using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.AddressableAssets;
using Il2CppTLD.Gameplay;
using Il2CppTLD.Gameplay.Tunable;
using Il2CppTLD.Gear;
using Il2CppTLD.Scenes;
using MelonLoader;
using UnityEngine;

namespace ChooseStartingLocation
{
    [HarmonyPatch(typeof(SandboxBaseConfig), nameof(SandboxBaseConfig.GetSpawnSceneSet))]
    internal static class OverridePlayerSpawn
    {
        private static bool Prefix(SandboxBaseConfig __instance, RegionSpecification region, ref SceneSet __result)
        {
            if (Settings.settings.modFunction == ModFunction.Disabled)
                return true;

            ExperienceModeType xpMode = ExperienceModeManager.GetCurrentExperienceModeType();

            if (!(xpMode == ExperienceModeType.Pilgrim ||
                  xpMode == ExperienceModeType.Voyageur ||
                  xpMode == ExperienceModeType.Stalker ||
                  xpMode == ExperienceModeType.Interloper ||
                  xpMode == ExperienceModeType.Misery ||
                  xpMode == ExperienceModeType.Custom))
            {
                return true;
            }

            if (Settings.settings.modFunction == ModFunction.LocationList)
            {
                Implementation.startLocation = LocationList.GetLocation(Settings.settings.region);
            }
            else if (Settings.settings.modFunction == ModFunction.CustomCoords)
            {
                Implementation.startLocation = new Location("Custom Coords", (Region)Enum.Parse(typeof(CustomRegion), Settings.settings.customRegion.ToString()),
                    Settings.settings.x,
                    Settings.settings.y,
                    Settings.settings.z,
                    Settings.settings.rotationX,
                    Settings.settings.rotationY
                );
            }

            if (Implementation.startLocation == null)
                return true;

            string sceneName = Implementation.startLocation.scene;

            if (string.IsNullOrEmpty(sceneName))
                return true;

            SceneSet sceneSet = SceneSetManager.FindSceneSetForSceneName(sceneName, true);

            if (sceneSet == null)
                return true;

            RegionSpecification? regionSpec = GetRegionSpecificationForLocation(Implementation.startLocation);

            __instance.m_ForceSceneLoad = sceneSet;
            __instance.m_ForceSpawnPoint = null;

            GameManager.m_ActiveSceneSet = sceneSet;

            if (sceneSet.IsOutdoors)
            {
                GameManager.m_LastOutdoorSceneSet = sceneSet;
            }
            else if (regionSpec != null)
            {
                SceneSet outdoorSceneSet = SceneSetManager.FindSceneSetForSceneName(regionSpec.name, true);

                if (outdoorSceneSet != null)
                    GameManager.m_LastOutdoorSceneSet = outdoorSceneSet;
            }

            if (regionSpec != null)
            {
                GameManager.m_StartRegion = regionSpec;
                regionSpec.Visit();
            }
            else if (GameManager.m_StartRegion == null && region != null)
            {
                GameManager.m_StartRegion = region;
            }

            __result = sceneSet;
            return false;
        }

        private static RegionSpecification? GetRegionSpecificationForLocation(Location location)
        {
            RegionSpecification? regionSpec = null;

            if (!string.IsNullOrEmpty(location.scene))
            {
                SceneSet sceneSet = SceneSetManager.FindSceneSetForSceneName(location.scene, true);

                if (sceneSet != null)
                {
                    string mappedRegion = InterfaceManager.GetRegionForScene(sceneSet.name);

                    if (!string.IsNullOrEmpty(mappedRegion))
                    {
                        AssetHelper.TryLoadAsset<RegionSpecification>(mappedRegion, out regionSpec);

                        if (regionSpec != null)
                            return regionSpec;
                    }
                }
            }

            AssetHelper.TryLoadAsset<RegionSpecification>(location.region.ToString(), out regionSpec);

            return regionSpec;
        }
    }


    [HarmonyPatch(typeof(Panel_Map), nameof(Panel_Map.Enable), typeof(bool), typeof(bool))]
    internal static class SetCorrectMapNameForRegion
    {
        private static void Postfix(Panel_Map __instance, bool enable, bool cameFromDetailSurvey)
        {
            if (!enable)
                return;

            if (Settings.settings.modFunction == ModFunction.Disabled)
                return;

            if (Implementation.startLocation == null)
                return;

            string sceneName = Implementation.startLocation.scene;

            if (string.IsNullOrEmpty(sceneName))
                return;

            if (GameManager.m_ActiveScene != sceneName)
                return;

            if (TrySelectMap(__instance, sceneName))
                return;

            string getRegionForScene = InterfaceManager.GetRegionForScene(sceneName);

            if (TrySelectMap(__instance, getRegionForScene))
                return;

            RegionSpecification? regionSpec = GetRegionSpecificationForLocation(Implementation.startLocation);

            if (regionSpec != null)
                TrySelectMap(__instance, regionSpec.name);
        }

        private static bool TrySelectMap(Panel_Map panelMap, string mapName)
        {
            if (panelMap == null || string.IsNullOrEmpty(mapName))
                return false;

            panelMap.UnlockRegionMap(mapName);

            int index = FindMapIndex(panelMap, mapName);

            if (index < 0)
                return false;

            panelMap.m_RegionSelectedIndex = index;
            panelMap.SetRegion(mapName);
            panelMap.ForceUpdateRegion();

            return true;
        }

        private static int FindMapIndex(Panel_Map panelMap, string name)
        {
            if (panelMap.m_UnlockedRegionNames == null || string.IsNullOrEmpty(name))
            {
                return -1;
            }

            for (int i = 0; i < panelMap.m_UnlockedRegionNames.Count; i++)
            {
                if (panelMap.m_UnlockedRegionNames[i] == name)
                    return i;
            }

            return -1;
        }

        private static RegionSpecification? GetRegionSpecificationForLocation(Location location)
        {
            RegionSpecification? regionSpec = null;

            AssetHelper.TryLoadAsset<RegionSpecification>(location.region.ToString(), out regionSpec);

            return regionSpec;
        }
    }
    
    
    [HarmonyPatch(typeof(StartGear), nameof(StartGear.AddAllToInventory))]
    internal class CustomStartingLocation
    {
        private static void Postfix()
        {
            if (GameManager.m_ActiveScene == "MainMenu") return;
            if (Settings.settings.modFunction == ModFunction.Disabled) return;

            if (!Implementation.startLocation.teleport)
            {
                //MelonLogger.Msg("Teleport flag FALSE for " + Implementation.startLocation.name);
                return;
            }

            //MelonLogger.Msg("TELEPORTING TO: " + Implementation.startLocation.name);

            if (Implementation.startLocation.position == Vector3.zero)
            {
                MelonLogger.Msg("ERROR: Location " + Implementation.startLocation.name + " has no coordinates!");
                return;
            }

            TeleportToSpawnPoint(Implementation.startLocation.position, Implementation.startLocation.rotation);
            GameManager.GetPlayerManagerComponent().StickPlayerToGround();
        }

        public static void TeleportToSpawnPoint(Vector3 position, Quaternion rotation)
        {
            ExperienceModeType xpMode = ExperienceModeManager.GetCurrentExperienceModeType();

            GameManager.GetPlayerManagerComponent().TeleportPlayer(position, rotation);

            if (xpMode == ExperienceModeType.Custom)
            {
                if (GameManager.GetCustomMode().m_StartWeather == CustomTunableWeather.Blizzard)
                {
                    GameManager.GetWeatherTransitionComponent().ActivateWeatherSetAtFrac(WeatherStage.Blizzard, 0.5f);
                }
                else if (GameManager.GetCustomMode().m_StartWeather == CustomTunableWeather.Clear)
                {
                    GameManager.GetWeatherTransitionComponent().ActivateWeatherSetAtFrac(WeatherStage.Clear, 0.5f);
                }
                else if (GameManager.GetCustomMode().m_StartWeather == CustomTunableWeather.DenseFog)
                {
                    GameManager.GetWeatherTransitionComponent().ActivateWeatherSetAtFrac(WeatherStage.DenseFog, 0.5f);
                }
                else if (GameManager.GetCustomMode().m_StartWeather == CustomTunableWeather.HeavySnow)
                {
                    GameManager.GetWeatherTransitionComponent().ActivateWeatherSetAtFrac(WeatherStage.HeavySnow, 0.5f);
                }
                else if (GameManager.GetCustomMode().m_StartWeather == CustomTunableWeather.LightFog)
                {
                    GameManager.GetWeatherTransitionComponent().ActivateWeatherSetAtFrac(WeatherStage.LightFog, 0.5f);
                }
                else if (GameManager.GetCustomMode().m_StartWeather == CustomTunableWeather.LightSnow)
                {
                    GameManager.GetWeatherTransitionComponent().ActivateWeatherSetAtFrac(WeatherStage.LightSnow, 0.5f);
                }
                else if (GameManager.GetCustomMode().m_StartWeather == CustomTunableWeather.Random)
                {
                    GameManager.GetStartSettingsComponent().SetWeather();
                }
                if (GameManager.GetCustomMode().m_StartTimeOfDay == CustomTunableTimeOfDay.Dawn)
                {
                    GameManager.GetTimeOfDayComponent().SetNormalizedTime(0.28f);
                }
                else if (GameManager.GetCustomMode().m_StartTimeOfDay == CustomTunableTimeOfDay.Noon)
                {
                    GameManager.GetTimeOfDayComponent().SetNormalizedTime(0.5f);
                }
                else if (GameManager.GetCustomMode().m_StartTimeOfDay == CustomTunableTimeOfDay.Dusk)
                {
                    GameManager.GetTimeOfDayComponent().SetNormalizedTime(0.78f);
                }
                else if (GameManager.GetCustomMode().m_StartTimeOfDay == CustomTunableTimeOfDay.Midnight)
                {
                    GameManager.GetTimeOfDayComponent().SetNormalizedTime(0f);
                }
                else if (GameManager.GetCustomMode().m_StartTimeOfDay == CustomTunableTimeOfDay.Random)
                {
                    GameManager.GetStartSettingsComponent().SetRandomTime();
                }
            }
            else
            {
                GameManager.GetStartSettingsComponent().SetTime();
                GameManager.GetStartSettingsComponent().SetWeather();
            }
        }
    }
}