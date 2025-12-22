using BonkMenu.Core;
using BonkMenu.Patches;
using BonkMenu.Features;
using BonkMenu.UI.Components;
using Il2CppAssets.Scripts.Menu.Shop;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Stats;
using Il2CppAssets.Scripts.Inventory.Stats;
using UnityEngine;
using UnityEngine.UI;

namespace BonkMenu.UI.Tabs;

/// <summary>
/// Provides enemy controls, modifiers, and spawning tools.
/// </summary>
public static class CombatTab
{
    private static readonly string[] enemies = new string[51]
    {
        "Skeleton", "GoldenSkeleton", "XpSkeleton", "ArmoredSkeleton", "SkeletonDusty", "ArmoredSkeletonDusty", "Ghoul", "MinibossPig", "Mummy", "Slime",
        "Test", "Test2", "Goblin", "GoblinStrong", "GoblinTank", "MinibossGolem", "Ghost", "GreaterGhost", "SkeletonMage", "Ent1",
        "Ent2", "Ent3", "BoomerSpider", "Golem", "Bee", "MinibossGolemSand", "Scorpion", "MinibossScorpion", "Wisp", "CactusShooter",
        "ScorpionMedium", "MummyTank", "MummyAncient", "Tumblebone", "Pharaoh1", "Pharaoh2", "Pharaoh3", "Bandit", "Bush", "GhostRed",
        "GhostPurple", "Zombie", "Head", "GhostKing", "GhostGrave1", "GhostGrave2", "GhostGrave3", "GhostGrave4", "GhostInvincible", "Ghostham",
        "CalciumDad"
    };

    /// <summary>
    /// Builds the Combat tab UI under the given parent.
    /// </summary>
    public static void Create(GameObject parent)
    {
		UIFactory.CreateCollapsibleSection("Enemy Modifiers", parent, CreateEnemyModifiers);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Enemy Spawning", parent, CreateEnemySpawning);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Debuffs", parent, CreateDebuffs);
    }



	private static void CreateEnemyModifiers(GameObject parent)
	{
		float hpBase = PlayerStatsNew.GetBaseValue((EStat)53); float hpOffset = 0f; StatsPatches._customStatOffsets.TryGetValue((EStat)53, out hpOffset);
		UIFactory.CreateSlider("Enemy HP Mult", 0.1f, 50000f, hpBase + hpOffset, delegate(float v) { StatsPatches.SetStatAbsolute((EStat)53, v);
		}, parent, false, true);
		float spdBase = PlayerStatsNew.GetBaseValue((EStat)52); float spdOffset = 0f; StatsPatches._customStatOffsets.TryGetValue((EStat)52, out spdOffset);
		UIFactory.CreateSlider("Enemy Speed Mult", 0f, 50000f, spdBase + spdOffset, delegate(float v) { StatsPatches.SetStatAbsolute((EStat)52, v);
		}, parent, false, true);
		float dmgBase = PlayerStatsNew.GetBaseValue((EStat)54); float dmgOffset = 0f; StatsPatches._customStatOffsets.TryGetValue((EStat)54, out dmgOffset);
		UIFactory.CreateSlider("Enemy Dmg Mult", 0f, 50000f, dmgBase + dmgOffset, delegate(float v) { StatsPatches.SetStatAbsolute((EStat)54, v);
		}, parent, false, true);
		float sizeBase = PlayerStatsNew.GetBaseValue((EStat)51); float sizeOffset = 0f; StatsPatches._customStatOffsets.TryGetValue((EStat)51, out sizeOffset);
		UIFactory.CreateSlider("Enemy Size", 0f, 50000f, sizeBase + sizeOffset, delegate(float v) { StatsPatches.SetStatAbsolute((EStat)51, v);
		}, parent);
		UIFactory.CreateSlider("Spawn Rate Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)57, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)57, v);
		}, parent, false, true);
		float eliteBase = PlayerStatsNew.GetBaseValue((EStat)39); float eliteOffset = 0f; StatsPatches._customStatOffsets.TryGetValue((EStat)39, out eliteOffset);
		UIFactory.CreateSlider("Elite Spawn Rate %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)39, eliteBase + eliteOffset), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)39, v);
		}, parent, true);
		UIFactory.CreateSlider("Difficulty %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)38, 1f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)38, v);  // Difficulty
		}, parent, true);
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


}
