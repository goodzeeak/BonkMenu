// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs
public struct AddDebuffContainer // TypeDefIndex: 5686
{
	// Fields
	public EDebuff eDebuff; // 0x0
	public DamageContainer dc; // 0x8
	public float duration; // 0x10
	public int stacks; // 0x14

	// Methods

	// RVA: 0x448200 Offset: 0x446800 VA: 0x180448200
	public void .ctor(EDebuff eDebuff, DamageContainer dc, float duration, int stacks = 1) { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs
public static class DebuffFactory // TypeDefIndex: 5687
{
	// Methods

	// RVA: 0x44EBA0 Offset: 0x44D1A0 VA: 0x18044EBA0
	public static EnemyDebuff CreateDebuff(EDebuff eDebuff, Enemy enemy, DamageContainer dc, float duration, int stacks = 1) { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs
public class DebuffUtility // TypeDefIndex: 5688
{
	// Fields
	public static readonly int debuffTicksPerSecond; // 0x0
	public static readonly float debuffCooldownSeconds; // 0x4

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x44F6F0 Offset: 0x44DCF0 VA: 0x18044F6F0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs
[Flags]
public enum EDebuff // TypeDefIndex: 5689
{
	// Fields
	public int value__; // 0x0
	public const EDebuff Poison = 1;
	public const EDebuff Freeze = 2;
	public const EDebuff Burn = 4;
	public const EDebuff Stun = 8;
	public const EDebuff Echo = 16;
	public const EDebuff Charm = 32;
	public const EDebuff Bloodmark = 64;
	public const EDebuff DebuffsWithCap = 42;
}

// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs
public abstract class EnemyDebuff // TypeDefIndex: 5690
{
	// Fields
	protected int ticksLeft; // 0x10
	protected Enemy enemy; // 0x18

	// Methods

	// RVA: 0x44FD20 Offset: 0x44E320 VA: 0x18044FD20
	public void .ctor(Enemy enemy, DamageContainer dc, float duration, int stacks = 1) { }

	// RVA: 0x44FCF0 Offset: 0x44E2F0 VA: 0x18044FCF0 Slot: 4
	public virtual void Tick() { }

	// RVA: 0x400B30 Offset: 0x3FF130 VA: 0x180400B30
	public bool IsDone() { }

	// RVA: 0x44FC80 Offset: 0x44E280 VA: 0x18044FC80
	public void Refresh(float duration, int stacks) { }

	// RVA: 0x44FBE0 Offset: 0x44E1E0 VA: 0x18044FBE0
	private int GetTicks(float duration) { }

	// RVA: 0x44FC60 Offset: 0x44E260 VA: 0x18044FC60
	private void RefreshTimeout(float duration) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddStacks(int numStacks);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void MyTick();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract float GetStartTicks();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract EDebuff GetDebuffType();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnRemove(bool fromDeath);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnAdded();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnRefresh();
}

// Namespace: Assets.Scripts.Game.Combat.EnemyDebuffs
public class DebuffEcho : EnemyDebuff // TypeDefIndex: 5691
{
	// Methods

	// RVA: 0x44EB60 Offset: 0x44D160 VA: 0x18044EB60
	public void .ctor(Enemy enemy, DamageContainer dc, float duration, int stacks) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void MyTick() { }

	// RVA: 0x3655D0 Offset: 0x363BD0 VA: 0x1803655D0 Slot: 7
	protected override float GetStartTicks() { }

	// RVA: 0x44EB70 Offset: 0x44D170 VA: 0x18044EB70 Slot: 8
	public override EDebuff GetDebuffType() { }

	// RVA: 0x44EB80 Offset: 0x44D180 VA: 0x18044EB80 Slot: 9
	public override void OnRemove(bool fromDeath) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	public override void OnAdded() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	public override void OnRefresh() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public override void AddStacks(int numStacks) { }
}

