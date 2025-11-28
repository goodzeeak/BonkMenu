// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class AsyncUtils // TypeDefIndex: 8255
{
	// Fields
	public static readonly Task<bool> False; // 0x0
	public static readonly Task<bool> True; // 0x8
	internal static readonly Task CompletedTask; // 0x10

	// Methods

	[Extension]
	// RVA: 0x15F68C0 Offset: 0x15F4EC0 VA: 0x1815F68C0
	internal static Task<bool> ToAsync(bool value) { }

	[NullableContext(2)]
	[Extension]
	// RVA: 0x15F65F0 Offset: 0x15F4BF0 VA: 0x1815F65F0
	public static Task CancelIfRequestedAsync(CancellationToken cancellationToken) { }

	[NullableContext(2)]
	[Extension]
	// RVA: -1 Offset: -1
	public static Task<T> CancelIfRequestedAsync<T>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x664960 Offset: 0x662F60 VA: 0x180664960
	|-AsyncUtils.CancelIfRequestedAsync<Nullable<bool>>
	|
	|-RVA: 0x664AC0 Offset: 0x6630C0 VA: 0x180664AC0
	|-AsyncUtils.CancelIfRequestedAsync<Nullable<DateTime>>
	|
	|-RVA: 0x6648B0 Offset: 0x662EB0 VA: 0x1806648B0
	|-AsyncUtils.CancelIfRequestedAsync<Nullable<DateTimeOffset>>
	|
	|-RVA: 0x664800 Offset: 0x662E00 VA: 0x180664800
	|-AsyncUtils.CancelIfRequestedAsync<Nullable<Decimal>>
	|
	|-RVA: 0x664A10 Offset: 0x663010 VA: 0x180664A10
	|-AsyncUtils.CancelIfRequestedAsync<Nullable<int>>
	|
	|-RVA: 0x6646A0 Offset: 0x662CA0 VA: 0x1806646A0
	|-AsyncUtils.CancelIfRequestedAsync<bool>
	|
	|-RVA: 0x664B70 Offset: 0x663170 VA: 0x180664B70
	|-AsyncUtils.CancelIfRequestedAsync<object>
	|
	|-RVA: 0x664750 Offset: 0x662D50 VA: 0x180664750
	|-AsyncUtils.CancelIfRequestedAsync<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x15F6680 Offset: 0x15F4C80 VA: 0x1815F6680
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static Task<T> FromCanceled<T>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x665490 Offset: 0x663A90 VA: 0x180665490
	|-AsyncUtils.FromCanceled<Nullable<bool>>
	|
	|-RVA: 0x6657F0 Offset: 0x663DF0 VA: 0x1806657F0
	|-AsyncUtils.FromCanceled<Nullable<DateTime>>
	|
	|-RVA: 0x6652E0 Offset: 0x6638E0 VA: 0x1806652E0
	|-AsyncUtils.FromCanceled<Nullable<DateTimeOffset>>
	|
	|-RVA: 0x665130 Offset: 0x663730 VA: 0x180665130
	|-AsyncUtils.FromCanceled<Nullable<Decimal>>
	|
	|-RVA: 0x665640 Offset: 0x663C40 VA: 0x180665640
	|-AsyncUtils.FromCanceled<Nullable<int>>
	|
	|-RVA: 0x664C20 Offset: 0x663220 VA: 0x180664C20
	|-AsyncUtils.FromCanceled<bool>
	|
	|-RVA: 0x664F80 Offset: 0x663580 VA: 0x180664F80
	|-AsyncUtils.FromCanceled<int>
	|
	|-RVA: 0x6659A0 Offset: 0x663FA0 VA: 0x1806659A0
	|-AsyncUtils.FromCanceled<object>
	|
	|-RVA: 0x664DD0 Offset: 0x6633D0 VA: 0x180664DD0
	|-AsyncUtils.FromCanceled<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x15F6AF0 Offset: 0x15F50F0 VA: 0x1815F6AF0
	public static Task WriteAsync(TextWriter writer, char value, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x15F6950 Offset: 0x15F4F50 VA: 0x1815F6950
	public static Task WriteAsync(TextWriter writer, string value, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x15F6A10 Offset: 0x15F5010 VA: 0x1815F6A10
	public static Task WriteAsync(TextWriter writer, char[] value, int start, int count, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x15F67D0 Offset: 0x15F4DD0 VA: 0x1815F67D0
	public static Task<int> ReadAsync(TextReader reader, char[] buffer, int index, int count, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x15F67A0 Offset: 0x15F4DA0 VA: 0x1815F67A0
	public static bool IsCompletedSucessfully(Task task) { }

	// RVA: 0x15F6BB0 Offset: 0x15F51B0 VA: 0x1815F6BB0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class Base64Encoder // TypeDefIndex: 8257
{
	// Fields
	private const int Base64LineSize = 76;
	private const int LineSizeInBytes = 57;
	private readonly char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	[Nullable(2)]
	private byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28

	// Methods

	// RVA: 0x15F75F0 Offset: 0x15F5BF0 VA: 0x1815F75F0
	public void .ctor(TextWriter writer) { }

	// RVA: 0x15F73D0 Offset: 0x15F59D0 VA: 0x1815F73D0
	private void ValidateEncode(byte[] buffer, int index, int count) { }

	// RVA: 0x15F6DF0 Offset: 0x15F53F0 VA: 0x1815F6DF0
	public void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x15F72E0 Offset: 0x15F58E0 VA: 0x1815F72E0
	private void StoreLeftOverBytes(byte[] buffer, int index, ref int count) { }

	// RVA: 0x15F7230 Offset: 0x15F5830 VA: 0x1815F7230
	private bool FulfillFromLeftover(byte[] buffer, int index, ref int count) { }

	// RVA: 0x15F7160 Offset: 0x15F5760 VA: 0x1815F7160
	public void Flush() { }

	// RVA: 0x15F75C0 Offset: 0x15F5BC0 VA: 0x1815F75C0
	private void WriteChars(char[] chars, int index, int count) { }

	[AsyncStateMachine(typeof(Base64Encoder.<EncodeAsync>d__13))]
	// RVA: 0x15F6CB0 Offset: 0x15F52B0 VA: 0x1815F6CB0
	public Task EncodeAsync(byte[] buffer, int index, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15F7530 Offset: 0x15F5B30 VA: 0x1815F7530
	private Task WriteCharsAsync(char[] chars, int index, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15F7000 Offset: 0x15F5600 VA: 0x1815F7000
	public Task FlushAsync(CancellationToken cancellationToken) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class BidirectionalDictionary<TFirst, TSecond> // TypeDefIndex: 8258
{
	// Fields
	private readonly IDictionary<TFirst, TSecond> _firstToSecond; // 0x0
	private readonly IDictionary<TSecond, TFirst> _secondToFirst; // 0x0
	private readonly string _duplicateFirstErrorMessage; // 0x0
	private readonly string _duplicateSecondErrorMessage; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC85E20 Offset: 0xC84420 VA: 0x180C85E20
	|-BidirectionalDictionary<object, object>..ctor
	|
	|-RVA: 0xC86260 Offset: 0xC84860 VA: 0x180C86260
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC862F0 Offset: 0xC848F0 VA: 0x180C862F0
	|-BidirectionalDictionary<object, object>..ctor
	|
	|-RVA: 0xC85FA0 Offset: 0xC845A0 VA: 0x180C85FA0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC86140 Offset: 0xC84740 VA: 0x180C86140
	|-BidirectionalDictionary<object, object>..ctor
	|
	|-RVA: 0xC86020 Offset: 0xC84620 VA: 0x180C86020
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Set(TFirst first, TSecond second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC84F30 Offset: 0xC83530 VA: 0x180C84F30
	|-BidirectionalDictionary<object, object>.Set
	|
	|-RVA: 0xC85270 Offset: 0xC83870 VA: 0x180C85270
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Set
	*/

	// RVA: -1 Offset: -1
	public bool TryGetByFirst(TFirst first, out TSecond second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC85B20 Offset: 0xC84120 VA: 0x180C85B20
	|-BidirectionalDictionary<object, object>.TryGetByFirst
	|
	|-RVA: 0xC85B90 Offset: 0xC84190 VA: 0x180C85B90
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetByFirst
	*/

	// RVA: -1 Offset: -1
	public bool TryGetBySecond(TSecond second, out TFirst first) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC85DB0 Offset: 0xC843B0 VA: 0x180C85DB0
	|-BidirectionalDictionary<object, object>.TryGetBySecond
	|
	|-RVA: 0xC85CA0 Offset: 0xC842A0 VA: 0x180C85CA0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetBySecond
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class CollectionUtils // TypeDefIndex: 8260
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B8EE0 Offset: 0x6B74E0 VA: 0x1806B8EE0
	|-CollectionUtils.IsNullOrEmpty<object>
	|-CollectionUtils.IsNullOrEmpty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B7AD0 Offset: 0x6B60D0 VA: 0x1806B7AD0
	|-CollectionUtils.AddRange<object>
	|
	|-RVA: 0x6B77C0 Offset: 0x6B5DC0 VA: 0x1806B77C0
	|-CollectionUtils.AddRange<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15F8D70 Offset: 0x15F7370 VA: 0x1815F8D70
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0x15F8FF0 Offset: 0x15F75F0 VA: 0x1815F8FF0
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0x15F9110 Offset: 0x15F7710 VA: 0x1815F9110
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static bool AddDistinct<T>(IList<T> list, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B70D0 Offset: 0x6B56D0 VA: 0x1806B70D0
	|-CollectionUtils.AddDistinct<object>
	|
	|-RVA: 0x6B6FE0 Offset: 0x6B55E0 VA: 0x1806B6FE0
	|-CollectionUtils.AddDistinct<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool AddDistinct<T>(IList<T> list, T value, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B7190 Offset: 0x6B5790 VA: 0x1806B7190
	|-CollectionUtils.AddDistinct<object>
	|
	|-RVA: 0x6B6E70 Offset: 0x6B5470 VA: 0x1806B6E70
	|-CollectionUtils.AddDistinct<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ContainsValue<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B80A0 Offset: 0x6B66A0 VA: 0x1806B80A0
	|-CollectionUtils.ContainsValue<object>
	|
	|-RVA: 0x6B7D70 Offset: 0x6B6370 VA: 0x1806B7D70
	|-CollectionUtils.ContainsValue<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool AddRangeDistinct<T>(IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B7540 Offset: 0x6B5B40 VA: 0x1806B7540
	|-CollectionUtils.AddRangeDistinct<object>
	|
	|-RVA: 0x6B7230 Offset: 0x6B5830 VA: 0x1806B7230
	|-CollectionUtils.AddRangeDistinct<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B8D40 Offset: 0x6B7340 VA: 0x1806B8D40
	|-CollectionUtils.IndexOf<object>
	|
	|-RVA: 0x6B8AA0 Offset: 0x6B70A0 VA: 0x1806B8AA0
	|-CollectionUtils.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B8450 Offset: 0x6B6A50 VA: 0x1806B8450
	|-CollectionUtils.Contains<object>
	|
	|-RVA: 0x6B82B0 Offset: 0x6B68B0 VA: 0x1806B82B0
	|-CollectionUtils.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B8A20 Offset: 0x6B7020 VA: 0x1806B8A20
	|-CollectionUtils.IndexOfReference<object>
	|
	|-RVA: 0x6B88C0 Offset: 0x6B6EC0 VA: 0x1806B88C0
	|-CollectionUtils.IndexOfReference<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void FastReverse<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B87A0 Offset: 0x6B6DA0 VA: 0x1806B87A0
	|-CollectionUtils.FastReverse<JsonPosition>
	|
	|-RVA: 0x6B8510 Offset: 0x6B6B10 VA: 0x1806B8510
	|-CollectionUtils.FastReverse<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15F89D0 Offset: 0x15F6FD0 VA: 0x1815F89D0
	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0x15F87A0 Offset: 0x15F6DA0 VA: 0x1815F87A0
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0x15F8EF0 Offset: 0x15F74F0 VA: 0x1815F8EF0
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0x15F93B0 Offset: 0x15F79B0 VA: 0x1815F93B0
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

	// RVA: -1 Offset: -1
	public static T[] ArrayEmpty<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FD9B0 Offset: 0x5FBFB0 VA: 0x1805FD9B0
	|-CollectionUtils.ArrayEmpty<byte>
	|-CollectionUtils.ArrayEmpty<int>
	|-CollectionUtils.ArrayEmpty<object>
	|-CollectionUtils.ArrayEmpty<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedCollection : IList, ICollection, IEnumerable // TypeDefIndex: 8261
{
	// Properties
	[Nullable(1)]
	public abstract object UnderlyingCollection { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingCollection();
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection // TypeDefIndex: 8262
{
	// Fields
	[Nullable(2)]
	private readonly IList _list; // 0x0
	[Nullable(new[] { 2, 1 })]
	private readonly ICollection<T> _genericCollection; // 0x0
	[Nullable(2)]
	private object _syncRoot; // 0x0

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object UnderlyingCollection { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA1210 Offset: 0xC9F810 VA: 0x180CA1210
	|-CollectionWrapper<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA11A0 Offset: 0xC9F7A0 VA: 0x180CA11A0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public virtual void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9FB40 Offset: 0xC9E140 VA: 0x180C9FB40
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9FD30 Offset: 0xC9E330 VA: 0x180C9FD30
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public virtual bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9FDD0 Offset: 0xC9E3D0 VA: 0x180C9FDD0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9FF50 Offset: 0xC9E550 VA: 0x180C9FF50
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public virtual int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA12D0 Offset: 0xC9F8D0 VA: 0x180CA12D0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public virtual bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA1370 Offset: 0xC9F970 VA: 0x180CA1370
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public virtual bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0260 Offset: 0xC9E860 VA: 0x180CA0260
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public virtual IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0070 Offset: 0xC9E670 VA: 0x180CA0070
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA05C0 Offset: 0xC9EBC0 VA: 0x180CA05C0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0610 Offset: 0xC9EC10 VA: 0x180CA0610
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0720 Offset: 0xC9ED20 VA: 0x180CA0720
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0840 Offset: 0xC9EE40 VA: 0x180CA0840
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0B20 Offset: 0xC9F120 VA: 0x180CA0B20
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA09C0 Offset: 0xC9EFC0 VA: 0x180CA09C0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0D50 Offset: 0xC9F350 VA: 0x180CA0D50
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0C40 Offset: 0xC9F240 VA: 0x180CA0C40
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0DF0 Offset: 0xC9F3F0 VA: 0x180CA0DF0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0F00 Offset: 0xC9F500 VA: 0x180CA0F00
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA04B0 Offset: 0xC9EAB0 VA: 0x180CA04B0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0550 Offset: 0xC9EB50 VA: 0x180CA0550
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	private static void VerifyValueType(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA1060 Offset: 0xC9F660 VA: 0x180CA1060
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.VerifyValueType
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA0100 Offset: 0xC9E700 VA: 0x180CA0100
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public object get_UnderlyingCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA1410 Offset: 0xC9FA10 VA: 0x180CA1410
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_UnderlyingCollection
	*/
}

// Namespace: Newtonsoft.Json.Utilities
internal enum PrimitiveTypeCode // TypeDefIndex: 8263
{
	// Fields
	public int value__; // 0x0
	public const PrimitiveTypeCode Empty = 0;
	public const PrimitiveTypeCode Object = 1;
	public const PrimitiveTypeCode Char = 2;
	public const PrimitiveTypeCode CharNullable = 3;
	public const PrimitiveTypeCode Boolean = 4;
	public const PrimitiveTypeCode BooleanNullable = 5;
	public const PrimitiveTypeCode SByte = 6;
	public const PrimitiveTypeCode SByteNullable = 7;
	public const PrimitiveTypeCode Int16 = 8;
	public const PrimitiveTypeCode Int16Nullable = 9;
	public const PrimitiveTypeCode UInt16 = 10;
	public const PrimitiveTypeCode UInt16Nullable = 11;
	public const PrimitiveTypeCode Int32 = 12;
	public const PrimitiveTypeCode Int32Nullable = 13;
	public const PrimitiveTypeCode Byte = 14;
	public const PrimitiveTypeCode ByteNullable = 15;
	public const PrimitiveTypeCode UInt32 = 16;
	public const PrimitiveTypeCode UInt32Nullable = 17;
	public const PrimitiveTypeCode Int64 = 18;
	public const PrimitiveTypeCode Int64Nullable = 19;
	public const PrimitiveTypeCode UInt64 = 20;
	public const PrimitiveTypeCode UInt64Nullable = 21;
	public const PrimitiveTypeCode Single = 22;
	public const PrimitiveTypeCode SingleNullable = 23;
	public const PrimitiveTypeCode Double = 24;
	public const PrimitiveTypeCode DoubleNullable = 25;
	public const PrimitiveTypeCode DateTime = 26;
	public const PrimitiveTypeCode DateTimeNullable = 27;
	public const PrimitiveTypeCode DateTimeOffset = 28;
	public const PrimitiveTypeCode DateTimeOffsetNullable = 29;
	public const PrimitiveTypeCode Decimal = 30;
	public const PrimitiveTypeCode DecimalNullable = 31;
	public const PrimitiveTypeCode Guid = 32;
	public const PrimitiveTypeCode GuidNullable = 33;
	public const PrimitiveTypeCode TimeSpan = 34;
	public const PrimitiveTypeCode TimeSpanNullable = 35;
	public const PrimitiveTypeCode BigInteger = 36;
	public const PrimitiveTypeCode BigIntegerNullable = 37;
	public const PrimitiveTypeCode Uri = 38;
	public const PrimitiveTypeCode String = 39;
	public const PrimitiveTypeCode Bytes = 40;
	public const PrimitiveTypeCode DBNull = 41;
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class TypeInformation // TypeDefIndex: 8264
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly PrimitiveTypeCode <TypeCode>k__BackingField; // 0x18

	// Properties
	public Type Type { get; }
	public PrimitiveTypeCode TypeCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xC05940 Offset: 0xC03F40 VA: 0x180C05940
	public void .ctor(Type type, PrimitiveTypeCode typeCode) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal enum ParseResult // TypeDefIndex: 8265
{
	// Fields
	public int value__; // 0x0
	public const ParseResult None = 0;
	public const ParseResult Success = 1;
	public const ParseResult Overflow = 2;
	public const ParseResult Invalid = 3;
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class ConvertUtils // TypeDefIndex: 8268
{
	// Fields
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	[Nullable(new[] { 1, 0, 1, 1, 2, 2, 2 })]
	private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>> CastConverters; // 0x10

	// Methods

	// RVA: 0x15FAC10 Offset: 0x15F9210 VA: 0x1815FAC10
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0x15FAC70 Offset: 0x15F9270 VA: 0x1815FAC70
	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	// RVA: 0x15FAEE0 Offset: 0x15F94E0 VA: 0x1815FAEE0
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0x15FB230 Offset: 0x15F9830 VA: 0x1815FB230
	public static bool IsConvertible(Type t) { }

	// RVA: 0x15FB3C0 Offset: 0x15F99C0 VA: 0x1815FB3C0
	public static TimeSpan ParseTimeSpan(string input) { }

	[NullableContext(2)]
	// RVA: 0x15F99E0 Offset: 0x15F7FE0 VA: 0x1815F99E0
	private static Func<object, object> CreateCastConverter(StructMultiKey<Type, Type> t) { }

	// RVA: 0x15FB450 Offset: 0x15F9A50 VA: 0x1815FB450
	internal static BigInteger ToBigInteger(object value) { }

	// RVA: 0x15FA7E0 Offset: 0x15F8DE0 VA: 0x1815FA7E0
	public static object FromBigInteger(BigInteger i, Type targetType) { }

	// RVA: 0x15F9740 Offset: 0x15F7D40 VA: 0x1815F9740
	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x15FC400 Offset: 0x15FAA00 VA: 0x1815FC400
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x15FB8D0 Offset: 0x15F9ED0 VA: 0x1815FB8D0
	private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x15F95F0 Offset: 0x15F7BF0 VA: 0x1815F95F0
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x15FA5A0 Offset: 0x15F8BA0 VA: 0x1815FA5A0
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0x15FC550 Offset: 0x15FAB50 VA: 0x1815FC550
	public static bool VersionTryParse(string input, out Version result) { }

	// RVA: 0x15FB2B0 Offset: 0x15F98B0 VA: 0x1815FB2B0
	public static bool IsInteger(object value) { }

	// RVA: 0x15FAF80 Offset: 0x15F9580 VA: 0x1815FAF80
	public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) { }

	// RVA: 0x15FB0E0 Offset: 0x15F96E0 VA: 0x1815FB0E0
	public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) { }

	// RVA: 0x15F9C60 Offset: 0x15F8260 VA: 0x1815F9C60
	public static ParseResult DecimalTryParse(char[] chars, int start, int length, out Decimal value) { }

	// RVA: 0x15FB880 Offset: 0x15F9E80 VA: 0x1815FB880
	public static bool TryConvertGuid(string s, out Guid g) { }

	// RVA: 0x15FC4B0 Offset: 0x15FAAB0 VA: 0x1815FC4B0
	public static bool TryHexTextToInt(char[] text, int start, int end, out int value) { }

	// RVA: 0x15FC560 Offset: 0x15FAB60 VA: 0x1815FC560
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
internal enum ParserTimeZone // TypeDefIndex: 8269
{
	// Fields
	public int value__; // 0x0
	public const ParserTimeZone Unspecified = 0;
	public const ParserTimeZone Utc = 1;
	public const ParserTimeZone LocalWestOfUtc = 2;
	public const ParserTimeZone LocalEastOfUtc = 3;
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal struct DateTimeParser // TypeDefIndex: 8270
{
	// Fields
	public int Year; // 0x0
	public int Month; // 0x4
	public int Day; // 0x8
	public int Hour; // 0xC
	public int Minute; // 0x10
	public int Second; // 0x14
	public int Fraction; // 0x18
	public int ZoneHour; // 0x1C
	public int ZoneMinute; // 0x20
	public ParserTimeZone Zone; // 0x24
	private char[] _text; // 0x28
	private int _end; // 0x30
	private static readonly int[] Power10; // 0x0
	private static readonly int Lzyyyy; // 0x8
	private static readonly int Lzyyyy_; // 0xC
	private static readonly int Lzyyyy_MM; // 0x10
	private static readonly int Lzyyyy_MM_; // 0x14
	private static readonly int Lzyyyy_MM_dd; // 0x18
	private static readonly int Lzyyyy_MM_ddT; // 0x1C
	private static readonly int LzHH; // 0x20
	private static readonly int LzHH_; // 0x24
	private static readonly int LzHH_mm; // 0x28
	private static readonly int LzHH_mm_; // 0x2C
	private static readonly int LzHH_mm_ss; // 0x30
	private static readonly int Lz_; // 0x34
	private static readonly int Lz_zz; // 0x38
	private const short MaxFractionDigits = 7;

	// Methods

	// RVA: 0x15FE510 Offset: 0x15FCB10 VA: 0x1815FE510
	private static void .cctor() { }

	// RVA: 0x15FE3F0 Offset: 0x15FC9F0 VA: 0x1815FE3F0
	public bool Parse(char[] text, int startIndex, int length) { }

	// RVA: 0x15FDA60 Offset: 0x15FC060 VA: 0x1815FDA60
	private bool ParseDate(int start) { }

	// RVA: 0x15FDD20 Offset: 0x15FC320 VA: 0x1815FDD20
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x15FDDA0 Offset: 0x15FC3A0 VA: 0x1815FDDA0
	private bool ParseTime(ref int start) { }

	// RVA: 0x15FE1C0 Offset: 0x15FC7C0 VA: 0x1815FE1C0
	private bool ParseZone(int start) { }

	// RVA: 0x15FD940 Offset: 0x15FBF40 VA: 0x1815FD940
	private bool Parse4Digit(int start, out int num) { }

	// RVA: 0x15FD8D0 Offset: 0x15FBED0 VA: 0x1815FD8D0
	private bool Parse2Digit(int start, out int num) { }

	// RVA: 0x15FDA20 Offset: 0x15FC020 VA: 0x1815FDA20
	private bool ParseChar(int start, char ch) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class DateTimeUtils // TypeDefIndex: 8271
{
	// Fields
	internal static readonly long InitialJavaScriptDateTicks; // 0x0
	private const string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK";
	private const int DaysPer100Years = 36524;
	private const int DaysPer400Years = 146097;
	private const int DaysPer4Years = 1461;
	private const int DaysPerYear = 365;
	private const long TicksPerDay = 864000000000;
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0x1602200 Offset: 0x1600800 VA: 0x181602200
	private static void .cctor() { }

	[Extension]
	// RVA: 0x15FF210 Offset: 0x15FD810 VA: 0x1815FF210
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0x15FF410 Offset: 0x15FDA10 VA: 0x1815FF410
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0x15FED80 Offset: 0x15FD380 VA: 0x1815FED80
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0x15FF270 Offset: 0x15FD870 VA: 0x1815FF270
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x15FF340 Offset: 0x15FD940 VA: 0x1815FF340
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x15FF630 Offset: 0x15FDC30 VA: 0x1815FF630
	private static long ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0x15FF4C0 Offset: 0x15FDAC0 VA: 0x1815FF4C0
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x15FE810 Offset: 0x15FCE10 VA: 0x1815FE810
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x15FE8D0 Offset: 0x15FCED0 VA: 0x1815FE8D0
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0x15FE920 Offset: 0x15FCF20 VA: 0x1815FE920
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0x1601280 Offset: 0x15FF880 VA: 0x181601280
	private static long UniversalTicksToJavaScriptTicks(long universalTicks) { }

	// RVA: 0x15FEB10 Offset: 0x15FD110 VA: 0x1815FEB10
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	// RVA: 0x15FF830 Offset: 0x15FDE30 VA: 0x1815FF830
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x15FFF00 Offset: 0x15FE500 VA: 0x1815FFF00
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x15FEC20 Offset: 0x15FD220 VA: 0x1815FEC20
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0x1600800 Offset: 0x15FEE00 VA: 0x181600800
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1600A30 Offset: 0x15FF030 VA: 0x181600A30
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1600310 Offset: 0x15FE910 VA: 0x181600310
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x1600520 Offset: 0x15FEB20 VA: 0x181600520
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x1600CF0 Offset: 0x15FF2F0 VA: 0x181600CF0
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	// RVA: 0x15FFCF0 Offset: 0x15FE2F0 VA: 0x1815FFCF0
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x15FF740 Offset: 0x15FDD40 VA: 0x1815FF740
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1600190 Offset: 0x15FE790 VA: 0x181600190
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x15FFE50 Offset: 0x15FE450 VA: 0x1815FFE50
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x1600FB0 Offset: 0x15FF5B0 VA: 0x181600FB0
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	// RVA: 0x1601730 Offset: 0x15FFD30 VA: 0x181601730
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x16018D0 Offset: 0x15FFED0 VA: 0x1816018D0
	internal static int WriteDateTimeString(char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0x1601CC0 Offset: 0x16002C0 VA: 0x181601CC0
	internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) { }

	// RVA: 0x15FEB90 Offset: 0x15FD190 VA: 0x1815FEB90
	private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) { }

	// RVA: 0x16014E0 Offset: 0x15FFAE0 VA: 0x1816014E0
	internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0x16012F0 Offset: 0x15FF8F0 VA: 0x1816012F0
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x15FF030 Offset: 0x15FD630 VA: 0x1815FF030
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 8272
{
	// Properties
	[Nullable(1)]
	public abstract object UnderlyingDictionary { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingDictionary();
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection // TypeDefIndex: 8275
{
	// Fields
	[Nullable(2)]
	private readonly IDictionary _dictionary; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private readonly IDictionary<TKey, TValue> _genericDictionary; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private readonly IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary; // 0x0
	[Nullable(2)]
	private object _syncRoot; // 0x0

	// Properties
	internal IDictionary<TKey, TValue> GenericDictionary { get; }
	public ICollection<TKey> Keys { get; }
	public ICollection<TValue> Values { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object UnderlyingDictionary { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41E70 Offset: 0xD40470 VA: 0x180D41E70
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41F50 Offset: 0xD40550 VA: 0x180D41F50
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IReadOnlyDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41EE0 Offset: 0xD404E0 VA: 0x180D41EE0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IDictionary<TKey, TValue> get_GenericDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_GenericDictionary
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3F0E0 Offset: 0xD3D6E0 VA: 0x180D3F0E0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3F730 Offset: 0xD3DD30 VA: 0x180D3F730
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD42450 Offset: 0xD40A50 VA: 0x180D42450
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD408D0 Offset: 0xD3EED0 VA: 0x180D408D0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41AC0 Offset: 0xD400C0 VA: 0x180D41AC0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD42610 Offset: 0xD40C10 VA: 0x180D42610
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD421A0 Offset: 0xD407A0 VA: 0x180D421A0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD42780 Offset: 0xD40D80 VA: 0x180D42780
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3F380 Offset: 0xD3D980 VA: 0x180D3F380
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3F620 Offset: 0xD3DC20 VA: 0x180D3F620
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3F960 Offset: 0xD3DF60 VA: 0x180D3F960
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3FB70 Offset: 0xD3E170 VA: 0x180D3FB70
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41FC0 Offset: 0xD405C0 VA: 0x180D41FC0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD420B0 Offset: 0xD406B0 VA: 0x180D420B0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD403C0 Offset: 0xD3E9C0 VA: 0x180D403C0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD40110 Offset: 0xD3E710 VA: 0x180D40110
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41A90 Offset: 0xD40090 VA: 0x180D41A90
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD40DE0 Offset: 0xD3F3E0 VA: 0x180D40DE0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD413E0 Offset: 0xD3F9E0 VA: 0x180D413E0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41850 Offset: 0xD3FE50 VA: 0x180D41850
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41200 Offset: 0xD3F800 VA: 0x180D41200
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41020 Offset: 0xD3F620 VA: 0x180D41020
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41370 Offset: 0xD3F970 VA: 0x180D41370
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41630 Offset: 0xD3FC30 VA: 0x180D41630
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public void Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD40720 Offset: 0xD3ED20 VA: 0x180D40720
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD41740 Offset: 0xD3FD40 VA: 0x180D41740
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD40B30 Offset: 0xD3F130 VA: 0x180D40B30
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 36
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD40D20 Offset: 0xD3F320 VA: 0x180D40D20
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD40D70 Offset: 0xD3F370 VA: 0x180D40D70
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public object get_UnderlyingDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD425C0 Offset: 0xD40BC0 VA: 0x180D425C0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_UnderlyingDictionary
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class DynamicProxy<T> // TypeDefIndex: 8276
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public virtual IEnumerable<string> GetDynamicMemberNames(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8F9D0 Offset: 0xE8DFD0 VA: 0x180E8F9D0
	|-DynamicProxy<object>.GetDynamicMemberNames
	|
	|-RVA: 0xE8FA00 Offset: 0xE8E000 VA: 0x180E8FA00
	|-DynamicProxy<__Il2CppFullySharedGenericType>.GetDynamicMemberNames
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8FA30 Offset: 0xE8E030 VA: 0x180E8FA30
	|-DynamicProxy<object>.TryBinaryOperation
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryBinaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual bool TryConvert(T instance, ConvertBinder binder, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8FA50 Offset: 0xE8E050 VA: 0x180E8FA50
	|-DynamicProxy<object>.TryConvert
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryConvert
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8FA30 Offset: 0xE8E030 VA: 0x180E8FA30
	|-DynamicProxy<object>.TryCreateInstance
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryCreateInstance
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-DynamicProxy<object>.TryDeleteIndex
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryDeleteIndex
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-DynamicProxy<object>.TryDeleteMember
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryDeleteMember
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8FA30 Offset: 0xE8E030 VA: 0x180E8FA30
	|-DynamicProxy<object>.TryGetIndex
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryGetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual bool TryGetMember(T instance, GetMemberBinder binder, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8FA50 Offset: 0xE8E050 VA: 0x180E8FA50
	|-DynamicProxy<object>.TryGetMember
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryGetMember
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8FA30 Offset: 0xE8E030 VA: 0x180E8FA30
	|-DynamicProxy<object>.TryInvoke
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8FA30 Offset: 0xE8E030 VA: 0x180E8FA30
	|-DynamicProxy<object>.TryInvokeMember
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryInvokeMember
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-DynamicProxy<object>.TrySetIndex
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TrySetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-DynamicProxy<object>.TrySetMember
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TrySetMember
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8FA50 Offset: 0xE8E050 VA: 0x180E8FA50
	|-DynamicProxy<object>.TryUnaryOperation
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryUnaryOperation
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-DynamicProxy<object>..ctor
	|-DynamicProxy<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject // TypeDefIndex: 8292
{
	// Fields
	private readonly DynamicProxy<T> _proxy; // 0x0

	// Properties
	private static Expression[] NoArgs { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression expression, T value, DynamicProxy<T> proxy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8C570 Offset: 0xE8AB70 VA: 0x180E8C570
	|-DynamicProxyMetaObject<object>..ctor
	|
	|-RVA: 0xE8F840 Offset: 0xE8DE40 VA: 0x180E8F840
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private bool IsOverridden(string method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8C4B0 Offset: 0xE8AAB0 VA: 0x180E8C4B0
	|-DynamicProxyMetaObject<object>.IsOverridden
	|
	|-RVA: 0xE8F780 Offset: 0xE8DD80 VA: 0x180E8F780
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.IsOverridden
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8A190 Offset: 0xE88790 VA: 0x180E8A190
	|-DynamicProxyMetaObject<object>.BindGetMember
	|
	|-RVA: 0xE8D300 Offset: 0xE8B900 VA: 0x180E8D300
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindGetMember
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8AA30 Offset: 0xE89030 VA: 0x180E8AA30
	|-DynamicProxyMetaObject<object>.BindSetMember
	|
	|-RVA: 0xE8DC60 Offset: 0xE8C260 VA: 0x180E8DC60
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindSetMember
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE89E00 Offset: 0xE88400 VA: 0x180E89E00
	|-DynamicProxyMetaObject<object>.BindDeleteMember
	|
	|-RVA: 0xE8CF30 Offset: 0xE8B530 VA: 0x180E8CF30
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindDeleteMember
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE89880 Offset: 0xE87E80 VA: 0x180E89880
	|-DynamicProxyMetaObject<object>.BindConvert
	|
	|-RVA: 0xE8C950 Offset: 0xE8AF50 VA: 0x180E8C950
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindConvert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8A360 Offset: 0xE88960 VA: 0x180E8A360
	|-DynamicProxyMetaObject<object>.BindInvokeMember
	|
	|-RVA: 0xE8D4D0 Offset: 0xE8BAD0 VA: 0x180E8D4D0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindInvokeMember
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE89A50 Offset: 0xE88050 VA: 0x180E89A50
	|-DynamicProxyMetaObject<object>.BindCreateInstance
	|
	|-RVA: 0xE8CB30 Offset: 0xE8B130 VA: 0x180E8CB30
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindCreateInstance
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8A650 Offset: 0xE88C50 VA: 0x180E8A650
	|-DynamicProxyMetaObject<object>.BindInvoke
	|
	|-RVA: 0xE8D840 Offset: 0xE8BE40 VA: 0x180E8D840
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE89610 Offset: 0xE87C10 VA: 0x180E89610
	|-DynamicProxyMetaObject<object>.BindBinaryOperation
	|
	|-RVA: 0xE8C6E0 Offset: 0xE8ACE0 VA: 0x180E8C6E0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindBinaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8AC60 Offset: 0xE89260 VA: 0x180E8AC60
	|-DynamicProxyMetaObject<object>.BindUnaryOperation
	|
	|-RVA: 0xE8DED0 Offset: 0xE8C4D0 VA: 0x180E8DED0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindUnaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE89FA0 Offset: 0xE885A0 VA: 0x180E89FA0
	|-DynamicProxyMetaObject<object>.BindGetIndex
	|
	|-RVA: 0xE8D100 Offset: 0xE8B700 VA: 0x180E8D100
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindGetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8A840 Offset: 0xE88E40 VA: 0x180E8A840
	|-DynamicProxyMetaObject<object>.BindSetIndex
	|
	|-RVA: 0xE8DA40 Offset: 0xE8C040 VA: 0x180E8DA40
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindSetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE89C40 Offset: 0xE88240 VA: 0x180E89C40
	|-DynamicProxyMetaObject<object>.BindDeleteIndex
	|
	|-RVA: 0xE8CD30 Offset: 0xE8B330 VA: 0x180E8CD30
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindDeleteIndex
	*/

	// RVA: -1 Offset: -1
	private static Expression[] get_NoArgs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8C640 Offset: 0xE8AC40 VA: 0x180E8C640
	|-DynamicProxyMetaObject<object>.get_NoArgs
	|
	|-RVA: 0xE8F9A0 Offset: 0xE8DFA0 VA: 0x180E8F9A0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.get_NoArgs
	*/

	// RVA: -1 Offset: -1
	private static IEnumerable<Expression> GetArgs(DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8C110 Offset: 0xE8A710 VA: 0x180E8C110
	|-DynamicProxyMetaObject<object>.GetArgs
	|
	|-RVA: 0xE8F390 Offset: 0xE8D990 VA: 0x180E8F390
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgs
	*/

	// RVA: -1 Offset: -1
	private static Expression[] GetArgArray(DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8BDA0 Offset: 0xE8A3A0 VA: 0x180E8BDA0
	|-DynamicProxyMetaObject<object>.GetArgArray
	|
	|-RVA: 0xE8F220 Offset: 0xE8D820 VA: 0x180E8F220
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgArray
	*/

	// RVA: -1 Offset: -1
	private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8BEF0 Offset: 0xE8A4F0 VA: 0x180E8BEF0
	|-DynamicProxyMetaObject<object>.GetArgArray
	|
	|-RVA: 0xE8EFE0 Offset: 0xE8D5E0 VA: 0x180E8EFE0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgArray
	*/

	// RVA: -1 Offset: -1
	private static ConstantExpression Constant(DynamicMetaObjectBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8BD00 Offset: 0xE8A300 VA: 0x180E8BD00
	|-DynamicProxyMetaObject<object>.Constant
	|
	|-RVA: 0xE8EF40 Offset: 0xE8D540 VA: 0x180E8EF40
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.Constant
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject.Fallback<T> fallback, DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8BC70 Offset: 0xE8A270 VA: 0x180E8BC70
	|-DynamicProxyMetaObject<object>.CallMethodWithResult
	|
	|-RVA: 0xE8EE70 Offset: 0xE8D470 VA: 0x180E8EE70
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodWithResult
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8AE30 Offset: 0xE89430 VA: 0x180E8AE30
	|-DynamicProxyMetaObject<object>.BuildCallMethodWithResult
	|
	|-RVA: 0xE8E0B0 Offset: 0xE8C6B0 VA: 0x180E8E0B0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BuildCallMethodWithResult
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject.Fallback<T> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8B6F0 Offset: 0xE89CF0 VA: 0x180E8B6F0
	|-DynamicProxyMetaObject<object>.CallMethodReturnLast
	|
	|-RVA: 0xE8E920 Offset: 0xE8CF20 VA: 0x180E8E920
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodReturnLast
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, DynamicProxyMetaObject.Fallback<T> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8B3D0 Offset: 0xE899D0 VA: 0x180E8B3D0
	|-DynamicProxyMetaObject<object>.CallMethodNoResult
	|
	|-RVA: 0xE8E630 Offset: 0xE8CC30 VA: 0x180E8E630
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodNoResult
	*/

	// RVA: -1 Offset: -1
	private BindingRestrictions GetRestrictions() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8C3F0 Offset: 0xE8A9F0 VA: 0x180E8C3F0
	|-DynamicProxyMetaObject<object>.GetRestrictions
	|
	|-RVA: 0xE8F6C0 Offset: 0xE8DCC0 VA: 0x180E8F6C0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetRestrictions
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override IEnumerable<string> GetDynamicMemberNames() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8C350 Offset: 0xE8A950 VA: 0x180E8C350
	|-DynamicProxyMetaObject<object>.GetDynamicMemberNames
	|
	|-RVA: 0xE8F5D0 Offset: 0xE8DBD0 VA: 0x180E8F5D0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetDynamicMemberNames
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class DynamicUtils // TypeDefIndex: 8294
{
	// Methods

	[Extension]
	// RVA: 0x1602310 Offset: 0x1600910 VA: 0x181602310
	public static IEnumerable<string> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class NoThrowGetBinderMember : GetMemberBinder // TypeDefIndex: 8295
{
	// Fields
	private readonly GetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0x160B020 Offset: 0x1609620 VA: 0x18160B020
	public void .ctor(GetMemberBinder innerBinder) { }

	// RVA: 0x160AF20 Offset: 0x1609520 VA: 0x18160AF20 Slot: 9
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class NoThrowSetBinderMember : SetMemberBinder // TypeDefIndex: 8296
{
	// Fields
	private readonly SetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0x160B1E0 Offset: 0x16097E0 VA: 0x18160B1E0
	public void .ctor(SetMemberBinder innerBinder) { }

	// RVA: 0x160B070 Offset: 0x1609670 VA: 0x18160B070 Slot: 9
	public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class NoThrowExpressionVisitor : ExpressionVisitor // TypeDefIndex: 8297
{
	// Fields
	internal static readonly object ErrorResult; // 0x0

	// Methods

	// RVA: 0x160AD90 Offset: 0x1609390 VA: 0x18160AD90 Slot: 7
	protected override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x160AEA0 Offset: 0x16094A0 VA: 0x18160AEA0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class EnumInfo // TypeDefIndex: 8298
{
	// Fields
	public readonly bool IsFlags; // 0x10
	public readonly ulong[] Values; // 0x18
	public readonly string[] Names; // 0x20
	public readonly string[] ResolvedNames; // 0x28

	// Methods

	// RVA: 0x1602410 Offset: 0x1600A10 VA: 0x181602410
	public void .ctor(bool isFlags, ulong[] values, string[] names, string[] resolvedNames) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class EnumUtils // TypeDefIndex: 8301
{
	// Fields
	private const char EnumSeparatorChar = '\x2c';
	private const string EnumSeparatorString = ", ";
	[Nullable(new[] { 1, 0, 1, 2, 1 })]
	private static readonly ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum; // 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

	// Methods

	// RVA: 0x1602630 Offset: 0x1600C30 VA: 0x181602630
	private static EnumInfo InitializeValuesAndNames(StructMultiKey<Type, NamingStrategy> key) { }

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public static IList<T> GetFlagsValues<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DA700 Offset: 0x6D8D00 VA: 0x1806DA700
	|-EnumUtils.GetFlagsValues<Int32Enum>
	|
	|-RVA: 0x6DA100 Offset: 0x6D8700 VA: 0x1806DA100
	|-EnumUtils.GetFlagsValues<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x1603AC0 Offset: 0x16020C0 VA: 0x181603AC0
	public static bool TryToString(Type enumType, object value, bool camelCase, out string name) { }

	// RVA: 0x1603910 Offset: 0x1601F10 VA: 0x181603910
	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, out string name) { }

	// RVA: 0x1602B30 Offset: 0x1601130 VA: 0x181602B30
	private static string InternalFlagsFormat(EnumInfo entry, ulong result) { }

	// RVA: 0x1602570 Offset: 0x1600B70 VA: 0x181602570
	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	// RVA: 0x1603600 Offset: 0x1601C00 VA: 0x181603600
	private static ulong ToUInt64(object value) { }

	// RVA: 0x1602DB0 Offset: 0x16013B0 VA: 0x181602DB0
	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	// RVA: 0x1602CD0 Offset: 0x16012D0 VA: 0x181602CD0
	private static Nullable<int> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0x1602480 Offset: 0x1600A80 VA: 0x181602480
	private static Nullable<int> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0x1603CD0 Offset: 0x16022D0 VA: 0x181603CD0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class ExpressionReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 8304
{
	// Fields
	private static readonly ExpressionReflectionDelegateFactory _instance; // 0x0

	// Properties
	internal static ReflectionDelegateFactory Instance { get; }

	// Methods

	// RVA: 0x1604D30 Offset: 0x1603330 VA: 0x181604D30
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0x1604760 Offset: 0x1602D60 VA: 0x181604760 Slot: 5
	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FDE70 Offset: 0x6FC470 VA: 0x1806FDE70
	|-ExpressionReflectionDelegateFactory.CreateMethodCall<object>
	|-ExpressionReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1603DF0 Offset: 0x16023F0 VA: 0x181603DF0
	private Expression BuildMethodCall(MethodBase method, Type type, ParameterExpression targetParameterExpression, ParameterExpression argsParameterExpression) { }

	// RVA: -1 Offset: -1 Slot: 6
	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FD400 Offset: 0x6FBA00 VA: 0x1806FD400
	|-ExpressionReflectionDelegateFactory.CreateDefaultConstructor<object>
	|
	|-RVA: 0x6FD190 Offset: 0x6FB790 VA: 0x1806FD190
	|-ExpressionReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FD670 Offset: 0x6FBC70 VA: 0x1806FD670
	|-ExpressionReflectionDelegateFactory.CreateGet<object>
	|-ExpressionReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FDC10 Offset: 0x6FC210 VA: 0x1806FDC10
	|-ExpressionReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x6FD9A0 Offset: 0x6FBFA0 VA: 0x1806FD9A0
	|-ExpressionReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FE600 Offset: 0x6FCC00 VA: 0x1806FE600
	|-ExpressionReflectionDelegateFactory.CreateSet<object>
	|-ExpressionReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FE0F0 Offset: 0x6FC6F0 VA: 0x1806FE0F0
	|-ExpressionReflectionDelegateFactory.CreateSet<object>
	|-ExpressionReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1604970 Offset: 0x1602F70 VA: 0x181604970
	private Expression EnsureCastExpression(Expression expression, Type targetType, bool allowWidening = False) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1604CC0 Offset: 0x16032C0 VA: 0x181604CC0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal class FSharpFunction // TypeDefIndex: 8305
{
	// Fields
	private readonly object _instance; // 0x10
	[Nullable(new[] { 1, 2, 1 })]
	private readonly MethodCall<object, object> _invoker; // 0x18

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(object instance, MethodCall<object, object> invoker) { }

	[NullableContext(1)]
	// RVA: 0x1604D80 Offset: 0x1603380 VA: 0x181604D80
	public object Invoke(object[] args) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class FSharpUtils // TypeDefIndex: 8309
{
	// Fields
	private static readonly object Lock; // 0x0
	[Nullable(2)]
	private static FSharpUtils _instance; // 0x8
	private MethodInfo _ofSeq; // 0x10
	private Type _mapType; // 0x18
	[CompilerGenerated]
	private Assembly <FSharpCoreAssembly>k__BackingField; // 0x20
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <IsUnion>k__BackingField; // 0x28
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <GetUnionCases>k__BackingField; // 0x30
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionTagReader>k__BackingField; // 0x38
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionReader>k__BackingField; // 0x40
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionConstructor>k__BackingField; // 0x48
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoDeclaringType>k__BackingField; // 0x50
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoName>k__BackingField; // 0x58
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoTag>k__BackingField; // 0x60
	[Nullable(new[] { 1, 1, 2 })]
	[CompilerGenerated]
	private MethodCall<object, object> <GetUnionCaseInfoFields>k__BackingField; // 0x68
	public const string FSharpSetTypeName = "FSharpSet`1";
	public const string FSharpListTypeName = "FSharpList`1";
	public const string FSharpMapTypeName = "FSharpMap`2";

	// Properties
	public static FSharpUtils Instance { get; }
	public Assembly FSharpCoreAssembly { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> IsUnion { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> GetUnionCases { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionTagReader { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionReader { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionConstructor { get; set; }
	public Func<object, object> GetUnionCaseInfoDeclaringType { get; set; }
	public Func<object, object> GetUnionCaseInfoName { get; set; }
	public Func<object, object> GetUnionCaseInfoTag { get; set; }
	[Nullable(new[] { 1, 1, 2 })]
	public MethodCall<object, object> GetUnionCaseInfoFields { get; set; }

	// Methods

	// RVA: 0x1605570 Offset: 0x1603B70 VA: 0x181605570
	private void .ctor(Assembly fsharpCoreAssembly) { }

	// RVA: 0x1605B00 Offset: 0x1604100 VA: 0x181605B00
	public static FSharpUtils get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Assembly get_FSharpCoreAssembly() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_FSharpCoreAssembly(Assembly value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public MethodCall<object, object> get_IsUnion() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	private void set_IsUnion(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public MethodCall<object, object> get_GetUnionCases() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_GetUnionCases(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public MethodCall<object, object> get_PreComputeUnionTagReader() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	private void set_PreComputeUnionTagReader(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public MethodCall<object, object> get_PreComputeUnionReader() { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	private void set_PreComputeUnionReader(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public MethodCall<object, object> get_PreComputeUnionConstructor() { }

	[CompilerGenerated]
	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	private void set_PreComputeUnionConstructor(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public Func<object, object> get_GetUnionCaseInfoDeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	private void set_GetUnionCaseInfoDeclaringType(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public Func<object, object> get_GetUnionCaseInfoName() { }

	[CompilerGenerated]
	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	private void set_GetUnionCaseInfoName(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public Func<object, object> get_GetUnionCaseInfoTag() { }

	[CompilerGenerated]
	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	private void set_GetUnionCaseInfoTag(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public MethodCall<object, object> get_GetUnionCaseInfoFields() { }

	[CompilerGenerated]
	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	private void set_GetUnionCaseInfoFields(MethodCall<object, object> value) { }

	// RVA: 0x16052F0 Offset: 0x16038F0 VA: 0x1816052F0
	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	// RVA: 0x1605470 Offset: 0x1603A70 VA: 0x181605470
	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	// RVA: 0x1604DB0 Offset: 0x16033B0 VA: 0x181604DB0
	private static MethodCall<object, object> CreateFSharpFuncCall(Type type, string methodName) { }

	// RVA: 0x16051D0 Offset: 0x16037D0 VA: 0x1816051D0
	public ObjectConstructor<object> CreateSeq(Type t) { }

	// RVA: 0x1604FF0 Offset: 0x16035F0 VA: 0x181604FF0
	public ObjectConstructor<object> CreateMap(Type keyType, Type valueType) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public ObjectConstructor<object> BuildMapCreator<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x701470 Offset: 0x6FFA70 VA: 0x180701470
	|-FSharpUtils.BuildMapCreator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x16054F0 Offset: 0x1603AF0 VA: 0x1816054F0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class ImmutableCollectionsUtils // TypeDefIndex: 8314
{
	// Fields
	private const string ImmutableListGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableList`1";
	private const string ImmutableQueueGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableQueue`1";
	private const string ImmutableStackGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableStack`1";
	private const string ImmutableSetGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableSet`1";
	private const string ImmutableArrayTypeName = "System.Collections.Immutable.ImmutableArray";
	private const string ImmutableArrayGenericTypeName = "System.Collections.Immutable.ImmutableArray`1";
	private const string ImmutableListTypeName = "System.Collections.Immutable.ImmutableList";
	private const string ImmutableListGenericTypeName = "System.Collections.Immutable.ImmutableList`1";
	private const string ImmutableQueueTypeName = "System.Collections.Immutable.ImmutableQueue";
	private const string ImmutableQueueGenericTypeName = "System.Collections.Immutable.ImmutableQueue`1";
	private const string ImmutableStackTypeName = "System.Collections.Immutable.ImmutableStack";
	private const string ImmutableStackGenericTypeName = "System.Collections.Immutable.ImmutableStack`1";
	private const string ImmutableSortedSetTypeName = "System.Collections.Immutable.ImmutableSortedSet";
	private const string ImmutableSortedSetGenericTypeName = "System.Collections.Immutable.ImmutableSortedSet`1";
	private const string ImmutableHashSetTypeName = "System.Collections.Immutable.ImmutableHashSet";
	private const string ImmutableHashSetGenericTypeName = "System.Collections.Immutable.ImmutableHashSet`1";
	private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x0
	private const string ImmutableDictionaryGenericInterfaceTypeName = "System.Collections.Immutable.IImmutableDictionary`2";
	private const string ImmutableDictionaryTypeName = "System.Collections.Immutable.ImmutableDictionary";
	private const string ImmutableDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableDictionary`2";
	private const string ImmutableSortedDictionaryTypeName = "System.Collections.Immutable.ImmutableSortedDictionary";
	private const string ImmutableSortedDictionaryGenericTypeName = "System.Collections.Immutable.ImmutableSortedDictionary`2";
	private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

	// Methods

	// RVA: 0x1605B50 Offset: 0x1604150 VA: 0x181605B50
	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator) { }

	// RVA: 0x1606060 Offset: 0x1604660 VA: 0x181606060
	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator) { }

	// RVA: 0x1606600 Offset: 0x1604C00 VA: 0x181606600
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal static class BufferUtils // TypeDefIndex: 8315
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x15F86C0 Offset: 0x15F6CC0 VA: 0x1815F86C0
	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	// RVA: 0x15F8740 Offset: 0x15F6D40 VA: 0x1815F8740
	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	// RVA: 0x15F8620 Offset: 0x15F6C20 VA: 0x1815F8620
	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class JavaScriptUtils // TypeDefIndex: 8319
{
	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10
	private const int UnicodeTextLength = 6;
	private const string EscapedUnicodeText = "!";

	// Methods

	// RVA: 0x1609160 Offset: 0x1607760 VA: 0x181609160
	private static void .cctor() { }

	// RVA: 0x1607250 Offset: 0x1605850 VA: 0x181607250
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	// RVA: 0x1607320 Offset: 0x1605920 VA: 0x181607320
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	[NullableContext(2)]
	// RVA: 0x1608940 Offset: 0x1606F40 VA: 0x181608940
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) { }

	// RVA: 0x16073B0 Offset: 0x16059B0 VA: 0x1816073B0
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x16071A0 Offset: 0x16057A0 VA: 0x1816071A0
	private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x1607F10 Offset: 0x1606510 VA: 0x181607F10
	public static Task WriteEscapedJavaScriptStringAsync(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x1608300 Offset: 0x1606900 VA: 0x181608300
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13))]
	// RVA: 0x1608180 Offset: 0x1606780 VA: 0x181608180
	private static Task WriteEscapedJavaScriptStringWithDelimitersAsync(Task task, TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JavaScriptUtils.<WriteCharAsync>d__14))]
	// RVA: 0x1607C70 Offset: 0x1606270 VA: 0x181607C70
	public static Task WriteCharAsync(Task task, TextWriter writer, char c, CancellationToken cancellationToken) { }

	// RVA: 0x16086B0 Offset: 0x1606CB0 VA: 0x1816086B0
	private static Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16))]
	// RVA: 0x1607DA0 Offset: 0x16063A0 VA: 0x181607DA0
	private static Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(TextWriter writer, string s, int lastWritePosition, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x16077D0 Offset: 0x1605DD0 VA: 0x1816077D0
	public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage) { }

	// RVA: 0x16075F0 Offset: 0x1605BF0 VA: 0x1816075F0
	private static bool TryGetDateConstructorValue(JsonReader reader, out Nullable<long> integer, out string errorMessage) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal static class JsonTokenUtils // TypeDefIndex: 8320
{
	// Methods

	// RVA: 0x1609BF0 Offset: 0x16081F0 VA: 0x181609BF0
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0x1609C20 Offset: 0x1608220 VA: 0x181609C20
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0x1609C00 Offset: 0x1608200 VA: 0x181609C00
	internal static bool IsPrimitiveToken(JsonToken token) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 8328
{
	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x0

	// Properties
	internal static ReflectionDelegateFactory Instance { get; }

	// Methods

	// RVA: 0x160A060 Offset: 0x1608660 VA: 0x18160A060
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0x1609E60 Offset: 0x1608460 VA: 0x181609E60 Slot: 5
	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x715150 Offset: 0x713750 VA: 0x180715150
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	|
	|-RVA: 0x714F90 Offset: 0x713590 VA: 0x180714F90
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x714A60 Offset: 0x713060 VA: 0x180714A60
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	|
	|-RVA: 0x7148E0 Offset: 0x712EE0 VA: 0x1807148E0
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x714DB0 Offset: 0x7133B0 VA: 0x180714DB0
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x714CC0 Offset: 0x7132C0 VA: 0x180714CC0
	|-LateBoundReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x714EA0 Offset: 0x7134A0 VA: 0x180714EA0
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x714BD0 Offset: 0x7131D0 VA: 0x180714BD0
	|-LateBoundReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x715400 Offset: 0x713A00 VA: 0x180715400
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x714BD0 Offset: 0x7131D0 VA: 0x180714BD0
	|-LateBoundReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x715310 Offset: 0x713910 VA: 0x180715310
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x714CC0 Offset: 0x7132C0 VA: 0x180714CC0
	|-LateBoundReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1609FF0 Offset: 0x16085F0 VA: 0x181609FF0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
internal static class MathUtils // TypeDefIndex: 8329
{
	// Methods

	// RVA: 0x160A180 Offset: 0x1608780 VA: 0x18160A180
	public static int IntLength(ulong i) { }

	// RVA: 0x160A2E0 Offset: 0x16088E0 VA: 0x18160A2E0
	public static char IntToHex(int n) { }

	// RVA: 0x160A4A0 Offset: 0x1608AA0 VA: 0x18160A4A0
	public static Nullable<int> Min(Nullable<int> val1, Nullable<int> val2) { }

	// RVA: 0x160A2F0 Offset: 0x16088F0 VA: 0x18160A2F0
	public static Nullable<int> Max(Nullable<int> val1, Nullable<int> val2) { }

	// RVA: 0x160A3C0 Offset: 0x16089C0 VA: 0x18160A3C0
	public static Nullable<double> Max(Nullable<double> val1, Nullable<double> val2) { }

	// RVA: 0x160A0B0 Offset: 0x16086B0 VA: 0x18160A0B0
	public static bool ApproxEquals(double d1, double d2) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class MethodCall<T, TResult> : MulticastDelegate // TypeDefIndex: 8330
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1018370 Offset: 0x1016970 VA: 0x181018370
	|-MethodCall<object, object>..ctor
	|
	|-RVA: 0xC05EB0 Offset: 0xC044B0 VA: 0x180C05EB0
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4320 Offset: 0x5D2920 VA: 0x1805D4320
	|-MethodCall<object, object>.Invoke
	|
	|-RVA: 0x5976A0 Offset: 0x595CA0 VA: 0x1805976A0
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T target, object[] args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C34C0 Offset: 0x5C1AC0 VA: 0x1805C34C0
	|-MethodCall<object, object>.BeginInvoke
	|
	|-RVA: 0xFFC340 Offset: 0xFFA940 VA: 0x180FFC340
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0
	|-MethodCall<object, object>.EndInvoke
	|
	|-RVA: 0xC05E00 Offset: 0xC04400 VA: 0x180C05E00
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class Creator<T> : MulticastDelegate // TypeDefIndex: 8331
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B9A50 Offset: 0x9B8050 VA: 0x1809B9A50
	|-Creator<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 13
	public virtual T Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0
	|-Creator<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B56D0 Offset: 0x3B3CD0 VA: 0x1803B56D0
	|-Creator<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual T EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC05E00 Offset: 0xC04400 VA: 0x180C05E00
	|-Creator<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class MiscellaneousUtils // TypeDefIndex: 8332
{
	// Methods

	[NullableContext(2)]
	[Conditional("DEBUG")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void Assert(bool condition, string message) { }

	[NullableContext(2)]
	// RVA: 0x160AA20 Offset: 0x1609020 VA: 0x18160AA20
	public static bool ValueEquals(object objA, object objB) { }

	// RVA: 0x160A600 Offset: 0x1608C00 VA: 0x18160A600
	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	// RVA: 0x160A990 Offset: 0x1608F90 VA: 0x18160A990
	public static string ToString(object value) { }

	// RVA: 0x160A570 Offset: 0x1608B70 VA: 0x18160A570
	public static int ByteArrayCompare(byte[] a1, byte[] a2) { }

	// RVA: 0x160A790 Offset: 0x1608D90 VA: 0x18160A790
	public static string GetPrefix(string qualifiedName) { }

	// RVA: 0x160A6E0 Offset: 0x1608CE0 VA: 0x18160A6E0
	public static string GetLocalName(string qualifiedName) { }

	// RVA: 0x160A840 Offset: 0x1608E40 VA: 0x18160A840
	public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName) { }

	// RVA: 0x160A900 Offset: 0x1608F00 VA: 0x18160A900
	internal static RegexOptions GetRegexOptions(string optionsText) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal abstract class ReflectionDelegateFactory // TypeDefIndex: 8333
{
	// Methods

	// RVA: -1 Offset: -1
	public Func<T, object> CreateGet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78FB70 Offset: 0x78E170 VA: 0x18078FB70
	|-ReflectionDelegateFactory.CreateGet<object>
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Action<T, object> CreateSet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78FD70 Offset: 0x78E370 VA: 0x18078FD70
	|-ReflectionDelegateFactory.CreateSet<object>
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateMethodCall<object>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Func<T> CreateDefaultConstructor<T>(Type type);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal class ReflectionMember // TypeDefIndex: 8334
{
	// Fields
	[CompilerGenerated]
	private Type <MemberType>k__BackingField; // 0x10
	[Nullable(new[] { 2, 1, 2 })]
	[CompilerGenerated]
	private Func<object, object> <Getter>k__BackingField; // 0x18
	[Nullable(new[] { 2, 1, 2 })]
	[CompilerGenerated]
	private Action<object, object> <Setter>k__BackingField; // 0x20

	// Properties
	public Type MemberType { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Func<object, object> Getter { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Action<object, object> Setter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_MemberType() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_MemberType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Func<object, object> get_Getter() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Getter(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Action<object, object> get_Setter() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Setter(Action<object, object> value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class ReflectionObject // TypeDefIndex: 8338
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private readonly ObjectConstructor<object> <Creator>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IDictionary<string, ReflectionMember> <Members>k__BackingField; // 0x18

	// Properties
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> Creator { get; }
	public IDictionary<string, ReflectionMember> Members { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ObjectConstructor<object> get_Creator() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public IDictionary<string, ReflectionMember> get_Members() { }

	// RVA: 0x160BCE0 Offset: 0x160A2E0 VA: 0x18160BCE0
	private void .ctor(ObjectConstructor<object> creator) { }

	// RVA: 0x160BBC0 Offset: 0x160A1C0 VA: 0x18160BBC0
	public object GetValue(object target, string member) { }

	// RVA: 0x160BC50 Offset: 0x160A250 VA: 0x18160BC50
	public void SetValue(object target, string member, object value) { }

	// RVA: 0x160BB60 Offset: 0x160A160 VA: 0x18160BB60
	public Type GetType(string member) { }

	// RVA: 0x160B230 Offset: 0x1609830 VA: 0x18160B230
	public static ReflectionObject Create(Type t, string[] memberNames) { }

	// RVA: 0x160B240 Offset: 0x1609840 VA: 0x18160B240
	public static ReflectionObject Create(Type t, MethodBase creator, string[] memberNames) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class ReflectionUtils // TypeDefIndex: 8344
{
	// Fields
	public static readonly Type[] EmptyTypes; // 0x0

	// Methods

	// RVA: 0x1610370 Offset: 0x160E970 VA: 0x181610370
	private static void .cctor() { }

	[Extension]
	// RVA: 0x160FDB0 Offset: 0x160E3B0 VA: 0x18160FDB0
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[Extension]
	// RVA: 0x160C6C0 Offset: 0x160ACC0 VA: 0x18160C6C0
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0x160FD10 Offset: 0x160E310 VA: 0x18160FD10
	public static bool IsPublic(PropertyInfo property) { }

	[NullableContext(2)]
	// RVA: 0x160E920 Offset: 0x160CF20 VA: 0x18160E920
	public static Type GetObjectType(object v) { }

	// RVA: 0x160EC20 Offset: 0x160D220 VA: 0x18160EC20
	public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	// RVA: 0x160DFD0 Offset: 0x160C5D0 VA: 0x18160DFD0
	private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	// RVA: 0x160FEA0 Offset: 0x160E4A0 VA: 0x18160FEA0
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0x160EF00 Offset: 0x160D500 VA: 0x18160EF00
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x160D190 Offset: 0x160B790 VA: 0x18160D190
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0x160D040 Offset: 0x160B640 VA: 0x18160D040
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x160F9E0 Offset: 0x160DFE0 VA: 0x18160F9E0
	public static bool IsNullable(Type t) { }

	// RVA: 0x160F920 Offset: 0x160DF20 VA: 0x18160F920
	public static bool IsNullableType(Type t) { }

	// RVA: 0x160C0E0 Offset: 0x160A6E0 VA: 0x18160C0E0
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0x160C080 Offset: 0x160A680 VA: 0x18160C080
	public static Type EnsureNotByRefType(Type t) { }

	// RVA: 0x160F710 Offset: 0x160DD10 VA: 0x18160F710
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x160F240 Offset: 0x160D840 VA: 0x18160F240
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x160EFD0 Offset: 0x160D5D0 VA: 0x18160EFD0
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	// RVA: 0x160F5A0 Offset: 0x160DBA0 VA: 0x18160F5A0
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0x160F3A0 Offset: 0x160D9A0 VA: 0x18160F3A0
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x160F2B0 Offset: 0x160D8B0 VA: 0x18160F2B0
	private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x160CD90 Offset: 0x160B390 VA: 0x18160CD90
	public static Type GetCollectionItemType(Type type) { }

	[NullableContext(2)]
	// RVA: 0x160D4D0 Offset: 0x160BAD0 VA: 0x18160D4D0
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	// RVA: 0x160E3D0 Offset: 0x160C9D0 VA: 0x18160E3D0
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0x160F610 Offset: 0x160DC10 VA: 0x18160F610
	public static bool IsByRefLikeType(Type type) { }

	// RVA: 0x160F790 Offset: 0x160DD90 VA: 0x18160F790
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0x160E650 Offset: 0x160CC50 VA: 0x18160E650
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0x160FFD0 Offset: 0x160E5D0 VA: 0x18160FFD0
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0x160BD80 Offset: 0x160A380 VA: 0x18160BD80
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0x160BEE0 Offset: 0x160A4E0 VA: 0x18160BEE0
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0x160D7A0 Offset: 0x160BDA0 VA: 0x18160D7A0
	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0x160FA60 Offset: 0x160E060 VA: 0x18160FA60
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x790870 Offset: 0x78EE70 VA: 0x180790870
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x790710 Offset: 0x78ED10 VA: 0x180790710
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] GetAttributes<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7909F0 Offset: 0x78EFF0 VA: 0x1807909F0
	|-ReflectionUtils.GetAttributes<object>
	*/

	// RVA: 0x160C210 Offset: 0x160A810 VA: 0x18160C210
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0x16101F0 Offset: 0x160E7F0 VA: 0x1816101F0
	public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

	// RVA: 0x160C140 Offset: 0x160A740 VA: 0x18160C140
	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0x160E120 Offset: 0x160C720 VA: 0x18160E120
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0x160DEC0 Offset: 0x160C4C0 VA: 0x18160DEC0
	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x160C7B0 Offset: 0x160ADB0 VA: 0x18160C7B0
	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x160E930 Offset: 0x160CF30 VA: 0x18160E930
	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[Extension]
	// RVA: 0x160FFC0 Offset: 0x160E5C0 VA: 0x18160FFC0
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0x160C990 Offset: 0x160AF90 VA: 0x18160C990
	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x160F800 Offset: 0x160DE00 VA: 0x18160F800
	public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	// RVA: 0x160D1E0 Offset: 0x160B7E0 VA: 0x18160D1E0
	public static object GetDefaultValue(Type type) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal struct StringBuffer // TypeDefIndex: 8345
{
	// Fields
	private char[] _buffer; // 0x0
	private int _position; // 0x8

	// Properties
	public int Position { get; set; }
	public bool IsEmpty { get; }
	public char[] InternalBuffer { get; }

	// Methods

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public int get_Position() { }

	// RVA: 0x9714C0 Offset: 0x96FAC0 VA: 0x1809714C0
	public void set_Position(int value) { }

	// RVA: 0x13F37F0 Offset: 0x13F1DF0 VA: 0x1813F37F0
	public bool get_IsEmpty() { }

	// RVA: 0x1631B90 Offset: 0x1630190 VA: 0x181631B90
	public void .ctor(IArrayPool<char> bufferPool, int initalSize) { }

	[NullableContext(1)]
	// RVA: 0x1631BD0 Offset: 0x16301D0 VA: 0x181631BD0
	private void .ctor(char[] buffer) { }

	// RVA: 0x16318E0 Offset: 0x162FEE0 VA: 0x1816318E0
	public void Append(IArrayPool<char> bufferPool, char value) { }

	[NullableContext(1)]
	// RVA: 0x16319A0 Offset: 0x162FFA0 VA: 0x1816319A0
	public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) { }

	// RVA: 0x1631A70 Offset: 0x1630070 VA: 0x181631A70
	public void Clear(IArrayPool<char> bufferPool) { }

	// RVA: 0x1631AC0 Offset: 0x16300C0 VA: 0x181631AC0
	private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) { }

	[NullableContext(1)]
	// RVA: 0x1631B30 Offset: 0x1630130 VA: 0x181631B30 Slot: 3
	public override string ToString() { }

	[NullableContext(1)]
	// RVA: 0x1631B60 Offset: 0x1630160 VA: 0x181631B60
	public string ToString(int start, int length) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public char[] get_InternalBuffer() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[IsReadOnly]
[DefaultMember("Item")]
internal struct StringReference // TypeDefIndex: 8346
{
	// Fields
	private readonly char[] _chars; // 0x0
	private readonly int _startIndex; // 0x8
	private readonly int _length; // 0xC

	// Properties
	public char Item { get; }
	public char[] Chars { get; }
	public int StartIndex { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x1631DD0 Offset: 0x16303D0 VA: 0x181631DD0
	public char get_Item(int i) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public char[] get_Chars() { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public int get_StartIndex() { }

	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public int get_Length() { }

	// RVA: 0xB26490 Offset: 0xB24A90 VA: 0x180B26490
	public void .ctor(char[] chars, int startIndex, int length) { }

	// RVA: 0x1631DA0 Offset: 0x16303A0 VA: 0x181631DA0 Slot: 3
	public override string ToString() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class StringReferenceExtensions // TypeDefIndex: 8347
{
	// Methods

	[Extension]
	// RVA: 0x1631C80 Offset: 0x1630280 VA: 0x181631C80
	public static int IndexOf(StringReference s, char c, int startIndex, int length) { }

	[Extension]
	// RVA: 0x1631D10 Offset: 0x1630310 VA: 0x181631D10
	public static bool StartsWith(StringReference s, string text) { }

	[Extension]
	// RVA: 0x1631BF0 Offset: 0x16301F0 VA: 0x181631BF0
	public static bool EndsWith(StringReference s, string text) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class StringUtils // TypeDefIndex: 8350
{
	// Fields
	public const string CarriageReturnLineFeed = "\r\n";
	public const string Empty = "";
	public const char CarriageReturn = '\xd';
	public const char LineFeed = '\xa';
	public const char Tab = '\x9';

	// Methods

	[NullableContext(2)]
	// RVA: 0x16326E0 Offset: 0x1630CE0 VA: 0x1816326E0
	public static bool IsNullOrEmpty(string value) { }

	[Extension]
	// RVA: 0x16323C0 Offset: 0x16309C0 VA: 0x1816323C0
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[Extension]
	// RVA: 0x16324F0 Offset: 0x1630AF0 VA: 0x1816324F0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[Extension]
	// RVA: 0x16321E0 Offset: 0x16307E0 VA: 0x1816321E0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[NullableContext(2)]
	[Extension]
	// RVA: 0x1631FB0 Offset: 0x16305B0 VA: 0x181631FB0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[Extension]
	// RVA: 0x1631F00 Offset: 0x1630500 VA: 0x181631F00
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0x16326F0 Offset: 0x1630CF0 VA: 0x1816326F0
	public static bool IsWhiteSpace(string s) { }

	// RVA: 0x1631E00 Offset: 0x1630400 VA: 0x181631E00
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0x16329D0 Offset: 0x1630FD0 VA: 0x1816329D0
	public static void ToCharAsUnicode(char c, char[] buffer) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B8C50 Offset: 0x7B7250 VA: 0x1807B8C50
	|-StringUtils.ForgivingCaseSensitiveFind<object>
	|
	|-RVA: 0x7B89C0 Offset: 0x7B6FC0 VA: 0x1807B89C0
	|-StringUtils.ForgivingCaseSensitiveFind<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1632800 Offset: 0x1630E00 VA: 0x181632800
	public static string ToCamelCase(string s) { }

	// RVA: 0x1632A90 Offset: 0x1631090 VA: 0x181632A90
	private static char ToLower(char c) { }

	// RVA: 0x1632DE0 Offset: 0x16313E0 VA: 0x181632DE0
	public static string ToSnakeCase(string s) { }

	// RVA: 0x1632A80 Offset: 0x1631080 VA: 0x181632A80
	public static string ToKebabCase(string s) { }

	// RVA: 0x1632B10 Offset: 0x1631110 VA: 0x181632B10
	private static string ToSeparatedCase(string s, char separator) { }

	// RVA: 0x1632680 Offset: 0x1630C80 VA: 0x181632680
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x16326B0 Offset: 0x1630CB0 VA: 0x1816326B0
	public static bool IsLowSurrogate(char c) { }

	[Extension]
	// RVA: 0x16327C0 Offset: 0x1630DC0 VA: 0x1816327C0
	public static bool StartsWith(string source, char value) { }

	[Extension]
	// RVA: 0x1631EC0 Offset: 0x16304C0 VA: 0x181631EC0
	public static bool EndsWith(string source, char value) { }

	[Extension]
	// RVA: 0x1632DF0 Offset: 0x16313F0 VA: 0x181632DF0
	public static string Trim(string s, int start, int length) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[IsReadOnly]
internal struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>> // TypeDefIndex: 8351
{
	// Fields
	public readonly T1 Value1; // 0x0
	public readonly T2 Value2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 v1, T2 v2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x598200 Offset: 0x596800 VA: 0x180598200
	|-StructMultiKey<object, object>..ctor
	|
	|-RVA: 0x9BB990 Offset: 0x9B9F90 VA: 0x1809BB990
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9BB3B0 Offset: 0x9B99B0 VA: 0x1809BB3B0
	|-StructMultiKey<object, object>.GetHashCode
	|
	|-RVA: 0x9BB420 Offset: 0x9B9A20 VA: 0x1809BB420
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9BB290 Offset: 0x9B9890 VA: 0x1809BB290
	|-StructMultiKey<object, object>.Equals
	|
	|-RVA: 0x9BAD60 Offset: 0x9B9360 VA: 0x1809BAD60
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(StructMultiKey<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9BAD10 Offset: 0x9B9310 VA: 0x1809BAD10
	|-StructMultiKey<object, object>.Equals
	|
	|-RVA: 0x9BAF40 Offset: 0x9B9540 VA: 0x1809BAF40
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class ThreadSafeStore<TKey, TValue> // TypeDefIndex: 8352
{
	// Fields
	private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore; // 0x0
	private readonly Func<TKey, TValue> _creator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<TKey, TValue> creator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4AD40 Offset: 0xA49340 VA: 0x180A4AD40
	|-ThreadSafeStore<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0xA4AE10 Offset: 0xA49410 VA: 0x180A4AE10
	|-ThreadSafeStore<object, object>..ctor
	|
	|-RVA: 0xA4AC70 Offset: 0xA49270 VA: 0x180A4AC70
	|-ThreadSafeStore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue Get(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4AC30 Offset: 0xA49230 VA: 0x180A4AC30
	|-ThreadSafeStore<StructMultiKey<object, object>, object>.Get
	|
	|-RVA: 0xA4AAA0 Offset: 0xA490A0 VA: 0x180A4AAA0
	|-ThreadSafeStore<object, object>.Get
	|
	|-RVA: 0xA4AAE0 Offset: 0xA490E0 VA: 0x180A4AAE0
	|-ThreadSafeStore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class TypeExtensions // TypeDefIndex: 8353
{
	// Methods

	[Extension]
	// RVA: 0x1633640 Offset: 0x1631C40 VA: 0x181633640
	public static MethodInfo Method(Delegate d) { }

	[Extension]
	// RVA: 0x1633610 Offset: 0x1631C10 VA: 0x181633610
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x1633210 Offset: 0x1631810 VA: 0x181633210
	public static bool ContainsGenericParameters(Type type) { }

	[Extension]
	// RVA: 0x1633570 Offset: 0x1631B70 VA: 0x181633570
	public static bool IsInterface(Type type) { }

	[Extension]
	// RVA: 0x1633540 Offset: 0x1631B40 VA: 0x181633540
	public static bool IsGenericType(Type type) { }

	[Extension]
	// RVA: 0x1633510 Offset: 0x1631B10 VA: 0x181633510
	public static bool IsGenericTypeDefinition(Type type) { }

	[Extension]
	// RVA: 0x16331E0 Offset: 0x16317E0 VA: 0x1816331E0
	public static Type BaseType(Type type) { }

	[Extension]
	// RVA: 0x1633000 Offset: 0x1631600 VA: 0x181633000
	public static Assembly Assembly(Type type) { }

	[Extension]
	// RVA: 0x16334E0 Offset: 0x1631AE0 VA: 0x1816334E0
	public static bool IsEnum(Type type) { }

	[Extension]
	// RVA: 0x16334C0 Offset: 0x1631AC0 VA: 0x1816334C0
	public static bool IsClass(Type type) { }

	[Extension]
	// RVA: 0x16335B0 Offset: 0x1631BB0 VA: 0x1816335B0
	public static bool IsSealed(Type type) { }

	[Extension]
	// RVA: 0x16334A0 Offset: 0x1631AA0 VA: 0x1816334A0
	public static bool IsAbstract(Type type) { }

	[Extension]
	// RVA: 0x16335F0 Offset: 0x1631BF0 VA: 0x1816335F0
	public static bool IsVisible(Type type) { }

	[Extension]
	// RVA: 0x16335D0 Offset: 0x1631BD0 VA: 0x1816335D0
	public static bool IsValueType(Type type) { }

	[Extension]
	// RVA: 0x1633590 Offset: 0x1631B90 VA: 0x181633590
	public static bool IsPrimitive(Type type) { }

	[Extension]
	// RVA: 0x1633050 Offset: 0x1631650 VA: 0x181633050
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match) { }

	[Extension]
	// RVA: 0x1633030 Offset: 0x1631630 VA: 0x181633030
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	[Extension]
	// RVA: 0x1633240 Offset: 0x1631840 VA: 0x181633240
	public static bool ImplementInterface(Type type, Type interfaceType) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal static class ValidationUtils // TypeDefIndex: 8354
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1634A90 Offset: 0x1633090 VA: 0x181634A90
	public static void ArgumentNotNull(object value, string parameterName) { }
}

