// Namespace: Internal.Threading.Tasks.Tracing
internal static class TaskTrace // TypeDefIndex: 136
{
	// Fields
	private static TaskTraceCallbacks s_callbacks; // 0x0

	// Properties
	public static bool Enabled { get; }

	// Methods

	// RVA: 0x136AFF0 Offset: 0x13695F0 VA: 0x18136AFF0
	public static bool get_Enabled() { }

	// RVA: 0x136AE70 Offset: 0x1369470 VA: 0x18136AE70
	public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x136AEF0 Offset: 0x13694F0 VA: 0x18136AEF0
	public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x136AF70 Offset: 0x1369570 VA: 0x18136AF70
	public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x136ADE0 Offset: 0x13693E0 VA: 0x18136ADE0
	public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions) { }
}

