// Namespace: UnityEngine.Localization.Operations
internal class GetLocalizedStringOperation : WaitForCurrentOperationAsyncOperationBase<string> // TypeDefIndex: 11998
{
	// Fields
	private LocalizedStringDatabase m_Database; // 0xD0
	private AsyncOperationHandle<LocalizedDatabase.TableEntryResult<StringTable, StringTableEntry>> m_TableEntryOperation; // 0xD8
	private TableReference m_TableReference; // 0xF8
	private TableEntryReference m_TableEntryReference; // 0x118
	private Locale m_SelectedLocale; // 0x130
	private IList<object> m_Arguments; // 0x138
	private IVariableGroup m_LocalVariables; // 0x140
	private bool m_AutoRelease; // 0x148

	// Methods

	// RVA: 0x1F04E60 Offset: 0x1F03460 VA: 0x181F04E60
	public void Init(AsyncOperationHandle<LocalizedDatabase.TableEntryResult<StringTable, StringTableEntry>> tableEntryOperation, Locale locale, LocalizedStringDatabase database, TableReference tableReference, TableEntryReference tableEntryReference, IList<object> arguments, IVariableGroup localVariables, bool autoRelease) { }

	// RVA: 0x1F04B50 Offset: 0x1F03150 VA: 0x181F04B50 Slot: 28
	protected override void Execute() { }

	// RVA: 0x1F04950 Offset: 0x1F02F50 VA: 0x181F04950
	public void CompleteAndRelease(string result, bool success, string errorMsg) { }

	// RVA: 0x1F04AD0 Offset: 0x1F030D0 VA: 0x181F04AD0 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x1F04FF0 Offset: 0x1F035F0 VA: 0x181F04FF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F05230 Offset: 0x1F03830 VA: 0x181F05230
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Operations
internal class GetTableEntryOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase.TableEntryResult<TTable, TEntry>> // TypeDefIndex: 11999
{
	// Fields
	private readonly Action<AsyncOperationHandle<TTable>> m_ExtractEntryFromTableAction; // 0x0
	private AsyncOperationHandle<TTable> m_LoadTableOperation; // 0x0
	private TableReference m_TableReference; // 0x0
	private TableEntryReference m_TableEntryReference; // 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; // 0x0
	private Locale m_SelectedLocale; // 0x0
	private Locale m_CurrentLocale; // 0x0
	private HashSet<Locale> m_HandledFallbacks; // 0x0
	private List<Locale> m_FallbackQueue; // 0x0
	private bool m_UseFallback; // 0x0
	private bool m_AutoRelease; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102CE80 Offset: 0x102B480 VA: 0x18102CE80
	|-GetTableEntryOperation<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(LocalizedDatabase<TTable, TEntry> database, AsyncOperationHandle<TTable> loadTableOperation, TableReference tableReference, TableEntryReference tableEntryReference, Locale selectedLoale, bool UseFallBack, bool autoRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102CA20 Offset: 0x102B020 VA: 0x18102CA20
	|-GetTableEntryOperation<object, object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102BD70 Offset: 0x102A370 VA: 0x18102BD70
	|-GetTableEntryOperation<object, object>.Execute
	*/

	// RVA: -1 Offset: -1
	private void ExtractEntryFromTable(AsyncOperationHandle<TTable> asyncOperation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102BF80 Offset: 0x102A580 VA: 0x18102BF80
	|-GetTableEntryOperation<object, object>.ExtractEntryFromTable
	*/

	// RVA: -1 Offset: -1
	private bool HandleEntryOverride(AsyncOperationHandle<TTable> asyncOperation, TEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102C4F0 Offset: 0x102AAF0 VA: 0x18102C4F0
	|-GetTableEntryOperation<object, object>.HandleEntryOverride
	*/

	// RVA: -1 Offset: -1
	private bool ApplyEntryOverride(IEntryOverride entryOverride, AsyncOperationHandle<TTable> asyncOperation, TEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102B6E0 Offset: 0x1029CE0 VA: 0x18102B6E0
	|-GetTableEntryOperation<object, object>.ApplyEntryOverride
	*/

	// RVA: -1 Offset: -1
	private Locale GetNextFallback(Locale currentLocale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102C120 Offset: 0x102A720 VA: 0x18102C120
	|-GetTableEntryOperation<object, object>.GetNextFallback
	*/

	// RVA: -1 Offset: -1
	private bool HandleFallback(AsyncOperationHandle<TTable> asyncOperation, TEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102C780 Offset: 0x102AD80 VA: 0x18102C780
	|-GetTableEntryOperation<object, object>.HandleFallback
	*/

	// RVA: -1 Offset: -1
	private void CompleteAndRelease(LocalizedDatabase.TableEntryResult<TTable, TEntry> result, bool success, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102BAA0 Offset: 0x102A0A0 VA: 0x18102BAA0
	|-GetTableEntryOperation<object, object>.CompleteAndRelease
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102BBB0 Offset: 0x102A1B0 VA: 0x18102BBB0
	|-GetTableEntryOperation<object, object>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102CB70 Offset: 0x102B170 VA: 0x18102CB70
	|-GetTableEntryOperation<object, object>.ToString
	*/
}

// Namespace: UnityEngine.Localization.Operations
internal class InitializationOperation : WaitForCurrentOperationAsyncOperationBase<LocalizationSettings> // TypeDefIndex: 12000
{
	// Fields
	private readonly Action<AsyncOperationHandle<Locale>> m_PreloadTablesAction; // 0xD0
	private readonly Action<AsyncOperationHandle> m_FinishInitializingAction; // 0xD8
	private LocalizationSettings m_Settings; // 0xE0
	private readonly List<AsyncOperationHandle> m_LoadDatabasesOperations; // 0xE8
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_PreloadDatabasesOperation; // 0xF0
	private int m_RemainingSteps; // 0x110
	private const int k_PreloadSteps = 3;

	// Properties
	protected override float Progress { get; }
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x1F05C80 Offset: 0x1F04280 VA: 0x181F05C80 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x1F05C50 Offset: 0x1F04250 VA: 0x181F05C50 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x1F05B10 Offset: 0x1F04110 VA: 0x181F05B10
	public void .ctor() { }

	// RVA: 0x1F05540 Offset: 0x1F03B40 VA: 0x181F05540
	public void Init(LocalizationSettings settings) { }

	// RVA: 0x1F052F0 Offset: 0x1F038F0 VA: 0x181F052F0 Slot: 28
	protected override void Execute() { }

	// RVA: 0x1F052F0 Offset: 0x1F038F0 VA: 0x181F052F0
	private void LoadLocales() { }

	// RVA: 0x1F05810 Offset: 0x1F03E10 VA: 0x181F05810
	private void PreloadTables() { }

	// RVA: 0x1F055D0 Offset: 0x1F03BD0 VA: 0x181F055D0
	private void PostInitializeExtensions() { }

	// RVA: 0x1F05430 Offset: 0x1F03A30 VA: 0x181F05430
	private void FinishInitializing(AsyncOperationHandle op) { }

	// RVA: 0x1F054B0 Offset: 0x1F03AB0 VA: 0x181F054B0
	private void FinishInitializing(bool success, string error) { }

	// RVA: 0x1F05270 Offset: 0x1F03870 VA: 0x181F05270 Slot: 29
	protected override void Destroy() { }

	[CompilerGenerated]
	// RVA: 0x1F05B00 Offset: 0x1F04100 VA: 0x181F05B00
	private void <.ctor>b__11_0(AsyncOperationHandle<Locale> a) { }
}

// Namespace: UnityEngine.Localization.Operations
internal class LoadAllTablesOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<IList<TTable>> // TypeDefIndex: 12001
{
	// Fields
	private AsyncOperationHandle<IList<TTable>> m_AllTablesOperation; // 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; // 0x0
	private Locale m_Locale; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Init(LocalizedDatabase<TTable, TEntry> database, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279D50 Offset: 0x1278350 VA: 0x181279D50
	|-LoadAllTablesOperation<object, object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279B40 Offset: 0x1278140 VA: 0x181279B40
	|-LoadAllTablesOperation<object, object>.Execute
	*/

	// RVA: -1 Offset: -1
	private void LoadingCompleted(AsyncOperationHandle<IList<TTable>> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279DA0 Offset: 0x12783A0 VA: 0x181279DA0
	|-LoadAllTablesOperation<object, object>.LoadingCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279AD0 Offset: 0x12780D0 VA: 0x181279AD0
	|-LoadAllTablesOperation<object, object>.Destroy
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A170 Offset: 0x1278770 VA: 0x18127A170
	|-LoadAllTablesOperation<object, object>..ctor
	*/
}

// Namespace: UnityEngine.Localization.Operations
internal class LoadAssetOperation<TObject> : WaitForCurrentOperationAsyncOperationBase<TObject> // TypeDefIndex: 12002
{
	// Fields
	private readonly Action<AsyncOperationHandle<TObject>> m_AssetLoadedAction; // 0x0
	private AsyncOperationHandle<LocalizedDatabase.TableEntryResult<AssetTable, AssetTableEntry>> m_TableEntryOperation; // 0x0
	private AsyncOperationHandle<TObject> m_LoadAssetOperation; // 0x0
	private bool m_AutoRelease; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A930 Offset: 0x1278F30 VA: 0x18127A930
	|-LoadAssetOperation<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle<LocalizedDatabase.TableEntryResult<AssetTable, AssetTableEntry>> loadTableEntryOperation, bool autoRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A870 Offset: 0x1278E70 VA: 0x18127A870
	|-LoadAssetOperation<object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A490 Offset: 0x1278A90 VA: 0x18127A490
	|-LoadAssetOperation<object>.Execute
	*/

	// RVA: -1 Offset: -1
	private void AssetLoaded(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A190 Offset: 0x1278790 VA: 0x18127A190
	|-LoadAssetOperation<object>.AssetLoaded
	*/

	// RVA: -1 Offset: -1
	public void CompleteAndRelease(TObject result, bool success, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A250 Offset: 0x1278850 VA: 0x18127A250
	|-LoadAssetOperation<object>.CompleteAndRelease
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A3E0 Offset: 0x12789E0 VA: 0x18127A3E0
	|-LoadAssetOperation<object>.Destroy
	*/
}

// Namespace: UnityEngine.Localization.Operations
internal class LoadSubAssetOperation<TObject> : WaitForCurrentOperationAsyncOperationBase<TObject> // TypeDefIndex: 12003
{
	// Fields
	private readonly Action<AsyncOperationHandle<TObject>> m_AssetLoadedAction; // 0x0
	private AsyncOperationHandle<TObject> m_AssetOperation; // 0x0
	private AsyncOperationHandle<Object[]> m_PreloadOperations; // 0x0
	private string m_Address; // 0x0
	private bool m_IsSubAsset; // 0x0
	private string m_SubAssetName; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A930 Offset: 0x1278F30 VA: 0x18127A930
	|-LoadSubAssetOperation<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(AsyncOperationHandle<Object[]> preloadOperations, string address, bool isSubAsset, string subAssetName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127AF50 Offset: 0x1279550 VA: 0x18127AF50
	|-LoadSubAssetOperation<object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127ABA0 Offset: 0x12791A0 VA: 0x18127ABA0
	|-LoadSubAssetOperation<object>.Execute
	*/

	// RVA: -1 Offset: -1
	private void AssetLoaded(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A9D0 Offset: 0x1278FD0 VA: 0x18127A9D0
	|-LoadSubAssetOperation<object>.AssetLoaded
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127AAC0 Offset: 0x12790C0 VA: 0x18127AAC0
	|-LoadSubAssetOperation<object>.Destroy
	*/
}

// Namespace: UnityEngine.Localization.Operations
internal class LoadTableOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<TTable> // TypeDefIndex: 12004
{
	// Fields
	private readonly Action<AsyncOperationHandle<SharedTableData>> m_LoadTableByGuidAction; // 0x0
	private readonly Action<AsyncOperationHandle<IList<IResourceLocation>>> m_LoadTableResourceAction; // 0x0
	private readonly Action<AsyncOperationHandle<TTable>> m_TableLoadedAction; // 0x0
	private readonly Action<AsyncOperationHandle<TTable>> m_CustomTableLoadedAction; // 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; // 0x0
	private TableReference m_TableReference; // 0x0
	private AsyncOperationHandle<TTable> m_LoadTableOperation; // 0x0
	private Locale m_SelectedLocale; // 0x0
	private string m_CollectionName; // 0x0
	[CompilerGenerated]
	private Action<AsyncOperationHandle<TTable>> <RegisterTableOperation>k__BackingField; // 0x0

	// Properties
	public Action<AsyncOperationHandle<TTable>> RegisterTableOperation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Action<AsyncOperationHandle<TTable>> get_RegisterTableOperation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C510 Offset: 0x127AB10 VA: 0x18127C510
	|-LoadTableOperation<object, object>.get_RegisterTableOperation
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_RegisterTableOperation(Action<AsyncOperationHandle<TTable>> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C520 Offset: 0x127AB20 VA: 0x18127C520
	|-LoadTableOperation<object, object>.set_RegisterTableOperation
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C360 Offset: 0x127A960 VA: 0x18127C360
	|-LoadTableOperation<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(LocalizedDatabase<TTable, TEntry> database, TableReference tableReference, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127B940 Offset: 0x1279F40 VA: 0x18127B940
	|-LoadTableOperation<object, object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127B460 Offset: 0x1279A60 VA: 0x18127B460
	|-LoadTableOperation<object, object>.Execute
	*/

	// RVA: -1 Offset: -1
	private void LoadTableByGuid(AsyncOperationHandle<SharedTableData> operationHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127B9C0 Offset: 0x1279FC0 VA: 0x18127B9C0
	|-LoadTableOperation<object, object>.LoadTableByGuid
	*/

	// RVA: -1 Offset: -1
	private void FindTableByName(string collectionName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127B8D0 Offset: 0x1279ED0 VA: 0x18127B8D0
	|-LoadTableOperation<object, object>.FindTableByName
	*/

	// RVA: -1 Offset: -1
	private bool TryLoadWithTableProvider() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C010 Offset: 0x127A610 VA: 0x18127C010
	|-LoadTableOperation<object, object>.TryLoadWithTableProvider
	*/

	// RVA: -1 Offset: -1
	private void DefaultLoadTableByName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127B200 Offset: 0x1279800 VA: 0x18127B200
	|-LoadTableOperation<object, object>.DefaultLoadTableByName
	*/

	// RVA: -1 Offset: -1
	private void LoadTableResource(AsyncOperationHandle<IList<IResourceLocation>> operationHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127BAE0 Offset: 0x127A0E0 VA: 0x18127BAE0
	|-LoadTableOperation<object, object>.LoadTableResource
	*/

	// RVA: -1 Offset: -1
	private void CustomTableLoaded(AsyncOperationHandle<TTable> operationHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127B0D0 Offset: 0x12796D0 VA: 0x18127B0D0
	|-LoadTableOperation<object, object>.CustomTableLoaded
	*/

	// RVA: -1 Offset: -1
	private void TableLoaded(AsyncOperationHandle<TTable> operationHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127BE90 Offset: 0x127A490 VA: 0x18127BE90
	|-LoadTableOperation<object, object>.TableLoaded
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127B3B0 Offset: 0x12799B0 VA: 0x18127B3B0
	|-LoadTableOperation<object, object>.Destroy
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127BF30 Offset: 0x127A530 VA: 0x18127BF30
	|-LoadTableOperation<object, object>.ToString
	*/
}

// Namespace: UnityEngine.Localization.Operations
internal class LocalizationGroupOperation : GroupOperation // TypeDefIndex: 12005
{
	// Methods

	// RVA: 0x1F081F0 Offset: 0x1F067F0 VA: 0x181F081F0 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x1F08180 Offset: 0x1F06780 VA: 0x181F08180 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x1F083F0 Offset: 0x1F069F0 VA: 0x181F083F0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Operations
internal class PreloadDatabaseOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>> // TypeDefIndex: 12006
{
	// Fields
	private readonly Action<AsyncOperationHandle> m_CompleteOperation; // 0x0
	private readonly Action<AsyncOperationHandle<IList<AsyncOperationHandle>>> m_CompleteGenericGroup; // 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; // 0x0

	// Properties
	protected override float Progress { get; }
	protected override string DebugName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F21E0 Offset: 0x12F07E0 VA: 0x1812F21E0
	|-PreloadDatabaseOperation<object, object>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2180 Offset: 0x12F0780 VA: 0x1812F2180
	|-PreloadDatabaseOperation<object, object>.get_DebugName
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2090 Offset: 0x12F0690 VA: 0x1812F2090
	|-PreloadDatabaseOperation<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(LocalizedDatabase<TTable, TEntry> database) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F1A10 Offset: 0x12F0010 VA: 0x1812F1A10
	|-PreloadDatabaseOperation<object, object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F13C0 Offset: 0x12EF9C0 VA: 0x1812F13C0
	|-PreloadDatabaseOperation<object, object>.Execute
	*/

	// RVA: -1 Offset: -1
	private void GetAllFallbackLocales(Locale current, HashSet<Locale> locales) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F17E0 Offset: 0x12EFDE0 VA: 0x1812F17E0
	|-PreloadDatabaseOperation<object, object>.GetAllFallbackLocales
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle PreloadLocale(Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F1A30 Offset: 0x12F0030 VA: 0x1812F1A30
	|-PreloadDatabaseOperation<object, object>.PreloadLocale
	*/

	// RVA: -1 Offset: -1
	private void PreloadLocales(ICollection<Locale> locales) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F1C20 Offset: 0x12F0220 VA: 0x1812F1C20
	|-PreloadDatabaseOperation<object, object>.PreloadLocales
	*/

	// RVA: -1 Offset: -1
	private void CompleteOperation(AsyncOperationHandle operationHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F12C0 Offset: 0x12EF8C0 VA: 0x1812F12C0
	|-PreloadDatabaseOperation<object, object>.CompleteOperation
	*/

	// RVA: -1 Offset: -1
	private void CompleteGenericGroup(AsyncOperationHandle<IList<AsyncOperationHandle>> operationHandle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F11F0 Offset: 0x12EF7F0 VA: 0x1812F11F0
	|-PreloadDatabaseOperation<object, object>.CompleteGenericGroup
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F1330 Offset: 0x12EF930 VA: 0x1812F1330
	|-PreloadDatabaseOperation<object, object>.Destroy
	*/
}

// Namespace: UnityEngine.Localization.Operations
internal class PreloadLocaleOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>> // TypeDefIndex: 12007
{
	// Fields
	private readonly Action<AsyncOperationHandle<IList<IResourceLocation>>> m_LoadTablesAction; // 0x0
	private readonly Action<AsyncOperationHandle<TTable>> m_LoadTableContentsAction; // 0x0
	private readonly Action<AsyncOperationHandle> m_FinishPreloadingAction; // 0x0
	private readonly Action<AsyncOperationHandle<IList<AsyncOperationHandle>>> m_PreloadTablesCompletedAction; // 0x0
	private LocalizedDatabase<TTable, TEntry> m_Database; // 0x0
	private Locale m_Locale; // 0x0
	private AsyncOperationHandle<IList<IResourceLocation>> m_LoadResourcesOperation; // 0x0
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_LoadTablesGroupOperation; // 0x0
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_LoadTableContentsOperation; // 0x0
	private readonly List<AsyncOperationHandle> m_LoadTablesOperations; // 0x0
	private readonly List<AsyncOperationHandle> m_PreloadTableContentsOperations; // 0x0
	private readonly List<string> m_ResourceLabels; // 0x0
	private float m_Progress; // 0x0

	// Properties
	protected override float Progress { get; }
	protected override string DebugName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 30
	protected override float get_Progress() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F39D0 Offset: 0x12F1FD0 VA: 0x1812F39D0
	|-PreloadLocaleOperation<object, object>.get_Progress
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected override string get_DebugName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3960 Offset: 0x12F1F60 VA: 0x1812F3960
	|-PreloadLocaleOperation<object, object>.get_DebugName
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3700 Offset: 0x12F1D00 VA: 0x1812F3700
	|-PreloadLocaleOperation<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(LocalizedDatabase<TTable, TEntry> database, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F27C0 Offset: 0x12F0DC0 VA: 0x1812F27C0
	|-PreloadLocaleOperation<object, object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2740 Offset: 0x12F0D40 VA: 0x1812F2740
	|-PreloadLocaleOperation<object, object>.Execute
	*/

	// RVA: -1 Offset: -1
	private void BeginPreloading() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2290 Offset: 0x12F0890 VA: 0x1812F2290
	|-PreloadLocaleOperation<object, object>.BeginPreloading
	*/

	// RVA: -1 Offset: -1
	private void LoadTables(AsyncOperationHandle<IList<IResourceLocation>> loadResourcesOperation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2DA0 Offset: 0x12F13A0 VA: 0x1812F2DA0
	|-PreloadLocaleOperation<object, object>.LoadTables
	*/

	// RVA: -1 Offset: -1
	private void LoadTableContents(AsyncOperationHandle<TTable> operation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2890 Offset: 0x12F0E90 VA: 0x1812F2890
	|-PreloadLocaleOperation<object, object>.LoadTableContents
	*/

	// RVA: -1 Offset: -1
	private void PreloadTablesCompleted(AsyncOperationHandle<IList<AsyncOperationHandle>> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3530 Offset: 0x12F1B30 VA: 0x1812F3530
	|-PreloadLocaleOperation<object, object>.PreloadTablesCompleted
	*/

	// RVA: -1 Offset: -1
	private void FinishPreloading(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2760 Offset: 0x12F0D60 VA: 0x1812F2760
	|-PreloadLocaleOperation<object, object>.FinishPreloading
	*/

	// RVA: -1 Offset: -1
	private void CompleteAndRelease(bool success, string errorMsg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F25E0 Offset: 0x12F0BE0 VA: 0x1812F25E0
	|-PreloadLocaleOperation<object, object>.CompleteAndRelease
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F26B0 Offset: 0x12F0CB0 VA: 0x1812F26B0
	|-PreloadLocaleOperation<object, object>.Destroy
	*/
}

// Namespace: UnityEngine.Localization.Operations
internal class PreloadTablesOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>> // TypeDefIndex: 12008
{
	// Fields
	private LocalizedDatabase<TTable, TEntry> m_Database; // 0x0
	private readonly List<AsyncOperationHandle<TTable>> m_LoadTables; // 0x0
	private readonly List<AsyncOperationHandle> m_LoadTablesOperation; // 0x0
	private readonly List<AsyncOperationHandle> m_PreloadTablesOperations; // 0x0
	private readonly Action<AsyncOperationHandle<IList<AsyncOperationHandle>>> m_LoadTableContentsAction; // 0x0
	private readonly Action<AsyncOperationHandle> m_FinishPreloadingAction; // 0x0
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_LoadTablesOperationHandle; // 0x0
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_PreloadTablesContentsHandle; // 0x0
	private IList<TableReference> m_TableReferences; // 0x0
	private Locale m_SelectedLocale; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F46F0 Offset: 0x12F2CF0 VA: 0x1812F46F0
	|-PreloadTablesOperation<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(LocalizedDatabase<TTable, TEntry> database, IList<TableReference> tableReference, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F40F0 Offset: 0x12F26F0 VA: 0x1812F40F0
	|-PreloadTablesOperation<object, object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void Execute() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F4060 Offset: 0x12F2660 VA: 0x1812F4060
	|-PreloadTablesOperation<object, object>.Execute
	*/

	// RVA: -1 Offset: -1
	private void BeginPreloadingTables() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F39E0 Offset: 0x12F1FE0 VA: 0x1812F39E0
	|-PreloadTablesOperation<object, object>.BeginPreloadingTables
	*/

	// RVA: -1 Offset: -1
	private void LoadTableContents() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F4160 Offset: 0x12F2760 VA: 0x1812F4160
	|-PreloadTablesOperation<object, object>.LoadTableContents
	*/

	// RVA: -1 Offset: -1
	private void FinishPreloading(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F4080 Offset: 0x12F2680 VA: 0x1812F4080
	|-PreloadTablesOperation<object, object>.FinishPreloading
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3ED0 Offset: 0x12F24D0 VA: 0x1812F3ED0
	|-PreloadTablesOperation<object, object>.Destroy
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <.ctor>b__10_0(AsyncOperationHandle<IList<AsyncOperationHandle>> a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F4640 Offset: 0x12F2C40 VA: 0x1812F4640
	|-PreloadTablesOperation<object, object>.<.ctor>b__10_0
	*/
}

// Namespace: UnityEngine.Localization.Operations
internal abstract class WaitForCurrentOperationAsyncOperationBase<TObject> : AsyncOperationBase<TObject> // TypeDefIndex: 12009
{
	// Fields
	[CompilerGenerated]
	private AsyncOperationHandle <CurrentOperation>k__BackingField; // 0x0
	[CompilerGenerated]
	private AsyncOperationHandle <Dependency>k__BackingField; // 0x0
	private bool m_Waiting; // 0x0

	// Properties
	protected AsyncOperationHandle CurrentOperation { get; set; }
	public AsyncOperationHandle Dependency { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected AsyncOperationHandle get_CurrentOperation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3900 Offset: 0xBE1F00 VA: 0x180BE3900
	|-WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_CurrentOperation
	|
	|-RVA: 0xBE3920 Offset: 0xBE1F20 VA: 0x180BE3920
	|-WaitForCurrentOperationAsyncOperationBase<object>.get_CurrentOperation
	|
	|-RVA: 0xBE38B0 Offset: 0xBE1EB0 VA: 0x180BE38B0
	|-WaitForCurrentOperationAsyncOperationBase<__Il2CppFullySharedGenericType>.get_CurrentOperation
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_CurrentOperation(AsyncOperationHandle value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE39D0 Offset: 0xBE1FD0 VA: 0x180BE39D0
	|-WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.set_CurrentOperation
	|
	|-RVA: 0xBE3A00 Offset: 0xBE2000 VA: 0x180BE3A00
	|-WaitForCurrentOperationAsyncOperationBase<object>.set_CurrentOperation
	|
	|-RVA: 0xBE3A30 Offset: 0xBE2030 VA: 0x180BE3A30
	|-WaitForCurrentOperationAsyncOperationBase<__Il2CppFullySharedGenericType>.set_CurrentOperation
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public AsyncOperationHandle get_Dependency() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3960 Offset: 0xBE1F60 VA: 0x180BE3960
	|-WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.get_Dependency
	|
	|-RVA: 0xBE3940 Offset: 0xBE1F40 VA: 0x180BE3940
	|-WaitForCurrentOperationAsyncOperationBase<object>.get_Dependency
	|
	|-RVA: 0xBE3980 Offset: 0xBE1F80 VA: 0x180BE3980
	|-WaitForCurrentOperationAsyncOperationBase<__Il2CppFullySharedGenericType>.get_Dependency
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Dependency(AsyncOperationHandle value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3B20 Offset: 0xBE2120 VA: 0x180BE3B20
	|-WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.set_Dependency
	|
	|-RVA: 0xBE3B50 Offset: 0xBE2150 VA: 0x180BE3B50
	|-WaitForCurrentOperationAsyncOperationBase<object>.set_Dependency
	|
	|-RVA: 0xBE3AA0 Offset: 0xBE20A0 VA: 0x180BE3AA0
	|-WaitForCurrentOperationAsyncOperationBase<__Il2CppFullySharedGenericType>.set_Dependency
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected override bool InvokeWaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE2E10 Offset: 0xBE1410 VA: 0x180BE2E10
	|-WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.InvokeWaitForCompletion
	|
	|-RVA: 0xBE2A70 Offset: 0xBE1070 VA: 0x180BE2A70
	|-WaitForCurrentOperationAsyncOperationBase<object>.InvokeWaitForCompletion
	|
	|-RVA: 0xBE31F0 Offset: 0xBE17F0 VA: 0x180BE31F0
	|-WaitForCurrentOperationAsyncOperationBase<__Il2CppFullySharedGenericType>.InvokeWaitForCompletion
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected override void Destroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE28F0 Offset: 0xBE0EF0 VA: 0x180BE28F0
	|-WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>.Destroy
	|
	|-RVA: 0xBE2860 Offset: 0xBE0E60 VA: 0x180BE2860
	|-WaitForCurrentOperationAsyncOperationBase<object>.Destroy
	|
	|-RVA: 0xBE2980 Offset: 0xBE0F80 VA: 0x180BE2980
	|-WaitForCurrentOperationAsyncOperationBase<__Il2CppFullySharedGenericType>.Destroy
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3870 Offset: 0xBE1E70 VA: 0x180BE3870
	|-WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase.TableEntryResult<object, object>>..ctor
	|
	|-RVA: 0xBE3850 Offset: 0xBE1E50 VA: 0x180BE3850
	|-WaitForCurrentOperationAsyncOperationBase<object>..ctor
	|
	|-RVA: 0xBE3890 Offset: 0xBE1E90 VA: 0x180BE3890
	|-WaitForCurrentOperationAsyncOperationBase<__Il2CppFullySharedGenericType>..ctor
	*/
}

