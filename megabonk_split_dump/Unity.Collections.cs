// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(10496)]
public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 9451
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(10496)]
public sealed class WriteOnlyAttribute : Attribute // TypeDefIndex: 9452
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(256)]
public sealed class DeallocateOnJobCompletionAttribute : Attribute // TypeDefIndex: 9453
{}

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeFixedLengthAttribute : Attribute // TypeDefIndex: 9454
{}

// Namespace: Unity.Collections
[Usage(256)]
[RequiredByNativeCode]
public sealed class NativeMatchesParallelForLengthAttribute : Attribute // TypeDefIndex: 9455
{}

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeDisableParallelForRestrictionAttribute : Attribute // TypeDefIndex: 9456
{}

// Namespace: Unity.Collections
[UsedByNativeCode]
public enum Allocator // TypeDefIndex: 9457
{
	// Fields
	public int value__; // 0x0
	public const Allocator Invalid = 0;
	public const Allocator None = 1;
	public const Allocator Temp = 2;
	public const Allocator TempJob = 3;
	public const Allocator Persistent = 4;
	public const Allocator AudioKernel = 5;
	public const Allocator Domain = 6;
	public const Allocator FirstUserIndex = 64;
}

// Namespace: Unity.Collections
[VisibleToOtherModules(new[] { "UnityEngine.AIModule" })]
[UsedByNativeCode]
internal enum LeakCategory // TypeDefIndex: 9458
{
	// Fields
	public int value__; // 0x0
	public const LeakCategory Invalid = 0;
	public const LeakCategory Malloc = 1;
	public const LeakCategory TempJob = 2;
	public const LeakCategory Persistent = 3;
	public const LeakCategory LightProbesQuery = 4;
	public const LeakCategory NativeTest = 5;
	public const LeakCategory MeshDataArray = 6;
	public const LeakCategory TransformAccessArray = 7;
	public const LeakCategory NavMeshQuery = 8;
}

// Namespace: Unity.Collections
public enum NativeArrayOptions // TypeDefIndex: 9459
{
	// Fields
	public int value__; // 0x0
	public const NativeArrayOptions UninitializedMemory = 0;
	public const NativeArrayOptions ClearMemory = 1;
}

// Namespace: Unity.Collections
[DebuggerTypeProxy(typeof(NativeArrayDebugView<T>))]
[DebuggerDisplay("Length = {m_Length}")]
[NativeContainerSupportsDeferredConvertListToArray]
[NativeContainerSupportsDeallocateOnJobCompletion]
[NativeContainerSupportsMinMaxWriteRestriction]
[NativeContainer]
[DefaultMember("Item")]
public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> // TypeDefIndex: 9463
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	[VisibleToOtherModules(new[] { "UnityEngine.ContentLoadModule", "UnityEngine.TilemapModule" })]
	internal void* m_Buffer; // 0x0
	internal int m_Length; // 0x0
	internal Allocator m_AllocatorLabel; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, Allocator allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129F5A0 Offset: 0x129DBA0 VA: 0x18129F5A0
	|-NativeArray<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x129FC10 Offset: 0x129E210 VA: 0x18129FC10
	|-NativeArray<BezierCurve>..ctor
	|
	|-RVA: 0x12A0030 Offset: 0x129E630 VA: 0x1812A0030
	|-NativeArray<BezierKnot>..ctor
	|
	|-RVA: 0x129FA00 Offset: 0x129E000 VA: 0x18129FA00
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x129EE30 Offset: 0x129D430 VA: 0x18129EE30
	|-NativeArray<Color>..ctor
	|-NativeArray<DrawBufferRange>..ctor
	|-NativeArray<Plane>..ctor
	|-NativeArray<Quaternion>..ctor
	|
	|-RVA: 0x129F7E0 Offset: 0x129DDE0 VA: 0x18129F7E0
	|-NativeArray<ContactPairHeader>..ctor
	|
	|-RVA: 0x129F270 Offset: 0x129D870 VA: 0x18129F270
	|-NativeArray<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x129F160 Offset: 0x129D760 VA: 0x18129F160
	|-NativeArray<CopyMeshJobData>..ctor
	|
	|-RVA: 0x129F490 Offset: 0x129DA90 VA: 0x18129F490
	|-NativeArray<CullingSplit>..ctor
	|-NativeArray<LightDataGI>..ctor
	|-NativeArray<TileData>..ctor
	|
	|-RVA: 0x129F8F0 Offset: 0x129DEF0 VA: 0x18129F8F0
	|-NativeArray<DistanceToInterpolation>..ctor
	|
	|-RVA: 0x129FB00 Offset: 0x129E100 VA: 0x18129FB00
	|-NativeArray<GfxUpdateBufferRange>..ctor
	|-NativeArray<JobHandle>..ctor
	|-NativeArray<Painter2D.Painter2DJobData>..ctor
	|
	|-RVA: 0x129F380 Offset: 0x129D980 VA: 0x18129F380
	|-NativeArray<int>..ctor
	|-NativeArray<float>..ctor
	|-NativeArray<uint>..ctor
	|
	|-RVA: 0x129FE20 Offset: 0x129E420 VA: 0x18129FE20
	|-NativeArray<Matrix4x4>..ctor
	|-NativeArray<Vertex>..ctor
	|
	|-RVA: 0x129FF30 Offset: 0x129E530 VA: 0x18129FF30
	|-NativeArray<ModifiableContactPair>..ctor
	|
	|-RVA: 0x129FD20 Offset: 0x129E320 VA: 0x18129FD20
	|-NativeArray<NudgeJobData>..ctor
	|
	|-RVA: 0x129EF40 Offset: 0x129D540 VA: 0x18129EF40
	|-NativeArray<ushort>..ctor
	|
	|-RVA: 0x129F050 Offset: 0x129D650 VA: 0x18129F050
	|-NativeArray<Vector3>..ctor
	|-NativeArray<Vector3Int>..ctor
	|-NativeArray<float3>..ctor
	|
	|-RVA: 0x129F6A0 Offset: 0x129DCA0 VA: 0x18129F6A0
	|-NativeArray<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x12A1AF0 Offset: 0x12A00F0 VA: 0x1812A1AF0
	|-NativeArray<MeshGenerator.TessellationJobParameters>..ctor
	|
	|-RVA: 0x12A19E0 Offset: 0x129FFE0 VA: 0x1812A19E0
	|-NativeArray<SplineMesh.VertexData>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void Allocate(int length, Allocator allocator, out NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12973A0 Offset: 0x12959A0 VA: 0x1812973A0
	|-NativeArray<BatchCullingOutputDrawCommands>.Allocate
	|
	|-RVA: 0x12975B0 Offset: 0x1295BB0 VA: 0x1812975B0
	|-NativeArray<BezierCurve>.Allocate
	|
	|-RVA: 0x1297190 Offset: 0x1295790 VA: 0x181297190
	|-NativeArray<BezierKnot>.Allocate
	|
	|-RVA: 0x1296F90 Offset: 0x1295590 VA: 0x181296F90
	|-NativeArray<byte>.Allocate
	|
	|-RVA: 0x1296C80 Offset: 0x1295280 VA: 0x181296C80
	|-NativeArray<Color>.Allocate
	|-NativeArray<DrawBufferRange>.Allocate
	|-NativeArray<Plane>.Allocate
	|-NativeArray<Quaternion>.Allocate
	|
	|-RVA: 0x1297450 Offset: 0x1295A50 VA: 0x181297450
	|-NativeArray<ContactPairHeader>.Allocate
	|
	|-RVA: 0x1296BD0 Offset: 0x12951D0 VA: 0x181296BD0
	|-NativeArray<ConvertMeshJobData>.Allocate
	|
	|-RVA: 0x1297030 Offset: 0x1295630 VA: 0x181297030
	|-NativeArray<CopyMeshJobData>.Allocate
	|
	|-RVA: 0x1296D30 Offset: 0x1295330 VA: 0x181296D30
	|-NativeArray<CullingSplit>.Allocate
	|-NativeArray<LightDataGI>.Allocate
	|-NativeArray<TileData>.Allocate
	|
	|-RVA: 0x1296B20 Offset: 0x1295120 VA: 0x181296B20
	|-NativeArray<DistanceToInterpolation>.Allocate
	|
	|-RVA: 0x12972F0 Offset: 0x12958F0 VA: 0x1812972F0
	|-NativeArray<GfxUpdateBufferRange>.Allocate
	|-NativeArray<JobHandle>.Allocate
	|-NativeArray<Painter2D.Painter2DJobData>.Allocate
	|
	|-RVA: 0x1297240 Offset: 0x1295840 VA: 0x181297240
	|-NativeArray<int>.Allocate
	|-NativeArray<float>.Allocate
	|-NativeArray<uint>.Allocate
	|
	|-RVA: 0x12969C0 Offset: 0x1294FC0 VA: 0x1812969C0
	|-NativeArray<Matrix4x4>.Allocate
	|-NativeArray<Vertex>.Allocate
	|
	|-RVA: 0x1296A70 Offset: 0x1295070 VA: 0x181296A70
	|-NativeArray<ModifiableContactPair>.Allocate
	|
	|-RVA: 0x1297500 Offset: 0x1295B00 VA: 0x181297500
	|-NativeArray<NudgeJobData>.Allocate
	|
	|-RVA: 0x1296EE0 Offset: 0x12954E0 VA: 0x181296EE0
	|-NativeArray<ushort>.Allocate
	|
	|-RVA: 0x12970E0 Offset: 0x12956E0 VA: 0x1812970E0
	|-NativeArray<Vector3>.Allocate
	|-NativeArray<Vector3Int>.Allocate
	|-NativeArray<float3>.Allocate
	|
	|-RVA: 0x1296DE0 Offset: 0x12953E0 VA: 0x181296DE0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Allocate
	|
	|-RVA: 0x12A09D0 Offset: 0x129EFD0 VA: 0x1812A09D0
	|-NativeArray<MeshGenerator.TessellationJobParameters>.Allocate
	|
	|-RVA: 0x12A0A80 Offset: 0x129F080 VA: 0x1812A0A80
	|-NativeArray<SplineMesh.VertexData>.Allocate
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9093D0 Offset: 0x9079D0 VA: 0x1809093D0
	|-NativeArray<BatchCullingOutputDrawCommands>.get_Length
	|-NativeArray<BezierCurve>.get_Length
	|-NativeArray<BezierKnot>.get_Length
	|-NativeArray<byte>.get_Length
	|-NativeArray<Color>.get_Length
	|-NativeArray<ContactPairHeader>.get_Length
	|-NativeArray<ConvertMeshJobData>.get_Length
	|-NativeArray<CopyMeshJobData>.get_Length
	|-NativeArray<CullingSplit>.get_Length
	|-NativeArray<DistanceToInterpolation>.get_Length
	|-NativeArray<DrawBufferRange>.get_Length
	|-NativeArray<GfxUpdateBufferRange>.get_Length
	|-NativeArray<int>.get_Length
	|-NativeArray<JobHandle>.get_Length
	|-NativeArray<LightDataGI>.get_Length
	|-NativeArray<Matrix4x4>.get_Length
	|-NativeArray<ModifiableContactPair>.get_Length
	|-NativeArray<NudgeJobData>.get_Length
	|-NativeArray<Plane>.get_Length
	|-NativeArray<Quaternion>.get_Length
	|-NativeArray<float>.get_Length
	|-NativeArray<TileData>.get_Length
	|-NativeArray<ushort>.get_Length
	|-NativeArray<uint>.get_Length
	|-NativeArray<Vector3>.get_Length
	|-NativeArray<Vector3Int>.get_Length
	|-NativeArray<Vertex>.get_Length
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_Length
	|-NativeArray<float3>.get_Length
	|-NativeArray<MeshGenerator.TessellationJobParameters>.get_Length
	|-NativeArray<Painter2D.Painter2DJobData>.get_Length
	|-NativeArray<SplineMesh.VertexData>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x909350 Offset: 0x907950 VA: 0x180909350
	|-NativeArray<BatchCullingOutputDrawCommands>.get_Item
	|
	|-RVA: 0x908B80 Offset: 0x907180 VA: 0x180908B80
	|-NativeArray<BezierCurve>.get_Item
	|-NativeArray<CopyMeshJobData>.get_Item
	|
	|-RVA: 0x908C30 Offset: 0x907230 VA: 0x180908C30
	|-NativeArray<BezierKnot>.get_Item
	|
	|-RVA: 0x908BF0 Offset: 0x9071F0 VA: 0x180908BF0
	|-NativeArray<byte>.get_Item
	|
	|-RVA: 0x908B30 Offset: 0x907130 VA: 0x180908B30
	|-NativeArray<Color>.get_Item
	|-NativeArray<DrawBufferRange>.get_Item
	|-NativeArray<GfxUpdateBufferRange>.get_Item
	|-NativeArray<JobHandle>.get_Item
	|-NativeArray<Plane>.get_Item
	|-NativeArray<Quaternion>.get_Item
	|-NativeArray<Painter2D.Painter2DJobData>.get_Item
	|
	|-RVA: 0x908F70 Offset: 0x907570 VA: 0x180908F70
	|-NativeArray<ContactPairHeader>.get_Item
	|
	|-RVA: 0x909140 Offset: 0x907740 VA: 0x180909140
	|-NativeArray<ConvertMeshJobData>.get_Item
	|
	|-RVA: 0x908CB0 Offset: 0x9072B0 VA: 0x180908CB0
	|-NativeArray<CullingSplit>.get_Item
	|-NativeArray<LightDataGI>.get_Item
	|-NativeArray<TileData>.get_Item
	|
	|-RVA: 0x908F30 Offset: 0x907530 VA: 0x180908F30
	|-NativeArray<DistanceToInterpolation>.get_Item
	|
	|-RVA: 0x908B00 Offset: 0x907100 VA: 0x180908B00
	|-NativeArray<int>.get_Item
	|-NativeArray<uint>.get_Item
	|
	|-RVA: 0x908A40 Offset: 0x907040 VA: 0x180908A40
	|-NativeArray<Matrix4x4>.get_Item
	|-NativeArray<Vertex>.get_Item
	|
	|-RVA: 0x909210 Offset: 0x907810 VA: 0x180909210
	|-NativeArray<ModifiableContactPair>.get_Item
	|
	|-RVA: 0x908E90 Offset: 0x907490 VA: 0x180908E90
	|-NativeArray<NudgeJobData>.get_Item
	|
	|-RVA: 0x908AC0 Offset: 0x9070C0 VA: 0x180908AC0
	|-NativeArray<float>.get_Item
	|
	|-RVA: 0x9092B0 Offset: 0x9078B0 VA: 0x1809092B0
	|-NativeArray<ushort>.get_Item
	|
	|-RVA: 0x908D50 Offset: 0x907350 VA: 0x180908D50
	|-NativeArray<Vector3>.get_Item
	|-NativeArray<Vector3Int>.get_Item
	|-NativeArray<float3>.get_Item
	|
	|-RVA: 0x12A0140 Offset: 0x129E740 VA: 0x1812A0140
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_Item
	|
	|-RVA: 0x908DB0 Offset: 0x9073B0 VA: 0x180908DB0
	|-NativeArray<MeshGenerator.TessellationJobParameters>.get_Item
	|
	|-RVA: 0x9092F0 Offset: 0x9078F0 VA: 0x1809092F0
	|-NativeArray<SplineMesh.VertexData>.get_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A08E0 Offset: 0x129EEE0 VA: 0x1812A08E0
	|-NativeArray<BatchCullingOutputDrawCommands>.set_Item
	|
	|-RVA: 0x12A0420 Offset: 0x129EA20 VA: 0x1812A0420
	|-NativeArray<BezierCurve>.set_Item
	|-NativeArray<CopyMeshJobData>.set_Item
	|
	|-RVA: 0x12A0880 Offset: 0x129EE80 VA: 0x1812A0880
	|-NativeArray<BezierKnot>.set_Item
	|
	|-RVA: 0x12A07C0 Offset: 0x129EDC0 VA: 0x1812A07C0
	|-NativeArray<byte>.set_Item
	|
	|-RVA: 0x12A0480 Offset: 0x129EA80 VA: 0x1812A0480
	|-NativeArray<Color>.set_Item
	|-NativeArray<DrawBufferRange>.set_Item
	|-NativeArray<GfxUpdateBufferRange>.set_Item
	|-NativeArray<JobHandle>.set_Item
	|-NativeArray<Plane>.set_Item
	|-NativeArray<Quaternion>.set_Item
	|-NativeArray<Painter2D.Painter2DJobData>.set_Item
	|
	|-RVA: 0x12A04D0 Offset: 0x129EAD0 VA: 0x1812A04D0
	|-NativeArray<ContactPairHeader>.set_Item
	|
	|-RVA: 0x12A02A0 Offset: 0x129E8A0 VA: 0x1812A02A0
	|-NativeArray<ConvertMeshJobData>.set_Item
	|
	|-RVA: 0x12A0570 Offset: 0x129EB70 VA: 0x1812A0570
	|-NativeArray<CullingSplit>.set_Item
	|-NativeArray<LightDataGI>.set_Item
	|-NativeArray<TileData>.set_Item
	|
	|-RVA: 0x12A0770 Offset: 0x129ED70 VA: 0x1812A0770
	|-NativeArray<DistanceToInterpolation>.set_Item
	|
	|-RVA: 0x12A03E0 Offset: 0x129E9E0 VA: 0x1812A03E0
	|-NativeArray<int>.set_Item
	|-NativeArray<uint>.set_Item
	|
	|-RVA: 0x12A05F0 Offset: 0x129EBF0 VA: 0x1812A05F0
	|-NativeArray<Matrix4x4>.set_Item
	|-NativeArray<Vertex>.set_Item
	|
	|-RVA: 0x12A0950 Offset: 0x129EF50 VA: 0x1812A0950
	|-NativeArray<ModifiableContactPair>.set_Item
	|
	|-RVA: 0x12A0800 Offset: 0x129EE00 VA: 0x1812A0800
	|-NativeArray<NudgeJobData>.set_Item
	|
	|-RVA: 0x12A0530 Offset: 0x129EB30 VA: 0x1812A0530
	|-NativeArray<float>.set_Item
	|
	|-RVA: 0x12A03A0 Offset: 0x129E9A0 VA: 0x1812A03A0
	|-NativeArray<ushort>.set_Item
	|
	|-RVA: 0x12A0350 Offset: 0x129E950 VA: 0x1812A0350
	|-NativeArray<Vector3>.set_Item
	|-NativeArray<Vector3Int>.set_Item
	|-NativeArray<float3>.set_Item
	|
	|-RVA: 0x12A0660 Offset: 0x129EC60 VA: 0x1812A0660
	|-NativeArray<__Il2CppFullySharedGenericStructType>.set_Item
	|
	|-RVA: 0x12A1C60 Offset: 0x12A0260 VA: 0x1812A1C60
	|-NativeArray<MeshGenerator.TessellationJobParameters>.set_Item
	|
	|-RVA: 0x12A1C00 Offset: 0x12A0200 VA: 0x1812A1C00
	|-NativeArray<SplineMesh.VertexData>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A0130 Offset: 0x129E730 VA: 0x1812A0130
	|-NativeArray<BatchCullingOutputDrawCommands>.get_IsCreated
	|-NativeArray<BezierCurve>.get_IsCreated
	|-NativeArray<BezierKnot>.get_IsCreated
	|-NativeArray<byte>.get_IsCreated
	|-NativeArray<Color>.get_IsCreated
	|-NativeArray<ContactPairHeader>.get_IsCreated
	|-NativeArray<ConvertMeshJobData>.get_IsCreated
	|-NativeArray<CopyMeshJobData>.get_IsCreated
	|-NativeArray<CullingSplit>.get_IsCreated
	|-NativeArray<DistanceToInterpolation>.get_IsCreated
	|-NativeArray<DrawBufferRange>.get_IsCreated
	|-NativeArray<GfxUpdateBufferRange>.get_IsCreated
	|-NativeArray<int>.get_IsCreated
	|-NativeArray<JobHandle>.get_IsCreated
	|-NativeArray<LightDataGI>.get_IsCreated
	|-NativeArray<Matrix4x4>.get_IsCreated
	|-NativeArray<ModifiableContactPair>.get_IsCreated
	|-NativeArray<NudgeJobData>.get_IsCreated
	|-NativeArray<Plane>.get_IsCreated
	|-NativeArray<Quaternion>.get_IsCreated
	|-NativeArray<float>.get_IsCreated
	|-NativeArray<TileData>.get_IsCreated
	|-NativeArray<ushort>.get_IsCreated
	|-NativeArray<uint>.get_IsCreated
	|-NativeArray<Vector3>.get_IsCreated
	|-NativeArray<Vector3Int>.get_IsCreated
	|-NativeArray<Vertex>.get_IsCreated
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_IsCreated
	|-NativeArray<float3>.get_IsCreated
	|-NativeArray<MeshGenerator.TessellationJobParameters>.get_IsCreated
	|-NativeArray<Painter2D.Painter2DJobData>.get_IsCreated
	|-NativeArray<SplineMesh.VertexData>.get_IsCreated
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129AAA0 Offset: 0x12990A0 VA: 0x18129AAA0
	|-NativeArray<BatchCullingOutputDrawCommands>.Dispose
	|-NativeArray<BezierCurve>.Dispose
	|-NativeArray<BezierKnot>.Dispose
	|-NativeArray<byte>.Dispose
	|-NativeArray<Color>.Dispose
	|-NativeArray<ContactPairHeader>.Dispose
	|-NativeArray<ConvertMeshJobData>.Dispose
	|-NativeArray<CopyMeshJobData>.Dispose
	|-NativeArray<CullingSplit>.Dispose
	|-NativeArray<DistanceToInterpolation>.Dispose
	|-NativeArray<DrawBufferRange>.Dispose
	|-NativeArray<GfxUpdateBufferRange>.Dispose
	|-NativeArray<int>.Dispose
	|-NativeArray<JobHandle>.Dispose
	|-NativeArray<LightDataGI>.Dispose
	|-NativeArray<Matrix4x4>.Dispose
	|-NativeArray<ModifiableContactPair>.Dispose
	|-NativeArray<NudgeJobData>.Dispose
	|-NativeArray<Plane>.Dispose
	|-NativeArray<Quaternion>.Dispose
	|-NativeArray<float>.Dispose
	|-NativeArray<TileData>.Dispose
	|-NativeArray<ushort>.Dispose
	|-NativeArray<uint>.Dispose
	|-NativeArray<Vector3>.Dispose
	|-NativeArray<Vector3Int>.Dispose
	|-NativeArray<Vertex>.Dispose
	|-NativeArray<float3>.Dispose
	|-NativeArray<MeshGenerator.TessellationJobParameters>.Dispose
	|-NativeArray<Painter2D.Painter2DJobData>.Dispose
	|-NativeArray<SplineMesh.VertexData>.Dispose
	|
	|-RVA: 0x129AB80 Offset: 0x1299180 VA: 0x18129AB80
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129E500 Offset: 0x129CB00 VA: 0x18129E500
	|-NativeArray<BatchCullingOutputDrawCommands>.ToArray
	|
	|-RVA: 0x129ECE0 Offset: 0x129D2E0 VA: 0x18129ECE0
	|-NativeArray<BezierCurve>.ToArray
	|-NativeArray<CopyMeshJobData>.ToArray
	|
	|-RVA: 0x129E650 Offset: 0x129CC50 VA: 0x18129E650
	|-NativeArray<BezierKnot>.ToArray
	|
	|-RVA: 0x129E240 Offset: 0x129C840 VA: 0x18129E240
	|-NativeArray<byte>.ToArray
	|
	|-RVA: 0x129DD00 Offset: 0x129C300 VA: 0x18129DD00
	|-NativeArray<Color>.ToArray
	|-NativeArray<DrawBufferRange>.ToArray
	|-NativeArray<GfxUpdateBufferRange>.ToArray
	|-NativeArray<JobHandle>.ToArray
	|-NativeArray<Plane>.ToArray
	|-NativeArray<Quaternion>.ToArray
	|-NativeArray<Painter2D.Painter2DJobData>.ToArray
	|
	|-RVA: 0x129EA40 Offset: 0x129D040 VA: 0x18129EA40
	|-NativeArray<ContactPairHeader>.ToArray
	|
	|-RVA: 0x129E7A0 Offset: 0x129CDA0 VA: 0x18129E7A0
	|-NativeArray<ConvertMeshJobData>.ToArray
	|
	|-RVA: 0x129DE50 Offset: 0x129C450 VA: 0x18129DE50
	|-NativeArray<CullingSplit>.ToArray
	|-NativeArray<LightDataGI>.ToArray
	|-NativeArray<TileData>.ToArray
	|
	|-RVA: 0x129DFA0 Offset: 0x129C5A0 VA: 0x18129DFA0
	|-NativeArray<DistanceToInterpolation>.ToArray
	|
	|-RVA: 0x129E8F0 Offset: 0x129CEF0 VA: 0x18129E8F0
	|-NativeArray<int>.ToArray
	|-NativeArray<float>.ToArray
	|-NativeArray<uint>.ToArray
	|
	|-RVA: 0x129DBB0 Offset: 0x129C1B0 VA: 0x18129DBB0
	|-NativeArray<Matrix4x4>.ToArray
	|-NativeArray<Vertex>.ToArray
	|
	|-RVA: 0x129D910 Offset: 0x129BF10 VA: 0x18129D910
	|-NativeArray<ModifiableContactPair>.ToArray
	|
	|-RVA: 0x129E0F0 Offset: 0x129C6F0 VA: 0x18129E0F0
	|-NativeArray<NudgeJobData>.ToArray
	|
	|-RVA: 0x129EB90 Offset: 0x129D190 VA: 0x18129EB90
	|-NativeArray<ushort>.ToArray
	|
	|-RVA: 0x129DA60 Offset: 0x129C060 VA: 0x18129DA60
	|-NativeArray<Vector3>.ToArray
	|-NativeArray<Vector3Int>.ToArray
	|-NativeArray<float3>.ToArray
	|
	|-RVA: 0x129E390 Offset: 0x129C990 VA: 0x18129E390
	|-NativeArray<__Il2CppFullySharedGenericStructType>.ToArray
	|
	|-RVA: 0x12A1890 Offset: 0x129FE90 VA: 0x1812A1890
	|-NativeArray<MeshGenerator.TessellationJobParameters>.ToArray
	|
	|-RVA: 0x12A1740 Offset: 0x129FD40 VA: 0x1812A1740
	|-NativeArray<SplineMesh.VertexData>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129B460 Offset: 0x1299A60 VA: 0x18129B460
	|-NativeArray<BatchCullingOutputDrawCommands>.GetEnumerator
	|
	|-RVA: 0x129B900 Offset: 0x1299F00 VA: 0x18129B900
	|-NativeArray<BezierCurve>.GetEnumerator
	|
	|-RVA: 0x129B3B0 Offset: 0x12999B0 VA: 0x18129B3B0
	|-NativeArray<BezierKnot>.GetEnumerator
	|
	|-RVA: 0x129BB50 Offset: 0x129A150 VA: 0x18129BB50
	|-NativeArray<byte>.GetEnumerator
	|
	|-RVA: 0x129AF80 Offset: 0x1299580 VA: 0x18129AF80
	|-NativeArray<Color>.GetEnumerator
	|-NativeArray<DrawBufferRange>.GetEnumerator
	|-NativeArray<Plane>.GetEnumerator
	|-NativeArray<Quaternion>.GetEnumerator
	|
	|-RVA: 0x129B860 Offset: 0x1299E60 VA: 0x18129B860
	|-NativeArray<ContactPairHeader>.GetEnumerator
	|
	|-RVA: 0x129B510 Offset: 0x1299B10 VA: 0x18129B510
	|-NativeArray<ConvertMeshJobData>.GetEnumerator
	|
	|-RVA: 0x129B6A0 Offset: 0x1299CA0 VA: 0x18129B6A0
	|-NativeArray<CopyMeshJobData>.GetEnumerator
	|
	|-RVA: 0x129B2C0 Offset: 0x12998C0 VA: 0x18129B2C0
	|-NativeArray<CullingSplit>.GetEnumerator
	|-NativeArray<LightDataGI>.GetEnumerator
	|-NativeArray<TileData>.GetEnumerator
	|
	|-RVA: 0x129B010 Offset: 0x1299610 VA: 0x18129B010
	|-NativeArray<DistanceToInterpolation>.GetEnumerator
	|
	|-RVA: 0x129B610 Offset: 0x1299C10 VA: 0x18129B610
	|-NativeArray<GfxUpdateBufferRange>.GetEnumerator
	|-NativeArray<JobHandle>.GetEnumerator
	|-NativeArray<Painter2D.Painter2DJobData>.GetEnumerator
	|
	|-RVA: 0x129B080 Offset: 0x1299680 VA: 0x18129B080
	|-NativeArray<int>.GetEnumerator
	|-NativeArray<float>.GetEnumerator
	|-NativeArray<uint>.GetEnumerator
	|
	|-RVA: 0x129B1F0 Offset: 0x12997F0 VA: 0x18129B1F0
	|-NativeArray<Matrix4x4>.GetEnumerator
	|-NativeArray<Vertex>.GetEnumerator
	|
	|-RVA: 0x129B100 Offset: 0x1299700 VA: 0x18129B100
	|-NativeArray<ModifiableContactPair>.GetEnumerator
	|
	|-RVA: 0x129B750 Offset: 0x1299D50 VA: 0x18129B750
	|-NativeArray<NudgeJobData>.GetEnumerator
	|
	|-RVA: 0x129B9B0 Offset: 0x1299FB0 VA: 0x18129B9B0
	|-NativeArray<ushort>.GetEnumerator
	|
	|-RVA: 0x129AF10 Offset: 0x1299510 VA: 0x18129AF10
	|-NativeArray<Vector3>.GetEnumerator
	|-NativeArray<Vector3Int>.GetEnumerator
	|-NativeArray<float3>.GetEnumerator
	|
	|-RVA: 0x129BA30 Offset: 0x129A030 VA: 0x18129BA30
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetEnumerator
	|
	|-RVA: 0x12A1220 Offset: 0x129F820 VA: 0x1812A1220
	|-NativeArray<MeshGenerator.TessellationJobParameters>.GetEnumerator
	|
	|-RVA: 0x12A1180 Offset: 0x129F780 VA: 0x1812A1180
	|-NativeArray<SplineMesh.VertexData>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129BF40 Offset: 0x129A540 VA: 0x18129BF40
	|-NativeArray<BatchCullingOutputDrawCommands>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C7D0 Offset: 0x129ADD0 VA: 0x18129C7D0
	|-NativeArray<BezierCurve>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C8B0 Offset: 0x129AEB0 VA: 0x18129C8B0
	|-NativeArray<BezierKnot>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C330 Offset: 0x129A930 VA: 0x18129C330
	|-NativeArray<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C470 Offset: 0x129AA70 VA: 0x18129C470
	|-NativeArray<Color>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<DrawBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Plane>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129BE80 Offset: 0x129A480 VA: 0x18129BE80
	|-NativeArray<ContactPairHeader>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C990 Offset: 0x129AF90 VA: 0x18129C990
	|-NativeArray<ConvertMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C250 Offset: 0x129A850 VA: 0x18129C250
	|-NativeArray<CopyMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129BC80 Offset: 0x129A280 VA: 0x18129BC80
	|-NativeArray<CullingSplit>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<LightDataGI>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<TileData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C020 Offset: 0x129A620 VA: 0x18129C020
	|-NativeArray<DistanceToInterpolation>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C0C0 Offset: 0x129A6C0 VA: 0x18129C0C0
	|-NativeArray<GfxUpdateBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<JobHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Painter2D.Painter2DJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129BBE0 Offset: 0x129A1E0 VA: 0x18129BBE0
	|-NativeArray<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C5C0 Offset: 0x129ABC0 VA: 0x18129C5C0
	|-NativeArray<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Vertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129BD80 Offset: 0x129A380 VA: 0x18129BD80
	|-NativeArray<ModifiableContactPair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C6C0 Offset: 0x129ACC0 VA: 0x18129C6C0
	|-NativeArray<NudgeJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C3D0 Offset: 0x129A9D0 VA: 0x18129C3D0
	|-NativeArray<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C520 Offset: 0x129AB20 VA: 0x18129C520
	|-NativeArray<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Vector3Int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<float3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x129C170 Offset: 0x129A770 VA: 0x18129C170
	|-NativeArray<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x12A1340 Offset: 0x129F940 VA: 0x1812A1340
	|-NativeArray<MeshGenerator.TessellationJobParameters>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x12A1470 Offset: 0x129FA70 VA: 0x1812A1470
	|-NativeArray<SplineMesh.VertexData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129D370 Offset: 0x129B970 VA: 0x18129D370
	|-NativeArray<BatchCullingOutputDrawCommands>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129D420 Offset: 0x129BA20 VA: 0x18129D420
	|-NativeArray<BezierCurve>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129CEB0 Offset: 0x129B4B0 VA: 0x18129CEB0
	|-NativeArray<BezierKnot>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129D0E0 Offset: 0x129B6E0 VA: 0x18129D0E0
	|-NativeArray<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129CAB0 Offset: 0x129B0B0 VA: 0x18129CAB0
	|-NativeArray<Color>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<DrawBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Plane>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129D750 Offset: 0x129BD50 VA: 0x18129D750
	|-NativeArray<ContactPairHeader>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129D1A0 Offset: 0x129B7A0 VA: 0x18129D1A0
	|-NativeArray<ConvertMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129D030 Offset: 0x129B630 VA: 0x18129D030
	|-NativeArray<CopyMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129CD20 Offset: 0x129B320 VA: 0x18129CD20
	|-NativeArray<CullingSplit>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<LightDataGI>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<TileData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129D2B0 Offset: 0x129B8B0 VA: 0x18129D2B0
	|-NativeArray<DistanceToInterpolation>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129CF60 Offset: 0x129B560 VA: 0x18129CF60
	|-NativeArray<GfxUpdateBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<JobHandle>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Painter2D.Painter2DJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129CC60 Offset: 0x129B260 VA: 0x18129CC60
	|-NativeArray<int>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<float>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129CDF0 Offset: 0x129B3F0 VA: 0x18129CDF0
	|-NativeArray<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Vertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129D840 Offset: 0x129BE40 VA: 0x18129D840
	|-NativeArray<ModifiableContactPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129CB80 Offset: 0x129B180 VA: 0x18129CB80
	|-NativeArray<NudgeJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129D590 Offset: 0x129BB90 VA: 0x18129D590
	|-NativeArray<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129D4D0 Offset: 0x129BAD0 VA: 0x18129D4D0
	|-NativeArray<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<float3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x129D650 Offset: 0x129BC50 VA: 0x18129D650
	|-NativeArray<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12A1540 Offset: 0x129FB40 VA: 0x1812A1540
	|-NativeArray<MeshGenerator.TessellationJobParameters>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12A1650 Offset: 0x129FC50 VA: 0x1812A1650
	|-NativeArray<SplineMesh.VertexData>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(NativeArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129ACA0 Offset: 0x12992A0 VA: 0x18129ACA0
	|-NativeArray<BatchCullingOutputDrawCommands>.Equals
	|-NativeArray<BezierCurve>.Equals
	|-NativeArray<BezierKnot>.Equals
	|-NativeArray<byte>.Equals
	|-NativeArray<Color>.Equals
	|-NativeArray<ContactPairHeader>.Equals
	|-NativeArray<ConvertMeshJobData>.Equals
	|-NativeArray<CopyMeshJobData>.Equals
	|-NativeArray<CullingSplit>.Equals
	|-NativeArray<DistanceToInterpolation>.Equals
	|-NativeArray<DrawBufferRange>.Equals
	|-NativeArray<GfxUpdateBufferRange>.Equals
	|-NativeArray<int>.Equals
	|-NativeArray<JobHandle>.Equals
	|-NativeArray<LightDataGI>.Equals
	|-NativeArray<Matrix4x4>.Equals
	|-NativeArray<ModifiableContactPair>.Equals
	|-NativeArray<NudgeJobData>.Equals
	|-NativeArray<Plane>.Equals
	|-NativeArray<Quaternion>.Equals
	|-NativeArray<float>.Equals
	|-NativeArray<TileData>.Equals
	|-NativeArray<ushort>.Equals
	|-NativeArray<uint>.Equals
	|-NativeArray<Vector3>.Equals
	|-NativeArray<Vector3Int>.Equals
	|-NativeArray<Vertex>.Equals
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Equals
	|-NativeArray<float3>.Equals
	|-NativeArray<MeshGenerator.TessellationJobParameters>.Equals
	|-NativeArray<Painter2D.Painter2DJobData>.Equals
	|-NativeArray<SplineMesh.VertexData>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129ACC0 Offset: 0x12992C0 VA: 0x18129ACC0
	|-NativeArray<BatchCullingOutputDrawCommands>.Equals
	|-NativeArray<BezierCurve>.Equals
	|-NativeArray<BezierKnot>.Equals
	|-NativeArray<byte>.Equals
	|-NativeArray<Color>.Equals
	|-NativeArray<ContactPairHeader>.Equals
	|-NativeArray<ConvertMeshJobData>.Equals
	|-NativeArray<CopyMeshJobData>.Equals
	|-NativeArray<CullingSplit>.Equals
	|-NativeArray<DistanceToInterpolation>.Equals
	|-NativeArray<DrawBufferRange>.Equals
	|-NativeArray<GfxUpdateBufferRange>.Equals
	|-NativeArray<int>.Equals
	|-NativeArray<JobHandle>.Equals
	|-NativeArray<LightDataGI>.Equals
	|-NativeArray<Matrix4x4>.Equals
	|-NativeArray<ModifiableContactPair>.Equals
	|-NativeArray<NudgeJobData>.Equals
	|-NativeArray<Plane>.Equals
	|-NativeArray<Quaternion>.Equals
	|-NativeArray<float>.Equals
	|-NativeArray<TileData>.Equals
	|-NativeArray<ushort>.Equals
	|-NativeArray<uint>.Equals
	|-NativeArray<Vector3>.Equals
	|-NativeArray<Vector3Int>.Equals
	|-NativeArray<Vertex>.Equals
	|-NativeArray<float3>.Equals
	|-NativeArray<MeshGenerator.TessellationJobParameters>.Equals
	|-NativeArray<Painter2D.Painter2DJobData>.Equals
	|-NativeArray<SplineMesh.VertexData>.Equals
	|
	|-RVA: 0x129ADC0 Offset: 0x12993C0 VA: 0x18129ADC0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129BBD0 Offset: 0x129A1D0 VA: 0x18129BBD0
	|-NativeArray<BatchCullingOutputDrawCommands>.GetHashCode
	|-NativeArray<BezierCurve>.GetHashCode
	|-NativeArray<BezierKnot>.GetHashCode
	|-NativeArray<byte>.GetHashCode
	|-NativeArray<Color>.GetHashCode
	|-NativeArray<ContactPairHeader>.GetHashCode
	|-NativeArray<ConvertMeshJobData>.GetHashCode
	|-NativeArray<CopyMeshJobData>.GetHashCode
	|-NativeArray<CullingSplit>.GetHashCode
	|-NativeArray<DistanceToInterpolation>.GetHashCode
	|-NativeArray<DrawBufferRange>.GetHashCode
	|-NativeArray<GfxUpdateBufferRange>.GetHashCode
	|-NativeArray<int>.GetHashCode
	|-NativeArray<JobHandle>.GetHashCode
	|-NativeArray<LightDataGI>.GetHashCode
	|-NativeArray<Matrix4x4>.GetHashCode
	|-NativeArray<ModifiableContactPair>.GetHashCode
	|-NativeArray<NudgeJobData>.GetHashCode
	|-NativeArray<Plane>.GetHashCode
	|-NativeArray<Quaternion>.GetHashCode
	|-NativeArray<float>.GetHashCode
	|-NativeArray<TileData>.GetHashCode
	|-NativeArray<ushort>.GetHashCode
	|-NativeArray<uint>.GetHashCode
	|-NativeArray<Vector3>.GetHashCode
	|-NativeArray<Vector3Int>.GetHashCode
	|-NativeArray<Vertex>.GetHashCode
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetHashCode
	|-NativeArray<float3>.GetHashCode
	|-NativeArray<MeshGenerator.TessellationJobParameters>.GetHashCode
	|-NativeArray<Painter2D.Painter2DJobData>.GetHashCode
	|-NativeArray<SplineMesh.VertexData>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1299170 Offset: 0x1297770 VA: 0x181299170
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x129A6B0 Offset: 0x1298CB0 VA: 0x18129A6B0
	|-NativeArray<BezierCurve>.Copy
	|-NativeArray<CopyMeshJobData>.Copy
	|
	|-RVA: 0x129A500 Offset: 0x1298B00 VA: 0x18129A500
	|-NativeArray<BezierKnot>.Copy
	|
	|-RVA: 0x1299000 Offset: 0x1297600 VA: 0x181299000
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x1299E40 Offset: 0x1298440 VA: 0x181299E40
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Painter2D.Painter2DJobData>.Copy
	|
	|-RVA: 0x12995C0 Offset: 0x1297BC0 VA: 0x1812995C0
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x129A9E0 Offset: 0x1298FE0 VA: 0x18129A9E0
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x1299320 Offset: 0x1297920 VA: 0x181299320
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x129A770 Offset: 0x1298D70 VA: 0x18129A770
	|-NativeArray<DistanceToInterpolation>.Copy
	|
	|-RVA: 0x129A0B0 Offset: 0x12986B0 VA: 0x18129A0B0
	|-NativeArray<int>.Copy
	|-NativeArray<float>.Copy
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x1299D80 Offset: 0x1298380 VA: 0x181299D80
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|
	|-RVA: 0x12990B0 Offset: 0x12976B0 VA: 0x1812990B0
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x1299F00 Offset: 0x1298500 VA: 0x181299F00
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x129A920 Offset: 0x1298F20 VA: 0x18129A920
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x1299680 Offset: 0x1297C80 VA: 0x181299680
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|-NativeArray<float3>.Copy
	|
	|-RVA: 0x129A260 Offset: 0x1298860 VA: 0x18129A260
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x12A0F10 Offset: 0x129F510 VA: 0x1812A0F10
	|-NativeArray<MeshGenerator.TessellationJobParameters>.Copy
	|
	|-RVA: 0x12A10C0 Offset: 0x129F6C0 VA: 0x1812A10C0
	|-NativeArray<SplineMesh.VertexData>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, T[] dst, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1299830 Offset: 0x1297E30 VA: 0x181299830
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x129A320 Offset: 0x1298920 VA: 0x18129A320
	|-NativeArray<BezierCurve>.Copy
	|-NativeArray<CopyMeshJobData>.Copy
	|
	|-RVA: 0x1299BB0 Offset: 0x12981B0 VA: 0x181299BB0
	|-NativeArray<BezierKnot>.Copy
	|
	|-RVA: 0x1299CA0 Offset: 0x12982A0 VA: 0x181299CA0
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x12999D0 Offset: 0x1297FD0 VA: 0x1812999D0
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Painter2D.Painter2DJobData>.Copy
	|
	|-RVA: 0x129A830 Offset: 0x1298E30 VA: 0x18129A830
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x129A5C0 Offset: 0x1298BC0 VA: 0x18129A5C0
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x1299AC0 Offset: 0x12980C0 VA: 0x181299AC0
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x1299230 Offset: 0x1297830 VA: 0x181299230
	|-NativeArray<DistanceToInterpolation>.Copy
	|
	|-RVA: 0x129A170 Offset: 0x1298770 VA: 0x18129A170
	|-NativeArray<int>.Copy
	|-NativeArray<float>.Copy
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x1299FC0 Offset: 0x12985C0 VA: 0x181299FC0
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|
	|-RVA: 0x129A410 Offset: 0x1298A10 VA: 0x18129A410
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x12993E0 Offset: 0x12979E0 VA: 0x1812993E0
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x1299740 Offset: 0x1297D40 VA: 0x181299740
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x12994D0 Offset: 0x1297AD0 VA: 0x1812994D0
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|-NativeArray<float3>.Copy
	|
	|-RVA: 0x1299920 Offset: 0x1297F20 VA: 0x181299920
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x12A0E20 Offset: 0x129F420 VA: 0x1812A0E20
	|-NativeArray<MeshGenerator.TessellationJobParameters>.Copy
	|
	|-RVA: 0x12A0FD0 Offset: 0x129F5D0 VA: 0x1812A0FD0
	|-NativeArray<SplineMesh.VertexData>.Copy
	*/

	// RVA: -1 Offset: -1
	private static void CopySafe(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1298DC0 Offset: 0x12973C0 VA: 0x181298DC0
	|-NativeArray<BatchCullingOutputDrawCommands>.CopySafe
	|
	|-RVA: 0x1297B80 Offset: 0x1296180 VA: 0x181297B80
	|-NativeArray<BezierCurve>.CopySafe
	|-NativeArray<CopyMeshJobData>.CopySafe
	|
	|-RVA: 0x1298A70 Offset: 0x1297070 VA: 0x181298A70
	|-NativeArray<BezierKnot>.CopySafe
	|
	|-RVA: 0x1297D00 Offset: 0x1296300 VA: 0x181297D00
	|-NativeArray<byte>.CopySafe
	|
	|-RVA: 0x1297A00 Offset: 0x1296000 VA: 0x181297A00
	|-NativeArray<Color>.CopySafe
	|-NativeArray<DrawBufferRange>.CopySafe
	|-NativeArray<GfxUpdateBufferRange>.CopySafe
	|-NativeArray<JobHandle>.CopySafe
	|-NativeArray<Plane>.CopySafe
	|-NativeArray<Quaternion>.CopySafe
	|-NativeArray<Painter2D.Painter2DJobData>.CopySafe
	|
	|-RVA: 0x1298D10 Offset: 0x1297310 VA: 0x181298D10
	|-NativeArray<ContactPairHeader>.CopySafe
	|
	|-RVA: 0x1298B10 Offset: 0x1297110 VA: 0x181298B10
	|-NativeArray<ConvertMeshJobData>.CopySafe
	|
	|-RVA: 0x1298560 Offset: 0x1296B60 VA: 0x181298560
	|-NativeArray<CullingSplit>.CopySafe
	|-NativeArray<LightDataGI>.CopySafe
	|-NativeArray<TileData>.CopySafe
	|
	|-RVA: 0x1298BC0 Offset: 0x12971C0 VA: 0x181298BC0
	|-NativeArray<DistanceToInterpolation>.CopySafe
	|
	|-RVA: 0x1298790 Offset: 0x1296D90 VA: 0x181298790
	|-NativeArray<int>.CopySafe
	|-NativeArray<float>.CopySafe
	|-NativeArray<uint>.CopySafe
	|
	|-RVA: 0x1298170 Offset: 0x1296770 VA: 0x181298170
	|-NativeArray<Matrix4x4>.CopySafe
	|-NativeArray<Vertex>.CopySafe
	|
	|-RVA: 0x1298C70 Offset: 0x1297270 VA: 0x181298C70
	|-NativeArray<ModifiableContactPair>.CopySafe
	|
	|-RVA: 0x1297DA0 Offset: 0x12963A0 VA: 0x181297DA0
	|-NativeArray<NudgeJobData>.CopySafe
	|
	|-RVA: 0x12986F0 Offset: 0x1296CF0 VA: 0x1812986F0
	|-NativeArray<ushort>.CopySafe
	|
	|-RVA: 0x1297880 Offset: 0x1295E80 VA: 0x181297880
	|-NativeArray<Vector3>.CopySafe
	|-NativeArray<Vector3Int>.CopySafe
	|-NativeArray<float3>.CopySafe
	|
	|-RVA: 0x1298840 Offset: 0x1296E40 VA: 0x181298840
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopySafe
	|
	|-RVA: 0x12A0BD0 Offset: 0x129F1D0 VA: 0x1812A0BD0
	|-NativeArray<MeshGenerator.TessellationJobParameters>.CopySafe
	|
	|-RVA: 0x12A0B30 Offset: 0x129F130 VA: 0x1812A0B30
	|-NativeArray<SplineMesh.VertexData>.CopySafe
	*/

	// RVA: -1 Offset: -1
	private static void CopySafe(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1298E60 Offset: 0x1297460 VA: 0x181298E60
	|-NativeArray<BatchCullingOutputDrawCommands>.CopySafe
	|
	|-RVA: 0x1298990 Offset: 0x1296F90 VA: 0x181298990
	|-NativeArray<BezierCurve>.CopySafe
	|-NativeArray<CopyMeshJobData>.CopySafe
	|
	|-RVA: 0x1298F30 Offset: 0x1297530 VA: 0x181298F30
	|-NativeArray<BezierKnot>.CopySafe
	|
	|-RVA: 0x12976E0 Offset: 0x1295CE0 VA: 0x1812976E0
	|-NativeArray<byte>.CopySafe
	|
	|-RVA: 0x1297C30 Offset: 0x1296230 VA: 0x181297C30
	|-NativeArray<Color>.CopySafe
	|-NativeArray<DrawBufferRange>.CopySafe
	|-NativeArray<GfxUpdateBufferRange>.CopySafe
	|-NativeArray<JobHandle>.CopySafe
	|-NativeArray<Plane>.CopySafe
	|-NativeArray<Quaternion>.CopySafe
	|-NativeArray<Painter2D.Painter2DJobData>.CopySafe
	|
	|-RVA: 0x12977A0 Offset: 0x1295DA0 VA: 0x1812977A0
	|-NativeArray<ContactPairHeader>.CopySafe
	|
	|-RVA: 0x1297FC0 Offset: 0x12965C0 VA: 0x181297FC0
	|-NativeArray<ConvertMeshJobData>.CopySafe
	|
	|-RVA: 0x1298090 Offset: 0x1296690 VA: 0x181298090
	|-NativeArray<CullingSplit>.CopySafe
	|-NativeArray<LightDataGI>.CopySafe
	|-NativeArray<TileData>.CopySafe
	|
	|-RVA: 0x1298480 Offset: 0x1296A80 VA: 0x181298480
	|-NativeArray<DistanceToInterpolation>.CopySafe
	|
	|-RVA: 0x1298610 Offset: 0x1296C10 VA: 0x181298610
	|-NativeArray<int>.CopySafe
	|-NativeArray<float>.CopySafe
	|-NativeArray<uint>.CopySafe
	|
	|-RVA: 0x12983B0 Offset: 0x12969B0 VA: 0x1812983B0
	|-NativeArray<Matrix4x4>.CopySafe
	|-NativeArray<Vertex>.CopySafe
	|
	|-RVA: 0x1297930 Offset: 0x1295F30 VA: 0x181297930
	|-NativeArray<ModifiableContactPair>.CopySafe
	|
	|-RVA: 0x12982E0 Offset: 0x12968E0 VA: 0x1812982E0
	|-NativeArray<NudgeJobData>.CopySafe
	|
	|-RVA: 0x1298210 Offset: 0x1296810 VA: 0x181298210
	|-NativeArray<ushort>.CopySafe
	|
	|-RVA: 0x1297AA0 Offset: 0x12960A0 VA: 0x181297AA0
	|-NativeArray<Vector3>.CopySafe
	|-NativeArray<Vector3Int>.CopySafe
	|-NativeArray<float3>.CopySafe
	|
	|-RVA: 0x1297E40 Offset: 0x1296440 VA: 0x181297E40
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopySafe
	|
	|-RVA: 0x12A0C80 Offset: 0x129F280 VA: 0x1812A0C80
	|-NativeArray<MeshGenerator.TessellationJobParameters>.CopySafe
	|
	|-RVA: 0x12A0D50 Offset: 0x129F350 VA: 0x1812A0D50
	|-NativeArray<SplineMesh.VertexData>.CopySafe
	*/

	// RVA: -1 Offset: -1
	private NativeArray<U> InternalReinterpret<U>(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x606AA0 Offset: 0x6050A0 VA: 0x180606AA0
	|-NativeArray<ushort>.InternalReinterpret<ushort>
	|-NativeArray<ushort>.InternalReinterpret<uint>
	|-NativeArray<uint>.InternalReinterpret<ushort>
	|-NativeArray<uint>.InternalReinterpret<uint>
	|
	|-RVA: 0x606A20 Offset: 0x605020 VA: 0x180606A20
	|-NativeArray<__Il2CppFullySharedGenericStructType>.InternalReinterpret<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public NativeArray<U> Reinterpret<U>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x606BE0 Offset: 0x6051E0 VA: 0x180606BE0
	|-NativeArray<ushort>.Reinterpret<ushort>
	|-NativeArray<ushort>.Reinterpret<uint>
	|-NativeArray<uint>.Reinterpret<ushort>
	|-NativeArray<uint>.Reinterpret<uint>
	|
	|-RVA: 0x606B20 Offset: 0x605120 VA: 0x180606B20
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Reinterpret<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public NativeArray.ReadOnly<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1297660 Offset: 0x1295C60 VA: 0x181297660
	|-NativeArray<BatchCullingOutputDrawCommands>.AsReadOnly
	|-NativeArray<BezierCurve>.AsReadOnly
	|-NativeArray<BezierKnot>.AsReadOnly
	|-NativeArray<byte>.AsReadOnly
	|-NativeArray<Color>.AsReadOnly
	|-NativeArray<ContactPairHeader>.AsReadOnly
	|-NativeArray<ConvertMeshJobData>.AsReadOnly
	|-NativeArray<CopyMeshJobData>.AsReadOnly
	|-NativeArray<CullingSplit>.AsReadOnly
	|-NativeArray<DistanceToInterpolation>.AsReadOnly
	|-NativeArray<DrawBufferRange>.AsReadOnly
	|-NativeArray<GfxUpdateBufferRange>.AsReadOnly
	|-NativeArray<int>.AsReadOnly
	|-NativeArray<JobHandle>.AsReadOnly
	|-NativeArray<LightDataGI>.AsReadOnly
	|-NativeArray<Matrix4x4>.AsReadOnly
	|-NativeArray<ModifiableContactPair>.AsReadOnly
	|-NativeArray<NudgeJobData>.AsReadOnly
	|-NativeArray<Plane>.AsReadOnly
	|-NativeArray<Quaternion>.AsReadOnly
	|-NativeArray<float>.AsReadOnly
	|-NativeArray<TileData>.AsReadOnly
	|-NativeArray<ushort>.AsReadOnly
	|-NativeArray<uint>.AsReadOnly
	|-NativeArray<Vector3>.AsReadOnly
	|-NativeArray<Vector3Int>.AsReadOnly
	|-NativeArray<Vertex>.AsReadOnly
	|-NativeArray<__Il2CppFullySharedGenericStructType>.AsReadOnly
	|-NativeArray<float3>.AsReadOnly
	|-NativeArray<MeshGenerator.TessellationJobParameters>.AsReadOnly
	|-NativeArray<Painter2D.Painter2DJobData>.AsReadOnly
	|-NativeArray<SplineMesh.VertexData>.AsReadOnly
	*/
}

// Namespace: Unity.Collections
[NativeContainer]
internal struct NativeArrayDispose // TypeDefIndex: 9464
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal void* m_Buffer; // 0x0
	internal Allocator m_AllocatorLabel; // 0x8

	// Methods

	// RVA: 0x230D9D0 Offset: 0x230BFD0 VA: 0x18230D9D0
	public void Dispose() { }
}

// Namespace: Unity.Collections
[NativeClass(null)]
internal struct NativeArrayDisposeJob : IJob // TypeDefIndex: 9465
{
	// Fields
	internal NativeArrayDispose Data; // 0x0

	// Methods

	// RVA: 0x230D9D0 Offset: 0x230BFD0 VA: 0x18230D9D0 Slot: 4
	public void Execute() { }

	[RequiredByNativeCode]
	// RVA: 0x230DA20 Offset: 0x230C020 VA: 0x18230DA20
	internal static void RegisterNativeArrayDisposeJobReflectionData() { }
}

// Namespace: Unity.Collections
internal sealed class NativeArrayDebugView<T> // TypeDefIndex: 9466
{}

// Namespace: Unity.Collections
internal sealed class NativeArrayReadOnlyDebugView<T> // TypeDefIndex: 9467
{}

// Namespace: Unity.Collections
[Extension]
public static class NativeSliceExtensions // TypeDefIndex: 9468
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x737DA0 Offset: 0x7363A0 VA: 0x180737DA0
	|-NativeSliceExtensions.Slice<ConvertMeshJobData>
	|
	|-RVA: 0x737E40 Offset: 0x736440 VA: 0x180737E40
	|-NativeSliceExtensions.Slice<CopyMeshJobData>
	|
	|-RVA: 0x737EE0 Offset: 0x7364E0 VA: 0x180737EE0
	|-NativeSliceExtensions.Slice<DrawBufferRange>
	|-NativeSliceExtensions.Slice<GfxUpdateBufferRange>
	|-NativeSliceExtensions.Slice<JobHandle>
	|-NativeSliceExtensions.Slice<Painter2D.Painter2DJobData>
	|
	|-RVA: 0x7380C0 Offset: 0x7366C0 VA: 0x1807380C0
	|-NativeSliceExtensions.Slice<NudgeJobData>
	|
	|-RVA: 0x738200 Offset: 0x736800 VA: 0x180738200
	|-NativeSliceExtensions.Slice<ushort>
	|
	|-RVA: 0x7382A0 Offset: 0x7368A0 VA: 0x1807382A0
	|-NativeSliceExtensions.Slice<Vertex>
	|
	|-RVA: 0x738020 Offset: 0x736620 VA: 0x180738020
	|-NativeSliceExtensions.Slice<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x738160 Offset: 0x736760 VA: 0x180738160
	|-NativeSliceExtensions.Slice<MeshGenerator.TessellationJobParameters>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x737F80 Offset: 0x736580 VA: 0x180737F80
	|-NativeSliceExtensions.Slice<ushort>
	|-NativeSliceExtensions.Slice<Vertex>
	|-NativeSliceExtensions.Slice<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: Unity.Collections
[NativeContainer]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(NativeSliceDebugView<T>))]
[DebuggerDisplay("Length = {Length}")]
[NativeContainerSupportsMinMaxWriteRestriction]
public struct NativeSlice<T> : IEnumerable<T>, IEnumerable, IEquatable<NativeSlice<T>> // TypeDefIndex: 9470
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal byte* m_Buffer; // 0x0
	internal int m_Stride; // 0x0
	internal int m_Length; // 0x0

	// Properties
	public T Item { get; set; }
	public int Stride { get; }
	public int Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NativeSlice<T> slice, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A59F0 Offset: 0x12A3FF0 VA: 0x1812A59F0
	|-NativeSlice<ConvertMeshJobData>..ctor
	|-NativeSlice<CopyMeshJobData>..ctor
	|-NativeSlice<DistanceToInterpolation>..ctor
	|-NativeSlice<DrawBufferRange>..ctor
	|-NativeSlice<GfxUpdateBufferRange>..ctor
	|-NativeSlice<JobHandle>..ctor
	|-NativeSlice<NudgeJobData>..ctor
	|-NativeSlice<ushort>..ctor
	|-NativeSlice<Vertex>..ctor
	|-NativeSlice<__Il2CppFullySharedGenericStructType>..ctor
	|-NativeSlice<MeshGenerator.TessellationJobParameters>..ctor
	|-NativeSlice<Painter2D.Painter2DJobData>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A60E0 Offset: 0x12A46E0 VA: 0x1812A60E0
	|-NativeSlice<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x12A5C70 Offset: 0x12A4270 VA: 0x1812A5C70
	|-NativeSlice<CopyMeshJobData>..ctor
	|
	|-RVA: 0x12A5AF0 Offset: 0x12A40F0 VA: 0x1812A5AF0
	|-NativeSlice<DistanceToInterpolation>..ctor
	|
	|-RVA: 0x12A5A10 Offset: 0x12A4010 VA: 0x1812A5A10
	|-NativeSlice<DrawBufferRange>..ctor
	|-NativeSlice<GfxUpdateBufferRange>..ctor
	|-NativeSlice<JobHandle>..ctor
	|-NativeSlice<Painter2D.Painter2DJobData>..ctor
	|
	|-RVA: 0x12A6000 Offset: 0x12A4600 VA: 0x1812A6000
	|-NativeSlice<NudgeJobData>..ctor
	|
	|-RVA: 0x12A5B60 Offset: 0x12A4160 VA: 0x1812A5B60
	|-NativeSlice<ushort>..ctor
	|
	|-RVA: 0x12A5A80 Offset: 0x12A4080 VA: 0x1812A5A80
	|-NativeSlice<Vertex>..ctor
	|
	|-RVA: 0x12A5D50 Offset: 0x12A4350 VA: 0x1812A5D50
	|-NativeSlice<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x12A61C0 Offset: 0x12A47C0 VA: 0x1812A61C0
	|-NativeSlice<MeshGenerator.TessellationJobParameters>..ctor
	*/

	// RVA: -1 Offset: -1
	public static NativeSlice<T> op_Implicit(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A6B70 Offset: 0x12A5170 VA: 0x1812A6B70
	|-NativeSlice<ConvertMeshJobData>.op_Implicit
	|
	|-RVA: 0x12A6AD0 Offset: 0x12A50D0 VA: 0x1812A6AD0
	|-NativeSlice<CopyMeshJobData>.op_Implicit
	|
	|-RVA: 0x12A6C10 Offset: 0x12A5210 VA: 0x1812A6C10
	|-NativeSlice<DistanceToInterpolation>.op_Implicit
	|
	|-RVA: 0x12A6A30 Offset: 0x12A5030 VA: 0x1812A6A30
	|-NativeSlice<DrawBufferRange>.op_Implicit
	|-NativeSlice<GfxUpdateBufferRange>.op_Implicit
	|-NativeSlice<JobHandle>.op_Implicit
	|-NativeSlice<Painter2D.Painter2DJobData>.op_Implicit
	|
	|-RVA: 0x12A6850 Offset: 0x12A4E50 VA: 0x1812A6850
	|-NativeSlice<NudgeJobData>.op_Implicit
	|
	|-RVA: 0x12A68F0 Offset: 0x12A4EF0 VA: 0x1812A68F0
	|-NativeSlice<ushort>.op_Implicit
	|
	|-RVA: 0x12A6CB0 Offset: 0x12A52B0 VA: 0x1812A6CB0
	|-NativeSlice<Vertex>.op_Implicit
	|
	|-RVA: 0x12A6D50 Offset: 0x12A5350 VA: 0x1812A6D50
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.op_Implicit
	|
	|-RVA: 0x12A6990 Offset: 0x12A4F90 VA: 0x1812A6990
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A6150 Offset: 0x12A4750 VA: 0x1812A6150
	|-NativeSlice<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x12A5CE0 Offset: 0x12A42E0 VA: 0x1812A5CE0
	|-NativeSlice<CopyMeshJobData>..ctor
	|
	|-RVA: 0x12A5F90 Offset: 0x12A4590 VA: 0x1812A5F90
	|-NativeSlice<DistanceToInterpolation>..ctor
	|
	|-RVA: 0x12A5F20 Offset: 0x12A4520 VA: 0x1812A5F20
	|-NativeSlice<DrawBufferRange>..ctor
	|-NativeSlice<GfxUpdateBufferRange>..ctor
	|-NativeSlice<JobHandle>..ctor
	|-NativeSlice<Painter2D.Painter2DJobData>..ctor
	|
	|-RVA: 0x12A6070 Offset: 0x12A4670 VA: 0x1812A6070
	|-NativeSlice<NudgeJobData>..ctor
	|
	|-RVA: 0x12A5EB0 Offset: 0x12A44B0 VA: 0x1812A5EB0
	|-NativeSlice<ushort>..ctor
	|
	|-RVA: 0x12A5980 Offset: 0x12A3F80 VA: 0x1812A5980
	|-NativeSlice<Vertex>..ctor
	|
	|-RVA: 0x12A5BD0 Offset: 0x12A41D0 VA: 0x1812A5BD0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x12A5E40 Offset: 0x12A4440 VA: 0x1812A5E40
	|-NativeSlice<MeshGenerator.TessellationJobParameters>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A63A0 Offset: 0x12A49A0 VA: 0x1812A63A0
	|-NativeSlice<ConvertMeshJobData>.get_Item
	|
	|-RVA: 0x12A6320 Offset: 0x12A4920 VA: 0x1812A6320
	|-NativeSlice<CopyMeshJobData>.get_Item
	|
	|-RVA: 0x12A6640 Offset: 0x12A4C40 VA: 0x1812A6640
	|-NativeSlice<DistanceToInterpolation>.get_Item
	|
	|-RVA: 0x12A62C0 Offset: 0x12A48C0 VA: 0x1812A62C0
	|-NativeSlice<DrawBufferRange>.get_Item
	|-NativeSlice<GfxUpdateBufferRange>.get_Item
	|-NativeSlice<JobHandle>.get_Item
	|-NativeSlice<Painter2D.Painter2DJobData>.get_Item
	|
	|-RVA: 0x12A66A0 Offset: 0x12A4CA0 VA: 0x1812A66A0
	|-NativeSlice<NudgeJobData>.get_Item
	|
	|-RVA: 0x12A6480 Offset: 0x12A4A80 VA: 0x1812A6480
	|-NativeSlice<ushort>.get_Item
	|
	|-RVA: 0x12A6230 Offset: 0x12A4830 VA: 0x1812A6230
	|-NativeSlice<Vertex>.get_Item
	|
	|-RVA: 0x12A64D0 Offset: 0x12A4AD0 VA: 0x1812A64D0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.get_Item
	|
	|-RVA: 0x12A6750 Offset: 0x12A4D50 VA: 0x1812A6750
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.get_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A6F70 Offset: 0x12A5570 VA: 0x1812A6F70
	|-NativeSlice<ConvertMeshJobData>.set_Item
	|
	|-RVA: 0x12A6E70 Offset: 0x12A5470 VA: 0x1812A6E70
	|-NativeSlice<CopyMeshJobData>.set_Item
	|
	|-RVA: 0x12A7290 Offset: 0x12A5890 VA: 0x1812A7290
	|-NativeSlice<DistanceToInterpolation>.set_Item
	|
	|-RVA: 0x12A6DB0 Offset: 0x12A53B0 VA: 0x1812A6DB0
	|-NativeSlice<DrawBufferRange>.set_Item
	|-NativeSlice<GfxUpdateBufferRange>.set_Item
	|-NativeSlice<JobHandle>.set_Item
	|-NativeSlice<Painter2D.Painter2DJobData>.set_Item
	|
	|-RVA: 0x12A6EE0 Offset: 0x12A54E0 VA: 0x1812A6EE0
	|-NativeSlice<NudgeJobData>.set_Item
	|
	|-RVA: 0x12A6E10 Offset: 0x12A5410 VA: 0x1812A6E10
	|-NativeSlice<ushort>.set_Item
	|
	|-RVA: 0x12A7100 Offset: 0x12A5700 VA: 0x1812A7100
	|-NativeSlice<Vertex>.set_Item
	|
	|-RVA: 0x12A7180 Offset: 0x12A5780 VA: 0x1812A7180
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.set_Item
	|
	|-RVA: 0x12A7030 Offset: 0x12A5630 VA: 0x1812A7030
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.set_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void CopyFrom(NativeSlice<T> slice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A4A50 Offset: 0x12A3050 VA: 0x1812A4A50
	|-NativeSlice<ConvertMeshJobData>.CopyFrom
	|
	|-RVA: 0x12A4ED0 Offset: 0x12A34D0 VA: 0x1812A4ED0
	|-NativeSlice<CopyMeshJobData>.CopyFrom
	|
	|-RVA: 0x12A4DB0 Offset: 0x12A33B0 VA: 0x1812A4DB0
	|-NativeSlice<DistanceToInterpolation>.CopyFrom
	|
	|-RVA: 0x12A4C90 Offset: 0x12A3290 VA: 0x1812A4C90
	|-NativeSlice<DrawBufferRange>.CopyFrom
	|-NativeSlice<GfxUpdateBufferRange>.CopyFrom
	|-NativeSlice<JobHandle>.CopyFrom
	|-NativeSlice<Painter2D.Painter2DJobData>.CopyFrom
	|
	|-RVA: 0x12A4B70 Offset: 0x12A3170 VA: 0x1812A4B70
	|-NativeSlice<NudgeJobData>.CopyFrom
	|
	|-RVA: 0x12A5310 Offset: 0x12A3910 VA: 0x1812A5310
	|-NativeSlice<ushort>.CopyFrom
	|
	|-RVA: 0x12A4930 Offset: 0x12A2F30 VA: 0x1812A4930
	|-NativeSlice<Vertex>.CopyFrom
	|
	|-RVA: 0x12A5110 Offset: 0x12A3710 VA: 0x1812A5110
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.CopyFrom
	|
	|-RVA: 0x12A4FF0 Offset: 0x12A35F0 VA: 0x1812A4FF0
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public int get_Stride() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	|-NativeSlice<ConvertMeshJobData>.get_Stride
	|-NativeSlice<CopyMeshJobData>.get_Stride
	|-NativeSlice<DistanceToInterpolation>.get_Stride
	|-NativeSlice<DrawBufferRange>.get_Stride
	|-NativeSlice<GfxUpdateBufferRange>.get_Stride
	|-NativeSlice<JobHandle>.get_Stride
	|-NativeSlice<NudgeJobData>.get_Stride
	|-NativeSlice<ushort>.get_Stride
	|-NativeSlice<Vertex>.get_Stride
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.get_Stride
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.get_Stride
	|-NativeSlice<Painter2D.Painter2DJobData>.get_Stride
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A6840 Offset: 0x12A4E40 VA: 0x1812A6840
	|-NativeSlice<ConvertMeshJobData>.get_Length
	|-NativeSlice<CopyMeshJobData>.get_Length
	|-NativeSlice<DistanceToInterpolation>.get_Length
	|-NativeSlice<DrawBufferRange>.get_Length
	|-NativeSlice<GfxUpdateBufferRange>.get_Length
	|-NativeSlice<JobHandle>.get_Length
	|-NativeSlice<NudgeJobData>.get_Length
	|-NativeSlice<ushort>.get_Length
	|-NativeSlice<Vertex>.get_Length
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.get_Length
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.get_Length
	|-NativeSlice<Painter2D.Painter2DJobData>.get_Length
	*/

	// RVA: -1 Offset: -1
	public NativeSlice.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A56C0 Offset: 0x12A3CC0 VA: 0x1812A56C0
	|-NativeSlice<ConvertMeshJobData>.GetEnumerator
	|-NativeSlice<CopyMeshJobData>.GetEnumerator
	|-NativeSlice<DistanceToInterpolation>.GetEnumerator
	|-NativeSlice<DrawBufferRange>.GetEnumerator
	|-NativeSlice<GfxUpdateBufferRange>.GetEnumerator
	|-NativeSlice<JobHandle>.GetEnumerator
	|-NativeSlice<NudgeJobData>.GetEnumerator
	|-NativeSlice<ushort>.GetEnumerator
	|-NativeSlice<Vertex>.GetEnumerator
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.GetEnumerator
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.GetEnumerator
	|-NativeSlice<Painter2D.Painter2DJobData>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A5760 Offset: 0x12A3D60 VA: 0x1812A5760
	|-NativeSlice<ConvertMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<CopyMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<DistanceToInterpolation>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<DrawBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<GfxUpdateBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<JobHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<NudgeJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Vertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Painter2D.Painter2DJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A5800 Offset: 0x12A3E00 VA: 0x1812A5800
	|-NativeSlice<ConvertMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<CopyMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<DistanceToInterpolation>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<DrawBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<GfxUpdateBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<JobHandle>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<NudgeJobData>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<ushort>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Vertex>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Painter2D.Painter2DJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x12A58C0 Offset: 0x12A3EC0 VA: 0x1812A58C0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(NativeSlice<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A5430 Offset: 0x12A3A30 VA: 0x1812A5430
	|-NativeSlice<ConvertMeshJobData>.Equals
	|-NativeSlice<CopyMeshJobData>.Equals
	|-NativeSlice<DistanceToInterpolation>.Equals
	|-NativeSlice<DrawBufferRange>.Equals
	|-NativeSlice<GfxUpdateBufferRange>.Equals
	|-NativeSlice<JobHandle>.Equals
	|-NativeSlice<NudgeJobData>.Equals
	|-NativeSlice<ushort>.Equals
	|-NativeSlice<Vertex>.Equals
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.Equals
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.Equals
	|-NativeSlice<Painter2D.Painter2DJobData>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A5450 Offset: 0x12A3A50 VA: 0x1812A5450
	|-NativeSlice<ConvertMeshJobData>.Equals
	|-NativeSlice<CopyMeshJobData>.Equals
	|-NativeSlice<DistanceToInterpolation>.Equals
	|-NativeSlice<DrawBufferRange>.Equals
	|-NativeSlice<GfxUpdateBufferRange>.Equals
	|-NativeSlice<JobHandle>.Equals
	|-NativeSlice<NudgeJobData>.Equals
	|-NativeSlice<ushort>.Equals
	|-NativeSlice<Vertex>.Equals
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.Equals
	|-NativeSlice<Painter2D.Painter2DJobData>.Equals
	|
	|-RVA: 0x12A5570 Offset: 0x12A3B70 VA: 0x1812A5570
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A5740 Offset: 0x12A3D40 VA: 0x1812A5740
	|-NativeSlice<ConvertMeshJobData>.GetHashCode
	|-NativeSlice<CopyMeshJobData>.GetHashCode
	|-NativeSlice<DistanceToInterpolation>.GetHashCode
	|-NativeSlice<DrawBufferRange>.GetHashCode
	|-NativeSlice<GfxUpdateBufferRange>.GetHashCode
	|-NativeSlice<JobHandle>.GetHashCode
	|-NativeSlice<NudgeJobData>.GetHashCode
	|-NativeSlice<ushort>.GetHashCode
	|-NativeSlice<Vertex>.GetHashCode
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.GetHashCode
	|-NativeSlice<MeshGenerator.TessellationJobParameters>.GetHashCode
	|-NativeSlice<Painter2D.Painter2DJobData>.GetHashCode
	*/
}

// Namespace: Unity.Collections
internal sealed class NativeSliceDebugView<T> // TypeDefIndex: 9471
{}

