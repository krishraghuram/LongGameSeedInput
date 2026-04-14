# LongGameSeedInput

A small [SMAPI](https://smapi.io/) mod for Stardew Valley that increases the character limit of the **Random Seed** text box in Advanced Game Options from 9 to 20 digits.

## The Problem

The Random Seed input in Advanced Game Options has a hardcoded limit of 9 characters, making it impossible to enter seeds with 10 or more digits. Paste also doesn't work reliably on some platforms (e.g. Ubuntu via Steam Proton).

## Installation

1. Install [SMAPI](https://smapi.io/).
2. Download the latest release and extract it into your `Mods` folder.
3. Launch the game through SMAPI.

## Usage

No configuration needed. The seed input box in Advanced Game Options will now accept up to 15 digits.

## Compatibility

- Stardew Valley 1.6+
- SMAPI 4.0+
- Should be compatible with any other mod that doesn't also patch `AdvancedGameOptions.PopulateOptions`

## How It Works

Uses [Harmony](https://github.com/pardeike/Harmony) to postfix-patch `AdvancedGameOptions.PopulateOptions` and raise the `textLimit` on the seed text box from 9 to 15. The game already uses `ulong` to parse the seed value, which supports up to 20 digits, so no other changes are needed.
