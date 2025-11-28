// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public enum EStatCategory // TypeDefIndex: 5500
{
	// Fields
	public int value__; // 0x0
	public const EStatCategory Offensive = 0;
	public const EStatCategory Defensive = 1;
	public const EStatCategory Movement = 2;
	public const EStatCategory Utility = 3;
	public const EStatCategory Difficulty = 4;
	public const EStatCategory Coolness = 5;
	public const EStatCategory Null = 6;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public enum EStatModifyType // TypeDefIndex: 5501
{
	// Fields
	public int value__; // 0x0
	public const EStatModifyType Addition = 0;
	public const EStatModifyType Multiplication = 1;
	public const EStatModifyType Flat = 2;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public enum EStatusEffect // TypeDefIndex: 5502
{
	// Fields
	public int value__; // 0x0
	public const EStatusEffect Haste = 0;
	public const EStatusEffect Rage = 1;
	public const EStatusEffect Shield = 2;
	public const EStatusEffect Stonks = 3;
	public const EStatusEffect TimeFreeze = 4;
	public const EStatusEffect Invulnerability = 5;
	public const EStatusEffect Slow = 6;
	public const EStatusEffect Freeze = 7;
	public const EStatusEffect Bleed = 8;
	public const EStatusEffect Poison = 9;
	public const EStatusEffect BossPoison = 10;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public class PlayerStatsNew // TypeDefIndex: 5503
{
	// Fields
	public Dictionary<EStat, float> stats; // 0x10
	public Dictionary<EStat, float> rawStats; // 0x18
	public Dictionary<EStat, StatComponents> statValuesMap; // 0x20
	private PlayerInventory playerInventory; // 0x28
	public static Action<EStat> A_StatUpdate; // 0x0
	private HashSet<EStat> queuedUpdateStats; // 0x30
	private Dictionary<EStat, HashSet<EShopItem>> statToShopItems; // 0x38
	private bool ignoreShopItems; // 0x40

	// Methods

	// RVA: 0x41B3D0 Offset: 0x4199D0 VA: 0x18041B3D0
	public void .ctor(PlayerInventory inventory, bool ignoreShopItems = False) { }

	// RVA: 0x419820 Offset: 0x417E20 VA: 0x180419820
	public void OnDestroy() { }

	// RVA: 0x4195B0 Offset: 0x417BB0 VA: 0x1804195B0
	public void Tick() { }

	// RVA: 0x419DB0 Offset: 0x4183B0 VA: 0x180419DB0
	private void TryPopStatUpdatesQueue() { }

	// RVA: 0x4195B0 Offset: 0x417BB0 VA: 0x1804195B0
	public void ForceUpdateStats() { }

	// RVA: 0x419CF0 Offset: 0x4182F0 VA: 0x180419CF0
	private void QueueUpdateStatTome(ETome eTome, EStat stat) { }

	// RVA: 0x419D50 Offset: 0x418350 VA: 0x180419D50
	private void QueueUpdateStat(EStat stat) { }

	// RVA: 0x419F20 Offset: 0x418520 VA: 0x180419F20
	private void UpdateStat(EStat stat) { }

	// RVA: 0x4194B0 Offset: 0x417AB0 VA: 0x1804194B0
	private void ApplyStatModifier(StatModifier modifier, int amount, ref float flatValues, ref float additionValues, ref float multiplicationValues) { }

	// RVA: 0x419540 Offset: 0x417B40 VA: 0x180419540
	private float CheckFinalValue(EStat stat, float value) { }

	// RVA: 0x4195C0 Offset: 0x417BC0 VA: 0x1804195C0
	public static float GetBaseValue(EStat stat) { }

	// RVA: 0x4196E0 Offset: 0x417CE0 VA: 0x1804196E0
	public float GetStat(EStat stat) { }

	// RVA: 0x419680 Offset: 0x417C80 VA: 0x180419680
	public float GetRawStat(EStat stat) { }

	// RVA: 0x4197C0 Offset: 0x417DC0 VA: 0x1804197C0
	public float GetUnclampedStat(EStat stat) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public class PlayerStatusEffects // TypeDefIndex: 5504
{
	// Fields
	public Dictionary<EStatusEffect, StatusEffect> statusEffects; // 0x10
	public static Action<EStat> A_StatusModifiedStat; // 0x0
	public static Action<EStatusEffect, bool> A_StatusEffectAdded; // 0x8
	public static Action<EStatusEffect> A_StatusEffectRemoved; // 0x10
	public const string poisonEffectName = "Poison";
	public const string bleedEffectName = "Bleed";
	private float nextBleedTime; // 0x18
	private float bleedInterval; // 0x1C
	private float nextPoisonTime; // 0x20
	private float poisonInterval; // 0x24

	// Methods

	// RVA: 0x41DF90 Offset: 0x41C590 VA: 0x18041DF90
	public void .ctor() { }

	// RVA: 0x41C5E0 Offset: 0x41ABE0 VA: 0x18041C5E0
	public void OnDestroy() { }

	// RVA: 0x41DC60 Offset: 0x41C260 VA: 0x18041DC60
	public void Tick() { }

	// RVA: 0x41C060 Offset: 0x41A660 VA: 0x18041C060
	public void AddNewEffect(StatusEffect statusEffect, float statusLengthTime) { }

	// RVA: 0x41D350 Offset: 0x41B950 VA: 0x18041D350
	private void RemoveStatusEffect(EStatusEffect eStatusEffect) { }

	// RVA: 0x41D210 Offset: 0x41B810 VA: 0x18041D210
	public void RemoveAllStatusEffects() { }

	// RVA: 0x41C580 Offset: 0x41AB80 VA: 0x18041C580
	public bool HasStatusEffect(EStatusEffect effect) { }

	// RVA: 0x41D630 Offset: 0x41BC30 VA: 0x18041D630
	public void TestPickup(EPickup ePickup) { }

	// RVA: 0x41C990 Offset: 0x41AF90 VA: 0x18041C990
	private void OnPickupTriggered(Pickup pickup) { }

	// RVA: 0x41D4B0 Offset: 0x41BAB0 VA: 0x18041D4B0
	public void SlowPlayer(float time) { }

	// RVA: 0x41C400 Offset: 0x41AA00 VA: 0x18041C400
	public void FreezePlayer(float time) { }

	// RVA: 0x41C220 Offset: 0x41A820 VA: 0x18041C220
	public void BleedPlayer(float duration) { }

	// RVA: 0x41CF60 Offset: 0x41B560 VA: 0x18041CF60
	public void PoisonPlayer(float duration) { }

	// RVA: 0x41C310 Offset: 0x41A910 VA: 0x18041C310
	public void BossPoisonPlayer(float duration) { }

	// RVA: 0x41C9B0 Offset: 0x41AFB0 VA: 0x18041C9B0
	private void OnPickupTriggered(EPickup ePickup) { }

	// RVA: 0x41C810 Offset: 0x41AE10 VA: 0x18041C810
	private void OnLevelupScreenDone() { }

	// RVA: 0x41D640 Offset: 0x41BC40 VA: 0x18041D640
	private void TickEffects() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
[Serializable]
public class StatCategoryRatio // TypeDefIndex: 5505
{
	// Fields
	public EStatCategory category; // 0x10
	public float value; // 0x14

	// Methods

	// RVA: 0x421D90 Offset: 0x420390 VA: 0x180421D90
	public void .ctor(EStatCategory category, float value) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public class StatComponents // TypeDefIndex: 5506
{
	// Fields
	public bool hasModifications; // 0x10
	[CompilerGenerated]
	private float <baseValue>k__BackingField; // 0x14
	[CompilerGenerated]
	private float <additiveValue>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <multiplicativeValue>k__BackingField; // 0x1C

	// Properties
	public float baseValue { get; set; }
	public float additiveValue { get; set; }
	public float multiplicativeValue { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3A4AB0 Offset: 0x3A30B0 VA: 0x1803A4AB0
	public float get_baseValue() { }

	[CompilerGenerated]
	// RVA: 0x3A4C60 Offset: 0x3A3260 VA: 0x1803A4C60
	private void set_baseValue(float value) { }

	[CompilerGenerated]
	// RVA: 0x3A4A70 Offset: 0x3A3070 VA: 0x1803A4A70
	public float get_additiveValue() { }

	[CompilerGenerated]
	// RVA: 0x3A4C30 Offset: 0x3A3230 VA: 0x1803A4C30
	private void set_additiveValue(float value) { }

	[CompilerGenerated]
	// RVA: 0x3CB3F0 Offset: 0x3C99F0 VA: 0x1803CB3F0
	public float get_multiplicativeValue() { }

	[CompilerGenerated]
	// RVA: 0x3CB450 Offset: 0x3C9A50 VA: 0x1803CB450
	private void set_multiplicativeValue(float value) { }

	// RVA: 0x421E40 Offset: 0x420440 VA: 0x180421E40
	public void Recycle() { }

	// RVA: 0x421E60 Offset: 0x420460 VA: 0x180421E60
	public void SetValues(float baseValues, float additiveValues, float multiplicativeValues) { }

	// RVA: 0x421E00 Offset: 0x420400 VA: 0x180421E00
	public float GetFinalValue(StatComponents other) { }

	// RVA: 0x421DF0 Offset: 0x4203F0 VA: 0x180421DF0
	public void AddMultiplier(float value) { }

	// RVA: 0x421DD0 Offset: 0x4203D0 VA: 0x180421DD0
	public void AddAdditive(float value) { }

	// RVA: 0x421DE0 Offset: 0x4203E0 VA: 0x180421DE0
	public void AddFlat(float value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public class StatInventory // TypeDefIndex: 5507
{
	// Fields
	public Dictionary<EStat, List<StatModifier>> permanentChanges; // 0x10
	public Dictionary<EStat, List<TemporaryStat>> temporaryChanges; // 0x18
	public Dictionary<string, StatModifier> movingStats; // 0x20
	public static Action<EStat> A_StatsChanged; // 0x0
	private HashSet<EStat> refreshStats; // 0x28

	// Methods

	// RVA: 0x421F00 Offset: 0x420500 VA: 0x180421F00
	public void ChangeStat(StatModifier stat, bool permanent, float timeout, bool addToShrineLog) { }

	// RVA: 0x421E70 Offset: 0x420470 VA: 0x180421E70
	public void ChangeMovingStat(string name, StatModifier statModifier) { }

	// RVA: 0x4222D0 Offset: 0x4208D0 VA: 0x1804222D0
	public void RemoveMovingStat(string name) { }

	// RVA: 0x4223B0 Offset: 0x4209B0 VA: 0x1804223B0
	public void Tick() { }

	// RVA: 0x422990 Offset: 0x420F90 VA: 0x180422990
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
[Serializable]
public class StatModifier // TypeDefIndex: 5508
{
	// Fields
	public EStat stat; // 0x10
	public EStatModifyType modifyType; // 0x14
	public float modification; // 0x18

	// Methods

	// RVA: 0x3A4A70 Offset: 0x3A3070 VA: 0x1803A4A70
	public float GetModificationAtAmount(int amount) { }

	// RVA: 0x422AE0 Offset: 0x4210E0 VA: 0x180422AE0
	public float GetModificationTotal(int amount) { }

	// RVA: 0x422B60 Offset: 0x421160 VA: 0x180422B60 Slot: 3
	public override string ToString() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public static class StatScaling // TypeDefIndex: 5509
{
	// Methods

	// RVA: 0x422D50 Offset: 0x421350 VA: 0x180422D50
	public static float HyperbolicScaling(float input, float maxValue = 1, float scaling = 0.5) { }

	// RVA: 0x422D60 Offset: 0x421360 VA: 0x180422D60
	private static float PowerScaling(float inputValue, float maxInputValue, float maxValue, float diminishingEffect) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public class StatsConstants // TypeDefIndex: 5510
{
	// Fields
	public static float cooldownDeviationMax; // 0x0
	public static float eliteSpawnChance; // 0x4

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x423F60 Offset: 0x422560 VA: 0x180423F60
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public class StatusEffect // TypeDefIndex: 5511
{
	// Fields
	public EStatusEffect eStatusEffect; // 0x10
	public StatModifier[] modifiers; // 0x18
	public float expirationTime; // 0x20
	public float addedTime; // 0x24

	// Methods

	// RVA: 0x423FB0 Offset: 0x4225B0 VA: 0x180423FB0
	public void .ctor(EStatusEffect eStatusEffect, float expirationTime, StatModifier[] modifiers) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public static class StatUtility // TypeDefIndex: 5512
{
	// Methods

	// RVA: 0x423D10 Offset: 0x422310 VA: 0x180423D10
	public static string GetUpgradeDescriptionWeapon(List<StatModifier> modifiers, WeaponData weaponData) { }

	// RVA: 0x4239C0 Offset: 0x421FC0 VA: 0x1804239C0
	public static string GetUpgradeDescriptionTome(List<StatModifier> modifiers, TomeData tomeData) { }

	// RVA: 0x423AB0 Offset: 0x4220B0 VA: 0x180423AB0
	public static string GetUpgradeDescriptionWeaponModifier(StatModifier modifier, WeaponData weaponData, string color = "#ffffff") { }

	// RVA: 0x4236B0 Offset: 0x421CB0 VA: 0x1804236B0
	public static string GetUpgradeDescriptionTomeModifier(StatModifier modifier, TomeData tomeData, string color = "#ffffff") { }

	// RVA: 0x423460 Offset: 0x421A60 VA: 0x180423460
	public static string GetUpgradeDescriptionStat(StatModifier modifier, string color = "#ffffff") { }

	// RVA: 0x422DC0 Offset: 0x4213C0 VA: 0x180422DC0
	public static string EncapsulateNumber(string number, string color) { }

	// RVA: 0x422EE0 Offset: 0x4214E0 VA: 0x180422EE0
	public static string EncapsulateNumber(float number, string color) { }

	// RVA: 0x422F50 Offset: 0x421550 VA: 0x180422F50
	public static string GetModificationString(StatModifier modifier, bool addOneToMultiplication = True) { }

	// RVA: 0x422F90 Offset: 0x421590 VA: 0x180422F90
	public static string GetModificationString(EStatModifyType modifyType, EStat stat, float value, bool addOneToMultiplication = True, bool usePrefix = True) { }

	// RVA: 0x423E00 Offset: 0x422400 VA: 0x180423E00
	public static string GetWeaponModificationString(EStatModifyType modifyType, EStat stat, float value, bool addOneToMultiplication = True) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	private static string ModifyStatName(string statName, EWeapon eWeapon) { }

	// RVA: 0x423290 Offset: 0x421890 VA: 0x180423290
	public static float GetRarityValue(float value, ERarity rarity, int decimals = 2) { }

	// RVA: 0x423350 Offset: 0x421950 VA: 0x180423350
	public static EStatCategory GetStatCategory(EStat eStat) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Stats
public class TemporaryStat // TypeDefIndex: 5513
{
	// Fields
	public StatModifier modifier; // 0x10
	public float expirationTime; // 0x18

	// Methods

	// RVA: 0x3DDE90 Offset: 0x3DC490 VA: 0x1803DDE90
	public void .ctor(StatModifier modifier, float expirationTime) { }
}

