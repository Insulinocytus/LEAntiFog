# Last Epoch Anti-fog

A mod that removes the fog of war from the game map.  
The mod sets the minimap's reveal radius to 999 when each minimap is initialized, so a newly loaded area is revealed.

Tested in game with MelonLoader v0.7.3 Open-Beta and Last Epoch 1.4.7.

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
