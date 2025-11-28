// Namespace: UnityEngine.SceneManagement
[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
[Serializable]
public struct Scene // TypeDefIndex: 9884
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private int m_Handle; // 0x0

	// Properties
	public int handle { get; }
	public string name { get; }
	public bool isLoaded { get; }
	public int rootCount { get; }

	// Methods

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x2360760 Offset: 0x235ED60 VA: 0x182360760
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x2360300 Offset: 0x235E900 VA: 0x182360300
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x2360280 Offset: 0x235E880 VA: 0x182360280
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x23603A0 Offset: 0x235E9A0 VA: 0x1823603A0
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", 2)]
	// RVA: 0x23603E0 Offset: 0x235E9E0 VA: 0x1823603E0
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public int get_handle() { }

	// RVA: 0x23607A0 Offset: 0x235EDA0 VA: 0x1823607A0
	public bool IsValid() { }

	// RVA: 0x2360820 Offset: 0x235EE20 VA: 0x182360820
	public string get_name() { }

	// RVA: 0x23607E0 Offset: 0x235EDE0 VA: 0x1823607E0
	public bool get_isLoaded() { }

	// RVA: 0x2360830 Offset: 0x235EE30 VA: 0x182360830
	public int get_rootCount() { }

	// RVA: 0x2360690 Offset: 0x235EC90 VA: 0x182360690
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x2360420 Offset: 0x235EA20 VA: 0x182360420
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	// RVA: 0x2340850 Offset: 0x233EE50 VA: 0x182340850
	public static bool op_Equality(Scene lhs, Scene rhs) { }

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2360200 Offset: 0x235E800 VA: 0x182360200 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x23602C0 Offset: 0x235E8C0 VA: 0x1823602C0
	private static void GetNameInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret) { }
}

// Namespace: UnityEngine.SceneManagement
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[StaticAccessor("SceneManagerBindings", 2)]
internal static class SceneManagerAPIInternal // TypeDefIndex: 9885
{
	// Methods

	[NativeThrows]
	// RVA: 0x235EF60 Offset: 0x235D560 VA: 0x18235EF60
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x235EEF0 Offset: 0x235D4F0 VA: 0x18235EEF0
	private static IntPtr LoadSceneAsyncNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, in LoadSceneParameters parameters, bool mustCompleteNextFrame) { }
}

// Namespace: UnityEngine.SceneManagement
public class SceneManagerAPI // TypeDefIndex: 9886
{
	// Fields
	private static SceneManagerAPI s_DefaultAPI; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static SceneManagerAPI ActiveAPI { get; }
	public static SceneManagerAPI overrideAPI { get; }

	// Methods

	// RVA: 0x235F220 Offset: 0x235D820 VA: 0x18235F220
	internal static SceneManagerAPI get_ActiveAPI() { }

	[CompilerGenerated]
	// RVA: 0x235F2D0 Offset: 0x235D8D0 VA: 0x18235F2D0
	public static SceneManagerAPI get_overrideAPI() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected internal void .ctor() { }

	// RVA: 0x235F180 Offset: 0x235D780 VA: 0x18235F180 Slot: 4
	protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	// RVA: 0x235F1B0 Offset: 0x235D7B0 VA: 0x18235F1B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.SceneManagement
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[RequiredByNativeCode]
public class SceneManager // TypeDefIndex: 9887
{
	// Fields
	internal static bool s_AllowLoadScene; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static UnityAction<Scene> sceneUnloaded; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x18

	// Properties
	public static int sceneCount { get; }

	// Methods

	[NativeMethod("GetSceneCount")]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[StaticAccessor("GetSceneManager()", 0)]
	// RVA: 0x235FFB0 Offset: 0x235E5B0 VA: 0x18235FFB0
	public static int get_sceneCount() { }

	[StaticAccessor("SceneManagerBindings", 2)]
	// RVA: 0x235F360 Offset: 0x235D960 VA: 0x18235F360
	public static Scene GetActiveScene() { }

	[StaticAccessor("SceneManagerBindings", 2)]
	[NativeThrows]
	// RVA: 0x235F410 Offset: 0x235DA10 VA: 0x18235F410
	public static Scene GetSceneAt(int index) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", 2)]
	// RVA: 0x235FC00 Offset: 0x235E200 VA: 0x18235FC00
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x235F6E0 Offset: 0x235DCE0 VA: 0x18235F6E0
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", 2)]
	// RVA: 0x235FAF0 Offset: 0x235E0F0 VA: 0x18235FAF0
	public static void MoveGameObjectToScene(GameObject go, Scene scene) { }

	[RequiredByNativeCode]
	// RVA: 0x235F670 Offset: 0x235DC70 VA: 0x18235F670
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	[CompilerGenerated]
	// RVA: 0x235FD90 Offset: 0x235E390 VA: 0x18235FD90
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGenerated]
	// RVA: 0x235FFE0 Offset: 0x235E5E0 VA: 0x18235FFE0
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGenerated]
	// RVA: 0x235FEA0 Offset: 0x235E4A0 VA: 0x18235FEA0
	public static void add_sceneUnloaded(UnityAction<Scene> value) { }

	[CompilerGenerated]
	// RVA: 0x23600F0 Offset: 0x235E6F0 VA: 0x1823600F0
	public static void remove_sceneUnloaded(UnityAction<Scene> value) { }

	// RVA: 0x235F8D0 Offset: 0x235DED0 VA: 0x18235F8D0
	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x235FA40 Offset: 0x235E040 VA: 0x18235FA40
	public static void LoadScene(string sceneName) { }

	// RVA: 0x235F940 Offset: 0x235DF40 VA: 0x18235F940
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	[ExcludeFromDocs]
	// RVA: 0x235F7C0 Offset: 0x235DDC0 VA: 0x18235F7C0
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	// RVA: 0x235F860 Offset: 0x235DE60 VA: 0x18235F860
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x235FC80 Offset: 0x235E280 VA: 0x18235FC80
	public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options) { }

	[RequiredByNativeCode]
	// RVA: 0x235F530 Offset: 0x235DB30 VA: 0x18235F530
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCode]
	// RVA: 0x235F5D0 Offset: 0x235DBD0 VA: 0x18235F5D0
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCode]
	// RVA: 0x235F490 Offset: 0x235DA90 VA: 0x18235F490
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x235FD50 Offset: 0x235E350 VA: 0x18235FD50
	private static void .cctor() { }

	// RVA: 0x235F320 Offset: 0x235D920 VA: 0x18235F320
	private static void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x235F3D0 Offset: 0x235D9D0 VA: 0x18235F3D0
	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	// RVA: 0x235FBC0 Offset: 0x235E1C0 VA: 0x18235FBC0
	private static IntPtr UnloadSceneAsyncInternal_Injected(in Scene scene, UnloadSceneOptions options) { }

	// RVA: 0x235FAA0 Offset: 0x235E0A0 VA: 0x18235FAA0
	private static void MoveGameObjectToScene_Injected(IntPtr go, in Scene scene) { }
}

// Namespace: UnityEngine.SceneManagement
public enum LoadSceneMode // TypeDefIndex: 9888
{
	// Fields
	public int value__; // 0x0
	public const LoadSceneMode Single = 0;
	public const LoadSceneMode Additive = 1;
}

// Namespace: UnityEngine.SceneManagement
[Flags]
public enum LocalPhysicsMode // TypeDefIndex: 9889
{
	// Fields
	public int value__; // 0x0
	public const LocalPhysicsMode None = 0;
	public const LocalPhysicsMode Physics2D = 1;
	public const LocalPhysicsMode Physics3D = 2;
}

// Namespace: UnityEngine.SceneManagement
[Serializable]
public struct LoadSceneParameters // TypeDefIndex: 9890
{
	// Fields
	[SerializeField]
	private LoadSceneMode m_LoadSceneMode; // 0x0
	[SerializeField]
	private LocalPhysicsMode m_LocalPhysicsMode; // 0x4

	// Methods

	// RVA: 0x9BFD10 Offset: 0x9BE310 VA: 0x1809BFD10
	public void .ctor(LoadSceneMode mode) { }
}

// Namespace: UnityEngine.SceneManagement
[Flags]
public enum UnloadSceneOptions // TypeDefIndex: 9891
{
	// Fields
	public int value__; // 0x0
	public const UnloadSceneOptions None = 0;
	public const UnloadSceneOptions UnloadAllEmbeddedSceneObjects = 1;
}

