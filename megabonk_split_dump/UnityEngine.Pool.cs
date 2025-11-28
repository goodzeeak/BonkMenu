// Namespace: UnityEngine.Pool
public class CollectionPool<TCollection, TItem> // TypeDefIndex: 10037
{
	// Fields
	internal static readonly ObjectPool<TCollection> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static TCollection Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9F670 Offset: 0xC9DC70 VA: 0x180C9F670
	|-CollectionPool<object, KeyValuePair<BindingId, DataBindingManager.BindingData>>.Get
	|-CollectionPool<object, KeyValuePair<object, object>>.Get
	|-CollectionPool<object, ValueTuple<int, int>>.Get
	|-CollectionPool<object, ValueTuple<LocaleIdentifier, object>>.Get
	|-CollectionPool<object, AsyncOperationHandle>.Get
	|-CollectionPool<object, Color32>.Get
	|-CollectionPool<object, int>.Get
	|-CollectionPool<object, object>.Get
	|-CollectionPool<object, PropertyPath>.Get
	|-CollectionPool<object, PropertyPathPart>.Get
	|-CollectionPool<object, UIVertex>.Get
	|-CollectionPool<object, Vector3>.Get
	|-CollectionPool<object, Vector4>.Get
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Get
	|-CollectionPool<object, DataBindingManager.BindingData>.Get
	|-CollectionPool<object, FocusController.FocusedElement>.Get
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>.Get
	*/

	// RVA: -1 Offset: -1
	public static PooledObject<TCollection> Get(out TCollection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9F570 Offset: 0xC9DB70 VA: 0x180C9F570
	|-CollectionPool<object, KeyValuePair<BindingId, DataBindingManager.BindingData>>.Get
	|-CollectionPool<object, KeyValuePair<object, object>>.Get
	|-CollectionPool<object, ValueTuple<int, int>>.Get
	|-CollectionPool<object, ValueTuple<LocaleIdentifier, object>>.Get
	|-CollectionPool<object, AsyncOperationHandle>.Get
	|-CollectionPool<object, Color32>.Get
	|-CollectionPool<object, int>.Get
	|-CollectionPool<object, object>.Get
	|-CollectionPool<object, PropertyPath>.Get
	|-CollectionPool<object, PropertyPathPart>.Get
	|-CollectionPool<object, UIVertex>.Get
	|-CollectionPool<object, Vector3>.Get
	|-CollectionPool<object, Vector4>.Get
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Get
	|-CollectionPool<object, DataBindingManager.BindingData>.Get
	|-CollectionPool<object, FocusController.FocusedElement>.Get
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(TCollection toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9F740 Offset: 0xC9DD40 VA: 0x180C9F740
	|-CollectionPool<object, KeyValuePair<BindingId, DataBindingManager.BindingData>>.Release
	|-CollectionPool<object, KeyValuePair<object, object>>.Release
	|-CollectionPool<object, ValueTuple<int, int>>.Release
	|-CollectionPool<object, ValueTuple<LocaleIdentifier, object>>.Release
	|-CollectionPool<object, AsyncOperationHandle>.Release
	|-CollectionPool<object, Color32>.Release
	|-CollectionPool<object, int>.Release
	|-CollectionPool<object, object>.Release
	|-CollectionPool<object, PropertyPath>.Release
	|-CollectionPool<object, PropertyPathPart>.Release
	|-CollectionPool<object, UIVertex>.Release
	|-CollectionPool<object, Vector3>.Release
	|-CollectionPool<object, Vector4>.Release
	|-CollectionPool<object, __Il2CppFullySharedGenericType>.Release
	|-CollectionPool<object, DataBindingManager.BindingData>.Release
	|-CollectionPool<object, FocusController.FocusedElement>.Release
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9F820 Offset: 0xC9DE20 VA: 0x180C9F820
	|-CollectionPool<object, KeyValuePair<BindingId, DataBindingManager.BindingData>>..cctor
	|-CollectionPool<object, KeyValuePair<object, object>>..cctor
	|-CollectionPool<object, ValueTuple<int, int>>..cctor
	|-CollectionPool<object, ValueTuple<LocaleIdentifier, object>>..cctor
	|-CollectionPool<object, AsyncOperationHandle>..cctor
	|-CollectionPool<object, Color32>..cctor
	|-CollectionPool<object, int>..cctor
	|-CollectionPool<object, object>..cctor
	|-CollectionPool<object, PropertyPath>..cctor
	|-CollectionPool<object, PropertyPathPart>..cctor
	|-CollectionPool<object, UIVertex>..cctor
	|-CollectionPool<object, Vector3>..cctor
	|-CollectionPool<object, Vector4>..cctor
	|-CollectionPool<object, __Il2CppFullySharedGenericType>..cctor
	|-CollectionPool<object, DataBindingManager.BindingData>..cctor
	|-CollectionPool<object, FocusController.FocusedElement>..cctor
	|-CollectionPool<object, MultiColumnCollectionHeader.SortedColumnState>..cctor
	*/
}

// Namespace: UnityEngine.Pool
public class GenericPool<T> // TypeDefIndex: 10039
{
	// Fields
	internal static readonly ObjectPool<T> s_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102A5D0 Offset: 0x1028BD0 VA: 0x18102A5D0
	|-GenericPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(T toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102AB60 Offset: 0x1029160 VA: 0x18102AB60
	|-GenericPool<object>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102AD30 Offset: 0x1029330 VA: 0x18102AD30
	|-GenericPool<object>..cctor
	*/
}

// Namespace: UnityEngine.Pool
public interface IObjectPool<T> // TypeDefIndex: 10040
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Release(T element);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IObjectPool<object>.Release
	*/
}

// Namespace: UnityEngine.Pool
public class ObjectPool<T> : IDisposable, IObjectPool<T> // TypeDefIndex: 10041
{
	// Fields
	internal readonly List<T> m_List; // 0x0
	private readonly Func<T> m_CreateFunc; // 0x0
	private readonly Action<T> m_ActionOnGet; // 0x0
	private readonly Action<T> m_ActionOnRelease; // 0x0
	private readonly Action<T> m_ActionOnDestroy; // 0x0
	private readonly int m_MaxSize; // 0x0
	internal bool m_CollectionCheck; // 0x0
	private T m_FreshlyReleased; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <CountAll>k__BackingField; // 0x0

	// Properties
	public int CountAll { get; set; }
	public int CountInactive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_CountAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	|-ObjectPool<object>.get_CountAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_CountAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF9A0 Offset: 0x12DDFA0 VA: 0x1812DF9A0
	|-ObjectPool<object>.set_CountAll
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_CountInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF950 Offset: 0x12DDF50 VA: 0x1812DF950
	|-ObjectPool<object>.get_CountInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> createFunc, Action<T> actionOnGet, Action<T> actionOnRelease, Action<T> actionOnDestroy, bool collectionCheck = True, int defaultCapacity = 10, int maxSize = 10000) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF240 Offset: 0x12DD840 VA: 0x1812DF240
	|-ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35EB50 Offset: 0x35D150 VA: 0x18035EB50
	|-ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public PooledObject<T> Get(out T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DDD50 Offset: 0x12DC350 VA: 0x1812DDD50
	|-ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE1B0 Offset: 0x12DC7B0 VA: 0x1812DE1B0
	|-ObjectPool<object>.Release
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DD330 Offset: 0x12DB930 VA: 0x1812DD330
	|-ObjectPool<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DD7D0 Offset: 0x12DBDD0 VA: 0x1812DD7D0
	|-ObjectPool<object>.Dispose
	*/
}

// Namespace: UnityEngine.Pool
public struct PooledObject<T> : IDisposable // TypeDefIndex: 10042
{
	// Fields
	private readonly T m_ToReturn; // 0x0
	private readonly IObjectPool<T> m_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(T value, IObjectPool<T> pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x598200 Offset: 0x596800 VA: 0x180598200
	|-PooledObject<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ED1D0 Offset: 0x12EB7D0 VA: 0x1812ED1D0
	|-PooledObject<object>.System.IDisposable.Dispose
	*/
}

