// Namespace: UnityEngine.AddressableAssets
public class ResourceLocatorInfo // TypeDefIndex: 13078
{
	// Fields
	[CompilerGenerated]
	private IResourceLocator <Locator>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <LocalHash>k__BackingField; // 0x18
	[CompilerGenerated]
	private IResourceLocation <CatalogLocation>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <ContentUpdateAvailable>k__BackingField; // 0x28

	// Properties
	public IResourceLocator Locator { get; set; }
	public string LocalHash { get; set; }
	public IResourceLocation CatalogLocation { get; set; }
	internal bool ContentUpdateAvailable { get; set; }
	public IResourceLocation HashLocation { get; }
	public bool CanUpdateContent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public IResourceLocator get_Locator() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_Locator(IResourceLocator value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_LocalHash() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_LocalHash(string value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public IResourceLocation get_CatalogLocation() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_CatalogLocation(IResourceLocation value) { }

	[CompilerGenerated]
	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	internal bool get_ContentUpdateAvailable() { }

	[CompilerGenerated]
	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	internal void set_ContentUpdateAvailable(bool value) { }

	// RVA: 0xA68FD0 Offset: 0xA675D0 VA: 0x180A68FD0
	public void .ctor(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x1EC06C0 Offset: 0x1EBECC0 VA: 0x181EC06C0
	public IResourceLocation get_HashLocation() { }

	// RVA: 0x1EC0610 Offset: 0x1EBEC10 VA: 0x181EC0610
	public bool get_CanUpdateContent() { }

	// RVA: 0x1EC05B0 Offset: 0x1EBEBB0 VA: 0x181EC05B0
	internal void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc) { }
}

// Namespace: UnityEngine.AddressableAssets
public class InvalidKeyException : Exception // TypeDefIndex: 13079
{
	// Fields
	[CompilerGenerated]
	private object <Key>k__BackingField; // 0x90
	[CompilerGenerated]
	private Type <Type>k__BackingField; // 0x98
	[CompilerGenerated]
	private readonly Nullable<Addressables.MergeMode> <MergeMode>k__BackingField; // 0xA0
	private AddressablesImpl m_Addressables; // 0xA8
	private const string BaseInvalidKeyMessageFormat = "{0}, Key={1}, Type={2}";

	// Properties
	public object Key { get; set; }
	public Type Type { get; set; }
	public Nullable<Addressables.MergeMode> MergeMode { get; }
	public override string Message { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public object get_Key() { }

	[CompilerGenerated]
	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	private void set_Key(object value) { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	private void set_Type(Type value) { }

	[CompilerGenerated]
	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public Nullable<Addressables.MergeMode> get_MergeMode() { }

	// RVA: 0x1EBD910 Offset: 0x1EBBF10 VA: 0x181EBD910
	public void .ctor(object key) { }

	// RVA: 0x1EBDC60 Offset: 0x1EBC260 VA: 0x181EBDC60
	public void .ctor(object key, Type type) { }

	// RVA: 0x1EBDCF0 Offset: 0x1EBC2F0 VA: 0x181EBDCF0
	internal void .ctor(object key, Type type, AddressablesImpl addr) { }

	// RVA: 0x1EBDB40 Offset: 0x1EBC140 VA: 0x181EBDB40
	public void .ctor(object key, Type type, Addressables.MergeMode mergeMode) { }

	// RVA: 0x1EBDA50 Offset: 0x1EBC050 VA: 0x181EBDA50
	internal void .ctor(object key, Type type, Addressables.MergeMode mergeMode, AddressablesImpl addr) { }

	// RVA: 0x1EBDC10 Offset: 0x1EBC210 VA: 0x181EBDC10
	public void .ctor() { }

	// RVA: 0x1EBDDB0 Offset: 0x1EBC3B0 VA: 0x181EBDDB0
	public void .ctor(string message) { }

	// RVA: 0x1EBD8A0 Offset: 0x1EBBEA0 VA: 0x181EBD8A0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1EBD9D0 Offset: 0x1EBBFD0 VA: 0x181EBD9D0
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x1EBDE10 Offset: 0x1EBC410 VA: 0x181EBDE10 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1EBBA20 Offset: 0x1EBA020 VA: 0x181EBBA20
	private string GetMessageForSingleKey(string keyString) { }

	// RVA: 0x1EBCF20 Offset: 0x1EBB520 VA: 0x181EBCF20
	private string GetNotFoundMessage(string keyString) { }

	// RVA: 0x1EBCF80 Offset: 0x1EBB580 VA: 0x181EBCF80
	private string GetTypeNotAssignableMessage(string keyString, HashSet<Type> typesAvailableForKey) { }

	// RVA: 0x1EBCBE0 Offset: 0x1EBB1E0 VA: 0x181EBCBE0
	private string GetMultipleAssignableTypesMessage(string keyString, HashSet<Type> typesAvailableForKey) { }

	// RVA: 0x1EBBAE0 Offset: 0x1EBA0E0 VA: 0x181EBBAE0
	private string GetMessageforMergeKeys(List<string> keys) { }

	// RVA: 0x1EBD4D0 Offset: 0x1EBBAD0 VA: 0x181EBD4D0
	private HashSet<Type> GetTypesForKey(string keyString) { }

	// RVA: 0x1EBD2A0 Offset: 0x1EBB8A0 VA: 0x181EBD2A0
	private bool GetTypeToKeys(string key, Dictionary<Type, List<string>> typeToKeys) { }

	// RVA: 0x1EBB770 Offset: 0x1EB9D70 VA: 0x181EBB770
	private string GetCSVString(IEnumerable<string> enumerator, string prefixSingle, string prefixPlural) { }
}

// Namespace: UnityEngine.AddressableAssets
public static class Addressables // TypeDefIndex: 13081
{
	// Fields
	internal static bool reinitializeAddressables; // 0x0
	internal static AddressablesImpl m_AddressablesInstance; // 0x8
	public const string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath";
	private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";
	public const string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog";
	public static string LibraryPath; // 0x10
	public static string BuildReportPath; // 0x18

	// Properties
	private static AddressablesImpl m_Addressables { get; }
	public static ResourceManager ResourceManager { get; }
	internal static AddressablesImpl Instance { get; }
	public static IInstanceProvider InstanceProvider { get; }
	public static Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public static Action<UnityWebRequest> WebRequestOverride { get; set; }
	public static string StreamingAssetsSubFolder { get; }
	public static string BuildPath { get; }
	public static string PlayerBuildDataPath { get; }
	public static string RuntimePath { get; }
	public static IEnumerable<IResourceLocator> ResourceLocators { get; }
	[Obsolete]
	public static AsyncOperationHandle<IResourceLocator> InitializationOperation { get; }

	// Methods

	// RVA: 0x1EAF520 Offset: 0x1EADB20 VA: 0x181EAF520
	private static AddressablesImpl get_m_Addressables() { }

	// RVA: 0x1EAF2B0 Offset: 0x1EAD8B0 VA: 0x181EAF2B0
	public static ResourceManager get_ResourceManager() { }

	// RVA: 0x1EAF060 Offset: 0x1EAD660 VA: 0x181EAF060
	internal static AddressablesImpl get_Instance() { }

	// RVA: 0x1EAEFD0 Offset: 0x1EAD5D0 VA: 0x181EAEFD0
	public static IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x1EAE030 Offset: 0x1EAC630 VA: 0x181EAE030
	public static string ResolveInternalId(string id) { }

	// RVA: 0x1EAF0F0 Offset: 0x1EAD6F0 VA: 0x181EAF0F0
	public static Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x1EAF570 Offset: 0x1EADB70 VA: 0x181EAF570
	public static void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x1EAF480 Offset: 0x1EADA80 VA: 0x181EAF480
	public static Action<UnityWebRequest> get_WebRequestOverride() { }

	// RVA: 0x1EAF620 Offset: 0x1EADC20 VA: 0x181EAF620
	public static void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x1EAF3D0 Offset: 0x1EAD9D0 VA: 0x181EAF3D0
	public static string get_StreamingAssetsSubFolder() { }

	// RVA: 0x1EAEF40 Offset: 0x1EAD540 VA: 0x181EAEF40
	public static string get_BuildPath() { }

	// RVA: 0x1EAF190 Offset: 0x1EAD790 VA: 0x181EAF190
	public static string get_PlayerBuildDataPath() { }

	// RVA: 0x1EAF340 Offset: 0x1EAD940 VA: 0x181EAF340
	public static string get_RuntimePath() { }

	// RVA: 0x1EAF220 Offset: 0x1EAD820 VA: 0x181EAF220
	public static IEnumerable<IResourceLocator> get_ResourceLocators() { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x1EAC5A0 Offset: 0x1EAABA0 VA: 0x181EAC5A0
	internal static void InternalSafeSerializationLog(string msg, LogType logType = 3) { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x1EAC450 Offset: 0x1EAAA50 VA: 0x181EAC450
	internal static void InternalSafeSerializationLogFormat(string format, LogType logType = 3, object[] args) { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x1EADAC0 Offset: 0x1EAC0C0 VA: 0x181EADAC0
	public static void Log(string msg) { }

	[Conditional("ADDRESSABLES_LOG_ALL")]
	// RVA: 0x1EAD830 Offset: 0x1EABE30 VA: 0x181EAD830
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x1EAD9F0 Offset: 0x1EABFF0 VA: 0x181EAD9F0
	public static void LogWarning(string msg) { }

	// RVA: 0x1EAD910 Offset: 0x1EABF10 VA: 0x181EAD910
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x1EAD5B0 Offset: 0x1EABBB0 VA: 0x181EAD5B0
	public static void LogError(string msg) { }

	// RVA: 0x1EAD710 Offset: 0x1EABD10 VA: 0x181EAD710
	public static void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x1EAD680 Offset: 0x1EABC80 VA: 0x181EAD680
	public static void LogException(Exception ex) { }

	// RVA: 0x1EAD4D0 Offset: 0x1EABAD0 VA: 0x181EAD4D0
	public static void LogErrorFormat(string format, object[] args) { }

	[Obsolete]
	// RVA: 0x1EAB4F0 Offset: 0x1EA9AF0 VA: 0x181EAB4F0
	public static AsyncOperationHandle<IResourceLocator> Initialize() { }

	// RVA: 0x1EAB3D0 Offset: 0x1EA99D0 VA: 0x181EAB3D0
	public static AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	// RVA: 0x1EAB2B0 Offset: 0x1EA98B0 VA: 0x181EAB2B0
	public static AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle) { }

	[Obsolete]
	// RVA: 0x1EAC8A0 Offset: 0x1EAAEA0 VA: 0x181EAC8A0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(string catalogPath, string providerSuffix) { }

	// RVA: 0x1EAC6D0 Offset: 0x1EAACD0 VA: 0x181EAC6D0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix) { }

	// RVA: 0x1EAC7B0 Offset: 0x1EAADB0 VA: 0x181EAC7B0
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix) { }

	// RVA: 0xC284D0 Offset: 0xC26AD0 VA: 0x180C284D0
	public static AsyncOperationHandle<IResourceLocator> get_InitializationOperation() { }

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAsset<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601DC0 Offset: 0x6003C0 VA: 0x180601DC0
	|-Addressables.LoadAsset<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAsset<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601DC0 Offset: 0x6003C0 VA: 0x180601DC0
	|-Addressables.LoadAsset<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601C00 Offset: 0x600200 VA: 0x180601C00
	|-Addressables.LoadAssetAsync<object>
	|
	|-RVA: 0x601B20 Offset: 0x600120 VA: 0x180601B20
	|-Addressables.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601CE0 Offset: 0x6002E0 VA: 0x180601CE0
	|-Addressables.LoadAssetAsync<object>
	|
	|-RVA: 0x601B20 Offset: 0x600120 VA: 0x180601B20
	|-Addressables.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: 0x1EACC70 Offset: 0x1EAB270 VA: 0x181EACC70
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	[Obsolete]
	// RVA: 0x1EACA90 Offset: 0x1EAB090 VA: 0x181EACA90
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<object> keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x1EACB80 Offset: 0x1EAB180 VA: 0x181EACB80
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	[Obsolete]
	// RVA: 0x1EACD90 Offset: 0x1EAB390 VA: 0x181EACD90
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(object key, Type type) { }

	// RVA: 0x1EAC9B0 Offset: 0x1EAAFB0 VA: 0x181EAC9B0
	public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602420 Offset: 0x600A20 VA: 0x180602420
	|-Addressables.LoadAssets<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602180 Offset: 0x600780 VA: 0x180602180
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E50 Offset: 0x600450 VA: 0x180601E50
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602360 Offset: 0x600960 VA: 0x180602360
	|-Addressables.LoadAssets<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602070 Offset: 0x600670 VA: 0x180602070
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602070 Offset: 0x600670 VA: 0x180602070
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601F60 Offset: 0x600560 VA: 0x180601F60
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601F60 Offset: 0x600560 VA: 0x180601F60
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602420 Offset: 0x600A20 VA: 0x180602420
	|-Addressables.LoadAssets<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602270 Offset: 0x600870 VA: 0x180602270
	|-Addressables.LoadAssetsAsync<object>
	|
	|-RVA: 0x602180 Offset: 0x600780 VA: 0x180602180
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601E50 Offset: 0x600450 VA: 0x180601E50
	|-Addressables.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6024C0 Offset: 0x600AC0 VA: 0x1806024C0
	|-Addressables.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602610 Offset: 0x600C10 VA: 0x180602610
	|-Addressables.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EADED0 Offset: 0x1EAC4D0 VA: 0x181EADED0
	public static void Release(AsyncOperationHandle handle) { }

	// RVA: 0x1EADB90 Offset: 0x1EAC190 VA: 0x181EADB90
	public static bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x1EADD50 Offset: 0x1EAC350 VA: 0x181EADD50
	public static bool ReleaseInstance(AsyncOperationHandle handle) { }

	// RVA: 0x1EADE10 Offset: 0x1EAC410 VA: 0x181EADE10
	public static bool ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

	[Obsolete]
	// RVA: 0x1EAAFB0 Offset: 0x1EA95B0 VA: 0x181EAAFB0
	public static AsyncOperationHandle<long> GetDownloadSize(object key) { }

	// RVA: 0x1EAAE50 Offset: 0x1EA9450 VA: 0x181EAAE50
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	// RVA: 0x1EAAB70 Offset: 0x1EA9170 VA: 0x181EAAB70
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(string key) { }

	[Obsolete]
	// RVA: 0x1EAAD90 Offset: 0x1EA9390 VA: 0x181EAAD90
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(IList<object> keys) { }

	// RVA: 0x1EAACD0 Offset: 0x1EA92D0 VA: 0x181EAACD0
	public static AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys) { }

	[Obsolete]
	// RVA: 0x1EAAA70 Offset: 0x1EA9070 VA: 0x181EAAA70
	public static AsyncOperationHandle DownloadDependencies(object key) { }

	// RVA: 0x1EAA990 Offset: 0x1EA8F90 VA: 0x181EAA990
	public static AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x1EAA7C0 Offset: 0x1EA8DC0 VA: 0x181EAA7C0
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	[Obsolete]
	// RVA: 0x1EAA8A0 Offset: 0x1EA8EA0 VA: 0x181EAA8A0
	public static AsyncOperationHandle DownloadDependenciesAsync(IList<object> keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x1EAA6D0 Offset: 0x1EA8CD0 VA: 0x181EAA6D0
	public static AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x1EAA3E0 Offset: 0x1EA89E0 VA: 0x181EAA3E0
	public static void ClearDependencyCacheAsync(object key) { }

	// RVA: 0x1EAA330 Offset: 0x1EA8930 VA: 0x181EAA330
	public static void ClearDependencyCacheAsync(IList<IResourceLocation> locations) { }

	[Obsolete]
	// RVA: 0x1EAA540 Offset: 0x1EA8B40 VA: 0x181EAA540
	public static void ClearDependencyCacheAsync(IList<object> keys) { }

	// RVA: 0x1EAA490 Offset: 0x1EA8A90 VA: 0x181EAA490
	public static void ClearDependencyCacheAsync(IEnumerable keys) { }

	// RVA: 0x1EAA1A0 Offset: 0x1EA87A0 VA: 0x181EAA1A0
	public static void ClearDependencyCacheAsync(string key) { }

	// RVA: 0x1EAA0C0 Offset: 0x1EA86C0 VA: 0x181EAA0C0
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	// RVA: 0x1EA9E20 Offset: 0x1EA8420 VA: 0x181EA9E20
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	[Obsolete]
	// RVA: 0x1EAA250 Offset: 0x1EA8850 VA: 0x181EAA250
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<object> keys, bool autoReleaseHandle) { }

	// RVA: 0x1EA9F00 Offset: 0x1EA8500 VA: 0x181EA9F00
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	// RVA: 0x1EA9FE0 Offset: 0x1EA85E0 VA: 0x181EA9FE0
	public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle) { }

	// RVA: 0x1EAB210 Offset: 0x1EA9810 VA: 0x181EAB210
	public static ResourceLocatorInfo GetLocatorInfo(string locatorId) { }

	// RVA: 0x1EAB140 Offset: 0x1EA9740 VA: 0x181EAB140
	public static ResourceLocatorInfo GetLocatorInfo(IResourceLocator locator) { }

	[Obsolete]
	// RVA: 0x1EAC060 Offset: 0x1EAA660 VA: 0x181EAC060
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x1EAC2A0 Offset: 0x1EAA8A0 VA: 0x181EAC2A0
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x1EABFB0 Offset: 0x1EAA5B0 VA: 0x181EABFB0
	public static AsyncOperationHandle<GameObject> Instantiate(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x1EABEE0 Offset: 0x1EAA4E0 VA: 0x181EABEE0
	public static AsyncOperationHandle<GameObject> Instantiate(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x1EAC160 Offset: 0x1EAA760 VA: 0x181EAC160
	public static AsyncOperationHandle<GameObject> Instantiate(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x1EABE20 Offset: 0x1EAA420 VA: 0x181EABE20
	public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x1EAB940 Offset: 0x1EA9F40 VA: 0x181EAB940
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x1EAB640 Offset: 0x1EA9C40 VA: 0x181EAB640
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x1EABBB0 Offset: 0x1EAA1B0 VA: 0x181EABBB0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x1EAB7C0 Offset: 0x1EA9DC0 VA: 0x181EAB7C0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x1EABAA0 Offset: 0x1EAA0A0 VA: 0x181EABAA0
	public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x1EABD10 Offset: 0x1EAA310 VA: 0x181EABD10
	public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	[Obsolete]
	// RVA: 0x1EAD430 Offset: 0x1EABA30 VA: 0x181EAD430
	public static AsyncOperationHandle<SceneInstance> LoadScene(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	[Obsolete]
	// RVA: 0x1EAD2E0 Offset: 0x1EAB8E0 VA: 0x181EAD2E0
	public static AsyncOperationHandle<SceneInstance> LoadScene(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x1EACFA0 Offset: 0x1EAB5A0 VA: 0x181EACFA0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x1EAD1E0 Offset: 0x1EAB7E0 VA: 0x181EAD1E0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x1EAD0C0 Offset: 0x1EAB6C0 VA: 0x181EAD0C0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x1EACEA0 Offset: 0x1EAB4A0 VA: 0x181EACEA0
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100) { }

	[Obsolete]
	// RVA: 0x1EAE6C0 Offset: 0x1EACCC0 VA: 0x181EAE6C0
	public static AsyncOperationHandle<SceneInstance> UnloadScene(SceneInstance scene, bool autoReleaseHandle = True) { }

	[Obsolete]
	// RVA: 0x1EAE7E0 Offset: 0x1EACDE0 VA: 0x181EAE7E0
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	[Obsolete]
	// RVA: 0x1EAE5A0 Offset: 0x1EACBA0 VA: 0x181EAE5A0
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	[Obsolete]
	// RVA: 0x1EAE900 Offset: 0x1EACF00 VA: 0x181EAE900
	public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = True) { }

	// RVA: 0x1EAE4A0 Offset: 0x1EACAA0 VA: 0x181EAE4A0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = True) { }

	// RVA: 0x1EAE1C0 Offset: 0x1EAC7C0 VA: 0x181EAE1C0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = True) { }

	// RVA: 0x1EAE2C0 Offset: 0x1EAC8C0 VA: 0x181EAE2C0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = True) { }

	// RVA: 0x1EAE3B0 Offset: 0x1EAC9B0 VA: 0x181EAE3B0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = True) { }

	// RVA: 0x1EAE0D0 Offset: 0x1EAC6D0 VA: 0x181EAE0D0
	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = True) { }

	// RVA: 0x1EA9C90 Offset: 0x1EA8290 VA: 0x181EA9C90
	public static AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x1EAEA70 Offset: 0x1EAD070 VA: 0x181EAEA70
	public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogs, bool autoReleaseHandle = True) { }

	// RVA: 0x1EAEB50 Offset: 0x1EAD150 VA: 0x181EAEB50
	public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(bool autoCleanBundleCache, IEnumerable<string> catalogs, bool autoReleaseHandle = True) { }

	// RVA: 0x1EA9BD0 Offset: 0x1EA81D0 VA: 0x181EA9BD0
	public static void AddResourceLocator(IResourceLocator locator, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x1EADF90 Offset: 0x1EAC590 VA: 0x181EADF90
	public static void RemoveResourceLocator(IResourceLocator locator) { }

	// RVA: 0x1EAA5F0 Offset: 0x1EA8BF0 VA: 0x181EAA5F0
	public static void ClearResourceLocators() { }

	// RVA: 0x1EA9D50 Offset: 0x1EA8350 VA: 0x181EA9D50
	public static AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogsIds) { }

	// RVA: -1 Offset: -1
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601A60 Offset: 0x600060 VA: 0x180601A60
	|-Addressables.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation remoteCatalogLocation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601A60 Offset: 0x600060 VA: 0x180601A60
	|-Addressables.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath, string remoteHashPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601990 Offset: 0x5FFF90 VA: 0x180601990
	|-Addressables.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EAEC40 Offset: 0x1EAD240 VA: 0x181EAEC40
	private static void .cctor() { }
}

// Namespace: UnityEngine.AddressableAssets
internal class AddressablesImpl : IEqualityComparer<IResourceLocation> // TypeDefIndex: 13114
{
	// Fields
	private ResourceManager m_ResourceManager; // 0x10
	private IInstanceProvider m_InstanceProvider; // 0x18
	private int m_CatalogRequestsTimeout; // 0x20
	internal const string kCacheDataFolder = "{UnityEngine.Application.persistentDataPath}/com.unity.addressables/";
	public ISceneProvider SceneProvider; // 0x28
	internal List<ResourceLocatorInfo> m_ResourceLocators; // 0x30
	private AsyncOperationHandle<IResourceLocator> m_InitializationOperation; // 0x38
	private AsyncOperationHandle<List<string>> m_ActiveCheckUpdateOperation; // 0x58
	internal AsyncOperationHandle<List<IResourceLocator>> m_ActiveUpdateOperation; // 0x78
	private Action<AsyncOperationHandle> m_OnHandleCompleteAction; // 0x98
	private Action<AsyncOperationHandle> m_OnSceneHandleCompleteAction; // 0xA0
	private Action<AsyncOperationHandle> m_OnHandleDestroyedAction; // 0xA8
	private Dictionary<object, AsyncOperationHandle> m_resultToHandle; // 0xB0
	internal HashSet<AsyncOperationHandle> m_SceneInstances; // 0xB8
	private AsyncOperationHandle<bool> m_ActiveCleanBundleCacheOperation; // 0xC0
	internal bool hasStartedInitialization; // 0xE0

	// Properties
	public IInstanceProvider InstanceProvider { get; set; }
	public ResourceManager ResourceManager { get; }
	public int CatalogRequestsTimeout { get; set; }
	internal int SceneOperationCount { get; }
	internal int TrackedHandleCount { get; }
	public Func<IResourceLocation, string> InternalIdTransformFunc { get; set; }
	public Action<UnityWebRequest> WebRequestOverride { get; set; }
	public AsyncOperationHandle ChainOperation { get; }
	internal bool ShouldChainRequest { get; }
	public string StreamingAssetsSubFolder { get; }
	public string BuildPath { get; }
	public string PlayerBuildDataPath { get; }
	public string RuntimePath { get; }
	public IEnumerable<IResourceLocator> ResourceLocators { get; }
	internal IEnumerable<string> CatalogsWithAvailableUpdates { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public IInstanceProvider get_InstanceProvider() { }

	// RVA: 0x1EA8DA0 Offset: 0x1EA73A0 VA: 0x181EA8DA0
	public void set_InstanceProvider(IInstanceProvider value) { }

	// RVA: 0x1EA8B50 Offset: 0x1EA7150 VA: 0x181EA8B50
	public ResourceManager get_ResourceManager() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_CatalogRequestsTimeout() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_CatalogRequestsTimeout(int value) { }

	// RVA: 0x1EA8C00 Offset: 0x1EA7200 VA: 0x181EA8C00
	internal int get_SceneOperationCount() { }

	// RVA: 0x1EA8D30 Offset: 0x1EA7330 VA: 0x181EA8D30
	internal int get_TrackedHandleCount() { }

	// RVA: 0x1EA8180 Offset: 0x1EA6780 VA: 0x181EA8180
	public void .ctor(IAllocationStrategy alloc) { }

	// RVA: 0x1EA7280 Offset: 0x1EA5880 VA: 0x181EA7280
	internal void ReleaseSceneManagerOperation() { }

	// RVA: 0x1EA8980 Offset: 0x1EA6F80 VA: 0x181EA8980
	public Func<IResourceLocation, string> get_InternalIdTransformFunc() { }

	// RVA: 0x1EA8E20 Offset: 0x1EA7420 VA: 0x181EA8E20
	public void set_InternalIdTransformFunc(Func<IResourceLocation, string> value) { }

	// RVA: 0x1EA8D80 Offset: 0x1EA7380 VA: 0x181EA8D80
	public Action<UnityWebRequest> get_WebRequestOverride() { }

	// RVA: 0x1EA8E50 Offset: 0x1EA7450 VA: 0x181EA8E50
	public void set_WebRequestOverride(Action<UnityWebRequest> value) { }

	// RVA: 0x1EA8780 Offset: 0x1EA6D80 VA: 0x181EA8780
	public AsyncOperationHandle get_ChainOperation() { }

	// RVA: 0x1EA8C40 Offset: 0x1EA7240 VA: 0x181EA8C40
	internal bool get_ShouldChainRequest() { }

	// RVA: 0x1EA6D90 Offset: 0x1EA5390 VA: 0x181EA6D90
	internal void OnSceneUnloaded(Scene scene) { }

	// RVA: 0x1EA8D00 Offset: 0x1EA7300 VA: 0x181EA8D00
	public string get_StreamingAssetsSubFolder() { }

	// RVA: 0x1EA8340 Offset: 0x1EA6940 VA: 0x181EA8340
	public string get_BuildPath() { }

	// RVA: 0x1EA89A0 Offset: 0x1EA6FA0 VA: 0x181EA89A0
	public string get_PlayerBuildDataPath() { }

	// RVA: 0x1EA8BF0 Offset: 0x1EA71F0 VA: 0x181EA8BF0
	public string get_RuntimePath() { }

	// RVA: 0x1EA6AA0 Offset: 0x1EA50A0 VA: 0x181EA6AA0
	public void Log(string msg) { }

	// RVA: 0x1EA6990 Offset: 0x1EA4F90 VA: 0x181EA6990
	public void LogFormat(string format, object[] args) { }

	// RVA: 0x1EA6A50 Offset: 0x1EA5050 VA: 0x181EA6A50
	public void LogWarning(string msg) { }

	// RVA: 0x1EA69F0 Offset: 0x1EA4FF0 VA: 0x181EA69F0
	public void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x1EA68B0 Offset: 0x1EA4EB0 VA: 0x181EA68B0
	public void LogError(string msg) { }

	// RVA: 0x1EA6900 Offset: 0x1EA4F00 VA: 0x181EA6900
	public void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void LogException(Exception ex) { }

	// RVA: 0x1EA6850 Offset: 0x1EA4E50 VA: 0x181EA6850
	public void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x1EA7430 Offset: 0x1EA5A30 VA: 0x181EA7430
	public string ResolveInternalId(string id) { }

	// RVA: 0x1EA8A30 Offset: 0x1EA7030 VA: 0x181EA8A30
	public IEnumerable<IResourceLocator> get_ResourceLocators() { }

	// RVA: 0x1E9DF80 Offset: 0x1E9C580 VA: 0x181E9DF80
	public void AddResourceLocator(IResourceLocator loc, string localCatalogHash, IResourceLocation remoteCatalogLocation) { }

	// RVA: 0x1EA7350 Offset: 0x1EA5950 VA: 0x181EA7350
	public void RemoveResourceLocator(IResourceLocator loc) { }

	// RVA: 0x1EA02B0 Offset: 0x1E9E8B0 VA: 0x181EA02B0
	public void ClearResourceLocators() { }

	// RVA: 0x1EA3350 Offset: 0x1EA1950 VA: 0x181EA3350
	internal bool GetResourceLocations(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x1EA3870 Offset: 0x1EA1E70 VA: 0x181EA3870
	internal bool GetResourceLocations(IEnumerable keys, Type type, Addressables.MergeMode merge, out IList<IResourceLocation> locations) { }

	// RVA: 0x1EA3D80 Offset: 0x1EA2380 VA: 0x181EA3D80
	public AsyncOperationHandle<IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix, bool autoReleaseHandle = True) { }

	// RVA: 0x1EA3C30 Offset: 0x1EA2230 VA: 0x181EA3C30
	public AsyncOperationHandle<IResourceLocator> InitializeAsync() { }

	// RVA: 0x1EA3CD0 Offset: 0x1EA22D0 VA: 0x181EA3CD0
	public AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle) { }

	// RVA: -1 Offset: -1
	public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation catalogLocation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x600320 Offset: 0x5FE920 VA: 0x180600320
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogLocation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6003A0 Offset: 0x5FE9A0 VA: 0x1806003A0
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<object>
	|
	|-RVA: 0x5FFE60 Offset: 0x5FE460 VA: 0x1805FFE60
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogPath, string hashFilePath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FFF00 Offset: 0x5FE500 VA: 0x1805FFF00
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<object>
	|-AddressablesImpl.CreateCatalogLocationWithHashDependencies<__Il2CppFullySharedGenericType>
	*/

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void QueueEditorUpdateIfNeeded() { }

	// RVA: 0x1EA53E0 Offset: 0x1EA39E0 VA: 0x181EA53E0
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle = True, string providerSuffix) { }

	// RVA: 0x1EA75D0 Offset: 0x1EA5BD0 VA: 0x181EA75D0
	private AsyncOperationHandle<SceneInstance> TrackHandle(AsyncOperationHandle<SceneInstance> handle) { }

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> TrackHandle<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67DAA0 Offset: 0x67C0A0 VA: 0x18067DAA0
	|-AddressablesImpl.TrackHandle<long>
	|-AddressablesImpl.TrackHandle<object>
	|
	|-RVA: 0x67DA30 Offset: 0x67C030 VA: 0x18067DA30
	|-AddressablesImpl.TrackHandle<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EA7590 Offset: 0x1EA5B90 VA: 0x181EA7590
	private AsyncOperationHandle TrackHandle(AsyncOperationHandle handle) { }

	// RVA: 0x1EA0310 Offset: 0x1E9E910 VA: 0x181EA0310
	internal void ClearTrackHandles() { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601470 Offset: 0x5FFA70 VA: 0x180601470
	|-AddressablesImpl.LoadAssetAsync<object>
	|
	|-RVA: 0x600430 Offset: 0x5FEA30 VA: 0x180600430
	|-AddressablesImpl.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, IResourceLocation loc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601680 Offset: 0x5FFC80 VA: 0x180601680
	|-AddressablesImpl.LoadAssetWithChain<object>
	|
	|-RVA: 0x67B7F0 Offset: 0x679DF0 VA: 0x18067B7F0
	|-AddressablesImpl.LoadAssetWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(AsyncOperationHandle dep, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601680 Offset: 0x5FFC80 VA: 0x180601680
	|-AddressablesImpl.LoadAssetWithChain<object>
	|
	|-RVA: 0x67B7F0 Offset: 0x679DF0 VA: 0x18067B7F0
	|-AddressablesImpl.LoadAssetWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x600CC0 Offset: 0x5FF2C0 VA: 0x180600CC0
	|-AddressablesImpl.LoadAssetAsync<object>
	|
	|-RVA: 0x600560 Offset: 0x5FEB60 VA: 0x180600560
	|-AddressablesImpl.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EA5D10 Offset: 0x1EA4310 VA: 0x181EA5D10
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x1EA5620 Offset: 0x1EA3C20 VA: 0x181EA5620
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, Addressables.MergeMode mode, Type type) { }

	// RVA: 0x1EA5BB0 Offset: 0x1EA41B0 VA: 0x181EA5BB0
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsWithChain(AsyncOperationHandle dep, object key, Type type) { }

	// RVA: 0x1EA58F0 Offset: 0x1EA3EF0 VA: 0x181EA58F0
	public AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type) { }

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67C320 Offset: 0x67A920 VA: 0x18067C320
	|-AddressablesImpl.LoadAssetsAsync<object>
	|
	|-RVA: 0x67B950 Offset: 0x679F50 VA: 0x18067B950
	|-AddressablesImpl.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67C880 Offset: 0x67AE80 VA: 0x18067C880
	|-AddressablesImpl.LoadAssetsWithChain<object>
	|
	|-RVA: 0x67C580 Offset: 0x67AB80 VA: 0x18067C580
	|-AddressablesImpl.LoadAssetsWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67C700 Offset: 0x67AD00 VA: 0x18067C700
	|-AddressablesImpl.LoadAssetsWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, Addressables.MergeMode mode, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67BAB0 Offset: 0x67A0B0 VA: 0x18067BAB0
	|-AddressablesImpl.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private AsyncOperationHandle<IList<TObject>> LoadAssetsWithChain<TObject>(AsyncOperationHandle dep, object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67C880 Offset: 0x67AE80 VA: 0x18067C880
	|-AddressablesImpl.LoadAssetsWithChain<object>
	|
	|-RVA: 0x67C580 Offset: 0x67AB80 VA: 0x18067C580
	|-AddressablesImpl.LoadAssetsWithChain<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67BFD0 Offset: 0x67A5D0 VA: 0x18067BFD0
	|-AddressablesImpl.LoadAssetsAsync<object>
	|
	|-RVA: 0x67BD50 Offset: 0x67A350 VA: 0x18067BD50
	|-AddressablesImpl.LoadAssetsAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EA6BE0 Offset: 0x1EA51E0 VA: 0x181EA6BE0
	private void OnHandleDestroyed(AsyncOperationHandle handle) { }

	// RVA: 0x1EA6C60 Offset: 0x1EA5260 VA: 0x181EA6C60
	private void OnSceneHandleCompleted(AsyncOperationHandle handle) { }

	// RVA: 0x1EA6AF0 Offset: 0x1EA50F0 VA: 0x181EA6AF0
	private void OnHandleCompleted(AsyncOperationHandle handle) { }

	// RVA: -1 Offset: -1
	public void Release<TObject>(TObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67D170 Offset: 0x67B770 VA: 0x18067D170
	|-AddressablesImpl.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Release<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67C9F0 Offset: 0x67AFF0 VA: 0x18067C9F0
	|-AddressablesImpl.Release<bool>
	|
	|-RVA: 0x67D310 Offset: 0x67B910 VA: 0x18067D310
	|-AddressablesImpl.Release<object>
	|
	|-RVA: 0x67D690 Offset: 0x67BC90 VA: 0x18067D690
	|-AddressablesImpl.Release<SceneInstance>
	|
	|-RVA: 0x67CD70 Offset: 0x67B370 VA: 0x18067CD70
	|-AddressablesImpl.Release<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EA7310 Offset: 0x1EA5910 VA: 0x181EA7310
	public void Release(AsyncOperationHandle handle) { }

	// RVA: 0x1EA2B70 Offset: 0x1EA1170 VA: 0x181EA2B70
	private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, object key) { }

	// RVA: 0x1EA0360 Offset: 0x1E9E960 VA: 0x181EA0360
	private AsyncOperationHandle<long> ComputeCatalogSizeWithChain(IResourceLocation catalogLoc) { }

	// RVA: 0x1EA5230 Offset: 0x1EA3830 VA: 0x181EA5230
	internal bool IsCatalogCached(IResourceLocation catalogLoc, Hash128 remoteHash) { }

	// RVA: 0x1EA3040 Offset: 0x1EA1640 VA: 0x181EA3040
	internal AsyncOperationHandle<long> GetRemoteCatalogHeaderSize(IResourceLocation catalogLoc) { }

	// RVA: 0x1EA2CC0 Offset: 0x1EA12C0 VA: 0x181EA2CC0
	private AsyncOperationHandle<long> GetDownloadSizeWithChain(AsyncOperationHandle dep, IEnumerable keys) { }

	// RVA: 0x1EA1EC0 Offset: 0x1EA04C0 VA: 0x181EA1EC0
	public AsyncOperationHandle<long> GetDownloadSizeAsync(object key) { }

	// RVA: 0x1EA1FA0 Offset: 0x1EA05A0 VA: 0x181EA1FA0
	public AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys) { }

	// RVA: 0x1EA0C50 Offset: 0x1E9F250 VA: 0x181EA0C50
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, object key, bool autoReleaseHandle) { }

	// RVA: 0x1EA80B0 Offset: 0x1EA66B0 VA: 0x181EA80B0
	internal static void WrapAsDownloadLocations(List<IResourceLocation> locations) { }

	// RVA: 0x1EA1AB0 Offset: 0x1EA00B0 VA: 0x181EA1AB0
	private static List<IResourceLocation> GatherDependenciesFromLocations(IList<IResourceLocation> locations) { }

	// RVA: 0x1EA10F0 Offset: 0x1E9F6F0 VA: 0x181EA10F0
	public AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = False) { }

	// RVA: 0x1EA0A80 Offset: 0x1E9F080 VA: 0x181EA0A80
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	// RVA: 0x1EA0E20 Offset: 0x1E9F420 VA: 0x181EA0E20
	public AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = False) { }

	// RVA: 0x1EA08A0 Offset: 0x1E9EEA0 VA: 0x181EA08A0
	private AsyncOperationHandle DownloadDependenciesAsyncWithChain(AsyncOperationHandle dep, IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle) { }

	// RVA: 0x1EA1490 Offset: 0x1E9FA90 VA: 0x181EA1490
	public AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, Addressables.MergeMode mode, bool autoReleaseHandle = False) { }

	// RVA: 0x1E9FCF0 Offset: 0x1E9E2F0 VA: 0x181E9FCF0
	internal bool ClearDependencyCacheForKey(object key) { }

	// RVA: 0x1E9E0A0 Offset: 0x1E9C6A0 VA: 0x181E9E0A0
	internal void AutoReleaseHandleOnCompletion(AsyncOperationHandle handle) { }

	// RVA: -1 Offset: -1
	internal void AutoReleaseHandleOnCompletion<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FF8F0 Offset: 0x5FDEF0 VA: 0x1805FF8F0
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<bool>
	|
	|-RVA: 0x5FFB20 Offset: 0x5FE120 VA: 0x1805FFB20
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<object>
	|
	|-RVA: 0x5FFBB0 Offset: 0x5FE1B0 VA: 0x1805FFBB0
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<SceneInstance>
	|
	|-RVA: 0x5FF980 Offset: 0x5FDF80 VA: 0x1805FF980
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void AutoReleaseHandleOnCompletion<TObject>(AsyncOperationHandle<TObject> handle, bool unloadSceneOpExcludeReleaseCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FFC40 Offset: 0x5FE240 VA: 0x1805FFC40
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<SceneInstance>
	|
	|-RVA: 0x5FFA20 Offset: 0x5FE020 VA: 0x1805FFA20
	|-AddressablesImpl.AutoReleaseHandleOnCompletion<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void AutoReleaseHandleOnTypelessCompletion<TObject>(AsyncOperationHandle<TObject> handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FFDD0 Offset: 0x5FE3D0 VA: 0x1805FFDD0
	|-AddressablesImpl.AutoReleaseHandleOnTypelessCompletion<object>
	|
	|-RVA: 0x5FFD40 Offset: 0x5FE340 VA: 0x1805FFD40
	|-AddressablesImpl.AutoReleaseHandleOnTypelessCompletion<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E9FAB0 Offset: 0x1E9E0B0 VA: 0x181E9FAB0
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle) { }

	// RVA: 0x1E9F210 Offset: 0x1E9D810 VA: 0x181E9F210
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle) { }

	// RVA: 0x1E9F630 Offset: 0x1E9DC30 VA: 0x181E9F630
	public AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle) { }

	// RVA: 0x1EA4D10 Offset: 0x1EA3310 VA: 0x181EA4D10
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x1EA4200 Offset: 0x1EA2800 VA: 0x181EA4200
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x1EA45B0 Offset: 0x1EA2BB0 VA: 0x181EA45B0
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent, bool instantiateInWorldSpace = False, bool trackHandle = True) { }

	// RVA: 0x1EA4680 Offset: 0x1EA2C80 VA: 0x181EA4680
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent, bool trackHandle = True) { }

	// RVA: 0x1EA4DE0 Offset: 0x1EA33E0 VA: 0x181EA4DE0
	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x1EA4770 Offset: 0x1EA2D70 VA: 0x181EA4770
	public AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x1EA4F90 Offset: 0x1EA3590 VA: 0x181EA4F90
	private AsyncOperationHandle<GameObject> InstantiateWithChain(AsyncOperationHandle dep, IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x1EA42F0 Offset: 0x1EA28F0 VA: 0x181EA42F0
	public AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = True) { }

	// RVA: 0x1EA7150 Offset: 0x1EA5750 VA: 0x181EA7150
	public bool ReleaseInstance(GameObject instance) { }

	// RVA: 0x1EA6660 Offset: 0x1EA4C60 VA: 0x181EA6660
	internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x1EA6470 Offset: 0x1EA4A70 VA: 0x181EA6470
	internal AsyncOperationHandle<SceneInstance> LoadSceneWithChain(AsyncOperationHandle dep, IResourceLocation key, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x1EA5E80 Offset: 0x1EA4480 VA: 0x181EA5E80
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key) { }

	// RVA: 0x1EA60C0 Offset: 0x1EA46C0 VA: 0x181EA60C0
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x1EA63E0 Offset: 0x1EA49E0 VA: 0x181EA63E0
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location) { }

	// RVA: 0x1EA6340 Offset: 0x1EA4940 VA: 0x181EA6340
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x1EA5F10 Offset: 0x1EA4510 VA: 0x181EA5F10
	public AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = True, int priority = 100, bool trackHandle = True) { }

	// RVA: 0x1EA7990 Offset: 0x1EA5F90 VA: 0x181EA7990
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = True) { }

	// RVA: 0x1EA7850 Offset: 0x1EA5E50 VA: 0x181EA7850
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = True) { }

	// RVA: 0x1EA7BB0 Offset: 0x1EA61B0 VA: 0x181EA7BB0
	public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions = 0, bool autoReleaseHandle = True) { }

	// RVA: 0x1EA0760 Offset: 0x1E9ED60 VA: 0x181EA0760
	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	// RVA: 0x1EA0620 Offset: 0x1E9EC20 VA: 0x181EA0620
	internal AsyncOperationHandle<SceneInstance> CreateUnloadSceneWithChain(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	// RVA: 0x1EA5140 Offset: 0x1EA3740 VA: 0x181EA5140
	internal AsyncOperationHandle<SceneInstance> InternalUnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle) { }

	// RVA: 0x1EA1A20 Offset: 0x1EA0020 VA: 0x181EA1A20
	private object EvaluateKey(object obj) { }

	// RVA: 0x1E9E280 Offset: 0x1E9C880 VA: 0x181E9E280
	internal AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = True) { }

	// RVA: 0x1E9E120 Offset: 0x1E9C720 VA: 0x181E9E120
	internal AsyncOperationHandle<List<string>> CheckForCatalogUpdatesWithChain(bool autoReleaseHandle) { }

	// RVA: 0x1EA2EC0 Offset: 0x1EA14C0 VA: 0x181EA2EC0
	public ResourceLocatorInfo GetLocatorInfo(string c) { }

	// RVA: 0x1EA8590 Offset: 0x1EA6B90 VA: 0x181EA8590
	internal IEnumerable<string> get_CatalogsWithAvailableUpdates() { }

	// RVA: 0x1EA7DF0 Offset: 0x1EA63F0 VA: 0x181EA7DF0
	internal AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogIds, bool autoReleaseHandle = True, bool autoCleanBundleCache = False) { }

	// RVA: 0x1EA18E0 Offset: 0x1E9FEE0 VA: 0x181EA18E0 Slot: 4
	public bool Equals(IResourceLocation x, IResourceLocation y) { }

	// RVA: 0x1EA2E10 Offset: 0x1EA1410 VA: 0x181EA2E10 Slot: 5
	public int GetHashCode(IResourceLocation loc) { }

	// RVA: 0x1E9E830 Offset: 0x1E9CE30 VA: 0x181E9E830
	internal AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogIds, bool forceSingleThreading) { }

	// RVA: 0x1E9EDE0 Offset: 0x1E9D3E0 VA: 0x181E9EDE0
	internal AsyncOperationHandle<bool> CleanBundleCache(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool forceSingleThreading) { }

	// RVA: 0x1E9E6B0 Offset: 0x1E9CCB0 VA: 0x181E9E6B0
	internal AsyncOperationHandle<bool> CleanBundleCacheWithChain(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool forceSingleThreading) { }

	// RVA: 0x1E9E540 Offset: 0x1E9CB40 VA: 0x181E9E540
	internal AsyncOperationHandle<bool> CleanBundleCacheWithChain(IEnumerable<string> catalogIds, bool forceSingleThreading) { }

	[CompilerGenerated]
	// RVA: 0x1EA77B0 Offset: 0x1EA5DB0 VA: 0x181EA77B0
	private void <TrackHandle>b__73_0(AsyncOperationHandle<SceneInstance> sceneHandle) { }

	[CompilerGenerated]
	// RVA: 0x1EA7680 Offset: 0x1EA5C80 VA: 0x181EA7680
	private AsyncOperationHandle<long> <GetRemoteCatalogHeaderSize>b__102_0(AsyncOperationHandle<UnityWebRequest> getOp) { }

	[CompilerGenerated]
	// RVA: 0x1EA7310 Offset: 0x1EA5910 VA: 0x181EA7310
	private void <AutoReleaseHandleOnCompletion>b__115_0(AsyncOperationHandle op) { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <AutoReleaseHandleOnCompletion>b__116_0<TObject>(AsyncOperationHandle<TObject> op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6017E0 Offset: 0x5FFDE0 VA: 0x1806017E0
	|-AddressablesImpl.<AutoReleaseHandleOnCompletion>b__116_0<bool>
	|
	|-RVA: 0x6018A0 Offset: 0x5FFEA0 VA: 0x1806018A0
	|-AddressablesImpl.<AutoReleaseHandleOnCompletion>b__116_0<object>
	|
	|-RVA: 0x601900 Offset: 0x5FFF00 VA: 0x180601900
	|-AddressablesImpl.<AutoReleaseHandleOnCompletion>b__116_0<SceneInstance>
	|
	|-RVA: 0x601840 Offset: 0x5FFE40 VA: 0x180601840
	|-AddressablesImpl.<AutoReleaseHandleOnCompletion>b__116_0<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <AutoReleaseHandleOnTypelessCompletion>b__118_0<TObject>(AsyncOperationHandle op) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x601960 Offset: 0x5FFF60 VA: 0x180601960
	|-AddressablesImpl.<AutoReleaseHandleOnTypelessCompletion>b__118_0<object>
	|-AddressablesImpl.<AutoReleaseHandleOnTypelessCompletion>b__118_0<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetLabelReference : IKeyEvaluator // TypeDefIndex: 13115
{
	// Fields
	[FormerlySerializedAs("m_labelString")]
	[SerializeField]
	private string m_LabelString; // 0x10

	// Properties
	public string labelString { get; set; }
	public object RuntimeKey { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_labelString() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_labelString(string value) { }

	// RVA: 0x1EAF740 Offset: 0x1EADD40 VA: 0x181EAF740 Slot: 4
	public object get_RuntimeKey() { }

	// RVA: 0x1EAF6D0 Offset: 0x1EADCD0 VA: 0x181EAF6D0 Slot: 5
	public bool RuntimeKeyIsValid() { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceT<TObject> : AssetReference // TypeDefIndex: 13116
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string guid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC3CE0 Offset: 0xBC22E0 VA: 0x180BC3CE0
	|-AssetReferenceT<object>..ctor
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAsset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC3C20 Offset: 0xBC2220 VA: 0x180BC3C20
	|-AssetReferenceT<object>.LoadAsset
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public virtual AsyncOperationHandle<TObject> LoadAssetAsync() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC3BB0 Offset: 0xBC21B0 VA: 0x180BC3BB0
	|-AssetReferenceT<object>.LoadAssetAsync
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public override bool ValidateAsset(Object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC3C60 Offset: 0xBC2260 VA: 0x180BC3C60
	|-AssetReferenceT<object>.ValidateAsset
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public override bool ValidateAsset(string mainAssetPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-AssetReferenceT<object>.ValidateAsset
	*/
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceGameObject : AssetReferenceT<GameObject> // TypeDefIndex: 13117
{
	// Methods

	// RVA: 0x1EAF860 Offset: 0x1EADE60 VA: 0x181EAF860
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceTexture : AssetReferenceT<Texture> // TypeDefIndex: 13118
{
	// Methods

	// RVA: 0x1EAF9A0 Offset: 0x1EADFA0 VA: 0x181EAF9A0
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceTexture2D : AssetReferenceT<Texture2D> // TypeDefIndex: 13119
{
	// Methods

	// RVA: 0x1EAF900 Offset: 0x1EADF00 VA: 0x181EAF900
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceTexture3D : AssetReferenceT<Texture3D> // TypeDefIndex: 13120
{
	// Methods

	// RVA: 0x1EAF950 Offset: 0x1EADF50 VA: 0x181EAF950
	public void .ctor(string guid) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceSprite : AssetReferenceT<Sprite> // TypeDefIndex: 13121
{
	// Methods

	// RVA: 0x1EAF8B0 Offset: 0x1EADEB0 VA: 0x181EAF8B0
	public void .ctor(string guid) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 21
	public override bool ValidateAsset(string path) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReferenceAtlasedSprite : AssetReferenceT<Sprite> // TypeDefIndex: 13122
{
	// Methods

	// RVA: 0x1EAF810 Offset: 0x1EADE10 VA: 0x181EAF810
	public void .ctor(string guid) { }

	// RVA: 0x1EAF790 Offset: 0x1EADD90 VA: 0x181EAF790 Slot: 20
	public override bool ValidateAsset(Object obj) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 21
	public override bool ValidateAsset(string path) { }
}

// Namespace: UnityEngine.AddressableAssets
[Serializable]
public class AssetReference : IKeyEvaluator // TypeDefIndex: 13123
{
	// Fields
	[FormerlySerializedAs("m_assetGUID")]
	[SerializeField]
	protected internal string m_AssetGUID; // 0x10
	[SerializeField]
	private string m_SubObjectName; // 0x18
	[SerializeField]
	private string m_SubObjectType; // 0x20
	private AsyncOperationHandle m_Operation; // 0x28

	// Properties
	public AsyncOperationHandle OperationHandle { get; set; }
	public virtual object RuntimeKey { get; }
	public virtual string AssetGUID { get; }
	public virtual string SubObjectName { get; set; }
	internal virtual Type SubOjbectType { get; }
	public bool IsDone { get; }
	public virtual Object Asset { get; }

	// Methods

	// RVA: 0x1116580 Offset: 0x1114B80 VA: 0x181116580
	public AsyncOperationHandle get_OperationHandle() { }

	// RVA: 0x11167B0 Offset: 0x1114DB0 VA: 0x1811167B0
	internal void set_OperationHandle(AsyncOperationHandle value) { }

	// RVA: 0x1EB0610 Offset: 0x1EAEC10 VA: 0x181EB0610 Slot: 6
	public virtual object get_RuntimeKey() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 7
	public virtual string get_AssetGUID() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 8
	public virtual string get_SubObjectName() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70 Slot: 9
	public virtual void set_SubObjectName(string value) { }

	// RVA: 0x1EB0690 Offset: 0x1EAEC90 VA: 0x181EB0690 Slot: 10
	internal virtual Type get_SubOjbectType() { }

	// RVA: 0x1EAFD80 Offset: 0x1EAE380 VA: 0x181EAFD80
	public bool IsValid() { }

	// RVA: 0x1EB0600 Offset: 0x1EAEC00 VA: 0x181EB0600
	public bool get_IsDone() { }

	// RVA: 0x1EB04A0 Offset: 0x1EAEAA0 VA: 0x181EB04A0
	public void .ctor() { }

	// RVA: 0x1EB04F0 Offset: 0x1EAEAF0 VA: 0x181EB04F0
	public void .ctor(string guid) { }

	// RVA: 0x1EB0560 Offset: 0x1EAEB60 VA: 0x181EB0560 Slot: 11
	public virtual Object get_Asset() { }

	// RVA: 0x1EB0320 Offset: 0x1EAE920 VA: 0x181EB0320 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static AsyncOperationHandle<T> CreateFailedOperation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65E790 Offset: 0x65CD90 VA: 0x18065E790
	|-AssetReference.CreateFailedOperation<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: -1 Offset: -1
	public AsyncOperationHandle<TObject> LoadAsset<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65EC00 Offset: 0x65D200 VA: 0x18065EC00
	|-AssetReference.LoadAsset<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: 0x1EAFF00 Offset: 0x1EAE500 VA: 0x181EAFF00
	public AsyncOperationHandle<SceneInstance> LoadScene() { }

	[Obsolete]
	// RVA: 0x1EAFD00 Offset: 0x1EAE300 VA: 0x181EAFD00
	public AsyncOperationHandle<GameObject> Instantiate(Vector3 position, Quaternion rotation, Transform parent) { }

	[Obsolete]
	// RVA: 0x1EAFCC0 Offset: 0x1EAE2C0 VA: 0x181EAFCC0
	public AsyncOperationHandle<GameObject> Instantiate(Transform parent, bool instantiateInWorldSpace = False) { }

	// RVA: -1 Offset: -1 Slot: 12
	public virtual AsyncOperationHandle<TObject> LoadAssetAsync<TObject>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65EAB0 Offset: 0x65D0B0 VA: 0x18065EAB0
	|-AssetReference.LoadAssetAsync<object>
	|
	|-RVA: 0x65E960 Offset: 0x65CF60 VA: 0x18065E960
	|-AssetReference.LoadAssetAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EAFD90 Offset: 0x1EAE390 VA: 0x181EAFD90 Slot: 13
	public virtual AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = 0, bool activateOnLoad = True, int priority = 100) { }

	// RVA: 0x1EB0370 Offset: 0x1EAE970 VA: 0x181EB0370 Slot: 14
	public virtual AsyncOperationHandle<SceneInstance> UnLoadScene() { }

	// RVA: 0x1EAFB10 Offset: 0x1EAE110 VA: 0x181EAFB10 Slot: 15
	public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x1EAFC00 Offset: 0x1EAE200 VA: 0x181EAFC00 Slot: 16
	public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Transform parent, bool instantiateInWorldSpace = False) { }

	// RVA: 0x1EB0290 Offset: 0x1EAE890 VA: 0x181EB0290 Slot: 17
	public virtual bool RuntimeKeyIsValid() { }

	// RVA: 0x1EAFF50 Offset: 0x1EAE550 VA: 0x181EAFF50 Slot: 18
	public virtual void ReleaseAsset() { }

	// RVA: 0x1EB00B0 Offset: 0x1EAE6B0 VA: 0x181EB00B0 Slot: 19
	public virtual void ReleaseInstance(GameObject obj) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 20
	public virtual bool ValidateAsset(Object obj) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 21
	public virtual bool ValidateAsset(string path) { }
}

// Namespace: UnityEngine.AddressableAssets
public interface IKeyEvaluator // TypeDefIndex: 13124
{
	// Properties
	public abstract object RuntimeKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_RuntimeKey();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool RuntimeKeyIsValid();
}

// Namespace: UnityEngine.AddressableAssets
internal class CheckCatalogsOperation : AsyncOperationBase<List<string>> // TypeDefIndex: 13126
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x98
	private List<string> m_LocalHashes; // 0xA0
	private List<ResourceLocatorInfo> m_LocatorInfos; // 0xA8
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xB0

	// Methods

	// RVA: 0x1EB2990 Offset: 0x1EB0F90 VA: 0x181EB2990
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x1EB2390 Offset: 0x1EB0990 VA: 0x181EB2390
	public AsyncOperationHandle<List<string>> Start(List<ResourceLocatorInfo> locatorInfos) { }

	// RVA: 0x1EB1D50 Offset: 0x1EB0350 VA: 0x181EB1D50 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x1EB1B10 Offset: 0x1EB0110 VA: 0x181EB1B10 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x1EB1C30 Offset: 0x1EB0230 VA: 0x181EB1C30 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x1EB1E80 Offset: 0x1EB0480 VA: 0x181EB1E80
	internal static List<string> ProcessDependentOpResults(IList<AsyncOperationHandle> results, List<ResourceLocatorInfo> locatorInfos, List<string> localHashes, out string errorString, out bool success) { }

	// RVA: 0x1EB1B80 Offset: 0x1EB0180 VA: 0x181EB1B80 Slot: 28
	protected override void Execute() { }
}

// Namespace: UnityEngine.AddressableAssets
internal class CleanBundleCacheOperation : AsyncOperationBase<bool>, IUpdateReceiver // TypeDefIndex: 13127
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x98
	private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xA0
	private List<string> m_CacheDirsForRemoval; // 0xC0
	private Thread m_EnumerationThread; // 0xC8
	private string m_BaseCachePath; // 0xD0
	private bool m_UseMultiThreading; // 0xD8

	// Methods

	// RVA: 0x1EB3B20 Offset: 0x1EB2120 VA: 0x181EB3B20
	public void .ctor(AddressablesImpl aa, bool forceSingleThreading) { }

	// RVA: 0x1EB3980 Offset: 0x1EB1F80 VA: 0x181EB3980
	public AsyncOperationHandle<bool> Start(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp) { }

	// RVA: 0x1EB29F0 Offset: 0x1EB0FF0 VA: 0x181EB29F0
	public void CompleteInternal(bool result, bool success, string errorMsg) { }

	// RVA: 0x1EB3720 Offset: 0x1EB1D20 VA: 0x181EB3720 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x1EB2A80 Offset: 0x1EB1080 VA: 0x181EB2A80 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x1EB3600 Offset: 0x1EB1C00 VA: 0x181EB3600 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x1EB2E10 Offset: 0x1EB1410 VA: 0x181EB2E10 Slot: 28
	protected override void Execute() { }

	// RVA: 0x1EB3AC0 Offset: 0x1EB20C0 VA: 0x181EB3AC0 Slot: 36
	private void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }

	// RVA: 0x1EB37E0 Offset: 0x1EB1DE0 VA: 0x181EB37E0
	private void RemoveCacheEntries() { }

	// RVA: 0x1EB2D90 Offset: 0x1EB1390 VA: 0x181EB2D90
	private void DetermineCacheDirsNotInUse(object data) { }

	// RVA: 0x1EB2AF0 Offset: 0x1EB10F0 VA: 0x181EB2AF0
	private void DetermineCacheDirsNotInUse(HashSet<string> cacheDirsInUse) { }

	// RVA: 0x1EB3000 Offset: 0x1EB1600 VA: 0x181EB3000
	private HashSet<string> GetCacheDirsInUse(IList<AsyncOperationHandle> catalogOps) { }
}

// Namespace: UnityEngine.AddressableAssets
internal class UpdateCatalogsOperation : AsyncOperationBase<List<IResourceLocator>> // TypeDefIndex: 13130
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x98
	private List<ResourceLocatorInfo> m_LocatorInfos; // 0xA0
	internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp; // 0xA8
	private AsyncOperationHandle<bool> m_CleanCacheOp; // 0xC8
	private bool m_AutoCleanBundleCache; // 0xE8

	// Methods

	// RVA: 0x1EC48F0 Offset: 0x1EC2EF0 VA: 0x181EC48F0
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x1EC42E0 Offset: 0x1EC28E0 VA: 0x181EC42E0
	public AsyncOperationHandle<List<IResourceLocator>> Start(IEnumerable<string> catalogIds, bool autoCleanBundleCache) { }

	// RVA: 0x1EC4040 Offset: 0x1EC2640 VA: 0x181EC4040 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x1EC3780 Offset: 0x1EC1D80 VA: 0x181EC3780 Slot: 29
	protected override void Destroy() { }

	// RVA: 0x1EC3F20 Offset: 0x1EC2520 VA: 0x181EC3F20 Slot: 32
	public override void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	// RVA: 0x1EC37F0 Offset: 0x1EC1DF0 VA: 0x181EC37F0 Slot: 28
	protected override void Execute() { }

	// RVA: 0x1EC41F0 Offset: 0x1EC27F0 VA: 0x181EC41F0
	private void OnCleanCacheCompleted(AsyncOperationHandle<bool> handle, List<IResourceLocator> catalogs) { }
}

// Namespace: UnityEngine.AddressableAssets
internal class DynamicResourceLocator : IResourceLocator // TypeDefIndex: 13131
{
	// Fields
	private AddressablesImpl m_Addressables; // 0x10
	private string m_AtlasSpriteProviderId; // 0x18

	// Properties
	public string LocatorId { get; }
	public virtual IEnumerable<object> Keys { get; }
	private string AtlasSpriteProviderId { get; }
	public IEnumerable<IResourceLocation> AllLocations { get; }

	// Methods

	// RVA: 0x1EB6920 Offset: 0x1EB4F20 VA: 0x181EB6920 Slot: 4
	public string get_LocatorId() { }

	// RVA: 0x1EB68E0 Offset: 0x1EB4EE0 VA: 0x181EB68E0 Slot: 7
	public virtual IEnumerable<object> get_Keys() { }

	// RVA: 0x1EB6690 Offset: 0x1EB4C90 VA: 0x181EB6690
	private string get_AtlasSpriteProviderId() { }

	// RVA: 0x1EB6650 Offset: 0x1EB4C50 VA: 0x181EB6650
	public IEnumerable<IResourceLocation> get_AllLocations() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(AddressablesImpl addr) { }

	// RVA: 0x1EB6300 Offset: 0x1EB4900 VA: 0x181EB6300 Slot: 6
	public bool Locate(object key, Type type, out IList<IResourceLocation> locations) { }

	// RVA: 0x1EB5F20 Offset: 0x1EB4520 VA: 0x181EB5F20
	internal void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc) { }
}

// Namespace: UnityEngine.AddressableAssets
public enum AddressablesPlatform // TypeDefIndex: 13132
{
	// Fields
	public int value__; // 0x0
	public const AddressablesPlatform Unknown = 0;
	public const AddressablesPlatform Windows = 1;
	public const AddressablesPlatform OSX = 2;
	public const AddressablesPlatform Linux = 3;
	public const AddressablesPlatform PS4 = 4;
	public const AddressablesPlatform Switch = 5;
	public const AddressablesPlatform XboxOne = 6;
	public const AddressablesPlatform WebGL = 7;
	public const AddressablesPlatform iOS = 8;
	public const AddressablesPlatform Android = 9;
	public const AddressablesPlatform WindowsUniversal = 10;
}

// Namespace: UnityEngine.AddressableAssets
public class PlatformMappingService // TypeDefIndex: 13133
{
	// Fields
	internal static readonly Dictionary<RuntimePlatform, AddressablesPlatform> s_RuntimeTargetMapping; // 0x0

	// Methods

	// RVA: 0x1EBEAD0 Offset: 0x1EBD0D0 VA: 0x181EBEAD0
	internal static AddressablesPlatform GetAddressablesPlatformInternal(RuntimePlatform platform) { }

	// RVA: 0x1EBEBA0 Offset: 0x1EBD1A0 VA: 0x181EBEBA0
	internal static string GetAddressablesPlatformPathInternal(RuntimePlatform platform) { }

	[Obsolete("This API doesn't adapt to the addition of new platforms.  Use GetPlatformPathSubFolder instead.")]
	// RVA: 0x1EBEE60 Offset: 0x1EBD460 VA: 0x181EBEE60
	public static AddressablesPlatform GetPlatform() { }

	// RVA: 0x1EBECE0 Offset: 0x1EBD2E0 VA: 0x181EBECE0
	public static string GetPlatformPathSubFolder() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1EBEF90 Offset: 0x1EBD590 VA: 0x181EBEF90
	private static void .cctor() { }
}

