// Namespace: Internal.Runtime.Augments
internal enum AsyncStatus // TypeDefIndex: 137
{
	// Fields
	public int value__; // 0x0
	public const AsyncStatus Started = 0;
	public const AsyncStatus Completed = 1;
	public const AsyncStatus Canceled = 2;
	public const AsyncStatus Error = 3;
}

// Namespace: Internal.Runtime.Augments
internal abstract class TaskTraceCallbacks // TypeDefIndex: 138
{
	// Properties
	public abstract bool Enabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_Enabled();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions);
}

// Namespace: Internal.Runtime.Augments
internal class RuntimeAugments // TypeDefIndex: 139
{
	// Fields
	private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks; // 0x0

	// Properties
	internal static ReflectionExecutionDomainCallbacks Callbacks { get; }

	// Methods

	// RVA: 0x135CC00 Offset: 0x135B200 VA: 0x18135CC00
	public static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x135CCB0 Offset: 0x135B2B0 VA: 0x18135CCB0
	internal static ReflectionExecutionDomainCallbacks get_Callbacks() { }

	// RVA: 0x135CC30 Offset: 0x135B230 VA: 0x18135CC30
	private static void .cctor() { }
}

// Namespace: Internal.Runtime.Augments
internal class ReflectionExecutionDomainCallbacks // TypeDefIndex: 140
{
	// Methods

	// RVA: 0x135A1D0 Offset: 0x13587D0 VA: 0x18135A1D0
	internal Exception CreateMissingMetadataException(Type attributeType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Internal.Runtime.Augments
internal sealed class RuntimeThread // TypeDefIndex: 141
{
	// Fields
	internal static readonly int OptimalMaxSpinWaitsPerSpinIteration; // 0x0
	private readonly Thread thread; // 0x10

	// Properties
	public bool IsBackground { set; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	private void .ctor(Thread t) { }

	// RVA: 0x135CD00 Offset: 0x135B300 VA: 0x18135CD00
	public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize) { }

	// RVA: 0x135CE40 Offset: 0x135B440 VA: 0x18135CE40
	public void set_IsBackground(bool value) { }

	// RVA: 0x135CDD0 Offset: 0x135B3D0 VA: 0x18135CDD0
	public void Start(object state) { }

	// RVA: 0x135CDA0 Offset: 0x135B3A0 VA: 0x18135CDA0
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x135CDF0 Offset: 0x135B3F0 VA: 0x18135CDF0
	public static bool Yield() { }

	// RVA: 0x135CDB0 Offset: 0x135B3B0 VA: 0x18135CDB0
	public static bool SpinWait(int iterations) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	public static int GetCurrentProcessorId() { }

	// RVA: 0x135CE00 Offset: 0x135B400 VA: 0x18135CE00
	private static void .cctor() { }
}

