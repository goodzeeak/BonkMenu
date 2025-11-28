// Namespace: Assets.Scripts.Inventory__Items__Pickups.GoldAndMoney
public class MoneyUtility // TypeDefIndex: 5610
{
	// Fields
	public static int[] moneyTiers; // 0x0
	private const float spawnInterval = 60;
	private static float nextSilverSpawnTime; // 0x8
	private static Dictionary<GameObject, MoneyFlying> flyingMoneyDict; // 0x10
	private static MoneyFlying lastSpawnedMoney; // 0x18
	private static int chestBasePrice; // 0x20
	private static int priceIncreasePerChest; // 0x24
	private static int priceIncreasePerChestOver10; // 0x28
	private static int priceIncreasePerChestOver20; // 0x2C
	private static int priceIncreasePerChestOver30; // 0x30
	private static int priceIncreasePerChestOver40; // 0x34
	private static int priceIncreasePerChestOver50; // 0x38
	private static float chestPriceIncrease; // 0x3C
	private static int chestsPurchased; // 0x40
	private static float bigPotMultiplier; // 0x44
	private static float potMoneyFractionOfChest; // 0x48
	public static Action A_ChestPriceIncreased; // 0x50

	// Methods

	// RVA: 0x4438E0 Offset: 0x441EE0 VA: 0x1804438E0
	public static void Init() { }

	// RVA: 0x442E50 Offset: 0x441450 VA: 0x180442E50
	public static void Cleanup() { }

	// RVA: 0x443C00 Offset: 0x442200 VA: 0x180443C00
	private static void OnEnemyDied(Enemy enemy, DamageContainer deathSource) { }

	// RVA: 0x442D40 Offset: 0x441340 VA: 0x180442D40
	private static void CheckSilver(Enemy enemy) { }

	// RVA: 0x444AD0 Offset: 0x4430D0 VA: 0x180444AD0
	private static void SpawnSilver(Enemy enemy) { }

	// RVA: 0x444B60 Offset: 0x443160 VA: 0x180444B60
	public static void SpawnSilver(Vector3 pos) { }

	// RVA: 0x444870 Offset: 0x442E70 VA: 0x180444870
	public static void SpawnSilverNoTimerImpact(int amount, Vector3 pos) { }

	// RVA: 0x444000 Offset: 0x442600 VA: 0x180444000
	private static void OnNewRun() { }

	// RVA: 0x4440C0 Offset: 0x4426C0 VA: 0x1804440C0
	private static void OnNewStage() { }

	// RVA: 0x443170 Offset: 0x441770 VA: 0x180443170
	public static List<int> Exchange(int amount) { }

	// RVA: 0x444160 Offset: 0x442760 VA: 0x180444160
	public static void SpawnMoney(int amount, Vector3 pos) { }

	// RVA: 0x4432F0 Offset: 0x4418F0 VA: 0x1804432F0
	public static int GetChestPrice() { }

	// RVA: 0x443780 Offset: 0x441D80 VA: 0x180443780
	public static int GetShadyguyPrice() { }

	// RVA: 0x443540 Offset: 0x441B40 VA: 0x180443540
	public static int GetItemPriceShadyGuy(EItemRarity rarity) { }

	// RVA: 0x4436B0 Offset: 0x441CB0 VA: 0x1804436B0
	public static int GetPotMoney(bool isBig) { }

	// RVA: 0x443860 Offset: 0x441E60 VA: 0x180443860
	public static void IncreaseChestPrice() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x444D70 Offset: 0x443370 VA: 0x180444D70
	private static void .cctor() { }
}

