// Namespace: Unity.Mathematics.Geometry
[Il2CppEagerStaticClassConstruction]
[Serializable]
internal struct MinMaxAABB : IEquatable<MinMaxAABB> // TypeDefIndex: 8106
{
	// Fields
	public float3 Min; // 0x0
	public float3 Max; // 0xC

	// Properties
	public float3 Extents { get; }
	public float3 HalfExtents { get; }
	public float3 Center { get; }
	public bool IsValid { get; }
	public float SurfaceArea { get; }

	// Methods

	// RVA: 0xB1EA30 Offset: 0xB1D030 VA: 0x180B1EA30
	public void .ctor(float3 min, float3 max) { }

	// RVA: 0x1F8F420 Offset: 0x1F8DA20 VA: 0x181F8F420
	public static MinMaxAABB CreateFromCenterAndExtents(float3 center, float3 extents) { }

	// RVA: 0x1F8F500 Offset: 0x1F8DB00 VA: 0x181F8F500
	public static MinMaxAABB CreateFromCenterAndHalfExtents(float3 center, float3 halfExtents) { }

	// RVA: 0x1F8FA30 Offset: 0x1F8E030 VA: 0x181F8FA30
	public float3 get_Extents() { }

	// RVA: 0x1F8FA80 Offset: 0x1F8E080 VA: 0x181F8FA80
	public float3 get_HalfExtents() { }

	// RVA: 0x1F8F9D0 Offset: 0x1F8DFD0 VA: 0x181F8F9D0
	public float3 get_Center() { }

	// RVA: 0x1F8FAE0 Offset: 0x1F8E0E0 VA: 0x181F8FAE0
	public bool get_IsValid() { }

	// RVA: 0x1F8FB30 Offset: 0x1F8E130 VA: 0x181F8FB30
	public float get_SurfaceArea() { }

	// RVA: 0x1F8F310 Offset: 0x1F8D910 VA: 0x181F8F310
	public bool Contains(float3 point) { }

	// RVA: 0x1F8F3A0 Offset: 0x1F8D9A0 VA: 0x181F8F3A0
	public bool Contains(MinMaxAABB aabb) { }

	// RVA: 0x1F8F8B0 Offset: 0x1F8DEB0 VA: 0x181F8F8B0
	public bool Overlaps(MinMaxAABB aabb) { }

	// RVA: 0x1F8F850 Offset: 0x1F8DE50 VA: 0x181F8F850
	public void Expand(float signedDistance) { }

	// RVA: 0x1F8F590 Offset: 0x1F8DB90 VA: 0x181F8F590
	public void Encapsulate(MinMaxAABB aabb) { }

	// RVA: 0x1F8F6B0 Offset: 0x1F8DCB0 VA: 0x181F8F6B0
	public void Encapsulate(float3 point) { }

	// RVA: 0x1F8F7D0 Offset: 0x1F8DDD0 VA: 0x181F8F7D0 Slot: 4
	public bool Equals(MinMaxAABB other) { }

	// RVA: 0x1F8F930 Offset: 0x1F8DF30 VA: 0x181F8F930 Slot: 3
	public override string ToString() { }
}

// Namespace: Unity.Mathematics.Geometry
internal static class Math // TypeDefIndex: 8107
{
	// Methods

	// RVA: 0x1F8ED40 Offset: 0x1F8D340 VA: 0x181F8ED40
	public static MinMaxAABB Transform(RigidTransform transform, MinMaxAABB aabb) { }

	// RVA: 0x1F8EBF0 Offset: 0x1F8D1F0 VA: 0x181F8EBF0
	public static MinMaxAABB Transform(float4x4 transform, MinMaxAABB aabb) { }

	// RVA: 0x1F8E730 Offset: 0x1F8CD30 VA: 0x181F8E730
	public static MinMaxAABB Transform(float3x3 transform, MinMaxAABB aabb) { }
}

// Namespace: Unity.Mathematics.Geometry
[DebuggerDisplay("{Normal}, {Distance}")]
[Il2CppEagerStaticClassConstruction]
[Serializable]
internal struct Plane // TypeDefIndex: 8108
{
	// Fields
	public float4 NormalAndDistance; // 0x0

	// Properties
	public float3 Normal { get; set; }
	public float Distance { get; set; }
	public Plane Flipped { get; }

	// Methods

	// RVA: 0x1F90060 Offset: 0x1F8E660 VA: 0x181F90060
	public void .ctor(float coefficientA, float coefficientB, float coefficientC, float coefficientD) { }

	// RVA: 0x1F8EB30 Offset: 0x1F8D130 VA: 0x181F8EB30
	public void .ctor(float3 normal, float distance) { }

	// RVA: 0x1F8EA30 Offset: 0x1F8D030 VA: 0x181F8EA30
	public void .ctor(float3 normal, float3 pointInPlane) { }

	// RVA: 0x1F8FF30 Offset: 0x1F8E530 VA: 0x181F8FF30
	public void .ctor(float3 vector1InPlane, float3 vector2InPlane, float3 pointInPlane) { }

	// RVA: 0x1F8FC20 Offset: 0x1F8E220 VA: 0x181F8FC20
	public static Plane CreateFromUnitNormalAndDistance(float3 unitNormal, float distance) { }

	// RVA: 0x1F8FC60 Offset: 0x1F8E260 VA: 0x181F8FC60
	public static Plane CreateFromUnitNormalAndPointInPlane(float3 unitNormal, float3 pointInPlane) { }

	// RVA: 0x1814190 Offset: 0x1812790 VA: 0x181814190
	public float3 get_Normal() { }

	// RVA: 0x1F90160 Offset: 0x1F8E760 VA: 0x181F90160
	public void set_Normal(float3 value) { }

	// RVA: 0x19477A0 Offset: 0x1945DA0 VA: 0x1819477A0
	public float get_Distance() { }

	// RVA: 0x1947A90 Offset: 0x1946090 VA: 0x181947A90
	public void set_Distance(float value) { }

	// RVA: 0x1F8FCE0 Offset: 0x1F8E2E0 VA: 0x181F8FCE0
	public static Plane Normalize(Plane plane) { }

	// RVA: 0x1F8FDA0 Offset: 0x1F8E3A0 VA: 0x181F8FDA0
	public static float4 Normalize(float4 planeCoefficients) { }

	// RVA: 0x1F8FEE0 Offset: 0x1F8E4E0 VA: 0x181F8FEE0
	public float SignedDistanceToPoint(float3 point) { }

	// RVA: 0x1F8FE40 Offset: 0x1F8E440 VA: 0x181F8FE40
	public float3 Projection(float3 point) { }

	// RVA: 0x1F90100 Offset: 0x1F8E700 VA: 0x181F90100
	public Plane get_Flipped() { }

	// RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	public static float4 op_Implicit(Plane plane) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x1F8FB80 Offset: 0x1F8E180 VA: 0x181F8FB80
	private void CheckPlaneIsNormalized() { }
}

