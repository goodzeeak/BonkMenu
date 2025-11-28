using BonkMenu.Core;
using BonkMenu.Features;
using BonkMenu.UI.Components;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Items;
using UnityEngine;
using UnityEngine.UI;

namespace BonkMenu.UI.Tabs;

public static class LootTab
{
	private static readonly string[] upgradeRarities = new string[5] { "Common", "Uncommon", "Rare", "Epic", "Legendary" };

	private static readonly string[] itemRarities = new string[4] { "Common", "Rare", "Epic", "Legendary" };

	private static int selectedUpgradeRarityIndex = 0;

	private static int selectedItemRarityIndex = 0;

	private static Text upgradeRarityLabel;

	private static Text itemRarityLabel;

	public static void Create(GameObject parent)
	{
		UIFactory.CreateSectionHeader("Rarity Control", parent);
		CreateRarityControl(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Luck Modifiers", parent);
		CreateLuckModifiers(parent);
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateSectionHeader("Spawning", parent);
		CreateSpawning(parent);
	}

	private static void CreateRarityControl(GameObject parent)
	{
		UIFactory.CreateCircularToggle("Force Upgrade Rarity", LootConfig.ForceUpgradeRarity, delegate(bool value)
		{
			LootConfig.ForceUpgradeRarity = value;
		}, parent);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateSelector(parent, upgradeRarities, () => selectedUpgradeRarityIndex, delegate(int val)
		{
			selectedUpgradeRarityIndex = val;
			LootConfig.DesiredUpgradeRarity = (ERarity)(val + 1);
		}, delegate(Text label)
		{
			upgradeRarityLabel = label;
		});
		UIFactory.CreateSpacer(8, parent);
		UIFactory.CreateCircularToggle("Force Item Rarity", LootConfig.ForceItemRarity, delegate(bool value)
		{
			LootConfig.ForceItemRarity = value;
		}, parent);
		UIFactory.CreateSpacer(4, parent);
		UIFactory.CreateSelector(parent, itemRarities, () => selectedItemRarityIndex, delegate(int val)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			selectedItemRarityIndex = val;
			LootConfig.DesiredItemRarity = MapIndexToItemRarity(val);
		}, delegate(Text label)
		{
			itemRarityLabel = label;
		});
	}

	private static EItemRarity MapIndexToItemRarity(int index)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		return (EItemRarity)(index switch
		{
			0 => 0, 
			1 => 1, 
			2 => 2, 
			3 => 3, 
			_ => 0, 
		});
	}

	private static void CreateLuckModifiers(GameObject parent)
	{
		UIFactory.CreateCircularToggle("Max Luck (Best Rolls)", LootConfig.MaxLuck, delegate(bool value)
		{
			LootConfig.MaxLuck = value;
		}, parent);
		UIFactory.CreateLabel("Forces all loot/upgrade rolls to use maximum luck value", parent);
	}

	private static void CreateSpawning(GameObject parent)
	{
		string[] spawnOptions = new string[] 
		{ 
			"Chests", 
			"Free Chests", 
			"All Statues", 
			"Challenge Shrines",
			"Cursed Shrines",
			"Greed Altars",
			"Magnet Shrines",
			"Moai Shrines",
			"Charge Shrines",
			"Gold Charge Shrines",
			"Pots",
			"Microwaves",
			"Shady Merchant",
			"Shady Merchant (Rare)",
			"Shady Merchant (Epic)",
			"Shady Merchant (Legendary)"
		};

		UIFactory.CreateSpawner(parent, "Spawn Object", spawnOptions, delegate(int index, int amount)
		{
			switch (index)
			{
				case 0: // Chests
					WorldFeatures.SpawnChests(amount);
					break;
				case 1: // Free Chests
					WorldFeatures.SpawnFreeChests(amount);
					break;
				case 2: // All Statues
					WorldFeatures.SpawnStatues(amount);
					break;
				case 3: // Challenge Shrines
					WorldFeatures.SpawnChallengeShrines(amount);
					break;
				case 4: // Cursed Shrines
					WorldFeatures.SpawnCursedShrines(amount);
					break;
				case 5: // Greed Altars
					WorldFeatures.SpawnGreedShrines(amount);
					break;
				case 6: // Magnet Shrines
					WorldFeatures.SpawnMagnetShrines(amount);
					break;
				case 7: // Moai Shrines
					WorldFeatures.SpawnMoaiShrines(amount);
					break;
				case 8: // Charge Shrines
					WorldFeatures.SpawnShrines(amount);
					break;
				case 9: // Gold Charge Shrines
					WorldFeatures.SpawnGoldShrines(amount);
					break;
				case 10: // Pots
					WorldFeatures.SpawnPots(amount);
					break;
				case 11: // Microwaves
					WorldFeatures.SpawnMicrowaves(amount);
					break;
				case 12: // Shady Merchant
					WorldFeatures.SpawnShadyMerchant(amount);
					break;
				case 13: // Shady Merchant (Rare)
					WorldFeatures.SpawnShadyMerchantRare(amount);
					break;
				case 14: // Shady Merchant (Epic)
					WorldFeatures.SpawnShadyMerchantEpic(amount);
					break;
				case 15: // Shady Merchant (Legendary)
					WorldFeatures.SpawnShadyMerchantLegendary(amount);
					break;
			}
		});
	}
}
