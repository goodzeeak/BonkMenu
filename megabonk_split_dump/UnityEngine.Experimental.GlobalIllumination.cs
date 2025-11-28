// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum LightType // TypeDefIndex: 10143
{
	// Fields
	public byte value__; // 0x0
	public const LightType Directional = 0;
	public const LightType Point = 1;
	public const LightType Spot = 2;
	public const LightType Rectangle = 3;
	public const LightType Disc = 4;
	public const LightType SpotPyramidShape = 5;
	public const LightType SpotBoxShape = 6;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum LightMode // TypeDefIndex: 10144
{
	// Fields
	public byte value__; // 0x0
	public const LightMode Realtime = 0;
	public const LightMode Mixed = 1;
	public const LightMode Baked = 2;
	public const LightMode Unknown = 3;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum FalloffType // TypeDefIndex: 10145
{
	// Fields
	public byte value__; // 0x0
	public const FalloffType InverseSquared = 0;
	public const FalloffType InverseSquaredNoRangeAttenuation = 1;
	public const FalloffType Linear = 2;
	public const FalloffType Legacy = 3;
	public const FalloffType Undefined = 4;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum AngularFalloffType // TypeDefIndex: 10146
{
	// Fields
	public byte value__; // 0x0
	public const AngularFalloffType LUT = 0;
	public const AngularFalloffType AnalyticAndInnerAngle = 1;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct LinearColor // TypeDefIndex: 10147
{
	// Fields
	private float m_red; // 0x0
	private float m_green; // 0x4
	private float m_blue; // 0x8
	private float m_intensity; // 0xC

	// Properties
	public float red { get; set; }
	public float green { get; set; }
	public float blue { get; set; }

	// Methods

	// RVA: 0x2300000 Offset: 0x22FE600 VA: 0x182300000
	public float get_red() { }

	// RVA: 0x2357980 Offset: 0x2355F80 VA: 0x182357980
	public void set_red(float value) { }

	// RVA: 0x2300010 Offset: 0x22FE610 VA: 0x182300010
	public float get_green() { }

	// RVA: 0x23578C0 Offset: 0x2355EC0 VA: 0x1823578C0
	public void set_green(float value) { }

	// RVA: 0x22FFFF0 Offset: 0x22FE5F0 VA: 0x1822FFFF0
	public float get_blue() { }

	// RVA: 0x2357800 Offset: 0x2355E00 VA: 0x182357800
	public void set_blue(float value) { }

	// RVA: 0x23574A0 Offset: 0x2355AA0 VA: 0x1823574A0
	public static LinearColor Convert(Color color, float intensity) { }

	// RVA: 0x2357470 Offset: 0x2355A70 VA: 0x182357470
	public static LinearColor Black() { }
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DirectionalLight // TypeDefIndex: 10148
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float penumbraWidthRadian; // 0x44
	[Obsolete("Directional lights support cookies now. In order to position the cookie projection in the world, a position and full orientation are necessary. Use the position and orientation members instead of the direction parameter.", True)]
	public Vector3 direction; // 0x48
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct PointLight // TypeDefIndex: 10149
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float sphereRadius; // 0x48
	public FalloffType falloff; // 0x4C
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct SpotLight // TypeDefIndex: 10150
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float sphereRadius; // 0x48
	public float coneAngle; // 0x4C
	public float innerConeAngle; // 0x50
	public FalloffType falloff; // 0x54
	public AngularFalloffType angularFalloff; // 0x55
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct RectangleLight // TypeDefIndex: 10151
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float width; // 0x48
	public float height; // 0x4C
	public FalloffType falloff; // 0x50
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DiscLight // TypeDefIndex: 10152
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float radius; // 0x48
	public FalloffType falloff; // 0x4C
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct Cookie // TypeDefIndex: 10153
{
	// Fields
	public int instanceID; // 0x0
	public float scale; // 0x4
	public Vector2 sizes; // 0x8
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
[UsedByNativeCode]
public struct LightDataGI // TypeDefIndex: 10154
{
	// Fields
	public int instanceID; // 0x0
	public int cookieID; // 0x4
	public float cookieScale; // 0x8
	public LinearColor color; // 0xC
	public LinearColor indirectColor; // 0x1C
	public Quaternion orientation; // 0x2C
	public Vector3 position; // 0x3C
	public float range; // 0x48
	public float coneAngle; // 0x4C
	public float innerConeAngle; // 0x50
	public float shape0; // 0x54
	public float shape1; // 0x58
	public LightType type; // 0x5C
	public LightMode mode; // 0x5D
	public byte shadow; // 0x5E
	public FalloffType falloff; // 0x5F

	// Methods

	// RVA: 0x2355750 Offset: 0x2353D50 VA: 0x182355750
	public void Init(ref DirectionalLight light, ref Cookie cookie) { }

	// RVA: 0x23557D0 Offset: 0x2353DD0 VA: 0x1823557D0
	public void Init(ref PointLight light, ref Cookie cookie) { }

	// RVA: 0x23556D0 Offset: 0x2353CD0 VA: 0x1823556D0
	public void Init(ref SpotLight light, ref Cookie cookie) { }

	// RVA: 0x23558B0 Offset: 0x2353EB0 VA: 0x1823558B0
	public void Init(ref RectangleLight light, ref Cookie cookie) { }

	// RVA: 0x2355840 Offset: 0x2353E40 VA: 0x182355840
	public void Init(ref DiscLight light, ref Cookie cookie) { }

	// RVA: 0x23556C0 Offset: 0x2353CC0 VA: 0x1823556C0
	public void InitNoBake(int lightInstanceID) { }
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class LightmapperUtils // TypeDefIndex: 10155
{
	// Methods

	// RVA: 0x2356710 Offset: 0x2354D10 VA: 0x182356710
	public static LightMode Extract(LightmapBakeType baketype) { }

	// RVA: 0x2355A50 Offset: 0x2354050 VA: 0x182355A50
	public static LinearColor ExtractIndirect(Light l) { }

	// RVA: 0x2355AE0 Offset: 0x23540E0 VA: 0x182355AE0
	public static float ExtractInnerCone(Light l) { }

	// RVA: 0x2355980 Offset: 0x2353F80 VA: 0x182355980
	private static Color ExtractColorTemperature(Light l) { }

	// RVA: 0x2355920 Offset: 0x2353F20 VA: 0x182355920
	private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor) { }

	// RVA: 0x2355F30 Offset: 0x2354530 VA: 0x182355F30
	public static void Extract(Light l, ref DirectionalLight dir) { }

	// RVA: 0x2356310 Offset: 0x2354910 VA: 0x182356310
	public static void Extract(Light l, ref PointLight point) { }

	// RVA: 0x2356730 Offset: 0x2354D30 VA: 0x182356730
	public static void Extract(Light l, ref SpotLight spot) { }

	// RVA: 0x2355B30 Offset: 0x2354130 VA: 0x182355B30
	public static void Extract(Light l, ref RectangleLight rect) { }

	// RVA: 0x2356B80 Offset: 0x2355180 VA: 0x182356B80
	public static void Extract(Light l, ref DiscLight disc) { }

	// RVA: 0x2356F80 Offset: 0x2355580 VA: 0x182356F80
	public static void Extract(Light l, out Cookie cookie) { }
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class Lightmapping // TypeDefIndex: 10158
{
	// Fields
	[RequiredByNativeCode]
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCode]
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2357250 Offset: 0x2355850 VA: 0x182357250
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCode]
	// RVA: 0x23570C0 Offset: 0x23556C0 VA: 0x1823570C0
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCode]
	// RVA: 0x23571E0 Offset: 0x23557E0 VA: 0x1823571E0
	public static void ResetDelegate() { }

	[RequiredByNativeCode]
	// RVA: 0x2357110 Offset: 0x2355710 VA: 0x182357110
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x23572E0 Offset: 0x23558E0 VA: 0x1823572E0
	private static void .cctor() { }
}

