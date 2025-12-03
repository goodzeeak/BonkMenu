using BonkMenu.Features;
using BonkMenu.Core;
using BonkMenu.UI.Components;
using UnityEngine;

namespace BonkMenu.UI.Tabs;

/// <summary>
/// Displays mod information, keybinds, and debug options.
/// </summary>
public static class AboutTab
{
    /// <summary>
    /// Builds the About tab UI under the given parent.
    /// </summary>
    public static void Create(GameObject parent)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		UIFactory.CreateSectionHeader("About", parent);
		UIFactory.CreateLabel("BonkMenu v1.0.0", parent);
		UIFactory.CreateLabel("Created by Goodzy", parent);
		UIFactory.CreateSpacer(10, parent);
		UIFactory.CreateSectionHeader("Keybinds", parent);
        UIFactory.CreateKeybindRow("Toggle Menu", () => KeybindConfig.ToggleMenuKey, v => KeybindConfig.ToggleMenuKey = v, parent);
        UIFactory.CreateKeybindRow("Toggle God Mode", () => KeybindConfig.ToggleGodModeKey, v => KeybindConfig.ToggleGodModeKey = v, parent);
        UIFactory.CreateKeybindRow("Toggle Unlimited XP", () => KeybindConfig.ToggleUnlimitedXpKey, v => KeybindConfig.ToggleUnlimitedXpKey = v, parent);
		UIFactory.CreateSpacer(6, parent);
		UIFactory.CreateSectionHeader("Spawnables", parent);
        UIFactory.CreateKeybindRow("Chests", () => KeybindConfig.SpawnChestsKey, v => KeybindConfig.SpawnChestsKey = v, parent);
        UIFactory.CreateKeybindRow("Free Chests", () => KeybindConfig.SpawnFreeChestsKey, v => KeybindConfig.SpawnFreeChestsKey = v, parent);
        UIFactory.CreateKeybindRow("Challenge Shrine", () => KeybindConfig.SpawnChallengeShrinesKey, v => KeybindConfig.SpawnChallengeShrinesKey = v, parent);
        UIFactory.CreateKeybindRow("Cursed Shrine", () => KeybindConfig.SpawnCursedShrinesKey, v => KeybindConfig.SpawnCursedShrinesKey = v, parent);
        UIFactory.CreateKeybindRow("Greed Shrine", () => KeybindConfig.SpawnGreedShrinesKey, v => KeybindConfig.SpawnGreedShrinesKey = v, parent);
        UIFactory.CreateKeybindRow("Greed Altar", () => KeybindConfig.SpawnGreedAltarsKey, v => KeybindConfig.SpawnGreedAltarsKey = v, parent);
        UIFactory.CreateKeybindRow("Magnet Shrine", () => KeybindConfig.SpawnMagnetShrinesKey, v => KeybindConfig.SpawnMagnetShrinesKey = v, parent);
        UIFactory.CreateKeybindRow("Moai Shrine", () => KeybindConfig.SpawnMoaiShrinesKey, v => KeybindConfig.SpawnMoaiShrinesKey = v, parent);
        UIFactory.CreateKeybindRow("Charge Shrine", () => KeybindConfig.SpawnChargeShrinesKey, v => KeybindConfig.SpawnChargeShrinesKey = v, parent);
        UIFactory.CreateKeybindRow("Gold Charge Shrine", () => KeybindConfig.SpawnGoldChargeShrinesKey, v => KeybindConfig.SpawnGoldChargeShrinesKey = v, parent);
        UIFactory.CreateKeybindRow("Pots", () => KeybindConfig.SpawnPotsKey, v => KeybindConfig.SpawnPotsKey = v, parent);
        UIFactory.CreateKeybindRow("Microwaves", () => KeybindConfig.SpawnMicrowavesKey, v => KeybindConfig.SpawnMicrowavesKey = v, parent);
        UIFactory.CreateKeybindRow("Shady Merchant", () => KeybindConfig.SpawnShadyMerchantKey, v => KeybindConfig.SpawnShadyMerchantKey = v, parent);
        UIFactory.CreateKeybindRow("Shady Merchant (Rare)", () => KeybindConfig.SpawnShadyMerchantRareKey, v => KeybindConfig.SpawnShadyMerchantRareKey = v, parent);
        UIFactory.CreateKeybindRow("Shady Merchant (Epic)", () => KeybindConfig.SpawnShadyMerchantEpicKey, v => KeybindConfig.SpawnShadyMerchantEpicKey = v, parent);
        UIFactory.CreateKeybindRow("Shady Merchant (Legendary)", () => KeybindConfig.SpawnShadyMerchantLegendaryKey, v => KeybindConfig.SpawnShadyMerchantLegendaryKey = v, parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("UI / Feedback", parent);
		UIFactory.CreateCircularToggle("Show Toasts", ModConfig.EnableToasts, delegate(bool value)
		{
			ModConfig.EnableToasts = value;
		}, parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateButton("Save Keybinds", delegate { KeybindConfig.SaveKeybinds(); }, parent);
		UIFactory.CreateButton("Reload Keybinds", delegate { KeybindConfig.LoadKeybinds(); }, parent);

        UIFactory.CreateSpacer(15, parent);
        UIFactory.CreateSectionHeader("Debug / Inspection", parent);
        
        UIFactory.CreateCircularToggle("Log Interactables on Hover", DebugFeatures.EnableInteractableLogging, delegate(bool value)
        {
            DebugFeatures.EnableInteractableLogging = value;
        }, parent);
        
        UIFactory.CreateButton("List Spawnable Objects", delegate
        {
            WorldFeatures.ListSpawnableObjects();
        }, parent);
        
		UIFactory.CreateLabel("Check MelonLoader console for output", parent);
	}
}
