# Choose Starting Location
All credit goes to [Cass](https://github.com/GruffCassquatch) for creating this mod.

Updated for TLD version v2.51

Allows you to choose your starting location when starting a new Sandbox game. 
The idea is to add more variety and to allow better roleplaying/storytelling options. 
This mod is designed to work alongside [ChooseStartingGear](https://github.com/moosemeat817/ChooseStartingGearRedux/releases) and [ChooseStartingCondition](https://github.com/Sm4rtBoyTom/ChooseStartingConditions/releases) for a completely custom start. These mods, and more, can also be found at [TLDMods.com](https://tldmods.com/)      

* You can choose your location even on Interloper and Misery!
* Includes ALL regions, not just the usual new game options
* All regions and locations are also available as Random options

## The mod will not work on Challenges or Story Mode, it is only for new Survival sandbox games.


## Requirements
[MelonLoader](https://melonwiki.xyz/#/) (v0.7.2)

[ModSettings](https://github.com/DigitalzombieTLD/ModSettings/)

## Installation:
1. Download ```ChooseStartingLocation.dll``` from [releases](https://github.com/Ezinw/ChooseStartingLocation/releases)
2. Drop ```ChooseStartingLocation.dll``` into your Mods folder
3. If you are updating from an older version, delete the ```ChooseStartingLocation.json``` from your Mods folder as old json's can cause errors if the mod's Settings have been changed

## Uninstallation:
Delete ```ChooseStartingLocation.dll``` and ```ChooseStartingLocation.json``` files from your Mods folder

## Using The Mod
1. Open the ```Options``` menu
2. Open the ```Mod Settings``` menu
3. Scroll across to the ```Choose Starting Location``` menu
4. Mod Options:
	* ```Disabled:``` Mod is disabled; a new game will be completely unmodified
	* ```Custom Coordinates:``` You can enter in your own custom starting coordinates
		* Choose your starting Region
		* Enter you Coordinates and optionally, your Rotation
		* It is easier to move the slider to the rough number you want with the mouse, then use the left/right arrow keys on your keyboard to get to the exact number. You can also manually enter the numbers in the json file and then launch the game.
		* To easily find coordinates for a location, go to the spot you like and use the debug screenshot key ```F8``` (by default)
		* The screenshot should be saved to your Desktop (by default), open it
		* The 3rd line with 3 numbers in brackets are the coordinates; enter them in the same order as they appear (X, Y, Z)
		* The 4th line with 2 numbers in brackets is the rotation (the direction the player is facing); enter these as they appear (X, Y)
		* You can reach interesting locations using the ```fly``` console command with [DeveloperConsole](https://github.com/DigitalzombieTLD/TLD-Developer-Console/releases), press ```space bar``` to land
	* ```Location List:``` You can choose from a list of Regions and Locations, or select Random
		* Select a starting Region
		* Select a starting Location from the list
		* Selecting Random for Region will select a random location from all locations included in the mod
		* Selecting a specific Region and then selecting Random for Location will select a random location from the list of all locations in that Region
5. Click ```CONFIRM``` to apply your changes or ```BACK``` to exit without applying changes
6. Start a new Survival Mode game as usual
	* It does not matter what you select when you get to the Region selection screen. If the mod is enabled, it will override any choice you make here
	* All other steps remain unchanged



## Feedback, Questions & Troubleshooting
* [The Long Dark Modding](https://discord.gg/QvFE7VV4WZ) Discord server
	* **Troubleshooting:** 
	    * Post in [#troubleshooting](https://discord.com/channels/322211727192358914/468386891507695628)
		* Or create an issue here on GitHub if you're not on Discord
		* Please note that many indoor locations CANNOT be added as they do not have unique scene names. It is too much work to add and maintain these locations!
		* While the mod is still in the testing phase, it will leave messages in your MelonLoader window. These are to help troubleshoot if something does not work as expected. You should not be worried about any messages unless they are RED.
