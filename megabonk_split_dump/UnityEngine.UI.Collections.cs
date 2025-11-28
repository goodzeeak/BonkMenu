// Namespace: UnityEngine.UI.Collections
[DefaultMember("Item")]
internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 12227
{
	// Fields
	private readonly List<T> m_List; // 0x0
	private Dictionary<T, int> m_Dictionary; // 0x0
	private int m_EnabledObjectCount; // 0x0

	// Properties
	public int Count { get; }
	public int Capacity { get; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A6FB0 Offset: 0x10A55B0 VA: 0x1810A6FB0
	|-IndexedSet<object>.Add
	|
	|-RVA: 0x10A6EB0 Offset: 0x10A54B0 VA: 0x1810A6EB0
	|-IndexedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T item, bool isActive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A6FD0 Offset: 0x10A55D0 VA: 0x1810A6FD0
	|-IndexedSet<object>.Add
	|
	|-RVA: 0x10A6C40 Offset: 0x10A5240 VA: 0x1810A6C40
	|-IndexedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool AddUnique(T item, bool isActive = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A6B20 Offset: 0x10A5120 VA: 0x1810A6B20
	|-IndexedSet<object>.AddUnique
	|
	|-RVA: 0x10A68D0 Offset: 0x10A4ED0 VA: 0x1810A68D0
	|-IndexedSet<__Il2CppFullySharedGenericType>.AddUnique
	*/

	// RVA: -1 Offset: -1
	public bool EnableItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A76B0 Offset: 0x10A5CB0 VA: 0x1810A76B0
	|-IndexedSet<object>.EnableItem
	|
	|-RVA: 0x10A7550 Offset: 0x10A5B50 VA: 0x1810A7550
	|-IndexedSet<__Il2CppFullySharedGenericType>.EnableItem
	*/

	// RVA: -1 Offset: -1
	public bool DisableItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A7350 Offset: 0x10A5950 VA: 0x1810A7350
	|-IndexedSet<object>.DisableItem
	|
	|-RVA: 0x10A73F0 Offset: 0x10A59F0 VA: 0x1810A73F0
	|-IndexedSet<__Il2CppFullySharedGenericType>.DisableItem
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A81A0 Offset: 0x10A67A0 VA: 0x1810A81A0
	|-IndexedSet<object>.Remove
	|
	|-RVA: 0x10A8050 Offset: 0x10A6650 VA: 0x1810A8050
	|-IndexedSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603570 Offset: 0x601B70 VA: 0x180603570
	|-IndexedSet<object>.GetEnumerator
	|-IndexedSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A8C50 Offset: 0x10A7250 VA: 0x1810A8C50
	|-IndexedSet<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94D430 Offset: 0x94BA30 VA: 0x18094D430
	|-IndexedSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A7150 Offset: 0x10A5750 VA: 0x1810A7150
	|-IndexedSet<object>.Clear
	|
	|-RVA: 0x10A70E0 Offset: 0x10A56E0 VA: 0x1810A70E0
	|-IndexedSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A71D0 Offset: 0x10A57D0 VA: 0x1810A71D0
	|-IndexedSet<object>.Contains
	|
	|-RVA: 0x10A7200 Offset: 0x10A5800 VA: 0x1810A7200
	|-IndexedSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A72F0 Offset: 0x10A58F0 VA: 0x1810A72F0
	|-IndexedSet<object>.CopyTo
	|
	|-RVA: 0x10A7320 Offset: 0x10A5920 VA: 0x1810A7320
	|-IndexedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-IndexedSet<object>.get_Count
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969700 Offset: 0x967D00 VA: 0x180969700
	|-IndexedSet<object>.get_Capacity
	|
	|-RVA: 0x10A8E40 Offset: 0x10A7440 VA: 0x1810A8E40
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-IndexedSet<object>.get_IsReadOnly
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A7860 Offset: 0x10A5E60 VA: 0x1810A7860
	|-IndexedSet<object>.IndexOf
	|
	|-RVA: 0x10A7740 Offset: 0x10A5D40 VA: 0x1810A7740
	|-IndexedSet<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A78B0 Offset: 0x10A5EB0 VA: 0x1810A78B0
	|-IndexedSet<object>.Insert
	|-IndexedSet<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A7EF0 Offset: 0x10A64F0 VA: 0x1810A7EF0
	|-IndexedSet<object>.RemoveAt
	|
	|-RVA: 0x10A7C30 Offset: 0x10A6230 VA: 0x1810A7C30
	|-IndexedSet<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private void Swap(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A8640 Offset: 0x10A6C40 VA: 0x1810A8640
	|-IndexedSet<object>.Swap
	|
	|-RVA: 0x10A8780 Offset: 0x10A6D80 VA: 0x1810A8780
	|-IndexedSet<__Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A8F90 Offset: 0x10A7590 VA: 0x1810A8F90
	|-IndexedSet<object>.get_Item
	|
	|-RVA: 0x10A8E80 Offset: 0x10A7480 VA: 0x1810A8E80
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A9000 Offset: 0x10A7600 VA: 0x1810A9000
	|-IndexedSet<object>.set_Item
	|
	|-RVA: 0x10A90D0 Offset: 0x10A76D0 VA: 0x1810A90D0
	|-IndexedSet<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A7900 Offset: 0x10A5F00 VA: 0x1810A7900
	|-IndexedSet<object>.RemoveAll
	|
	|-RVA: 0x10A79D0 Offset: 0x10A5FD0 VA: 0x1810A79D0
	|-IndexedSet<__Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> sortLayoutFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A8580 Offset: 0x10A6B80 VA: 0x1810A8580
	|-IndexedSet<object>.Sort
	|
	|-RVA: 0x10A8340 Offset: 0x10A6940 VA: 0x1810A8340
	|-IndexedSet<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A8D60 Offset: 0x10A7360 VA: 0x1810A8D60
	|-IndexedSet<object>..ctor
	|
	|-RVA: 0x10A8C80 Offset: 0x10A7280 VA: 0x1810A8C80
	|-IndexedSet<__Il2CppFullySharedGenericType>..ctor
	*/
}

