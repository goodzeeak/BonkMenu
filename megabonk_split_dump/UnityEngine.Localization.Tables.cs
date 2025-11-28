// Namespace: UnityEngine.Localization.Tables
public class AssetTableEntry : TableEntry // TypeDefIndex: 11799
{
	// Fields
	[CompilerGenerated]
	private AsyncOperationHandle<Object[]> <PreloadAsyncOperation>k__BackingField; // 0x28
	[CompilerGenerated]
	private AsyncOperationHandle <AsyncOperation>k__BackingField; // 0x48
	private string m_GuidCache; // 0x60
	private string m_SubAssetNameCache; // 0x68

	// Properties
	internal AsyncOperationHandle<Object[]> PreloadAsyncOperation { get; set; }
	internal AsyncOperationHandle AsyncOperation { get; set; }
	public string Address { get; set; }
	public string Guid { get; set; }
	public string SubAssetName { get; }
	public bool IsEmpty { get; }
	public bool IsSubAsset { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x11165A0 Offset: 0x1114BA0 VA: 0x1811165A0
	internal AsyncOperationHandle<Object[]> get_PreloadAsyncOperation() { }

	[CompilerGenerated]
	// RVA: 0x1EC5FF0 Offset: 0x1EC45F0 VA: 0x181EC5FF0
	internal void set_PreloadAsyncOperation(AsyncOperationHandle<Object[]> value) { }

	[CompilerGenerated]
	// RVA: 0x1797030 Offset: 0x1795630 VA: 0x181797030
	internal AsyncOperationHandle get_AsyncOperation() { }

	[CompilerGenerated]
	// RVA: 0x1EC5FD0 Offset: 0x1EC45D0 VA: 0x181EC5FD0
	internal void set_AsyncOperation(AsyncOperationHandle value) { }

	// RVA: 0x1CE9240 Offset: 0x1CE7840 VA: 0x181CE9240
	public string get_Address() { }

	// RVA: 0x1EC5F80 Offset: 0x1EC4580 VA: 0x181EC5F80
	public void set_Address(string value) { }

	// RVA: 0x1EC5D50 Offset: 0x1EC4350 VA: 0x181EC5D50
	public string get_Guid() { }

	// RVA: 0x1EC5F80 Offset: 0x1EC4580 VA: 0x181EC5F80
	public void set_Guid(string value) { }

	// RVA: 0x1EC5EB0 Offset: 0x1EC44B0 VA: 0x181EC5EB0
	public string get_SubAssetName() { }

	// RVA: 0x1EC5E20 Offset: 0x1EC4420 VA: 0x181EC5E20
	public bool get_IsEmpty() { }

	// RVA: 0x1EC5E50 Offset: 0x1EC4450 VA: 0x181EC5E50
	public bool get_IsSubAsset() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1EC5BC0 Offset: 0x1EC41C0 VA: 0x181EC5BC0
	public void RemoveFromTable() { }

	// RVA: 0x1EC5990 Offset: 0x1EC3F90 VA: 0x181EC5990
	internal Type GetExpectedType() { }

	// RVA: -1 Offset: -1
	public void SetAssetOverride<T>(T asset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65EC80 Offset: 0x65D280 VA: 0x18065EC80
	|-AssetTableEntry.SetAssetOverride<object>
	*/
}

// Namespace: UnityEngine.Localization.Tables
public class AssetTable : DetailedLocalizationTable<AssetTableEntry>, IPreloadRequired // TypeDefIndex: 11800
{
	// Fields
	private AsyncOperationHandle m_PreloadOperationHandle; // 0x48

	// Properties
	private ResourceManager ResourceManager { get; }
	public virtual AsyncOperationHandle PreloadOperation { get; }

	// Methods

	// RVA: 0x1EC5700 Offset: 0x1EC3D00 VA: 0x181EC5700
	private ResourceManager get_ResourceManager() { }

	// RVA: 0x1EC6B10 Offset: 0x1EC5110 VA: 0x181EC6B10 Slot: 37
	public virtual AsyncOperationHandle get_PreloadOperation() { }

	// RVA: 0x1EC6110 Offset: 0x1EC4710 VA: 0x181EC6110
	private AsyncOperationHandle PreloadAssets() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> GetAssetAsync<TObject>(TableEntryReference entryReference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65F0F0 Offset: 0x65D6F0 VA: 0x18065F0F0
	|-AssetTable.GetAssetAsync<object>
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<TObject> GetAssetAsync<TObject>(AssetTableEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65ED60 Offset: 0x65D360 VA: 0x18065ED60
	|-AssetTable.GetAssetAsync<object>
	*/

	// RVA: 0x1EC6880 Offset: 0x1EC4E80 VA: 0x181EC6880
	public void ReleaseAssets() { }

	// RVA: 0x1EC6670 Offset: 0x1EC4C70 VA: 0x181EC6670
	public void ReleaseAsset(AssetTableEntry entry) { }

	// RVA: 0x1EC6810 Offset: 0x1EC4E10 VA: 0x181EC6810
	public void ReleaseAsset(TableEntryReference entry) { }

	// RVA: 0x1EC6010 Offset: 0x1EC4610 VA: 0x181EC6010 Slot: 32
	public override AssetTableEntry CreateTableEntry() { }

	// RVA: 0x1EC6AD0 Offset: 0x1EC50D0 VA: 0x181EC6AD0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Tables
public class TableEntry : IMetadataCollection // TypeDefIndex: 11801
{
	// Fields
	private SharedTableData.SharedTableEntry m_SharedTableEntry; // 0x10
	[CompilerGenerated]
	private LocalizationTable <Table>k__BackingField; // 0x18
	[CompilerGenerated]
	private TableEntryData <Data>k__BackingField; // 0x20

	// Properties
	public LocalizationTable Table { get; set; }
	internal TableEntryData Data { get; set; }
	public SharedTableData.SharedTableEntry SharedEntry { get; }
	public string Key { get; set; }
	public long KeyId { get; }
	public string LocalizedValue { get; }
	public IList<IMetadata> MetadataEntries { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public LocalizationTable get_Table() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_Table(LocalizationTable value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal TableEntryData get_Data() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_Data(TableEntryData value) { }

	// RVA: 0x1EDCB80 Offset: 0x1EDB180 VA: 0x181EDCB80
	public SharedTableData.SharedTableEntry get_SharedEntry() { }

	// RVA: 0x1EDCAE0 Offset: 0x1EDB0E0 VA: 0x181EDCAE0
	public string get_Key() { }

	// RVA: 0x1EDCBE0 Offset: 0x1EDB1E0 VA: 0x181EDCBE0
	public void set_Key(string value) { }

	// RVA: 0x1CE92E0 Offset: 0x1CE78E0 VA: 0x181CE92E0
	public long get_KeyId() { }

	// RVA: 0x1CE9240 Offset: 0x1CE7840 VA: 0x181CE9240
	public string get_LocalizedValue() { }

	// RVA: 0x1EDCB50 Offset: 0x1EDB150 VA: 0x181EDCB50 Slot: 4
	public IList<IMetadata> get_MetadataEntries() { }

	// RVA: -1 Offset: -1 Slot: 5
	public TObject GetMetadata<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0D30 Offset: 0x7BF330 VA: 0x1807C0D30
	|-TableEntry.GetMetadata<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void GetMetadatas<TObject>(IList<TObject> foundItems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0E00 Offset: 0x7BF400 VA: 0x1807C0E00
	|-TableEntry.GetMetadatas<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IList<TObject> GetMetadatas<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0E60 Offset: 0x7BF460 VA: 0x1807C0E60
	|-TableEntry.GetMetadatas<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool HasTagMetadata<TShared>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0EB0 Offset: 0x7BF4B0 VA: 0x1807C0EB0
	|-TableEntry.HasTagMetadata<object>
	*/

	// RVA: -1 Offset: -1
	public void AddTagMetadata<TShared>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0B10 Offset: 0x7BF110 VA: 0x1807C0B10
	|-TableEntry.AddTagMetadata<object>
	*/

	// RVA: 0x1EDC770 Offset: 0x1EDAD70 VA: 0x181EDC770
	public void AddSharedMetadata(SharedTableEntryMetadata md) { }

	// RVA: 0x1EDC810 Offset: 0x1EDAE10 VA: 0x181EDC810
	public void AddSharedMetadata(SharedTableCollectionMetadata md) { }

	// RVA: 0x1EDC740 Offset: 0x1EDAD40 VA: 0x181EDC740 Slot: 8
	public void AddMetadata(IMetadata md) { }

	// RVA: -1 Offset: -1
	public void RemoveTagMetadata<TShared>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C0F20 Offset: 0x7BF520 VA: 0x1807C0F20
	|-TableEntry.RemoveTagMetadata<object>
	*/

	// RVA: 0x1EDC920 Offset: 0x1EDAF20 VA: 0x181EDC920
	public void RemoveSharedMetadata(SharedTableEntryMetadata md) { }

	// RVA: 0x1EDC9D0 Offset: 0x1EDAFD0 VA: 0x181EDC9D0
	public void RemoveSharedMetadata(SharedTableCollectionMetadata md) { }

	// RVA: 0x1EDC8F0 Offset: 0x1EDAEF0 VA: 0x181EDC8F0 Slot: 9
	public bool RemoveMetadata(IMetadata md) { }

	// RVA: 0x1EDC8C0 Offset: 0x1EDAEC0 VA: 0x181EDC8C0 Slot: 10
	public bool Contains(IMetadata md) { }

	// RVA: 0x1EDCA60 Offset: 0x1EDB060 VA: 0x181EDCA60 Slot: 3
	public override string ToString() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Tables
public enum MissingEntryAction // TypeDefIndex: 11802
{
	// Fields
	public int value__; // 0x0
	public const MissingEntryAction Nothing = 0;
	public const MissingEntryAction AddEntriesToSharedData = 1;
	public const MissingEntryAction RemoveEntriesFromTable = 2;
}

// Namespace: UnityEngine.Localization.Tables
[DefaultMember("Item")]
public abstract class DetailedLocalizationTable<TEntry> : LocalizationTable, IDictionary<long, TEntry>, ICollection<KeyValuePair<long, TEntry>>, IEnumerable<KeyValuePair<long, TEntry>>, IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 11804
{
	// Fields
	private Dictionary<long, TEntry> m_TableEntries; // 0x0

	// Properties
	private ICollection<long> System.Collections.Generic.IDictionary<System.Int64,TEntry>.Keys { get; }
	public ICollection<TEntry> Values { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	public TEntry Item { get; set; }
	public TEntry Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 15
	private ICollection<long> System.Collections.Generic.IDictionary<System.Int64,TEntry>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3B960 Offset: 0xD39F60 VA: 0x180D3B960
	|-DetailedLocalizationTable<object>.System.Collections.Generic.IDictionary<System.Int64,TEntry>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public ICollection<TEntry> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3BB70 Offset: 0xD3A170 VA: 0x180D3BB70
	|-DetailedLocalizationTable<object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3BB10 Offset: 0xD3A110 VA: 0x180D3BB10
	|-DetailedLocalizationTable<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-DetailedLocalizationTable<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public TEntry get_Item(long key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3BB40 Offset: 0xD3A140 VA: 0x180D3BB40
	|-DetailedLocalizationTable<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void set_Item(long key, TEntry value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3BBA0 Offset: 0xD3A1A0 VA: 0x180D3BBA0
	|-DetailedLocalizationTable<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public TEntry get_Item(string keyName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3AAB0 Offset: 0xD390B0 VA: 0x180D3AAB0
	|-DetailedLocalizationTable<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(string keyName, TEntry value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3BD20 Offset: 0xD3A320 VA: 0x180D3BD20
	|-DetailedLocalizationTable<object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public abstract TEntry CreateTableEntry();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-DetailedLocalizationTable<object>.CreateTableEntry
	*/

	// RVA: -1 Offset: -1
	internal TEntry CreateTableEntry(TableEntryData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A9F0 Offset: 0xD38FF0 VA: 0x180D3A9F0
	|-DetailedLocalizationTable<object>.CreateTableEntry
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void CreateEmpty(TableEntryReference entryReference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A8C0 Offset: 0xD38EC0 VA: 0x180D3A8C0
	|-DetailedLocalizationTable<object>.CreateEmpty
	*/

	// RVA: -1 Offset: -1
	public TEntry AddEntry(string key, string localized) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A0B0 Offset: 0xD386B0 VA: 0x180D3A0B0
	|-DetailedLocalizationTable<object>.AddEntry
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public virtual TEntry AddEntry(long keyId, string localized) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD39ED0 Offset: 0xD384D0 VA: 0x180D39ED0
	|-DetailedLocalizationTable<object>.AddEntry
	*/

	// RVA: -1 Offset: -1
	public TEntry AddEntryFromReference(TableEntryReference entryReference, string localized) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD39DF0 Offset: 0xD383F0 VA: 0x180D39DF0
	|-DetailedLocalizationTable<object>.AddEntryFromReference
	*/

	// RVA: -1 Offset: -1
	public bool RemoveEntry(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3B360 Offset: 0xD39960 VA: 0x180D3B360
	|-DetailedLocalizationTable<object>.RemoveEntry
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public virtual bool RemoveEntry(long keyId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3B3B0 Offset: 0xD399B0 VA: 0x180D3B3B0
	|-DetailedLocalizationTable<object>.RemoveEntry
	*/

	// RVA: -1 Offset: -1
	public TEntry GetEntryFromReference(TableEntryReference entryReference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3AA40 Offset: 0xD39040 VA: 0x180D3AA40
	|-DetailedLocalizationTable<object>.GetEntryFromReference
	*/

	// RVA: -1 Offset: -1
	public TEntry GetEntry(string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3AAB0 Offset: 0xD390B0 VA: 0x180D3AAB0
	|-DetailedLocalizationTable<object>.GetEntry
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public virtual TEntry GetEntry(long keyId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3AB00 Offset: 0xD39100 VA: 0x180D3AB00
	|-DetailedLocalizationTable<object>.GetEntry
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void Add(long keyId, TEntry value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A130 Offset: 0xD38730 VA: 0x180D3A130
	|-DetailedLocalizationTable<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public void Add(KeyValuePair<long, TEntry> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A110 Offset: 0xD38710 VA: 0x180D3A110
	|-DetailedLocalizationTable<object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool ContainsKey(long keyId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A530 Offset: 0xD38B30 VA: 0x180D3A530
	|-DetailedLocalizationTable<object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(string localized) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A560 Offset: 0xD38B60 VA: 0x180D3A560
	|-DetailedLocalizationTable<object>.ContainsValue
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public bool Contains(KeyValuePair<long, TEntry> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A700 Offset: 0xD38D00 VA: 0x180D3A700
	|-DetailedLocalizationTable<object>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool Remove(long keyId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3B8C0 Offset: 0xD39EC0 VA: 0x180D3B8C0
	|-DetailedLocalizationTable<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public bool Remove(KeyValuePair<long, TEntry> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3B8E0 Offset: 0xD39EE0 VA: 0x180D3B8E0
	|-DetailedLocalizationTable<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public IList<TEntry> CheckForMissingSharedTableDataEntries(MissingEntryAction action = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A150 Offset: 0xD38750 VA: 0x180D3A150
	|-DetailedLocalizationTable<object>.CheckForMissingSharedTableDataEntries
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public bool TryGetValue(long keyId, out TEntry value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3BA20 Offset: 0xD3A020 VA: 0x180D3BA20
	|-DetailedLocalizationTable<object>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A4A0 Offset: 0xD38AA0 VA: 0x180D3A4A0
	|-DetailedLocalizationTable<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public void CopyTo(KeyValuePair<long, TEntry>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3A740 Offset: 0xD38D40 VA: 0x180D3A740
	|-DetailedLocalizationTable<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public IEnumerator<KeyValuePair<long, TEntry>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3AB50 Offset: 0xD39150 VA: 0x180D3AB50
	|-DetailedLocalizationTable<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3AB50 Offset: 0xD39150 VA: 0x180D3AB50
	|-DetailedLocalizationTable<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3B990 Offset: 0xD39F90 VA: 0x180D3B990
	|-DetailedLocalizationTable<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3B020 Offset: 0xD39620 VA: 0x180D3B020
	|-DetailedLocalizationTable<object>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3ABD0 Offset: 0xD391D0 VA: 0x180D3ABD0
	|-DetailedLocalizationTable<object>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3BA80 Offset: 0xD3A080 VA: 0x180D3BA80
	|-DetailedLocalizationTable<object>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private bool <CheckForMissingSharedTableDataEntries>b__33_0(KeyValuePair<long, TEntry> e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3BA50 Offset: 0xD3A050 VA: 0x180D3BA50
	|-DetailedLocalizationTable<object>.<CheckForMissingSharedTableDataEntries>b__33_0
	*/
}

// Namespace: UnityEngine.Localization.Tables
[Serializable]
public class DistributedUIDGenerator : IKeyGenerator // TypeDefIndex: 11805
{
	// Fields
	private const int kMachineIdBits = 10;
	private const int kSequenceBits = 12;
	private static readonly int kMaxNodeId; // 0x0
	private static readonly int kMaxSequence; // 0x4
	public const string MachineIdPrefKey = "KeyGenerator-MachineId";
	[SerializeField]
	[HideInInspector]
	private long m_CustomEpoch; // 0x10
	private long m_LastTimestamp; // 0x18
	private long m_Sequence; // 0x20
	private int m_MachineId; // 0x28

	// Properties
	public long CustomEpoch { get; }
	public int MachineId { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public long get_CustomEpoch() { }

	// RVA: 0x1EC7190 Offset: 0x1EC5790 VA: 0x181EC7190
	public int get_MachineId() { }

	// RVA: 0x1EC7230 Offset: 0x1EC5830 VA: 0x181EC7230
	public void set_MachineId(int value) { }

	// RVA: 0x1EC7110 Offset: 0x1EC5710 VA: 0x181EC7110
	public void .ctor() { }

	// RVA: 0x1EC7080 Offset: 0x1EC5680 VA: 0x181EC7080
	public void .ctor(long customEpoch) { }

	// RVA: 0x1EC6CE0 Offset: 0x1EC52E0 VA: 0x181EC6CE0 Slot: 4
	public long GetNextKey() { }

	// RVA: 0x1EC6EF0 Offset: 0x1EC54F0 VA: 0x181EC6EF0
	private long TimeStamp() { }

	// RVA: 0x1EC6C80 Offset: 0x1EC5280 VA: 0x181EC6C80
	private static int GetMachineId() { }

	// RVA: 0x1EC6F60 Offset: 0x1EC5560 VA: 0x181EC6F60
	private long WaitNextMillis(long currentTimestamp) { }

	// RVA: 0x1EC6FF0 Offset: 0x1EC55F0 VA: 0x181EC6FF0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.Tables
public interface IKeyGenerator // TypeDefIndex: 11806
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract long GetNextKey();
}

// Namespace: UnityEngine.Localization.Tables
public class SequentialIDGenerator : IKeyGenerator // TypeDefIndex: 11807
{
	// Fields
	[SerializeField]
	private long m_NextAvailableId; // 0x10

	// Properties
	public long NextAvailableId { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public long get_NextAvailableId() { }

	// RVA: 0x1ED4420 Offset: 0x1ED2A20 VA: 0x181ED4420
	public void .ctor() { }

	// RVA: 0x1ED43F0 Offset: 0x1ED29F0 VA: 0x181ED43F0
	public void .ctor(long startingId) { }

	// RVA: 0x1ED43E0 Offset: 0x1ED29E0 VA: 0x181ED43E0 Slot: 4
	public long GetNextKey() { }
}

// Namespace: UnityEngine.Localization.Tables
public abstract class LocalizationTable : ScriptableObject, IMetadataCollection, IComparable<LocalizationTable> // TypeDefIndex: 11808
{
	// Fields
	[SerializeField]
	private LocaleIdentifier m_LocaleId; // 0x18
	[FormerlySerializedAs("m_KeyDatabase")]
	[SerializeField]
	[HideInInspector]
	private SharedTableData m_SharedData; // 0x28
	[SerializeField]
	private MetadataCollection m_Metadata; // 0x30
	[SerializeField]
	private List<TableEntryData> m_TableData; // 0x38

	// Properties
	public LocaleIdentifier LocaleIdentifier { get; set; }
	public string TableCollectionName { get; }
	public SharedTableData SharedData { get; set; }
	internal List<TableEntryData> TableData { get; }
	public IList<IMetadata> MetadataEntries { get; }

	// Methods

	// RVA: 0x8641A0 Offset: 0x8627A0 VA: 0x1808641A0
	public LocaleIdentifier get_LocaleIdentifier() { }

	// RVA: 0x1ECA5B0 Offset: 0x1EC8BB0 VA: 0x181ECA5B0
	public void set_LocaleIdentifier(LocaleIdentifier value) { }

	// RVA: 0x1ECB090 Offset: 0x1EC9690 VA: 0x181ECB090
	public string get_TableCollectionName() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public SharedTableData get_SharedData() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_SharedData(SharedTableData value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal List<TableEntryData> get_TableData() { }

	// RVA: 0x1CF2C70 Offset: 0x1CF1270 VA: 0x181CF2C70 Slot: 4
	public IList<IMetadata> get_MetadataEntries() { }

	// RVA: -1 Offset: -1 Slot: 5
	public TObject GetMetadata<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72CC60 Offset: 0x72B260 VA: 0x18072CC60
	|-LocalizationTable.GetMetadata<object>
	|
	|-RVA: 0x72CBA0 Offset: 0x72B1A0 VA: 0x18072CBA0
	|-LocalizationTable.GetMetadata<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void GetMetadatas<TObject>(IList<TObject> foundItems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72CCB0 Offset: 0x72B2B0 VA: 0x18072CCB0
	|-LocalizationTable.GetMetadatas<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IList<TObject> GetMetadatas<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72CD10 Offset: 0x72B310 VA: 0x18072CD10
	|-LocalizationTable.GetMetadatas<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1ECAC50 Offset: 0x1EC9250 VA: 0x181ECAC50 Slot: 8
	public void AddMetadata(IMetadata md) { }

	// RVA: 0x1ECAE50 Offset: 0x1EC9450 VA: 0x181ECAE50 Slot: 9
	public bool RemoveMetadata(IMetadata md) { }

	// RVA: 0x1ECADA0 Offset: 0x1EC93A0 VA: 0x181ECADA0 Slot: 10
	public bool Contains(IMetadata md) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void CreateEmpty(TableEntryReference entryReference);

	// RVA: 0x1ECADC0 Offset: 0x1EC93C0 VA: 0x181ECADC0
	protected long FindKeyId(string key, bool addKey) { }

	// RVA: 0x1ECAF00 Offset: 0x1EC9500 VA: 0x181ECAF00
	private void VerifySharedTableDataIsNotNull() { }

	// RVA: 0x1ECAE70 Offset: 0x1EC9470 VA: 0x181ECAE70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ECAC70 Offset: 0x1EC9270 VA: 0x181ECAC70 Slot: 11
	public int CompareTo(LocalizationTable other) { }

	// RVA: 0x1ECAFE0 Offset: 0x1EC95E0 VA: 0x181ECAFE0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Localization.Tables
public class SharedTableData : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 11810
{
	// Fields
	public const long EmptyId = 0;
	internal const string NewEntryKey = "New Entry";
	[FormerlySerializedAs("m_TableName")]
	[SerializeField]
	private string m_TableCollectionName; // 0x18
	[FormerlySerializedAs("m_TableNameGuidString")]
	[SerializeField]
	private string m_TableCollectionNameGuidString; // 0x20
	[SerializeField]
	private List<SharedTableData.SharedTableEntry> m_Entries; // 0x28
	[SerializeField]
	[MetadataType(2)]
	private MetadataCollection m_Metadata; // 0x30
	[SerializeReference]
	private IKeyGenerator m_KeyGenerator; // 0x38
	private Guid m_TableCollectionNameGuid; // 0x40
	private Dictionary<long, SharedTableData.SharedTableEntry> m_IdDictionary; // 0x50
	private Dictionary<string, SharedTableData.SharedTableEntry> m_KeyDictionary; // 0x58

	// Properties
	public List<SharedTableData.SharedTableEntry> Entries { get; set; }
	public string TableCollectionName { get; set; }
	public Guid TableCollectionNameGuid { get; set; }
	public MetadataCollection Metadata { get; set; }
	public IKeyGenerator KeyGenerator { get; set; }

	// Methods

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public List<SharedTableData.SharedTableEntry> get_Entries() { }

	// RVA: 0x1ED5AD0 Offset: 0x1ED40D0 VA: 0x181ED5AD0
	public void set_Entries(List<SharedTableData.SharedTableEntry> value) { }

	// RVA: 0x1ED4A30 Offset: 0x1ED3030 VA: 0x181ED4A30
	public void Clear() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_TableCollectionName() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_TableCollectionName(string value) { }

	// RVA: 0xAC52A0 Offset: 0xAC38A0 VA: 0x180AC52A0
	public Guid get_TableCollectionNameGuid() { }

	// RVA: 0xAC52D0 Offset: 0xAC38D0 VA: 0x180AC52D0
	internal void set_TableCollectionNameGuid(Guid value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public MetadataCollection get_Metadata() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_Metadata(MetadataCollection value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public IKeyGenerator get_KeyGenerator() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_KeyGenerator(IKeyGenerator value) { }

	// RVA: 0x1ED53E0 Offset: 0x1ED39E0 VA: 0x181ED53E0
	public string GetKey(long id) { }

	// RVA: 0x1ED53C0 Offset: 0x1ED39C0 VA: 0x181ED53C0
	public long GetId(string key) { }

	// RVA: 0x1ED5340 Offset: 0x1ED3940 VA: 0x181ED5340
	public long GetId(string key, bool addNewKey) { }

	// RVA: 0x1ED5300 Offset: 0x1ED3900 VA: 0x181ED5300
	public SharedTableData.SharedTableEntry GetEntryFromReference(TableEntryReference tableEntryReference) { }

	// RVA: 0x1ED5330 Offset: 0x1ED3930 VA: 0x181ED5330
	public SharedTableData.SharedTableEntry GetEntry(long id) { }

	// RVA: 0x1ED5320 Offset: 0x1ED3920 VA: 0x181ED5320
	public SharedTableData.SharedTableEntry GetEntry(string key) { }

	// RVA: 0x1ED4D80 Offset: 0x1ED3380 VA: 0x181ED4D80
	public bool Contains(long id) { }

	// RVA: 0x1ED4DA0 Offset: 0x1ED33A0 VA: 0x181ED4DA0
	public bool Contains(string key) { }

	// RVA: 0x1ED48F0 Offset: 0x1ED2EF0 VA: 0x181ED48F0
	public SharedTableData.SharedTableEntry AddKey(string key, long id) { }

	// RVA: 0x1ED4950 Offset: 0x1ED2F50 VA: 0x181ED4950
	public SharedTableData.SharedTableEntry AddKey(string key) { }

	// RVA: 0x1ED5730 Offset: 0x1ED3D30 VA: 0x181ED5730
	public void RemoveKey(long id) { }

	// RVA: 0x1ED5700 Offset: 0x1ED3D00 VA: 0x181ED5700
	public void RemoveKey(string key) { }

	// RVA: 0x1ED5830 Offset: 0x1ED3E30 VA: 0x181ED5830
	public void RenameKey(long id, string newValue) { }

	// RVA: 0x1ED5870 Offset: 0x1ED3E70 VA: 0x181ED5870
	public void RenameKey(string oldValue, string newValue) { }

	// RVA: 0x1ED5530 Offset: 0x1ED3B30 VA: 0x181ED5530
	public bool RemapId(long currentId, long newId) { }

	[Obsolete("FindSimilarKey will be removed in the future, please use Unity Search. See TableEntrySearchData class for further details.")]
	// RVA: 0x1ED4DC0 Offset: 0x1ED33C0 VA: 0x181ED4DC0
	public SharedTableData.SharedTableEntry FindSimilarKey(string text, out int distance) { }

	// RVA: 0x1ED4AD0 Offset: 0x1ED30D0 VA: 0x181ED4AD0
	private static int ComputeLevenshteinDistance(string a, string b) { }

	// RVA: 0x1ED4430 Offset: 0x1ED2A30 VA: 0x181ED4430
	private SharedTableData.SharedTableEntry AddKeyInternal(string key) { }

	// RVA: 0x1ED4700 Offset: 0x1ED2D00 VA: 0x181ED4700
	private SharedTableData.SharedTableEntry AddKeyInternal(string key, long id) { }

	// RVA: 0x1ED5760 Offset: 0x1ED3D60 VA: 0x181ED5760
	private void RenameKeyInternal(SharedTableData.SharedTableEntry entry, string newValue) { }

	// RVA: 0x1ED5600 Offset: 0x1ED3C00 VA: 0x181ED5600
	private void RemoveKeyInternal(SharedTableData.SharedTableEntry entry) { }

	// RVA: 0x1ED4F60 Offset: 0x1ED3560 VA: 0x181ED4F60
	private SharedTableData.SharedTableEntry FindWithId(long id) { }

	// RVA: 0x1ED5130 Offset: 0x1ED3730 VA: 0x181ED5130
	private SharedTableData.SharedTableEntry FindWithKey(string key) { }

	// RVA: 0x1ED58B0 Offset: 0x1ED3EB0 VA: 0x181ED58B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ED54C0 Offset: 0x1ED3AC0 VA: 0x181ED54C0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1ED5400 Offset: 0x1ED3A00 VA: 0x181ED5400 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1ED58F0 Offset: 0x1ED3EF0 VA: 0x181ED58F0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Tables
public class StringTableEntry : TableEntry // TypeDefIndex: 11811
{
	// Fields
	private FormatCache m_FormatCache; // 0x28

	// Properties
	public FormatCache FormatCache { get; set; }
	public string Value { get; set; }
	public bool IsSmart { get; set; }

	// Methods

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public FormatCache get_FormatCache() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_FormatCache(FormatCache value) { }

	// RVA: 0x1CE9240 Offset: 0x1CE7840 VA: 0x181CE9240
	public string get_Value() { }

	// RVA: 0x1EDACC0 Offset: 0x1ED92C0 VA: 0x181EDACC0
	public void set_Value(string value) { }

	// RVA: 0x1EDAB80 Offset: 0x1ED9180 VA: 0x181EDAB80
	public bool get_IsSmart() { }

	// RVA: 0x1EDAC00 Offset: 0x1ED9200 VA: 0x181EDAC00
	public void set_IsSmart(bool value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1EDA9F0 Offset: 0x1ED8FF0 VA: 0x181EDA9F0
	public void RemoveFromTable() { }

	// RVA: 0x1EDA8C0 Offset: 0x1ED8EC0 VA: 0x181EDA8C0
	internal FormatCache GetOrCreateFormatCache() { }

	// RVA: 0x1EDA710 Offset: 0x1ED8D10 VA: 0x181EDA710
	public string GetLocalizedString() { }

	// RVA: 0x1EDA630 Offset: 0x1ED8C30 VA: 0x181EDA630
	public string GetLocalizedString(object[] args) { }

	// RVA: 0x1EDA7E0 Offset: 0x1ED8DE0 VA: 0x181EDA7E0
	public string GetLocalizedString(IList<object> args) { }

	// RVA: 0x1EDA170 Offset: 0x1ED8770 VA: 0x181EDA170
	public string GetLocalizedString(IFormatProvider formatProvider, IList<object> args) { }

	// RVA: 0x1EDA260 Offset: 0x1ED8860 VA: 0x181EDA260
	public string GetLocalizedString(IFormatProvider formatProvider, IList<object> args, PseudoLocale pseudoLocale) { }
}

// Namespace: UnityEngine.Localization.Tables
public class StringTable : DetailedLocalizationTable<StringTableEntry> // TypeDefIndex: 11813
{
	// Methods

	// RVA: 0x1EDB240 Offset: 0x1ED9840 VA: 0x181EDB240
	public string GenerateCharacterSet() { }

	// RVA: 0x1EDAD60 Offset: 0x1ED9360 VA: 0x181EDAD60
	internal IEnumerable<char> CollectLiteralCharacters() { }

	// RVA: 0x1EDB140 Offset: 0x1ED9740 VA: 0x181EDB140 Slot: 32
	public override StringTableEntry CreateTableEntry() { }

	// RVA: 0x1EDB3A0 Offset: 0x1ED99A0 VA: 0x181EDB3A0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Tables
[Serializable]
internal class TableEntryData // TypeDefIndex: 11814
{
	// Fields
	[SerializeField]
	private long m_Id; // 0x10
	[SerializeField]
	private string m_Localized; // 0x18
	[SerializeField]
	private MetadataCollection m_Metadata; // 0x20

	// Properties
	public long Id { get; set; }
	public string Localized { get; set; }
	public MetadataCollection Metadata { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public long get_Id() { }

	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	public void set_Id(long value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Localized() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Localized(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public MetadataCollection get_Metadata() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Metadata(MetadataCollection value) { }

	// RVA: 0x1EDBE80 Offset: 0x1EDA480 VA: 0x181EDBE80
	public void .ctor() { }

	// RVA: 0x1EDBF90 Offset: 0x1EDA590 VA: 0x181EDBF90
	public void .ctor(long id) { }

	// RVA: 0x1EDBEF0 Offset: 0x1EDA4F0 VA: 0x181EDBEF0
	public void .ctor(long id, string localized) { }
}

// Namespace: UnityEngine.Localization.Tables
[Serializable]
public struct TableReference : ISerializationCallbackReceiver, IEquatable<TableReference> // TypeDefIndex: 11816
{
	// Fields
	private static readonly Dictionary<Guid, string> s_GuidToStringCache; // 0x0
	private static readonly Dictionary<string, Guid> s_StringToGuidCache; // 0x8
	[SerializeField]
	[FormerlySerializedAs("m_TableName")]
	private string m_TableCollectionName; // 0x0
	private bool m_Valid; // 0x8
	private const string k_GuidTag = "GUID:";
	[CompilerGenerated]
	private TableReference.Type <ReferenceType>k__BackingField; // 0xC
	[CompilerGenerated]
	private Guid <TableCollectionNameGuid>k__BackingField; // 0x10

	// Properties
	public TableReference.Type ReferenceType { get; set; }
	public Guid TableCollectionNameGuid { get; set; }
	public string TableCollectionName { get; set; }
	internal SharedTableData SharedTableData { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public TableReference.Type get_ReferenceType() { }

	[CompilerGenerated]
	// RVA: 0x14A5B10 Offset: 0x14A4110 VA: 0x1814A5B10
	private void set_ReferenceType(TableReference.Type value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0xA67320 Offset: 0xA65920 VA: 0x180A67320
	public Guid get_TableCollectionNameGuid() { }

	[CompilerGenerated]
	// RVA: 0x1032A10 Offset: 0x1031010 VA: 0x181032A10
	private void set_TableCollectionNameGuid(Guid value) { }

	// RVA: 0x1EDE0A0 Offset: 0x1EDC6A0 VA: 0x181EDE0A0
	public string get_TableCollectionName() { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	private void set_TableCollectionName(string value) { }

	// RVA: 0x1EDDB40 Offset: 0x1EDC140 VA: 0x181EDDB40
	internal SharedTableData get_SharedTableData() { }

	// RVA: 0x1EDE290 Offset: 0x1EDC890 VA: 0x181EDE290
	public static TableReference op_Implicit(string tableCollectionName) { }

	// RVA: 0x1EDE170 Offset: 0x1EDC770 VA: 0x181EDE170
	public static TableReference op_Implicit(Guid tableCollectionNameGuid) { }

	// RVA: 0x1EDE120 Offset: 0x1EDC720 VA: 0x181EDE120
	public static string op_Implicit(TableReference tableReference) { }

	// RVA: 0x1EDE230 Offset: 0x1EDC830 VA: 0x181EDE230
	public static Guid op_Implicit(TableReference tableReference) { }

	// RVA: 0x1EDD880 Offset: 0x1EDBE80 VA: 0x181EDD880
	internal void Validate() { }

	// RVA: 0x1EDCF40 Offset: 0x1EDB540 VA: 0x181EDCF40
	internal string GetSerializedString() { }

	// RVA: 0x1EDD720 Offset: 0x1EDBD20 VA: 0x181EDD720 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EDCC40 Offset: 0x1EDB240 VA: 0x181EDCC40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EDCE30 Offset: 0x1EDB430 VA: 0x181EDCE30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EDCD10 Offset: 0x1EDB310 VA: 0x181EDCD10 Slot: 6
	public bool Equals(TableReference other) { }

	// RVA: 0x1EDD010 Offset: 0x1EDB610 VA: 0x181EDD010
	internal static Guid GuidFromString(string value) { }

	// RVA: 0x1EDD390 Offset: 0x1EDB990 VA: 0x181EDD390
	internal static string StringFromGuid(Guid value) { }

	// RVA: 0x1EDD4E0 Offset: 0x1EDBAE0 VA: 0x181EDD4E0
	internal static TableReference TableReferenceFromString(string value) { }

	// RVA: 0x1EDD180 Offset: 0x1EDB780 VA: 0x181EDD180
	internal static bool IsGuid(string value) { }

	// RVA: 0x1EDD330 Offset: 0x1EDB930 VA: 0x181EDD330 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1EDD1F0 Offset: 0x1EDB7F0 VA: 0x181EDD1F0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1EDDA50 Offset: 0x1EDC050 VA: 0x181EDDA50
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.Tables
[Serializable]
public struct TableEntryReference : ISerializationCallbackReceiver, IEquatable<TableEntryReference> // TypeDefIndex: 11818
{
	// Fields
	[SerializeField]
	private long m_KeyId; // 0x0
	[SerializeField]
	private string m_Key; // 0x8
	private bool m_Valid; // 0x10
	[CompilerGenerated]
	private TableEntryReference.Type <ReferenceType>k__BackingField; // 0x14

	// Properties
	public TableEntryReference.Type ReferenceType { get; set; }
	public long KeyId { get; set; }
	public string Key { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public TableEntryReference.Type get_ReferenceType() { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	private void set_ReferenceType(TableEntryReference.Type value) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public long get_KeyId() { }

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	private void set_KeyId(long value) { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public string get_Key() { }

	// RVA: 0x971490 Offset: 0x96FA90 VA: 0x180971490
	private void set_Key(string value) { }

	// RVA: 0x1EDC690 Offset: 0x1EDAC90 VA: 0x181EDC690
	public static TableEntryReference op_Implicit(string key) { }

	// RVA: 0x1EDC710 Offset: 0x1EDAD10 VA: 0x181EDC710
	public static TableEntryReference op_Implicit(long keyId) { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public static string op_Implicit(TableEntryReference tableEntryReference) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public static long op_Implicit(TableEntryReference tableEntryReference) { }

	// RVA: 0x1EDC570 Offset: 0x1EDAB70 VA: 0x181EDC570
	internal void Validate() { }

	// RVA: 0x1EDC230 Offset: 0x1EDA830 VA: 0x181EDC230
	public string ResolveKeyName(SharedTableData sharedData) { }

	// RVA: 0x1EDC4A0 Offset: 0x1EDAAA0 VA: 0x181EDC4A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EDC320 Offset: 0x1EDA920 VA: 0x181EDC320
	public string ToString(TableReference tableReference) { }

	// RVA: 0x1EDC050 Offset: 0x1EDA650 VA: 0x181EDC050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EDC010 Offset: 0x1EDA610 VA: 0x181EDC010 Slot: 6
	public bool Equals(TableEntryReference other) { }

	// RVA: 0x1EDC140 Offset: 0x1EDA740 VA: 0x181EDC140 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1EDC1F0 Offset: 0x1EDA7F0 VA: 0x181EDC1F0 Slot: 5
	public void OnAfterDeserialize() { }
}

