using MelonLoader;

namespace ChooseStartingLocation
{
    public enum Region
    {
        AshCanyonRegion, BlackrockRegion, /*BlackrockPrisonSurvivalZone,*/ CanneryRegion, TracksRegion, CoastalRegion, HighwayTransitionZone, WhalingStationRegion, MarshRegion, AirfieldRegion, RiverValleyRegion, BlackrockTransitionZone,
        CanyonRoadTransitionZone, MountainTownRegion, LakeRegion, RuralRegion, RavineTransitionZone, MountainPassRegion, CrashMountainRegion, HubRegion, DamRiverTransitionZoneB, MiningRegion, Random,
    }
    public enum CustomRegion
    {
        AshCanyonRegion, BlackrockRegion, /*BlackrockPrisonSurvivalZone,*/ CanneryRegion, TracksRegion, CoastalRegion, HighwayTransitionZone, WhalingStationRegion, MarshRegion, AirfieldRegion, RiverValleyRegion, BlackrockTransitionZone,
        CanyonRoadTransitionZone, MountainTownRegion, LakeRegion, RuralRegion, RavineTransitionZone, MountainPassRegion, CrashMountainRegion, HubRegion, DamRiverTransitionZoneB, MiningRegion
    }
    public enum AshCanyonLocation
    {
        AnglersDen, BitterMarsh, BroadFalls, Cave, CaveTWM, ClimbersCave, FireOverlook, ForemansRetreat, GoldMine, HighCamp, HighMeadow, HomesteadersRespite, LongFalls, MinersFolly, MiningCamp, NarrowFallsCave, PillarsFootrest,
        RunawayBridge, SecludedCamp, ShatteredCove, ShelteredCamp, StoneShelfCave, ViewpointCamp, WolfsJawOverlook, Random
    }
    public enum BlackrockLocation
    {
        BearsBend, BlockedBridge, BricklayersRetreat, CliffCave, CooksFarm, CreekBedCave, CuttysCave, FoolsCorner, ForagersRemnant, ForemansClearcut, GrandMeadow, JailersResidence, LastProspect, LineworkersHideout,
        MuleBridgeLower, MuleBridgeUpper, NarrowBridge, NoRoadCave, OldSubstation, PowerPlant, SteamTunnels, Trailer, WedgeCave, WhistlingPerch, Random
    }
    /*public enum BlackrockPrisonLocation
    {
        Cells, Gatehouse, GuardRoom, HidingSpot, Infirmary, MaintenanceShed, Rooftop, StaffQuarters, SteamTunnels, WardensOffice, Watchtower, Random
    }*/

    public enum BleakInletLocation
    {
        Cabin, CanneryPier, CanneryWorkerResidences, CanneryWorkshop, CaveCentral, CaveNorthEast, CaveSouthEast, CaveSouthWest, CaveWest, CaveFM, CoastalHighwayTerminus, CoastMountainRoad, EchoOneRadioTower,
        FallenLighthouse, FrozenDelta, HuntersBlindEast, HuntersBlindNorth, HuntersBlindWest, Landslide, LastResortCannery, LongBridge, LowerRavenFalls, PensiveLookout, RavenCrossing, RavinesEndWaterfall, SecretMountainPath,
        SummitAtRavinesEnd, Trailer, Trailers, WashedOutTrailers, Random
    }
    public enum BrokenRailroadLocation
    {
        BrokenBridge, Cave, HuntersBlind, HuntingLodge, Landslide, LocomotiveEngine, MaintenanceShed, RicketyFootBridge, Random
    }
    public enum CoastalHighwayLocation
    {
        AbandonedLookout, BearCreekCampground, CinderHillsCoalMineLower, CinderHillsCoalMineMiddle, CinderHillsCoalMineUpper, CoastalTownsite, CommutersLament, FishingCamp, JackrabbitIsland, LogSort, MisanthropesHomestead,
        QuonsetGarage, RabbitGrove, Rockfall, SilentClearing, TheTooth, TrainUnloading, WaterfrontCottages, Random
    }
    public enum CrumblingHighwayLocation
    {
        AbandonedHarrisHome, AbandonedMineNo3, Cave, RoadCollapse, TheArch, Random
    }
    public enum DesolationPointLocation
    {
        AbandonedMineNo3, AbandonedMineNo5, BlockedHighway, BrokenBridge, Cave, HiberniaProcessing, KatiesSecludedCorner, LittleIsland, LonelyLighthouse, MattsTruck, StoneChurch, TheRiken, TrailersinSShape, Waterfall, Random
    }
    public enum ForlornMuskegLocation
    {
        Bunkhouses, Cave, CaveBI, HatCreek, HighBlind, LowBlind, MarshRidge, MuskegOverlook, OldSpenceFamilyHomestead, PoachersCamp, PrepperCache, ShortwaveTower, Waterfall, Random
    }
    public enum ForsakenAirfieldLocation
    {
        ControlTower, IslandCottage, JustysHovel, MindfulCabin, Random
    }
    public enum HushedRiverValleyLocation
    {
        BannerFalls, CaveMT, CloudtopFalls, ForestKnoll, IceCaveNorth, IceCaveSouth, LakeCave, Landslide, LittleBearandCubFalls, LonelyCave, LongShotFalls, MammothFalls, ManyFallsVista, MonolithLake, MooseOverlook, MysteriousSignalFire,
        OffsetFalls, PeakCave, PensiveVista, QuarrellingFalls, ReclusiveFalls, RiversideCamp, SecludedCamp, StairstepsLake, TwinSistersFalls, ValleyCave, ValleyViewPoint, VistaCamp, WatchfulFalls, Random
    }
    public enum KeepersPassNorthLocation
    {
        BuildersBridge, CaveKPS, ForestersHermitage, Random
    }
    public enum KeepersPassSouthLocation
    {
        CaveKPN, FishingHut, MirthlessFork, ScenicView, TheToe, Random
    }
    public enum MountainTownLocation
    {
        CaveClimbingArea, CaveDeep, CaveRadioTower, CaveHRV, CaveML, CrashedPlane, CrashedPrisonTransportBus, Graveyard, GreyMothersHouse, HermitsCabin, MiltonBasin, MiltonCreditUnion, MiltonHouse, MiltonPark, MiltonPostOffice,
        OldSchoolhouse, OrcaGasStation, ParadiseMeadowsFarm, ParkOffice, PicnicArea, PrepperCache, RadioTower, RockyRefuge, SideOfTheRoad, SpruceFallsBridge, StChristophersChurch, TheArch, TownOfMilton, Trailer, WoodLotNorth, WoodLotSouthEast,
        WoodLotSouthWest, Random
    }
    public enum MysteryLakeLocation
    {
        AlansCave, CampOffice, CarterHydroDam, CaveMT, CaveUnnamed, Clearcut, DavesQuietClearing, DeadfallArea, Derailment, DestroyedLookout, ForestryLookout, FrozenCreek, HuntersBlindatAlansCave, IceFishingHuts, LakeCabin,
        LakeCabinsSE, LakeCabinsSW, LakeOverlook, LoggingCamp, Lookout, MaxsLastStand, PrepperCache, RailTunnel, RiverNorthernAccess, RiverSouthernAccess, MysteryLake, MysteryLakeWesternAccess, TrainBridge, TrainLoadingArea, TrappersCabin,
        UnnamedPond, Random
    }
    public enum PleasantValleyLocation
    {
        BarnLarge, BarnSmall, BurnedRidgeCave, CascadingFalls, Cave, CaveWR, Church, CinderHillsCoalMine, CommunityHall, ContemplationBridge, CrashSite, DerelictCabins, DraftDodgersCabin, EndoftheRoad, ForestCave, HeartbreakBridge,
        HilltopCave, HuntersBlindEast, HuntersBlindWest, LonelyHomestead, LongCurve, LowerFalls, MistyFallsPicnicArea, PensivePond, PicnicSpot, PleasantValleyFarmstead, PleasantValleyOutbuildings, PointofDisagreement,
        PreppersAbandonedCache, RadioControlHut, SignalHill, SkeetersRidge, ThomsonsCrossing, ThreeStrikesFarmstead, UpperFalls, Random
    }
    public enum RavineLocation
    {
        CaveLower, CaveUpper, RavenFallsTrestle, RavineBasin, ShuntingYard, TrainCar, Random
    }
    public enum SunderedPassLocation
    {
        FinalRefuge, LastLonelyHouse, LottesRest, WeatherStation, Random
    }
    public enum TimberwolfMountainLocation
    {
        AndresPeak, CaveLargeOpen, CaveLower, CaveUpper, CaveUnnamed, CaveAC, ChasmCave, CrystalLake, DeerClearing, EchoPeakEast, EchoPeakWest, EchoRavine, Engine, EricsFalls, ForestCave, LandingGear, MountaineersHut,
        SecludedShelf, Summit, SummitCave, TailSection, WaterfallCave, Wing, Random
    }
    public enum TransferPassLocation
    {
        VacantDepot, Random
    }
    public enum WindingRiverLocation
    {
        Cave, CavePV, Dam, Hilltop, ShelteredSpot, Random
    }
    public enum ZoneOfContaminationLocation
    {
        IdleCamp, Mine, Trailer, Random
    }

    class LocationList
    {
        public static Location GetLocation(Region region)
        {
            switch (region)
            {
                case Region.AshCanyonRegion:
                    return GetAshCanyonLocation(Settings.settings.ashCanyonLocation);
                case Region.BlackrockRegion:
                    return GetBlackrockLocation(Settings.settings.blackrockLocation);
                /*case Region.BlackrockPrisonSurvivalZone:
                    return GetBlackrockPrisonLocation(Settings.settings.blackrockPrisonLocation);*/
                case Region.CanneryRegion:
                    return GetBleakInletLocation(Settings.settings.bleakInletLocation);
                case Region.TracksRegion:
                    return GetBrokenRailroadLocation(Settings.settings.brokenRailroadLocation);
                case Region.CoastalRegion:
                    return GetCoastalHighwayLocation(Settings.settings.coastalHighwayLocation);
                case Region.HighwayTransitionZone:
                    return GetCrumblingHighwayLocation(Settings.settings.crumblingHighwayLocation);
                case Region.WhalingStationRegion:
                    return GetDesolationPointLocation(Settings.settings.desolationPointLocation);
                case Region.MarshRegion:
                    return GetForlornMuskegLocation(Settings.settings.forlornMuskegLocation);
                case Region.AirfieldRegion:
                    return GetForsakenAirFieldLocation(Settings.settings.forsakenAirfieldLocation);
                case Region.RiverValleyRegion:
                    return GetHushedRiverValleyLocation(Settings.settings.hushedRiverValleyLocation);
                case Region.BlackrockTransitionZone:
                    return GetKeepersPassNorthLocation(Settings.settings.keepersPassNorthLocation);
                case Region.CanyonRoadTransitionZone:
                    return GetKeepersPassSouthLocation(Settings.settings.keepersPassSouthLocation);
                case Region.MountainTownRegion:
                    return GetMountainTownLocation(Settings.settings.mountainTownLocation);
                case Region.LakeRegion:
                    return GetMysteryLakeLocation(Settings.settings.mysteryLakeLocation);
                case Region.RuralRegion:
                    return GetPleasantValleyLocation(Settings.settings.pleasantValleyLocation);
                case Region.RavineTransitionZone:
                    return GetRavineLocation(Settings.settings.ravineLocation);
                case Region.MountainPassRegion:
                    return GetSunderedPassLocation(Settings.settings.sunderedPassLocation);
                case Region.CrashMountainRegion:
                    return GetTimberwolfMountainLocation(Settings.settings.timberwolfMountainLocation);
                case Region.HubRegion:
                    return GetTransferPassLocation(Settings.settings.transferPassLocation);
                case Region.DamRiverTransitionZoneB:
                    return GetWindingRiverLocation(Settings.settings.windingRiverLocation);
                case Region.MiningRegion:
                    return GetZoneOfContaminationLocation(Settings.settings.zoneOfContminationLocation);
                case Region.Random:
                    return GetLocation(RandomRegion());
                default:
                    MelonLogger.Msg("ERROR: GetLocation switch fell through! Returning DEFAULT location (Camp Office at Mystery Lake)");
                    return new Location("Camp Office", "CampOffice", Region.LakeRegion, true, false);
            }
        }

        public static Region RandomRegion()
        {
            Region randomRegion = (Region)UnityEngine.Random.Range(0, Enum.GetNames(typeof(Region)).Length - 1);
            MelonLogger.Msg("RandomRegion Selected: " + randomRegion.ToString());
            if (randomRegion == Region.Random)
            {
                MelonLogger.Msg("ERROR: RandomRegion produced Region.Random! Returning DEFAULT region (Mystery Lake)!");
                return Region.LakeRegion;
            }
            return randomRegion;
        }

        public static Location GetAshCanyonLocation(AshCanyonLocation location)
        {
            switch (location)
            {
                case AshCanyonLocation.AnglersDen:
                    return new Location("Angler's Den", "AshCabinF", Region.AshCanyonRegion, true, false);
                case AshCanyonLocation.BitterMarsh:
                    return new Location("Bitter Marsh", Region.AshCanyonRegion, 631.7f, 53.0f, -419.7f, 89.3f, -10.6f);
                case AshCanyonLocation.BroadFalls:
                    return new Location("Broad Falls", Region.AshCanyonRegion, -228.5f, 72.0f, 390.6f, 350.7f, -50.3f);
                case AshCanyonLocation.Cave:
                    return new Location("Cave", "AshCaveB", Region.AshCanyonRegion, true, true, 48.6f, 18.6f, -15.0f, 354.7f, 15.5f);
                case AshCanyonLocation.CaveTWM:
                    return new Location("Cave to Timberwolf Moutain", "AshCaveA", Region.AshCanyonRegion, true, true, 15.1f, -4.2f, 56.6f, 11.4f, 19.0f);
                case AshCanyonLocation.ClimbersCave:
                    return new Location("Climber's Cave", Region.AshCanyonRegion, -98.2f, 135.0f, -355.1f, 64.7f, 1.9f);
                case AshCanyonLocation.FireOverlook:
                    return new Location("Fire Overlook", Region.AshCanyonRegion, 648.4f, 180.5f, -225.9f, 246.4f, 0.8f);
                case AshCanyonLocation.ForemansRetreat:
                    return new Location("Foreman's Retreat", "WoodCabinB", Region.AshCanyonRegion, true, false);
                case AshCanyonLocation.GoldMine:
                    return new Location("Gold Mine", "AshMine", Region.AshCanyonRegion, true, true, -135.2f, -55.3f, 229.5f, 333.7f, 25.1f);
                case AshCanyonLocation.HighCamp:
                    return new Location("High Camp", Region.AshCanyonRegion, 487.6f, 220.8f, 1.3f, 274.0f, -3.6f);
                case AshCanyonLocation.HighMeadow:
                    return new Location("High Meadow", Region.AshCanyonRegion, 150.2f, 227.4f, 48.5f, 314.3f, -3.0f);
                case AshCanyonLocation.HomesteadersRespite:
                    return new Location("Homesteader's Respite", "AshWoodCabinA", Region.AshCanyonRegion, true, false);
                case AshCanyonLocation.LongFalls:
                    return new Location("Long Falls", Region.AshCanyonRegion, -365.2f, 162.4f, 719.2f, 288.9f, -68.7f);
                case AshCanyonLocation.MinersFolly:
                    return new Location("Miner's Folly", "AshCabinD", Region.AshCanyonRegion, true, false);
                case AshCanyonLocation.MiningCamp:
                    return new Location("Mining Camp", Region.AshCanyonRegion, -584.9f, 295.0f, 722.5f, 311.2f, -4.4f);
                case AshCanyonLocation.NarrowFallsCave:
                    return new Location("Narrow Falls Cave", Region.AshCanyonRegion, 543.3f, 105.1f, 549.0f, 184.1f, 9.8f);
                case AshCanyonLocation.PillarsFootrest:
                    return new Location("Pillar's Footrest", Region.AshCanyonRegion, -359.9f, 84.9f, -669.6f, 114.4f, -21.6f);
                case AshCanyonLocation.RunawayBridge:
                    return new Location("Runaway Bridge", Region.AshCanyonRegion, -259.4f, 199.5f, 82.4f, 131.8f, 2.1f);
                case AshCanyonLocation.SecludedCamp:
                    return new Location("Secluded Camp", Region.AshCanyonRegion, -750.2f, 215.1f, 6.7f, 65.8f, -1.5f);
                case AshCanyonLocation.ShatteredCove:
                    return new Location("Shattered Cove", Region.AshCanyonRegion, 214.8f, 43.6f, -668.8f, 70.9f, -19.9f);
                case AshCanyonLocation.ShelteredCamp:
                    return new Location("Sheltered Camp", Region.AshCanyonRegion, -271.9f, 152.9f, -550.9f, 3213.9f, -31.1f);
                case AshCanyonLocation.StoneShelfCave:
                    return new Location("Stone Shelf Cave", Region.AshCanyonRegion, -714.3f, 131.1f, 154.1f, 96.2f, -7.2f);
                case AshCanyonLocation.ViewpointCamp:
                    return new Location("Viewpoint Camp", Region.AshCanyonRegion, 12.9f, 278.0f, 619.9f, 281.4f, -9.0f);
                case AshCanyonLocation.WolfsJawOverlook:
                    return new Location("Wolf's Jaw Overlook", Region.AshCanyonRegion, -316.3f, 355.8f, 364.9f, 184.0f, 5.1f);
                case AshCanyonLocation.Random:
                    Location randomLocation = GetAshCanyonLocation((AshCanyonLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(AshCanyonLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetAshCanyonLocation switch fell through! Returning DEFAULT location (Angler's Den)");
                    return GetAshCanyonLocation(AshCanyonLocation.AnglersDen);
            }
        }

        public static Location GetBlackrockLocation(BlackrockLocation location)
        {
            switch (location)
            {
                case BlackrockLocation.BearsBend:
                    return new Location("Bears Bend", Region.BlackrockRegion, -922.4f, 77.1f, -149.1f, 328.5f, -10.4f);
                case BlackrockLocation.BlockedBridge:
                    return new Location("Blocked Bridge", Region.BlackrockRegion, -308.8f, 159.9f, -812.7f, 7.7f, -2.6f);
                case BlackrockLocation.BricklayersRetreat:
                    return new Location("Bricklayer's Retreat", Region.BlackrockRegion, 903.2f, 233.3f, -98.8f, 270.5f, 5.4f);
                case BlackrockLocation.CliffCave:
                    return new Location("Cliff Cave", Region.BlackrockRegion, 530.8f, 242.7f, 304.6f, 198.1f, 5.4f);
                case BlackrockLocation.CooksFarm:
                    return new Location("Cooks Farm", Region.BlackrockRegion, 195.7f, 181.0f, -257.3f, 307.7f, -3.5f);
                case BlackrockLocation.CreekBedCave:
                    return new Location("Creek Bed Cave", Region.BlackrockRegion, -1087.4f, 112.5f, -342.2f, 111.9f, 6.4f);
                case BlackrockLocation.CuttysCave:
                    return new Location("Cutty's Cave", Region.BlackrockRegion, 486.2f, 186.7f, -560.7f, 257.4f, 7.3f);
                case BlackrockLocation.FoolsCorner:
                    return new Location("Fool's Corner", Region.BlackrockRegion, 649.6f, 326.5f, 700.8f, 164.3f, -8.2f);
                case BlackrockLocation.ForagersRemnant:
                    return new Location("Forager's Remnant", Region.BlackrockRegion, -809.4f, 101.4f, 436.8f, 220.9f, -11.2f);
                case BlackrockLocation.ForemansClearcut:
                    return new Location("Foreman's Clearcut", Region.BlackrockRegion, 480.1f, 213.1f, -215.2f, 251.8f, -0.9f);
                case BlackrockLocation.GrandMeadow:
                    return new Location("Grand Meadow", Region.BlackrockRegion, -621.8f, 85.3f, 384.2f, 313.1f, -16.6f);
                case BlackrockLocation.JailersResidence:
                    return new Location("Jailer's Residence", Region.BlackrockRegion, -101.2f, 122.0f, -685.2f, 142.7f, 2.8f);
                case BlackrockLocation.LastProspect:
                    return new Location("Last Prospect", Region.BlackrockRegion, 478.2f, 364.2f, 930.7f, 197.9f, -3.6f);
                case BlackrockLocation.LineworkersHideout:
                    return new Location("Lineworker's Hideout", Region.BlackrockRegion, -654.1f, 107.0f, -631.1f, 29.9f, 0.7f);
                case BlackrockLocation.MuleBridgeLower:
                    return new Location("Mule Bridge (Lower)", Region.BlackrockRegion, 583.6f, 201.4f, 873.2f, 21.6f, -84.3f);
                case BlackrockLocation.MuleBridgeUpper:
                    return new Location("Mule Bridge (Upper)", Region.BlackrockRegion, 626.5f, 363.7f, 845.8f, 285.8f, 4.9f);
                case BlackrockLocation.NarrowBridge:
                    return new Location("Narrow Bridge", Region.BlackrockRegion, -757.7f, 87.1f, -495.1f, 295.7f, 11.1f);
                case BlackrockLocation.NoRoadCave:
                    return new Location("No Road Cave", Region.BlackrockRegion, 804.9f, 310.5f, 705.9f, 230.2f, 18.7f);
                case BlackrockLocation.OldSubstation:
                    return new Location("Old Substation", "RadioControlHutC", Region.BlackrockRegion, true, false);
                case BlackrockLocation.PowerPlant:
                    return new Location("Power Plant", "BlackrockPowerplantA", Region.BlackrockRegion, true, true, 8.5f, 1.8f, 3.4f, 178.7f, 2.4f);
                case BlackrockLocation.SteamTunnels:
                    return new Location("Steam Tunnels", "BlackrockSteamTunnelsASurvival", Region.BlackrockRegion, true, true, 14.4f, 2.1f, 5.2f, 147.2f, 14.4f);
                case BlackrockLocation.Trailer:
                    return new Location("Trailer", "BlackRockTrailerB", Region.BlackrockRegion, true, false);
                case BlackrockLocation.WedgeCave:
                    return new Location("Wedge Cave", Region.BlackrockRegion, 1091.2f, 303.6f, 543.2f, 258.0f, -4.3f);
                case BlackrockLocation.WhistlingPerch:
                    return new Location("Whistling Perch", Region.BlackrockRegion, 854.9f, 309.9f, 359.9f, 190.1f, -8.1f);
                case BlackrockLocation.Random:
                    Location randomLocation = GetBlackrockLocation((BlackrockLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(BlackrockLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetBlackrockLocation switch fell through! Returning DEFAULT location (Old Substation)");
                    return GetBlackrockLocation(BlackrockLocation.OldSubstation);
            }
        }

        /*public static Location GetBlackrockPrisonLocation(BlackrockPrisonLocation location)
        {
            switch (location)
            {
                case BlackrockPrisonLocation.Cells:
                    return new Location("Cells", "BlackrockInteriorASurvival", Region.BlackrockPrisonSurvivalZone, true, true, 50.2f, 1.9f, 4.9f, 359.1f, 6.8f);
                case BlackrockPrisonLocation.Gatehouse:
                    return new Location("Gatehouse", "BlackrockPrisonSurvivalZone", Region.BlackrockPrisonSurvivalZone, false, true, -189.5f, 227.6f, 4.6f, 353.0f, 20.7f);
                case BlackrockPrisonLocation.GuardRoom:
                    return new Location("Guard Room", "BlackrockInteriorASurvival", Region.BlackrockPrisonSurvivalZone, true, true, 30.9f, 1.9f, 5.6f, 89.8f, 23.3f);
                case BlackrockPrisonLocation.HidingSpot:
                    return new Location("Hiding Spot", "BlackrockInteriorASurvival", Region.BlackrockPrisonSurvivalZone, true, true, -8.9f, 1.8f, -24.4f, 297.8f, 46.3f);
                case BlackrockPrisonLocation.Infirmary:
                    return new Location("Infirmary", "BlackrockPrisonSurvivalZone", Region.BlackrockPrisonSurvivalZone, false, true, -147.9f, 230.7f, 81.8f, 335.1f, 16.2f);
                case BlackrockPrisonLocation.MaintenanceShed:
                    return new Location("Maintenance Shed", "BlackrockPrisonSurvivalZone", Region.BlackrockPrisonSurvivalZone, false, true, -81.2f, 227.6f, 41.6f, 154.4f, 15.4f);
                case BlackrockPrisonLocation.Rooftop:
                    return new Location("Rooftop", "BlackrockPrisonSurvivalZone", Region.BlackrockPrisonSurvivalZone, false, true, -143.5f, 231.3f, 81.9f, 228.6f, 11.2f);
                case BlackrockPrisonLocation.StaffQuarters:
                    return new Location("Staff Quarters", "BlackrockPrisonSurvivalZone", Region.BlackrockPrisonSurvivalZone, false, true, -111.3f, 227.1f, 110.7f, 138.4f, 7.9f);
                case BlackrockPrisonLocation.SteamTunnels:
                    return new Location("Steam Tunnels", "BlackrockSteamTunnelsASurvival", Region.BlackrockPrisonSurvivalZone, true, true, 14.4f, 2.1f, 5.2f, 147.2f, 14.4f);
                case BlackrockPrisonLocation.WardensOffice:
                    return new Location("Warden's Office", "BlackrockPrisonSurvivalZone", Region.BlackrockPrisonSurvivalZone, false, true, -234.6f, 235.7f, 154.0f, 249.4f, 10.5f);
                case BlackrockPrisonLocation.Watchtower:
                    return new Location("Watchtower", "BlackrockPrisonSurvivalZone", Region.BlackrockPrisonSurvivalZone, false, true, -143.2f, 235.2f, 109.4f, 216.5f, 1.7f);
                case BlackrockPrisonLocation.Random:
                    Location randomLocation = GetBlackrockPrisonLocation((BlackrockPrisonLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(BlackrockPrisonLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetBlackrockPrisonLocation switch fell through! Returning DEFAULT location (Cells)");
                    return GetBlackrockPrisonLocation(BlackrockPrisonLocation.Cells);
            }
        }*/

        public static Location GetBleakInletLocation(BleakInletLocation location)
        {
            switch (location)
            {
                case BleakInletLocation.Cabin:
                    return new Location("Cabin", "WoodCabinC", Region.CanneryRegion, true, false);
                case BleakInletLocation.CanneryPier:
                    return new Location("CanneryPier", Region.CanneryRegion, -410.5f, 33.6f, -586.2f, 27.6f, -10.8f);
                case BleakInletLocation.CanneryWorkerResidences:
                    return new Location("Cannery Worker Residences", "WoodCabinA", Region.CanneryRegion, true, false);
                case BleakInletLocation.CanneryWorkshop:
                    return new Location("Cannery Workshop", "MaintenanceShedB", Region.CanneryRegion, true, false);
                case BleakInletLocation.CaveCentral:
                    return new Location("Cave (Central)", Region.CanneryRegion, -57.0f, 56.4f, 267.1f, 148.1f, 16.9f);
                case BleakInletLocation.CaveNorthEast:
                    return new Location("Cave (North East)", Region.CanneryRegion, 527.4f, 276.6f, 760.8f, 225.2f, 9.8f);
                case BleakInletLocation.CaveSouthEast:
                    return new Location("Cave (South East)", Region.CanneryRegion, 510.3f, 40.5f, -521.0f, 274.1f, 6.4f);
                case BleakInletLocation.CaveSouthWest:
                    return new Location("Cave (South West)", Region.CanneryRegion, -966.2f, 38.0f, -749.7f, 101.0f, 1.6f);
                case BleakInletLocation.CaveWest:
                    return new Location("Cave (West)", Region.CanneryRegion, -990.8f, 65.8f, 438.0f, 109.9f, 8.9f);
                case BleakInletLocation.CaveFM:
                    return new Location("Cave to Forlorn Muskeg", "CanneryMarshTransitionCave", Region.CanneryRegion, true, true, -20.7f, 38.1f, 5.0f, 239.3f, -82.6f);
                case BleakInletLocation.CoastalHighwayTerminus:
                    return new Location("Coastal Highway Terminus", Region.CanneryRegion, -1038.2f, 52.6f, -259.5f);
                case BleakInletLocation.CoastMountainRoad:
                    return new Location("Coast Mountain Road", Region.CanneryRegion, 186.9f, 92.2f, 179.6f, 210.2f, 3.2f);
                case BleakInletLocation.EchoOneRadioTower:
                    return new Location("Echo One Radio Tower", "RadioControlHutB", Region.CanneryRegion, true, false);
                case BleakInletLocation.FallenLighthouse:
                    return new Location("Fallen Lighthouse", Region.CanneryRegion, 74.1f, 84.7f, -919.2f, 55.8f, 27.6f);
                case BleakInletLocation.FrozenDelta:
                    return new Location("Frozen Delta", Region.CanneryRegion, -413.2f, 59.3f, 282.8f, 163.5f, -3.6f);
                case BleakInletLocation.HuntersBlindEast:
                    return new Location("Hunter's Blind (East)", Region.CanneryRegion, -365.3f, 59.4f, 412.9f, 258.4f, -1.2f);
                case BleakInletLocation.HuntersBlindNorth:
                    return new Location("Hunter's Blind (North", Region.CanneryRegion, -573.6f, 86.2f, 709.9f, 119.9f, 2.0f);
                case BleakInletLocation.HuntersBlindWest:
                    return new Location("Hunter's Blind (West)", Region.CanneryRegion, -1030.8f, 57.8f, 102.1f, 63.3f, 1.8f);
                case BleakInletLocation.Landslide:
                    return new Location("Landslide", Region.CanneryRegion, 671.2f, 67.8f, -272.9f, 134.5f, -10.7f);
                case BleakInletLocation.LastResortCannery:
                    return new Location("Last Resort Cannery", Region.CanneryRegion, -439.5f, 34.0f, -466.0f, 128.3f, -4.8f);
                case BleakInletLocation.LongBridge:
                    return new Location("Long Bridge", Region.CanneryRegion, -182.8f, 51.5f, -352.3f, 227.6f, 0.1f);
                case BleakInletLocation.LowerRavenFalls:
                    return new Location("Lower Raven Falls", Region.CanneryRegion, 782.9f, 118.2f, 426.3f, 39.8f, -37.0f);
                case BleakInletLocation.PensiveLookout:
                    return new Location("Pensive Lookout", Region.CanneryRegion, 298.2f, 240.8f, 349.8f, 217.0f, 17.2f);
                case BleakInletLocation.RavenCrossing:
                    return new Location("Raven Crossing", Region.CanneryRegion, 491.1f, 63.5f, -128.2f, 241.5f, -0.9f);
                case BleakInletLocation.RavinesEndWaterfall:
                    return new Location("Ravine's End Waterfall", Region.CanneryRegion, -77.2f, 109.9f, 544.2f, 71.5f, -32.1f);
                case BleakInletLocation.SecretMountainPath:
                    return new Location("Secret Mountain Path", Region.CanneryRegion, -21.8f, 132.8f, 517.3f, 198.0f, 37.0f);
                case BleakInletLocation.SummitAtRavinesEnd:
                    return new Location("Summit at Ravine's End", Region.CanneryRegion, 228.8f, 346.8f, 958.7f, 190.1f, 10.8f);
                case BleakInletLocation.Trailer:
                    return new Location("Trailer in Cannery", "CanneryTrailerA", Region.CanneryRegion, true, false);
                case BleakInletLocation.Trailers:
                    return new Location("Trailers West of Cannery", Region.CanneryRegion, -756.9f, 38.1f, -390.8f, 137.7f, 2.6f);
                case BleakInletLocation.WashedOutTrailers:
                    return new Location("Washed-Out Trailers", Region.CanneryRegion, -645.3f, 35.0f, -92.5f, 22.0f, -2.2f);
                case BleakInletLocation.Random:
                    Location randomLocation = GetBleakInletLocation((BleakInletLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(BleakInletLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetBleakInletLocation switch fell through! Returning DEFAULT location (Last Resort Cannery)");
                    return GetBleakInletLocation(BleakInletLocation.LastResortCannery);
            }
        }

        public static Location GetBrokenRailroadLocation(BrokenRailroadLocation location)
        {
            switch (location)
            {
                case BrokenRailroadLocation.BrokenBridge:
                    return new Location("Broken Bridge", Region.TracksRegion, 822.9f, 236.8f, 377.8f, 219.4f, 2.6f);
                case BrokenRailroadLocation.Cave:
                    return new Location("Cave", Region.TracksRegion, -165.2f, 250.9f, 863.6f, 131.5f, -3.8f);
                case BrokenRailroadLocation.HuntersBlind:
                    return new Location("Hunter's Blind", Region.TracksRegion, 254.6f, 189.7f, 574.6f, 61.8f, 0.9f);
                case BrokenRailroadLocation.HuntingLodge:
                    return new Location("Hunting Lodge", "HuntingLodgeA", Region.TracksRegion, true, false);
                case BrokenRailroadLocation.Landslide:
                    return new Location("Landslide", Region.TracksRegion, 667.3f, 235.6f, 1212.9f, 359.0f, -4.8f);
                case BrokenRailroadLocation.LocomotiveEngine:
                    return new Location("Locomotive Engine", Region.TracksRegion, 815.3f, 236.3f, 828.9f, 152.3f, -5.9f);
                case BrokenRailroadLocation.MaintenanceShed:
                    return new Location("Maintenance Shed", Region.TracksRegion, 580.9f, 200.7f, 559.8f, 262.1f, -4.8f);
                case BrokenRailroadLocation.RicketyFootBridge:
                    return new Location("Rickety Foot Bridge", Region.TracksRegion, 272.6f, 249.7f, 946.7f, 197.3f, 3.1f);
                case BrokenRailroadLocation.Random:
                    Location randomLocation = GetBrokenRailroadLocation((BrokenRailroadLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(BrokenRailroadLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetBrokenRailroadLocation switch fell through! Returning DEFAULT location (Hunting Lodge)");
                    return GetBrokenRailroadLocation(BrokenRailroadLocation.HuntingLodge);
            }
        }

        public static Location GetCoastalHighwayLocation(CoastalHighwayLocation location)
        {
            switch (location)
            {
                case CoastalHighwayLocation.AbandonedLookout:
                    return new Location("Abandoned Lookout", Region.CoastalRegion, 355.7f, 205.0f, 1155.8f, 192.8f, 8.1f);
                case CoastalHighwayLocation.BearCreekCampground:
                    return new Location("Bear Creek Campground", Region.CoastalRegion, -1194.6f, 102.6f, 829.0f);
                case CoastalHighwayLocation.CinderHillsCoalMineLower:
                    return new Location("Cinder Hills Coal Mine (Lower)", "MineTransitionZone", Region.CoastalRegion, true, true, -138.0f, -78.7f, 317.3f, 111.2f, 8.0f);
                case CoastalHighwayLocation.CinderHillsCoalMineMiddle:
                    return new Location("Cinder Hills Coal Mine (Middle)", "MineTransitionZone", Region.CoastalRegion, true, true, -126.0f, -55.3f, 219.6f, 171.9f, 5.3f);
                case CoastalHighwayLocation.CinderHillsCoalMineUpper:
                    return new Location("Cinder Hills Coal Mine (Upper)", "MineTransitionZone", Region.CoastalRegion, true, true, -12.7f, -4.0f, 30.4f, 206.2f, 15.4f);
                case CoastalHighwayLocation.CoastalTownsite:
                    return new Location("Coastal Townsite", Region.CoastalRegion, 754.3f, 26.4f, 636.9f, 37.7f, -3.4f);
                case CoastalHighwayLocation.CommutersLament:
                    return new Location("Commuters Lament", Region.CoastalRegion, 688.6f, 36.1f, -422.6f, 160.8f, 1.8f);
                case CoastalHighwayLocation.FishingCamp:
                    return new Location("Fishing Camp", Region.CoastalRegion, -724.9f, 29.4f, 677.4f, 111.0f, -6.2f);
                case CoastalHighwayLocation.JackrabbitIsland:
                    return new Location("Jackrabbit Island", "CoastalHouseD", Region.CoastalRegion, true, false);
                case CoastalHighwayLocation.LogSort:
                    return new Location("Log Sort", Region.CoastalRegion, -53.8f, 27.5f, 894.2f, 128.4f, -4.1f);
                case CoastalHighwayLocation.MisanthropesHomestead:
                    return new Location("Misanthropes Homestead", "CoastalHouseE", Region.CoastalRegion, true, false);
                case CoastalHighwayLocation.QuonsetGarage:
                    return new Location("Quonset Garage", "QuonsetGasStation", Region.CoastalRegion, true, false);
                case CoastalHighwayLocation.RabbitGrove:
                    return new Location("Rabbit Grove", Region.CoastalRegion, -1237.9f, 129.2f, 973.1f, 57.5f, -2.6f);
                case CoastalHighwayLocation.Rockfall:
                    return new Location("Rockfall", Region.CoastalRegion, -994.4f, 26.3f, 187.5f, 197.9f, -16.9f);
                case CoastalHighwayLocation.SilentClearing:
                    return new Location("Silent Clearing", Region.CoastalRegion, 1032.5f, 97.3f, 705.4f, 306.3f, -3.8f);
                case CoastalHighwayLocation.TheTooth:
                    return new Location("The Tooth", Region.CoastalRegion, -299.1f, 24.8f, 915.8f, 334.7f, 9.5f);
                case CoastalHighwayLocation.TrainUnloading:
                    return new Location("Train Unloading", Region.CoastalRegion, -803.0f, 205.9f, 1262.7f, 76.8f, -3.6f);
                case CoastalHighwayLocation.WaterfrontCottages:
                    return new Location("Waterfront Cottages", Region.CoastalRegion, 716.2f, 33.4f, -111.0f, 319.3f, -5.2f);
                case CoastalHighwayLocation.Random:
                    Location randomLocation = GetCoastalHighwayLocation((CoastalHighwayLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(CoastalHighwayLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetCoastalHighwayLocation switch fell through! Returning DEFAULT location (Coastal Townsite)");
                    return GetCoastalHighwayLocation(CoastalHighwayLocation.CoastalTownsite);
            }
        }

        public static Location GetCrumblingHighwayLocation(CrumblingHighwayLocation location)
        {
            switch (location)
            {
                case CrumblingHighwayLocation.AbandonedHarrisHome:
                    return new Location("Abandoned Harris Home", Region.HighwayTransitionZone, 394.4f, 67.9f, 460.1f);
                case CrumblingHighwayLocation.AbandonedMineNo3:
                    return new Location("Abandoned Mine #3", "HighwayMineTransitionZone", Region.HighwayTransitionZone, true, true, -60.7f, -4.0f, -24.2f, 145.5f, 19.3f);
                case CrumblingHighwayLocation.Cave:
                    return new Location("Cave", Region.HighwayTransitionZone, 495.7f, 66.4f, 502.9f, 130.8f, -2.0f);
                case CrumblingHighwayLocation.RoadCollapse:
                    return new Location("Road Collapse", Region.HighwayTransitionZone, 590.4f, 66f, 417.6f);
                case CrumblingHighwayLocation.TheArch:
                    return new Location("The Arch", Region.HighwayTransitionZone, 461.5f, 51.9f, 230.3f, 327.0f, 4.9f);
                case CrumblingHighwayLocation.Random:
                    Location randomLocation = GetCrumblingHighwayLocation((CrumblingHighwayLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(CrumblingHighwayLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetCrumblingHighwayLocation switch fell through! Returning DEFAULT location (Abandoned Harris Home)");
                    return GetCrumblingHighwayLocation(CrumblingHighwayLocation.AbandonedHarrisHome);
            }
        }

        public static Location GetDesolationPointLocation(DesolationPointLocation location)
        {
            switch (location)
            {
                case DesolationPointLocation.AbandonedMineNo3:
                    return new Location("Abandoned Mine #3", "HighwayMineTransitionZone", Region.WhalingStationRegion, true, true, 0.2f, -16.8f, -14.6f, 157.1f, 17.2f);
                case DesolationPointLocation.AbandonedMineNo5:
                    return new Location("Abandoned Mine #5", "WhalingMine", Region.WhalingStationRegion, true, true, -40.0f, -14.5f, 26.4f, 264.5f, 12.3f);
                case DesolationPointLocation.BlockedHighway:
                    return new Location("Blocked Highway", Region.WhalingStationRegion, 139.0f, 36.7f, 1052.8f, 213.9f, -18.2f);
                case DesolationPointLocation.BrokenBridge:
                    return new Location("Broken Bridge", Region.WhalingStationRegion, 1005.5f, 40.0f, 1582.7f, 43.8f, -3.4f);
                case DesolationPointLocation.Cave:
                    return new Location("Cave", "CaveC", Region.WhalingStationRegion, true, true, -41.2f, 18.3f, -39.8f, 84.8f, 34.7f);
                case DesolationPointLocation.HiberniaProcessing:
                    return new Location("Hibernia Processing", "WhalingWarehouseA", Region.WhalingStationRegion, true, false);
                case DesolationPointLocation.KatiesSecludedCorner:
                    return new Location("Katie's Secluded Corner", Region.WhalingStationRegion, 168.2f, 89.4f, 963.3f, 46.2f, 19.1f);
                case DesolationPointLocation.LittleIsland:
                    return new Location("Little Island", Region.WhalingStationRegion, 1193.7f, 17.2f, 725.2f, 279.2f, -8.2f);
                case DesolationPointLocation.LonelyLighthouse:
                    return new Location("Lonely Lighthouse", "LightHouseA", Region.WhalingStationRegion, true, false);
                case DesolationPointLocation.MattsTruck:
                    return new Location("Matt's Truck", Region.WhalingStationRegion, 810.0f, 17.5f, 1031.9f, 326.6f, 28.4f);
                case DesolationPointLocation.StoneChurch:
                    return new Location("Stone Church", Region.WhalingStationRegion, 564.3f, 64.6f, 1075.7f, 8.2f, -15.3f);
                case DesolationPointLocation.TheRiken:
                    return new Location("The Riken", "WhalingShipA", Region.WhalingStationRegion, true, false);
                case DesolationPointLocation.TrailersinSShape:
                    return new Location("Trailers", "TrailerSShape", Region.WhalingStationRegion, true, false);
                case DesolationPointLocation.Waterfall:
                    return new Location("Waterfall", Region.WhalingStationRegion, 915.3f, 22.1f, 1655.3f);
                case DesolationPointLocation.Random:
                    Location randomLocation = GetDesolationPointLocation((DesolationPointLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(DesolationPointLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetCrumblingHighwayLocation switch fell through! Returning DEFAULT location (Lonely Lighthouse)");
                    return GetDesolationPointLocation(DesolationPointLocation.LonelyLighthouse);
            }
        }

        public static Location GetForlornMuskegLocation(ForlornMuskegLocation location)
        {
            switch (location)
            {
                case ForlornMuskegLocation.Bunkhouses:
                    return new Location("Bunkhouses", Region.MarshRegion, 742.7f, -128.8f, -18.9f, 322.4f, -7.9f);
                case ForlornMuskegLocation.Cave:
                    return new Location("Cave", "CaveD", Region.MarshRegion, true, true, -11.9f, -19.5f, 119.5f, 155.5f, 45.0f);
                case ForlornMuskegLocation.CaveBI:
                    return new Location("Cave To Bleak Inlet", "CanneryMarshTransitionCave", Region.MarshRegion, true, true, -85.4f, 24.4f, -52.4f, 130.5f, -64.2f);
                case ForlornMuskegLocation.HatCreek:
                    return new Location("HatCreek", Region.MarshRegion, 555.2f, -99.3f, 1385.2f, 164.4f, 3.2f);
                case ForlornMuskegLocation.HighBlind:
                    return new Location("High Blind", Region.MarshRegion, 1069.6f, -125.3f, 391.8f, 307.3f, -2.7f);
                case ForlornMuskegLocation.LowBlind:
                    return new Location("Low Blind", Region.MarshRegion, 283.9f, -130.0f, 1038.1f, 33.5f, 1.2f);
                case ForlornMuskegLocation.MarshRidge:
                    return new Location("Marsh Ridge", Region.MarshRegion, 288.6f, -43.7f, 1483.7f, 250.3f, -0.6f);
                case ForlornMuskegLocation.MuskegOverlook:
                    return new Location("Muskeg Overlook", Region.MarshRegion, 1528.4f, -52.7f, 415.5f, 267.2f, 4.4f);
                case ForlornMuskegLocation.OldSpenceFamilyHomestead:
                    return new Location("Old Spence Family Homestead", Region.MarshRegion, 471.5f, -123.4f, 60.2f, 183.0f, 2.5f);
                case ForlornMuskegLocation.PoachersCamp:
                    return new Location("Poacher's Camp", Region.MarshRegion, 1111.6f, -128.3f, 975.8f, 106.9f, 1.2f);
                case ForlornMuskegLocation.PrepperCache:
                    return new Location("Prepper Cache", Region.MarshRegion, 591.4f, -83.1f, -105.5f, 77.8f, 20.7f);
                case ForlornMuskegLocation.ShortwaveTower:
                    return new Location("Shortwave Tower", Region.MarshRegion, 703.1f, -17.3f, 1486.7f, 156.9f, 12.1f);
                case ForlornMuskegLocation.Waterfall:
                    return new Location("Waterfall", Region.MarshRegion, 485.0f, -22.8f, 1661.6f, 161.7f, -2.4f);
                case ForlornMuskegLocation.Random:
                    Location randomLocation = GetForlornMuskegLocation((ForlornMuskegLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(ForlornMuskegLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetForlornMuskegLocation switch fell through! Returning DEFAULT location (Poacher's Camp)");
                    return GetForlornMuskegLocation(ForlornMuskegLocation.PoachersCamp);
            }
        }

        public static Location GetForsakenAirFieldLocation(ForsakenAirfieldLocation location)
        {
            switch (location)
            {
                case ForsakenAirfieldLocation.ControlTower:
                    return new Location("Control Tower", Region.AirfieldRegion, 91.0f, 162.3f, -449.8f, 147.6f, 4.3f);
                case ForsakenAirfieldLocation.IslandCottage:
                    return new Location("Island Cottage", Region.AirfieldRegion, 325.6f, 210.5f, 1016.8f, 201.9f, 16.8f);
                case ForsakenAirfieldLocation.JustysHovel:
                    return new Location("Justy's Hovel", Region.AirfieldRegion, 1013.7f, 289.8f, -944.0f, 223.8f, 1.8f);
                case ForsakenAirfieldLocation.MindfulCabin:
                    return new Location("Mindful Cabin", Region.AirfieldRegion, -738.6f, 296.6f, 1138.7f, 157.2f, 0.1f);
                case ForsakenAirfieldLocation.Random:
                    Location randomLocation = GetForsakenAirFieldLocation((ForsakenAirfieldLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(ForsakenAirfieldLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetAirFieldLocation switch fell through! Returning DEFAULT location (Control Tower)");
                    return GetForsakenAirFieldLocation(ForsakenAirfieldLocation.MindfulCabin);
            }
        }

        public static Location GetHushedRiverValleyLocation(HushedRiverValleyLocation location)
        {
            switch (location)
            {
                case HushedRiverValleyLocation.BannerFalls:
                    return new Location("Banner Falls", Region.RiverValleyRegion, 1339.2f, 214.2f, 1819.6f);
                case HushedRiverValleyLocation.CaveMT:
                    return new Location("Cave to Mountain Town", "RiverValleyTransitionCave", Region.RiverValleyRegion, true, true, -20.0f, -5.8f, 44.0f, 293.5f, 3.1f);
                case HushedRiverValleyLocation.CloudtopFalls:
                    return new Location("Cloudtop Falls", Region.RiverValleyRegion, 199.9f, 192.5f, 291.9f);
                case HushedRiverValleyLocation.ForestKnoll:
                    return new Location("Forest Knoll", Region.RiverValleyRegion, 450.3f, 152.8f, 1334.1f, 74.6f, 1.6f);
                case HushedRiverValleyLocation.IceCaveNorth:
                    return new Location("Ice Cave (North)", "IceCaveB", Region.RiverValleyRegion, true, true, 73.7f, -2.3f, -43.2f, 249.3f, 37.0f);
                case HushedRiverValleyLocation.IceCaveSouth:
                    return new Location("Ice Cave (South)", "IceCaveA", Region.RiverValleyRegion, true, true, 99.1f, -8.2f, -8.7f, 345.9f, 25.9f);
                case HushedRiverValleyLocation.LakeCave:
                    return new Location("Lake Cave", Region.RiverValleyRegion, 1493.35f, 207f, 1754.6f);
                case HushedRiverValleyLocation.Landslide:
                    return new Location("Landslide", Region.RiverValleyRegion, 1693.3f, 30.4f, 1086f);
                case HushedRiverValleyLocation.LittleBearandCubFalls:
                    return new Location("Little Bear and Cub Falls", Region.RiverValleyRegion, 1065f, 40f, 1244f);
                case HushedRiverValleyLocation.LonelyCave:
                    return new Location("Lonely Cave", Region.RiverValleyRegion, 407.9f, 259.64f, 430.4f);
                case HushedRiverValleyLocation.LongShotFalls:
                    return new Location("Long Shot Falls", Region.RiverValleyRegion, 925.5f, 19.5f, 1186.9f);
                case HushedRiverValleyLocation.MammothFalls:
                    return new Location("Mammoth Falls", Region.RiverValleyRegion, 936.7f, 214.2f, 1721.4f);
                case HushedRiverValleyLocation.ManyFallsVista:
                    return new Location("Many Falls Vista", Region.RiverValleyRegion, 1078.56f, 123.6f, 822.18f);
                case HushedRiverValleyLocation.MonolithLake:
                    return new Location("Monolith Lake", Region.RiverValleyRegion, 1351.6f, 214f, 1612.6f);
                case HushedRiverValleyLocation.MooseOverlook:
                    return new Location("Moose Overlook", Region.RiverValleyRegion, 1281.69f, 81.8f, 923.25f);
                case HushedRiverValleyLocation.MysteriousSignalFire:
                    return new Location("Mysterious Signal Fire", Region.RiverValleyRegion, 943.3f, 199.4f, 1281.1f);
                case HushedRiverValleyLocation.OffsetFalls:
                    return new Location("Offset Falls", Region.RiverValleyRegion, 184.4f, 92.3f, 1007.1f);
                case HushedRiverValleyLocation.PeakCave:
                    return new Location("Peak Cave", Region.RiverValleyRegion, 1435.5f, 291.2f, 1308f);
                case HushedRiverValleyLocation.PensiveVista:
                    return new Location("Pensive Vista", Region.RiverValleyRegion, 1203.4f, 223f, 1220f);
                case HushedRiverValleyLocation.QuarrellingFalls:
                    return new Location("Quarrelling Falls", Region.RiverValleyRegion, 1056.1f, 214.2f, 1770.2f);
                case HushedRiverValleyLocation.ReclusiveFalls:
                    return new Location("Reclusive Falls", Region.RiverValleyRegion, 464.53f, 88.15f, 1032.22f);
                case HushedRiverValleyLocation.RiversideCamp:
                    return new Location("Riverside Camp", Region.RiverValleyRegion, 659.3f, 105.5f, 1137.2f, 89.0f, -13.1f);
                case HushedRiverValleyLocation.SecludedCamp:
                    return new Location("Secluded Camp", Region.RiverValleyRegion, 363.2f, 133.8f, 1007.6f, 344.8f, 5.2f);
                case HushedRiverValleyLocation.StairstepsLake:
                    return new Location("Stairsteps Lake", Region.RiverValleyRegion, 404f, 114f, 645.6f);
                case HushedRiverValleyLocation.TwinSistersFalls:
                    return new Location("Twin Sisters Falls", Region.RiverValleyRegion, 963.2f, 19.5f, 1043.3f);
                case HushedRiverValleyLocation.ValleyCave:
                    return new Location("Valley Cave", Region.RiverValleyRegion, 1136f, 28.3f, 1210.8f);
                case HushedRiverValleyLocation.ValleyViewPoint:
                    return new Location("Valley View Point", Region.RiverValleyRegion, 879.5f, 136.5f, 1055.3f, 87.8f, 3.0f);
                case HushedRiverValleyLocation.VistaCamp:
                    return new Location("Vista Camp", Region.RiverValleyRegion, 302.5f, 169.5f, 453.0f, 353.1f, -8.2f);
                case HushedRiverValleyLocation.WatchfulFalls:
                    return new Location("Watchful Falls", Region.RiverValleyRegion, 1461f, 214.2f, 1699.4f);
                case HushedRiverValleyLocation.Random:
                    Location randomLocation = GetHushedRiverValleyLocation((HushedRiverValleyLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(HushedRiverValleyLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetForlornMuskegLocation switch fell through! Returning DEFAULT location (Valley View Point)");
                    return GetHushedRiverValleyLocation(HushedRiverValleyLocation.ValleyViewPoint);
            }
        }

        public static Location GetKeepersPassNorthLocation(KeepersPassNorthLocation location)
        {
            switch (location)
            {
                case KeepersPassNorthLocation.BuildersBridge:
                    return new Location("Builder's Bridge", Region.BlackrockTransitionZone, 417.76f, 255.6139f, -126.15f);
                case KeepersPassNorthLocation.CaveKPS:
                    return new Location("Cave to Keeper's Pass South", "CanyonRoadCave", Region.BlackrockTransitionZone, true, true, 101.1f, -7.3f, -14.4f, 100.2f, 30.8f);
                case KeepersPassNorthLocation.ForestersHermitage:
                    return new Location("Forester's Hermitage", Region.BlackrockTransitionZone, 756.6f, 246.3f, -164.6f, 60.2f, 19.2f);
                case KeepersPassNorthLocation.Random:
                    Location randomLocation = GetKeepersPassNorthLocation((KeepersPassNorthLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(KeepersPassNorthLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetKeepersPassNorthLocation switch fell through! Returning DEFAULT location (Forester's Hermitage)");
                    return GetKeepersPassNorthLocation(KeepersPassNorthLocation.ForestersHermitage);
            }
        }

        public static Location GetKeepersPassSouthLocation(KeepersPassSouthLocation location)
        {
            switch (location)
            {
                case KeepersPassSouthLocation.CaveKPN:
                    return new Location("Cave to Keeper's Pass North", "CanyonRoadCave", Region.CanyonRoadTransitionZone, true, true, 176.8f, -3.4f, -30.4f, 336.8f, 24.3f);
                case KeepersPassSouthLocation.FishingHut:
                    return new Location("Fishing Hut", Region.CanyonRoadTransitionZone, 231.8f, 41.7f, 422.4f, 155.1f, 5.6f);
                case KeepersPassSouthLocation.MirthlessFork:
                    return new Location("Mirthless Fork", Region.CanyonRoadTransitionZone, 378.7f, 74.0f, 443.9f, 229.6f, -1.0f);
                case KeepersPassSouthLocation.ScenicView:
                    return new Location("Scenic View", Region.CanyonRoadTransitionZone, 312.6f, 73.1f, 382.1f, 180.6f, 11.0f);
                case KeepersPassSouthLocation.TheToe:
                    return new Location("The Toe", Region.CanyonRoadTransitionZone, 291.6f, 41.8f, 82.7f, 5.9f, -15.9f);
                case KeepersPassSouthLocation.Random:
                    Location randomLocation = GetKeepersPassSouthLocation((KeepersPassSouthLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(KeepersPassSouthLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetKeepersPassSouthLocation switch fell through! Returning DEFAULT location (Mirthless Fork)");
                    return GetKeepersPassSouthLocation(KeepersPassSouthLocation.MirthlessFork);
            }
        }

        public static Location GetMountainTownLocation(MountainTownLocation location)
        {
            switch (location)
            {
                case MountainTownLocation.CaveClimbingArea:
                    return new Location("Cave (Climbing Area)", Region.MountainTownRegion, 1276.8f, 247.3f, 1000.6f, 243.3f, 5.4f);
                case MountainTownLocation.CaveDeep:
                    return new Location("Cave (Deep)", "MountainTownCaveA", Region.MountainTownRegion, true, true, -76.2f, 25.6f, -84.7f, 203.7f, 34.8f);
                case MountainTownLocation.CaveRadioTower:
                    return new Location("Cave (near Radio Tower)", Region.MountainTownRegion, 1482.7f, 325.3f, 1532.7f, 276.5f, 8.8f);
                case MountainTownLocation.CaveHRV:
                    return new Location("Cave to Hushed River Valley", "RiverValleyTransitionCave", Region.MountainTownRegion, true, true, -20.0f, -5.8f, 44.0f, 293.5f, 3.1f);
                case MountainTownLocation.CaveML:
                    return new Location("Cave to Mystery Lake", "MountainTownCaveB", Region.MountainTownRegion, true, true, -20.1f, 15.1f, 38.9f, 358.6f, 16.1f);
                case MountainTownLocation.CrashedPlane:
                    return new Location("Crashed Plane", Region.MountainTownRegion, 2006.9f, 380.7f, 1442.6f, 333.0f, -73.1f);
                case MountainTownLocation.CrashedPrisonTransportBus:
                    return new Location("Crashed Prison Transport Bus", Region.MountainTownRegion, 1370.3f, 266.4f, 1199.6f, 58.0f, 6.1f);
                case MountainTownLocation.Graveyard:
                    return new Location("Graveyard", Region.MountainTownRegion, 766.5f, 290.0f, 2109.7f, 155.9f, 7.1f);
                case MountainTownLocation.GreyMothersHouse:
                    return new Location("Grey Mother's House", "GreyMothersHouseA", Region.MountainTownRegion, true, false);
                case MountainTownLocation.HermitsCabin:
                    return new Location("Hermit's Cabin", Region.MountainTownRegion, 443.3f, 8.6f, 712.9f, 345.4f, 20.9f);
                case MountainTownLocation.MiltonBasin:
                    return new Location("Milton Basin", Region.MountainTownRegion, 617.5f, 19.1f, 602.0f, 11.9f, -12.3f);
                case MountainTownLocation.MiltonCreditUnion:
                    return new Location("Milton Credit Union", "BankA", Region.MountainTownRegion, true, false);
                case MountainTownLocation.MiltonHouse:
                    return new Location("Milton House", "MiltonHouseH3", Region.MountainTownRegion, true, false);
                case MountainTownLocation.MiltonPark:
                    return new Location("Milton Park", Region.MountainTownRegion, 1097.9f, 281.5f, 1242.3f, 243.2f, -3.4f);
                case MountainTownLocation.MiltonPostOffice:
                    return new Location("Milton Post Office", "PostOfficeA", Region.MountainTownRegion, true, false);
                case MountainTownLocation.OldSchoolhouse:
                    return new Location("Old Schoolhouse", Region.MountainTownRegion, 988.3f, 266.4f, 1732.9f, 253.1f, -3.8f);
                case MountainTownLocation.OrcaGasStation:
                    return new Location("Orca Gas Station", Region.MountainTownRegion, 1194.8f, 267.7f, 1353.5f, 282.4f, 0.7f);
                case MountainTownLocation.ParadiseMeadowsFarm:
                    return new Location("Paradise Meadows Farm", "FarmHouseB", Region.MountainTownRegion, true, false);
                case MountainTownLocation.ParkOffice:
                    return new Location("Park Office", Region.MountainTownRegion, 963.7f, 306.0f, 1232.0f, 334.7f, 4.6f);
                case MountainTownLocation.PicnicArea:
                    return new Location("Picnic Area", Region.MountainTownRegion, 926.4f, 315.7f, 1157.0f, 232.7f, -0.4f);
                case MountainTownLocation.PrepperCache:
                    return new Location("Prepper Cache", Region.MountainTownRegion, 1829.7f, 444.9f, 1769.7f, 323.3f, 27.6f);
                case MountainTownLocation.RadioTower:
                    return new Location("Radio Tower", Region.MountainTownRegion, 1317.8f, 352.2f, 1602.0f, 291.4f, -70.4f);
                case MountainTownLocation.RockyRefuge:
                    return new Location("Rocky Refuge", Region.MountainTownRegion, 873.1f, 59.9f, 886.1f, 272.6f, -1.1f);
                case MountainTownLocation.SideOfTheRoad:
                    return new Location("Side of the Road", Region.MountainTownRegion, 1482.1f, 366.1f, 2008.0f, 352.8f, 30.0f);
                case MountainTownLocation.SpruceFallsBridge:
                    return new Location("Spruce Falls Bridge", Region.MountainTownRegion, 1818.7f, 395.6f, 2072.9f, 341.5f, -8.2f);
                case MountainTownLocation.StChristophersChurch:
                    return new Location("St. Christopher's Church", "ChurchB", Region.MountainTownRegion, true, false);
                case MountainTownLocation.TheArch:
                    return new Location("The Arch", Region.MountainTownRegion, 1300.9f, 289.1f, 1531.7f, 312.8f, -1.3f);
                case MountainTownLocation.TownOfMilton:
                    return new Location("Town of Milton", Region.MountainTownRegion, 1081.3f, 263.0f, 1756.3f, 159.2f, -0.5f);
                case MountainTownLocation.Trailer:
                    return new Location("Trailer", "MiltonTrailerB", Region.MountainTownRegion, true, false);
                case MountainTownLocation.WoodLotNorth:
                    return new Location("Wood Lot (Northern)", Region.MountainTownRegion, 882.7f, 274.9f, 2027.5f, 160.7f, 3.3f);
                case MountainTownLocation.WoodLotSouthEast:
                    return new Location("Wood Lot (South Eastern)", Region.MountainTownRegion, 1305.3f, 266.4f, 1325.8f, 283.3f, -3.0f);
                case MountainTownLocation.WoodLotSouthWest:
                    return new Location("Wood Lot (South Western)", Region.MountainTownRegion, 1102.9f, 264.1f, 1420.9f, 37.5f, 3.1f);
                case MountainTownLocation.Random:
                    Location randomLocation = GetMountainTownLocation((MountainTownLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(MountainTownLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetMountainTownLocation switch fell through! Returning DEFAULT location (CRashed Plane)");
                    return GetMountainTownLocation(MountainTownLocation.CrashedPlane);
            }
        }

        public static Location GetMysteryLakeLocation(MysteryLakeLocation location)
        {
            switch (location)
            {
                case MysteryLakeLocation.AlansCave:
                    return new Location("Alan's Cave", Region.LakeRegion, 1529.5f, 37.5f, 838.9f, 90.8f, -3.8f);
                case MysteryLakeLocation.CampOffice:
                    return new Location("Camp Office", "CampOffice", Region.LakeRegion, true, false);
                case MysteryLakeLocation.CarterHydroDam:
                    return new Location("Carter Hydro Dam", "Dam", Region.LakeRegion, true, false);
                case MysteryLakeLocation.CaveMT:
                    return new Location("Cave to Mountain Town", "MountainTownCaveB", Region.LakeRegion, true, true, -20.1f, 15.1f, 38.9f, 358.6f, 16.1f);
                case MysteryLakeLocation.CaveUnnamed:
                    return new Location("Cave (Unnamed)", Region.LakeRegion, 947.1f, 45.6f, -238.3f, 22.9f, 1 - 5.9f);
                case MysteryLakeLocation.Clearcut:
                    return new Location("Clearcut", Region.LakeRegion, 329.5f, 19.1f, 1260.6f, 188.6f, -5.0f);
                case MysteryLakeLocation.DavesQuietClearing:
                    return new Location("Dave's Quiet Clearing", Region.LakeRegion, 942.0f, 52.2f, 60.9f, 125.9f, -0.9f);
                case MysteryLakeLocation.DeadfallArea:
                    return new Location("Deadfall Area", Region.LakeRegion, 567.7f, 0.2f, 264.8f, 278.3f, 22.1f);
                case MysteryLakeLocation.Derailment:
                    return new Location("Derailment", Region.LakeRegion, 970.2f, 40.7f, 8561.4f, 358.4f, 18.8f);
                case MysteryLakeLocation.DestroyedLookout:
                    return new Location("Destroyed Lookout", Region.LakeRegion, 441.1f, 157.8f, 1009.7f, 124.7f, -24.3f);
                case MysteryLakeLocation.ForestryLookout:
                    return new Location("Forestry Lookout", Region.LakeRegion, 788.5f, 215.0f, 966.6f, 314.0f, 11.2f);
                case MysteryLakeLocation.FrozenCreek:
                    return new Location("Frozen Creek", Region.LakeRegion, 529.4f, 55.8f, 819.7f, 71.8f, -25.5f);
                case MysteryLakeLocation.HuntersBlindatAlansCave:
                    return new Location("Hunter's Blind at Alan's Cave", Region.LakeRegion, 1637.8f, 20.6f, 833.8f, 279.1f, 2.1f);
                case MysteryLakeLocation.IceFishingHuts:
                    return new Location("IceFishingHuts", Region.LakeRegion, 1448.0f, 26.0f, 210.3f, 273.9f, 5.9f);
                case MysteryLakeLocation.LakeCabin:
                    return new Location("Lake Cabin (Lone)", Region.LakeRegion, 1666.1f, 19.7f, 285.3f, 50.8f, -6.2f);
                case MysteryLakeLocation.LakeCabinsSE:
                    return new Location("Lake Cabins (South Eastern)", Region.LakeRegion, 1615.1f, 19.9f, 66.2f, 289.0f, 1.6f);
                case MysteryLakeLocation.LakeCabinsSW:
                    return new Location("Lake Cabins (South Western)", Region.LakeRegion, 1468.5f, 21.5f, -41.0f, 315.8f, 1.8f);
                case MysteryLakeLocation.LakeOverlook:
                    return new Location("Lake Overlook", Region.LakeRegion, 1292.6f, 134.5f, 496.5f, 145.3f, 11.9f);
                case MysteryLakeLocation.LoggingCamp:
                    return new Location("Logging Camp", Region.LakeRegion, 885.0f, 24.0f, 1252.5f, 89.5f, 1.5f);
                case MysteryLakeLocation.Lookout:
                    return new Location("Lookout", Region.LakeRegion, 29.6f, 146.8f, 1594.8f, 141.4f, 0.8f);
                case MysteryLakeLocation.MaxsLastStand:
                    return new Location("Max's Last Stand", Region.LakeRegion, 319.2f, 12.4f, -36.9f, 142.5f, 1.8f);
                case MysteryLakeLocation.PrepperCache:
                    return new Location("Prepper Cache", Region.LakeRegion, 1029.0f, 92.6f, -54.8f, 7.8f, 25.3f);
                case MysteryLakeLocation.RailTunnel:
                    return new Location("Rail Tunnel", Region.LakeRegion, 778.4f, 38.7f, -88.0f, 204.2f, -5.1f);
                case MysteryLakeLocation.RiverNorthernAccess:
                    return new Location("River (Northern Access)", Region.LakeRegion, 1433.5f, 18.1f, 1098.0f, 173.7f, -9.5f);
                case MysteryLakeLocation.RiverSouthernAccess:
                    return new Location("River (Southern Access)", Region.LakeRegion, 1412.6f, 18.1f, 47934f, 353.8f, -5.0f);
                case MysteryLakeLocation.MysteryLake:
                    return new Location("Mystery Lake", Region.LakeRegion, 1089.6f, 18.1f, 426.4f, 115.5f, -4.2f);
                case MysteryLakeLocation.MysteryLakeWesternAccess:
                    return new Location("Mystery Lake (Western Access)", Region.LakeRegion, 1292.8f, 19.0f, 26.0f, 87.5f, 0.5f);
                case MysteryLakeLocation.TrainBridge:
                    return new Location("Train Bridge", Region.LakeRegion, 1563.9f, 38.6f, 1277.2f, 95.2f, -5.3f);
                case MysteryLakeLocation.TrainLoadingArea:
                    return new Location("Train Loading Area", Region.LakeRegion, 1304.4f, 38.9f, 1245.5f, 229.0f, -0.6f);
                case MysteryLakeLocation.TrappersCabin:
                    return new Location("Trapper's Cabin", "SafeHouseA", Region.LakeRegion, true, false);
                case MysteryLakeLocation.UnnamedPond:
                    return new Location("Unnamed Pond", Region.LakeRegion, 130.9f, 13.0f, 664.0f, 63.1f, -3.9f);
                case MysteryLakeLocation.Random:
                    Location randomLocation = GetMysteryLakeLocation((MysteryLakeLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(MysteryLakeLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetMysteryLakeLocation switch fell through! Returning DEFAULT location (Camp Office)");
                    return GetMysteryLakeLocation(MysteryLakeLocation.CampOffice);
            }
        }

        public static Location GetPleasantValleyLocation(PleasantValleyLocation location)
        {
            switch (location)
            {
                case PleasantValleyLocation.BarnLarge:
                    return new Location("Barn (Large)", "BarnHouseA", Region.RuralRegion, true, false);
                case PleasantValleyLocation.BarnSmall:
                    return new Location("Barn (Small)", "BarnHouseB", Region.RuralRegion, true, false);
                case PleasantValleyLocation.BurnedRidgeCave:
                    return new Location("Burned Ridge Cave", Region.RuralRegion, 513.7f, 153.0f, 1572.2f, 68.2f, -1.0f);
                case PleasantValleyLocation.CascadingFalls:
                    return new Location("Cascading Falls", Region.RuralRegion, 2772.0f, 112.8f, 933.9f, 115.6f, -36.9f);
                case PleasantValleyLocation.Cave:
                    return new Location("Cave", Region.RuralRegion, 2885.6f, 126.8f, 1950.7f, 289.9f, -1.2f);
                case PleasantValleyLocation.CaveWR:
                    return new Location("Cave to Winding River", "DamCaveTransitionZone", Region.RuralRegion, true, true, -57.5f, 5.4f, 95.0f, 21.2f, 18.1f);
                case PleasantValleyLocation.Church:
                    return new Location("Church", "ChurchC", Region.RuralRegion, true, false);
                case PleasantValleyLocation.CinderHillsCoalMine:
                    return new Location("Cinder Hills Coal Mine", "MineTransitionZone", Region.CoastalRegion, true, true, -40.4f, -14.5f, 26.0f, 235.7f, 20.0f);
                case PleasantValleyLocation.CommunityHall:
                    return new Location("Community Hall", "CommunityHallA", Region.RuralRegion, true, false);
                case PleasantValleyLocation.ContemplationBridge:
                    return new Location("Contemplation Bridge", Region.RuralRegion, 2008.0f, 63.8f, 1733.0f, 284.1f, 1.2f);
                case PleasantValleyLocation.CrashSite:
                    return new Location("Crash Site", Region.RuralRegion, 551.4f, 151.9f, 1724.5f, 135.9f, -86.3f);
                case PleasantValleyLocation.DerelictCabins:
                    return new Location("Derelict Cabins", Region.RuralRegion, 1443.4f, 89.2f, 2679.1f, 277.9f, 2.4f);
                case PleasantValleyLocation.DraftDodgersCabin:
                    return new Location("Draft Dodger's Cabin", Region.RuralRegion, 951.7f, 39.6f, 1667.0f, 284.2f, 3.0f);
                case PleasantValleyLocation.EndoftheRoad:
                    return new Location("End of the Road", Region.RuralRegion, 1827.4f, 93.9f, 2935.8f, 78.6f, -5.7f);
                case PleasantValleyLocation.ForestCave:
                    return new Location("ForestCave", Region.RuralRegion, 2379.9f, 91.4f, 1387.8f, 293.5f, -10.3f);
                case PleasantValleyLocation.HeartbreakBridge:
                    return new Location("Heartbreak Bridge", Region.RuralRegion, 1787.6f, 57.0f, 1032.2f, 5.6f, -8.1f);
                case PleasantValleyLocation.HilltopCave:
                    return new Location("Hilltop Cave", Region.RuralRegion, 2452.5f, 194.0f, 478.1f, 336.0f, 30.0f);
                case PleasantValleyLocation.HuntersBlindEast:
                    return new Location("Hunter's Blind (East)", Region.RuralRegion, 391.8f, 150.1f, 2053.7f, 66.2f, -12.4f);
                case PleasantValleyLocation.HuntersBlindWest:
                    return new Location("Hunter's Blind (West)", Region.RuralRegion, 2509.4f, 188.1f, 562.3f, 53.8f, 15.9f);
                case PleasantValleyLocation.LonelyHomestead:
                    return new Location("Lonely Homestead", Region.RuralRegion, 1403.4f, 39.5f, 2236.7f, 91.8f, 5.5f);
                case PleasantValleyLocation.LongCurve:
                    return new Location("LongCurve", Region.RuralRegion, 1666.8f, 45.0f, 173.3f, 243.8f, 4.4f);
                case PleasantValleyLocation.LowerFalls:
                    return new Location("Lower Falls", Region.RuralRegion, 2168.0f, 43.5f, 1118.6f, 138.8f, -17.0f);
                case PleasantValleyLocation.MistyFallsPicnicArea:
                    return new Location("Misty Falls Picnic Area", Region.RuralRegion, 367.5f, 140.6f, 2627.5f, 324.4f, -12.5f);
                case PleasantValleyLocation.PensivePond:
                    return new Location("Pensive Pond", Region.RuralRegion, 2507.1f, 113.0f, 1209.7f, 238.0f, 2.0f);
                case PleasantValleyLocation.PicnicSpot:
                    return new Location("Picnic Spot", Region.RuralRegion, 2621.8f, 96.0f, 1469.7f, 224.2f, 6.5f);
                case PleasantValleyLocation.PleasantValleyFarmstead:
                    return new Location("Pleasant Valley Farmstead", "FarmHouseA", Region.RuralRegion, true, false);
                case PleasantValleyLocation.PleasantValleyOutbuildings:
                    return new Location("Pleasant Valley Outbuildings", Region.RuralRegion, 1718.6f, 43.4f, 1822.1f, 290.6f, -2.7f);
                case PleasantValleyLocation.PointofDisagreement:
                    return new Location("Point of Disagreement", Region.RuralRegion, 666.9f, 142.8f, 2275.5f, 65.5f, 3.0f);
                case PleasantValleyLocation.PreppersAbandonedCache:
                    return new Location("Prepper's Abandoned Cache", "PrepperCacheEmpty", Region.RuralRegion, true, false);
                case PleasantValleyLocation.RadioControlHut:
                    return new Location("Radio Control Hut", "RadioControlHut", Region.RuralRegion, true, false);
                case PleasantValleyLocation.SignalHill:
                    return new Location("Signal Hill", Region.RuralRegion, 1921.4f, 201.4f, 629.8f, 285.1f, -1.0f);
                case PleasantValleyLocation.SkeetersRidge:
                    return new Location("Skeeter's Ridge", "HouseBasementPV", Region.RuralRegion, true, false);
                case PleasantValleyLocation.ThomsonsCrossing:
                    return new Location("Thomson's Crossing", Region.RuralRegion, 2402.8f, 54.2f, 2223.7f, 302.6f, -4.9f);
                case PleasantValleyLocation.ThreeStrikesFarmstead:
                    return new Location("Three Strikes Farmstead", Region.RuralRegion, 474.9f, 61.4f, 592.5f, 98.6f, 46.8f);
                case PleasantValleyLocation.UpperFalls:
                    return new Location("Upper Falls", Region.RuralRegion, 2727.6f, 90.6f, 2322.7f, 104.6f, -15.1f);
                case PleasantValleyLocation.Random:
                    Location randomLocation = GetPleasantValleyLocation((PleasantValleyLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(PleasantValleyLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetMysteryLakeLocation switch fell through! Returning DEFAULT location (Pleasant Valley Farmstead)");
                    return GetPleasantValleyLocation(PleasantValleyLocation.PleasantValleyFarmstead);
            }
        }

        public static Location GetRavineLocation(RavineLocation location)
        {
            switch (location)
            {
                case RavineLocation.CaveLower:
                    return new Location("Cave (Lower)", Region.RavineTransitionZone, -486.2f, 22.7f, -229.5f, 5.2f, -6.8f);
                case RavineLocation.CaveUpper:
                    return new Location("Cave (Upper)", Region.RavineTransitionZone, -1033.1f, 138.5f, -292.2f, 317.6f, -6.0f);
                case RavineLocation.RavenFallsTrestle:
                    return new Location("Raven Falls Trestle", Region.RavineTransitionZone, -9.1f, 135.2f, 19.2f, 349.9f, -13.7f);
                case RavineLocation.RavineBasin:
                    return new Location("Ravine Basin", Region.RavineTransitionZone, -678.7f, 20.1f, -191.0f, 285.3f, -30.3f);
                case RavineLocation.ShuntingYard:
                    return new Location("Shunting Yard", Region.RavineTransitionZone, -629.4f, 140.4f, 21.8f, 120.8f, 16.8f);
                case RavineLocation.TrainCar:
                    return new Location("Train Car", Region.RavineTransitionZone, -770.9f, 131.4f, -130.6f, 105.9f, 26.4f);
                case RavineLocation.Random:
                    Location randomLocation = GetRavineLocation((RavineLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(RavineLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetMysteryLakeLocation switch fell through! Returning DEFAULT location (Shunting Yard)");
                    return GetRavineLocation(RavineLocation.ShuntingYard);
            }
        }

        public static Location GetSunderedPassLocation(SunderedPassLocation location)
        {
            switch (location)
            {
                case SunderedPassLocation.FinalRefuge:
                    return new Location("Final Refuge", Region.MountainPassRegion, -337.6f, 599.9f, -998.6f, 166.6f, 12.9f);
                case SunderedPassLocation.LastLonelyHouse:
                    return new Location("Last Lonely House", Region.MountainPassRegion, 495.6f, 100.4f, 659.6f, 175.1f, -15.8f);
                case SunderedPassLocation.LottesRest:
                    return new Location("Lotte's Rest", Region.MountainPassRegion, 204.0f, 198.5f, 761.8f, 158.2f, 4.7f);
                case SunderedPassLocation.WeatherStation:
                    return new Location("Weather Station", Region.MountainPassRegion, 526.1f, 598.4f, -621.8f, 55.8f, 4.2f);
                case SunderedPassLocation.Random:
                    Location randomLocation = GetSunderedPassLocation((SunderedPassLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(SunderedPassLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetSunderedPassLocation switch fell through! Returning DEFAULT location (Last Lonely House)");
                    return GetSunderedPassLocation(SunderedPassLocation.LastLonelyHouse);
            }
        }

        public static Location GetTimberwolfMountainLocation(TimberwolfMountainLocation location)
        {
            switch (location)
            {
                case TimberwolfMountainLocation.AndresPeak:
                    return new Location("Andre's Peak", Region.CrashMountainRegion, 604.6f, 335.2f, 967.5f, 104.6f, 2.7f);
                case TimberwolfMountainLocation.CaveLargeOpen:
                    return new Location("Cave (Large Open)", Region.CrashMountainRegion, 1380.9f, 149.9f, 1209.3f, 280.3f, 19.4f);
                case TimberwolfMountainLocation.CaveLower:
                    return new Location("Cave (Lower)", "MountainCaveA", Region.CrashMountainRegion, true, true, -12.7f, 17.7f, 11.7f, 212.4f, 29.4f);
                case TimberwolfMountainLocation.CaveUpper:
                    return new Location("Cave (Upper)", "MountainCaveA", Region.CrashMountainRegion, true, true, -26.2f, 4.3f, 38.8f, 64.1f, 5.2f);
                case TimberwolfMountainLocation.CaveUnnamed:
                    return new Location("Cave (Unnamed)", Region.CrashMountainRegion, 1824.5f, 156.6f, 1074.8f, 254.7f, 2.9f);
                case TimberwolfMountainLocation.CaveAC:
                    return new Location("Cave to Ash Canyon", "AshCaveA", Region.CrashMountainRegion, true, true, 15.1f, -4.2f, 56.6f, 11.4f, 19.0f);
                case TimberwolfMountainLocation.ChasmCave:
                    return new Location("Chasm Cave", Region.CrashMountainRegion, 1330.4f, 52.0f, 881.4f, 201.5f, 13.7f);
                case TimberwolfMountainLocation.CrystalLake:
                    return new Location("Crystal Lake", Region.CrashMountainRegion, 819.1f, 150.9f, 570.4f, 151.3f, -3.4f);
                case TimberwolfMountainLocation.DeerClearing:
                    return new Location("Deer Clearing", Region.CrashMountainRegion, 1665.3f, 192.7f, 1675.8f, 258.0f, -13.1f);
                case TimberwolfMountainLocation.EchoPeakEast:
                    return new Location("Echo Peak East", Region.CrashMountainRegion, 1433.8f, 200.0f, 829.8f, 87.4f, 1.2f);
                case TimberwolfMountainLocation.EchoPeakWest:
                    return new Location("Echo Peak West", Region.CrashMountainRegion, 1684.5f, 208.0f, 715.3f, 267.7f, -5.8f);
                case TimberwolfMountainLocation.EchoRavine:
                    return new Location("Echo Ravine", Region.CrashMountainRegion, 1441.6f, 60.5f, 989.6f, 127.5f, 41.5f);
                case TimberwolfMountainLocation.Engine:
                    return new Location("Engine", Region.CrashMountainRegion, 648.2f, 276.6f, 1104.1f, 231.1f, -10.8f);
                case TimberwolfMountainLocation.EricsFalls:
                    return new Location("Eric's Falls", Region.CrashMountainRegion, 399.7f, 346.2f, 1736.6f, 323.0f, -24.0f);
                case TimberwolfMountainLocation.ForestCave:
                    return new Location("Forest Cave", Region.CrashMountainRegion, 1717.1f, 152.9f, 228.8f, 275.6f, 5.6f);
                case TimberwolfMountainLocation.LandingGear:
                    return new Location("Landing Gear", Region.CrashMountainRegion, 425.0f, 178.0f, 292.5f, 122.3f, -6.8f);
                case TimberwolfMountainLocation.MountaineersHut:
                    return new Location("Mountaineer's Hut", Region.CrashMountainRegion, 889.1f, 162.4f, 342.7f, 351.8f, 0f);
                case TimberwolfMountainLocation.SecludedShelf:
                    return new Location("Secluded Shelf", Region.CrashMountainRegion, 1258.0f, 349.8f, 1415.0f, 169.7f, 8.6f);
                case TimberwolfMountainLocation.Summit:
                    return new Location("Summit", Region.CrashMountainRegion, 886.3f, 496.9f, 1500.1f, 289.9f, -2.6f);
                case TimberwolfMountainLocation.SummitCave:
                    return new Location("Summit Cave", Region.CrashMountainRegion, 1018.2f, 493.1f, 1405.3f, 164.4f, 12.0f);
                case TimberwolfMountainLocation.TailSection:
                    return new Location("Tail Section", Region.CrashMountainRegion, 924.6f, 471.1f, 1179.5f, 113.6f, -40.9f);
                case TimberwolfMountainLocation.WaterfallCave:
                    return new Location("Waterfall Cave", Region.CrashMountainRegion, 429.2f, 351.5f, 1817.6f, 138.4f, -6.3f);
                case TimberwolfMountainLocation.Wing:
                    return new Location("Wing", Region.CrashMountainRegion, 1575.3f, 128.8f, 486.6f, 74.8f, 2.6f);
                case TimberwolfMountainLocation.Random:
                    Location randomLocation = GetTimberwolfMountainLocation((TimberwolfMountainLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(TimberwolfMountainLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetMysteryLakeLocation switch fell through! Returning DEFAULT location (Mountaineer's Hut)");
                    return GetTimberwolfMountainLocation(TimberwolfMountainLocation.MountaineersHut);
            }
        }

        public static Location GetTransferPassLocation(TransferPassLocation location)
        {
            switch (location)
            {
                case TransferPassLocation.VacantDepot:
                    return new Location("Vacant Depot", Region.HubRegion, 133.2f, 253.3f, 402.9f, 250.0f, 8.0f);
                case TransferPassLocation.Random:
                    Location randomLocation = GetTransferPassLocation((TransferPassLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(TransferPassLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetWindingRiverLocation switch fell through! Returning DEFAULT location (Vacant Depot)");
                    return GetTransferPassLocation(TransferPassLocation.VacantDepot);
            }
        }

        public static Location GetWindingRiverLocation(WindingRiverLocation location)
        {
            switch (location)
            {
                case WindingRiverLocation.Cave:
                    return new Location("Cave", Region.DamRiverTransitionZoneB, 357.0f, 40.1f, 625.7f, 112.2f, 19.0f);
                case WindingRiverLocation.CavePV:
                    return new Location("Cave to Pleasant Valley", "DamCaveTransitionZone", Region.RuralRegion, true, true, -57.5f, 5.4f, 95.0f, 21.2f, 18.1f);
                case WindingRiverLocation.Dam:
                    return new Location("Dam", "DamTransitionZone", Region.RuralRegion, true, true, -11.4f, 1.8f, -8.7f, 66.0f, 1.2f);
                case WindingRiverLocation.Hilltop:
                    return new Location("Hilltop", Region.DamRiverTransitionZoneB, 450.4f, 75.1f, 456.1f, 146.2f, 4.7f);
                case WindingRiverLocation.ShelteredSpot:
                    return new Location("Sheltered Spot", Region.DamRiverTransitionZoneB, 644.1f, 53.0f, 431.1f, 299.2f, 24.3f);
                case WindingRiverLocation.Random:
                    Location randomLocation = GetWindingRiverLocation((WindingRiverLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(WindingRiverLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetWindingRiverLocation switch fell through! Returning DEFAULT location (Pleasant Valley Farmstead)");
                    return GetWindingRiverLocation(WindingRiverLocation.Cave);
            }
        }

        public static Location GetZoneOfContaminationLocation(ZoneOfContaminationLocation location)
        {
            switch (location)
            {
                case ZoneOfContaminationLocation.IdleCamp:
                    return new Location("Idle Camp", Region.MiningRegion, 433.0f, 237.6f, 197.7f, 318.3f, 10.2f);
                case ZoneOfContaminationLocation.Mine:
                    return new Location("Mine", Region.MiningRegion, -315.8f, 152.0f, -72.9f, 258.0f, 2.1f);
                case ZoneOfContaminationLocation.Trailer:
                    return new Location("Trailer", Region.MiningRegion, -341.7f, 221.6f, -449.2f, 164.5f, -4.1f);
                case ZoneOfContaminationLocation.Random:
                    Location randomLocation = GetZoneOfContaminationLocation((ZoneOfContaminationLocation)UnityEngine.Random.Range(0, Enum.GetNames(typeof(ZoneOfContaminationLocation)).Length - 1));
                    MelonLogger.Msg("GetLocation for " + randomLocation.region.ToString() + " returned " + randomLocation.name + " as Random Location");
                    return randomLocation;
                default:
                    MelonLogger.Msg("ERROR: GetWindingRiverLocation switch fell through! Returning DEFAULT location (Idle Camp)");
                    return GetZoneOfContaminationLocation(ZoneOfContaminationLocation.IdleCamp);
            }
        }
    }
}