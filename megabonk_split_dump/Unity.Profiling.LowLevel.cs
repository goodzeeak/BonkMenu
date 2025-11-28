// Namespace: Unity.Profiling.LowLevel
[Flags]
public enum MarkerFlags // TypeDefIndex: 9435
{
	// Fields
	public ushort value__; // 0x0
	public const MarkerFlags Default = 0;
	public const MarkerFlags Script = 2;
	public const MarkerFlags ScriptInvoke = 32;
	public const MarkerFlags ScriptDeepProfiler = 64;
	public const MarkerFlags AvailabilityEditor = 4;
	public const MarkerFlags AvailabilityNonDevelopment = 8;
	public const MarkerFlags Warning = 16;
	public const MarkerFlags Counter = 128;
	public const MarkerFlags SampleGPU = 256;
}

