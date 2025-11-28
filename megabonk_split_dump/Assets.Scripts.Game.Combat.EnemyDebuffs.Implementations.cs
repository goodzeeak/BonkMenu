// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
public class DebuffBloodmark : EnemyDebuff // TypeDefIndex: 5692
{
	// Fields
	public const float defaultDuration = 4;
	private int stacks; // 0x20
	public static string damageSource; // 0x0
	private DamageContainer dc; // 0x28
	private float baseDamageMultiplier; // 0x30
	private float damage; // 0x34
	private bool isDone; // 0x38
	private bool isSubscribed; // 0x39

	// Methods

	// RVA: 0x44EA40 Offset: 0x44D040 VA: 0x18044EA40
	public void .ctor(Enemy enemy, DamageContainer dc, float duration, int stacks) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void MyTick() { }

	// RVA: 0x44E5F0 Offset: 0x44CBF0 VA: 0x18044E5F0 Slot: 7
	protected override float GetStartTicks() { }

	// RVA: 0x43AEF0 Offset: 0x4394F0 VA: 0x18043AEF0
	public float GetDamage() { }

	// RVA: 0x44E4B0 Offset: 0x44CAB0 VA: 0x18044E4B0 Slot: 5
	public override void AddStacks(int numStacks) { }

	// RVA: 0x44E5E0 Offset: 0x44CBE0 VA: 0x18044E5E0 Slot: 8
	public override EDebuff GetDebuffType() { }

	// RVA: 0x44E800 Offset: 0x44CE00 VA: 0x18044E800 Slot: 9
	public override void OnRemove(bool fromDeath) { }

	// RVA: 0x44E600 Offset: 0x44CC00 VA: 0x18044E600 Slot: 10
	public override void OnAdded() { }

	// RVA: 0x44E720 Offset: 0x44CD20 VA: 0x18044E720
	private void OnEnemyDamaged(Enemy e, DamageContainer dc) { }

	// RVA: 0x44E7F0 Offset: 0x44CDF0 VA: 0x18044E7F0 Slot: 11
	public override void OnRefresh() { }

	// RVA: 0x44E9B0 Offset: 0x44CFB0 VA: 0x18044E9B0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
public class DebuffCharm : EnemyDebuff // TypeDefIndex: 5693
{
	// Methods

	// RVA: 0x44EB60 Offset: 0x44D160 VA: 0x18044EB60
	public void .ctor(Enemy enemy, DamageContainer dc, float duration, int stacks) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void MyTick() { }

	// RVA: 0x3655D0 Offset: 0x363BD0 VA: 0x1803655D0 Slot: 7
	protected override float GetStartTicks() { }

	// RVA: 0x44EB30 Offset: 0x44D130 VA: 0x18044EB30 Slot: 8
	public override EDebuff GetDebuffType() { }

	// RVA: 0x44EB40 Offset: 0x44D140 VA: 0x18044EB40 Slot: 9
	public override void OnRemove(bool fromDeath) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	public override void OnAdded() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	public override void OnRefresh() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void AddStacks(int numStacks) { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
public class DebuffFire : EnemyDebuff // TypeDefIndex: 5694
{
	// Fields
	private static string damageSource; // 0x0
	private DamageContainer dc; // 0x20
	private bool canDamage; // 0x28

	// Methods

	// RVA: 0x44F180 Offset: 0x44D780 VA: 0x18044F180
	public void .ctor(Enemy enemy, DamageContainer dc, float duration, int stacks) { }

	// RVA: 0x44EF80 Offset: 0x44D580 VA: 0x18044EF80 Slot: 6
	public override void MyTick() { }

	// RVA: 0x44EEE0 Offset: 0x44D4E0 VA: 0x18044EEE0
	private float GetDamage() { }

	// RVA: 0x44EF70 Offset: 0x44D570 VA: 0x18044EF70 Slot: 7
	protected override float GetStartTicks() { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 8
	public override EDebuff GetDebuffType() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void OnRemove(bool fromDeath) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	public override void OnAdded() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	public override void OnRefresh() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void AddStacks(int numStacks) { }

	// RVA: 0x44F0F0 Offset: 0x44D6F0 VA: 0x18044F0F0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
public class DebuffIce : EnemyDebuff // TypeDefIndex: 5695
{
	// Fields
	public static float slowMultiplier; // 0x0
	public static int numFrozenEnemies; // 0x4

	// Methods

	// RVA: 0x44EB60 Offset: 0x44D160 VA: 0x18044EB60
	public void .ctor(Enemy enemy, DamageContainer dc, float duration, int stacks) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void MyTick() { }

	// RVA: 0x44EF70 Offset: 0x44D570 VA: 0x18044EF70 Slot: 7
	protected override float GetStartTicks() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 8
	public override EDebuff GetDebuffType() { }

	// RVA: 0x44F280 Offset: 0x44D880 VA: 0x18044F280 Slot: 10
	public override void OnAdded() { }

	// RVA: 0x44F300 Offset: 0x44D900 VA: 0x18044F300 Slot: 9
	public override void OnRemove(bool fromDeath) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	public override void OnRefresh() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void AddStacks(int numStacks) { }

	// RVA: 0x44F380 Offset: 0x44D980 VA: 0x18044F380
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
public class DebuffPoison : EnemyDebuff // TypeDefIndex: 5696
{
	// Fields
	public static int numPoisonedEnemies; // 0x0
	private int stacks; // 0x20
	public static string poisonDamageSource; // 0x8

	// Methods

	// RVA: 0x44EB60 Offset: 0x44D160 VA: 0x18044EB60
	public void .ctor(Enemy enemy, DamageContainer dc, float duration, int stacks) { }

	// RVA: 0x44F3D0 Offset: 0x44D9D0 VA: 0x18044F3D0
	public float GetDamageForHpBar() { }

	// RVA: 0x44F450 Offset: 0x44DA50 VA: 0x18044F450 Slot: 6
	public override void MyTick() { }

	// RVA: 0x44F440 Offset: 0x44DA40 VA: 0x18044F440 Slot: 7
	protected override float GetStartTicks() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 8
	public override EDebuff GetDebuffType() { }

	// RVA: 0x44F5C0 Offset: 0x44DBC0 VA: 0x18044F5C0 Slot: 9
	public override void OnRemove(bool fromDeath) { }

	// RVA: 0x44F560 Offset: 0x44DB60 VA: 0x18044F560 Slot: 10
	public override void OnAdded() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	public override void OnRefresh() { }

	// RVA: 0x44F3C0 Offset: 0x44D9C0 VA: 0x18044F3C0 Slot: 5
	public override void AddStacks(int numStacks) { }

	// RVA: 0x44F620 Offset: 0x44DC20 VA: 0x18044F620
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs.Implementations
public class DebuffStun : EnemyDebuff // TypeDefIndex: 5697
{
	// Methods

	// RVA: 0x44EB60 Offset: 0x44D160 VA: 0x18044EB60
	public void .ctor(Enemy enemy, DamageContainer dc, float duration, int stacks) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void MyTick() { }

	// RVA: 0x44E5F0 Offset: 0x44CBF0 VA: 0x18044E5F0 Slot: 7
	protected override float GetStartTicks() { }

	// RVA: 0x44F6B0 Offset: 0x44DCB0 VA: 0x18044F6B0 Slot: 8
	public override EDebuff GetDebuffType() { }

	// RVA: 0x44F6C0 Offset: 0x44DCC0 VA: 0x18044F6C0 Slot: 10
	public override void OnAdded() { }

	// RVA: 0x44F6C0 Offset: 0x44DCC0 VA: 0x18044F6C0 Slot: 9
	public override void OnRemove(bool fromDeath) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	public override void OnRefresh() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void AddStacks(int numStacks) { }
}

