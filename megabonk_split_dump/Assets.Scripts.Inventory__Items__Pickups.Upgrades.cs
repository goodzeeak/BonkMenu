// Namespace: Assets.Scripts.Inventory__Items__Pickups.Upgrades
public class EncounterUtility // TypeDefIndex: 5498
{
	// Fields
	public static List<EStat> upgradableStats; // 0x0
	private static List<EStat> upgradableStatsBalanceShrine; // 0x8

	// Methods

	// RVA: 0x40EDD0 Offset: 0x40D3D0 VA: 0x18040EDD0
	public static List<EStat> GetRandomStats(int amount) { }

	// RVA: 0x40EBC0 Offset: 0x40D1C0 VA: 0x18040EBC0
	public static List<EStat> GetRandomStatsBalanceShrine(int amount) { }

	// RVA: 0x40E6A0 Offset: 0x40CCA0 VA: 0x18040E6A0
	public static List<EncounterOffer> GetRandomStatOffers(int amount, bool forceLegendary = False) { }

	// RVA: 0x40E360 Offset: 0x40C960 VA: 0x18040E360
	public static List<EncounterOffer> GetBalanceShrineOffers(int amount) { }

	// RVA: 0x40EA70 Offset: 0x40D070 VA: 0x18040EA70
	private static float GetRandomStatValue(EStat stat, out EStatModifyType type) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x40EFE0 Offset: 0x40D5E0 VA: 0x18040EFE0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Upgrades
[CreateAssetMenu(menuName = "Me/UpgradeData", order = 1)]
public class UpgradeData : ScriptableObject // TypeDefIndex: 5499
{
	// Fields
	public List<StatModifier> upgradeModifiers; // 0x18

	// Methods

	// RVA: 0x425070 Offset: 0x423670 VA: 0x180425070
	public List<StatModifier> GetUpgradeOffer(ERarity rarity, EWeapon eWeapon) { }

	// RVA: 0x424F60 Offset: 0x423560 VA: 0x180424F60
	private StatModifier GetRandomModifier(StatModifier randomModifier, float multiplier) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

