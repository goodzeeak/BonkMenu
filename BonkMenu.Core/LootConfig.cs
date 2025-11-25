using Il2CppAssets.Scripts.Inventory__Items__Pickups;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Items;

namespace BonkMenu.Core;

public static class LootConfig
{
	public static bool ForceUpgradeRarity { get; set; } = false;

	public static ERarity DesiredUpgradeRarity { get; set; } = (ERarity)4;

	public static bool ForceItemRarity { get; set; } = false;

	public static EItemRarity DesiredItemRarity { get; set; } = (EItemRarity)3;

	public static bool ForceSpecificItem { get; set; } = false;

	public static EItem DesiredItem { get; set; } = (EItem)1;

	public static bool OverrideChestLoot { get; set; } = false;

	public static EItemRarity ChestRarityOverride { get; set; } = (EItemRarity)3;

	public static bool MaxLuck { get; set; } = false;
}
