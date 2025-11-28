// Namespace: Unity.Collections.LowLevel.Unsafe
[StaticAccessor("BurstLike", 2)]
[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
[NativeHeader("Runtime/Export/BurstLike/BurstLike.bindings.h")]
internal static class BurstLike // TypeDefIndex: 9474
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
internal static class BurstRuntime // TypeDefIndex: 9476
{
	// Methods

	// RVA: -1 Offset: -1
	public static long GetHashCode64<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B2F70 Offset: 0x6B1570 VA: 0x1806B2F70
	|-BurstRuntime.GetHashCode64<IJobExtensions.JobStruct<NativeArrayDisposeJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForExtensions.ParallelForJobStruct<GetPosition>>
	|-BurstRuntime.GetHashCode64<IJobParallelForExtensions.ParallelForJobStruct<GetPositionTangentNormal>>
	|-BurstRuntime.GetHashCode64<IJobParallelForExtensions.ParallelForJobStruct<MeshGenerator.TessellationJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForExtensions.ParallelForJobStruct<OpacityIdAccelerator.OpacityIdUpdateJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForExtensions.ParallelForJobStruct<Painter2D.Painter2DJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForExtensions.ParallelForJobStruct<UITKTextJobSystem.GenerateTextJobData>>
	|-BurstRuntime.GetHashCode64<IJobParallelForExtensions.ParallelForJobStruct<UITKTextJobSystem.PrepareTextJobData>>
	|-BurstRuntime.GetHashCode64<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22F25D0 Offset: 0x22F0BD0 VA: 0x1822F25D0
	internal static long HashStringWithFNV1A64(string text) { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerAttribute : Attribute // TypeDefIndex: 9477
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(8)]
public sealed class NativeContainerIsReadOnlyAttribute : Attribute // TypeDefIndex: 9478
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(8)]
public sealed class NativeContainerIsAtomicWriteOnlyAttribute : Attribute // TypeDefIndex: 9479
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute // TypeDefIndex: 9480
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(8)]
public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute // TypeDefIndex: 9481
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerSupportsDeferredConvertListToArray : Attribute // TypeDefIndex: 9482
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(256)]
[RequiredByNativeCode]
public sealed class NativeSetThreadIndexAttribute : Attribute // TypeDefIndex: 9483
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Obsolete("Use NativeSetThreadIndexAttribute instead")]
[Usage(8)]
public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute // TypeDefIndex: 9484
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(192)]
public class WriteAccessRequiredAttribute : Attribute // TypeDefIndex: 9485
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(256)]
[RequiredByNativeCode]
public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute // TypeDefIndex: 9486
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeDisableContainerSafetyRestrictionAttribute : Attribute // TypeDefIndex: 9487
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(256)]
[RequiredByNativeCode]
public sealed class NativeSetClassTypeToNullOnScheduleAttribute : Attribute // TypeDefIndex: 9488
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Extension]
public static class NativeArrayUnsafeUtility // TypeDefIndex: 9489
{
	// Methods

	// RVA: -1 Offset: -1
	public static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x737D60 Offset: 0x736360 VA: 0x180737D60
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BatchCullingOutputDrawCommands>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Color>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ContactPairHeader>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<CullingSplit>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightDataGI>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ModifiableContactPair>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Plane>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Quaternion>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<TileData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ushort>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<uint>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector3>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector3Int>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vertex>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<__Il2CppFullySharedGenericStructType>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<SplineMesh.VertexData>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x737D90 Offset: 0x736390 VA: 0x180737D90
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<BezierCurve>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<byte>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<JobHandle>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<float>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ushort>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<Vertex>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Extension]
public static class NativeSliceUnsafeUtility // TypeDefIndex: 9490
{
	// Methods

	// RVA: -1 Offset: -1
	public static NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x738340 Offset: 0x736940 VA: 0x180738340
	|-NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<DrawBufferRange>
	|-NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<ushort>
	|-NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<Vertex>
	|-NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeSlice<T> nativeSlice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x737D90 Offset: 0x736390 VA: 0x180737D90
	|-NativeSliceUnsafeUtility.GetUnsafePtr<ConvertMeshJobData>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<CopyMeshJobData>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<DistanceToInterpolation>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<DrawBufferRange>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<GfxUpdateBufferRange>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<JobHandle>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<NudgeJobData>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<ushort>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<Vertex>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<__Il2CppFullySharedGenericStructType>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<MeshGenerator.TessellationJobParameters>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<Painter2D.Painter2DJobData>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeSlice<T> nativeSlice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x737D90 Offset: 0x736390 VA: 0x180737D90
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<ConvertMeshJobData>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<CopyMeshJobData>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<DistanceToInterpolation>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<DrawBufferRange>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<GfxUpdateBufferRange>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<JobHandle>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<NudgeJobData>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<ushort>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<Vertex>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<__Il2CppFullySharedGenericStructType>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<MeshGenerator.TessellationJobParameters>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<Painter2D.Painter2DJobData>
	*/
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[StaticAccessor("UnsafeUtility", 2)]
[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
public static class UnsafeUtility // TypeDefIndex: 9492
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80EA60 Offset: 0x80D060 VA: 0x18080EA60
	|-UnsafeUtility.IsBlittable<__Il2CppFullySharedGenericStructType>
	|-UnsafeUtility.IsBlittable<GrassChunkManager.GrassData>
	*/

	[VisibleToOtherModules(new[] { "UnityEngine.AIModule" })]
	[ThreadSafe(ThrowsException = False)]
	[BurstAuthorizedExternalMethod]
	// RVA: 0x2314EC0 Offset: 0x23134C0 VA: 0x182314EC0
	internal static int LeakErase(IntPtr handle, LeakCategory category) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2314F00 Offset: 0x2313500 VA: 0x182314F00
	public static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2314AA0 Offset: 0x23130A0 VA: 0x182314AA0
	public static void FreeTracked(void* memory, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2314F60 Offset: 0x2313560 VA: 0x182314F60
	public static void* Malloc(long size, int alignment, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2314AE0 Offset: 0x23130E0 VA: 0x182314AE0
	public static void Free(void* memory, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2315060 Offset: 0x2313660 VA: 0x182315060
	public static void MemCpy(void* destination, void* source, long size) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2315000 Offset: 0x2313600 VA: 0x182315000
	public static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x23150C0 Offset: 0x23136C0 VA: 0x1823150C0
	public static void MemMove(void* destination, void* source, long size) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2315120 Offset: 0x2313720 VA: 0x182315120
	public static void MemSet(void* destination, byte value, long size) { }

	// RVA: 0x2314FB0 Offset: 0x23135B0 VA: 0x182314FB0
	public static void MemClear(void* destination, long size) { }

	[ThreadSafe]
	// RVA: 0x2315180 Offset: 0x2313780 VA: 0x182315180
	public static int SizeOf(Type type) { }

	[ThreadSafe]
	// RVA: 0x2314E80 Offset: 0x2313480 VA: 0x182314E80
	public static bool IsBlittable(Type type) { }

	// RVA: 0x2314E20 Offset: 0x2313420 VA: 0x182314E20
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x2314B90 Offset: 0x2313190 VA: 0x182314B90
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x2314D90 Offset: 0x2313390 VA: 0x182314D90
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static bool IsGenericListBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80EB10 Offset: 0x80D110 VA: 0x18080EB10
	|-UnsafeUtility.IsGenericListBlittable<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x80EAB0 Offset: 0x80D0B0 VA: 0x18080EAB0
	|-UnsafeUtility.IsGenericListBlittable<GrassChunkManager.GrassData>
	*/

	// RVA: 0x2314B20 Offset: 0x2313120 VA: 0x182314B20
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static string GetReasonForGenericListNonBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80E9D0 Offset: 0x80CFD0 VA: 0x18080E9D0
	|-UnsafeUtility.GetReasonForGenericListNonBlittable<__Il2CppFullySharedGenericStructType>
	|-UnsafeUtility.GetReasonForGenericListNonBlittable<GrassChunkManager.GrassData>
	*/

	// RVA: -1 Offset: -1
	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80E790 Offset: 0x80CD90 VA: 0x18080E790
	|-UnsafeUtility.AlignOf<BatchCullingOutputDrawCommands>
	|-UnsafeUtility.AlignOf<ContactPairHeader>
	|-UnsafeUtility.AlignOf<ConvertMeshJobData>
	|-UnsafeUtility.AlignOf<CopyMeshJobData>
	|-UnsafeUtility.AlignOf<GfxUpdateBufferRange>
	|-UnsafeUtility.AlignOf<IntPtr>
	|-UnsafeUtility.AlignOf<JobHandle>
	|-UnsafeUtility.AlignOf<ModifiableContactPair>
	|-UnsafeUtility.AlignOf<NudgeJobData>
	|-UnsafeUtility.AlignOf<LayoutDataStore.Chunk>
	|-UnsafeUtility.AlignOf<LayoutDataStore.ComponentDataStore>
	|-UnsafeUtility.AlignOf<LayoutDataStore.Data>
	|-UnsafeUtility.AlignOf<MeshGenerator.TessellationJobParameters>
	|-UnsafeUtility.AlignOf<Painter2D.Painter2DJobData>
	|
	|-RVA: 0x6B9F70 Offset: 0x6B8570 VA: 0x1806B9F70
	|-UnsafeUtility.AlignOf<BezierCurve>
	|-UnsafeUtility.AlignOf<BezierKnot>
	|-UnsafeUtility.AlignOf<Color>
	|-UnsafeUtility.AlignOf<CullingSplit>
	|-UnsafeUtility.AlignOf<DistanceToInterpolation>
	|-UnsafeUtility.AlignOf<DrawBufferRange>
	|-UnsafeUtility.AlignOf<int>
	|-UnsafeUtility.AlignOf<LightDataGI>
	|-UnsafeUtility.AlignOf<Matrix4x4>
	|-UnsafeUtility.AlignOf<Plane>
	|-UnsafeUtility.AlignOf<Quaternion>
	|-UnsafeUtility.AlignOf<float>
	|-UnsafeUtility.AlignOf<TileData>
	|-UnsafeUtility.AlignOf<uint>
	|-UnsafeUtility.AlignOf<Vector3>
	|-UnsafeUtility.AlignOf<Vector3Int>
	|-UnsafeUtility.AlignOf<Vertex>
	|-UnsafeUtility.AlignOf<float3>
	|-UnsafeUtility.AlignOf<SplineMesh.VertexData>
	|
	|-RVA: 0x80E7B0 Offset: 0x80CDB0 VA: 0x18080E7B0
	|-UnsafeUtility.AlignOf<byte>
	|
	|-RVA: 0x80E820 Offset: 0x80CE20 VA: 0x18080E820
	|-UnsafeUtility.AlignOf<ushort>
	|
	|-RVA: 0x80E7D0 Offset: 0x80CDD0 VA: 0x18080E7D0
	|-UnsafeUtility.AlignOf<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80EE30 Offset: 0x80D430 VA: 0x18080EE30
	|-UnsafeUtility.ReadArrayElement<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x80EE70 Offset: 0x80D470 VA: 0x18080EE70
	|-UnsafeUtility.ReadArrayElement<BezierCurve>
	|-UnsafeUtility.ReadArrayElement<CopyMeshJobData>
	|
	|-RVA: 0x80EEA0 Offset: 0x80D4A0 VA: 0x18080EEA0
	|-UnsafeUtility.ReadArrayElement<BezierKnot>
	|
	|-RVA: 0x80EED0 Offset: 0x80D4D0 VA: 0x18080EED0
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0x80EEE0 Offset: 0x80D4E0 VA: 0x18080EEE0
	|-UnsafeUtility.ReadArrayElement<Color>
	|-UnsafeUtility.ReadArrayElement<DrawBufferRange>
	|-UnsafeUtility.ReadArrayElement<GfxUpdateBufferRange>
	|-UnsafeUtility.ReadArrayElement<JobHandle>
	|-UnsafeUtility.ReadArrayElement<Plane>
	|-UnsafeUtility.ReadArrayElement<Quaternion>
	|-UnsafeUtility.ReadArrayElement<Painter2D.Painter2DJobData>
	|
	|-RVA: 0x80EF00 Offset: 0x80D500 VA: 0x18080EF00
	|-UnsafeUtility.ReadArrayElement<ContactPairHeader>
	|
	|-RVA: 0x80EF30 Offset: 0x80D530 VA: 0x18080EF30
	|-UnsafeUtility.ReadArrayElement<ConvertMeshJobData>
	|
	|-RVA: 0x80EFB0 Offset: 0x80D5B0 VA: 0x18080EFB0
	|-UnsafeUtility.ReadArrayElement<CullingSplit>
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|-UnsafeUtility.ReadArrayElement<TileData>
	|
	|-RVA: 0x80F000 Offset: 0x80D600 VA: 0x18080F000
	|-UnsafeUtility.ReadArrayElement<DistanceToInterpolation>
	|
	|-RVA: 0x80F0D0 Offset: 0x80D6D0 VA: 0x18080F0D0
	|-UnsafeUtility.ReadArrayElement<int>
	|-UnsafeUtility.ReadArrayElement<uint>
	|
	|-RVA: 0x80F0E0 Offset: 0x80D6E0 VA: 0x18080F0E0
	|-UnsafeUtility.ReadArrayElement<Matrix4x4>
	|-UnsafeUtility.ReadArrayElement<Vertex>
	|
	|-RVA: 0x80F110 Offset: 0x80D710 VA: 0x18080F110
	|-UnsafeUtility.ReadArrayElement<ModifiableContactPair>
	|
	|-RVA: 0x80F170 Offset: 0x80D770 VA: 0x18080F170
	|-UnsafeUtility.ReadArrayElement<NudgeJobData>
	|
	|-RVA: 0x80F1C0 Offset: 0x80D7C0 VA: 0x18080F1C0
	|-UnsafeUtility.ReadArrayElement<float>
	|
	|-RVA: 0x80F270 Offset: 0x80D870 VA: 0x18080F270
	|-UnsafeUtility.ReadArrayElement<ushort>
	|
	|-RVA: 0x80F280 Offset: 0x80D880 VA: 0x18080F280
	|-UnsafeUtility.ReadArrayElement<Vector3>
	|-UnsafeUtility.ReadArrayElement<Vector3Int>
	|-UnsafeUtility.ReadArrayElement<float3>
	|
	|-RVA: 0x80F020 Offset: 0x80D620 VA: 0x18080F020
	|-UnsafeUtility.ReadArrayElement<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x80F1D0 Offset: 0x80D7D0 VA: 0x18080F1D0
	|-UnsafeUtility.ReadArrayElement<MeshGenerator.TessellationJobParameters>
	|
	|-RVA: 0x80F2A0 Offset: 0x80D8A0 VA: 0x18080F2A0
	|-UnsafeUtility.ReadArrayElement<SplineMesh.VertexData>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElementWithStride<T>(void* source, int index, int stride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80EB40 Offset: 0x80D140 VA: 0x18080EB40
	|-UnsafeUtility.ReadArrayElementWithStride<ConvertMeshJobData>
	|
	|-RVA: 0x80EBC0 Offset: 0x80D1C0 VA: 0x18080EBC0
	|-UnsafeUtility.ReadArrayElementWithStride<CopyMeshJobData>
	|
	|-RVA: 0x80EBF0 Offset: 0x80D1F0 VA: 0x18080EBF0
	|-UnsafeUtility.ReadArrayElementWithStride<DistanceToInterpolation>
	|
	|-RVA: 0x80EC10 Offset: 0x80D210 VA: 0x18080EC10
	|-UnsafeUtility.ReadArrayElementWithStride<DrawBufferRange>
	|-UnsafeUtility.ReadArrayElementWithStride<GfxUpdateBufferRange>
	|-UnsafeUtility.ReadArrayElementWithStride<JobHandle>
	|-UnsafeUtility.ReadArrayElementWithStride<Painter2D.Painter2DJobData>
	|
	|-RVA: 0x80ECE0 Offset: 0x80D2E0 VA: 0x18080ECE0
	|-UnsafeUtility.ReadArrayElementWithStride<NudgeJobData>
	|
	|-RVA: 0x80EDE0 Offset: 0x80D3E0 VA: 0x18080EDE0
	|-UnsafeUtility.ReadArrayElementWithStride<ushort>
	|
	|-RVA: 0x80EDF0 Offset: 0x80D3F0 VA: 0x18080EDF0
	|-UnsafeUtility.ReadArrayElementWithStride<Vertex>
	|
	|-RVA: 0x80EC30 Offset: 0x80D230 VA: 0x18080EC30
	|-UnsafeUtility.ReadArrayElementWithStride<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x80ED40 Offset: 0x80D340 VA: 0x18080ED40
	|-UnsafeUtility.ReadArrayElementWithStride<MeshGenerator.TessellationJobParameters>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80F760 Offset: 0x80DD60 VA: 0x18080F760
	|-UnsafeUtility.WriteArrayElement<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x80F790 Offset: 0x80DD90 VA: 0x18080F790
	|-UnsafeUtility.WriteArrayElement<BezierCurve>
	|-UnsafeUtility.WriteArrayElement<CopyMeshJobData>
	|
	|-RVA: 0x80F7C0 Offset: 0x80DDC0 VA: 0x18080F7C0
	|-UnsafeUtility.WriteArrayElement<BezierKnot>
	|
	|-RVA: 0x80F7F0 Offset: 0x80DDF0 VA: 0x18080F7F0
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0x80F800 Offset: 0x80DE00 VA: 0x18080F800
	|-UnsafeUtility.WriteArrayElement<Color>
	|-UnsafeUtility.WriteArrayElement<DrawBufferRange>
	|-UnsafeUtility.WriteArrayElement<GfxUpdateBufferRange>
	|-UnsafeUtility.WriteArrayElement<JobHandle>
	|-UnsafeUtility.WriteArrayElement<Plane>
	|-UnsafeUtility.WriteArrayElement<Quaternion>
	|-UnsafeUtility.WriteArrayElement<Painter2D.Painter2DJobData>
	|
	|-RVA: 0x80F810 Offset: 0x80DE10 VA: 0x18080F810
	|-UnsafeUtility.WriteArrayElement<ContactPairHeader>
	|
	|-RVA: 0x80F840 Offset: 0x80DE40 VA: 0x18080F840
	|-UnsafeUtility.WriteArrayElement<ConvertMeshJobData>
	|
	|-RVA: 0x80F8D0 Offset: 0x80DED0 VA: 0x18080F8D0
	|-UnsafeUtility.WriteArrayElement<CullingSplit>
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|-UnsafeUtility.WriteArrayElement<TileData>
	|
	|-RVA: 0x80F920 Offset: 0x80DF20 VA: 0x18080F920
	|-UnsafeUtility.WriteArrayElement<DistanceToInterpolation>
	|
	|-RVA: 0x80FA20 Offset: 0x80E020 VA: 0x18080FA20
	|-UnsafeUtility.WriteArrayElement<int>
	|-UnsafeUtility.WriteArrayElement<uint>
	|
	|-RVA: 0x80FA30 Offset: 0x80E030 VA: 0x18080FA30
	|-UnsafeUtility.WriteArrayElement<Matrix4x4>
	|-UnsafeUtility.WriteArrayElement<Vertex>
	|
	|-RVA: 0x80FA60 Offset: 0x80E060 VA: 0x18080FA60
	|-UnsafeUtility.WriteArrayElement<ModifiableContactPair>
	|
	|-RVA: 0x80FAB0 Offset: 0x80E0B0 VA: 0x18080FAB0
	|-UnsafeUtility.WriteArrayElement<NudgeJobData>
	|
	|-RVA: 0x80FB00 Offset: 0x80E100 VA: 0x18080FB00
	|-UnsafeUtility.WriteArrayElement<float>
	|
	|-RVA: 0x80FBB0 Offset: 0x80E1B0 VA: 0x18080FBB0
	|-UnsafeUtility.WriteArrayElement<ushort>
	|
	|-RVA: 0x80FBC0 Offset: 0x80E1C0 VA: 0x18080FBC0
	|-UnsafeUtility.WriteArrayElement<Vector3>
	|-UnsafeUtility.WriteArrayElement<Vector3Int>
	|-UnsafeUtility.WriteArrayElement<float3>
	|
	|-RVA: 0x80F930 Offset: 0x80DF30 VA: 0x18080F930
	|-UnsafeUtility.WriteArrayElement<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x80FB10 Offset: 0x80E110 VA: 0x18080FB10
	|-UnsafeUtility.WriteArrayElement<MeshGenerator.TessellationJobParameters>
	|
	|-RVA: 0x80FBE0 Offset: 0x80E1E0 VA: 0x18080FBE0
	|-UnsafeUtility.WriteArrayElement<SplineMesh.VertexData>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80F420 Offset: 0x80DA20 VA: 0x18080F420
	|-UnsafeUtility.WriteArrayElementWithStride<ConvertMeshJobData>
	|
	|-RVA: 0x80F4B0 Offset: 0x80DAB0 VA: 0x18080F4B0
	|-UnsafeUtility.WriteArrayElementWithStride<CopyMeshJobData>
	|
	|-RVA: 0x80F4E0 Offset: 0x80DAE0 VA: 0x18080F4E0
	|-UnsafeUtility.WriteArrayElementWithStride<DistanceToInterpolation>
	|
	|-RVA: 0x80F4F0 Offset: 0x80DAF0 VA: 0x18080F4F0
	|-UnsafeUtility.WriteArrayElementWithStride<DrawBufferRange>
	|-UnsafeUtility.WriteArrayElementWithStride<GfxUpdateBufferRange>
	|-UnsafeUtility.WriteArrayElementWithStride<JobHandle>
	|-UnsafeUtility.WriteArrayElementWithStride<Painter2D.Painter2DJobData>
	|
	|-RVA: 0x80F610 Offset: 0x80DC10 VA: 0x18080F610
	|-UnsafeUtility.WriteArrayElementWithStride<NudgeJobData>
	|
	|-RVA: 0x80F710 Offset: 0x80DD10 VA: 0x18080F710
	|-UnsafeUtility.WriteArrayElementWithStride<ushort>
	|
	|-RVA: 0x80F720 Offset: 0x80DD20 VA: 0x18080F720
	|-UnsafeUtility.WriteArrayElementWithStride<Vertex>
	|
	|-RVA: 0x80F510 Offset: 0x80DB10 VA: 0x18080F510
	|-UnsafeUtility.WriteArrayElementWithStride<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x80F670 Offset: 0x80DC70 VA: 0x18080F670
	|-UnsafeUtility.WriteArrayElementWithStride<MeshGenerator.TessellationJobParameters>
	*/

	// RVA: -1 Offset: -1
	public static void* AddressOf<T>(ref T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-UnsafeUtility.AddressOf<GetPosition>
	|-UnsafeUtility.AddressOf<GetPositionTangentNormal>
	|-UnsafeUtility.AddressOf<__Il2CppFullySharedGenericStructType>
	|-UnsafeUtility.AddressOf<MeshGenerator.TessellationJob>
	|-UnsafeUtility.AddressOf<OpacityIdAccelerator.OpacityIdUpdateJob>
	|-UnsafeUtility.AddressOf<Painter2D.Painter2DJob>
	|-UnsafeUtility.AddressOf<UITKTextJobSystem.GenerateTextJobData>
	|-UnsafeUtility.AddressOf<UITKTextJobSystem.PrepareTextJobData>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44E5E0 Offset: 0x44CBE0 VA: 0x18044E5E0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchCullingOutputDrawCommands>>
	|-UnsafeUtility.SizeOf<Matrix4x4>
	|-UnsafeUtility.SizeOf<Vertex>
	|
	|-RVA: 0x80F330 Offset: 0x80D930 VA: 0x18080F330
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BezierCurve>>
	|-UnsafeUtility.SizeOf<BezierKnot>
	|
	|-RVA: 0x80F2F0 Offset: 0x80D8F0 VA: 0x18080F2F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BezierKnot>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<CopyMeshJobData>>
	|-UnsafeUtility.SizeOf<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|-UnsafeUtility.SizeOf<ushort>
	|
	|-RVA: 0x412DA0 Offset: 0x4113A0 VA: 0x180412DA0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Color>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<DrawBufferRange>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Quaternion>>
	|
	|-RVA: 0x80F2E0 Offset: 0x80D8E0 VA: 0x18080F2E0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ContactPairHeader>>
	|-UnsafeUtility.SizeOf<BezierCurve>
	|-UnsafeUtility.SizeOf<CopyMeshJobData>
	|-UnsafeUtility.SizeOf<LayoutStyleDimensionData>
	|
	|-RVA: 0x80F320 Offset: 0x80D920 VA: 0x18080F320
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ConvertMeshJobData>>
	|
	|-RVA: 0x429C80 Offset: 0x428280 VA: 0x180429C80
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<CullingSplit>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<TileData>>
	|
	|-RVA: 0x458FC0 Offset: 0x4575C0 VA: 0x180458FC0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<DistanceToInterpolation>>
	|-UnsafeUtility.SizeOf<Vector3>
	|-UnsafeUtility.SizeOf<Vector3Int>
	|-UnsafeUtility.SizeOf<float3>
	|
	|-RVA: 0x80F2C0 Offset: 0x80D8C0 VA: 0x18080F2C0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<GfxUpdateBufferRange>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<JobHandle>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Painter2D.Painter2DJobData>>
	|-UnsafeUtility.SizeOf<LayoutDataStore.ComponentDataStore>
	|
	|-RVA: 0x44F6B0 Offset: 0x44DCB0 VA: 0x18044F6B0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<uint>>
	|-UnsafeUtility.SizeOf<DistanceToInterpolation>
	|-UnsafeUtility.SizeOf<IntPtr>
	|-UnsafeUtility.SizeOf<LayoutHandle>
	|-UnsafeUtility.SizeOf<LayoutDataStore.Chunk>
	|
	|-RVA: 0x44EB70 Offset: 0x44D170 VA: 0x18044EB70
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<IntPtr>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector3>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector3Int>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float3>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LayoutDataStore.Chunk>>
	|-UnsafeUtility.SizeOf<LayoutList.Data<LayoutHandle>>
	|-UnsafeUtility.SizeOf<Color>
	|-UnsafeUtility.SizeOf<DrawBufferRange>
	|-UnsafeUtility.SizeOf<GfxUpdateBufferRange>
	|-UnsafeUtility.SizeOf<JobHandle>
	|-UnsafeUtility.SizeOf<Plane>
	|-UnsafeUtility.SizeOf<Quaternion>
	|-UnsafeUtility.SizeOf<Painter2D.Painter2DJobData>
	|
	|-RVA: 0x80F300 Offset: 0x80D900 VA: 0x18080F300
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Matrix4x4>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vertex>>
	|
	|-RVA: 0x80F340 Offset: 0x80D940 VA: 0x18080F340
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ModifiableContactPair>>
	|-UnsafeUtility.SizeOf<NudgeJobData>
	|
	|-RVA: 0x80F350 Offset: 0x80D950 VA: 0x18080F350
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<NudgeJobData>>
	|
	|-RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ushort>>
	|-UnsafeUtility.SizeOf<int>
	|-UnsafeUtility.SizeOf<LayoutConfigData>
	|-UnsafeUtility.SizeOf<float>
	|-UnsafeUtility.SizeOf<uint>
	|
	|-RVA: 0x44EB30 Offset: 0x44D130 VA: 0x18044EB30
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LayoutDataStore.ComponentDataStore>>
	|-UnsafeUtility.SizeOf<LayoutDataStore.Data>
	|-UnsafeUtility.SizeOf<SplineMesh.VertexData>
	|
	|-RVA: 0x5513C0 Offset: 0x54F9C0 VA: 0x1805513C0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LayoutDataStore.Data>>
	|-UnsafeUtility.SizeOf<ContactPairHeader>
	|
	|-RVA: 0x80F310 Offset: 0x80D910 VA: 0x18080F310
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<MeshGenerator.TessellationJobParameters>>
	|
	|-RVA: 0x80F2D0 Offset: 0x80D8D0 VA: 0x18080F2D0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<SplineMesh.VertexData>>
	|
	|-RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0x80F360 Offset: 0x80D960 VA: 0x18080F360
	|-UnsafeUtility.SizeOf<ConvertMeshJobData>
	|
	|-RVA: 0x80F370 Offset: 0x80D970 VA: 0x18080F370
	|-UnsafeUtility.SizeOf<CullingSplit>
	|-UnsafeUtility.SizeOf<LightDataGI>
	|-UnsafeUtility.SizeOf<TileData>
	|
	|-RVA: 0x80F3B0 Offset: 0x80D9B0 VA: 0x18080F3B0
	|-UnsafeUtility.SizeOf<LayoutCacheData>
	|
	|-RVA: 0x80F3C0 Offset: 0x80D9C0 VA: 0x18080F3C0
	|-UnsafeUtility.SizeOf<LayoutComputedData>
	|
	|-RVA: 0x80F3D0 Offset: 0x80D9D0 VA: 0x18080F3D0
	|-UnsafeUtility.SizeOf<LayoutNodeData>
	|
	|-RVA: 0x80F3E0 Offset: 0x80D9E0 VA: 0x18080F3E0
	|-UnsafeUtility.SizeOf<LayoutStyleBorderData>
	|-UnsafeUtility.SizeOf<LayoutStyleMarginData>
	|
	|-RVA: 0x80F3F0 Offset: 0x80D9F0 VA: 0x18080F3F0
	|-UnsafeUtility.SizeOf<LayoutStyleData>
	|
	|-RVA: 0x80F400 Offset: 0x80DA00 VA: 0x18080F400
	|-UnsafeUtility.SizeOf<ModifiableContactPair>
	|
	|-RVA: 0x80F380 Offset: 0x80D980 VA: 0x18080F380
	|-UnsafeUtility.SizeOf<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x80F410 Offset: 0x80DA10 VA: 0x18080F410
	|-UnsafeUtility.SizeOf<MeshGenerator.TessellationJobParameters>
	*/

	// RVA: -1 Offset: -1
	public static ref T As<U, T>(ref U from) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-UnsafeUtility.As<double, bool>
	|-UnsafeUtility.As<double, byte>
	|-UnsafeUtility.As<double, double>
	|-UnsafeUtility.As<double, short>
	|-UnsafeUtility.As<double, int>
	|-UnsafeUtility.As<double, long>
	|-UnsafeUtility.As<double, sbyte>
	|-UnsafeUtility.As<double, float>
	|-UnsafeUtility.As<double, ushort>
	|-UnsafeUtility.As<double, uint>
	|-UnsafeUtility.As<double, ulong>
	|-UnsafeUtility.As<int, double>
	|-UnsafeUtility.As<int, long>
	|-UnsafeUtility.As<int, ulong>
	|-UnsafeUtility.As<long, double>
	|-UnsafeUtility.As<long, int>
	|-UnsafeUtility.As<long, long>
	|-UnsafeUtility.As<long, float>
	|-UnsafeUtility.As<long, ulong>
	|-UnsafeUtility.As<IntPtr, GCHandle>
	|-UnsafeUtility.As<object, object>
	|-UnsafeUtility.As<float, double>
	|-UnsafeUtility.As<float, long>
	|-UnsafeUtility.As<float, ulong>
	|-UnsafeUtility.As<ulong, double>
	|-UnsafeUtility.As<ulong, int>
	|-UnsafeUtility.As<ulong, long>
	|-UnsafeUtility.As<ulong, float>
	|-UnsafeUtility.As<ulong, ulong>
	|-UnsafeUtility.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static T As<T>(object from) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-UnsafeUtility.As<object>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-UnsafeUtility.AsRef<IntPtr>
	|-UnsafeUtility.AsRef<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int EnumToInt<T>(T enumValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80E9B0 Offset: 0x80CFB0 VA: 0x18080E9B0
	|-UnsafeUtility.EnumToInt<Int32Enum>
	|
	|-RVA: 0x80E960 Offset: 0x80CF60 VA: 0x18080E960
	|-UnsafeUtility.EnumToInt<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x80EA50 Offset: 0x80D050 VA: 0x18080EA50
	|-UnsafeUtility.InternalEnumToInt<Int32Enum>
	|-UnsafeUtility.InternalEnumToInt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool EnumEquals<T>(T lhs, T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	|-UnsafeUtility.EnumEquals<Int32Enum>
	|
	|-RVA: 0x80E840 Offset: 0x80CE40 VA: 0x18080E840
	|-UnsafeUtility.EnumEquals<__Il2CppFullySharedGenericStructType>
	*/
}

