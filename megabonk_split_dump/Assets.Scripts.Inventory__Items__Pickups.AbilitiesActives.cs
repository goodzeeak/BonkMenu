// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesActives
public abstract class ActiveAbility // TypeDefIndex: 5641
{
	// Fields
	protected float readyAtTime; // 0x10

	// Methods

	// RVA: 0x448120 Offset: 0x446720 VA: 0x180448120
	public void Use() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Tick();

	// RVA: 0x4480C0 Offset: 0x4466C0 VA: 0x1804480C0
	private bool IsReady() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Init();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Cleanup();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void UseImplementation();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float GetCooldown();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesActives
public static class ActiveAbilityFactory // TypeDefIndex: 5642
{
	// Methods

	// RVA: 0x448060 Offset: 0x446660 VA: 0x180448060
	public static ActiveAbility CreateAbility(EAbiltiyActive ability) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.AbilitiesActives
public enum EAbiltiyActive // TypeDefIndex: 5643
{
	// Fields
	public int value__; // 0x0
	public const EAbiltiyActive Dash = 0;
}

