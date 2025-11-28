// Namespace: UnityEngine.AddressableAssets.Initialization
public static class AddressablesRuntimeProperties // TypeDefIndex: 13151
{
	// Fields
	private static Stack<string> s_TokenStack; // 0x0
	private static Stack<int> s_TokenStartStack; // 0x8
	private static bool s_StaticStacksAreInUse; // 0x10
	private static Dictionary<string, string> s_CachedValues; // 0x18

	// Methods

	// RVA: 0x1EA9920 Offset: 0x1EA7F20 VA: 0x181EA9920
	private static Assembly[] GetAssemblies() { }

	// RVA: 0x1EA9950 Offset: 0x1EA7F50 VA: 0x181EA9950
	internal static int GetCachedValueCount() { }

	// RVA: 0x1EA99D0 Offset: 0x1EA7FD0 VA: 0x181EA99D0
	public static void SetPropertyValue(string name, string val) { }

	// RVA: 0x1EA8E80 Offset: 0x1EA7480 VA: 0x181EA8E80
	public static void ClearCachedPropertyValues() { }

	// RVA: 0x1EA8F00 Offset: 0x1EA7500 VA: 0x181EA8F00
	public static string EvaluateProperty(string name) { }

	// RVA: 0x1EA9330 Offset: 0x1EA7930 VA: 0x181EA9330
	public static string EvaluateString(string input) { }

	// RVA: 0x1EA93E0 Offset: 0x1EA79E0 VA: 0x181EA93E0
	public static string EvaluateString(string inputString, char startDelimiter, char endDelimiter, Func<string, string> varFunc) { }

	// RVA: 0x1EA9A60 Offset: 0x1EA8060 VA: 0x181EA9A60
	private static void .cctor() { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
[Serializable]
public class CacheInitialization : IInitializableObject // TypeDefIndex: 13154
{
	// Properties
	public static string RootPath { get; }

	// Methods

	// RVA: 0x1EB1960 Offset: 0x1EAFF60 VA: 0x181EB1960 Slot: 4
	public bool Initialize(string id, string dataStr) { }

	// RVA: 0x1EB17A0 Offset: 0x1EAFDA0 VA: 0x181EB17A0 Slot: 6
	public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data) { }

	// RVA: 0x1EB1AA0 Offset: 0x1EB00A0 VA: 0x181EB1AA0
	public static string get_RootPath() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
[Serializable]
public class CacheInitializationData // TypeDefIndex: 13155
{
	// Fields
	[FormerlySerializedAs("m_compressionEnabled")]
	[SerializeField]
	private bool m_CompressionEnabled; // 0x10
	[FormerlySerializedAs("m_cacheDirectoryOverride")]
	[SerializeField]
	private string m_CacheDirectoryOverride; // 0x18
	[FormerlySerializedAs("m_expirationDelay")]
	[SerializeField]
	private int m_ExpirationDelay; // 0x20
	[FormerlySerializedAs("m_limitCacheSize")]
	[SerializeField]
	private bool m_LimitCacheSize; // 0x24
	[FormerlySerializedAs("m_maximumCacheSize")]
	[SerializeField]
	private long m_MaximumCacheSize; // 0x28

	// Properties
	public bool CompressionEnabled { get; set; }
	public string CacheDirectoryOverride { get; set; }
	[Obsolete("Functionality remains unchanged.  However, due to issues with Caching this property is being marked obsolete.  See Caching API documentation for more details.")]
	public int ExpirationDelay { get; set; }
	public bool LimitCacheSize { get; set; }
	public long MaximumCacheSize { get; set; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_CompressionEnabled() { }

	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_CompressionEnabled(bool value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_CacheDirectoryOverride() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_CacheDirectoryOverride(string value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_ExpirationDelay() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_ExpirationDelay(int value) { }

	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	public bool get_LimitCacheSize() { }

	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	public void set_LimitCacheSize(bool value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public long get_MaximumCacheSize() { }

	// RVA: 0x1EB1790 Offset: 0x1EAFD90 VA: 0x181EB1790
	public void set_MaximumCacheSize(long value) { }

	// RVA: 0x1EB1720 Offset: 0x1EAFD20 VA: 0x181EB1720
	public void .ctor() { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
internal class InitializationOperation : AsyncOperationBase<IResourceLocator> // TypeDefIndex: 13159
{
	// Fields
	private AsyncOperationHandle<ResourceManagerRuntimeData> m_rtdOp; // 0x98
	private AsyncOperationHandle<IResourceLocator> m_loadCatalogOp; // 0xB8
	private string m_ProviderSuffix; // 0xD8
	private AddressablesImpl m_Addressables; // 0xE0
	private ResourceManagerDiagnostics m_Diagnostics; // 0xE8
	private InitalizationObjectsOperation m_InitGroupOps; // 0xF0

	// Properties
	protected override float Progress { get; }
	protected override string DebugName { get; }

	// Methods

	// RVA: 0x1EB9D20 Offset: 0x1EB8320 VA: 0x181EB9D20
	public void .ctor(AddressablesImpl aa) { }

	// RVA: 0x1EB9ED0 Offset: 0x1EB84D0 VA: 0x181EB9ED0 Slot: 30
	protected override float get_Progress() { }

	// RVA: 0x1EB9EA0 Offset: 0x1EB84A0 VA: 0x181EB9EA0 Slot: 31
	protected override string get_DebugName() { }

	// RVA: 0x1EB7530 Offset: 0x1EB5B30 VA: 0x181EB7530
	internal static AsyncOperationHandle<IResourceLocator> CreateInitializationOperation(AddressablesImpl aa, string playerSettingsLocation, string providerSuffix) { }

	// RVA: 0x1EB8760 Offset: 0x1EB6D60 VA: 0x181EB8760 Slot: 33
	protected override bool InvokeWaitForCompletion() { }

	// RVA: 0x1EB7BF0 Offset: 0x1EB61F0 VA: 0x181EB7BF0 Slot: 28
	protected override void Execute() { }

	// RVA: 0x1EB9470 Offset: 0x1EB7A70 VA: 0x181EB9470
	private static void LoadProvider(AddressablesImpl addressables, ObjectInitializationData providerData, string providerSuffix) { }

	// RVA: 0x1EB9780 Offset: 0x1EB7D80 VA: 0x181EB9780
	private static AsyncOperationHandle<IResourceLocator> OnCatalogDataLoaded(AddressablesImpl addressables, AsyncOperationHandle<ContentCatalogData> op, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x1EB8B60 Offset: 0x1EB7160 VA: 0x181EB8B60
	public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(AddressablesImpl addressables, IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x1EB8B10 Offset: 0x1EB7110 VA: 0x181EB8B10
	public AsyncOperationHandle<IResourceLocator> LoadContentCatalog(IResourceLocation loc, string providerSuffix, IResourceLocation remoteHashLocation) { }

	// RVA: 0x1EB8910 Offset: 0x1EB6F10 VA: 0x181EB8910
	internal AsyncOperationHandle<IResourceLocator> LoadContentCatalogInternal(IList<IResourceLocation> catalogs, int index, ResourceLocationMap locMap, IResourceLocation remoteHashLocation) { }

	// RVA: 0x1EB9110 Offset: 0x1EB7710 VA: 0x181EB9110
	private void LoadOpComplete(AsyncOperationHandle<IResourceLocator> op, IList<IResourceLocation> catalogs, ResourceLocationMap locMap, int index, IResourceLocation remoteHashLocation) { }
}

// Namespace: UnityEngine.AddressableAssets.Initialization
[Serializable]
public class ResourceManagerRuntimeData // TypeDefIndex: 13160
{
	// Fields
	public const string kCatalogAddress = "AddressablesMainContentCatalog";
	[SerializeField]
	private string m_buildTarget; // 0x10
	[FormerlySerializedAs("m_settingsHash")]
	[SerializeField]
	private string m_SettingsHash; // 0x18
	[FormerlySerializedAs("m_catalogLocations")]
	[SerializeField]
	private List<ResourceLocationData> m_CatalogLocations; // 0x20
	[FormerlySerializedAs("m_profileEvents")]
	[SerializeField]
	private bool m_ProfileEvents; // 0x28
	[FormerlySerializedAs("m_logResourceManagerExceptions")]
	[SerializeField]
	private bool m_LogResourceManagerExceptions; // 0x29
	[FormerlySerializedAs("m_extraInitializationData")]
	[SerializeField]
	private List<ObjectInitializationData> m_ExtraInitializationData; // 0x30
	[SerializeField]
	private bool m_DisableCatalogUpdateOnStart; // 0x38
	[SerializeField]
	private bool m_IsLocalCatalogInBundle; // 0x39
	[SerializeField]
	private SerializedType m_CertificateHandlerType; // 0x40
	[SerializeField]
	private string m_AddressablesVersion; // 0x60
	[SerializeField]
	private int m_maxConcurrentWebRequests; // 0x68
	[SerializeField]
	private int m_CatalogRequestsTimeout; // 0x6C

	// Properties
	public string BuildTarget { get; set; }
	public string SettingsHash { get; set; }
	public List<ResourceLocationData> CatalogLocations { get; }
	public bool ProfileEvents { get; set; }
	public bool LogResourceManagerExceptions { get; set; }
	public List<ObjectInitializationData> InitializationObjects { get; }
	public bool DisableCatalogUpdateOnStartup { get; set; }
	public bool IsLocalCatalogInBundle { get; set; }
	public Type CertificateHandlerType { get; set; }
	public string AddressablesVersion { get; set; }
	public int MaxConcurrentWebRequests { get; set; }
	public int CatalogRequestsTimeout { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_BuildTarget() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_BuildTarget(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_SettingsHash() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_SettingsHash(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<ResourceLocationData> get_CatalogLocations() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_ProfileEvents() { }

	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	public void set_ProfileEvents(bool value) { }

	// RVA: 0x179F980 Offset: 0x179DF80 VA: 0x18179F980
	public bool get_LogResourceManagerExceptions() { }

	// RVA: 0x1EC4A60 Offset: 0x1EC3060 VA: 0x181EC4A60
	public void set_LogResourceManagerExceptions(bool value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public List<ObjectInitializationData> get_InitializationObjects() { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_DisableCatalogUpdateOnStartup() { }

	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_DisableCatalogUpdateOnStartup(bool value) { }

	// RVA: 0xADABC0 Offset: 0xAD91C0 VA: 0x180ADABC0
	public bool get_IsLocalCatalogInBundle() { }

	// RVA: 0xADB1E0 Offset: 0xAD97E0 VA: 0x180ADB1E0
	public void set_IsLocalCatalogInBundle(bool value) { }

	// RVA: 0x1EC4A20 Offset: 0x1EC3020 VA: 0x181EC4A20
	public Type get_CertificateHandlerType() { }

	// RVA: 0x1EC4A50 Offset: 0x1EC3050 VA: 0x181EC4A50
	public void set_CertificateHandlerType(Type value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public string get_AddressablesVersion() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_AddressablesVersion(string value) { }

	// RVA: 0xC9D690 Offset: 0xC9BC90 VA: 0x180C9D690
	public int get_MaxConcurrentWebRequests() { }

	// RVA: 0x1EC4A70 Offset: 0x1EC3070 VA: 0x181EC4A70
	public void set_MaxConcurrentWebRequests(int value) { }

	// RVA: 0xC9D570 Offset: 0xC9BB70 VA: 0x180C9D570
	public int get_CatalogRequestsTimeout() { }

	// RVA: 0x1EC4A30 Offset: 0x1EC3030 VA: 0x181EC4A30
	public void set_CatalogRequestsTimeout(int value) { }

	// RVA: 0x1EC4950 Offset: 0x1EC2F50 VA: 0x181EC4950
	public void .ctor() { }
}

