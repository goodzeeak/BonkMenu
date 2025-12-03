using BonkMenu.Core;
using BonkMenu.Features;
using BonkMenu.UI.Components;
using Il2CppAssets.Scripts.Menu.Shop;
using UnityEngine;
using UnityEngine.UI;

namespace BonkMenu.UI.Tabs;

/// <summary>
/// Provides enemy controls, modifiers, and spawning tools.
/// </summary>
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

    /// <summary>
    /// Builds the Combat tab UI under the given parent.
    /// </summary>
    public static void Create(GameObject parent)
    {
		UIFactory.CreateCollapsibleSection("Toggles", parent, CreateToggles);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Enemy Modifiers", parent, CreateEnemyModifiers);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Enemy Spawning", parent, CreateEnemySpawning);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Debuffs", parent, CreateDebuffs);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Actions", parent, CreateEnemyActions);
    }

	private static void CreateToggles(GameObject parent)
	{
		GameObject grid = new GameObject("ToggleGrid");
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
		UIFactory.CreateCircularToggle("Insta-Kill", ModConfig.OneHitKill, delegate(bool value)
		{
			if (value != ModConfig.OneHitKill)
			{
				ModConfig.ToggleOneHitKill();
			}
		}, grid);
		UIFactory.CreateCircularToggle("Freeze Enemies", ModConfig.FreezeEnemies, delegate(bool value)
		{
			if (value != ModConfig.FreezeEnemies)
			{
				ModConfig.ToggleFreezeEnemies();
			}
		}, grid);
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
        int[] map;
        var sorted = SortWithMap(enemies, out map);
        UIFactory.CreateSpawner(parent, "SPAWN ENEMIES", sorted, delegate(int id, int amount)
        {
            int originalId = map[id];
            for (int i = 0; i < amount; i++)
            {
                CombatFeatures.SpawnSpecificEnemy(originalId);
            }
        });
    }

    private static string[] SortWithMap(string[] names, out int[] map)
    {
        var sorted = (string[])names.Clone();
        map = new int[names.Length];
        for (int i = 0; i < map.Length; i++) map[i] = i;
        System.Array.Sort(sorted, map, System.StringComparer.OrdinalIgnoreCase);
        return sorted;
    }

	private static void CreateDebuffs(GameObject parent)
	{
		string[] debuffs = new string[7] { "Poison", "Freeze", "Burn", "Stun", "Echo", "Charm", "Bloodmark" };
		int[] map;
		var sorted = SortWithMap(debuffs, out map);
		UIFactory.CreateSpawnerNoSlider(parent, "Apply Debuff to All", sorted, delegate(int id)
		{
			int originalId = map[id];
			string debuffName = debuffs[originalId];
			DebuffFeatures.ApplyDebuff(originalId, debuffName);
		}, "🧹 Remove All Debuffs", delegate(int _)
		{
			DebuffFeatures.RemoveAllDebuffs();
		});
	}

	private static void CreateEnemyActions(GameObject parent)
	{
		GameObject grid = new GameObject("ActionGrid");
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
		UIFactory.CreateButton("💀 Kill All Enemies", delegate
		{
			CombatFeatures.KillAllEnemies();
		}, grid);
	}
}
