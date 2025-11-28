// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
public struct BitVector32 // TypeDefIndex: 7689
{
	// Fields
	private uint _data; // 0x0

	// Properties
	public bool Item { get; set; }

	// Methods

	// RVA: 0x1E4A1B0 Offset: 0x1E487B0 VA: 0x181E4A1B0
	public bool get_Item(int bit) { }

	// RVA: 0x1E4A1D0 Offset: 0x1E487D0 VA: 0x181E4A1D0
	public void set_Item(int bit, bool value) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	public static int CreateMask() { }

	// RVA: 0x1E49EC0 Offset: 0x1E484C0 VA: 0x181E49EC0
	public static int CreateMask(int previous) { }

	// RVA: 0x1E49F40 Offset: 0x1E48540 VA: 0x181E49F40 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1E49FC0 Offset: 0x1E485C0 VA: 0x181E49FC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E4A0E0 Offset: 0x1E486E0 VA: 0x181E4A0E0
	public static string ToString(BitVector32 value) { }

	// RVA: 0x1E4A010 Offset: 0x1E48610 VA: 0x181E4A010 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 7690
{
	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Properties
	public string Item { get; set; }

	// Methods

	// RVA: 0x1E58600 Offset: 0x1E56C00 VA: 0x181E58600
	public void .ctor() { }

	// RVA: 0x1E58510 Offset: 0x1E56B10 VA: 0x181E58510
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1E58590 Offset: 0x1E56B90 VA: 0x181E58590
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E582E0 Offset: 0x1E568E0 VA: 0x181E582E0
	protected void InvalidateCachedArrays() { }

	// RVA: 0x1E57D70 Offset: 0x1E56370 VA: 0x181E57D70
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x1E57F50 Offset: 0x1E56550 VA: 0x181E57F50
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x1E57BE0 Offset: 0x1E561E0 VA: 0x181E57BE0 Slot: 15
	public virtual void Add(string name, string value) { }

	// RVA: 0x1E58240 Offset: 0x1E56840 VA: 0x181E58240 Slot: 16
	public virtual string Get(string name) { }

	// RVA: 0x1E58010 Offset: 0x1E56610 VA: 0x181E58010 Slot: 17
	public virtual string[] GetValues(string name) { }

	// RVA: 0x1E58370 Offset: 0x1E56970 VA: 0x181E58370 Slot: 18
	public virtual void Set(string name, string value) { }

	// RVA: 0x1E58320 Offset: 0x1E56920 VA: 0x181E58320 Slot: 19
	public virtual void Remove(string name) { }

	// RVA: 0x1A1D2A0 Offset: 0x1A1B8A0 VA: 0x181A1D2A0
	public string get_Item(string name) { }

	// RVA: 0x1E586E0 Offset: 0x1E56CE0 VA: 0x181E586E0
	public void set_Item(string name, string value) { }

	// RVA: 0x1E58130 Offset: 0x1E56730 VA: 0x181E58130 Slot: 20
	public virtual string Get(int index) { }

	// RVA: 0x1E58000 Offset: 0x1E56600 VA: 0x181E58000 Slot: 21
	public virtual string GetKey(int index) { }

	// RVA: 0x1E58690 Offset: 0x1E56C90 VA: 0x181E58690
	internal void .ctor(DBNull dummy) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class OrderedDictionary : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 7693
{
	// Fields
	private ArrayList _objectsArray; // 0x10
	private Hashtable _objectsTable; // 0x18
	private int _initialCapacity; // 0x20
	private IEqualityComparer _comparer; // 0x28
	private bool _readOnly; // 0x30
	private object _syncRoot; // 0x38
	private SerializationInfo _siInfo; // 0x40

	// Properties
	public int Count { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	public ICollection Keys { get; }
	private ArrayList objectsArray { get; }
	private Hashtable objectsTable { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object Item { get; set; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x1E5C890 Offset: 0x1E5AE90 VA: 0x181E5C890
	public void .ctor() { }

	// RVA: 0x1E5C810 Offset: 0x1E5AE10 VA: 0x181E5C810
	public void .ctor(int capacity) { }

	// RVA: 0x1E5C850 Offset: 0x1E5AE50 VA: 0x181E5C850
	public void .ctor(IEqualityComparer comparer) { }

	// RVA: 0x1E5C8C0 Offset: 0x1E5AEC0 VA: 0x181E5C8C0
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x103DAC0 Offset: 0x103C0C0 VA: 0x18103DAC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E5C900 Offset: 0x1E5AF00 VA: 0x181E5C900 Slot: 16
	public int get_Count() { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190 Slot: 12
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1E5C980 Offset: 0x1E5AF80 VA: 0x181E5C980 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x1E5CA80 Offset: 0x1E5B080 VA: 0x181E5CA80
	private ArrayList get_objectsArray() { }

	// RVA: 0x1E5CB00 Offset: 0x1E5B100 VA: 0x181E5CB00
	private Hashtable get_objectsTable() { }

	// RVA: 0x1E5C6E0 Offset: 0x1E5ACE0 VA: 0x181E5C6E0 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1E5C940 Offset: 0x1E5AF40 VA: 0x181E5C940 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x1E5CB90 Offset: 0x1E5B190 VA: 0x181E5CB90 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x1E5CA00 Offset: 0x1E5B000 VA: 0x181E5CA00 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x1E5BBD0 Offset: 0x1E5A1D0 VA: 0x181E5BBD0 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x1E5BD00 Offset: 0x1E5A300 VA: 0x181E5BD00 Slot: 10
	public void Clear() { }

	// RVA: 0x1E5BDB0 Offset: 0x1E5A3B0 VA: 0x181E5BDB0 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x1E5BDF0 Offset: 0x1E5A3F0 VA: 0x181E5BDF0 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1E5C0B0 Offset: 0x1E5A6B0 VA: 0x181E5C0B0
	private int IndexOfKey(object key) { }

	// RVA: 0x1E5C5B0 Offset: 0x1E5ABB0 VA: 0x181E5C5B0 Slot: 14
	public void Remove(object key) { }

	// RVA: 0x1E5BE40 Offset: 0x1E5A440 VA: 0x181E5BE40 Slot: 22
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1E5C750 Offset: 0x1E5AD50 VA: 0x181E5C750 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1E5BEE0 Offset: 0x1E5A4E0 VA: 0x181E5BEE0 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E5C7F0 Offset: 0x1E5ADF0 VA: 0x181E5C7F0 Slot: 21
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1E5C220 Offset: 0x1E5A820 VA: 0x181E5C220 Slot: 24
	protected virtual void OnDeserialization(object sender) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class StringCollection : IList, ICollection, IEnumerable // TypeDefIndex: 7694
{
	// Fields
	private readonly ArrayList data; // 0x10

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1E5DB10 Offset: 0x1E5C110 VA: 0x181E5DB10
	public string get_Item(int index) { }

	// RVA: 0x1E5DC30 Offset: 0x1E5C230 VA: 0x181E5DC30
	public void set_Item(int index, string value) { }

	// RVA: 0x14A4DA0 Offset: 0x14A33A0 VA: 0x1814A4DA0 Slot: 16
	public int get_Count() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1E5D870 Offset: 0x1E5BE70 VA: 0x181E5D870
	public int Add(string value) { }

	// RVA: 0x1E222F0 Offset: 0x1E208F0 VA: 0x181E222F0 Slot: 8
	public void Clear() { }

	// RVA: 0x14A46C0 Offset: 0x14A2CC0 VA: 0x1814A46C0
	public bool Contains(string value) { }

	// RVA: 0x14A4550 Offset: 0x14A2B50 VA: 0x1814A4550
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x14A46F0 Offset: 0x14A2CF0 VA: 0x1814A46F0
	public int IndexOf(string value) { }

	// RVA: 0x1E5D8A0 Offset: 0x1E5BEA0 VA: 0x181E5D8A0
	public void Insert(int index, string value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x1E5D900 Offset: 0x1E5BF00 VA: 0x181E5D900
	public void Remove(string value) { }

	// RVA: 0x1E5D8D0 Offset: 0x1E5BED0 VA: 0x181E5D8D0 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x14A4580 Offset: 0x14A2B80 VA: 0x1814A4580 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x1E5DB10 Offset: 0x1E5C110 VA: 0x181E5DB10 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1E5DB60 Offset: 0x1E5C160 VA: 0x181E5DB60 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1E5D930 Offset: 0x1E5BF30 VA: 0x181E5D930 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1E5D990 Offset: 0x1E5BF90 VA: 0x181E5D990 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1E5D9F0 Offset: 0x1E5BFF0 VA: 0x181E5D9F0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1E5DA50 Offset: 0x1E5C050 VA: 0x181E5DA50 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1E5DAB0 Offset: 0x1E5C0B0 VA: 0x181E5DAB0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x14A4550 Offset: 0x14A2B50 VA: 0x1814A4550 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x131AB70 Offset: 0x1319170 VA: 0x18131AB70 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1E5DBC0 Offset: 0x1E5C1C0 VA: 0x181E5DBC0
	public void .ctor() { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class StringDictionary : IEnumerable // TypeDefIndex: 7695
{
	// Fields
	internal Hashtable contents; // 0x10

	// Methods

	// RVA: 0x1E4A270 Offset: 0x1E48870 VA: 0x181E4A270
	public void .ctor() { }

	// RVA: 0x1E5DC60 Offset: 0x1E5C260 VA: 0x181E5DC60 Slot: 5
	public virtual void Add(string key, string value) { }

	// RVA: 0x1B314C0 Offset: 0x1B2FAC0 VA: 0x181B314C0 Slot: 6
	public virtual IEnumerator GetEnumerator() { }
}

// Namespace: System.Collections.Specialized
public interface INotifyCollectionChanged // TypeDefIndex: 7696
{}

// Namespace: System.Collections.Specialized
public enum NotifyCollectionChangedAction // TypeDefIndex: 7697
{
	// Fields
	public int value__; // 0x0
	public const NotifyCollectionChangedAction Add = 0;
	public const NotifyCollectionChangedAction Remove = 1;
	public const NotifyCollectionChangedAction Replace = 2;
	public const NotifyCollectionChangedAction Move = 3;
	public const NotifyCollectionChangedAction Reset = 4;
}

// Namespace: System.Collections.Specialized
public class NotifyCollectionChangedEventArgs : EventArgs // TypeDefIndex: 7698
{
	// Fields
	private NotifyCollectionChangedAction _action; // 0x10
	private IList _newItems; // 0x18
	private IList _oldItems; // 0x20
	private int _newStartingIndex; // 0x28
	private int _oldStartingIndex; // 0x2C

	// Methods

	// RVA: 0x1E5AB40 Offset: 0x1E59140 VA: 0x181E5AB40
	public void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x1E5A800 Offset: 0x1E58E00 VA: 0x181E5A800
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x1E5AE50 Offset: 0x1E59450 VA: 0x181E5AE50
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x1E5AC70 Offset: 0x1E59270 VA: 0x181E5AC70
	public void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	// RVA: 0x1E5A4A0 Offset: 0x1E58AA0 VA: 0x181E5A4A0
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x1E5A5B0 Offset: 0x1E58BB0 VA: 0x181E5A5B0
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x1E5A760 Offset: 0x1E58D60 VA: 0x181E5A760
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x1E5A650 Offset: 0x1E58C50 VA: 0x181E5A650
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }
}

// Namespace: System.Collections.Specialized
public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate // TypeDefIndex: 7699
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
internal sealed class ReadOnlyList : IList, ICollection, IEnumerable // TypeDefIndex: 7700
{
	// Fields
	private readonly IList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(IList list) { }

	// RVA: 0x1E5D1B0 Offset: 0x1E5B7B0 VA: 0x181E5D1B0 Slot: 16
	public int get_Count() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 9
	public bool get_IsReadOnly() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 10
	public bool get_IsFixedSize() { }

	// RVA: 0x1E5D200 Offset: 0x1E5B800 VA: 0x181E5D200 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x1E5D250 Offset: 0x1E5B850 VA: 0x181E5D250 Slot: 4
	public object get_Item(int index) { }

	// RVA: 0x1E5D300 Offset: 0x1E5B900 VA: 0x181E5D300 Slot: 5
	public void set_Item(int index, object value) { }

	// RVA: 0x1E5D2B0 Offset: 0x1E5B8B0 VA: 0x181E5D2B0 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x1E5CE30 Offset: 0x1E5B430 VA: 0x181E5CE30 Slot: 6
	public int Add(object value) { }

	// RVA: 0x1E5CE80 Offset: 0x1E5B480 VA: 0x181E5CE80 Slot: 8
	public void Clear() { }

	// RVA: 0x1E5CED0 Offset: 0x1E5B4D0 VA: 0x181E5CED0 Slot: 7
	public bool Contains(object value) { }

	// RVA: 0x1E5CFA0 Offset: 0x1E5B5A0 VA: 0x181E5CFA0 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1E5D010 Offset: 0x1E5B610 VA: 0x181E5D010 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1E5D060 Offset: 0x1E5B660 VA: 0x181E5D060 Slot: 11
	public int IndexOf(object value) { }

	// RVA: 0x1E5D0C0 Offset: 0x1E5B6C0 VA: 0x181E5D0C0 Slot: 12
	public void Insert(int index, object value) { }

	// RVA: 0x1E5D160 Offset: 0x1E5B760 VA: 0x181E5D160 Slot: 13
	public void Remove(object value) { }

	// RVA: 0x1E5D110 Offset: 0x1E5B710 VA: 0x181E5D110 Slot: 14
	public void RemoveAt(int index) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
internal class CaseSensitiveStringDictionary : StringDictionary // TypeDefIndex: 7701
{
	// Methods

	// RVA: 0x1E4A270 Offset: 0x1E48870 VA: 0x181E4A270
	public void .ctor() { }

	// RVA: 0x1E4A1F0 Offset: 0x1E487F0 VA: 0x181E4A1F0 Slot: 5
	public override void Add(string key, string value) { }
}

// Namespace: System.Collections.Specialized
[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 7704
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private object _syncRoot; // 0x48
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0x1E577C0 Offset: 0x1E55DC0 VA: 0x181E577C0
	protected void .ctor() { }

	// RVA: 0x1E57820 Offset: 0x1E55E20 VA: 0x181E57820
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1E57780 Offset: 0x1E55D80 VA: 0x181E57780
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x1BC7AF0 Offset: 0x1BC60F0 VA: 0x181BC7AF0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E56220 Offset: 0x1E54820 VA: 0x181E56220 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E56970 Offset: 0x1E54F70 VA: 0x181E56970 Slot: 12
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x1E57150 Offset: 0x1E55750 VA: 0x181E57150
	private void Reset() { }

	// RVA: 0x1E57220 Offset: 0x1E55820 VA: 0x181E57220
	private void Reset(int capacity) { }

	// RVA: 0x1E560D0 Offset: 0x1E546D0 VA: 0x181E560D0
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	protected bool get_IsReadOnly() { }

	// RVA: 0x1E55AA0 Offset: 0x1E540A0 VA: 0x181E55AA0
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x1E55DA0 Offset: 0x1E543A0 VA: 0x181E55DA0
	protected void BaseRemove(string name) { }

	// RVA: 0x1E55CE0 Offset: 0x1E542E0 VA: 0x181E55CE0
	protected object BaseGet(string name) { }

	// RVA: 0x1E56000 Offset: 0x1E54600 VA: 0x181E56000
	protected void BaseSet(string name, object value) { }

	// RVA: 0x1E55D00 Offset: 0x1E54300 VA: 0x181E55D00
	protected object BaseGet(int index) { }

	// RVA: 0x1E55C40 Offset: 0x1E54240 VA: 0x181E55C40
	protected string BaseGetKey(int index) { }

	// RVA: 0x1E561A0 Offset: 0x1E547A0 VA: 0x181E561A0 Slot: 13
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x138B880 Offset: 0x1389E80 VA: 0x18138B880 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x1E57300 Offset: 0x1E55900 VA: 0x181E57300 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1E57660 Offset: 0x1E55C60 VA: 0x181E57660 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1E576D0 Offset: 0x1E55CD0 VA: 0x181E576D0
	private static void .cctor() { }
}

// Namespace: System.Collections.Specialized
[Serializable]
internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 7705
{
	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties
	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x1E4A3A0 Offset: 0x1E489A0 VA: 0x181E4A3A0 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x1E4A520 Offset: 0x1E48B20 VA: 0x181E4A520 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public IComparer get_Comparer() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x1E4A5F0 Offset: 0x1E48BF0 VA: 0x181E4A5F0
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x1E4A6E0 Offset: 0x1E48CE0 VA: 0x181E4A6E0
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }
}

