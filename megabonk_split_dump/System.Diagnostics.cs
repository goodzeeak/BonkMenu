// Namespace: System.Diagnostics
[Usage(68, AllowMultiple = True)]
[Serializable]
public sealed class ConditionalAttribute : Attribute // TypeDefIndex: 1398
{
	// Fields
	[CompilerGenerated]
	private readonly string <ConditionString>k__BackingField; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string conditionString) { }
}

// Namespace: System.Diagnostics
[Usage(108, Inherited = False)]
internal sealed class StackTraceHiddenAttribute : Attribute // TypeDefIndex: 1399
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(108, Inherited = False)]
[Serializable]
public sealed class DebuggerStepThroughAttribute : Attribute // TypeDefIndex: 1400
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(224, Inherited = False)]
[Serializable]
public sealed class DebuggerHiddenAttribute : Attribute // TypeDefIndex: 1401
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(236, Inherited = False)]
[Serializable]
public sealed class DebuggerNonUserCodeAttribute : Attribute // TypeDefIndex: 1402
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[Usage(3, AllowMultiple = False)]
[ComVisible(True)]
public sealed class DebuggableAttribute : Attribute // TypeDefIndex: 1404
{
	// Fields
	private DebuggableAttribute.DebuggingModes m_debuggingModes; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(DebuggableAttribute.DebuggingModes modes) { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
public enum DebuggerBrowsableState // TypeDefIndex: 1405
{
	// Fields
	public int value__; // 0x0
	public const DebuggerBrowsableState Never = 0;
	public const DebuggerBrowsableState Collapsed = 2;
	public const DebuggerBrowsableState RootHidden = 3;
}

// Namespace: System.Diagnostics
[Usage(384, AllowMultiple = False)]
[ComVisible(True)]
public sealed class DebuggerBrowsableAttribute : Attribute // TypeDefIndex: 1406
{
	// Fields
	private DebuggerBrowsableState state; // 0x10

	// Methods

	// RVA: 0x14A5840 Offset: 0x14A3E40 VA: 0x1814A5840
	public void .ctor(DebuggerBrowsableState state) { }
}

// Namespace: System.Diagnostics
[Usage(13, AllowMultiple = True)]
[ComVisible(True)]
public sealed class DebuggerTypeProxyAttribute : Attribute // TypeDefIndex: 1407
{
	// Fields
	private string typeName; // 0x10

	// Methods

	// RVA: 0x14A5960 Offset: 0x14A3F60 VA: 0x1814A5960
	public void .ctor(Type type) { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(4509, AllowMultiple = True)]
public sealed class DebuggerDisplayAttribute : Attribute // TypeDefIndex: 1408
{
	// Fields
	private string name; // 0x10
	private string value; // 0x18
	private string type; // 0x20

	// Properties
	public string Name { set; }
	public string Type { set; }

	// Methods

	// RVA: 0x14A58C0 Offset: 0x14A3EC0 VA: 0x1814A58C0
	public void .ctor(string value) { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Name(string value) { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Type(string value) { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
public sealed class Debugger // TypeDefIndex: 1409
{
	// Fields
	public static readonly string DefaultCategory; // 0x0

	// Methods

	// RVA: 0x1353770 Offset: 0x1351D70 VA: 0x181353770
	public static bool IsLogging() { }

	// RVA: 0x144A4C0 Offset: 0x1448AC0 VA: 0x18144A4C0
	private static void Log_icall(int level, ref string category, ref string message) { }

	// RVA: 0x14A5A30 Offset: 0x14A4030 VA: 0x1814A5A30
	public static void Log(int level, string category, string message) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void NotifyOfCrossThreadDependency() { }

	// RVA: 0x14A5A90 Offset: 0x14A4090 VA: 0x1814A5A90
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[MonoTODO("Serialized objects are not compatible with MS.NET")]
[ComVisible(True)]
[Serializable]
public class StackFrame // TypeDefIndex: 1410
{
	// Fields
	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; // 0x10
	private int nativeOffset; // 0x14
	private long methodAddress; // 0x18
	private uint methodIndex; // 0x20
	private MethodBase methodBase; // 0x28
	private string fileName; // 0x30
	private int lineNumber; // 0x38
	private int columnNumber; // 0x3C
	private string internalMethodName; // 0x40

	// Methods

	// RVA: 0x14B2CF0 Offset: 0x14B12F0 VA: 0x1814B2CF0
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	// RVA: 0x14B2C90 Offset: 0x14B1290 VA: 0x1814B2C90
	public void .ctor() { }

	// RVA: 0x14B2C10 Offset: 0x14B1210 VA: 0x1814B2C10
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 4
	public virtual int GetFileLineNumber() { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0 Slot: 5
	public virtual int GetFileColumnNumber() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 6
	public virtual string GetFileName() { }

	// RVA: 0x14B29A0 Offset: 0x14B0FA0 VA: 0x1814B29A0
	internal string GetSecureFileName() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 7
	public virtual int GetILOffset() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 8
	public virtual MethodBase GetMethod() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30 Slot: 9
	public virtual int GetNativeOffset() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal long GetMethodAddress() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	internal uint GetMethodIndex() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal string GetInternalMethodName() { }

	// RVA: 0x14B2A00 Offset: 0x14B1000 VA: 0x1814B2A00 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Diagnostics
[MonoTODO("Serialized objects are not compatible with .NET")]
[ComVisible(True)]
[Serializable]
public class StackTrace // TypeDefIndex: 1412
{
	// Fields
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x14B4270 Offset: 0x14B2870 VA: 0x1814B4270
	public void .ctor() { }

	// RVA: 0x14B4020 Offset: 0x14B2620 VA: 0x1814B4020
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x14B4180 Offset: 0x14B2780 VA: 0x1814B4180
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x14B42D0 Offset: 0x14B28D0 VA: 0x1814B42D0
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x14B42C0 Offset: 0x14B28C0 VA: 0x1814B42C0
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x14B41C0 Offset: 0x14B27C0 VA: 0x1814B41C0
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x14B4060 Offset: 0x14B2660 VA: 0x1814B4060
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x14B42A0 Offset: 0x14B28A0 VA: 0x1814B42A0 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x14B35E0 Offset: 0x14B1BE0 VA: 0x1814B35E0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	[ComVisible(False)]
	// RVA: 0x14B3650 Offset: 0x14B1C50 VA: 0x1814B3650 Slot: 6
	public virtual StackFrame[] GetFrames() { }

	// RVA: 0x14B34F0 Offset: 0x14B1AF0 VA: 0x1814B34F0
	private static string GetAotId() { }

	// RVA: 0x14B2D00 Offset: 0x14B1300 VA: 0x1814B2D00
	private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync) { }

	// RVA: 0x14B37D0 Offset: 0x14B1DD0 VA: 0x1814B37D0
	private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync) { }

	// RVA: 0x14B3210 Offset: 0x14B1810 VA: 0x1814B3210
	private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType) { }

	// RVA: 0x14B3E90 Offset: 0x14B2490 VA: 0x1814B3E90 Slot: 3
	public override string ToString() { }

	// RVA: 0x14B4000 Offset: 0x14B2600 VA: 0x1814B4000
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

// Namespace: System.Diagnostics
[SwitchLevel(typeof(bool))]
public class BooleanSwitch : Switch // TypeDefIndex: 7471
{
	// Methods

	// RVA: 0x1DF92D0 Offset: 0x1DF78D0 VA: 0x181DF92D0
	public void .ctor(string displayName, string description) { }
}

// Namespace: System.Diagnostics
public class CorrelationManager // TypeDefIndex: 7472
{
	// Properties
	public Stack LogicalOperationStack { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1DF9370 Offset: 0x1DF7970 VA: 0x181DF9370
	public Stack get_LogicalOperationStack() { }

	// RVA: 0x1DF9370 Offset: 0x1DF7970 VA: 0x181DF9370
	private Stack GetLogicalOperationStack() { }
}

// Namespace: System.Diagnostics
public abstract class Switch // TypeDefIndex: 7473
{
	// Fields
	private readonly string description; // 0x10
	private readonly string displayName; // 0x18
	private string switchValueString; // 0x20
	private string defaultValue; // 0x28
	private static List<WeakReference> switches; // 0x0
	private static int s_LastCollectionCount; // 0x8

	// Methods

	// RVA: 0x1E0C470 Offset: 0x1E0AA70 VA: 0x181E0C470
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x1E0C4E0 Offset: 0x1E0AAE0 VA: 0x181E0C4E0
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x1E0C730 Offset: 0x1E0AD30 VA: 0x181E0C730
	private static void _pruneCachedSwitches() { }

	// RVA: 0x1E0C3E0 Offset: 0x1E0A9E0 VA: 0x181E0C3E0
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[Usage(4)]
public sealed class SwitchLevelAttribute : Attribute // TypeDefIndex: 7474
{
	// Fields
	private Type type; // 0x10

	// Properties
	public Type SwitchLevelType { set; }

	// Methods

	// RVA: 0x1E0C2A0 Offset: 0x1E0A8A0 VA: 0x181E0C2A0
	public void .ctor(Type switchLevelType) { }

	// RVA: 0x1E0C340 Offset: 0x1E0A940 VA: 0x181E0C340
	public void set_SwitchLevelType(Type value) { }
}

// Namespace: System.Diagnostics
public sealed class Trace // TypeDefIndex: 7475
{
	// Fields
	private static CorrelationManager correlationManager; // 0x0

	// Properties
	public static TraceListenerCollection Listeners { get; }
	public static bool AutoFlush { get; }
	public static CorrelationManager CorrelationManager { get; }

	// Methods

	// RVA: 0x1E0F190 Offset: 0x1E0D790 VA: 0x181E0F190
	public static TraceListenerCollection get_Listeners() { }

	// RVA: 0x1E0F050 Offset: 0x1E0D650 VA: 0x181E0F050
	public static bool get_AutoFlush() { }

	// RVA: 0x1E0F0E0 Offset: 0x1E0D6E0 VA: 0x181E0F0E0
	public static CorrelationManager get_CorrelationManager() { }
}

// Namespace: System.Diagnostics
public class TraceEventCache // TypeDefIndex: 7476
{
	// Fields
	private static int processId; // 0x0
	private static string processName; // 0x8
	private long timeStamp; // 0x10
	private DateTime dateTime; // 0x18
	private string stackTrace; // 0x20

	// Properties
	public string Callstack { get; }
	public Stack LogicalOperationStack { get; }
	public DateTime DateTime { get; }
	public int ProcessId { get; }
	public string ThreadId { get; }
	public long Timestamp { get; }

	// Methods

	// RVA: 0x1E0CDB0 Offset: 0x1E0B3B0 VA: 0x181E0CDB0
	public string get_Callstack() { }

	// RVA: 0x1E0CE90 Offset: 0x1E0B490 VA: 0x181E0CE90
	public Stack get_LogicalOperationStack() { }

	// RVA: 0x1E0CDF0 Offset: 0x1E0B3F0 VA: 0x181E0CDF0
	public DateTime get_DateTime() { }

	// RVA: 0x1E0CBC0 Offset: 0x1E0B1C0 VA: 0x181E0CBC0
	public int get_ProcessId() { }

	// RVA: 0x1E0CFF0 Offset: 0x1E0B5F0 VA: 0x181E0CFF0
	public string get_ThreadId() { }

	// RVA: 0x1E0D070 Offset: 0x1E0B670 VA: 0x181E0D070
	public long get_Timestamp() { }

	// RVA: 0x1E0CC10 Offset: 0x1E0B210 VA: 0x181E0CC10
	private static void InitProcessInfo() { }

	// RVA: 0x1E0CBC0 Offset: 0x1E0B1C0 VA: 0x181E0CBC0
	internal static int GetProcessId() { }

	// RVA: 0x1561130 Offset: 0x155F730 VA: 0x181561130
	internal static int GetThreadId() { }

	// RVA: 0x1E0CD40 Offset: 0x1E0B340 VA: 0x181E0CD40
	public void .ctor() { }
}

// Namespace: System.Diagnostics
public enum TraceEventType // TypeDefIndex: 7477
{
	// Fields
	public int value__; // 0x0
	public const TraceEventType Critical = 1;
	public const TraceEventType Error = 2;
	public const TraceEventType Warning = 4;
	public const TraceEventType Information = 8;
	public const TraceEventType Verbose = 16;
	[EditorBrowsable(2)]
	public const TraceEventType Start = 256;
	[EditorBrowsable(2)]
	public const TraceEventType Stop = 512;
	[EditorBrowsable(2)]
	public const TraceEventType Suspend = 1024;
	[EditorBrowsable(2)]
	public const TraceEventType Resume = 2048;
	[EditorBrowsable(2)]
	public const TraceEventType Transfer = 4096;
}

// Namespace: System.Diagnostics
public abstract class TraceFilter // TypeDefIndex: 7478
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);

	// RVA: 0x1E0D0D0 Offset: 0x1E0B6D0 VA: 0x181E0D0D0
	internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage) { }
}

// Namespace: System.Diagnostics
internal static class TraceInternal // TypeDefIndex: 7479
{
	// Fields
	private static string appName; // 0x0
	private static TraceListenerCollection listeners; // 0x8
	private static bool autoFlush; // 0x10
	[ThreadStatic]
	private static int indentLevel; // 0x80000000
	private static int indentSize; // 0x14
	internal static readonly object critSec; // 0x18

	// Properties
	public static TraceListenerCollection Listeners { get; }
	public static bool AutoFlush { get; }
	public static int IndentLevel { get; }
	public static int IndentSize { get; }

	// Methods

	// RVA: 0x1E0D2E0 Offset: 0x1E0B8E0 VA: 0x181E0D2E0
	public static TraceListenerCollection get_Listeners() { }

	// RVA: 0x1E0D1D0 Offset: 0x1E0B7D0 VA: 0x181E0D1D0
	public static bool get_AutoFlush() { }

	// RVA: 0x1E0D230 Offset: 0x1E0B830 VA: 0x181E0D230
	public static int get_IndentLevel() { }

	// RVA: 0x1E0D280 Offset: 0x1E0B880 VA: 0x181E0D280
	public static int get_IndentSize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void InitializeSettings() { }

	// RVA: 0x1E0D120 Offset: 0x1E0B720 VA: 0x181E0D120
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
public enum TraceLevel // TypeDefIndex: 7480
{
	// Fields
	public int value__; // 0x0
	public const TraceLevel Off = 0;
	public const TraceLevel Error = 1;
	public const TraceLevel Warning = 2;
	public const TraceLevel Info = 3;
	public const TraceLevel Verbose = 4;
}

// Namespace: System.Diagnostics
public abstract class TraceListener : MarshalByRefObject, IDisposable // TypeDefIndex: 7481
{
	// Fields
	private int indentLevel; // 0x18
	private int indentSize; // 0x1C
	private TraceOptions traceOptions; // 0x20
	private bool needIndent; // 0x24
	private string listenerName; // 0x28
	private TraceFilter filter; // 0x30

	// Properties
	public virtual bool IsThreadSafe { get; }
	public int IndentLevel { set; }
	public int IndentSize { set; }
	[ComVisible(False)]
	public TraceFilter Filter { get; }
	protected bool NeedIndent { get; set; }
	[ComVisible(False)]
	public TraceOptions TraceOutputOptions { get; }

	// Methods

	// RVA: 0x1E0EE90 Offset: 0x1E0D490 VA: 0x181E0EE90
	protected void .ctor(string name) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public virtual bool get_IsThreadSafe() { }

	// RVA: 0x1E0E340 Offset: 0x1E0C940 VA: 0x181E0E340 Slot: 6
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public virtual void Flush() { }

	// RVA: 0x1E0EED0 Offset: 0x1E0D4D0 VA: 0x181E0EED0
	public void set_IndentLevel(int value) { }

	// RVA: 0x1E0EEF0 Offset: 0x1E0D4F0 VA: 0x181E0EEF0
	public void set_IndentSize(int value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public TraceFilter get_Filter() { }

	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	protected bool get_NeedIndent() { }

	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	protected void set_NeedIndent(bool value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public TraceOptions get_TraceOutputOptions() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Write(string message);

	// RVA: 0x1E0EDE0 Offset: 0x1E0D3E0 VA: 0x181E0EDE0 Slot: 11
	protected virtual void WriteIndent() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteLine(string message);

	[ComVisible(False)]
	// RVA: 0x1E0E3B0 Offset: 0x1E0C9B0 VA: 0x181E0E3B0 Slot: 13
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) { }

	// RVA: 0x1E0ECD0 Offset: 0x1E0D2D0 VA: 0x181E0ECD0
	private void WriteHeader(string source, TraceEventType eventType, int id) { }

	// RVA: 0x1E0E550 Offset: 0x1E0CB50 VA: 0x181E0E550
	private void WriteFooter(TraceEventCache eventCache) { }

	// RVA: 0x1E0E3A0 Offset: 0x1E0C9A0 VA: 0x181E0E3A0
	internal bool IsEnabled(TraceOptions opts) { }
}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
public class TraceListenerCollection : IList, ICollection, IEnumerable // TypeDefIndex: 7482
{
	// Fields
	private ArrayList list; // 0x10

	// Properties
	public int Count { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0x1E0E2D0 Offset: 0x1E0C8D0 VA: 0x181E0E2D0
	internal void .ctor() { }

	// RVA: 0x14A4DA0 Offset: 0x14A33A0 VA: 0x1814A4DA0 Slot: 16
	public int get_Count() { }

	// RVA: 0x1E0D5E0 Offset: 0x1E0BBE0 VA: 0x181E0D5E0
	public int Add(TraceListener listener) { }

	// RVA: 0x1E0D700 Offset: 0x1E0BD00 VA: 0x181E0D700 Slot: 8
	public void Clear() { }

	// RVA: 0x131AB70 Offset: 0x1319170 VA: 0x18131AB70 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1E0D760 Offset: 0x1E0BD60 VA: 0x181E0D760
	internal void InitializeListener(TraceListener listener) { }

	// RVA: 0x1E0D8A0 Offset: 0x1E0BEA0 VA: 0x181E0D8A0 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x1B31460 Offset: 0x1B2FA60 VA: 0x181B31460 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1E0E0E0 Offset: 0x1E0C6E0 VA: 0x181E0E0E0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1E0DAB0 Offset: 0x1E0C0B0 VA: 0x181E0DAB0 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x14A46C0 Offset: 0x14A2CC0 VA: 0x1814A46C0 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x14A46F0 Offset: 0x14A2CF0 VA: 0x1814A46F0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1E0DD50 Offset: 0x1E0C350 VA: 0x181E0DD50 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1E0DFE0 Offset: 0x1E0C5E0 VA: 0x181E0DFE0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1E0D9A0 Offset: 0x1E0BFA0 VA: 0x181E0D9A0 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
}

// Namespace: System.Diagnostics
[Flags]
public enum TraceOptions // TypeDefIndex: 7483
{
	// Fields
	public int value__; // 0x0
	public const TraceOptions None = 0;
	public const TraceOptions LogicalOperationStack = 1;
	public const TraceOptions DateTime = 2;
	public const TraceOptions Timestamp = 4;
	public const TraceOptions ProcessId = 8;
	public const TraceOptions ThreadId = 16;
	public const TraceOptions Callstack = 32;
}

// Namespace: System.Diagnostics
[SwitchLevel(typeof(TraceLevel))]
public class TraceSwitch : Switch // TypeDefIndex: 7484
{
	// Methods

	// RVA: 0x1E0EFB0 Offset: 0x1E0D5B0 VA: 0x181E0EFB0
	public void .ctor(string displayName, string description) { }
}

// Namespace: System.Diagnostics
internal class AsyncStreamReader // TypeDefIndex: 7485
{
	// Fields
	private Stream stream; // 0x10
	private Encoding encoding; // 0x18
	private Decoder decoder; // 0x20
	private byte[] byteBuffer; // 0x28
	private char[] charBuffer; // 0x30
	private bool cancelOperation; // 0x38
	private ManualResetEvent eofEvent; // 0x40
	private object syncObject; // 0x48
	private IAsyncResult asyncReadResult; // 0x50

	// Methods

	// RVA: 0x1DBFEE0 Offset: 0x1DBE4E0 VA: 0x181DBFEE0 Slot: 4
	public virtual void Close() { }

	// RVA: 0x1DF8F80 Offset: 0x1DF7580 VA: 0x181DF8F80 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1DF8F70 Offset: 0x1DF7570 VA: 0x181DF8F70
	internal void CancelOperation() { }
}

// Namespace: System.Diagnostics
[DefaultProperty("StartInfo")]
[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
[DefaultEvent("Exited")]
public class Process : Component // TypeDefIndex: 7489
{
	// Fields
	private bool haveProcessId; // 0x28
	private int processId; // 0x2C
	private bool haveProcessHandle; // 0x30
	private SafeProcessHandle m_processHandle; // 0x38
	private bool isRemoteMachine; // 0x40
	private string machineName; // 0x48
	private int m_processAccess; // 0x50
	private ProcessThreadCollection threads; // 0x58
	private ProcessModuleCollection modules; // 0x60
	private bool haveWorkingSetLimits; // 0x68
	private bool havePriorityClass; // 0x69
	private ProcessStartInfo startInfo; // 0x70
	private bool watchForExit; // 0x78
	private bool watchingForExit; // 0x79
	private EventHandler onExited; // 0x80
	private bool exited; // 0x88
	private int exitCode; // 0x8C
	private bool signaled; // 0x90
	private bool haveExitTime; // 0x91
	private bool raisedOnExited; // 0x92
	private RegisteredWaitHandle registeredWaitHandle; // 0x98
	private WaitHandle waitHandle; // 0xA0
	private ISynchronizeInvoke synchronizingObject; // 0xA8
	private StreamReader standardOutput; // 0xB0
	private StreamWriter standardInput; // 0xB8
	private StreamReader standardError; // 0xC0
	private bool disposed; // 0xC8
	private Process.StreamReadMode outputStreamReadMode; // 0xCC
	private Process.StreamReadMode errorStreamReadMode; // 0xD0
	private Process.StreamReadMode inputStreamReadMode; // 0xD4
	internal AsyncStreamReader output; // 0xD8
	internal AsyncStreamReader error; // 0xE0
	private string process_name; // 0xE8

	// Properties
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("Indicates if the process component is associated with a real process.")]
	private bool Associated { get; }
	[MonitoringDescription("Indicates if the associated process has been terminated.")]
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public bool HasExited { get; }
	[MonitoringDescription("Returns the native handle for this process.   The handle is only available if the process was started using this component.")]
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public IntPtr Handle { get; }
	[MonitoringDescription("The unique identifier for the process.")]
	[DesignerSerializationVisibility(0)]
	public int Id { get; }
	[MonitoringDescription("Specifies information used to start a process.")]
	[Browsable(False)]
	[DesignerSerializationVisibility(2)]
	public ProcessStartInfo StartInfo { get; set; }
	[DefaultValue(null)]
	[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
	[Browsable(False)]
	public ISynchronizeInvoke SynchronizingObject { get; }
	[Browsable(False)]
	[DefaultValue(False)]
	[MonitoringDescription("Whether the process component should watch for the associated process to exit, and raise the Exited event.")]
	public bool EnableRaisingEvents { set; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The name of this process.")]
	public string ProcessName { get; }
	private static bool IsWindows { get; }

	// Methods

	// RVA: 0x1DFF000 Offset: 0x1DFD600 VA: 0x181DFF000
	public void .ctor() { }

	// RVA: 0x1DFF090 Offset: 0x1DFD690 VA: 0x181DFF090
	private void .ctor(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	// RVA: 0x1DFF1E0 Offset: 0x1DFD7E0 VA: 0x181DFF1E0
	private bool get_Associated() { }

	// RVA: 0x1DFF230 Offset: 0x1DFD830 VA: 0x181DFF230
	public bool get_HasExited() { }

	// RVA: 0x1DFF1F0 Offset: 0x1DFD7F0 VA: 0x181DFF1F0
	public IntPtr get_Handle() { }

	// RVA: 0x1DFF580 Offset: 0x1DFDB80 VA: 0x181DFF580
	public int get_Id() { }

	// RVA: 0x1DFF820 Offset: 0x1DFDE20 VA: 0x181DFF820
	public ProcessStartInfo get_StartInfo() { }

	// RVA: 0x1DFFB90 Offset: 0x1DFE190 VA: 0x181DFFB90
	public void set_StartInfo(ProcessStartInfo value) { }

	// RVA: 0x1DFF8F0 Offset: 0x1DFDEF0 VA: 0x181DFF8F0
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0x1DFFB20 Offset: 0x1DFE120 VA: 0x181DFFB20
	public void set_EnableRaisingEvents(bool value) { }

	// RVA: 0x1DFF130 Offset: 0x1DFD730 VA: 0x181DFF130
	public void add_Exited(EventHandler value) { }

	// RVA: 0x1DFFA70 Offset: 0x1DFE070 VA: 0x181DFFA70
	public void remove_Exited(EventHandler value) { }

	// RVA: 0x1DFD4A0 Offset: 0x1DFBAA0 VA: 0x181DFD4A0
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	// RVA: 0x1DFC310 Offset: 0x1DFA910 VA: 0x181DFC310
	private void CompletionCallback(object context, bool wasSignaled) { }

	// RVA: 0x1DFC660 Offset: 0x1DFAC60 VA: 0x181DFC660 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1DFC0F0 Offset: 0x1DFA6F0 VA: 0x181DFC0F0
	public void Close() { }

	// RVA: 0x1DFC6B0 Offset: 0x1DFACB0 VA: 0x181DFC6B0
	private void EnsureState(Process.State state) { }

	// RVA: 0x1DFC930 Offset: 0x1DFAF30 VA: 0x181DFC930
	private void EnsureWatchingForExit() { }

	// RVA: 0x1DFCB70 Offset: 0x1DFB170 VA: 0x181DFCB70
	public static Process GetCurrentProcess() { }

	// RVA: 0x1DFCF90 Offset: 0x1DFB590 VA: 0x181DFCF90
	protected void OnExited() { }

	// RVA: 0x1DFCC40 Offset: 0x1DFB240 VA: 0x181DFCC40
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	// RVA: 0x1DFCF80 Offset: 0x1DFB580 VA: 0x181DFCF80
	private SafeProcessHandle GetProcessHandle(int access) { }

	// RVA: 0x1DFD1F0 Offset: 0x1DFB7F0 VA: 0x181DFD1F0
	private SafeProcessHandle OpenProcessHandle() { }

	// RVA: 0x1DFD200 Offset: 0x1DFB800 VA: 0x181DFD200
	private SafeProcessHandle OpenProcessHandle(int access) { }

	// RVA: 0x1DFD450 Offset: 0x1DFBA50 VA: 0x181DFD450
	public void Refresh() { }

	// RVA: 0x1DFD4C0 Offset: 0x1DFBAC0 VA: 0x181DFD4C0
	private void SetProcessHandle(SafeProcessHandle processHandle) { }

	// RVA: 0x1DFD500 Offset: 0x1DFBB00 VA: 0x181DFD500
	private void SetProcessId(int processId) { }

	// RVA: 0x1DFE970 Offset: 0x1DFCF70 VA: 0x181DFE970
	public bool Start() { }

	// RVA: 0x1DFED80 Offset: 0x1DFD380 VA: 0x181DFED80
	public static Process Start(string fileName) { }

	// RVA: 0x1DFEAF0 Offset: 0x1DFD0F0 VA: 0x181DFEAF0
	public static Process Start(ProcessStartInfo startInfo) { }

	// RVA: 0x1DFEDF0 Offset: 0x1DFD3F0 VA: 0x181DFEDF0
	private void StopWatchingForExit() { }

	// RVA: 0x1DFEF00 Offset: 0x1DFD500 VA: 0x181DFEF00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DFD2C0 Offset: 0x1DFB8C0 VA: 0x181DFD2C0
	private static string ProcessName_icall(IntPtr handle) { }

	// RVA: 0x1DFD2D0 Offset: 0x1DFB8D0 VA: 0x181DFD2D0
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	// RVA: 0x1DFF5D0 Offset: 0x1DFDBD0 VA: 0x181DFF5D0
	public string get_ProcessName() { }

	// RVA: 0x1353770 Offset: 0x1351D70 VA: 0x181353770
	private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo) { }

	// RVA: 0x1353770 Offset: 0x1351D70 VA: 0x181353770
	private static bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref Process.ProcInfo procInfo) { }

	// RVA: 0x1DFE4D0 Offset: 0x1DFCAD0 VA: 0x181DFE4D0
	private bool StartWithShellExecuteEx(ProcessStartInfo startInfo) { }

	// RVA: 0x1DFC330 Offset: 0x1DFA930 VA: 0x181DFC330
	private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection) { }

	// RVA: 0x1DFF5A0 Offset: 0x1DFDBA0 VA: 0x181DFF5A0
	private static bool get_IsWindows() { }

	// RVA: 0x1DFD510 Offset: 0x1DFBB10 VA: 0x181DFD510
	private bool StartWithCreateProcess(ProcessStartInfo startInfo) { }

	// RVA: 0x1DFCA60 Offset: 0x1DFB060 VA: 0x181DFCA60
	private static void FillUserInfo(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo) { }

	// RVA: 0x1DFD3A0 Offset: 0x1DFB9A0 VA: 0x181DFD3A0
	private void RaiseOnExited() { }
}

// Namespace: System.Diagnostics
internal class ProcessInfo // TypeDefIndex: 7490
{}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
public class ProcessModuleCollection : ReadOnlyCollectionBase // TypeDefIndex: 7491
{}

// Namespace: System.Diagnostics
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ProcessStartInfo // TypeDefIndex: 7492
{
	// Fields
	private string fileName; // 0x10
	private string arguments; // 0x18
	private string directory; // 0x20
	private string verb; // 0x28
	private ProcessWindowStyle windowStyle; // 0x30
	private bool errorDialog; // 0x34
	private IntPtr errorDialogParentHandle; // 0x38
	private bool useShellExecute; // 0x40
	private string userName; // 0x48
	private string domain; // 0x50
	private SecureString password; // 0x58
	private string passwordInClearText; // 0x60
	private bool loadUserProfile; // 0x68
	private bool redirectStandardInput; // 0x69
	private bool redirectStandardOutput; // 0x6A
	private bool redirectStandardError; // 0x6B
	private Encoding standardOutputEncoding; // 0x70
	private Encoding standardErrorEncoding; // 0x78
	private bool createNoWindow; // 0x80
	private WeakReference weakParentProcess; // 0x88
	internal StringDictionary environmentVariables; // 0x90
	private static readonly string[] empty; // 0x0
	private Collection<string> _argumentList; // 0x98
	private IDictionary<string, string> environment; // 0xA0
	[CompilerGenerated]
	private Encoding <StandardInputEncoding>k__BackingField; // 0xA8

	// Properties
	public Collection<string> ArgumentList { get; }
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[SettingsBindable(True)]
	[DefaultValue("")]
	[NotifyParentProperty(True)]
	[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
	public string Arguments { get; set; }
	[DesignerSerializationVisibility(2)]
	[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
	[DefaultValue(null)]
	[NotifyParentProperty(True)]
	public StringDictionary EnvironmentVariables { get; }
	[DefaultValue(False)]
	[MonitoringDescription("Whether the process command input is read from the Process instance's StandardInput member.")]
	[NotifyParentProperty(True)]
	public bool RedirectStandardInput { get; }
	[NotifyParentProperty(True)]
	[MonitoringDescription("Whether the process output is written to the Process instance's StandardOutput member.")]
	[DefaultValue(False)]
	public bool RedirectStandardOutput { get; }
	[MonitoringDescription("Whether the process's error output is written to the Process instance's StandardError member.")]
	[NotifyParentProperty(True)]
	[DefaultValue(False)]
	public bool RedirectStandardError { get; }
	public Encoding StandardErrorEncoding { get; }
	public Encoding StandardOutputEncoding { get; }
	[DefaultValue(True)]
	[MonitoringDescription("Whether to use the operating system shell to start the process.")]
	[NotifyParentProperty(True)]
	public bool UseShellExecute { get; set; }
	[NotifyParentProperty(True)]
	public string UserName { get; }
	public SecureString Password { get; }
	[NotifyParentProperty(True)]
	public string Domain { get; }
	[NotifyParentProperty(True)]
	public bool LoadUserProfile { get; }
	[MonitoringDescription("The name of the application, document or URL to start.")]
	[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[NotifyParentProperty(True)]
	[DefaultValue("")]
	[SettingsBindable(True)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string FileName { get; set; }
	[NotifyParentProperty(True)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[SettingsBindable(True)]
	[DefaultValue("")]
	[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("The initial working directory for the process.")]
	public string WorkingDirectory { get; }
	internal bool HaveEnvVars { get; }
	public Encoding StandardInputEncoding { get; }

	// Methods

	// RVA: 0x1DFBB20 Offset: 0x1DFA120 VA: 0x181DFBB20
	public void .ctor() { }

	// RVA: 0x1DFBA90 Offset: 0x1DFA090 VA: 0x181DFBA90
	internal void .ctor(Process parent) { }

	// RVA: 0x1DFBA50 Offset: 0x1DFA050 VA: 0x181DFBA50
	public void .ctor(string fileName) { }

	// RVA: 0x1DFBB30 Offset: 0x1DFA130 VA: 0x181DFBB30
	public Collection<string> get_ArgumentList() { }

	// RVA: 0x1D2CBB0 Offset: 0x1D2B1B0 VA: 0x181D2CBB0
	public string get_Arguments() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Arguments(string value) { }

	// RVA: 0x1DFBBE0 Offset: 0x1DFA1E0 VA: 0x181DFBBE0
	public StringDictionary get_EnvironmentVariables() { }

	// RVA: 0x534E70 Offset: 0x533470 VA: 0x180534E70
	public bool get_RedirectStandardInput() { }

	// RVA: 0x1CC49C0 Offset: 0x1CC2FC0 VA: 0x181CC49C0
	public bool get_RedirectStandardOutput() { }

	// RVA: 0x1D63850 Offset: 0x1D61E50 VA: 0x181D63850
	public bool get_RedirectStandardError() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public Encoding get_StandardErrorEncoding() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public Encoding get_StandardOutputEncoding() { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_UseShellExecute() { }

	// RVA: 0x40E2F0 Offset: 0x40C8F0 VA: 0x18040E2F0
	public void set_UseShellExecute(bool value) { }

	// RVA: 0x1DFC070 Offset: 0x1DFA670 VA: 0x181DFC070
	public string get_UserName() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public SecureString get_Password() { }

	// RVA: 0x1DFBBC0 Offset: 0x1DFA1C0 VA: 0x181DFBBC0
	public string get_Domain() { }

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	public bool get_LoadUserProfile() { }

	// RVA: 0x1D1DA70 Offset: 0x1D1C070 VA: 0x181D1DA70
	public string get_FileName() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_FileName(string value) { }

	// RVA: 0x1D60ED0 Offset: 0x1D5F4D0 VA: 0x181D60ED0
	public string get_WorkingDirectory() { }

	// RVA: 0x1DFC060 Offset: 0x1DFA660 VA: 0x181DFC060
	internal bool get_HaveEnvVars() { }

	[CompilerGenerated]
	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public Encoding get_StandardInputEncoding() { }

	// RVA: 0x1DFB9E0 Offset: 0x1DF9FE0 VA: 0x181DFB9E0
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
public class ProcessThreadCollection : ReadOnlyCollectionBase // TypeDefIndex: 7493
{}

// Namespace: System.Diagnostics
internal class ProcessWaitHandle : WaitHandle // TypeDefIndex: 7494
{
	// Methods

	// RVA: 0x1DFC090 Offset: 0x1DFA690 VA: 0x181DFC090
	internal void .ctor(SafeProcessHandle processHandle) { }
}

// Namespace: System.Diagnostics
public class DefaultTraceListener : TraceListener // TypeDefIndex: 7495
{
	// Fields
	private static readonly bool OnWin32; // 0x0
	private static readonly string MonoTracePrefix; // 0x8
	private static readonly string MonoTraceFile; // 0x10
	private string logFileName; // 0x38

	// Properties
	[MonoTODO]
	public string LogFileName { get; }

	// Methods

	// RVA: 0x1DF9B40 Offset: 0x1DF8140 VA: 0x181DF9B40
	private static void .cctor() { }

	// RVA: 0x1DF9420 Offset: 0x1DF7A20 VA: 0x181DF9420
	private static string GetPrefix(string var, string target) { }

	// RVA: 0x1DF9D10 Offset: 0x1DF8310 VA: 0x181DF9D10
	public void .ctor() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_LogFileName() { }

	// RVA: 0x1DF9B20 Offset: 0x1DF8120 VA: 0x181DF9B20
	private static void WriteWindowsDebugString(char* message) { }

	// RVA: 0x1DF9490 Offset: 0x1DF7A90 VA: 0x181DF9490
	private void WriteDebugString(string message) { }

	// RVA: 0x1DF98B0 Offset: 0x1DF7EB0 VA: 0x181DF98B0
	private void WriteMonoTrace(string message) { }

	// RVA: 0x1DF9A90 Offset: 0x1DF8090 VA: 0x181DF9A90
	private void WritePrefix() { }

	// RVA: 0x1DF9540 Offset: 0x1DF7B40 VA: 0x181DF9540
	private void WriteImpl(string message) { }

	// RVA: 0x1DF9750 Offset: 0x1DF7D50 VA: 0x181DF9750
	private void WriteLogFile(string message, string logFile) { }

	// RVA: 0x1DF9B30 Offset: 0x1DF8130 VA: 0x181DF9B30 Slot: 10
	public override void Write(string message) { }

	// RVA: 0x1DF9700 Offset: 0x1DF7D00 VA: 0x181DF9700 Slot: 12
	public override void WriteLine(string message) { }
}

// Namespace: System.Diagnostics
[Usage(32767)]
public class MonitoringDescriptionAttribute : DescriptionAttribute // TypeDefIndex: 7496
{
	// Properties
	public override string Description { get; }

	// Methods

	// RVA: 0x1DFB970 Offset: 0x1DF9F70 VA: 0x181DFB970
	public void .ctor(string description) { }

	// RVA: 0x1DFB9D0 Offset: 0x1DF9FD0 VA: 0x181DFB9D0 Slot: 7
	public override string get_Description() { }
}

// Namespace: System.Diagnostics
public enum ProcessWindowStyle // TypeDefIndex: 7497
{
	// Fields
	public int value__; // 0x0
	public const ProcessWindowStyle Hidden = 1;
	public const ProcessWindowStyle Maximized = 3;
	public const ProcessWindowStyle Minimized = 2;
	public const ProcessWindowStyle Normal = 0;
}

// Namespace: System.Diagnostics
public class Stopwatch // TypeDefIndex: 7498
{
	// Fields
	public static readonly long Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private long elapsed; // 0x10
	private long started; // 0x18
	private bool is_running; // 0x20

	// Properties
	public TimeSpan Elapsed { get; }
	public long ElapsedMilliseconds { get; }
	public long ElapsedTicks { get; }
	public bool IsRunning { get; }

	// Methods

	// RVA: 0x15A2C50 Offset: 0x15A1250 VA: 0x1815A2C50
	public static long GetTimestamp() { }

	// RVA: 0x1E0BBD0 Offset: 0x1E0A1D0 VA: 0x181E0BBD0
	public static Stopwatch StartNew() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1E0C100 Offset: 0x1E0A700 VA: 0x181E0C100
	public TimeSpan get_Elapsed() { }

	// RVA: 0x1E0BDA0 Offset: 0x1E0A3A0 VA: 0x181E0BDA0
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x1E0C090 Offset: 0x1E0A690 VA: 0x181E0C090
	public long get_ElapsedTicks() { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_IsRunning() { }

	// RVA: 0x1E0BB60 Offset: 0x1E0A160 VA: 0x181E0BB60
	public void Reset() { }

	// RVA: 0x1E0BC70 Offset: 0x1E0A270 VA: 0x181E0BC70
	public void Start() { }

	// RVA: 0x1E0BCD0 Offset: 0x1E0A2D0 VA: 0x181E0BCD0
	public void Stop() { }

	// RVA: 0x1E0BB70 Offset: 0x1E0A170 VA: 0x181E0BB70
	public void Restart() { }

	// RVA: 0x1E0BD50 Offset: 0x1E0A350 VA: 0x181E0BD50
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler // TypeDefIndex: 8007
{
	// Methods

	// RVA: 0x1DAE080 Offset: 0x1DAC680 VA: 0x181DAE080
	public void .ctor() { }

	// RVA: 0x1DAE050 Offset: 0x1DAC650 VA: 0x181DAE050 Slot: 4
	public virtual object Create(object parent, object configContext, XmlNode section) { }
}

