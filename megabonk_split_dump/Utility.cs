// Namespace: Utility
public class MyRandom // TypeDefIndex: 5305
{
	// Fields
	public static Random random; // 0x0

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x3C3B00 Offset: 0x3C2100 VA: 0x1803C3B00
	private static void .cctor() { }
}

// Namespace: Utility
public class RaycastUtility // TypeDefIndex: 5307
{
	// Fields
	private static Collider[] coneCastBuffer; // 0x0

	// Methods

	// RVA: 0x3C9C50 Offset: 0x3C8250 VA: 0x1803C9C50
	public static Vector3 RayToGround(Vector3 pos, float maxDistance = 9999) { }

	// RVA: 0x3C9A60 Offset: 0x3C8060 VA: 0x1803C9A60
	public static Vector3 RayToGround(Vector3 pos, LayerMask layerMask, float maxDistance = 9999) { }

	// RVA: 0x3C8BA0 Offset: 0x3C71A0 VA: 0x1803C8BA0
	public static List<Collider> ConeCastAll(Vector3 origin, Vector3 direction, float maxDistance, float coneAngle) { }

	// RVA: 0x3C9300 Offset: 0x3C7900 VA: 0x1803C9300
	public static HashSet<Collider> ConeCastNew(Vector3 origin, Vector3 direction, float distance, float coneAngle) { }

	// RVA: 0x3C9650 Offset: 0x3C7C50 VA: 0x1803C9650
	public static List<RaycastUtility.ConeSphere> GetConecastPositions(Vector3 pos, Vector3 dir, float dist, float coneAngle) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x3C9E90 Offset: 0x3C8490 VA: 0x1803C9E90
	private static void .cctor() { }
}

