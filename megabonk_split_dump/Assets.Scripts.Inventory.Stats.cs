// Namespace: Assets.Scripts.Inventory.Stats
public static class EnemyStats // TypeDefIndex: 5466
{
	// Fields
	private static float maxSpeedMultiplier; // 0x0

	// Methods

	// RVA: 0x3F4BB0 Offset: 0x3F31B0 VA: 0x1803F4BB0
	public static float GetHp(Enemy enemy) { }

	// RVA: 0x3F4F30 Offset: 0x3F3530 VA: 0x1803F4F30
	public static float GetSpeed(EnemyData enemyData) { }

	// RVA: 0x3F49F0 Offset: 0x3F2FF0 VA: 0x1803F49F0
	public static float GetDamage(Enemy enemy) { }

	// RVA: 0x3F4B70 Offset: 0x3F3170 VA: 0x1803F4B70
	public static float GetEliteChance(EnemyData enemyData) { }

	// RVA: 0x3F4E30 Offset: 0x3F3430 VA: 0x1803F4E30
	public static float GetKnockbackResistance(Enemy enemy) { }

	// RVA: 0x3F50C0 Offset: 0x3F36C0 VA: 0x1803F50C0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory.Stats
public static class PlayerStats // TypeDefIndex: 5467
{
	// Methods

	// RVA: 0x403290 Offset: 0x401890 VA: 0x180403290
	public static float GetStat(EStat stat) { }

	// RVA: 0x403150 Offset: 0x401750 VA: 0x180403150
	public static float GetStatRaw(EStat stat) { }

	// RVA: 0x402FF0 Offset: 0x4015F0 VA: 0x180402FF0
	public static StatComponents GetStatComponents(EStat stat) { }

	// RVA: 0x4033D0 Offset: 0x4019D0 VA: 0x1804033D0
	public static bool HasStats() { }
}

