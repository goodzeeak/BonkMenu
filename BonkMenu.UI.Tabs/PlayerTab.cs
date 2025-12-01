using BonkMenu.Core;
using BonkMenu.Features;
using BonkMenu.UI.Components;
using Il2CppAssets.Scripts.Menu.Shop;
using UnityEngine;

namespace BonkMenu.UI.Tabs;

public static class PlayerTab
{
	public static void Create(GameObject parent)
	{
		UIFactory.CreateSectionHeader("Toggles", parent);
		CreateToggles(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Utilities", parent);
		CreateUtilities(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Status Buffs", parent);
		CreateStatusEffectBuffs(parent);
		UIFactory.CreateSpacer(8, parent);
		CreateSliders(parent);
	}

	private static void CreateToggles(GameObject parent)
	{
		UIFactory.CreateCircularToggle("\ud83d\udee1\ufe0f God Mode", ModConfig.GodMode, delegate(bool value)
		{
			if (value != ModConfig.GodMode)
			{
				ModConfig.ToggleGodMode();
			}
		}, parent);
		UIFactory.CreateCircularToggle("✈\ufe0f Flight Mode", ModConfig.FlightMode, delegate(bool value)
		{
			if (value != ModConfig.FlightMode)
			{
				ModConfig.ToggleFlightMode();
			}
		}, parent);
		UIFactory.CreateCircularToggle("Infinite Health", ModConfig.InfiniteHealth, delegate(bool value)
		{
			if (value != ModConfig.InfiniteHealth)
			{
				ModConfig.ToggleInfiniteHealth();
			}
		}, parent);
		UIFactory.CreateCircularToggle("Infinite Rerolls", ModConfig.InfiniteRefreshes, delegate(bool value)
		{
			if (value != ModConfig.InfiniteRefreshes)
			{
				ModConfig.ToggleInfiniteRefreshes();
			}
		}, parent);
		UIFactory.CreateCircularToggle("No Cooldowns", ModConfig.NoCooldowns, delegate(bool value)
		{
			if (value != ModConfig.NoCooldowns)
			{
				ModConfig.ToggleNoCooldowns();
			}
		}, parent);
		UIFactory.CreateCircularToggle("∞ Unlimited Levels", ModConfig.UnlimitedLevels, delegate(bool value)
		{
			if (value != ModConfig.UnlimitedLevels)
			{
				ModConfig.ToggleUnlimitedLevels();
			}
		}, parent);
		UIFactory.CreateCircularToggle("∞ Unlimited XP", ModConfig.UnlimitedXp, delegate(bool value)
		{
			if (value != ModConfig.UnlimitedXp)
			{
				ModConfig.ToggleUnlimitedXp();
			}
		}, parent);
	}

	private static void CreateUtilities(GameObject parent)
	{
		UIFactory.CreateButton("❤\ufe0f Restore Health", delegate
		{
			PlayerFeatures.FullHeal();
		}, parent);
		UIFactory.CreateButton("\ud83e\uddf9 Clear Statuses", delegate
		{
			PlayerFeatures.ClearAllStatusEffects();
		}, parent);
	}

	private static void CreateStatusEffectBuffs(GameObject parent)
	{
		string[] buffs = new string[4] { "Rage", "Haste", "Shield", "Invulnerability" };
		UIFactory.CreateSpawnerNoSlider(parent, "Apply Buff", buffs, delegate(int id)
		{
			switch (id)
			{
				case 0: StatusEffects.ApplyRage(); break;
				case 1: StatusEffects.ApplyHaste(); break;
				case 2: StatusEffects.ApplyShield(); break;
				case 3: StatusEffects.ApplyInvulnerability(); break;
			}
		});
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
		}, parent);
		UIFactory.CreateSlider("Evasion %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)5, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)5, v);
		}, parent);
		UIFactory.CreateSlider("Dmg Reduction", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)7, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)7, v);
		}, parent);
		UIFactory.CreateSlider("Overheal", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)47, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)47, v);
		}, parent);
		UIFactory.CreateSlider("Healing Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)48, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)48, v);
		}, parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Attack Stats", parent);
		UIFactory.CreateSlider("Damage Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)12, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)12, v);
		}, parent);
		UIFactory.CreateSlider("Attack Speed %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)15, 1f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)15, v);
		}, parent);
		UIFactory.CreateSlider("Crit Chance %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)18, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)18, v);
		}, parent);
		UIFactory.CreateSlider("Crit Damage", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)19, 1.5f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)19, v);
		}, parent);
		UIFactory.CreateSlider("Lifesteal %", 0f, 50000f, StatsHelper.GetDisplayValue((EStat)17, 0f), delegate(float v) { StatsHelper.SetStatFromDisplay((EStat)17, v);
		}, parent);
		UIFactory.CreateSlider("Elite Dmg Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)23, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)23, v);
		}, parent);
		UIFactory.CreateSlider("Fire Damage", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)20, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)20, v);
		}, parent);
		UIFactory.CreateSlider("Ice Damage", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)21, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)21, v);
		}, parent);
		UIFactory.CreateSlider("Lightning Damage", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)22, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)22, v);
		}, parent);
		UIFactory.CreateSlider("Burn Chance", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)42, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)42, v);
		}, parent);
		UIFactory.CreateSlider("Freeze Chance", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)43, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)43, v);
		}, parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Projectile Stats", parent);
		UIFactory.CreateSlider("Projectiles", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)16, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)16, v);
		}, parent);
		UIFactory.CreateSlider("Proj Speed Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)11, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)11, v);
		}, parent);
		UIFactory.CreateSlider("Proj Bounces", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)45, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)45, v);
		}, parent);
		UIFactory.CreateSlider("Size Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)9, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)9, v);
		}, parent);
		UIFactory.CreateSlider("Duration Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)10, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)10, v);
		}, parent);
		UIFactory.CreateSlider("Knockback Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)24, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)24, v);
		}, parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Movement & Utility", parent);
		UIFactory.CreateSlider("Move Speed Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)25, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)25, v);
		}, parent);
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
		}, parent);
		UIFactory.CreateSlider("Gold Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)31, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)31, v);
		}, parent);
		UIFactory.CreateSlider("XP Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)32, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)32, v);
		}, parent);
		UIFactory.CreateSlider("Chest Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)33, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)33, v);
		}, parent);
		UIFactory.CreateSlider("Chest Price Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)34, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)34, v);
		}, parent);
		UIFactory.CreateSlider("Shop Discount", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)35, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)35, v);
		}, parent);
		UIFactory.CreateSlider("Silver Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)49, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)49, v);
		}, parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Special Stats", parent);
		UIFactory.CreateSlider("Evolve", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)6, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)6, v);
		}, parent);
		UIFactory.CreateSlider("Effect Duration Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)14, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)14, v);
		}, parent);
		UIFactory.CreateSlider("Powerup Boost Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)40, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)40, v);
		}, parent);
		UIFactory.CreateSlider("Powerup Chance", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)41, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)41, v);
		}, parent);
		UIFactory.CreateSlider("Holiness", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)36, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)36, v);
		}, parent);
		UIFactory.CreateSlider("Wickedness", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)37, 0f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)37, v);
		}, parent);
		UIFactory.CreateSlider("Weapon Burst CD", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)44, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)44, v);
		}, parent);
		UIFactory.CreateSlider("Dmg CD Mult", 0f, 50000f, StatsHelper.GetCurrentStatValue((EStat)8, 1f), delegate(float v) { StatsHelper.SetStatAndUpdate((EStat)8, v);
		}, parent);
	}
}

