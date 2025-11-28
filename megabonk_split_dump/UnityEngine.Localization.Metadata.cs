// Namespace: UnityEngine.Localization.Metadata
[Flags]
public enum MetadataType // TypeDefIndex: 12023
{
	// Fields
	public int value__; // 0x0
	public const MetadataType Locale = 1;
	public const MetadataType SharedTableData = 2;
	public const MetadataType StringTable = 4;
	public const MetadataType AssetTable = 8;
	public const MetadataType StringTableEntry = 16;
	public const MetadataType AssetTableEntry = 32;
	public const MetadataType SharedStringTableEntry = 64;
	public const MetadataType SharedAssetTableEntry = 128;
	public const MetadataType LocalizationSettings = 256;
	public const MetadataType AllTables = 12;
	public const MetadataType AllTableEntries = 48;
	public const MetadataType AllSharedTableEntries = 192;
	public const MetadataType All = 63;
}

// Namespace: UnityEngine.Localization.Metadata
[Usage(256)]
internal class MetadataTypeAttribute : PropertyAttribute // TypeDefIndex: 12024
{
	// Fields
	[CompilerGenerated]
	private MetadataType <Type>k__BackingField; // 0x10

	// Properties
	public MetadataType Type { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public MetadataType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_Type(MetadataType value) { }

	// RVA: 0x1F08FB0 Offset: 0x1F075B0 VA: 0x181F08FB0
	public void .ctor(MetadataType type) { }
}

// Namespace: UnityEngine.Localization.Metadata
[Usage(4)]
public class MetadataAttribute : Attribute // TypeDefIndex: 12025
{
	// Fields
	[CompilerGenerated]
	private string <MenuItem>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <AllowMultiple>k__BackingField; // 0x18
	[CompilerGenerated]
	private MetadataType <AllowedTypes>k__BackingField; // 0x1C

	// Properties
	public string MenuItem { get; set; }
	public bool AllowMultiple { get; set; }
	public MetadataType AllowedTypes { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_MenuItem() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_MenuItem(string value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_AllowMultiple() { }

	[CompilerGenerated]
	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	public void set_AllowMultiple(bool value) { }

	[CompilerGenerated]
	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public MetadataType get_AllowedTypes() { }

	[CompilerGenerated]
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_AllowedTypes(MetadataType value) { }

	// RVA: 0x1F08D90 Offset: 0x1F07390 VA: 0x181F08D90
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Metadata
[HideInInspector]
internal class AssetTypeMetadata : SharedTableCollectionMetadata // TypeDefIndex: 12026
{
	// Fields
	[SerializeField]
	[HideInInspector]
	internal string m_TypeString; // 0x20
	[CompilerGenerated]
	private Type <Type>k__BackingField; // 0x28

	// Properties
	public Type Type { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_Type(Type value) { }

	// RVA: 0x1F00CA0 Offset: 0x1EFF2A0 VA: 0x181F00CA0 Slot: 6
	public override void OnBeforeSerialize() { }

	// RVA: 0x1F00C00 Offset: 0x1EFF200 VA: 0x181F00C00 Slot: 7
	public override void OnAfterDeserialize() { }

	// RVA: 0x1F00CF0 Offset: 0x1EFF2F0 VA: 0x181F00CF0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Metadata
[Metadata]
[Serializable]
public class Comment : IMetadata // TypeDefIndex: 12027
{
	// Fields
	[SerializeField]
	[TextArea(1, 2147483647)]
	private string m_CommentText; // 0x10

	// Properties
	public string CommentText { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_CommentText() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_CommentText(string value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F01D10 Offset: 0x1F00310 VA: 0x181F01D10
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Metadata
[Metadata(AllowedTypes = 192)]
[Serializable]
public class ExcludeEntryFromExport : IMetadata // TypeDefIndex: 12028
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Metadata
[Metadata(AllowedTypes = 1)]
[Serializable]
public class FallbackLocale : IMetadata // TypeDefIndex: 12029
{
	// Fields
	[SerializeField]
	private Locale m_Locale; // 0x10

	// Properties
	public Locale Locale { get; set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1F03BE0 Offset: 0x1F021E0 VA: 0x181F03BE0
	public void .ctor(Locale fallback) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Locale get_Locale() { }

	// RVA: 0x1F03D60 Offset: 0x1F02360 VA: 0x181F03D60
	public void set_Locale(Locale value) { }

	// RVA: 0x1F03A80 Offset: 0x1F02080 VA: 0x181F03A80
	private bool IsCyclic(Locale locale) { }
}

// Namespace: UnityEngine.Localization.Metadata
public interface IMetadata // TypeDefIndex: 12030
{}

// Namespace: UnityEngine.Localization.Metadata
[HideInInspector]
public interface ISharedMetadata : IMetadata // TypeDefIndex: 12031
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Contains(long keyId);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddEntry(long keyId);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RemoveEntry(long keyId);
}

// Namespace: UnityEngine.Localization.Metadata
public interface IMetadataCollection // TypeDefIndex: 12032
{
	// Properties
	public abstract IList<IMetadata> MetadataEntries { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IList<IMetadata> get_MetadataEntries();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TObject GetMetadata<TObject>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMetadataCollection.GetMetadata<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetMetadatas<TObject>(IList<TObject> foundItems);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMetadataCollection.GetMetadatas<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IList<TObject> GetMetadatas<TObject>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMetadataCollection.GetMetadatas<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddMetadata(IMetadata md);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool RemoveMetadata(IMetadata md);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Contains(IMetadata md);
}

// Namespace: UnityEngine.Localization.Metadata
[Serializable]
public class MetadataCollection : IMetadataCollection // TypeDefIndex: 12033
{
	// Fields
	[SerializeReference]
	private List<IMetadata> m_Items; // 0x10

	// Properties
	public IList<IMetadata> MetadataEntries { get; }
	public bool HasData { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public IList<IMetadata> get_MetadataEntries() { }

	// RVA: 0x1F08F50 Offset: 0x1F07550 VA: 0x181F08F50
	public bool get_HasData() { }

	// RVA: -1 Offset: -1
	public bool HasMetadata<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x735A60 Offset: 0x734060 VA: 0x180735A60
	|-MetadataCollection.HasMetadata<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TObject GetMetadata<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7355A0 Offset: 0x733BA0 VA: 0x1807355A0
	|-MetadataCollection.GetMetadata<object>
	|
	|-RVA: 0x7352A0 Offset: 0x7338A0 VA: 0x1807352A0
	|-MetadataCollection.GetMetadata<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void GetMetadatas<TObject>(IList<TObject> foundItems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x735740 Offset: 0x733D40 VA: 0x180735740
	|-MetadataCollection.GetMetadatas<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IList<TObject> GetMetadatas<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7359E0 Offset: 0x733FE0 VA: 0x1807359E0
	|-MetadataCollection.GetMetadatas<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1F08DB0 Offset: 0x1F073B0 VA: 0x181F08DB0 Slot: 8
	public void AddMetadata(IMetadata md) { }

	// RVA: 0x1F08E70 Offset: 0x1F07470 VA: 0x181F08E70 Slot: 9
	public bool RemoveMetadata(IMetadata md) { }

	// RVA: 0x1F08E10 Offset: 0x1F07410 VA: 0x181F08E10 Slot: 10
	public bool Contains(IMetadata md) { }

	// RVA: 0x1F08ED0 Offset: 0x1F074D0 VA: 0x181F08ED0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Metadata
public enum EntryOverrideType // TypeDefIndex: 12034
{
	// Fields
	public int value__; // 0x0
	public const EntryOverrideType None = 0;
	public const EntryOverrideType Table = 1;
	public const EntryOverrideType Entry = 2;
	public const EntryOverrideType TableAndEntry = 3;
}

// Namespace: UnityEngine.Localization.Metadata
public interface IEntryOverride : IMetadata // TypeDefIndex: 12035
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference);
}

// Namespace: UnityEngine.Localization.Metadata
[Metadata(AllowedTypes = 240, AllowMultiple = False)]
[Serializable]
public class PlatformOverride : IEntryOverride, IMetadata, ISerializationCallbackReceiver // TypeDefIndex: 12037
{
	// Fields
	[SerializeField]
	private List<PlatformOverride.PlatformOverrideData> m_PlatformOverrides; // 0x10
	private PlatformOverride.PlatformOverrideData m_PlayerPlatformOverride; // 0x18

	// Methods

	// RVA: 0x1F09840 Offset: 0x1F07E40 VA: 0x181F09840
	public void AddPlatformTableOverride(RuntimePlatform platform, TableReference table) { }

	// RVA: 0x1F09620 Offset: 0x1F07C20 VA: 0x181F09620
	public void AddPlatformEntryOverride(RuntimePlatform platform, TableEntryReference entry) { }

	// RVA: 0x1F09670 Offset: 0x1F07C70 VA: 0x181F09670
	public void AddPlatformOverride(RuntimePlatform platform, TableReference table, TableEntryReference entry, EntryOverrideType entryOverrideType = 3) { }

	// RVA: 0x1F09B70 Offset: 0x1F08170 VA: 0x181F09B70
	public bool RemovePlatformOverride(RuntimePlatform platform) { }

	// RVA: 0x1F098A0 Offset: 0x1F07EA0 VA: 0x181F098A0 Slot: 4
	public EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference) { }

	// RVA: 0x1F09940 Offset: 0x1F07F40 VA: 0x181F09940
	public EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference, RuntimePlatform platform) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void OnBeforeSerialize() { }

	// RVA: 0x1F09A80 Offset: 0x1F08080 VA: 0x181F09A80 Slot: 6
	public void OnAfterDeserialize() { }

	// RVA: 0x1F09C40 Offset: 0x1F08240 VA: 0x181F09C40
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Metadata
[Metadata(AllowedTypes = 10, MenuItem = "Preload Assets")]
[Serializable]
public class PreloadAssetTableMetadata : IMetadata // TypeDefIndex: 12039
{
	// Fields
	[SerializeField]
	private PreloadAssetTableMetadata.PreloadBehaviour m_PreloadBehaviour; // 0x10

	// Properties
	public PreloadAssetTableMetadata.PreloadBehaviour Behaviour { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public PreloadAssetTableMetadata.PreloadBehaviour get_Behaviour() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_Behaviour(PreloadAssetTableMetadata.PreloadBehaviour value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Metadata
[Serializable]
public abstract class SharedTableCollectionMetadata : IMetadata, ISerializationCallbackReceiver // TypeDefIndex: 12041
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private List<SharedTableCollectionMetadata.Item> m_Entries; // 0x10
	[CompilerGenerated]
	private Dictionary<long, HashSet<string>> <EntriesLookup>k__BackingField; // 0x18

	// Properties
	public Dictionary<long, HashSet<string>> EntriesLookup { get; set; }
	public bool IsEmpty { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Dictionary<long, HashSet<string>> get_EntriesLookup() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_EntriesLookup(Dictionary<long, HashSet<string>> value) { }

	// RVA: 0x1F0B2D0 Offset: 0x1F098D0 VA: 0x181F0B2D0
	public bool get_IsEmpty() { }

	// RVA: 0x1F0ACE0 Offset: 0x1F092E0 VA: 0x181F0ACE0
	public bool Contains(long keyId) { }

	// RVA: 0x1F0AC30 Offset: 0x1F09230 VA: 0x181F0AC30
	public bool Contains(long keyId, string code) { }

	// RVA: 0x1F0AB20 Offset: 0x1F09120 VA: 0x181F0AB20
	public void AddEntry(long keyId, string code) { }

	// RVA: 0x1F0B1F0 Offset: 0x1F097F0 VA: 0x181F0B1F0
	public void RemoveEntry(long keyId, string code) { }

	// RVA: 0x1F0AF20 Offset: 0x1F09520 VA: 0x181F0AF20 Slot: 6
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x1F0AD40 Offset: 0x1F09340 VA: 0x181F0AD40 Slot: 7
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x1F00CF0 Offset: 0x1EFF2F0 VA: 0x181F00CF0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Localization.Metadata
public abstract class SharedTableEntryMetadata : IMetadata, ISerializationCallbackReceiver // TypeDefIndex: 12042
{
	// Fields
	[SerializeField]
	private List<long> m_Entries; // 0x10
	private HashSet<long> m_EntriesLookup; // 0x18

	// Properties
	internal int Count { get; }

	// Methods

	// RVA: 0x1F0B780 Offset: 0x1F09D80 VA: 0x181F0B780
	internal int get_Count() { }

	// RVA: 0x1F0B320 Offset: 0x1F09920 VA: 0x181F0B320
	internal bool IsRegistered(TableEntry entry) { }

	// RVA: 0x1F0B5E0 Offset: 0x1F09BE0 VA: 0x181F0B5E0
	internal void Register(TableEntry entry) { }

	// RVA: 0x1F0B650 Offset: 0x1F09C50 VA: 0x181F0B650
	internal void Unregister(TableEntry entry) { }

	// RVA: 0x1F0B520 Offset: 0x1F09B20 VA: 0x181F0B520 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1F0B390 Offset: 0x1F09990 VA: 0x181F0B390 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1F0B6C0 Offset: 0x1F09CC0 VA: 0x181F0B6C0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Localization.Metadata
[HideInInspector]
[Serializable]
public class SmartFormatTag : SharedTableEntryMetadata // TypeDefIndex: 12043
{
	// Methods

	// RVA: 0x1F0B6C0 Offset: 0x1F09CC0 VA: 0x181F0B6C0
	public void .ctor() { }
}

