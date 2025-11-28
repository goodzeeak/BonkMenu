// Namespace: Unity.Jobs.LowLevel.Unsafe
[Usage(1024)]
public sealed class JobProducerTypeAttribute : Attribute // TypeDefIndex: 9417
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Type <ProducerType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type producerType) { }
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public struct JobRanges // TypeDefIndex: 9418
{
	// Fields
	internal int BatchSize; // 0x0
	internal int NumJobs; // 0x4
	public int TotalIterationCount; // 0x8
	internal IntPtr StartEndIndex; // 0x10
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public enum ScheduleMode // TypeDefIndex: 9419
{
	// Fields
	public int value__; // 0x0
	public const ScheduleMode Run = 0;
	[Obsolete("Batched is obsolete, use Parallel or Single depending on job type. (UnityUpgradable) -> Parallel", False)]
	public const ScheduleMode Batched = 1;
	public const ScheduleMode Parallel = 1;
	public const ScheduleMode Single = 2;
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
[NativeHeader("Runtime/Jobs/JobSystem.h")]
public static class JobsUtility // TypeDefIndex: 9422
{
	// Fields
	internal static JobsUtility.PanicFunction_ PanicFunction; // 0x0

	// Properties
	public static bool IsExecutingJob { get; }
	public static int ThreadIndex { get; }
	public static int ThreadIndexCount { get; }

	// Methods

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x22FFD90 Offset: 0x22FE390 VA: 0x1822FFD90
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[FreeFunction("ScheduleManagedJobParallelFor", ThrowsException = True, IsThreadSafe = True)]
	// RVA: 0x22FFEA0 Offset: 0x22FE4A0 VA: 0x1822FFEA0
	public static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[FreeFunction(ThrowsException = True, IsThreadSafe = True)]
	// RVA: 0x22FFD20 Offset: 0x22FE320 VA: 0x1822FFD20
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x22FFCB0 Offset: 0x22FE2B0 VA: 0x1822FFCB0
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x22FFF10 Offset: 0x22FE510 VA: 0x1822FFF10
	public static bool get_IsExecutingJob() { }

	[FreeFunction("GetJobWorkerIndex", IsThreadSafe = True)]
	[BurstAuthorizedExternalMethod]
	// RVA: 0x22FFF70 Offset: 0x22FE570 VA: 0x1822FFF70
	public static int get_ThreadIndex() { }

	[FreeFunction("GetJobWorkerIndexCount", IsThreadSafe = True)]
	[BurstAuthorizedExternalMethod]
	// RVA: 0x22FFF40 Offset: 0x22FE540 VA: 0x1822FFF40
	public static int get_ThreadIndexCount() { }

	[RequiredByNativeCode]
	// RVA: 0x22FFDF0 Offset: 0x22FE3F0 VA: 0x1822FFDF0
	private static void InvokePanicFunction() { }

	// RVA: 0x22FFE40 Offset: 0x22FE440 VA: 0x1822FFE40
	private static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }
}

