// Namespace: UnityEngine.ResourceManagement.ResourceLocations
public interface ILocationSizeData // TypeDefIndex: 12722
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long ComputeSize(IResourceLocation location, ResourceManager resourceManager);
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
public interface IResourceLocation // TypeDefIndex: 12723
{
	// Properties
	public abstract string InternalId { get; }
	public abstract string ProviderId { get; }
	public abstract IList<IResourceLocation> Dependencies { get; }
	public abstract int DependencyHashCode { get; }
	public abstract bool HasDependencies { get; }
	public abstract object Data { get; }
	public abstract string PrimaryKey { get; }
	public abstract Type ResourceType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_InternalId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ProviderId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IList<IResourceLocation> get_Dependencies();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int Hash(Type resultType);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_DependencyHashCode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_HasDependencies();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object get_Data();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_PrimaryKey();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Type get_ResourceType();
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
public class ResourceLocationBase : IResourceLocation // TypeDefIndex: 12724
{
	// Fields
	private string m_Name; // 0x10
	private string m_Id; // 0x18
	private string m_ProviderId; // 0x20
	private object m_Data; // 0x28
	private int m_DependencyHashCode; // 0x30
	private int m_HashCode; // 0x34
	private Type m_Type; // 0x38
	private List<IResourceLocation> m_Dependencies; // 0x40
	private string m_PrimaryKey; // 0x48

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public bool HasDependencies { get; }
	public object Data { get; set; }
	public string PrimaryKey { get; set; }
	public int DependencyHashCode { get; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 4
	public string get_InternalId() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x2126940 Offset: 0x2124F40 VA: 0x182126940 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 10
	public object get_Data() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_Data(object value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_PrimaryKey(string value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x2126670 Offset: 0x2124C70 VA: 0x182126670 Slot: 7
	public int Hash(Type t) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 3
	public override string ToString() { }

	// RVA: 0x21266C0 Offset: 0x2124CC0 VA: 0x1821266C0
	public void .ctor(string name, string id, string providerId, Type t, IResourceLocation[] dependencies) { }

	// RVA: 0x2126450 Offset: 0x2124A50 VA: 0x182126450
	public void ComputeDependencyHash() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceLocations
internal class LocationWrapper : IResourceLocation // TypeDefIndex: 12725
{
	// Fields
	private IResourceLocation m_InternalLocation; // 0x10

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public int DependencyHashCode { get; }
	public bool HasDependencies { get; }
	public object Data { get; }
	public string PrimaryKey { get; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(IResourceLocation location) { }

	// RVA: 0x2124350 Offset: 0x2122950 VA: 0x182124350 Slot: 4
	public string get_InternalId() { }

	// RVA: 0x21243F0 Offset: 0x21229F0 VA: 0x1821243F0 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x2124260 Offset: 0x2122860 VA: 0x182124260 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x21242B0 Offset: 0x21228B0 VA: 0x1821242B0 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x2124300 Offset: 0x2122900 VA: 0x182124300 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x2124210 Offset: 0x2122810 VA: 0x182124210 Slot: 10
	public object get_Data() { }

	// RVA: 0x21243A0 Offset: 0x21229A0 VA: 0x1821243A0 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x2124440 Offset: 0x2122A40 VA: 0x182124440 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x21241B0 Offset: 0x21227B0 VA: 0x1821241B0 Slot: 7
	public int Hash(Type resultType) { }
}

