// Namespace: System.Runtime.Remoting.Services
[ComVisible(True)]
public interface ITrackingHandler // TypeDefIndex: 857
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DisconnectedObject(object obj);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarshaledObject(object obj, ObjRef or);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UnmarshaledObject(object obj, ObjRef or);
}

// Namespace: System.Runtime.Remoting.Services
[ComVisible(True)]
public class TrackingServices // TypeDefIndex: 858
{
	// Fields
	private static ArrayList _handlers; // 0x0

	// Methods

	// RVA: 0x13D28F0 Offset: 0x13D0EF0 VA: 0x1813D28F0
	internal static void NotifyMarshaledObject(object obj, ObjRef or) { }

	// RVA: 0x13D2C40 Offset: 0x13D1240 VA: 0x1813D2C40
	internal static void NotifyUnmarshaledObject(object obj, ObjRef or) { }

	// RVA: 0x13D25C0 Offset: 0x13D0BC0 VA: 0x1813D25C0
	internal static void NotifyDisconnectedObject(object obj) { }

	// RVA: 0x13D2F90 Offset: 0x13D1590 VA: 0x1813D2F90
	private static void .cctor() { }
}

