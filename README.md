# Last Epoch Anti-fog

A mod that removes the fog of war from the game map.  
As is well known, the game uses a circular collision detection area centered on the player to reveal areas through the fog of war. This mod simply expands the range of this circle to a much larger value each time a scene is loaded.  
  
Tested with MelonLoader v0.7.1 Open-Beta + game version 1.2.7.0.

## How to install

- Download `LEAntifog.dll`
- Install [MelonLoader](https://github.com/LavaGang/MelonLoader)
- Start the game at least once (to let MelonLoader create the `Mods` folder)
- Move `LEAntifog.dll` into the `Mods` folder

## How to build

- Install [MelonLoader](https://github.com/LavaGang/MelonLoader)
- Start the game at least once (to let MelonLoader create the `MelonLoader` folder)
- Clone this repository
- Copy the `MelonLoader` folder from your game directory to this repository
- Run `dotnet restore` then `dotnet build` (or `dotnet build --configuration Release`)
