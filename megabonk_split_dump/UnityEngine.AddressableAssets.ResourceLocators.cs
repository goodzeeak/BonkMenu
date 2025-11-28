// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public class ContentCatalogDataEntry // TypeDefIndex: 13142
{
	// Fields
	[CompilerGenerated]
	private string <InternalId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Provider>k__BackingField; // 0x18
	[CompilerGenerated]
	private List<object> <Keys>k__BackingField; // 0x20
	[CompilerGenerated]
	private List<object> <Dependencies>k__BackingField; // 0x28
	[CompilerGenerated]
	private object <Data>k__BackingField; // 0x30
	[CompilerGenerated]
	private Type <ResourceType>k__BackingField; // 0x38

	// Properties
	public string InternalId { get; set; }
	public string Provider { get; set; }
	public List<object> Keys { get; set; }
	public List<object> Dependencies { get; set; }
	public object Data { get; set; }
	public Type ResourceType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_InternalId() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_InternalId(string value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_Provider(string value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<object> get_Keys() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_Keys(List<object> value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public List<object> get_Dependencies() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	private void set_Dependencies(List<object> value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public object get_Data() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_Data(object value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public Type get_ResourceType() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	private void set_ResourceType(Type value) { }

	// RVA: 0x1EB3E30 Offset: 0x1EB2430 VA: 0x181EB3E30
	public void .ctor(Type type, string internalId, string provider, IEnumerable<object> keys, IEnumerable<object> dependencies, object extraData) { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
[Serializable]
public class ContentCatalogData // TypeDefIndex: 13146
{
	// Fields
	private static int kMagic; // 0x0
	private const int kVersion = 1;
	internal string localHash; // 0x10
	internal IResourceLocation location; // 0x18
	[SerializeField]
	internal string m_LocatorId; // 0x20
	[SerializeField]
	internal string m_BuildResultHash; // 0x28
	[SerializeField]
	private ObjectInitializationData m_InstanceProviderData; // 0x30
	[SerializeField]
	private ObjectInitializationData m_SceneProviderData; // 0x60
	[SerializeField]
	internal List<ObjectInitializationData> m_ResourceProviderData; // 0x90
	private IList<ContentCatalogDataEntry> m_Entries; // 0x98
	[FormerlySerializedAs("m_providerIds")]
	[SerializeField]
	internal string[] m_ProviderIds; // 0xA0
	[FormerlySerializedAs("m_internalIds")]
	[SerializeField]
	internal string[] m_InternalIds; // 0xA8
	[FormerlySerializedAs("m_keyDataString")]
	[SerializeField]
	internal string m_KeyDataString; // 0xB0
	[FormerlySerializedAs("m_bucketDataString")]
	[SerializeField]
	internal string m_BucketDataString; // 0xB8
	[FormerlySerializedAs("m_entryDataString")]
	[SerializeField]
	internal string m_EntryDataString; // 0xC0
	private const int kBytesPerInt32 = 4;
	private const int k_EntryDataItemPerEntry = 7;
	[FormerlySerializedAs("m_extraDataString")]
	[SerializeField]
	internal string m_ExtraDataString; // 0xC8
	[SerializeField]
	internal SerializedType[] m_resourceTypes; // 0xD0
	[SerializeField]
	private string[] m_InternalIdPrefixes; // 0xD8

	// Properties
	public string ProviderId { get; set; }
	public ObjectInitializationData InstanceProviderData { get; set; }
	public ObjectInitializationData SceneProviderData { get; set; }
	public List<ObjectInitializationData> ResourceProviderData { get; set; }
	public string[] ProviderIds { get; }
	public string[] InternalIds { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_ProviderId() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_ProviderId(string value) { }

	// RVA: 0x1EB5A00 Offset: 0x1EB4000 VA: 0x181EB5A00
	public ObjectInitializationData get_InstanceProviderData() { }

	// RVA: 0x1EB5A40 Offset: 0x1EB4040 VA: 0x181EB5A40
	public void set_InstanceProviderData(ObjectInitializationData value) { }

	// RVA: 0x1EB5A20 Offset: 0x1EB4020 VA: 0x181EB5A20
	public ObjectInitializationData get_SceneProviderData() { }

	// RVA: 0x1EB5A70 Offset: 0x1EB4070 VA: 0x181EB5A70
	public void set_SceneProviderData(ObjectInitializationData value) { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public List<ObjectInitializationData> get_ResourceProviderData() { }

	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	public void set_ResourceProviderData(List<ObjectInitializationData> value) { }

	// RVA: 0x1EB58E0 Offset: 0x1EB3EE0 VA: 0x181EB58E0
	public void .ctor(string id) { }

	// RVA: 0x1EB5980 Offset: 0x1EB3F80 VA: 0x181EB5980
	public void .ctor() { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public string[] get_ProviderIds() { }

	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public string[] get_InternalIds() { }

	// RVA: 0x1EB57F0 Offset: 0x1EB3DF0 VA: 0x181EB57F0
	internal static ContentCatalogData LoadFromFile(string path, int cacheSize = 1024) { }

	// RVA: 0x1EB5840 Offset: 0x1EB3E40 VA: 0x181EB5840
	internal void SaveToFile(string path) { }

	// RVA: 0x1EB3F60 Offset: 0x1EB2560 VA: 0x181EB3F60
	internal void CleanData() { }

	// RVA: 0x1EB4090 Offset: 0x1EB2690 VA: 0x181EB4090
	internal ResourceLocationMap CreateCustomLocator(string overrideId = "", string providerSuffix) { }

	// RVA: 0x1EB40D0 Offset: 0x1EB26D0 VA: 0x181EB40D0
	public ResourceLocationMap CreateLocator(string providerSuffix) { }

	// RVA: 0x1EB4E20 Offset: 0x1EB3420 VA: 0x181EB4E20
	internal IList<ContentCatalogDataEntry> GetData() { }

	// RVA: 0x1EB4D50 Offset: 0x1EB3350 VA: 0x181EB4D50
	internal static string ExpandInternalId(string[] internalIdPrefixes, string v) { }

	// RVA: 0x1EB5870 Offset: 0x1EB3E70 VA: 0x181EB5870
	private static void .cctor() { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public interface IResourceLocator // TypeDefIndex: 13147
{
	// Properties
	public abstract string LocatorId { get; }
	public abstract IEnumerable<object> Keys { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_LocatorId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerable<object> get_Keys();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Locate(object key, Type type, out IList<IResourceLocation> locations);
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public class LegacyResourcesLocator : IResourceLocator // TypeDefIndex: 13148
{
	// Properties
	public IEnumerable<object> Keys { get; }
	public string LocatorId { get; }

	// Methods

	// RVA: 0x1EBE390 Offset: 0x1EBC990 VA: 0x181EBE390 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public IEnumerable<object> get_Keys() { }

	// RVA: 0x1EBE570 Offset: 0x1EBCB70 VA: 0x181EBE570 Slot: 4
	public string get_LocatorId() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
[Serializable]
public class ResourceLocationData // TypeDefIndex: 13149
{
	// Fields
	[FormerlySerializedAs("m_keys")]
	[SerializeField]
	private string[] m_Keys; // 0x10
	[FormerlySerializedAs("m_internalId")]
	[SerializeField]
	private string m_InternalId; // 0x18
	[FormerlySerializedAs("m_provider")]
	[SerializeField]
	private string m_Provider; // 0x20
	[FormerlySerializedAs("m_dependencies")]
	[SerializeField]
	private string[] m_Dependencies; // 0x28
	[SerializeField]
	private SerializedType m_ResourceType; // 0x30
	[SerializeField]
	private byte[] SerializedData; // 0x50
	private object _Data; // 0x58

	// Properties
	public string[] Keys { get; }
	public string InternalId { get; }
	public string Provider { get; }
	public string[] Dependencies { get; }
	public Type ResourceType { get; }
	public object Data { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string[] get_Keys() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_InternalId() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Provider() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string[] get_Dependencies() { }

	// RVA: 0x1EBF350 Offset: 0x1EBD950 VA: 0x181EBF350
	public Type get_ResourceType() { }

	// RVA: 0x1EBF2F0 Offset: 0x1EBD8F0 VA: 0x181EBF2F0
	public object get_Data() { }

	// RVA: 0x1EBF360 Offset: 0x1EBD960 VA: 0x181EBF360
	public void set_Data(object value) { }

	// RVA: 0x1EBF1A0 Offset: 0x1EBD7A0 VA: 0x181EBF1A0
	public void .ctor(string[] keys, string id, Type provider, Type t, string[] dependencies) { }
}

// Namespace: UnityEngine.AddressableAssets.ResourceLocators
public class ResourceLocationMap : IResourceLocator // TypeDefIndex: 13150
{
	// Fields
	[CompilerGenerated]
	private string <LocatorId>k__BackingField; // 0x10
	private Dictionary<object, IList<IResourceLocation>> locations; // 0x18

	// Properties
	public string LocatorId { get; set; }
	public Dictionary<object, IList<IResourceLocation>> Locations { get; }
	public IEnumerable<object> Keys { get; }

	// Methods

	// RVA: 0x1EBFBA0 Offset: 0x1EBE1A0 VA: 0x181EBFBA0
	public void .ctor(string id, int capacity = 0) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public string get_LocatorId() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_LocatorId(string value) { }

	// RVA: 0x1EBFC50 Offset: 0x1EBE250 VA: 0x181EBFC50
	public void .ctor(string id, IList<ResourceLocationData> locations) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Dictionary<object, IList<IResourceLocation>> get_Locations() { }

	// RVA: 0x1EC0560 Offset: 0x1EBEB60 VA: 0x181EC0560 Slot: 5
	public IEnumerable<object> get_Keys() { }

	// RVA: 0x1EBF5A0 Offset: 0x1EBDBA0 VA: 0x181EBF5A0 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x1EBF410 Offset: 0x1EBDA10 VA: 0x181EBF410
	public void Add(object key, IResourceLocation location) { }

	// RVA: 0x1EBF530 Offset: 0x1EBDB30 VA: 0x181EBF530
	public void Add(object key, IList<IResourceLocation> locations) { }
}

