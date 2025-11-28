// Namespace: System.Collections.Concurrent
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ConcurrentQueue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 1477
{
	// Fields
	private object _crossSegmentLock; // 0x0
	private ConcurrentQueue.Segment<T> _tail; // 0x0
	private ConcurrentQueue.Segment<T> _head; // 0x0

	// Properties
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD28CE0 Offset: 0xD272E0 VA: 0x180D28CE0
	|-ConcurrentQueue<object>..ctor
	|
	|-RVA: 0xD28DD0 Offset: 0xD273D0 VA: 0x180D28DD0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD283D0 Offset: 0xD269D0 VA: 0x180D283D0
	|-ConcurrentQueue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD282C0 Offset: 0xD268C0 VA: 0x180D282C0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ConcurrentQueue<object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1DA80 Offset: 0xD1C080 VA: 0x180D1DA80
	|-ConcurrentQueue<object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD284D0 Offset: 0xD26AD0 VA: 0x180D284D0
	|-ConcurrentQueue<object>.System.Collections.IEnumerable.GetEnumerator
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD288D0 Offset: 0xD26ED0 VA: 0x180D288D0
	|-ConcurrentQueue<object>.ToArray
	|
	|-RVA: 0xD28520 Offset: 0xD26B20 VA: 0x180D28520
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD29240 Offset: 0xD27840 VA: 0x180D29240
	|-ConcurrentQueue<object>.get_Count
	|
	|-RVA: 0xD28EC0 Offset: 0xD274C0 VA: 0x180D28EC0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private static int GetCount(ConcurrentQueue.Segment<T> s, int head, int tail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD27930 Offset: 0xD25F30 VA: 0x180D27930
	|-ConcurrentQueue<object>.GetCount
	|
	|-RVA: 0xD27670 Offset: 0xD25C70 VA: 0x180D27670
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetCount
	*/

	// RVA: -1 Offset: -1
	private static long GetCount(ConcurrentQueue.Segment<T> head, int headHead, ConcurrentQueue.Segment<T> tail, int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD279E0 Offset: 0xD25FE0 VA: 0x180D279E0
	|-ConcurrentQueue<object>.GetCount
	|
	|-RVA: 0xD27750 Offset: 0xD25D50 VA: 0x180D27750
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetCount
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD267F0 Offset: 0xD24DF0 VA: 0x180D267F0
	|-ConcurrentQueue<object>.CopyTo
	|
	|-RVA: 0xD26410 Offset: 0xD24A10 VA: 0x180D26410
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD27C00 Offset: 0xD26200 VA: 0x180D27C00
	|-ConcurrentQueue<object>.GetEnumerator
	|
	|-RVA: 0xD27B60 Offset: 0xD26160 VA: 0x180D27B60
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void SnapForObservation(out ConcurrentQueue.Segment<T> head, out int headHead, out ConcurrentQueue.Segment<T> tail, out int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD28140 Offset: 0xD26740 VA: 0x180D28140
	|-ConcurrentQueue<object>.SnapForObservation
	|
	|-RVA: 0xD27FA0 Offset: 0xD265A0 VA: 0x180D27FA0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.SnapForObservation
	*/

	// RVA: -1 Offset: -1
	private T GetItemWhenAvailable(ConcurrentQueue.Segment<T> segment, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD27EA0 Offset: 0xD264A0 VA: 0x180D27EA0
	|-ConcurrentQueue<object>.GetItemWhenAvailable
	|
	|-RVA: 0xD27C90 Offset: 0xD26290 VA: 0x180D27C90
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetItemWhenAvailable
	*/

	[IteratorStateMachine(typeof(ConcurrentQueue.<Enumerate>d__28<T>))]
	// RVA: -1 Offset: -1
	private IEnumerator<T> Enumerate(ConcurrentQueue.Segment<T> head, int headHead, ConcurrentQueue.Segment<T> tail, int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD27590 Offset: 0xD25B90 VA: 0x180D27590
	|-ConcurrentQueue<object>.Enumerate
	|
	|-RVA: 0xD27360 Offset: 0xD25960 VA: 0x180D27360
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.Enumerate
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD272D0 Offset: 0xD258D0 VA: 0x180D272D0
	|-ConcurrentQueue<object>.Enqueue
	|
	|-RVA: 0xD27140 Offset: 0xD25740 VA: 0x180D27140
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	private void EnqueueSlow(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD26C30 Offset: 0xD25230 VA: 0x180D26C30
	|-ConcurrentQueue<object>.EnqueueSlow
	|
	|-RVA: 0xD26E40 Offset: 0xD25440 VA: 0x180D26E40
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.EnqueueSlow
	*/
}

// Namespace: System.Collections.Concurrent
[DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
internal struct PaddedHeadAndTail // TypeDefIndex: 1478
{
	// Fields
	public int Head; // 0x80
	public int Tail; // 0x100
}

// Namespace: System.Collections.Concurrent
[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
internal sealed class CDSCollectionETWBCLProvider : EventSource // TypeDefIndex: 1479
{
	// Fields
	public static CDSCollectionETWBCLProvider Log; // 0x0

	// Methods

	// RVA: 0x14A3B90 Offset: 0x14A2190 VA: 0x1814A3B90
	private void .ctor() { }

	[Event(3, Level = 3)]
	// RVA: 0x5EFE00 Offset: 0x5EE400 VA: 0x1805EFE00
	public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets) { }

	// RVA: 0x14A3AE0 Offset: 0x14A20E0 VA: 0x1814A3AE0
	private static void .cctor() { }
}

// Namespace: System.Collections.Concurrent
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<K, V>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 1484
{
	// Fields
	private ConcurrentDictionary.Tables<TKey, TValue> _tables; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0
	private readonly bool _growLockArray; // 0x0
	private int _budget; // 0x0
	private KeyValuePair<TKey, TValue>[] _serializationArray; // 0x0
	private int _serializationConcurrencyLevel; // 0x0
	private int _serializationCapacity; // 0x0
	private static readonly bool s_isValueWriteAtomic; // 0x0

	// Properties
	public TValue Item { get; set; }
	public int Count { get; }
	public ICollection<TKey> Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public ICollection<TValue> Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private static int DefaultConcurrencyLevel { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static bool IsValueWriteAtomic() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1A5F0 Offset: 0xD18BF0 VA: 0x180D1A5F0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.IsValueWriteAtomic
	|-ConcurrentDictionary<object, object>.IsValueWriteAtomic
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsValueWriteAtomic
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD24F90 Offset: 0xD23590 VA: 0x180D24F90
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0xD246E0 Offset: 0xD22CE0 VA: 0x180D246E0
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0xD24EF0 Offset: 0xD234F0 VA: 0x180D24EF0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD25420 Offset: 0xD23A20 VA: 0x180D25420
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0xD24850 Offset: 0xD22E50 VA: 0x180D24850
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0xD247A0 Offset: 0xD22DA0 VA: 0x180D247A0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1A2C0 Offset: 0xD188C0 VA: 0x180D1A2C0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.InitializeFromCollection
	|
	|-RVA: 0xD19940 Offset: 0xD17F40 VA: 0x180D19940
	|-ConcurrentDictionary<object, object>.InitializeFromCollection
	|
	|-RVA: 0xD19C90 Offset: 0xD18290 VA: 0x180D19C90
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InitializeFromCollection
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD25050 Offset: 0xD23650 VA: 0x180D25050
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0xD24C00 Offset: 0xD23200 VA: 0x180D24C00
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0xD24910 Offset: 0xD22F10 VA: 0x180D24910
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD21F80 Offset: 0xD20580 VA: 0x180D21F80
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryAdd
	|
	|-RVA: 0xD220D0 Offset: 0xD206D0 VA: 0x180D220D0
	|-ConcurrentDictionary<object, object>.TryAdd
	|
	|-RVA: 0xD221D0 Offset: 0xD207D0 VA: 0x180D221D0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD146E0 Offset: 0xD12CE0 VA: 0x180D146E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ContainsKey
	|
	|-RVA: 0xD14900 Offset: 0xD12F00 VA: 0x180D14900
	|-ConcurrentDictionary<object, object>.ContainsKey
	|
	|-RVA: 0xD14720 Offset: 0xD12D20 VA: 0x180D14720
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool TryRemove(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD24220 Offset: 0xD22820 VA: 0x180D24220
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryRemove
	|
	|-RVA: 0xD241A0 Offset: 0xD227A0 VA: 0x180D241A0
	|-ConcurrentDictionary<object, object>.TryRemove
	|
	|-RVA: 0xD24260 Offset: 0xD22860 VA: 0x180D24260
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemove
	*/

	// RVA: -1 Offset: -1
	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD230B0 Offset: 0xD216B0 VA: 0x180D230B0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryRemoveInternal
	|
	|-RVA: 0xD23D80 Offset: 0xD22380 VA: 0x180D23D80
	|-ConcurrentDictionary<object, object>.TryRemoveInternal
	|
	|-RVA: 0xD235D0 Offset: 0xD21BD0 VA: 0x180D235D0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemoveInternal
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD22C20 Offset: 0xD21220 VA: 0x180D22C20
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryGetValue
	|
	|-RVA: 0xD22FB0 Offset: 0xD215B0 VA: 0x180D22FB0
	|-ConcurrentDictionary<object, object>.TryGetValue
	|
	|-RVA: 0xD22D50 Offset: 0xD21350 VA: 0x180D22D50
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD22540 Offset: 0xD20B40 VA: 0x180D22540
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryGetValueInternal
	|
	|-RVA: 0xD22720 Offset: 0xD20D20 VA: 0x180D22720
	|-ConcurrentDictionary<object, object>.TryGetValueInternal
	|
	|-RVA: 0xD22870 Offset: 0xD20E70 VA: 0x180D22870
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValueInternal
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD14450 Offset: 0xD12A50 VA: 0x180D14450
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.Clear
	|
	|-RVA: 0xD13EC0 Offset: 0xD124C0 VA: 0x180D13EC0
	|-ConcurrentDictionary<object, object>.Clear
	|
	|-RVA: 0xD14150 Offset: 0xD12750 VA: 0x180D14150
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1B650 Offset: 0xD19C50 VA: 0x180D1B650
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0xD1B8B0 Offset: 0xD19EB0 VA: 0x180D1B8B0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0xD1BBE0 Offset: 0xD1A1E0 VA: 0x180D1BBE0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<TKey, TValue>[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1FEA0 Offset: 0xD1E4A0 VA: 0x180D1FEA0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ToArray
	|
	|-RVA: 0xD1FC00 Offset: 0xD1E200 VA: 0x180D1FC00
	|-ConcurrentDictionary<object, object>.ToArray
	|
	|-RVA: 0xD20140 Offset: 0xD1E740 VA: 0x180D20140
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD158E0 Offset: 0xD13EE0 VA: 0x180D158E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToPairs
	|
	|-RVA: 0xD15A20 Offset: 0xD14020 VA: 0x180D15A20
	|-ConcurrentDictionary<object, object>.CopyToPairs
	|
	|-RVA: 0xD15540 Offset: 0xD13B40 VA: 0x180D15540
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToPairs
	*/

	// RVA: -1 Offset: -1
	private void CopyToEntries(DictionaryEntry[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD14A00 Offset: 0xD13000 VA: 0x180D14A00
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToEntries
	|
	|-RVA: 0xD14B30 Offset: 0xD13130 VA: 0x180D14B30
	|-ConcurrentDictionary<object, object>.CopyToEntries
	|
	|-RVA: 0xD14C40 Offset: 0xD13240 VA: 0x180D14C40
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToEntries
	*/

	// RVA: -1 Offset: -1
	private void CopyToObjects(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD153A0 Offset: 0xD139A0 VA: 0x180D153A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToObjects
	|
	|-RVA: 0xD14EA0 Offset: 0xD134A0 VA: 0x180D14EA0
	|-ConcurrentDictionary<object, object>.CopyToObjects
	|
	|-RVA: 0xD15020 Offset: 0xD13620 VA: 0x180D15020
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToObjects
	*/

	[IteratorStateMachine(typeof(ConcurrentDictionary.<GetEnumerator>d__35<TKey, TValue>))]
	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15C20 Offset: 0xD14220 VA: 0x180D15C20
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetEnumerator
	|
	|-RVA: 0x99C950 Offset: 0x99AF50 VA: 0x18099C950
	|-ConcurrentDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x99C880 Offset: 0x99AE80 VA: 0x18099C880
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD20B80 Offset: 0xD1F180 VA: 0x180D20B80
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryAddInternal
	|
	|-RVA: 0xD20450 Offset: 0xD1EA50 VA: 0x180D20450
	|-ConcurrentDictionary<object, object>.TryAddInternal
	|
	|-RVA: 0xD21330 Offset: 0xD1F930 VA: 0x180D21330
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAddInternal
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD25890 Offset: 0xD23E90 VA: 0x180D25890
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Item
	|
	|-RVA: 0xD25960 Offset: 0xD23F60 VA: 0x180D25960
	|-ConcurrentDictionary<object, object>.get_Item
	|
	|-RVA: 0xD25AB0 Offset: 0xD240B0 VA: 0x180D25AB0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD25CD0 Offset: 0xD242D0 VA: 0x180D25CD0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.set_Item
	|
	|-RVA: 0xD25E20 Offset: 0xD24420 VA: 0x180D25E20
	|-ConcurrentDictionary<object, object>.set_Item
	|
	|-RVA: 0xD25F20 Offset: 0xD24520 VA: 0x180D25F20
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNotFoundException(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1FB30 Offset: 0xD1E130 VA: 0x180D1FB30
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<object, object>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowKeyNotFoundException
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNullException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1FBB0 Offset: 0xD1E1B0 VA: 0x180D1FBB0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ThrowKeyNullException
	|-ConcurrentDictionary<object, object>.ThrowKeyNullException
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowKeyNullException
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD255C0 Offset: 0xD23BC0 VA: 0x180D255C0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Count
	|
	|-RVA: 0xD254E0 Offset: 0xD23AE0 VA: 0x180D254E0
	|-ConcurrentDictionary<object, object>.get_Count
	|
	|-RVA: 0xD256A0 Offset: 0xD23CA0 VA: 0x180D256A0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private int GetCountInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15B70 Offset: 0xD14170 VA: 0x180D15B70
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetCountInternal
	|-ConcurrentDictionary<object, object>.GetCountInternal
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetCountInternal
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD16760 Offset: 0xD14D60 VA: 0x180D16760
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetOrAdd
	|
	|-RVA: 0xD17420 Offset: 0xD15A20 VA: 0x180D17420
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|
	|-RVA: 0xD16AE0 Offset: 0xD150E0 VA: 0x180D16AE0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD16950 Offset: 0xD14F50 VA: 0x180D16950
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetOrAdd
	|
	|-RVA: 0xD16620 Offset: 0xD14C20 VA: 0x180D16620
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|
	|-RVA: 0xD16FD0 Offset: 0xD155D0 VA: 0x180D16FD0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOrAdd
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1C400 Offset: 0xD1AA00 VA: 0x180D1C400
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0xD1C5A0 Offset: 0xD1ABA0 VA: 0x180D1C5A0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0xD1C230 Offset: 0xD1A830 VA: 0x180D1C230
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1C8D0 Offset: 0xD1AED0 VA: 0x180D1C8D0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0xD1C700 Offset: 0xD1AD00 VA: 0x180D1C700
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0xD1C790 Offset: 0xD1AD90 VA: 0x180D1C790
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1C980 Offset: 0xD1AF80 VA: 0x180D1C980
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Keys
	|
	|-RVA: 0xD1C930 Offset: 0xD1AF30 VA: 0x180D1C930
	|-ConcurrentDictionary<object, object>.get_Keys
	|
	|-RVA: 0xD1C950 Offset: 0xD1AF50 VA: 0x180D1C950
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1C980 Offset: 0xD1AF80 VA: 0x180D1C980
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xD1C930 Offset: 0xD1AF30 VA: 0x180D1C930
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xD1C950 Offset: 0xD1AF50 VA: 0x180D1C950
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1C9A0 Offset: 0xD1AFA0 VA: 0x180D1C9A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Values
	|
	|-RVA: 0xD1C9F0 Offset: 0xD1AFF0 VA: 0x180D1C9F0
	|-ConcurrentDictionary<object, object>.get_Values
	|
	|-RVA: 0xD1C9C0 Offset: 0xD1AFC0 VA: 0x180D1C9C0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1C9A0 Offset: 0xD1AFA0 VA: 0x180D1C9A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xD1C9F0 Offset: 0xD1AFF0 VA: 0x180D1C9F0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xD1C9C0 Offset: 0xD1AFC0 VA: 0x180D1C9C0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1AF40 Offset: 0xD19540 VA: 0x180D1AF40
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xD1B010 Offset: 0xD19610 VA: 0x180D1B010
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xD1B080 Offset: 0xD19680 VA: 0x180D1B080
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1B5B0 Offset: 0xD19BB0 VA: 0x180D1B5B0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xD1B460 Offset: 0xD19A60 VA: 0x180D1B460
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xD1B210 Offset: 0xD19810 VA: 0x180D1B210
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1BED0 Offset: 0xD1A4D0 VA: 0x180D1BED0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xD1BF20 Offset: 0xD1A520 VA: 0x180D1BF20
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xD1BFD0 Offset: 0xD1A5D0 VA: 0x180D1BFD0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1F9F0 Offset: 0xD1DFF0 VA: 0x180D1F9F0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD1FA90 Offset: 0xD1E090 VA: 0x180D1FA90
	|-ConcurrentDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD1F9C0 Offset: 0xD1DFC0 VA: 0x180D1F9C0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1DDD0 Offset: 0xD1C3D0 VA: 0x180D1DDD0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xD1E060 Offset: 0xD1C660 VA: 0x180D1E060
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xD1DAD0 Offset: 0xD1C0D0 VA: 0x180D1DAD0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1E580 Offset: 0xD1CB80 VA: 0x180D1E580
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xD1E280 Offset: 0xD1C880 VA: 0x180D1E280
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xD1E400 Offset: 0xD1CA00 VA: 0x180D1E400
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1E7B0 Offset: 0xD1CDB0 VA: 0x180D1E7B0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xD1E730 Offset: 0xD1CD30 VA: 0x180D1E730
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xD1E6B0 Offset: 0xD1CCB0 VA: 0x180D1E6B0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1C980 Offset: 0xD1AF80 VA: 0x180D1C980
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xD1C930 Offset: 0xD1AF30 VA: 0x180D1C930
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xD1C950 Offset: 0xD1AF50 VA: 0x180D1C950
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1E960 Offset: 0xD1CF60 VA: 0x180D1E960
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xD1E830 Offset: 0xD1CE30 VA: 0x180D1E830
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xD1EAA0 Offset: 0xD1D0A0 VA: 0x180D1EAA0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1C9A0 Offset: 0xD1AFA0 VA: 0x180D1C9A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xD1C9F0 Offset: 0xD1AFF0 VA: 0x180D1C9F0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xD1C9C0 Offset: 0xD1AFC0 VA: 0x180D1C9C0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1EC60 Offset: 0xD1D260 VA: 0x180D1EC60
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xD1EFA0 Offset: 0xD1D5A0 VA: 0x180D1EFA0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xD1ED80 Offset: 0xD1D380 VA: 0x180D1ED80
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1F120 Offset: 0xD1D720 VA: 0x180D1F120
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xD1F460 Offset: 0xD1DA60 VA: 0x180D1F460
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xD1F700 Offset: 0xD1DD00 VA: 0x180D1F700
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1CF10 Offset: 0xD1B510 VA: 0x180D1CF10
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD1D500 Offset: 0xD1BB00 VA: 0x180D1D500
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD1CA10 Offset: 0xD1B010 VA: 0x180D1CA10
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1DA80 Offset: 0xD1C080 VA: 0x180D1DA80
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	private void GrowTable(ConcurrentDictionary.Tables<TKey, TValue> tables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD17F20 Offset: 0xD16520 VA: 0x180D17F20
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GrowTable
	|
	|-RVA: 0xD186F0 Offset: 0xD16CF0 VA: 0x180D186F0
	|-ConcurrentDictionary<object, object>.GrowTable
	|
	|-RVA: 0xD18EB0 Offset: 0xD174B0 VA: 0x180D18EB0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GrowTable
	*/

	// RVA: -1 Offset: -1
	private static int GetBucket(int hashcode, int bucketCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15B60 Offset: 0xD14160 VA: 0x180D15B60
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetBucket
	|-ConcurrentDictionary<object, object>.GetBucket
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucket
	*/

	// RVA: -1 Offset: -1
	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15B40 Offset: 0xD14140 VA: 0x180D15B40
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetBucketAndLockNo
	|-ConcurrentDictionary<object, object>.GetBucketAndLockNo
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucketAndLockNo
	*/

	// RVA: -1 Offset: -1
	private static int get_DefaultConcurrencyLevel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD257D0 Offset: 0xD23DD0 VA: 0x180D257D0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0xD25810 Offset: 0xD23E10 VA: 0x180D25810
	|-ConcurrentDictionary<object, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0xD25850 Offset: 0xD23E50 VA: 0x180D25850
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_DefaultConcurrencyLevel
	*/

	// RVA: -1 Offset: -1
	private void AcquireAllLocks(ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13AF0 Offset: 0xD120F0 VA: 0x180D13AF0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AcquireAllLocks
	|
	|-RVA: 0xD13C60 Offset: 0xD12260 VA: 0x180D13C60
	|-ConcurrentDictionary<object, object>.AcquireAllLocks
	|
	|-RVA: 0xD13990 Offset: 0xD11F90 VA: 0x180D13990
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AcquireAllLocks
	*/

	// RVA: -1 Offset: -1
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13DD0 Offset: 0xD123D0 VA: 0x180D13DD0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AcquireLocks
	|-ConcurrentDictionary<object, object>.AcquireLocks
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AcquireLocks
	*/

	// RVA: -1 Offset: -1
	private void ReleaseLocks(int fromInclusive, int toExclusive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1AEC0 Offset: 0xD194C0 VA: 0x180D1AEC0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ReleaseLocks
	|-ConcurrentDictionary<object, object>.ReleaseLocks
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReleaseLocks
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TKey> GetKeys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD16370 Offset: 0xD14970 VA: 0x180D16370
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetKeys
	|
	|-RVA: 0xD160D0 Offset: 0xD146D0 VA: 0x180D160D0
	|-ConcurrentDictionary<object, object>.GetKeys
	|
	|-RVA: 0xD15CB0 Offset: 0xD142B0 VA: 0x180D15CB0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeys
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TValue> GetValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD17C80 Offset: 0xD16280 VA: 0x180D17C80
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetValues
	|
	|-RVA: 0xD175B0 Offset: 0xD15BB0 VA: 0x180D175B0
	|-ConcurrentDictionary<object, object>.GetValues
	|
	|-RVA: 0xD17850 Offset: 0xD15E50 VA: 0x180D17850
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValues
	*/

	[OnSerializing]
	// RVA: -1 Offset: -1
	private void OnSerializing(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1AD90 Offset: 0xD19390 VA: 0x180D1AD90
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnSerializing
	|
	|-RVA: 0xD1AD00 Offset: 0xD19300 VA: 0x180D1AD00
	|-ConcurrentDictionary<object, object>.OnSerializing
	|
	|-RVA: 0xD1AE20 Offset: 0xD19420 VA: 0x180D1AE20
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnSerializing
	*/

	[OnSerialized]
	// RVA: -1 Offset: -1
	private void OnSerialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1ACE0 Offset: 0xD192E0 VA: 0x180D1ACE0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnSerialized
	|-ConcurrentDictionary<object, object>.OnSerialized
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnSerialized
	*/

	[OnDeserialized]
	// RVA: -1 Offset: -1
	private void OnDeserialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD1AAE0 Offset: 0xD190E0 VA: 0x180D1AAE0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnDeserialized
	|
	|-RVA: 0xD1A6E0 Offset: 0xD18CE0 VA: 0x180D1A6E0
	|-ConcurrentDictionary<object, object>.OnDeserialized
	|
	|-RVA: 0xD1A8E0 Offset: 0xD18EE0 VA: 0x180D1A8E0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnDeserialized
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD244C0 Offset: 0xD22AC0 VA: 0x180D244C0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..cctor
	|-ConcurrentDictionary<object, object>..cctor
	|
	|-RVA: 0xD24620 Offset: 0xD22C20 VA: 0x180D24620
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Concurrent
internal sealed class IDictionaryDebugView<K, V> // TypeDefIndex: 1485
{}

// Namespace: System.Collections.Concurrent
internal sealed class IProducerConsumerCollectionDebugView<T> // TypeDefIndex: 1486
{}

