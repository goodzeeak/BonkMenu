// Namespace: UnityEngine.ResourceManagement.ResourceProviders
internal class DownloadOnlyLocation : LocationWrapper // TypeDefIndex: 12686
{
	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(IResourceLocation location) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public enum AssetLoadMode // TypeDefIndex: 12687
{
	// Fields
	public int value__; // 0x0
	public const AssetLoadMode RequestedAssetAndDependencies = 0;
	public const AssetLoadMode AllPackedAssetsAndDependencies = 1;
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface IAssetBundleResource // TypeDefIndex: 12688
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AssetBundle GetAssetBundle();
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Serializable]
public class AssetBundleRequestOptions : ILocationSizeData // TypeDefIndex: 12689
{
	// Fields
	[FormerlySerializedAs("m_hash")]
	[SerializeField]
	private string m_Hash; // 0x10
	[FormerlySerializedAs("m_crc")]
	[SerializeField]
	private uint m_Crc; // 0x18
	[FormerlySerializedAs("m_timeout")]
	[SerializeField]
	private int m_Timeout; // 0x1C
	[FormerlySerializedAs("m_chunkedTransfer")]
	[SerializeField]
	private bool m_ChunkedTransfer; // 0x20
	[FormerlySerializedAs("m_redirectLimit")]
	[SerializeField]
	private int m_RedirectLimit; // 0x24
	[FormerlySerializedAs("m_retryCount")]
	[SerializeField]
	private int m_RetryCount; // 0x28
	[SerializeField]
	private string m_BundleName; // 0x30
	[SerializeField]
	private AssetLoadMode m_AssetLoadMode; // 0x38
	[SerializeField]
	private long m_BundleSize; // 0x40
	[SerializeField]
	private bool m_UseCrcForCachedBundles; // 0x48
	[SerializeField]
	private bool m_UseUWRForLocalBundles; // 0x49
	[SerializeField]
	private bool m_ClearOtherCachedVersionsWhenLoaded; // 0x4A

	// Properties
	public string Hash { get; set; }
	public uint Crc { get; set; }
	public int Timeout { get; set; }
	public bool ChunkedTransfer { get; set; }
	public int RedirectLimit { get; set; }
	public int RetryCount { get; set; }
	public string BundleName { get; set; }
	public AssetLoadMode AssetLoadMode { get; set; }
	public long BundleSize { get; set; }
	public bool UseCrcForCachedBundle { get; set; }
	public bool UseUnityWebRequestForLocalBundles { get; set; }
	public bool ClearOtherCachedVersionsWhenLoaded { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Hash() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Hash(string value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public uint get_Crc() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_Crc(uint value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_Timeout() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_Timeout(int value) { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_ChunkedTransfer() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_ChunkedTransfer(bool value) { }

	// RVA: 0x2115580 Offset: 0x2113B80 VA: 0x182115580
	public int get_RedirectLimit() { }

	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	public void set_RedirectLimit(int value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_RetryCount() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_RetryCount(int value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_BundleName() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_BundleName(string value) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public AssetLoadMode get_AssetLoadMode() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_AssetLoadMode(AssetLoadMode value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public long get_BundleSize() { }

	// RVA: 0xAC52C0 Offset: 0xAC38C0 VA: 0x180AC52C0
	public void set_BundleSize(long value) { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	public bool get_UseCrcForCachedBundle() { }

	// RVA: 0x132E3F0 Offset: 0x132C9F0 VA: 0x18132E3F0
	public void set_UseCrcForCachedBundle(bool value) { }

	// RVA: 0x16EE300 Offset: 0x16EC900 VA: 0x1816EE300
	public bool get_UseUnityWebRequestForLocalBundles() { }

	// RVA: 0x16EE310 Offset: 0x16EC910 VA: 0x1816EE310
	public void set_UseUnityWebRequestForLocalBundles(bool value) { }

	// RVA: 0x16EE320 Offset: 0x16EC920 VA: 0x1816EE320
	public bool get_ClearOtherCachedVersionsWhenLoaded() { }

	// RVA: 0x16EE330 Offset: 0x16EC930 VA: 0x1816EE330
	public void set_ClearOtherCachedVersionsWhenLoaded(bool value) { }

	// RVA: 0x2115380 Offset: 0x2113980 VA: 0x182115380 Slot: 5
	public virtual long ComputeSize(IResourceLocation location, ResourceManager resourceManager) { }

	// RVA: 0x2115520 Offset: 0x2113B20 VA: 0x182115520
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class AssetBundleResource : IAssetBundleResource, IUpdateReceiver // TypeDefIndex: 12691
{
	// Fields
	private AssetBundle m_AssetBundle; // 0x10
	private AsyncOperation m_RequestOperation; // 0x18
	internal WebRequestQueueOperation m_WebRequestQueueOperation; // 0x20
	internal ProvideHandle m_ProvideHandle; // 0x28
	internal AssetBundleRequestOptions m_Options; // 0x40
	private bool m_RequestCompletedCallbackCalled; // 0x48
	private int m_Retries; // 0x4C
	private BundleSource m_Source; // 0x50
	private long m_BytesToDownload; // 0x58
	private long m_DownloadedBytes; // 0x60
	private bool m_Completed; // 0x68
	private AssetBundleUnloadOperation m_UnloadOperation; // 0x70
	private const int k_WaitForWebRequestMainThreadSleep = 1;
	private string m_TransformedInternalId; // 0x78
	private AssetBundleRequest m_PreloadRequest; // 0x80
	private bool m_PreloadCompleted; // 0x88
	private ulong m_LastDownloadedByteCount; // 0x90
	private float m_TimeoutTimer; // 0x98
	private int m_TimeoutOverFrames; // 0x9C

	// Properties
	private bool HasTimedOut { get; }
	internal long BytesToDownload { get; }

	// Methods

	// RVA: 0x2117E40 Offset: 0x2116440 VA: 0x182117E40
	private bool get_HasTimedOut() { }

	// RVA: 0x2117D80 Offset: 0x2116380 VA: 0x182117D80
	internal long get_BytesToDownload() { }

	// RVA: 0x2116210 Offset: 0x2114810 VA: 0x182116210
	internal UnityWebRequest CreateWebRequest(IResourceLocation loc) { }

	// RVA: 0x2115F90 Offset: 0x2114590 VA: 0x182115F90
	internal UnityWebRequest CreateWebRequest(string url) { }

	// RVA: 0x2116480 Offset: 0x2114A80 VA: 0x182116480
	public AssetBundleRequest GetAssetPreloadRequest() { }

	// RVA: 0x2116DE0 Offset: 0x21153E0 VA: 0x182116DE0
	private float PercentComplete() { }

	// RVA: 0x2116600 Offset: 0x2114C00 VA: 0x182116600
	private DownloadStatus GetDownloadStatus() { }

	// RVA: 0x2116430 Offset: 0x2114A30 VA: 0x182116430 Slot: 4
	public AssetBundle GetAssetBundle() { }

	// RVA: 0x2116DB0 Offset: 0x21153B0 VA: 0x182116DB0
	private void OnUnloadOperationComplete(AsyncOperation op) { }

	// RVA: 0x2116E00 Offset: 0x2115400 VA: 0x182116E00
	public void Start(ProvideHandle provideHandle, AssetBundleUnloadOperation unloadOp) { }

	// RVA: 0x2117310 Offset: 0x2115910 VA: 0x182117310
	private bool WaitForCompletionHandler() { }

	// RVA: 0x21156D0 Offset: 0x2113CD0 VA: 0x1821156D0
	private void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback) { }

	// RVA: 0x21167A0 Offset: 0x2114DA0 VA: 0x1821167A0
	public static void GetLoadInfo(ProvideHandle handle, out AssetBundleResource.LoadType loadType, out string path) { }

	// RVA: 0x2116830 Offset: 0x2114E30 VA: 0x182116830
	internal static void GetLoadInfo(IResourceLocation location, ResourceManager resourceManager, out AssetBundleResource.LoadType loadType, out string path) { }

	// RVA: 0x2115740 Offset: 0x2113D40 VA: 0x182115740
	private void BeginOperation() { }

	// RVA: 0x2116A90 Offset: 0x2115090 VA: 0x182116A90
	private void LoadLocalBundle() { }

	// RVA: 0x21162B0 Offset: 0x21148B0 VA: 0x1821162B0
	internal WebRequestQueueOperation EnqueueWebRequest(string internalId) { }

	// RVA: 0x21155A0 Offset: 0x2113BA0 VA: 0x1821155A0
	internal void AddBeginWebRequestHandler(WebRequestQueueOperation webRequestQueueOperation) { }

	// RVA: 0x2115CC0 Offset: 0x21142C0 VA: 0x182115CC0
	private void BeginWebRequestOperation(AsyncOperation asyncOp) { }

	// RVA: 0x21171E0 Offset: 0x21157E0 VA: 0x1821171E0 Slot: 5
	public void Update(float unscaledDeltaTime) { }

	// RVA: 0x2116B90 Offset: 0x2115190 VA: 0x182116B90
	private void LocalRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x2115E00 Offset: 0x2114400 VA: 0x182115E00
	private void CompleteBundleLoad(AssetBundle bundle) { }

	// RVA: 0x2117780 Offset: 0x2115D80 VA: 0x182117780
	private void WebRequestOperationCompleted(AsyncOperation op) { }

	// RVA: 0x2117110 Offset: 0x2115710 VA: 0x182117110
	public bool Unload(out AssetBundleUnloadOperation unloadOp) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x51BCF0 Offset: 0x51A2F0 VA: 0x18051BCF0
	private void <GetAssetPreloadRequest>b__26_0(AsyncOperation operation) { }

	[CompilerGenerated]
	// RVA: 0x2117100 Offset: 0x2115700 VA: 0x182117100
	private void <AddBeginWebRequestHandler>b__39_0(UnityWebRequestAsyncOperation asyncOp) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("AssetBundle Provider")]
public class AssetBundleProvider : ResourceProviderBase // TypeDefIndex: 12693
{
	// Fields
	internal static Dictionary<string, AssetBundleUnloadOperation> m_UnloadingBundles; // 0x0

	// Properties
	protected internal static Dictionary<string, AssetBundleUnloadOperation> UnloadingBundles { get; set; }
	internal static int UnloadingAssetBundleCount { get; }
	internal static int AssetBundleCount { get; }

	// Methods

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x2114AC0 Offset: 0x21130C0 VA: 0x182114AC0
	private static void Init() { }

	// RVA: 0x21152C0 Offset: 0x21138C0 VA: 0x1821152C0
	protected internal static Dictionary<string, AssetBundleUnloadOperation> get_UnloadingBundles() { }

	// RVA: 0x2115310 Offset: 0x2113910 VA: 0x182115310
	internal static void set_UnloadingBundles(Dictionary<string, AssetBundleUnloadOperation> value) { }

	// RVA: 0x2115250 Offset: 0x2113850 VA: 0x182115250
	internal static int get_UnloadingAssetBundleCount() { }

	// RVA: 0x21151E0 Offset: 0x21137E0 VA: 0x1821151E0
	internal static int get_AssetBundleCount() { }

	// RVA: 0x2115050 Offset: 0x2113650 VA: 0x182115050
	internal static void WaitForAllUnloadingBundlesToComplete() { }

	// RVA: 0x2114B60 Offset: 0x2113160 VA: 0x182114B60 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }

	// RVA: 0x2114A70 Offset: 0x2113070 VA: 0x182114A70 Slot: 16
	public override Type GetDefaultType(IResourceLocation location) { }

	// RVA: 0x2114CE0 Offset: 0x21132E0 VA: 0x182114CE0 Slot: 15
	public override void Release(IResourceLocation location, object asset) { }

	// RVA: 0x21149A0 Offset: 0x2112FA0 VA: 0x1821149A0 Slot: 19
	internal virtual IOperationCacheKey CreateCacheKeyForLocation(ResourceManager rm, IResourceLocation location, Type desiredType) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x2115150 Offset: 0x2113750 VA: 0x182115150
	private static void .cctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Sprites from Atlases Provider")]
public class AtlasSpriteProvider : ResourceProviderBase // TypeDefIndex: 12694
{
	// Methods

	// RVA: 0x2118FA0 Offset: 0x21175A0 VA: 0x182118FA0 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Binary Asset Provider")]
internal class BinaryAssetProvider<TAdapter> : BinaryDataProvider // TypeDefIndex: 12695
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 19
	public override object Convert(Type type, byte[] data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC86440 Offset: 0xC84A40 VA: 0x180C86440
	|-BinaryAssetProvider<__Il2CppFullySharedGenericType>.Convert
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	|-BinaryAssetProvider<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Binary Data Provider")]
internal class BinaryDataProvider : ResourceProviderBase // TypeDefIndex: 12697
{
	// Fields
	[CompilerGenerated]
	private bool <IgnoreFailures>k__BackingField; // 0x20

	// Properties
	public bool IgnoreFailures { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_IgnoreFailures() { }

	[CompilerGenerated]
	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_IgnoreFailures(bool value) { }

	// RVA: 0x2119520 Offset: 0x2117B20 VA: 0x182119520 Slot: 19
	public virtual object Convert(Type type, byte[] data) { }

	// RVA: 0x2119530 Offset: 0x2117B30 VA: 0x182119530 Slot: 17
	public override void Provide(ProvideHandle provideHandle) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Assets from Bundles Provider")]
public class BundledAssetProvider : ResourceProviderBase // TypeDefIndex: 12699
{
	// Methods

	// RVA: 0x211A6D0 Offset: 0x2118CD0 VA: 0x18211A6D0 Slot: 17
	public override void Provide(ProvideHandle provideHandle) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct InstantiationParameters // TypeDefIndex: 12700
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Quaternion m_Rotation; // 0xC
	private Transform m_Parent; // 0x20
	private bool m_InstantiateInWorldPosition; // 0x28
	private bool m_SetPositionRotation; // 0x29

	// Properties
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Transform Parent { get; }
	public bool InstantiateInWorldPosition { get; }
	public bool SetPositionRotation { get; }

	// Methods

	// RVA: 0x971FB0 Offset: 0x9705B0 VA: 0x180971FB0
	public Vector3 get_Position() { }

	// RVA: 0x209E8F0 Offset: 0x209CEF0 VA: 0x18209E8F0
	public Quaternion get_Rotation() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Transform get_Parent() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_InstantiateInWorldPosition() { }

	// RVA: 0x179F980 Offset: 0x179DF80 VA: 0x18179F980
	public bool get_SetPositionRotation() { }

	// RVA: 0x211F950 Offset: 0x211DF50 VA: 0x18211F950
	public void .ctor(Transform parent, bool instantiateInWorldSpace) { }

	// RVA: 0x211FA00 Offset: 0x211E000 VA: 0x18211FA00
	public void .ctor(Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: -1 Offset: -1
	public TObject Instantiate<TObject>(TObject source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70F2F0 Offset: 0x70D8F0 VA: 0x18070F2F0
	|-InstantiationParameters.Instantiate<object>
	*/
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface IInstanceProvider // TypeDefIndex: 12701
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReleaseInstance(ResourceManager resourceManager, GameObject instance);
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class InstanceProvider : IInstanceProvider // TypeDefIndex: 12702
{
	// Fields
	private Dictionary<GameObject, AsyncOperationHandle<GameObject>> m_InstanceObjectToPrefabHandle; // 0x10

	// Methods

	// RVA: 0x211F4D0 Offset: 0x211DAD0 VA: 0x18211F4D0 Slot: 4
	public GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters) { }

	// RVA: 0x211F590 Offset: 0x211DB90 VA: 0x18211F590 Slot: 5
	public void ReleaseInstance(ResourceManager resourceManager, GameObject instance) { }

	// RVA: 0x211F8D0 Offset: 0x211DED0 VA: 0x18211F8D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public enum ProviderBehaviourFlags // TypeDefIndex: 12703
{
	// Fields
	public int value__; // 0x0
	public const ProviderBehaviourFlags None = 0;
	public const ProviderBehaviourFlags CanProvideWithFailedDependencies = 1;
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct ProvideHandle // TypeDefIndex: 12704
{
	// Fields
	private int m_Version; // 0x0
	private IGenericProviderOperation m_InternalOp; // 0x8
	private ResourceManager m_ResourceManager; // 0x10

	// Properties
	internal bool IsValid { get; }
	internal IGenericProviderOperation InternalOp { get; }
	public ResourceManager ResourceManager { get; }
	public Type Type { get; }
	public IResourceLocation Location { get; }
	public int DependencyCount { get; }

	// Methods

	// RVA: 0x2124EE0 Offset: 0x21234E0 VA: 0x182124EE0
	internal void .ctor(ResourceManager rm, IGenericProviderOperation op) { }

	// RVA: 0x2125070 Offset: 0x2123670 VA: 0x182125070
	internal bool get_IsValid() { }

	// RVA: 0x2124FD0 Offset: 0x21235D0 VA: 0x182124FD0
	internal IGenericProviderOperation get_InternalOp() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ResourceManager get_ResourceManager() { }

	// RVA: 0x2125130 Offset: 0x2123730 VA: 0x182125130
	public Type get_Type() { }

	// RVA: 0x21250D0 Offset: 0x21236D0 VA: 0x1821250D0
	public IResourceLocation get_Location() { }

	// RVA: 0x2124F70 Offset: 0x2123570 VA: 0x182124F70
	public int get_DependencyCount() { }

	// RVA: -1 Offset: -1
	public TDepObject GetDependency<TDepObject>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78D6A0 Offset: 0x78BCA0 VA: 0x18078D6A0
	|-ProvideHandle.GetDependency<object>
	|
	|-RVA: 0x78D550 Offset: 0x78BB50 VA: 0x18078D550
	|-ProvideHandle.GetDependency<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2124C00 Offset: 0x2123200 VA: 0x182124C00
	public void GetDependencies(IList<object> list) { }

	// RVA: 0x2124D40 Offset: 0x2123340 VA: 0x182124D40
	public void SetProgressCallback(Func<float> callback) { }

	// RVA: 0x2124C70 Offset: 0x2123270 VA: 0x182124C70
	public void SetDownloadProgressCallbacks(Func<DownloadStatus> callback) { }

	// RVA: 0x2124E10 Offset: 0x2123410 VA: 0x182124E10
	public void SetWaitForCompletionCallback(Func<bool> callback) { }

	// RVA: -1 Offset: -1
	public void Complete<T>(T result, bool status, Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78D440 Offset: 0x78BA40 VA: 0x18078D440
	|-ProvideHandle.Complete<object>
	|
	|-RVA: 0x78D2C0 Offset: 0x78B8C0 VA: 0x18078D2C0
	|-ProvideHandle.Complete<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface IResourceProvider // TypeDefIndex: 12705
{
	// Properties
	public abstract string ProviderId { get; }
	public abstract ProviderBehaviourFlags BehaviourFlags { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ProviderId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type GetDefaultType(IResourceLocation location);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool CanProvide(Type type, IResourceLocation location);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Provide(ProvideHandle provideHandle);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Release(IResourceLocation location, object asset);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ProviderBehaviourFlags get_BehaviourFlags();
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public struct SceneInstance // TypeDefIndex: 12706
{
	// Fields
	private Scene m_Scene; // 0x0
	internal AsyncOperation m_Operation; // 0x8

	// Properties
	public Scene Scene { get; set; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public Scene get_Scene() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	internal void set_Scene(Scene value) { }

	[Obsolete("Activate() has been deprecated.  Please use ActivateAsync().")]
	// RVA: 0x212BC30 Offset: 0x212A230 VA: 0x18212BC30
	public void Activate() { }

	// RVA: 0x212BC00 Offset: 0x212A200 VA: 0x18212BC00
	public AsyncOperation ActivateAsync() { }

	// RVA: 0x212BD20 Offset: 0x212A320 VA: 0x18212BD20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212BC60 Offset: 0x212A260 VA: 0x18212BC60 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public interface ISceneProvider // TypeDefIndex: 12707
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadMode, bool activateOnLoad, int priority);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle);
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
internal interface ISceneProvider2 : ISceneProvider // TypeDefIndex: 12708
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions);
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Extension]
internal static class SceneProviderExtensions // TypeDefIndex: 12709
{
	// Methods

	[Extension]
	// RVA: 0x212CE60 Offset: 0x212B460 VA: 0x18212CE60
	public static AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider provider, ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions) { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("JSON Asset Provider")]
public class JsonAssetProvider : TextDataProvider // TypeDefIndex: 12710
{
	// Methods

	// RVA: 0x2122D80 Offset: 0x2121380 VA: 0x182122D80 Slot: 19
	public override object Convert(Type type, string text) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Assets from Legacy Resources")]
public class LegacyResourcesProvider : ResourceProviderBase // TypeDefIndex: 12712
{
	// Methods

	// RVA: 0x2123490 Offset: 0x2121A90 VA: 0x182123490 Slot: 17
	public override void Provide(ProvideHandle pi) { }

	// RVA: 0x2123AD0 Offset: 0x21220D0 VA: 0x182123AD0 Slot: 15
	public override void Release(IResourceLocation location, object asset) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public abstract class ResourceProviderBase : IResourceProvider, IInitializableObject // TypeDefIndex: 12715
{
	// Fields
	protected string m_ProviderId; // 0x10
	protected ProviderBehaviourFlags m_BehaviourFlags; // 0x18

	// Properties
	public virtual string ProviderId { get; }
	private ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.BehaviourFlags { get; }

	// Methods

	// RVA: 0x212BBA0 Offset: 0x212A1A0 VA: 0x18212BBA0 Slot: 12
	public virtual string get_ProviderId() { }

	// RVA: 0x212BB70 Offset: 0x212A170 VA: 0x18212BB70 Slot: 13
	public virtual bool Initialize(string id, string data) { }

	// RVA: 0x212B960 Offset: 0x2129F60 VA: 0x18212B960 Slot: 14
	public virtual bool CanProvide(Type t, IResourceLocation location) { }

	// RVA: 0x1A0A860 Offset: 0x1A08E60 VA: 0x181A0A860 Slot: 3
	public override string ToString() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 15
	public virtual void Release(IResourceLocation location, object obj) { }

	// RVA: 0x16592C0 Offset: 0x16578C0 VA: 0x1816592C0 Slot: 16
	public virtual Type GetDefaultType(IResourceLocation location) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Provide(ProvideHandle provideHandle);

	// RVA: 0x212B9B0 Offset: 0x2129FB0 VA: 0x18212B9B0 Slot: 18
	public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 9
	private ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.get_BehaviourFlags() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[Serializable]
public class ProviderLoadRequestOptions // TypeDefIndex: 12716
{
	// Fields
	[SerializeField]
	private bool m_IgnoreFailures; // 0x10
	private int m_WebRequestTimeout; // 0x14

	// Properties
	public bool IgnoreFailures { get; set; }
	public int WebRequestTimeout { get; set; }

	// Methods

	// RVA: 0x2125220 Offset: 0x2123820 VA: 0x182125220
	public ProviderLoadRequestOptions Copy() { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_IgnoreFailures() { }

	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_IgnoreFailures(bool value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_WebRequestTimeout() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_WebRequestTimeout(int value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
public class SceneProvider : ISceneProvider2, ISceneProvider // TypeDefIndex: 12719
{
	// Methods

	// RVA: 0x212D0C0 Offset: 0x212B6C0 VA: 0x18212D0C0 Slot: 5
	public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority) { }

	// RVA: 0x212D170 Offset: 0x212B770 VA: 0x18212D170 Slot: 6
	public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	// RVA: 0x212D430 Offset: 0x212BA30 VA: 0x18212D430 Slot: 7
	public AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	// RVA: 0x212D540 Offset: 0x212BB40 VA: 0x18212D540 Slot: 4
	private AsyncOperationHandle<SceneInstance> UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider2.ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.ResourceProviders
[DisplayName("Text Data Provider")]
public class TextDataProvider : ResourceProviderBase // TypeDefIndex: 12721
{
	// Fields
	[CompilerGenerated]
	private bool <IgnoreFailures>k__BackingField; // 0x20

	// Properties
	public bool IgnoreFailures { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_IgnoreFailures() { }

	[CompilerGenerated]
	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_IgnoreFailures(bool value) { }

	// RVA: 0x2119520 Offset: 0x2117B20 VA: 0x182119520 Slot: 19
	public virtual object Convert(Type type, string text) { }

	// RVA: 0x212DA20 Offset: 0x212C020 VA: 0x18212DA20 Slot: 17
	public override void Provide(ProvideHandle provideHandle) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

