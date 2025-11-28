// Namespace: Unity.Profiling.Memory
public class MemorySnapshotMetadata // TypeDefIndex: 9438
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x18

	// Properties
	public string Description { get; set; }
	internal byte[] Data { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal byte[] get_Data() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.Profiling.Memory
[NativeHeader("Modules/Profiler/Runtime/MemorySnapshotManager.h")]
public static class MemoryProfiler // TypeDefIndex: 9439
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<MemorySnapshotMetadata> CreatingMetadata; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2307710 Offset: 0x2305D10 VA: 0x182307710
	private static byte[] PrepareMetadata() { }

	// RVA: 0x2307B60 Offset: 0x2306160 VA: 0x182307B60
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x2307BE0 Offset: 0x23061E0 VA: 0x182307BE0
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCode]
	// RVA: 0x2307680 Offset: 0x2305C80 VA: 0x182307680
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCode]
	// RVA: 0x2307A30 Offset: 0x2306030 VA: 0x182307A30
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }
}

