using BonkMenu.Features;
using BonkMenu.Core;
using BonkMenu.UI.Components;
using UnityEngine;
using UnityEngine.UI;

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
		UIFactory.CreateCollapsibleSection("About", parent, CreateInfo);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Keybinds", parent, CreateKeybinds);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Spawnables", parent, CreateSpawnableKeybinds);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("UI / Feedback", parent, CreateUiFeedback);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Debug / Inspection", parent, CreateDebugInspection);
	}

	private static void CreateInfo(GameObject parent)
	{
		UIFactory.CreateLabel("BonkMenu v1.0.0", parent);
		UIFactory.CreateLabel("Created by Goodzy", parent);
	}

	private static void CreateKeybinds(GameObject parent)
	{
		UIFactory.CreateKeybindRow("Toggle Menu", () => KeybindConfig.ToggleMenuKey, v => KeybindConfig.ToggleMenuKey = v, parent);
		UIFactory.CreateKeybindRow("Toggle God Mode", () => KeybindConfig.ToggleGodModeKey, v => KeybindConfig.ToggleGodModeKey = v, parent);
		UIFactory.CreateKeybindRow("Toggle Unlimited XP", () => KeybindConfig.ToggleUnlimitedXpKey, v => KeybindConfig.ToggleUnlimitedXpKey = v, parent);
	}

	private static void CreateSpawnableKeybinds(GameObject parent)
	{
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
	}

	private static void CreateUiFeedback(GameObject parent)
	{
		GameObject tGrid = new GameObject("ToggleGrid");
		tGrid.transform.SetParent(parent.transform, false);
		RectTransform tgrt = tGrid.AddComponent<RectTransform>();
		tgrt.sizeDelta = new Vector2(0f, 0f);
		GridLayoutGroup tglg = tGrid.AddComponent<GridLayoutGroup>();
		tglg.cellSize = new Vector2(283f, 30f);
		tglg.spacing = new Vector2(10f, 8f);
		tglg.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
		tglg.constraintCount = 2;
		ContentSizeFitter tfit = tGrid.AddComponent<ContentSizeFitter>();
		tfit.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
		LayoutElement tgle = tGrid.AddComponent<LayoutElement>();
		tgle.flexibleWidth = 1f;
		UIFactory.CreateCircularToggle("Show Toasts", ModConfig.EnableToasts, delegate(bool value)
		{
			ModConfig.EnableToasts = value;
		}, tGrid);
		UIFactory.CreateSpacer(4, parent);
		GameObject bGrid = new GameObject("ButtonGrid");
		bGrid.transform.SetParent(parent.transform, false);
		RectTransform bgrt = bGrid.AddComponent<RectTransform>();
		bgrt.sizeDelta = new Vector2(0f, 0f);
		GridLayoutGroup bglg = bGrid.AddComponent<GridLayoutGroup>();
		bglg.cellSize = new Vector2(283f, 30f);
		bglg.spacing = new Vector2(10f, 8f);
		bglg.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
		bglg.constraintCount = 2;
		ContentSizeFitter bfit = bGrid.AddComponent<ContentSizeFitter>();
		bfit.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
		LayoutElement bgle = bGrid.AddComponent<LayoutElement>();
		bgle.flexibleWidth = 1f;
		UIFactory.CreateButton("Save Keybinds", delegate { KeybindConfig.SaveKeybinds(); }, bGrid);
		UIFactory.CreateButton("Reload Keybinds", delegate { KeybindConfig.LoadKeybinds(); }, bGrid);
	}

	private static void CreateDebugInspection(GameObject parent)
	{
		GameObject grid = new GameObject("DebugGrid");
		grid.transform.SetParent(parent.transform, false);
		RectTransform grt = grid.AddComponent<RectTransform>();
		grt.sizeDelta = new Vector2(0f, 0f);
		GridLayoutGroup glg = grid.AddComponent<GridLayoutGroup>();
		glg.cellSize = new Vector2(283f, 30f);
		glg.spacing = new Vector2(10f, 8f);
		glg.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
		glg.constraintCount = 2;
		ContentSizeFitter fit = grid.AddComponent<ContentSizeFitter>();
		fit.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
		LayoutElement gle = grid.AddComponent<LayoutElement>();
		gle.flexibleWidth = 1f;
		UIFactory.CreateCircularToggle("Log Interactables on Hover", DebugFeatures.EnableInteractableLogging, delegate(bool value)
		{
			DebugFeatures.EnableInteractableLogging = value;
		}, grid);
		UIFactory.CreateButton("List Spawnable Objects", delegate
		{
			WorldFeatures.ListSpawnableObjects();
		}, grid);
		UIFactory.CreateLabel("Check MelonLoader console for output", parent);
	}
}
