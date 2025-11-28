// Namespace: System.Collections
[Serializable]
public sealed class Comparer : IComparer, ISerializable // TypeDefIndex: 1424
{
	// Fields
	private CompareInfo _compareInfo; // 0x10
	public static readonly Comparer Default; // 0x0
	public static readonly Comparer DefaultInvariant; // 0x8

	// Methods

	// RVA: 0x14A5380 Offset: 0x14A3980 VA: 0x1814A5380
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x14A51F0 Offset: 0x14A37F0 VA: 0x1814A51F0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A4F70 Offset: 0x14A3570 VA: 0x1814A4F70 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A4DD0 Offset: 0x14A33D0 VA: 0x1814A4DD0 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x14A5010 Offset: 0x14A3610 VA: 0x1814A5010
	private static void .cctor() { }
}

// Namespace: System.Collections
[Serializable]
public struct DictionaryEntry // TypeDefIndex: 1425
{
	// Fields
	private object _key; // 0x0
	private object _value; // 0x8

	// Properties
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x598200 Offset: 0x596800 VA: 0x180598200
	public void .ctor(object key, object value) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public object get_Key() { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public object get_Value() { }
}

// Namespace: System.Collections
internal static class HashHelpers // TypeDefIndex: 1426
{
	// Fields
	public static readonly int[] primes; // 0x0
	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable; // 0x8

	// Properties
	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }

	// Methods

	// RVA: 0x14A6570 Offset: 0x14A4B70 VA: 0x1814A6570
	public static bool IsPrime(int candidate) { }

	// RVA: 0x14A6350 Offset: 0x14A4950 VA: 0x1814A6350
	public static int GetPrime(int min) { }

	// RVA: 0x14A62D0 Offset: 0x14A48D0 VA: 0x1814A62D0
	public static int ExpandPrime(int oldSize) { }

	// RVA: 0x14A66B0 Offset: 0x14A4CB0 VA: 0x1814A66B0
	internal static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	// RVA: 0x14A6620 Offset: 0x14A4C20 VA: 0x1814A6620
	private static void .cctor() { }
}

// Namespace: System.Collections
public interface ICollection : IEnumerable // TypeDefIndex: 1427
{
	// Properties
	public abstract int Count { get; }
	public abstract object SyncRoot { get; }
	public abstract bool IsSynchronized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CopyTo(Array array, int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_SyncRoot();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsSynchronized();
}

// Namespace: System.Collections
public interface IComparer // TypeDefIndex: 1428
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Compare(object x, object y);
}

// Namespace: System.Collections
[DefaultMember("Item")]
public interface IDictionary : ICollection, IEnumerable // TypeDefIndex: 1429
{
	// Properties
	public abstract object Item { get; set; }
	public abstract ICollection Keys { get; }
	public abstract ICollection Values { get; }
	public abstract bool IsReadOnly { get; }
	public abstract bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(object key);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(object key, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection get_Keys();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ICollection get_Values();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Contains(object key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Add(object key, object value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_IsFixedSize();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IDictionaryEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Remove(object key);
}

// Namespace: System.Collections
public interface IDictionaryEnumerator : IEnumerator // TypeDefIndex: 1430
{
	// Properties
	public abstract object Key { get; }
	public abstract object Value { get; }
	public abstract DictionaryEntry Entry { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DictionaryEntry get_Entry();
}

// Namespace: System.Collections
public interface IEnumerable // TypeDefIndex: 1431
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerator GetEnumerator();
}

// Namespace: System.Collections
public interface IEnumerator // TypeDefIndex: 1432
{
	// Properties
	public abstract object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Reset();
}

// Namespace: System.Collections
public interface IEqualityComparer // TypeDefIndex: 1433
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(object x, object y);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(object obj);
}

// Namespace: System.Collections
[DefaultMember("Item")]
public interface IList : ICollection, IEnumerable // TypeDefIndex: 1434
{
	// Properties
	public abstract object Item { get; set; }
	public abstract bool IsReadOnly { get; }
	public abstract bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int Add(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Contains(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsFixedSize();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int IndexOf(object value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Insert(int index, object value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Remove(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void RemoveAt(int index);
}

// Namespace: System.Collections
public interface IStructuralComparable // TypeDefIndex: 1435
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(object other, IComparer comparer);
}

// Namespace: System.Collections
public interface IStructuralEquatable // TypeDefIndex: 1436
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(object other, IEqualityComparer comparer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(IEqualityComparer comparer);
}

// Namespace: System.Collections
[DefaultMember("Item")]
[Serializable]
internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable // TypeDefIndex: 1441
{
	// Fields
	private ListDictionaryInternal.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public object Item { get; set; }
	public int Count { get; }
	public ICollection Keys { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x14AD940 Offset: 0x14ABF40 VA: 0x1814AD940 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x14ADB60 Offset: 0x14AC160 VA: 0x1814ADB60 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30 Slot: 16
	public int get_Count() { }

	// RVA: 0x14ADA10 Offset: 0x14AC010 VA: 0x1814ADA10 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 12
	public bool get_IsFixedSize() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x14ADA80 Offset: 0x14AC080 VA: 0x1814ADA80 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x14ADAF0 Offset: 0x14AC0F0 VA: 0x1814ADAF0 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x14AD1D0 Offset: 0x14AB7D0 VA: 0x1814AD1D0 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x14AD3B0 Offset: 0x14AB9B0 VA: 0x1814AD3B0 Slot: 10
	public void Clear() { }

	// RVA: 0x14AD3E0 Offset: 0x14AB9E0 VA: 0x1814AD3E0 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x14AD4B0 Offset: 0x14ABAB0 VA: 0x1814AD4B0 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x14AD700 Offset: 0x14ABD00 VA: 0x1814AD700 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x14AD8B0 Offset: 0x14ABEB0 VA: 0x1814AD8B0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14AD790 Offset: 0x14ABD90 VA: 0x1814AD790 Slot: 14
	public void Remove(object key) { }
}

// Namespace: System.Collections
[Serializable]
internal sealed class CompatibleComparer : IEqualityComparer // TypeDefIndex: 1442
{
	// Fields
	private readonly IHashCodeProvider _hcp; // 0x10
	private readonly IComparer _comparer; // 0x18

	// Properties
	internal IHashCodeProvider HashCodeProvider { get; }
	internal IComparer Comparer { get; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	internal void .ctor(IHashCodeProvider hashCodeProvider, IComparer comparer) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal IComparer get_Comparer() { }

	// RVA: 0x14A55E0 Offset: 0x14A3BE0 VA: 0x1814A55E0 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x14A5420 Offset: 0x14A3A20 VA: 0x1814A5420
	public int Compare(object a, object b) { }

	// RVA: 0x14A5770 Offset: 0x14A3D70 VA: 0x1814A5770 Slot: 5
	public int GetHashCode(object obj) { }
}

// Namespace: System.Collections
[Serializable]
public class CaseInsensitiveComparer : IComparer // TypeDefIndex: 1443
{
	// Fields
	private CompareInfo _compareInfo; // 0x10

	// Properties
	public static CaseInsensitiveComparer Default { get; }

	// Methods

	// RVA: 0x14A3E30 Offset: 0x14A2430 VA: 0x1814A3E30
	public void .ctor() { }

	// RVA: 0x14A3EC0 Offset: 0x14A24C0 VA: 0x1814A3EC0
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x14A3F60 Offset: 0x14A2560 VA: 0x1814A3F60
	public static CaseInsensitiveComparer get_Default() { }

	// RVA: 0x14A3BF0 Offset: 0x14A21F0 VA: 0x1814A3BF0 Slot: 4
	public int Compare(object a, object b) { }
}

// Namespace: System.Collections
[Obsolete("Please use StringComparer instead.")]
[Serializable]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider // TypeDefIndex: 1444
{
	// Fields
	private readonly CompareInfo _compareInfo; // 0x10

	// Properties
	public static CaseInsensitiveHashCodeProvider Default { get; }

	// Methods

	// RVA: 0x14A4110 Offset: 0x14A2710 VA: 0x1814A4110
	public void .ctor() { }

	// RVA: 0x14A41A0 Offset: 0x14A27A0 VA: 0x1814A41A0
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x14A4240 Offset: 0x14A2840 VA: 0x1814A4240
	public static CaseInsensitiveHashCodeProvider get_Default() { }

	// RVA: 0x14A4050 Offset: 0x14A2650 VA: 0x1814A4050 Slot: 4
	public int GetHashCode(object obj) { }
}

// Namespace: System.Collections
[Serializable]
public abstract class CollectionBase : IList, ICollection, IEnumerable // TypeDefIndex: 1445
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	protected IList List { get; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x14A4D00 Offset: 0x14A3300 VA: 0x1814A4D00
	protected void .ctor() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	protected ArrayList get_InnerList() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	protected IList get_List() { }

	// RVA: 0x14A4DA0 Offset: 0x14A33A0 VA: 0x1814A4DA0 Slot: 16
	public int get_Count() { }

	// RVA: 0x14A42F0 Offset: 0x14A28F0 VA: 0x1814A42F0 Slot: 8
	public void Clear() { }

	// RVA: 0x14A43B0 Offset: 0x14A29B0 VA: 0x1814A43B0 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x14A4A30 Offset: 0x14A3030 VA: 0x1814A4A30 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x14A4A00 Offset: 0x14A3000 VA: 0x1814A4A00 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x140B6D0 Offset: 0x1409CD0 VA: 0x18140B6D0 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x14A4580 Offset: 0x14A2B80 VA: 0x1814A4580 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x14A4550 Offset: 0x14A2B50 VA: 0x1814A4550 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14A4A60 Offset: 0x14A3060 VA: 0x1814A4A60 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x14A4B30 Offset: 0x14A3130 VA: 0x1814A4B30 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x14A46C0 Offset: 0x14A2CC0 VA: 0x1814A46C0 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x14A45B0 Offset: 0x14A2BB0 VA: 0x1814A45B0 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x14A48A0 Offset: 0x14A2EA0 VA: 0x1814A48A0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x14A46F0 Offset: 0x14A2CF0 VA: 0x1814A46F0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x14A4720 Offset: 0x14A2D20 VA: 0x1814A4720 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x131AB70 Offset: 0x1319170 VA: 0x18131AB70 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 21
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 22
	protected virtual void OnClear() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 23
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x14A4350 Offset: 0x14A2950 VA: 0x1814A4350 Slot: 24
	protected virtual void OnValidate(object value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 25
	protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 26
	protected virtual void OnInsertComplete(int index, object value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 27
	protected virtual void OnClearComplete() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 28
	protected virtual void OnRemoveComplete(int index, object value) { }
}

// Namespace: System.Collections
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(Queue.QueueDebugView))]
[Serializable]
public class Queue : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1448
{
	// Fields
	private object[] _array; // 0x10
	private int _head; // 0x18
	private int _tail; // 0x1C
	private int _size; // 0x20
	private int _growFactor; // 0x24
	private int _version; // 0x28
	private object _syncRoot; // 0x30

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x14AF6A0 Offset: 0x14ADCA0 VA: 0x1814AF6A0
	public void .ctor() { }

	// RVA: 0x14AF690 Offset: 0x14ADC90 VA: 0x1814AF690
	public void .ctor(int capacity) { }

	// RVA: 0x14AF2B0 Offset: 0x14AD8B0 VA: 0x1814AF2B0
	public void .ctor(int capacity, float growFactor) { }

	// RVA: 0x14AF460 Offset: 0x14ADA60 VA: 0x1814AF460
	public void .ctor(ICollection col) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x14AE9F0 Offset: 0x14ACFF0 VA: 0x1814AE9F0 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 12
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x14AF6C0 Offset: 0x14ADCC0 VA: 0x1814AF6C0 Slot: 13
	public virtual object get_SyncRoot() { }

	// RVA: 0x14AEB00 Offset: 0x14AD100 VA: 0x1814AEB00 Slot: 14
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x14AEE40 Offset: 0x14AD440 VA: 0x1814AEE40 Slot: 15
	public virtual void Enqueue(object obj) { }

	// RVA: 0x14AF060 Offset: 0x14AD660 VA: 0x1814AF060 Slot: 16
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x14AED50 Offset: 0x14AD350 VA: 0x1814AED50 Slot: 17
	public virtual object Dequeue() { }

	// RVA: 0x14AF110 Offset: 0x14AD710 VA: 0x1814AF110 Slot: 18
	public virtual object Peek() { }

	// RVA: 0x14AF020 Offset: 0x14AD620 VA: 0x1814AF020
	internal object GetElement(int i) { }

	// RVA: 0x14AF1B0 Offset: 0x14AD7B0 VA: 0x1814AF1B0
	private void SetCapacity(int capacity) { }
}

// Namespace: System.Collections
[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1449
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	public virtual int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x14AFFE0 Offset: 0x14AE5E0 VA: 0x1814AFFE0
	protected ArrayList get_InnerList() { }

	// RVA: 0x14AFFA0 Offset: 0x14AE5A0 VA: 0x1814AFFA0 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x14AFF20 Offset: 0x14AE520 VA: 0x1814AFF20 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x14AFF60 Offset: 0x14AE560 VA: 0x1814AFF60 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x14AFED0 Offset: 0x14AE4D0 VA: 0x1814AFED0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14AFE90 Offset: 0x14AE490 VA: 0x1814AFE90 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Collections
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(SortedList.SortedListDebugView))]
[DefaultMember("Item")]
[Serializable]
public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1455
{
	// Fields
	private object[] keys; // 0x10
	private object[] values; // 0x18
	private int _size; // 0x20
	private int version; // 0x24
	private IComparer comparer; // 0x28
	private SortedList.KeyList keyList; // 0x30
	private SortedList.ValueList valueList; // 0x38
	private object _syncRoot; // 0x40

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x14B1F80 Offset: 0x14B0580 VA: 0x1814B1F80
	public void .ctor() { }

	// RVA: 0x14B1920 Offset: 0x14AFF20 VA: 0x1814B1920
	private void Init() { }

	// RVA: 0x14B20E0 Offset: 0x14B06E0 VA: 0x1814B20E0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x14B1F40 Offset: 0x14B0540 VA: 0x1814B1F40
	public void .ctor(IComparer comparer) { }

	// RVA: 0x14B0F30 Offset: 0x14AF530 VA: 0x1814B0F30 Slot: 21
	public virtual void Add(object key, object value) { }

	// RVA: 0x14B23B0 Offset: 0x14B09B0 VA: 0x1814B23B0 Slot: 22
	public virtual void set_Capacity(int value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 23
	public virtual int get_Count() { }

	// RVA: 0x14B2300 Offset: 0x14B0900 VA: 0x1814B2300 Slot: 24
	public virtual ICollection get_Keys() { }

	// RVA: 0x14B2390 Offset: 0x14B0990 VA: 0x1814B2390 Slot: 25
	public virtual ICollection get_Values() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 26
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 27
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 28
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x14B2320 Offset: 0x14B0920 VA: 0x1814B2320 Slot: 29
	public virtual object get_SyncRoot() { }

	// RVA: 0x14B1070 Offset: 0x14AF670 VA: 0x1814B1070 Slot: 30
	public virtual void Clear() { }

	// RVA: 0x14B10B0 Offset: 0x14AF6B0 VA: 0x1814B10B0 Slot: 31
	public virtual object Clone() { }

	// RVA: 0x14B1180 Offset: 0x14AF780 VA: 0x1814B1180 Slot: 32
	public virtual bool Contains(object key) { }

	// RVA: 0x14B1180 Offset: 0x14AF780 VA: 0x1814B1180 Slot: 33
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x14B11B0 Offset: 0x14AF7B0 VA: 0x1814B11B0 Slot: 34
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x14B11E0 Offset: 0x14AF7E0 VA: 0x1814B11E0 Slot: 35
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14B14D0 Offset: 0x14AFAD0 VA: 0x1814B14D0
	private void EnsureCapacity(int min) { }

	// RVA: 0x14B1520 Offset: 0x14AFB20 VA: 0x1814B1520 Slot: 36
	public virtual object GetByIndex(int index) { }

	// RVA: 0x14B1EB0 Offset: 0x14B04B0 VA: 0x1814B1EB0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14B15D0 Offset: 0x14AFBD0 VA: 0x1814B15D0 Slot: 37
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x14B16E0 Offset: 0x14AFCE0 VA: 0x1814B16E0 Slot: 38
	public virtual object GetKey(int index) { }

	// RVA: 0x14B1660 Offset: 0x14AFC60 VA: 0x1814B1660 Slot: 39
	public virtual IList GetKeyList() { }

	// RVA: 0x14B1790 Offset: 0x14AFD90 VA: 0x1814B1790 Slot: 40
	public virtual IList GetValueList() { }

	// RVA: 0x14B22B0 Offset: 0x14B08B0 VA: 0x1814B22B0 Slot: 41
	public virtual object get_Item(object key) { }

	// RVA: 0x14B2560 Offset: 0x14B0B60 VA: 0x1814B2560 Slot: 42
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x14B1810 Offset: 0x14AFE10 VA: 0x1814B1810 Slot: 43
	public virtual int IndexOfKey(object key) { }

	// RVA: 0x14B18C0 Offset: 0x14AFEC0 VA: 0x1814B18C0 Slot: 44
	public virtual int IndexOfValue(object value) { }

	// RVA: 0x14B1A80 Offset: 0x14B0080 VA: 0x1814B1A80
	private void Insert(int index, object key, object value) { }

	// RVA: 0x14B1C20 Offset: 0x14B0220 VA: 0x1814B1C20 Slot: 45
	public virtual void RemoveAt(int index) { }

	// RVA: 0x14B1D80 Offset: 0x14B0380 VA: 0x1814B1D80 Slot: 46
	public virtual void Remove(object key) { }

	// RVA: 0x14B1DD0 Offset: 0x14B03D0 VA: 0x1814B1DD0
	public static SortedList Synchronized(SortedList list) { }
}

// Namespace: System.Collections
[DebuggerTypeProxy(typeof(Stack.StackDebugView))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class Stack : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1458
{
	// Fields
	private object[] _array; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x14B4CF0 Offset: 0x14B32F0 VA: 0x1814B4CF0
	public void .ctor() { }

	// RVA: 0x14B4C20 Offset: 0x14B3220 VA: 0x1814B4C20
	public void .ctor(int initialCapacity) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x14B4D50 Offset: 0x14B3350 VA: 0x1814B4D50 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0x9AD950 Offset: 0x9ABF50 VA: 0x1809AD950 Slot: 13
	public virtual void Clear() { }

	// RVA: 0x14B4510 Offset: 0x14B2B10 VA: 0x1814B4510 Slot: 14
	public virtual object Clone() { }

	// RVA: 0x14B4640 Offset: 0x14B2C40 VA: 0x1814B4640 Slot: 15
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x14B4920 Offset: 0x14B2F20 VA: 0x1814B4920 Slot: 16
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x14B49B0 Offset: 0x14B2FB0 VA: 0x1814B49B0 Slot: 17
	public virtual object Peek() { }

	// RVA: 0x14B4A40 Offset: 0x14B3040 VA: 0x1814B4A40 Slot: 18
	public virtual object Pop() { }

	// RVA: 0x14B4B00 Offset: 0x14B3100 VA: 0x1814B4B00 Slot: 19
	public virtual void Push(object obj) { }
}

// Namespace: System.Collections
[DefaultMember("Item")]
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1460
{
	// Fields
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public bool Item { get; set; }
	public int Length { get; set; }
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }

	// Methods

	// RVA: 0x14A29E0 Offset: 0x14A0FE0 VA: 0x1814A29E0
	public void .ctor(int length) { }

	// RVA: 0x14A2870 Offset: 0x14A0E70 VA: 0x1814A2870
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x14A2B50 Offset: 0x14A1150 VA: 0x1814A2B50
	public void .ctor(BitArray bits) { }

	// RVA: 0x14A2C50 Offset: 0x14A1250 VA: 0x1814A2C50
	public bool get_Item(int index) { }

	// RVA: 0x14A2CD0 Offset: 0x14A12D0 VA: 0x1814A2CD0
	public void set_Item(int index, bool value) { }

	// RVA: 0x14A2660 Offset: 0x14A0C60 VA: 0x1814A2660
	public bool Get(int index) { }

	// RVA: 0x14A2750 Offset: 0x14A0D50 VA: 0x1814A2750
	public void Set(int index, bool value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_Length() { }

	// RVA: 0x14A2DF0 Offset: 0x14A13F0 VA: 0x1814A2DF0
	public void set_Length(int value) { }

	// RVA: 0x14A1FC0 Offset: 0x14A05C0 VA: 0x1814A1FC0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 5
	public int get_Count() { }

	// RVA: 0x14A2C60 Offset: 0x14A1260 VA: 0x1814A2C60 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x14A1E90 Offset: 0x14A0490 VA: 0x1814A1E90 Slot: 9
	public object Clone() { }

	// RVA: 0x14A25E0 Offset: 0x14A0BE0 VA: 0x1814A25E0 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14A25C0 Offset: 0x14A0BC0 VA: 0x1814A25C0
	private static int GetArrayLength(int n, int div) { }
}

// Namespace: System.Collections
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ArrayList.ArrayListDebugView))]
[Serializable]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1465
{
	// Fields
	private object[] _items; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x14A10C0 Offset: 0x149F6C0 VA: 0x1814A10C0
	public void .ctor() { }

	// RVA: 0x14A1110 Offset: 0x149F710 VA: 0x1814A1110
	public void .ctor(int capacity) { }

	// RVA: 0x14A1210 Offset: 0x149F810 VA: 0x1814A1210
	public void .ctor(ICollection c) { }

	// RVA: 0x14A1470 Offset: 0x149FA70 VA: 0x1814A1470 Slot: 21
	public virtual void set_Capacity(int value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 22
	public virtual int get_Count() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 23
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 24
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 25
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x14A1400 Offset: 0x149FA00 VA: 0x1814A1400 Slot: 26
	public virtual object get_SyncRoot() { }

	// RVA: 0x14A1350 Offset: 0x149F950 VA: 0x1814A1350 Slot: 27
	public virtual object get_Item(int index) { }

	// RVA: 0x14A15A0 Offset: 0x149FBA0 VA: 0x1814A15A0 Slot: 28
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x149FEE0 Offset: 0x149E4E0 VA: 0x18149FEE0
	public static ArrayList Adapter(IList list) { }

	// RVA: 0x149FFB0 Offset: 0x149E5B0 VA: 0x18149FFB0 Slot: 29
	public virtual int Add(object value) { }

	// RVA: 0x149FF90 Offset: 0x149E590 VA: 0x18149FF90 Slot: 30
	public virtual void AddRange(ICollection c) { }

	// RVA: 0x8F9E30 Offset: 0x8F8430 VA: 0x1808F9E30 Slot: 31
	public virtual void Clear() { }

	// RVA: 0x14A00B0 Offset: 0x149E6B0 VA: 0x1814A00B0 Slot: 32
	public virtual object Clone() { }

	// RVA: 0x14A0220 Offset: 0x149E820 VA: 0x1814A0220 Slot: 33
	public virtual bool Contains(object item) { }

	// RVA: 0x14A0500 Offset: 0x149EB00 VA: 0x1814A0500 Slot: 34
	public virtual void CopyTo(Array array) { }

	// RVA: 0x14A0440 Offset: 0x149EA40 VA: 0x1814A0440 Slot: 35
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14A0310 Offset: 0x149E910 VA: 0x1814A0310 Slot: 36
	public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x14A0520 Offset: 0x149EB20 VA: 0x1814A0520
	private void EnsureCapacity(int min) { }

	// RVA: 0x14A0580 Offset: 0x149EB80 VA: 0x1814A0580 Slot: 37
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x14A06B0 Offset: 0x149ECB0 VA: 0x1814A06B0 Slot: 38
	public virtual int IndexOf(object value) { }

	// RVA: 0x14A08C0 Offset: 0x149EEC0 VA: 0x1814A08C0 Slot: 39
	public virtual void Insert(int index, object value) { }

	// RVA: 0x14A06E0 Offset: 0x149ECE0 VA: 0x1814A06E0 Slot: 40
	public virtual void InsertRange(int index, ICollection c) { }

	// RVA: 0x14A0A20 Offset: 0x149F020 VA: 0x1814A0A20
	public static ArrayList ReadOnly(ArrayList list) { }

	// RVA: 0x14A0D80 Offset: 0x149F380 VA: 0x1814A0D80 Slot: 41
	public virtual void Remove(object obj) { }

	// RVA: 0x14A0AD0 Offset: 0x149F0D0 VA: 0x1814A0AD0 Slot: 42
	public virtual void RemoveAt(int index) { }

	// RVA: 0x14A0BB0 Offset: 0x149F1B0 VA: 0x1814A0BB0 Slot: 43
	public virtual void RemoveRange(int index, int count) { }

	// RVA: 0x14A0DD0 Offset: 0x149F3D0 VA: 0x1814A0DD0 Slot: 44
	public virtual void Sort(IComparer comparer) { }

	// RVA: 0x14A0E20 Offset: 0x149F420 VA: 0x1814A0E20 Slot: 45
	public virtual void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x14A0F70 Offset: 0x149F570 VA: 0x1814A0F70 Slot: 46
	public virtual object[] ToArray() { }

	// RVA: 0x14A1000 Offset: 0x149F600 VA: 0x1814A1000 Slot: 47
	public virtual Array ToArray(Type type) { }
}

// Namespace: System.Collections
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(Hashtable.HashtableDebugView))]
[DefaultMember("Item")]
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1472
{
	// Fields
	private Hashtable.bucket[] _buckets; // 0x10
	private int _count; // 0x18
	private int _occupancy; // 0x1C
	private int _loadsize; // 0x20
	private float _loadFactor; // 0x24
	private int _version; // 0x28
	private bool _isWriterInProgress; // 0x2C
	private ICollection _keys; // 0x30
	private ICollection _values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48
	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable; // 0x0

	// Properties
	private static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }
	public virtual object Item { get; set; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x14A9B10 Offset: 0x14A8110 VA: 0x1814A9B10
	private static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor(bool trash) { }

	// RVA: 0x14A9480 Offset: 0x14A7A80 VA: 0x1814A9480
	public void .ctor() { }

	// RVA: 0x14A93C0 Offset: 0x14A79C0 VA: 0x1814A93C0
	public void .ctor(int capacity) { }

	// RVA: 0x14A9520 Offset: 0x14A7B20 VA: 0x1814A9520
	public void .ctor(int capacity, float loadFactor) { }

	// RVA: 0x14A94A0 Offset: 0x14A7AA0 VA: 0x1814A94A0
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
	// RVA: 0x14A9230 Offset: 0x14A7830 VA: 0x1814A9230
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x14A91F0 Offset: 0x14A77F0 VA: 0x1814A91F0
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x14A94E0 Offset: 0x14A7AE0 VA: 0x1814A94E0
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
	// RVA: 0x14A92F0 Offset: 0x14A78F0 VA: 0x1814A92F0
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x14A93D0 Offset: 0x14A79D0 VA: 0x1814A93D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A7C90 Offset: 0x14A6290 VA: 0x1814A7C90
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x14A6CB0 Offset: 0x14A52B0 VA: 0x1814A6CB0 Slot: 23
	public virtual void Add(object key, object value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x14A6CD0 Offset: 0x14A52D0 VA: 0x1814A6CD0 Slot: 24
	public virtual void Clear() { }

	// RVA: 0x14A6E10 Offset: 0x14A5410 VA: 0x1814A6E10 Slot: 25
	public virtual object Clone() { }

	// RVA: 0x14A70B0 Offset: 0x14A56B0 VA: 0x1814A70B0 Slot: 26
	public virtual bool Contains(object key) { }

	// RVA: 0x14A6F20 Offset: 0x14A5520 VA: 0x1814A6F20 Slot: 27
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x14A71F0 Offset: 0x14A57F0 VA: 0x1814A71F0
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x14A70D0 Offset: 0x14A56D0 VA: 0x1814A70D0
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x14A7290 Offset: 0x14A5890 VA: 0x1814A7290 Slot: 28
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14A7550 Offset: 0x14A5B50 VA: 0x1814A7550
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x14A9860 Offset: 0x14A7E60 VA: 0x1814A9860 Slot: 29
	public virtual object get_Item(object key) { }

	// RVA: 0x14A9F20 Offset: 0x14A8520 VA: 0x1814A9F20 Slot: 30
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x14A97A0 Offset: 0x14A7DA0 VA: 0x1814A97A0
	private void expand() { }

	// RVA: 0x14A9EF0 Offset: 0x14A84F0 VA: 0x1814A9EF0
	private void rehash() { }

	// RVA: 0x14A91C0 Offset: 0x14A77C0 VA: 0x1814A91C0
	private void UpdateVersion() { }

	// RVA: 0x14A9DA0 Offset: 0x14A83A0 VA: 0x1814A9DA0
	private void rehash(int newsize) { }

	// RVA: 0x14A9130 Offset: 0x14A7730 VA: 0x1814A9130 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14A75F0 Offset: 0x14A5BF0 VA: 0x1814A75F0 Slot: 31
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x14A7680 Offset: 0x14A5C80 VA: 0x1814A7680 Slot: 32
	protected virtual int GetHash(object key) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 33
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 34
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 35
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x14A82E0 Offset: 0x14A68E0 VA: 0x1814A82E0 Slot: 36
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x14A9A90 Offset: 0x14A8090 VA: 0x1814A9A90 Slot: 37
	public virtual ICollection get_Keys() { }

	// RVA: 0x14A9BD0 Offset: 0x14A81D0 VA: 0x1814A9BD0 Slot: 38
	public virtual ICollection get_Values() { }

	// RVA: 0x14A7CE0 Offset: 0x14A62E0 VA: 0x1814A7CE0
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x14A9C50 Offset: 0x14A8250 VA: 0x1814A9C50
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x14A8DB0 Offset: 0x14A73B0 VA: 0x1814A8DB0 Slot: 39
	public virtual void Remove(object key) { }

	// RVA: 0x14A9B60 Offset: 0x14A8160 VA: 0x1814A9B60 Slot: 40
	public virtual object get_SyncRoot() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 41
	public virtual int get_Count() { }

	// RVA: 0x14A9080 Offset: 0x14A7680 VA: 0x1814A9080
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x14A7710 Offset: 0x14A5D10 VA: 0x1814A7710 Slot: 42
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14A8420 Offset: 0x14A6A20 VA: 0x1814A8420 Slot: 43
	public virtual void OnDeserialization(object sender) { }
}

// Namespace: System.Collections
[Obsolete("Please use IEqualityComparer instead.")]
public interface IHashCodeProvider // TypeDefIndex: 1473
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetHashCode(object obj);
}

// Namespace: System.Collections
[Extension]
internal static class HashtableExtensions // TypeDefIndex: 7688
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool TryGetValue<T>(Hashtable table, object key, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7094F0 Offset: 0x707AF0 VA: 0x1807094F0
	|-HashtableExtensions.TryGetValue<int>
	|
	|-RVA: 0x7093A0 Offset: 0x7079A0 VA: 0x1807093A0
	|-HashtableExtensions.TryGetValue<__Il2CppFullySharedGenericType>
	*/
}

