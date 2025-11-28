// Namespace: UnityEngine.ResourceManagement.Util
internal class BinaryStorageBuffer // TypeDefIndex: 12659
{
	// Fields
	private const uint kUnicodeStringFlag = 2147483648;
	private const uint kDynamicStringFlag = 1073741824;
	private const uint kClearFlagsMask = 1073741823;

	// Methods

	// RVA: 0x2119A80 Offset: 0x2118080 VA: 0x182119A80
	private static void ComputeHash(void* pData, ulong size, Hash128* hash) { }

	// RVA: 0x21195C0 Offset: 0x2117BC0 VA: 0x1821195C0
	private static void AddSerializationAdapter(Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter> serializationAdapters, BinaryStorageBuffer.ISerializationAdapter adapter, bool forceOverride = False) { }

	// RVA: 0x2119AA0 Offset: 0x21180A0 VA: 0x182119AA0
	private static bool GetSerializationAdapter(Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter> serializationAdapters, Type t, out BinaryStorageBuffer.ISerializationAdapter adapter) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal struct LRUCache<TKey, TValue> // TypeDefIndex: 12661
{
	// Fields
	private int entryLimit; // 0x0
	private Dictionary<TKey, LRUCache.Entry<TKey, TValue>> cache; // 0x0
	private LinkedList<TKey> lru; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int limit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110EC30 Offset: 0x110D230 VA: 0x18110EC30
	|-LRUCache<uint, object>..ctor
	|
	|-RVA: 0x110EAD0 Offset: 0x110D0D0 VA: 0x18110EAD0
	|-LRUCache<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey id, TValue obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E210 Offset: 0x110C810 VA: 0x18110E210
	|-LRUCache<uint, object>.TryAdd
	|
	|-RVA: 0x110DB30 Offset: 0x110C130 VA: 0x18110DB30
	|-LRUCache<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryGet(TKey offset, out TValue val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E430 Offset: 0x110CA30 VA: 0x18110E430
	|-LRUCache<uint, object>.TryGet
	|
	|-RVA: 0x110E5A0 Offset: 0x110CBA0 VA: 0x18110E5A0
	|-LRUCache<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGet
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
[ExecuteInEditMode]
public abstract class ComponentSingleton<T> : MonoBehaviour // TypeDefIndex: 12662
{
	// Fields
	private static T s_Instance; // 0x0

	// Properties
	public static bool Exists { get; }
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_Exists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13140 Offset: 0xD11740 VA: 0x180D13140
	|-ComponentSingleton<object>.get_Exists
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD131D0 Offset: 0xD117D0 VA: 0x180D131D0
	|-ComponentSingleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	private static T FindInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13070 Offset: 0xD11670 VA: 0x180D13070
	|-ComponentSingleton<object>.FindInstance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual string GetGameObjectName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD130E0 Offset: 0xD116E0 VA: 0x180D130E0
	|-ComponentSingleton<object>.GetGameObjectName
	*/

	// RVA: -1 Offset: -1
	private static T CreateNewSingleton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD12DD0 Offset: 0xD113D0 VA: 0x180D12DD0
	|-ComponentSingleton<object>.CreateNewSingleton
	*/

	// RVA: -1 Offset: -1
	private void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD12BE0 Offset: 0xD111E0 VA: 0x180D12BE0
	|-ComponentSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	public static void DestroySingleton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD12F00 Offset: 0xD11500 VA: 0x180D12F00
	|-ComponentSingleton<object>.DestroySingleton
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	|-ComponentSingleton<object>..ctor
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
internal class DelayedActionManager : ComponentSingleton<DelayedActionManager> // TypeDefIndex: 12664
{
	// Fields
	private List<DelayedActionManager.DelegateInfo>[] m_Actions; // 0x20
	private LinkedList<DelayedActionManager.DelegateInfo> m_DelayedActions; // 0x28
	private Stack<LinkedListNode<DelayedActionManager.DelegateInfo>> m_NodeCache; // 0x30
	private int m_CollectionIndex; // 0x38
	private bool m_DestroyOnCompletion; // 0x3C

	// Properties
	public static bool IsActive { get; }

	// Methods

	// RVA: 0x211AB10 Offset: 0x2119110 VA: 0x18211AB10
	private LinkedListNode<DelayedActionManager.DelegateInfo> GetNode(ref DelayedActionManager.DelegateInfo del) { }

	// RVA: 0x211AAA0 Offset: 0x21190A0 VA: 0x18211AAA0
	public static void Clear() { }

	// RVA: 0x211AB00 Offset: 0x2119100 VA: 0x18211AB00
	private void DestroyWhenComplete() { }

	// RVA: 0x211AA20 Offset: 0x2119020 VA: 0x18211AA20
	public static void AddAction(Delegate action, float delay = 0, object[] parameters) { }

	// RVA: 0x211A760 Offset: 0x2118D60 VA: 0x18211A760
	private void AddActionInternal(Delegate action, float delay, object[] parameters) { }

	// RVA: 0x211B400 Offset: 0x2119A00 VA: 0x18211B400
	public static bool get_IsActive() { }

	// RVA: 0x211B060 Offset: 0x2119660 VA: 0x18211B060
	public static bool Wait(float timeout = 0, float timeAdvanceAmount = 0) { }

	// RVA: 0x211AF80 Offset: 0x2119580 VA: 0x18211AF80
	private void LateUpdate() { }

	// RVA: 0x211AC20 Offset: 0x2119220 VA: 0x18211AC20
	private void InternalLateUpdate(float t) { }

	// RVA: 0x211AFB0 Offset: 0x21195B0 VA: 0x18211AFB0
	private void OnApplicationQuit() { }

	// RVA: 0x211B1F0 Offset: 0x21197F0 VA: 0x18211B1F0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal interface IOperationCacheKey : IEquatable<IOperationCacheKey> // TypeDefIndex: 12665
{}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class IdCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 12666
{
	// Fields
	public string ID; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(string id) { }

	// RVA: 0x211EB30 Offset: 0x211D130 VA: 0x18211EB30
	private bool Equals(IdCacheKey other) { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211EB60 Offset: 0x211D160 VA: 0x18211EB60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x211EAB0 Offset: 0x211D0B0 VA: 0x18211EAB0 Slot: 4
	public bool Equals(IOperationCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class LocationCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 12667
{
	// Fields
	private readonly IResourceLocation m_Location; // 0x10
	private readonly Type m_DesiredType; // 0x18

	// Methods

	// RVA: 0x2123E20 Offset: 0x2122420 VA: 0x182123E20
	public void .ctor(IResourceLocation location, Type desiredType) { }

	// RVA: 0x2123DD0 Offset: 0x21223D0 VA: 0x182123DD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2123C00 Offset: 0x2122200 VA: 0x182123C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2123D20 Offset: 0x2122320 VA: 0x182123D20 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x2123CB0 Offset: 0x21222B0 VA: 0x182123CB0
	private bool Equals(LocationCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class DependenciesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 12668
{
	// Fields
	private readonly IList<IResourceLocation> m_Dependencies; // 0x10
	private readonly int m_DependenciesHash; // 0x18

	// Methods

	// RVA: 0xC05940 Offset: 0xC03F40 VA: 0x180C05940
	public void .ctor(IList<IResourceLocation> dependencies, int dependenciesHash) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211BAE0 Offset: 0x211A0E0 VA: 0x18211BAE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x211BC70 Offset: 0x211A270 VA: 0x18211BC70 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x211BB40 Offset: 0x211A140 VA: 0x18211BB40
	private bool Equals(DependenciesCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal sealed class AsyncOpHandlesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey> // TypeDefIndex: 12669
{
	// Fields
	private readonly HashSet<AsyncOperationHandle> m_Handles; // 0x10

	// Methods

	// RVA: 0x2118080 Offset: 0x2116680 VA: 0x182118080
	public void .ctor(IList<AsyncOperationHandle> handles) { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2117F00 Offset: 0x2116500 VA: 0x182117F00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2117FC0 Offset: 0x21165C0 VA: 0x182117FC0 Slot: 4
	public bool Equals(IOperationCacheKey other) { }

	// RVA: 0x2117E80 Offset: 0x2116480 VA: 0x182117E80
	private bool Equals(AsyncOpHandlesCacheKey other) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal static class LocationUtils // TypeDefIndex: 12670
{
	// Methods

	// RVA: 0x2124040 Offset: 0x2122640 VA: 0x182124040
	public static bool LocationEquals(IResourceLocation loc1, IResourceLocation loc2) { }

	// RVA: 0x2123F30 Offset: 0x2122530 VA: 0x182123F30
	public static bool DependenciesEqual(IList<IResourceLocation> deps1, IList<IResourceLocation> deps2) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
internal class PlatformUtilities // TypeDefIndex: 12671
{
	// Methods

	// RVA: 0x2124BF0 Offset: 0x21231F0 VA: 0x182124BF0
	internal static bool PlatformUsesMultiThreading(RuntimePlatform platform) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public interface IInitializableObject // TypeDefIndex: 12672
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Initialize(string id, string data);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data);
}

// Namespace: UnityEngine.ResourceManagement.Util
public interface IObjectInitializationDataProvider // TypeDefIndex: 12673
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ObjectInitializationData CreateObjectInitializationData();
}

// Namespace: UnityEngine.ResourceManagement.Util
public interface IAllocationStrategy // TypeDefIndex: 12674
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object New(Type type, int typeHash);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Release(int typeHash, object obj);
}

// Namespace: UnityEngine.ResourceManagement.Util
public class DefaultAllocationStrategy : IAllocationStrategy // TypeDefIndex: 12675
{
	// Methods

	// RVA: 0x211A750 Offset: 0x2118D50 VA: 0x18211A750 Slot: 4
	public object New(Type type, int typeHash) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void Release(int typeHash, object obj) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class LRUCacheAllocationStrategy : IAllocationStrategy // TypeDefIndex: 12676
{
	// Fields
	private int m_poolMaxSize; // 0x10
	private int m_poolInitialCapacity; // 0x14
	private int m_poolCacheMaxSize; // 0x18
	private List<List<object>> m_poolCache; // 0x20
	private Dictionary<int, List<object>> m_cache; // 0x28

	// Methods

	// RVA: 0x21232C0 Offset: 0x21218C0 VA: 0x1821232C0
	public void .ctor(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity) { }

	// RVA: 0x2122D90 Offset: 0x2121390 VA: 0x182122D90
	private List<object> GetPool() { }

	// RVA: 0x2123050 Offset: 0x2121650 VA: 0x182123050
	private void ReleasePool(List<object> pool) { }

	// RVA: 0x2122E80 Offset: 0x2121480 VA: 0x182122E80 Slot: 4
	public object New(Type type, int typeHash) { }

	// RVA: 0x21230C0 Offset: 0x21216C0 VA: 0x1821230C0 Slot: 5
	public void Release(int typeHash, object obj) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class SerializedTypeRestrictionAttribute : Attribute // TypeDefIndex: 12677
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class LinkedListNodeCache<T> // TypeDefIndex: 12678
{
	// Fields
	private int m_NodesCreated; // 0x0
	private LinkedList<T> m_NodeCache; // 0x0

	// Properties
	internal int CreatedNodeCount { get; }
	internal int CachedNodeCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public LinkedListNode<T> Acquire(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115280 Offset: 0x1113880 VA: 0x181115280
	|-LinkedListNodeCache<object>.Acquire
	|
	|-RVA: 0x11153B0 Offset: 0x11139B0 VA: 0x1811153B0
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void Release(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115750 Offset: 0x1113D50 VA: 0x181115750
	|-LinkedListNodeCache<object>.Release
	|
	|-RVA: 0x11155B0 Offset: 0x1113BB0 VA: 0x1811155B0
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	internal int get_CreatedNodeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	|-LinkedListNodeCache<object>.get_CreatedNodeCount
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.get_CreatedNodeCount
	*/

	// RVA: -1 Offset: -1
	internal int get_CachedNodeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115810 Offset: 0x1113E10 VA: 0x181115810
	|-LinkedListNodeCache<object>.get_CachedNodeCount
	|
	|-RVA: 0x1115830 Offset: 0x1113E30 VA: 0x181115830
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.get_CachedNodeCount
	*/

	// RVA: -1 Offset: -1
	internal void set_CachedNodeCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115870 Offset: 0x1113E70 VA: 0x181115870
	|-LinkedListNodeCache<object>.set_CachedNodeCount
	|
	|-RVA: 0x1115A40 Offset: 0x1114040 VA: 0x181115A40
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>.set_CachedNodeCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-LinkedListNodeCache<object>..ctor
	|-LinkedListNodeCache<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
internal static class GlobalLinkedListNodeCache<T> // TypeDefIndex: 12679
{
	// Fields
	private static LinkedListNodeCache<T> m_globalCache; // 0x0

	// Properties
	public static bool CacheExists { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_CacheExists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102E2B0 Offset: 0x102C8B0 VA: 0x18102E2B0
	|-GlobalLinkedListNodeCache<object>.get_CacheExists
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.get_CacheExists
	*/

	// RVA: -1 Offset: -1
	public static void SetCacheSize(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102E0F0 Offset: 0x102C6F0 VA: 0x18102E0F0
	|-GlobalLinkedListNodeCache<object>.SetCacheSize
	|
	|-RVA: 0x102DEE0 Offset: 0x102C4E0 VA: 0x18102DEE0
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.SetCacheSize
	*/

	// RVA: -1 Offset: -1
	public static LinkedListNode<T> Acquire(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102D950 Offset: 0x102BF50 VA: 0x18102D950
	|-GlobalLinkedListNodeCache<object>.Acquire
	|
	|-RVA: 0x102D670 Offset: 0x102BC70 VA: 0x18102D670
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public static void Release(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102DB10 Offset: 0x102C110 VA: 0x18102DB10
	|-GlobalLinkedListNodeCache<object>.Release
	|
	|-RVA: 0x102DCD0 Offset: 0x102C2D0 VA: 0x18102DCD0
	|-GlobalLinkedListNodeCache<__Il2CppFullySharedGenericType>.Release
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
[Serializable]
public struct SerializedType // TypeDefIndex: 12680
{
	// Fields
	[FormerlySerializedAs("m_assemblyName")]
	[SerializeField]
	private string m_AssemblyName; // 0x0
	[FormerlySerializedAs("m_className")]
	[SerializeField]
	private string m_ClassName; // 0x8
	private Type m_CachedType; // 0x10
	[CompilerGenerated]
	private bool <ValueChanged>k__BackingField; // 0x18

	// Properties
	public string AssemblyName { get; }
	public string ClassName { get; }
	public Type Value { get; set; }
	public bool ValueChanged { get; set; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public string get_AssemblyName() { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public string get_ClassName() { }

	// RVA: 0x212D720 Offset: 0x212BD20 VA: 0x18212D720 Slot: 3
	public override string ToString() { }

	// RVA: 0x212D7D0 Offset: 0x212BDD0 VA: 0x18212D7D0
	public Type get_Value() { }

	// RVA: 0x212D940 Offset: 0x212BF40 VA: 0x18212D940
	public void set_Value(Type value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_ValueChanged() { }

	[CompilerGenerated]
	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	public void set_ValueChanged(bool value) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
[Serializable]
public struct ObjectInitializationData // TypeDefIndex: 12681
{
	// Fields
	[FormerlySerializedAs("m_id")]
	[SerializeField]
	private string m_Id; // 0x0
	[FormerlySerializedAs("m_objectType")]
	[SerializeField]
	private SerializedType m_ObjectType; // 0x8
	[FormerlySerializedAs("m_data")]
	[SerializeField]
	private string m_Data; // 0x28

	// Properties
	public string Id { get; }
	public SerializedType ObjectType { get; }
	public string Data { get; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public string get_Id() { }

	// RVA: 0x1105E50 Offset: 0x1104450 VA: 0x181105E50
	public SerializedType get_ObjectType() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Data() { }

	// RVA: 0x2124A70 Offset: 0x2123070 VA: 0x182124A70 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	public TObject CreateInstance<TObject>(string idOverride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7394F0 Offset: 0x737AF0 VA: 0x1807394F0
	|-ObjectInitializationData.CreateInstance<object>
	|
	|-RVA: 0x739240 Offset: 0x737840 VA: 0x180739240
	|-ObjectInitializationData.CreateInstance<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2124840 Offset: 0x2122E40 VA: 0x182124840
	public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride) { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public static class ResourceManagerConfig // TypeDefIndex: 12682
{
	// Methods

	// RVA: 0x2126C90 Offset: 0x2125290 VA: 0x182126C90
	public static bool ExtractKeyAndSubKey(object keyObj, out string mainKey, out string subKey) { }

	// RVA: 0x2126D80 Offset: 0x2125380 VA: 0x182126D80
	public static bool IsPathRemote(string path) { }

	// RVA: 0x2127040 Offset: 0x2125640 VA: 0x182127040
	public static string StripQueryParameters(string path) { }

	// RVA: 0x2126ED0 Offset: 0x21254D0 VA: 0x182126ED0
	public static bool ShouldPathUseWebRequest(string path) { }

	// RVA: 0x2126DD0 Offset: 0x21253D0 VA: 0x182126DD0
	private static bool PlatformCanLoadLocallyFromUrlPath() { }

	// RVA: 0x2126990 Offset: 0x2124F90 VA: 0x182126990
	public static Array CreateArrayResult(Type type, Object[] allAssets) { }

	// RVA: -1 Offset: -1
	public static TObject CreateArrayResult<TObject>(Object[] allAssets) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7923A0 Offset: 0x7909A0 VA: 0x1807923A0
	|-ResourceManagerConfig.CreateArrayResult<object>
	*/

	// RVA: 0x2126B00 Offset: 0x2125100 VA: 0x182126B00
	public static IList CreateListResult(Type type, Object[] allAssets) { }

	// RVA: -1 Offset: -1
	public static TObject CreateListResult<TObject>(Object[] allAssets) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x792430 Offset: 0x790A30 VA: 0x180792430
	|-ResourceManagerConfig.CreateListResult<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool IsInstance<T1, T2>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x792530 Offset: 0x790B30 VA: 0x180792530
	|-ResourceManagerConfig.IsInstance<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.ResourceManagement.Util
[Flags]
internal enum BundleSource // TypeDefIndex: 12683
{
	// Fields
	public int value__; // 0x0
	public const BundleSource None = 0;
	public const BundleSource Local = 1;
	public const BundleSource Cache = 2;
	public const BundleSource Download = 4;
}

// Namespace: UnityEngine.ResourceManagement.Util
public class UnityWebRequestUtilities // TypeDefIndex: 12684
{
	// Methods

	// RVA: 0x212E790 Offset: 0x212CD90 VA: 0x18212E790
	public static bool RequestHasErrors(UnityWebRequest webReq, out UnityWebRequestResult result) { }

	// RVA: 0x212E6F0 Offset: 0x212CCF0 VA: 0x18212E6F0
	public static bool IsAssetBundleDownloaded(UnityWebRequestAsyncOperation op) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ResourceManagement.Util
public class UnityWebRequestResult // TypeDefIndex: 12685
{
	// Fields
	[CompilerGenerated]
	private string <Error>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly long <ResponseCode>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly UnityWebRequest.Result <Result>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <Method>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Url>k__BackingField; // 0x30

	// Properties
	public string Error { get; set; }
	public long ResponseCode { get; }
	public UnityWebRequest.Result Result { get; }
	public string Method { get; }
	public string Url { get; }

	// Methods

	// RVA: 0x212E5D0 Offset: 0x212CBD0 VA: 0x18212E5D0
	public void .ctor(UnityWebRequest request) { }

	// RVA: 0x212E480 Offset: 0x212CA80 VA: 0x18212E480 Slot: 3
	public override string ToString() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Error() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Error(string value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public long get_ResponseCode() { }

	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public UnityWebRequest.Result get_Result() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Method() { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_Url() { }

	// RVA: 0x212E1B0 Offset: 0x212C7B0 VA: 0x18212E1B0
	public bool ShouldRetryDownloadError() { }
}

