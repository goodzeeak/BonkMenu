// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemAnvil : ItemBase // TypeDefIndex: 5529
{
	// Methods

	// RVA: 0x40FFE0 Offset: 0x40E5E0 VA: 0x18040FFE0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBackpack : ItemBase // TypeDefIndex: 5530
{
	// Fields
	private int projectilesPerAmount; // 0x30

	// Methods

	// RVA: 0x410180 Offset: 0x40E780 VA: 0x180410180 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x410200 Offset: 0x40E800 VA: 0x180410200
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x410060 Offset: 0x40E660 VA: 0x180410060 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBattery : ItemBase // TypeDefIndex: 5531
{
	// Fields
	private float attackSpeedPerStack; // 0x30

	// Methods

	// RVA: 0x4107F0 Offset: 0x40EDF0 VA: 0x1804107F0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x410880 Offset: 0x40EE80 VA: 0x180410880
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x410640 Offset: 0x40EC40 VA: 0x180410640 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBeacon : ItemBase // TypeDefIndex: 5532
{
	// Fields
	private int extraShrinesPerAmount; // 0x30
	private float healingRadiusPerAmount; // 0x34
	private float healingFractionPerInterval; // 0x38

	// Methods

	// RVA: 0x410A50 Offset: 0x40F050 VA: 0x180410A50
	public float GetHealingPerInterval() { }

	// RVA: 0x410B00 Offset: 0x40F100 VA: 0x180410B00
	public float GetRadius() { }

	// RVA: 0x410A40 Offset: 0x40F040 VA: 0x180410A40
	public int GetExtraShrines() { }

	// RVA: 0x410B20 Offset: 0x40F120 VA: 0x180410B20
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x410890 Offset: 0x40EE90 VA: 0x180410890 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBeefyRing : ItemBase // TypeDefIndex: 5533
{
	// Fields
	private int maxHpPerStack; // 0x30
	private float powerPerHpPerAmount; // 0x34
	private int lastStoredMaxHp; // 0x38
	private float nextUpdateTime; // 0x3C

	// Methods

	// RVA: 0x410D10 Offset: 0x40F310 VA: 0x180410D10 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x410DE0 Offset: 0x40F3E0 VA: 0x180410DE0
	private void RefreshPower() { }

	// RVA: 0x410F60 Offset: 0x40F560 VA: 0x180410F60 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x411150 Offset: 0x40F750 VA: 0x180411150
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x410B40 Offset: 0x40F140 VA: 0x180410B40 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBeer : ItemBase // TypeDefIndex: 5534
{
	// Fields
	private float damagePerStack; // 0x30
	private float maxHealthPerStack; // 0x34

	// Methods

	// RVA: 0x411340 Offset: 0x40F940 VA: 0x180411340 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x411410 Offset: 0x40FA10 VA: 0x180411410
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x411170 Offset: 0x40F770 VA: 0x180411170 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBloodyCleaver : ItemBase // TypeDefIndex: 5535
{
	// Fields
	private int bloodmarkStacksPerLifestealPerAmount; // 0x30
	private int bloodmarkStacksPerLifesteal; // 0x34
	private float bloodmarkChancePerAmount; // 0x38
	private float totalBloodmarkChance; // 0x3C
	private static string damageSource; // 0x0
	private DamageContainer dc; // 0x40

	// Methods

	// RVA: 0x411880 Offset: 0x40FE80 VA: 0x180411880 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x411730 Offset: 0x40FD30 VA: 0x180411730 Slot: 4
	public override void Init() { }

	// RVA: 0x411430 Offset: 0x40FA30 VA: 0x180411430 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x411910 Offset: 0x40FF10 VA: 0x180411910 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x4118A0 Offset: 0x40FEA0 VA: 0x1804118A0
	private void OnLifestealProc(Enemy enemy, int lifestealAmount) { }

	// RVA: 0x411AC0 Offset: 0x4100C0 VA: 0x180411AC0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x411580 Offset: 0x40FB80 VA: 0x180411580 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }

	// RVA: 0x411A30 Offset: 0x410030 VA: 0x180411A30
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBobDead : ItemBase // TypeDefIndex: 5536
{
	// Fields
	private string damageSource; // 0x30
	public const int maxGhosts = 80;
	private float unitsPerProjectile; // 0x38
	private float minSpawnTime; // 0x3C
	private float nextCheckTime; // 0x40
	private float accumulatedDistance; // 0x44
	private Vector3 lastPos; // 0x48

	// Methods

	// RVA: 0x411D00 Offset: 0x410300 VA: 0x180411D00 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x411E90 Offset: 0x410490 VA: 0x180411E90 Slot: 7
	public override void Tick() { }

	// RVA: 0x411B90 Offset: 0x410190 VA: 0x180411B90
	private float GetDamage() { }

	// RVA: 0x411D90 Offset: 0x410390 VA: 0x180411D90
	private void SpawnGhost() { }

	// RVA: 0x411C00 Offset: 0x410200 VA: 0x180411C00
	private float GetDuration() { }

	// RVA: 0x4121A0 Offset: 0x4107A0 VA: 0x1804121A0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x411C20 Offset: 0x410220 VA: 0x180411C20 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBonker : ItemBase // TypeDefIndex: 5537
{
	// Fields
	private float baseChance; // 0x30
	private float baseDamageMultiplier; // 0x34
	private float chancePerStack; // 0x38
	private float damageMultiplierPerStack; // 0x3C
	private float radiusPerStack; // 0x40
	private float radius; // 0x44
	private float maxRadius; // 0x48
	private float chance; // 0x4C
	private float damageMultiplier; // 0x50
	private string damageSource; // 0x58
	private DamageContainer reuseDc; // 0x60
	private int maxProcsPerTick; // 0x68
	private int numProcsThisTick; // 0x6C

	// Methods

	// RVA: 0x4123C0 Offset: 0x4109C0 VA: 0x1804123C0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x412440 Offset: 0x410A40 VA: 0x180412440 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x412990 Offset: 0x410F90 VA: 0x180412990 Slot: 7
	public override void Tick() { }

	// RVA: 0x4129A0 Offset: 0x410FA0 VA: 0x1804129A0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x412230 Offset: 0x410830 VA: 0x180412230 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBorgor : ItemBase // TypeDefIndex: 5538
{
	// Fields
	public const int maxAmountAbsolute = 20;
	private const float maxSpawnDistance = 30;
	private float baseChance; // 0x30
	private float chancePerAmount; // 0x34
	private float ratioHeal; // 0x38
	private int flatHealPerAmount; // 0x3C
	private int flatHeal; // 0x40
	private float chance; // 0x44

	// Methods

	// RVA: 0x413130 Offset: 0x411730 VA: 0x180413130 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x412F00 Offset: 0x411500 VA: 0x180412F00
	private void OnEnemyDied(Enemy enemy, DamageContainer deathSource) { }

	// RVA: 0x412DB0 Offset: 0x4113B0 VA: 0x180412DB0 Slot: 4
	public override void Init() { }

	// RVA: 0x412AE0 Offset: 0x4110E0 VA: 0x180412AE0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x412DA0 Offset: 0x4113A0 VA: 0x180412DA0
	public static int GetMaxAmount() { }

	// RVA: 0x413160 Offset: 0x411760 VA: 0x180413160
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x412C30 Offset: 0x411230 VA: 0x180412C30 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBossBuster : ItemBase // TypeDefIndex: 5539
{
	// Fields
	private float damagePerAmount; // 0x30
	private float additiveDamage; // 0x34

	// Methods

	// RVA: 0x413300 Offset: 0x411900 VA: 0x180413300 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x4133F0 Offset: 0x4119F0 VA: 0x1804133F0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x413320 Offset: 0x411920 VA: 0x180413320 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x413190 Offset: 0x411790 VA: 0x180413190 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemBrassKnuckles : ItemBase // TypeDefIndex: 5540
{
	// Fields
	private float damagePerAmount; // 0x30
	private float flatValue; // 0x34
	private float radius; // 0x38
	private float baseRadius; // 0x3C
	private float radiusAddPerAmount; // 0x40

	// Methods

	// RVA: 0x4134E0 Offset: 0x411AE0 VA: 0x1804134E0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x413510 Offset: 0x411B10 VA: 0x180413510 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x413560 Offset: 0x411B60 VA: 0x180413560
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x413400 Offset: 0x411A00 VA: 0x180413400 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemCactus : ItemBase // TypeDefIndex: 5541
{
	// Fields
	private float damagePerAmount; // 0x30
	private int numProjectilesPerAmount; // 0x34
	private float damage; // 0x38
	private int numProjectiles; // 0x3C
	public static string damageSource; // 0x0

	// Methods

	// RVA: 0x413960 Offset: 0x411F60 VA: 0x180413960 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x413810 Offset: 0x411E10 VA: 0x180413810 Slot: 4
	public override void Init() { }

	// RVA: 0x413580 Offset: 0x411B80 VA: 0x180413580 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x413980 Offset: 0x411F80 VA: 0x180413980
	private void OnTakeDamage(PlayerHealth ph, DamageContainer dc, bool isShieldDamage) { }

	// RVA: 0x4144D0 Offset: 0x412AD0 VA: 0x1804144D0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x4136D0 Offset: 0x411CD0 VA: 0x1804136D0 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x414440 Offset: 0x412A40 VA: 0x180414440
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemCampfire : ItemBase // TypeDefIndex: 5542
{
	// Fields
	private float healthRegenPerMinutePerAmount; // 0x30
	private float healthRegen; // 0x34
	public Campfire campfire; // 0x38
	private Vector3 campfirePos; // 0x40
	private float setupTime; // 0x4C
	private float distThreshold; // 0x50
	private float startCampfireTime; // 0x54
	private bool isCampActive; // 0x58

	// Methods

	// RVA: 0x413300 Offset: 0x411900 VA: 0x180413300 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x414BF0 Offset: 0x4131F0 VA: 0x180414BF0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x4144F0 Offset: 0x412AF0 VA: 0x1804144F0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x414990 Offset: 0x412F90 VA: 0x180414990 Slot: 7
	public override void Tick() { }

	// RVA: 0x414500 Offset: 0x412B00 VA: 0x180414500
	private void CreateCamp() { }

	// RVA: 0x414900 Offset: 0x412F00 VA: 0x180414900
	private void RemoveCamp() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemChonkplate : ItemBase // TypeDefIndex: 5543
{
	// Fields
	private float overhealPerAmount; // 0x30
	private float lifestealPerAmount; // 0x34

	// Methods

	// RVA: 0x414E10 Offset: 0x413410 VA: 0x180414E10 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x414EF0 Offset: 0x4134F0 VA: 0x180414EF0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x414C10 Offset: 0x413210 VA: 0x180414C10 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemClover : ItemBase // TypeDefIndex: 5544
{
	// Fields
	private float luckPerAmount; // 0x30

	// Methods

	// RVA: 0x4150C0 Offset: 0x4136C0 VA: 0x1804150C0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x415150 Offset: 0x413750 VA: 0x180415150
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x414F10 Offset: 0x413510 VA: 0x180414F10 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemCowardsCloak : ItemBase // TypeDefIndex: 5545
{
	// Fields
	private float speedPerAmount; // 0x30
	private float speedPerStack; // 0x34
	private int maxStacks; // 0x38
	private int stacksPerAmount; // 0x3C
	private float extraDurationPerAmount; // 0x40
	private float stacksResetAtTime; // 0x44
	private int stacks; // 0x48

	// Methods

	// RVA: 0x415710 Offset: 0x413D10 VA: 0x180415710 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x415650 Offset: 0x413C50 VA: 0x180415650
	private void OnDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage) { }

	// RVA: 0x415160 Offset: 0x413760 VA: 0x180415160
	private void AddTemporaryStack() { }

	// RVA: 0x415840 Offset: 0x413E40 VA: 0x180415840 Slot: 7
	public override void Tick() { }

	// RVA: 0x415720 Offset: 0x413D20 VA: 0x180415720
	private void RefreshStats() { }

	// RVA: 0x415500 Offset: 0x413B00 VA: 0x180415500 Slot: 4
	public override void Init() { }

	// RVA: 0x415200 Offset: 0x413800 VA: 0x180415200 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x4158C0 Offset: 0x413EC0 VA: 0x1804158C0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x415350 Offset: 0x413950 VA: 0x180415350 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemCreditCardGreen : ItemBase // TypeDefIndex: 5546
{
	// Fields
	private float luckPerChestPerAmount; // 0x30
	private float luckPerChest; // 0x34
	private float accumulatedLuck; // 0x38

	// Methods

	// RVA: 0x413300 Offset: 0x411900 VA: 0x180413300 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x42E3A0 Offset: 0x42C9A0 VA: 0x18042E3A0 Slot: 4
	public override void Init() { }

	// RVA: 0x42E0D0 Offset: 0x42C6D0 VA: 0x18042E0D0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x42E4C0 Offset: 0x42CAC0 VA: 0x18042E4C0
	private void OnChestWindowOpen() { }

	// RVA: 0x42E600 Offset: 0x42CC00 VA: 0x18042E600
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x42E1F0 Offset: 0x42C7F0 VA: 0x18042E1F0 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemCreditCardRed : ItemBase // TypeDefIndex: 5547
{
	// Fields
	private float damagePerChestAmount; // 0x30
	private float damagePerChest; // 0x34
	private float accumulatedDamage; // 0x38

	// Methods

	// RVA: 0x413300 Offset: 0x411900 VA: 0x180413300 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x42E8E0 Offset: 0x42CEE0 VA: 0x18042E8E0 Slot: 4
	public override void Init() { }

	// RVA: 0x42E610 Offset: 0x42CC10 VA: 0x18042E610 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x42EA00 Offset: 0x42D000 VA: 0x18042EA00
	private void OnChestWindowOpen() { }

	// RVA: 0x42EB30 Offset: 0x42D130 VA: 0x18042EB30
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x42E730 Offset: 0x42CD30 VA: 0x18042E730 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemCursedDoll : ItemBase // TypeDefIndex: 5549
{
	// Fields
	private int maxNumCursedEnemies; // 0x30
	private float damageMaxHpPercentage; // 0x34
	private int enemiesCursedPerDoll; // 0x38
	private int maxNumCursesPerCheck; // 0x3C
	private DamageContainer reuseDc; // 0x40
	private string damageSource; // 0x48
	private HashSet<Enemy> cursedEnemies; // 0x50
	private float attackCooldown; // 0x58
	private float nextAttackTime; // 0x5C

	// Methods

	// RVA: 0x42EFD0 Offset: 0x42D5D0 VA: 0x18042EFD0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x42EFE0 Offset: 0x42D5E0 VA: 0x18042EFE0 Slot: 7
	public override void Tick() { }

	// RVA: 0x42EF50 Offset: 0x42D550 VA: 0x18042EF50
	private void OnEnemyDied(Enemy enemy) { }

	// RVA: 0x42EE00 Offset: 0x42D400 VA: 0x18042EE00 Slot: 4
	public override void Init() { }

	// RVA: 0x42EB40 Offset: 0x42D140 VA: 0x18042EB40 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x42F7D0 Offset: 0x42DDD0 VA: 0x18042F7D0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x42EC90 Offset: 0x42D290 VA: 0x18042EC90 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemDemonBlade : ItemBase // TypeDefIndex: 5550
{
	// Fields
	private float critChance; // 0x30
	private float healChancePerStack; // 0x34
	private float totalHealChance; // 0x38

	// Methods

	// RVA: 0x42FEC0 Offset: 0x42E4C0 VA: 0x18042FEC0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x42FD50 Offset: 0x42E350 VA: 0x18042FD50
	private void OnEnemyDamaged(Enemy e, DamageContainer dc) { }

	// RVA: 0x42FF50 Offset: 0x42E550 VA: 0x18042FF50
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x42FC00 Offset: 0x42E200 VA: 0x18042FC00 Slot: 4
	public override void Init() { }

	// RVA: 0x42F940 Offset: 0x42DF40 VA: 0x18042F940 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x42FA90 Offset: 0x42E090 VA: 0x18042FA90 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemDemonicBlood : ItemBase // TypeDefIndex: 5551
{
	// Fields
	private static readonly float hpPerStack; // 0x0
	private int maxStacksPerAmount; // 0x30
	private int stacks; // 0x34
	private int maxStacks; // 0x38
	private int lastUsedStacks; // 0x3C
	private float nextUpdateTime; // 0x40

	// Methods

	// RVA: 0x430460 Offset: 0x42EA60 VA: 0x180430460 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x430450 Offset: 0x42EA50 VA: 0x180430450
	private void OnEnemyDied(Enemy enemy, DamageContainer deathSource) { }

	// RVA: 0x430480 Offset: 0x42EA80 VA: 0x180430480 Slot: 7
	public override void Tick() { }

	// RVA: 0x430300 Offset: 0x42E900 VA: 0x180430300 Slot: 4
	public override void Init() { }

	// RVA: 0x42FF70 Offset: 0x42E570 VA: 0x18042FF70 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x430610 Offset: 0x42EC10 VA: 0x180430610
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x4300C0 Offset: 0x42E6C0 VA: 0x1804300C0 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x4305D0 Offset: 0x42EBD0 VA: 0x1804305D0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemDemonicSoul : ItemBase // TypeDefIndex: 5552
{
	// Fields
	private static readonly float attackDamagePerStack; // 0x0
	private int maxStacksPerAmount; // 0x30
	private int stacks; // 0x34
	private int maxStacks; // 0x38
	private int lastUsedStacks; // 0x3C
	private float nextUpdateTime; // 0x40

	// Methods

	// RVA: 0x430460 Offset: 0x42EA60 VA: 0x180430460 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x430AD0 Offset: 0x42F0D0 VA: 0x180430AD0
	private void OnEnemyDied(Enemy enemy, DamageContainer deathSource) { }

	// RVA: 0x430AF0 Offset: 0x42F0F0 VA: 0x180430AF0 Slot: 7
	public override void Tick() { }

	// RVA: 0x430980 Offset: 0x42EF80 VA: 0x180430980 Slot: 4
	public override void Init() { }

	// RVA: 0x430690 Offset: 0x42EC90 VA: 0x180430690 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x430C80 Offset: 0x42F280 VA: 0x180430C80
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x4307E0 Offset: 0x42EDE0 VA: 0x1804307E0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }

	// RVA: 0x430C40 Offset: 0x42F240 VA: 0x180430C40
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemDragonfire : ItemBase // TypeDefIndex: 5553
{
	// Fields
	public float procChancePerAmount; // 0x30
	private float procChance; // 0x34
	private float burnChancePerAmount; // 0x38
	private float burnChance; // 0x3C
	private string damageSource; // 0x40

	// Methods

	// RVA: 0x430DE0 Offset: 0x42F3E0 VA: 0x180430DE0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x430E50 Offset: 0x42F450 VA: 0x180430E50 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x431250 Offset: 0x42F850 VA: 0x180431250
	private void TryProcBurn(DamageContainer dc, float overrideProcCoefficient = -1) { }

	// RVA: 0x4312D0 Offset: 0x42F8D0 VA: 0x1804312D0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x430D00 Offset: 0x42F300 VA: 0x180430D00 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemEagleClaw : ItemBase // TypeDefIndex: 5554
{
	// Fields
	public float procChancePerAmount; // 0x30
	private float procChance; // 0x34
	public float damageAddition; // 0x38
	public float damageAdditionPerAmount; // 0x3C
	private float knockupForce; // 0x40

	// Methods

	// RVA: 0x4314F0 Offset: 0x42FAF0 VA: 0x1804314F0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x431540 Offset: 0x42FB40 VA: 0x180431540 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x431610 Offset: 0x42FC10 VA: 0x180431610 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x431720 Offset: 0x42FD20 VA: 0x180431720
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x431360 Offset: 0x42F960 VA: 0x180431360 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemEchoShard : ItemBase // TypeDefIndex: 5555
{
	// Fields
	private static float chancePerAmount; // 0x0
	public float chance; // 0x30

	// Methods

	// RVA: 0x431970 Offset: 0x42FF70 VA: 0x180431970 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x4318E0 Offset: 0x42FEE0 VA: 0x1804318E0
	public int GetExtraShards() { }

	// RVA: 0x40FFE0 Offset: 0x40E5E0 VA: 0x18040FFE0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x431750 Offset: 0x42FD50 VA: 0x180431750 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x4319E0 Offset: 0x42FFE0 VA: 0x1804319E0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemElectricPlug : ItemBase // TypeDefIndex: 5556
{
	// Fields
	private string damageSource; // 0x30
	private DamageContainer reuseDc; // 0x38
	private float radius; // 0x40
	private float radiusPerAmount; // 0x44
	private int targets; // 0x48
	private int targetsPerAmount; // 0x4C

	// Methods

	// RVA: 0x431D10 Offset: 0x430310 VA: 0x180431D10 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x431B60 Offset: 0x430160 VA: 0x180431B60
	private float GetDamage() { }

	// RVA: 0x431BD0 Offset: 0x4301D0 VA: 0x180431BD0 Slot: 4
	public override void Init() { }

	// RVA: 0x431A20 Offset: 0x430020 VA: 0x180431A20 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x431D60 Offset: 0x430360 VA: 0x180431D60
	private void OnPlayerHit() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x432240 Offset: 0x430840 VA: 0x180432240
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemEnergyCore : ItemBase // TypeDefIndex: 5557
{
	// Fields
	private int orbsPerAmount; // 0x30
	private int numOrbs; // 0x34
	private float range; // 0x38
	private float cooldown; // 0x3C
	private float cooldownPerOrb; // 0x40
	private float nextSpawnTime; // 0x44
	private int orbsLeftToShoot; // 0x48
	private float nextOrbTime; // 0x4C
	private string damageSource; // 0x50

	// Methods

	// RVA: 0x4326A0 Offset: 0x430CA0 VA: 0x1804326A0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x432630 Offset: 0x430C30 VA: 0x180432630
	private float GetDamage() { }

	// RVA: 0x4326E0 Offset: 0x430CE0 VA: 0x1804326E0 Slot: 7
	public override void Tick() { }

	// RVA: 0x432360 Offset: 0x430960 VA: 0x180432360
	private void FireOrb(int index) { }

	// RVA: 0x432810 Offset: 0x430E10 VA: 0x180432810
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemFlappyFeathers : ItemBase // TypeDefIndex: 5558
{
	// Fields
	private float speedBoostPerAmount; // 0x30
	private float jumpHeightAdditionPerAmount; // 0x34
	private float speedBoost; // 0x38

	// Methods

	// RVA: 0x432B20 Offset: 0x431120 VA: 0x180432B20 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x432BC0 Offset: 0x4311C0 VA: 0x180432BC0
	private void OnJumped(PlayerMovement pm) { }

	// RVA: 0x4329F0 Offset: 0x430FF0 VA: 0x1804329F0 Slot: 4
	public override void Init() { }

	// RVA: 0x4328C0 Offset: 0x430EC0 VA: 0x1804328C0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x432D10 Offset: 0x431310 VA: 0x180432D10
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemForbiddenJuice : ItemBase // TypeDefIndex: 5559
{
	// Fields
	private float critPerStack; // 0x30

	// Methods

	// RVA: 0x432EE0 Offset: 0x4314E0 VA: 0x180432EE0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x432F70 Offset: 0x431570 VA: 0x180432F70
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x432D30 Offset: 0x431330 VA: 0x180432D30 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGamerGoggles : ItemBase // TypeDefIndex: 5560
{
	// Fields
	private float maxDamagePerAmount; // 0x30
	private float maxDamage; // 0x34
	private float updateCooldown; // 0x38
	private float nextUpdateTime; // 0x3C
	private float lastValue; // 0x40

	// Methods

	// RVA: 0x413300 Offset: 0x411900 VA: 0x180413300 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x433040 Offset: 0x431640 VA: 0x180433040 Slot: 7
	public override void Tick() { }

	// RVA: 0x433250 Offset: 0x431850 VA: 0x180433250
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x432F80 Offset: 0x431580 VA: 0x180432F80 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGasmask : ItemBase // TypeDefIndex: 5561
{
	// Fields
	private float armorPerStack; // 0x30
	private float overhealPerStack; // 0x34
	private float maxArmorPerAmount; // 0x38
	private float maxOverhealPerAmount; // 0x3C
	private float maxArmor; // 0x40
	private float maxOverheal; // 0x44
	private int lastStoredStacks; // 0x48
	private float updateInverval; // 0x4C
	private float nextUpdateTime; // 0x50

	// Methods

	// RVA: 0x433610 Offset: 0x431C10 VA: 0x180433610 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x4338C0 Offset: 0x431EC0 VA: 0x1804338C0
	private void UpdateRetaliation() { }

	// RVA: 0x433490 Offset: 0x431A90 VA: 0x180433490
	private int GetNumPoisonedEnemies() { }

	// RVA: 0x4336A0 Offset: 0x431CA0 VA: 0x1804336A0
	private void OnStageStarted() { }

	// RVA: 0x433700 Offset: 0x431D00 VA: 0x180433700 Slot: 7
	public override void Tick() { }

	// RVA: 0x433A00 Offset: 0x432000 VA: 0x180433A00
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x4334E0 Offset: 0x431AE0 VA: 0x1804334E0 Slot: 4
	public override void Init() { }

	// RVA: 0x433270 Offset: 0x431870 VA: 0x180433270 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x4333A0 Offset: 0x4319A0 VA: 0x1804333A0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGhost : ItemBase // TypeDefIndex: 5562
{
	// Fields
	public const int maxGhosts = 100;
	private int numGhosts; // 0x30
	private int numGhostsPerAmount; // 0x34
	private string damageSource; // 0x38

	// Methods

	// RVA: 0x433D20 Offset: 0x432320 VA: 0x180433D20 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x433D30 Offset: 0x432330 VA: 0x180433D30
	private void OnInteracted(BaseInteractable interactable, bool success) { }

	// RVA: 0x433E70 Offset: 0x432470 VA: 0x180433E70
	private void SpawnGhost() { }

	// RVA: 0x433BD0 Offset: 0x4321D0 VA: 0x180433BD0
	private float GetDuration() { }

	// RVA: 0x433B60 Offset: 0x432160 VA: 0x180433B60
	private float GetDamage() { }

	// RVA: 0x433BF0 Offset: 0x4321F0 VA: 0x180433BF0 Slot: 4
	public override void Init() { }

	// RVA: 0x433A30 Offset: 0x432030 VA: 0x180433A30 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x433F70 Offset: 0x432570 VA: 0x180433F70
	public void .ctor(ItemInventory itemInventoryRef) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGiantFork : ItemBase // TypeDefIndex: 5563
{
	// Fields
	private float critChancePerAmount; // 0x30
	private float megaCritChancePerAmount; // 0x34
	private float megaCritChance; // 0x38
	private float megaCritDamageMultiplier; // 0x3C

	// Methods

	// RVA: 0x434000 Offset: 0x432600 VA: 0x180434000 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x4340A0 Offset: 0x4326A0 VA: 0x1804340A0 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x4340F0 Offset: 0x4326F0 VA: 0x1804340F0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGlovesBlood : ItemBase // TypeDefIndex: 5564
{
	// Fields
	public float readyAtTime; // 0x30
	private float cooldown; // 0x34
	private float baseDamageMultiplier; // 0x38
	private float baseRadius; // 0x3C
	private float healPercentage; // 0x40
	private static string damageSource; // 0x0
	private DamageContainer reuseDc; // 0x48
	private EffectPlayer fx; // 0x50

	// Methods

	// RVA: 0x434960 Offset: 0x432F60 VA: 0x180434960
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x4342E0 Offset: 0x4328E0 VA: 0x1804342E0 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x434110 Offset: 0x432710 VA: 0x180434110
	private float GetDamage() { }

	// RVA: 0x4341A0 Offset: 0x4327A0 VA: 0x1804341A0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x4348D0 Offset: 0x432ED0 VA: 0x1804348D0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGlovesCursed : ItemBase // TypeDefIndex: 5565
{
	// Fields
	public float procChancePerAmount; // 0x30
	private float procChance; // 0x34
	private float difficultyPerAmount; // 0x38
	private float maxHpMultiplierPerAmount; // 0x3C
	private float baseDamageMultiplier; // 0x40
	private float baseRadius; // 0x44
	private static string damageSource; // 0x0
	private DamageContainer reuseDc; // 0x48
	private EffectPlayer fx; // 0x50

	// Methods

	// RVA: 0x435310 Offset: 0x433910 VA: 0x180435310
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x434D00 Offset: 0x433300 VA: 0x180434D00 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x434E10 Offset: 0x433410 VA: 0x180434E10 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x434A40 Offset: 0x433040 VA: 0x180434A40
	private float GetDamage() { }

	// RVA: 0x434AD0 Offset: 0x4330D0 VA: 0x180434AD0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x435280 Offset: 0x433880 VA: 0x180435280
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGlovesLightning : ItemBase // TypeDefIndex: 5566
{
	// Fields
	public float readyAtTime; // 0x30
	private float cooldown; // 0x34
	private float baseDamageMultiplier; // 0x38
	private float baseRadius; // 0x3C
	private static string damageSource; // 0x0
	private DamageContainer reuseDc; // 0x40
	private EffectPlayer fx; // 0x48

	// Methods

	// RVA: 0x435B40 Offset: 0x434140 VA: 0x180435B40
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x435560 Offset: 0x433B60 VA: 0x180435560 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x4353F0 Offset: 0x4339F0 VA: 0x1804353F0
	private float GetDamage() { }

	// RVA: 0x435480 Offset: 0x433A80 VA: 0x180435480 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x435AB0 Offset: 0x4340B0 VA: 0x180435AB0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGlovesPoison : ItemBase // TypeDefIndex: 5567
{
	// Fields
	public float readyAtTime; // 0x30
	private float cooldown; // 0x34
	private float baseDamageMultiplier; // 0x38
	private float baseRadius; // 0x3C
	private int poisonStacksPerAmount; // 0x40
	private static string damageSource; // 0x0
	private DamageContainer reuseDc; // 0x48
	private EffectPlayer fx; // 0x50

	// Methods

	// RVA: 0x436280 Offset: 0x434880 VA: 0x180436280
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x435CB0 Offset: 0x4342B0 VA: 0x180435CB0 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x435C20 Offset: 0x434220 VA: 0x180435C20
	private float GetDamage() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x4361F0 Offset: 0x4347F0 VA: 0x1804361F0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGlovesPower : ItemBase // TypeDefIndex: 5568
{
	// Fields
	private float knockbackForce; // 0x30
	public float procChancePerAmount; // 0x34
	private float procChance; // 0x38
	private float baseDamageMultiplier; // 0x3C
	private float radiusPerAmount; // 0x40
	private float radius; // 0x44
	private static string damageSource; // 0x0
	private DamageContainer reuseDc; // 0x48
	private EffectPlayer fx; // 0x50
	private float readyAtTime; // 0x58
	private float cooldown; // 0x5C

	// Methods

	// RVA: 0x436C70 Offset: 0x435270 VA: 0x180436C70
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x4364D0 Offset: 0x434AD0 VA: 0x1804364D0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x436570 Offset: 0x434B70 VA: 0x180436570 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x436360 Offset: 0x434960 VA: 0x180436360
	private float GetDamage() { }

	// RVA: 0x4363F0 Offset: 0x4349F0 VA: 0x1804363F0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x436BE0 Offset: 0x4351E0 VA: 0x180436BE0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGoldenGlove : ItemBase // TypeDefIndex: 5569
{
	// Fields
	private float chancePerAmount; // 0x30
	private float chance; // 0x34
	private int extraGoldFromOverload; // 0x38

	// Methods

	// RVA: 0x436F60 Offset: 0x435560 VA: 0x180436F60 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x436ED0 Offset: 0x4354D0 VA: 0x180436ED0
	public int GetExtraGold() { }

	// RVA: 0x4133F0 Offset: 0x4119F0 VA: 0x1804133F0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x436D60 Offset: 0x435360 VA: 0x180436D60 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGoldenShield : ItemBase // TypeDefIndex: 5570
{
	// Fields
	private float chancePerAmount; // 0x30
	private float chance; // 0x34
	private int extraGoldFromOverload; // 0x38
	private int goldPerAmount; // 0x3C
	private int goldOnHit; // 0x40
	private float cooldown; // 0x44
	private float readyAtTime; // 0x48

	// Methods

	// RVA: 0x437290 Offset: 0x435890 VA: 0x180437290 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x437340 Offset: 0x435940 VA: 0x180437340
	private void OnPlayerTakeDamage(PlayerHealth playerHealth, DamageContainer dc, bool b) { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	private int GetGold() { }

	// RVA: 0x437140 Offset: 0x435740 VA: 0x180437140 Slot: 4
	public override void Init() { }

	// RVA: 0x436FF0 Offset: 0x4355F0 VA: 0x180436FF0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x437480 Offset: 0x435A80 VA: 0x180437480
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGoldenSneakers : ItemBase // TypeDefIndex: 5571
{
	// Fields
	private float goldPerMeter; // 0x30
	private float goldPerMeterBase; // 0x34
	private float checkInterval; // 0x38
	private float nextCheckTime; // 0x3C
	private Vector3 lastPos; // 0x40
	private float accumulatedGold; // 0x4C

	// Methods

	// RVA: 0x4378A0 Offset: 0x435EA0 VA: 0x1804378A0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x4374A0 Offset: 0x435AA0 VA: 0x1804374A0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x437560 Offset: 0x435B60 VA: 0x180437560 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGrandmasSecretTonic : ItemBase // TypeDefIndex: 5572
{
	// Fields
	private float critChanceTotal; // 0x30
	private float baseRadius; // 0x34
	private float radiusPerAmount; // 0x38
	private float maxRadius; // 0x3C
	private float radius; // 0x40
	private float damageSpreadMultiplier; // 0x44
	private float procChance; // 0x48
	private DamageContainer procDc; // 0x50
	private string damageSource; // 0x58
	private int maxProcsPerTick; // 0x60
	private int numProcsThisTick; // 0x64

	// Methods

	// RVA: 0x437A80 Offset: 0x436080 VA: 0x180437A80 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x437EB0 Offset: 0x4364B0 VA: 0x180437EB0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x437A00 Offset: 0x436000 VA: 0x180437A00 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x437B00 Offset: 0x436100 VA: 0x180437B00 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x437EA0 Offset: 0x4364A0 VA: 0x180437EA0 Slot: 7
	public override void Tick() { }

	// RVA: 0x4378C0 Offset: 0x435EC0 VA: 0x1804378C0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemGymSauce : ItemBase // TypeDefIndex: 5573
{
	// Fields
	private float damagePerAmount; // 0x30

	// Methods

	// RVA: 0x438170 Offset: 0x436770 VA: 0x180438170 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x432F70 Offset: 0x431570 VA: 0x180432F70
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x437FC0 Offset: 0x4365C0 VA: 0x180437FC0 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemHolyBook : ItemBase // TypeDefIndex: 5574
{
	// Fields
	public static Action<float> A_OnUse; // 0x0
	private float maxHpPerAmount; // 0x30
	private float hpRegenPerAmount; // 0x34
	private float overhealPerAmount; // 0x38
	private float radius; // 0x3C
	private float radiusPerAmount; // 0x40
	private float healsThisTick; // 0x44
	private float nextDamageTime; // 0x48
	private float cooldown; // 0x4C
	private string damageSource; // 0x50
	private DamageContainer dc; // 0x58

	// Methods

	// RVA: 0x438660 Offset: 0x436C60 VA: 0x180438660 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x438CC0 Offset: 0x4372C0 VA: 0x180438CC0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x438500 Offset: 0x436B00 VA: 0x180438500 Slot: 4
	public override void Init() { }

	// RVA: 0x438200 Offset: 0x436800 VA: 0x180438200 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x438650 Offset: 0x436C50 VA: 0x180438650
	private void OnHeal(PlayerHealth ph, float hpHealed, bool isShield) { }

	// RVA: 0x4387A0 Offset: 0x436DA0 VA: 0x1804387A0 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x438350 Offset: 0x436950 VA: 0x180438350 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemIceCrystal : ItemBase // TypeDefIndex: 5575
{
	// Fields
	private float freezeTime; // 0x30
	public float procChancePerAmount; // 0x34
	private float procChance; // 0x38

	// Methods

	// RVA: 0x438FC0 Offset: 0x4375C0 VA: 0x180438FC0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x438ED0 Offset: 0x4374D0 VA: 0x180438ED0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x438F50 Offset: 0x437550 VA: 0x180438F50 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x438DF0 Offset: 0x4373F0 VA: 0x180438DF0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemIceCube : ItemBase // TypeDefIndex: 5576
{
	// Fields
	public float procChancePerAmount; // 0x30
	private float procChance; // 0x34
	private float freezeChancePerAmount; // 0x38
	private float freezeChance; // 0x3C
	public float damageRatio; // 0x40
	public float damageRatioPerAmount; // 0x44
	private string damageSource; // 0x48
	private DamageContainer reuseDc; // 0x50
	public static Action A_FreezeEnemy; // 0x0

	// Methods

	// RVA: 0x439590 Offset: 0x437B90 VA: 0x180439590
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x4390B0 Offset: 0x4376B0 VA: 0x1804390B0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x439130 Offset: 0x437730 VA: 0x180439130 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x4394C0 Offset: 0x437AC0 VA: 0x1804394C0
	private void TryProcFreeze(DamageContainer dc, float overrideProcCoefficient = -1) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x438FD0 Offset: 0x4375D0 VA: 0x180438FD0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemIdleJuice : ItemBase // TypeDefIndex: 5577
{
	// Fields
	private float damagePerAmount; // 0x30
	private float maxDamage; // 0x34
	private float damagePerSecond; // 0x38
	private Vector3 campfirePos; // 0x3C
	private float setupTime; // 0x48
	private float distThreshold; // 0x4C
	private float startCampfireTime; // 0x50
	private bool isCampActive; // 0x54
	private float currentDamage; // 0x58
	private float nextUpdateDamageTime; // 0x5C
	private float updateDamageInterval; // 0x60

	// Methods

	// RVA: 0x413300 Offset: 0x411900 VA: 0x180413300 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x439980 Offset: 0x437F80 VA: 0x180439980 Slot: 7
	public override void Tick() { }

	// RVA: 0x4396B0 Offset: 0x437CB0 VA: 0x1804396B0
	private void CreateCamp() { }

	// RVA: 0x439900 Offset: 0x437F00 VA: 0x180439900
	private void RemoveCamp() { }

	// RVA: 0x439DF0 Offset: 0x4383F0 VA: 0x180439DF0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x439790 Offset: 0x437D90 VA: 0x180439790 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemJoesDagger : ItemBase // TypeDefIndex: 5578
{
	// Fields
	private float attackDamagePerProc; // 0x30
	private float accumulatedDamaged; // 0x34
	private float executionChancePerAmount; // 0x38
	private float executionChance; // 0x3C
	private int stacks; // 0x40
	private int maxStacks; // 0x44
	private int lastUsedStacks; // 0x48
	private float nextUpdateTime; // 0x4C
	private string damageSource; // 0x50
	private const float maxRollsPerMinute = 200;
	private float rollCooldown; // 0x58
	private float nextRollTime; // 0x5C

	// Methods

	// RVA: 0x43A3B0 Offset: 0x4389B0 VA: 0x18043A3B0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43A480 Offset: 0x438A80 VA: 0x18043A480 Slot: 7
	public override void Tick() { }

	// RVA: 0x43A2D0 Offset: 0x4388D0 VA: 0x18043A2D0
	private void OnEnemyDamage(Enemy e, DamageContainer dc) { }

	// RVA: 0x43A180 Offset: 0x438780 VA: 0x18043A180 Slot: 4
	public override void Init() { }

	// RVA: 0x439E20 Offset: 0x438420 VA: 0x180439E20 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x43A580 Offset: 0x438B80 VA: 0x18043A580
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x43A3D0 Offset: 0x4389D0 VA: 0x18043A3D0 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x439F70 Offset: 0x438570 VA: 0x180439F70 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemKevin : ItemBase // TypeDefIndex: 5579
{
	// Fields
	private float damageChancePerAmount; // 0x30
	private float damageChance; // 0x34
	private int numHits; // 0x38
	public static string damageSource; // 0x0

	// Methods

	// RVA: 0x413300 Offset: 0x411900 VA: 0x180413300 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43AC60 Offset: 0x439260 VA: 0x18043AC60 Slot: 4
	public override void Init() { }

	// RVA: 0x43A9A0 Offset: 0x438FA0 VA: 0x18043A9A0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x43ADB0 Offset: 0x4393B0 VA: 0x18043ADB0
	private void OnEnemyDamaged(Enemy enemy, DamageContainer dc) { }

	// RVA: 0x43A630 Offset: 0x438C30 VA: 0x18043A630
	private void CheckSelfDamage() { }

	// RVA: 0x43AE40 Offset: 0x439440 VA: 0x18043AE40 Slot: 7
	public override void Tick() { }

	// RVA: 0x43AEE0 Offset: 0x4394E0 VA: 0x18043AEE0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43AAF0 Offset: 0x4390F0 VA: 0x18043AAF0 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x43AE50 Offset: 0x439450 VA: 0x18043AE50
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemKey : ItemBase // TypeDefIndex: 5580
{
	// Fields
	private float chancePerStack; // 0x30
	private float currentChance; // 0x34

	// Methods

	// RVA: 0x43B070 Offset: 0x439670 VA: 0x18043B070 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43AEF0 Offset: 0x4394F0 VA: 0x18043AEF0
	public float GetChance() { }

	// RVA: 0x43B0B0 Offset: 0x4396B0 VA: 0x18043B0B0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43AF00 Offset: 0x439500 VA: 0x18043AF00 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemLeechingCrystal : ItemBase // TypeDefIndex: 5581
{
	// Fields
	private float regenAdditivePerAmount; // 0x30
	private float maxHpPerAmount; // 0x34

	// Methods

	// RVA: 0x43B2A0 Offset: 0x4398A0 VA: 0x18043B2A0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43B370 Offset: 0x439970 VA: 0x18043B370
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43B0D0 Offset: 0x4396D0 VA: 0x18043B0D0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemLightningOrb : ItemBase // TypeDefIndex: 5582
{
	// Fields
	public float procChancePerAmount; // 0x30
	private float procChance; // 0x34
	private float stunChancePerAmount; // 0x38
	private float stunChance; // 0x3C
	private float baseRadius; // 0x40
	public float damageRatio; // 0x44
	public float damageRatioPerAmount; // 0x48
	private float foundEnemiesAtTime; // 0x4C
	private List<Collider> enemies; // 0x50
	private string damageSource; // 0x58
	private DamageContainer yepDc; // 0x60

	// Methods

	// RVA: 0x43B9E0 Offset: 0x439FE0 VA: 0x18043B9E0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x43B470 Offset: 0x439A70 VA: 0x18043B470 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43B4F0 Offset: 0x439AF0 VA: 0x18043B4F0 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43B960 Offset: 0x439F60 VA: 0x18043B960
	private void TryProcStun(DamageContainer dc, float overrideProcCoefficient = -1) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x43B390 Offset: 0x439990 VA: 0x18043B390 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemMedkit : ItemBase // TypeDefIndex: 5583
{
	// Fields
	private float hpRegenPerAmount; // 0x30

	// Methods

	// RVA: 0x43BC90 Offset: 0x43A290 VA: 0x18043BC90 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43BD20 Offset: 0x43A320 VA: 0x18043BD20
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43BAE0 Offset: 0x43A0E0 VA: 0x18043BAE0 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemMirror : ItemBase // TypeDefIndex: 5584
{
	// Fields
	public static Action<bool> A_MirrorReady; // 0x0
	public float cooldown; // 0x30
	private float minCooldown; // 0x34
	private float damageMultiplier; // 0x38
	private float damagePerAmount; // 0x3C
	private float lastReflectedTime; // 0x40
	private bool canReflect; // 0x44
	private string damageSource; // 0x48
	private DamageContainer reuseDc; // 0x50

	// Methods

	// RVA: 0x43C070 Offset: 0x43A670 VA: 0x18043C070 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43BEB0 Offset: 0x43A4B0 VA: 0x18043BEB0 Slot: 4
	public override void Init() { }

	// RVA: 0x43BD30 Offset: 0x43A330 VA: 0x18043BD30 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x43CA60 Offset: 0x43B060 VA: 0x18043CA60 Slot: 7
	public override void Tick() { }

	// RVA: 0x43C000 Offset: 0x43A600 VA: 0x18043C000
	private bool IsReady() { }

	// RVA: 0x43C100 Offset: 0x43A700 VA: 0x18043C100
	private bool ReflectDamage(DamageContainer dc) { }

	// RVA: 0x43C010 Offset: 0x43A610 VA: 0x18043C010
	private void OnCheckStopDamage(DamageContainer dc, bool shieldDamage) { }

	// RVA: 0x43CB10 Offset: 0x43B110 VA: 0x18043CB10
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemMoldyCheese : ItemBase // TypeDefIndex: 5585
{
	// Fields
	private float chanceToStackPerAmount; // 0x30
	private float totalChance; // 0x34
	private int procsSinceLastTick; // 0x38

	// Methods

	// RVA: 0x43CF10 Offset: 0x43B510 VA: 0x18043CF10
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x413300 Offset: 0x411900 VA: 0x180413300 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43CDA0 Offset: 0x43B3A0 VA: 0x18043CDA0 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x43CEA0 Offset: 0x43B4A0 VA: 0x18043CEA0 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x43CC30 Offset: 0x43B230 VA: 0x18043CC30 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemNoImplementation : ItemBase // TypeDefIndex: 5586
{
	// Methods

	// RVA: 0x40FFE0 Offset: 0x40E5E0 VA: 0x18040FFE0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemOats : ItemBase // TypeDefIndex: 5587
{
	// Fields
	private float hpPerAmount; // 0x30

	// Methods

	// RVA: 0x43D0D0 Offset: 0x43B6D0 VA: 0x18043D0D0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43D160 Offset: 0x43B760 VA: 0x18043D160
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43CF20 Offset: 0x43B520 VA: 0x18043CF20 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemOverpoweredLamp : ItemBase // TypeDefIndex: 5588
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x40FFE0 Offset: 0x40E5E0 VA: 0x18040FFE0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemPhantomShroud : ItemBase // TypeDefIndex: 5589
{
	// Fields
	private float evasionPerAmount; // 0x30
	private float damageMultiplierBase; // 0x34
	private float damageMultiplierPerAmount; // 0x38
	private float speedAdditionBase; // 0x3C
	private float speedAdditionPerAmount; // 0x40
	private float timeout; // 0x44
	private float attackSpeedPerStack; // 0x48
	private float damagePerStack; // 0x4C
	private int stacks; // 0x50
	private int maxStacks; // 0x54
	private bool hasEvaded; // 0x58
	private float speedResetAtTime; // 0x5C
	private bool hasSpeed; // 0x60

	// Methods

	// RVA: 0x43D770 Offset: 0x43BD70 VA: 0x18043D770 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43D600 Offset: 0x43BC00 VA: 0x18043D600
	private void OnEvade(Enemy enemy) { }

	// RVA: 0x43D880 Offset: 0x43BE80 VA: 0x18043D880 Slot: 7
	public override void Tick() { }

	// RVA: 0x43D830 Offset: 0x43BE30 VA: 0x18043D830 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x43D4B0 Offset: 0x43BAB0 VA: 0x18043D4B0 Slot: 4
	public override void Init() { }

	// RVA: 0x43D170 Offset: 0x43B770 VA: 0x18043D170 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x43D9D0 Offset: 0x43BFD0 VA: 0x18043D9D0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43D2C0 Offset: 0x43B8C0 VA: 0x18043D2C0 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemQuinsMask : ItemBase // TypeDefIndex: 5590
{
	// Fields
	private float thornsPerAmount; // 0x30
	private float baseRadius; // 0x34
	private float radiusPerAmount; // 0x38
	private float maxRadius; // 0x3C
	private float radius; // 0x40
	private float damageSpreadMultiplier; // 0x44
	private float procChance; // 0x48
	private HashSet<string> damageSources; // 0x50
	private DamageContainer procDc; // 0x58
	private string damageSource; // 0x60
	private string aegisDamageSource; // 0x68
	private int maxProcsPerTick; // 0x70
	private int numProcsThisTick; // 0x74

	// Methods

	// RVA: 0x43DCB0 Offset: 0x43C2B0 VA: 0x18043DCB0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43E1B0 Offset: 0x43C7B0 VA: 0x18043E1B0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x43DAF0 Offset: 0x43C0F0 VA: 0x18043DAF0 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x43DDA0 Offset: 0x43C3A0 VA: 0x18043DDA0 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x3BC900 Offset: 0x3BAF00 VA: 0x1803BC900 Slot: 7
	public override void Tick() { }

	// RVA: 0x43DA10 Offset: 0x43C010 VA: 0x18043DA10 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemRollerblades : ItemBase // TypeDefIndex: 5591
{
	// Fields
	private float cap; // 0x30
	private float maxAttackSpeedPerAmount; // 0x34
	private float updateStatsInterval; // 0x38
	private float nextUpdateTime; // 0x3C

	// Methods

	// RVA: 0x43E3F0 Offset: 0x43C9F0 VA: 0x18043E3F0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43E5B0 Offset: 0x43CBB0 VA: 0x18043E5B0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x43E410 Offset: 0x43CA10 VA: 0x18043E410 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43E2C0 Offset: 0x43C8C0 VA: 0x18043E2C0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemScarf : ItemBase // TypeDefIndex: 5592
{
	// Fields
	private float damageAddPerAmount; // 0x30
	private float damageAdd; // 0x34
	private float lastValueSet; // 0x38

	// Methods

	// RVA: 0x43E970 Offset: 0x43CF70 VA: 0x18043E970 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x43E960 Offset: 0x43CF60 VA: 0x18043E960
	private void OnGroundedChange(bool grounded) { }

	// RVA: 0x43EA70 Offset: 0x43D070 VA: 0x18043EA70
	private void UpdateDamage(bool grounded) { }

	// RVA: 0x43EB10 Offset: 0x43D110 VA: 0x18043EB10
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x43E830 Offset: 0x43CE30 VA: 0x18043E830 Slot: 4
	public override void Init() { }

	// RVA: 0x43E5D0 Offset: 0x43CBD0 VA: 0x18043E5D0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43E700 Offset: 0x43CD00 VA: 0x18043E700 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemShatteredWisdom : ItemBase // TypeDefIndex: 5593
{
	// Fields
	private static float damage; // 0x0
	public static float procCoefficient; // 0x4

	// Methods

	// RVA: 0x43EB70 Offset: 0x43D170 VA: 0x18043EB70 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43EB20 Offset: 0x43D120 VA: 0x18043EB20
	public static float GetDamage() { }

	// RVA: 0x40FFE0 Offset: 0x40E5E0 VA: 0x18040FFE0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43EC30 Offset: 0x43D230 VA: 0x18043EC30
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemSkuleg : ItemBase // TypeDefIndex: 5594
{
	// Fields
	private float difficultyPerAmount; // 0x30

	// Methods

	// RVA: 0x43EE20 Offset: 0x43D420 VA: 0x18043EE20 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43EEB0 Offset: 0x43D4B0 VA: 0x18043EEB0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43EC70 Offset: 0x43D270 VA: 0x18043EC70 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemSlipperyRing : ItemBase // TypeDefIndex: 5595
{
	// Fields
	private float evasionPerStack; // 0x30

	// Methods

	// RVA: 0x43F070 Offset: 0x43D670 VA: 0x18043F070 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x4133F0 Offset: 0x4119F0 VA: 0x1804133F0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43EEC0 Offset: 0x43D4C0 VA: 0x18043EEC0 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemSluttyCannon : ItemBase // TypeDefIndex: 5596
{
	// Fields
	private float procChance; // 0x30
	public float procChancePerAmount; // 0x34
	public float damageRatio; // 0x38
	public float damageRatioPerAmount; // 0x3C
	private string damageSource; // 0x40
	private int maxProcsPerTick; // 0x48
	private int numProcsThisTick; // 0x4C

	// Methods

	// RVA: 0x43F1E0 Offset: 0x43D7E0 VA: 0x18043F1E0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43F250 Offset: 0x43D850 VA: 0x18043F250 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x43F4B0 Offset: 0x43DAB0 VA: 0x18043F4B0 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x43F4C0 Offset: 0x43DAC0 VA: 0x18043F4C0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x43F100 Offset: 0x43D700 VA: 0x18043F100 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemSoulHarvester : ItemBase // TypeDefIndex: 5597
{
	// Fields
	private string damageSource; // 0x30
	public const int maxProjectiles = 100;
	private int numProjectiles; // 0x38
	private float damageMultiplier; // 0x3C
	private float range; // 0x40

	// Methods

	// RVA: 0x43F810 Offset: 0x43DE10 VA: 0x18043F810 Slot: 4
	public override void Init() { }

	// RVA: 0x43F560 Offset: 0x43DB60 VA: 0x18043F560 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x43FC70 Offset: 0x43E270 VA: 0x18043FC70 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x43F6B0 Offset: 0x43DCB0 VA: 0x18043F6B0
	private float GetDamage() { }

	// RVA: 0x43F960 Offset: 0x43DF60 VA: 0x18043F960
	private void OnEnemyDied(Enemy enemy) { }

	// RVA: 0x43FC80 Offset: 0x43E280 VA: 0x18043FC80
	private void SpawnProjectile(Vector3 pos) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x43FED0 Offset: 0x43E4D0 VA: 0x18043FED0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x43F730 Offset: 0x43DD30 VA: 0x18043F730 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemSpeedBoi : ItemBase // TypeDefIndex: 5598
{
	// Fields
	private float damageMultiplierDuringFreeze; // 0x30
	private float duration; // 0x34
	private float durationPerAmount; // 0x38
	private float normalCooldown; // 0x3C
	private float slowdownReadyAtTime; // 0x40
	public static Action A_Slowdown; // 0x0
	private float slowdownHpRatio; // 0x44

	// Methods

	// RVA: 0x440C40 Offset: 0x43F240 VA: 0x180440C40
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x440440 Offset: 0x43EA40 VA: 0x180440440 Slot: 4
	public override void Init() { }

	// RVA: 0x43FF60 Offset: 0x43E560 VA: 0x18043FF60 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x440950 Offset: 0x43EF50 VA: 0x180440950
	private void RefreshTimeScale() { }

	// RVA: 0x440790 Offset: 0x43ED90 VA: 0x180440790 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x4407D0 Offset: 0x43EDD0 VA: 0x1804407D0
	private void OnTakeDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage) { }

	// RVA: 0x440B10 Offset: 0x43F110 VA: 0x180440B10
	private void Slowdown() { }

	// RVA: 0x440A90 Offset: 0x43F090 VA: 0x180440A90
	private void ResetStats() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x4402B0 Offset: 0x43E8B0 VA: 0x1804402B0 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemSpicyMeatball : ItemBase // TypeDefIndex: 5599
{
	// Fields
	private float baseRadius; // 0x30
	private float radiusPerAmount; // 0x34
	private float maxRadius; // 0x38
	private float radius; // 0x3C
	private float damageSpreadMultiplier; // 0x40
	private float procChance; // 0x44
	private string damageSource; // 0x48
	private DamageContainer reuseDc; // 0x50
	private int maxProcsPerTick; // 0x58
	private int numProcsThisTick; // 0x5C

	// Methods

	// RVA: 0x440E00 Offset: 0x43F400 VA: 0x180440E00 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x440E80 Offset: 0x43F480 VA: 0x180440E80 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x441220 Offset: 0x43F820 VA: 0x180441220 Slot: 7
	public override void Tick() { }

	// RVA: 0x441230 Offset: 0x43F830 VA: 0x180441230
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x440C70 Offset: 0x43F270 VA: 0x180440C70 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemSpikyShield : ItemBase // TypeDefIndex: 5600
{
	// Fields
	private float armorPerAmount; // 0x30
	private float retaliationPerArmorPerAmount; // 0x34
	private float lastStoredArmor; // 0x38
	private float nextUpdateTime; // 0x3C

	// Methods

	// RVA: 0x441570 Offset: 0x43FB70 VA: 0x180441570 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x441790 Offset: 0x43FD90 VA: 0x180441790
	private void UpdateRetaliation() { }

	// RVA: 0x441640 Offset: 0x43FC40 VA: 0x180441640 Slot: 7
	public override void Tick() { }

	// RVA: 0x441860 Offset: 0x43FE60 VA: 0x180441860
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x441360 Offset: 0x43F960 VA: 0x180441360 Slot: 10
	protected override Dictionary<string, object> GetLocalizationKeys() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemTacticalGlasses : ItemBase // TypeDefIndex: 5601
{
	// Fields
	private float damagePerAmount; // 0x30
	private float additiveDamage; // 0x34

	// Methods

	// RVA: 0x413300 Offset: 0x411900 VA: 0x180413300 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x441AB0 Offset: 0x4400B0 VA: 0x180441AB0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x4419F0 Offset: 0x43FFF0 VA: 0x1804419F0 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x441880 Offset: 0x43FE80 VA: 0x180441880 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemTimeBracelet : ItemBase // TypeDefIndex: 5602
{
	// Fields
	private float damagePerAmount; // 0x30

	// Methods

	// RVA: 0x441CD0 Offset: 0x4402D0 VA: 0x180441CD0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x410880 Offset: 0x40EE80 VA: 0x180410880
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x441AC0 Offset: 0x4400C0 VA: 0x180441AC0 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemToxicBarrel : ItemBase // TypeDefIndex: 5603
{
	// Fields
	public static Action<float> A_OnUse; // 0x0
	private float radius; // 0x30
	private float radiusPerAmount; // 0x34
	private int poisonStacksPerAmount; // 0x38
	private int poisonStacks; // 0x3C
	private float cooldown; // 0x40
	private float readyAtTime; // 0x44
	private float poisonDuration; // 0x48
	private string damageSource; // 0x50
	private DamageContainer dc; // 0x58

	// Methods

	// RVA: 0x442220 Offset: 0x440820 VA: 0x180442220 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x4420D0 Offset: 0x4406D0 VA: 0x1804420D0 Slot: 4
	public override void Init() { }

	// RVA: 0x441F80 Offset: 0x440580 VA: 0x180441F80 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x442250 Offset: 0x440850 VA: 0x180442250
	private void OnTakeDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage) { }

	// RVA: 0x441D60 Offset: 0x440360 VA: 0x180441D60
	private void Activate() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x4422F0 Offset: 0x4408F0 VA: 0x1804422F0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemTurboSocks : ItemBase // TypeDefIndex: 5604
{
	// Fields
	private float moveSpeedPerAmount; // 0x30

	// Methods

	// RVA: 0x4425C0 Offset: 0x440BC0 VA: 0x1804425C0 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x4133F0 Offset: 0x4119F0 VA: 0x1804133F0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x442410 Offset: 0x440A10 VA: 0x180442410 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemUnstableTransfusion : ItemBase // TypeDefIndex: 5605
{
	// Fields
	private float chanceToStackPerAmount; // 0x30
	private float totalChance; // 0x34

	// Methods

	// RVA: 0x413300 Offset: 0x411900 VA: 0x180413300 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x442840 Offset: 0x440E40 VA: 0x180442840 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x442940 Offset: 0x440F40 VA: 0x180442940
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x442640 Offset: 0x440C40 VA: 0x180442640 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemWeebHeadset : ItemBase // TypeDefIndex: 5606
{
	// Fields
	public float charmChancePerAmount; // 0x30
	private float durationPerAmount; // 0x34
	private float charmDuration; // 0x38
	private float charmChance; // 0x3C
	private int maxProcsPerTick; // 0x40
	private int numProcsThisTick; // 0x44

	// Methods

	// RVA: 0x442A60 Offset: 0x441060 VA: 0x180442A60
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x442950 Offset: 0x440F50 VA: 0x180442950 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x4429C0 Offset: 0x440FC0 VA: 0x1804429C0 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x442A50 Offset: 0x441050 VA: 0x180442A50 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemWrench : ItemBase // TypeDefIndex: 5607
{
	// Fields
	private float chargeSpeedIncrease; // 0x30
	private float chargeRewardIncrease; // 0x34

	// Methods

	// RVA: 0x442AA0 Offset: 0x4410A0 VA: 0x180442AA0
	public float GetChargeSpeedIncrease() { }

	// RVA: 0x442A80 Offset: 0x441080 VA: 0x180442A80
	public float GetChargeRewardMultiplier() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x442CE0 Offset: 0x4412E0 VA: 0x180442CE0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x442AB0 Offset: 0x4410B0 VA: 0x180442AB0 Slot: 11
	public override string GetDescription(LocalizedString localizedString) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Items.ItemImplementations
public class ItemZaWarudo : ItemBase // TypeDefIndex: 5608
{
	// Fields
	public static float freezeTime; // 0x0

	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected override void OnInitOrAmountChanged() { }

	// RVA: 0x40FFE0 Offset: 0x40E5E0 VA: 0x18040FFE0
	public void .ctor(ItemInventory itemInventoryRef) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void Init() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public override void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void PreAttack(DamageContainer dc, StatComponents itemAttackModifier) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void ProcOnHitEffects(DamageContainer dc) { }

	// RVA: 0x442D00 Offset: 0x441300 VA: 0x180442D00
	private static void .cctor() { }
}

