// Namespace: System.Collections.ObjectModel
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[DefaultMember("Item")]
[Serializable]
public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 1487
{
	// Fields
	private IList<T> items; // 0x0

	// Properties
	public int Count { get; }
	protected IList<T> Items { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA46F0 Offset: 0xCA2CF0 VA: 0x180CA46F0
	|-Collection<object>..ctor
	|
	|-RVA: 0x9CE3F0 Offset: 0x9CC9F0 VA: 0x1809CE3F0
	|-Collection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x906AE0 Offset: 0x9050E0 VA: 0x180906AE0
	|-Collection<object>..ctor
	|-Collection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA4770 Offset: 0xCA2D70 VA: 0x180CA4770
	|-Collection<object>.get_Count
	|-Collection<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	protected IList<T> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-Collection<object>.get_Items
	|-Collection<__Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA4280 Offset: 0xCA2880 VA: 0x180CA4280
	|-Collection<object>.get_Item
	|
	|-RVA: 0xCA47C0 Offset: 0xCA2DC0 VA: 0x180CA47C0
	|-Collection<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA4A20 Offset: 0xCA3020 VA: 0x180CA4A20
	|-Collection<object>.set_Item
	|
	|-RVA: 0xCA4890 Offset: 0xCA2E90 VA: 0x180CA4890
	|-Collection<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA1420 Offset: 0xC9FA20 VA: 0x180CA1420
	|-Collection<object>.Add
	|
	|-RVA: 0xCA1500 Offset: 0xC9FB00 VA: 0x180CA1500
	|-Collection<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA16E0 Offset: 0xC9FCE0 VA: 0x180CA16E0
	|-Collection<object>.Clear
	|-Collection<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA19A0 Offset: 0xC9FFA0 VA: 0x180CA19A0
	|-Collection<object>.CopyTo
	|-Collection<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA18D0 Offset: 0xC9FED0 VA: 0x180CA18D0
	|-Collection<object>.Contains
	|
	|-RVA: 0xCA1760 Offset: 0xC9FD60 VA: 0x180CA1760
	|-Collection<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA1A10 Offset: 0xCA0010 VA: 0x180CA1A10
	|-Collection<object>.GetEnumerator
	|-Collection<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA1A60 Offset: 0xCA0060 VA: 0x180CA1A60
	|-Collection<object>.IndexOf
	|
	|-RVA: 0xCA1AC0 Offset: 0xCA00C0 VA: 0x180CA1AC0
	|-Collection<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA1D30 Offset: 0xCA0330 VA: 0x180CA1D30
	|-Collection<object>.Insert
	|
	|-RVA: 0xCA1E20 Offset: 0xCA0420 VA: 0x180CA1E20
	|-Collection<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA22A0 Offset: 0xCA08A0 VA: 0x180CA22A0
	|-Collection<object>.Remove
	|
	|-RVA: 0xCA2380 Offset: 0xCA0980 VA: 0x180CA2380
	|-Collection<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA2160 Offset: 0xCA0760 VA: 0x180CA2160
	|-Collection<object>.RemoveAt
	|-Collection<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected virtual void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA1690 Offset: 0xC9FC90 VA: 0x180CA1690
	|-Collection<object>.ClearItems
	|-Collection<__Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA1CC0 Offset: 0xCA02C0 VA: 0x180CA1CC0
	|-Collection<object>.InsertItem
	|
	|-RVA: 0xCA1BC0 Offset: 0xCA01C0 VA: 0x180CA1BC0
	|-Collection<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA2240 Offset: 0xCA0840 VA: 0x180CA2240
	|-Collection<object>.RemoveItem
	|-Collection<__Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA25F0 Offset: 0xCA0BF0 VA: 0x180CA25F0
	|-Collection<object>.SetItem
	|
	|-RVA: 0xCA24F0 Offset: 0xCA0AF0 VA: 0x180CA24F0
	|-Collection<__Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA2660 Offset: 0xCA0C60 VA: 0x180CA2660
	|-Collection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA3010 Offset: 0xCA1610 VA: 0x180CA3010
	|-Collection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCA2FC0 Offset: 0xCA15C0 VA: 0x180CA2FC0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-Collection<object>.System.Collections.ICollection.get_IsSynchronized
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA2F60 Offset: 0xCA1560 VA: 0x180CA2F60
	|-Collection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xCA2F00 Offset: 0xCA1500 VA: 0x180CA2F00
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA26B0 Offset: 0xCA0CB0 VA: 0x180CA26B0
	|-Collection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCA2AA0 Offset: 0xCA10A0 VA: 0x180CA2AA0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA4280 Offset: 0xCA2880 VA: 0x180CA4280
	|-Collection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0xCA42E0 Offset: 0xCA28E0 VA: 0x180CA42E0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA4530 Offset: 0xCA2B30 VA: 0x180CA4530
	|-Collection<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0xCA43B0 Offset: 0xCA29B0 VA: 0x180CA43B0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA2660 Offset: 0xCA0C60 VA: 0x180CA2660
	|-Collection<object>.System.Collections.IList.get_IsReadOnly
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA4120 Offset: 0xCA2720 VA: 0x180CA4120
	|-Collection<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0xCA41D0 Offset: 0xCA27D0 VA: 0x180CA41D0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA3060 Offset: 0xCA1660 VA: 0x180CA3060
	|-Collection<object>.System.Collections.IList.Add
	|
	|-RVA: 0xCA32B0 Offset: 0xCA18B0 VA: 0x180CA32B0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA35D0 Offset: 0xCA1BD0 VA: 0x180CA35D0
	|-Collection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0xCA34A0 Offset: 0xCA1AA0 VA: 0x180CA34A0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA3770 Offset: 0xCA1D70 VA: 0x180CA3770
	|-Collection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xCA38B0 Offset: 0xCA1EB0 VA: 0x180CA38B0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA3BB0 Offset: 0xCA21B0 VA: 0x180CA3BB0
	|-Collection<object>.System.Collections.IList.Insert
	|
	|-RVA: 0xCA39E0 Offset: 0xCA1FE0 VA: 0x180CA39E0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA3F30 Offset: 0xCA2530 VA: 0x180CA3F30
	|-Collection<object>.System.Collections.IList.Remove
	|
	|-RVA: 0xCA3DC0 Offset: 0xCA23C0 VA: 0x180CA3DC0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA2100 Offset: 0xCA0700 VA: 0x180CA2100
	|-Collection<object>.IsCompatibleObject
	|
	|-RVA: 0xCA1FB0 Offset: 0xCA05B0 VA: 0x180CA1FB0
	|-Collection<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/
}

// Namespace: System.Collections.ObjectModel
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 1488
{
	// Fields
	private IList<T> list; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x906AE0 Offset: 0x9050E0 VA: 0x180906AE0
	|-ReadOnlyCollection<AsyncOperationHandle<object>>..ctor
	|-ReadOnlyCollection<DataPoint<int>>..ctor
	|-ReadOnlyCollection<DataPoint<object>>..ctor
	|-ReadOnlyCollection<DataPoint<float>>..ctor
	|-ReadOnlyCollection<DataPoint<float4>>..ctor
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>..ctor
	|-ReadOnlyCollection<KeyValuePair<int, int>>..ctor
	|-ReadOnlyCollection<KeyValuePair<int, object>>..ctor
	|-ReadOnlyCollection<KeyValuePair<long, object>>..ctor
	|-ReadOnlyCollection<KeyValuePair<object, bool>>..ctor
	|-ReadOnlyCollection<KeyValuePair<object, object>>..ctor
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>..ctor
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>..ctor
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>..ctor
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>..ctor
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>..ctor
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>..ctor
	|-ReadOnlyCollection<NativeSlice<ushort>>..ctor
	|-ReadOnlyCollection<NativeSlice<Vertex>>..ctor
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>..ctor
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>..ctor
	|-ReadOnlyCollection<SimpleTuple<int, int>>..ctor
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>..ctor
	|-ReadOnlyCollection<SimpleTuple<object, int>>..ctor
	|-ReadOnlyCollection<SimpleTuple<object, object>>..ctor
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>..ctor
	|-ReadOnlyCollection<StructMultiKey<object, object>>..ctor
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>..ctor
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>..ctor
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>..ctor
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>..ctor
	|-ReadOnlyCollection<ValueTuple<int, int>>..ctor
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>..ctor
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>..ctor
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>..ctor
	|-ReadOnlyCollection<AsyncOperationHandle>..ctor
	|-ReadOnlyCollection<BezierKnot>..ctor
	|-ReadOnlyCollection<BezierPoint>..ctor
	|-ReadOnlyCollection<bool>..ctor
	|-ReadOnlyCollection<byte>..ctor
	|-ReadOnlyCollection<char>..ctor
	|-ReadOnlyCollection<Color>..ctor
	|-ReadOnlyCollection<Color32>..ctor
	|-ReadOnlyCollection<CombineInstance>..ctor
	|-ReadOnlyCollection<ComputedTransitionProperty>..ctor
	|-ReadOnlyCollection<ControllerPollingInfo>..ctor
	|-ReadOnlyCollection<ControllerTemplateElementTarget>..ctor
	|-ReadOnlyCollection<CustomAttributeNamedArgument>..ctor
	|-ReadOnlyCollection<CustomAttributeTypedArgument>..ctor
	|-ReadOnlyCollection<DateTime>..ctor
	|-ReadOnlyCollection<DateTimeOffset>..ctor
	|-ReadOnlyCollection<Decimal>..ctor
	|-ReadOnlyCollection<DiagnosticEvent>..ctor
	|-ReadOnlyCollection<DisplayInfo>..ctor
	|-ReadOnlyCollection<double>..ctor
	|-ReadOnlyCollection<EasingFunction>..ctor
	|-ReadOnlyCollection<Edge>..ctor
	|-ReadOnlyCollection<EdgeLookup>..ctor
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>..ctor
	|-ReadOnlyCollection<Entitlement>..ctor
	|-ReadOnlyCollection<FileStat>..ctor
	|-ReadOnlyCollection<GCHandle>..ctor
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>..ctor
	|-ReadOnlyCollection<GlyphRect>..ctor
	|-ReadOnlyCollection<Guid>..ctor
	|-ReadOnlyCollection<InputActionSourceData>..ctor
	|-ReadOnlyCollection<short>..ctor
	|-ReadOnlyCollection<int>..ctor
	|-ReadOnlyCollection<Int32Enum>..ctor
	|-ReadOnlyCollection<long>..ctor
	|-ReadOnlyCollection<IntPtr>..ctor
	|-ReadOnlyCollection<InterpretedFrameInfo>..ctor
	|-ReadOnlyCollection<JsonPosition>..ctor
	|-ReadOnlyCollection<LigatureSubstitutionRecord>..ctor
	|-ReadOnlyCollection<LigatureSubstitutionRecord>..ctor
	|-ReadOnlyCollection<ManipulatorActivationFilter>..ctor
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>..ctor
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>..ctor
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>..ctor
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>..ctor
	|-ReadOnlyCollection<MultipleSubstitutionRecord>..ctor
	|-ReadOnlyCollection<MultipleSubstitutionRecord>..ctor
	|-ReadOnlyCollection<object>..ctor
	|-ReadOnlyCollection<ObjectInitializationData>..ctor
	|-ReadOnlyCollection<PidVid>..ctor
	|-ReadOnlyCollection<PropertyPath>..ctor
	|-ReadOnlyCollection<PropertyPathInfo>..ctor
	|-ReadOnlyCollection<PropertyPathPart>..ctor
	|-ReadOnlyCollection<Quaternion>..ctor
	|-ReadOnlyCollection<RangePositionInfo>..ctor
	|-ReadOnlyCollection<RaycastHit2D>..ctor
	|-ReadOnlyCollection<RaycastResult>..ctor
	|-ReadOnlyCollection<RenderTargetIdentifier>..ctor
	|-ReadOnlyCollection<Resolution>..ctor
	|-ReadOnlyCollection<RuleMatcher>..ctor
	|-ReadOnlyCollection<sbyte>..ctor
	|-ReadOnlyCollection<SelectorMatchRecord>..ctor
	|-ReadOnlyCollection<SerializedCommand>..ctor
	|-ReadOnlyCollection<float>..ctor
	|-ReadOnlyCollection<Sku>..ctor
	|-ReadOnlyCollection<SplineKnotIndex>..ctor
	|-ReadOnlyCollection<StylePropertyName>..ctor
	|-ReadOnlyCollection<StylePropertyValue>..ctor
	|-ReadOnlyCollection<StyleSelectorPart>..ctor
	|-ReadOnlyCollection<StyleSyntaxToken>..ctor
	|-ReadOnlyCollection<StyleValue>..ctor
	|-ReadOnlyCollection<StyleValueManaged>..ctor
	|-ReadOnlyCollection<StyleVariable>..ctor
	|-ReadOnlyCollection<TimeSpan>..ctor
	|-ReadOnlyCollection<TimeValue>..ctor
	|-ReadOnlyCollection<TreeViewItemWrapper>..ctor
	|-ReadOnlyCollection<Triangle>..ctor
	|-ReadOnlyCollection<TypeWrapper>..ctor
	|-ReadOnlyCollection<UICharInfo>..ctor
	|-ReadOnlyCollection<UILineInfo>..ctor
	|-ReadOnlyCollection<UIVertex>..ctor
	|-ReadOnlyCollection<ushort>..ctor
	|-ReadOnlyCollection<uint>..ctor
	|-ReadOnlyCollection<UInt32Enum>..ctor
	|-ReadOnlyCollection<ulong>..ctor
	|-ReadOnlyCollection<User>..ctor
	|-ReadOnlyCollection<UxmlDescription>..ctor
	|-ReadOnlyCollection<UxmlNamespaceDefinition>..ctor
	|-ReadOnlyCollection<Vector2>..ctor
	|-ReadOnlyCollection<Vector2Int>..ctor
	|-ReadOnlyCollection<Vector3>..ctor
	|-ReadOnlyCollection<Vector4>..ctor
	|-ReadOnlyCollection<X509ChainStatus>..ctor
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>..ctor
	|-ReadOnlyCollection<float3>..ctor
	|-ReadOnlyCollection<fsVersionedType>..ctor
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>..ctor
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>..ctor
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>..ctor
	|-ReadOnlyCollection<BitmapAllocator32.Page>..ctor
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>..ctor
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>..ctor
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>..ctor
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>..ctor
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>..ctor
	|-ReadOnlyCollection<DataBindingManager.BindingData>..ctor
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>..ctor
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>..ctor
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>..ctor
	|-ReadOnlyCollection<EventProvider.Registration>..ctor
	|-ReadOnlyCollection<Expander.ExpansionRule>..ctor
	|-ReadOnlyCollection<FocusController.FocusedElement>..ctor
	|-ReadOnlyCollection<GrassChunkManager.GrassData>..ctor
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>..ctor
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>..ctor
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>..ctor
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>..ctor
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>..ctor
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>..ctor
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>..ctor
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>..ctor
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>..ctor
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>..ctor
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>..ctor
	|-ReadOnlyCollection<RegexCharClass.SingleRange>..ctor
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>..ctor
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>..ctor
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>..ctor
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>..ctor
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>..ctor
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>..ctor
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>..ctor
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>..ctor
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>..ctor
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>..ctor
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>..ctor
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>..ctor
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>..ctor
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>..ctor
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>..ctor
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>..ctor
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>..ctor
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>..ctor
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>..ctor
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>..ctor
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>..ctor
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>..ctor
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>..ctor
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>..ctor
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>..ctor
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x906B20 Offset: 0x905120 VA: 0x180906B20
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.get_Count
	|-ReadOnlyCollection<DataPoint<int>>.get_Count
	|-ReadOnlyCollection<DataPoint<object>>.get_Count
	|-ReadOnlyCollection<DataPoint<float>>.get_Count
	|-ReadOnlyCollection<DataPoint<float4>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<int, int>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<long, object>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.get_Count
	|-ReadOnlyCollection<KeyValuePair<object, object>>.get_Count
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.get_Count
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.get_Count
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.get_Count
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.get_Count
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.get_Count
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.get_Count
	|-ReadOnlyCollection<NativeSlice<ushort>>.get_Count
	|-ReadOnlyCollection<NativeSlice<Vertex>>.get_Count
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.get_Count
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.get_Count
	|-ReadOnlyCollection<SimpleTuple<int, int>>.get_Count
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.get_Count
	|-ReadOnlyCollection<SimpleTuple<object, int>>.get_Count
	|-ReadOnlyCollection<SimpleTuple<object, object>>.get_Count
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.get_Count
	|-ReadOnlyCollection<StructMultiKey<object, object>>.get_Count
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.get_Count
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.get_Count
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.get_Count
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.get_Count
	|-ReadOnlyCollection<ValueTuple<int, int>>.get_Count
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.get_Count
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.get_Count
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.get_Count
	|-ReadOnlyCollection<AsyncOperationHandle>.get_Count
	|-ReadOnlyCollection<BezierKnot>.get_Count
	|-ReadOnlyCollection<BezierPoint>.get_Count
	|-ReadOnlyCollection<bool>.get_Count
	|-ReadOnlyCollection<byte>.get_Count
	|-ReadOnlyCollection<char>.get_Count
	|-ReadOnlyCollection<Color>.get_Count
	|-ReadOnlyCollection<Color32>.get_Count
	|-ReadOnlyCollection<CombineInstance>.get_Count
	|-ReadOnlyCollection<ComputedTransitionProperty>.get_Count
	|-ReadOnlyCollection<ControllerPollingInfo>.get_Count
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.get_Count
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Count
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Count
	|-ReadOnlyCollection<DateTime>.get_Count
	|-ReadOnlyCollection<DateTimeOffset>.get_Count
	|-ReadOnlyCollection<Decimal>.get_Count
	|-ReadOnlyCollection<DiagnosticEvent>.get_Count
	|-ReadOnlyCollection<DisplayInfo>.get_Count
	|-ReadOnlyCollection<double>.get_Count
	|-ReadOnlyCollection<EasingFunction>.get_Count
	|-ReadOnlyCollection<Edge>.get_Count
	|-ReadOnlyCollection<EdgeLookup>.get_Count
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.get_Count
	|-ReadOnlyCollection<Entitlement>.get_Count
	|-ReadOnlyCollection<FileStat>.get_Count
	|-ReadOnlyCollection<GCHandle>.get_Count
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.get_Count
	|-ReadOnlyCollection<GlyphRect>.get_Count
	|-ReadOnlyCollection<Guid>.get_Count
	|-ReadOnlyCollection<InputActionSourceData>.get_Count
	|-ReadOnlyCollection<short>.get_Count
	|-ReadOnlyCollection<int>.get_Count
	|-ReadOnlyCollection<Int32Enum>.get_Count
	|-ReadOnlyCollection<long>.get_Count
	|-ReadOnlyCollection<IntPtr>.get_Count
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Count
	|-ReadOnlyCollection<JsonPosition>.get_Count
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.get_Count
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.get_Count
	|-ReadOnlyCollection<ManipulatorActivationFilter>.get_Count
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.get_Count
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.get_Count
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.get_Count
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.get_Count
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.get_Count
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.get_Count
	|-ReadOnlyCollection<object>.get_Count
	|-ReadOnlyCollection<ObjectInitializationData>.get_Count
	|-ReadOnlyCollection<PidVid>.get_Count
	|-ReadOnlyCollection<PropertyPath>.get_Count
	|-ReadOnlyCollection<PropertyPathInfo>.get_Count
	|-ReadOnlyCollection<PropertyPathPart>.get_Count
	|-ReadOnlyCollection<Quaternion>.get_Count
	|-ReadOnlyCollection<RangePositionInfo>.get_Count
	|-ReadOnlyCollection<RaycastHit2D>.get_Count
	|-ReadOnlyCollection<RaycastResult>.get_Count
	|-ReadOnlyCollection<RenderTargetIdentifier>.get_Count
	|-ReadOnlyCollection<Resolution>.get_Count
	|-ReadOnlyCollection<RuleMatcher>.get_Count
	|-ReadOnlyCollection<sbyte>.get_Count
	|-ReadOnlyCollection<SelectorMatchRecord>.get_Count
	|-ReadOnlyCollection<SerializedCommand>.get_Count
	|-ReadOnlyCollection<float>.get_Count
	|-ReadOnlyCollection<Sku>.get_Count
	|-ReadOnlyCollection<SplineKnotIndex>.get_Count
	|-ReadOnlyCollection<StylePropertyName>.get_Count
	|-ReadOnlyCollection<StylePropertyValue>.get_Count
	|-ReadOnlyCollection<StyleSelectorPart>.get_Count
	|-ReadOnlyCollection<StyleSyntaxToken>.get_Count
	|-ReadOnlyCollection<StyleValue>.get_Count
	|-ReadOnlyCollection<StyleValueManaged>.get_Count
	|-ReadOnlyCollection<StyleVariable>.get_Count
	|-ReadOnlyCollection<TimeSpan>.get_Count
	|-ReadOnlyCollection<TimeValue>.get_Count
	|-ReadOnlyCollection<TreeViewItemWrapper>.get_Count
	|-ReadOnlyCollection<Triangle>.get_Count
	|-ReadOnlyCollection<TypeWrapper>.get_Count
	|-ReadOnlyCollection<UICharInfo>.get_Count
	|-ReadOnlyCollection<UILineInfo>.get_Count
	|-ReadOnlyCollection<UIVertex>.get_Count
	|-ReadOnlyCollection<ushort>.get_Count
	|-ReadOnlyCollection<uint>.get_Count
	|-ReadOnlyCollection<UInt32Enum>.get_Count
	|-ReadOnlyCollection<ulong>.get_Count
	|-ReadOnlyCollection<User>.get_Count
	|-ReadOnlyCollection<UxmlDescription>.get_Count
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.get_Count
	|-ReadOnlyCollection<Vector2>.get_Count
	|-ReadOnlyCollection<Vector2Int>.get_Count
	|-ReadOnlyCollection<Vector3>.get_Count
	|-ReadOnlyCollection<Vector4>.get_Count
	|-ReadOnlyCollection<X509ChainStatus>.get_Count
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Count
	|-ReadOnlyCollection<float3>.get_Count
	|-ReadOnlyCollection<fsVersionedType>.get_Count
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.get_Count
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.get_Count
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Count
	|-ReadOnlyCollection<BitmapAllocator32.Page>.get_Count
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.get_Count
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.get_Count
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.get_Count
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.get_Count
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.get_Count
	|-ReadOnlyCollection<DataBindingManager.BindingData>.get_Count
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.get_Count
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.get_Count
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.get_Count
	|-ReadOnlyCollection<EventProvider.Registration>.get_Count
	|-ReadOnlyCollection<Expander.ExpansionRule>.get_Count
	|-ReadOnlyCollection<FocusController.FocusedElement>.get_Count
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.get_Count
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.get_Count
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.get_Count
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.get_Count
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.get_Count
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.get_Count
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.get_Count
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.get_Count
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.get_Count
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.get_Count
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Count
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.get_Count
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.get_Count
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.get_Count
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.get_Count
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.get_Count
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.get_Count
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.get_Count
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.get_Count
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.get_Count
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.get_Count
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.get_Count
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.get_Count
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.get_Count
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Count
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.get_Count
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.get_Count
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.get_Count
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.get_Count
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.get_Count
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.get_Count
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.get_Count
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Count
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.get_Count
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.get_Count
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.get_Count
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.get_Count
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.get_Count
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.get_Count
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.get_Count
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDCC0 Offset: 0x8FC2C0 VA: 0x1808FDCC0
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.get_Item
	|-ReadOnlyCollection<PropertyPathPart>.get_Item
	|-ReadOnlyCollection<TypeWrapper>.get_Item
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.get_Item
	|-ReadOnlyCollection<EventProvider.Registration>.get_Item
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.get_Item
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.get_Item
	|
	|-RVA: 0x8FDC60 Offset: 0x8FC260 VA: 0x1808FDC60
	|-ReadOnlyCollection<DataPoint<int>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<int, int>>.get_Item
	|-ReadOnlyCollection<SimpleTuple<int, int>>.get_Item
	|-ReadOnlyCollection<ValueTuple<int, int>>.get_Item
	|-ReadOnlyCollection<bool>.get_Item
	|-ReadOnlyCollection<byte>.get_Item
	|-ReadOnlyCollection<char>.get_Item
	|-ReadOnlyCollection<Color32>.get_Item
	|-ReadOnlyCollection<DateTime>.get_Item
	|-ReadOnlyCollection<EasingFunction>.get_Item
	|-ReadOnlyCollection<Edge>.get_Item
	|-ReadOnlyCollection<GCHandle>.get_Item
	|-ReadOnlyCollection<short>.get_Item
	|-ReadOnlyCollection<int>.get_Item
	|-ReadOnlyCollection<Int32Enum>.get_Item
	|-ReadOnlyCollection<long>.get_Item
	|-ReadOnlyCollection<IntPtr>.get_Item
	|-ReadOnlyCollection<object>.get_Item
	|-ReadOnlyCollection<PidVid>.get_Item
	|-ReadOnlyCollection<sbyte>.get_Item
	|-ReadOnlyCollection<SplineKnotIndex>.get_Item
	|-ReadOnlyCollection<TimeSpan>.get_Item
	|-ReadOnlyCollection<TimeValue>.get_Item
	|-ReadOnlyCollection<ushort>.get_Item
	|-ReadOnlyCollection<uint>.get_Item
	|-ReadOnlyCollection<UInt32Enum>.get_Item
	|-ReadOnlyCollection<ulong>.get_Item
	|-ReadOnlyCollection<Vector2Int>.get_Item
	|-ReadOnlyCollection<BitmapAllocator32.Page>.get_Item
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.get_Item
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.get_Item
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.get_Item
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.get_Item
	|
	|-RVA: 0x8FDAB0 Offset: 0x8FC0B0 VA: 0x1808FDAB0
	|-ReadOnlyCollection<DataPoint<object>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<int, object>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<long, object>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, object>>.get_Item
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.get_Item
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.get_Item
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.get_Item
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.get_Item
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.get_Item
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.get_Item
	|-ReadOnlyCollection<NativeSlice<ushort>>.get_Item
	|-ReadOnlyCollection<NativeSlice<Vertex>>.get_Item
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.get_Item
	|-ReadOnlyCollection<SimpleTuple<object, int>>.get_Item
	|-ReadOnlyCollection<SimpleTuple<object, object>>.get_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.get_Item
	|-ReadOnlyCollection<Color>.get_Item
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.get_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Item
	|-ReadOnlyCollection<DateTimeOffset>.get_Item
	|-ReadOnlyCollection<Decimal>.get_Item
	|-ReadOnlyCollection<EdgeLookup>.get_Item
	|-ReadOnlyCollection<GlyphRect>.get_Item
	|-ReadOnlyCollection<Guid>.get_Item
	|-ReadOnlyCollection<InterpretedFrameInfo>.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.get_Item
	|-ReadOnlyCollection<Quaternion>.get_Item
	|-ReadOnlyCollection<RangePositionInfo>.get_Item
	|-ReadOnlyCollection<Resolution>.get_Item
	|-ReadOnlyCollection<RuleMatcher>.get_Item
	|-ReadOnlyCollection<StylePropertyName>.get_Item
	|-ReadOnlyCollection<StylePropertyValue>.get_Item
	|-ReadOnlyCollection<StyleValueManaged>.get_Item
	|-ReadOnlyCollection<UILineInfo>.get_Item
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.get_Item
	|-ReadOnlyCollection<Vector4>.get_Item
	|-ReadOnlyCollection<X509ChainStatus>.get_Item
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.get_Item
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.get_Item
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.get_Item
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.get_Item
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.get_Item
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.get_Item
	|-ReadOnlyCollection<FocusController.FocusedElement>.get_Item
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.get_Item
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.get_Item
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.get_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.get_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.get_Item
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Item
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.get_Item
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.get_Item
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.get_Item
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.get_Item
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.get_Item
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.get_Item
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.get_Item
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Item
	|
	|-RVA: 0x8FDC00 Offset: 0x8FC200 VA: 0x1808FDC00
	|-ReadOnlyCollection<DataPoint<float>>.get_Item
	|-ReadOnlyCollection<Vector2>.get_Item
	|
	|-RVA: 0x8FDD40 Offset: 0x8FC340 VA: 0x1808FDD40
	|-ReadOnlyCollection<DataPoint<float4>>.get_Item
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.get_Item
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.get_Item
	|
	|-RVA: 0x8FDB80 Offset: 0x8FC180 VA: 0x1808FDB80
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.get_Item
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.get_Item
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.get_Item
	|-ReadOnlyCollection<AsyncOperationHandle>.get_Item
	|-ReadOnlyCollection<ComputedTransitionProperty>.get_Item
	|-ReadOnlyCollection<Entitlement>.get_Item
	|-ReadOnlyCollection<FileStat>.get_Item
	|-ReadOnlyCollection<InputActionSourceData>.get_Item
	|-ReadOnlyCollection<JsonPosition>.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.get_Item
	|-ReadOnlyCollection<SelectorMatchRecord>.get_Item
	|-ReadOnlyCollection<StyleSelectorPart>.get_Item
	|-ReadOnlyCollection<StyleSyntaxToken>.get_Item
	|-ReadOnlyCollection<StyleValue>.get_Item
	|-ReadOnlyCollection<StyleVariable>.get_Item
	|-ReadOnlyCollection<TreeViewItemWrapper>.get_Item
	|-ReadOnlyCollection<fsVersionedType>.get_Item
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.get_Item
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.get_Item
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.get_Item
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.get_Item
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.get_Item
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.get_Item
	|
	|-RVA: 0x90A830 Offset: 0x908E30 VA: 0x18090A830
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.get_Item
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.get_Item
	|-ReadOnlyCollection<ManipulatorActivationFilter>.get_Item
	|-ReadOnlyCollection<Triangle>.get_Item
	|-ReadOnlyCollection<UICharInfo>.get_Item
	|-ReadOnlyCollection<Vector3>.get_Item
	|-ReadOnlyCollection<float3>.get_Item
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.get_Item
	|-ReadOnlyCollection<Expander.ExpansionRule>.get_Item
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.get_Item
	|
	|-RVA: 0x90AB10 Offset: 0x909110 VA: 0x18090AB10
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.get_Item
	|-ReadOnlyCollection<RenderTargetIdentifier>.get_Item
	|-ReadOnlyCollection<Sku>.get_Item
	|-ReadOnlyCollection<User>.get_Item
	|-ReadOnlyCollection<UxmlDescription>.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.get_Item
	|
	|-RVA: 0x90A940 Offset: 0x908F40 VA: 0x18090A940
	|-ReadOnlyCollection<BezierKnot>.get_Item
	|-ReadOnlyCollection<BezierPoint>.get_Item
	|
	|-RVA: 0x90AA60 Offset: 0x909060 VA: 0x18090AA60
	|-ReadOnlyCollection<CombineInstance>.get_Item
	|
	|-RVA: 0x90A9D0 Offset: 0x908FD0 VA: 0x18090A9D0
	|-ReadOnlyCollection<ControllerPollingInfo>.get_Item
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.get_Item
	|
	|-RVA: 0x90A7A0 Offset: 0x908DA0 VA: 0x18090A7A0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Item
	|-ReadOnlyCollection<DiagnosticEvent>.get_Item
	|-ReadOnlyCollection<DisplayInfo>.get_Item
	|-ReadOnlyCollection<ObjectInitializationData>.get_Item
	|
	|-RVA: 0x90ABA0 Offset: 0x9091A0 VA: 0x18090ABA0
	|-ReadOnlyCollection<double>.get_Item
	|-ReadOnlyCollection<float>.get_Item
	|
	|-RVA: 0x90A8B0 Offset: 0x908EB0 VA: 0x18090A8B0
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.get_Item
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.get_Item
	|
	|-RVA: 0x91D090 Offset: 0x91B690 VA: 0x18091D090
	|-ReadOnlyCollection<PropertyPath>.get_Item
	|
	|-RVA: 0x91CFB0 Offset: 0x91B5B0 VA: 0x18091CFB0
	|-ReadOnlyCollection<PropertyPathInfo>.get_Item
	|
	|-RVA: 0x91D210 Offset: 0x91B810 VA: 0x18091D210
	|-ReadOnlyCollection<RaycastHit2D>.get_Item
	|
	|-RVA: 0x91CF10 Offset: 0x91B510 VA: 0x18091CF10
	|-ReadOnlyCollection<RaycastResult>.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.get_Item
	|
	|-RVA: 0x91D160 Offset: 0x91B760 VA: 0x18091D160
	|-ReadOnlyCollection<SerializedCommand>.get_Item
	|
	|-RVA: 0x92EB00 Offset: 0x92D100 VA: 0x18092EB00
	|-ReadOnlyCollection<UIVertex>.get_Item
	|
	|-RVA: 0x92EC50 Offset: 0x92D250 VA: 0x18092EC50
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x92EA20 Offset: 0x92D020 VA: 0x18092EA20
	|-ReadOnlyCollection<DataBindingManager.BindingData>.get_Item
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.get_Item
	|
	|-RVA: 0x92EBC0 Offset: 0x92D1C0 VA: 0x18092EBC0
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.get_Item
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.get_Item
	|
	|-RVA: 0x93FC60 Offset: 0x93E260 VA: 0x18093FC60
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.get_Item
	|
	|-RVA: 0x93FB60 Offset: 0x93E160 VA: 0x18093FB60
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FD370 Offset: 0x8FB970 VA: 0x1808FD370
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.Contains
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Contains
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Contains
	|-ReadOnlyCollection<PropertyPathPart>.Contains
	|-ReadOnlyCollection<TypeWrapper>.Contains
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.Contains
	|-ReadOnlyCollection<EventProvider.Registration>.Contains
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.Contains
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.Contains
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.Contains
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.Contains
	|
	|-RVA: 0x8FD0F0 Offset: 0x8FB6F0 VA: 0x1808FD0F0
	|-ReadOnlyCollection<DataPoint<int>>.Contains
	|-ReadOnlyCollection<KeyValuePair<int, int>>.Contains
	|-ReadOnlyCollection<SimpleTuple<int, int>>.Contains
	|-ReadOnlyCollection<ValueTuple<int, int>>.Contains
	|-ReadOnlyCollection<DateTime>.Contains
	|-ReadOnlyCollection<Edge>.Contains
	|-ReadOnlyCollection<GCHandle>.Contains
	|-ReadOnlyCollection<SplineKnotIndex>.Contains
	|-ReadOnlyCollection<TimeSpan>.Contains
	|-ReadOnlyCollection<TimeValue>.Contains
	|-ReadOnlyCollection<Vector2Int>.Contains
	|-ReadOnlyCollection<BitmapAllocator32.Page>.Contains
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.Contains
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Contains
	|
	|-RVA: 0x8FD020 Offset: 0x8FB620 VA: 0x1808FD020
	|-ReadOnlyCollection<DataPoint<object>>.Contains
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.Contains
	|-ReadOnlyCollection<KeyValuePair<int, object>>.Contains
	|-ReadOnlyCollection<KeyValuePair<long, object>>.Contains
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.Contains
	|-ReadOnlyCollection<KeyValuePair<object, object>>.Contains
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.Contains
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.Contains
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.Contains
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.Contains
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.Contains
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.Contains
	|-ReadOnlyCollection<NativeSlice<ushort>>.Contains
	|-ReadOnlyCollection<NativeSlice<Vertex>>.Contains
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.Contains
	|-ReadOnlyCollection<SimpleTuple<object, int>>.Contains
	|-ReadOnlyCollection<SimpleTuple<object, object>>.Contains
	|-ReadOnlyCollection<StructMultiKey<object, object>>.Contains
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Contains
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Contains
	|-ReadOnlyCollection<Color>.Contains
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.Contains
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.Contains
	|-ReadOnlyCollection<DateTimeOffset>.Contains
	|-ReadOnlyCollection<Decimal>.Contains
	|-ReadOnlyCollection<EdgeLookup>.Contains
	|-ReadOnlyCollection<GlyphRect>.Contains
	|-ReadOnlyCollection<Guid>.Contains
	|-ReadOnlyCollection<InterpretedFrameInfo>.Contains
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.Contains
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.Contains
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.Contains
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.Contains
	|-ReadOnlyCollection<Quaternion>.Contains
	|-ReadOnlyCollection<RangePositionInfo>.Contains
	|-ReadOnlyCollection<Resolution>.Contains
	|-ReadOnlyCollection<RuleMatcher>.Contains
	|-ReadOnlyCollection<StylePropertyName>.Contains
	|-ReadOnlyCollection<StylePropertyValue>.Contains
	|-ReadOnlyCollection<StyleValueManaged>.Contains
	|-ReadOnlyCollection<UILineInfo>.Contains
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.Contains
	|-ReadOnlyCollection<Vector4>.Contains
	|-ReadOnlyCollection<X509ChainStatus>.Contains
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.Contains
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.Contains
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.Contains
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.Contains
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.Contains
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.Contains
	|-ReadOnlyCollection<FocusController.FocusedElement>.Contains
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.Contains
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.Contains
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.Contains
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.Contains
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.Contains
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.Contains
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.Contains
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.Contains
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.Contains
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.Contains
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.Contains
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.Contains
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.Contains
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.Contains
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.Contains
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.Contains
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.Contains
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Contains
	|
	|-RVA: 0x8FD2A0 Offset: 0x8FB8A0 VA: 0x1808FD2A0
	|-ReadOnlyCollection<DataPoint<float>>.Contains
	|-ReadOnlyCollection<Vector2>.Contains
	|
	|-RVA: 0x8FCF40 Offset: 0x8FB540 VA: 0x1808FCF40
	|-ReadOnlyCollection<DataPoint<float4>>.Contains
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.Contains
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.Contains
	|
	|-RVA: 0x8FD1C0 Offset: 0x8FB7C0 VA: 0x1808FD1C0
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.Contains
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.Contains
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.Contains
	|-ReadOnlyCollection<AsyncOperationHandle>.Contains
	|-ReadOnlyCollection<ComputedTransitionProperty>.Contains
	|-ReadOnlyCollection<Entitlement>.Contains
	|-ReadOnlyCollection<FileStat>.Contains
	|-ReadOnlyCollection<InputActionSourceData>.Contains
	|-ReadOnlyCollection<JsonPosition>.Contains
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.Contains
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.Contains
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.Contains
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.Contains
	|-ReadOnlyCollection<SelectorMatchRecord>.Contains
	|-ReadOnlyCollection<StyleSelectorPart>.Contains
	|-ReadOnlyCollection<StyleSyntaxToken>.Contains
	|-ReadOnlyCollection<StyleValue>.Contains
	|-ReadOnlyCollection<StyleVariable>.Contains
	|-ReadOnlyCollection<TreeViewItemWrapper>.Contains
	|-ReadOnlyCollection<fsVersionedType>.Contains
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.Contains
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.Contains
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.Contains
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.Contains
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.Contains
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.Contains
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.Contains
	|
	|-RVA: 0x909930 Offset: 0x907F30 VA: 0x180909930
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.Contains
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.Contains
	|-ReadOnlyCollection<ManipulatorActivationFilter>.Contains
	|-ReadOnlyCollection<Triangle>.Contains
	|-ReadOnlyCollection<UICharInfo>.Contains
	|-ReadOnlyCollection<Vector3>.Contains
	|-ReadOnlyCollection<float3>.Contains
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.Contains
	|-ReadOnlyCollection<Expander.ExpansionRule>.Contains
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.Contains
	|
	|-RVA: 0x909840 Offset: 0x907E40 VA: 0x180909840
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.Contains
	|-ReadOnlyCollection<RenderTargetIdentifier>.Contains
	|-ReadOnlyCollection<Sku>.Contains
	|-ReadOnlyCollection<User>.Contains
	|-ReadOnlyCollection<UxmlDescription>.Contains
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.Contains
	|
	|-RVA: 0x9093E0 Offset: 0x9079E0 VA: 0x1809093E0
	|-ReadOnlyCollection<BezierKnot>.Contains
	|-ReadOnlyCollection<BezierPoint>.Contains
	|
	|-RVA: 0x909AE0 Offset: 0x9080E0 VA: 0x180909AE0
	|-ReadOnlyCollection<bool>.Contains
	|-ReadOnlyCollection<byte>.Contains
	|-ReadOnlyCollection<sbyte>.Contains
	|
	|-RVA: 0x9095C0 Offset: 0x907BC0 VA: 0x1809095C0
	|-ReadOnlyCollection<char>.Contains
	|-ReadOnlyCollection<short>.Contains
	|-ReadOnlyCollection<ushort>.Contains
	|
	|-RVA: 0x909690 Offset: 0x907C90 VA: 0x180909690
	|-ReadOnlyCollection<Color32>.Contains
	|-ReadOnlyCollection<EasingFunction>.Contains
	|-ReadOnlyCollection<PidVid>.Contains
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.Contains
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.Contains
	|
	|-RVA: 0x909CA0 Offset: 0x9082A0 VA: 0x180909CA0
	|-ReadOnlyCollection<CombineInstance>.Contains
	|
	|-RVA: 0x909BB0 Offset: 0x9081B0 VA: 0x180909BB0
	|-ReadOnlyCollection<ControllerPollingInfo>.Contains
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.Contains
	|
	|-RVA: 0x909760 Offset: 0x907D60 VA: 0x180909760
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.Contains
	|-ReadOnlyCollection<DiagnosticEvent>.Contains
	|-ReadOnlyCollection<DisplayInfo>.Contains
	|-ReadOnlyCollection<ObjectInitializationData>.Contains
	|
	|-RVA: 0x909A10 Offset: 0x908010 VA: 0x180909A10
	|-ReadOnlyCollection<double>.Contains
	|-ReadOnlyCollection<float>.Contains
	|
	|-RVA: 0x9094D0 Offset: 0x907AD0 VA: 0x1809094D0
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.Contains
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.Contains
	|
	|-RVA: 0x91C0D0 Offset: 0x91A6D0 VA: 0x18091C0D0
	|-ReadOnlyCollection<int>.Contains
	|-ReadOnlyCollection<Int32Enum>.Contains
	|-ReadOnlyCollection<uint>.Contains
	|-ReadOnlyCollection<UInt32Enum>.Contains
	|
	|-RVA: 0x91C760 Offset: 0x91AD60 VA: 0x18091C760
	|-ReadOnlyCollection<long>.Contains
	|-ReadOnlyCollection<IntPtr>.Contains
	|
	|-RVA: 0x91C470 Offset: 0x91AA70 VA: 0x18091C470
	|-ReadOnlyCollection<object>.Contains
	|-ReadOnlyCollection<ulong>.Contains
	|
	|-RVA: 0x91C340 Offset: 0x91A940 VA: 0x18091C340
	|-ReadOnlyCollection<PropertyPath>.Contains
	|
	|-RVA: 0x91C620 Offset: 0x91AC20 VA: 0x18091C620
	|-ReadOnlyCollection<PropertyPathInfo>.Contains
	|
	|-RVA: 0x91C540 Offset: 0x91AB40 VA: 0x18091C540
	|-ReadOnlyCollection<RaycastHit2D>.Contains
	|
	|-RVA: 0x91C240 Offset: 0x91A840 VA: 0x18091C240
	|-ReadOnlyCollection<RaycastResult>.Contains
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.Contains
	|
	|-RVA: 0x91C130 Offset: 0x91A730 VA: 0x18091C130
	|-ReadOnlyCollection<SerializedCommand>.Contains
	|
	|-RVA: 0x92E1D0 Offset: 0x92C7D0 VA: 0x18092E1D0
	|-ReadOnlyCollection<UIVertex>.Contains
	|
	|-RVA: 0x92E060 Offset: 0x92C660 VA: 0x18092E060
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x92DF10 Offset: 0x92C510 VA: 0x18092DF10
	|-ReadOnlyCollection<DataBindingManager.BindingData>.Contains
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.Contains
	|
	|-RVA: 0x92E300 Offset: 0x92C900 VA: 0x18092E300
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.Contains
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.Contains
	|
	|-RVA: 0x93F6A0 Offset: 0x93DCA0 VA: 0x18093F6A0
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.Contains
	|
	|-RVA: 0x93F7A0 Offset: 0x93DDA0 VA: 0x18093F7A0
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FD450 Offset: 0x8FBA50 VA: 0x1808FD450
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.CopyTo
	|-ReadOnlyCollection<DataPoint<int>>.CopyTo
	|-ReadOnlyCollection<DataPoint<object>>.CopyTo
	|-ReadOnlyCollection<DataPoint<float>>.CopyTo
	|-ReadOnlyCollection<DataPoint<float4>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<int, int>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<int, object>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<long, object>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.CopyTo
	|-ReadOnlyCollection<KeyValuePair<object, object>>.CopyTo
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.CopyTo
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.CopyTo
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.CopyTo
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.CopyTo
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.CopyTo
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.CopyTo
	|-ReadOnlyCollection<NativeSlice<ushort>>.CopyTo
	|-ReadOnlyCollection<NativeSlice<Vertex>>.CopyTo
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.CopyTo
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.CopyTo
	|-ReadOnlyCollection<SimpleTuple<int, int>>.CopyTo
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.CopyTo
	|-ReadOnlyCollection<SimpleTuple<object, int>>.CopyTo
	|-ReadOnlyCollection<SimpleTuple<object, object>>.CopyTo
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.CopyTo
	|-ReadOnlyCollection<StructMultiKey<object, object>>.CopyTo
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.CopyTo
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.CopyTo
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.CopyTo
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.CopyTo
	|-ReadOnlyCollection<ValueTuple<int, int>>.CopyTo
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.CopyTo
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.CopyTo
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.CopyTo
	|-ReadOnlyCollection<AsyncOperationHandle>.CopyTo
	|-ReadOnlyCollection<BezierKnot>.CopyTo
	|-ReadOnlyCollection<BezierPoint>.CopyTo
	|-ReadOnlyCollection<bool>.CopyTo
	|-ReadOnlyCollection<byte>.CopyTo
	|-ReadOnlyCollection<char>.CopyTo
	|-ReadOnlyCollection<Color>.CopyTo
	|-ReadOnlyCollection<Color32>.CopyTo
	|-ReadOnlyCollection<CombineInstance>.CopyTo
	|-ReadOnlyCollection<ComputedTransitionProperty>.CopyTo
	|-ReadOnlyCollection<ControllerPollingInfo>.CopyTo
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.CopyTo
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.CopyTo
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.CopyTo
	|-ReadOnlyCollection<DateTime>.CopyTo
	|-ReadOnlyCollection<DateTimeOffset>.CopyTo
	|-ReadOnlyCollection<Decimal>.CopyTo
	|-ReadOnlyCollection<DiagnosticEvent>.CopyTo
	|-ReadOnlyCollection<DisplayInfo>.CopyTo
	|-ReadOnlyCollection<double>.CopyTo
	|-ReadOnlyCollection<EasingFunction>.CopyTo
	|-ReadOnlyCollection<Edge>.CopyTo
	|-ReadOnlyCollection<EdgeLookup>.CopyTo
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.CopyTo
	|-ReadOnlyCollection<Entitlement>.CopyTo
	|-ReadOnlyCollection<FileStat>.CopyTo
	|-ReadOnlyCollection<GCHandle>.CopyTo
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.CopyTo
	|-ReadOnlyCollection<GlyphRect>.CopyTo
	|-ReadOnlyCollection<Guid>.CopyTo
	|-ReadOnlyCollection<InputActionSourceData>.CopyTo
	|-ReadOnlyCollection<short>.CopyTo
	|-ReadOnlyCollection<int>.CopyTo
	|-ReadOnlyCollection<Int32Enum>.CopyTo
	|-ReadOnlyCollection<long>.CopyTo
	|-ReadOnlyCollection<IntPtr>.CopyTo
	|-ReadOnlyCollection<InterpretedFrameInfo>.CopyTo
	|-ReadOnlyCollection<JsonPosition>.CopyTo
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.CopyTo
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.CopyTo
	|-ReadOnlyCollection<ManipulatorActivationFilter>.CopyTo
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.CopyTo
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.CopyTo
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.CopyTo
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.CopyTo
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.CopyTo
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.CopyTo
	|-ReadOnlyCollection<object>.CopyTo
	|-ReadOnlyCollection<ObjectInitializationData>.CopyTo
	|-ReadOnlyCollection<PidVid>.CopyTo
	|-ReadOnlyCollection<PropertyPath>.CopyTo
	|-ReadOnlyCollection<PropertyPathInfo>.CopyTo
	|-ReadOnlyCollection<PropertyPathPart>.CopyTo
	|-ReadOnlyCollection<Quaternion>.CopyTo
	|-ReadOnlyCollection<RangePositionInfo>.CopyTo
	|-ReadOnlyCollection<RaycastHit2D>.CopyTo
	|-ReadOnlyCollection<RaycastResult>.CopyTo
	|-ReadOnlyCollection<RenderTargetIdentifier>.CopyTo
	|-ReadOnlyCollection<Resolution>.CopyTo
	|-ReadOnlyCollection<RuleMatcher>.CopyTo
	|-ReadOnlyCollection<sbyte>.CopyTo
	|-ReadOnlyCollection<SelectorMatchRecord>.CopyTo
	|-ReadOnlyCollection<SerializedCommand>.CopyTo
	|-ReadOnlyCollection<float>.CopyTo
	|-ReadOnlyCollection<Sku>.CopyTo
	|-ReadOnlyCollection<SplineKnotIndex>.CopyTo
	|-ReadOnlyCollection<StylePropertyName>.CopyTo
	|-ReadOnlyCollection<StylePropertyValue>.CopyTo
	|-ReadOnlyCollection<StyleSelectorPart>.CopyTo
	|-ReadOnlyCollection<StyleSyntaxToken>.CopyTo
	|-ReadOnlyCollection<StyleValue>.CopyTo
	|-ReadOnlyCollection<StyleValueManaged>.CopyTo
	|-ReadOnlyCollection<StyleVariable>.CopyTo
	|-ReadOnlyCollection<TimeSpan>.CopyTo
	|-ReadOnlyCollection<TimeValue>.CopyTo
	|-ReadOnlyCollection<TreeViewItemWrapper>.CopyTo
	|-ReadOnlyCollection<Triangle>.CopyTo
	|-ReadOnlyCollection<TypeWrapper>.CopyTo
	|-ReadOnlyCollection<UICharInfo>.CopyTo
	|-ReadOnlyCollection<UILineInfo>.CopyTo
	|-ReadOnlyCollection<UIVertex>.CopyTo
	|-ReadOnlyCollection<ushort>.CopyTo
	|-ReadOnlyCollection<uint>.CopyTo
	|-ReadOnlyCollection<UInt32Enum>.CopyTo
	|-ReadOnlyCollection<ulong>.CopyTo
	|-ReadOnlyCollection<User>.CopyTo
	|-ReadOnlyCollection<UxmlDescription>.CopyTo
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.CopyTo
	|-ReadOnlyCollection<Vector2>.CopyTo
	|-ReadOnlyCollection<Vector2Int>.CopyTo
	|-ReadOnlyCollection<Vector3>.CopyTo
	|-ReadOnlyCollection<Vector4>.CopyTo
	|-ReadOnlyCollection<X509ChainStatus>.CopyTo
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.CopyTo
	|-ReadOnlyCollection<float3>.CopyTo
	|-ReadOnlyCollection<fsVersionedType>.CopyTo
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.CopyTo
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.CopyTo
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.CopyTo
	|-ReadOnlyCollection<BitmapAllocator32.Page>.CopyTo
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.CopyTo
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.CopyTo
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.CopyTo
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.CopyTo
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.CopyTo
	|-ReadOnlyCollection<DataBindingManager.BindingData>.CopyTo
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.CopyTo
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.CopyTo
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.CopyTo
	|-ReadOnlyCollection<EventProvider.Registration>.CopyTo
	|-ReadOnlyCollection<Expander.ExpansionRule>.CopyTo
	|-ReadOnlyCollection<FocusController.FocusedElement>.CopyTo
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.CopyTo
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.CopyTo
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.CopyTo
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.CopyTo
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.CopyTo
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.CopyTo
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.CopyTo
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.CopyTo
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.CopyTo
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.CopyTo
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.CopyTo
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.CopyTo
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.CopyTo
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.CopyTo
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.CopyTo
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.CopyTo
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.CopyTo
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.CopyTo
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.CopyTo
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.CopyTo
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.CopyTo
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.CopyTo
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.CopyTo
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.CopyTo
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.CopyTo
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.CopyTo
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.CopyTo
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.CopyTo
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.CopyTo
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.CopyTo
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.CopyTo
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.CopyTo
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.CopyTo
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.CopyTo
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.CopyTo
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.CopyTo
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.CopyTo
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.CopyTo
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.CopyTo
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.CopyTo
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FD4C0 Offset: 0x8FBAC0 VA: 0x1808FD4C0
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.GetEnumerator
	|-ReadOnlyCollection<DataPoint<int>>.GetEnumerator
	|-ReadOnlyCollection<DataPoint<object>>.GetEnumerator
	|-ReadOnlyCollection<DataPoint<float>>.GetEnumerator
	|-ReadOnlyCollection<DataPoint<float4>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<int, int>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<int, object>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<long, object>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.GetEnumerator
	|-ReadOnlyCollection<KeyValuePair<object, object>>.GetEnumerator
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.GetEnumerator
	|-ReadOnlyCollection<NativeSlice<ushort>>.GetEnumerator
	|-ReadOnlyCollection<NativeSlice<Vertex>>.GetEnumerator
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.GetEnumerator
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.GetEnumerator
	|-ReadOnlyCollection<SimpleTuple<int, int>>.GetEnumerator
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.GetEnumerator
	|-ReadOnlyCollection<SimpleTuple<object, int>>.GetEnumerator
	|-ReadOnlyCollection<SimpleTuple<object, object>>.GetEnumerator
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.GetEnumerator
	|-ReadOnlyCollection<StructMultiKey<object, object>>.GetEnumerator
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.GetEnumerator
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.GetEnumerator
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.GetEnumerator
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.GetEnumerator
	|-ReadOnlyCollection<ValueTuple<int, int>>.GetEnumerator
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.GetEnumerator
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.GetEnumerator
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.GetEnumerator
	|-ReadOnlyCollection<AsyncOperationHandle>.GetEnumerator
	|-ReadOnlyCollection<BezierKnot>.GetEnumerator
	|-ReadOnlyCollection<BezierPoint>.GetEnumerator
	|-ReadOnlyCollection<bool>.GetEnumerator
	|-ReadOnlyCollection<byte>.GetEnumerator
	|-ReadOnlyCollection<char>.GetEnumerator
	|-ReadOnlyCollection<Color>.GetEnumerator
	|-ReadOnlyCollection<Color32>.GetEnumerator
	|-ReadOnlyCollection<CombineInstance>.GetEnumerator
	|-ReadOnlyCollection<ComputedTransitionProperty>.GetEnumerator
	|-ReadOnlyCollection<ControllerPollingInfo>.GetEnumerator
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.GetEnumerator
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.GetEnumerator
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.GetEnumerator
	|-ReadOnlyCollection<DateTime>.GetEnumerator
	|-ReadOnlyCollection<DateTimeOffset>.GetEnumerator
	|-ReadOnlyCollection<Decimal>.GetEnumerator
	|-ReadOnlyCollection<DiagnosticEvent>.GetEnumerator
	|-ReadOnlyCollection<DisplayInfo>.GetEnumerator
	|-ReadOnlyCollection<double>.GetEnumerator
	|-ReadOnlyCollection<EasingFunction>.GetEnumerator
	|-ReadOnlyCollection<Edge>.GetEnumerator
	|-ReadOnlyCollection<EdgeLookup>.GetEnumerator
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.GetEnumerator
	|-ReadOnlyCollection<Entitlement>.GetEnumerator
	|-ReadOnlyCollection<FileStat>.GetEnumerator
	|-ReadOnlyCollection<GCHandle>.GetEnumerator
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.GetEnumerator
	|-ReadOnlyCollection<GlyphRect>.GetEnumerator
	|-ReadOnlyCollection<Guid>.GetEnumerator
	|-ReadOnlyCollection<InputActionSourceData>.GetEnumerator
	|-ReadOnlyCollection<short>.GetEnumerator
	|-ReadOnlyCollection<int>.GetEnumerator
	|-ReadOnlyCollection<Int32Enum>.GetEnumerator
	|-ReadOnlyCollection<long>.GetEnumerator
	|-ReadOnlyCollection<IntPtr>.GetEnumerator
	|-ReadOnlyCollection<InterpretedFrameInfo>.GetEnumerator
	|-ReadOnlyCollection<JsonPosition>.GetEnumerator
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.GetEnumerator
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.GetEnumerator
	|-ReadOnlyCollection<ManipulatorActivationFilter>.GetEnumerator
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.GetEnumerator
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.GetEnumerator
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.GetEnumerator
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.GetEnumerator
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.GetEnumerator
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.GetEnumerator
	|-ReadOnlyCollection<object>.GetEnumerator
	|-ReadOnlyCollection<ObjectInitializationData>.GetEnumerator
	|-ReadOnlyCollection<PidVid>.GetEnumerator
	|-ReadOnlyCollection<PropertyPath>.GetEnumerator
	|-ReadOnlyCollection<PropertyPathInfo>.GetEnumerator
	|-ReadOnlyCollection<PropertyPathPart>.GetEnumerator
	|-ReadOnlyCollection<Quaternion>.GetEnumerator
	|-ReadOnlyCollection<RangePositionInfo>.GetEnumerator
	|-ReadOnlyCollection<RaycastHit2D>.GetEnumerator
	|-ReadOnlyCollection<RaycastResult>.GetEnumerator
	|-ReadOnlyCollection<RenderTargetIdentifier>.GetEnumerator
	|-ReadOnlyCollection<Resolution>.GetEnumerator
	|-ReadOnlyCollection<RuleMatcher>.GetEnumerator
	|-ReadOnlyCollection<sbyte>.GetEnumerator
	|-ReadOnlyCollection<SelectorMatchRecord>.GetEnumerator
	|-ReadOnlyCollection<SerializedCommand>.GetEnumerator
	|-ReadOnlyCollection<float>.GetEnumerator
	|-ReadOnlyCollection<Sku>.GetEnumerator
	|-ReadOnlyCollection<SplineKnotIndex>.GetEnumerator
	|-ReadOnlyCollection<StylePropertyName>.GetEnumerator
	|-ReadOnlyCollection<StylePropertyValue>.GetEnumerator
	|-ReadOnlyCollection<StyleSelectorPart>.GetEnumerator
	|-ReadOnlyCollection<StyleSyntaxToken>.GetEnumerator
	|-ReadOnlyCollection<StyleValue>.GetEnumerator
	|-ReadOnlyCollection<StyleValueManaged>.GetEnumerator
	|-ReadOnlyCollection<StyleVariable>.GetEnumerator
	|-ReadOnlyCollection<TimeSpan>.GetEnumerator
	|-ReadOnlyCollection<TimeValue>.GetEnumerator
	|-ReadOnlyCollection<TreeViewItemWrapper>.GetEnumerator
	|-ReadOnlyCollection<Triangle>.GetEnumerator
	|-ReadOnlyCollection<TypeWrapper>.GetEnumerator
	|-ReadOnlyCollection<UICharInfo>.GetEnumerator
	|-ReadOnlyCollection<UILineInfo>.GetEnumerator
	|-ReadOnlyCollection<UIVertex>.GetEnumerator
	|-ReadOnlyCollection<ushort>.GetEnumerator
	|-ReadOnlyCollection<uint>.GetEnumerator
	|-ReadOnlyCollection<UInt32Enum>.GetEnumerator
	|-ReadOnlyCollection<ulong>.GetEnumerator
	|-ReadOnlyCollection<User>.GetEnumerator
	|-ReadOnlyCollection<UxmlDescription>.GetEnumerator
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.GetEnumerator
	|-ReadOnlyCollection<Vector2>.GetEnumerator
	|-ReadOnlyCollection<Vector2Int>.GetEnumerator
	|-ReadOnlyCollection<Vector3>.GetEnumerator
	|-ReadOnlyCollection<Vector4>.GetEnumerator
	|-ReadOnlyCollection<X509ChainStatus>.GetEnumerator
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.GetEnumerator
	|-ReadOnlyCollection<float3>.GetEnumerator
	|-ReadOnlyCollection<fsVersionedType>.GetEnumerator
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.GetEnumerator
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.GetEnumerator
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.GetEnumerator
	|-ReadOnlyCollection<BitmapAllocator32.Page>.GetEnumerator
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.GetEnumerator
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.GetEnumerator
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.GetEnumerator
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.GetEnumerator
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.GetEnumerator
	|-ReadOnlyCollection<DataBindingManager.BindingData>.GetEnumerator
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.GetEnumerator
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.GetEnumerator
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.GetEnumerator
	|-ReadOnlyCollection<EventProvider.Registration>.GetEnumerator
	|-ReadOnlyCollection<Expander.ExpansionRule>.GetEnumerator
	|-ReadOnlyCollection<FocusController.FocusedElement>.GetEnumerator
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.GetEnumerator
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.GetEnumerator
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.GetEnumerator
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.GetEnumerator
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.GetEnumerator
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.GetEnumerator
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.GetEnumerator
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.GetEnumerator
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.GetEnumerator
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.GetEnumerator
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.GetEnumerator
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.GetEnumerator
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.GetEnumerator
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.GetEnumerator
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.GetEnumerator
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.GetEnumerator
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.GetEnumerator
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.GetEnumerator
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.GetEnumerator
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.GetEnumerator
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.GetEnumerator
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.GetEnumerator
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.GetEnumerator
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.GetEnumerator
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.GetEnumerator
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.GetEnumerator
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.GetEnumerator
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.GetEnumerator
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.GetEnumerator
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.GetEnumerator
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.GetEnumerator
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.GetEnumerator
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.GetEnumerator
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.GetEnumerator
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.GetEnumerator
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FD510 Offset: 0x8FBB10 VA: 0x1808FD510
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.IndexOf
	|-ReadOnlyCollection<PropertyPathPart>.IndexOf
	|-ReadOnlyCollection<TypeWrapper>.IndexOf
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.IndexOf
	|-ReadOnlyCollection<EventProvider.Registration>.IndexOf
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.IndexOf
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.IndexOf
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.IndexOf
	|
	|-RVA: 0x8FD5F0 Offset: 0x8FBBF0 VA: 0x1808FD5F0
	|-ReadOnlyCollection<DataPoint<int>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<int, int>>.IndexOf
	|-ReadOnlyCollection<SimpleTuple<int, int>>.IndexOf
	|-ReadOnlyCollection<ValueTuple<int, int>>.IndexOf
	|-ReadOnlyCollection<DateTime>.IndexOf
	|-ReadOnlyCollection<Edge>.IndexOf
	|-ReadOnlyCollection<GCHandle>.IndexOf
	|-ReadOnlyCollection<SplineKnotIndex>.IndexOf
	|-ReadOnlyCollection<TimeSpan>.IndexOf
	|-ReadOnlyCollection<TimeValue>.IndexOf
	|-ReadOnlyCollection<Vector2Int>.IndexOf
	|-ReadOnlyCollection<BitmapAllocator32.Page>.IndexOf
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.IndexOf
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.IndexOf
	|
	|-RVA: 0x8FD6C0 Offset: 0x8FBCC0 VA: 0x1808FD6C0
	|-ReadOnlyCollection<DataPoint<object>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<int, object>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<long, object>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.IndexOf
	|-ReadOnlyCollection<KeyValuePair<object, object>>.IndexOf
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.IndexOf
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.IndexOf
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.IndexOf
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.IndexOf
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.IndexOf
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.IndexOf
	|-ReadOnlyCollection<NativeSlice<ushort>>.IndexOf
	|-ReadOnlyCollection<NativeSlice<Vertex>>.IndexOf
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.IndexOf
	|-ReadOnlyCollection<SimpleTuple<object, int>>.IndexOf
	|-ReadOnlyCollection<SimpleTuple<object, object>>.IndexOf
	|-ReadOnlyCollection<StructMultiKey<object, object>>.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.IndexOf
	|-ReadOnlyCollection<Color>.IndexOf
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.IndexOf
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IndexOf
	|-ReadOnlyCollection<DateTimeOffset>.IndexOf
	|-ReadOnlyCollection<Decimal>.IndexOf
	|-ReadOnlyCollection<EdgeLookup>.IndexOf
	|-ReadOnlyCollection<GlyphRect>.IndexOf
	|-ReadOnlyCollection<Guid>.IndexOf
	|-ReadOnlyCollection<InterpretedFrameInfo>.IndexOf
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.IndexOf
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.IndexOf
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.IndexOf
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.IndexOf
	|-ReadOnlyCollection<Quaternion>.IndexOf
	|-ReadOnlyCollection<RangePositionInfo>.IndexOf
	|-ReadOnlyCollection<Resolution>.IndexOf
	|-ReadOnlyCollection<RuleMatcher>.IndexOf
	|-ReadOnlyCollection<StylePropertyName>.IndexOf
	|-ReadOnlyCollection<StylePropertyValue>.IndexOf
	|-ReadOnlyCollection<StyleValueManaged>.IndexOf
	|-ReadOnlyCollection<UILineInfo>.IndexOf
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.IndexOf
	|-ReadOnlyCollection<Vector4>.IndexOf
	|-ReadOnlyCollection<X509ChainStatus>.IndexOf
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.IndexOf
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.IndexOf
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.IndexOf
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.IndexOf
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.IndexOf
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.IndexOf
	|-ReadOnlyCollection<FocusController.FocusedElement>.IndexOf
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.IndexOf
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.IndexOf
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.IndexOf
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.IndexOf
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.IndexOf
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.IndexOf
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.IndexOf
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.IndexOf
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.IndexOf
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.IndexOf
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.IndexOf
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.IndexOf
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.IndexOf
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.IndexOf
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IndexOf
	|
	|-RVA: 0x8FD870 Offset: 0x8FBE70 VA: 0x1808FD870
	|-ReadOnlyCollection<DataPoint<float>>.IndexOf
	|-ReadOnlyCollection<Vector2>.IndexOf
	|
	|-RVA: 0x8FD790 Offset: 0x8FBD90 VA: 0x1808FD790
	|-ReadOnlyCollection<DataPoint<float4>>.IndexOf
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.IndexOf
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.IndexOf
	|
	|-RVA: 0x8FD940 Offset: 0x8FBF40 VA: 0x1808FD940
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.IndexOf
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.IndexOf
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.IndexOf
	|-ReadOnlyCollection<AsyncOperationHandle>.IndexOf
	|-ReadOnlyCollection<ComputedTransitionProperty>.IndexOf
	|-ReadOnlyCollection<Entitlement>.IndexOf
	|-ReadOnlyCollection<FileStat>.IndexOf
	|-ReadOnlyCollection<InputActionSourceData>.IndexOf
	|-ReadOnlyCollection<JsonPosition>.IndexOf
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.IndexOf
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.IndexOf
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.IndexOf
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.IndexOf
	|-ReadOnlyCollection<SelectorMatchRecord>.IndexOf
	|-ReadOnlyCollection<StyleSelectorPart>.IndexOf
	|-ReadOnlyCollection<StyleSyntaxToken>.IndexOf
	|-ReadOnlyCollection<StyleValue>.IndexOf
	|-ReadOnlyCollection<StyleVariable>.IndexOf
	|-ReadOnlyCollection<TreeViewItemWrapper>.IndexOf
	|-ReadOnlyCollection<fsVersionedType>.IndexOf
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.IndexOf
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.IndexOf
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.IndexOf
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.IndexOf
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.IndexOf
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.IndexOf
	|
	|-RVA: 0x90A3C0 Offset: 0x9089C0 VA: 0x18090A3C0
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.IndexOf
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.IndexOf
	|-ReadOnlyCollection<ManipulatorActivationFilter>.IndexOf
	|-ReadOnlyCollection<Triangle>.IndexOf
	|-ReadOnlyCollection<UICharInfo>.IndexOf
	|-ReadOnlyCollection<Vector3>.IndexOf
	|-ReadOnlyCollection<float3>.IndexOf
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.IndexOf
	|-ReadOnlyCollection<Expander.ExpansionRule>.IndexOf
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.IndexOf
	|
	|-RVA: 0x90A6B0 Offset: 0x908CB0 VA: 0x18090A6B0
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.IndexOf
	|-ReadOnlyCollection<RenderTargetIdentifier>.IndexOf
	|-ReadOnlyCollection<Sku>.IndexOf
	|-ReadOnlyCollection<User>.IndexOf
	|-ReadOnlyCollection<UxmlDescription>.IndexOf
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.IndexOf
	|
	|-RVA: 0x90A130 Offset: 0x908730 VA: 0x18090A130
	|-ReadOnlyCollection<BezierKnot>.IndexOf
	|-ReadOnlyCollection<BezierPoint>.IndexOf
	|
	|-RVA: 0x909E90 Offset: 0x908490 VA: 0x180909E90
	|-ReadOnlyCollection<bool>.IndexOf
	|-ReadOnlyCollection<byte>.IndexOf
	|-ReadOnlyCollection<sbyte>.IndexOf
	|
	|-RVA: 0x90A2F0 Offset: 0x9088F0 VA: 0x18090A2F0
	|-ReadOnlyCollection<char>.IndexOf
	|-ReadOnlyCollection<short>.IndexOf
	|-ReadOnlyCollection<ushort>.IndexOf
	|
	|-RVA: 0x909DC0 Offset: 0x9083C0 VA: 0x180909DC0
	|-ReadOnlyCollection<Color32>.IndexOf
	|-ReadOnlyCollection<EasingFunction>.IndexOf
	|-ReadOnlyCollection<PidVid>.IndexOf
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.IndexOf
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.IndexOf
	|
	|-RVA: 0x90A590 Offset: 0x908B90 VA: 0x18090A590
	|-ReadOnlyCollection<CombineInstance>.IndexOf
	|
	|-RVA: 0x90A040 Offset: 0x908640 VA: 0x18090A040
	|-ReadOnlyCollection<ControllerPollingInfo>.IndexOf
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.IndexOf
	|
	|-RVA: 0x909F60 Offset: 0x908560 VA: 0x180909F60
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IndexOf
	|-ReadOnlyCollection<DiagnosticEvent>.IndexOf
	|-ReadOnlyCollection<DisplayInfo>.IndexOf
	|-ReadOnlyCollection<ObjectInitializationData>.IndexOf
	|
	|-RVA: 0x90A220 Offset: 0x908820 VA: 0x18090A220
	|-ReadOnlyCollection<double>.IndexOf
	|-ReadOnlyCollection<float>.IndexOf
	|
	|-RVA: 0x90A4A0 Offset: 0x908AA0 VA: 0x18090A4A0
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.IndexOf
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.IndexOf
	|
	|-RVA: 0x91CC60 Offset: 0x91B260 VA: 0x18091CC60
	|-ReadOnlyCollection<int>.IndexOf
	|-ReadOnlyCollection<Int32Enum>.IndexOf
	|-ReadOnlyCollection<uint>.IndexOf
	|-ReadOnlyCollection<UInt32Enum>.IndexOf
	|
	|-RVA: 0x91C900 Offset: 0x91AF00 VA: 0x18091C900
	|-ReadOnlyCollection<long>.IndexOf
	|-ReadOnlyCollection<IntPtr>.IndexOf
	|
	|-RVA: 0x91CB90 Offset: 0x91B190 VA: 0x18091CB90
	|-ReadOnlyCollection<object>.IndexOf
	|-ReadOnlyCollection<ulong>.IndexOf
	|
	|-RVA: 0x91C960 Offset: 0x91AF60 VA: 0x18091C960
	|-ReadOnlyCollection<PropertyPath>.IndexOf
	|
	|-RVA: 0x91C7C0 Offset: 0x91ADC0 VA: 0x18091C7C0
	|-ReadOnlyCollection<PropertyPathInfo>.IndexOf
	|
	|-RVA: 0x91CCC0 Offset: 0x91B2C0 VA: 0x18091CCC0
	|-ReadOnlyCollection<RaycastHit2D>.IndexOf
	|
	|-RVA: 0x91CA90 Offset: 0x91B090 VA: 0x18091CA90
	|-ReadOnlyCollection<RaycastResult>.IndexOf
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.IndexOf
	|
	|-RVA: 0x91CDA0 Offset: 0x91B3A0 VA: 0x18091CDA0
	|-ReadOnlyCollection<SerializedCommand>.IndexOf
	|
	|-RVA: 0x92E3F0 Offset: 0x92C9F0 VA: 0x18092E3F0
	|-ReadOnlyCollection<UIVertex>.IndexOf
	|
	|-RVA: 0x92E610 Offset: 0x92CC10 VA: 0x18092E610
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x92E780 Offset: 0x92CD80 VA: 0x18092E780
	|-ReadOnlyCollection<DataBindingManager.BindingData>.IndexOf
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.IndexOf
	|
	|-RVA: 0x92E520 Offset: 0x92CB20 VA: 0x18092E520
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.IndexOf
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.IndexOf
	|
	|-RVA: 0x93FA60 Offset: 0x93E060 VA: 0x18093FA60
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.IndexOf
	|
	|-RVA: 0x93F900 Offset: 0x93DF00 VA: 0x18093F900
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<BezierKnot>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<BezierPoint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Entitlement>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<FileStat>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<GCHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PropertyPath>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Sku>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Triangle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<User>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<float3>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDCC0 Offset: 0x8FC2C0 VA: 0x1808FDCC0
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x8FDC60 Offset: 0x8FC260 VA: 0x1808FDC60
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<GCHandle>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x8FDAB0 Offset: 0x8FC0B0 VA: 0x1808FDAB0
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x8FDC00 Offset: 0x8FC200 VA: 0x1808FDC00
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x8FDD40 Offset: 0x8FC340 VA: 0x1808FDD40
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x8FDB80 Offset: 0x8FC180 VA: 0x1808FDB80
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Entitlement>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<FileStat>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x90A830 Offset: 0x908E30 VA: 0x18090A830
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Triangle>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<float3>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x90AB10 Offset: 0x909110 VA: 0x18090AB10
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<Sku>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<User>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x90A940 Offset: 0x908F40 VA: 0x18090A940
	|-ReadOnlyCollection<BezierKnot>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<BezierPoint>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x90AA60 Offset: 0x909060 VA: 0x18090AA60
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x90A9D0 Offset: 0x908FD0 VA: 0x18090A9D0
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x90A7A0 Offset: 0x908DA0 VA: 0x18090A7A0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x90ABA0 Offset: 0x9091A0 VA: 0x18090ABA0
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x90A8B0 Offset: 0x908EB0 VA: 0x18090A8B0
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x91D090 Offset: 0x91B690 VA: 0x18091D090
	|-ReadOnlyCollection<PropertyPath>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x91CFB0 Offset: 0x91B5B0 VA: 0x18091CFB0
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x91D210 Offset: 0x91B810 VA: 0x18091D210
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x91CF10 Offset: 0x91B510 VA: 0x18091CF10
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x91D160 Offset: 0x91B760 VA: 0x18091D160
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x92EB00 Offset: 0x92D100 VA: 0x18092EB00
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x92EC50 Offset: 0x92D250 VA: 0x18092EC50
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x92EA20 Offset: 0x92D020 VA: 0x18092EA20
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x92EBC0 Offset: 0x92D1C0 VA: 0x18092EBC0
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.Generic.IList<T>.get_Item
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x93FC60 Offset: 0x93E260 VA: 0x18093FC60
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x93FB60 Offset: 0x93E160 VA: 0x18093FB60
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<BezierKnot>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<BezierPoint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Entitlement>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<FileStat>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<GCHandle>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PropertyPath>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Sku>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Triangle>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<User>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<float3>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.Generic.IList<T>.set_Item
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<BezierKnot>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<BezierPoint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Entitlement>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<FileStat>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<GCHandle>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PropertyPath>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Sku>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Triangle>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<User>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<float3>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.Generic.ICollection<T>.Add
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<BezierKnot>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<BezierPoint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Entitlement>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<FileStat>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<GCHandle>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PropertyPath>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Sku>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Triangle>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<User>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<float3>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.Generic.ICollection<T>.Clear
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<BezierKnot>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<BezierPoint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Entitlement>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<FileStat>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<GCHandle>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PropertyPath>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Sku>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Triangle>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<User>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<float3>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.Generic.IList<T>.Insert
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA90 Offset: 0x8FC090 VA: 0x1808FDA90
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<BezierKnot>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<BezierPoint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<byte>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<char>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Color>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<double>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Entitlement>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<FileStat>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<GCHandle>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<short>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<int>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<long>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PropertyPath>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<float>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Sku>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Triangle>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<uint>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<User>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<float3>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.Generic.ICollection<T>.Remove
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<BezierKnot>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<BezierPoint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<char>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Color>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Color32>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CombineInstance>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DateTime>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Decimal>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<double>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<EasingFunction>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Edge>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Entitlement>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<FileStat>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<GCHandle>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<GlyphRect>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Guid>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<short>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<int>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Int32Enum>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<long>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<IntPtr>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<JsonPosition>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PidVid>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PropertyPath>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Quaternion>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RaycastResult>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Resolution>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<sbyte>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<float>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Sku>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StyleValue>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<StyleVariable>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TimeSpan>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TimeValue>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Triangle>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UICharInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UILineInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UIVertex>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ushort>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<uint>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ulong>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<User>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Vector2>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Vector2Int>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Vector3>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Vector4>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<float3>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.Generic.IList<T>.RemoveAt
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9051F0 Offset: 0x9037F0 VA: 0x1809051F0
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904E30 Offset: 0x903430 VA: 0x180904E30
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x905240 Offset: 0x903840 VA: 0x180905240
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904F70 Offset: 0x903570 VA: 0x180904F70
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x905150 Offset: 0x903750 VA: 0x180905150
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904CA0 Offset: 0x9032A0 VA: 0x180904CA0
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904CF0 Offset: 0x9032F0 VA: 0x180904CF0
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904ED0 Offset: 0x9034D0 VA: 0x180904ED0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x905100 Offset: 0x903700 VA: 0x180905100
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x905060 Offset: 0x903660 VA: 0x180905060
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9051A0 Offset: 0x9037A0 VA: 0x1809051A0
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904D90 Offset: 0x903390 VA: 0x180904D90
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904E80 Offset: 0x903480 VA: 0x180904E80
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904DE0 Offset: 0x9033E0 VA: 0x180904DE0
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904C50 Offset: 0x903250 VA: 0x180904C50
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904FC0 Offset: 0x9035C0 VA: 0x180904FC0
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9050B0 Offset: 0x9036B0 VA: 0x1809050B0
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904F20 Offset: 0x903520 VA: 0x180904F20
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904BB0 Offset: 0x9031B0 VA: 0x180904BB0
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x905010 Offset: 0x903610 VA: 0x180905010
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904D40 Offset: 0x903340 VA: 0x180904D40
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x904C00 Offset: 0x903200 VA: 0x180904C00
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918D20 Offset: 0x917320 VA: 0x180918D20
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918F00 Offset: 0x917500 VA: 0x180918F00
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918E60 Offset: 0x917460 VA: 0x180918E60
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918D70 Offset: 0x917370 VA: 0x180918D70
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9186E0 Offset: 0x916CE0 VA: 0x1809186E0
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918550 Offset: 0x916B50 VA: 0x180918550
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918910 Offset: 0x916F10 VA: 0x180918910
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918500 Offset: 0x916B00 VA: 0x180918500
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9190E0 Offset: 0x9176E0 VA: 0x1809190E0
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9185F0 Offset: 0x916BF0 VA: 0x1809185F0
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x919180 Offset: 0x917780 VA: 0x180919180
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918820 Offset: 0x916E20 VA: 0x180918820
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9187D0 Offset: 0x916DD0 VA: 0x1809187D0
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918E10 Offset: 0x917410 VA: 0x180918E10
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9188C0 Offset: 0x916EC0 VA: 0x1809188C0
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918A50 Offset: 0x917050 VA: 0x180918A50
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918460 Offset: 0x916A60 VA: 0x180918460
	|-ReadOnlyCollection<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918B90 Offset: 0x917190 VA: 0x180918B90
	|-ReadOnlyCollection<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918CD0 Offset: 0x9172D0 VA: 0x180918CD0
	|-ReadOnlyCollection<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9185A0 Offset: 0x916BA0 VA: 0x1809185A0
	|-ReadOnlyCollection<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918730 Offset: 0x916D30 VA: 0x180918730
	|-ReadOnlyCollection<Color32>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918960 Offset: 0x916F60 VA: 0x180918960
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918870 Offset: 0x916E70 VA: 0x180918870
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918F50 Offset: 0x917550 VA: 0x180918F50
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918AF0 Offset: 0x9170F0 VA: 0x180918AF0
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918FF0 Offset: 0x9175F0 VA: 0x180918FF0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x919130 Offset: 0x917730 VA: 0x180919130
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918DC0 Offset: 0x9173C0 VA: 0x180918DC0
	|-ReadOnlyCollection<DateTime>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918C30 Offset: 0x917230 VA: 0x180918C30
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9184B0 Offset: 0x916AB0 VA: 0x1809184B0
	|-ReadOnlyCollection<Decimal>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x919090 Offset: 0x917690 VA: 0x180919090
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918EB0 Offset: 0x9174B0 VA: 0x180918EB0
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918690 Offset: 0x916C90 VA: 0x180918690
	|-ReadOnlyCollection<double>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918BE0 Offset: 0x9171E0 VA: 0x180918BE0
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918AA0 Offset: 0x9170A0 VA: 0x180918AA0
	|-ReadOnlyCollection<Edge>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918A00 Offset: 0x917000 VA: 0x180918A00
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x919040 Offset: 0x917640 VA: 0x180919040
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918FA0 Offset: 0x9175A0 VA: 0x180918FA0
	|-ReadOnlyCollection<Entitlement>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918C80 Offset: 0x917280 VA: 0x180918C80
	|-ReadOnlyCollection<FileStat>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x9189B0 Offset: 0x916FB0 VA: 0x1809189B0
	|-ReadOnlyCollection<GCHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918B40 Offset: 0x917140 VA: 0x180918B40
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918640 Offset: 0x916C40 VA: 0x180918640
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x918780 Offset: 0x916D80 VA: 0x180918780
	|-ReadOnlyCollection<Guid>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B100 Offset: 0x929700 VA: 0x18092B100
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AF70 Offset: 0x929570 VA: 0x18092AF70
	|-ReadOnlyCollection<short>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AE30 Offset: 0x929430 VA: 0x18092AE30
	|-ReadOnlyCollection<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AE80 Offset: 0x929480 VA: 0x18092AE80
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B0B0 Offset: 0x9296B0 VA: 0x18092B0B0
	|-ReadOnlyCollection<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AB60 Offset: 0x929160 VA: 0x18092AB60
	|-ReadOnlyCollection<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B470 Offset: 0x929A70 VA: 0x18092B470
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AC50 Offset: 0x929250 VA: 0x18092AC50
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B3D0 Offset: 0x9299D0 VA: 0x18092B3D0
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B2E0 Offset: 0x9298E0 VA: 0x18092B2E0
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B380 Offset: 0x929980 VA: 0x18092B380
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B650 Offset: 0x929C50 VA: 0x18092B650
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B880 Offset: 0x929E80 VA: 0x18092B880
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92ACF0 Offset: 0x9292F0 VA: 0x18092ACF0
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AC00 Offset: 0x929200 VA: 0x18092AC00
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B420 Offset: 0x929A20 VA: 0x18092B420
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B790 Offset: 0x929D90 VA: 0x18092B790
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B740 Offset: 0x929D40 VA: 0x18092B740
	|-ReadOnlyCollection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B010 Offset: 0x929610 VA: 0x18092B010
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B600 Offset: 0x929C00 VA: 0x18092B600
	|-ReadOnlyCollection<PidVid>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B1A0 Offset: 0x9297A0 VA: 0x18092B1A0
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AD40 Offset: 0x929340 VA: 0x18092AD40
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B4C0 Offset: 0x929AC0 VA: 0x18092B4C0
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B6F0 Offset: 0x929CF0 VA: 0x18092B6F0
	|-ReadOnlyCollection<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B7E0 Offset: 0x929DE0 VA: 0x18092B7E0
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B060 Offset: 0x929660 VA: 0x18092B060
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B1F0 Offset: 0x9297F0 VA: 0x18092B1F0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92ADE0 Offset: 0x9293E0 VA: 0x18092ADE0
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B830 Offset: 0x929E30 VA: 0x18092B830
	|-ReadOnlyCollection<Resolution>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B560 Offset: 0x929B60 VA: 0x18092B560
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AF20 Offset: 0x929520 VA: 0x18092AF20
	|-ReadOnlyCollection<sbyte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92ABB0 Offset: 0x9291B0 VA: 0x18092ABB0
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B240 Offset: 0x929840 VA: 0x18092B240
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B290 Offset: 0x929890 VA: 0x18092B290
	|-ReadOnlyCollection<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AED0 Offset: 0x9294D0 VA: 0x18092AED0
	|-ReadOnlyCollection<Sku>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92ACA0 Offset: 0x9292A0 VA: 0x18092ACA0
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B6A0 Offset: 0x929CA0 VA: 0x18092B6A0
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B5B0 Offset: 0x929BB0 VA: 0x18092B5B0
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B330 Offset: 0x929930 VA: 0x18092B330
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B150 Offset: 0x929750 VA: 0x18092B150
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AFC0 Offset: 0x9295C0 VA: 0x18092AFC0
	|-ReadOnlyCollection<StyleValue>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92B510 Offset: 0x929B10 VA: 0x18092B510
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x92AD90 Offset: 0x929390 VA: 0x18092AD90
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CEF0 Offset: 0x93B4F0 VA: 0x18093CEF0
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CE50 Offset: 0x93B450 VA: 0x18093CE50
	|-ReadOnlyCollection<TimeValue>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CFE0 Offset: 0x93B5E0 VA: 0x18093CFE0
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CA90 Offset: 0x93B090 VA: 0x18093CA90
	|-ReadOnlyCollection<Triangle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C9F0 Offset: 0x93AFF0 VA: 0x18093C9F0
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C950 Offset: 0x93AF50 VA: 0x18093C950
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CD10 Offset: 0x93B310 VA: 0x18093CD10
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CE00 Offset: 0x93B400 VA: 0x18093CE00
	|-ReadOnlyCollection<UIVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CD60 Offset: 0x93B360 VA: 0x18093CD60
	|-ReadOnlyCollection<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C5E0 Offset: 0x93ABE0 VA: 0x18093C5E0
	|-ReadOnlyCollection<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C8B0 Offset: 0x93AEB0 VA: 0x18093C8B0
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93D120 Offset: 0x93B720 VA: 0x18093D120
	|-ReadOnlyCollection<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CAE0 Offset: 0x93B0E0 VA: 0x18093CAE0
	|-ReadOnlyCollection<User>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93D1C0 Offset: 0x93B7C0 VA: 0x18093D1C0
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C770 Offset: 0x93AD70 VA: 0x18093C770
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93D300 Offset: 0x93B900 VA: 0x18093D300
	|-ReadOnlyCollection<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CCC0 Offset: 0x93B2C0 VA: 0x18093CCC0
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C720 Offset: 0x93AD20 VA: 0x18093C720
	|-ReadOnlyCollection<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93D030 Offset: 0x93B630 VA: 0x18093D030
	|-ReadOnlyCollection<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C9A0 Offset: 0x93AFA0 VA: 0x18093C9A0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93D0D0 Offset: 0x93B6D0 VA: 0x18093D0D0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CDB0 Offset: 0x93B3B0 VA: 0x18093CDB0
	|-ReadOnlyCollection<float3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C810 Offset: 0x93AE10 VA: 0x18093C810
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CEA0 Offset: 0x93B4A0 VA: 0x18093CEA0
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C630 Offset: 0x93AC30 VA: 0x18093C630
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C860 Offset: 0x93AE60 VA: 0x18093C860
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C680 Offset: 0x93AC80 VA: 0x18093C680
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CBD0 Offset: 0x93B1D0 VA: 0x18093CBD0
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CF90 Offset: 0x93B590 VA: 0x18093CF90
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93D260 Offset: 0x93B860 VA: 0x18093D260
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C7C0 Offset: 0x93ADC0 VA: 0x18093C7C0
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CB80 Offset: 0x93B180 VA: 0x18093CB80
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CC20 Offset: 0x93B220 VA: 0x18093CC20
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C900 Offset: 0x93AF00 VA: 0x18093C900
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93D080 Offset: 0x93B680 VA: 0x18093D080
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CC70 Offset: 0x93B270 VA: 0x18093CC70
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93D2B0 Offset: 0x93B8B0 VA: 0x18093D2B0
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CF40 Offset: 0x93B540 VA: 0x18093CF40
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93D170 Offset: 0x93B770 VA: 0x18093D170
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93D210 Offset: 0x93B810 VA: 0x18093D210
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93C6D0 Offset: 0x93ACD0 VA: 0x18093C6D0
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CB30 Offset: 0x93B130 VA: 0x18093CB30
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x93CA40 Offset: 0x93B040 VA: 0x18093CA40
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BA10 Offset: 0x94A010 VA: 0x18094BA10
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BC40 Offset: 0x94A240 VA: 0x18094BC40
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BB00 Offset: 0x94A100 VA: 0x18094BB00
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BA60 Offset: 0x94A060 VA: 0x18094BA60
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C140 Offset: 0x94A740 VA: 0x18094C140
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C280 Offset: 0x94A880 VA: 0x18094C280
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BFB0 Offset: 0x94A5B0 VA: 0x18094BFB0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C0F0 Offset: 0x94A6F0 VA: 0x18094C0F0
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BE70 Offset: 0x94A470 VA: 0x18094BE70
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94B7E0 Offset: 0x949DE0 VA: 0x18094B7E0
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BE20 Offset: 0x94A420 VA: 0x18094BE20
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BD80 Offset: 0x94A380 VA: 0x18094BD80
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C000 Offset: 0x94A600 VA: 0x18094C000
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C2D0 Offset: 0x94A8D0 VA: 0x18094C2D0
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C230 Offset: 0x94A830 VA: 0x18094C230
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94B880 Offset: 0x949E80 VA: 0x18094B880
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BEC0 Offset: 0x94A4C0 VA: 0x18094BEC0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BBA0 Offset: 0x94A1A0 VA: 0x18094BBA0
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94B9C0 Offset: 0x949FC0 VA: 0x18094B9C0
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BF10 Offset: 0x94A510 VA: 0x18094BF10
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BC90 Offset: 0x94A290 VA: 0x18094BC90
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C0A0 Offset: 0x94A6A0 VA: 0x18094C0A0
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BB50 Offset: 0x94A150 VA: 0x18094BB50
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94B830 Offset: 0x949E30 VA: 0x18094B830
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94B920 Offset: 0x949F20 VA: 0x18094B920
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BBF0 Offset: 0x94A1F0 VA: 0x18094BBF0
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BF60 Offset: 0x94A560 VA: 0x18094BF60
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C050 Offset: 0x94A650 VA: 0x18094C050
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C190 Offset: 0x94A790 VA: 0x18094C190
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BCE0 Offset: 0x94A2E0 VA: 0x18094BCE0
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BAB0 Offset: 0x94A0B0 VA: 0x18094BAB0
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C1E0 Offset: 0x94A7E0 VA: 0x18094C1E0
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94B8D0 Offset: 0x949ED0 VA: 0x18094B8D0
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BD30 Offset: 0x94A330 VA: 0x18094BD30
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94C320 Offset: 0x94A920 VA: 0x18094C320
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94B970 Offset: 0x949F70 VA: 0x18094B970
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x94BDD0 Offset: 0x94A3D0 VA: 0x18094BDD0
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<BezierKnot>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<BezierPoint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<char>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CombineInstance>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<double>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<EasingFunction>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Edge>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Entitlement>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<FileStat>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<GCHandle>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<GlyphRect>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Guid>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<short>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<int>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<long>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<IntPtr>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<JsonPosition>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PidVid>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PropertyPath>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Quaternion>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RaycastResult>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Resolution>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<float>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Sku>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StyleValue>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<StyleVariable>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TimeValue>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Triangle>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UICharInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UILineInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UIVertex>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<User>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Vector2Int>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<float3>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9042F0 Offset: 0x9028F0 VA: 0x1809042F0
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x904050 Offset: 0x902650 VA: 0x180904050
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9043D0 Offset: 0x9029D0 VA: 0x1809043D0
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x904750 Offset: 0x902D50 VA: 0x180904750
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x904830 Offset: 0x902E30 VA: 0x180904830
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x903F70 Offset: 0x902570 VA: 0x180903F70
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x904670 Offset: 0x902C70 VA: 0x180904670
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x904910 Offset: 0x902F10 VA: 0x180904910
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x903E90 Offset: 0x902490 VA: 0x180903E90
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x903BF0 Offset: 0x9021F0 VA: 0x180903BF0
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x904210 Offset: 0x902810 VA: 0x180904210
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x903870 Offset: 0x901E70 VA: 0x180903870
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x903CD0 Offset: 0x9022D0 VA: 0x180903CD0
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x903950 Offset: 0x901F50 VA: 0x180903950
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x904AD0 Offset: 0x9030D0 VA: 0x180904AD0
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x903A30 Offset: 0x902030 VA: 0x180903A30
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x904130 Offset: 0x902730 VA: 0x180904130
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x903B10 Offset: 0x902110 VA: 0x180903B10
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x903DB0 Offset: 0x9023B0 VA: 0x180903DB0
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x904590 Offset: 0x902B90 VA: 0x180904590
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9049F0 Offset: 0x902FF0 VA: 0x1809049F0
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9044B0 Offset: 0x902AB0 VA: 0x1809044B0
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916320 Offset: 0x914920 VA: 0x180916320
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x915EC0 Offset: 0x9144C0 VA: 0x180915EC0
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9164E0 Offset: 0x914AE0 VA: 0x1809164E0
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917E40 Offset: 0x916440 VA: 0x180917E40
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917D60 Offset: 0x916360 VA: 0x180917D60
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916DA0 Offset: 0x9153A0 VA: 0x180916DA0
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916780 Offset: 0x914D80 VA: 0x180916780
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916860 Offset: 0x914E60 VA: 0x180916860
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x918000 Offset: 0x916600 VA: 0x180918000
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916BE0 Offset: 0x9151E0 VA: 0x180916BE0
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917BA0 Offset: 0x9161A0 VA: 0x180917BA0
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9179E0 Offset: 0x915FE0 VA: 0x1809179E0
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916A20 Offset: 0x915020 VA: 0x180916A20
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916940 Offset: 0x914F40 VA: 0x180916940
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916080 Offset: 0x914680 VA: 0x180916080
	|-ReadOnlyCollection<BezierKnot>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916400 Offset: 0x914A00 VA: 0x180916400
	|-ReadOnlyCollection<BezierPoint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9181C0 Offset: 0x9167C0 VA: 0x1809181C0
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917200 Offset: 0x915800 VA: 0x180917200
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9182A0 Offset: 0x9168A0 VA: 0x1809182A0
	|-ReadOnlyCollection<char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916CC0 Offset: 0x9152C0 VA: 0x180916CC0
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9166A0 Offset: 0x914CA0 VA: 0x1809166A0
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916B00 Offset: 0x915100 VA: 0x180916B00
	|-ReadOnlyCollection<CombineInstance>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917C80 Offset: 0x916280 VA: 0x180917C80
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x918380 Offset: 0x916980 VA: 0x180918380
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917120 Offset: 0x915720 VA: 0x180917120
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917580 Offset: 0x915B80 VA: 0x180917580
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916F60 Offset: 0x915560 VA: 0x180916F60
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9165C0 Offset: 0x914BC0 VA: 0x1809165C0
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9174A0 Offset: 0x915AA0 VA: 0x1809174A0
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917660 Offset: 0x915C60 VA: 0x180917660
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9173C0 Offset: 0x9159C0 VA: 0x1809173C0
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917F20 Offset: 0x916520 VA: 0x180917F20
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917740 Offset: 0x915D40 VA: 0x180917740
	|-ReadOnlyCollection<double>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917AC0 Offset: 0x9160C0 VA: 0x180917AC0
	|-ReadOnlyCollection<EasingFunction>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917040 Offset: 0x915640 VA: 0x180917040
	|-ReadOnlyCollection<Edge>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916E80 Offset: 0x915480 VA: 0x180916E80
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916160 Offset: 0x914760 VA: 0x180916160
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917900 Offset: 0x915F00 VA: 0x180917900
	|-ReadOnlyCollection<Entitlement>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9180E0 Offset: 0x9166E0 VA: 0x1809180E0
	|-ReadOnlyCollection<FileStat>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9172E0 Offset: 0x9158E0 VA: 0x1809172E0
	|-ReadOnlyCollection<GCHandle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x916240 Offset: 0x914840 VA: 0x180916240
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x917820 Offset: 0x915E20 VA: 0x180917820
	|-ReadOnlyCollection<GlyphRect>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x915FA0 Offset: 0x9145A0 VA: 0x180915FA0
	|-ReadOnlyCollection<Guid>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x928F60 Offset: 0x927560 VA: 0x180928F60
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929740 Offset: 0x927D40 VA: 0x180929740
	|-ReadOnlyCollection<short>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A0E0 Offset: 0x9286E0 VA: 0x18092A0E0
	|-ReadOnlyCollection<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929200 Offset: 0x927800 VA: 0x180929200
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9299E0 Offset: 0x927FE0 VA: 0x1809299E0
	|-ReadOnlyCollection<long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929580 Offset: 0x927B80 VA: 0x180929580
	|-ReadOnlyCollection<IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A380 Offset: 0x928980 VA: 0x18092A380
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A1C0 Offset: 0x9287C0 VA: 0x18092A1C0
	|-ReadOnlyCollection<JsonPosition>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A2A0 Offset: 0x9288A0 VA: 0x18092A2A0
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A7E0 Offset: 0x928DE0 VA: 0x18092A7E0
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9294A0 Offset: 0x927AA0 VA: 0x1809294A0
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929BA0 Offset: 0x9281A0 VA: 0x180929BA0
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x928A20 Offset: 0x927020 VA: 0x180928A20
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A620 Offset: 0x928C20 VA: 0x18092A620
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929C80 Offset: 0x928280 VA: 0x180929C80
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92AA80 Offset: 0x929080 VA: 0x18092AA80
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x928E80 Offset: 0x927480 VA: 0x180928E80
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929900 Offset: 0x927F00 VA: 0x180929900
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929120 Offset: 0x927720 VA: 0x180929120
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929820 Offset: 0x927E20 VA: 0x180929820
	|-ReadOnlyCollection<PidVid>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9285C0 Offset: 0x926BC0 VA: 0x1809285C0
	|-ReadOnlyCollection<PropertyPath>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9293C0 Offset: 0x9279C0 VA: 0x1809293C0
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9286A0 Offset: 0x926CA0 VA: 0x1809286A0
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x928BE0 Offset: 0x9271E0 VA: 0x180928BE0
	|-ReadOnlyCollection<Quaternion>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A700 Offset: 0x928D00 VA: 0x18092A700
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A460 Offset: 0x928A60 VA: 0x18092A460
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A8C0 Offset: 0x928EC0 VA: 0x18092A8C0
	|-ReadOnlyCollection<RaycastResult>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929D60 Offset: 0x928360 VA: 0x180929D60
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x928B00 Offset: 0x927100 VA: 0x180928B00
	|-ReadOnlyCollection<Resolution>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929660 Offset: 0x927C60 VA: 0x180929660
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929040 Offset: 0x927640 VA: 0x180929040
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x928DA0 Offset: 0x9273A0 VA: 0x180928DA0
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x928CC0 Offset: 0x9272C0 VA: 0x180928CC0
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A540 Offset: 0x928B40 VA: 0x18092A540
	|-ReadOnlyCollection<float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x9292E0 Offset: 0x9278E0 VA: 0x1809292E0
	|-ReadOnlyCollection<Sku>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929AC0 Offset: 0x9280C0 VA: 0x180929AC0
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x928940 Offset: 0x926F40 VA: 0x180928940
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A000 Offset: 0x928600 VA: 0x18092A000
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929E40 Offset: 0x928440 VA: 0x180929E40
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x929F20 Offset: 0x928520 VA: 0x180929F20
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x928860 Offset: 0x926E60 VA: 0x180928860
	|-ReadOnlyCollection<StyleValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x92A9A0 Offset: 0x928FA0 VA: 0x18092A9A0
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x928780 Offset: 0x926D80 VA: 0x180928780
	|-ReadOnlyCollection<StyleVariable>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93AC80 Offset: 0x939280 VA: 0x18093AC80
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93AAC0 Offset: 0x9390C0 VA: 0x18093AAC0
	|-ReadOnlyCollection<TimeValue>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B2A0 Offset: 0x9398A0 VA: 0x18093B2A0
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B7E0 Offset: 0x939DE0 VA: 0x18093B7E0
	|-ReadOnlyCollection<Triangle>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B8C0 Offset: 0x939EC0 VA: 0x18093B8C0
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93BE00 Offset: 0x93A400 VA: 0x18093BE00
	|-ReadOnlyCollection<UICharInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93BFC0 Offset: 0x93A5C0 VA: 0x18093BFC0
	|-ReadOnlyCollection<UILineInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93C340 Offset: 0x93A940 VA: 0x18093C340
	|-ReadOnlyCollection<UIVertex>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A660 Offset: 0x938C60 VA: 0x18093A660
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93C260 Offset: 0x93A860 VA: 0x18093C260
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93BC40 Offset: 0x93A240 VA: 0x18093BC40
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A900 Offset: 0x938F00 VA: 0x18093A900
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93C180 Offset: 0x93A780 VA: 0x18093C180
	|-ReadOnlyCollection<User>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B380 Offset: 0x939980 VA: 0x18093B380
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A200 Offset: 0x938800 VA: 0x18093A200
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93BEE0 Offset: 0x93A4E0 VA: 0x18093BEE0
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A9E0 Offset: 0x938FE0 VA: 0x18093A9E0
	|-ReadOnlyCollection<Vector2Int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A120 Offset: 0x938720 VA: 0x18093A120
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A040 Offset: 0x938640 VA: 0x18093A040
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A2E0 Offset: 0x9388E0 VA: 0x18093A2E0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93C0A0 Offset: 0x93A6A0 VA: 0x18093C0A0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93ABA0 Offset: 0x9391A0 VA: 0x18093ABA0
	|-ReadOnlyCollection<float3>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93BD20 Offset: 0x93A320 VA: 0x18093BD20
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93AE40 Offset: 0x939440 VA: 0x18093AE40
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B620 Offset: 0x939C20 VA: 0x18093B620
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93C420 Offset: 0x93AA20 VA: 0x18093C420
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A820 Offset: 0x938E20 VA: 0x18093A820
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93AF20 Offset: 0x939520 VA: 0x18093AF20
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A3C0 Offset: 0x9389C0 VA: 0x18093A3C0
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A4A0 Offset: 0x938AA0 VA: 0x18093A4A0
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B0E0 Offset: 0x9396E0 VA: 0x18093B0E0
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B700 Offset: 0x939D00 VA: 0x18093B700
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B1C0 Offset: 0x9397C0 VA: 0x18093B1C0
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93AD60 Offset: 0x939360 VA: 0x18093AD60
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A740 Offset: 0x938D40 VA: 0x18093A740
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93A580 Offset: 0x938B80 VA: 0x18093A580
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B540 Offset: 0x939B40 VA: 0x18093B540
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B000 Offset: 0x939600 VA: 0x18093B000
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B460 Offset: 0x939A60 VA: 0x18093B460
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93B9A0 Offset: 0x939FA0 VA: 0x18093B9A0
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93C500 Offset: 0x93AB00 VA: 0x18093C500
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93BA80 Offset: 0x93A080 VA: 0x18093BA80
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x93BB60 Offset: 0x93A160 VA: 0x18093BB60
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x949DA0 Offset: 0x9483A0 VA: 0x180949DA0
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A9E0 Offset: 0x948FE0 VA: 0x18094A9E0
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94B2A0 Offset: 0x9498A0 VA: 0x18094B2A0
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94AAC0 Offset: 0x9490C0 VA: 0x18094AAC0
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94B000 Offset: 0x949600 VA: 0x18094B000
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A660 Offset: 0x948C60 VA: 0x18094A660
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A4A0 Offset: 0x948AA0 VA: 0x18094A4A0
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x949B00 Offset: 0x948100 VA: 0x180949B00
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94B380 Offset: 0x949980 VA: 0x18094B380
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A740 Offset: 0x948D40 VA: 0x18094A740
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94AD60 Offset: 0x949360 VA: 0x18094AD60
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94AF20 Offset: 0x949520 VA: 0x18094AF20
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x949F60 Offset: 0x948560 VA: 0x180949F60
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A200 Offset: 0x948800 VA: 0x18094A200
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A120 Offset: 0x948720 VA: 0x18094A120
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94B460 Offset: 0x949A60 VA: 0x18094B460
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94B0E0 Offset: 0x9496E0 VA: 0x18094B0E0
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x949BE0 Offset: 0x9481E0 VA: 0x180949BE0
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A2E0 Offset: 0x9488E0 VA: 0x18094A2E0
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94AC80 Offset: 0x949280 VA: 0x18094AC80
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x949CC0 Offset: 0x9482C0 VA: 0x180949CC0
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94B540 Offset: 0x949B40 VA: 0x18094B540
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x949E80 Offset: 0x948480 VA: 0x180949E80
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x949A20 Offset: 0x948020 VA: 0x180949A20
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A040 Offset: 0x948640 VA: 0x18094A040
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A3C0 Offset: 0x9489C0 VA: 0x18094A3C0
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94B1C0 Offset: 0x9497C0 VA: 0x18094B1C0
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x949860 Offset: 0x947E60 VA: 0x180949860
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94B620 Offset: 0x949C20 VA: 0x18094B620
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x949940 Offset: 0x947F40 VA: 0x180949940
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A820 Offset: 0x948E20 VA: 0x18094A820
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x949780 Offset: 0x947D80 VA: 0x180949780
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A900 Offset: 0x948F00 VA: 0x18094A900
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94ABA0 Offset: 0x9491A0 VA: 0x18094ABA0
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94B700 Offset: 0x949D00 VA: 0x18094B700
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94A580 Offset: 0x948B80 VA: 0x18094A580
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x94AE40 Offset: 0x949440 VA: 0x18094AE40
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FF670 Offset: 0x8FDC70 VA: 0x1808FF670
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x8FFEC0 Offset: 0x8FE4C0 VA: 0x1808FFEC0
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9006F0 Offset: 0x8FECF0 VA: 0x1809006F0
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x8FF260 Offset: 0x8FD860 VA: 0x1808FF260
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x901350 Offset: 0x8FF950 VA: 0x180901350
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9027E0 Offset: 0x900DE0 VA: 0x1809027E0
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x8FEE50 Offset: 0x8FD450 VA: 0x1808FEE50
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9002D0 Offset: 0x8FE8D0 VA: 0x1809002D0
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x900F30 Offset: 0x8FF530 VA: 0x180900F30
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x8FE600 Offset: 0x8FCC00 VA: 0x1808FE600
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x901B90 Offset: 0x900190 VA: 0x180901B90
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x901FB0 Offset: 0x9005B0 VA: 0x180901FB0
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x902C00 Offset: 0x901200 VA: 0x180902C00
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x8FFAA0 Offset: 0x8FE0A0 VA: 0x1808FFAA0
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x8FE1E0 Offset: 0x8FC7E0 VA: 0x1808FE1E0
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x8FDDC0 Offset: 0x8FC3C0 VA: 0x1808FDDC0
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x900B10 Offset: 0x8FF110 VA: 0x180900B10
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x903450 Offset: 0x901A50 VA: 0x180903450
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x901770 Offset: 0x8FFD70 VA: 0x180901770
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x903020 Offset: 0x901620 VA: 0x180903020
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x8FEA20 Offset: 0x8FD020 VA: 0x1808FEA20
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9023D0 Offset: 0x9009D0 VA: 0x1809023D0
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90FF10 Offset: 0x90E510 VA: 0x18090FF10
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x912060 Offset: 0x910660 VA: 0x180912060
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90B460 Offset: 0x909A60 VA: 0x18090B460
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x911810 Offset: 0x90FE10 VA: 0x180911810
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90B040 Offset: 0x909640 VA: 0x18090B040
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x915650 Offset: 0x913C50 VA: 0x180915650
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90D130 Offset: 0x90B730 VA: 0x18090D130
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9145A0 Offset: 0x912BA0 VA: 0x1809145A0
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90CD10 Offset: 0x90B310 VA: 0x18090CD10
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90D550 Offset: 0x90BB50 VA: 0x18090D550
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90B880 Offset: 0x909E80 VA: 0x18090B880
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90F6A0 Offset: 0x90DCA0 VA: 0x18090F6A0
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x910330 Offset: 0x90E930 VA: 0x180910330
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x910B80 Offset: 0x90F180 VA: 0x180910B80
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x915A80 Offset: 0x914080 VA: 0x180915A80
	|-ReadOnlyCollection<BezierKnot>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x913530 Offset: 0x911B30 VA: 0x180913530
	|-ReadOnlyCollection<BezierPoint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90BCB0 Offset: 0x90A2B0 VA: 0x18090BCB0
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90C4E0 Offset: 0x90AAE0 VA: 0x18090C4E0
	|-ReadOnlyCollection<byte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90DDD0 Offset: 0x90C3D0 VA: 0x18090DDD0
	|-ReadOnlyCollection<char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x914DF0 Offset: 0x9133F0 VA: 0x180914DF0
	|-ReadOnlyCollection<Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x913D80 Offset: 0x912380 VA: 0x180913D80
	|-ReadOnlyCollection<Color32>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90D960 Offset: 0x90BF60 VA: 0x18090D960
	|-ReadOnlyCollection<CombineInstance>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x910FB0 Offset: 0x90F5B0 VA: 0x180910FB0
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9130F0 Offset: 0x9116F0 VA: 0x1809130F0
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9149D0 Offset: 0x912FD0 VA: 0x1809149D0
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90EE20 Offset: 0x90D420 VA: 0x18090EE20
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9128A0 Offset: 0x910EA0 VA: 0x1809128A0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x913970 Offset: 0x911F70 VA: 0x180913970
	|-ReadOnlyCollection<DateTime>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x911C40 Offset: 0x910240 VA: 0x180911C40
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90C8F0 Offset: 0x90AEF0 VA: 0x18090C8F0
	|-ReadOnlyCollection<Decimal>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x915210 Offset: 0x913810 VA: 0x180915210
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90FAD0 Offset: 0x90E0D0 VA: 0x18090FAD0
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90EA10 Offset: 0x90D010 VA: 0x18090EA10
	|-ReadOnlyCollection<double>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x910770 Offset: 0x90ED70 VA: 0x180910770
	|-ReadOnlyCollection<EasingFunction>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90E1E0 Offset: 0x90C7E0 VA: 0x18090E1E0
	|-ReadOnlyCollection<Edge>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90E5F0 Offset: 0x90CBF0 VA: 0x18090E5F0
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90F260 Offset: 0x90D860 VA: 0x18090F260
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x912CC0 Offset: 0x9112C0 VA: 0x180912CC0
	|-ReadOnlyCollection<Entitlement>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9113E0 Offset: 0x90F9E0 VA: 0x1809113E0
	|-ReadOnlyCollection<FileStat>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x914190 Offset: 0x912790 VA: 0x180914190
	|-ReadOnlyCollection<GCHandle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90AC00 Offset: 0x909200 VA: 0x18090AC00
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x90C0C0 Offset: 0x90A6C0 VA: 0x18090C0C0
	|-ReadOnlyCollection<GlyphRect>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x912480 Offset: 0x910A80 VA: 0x180912480
	|-ReadOnlyCollection<Guid>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x926460 Offset: 0x924A60 VA: 0x180926460
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9281B0 Offset: 0x9267B0 VA: 0x1809281B0
	|-ReadOnlyCollection<short>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x921DF0 Offset: 0x9203F0 VA: 0x180921DF0
	|-ReadOnlyCollection<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91FC00 Offset: 0x91E200 VA: 0x18091FC00
	|-ReadOnlyCollection<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x922E70 Offset: 0x921470 VA: 0x180922E70
	|-ReadOnlyCollection<long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x924740 Offset: 0x922D40 VA: 0x180924740
	|-ReadOnlyCollection<IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x925C20 Offset: 0x924220 VA: 0x180925C20
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x921580 Offset: 0x91FB80 VA: 0x180921580
	|-ReadOnlyCollection<JsonPosition>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x921160 Offset: 0x91F760 VA: 0x180921160
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x927130 Offset: 0x925730 VA: 0x180927130
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x922200 Offset: 0x920800 VA: 0x180922200
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91D290 Offset: 0x91B890 VA: 0x18091D290
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x924310 Offset: 0x922910 VA: 0x180924310
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x923EE0 Offset: 0x9224E0 VA: 0x180923EE0
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x924B50 Offset: 0x923150 VA: 0x180924B50
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x923AC0 Offset: 0x9220C0 VA: 0x180923AC0
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9253D0 Offset: 0x9239D0 VA: 0x1809253D0
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91E350 Offset: 0x91C950 VA: 0x18091E350
	|-ReadOnlyCollection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91EB50 Offset: 0x91D150 VA: 0x18091EB50
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x927550 Offset: 0x925B50 VA: 0x180927550
	|-ReadOnlyCollection<PidVid>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x926CB0 Offset: 0x9252B0 VA: 0x180926CB0
	|-ReadOnlyCollection<PropertyPath>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x920890 Offset: 0x91EE90 VA: 0x180920890
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x922A40 Offset: 0x921040 VA: 0x180922A40
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x926040 Offset: 0x924640 VA: 0x180926040
	|-ReadOnlyCollection<Quaternion>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x926890 Offset: 0x924E90 VA: 0x180926890
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x927D80 Offset: 0x926380 VA: 0x180927D80
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x924F80 Offset: 0x923580 VA: 0x180924F80
	|-ReadOnlyCollection<RaycastResult>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9219B0 Offset: 0x91FFB0 VA: 0x1809219B0
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91F7E0 Offset: 0x91DDE0 VA: 0x18091F7E0
	|-ReadOnlyCollection<Resolution>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x923280 Offset: 0x921880 VA: 0x180923280
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x922630 Offset: 0x920C30 VA: 0x180922630
	|-ReadOnlyCollection<sbyte>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91DAF0 Offset: 0x91C0F0 VA: 0x18091DAF0
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x920010 Offset: 0x91E610 VA: 0x180920010
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x920470 Offset: 0x91EA70 VA: 0x180920470
	|-ReadOnlyCollection<float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x920D20 Offset: 0x91F320 VA: 0x180920D20
	|-ReadOnlyCollection<Sku>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91E740 Offset: 0x91CD40 VA: 0x18091E740
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x927960 Offset: 0x925F60 VA: 0x180927960
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91EF90 Offset: 0x91D590 VA: 0x18091EF90
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9257F0 Offset: 0x923DF0 VA: 0x1809257F0
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91D6C0 Offset: 0x91BCC0 VA: 0x18091D6C0
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91F3B0 Offset: 0x91D9B0 VA: 0x18091F3B0
	|-ReadOnlyCollection<StyleValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9236A0 Offset: 0x921CA0 VA: 0x1809236A0
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x91DF20 Offset: 0x91C520 VA: 0x18091DF20
	|-ReadOnlyCollection<StyleVariable>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x939C30 Offset: 0x938230 VA: 0x180939C30
	|-ReadOnlyCollection<TimeSpan>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x932710 Offset: 0x930D10 VA: 0x180932710
	|-ReadOnlyCollection<TimeValue>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x936E90 Offset: 0x935490 VA: 0x180936E90
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x935120 Offset: 0x933720 VA: 0x180935120
	|-ReadOnlyCollection<Triangle>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x938350 Offset: 0x936950 VA: 0x180938350
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x935D90 Offset: 0x934390 VA: 0x180935D90
	|-ReadOnlyCollection<UICharInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x936A70 Offset: 0x935070 VA: 0x180936A70
	|-ReadOnlyCollection<UILineInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9337B0 Offset: 0x931DB0 VA: 0x1809337B0
	|-ReadOnlyCollection<UIVertex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9344F0 Offset: 0x932AF0 VA: 0x1809344F0
	|-ReadOnlyCollection<ushort>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x934900 Offset: 0x932F00 VA: 0x180934900
	|-ReadOnlyCollection<uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9301C0 Offset: 0x92E7C0 VA: 0x1809301C0
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x931230 Offset: 0x92F830 VA: 0x180931230
	|-ReadOnlyCollection<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x931640 Offset: 0x92FC40 VA: 0x180931640
	|-ReadOnlyCollection<User>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9340B0 Offset: 0x9326B0 VA: 0x1809340B0
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x92ED20 Offset: 0x92D320 VA: 0x18092ED20
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9305D0 Offset: 0x92EBD0 VA: 0x1809305D0
	|-ReadOnlyCollection<Vector2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x92F140 Offset: 0x92D740 VA: 0x18092F140
	|-ReadOnlyCollection<Vector2Int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9372C0 Offset: 0x9358C0 VA: 0x1809372C0
	|-ReadOnlyCollection<Vector3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x935970 Offset: 0x933F70 VA: 0x180935970
	|-ReadOnlyCollection<Vector4>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x92FDA0 Offset: 0x92E3A0 VA: 0x18092FDA0
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x933360 Offset: 0x931960 VA: 0x180933360
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x930E00 Offset: 0x92F400 VA: 0x180930E00
	|-ReadOnlyCollection<float3>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9376F0 Offset: 0x935CF0 VA: 0x1809376F0
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x932B20 Offset: 0x931120 VA: 0x180932B20
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9361C0 Offset: 0x9347C0 VA: 0x1809361C0
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x937F30 Offset: 0x936530 VA: 0x180937F30
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x939820 Offset: 0x937E20 VA: 0x180939820
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x934D10 Offset: 0x933310 VA: 0x180934D10
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x938BA0 Offset: 0x9371A0 VA: 0x180938BA0
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9309E0 Offset: 0x92EFE0 VA: 0x1809309E0
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9322E0 Offset: 0x9308E0 VA: 0x1809322E0
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x932F40 Offset: 0x931540 VA: 0x180932F40
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x933C20 Offset: 0x932220 VA: 0x180933C20
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9365E0 Offset: 0x934BE0 VA: 0x1809365E0
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x931A80 Offset: 0x930080 VA: 0x180931A80
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x937B20 Offset: 0x936120 VA: 0x180937B20
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x931EB0 Offset: 0x9304B0 VA: 0x180931EB0
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x92F550 Offset: 0x92DB50 VA: 0x18092F550
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x935550 Offset: 0x933B50 VA: 0x180935550
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x938FC0 Offset: 0x9375C0 VA: 0x180938FC0
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x939400 Offset: 0x937A00 VA: 0x180939400
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x938780 Offset: 0x936D80 VA: 0x180938780
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x92F980 Offset: 0x92DF80 VA: 0x18092F980
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x946580 Offset: 0x944B80 VA: 0x180946580
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9454C0 Offset: 0x943AC0 VA: 0x1809454C0
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9411E0 Offset: 0x93F7E0 VA: 0x1809411E0
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x948F30 Offset: 0x947530 VA: 0x180948F30
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x942ED0 Offset: 0x9414D0 VA: 0x180942ED0
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x942260 Offset: 0x940860 VA: 0x180942260
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x943370 Offset: 0x941970 VA: 0x180943370
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x945910 Offset: 0x943F10 VA: 0x180945910
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x942AB0 Offset: 0x9410B0 VA: 0x180942AB0
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x946DE0 Offset: 0x9453E0 VA: 0x180946DE0
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x941E40 Offset: 0x940440 VA: 0x180941E40
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x947E50 Offset: 0x946450 VA: 0x180947E50
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x941A10 Offset: 0x940010 VA: 0x180941A10
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9450A0 Offset: 0x9436A0 VA: 0x1809450A0
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x947610 Offset: 0x945C10 VA: 0x180947610
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9469A0 Offset: 0x944FA0 VA: 0x1809469A0
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x944C60 Offset: 0x943260 VA: 0x180944C60
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x940130 Offset: 0x93E730 VA: 0x180940130
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x940980 Offset: 0x93EF80 VA: 0x180940980
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x948280 Offset: 0x946880 VA: 0x180948280
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x944410 Offset: 0x942A10 VA: 0x180944410
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x940550 Offset: 0x93EB50 VA: 0x180940550
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x948B00 Offset: 0x947100 VA: 0x180948B00
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x947A30 Offset: 0x946030 VA: 0x180947A30
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x940DC0 Offset: 0x93F3C0 VA: 0x180940DC0
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x943790 Offset: 0x941D90 VA: 0x180943790
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x946160 Offset: 0x944760 VA: 0x180946160
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9471F0 Offset: 0x9457F0 VA: 0x1809471F0
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x944840 Offset: 0x942E40 VA: 0x180944840
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x9486D0 Offset: 0x946CD0 VA: 0x1809486D0
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x941600 Offset: 0x93FC00 VA: 0x180941600
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x945D30 Offset: 0x944330 VA: 0x180945D30
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x942680 Offset: 0x940C80 VA: 0x180942680
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x943FE0 Offset: 0x9425E0 VA: 0x180943FE0
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x93FD00 Offset: 0x93E300 VA: 0x18093FD00
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x943BC0 Offset: 0x9421C0 VA: 0x180943BC0
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x949360 Offset: 0x947960 VA: 0x180949360
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<char>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<double>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Edge>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Guid>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<short>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<int>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<long>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<float>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Sku>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<User>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<float3>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<char>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<double>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Edge>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Guid>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<short>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<int>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<long>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<float>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Sku>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<User>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<float3>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x906920 Offset: 0x904F20 VA: 0x180906920
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.get_Item
	|
	|-RVA: 0x9068A0 Offset: 0x904EA0 VA: 0x1809068A0
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Edge>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<long>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ulong>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.get_Item
	|
	|-RVA: 0x9067B0 Offset: 0x904DB0 VA: 0x1809067B0
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Color>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Guid>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x906A60 Offset: 0x905060 VA: 0x180906A60
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.get_Item
	|
	|-RVA: 0x906720 Offset: 0x904D20 VA: 0x180906720
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.get_Item
	|
	|-RVA: 0x9069C0 Offset: 0x904FC0 VA: 0x1809069C0
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91BAF0 Offset: 0x91A0F0 VA: 0x18091BAF0
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<float3>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91BDF0 Offset: 0x91A3F0 VA: 0x18091BDF0
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Sku>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<User>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91BC40 Offset: 0x91A240 VA: 0x18091BC40
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91BCF0 Offset: 0x91A2F0 VA: 0x18091BCF0
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<byte>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91BD70 Offset: 0x91A370 VA: 0x18091BD70
	|-ReadOnlyCollection<char>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<short>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ushort>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91B9C0 Offset: 0x919FC0 VA: 0x18091B9C0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<int>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<uint>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91BEA0 Offset: 0x91A4A0 VA: 0x18091BEA0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91BF80 Offset: 0x91A580 VA: 0x18091BF80
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91BA40 Offset: 0x91A040 VA: 0x18091BA40
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91C040 Offset: 0x91A640 VA: 0x18091C040
	|-ReadOnlyCollection<double>.System.Collections.IList.get_Item
	|
	|-RVA: 0x91BB90 Offset: 0x91A190 VA: 0x18091BB90
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.get_Item
	|
	|-RVA: 0x8FDC60 Offset: 0x8FC260 VA: 0x1808FDC60
	|-ReadOnlyCollection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x92DA50 Offset: 0x92C050 VA: 0x18092DA50
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.get_Item
	|
	|-RVA: 0x92DE10 Offset: 0x92C410 VA: 0x18092DE10
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.get_Item
	|
	|-RVA: 0x92DC00 Offset: 0x92C200 VA: 0x18092DC00
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.get_Item
	|
	|-RVA: 0x92DB40 Offset: 0x92C140 VA: 0x18092DB40
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.get_Item
	|
	|-RVA: 0x92DD40 Offset: 0x92C340 VA: 0x18092DD40
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.get_Item
	|
	|-RVA: 0x92DCB0 Offset: 0x92C2B0 VA: 0x18092DCB0
	|-ReadOnlyCollection<float>.System.Collections.IList.get_Item
	|
	|-RVA: 0x93E690 Offset: 0x93CC90 VA: 0x18093E690
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.get_Item
	|
	|-RVA: 0x93E820 Offset: 0x93CE20 VA: 0x18093E820
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	|
	|-RVA: 0x93E8F0 Offset: 0x93CEF0 VA: 0x18093E8F0
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.get_Item
	|
	|-RVA: 0x93E770 Offset: 0x93CD70 VA: 0x18093E770
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.get_Item
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.get_Item
	|
	|-RVA: 0x94CE00 Offset: 0x94B400 VA: 0x18094CE00
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.get_Item
	|
	|-RVA: 0x94CCF0 Offset: 0x94B2F0 VA: 0x18094CCF0
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<bool>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<byte>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<char>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Color>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Color32>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<double>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Edge>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Guid>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<short>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<int>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<long>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<object>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<float>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Sku>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ushort>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<uint>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ulong>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<User>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<float3>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.set_Item
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x905290 Offset: 0x903890 VA: 0x180905290
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.Add
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.Add
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.Add
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.Add
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.Add
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.Add
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.Add
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.Add
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.Add
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.Add
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.Add
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Add
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.Add
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.Add
	|-ReadOnlyCollection<bool>.System.Collections.IList.Add
	|-ReadOnlyCollection<byte>.System.Collections.IList.Add
	|-ReadOnlyCollection<char>.System.Collections.IList.Add
	|-ReadOnlyCollection<Color>.System.Collections.IList.Add
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Add
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Add
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.Add
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.Add
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Add
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Add
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Add
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Add
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Add
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Add
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<double>.System.Collections.IList.Add
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.Add
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Add
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.Add
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.Add
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.Add
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.Add
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Add
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Add
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.Add
	|-ReadOnlyCollection<short>.System.Collections.IList.Add
	|-ReadOnlyCollection<int>.System.Collections.IList.Add
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Add
	|-ReadOnlyCollection<long>.System.Collections.IList.Add
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.Add
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Add
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.Add
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<object>.System.Collections.IList.Add
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Add
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.Add
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.Add
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.Add
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Add
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Add
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Add
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.Add
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.Add
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.Add
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Add
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.Add
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.Add
	|-ReadOnlyCollection<float>.System.Collections.IList.Add
	|-ReadOnlyCollection<Sku>.System.Collections.IList.Add
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.Add
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.Add
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.Add
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.Add
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.Add
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.Add
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.Add
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.Add
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Add
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.Add
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.Add
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.Add
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.Add
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Add
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Add
	|-ReadOnlyCollection<uint>.System.Collections.IList.Add
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.Add
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Add
	|-ReadOnlyCollection<User>.System.Collections.IList.Add
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.Add
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.Add
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Add
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.Add
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Add
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Add
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Add
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	|-ReadOnlyCollection<float3>.System.Collections.IList.Add
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.Add
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.Add
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.Add
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Add
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.Add
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.Add
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.Add
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.Add
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.Add
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.Add
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.Add
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.Add
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.Add
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.Add
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.Add
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Add
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.Add
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.Add
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.Add
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.Add
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.Add
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.Add
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.Add
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.Add
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.Add
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.Add
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Add
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.Add
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.Add
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Add
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.Add
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.Add
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.Add
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.Add
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.Add
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Add
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.Add
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.Add
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Add
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Add
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.Add
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.Add
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Add
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.Add
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.Add
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.Add
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.Add
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.Clear
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Clear
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.Clear
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<bool>.System.Collections.IList.Clear
	|-ReadOnlyCollection<byte>.System.Collections.IList.Clear
	|-ReadOnlyCollection<char>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Color>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<double>.System.Collections.IList.Clear
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Clear
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.Clear
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.Clear
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.Clear
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<short>.System.Collections.IList.Clear
	|-ReadOnlyCollection<int>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Clear
	|-ReadOnlyCollection<long>.System.Collections.IList.Clear
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Clear
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<object>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.Clear
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.Clear
	|-ReadOnlyCollection<float>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Sku>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.Clear
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Clear
	|-ReadOnlyCollection<uint>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Clear
	|-ReadOnlyCollection<User>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Clear
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Clear
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	|-ReadOnlyCollection<float3>.System.Collections.IList.Clear
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.Clear
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.Clear
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Clear
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.Clear
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.Clear
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.Clear
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.Clear
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Clear
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.Clear
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.Clear
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Clear
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Clear
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.Clear
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Clear
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.Clear
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.Clear
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Clear
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.Clear
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.Clear
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.Clear
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA20 Offset: 0x8FC020 VA: 0x1808FDA20
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.IsCompatibleObject
	|-ReadOnlyCollection<DataPoint<int>>.IsCompatibleObject
	|-ReadOnlyCollection<DataPoint<object>>.IsCompatibleObject
	|-ReadOnlyCollection<DataPoint<float>>.IsCompatibleObject
	|-ReadOnlyCollection<DataPoint<float4>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<int, int>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<int, object>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<long, object>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.IsCompatibleObject
	|-ReadOnlyCollection<KeyValuePair<object, object>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeSlice<ushort>>.IsCompatibleObject
	|-ReadOnlyCollection<NativeSlice<Vertex>>.IsCompatibleObject
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.IsCompatibleObject
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.IsCompatibleObject
	|-ReadOnlyCollection<SimpleTuple<int, int>>.IsCompatibleObject
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.IsCompatibleObject
	|-ReadOnlyCollection<SimpleTuple<object, int>>.IsCompatibleObject
	|-ReadOnlyCollection<SimpleTuple<object, object>>.IsCompatibleObject
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.IsCompatibleObject
	|-ReadOnlyCollection<StructMultiKey<object, object>>.IsCompatibleObject
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.IsCompatibleObject
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.IsCompatibleObject
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.IsCompatibleObject
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.IsCompatibleObject
	|-ReadOnlyCollection<ValueTuple<int, int>>.IsCompatibleObject
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.IsCompatibleObject
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.IsCompatibleObject
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.IsCompatibleObject
	|-ReadOnlyCollection<AsyncOperationHandle>.IsCompatibleObject
	|-ReadOnlyCollection<BezierKnot>.IsCompatibleObject
	|-ReadOnlyCollection<BezierPoint>.IsCompatibleObject
	|-ReadOnlyCollection<bool>.IsCompatibleObject
	|-ReadOnlyCollection<byte>.IsCompatibleObject
	|-ReadOnlyCollection<char>.IsCompatibleObject
	|-ReadOnlyCollection<Color>.IsCompatibleObject
	|-ReadOnlyCollection<Color32>.IsCompatibleObject
	|-ReadOnlyCollection<CombineInstance>.IsCompatibleObject
	|-ReadOnlyCollection<ComputedTransitionProperty>.IsCompatibleObject
	|-ReadOnlyCollection<ControllerPollingInfo>.IsCompatibleObject
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.IsCompatibleObject
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IsCompatibleObject
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IsCompatibleObject
	|-ReadOnlyCollection<DateTime>.IsCompatibleObject
	|-ReadOnlyCollection<DateTimeOffset>.IsCompatibleObject
	|-ReadOnlyCollection<Decimal>.IsCompatibleObject
	|-ReadOnlyCollection<DiagnosticEvent>.IsCompatibleObject
	|-ReadOnlyCollection<DisplayInfo>.IsCompatibleObject
	|-ReadOnlyCollection<double>.IsCompatibleObject
	|-ReadOnlyCollection<EasingFunction>.IsCompatibleObject
	|-ReadOnlyCollection<Edge>.IsCompatibleObject
	|-ReadOnlyCollection<EdgeLookup>.IsCompatibleObject
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.IsCompatibleObject
	|-ReadOnlyCollection<Entitlement>.IsCompatibleObject
	|-ReadOnlyCollection<FileStat>.IsCompatibleObject
	|-ReadOnlyCollection<GCHandle>.IsCompatibleObject
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.IsCompatibleObject
	|-ReadOnlyCollection<GlyphRect>.IsCompatibleObject
	|-ReadOnlyCollection<Guid>.IsCompatibleObject
	|-ReadOnlyCollection<InputActionSourceData>.IsCompatibleObject
	|-ReadOnlyCollection<short>.IsCompatibleObject
	|-ReadOnlyCollection<int>.IsCompatibleObject
	|-ReadOnlyCollection<Int32Enum>.IsCompatibleObject
	|-ReadOnlyCollection<long>.IsCompatibleObject
	|-ReadOnlyCollection<IntPtr>.IsCompatibleObject
	|-ReadOnlyCollection<InterpretedFrameInfo>.IsCompatibleObject
	|-ReadOnlyCollection<JsonPosition>.IsCompatibleObject
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.IsCompatibleObject
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.IsCompatibleObject
	|-ReadOnlyCollection<ManipulatorActivationFilter>.IsCompatibleObject
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.IsCompatibleObject
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.IsCompatibleObject
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.IsCompatibleObject
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.IsCompatibleObject
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.IsCompatibleObject
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.IsCompatibleObject
	|-ReadOnlyCollection<ObjectInitializationData>.IsCompatibleObject
	|-ReadOnlyCollection<PidVid>.IsCompatibleObject
	|-ReadOnlyCollection<PropertyPath>.IsCompatibleObject
	|-ReadOnlyCollection<PropertyPathInfo>.IsCompatibleObject
	|-ReadOnlyCollection<PropertyPathPart>.IsCompatibleObject
	|-ReadOnlyCollection<Quaternion>.IsCompatibleObject
	|-ReadOnlyCollection<RangePositionInfo>.IsCompatibleObject
	|-ReadOnlyCollection<RaycastHit2D>.IsCompatibleObject
	|-ReadOnlyCollection<RaycastResult>.IsCompatibleObject
	|-ReadOnlyCollection<RenderTargetIdentifier>.IsCompatibleObject
	|-ReadOnlyCollection<Resolution>.IsCompatibleObject
	|-ReadOnlyCollection<RuleMatcher>.IsCompatibleObject
	|-ReadOnlyCollection<sbyte>.IsCompatibleObject
	|-ReadOnlyCollection<SelectorMatchRecord>.IsCompatibleObject
	|-ReadOnlyCollection<SerializedCommand>.IsCompatibleObject
	|-ReadOnlyCollection<float>.IsCompatibleObject
	|-ReadOnlyCollection<Sku>.IsCompatibleObject
	|-ReadOnlyCollection<SplineKnotIndex>.IsCompatibleObject
	|-ReadOnlyCollection<StylePropertyName>.IsCompatibleObject
	|-ReadOnlyCollection<StylePropertyValue>.IsCompatibleObject
	|-ReadOnlyCollection<StyleSelectorPart>.IsCompatibleObject
	|-ReadOnlyCollection<StyleSyntaxToken>.IsCompatibleObject
	|-ReadOnlyCollection<StyleValue>.IsCompatibleObject
	|-ReadOnlyCollection<StyleValueManaged>.IsCompatibleObject
	|-ReadOnlyCollection<StyleVariable>.IsCompatibleObject
	|-ReadOnlyCollection<TimeSpan>.IsCompatibleObject
	|-ReadOnlyCollection<TimeValue>.IsCompatibleObject
	|-ReadOnlyCollection<TreeViewItemWrapper>.IsCompatibleObject
	|-ReadOnlyCollection<Triangle>.IsCompatibleObject
	|-ReadOnlyCollection<TypeWrapper>.IsCompatibleObject
	|-ReadOnlyCollection<UICharInfo>.IsCompatibleObject
	|-ReadOnlyCollection<UILineInfo>.IsCompatibleObject
	|-ReadOnlyCollection<UIVertex>.IsCompatibleObject
	|-ReadOnlyCollection<ushort>.IsCompatibleObject
	|-ReadOnlyCollection<uint>.IsCompatibleObject
	|-ReadOnlyCollection<UInt32Enum>.IsCompatibleObject
	|-ReadOnlyCollection<ulong>.IsCompatibleObject
	|-ReadOnlyCollection<User>.IsCompatibleObject
	|-ReadOnlyCollection<UxmlDescription>.IsCompatibleObject
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.IsCompatibleObject
	|-ReadOnlyCollection<Vector2>.IsCompatibleObject
	|-ReadOnlyCollection<Vector2Int>.IsCompatibleObject
	|-ReadOnlyCollection<Vector3>.IsCompatibleObject
	|-ReadOnlyCollection<Vector4>.IsCompatibleObject
	|-ReadOnlyCollection<X509ChainStatus>.IsCompatibleObject
	|-ReadOnlyCollection<float3>.IsCompatibleObject
	|-ReadOnlyCollection<fsVersionedType>.IsCompatibleObject
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.IsCompatibleObject
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.IsCompatibleObject
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.IsCompatibleObject
	|-ReadOnlyCollection<BitmapAllocator32.Page>.IsCompatibleObject
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.IsCompatibleObject
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.IsCompatibleObject
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.IsCompatibleObject
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.IsCompatibleObject
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.IsCompatibleObject
	|-ReadOnlyCollection<DataBindingManager.BindingData>.IsCompatibleObject
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.IsCompatibleObject
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.IsCompatibleObject
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.IsCompatibleObject
	|-ReadOnlyCollection<EventProvider.Registration>.IsCompatibleObject
	|-ReadOnlyCollection<Expander.ExpansionRule>.IsCompatibleObject
	|-ReadOnlyCollection<FocusController.FocusedElement>.IsCompatibleObject
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.IsCompatibleObject
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.IsCompatibleObject
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.IsCompatibleObject
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.IsCompatibleObject
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.IsCompatibleObject
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.IsCompatibleObject
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.IsCompatibleObject
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.IsCompatibleObject
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.IsCompatibleObject
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.IsCompatibleObject
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.IsCompatibleObject
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.IsCompatibleObject
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.IsCompatibleObject
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.IsCompatibleObject
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.IsCompatibleObject
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.IsCompatibleObject
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.IsCompatibleObject
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.IsCompatibleObject
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.IsCompatibleObject
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.IsCompatibleObject
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.IsCompatibleObject
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.IsCompatibleObject
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.IsCompatibleObject
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.IsCompatibleObject
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.IsCompatibleObject
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.IsCompatibleObject
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.IsCompatibleObject
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.IsCompatibleObject
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.IsCompatibleObject
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.IsCompatibleObject
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.IsCompatibleObject
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.IsCompatibleObject
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.IsCompatibleObject
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.IsCompatibleObject
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.IsCompatibleObject
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.IsCompatibleObject
	|
	|-RVA: 0x91CEB0 Offset: 0x91B4B0 VA: 0x18091CEB0
	|-ReadOnlyCollection<object>.IsCompatibleObject
	|
	|-RVA: 0x92E8D0 Offset: 0x92CED0 VA: 0x18092E8D0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x905B20 Offset: 0x904120 VA: 0x180905B20
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.Contains
	|
	|-RVA: 0x905610 Offset: 0x903C10 VA: 0x180905610
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Contains
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.Contains
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.Contains
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.Contains
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.Contains
	|
	|-RVA: 0x9052B0 Offset: 0x9038B0 VA: 0x1809052B0
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Color>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Contains
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.Contains
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Contains
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Contains
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Contains
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.Contains
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.Contains
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Contains
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.Contains
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.Contains
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.Contains
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Contains
	|
	|-RVA: 0x905970 Offset: 0x903F70 VA: 0x180905970
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Contains
	|
	|-RVA: 0x905460 Offset: 0x903A60 VA: 0x180905460
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.Contains
	|
	|-RVA: 0x9057B0 Offset: 0x903DB0 VA: 0x1809057B0
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.Contains
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.Contains
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.Contains
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.Contains
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.Contains
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.Contains
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.Contains
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x919E40 Offset: 0x918440 VA: 0x180919E40
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Contains
	|-ReadOnlyCollection<float3>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.Contains
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.Contains
	|
	|-RVA: 0x9193C0 Offset: 0x9179C0 VA: 0x1809193C0
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Sku>.System.Collections.IList.Contains
	|-ReadOnlyCollection<User>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.Contains
	|
	|-RVA: 0x919AC0 Offset: 0x9180C0 VA: 0x180919AC0
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.Contains
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.Contains
	|
	|-RVA: 0x919750 Offset: 0x917D50 VA: 0x180919750
	|-ReadOnlyCollection<bool>.System.Collections.IList.Contains
	|-ReadOnlyCollection<byte>.System.Collections.IList.Contains
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Contains
	|
	|-RVA: 0x919CA0 Offset: 0x9182A0 VA: 0x180919CA0
	|-ReadOnlyCollection<char>.System.Collections.IList.Contains
	|-ReadOnlyCollection<short>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Contains
	|
	|-RVA: 0x9195B0 Offset: 0x917BB0 VA: 0x1809195B0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Contains
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.Contains
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.Contains
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.Contains
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Contains
	|
	|-RVA: 0x91A380 Offset: 0x918980 VA: 0x18091A380
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Contains
	|
	|-RVA: 0x91A190 Offset: 0x918790 VA: 0x18091A190
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x9198F0 Offset: 0x917EF0 VA: 0x1809198F0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Contains
	|
	|-RVA: 0x919FF0 Offset: 0x9185F0 VA: 0x180919FF0
	|-ReadOnlyCollection<double>.System.Collections.IList.Contains
	|
	|-RVA: 0x9191D0 Offset: 0x9177D0 VA: 0x1809191D0
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.Contains
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.Contains
	|
	|-RVA: 0x92C060 Offset: 0x92A660 VA: 0x18092C060
	|-ReadOnlyCollection<int>.System.Collections.IList.Contains
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Contains
	|-ReadOnlyCollection<uint>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x92B8D0 Offset: 0x929ED0 VA: 0x18092B8D0
	|-ReadOnlyCollection<long>.System.Collections.IList.Contains
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.Contains
	|
	|-RVA: 0x92C560 Offset: 0x92AB60 VA: 0x18092C560
	|-ReadOnlyCollection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x92C6F0 Offset: 0x92ACF0 VA: 0x18092C6F0
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.Contains
	|
	|-RVA: 0x92BDC0 Offset: 0x92A3C0 VA: 0x18092BDC0
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.Contains
	|
	|-RVA: 0x92C180 Offset: 0x92A780 VA: 0x18092C180
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Contains
	|
	|-RVA: 0x92C350 Offset: 0x92A950 VA: 0x18092C350
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Contains
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.Contains
	|
	|-RVA: 0x92B9F0 Offset: 0x929FF0 VA: 0x18092B9F0
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.Contains
	|
	|-RVA: 0x92BC20 Offset: 0x92A220 VA: 0x18092BC20
	|-ReadOnlyCollection<float>.System.Collections.IList.Contains
	|
	|-RVA: 0x93D780 Offset: 0x93BD80 VA: 0x18093D780
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Contains
	|
	|-RVA: 0x93D5E0 Offset: 0x93BBE0 VA: 0x18093D5E0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Contains
	|
	|-RVA: 0x93DBC0 Offset: 0x93C1C0 VA: 0x18093DBC0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	|
	|-RVA: 0x93D350 Offset: 0x93B950 VA: 0x18093D350
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.Contains
	|
	|-RVA: 0x93D9D0 Offset: 0x93BFD0 VA: 0x18093D9D0
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.Contains
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Contains
	|
	|-RVA: 0x94C620 Offset: 0x94AC20 VA: 0x18094C620
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.Contains
	|
	|-RVA: 0x94C370 Offset: 0x94A970 VA: 0x18094C370
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x906560 Offset: 0x904B60 VA: 0x180906560
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x905E90 Offset: 0x904490 VA: 0x180905E90
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Edge>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x905CE0 Offset: 0x9042E0 VA: 0x180905CE0
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Color>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Guid>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x906030 Offset: 0x904630 VA: 0x180906030
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x9063B0 Offset: 0x9049B0 VA: 0x1809063B0
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x9061E0 Offset: 0x9047E0 VA: 0x1809061E0
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91AD00 Offset: 0x919300 VA: 0x18091AD00
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<float3>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91AEB0 Offset: 0x9194B0 VA: 0x18091AEB0
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Sku>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<User>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91AB20 Offset: 0x919120 VA: 0x18091AB20
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91B240 Offset: 0x919840 VA: 0x18091B240
	|-ReadOnlyCollection<bool>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<byte>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91A980 Offset: 0x918F80 VA: 0x18091A980
	|-ReadOnlyCollection<char>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<short>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ushort>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91B0A0 Offset: 0x9196A0 VA: 0x18091B0A0
	|-ReadOnlyCollection<Color32>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91B3E0 Offset: 0x9199E0 VA: 0x18091B3E0
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91B630 Offset: 0x919C30 VA: 0x18091B630
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91A5C0 Offset: 0x918BC0 VA: 0x18091A5C0
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91B820 Offset: 0x919E20 VA: 0x18091B820
	|-ReadOnlyCollection<double>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x91A790 Offset: 0x918D90 VA: 0x18091A790
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x92CB80 Offset: 0x92B180 VA: 0x18092CB80
	|-ReadOnlyCollection<int>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<uint>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x92D130 Offset: 0x92B730 VA: 0x18092D130
	|-ReadOnlyCollection<long>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x92D680 Offset: 0x92BC80 VA: 0x18092D680
	|-ReadOnlyCollection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x92D260 Offset: 0x92B860 VA: 0x18092D260
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x92CE80 Offset: 0x92B480 VA: 0x18092CE80
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x92CCB0 Offset: 0x92B2B0 VA: 0x18092CCB0
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x92C970 Offset: 0x92AF70 VA: 0x18092C970
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x92D820 Offset: 0x92BE20 VA: 0x18092D820
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x92D4E0 Offset: 0x92BAE0 VA: 0x18092D4E0
	|-ReadOnlyCollection<float>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x93E440 Offset: 0x93CA40 VA: 0x18093E440
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x93DEE0 Offset: 0x93C4E0 VA: 0x18093DEE0
	|-ReadOnlyCollection<ulong>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x93E080 Offset: 0x93C680 VA: 0x18093E080
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x93E1B0 Offset: 0x93C7B0 VA: 0x18093E1B0
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x93DCF0 Offset: 0x93C2F0 VA: 0x18093DCF0
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.IndexOf
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x94C830 Offset: 0x94AE30 VA: 0x18094C830
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x94CA40 Offset: 0x94B040 VA: 0x18094CA40
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.Insert
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Insert
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.Insert
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<bool>.System.Collections.IList.Insert
	|-ReadOnlyCollection<byte>.System.Collections.IList.Insert
	|-ReadOnlyCollection<char>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Color>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<double>.System.Collections.IList.Insert
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Insert
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.Insert
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.Insert
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.Insert
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<short>.System.Collections.IList.Insert
	|-ReadOnlyCollection<int>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Insert
	|-ReadOnlyCollection<long>.System.Collections.IList.Insert
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Insert
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<object>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.Insert
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.Insert
	|-ReadOnlyCollection<float>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Sku>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.Insert
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Insert
	|-ReadOnlyCollection<uint>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Insert
	|-ReadOnlyCollection<User>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Insert
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Insert
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	|-ReadOnlyCollection<float3>.System.Collections.IList.Insert
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.Insert
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.Insert
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Insert
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.Insert
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.Insert
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.Insert
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.Insert
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Insert
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.Insert
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.Insert
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Insert
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Insert
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.Insert
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Insert
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.Insert
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.Insert
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Insert
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.Insert
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.Insert
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.Insert
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.Remove
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.Remove
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.Remove
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<bool>.System.Collections.IList.Remove
	|-ReadOnlyCollection<byte>.System.Collections.IList.Remove
	|-ReadOnlyCollection<char>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Color>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Color32>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<double>.System.Collections.IList.Remove
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Edge>.System.Collections.IList.Remove
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.Remove
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.Remove
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.Remove
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Guid>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<short>.System.Collections.IList.Remove
	|-ReadOnlyCollection<int>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.Remove
	|-ReadOnlyCollection<long>.System.Collections.IList.Remove
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.Remove
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<object>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.Remove
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.Remove
	|-ReadOnlyCollection<float>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Sku>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.Remove
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ushort>.System.Collections.IList.Remove
	|-ReadOnlyCollection<uint>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ulong>.System.Collections.IList.Remove
	|-ReadOnlyCollection<User>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.Remove
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.Remove
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	|-ReadOnlyCollection<float3>.System.Collections.IList.Remove
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.Remove
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.Remove
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.Remove
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.Remove
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.Remove
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.Remove
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.Remove
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.Remove
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.Remove
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.Remove
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.Remove
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.Remove
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.Remove
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.Remove
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.Remove
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.Remove
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.Remove
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.Remove
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.Remove
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.Remove
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA80 Offset: 0x8FC080 VA: 0x1808FDA80
	|-ReadOnlyCollection<AsyncOperationHandle<object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DataPoint<int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DataPoint<object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DataPoint<float>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DataPoint<float4>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<Edge, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<int, int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<int, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<long, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, bool>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<KeyValuePair<object, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeArray<ConvertMeshJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeArray<CopyMeshJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeArray<NudgeJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeSlice<ConvertMeshJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeSlice<CopyMeshJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeSlice<NudgeJobData>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeSlice<ushort>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<NativeSlice<Vertex>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TempAllocator.Page<ushort>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TempAllocator.Page<Vertex>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SimpleTuple<int, int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SimpleTuple<object, Edge>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SimpleTuple<object, int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SimpleTuple<object, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SimpleTuple<float, Vector2>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StructMultiKey<object, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ValueTuple<int, int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ValueTuple<LocaleIdentifier, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ValueTuple<Vector2Int, int>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ValueTuple<Rect, Rect, object>>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<AsyncOperationHandle>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<BezierKnot>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<BezierPoint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<bool>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<byte>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<char>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Color>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Color32>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CombineInstance>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ComputedTransitionProperty>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ControllerPollingInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ControllerTemplateElementTarget>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DateTime>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DateTimeOffset>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Decimal>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DiagnosticEvent>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DisplayInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<double>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<EasingFunction>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Edge>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<EdgeLookup>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ElementAssignmentConflictInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Entitlement>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<FileStat>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<GCHandle>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<GlyphPairAdjustmentRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<GlyphRect>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Guid>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InputActionSourceData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<short>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<int>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Int32Enum>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<long>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<IntPtr>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InterpretedFrameInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<JsonPosition>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<LigatureSubstitutionRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ManipulatorActivationFilter>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MarkToBaseAdjustmentRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MarkToMarkAdjustmentRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MultipleSubstitutionRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<object>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ObjectInitializationData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PidVid>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PropertyPath>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PropertyPathInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PropertyPathPart>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Quaternion>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RangePositionInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RaycastHit2D>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RaycastResult>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RenderTargetIdentifier>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Resolution>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RuleMatcher>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<sbyte>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SelectorMatchRecord>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SerializedCommand>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<float>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Sku>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SplineKnotIndex>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StylePropertyName>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StylePropertyValue>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StyleSelectorPart>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StyleSyntaxToken>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StyleValue>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StyleValueManaged>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<StyleVariable>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TimeSpan>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TimeValue>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TreeViewItemWrapper>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Triangle>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TypeWrapper>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UICharInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UILineInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UIVertex>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ushort>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<uint>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UInt32Enum>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ulong>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<User>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UxmlDescription>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UxmlNamespaceDefinition>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Vector2>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Vector2Int>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Vector3>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Vector4>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<X509ChainStatus>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<float3>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<fsVersionedType>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<AnimatedMeshScriptableObject.Animation>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Awaitable.AwaitableAndFrameIndex>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<BeforeRenderHelper.OrderBlock>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<BitmapAllocator32.Page>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CharacterSubstitutor.CharReplacement>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CreationContext.AttributeOverrideRange>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CreationContext.SerializedDataOverrideRange>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<CustomController.KiLXVYKHYMbZvvyjxfoVHhxraxAi>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DXnTDZXHQpCujdEJFmFqfVHQdWXDb.ZfJsnwpzeUVRKsNYVaGcdqKsEvCiA>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DataBindingManager.BindingData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DataBindingManager.BindingRequest>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<DelayedActionManager.DelegateInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<EntryPreProcessor.AllocSize>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<EventProvider.Registration>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Expander.ExpansionRule>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<FocusController.FocusedElement>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<GrassChunkManager.GrassData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<GrassChunkManager.GrassInstance>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<HijykGpnyXfeYIerfVreevyeqZGM.IRxMMtNknCbkkyBHqmJzIKAlUJSl>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.JoJYJdIdtfSiGCgSmXdqtJRIRxJB>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.ltPGxQzSNiWBWxsKUhkZGQtSCPeL>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ITuaUliMwXPnKweTZqmoWqgcoSFGA.qfJAipbIdExnEaMNeCsUnhHFoYRi>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MeshGenerator.RepeatRectUV>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MeshGenerator.TessellationJobParameters>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MultiColumnCollectionHeader.SortedColumnState>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<Painter2D.Painter2DJobData>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RaycastUtility.ConeSphere>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RegexCharClass.SingleRange>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<ResourceManager.DeferredCallbackRegisterRequest>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<SplineInstantiate.InstantiableItem>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TemplateAsset.AttributeOverride>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TemplateAsset.UxmlSerializedDataOverride>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TextSettings.FontReferenceMap>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TextureBlitter.BlitInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TexturePacker_JsonArray.Frame>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<TextureRegistry.TextureInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UIRenderDevice.AllocToFree>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UIRenderDevice.AllocToUpdate>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UnitySynchronizationContext.WorkRequest>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UnityUITextMeshProGlyphHelper.GlyphOrText>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.AssetEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.SlotDefinition>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.SlotUsageEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.UsingEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeAsset.UxmlObjectEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<VisualTreeDataBindingsUpdater.VersionInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<fsAotCompilationManager.AotCompilation>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<InstructionList.DebugView.InstructionView>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<MultiColumnCollectionHeader.ViewState.ColumnState>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<PlayerController.Element.PtLKUxxIyabJJvxoMbvgOMZNnUiJ>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<RenderChain.VisualChangesProcessor.EntryProcessingInfo>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry>.System.Collections.IList.RemoveAt
	|-ReadOnlyCollection<UserDataStore_PlayerPrefs.ControllerElementByRoleMap.Entry>.System.Collections.IList.RemoveAt
	*/
}

// Namespace: System.Collections.ObjectModel
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[Serializable]
public abstract class KeyedCollection<TKey, TItem> : Collection<TItem> // TypeDefIndex: 1489
{
	// Fields
	private readonly IEqualityComparer<TKey> comparer; // 0x0
	private Dictionary<TKey, TItem> dict; // 0x0
	private int keyCount; // 0x0
	private readonly int threshold; // 0x0

	// Properties
	private List<TItem> Items { get; }
	public TItem Item { get; }
	protected IDictionary<TKey, TItem> Dictionary { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110AC60 Offset: 0x1109260 VA: 0x18110AC60
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0xE5F9B0 Offset: 0xE5DFB0 VA: 0x180E5F9B0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110AB10 Offset: 0x1109110 VA: 0x18110AB10
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0xE604E0 Offset: 0xE5EAE0 VA: 0x180E604E0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110AB30 Offset: 0x1109130 VA: 0x18110AB30
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x110AC80 Offset: 0x1109280 VA: 0x18110AC80
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private List<TItem> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B1D0 Offset: 0x11097D0 VA: 0x18110B1D0
	|-KeyedCollection<object, object>.get_Items
	|
	|-RVA: 0x110B110 Offset: 0x1109710 VA: 0x18110B110
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1
	public TItem get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B050 Offset: 0x1109650 VA: 0x18110B050
	|-KeyedCollection<object, object>.get_Item
	|
	|-RVA: 0x110ADC0 Offset: 0x11093C0 VA: 0x18110ADC0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1107DB0 Offset: 0x11063B0 VA: 0x181107DB0
	|-KeyedCollection<object, object>.Contains
	|
	|-RVA: 0x11077C0 Offset: 0x1105DC0 VA: 0x1811077C0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110A130 Offset: 0x1108730 VA: 0x18110A130
	|-KeyedCollection<object, object>.TryGetValue
	|
	|-RVA: 0x110A420 Offset: 0x1108A20 VA: 0x18110A420
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private bool ContainsItem(TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1107220 Offset: 0x1105820 VA: 0x181107220
	|-KeyedCollection<object, object>.ContainsItem
	|
	|-RVA: 0x11073A0 Offset: 0x11059A0 VA: 0x1811073A0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsItem
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11090F0 Offset: 0x11076F0 VA: 0x1811090F0
	|-KeyedCollection<object, object>.Remove
	|
	|-RVA: 0x1109380 Offset: 0x1107980 VA: 0x181109380
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	protected IDictionary<TKey, TItem> get_Dictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-KeyedCollection<object, object>.get_Dictionary
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Dictionary
	*/

	// RVA: -1 Offset: -1
	protected void ChangeItemKey(TItem item, TKey newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11069B0 Offset: 0x1104FB0 VA: 0x1811069B0
	|-KeyedCollection<object, object>.ChangeItemKey
	|
	|-RVA: 0x1106C60 Offset: 0x1105260 VA: 0x181106C60
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ChangeItemKey
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11071B0 Offset: 0x11057B0 VA: 0x1811071B0
	|-KeyedCollection<object, object>.ClearItems
	|
	|-RVA: 0x1107140 Offset: 0x1105740 VA: 0x181107140
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract TKey GetKeyForItem(TItem item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeyForItem
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1108840 Offset: 0x1106E40 VA: 0x181108840
	|-KeyedCollection<object, object>.InsertItem
	|
	|-RVA: 0x11088D0 Offset: 0x1106ED0 VA: 0x1811088D0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1108BD0 Offset: 0x11071D0 VA: 0x181108BD0
	|-KeyedCollection<object, object>.RemoveItem
	|
	|-RVA: 0x1108D30 Offset: 0x1107330 VA: 0x181108D30
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected override void SetItem(int index, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1109840 Offset: 0x1107E40 VA: 0x181109840
	|-KeyedCollection<object, object>.SetItem
	|
	|-RVA: 0x1109A60 Offset: 0x1108060 VA: 0x181109A60
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1
	private void AddKey(TKey key, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1106890 Offset: 0x1104E90 VA: 0x181106890
	|-KeyedCollection<object, object>.AddKey
	|
	|-RVA: 0x1106580 Offset: 0x1104B80 VA: 0x181106580
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddKey
	*/

	// RVA: -1 Offset: -1
	private void CreateDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1108070 Offset: 0x1106670 VA: 0x181108070
	|-KeyedCollection<object, object>.CreateDictionary
	|
	|-RVA: 0x11082C0 Offset: 0x11068C0 VA: 0x1811082C0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDictionary
	*/

	// RVA: -1 Offset: -1
	private void RemoveKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1108FB0 Offset: 0x11075B0 VA: 0x181108FB0
	|-KeyedCollection<object, object>.RemoveKey
	|
	|-RVA: 0x1108FF0 Offset: 0x11075F0 VA: 0x181108FF0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveKey
	*/
}

// Namespace: System.Collections.ObjectModel
[DebuggerTypeProxy(typeof(DictionaryDebugView<K, V>))]
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[Serializable]
public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 1493
{
	// Fields
	private readonly IDictionary<TKey, TValue> m_dictionary; // 0x0
	private object _syncRoot; // 0x0
	private ReadOnlyDictionary.KeyCollection<TKey, TValue> _keys; // 0x0
	private ReadOnlyDictionary.ValueCollection<TKey, TValue> _values; // 0x0

	// Properties
	public ReadOnlyDictionary.KeyCollection<TKey, TValue> Keys { get; }
	public ReadOnlyDictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	public TValue Item { get; }
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item { get; set; }
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public ReadOnlyDictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E500 Offset: 0x94CB00 VA: 0x18094E500
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyDictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E5E0 Offset: 0x94CBE0 VA: 0x18094E5E0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94CEC0 Offset: 0x94B4C0 VA: 0x18094CEC0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8788F0 Offset: 0x876EF0 VA: 0x1808788F0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E330 Offset: 0x94C930 VA: 0x18094E330
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D430 Offset: 0x94BA30 VA: 0x18094D430
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D2D0 Offset: 0x94B8D0 VA: 0x18094D2D0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D280 Offset: 0x94B880 VA: 0x18094D280
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D0B0 Offset: 0x94B6B0 VA: 0x18094D0B0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D2D0 Offset: 0x94B8D0 VA: 0x18094D2D0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D280 Offset: 0x94B880 VA: 0x18094D280
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E4B0 Offset: 0x94CAB0 VA: 0x18094E4B0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D150 Offset: 0x94B750 VA: 0x18094D150
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D210 Offset: 0x94B810 VA: 0x18094D210
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D0B0 Offset: 0x94B6B0 VA: 0x18094D0B0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D100 Offset: 0x94B700 VA: 0x18094D100
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D0B0 Offset: 0x94B6B0 VA: 0x18094D0B0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94CFC0 Offset: 0x94B5C0 VA: 0x18094CFC0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E2E0 Offset: 0x94C8E0 VA: 0x18094E2E0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D010 Offset: 0x94B610 VA: 0x18094D010
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D280 Offset: 0x94B880 VA: 0x18094D280
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IDictionary.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D100 Offset: 0x94B700 VA: 0x18094D100
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94DF70 Offset: 0x94C570 VA: 0x18094DF70
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E0A0 Offset: 0x94C6A0 VA: 0x18094E0A0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8788F0 Offset: 0x876EF0 VA: 0x1808788F0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D0B0 Offset: 0x94B6B0 VA: 0x18094D0B0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D430 Offset: 0x94BA30 VA: 0x18094D430
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E160 Offset: 0x94C760 VA: 0x18094E160
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D280 Offset: 0x94B880 VA: 0x18094D280
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D460 Offset: 0x94BA60 VA: 0x18094D460
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94DE90 Offset: 0x94C490 VA: 0x18094DE90
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8788F0 Offset: 0x876EF0 VA: 0x1808788F0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D430 Offset: 0x94BA30 VA: 0x18094D430
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/
}

// Namespace: System.Collections.ObjectModel
internal static class ReadOnlyDictionaryHelpers // TypeDefIndex: 1494
{
	// Methods

	// RVA: -1 Offset: -1
	internal static void CopyToNonGenericICollectionHelper<T>(ICollection<T> collection, Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78D790 Offset: 0x78BD90 VA: 0x18078D790
	|-ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<__Il2CppFullySharedGenericType>
	*/
}

