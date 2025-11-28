// Namespace: UnityEngine.ProBuilder.KdTree
internal struct HyperRect<T> // TypeDefIndex: 13996
{
	// Fields
	private T[] minPoint; // 0x0
	private T[] maxPoint; // 0x0

	// Properties
	public T[] MinPoint { get; set; }
	public T[] MaxPoint { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T[] get_MinPoint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	|-HyperRect<float>.get_MinPoint
	|-HyperRect<__Il2CppFullySharedGenericType>.get_MinPoint
	*/

	// RVA: -1 Offset: -1
	public void set_MinPoint(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10917C0 Offset: 0x108FDC0 VA: 0x1810917C0
	|-HyperRect<float>.set_MinPoint
	|-HyperRect<__Il2CppFullySharedGenericType>.set_MinPoint
	*/

	// RVA: -1 Offset: -1
	public T[] get_MaxPoint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	|-HyperRect<float>.get_MaxPoint
	|-HyperRect<__Il2CppFullySharedGenericType>.get_MaxPoint
	*/

	// RVA: -1 Offset: -1
	public void set_MaxPoint(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1091730 Offset: 0x108FD30 VA: 0x181091730
	|-HyperRect<float>.set_MaxPoint
	|-HyperRect<__Il2CppFullySharedGenericType>.set_MaxPoint
	*/

	// RVA: -1 Offset: -1
	public static HyperRect<T> Infinite(int dimensions, ITypeMath<T> math) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1091360 Offset: 0x108F960 VA: 0x181091360
	|-HyperRect<float>.Infinite
	|
	|-RVA: 0x1090E10 Offset: 0x108F410 VA: 0x181090E10
	|-HyperRect<__Il2CppFullySharedGenericType>.Infinite
	*/

	// RVA: -1 Offset: -1
	public T[] GetClosestPoint(T[] toPoint, ITypeMath<T> math) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090B60 Offset: 0x108F160 VA: 0x181090B60
	|-HyperRect<float>.GetClosestPoint
	|
	|-RVA: 0x1090710 Offset: 0x108ED10 VA: 0x181090710
	|-HyperRect<__Il2CppFullySharedGenericType>.GetClosestPoint
	*/

	// RVA: -1 Offset: -1
	public HyperRect<T> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090580 Offset: 0x108EB80 VA: 0x181090580
	|-HyperRect<float>.Clone
	|
	|-RVA: 0x1090400 Offset: 0x108EA00 VA: 0x181090400
	|-HyperRect<__Il2CppFullySharedGenericType>.Clone
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal interface IKdTree<TKey, TValue> : IEnumerable<KdTreeNode<TKey, TValue>>, IEnumerable // TypeDefIndex: 13997
{
	// Properties
	public abstract int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Add(TKey[] point, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TryFindValueAt(TKey[] point, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryFindValueAt
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TValue FindValueAt(TKey[] point);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindValueAt
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TryFindValue(TValue value, out TKey[] point);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryFindValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TKey[] FindValue(TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindValue
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract KdTreeNode<TKey, TValue>[] RadialSearch(TKey[] center, TKey radius, int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RadialSearch
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void RemoveAt(TKey[] point);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Clear();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract KdTreeNode<TKey, TValue>[] GetNearestNeighbours(TKey[] point, int count = 2147483647);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetNearestNeighbours
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal interface IPriorityQueue<TItem, TPriority> // TypeDefIndex: 13998
{
	// Properties
	public abstract int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Enqueue(TItem item, TPriority priority);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TItem Dequeue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dequeue
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal enum AddDuplicateBehavior // TypeDefIndex: 13999
{
	// Fields
	public int value__; // 0x0
	public const AddDuplicateBehavior Skip = 0;
	public const AddDuplicateBehavior Error = 1;
	public const AddDuplicateBehavior Update = 2;
	public const AddDuplicateBehavior Collect = 3;
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal class DuplicateNodeError : Exception // TypeDefIndex: 14000
{
	// Methods

	// RVA: 0x20726B0 Offset: 0x2070CB0 VA: 0x1820726B0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.KdTree
[Serializable]
internal class KdTree<TKey, TValue> : IKdTree<TKey, TValue>, IEnumerable<KdTreeNode<TKey, TValue>>, IEnumerable // TypeDefIndex: 14003
{
	// Fields
	private int dimensions; // 0x0
	private ITypeMath<TKey> typeMath; // 0x0
	private KdTreeNode<TKey, TValue> root; // 0x0
	[CompilerGenerated]
	private AddDuplicateBehavior <AddDuplicateBehavior>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public AddDuplicateBehavior AddDuplicateBehavior { get; set; }
	public int Count { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int dimensions, ITypeMath<TKey> typeMath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D2AD0 Offset: 0x10D10D0 VA: 0x1810D2AD0
	|-KdTree<float, int>..ctor
	|
	|-RVA: 0x10D2A00 Offset: 0x10D1000 VA: 0x1810D2A00
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int dimensions, ITypeMath<TKey> typeMath, AddDuplicateBehavior addDuplicateBehavior) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D2A70 Offset: 0x10D1070 VA: 0x1810D2A70
	|-KdTree<float, int>..ctor
	|
	|-RVA: 0x10D2B20 Offset: 0x10D1120 VA: 0x1810D2B20
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public AddDuplicateBehavior get_AddDuplicateBehavior() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	|-KdTree<float, int>.get_AddDuplicateBehavior
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_AddDuplicateBehavior
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_AddDuplicateBehavior(AddDuplicateBehavior value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	|-KdTree<float, int>.set_AddDuplicateBehavior
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_AddDuplicateBehavior
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Add(TKey[] point, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CDD90 Offset: 0x10CC390 VA: 0x1810CDD90
	|-KdTree<float, int>.Add
	|
	|-RVA: 0x10CE2A0 Offset: 0x10CC8A0 VA: 0x1810CE2A0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private void ReadChildNodes(KdTreeNode<TKey, TValue> removedNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D02D0 Offset: 0x10CE8D0 VA: 0x1810D02D0
	|-KdTree<float, int>.ReadChildNodes
	|
	|-RVA: 0x10D0550 Offset: 0x10CEB50 VA: 0x1810D0550
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReadChildNodes
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void RemoveAt(TKey[] point) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D0A70 Offset: 0x10CF070 VA: 0x1810D0A70
	|-KdTree<float, int>.RemoveAt
	|
	|-RVA: 0x10D0DE0 Offset: 0x10CF3E0 VA: 0x1810D0DE0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public KdTreeNode<TKey, TValue>[] GetNearestNeighbours(TKey[] point, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CF110 Offset: 0x10CD710 VA: 0x1810CF110
	|-KdTree<float, int>.GetNearestNeighbours
	|
	|-RVA: 0x10CF450 Offset: 0x10CDA50 VA: 0x1810CF450
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetNearestNeighbours
	*/

	// RVA: -1 Offset: -1
	private void AddNearestNeighbours(KdTreeNode<TKey, TValue> node, TKey[] target, HyperRect<TKey> rect, int depth, NearestNeighbourList<KdTreeNode<TKey, TValue>, TKey> nearestNeighbours, TKey maxSearchRadiusSquared) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CCD80 Offset: 0x10CB380 VA: 0x1810CCD80
	|-KdTree<float, int>.AddNearestNeighbours
	|
	|-RVA: 0x10CC1D0 Offset: 0x10CA7D0 VA: 0x1810CC1D0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddNearestNeighbours
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public KdTreeNode<TKey, TValue>[] RadialSearch(TKey[] center, TKey radius, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D0010 Offset: 0x10CE610 VA: 0x1810D0010
	|-KdTree<float, int>.RadialSearch
	|
	|-RVA: 0x10CFB90 Offset: 0x10CE190 VA: 0x1810CFB90
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RadialSearch
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 13
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	|-KdTree<float, int>.get_Count
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	|-KdTree<float, int>.set_Count
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool TryFindValueAt(TKey[] point, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D1E30 Offset: 0x10D0430 VA: 0x1810D1E30
	|-KdTree<float, int>.TryFindValueAt
	|
	|-RVA: 0x10D2090 Offset: 0x10D0690 VA: 0x1810D2090
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryFindValueAt
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TValue FindValueAt(TKey[] point) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CEE50 Offset: 0x10CD450 VA: 0x1810CEE50
	|-KdTree<float, int>.FindValueAt
	|
	|-RVA: 0x10CED10 Offset: 0x10CD310 VA: 0x1810CED10
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindValueAt
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool TryFindValue(TValue value, out TKey[] point) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D2860 Offset: 0x10D0E60 VA: 0x1810D2860
	|-KdTree<float, int>.TryFindValue
	|
	|-RVA: 0x10D24F0 Offset: 0x10D0AF0 VA: 0x1810D24F0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryFindValue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public TKey[] FindValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CEE90 Offset: 0x10CD490 VA: 0x1810CEE90
	|-KdTree<float, int>.FindValue
	|
	|-RVA: 0x10CEED0 Offset: 0x10CD4D0 VA: 0x1810CEED0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindValue
	*/

	// RVA: -1 Offset: -1
	private void AddNodeToStringBuilder(KdTreeNode<TKey, TValue> node, StringBuilder sb, int depth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CD220 Offset: 0x10CB820 VA: 0x1810CD220
	|-KdTree<float, int>.AddNodeToStringBuilder
	|
	|-RVA: 0x10CD3B0 Offset: 0x10CB9B0 VA: 0x1810CD3B0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddNodeToStringBuilder
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D1C90 Offset: 0x10D0290 VA: 0x1810D1C90
	|-KdTree<float, int>.ToString
	|
	|-RVA: 0x10D1D60 Offset: 0x10D0360 VA: 0x1810D1D60
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	private void AddNodesToList(KdTreeNode<TKey, TValue> node, List<KdTreeNode<TKey, TValue>> nodes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CDC60 Offset: 0x10CC260 VA: 0x1810CDC60
	|-KdTree<float, int>.AddNodesToList
	|
	|-RVA: 0x10CDB40 Offset: 0x10CC140 VA: 0x1810CDB40
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddNodesToList
	*/

	// RVA: -1 Offset: -1
	private void SortNodesArray(KdTreeNode<TKey, TValue>[] nodes, int byDimension, int fromIndex, int toIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D1A00 Offset: 0x10D0000 VA: 0x1810D1A00
	|-KdTree<float, int>.SortNodesArray
	|
	|-RVA: 0x10D1700 Offset: 0x10CFD00 VA: 0x1810D1700
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SortNodesArray
	*/

	// RVA: -1 Offset: -1
	private void AddNodesBalanced(KdTreeNode<TKey, TValue>[] nodes, int byDimension, int fromIndex, int toIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CD900 Offset: 0x10CBF00 VA: 0x1810CD900
	|-KdTree<float, int>.AddNodesBalanced
	|
	|-RVA: 0x10CD570 Offset: 0x10CBB70 VA: 0x1810CD570
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddNodesBalanced
	*/

	// RVA: -1 Offset: -1
	public void Balance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CEA40 Offset: 0x10CD040 VA: 0x1810CEA40
	|-KdTree<float, int>.Balance
	|
	|-RVA: 0x10CEB60 Offset: 0x10CD160 VA: 0x1810CEB60
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Balance
	*/

	// RVA: -1 Offset: -1
	private void RemoveChildNodes(KdTreeNode<TKey, TValue> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D1330 Offset: 0x10CF930 VA: 0x1810D1330
	|-KdTree<float, int>.RemoveChildNodes
	|
	|-RVA: 0x10D13F0 Offset: 0x10CF9F0 VA: 0x1810D13F0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveChildNodes
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CECE0 Offset: 0x10CD2E0 VA: 0x1810CECE0
	|-KdTree<float, int>.Clear
	|
	|-RVA: 0x10CECB0 Offset: 0x10CD2B0 VA: 0x1810CECB0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SaveToFile(string filename) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D14E0 Offset: 0x10CFAE0 VA: 0x1810D14E0
	|-KdTree<float, int>.SaveToFile
	|
	|-RVA: 0x10D15F0 Offset: 0x10CFBF0 VA: 0x1810D15F0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SaveToFile
	*/

	// RVA: -1 Offset: -1
	public static KdTree<TKey, TValue> LoadFromFile(string filename) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CF8B0 Offset: 0x10CDEB0 VA: 0x1810CF8B0
	|-KdTree<float, int>.LoadFromFile
	|
	|-RVA: 0x10CFA20 Offset: 0x10CE020 VA: 0x1810CFA20
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.LoadFromFile
	*/

	[IteratorStateMachine(typeof(KdTree.<GetEnumerator>d__33<TKey, TValue>))]
	// RVA: -1 Offset: -1 Slot: 14
	public IEnumerator<KdTreeNode<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CEFF0 Offset: 0x10CD5F0 VA: 0x1810CEFF0
	|-KdTree<float, int>.GetEnumerator
	|
	|-RVA: 0x10CF080 Offset: 0x10CD680 VA: 0x1810CF080
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10D1BF0 Offset: 0x10D01F0 VA: 0x1810D1BF0
	|-KdTree<float, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD1C9C0 Offset: 0xD1AFC0 VA: 0x180D1C9C0
	|-KdTree<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
[DefaultMember("Item")]
[Serializable]
internal class KdTreeNode<TKey, TValue> // TypeDefIndex: 14004
{
	// Fields
	public TKey[] Point; // 0x0
	public TValue Value; // 0x0
	public List<TValue> Duplicates; // 0x0
	internal KdTreeNode<TKey, TValue> LeftChild; // 0x0
	internal KdTreeNode<TKey, TValue> RightChild; // 0x0

	// Properties
	internal KdTreeNode<TKey, TValue> Item { get; set; }
	public bool IsLeaf { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-KdTreeNode<float, int>..ctor
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TKey[] point, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC05940 Offset: 0xC03F40 VA: 0x180C05940
	|-KdTreeNode<float, int>..ctor
	|
	|-RVA: 0x10CBEC0 Offset: 0x10CA4C0 VA: 0x1810CBEC0
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal KdTreeNode<TKey, TValue> get_Item(int compare) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CC0E0 Offset: 0x10CA6E0 VA: 0x1810CC0E0
	|-KdTreeNode<float, int>.get_Item
	|
	|-RVA: 0x10CC080 Offset: 0x10CA680 VA: 0x1810CC080
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	internal void set_Item(int compare, KdTreeNode<TKey, TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CC1A0 Offset: 0x10CA7A0 VA: 0x1810CC1A0
	|-KdTreeNode<float, int>.set_Item
	|
	|-RVA: 0x10CC0F0 Offset: 0x10CA6F0 VA: 0x1810CC0F0
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool get_IsLeaf() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CC060 Offset: 0x10CA660 VA: 0x1810CC060
	|-KdTreeNode<float, int>.get_IsLeaf
	|
	|-RVA: 0x10CBFE0 Offset: 0x10CA5E0 VA: 0x1810CBFE0
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsLeaf
	*/

	// RVA: -1 Offset: -1
	public void AddDuplicate(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CB6B0 Offset: 0x10C9CB0 VA: 0x1810CB6B0
	|-KdTreeNode<float, int>.AddDuplicate
	|
	|-RVA: 0x10CB800 Offset: 0x10C9E00 VA: 0x1810CB800
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddDuplicate
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CBA50 Offset: 0x10CA050 VA: 0x1810CBA50
	|-KdTreeNode<float, int>.ToString
	|
	|-RVA: 0x10CBB70 Offset: 0x10CA170 VA: 0x1810CBB70
	|-KdTreeNode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal interface ITypeMath<T> // TypeDefIndex: 14005
{
	// Properties
	public abstract T MinValue { get; }
	public abstract T MaxValue { get; }
	public abstract T Zero { get; }
	public abstract T NegativeInfinity { get; }
	public abstract T PositiveInfinity { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Compare(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T get_MinValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.get_MinValue
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract T get_MaxValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.get_MaxValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract T Min(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.Min
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T Max(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.Max
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool AreEqual(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.AreEqual
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool AreEqual(T[] a, T[] b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.AreEqual
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract T Add(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract T Subtract(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.Subtract
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract T Multiply(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.Multiply
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract T get_Zero();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.get_Zero
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract T get_NegativeInfinity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.get_NegativeInfinity
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public abstract T get_PositiveInfinity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.get_PositiveInfinity
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract T DistanceSquaredBetweenPoints(T[] a, T[] b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeMath<__Il2CppFullySharedGenericType>.DistanceSquaredBetweenPoints
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal interface INearestNeighbourList<TItem, TDistance> // TypeDefIndex: 14006
{
	// Properties
	public abstract int MaxCapacity { get; }
	public abstract int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Add(TItem item, TDistance distance);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TItem GetFurtherest();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetFurtherest
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TItem RemoveFurtherest();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveFurtherest
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_MaxCapacity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_MaxCapacity
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal class NearestNeighbourList<TItem, TDistance> : INearestNeighbourList<TItem, TDistance> // TypeDefIndex: 14007
{
	// Fields
	private PriorityQueue<TItem, TDistance> queue; // 0x0
	private ITypeMath<TDistance> distanceMath; // 0x0
	private int maxCapacity; // 0x0

	// Properties
	public int MaxCapacity { get; }
	public int Count { get; }
	public bool IsCapacityReached { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int maxCapacity, ITypeMath<TDistance> distanceMath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A7FD0 Offset: 0x12A65D0 VA: 0x1812A7FD0
	|-NearestNeighbourList<object, float>..ctor
	|
	|-RVA: 0x12A8090 Offset: 0x12A6690 VA: 0x1812A8090
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public int get_MaxCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-NearestNeighbourList<object, float>.get_MaxCapacity
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_MaxCapacity
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8150 Offset: 0x12A6750 VA: 0x1812A8150
	|-NearestNeighbourList<object, float>.get_Count
	|
	|-RVA: 0x9C4E90 Offset: 0x9C3490 VA: 0x1809C4E90
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Add(TItem item, TDistance distance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A79F0 Offset: 0x12A5FF0 VA: 0x1812A79F0
	|-NearestNeighbourList<object, float>.Add
	|
	|-RVA: 0x12A7590 Offset: 0x12A5B90 VA: 0x1812A7590
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TItem GetFurtherest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A7D30 Offset: 0x12A6330 VA: 0x1812A7D30
	|-NearestNeighbourList<object, float>.GetFurtherest
	|
	|-RVA: 0x12A7DC0 Offset: 0x12A63C0 VA: 0x1812A7DC0
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetFurtherest
	*/

	// RVA: -1 Offset: -1
	public TDistance GetFurtherestDistance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A7CA0 Offset: 0x12A62A0 VA: 0x1812A7CA0
	|-NearestNeighbourList<object, float>.GetFurtherestDistance
	|
	|-RVA: 0x12A7B70 Offset: 0x12A6170 VA: 0x1812A7B70
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetFurtherestDistance
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TItem RemoveFurtherest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A7FA0 Offset: 0x12A65A0 VA: 0x1812A7FA0
	|-NearestNeighbourList<object, float>.RemoveFurtherest
	|
	|-RVA: 0x12A7EF0 Offset: 0x12A64F0 VA: 0x1812A7EF0
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveFurtherest
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCapacityReached() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8170 Offset: 0x12A6770 VA: 0x1812A8170
	|-NearestNeighbourList<object, float>.get_IsCapacityReached
	|
	|-RVA: 0x12A81A0 Offset: 0x12A67A0 VA: 0x1812A81A0
	|-NearestNeighbourList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsCapacityReached
	*/
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal struct ItemPriority<TItem, TPriority> // TypeDefIndex: 14008
{
	// Fields
	public TItem Item; // 0x0
	public TPriority Priority; // 0x0
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal class PriorityQueue<TItem, TPriority> : IPriorityQueue<TItem, TPriority> // TypeDefIndex: 14009
{
	// Fields
	private ITypeMath<TPriority> priorityMath; // 0x0
	private ItemPriority<TItem, TPriority>[] queue; // 0x0
	private int capacity; // 0x0
	private int count; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, ITypeMath<TPriority> priorityMath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F5F70 Offset: 0x12F4570 VA: 0x1812F5F70
	|-PriorityQueue<object, float>..ctor
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	|-PriorityQueue<object, float>.get_Count
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private void ExpandCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F5450 Offset: 0x12F3A50 VA: 0x1812F5450
	|-PriorityQueue<object, float>.ExpandCapacity
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ExpandCapacity
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Enqueue(TItem item, TPriority priority) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F52D0 Offset: 0x12F38D0 VA: 0x1812F52D0
	|-PriorityQueue<object, float>.Enqueue
	|
	|-RVA: 0x12F5010 Offset: 0x12F3610 VA: 0x1812F5010
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TItem Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F4C50 Offset: 0x12F3250 VA: 0x1812F4C50
	|-PriorityQueue<object, float>.Dequeue
	|
	|-RVA: 0x12F4DA0 Offset: 0x12F33A0 VA: 0x1812F4DA0
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dequeue
	*/

	// RVA: -1 Offset: -1
	private void ReorderItem(int index, int direction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F5D10 Offset: 0x12F4310 VA: 0x1812F5D10
	|-PriorityQueue<object, float>.ReorderItem
	|
	|-RVA: 0x12F5810 Offset: 0x12F3E10 VA: 0x1812F5810
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReorderItem
	*/

	// RVA: -1 Offset: -1
	public TItem GetHighest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F5670 Offset: 0x12F3C70 VA: 0x1812F5670
	|-PriorityQueue<object, float>.GetHighest
	|
	|-RVA: 0x12F56F0 Offset: 0x12F3CF0 VA: 0x1812F56F0
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHighest
	*/

	// RVA: -1 Offset: -1
	public TPriority GetHighestPriority() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F55F0 Offset: 0x12F3BF0 VA: 0x1812F55F0
	|-PriorityQueue<object, float>.GetHighestPriority
	|
	|-RVA: 0x12F54D0 Offset: 0x12F3AD0 VA: 0x1812F54D0
	|-PriorityQueue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHighestPriority
	*/
}

