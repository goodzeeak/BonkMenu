using BonkMenu.Features;
using BonkMenu.UI.Components;
using UnityEngine;

namespace BonkMenu.UI.Tabs;

public static class UnlocksTab
{
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
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Passive Abilities", parent);
		string[] passives = new string[21]
		{
			"Bullseye", "RngBlessing", "SpeedDemon", "Reinforced", "Flowstate", "CritHappens", "Warrior", "Flex", "WallClimb", "None",
			"Float", "Enduring", "Plague", "Quantum", "Shadowstep", "Gamba", "Vampire", "Curse", "Stonks", "LockIn",
			"Zap"
		};
		for (int num = 0; num < passives.Length; num++)
		{
			int id = num;
			UIFactory.CreateButton("Grant " + passives[num], delegate
			{
				PassiveFeatures.GrantPassive(id, passives[id]);
			}, parent);
		}
	}
}
