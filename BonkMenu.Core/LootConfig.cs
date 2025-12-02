using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Items;

namespace BonkMenu.Core;

/// <summary>
/// Configures loot rarity and item overrides.
/// </summary>
public static class LootConfig
{
    /// <summary>
    /// When true, forces a specific upgrade rarity.
    /// </summary>
    public static bool ForceUpgradeRarity { get; set; } = false;

    /// <summary>
    /// The desired upgrade rarity to force.
    /// </summary>
    public static ERarity DesiredUpgradeRarity { get; set; } = (ERarity)4;

    /// <summary>
    /// When true, forces a specific item rarity.
    /// </summary>
    public static bool ForceItemRarity { get; set; } = false;

    /// <summary>
    /// The desired item rarity to force.
    /// </summary>
    public static EItemRarity DesiredItemRarity { get; set; } = (EItemRarity)3;

    /// <summary>
    /// When true, forces a specific item to be offered.
    /// </summary>
    public static bool ForceSpecificItem { get; set; } = false;

    /// <summary>
    /// The specific item to offer when forcing.
    /// </summary>
    public static EItem DesiredItem { get; set; } = (EItem)1;

    /// <summary>
    /// When true, overrides chest loot rarity.
    /// </summary>
    public static bool OverrideChestLoot { get; set; } = false;

    /// <summary>
    /// Chest loot rarity to use when overriding.
    /// </summary>
    public static EItemRarity ChestRarityOverride { get; set; } = (EItemRarity)3;

    /// <summary>
    /// When true, sets luck stat to maximum.
    /// </summary>
    public static bool MaxLuck { get; set; } = false;
}
