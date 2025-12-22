<div align="center">

  <h1>BonkMenu</h1>
  <p>
    A focused MelonLoader mod menu for <strong>Megabonk</strong>. BonkMenu gives you fast, safe control over player stats, enemy scaling, loot, and spawns through a clean in‑game UI and keybinds.
  </p>
  <p>
    <img alt=".NET 6" src="https://img.shields.io/badge/.NET-6.0-512BD4?logo=dotnet&logoColor=white" />
    <img alt="MelonLoader" src="https://img.shields.io/badge/MelonLoader-0.7.2%2B-FF4C4C" />
    <img alt="Unity IL2CPP" src="https://img.shields.io/badge/Unity-IL2CPP-000000?logo=unity&logoColor=white" />
    <img alt="Language: C#" src="https://img.shields.io/badge/Language-C%23-239120?logo=csharp&logoColor=white" />
    <img alt="Platform: Windows" src="https://img.shields.io/badge/Platform-Windows-0078D6?logo=windows&logoColor=white" />
  </p>

</div>

---

## 🚀 TL;DR Install

1. Patch Megabonk with MelonLoader (IL2CPP) and confirm the MelonLoader console appears on launch.
2. Build `BonkMenu.dll` with `dotnet build` (see [Development](#development)), then copy it into your `Megabonk/Mods` folder.
3. Copy the exact `Libs/UniverseLib.IL2CPP.dll` from this repo into the same `Megabonk/Mods` folder next to `BonkMenu.dll`.
4. Launch the game and press `F1` to open BonkMenu.

## 🧠 Overview

BonkMenu is a feature‑rich mod menu for the game `Megabonk` (MelonLoader `[assembly: MelonGame("Ved", "Megabonk")]`, `Properties/AssemblyInfo.cs:3`). It is built for IL2CPP, uses UniverseLib for the UI, and ships with focused patches for combat, enemy scaling, loot, and XP so you can script your runs without constantly alt‑tabbing or editing saves.

Core behaviors are implemented in `BonkMenu.Core/BonkMenuMod.cs` and exposed through a tabbed UniverseLib UI (`BonkMenu.UI/UniverseUI.cs`), with most game logic broken out into small feature modules under `BonkMenu.Features/*`.

BonkMenu is single‑player focused. It touches game balance heavily; treat it as a sandbox or training tool, not something you use on shared leaderboards.

## ✨ Features

- 🧍 Player control
  - Toggle God Mode, infinite health/shield, infinite jumps, and max luck (`BonkMenu.Core/ModConfig.cs`).
  - Freeze enemies, remove cooldowns, and enable one‑hit kills for fast testing.
- 📈 XP and progression
  - Unlimited XP toggle that safely uncaps the XP multiplier by caching and updating the underlying fields only when the run is actually active (`BonkMenu.Core/BonkMenuMod.cs:213`).
  - Optional uncapped weapon and tome level caps (global or per‑name).
- 🧪 Enemy scaling
  - Direct Harmony patches for enemy HP, damage, speed, size, spawn rate, and elite chance (`BonkMenu.UI/BonkMenu.Patches/EnemyScalingPatches.cs`).
  - Scaling values are driven by stats and can be tuned live from the Combat tab.
- 💰 Loot and economy
  - Spawn chests, shrines, pots, microwaves, merchants, and altars from hotkeys (`BonkMenu.Core/BonkMenuMod.cs:213`).
  - Free purchases, infinite refreshes, and silver injection through the Player/Loot tabs.
- 🖥️ UI and feedback
  - Tabbed UniverseLib UI with a minimal dark theme (`BonkMenu.UI/UniverseUI.cs`).
  - Bottom‑right toast notifications that aggregate counts per action instead of spamming (`BonkMenu.UI.Components/UIFactory.cs`).
  - Keybind changes are reflected in the UI, and toggles stay in sync with runtime state.
- 🛡️ Safety‑oriented design
  - XP uncap logic is deferred until the `GameManager` and `player.inventory` are valid to avoid IL2CPP null access (`BonkMenu.Core/BonkMenuMod.cs:213`).
  - Enemy spawn patches avoid affecting bosses and shrines and allow “off” states for spawn rate when set to zero (`EnemyScalingPatches.ShouldAffectSpawn`, `EnemyScalingPatches.GetSpawnRateMultiplier`).

## 🧭 Table of Contents

- [🚀 TL;DR Install](#tldr-install)
- [🧠 Overview](#overview)
- [✨ Features](#features)
- [📦 Requirements](#requirements)
- [🛠️ Installation](#installation)
- [⚡ Quick Start](#quick-start)
- [🎮 In‑Game Usage](#in-game-usage)
- [⌨️ Default Keybinds](#default-keybinds)
- [🧩 Tabs & Capabilities](#tabs--capabilities)
- [⚙️ Configuration & Saves](#configuration--saves)
- [🧪 Development](#development)
- [⚠️ Known Limitations](#known-limitations)
- [🧯 Troubleshooting](#troubleshooting)
- [📜 Disclaimer](#disclaimer)

## 📦 Requirements

- Windows
- Megabonk (IL2CPP build)
- MelonLoader `>= 0.7.2.2367`
- .NET 6 SDK (for building from source)
- The bundled IL2CPP libraries in `Libs/` (including `Libs/UniverseLib.IL2CPP.dll`, MelonLoader, Unity assemblies, and game stubs) for building

The `BonkMenu.csproj` (`BonkMenu.csproj:1`) is wired to use the local `Libs/` directory so you can build directly after cloning without dragging assemblies out of your game folder manually.

At runtime, **the exact UniverseLib build shipped with this repo** at `Libs/UniverseLib.IL2CPP.dll` must live in your game’s `Mods` (or `Plugins`) folder next to `BonkMenu.dll`. This DLL has been reverse‑engineered and rebuilt specifically for Megabonk; do not swap it for an upstream or different UniverseLib build.

## 🛠️ Installation

### 1. Install MelonLoader for Megabonk

- Run the MelonLoader installer against the `Megabonk` executable so the game is actually patched.
- Follow the official MelonLoader documentation for **IL2CPP** titles.
- Launch the game once and confirm the MelonLoader console appears before adding this mod.

### 2. Install BonkMenu

Build from source:

- Clone the repository into any folder.
- Ensure the `Libs/` folder is present (it is committed to the repo).
- Run `dotnet build` from the repo root.
- The compiled `BonkMenu.dll` will be in `bin/Debug/net6.0` by default.
- Copy the built `BonkMenu.dll` into your game’s `Mods` folder.
- Also copy `Libs/UniverseLib.IL2CPP.dll` from this repository into that same `Mods` folder so MelonLoader can load UniverseLib at runtime. Again, this specific DLL is required; mixing versions will almost certainly break the UI patches.

### 3. Verify

- Launch Megabonk.
- Watch the MelonLoader console; you should see `=== BonkMenu Initialized ===` (`BonkMenu.Core/BonkMenuMod.cs:54`).
- By default, pressing `F1` will open the BonkMenu UI.

## ⚡ Quick Start

1. Start a run in Megabonk.
2. Press `F1` to toggle the BonkMenu panel.
3. Use the **Player** tab to enable God Mode or other safety toggles.
4. Use spawn keybinds to drop chests/shrines/merchants while watching the bottom‑right toasts for counts.
5. Use the **Combat** tab to adjust enemy HP/damage/speed and overall spawn rate.
6. When finished, disable toggles you no longer need; most settings only affect the current session.

## 🎮 In‑Game Usage

- Menu toggle
  - `F1` by default (`KeybindConfig.ToggleMenuKey`) opens/closes the BonkMenu panel.
  - When the menu is open, player input is redirected to the UI; most hotkeys are ignored while the panel is visible to prevent accidental spawns (`BonkMenu.Core/BonkMenuMod.cs:172`).
- Toggles
  - Player and combat toggles live under the **Player** and **Combat** tabs and are applied via Harmony patches and runtime flags in `ModConfig`.
- Spawns
  - Spawn keybinds only work while the menu is closed.
  - Holding a spawn key repeatedly triggers a spawn at a safe repeat interval (`SpawnRepeatInterval = 0.2f`, `BonkMenu.Core/BonkMenuMod.cs:52`).
  - Spawn actions are funneled through `WorldFeatures` (`BonkMenu.Features/WorldFeatures.cs`) and surfaced as toasts so you can see what you just did.
- Toasts
  - Toasts appear in the bottom‑right via `UIFactory.ShowToast` (`BonkMenu.UI.Components/UIFactory.cs:684`).
  - Repeated actions aggregate into a single toast with a `×N` counter per action instead of spamming a new toast for every spawn.

## ⌨️ Default Keybinds

You can change these in‑game via the **About → Keybinds** section (`BonkMenu.UI.Tabs/AboutTab.cs`), but the defaults are:

| Action                      | Default Key |
|-----------------------------|------------:|
| Toggle Menu                 | `F1`        |
| God Mode                    | `F2`        |
| Unlimited XP                | `F3`        |
| Spawn Chests                | `1`         |
| Spawn Free Chests           | `2`         |
| Spawn Challenge Shrine      | `4`         |
| Spawn Cursed Shrine         | `5`         |
| Spawn Greed Shrine          | `6`         |
| Spawn Magnet Shrine         | `7`         |
| Spawn Moai Shrine           | `8`         |
| Spawn Charge Shrine         | `9`         |
| Spawn Gold Charge Shrine    | `0`         |
| Spawn Pots                  | `F5`        |
| Spawn Microwaves            | `F6`        |
| Spawn Shady Merchant        | `F7`        |
| Spawn Shady Merchant (Rare) | `F8`        |
| Spawn Shady Merchant (Epic) | `F9`        |
| Spawn Shady Merchant (Legendary) | `F10`  |
| Spawn Greed Altar           | `F11`       |

Notes:

- Holding a spawn key repeats the action at a fixed, rate‑limited interval.
- Spawn actions are disabled while the menu is open to avoid conflicts.

## 🧩 Tabs & Capabilities

BonkMenu is organized into several tabs (see `BonkMenu.UI/UniverseUI.cs:54`):

- Player
  - Toggle God Mode, infinite health/shield/jumps.
  - Max luck, free purchases, infinite refreshes, and other player‑centric modifiers.
  - Weapon and tome utilities (e.g., level caps, bulk upgrades) via `PlayerFeatures`, `WeaponFeatures`, `TomeFeatures`.
- Combat
  - Adjust enemy HP, damage, speed, and spawn rate via stat sliders (`BonkMenu.UI.Tabs/CombatTab.cs`).
  - Enemy scaling patches in `EnemyScalingPatches` ensure that the game actually respects these modifiers.
- Items
  - Manage weapons, tomes, and passives directly (`BonkMenu.UI.Tabs/ItemsTab.cs`).
  - Uses lookup tables for known weapon and tome names (`BonkMenu.UI.Tabs/PlayerTab.cs:20` and `:27`).
- Loot
  - Control chests, shrines, pots, and other interactables (`BonkMenu.UI.Tabs/LootTab.cs`).
  - Ties into `WorldFeatures`, `LootConfig`, and specific patches like `PotVariantPatch` and `ShadyGuyVariantPatch`.
- Unlocks
  - Shortcuts for global unlocks and character‑related progression (`BonkMenu.UI.Tabs/UnlocksTab.cs`).
  - Backed by `BonkMenu.Features/UnlockFeatures.cs`, which directly edits `ProgressionSaveFile` to unlock characters, skins, maps, shop items, and achievements. These operations are powerful; back up your save before using them.
- About
  - Version and author info.
  - Keybind editor (using `UIFactory.CreateKeybindRow` and `KeybindConfig`).
  - UI / feedback options (such as enabling/disabling toasts) and some debug/inspection helpers.

## ⚙️ Configuration & Saves

- Keybinds
  - Stored using MelonPreferences under the category `BonkMenu` (`BonkMenu.Core/KeybindConfig.cs:121`).
  - Keybind changes save immediately: every successful rebind updates the underlying `MelonPreferences_Entry` and calls `MelonPreferences.Save()` via the property setters in `KeybindConfig` (`BonkMenu.Core/KeybindConfig.cs:37–121`).
  - To rebind in‑game, open **About → Keybinds**, click a row, then press the desired key (with optional Shift/Ctrl/Alt modifiers). Press `Escape` to cancel without changing the binding, or hold `Shift+Escape` to set the binding to `None` (`BonkMenu.Core/BonkMenuMod.cs:149–171`).
- Runtime flags
  - Most toggles are runtime‑only flags in `ModConfig` and are not persisted across game launches.
  - XP, enemy scaling, and spawn patches are applied at runtime and reset whenever the game process restarts.
- External config files
  - BonkMenu does not introduce custom config file formats; it relies on MelonPreferences and in‑memory state.

## 🧪 Development

- 🧰 Tooling
  - .NET 6 SDK or newer
  - Any modern C# IDE (Rider, VS, VS Code with C# dev kit)
- 🏗️ Build
  - From the repo root, run:

    ```sh
    dotnet build
    ```

  - Output is `bin/Debug/net6.0/BonkMenu.dll` unless you change the configuration.
  - `BonkMenu.csproj` enables Roslyn analyzers and code‑style enforcement (`EnableNETAnalyzers`, `EnforceCodeStyleInBuild`, `AnalysisLevel=latest`) to keep the codebase clean.
- 🗂️ Project structure
  - 🚀 `BonkMenu.Core` – mod entrypoint (`BonkMenuMod`), config (`ModConfig`, `LootConfig`), logging, keybinds, and patch bootstrap (`Patches`).
  - 🎮 `BonkMenu.Features` – self‑contained gameplay chunks (player, combat, loot, unlocks, stats).
  - 🖥️ `BonkMenu.UI` – UniverseLib integration and panel wiring.
  - 🧩 `BonkMenu.UI.Components` – UIFactory helper for building controls and toast notifications.
  - 📑 `BonkMenu.UI.Tabs` – individual tab UIs wired to feature modules.
  - 📚 `Libs` – IL2CPP, Unity, and MelonLoader assemblies required to build.
  - ⚙️ `BonkMenu.csproj` also has a `PostBuild` target that copies both `BonkMenu.dll` and `Libs/UniverseLib.IL2CPP.dll` into your Megabonk `Mods` folder. By default it targets `C:\Program Files (x86)\Steam\steamapps\common\Megabonk\Mods`, but you can override this by setting the `MEGABONK_MODS_DIR` environment variable or by changing the `MegabonkModsDir` property in the project file.

## ⚠️ Known Limitations

- Save integrity
  - While BonkMenu avoids writing to disk directly for most features, abusing XP, stats, or spawn rate may leave your save in a weird state if the game itself records those values.
  - Unlock actions in `BonkMenu.Features/UnlockFeatures.cs` write to the game’s `ProgressionSaveFile`. They are designed to be safe, but always keep backups of your saves before using Unlocks tab actions.
- Stability
  - Extreme values for enemy HP/damage/speed or spawn rate can still harm stability even though patches try to guard against obviously bad settings.
  - Unlimited XP and other caps are wired to IL2CPP internals; if the game updates significantly, expect these features to break until offsets are reviewed.

## 🧯 Troubleshooting

- Mod does not load
  - Confirm MelonLoader is installed and the console shows it scanning `BonkMenu.dll`.
  - Ensure `BonkMenu.dll` is in the correct `Mods` folder for your Megabonk installation.
  - Check that the game is the IL2CPP build that matches the assemblies in `Libs/`.
  - Make sure the game executable has actually been patched with MelonLoader (run the installer against Megabonk at least once).
- Pressing `F1` does nothing
  - Check the MelonLoader console for errors related to UniverseLib or BonkMenu.
  - Verify that the custom `UniverseLib.IL2CPP.dll` from this repo (`Libs/UniverseLib.IL2CPP.dll`) is present in your game’s `Mods` (or `Plugins`) folder next to `BonkMenu.dll`. The copy under this repo’s `Libs/` folder is only a source for that exact DLL; other UniverseLib builds are not supported.
- Crashes or soft locks when enabling Unlimited XP
  - BonkMenu defers XP uncapping until the run has actually started (`GameManager.Instance`, `player`, and `player.inventory` are checked). If you still see issues, only enable Unlimited XP once you are fully in a run and have moved the character at least once.
- Enemy scaling feels wrong
  - Verify your sliders in the Combat tab are set to reasonable values.
  - Remember that some patches multiply base stats; extreme multipliers stack quickly.
- No toasts
  - Make sure “Toasts” is enabled in‑game (tied to `ModConfig.EnableToasts`).
  - Confirm overlays/Unity UI are not being blocked by another overlay or capture tool.

## 📜 Disclaimer

BonkMenu is a single‑player utility mod. It is not affiliated with the Megabonk developers, and it comes with no warranty of any kind.

- Use it at your own risk.
- Do not use it to ruin other players’ experience or to cheat on shared leaderboards.
- Expect that game updates can break or change behavior; always read the code and understand what a feature does before relying on it long‑term.

If you are using BonkMenu as a learning tool, browse the feature and patch modules under `BonkMenu.Features` and `BonkMenu.UI/BonkMenu.Patches` to see how the mod interacts with IL2CPP and Unity. The codebase is intentionally organized into small, composable units to make that exploration easier.
