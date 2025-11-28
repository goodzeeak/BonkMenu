// Namespace: Assets.Scripts.Inventory__Items__Pickups.Pickups
public enum EPickup // TypeDefIndex: 5515
{
	// Fields
	public int value__; // 0x0
	public const EPickup Xp = 0;
	public const EPickup Gold = 1;
	public const EPickup Health = 2;
	public const EPickup Nuke = 3;
	public const EPickup Time = 4;
	public const EPickup Shield = 5;
	public const EPickup Rage = 6;
	public const EPickup Haste = 7;
	public const EPickup Stonks = 8;
	public const EPickup Magnet = 9;
	public const EPickup Silver = 10;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Pickups
public class PickupStackableList // TypeDefIndex: 5516
{
	// Fields
	private int maxObjects; // 0x10
	private EPickup ePickup; // 0x14
	public LinkedList<Pickup> pickupsList; // 0x18

	// Methods

	// RVA: 0x419410 Offset: 0x417A10 VA: 0x180419410
	public void .ctor(int nMax, EPickup ePickup) { }

	// RVA: 0x419050 Offset: 0x417650 VA: 0x180419050
	public Pickup AddPickup(Vector3 pos) { }

	// RVA: 0x419280 Offset: 0x417880 VA: 0x180419280
	private void CombineOldestObjects() { }

	// RVA: 0x4193B0 Offset: 0x4179B0 VA: 0x1804193B0
	public void RemovePickup(Pickup pickup) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Pickups
public class PowerupConstants // TypeDefIndex: 5517
{
	// Methods

	// RVA: 0x41E310 Offset: 0x41C910 VA: 0x18041E310
	public static float GetTime(EStatusEffect statusEffect) { }

	// RVA: 0x41E220 Offset: 0x41C820 VA: 0x18041E220
	public static float GetExplosionRadius() { }

	// RVA: 0x41E280 Offset: 0x41C880 VA: 0x18041E280
	public static float GetHasteTime() { }

	// RVA: 0x41E260 Offset: 0x41C860 VA: 0x18041E260
	public static float GetHasteMultiplier() { }

	// RVA: 0x41E2F0 Offset: 0x41C8F0 VA: 0x18041E2F0
	public static float GetRageTime() { }

	// RVA: 0x41E2D0 Offset: 0x41C8D0 VA: 0x18041E2D0
	public static float GetRageDamageMultiplier() { }

	// RVA: 0x41E2B0 Offset: 0x41C8B0 VA: 0x18041E2B0
	public static float GetRageCooldownMultiplier() { }

	// RVA: 0x41E2F0 Offset: 0x41C8F0 VA: 0x18041E2F0
	public static float GetShieldTime() { }

	// RVA: 0x41E2F0 Offset: 0x41C8F0 VA: 0x18041E2F0
	public static float GetStonksTime() { }

	// RVA: 0x41E2B0 Offset: 0x41C8B0 VA: 0x18041E2B0
	public static float GetStonksMultiplier() { }

	// RVA: 0x41E240 Offset: 0x41C840 VA: 0x18041E240
	public static float GetFreezeTime() { }

	// RVA: 0x41E2A0 Offset: 0x41C8A0 VA: 0x18041E2A0
	private static float GetMultiplier() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

