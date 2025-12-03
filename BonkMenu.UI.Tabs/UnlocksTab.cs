using BonkMenu.Features;
using BonkMenu.UI.Components;
using UnityEngine;
using UnityEngine.UI;

namespace BonkMenu.UI.Tabs;

/// <summary>
/// Provides shortcuts for global and character unlocks.
/// </summary>
public static class UnlocksTab
{
    /// <summary>
    /// Builds the Unlocks tab UI under the given parent.
    /// </summary>
    public static void Create(GameObject parent)
	{
		UIFactory.CreateCollapsibleSection("Global Unlocks", parent, CreateGlobalUnlocks);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Character Progression", parent, CreateCharacterProgression);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Toggle System", parent, CreateToggleSection);
	}

	private static void CreateGlobalUnlocks(GameObject parent)
	{
		GameObject grid = new GameObject("GlobalUnlocksGrid");
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
		UIFactory.CreateButton("\ud83d\udd13 Unlock EVERYTHING", delegate
		{
			UnlockFeatures.UnlockEverything();
		}, grid);
		UIFactory.CreateButton("\ud83d\udd13 Unlock All Characters", delegate
		{
			UnlockFeatures.UnlockAllCharacters();
		}, grid);
		UIFactory.CreateButton("\ud83d\udd13 Unlock All Skins", delegate
		{
			UnlockFeatures.UnlockAllSkins();
		}, grid);
		UIFactory.CreateButton("\ud83d\udd13 Unlock All Maps", delegate
		{
			UnlockFeatures.UnlockAllMaps();
		}, grid);
	}

	private static void CreateCharacterProgression(GameObject parent)
	{
		GameObject grid = new GameObject("CharacterProgressGrid");
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
		UIFactory.CreateButton("⭐ Max Rank All Characters", delegate
		{
			UnlockFeatures.MaxRankAllCharacters();
		}, grid);
	}

	private static void CreateToggleSection(GameObject parent)
	{
		UIFactory.CreateLabel("Enable toggling of weapons, tomes, and items in the game's unlocks menu", parent);
		UIFactory.CreateSpacer(4, parent);
		
		UIFactory.CreateCircularToggle(
			"Enable Weapon/Tome/Item Toggles", 
			TogglePatches.IsEnabled(), 
			(isOn) =>
			{
				TogglePatches.SetEnabled(isOn);
				UIFactory.ShowToast($"Toggle system: {(isOn ? "Enabled" : "Disabled")}");
			}, 
			parent
		);
	}
}
