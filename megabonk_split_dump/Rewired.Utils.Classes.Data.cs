// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class ADictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue> // TypeDefIndex: 2977
{
	// Fields
	private int[] tzsmzqlxeIMEGmDTjDLHEqhOdojo; // 0x0
	internal ADictionary.Entry<TKey, TValue>[] _entries; // 0x0
	internal int _count; // 0x0
	private int nJqDNHJPqyuDHBuxoAuienGdqoITB; // 0x0
	private int yhjaXTtQhoVhHFmazKWtqbxHfTxbA; // 0x0
	private int qFShiOKrWwjfGufnfcPCbKxHDwLs; // 0x0
	private int oAHfUJzUlLaUlqPnjlGIrHRnxFNe; // 0x0
	private IEqualityComparer<TKey> zNdGmPXIxjhAvBNcxEdhgOUJzLjcA; // 0x0
	private IEqualityComparer<TValue> LyyERbigFbhuWMPUDBfihAPgPEQMB; // 0x0
	private ADictionary.KeyCollection<TKey, TValue> FyDivcqgNUUQVMgIyPmBzKbtVnsJ; // 0x0
	private ADictionary.ValueCollection<TKey, TValue> WEMPYfDLlvJgLjaYYfSBIIPQvieG; // 0x0
	private readonly object RuvDbEOSuUJUHIqdjGKjQwjliEE; // 0x0
	private static readonly bool HDeFDnsmEIeiVQgZVEesAsgelhos; // 0x0
	private static readonly bool nbvCWXXnHCfquXGqELtmAAkOkFdQ; // 0x0
	private const string AxUmKzgZRGvsLITrosHIbWROVBkb = "Version";
	private const string EpznQgZTKKhPtgKQjcurjHIFCJmP = "HashSize";
	private const string FqAXoCHracvFfuJTpCPsGjbYWhwg = "KeyValuePairs";
	private const string luNfyAaZtQbJWLmuHhVddxdFFmFu = "Comparer";

	// Properties
	public int Count { get; }
	public int TotalCount { get; }
	public ADictionary.KeyCollection<TKey, TValue> Keys { get; }
	public ADictionary.ValueCollection<TKey, TValue> Values { get; }
	public IEqualityComparer<TKey> KeyComparer { get; set; }
	public IEqualityComparer<TValue> ValueComparer { get; set; }
	public TValue Item { get; set; }
	public int IndexOfFirst { get; }
	public int IndexOfLast { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection<TKey> Rewired.Utils.Interfaces.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	private ICollection<TValue> Rewired.Utils.Interfaces.IReadOnlyDictionary<TKey,TValue>.Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 33
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD07760 Offset: 0xD05D60 VA: 0x180D07760
	|-ADictionary<Bytes20, int>.get_Count
	|-ADictionary<Guid, object>.get_Count
	|-ADictionary<int, int>.get_Count
	|-ADictionary<int, object>.get_Count
	|-ADictionary<object, int>.get_Count
	|-ADictionary<object, Int32Enum>.get_Count
	|-ADictionary<object, object>.get_Count
	|-ADictionary<uint, int>.get_Count
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_TotalCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-ADictionary<Bytes20, int>.get_TotalCount
	|-ADictionary<Guid, object>.get_TotalCount
	|-ADictionary<int, int>.get_TotalCount
	|-ADictionary<int, object>.get_TotalCount
	|-ADictionary<object, int>.get_TotalCount
	|-ADictionary<object, Int32Enum>.get_TotalCount
	|-ADictionary<object, object>.get_TotalCount
	|-ADictionary<uint, int>.get_TotalCount
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_TotalCount
	*/

	// RVA: -1 Offset: -1
	public ADictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7A10 Offset: 0xCF6010 VA: 0x180CF7A10
	|-ADictionary<Bytes20, int>.get_Keys
	|-ADictionary<Guid, object>.get_Keys
	|-ADictionary<int, int>.get_Keys
	|-ADictionary<int, object>.get_Keys
	|-ADictionary<object, int>.get_Keys
	|-ADictionary<object, Int32Enum>.get_Keys
	|-ADictionary<object, object>.get_Keys
	|-ADictionary<uint, int>.get_Keys
	|
	|-RVA: 0xDE09D0 Offset: 0xDDEFD0 VA: 0x180DE09D0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public ADictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFC4C0 Offset: 0xCFAAC0 VA: 0x180CFC4C0
	|-ADictionary<Bytes20, int>.get_Values
	|-ADictionary<Guid, object>.get_Values
	|-ADictionary<int, int>.get_Values
	|-ADictionary<int, object>.get_Values
	|-ADictionary<object, int>.get_Values
	|-ADictionary<object, Int32Enum>.get_Values
	|-ADictionary<object, object>.get_Values
	|-ADictionary<uint, int>.get_Values
	|
	|-RVA: 0xDE3A30 Offset: 0xDE2030 VA: 0x180DE3A30
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<TKey> get_KeyComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	|-ADictionary<Bytes20, int>.get_KeyComparer
	|-ADictionary<Guid, object>.get_KeyComparer
	|-ADictionary<int, int>.get_KeyComparer
	|-ADictionary<int, object>.get_KeyComparer
	|-ADictionary<object, int>.get_KeyComparer
	|-ADictionary<object, Int32Enum>.get_KeyComparer
	|-ADictionary<object, object>.get_KeyComparer
	|-ADictionary<uint, int>.get_KeyComparer
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_KeyComparer
	*/

	// RVA: -1 Offset: -1
	public void set_KeyComparer(IEqualityComparer<TKey> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD08080 Offset: 0xD06680 VA: 0x180D08080
	|-ADictionary<Bytes20, int>.set_KeyComparer
	|
	|-RVA: 0xD08100 Offset: 0xD06700 VA: 0x180D08100
	|-ADictionary<Guid, object>.set_KeyComparer
	|
	|-RVA: 0xD080C0 Offset: 0xD066C0 VA: 0x180D080C0
	|-ADictionary<int, int>.set_KeyComparer
	|-ADictionary<int, object>.set_KeyComparer
	|
	|-RVA: 0xD08040 Offset: 0xD06640 VA: 0x180D08040
	|-ADictionary<object, int>.set_KeyComparer
	|-ADictionary<object, Int32Enum>.set_KeyComparer
	|-ADictionary<object, object>.set_KeyComparer
	|
	|-RVA: 0xDEC780 Offset: 0xDEAD80 VA: 0x180DEC780
	|-ADictionary<uint, int>.set_KeyComparer
	|
	|-RVA: 0xDEC7C0 Offset: 0xDEADC0 VA: 0x180DEC7C0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_KeyComparer
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<TValue> get_ValueComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	|-ADictionary<Bytes20, int>.get_ValueComparer
	|-ADictionary<Guid, object>.get_ValueComparer
	|-ADictionary<int, int>.get_ValueComparer
	|-ADictionary<int, object>.get_ValueComparer
	|-ADictionary<object, int>.get_ValueComparer
	|-ADictionary<object, Int32Enum>.get_ValueComparer
	|-ADictionary<object, object>.get_ValueComparer
	|-ADictionary<uint, int>.get_ValueComparer
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ValueComparer
	*/

	// RVA: -1 Offset: -1
	public void set_ValueComparer(IEqualityComparer<TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD08180 Offset: 0xD06780 VA: 0x180D08180
	|-ADictionary<Bytes20, int>.set_ValueComparer
	|-ADictionary<int, int>.set_ValueComparer
	|-ADictionary<object, int>.set_ValueComparer
	|-ADictionary<uint, int>.set_ValueComparer
	|
	|-RVA: 0xD08140 Offset: 0xD06740 VA: 0x180D08140
	|-ADictionary<Guid, object>.set_ValueComparer
	|-ADictionary<int, object>.set_ValueComparer
	|-ADictionary<object, object>.set_ValueComparer
	|
	|-RVA: 0xDEC810 Offset: 0xDEAE10 VA: 0x180DEC810
	|-ADictionary<object, Int32Enum>.set_ValueComparer
	|
	|-RVA: 0xDEC850 Offset: 0xDEAE50 VA: 0x180DEC850
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_ValueComparer
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD079F0 Offset: 0xD05FF0 VA: 0x180D079F0
	|-ADictionary<Bytes20, int>.get_Item
	|
	|-RVA: 0xD07E20 Offset: 0xD06420 VA: 0x180D07E20
	|-ADictionary<Guid, object>.get_Item
	|
	|-RVA: 0xD07B20 Offset: 0xD06120 VA: 0x180D07B20
	|-ADictionary<int, int>.get_Item
	|
	|-RVA: 0xD07D20 Offset: 0xD06320 VA: 0x180D07D20
	|-ADictionary<int, object>.get_Item
	|
	|-RVA: 0xD07C20 Offset: 0xD06220 VA: 0x180D07C20
	|-ADictionary<object, int>.get_Item
	|-ADictionary<object, Int32Enum>.get_Item
	|
	|-RVA: 0xDEBFE0 Offset: 0xDEA5E0 VA: 0x180DEBFE0
	|-ADictionary<object, object>.get_Item
	|
	|-RVA: 0xDEC450 Offset: 0xDEAA50 VA: 0x180DEC450
	|-ADictionary<uint, int>.get_Item
	|
	|-RVA: 0xDEC0E0 Offset: 0xDEA6E0 VA: 0x180DEC0E0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD07FA0 Offset: 0xD065A0 VA: 0x180D07FA0
	|-ADictionary<Bytes20, int>.set_Item
	|
	|-RVA: 0xD07F60 Offset: 0xD06560 VA: 0x180D07F60
	|-ADictionary<Guid, object>.set_Item
	|
	|-RVA: 0xD07F30 Offset: 0xD06530 VA: 0x180D07F30
	|-ADictionary<int, int>.set_Item
	|
	|-RVA: 0xD07FE0 Offset: 0xD065E0 VA: 0x180D07FE0
	|-ADictionary<int, object>.set_Item
	|
	|-RVA: 0xD08010 Offset: 0xD06610 VA: 0x180D08010
	|-ADictionary<object, int>.set_Item
	|
	|-RVA: 0xDEC580 Offset: 0xDEAB80 VA: 0x180DEC580
	|-ADictionary<object, Int32Enum>.set_Item
	|
	|-RVA: 0xDEC550 Offset: 0xDEAB50 VA: 0x180DEC550
	|-ADictionary<object, object>.set_Item
	|
	|-RVA: 0xDEC5B0 Offset: 0xDEABB0 VA: 0x180DEC5B0
	|-ADictionary<uint, int>.set_Item
	|
	|-RVA: 0xDEC5E0 Offset: 0xDEABE0 VA: 0x180DEC5E0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD056B0 Offset: 0xD03CB0 VA: 0x180D056B0
	|-ADictionary<Bytes20, int>..ctor
	|
	|-RVA: 0xD063E0 Offset: 0xD049E0 VA: 0x180D063E0
	|-ADictionary<Guid, object>..ctor
	|
	|-RVA: 0xD06210 Offset: 0xD04810 VA: 0x180D06210
	|-ADictionary<int, int>..ctor
	|
	|-RVA: 0xD062E0 Offset: 0xD048E0 VA: 0x180D062E0
	|-ADictionary<int, object>..ctor
	|
	|-RVA: 0xD05280 Offset: 0xD03880 VA: 0x180D05280
	|-ADictionary<object, int>..ctor
	|
	|-RVA: 0xDEAD40 Offset: 0xDE9340 VA: 0x180DEAD40
	|-ADictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0xDEA2E0 Offset: 0xDE88E0 VA: 0x180DEA2E0
	|-ADictionary<object, object>..ctor
	|
	|-RVA: 0xDEA3B0 Offset: 0xDE89B0 VA: 0x180DEA3B0
	|-ADictionary<uint, int>..ctor
	|
	|-RVA: 0xDEB430 Offset: 0xDE9A30 VA: 0x180DEB430
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD073B0 Offset: 0xD059B0 VA: 0x180D073B0
	|-ADictionary<Bytes20, int>..ctor
	|
	|-RVA: 0xD05BB0 Offset: 0xD041B0 VA: 0x180D05BB0
	|-ADictionary<Guid, object>..ctor
	|
	|-RVA: 0xD06A60 Offset: 0xD05060 VA: 0x180D06A60
	|-ADictionary<int, int>..ctor
	|
	|-RVA: 0xD05780 Offset: 0xD03D80 VA: 0x180D05780
	|-ADictionary<int, object>..ctor
	|
	|-RVA: 0xD05C90 Offset: 0xD04290 VA: 0x180D05C90
	|-ADictionary<object, int>..ctor
	|
	|-RVA: 0xDEA020 Offset: 0xDE8620 VA: 0x180DEA020
	|-ADictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0xDEA780 Offset: 0xDE8D80 VA: 0x180DEA780
	|-ADictionary<object, object>..ctor
	|
	|-RVA: 0xDEA200 Offset: 0xDE8800 VA: 0x180DEA200
	|-ADictionary<uint, int>..ctor
	|
	|-RVA: 0xDEAAC0 Offset: 0xDE90C0 VA: 0x180DEAAC0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> , IEqualityComparer<TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD05D70 Offset: 0xD04370 VA: 0x180D05D70
	|-ADictionary<Bytes20, int>..ctor
	|
	|-RVA: 0xD06670 Offset: 0xD04C70 VA: 0x180D06670
	|-ADictionary<Guid, object>..ctor
	|
	|-RVA: 0xD074C0 Offset: 0xD05AC0 VA: 0x180D074C0
	|-ADictionary<int, int>..ctor
	|
	|-RVA: 0xD06F40 Offset: 0xD05540 VA: 0x180D06F40
	|-ADictionary<int, object>..ctor
	|
	|-RVA: 0xD06E40 Offset: 0xD05440 VA: 0x180D06E40
	|-ADictionary<object, int>..ctor
	|
	|-RVA: 0xDEA100 Offset: 0xDE8700 VA: 0x180DEA100
	|-ADictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0xDEA860 Offset: 0xDE8E60 VA: 0x180DEA860
	|-ADictionary<object, object>..ctor
	|
	|-RVA: 0xDEAE10 Offset: 0xDE9410 VA: 0x180DEAE10
	|-ADictionary<uint, int>..ctor
	|
	|-RVA: 0xDEACE0 Offset: 0xDE92E0 VA: 0x180DEACE0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD075F0 Offset: 0xD05BF0 VA: 0x180D075F0
	|-ADictionary<Bytes20, int>..ctor
	|
	|-RVA: 0xD07040 Offset: 0xD05640 VA: 0x180D07040
	|-ADictionary<Guid, object>..ctor
	|
	|-RVA: 0xD05EA0 Offset: 0xD044A0 VA: 0x180D05EA0
	|-ADictionary<int, int>..ctor
	|
	|-RVA: 0xD063B0 Offset: 0xD049B0 VA: 0x180D063B0
	|-ADictionary<int, object>..ctor
	|
	|-RVA: 0xD05380 Offset: 0xD03980 VA: 0x180D05380
	|-ADictionary<object, int>..ctor
	|
	|-RVA: 0xDEAC80 Offset: 0xDE9280 VA: 0x180DEAC80
	|-ADictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0xDEB3D0 Offset: 0xDE99D0 VA: 0x180DEB3D0
	|-ADictionary<object, object>..ctor
	|
	|-RVA: 0xDEBDD0 Offset: 0xDEA3D0 VA: 0x180DEBDD0
	|-ADictionary<uint, int>..ctor
	|
	|-RVA: 0xDEB460 Offset: 0xDE9A60 VA: 0x180DEB460
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int , IEqualityComparer<TKey> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD05860 Offset: 0xD03E60 VA: 0x180D05860
	|-ADictionary<Bytes20, int>..ctor
	|
	|-RVA: 0xD05ED0 Offset: 0xD044D0 VA: 0x180D05ED0
	|-ADictionary<Guid, object>..ctor
	|
	|-RVA: 0xD053B0 Offset: 0xD039B0 VA: 0x180D053B0
	|-ADictionary<int, int>..ctor
	|
	|-RVA: 0xD05350 Offset: 0xD03950 VA: 0x180D05350
	|-ADictionary<int, object>..ctor
	|
	|-RVA: 0xD05890 Offset: 0xD03E90 VA: 0x180D05890
	|-ADictionary<object, int>..ctor
	|
	|-RVA: 0xDEAAF0 Offset: 0xDE90F0 VA: 0x180DEAAF0
	|-ADictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0xDEBE00 Offset: 0xDEA400 VA: 0x180DEBE00
	|-ADictionary<object, object>..ctor
	|
	|-RVA: 0xDEBA90 Offset: 0xDEA090 VA: 0x180DEBA90
	|-ADictionary<uint, int>..ctor
	|
	|-RVA: 0xDEB400 Offset: 0xDE9A00 VA: 0x180DEB400
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int , IEqualityComparer<TKey> , IEqualityComparer<TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD058C0 Offset: 0xD03EC0 VA: 0x180D058C0
	|-ADictionary<Bytes20, int>..ctor
	|
	|-RVA: 0xD064E0 Offset: 0xD04AE0 VA: 0x180D064E0
	|-ADictionary<Guid, object>..ctor
	|
	|-RVA: 0xD06770 Offset: 0xD04D70 VA: 0x180D06770
	|-ADictionary<int, int>..ctor
	|
	|-RVA: 0xD06900 Offset: 0xD04F00 VA: 0x180D06900
	|-ADictionary<int, object>..ctor
	|
	|-RVA: 0xD05A50 Offset: 0xD04050 VA: 0x180D05A50
	|-ADictionary<object, int>..ctor
	|
	|-RVA: 0xDEAB20 Offset: 0xDE9120 VA: 0x180DEAB20
	|-ADictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0xDEA960 Offset: 0xDE8F60 VA: 0x180DEA960
	|-ADictionary<object, object>..ctor
	|
	|-RVA: 0xDEB490 Offset: 0xDE9A90 VA: 0x180DEB490
	|-ADictionary<uint, int>..ctor
	|
	|-RVA: 0xDEAF40 Offset: 0xDE9540 VA: 0x180DEAF40
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD07380 Offset: 0xD05980 VA: 0x180D07380
	|-ADictionary<Bytes20, int>..ctor
	|
	|-RVA: 0xD06640 Offset: 0xD04C40 VA: 0x180D06640
	|-ADictionary<Guid, object>..ctor
	|
	|-RVA: 0xD07350 Offset: 0xD05950 VA: 0x180D07350
	|-ADictionary<int, int>..ctor
	|
	|-RVA: 0xD068D0 Offset: 0xD04ED0 VA: 0x180D068D0
	|-ADictionary<int, object>..ctor
	|
	|-RVA: 0xD05F00 Offset: 0xD04500 VA: 0x180D05F00
	|-ADictionary<object, int>..ctor
	|
	|-RVA: 0xDEACB0 Offset: 0xDE92B0 VA: 0x180DEACB0
	|-ADictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0xDEAD10 Offset: 0xDE9310 VA: 0x180DEAD10
	|-ADictionary<object, object>..ctor
	|
	|-RVA: 0xDEBDA0 Offset: 0xDEA3A0 VA: 0x180DEBDA0
	|-ADictionary<uint, int>..ctor
	|
	|-RVA: 0xDEA480 Offset: 0xDE8A80 VA: 0x180DEA480
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> , IEqualityComparer<TKey> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD064B0 Offset: 0xD04AB0 VA: 0x180D064B0
	|-ADictionary<Bytes20, int>..ctor
	|
	|-RVA: 0xD05A20 Offset: 0xD04020 VA: 0x180D05A20
	|-ADictionary<Guid, object>..ctor
	|
	|-RVA: 0xD05E70 Offset: 0xD04470 VA: 0x180D05E70
	|-ADictionary<int, int>..ctor
	|
	|-RVA: 0xD07490 Offset: 0xD05A90 VA: 0x180D07490
	|-ADictionary<int, object>..ctor
	|
	|-RVA: 0xD075C0 Offset: 0xD05BC0 VA: 0x180D075C0
	|-ADictionary<object, int>..ctor
	|
	|-RVA: 0xDEB5F0 Offset: 0xDE9BF0 VA: 0x180DEB5F0
	|-ADictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0xDEB0C0 Offset: 0xDE96C0 VA: 0x180DEB0C0
	|-ADictionary<object, object>..ctor
	|
	|-RVA: 0xDEAF10 Offset: 0xDE9510 VA: 0x180DEAF10
	|-ADictionary<uint, int>..ctor
	|
	|-RVA: 0xDEBE30 Offset: 0xDEA430 VA: 0x180DEBE30
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> , IEqualityComparer<TKey> , IEqualityComparer<TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD06B40 Offset: 0xD05140 VA: 0x180D06B40
	|-ADictionary<Bytes20, int>..ctor
	|
	|-RVA: 0xD04F80 Offset: 0xD03580 VA: 0x180D04F80
	|-ADictionary<Guid, object>..ctor
	|
	|-RVA: 0xD053E0 Offset: 0xD039E0 VA: 0x180D053E0
	|-ADictionary<int, int>..ctor
	|
	|-RVA: 0xD05F30 Offset: 0xD04530 VA: 0x180D05F30
	|-ADictionary<int, object>..ctor
	|
	|-RVA: 0xD07070 Offset: 0xD05670 VA: 0x180D07070
	|-ADictionary<object, int>..ctor
	|
	|-RVA: 0xDEB0F0 Offset: 0xDE96F0 VA: 0x180DEB0F0
	|-ADictionary<object, Int32Enum>..ctor
	|
	|-RVA: 0xDEBAC0 Offset: 0xDEA0C0 VA: 0x180DEBAC0
	|-ADictionary<object, object>..ctor
	|
	|-RVA: 0xDEA4B0 Offset: 0xDE8AB0 VA: 0x180DEA4B0
	|-ADictionary<uint, int>..ctor
	|
	|-RVA: 0xDEB620 Offset: 0xDE9C20 VA: 0x180DEB620
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF5D50 Offset: 0xCF4350 VA: 0x180CF5D50
	|-ADictionary<Bytes20, int>.Add
	|
	|-RVA: 0xCF5D10 Offset: 0xCF4310 VA: 0x180CF5D10
	|-ADictionary<Guid, object>.Add
	|
	|-RVA: 0xCF5D90 Offset: 0xCF4390 VA: 0x180CF5D90
	|-ADictionary<int, int>.Add
	|
	|-RVA: 0xCF5DF0 Offset: 0xCF43F0 VA: 0x180CF5DF0
	|-ADictionary<int, object>.Add
	|
	|-RVA: 0xCF5DC0 Offset: 0xCF43C0 VA: 0x180CF5DC0
	|-ADictionary<object, int>.Add
	|
	|-RVA: 0xDDF640 Offset: 0xDDDC40 VA: 0x180DDF640
	|-ADictionary<object, Int32Enum>.Add
	|
	|-RVA: 0xDDF670 Offset: 0xDDDC70 VA: 0x180DDF670
	|-ADictionary<object, object>.Add
	|
	|-RVA: 0xDDF610 Offset: 0xDDDC10 VA: 0x180DDF610
	|-ADictionary<uint, int>.Add
	|
	|-RVA: 0xDDF470 Offset: 0xDDDA70 VA: 0x180DDF470
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF6550 Offset: 0xCF4B50 VA: 0x180CF6550
	|-ADictionary<Bytes20, int>.Clear
	|-ADictionary<Guid, object>.Clear
	|-ADictionary<int, int>.Clear
	|-ADictionary<int, object>.Clear
	|-ADictionary<object, int>.Clear
	|-ADictionary<object, Int32Enum>.Clear
	|-ADictionary<object, object>.Clear
	|-ADictionary<uint, int>.Clear
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF6610 Offset: 0xCF4C10 VA: 0x180CF6610
	|-ADictionary<Bytes20, int>.ContainsKey
	|
	|-RVA: 0xCF66B0 Offset: 0xCF4CB0 VA: 0x180CF66B0
	|-ADictionary<Guid, object>.ContainsKey
	|
	|-RVA: 0xCF6680 Offset: 0xCF4C80 VA: 0x180CF6680
	|-ADictionary<int, int>.ContainsKey
	|-ADictionary<uint, int>.ContainsKey
	|
	|-RVA: 0xCF65E0 Offset: 0xCF4BE0 VA: 0x180CF65E0
	|-ADictionary<int, object>.ContainsKey
	|
	|-RVA: 0xCF6650 Offset: 0xCF4C50 VA: 0x180CF6650
	|-ADictionary<object, int>.ContainsKey
	|-ADictionary<object, Int32Enum>.ContainsKey
	|-ADictionary<object, object>.ContainsKey
	|
	|-RVA: 0xDDFD80 Offset: 0xDDE380 VA: 0x180DDFD80
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF6890 Offset: 0xCF4E90 VA: 0x180CF6890
	|-ADictionary<Bytes20, int>.ContainsValue
	|
	|-RVA: 0xCF6860 Offset: 0xCF4E60 VA: 0x180CF6860
	|-ADictionary<Guid, object>.ContainsValue
	|
	|-RVA: 0xCF6710 Offset: 0xCF4D10 VA: 0x180CF6710
	|-ADictionary<int, int>.ContainsValue
	|-ADictionary<uint, int>.ContainsValue
	|
	|-RVA: 0xCF66E0 Offset: 0xCF4CE0 VA: 0x180CF66E0
	|-ADictionary<int, object>.ContainsValue
	|-ADictionary<object, object>.ContainsValue
	|
	|-RVA: 0xCF69E0 Offset: 0xCF4FE0 VA: 0x180CF69E0
	|-ADictionary<object, int>.ContainsValue
	|-ADictionary<object, Int32Enum>.ContainsValue
	|
	|-RVA: 0xDDFE70 Offset: 0xDDE470 VA: 0x180DDFE70
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1
	public ADictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF80E0 Offset: 0xCF66E0 VA: 0x180CF80E0
	|-ADictionary<Bytes20, int>.GetEnumerator
	|
	|-RVA: 0xCF80A0 Offset: 0xCF66A0 VA: 0x180CF80A0
	|-ADictionary<Guid, object>.GetEnumerator
	|
	|-RVA: 0xCF8170 Offset: 0xCF6770 VA: 0x180CF8170
	|-ADictionary<int, int>.GetEnumerator
	|-ADictionary<uint, int>.GetEnumerator
	|
	|-RVA: 0xCF8130 Offset: 0xCF6730 VA: 0x180CF8130
	|-ADictionary<int, object>.GetEnumerator
	|-ADictionary<object, int>.GetEnumerator
	|-ADictionary<object, Int32Enum>.GetEnumerator
	|-ADictionary<object, object>.GetEnumerator
	|
	|-RVA: 0xDE0F10 Offset: 0xDDF510 VA: 0x180DE0F10
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFD830 Offset: 0xCFBE30 VA: 0x180CFD830
	|-ADictionary<Bytes20, int>.Remove
	|
	|-RVA: 0xCFD440 Offset: 0xCFBA40 VA: 0x180CFD440
	|-ADictionary<Guid, object>.Remove
	|
	|-RVA: 0xCFD170 Offset: 0xCFB770 VA: 0x180CFD170
	|-ADictionary<int, int>.Remove
	|-ADictionary<uint, int>.Remove
	|
	|-RVA: 0xCFDBF0 Offset: 0xCFC1F0 VA: 0x180CFDBF0
	|-ADictionary<int, object>.Remove
	|
	|-RVA: 0xCFCE30 Offset: 0xCFB430 VA: 0x180CFCE30
	|-ADictionary<object, int>.Remove
	|-ADictionary<object, Int32Enum>.Remove
	|
	|-RVA: 0xDE46D0 Offset: 0xDE2CD0 VA: 0x180DE46D0
	|-ADictionary<object, object>.Remove
	|
	|-RVA: 0xDE4030 Offset: 0xDE2630 VA: 0x180DE4030
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD03200 Offset: 0xD01800 VA: 0x180D03200
	|-ADictionary<Bytes20, int>.TryGetValue
	|
	|-RVA: 0xD03290 Offset: 0xD01890 VA: 0x180D03290
	|-ADictionary<Guid, object>.TryGetValue
	|
	|-RVA: 0xD03120 Offset: 0xD01720 VA: 0x180D03120
	|-ADictionary<int, int>.TryGetValue
	|-ADictionary<uint, int>.TryGetValue
	|
	|-RVA: 0xD030A0 Offset: 0xD016A0 VA: 0x180D030A0
	|-ADictionary<int, object>.TryGetValue
	|
	|-RVA: 0xD03190 Offset: 0xD01790 VA: 0x180D03190
	|-ADictionary<object, int>.TryGetValue
	|-ADictionary<object, Int32Enum>.TryGetValue
	|
	|-RVA: 0xDE86E0 Offset: 0xDE6CE0 VA: 0x180DE86E0
	|-ADictionary<object, object>.TryGetValue
	|
	|-RVA: 0xDE84F0 Offset: 0xDE6AF0 VA: 0x180DE84F0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetValueSafe(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFA550 Offset: 0xCF8B50 VA: 0x180CFA550
	|-ADictionary<Bytes20, int>.GetValueSafe
	|
	|-RVA: 0xCFA4E0 Offset: 0xCF8AE0 VA: 0x180CFA4E0
	|-ADictionary<Guid, object>.GetValueSafe
	|
	|-RVA: 0xCFA5C0 Offset: 0xCF8BC0 VA: 0x180CFA5C0
	|-ADictionary<int, int>.GetValueSafe
	|-ADictionary<uint, int>.GetValueSafe
	|
	|-RVA: 0xCFA420 Offset: 0xCF8A20 VA: 0x180CFA420
	|-ADictionary<int, object>.GetValueSafe
	|
	|-RVA: 0xCFA480 Offset: 0xCF8A80 VA: 0x180CFA480
	|-ADictionary<object, int>.GetValueSafe
	|-ADictionary<object, Int32Enum>.GetValueSafe
	|
	|-RVA: 0xDE2710 Offset: 0xDE0D10 VA: 0x180DE2710
	|-ADictionary<object, object>.GetValueSafe
	|
	|-RVA: 0xDE2530 Offset: 0xDE0B30 VA: 0x180DE2530
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValueSafe
	*/

	// RVA: -1 Offset: -1
	public int get_IndexOfFirst() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD07860 Offset: 0xD05E60 VA: 0x180D07860
	|-ADictionary<Bytes20, int>.get_IndexOfFirst
	|
	|-RVA: 0xD07770 Offset: 0xD05D70 VA: 0x180D07770
	|-ADictionary<Guid, object>.get_IndexOfFirst
	|
	|-RVA: 0xD077C0 Offset: 0xD05DC0 VA: 0x180D077C0
	|-ADictionary<int, int>.get_IndexOfFirst
	|-ADictionary<uint, int>.get_IndexOfFirst
	|
	|-RVA: 0xD07810 Offset: 0xD05E10 VA: 0x180D07810
	|-ADictionary<int, object>.get_IndexOfFirst
	|-ADictionary<object, int>.get_IndexOfFirst
	|-ADictionary<object, Int32Enum>.get_IndexOfFirst
	|-ADictionary<object, object>.get_IndexOfFirst
	|
	|-RVA: 0xDEBEA0 Offset: 0xDEA4A0 VA: 0x180DEBEA0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IndexOfFirst
	*/

	// RVA: -1 Offset: -1
	public int get_IndexOfLast() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD079A0 Offset: 0xD05FA0 VA: 0x180D079A0
	|-ADictionary<Bytes20, int>.get_IndexOfLast
	|
	|-RVA: 0xD078B0 Offset: 0xD05EB0 VA: 0x180D078B0
	|-ADictionary<Guid, object>.get_IndexOfLast
	|
	|-RVA: 0xD07950 Offset: 0xD05F50 VA: 0x180D07950
	|-ADictionary<int, int>.get_IndexOfLast
	|-ADictionary<uint, int>.get_IndexOfLast
	|
	|-RVA: 0xD07900 Offset: 0xD05F00 VA: 0x180D07900
	|-ADictionary<int, object>.get_IndexOfLast
	|-ADictionary<object, int>.get_IndexOfLast
	|-ADictionary<object, Int32Enum>.get_IndexOfLast
	|-ADictionary<object, object>.get_IndexOfLast
	|
	|-RVA: 0xDEBF40 Offset: 0xDEA540 VA: 0x180DEBF40
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IndexOfLast
	*/

	// RVA: -1 Offset: -1
	public int IndexOfKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFB170 Offset: 0xCF9770 VA: 0x180CFB170
	|-ADictionary<Bytes20, int>.IndexOfKey
	|
	|-RVA: 0xCFB9C0 Offset: 0xCF9FC0 VA: 0x180CFB9C0
	|-ADictionary<Guid, object>.IndexOfKey
	|
	|-RVA: 0xCFB3F0 Offset: 0xCF99F0 VA: 0x180CFB3F0
	|-ADictionary<int, int>.IndexOfKey
	|-ADictionary<uint, int>.IndexOfKey
	|
	|-RVA: 0xCFB7F0 Offset: 0xCF9DF0 VA: 0x180CFB7F0
	|-ADictionary<int, object>.IndexOfKey
	|
	|-RVA: 0xCFB5C0 Offset: 0xCF9BC0 VA: 0x180CFB5C0
	|-ADictionary<object, int>.IndexOfKey
	|-ADictionary<object, Int32Enum>.IndexOfKey
	|-ADictionary<object, object>.IndexOfKey
	|
	|-RVA: 0xDE3200 Offset: 0xDE1800 VA: 0x180DE3200
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOfKey
	*/

	// RVA: -1 Offset: -1
	public int IndexOfValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFC100 Offset: 0xCFA700 VA: 0x180CFC100
	|-ADictionary<Bytes20, int>.IndexOfValue
	|
	|-RVA: 0xCFBCA0 Offset: 0xCFA2A0 VA: 0x180CFBCA0
	|-ADictionary<Guid, object>.IndexOfValue
	|
	|-RVA: 0xCFC240 Offset: 0xCFA840 VA: 0x180CFC240
	|-ADictionary<int, int>.IndexOfValue
	|-ADictionary<uint, int>.IndexOfValue
	|
	|-RVA: 0xCFBF70 Offset: 0xCFA570 VA: 0x180CFBF70
	|-ADictionary<int, object>.IndexOfValue
	|-ADictionary<object, object>.IndexOfValue
	|
	|-RVA: 0xCFBE30 Offset: 0xCFA430 VA: 0x180CFBE30
	|-ADictionary<object, int>.IndexOfValue
	|-ADictionary<object, Int32Enum>.IndexOfValue
	|
	|-RVA: 0xDE3620 Offset: 0xDE1C20 VA: 0x180DE3620
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOfValue
	*/

	// RVA: -1 Offset: -1
	public bool IsValidAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFC420 Offset: 0xCFAA20 VA: 0x180CFC420
	|-ADictionary<Bytes20, int>.IsValidAt
	|
	|-RVA: 0xCFC3D0 Offset: 0xCFA9D0 VA: 0x180CFC3D0
	|-ADictionary<Guid, object>.IsValidAt
	|
	|-RVA: 0xCFC470 Offset: 0xCFAA70 VA: 0x180CFC470
	|-ADictionary<int, int>.IsValidAt
	|-ADictionary<uint, int>.IsValidAt
	|
	|-RVA: 0xCFC380 Offset: 0xCFA980 VA: 0x180CFC380
	|-ADictionary<int, object>.IsValidAt
	|-ADictionary<object, int>.IsValidAt
	|-ADictionary<object, Int32Enum>.IsValidAt
	|-ADictionary<object, object>.IsValidAt
	|
	|-RVA: 0xDE39C0 Offset: 0xDE1FC0 VA: 0x180DE39C0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsValidAt
	*/

	// RVA: -1 Offset: -1
	public TKey GetKeyAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF8450 Offset: 0xCF6A50 VA: 0x180CF8450
	|-ADictionary<Bytes20, int>.GetKeyAt
	|
	|-RVA: 0xCF8370 Offset: 0xCF6970 VA: 0x180CF8370
	|-ADictionary<Guid, object>.GetKeyAt
	|
	|-RVA: 0xCF81B0 Offset: 0xCF67B0 VA: 0x180CF81B0
	|-ADictionary<int, int>.GetKeyAt
	|-ADictionary<uint, int>.GetKeyAt
	|
	|-RVA: 0xCF8290 Offset: 0xCF6890 VA: 0x180CF8290
	|-ADictionary<int, object>.GetKeyAt
	|
	|-RVA: 0xCF8540 Offset: 0xCF6B40 VA: 0x180CF8540
	|-ADictionary<object, int>.GetKeyAt
	|-ADictionary<object, Int32Enum>.GetKeyAt
	|-ADictionary<object, object>.GetKeyAt
	|
	|-RVA: 0xDE0FD0 Offset: 0xDDF5D0 VA: 0x180DE0FD0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeyAt
	*/

	// RVA: -1 Offset: -1
	public TValue GetValueAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9FC0 Offset: 0xCF85C0 VA: 0x180CF9FC0
	|-ADictionary<Bytes20, int>.GetValueAt
	|
	|-RVA: 0xCFA340 Offset: 0xCF8940 VA: 0x180CFA340
	|-ADictionary<Guid, object>.GetValueAt
	|
	|-RVA: 0xCFA260 Offset: 0xCF8860 VA: 0x180CFA260
	|-ADictionary<int, int>.GetValueAt
	|-ADictionary<uint, int>.GetValueAt
	|
	|-RVA: 0xCFA0A0 Offset: 0xCF86A0 VA: 0x180CFA0A0
	|-ADictionary<int, object>.GetValueAt
	|-ADictionary<object, object>.GetValueAt
	|
	|-RVA: 0xCFA180 Offset: 0xCF8780 VA: 0x180CFA180
	|-ADictionary<object, int>.GetValueAt
	|-ADictionary<object, Int32Enum>.GetValueAt
	|
	|-RVA: 0xDE2360 Offset: 0xDE0960 VA: 0x180DE2360
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValueAt
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<TKey, TValue> GetEntryAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7F60 Offset: 0xCF6560 VA: 0x180CF7F60
	|-ADictionary<Bytes20, int>.GetEntryAt
	|
	|-RVA: 0xCF7BD0 Offset: 0xCF61D0 VA: 0x180CF7BD0
	|-ADictionary<Guid, object>.GetEntryAt
	|
	|-RVA: 0xCF7E20 Offset: 0xCF6420 VA: 0x180CF7E20
	|-ADictionary<int, int>.GetEntryAt
	|-ADictionary<uint, int>.GetEntryAt
	|
	|-RVA: 0xCF7D00 Offset: 0xCF6300 VA: 0x180CF7D00
	|-ADictionary<int, object>.GetEntryAt
	|
	|-RVA: 0xCF7AB0 Offset: 0xCF60B0 VA: 0x180CF7AB0
	|-ADictionary<object, int>.GetEntryAt
	|-ADictionary<object, Int32Enum>.GetEntryAt
	|
	|-RVA: 0xDE0DF0 Offset: 0xDDF3F0 VA: 0x180DE0DF0
	|-ADictionary<object, object>.GetEntryAt
	|
	|-RVA: 0xDE0A70 Offset: 0xDDF070 VA: 0x180DE0A70
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEntryAt
	*/

	// RVA: -1 Offset: -1
	public bool TryGetKeyAt(int index, out TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD02E50 Offset: 0xD01450 VA: 0x180D02E50
	|-ADictionary<Bytes20, int>.TryGetKeyAt
	|
	|-RVA: 0xD02CD0 Offset: 0xD012D0 VA: 0x180D02CD0
	|-ADictionary<Guid, object>.TryGetKeyAt
	|
	|-RVA: 0xD02DF0 Offset: 0xD013F0 VA: 0x180D02DF0
	|-ADictionary<int, int>.TryGetKeyAt
	|-ADictionary<uint, int>.TryGetKeyAt
	|
	|-RVA: 0xD02D30 Offset: 0xD01330 VA: 0x180D02D30
	|-ADictionary<int, object>.TryGetKeyAt
	|
	|-RVA: 0xD02D90 Offset: 0xD01390 VA: 0x180D02D90
	|-ADictionary<object, int>.TryGetKeyAt
	|-ADictionary<object, Int32Enum>.TryGetKeyAt
	|-ADictionary<object, object>.TryGetKeyAt
	|
	|-RVA: 0xDE81C0 Offset: 0xDE67C0 VA: 0x180DE81C0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetKeyAt
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValueAt(int index, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD02EC0 Offset: 0xD014C0 VA: 0x180D02EC0
	|-ADictionary<Bytes20, int>.TryGetValueAt
	|
	|-RVA: 0xD03040 Offset: 0xD01640 VA: 0x180D03040
	|-ADictionary<Guid, object>.TryGetValueAt
	|
	|-RVA: 0xD02FE0 Offset: 0xD015E0 VA: 0x180D02FE0
	|-ADictionary<int, int>.TryGetValueAt
	|-ADictionary<uint, int>.TryGetValueAt
	|
	|-RVA: 0xD02F80 Offset: 0xD01580 VA: 0x180D02F80
	|-ADictionary<int, object>.TryGetValueAt
	|-ADictionary<object, object>.TryGetValueAt
	|
	|-RVA: 0xD02F20 Offset: 0xD01520 VA: 0x180D02F20
	|-ADictionary<object, int>.TryGetValueAt
	|-ADictionary<object, Int32Enum>.TryGetValueAt
	|
	|-RVA: 0xDE8350 Offset: 0xDE6950 VA: 0x180DE8350
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValueAt
	*/

	// RVA: -1 Offset: -1
	public bool TryGetEntryAt(int index, out KeyValuePair<TKey, TValue> entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD02BD0 Offset: 0xD011D0 VA: 0x180D02BD0
	|-ADictionary<Bytes20, int>.TryGetEntryAt
	|
	|-RVA: 0xD02AD0 Offset: 0xD010D0 VA: 0x180D02AD0
	|-ADictionary<Guid, object>.TryGetEntryAt
	|
	|-RVA: 0xD02860 Offset: 0xD00E60 VA: 0x180D02860
	|-ADictionary<int, int>.TryGetEntryAt
	|-ADictionary<uint, int>.TryGetEntryAt
	|
	|-RVA: 0xD02920 Offset: 0xD00F20 VA: 0x180D02920
	|-ADictionary<int, object>.TryGetEntryAt
	|
	|-RVA: 0xD02A00 Offset: 0xD01000 VA: 0x180D02A00
	|-ADictionary<object, int>.TryGetEntryAt
	|-ADictionary<object, Int32Enum>.TryGetEntryAt
	|
	|-RVA: 0xDE7DA0 Offset: 0xDE63A0 VA: 0x180DE7DA0
	|-ADictionary<object, object>.TryGetEntryAt
	|
	|-RVA: 0xDE7E80 Offset: 0xDE6480 VA: 0x180DE7E80
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetEntryAt
	*/

	// RVA: -1 Offset: -1
	public bool GetNextIndex(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF8CC0 Offset: 0xCF72C0 VA: 0x180CF8CC0
	|-ADictionary<Bytes20, int>.GetNextIndex
	|
	|-RVA: 0xCF8BA0 Offset: 0xCF71A0 VA: 0x180CF8BA0
	|-ADictionary<Guid, object>.GetNextIndex
	|
	|-RVA: 0xCF8D20 Offset: 0xCF7320 VA: 0x180CF8D20
	|-ADictionary<int, int>.GetNextIndex
	|-ADictionary<uint, int>.GetNextIndex
	|
	|-RVA: 0xCF8C00 Offset: 0xCF7200 VA: 0x180CF8C00
	|-ADictionary<int, object>.GetNextIndex
	|-ADictionary<object, int>.GetNextIndex
	|-ADictionary<object, Int32Enum>.GetNextIndex
	|-ADictionary<object, object>.GetNextIndex
	|
	|-RVA: 0xDE1670 Offset: 0xDDFC70 VA: 0x180DE1670
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetNextIndex
	*/

	// RVA: -1 Offset: -1
	public int GetNextIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF8D80 Offset: 0xCF7380 VA: 0x180CF8D80
	|-ADictionary<Bytes20, int>.GetNextIndex
	|
	|-RVA: 0xCF8B40 Offset: 0xCF7140 VA: 0x180CF8B40
	|-ADictionary<Guid, object>.GetNextIndex
	|
	|-RVA: 0xCF8C60 Offset: 0xCF7260 VA: 0x180CF8C60
	|-ADictionary<int, int>.GetNextIndex
	|-ADictionary<uint, int>.GetNextIndex
	|
	|-RVA: 0xCF8AE0 Offset: 0xCF70E0 VA: 0x180CF8AE0
	|-ADictionary<int, object>.GetNextIndex
	|-ADictionary<object, int>.GetNextIndex
	|-ADictionary<object, Int32Enum>.GetNextIndex
	|-ADictionary<object, object>.GetNextIndex
	|
	|-RVA: 0xDE15D0 Offset: 0xDDFBD0 VA: 0x180DE15D0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetNextIndex
	*/

	// RVA: -1 Offset: -1
	public bool GetNextKey(ref int index, out TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF8DE0 Offset: 0xCF73E0 VA: 0x180CF8DE0
	|-ADictionary<Bytes20, int>.GetNextKey
	|
	|-RVA: 0xCF8F00 Offset: 0xCF7500 VA: 0x180CF8F00
	|-ADictionary<Guid, object>.GetNextKey
	|
	|-RVA: 0xCF8F80 Offset: 0xCF7580 VA: 0x180CF8F80
	|-ADictionary<int, int>.GetNextKey
	|-ADictionary<uint, int>.GetNextKey
	|
	|-RVA: 0xCF8E80 Offset: 0xCF7480 VA: 0x180CF8E80
	|-ADictionary<int, object>.GetNextKey
	|
	|-RVA: 0xCF9000 Offset: 0xCF7600 VA: 0x180CF9000
	|-ADictionary<object, int>.GetNextKey
	|-ADictionary<object, Int32Enum>.GetNextKey
	|-ADictionary<object, object>.GetNextKey
	|
	|-RVA: 0xDE1720 Offset: 0xDDFD20 VA: 0x180DE1720
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetNextKey
	*/

	// RVA: -1 Offset: -1
	public bool GetNextValue(ref int index, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF92B0 Offset: 0xCF78B0 VA: 0x180CF92B0
	|-ADictionary<Bytes20, int>.GetNextValue
	|
	|-RVA: 0xCF9090 Offset: 0xCF7690 VA: 0x180CF9090
	|-ADictionary<Guid, object>.GetNextValue
	|
	|-RVA: 0xCF91A0 Offset: 0xCF77A0 VA: 0x180CF91A0
	|-ADictionary<int, int>.GetNextValue
	|-ADictionary<uint, int>.GetNextValue
	|
	|-RVA: 0xCF9220 Offset: 0xCF7820 VA: 0x180CF9220
	|-ADictionary<int, object>.GetNextValue
	|-ADictionary<object, object>.GetNextValue
	|
	|-RVA: 0xCF9110 Offset: 0xCF7710 VA: 0x180CF9110
	|-ADictionary<object, int>.GetNextValue
	|-ADictionary<object, Int32Enum>.GetNextValue
	|
	|-RVA: 0xDE18C0 Offset: 0xDDFEC0 VA: 0x180DE18C0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetNextValue
	*/

	// RVA: -1 Offset: -1
	public bool GetNextEntry(ref int index, out KeyValuePair<TKey, TValue> entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF8700 Offset: 0xCF6D00 VA: 0x180CF8700
	|-ADictionary<Bytes20, int>.GetNextEntry
	|
	|-RVA: 0xCF8810 Offset: 0xCF6E10 VA: 0x180CF8810
	|-ADictionary<Guid, object>.GetNextEntry
	|
	|-RVA: 0xCF8620 Offset: 0xCF6C20 VA: 0x180CF8620
	|-ADictionary<int, int>.GetNextEntry
	|-ADictionary<uint, int>.GetNextEntry
	|
	|-RVA: 0xCF8A00 Offset: 0xCF7000 VA: 0x180CF8A00
	|-ADictionary<int, object>.GetNextEntry
	|
	|-RVA: 0xCF8920 Offset: 0xCF6F20 VA: 0x180CF8920
	|-ADictionary<object, int>.GetNextEntry
	|-ADictionary<object, Int32Enum>.GetNextEntry
	|
	|-RVA: 0xDE14F0 Offset: 0xDDFAF0 VA: 0x180DE14F0
	|-ADictionary<object, object>.GetNextEntry
	|
	|-RVA: 0xDE11A0 Offset: 0xDDF7A0 VA: 0x180DE11A0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetNextEntry
	*/

	// RVA: -1 Offset: -1
	public bool GetPreviousIndex(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF98C0 Offset: 0xCF7EC0 VA: 0x180CF98C0
	|-ADictionary<Bytes20, int>.GetPreviousIndex
	|
	|-RVA: 0xCF9810 Offset: 0xCF7E10 VA: 0x180CF9810
	|-ADictionary<Guid, object>.GetPreviousIndex
	|
	|-RVA: 0xCF99D0 Offset: 0xCF7FD0 VA: 0x180CF99D0
	|-ADictionary<int, int>.GetPreviousIndex
	|-ADictionary<uint, int>.GetPreviousIndex
	|
	|-RVA: 0xCF9920 Offset: 0xCF7F20 VA: 0x180CF9920
	|-ADictionary<int, object>.GetPreviousIndex
	|-ADictionary<object, int>.GetPreviousIndex
	|-ADictionary<object, Int32Enum>.GetPreviousIndex
	|-ADictionary<object, object>.GetPreviousIndex
	|
	|-RVA: 0xDE1F50 Offset: 0xDE0550 VA: 0x180DE1F50
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetPreviousIndex
	*/

	// RVA: -1 Offset: -1
	public int GetPreviousIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9A30 Offset: 0xCF8030 VA: 0x180CF9A30
	|-ADictionary<Bytes20, int>.GetPreviousIndex
	|
	|-RVA: 0xCF9980 Offset: 0xCF7F80 VA: 0x180CF9980
	|-ADictionary<Guid, object>.GetPreviousIndex
	|
	|-RVA: 0xCF97C0 Offset: 0xCF7DC0 VA: 0x180CF97C0
	|-ADictionary<int, int>.GetPreviousIndex
	|-ADictionary<uint, int>.GetPreviousIndex
	|
	|-RVA: 0xCF9870 Offset: 0xCF7E70 VA: 0x180CF9870
	|-ADictionary<int, object>.GetPreviousIndex
	|-ADictionary<object, int>.GetPreviousIndex
	|-ADictionary<object, Int32Enum>.GetPreviousIndex
	|-ADictionary<object, object>.GetPreviousIndex
	|
	|-RVA: 0xDE1EB0 Offset: 0xDE04B0 VA: 0x180DE1EB0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetPreviousIndex
	*/

	// RVA: -1 Offset: -1
	public bool GetPreviousKey(ref int index, out TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9C10 Offset: 0xCF8210 VA: 0x180CF9C10
	|-ADictionary<Bytes20, int>.GetPreviousKey
	|
	|-RVA: 0xCF9B90 Offset: 0xCF8190 VA: 0x180CF9B90
	|-ADictionary<Guid, object>.GetPreviousKey
	|
	|-RVA: 0xCF9A80 Offset: 0xCF8080 VA: 0x180CF9A80
	|-ADictionary<int, int>.GetPreviousKey
	|-ADictionary<uint, int>.GetPreviousKey
	|
	|-RVA: 0xCF9CB0 Offset: 0xCF82B0 VA: 0x180CF9CB0
	|-ADictionary<int, object>.GetPreviousKey
	|
	|-RVA: 0xCF9B00 Offset: 0xCF8100 VA: 0x180CF9B00
	|-ADictionary<object, int>.GetPreviousKey
	|-ADictionary<object, Int32Enum>.GetPreviousKey
	|-ADictionary<object, object>.GetPreviousKey
	|
	|-RVA: 0xDE2000 Offset: 0xDE0600 VA: 0x180DE2000
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetPreviousKey
	*/

	// RVA: -1 Offset: -1
	public bool GetPreviousValue(ref int index, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9D30 Offset: 0xCF8330 VA: 0x180CF9D30
	|-ADictionary<Bytes20, int>.GetPreviousValue
	|
	|-RVA: 0xCF9E40 Offset: 0xCF8440 VA: 0x180CF9E40
	|-ADictionary<Guid, object>.GetPreviousValue
	|
	|-RVA: 0xCF9F40 Offset: 0xCF8540 VA: 0x180CF9F40
	|-ADictionary<int, int>.GetPreviousValue
	|-ADictionary<uint, int>.GetPreviousValue
	|
	|-RVA: 0xCF9DB0 Offset: 0xCF83B0 VA: 0x180CF9DB0
	|-ADictionary<int, object>.GetPreviousValue
	|-ADictionary<object, object>.GetPreviousValue
	|
	|-RVA: 0xCF9EC0 Offset: 0xCF84C0 VA: 0x180CF9EC0
	|-ADictionary<object, int>.GetPreviousValue
	|-ADictionary<object, Int32Enum>.GetPreviousValue
	|
	|-RVA: 0xDE21B0 Offset: 0xDE07B0 VA: 0x180DE21B0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetPreviousValue
	*/

	// RVA: -1 Offset: -1
	public bool GetPreviousEntry(ref int index, out KeyValuePair<TKey, TValue> entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF95C0 Offset: 0xCF7BC0 VA: 0x180CF95C0
	|-ADictionary<Bytes20, int>.GetPreviousEntry
	|
	|-RVA: 0xCF96C0 Offset: 0xCF7CC0 VA: 0x180CF96C0
	|-ADictionary<Guid, object>.GetPreviousEntry
	|
	|-RVA: 0xCF9330 Offset: 0xCF7930 VA: 0x180CF9330
	|-ADictionary<int, int>.GetPreviousEntry
	|-ADictionary<uint, int>.GetPreviousEntry
	|
	|-RVA: 0xCF9400 Offset: 0xCF7A00 VA: 0x180CF9400
	|-ADictionary<int, object>.GetPreviousEntry
	|
	|-RVA: 0xCF94E0 Offset: 0xCF7AE0 VA: 0x180CF94E0
	|-ADictionary<object, int>.GetPreviousEntry
	|-ADictionary<object, Int32Enum>.GetPreviousEntry
	|
	|-RVA: 0xDE1A70 Offset: 0xDE0070 VA: 0x180DE1A70
	|-ADictionary<object, object>.GetPreviousEntry
	|
	|-RVA: 0xDE1B50 Offset: 0xDE0150 VA: 0x180DE1B50
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetPreviousEntry
	*/

	// RVA: -1 Offset: -1
	public bool RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFCA40 Offset: 0xCFB040 VA: 0x180CFCA40
	|-ADictionary<Bytes20, int>.RemoveAt
	|
	|-RVA: 0xCFCCA0 Offset: 0xCFB2A0 VA: 0x180CFCCA0
	|-ADictionary<Guid, object>.RemoveAt
	|
	|-RVA: 0xCFCD70 Offset: 0xCFB370 VA: 0x180CFCD70
	|-ADictionary<int, int>.RemoveAt
	|-ADictionary<uint, int>.RemoveAt
	|
	|-RVA: 0xCFCB20 Offset: 0xCFB120 VA: 0x180CFCB20
	|-ADictionary<int, object>.RemoveAt
	|
	|-RVA: 0xCFCBE0 Offset: 0xCFB1E0 VA: 0x180CFCBE0
	|-ADictionary<object, int>.RemoveAt
	|-ADictionary<object, Int32Enum>.RemoveAt
	|
	|-RVA: 0xDE3F70 Offset: 0xDE2570 VA: 0x180DE3F70
	|-ADictionary<object, object>.RemoveAt
	|
	|-RVA: 0xDE3DA0 Offset: 0xDE23A0 VA: 0x180DE3DA0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF6B30 Offset: 0xCF5130 VA: 0x180CF6B30
	|-ADictionary<Bytes20, int>.CopyTo
	|
	|-RVA: 0xCF6F10 Offset: 0xCF5510 VA: 0x180CF6F10
	|-ADictionary<Guid, object>.CopyTo
	|
	|-RVA: 0xCF6D40 Offset: 0xCF5340 VA: 0x180CF6D40
	|-ADictionary<int, int>.CopyTo
	|-ADictionary<uint, int>.CopyTo
	|
	|-RVA: 0xCF7140 Offset: 0xCF5740 VA: 0x180CF7140
	|-ADictionary<int, object>.CopyTo
	|
	|-RVA: 0xCF7330 Offset: 0xCF5930 VA: 0x180CF7330
	|-ADictionary<object, int>.CopyTo
	|-ADictionary<object, Int32Enum>.CopyTo
	|
	|-RVA: 0xDDFF70 Offset: 0xDDE570 VA: 0x180DDFF70
	|-ADictionary<object, object>.CopyTo
	|
	|-RVA: 0xDE0160 Offset: 0xDDE760 VA: 0x180DE0160
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void AxIByVopDfvHaFdcKWHJMelVpGPn(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF5E20 Offset: 0xCF4420 VA: 0x180CF5E20
	|-ADictionary<Bytes20, int>.AxIByVopDfvHaFdcKWHJMelVpGPn
	|
	|-RVA: 0xCF62A0 Offset: 0xCF48A0 VA: 0x180CF62A0
	|-ADictionary<Guid, object>.AxIByVopDfvHaFdcKWHJMelVpGPn
	|
	|-RVA: 0xCF6060 Offset: 0xCF4660 VA: 0x180CF6060
	|-ADictionary<int, int>.AxIByVopDfvHaFdcKWHJMelVpGPn
	|
	|-RVA: 0xCF5F40 Offset: 0xCF4540 VA: 0x180CF5F40
	|-ADictionary<int, object>.AxIByVopDfvHaFdcKWHJMelVpGPn
	|
	|-RVA: 0xCF6180 Offset: 0xCF4780 VA: 0x180CF6180
	|-ADictionary<object, int>.AxIByVopDfvHaFdcKWHJMelVpGPn
	|
	|-RVA: 0xDDF6A0 Offset: 0xDDDCA0 VA: 0x180DDF6A0
	|-ADictionary<object, Int32Enum>.AxIByVopDfvHaFdcKWHJMelVpGPn
	|
	|-RVA: 0xDDFA00 Offset: 0xDDE000 VA: 0x180DDFA00
	|-ADictionary<object, object>.AxIByVopDfvHaFdcKWHJMelVpGPn
	|
	|-RVA: 0xDDF8E0 Offset: 0xDDDEE0 VA: 0x180DDF8E0
	|-ADictionary<uint, int>.AxIByVopDfvHaFdcKWHJMelVpGPn
	|
	|-RVA: 0xDDF7C0 Offset: 0xDDDDC0 VA: 0x180DDF7C0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AxIByVopDfvHaFdcKWHJMelVpGPn
	*/

	// RVA: -1 Offset: -1
	private void XCYCcjEcKiiofrCiznPJRZCBfmJZA(TKey , TValue , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD040C0 Offset: 0xD026C0 VA: 0x180D040C0
	|-ADictionary<Bytes20, int>.XCYCcjEcKiiofrCiznPJRZCBfmJZA
	|
	|-RVA: 0xD03B60 Offset: 0xD02160 VA: 0x180D03B60
	|-ADictionary<Guid, object>.XCYCcjEcKiiofrCiznPJRZCBfmJZA
	|
	|-RVA: 0xD03320 Offset: 0xD01920 VA: 0x180D03320
	|-ADictionary<int, int>.XCYCcjEcKiiofrCiznPJRZCBfmJZA
	|
	|-RVA: 0xD03720 Offset: 0xD01D20 VA: 0x180D03720
	|-ADictionary<int, object>.XCYCcjEcKiiofrCiznPJRZCBfmJZA
	|
	|-RVA: 0xD045A0 Offset: 0xD02BA0 VA: 0x180D045A0
	|-ADictionary<object, int>.XCYCcjEcKiiofrCiznPJRZCBfmJZA
	|
	|-RVA: 0xDE9870 Offset: 0xDE7E70 VA: 0x180DE9870
	|-ADictionary<object, Int32Enum>.XCYCcjEcKiiofrCiznPJRZCBfmJZA
	|
	|-RVA: 0xDE8760 Offset: 0xDE6D60 VA: 0x180DE8760
	|-ADictionary<object, object>.XCYCcjEcKiiofrCiznPJRZCBfmJZA
	|
	|-RVA: 0xDE8C30 Offset: 0xDE7230 VA: 0x180DE8C30
	|-ADictionary<uint, int>.XCYCcjEcKiiofrCiznPJRZCBfmJZA
	|
	|-RVA: 0xDE9030 Offset: 0xDE7630 VA: 0x180DE9030
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.XCYCcjEcKiiofrCiznPJRZCBfmJZA
	*/

	// RVA: -1 Offset: -1
	private void PvAgrzaJtHrUiDPNNtgntJYXeoOJ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFC820 Offset: 0xCFAE20 VA: 0x180CFC820
	|-ADictionary<Bytes20, int>.PvAgrzaJtHrUiDPNNtgntJYXeoOJ
	|
	|-RVA: 0xCFC9A0 Offset: 0xCFAFA0 VA: 0x180CFC9A0
	|-ADictionary<Guid, object>.PvAgrzaJtHrUiDPNNtgntJYXeoOJ
	|
	|-RVA: 0xCFC8A0 Offset: 0xCFAEA0 VA: 0x180CFC8A0
	|-ADictionary<int, int>.PvAgrzaJtHrUiDPNNtgntJYXeoOJ
	|
	|-RVA: 0xCFC7A0 Offset: 0xCFADA0 VA: 0x180CFC7A0
	|-ADictionary<int, object>.PvAgrzaJtHrUiDPNNtgntJYXeoOJ
	|
	|-RVA: 0xCFC920 Offset: 0xCFAF20 VA: 0x180CFC920
	|-ADictionary<object, int>.PvAgrzaJtHrUiDPNNtgntJYXeoOJ
	|
	|-RVA: 0xDE3D20 Offset: 0xDE2320 VA: 0x180DE3D20
	|-ADictionary<object, Int32Enum>.PvAgrzaJtHrUiDPNNtgntJYXeoOJ
	|
	|-RVA: 0xDE3B90 Offset: 0xDE2190 VA: 0x180DE3B90
	|-ADictionary<object, object>.PvAgrzaJtHrUiDPNNtgntJYXeoOJ
	|
	|-RVA: 0xDE3C10 Offset: 0xDE2210 VA: 0x180DE3C10
	|-ADictionary<uint, int>.PvAgrzaJtHrUiDPNNtgntJYXeoOJ
	|
	|-RVA: 0xDE3C90 Offset: 0xDE2290 VA: 0x180DE3C90
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.PvAgrzaJtHrUiDPNNtgntJYXeoOJ
	*/

	// RVA: -1 Offset: -1
	private void HufCeXGWkUCThZCFsfGEpaFrTndgA(int , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFAAA0 Offset: 0xCF90A0 VA: 0x180CFAAA0
	|-ADictionary<Bytes20, int>.HufCeXGWkUCThZCFsfGEpaFrTndgA
	|
	|-RVA: 0xCFA860 Offset: 0xCF8E60 VA: 0x180CFA860
	|-ADictionary<Guid, object>.HufCeXGWkUCThZCFsfGEpaFrTndgA
	|
	|-RVA: 0xCFAF30 Offset: 0xCF9530 VA: 0x180CFAF30
	|-ADictionary<int, int>.HufCeXGWkUCThZCFsfGEpaFrTndgA
	|
	|-RVA: 0xCFA620 Offset: 0xCF8C20 VA: 0x180CFA620
	|-ADictionary<int, object>.HufCeXGWkUCThZCFsfGEpaFrTndgA
	|
	|-RVA: 0xCFACF0 Offset: 0xCF92F0 VA: 0x180CFACF0
	|-ADictionary<object, int>.HufCeXGWkUCThZCFsfGEpaFrTndgA
	|
	|-RVA: 0xDE2BF0 Offset: 0xDE11F0 VA: 0x180DE2BF0
	|-ADictionary<object, Int32Enum>.HufCeXGWkUCThZCFsfGEpaFrTndgA
	|
	|-RVA: 0xDE29B0 Offset: 0xDE0FB0 VA: 0x180DE29B0
	|-ADictionary<object, object>.HufCeXGWkUCThZCFsfGEpaFrTndgA
	|
	|-RVA: 0xDE2770 Offset: 0xDE0D70 VA: 0x180DE2770
	|-ADictionary<uint, int>.HufCeXGWkUCThZCFsfGEpaFrTndgA
	|
	|-RVA: 0xDE2E30 Offset: 0xDE1430 VA: 0x180DE2E30
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.HufCeXGWkUCThZCFsfGEpaFrTndgA
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> FkGyCOWRjtMJSmmfOPHpooWVjtCm() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7A10 Offset: 0xCF6010 VA: 0x180CF7A10
	|-ADictionary<Bytes20, int>.FkGyCOWRjtMJSmmfOPHpooWVjtCm
	|-ADictionary<Guid, object>.FkGyCOWRjtMJSmmfOPHpooWVjtCm
	|-ADictionary<int, int>.FkGyCOWRjtMJSmmfOPHpooWVjtCm
	|-ADictionary<int, object>.FkGyCOWRjtMJSmmfOPHpooWVjtCm
	|-ADictionary<object, int>.FkGyCOWRjtMJSmmfOPHpooWVjtCm
	|-ADictionary<object, Int32Enum>.FkGyCOWRjtMJSmmfOPHpooWVjtCm
	|-ADictionary<object, object>.FkGyCOWRjtMJSmmfOPHpooWVjtCm
	|-ADictionary<uint, int>.FkGyCOWRjtMJSmmfOPHpooWVjtCm
	|
	|-RVA: 0xDE09D0 Offset: 0xDDEFD0 VA: 0x180DE09D0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FkGyCOWRjtMJSmmfOPHpooWVjtCm
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> KmNZXWpsnhsOlYEvwJheVTZrICIK() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFC4C0 Offset: 0xCFAAC0 VA: 0x180CFC4C0
	|-ADictionary<Bytes20, int>.KmNZXWpsnhsOlYEvwJheVTZrICIK
	|-ADictionary<Guid, object>.KmNZXWpsnhsOlYEvwJheVTZrICIK
	|-ADictionary<int, int>.KmNZXWpsnhsOlYEvwJheVTZrICIK
	|-ADictionary<int, object>.KmNZXWpsnhsOlYEvwJheVTZrICIK
	|-ADictionary<object, int>.KmNZXWpsnhsOlYEvwJheVTZrICIK
	|-ADictionary<object, Int32Enum>.KmNZXWpsnhsOlYEvwJheVTZrICIK
	|-ADictionary<object, object>.KmNZXWpsnhsOlYEvwJheVTZrICIK
	|-ADictionary<uint, int>.KmNZXWpsnhsOlYEvwJheVTZrICIK
	|
	|-RVA: 0xDE3A30 Offset: 0xDE2030 VA: 0x180DE3A30
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.KmNZXWpsnhsOlYEvwJheVTZrICIK
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator<KeyValuePair<TKey, TValue>> LWfEyzEWiNfeXWDicOlniMFMjtUGA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFC560 Offset: 0xCFAB60 VA: 0x180CFC560
	|-ADictionary<Bytes20, int>.LWfEyzEWiNfeXWDicOlniMFMjtUGA
	|
	|-RVA: 0xCFC600 Offset: 0xCFAC00 VA: 0x180CFC600
	|-ADictionary<Guid, object>.LWfEyzEWiNfeXWDicOlniMFMjtUGA
	|
	|-RVA: 0xCFC690 Offset: 0xCFAC90 VA: 0x180CFC690
	|-ADictionary<int, int>.LWfEyzEWiNfeXWDicOlniMFMjtUGA
	|-ADictionary<uint, int>.LWfEyzEWiNfeXWDicOlniMFMjtUGA
	|
	|-RVA: 0xCFC710 Offset: 0xCFAD10 VA: 0x180CFC710
	|-ADictionary<int, object>.LWfEyzEWiNfeXWDicOlniMFMjtUGA
	|-ADictionary<object, int>.LWfEyzEWiNfeXWDicOlniMFMjtUGA
	|-ADictionary<object, Int32Enum>.LWfEyzEWiNfeXWDicOlniMFMjtUGA
	|-ADictionary<object, object>.LWfEyzEWiNfeXWDicOlniMFMjtUGA
	|
	|-RVA: 0xDE3AD0 Offset: 0xDE20D0 VA: 0x180DE3AD0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.LWfEyzEWiNfeXWDicOlniMFMjtUGA
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void BbTUcDbgFlEEMFtXzBkiNrrNjCAcA(KeyValuePair<TKey, TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF6450 Offset: 0xCF4A50 VA: 0x180CF6450
	|-ADictionary<Bytes20, int>.BbTUcDbgFlEEMFtXzBkiNrrNjCAcA
	|
	|-RVA: 0xCF6400 Offset: 0xCF4A00 VA: 0x180CF6400
	|-ADictionary<Guid, object>.BbTUcDbgFlEEMFtXzBkiNrrNjCAcA
	|
	|-RVA: 0xCF64B0 Offset: 0xCF4AB0 VA: 0x180CF64B0
	|-ADictionary<int, int>.BbTUcDbgFlEEMFtXzBkiNrrNjCAcA
	|
	|-RVA: 0xCF63C0 Offset: 0xCF49C0 VA: 0x180CF63C0
	|-ADictionary<int, object>.BbTUcDbgFlEEMFtXzBkiNrrNjCAcA
	|
	|-RVA: 0xCF6500 Offset: 0xCF4B00 VA: 0x180CF6500
	|-ADictionary<object, int>.BbTUcDbgFlEEMFtXzBkiNrrNjCAcA
	|
	|-RVA: 0xDDFD30 Offset: 0xDDE330 VA: 0x180DDFD30
	|-ADictionary<object, Int32Enum>.BbTUcDbgFlEEMFtXzBkiNrrNjCAcA
	|
	|-RVA: 0xDDFCE0 Offset: 0xDDE2E0 VA: 0x180DDFCE0
	|-ADictionary<object, object>.BbTUcDbgFlEEMFtXzBkiNrrNjCAcA
	|
	|-RVA: 0xDDFC90 Offset: 0xDDE290 VA: 0x180DDFC90
	|-ADictionary<uint, int>.BbTUcDbgFlEEMFtXzBkiNrrNjCAcA
	|
	|-RVA: 0xDDFB20 Offset: 0xDDE120 VA: 0x180DDFB20
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BbTUcDbgFlEEMFtXzBkiNrrNjCAcA
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool XtgLCieMunHhqAcuNvuZtartLniy(KeyValuePair<TKey, TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04BC0 Offset: 0xD031C0 VA: 0x180D04BC0
	|-ADictionary<Bytes20, int>.XtgLCieMunHhqAcuNvuZtartLniy
	|
	|-RVA: 0xD04D70 Offset: 0xD03370 VA: 0x180D04D70
	|-ADictionary<Guid, object>.XtgLCieMunHhqAcuNvuZtartLniy
	|
	|-RVA: 0xD04B00 Offset: 0xD03100 VA: 0x180D04B00
	|-ADictionary<int, int>.XtgLCieMunHhqAcuNvuZtartLniy
	|-ADictionary<uint, int>.XtgLCieMunHhqAcuNvuZtartLniy
	|
	|-RVA: 0xD04CA0 Offset: 0xD032A0 VA: 0x180D04CA0
	|-ADictionary<int, object>.XtgLCieMunHhqAcuNvuZtartLniy
	|
	|-RVA: 0xD04A30 Offset: 0xD03030 VA: 0x180D04A30
	|-ADictionary<object, int>.XtgLCieMunHhqAcuNvuZtartLniy
	|-ADictionary<object, Int32Enum>.XtgLCieMunHhqAcuNvuZtartLniy
	|
	|-RVA: 0xDE9F50 Offset: 0xDE8550 VA: 0x180DE9F50
	|-ADictionary<object, object>.XtgLCieMunHhqAcuNvuZtartLniy
	|
	|-RVA: 0xDE9D00 Offset: 0xDE8300 VA: 0x180DE9D00
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.XtgLCieMunHhqAcuNvuZtartLniy
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool DzpLLfRLmEaTdnMTYVfIjxMWLoOs(KeyValuePair<TKey, TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7810 Offset: 0xCF5E10 VA: 0x180CF7810
	|-ADictionary<Bytes20, int>.DzpLLfRLmEaTdnMTYVfIjxMWLoOs
	|
	|-RVA: 0xCF7700 Offset: 0xCF5D00 VA: 0x180CF7700
	|-ADictionary<Guid, object>.DzpLLfRLmEaTdnMTYVfIjxMWLoOs
	|
	|-RVA: 0xCF7930 Offset: 0xCF5F30 VA: 0x180CF7930
	|-ADictionary<int, int>.DzpLLfRLmEaTdnMTYVfIjxMWLoOs
	|-ADictionary<uint, int>.DzpLLfRLmEaTdnMTYVfIjxMWLoOs
	|
	|-RVA: 0xCF7610 Offset: 0xCF5C10 VA: 0x180CF7610
	|-ADictionary<int, object>.DzpLLfRLmEaTdnMTYVfIjxMWLoOs
	|
	|-RVA: 0xCF7520 Offset: 0xCF5B20 VA: 0x180CF7520
	|-ADictionary<object, int>.DzpLLfRLmEaTdnMTYVfIjxMWLoOs
	|-ADictionary<object, Int32Enum>.DzpLLfRLmEaTdnMTYVfIjxMWLoOs
	|
	|-RVA: 0xDE08E0 Offset: 0xDDEEE0 VA: 0x180DE08E0
	|-ADictionary<object, object>.DzpLLfRLmEaTdnMTYVfIjxMWLoOs
	|
	|-RVA: 0xDE0610 Offset: 0xDDEC10 VA: 0x180DE0610
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DzpLLfRLmEaTdnMTYVfIjxMWLoOs
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool StyWbOPGFSEgSYmuYhDGyFTRAKHp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ADictionary<Bytes20, int>.StyWbOPGFSEgSYmuYhDGyFTRAKHp
	|-ADictionary<Guid, object>.StyWbOPGFSEgSYmuYhDGyFTRAKHp
	|-ADictionary<int, int>.StyWbOPGFSEgSYmuYhDGyFTRAKHp
	|-ADictionary<int, object>.StyWbOPGFSEgSYmuYhDGyFTRAKHp
	|-ADictionary<object, int>.StyWbOPGFSEgSYmuYhDGyFTRAKHp
	|-ADictionary<object, Int32Enum>.StyWbOPGFSEgSYmuYhDGyFTRAKHp
	|-ADictionary<object, object>.StyWbOPGFSEgSYmuYhDGyFTRAKHp
	|-ADictionary<uint, int>.StyWbOPGFSEgSYmuYhDGyFTRAKHp
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.StyWbOPGFSEgSYmuYhDGyFTRAKHp
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void aHBFkNfKKowCVnwTYMlGmanuoOKF(KeyValuePair<TKey, TValue>[] , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD07680 Offset: 0xD05C80 VA: 0x180D07680
	|-ADictionary<Bytes20, int>.aHBFkNfKKowCVnwTYMlGmanuoOKF
	|
	|-RVA: 0xD07620 Offset: 0xD05C20 VA: 0x180D07620
	|-ADictionary<Guid, object>.aHBFkNfKKowCVnwTYMlGmanuoOKF
	|
	|-RVA: 0xD076A0 Offset: 0xD05CA0 VA: 0x180D076A0
	|-ADictionary<int, int>.aHBFkNfKKowCVnwTYMlGmanuoOKF
	|-ADictionary<uint, int>.aHBFkNfKKowCVnwTYMlGmanuoOKF
	|
	|-RVA: 0xD07640 Offset: 0xD05C40 VA: 0x180D07640
	|-ADictionary<int, object>.aHBFkNfKKowCVnwTYMlGmanuoOKF
	|
	|-RVA: 0xD07660 Offset: 0xD05C60 VA: 0x180D07660
	|-ADictionary<object, int>.aHBFkNfKKowCVnwTYMlGmanuoOKF
	|-ADictionary<object, Int32Enum>.aHBFkNfKKowCVnwTYMlGmanuoOKF
	|
	|-RVA: 0xDEBE80 Offset: 0xDEA480 VA: 0x180DEBE80
	|-ADictionary<object, object>.aHBFkNfKKowCVnwTYMlGmanuoOKF
	|
	|-RVA: 0xDEBE60 Offset: 0xDEA460 VA: 0x180DEBE60
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.aHBFkNfKKowCVnwTYMlGmanuoOKF
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFEE30 Offset: 0xCFD430 VA: 0x180CFEE30
	|-ADictionary<Bytes20, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFE3E0 Offset: 0xCFC9E0 VA: 0x180CFE3E0
	|-ADictionary<Guid, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFF3C0 Offset: 0xCFD9C0 VA: 0x180CFF3C0
	|-ADictionary<int, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFDED0 Offset: 0xCFC4D0 VA: 0x180CFDED0
	|-ADictionary<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xCFE920 Offset: 0xCFCF20 VA: 0x180CFE920
	|-ADictionary<object, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xDE5780 Offset: 0xDE3D80 VA: 0x180DE5780
	|-ADictionary<object, Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xDE5C90 Offset: 0xDE4290 VA: 0x180DE5C90
	|-ADictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xDE4A10 Offset: 0xDE3010 VA: 0x180DE4A10
	|-ADictionary<uint, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xDE4F50 Offset: 0xDE3550 VA: 0x180DE4F50
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFC560 Offset: 0xCFAB60 VA: 0x180CFC560
	|-ADictionary<Bytes20, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCFC600 Offset: 0xCFAC00 VA: 0x180CFC600
	|-ADictionary<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCFC690 Offset: 0xCFAC90 VA: 0x180CFC690
	|-ADictionary<int, int>.System.Collections.IEnumerable.GetEnumerator
	|-ADictionary<uint, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCFC710 Offset: 0xCFAD10 VA: 0x180CFC710
	|-ADictionary<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-ADictionary<object, int>.System.Collections.IEnumerable.GetEnumerator
	|-ADictionary<object, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-ADictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xDE3AD0 Offset: 0xDE20D0 VA: 0x180DE3AD0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ADictionary<Bytes20, int>.System.Collections.ICollection.get_IsSynchronized
	|-ADictionary<Guid, object>.System.Collections.ICollection.get_IsSynchronized
	|-ADictionary<int, int>.System.Collections.ICollection.get_IsSynchronized
	|-ADictionary<int, object>.System.Collections.ICollection.get_IsSynchronized
	|-ADictionary<object, int>.System.Collections.ICollection.get_IsSynchronized
	|-ADictionary<object, Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-ADictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-ADictionary<uint, int>.System.Collections.ICollection.get_IsSynchronized
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	|-ADictionary<Bytes20, int>.System.Collections.ICollection.get_SyncRoot
	|-ADictionary<Guid, object>.System.Collections.ICollection.get_SyncRoot
	|-ADictionary<int, int>.System.Collections.ICollection.get_SyncRoot
	|-ADictionary<int, object>.System.Collections.ICollection.get_SyncRoot
	|-ADictionary<object, int>.System.Collections.ICollection.get_SyncRoot
	|-ADictionary<object, Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|-ADictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|-ADictionary<uint, int>.System.Collections.ICollection.get_SyncRoot
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ADictionary<Bytes20, int>.System.Collections.IDictionary.get_IsFixedSize
	|-ADictionary<Guid, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ADictionary<int, int>.System.Collections.IDictionary.get_IsFixedSize
	|-ADictionary<int, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ADictionary<object, int>.System.Collections.IDictionary.get_IsFixedSize
	|-ADictionary<object, Int32Enum>.System.Collections.IDictionary.get_IsFixedSize
	|-ADictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ADictionary<uint, int>.System.Collections.IDictionary.get_IsFixedSize
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ADictionary<Bytes20, int>.System.Collections.IDictionary.get_IsReadOnly
	|-ADictionary<Guid, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ADictionary<int, int>.System.Collections.IDictionary.get_IsReadOnly
	|-ADictionary<int, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ADictionary<object, int>.System.Collections.IDictionary.get_IsReadOnly
	|-ADictionary<object, Int32Enum>.System.Collections.IDictionary.get_IsReadOnly
	|-ADictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ADictionary<uint, int>.System.Collections.IDictionary.get_IsReadOnly
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD01CF0 Offset: 0xD002F0 VA: 0x180D01CF0
	|-ADictionary<Bytes20, int>.System.Collections.IDictionary.get_Keys
	|-ADictionary<Guid, object>.System.Collections.IDictionary.get_Keys
	|-ADictionary<int, int>.System.Collections.IDictionary.get_Keys
	|-ADictionary<int, object>.System.Collections.IDictionary.get_Keys
	|-ADictionary<object, int>.System.Collections.IDictionary.get_Keys
	|-ADictionary<object, Int32Enum>.System.Collections.IDictionary.get_Keys
	|-ADictionary<object, object>.System.Collections.IDictionary.get_Keys
	|-ADictionary<uint, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xDE73B0 Offset: 0xDE59B0 VA: 0x180DE73B0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFCA20 Offset: 0xCFB020 VA: 0x180CFCA20
	|-ADictionary<Bytes20, int>.System.Collections.IDictionary.get_Values
	|-ADictionary<Guid, object>.System.Collections.IDictionary.get_Values
	|-ADictionary<int, int>.System.Collections.IDictionary.get_Values
	|-ADictionary<int, object>.System.Collections.IDictionary.get_Values
	|-ADictionary<object, int>.System.Collections.IDictionary.get_Values
	|-ADictionary<object, Int32Enum>.System.Collections.IDictionary.get_Values
	|-ADictionary<object, object>.System.Collections.IDictionary.get_Values
	|-ADictionary<uint, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xD41A90 Offset: 0xD40090 VA: 0x180D41A90
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD01670 Offset: 0xCFFC70 VA: 0x180D01670
	|-ADictionary<Bytes20, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xD01B60 Offset: 0xD00160 VA: 0x180D01B60
	|-ADictionary<Guid, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xD014C0 Offset: 0xCFFAC0 VA: 0x180D014C0
	|-ADictionary<int, int>.System.Collections.IDictionary.get_Item
	|-ADictionary<uint, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xD019E0 Offset: 0xCFFFE0 VA: 0x180D019E0
	|-ADictionary<int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xD01830 Offset: 0xCFFE30 VA: 0x180D01830
	|-ADictionary<object, int>.System.Collections.IDictionary.get_Item
	|-ADictionary<object, Int32Enum>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xDE7000 Offset: 0xDE5600 VA: 0x180DE7000
	|-ADictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xDE7190 Offset: 0xDE5790 VA: 0x180DE7190
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD023C0 Offset: 0xD009C0 VA: 0x180D023C0
	|-ADictionary<Bytes20, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xD01D10 Offset: 0xD00310 VA: 0x180D01D10
	|-ADictionary<Guid, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xD02190 Offset: 0xD00790 VA: 0x180D02190
	|-ADictionary<int, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xD01F60 Offset: 0xD00560 VA: 0x180D01F60
	|-ADictionary<int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xD02620 Offset: 0xD00C20 VA: 0x180D02620
	|-ADictionary<object, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xDE7700 Offset: 0xDE5D00 VA: 0x180DE7700
	|-ADictionary<object, Int32Enum>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xDE7B70 Offset: 0xDE6170 VA: 0x180DE7B70
	|-ADictionary<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xDE7940 Offset: 0xDE5F40 VA: 0x180DE7940
	|-ADictionary<uint, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xDE73E0 Offset: 0xDE59E0 VA: 0x180DE73E0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFFD80 Offset: 0xCFE380 VA: 0x180CFFD80
	|-ADictionary<Bytes20, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xCFFB30 Offset: 0xCFE130 VA: 0x180CFFB30
	|-ADictionary<Guid, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xCFF900 Offset: 0xCFDF00 VA: 0x180CFF900
	|-ADictionary<int, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xCFFFE0 Offset: 0xCFE5E0 VA: 0x180CFFFE0
	|-ADictionary<int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xD00210 Offset: 0xCFE810 VA: 0x180D00210
	|-ADictionary<object, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xDE68F0 Offset: 0xDE4EF0 VA: 0x180DE68F0
	|-ADictionary<object, Int32Enum>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xDE6170 Offset: 0xDE4770 VA: 0x180DE6170
	|-ADictionary<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xDE63A0 Offset: 0xDE49A0 VA: 0x180DE63A0
	|-ADictionary<uint, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xDE65D0 Offset: 0xDE4BD0 VA: 0x180DE65D0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD00730 Offset: 0xCFED30 VA: 0x180D00730
	|-ADictionary<Bytes20, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xD00A20 Offset: 0xCFF020 VA: 0x180D00A20
	|-ADictionary<Guid, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xD005C0 Offset: 0xCFEBC0 VA: 0x180D005C0
	|-ADictionary<int, int>.System.Collections.IDictionary.Contains
	|-ADictionary<uint, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xD008B0 Offset: 0xCFEEB0 VA: 0x180D008B0
	|-ADictionary<int, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xD00450 Offset: 0xCFEA50 VA: 0x180D00450
	|-ADictionary<object, int>.System.Collections.IDictionary.Contains
	|-ADictionary<object, Int32Enum>.System.Collections.IDictionary.Contains
	|-ADictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xDE6B30 Offset: 0xDE5130 VA: 0x180DE6B30
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD00D30 Offset: 0xCFF330 VA: 0x180D00D30
	|-ADictionary<Bytes20, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xD00CA0 Offset: 0xCFF2A0 VA: 0x180D00CA0
	|-ADictionary<Guid, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xD00C20 Offset: 0xCFF220 VA: 0x180D00C20
	|-ADictionary<int, int>.System.Collections.IDictionary.GetEnumerator
	|-ADictionary<uint, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xD00B90 Offset: 0xCFF190 VA: 0x180D00B90
	|-ADictionary<int, object>.System.Collections.IDictionary.GetEnumerator
	|-ADictionary<object, int>.System.Collections.IDictionary.GetEnumerator
	|-ADictionary<object, Int32Enum>.System.Collections.IDictionary.GetEnumerator
	|-ADictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xDE6C90 Offset: 0xDE5290 VA: 0x180DE6C90
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD00F30 Offset: 0xCFF530 VA: 0x180D00F30
	|-ADictionary<Bytes20, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xD01360 Offset: 0xCFF960 VA: 0x180D01360
	|-ADictionary<Guid, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xD01200 Offset: 0xCFF800 VA: 0x180D01200
	|-ADictionary<int, int>.System.Collections.IDictionary.Remove
	|-ADictionary<uint, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xD00DD0 Offset: 0xCFF3D0 VA: 0x180D00DD0
	|-ADictionary<int, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xD010A0 Offset: 0xCFF6A0 VA: 0x180D010A0
	|-ADictionary<object, int>.System.Collections.IDictionary.Remove
	|-ADictionary<object, Int32Enum>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xDE6D50 Offset: 0xDE5350 VA: 0x180DE6D50
	|-ADictionary<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xDE6EB0 Offset: 0xDE54B0 VA: 0x180DE6EB0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 37
	private ICollection<TKey> UpodxQmbfbmYnyywCFcPFZmJSDAW() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD01CF0 Offset: 0xD002F0 VA: 0x180D01CF0
	|-ADictionary<Bytes20, int>.UpodxQmbfbmYnyywCFcPFZmJSDAW
	|-ADictionary<Guid, object>.UpodxQmbfbmYnyywCFcPFZmJSDAW
	|-ADictionary<int, int>.UpodxQmbfbmYnyywCFcPFZmJSDAW
	|-ADictionary<int, object>.UpodxQmbfbmYnyywCFcPFZmJSDAW
	|-ADictionary<object, int>.UpodxQmbfbmYnyywCFcPFZmJSDAW
	|-ADictionary<object, Int32Enum>.UpodxQmbfbmYnyywCFcPFZmJSDAW
	|-ADictionary<object, object>.UpodxQmbfbmYnyywCFcPFZmJSDAW
	|-ADictionary<uint, int>.UpodxQmbfbmYnyywCFcPFZmJSDAW
	|
	|-RVA: 0xDE73B0 Offset: 0xDE59B0 VA: 0x180DE73B0
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.UpodxQmbfbmYnyywCFcPFZmJSDAW
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private ICollection<TValue> RMYBQUjabhituROOAgoSfZjyzrYv() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFCA20 Offset: 0xCFB020 VA: 0x180CFCA20
	|-ADictionary<Bytes20, int>.RMYBQUjabhituROOAgoSfZjyzrYv
	|-ADictionary<Guid, object>.RMYBQUjabhituROOAgoSfZjyzrYv
	|-ADictionary<int, int>.RMYBQUjabhituROOAgoSfZjyzrYv
	|-ADictionary<int, object>.RMYBQUjabhituROOAgoSfZjyzrYv
	|-ADictionary<object, int>.RMYBQUjabhituROOAgoSfZjyzrYv
	|-ADictionary<object, Int32Enum>.RMYBQUjabhituROOAgoSfZjyzrYv
	|-ADictionary<object, object>.RMYBQUjabhituROOAgoSfZjyzrYv
	|-ADictionary<uint, int>.RMYBQUjabhituROOAgoSfZjyzrYv
	|
	|-RVA: 0xD41A90 Offset: 0xD40090 VA: 0x180D41A90
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RMYBQUjabhituROOAgoSfZjyzrYv
	*/

	// RVA: -1 Offset: -1
	private static bool briRalGxqiyVaDjeaxisVBQmEVyG(object ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD076C0 Offset: 0xD05CC0 VA: 0x180D076C0
	|-ADictionary<Bytes20, int>.briRalGxqiyVaDjeaxisVBQmEVyG
	|-ADictionary<Guid, object>.briRalGxqiyVaDjeaxisVBQmEVyG
	|-ADictionary<int, int>.briRalGxqiyVaDjeaxisVBQmEVyG
	|-ADictionary<int, object>.briRalGxqiyVaDjeaxisVBQmEVyG
	|-ADictionary<object, int>.briRalGxqiyVaDjeaxisVBQmEVyG
	|-ADictionary<object, Int32Enum>.briRalGxqiyVaDjeaxisVBQmEVyG
	|-ADictionary<object, object>.briRalGxqiyVaDjeaxisVBQmEVyG
	|-ADictionary<uint, int>.briRalGxqiyVaDjeaxisVBQmEVyG
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.briRalGxqiyVaDjeaxisVBQmEVyG
	*/

	// RVA: -1 Offset: -1
	private static void hnNmbeVXfHFzZrkMwBfBUGptRLKq<>(object , string ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EFDB0 Offset: 0x5EE3B0 VA: 0x1805EFDB0
	|-ADictionary<Bytes20, int>.hnNmbeVXfHFzZrkMwBfBUGptRLKq<int>
	|-ADictionary<int, int>.hnNmbeVXfHFzZrkMwBfBUGptRLKq<int>
	|-ADictionary<object, int>.hnNmbeVXfHFzZrkMwBfBUGptRLKq<int>
	|-ADictionary<object, Int32Enum>.hnNmbeVXfHFzZrkMwBfBUGptRLKq<Int32Enum>
	|-ADictionary<uint, int>.hnNmbeVXfHFzZrkMwBfBUGptRLKq<int>
	|
	|-RVA: 0x5EFE00 Offset: 0x5EE400 VA: 0x1805EFE00
	|-ADictionary<Guid, object>.hnNmbeVXfHFzZrkMwBfBUGptRLKq<object>
	|-ADictionary<int, object>.hnNmbeVXfHFzZrkMwBfBUGptRLKq<object>
	|-ADictionary<object, object>.hnNmbeVXfHFzZrkMwBfBUGptRLKq<object>
	|
	|-RVA: 0x5EFC90 Offset: 0x5EE290 VA: 0x1805EFC90
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.hnNmbeVXfHFzZrkMwBfBUGptRLKq<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04E50 Offset: 0xD03450 VA: 0x180D04E50
	|-ADictionary<Bytes20, int>..cctor
	|-ADictionary<Guid, object>..cctor
	|-ADictionary<int, int>..cctor
	|-ADictionary<int, object>..cctor
	|-ADictionary<object, int>..cctor
	|-ADictionary<object, Int32Enum>..cctor
	|-ADictionary<object, object>..cctor
	|-ADictionary<uint, int>..cctor
	|-ADictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class IndexedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyList<TValue>, IReadOnlyList // TypeDefIndex: 2984
{
	// Fields
	private static readonly bool APAUgjOihDwVuNhbdtEtrhRnFRcD; // 0x0
	private static readonly bool yxMXYuZMOcWvVOjWSBdqecXvzjsx; // 0x0
	private IEqualityComparer<TKey> jCpZsdwzMHCQtthMDJxwRhIAbROd; // 0x0
	private IEqualityComparer<TValue> VHqbJbiWDaFMvLJqeZMScPQDZLNuA; // 0x0
	private readonly AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<TKey, TValue>> PNrzXRLKBlfpwlwoucUZVHmbphVA; // 0x0
	private readonly ADictionary<TKey, int> vHAesMCizyjHQSWVeIOQxGhnMIrx; // 0x0
	private bool NbzBSunvEVlTOAfDjqMGuqPJXraV; // 0x0

	// Properties
	public int Count { get; }
	public bool ContainsDuplicateKeys { get; }
	public bool AllowDuplicateKeys { get; set; }
	public TValue Item { get; set; }
	public IEqualityComparer<TKey> KeyComparer { get; set; }
	public IEqualityComparer<TValue> ValueComparer { get; set; }
	public ICollection<TKey> Keys { get; }
	public ICollection<TValue> Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item { get; set; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private TValue Rewired.Utils.Interfaces.IReadOnlyList<TValue>.Item { get; }
	private int Rewired.Utils.Interfaces.IReadOnlyList.Count { get; }
	private object Rewired.Utils.Interfaces.IReadOnlyList.Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 33
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109D290 Offset: 0x109B890 VA: 0x18109D290
	|-IndexedDictionary<Bytes20, object>.get_Count
	|-IndexedDictionary<int, object>.get_Count
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.get_Count
	|-IndexedDictionary<uint, object>.get_Count
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_ContainsDuplicateKeys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109FDF0 Offset: 0x109E3F0 VA: 0x18109FDF0
	|-IndexedDictionary<Bytes20, object>.get_ContainsDuplicateKeys
	|-IndexedDictionary<int, object>.get_ContainsDuplicateKeys
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.get_ContainsDuplicateKeys
	|-IndexedDictionary<uint, object>.get_ContainsDuplicateKeys
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ContainsDuplicateKeys
	*/

	// RVA: -1 Offset: -1
	public bool get_AllowDuplicateKeys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	|-IndexedDictionary<Bytes20, object>.get_AllowDuplicateKeys
	|-IndexedDictionary<int, object>.get_AllowDuplicateKeys
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.get_AllowDuplicateKeys
	|-IndexedDictionary<uint, object>.get_AllowDuplicateKeys
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_AllowDuplicateKeys
	*/

	// RVA: -1 Offset: -1
	public void set_AllowDuplicateKeys(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A0450 Offset: 0x109EA50 VA: 0x1810A0450
	|-IndexedDictionary<Bytes20, object>.set_AllowDuplicateKeys
	|-IndexedDictionary<int, object>.set_AllowDuplicateKeys
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.set_AllowDuplicateKeys
	|-IndexedDictionary<uint, object>.set_AllowDuplicateKeys
	|
	|-RVA: 0x10A6270 Offset: 0x10A4870 VA: 0x1810A6270
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_AllowDuplicateKeys
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109D8E0 Offset: 0x109BEE0 VA: 0x18109D8E0
	|-IndexedDictionary<Bytes20, object>..ctor
	|
	|-RVA: 0x109DB40 Offset: 0x109C140 VA: 0x18109DB40
	|-IndexedDictionary<int, object>..ctor
	|
	|-RVA: 0x109DAE0 Offset: 0x109C0E0 VA: 0x18109DAE0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>..ctor
	|
	|-RVA: 0x109D8C0 Offset: 0x109BEC0 VA: 0x18109D8C0
	|-IndexedDictionary<uint, object>..ctor
	|
	|-RVA: 0x10A4BF0 Offset: 0x10A31F0 VA: 0x1810A4BF0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109EED0 Offset: 0x109D4D0 VA: 0x18109EED0
	|-IndexedDictionary<Bytes20, object>..ctor
	|
	|-RVA: 0x109DB20 Offset: 0x109C120 VA: 0x18109DB20
	|-IndexedDictionary<int, object>..ctor
	|
	|-RVA: 0x109DF20 Offset: 0x109C520 VA: 0x18109DF20
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>..ctor
	|
	|-RVA: 0x109E0C0 Offset: 0x109C6C0 VA: 0x18109E0C0
	|-IndexedDictionary<uint, object>..ctor
	|
	|-RVA: 0x10A5400 Offset: 0x10A3A00 VA: 0x1810A5400
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109DAA0 Offset: 0x109C0A0 VA: 0x18109DAA0
	|-IndexedDictionary<Bytes20, object>..ctor
	|
	|-RVA: 0x109EEB0 Offset: 0x109D4B0 VA: 0x18109EEB0
	|-IndexedDictionary<int, object>..ctor
	|
	|-RVA: 0x109DA80 Offset: 0x109C080 VA: 0x18109DA80
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>..ctor
	|
	|-RVA: 0x109D8A0 Offset: 0x109BEA0 VA: 0x18109D8A0
	|-IndexedDictionary<uint, object>..ctor
	|
	|-RVA: 0x10A4BD0 Offset: 0x10A31D0 VA: 0x1810A4BD0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109E800 Offset: 0x109CE00 VA: 0x18109E800
	|-IndexedDictionary<Bytes20, object>..ctor
	|
	|-RVA: 0x109D900 Offset: 0x109BF00 VA: 0x18109D900
	|-IndexedDictionary<int, object>..ctor
	|
	|-RVA: 0x109DF40 Offset: 0x109C540 VA: 0x18109DF40
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>..ctor
	|
	|-RVA: 0x109ED10 Offset: 0x109D310 VA: 0x18109ED10
	|-IndexedDictionary<uint, object>..ctor
	|
	|-RVA: 0x10A4C10 Offset: 0x10A3210 VA: 0x1810A4C10
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109DB00 Offset: 0x109C100 VA: 0x18109DB00
	|-IndexedDictionary<Bytes20, object>..ctor
	|
	|-RVA: 0x109EE90 Offset: 0x109D490 VA: 0x18109EE90
	|-IndexedDictionary<int, object>..ctor
	|
	|-RVA: 0x109E980 Offset: 0x109CF80 VA: 0x18109E980
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>..ctor
	|
	|-RVA: 0x109DAC0 Offset: 0x109C0C0 VA: 0x18109DAC0
	|-IndexedDictionary<uint, object>..ctor
	|
	|-RVA: 0x10A4BB0 Offset: 0x10A31B0 VA: 0x1810A4BB0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109E0E0 Offset: 0x109C6E0 VA: 0x18109E0E0
	|-IndexedDictionary<Bytes20, object>..ctor
	|
	|-RVA: 0x109E9A0 Offset: 0x109CFA0 VA: 0x18109E9A0
	|-IndexedDictionary<int, object>..ctor
	|
	|-RVA: 0x109DB60 Offset: 0x109C160 VA: 0x18109DB60
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>..ctor
	|
	|-RVA: 0x109E490 Offset: 0x109CA90 VA: 0x18109E490
	|-IndexedDictionary<uint, object>..ctor
	|
	|-RVA: 0x10A4DB0 Offset: 0x10A33B0 VA: 0x1810A4DB0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109FF60 Offset: 0x109E560 VA: 0x18109FF60
	|-IndexedDictionary<Bytes20, object>.get_Item
	|
	|-RVA: 0x109FED0 Offset: 0x109E4D0 VA: 0x18109FED0
	|-IndexedDictionary<int, object>.get_Item
	|-IndexedDictionary<uint, object>.get_Item
	|
	|-RVA: 0x109FE30 Offset: 0x109E430 VA: 0x18109FE30
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.get_Item
	|
	|-RVA: 0x10A5D40 Offset: 0x10A4340 VA: 0x1810A5D40
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A0520 Offset: 0x109EB20 VA: 0x1810A0520
	|-IndexedDictionary<Bytes20, object>.set_Item
	|
	|-RVA: 0x10A05D0 Offset: 0x109EBD0 VA: 0x1810A05D0
	|-IndexedDictionary<int, object>.set_Item
	|-IndexedDictionary<uint, object>.set_Item
	|
	|-RVA: 0x10A0460 Offset: 0x109EA60 VA: 0x1810A0460
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.set_Item
	|
	|-RVA: 0x10A6300 Offset: 0x10A4900 VA: 0x1810A6300
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<TKey> get_KeyComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-IndexedDictionary<Bytes20, object>.get_KeyComparer
	|-IndexedDictionary<int, object>.get_KeyComparer
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.get_KeyComparer
	|-IndexedDictionary<uint, object>.get_KeyComparer
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_KeyComparer
	*/

	// RVA: -1 Offset: -1
	public void set_KeyComparer(IEqualityComparer<TKey> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A0680 Offset: 0x109EC80 VA: 0x1810A0680
	|-IndexedDictionary<Bytes20, object>.set_KeyComparer
	|
	|-RVA: 0x10A0700 Offset: 0x109ED00 VA: 0x1810A0700
	|-IndexedDictionary<int, object>.set_KeyComparer
	|
	|-RVA: 0x10A06C0 Offset: 0x109ECC0 VA: 0x1810A06C0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.set_KeyComparer
	|
	|-RVA: 0x10A0740 Offset: 0x109ED40 VA: 0x1810A0740
	|-IndexedDictionary<uint, object>.set_KeyComparer
	|
	|-RVA: 0x10A6460 Offset: 0x10A4A60 VA: 0x1810A6460
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_KeyComparer
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<TValue> get_ValueComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-IndexedDictionary<Bytes20, object>.get_ValueComparer
	|-IndexedDictionary<int, object>.get_ValueComparer
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.get_ValueComparer
	|-IndexedDictionary<uint, object>.get_ValueComparer
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ValueComparer
	*/

	// RVA: -1 Offset: -1
	public void set_ValueComparer(IEqualityComparer<TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A0780 Offset: 0x109ED80 VA: 0x1810A0780
	|-IndexedDictionary<Bytes20, object>.set_ValueComparer
	|-IndexedDictionary<int, object>.set_ValueComparer
	|-IndexedDictionary<uint, object>.set_ValueComparer
	|
	|-RVA: 0x10A07C0 Offset: 0x109EDC0 VA: 0x1810A07C0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.set_ValueComparer
	|
	|-RVA: 0x10A64B0 Offset: 0x10A4AB0 VA: 0x1810A64B0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_ValueComparer
	*/

	// RVA: -1 Offset: -1
	public TValue GetValue(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1098480 Offset: 0x1096A80 VA: 0x181098480
	|-IndexedDictionary<Bytes20, object>.GetValue
	|
	|-RVA: 0x10983A0 Offset: 0x10969A0 VA: 0x1810983A0
	|-IndexedDictionary<int, object>.GetValue
	|
	|-RVA: 0x1098400 Offset: 0x1096A00 VA: 0x181098400
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.GetValue
	|
	|-RVA: 0x1098500 Offset: 0x1096B00 VA: 0x181098500
	|-IndexedDictionary<uint, object>.GetValue
	|
	|-RVA: 0x10A1C40 Offset: 0x10A0240 VA: 0x1810A1C40
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109D1D0 Offset: 0x109B7D0 VA: 0x18109D1D0
	|-IndexedDictionary<Bytes20, object>.TryGetValue
	|
	|-RVA: 0x109D130 Offset: 0x109B730 VA: 0x18109D130
	|-IndexedDictionary<int, object>.TryGetValue
	|-IndexedDictionary<uint, object>.TryGetValue
	|
	|-RVA: 0x109D070 Offset: 0x109B670 VA: 0x18109D070
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.TryGetValue
	|
	|-RVA: 0x10A47E0 Offset: 0x10A2DE0 VA: 0x1810A47E0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TKey GetKeyAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10981C0 Offset: 0x10967C0 VA: 0x1810981C0
	|-IndexedDictionary<Bytes20, object>.GetKeyAt
	|
	|-RVA: 0x1098310 Offset: 0x1096910 VA: 0x181098310
	|-IndexedDictionary<int, object>.GetKeyAt
	|-IndexedDictionary<uint, object>.GetKeyAt
	|
	|-RVA: 0x1098270 Offset: 0x1096870 VA: 0x181098270
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.GetKeyAt
	|
	|-RVA: 0x10A1AA0 Offset: 0x10A00A0 VA: 0x1810A1AA0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeyAt
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<TKey, TValue> GetEntry(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1097E20 Offset: 0x1096420 VA: 0x181097E20
	|-IndexedDictionary<Bytes20, object>.GetEntry
	|
	|-RVA: 0x1097FD0 Offset: 0x10965D0 VA: 0x181097FD0
	|-IndexedDictionary<int, object>.GetEntry
	|
	|-RVA: 0x1097F00 Offset: 0x1096500 VA: 0x181097F00
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.GetEntry
	|
	|-RVA: 0x1097D60 Offset: 0x1096360 VA: 0x181097D60
	|-IndexedDictionary<uint, object>.GetEntry
	|
	|-RVA: 0x10A1750 Offset: 0x109FD50 VA: 0x1810A1750
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEntry
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<TKey, TValue> GetEntryAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1097C80 Offset: 0x1096280 VA: 0x181097C80
	|-IndexedDictionary<Bytes20, object>.GetEntryAt
	|
	|-RVA: 0x1097BB0 Offset: 0x10961B0 VA: 0x181097BB0
	|-IndexedDictionary<int, object>.GetEntryAt
	|-IndexedDictionary<uint, object>.GetEntryAt
	|
	|-RVA: 0x1097AD0 Offset: 0x10960D0 VA: 0x181097AD0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.GetEntryAt
	|
	|-RVA: 0x10A1570 Offset: 0x109FB70 VA: 0x1810A1570
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEntryAt
	*/

	// RVA: -1 Offset: -1
	public bool TryGetEntry(TKey key, out KeyValuePair<TKey, TValue> entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109CF40 Offset: 0x109B540 VA: 0x18109CF40
	|-IndexedDictionary<Bytes20, object>.TryGetEntry
	|
	|-RVA: 0x109CD40 Offset: 0x109B340 VA: 0x18109CD40
	|-IndexedDictionary<int, object>.TryGetEntry
	|-IndexedDictionary<uint, object>.TryGetEntry
	|
	|-RVA: 0x109CE30 Offset: 0x109B430 VA: 0x18109CE30
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.TryGetEntry
	|
	|-RVA: 0x10A4510 Offset: 0x10A2B10 VA: 0x1810A4510
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetEntry
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1097130 Offset: 0x1095730 VA: 0x181097130
	|-IndexedDictionary<Bytes20, object>.Add
	|
	|-RVA: 0x1096F70 Offset: 0x1095570 VA: 0x181096F70
	|-IndexedDictionary<int, object>.Add
	|
	|-RVA: 0x1097370 Offset: 0x1095970 VA: 0x181097370
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.Add
	|
	|-RVA: 0x1097550 Offset: 0x1095B50 VA: 0x181097550
	|-IndexedDictionary<uint, object>.Add
	|
	|-RVA: 0x10A0BC0 Offset: 0x109F1C0 VA: 0x1810A0BC0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void SetValue(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109AED0 Offset: 0x10994D0 VA: 0x18109AED0
	|-IndexedDictionary<Bytes20, object>.SetValue
	|
	|-RVA: 0x109ABA0 Offset: 0x10991A0 VA: 0x18109ABA0
	|-IndexedDictionary<int, object>.SetValue
	|
	|-RVA: 0x109ADA0 Offset: 0x10993A0 VA: 0x18109ADA0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.SetValue
	|
	|-RVA: 0x109ACA0 Offset: 0x10992A0 VA: 0x18109ACA0
	|-IndexedDictionary<uint, object>.SetValue
	|
	|-RVA: 0x10A3330 Offset: 0x10A1930 VA: 0x1810A3330
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109A930 Offset: 0x1098F30 VA: 0x18109A930
	|-IndexedDictionary<Bytes20, object>.Remove
	|
	|-RVA: 0x109A550 Offset: 0x1098B50 VA: 0x18109A550
	|-IndexedDictionary<int, object>.Remove
	|
	|-RVA: 0x109A740 Offset: 0x1098D40 VA: 0x18109A740
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.Remove
	|
	|-RVA: 0x109A360 Offset: 0x1098960 VA: 0x18109A360
	|-IndexedDictionary<uint, object>.Remove
	|
	|-RVA: 0x10A2FD0 Offset: 0x10A15D0 VA: 0x1810A2FD0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1099E30 Offset: 0x1098430 VA: 0x181099E30
	|-IndexedDictionary<Bytes20, object>.RemoveAt
	|
	|-RVA: 0x1099CA0 Offset: 0x10982A0 VA: 0x181099CA0
	|-IndexedDictionary<int, object>.RemoveAt
	|
	|-RVA: 0x1099B10 Offset: 0x1098110 VA: 0x181099B10
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.RemoveAt
	|
	|-RVA: 0x109A000 Offset: 0x1098600 VA: 0x18109A000
	|-IndexedDictionary<uint, object>.RemoveAt
	|
	|-RVA: 0x10A2B30 Offset: 0x10A1130 VA: 0x1810A2B30
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109A270 Offset: 0x1098870 VA: 0x18109A270
	|-IndexedDictionary<Bytes20, object>.RemoveValue
	|
	|-RVA: 0x109A190 Offset: 0x1098790 VA: 0x18109A190
	|-IndexedDictionary<int, object>.RemoveValue
	|
	|-RVA: 0x109A2E0 Offset: 0x10988E0 VA: 0x18109A2E0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.RemoveValue
	|
	|-RVA: 0x109A200 Offset: 0x1098800 VA: 0x18109A200
	|-IndexedDictionary<uint, object>.RemoveValue
	|
	|-RVA: 0x10A2EA0 Offset: 0x10A14A0 VA: 0x1810A2EA0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveValue
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1099990 Offset: 0x1097F90 VA: 0x181099990
	|-IndexedDictionary<Bytes20, object>.RemoveAll
	|
	|-RVA: 0x1099660 Offset: 0x1097C60 VA: 0x181099660
	|-IndexedDictionary<int, object>.RemoveAll
	|
	|-RVA: 0x10997E0 Offset: 0x1097DE0 VA: 0x1810997E0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.RemoveAll
	|
	|-RVA: 0x10994E0 Offset: 0x1097AE0 VA: 0x1810994E0
	|-IndexedDictionary<uint, object>.RemoveAll
	|
	|-RVA: 0x10A2910 Offset: 0x10A0F10 VA: 0x1810A2910
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public int IndexOfKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1098840 Offset: 0x1096E40 VA: 0x181098840
	|-IndexedDictionary<Bytes20, object>.IndexOfKey
	|
	|-RVA: 0x1098560 Offset: 0x1096B60 VA: 0x181098560
	|-IndexedDictionary<int, object>.IndexOfKey
	|-IndexedDictionary<uint, object>.IndexOfKey
	|
	|-RVA: 0x10986A0 Offset: 0x1096CA0 VA: 0x1810986A0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.IndexOfKey
	|
	|-RVA: 0x10A1E00 Offset: 0x10A0400 VA: 0x1810A1E00
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOfKey
	*/

	// RVA: -1 Offset: -1
	public int IndexOfValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1098CF0 Offset: 0x10972F0 VA: 0x181098CF0
	|-IndexedDictionary<Bytes20, object>.IndexOfValue
	|
	|-RVA: 0x1098A60 Offset: 0x1097060 VA: 0x181098A60
	|-IndexedDictionary<int, object>.IndexOfValue
	|-IndexedDictionary<uint, object>.IndexOfValue
	|
	|-RVA: 0x1098B50 Offset: 0x1097150 VA: 0x181098B50
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.IndexOfValue
	|
	|-RVA: 0x10A20E0 Offset: 0x10A06E0 VA: 0x1810A20E0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOfValue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10977A0 Offset: 0x1095DA0 VA: 0x1810977A0
	|-IndexedDictionary<Bytes20, object>.ContainsKey
	|
	|-RVA: 0x1097770 Offset: 0x1095D70 VA: 0x181097770
	|-IndexedDictionary<int, object>.ContainsKey
	|-IndexedDictionary<uint, object>.ContainsKey
	|
	|-RVA: 0x10977F0 Offset: 0x1095DF0 VA: 0x1810977F0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.ContainsKey
	|
	|-RVA: 0x10A1270 Offset: 0x109F870 VA: 0x1810A1270
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1097820 Offset: 0x1095E20 VA: 0x181097820
	|-IndexedDictionary<Bytes20, object>.ContainsValue
	|
	|-RVA: 0x1097850 Offset: 0x1095E50 VA: 0x181097850
	|-IndexedDictionary<int, object>.ContainsValue
	|-IndexedDictionary<uint, object>.ContainsValue
	|
	|-RVA: 0x1097880 Offset: 0x1095E80 VA: 0x181097880
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.ContainsValue
	|
	|-RVA: 0x10A1370 Offset: 0x109F970 VA: 0x1810A1370
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1097710 Offset: 0x1095D10 VA: 0x181097710
	|-IndexedDictionary<Bytes20, object>.Clear
	|-IndexedDictionary<int, object>.Clear
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.Clear
	|-IndexedDictionary<uint, object>.Clear
	|
	|-RVA: 0x10A1200 Offset: 0x109F800 VA: 0x1810A1200
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109CCE0 Offset: 0x109B2E0 VA: 0x18109CCE0
	|-IndexedDictionary<Bytes20, object>.TrimExcess
	|
	|-RVA: 0x109CC80 Offset: 0x109B280 VA: 0x18109CC80
	|-IndexedDictionary<int, object>.TrimExcess
	|
	|-RVA: 0x109CD10 Offset: 0x109B310 VA: 0x18109CD10
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.TrimExcess
	|
	|-RVA: 0x109CCB0 Offset: 0x109B2B0 VA: 0x18109CCB0
	|-IndexedDictionary<uint, object>.TrimExcess
	|
	|-RVA: 0x10A44E0 Offset: 0x10A2AE0 VA: 0x1810A44E0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TrimExcess
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109C690 Offset: 0x109AC90 VA: 0x18109C690
	|-IndexedDictionary<Bytes20, object>.get_Keys
	|-IndexedDictionary<int, object>.get_Keys
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.get_Keys
	|-IndexedDictionary<uint, object>.get_Keys
	|
	|-RVA: 0x10A41C0 Offset: 0x10A27C0 VA: 0x1810A41C0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109C710 Offset: 0x109AD10 VA: 0x18109C710
	|-IndexedDictionary<Bytes20, object>.get_Values
	|-IndexedDictionary<int, object>.get_Values
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.get_Values
	|-IndexedDictionary<uint, object>.get_Values
	|
	|-RVA: 0x10A4240 Offset: 0x10A2840 VA: 0x1810A4240
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void NltgMDiqFpNLsMOaJXUHIZwMeZXwA(KeyValuePair<TKey, TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1098E60 Offset: 0x1097460 VA: 0x181098E60
	|-IndexedDictionary<Bytes20, object>.NltgMDiqFpNLsMOaJXUHIZwMeZXwA
	|
	|-RVA: 0x1098E40 Offset: 0x1097440 VA: 0x181098E40
	|-IndexedDictionary<int, object>.NltgMDiqFpNLsMOaJXUHIZwMeZXwA
	|
	|-RVA: 0x1098E00 Offset: 0x1097400 VA: 0x181098E00
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.NltgMDiqFpNLsMOaJXUHIZwMeZXwA
	|
	|-RVA: 0x1098DE0 Offset: 0x10973E0 VA: 0x181098DE0
	|-IndexedDictionary<uint, object>.NltgMDiqFpNLsMOaJXUHIZwMeZXwA
	|
	|-RVA: 0x10A22E0 Offset: 0x10A08E0 VA: 0x1810A22E0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.NltgMDiqFpNLsMOaJXUHIZwMeZXwA
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool jTQpTjaQDagGRKMZDAOjsdkJBQDk(KeyValuePair<TKey, TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A0100 Offset: 0x109E700 VA: 0x1810A0100
	|-IndexedDictionary<Bytes20, object>.jTQpTjaQDagGRKMZDAOjsdkJBQDk
	|
	|-RVA: 0x10A0370 Offset: 0x109E970 VA: 0x1810A0370
	|-IndexedDictionary<int, object>.jTQpTjaQDagGRKMZDAOjsdkJBQDk
	|-IndexedDictionary<uint, object>.jTQpTjaQDagGRKMZDAOjsdkJBQDk
	|
	|-RVA: 0x10A0200 Offset: 0x109E800 VA: 0x1810A0200
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.jTQpTjaQDagGRKMZDAOjsdkJBQDk
	|
	|-RVA: 0x10A5F50 Offset: 0x10A4550 VA: 0x1810A5F50
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.jTQpTjaQDagGRKMZDAOjsdkJBQDk
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void QChkxvuvABKPfdeoLZgEoGkmkkwV(KeyValuePair<TKey, TValue>[] , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1099090 Offset: 0x1097690 VA: 0x181099090
	|-IndexedDictionary<Bytes20, object>.QChkxvuvABKPfdeoLZgEoGkmkkwV
	|
	|-RVA: 0x1098EA0 Offset: 0x10974A0 VA: 0x181098EA0
	|-IndexedDictionary<int, object>.QChkxvuvABKPfdeoLZgEoGkmkkwV
	|-IndexedDictionary<uint, object>.QChkxvuvABKPfdeoLZgEoGkmkkwV
	|
	|-RVA: 0x10992C0 Offset: 0x10978C0 VA: 0x1810992C0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.QChkxvuvABKPfdeoLZgEoGkmkkwV
	|
	|-RVA: 0x10A2460 Offset: 0x10A0A60 VA: 0x1810A2460
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.QChkxvuvABKPfdeoLZgEoGkmkkwV
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool eGZvDyIjcNBMWfMnSFGJnLWwfAjJ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-IndexedDictionary<Bytes20, object>.eGZvDyIjcNBMWfMnSFGJnLWwfAjJ
	|-IndexedDictionary<int, object>.eGZvDyIjcNBMWfMnSFGJnLWwfAjJ
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.eGZvDyIjcNBMWfMnSFGJnLWwfAjJ
	|-IndexedDictionary<uint, object>.eGZvDyIjcNBMWfMnSFGJnLWwfAjJ
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.eGZvDyIjcNBMWfMnSFGJnLWwfAjJ
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool cUnjyKiuRQlcphJMXaxkGSAuQNawA(KeyValuePair<TKey, TValue> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109F490 Offset: 0x109DA90 VA: 0x18109F490
	|-IndexedDictionary<Bytes20, object>.cUnjyKiuRQlcphJMXaxkGSAuQNawA
	|
	|-RVA: 0x109F700 Offset: 0x109DD00 VA: 0x18109F700
	|-IndexedDictionary<int, object>.cUnjyKiuRQlcphJMXaxkGSAuQNawA
	|
	|-RVA: 0x109EEF0 Offset: 0x109D4F0 VA: 0x18109EEF0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.cUnjyKiuRQlcphJMXaxkGSAuQNawA
	|
	|-RVA: 0x109F230 Offset: 0x109D830 VA: 0x18109F230
	|-IndexedDictionary<uint, object>.cUnjyKiuRQlcphJMXaxkGSAuQNawA
	|
	|-RVA: 0x10A5420 Offset: 0x10A3A20 VA: 0x1810A5420
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.cUnjyKiuRQlcphJMXaxkGSAuQNawA
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1098090 Offset: 0x1096690 VA: 0x181098090
	|-IndexedDictionary<Bytes20, object>.GetEnumerator
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.GetEnumerator
	|
	|-RVA: 0x1098130 Offset: 0x1096730 VA: 0x181098130
	|-IndexedDictionary<int, object>.GetEnumerator
	|-IndexedDictionary<uint, object>.GetEnumerator
	|
	|-RVA: 0x10A19E0 Offset: 0x109FFE0 VA: 0x1810A19E0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1098090 Offset: 0x1096690 VA: 0x181098090
	|-IndexedDictionary<Bytes20, object>.System.Collections.IEnumerable.GetEnumerator
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1098130 Offset: 0x1096730 VA: 0x181098130
	|-IndexedDictionary<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-IndexedDictionary<uint, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10A19E0 Offset: 0x109FFE0 VA: 0x1810A19E0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private TValue gDlkJWUMWcvupzYvYLMqqjiaBYTD(TKey ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109FA70 Offset: 0x109E070 VA: 0x18109FA70
	|-IndexedDictionary<Bytes20, object>.gDlkJWUMWcvupzYvYLMqqjiaBYTD
	|
	|-RVA: 0x109F960 Offset: 0x109DF60 VA: 0x18109F960
	|-IndexedDictionary<int, object>.gDlkJWUMWcvupzYvYLMqqjiaBYTD
	|
	|-RVA: 0x109FCC0 Offset: 0x109E2C0 VA: 0x18109FCC0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.gDlkJWUMWcvupzYvYLMqqjiaBYTD
	|
	|-RVA: 0x109FBB0 Offset: 0x109E1B0 VA: 0x18109FBB0
	|-IndexedDictionary<uint, object>.gDlkJWUMWcvupzYvYLMqqjiaBYTD
	|
	|-RVA: 0x10A59B0 Offset: 0x10A3FB0 VA: 0x1810A59B0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.gDlkJWUMWcvupzYvYLMqqjiaBYTD
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void UOFfDikjJdDJVgEbYBHJnKWbzCib(TKey , TValue ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109D610 Offset: 0x109BC10 VA: 0x18109D610
	|-IndexedDictionary<Bytes20, object>.UOFfDikjJdDJVgEbYBHJnKWbzCib
	|
	|-RVA: 0x109D2B0 Offset: 0x109B8B0 VA: 0x18109D2B0
	|-IndexedDictionary<int, object>.UOFfDikjJdDJVgEbYBHJnKWbzCib
	|
	|-RVA: 0x109D3C0 Offset: 0x109B9C0 VA: 0x18109D3C0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.UOFfDikjJdDJVgEbYBHJnKWbzCib
	|
	|-RVA: 0x109D500 Offset: 0x109BB00 VA: 0x18109D500
	|-IndexedDictionary<uint, object>.UOFfDikjJdDJVgEbYBHJnKWbzCib
	|
	|-RVA: 0x10A4A20 Offset: 0x10A3020 VA: 0x1810A4A20
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.UOFfDikjJdDJVgEbYBHJnKWbzCib
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109BB20 Offset: 0x109A120 VA: 0x18109BB20
	|-IndexedDictionary<Bytes20, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x109BC40 Offset: 0x109A240 VA: 0x18109BC40
	|-IndexedDictionary<int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x109BA00 Offset: 0x109A000 VA: 0x18109BA00
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x109B900 Offset: 0x1099F00 VA: 0x18109B900
	|-IndexedDictionary<uint, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x10A3BB0 Offset: 0x10A21B0 VA: 0x1810A3BB0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109BDE0 Offset: 0x109A3E0 VA: 0x18109BDE0
	|-IndexedDictionary<Bytes20, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x109BD40 Offset: 0x109A340 VA: 0x18109BD40
	|-IndexedDictionary<int, object>.System.Collections.IDictionary.Contains
	|-IndexedDictionary<uint, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x109BE90 Offset: 0x109A490 VA: 0x18109BE90
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x10A3D40 Offset: 0x10A2340 VA: 0x1810A3D40
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109BF40 Offset: 0x109A540 VA: 0x18109BF40
	|-IndexedDictionary<Bytes20, object>.System.Collections.IDictionary.GetEnumerator
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x109BFE0 Offset: 0x109A5E0 VA: 0x18109BFE0
	|-IndexedDictionary<int, object>.System.Collections.IDictionary.GetEnumerator
	|-IndexedDictionary<uint, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x10A3E40 Offset: 0x10A2440 VA: 0x1810A3E40
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-IndexedDictionary<Bytes20, object>.System.Collections.IDictionary.get_IsFixedSize
	|-IndexedDictionary<int, object>.System.Collections.IDictionary.get_IsFixedSize
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IDictionary.get_IsFixedSize
	|-IndexedDictionary<uint, object>.System.Collections.IDictionary.get_IsFixedSize
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-IndexedDictionary<Bytes20, object>.System.Collections.IDictionary.get_IsReadOnly
	|-IndexedDictionary<int, object>.System.Collections.IDictionary.get_IsReadOnly
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IDictionary.get_IsReadOnly
	|-IndexedDictionary<uint, object>.System.Collections.IDictionary.get_IsReadOnly
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109C690 Offset: 0x109AC90 VA: 0x18109C690
	|-IndexedDictionary<Bytes20, object>.System.Collections.IDictionary.get_Keys
	|-IndexedDictionary<int, object>.System.Collections.IDictionary.get_Keys
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IDictionary.get_Keys
	|-IndexedDictionary<uint, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x10A41C0 Offset: 0x10A27C0 VA: 0x1810A41C0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109C070 Offset: 0x109A670 VA: 0x18109C070
	|-IndexedDictionary<Bytes20, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x109C110 Offset: 0x109A710 VA: 0x18109C110
	|-IndexedDictionary<int, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x109C230 Offset: 0x109A830 VA: 0x18109C230
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x109C1A0 Offset: 0x109A7A0 VA: 0x18109C1A0
	|-IndexedDictionary<uint, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x10A3F00 Offset: 0x10A2500 VA: 0x1810A3F00
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109C710 Offset: 0x109AD10 VA: 0x18109C710
	|-IndexedDictionary<Bytes20, object>.System.Collections.IDictionary.get_Values
	|-IndexedDictionary<int, object>.System.Collections.IDictionary.get_Values
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IDictionary.get_Values
	|-IndexedDictionary<uint, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x10A4240 Offset: 0x10A2840 VA: 0x1810A4240
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109C3E0 Offset: 0x109A9E0 VA: 0x18109C3E0
	|-IndexedDictionary<Bytes20, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x109C2C0 Offset: 0x109A8C0 VA: 0x18109C2C0
	|-IndexedDictionary<int, object>.System.Collections.IDictionary.get_Item
	|-IndexedDictionary<uint, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x109C530 Offset: 0x109AB30 VA: 0x18109C530
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x10A3FF0 Offset: 0x10A25F0 VA: 0x1810A3FF0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109C920 Offset: 0x109AF20 VA: 0x18109C920
	|-IndexedDictionary<Bytes20, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x109C790 Offset: 0x109AD90 VA: 0x18109C790
	|-IndexedDictionary<int, object>.System.Collections.IDictionary.set_Item
	|-IndexedDictionary<uint, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x109CAD0 Offset: 0x109B0D0 VA: 0x18109CAD0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x10A42C0 Offset: 0x10A28C0 VA: 0x1810A42C0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109B450 Offset: 0x1099A50 VA: 0x18109B450
	|-IndexedDictionary<Bytes20, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x109B250 Offset: 0x1099850 VA: 0x18109B250
	|-IndexedDictionary<int, object>.System.Collections.ICollection.CopyTo
	|-IndexedDictionary<uint, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x109B020 Offset: 0x1099620 VA: 0x18109B020
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x10A36D0 Offset: 0x10A1CD0 VA: 0x1810A36D0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109B6D0 Offset: 0x1099CD0 VA: 0x18109B6D0
	|-IndexedDictionary<Bytes20, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x109B680 Offset: 0x1099C80 VA: 0x18109B680
	|-IndexedDictionary<int, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x109B770 Offset: 0x1099D70 VA: 0x18109B770
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x109B720 Offset: 0x1099D20 VA: 0x18109B720
	|-IndexedDictionary<uint, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x10A3B10 Offset: 0x10A2110 VA: 0x1810A3B10
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109B8B0 Offset: 0x1099EB0 VA: 0x18109B8B0
	|-IndexedDictionary<Bytes20, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x109B860 Offset: 0x1099E60 VA: 0x18109B860
	|-IndexedDictionary<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x109B810 Offset: 0x1099E10 VA: 0x18109B810
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x109B7C0 Offset: 0x1099DC0 VA: 0x18109B7C0
	|-IndexedDictionary<uint, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x10A3B60 Offset: 0x10A2160 VA: 0x1810A3B60
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 36
	private TValue wlbBtohZWLkoboHhkOrEwUCHySjn(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A00E0 Offset: 0x109E6E0 VA: 0x1810A00E0
	|-IndexedDictionary<Bytes20, object>.wlbBtohZWLkoboHhkOrEwUCHySjn
	|
	|-RVA: 0x10A00C0 Offset: 0x109E6C0 VA: 0x1810A00C0
	|-IndexedDictionary<int, object>.wlbBtohZWLkoboHhkOrEwUCHySjn
	|-IndexedDictionary<uint, object>.wlbBtohZWLkoboHhkOrEwUCHySjn
	|
	|-RVA: 0x10A0A90 Offset: 0x109F090 VA: 0x1810A0A90
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.wlbBtohZWLkoboHhkOrEwUCHySjn
	|
	|-RVA: 0x10A6700 Offset: 0x10A4D00 VA: 0x1810A6700
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.wlbBtohZWLkoboHhkOrEwUCHySjn
	*/

	// RVA: -1 Offset: -1 Slot: 37
	private int zHvIfXgzViQxoKKfulVOMJeOAyHA(TValue ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A0BA0 Offset: 0x109F1A0 VA: 0x1810A0BA0
	|-IndexedDictionary<Bytes20, object>.zHvIfXgzViQxoKKfulVOMJeOAyHA
	|
	|-RVA: 0x10A0B80 Offset: 0x109F180 VA: 0x1810A0B80
	|-IndexedDictionary<int, object>.zHvIfXgzViQxoKKfulVOMJeOAyHA
	|-IndexedDictionary<uint, object>.zHvIfXgzViQxoKKfulVOMJeOAyHA
	|
	|-RVA: 0x10A0B40 Offset: 0x109F140 VA: 0x1810A0B40
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.zHvIfXgzViQxoKKfulVOMJeOAyHA
	|
	|-RVA: 0x10A67D0 Offset: 0x10A4DD0 VA: 0x1810A67D0
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.zHvIfXgzViQxoKKfulVOMJeOAyHA
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private bool wEPAjyosCskPcbNxtXzfSJntdoBN(TValue ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A0A50 Offset: 0x109F050 VA: 0x1810A0A50
	|-IndexedDictionary<Bytes20, object>.wEPAjyosCskPcbNxtXzfSJntdoBN
	|
	|-RVA: 0x10A09C0 Offset: 0x109EFC0 VA: 0x1810A09C0
	|-IndexedDictionary<int, object>.wEPAjyosCskPcbNxtXzfSJntdoBN
	|-IndexedDictionary<uint, object>.wEPAjyosCskPcbNxtXzfSJntdoBN
	|
	|-RVA: 0x10A0A00 Offset: 0x109F000 VA: 0x1810A0A00
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.wEPAjyosCskPcbNxtXzfSJntdoBN
	|
	|-RVA: 0x10A6600 Offset: 0x10A4C00 VA: 0x1810A6600
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.wEPAjyosCskPcbNxtXzfSJntdoBN
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private int UMoswxVlLjPvKxjqAINGjXhtVAbX() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109D290 Offset: 0x109B890 VA: 0x18109D290
	|-IndexedDictionary<Bytes20, object>.UMoswxVlLjPvKxjqAINGjXhtVAbX
	|-IndexedDictionary<int, object>.UMoswxVlLjPvKxjqAINGjXhtVAbX
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.UMoswxVlLjPvKxjqAINGjXhtVAbX
	|-IndexedDictionary<uint, object>.UMoswxVlLjPvKxjqAINGjXhtVAbX
	|
	|-RVA: 0xE5A020 Offset: 0xE58620 VA: 0x180E5A020
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.UMoswxVlLjPvKxjqAINGjXhtVAbX
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private object hiDJHEcKSvCOQdTBWAqleqyCilCW(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A00E0 Offset: 0x109E6E0 VA: 0x1810A00E0
	|-IndexedDictionary<Bytes20, object>.hiDJHEcKSvCOQdTBWAqleqyCilCW
	|
	|-RVA: 0x10A00C0 Offset: 0x109E6C0 VA: 0x1810A00C0
	|-IndexedDictionary<int, object>.hiDJHEcKSvCOQdTBWAqleqyCilCW
	|-IndexedDictionary<uint, object>.hiDJHEcKSvCOQdTBWAqleqyCilCW
	|
	|-RVA: 0x109FFF0 Offset: 0x109E5F0 VA: 0x18109FFF0
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.hiDJHEcKSvCOQdTBWAqleqyCilCW
	|
	|-RVA: 0x10A5E80 Offset: 0x10A4480 VA: 0x1810A5E80
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.hiDJHEcKSvCOQdTBWAqleqyCilCW
	*/

	// RVA: -1 Offset: -1 Slot: 41
	private int vHudGghcWPWJxqXFHfzUINhpdSOaA(object ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10A0890 Offset: 0x109EE90 VA: 0x1810A0890
	|-IndexedDictionary<Bytes20, object>.vHudGghcWPWJxqXFHfzUINhpdSOaA
	|
	|-RVA: 0x10A0800 Offset: 0x109EE00 VA: 0x1810A0800
	|-IndexedDictionary<int, object>.vHudGghcWPWJxqXFHfzUINhpdSOaA
	|-IndexedDictionary<uint, object>.vHudGghcWPWJxqXFHfzUINhpdSOaA
	|
	|-RVA: 0x10A0920 Offset: 0x109EF20 VA: 0x1810A0920
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.vHudGghcWPWJxqXFHfzUINhpdSOaA
	|
	|-RVA: 0x10A6500 Offset: 0x10A4B00 VA: 0x1810A6500
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.vHudGghcWPWJxqXFHfzUINhpdSOaA
	*/

	// RVA: -1 Offset: -1 Slot: 42
	private bool FRLIDkfNFnczaDRUIYBHbUNphiis(object ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1097970 Offset: 0x1095F70 VA: 0x181097970
	|-IndexedDictionary<Bytes20, object>.FRLIDkfNFnczaDRUIYBHbUNphiis
	|
	|-RVA: 0x10978C0 Offset: 0x1095EC0 VA: 0x1810978C0
	|-IndexedDictionary<int, object>.FRLIDkfNFnczaDRUIYBHbUNphiis
	|-IndexedDictionary<uint, object>.FRLIDkfNFnczaDRUIYBHbUNphiis
	|
	|-RVA: 0x1097A20 Offset: 0x1096020 VA: 0x181097A20
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>.FRLIDkfNFnczaDRUIYBHbUNphiis
	|
	|-RVA: 0x10A1470 Offset: 0x109FA70 VA: 0x1810A1470
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FRLIDkfNFnczaDRUIYBHbUNphiis
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x109D770 Offset: 0x109BD70 VA: 0x18109D770
	|-IndexedDictionary<Bytes20, object>..cctor
	|-IndexedDictionary<int, object>..cctor
	|-IndexedDictionary<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>..cctor
	|-IndexedDictionary<uint, object>..cctor
	|-IndexedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
[Serializable]
internal sealed class RingBuffer<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 2986
{
	// Fields
	private readonly T[] PrfPZXsGmzgfaNUCurLIEmSRjNhB; // 0x0
	private readonly int trhVyvQgytEMspScbcKbCFDTwbuU; // 0x0
	private int hHFGJmLOoSZbQgHDLPCKtCdsVuyO; // 0x0
	private int TvAxKpAOOYJRCLRGxXKCiHrQKXqI; // 0x0
	private int RsGnEXDQExDlWciToQSJcdgbDLPH; // 0x0
	private int rwfITIqhfMJzdrcPEHqTdZznQgPL; // 0x0
	private int jfWUKfrPFnUrhKIEzdWDgiscOVxV; // 0x0
	private IEqualityComparer<T> OwHYRyKATJaOUXIQLxaXyqKytGkE; // 0x0

	// Properties
	public int Count { get; }
	public int Capacity { get; }
	public int OverrunCount { get; }
	public IEqualityComparer<T> EqualityComparer { get; set; }
	public T Item { get; set; }
	private int System.Collections.Generic.ICollection<T>.Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	|-RingBuffer<object>.get_Count
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Count
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	|-RingBuffer<object>.get_Capacity
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Capacity
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public int get_OverrunCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	|-RingBuffer<object>.get_OverrunCount
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_OverrunCount
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.get_OverrunCount
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-RingBuffer<object>.get_EqualityComparer
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_EqualityComparer
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1
	public void set_EqualityComparer(IEqualityComparer<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E5B0 Offset: 0x95CBB0 VA: 0x18095E5B0
	|-RingBuffer<object>.set_EqualityComparer
	|
	|-RVA: 0x961CF0 Offset: 0x9602F0 VA: 0x180961CF0
	|-RingBuffer<__Il2CppFullySharedGenericType>.set_EqualityComparer
	|
	|-RVA: 0x961CB0 Offset: 0x9602B0 VA: 0x180961CB0
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.set_EqualityComparer
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E450 Offset: 0x95CA50 VA: 0x18095E450
	|-RingBuffer<object>.get_Item
	|
	|-RVA: 0x9618C0 Offset: 0x95FEC0 VA: 0x1809618C0
	|-RingBuffer<__Il2CppFullySharedGenericType>.get_Item
	|
	|-RVA: 0x961810 Offset: 0x95FE10 VA: 0x180961810
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E5F0 Offset: 0x95CBF0 VA: 0x18095E5F0
	|-RingBuffer<object>.set_Item
	|
	|-RVA: 0x961D40 Offset: 0x960340 VA: 0x180961D40
	|-RingBuffer<__Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0x961F00 Offset: 0x960500 VA: 0x180961F00
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E140 Offset: 0x95C740 VA: 0x18095E140
	|-RingBuffer<object>..ctor
	|
	|-RVA: 0x961010 Offset: 0x95F610 VA: 0x180961010
	|-RingBuffer<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x961110 Offset: 0x95F710 VA: 0x180961110
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DA50 Offset: 0x95C050 VA: 0x18095DA50
	|-RingBuffer<object>.Enqueue
	|
	|-RVA: 0x95FD50 Offset: 0x95E350 VA: 0x18095FD50
	|-RingBuffer<__Il2CppFullySharedGenericType>.Enqueue
	|
	|-RVA: 0x95FCD0 Offset: 0x95E2D0 VA: 0x18095FCD0
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public bool EnqueueIfUnique(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D9C0 Offset: 0x95BFC0 VA: 0x18095D9C0
	|-RingBuffer<object>.EnqueueIfUnique
	|
	|-RVA: 0x95FAD0 Offset: 0x95E0D0 VA: 0x18095FAD0
	|-RingBuffer<__Il2CppFullySharedGenericType>.EnqueueIfUnique
	|
	|-RVA: 0x95FC40 Offset: 0x95E240 VA: 0x18095FC40
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.EnqueueIfUnique
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D8B0 Offset: 0x95BEB0 VA: 0x18095D8B0
	|-RingBuffer<object>.Dequeue
	|
	|-RVA: 0x95F770 Offset: 0x95DD70 VA: 0x18095F770
	|-RingBuffer<__Il2CppFullySharedGenericType>.Dequeue
	|
	|-RVA: 0x95F680 Offset: 0x95DC80 VA: 0x18095F680
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DC20 Offset: 0x95C220 VA: 0x18095DC20
	|-RingBuffer<object>.Peek
	|
	|-RVA: 0x960290 Offset: 0x95E890 VA: 0x180960290
	|-RingBuffer<__Il2CppFullySharedGenericType>.Peek
	|
	|-RVA: 0x960210 Offset: 0x95E810 VA: 0x180960210
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.Peek
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D850 Offset: 0x95BE50 VA: 0x18095D850
	|-RingBuffer<object>.Contains
	|
	|-RVA: 0x95F520 Offset: 0x95DB20 VA: 0x18095F520
	|-RingBuffer<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x95F650 Offset: 0x95DC50 VA: 0x18095F650
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D880 Offset: 0x95BE80 VA: 0x18095D880
	|-RingBuffer<object>.Contains
	|
	|-RVA: 0x95F420 Offset: 0x95DA20 VA: 0x18095F420
	|-RingBuffer<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x95F620 Offset: 0x95DC20 VA: 0x18095F620
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.Contains
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DB50 Offset: 0x95C150 VA: 0x18095DB50
	|-RingBuffer<object>.IndexOf
	|
	|-RVA: 0x9600E0 Offset: 0x95E6E0 VA: 0x1809600E0
	|-RingBuffer<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x95FED0 Offset: 0x95E4D0 VA: 0x18095FED0
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DAE0 Offset: 0x95C0E0 VA: 0x18095DAE0
	|-RingBuffer<object>.IndexOf
	|
	|-RVA: 0x95FFC0 Offset: 0x95E5C0 VA: 0x18095FFC0
	|-RingBuffer<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0x95FF50 Offset: 0x95E550 VA: 0x18095FF50
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DF20 Offset: 0x95C520 VA: 0x18095DF20
	|-RingBuffer<object>.Remove
	|
	|-RVA: 0x960A60 Offset: 0x95F060 VA: 0x180960A60
	|-RingBuffer<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x960CF0 Offset: 0x95F2F0 VA: 0x180960CF0
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DFE0 Offset: 0x95C5E0 VA: 0x18095DFE0
	|-RingBuffer<object>.Remove
	|
	|-RVA: 0x960B50 Offset: 0x95F150 VA: 0x180960B50
	|-RingBuffer<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x9609B0 Offset: 0x95EFB0 VA: 0x1809609B0
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DEF0 Offset: 0x95C4F0 VA: 0x18095DEF0
	|-RingBuffer<object>.RemoveAt
	|
	|-RVA: 0x960950 Offset: 0x95EF50 VA: 0x180960950
	|-RingBuffer<__Il2CppFullySharedGenericType>.RemoveAt
	|
	|-RVA: 0x960920 Offset: 0x95EF20 VA: 0x180960920
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DED0 Offset: 0x95C4D0 VA: 0x18095DED0
	|-RingBuffer<object>.RemoveAll
	|
	|-RVA: 0x960820 Offset: 0x95EE20 VA: 0x180960820
	|-RingBuffer<__Il2CppFullySharedGenericType>.RemoveAll
	|
	|-RVA: 0x9605E0 Offset: 0x95EBE0 VA: 0x1809605E0
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(T item, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DCA0 Offset: 0x95C2A0 VA: 0x18095DCA0
	|-RingBuffer<object>.RemoveAll
	|
	|-RVA: 0x9603A0 Offset: 0x95E9A0 VA: 0x1809603A0
	|-RingBuffer<__Il2CppFullySharedGenericType>.RemoveAll
	|
	|-RVA: 0x960600 Offset: 0x95EC00 VA: 0x180960600
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D7D0 Offset: 0x95BDD0 VA: 0x18095D7D0
	|-RingBuffer<object>.Clear
	|-RingBuffer<__Il2CppFullySharedGenericType>.Clear
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.Clear
	*/

	// RVA: -1 Offset: -1
	private int mPfMslbLUUhXPgmMrsbLWhIqIiJj(T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E500 Offset: 0x95CB00 VA: 0x18095E500
	|-RingBuffer<object>.mPfMslbLUUhXPgmMrsbLWhIqIiJj
	|
	|-RVA: 0x961A40 Offset: 0x960040 VA: 0x180961A40
	|-RingBuffer<__Il2CppFullySharedGenericType>.mPfMslbLUUhXPgmMrsbLWhIqIiJj
	|
	|-RVA: 0x961A20 Offset: 0x960020 VA: 0x180961A20
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.mPfMslbLUUhXPgmMrsbLWhIqIiJj
	*/

	// RVA: -1 Offset: -1
	private int aahDOiyqNuOXDfYLYVeNUoJSPWLQ(T , IEqualityComparer<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E230 Offset: 0x95C830 VA: 0x18095E230
	|-RingBuffer<object>.aahDOiyqNuOXDfYLYVeNUoJSPWLQ
	|
	|-RVA: 0x961200 Offset: 0x95F800 VA: 0x180961200
	|-RingBuffer<__Il2CppFullySharedGenericType>.aahDOiyqNuOXDfYLYVeNUoJSPWLQ
	|
	|-RVA: 0x961600 Offset: 0x95FC00 VA: 0x180961600
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.aahDOiyqNuOXDfYLYVeNUoJSPWLQ
	*/

	// RVA: -1 Offset: -1
	private void AngKXANiXMWLhtUUKpyNLmgKTJUE(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D550 Offset: 0x95BB50 VA: 0x18095D550
	|-RingBuffer<object>.AngKXANiXMWLhtUUKpyNLmgKTJUE
	|
	|-RVA: 0x95F0E0 Offset: 0x95D6E0 VA: 0x18095F0E0
	|-RingBuffer<__Il2CppFullySharedGenericType>.AngKXANiXMWLhtUUKpyNLmgKTJUE
	|
	|-RVA: 0x95EE90 Offset: 0x95D490 VA: 0x18095EE90
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.AngKXANiXMWLhtUUKpyNLmgKTJUE
	*/

	// RVA: -1 Offset: -1
	private bool ItpcWohxussqlsGdzCyapmiVNiDbA(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DBD0 Offset: 0x95C1D0 VA: 0x18095DBD0
	|-RingBuffer<object>.ItpcWohxussqlsGdzCyapmiVNiDbA
	|-RingBuffer<__Il2CppFullySharedGenericType>.ItpcWohxussqlsGdzCyapmiVNiDbA
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.ItpcWohxussqlsGdzCyapmiVNiDbA
	*/

	// RVA: -1 Offset: -1
	private int pocapABytlMlMHLnrdauKfAUoIGib(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E540 Offset: 0x95CB40 VA: 0x18095E540
	|-RingBuffer<object>.pocapABytlMlMHLnrdauKfAUoIGib
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.pocapABytlMlMHLnrdauKfAUoIGib
	|
	|-RVA: 0x961B30 Offset: 0x960130 VA: 0x180961B30
	|-RingBuffer<__Il2CppFullySharedGenericType>.pocapABytlMlMHLnrdauKfAUoIGib
	*/

	// RVA: -1 Offset: -1
	private int pBogTBHOrtBCXYfYziPGdrHcFzCrB(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E520 Offset: 0x95CB20 VA: 0x18095E520
	|-RingBuffer<object>.pBogTBHOrtBCXYfYziPGdrHcFzCrB
	|-RingBuffer<__Il2CppFullySharedGenericType>.pBogTBHOrtBCXYfYziPGdrHcFzCrB
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.pBogTBHOrtBCXYfYziPGdrHcFzCrB
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void rVglQUzAWFuyGcbqpiqaYseqdVqFA(T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E590 Offset: 0x95CB90 VA: 0x18095E590
	|-RingBuffer<object>.rVglQUzAWFuyGcbqpiqaYseqdVqFA
	|
	|-RVA: 0x961BB0 Offset: 0x9601B0 VA: 0x180961BB0
	|-RingBuffer<__Il2CppFullySharedGenericType>.rVglQUzAWFuyGcbqpiqaYseqdVqFA
	|
	|-RVA: 0x961C90 Offset: 0x960290 VA: 0x180961C90
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.rVglQUzAWFuyGcbqpiqaYseqdVqFA
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void JPqFQDePKYaqGEpZFjvNeUOEToziB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DC00 Offset: 0x95C200 VA: 0x18095DC00
	|-RingBuffer<object>.JPqFQDePKYaqGEpZFjvNeUOEToziB
	|
	|-RVA: 0x9601F0 Offset: 0x95E7F0 VA: 0x1809601F0
	|-RingBuffer<__Il2CppFullySharedGenericType>.JPqFQDePKYaqGEpZFjvNeUOEToziB
	|
	|-RVA: 0x9601D0 Offset: 0x95E7D0 VA: 0x1809601D0
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.JPqFQDePKYaqGEpZFjvNeUOEToziB
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool XdSZCcZFZTlVhyPdLeoVCPKxUSbO(T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E100 Offset: 0x95C700 VA: 0x18095E100
	|-RingBuffer<object>.XdSZCcZFZTlVhyPdLeoVCPKxUSbO
	|
	|-RVA: 0x960F20 Offset: 0x95F520 VA: 0x180960F20
	|-RingBuffer<__Il2CppFullySharedGenericType>.XdSZCcZFZTlVhyPdLeoVCPKxUSbO
	|
	|-RVA: 0x960EE0 Offset: 0x95F4E0 VA: 0x180960EE0
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.XdSZCcZFZTlVhyPdLeoVCPKxUSbO
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void xeEricCtIAVRIXwjajLsHfgeoPZl(T[] , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E780 Offset: 0x95CD80 VA: 0x18095E780
	|-RingBuffer<object>.xeEricCtIAVRIXwjajLsHfgeoPZl
	|
	|-RVA: 0x962170 Offset: 0x960770 VA: 0x180962170
	|-RingBuffer<__Il2CppFullySharedGenericType>.xeEricCtIAVRIXwjajLsHfgeoPZl
	|
	|-RVA: 0x9623E0 Offset: 0x9609E0 VA: 0x1809623E0
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.xeEricCtIAVRIXwjajLsHfgeoPZl
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private int lMKrJvYJKlIrZEFqwCZVQmlEqxx() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	|-RingBuffer<object>.lMKrJvYJKlIrZEFqwCZVQmlEqxx
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.lMKrJvYJKlIrZEFqwCZVQmlEqxx
	|
	|-RVA: 0x8FB170 Offset: 0x8F9770 VA: 0x1808FB170
	|-RingBuffer<__Il2CppFullySharedGenericType>.lMKrJvYJKlIrZEFqwCZVQmlEqxx
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool YqmYPcqUzLCXNjinhsHIGsJeAKil() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-RingBuffer<object>.YqmYPcqUzLCXNjinhsHIGsJeAKil
	|-RingBuffer<__Il2CppFullySharedGenericType>.YqmYPcqUzLCXNjinhsHIGsJeAKil
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.YqmYPcqUzLCXNjinhsHIGsJeAKil
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool wQglZhMIhUPcehrHcDQHnMQipONv(T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E6B0 Offset: 0x95CCB0 VA: 0x18095E6B0
	|-RingBuffer<object>.wQglZhMIhUPcehrHcDQHnMQipONv
	|
	|-RVA: 0x961FB0 Offset: 0x9605B0 VA: 0x180961FB0
	|-RingBuffer<__Il2CppFullySharedGenericType>.wQglZhMIhUPcehrHcDQHnMQipONv
	|
	|-RVA: 0x9620A0 Offset: 0x9606A0 VA: 0x1809620A0
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.wQglZhMIhUPcehrHcDQHnMQipONv
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> tHfudBkMBhfLIRSNLHFjkapNsznsA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E090 Offset: 0x95C690 VA: 0x18095E090
	|-RingBuffer<object>.tHfudBkMBhfLIRSNLHFjkapNsznsA
	|
	|-RVA: 0x960DB0 Offset: 0x95F3B0 VA: 0x180960DB0
	|-RingBuffer<__Il2CppFullySharedGenericType>.tHfudBkMBhfLIRSNLHFjkapNsznsA
	|
	|-RVA: 0x960E70 Offset: 0x95F470 VA: 0x180960E70
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.tHfudBkMBhfLIRSNLHFjkapNsznsA
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E090 Offset: 0x95C690 VA: 0x18095E090
	|-RingBuffer<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x960DB0 Offset: 0x95F3B0 VA: 0x180960DB0
	|-RingBuffer<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x960E70 Offset: 0x95F470 VA: 0x180960E70
	|-RingBuffer<pLASGVNxyqcLqfQMjwoAFeDtDdPS>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class ExpandableArray_DataContainer<T> // TypeDefIndex: 2988
{
	// Fields
	public readonly T injector; // 0x0
	private T[] qBCLpeFWraHdHTOmTCgyJkoznWFT; // 0x0
	private int xLKDgOGUEckEwjFxzazpVqPpdJIK; // 0x0
	private int SZmLfgDMHpciSdmCpqhyfGRitYTfb; // 0x0
	private int TdzuetbgFrydrPKqRSTZcjnSaLFz; // 0x0
	private int QVoplnQAYYNeyygZHNENyIeDjVHaA; // 0x0
	private bool xtMVWTgLbrQtGgOqZqnAFjcSMGYE; // 0x0

	// Properties
	public int Count { get; }
	public int Length { get; }
	public int MaxLength { get; }
	public int FreeSpace { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-ExpandableArray_DataContainer<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-ExpandableArray_DataContainer<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public int get_MaxLength() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	|-ExpandableArray_DataContainer<object>.get_MaxLength
	*/

	// RVA: -1 Offset: -1
	public int get_FreeSpace() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFDFE0 Offset: 0xFFC5E0 VA: 0x180FFDFE0
	|-ExpandableArray_DataContainer<object>.get_FreeSpace
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int , bool  = True, int  = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFDE90 Offset: 0xFFC490 VA: 0x180FFDE90
	|-ExpandableArray_DataContainer<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFDFF0 Offset: 0xFFC5F0 VA: 0x180FFDFF0
	|-ExpandableArray_DataContainer<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public int Inject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFD620 Offset: 0xFFBC20 VA: 0x180FFD620
	|-ExpandableArray_DataContainer<object>.Inject
	*/

	// RVA: -1 Offset: -1
	public int InjectIfUnique() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFD4D0 Offset: 0xFFBAD0 VA: 0x180FFD4D0
	|-ExpandableArray_DataContainer<object>.InjectIfUnique
	*/

	// RVA: -1 Offset: -1
	public int AddData(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCFE0 Offset: 0xFFB5E0 VA: 0x180FFCFE0
	|-ExpandableArray_DataContainer<object>.AddData
	*/

	// RVA: -1 Offset: -1
	public int AddIfUnique(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFD0E0 Offset: 0xFFB6E0 VA: 0x180FFD0E0
	|-ExpandableArray_DataContainer<object>.AddIfUnique
	*/

	// RVA: -1 Offset: -1
	public bool ContainsData(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFD350 Offset: 0xFFB950 VA: 0x180FFD350
	|-ExpandableArray_DataContainer<object>.ContainsData
	*/

	// RVA: -1 Offset: -1
	public int IndexOfData(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFD410 Offset: 0xFFBA10 VA: 0x180FFD410
	|-ExpandableArray_DataContainer<object>.IndexOfData
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFD1D0 Offset: 0xFFB7D0 VA: 0x180FFD1D0
	|-ExpandableArray_DataContainer<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFD6B0 Offset: 0xFFBCB0 VA: 0x180FFD6B0
	|-ExpandableArray_DataContainer<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveLast() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFD950 Offset: 0xFFBF50 VA: 0x180FFD950
	|-ExpandableArray_DataContainer<object>.RemoveLast
	*/

	// RVA: -1 Offset: -1
	public void Resize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFD9E0 Offset: 0xFFBFE0 VA: 0x180FFD9E0
	|-ExpandableArray_DataContainer<object>.Resize
	*/

	// RVA: -1 Offset: -1
	public void SortAscending() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFDBB0 Offset: 0xFFC1B0 VA: 0x180FFDBB0
	|-ExpandableArray_DataContainer<object>.SortAscending
	*/

	// RVA: -1 Offset: -1
	public void SortDescending() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFDD20 Offset: 0xFFC320 VA: 0x180FFDD20
	|-ExpandableArray_DataContainer<object>.SortDescending
	*/

	// RVA: -1 Offset: -1
	private void akpahWsyPLLWiPBkrWJCwSQjLtbr() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFDFB0 Offset: 0xFFC5B0 VA: 0x180FFDFB0
	|-ExpandableArray_DataContainer<object>.akpahWsyPLLWiPBkrWJCwSQjLtbr
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
[Serializable]
internal class AList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection // TypeDefIndex: 2990
{
	// Fields
	private const int QikHOYfvQqIQxxrjvqfADMUuDbJgA = 4;
	private static readonly T[] JXeymmnlcLjhhCrraDepHEZAEQeXB; // 0x0
	private IEqualityComparer<T> sQUsJvDRDyyESwWSQMAhKdJsFZeo; // 0x0
	public T[] _items; // 0x0
	private int kkAEeonbedaxHokVddgbbydsgjfD; // 0x0
	public int _count; // 0x0
	private int lZaDHyFhYWHjIlSZuOubWrckOSHeb; // 0x0
	private bool VXcPSwjaCDgKCbucOmCgxAfQBnBd; // 0x0
	private readonly int XlrYLcMCgJAltHAMbuYwKBUZIlcf; // 0x0
	private readonly bool uRNbkVJbrFerekNjPaUlliFoEzGaA; // 0x0
	private int xLRzWkfzeigcMpmbezNKkpiKWkAp; // 0x0
	private object VkBPQAXOCfZhMoSwIVbNmmGQsAxj; // 0x0

	// Properties
	public int Count { get; }
	public int Capacity { get; }
	public int FreeSpace { get; }
	public bool IsFixedSize { get; }
	public IEqualityComparer<T> EqualityComparer { get; set; }
	public int Version { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.get_Count
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.get_Count
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.get_Count
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.get_Count
	|-AList<object>.get_Count
	|-AList<__Il2CppFullySharedGenericType>.get_Count
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.get_Capacity
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.get_Capacity
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.get_Capacity
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.get_Capacity
	|-AList<object>.get_Capacity
	|-AList<__Il2CppFullySharedGenericType>.get_Capacity
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public int get_FreeSpace() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF5A10 Offset: 0xDF4010 VA: 0x180DF5A10
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.get_FreeSpace
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.get_FreeSpace
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.get_FreeSpace
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.get_FreeSpace
	|-AList<object>.get_FreeSpace
	|-AList<__Il2CppFullySharedGenericType>.get_FreeSpace
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.get_FreeSpace
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public bool get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF5A20 Offset: 0xDF4020 VA: 0x180DF5A20
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.get_IsFixedSize
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.get_IsFixedSize
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.get_IsFixedSize
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.get_IsFixedSize
	|-AList<object>.get_IsFixedSize
	|-AList<__Il2CppFullySharedGenericType>.get_IsFixedSize
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> get_EqualityComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.get_EqualityComparer
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.get_EqualityComparer
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.get_EqualityComparer
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.get_EqualityComparer
	|-AList<object>.get_EqualityComparer
	|-AList<__Il2CppFullySharedGenericType>.get_EqualityComparer
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.get_EqualityComparer
	*/

	// RVA: -1 Offset: -1
	public void set_EqualityComparer(IEqualityComparer<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF5B40 Offset: 0xDF4140 VA: 0x180DF5B40
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.set_EqualityComparer
	|
	|-RVA: 0xDF5B80 Offset: 0xDF4180 VA: 0x180DF5B80
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.set_EqualityComparer
	|
	|-RVA: 0xEA8A00 Offset: 0xEA7000 VA: 0x180EA8A00
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.set_EqualityComparer
	|
	|-RVA: 0xEA88F0 Offset: 0xEA6EF0 VA: 0x180EA88F0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.set_EqualityComparer
	|
	|-RVA: 0xEA8970 Offset: 0xEA6F70 VA: 0x180EA8970
	|-AList<object>.set_EqualityComparer
	|
	|-RVA: 0xEA89B0 Offset: 0xEA6FB0 VA: 0x180EA89B0
	|-AList<__Il2CppFullySharedGenericType>.set_EqualityComparer
	|
	|-RVA: 0xEA8930 Offset: 0xEA6F30 VA: 0x180EA8930
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.set_EqualityComparer
	*/

	// RVA: -1 Offset: -1
	public int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.get_Version
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.get_Version
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.get_Version
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.get_Version
	|-AList<object>.get_Version
	|-AList<__Il2CppFullySharedGenericType>.get_Version
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.get_Version
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF5A30 Offset: 0xDF4030 VA: 0x180DF5A30
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.get_Item
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.get_Item
	|
	|-RVA: 0xDF5AC0 Offset: 0xDF40C0 VA: 0x180DF5AC0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.get_Item
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.get_Item
	|
	|-RVA: 0xEA8790 Offset: 0xEA6D90 VA: 0x180EA8790
	|-AList<object>.get_Item
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.get_Item
	|
	|-RVA: 0xEA8800 Offset: 0xEA6E00 VA: 0x180EA8800
	|-AList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF5BC0 Offset: 0xDF41C0 VA: 0x180DF5BC0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.set_Item
	|
	|-RVA: 0xDF5C60 Offset: 0xDF4260 VA: 0x180DF5C60
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.set_Item
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.set_Item
	|
	|-RVA: 0xEA8C40 Offset: 0xEA7240 VA: 0x180EA8C40
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.set_Item
	|
	|-RVA: 0xEA8A40 Offset: 0xEA7040 VA: 0x180EA8A40
	|-AList<object>.set_Item
	|
	|-RVA: 0xEA8AD0 Offset: 0xEA70D0 VA: 0x180EA8AD0
	|-AList<__Il2CppFullySharedGenericType>.set_Item
	|
	|-RVA: 0xEA8CE0 Offset: 0xEA72E0 VA: 0x180EA8CE0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF4690 Offset: 0xDF2C90 VA: 0x180DF4690
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>..ctor
	|
	|-RVA: 0xDF5260 Offset: 0xDF3860 VA: 0x180DF5260
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>..ctor
	|
	|-RVA: 0xEA8050 Offset: 0xEA6650 VA: 0x180EA8050
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>..ctor
	|
	|-RVA: 0xEA5650 Offset: 0xEA3C50 VA: 0x180EA5650
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>..ctor
	|
	|-RVA: 0xEA6980 Offset: 0xEA4F80 VA: 0x180EA6980
	|-AList<object>..ctor
	|
	|-RVA: 0xEA75F0 Offset: 0xEA5BF0 VA: 0x180EA75F0
	|-AList<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xEA75C0 Offset: 0xEA5BC0 VA: 0x180EA75C0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF4660 Offset: 0xDF2C60 VA: 0x180DF4660
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>..ctor
	|
	|-RVA: 0xDF59B0 Offset: 0xDF3FB0 VA: 0x180DF59B0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>..ctor
	|
	|-RVA: 0xEA6020 Offset: 0xEA4620 VA: 0x180EA6020
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>..ctor
	|
	|-RVA: 0xEA69E0 Offset: 0xEA4FE0 VA: 0x180EA69E0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>..ctor
	|
	|-RVA: 0xEA5FF0 Offset: 0xEA45F0 VA: 0x180EA5FF0
	|-AList<object>..ctor
	|
	|-RVA: 0xEA69B0 Offset: 0xEA4FB0 VA: 0x180EA69B0
	|-AList<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xEA5D50 Offset: 0xEA4350 VA: 0x180EA5D50
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF46C0 Offset: 0xDF2CC0 VA: 0x180DF46C0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>..ctor
	|
	|-RVA: 0xDF4630 Offset: 0xDF2C30 VA: 0x180DF4630
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>..ctor
	|
	|-RVA: 0xEA8080 Offset: 0xEA6680 VA: 0x180EA8080
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>..ctor
	|
	|-RVA: 0xEA5D20 Offset: 0xEA4320 VA: 0x180EA5D20
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>..ctor
	|
	|-RVA: 0xEA7DE0 Offset: 0xEA63E0 VA: 0x180EA7DE0
	|-AList<object>..ctor
	|
	|-RVA: 0xEA5D80 Offset: 0xEA4380 VA: 0x180EA5D80
	|-AList<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xEA7DB0 Offset: 0xEA63B0 VA: 0x180EA7DB0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int , int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF5020 Offset: 0xDF3620 VA: 0x180DF5020
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>..ctor
	|
	|-RVA: 0xDF46F0 Offset: 0xDF2CF0 VA: 0x180DF46F0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>..ctor
	|
	|-RVA: 0xEA6740 Offset: 0xEA4D40 VA: 0x180EA6740
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>..ctor
	|
	|-RVA: 0xEA6A10 Offset: 0xEA5010 VA: 0x180EA6A10
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>..ctor
	|
	|-RVA: 0xEA5DB0 Offset: 0xEA43B0 VA: 0x180EA5DB0
	|-AList<object>..ctor
	|
	|-RVA: 0xEA7340 Offset: 0xEA5940 VA: 0x180EA7340
	|-AList<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xEA7E10 Offset: 0xEA6410 VA: 0x180EA7E10
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF5290 Offset: 0xDF3890 VA: 0x180DF5290
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>..ctor
	|
	|-RVA: 0xDF59E0 Offset: 0xDF3FE0 VA: 0x180DF59E0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>..ctor
	|
	|-RVA: 0xEA7620 Offset: 0xEA5C20 VA: 0x180EA7620
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>..ctor
	|
	|-RVA: 0xEA8760 Offset: 0xEA6D60 VA: 0x180EA8760
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>..ctor
	|
	|-RVA: 0xEA5620 Offset: 0xEA3C20 VA: 0x180EA5620
	|-AList<object>..ctor
	|
	|-RVA: 0xEA7590 Offset: 0xEA5B90 VA: 0x180EA7590
	|-AList<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xEA7650 Offset: 0xEA5C50 VA: 0x180EA7650
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> , int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF4930 Offset: 0xDF2F30 VA: 0x180DF4930
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>..ctor
	|
	|-RVA: 0xDF52C0 Offset: 0xDF38C0 VA: 0x180DF52C0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>..ctor
	|
	|-RVA: 0xEA6C50 Offset: 0xEA5250 VA: 0x180EA6C50
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>..ctor
	|
	|-RVA: 0xEA6050 Offset: 0xEA4650 VA: 0x180EA6050
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>..ctor
	|
	|-RVA: 0xEA80B0 Offset: 0xEA66B0 VA: 0x180EA80B0
	|-AList<object>..ctor
	|
	|-RVA: 0xEA7680 Offset: 0xEA5C80 VA: 0x180EA7680
	|-AList<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xEA5680 Offset: 0xEA3C80 VA: 0x180EA5680
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>..ctor
	*/

	// RVA: -1 Offset: -1
	public T GetRandom() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEF710 Offset: 0xDEDD10 VA: 0x180DEF710
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.GetRandom
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.GetRandom
	|
	|-RVA: 0xDEF790 Offset: 0xDEDD90 VA: 0x180DEF790
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.GetRandom
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.GetRandom
	|
	|-RVA: 0xE9C440 Offset: 0xE9AA40 VA: 0x180E9C440
	|-AList<object>.GetRandom
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.GetRandom
	|
	|-RVA: 0xE9C490 Offset: 0xE9AA90 VA: 0x180E9C490
	|-AList<__Il2CppFullySharedGenericType>.GetRandom
	*/

	// RVA: -1 Offset: -1
	public int Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDED9F0 Offset: 0xDEBFF0 VA: 0x180DED9F0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Add
	|
	|-RVA: 0xDED740 Offset: 0xDEBD40 VA: 0x180DED740
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Add
	|
	|-RVA: 0xE998E0 Offset: 0xE97EE0 VA: 0x180E998E0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Add
	|
	|-RVA: 0xE98E00 Offset: 0xE97400 VA: 0x180E98E00
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Add
	|
	|-RVA: 0xE98530 Offset: 0xE96B30 VA: 0x180E98530
	|-AList<object>.Add
	|
	|-RVA: 0xE994B0 Offset: 0xE97AB0 VA: 0x180E994B0
	|-AList<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0xE99860 Offset: 0xE97E60 VA: 0x180E99860
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Add(T[] items, int count = 0, int startIndex = 0, bool allowPartialAdd = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDED7F0 Offset: 0xDEBDF0 VA: 0x180DED7F0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Add
	|
	|-RVA: 0xDED540 Offset: 0xDEBB40 VA: 0x180DED540
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Add
	|
	|-RVA: 0xE985D0 Offset: 0xE96BD0 VA: 0x180E985D0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Add
	|
	|-RVA: 0xE989D0 Offset: 0xE96FD0 VA: 0x180E989D0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Add
	|
	|-RVA: 0xE98EB0 Offset: 0xE974B0 VA: 0x180E98EB0
	|-AList<object>.Add
	|
	|-RVA: 0xE99630 Offset: 0xE97C30 VA: 0x180E99630
	|-AList<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0xE987D0 Offset: 0xE96DD0 VA: 0x180E987D0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Add(AList<T> items, int count = 0, int startIndex = 0, bool allowPartialAdd = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDED140 Offset: 0xDEB740 VA: 0x180DED140
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Add
	|
	|-RVA: 0xDED340 Offset: 0xDEB940 VA: 0x180DED340
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Add
	|
	|-RVA: 0xE98330 Offset: 0xE96930 VA: 0x180E98330
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Add
	|
	|-RVA: 0xE992B0 Offset: 0xE978B0 VA: 0x180E992B0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Add
	|
	|-RVA: 0xE990B0 Offset: 0xE976B0 VA: 0x180E990B0
	|-AList<object>.Add
	|
	|-RVA: 0xE98BD0 Offset: 0xE971D0 VA: 0x180E98BD0
	|-AList<__Il2CppFullySharedGenericType>.Add
	|
	|-RVA: 0xE98130 Offset: 0xE96730 VA: 0x180E98130
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Add
	*/

	// RVA: -1 Offset: -1
	public int AddIfUnique(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEC8A0 Offset: 0xDEAEA0 VA: 0x180DEC8A0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.AddIfUnique
	|
	|-RVA: 0xDEC930 Offset: 0xDEAF30 VA: 0x180DEC930
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.AddIfUnique
	|
	|-RVA: 0xE96D60 Offset: 0xE95360 VA: 0x180E96D60
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.AddIfUnique
	|
	|-RVA: 0xE96DF0 Offset: 0xE953F0 VA: 0x180E96DF0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.AddIfUnique
	|
	|-RVA: 0xE96E70 Offset: 0xE95470 VA: 0x180E96E70
	|-AList<object>.AddIfUnique
	|
	|-RVA: 0xE96BF0 Offset: 0xE951F0 VA: 0x180E96BF0
	|-AList<__Il2CppFullySharedGenericType>.AddIfUnique
	|
	|-RVA: 0xE96ED0 Offset: 0xE954D0 VA: 0x180E96ED0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.AddIfUnique
	*/

	// RVA: -1 Offset: -1
	public int AddToFirstOpenSpace(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEC9B0 Offset: 0xDEAFB0 VA: 0x180DEC9B0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.AddToFirstOpenSpace
	|
	|-RVA: 0xDECBA0 Offset: 0xDEB1A0 VA: 0x180DECBA0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.AddToFirstOpenSpace
	|
	|-RVA: 0xE97F40 Offset: 0xE96540 VA: 0x180E97F40
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.AddToFirstOpenSpace
	|
	|-RVA: 0xE97960 Offset: 0xE95F60 VA: 0x180E97960
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.AddToFirstOpenSpace
	|
	|-RVA: 0xE97380 Offset: 0xE95980 VA: 0x180E97380
	|-AList<object>.AddToFirstOpenSpace
	|
	|-RVA: 0xE97B20 Offset: 0xE96120 VA: 0x180E97B20
	|-AList<__Il2CppFullySharedGenericType>.AddToFirstOpenSpace
	|
	|-RVA: 0xE97150 Offset: 0xE95750 VA: 0x180E97150
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.AddToFirstOpenSpace
	*/

	// RVA: -1 Offset: -1
	public int AddToFirstOpenSpace(T item, T openSpaceEquals) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDECD60 Offset: 0xDEB360 VA: 0x180DECD60
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.AddToFirstOpenSpace
	|
	|-RVA: 0xDECF70 Offset: 0xDEB570 VA: 0x180DECF70
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.AddToFirstOpenSpace
	|
	|-RVA: 0xE96F40 Offset: 0xE95540 VA: 0x180E96F40
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.AddToFirstOpenSpace
	|
	|-RVA: 0xE97790 Offset: 0xE95D90 VA: 0x180E97790
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.AddToFirstOpenSpace
	|
	|-RVA: 0xE97260 Offset: 0xE95860 VA: 0x180E97260
	|-AList<object>.AddToFirstOpenSpace
	|
	|-RVA: 0xE974A0 Offset: 0xE95AA0 VA: 0x180E974A0
	|-AList<__Il2CppFullySharedGenericType>.AddToFirstOpenSpace
	|
	|-RVA: 0xE97E30 Offset: 0xE96430 VA: 0x180E97E30
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.AddToFirstOpenSpace
	*/

	// RVA: -1 Offset: -1
	public bool Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF1090 Offset: 0xDEF690 VA: 0x180DF1090
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Insert
	|
	|-RVA: 0xDF0F80 Offset: 0xDEF580 VA: 0x180DF0F80
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Insert
	|
	|-RVA: 0xE9ECC0 Offset: 0xE9D2C0 VA: 0x180E9ECC0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Insert
	|
	|-RVA: 0xE9EDE0 Offset: 0xE9D3E0 VA: 0x180E9EDE0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Insert
	|
	|-RVA: 0xE9EBB0 Offset: 0xE9D1B0 VA: 0x180E9EBB0
	|-AList<object>.Insert
	|
	|-RVA: 0xE9EEF0 Offset: 0xE9D4F0 VA: 0x180E9EEF0
	|-AList<__Il2CppFullySharedGenericType>.Insert
	|
	|-RVA: 0xE9EAB0 Offset: 0xE9D0B0 VA: 0x180E9EAB0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF2100 Offset: 0xDF0700 VA: 0x180DF2100
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Remove
	|
	|-RVA: 0xDF1FF0 Offset: 0xDF05F0 VA: 0x180DF1FF0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Remove
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Remove
	|
	|-RVA: 0xEA1240 Offset: 0xE9F840 VA: 0x180EA1240
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Remove
	|
	|-RVA: 0xEA1440 Offset: 0xE9FA40 VA: 0x180EA1440
	|-AList<object>.Remove
	|
	|-RVA: 0xEA1530 Offset: 0xE9FB30 VA: 0x180EA1530
	|-AList<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0xEA1360 Offset: 0xE9F960 VA: 0x180EA1360
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF1F20 Offset: 0xDF0520 VA: 0x180DF1F20
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.RemoveAt
	|
	|-RVA: 0xDF1E50 Offset: 0xDF0450 VA: 0x180DF1E50
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.RemoveAt
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.RemoveAt
	|
	|-RVA: 0xEA0E40 Offset: 0xE9F440 VA: 0x180EA0E40
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.RemoveAt
	|
	|-RVA: 0xEA0F10 Offset: 0xE9F510 VA: 0x180EA0F10
	|-AList<object>.RemoveAt
	|
	|-RVA: 0xEA0FC0 Offset: 0xE9F5C0 VA: 0x180EA0FC0
	|-AList<__Il2CppFullySharedGenericType>.RemoveAt
	|
	|-RVA: 0xEA1190 Offset: 0xE9F790 VA: 0x180EA1190
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEDEA0 Offset: 0xDEC4A0 VA: 0x180DEDEA0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Contains
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Contains
	|
	|-RVA: 0xDEE070 Offset: 0xDEC670 VA: 0x180DEE070
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Contains
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Contains
	|
	|-RVA: 0xE99E50 Offset: 0xE98450 VA: 0x180E99E50
	|-AList<object>.Contains
	|
	|-RVA: 0xE99A10 Offset: 0xE98010 VA: 0x180E99A10
	|-AList<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0xE99D30 Offset: 0xE98330 VA: 0x180E99D30
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEDB50 Offset: 0xDEC150 VA: 0x180DEDB50
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Contains
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Contains
	|
	|-RVA: 0xDEDD10 Offset: 0xDEC310 VA: 0x180DEDD10
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Contains
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Contains
	|
	|-RVA: 0xE99C20 Offset: 0xE98220 VA: 0x180E99C20
	|-AList<object>.Contains
	|
	|-RVA: 0xE99F70 Offset: 0xE98570 VA: 0x180E99F70
	|-AList<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0xE99B10 Offset: 0xE98110 VA: 0x180E99B10
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF0B90 Offset: 0xDEF190 VA: 0x180DF0B90
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.IndexOf
	|
	|-RVA: 0xDEFE50 Offset: 0xDEE450 VA: 0x180DEFE50
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.IndexOf
	|
	|-RVA: 0xE9D2F0 Offset: 0xE9B8F0 VA: 0x180E9D2F0
	|-AList<object>.IndexOf
	|
	|-RVA: 0xE9D530 Offset: 0xE9BB30 VA: 0x180E9D530
	|-AList<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0xE9D410 Offset: 0xE9BA10 VA: 0x180E9D410
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEFC70 Offset: 0xDEE270 VA: 0x180DEFC70
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.IndexOf
	|
	|-RVA: 0xDF0820 Offset: 0xDEEE20 VA: 0x180DF0820
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.IndexOf
	|
	|-RVA: 0xE9E990 Offset: 0xE9CF90 VA: 0x180E9E990
	|-AList<object>.IndexOf
	|
	|-RVA: 0xE9E3B0 Offset: 0xE9C9B0 VA: 0x180E9E3B0
	|-AList<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0xE9E4D0 Offset: 0xE9CAD0 VA: 0x180E9E4D0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF0D60 Offset: 0xDEF360 VA: 0x180DF0D60
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.IndexOf
	|
	|-RVA: 0xDF07E0 Offset: 0xDEEDE0 VA: 0x180DF07E0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.IndexOf
	|
	|-RVA: 0xE9D140 Offset: 0xE9B740 VA: 0x180E9D140
	|-AList<object>.IndexOf
	|
	|-RVA: 0xE9D940 Offset: 0xE9BF40 VA: 0x180E9D940
	|-AList<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0xE9DF30 Offset: 0xE9C530 VA: 0x180E9DF30
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF0DB0 Offset: 0xDEF3B0 VA: 0x180DF0DB0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.IndexOf
	|
	|-RVA: 0xDF0230 Offset: 0xDEE830 VA: 0x180DF0230
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.IndexOf
	|
	|-RVA: 0xE9E0F0 Offset: 0xE9C6F0 VA: 0x180E9E0F0
	|-AList<object>.IndexOf
	|
	|-RVA: 0xE9E5F0 Offset: 0xE9CBF0 VA: 0x180E9E5F0
	|-AList<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0xE9D830 Offset: 0xE9BE30 VA: 0x180E9D830
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int index, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF09C0 Offset: 0xDEEFC0 VA: 0x180DF09C0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.IndexOf
	|
	|-RVA: 0xDF0640 Offset: 0xDEEC40 VA: 0x180DF0640
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.IndexOf
	|
	|-RVA: 0xE9DA70 Offset: 0xE9C070 VA: 0x180E9DA70
	|-AList<object>.IndexOf
	|
	|-RVA: 0xE9D630 Offset: 0xE9BC30 VA: 0x180E9D630
	|-AList<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0xE9DB90 Offset: 0xE9C190 VA: 0x180E9DB90
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T item, int index, int count, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF03C0 Offset: 0xDEE9C0 VA: 0x180DF03C0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.IndexOf
	|
	|-RVA: 0xDEFFF0 Offset: 0xDEE5F0 VA: 0x180DEFFF0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.IndexOf
	|
	|-RVA: 0xE9E200 Offset: 0xE9C800 VA: 0x180E9E200
	|-AList<object>.IndexOf
	|
	|-RVA: 0xE9DCB0 Offset: 0xE9C2B0 VA: 0x180E9DCB0
	|-AList<__Il2CppFullySharedGenericType>.IndexOf
	|
	|-RVA: 0xE9E7E0 Offset: 0xE9CDE0 VA: 0x180E9E7E0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public void Reverse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF22B0 Offset: 0xDF08B0 VA: 0x180DF22B0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Reverse
	|
	|-RVA: 0xDF2220 Offset: 0xDF0820 VA: 0x180DF2220
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Reverse
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Reverse
	|
	|-RVA: 0xEA16E0 Offset: 0xE9FCE0 VA: 0x180EA16E0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Reverse
	|
	|-RVA: 0xEA1650 Offset: 0xE9FC50 VA: 0x180EA1650
	|-AList<object>.Reverse
	|
	|-RVA: 0xEA1A70 Offset: 0xEA0070 VA: 0x180EA1A70
	|-AList<__Il2CppFullySharedGenericType>.Reverse
	|
	|-RVA: 0xEA1BE0 Offset: 0xEA01E0 VA: 0x180EA1BE0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void Reverse(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF2340 Offset: 0xDF0940 VA: 0x180DF2340
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Reverse
	|
	|-RVA: 0xDF2440 Offset: 0xDF0A40 VA: 0x180DF2440
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Reverse
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Reverse
	|
	|-RVA: 0xEA1770 Offset: 0xE9FD70 VA: 0x180EA1770
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Reverse
	|
	|-RVA: 0xEA1AE0 Offset: 0xEA00E0 VA: 0x180EA1AE0
	|-AList<object>.Reverse
	|
	|-RVA: 0xEA1870 Offset: 0xE9FE70 VA: 0x180EA1870
	|-AList<__Il2CppFullySharedGenericType>.Reverse
	|
	|-RVA: 0xEA1970 Offset: 0xE9FF70 VA: 0x180EA1970
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Reverse
	*/

	// RVA: -1 Offset: -1
	public void Sort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF2800 Offset: 0xDF0E00 VA: 0x180DF2800
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Sort
	|
	|-RVA: 0xDF27D0 Offset: 0xDF0DD0 VA: 0x180DF27D0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Sort
	|
	|-RVA: 0xEA1C70 Offset: 0xEA0270 VA: 0x180EA1C70
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Sort
	|
	|-RVA: 0xEA20A0 Offset: 0xEA06A0 VA: 0x180EA20A0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Sort
	|
	|-RVA: 0xEA21B0 Offset: 0xEA07B0 VA: 0x180EA21B0
	|-AList<object>.Sort
	|
	|-RVA: 0xEA1E00 Offset: 0xEA0400 VA: 0x180EA1E00
	|-AList<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0xEA1DD0 Offset: 0xEA03D0 VA: 0x180EA1DD0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF2670 Offset: 0xDF0C70 VA: 0x180DF2670
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Sort
	|
	|-RVA: 0xDF26A0 Offset: 0xDF0CA0 VA: 0x180DF26A0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Sort
	|
	|-RVA: 0xEA2180 Offset: 0xEA0780 VA: 0x180EA2180
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Sort
	|
	|-RVA: 0xEA2150 Offset: 0xEA0750 VA: 0x180EA2150
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Sort
	|
	|-RVA: 0xEA1F70 Offset: 0xEA0570 VA: 0x180EA1F70
	|-AList<object>.Sort
	|
	|-RVA: 0xEA20D0 Offset: 0xEA06D0 VA: 0x180EA20D0
	|-AList<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0xEA1DA0 Offset: 0xEA03A0 VA: 0x180EA1DA0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Sort
	*/

	// RVA: -1 Offset: -1
	public void Sort(int index, int count, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF26D0 Offset: 0xDF0CD0 VA: 0x180DF26D0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Sort
	|
	|-RVA: 0xDF2570 Offset: 0xDF0B70 VA: 0x180DF2570
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Sort
	|
	|-RVA: 0xEA1FA0 Offset: 0xEA05A0 VA: 0x180EA1FA0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Sort
	|
	|-RVA: 0xEA1E70 Offset: 0xEA0470 VA: 0x180EA1E70
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Sort
	|
	|-RVA: 0xEA21E0 Offset: 0xEA07E0 VA: 0x180EA21E0
	|-AList<object>.Sort
	|
	|-RVA: 0xEA1CA0 Offset: 0xEA02A0 VA: 0x180EA1CA0
	|-AList<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0xEA22E0 Offset: 0xEA08E0 VA: 0x180EA22E0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Sort
	*/

	// RVA: -1 Offset: -1
	public List<T> GetRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEF9B0 Offset: 0xDEDFB0 VA: 0x180DEF9B0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.GetRange
	|
	|-RVA: 0xDEF800 Offset: 0xDEDE00 VA: 0x180DEF800
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.GetRange
	|
	|-RVA: 0xE9CAC0 Offset: 0xE9B0C0 VA: 0x180E9CAC0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.GetRange
	|
	|-RVA: 0xE9C910 Offset: 0xE9AF10 VA: 0x180E9C910
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.GetRange
	|
	|-RVA: 0xE9C5B0 Offset: 0xE9ABB0 VA: 0x180E9C5B0
	|-AList<object>.GetRange
	|
	|-RVA: 0xE9CC70 Offset: 0xE9B270 VA: 0x180E9CC70
	|-AList<__Il2CppFullySharedGenericType>.GetRange
	|
	|-RVA: 0xE9C760 Offset: 0xE9AD60 VA: 0x180E9C760
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.GetRange
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEDAA0 Offset: 0xDEC0A0 VA: 0x180DEDAA0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.AsReadOnly
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.AsReadOnly
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.AsReadOnly
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.AsReadOnly
	|-AList<object>.AsReadOnly
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.AsReadOnly
	|
	|-RVA: 0xE99990 Offset: 0xE97F90 VA: 0x180E99990
	|-AList<__Il2CppFullySharedGenericType>.AsReadOnly
	*/

	// RVA: -1 Offset: -1
	public bool Exists(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEE3F0 Offset: 0xDEC9F0 VA: 0x180DEE3F0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Exists
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Exists
	|
	|-RVA: 0xDEE440 Offset: 0xDECA40 VA: 0x180DEE440
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Exists
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Exists
	|
	|-RVA: 0xE9A4B0 Offset: 0xE98AB0 VA: 0x180E9A4B0
	|-AList<object>.Exists
	|
	|-RVA: 0xE9A550 Offset: 0xE98B50 VA: 0x180E9A550
	|-AList<__Il2CppFullySharedGenericType>.Exists
	|
	|-RVA: 0xE9A500 Offset: 0xE98B00 VA: 0x180E9A500
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Exists
	*/

	// RVA: -1 Offset: -1
	public T Find(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEF370 Offset: 0xDED970 VA: 0x180DEF370
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Find
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Find
	|
	|-RVA: 0xDEF250 Offset: 0xDED850 VA: 0x180DEF250
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Find
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Find
	|
	|-RVA: 0xE9C070 Offset: 0xE9A670 VA: 0x180E9C070
	|-AList<object>.Find
	|
	|-RVA: 0xE9BE70 Offset: 0xE9A470 VA: 0x180E9BE70
	|-AList<__Il2CppFullySharedGenericType>.Find
	|
	|-RVA: 0xE9BD90 Offset: 0xE9A390 VA: 0x180E9BD90
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Find
	*/

	// RVA: -1 Offset: -1
	public List<T> FindAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEE490 Offset: 0xDECA90 VA: 0x180DEE490
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.FindAll
	|
	|-RVA: 0xDEE630 Offset: 0xDECC30 VA: 0x180DEE630
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.FindAll
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.FindAll
	|
	|-RVA: 0xE9A850 Offset: 0xE98E50 VA: 0x180E9A850
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.FindAll
	|
	|-RVA: 0xE9A6F0 Offset: 0xE98CF0 VA: 0x180E9A6F0
	|-AList<object>.FindAll
	|
	|-RVA: 0xE9A9F0 Offset: 0xE98FF0 VA: 0x180E9A9F0
	|-AList<__Il2CppFullySharedGenericType>.FindAll
	|
	|-RVA: 0xE9A590 Offset: 0xE98B90 VA: 0x180E9A590
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.FindAll
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEE7C0 Offset: 0xDECDC0 VA: 0x180DEE7C0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.FindIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.FindIndex
	|
	|-RVA: 0xDEE9E0 Offset: 0xDECFE0 VA: 0x180DEE9E0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.FindIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.FindIndex
	|
	|-RVA: 0xE9AEC0 Offset: 0xE994C0 VA: 0x180E9AEC0
	|-AList<object>.FindIndex
	|
	|-RVA: 0xE9B240 Offset: 0xE99840 VA: 0x180E9B240
	|-AList<__Il2CppFullySharedGenericType>.FindIndex
	|
	|-RVA: 0xE9AC40 Offset: 0xE99240 VA: 0x180E9AC40
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(int startIndex, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEE830 Offset: 0xDECE30 VA: 0x180DEE830
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.FindIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.FindIndex
	|
	|-RVA: 0xDEE7F0 Offset: 0xDECDF0 VA: 0x180DEE7F0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.FindIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.FindIndex
	|
	|-RVA: 0xE9B200 Offset: 0xE99800 VA: 0x180E9B200
	|-AList<object>.FindIndex
	|
	|-RVA: 0xE9AEF0 Offset: 0xE994F0 VA: 0x180E9AEF0
	|-AList<__Il2CppFullySharedGenericType>.FindIndex
	|
	|-RVA: 0xE9AE80 Offset: 0xE99480 VA: 0x180E9AE80
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEEA10 Offset: 0xDED010 VA: 0x180DEEA10
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.FindIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.FindIndex
	|
	|-RVA: 0xDEE870 Offset: 0xDECE70 VA: 0x180DEE870
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.FindIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.FindIndex
	|
	|-RVA: 0xE9AF40 Offset: 0xE99540 VA: 0x180E9AF40
	|-AList<object>.FindIndex
	|
	|-RVA: 0xE9AC70 Offset: 0xE99270 VA: 0x180E9AC70
	|-AList<__Il2CppFullySharedGenericType>.FindIndex
	|
	|-RVA: 0xE9B0A0 Offset: 0xE996A0 VA: 0x180E9B0A0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.FindIndex
	*/

	// RVA: -1 Offset: -1
	public T FindLast(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEF120 Offset: 0xDED720 VA: 0x180DEF120
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.FindLast
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.FindLast
	|
	|-RVA: 0xDEF000 Offset: 0xDED600 VA: 0x180DEF000
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.FindLast
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.FindLast
	|
	|-RVA: 0xE9BAB0 Offset: 0xE9A0B0 VA: 0x180E9BAB0
	|-AList<object>.FindLast
	|
	|-RVA: 0xE9BB90 Offset: 0xE9A190 VA: 0x180E9BB90
	|-AList<__Il2CppFullySharedGenericType>.FindLast
	|
	|-RVA: 0xE9B9D0 Offset: 0xE99FD0 VA: 0x180E9B9D0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.FindLast
	*/

	// RVA: -1 Offset: -1
	public int FindLastIndex(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEEDC0 Offset: 0xDED3C0 VA: 0x180DEEDC0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.FindLastIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.FindLastIndex
	|
	|-RVA: 0xDEEE00 Offset: 0xDED400 VA: 0x180DEEE00
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.FindLastIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.FindLastIndex
	|
	|-RVA: 0xE9B4C0 Offset: 0xE99AC0 VA: 0x180E9B4C0
	|-AList<object>.FindLastIndex
	|
	|-RVA: 0xE9B570 Offset: 0xE99B70 VA: 0x180E9B570
	|-AList<__Il2CppFullySharedGenericType>.FindLastIndex
	|
	|-RVA: 0xE9B500 Offset: 0xE99B00 VA: 0x180E9B500
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.FindLastIndex
	*/

	// RVA: -1 Offset: -1
	public int FindLastIndex(int startIndex, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEEB90 Offset: 0xDED190 VA: 0x180DEEB90
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.FindLastIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.FindLastIndex
	|
	|-RVA: 0xDEEBC0 Offset: 0xDED1C0 VA: 0x180DEEBC0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.FindLastIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.FindLastIndex
	|
	|-RVA: 0xE9B540 Offset: 0xE99B40 VA: 0x180E9B540
	|-AList<object>.FindLastIndex
	|
	|-RVA: 0xE9B2C0 Offset: 0xE998C0 VA: 0x180E9B2C0
	|-AList<__Il2CppFullySharedGenericType>.FindLastIndex
	|
	|-RVA: 0xE9B290 Offset: 0xE99890 VA: 0x180E9B290
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.FindLastIndex
	*/

	// RVA: -1 Offset: -1
	public int FindLastIndex(int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEEBF0 Offset: 0xDED1F0 VA: 0x180DEEBF0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.FindLastIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.FindLastIndex
	|
	|-RVA: 0xDEEE40 Offset: 0xDED440 VA: 0x180DEEE40
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.FindLastIndex
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.FindLastIndex
	|
	|-RVA: 0xE9B5C0 Offset: 0xE99BC0 VA: 0x180E9B5C0
	|-AList<object>.FindLastIndex
	|
	|-RVA: 0xE9B770 Offset: 0xE99D70 VA: 0x180E9B770
	|-AList<__Il2CppFullySharedGenericType>.FindLastIndex
	|
	|-RVA: 0xE9B310 Offset: 0xE99910 VA: 0x180E9B310
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.FindLastIndex
	*/

	// RVA: -1 Offset: -1
	public void ForEach(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEF5D0 Offset: 0xDEDBD0 VA: 0x180DEF5D0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.ForEach
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.ForEach
	|
	|-RVA: 0xDEF4A0 Offset: 0xDEDAA0 VA: 0x180DEF4A0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.ForEach
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.ForEach
	|
	|-RVA: 0xE9C150 Offset: 0xE9A750 VA: 0x180E9C150
	|-AList<object>.ForEach
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.ForEach
	|
	|-RVA: 0xE9C270 Offset: 0xE9A870 VA: 0x180E9C270
	|-AList<__Il2CppFullySharedGenericType>.ForEach
	*/

	// RVA: -1 Offset: -1
	public int LastIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF16E0 Offset: 0xDEFCE0 VA: 0x180DF16E0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.LastIndexOf
	|
	|-RVA: 0xDF1460 Offset: 0xDEFA60 VA: 0x180DF1460
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.LastIndexOf
	|
	|-RVA: 0xE9FD20 Offset: 0xE9E320 VA: 0x180E9FD20
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.LastIndexOf
	|
	|-RVA: 0xE9F350 Offset: 0xE9D950 VA: 0x180E9F350
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.LastIndexOf
	|
	|-RVA: 0xE9FD80 Offset: 0xE9E380 VA: 0x180E9FD80
	|-AList<object>.LastIndexOf
	|
	|-RVA: 0xE9F850 Offset: 0xE9DE50 VA: 0x180E9F850
	|-AList<__Il2CppFullySharedGenericType>.LastIndexOf
	|
	|-RVA: 0xE9FAF0 Offset: 0xE9E0F0 VA: 0x180E9FAF0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.LastIndexOf
	*/

	// RVA: -1 Offset: -1
	public int LastIndexOf(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF14B0 Offset: 0xDEFAB0 VA: 0x180DF14B0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.LastIndexOf
	|
	|-RVA: 0xDF1260 Offset: 0xDEF860 VA: 0x180DF1260
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.LastIndexOf
	|
	|-RVA: 0xE9F7B0 Offset: 0xE9DDB0 VA: 0x180E9F7B0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.LastIndexOf
	|
	|-RVA: 0xE9F5B0 Offset: 0xE9DBB0 VA: 0x180E9F5B0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.LastIndexOf
	|
	|-RVA: 0xE9FCA0 Offset: 0xE9E2A0 VA: 0x180E9FCA0
	|-AList<object>.LastIndexOf
	|
	|-RVA: 0xE9FDC0 Offset: 0xE9E3C0 VA: 0x180E9FDC0
	|-AList<__Il2CppFullySharedGenericType>.LastIndexOf
	|
	|-RVA: 0xE9F3A0 Offset: 0xE9D9A0 VA: 0x180E9F3A0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.LastIndexOf
	*/

	// RVA: -1 Offset: -1
	public int LastIndexOf(T item, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF1550 Offset: 0xDEFB50 VA: 0x180DF1550
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.LastIndexOf
	|
	|-RVA: 0xDF12F0 Offset: 0xDEF8F0 VA: 0x180DF12F0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.LastIndexOf
	|
	|-RVA: 0xE9F420 Offset: 0xE9DA20 VA: 0x180E9F420
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.LastIndexOf
	|
	|-RVA: 0xE9FB30 Offset: 0xE9E130 VA: 0x180E9FB30
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.LastIndexOf
	|
	|-RVA: 0xE9F980 Offset: 0xE9DF80 VA: 0x180E9F980
	|-AList<object>.LastIndexOf
	|
	|-RVA: 0xE9F0E0 Offset: 0xE9D6E0 VA: 0x180E9F0E0
	|-AList<__Il2CppFullySharedGenericType>.LastIndexOf
	|
	|-RVA: 0xE9F640 Offset: 0xE9DC40 VA: 0x180E9F640
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.LastIndexOf
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF1A50 Offset: 0xDF0050 VA: 0x180DF1A50
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.RemoveAll
	|
	|-RVA: 0xDF1C60 Offset: 0xDF0260 VA: 0x180DF1C60
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.RemoveAll
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.RemoveAll
	|
	|-RVA: 0xEA0730 Offset: 0xE9ED30 VA: 0x180EA0730
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.RemoveAll
	|
	|-RVA: 0xEA0C90 Offset: 0xE9F290 VA: 0x180EA0C90
	|-AList<object>.RemoveAll
	|
	|-RVA: 0xEA0940 Offset: 0xE9EF40 VA: 0x180EA0940
	|-AList<__Il2CppFullySharedGenericType>.RemoveAll
	|
	|-RVA: 0xEA05A0 Offset: 0xE9EBA0 VA: 0x180EA05A0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public bool TrueForAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF4400 Offset: 0xDF2A00 VA: 0x180DF4400
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.TrueForAll
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.TrueForAll
	|
	|-RVA: 0xDF4320 Offset: 0xDF2920 VA: 0x180DF4320
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.TrueForAll
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.TrueForAll
	|
	|-RVA: 0xEA5390 Offset: 0xEA3990 VA: 0x180EA5390
	|-AList<object>.TrueForAll
	|
	|-RVA: 0xEA5140 Offset: 0xEA3740 VA: 0x180EA5140
	|-AList<__Il2CppFullySharedGenericType>.TrueForAll
	|
	|-RVA: 0xEA52C0 Offset: 0xEA38C0 VA: 0x180EA52C0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.TrueForAll
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF4230 Offset: 0xDF2830 VA: 0x180DF4230
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.ToArray
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.ToArray
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.ToArray
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.ToArray
	|-AList<object>.ToArray
	|-AList<__Il2CppFullySharedGenericType>.ToArray
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(int index, T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEE210 Offset: 0xDEC810 VA: 0x180DEE210
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.CopyTo
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.CopyTo
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.CopyTo
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.CopyTo
	|-AList<object>.CopyTo
	|-AList<__Il2CppFullySharedGenericType>.CopyTo
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEE280 Offset: 0xDEC880 VA: 0x180DEE280
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.CopyTo
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.CopyTo
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.CopyTo
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.CopyTo
	|-AList<object>.CopyTo
	|-AList<__Il2CppFullySharedGenericType>.CopyTo
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEDB20 Offset: 0xDEC120 VA: 0x180DEDB20
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.Clear
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.Clear
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.Clear
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.Clear
	|-AList<object>.Clear
	|-AList<__Il2CppFullySharedGenericType>.Clear
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.Clear
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF42E0 Offset: 0xDF28E0 VA: 0x180DF42E0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.TrimExcess
	|
	|-RVA: 0xDF42A0 Offset: 0xDF28A0 VA: 0x180DF42A0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.TrimExcess
	|
	|-RVA: 0xEA5000 Offset: 0xEA3600 VA: 0x180EA5000
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.TrimExcess
	|
	|-RVA: 0xEA5100 Offset: 0xEA3700 VA: 0x180EA5100
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.TrimExcess
	|
	|-RVA: 0xEA5040 Offset: 0xEA3640 VA: 0x180EA5040
	|-AList<object>.TrimExcess
	|
	|-RVA: 0xEA5080 Offset: 0xEA3680 VA: 0x180EA5080
	|-AList<__Il2CppFullySharedGenericType>.TrimExcess
	|
	|-RVA: 0xEA50C0 Offset: 0xEA36C0 VA: 0x180EA50C0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	private int tEjLndeZaVUfIdyQBTrbaBpGbryR(int , bool  = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF5CF0 Offset: 0xDF42F0 VA: 0x180DF5CF0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.tEjLndeZaVUfIdyQBTrbaBpGbryR
	|
	|-RVA: 0xDF5DF0 Offset: 0xDF43F0 VA: 0x180DF5DF0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.tEjLndeZaVUfIdyQBTrbaBpGbryR
	|
	|-RVA: 0xEA8F70 Offset: 0xEA7570 VA: 0x180EA8F70
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.tEjLndeZaVUfIdyQBTrbaBpGbryR
	|
	|-RVA: 0xEA9070 Offset: 0xEA7670 VA: 0x180EA9070
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.tEjLndeZaVUfIdyQBTrbaBpGbryR
	|
	|-RVA: 0xEA9170 Offset: 0xEA7770 VA: 0x180EA9170
	|-AList<object>.tEjLndeZaVUfIdyQBTrbaBpGbryR
	|
	|-RVA: 0xEA8E50 Offset: 0xEA7450 VA: 0x180EA8E50
	|-AList<__Il2CppFullySharedGenericType>.tEjLndeZaVUfIdyQBTrbaBpGbryR
	|
	|-RVA: 0xEA8D50 Offset: 0xEA7350 VA: 0x180EA8D50
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.tEjLndeZaVUfIdyQBTrbaBpGbryR
	*/

	// RVA: -1 Offset: -1
	private int RhnbfFiMvTDKnaNcoENPqMBlIVHjA(int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF2540 Offset: 0xDF0B40 VA: 0x180DF2540
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.RhnbfFiMvTDKnaNcoENPqMBlIVHjA
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.RhnbfFiMvTDKnaNcoENPqMBlIVHjA
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.RhnbfFiMvTDKnaNcoENPqMBlIVHjA
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.RhnbfFiMvTDKnaNcoENPqMBlIVHjA
	|-AList<object>.RhnbfFiMvTDKnaNcoENPqMBlIVHjA
	|-AList<__Il2CppFullySharedGenericType>.RhnbfFiMvTDKnaNcoENPqMBlIVHjA
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.RhnbfFiMvTDKnaNcoENPqMBlIVHjA
	*/

	// RVA: -1 Offset: -1
	private bool LfDrhzTtizQYJhCqPOdxufjdhcxHA(int , bool  = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF1850 Offset: 0xDEFE50 VA: 0x180DF1850
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.LfDrhzTtizQYJhCqPOdxufjdhcxHA
	|
	|-RVA: 0xDF1740 Offset: 0xDEFD40 VA: 0x180DF1740
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.LfDrhzTtizQYJhCqPOdxufjdhcxHA
	|
	|-RVA: 0xEA0360 Offset: 0xE9E960 VA: 0x180EA0360
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.LfDrhzTtizQYJhCqPOdxufjdhcxHA
	|
	|-RVA: 0xEA0030 Offset: 0xE9E630 VA: 0x180EA0030
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.LfDrhzTtizQYJhCqPOdxufjdhcxHA
	|
	|-RVA: 0xEA0140 Offset: 0xE9E740 VA: 0x180EA0140
	|-AList<object>.LfDrhzTtizQYJhCqPOdxufjdhcxHA
	|
	|-RVA: 0xEA0250 Offset: 0xE9E850 VA: 0x180EA0250
	|-AList<__Il2CppFullySharedGenericType>.LfDrhzTtizQYJhCqPOdxufjdhcxHA
	|
	|-RVA: 0xE9FF20 Offset: 0xE9E520 VA: 0x180E9FF20
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.LfDrhzTtizQYJhCqPOdxufjdhcxHA
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void YJOkDuQDMfFvZdbXPpkxFJvBddlub(int , T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF44F0 Offset: 0xDF2AF0 VA: 0x180DF44F0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.YJOkDuQDMfFvZdbXPpkxFJvBddlub
	|
	|-RVA: 0xDF4530 Offset: 0xDF2B30 VA: 0x180DF4530
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.YJOkDuQDMfFvZdbXPpkxFJvBddlub
	|
	|-RVA: 0xEA54A0 Offset: 0xEA3AA0 VA: 0x180EA54A0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.YJOkDuQDMfFvZdbXPpkxFJvBddlub
	|
	|-RVA: 0xEA55F0 Offset: 0xEA3BF0 VA: 0x180EA55F0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.YJOkDuQDMfFvZdbXPpkxFJvBddlub
	|
	|-RVA: 0xEA5460 Offset: 0xEA3A60 VA: 0x180EA5460
	|-AList<object>.YJOkDuQDMfFvZdbXPpkxFJvBddlub
	|
	|-RVA: 0xEA54E0 Offset: 0xEA3AE0 VA: 0x180EA54E0
	|-AList<__Il2CppFullySharedGenericType>.YJOkDuQDMfFvZdbXPpkxFJvBddlub
	|
	|-RVA: 0xEA5480 Offset: 0xEA3A80 VA: 0x180EA5480
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.YJOkDuQDMfFvZdbXPpkxFJvBddlub
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void IVNQiOmMIxVGTiKeHPluaLELjYGC(T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEFB60 Offset: 0xDEE160 VA: 0x180DEFB60
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.IVNQiOmMIxVGTiKeHPluaLELjYGC
	|
	|-RVA: 0xDEFBF0 Offset: 0xDEE1F0 VA: 0x180DEFBF0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.IVNQiOmMIxVGTiKeHPluaLELjYGC
	|
	|-RVA: 0xE9CE90 Offset: 0xE9B490 VA: 0x180E9CE90
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.IVNQiOmMIxVGTiKeHPluaLELjYGC
	|
	|-RVA: 0xE9D0C0 Offset: 0xE9B6C0 VA: 0x180E9D0C0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.IVNQiOmMIxVGTiKeHPluaLELjYGC
	|
	|-RVA: 0xE9CF20 Offset: 0xE9B520 VA: 0x180E9CF20
	|-AList<object>.IVNQiOmMIxVGTiKeHPluaLELjYGC
	|
	|-RVA: 0xE9CF90 Offset: 0xE9B590 VA: 0x180E9CF90
	|-AList<__Il2CppFullySharedGenericType>.IVNQiOmMIxVGTiKeHPluaLELjYGC
	|
	|-RVA: 0xE9CE20 Offset: 0xE9B420 VA: 0x180E9CE20
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.IVNQiOmMIxVGTiKeHPluaLELjYGC
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void JQGAUKApJCVMdNoCPkkUfqHheLHk(T[] , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF11B0 Offset: 0xDEF7B0 VA: 0x180DF11B0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.JQGAUKApJCVMdNoCPkkUfqHheLHk
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.JQGAUKApJCVMdNoCPkkUfqHheLHk
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.JQGAUKApJCVMdNoCPkkUfqHheLHk
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.JQGAUKApJCVMdNoCPkkUfqHheLHk
	|-AList<object>.JQGAUKApJCVMdNoCPkkUfqHheLHk
	|-AList<__Il2CppFullySharedGenericType>.JQGAUKApJCVMdNoCPkkUfqHheLHk
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.JQGAUKApJCVMdNoCPkkUfqHheLHk
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF2830 Offset: 0xDF0E30 VA: 0x180DF2830
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.ICollection.CopyTo
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.ICollection.CopyTo
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.ICollection.CopyTo
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.ICollection.CopyTo
	|-AList<object>.System.Collections.ICollection.CopyTo
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool TurqzUekyBdeSVLyqeMeCFsAJsErA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.TurqzUekyBdeSVLyqeMeCFsAJsErA
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.TurqzUekyBdeSVLyqeMeCFsAJsErA
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.TurqzUekyBdeSVLyqeMeCFsAJsErA
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.TurqzUekyBdeSVLyqeMeCFsAJsErA
	|-AList<object>.TurqzUekyBdeSVLyqeMeCFsAJsErA
	|-AList<__Il2CppFullySharedGenericType>.TurqzUekyBdeSVLyqeMeCFsAJsErA
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.TurqzUekyBdeSVLyqeMeCFsAJsErA
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.get_IsReadOnly
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.get_IsReadOnly
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.get_IsReadOnly
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.get_IsReadOnly
	|-AList<object>.System.Collections.IList.get_IsReadOnly
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> NuBzajrEkMvnCtBQyGmuHGFBNvOMA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF1960 Offset: 0xDEFF60 VA: 0x180DF1960
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.NuBzajrEkMvnCtBQyGmuHGFBNvOMA
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.NuBzajrEkMvnCtBQyGmuHGFBNvOMA
	|
	|-RVA: 0xDF19E0 Offset: 0xDEFFE0 VA: 0x180DF19E0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.NuBzajrEkMvnCtBQyGmuHGFBNvOMA
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.NuBzajrEkMvnCtBQyGmuHGFBNvOMA
	|
	|-RVA: 0xEA0470 Offset: 0xE9EA70 VA: 0x180EA0470
	|-AList<object>.NuBzajrEkMvnCtBQyGmuHGFBNvOMA
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.NuBzajrEkMvnCtBQyGmuHGFBNvOMA
	|
	|-RVA: 0xEA04E0 Offset: 0xE9EAE0 VA: 0x180EA04E0
	|-AList<__Il2CppFullySharedGenericType>.NuBzajrEkMvnCtBQyGmuHGFBNvOMA
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF1960 Offset: 0xDEFF60 VA: 0x180DF1960
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IEnumerable.GetEnumerator
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xDF19E0 Offset: 0xDEFFE0 VA: 0x180DF19E0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xEA0470 Offset: 0xE9EA70 VA: 0x180EA0470
	|-AList<object>.System.Collections.IEnumerable.GetEnumerator
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xEA04E0 Offset: 0xE9EAE0 VA: 0x180EA04E0
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF2B70 Offset: 0xDF1170 VA: 0x180DF2B70
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.Add
	|
	|-RVA: 0xDF2A10 Offset: 0xDF1010 VA: 0x180DF2A10
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.Add
	|
	|-RVA: 0xEA2760 Offset: 0xEA0D60 VA: 0x180EA2760
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.Add
	|
	|-RVA: 0xEA2BC0 Offset: 0xEA11C0 VA: 0x180EA2BC0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.Add
	|
	|-RVA: 0xEA2A60 Offset: 0xEA1060 VA: 0x180EA2A60
	|-AList<object>.System.Collections.IList.Add
	|
	|-RVA: 0xEA28D0 Offset: 0xEA0ED0 VA: 0x180EA28D0
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	|
	|-RVA: 0xEA2610 Offset: 0xEA0C10 VA: 0x180EA2610
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF2CE0 Offset: 0xDF12E0 VA: 0x180DF2CE0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.Contains
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.Contains
	|
	|-RVA: 0xDF3000 Offset: 0xDF1600 VA: 0x180DF3000
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.Contains
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.Contains
	|
	|-RVA: 0xEA2D20 Offset: 0xEA1320 VA: 0x180EA2D20
	|-AList<object>.System.Collections.IList.Contains
	|
	|-RVA: 0xEA2F50 Offset: 0xEA1550 VA: 0x180EA2F50
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	|
	|-RVA: 0xEA30E0 Offset: 0xEA16E0 VA: 0x180EA30E0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF32C0 Offset: 0xDF18C0 VA: 0x180DF32C0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xDF3430 Offset: 0xDF1A30 VA: 0x180DF3430
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.IndexOf
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xEA35F0 Offset: 0xEA1BF0 VA: 0x180EA35F0
	|-AList<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xEA3310 Offset: 0xEA1910 VA: 0x180EA3310
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	|
	|-RVA: 0xEA34A0 Offset: 0xEA1AA0 VA: 0x180EA34A0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF3590 Offset: 0xDF1B90 VA: 0x180DF3590
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0xDF3710 Offset: 0xDF1D10 VA: 0x180DF3710
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0xEA3BE0 Offset: 0xEA21E0 VA: 0x180EA3BE0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.Insert
	|
	|-RVA: 0xEA3D60 Offset: 0xEA2360 VA: 0x180EA3D60
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.Insert
	|
	|-RVA: 0xEA3750 Offset: 0xEA1D50 VA: 0x180EA3750
	|-AList<object>.System.Collections.IList.Insert
	|
	|-RVA: 0xEA38C0 Offset: 0xEA1EC0 VA: 0x180EA38C0
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	|
	|-RVA: 0xEA3A70 Offset: 0xEA2070 VA: 0x180EA3A70
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF3880 Offset: 0xDF1E80 VA: 0x180DF3880
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0xDF3AD0 Offset: 0xDF20D0 VA: 0x180DF3AD0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.Remove
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.Remove
	|
	|-RVA: 0xEA3ED0 Offset: 0xEA24D0 VA: 0x180EA3ED0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.Remove
	|
	|-RVA: 0xEA44C0 Offset: 0xEA2AC0 VA: 0x180EA44C0
	|-AList<object>.System.Collections.IList.Remove
	|
	|-RVA: 0xEA4120 Offset: 0xEA2720 VA: 0x180EA4120
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	|
	|-RVA: 0xEA42B0 Offset: 0xEA28B0 VA: 0x180EA42B0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF3DB0 Offset: 0xDF23B0 VA: 0x180DF3DB0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.get_Item
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.get_Item
	|
	|-RVA: 0xDF3D10 Offset: 0xDF2310 VA: 0x180DF3D10
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.get_Item
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.get_Item
	|
	|-RVA: 0xEA4850 Offset: 0xEA2E50 VA: 0x180EA4850
	|-AList<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0xEA4790 Offset: 0xEA2D90 VA: 0x180EA4790
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	|
	|-RVA: 0xEA46F0 Offset: 0xEA2CF0 VA: 0x180EA46F0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF4040 Offset: 0xDF2640 VA: 0x180DF4040
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0xDF3E60 Offset: 0xDF2460 VA: 0x180DF3E60
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.IList.set_Item
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.IList.set_Item
	|
	|-RVA: 0xEA4C50 Offset: 0xEA3250 VA: 0x180EA4C50
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.IList.set_Item
	|
	|-RVA: 0xEA4A90 Offset: 0xEA3090 VA: 0x180EA4A90
	|-AList<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0xEA48D0 Offset: 0xEA2ED0 VA: 0x180EA48D0
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	|
	|-RVA: 0xEA4E40 Offset: 0xEA3440 VA: 0x180EA4E40
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private int System.Collections.ICollection.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.ICollection.get_Count
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.ICollection.get_Count
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.ICollection.get_Count
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.ICollection.get_Count
	|-AList<object>.System.Collections.ICollection.get_Count
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_Count
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.ICollection.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.ICollection.get_IsSynchronized
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.ICollection.get_IsSynchronized
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.ICollection.get_IsSynchronized
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.ICollection.get_IsSynchronized
	|-AList<object>.System.Collections.ICollection.get_IsSynchronized
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF29A0 Offset: 0xDF0FA0 VA: 0x180DF29A0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xDF2930 Offset: 0xDF0F30 VA: 0x180DF2930
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xEA24C0 Offset: 0xEA0AC0 VA: 0x180EA24C0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xEA2530 Offset: 0xEA0B30 VA: 0x180EA2530
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xEA25A0 Offset: 0xEA0BA0 VA: 0x180EA25A0
	|-AList<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xEA23E0 Offset: 0xEA09E0 VA: 0x180EA23E0
	|-AList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xEA2450 Offset: 0xEA0A50 VA: 0x180EA2450
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public static AList<T> CreateFixedLengthList(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDEE2B0 Offset: 0xDEC8B0 VA: 0x180DEE2B0
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.CreateFixedLengthList
	|
	|-RVA: 0xDEE350 Offset: 0xDEC950 VA: 0x180DEE350
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.CreateFixedLengthList
	|
	|-RVA: 0xE9A230 Offset: 0xE98830 VA: 0x180E9A230
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.CreateFixedLengthList
	|
	|-RVA: 0xE9A370 Offset: 0xE98970 VA: 0x180E9A370
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.CreateFixedLengthList
	|
	|-RVA: 0xE9A410 Offset: 0xE98A10 VA: 0x180E9A410
	|-AList<object>.CreateFixedLengthList
	|
	|-RVA: 0xE9A160 Offset: 0xE98760 VA: 0x180E9A160
	|-AList<__Il2CppFullySharedGenericType>.CreateFixedLengthList
	|
	|-RVA: 0xE9A2D0 Offset: 0xE988D0 VA: 0x180E9A2D0
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.CreateFixedLengthList
	*/

	// RVA: -1 Offset: -1
	private static bool UFsokZQaORBbaLtCKdwQveETgGSC(object ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FDA20 Offset: 0x8FC020 VA: 0x1808FDA20
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>.UFsokZQaORBbaLtCKdwQveETgGSC
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>.UFsokZQaORBbaLtCKdwQveETgGSC
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>.UFsokZQaORBbaLtCKdwQveETgGSC
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>.UFsokZQaORBbaLtCKdwQveETgGSC
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>.UFsokZQaORBbaLtCKdwQveETgGSC
	|
	|-RVA: 0x91CEB0 Offset: 0x91B4B0 VA: 0x18091CEB0
	|-AList<object>.UFsokZQaORBbaLtCKdwQveETgGSC
	|
	|-RVA: 0x92E8D0 Offset: 0x92CED0 VA: 0x18092E8D0
	|-AList<__Il2CppFullySharedGenericType>.UFsokZQaORBbaLtCKdwQveETgGSC
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDF4560 Offset: 0xDF2B60 VA: 0x180DF4560
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<Bytes20, object>>..cctor
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<int, object>>..cctor
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<object, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV>>..cctor
	|-AList<IndexedDictionary.TjphZZjkCIatRwksGEUOCKvcpXvwA<uint, object>>..cctor
	|-AList<object>..cctor
	|-AList<__Il2CppFullySharedGenericType>..cctor
	|-AList<niVcjWyfiGBKhvdDrLudThrVJGC.YlhslVjaSaQDVhKxFkPydpuyEtSkA>..cctor
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal sealed class ReadOnlyList<T> : IReadOnlyList<T>, IReadOnlyList, IEnumerable<T>, IEnumerable // TypeDefIndex: 2991
{
	// Fields
	private readonly IList<T> odhEAQJpDCYqIfNtqvoPegLmzYne; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; }
	private object Rewired.Utils.Interfaces.IReadOnlyList.Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x906B20 Offset: 0x905120 VA: 0x180906B20
	|-ReadOnlyList<Guid>.get_Count
	|-ReadOnlyList<object>.get_Count
	|-ReadOnlyList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F4E0 Offset: 0x94DAE0 VA: 0x18094F4E0
	|-ReadOnlyList<Guid>..ctor
	|-ReadOnlyList<object>..ctor
	|-ReadOnlyList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ReadOnlyList<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F620 Offset: 0x94DC20 VA: 0x18094F620
	|-ReadOnlyList<Guid>..ctor
	|
	|-RVA: 0x94F550 Offset: 0x94DB50 VA: 0x18094F550
	|-ReadOnlyList<object>..ctor
	|
	|-RVA: 0x94F410 Offset: 0x94DA10 VA: 0x18094F410
	|-ReadOnlyList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F940 Offset: 0x94DF40 VA: 0x18094F940
	|-ReadOnlyList<Guid>.get_Item
	|
	|-RVA: 0x94FA10 Offset: 0x94E010 VA: 0x18094FA10
	|-ReadOnlyList<object>.get_Item
	|
	|-RVA: 0x94F870 Offset: 0x94DE70 VA: 0x18094F870
	|-ReadOnlyList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FD020 Offset: 0x8FB620 VA: 0x1808FD020
	|-ReadOnlyList<Guid>.Contains
	|
	|-RVA: 0x91C760 Offset: 0x91AD60 VA: 0x18091C760
	|-ReadOnlyList<object>.Contains
	|
	|-RVA: 0x94E6C0 Offset: 0x94CCC0 VA: 0x18094E6C0
	|-ReadOnlyList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F000 Offset: 0x94D600 VA: 0x18094F000
	|-ReadOnlyList<Guid>.IndexOf
	|
	|-RVA: 0x94EFA0 Offset: 0x94D5A0 VA: 0x18094EFA0
	|-ReadOnlyList<object>.IndexOf
	|
	|-RVA: 0x94F0D0 Offset: 0x94D6D0 VA: 0x18094F0D0
	|-ReadOnlyList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(IList<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94EA50 Offset: 0x94D050 VA: 0x18094EA50
	|-ReadOnlyList<Guid>.CopyTo
	|
	|-RVA: 0x94E7C0 Offset: 0x94CDC0 VA: 0x18094E7C0
	|-ReadOnlyList<object>.CopyTo
	|
	|-RVA: 0x94ED00 Offset: 0x94D300 VA: 0x18094ED00
	|-ReadOnlyList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object NkPYhWIaGjgdCzhBzzMBRYomNKcV(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F390 Offset: 0x94D990 VA: 0x18094F390
	|-ReadOnlyList<Guid>.NkPYhWIaGjgdCzhBzzMBRYomNKcV
	|
	|-RVA: 0x94F310 Offset: 0x94D910 VA: 0x18094F310
	|-ReadOnlyList<object>.NkPYhWIaGjgdCzhBzzMBRYomNKcV
	|
	|-RVA: 0x94F290 Offset: 0x94D890 VA: 0x18094F290
	|-ReadOnlyList<__Il2CppFullySharedGenericType>.NkPYhWIaGjgdCzhBzzMBRYomNKcV
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int dcqcyzwZsRiENooPrklVtpEsDLej(object ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F6F0 Offset: 0x94DCF0 VA: 0x18094F6F0
	|-ReadOnlyList<Guid>.dcqcyzwZsRiENooPrklVtpEsDLej
	|
	|-RVA: 0x94F770 Offset: 0x94DD70 VA: 0x18094F770
	|-ReadOnlyList<object>.dcqcyzwZsRiENooPrklVtpEsDLej
	|
	|-RVA: 0x94F7F0 Offset: 0x94DDF0 VA: 0x18094F7F0
	|-ReadOnlyList<__Il2CppFullySharedGenericType>.dcqcyzwZsRiENooPrklVtpEsDLej
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool yqXXHbqCigjXAXvKklVvGbSnedJw(object ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94FA70 Offset: 0x94E070 VA: 0x18094FA70
	|-ReadOnlyList<Guid>.yqXXHbqCigjXAXvKklVvGbSnedJw
	|
	|-RVA: 0x94FAF0 Offset: 0x94E0F0 VA: 0x18094FAF0
	|-ReadOnlyList<object>.yqXXHbqCigjXAXvKklVvGbSnedJw
	|
	|-RVA: 0x94FB70 Offset: 0x94E170 VA: 0x18094FB70
	|-ReadOnlyList<__Il2CppFullySharedGenericType>.yqXXHbqCigjXAXvKklVvGbSnedJw
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> MShvnEAXiCWaURvUKERdIzzrgAge() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F240 Offset: 0x94D840 VA: 0x18094F240
	|-ReadOnlyList<Guid>.MShvnEAXiCWaURvUKERdIzzrgAge
	|-ReadOnlyList<object>.MShvnEAXiCWaURvUKERdIzzrgAge
	|-ReadOnlyList<__Il2CppFullySharedGenericType>.MShvnEAXiCWaURvUKERdIzzrgAge
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F240 Offset: 0x94D840 VA: 0x18094F240
	|-ReadOnlyList<Guid>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyList<object>.System.Collections.IEnumerable.GetEnumerator
	|-ReadOnlyList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
[Serializable]
internal sealed class MappedArray<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection // TypeDefIndex: 2993
{
	// Fields
	private T[] WXiZIBawSFLMXMrNJoXHoeIAtBJR; // 0x0
	private int yyUeSyVcHDhFDxYDmWwLqPKWkhxJ; // 0x0
	private Func<int, int> EaQWmYZljOdRJbeosLMeLategQOQA; // 0x0

	// Properties
	public Func<int, int> indexMap { get; set; }
	public T Item { get; set; }
	public int Length { get; }
	private int System.Collections.Generic.ICollection<T>.Count { get; }
	public bool IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: -1 Offset: -1
	public Func<int, int> get_indexMap() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-MappedArray<object>.get_indexMap
	|-MappedArray<__Il2CppFullySharedGenericType>.get_indexMap
	*/

	// RVA: -1 Offset: -1
	public void set_indexMap(Func<int, int> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D970 Offset: 0x128BF70 VA: 0x18128D970
	|-MappedArray<object>.set_indexMap
	|-MappedArray<__Il2CppFullySharedGenericType>.set_indexMap
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] , Func<int, int> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D5A0 Offset: 0x128BBA0 VA: 0x18128D5A0
	|-MappedArray<object>..ctor
	|-MappedArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D5F0 Offset: 0x128BBF0 VA: 0x18128D5F0
	|-MappedArray<object>.get_Item
	|
	|-RVA: 0x128D650 Offset: 0x128BC50 VA: 0x18128D650
	|-MappedArray<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D790 Offset: 0x128BD90 VA: 0x18128D790
	|-MappedArray<object>.set_Item
	|
	|-RVA: 0x128D810 Offset: 0x128BE10 VA: 0x18128D810
	|-MappedArray<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969700 Offset: 0x967D00 VA: 0x180969700
	|-MappedArray<object>.get_Length
	|-MappedArray<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int fyLRopmjZojQONaaLyTnFqthGoOG() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969700 Offset: 0x967D00 VA: 0x180969700
	|-MappedArray<object>.fyLRopmjZojQONaaLyTnFqthGoOG
	|-MappedArray<__Il2CppFullySharedGenericType>.fyLRopmjZojQONaaLyTnFqthGoOG
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA2660 Offset: 0xCA0C60 VA: 0x180CA2660
	|-MappedArray<object>.get_IsReadOnly
	|-MappedArray<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B22C0 Offset: 0x10B08C0 VA: 0x1810B22C0
	|-MappedArray<object>.Add
	|-MappedArray<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CAA0 Offset: 0x128B0A0 VA: 0x18128CAA0
	|-MappedArray<object>.Clear
	|-MappedArray<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CBC0 Offset: 0x128B1C0 VA: 0x18128CBC0
	|-MappedArray<object>.Contains
	|
	|-RVA: 0x128CAD0 Offset: 0x128B0D0 VA: 0x18128CAD0
	|-MappedArray<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CBE0 Offset: 0x128B1E0 VA: 0x18128CBE0
	|-MappedArray<object>.CopyTo
	|-MappedArray<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CCB0 Offset: 0x128B2B0 VA: 0x18128CCB0
	|-MappedArray<object>.GetEnumerator
	|
	|-RVA: 0x128CC00 Offset: 0x128B200 VA: 0x18128CC00
	|-MappedArray<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CEC0 Offset: 0x128B4C0 VA: 0x18128CEC0
	|-MappedArray<object>.IndexOf
	|
	|-RVA: 0x128CD20 Offset: 0x128B320 VA: 0x18128CD20
	|-MappedArray<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void VDtCppxXbwmEshiChEEhcAlKdgdyA(int , T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D220 Offset: 0x128B820 VA: 0x18128D220
	|-MappedArray<object>.VDtCppxXbwmEshiChEEhcAlKdgdyA
	|-MappedArray<__Il2CppFullySharedGenericType>.VDtCppxXbwmEshiChEEhcAlKdgdyA
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool sWzEnceSdpQHFtRzphhdwBDLHzmEA(T ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B22C0 Offset: 0x10B08C0 VA: 0x1810B22C0
	|-MappedArray<object>.sWzEnceSdpQHFtRzphhdwBDLHzmEA
	|-MappedArray<__Il2CppFullySharedGenericType>.sWzEnceSdpQHFtRzphhdwBDLHzmEA
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void xdJYtCBOEXGmKJFMEcwKMUzUYlUB(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B22C0 Offset: 0x10B08C0 VA: 0x1810B22C0
	|-MappedArray<object>.xdJYtCBOEXGmKJFMEcwKMUzUYlUB
	|-MappedArray<__Il2CppFullySharedGenericType>.xdJYtCBOEXGmKJFMEcwKMUzUYlUB
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D300 Offset: 0x128B900 VA: 0x18128D300
	|-MappedArray<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x128D390 Offset: 0x128B990 VA: 0x18128D390
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D4F0 Offset: 0x128BAF0 VA: 0x18128D4F0
	|-MappedArray<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x128D430 Offset: 0x128BA30 VA: 0x18128D430
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private int System.Collections.ICollection.get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969700 Offset: 0x967D00 VA: 0x180969700
	|-MappedArray<object>.System.Collections.ICollection.get_Count
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D260 Offset: 0x128B860 VA: 0x18128D260
	|-MappedArray<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x128D2B0 Offset: 0x128B8B0 VA: 0x18128D2B0
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D050 Offset: 0x128B650 VA: 0x18128D050
	|-MappedArray<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x128D000 Offset: 0x128B600 VA: 0x18128D000
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CF60 Offset: 0x128B560 VA: 0x18128CF60
	|-MappedArray<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x128CFB0 Offset: 0x128B5B0 VA: 0x18128CFB0
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B22C0 Offset: 0x10B08C0 VA: 0x1810B22C0
	|-MappedArray<object>.System.Collections.IList.Add
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D0A0 Offset: 0x128B6A0 VA: 0x18128D0A0
	|-MappedArray<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x128D100 Offset: 0x128B700 VA: 0x18128D100
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CBE0 Offset: 0x128B1E0 VA: 0x18128CBE0
	|-MappedArray<object>.System.Collections.ICollection.CopyTo
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CCB0 Offset: 0x128B2B0 VA: 0x18128CCB0
	|-MappedArray<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x128CC00 Offset: 0x128B200 VA: 0x18128CC00
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D160 Offset: 0x128B760 VA: 0x18128D160
	|-MappedArray<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x128D1C0 Offset: 0x128B7C0 VA: 0x18128D1C0
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D220 Offset: 0x128B820 VA: 0x18128D220
	|-MappedArray<object>.System.Collections.IList.Insert
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B22C0 Offset: 0x10B08C0 VA: 0x1810B22C0
	|-MappedArray<object>.System.Collections.IList.Remove
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B22C0 Offset: 0x10B08C0 VA: 0x1810B22C0
	|-MappedArray<object>.System.Collections.IList.RemoveAt
	|-MappedArray<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private int lIeeRBMhZqDGFaagNIQtoJnSwXuO(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D740 Offset: 0x128BD40 VA: 0x18128D740
	|-MappedArray<object>.lIeeRBMhZqDGFaagNIQtoJnSwXuO
	|-MappedArray<__Il2CppFullySharedGenericType>.lIeeRBMhZqDGFaagNIQtoJnSwXuO
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal struct ReadOnlyArrayStruct<T> // TypeDefIndex: 2994
{
	// Fields
	private T[] zzsdLqXELkGwmgQTOdwAAIDafPJLA; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9C20 Offset: 0x8F8220 VA: 0x1808F9C20
	|-ReadOnlyArrayStruct<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9B50 Offset: 0x8F8150 VA: 0x1808F9B50
	|-ReadOnlyArrayStruct<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	|-ReadOnlyArrayStruct<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal sealed class SerializedObject : IEnumerable<SerializedObject.Field>, IEnumerable, IExportToXml, IExportToJson, IAddValue<object>, IAddKeyValue<string, object> // TypeDefIndex: 3006
{
	// Fields
	private readonly IndexedDictionary<string, SerializedObject.keMqjQvJEoFZHStLoZQhEBScpICV> WtqRjKGCBsojZgahyjWLBrixOBSzA; // 0x10
	private SerializedObject.XmlInfo UgIgZnXrNfoEfimJKdxAaJHLJWXW; // 0x18
	private Type UNafavoxaOBdgFzopFCevvWNLApTA; // 0x20
	private SerializedObject.ObjectType XToGYhWsGOmRSLTMtikYALLiDqiDA; // 0x28
	private static readonly Dictionary<Type, Dictionary<string, FieldInfo>> VGKsJygeaOEzefhfxdiyeMQLiJlc; // 0x0
	private static readonly Dictionary<Type, Dictionary<string, PropertyInfo>> QzBLOztebwPbPHutxjVNNAxJCiqP; // 0x8

	// Properties
	private bool allowDuplicateKeys { get; }
	public SerializedObject.ObjectType objectType { get; set; }
	public Type type { get; }
	public SerializedObject.XmlInfo xmlInfo { get; set; }
	public int count { get; }
	public SerializedObject.Field Item { get; }
	private bool Rewired.Utils.Interfaces.IExportToXml.writesOwnElementTag { get; }

	// Methods

	[CustomObfuscation(rename = False)]
	// RVA: 0x17F3400 Offset: 0x17F1A00 VA: 0x1817F3400
	private void .ctor() { }

	// RVA: 0x17F3410 Offset: 0x17F1A10 VA: 0x1817F3410
	private void .ctor(int ) { }

	// RVA: 0x17F33E0 Offset: 0x17F19E0 VA: 0x1817F33E0
	public void .ctor(Type , SerializedObject.ObjectType ) { }

	// RVA: 0x17F34A0 Offset: 0x17F1AA0 VA: 0x1817F34A0
	public void .ctor(Type , SerializedObject.ObjectType , int ) { }

	// RVA: 0x17F3530 Offset: 0x17F1B30 VA: 0x1817F3530
	public void .ctor(Type , IDictionary<string, object> , SerializedObject.ObjectType ) { }

	// RVA: 0x17F26A0 Offset: 0x17F0CA0 VA: 0x1817F26A0
	private bool STWxnLqdSazPnINyQYsMozuYFtpd() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public SerializedObject.ObjectType get_objectType() { }

	// RVA: 0x17F4630 Offset: 0x17F2C30 VA: 0x1817F4630
	public void set_objectType(SerializedObject.ObjectType value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Type get_type() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public SerializedObject.XmlInfo get_xmlInfo() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_xmlInfo(SerializedObject.XmlInfo value) { }

	// RVA: 0x17F3C20 Offset: 0x17F2220 VA: 0x1817F3C20
	public int get_count() { }

	// RVA: 0x17F3B60 Offset: 0x17F2160 VA: 0x1817F3B60
	public SerializedObject.Field get_Item(int index) { }

	// RVA: -1 Offset: -1
	public void Add<T>(string fieldName, T value, SerializedObject.FieldOptions options = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79A2E0 Offset: 0x7988E0 VA: 0x18079A2E0
	|-SerializedObject.Add<bool>
	|
	|-RVA: 0x79A390 Offset: 0x798990 VA: 0x18079A390
	|-SerializedObject.Add<Guid>
	|
	|-RVA: 0x79A560 Offset: 0x798B60 VA: 0x18079A560
	|-SerializedObject.Add<int>
	|-SerializedObject.Add<Int32Enum>
	|
	|-RVA: 0x79A610 Offset: 0x798C10 VA: 0x18079A610
	|-SerializedObject.Add<object>
	|
	|-RVA: 0x79A6B0 Offset: 0x798CB0 VA: 0x18079A6B0
	|-SerializedObject.Add<float>
	|
	|-RVA: 0x79A450 Offset: 0x798A50 VA: 0x18079A450
	|-SerializedObject.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17EA750 Offset: 0x17E8D50 VA: 0x1817EA750
	public void Add(Type type, string fieldName, object value, SerializedObject.FieldOptions options = 0) { }

	// RVA: 0x17EA9F0 Offset: 0x17E8FF0 VA: 0x1817EA9F0
	public void Add(string fieldName, object value) { }

	// RVA: 0x17F2630 Offset: 0x17F0C30 VA: 0x1817F2630
	public bool Remove(string fieldName) { }

	// RVA: 0x17EAA60 Offset: 0x17E9060 VA: 0x1817EAA60
	public bool Contains(string fieldName) { }

	// RVA: 0x17EAFF0 Offset: 0x17E95F0 VA: 0x1817EAFF0
	public Type GetDataType(string fieldName) { }

	// RVA: 0x17F2E80 Offset: 0x17F1480 VA: 0x1817F2E80
	public bool TryGetOriginalValue(string fieldName, out object value) { }

	// RVA: 0x17EB080 Offset: 0x17E9680 VA: 0x1817EB080
	public SerializedObject.Field GetEntry(string fieldName) { }

	// RVA: 0x17EB1A0 Offset: 0x17E97A0 VA: 0x1817EB1A0
	public object GetOriginalValue(string fieldName) { }

	// RVA: 0x17EB140 Offset: 0x17E9740 VA: 0x1817EB140
	public object GetOriginalValue(int index) { }

	// RVA: -1 Offset: -1
	public T GetOriginalValue<T>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79A770 Offset: 0x798D70 VA: 0x18079A770
	|-SerializedObject.GetOriginalValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetOriginalValue<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79A840 Offset: 0x798E40 VA: 0x18079A840
	|-SerializedObject.GetOriginalValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetDeserializedValue<T>(string fieldName, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79AF40 Offset: 0x799540 VA: 0x18079AF40
	|-SerializedObject.TryGetDeserializedValue<bool>
	|
	|-RVA: 0x79B130 Offset: 0x799730 VA: 0x18079B130
	|-SerializedObject.TryGetDeserializedValue<Guid>
	|
	|-RVA: 0x79B5E0 Offset: 0x799BE0 VA: 0x18079B5E0
	|-SerializedObject.TryGetDeserializedValue<int>
	|-SerializedObject.TryGetDeserializedValue<Int32Enum>
	|-SerializedObject.TryGetDeserializedValue<float>
	|
	|-RVA: 0x79B7D0 Offset: 0x799DD0 VA: 0x18079B7D0
	|-SerializedObject.TryGetDeserializedValue<object>
	|
	|-RVA: 0x79B330 Offset: 0x799930 VA: 0x18079B330
	|-SerializedObject.TryGetDeserializedValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetDeserializedValue<T>(int index, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79B8F0 Offset: 0x799EF0 VA: 0x18079B8F0
	|-SerializedObject.TryGetDeserializedValue<object>
	|
	|-RVA: 0x79B480 Offset: 0x799A80 VA: 0x18079B480
	|-SerializedObject.TryGetDeserializedValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetDeserializedValueByRef<T>(string fieldName, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79A910 Offset: 0x798F10 VA: 0x18079A910
	|-SerializedObject.TryGetDeserializedValueByRef<bool>
	|
	|-RVA: 0x79A990 Offset: 0x798F90 VA: 0x18079A990
	|-SerializedObject.TryGetDeserializedValueByRef<Guid>
	|
	|-RVA: 0x79ACB0 Offset: 0x7992B0 VA: 0x18079ACB0
	|-SerializedObject.TryGetDeserializedValueByRef<int>
	|-SerializedObject.TryGetDeserializedValueByRef<Int32Enum>
	|
	|-RVA: 0x79AD40 Offset: 0x799340 VA: 0x18079AD40
	|-SerializedObject.TryGetDeserializedValueByRef<object>
	|
	|-RVA: 0x79AEB0 Offset: 0x7994B0 VA: 0x18079AEB0
	|-SerializedObject.TryGetDeserializedValueByRef<float>
	|
	|-RVA: 0x79AB80 Offset: 0x799180 VA: 0x18079AB80
	|-SerializedObject.TryGetDeserializedValueByRef<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetDeserializedValueByRef<T>(int index, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79AA20 Offset: 0x799020 VA: 0x18079AA20
	|-SerializedObject.TryGetDeserializedValueByRef<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17F2C30 Offset: 0x17F1230 VA: 0x1817F2C30
	public string ToXmlString(bool writeDocumentTag) { }

	// RVA: 0x17E5CF0 Offset: 0x17E42F0 VA: 0x1817E5CF0
	public string ToJsonString() { }

	// RVA: 0x17F2830 Offset: 0x17F0E30 VA: 0x1817F2830 Slot: 3
	public override string ToString() { }

	// RVA: 0x17F2540 Offset: 0x17F0B40 VA: 0x1817F2540
	private void LvarfhFOMZjaOJqEOIHDbvsHiSNYb(XmlWriter ) { }

	// RVA: 0x17F2F40 Offset: 0x17F1540 VA: 0x1817F2F40
	private void VosDTESfLyeCAVnWOVmkXEpAByVs(XmlWriter ) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 6
	private bool TINbjGHDcnHFGYOHaPnjwseXngnqA() { }

	// RVA: 0x17F2540 Offset: 0x17F0B40 VA: 0x1817F2540 Slot: 7
	private void maxgHWfzouZKNClwplxGaitSTzhSA(XmlWriter ) { }

	// RVA: 0x17F3870 Offset: 0x17F1E70 VA: 0x1817F3870 Slot: 8
	private void geQmuvHAnXtkhhsVmTuTgWFUudoj(StringBuilder , Action<StringBuilder, object> ) { }

	// RVA: 0x17F27D0 Offset: 0x17F0DD0 VA: 0x1817F27D0 Slot: 9
	private void TEeyrZCIJwCGMERJrBmXjKkpVetbb(object ) { }

	// RVA: 0x17EA9F0 Offset: 0x17E8FF0 VA: 0x1817EA9F0 Slot: 10
	private void aJnDbNJMIolziFWaeuHAmrFNbnqFB(string , object ) { }

	// RVA: 0x17F26B0 Offset: 0x17F0CB0 VA: 0x1817F26B0 Slot: 4
	private IEnumerator<SerializedObject.Field> System.Collections.Generic.IEnumerable<Rewired.Utils.Classes.Data.SerializedObject.Field>.GetEnumerator() { }

	// RVA: 0x17F2740 Offset: 0x17F0D40 VA: 0x1817F2740 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: -1 Offset: -1
	private static bool lsnpvwJDjlpPerKsTwWwGiDThbwi<>(object , out  , NumberStyles  = 511, CultureInfo ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79BA20 Offset: 0x79A020 VA: 0x18079BA20
	|-SerializedObject.lsnpvwJDjlpPerKsTwWwGiDThbwi<bool>
	|
	|-RVA: 0x79BB50 Offset: 0x79A150 VA: 0x18079BB50
	|-SerializedObject.lsnpvwJDjlpPerKsTwWwGiDThbwi<Guid>
	|
	|-RVA: 0x79BE10 Offset: 0x79A410 VA: 0x18079BE10
	|-SerializedObject.lsnpvwJDjlpPerKsTwWwGiDThbwi<int>
	|-SerializedObject.lsnpvwJDjlpPerKsTwWwGiDThbwi<Int32Enum>
	|-SerializedObject.lsnpvwJDjlpPerKsTwWwGiDThbwi<float>
	|
	|-RVA: 0x79BF40 Offset: 0x79A540 VA: 0x18079BF40
	|-SerializedObject.lsnpvwJDjlpPerKsTwWwGiDThbwi<object>
	|
	|-RVA: 0x79BC80 Offset: 0x79A280 VA: 0x18079BC80
	|-SerializedObject.lsnpvwJDjlpPerKsTwWwGiDThbwi<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17EB210 Offset: 0x17E9810 VA: 0x1817EB210
	private static bool IadAlldIZzLOYLhGACmTnlUoIpYh(Type , object , out object , NumberStyles  = 511, CultureInfo ) { }

	// RVA: 0x17F3C70 Offset: 0x17F2270 VA: 0x1817F3C70
	private static bool qttTQCTAsSvmgNDzcnhHUuXbTlpm(Type , SerializedObject , out object , NumberStyles  = 511, CultureInfo ) { }

	// RVA: 0x17EAAD0 Offset: 0x17E90D0 VA: 0x1817EAAD0
	public static SerializedObject FromJson(Type type, string jsonString) { }

	// RVA: 0x17EACD0 Offset: 0x17E92D0 VA: 0x1817EACD0
	public static SerializedObject FromXml(Type type, string xmlString) { }

	// RVA: 0x17F32F0 Offset: 0x17F18F0 VA: 0x1817F32F0
	private static void .cctor() { }
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class NativeBuffer : IDisposable // TypeDefIndex: 3007
{
	// Fields
	private IntPtr OTtsDUWYCWojvnhoQaVqFwEOcmpfA; // 0x10
	private int mrlNNwkGzhrTvSsFCeoWdlfnHTbg; // 0x18
	private bool fDHgiGFcbHuWwvYPhjUjjPrjWRuO; // 0x1C

	// Properties
	public IntPtr Pointer { get; }
	public int Length { get; }
	public byte Item { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public IntPtr get_Pointer() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_Length() { }

	// RVA: 0x181A000 Offset: 0x1818600 VA: 0x18181A000
	public byte get_Item(int index) { }

	// RVA: 0x181A0A0 Offset: 0x18186A0 VA: 0x18181A0A0
	public void set_Item(int index, byte value) { }

	// RVA: 0x1819FD0 Offset: 0x18185D0 VA: 0x181819FD0
	public void .ctor(int ) { }

	// RVA: 0x1817980 Offset: 0x1815F80 VA: 0x181817980
	public IntPtr GetPointer(int offset = 0) { }

	// RVA: 0x18177F0 Offset: 0x1815DF0 VA: 0x1818177F0
	public string DumpToHexString() { }

	// RVA: 0x1817A10 Offset: 0x1816010 VA: 0x181817A10
	public bool ReadBit(int byteIndex, byte bit) { }

	// RVA: 0x1817B40 Offset: 0x1816140 VA: 0x181817B40
	public byte ReadByte(int startIndex) { }

	// RVA: 0x1817ED0 Offset: 0x18164D0 VA: 0x181817ED0
	public short ReadShort(int startIndex) { }

	// RVA: 0x18180E0 Offset: 0x18166E0 VA: 0x1818180E0
	public ushort ReadUShort(int startIndex) { }

	// RVA: 0x1817D70 Offset: 0x1816370 VA: 0x181817D70
	public int ReadInt(int startIndex) { }

	// RVA: 0x1817F80 Offset: 0x1816580 VA: 0x181817F80
	public uint ReadUInt(int startIndex) { }

	// RVA: 0x1817E20 Offset: 0x1816420 VA: 0x181817E20
	public long ReadLong(int startIndex) { }

	// RVA: 0x1818030 Offset: 0x1816630 VA: 0x181818030
	public ulong ReadULong(int startIndex) { }

	// RVA: 0x1817CB0 Offset: 0x18162B0 VA: 0x181817CB0
	public float ReadFloat(int startIndex) { }

	// RVA: 0x1817BF0 Offset: 0x18161F0 VA: 0x181817BF0
	public double ReadDouble(int startIndex) { }

	// RVA: 0x1818190 Offset: 0x1816790 VA: 0x181818190
	public void Read(byte[] buffer, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0) { }

	// RVA: 0x1818560 Offset: 0x1816B60 VA: 0x181818560
	public void Read(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0) { }

	// RVA: 0x1818D20 Offset: 0x1817320 VA: 0x181818D20
	public int TryReadBytes(byte[] buffer, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0) { }

	// RVA: 0x1818DC0 Offset: 0x18173C0 VA: 0x181818DC0
	public int TryReadBytes(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex = 0, int writeStartIndex = 0) { }

	// RVA: 0x1818F90 Offset: 0x1817590 VA: 0x181818F90
	public void WriteBit(int byteIndex, byte bit, bool value) { }

	// RVA: 0x1819BE0 Offset: 0x18181E0 VA: 0x181819BE0
	public void Write(byte byte, int startIndex) { }

	// RVA: 0x1819CA0 Offset: 0x18182A0 VA: 0x181819CA0
	public void Write(short bytes, int startIndex) { }

	// RVA: 0x1819B10 Offset: 0x1818110 VA: 0x181819B10
	public void Write(ushort bytes, int startIndex) { }

	// RVA: 0x18191E0 Offset: 0x18177E0 VA: 0x1818191E0
	public void Write(int bytes, int startIndex) { }

	// RVA: 0x1819F10 Offset: 0x1818510 VA: 0x181819F10
	public void Write(uint bytes, int startIndex) { }

	// RVA: 0x1819110 Offset: 0x1817710 VA: 0x181819110
	public void Write(long bytes, int startIndex) { }

	// RVA: 0x1819D70 Offset: 0x1818370 VA: 0x181819D70
	public void Write(ulong bytes, int startIndex) { }

	// RVA: 0x1819670 Offset: 0x1817C70 VA: 0x181819670
	public void Write(float bytes, int startIndex) { }

	// RVA: 0x1819E40 Offset: 0x1818440 VA: 0x181819E40
	public void Write(double bytes, int startIndex) { }

	// RVA: 0x1819740 Offset: 0x1817D40 VA: 0x181819740
	public void Write(byte[] bytes, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0) { }

	// RVA: 0x18192A0 Offset: 0x18178A0 VA: 0x1818192A0
	public void Write(IntPtr bytes, int bufferLength, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0) { }

	// RVA: 0x1818EF0 Offset: 0x18174F0 VA: 0x181818EF0
	public int TryWriteBytes(byte[] bytes, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0) { }

	// RVA: 0x1818E60 Offset: 0x1817460 VA: 0x181818E60
	public int TryWriteBytes(IntPtr bytes, int bufferLength, int numBytesToWrite, int writeStartIndex = 0, int readStartIndex = 0) { }

	// RVA: 0x1818CC0 Offset: 0x18172C0 VA: 0x181818CC0
	public int TryFill(byte value, int numBytesToWrite, int writeStartIndex = 0) { }

	// RVA: 0x18189B0 Offset: 0x1816FB0 VA: 0x1818189B0
	public bool Resize(int size, bool preserveData) { }

	// RVA: 0x1817580 Offset: 0x1815B80 VA: 0x181817580
	public void Clear() { }

	// RVA: 0x1818930 Offset: 0x1816F30 VA: 0x181818930
	public void Release() { }

	// RVA: 0x18175A0 Offset: 0x1815BA0 VA: 0x1818175A0
	public void CopyFrom(NativeBuffer other) { }

	// RVA: 0x1818BA0 Offset: 0x18171A0 VA: 0x181818BA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1817770 Offset: 0x1815D70 VA: 0x181817770 Slot: 4
	public void Dispose() { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18177D0 Offset: 0x1815DD0 VA: 0x1818177D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1815E30 Offset: 0x1814430 VA: 0x181815E30
	public static IntPtr op_Implicit(NativeBuffer buffer) { }

	// RVA: 0x1817650 Offset: 0x1815C50 VA: 0x181817650
	public static bool Copy(NativeBuffer source, NativeBuffer destination) { }
}

// Namespace: Rewired.Utils.Classes.Data
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class NativeRingBuffer : IDisposable // TypeDefIndex: 3008
{
	// Fields
	private readonly NativeBuffer QQsHMInLNSAOjkQRmFqbZUxqXFE; // 0x10
	private readonly int tvvuZdzQzCbvtDyiTUVUEwXgVTDK; // 0x18
	private long fgNIUojKGyOywcYgfduADjfmjPkkA; // 0x20
	private long hVfVnuWruqmjhQKPFTzeMbyGPbYp; // 0x28
	private int FMhjqrbzOXPloWepvbrRBYmNaCCfA; // 0x30
	private bool fDZUbtNIzILpllvAHpvbTagabEIp; // 0x34
	private uint YEKnbuulWrRtCwfIrvjbiEvUZGIu; // 0x38
	private bool FKSYWoHXcqcISqmQJjsugGBSAPxm; // 0x3C

	// Properties
	public int Capacity { get; }
	public int BytesInBuffer { get; }
	public bool BufferOverrun { get; }
	public int ReadPosition { get; }
	public long WritePosition { get; }

	// Methods

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_Capacity() { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public int get_BytesInBuffer() { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_BufferOverrun() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_ReadPosition() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public long get_WritePosition() { }

	// RVA: 0x181B230 Offset: 0x1819830 VA: 0x18181B230
	public void .ctor(int ) { }

	// RVA: 0x181A4A0 Offset: 0x1818AA0 VA: 0x18181A4A0
	public IntPtr Allocate(int bufferLength, bool zeroFill, out uint passId) { }

	// RVA: 0x181AF10 Offset: 0x1819510 VA: 0x18181AF10
	public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite, out int startOffset, out uint passId) { }

	// RVA: 0x181B090 Offset: 0x1819690 VA: 0x18181B090
	public int Write(byte[] buffer, int numBytesToWrite, out int startOffset, out uint passId) { }

	// RVA: 0x181AED0 Offset: 0x18194D0 VA: 0x18181AED0
	public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite) { }

	// RVA: 0x181B200 Offset: 0x1819800 VA: 0x18181B200
	public int Write(byte[] buffer, int numBytesToWrite) { }

	// RVA: 0x181AD80 Offset: 0x1819380 VA: 0x18181AD80
	public int Read(IntPtr buffer, int bufferLength, int numBytesToRead) { }

	// RVA: 0x181AC10 Offset: 0x1819210 VA: 0x18181AC10
	public int Read(byte[] buffer, int numBytesToRead) { }

	// RVA: 0x181A990 Offset: 0x1818F90 VA: 0x18181A990
	public int RandomRead(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex) { }

	// RVA: 0x181AAB0 Offset: 0x18190B0 VA: 0x18181AAB0
	public int RandomRead(byte[] buffer, int numBytesToRead, int readStartIndex) { }

	// RVA: 0x181A8C0 Offset: 0x1818EC0 VA: 0x18181A8C0
	public IntPtr GetPointerFromReadPosition(int offset) { }

	// RVA: 0x181A890 Offset: 0x1818E90 VA: 0x18181A890
	public int GetOffsetFromReadPosition(int offset) { }

	// RVA: 0x181A910 Offset: 0x1818F10 VA: 0x18181A910
	public bool IsValid(int startIndex, uint passId) { }

	// RVA: 0x181A570 Offset: 0x1818B70 VA: 0x18181A570
	public void CopyFrom(NativeRingBuffer other) { }

	// RVA: 0x181AEB0 Offset: 0x18194B0 VA: 0x18181AEB0
	public void Reset() { }

	// RVA: 0x181B310 Offset: 0x1819910 VA: 0x18181B310
	private void eAMQjEGJJIsSoGQUglTbwKiUvuRv(int ) { }

	// RVA: 0x181A940 Offset: 0x1818F40 VA: 0x18181A940
	private void KgtjNWhuBKplaXoAJgRIjPgwVjDY(int ) { }

	// RVA: 0x181B3C0 Offset: 0x18199C0 VA: 0x18181B3C0
	private void xfLXdPCmdkYSSKdUKaNaIVkqbvBdb() { }

	// RVA: 0x181A700 Offset: 0x1818D00 VA: 0x18181A700 Slot: 4
	public void Dispose() { }

	// RVA: 0x181A850 Offset: 0x1818E50 VA: 0x18181A850 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x181A7C0 Offset: 0x1818DC0 VA: 0x18181A7C0
	protected void Dispose(bool disposing) { }
}

// Namespace: Rewired.Utils.Classes.Data
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class NativeMemoryBlock : IDisposable // TypeDefIndex: 3009
{
	// Fields
	private int dWbRJDmMgkxISVhiTENjFJurWiwY; // 0x10
	private uint LUCyWjvouyXljQjvyscepnmCrfvH; // 0x14
	private IntPtr dwikegbHmIHYtWdlEVkUVInhlypG; // 0x18
	private bool nBwjJdXSvmsokThIKVNnSaAPhRcEA; // 0x20

	// Properties
	public uint size { get; }

	// Methods

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public uint get_size() { }

	// RVA: 0x181A370 Offset: 0x1818970 VA: 0x18181A370
	public void .ctor(uint ) { }

	// RVA: 0x181A1D0 Offset: 0x18187D0 VA: 0x18181A1D0
	public IntPtr Allocate(uint bytes, IntPtr ptrToData) { }

	// RVA: 0x181A150 Offset: 0x1818750 VA: 0x18181A150
	public IntPtr Allocate(uint bytes) { }

	// RVA: 0x181A290 Offset: 0x1818890 VA: 0x18181A290 Slot: 4
	public void Dispose() { }

	// RVA: 0x13323C0 Offset: 0x13309C0 VA: 0x1813323C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x181A2F0 Offset: 0x18188F0 VA: 0x18181A2F0 Slot: 5
	protected virtual void Dispose(bool disposing) { }
}

// Namespace: Rewired.Utils.Classes.Data
public struct TypeWrapper // TypeDefIndex: 3011
{
	// Fields
	public TypeWrapper.DataType type; // 0x0
	private dFnFpKBPBzhYQQEPPPmvVAzrPBMAA PTgbaDEtzusBYRlwzFrQEUtrxLadb; // 0x8
	private string FyfKUDfFjNdvTHnHheMMyexrBvgoA; // 0x10
	private object WEYaMCPCvBLWeOJeMVioaFckAPYcA; // 0x18

	// Methods

	// RVA: 0x181BEA0 Offset: 0x181A4A0 VA: 0x18181BEA0
	public void .ctor(TypeWrapper.DataType ) { }

	// RVA: 0x181BD90 Offset: 0x181A390 VA: 0x18181BD90
	public void .ctor(byte ) { }

	// RVA: 0x181BFE0 Offset: 0x181A5E0 VA: 0x18181BFE0
	public void .ctor(sbyte ) { }

	// RVA: 0x181BC00 Offset: 0x181A200 VA: 0x18181BC00
	public void .ctor(char ) { }

	// RVA: 0x181BB60 Offset: 0x181A160 VA: 0x18181BB60
	public void .ctor(short ) { }

	// RVA: 0x181BCA0 Offset: 0x181A2A0 VA: 0x18181BCA0
	public void .ctor(ushort ) { }

	// RVA: 0x181BF40 Offset: 0x181A540 VA: 0x18181BF40
	public void .ctor(int ) { }

	// RVA: 0x181BD40 Offset: 0x181A340 VA: 0x18181BD40
	public void .ctor(uint ) { }

	// RVA: 0x181BCF0 Offset: 0x181A2F0 VA: 0x18181BCF0
	public void .ctor(long ) { }

	// RVA: 0x181BEF0 Offset: 0x181A4F0 VA: 0x18181BEF0
	public void .ctor(ulong ) { }

	// RVA: 0x181BF90 Offset: 0x181A590 VA: 0x18181BF90
	public void .ctor(float ) { }

	// RVA: 0x181BC50 Offset: 0x181A250 VA: 0x18181BC50
	public void .ctor(double ) { }

	// RVA: 0x181BBB0 Offset: 0x181A1B0 VA: 0x18181BBB0
	public void .ctor(bool ) { }

	// RVA: 0x181BE40 Offset: 0x181A440 VA: 0x18181BE40
	public void .ctor(string ) { }

	// RVA: 0x181BDE0 Offset: 0x181A3E0 VA: 0x18181BDE0
	public void .ctor(object ) { }

	// RVA: 0x181BB10 Offset: 0x181A110 VA: 0x18181BB10
	public void Clear() { }

	// RVA: 0x181C1B0 Offset: 0x181A7B0 VA: 0x18181C1B0
	public static byte op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C580 Offset: 0x181AB80 VA: 0x18181C580
	public static sbyte op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C210 Offset: 0x181A810 VA: 0x18181C210
	public static char op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C7C0 Offset: 0x181ADC0 VA: 0x18181C7C0
	public static short op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C520 Offset: 0x181AB20 VA: 0x18181C520
	public static int op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C400 Offset: 0x181AA00 VA: 0x18181C400
	public static long op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C940 Offset: 0x181AF40 VA: 0x18181C940
	public static ushort op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C8E0 Offset: 0x181AEE0 VA: 0x18181C8E0
	public static uint op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C2D0 Offset: 0x181A8D0 VA: 0x18181C2D0
	public static ulong op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C6A0 Offset: 0x181ACA0 VA: 0x18181C6A0
	public static float op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C5E0 Offset: 0x181ABE0 VA: 0x18181C5E0
	public static double op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C030 Offset: 0x181A630 VA: 0x18181C030
	public static bool op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C700 Offset: 0x181AD00 VA: 0x18181C700
	public static string op_Implicit(TypeWrapper obj) { }

	// RVA: 0x181C150 Offset: 0x181A750 VA: 0x18181C150
	public static TypeWrapper op_Implicit(byte obj) { }

	// RVA: 0x181C640 Offset: 0x181AC40 VA: 0x18181C640
	public static TypeWrapper op_Implicit(sbyte obj) { }

	// RVA: 0x181C270 Offset: 0x181A870 VA: 0x18181C270
	public static TypeWrapper op_Implicit(char obj) { }

	// RVA: 0x181C090 Offset: 0x181A690 VA: 0x18181C090
	public static TypeWrapper op_Implicit(short obj) { }

	// RVA: 0x181C760 Offset: 0x181AD60 VA: 0x18181C760
	public static TypeWrapper op_Implicit(int obj) { }

	// RVA: 0x181C880 Offset: 0x181AE80 VA: 0x18181C880
	public static TypeWrapper op_Implicit(long obj) { }

	// RVA: 0x181C820 Offset: 0x181AE20 VA: 0x18181C820
	public static TypeWrapper op_Implicit(ushort obj) { }

	// RVA: 0x181C9A0 Offset: 0x181AFA0 VA: 0x18181C9A0
	public static TypeWrapper op_Implicit(uint obj) { }

	// RVA: 0x181C0F0 Offset: 0x181A6F0 VA: 0x18181C0F0
	public static TypeWrapper op_Implicit(ulong obj) { }

	// RVA: 0x181C330 Offset: 0x181A930 VA: 0x18181C330
	public static TypeWrapper op_Implicit(float obj) { }

	// RVA: 0x181C4C0 Offset: 0x181AAC0 VA: 0x18181C4C0
	public static TypeWrapper op_Implicit(double obj) { }

	// RVA: 0x181C460 Offset: 0x181AA60 VA: 0x18181C460
	public static TypeWrapper op_Implicit(bool obj) { }

	// RVA: 0x181C390 Offset: 0x181A990 VA: 0x18181C390
	public static TypeWrapper op_Implicit(string obj) { }
}

// Namespace: Rewired.Utils.Classes.Data
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class IntPtrWrapper // TypeDefIndex: 3012
{
	// Fields
	private IntPtr fkfiAGfwpYQvVXFTRjHHzvTlJPSI; // 0x10

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1815E20 Offset: 0x1814420 VA: 0x181815E20
	public bool get_IsValid() { }

	// RVA: 0x1815DF0 Offset: 0x18143F0 VA: 0x181815DF0
	public void .ctor(IntPtr ) { }

	// RVA: 0x1815DE0 Offset: 0x18143E0 VA: 0x181815DE0
	public void Clear() { }

	// RVA: 0x1815E30 Offset: 0x1814430 VA: 0x181815E30
	public static IntPtr op_Implicit(IntPtrWrapper obj) { }
}

// Namespace: Rewired.Utils.Classes.Data
[Serializable]
public class IntVector2 // TypeDefIndex: 3013
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14

	// Methods

	// RVA: 0x1799860 Offset: 0x1797E60 VA: 0x181799860
	public void .ctor() { }

	// RVA: 0x1669140 Offset: 0x1667740 VA: 0x181669140
	public void .ctor(int , int ) { }

	// RVA: 0x1815FB0 Offset: 0x18145B0 VA: 0x181815FB0
	public IntVector2 Clone() { }

	// RVA: 0x1816020 Offset: 0x1814620 VA: 0x181816020
	public static IntVector2 Clone(IntVector2 intVector2) { }

	// RVA: 0x1816170 Offset: 0x1814770 VA: 0x181816170
	public static IntVector2 op_Addition(IntVector2 value1, IntVector2 value2) { }

	// RVA: 0x18164F0 Offset: 0x1814AF0 VA: 0x1818164F0
	public static IntVector2 op_Subtraction(IntVector2 value1, IntVector2 value2) { }

	// RVA: 0x1816410 Offset: 0x1814A10 VA: 0x181816410
	public static IntVector2 op_Multiply(IntVector2 value1, IntVector2 value2) { }

	// RVA: 0x18162E0 Offset: 0x18148E0 VA: 0x1818162E0
	public static IntVector2 op_Division(IntVector2 value1, IntVector2 value2) { }

	// RVA: 0x18160A0 Offset: 0x18146A0 VA: 0x1818160A0
	public static IntVector2 op_Addition(IntVector2 value1, int value2) { }

	// RVA: 0x18165D0 Offset: 0x1814BD0 VA: 0x1818165D0
	public static IntVector2 op_Subtraction(IntVector2 value1, int value2) { }

	// RVA: 0x1816380 Offset: 0x1814980 VA: 0x181816380
	public static IntVector2 op_Multiply(IntVector2 value1, int value2) { }

	// RVA: 0x1816250 Offset: 0x1814850 VA: 0x181816250
	public static IntVector2 op_Division(IntVector2 value1, int value2) { }

	// RVA: 0x1816130 Offset: 0x1814730 VA: 0x181816130
	public static Vector2 op_Addition(IntVector2 value1, float value2) { }

	// RVA: 0x1816590 Offset: 0x1814B90 VA: 0x181816590
	public static Vector2 op_Subtraction(IntVector2 value1, float value2) { }

	// RVA: 0x18164B0 Offset: 0x1814AB0 VA: 0x1818164B0
	public static Vector2 op_Multiply(IntVector2 value1, float value2) { }

	// RVA: 0x1816210 Offset: 0x1814810 VA: 0x181816210
	public static Vector2 op_Division(IntVector2 value1, float value2) { }
}

// Namespace: Rewired.Utils.Classes.Data
[Serializable]
public class IntVector3 // TypeDefIndex: 3014
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14
	public int z; // 0x18

	// Methods

	// RVA: 0x18166E0 Offset: 0x1814CE0 VA: 0x1818166E0
	public void .ctor() { }

	// RVA: 0x139BDD0 Offset: 0x139A3D0 VA: 0x18139BDD0
	public void .ctor(int , int , int ) { }

	// RVA: 0x1816660 Offset: 0x1814C60 VA: 0x181816660
	public IntVector3 Clone() { }

	// RVA: 0x1816700 Offset: 0x1814D00 VA: 0x181816700
	public static IntVector3 op_Addition(IntVector3 value1, IntVector3 value2) { }

	// RVA: 0x1816C30 Offset: 0x1815230 VA: 0x181816C30
	public static IntVector3 op_Subtraction(IntVector3 value1, IntVector3 value2) { }

	// RVA: 0x1816AD0 Offset: 0x18150D0 VA: 0x181816AD0
	public static IntVector3 op_Multiply(IntVector3 value1, IntVector3 value2) { }

	// RVA: 0x18168B0 Offset: 0x1814EB0 VA: 0x1818168B0
	public static IntVector3 op_Division(IntVector3 value1, IntVector3 value2) { }

	// RVA: 0x1816810 Offset: 0x1814E10 VA: 0x181816810
	public static IntVector3 op_Addition(IntVector3 value1, int value2) { }

	// RVA: 0x1816D40 Offset: 0x1815340 VA: 0x181816D40
	public static IntVector3 op_Subtraction(IntVector3 value1, int value2) { }

	// RVA: 0x1816B90 Offset: 0x1815190 VA: 0x181816B90
	public static IntVector3 op_Multiply(IntVector3 value1, int value2) { }

	// RVA: 0x18169D0 Offset: 0x1814FD0 VA: 0x1818169D0
	public static IntVector3 op_Division(IntVector3 value1, int value2) { }

	// RVA: 0x18167C0 Offset: 0x1814DC0 VA: 0x1818167C0
	public static Vector3 op_Addition(IntVector3 value1, float value2) { }

	// RVA: 0x1816CF0 Offset: 0x18152F0 VA: 0x181816CF0
	public static Vector3 op_Subtraction(IntVector3 value1, float value2) { }

	// RVA: 0x1816A80 Offset: 0x1815080 VA: 0x181816A80
	public static Vector3 op_Multiply(IntVector3 value1, float value2) { }

	// RVA: 0x1816980 Offset: 0x1814F80 VA: 0x181816980
	public static Vector3 op_Division(IntVector3 value1, float value2) { }
}

// Namespace: Rewired.Utils.Classes.Data
[Serializable]
public class IntVector4 // TypeDefIndex: 3015
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14
	public int z; // 0x18
	public int q; // 0x1C

	// Methods

	// RVA: 0x18155B0 Offset: 0x1813BB0 VA: 0x1818155B0
	public void .ctor() { }

	// RVA: 0x1815560 Offset: 0x1813B60 VA: 0x181815560
	public void .ctor(int , int , int , int ) { }

	// RVA: 0x1816DE0 Offset: 0x18153E0 VA: 0x181816DE0
	public IntVector4 Clone() { }

	// RVA: 0x1816E70 Offset: 0x1815470 VA: 0x181816E70
	public static IntVector4 op_Addition(IntVector4 value1, IntVector4 value2) { }

	// RVA: 0x1817410 Offset: 0x1815A10 VA: 0x181817410
	public static IntVector4 op_Subtraction(IntVector4 value1, IntVector4 value2) { }

	// RVA: 0x18171C0 Offset: 0x18157C0 VA: 0x1818171C0
	public static IntVector4 op_Multiply(IntVector4 value1, IntVector4 value2) { }

	// RVA: 0x18170D0 Offset: 0x18156D0 VA: 0x1818170D0
	public static IntVector4 op_Division(IntVector4 value1, IntVector4 value2) { }

	// RVA: 0x1816F60 Offset: 0x1815560 VA: 0x181816F60
	public static IntVector4 op_Addition(IntVector4 value1, int value2) { }

	// RVA: 0x1817360 Offset: 0x1815960 VA: 0x181817360
	public static IntVector4 op_Subtraction(IntVector4 value1, int value2) { }

	// RVA: 0x18172B0 Offset: 0x18158B0 VA: 0x1818172B0
	public static IntVector4 op_Multiply(IntVector4 value1, int value2) { }

	// RVA: 0x1817010 Offset: 0x1815610 VA: 0x181817010
	public static IntVector4 op_Division(IntVector4 value1, int value2) { }

	// RVA: 0x1815680 Offset: 0x1813C80 VA: 0x181815680
	public static Vector4 op_Addition(IntVector4 value1, float value2) { }

	// RVA: 0x1815BE0 Offset: 0x18141E0 VA: 0x181815BE0
	public static Vector4 op_Subtraction(IntVector4 value1, float value2) { }

	// RVA: 0x1815B80 Offset: 0x1814180 VA: 0x181815B80
	public static Vector4 op_Multiply(IntVector4 value1, float value2) { }

	// RVA: 0x1815980 Offset: 0x1813F80 VA: 0x181815980
	public static Vector4 op_Division(IntVector4 value1, float value2) { }
}

// Namespace: Rewired.Utils.Classes.Data
[Serializable]
public class IntRect // TypeDefIndex: 3016
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14
	public int width; // 0x18
	public int height; // 0x1C

	// Properties
	public int yMin { get; set; }
	public int yMax { get; set; }
	public int xMin { get; set; }
	public int xMax { get; set; }
	public int top { get; set; }
	public int bottom { get; set; }
	public int left { get; set; }
	public int right { get; set; }

	// Methods

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_yMin() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_yMin(int value) { }

	// RVA: 0x1815F70 Offset: 0x1814570 VA: 0x181815F70
	public int get_yMax() { }

	// RVA: 0x1815F90 Offset: 0x1814590 VA: 0x181815F90
	public void set_yMax(int value) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_xMin() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_xMin(int value) { }

	// RVA: 0x1815F80 Offset: 0x1814580 VA: 0x181815F80
	public int get_xMax() { }

	// RVA: 0x1815FA0 Offset: 0x18145A0 VA: 0x181815FA0
	public void set_xMax(int value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_top() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_top(int value) { }

	// RVA: 0x1815F70 Offset: 0x1814570 VA: 0x181815F70
	public int get_bottom() { }

	// RVA: 0x1815F90 Offset: 0x1814590 VA: 0x181815F90
	public void set_bottom(int value) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_left() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_left(int value) { }

	// RVA: 0x1815F80 Offset: 0x1814580 VA: 0x181815F80
	public int get_right() { }

	// RVA: 0x1815FA0 Offset: 0x18145A0 VA: 0x181815FA0
	public void set_right(int value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1815560 Offset: 0x1813B60 VA: 0x181815560
	public void .ctor(int , int , int , int ) { }

	// RVA: 0x1815EE0 Offset: 0x18144E0 VA: 0x181815EE0
	public IntRect Clone() { }

	// RVA: 0x1815E40 Offset: 0x1814440 VA: 0x181815E40
	public static IntRect Clone(IntRect intRect) { }
}

// Namespace: Rewired.Utils.Classes.Data
[Serializable]
public class IntPadding // TypeDefIndex: 3017
{
	// Fields
	public int top; // 0x10
	public int right; // 0x14
	public int bottom; // 0x18
	public int left; // 0x1C

	// Methods

	// RVA: 0x18155B0 Offset: 0x1813BB0 VA: 0x1818155B0
	public void .ctor() { }

	// RVA: 0x1815560 Offset: 0x1813B60 VA: 0x181815560
	public void .ctor(int , int , int , int ) { }

	// RVA: 0x18154D0 Offset: 0x1813AD0 VA: 0x1818154D0
	public IntPadding Clone() { }

	// RVA: 0x18156E0 Offset: 0x1813CE0 VA: 0x1818156E0
	public static IntPadding op_Addition(IntPadding value1, IntPadding value2) { }

	// RVA: 0x1815C40 Offset: 0x1814240 VA: 0x181815C40
	public static IntPadding op_Subtraction(IntPadding value1, IntPadding value2) { }

	// RVA: 0x18159E0 Offset: 0x1813FE0 VA: 0x1818159E0
	public static IntPadding op_Multiply(IntPadding value1, IntPadding value2) { }

	// RVA: 0x1815890 Offset: 0x1813E90 VA: 0x181815890
	public static IntPadding op_Division(IntPadding value1, IntPadding value2) { }

	// RVA: 0x18155D0 Offset: 0x1813BD0 VA: 0x1818155D0
	public static IntPadding op_Addition(IntPadding value1, int value2) { }

	// RVA: 0x1815D30 Offset: 0x1814330 VA: 0x181815D30
	public static IntPadding op_Subtraction(IntPadding value1, int value2) { }

	// RVA: 0x1815AD0 Offset: 0x18140D0 VA: 0x181815AD0
	public static IntPadding op_Multiply(IntPadding value1, int value2) { }

	// RVA: 0x18157D0 Offset: 0x1813DD0 VA: 0x1818157D0
	public static IntPadding op_Division(IntPadding value1, int value2) { }

	// RVA: 0x1815680 Offset: 0x1813C80 VA: 0x181815680
	public static Vector4 op_Addition(IntPadding value1, float value2) { }

	// RVA: 0x1815BE0 Offset: 0x18141E0 VA: 0x181815BE0
	public static Vector4 op_Subtraction(IntPadding value1, float value2) { }

	// RVA: 0x1815B80 Offset: 0x1814180 VA: 0x181815B80
	public static Vector4 op_Multiply(IntPadding value1, float value2) { }

	// RVA: 0x1815980 Offset: 0x1813F80 VA: 0x181815980
	public static Vector4 op_Division(IntPadding value1, float value2) { }
}

// Namespace: Rewired.Utils.Classes.Data
[Serializable]
public class SerializableULong // TypeDefIndex: 3018
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int ulong_32BitLow; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int ulong_32BitHigh; // 0x14

	// Properties
	public ulong value { get; set; }

	// Methods

	// RVA: 0x181BAE0 Offset: 0x181A0E0 VA: 0x18181BAE0
	public ulong get_value() { }

	// RVA: 0x181BB00 Offset: 0x181A100 VA: 0x18181BB00
	public void set_value(ulong value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x181BAA0 Offset: 0x181A0A0 VA: 0x18181BAA0
	public void .ctor(SerializableULong ) { }

	// RVA: 0x181BAF0 Offset: 0x181A0F0 VA: 0x18181BAF0
	private void pirhRMYOwjAEZPmGiDyFiPtHxlyIA(ulong , out int , out int ) { }

	// RVA: 0x181BA90 Offset: 0x181A090 VA: 0x18181BA90
	private ulong JWxFkvEKtRhondiKAeixquWCatHKB(int , int ) { }

	// RVA: 0x181BA20 Offset: 0x181A020 VA: 0x18181BA20
	public SerializableULong Clone() { }
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[Serializable]
public struct Float2x : IEquatable<Float2x> // TypeDefIndex: 3023
{
	// Fields
	public const int Length = 2;
	public float a; // 0x0
	public float b; // 0x4
	private static Func<Float2x, Float2x, Float2x> _additionDelegate; // 0x0
	private static Func<Float2x, Float2x, Float2x> _subtractionDelegate; // 0x8
	private static Func<Float2x, Float2x, Float2x> _multiplicationDelegate; // 0x10
	private static Func<Float2x, Float2x, Float2x> _divisionDelegate; // 0x18

	// Properties
	public float Item { get; set; }
	public static Float2x Zero { get; }

	// Methods

	// RVA: 0x1813F80 Offset: 0x1812580 VA: 0x181813F80
	public float get_Item(int index) { }

	// RVA: 0x18140C0 Offset: 0x18126C0 VA: 0x1818140C0
	public void set_Item(int index, float value) { }

	// RVA: 0xB1E9A0 Offset: 0xB1CFA0 VA: 0x180B1E9A0
	public void .ctor(float , float ) { }

	// RVA: 0x1813A30 Offset: 0x1812030 VA: 0x181813A30
	public Float2x Clone() { }

	// RVA: 0x17C2000 Offset: 0x17C0600 VA: 0x1817C2000
	public static Float2x Clone(Float2x obj) { }

	// RVA: 0xA6F370 Offset: 0xA6D970 VA: 0x180A6F370
	public static Float2x get_Zero() { }

	// RVA: 0x1813AC0 Offset: 0x18120C0 VA: 0x181813AC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1813CE0 Offset: 0x18122E0 VA: 0x181813CE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1813A90 Offset: 0x1812090 VA: 0x181813A90 Slot: 4
	public bool Equals(Float2x other) { }

	// RVA: 0x1813F20 Offset: 0x1812520 VA: 0x181813F20 Slot: 3
	public override string ToString() { }

	// RVA: 0x18139F0 Offset: 0x1811FF0 VA: 0x1818139F0
	public static Float2x Add(Float2x value1, Float2x value2) { }

	// RVA: 0x1813EE0 Offset: 0x18124E0 VA: 0x181813EE0
	public static Float2x Subtract(Float2x value1, Float2x value2) { }

	// RVA: 0x1813EA0 Offset: 0x18124A0 VA: 0x181813EA0
	public static Float2x Multiply(Float2x value1, Float2x value2) { }

	// RVA: 0x1813A50 Offset: 0x1812050 VA: 0x181813A50
	public static Float2x Divide(Float2x value1, Float2x value2) { }

	// RVA: 0x1813B60 Offset: 0x1812160 VA: 0x181813B60
	public static Func<Float2x, Float2x, Float2x> GetAdditionDelegate() { }

	// RVA: 0x1813DE0 Offset: 0x18123E0 VA: 0x181813DE0
	public static Func<Float2x, Float2x, Float2x> GetSubtractionDelegate() { }

	// RVA: 0x1813D20 Offset: 0x1812320 VA: 0x181813D20
	public static Func<Float2x, Float2x, Float2x> GetMultiplicationDelegate() { }

	// RVA: 0x1813C20 Offset: 0x1812220 VA: 0x181813C20
	public static Func<Float2x, Float2x, Float2x> GetDivisionDelegate() { }

	// RVA: 0x17C2000 Offset: 0x17C0600 VA: 0x1817C2000
	public static Float2x op_Implicit(Vector2 obj) { }

	// RVA: 0x17C2000 Offset: 0x17C0600 VA: 0x1817C2000
	public static Vector2 op_Implicit(Float2x obj) { }

	// RVA: 0x18139F0 Offset: 0x1811FF0 VA: 0x1818139F0
	public static Float2x op_Addition(Float2x value1, Float2x value2) { }

	// RVA: 0x1813EE0 Offset: 0x18124E0 VA: 0x181813EE0
	public static Float2x op_Subtraction(Float2x value1, Float2x value2) { }

	// RVA: 0x1813EA0 Offset: 0x18124A0 VA: 0x181813EA0
	public static Float2x op_Multiply(Float2x value1, Float2x value2) { }

	// RVA: 0x1813A50 Offset: 0x1812050 VA: 0x181813A50
	public static Float2x op_Division(Float2x value1, Float2x value2) { }

	// RVA: 0x1814000 Offset: 0x1812600 VA: 0x181814000
	public static Float2x op_Addition(Float2x value1, float value2) { }

	// RVA: 0x1814090 Offset: 0x1812690 VA: 0x181814090
	public static Float2x op_Subtraction(Float2x value1, float value2) { }

	// RVA: 0x1814060 Offset: 0x1812660 VA: 0x181814060
	public static Float2x op_Multiply(Float2x value1, float value2) { }

	// RVA: 0x1814030 Offset: 0x1812630 VA: 0x181814030
	public static Float2x op_Division(Float2x value1, float value2) { }
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[Serializable]
public struct Float3x : IEquatable<Float3x> // TypeDefIndex: 3024
{
	// Fields
	public const int Length = 3;
	public float a; // 0x0
	public float b; // 0x4
	public float c; // 0x8
	private static Func<Float3x, Float3x, Float3x> _additionDelegate; // 0x0
	private static Func<Float3x, Float3x, Float3x> _subtractionDelegate; // 0x8
	private static Func<Float3x, Float3x, Float3x> _multiplicationDelegate; // 0x10
	private static Func<Float3x, Float3x, Float3x> _divisionDelegate; // 0x18

	// Properties
	public float Item { get; set; }
	public static Float3x Zero { get; }

	// Methods

	// RVA: 0x18147F0 Offset: 0x1812DF0 VA: 0x1818147F0
	public float get_Item(int index) { }

	// RVA: 0x1814960 Offset: 0x1812F60 VA: 0x181814960
	public void set_Item(int index, float value) { }

	// RVA: 0x17E7430 Offset: 0x17E5A30 VA: 0x1817E7430
	public void .ctor(float , float , float ) { }

	// RVA: 0x35E960 Offset: 0x35CF60 VA: 0x18035E960
	public Float3x Clone() { }

	// RVA: 0x1814190 Offset: 0x1812790 VA: 0x181814190
	public static Float3x Clone(Float3x obj) { }

	// RVA: 0x17E75B0 Offset: 0x17E5BB0 VA: 0x1817E75B0
	public static Float3x get_Zero() { }

	// RVA: 0x1814200 Offset: 0x1812800 VA: 0x181814200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1814460 Offset: 0x1812A60 VA: 0x181814460 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18142B0 Offset: 0x18128B0 VA: 0x1818142B0 Slot: 4
	public bool Equals(Float3x other) { }

	// RVA: 0x18146E0 Offset: 0x1812CE0 VA: 0x1818146E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1814140 Offset: 0x1812740 VA: 0x181814140
	public static Float3x Add(Float3x value1, Float3x value2) { }

	// RVA: 0x1814690 Offset: 0x1812C90 VA: 0x181814690
	public static Float3x Subtract(Float3x value1, Float3x value2) { }

	// RVA: 0x1814640 Offset: 0x1812C40 VA: 0x181814640
	public static Float3x Multiply(Float3x value1, Float3x value2) { }

	// RVA: 0x18141B0 Offset: 0x18127B0 VA: 0x1818141B0
	public static Float3x Divide(Float3x value1, Float3x value2) { }

	// RVA: 0x18142E0 Offset: 0x18128E0 VA: 0x1818142E0
	public static Func<Float3x, Float3x, Float3x> GetAdditionDelegate() { }

	// RVA: 0x1814580 Offset: 0x1812B80 VA: 0x181814580
	public static Func<Float3x, Float3x, Float3x> GetSubtractionDelegate() { }

	// RVA: 0x18144C0 Offset: 0x1812AC0 VA: 0x1818144C0
	public static Func<Float3x, Float3x, Float3x> GetMultiplicationDelegate() { }

	// RVA: 0x18143A0 Offset: 0x18129A0 VA: 0x1818143A0
	public static Func<Float3x, Float3x, Float3x> GetDivisionDelegate() { }

	// RVA: 0x35E960 Offset: 0x35CF60 VA: 0x18035E960
	public static Float3x op_Implicit(Vector3 obj) { }

	// RVA: 0x35E960 Offset: 0x35CF60 VA: 0x18035E960
	public static Vector3 op_Implicit(Float3x obj) { }

	// RVA: 0x17E75C0 Offset: 0x17E5BC0 VA: 0x1817E75C0
	public static Float3x op_Addition(Float3x value1, Float3x value2) { }

	// RVA: 0x17E73F0 Offset: 0x17E59F0 VA: 0x1817E73F0
	public static Float3x op_Subtraction(Float3x value1, Float3x value2) { }

	// RVA: 0x18148F0 Offset: 0x1812EF0 VA: 0x1818148F0
	public static Float3x op_Multiply(Float3x value1, Float3x value2) { }

	// RVA: 0x18148B0 Offset: 0x1812EB0 VA: 0x1818148B0
	public static Float3x op_Division(Float3x value1, Float3x value2) { }

	// RVA: 0x1814880 Offset: 0x1812E80 VA: 0x181814880
	public static Float3x op_Addition(Float3x value1, float value2) { }

	// RVA: 0x1814930 Offset: 0x1812F30 VA: 0x181814930
	public static Float3x op_Subtraction(Float3x value1, float value2) { }

	// RVA: 0x17E74E0 Offset: 0x17E5AE0 VA: 0x1817E74E0
	public static Float3x op_Multiply(Float3x value1, float value2) { }

	// RVA: 0x17E7660 Offset: 0x17E5C60 VA: 0x1817E7660
	public static Float3x op_Division(Float3x value1, float value2) { }
}

// Namespace: Rewired.Utils.Classes.Data
[DefaultMember("Item")]
[Serializable]
public struct Float4x : IEquatable<Float4x> // TypeDefIndex: 3025
{
	// Fields
	public const int Length = 4;
	public float a; // 0x0
	public float b; // 0x4
	public float c; // 0x8
	public float d; // 0xC
	private static Func<Float4x, Float4x, Float4x> _additionDelegate; // 0x0
	private static Func<Float4x, Float4x, Float4x> _subtractionDelegate; // 0x8
	private static Func<Float4x, Float4x, Float4x> _multiplicationDelegate; // 0x10
	private static Func<Float4x, Float4x, Float4x> _divisionDelegate; // 0x18

	// Properties
	public float Item { get; set; }
	public static Float4x Zero { get; }

	// Methods

	// RVA: 0x1815110 Offset: 0x1813710 VA: 0x181815110
	public float get_Item(int index) { }

	// RVA: 0x1815360 Offset: 0x1813960 VA: 0x181815360
	public void set_Item(int index, float value) { }

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440
	public void .ctor(float , float , float , float ) { }

	// RVA: 0x1814A60 Offset: 0x1813060 VA: 0x181814A60
	public Float4x Clone() { }

	// RVA: 0x1814A80 Offset: 0x1813080 VA: 0x181814A80
	public static Float4x Clone(Float4x obj) { }

	// RVA: 0x86A2C0 Offset: 0x8688C0 VA: 0x18086A2C0
	public static Float4x get_Zero() { }

	// RVA: 0x1814B10 Offset: 0x1813110 VA: 0x181814B10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x177A2C0 Offset: 0x17788C0 VA: 0x18177A2C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x177A1C0 Offset: 0x17787C0 VA: 0x18177A1C0 Slot: 4
	public bool Equals(Float4x other) { }

	// RVA: 0x1814FB0 Offset: 0x18135B0 VA: 0x181814FB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18149F0 Offset: 0x1812FF0 VA: 0x1818149F0
	public static Float4x Add(Float4x value1, Float4x value2) { }

	// RVA: 0x1814F40 Offset: 0x1813540 VA: 0x181814F40
	public static Float4x Subtract(Float4x value1, Float4x value2) { }

	// RVA: 0x1814ED0 Offset: 0x18134D0 VA: 0x181814ED0
	public static Float4x Multiply(Float4x value1, Float4x value2) { }

	// RVA: 0x1814AA0 Offset: 0x18130A0 VA: 0x181814AA0
	public static Float4x Divide(Float4x value1, Float4x value2) { }

	// RVA: 0x1814BD0 Offset: 0x18131D0 VA: 0x181814BD0
	public static Func<Float4x, Float4x, Float4x> GetAdditionDelegate() { }

	// RVA: 0x1814E10 Offset: 0x1813410 VA: 0x181814E10
	public static Func<Float4x, Float4x, Float4x> GetSubtractionDelegate() { }

	// RVA: 0x1814D50 Offset: 0x1813350 VA: 0x181814D50
	public static Func<Float4x, Float4x, Float4x> GetMultiplicationDelegate() { }

	// RVA: 0x1814C90 Offset: 0x1813290 VA: 0x181814C90
	public static Func<Float4x, Float4x, Float4x> GetDivisionDelegate() { }

	// RVA: 0x1814A60 Offset: 0x1813060 VA: 0x181814A60
	public static Float4x op_Implicit(Vector4 obj) { }

	// RVA: 0x1814A60 Offset: 0x1813060 VA: 0x181814A60
	public static Vector4 op_Implicit(Float4x obj) { }

	// RVA: 0x18151A0 Offset: 0x18137A0 VA: 0x1818151A0
	public static Float4x op_Addition(Float4x value1, Float4x value2) { }

	// RVA: 0x18152F0 Offset: 0x18138F0 VA: 0x1818152F0
	public static Float4x op_Subtraction(Float4x value1, Float4x value2) { }

	// RVA: 0x1815280 Offset: 0x1813880 VA: 0x181815280
	public static Float4x op_Multiply(Float4x value1, Float4x value2) { }

	// RVA: 0x1815210 Offset: 0x1813810 VA: 0x181815210
	public static Float4x op_Division(Float4x value1, Float4x value2) { }

	// RVA: 0x18151F0 Offset: 0x18137F0 VA: 0x1818151F0
	public static Float4x op_Addition(Float4x value1, float value2) { }

	// RVA: 0x1815340 Offset: 0x1813940 VA: 0x181815340
	public static Float4x op_Subtraction(Float4x value1, float value2) { }

	// RVA: 0x18152D0 Offset: 0x18138D0 VA: 0x1818152D0
	public static Float4x op_Multiply(Float4x value1, float value2) { }

	// RVA: 0x1815260 Offset: 0x1813860 VA: 0x181815260
	public static Float4x op_Division(Float4x value1, float value2) { }
}

// Namespace: Rewired.Utils.Classes.Data
[Serializable]
public struct ScreenRect // TypeDefIndex: 3026
{
	// Fields
	public float xMin; // 0x0
	public float yMin; // 0x4
	public float width; // 0x8
	public float height; // 0xC

	// Properties
	public float xMax { get; set; }
	public float yMax { get; set; }
	public Vector2 center { get; }

	// Methods

	// RVA: 0x1801440 Offset: 0x17FFA40 VA: 0x181801440
	public void .ctor(float , float , float , float ) { }

	// RVA: 0x181B620 Offset: 0x1819C20 VA: 0x18181B620
	public float get_xMax() { }

	// RVA: 0x181B6A0 Offset: 0x1819CA0 VA: 0x18181B6A0
	public void set_xMax(float value) { }

	// RVA: 0x181B630 Offset: 0x1819C30 VA: 0x18181B630
	public float get_yMax() { }

	// RVA: 0x181B6B0 Offset: 0x1819CB0 VA: 0x18181B6B0
	public void set_yMax(float value) { }

	// RVA: 0x181B5F0 Offset: 0x1819BF0 VA: 0x18181B5F0
	public Vector2 get_center() { }

	// RVA: 0x181B3E0 Offset: 0x18199E0 VA: 0x18181B3E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x181B670 Offset: 0x1819C70 VA: 0x18181B670
	public static Rect op_Implicit(ScreenRect o) { }

	// RVA: 0x181B640 Offset: 0x1819C40 VA: 0x18181B640
	public static ScreenRect op_Implicit(Rect o) { }
}

// Namespace: Rewired.Utils.Classes.Data
[Serializable]
public struct Id : IEquatable<Id>, IEquatable<uint> // TypeDefIndex: 3027
{
	// Fields
	public const uint Default = 0;
	public const uint First = 1;
	public const uint Invalid = 4294967295;
	public uint id; // 0x0

	// Methods

	// RVA: 0x18154C0 Offset: 0x1813AC0 VA: 0x1818154C0
	public static bool IsValid(Id id) { }

	// RVA: 0x18154C0 Offset: 0x1813AC0 VA: 0x1818154C0
	public static bool IsValid(uint id) { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void .ctor(uint ) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 4
	public bool Equals(Id other) { }

	// RVA: 0x58E120 Offset: 0x58C720 VA: 0x18058E120 Slot: 5
	public bool Equals(uint other) { }

	// RVA: 0x18153F0 Offset: 0x18139F0 VA: 0x1818153F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x58E130 Offset: 0x58C730 VA: 0x18058E130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58E1A0 Offset: 0x58C7A0 VA: 0x18058E1A0
	public static bool op_Equality(Id a, Id b) { }

	// RVA: 0x5C2FF0 Offset: 0x5C15F0 VA: 0x1805C2FF0
	public static bool op_Inequality(Id a, Id b) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static uint op_Implicit(Id a) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	public static Id op_Implicit(uint a) { }

	// RVA: 0x18154A0 Offset: 0x1813AA0 VA: 0x1818154A0
	public void Increment() { }
}

// Namespace: Rewired.Utils.Classes.Data
[Serializable]
public struct Bytes20 : IEquatable<Bytes20> // TypeDefIndex: 3028
{
	// Fields
	public long value0; // 0x0
	public long value1; // 0x8
	public int value2; // 0x10

	// Methods

	// RVA: 0x1803840 Offset: 0x1801E40 VA: 0x181803840
	public void .ctor(byte[] ) { }

	// RVA: 0x1803610 Offset: 0x1801C10 VA: 0x181803610
	public byte[] GetBytes() { }

	// RVA: 0x1803500 Offset: 0x1801B00 VA: 0x181803500 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18036F0 Offset: 0x1801CF0 VA: 0x1818036F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18035C0 Offset: 0x1801BC0 VA: 0x1818035C0 Slot: 4
	public bool Equals(Bytes20 other) { }

	// RVA: 0x1803920 Offset: 0x1801F20 VA: 0x181803920
	public static bool op_Equality(Bytes20 a, Bytes20 b) { }

	// RVA: 0x1803990 Offset: 0x1801F90 VA: 0x181803990
	public static bool op_Inequality(Bytes20 a, Bytes20 b) { }

	// RVA: 0x1803750 Offset: 0x1801D50 VA: 0x181803750 Slot: 3
	public override string ToString() { }
}

// Namespace: Rewired.Utils.Classes.Data
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public struct SerializableGuid : IEquatable<SerializableGuid> // TypeDefIndex: 3029
{
	// Fields
	private const int length = 16;
	public static readonly SerializableGuid Empty; // 0x0
	private long _a; // 0x0
	private long _b; // 0x8

	// Methods

	// RVA: 0x181B9A0 Offset: 0x1819FA0 VA: 0x18181B9A0
	public void .ctor(Guid ) { }

	// RVA: 0x181B780 Offset: 0x1819D80 VA: 0x18181B780
	public byte[] GetBytes() { }

	// RVA: 0x181B870 Offset: 0x1819E70 VA: 0x18181B870
	public Guid ToGuid() { }

	// RVA: 0x181B6C0 Offset: 0x1819CC0 VA: 0x18181B6C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x181B830 Offset: 0x1819E30 VA: 0x18181B830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x181B760 Offset: 0x1819D60 VA: 0x18181B760 Slot: 4
	public bool Equals(SerializableGuid other) { }

	// RVA: 0x181B760 Offset: 0x1819D60 VA: 0x18181B760
	public static bool op_Equality(SerializableGuid a, SerializableGuid b) { }

	// RVA: 0x181B9F0 Offset: 0x1819FF0 VA: 0x18181B9F0
	public static bool op_Inequality(SerializableGuid a, SerializableGuid b) { }

	// RVA: 0x181B910 Offset: 0x1819F10 VA: 0x18181B910 Slot: 3
	public override string ToString() { }

	// RVA: 0x181B950 Offset: 0x1819F50 VA: 0x18181B950
	public string ToString(string format) { }

	// RVA: 0x181B8B0 Offset: 0x1819EB0 VA: 0x18181B8B0
	public string ToString(string format, IFormatProvider provider) { }
}

// Namespace: Rewired.Utils.Classes.Data
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal sealed class GetSetValue<T> : IGetSetValue<T>, IGetValue<T>, ISetValue<T> // TypeDefIndex: 3030
{
	// Fields
	private Func<T> pzaLLDpDlbJNHHJzOESklPeSAwYv; // 0x0
	private Action<T> moJgbxMsrqvkwmKVfrFDNoYlEkLJA; // 0x0

	// Properties
	public Func<T> getValueDelegate { get; set; }
	public Action<T> setValueDelegate { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public Func<T> get_getValueDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-GetSetValue<bool>.get_getValueDelegate
	|-GetSetValue<int>.get_getValueDelegate
	|-GetSetValue<Int32Enum>.get_getValueDelegate
	|-GetSetValue<__Il2CppFullySharedGenericType>.get_getValueDelegate
	*/

	// RVA: -1 Offset: -1
	public void set_getValueDelegate(Func<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-GetSetValue<bool>.set_getValueDelegate
	|-GetSetValue<int>.set_getValueDelegate
	|-GetSetValue<Int32Enum>.set_getValueDelegate
	|-GetSetValue<__Il2CppFullySharedGenericType>.set_getValueDelegate
	*/

	// RVA: -1 Offset: -1
	public Action<T> get_setValueDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-GetSetValue<bool>.get_setValueDelegate
	|-GetSetValue<int>.get_setValueDelegate
	|-GetSetValue<Int32Enum>.get_setValueDelegate
	|-GetSetValue<__Il2CppFullySharedGenericType>.get_setValueDelegate
	*/

	// RVA: -1 Offset: -1
	public void set_setValueDelegate(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	|-GetSetValue<bool>.set_setValueDelegate
	|-GetSetValue<int>.set_setValueDelegate
	|-GetSetValue<Int32Enum>.set_setValueDelegate
	|-GetSetValue<__Il2CppFullySharedGenericType>.set_setValueDelegate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> , Action<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	|-GetSetValue<bool>..ctor
	|-GetSetValue<int>..ctor
	|-GetSetValue<Int32Enum>..ctor
	|-GetSetValue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102B3E0 Offset: 0x10299E0 VA: 0x18102B3E0
	|-GetSetValue<bool>.GetValue
	|-GetSetValue<int>.GetValue
	|-GetSetValue<Int32Enum>.GetValue
	|
	|-RVA: 0x102B450 Offset: 0x1029A50 VA: 0x18102B450
	|-GetSetValue<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void SetValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102B540 Offset: 0x1029B40 VA: 0x18102B540
	|-GetSetValue<bool>.SetValue
	|-GetSetValue<int>.SetValue
	|-GetSetValue<Int32Enum>.SetValue
	|
	|-RVA: 0x102B5B0 Offset: 0x1029BB0 VA: 0x18102B5B0
	|-GetSetValue<__Il2CppFullySharedGenericType>.SetValue
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal sealed class KeyedGetSetValueStore<TKey> : IDictionary<TKey, object>, ICollection<KeyValuePair<TKey, object>>, IEnumerable<KeyValuePair<TKey, object>>, IEnumerable // TypeDefIndex: 3031
{
	// Fields
	private readonly Dictionary<TKey, object> sAjcIEOIkkSMIPaQwEOhADCXEsKcA; // 0x0
	private readonly bool hNqkVBvUhWiAxgKQwRYiheZBnYTU; // 0x0

	// Properties
	public int Count { get; }
	public bool isReadOnlyCollection { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,System.Object>.Keys { get; }
	private ICollection<object> System.Collections.Generic.IDictionary<TKey,System.Object>.Values { get; }
	private object System.Collections.Generic.IDictionary<TKey,System.Object>.Item { get; set; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B7E0 Offset: 0x1109DE0 VA: 0x18110B7E0
	|-KeyedGetSetValueStore<object>.get_Count
	|
	|-RVA: 0x110B810 Offset: 0x1109E10 VA: 0x18110B810
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_isReadOnlyCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	|-KeyedGetSetValueStore<object>.get_isReadOnlyCollection
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.get_isReadOnlyCollection
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, object> , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C350 Offset: 0x110A950 VA: 0x18110C350
	|-KeyedGetSetValueStore<object>..ctor
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C3A0 Offset: 0x110A9A0 VA: 0x18110C3A0
	|-KeyedGetSetValueStore<object>..ctor
	|
	|-RVA: 0x110C2C0 Offset: 0x110A8C0 VA: 0x18110C2C0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddItem<TValue>(TKey key, IGetSetValue<TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6035B0 Offset: 0x601BB0 VA: 0x1806035B0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.AddItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public IGetSetValue<TValue> GetItem<TValue>(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603880 Offset: 0x601E80 VA: 0x180603880
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.GetItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool RemoveItem<TValue>(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603CA0 Offset: 0x6022A0 VA: 0x180603CA0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.RemoveItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B340 Offset: 0x1109940 VA: 0x18110B340
	|-KeyedGetSetValueStore<object>.ContainsKey
	|
	|-RVA: 0x110B370 Offset: 0x1109970 VA: 0x18110B370
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B2C0 Offset: 0x11098C0 VA: 0x18110B2C0
	|-KeyedGetSetValueStore<object>.Clear
	|
	|-RVA: 0x110B260 Offset: 0x1109860 VA: 0x18110B260
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue<TValue>(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603710 Offset: 0x601D10 VA: 0x180603710
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.ContainsValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public TValue GetValue<TValue>(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603A80 Offset: 0x602080 VA: 0x180603A80
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetValue<TValue>(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603DB0 Offset: 0x6023B0 VA: 0x180603DB0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.SetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue<TValue>(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603FD0 Offset: 0x6025D0 VA: 0x180603FD0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.TryGetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TrySetValue<TValue>(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6042A0 Offset: 0x6028A0 VA: 0x1806042A0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.TrySetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void aqYvkNgwucsCQXOXOsHXFfTbYkoj() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C430 Offset: 0x110AA30 VA: 0x18110C430
	|-KeyedGetSetValueStore<object>.aqYvkNgwucsCQXOXOsHXFfTbYkoj
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.aqYvkNgwucsCQXOXOsHXFfTbYkoj
	*/

	// RVA: -1 Offset: -1
	private static void CyuExEvDzEEuhUixOipoBEnZoawo(TKey , Type ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B5D0 Offset: 0x1109BD0 VA: 0x18110B5D0
	|-KeyedGetSetValueStore<object>.CyuExEvDzEEuhUixOipoBEnZoawo
	|
	|-RVA: 0x110B470 Offset: 0x1109A70 VA: 0x18110B470
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.CyuExEvDzEEuhUixOipoBEnZoawo
	*/

	// RVA: -1 Offset: -1
	private static string VieRogTJFSofjQTjoALPoNGEoHsx(TKey , Type ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C020 Offset: 0x110A620 VA: 0x18110C020
	|-KeyedGetSetValueStore<object>.VieRogTJFSofjQTjoALPoNGEoHsx
	|
	|-RVA: 0x110BCD0 Offset: 0x110A2D0 VA: 0x18110BCD0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.VieRogTJFSofjQTjoALPoNGEoHsx
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void PNBqdCNrOZrNqjvjfQFguskbmlUg(TKey , object ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B850 Offset: 0x1109E50 VA: 0x18110B850
	|-KeyedGetSetValueStore<object>.PNBqdCNrOZrNqjvjfQFguskbmlUg
	|
	|-RVA: 0x110B8D0 Offset: 0x1109ED0 VA: 0x18110B8D0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.PNBqdCNrOZrNqjvjfQFguskbmlUg
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool ySPtsZYAeYgUTCgjrHiIBmCaGNNl(TKey ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CE00 Offset: 0x110B400 VA: 0x18110CE00
	|-KeyedGetSetValueStore<object>.ySPtsZYAeYgUTCgjrHiIBmCaGNNl
	|
	|-RVA: 0x110CD10 Offset: 0x110B310 VA: 0x18110CD10
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.ySPtsZYAeYgUTCgjrHiIBmCaGNNl
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> uQKdEpkmkEAFfIgPEZismyjhpLIqB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CBE0 Offset: 0x110B1E0 VA: 0x18110CBE0
	|-KeyedGetSetValueStore<object>.uQKdEpkmkEAFfIgPEZismyjhpLIqB
	|
	|-RVA: 0x110CB90 Offset: 0x110B190 VA: 0x18110CB90
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.uQKdEpkmkEAFfIgPEZismyjhpLIqB
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool xpzJWoavisPQsbOVASZABoBSsKWm(TKey ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CC90 Offset: 0x110B290 VA: 0x18110CC90
	|-KeyedGetSetValueStore<object>.xpzJWoavisPQsbOVASZABoBSsKWm
	|
	|-RVA: 0x603CA0 Offset: 0x6022A0 VA: 0x180603CA0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.xpzJWoavisPQsbOVASZABoBSsKWm
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private bool lOpIFYUVSMSdplPmcBuLbgCzhoRnA(TKey , out object ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CB60 Offset: 0x110B160 VA: 0x18110CB60
	|-KeyedGetSetValueStore<object>.lOpIFYUVSMSdplPmcBuLbgCzhoRnA
	|
	|-RVA: 0x110CA60 Offset: 0x110B060 VA: 0x18110CA60
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.lOpIFYUVSMSdplPmcBuLbgCzhoRnA
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<object> uycQdtVJpDuOwKKbONHzxXeLuIFH() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CC60 Offset: 0x110B260 VA: 0x18110CC60
	|-KeyedGetSetValueStore<object>.uycQdtVJpDuOwKKbONHzxXeLuIFH
	|
	|-RVA: 0x110CC10 Offset: 0x110B210 VA: 0x18110CC10
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.uycQdtVJpDuOwKKbONHzxXeLuIFH
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private object WbFHmxZadhIqSQUWxzAJZXGMowCd(TKey ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C190 Offset: 0x110A790 VA: 0x18110C190
	|-KeyedGetSetValueStore<object>.WbFHmxZadhIqSQUWxzAJZXGMowCd
	|
	|-RVA: 0x110C1C0 Offset: 0x110A7C0 VA: 0x18110C1C0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.WbFHmxZadhIqSQUWxzAJZXGMowCd
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void kTPRaTIIcPCxGlqMdEpcHviBmGfAA(TKey , object ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C8A0 Offset: 0x110AEA0 VA: 0x18110C8A0
	|-KeyedGetSetValueStore<object>.kTPRaTIIcPCxGlqMdEpcHviBmGfAA
	|
	|-RVA: 0x110C930 Offset: 0x110AF30 VA: 0x18110C930
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.kTPRaTIIcPCxGlqMdEpcHviBmGfAA
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void jcQORzgFKQFEnDMpFykihuJGawqL(KeyValuePair<TKey, object> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C780 Offset: 0x110AD80 VA: 0x18110C780
	|-KeyedGetSetValueStore<object>.jcQORzgFKQFEnDMpFykihuJGawqL
	|
	|-RVA: 0x110C620 Offset: 0x110AC20 VA: 0x18110C620
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.jcQORzgFKQFEnDMpFykihuJGawqL
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void FRMiBSDfzVFOIbrXikJIzbceDbSQ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B650 Offset: 0x1109C50 VA: 0x18110B650
	|-KeyedGetSetValueStore<object>.FRMiBSDfzVFOIbrXikJIzbceDbSQ
	|
	|-RVA: 0x110B6F0 Offset: 0x1109CF0 VA: 0x18110B6F0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.FRMiBSDfzVFOIbrXikJIzbceDbSQ
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool gXkpyaohCGQVpnEYoYNjsahOTrx(KeyValuePair<TKey, object> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C490 Offset: 0x110AA90 VA: 0x18110C490
	|-KeyedGetSetValueStore<object>.gXkpyaohCGQVpnEYoYNjsahOTrx
	|
	|-RVA: 0x110C560 Offset: 0x110AB60 VA: 0x18110C560
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.gXkpyaohCGQVpnEYoYNjsahOTrx
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void RnUWZolrKpbgjmghQJNJREsaAvsS(KeyValuePair<TKey, object>[] , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110BC00 Offset: 0x110A200 VA: 0x18110BC00
	|-KeyedGetSetValueStore<object>.RnUWZolrKpbgjmghQJNJREsaAvsS
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.RnUWZolrKpbgjmghQJNJREsaAvsS
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int PANagDPcfoVppILeXymWHCSzpQml() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B7E0 Offset: 0x1109DE0 VA: 0x18110B7E0
	|-KeyedGetSetValueStore<object>.PANagDPcfoVppILeXymWHCSzpQml
	|
	|-RVA: 0x110B810 Offset: 0x1109E10 VA: 0x18110B810
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.PANagDPcfoVppILeXymWHCSzpQml
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool cyZuEsEWZEeRXMNIgtQiPjxJRBVJ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	|-KeyedGetSetValueStore<object>.cyZuEsEWZEeRXMNIgtQiPjxJRBVJ
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.cyZuEsEWZEeRXMNIgtQiPjxJRBVJ
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool QrpIUGRTOVDuVStvJxXiqlygKAZC(KeyValuePair<TKey, object> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110BAE0 Offset: 0x110A0E0 VA: 0x18110BAE0
	|-KeyedGetSetValueStore<object>.QrpIUGRTOVDuVStvJxXiqlygKAZC
	|
	|-RVA: 0x110B9F0 Offset: 0x1109FF0 VA: 0x18110B9F0
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.QrpIUGRTOVDuVStvJxXiqlygKAZC
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator<KeyValuePair<TKey, object>> FTpRaWRUnHbryJqGTSVFlazUNpno() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B760 Offset: 0x1109D60 VA: 0x18110B760
	|-KeyedGetSetValueStore<object>.FTpRaWRUnHbryJqGTSVFlazUNpno
	|
	|-RVA: 0xD34F10 Offset: 0xD33510 VA: 0x180D34F10
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.FTpRaWRUnHbryJqGTSVFlazUNpno
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B760 Offset: 0x1109D60 VA: 0x18110B760
	|-KeyedGetSetValueStore<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD34F10 Offset: 0xD33510 VA: 0x180D34F10
	|-KeyedGetSetValueStore<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class InspectorValue<T> // TypeDefIndex: 3034
{
	// Fields
	private T LtckDfZzAjSPoxcMMrjPrBleADZd; // 0x0
	private bool taxuvSYvjcTvhizcgoCQKkDgiTRc; // 0x0

	// Properties
	public bool isSet { get; }
	public T value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_isSet() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB698E0 Offset: 0xB67EE0 VA: 0x180B698E0
	|-InspectorValue<__Il2CppFullySharedGenericType>.get_isSet
	*/

	// RVA: -1 Offset: -1
	public T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x86E550 Offset: 0x86CB50 VA: 0x18086E550
	|-InspectorValue<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1
	public void set_value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7170 Offset: 0x10B5770 VA: 0x1810B7170
	|-InspectorValue<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1
	public bool SetIfChanged(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B6EF0 Offset: 0x10B54F0 VA: 0x1810B6EF0
	|-InspectorValue<__Il2CppFullySharedGenericType>.SetIfChanged
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B6E40 Offset: 0x10B5440 VA: 0x1810B6E40
	|-InspectorValue<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-InspectorValue<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Rewired.Utils.Classes.Data
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class InspectorListValue<T> // TypeDefIndex: 3035
{
	// Fields
	private IList<T> SOkVSPuOsfAbfCJmMgciRqgeqvJk; // 0x0
	private readonly List<T> rRFEutswISSwcUFGzEiwEMZHyMaJA; // 0x0
	private bool XkLAzKUISOYNBQbcBOMOfBVCMhas; // 0x0

	// Properties
	public bool isSet { get; }
	public IList<T> value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_isSet() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	|-InspectorListValue<__Il2CppFullySharedGenericType>.get_isSet
	*/

	// RVA: -1 Offset: -1
	public IList<T> get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-InspectorListValue<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1
	public void set_value(IList<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B6DC0 Offset: 0x10B53C0 VA: 0x1810B6DC0
	|-InspectorListValue<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1
	public bool SetIfChanged(IList<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B6930 Offset: 0x10B4F30 VA: 0x1810B6930
	|-InspectorListValue<__Il2CppFullySharedGenericType>.SetIfChanged
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B68D0 Offset: 0x10B4ED0 VA: 0x1810B68D0
	|-InspectorListValue<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	private static bool bVTbpUIgrffJQFcCvdaKyamnOEXRA(IList<T> , IList<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B6A90 Offset: 0x10B5090 VA: 0x1810B6A90
	|-InspectorListValue<__Il2CppFullySharedGenericType>.bVTbpUIgrffJQFcCvdaKyamnOEXRA
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B6A00 Offset: 0x10B5000 VA: 0x1810B6A00
	|-InspectorListValue<__Il2CppFullySharedGenericType>..ctor
	*/
}

