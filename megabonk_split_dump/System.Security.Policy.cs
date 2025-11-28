// Namespace: System.Security.Policy
[ComVisible(True)]
[MonoTODO("Serialization format not compatible with .NET")]
[Serializable]
public sealed class Evidence : ICollection, IEnumerable // TypeDefIndex: 725
{
	// Fields
	private bool _locked; // 0x10
	private ArrayList hostEvidenceList; // 0x18
	private ArrayList assemblyEvidenceList; // 0x20

	// Properties
	[Obsolete]
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1386A50 Offset: 0x1385050 VA: 0x181386A50 Slot: 5
	public int get_Count() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 6
	public object get_SyncRoot() { }

	[Obsolete]
	// RVA: 0x13868C0 Offset: 0x1384EC0 VA: 0x1813868C0 Slot: 4
	public void CopyTo(Array array, int index) { }

	[Obsolete]
	// RVA: 0x1386980 Offset: 0x1384F80 VA: 0x181386980 Slot: 8
	public IEnumerator GetEnumerator() { }
}

