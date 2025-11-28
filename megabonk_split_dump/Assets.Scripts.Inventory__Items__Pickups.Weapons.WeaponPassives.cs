// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives
public abstract class WeaponPassive // TypeDefIndex: 5485
{
	// Fields
	public Dictionary<EStat, StatModifiersContainer> statModifiers; // 0x10
	protected WeaponBase weaponBase; // 0x18

	// Methods

	// RVA: 0x428230 Offset: 0x426830 VA: 0x180428230
	public void .ctor(WeaponBase weaponBase) { }

	// RVA: 0x4280D0 Offset: 0x4266D0 VA: 0x1804280D0
	protected void SetStat(StatModifier statModifier) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Init();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Cleanup();
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives
public class WeaponPassiveBloodMagic : WeaponPassive // TypeDefIndex: 5486
{
	// Fields
	private int stacks; // 0x20
	private float stackChance; // 0x24
	private static string bloodMagicDamageSource; // 0x0
	private static float maxRollsUpgradesPerMinute; // 0x8
	private float rollCooldown; // 0x28
	private float nextReadyTime; // 0x2C

	// Methods

	// RVA: 0x427490 Offset: 0x425A90 VA: 0x180427490 Slot: 4
	public override void Init() { }

	// RVA: 0x427340 Offset: 0x425940 VA: 0x180427340 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x4275E0 Offset: 0x425BE0 VA: 0x1804275E0
	private void OnEnemyDied(Enemy enemy, DamageContainer dc) { }

	// RVA: 0x427960 Offset: 0x425F60 VA: 0x180427960
	public void .ctor(WeaponBase weaponBase) { }

	// RVA: 0x4278C0 Offset: 0x425EC0 VA: 0x1804278C0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives
public class WeaponPassiveDice : WeaponPassive // TypeDefIndex: 5487
{
	// Fields
	private int stacks; // 0x20
	private float critPer6; // 0x24
	private string movingStatName; // 0x28
	private static float maxRollsUpgradesPerMinute; // 0x0
	private float rollCooldown; // 0x30
	private float nextRollTime; // 0x34
	private float accumulatedCritChance; // 0x38

	// Methods

	// RVA: 0x427B10 Offset: 0x426110 VA: 0x180427B10 Slot: 4
	public override void Init() { }

	// RVA: 0x4279F0 Offset: 0x425FF0 VA: 0x1804279F0 Slot: 5
	public override void Cleanup() { }

	// RVA: 0x427C30 Offset: 0x426230 VA: 0x180427C30
	private void OnStackAdded() { }

	// RVA: 0x427E90 Offset: 0x426490 VA: 0x180427E90
	public void .ctor(WeaponBase weaponBase) { }

	// RVA: 0x427E50 Offset: 0x426450 VA: 0x180427E50
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponPassives
public class WeaponPassiveFactory // TypeDefIndex: 5488
{
	// Methods

	// RVA: 0x427F40 Offset: 0x426540 VA: 0x180427F40
	public static WeaponPassive GetWeaponPassive(WeaponBase weaponBase) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

