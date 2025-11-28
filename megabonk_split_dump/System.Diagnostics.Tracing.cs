// Namespace: System.Diagnostics.Tracing
public enum EventLevel // TypeDefIndex: 1414
{
	// Fields
	public int value__; // 0x0
	public const EventLevel LogAlways = 0;
	public const EventLevel Critical = 1;
	public const EventLevel Error = 2;
	public const EventLevel Warning = 3;
	public const EventLevel Informational = 4;
	public const EventLevel Verbose = 5;
}

// Namespace: System.Diagnostics.Tracing
[Flags]
public enum EventKeywords // TypeDefIndex: 1415
{
	// Fields
	public long value__; // 0x0
	public const EventKeywords None = 0;
	public const EventKeywords All = -1;
	public const EventKeywords MicrosoftTelemetry = 562949953421312;
	public const EventKeywords WdiContext = 562949953421312;
	public const EventKeywords WdiDiagnostic = 1125899906842624;
	public const EventKeywords Sqm = 2251799813685248;
	public const EventKeywords AuditFailure = 4503599627370496;
	public const EventKeywords AuditSuccess = 9007199254740992;
	public const EventKeywords CorrelationHint = 4503599627370496;
	public const EventKeywords EventLogClassic = 36028797018963968;
}

// Namespace: System.Diagnostics.Tracing
[Usage(64)]
public sealed class EventAttribute : Attribute // TypeDefIndex: 1416
{
	// Fields
	[CompilerGenerated]
	private int <EventId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EventLevel <Level>k__BackingField; // 0x14
	[CompilerGenerated]
	private EventKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x20

	// Properties
	private int EventId { set; }
	public EventLevel Level { set; }
	public EventKeywords Keywords { set; }
	public string Message { set; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(int eventId) { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	private void set_EventId(int value) { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_Level(EventLevel value) { }

	[CompilerGenerated]
	// RVA: 0x14A5B00 Offset: 0x14A4100 VA: 0x1814A5B00
	public void set_Keywords(EventKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Message(string value) { }
}

// Namespace: System.Diagnostics.Tracing
public class EventSource : IDisposable // TypeDefIndex: 1418
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	private string Name { set; }

	// Methods

	// RVA: 0x14A3B90 Offset: 0x14A2190 VA: 0x1814A3B90
	protected void .ctor() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(string eventSourceName) { }

	// RVA: 0x14A6290 Offset: 0x14A4890 VA: 0x1814A6290
	internal void .ctor(Guid eventSourceGuid, string eventSourceName) { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_Name(string value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public bool IsEnabled() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	// RVA: 0x14A5B20 Offset: 0x14A4120 VA: 0x1814A5B20 Slot: 4
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14A5EB0 Offset: 0x14A44B0 VA: 0x1814A5EB0
	protected void WriteEvent(int eventId, int arg1) { }

	// RVA: 0x14A5B80 Offset: 0x14A4180 VA: 0x1814A5B80
	protected void WriteEvent(int eventId, string arg1) { }

	// RVA: 0x14A6170 Offset: 0x14A4770 VA: 0x1814A6170
	protected void WriteEvent(int eventId, int arg1, int arg2) { }

	// RVA: 0x14A5C20 Offset: 0x14A4220 VA: 0x1814A5C20
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	// RVA: 0x14A60B0 Offset: 0x14A46B0 VA: 0x1814A60B0
	protected void WriteEvent(int eventId, long arg1) { }

	// RVA: 0x14A5DB0 Offset: 0x14A43B0 VA: 0x1814A5DB0
	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	protected void WriteEvent(int eventId, object[] args) { }

	// RVA: 0x14A5F70 Offset: 0x14A4570 VA: 0x1814A5F70
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	[CLSCompliant(False)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	protected void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data) { }
}

// Namespace: System.Diagnostics.Tracing
[Usage(4)]
public sealed class EventSourceAttribute : Attribute // TypeDefIndex: 1419
{
	// Fields
	[CompilerGenerated]
	private string <Guid>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string Guid { set; }
	public string Name { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Guid(string value) { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Name(string value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Diagnostics.Tracing
[Usage(64)]
public sealed class NonEventAttribute : Attribute // TypeDefIndex: 1420
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

