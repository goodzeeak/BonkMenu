using BonkMenu.Features;
using BonkMenu.UI.Components;
using UnityEngine;

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
		UIFactory.CreateSectionHeader("Global Unlocks", parent);
		UIFactory.CreateButton("\ud83d\udd13 Unlock EVERYTHING", delegate
		{
			UnlockFeatures.UnlockEverything();
		}, parent);
		UIFactory.CreateButton("\ud83d\udd13 Unlock All Characters", delegate
		{
			UnlockFeatures.UnlockAllCharacters();
		}, parent);
		UIFactory.CreateButton("\ud83d\udd13 Unlock All Skins", delegate
		{
			UnlockFeatures.UnlockAllSkins();
		}, parent);
		UIFactory.CreateButton("\ud83d\udd13 Unlock All Maps", delegate
		{
			UnlockFeatures.UnlockAllMaps();
		}, parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Character Progression", parent);
		UIFactory.CreateButton("⭐ Max Rank All Characters", delegate
		{
			UnlockFeatures.MaxRankAllCharacters();
		}, parent);

	}
}
