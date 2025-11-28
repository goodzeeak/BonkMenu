// Namespace: UnityEngine.Localization.Settings
[Serializable]
public class LocalizedAssetDatabase : LocalizedDatabase<AssetTable, AssetTableEntry> // TypeDefIndex: 11953
{
	// Methods

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> GetLocalizedAssetAsync<TObject>(TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72D070 Offset: 0x72B670 VA: 0x18072D070
	|-LocalizedAssetDatabase.GetLocalizedAssetAsync<object>
	*/

	// RVA: -1 Offset: -1
	public TObject GetLocalizedAsset<TObject>(TableEntryReference tableEntryReference, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72D1A0 Offset: 0x72B7A0 VA: 0x18072D1A0
	|-LocalizedAssetDatabase.GetLocalizedAsset<object>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public virtual AsyncOperationHandle<TObject> GetLocalizedAssetAsync<TObject>(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72CF80 Offset: 0x72B580 VA: 0x18072CF80
	|-LocalizedAssetDatabase.GetLocalizedAssetAsync<object>
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public virtual TObject GetLocalizedAsset<TObject>(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72D2E0 Offset: 0x72B8E0 VA: 0x18072D2E0
	|-LocalizedAssetDatabase.GetLocalizedAsset<object>
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected virtual AsyncOperationHandle<TObject> GetLocalizedAssetAsyncInternal<TObject>(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72CD60 Offset: 0x72B360 VA: 0x18072CD60
	|-LocalizedAssetDatabase.GetLocalizedAssetAsyncInternal<object>
	*/

	// RVA: 0x1EF0990 Offset: 0x1EEEF90 VA: 0x181EF0990 Slot: 17
	internal override void ReleaseTableContents(AssetTable table) { }

	// RVA: 0x1EF09B0 Offset: 0x1EEEFB0 VA: 0x181EF09B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Settings
public enum FallbackBehavior // TypeDefIndex: 11954
{
	// Fields
	public int value__; // 0x0
	public const FallbackBehavior UseProjectSettings = 0;
	public const FallbackBehavior DontUseFallback = 1;
	public const FallbackBehavior UseFallback = 2;
}

// Namespace: UnityEngine.Localization.Settings
[Flags]
public enum MissingTranslationBehavior // TypeDefIndex: 11955
{
	// Fields
	public int value__; // 0x0
	public const MissingTranslationBehavior ShowMissingTranslationMessage = 1;
	public const MissingTranslationBehavior PrintWarning = 2;
}

// Namespace: UnityEngine.Localization.Settings
public interface ITableProvider // TypeDefIndex: 11956
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AsyncOperationHandle<TTable> ProvideTableAsync<TTable>(string tableCollectionName, Locale locale);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITableProvider.ProvideTableAsync<object>
	*/
}

// Namespace: UnityEngine.Localization.Settings
public interface ITablePostprocessor // TypeDefIndex: 11957
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PostprocessTable(LocalizationTable table);
}

// Namespace: UnityEngine.Localization.Settings
[Serializable]
public abstract class LocalizedDatabase<TTable, TEntry> : IPreloadRequired, IReset, IDisposable // TypeDefIndex: 11959
{
	// Fields
	[SerializeField]
	private TableReference m_DefaultTableReference; // 0x0
	[SerializeReference]
	private ITableProvider m_CustomTableProvider; // 0x0
	[SerializeReference]
	private ITablePostprocessor m_CustomTablePostprocessor; // 0x0
	[SerializeField]
	private bool m_UseFallback; // 0x0
	internal AsyncOperationHandle m_PreloadOperationHandle; // 0x0
	private Action<AsyncOperationHandle> m_ReleaseNextFrame; // 0x0
	private readonly Action<AsyncOperationHandle<TTable>> m_PatchTableContentsAction; // 0x0
	private readonly Action<AsyncOperationHandle<TTable>> m_RegisterSharedTableAndGuidOperationAction; // 0x0
	private readonly Action<AsyncOperationHandle<TTable>> m_RegisterCompletedTableOperationAction; // 0x0
	internal static readonly LocaleIdentifier k_SelectedLocaleId; // 0x0
	[TupleElementNames(new[] { "localeIdentifier", "tableNameOrGuid" })]
	[CompilerGenerated]
	private readonly Dictionary<ValueTuple<LocaleIdentifier, string>, AsyncOperationHandle<TTable>> <TableOperations>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly Dictionary<Guid, AsyncOperationHandle<SharedTableData>> <SharedTableDataOperations>k__BackingField; // 0x0

	// Properties
	public AsyncOperationHandle PreloadOperation { get; }
	internal Action<AsyncOperationHandle> ReleaseNextFrame { get; }
	[TupleElementNames(new[] { "localeIdentifier", "tableNameOrGuid" })]
	internal Dictionary<ValueTuple<LocaleIdentifier, string>, AsyncOperationHandle<TTable>> TableOperations { get; }
	internal Dictionary<Guid, AsyncOperationHandle<SharedTableData>> SharedTableDataOperations { get; }
	public virtual TableReference DefaultTable { get; set; }
	public ITableProvider TableProvider { get; set; }
	public ITablePostprocessor TablePostprocessor { get; set; }
	public bool UseFallback { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public AsyncOperationHandle get_PreloadOperation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281420 Offset: 0x127FA20 VA: 0x181281420
	|-LocalizedDatabase<object, object>.get_PreloadOperation
	*/

	// RVA: -1 Offset: -1
	internal Action<AsyncOperationHandle> get_ReleaseNextFrame() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	|-LocalizedDatabase<object, object>.get_ReleaseNextFrame
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal Dictionary<ValueTuple<LocaleIdentifier, string>, AsyncOperationHandle<TTable>> get_TableOperations() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	|-LocalizedDatabase<object, object>.get_TableOperations
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal Dictionary<Guid, AsyncOperationHandle<SharedTableData>> get_SharedTableDataOperations() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	|-LocalizedDatabase<object, object>.get_SharedTableDataOperations
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public virtual TableReference get_DefaultTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC175B0 Offset: 0xC15BB0 VA: 0x180C175B0
	|-LocalizedDatabase<object, object>.get_DefaultTable
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual void set_DefaultTable(TableReference value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12815A0 Offset: 0x127FBA0 VA: 0x1812815A0
	|-LocalizedDatabase<object, object>.set_DefaultTable
	*/

	// RVA: -1 Offset: -1
	public ITableProvider get_TableProvider() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-LocalizedDatabase<object, object>.get_TableProvider
	*/

	// RVA: -1 Offset: -1
	public void set_TableProvider(ITableProvider value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	|-LocalizedDatabase<object, object>.set_TableProvider
	*/

	// RVA: -1 Offset: -1
	public ITablePostprocessor get_TablePostprocessor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	|-LocalizedDatabase<object, object>.get_TablePostprocessor
	*/

	// RVA: -1 Offset: -1
	public void set_TablePostprocessor(ITablePostprocessor value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	|-LocalizedDatabase<object, object>.set_TablePostprocessor
	*/

	// RVA: -1 Offset: -1
	public bool get_UseFallback() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	|-LocalizedDatabase<object, object>.get_UseFallback
	*/

	// RVA: -1 Offset: -1
	public void set_UseFallback(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40E2F0 Offset: 0x40C8F0 VA: 0x18040E2F0
	|-LocalizedDatabase<object, object>.set_UseFallback
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12811E0 Offset: 0x127F7E0 VA: 0x1812811E0
	|-LocalizedDatabase<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TableReference GetDefaultTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127DE00 Offset: 0x127C400 VA: 0x18127DE00
	|-LocalizedDatabase<object, object>.GetDefaultTable
	*/

	// RVA: -1 Offset: -1
	internal void RegisterCompletedTableOperation(AsyncOperationHandle<TTable> tableOperation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127F490 Offset: 0x127DA90 VA: 0x18127F490
	|-LocalizedDatabase<object, object>.RegisterCompletedTableOperation
	*/

	// RVA: -1 Offset: -1
	private void RegisterTableNameOperation(AsyncOperationHandle<TTable> tableOperation, LocaleIdentifier localeIdentifier, string tableName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127F990 Offset: 0x127DF90 VA: 0x18127F990
	|-LocalizedDatabase<object, object>.RegisterTableNameOperation
	*/

	// RVA: -1 Offset: -1
	private void RegisterSharedTableAndGuidOperation(AsyncOperationHandle<TTable> tableOperation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127F650 Offset: 0x127DC50 VA: 0x18127F650
	|-LocalizedDatabase<object, object>.RegisterSharedTableAndGuidOperation
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TTable> GetDefaultTableAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127DCB0 Offset: 0x127C2B0 VA: 0x18127DCB0
	|-LocalizedDatabase<object, object>.GetDefaultTableAsync
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public virtual AsyncOperationHandle<TTable> GetTableAsync(TableReference tableReference, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E040 Offset: 0x127C640 VA: 0x18127E040
	|-LocalizedDatabase<object, object>.GetTableAsync
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual TTable GetTable(TableReference tableReference, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127EBD0 Offset: 0x127D1D0 VA: 0x18127EBD0
	|-LocalizedDatabase<object, object>.GetTable
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle PreloadTables(TableReference tableReference, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127F210 Offset: 0x127D810 VA: 0x18127F210
	|-LocalizedDatabase<object, object>.PreloadTables
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle PreloadTables(IList<TableReference> tableReferences, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127EFE0 Offset: 0x127D5E0 VA: 0x18127EFE0
	|-LocalizedDatabase<object, object>.PreloadTables
	*/

	// RVA: -1 Offset: -1
	public void ReleaseAllTables(Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127FC60 Offset: 0x127E260 VA: 0x18127FC60
	|-LocalizedDatabase<object, object>.ReleaseAllTables
	*/

	// RVA: -1 Offset: -1
	public void ReleaseTable(TableReference tableReference, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1280450 Offset: 0x127EA50 VA: 0x181280450
	|-LocalizedDatabase<object, object>.ReleaseTable
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual AsyncOperationHandle<IList<TTable>> GetAllTables(Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127DA90 Offset: 0x127C090 VA: 0x18127DA90
	|-LocalizedDatabase<object, object>.GetAllTables
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool IsTableLoaded(TableReference tableReference, Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127EC60 Offset: 0x127D260 VA: 0x18127EC60
	|-LocalizedDatabase<object, object>.IsTableLoaded
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal virtual LoadTableOperation<TTable, TEntry> CreateLoadTableOperation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D9D0 Offset: 0x127BFD0 VA: 0x18127D9D0
	|-LocalizedDatabase<object, object>.CreateLoadTableOperation
	*/

	// RVA: -1 Offset: -1 Slot: 14
	internal virtual PreloadTablesOperation<TTable, TEntry> CreatePreloadTablesOperation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127DA30 Offset: 0x127C030 VA: 0x18127DA30
	|-LocalizedDatabase<object, object>.CreatePreloadTablesOperation
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual AsyncOperationHandle<LocalizedDatabase.TableEntryResult<TTable, TEntry>> GetTableEntryAsync(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E890 Offset: 0x127CE90 VA: 0x18127E890
	|-LocalizedDatabase<object, object>.GetTableEntryAsync
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual LocalizedDatabase.TableEntryResult<TTable, TEntry> GetTableEntry(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127EB00 Offset: 0x127D100 VA: 0x18127EB00
	|-LocalizedDatabase<object, object>.GetTableEntry
	*/

	// RVA: -1 Offset: -1
	internal AsyncOperationHandle<SharedTableData> GetSharedTableData(Guid tableNameGuid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127DF00 Offset: 0x127C500 VA: 0x18127DF00
	|-LocalizedDatabase<object, object>.GetSharedTableData
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal virtual void ReleaseTableContents(TTable table) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-LocalizedDatabase<object, object>.ReleaseTableContents
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public virtual void OnLocaleChanged(Locale locale) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127EE80 Offset: 0x127D480 VA: 0x18127EE80
	|-LocalizedDatabase<object, object>.OnLocaleChanged
	*/

	// RVA: -1 Offset: -1
	private void PatchTableContents(AsyncOperationHandle<TTable> tableOperation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127EEA0 Offset: 0x127D4A0 VA: 0x18127EEA0
	|-LocalizedDatabase<object, object>.PatchTableContents
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void ResetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12810E0 Offset: 0x127F6E0 VA: 0x1812810E0
	|-LocalizedDatabase<object, object>.ResetState
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12810E0 Offset: 0x127F6E0 VA: 0x1812810E0
	|-LocalizedDatabase<object, object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281100 Offset: 0x127F700 VA: 0x181281100
	|-LocalizedDatabase<object, object>..cctor
	*/
}

// Namespace: UnityEngine.Localization.Settings
[Serializable]
public class LocalizedStringDatabase : LocalizedDatabase<StringTable, StringTableEntry> // TypeDefIndex: 11961
{
	// Fields
	[SerializeField]
	private MissingTranslationBehavior m_MissingTranslationState; // 0x90
	[CompilerGenerated]
	private LocalizedStringDatabase.MissingTranslation TranslationNotFound; // 0x98
	private const string k_DefaultNoTranslationMessage = "No translation found for \'{key}\' in {table.TableCollectionName}";
	[SerializeField]
	[Tooltip("The string that will be used when a localized value is missing. This is a Smart String which has access to the following placeholders:
	{key}: The name of the key
	{keyId}: The numeric Id of the key
	{table}: The table object, this can be further queried, for example {table.TableCollectionName}
	{locale}: The locale asset, this can be further queried, for example {locale.name}")]
	private string m_NoTranslationFoundMessage; // 0xA0
	[SerializeReference]
	private SmartFormatter m_SmartFormat; // 0xA8
	private StringTable m_MissingTranslationTable; // 0xB0

	// Properties
	public string NoTranslationFoundMessage { get; set; }
	public MissingTranslationBehavior MissingTranslationState { get; set; }
	public SmartFormatter SmartFormatter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1EF1EC0 Offset: 0x1EF04C0 VA: 0x181EF1EC0
	public void add_TranslationNotFound(LocalizedStringDatabase.MissingTranslation value) { }

	[CompilerGenerated]
	// RVA: 0x1EF1F70 Offset: 0x1EF0570 VA: 0x181EF1F70
	public void remove_TranslationNotFound(LocalizedStringDatabase.MissingTranslation value) { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public string get_NoTranslationFoundMessage() { }

	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120
	public void set_NoTranslationFoundMessage(string value) { }

	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	public MissingTranslationBehavior get_MissingTranslationState() { }

	// RVA: 0xAC7EF0 Offset: 0xAC64F0 VA: 0x180AC7EF0
	public void set_MissingTranslationState(MissingTranslationBehavior value) { }

	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public SmartFormatter get_SmartFormatter() { }

	// RVA: 0x163E0C0 Offset: 0x163C6C0 VA: 0x18163E0C0
	public void set_SmartFormatter(SmartFormatter value) { }

	// RVA: 0x1EF1020 Offset: 0x1EEF620 VA: 0x181EF1020
	public AsyncOperationHandle<string> GetLocalizedStringAsync(TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = 0, object[] arguments) { }

	// RVA: 0x1EF1290 Offset: 0x1EEF890 VA: 0x181EF1290
	public string GetLocalizedString(TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = 0, object[] arguments) { }

	// RVA: 0x1EF0F10 Offset: 0x1EEF510 VA: 0x181EF0F10
	public AsyncOperationHandle<string> GetLocalizedStringAsync(TableEntryReference tableEntryReference, IList<object> arguments, Locale locale, FallbackBehavior fallbackBehavior = 0) { }

	// RVA: 0x1EF1370 Offset: 0x1EEF970 VA: 0x181EF1370
	public string GetLocalizedString(TableEntryReference tableEntryReference, IList<object> arguments, Locale locale, FallbackBehavior fallbackBehavior = 0) { }

	// RVA: 0x1EF1130 Offset: 0x1EEF730 VA: 0x181EF1130 Slot: 19
	public virtual AsyncOperationHandle<string> GetLocalizedStringAsync(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = 0, object[] arguments) { }

	// RVA: 0x1EF15D0 Offset: 0x1EEFBD0 VA: 0x181EF15D0 Slot: 20
	public virtual string GetLocalizedString(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = 0, object[] arguments) { }

	// RVA: 0x1EF11E0 Offset: 0x1EEF7E0 VA: 0x181EF11E0 Slot: 21
	public virtual AsyncOperationHandle<string> GetLocalizedStringAsync(TableReference tableReference, TableEntryReference tableEntryReference, IList<object> arguments, Locale locale, FallbackBehavior fallbackBehavior = 0, IVariableGroup localVariables) { }

	// RVA: 0x1EF0C90 Offset: 0x1EEF290 VA: 0x181EF0C90 Slot: 22
	internal virtual AsyncOperationHandle<string> GetLocalizedStringAsyncInternal(TableReference tableReference, TableEntryReference tableEntryReference, IList<object> arguments, Locale locale, FallbackBehavior fallbackBehavior = 0, IVariableGroup localVariables, bool autoRelease = True) { }

	// RVA: 0x1EF1450 Offset: 0x1EEFA50 VA: 0x181EF1450 Slot: 23
	public virtual string GetLocalizedString(TableReference tableReference, TableEntryReference tableEntryReference, IList<object> arguments, Locale locale, FallbackBehavior fallbackBehavior = 0) { }

	// RVA: 0x1EF0A10 Offset: 0x1EEF010 VA: 0x181EF0A10 Slot: 24
	protected internal virtual string GenerateLocalizedString(StringTable table, StringTableEntry entry, TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, IList<object> arguments) { }

	// RVA: 0x1EF1640 Offset: 0x1EEFC40 VA: 0x181EF1640
	private StringTable GetUntranslatedTextTempTable(TableReference tableReference) { }

	// RVA: 0x1EF19B0 Offset: 0x1EEFFB0 VA: 0x181EF19B0
	internal string ProcessUntranslatedText(string key, long keyId, TableReference tableReference, StringTable table, Locale locale) { }

	// RVA: 0x1EF1DF0 Offset: 0x1EF03F0 VA: 0x181EF1DF0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Settings
public interface IInitialize // TypeDefIndex: 11962
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PostInitialization(LocalizationSettings settings);
}

// Namespace: UnityEngine.Localization.Settings
public interface ILocalesProvider // TypeDefIndex: 11963
{
	// Properties
	public abstract List<Locale> Locales { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract List<Locale> get_Locales();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Locale GetLocale(LocaleIdentifier id);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddLocale(Locale locale);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool RemoveLocale(Locale locale);
}

// Namespace: UnityEngine.Localization.Settings
public interface IReset // TypeDefIndex: 11964
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ResetState();
}

// Namespace: UnityEngine.Localization.Settings
public interface IStartupLocaleSelector // TypeDefIndex: 11965
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Locale GetStartupLocale(ILocalesProvider availableLocales);
}

// Namespace: UnityEngine.Localization.Settings
[Serializable]
public class LocalesProvider : ILocalesProvider, IPreloadRequired, IReset, IDisposable // TypeDefIndex: 11966
{
	// Fields
	private readonly List<Locale> m_Locales; // 0x10
	private AsyncOperationHandle m_LoadOperation; // 0x18

	// Properties
	public List<Locale> Locales { get; }
	public AsyncOperationHandle PreloadOperation { get; }

	// Methods

	// RVA: 0x1EEDBC0 Offset: 0x1EEC1C0 VA: 0x181EEDBC0 Slot: 4
	public List<Locale> get_Locales() { }

	// RVA: 0x1EEDC60 Offset: 0x1EEC260 VA: 0x181EEDC60 Slot: 8
	public AsyncOperationHandle get_PreloadOperation() { }

	// RVA: 0x1EED5C0 Offset: 0x1EEBBC0 VA: 0x181EED5C0 Slot: 5
	public Locale GetLocale(LocaleIdentifier id) { }

	// RVA: 0x1EED8D0 Offset: 0x1EEBED0 VA: 0x181EED8D0
	public Locale GetLocale(string code) { }

	// RVA: 0x1EED910 Offset: 0x1EEBF10 VA: 0x181EED910
	public Locale GetLocale(SystemLanguage systemLanguage) { }

	// RVA: 0x1EED0F0 Offset: 0x1EEB6F0 VA: 0x181EED0F0 Slot: 6
	public void AddLocale(Locale locale) { }

	// RVA: 0x1EED950 Offset: 0x1EEBF50 VA: 0x181EED950 Slot: 7
	public bool RemoveLocale(Locale locale) { }

	// RVA: 0x1EED4A0 Offset: 0x1EEBAA0 VA: 0x181EED4A0
	public Locale FindFallbackLocale(LocaleIdentifier localeIdentifier) { }

	// RVA: 0x1EEDA20 Offset: 0x1EEC020 VA: 0x181EEDA20 Slot: 9
	public void ResetState() { }

	// RVA: 0x1EED420 Offset: 0x1EEBA20 VA: 0x181EED420 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1EEDA90 Offset: 0x1EEC090 VA: 0x181EEDA90 Slot: 10
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1EEDB40 Offset: 0x1EEC140 VA: 0x181EEDB40
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Settings
public class LocalizationSettings : ScriptableObject, IReset, IDisposable // TypeDefIndex: 11968
{
	// Fields
	internal const string ConfigName = "com.unity.localization.settings";
	internal const string ConfigEditorLocale = "com.unity.localization-edit-locale";
	internal const string IgnoreSettings = "IgnoreSettings";
	internal const string LocaleLabel = "Locale";
	internal const string PreloadLabel = "Preload";
	[SerializeReference]
	private List<IStartupLocaleSelector> m_StartupSelectors; // 0x18
	[SerializeReference]
	private ILocalesProvider m_AvailableLocales; // 0x20
	[SerializeReference]
	private LocalizedAssetDatabase m_AssetDatabase; // 0x28
	[SerializeReference]
	private LocalizedStringDatabase m_StringDatabase; // 0x30
	[MetadataType(256)]
	[SerializeField]
	private MetadataCollection m_Metadata; // 0x38
	[SerializeField]
	internal LocaleIdentifier m_ProjectLocaleIdentifier; // 0x40
	[SerializeField]
	private PreloadBehavior m_PreloadBehavior; // 0x50
	[SerializeField]
	private bool m_InitializeSynchronously; // 0x54
	internal AsyncOperationHandle<LocalizationSettings> m_InitializingOperationHandle; // 0x58
	private AsyncOperationHandle<Locale> m_SelectedLocaleAsync; // 0x78
	private Locale m_ProjectLocale; // 0x98
	private CallbackArray<Action<Locale>> m_SelectedLocaleChanged; // 0xA0
	private static LocalizationSettings s_Instance; // 0x0

	// Properties
	internal bool HasSelectedLocaleChangedSubscribers { get; }
	public static bool HasSettings { get; }
	public static AsyncOperationHandle<LocalizationSettings> InitializationOperation { get; }
	public static LocalizationSettings Instance { get; set; }
	public static List<IStartupLocaleSelector> StartupLocaleSelectors { get; }
	public static ILocalesProvider AvailableLocales { get; set; }
	public static LocalizedAssetDatabase AssetDatabase { get; set; }
	public static LocalizedStringDatabase StringDatabase { get; set; }
	public static MetadataCollection Metadata { get; }
	public static Locale SelectedLocale { get; set; }
	public static AsyncOperationHandle<Locale> SelectedLocaleAsync { get; }
	public static Locale ProjectLocale { get; set; }
	public static bool InitializeSynchronously { get; set; }
	public static PreloadBehavior PreloadBehavior { get; set; }
	internal bool IsPlayingOrWillChangePlaymode { get; }
	internal bool IsPlaying { get; }
	internal virtual RuntimePlatform Platform { get; }

	// Methods

	// RVA: 0x1EEFE90 Offset: 0x1EEE490 VA: 0x181EEFE90
	internal bool get_HasSelectedLocaleChangedSubscribers() { }

	// RVA: 0x1EEFD40 Offset: 0x1EEE340 VA: 0x181EEFD40
	public void add_OnSelectedLocaleChanged(Action<Locale> value) { }

	// RVA: 0x1EF0500 Offset: 0x1EEEB00 VA: 0x181EF0500
	public void remove_OnSelectedLocaleChanged(Action<Locale> value) { }

	// RVA: 0x1EEFED0 Offset: 0x1EEE4D0 VA: 0x181EEFED0
	public static bool get_HasSettings() { }

	// RVA: 0x1EEFFC0 Offset: 0x1EEE5C0 VA: 0x181EEFFC0
	public static AsyncOperationHandle<LocalizationSettings> get_InitializationOperation() { }

	// RVA: 0x1EF0030 Offset: 0x1EEE630 VA: 0x181EF0030
	public static LocalizationSettings get_Instance() { }

	// RVA: 0x1EF0640 Offset: 0x1EEEC40 VA: 0x181EF0640
	public static void set_Instance(LocalizationSettings value) { }

	// RVA: 0x1EF04A0 Offset: 0x1EEEAA0 VA: 0x181EF04A0
	public static List<IStartupLocaleSelector> get_StartupLocaleSelectors() { }

	// RVA: 0x1EEFE50 Offset: 0x1EEE450 VA: 0x181EEFE50
	public static ILocalesProvider get_AvailableLocales() { }

	// RVA: 0x1EF05E0 Offset: 0x1EEEBE0 VA: 0x181EF05E0
	public static void set_AvailableLocales(ILocalesProvider value) { }

	// RVA: 0x1EEFE10 Offset: 0x1EEE410 VA: 0x181EEFE10
	public static LocalizedAssetDatabase get_AssetDatabase() { }

	// RVA: 0x1EF05B0 Offset: 0x1EEEBB0 VA: 0x181EF05B0
	public static void set_AssetDatabase(LocalizedAssetDatabase value) { }

	// RVA: 0x1EF04C0 Offset: 0x1EEEAC0 VA: 0x181EF04C0
	public static LocalizedStringDatabase get_StringDatabase() { }

	// RVA: 0x1EF0960 Offset: 0x1EEEF60 VA: 0x181EF0960
	public static void set_StringDatabase(LocalizedStringDatabase value) { }

	// RVA: 0x1EF0190 Offset: 0x1EEE790 VA: 0x181EF0190
	public static MetadataCollection get_Metadata() { }

	// RVA: 0x1EF0460 Offset: 0x1EEEA60 VA: 0x181EF0460
	public static Locale get_SelectedLocale() { }

	// RVA: 0x1EF0780 Offset: 0x1EEED80 VA: 0x181EF0780
	public static void set_SelectedLocale(Locale value) { }

	// RVA: 0x1EF0410 Offset: 0x1EEEA10 VA: 0x181EF0410
	public static AsyncOperationHandle<Locale> get_SelectedLocaleAsync() { }

	// RVA: 0x1EEFDA0 Offset: 0x1EEE3A0 VA: 0x181EEFDA0
	public static void add_SelectedLocaleChanged(Action<Locale> value) { }

	// RVA: 0x1EF0550 Offset: 0x1EEEB50 VA: 0x181EF0550
	public static void remove_SelectedLocaleChanged(Action<Locale> value) { }

	// RVA: 0x1EF0210 Offset: 0x1EEE810 VA: 0x181EF0210
	public static Locale get_ProjectLocale() { }

	// RVA: 0x1EF06D0 Offset: 0x1EEECD0 VA: 0x181EF06D0
	public static void set_ProjectLocale(Locale value) { }

	// RVA: 0x1EF0010 Offset: 0x1EEE610 VA: 0x181EF0010
	public static bool get_InitializeSynchronously() { }

	// RVA: 0x1EF0610 Offset: 0x1EEEC10 VA: 0x181EF0610
	public static void set_InitializeSynchronously(bool value) { }

	// RVA: 0x1EF01F0 Offset: 0x1EEE7F0 VA: 0x181EF01F0
	public static PreloadBehavior get_PreloadBehavior() { }

	// RVA: 0x1EF06A0 Offset: 0x1EEECA0 VA: 0x181EF06A0
	public static void set_PreloadBehavior(PreloadBehavior value) { }

	// RVA: 0x1EEE660 Offset: 0x1EECC60 VA: 0x181EEE660
	private void OnEnable() { }

	// RVA: 0x1EEF6E0 Offset: 0x1EEDCE0 VA: 0x181EEF6E0
	internal static void ValidateSettingsExist(string error = "") { }

	// RVA: 0x1EEDDC0 Offset: 0x1EEC3C0 VA: 0x181EEDDC0 Slot: 6
	public virtual AsyncOperationHandle<LocalizationSettings> GetInitializationOperation() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	internal bool get_IsPlayingOrWillChangePlaymode() { }

	// RVA: 0x1EF0150 Offset: 0x1EEE750 VA: 0x181EF0150
	internal bool get_IsPlaying() { }

	// RVA: 0x1EF01B0 Offset: 0x1EEE7B0 VA: 0x181EF01B0 Slot: 7
	internal virtual RuntimePlatform get_Platform() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public List<IStartupLocaleSelector> GetStartupLocaleSelectors() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void SetAvailableLocales(ILocalesProvider available) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 8
	public virtual ILocalesProvider GetAvailableLocales() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void SetAssetDatabase(LocalizedAssetDatabase database) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 9
	public virtual LocalizedAssetDatabase GetAssetDatabase() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void SetStringDatabase(LocalizedStringDatabase database) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 10
	public virtual LocalizedStringDatabase GetStringDatabase() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public MetadataCollection GetMetadata() { }

	// RVA: 0x1EEF060 Offset: 0x1EED660 VA: 0x181EEF060
	internal void SendLocaleChangedEvents(Locale locale) { }

	[IteratorStateMachine(typeof(LocalizationSettings.<InitializeAndCallSelectedLocaleChangedCoroutine>d__78))]
	// RVA: 0x1EEE450 Offset: 0x1EECA50 VA: 0x181EEE450
	private IEnumerator InitializeAndCallSelectedLocaleChangedCoroutine(Locale locale) { }

	// RVA: 0x1EEE4E0 Offset: 0x1EECAE0 VA: 0x181EEE4E0
	private void InvokeSelectedLocaleChanged(Locale locale) { }

	// RVA: 0x1EEE880 Offset: 0x1EECE80 VA: 0x181EEE880
	private Locale SelectActiveLocale() { }

	// RVA: 0x1EEE960 Offset: 0x1EECF60 VA: 0x181EEE960 Slot: 11
	protected internal virtual Locale SelectLocaleUsingStartupSelectors() { }

	// RVA: 0x1EEF280 Offset: 0x1EED880 VA: 0x181EEF280
	public void SetSelectedLocale(Locale locale) { }

	// RVA: 0x1EEE150 Offset: 0x1EEC750 VA: 0x181EEE150 Slot: 12
	public virtual AsyncOperationHandle<Locale> GetSelectedLocaleAsync() { }

	// RVA: 0x1EEE390 Offset: 0x1EEC990 VA: 0x181EEE390 Slot: 13
	public virtual Locale GetSelectedLocale() { }

	// RVA: 0x1EEE700 Offset: 0x1EECD00 VA: 0x181EEE700 Slot: 14
	public virtual void OnLocaleRemoved(Locale locale) { }

	// RVA: 0x1EEE7E0 Offset: 0x1EECDE0 VA: 0x181EEE7E0 Slot: 4
	public void ResetState() { }

	// RVA: 0x1EEF450 Offset: 0x1EEDA50 VA: 0x181EEF450 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1EEE020 Offset: 0x1EEC620 VA: 0x181EEE020
	public static LocalizationSettings GetInstanceDontCreateDefault() { }

	// RVA: 0x1EEE0A0 Offset: 0x1EEC6A0 VA: 0x181EEE0A0
	private static LocalizationSettings GetOrCreateSettings() { }

	// RVA: 0x1EEF840 Offset: 0x1EEDE40 VA: 0x181EEF840
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1EEF640 Offset: 0x1EEDC40 VA: 0x181EEF640
	private AsyncOperationHandle<Locale> <GetSelectedLocaleAsync>b__83_0(AsyncOperationHandle op) { }
}

// Namespace: UnityEngine.Localization.Settings
public enum PreloadBehavior // TypeDefIndex: 11969
{
	// Fields
	public int value__; // 0x0
	public const PreloadBehavior NoPreloading = 0;
	public const PreloadBehavior PreloadSelectedLocale = 1;
	public const PreloadBehavior PreloadSelectedLocaleAndFallbacks = 2;
	public const PreloadBehavior PreloadAllLocales = 3;
}

// Namespace: UnityEngine.Localization.Settings
[Serializable]
public class CommandLineLocaleSelector : IStartupLocaleSelector // TypeDefIndex: 11970
{
	// Fields
	[SerializeField]
	private string m_CommandLineArgument; // 0x10

	// Properties
	public string CommandLineArgument { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_CommandLineArgument() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_CommandLineArgument(string value) { }

	// RVA: 0x1EE6410 Offset: 0x1EE4A10 VA: 0x181EE6410 Slot: 4
	public Locale GetStartupLocale(ILocalesProvider availableLocales) { }

	// RVA: 0x1EE6700 Offset: 0x1EE4D00 VA: 0x181EE6700
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Settings
[Serializable]
public class PlayerPrefLocaleSelector : IStartupLocaleSelector, IInitialize // TypeDefIndex: 11971
{
	// Fields
	[SerializeField]
	private string m_PlayerPreferenceKey; // 0x10

	// Properties
	public string PlayerPreferenceKey { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_PlayerPreferenceKey() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_PlayerPreferenceKey(string value) { }

	// RVA: 0x1EF7B00 Offset: 0x1EF6100 VA: 0x181EF7B00 Slot: 5
	public void PostInitialization(LocalizationSettings settings) { }

	// RVA: 0x1EF79E0 Offset: 0x1EF5FE0 VA: 0x181EF79E0 Slot: 4
	public Locale GetStartupLocale(ILocalesProvider availableLocales) { }

	// RVA: 0x1EF7BB0 Offset: 0x1EF61B0 VA: 0x181EF7BB0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Settings
[Serializable]
public class SpecificLocaleSelector : IStartupLocaleSelector // TypeDefIndex: 11972
{
	// Fields
	[SerializeField]
	private LocaleIdentifier m_LocaleId; // 0x10

	// Properties
	public LocaleIdentifier LocaleId { get; set; }

	// Methods

	// RVA: 0xA67320 Offset: 0xA65920 VA: 0x180A67320
	public LocaleIdentifier get_LocaleId() { }

	// RVA: 0xBD1880 Offset: 0xBCFE80 VA: 0x180BD1880
	public void set_LocaleId(LocaleIdentifier value) { }

	// RVA: 0x1EF96E0 Offset: 0x1EF7CE0 VA: 0x181EF96E0 Slot: 4
	public Locale GetStartupLocale(ILocalesProvider availableLocales) { }

	// RVA: 0x1EF97B0 Offset: 0x1EF7DB0 VA: 0x181EF97B0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.Settings
[Serializable]
public class SystemLocaleSelector : IStartupLocaleSelector // TypeDefIndex: 11973
{
	// Methods

	// RVA: 0x1EFA940 Offset: 0x1EF8F40 VA: 0x181EFA940 Slot: 4
	public Locale GetStartupLocale(ILocalesProvider availableLocales) { }

	// RVA: 0x1EFA590 Offset: 0x1EF8B90 VA: 0x181EFA590
	private static Locale FindLocaleOrFallback(LocaleIdentifier localeIdentifier, ILocalesProvider availableLocales) { }

	// RVA: 0x1EFAA40 Offset: 0x1EF9040 VA: 0x181EFAA40 Slot: 5
	protected virtual CultureInfo GetSystemCulture() { }

	// RVA: 0x1EFA900 Offset: 0x1EF8F00 VA: 0x181EFA900 Slot: 6
	protected virtual SystemLanguage GetApplicationSystemLanguage() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

