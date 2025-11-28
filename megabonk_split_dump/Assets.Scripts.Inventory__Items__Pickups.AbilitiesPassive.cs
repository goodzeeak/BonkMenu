// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive
public enum EPassive // TypeDefIndex: 5616
{
	// Fields
	public int value__; // 0x0
	public const EPassive Bullseye = 0;
	public const EPassive RngBlessing = 1;
	public const EPassive SpeedDemon = 2;
	public const EPassive Reinforced = 3;
	public const EPassive Flowstate = 4;
	public const EPassive CritHappens = 5;
	public const EPassive Warrior = 6;
	public const EPassive Flex = 7;
	public const EPassive WallClimb = 8;
	public const EPassive None = 9;
	public const EPassive Float = 10;
	public const EPassive Enduring = 11;
	public const EPassive Plague = 12;
	public const EPassive Quantum = 13;
	public const EPassive Shadowstep = 14;
	public const EPassive Gamba = 15;
	public const EPassive Vampire = 16;
	public const EPassive Curse = 17;
	public const EPassive Stonks = 18;
	public const EPassive LockIn = 19;
	public const EPassive Zap = 20;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive
public abstract class PassiveAbility // TypeDefIndex: 5617
{
	// Fields
	public Dictionary<EStat, StatModifiersContainer> statModifiers; // 0x10
	public static Action<EStat> A_StatModified; // 0x0

	// Methods

	// RVA: 0x447380 Offset: 0x445980 VA: 0x180447380
	protected void SetStat(StatModifier statModifier) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Init();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Cleanup();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Tick();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract EPassive GetPassiveType();

	// RVA: 0x447360 Offset: 0x445960 VA: 0x180447360 Slot: 8
	public virtual string GetDescription(LocalizedString localizedString) { }

	// RVA: 0x4474C0 Offset: 0x445AC0 VA: 0x1804474C0
	protected void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive
public static class PassiveAbilityFactory // TypeDefIndex: 5618
{
	// Methods

	// RVA: 0x446D60 Offset: 0x445360 VA: 0x180446D60
	public static PassiveAbility CreatePassiveAbility(PassiveData passive) { }
}

