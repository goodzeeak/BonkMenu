// Namespace: Unity.Profiling.LowLevel.Unsafe
[IsReadOnly]
public struct ProfilerCategoryDescription // TypeDefIndex: 9436
{
	// Fields
	public readonly ushort Id; // 0x0
	public readonly ushort Flags; // 0x2
	public readonly Color32 Color; // 0x4
	private readonly int reserved0; // 0x8
	public readonly int NameUtf8Len; // 0xC
	public readonly byte* NameUtf8; // 0x10
}

// Namespace: Unity.Profiling.LowLevel.Unsafe
[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
[IgnoredByDeepProfiler]
[UsedByNativeCode]
public static class ProfilerUnsafeUtility // TypeDefIndex: 9437
{
	// Methods

	[ThreadSafe]
	// RVA: 0x230E050 Offset: 0x230C650 VA: 0x18230E050
	internal static ushort CreateCategory__Unmanaged(byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	[ThreadSafe]
	// RVA: 0x230E470 Offset: 0x230CA70 VA: 0x18230E470
	public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId) { }

	[ThreadSafe]
	// RVA: 0x230E240 Offset: 0x230C840 VA: 0x18230E240
	public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[ThreadSafe]
	// RVA: 0x230E1D0 Offset: 0x230C7D0 VA: 0x18230E1D0
	internal static IntPtr CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[ThreadSafe]
	// RVA: 0x230E4D0 Offset: 0x230CAD0 VA: 0x18230E4D0
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, byte* name, int nameLen, byte type, byte unit) { }

	[ThreadSafe]
	// RVA: 0x230E010 Offset: 0x230C610 VA: 0x18230E010
	public static void BeginSample(IntPtr markerPtr) { }

	[ThreadSafe]
	// RVA: 0x230E3E0 Offset: 0x230C9E0 VA: 0x18230E3E0
	public static void EndSample(IntPtr markerPtr) { }

	[ThreadSafe]
	// RVA: 0x230E0B0 Offset: 0x230C6B0 VA: 0x18230E0B0
	internal static void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	// RVA: 0x230E550 Offset: 0x230CB50 VA: 0x18230E550
	internal static string Utf8ToString(byte* chars, int charsLen) { }

	// RVA: 0x230E420 Offset: 0x230CA20 VA: 0x18230E420
	private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret) { }

	// RVA: 0x230E160 Offset: 0x230C760 VA: 0x18230E160
	private static IntPtr CreateMarker_Injected(ref ManagedSpanWrapper name, ushort categoryId, MarkerFlags flags, int metadataCount) { }
}

