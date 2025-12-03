using BonkMenu.Core;
using BonkMenu.Features;
using BonkMenu.UI.Components;
using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Items;
using UnityEngine;
using UnityEngine.UI;

namespace BonkMenu.UI.Tabs;

/// <summary>
/// Controls loot rarity, luck, and spawn helpers.
/// </summary>
public static class LootTab
{
	private static readonly string[] upgradeRarities = new string[5] { "Common", "Uncommon", "Rare", "Epic", "Legendary" };

	private static readonly string[] itemRarities = new string[4] { "Common", "Rare", "Epic", "Legendary" };

	private static int selectedUpgradeRarityIndex = 0;

	private static int selectedItemRarityIndex = 0;

    

    /// <summary>
    /// Builds the Loot tab UI under the given parent.
    /// </summary>
    public static void Create(GameObject parent)
    {
        UIFactory.CreateCollapsibleSection("Toggles", parent, CreateToggles);
        UIFactory.CreateSpacer(4, parent);
        UIFactory.CreateCollapsibleSection("Rarity Control", parent, CreateRarityControl);
        UIFactory.CreateSpacer(4, parent);
        UIFactory.CreateCollapsibleSection("Spawning", parent, CreateSpawning);
    }

    private static void CreateRarityControl(GameObject parent)
    {
        UIFactory.CreateSpawnerNoSlider(parent, "Set Upgrade Rarity", upgradeRarities, idx =>
        {
            selectedUpgradeRarityIndex = idx;
            LootConfig.DesiredUpgradeRarity = (ERarity)(idx + 1);
        });
        UIFactory.CreateSpacer(8, parent);
        UIFactory.CreateSpawnerNoSlider(parent, "Set Item Rarity", itemRarities, idx =>
        {
            selectedItemRarityIndex = idx;
            LootConfig.DesiredItemRarity = MapIndexToItemRarity(idx);
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
        UIFactory.CreateCircularToggle("Force Upgrade Rarity", LootConfig.ForceUpgradeRarity, delegate(bool value)
        {
            LootConfig.ForceUpgradeRarity = value;
        }, grid);
        UIFactory.CreateCircularToggle("Force Item Rarity", LootConfig.ForceItemRarity, delegate(bool value)
        {
            LootConfig.ForceItemRarity = value;
        }, grid);
        UIFactory.CreateCircularToggle("Max Luck (Best Rolls)", LootConfig.MaxLuck, delegate(bool value)
        {
            LootConfig.MaxLuck = value;
        }, grid);
        UIFactory.CreateLabel("Forces all loot/upgrade rolls to use maximum luck value", parent);
    }

	private static void CreateSpawning(GameObject parent)
	{
        string[] spawnOptions = new string[] 
        { 
            "Chests", 
            "Free Chests", 
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
                case 2: // Challenge Shrines
                    WorldFeatures.SpawnChallengeShrines(amount);
                    break;
                case 3: // Cursed Shrines
                    WorldFeatures.SpawnCursedShrines(amount);
                    break;
                case 4: // Greed Altars
                    WorldFeatures.SpawnGreedAltars(amount);
                    break;
                case 5: // Magnet Shrines
                    WorldFeatures.SpawnMagnetShrines(amount);
                    break;
                case 6: // Moai Shrines
                    WorldFeatures.SpawnMoaiShrines(amount);
                    break;
                case 7: // Charge Shrines
                    WorldFeatures.SpawnShrines(amount);
                    break;
                case 8: // Gold Charge Shrines
                    WorldFeatures.SpawnGoldShrines(amount);
                    break;
                case 9: // Pots
                    WorldFeatures.SpawnPots(amount);
                    break;
                case 10: // Microwaves
                    WorldFeatures.SpawnMicrowaves(amount);
                    break;
                case 11: // Shady Merchant
                    WorldFeatures.SpawnShadyMerchant(amount);
                    break;
                case 12: // Shady Merchant (Rare)
                    WorldFeatures.SpawnShadyMerchantRare(amount);
                    break;
                case 13: // Shady Merchant (Epic)
                    WorldFeatures.SpawnShadyMerchantEpic(amount);
                    break;
                case 14: // Shady Merchant (Legendary)
                    WorldFeatures.SpawnShadyMerchantLegendary(amount);
                    break;
            }
		});
	}
}
