// Namespace: Unity.Profiling
[RequiredByNativeCode]
[Usage(76, AllowMultiple = False)]
public sealed class IgnoredByDeepProfilerAttribute : Attribute // TypeDefIndex: 9428
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Profiling
[UsedByNativeCode]
[IsReadOnly]
public struct ProfilerCategory // TypeDefIndex: 9429
{
	// Fields
	private readonly ushort m_CategoryId; // 0x0

	// Properties
	public string Name { get; }
	public static ProfilerCategory Scripts { get; }

	// Methods

	// RVA: 0x594180 Offset: 0x592780 VA: 0x180594180
	internal void .ctor(ushort category) { }

	// RVA: 0x230DE30 Offset: 0x230C430 VA: 0x18230DE30
	public string get_Name() { }

	// RVA: 0x230DE20 Offset: 0x230C420 VA: 0x18230DE20 Slot: 3
	public override string ToString() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	public static ProfilerCategory get_Scripts() { }

	// RVA: 0x230DF60 Offset: 0x230C560 VA: 0x18230DF60
	public static ushort op_Implicit(ProfilerCategory category) { }
}

// Namespace: Unity.Profiling
public enum ProfilerCategoryColor // TypeDefIndex: 9430
{
	// Fields
	public ushort value__; // 0x0
	public const ProfilerCategoryColor Render = 0;
	public const ProfilerCategoryColor Scripts = 1;
	public const ProfilerCategoryColor BurstJobs = 2;
	public const ProfilerCategoryColor Other = 3;
	public const ProfilerCategoryColor Physics = 4;
	public const ProfilerCategoryColor Animation = 5;
	public const ProfilerCategoryColor Audio = 6;
	public const ProfilerCategoryColor AudioJob = 7;
	public const ProfilerCategoryColor AudioUpdateJob = 8;
	public const ProfilerCategoryColor Lighting = 9;
	public const ProfilerCategoryColor GC = 10;
	public const ProfilerCategoryColor VSync = 11;
	public const ProfilerCategoryColor Memory = 12;
	public const ProfilerCategoryColor Internal = 13;
	public const ProfilerCategoryColor UI = 14;
	public const ProfilerCategoryColor Build = 15;
	public const ProfilerCategoryColor Input = 16;
}

// Namespace: Unity.Profiling
[UsedByNativeCode]
[IgnoredByDeepProfiler]
public struct ProfilerMarker // TypeDefIndex: 9432
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x230DFE0 Offset: 0x230C5E0 VA: 0x18230DFE0
	public void .ctor(string name) { }

	// RVA: 0x230DFB0 Offset: 0x230C5B0 VA: 0x18230DFB0
	public void .ctor(ProfilerCategory category, string name) { }

	[Pure]
	// RVA: 0x230DF70 Offset: 0x230C570 VA: 0x18230DF70
	public ProfilerMarker.AutoScope Auto() { }
}

// Namespace: Unity.Profiling
[Flags]
public enum ProfilerCounterOptions // TypeDefIndex: 9433
{
	// Fields
	public ushort value__; // 0x0
	public const ProfilerCounterOptions None = 0;
	public const ProfilerCounterOptions FlushOnEndOfFrame = 2;
	public const ProfilerCounterOptions ResetToZeroOnFlush = 4;
}

// Namespace: Unity.Profiling
public struct DebugScreenCapture // TypeDefIndex: 9434
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private NativeArray<byte> <RawImageDataReference>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private TextureFormat <ImageFormat>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <Width>k__BackingField; // 0x14
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <Height>k__BackingField; // 0x18

	// Properties
	public NativeArray<byte> RawImageDataReference { set; }
	public TextureFormat ImageFormat { set; }
	public int Width { set; }
	public int Height { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3A43C0 Offset: 0x3A29C0 VA: 0x1803A43C0
	public void set_RawImageDataReference(NativeArray<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_ImageFormat(TextureFormat value) { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_Width(int value) { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_Height(int value) { }
}

