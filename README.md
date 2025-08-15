# Last Epoch Anti-fog

A mod that removes the fog of war from the game map.
It is well known that the game uses a circular collision box centered around a player to explore the fog of war.
This mod simply sets the range of this circle to a larger value every time a scene is loaded.

Tested in MelonLoader v0.7.1 Open-Beta + game version 1.2.7.0.

## How to install

- Download `LEAntiFog.dll`
- Install [MelonLoader](https://github.com/LavaGang/MelonLoader)
- At least start the game once (let MelonLoader create the folder)
- Move `LEAntiFog.dll` into Mods folder

## How to build

- Install [MelonLoader](https://github.com/LavaGang/MelonLoader)
- At least start the game once (let MelonLoader create the folder)
- Clone this repo
- Copy /path/to/game/MelonLoader to this repo
- Run `dotnet restore` then `dotnet build`
