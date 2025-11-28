// Namespace: Assets.Scripts.Inventory__Items__Pickups
public class InventoryUtility // TypeDefIndex: 5468
{
	// Methods

	// RVA: 0x3F95F0 Offset: 0x3F7BF0 VA: 0x1803F95F0
	public static List<IUpgradable> GetRandomUpgrades() { }

	// RVA: 0x3F8AD0 Offset: 0x3F70D0 VA: 0x1803F8AD0
	public static List<ItemData> GetRandomItemsMoai(int moaiLuckMode) { }

	// RVA: 0x3F9080 Offset: 0x3F7680 VA: 0x1803F9080
	public static List<ItemData> GetRandomItemsShadyGuy(EItemRarity itemRarity) { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0
	private static int GetNumUpgrades() { }

	// RVA: 0x3F8560 Offset: 0x3F6B60 VA: 0x1803F8560
	private static bool CanUnlockItem(IUpgradable upgradable) { }

	// RVA: 0x3F8910 Offset: 0x3F6F10 VA: 0x1803F8910
	private static bool CanUnlockWeapons() { }

	// RVA: 0x3F8800 Offset: 0x3F6E00 VA: 0x1803F8800
	private static bool CanUnlockTomes() { }

	// RVA: 0x3F8A50 Offset: 0x3F7050 VA: 0x1803F8A50
	public static int GetNumAvailableWeaponSlots() { }

	// RVA: 0x3F89F0 Offset: 0x3F6FF0 VA: 0x1803F89F0
	public static int GetNumAvailableTomeSlots() { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0
	public static int GetNumMaxWeaponSlots() { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0
	public static int GetNumMaxTomeSlots() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups
public class PlayerHealth // TypeDefIndex: 5469
{
	// Fields
	public static int maxMaxHp; // 0x0
	public int hp; // 0x10
	public int maxHp; // 0x14
	public float overheal; // 0x18
	public float maxOverheal; // 0x1C
	public float shield; // 0x20
	public float maxShield; // 0x24
	public static Action<PlayerHealth, DamageContainer, bool> A_TakeDamage; // 0x8
	public static Action<PlayerHealth, float, bool> A_Heal; // 0x10
	public static Action<PlayerHealth> A_MaxValuesChanged; // 0x18
	public static Action<PlayerHealth> A_OverhealUpdate; // 0x20
	public static Action A_CooldownOver; // 0x28
	public static Action A_Died; // 0x30
	public static Action<Enemy> A_Evaded; // 0x38
	public static Action<DamageContainer, bool> A_CheckStopDamage; // 0x40
	private float baseHp; // 0x28
	private float baseShield; // 0x2C
	private string lvlHpMovingStatName; // 0x30
	private float minFallDamageSpeed; // 0x38
	private float maxFallDamageSpeed; // 0x3C
	public float fallDamageTakenAtTime; // 0x40
	public const string fallDamageSource = "fallDamage";
	public static Action A_StoppedDamage; // 0x48
	public static Action A_DamagePlayerCalled; // 0x50
	private HashSet<string> ignoreShieldRechargeSources; // 0x48
	public static string thornsDamageSource; // 0x58
	private float shieldRechargeAtTime; // 0x50
	private float shieldRegenCooldownTime; // 0x54
	public const float damageCooldownTime = 0.15;
	public static Action<Enemy, int> A_LifestealProc; // 0x60
	private int lifestealHeal; // 0x58
	public static Action<int> A_LifestealHealing; // 0x68
	private float leftOverHeal; // 0x5C
	public const string healthRegenDamageSource = "HealthRegen";
	private float nextCheckDeadTime; // 0x60
	private float checkDeadInterval; // 0x64
	private float overhealRemovalFractionPerSecond; // 0x68
	private float shieldHealingPerTick; // 0x6C
	private float shieldHealingValue; // 0x70
	private float healingValue; // 0x74
	private float healingTime; // 0x78
	private float healInterval; // 0x7C
	private float healPerInterval; // 0x80
	private float healingPerMinute; // 0x84
	private float damageCooldown; // 0x88

	// Methods

	// RVA: 0x4028B0 Offset: 0x400EB0 VA: 0x1804028B0
	public void .ctor(PlayerStatsNew playerStats) { }

	// RVA: 0x400B60 Offset: 0x3FF160 VA: 0x180400B60
	public void OnDestroy() { }

	// RVA: 0x401370 Offset: 0x3FF970 VA: 0x180401370
	private void OnPickup(Pickup pickup) { }

	// RVA: 0x401710 Offset: 0x3FFD10 VA: 0x180401710
	private void OnStatUpdate(EStat stat) { }

	// RVA: 0x401260 Offset: 0x3FF860 VA: 0x180401260
	private void OnLevelUp(int lvl) { }

	// RVA: 0x402430 Offset: 0x400A30 VA: 0x180402430
	private void UpdateRegenValues(float forceValue = 0) { }

	// RVA: 0x4013E0 Offset: 0x3FF9E0 VA: 0x1804013E0
	private void OnPlayerLanded(float speed) { }

	// RVA: 0x402220 Offset: 0x400820 VA: 0x180402220
	private void UpdateMaxValues() { }

	// RVA: 0x3FFFD0 Offset: 0x3FE5D0 VA: 0x1803FFFD0
	public void DamagePlayer(Enemy enemy, Vector3 direction, DcFlags flags = 0) { }

	// RVA: 0x3FFE40 Offset: 0x3FE440 VA: 0x1803FFE40
	public void DamagePlayerExternal(float damage, float knockback, Vector3 direction, bool ignoreShield = False, string damageSource = "Enemy", DcFlags flags = 0, EDamageEffect damageEffect = 0, Enemy enemy) { }

	// RVA: 0x400050 Offset: 0x3FE650 VA: 0x180400050
	private void Damage(DamageContainer dc, bool ignoreShield) { }

	// RVA: 0x3FF8D0 Offset: 0x3FDED0 VA: 0x1803FF8D0
	private void CheckDamageCooldown(DamageContainer dc) { }

	// RVA: 0x3FFA20 Offset: 0x3FE020 VA: 0x1803FFA20
	private void CheckShieldRecharge(DamageContainer dc) { }

	// RVA: 0x400B40 Offset: 0x3FF140 VA: 0x180400B40
	public void KillPlayer() { }

	// RVA: 0x3FFAC0 Offset: 0x3FE0C0 VA: 0x1803FFAC0
	public bool CheckStopDamage(DamageContainer dc, bool ignoreShield) { }

	// RVA: 0x4024F0 Offset: 0x400AF0 VA: 0x1804024F0
	private void UseAegis(DamageContainer dc, Color color, string text = "Block") { }

	// RVA: 0x4027E0 Offset: 0x400DE0 VA: 0x1804027E0
	public bool WillDamageKill(DamageContainer dc, bool ignoreShield) { }

	// RVA: 0x4027B0 Offset: 0x400DB0 VA: 0x1804027B0
	public bool WillDamageKill(float damage, bool ignoreShield) { }

	// RVA: 0x400560 Offset: 0x3FEB60 VA: 0x180400560
	private void Evade(DamageContainer dc) { }

	// RVA: 0x401850 Offset: 0x3FFE50 VA: 0x180401850
	public void Retaliate(DamageContainer dc) { }

	// RVA: 0x400850 Offset: 0x3FEE50 VA: 0x180400850
	private float GetDamageCooldown() { }

	// RVA: 0x4010C0 Offset: 0x3FF6C0 VA: 0x1804010C0
	private void OnEnemyDamaged(Enemy enemy, DamageContainer dc) { }

	// RVA: 0x402040 Offset: 0x400640 VA: 0x180402040
	private void TryLifestealHit(Enemy enemy, DamageContainer dc) { }

	// RVA: 0x3FF760 Offset: 0x3FDD60 VA: 0x1803FF760
	private void ApplyLifesteal() { }

	// RVA: 0x400890 Offset: 0x3FEE90 VA: 0x180400890
	public int Heal(float amount, bool allowOverheal = True) { }

	// RVA: 0x401AE0 Offset: 0x4000E0 VA: 0x180401AE0
	public void Tick() { }

	// RVA: 0x3FF950 Offset: 0x3FDF50 VA: 0x1803FF950
	private void CheckDead() { }

	// RVA: 0x4021B0 Offset: 0x4007B0 VA: 0x1804021B0
	private void UpdateHealthRegen() { }

	// RVA: 0x4017D0 Offset: 0x3FFDD0 VA: 0x1804017D0
	public void PlayerDied() { }

	// RVA: 0x400B30 Offset: 0x3FF130 VA: 0x180400B30
	public bool IsDead() { }

	// RVA: 0x3FF840 Offset: 0x3FDE40 VA: 0x1803FF840
	public bool CanTakeDamage() { }

	// RVA: 0x400810 Offset: 0x3FEE10 VA: 0x180400810
	public int GetCombinedHp() { }

	// RVA: 0x400830 Offset: 0x3FEE30 VA: 0x180400830
	public int GetCombinedMaxHp() { }

	// RVA: 0x400870 Offset: 0x3FEE70 VA: 0x180400870
	public float GetHpRatio() { }

	// RVA: 0x3FFE20 Offset: 0x3FE420 VA: 0x1803FFE20
	public bool DamageCooldown() { }

	// RVA: 0x3FF800 Offset: 0x3FDE00 VA: 0x1803FF800
	public bool CanHeal() { }

	// RVA: 0x3FF820 Offset: 0x3FDE20 VA: 0x1803FF820
	private bool CanLifesteal() { }

	// RVA: 0x402830 Offset: 0x400E30 VA: 0x180402830
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups
public enum ERarity // TypeDefIndex: 5470
{
	// Fields
	public int value__; // 0x0
	public const ERarity New = 0;
	public const ERarity Common = 1;
	public const ERarity Uncommon = 2;
	public const ERarity Rare = 3;
	public const ERarity Epic = 4;
	public const ERarity Legendary = 5;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups
public static class Rarity // TypeDefIndex: 5471
{
	// Methods

	// RVA: 0x4096A0 Offset: 0x407CA0 VA: 0x1804096A0
	public static ERarity GetUpgradeOfferRarity(float luck) { }

	// RVA: 0x4096A0 Offset: 0x407CA0 VA: 0x1804096A0
	public static ERarity GetEncounterOfferRarity(float luck) { }

	// RVA: 0x4097D0 Offset: 0x407DD0 VA: 0x1804097D0
	public static EItemRarity GetItemRarity(float luck) { }

	// RVA: 0x409E30 Offset: 0x408430 VA: 0x180409E30
	public static EItemRarity GetShadyGuyRarity(float luck, float[] customWeights) { }

	// RVA: 0x409590 Offset: 0x407B90 VA: 0x180409590
	public static void CalculateRarityWeights(float[] rarityWeights, float luck) { }

	// RVA: 0x409DD0 Offset: 0x4083D0 VA: 0x180409DD0
	public static float GetMultiplier(ERarity rarity) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups
public static class RunUnlockables // TypeDefIndex: 5472
{
	// Fields
	public static HashSet<ItemData> banishedItems; // 0x0
	public static HashSet<UnlockableBase> banishedUpgradables; // 0x8
	public static Dictionary<EItemRarity, List<ItemData>> availableItems; // 0x10
	public static Action A_Inited; // 0x18
	private static int maxOverpoweredLamps; // 0x20
	private static int maxAnvils; // 0x24

	// Methods

	// RVA: 0x40A6A0 Offset: 0x408CA0 VA: 0x18040A6A0
	public static void Init() { }

	// RVA: 0x40A360 Offset: 0x408960 VA: 0x18040A360
	public static void Cleanup() { }

	// RVA: 0x40ABE0 Offset: 0x4091E0 VA: 0x18040ABE0
	private static void OnNewRunStarted() { }

	// RVA: 0x40B1D0 Offset: 0x4097D0 VA: 0x18040B1D0
	public static void Testing() { }

	// RVA: 0x409F90 Offset: 0x408590 VA: 0x180409F90
	private static void AddItemToPool(ItemData item) { }

	// RVA: 0x40A9E0 Offset: 0x408FE0 VA: 0x18040A9E0
	private static void OnItemAdded(EItem eItem) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void OnAchievementUnlocked(MyAchievement ach) { }

	// RVA: 0x40A190 Offset: 0x408790 VA: 0x18040A190
	public static void BanishItem(ItemData unlockable) { }

	// RVA: 0x40A2E0 Offset: 0x4088E0 VA: 0x18040A2E0
	public static void BanishUpgradable(UnlockableBase upgradable) { }

	// RVA: 0x40B210 Offset: 0x409810 VA: 0x18040B210
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups
public class TomeInventory // TypeDefIndex: 5473
{
	// Fields
	private bool isMaxed; // 0x10
	public static Action<ETome, EStat> A_TomeUpgrade; // 0x0
	public Dictionary<ETome, int> tomeLevels; // 0x18
	public Dictionary<EStat, HashSet<ETome>> statToTomes; // 0x20
	public Dictionary<ETome, StatModifier> tomeUpgrade; // 0x28

	// Methods

	// RVA: 0x40B4A0 Offset: 0x409AA0 VA: 0x18040B4A0
	public void AddTome(TomeData tomeData, List<StatModifier> upgradeOffer, ERarity rarity) { }

	// RVA: 0x40B2D0 Offset: 0x4098D0 VA: 0x18040B2D0
	public void AddMaxedTome(TomeData tomeData) { }

	// RVA: 0x40BC60 Offset: 0x40A260 VA: 0x18040BC60
	public int GetTomeLevel(ETome tome) { }

	// RVA: 0x40BC10 Offset: 0x40A210 VA: 0x18040BC10
	public int GetNumTomes() { }

	// RVA: 0x40B9E0 Offset: 0x409FE0 VA: 0x18040B9E0
	private void CheckMaxed() { }

	// RVA: 0x40BD50 Offset: 0x40A350 VA: 0x18040BD50
	private bool IsMaxLevel(ETome eTome) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool IsMaxed() { }

	// RVA: 0x40BCF0 Offset: 0x40A2F0 VA: 0x18040BCF0
	public bool HasTome(ETome eTome) { }

	// RVA: 0x40BE20 Offset: 0x40A420 VA: 0x18040BE20
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups
public class TomeUtility // TypeDefIndex: 5474
{
	// Fields
	private static float balanceTomeValue; // 0x0

	// Methods

	// RVA: 0x40BF30 Offset: 0x40A530 VA: 0x18040BF30
	public static void CheckSpecialTomes(TomeData tomeData, ERarity rarity) { }

	// RVA: 0x40C600 Offset: 0x40AC00 VA: 0x18040C600
	public static string GetUpgradeDescription(TomeData tomeData, ERarity rarity) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x40C7C0 Offset: 0x40ADC0 VA: 0x18040C7C0
	private static void .cctor() { }
}

