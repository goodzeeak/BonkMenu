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
		UIFactory.CreateKeybindRow("Toggle Menu", KeybindConfig.ToggleMenuKey, parent);
		UIFactory.CreateKeybindRow("Toggle God Mode", KeybindConfig.ToggleGodModeKey, parent);
		UIFactory.CreateKeybindRow("Toggle Unlimited XP", KeybindConfig.ToggleUnlimitedXpKey, parent);
		UIFactory.CreateSpacer(6, parent);
		UIFactory.CreateSectionHeader("Spawnables", parent);
		UIFactory.CreateKeybindRow("Chests", KeybindConfig.SpawnChestsKey, parent);
		UIFactory.CreateKeybindRow("Free Chests", KeybindConfig.SpawnFreeChestsKey, parent);
		UIFactory.CreateKeybindRow("Challenge Shrine", KeybindConfig.SpawnChallengeShrinesKey, parent);
		UIFactory.CreateKeybindRow("Cursed Shrine", KeybindConfig.SpawnCursedShrinesKey, parent);
        UIFactory.CreateKeybindRow("Greed Shrine", KeybindConfig.SpawnGreedShrinesKey, parent);
        UIFactory.CreateKeybindRow("Greed Altar", KeybindConfig.SpawnGreedAltarsKey, parent);
		UIFactory.CreateKeybindRow("Magnet Shrine", KeybindConfig.SpawnMagnetShrinesKey, parent);
		UIFactory.CreateKeybindRow("Moai Shrine", KeybindConfig.SpawnMoaiShrinesKey, parent);
		UIFactory.CreateKeybindRow("Charge Shrine", KeybindConfig.SpawnChargeShrinesKey, parent);
		UIFactory.CreateKeybindRow("Gold Charge Shrine", KeybindConfig.SpawnGoldChargeShrinesKey, parent);
		UIFactory.CreateKeybindRow("Pots", KeybindConfig.SpawnPotsKey, parent);
		UIFactory.CreateKeybindRow("Microwaves", KeybindConfig.SpawnMicrowavesKey, parent);
		UIFactory.CreateKeybindRow("Shady Merchant", KeybindConfig.SpawnShadyMerchantKey, parent);
		UIFactory.CreateKeybindRow("Shady Merchant (Rare)", KeybindConfig.SpawnShadyMerchantRareKey, parent);
		UIFactory.CreateKeybindRow("Shady Merchant (Epic)", KeybindConfig.SpawnShadyMerchantEpicKey, parent);
		UIFactory.CreateKeybindRow("Shady Merchant (Legendary)", KeybindConfig.SpawnShadyMerchantLegendaryKey, parent);
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
