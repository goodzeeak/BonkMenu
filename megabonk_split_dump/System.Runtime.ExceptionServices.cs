// Namespace: System.Runtime.ExceptionServices
public class FirstChanceExceptionEventArgs : EventArgs // TypeDefIndex: 1114
{}

// Namespace: System.Runtime.ExceptionServices
[Usage(64, AllowMultiple = False, Inherited = False)]
public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute // TypeDefIndex: 1115
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.ExceptionServices
public sealed class ExceptionDispatchInfo // TypeDefIndex: 1116
{
	// Fields
	private Exception m_Exception; // 0x10
	private object m_stackTrace; // 0x18

	// Properties
	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }

	// Methods

	// RVA: 0x1415E70 Offset: 0x1414470 VA: 0x181415E70
	private void .ctor(Exception exception) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0x1415BF0 Offset: 0x14141F0 VA: 0x181415BF0
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Exception get_SourceException() { }

	[StackTraceHidden]
	// RVA: 0x1415DF0 Offset: 0x14143F0 VA: 0x181415DF0
	public void Throw() { }

	[StackTraceHidden]
	// RVA: 0x1415E40 Offset: 0x1414440 VA: 0x181415E40
	public static void Throw(Exception source) { }
}

