// Namespace: Inventory__Items__Pickups
public class XpUtility // TypeDefIndex: 5310
{
	// Fields
	public static float eliteEnemyXpMultiplier; // 0x0
	private static int baseXp; // 0x4
	private static float increaseRate; // 0x8
	private static float exponent; // 0xC
	public const int maxLevel = 9999;
	public static int[] xpForLevelsTable; // 0x10

	// Methods

	// RVA: 0x3D0330 Offset: 0x3CE930 VA: 0x1803D0330
	public static void Init() { }

	// RVA: 0x3D05B0 Offset: 0x3CEBB0 VA: 0x1803D05B0
	public static int XpToLevel(int xp) { }

	// RVA: 0x3D06C0 Offset: 0x3CECC0 VA: 0x1803D06C0
	public static int XpToNextLevel(int currentXp) { }

	// RVA: 0x3D0550 Offset: 0x3CEB50 VA: 0x1803D0550
	public static int XpOnCurrentLevel(int currentXp) { }

	// RVA: 0x3D0650 Offset: 0x3CEC50 VA: 0x1803D0650
	public static int XpToNextLevelTotal(int currentXp) { }

	// RVA: 0x3D0220 Offset: 0x3CE820 VA: 0x1803D0220
	public static float CurrentLevelProgress(int currentXp) { }

	// RVA: 0x3D04C0 Offset: 0x3CEAC0 VA: 0x1803D04C0
	public static int LevelToXp(int lvl) { }

	// RVA: 0x3D07B0 Offset: 0x3CEDB0 VA: 0x1803D07B0
	public static int XpTotalCurrentLevel(int xp) { }

	// RVA: 0x3D0800 Offset: 0x3CEE00 VA: 0x1803D0800
	public static int XpTotalNextLevel(int xp) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x3D0860 Offset: 0x3CEE60 VA: 0x1803D0860
	private static void .cctor() { }
}

