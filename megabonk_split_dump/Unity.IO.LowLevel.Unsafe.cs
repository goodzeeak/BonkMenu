// Namespace: Unity.IO.LowLevel.Unsafe
[RequiredByNativeCode]
public enum FileState // TypeDefIndex: 9440
{
	// Fields
	public int value__; // 0x0
	public const FileState Absent = 0;
	public const FileState Exists = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum AssetLoadingSubsystem // TypeDefIndex: 9441
{
	// Fields
	public int value__; // 0x0
	public const AssetLoadingSubsystem Other = 0;
	public const AssetLoadingSubsystem Texture = 1;
	public const AssetLoadingSubsystem VirtualTexture = 2;
	public const AssetLoadingSubsystem Mesh = 3;
	public const AssetLoadingSubsystem Audio = 4;
	public const AssetLoadingSubsystem Scripts = 5;
	public const AssetLoadingSubsystem EntitiesScene = 6;
	public const AssetLoadingSubsystem EntitiesStreamBinaryReader = 7;
	public const AssetLoadingSubsystem FileInfo = 8;
	public const AssetLoadingSubsystem ContentLoading = 9;
}

// Namespace: Unity.IO.LowLevel.Unsafe
[RequiredByNativeCode]
public enum Priority // TypeDefIndex: 9442
{
	// Fields
	public int value__; // 0x0
	public const Priority PriorityLow = 0;
	public const Priority PriorityHigh = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
[NativeHeader("Runtime/File/AsyncReadManagerMetrics.h")]
public enum ProcessingState // TypeDefIndex: 9443
{
	// Fields
	public int value__; // 0x0
	public const ProcessingState Unknown = 0;
	public const ProcessingState InQueue = 1;
	public const ProcessingState Reading = 2;
	public const ProcessingState Completed = 3;
	public const ProcessingState Failed = 4;
	public const ProcessingState Canceled = 5;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum FileReadType // TypeDefIndex: 9444
{
	// Fields
	public int value__; // 0x0
	public const FileReadType Sync = 0;
	public const FileReadType Async = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
[NativeConditional("ENABLE_PROFILER")]
[RequiredByNativeCode]
public struct AsyncReadManagerRequestMetric // TypeDefIndex: 9445
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <AssetName>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <OffsetBytes>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ulong <SizeBytes>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <AssetTypeId>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ulong <CurrentBytesRead>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly uint <BatchReadCount>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <IsBatchRead>k__BackingField; // 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ProcessingState <State>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly FileReadType <ReadType>k__BackingField; // 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Priority <PriorityLevel>k__BackingField; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly AssetLoadingSubsystem <Subsystem>k__BackingField; // 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly double <RequestTimeMicroseconds>k__BackingField; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly double <TimeInQueueMicroseconds>k__BackingField; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly double <TotalTimeMicroseconds>k__BackingField; // 0x58
}

// Namespace: Unity.IO.LowLevel.Unsafe
[NativeConditional("ENABLE_PROFILER")]
[RequiredByNativeCode]
[NativeAsStruct]
public class AsyncReadManagerMetricsFilters // TypeDefIndex: 9446
{
	// Fields
	[NativeName("typeIDs")]
	internal ulong[] TypeIDs; // 0x10
	[NativeName("states")]
	internal ProcessingState[] States; // 0x18
	[NativeName("readTypes")]
	internal FileReadType[] ReadTypes; // 0x20
	[NativeName("priorityLevels")]
	internal Priority[] PriorityLevels; // 0x28
	[NativeName("subsystems")]
	internal AssetLoadingSubsystem[] Subsystems; // 0x30
}

