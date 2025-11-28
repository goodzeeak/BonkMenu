// Namespace: ProGrids
public static class pg_Constant // TypeDefIndex: 5282
{
	// Fields
	public const string ProGridsIsEnabled = "pgProGridsIsEnabled";
	public const string ProGridsIsExtended = "pgProGridsIsExtended";
	public const string ProGridsUpgradeURL = "http://u3d.as/content/six-by-seven-studio/pro-grids/3ov";
	public const string SnapValue = "pgSnapValue";
	public const string SnapMultiplier = "pgSnapMultiplier";
	public const string SnapEnabled = "pgSnapEnabled";
	public const string UseAxisConstraints = "pgUseAxisConstraints";
	public const string LastOrthoToggledRotation = "pgLastOrthoToggledRotation";
	public const string BracketIncreaseValue = "pgBracketIncreaseValue";
	public const string GridUnit = "pg_GridUnit";
	public const string LockGrid = "pg_LockGrid";
	public const string LockedGridPivot = "pg_LockedGridPivot";
	public const string PGVersion = "pg_Version";
	public const string GridAxis = "pg_GridAxis";
	public const string PerspGrid = "pg_PerspGrid";
	public const string SnapScale = "pg_SnapOnScale";
	public const string PredictiveGrid = "pg_PredictiveGrid";
	public const string SnapAsGroup = "pg_SnapAsGroup";
	public const string MajorLineIncrement = "pg_MajorLineIncrement";
	public const string SyncUnitySnap = "pg_SyncUnitySnap";
	public const float METER = 1;
	public const float CENTIMETER = 0.01;
	public const float MILLIMETER = 0.001;
	public const float INCH = 0.025399987;
	public const float FOOT = 0.3048;
	public const float YARD = 1.09361;
	public const float PARSEC = 5;
}

// Namespace: ProGrids
public enum Axis // TypeDefIndex: 5283
{
	// Fields
	public int value__; // 0x0
	public const Axis None = 0;
	public const Axis X = 1;
	public const Axis Y = 2;
	public const Axis Z = 4;
	public const Axis NegX = 8;
	public const Axis NegY = 22;
	public const Axis NegZ = 50;
}

// Namespace: ProGrids
public enum SnapUnit // TypeDefIndex: 5284
{
	// Fields
	public int value__; // 0x0
	public const SnapUnit Meter = 0;
	public const SnapUnit Centimeter = 1;
	public const SnapUnit Millimeter = 2;
	public const SnapUnit Inch = 3;
	public const SnapUnit Foot = 4;
	public const SnapUnit Yard = 5;
	public const SnapUnit Parsec = 6;
}

// Namespace: ProGrids
public static class pg_Enum // TypeDefIndex: 5285
{
	// Methods

	// RVA: 0x3B0BF0 Offset: 0x3AF1F0 VA: 0x1803B0BF0
	public static Vector3 InverseAxisMask(Vector3 v, Axis axis) { }

	// RVA: 0x3B0B10 Offset: 0x3AF110 VA: 0x1803B0B10
	public static Vector3 AxisMask(Vector3 v, Axis axis) { }

	// RVA: 0x3B0CC0 Offset: 0x3AF2C0 VA: 0x1803B0CC0
	public static float SnapUnitValue(SnapUnit su) { }
}

// Namespace: ProGrids
[Usage(4, AllowMultiple = False, Inherited = True)]
public class ProGridsNoSnapAttribute : Attribute // TypeDefIndex: 5286
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: ProGrids
[Usage(4, AllowMultiple = False, Inherited = True)]
public class ProGridsConditionalSnapAttribute : Attribute // TypeDefIndex: 5287
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: ProGrids
public static class pg_Util // TypeDefIndex: 5295
{
	// Fields
	private const float EPSILON = 0.0001;
	private static Dictionary<Transform, pg_Util.SnapEnabledOverride> m_SnapOverrideCache; // 0x0
	private static Dictionary<Type, bool> m_NoSnapAttributeTypeCache; // 0x8
	private static Dictionary<Type, MethodInfo> m_ConditionalSnapAttributeCache; // 0x10

	// Methods

	// RVA: 0x3B1490 Offset: 0x3AFA90 VA: 0x1803B1490
	public static Color ColorWithString(string value) { }

	// RVA: 0x3B2C00 Offset: 0x3B1200 VA: 0x1803B2C00
	private static Vector3 VectorToMask(Vector3 vec) { }

	// RVA: 0x3B1AD0 Offset: 0x3B00D0 VA: 0x1803B1AD0
	private static Axis MaskToAxis(Vector3 vec) { }

	// RVA: 0x3B0D40 Offset: 0x3AF340 VA: 0x1803B0D40
	private static Axis BestAxis(Vector3 vec) { }

	// RVA: 0x3B0D90 Offset: 0x3AF390 VA: 0x1803B0D90
	public static Axis CalcDragAxis(Vector3 movement, Camera cam) { }

	// RVA: 0x3B2BC0 Offset: 0x3B11C0 VA: 0x1803B2BC0
	public static float ValueFromMask(Vector3 val, Vector3 mask) { }

	// RVA: 0x3B2A00 Offset: 0x3B1000 VA: 0x1803B2A00
	public static Vector3 SnapValue(Vector3 val, float snapValue) { }

	// RVA: 0x3B1690 Offset: 0x3AFC90 VA: 0x1803B1690
	private static Type GetType(string type, string assembly) { }

	// RVA: 0x3B1B20 Offset: 0x3B0120 VA: 0x1803B1B20
	public static void SetUnityGridEnabled(bool isEnabled) { }

	// RVA: 0x3B19E0 Offset: 0x3AFFE0 VA: 0x1803B19E0
	public static bool GetUnityGridEnabled() { }

	// RVA: 0x3B28A0 Offset: 0x3B0EA0 VA: 0x1803B28A0
	public static Vector3 SnapValue(Vector3 val, Vector3 mask, float snapValue) { }

	// RVA: 0x3B24E0 Offset: 0x3B0AE0 VA: 0x1803B24E0
	public static Vector3 SnapToCeil(Vector3 val, Vector3 mask, float snapValue) { }

	// RVA: 0x3B2670 Offset: 0x3B0C70 VA: 0x1803B2670
	public static Vector3 SnapToFloor(Vector3 val, float snapValue) { }

	// RVA: 0x3B2740 Offset: 0x3B0D40 VA: 0x1803B2740
	public static Vector3 SnapToFloor(Vector3 val, Vector3 mask, float snapValue) { }

	// RVA: 0x3B2AC0 Offset: 0x3B10C0 VA: 0x1803B2AC0
	public static float Snap(float val, float round) { }

	// RVA: 0x3B2640 Offset: 0x3B0C40 VA: 0x1803B2640
	public static float SnapToFloor(float val, float snapValue) { }

	// RVA: 0x3B24B0 Offset: 0x3B0AB0 VA: 0x1803B24B0
	public static float SnapToCeil(float val, float snapValue) { }

	// RVA: 0x3B13B0 Offset: 0x3AF9B0 VA: 0x1803B13B0
	public static Vector3 CeilFloor(Vector3 v) { }

	// RVA: 0x3B1420 Offset: 0x3AFA20 VA: 0x1803B1420
	public static void ClearSnapEnabledCache() { }

	// RVA: 0x3B1C20 Offset: 0x3B0220 VA: 0x1803B1C20
	public static bool SnapIsEnabled(Transform t) { }

	// RVA: 0x3B2CA0 Offset: 0x3B12A0 VA: 0x1803B2CA0
	private static void .cctor() { }
}

// Namespace: ProGrids
[Extension]
public static class PGExtensions // TypeDefIndex: 5296
{
	// Methods

	[Extension]
	// RVA: 0x3C5AD0 Offset: 0x3C40D0 VA: 0x1803C5AD0
	public static bool Contains(Transform[] t_arr, Transform t) { }

	[Extension]
	// RVA: 0x3C5C10 Offset: 0x3C4210 VA: 0x1803C5C10
	public static float Sum(Vector3 v) { }

	[Extension]
	// RVA: 0x3C5B80 Offset: 0x3C4180 VA: 0x1803C5B80
	public static bool InFrustum(Camera cam, Vector3 point) { }
}

