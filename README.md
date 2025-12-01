<div align="center">

  <h1>BonkMenu</h1>
  <p>
    A modern MelonLoader mod menu for MegaBonk. Clean UI, rock-solid stability, and a fast workflow with keybinds and live toasts.
  </p>
  <p>
    <img alt=".NET 6" src="https://img.shields.io/badge/.NET-6.0-512BD4?logo=dotnet&logoColor=white" />
    <img alt="MelonLoader" src="https://img.shields.io/badge/MelonLoader-0.7.2%2B-FF4C4C" />
    <img alt="Unity IL2CPP" src="https://img.shields.io/badge/Unity-IL2CPP-000000?logo=unity&logoColor=white" />
    <img alt="Language: C#" src="https://img.shields.io/badge/Language-C%23-239120?logo=csharp&logoColor=white" />
    <img alt="Platform: Windows" src="https://img.shields.io/badge/Platform-Windows-0078D6?logo=windows&logoColor=white" />
  </p>

</div>

## Overview
BonkMenu adds a polished in-game menu, quick toggles, and spawn helpers designed for MegaBonk. It uses UniverseLib (IL2CPP) for UI and includes bottom-right Windows-style toasts that aggregate counts while you hold a key.

## Highlights
- Organized menu with tabs and a minimal dark theme
- Keybind-driven actions with live toasts (no spam; counts update: `×N`)
- UI state sync with keybinds (toggles reflect changes instantly)
- IL2CPP-safe Unlimited XP (deferred and guarded to prevent crashes)

## Table of Contents
- [Requirements](#requirements)
- [Quick Start](#quick-start)
- [Keybinds](#keybinds)
- [Usage](#usage)
- [Configuration](#configuration)
- [Development](#development)
- [Troubleshooting](#troubleshooting)

## Requirements
- MelonLoader `>= 0.7.2.2367` (recommended)
- UniverseLib IL2CPP build (bundled in this repo)
  - The repo ships `Libs/UniverseLib.IL2CPP.dll` and other required stubs so you can build immediately after cloning.

## Quick Start
1. Install MelonLoader for MegaBonk.
2. Download the prebuilt `BonkMenu.dll` from releases or build it yourself.
3. Drop `BonkMenu.dll` into MegaBonks `Mods` folder.
4. Launch the game and press `F1` to open BonkMenu.

## Keybinds
Default bindings (customizable in-game):

| Action | Default Key |
|---|---|
| Toggle Menu | F1 |
| God Mode | F2 |
| Unlimited XP | F3 |
| Chests | 1 |
| Free Chests | 2 |
| Challenge Shrine | 4 |
| Cursed Shrine | 5 |
| Greed Shrine | 6 |
| Magnet Shrine | 7 |
| Moai Shrine | 8 |
| Charge Shrine | 9 |
| Gold Charge Shrine | 0 |
| Pots | F5 |
| Microwaves | F6 |
| Shady Merchant | F7 |
| Shady Merchant (Rare) | F8 |
| Shady Merchant (Epic) | F9 |
| Shady Merchant (Legendary) | F10 |
| Greed Altar | F11 |

Notes:
- Holding a spawn key repeats the action at a safe interval.
- Toasts aggregate per key and update the count: e.g., `Greed Altar ×3`.

## Usage
- Press `F1` to open/close the menu.
- Toggle features via the Player tab; they also sync when triggered by keybinds.
- Use spawn keys to drop objects; a bottom-right toast shows what you spawned and how many.

## Configuration
- In the About tab, use “Save Keybinds” to persist changes or “Reload Keybinds” to re-read preferences.
- Keybinds are stored under the MelonPreferences category `BonkMenu`.

## Development
- Prerequisites: .NET SDK 6+
- Build:
```sh
dotnet build
```
- Output: `bin/Debug/net6.0/BonkMenu.dll`
- The repo includes the `Libs` directory (stubs and UniverseLib IL2CPP), so building from a fresh clone should succeed without extra setup.
- A `PostBuild` copy path is present in the project file; update or remove it if your game installation path differs.

## Troubleshooting
- Crash when toggling Unlimited XP: BonkMenu defers the change until runtime objects are ready, but if issues persist, toggle it after the run starts.
- No toasts: ensure overlays are allowed in-game; BonkMenu creates a `BonkMenuCanvas` for UI.
- UniverseLib errors: verify you are using the IL2CPP build bundled under `Libs/UniverseLib.IL2CPP.dll`.

---

Use responsibly. This project is intended for learning, modding, and enhancing user experience.
