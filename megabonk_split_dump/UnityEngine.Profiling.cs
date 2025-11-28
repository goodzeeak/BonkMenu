// Namespace: UnityEngine.Profiling
[MovedFrom("UnityEngine")]
[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
[NativeHeader("Runtime/Allocator/MemoryManager.h")]
[NativeHeader("Runtime/Profiler/Profiler.h")]
[UsedByNativeCode]
public sealed class Profiler // TypeDefIndex: 9804
{
	// Methods

	[NativeMethod(Name = "scripting_gc_get_used_size", IsFreeFunction = True)]
	// RVA: 0x235CAF0 Offset: 0x235B0F0 VA: 0x18235CAF0
	public static long GetMonoUsedSizeLong() { }

	[StaticAccessor("GetMemoryManager()", 0)]
	[NativeConditional("ENABLE_MEMORY_MANAGER")]
	[NativeMethod(Name = "GetTotalReservedMemory")]
	// RVA: 0x235CB20 Offset: 0x235B120 VA: 0x18235CB20
	public static long GetTotalReservedMemoryLong() { }
}

