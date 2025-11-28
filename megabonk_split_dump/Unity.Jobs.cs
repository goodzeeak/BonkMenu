// Namespace: Unity.Jobs
[JobProducerType(typeof(IJobExtensions.JobStruct<T>))]
public interface IJob // TypeDefIndex: 9408
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute();
}

// Namespace: Unity.Jobs
[Extension]
public static class IJobExtensions // TypeDefIndex: 9411
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EarlyJobInit<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70AD90 Offset: 0x709390 VA: 0x18070AD90
	|-IJobExtensions.EarlyJobInit<NativeArrayDisposeJob>
	|
	|-RVA: 0x70AD30 Offset: 0x709330 VA: 0x18070AD30
	|-IJobExtensions.EarlyJobInit<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: Unity.Jobs
[JobProducerType(typeof(IJobParallelForExtensions.ParallelForJobStruct<T>))]
public interface IJobParallelFor // TypeDefIndex: 9412
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute(int index);
}

// Namespace: Unity.Jobs
[Extension]
public static class IJobParallelForExtensions // TypeDefIndex: 9415
{
	// Methods

	// RVA: -1 Offset: -1
	private static IntPtr GetReflectionData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70AF40 Offset: 0x709540 VA: 0x18070AF40
	|-IJobParallelForExtensions.GetReflectionData<GetPosition>
	|
	|-RVA: 0x70AE90 Offset: 0x709490 VA: 0x18070AE90
	|-IJobParallelForExtensions.GetReflectionData<GetPositionTangentNormal>
	|
	|-RVA: 0x70AFF0 Offset: 0x7095F0 VA: 0x18070AFF0
	|-IJobParallelForExtensions.GetReflectionData<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x70B2B0 Offset: 0x7098B0 VA: 0x18070B2B0
	|-IJobParallelForExtensions.GetReflectionData<MeshGenerator.TessellationJob>
	|
	|-RVA: 0x70B0A0 Offset: 0x7096A0 VA: 0x18070B0A0
	|-IJobParallelForExtensions.GetReflectionData<OpacityIdAccelerator.OpacityIdUpdateJob>
	|
	|-RVA: 0x70B150 Offset: 0x709750 VA: 0x18070B150
	|-IJobParallelForExtensions.GetReflectionData<Painter2D.Painter2DJob>
	|
	|-RVA: 0x70ADE0 Offset: 0x7093E0 VA: 0x18070ADE0
	|-IJobParallelForExtensions.GetReflectionData<UITKTextJobSystem.GenerateTextJobData>
	|
	|-RVA: 0x70B200 Offset: 0x709800 VA: 0x18070B200
	|-IJobParallelForExtensions.GetReflectionData<UITKTextJobSystem.PrepareTextJobData>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70B620 Offset: 0x709C20 VA: 0x18070B620
	|-IJobParallelForExtensions.Schedule<GetPosition>
	|
	|-RVA: 0x70B4C0 Offset: 0x709AC0 VA: 0x18070B4C0
	|-IJobParallelForExtensions.Schedule<GetPositionTangentNormal>
	|
	|-RVA: 0x70B780 Offset: 0x709D80 VA: 0x18070B780
	|-IJobParallelForExtensions.Schedule<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0x70BC80 Offset: 0x70A280 VA: 0x18070BC80
	|-IJobParallelForExtensions.Schedule<MeshGenerator.TessellationJob>
	|
	|-RVA: 0x70B870 Offset: 0x709E70 VA: 0x18070B870
	|-IJobParallelForExtensions.Schedule<OpacityIdAccelerator.OpacityIdUpdateJob>
	|
	|-RVA: 0x70B9D0 Offset: 0x709FD0 VA: 0x18070B9D0
	|-IJobParallelForExtensions.Schedule<Painter2D.Painter2DJob>
	|
	|-RVA: 0x70B360 Offset: 0x709960 VA: 0x18070B360
	|-IJobParallelForExtensions.Schedule<UITKTextJobSystem.GenerateTextJobData>
	|
	|-RVA: 0x70BB30 Offset: 0x70A130 VA: 0x18070BB30
	|-IJobParallelForExtensions.Schedule<UITKTextJobSystem.PrepareTextJobData>
	*/
}

// Namespace: Unity.Jobs
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public struct JobHandle : IEquatable<JobHandle> // TypeDefIndex: 9416
{
	// Fields
	internal ulong jobGroup; // 0x0
	internal int version; // 0x8

	// Methods

	// RVA: 0x22FFBB0 Offset: 0x22FE1B0 VA: 0x1822FFBB0
	public void Complete() { }

	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x22FFC40 Offset: 0x22FE240 VA: 0x1822FFC40
	public static void ScheduleBatchedJobs() { }

	[NativeMethod("ScheduleBatchedScriptingJobsAndComplete", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x22FFC00 Offset: 0x22FE200 VA: 0x1822FFC00
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	// RVA: 0x22FFA40 Offset: 0x22FE040 VA: 0x1822FFA40
	public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs) { }

	// RVA: 0x22FFAF0 Offset: 0x22FE0F0 VA: 0x1822FFAF0
	public static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x22FF9E0 Offset: 0x22FDFE0 VA: 0x1822FF9E0
	internal static JobHandle CombineDependenciesInternalPtr(void* jobs, int count) { }

	// RVA: 0x22FFBF0 Offset: 0x22FE1F0 VA: 0x1822FFBF0 Slot: 4
	public bool Equals(JobHandle other) { }

	// RVA: 0x22FF990 Offset: 0x22FDF90 VA: 0x1822FF990
	private static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret) { }
}

