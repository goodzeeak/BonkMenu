using BonkMenu.Core;
using BonkMenu.Features;
using BonkMenu.UI.Components;
using Il2Cpp;
using Il2CppAssets.Scripts.Actors.Player;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Menu.Shop;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace BonkMenu.UI.Tabs;

public static class CombatTab
{
	private static readonly string[] enemies = new string[41]
	{
		"Skeleton", "GoldenSkeleton", "XpSkeleton", "ArmoredSkeleton", "SkeletonDusty", "ArmoredSkeletonDusty", "Ghoul", "MinibossPig", "Mummy", "Slime",
		"Test", "Test2", "Goblin", "GoblinStrong", "GoblinTank", "MinibossGolem", "Ghost", "GreaterGhost", "SkeletonMage", "Ent1",
		"Ent2", "Ent3", "BoomerSpider", "Golem", "Bee", "MinibossGolemSand", "Scorpion", "MinibossScorpion", "Wisp", "CactusShooter",
		"ScorpionMedium", "MummyTank", "MummyAncient", "Tumblebone", "Pharaoh1", "Pharaoh2", "Pharaoh3", "Bandit", "Bush", "GhostRed",
		"GhostPurple"
	};

	public static void Create(GameObject parent)
	{
		UIFactory.CreateSectionHeader("Toggles", parent);
		CreateToggles(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Enemy Modifiers", parent);
		CreateEnemyModifiers(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Enemy Spawning", parent);
		CreateEnemySpawning(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Debuffs", parent);
		CreateDebuffs(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Actions", parent);
		CreateEnemyActions(parent);
	}

	private static void CreateToggles(GameObject parent)
	{
		UIFactory.CreateCircularToggle("Insta-Kill", ModConfig.OneHitKill, delegate(bool value)
		{
			if (value != ModConfig.OneHitKill)
			{
				ModConfig.ToggleOneHitKill();
			}
		}, parent);
		UIFactory.CreateCircularToggle("Freeze Enemies", ModConfig.FreezeEnemies, delegate(bool value)
		{
			if (value != ModConfig.FreezeEnemies)
			{
				ModConfig.ToggleFreezeEnemies();
			}
		}, parent);
	}

	private static void CreateEnemyModifiers(GameObject parent)
	{
		UIFactory.CreateSlider("Enemy HP Mult", 0.1f, 50000f, StatsHelper.GetCurrentStatValue((EStat)53, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)53, v);
		}, parent);
		UIFactory.CreateSlider("Enemy Speed Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)52, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)52, v);
		}, parent);
		UIFactory.CreateSlider("Enemy Dmg Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)54, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)54, v);
		}, parent);
		UIFactory.CreateSlider("Enemy Amount", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)50, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)50, v);
		}, parent);
		UIFactory.CreateSlider("Enemy Size", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)51, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)51, v);
		}, parent);
		UIFactory.CreateSlider("Elite Spawn Rate", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)39, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)39, v);  // EliteSpawnIncrease
		}, parent);
		UIFactory.CreateSlider("Difficulty %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)38, 1f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)38, v);  // Difficulty
		}, parent);
	}

	private static void CreateEnemySpawning(GameObject parent)
	{
		UIFactory.CreateSpawner(parent, "SPAWN ENEMIES", enemies, delegate(int id, int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				CombatFeatures.SpawnSpecificEnemy(id);
			}
		});
	}

	private static void CreateDebuffs(GameObject parent)
	{
		string[] debuffs = new string[7] { "Poison", "Freeze", "Burn", "Stun", "Echo", "Charm", "Bloodmark" };
		UIFactory.CreateSpawner(parent, "Apply Debuff to All", debuffs, delegate(int id, int amount)
		{
			string debuffName = debuffs[id];
			for (int i = 0; i < amount; i++)
			{
				DebuffFeatures.ApplyDebuff(id, debuffName);
			}
		});
		UIFactory.CreateButton("\ud83e\uddf9 Remove All Debuffs", delegate
		{
			DebuffFeatures.RemoveAllDebuffs();
		}, parent);
	}

	private static void CreateEnemyActions(GameObject parent)
	{
		UIFactory.CreateButton("\ud83d\udc80 Kill All Enemies", delegate
		{
			CombatFeatures.KillAllEnemies();
		}, parent);
	}
}

