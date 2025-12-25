using BonkMenu.Core;
using BonkMenu.Features;
using BonkMenu.Patches;
using BonkMenu.UI.Components;
using Il2CppAssets.Scripts.Menu.Shop;
using Il2Cpp;
using Il2CppAssets.Scripts._Data.Tomes;
using UnityEngine;
using UnityEngine.UI;

namespace BonkMenu.UI.Tabs;

/// <summary>
/// Offers player toggles, utilities, buffs, and advanced stats.
/// </summary>
public static class PlayerTab
{
    private static readonly string[] passiveNames = new string[22]
    {
        "Bullseye", "RngBlessing", "SpeedDemon", "Reinforced", "Flowstate", "CritHappens", "Warrior", "Flex", "WallClimb", "None",
        "Float", "Enduring", "Plague", "Quantum", "Shadowstep", "Gamba", "Vampire", "Curse", "Stonks", "LockIn",
        "Zap", "Hoarder"
    };

    private static readonly string[] weaponsByName = new string[31]
    {
        "FireStaff", "Bone", "Sword", "Revolver", "Aura", "Axe", "Bow", "Aegis", "Test", "LightningStaff",
        "Flamewalker", "Rockets", "Bananarang", "Tornado", "Dexecutioner", "Sniper", "Frostwalker", "SpaceNoodle", "DragonsBreath", "Chunkers",
        "Mine", "PoisonFlask", "BlackHole", "Katana", "BloodMagic", "BluetoothDagger", "Dice", "HeroSword", "CorruptSword", "Shotgun",
        "Scythe"
    };

    private static readonly string[] tomesByName = new string[27]
    {
        "Damage", "Agility", "Cooldown", "Quantity", "Knockback", "Armor", "Health", "Regeneration", "Size", "ProjectileSpeed",
        "Duration", "Evasion", "Attraction", "Luck", "Xp", "Golden", "Precision", "Shield", "Blood", "Thorns",
        "Bounce", "Cursed", "Silver", "Balance", "Chaos", "Gambler", "Hoarder"
    };
    /// <summary>
    /// Builds the Player tab UI under the given parent.
    /// </summary>
    public static void Create(GameObject parent)
	{
		UIFactory.CreateCollapsibleSection("Toggles", parent, CreateToggles);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Utilities", parent, CreateUtilities);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Status Buffs", parent, CreateStatusEffectBuffs);
		UIFactory.CreateSpacer(4, parent);
        UIFactory.CreateCollapsibleSection("Passive Abilities", parent, CreatePassiveAbilities);
        UIFactory.CreateSpacer(4, parent);
        UIFactory.CreateCollapsibleSection("Uncap weapon level by name", parent, CreateUncapWeaponByName);
        UIFactory.CreateSpacer(4, parent);
        UIFactory.CreateCollapsibleSection("Uncap tome level by name", parent, CreateUncapTomeByName);
        UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateCollapsibleSection("Advanced Stats", parent, CreateSliders);
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
		UIFactory.CreateCircularToggle("\ud83d\udee1\ufe0f God Mode", ModConfig.GodMode, delegate(bool value)
		{
			if (value != ModConfig.GodMode)
			{
				ModConfig.ToggleGodMode();
			}
		}, grid);
		UIFactory.CreateCircularToggle("Infinite Health", ModConfig.InfiniteHealth, delegate(bool value)
		{
			if (value != ModConfig.InfiniteHealth)
			{
				ModConfig.ToggleInfiniteHealth();
			}
		}, grid);
		UIFactory.CreateCircularToggle("Infinite Rerolls", ModConfig.InfiniteRefreshes, delegate(bool value)
		{
			if (value != ModConfig.InfiniteRefreshes)
			{
				ModConfig.ToggleInfiniteRefreshes();
			}
		}, grid);
		UIFactory.CreateCircularToggle("No Cooldowns", ModConfig.NoCooldowns, delegate(bool value)
		{
			if (value != ModConfig.NoCooldowns)
			{
				ModConfig.ToggleNoCooldowns();
			}
		}, grid);
		UIFactory.CreateCircularToggle("\u221e Unlimited XP", ModConfig.UnlimitedXp, delegate(bool value)
		{
			if (value != ModConfig.UnlimitedXp)
			{
				ModConfig.ToggleUnlimitedXp();
			}
		}, grid);
		UIFactory.CreateCircularToggle("🍀 Max Luck", ModConfig.MaxLuck, delegate(bool value)
		{
			if (value != ModConfig.MaxLuck)
			{
				ModConfig.ToggleMaxLuck();
			}
		}, grid);
		UIFactory.CreateCircularToggle("🔧 Toggle System", TogglePatches.IsEnabled(), delegate(bool value)
		{
			TogglePatches.SetEnabled(value);
			UIFactory.ShowToast($"Toggle system: {(value ? "Enabled" : "Disabled")}");
		}, grid);
		UIFactory.CreateCircularToggle("\ud83d\udc80 Insta-Kill", ModConfig.OneHitKill, delegate(bool value)
		{
			if (value != ModConfig.OneHitKill)
			{
				ModConfig.ToggleOneHitKill();
			}
		}, grid);

		// Centered row for the 9th toggle (Freeze Enemies) using a single-column grid
		GameObject lastToggleRow = new GameObject("LastToggleRow");
		lastToggleRow.transform.SetParent(parent.transform, false);
		RectTransform lastToggleRT = lastToggleRow.AddComponent<RectTransform>();
		lastToggleRT.sizeDelta = new Vector2(0f, 30f);
		GridLayoutGroup lastToggleGLG = lastToggleRow.AddComponent<GridLayoutGroup>();
		lastToggleGLG.cellSize = new Vector2(283f, 30f);
		lastToggleGLG.childAlignment = TextAnchor.MiddleCenter;
		lastToggleGLG.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
		lastToggleGLG.constraintCount = 1;

		UIFactory.CreateCircularToggle("\u2744\ufe0f Freeze Enemies", ModConfig.FreezeEnemies, delegate(bool value)
		{
			if (value != ModConfig.FreezeEnemies)
			{
				ModConfig.ToggleFreezeEnemies();
			}
		}, lastToggleRow);
	}

	private static void CreateUtilities(GameObject parent)
	{
		GameObject grid = new GameObject("UtilitiesGrid");
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
		UIFactory.CreateButton("❤\ufe0f Restore Health", delegate
		{
			PlayerFeatures.FullHeal();
		}, grid);
		UIFactory.CreateButton("\ud83e\uddf9 Clear Statuses", delegate
		{
			PlayerFeatures.ClearAllStatusEffects();
		}, grid);

		// Centered row for the 3rd utility button (Kill All Enemies) using a single-column grid
		GameObject lastUtilRow = new GameObject("LastUtilRow");
		lastUtilRow.transform.SetParent(parent.transform, false);
		RectTransform lastUtilRT = lastUtilRow.AddComponent<RectTransform>();
		lastUtilRT.sizeDelta = new Vector2(0f, 30f);
		GridLayoutGroup lastUtilGLG = lastUtilRow.AddComponent<GridLayoutGroup>();
		lastUtilGLG.cellSize = new Vector2(283f, 30f);
		lastUtilGLG.childAlignment = TextAnchor.MiddleCenter;
		lastUtilGLG.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
		lastUtilGLG.constraintCount = 1;

		UIFactory.CreateButton("\ud83d\udc80 Kill All Enemies", delegate
		{
			CombatFeatures.KillAllEnemies();
		}, lastUtilRow);
	}

    private static void CreateStatusEffectBuffs(GameObject parent)
    {
        string[] buffs = new string[4] { "Rage", "Haste", "Shield", "Invulnerability" };
        int[] map;
        var sorted = SortWithMap(buffs, out map);
        UIFactory.CreateSpawnerNoSlider(parent, "Apply Buff", sorted, delegate(int id)
        {
            int originalId = map[id];
            string chosen = buffs[originalId];
            if (chosen == "Haste") StatusEffects.ApplyHaste();
            else if (chosen == "Invulnerability") StatusEffects.ApplyInvulnerability();
            else if (chosen == "Rage") StatusEffects.ApplyRage();
            else if (chosen == "Shield") StatusEffects.ApplyShield();
        });
    }

    private static void CreatePassiveAbilities(GameObject parent)
    {
        int[] map;
        var sorted = SortWithMap(passiveNames, out map);
        UIFactory.CreateSpawnerNoSlider(parent, "Grant Passive", sorted, delegate(int id)
        {
            int originalId = map[id];
            string passiveName = passiveNames[originalId];
            PassiveFeatures.GrantPassive(originalId, passiveName);
        });
    }

    private static void CreateUncapWeaponByName(GameObject parent)
    {
        int[] wMap;
        var wSorted = SortWithMap(weaponsByName, out wMap);
        UIFactory.CreateSpawnerNoSlider(parent, "Uncap Weapon", wSorted, idx =>
        {
            var originalId = wMap[idx];
            var name = weaponsByName[originalId];
            string canonical = name;
            var dm = DataManager.Instance;
            if ((Object)(object)dm != (Object)null)
            {
                var w = dm.GetWeapon((EWeapon)originalId);
                if (w != null && w.name != null)
                {
                    canonical = w.name;
                }
            }
            BonkMenu.Core.ModConfig.EnableUnlimitedForWeapon(name);
            BonkMenu.Core.ModConfig.EnableUnlimitedForWeapon(canonical);
        }, "Disable Uncap", idx =>
        {
            var originalId = wMap[idx];
            var name = weaponsByName[originalId];
            string canonical = name;
            var dm = DataManager.Instance;
            if ((Object)(object)dm != (Object)null)
            {
                var w = dm.GetWeapon((EWeapon)originalId);
                if (w != null && w.name != null)
                {
                    canonical = w.name;
                }
            }
            BonkMenu.Core.ModConfig.DisableUnlimitedForWeapon(name);
            BonkMenu.Core.ModConfig.DisableUnlimitedForWeapon(canonical);
        });
    }

    private static void CreateUncapTomeByName(GameObject parent)
    {
        int[] tMap;
        var tSorted = SortWithMap(tomesByName, out tMap);
        UIFactory.CreateSpawnerNoSlider(parent, "Uncap Tome", tSorted, idx =>
        {
            var originalId = tMap[idx];
            var name = tomesByName[originalId];
            string canonical = name;
            var dm = DataManager.Instance;
            if ((Object)(object)dm != (Object)null)
            {
                var t = dm.GetTome((ETome)originalId);
                if (t != null && t.name != null)
                {
                    canonical = t.name;
                }
            }
            BonkMenu.Core.ModConfig.EnableUnlimitedForTome(name);
            BonkMenu.Core.ModConfig.EnableUnlimitedForTome(canonical);
        }, "Disable Uncap", idx =>
        {
            var originalId = tMap[idx];
            var name = tomesByName[originalId];
            string canonical = name;
            var dm = DataManager.Instance;
            if ((Object)(object)dm != (Object)null)
            {
                var t = dm.GetTome((ETome)originalId);
                if (t != null && t.name != null)
                {
                    canonical = t.name;
                }
            }
            BonkMenu.Core.ModConfig.DisableUnlimitedForTome(name);
            BonkMenu.Core.ModConfig.DisableUnlimitedForTome(canonical);
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

	private static void CreateSliders(GameObject parent)
	{
		UIFactory.CreateSectionHeader("Health & Defense", parent);
		UIFactory.CreateSlider("Max HP", 10f, 50000f, StatsHelper.GetCurrentStatValue((EStat)0, 100f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)0, v);
		}, parent);
		UIFactory.CreateSlider("HP Regen", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)1, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)1, v);
		}, parent);
		UIFactory.CreateSlider("Shield", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)2, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)2, v);
		}, parent);
		UIFactory.CreateSlider("Thorns", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)3, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)3, v);
		}, parent);
		UIFactory.CreateSlider("Armor %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)4, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)4, v);
		}, parent, true);
		UIFactory.CreateSlider("Evasion %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)5, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)5, v);
		}, parent, true);
		UIFactory.CreateSlider("Dmg Reduction", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)7, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)7, v);
		}, parent);
		UIFactory.CreateSlider("Overheal", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)47, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)47, v);
		}, parent);
		UIFactory.CreateSlider("Healing Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)48, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)48, v);
		}, parent, false, true);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Attack Stats", parent);
		UIFactory.CreateSlider("Damage Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)12, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)12, v);
		}, parent, false, true);
		UIFactory.CreateSlider("Attack Speed %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)15, 1f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)15, v);
		}, parent, true);
		UIFactory.CreateSlider("Crit Chance %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)18, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)18, v);
		}, parent, true);
		UIFactory.CreateSlider("Crit Damage", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)19, 1.5f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)19, v);
		}, parent);
		UIFactory.CreateSlider("Lifesteal %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)17, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)17, v);
		}, parent, true);
		UIFactory.CreateSlider("Elite Dmg Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)23, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)23, v);
		}, parent);
		UIFactory.CreateSlider("Fire Damage", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)20, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)20, v);
		}, parent);
		UIFactory.CreateSlider("Ice Damage", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)21, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)21, v);
		}, parent);
		UIFactory.CreateSlider("Lightning Damage", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)22, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)22, v);
		}, parent);
		UIFactory.CreateSlider("Poison Damage", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)56, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)56, v);
		}, parent);
		UIFactory.CreateSlider("Burn Chance %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)42, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)42, v);
		}, parent, true);
		UIFactory.CreateSlider("Freeze Chance %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)43, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)43, v);
		}, parent, true);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Projectile Stats", parent);
		UIFactory.CreateSlider("Projectiles", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)16, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)16, v);
		}, parent);
		UIFactory.CreateSlider("Proj Speed Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)11, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)11, v);
		}, parent, false, true);
		UIFactory.CreateSlider("Proj Bounces", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)45, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)45, v);
		}, parent);
		UIFactory.CreateSlider("Size Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)9, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)9, v);
		}, parent, false, true);
		UIFactory.CreateSlider("Duration Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)10, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)10, v);
		}, parent, false, true);
		UIFactory.CreateSlider("Knockback Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)24, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)24, v);
		}, parent, false, true);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Movement & Utility", parent);
		UIFactory.CreateSlider("Move Speed Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)25, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)25, v);
		}, parent, false, true);
		UIFactory.CreateSlider("Jump Height", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)26, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)26, v);
		}, parent);
		UIFactory.CreateSlider("Extra Jumps", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)46, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)46, v);
		}, parent);
		UIFactory.CreateSlider("Fall Dmg Reduction", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)27, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)27, v);
		}, parent);
		UIFactory.CreateSlider("Slam", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)28, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)28, v);
		}, parent);
		UIFactory.CreateSlider("Pickup Range", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)29, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)29, v);
		}, parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Resources & Economy", parent);
		UIFactory.CreateSlider("Luck %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)30, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)30, v);
		}, parent, true);
		UIFactory.CreateSlider("Gold Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)31, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)31, v);
		}, parent, false, true);
		UIFactory.CreateSlider("XP Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)32, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)32, v);
		}, parent, false, true);
		UIFactory.CreateSlider("Chest Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)33, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)33, v);
		}, parent, false, true);
		UIFactory.CreateSlider("Chest Price Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)34, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)34, v);
		}, parent, false, true);
		UIFactory.CreateSlider("Shop Discount", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)35, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)35, v);
		}, parent);
		UIFactory.CreateSlider("Silver Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)49, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)49, v);
		}, parent, false, true);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Special Stats", parent);
		UIFactory.CreateSlider("Evolve", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)6, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)6, v);
		}, parent);
		UIFactory.CreateSlider("Effect Duration Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)14, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)14, v);
		}, parent, false, true);
		UIFactory.CreateSlider("Powerup Boost Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)40, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)40, v);
		}, parent, false, true);
		UIFactory.CreateSlider("Powerup Chance %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)41, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)41, v);
		}, parent, true);
		UIFactory.CreateSlider("Holiness", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)36, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)36, v);
		}, parent);
		UIFactory.CreateSlider("Wickedness", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)37, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)37, v);
		}, parent);
		UIFactory.CreateSlider("Weapon Burst CD", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)44, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)44, v);
		}, parent);
		UIFactory.CreateSlider("Dmg CD Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)8, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)8, v);
		}, parent, false, true);
	}
}
