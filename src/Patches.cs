using HarmonyLib;
using Il2Cpp;
using Il2CppTLD.AddressableAssets;
using Il2CppTLD.Gameplay.Tunable;
using Il2CppTLD.Gear;
using Il2CppTLD.SaveState;
using Il2CppTLD.Scenes;
using MelonLoader;
using UnityEngine;


namespace ChooseStartingLocation
{
    class Patches
    {
        [HarmonyPatch(typeof(GameManager), nameof(GameManager.LaunchSandbox))]
        internal class OverridePlayerSpawn
        {
            private static bool Prefix()
            {
                if (Settings.settings.modFunction == ModFunction.Disabled)
                    return true;

                ExperienceModeType xpMode = ExperienceModeManager.GetCurrentExperienceModeType();

                if (xpMode == ExperienceModeType.Pilgrim || xpMode == ExperienceModeType.Voyageur || xpMode == ExperienceModeType.Stalker || xpMode == ExperienceModeType.Interloper || xpMode == ExperienceModeType.Misery || xpMode == ExperienceModeType.Custom)
                {
                    SaveGameSlots.ClearAutoSave();
                    SaveGameSlotHelper.ClearSaveSlotsLists();

                    if (Settings.settings.modFunction == ModFunction.LocationList)
                    {
                        Implementation.startLocation = LocationList.GetLocation(Settings.settings.region);
                    }
                    else if (Settings.settings.modFunction == ModFunction.CustomCoords)
                    {
                        Implementation.startLocation = new Location("Custom Coords", (Region)Enum.Parse(typeof(CustomRegion), Settings.settings.customRegion.ToString()), Settings.settings.x, Settings.settings.y, Settings.settings.z, Settings.settings.rotationX, Settings.settings.rotationY);
                    }

                    RegionSpecification? regionSpecification = GetRegionSpecification(Implementation.startLocation.region.ToString());
                    if (regionSpecification == null)
                    {
                        // MelonLogger.Msg($"Failed to load RegionSpecification");
                        return true;
                    }
                    GameManager.m_StartRegion = regionSpecification;

                    string commandToRunAfterLoad = "mission_jump null false";

                    bool flag = GameManager.IsPlayingCustomXPGame();

                    InterfaceManager.GetPanel<Panel_Loading>().m_HoldScreenAfterLoad = true;
                    InterfaceManager.GetPanel<Panel_Loading>().m_ShowQuoteAfterLoad = flag;
                    InterfaceManager.GetPanel<Panel_Loading>().m_CommandToRunAfterLoad = commandToRunAfterLoad;
                    InterfaceManager.GetPanel<Panel_Loading>().m_SaveAfterLoad = flag;
                    UIInput.selection = null;
                    InterfaceManager.GetPanel<Panel_Inventory>().ResetFilter();
                    StatsManager.Reset();
                    InterfaceManager.GetPanel<Panel_Log>().Reset();
                    InterfaceManager.GetPanel<Panel_SprayPaint>().Reset();
                    InterfaceManager.GetPanel<Panel_HUD>().CleanupDamageEventTable();

                    var profile = BaseStateSingleton<ProfileState>.Instance;
                    if (profile != null)
                        profile.m_NumGamesPlayed++;

                    GameManager.FadeOutSceneAudio();

                    GameManager.m_SceneTransitionData = new SceneTransitionData();
                    GameManager.m_SceneTransitionData.m_GameRandomSeed = UnityEngine.Random.Range(int.MinValue, int.MaxValue);

                    GameManager.m_PendingSave = !flag;

                    GameManager.LoadSceneWithLoadingScreen(Implementation.startLocation.scene);

                    return false;
                }

                return true;
            }

            private static RegionSpecification? GetRegionSpecification(string regionName)
            {
                if (string.IsNullOrEmpty(regionName))
                    return null;

                if (AssetHelper.TryLoadAsset<RegionSpecification>(regionName, out RegionSpecification region))
                {
                    return region;
                }

                return null;
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
}



