using ModSettings;
using System.Reflection;

namespace ChooseStartingLocation
{
    public enum ModFunction
    {
        Disabled, CustomCoords, LocationList
    }

    class ChooseStartingLocationSettings : JsonModSettings
    {
        [Section("Starting Location Options")]
        [Name("Choose Starting Location Mod Options")]
        [Description("DISABLED: This mod will be disabled\nCUSTOM COORDINATES: Enter your own custom coordinates\nLOCATION LIST: Choose from a list of locations ")]
        [Choice("Disabled", "Custom Coordinates", "Location List")]
        public ModFunction modFunction = ModFunction.Disabled;

        [Section("Starting Region")]
        [Name("Choose Starting Region")]
        [Description("This will OVERRIDE the region choice you make when starting a new game")]
        [Choice("Ash Canyon", "Blackrock", /*"Blackrock Prison",*/ "Bleak Inlet", "Broken Railroad", "Coastal Highway", "Crumbling Highway", "Desolation Point", "Forlorn Muskeg", "Forsaken Airfield", "Hushed River Valley", "Keeper's Pass North", 
            "Keeper's Pass South", "Mountain Town", "Mystery Lake", "Pleasant Valley", "Ravine", "Sundered Pass", "Timberwolf Mountain", "Transfer Pass", "Winding River", "Zone of Contamination", "Random")]
        public Region region = Region.AshCanyonRegion;

        [Section("Starting Region")]
        [Name("Choose Starting Region")]
        [Description("This will OVERRIDE the region choice you make when starting a new game")]
        [Choice("Ash Canyon", "Blackrock", /*"Blackrock Prison",*/ "Bleak Inlet", "Broken Railroad", "Coastal Highway", "Crumbling Highway", "Desolation Point", "Forlorn Muskeg", "Forsaken Airfield", "Hushed River Valley", "Keeper's Pass North", 
            "Keeper's Pass South", "Mountain Town", "Mystery Lake", "Pleasant Valley", "Ravine", "Sundered Pass", "Timberwolf Mountain", "Transfer Pass", "Winding River", "Zone of Contamination")]
        public CustomRegion customRegion = CustomRegion.AshCanyonRegion;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Angler's Den", "Bitter Marsh", "Broad Falls", "Cave", "Cave to Timberwolf Mountain", "Climber's Cave", "Fire Overlook", "Foreman's Retreat", "Gold Mine", "High Camp", "High Meadow", "Homesteader's Respite", 
            "Long Falls", "Miner's Folly", "Mining Camp", "Narrow Falls Cave", "Pillar's Footrest", "Runaway Bridge", "Secluded Camp", "Shattered Cove", "Sheltered Camp", "Stone Shelf Cave", "Viewpoint Camp", 
            "Wolf's Jaw Overlook", "Random")]
        public AshCanyonLocation ashCanyonLocation = AshCanyonLocation.AnglersDen;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Bear's Bend", "Blocked Bridge", "Bricklayer's Retreat", "Cliff Cave", "Cook's Farm", "Creek Bed Cave", "Cutty's Cave", "Fool's Corner", "Forager's Remnant", "Foreman's Clearcut", "Grand Meadow", 
            "Jailer's Residence", "Last Prospect", "Lineworker's Hideout", "Mule Bridge (Lower)", "Mule Bridge (Upper)", "Narrow Bridge", "No Road Cave", "Old Substation", "Power Plant", "Steam Tunnels", "Trailer", 
            "Wedge Cave", "Whistling Perch", "Random")]
        public BlackrockLocation blackrockLocation = BlackrockLocation.BearsBend;

        /*[Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Cells", "Gatehouse", "Guard Room", "Hiding Spot", "Infirmary", "Maintenance Shed", "Rooftop", "Staff Quarters", "Steam Tunnels", "Warden's Office", "Watchtower", "Random")]
        public BlackrockPrisonLocation blackrockPrisonLocation = BlackrockPrisonLocation.Cells;*/

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Cabin", "Cannery Pier", "Cannery Worker Residences", "Cannery Workshop", "Cave (Central)", "Cave (North East)", "Cave (South East)", "Cave (South West)", "Cave (West)", "Cave to Forlorn Muskeg", 
            "Coastal Highway Terminus", "Coast Mountain Road", "Echo One Radio Tower", "Fallen Lighthouse", "Frozen Delta", "Hunter's Blind (East)", "Hunter's Blind (North)", "Hunter's Blind (West)", "Landslide", 
            "Last Resort Cannery", "Long Bridge", "Lower Raven Falls", "Pensive Lookout", "Raven Crossing", "Ravine's End Waterfall", "Secret Mountain Path", "Summit at Ravine's End", "Trailer in Cannery", "Trailers", 
            "Washed-Out Trailers", "Random")]
        public BleakInletLocation bleakInletLocation = BleakInletLocation.Cabin;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Broken Bridge", "Cave", "Hunter's Blind", "Hunting Lodge", "Landslide", "Locomotive Engine", "Maintenance Shed", "Rickety Foot Bridge", "Random")]
        public BrokenRailroadLocation brokenRailroadLocation = BrokenRailroadLocation.BrokenBridge;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Abandoned Lookout", "Bear Creek Campground", "Cinder Hills Coal Mine (Lower)", "Cinder Hills Coal Mine (Middle)", "Cinder Hills Coal Mine (Upper)", "Coastal Townsite", "Commuter's Lament", "Fishing Camp", 
            "Jackrabbit Island", "Log Sort", "Misanthrope's Homestead", "Quonset Garage", "Rabbit Grove", "Rockfall", "Silent Clearing", "The Tooth", "Train Unloading", "Waterfront Cottages", "Random")]
        public CoastalHighwayLocation coastalHighwayLocation = CoastalHighwayLocation.AbandonedLookout;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Abandoned Harris Home", "Abandoned Mine #3", "Cave", "Road Collapse", "The Arch", "Random")]
        public CrumblingHighwayLocation crumblingHighwayLocation = CrumblingHighwayLocation.AbandonedHarrisHome;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Abandoned Mine #3", "Abandoned Mine #5", "Blocked Highway", "Broken Bridge", "Cave", "Hibernia Processing", "Katie's Secluded Corner", "Little Island", "Lonely Lighthouse", "Matt's Truck", "Stone Church", 
            "The Riken", "Trailers", "Waterfall", "Random")]
        public DesolationPointLocation desolationPointLocation = DesolationPointLocation.AbandonedMineNo3;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Bunkhouses", "Cave", "Cave to Bleak Inlet", "Hat Creek", "High Blind", "Low Blind", "Marsh Ridge", "Muskeg Overlook", "Old Spence Family Homestead", "Poacher's Camp", "Prepper Cache", "Shortwave Tower", "Waterfall", "Random")]
        public ForlornMuskegLocation forlornMuskegLocation = ForlornMuskegLocation.Bunkhouses;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Control Tower", "Island Cottage", "Justy's Hovel", "Mindful Cabin", "Random")]
        public ForsakenAirfieldLocation forsakenAirfieldLocation = ForsakenAirfieldLocation.ControlTower;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Banner Falls", "Cave to Mountain Town", "Cloudtop Falls", "Forest Knoll", "Ice Cave (North)", "Ice Cave (South)", "Lake Cave", "Landslide", "Little Bear and Cub Falls", "Lonely Cave", "Long Shot Falls", 
            "Mammoth Falls", "Many Falls Vista", "Monolith Lake", "Moose Overlook", "Mysterious Signal Fire", "Offset Falls", "Peak Cave", "Pensive Vista", "Quarrelling Falls", "Reclusive Falls", "Riverside Camp", "Secluded Camp", 
            "Stairsteps Lake", "Twin Sisters Falls", "Valley Cave", "Valley View Point", "Vista Camp", "Watchful Falls", "Random")]
        public HushedRiverValleyLocation hushedRiverValleyLocation = HushedRiverValleyLocation.BannerFalls;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Builder's Bridge", "Cave to Keeper's Pass South", "Forester's Hermitage", "Random")]
        public KeepersPassNorthLocation keepersPassNorthLocation = KeepersPassNorthLocation.BuildersBridge;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Cave to Keeper's Pass North", "Fishing Hut", "Mirthless Fork", "Scenic View", "The Toe", "Random")]
        public KeepersPassSouthLocation keepersPassSouthLocation = KeepersPassSouthLocation.CaveKPN;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Cave (Climbing Area)", "Cave (Deep)", "Cave (Near Radio Tower)", "Cave to Hushed River Valey", "Cave to Mystery Lake", "Crashed Plane", "Crashed Prison Transport Bus", "Graveyard", "Grey Mother's House", 
            "Hermit's Cabin", "Milton Basin", "Milton Credit Union", "Milton House", "Milton Park", "Milton Post Office", "Old Schoolhouse", "Orca Gas Station", "Paradise Meadows Farm", "Park Office", "Picnic Area", "Prepper Cache", "Radio Tower", 
            "Rocky Refuge", "Side of the Road", "Spruce Falls Bridge", "St. Christopher's Church", "The Arch", "Town of Milton", "Trailer", "Wood Lot (Northern)", "Wood Lot (South Eastern)", "Wood Lot (South Western)", "Random")]
        public MountainTownLocation mountainTownLocation = MountainTownLocation.CaveClimbingArea;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Alan's Cave", "Camp Office", "Carter Hydro Dam", "Cave to Mountain Town", "Cave (Unnamed)", "Clearcut", "Dave's Quiet Clearing", "Deadfall Area", "Derailment", "Destroyed Lookout", "Forestry Lookout", 
            "Frozen Creek", "Hunter's Blind at Alan's Cave", "Ice Fishing Huts", "Lake Cabin (Lone)", "Lake Cabins (South Eastern)", "Lake Cabins (South Western)", "Lake Overlook", "Logging Camp", "Lookout Spot", "Max's Last Stand",
            "Prepper Cache", "Rail Tunnel", "River (Northern Access)", "River (Southern Access)", "Mystery Lake", "Mystery Lake (Western Access)", "Train Bridge", "Train Loading Area", "Trapper's Cabin", "Unnamed Pond", "Random")]
        public MysteryLakeLocation mysteryLakeLocation = MysteryLakeLocation.AlansCave;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Barn (Large)", "Barn (Small)", "Burned Ridge Cave", "Cascading Falls", "Cave", "Cave to Winding River", "Church", "Cinder Hills Coal Mine", "Community Hall", "Contemplation Bridge", "Crash Site", 
            "Derelict Cabins", "Draft Dodger's Cabin", "End of the Road", "Forest Cave", "Heartbreak Bridge", "Hilltop Cave", "Hunter's Blind (East)", "Hunter's Blind (West)", "Lonely Homestead", "Long Curve", "Lower Falls", 
            "Misty Falls Picnic Area", "Pensive Pond", "Picnic Spot", "Pleasant Valley Farmstead", "Pleasant Valley Outbuildings", "Point of Disagreement", "Prepper's Abandoned Cache", "Radio Control Hut", "Signal Hill", 
            "Skeeter's Ridge", "Thomson's Crossing", "Three Strikes Farmstead", "Upper Falls", "Random")]
        public PleasantValleyLocation pleasantValleyLocation = PleasantValleyLocation.BarnLarge;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Cave (Lower)", "Cave (Upper)", "Raven Falls Trestle", "Ravine Basin", "Shunting Yard", "Train Car", "Random")]
        public RavineLocation ravineLocation = RavineLocation.CaveLower;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Final Refuge", "Last Lonely House", "Lotte's Rest", "Weather Station", "Random")]
        public SunderedPassLocation sunderedPassLocation = SunderedPassLocation.FinalRefuge;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Andre's Peak", "Cave (Large Open)", "Cave (Lower)", "Cave (Upper)", "Cave (Unnamed)", "Cave to Ash Canyon", "Chasm Cave", "Crystal Lake", "Deer Clearing", "Echo Peak East", "Echo Peak West", "Echo Ravine", 
            "Engine", "Eric's Falls", "Forest Cave", "Landing Gear", "Mountaineer's Hut", "Secluded Shelf", "Summit", "Summit Cave", "Tail Section", "Waterfall Cave", "Wing", "Random")]
        public TimberwolfMountainLocation timberwolfMountainLocation = TimberwolfMountainLocation.AndresPeak;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Vacant Depot", "Random")]
        public TransferPassLocation transferPassLocation = TransferPassLocation.VacantDepot;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Cave", "Cave to Pleasant Valley", "Dam", "Hilltop", "Sheltered Spot", "Random")]
        public WindingRiverLocation windingRiverLocation = WindingRiverLocation.Cave;

        [Section("Starting Location")]
        [Name("Choose Starting Location")]
        [Choice("Idle Camp", "Mine", "Trailer", "Random")]
        public ZoneOfContaminationLocation zoneOfContminationLocation = ZoneOfContaminationLocation.IdleCamp;


        [Section("Custom Coordinates")]
        [Name("X Coordinate")]
        [Description("Enter X coordinate (can manually enter value in json instead, restart the game to see the change)")]
        [Slider(-2000f, 3000f, 50001, NumberFormat = "{0:0.0}")]
        public float x = 0.0f;

        [Name("Y Coordinate")]
        [Description("Enter Y coordinate (can manually enter value in json instead, restart the game to see the change)")]
        [Slider(-2000f, 3000f, 50001, NumberFormat = "{0:0.0}")]
        public float y = 0.0f;

        [Name("Z Coordinate")]
        [Description("Enter Z coordinate (can manually enter value in json instead, restart the game to see the change)")]
        [Slider(-2000f, 3000f, 50001, NumberFormat = "{0:0.0}")]
        public float z = 0.0f;

        [Section("Custom Rotation (Optional)")]
        [Name("X Coordinate")]
        [Description("Enter X coordinate ((can manually enter value in json instead, restart the game to see the change)")]
        [Slider(-360f, 360, 7201, NumberFormat = "{0:0.0}")]
        public float rotationX = 0.0f;

        [Name("Y Coordinate")]
        [Description("Enter Y coordinate (can manually enter value in json instead, restart the game to see the change)")]
        [Slider(-90f, 90, 1801, NumberFormat = "{0:0.0}")]
        public float rotationY = 0.0f;

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(modFunction) ||
                field.Name == nameof(region) ||
                field.Name == nameof(ashCanyonLocation) ||
                field.Name == nameof(blackrockLocation) ||
                field.Name == nameof(bleakInletLocation) ||
                field.Name == nameof(brokenRailroadLocation) ||
                field.Name == nameof(coastalHighwayLocation) ||
                field.Name == nameof(crumblingHighwayLocation) ||
                field.Name == nameof(desolationPointLocation) ||
                field.Name == nameof(forlornMuskegLocation) ||
                field.Name == nameof(forsakenAirfieldLocation) ||
                field.Name == nameof(hushedRiverValleyLocation) ||
                field.Name == nameof(mountainTownLocation) ||
                field.Name == nameof(mysteryLakeLocation) ||
                field.Name == nameof(pleasantValleyLocation) ||
                field.Name == nameof(ravineLocation) ||
                field.Name == nameof(sunderedPassLocation) ||
                field.Name == nameof(timberwolfMountainLocation) ||
                field.Name == nameof(transferPassLocation) ||
                field.Name == nameof(windingRiverLocation) ||
                field.Name == nameof(zoneOfContminationLocation))
            {
                RefreshFields();
            }
        }

        internal void RefreshFields()
        {
            SetFieldVisible(nameof(region), Settings.settings.modFunction == ModFunction.LocationList);
            SetFieldVisible(nameof(customRegion), Settings.settings.modFunction == ModFunction.CustomCoords);

            SetFieldVisible(nameof(ashCanyonLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.AshCanyonRegion);
            SetFieldVisible(nameof(blackrockLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.BlackrockRegion);
            //SetFieldVisible(nameof(blackrockPrisonLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.BlackrockPrisonSurvivalZone);
            SetFieldVisible(nameof(bleakInletLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.CanneryRegion);
            SetFieldVisible(nameof(brokenRailroadLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.TracksRegion);
            SetFieldVisible(nameof(coastalHighwayLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.CoastalRegion);
            SetFieldVisible(nameof(crumblingHighwayLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.HighwayTransitionZone);
            SetFieldVisible(nameof(desolationPointLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.WhalingStationRegion);
            SetFieldVisible(nameof(forlornMuskegLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.MarshRegion);
            SetFieldVisible(nameof(forsakenAirfieldLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.AirfieldRegion);
            SetFieldVisible(nameof(hushedRiverValleyLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.RiverValleyRegion);
            SetFieldVisible(nameof(keepersPassNorthLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.BlackrockTransitionZone);
            SetFieldVisible(nameof(keepersPassSouthLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.CanyonRoadTransitionZone);
            SetFieldVisible(nameof(mountainTownLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.MountainTownRegion);
            SetFieldVisible(nameof(mysteryLakeLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.LakeRegion);
            SetFieldVisible(nameof(pleasantValleyLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.RuralRegion);
            SetFieldVisible(nameof(ravineLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.RavineTransitionZone);
            SetFieldVisible(nameof(sunderedPassLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.MountainPassRegion);
            SetFieldVisible(nameof(timberwolfMountainLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.CrashMountainRegion);
            SetFieldVisible(nameof(transferPassLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.HubRegion);
            SetFieldVisible(nameof(windingRiverLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.DamRiverTransitionZoneB);
            SetFieldVisible(nameof(zoneOfContminationLocation), Settings.settings.modFunction == ModFunction.LocationList && Settings.settings.region == Region.MiningRegion);

            SetFieldVisible(nameof(x), Settings.settings.modFunction == ModFunction.CustomCoords);
            SetFieldVisible(nameof(y), Settings.settings.modFunction == ModFunction.CustomCoords);
            SetFieldVisible(nameof(z), Settings.settings.modFunction == ModFunction.CustomCoords);
            SetFieldVisible(nameof(rotationX), Settings.settings.modFunction == ModFunction.CustomCoords);
            SetFieldVisible(nameof(rotationY), Settings.settings.modFunction == ModFunction.CustomCoords);
        }
    }

    internal static class Settings
    {
        public static ChooseStartingLocationSettings settings;
        public static void OnLoad()
        {
            settings = new ChooseStartingLocationSettings();
            settings.AddToModSettings("Choose Starting Location");
            settings.RefreshFields();
        }
    }
}
