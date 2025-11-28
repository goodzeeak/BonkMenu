// Namespace: Newtonsoft.Json.Linq
public enum CommentHandling // TypeDefIndex: 8450
{
	// Fields
	public int value__; // 0x0
	public const CommentHandling Ignore = 0;
	public const CommentHandling Load = 1;
}

// Namespace: Newtonsoft.Json.Linq
public enum DuplicatePropertyNameHandling // TypeDefIndex: 8451
{
	// Fields
	public int value__; // 0x0
	public const DuplicatePropertyNameHandling Replace = 0;
	public const DuplicatePropertyNameHandling Ignore = 1;
	public const DuplicatePropertyNameHandling Error = 2;
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[Extension]
public static class Extensions // TypeDefIndex: 8460
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<JToken> Ancestors<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x700260 Offset: 0x6FE860 VA: 0x180700260
	|-Extensions.Ancestors<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<JToken> AncestorsAndSelf<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x700260 Offset: 0x6FE860 VA: 0x180700260
	|-Extensions.AncestorsAndSelf<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<JToken> Descendants<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x700260 Offset: 0x6FE860 VA: 0x180700260
	|-Extensions.Descendants<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<JToken> DescendantsAndSelf<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x700260 Offset: 0x6FE860 VA: 0x180700260
	|-Extensions.DescendantsAndSelf<object>
	*/

	[Extension]
	// RVA: 0x1634D60 Offset: 0x1633360 VA: 0x181634D60
	public static IJEnumerable<JProperty> Properties(IEnumerable<JObject> source) { }

	[Extension]
	// RVA: 0x1635060 Offset: 0x1633660 VA: 0x181635060
	public static IJEnumerable<JToken> Values(IEnumerable<JToken> source, object key) { }

	[Extension]
	// RVA: 0x16350E0 Offset: 0x16336E0 VA: 0x1816350E0
	public static IJEnumerable<JToken> Values(IEnumerable<JToken> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<U> Values<U>(IEnumerable<JToken> source, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x701420 Offset: 0x6FFA20 VA: 0x180701420
	|-Extensions.Values<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<U> Values<U>(IEnumerable<JToken> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7013E0 Offset: 0x6FF9E0 VA: 0x1807013E0
	|-Extensions.Values<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	[Extension]
	// RVA: -1 Offset: -1
	public static U Value<U>(IEnumerable<JToken> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7011D0 Offset: 0x6FF7D0 VA: 0x1807011D0
	|-Extensions.Value<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static U Value<T, U>(IEnumerable<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x701290 Offset: 0x6FF890 VA: 0x180701290
	|-Extensions.Value<object, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Extensions.<Values>d__11<T, U>))]
	[Extension]
	// RVA: -1 Offset: -1
	internal static IEnumerable<U> Values<T, U>(IEnumerable<T> source, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E3130 Offset: 0x6E1730 VA: 0x1806E3130
	|-Extensions.Values<object, object>
	|
	|-RVA: 0x6E3010 Offset: 0x6E1610 VA: 0x1806E3010
	|-Extensions.Values<object, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<JToken> Children<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x700890 Offset: 0x6FEE90 VA: 0x180700890
	|-Extensions.Children<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<U> Children<T, U>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x700670 Offset: 0x6FEC70 VA: 0x180700670
	|-Extensions.Children<object, object>
	|
	|-RVA: 0x7004B0 Offset: 0x6FEAB0 VA: 0x1807004B0
	|-Extensions.Children<object, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(Extensions.<Convert>d__14<T, U>))]
	[Extension]
	// RVA: -1 Offset: -1
	internal static IEnumerable<U> Convert<T, U>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DC610 Offset: 0x6DAC10 VA: 0x1806DC610
	|-Extensions.Convert<object, object>
	|
	|-RVA: 0x6DC4C0 Offset: 0x6DAAC0 VA: 0x1806DC4C0
	|-Extensions.Convert<object, __Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	[Extension]
	// RVA: -1 Offset: -1
	internal static U Convert<T, U>(T token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x700E00 Offset: 0x6FF400 VA: 0x180700E00
	|-Extensions.Convert<object, object>
	|
	|-RVA: 0x7008E0 Offset: 0x6FEEE0 VA: 0x1807008E0
	|-Extensions.Convert<object, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1634B00 Offset: 0x1633100 VA: 0x181634B00
	public static IJEnumerable<JToken> AsJEnumerable(IEnumerable<JToken> source) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IJEnumerable<T> AsJEnumerable<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x700410 Offset: 0x6FEA10 VA: 0x180700410
	|-Extensions.AsJEnumerable<object>
	*/
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[DefaultMember("Item")]
public interface IJEnumerable<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 8461
{
	// Properties
	public abstract IJEnumerable<JToken> Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IJEnumerable<JToken> get_Item(object key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IJEnumerable<object>.get_Item
	*/
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 8464
{
	// Fields
	private readonly List<JToken> _values; // 0x58

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public override JToken Item { get; set; }
	public JToken Item { get; set; }
	public bool IsReadOnly { get; }

	// Methods

	[AsyncStateMachine(typeof(JArray.<WriteToAsync>d__0))]
	// RVA: 0x1635E70 Offset: 0x1634470 VA: 0x181635E70 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x1635760 Offset: 0x1633D60 VA: 0x181635760
	public static Task<JArray> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JArray.<LoadAsync>d__2))]
	// RVA: 0x16358A0 Offset: 0x1633EA0 VA: 0x1816358A0
	public static Task<JArray> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x16360A0 Offset: 0x16346A0 VA: 0x1816360A0
	public void .ctor() { }

	// RVA: 0x16361C0 Offset: 0x16347C0 VA: 0x1816361C0
	public void .ctor(JArray other) { }

	// RVA: 0x1636120 Offset: 0x1634720 VA: 0x181636120
	public void .ctor(object[] content) { }

	// RVA: 0x1636120 Offset: 0x1634720 VA: 0x181636120
	public void .ctor(object content) { }

	// RVA: 0x1635290 Offset: 0x1633890 VA: 0x181635290 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x1635190 Offset: 0x1633790 VA: 0x181635190 Slot: 13
	internal override JToken CloneToken() { }

	// RVA: 0x1635BD0 Offset: 0x16341D0 VA: 0x181635BD0
	public static JArray Load(JsonReader reader) { }

	// RVA: 0x16359F0 Offset: 0x1633FF0 VA: 0x1816359F0
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x1635E20 Offset: 0x1634420 VA: 0x181635E20
	public static JArray Parse(string json) { }

	// RVA: 0x1635CD0 Offset: 0x16342D0 VA: 0x181635CD0
	public static JArray Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0x1635320 Offset: 0x1633920 VA: 0x181635320
	public static JArray FromObject(object o) { }

	// RVA: 0x16354A0 Offset: 0x1633AA0 VA: 0x1816354A0
	public static JArray FromObject(object o, JsonSerializer jsonSerializer) { }

	// RVA: 0x1635FB0 Offset: 0x16345B0 VA: 0x181635FB0 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x1636250 Offset: 0x1634850 VA: 0x181636250 Slot: 17
	public override JToken get_Item(object key) { }

	// RVA: 0x16363C0 Offset: 0x16349C0 VA: 0x1816363C0 Slot: 18
	public override void set_Item(object key, JToken value) { }

	// RVA: 0x1636380 Offset: 0x1634980 VA: 0x181636380 Slot: 27
	public JToken get_Item(int index) { }

	// RVA: 0x16363A0 Offset: 0x16349A0 VA: 0x1816363A0 Slot: 28
	public void set_Item(int index, JToken value) { }

	[NullableContext(2)]
	// RVA: 0x16356B0 Offset: 0x1633CB0 VA: 0x1816356B0 Slot: 80
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x1635BE0 Offset: 0x16341E0 VA: 0x181635BE0 Slot: 92
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	// RVA: 0x1635710 Offset: 0x1633D10 VA: 0x181635710 Slot: 29
	public int IndexOf(JToken item) { }

	// RVA: 0x1635730 Offset: 0x1633D30 VA: 0x181635730 Slot: 30
	public void Insert(int index, JToken item) { }

	// RVA: 0x1635E30 Offset: 0x1634430 VA: 0x181635E30 Slot: 31
	public void RemoveAt(int index) { }

	// RVA: 0x1635630 Offset: 0x1633C30 VA: 0x181635630 Slot: 5
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0x1635150 Offset: 0x1633750 VA: 0x181635150 Slot: 34
	public void Add(JToken item) { }

	// RVA: 0x1635170 Offset: 0x1633770 VA: 0x181635170 Slot: 35
	public void Clear() { }

	// RVA: 0x1635250 Offset: 0x1633850 VA: 0x181635250 Slot: 36
	public bool Contains(JToken item) { }

	// RVA: 0x1635270 Offset: 0x1633870 VA: 0x181635270 Slot: 37
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 33
	public bool get_IsReadOnly() { }

	// RVA: 0x1635E50 Offset: 0x1634450 VA: 0x181635E50 Slot: 38
	public bool Remove(JToken item) { }

	// RVA: 0x1635620 Offset: 0x1633C20 VA: 0x181635620 Slot: 25
	internal override int GetDeepHashCode() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
public class JConstructor : JContainer // TypeDefIndex: 8467
{
	// Fields
	[Nullable(2)]
	private string _name; // 0x58
	private readonly List<JToken> _values; // 0x60

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	[Nullable(2)]
	public string Name { get; set; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public override JToken Item { get; set; }

	// Methods

	[AsyncStateMachine(typeof(JConstructor.<WriteToAsync>d__0))]
	// RVA: 0x16509C0 Offset: 0x164EFC0 VA: 0x1816509C0 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x16506D0 Offset: 0x164ECD0 VA: 0x1816506D0
	public static Task<JConstructor> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JConstructor.<LoadAsync>d__2))]
	// RVA: 0x1650580 Offset: 0x164EB80 VA: 0x181650580
	public static Task<JConstructor> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0 Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	[NullableContext(2)]
	// RVA: 0x1650520 Offset: 0x164EB20 VA: 0x181650520 Slot: 80
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x1650920 Offset: 0x164EF20 VA: 0x181650920 Slot: 92
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public string get_Name() { }

	[NullableContext(2)]
	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_Name(string value) { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x1650E60 Offset: 0x164F460 VA: 0x181650E60
	public void .ctor() { }

	// RVA: 0x1650C30 Offset: 0x164F230 VA: 0x181650C30
	public void .ctor(JConstructor other) { }

	// RVA: 0x1650BF0 Offset: 0x164F1F0 VA: 0x181650BF0
	public void .ctor(string name, object[] content) { }

	// RVA: 0x1650BF0 Offset: 0x164F1F0 VA: 0x181650BF0
	public void .ctor(string name, object content) { }

	// RVA: 0x1650CE0 Offset: 0x164F2E0 VA: 0x181650CE0
	public void .ctor(string name) { }

	// RVA: 0x1650300 Offset: 0x164E900 VA: 0x181650300 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x1650230 Offset: 0x164E830 VA: 0x181650230 Slot: 13
	internal override JToken CloneToken() { }

	// RVA: 0x1650B00 Offset: 0x164F100 VA: 0x181650B00 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x1650F10 Offset: 0x164F510 VA: 0x181650F10 Slot: 17
	public override JToken get_Item(object key) { }

	// RVA: 0x1651040 Offset: 0x164F640 VA: 0x181651040 Slot: 18
	public override void set_Item(object key, JToken value) { }

	// RVA: 0x16504D0 Offset: 0x164EAD0 VA: 0x1816504D0 Slot: 25
	internal override int GetDeepHashCode() { }

	// RVA: 0x16506E0 Offset: 0x164ECE0 VA: 0x1816506E0
	public static JConstructor Load(JsonReader reader) { }

	// RVA: 0x16506F0 Offset: 0x164ECF0 VA: 0x1816506F0
	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, ICollection, IList, INotifyCollectionChanged // TypeDefIndex: 8471
{
	// Fields
	[Nullable(2)]
	internal ListChangedEventHandler _listChanged; // 0x30
	[Nullable(2)]
	internal AddingNewEventHandler _addingNew; // 0x38
	[Nullable(2)]
	internal NotifyCollectionChangedEventHandler _collectionChanged; // 0x40
	[Nullable(2)]
	private object _syncRoot; // 0x48
	private bool _busy; // 0x50

	// Properties
	protected abstract IList<JToken> ChildrenTokens { get; }
	public override bool HasValues { get; }
	[Nullable(2)]
	public override JToken First { get; }
	[Nullable(2)]
	public override JToken Last { get; }
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item { get; set; }
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }
	[Nullable(2)]
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }

	// Methods

	[AsyncStateMachine(typeof(JContainer.<ReadTokenFromAsync>d__0))]
	// RVA: 0x16539C0 Offset: 0x1651FC0 VA: 0x1816539C0
	internal Task ReadTokenFromAsync(JsonReader reader, JsonLoadSettings options, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JContainer.<ReadContentFromAsync>d__1))]
	// RVA: 0x1653050 Offset: 0x1651650 VA: 0x181653050
	private Task ReadContentFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x1655420 Offset: 0x1653A20 VA: 0x181655420 Slot: 71
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x16557F0 Offset: 0x1653DF0 VA: 0x1816557F0 Slot: 72
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x16552E0 Offset: 0x16538E0 VA: 0x1816552E0
	public void add_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x16556B0 Offset: 0x1653CB0 VA: 0x1816556B0
	public void remove_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x1655380 Offset: 0x1653980 VA: 0x181655380 Slot: 73
	public void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	// RVA: 0x1655750 Offset: 0x1653D50 VA: 0x181655750 Slot: 74
	public void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }

	// RVA: -1 Offset: -1 Slot: 75
	protected abstract IList<JToken> get_ChildrenTokens();

	// RVA: 0x1655290 Offset: 0x1653890 VA: 0x181655290
	internal void .ctor() { }

	// RVA: 0x1654FB0 Offset: 0x16535B0 VA: 0x181654FB0
	internal void .ctor(JContainer other) { }

	// RVA: 0x16512B0 Offset: 0x164F8B0 VA: 0x1816512B0
	internal void CheckReentrancy() { }

	// RVA: 0x1651D20 Offset: 0x1650320 VA: 0x181651D20 Slot: 76
	internal virtual IList<JToken> CreateChildrenCollection() { }

	// RVA: 0x1652F50 Offset: 0x1651550 VA: 0x181652F50 Slot: 77
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0x1652FE0 Offset: 0x16515E0 VA: 0x181652FE0 Slot: 78
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1652F70 Offset: 0x1651570 VA: 0x181652F70 Slot: 79
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	// RVA: 0x16555B0 Offset: 0x1653BB0 VA: 0x1816555B0 Slot: 16
	public override bool get_HasValues() { }

	// RVA: 0x16516E0 Offset: 0x164FCE0 VA: 0x1816516E0
	internal bool ContentsEqual(JContainer container) { }

	[NullableContext(2)]
	// RVA: 0x1655520 Offset: 0x1653B20 VA: 0x181655520 Slot: 20
	public override JToken get_First() { }

	[NullableContext(2)]
	// RVA: 0x1655620 Offset: 0x1653C20 VA: 0x181655620 Slot: 21
	public override JToken get_Last() { }

	// RVA: 0x1651360 Offset: 0x164F960 VA: 0x181651360 Slot: 22
	public override JEnumerable<JToken> Children() { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	public override IEnumerable<T> Values<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x710070 Offset: 0x70E670 VA: 0x180710070
	|-JContainer.Values<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1651E90 Offset: 0x1650490 VA: 0x181651E90
	public IEnumerable<JToken> Descendants() { }

	// RVA: 0x1651E80 Offset: 0x1650480 VA: 0x181651E80
	public IEnumerable<JToken> DescendantsAndSelf() { }

	[IteratorStateMachine(typeof(JContainer.<GetDescendants>d__36))]
	// RVA: 0x1651FF0 Offset: 0x16505F0 VA: 0x181651FF0
	internal IEnumerable<JToken> GetDescendants(bool self) { }

	[NullableContext(2)]
	// RVA: 0x1652400 Offset: 0x1650A00 VA: 0x181652400
	internal bool IsMultiContent(object content) { }

	// RVA: 0x1651EA0 Offset: 0x16504A0 VA: 0x181651EA0
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 80
	internal abstract int IndexOfItem(JToken item);

	[NullableContext(2)]
	// RVA: 0x16520F0 Offset: 0x16506F0 VA: 0x1816520F0 Slot: 81
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0x1653CD0 Offset: 0x16522D0 VA: 0x181653CD0 Slot: 82
	internal virtual void RemoveItemAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x1654030 Offset: 0x1652630 VA: 0x181654030 Slot: 83
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0x1652080 Offset: 0x1650680 VA: 0x181652080 Slot: 84
	internal virtual JToken GetItem(int index) { }

	[NullableContext(2)]
	// RVA: 0x1654130 Offset: 0x1652730 VA: 0x181654130 Slot: 85
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0x16513D0 Offset: 0x164F9D0 VA: 0x1816513D0 Slot: 86
	internal virtual void ClearItems() { }

	// RVA: 0x16540D0 Offset: 0x16526D0 VA: 0x1816540D0 Slot: 87
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	[NullableContext(2)]
	// RVA: 0x16516B0 Offset: 0x164FCB0 VA: 0x1816516B0 Slot: 88
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0x1651A30 Offset: 0x1650030 VA: 0x181651A30 Slot: 89
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0x16524C0 Offset: 0x1650AC0 VA: 0x1816524C0
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0x1654E80 Offset: 0x1653480 VA: 0x181654E80 Slot: 90
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	[NullableContext(2)]
	// RVA: 0x1651220 Offset: 0x164F820 VA: 0x181651220 Slot: 91
	public virtual void Add(object content) { }

	[NullableContext(2)]
	// RVA: 0x1654DF0 Offset: 0x16533F0 VA: 0x181654DF0
	internal bool TryAdd(object content) { }

	// RVA: 0x1651170 Offset: 0x164F770 VA: 0x181651170
	internal void AddAndSkipParentCheck(JToken token) { }

	[NullableContext(2)]
	// RVA: 0x1651200 Offset: 0x164F800 VA: 0x181651200
	public void AddFirst(object content) { }

	[NullableContext(2)]
	// RVA: 0x1654B50 Offset: 0x1653150 VA: 0x181654B50
	internal bool TryAddInternal(int index, object content, bool skipParentCheck) { }

	// RVA: 0x1651D80 Offset: 0x1650380 VA: 0x181651D80
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0x1651E20 Offset: 0x1650420 VA: 0x181651E20
	public JsonWriter CreateWriter() { }

	// RVA: 0x1654080 Offset: 0x1652680 VA: 0x181654080
	public void ReplaceAll(object content) { }

	// RVA: 0x1635170 Offset: 0x1633770 VA: 0x181635170
	public void RemoveAll() { }

	// RVA: -1 Offset: -1 Slot: 92
	internal abstract void MergeItem(object content, JsonMergeSettings settings);

	// RVA: 0x1652F30 Offset: 0x1651530 VA: 0x181652F30
	public void Merge(object content) { }

	// RVA: 0x1652F10 Offset: 0x1651510 VA: 0x181652F10
	public void Merge(object content, JsonMergeSettings settings) { }

	// RVA: 0x1653B10 Offset: 0x1652110 VA: 0x181653B10
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0x16531A0 Offset: 0x16517A0 VA: 0x1816531A0
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x1653750 Offset: 0x1651D50 VA: 0x181653750
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	// RVA: 0x1651840 Offset: 0x164FE40 VA: 0x181651840
	internal int ContentsHashCode() { }

	// RVA: 0x37A870 Offset: 0x378E70 VA: 0x18037A870 Slot: 39
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x1654A60 Offset: 0x1653060 VA: 0x181654A60 Slot: 40
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x1635710 Offset: 0x1633D10 VA: 0x181635710 Slot: 29
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0x1635730 Offset: 0x1633D30 VA: 0x181635730 Slot: 30
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0x1635E30 Offset: 0x1634430 VA: 0x181635E30 Slot: 31
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0x1636380 Offset: 0x1634980 VA: 0x181636380 Slot: 27
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0x16363A0 Offset: 0x16349A0 VA: 0x1816363A0 Slot: 28
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0x1635150 Offset: 0x1633750 VA: 0x181635150 Slot: 34
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0x1635170 Offset: 0x1633770 VA: 0x181635170 Slot: 35
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0x1635250 Offset: 0x1633850 VA: 0x181635250 Slot: 36
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0x1635270 Offset: 0x1633870 VA: 0x181635270 Slot: 37
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 33
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0x1635E50 Offset: 0x1634450 VA: 0x181635E50 Slot: 38
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	// RVA: 0x1651F40 Offset: 0x1650540 VA: 0x181651F40
	private JToken EnsureValue(object value) { }

	// RVA: 0x16545F0 Offset: 0x1652BF0 VA: 0x1816545F0 Slot: 58
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1635170 Offset: 0x1633770 VA: 0x181635170 Slot: 60
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1654670 Offset: 0x1652C70 VA: 0x181654670 Slot: 59
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x16546A0 Offset: 0x1652CA0 VA: 0x1816546A0 Slot: 63
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x16546D0 Offset: 0x1652CD0 VA: 0x1816546D0 Slot: 64
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 62
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 61
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1654720 Offset: 0x1652D20 VA: 0x181654720 Slot: 65
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1635E30 Offset: 0x1634430 VA: 0x181635E30 Slot: 66
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1636380 Offset: 0x1634980 VA: 0x181636380 Slot: 56
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1654750 Offset: 0x1652D50 VA: 0x181654750 Slot: 57
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1635270 Offset: 0x1633870 VA: 0x181635270 Slot: 67
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x16554C0 Offset: 0x1653AC0 VA: 0x1816554C0 Slot: 68
	public int get_Count() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 70
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1654580 Offset: 0x1652B80 VA: 0x181654580 Slot: 69
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 51
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0x1654790 Offset: 0x1652D90 VA: 0x181654790 Slot: 42
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 43
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 41
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 44
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x16549A0 Offset: 0x1652FA0 VA: 0x1816549A0 Slot: 52
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x16549E0 Offset: 0x1652FE0 VA: 0x1816549E0 Slot: 53
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 48
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 54
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x1654A20 Offset: 0x1653020 VA: 0x181654A20 Slot: 55
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 50
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	[NullableContext(2)]
	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 49
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 45
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 46
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 47
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x1652570 Offset: 0x1650B70 VA: 0x181652570
	internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[IsReadOnly]
[DefaultMember("Item")]
public struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> // TypeDefIndex: 8472
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public static readonly JEnumerable<T> Empty; // 0x0
	private readonly IEnumerable<T> _enumerable; // 0x0

	// Properties
	public IJEnumerable<JToken> Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CA510 Offset: 0x10C8B10 VA: 0x1810CA510
	|-JEnumerable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CA1D0 Offset: 0x10C87D0 VA: 0x1810CA1D0
	|-JEnumerable<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CA310 Offset: 0x10C8910 VA: 0x1810CA310
	|-JEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IJEnumerable<JToken> get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CA570 Offset: 0x10C8B70 VA: 0x1810CA570
	|-JEnumerable<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(JEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CA1C0 Offset: 0x10C87C0 VA: 0x1810CA1C0
	|-JEnumerable<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CA080 Offset: 0x10C8680 VA: 0x1810CA080
	|-JEnumerable<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CA2F0 Offset: 0x10C88F0 VA: 0x1810CA2F0
	|-JEnumerable<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CA3A0 Offset: 0x10C89A0 VA: 0x1810CA3A0
	|-JEnumerable<object>..cctor
	*/
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging // TypeDefIndex: 8479
{
	// Fields
	private readonly JPropertyKeyedCollection _properties; // 0x58
	[Nullable(2)]
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x60
	[Nullable(2)]
	[CompilerGenerated]
	private PropertyChangingEventHandler PropertyChanging; // 0x68

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public override JToken Item { get; set; }
	[Nullable(2)]
	public JToken Item { get; set; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; }
	[Nullable(new[] { 1, 2 })]
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x1658550 Offset: 0x1656B50 VA: 0x181658550 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x1656760 Offset: 0x1654D60 VA: 0x181656760
	public static Task<JObject> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JObject.<LoadAsync>d__2))]
	// RVA: 0x1656610 Offset: 0x1654C10 VA: 0x181656610
	public static Task<JObject> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1658A20 Offset: 0x1657020 VA: 0x181658A20 Slot: 121
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1658CE0 Offset: 0x16572E0 VA: 0x181658CE0 Slot: 122
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1658AC0 Offset: 0x16570C0 VA: 0x181658AC0 Slot: 123
	public void add_PropertyChanging(PropertyChangingEventHandler value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1658D80 Offset: 0x1657380 VA: 0x181658D80 Slot: 124
	public void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0x1658980 Offset: 0x1656F80 VA: 0x181658980
	public void .ctor() { }

	// RVA: 0x1658900 Offset: 0x1656F00 VA: 0x181658900
	public void .ctor(JObject other) { }

	// RVA: 0x1658840 Offset: 0x1656E40 VA: 0x181658840
	public void .ctor(object[] content) { }

	// RVA: 0x1658840 Offset: 0x1656E40 VA: 0x181658840
	public void .ctor(object content) { }

	// RVA: 0x1655D80 Offset: 0x1654380 VA: 0x181655D80 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	[NullableContext(2)]
	// RVA: 0x16562D0 Offset: 0x16548D0 VA: 0x1816562D0 Slot: 80
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x1656390 Offset: 0x1654990 VA: 0x181656390 Slot: 81
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck) { }

	// RVA: 0x1658260 Offset: 0x1656860 VA: 0x181658260 Slot: 90
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0x1656980 Offset: 0x1654F80 VA: 0x181656980 Slot: 92
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	// RVA: 0x1656580 Offset: 0x1654B80 VA: 0x181656580
	private static bool IsNull(JToken token) { }

	// RVA: 0x1656410 Offset: 0x1654A10 VA: 0x181656410
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0x1656550 Offset: 0x1654B50 VA: 0x181656550
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0x1655BE0 Offset: 0x16541E0 VA: 0x181655BE0 Slot: 13
	internal override JToken CloneToken() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x1656F90 Offset: 0x1655590 VA: 0x181656F90
	public IEnumerable<JProperty> Properties() { }

	// RVA: 0x1657350 Offset: 0x1655950 VA: 0x181657350
	public JProperty Property(string name) { }

	// RVA: 0x1657150 Offset: 0x1655750 VA: 0x181657150
	public JProperty Property(string name, StringComparison comparison) { }

	// RVA: 0x1656FD0 Offset: 0x16555D0 VA: 0x181656FD0
	public JEnumerable<JToken> PropertyValues() { }

	// RVA: 0x1658B60 Offset: 0x1657160 VA: 0x181658B60 Slot: 17
	public override JToken get_Item(object key) { }

	// RVA: 0x1658F10 Offset: 0x1657510 VA: 0x181658F10 Slot: 18
	public override void set_Item(object key, JToken value) { }

	// RVA: 0x1658C60 Offset: 0x1657260 VA: 0x181658C60 Slot: 93
	public JToken get_Item(string propertyName) { }

	// RVA: 0x1658E20 Offset: 0x1657420 VA: 0x181658E20 Slot: 94
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0x1656770 Offset: 0x1654D70 VA: 0x181656770
	public static JObject Load(JsonReader reader) { }

	// RVA: 0x1656780 Offset: 0x1654D80 VA: 0x181656780
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x1656E30 Offset: 0x1655430 VA: 0x181656E30
	public static JObject Parse(string json) { }

	// RVA: 0x1656E40 Offset: 0x1655440 VA: 0x181656E40
	public static JObject Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0x1655E10 Offset: 0x1654410 VA: 0x181655E10
	public static JObject FromObject(object o) { }

	// RVA: 0x1655F90 Offset: 0x1654590 VA: 0x181655F90
	public static JObject FromObject(object o, JsonSerializer jsonSerializer) { }

	// RVA: 0x1658730 Offset: 0x1656D30 VA: 0x181658730 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[NullableContext(2)]
	// RVA: 0x1656290 Offset: 0x1654890 VA: 0x181656290
	public JToken GetValue(string propertyName) { }

	[NullableContext(2)]
	// RVA: 0x1656250 Offset: 0x1654850 VA: 0x181656250
	public JToken GetValue(string propertyName, StringComparison comparison) { }

	// RVA: 0x1658060 Offset: 0x1656660 VA: 0x181658060
	public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value) { }

	// RVA: 0x1655B50 Offset: 0x1654150 VA: 0x181655B50 Slot: 98
	public void Add(string propertyName, JToken value) { }

	// RVA: 0x1655C90 Offset: 0x1654290 VA: 0x181655C90 Slot: 97
	public bool ContainsKey(string propertyName) { }

	// RVA: 0x1657A20 Offset: 0x1656020 VA: 0x181657A20 Slot: 95
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0x1657360 Offset: 0x1655960 VA: 0x181657360 Slot: 99
	public bool Remove(string propertyName) { }

	// RVA: 0x16580B0 Offset: 0x16566B0 VA: 0x1816580B0 Slot: 100
	public bool TryGetValue(string propertyName, out JToken value) { }

	// RVA: 0x1657A80 Offset: 0x1656080 VA: 0x181657A80 Slot: 96
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0x1657400 Offset: 0x1655A00 VA: 0x181657400 Slot: 103
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	// RVA: 0x1635170 Offset: 0x1633770 VA: 0x181635170 Slot: 104
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0x1657490 Offset: 0x1655A90 VA: 0x181657490 Slot: 105
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	// RVA: 0x1657510 Offset: 0x1655B10 VA: 0x181657510 Slot: 106
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 102
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0x16578A0 Offset: 0x1655EA0 VA: 0x1816578A0 Slot: 107
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	// RVA: 0x1635620 Offset: 0x1633C20 VA: 0x181635620 Slot: 25
	internal override int GetDeepHashCode() { }

	[IteratorStateMachine(typeof(JObject.<GetEnumerator>d__63))]
	// RVA: 0x1656110 Offset: 0x1654710 VA: 0x181656110 Slot: 108
	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	// RVA: 0x1656D10 Offset: 0x1655310 VA: 0x181656D10 Slot: 125
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0x1656DA0 Offset: 0x16553A0 VA: 0x181656DA0 Slot: 126
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0x1657F30 Offset: 0x1656530 VA: 0x181657F30 Slot: 118
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1657C00 Offset: 0x1656200 VA: 0x181657C00 Slot: 119
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1657AC0 Offset: 0x16560C0 VA: 0x181657AC0 Slot: 109
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	[NullableContext(2)]
	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 110
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	[NullableContext(2)]
	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 111
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1657B10 Offset: 0x1656110 VA: 0x181657B10 Slot: 112
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	[NullableContext(2)]
	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 113
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	[NullableContext(2)]
	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 114
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 115
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1657B60 Offset: 0x1656160 VA: 0x181657B60 Slot: 117
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1657BB0 Offset: 0x16561B0 VA: 0x181657BB0 Slot: 116
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1657FE0 Offset: 0x16565E0 VA: 0x181657FE0 Slot: 120
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x1656180 Offset: 0x1654780 VA: 0x181656180 Slot: 26
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	[AsyncStateMachine(typeof(JObject.<<WriteToAsync>g__AwaitProperties|0_0>d))]
	[CompilerGenerated]
	// RVA: 0x1658110 Offset: 0x1656710 VA: 0x181658110
	private Task <WriteToAsync>g__AwaitProperties|0_0(Task task, int i, JsonWriter Writer, CancellationToken CancellationToken, JsonConverter[] Converters) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JProperty : JContainer // TypeDefIndex: 8484
{
	// Fields
	private readonly JProperty.JPropertyList _content; // 0x58
	private readonly string _name; // 0x60

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public JToken Value { get; set; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x165B860 Offset: 0x1659E60 VA: 0x18165B860 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[AsyncStateMachine(typeof(JProperty.<WriteToAsync>d__1))]
	// RVA: 0x165B720 Offset: 0x1659D20 VA: 0x18165B720
	private Task WriteToAsync(Task task, JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x165BB10 Offset: 0x165A110 VA: 0x18165BB10
	private Task WriteValueAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x165AF80 Offset: 0x1659580 VA: 0x18165AF80
	public static Task<JProperty> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JProperty.<LoadAsync>d__4))]
	// RVA: 0x165AE30 Offset: 0x1659430 VA: 0x18165AE30
	public static Task<JProperty> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 75
	protected override IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThrough]
	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public string get_Name() { }

	[DebuggerStepThrough]
	// RVA: 0x165BEA0 Offset: 0x165A4A0 VA: 0x18165BEA0
	public JToken get_Value() { }

	// RVA: 0x165BEC0 Offset: 0x165A4C0 VA: 0x18165BEC0
	public void set_Value(JToken value) { }

	// RVA: 0x165BB90 Offset: 0x165A190 VA: 0x18165BB90
	public void .ctor(JProperty other) { }

	// RVA: 0x165AC60 Offset: 0x1659260 VA: 0x18165AC60 Slot: 84
	internal override JToken GetItem(int index) { }

	[NullableContext(2)]
	// RVA: 0x165B430 Offset: 0x1659A30 VA: 0x18165B430 Slot: 85
	internal override void SetItem(int index, JToken item) { }

	[NullableContext(2)]
	// RVA: 0x165B380 Offset: 0x1659980 VA: 0x18165B380 Slot: 83
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0x165B2D0 Offset: 0x16598D0 VA: 0x18165B2D0 Slot: 82
	internal override void RemoveItemAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x165ACD0 Offset: 0x16592D0 VA: 0x18165ACD0 Slot: 80
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x165AD10 Offset: 0x1659310 VA: 0x18165AD10 Slot: 81
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck) { }

	[NullableContext(2)]
	// RVA: 0x165A9F0 Offset: 0x1658FF0 VA: 0x18165A9F0 Slot: 88
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0x165B1D0 Offset: 0x16597D0 VA: 0x18165B1D0 Slot: 92
	internal override void MergeItem(object content, JsonMergeSettings settings) { }

	// RVA: 0x165A880 Offset: 0x1658E80 VA: 0x18165A880 Slot: 86
	internal override void ClearItems() { }

	// RVA: 0x165AA10 Offset: 0x1659010 VA: 0x18165AA10 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x165A930 Offset: 0x1658F30 VA: 0x18165A930 Slot: 13
	internal override JToken CloneToken() { }

	[DebuggerStepThrough]
	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 15
	public override JTokenType get_Type() { }

	// RVA: 0x165BC30 Offset: 0x165A230 VA: 0x18165BC30
	internal void .ctor(string name) { }

	// RVA: 0x165BB80 Offset: 0x165A180 VA: 0x18165BB80
	public void .ctor(string name, object[] content) { }

	// RVA: 0x165BD10 Offset: 0x165A310 VA: 0x18165BD10
	public void .ctor(string name, object content) { }

	// RVA: 0x165BA70 Offset: 0x165A070 VA: 0x18165BA70 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x165ABE0 Offset: 0x16591E0 VA: 0x18165ABE0 Slot: 25
	internal override int GetDeepHashCode() { }

	// RVA: 0x165AF90 Offset: 0x1659590 VA: 0x18165AF90
	public static JProperty Load(JsonReader reader) { }

	// RVA: 0x165AFA0 Offset: 0x16595A0 VA: 0x18165AFA0
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 8485
{
	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }

	// Methods

	// RVA: 0x1659260 Offset: 0x1657860 VA: 0x181659260
	public void .ctor(string name) { }

	// RVA: 0x1659020 Offset: 0x1657620 VA: 0x181659020
	private static JObject CastInstance(object instance) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x16590A0 Offset: 0x16576A0 VA: 0x1816590A0 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x1659140 Offset: 0x1657740 VA: 0x181659140 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 22
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x1659270 Offset: 0x1657870 VA: 0x181659270 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x16592C0 Offset: 0x16578C0 VA: 0x1816592C0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 8
	protected override int get_NameHashCode() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(new[] { 0, 1 })]
[DefaultMember("Item")]
internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 8486
{
	// Fields
	private static readonly IEqualityComparer<string> Comparer; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private Dictionary<string, JToken> _dictionary; // 0x18

	// Properties
	public JToken Item { get; }
	public ICollection<string> Keys { get; }
	public ICollection<JToken> Values { get; }

	// Methods

	// RVA: 0x165A410 Offset: 0x1658A10 VA: 0x18165A410
	public void .ctor() { }

	// RVA: 0x1659300 Offset: 0x1657900 VA: 0x181659300
	private void AddKey(string key, JToken item) { }

	// RVA: 0x1659370 Offset: 0x1657970 VA: 0x181659370
	protected void ChangeItemKey(JToken item, string newKey) { }

	// RVA: 0x16595B0 Offset: 0x1657BB0 VA: 0x1816595B0 Slot: 35
	protected override void ClearItems() { }

	// RVA: 0x1659A50 Offset: 0x1658050 VA: 0x181659A50
	public bool Contains(string key) { }

	// RVA: 0x1659980 Offset: 0x1657F80 VA: 0x181659980
	private bool ContainsItem(JToken item) { }

	// RVA: 0x1659B00 Offset: 0x1658100 VA: 0x181659B00
	private void EnsureDictionary() { }

	// RVA: 0x1659BC0 Offset: 0x16581C0 VA: 0x181659BC0
	private string GetKeyForItem(JToken item) { }

	// RVA: 0x1659CE0 Offset: 0x16582E0 VA: 0x181659CE0 Slot: 36
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0x1659F60 Offset: 0x1658560 VA: 0x181659F60
	public bool Remove(string key) { }

	// RVA: 0x1659DF0 Offset: 0x16583F0 VA: 0x181659DF0 Slot: 37
	protected override void RemoveItem(int index) { }

	// RVA: 0x1659F10 Offset: 0x1658510 VA: 0x181659F10
	private void RemoveKey(string key) { }

	// RVA: 0x165A040 Offset: 0x1658640 VA: 0x18165A040 Slot: 38
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0x165A490 Offset: 0x1658A90 VA: 0x18165A490
	public JToken get_Item(string key) { }

	// RVA: 0x165A2D0 Offset: 0x16588D0 VA: 0x18165A2D0
	public bool TryGetValue(string key, out JToken value) { }

	// RVA: 0x165A580 Offset: 0x1658B80 VA: 0x18165A580
	public ICollection<string> get_Keys() { }

	// RVA: 0x165A5D0 Offset: 0x1658BD0 VA: 0x18165A5D0
	public ICollection<JToken> get_Values() { }

	// RVA: 0x1659C40 Offset: 0x1658240 VA: 0x181659C40
	public int IndexOfReference(JToken t) { }

	// RVA: 0x1659610 Offset: 0x1657C10 VA: 0x181659610
	public bool Compare(JPropertyKeyedCollection other) { }

	// RVA: 0x165A360 Offset: 0x1658960 VA: 0x18165A360
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JRaw : JValue // TypeDefIndex: 8488
{
	// Methods

	[AsyncStateMachine(typeof(JRaw.<CreateAsync>d__0))]
	// RVA: 0x165BFA0 Offset: 0x165A5A0 VA: 0x18165BFA0
	public static Task<JRaw> CreateAsync(JsonReader reader, CancellationToken cancellationToken) { }

	// RVA: 0x165C300 Offset: 0x165A900 VA: 0x18165C300
	public void .ctor(JRaw other) { }

	[NullableContext(2)]
	// RVA: 0x165C2F0 Offset: 0x165A8F0 VA: 0x18165C2F0
	public void .ctor(object rawJson) { }

	// RVA: 0x165C0D0 Offset: 0x165A6D0 VA: 0x18165C0D0
	public static JRaw Create(JsonReader reader) { }

	// RVA: 0x165BF40 Offset: 0x165A540 VA: 0x18165BF40 Slot: 13
	internal override JToken CloneToken() { }
}

// Namespace: Newtonsoft.Json.Linq
public class JsonLoadSettings // TypeDefIndex: 8489
{
	// Fields
	private CommentHandling _commentHandling; // 0x10
	private LineInfoHandling _lineInfoHandling; // 0x14
	private DuplicatePropertyNameHandling _duplicatePropertyNameHandling; // 0x18

	// Properties
	public CommentHandling CommentHandling { get; set; }
	public LineInfoHandling LineInfoHandling { get; set; }
	public DuplicatePropertyNameHandling DuplicatePropertyNameHandling { get; set; }

	// Methods

	// RVA: 0x1668E50 Offset: 0x1667450 VA: 0x181668E50
	public void .ctor() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public CommentHandling get_CommentHandling() { }

	// RVA: 0x1668E80 Offset: 0x1667480 VA: 0x181668E80
	public void set_CommentHandling(CommentHandling value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public LineInfoHandling get_LineInfoHandling() { }

	// RVA: 0x1668F60 Offset: 0x1667560 VA: 0x181668F60
	public void set_LineInfoHandling(LineInfoHandling value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }

	// RVA: 0x1668EF0 Offset: 0x16674F0 VA: 0x181668EF0
	public void set_DuplicatePropertyNameHandling(DuplicatePropertyNameHandling value) { }
}

// Namespace: Newtonsoft.Json.Linq
public class JsonMergeSettings // TypeDefIndex: 8490
{
	// Fields
	private MergeArrayHandling _mergeArrayHandling; // 0x10
	private MergeNullValueHandling _mergeNullValueHandling; // 0x14
	private StringComparison _propertyNameComparison; // 0x18

	// Properties
	public MergeArrayHandling MergeArrayHandling { get; set; }
	public MergeNullValueHandling MergeNullValueHandling { get; set; }
	public StringComparison PropertyNameComparison { get; set; }

	// Methods

	// RVA: 0x1668FD0 Offset: 0x16675D0 VA: 0x181668FD0
	public void .ctor() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public MergeArrayHandling get_MergeArrayHandling() { }

	// RVA: 0x1668FF0 Offset: 0x16675F0 VA: 0x181668FF0
	public void set_MergeArrayHandling(MergeArrayHandling value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public MergeNullValueHandling get_MergeNullValueHandling() { }

	// RVA: 0x1669060 Offset: 0x1667660 VA: 0x181669060
	public void set_MergeNullValueHandling(MergeNullValueHandling value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public StringComparison get_PropertyNameComparison() { }

	// RVA: 0x16690D0 Offset: 0x16676D0 VA: 0x1816690D0
	public void set_PropertyNameComparison(StringComparison value) { }
}

// Namespace: Newtonsoft.Json.Linq
public class JsonSelectSettings // TypeDefIndex: 8491
{
	// Fields
	[CompilerGenerated]
	private Nullable<TimeSpan> <RegexMatchTimeout>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ErrorWhenNoMatch>k__BackingField; // 0x20

	// Properties
	public Nullable<TimeSpan> RegexMatchTimeout { get; set; }
	public bool ErrorWhenNoMatch { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xA67320 Offset: 0xA65920 VA: 0x180A67320
	public Nullable<TimeSpan> get_RegexMatchTimeout() { }

	[CompilerGenerated]
	// RVA: 0x1032A10 Offset: 0x1031010 VA: 0x181032A10
	public void set_RegexMatchTimeout(Nullable<TimeSpan> value) { }

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_ErrorWhenNoMatch() { }

	[CompilerGenerated]
	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_ErrorWhenNoMatch(bool value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider // TypeDefIndex: 8499
{
	// Fields
	[Nullable(2)]
	private static JTokenEqualityComparer _equalityComparer; // 0x0
	[Nullable(2)]
	private JContainer _parent; // 0x10
	[Nullable(2)]
	private JToken _previous; // 0x18
	[Nullable(2)]
	private JToken _next; // 0x20
	[Nullable(2)]
	private object _annotations; // 0x28
	private static readonly JTokenType[] BooleanTypes; // 0x8
	private static readonly JTokenType[] NumberTypes; // 0x10
	private static readonly JTokenType[] BigIntegerTypes; // 0x18
	private static readonly JTokenType[] StringTypes; // 0x20
	private static readonly JTokenType[] GuidTypes; // 0x28
	private static readonly JTokenType[] TimeSpanTypes; // 0x30
	private static readonly JTokenType[] UriTypes; // 0x38
	private static readonly JTokenType[] CharTypes; // 0x40
	private static readonly JTokenType[] DateTimeTypes; // 0x48
	private static readonly JTokenType[] BytesTypes; // 0x50

	// Properties
	public static JTokenEqualityComparer EqualityComparer { get; }
	[Nullable(2)]
	public JContainer Parent { get; set; }
	public JToken Root { get; }
	public abstract JTokenType Type { get; }
	public abstract bool HasValues { get; }
	[Nullable(2)]
	public JToken Next { get; set; }
	[Nullable(2)]
	public JToken Previous { get; set; }
	public string Path { get; }
	[Nullable(2)]
	public virtual JToken Item { get; set; }
	[Nullable(2)]
	public virtual JToken First { get; }
	[Nullable(2)]
	public virtual JToken Last { get; }
	private IJEnumerable<JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.Item { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x1661490 Offset: 0x165FA90 VA: 0x181661490 Slot: 12
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	// RVA: 0x16614D0 Offset: 0x165FAD0 VA: 0x1816614D0
	public Task WriteToAsync(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x165ECE0 Offset: 0x165D2E0 VA: 0x18165ECE0
	public static Task<JToken> ReadFromAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JToken.<ReadFromAsync>d__3))]
	// RVA: 0x165EBA0 Offset: 0x165D1A0 VA: 0x18165EBA0
	public static Task<JToken> ReadFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x165E740 Offset: 0x165CD40 VA: 0x18165E740
	public static Task<JToken> LoadAsync(JsonReader reader, CancellationToken cancellationToken) { }

	// RVA: 0x165E6D0 Offset: 0x165CCD0 VA: 0x18165E6D0
	public static Task<JToken> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken) { }

	// RVA: 0x16618E0 Offset: 0x165FEE0 VA: 0x1816618E0
	public static JTokenEqualityComparer get_EqualityComparer() { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public JContainer get_Parent() { }

	[NullableContext(2)]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_Parent(JContainer value) { }

	// RVA: 0x1661EB0 Offset: 0x16604B0 VA: 0x181661EB0
	public JToken get_Root() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract JToken CloneToken();

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool DeepEquals(JToken node);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract JTokenType get_Type();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool get_HasValues();

	[NullableContext(2)]
	// RVA: 0x165E130 Offset: 0x165C730 VA: 0x18165E130
	public static bool DeepEquals(JToken t1, JToken t2) { }

	[NullableContext(2)]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public JToken get_Next() { }

	[NullableContext(2)]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_Next(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public JToken get_Previous() { }

	[NullableContext(2)]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_Previous(JToken value) { }

	// RVA: 0x1661BB0 Offset: 0x16601B0 VA: 0x181661BB0
	public string get_Path() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	[NullableContext(2)]
	// RVA: 0x165D850 Offset: 0x165BE50 VA: 0x18165D850
	public void AddAfterSelf(object content) { }

	[NullableContext(2)]
	// RVA: 0x165DBC0 Offset: 0x165C1C0 VA: 0x18165DBC0
	public void AddBeforeSelf(object content) { }

	// RVA: 0x165DD00 Offset: 0x165C300 VA: 0x18165DD00
	public IEnumerable<JToken> Ancestors() { }

	// RVA: 0x165DCF0 Offset: 0x165C2F0 VA: 0x18165DCF0
	public IEnumerable<JToken> AncestorsAndSelf() { }

	[IteratorStateMachine(typeof(JToken.<GetAncestors>d__48))]
	// RVA: 0x165E4A0 Offset: 0x165CAA0 VA: 0x18165E4A0
	internal IEnumerable<JToken> GetAncestors(bool self) { }

	[IteratorStateMachine(typeof(JToken.<AfterSelf>d__49))]
	// RVA: 0x165DC70 Offset: 0x165C270 VA: 0x18165DC70
	public IEnumerable<JToken> AfterSelf() { }

	[IteratorStateMachine(typeof(JToken.<BeforeSelf>d__50))]
	// RVA: 0x165DF20 Offset: 0x165C520 VA: 0x18165DF20
	public IEnumerable<JToken> BeforeSelf() { }

	// RVA: 0x1661A70 Offset: 0x1660070 VA: 0x181661A70 Slot: 17
	public virtual JToken get_Item(object key) { }

	// RVA: 0x1668DB0 Offset: 0x16673B0 VA: 0x181668DB0 Slot: 18
	public virtual void set_Item(object key, JToken value) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 19
	public virtual T Value<T>(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7106D0 Offset: 0x70ECD0 VA: 0x1807106D0
	|-JToken.Value<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	// RVA: 0x16619D0 Offset: 0x165FFD0 VA: 0x1816619D0 Slot: 20
	public virtual JToken get_First() { }

	[NullableContext(2)]
	// RVA: 0x1661B10 Offset: 0x1660110 VA: 0x181661B10 Slot: 21
	public virtual JToken get_Last() { }

	// RVA: 0x165DFA0 Offset: 0x165C5A0 VA: 0x18165DFA0 Slot: 22
	public virtual JEnumerable<JToken> Children() { }

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public JEnumerable<T> Children<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x710240 Offset: 0x70E840 VA: 0x180710240
	|-JToken.Children<object>
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	public virtual IEnumerable<T> Values<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x710800 Offset: 0x70EE00 VA: 0x180710800
	|-JToken.Values<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x165F350 Offset: 0x165D950 VA: 0x18165F350
	public void Remove() { }

	// RVA: 0x165F3D0 Offset: 0x165D9D0 VA: 0x18165F3D0
	public void Replace(JToken value) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	// RVA: 0x1661150 Offset: 0x165F750 VA: 0x181661150 Slot: 3
	public override string ToString() { }

	// RVA: 0x1661200 Offset: 0x165F800 VA: 0x181661200
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0x165E160 Offset: 0x165C760 VA: 0x18165E160
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0x165E5F0 Offset: 0x165CBF0 VA: 0x18165E5F0
	private static string GetType(JToken token) { }

	// RVA: 0x16613B0 Offset: 0x165F9B0 VA: 0x1816613B0
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0x1664970 Offset: 0x1662F70 VA: 0x181664970
	public static bool op_Explicit(JToken value) { }

	// RVA: 0x16633A0 Offset: 0x16619A0 VA: 0x1816633A0
	public static DateTimeOffset op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1666300 Offset: 0x1664900 VA: 0x181666300
	public static Nullable<bool> op_Explicit(JToken value) { }

	// RVA: 0x1666FC0 Offset: 0x16655C0 VA: 0x181666FC0
	public static long op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1665DD0 Offset: 0x16643D0 VA: 0x181665DD0
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1663070 Offset: 0x1661670 VA: 0x181663070
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1665830 Offset: 0x1663E30 VA: 0x181665830
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1667960 Offset: 0x1665F60 VA: 0x181667960
	public static Nullable<double> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x16638D0 Offset: 0x1661ED0 VA: 0x1816638D0
	public static Nullable<char> op_Explicit(JToken value) { }

	// RVA: 0x1664410 Offset: 0x1662A10 VA: 0x181664410
	public static int op_Explicit(JToken value) { }

	// RVA: 0x1664E30 Offset: 0x1663430 VA: 0x181664E30
	public static short op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x16665B0 Offset: 0x1664BB0 VA: 0x1816665B0
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x1666820 Offset: 0x1664E20 VA: 0x181666820
	public static char op_Explicit(JToken value) { }

	// RVA: 0x1667BF0 Offset: 0x16661F0 VA: 0x181667BF0
	public static byte op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x1665330 Offset: 0x1663930 VA: 0x181665330
	public static sbyte op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1665B30 Offset: 0x1664130 VA: 0x181665B30
	public static Nullable<int> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1663ED0 Offset: 0x16624D0 VA: 0x181663ED0
	public static Nullable<short> op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x1666A90 Offset: 0x1665090 VA: 0x181666A90
	public static Nullable<ushort> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x16628F0 Offset: 0x1660EF0 VA: 0x1816628F0
	public static Nullable<byte> op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x1666D30 Offset: 0x1665330 VA: 0x181666D30
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	// RVA: 0x1662E10 Offset: 0x1661410 VA: 0x181662E10
	public static DateTime op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x16655A0 Offset: 0x1663BA0 VA: 0x1816655A0
	public static Nullable<long> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x16623E0 Offset: 0x16609E0 VA: 0x1816623E0
	public static Nullable<float> op_Explicit(JToken value) { }

	// RVA: 0x1662150 Offset: 0x1660750 VA: 0x181662150
	public static Decimal op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x1664170 Offset: 0x1662770 VA: 0x181664170
	public static Nullable<uint> op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x16650A0 Offset: 0x16636A0 VA: 0x1816650A0
	public static Nullable<ulong> op_Explicit(JToken value) { }

	// RVA: 0x1667490 Offset: 0x1665A90 VA: 0x181667490
	public static double op_Explicit(JToken value) { }

	// RVA: 0x1663660 Offset: 0x1661C60 VA: 0x181663660
	public static float op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1666030 Offset: 0x1664630 VA: 0x181666030
	public static string op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x1662680 Offset: 0x1660C80 VA: 0x181662680
	public static uint op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x1661EE0 Offset: 0x16604E0 VA: 0x181661EE0
	public static ulong op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1663B70 Offset: 0x1662170 VA: 0x181663B70
	public static byte[] op_Explicit(JToken value) { }

	// RVA: 0x1662B80 Offset: 0x1661180 VA: 0x181662B80
	public static Guid op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1664680 Offset: 0x1662C80 VA: 0x181664680
	public static Nullable<Guid> op_Explicit(JToken value) { }

	// RVA: 0x1667700 Offset: 0x1665D00 VA: 0x181667700
	public static TimeSpan op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1667230 Offset: 0x1665830 VA: 0x181667230
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1664C00 Offset: 0x1663200 VA: 0x181664C00
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0x165FCE0 Offset: 0x165E2E0 VA: 0x18165FCE0
	private static BigInteger ToBigInteger(JToken value) { }

	// RVA: 0x165FA60 Offset: 0x165E060 VA: 0x18165FA60
	private static Nullable<BigInteger> ToBigIntegerNullable(JToken value) { }

	// RVA: 0x16686A0 Offset: 0x1666CA0 VA: 0x1816686A0
	public static JToken op_Implicit(bool value) { }

	// RVA: 0x1667FC0 Offset: 0x16665C0 VA: 0x181667FC0
	public static JToken op_Implicit(DateTimeOffset value) { }

	// RVA: 0x1668AB0 Offset: 0x16670B0 VA: 0x181668AB0
	public static JToken op_Implicit(byte value) { }

	// RVA: 0x1668B10 Offset: 0x1667110 VA: 0x181668B10
	public static JToken op_Implicit(Nullable<byte> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1668120 Offset: 0x1666720 VA: 0x181668120
	public static JToken op_Implicit(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1667EC0 Offset: 0x16664C0 VA: 0x181667EC0
	public static JToken op_Implicit(Nullable<sbyte> value) { }

	// RVA: 0x1668020 Offset: 0x1666620 VA: 0x181668020
	public static JToken op_Implicit(Nullable<bool> value) { }

	// RVA: 0x1668640 Offset: 0x1666C40 VA: 0x181668640
	public static JToken op_Implicit(long value) { }

	// RVA: 0x16684B0 Offset: 0x1666AB0 VA: 0x1816684B0
	public static JToken op_Implicit(Nullable<DateTime> value) { }

	// RVA: 0x16689C0 Offset: 0x1666FC0 VA: 0x1816689C0
	public static JToken op_Implicit(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1668180 Offset: 0x1666780 VA: 0x181668180
	public static JToken op_Implicit(Nullable<Decimal> value) { }

	// RVA: 0x1668880 Offset: 0x1666E80 VA: 0x181668880
	public static JToken op_Implicit(Nullable<double> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1668820 Offset: 0x1666E20 VA: 0x181668820
	public static JToken op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1667E60 Offset: 0x1666460 VA: 0x181667E60
	public static JToken op_Implicit(ushort value) { }

	// RVA: 0x1668A50 Offset: 0x1667050 VA: 0x181668A50
	public static JToken op_Implicit(int value) { }

	// RVA: 0x16682F0 Offset: 0x16668F0 VA: 0x1816682F0
	public static JToken op_Implicit(Nullable<int> value) { }

	// RVA: 0x1668370 Offset: 0x1666970 VA: 0x181668370
	public static JToken op_Implicit(DateTime value) { }

	// RVA: 0x1668D30 Offset: 0x1667330 VA: 0x181668D30
	public static JToken op_Implicit(Nullable<long> value) { }

	// RVA: 0x1668430 Offset: 0x1666A30 VA: 0x181668430
	public static JToken op_Implicit(Nullable<float> value) { }

	// RVA: 0x1668B90 Offset: 0x1667190 VA: 0x181668B90
	public static JToken op_Implicit(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1668270 Offset: 0x1666870 VA: 0x181668270
	public static JToken op_Implicit(Nullable<short> value) { }

	[CLSCompliant(False)]
	// RVA: 0x16680A0 Offset: 0x16666A0 VA: 0x1816680A0
	public static JToken op_Implicit(Nullable<ushort> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1667F40 Offset: 0x1666540 VA: 0x181667F40
	public static JToken op_Implicit(Nullable<uint> value) { }

	[CLSCompliant(False)]
	// RVA: 0x16685C0 Offset: 0x1666BC0 VA: 0x1816685C0
	public static JToken op_Implicit(Nullable<ulong> value) { }

	// RVA: 0x16683D0 Offset: 0x16669D0 VA: 0x1816683D0
	public static JToken op_Implicit(double value) { }

	// RVA: 0x1668900 Offset: 0x1666F00 VA: 0x181668900
	public static JToken op_Implicit(float value) { }

	// RVA: 0x16687C0 Offset: 0x1666DC0 VA: 0x1816687C0
	public static JToken op_Implicit(string value) { }

	[CLSCompliant(False)]
	// RVA: 0x1668760 Offset: 0x1666D60 VA: 0x181668760
	public static JToken op_Implicit(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1668960 Offset: 0x1666F60 VA: 0x181668960
	public static JToken op_Implicit(ulong value) { }

	// RVA: 0x1668210 Offset: 0x1666810 VA: 0x181668210
	public static JToken op_Implicit(byte[] value) { }

	// RVA: 0x1668700 Offset: 0x1666D00 VA: 0x181668700
	public static JToken op_Implicit(Uri value) { }

	// RVA: 0x1668CD0 Offset: 0x16672D0 VA: 0x181668CD0
	public static JToken op_Implicit(TimeSpan value) { }

	// RVA: 0x1668C50 Offset: 0x1667250 VA: 0x181668C50
	public static JToken op_Implicit(Nullable<TimeSpan> value) { }

	// RVA: 0x1668BF0 Offset: 0x16671F0 VA: 0x181668BF0
	public static JToken op_Implicit(Guid value) { }

	// RVA: 0x1668530 Offset: 0x1666B30 VA: 0x181668530
	public static JToken op_Implicit(Nullable<Guid> value) { }

	// RVA: 0x165FA00 Offset: 0x165E000 VA: 0x18165FA00 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x165F980 Offset: 0x165DF80 VA: 0x18165F980 Slot: 5
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: -1 Offset: -1 Slot: 25
	internal abstract int GetDeepHashCode();

	// RVA: 0x165E990 Offset: 0x165CF90 VA: 0x18165E990 Slot: 4
	private IJEnumerable<JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.get_Item(object key) { }

	// RVA: 0x165E0A0 Offset: 0x165C6A0 VA: 0x18165E0A0
	public JsonReader CreateReader() { }

	// RVA: 0x165E290 Offset: 0x165C890 VA: 0x18165E290
	internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer) { }

	// RVA: 0x165E3E0 Offset: 0x165C9E0 VA: 0x18165E3E0
	public static JToken FromObject(object o) { }

	// RVA: 0x165E440 Offset: 0x165CA40 VA: 0x18165E440
	public static JToken FromObject(object o, JsonSerializer jsonSerializer) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public T ToObject<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7104D0 Offset: 0x70EAD0 VA: 0x1807104D0
	|-JToken.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1660000 Offset: 0x165E600 VA: 0x181660000
	public object ToObject(Type objectType) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public T ToObject<T>(JsonSerializer jsonSerializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7105D0 Offset: 0x70EBD0 VA: 0x1807105D0
	|-JToken.ToObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x165FEA0 Offset: 0x165E4A0 VA: 0x18165FEA0
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0x165F0B0 Offset: 0x165D6B0 VA: 0x18165F0B0
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0x165ED40 Offset: 0x165D340 VA: 0x18165ED40
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x165EB50 Offset: 0x165D150 VA: 0x18165EB50
	public static JToken Parse(string json) { }

	// RVA: 0x165E9B0 Offset: 0x165CFB0 VA: 0x18165E9B0
	public static JToken Parse(string json, JsonLoadSettings settings) { }

	// RVA: 0x165E850 Offset: 0x165CE50 VA: 0x18165E850
	public static JToken Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x165E7D0 Offset: 0x165CDD0 VA: 0x18165E7D0
	public static JToken Load(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x165F890 Offset: 0x165DE90 VA: 0x18165F890
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0x165F810 Offset: 0x165DE10 VA: 0x18165F810
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x165E8B0 Offset: 0x165CEB0 VA: 0x18165E8B0 Slot: 7
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x165E8F0 Offset: 0x165CEF0 VA: 0x18165E8F0 Slot: 8
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x165E940 Offset: 0x165CF40 VA: 0x18165E940 Slot: 9
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x165F640 Offset: 0x165DC40 VA: 0x18165F640
	public JToken SelectToken(string path) { }

	// RVA: 0x165F650 Offset: 0x165DC50 VA: 0x18165F650
	public JToken SelectToken(string path, bool errorWhenNoMatch) { }

	[NullableContext(2)]
	// RVA: 0x165F450 Offset: 0x165DA50 VA: 0x18165F450
	public JToken SelectToken(string path, JsonSelectSettings settings) { }

	// RVA: 0x165F6E0 Offset: 0x165DCE0 VA: 0x18165F6E0
	public IEnumerable<JToken> SelectTokens(string path) { }

	// RVA: 0x165F6F0 Offset: 0x165DCF0 VA: 0x18165F6F0
	public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch) { }

	// RVA: 0x165F780 Offset: 0x165DD80 VA: 0x18165F780
	public IEnumerable<JToken> SelectTokens(string path, JsonSelectSettings settings) { }

	// RVA: 0x165E530 Offset: 0x165CB30 VA: 0x18165E530 Slot: 26
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0x165FA40 Offset: 0x165E040 VA: 0x18165FA40 Slot: 11
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0x14B0290 Offset: 0x14AE890 VA: 0x1814B0290 Slot: 10
	private object System.ICloneable.Clone() { }

	// RVA: 0x14B0290 Offset: 0x14AE890 VA: 0x1814B0290
	public JToken DeepClone() { }

	// RVA: 0x165D900 Offset: 0x165BF00 VA: 0x18165D900
	public void AddAnnotation(object annotation) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7100C0 Offset: 0x70E6C0 VA: 0x1807100C0
	|-JToken.Annotation<object>
	*/

	// RVA: 0x165DD10 Offset: 0x165C310 VA: 0x18165DD10
	public object Annotation(Type type) { }

	[IteratorStateMachine(typeof(JToken.<Annotations>d__184<T>))]
	// RVA: -1 Offset: -1
	public IEnumerable<T> Annotations<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7101B0 Offset: 0x70E7B0 VA: 0x1807101B0
	|-JToken.Annotations<object>
	*/

	[IteratorStateMachine(typeof(JToken.<Annotations>d__185))]
	// RVA: 0x165DE90 Offset: 0x165C490 VA: 0x18165DE90
	public IEnumerable<object> Annotations(Type type) { }

	// RVA: -1 Offset: -1
	public void RemoveAnnotations<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7102E0 Offset: 0x70E8E0 VA: 0x1807102E0
	|-JToken.RemoveAnnotations<object>
	*/

	// RVA: 0x165F100 Offset: 0x165D700 VA: 0x18165F100
	public void RemoveAnnotations(Type type) { }

	// RVA: 0x165DFF0 Offset: 0x165C5F0 VA: 0x18165DFF0
	internal void CopyAnnotations(JToken target, JToken source) { }

	// RVA: 0x1661500 Offset: 0x165FB00 VA: 0x181661500
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JTokenEqualityComparer : IEqualityComparer<JToken> // TypeDefIndex: 8500
{
	// Methods

	// RVA: 0x165C310 Offset: 0x165A910 VA: 0x18165C310 Slot: 4
	public bool Equals(JToken x, JToken y) { }

	// RVA: 0x165C3A0 Offset: 0x165A9A0 VA: 0x18165C3A0 Slot: 5
	public int GetHashCode(JToken obj) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 8501
{
	// Fields
	private readonly JToken _root; // 0x78
	[Nullable(2)]
	private string _initialPath; // 0x80
	[Nullable(2)]
	private JToken _parent; // 0x88
	[Nullable(2)]
	private JToken _current; // 0x90

	// Properties
	[Nullable(2)]
	public JToken CurrentToken { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }
	public override string Path { get; }

	// Methods

	[NullableContext(2)]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public JToken get_CurrentToken() { }

	// RVA: 0x165D650 Offset: 0x165BC50 VA: 0x18165D650
	public void .ctor(JToken token) { }

	// RVA: 0x165D6C0 Offset: 0x165BCC0 VA: 0x18165D6C0
	public void .ctor(JToken token, string initialPath) { }

	// RVA: 0x165C880 Offset: 0x165AE80 VA: 0x18165C880 Slot: 21
	public override bool Read() { }

	// RVA: 0x165C710 Offset: 0x165AD10 VA: 0x18165C710
	private bool ReadOver(JToken t) { }

	// RVA: 0x165C840 Offset: 0x165AE40 VA: 0x18165C840
	private bool ReadToEnd() { }

	// RVA: 0x165C3D0 Offset: 0x165A9D0 VA: 0x18165C3D0
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0x165C660 Offset: 0x165AC60 VA: 0x18165C660
	private bool ReadInto(JContainer c) { }

	// RVA: 0x165CCC0 Offset: 0x165B2C0 VA: 0x18165CCC0
	private bool SetEnd(JContainer c) { }

	// RVA: 0x165CEA0 Offset: 0x165B4A0 VA: 0x18165CEA0
	private void SetToken(JToken token) { }

	[NullableContext(2)]
	// RVA: 0x165CC90 Offset: 0x165B290 VA: 0x18165CC90
	private string SafeToString(object value) { }

	// RVA: 0x165C540 Offset: 0x165AB40 VA: 0x18165C540 Slot: 32
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x165C5A0 Offset: 0x165ABA0 VA: 0x18165C5A0 Slot: 33
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x165C600 Offset: 0x165AC00 VA: 0x18165C600 Slot: 34
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x165D750 Offset: 0x165BD50 VA: 0x18165D750 Slot: 20
	public override string get_Path() { }
}

// Namespace: Newtonsoft.Json.Linq
public enum JTokenType // TypeDefIndex: 8502
{
	// Fields
	public int value__; // 0x0
	public const JTokenType None = 0;
	public const JTokenType Object = 1;
	public const JTokenType Array = 2;
	public const JTokenType Constructor = 3;
	public const JTokenType Property = 4;
	public const JTokenType Comment = 5;
	public const JTokenType Integer = 6;
	public const JTokenType Float = 7;
	public const JTokenType String = 8;
	public const JTokenType Boolean = 9;
	public const JTokenType Null = 10;
	public const JTokenType Undefined = 11;
	public const JTokenType Date = 12;
	public const JTokenType Raw = 13;
	public const JTokenType Bytes = 14;
	public const JTokenType Guid = 15;
	public const JTokenType Uri = 16;
	public const JTokenType TimeSpan = 17;
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(2)]
[Nullable(0)]
public class JTokenWriter : JsonWriter // TypeDefIndex: 8503
{
	// Fields
	private JContainer _token; // 0x60
	private JContainer _parent; // 0x68
	private JValue _value; // 0x70
	private JToken _current; // 0x78

	// Properties
	public JToken CurrentToken { get; }
	public JToken Token { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1679A60 Offset: 0x1678060 VA: 0x181679A60 Slot: 24
	internal override Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken) { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public JToken get_CurrentToken() { }

	// RVA: 0x167AD90 Offset: 0x1679390 VA: 0x18167AD90
	public JToken get_Token() { }

	[NullableContext(1)]
	// RVA: 0x167ACF0 Offset: 0x16792F0 VA: 0x18167ACF0
	public void .ctor(JContainer container) { }

	// RVA: 0x167ACA0 Offset: 0x16792A0 VA: 0x18167ACA0
	public void .ctor() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 66
	public override void Flush() { }

	// RVA: 0x1679560 Offset: 0x1677B60 VA: 0x181679560 Slot: 67
	public override void Close() { }

	// RVA: 0x16799C0 Offset: 0x1677FC0 VA: 0x1816799C0 Slot: 68
	public override void WriteStartObject() { }

	[NullableContext(1)]
	// RVA: 0x1679320 Offset: 0x1677920 VA: 0x181679320
	private void AddParent(JContainer container) { }

	// RVA: 0x1679570 Offset: 0x1677B70 VA: 0x181679570
	private void RemoveParent() { }

	// RVA: 0x1679870 Offset: 0x1677E70 VA: 0x181679870 Slot: 70
	public override void WriteStartArray() { }

	[NullableContext(1)]
	// RVA: 0x1679910 Offset: 0x1677F10 VA: 0x181679910 Slot: 72
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x1679570 Offset: 0x1677B70 VA: 0x181679570 Slot: 78
	protected override void WriteEnd(JsonToken token) { }

	[NullableContext(1)]
	// RVA: 0x16796F0 Offset: 0x1677CF0 VA: 0x1816796F0 Slot: 74
	public override void WritePropertyName(string name) { }

	// RVA: 0x16794E0 Offset: 0x1677AE0 VA: 0x1816794E0
	private void AddValue(object value, JsonToken token) { }

	// RVA: 0x1679380 Offset: 0x1677980 VA: 0x181679380
	internal void AddValue(JValue value, JsonToken token) { }

	// RVA: 0x167A3D0 Offset: 0x16789D0 VA: 0x18167A3D0 Slot: 123
	public override void WriteValue(object value) { }

	// RVA: 0x16796C0 Offset: 0x1677CC0 VA: 0x1816796C0 Slot: 82
	public override void WriteNull() { }

	// RVA: 0x1679EF0 Offset: 0x16784F0 VA: 0x181679EF0 Slot: 83
	public override void WriteUndefined() { }

	// RVA: 0x16797F0 Offset: 0x1677DF0 VA: 0x1816797F0 Slot: 84
	public override void WriteRaw(string json) { }

	// RVA: 0x1679600 Offset: 0x1677C00 VA: 0x181679600 Slot: 124
	public override void WriteComment(string text) { }

	// RVA: 0x167A040 Offset: 0x1678640 VA: 0x18167A040 Slot: 86
	public override void WriteValue(string value) { }

	// RVA: 0x167A460 Offset: 0x1678A60 VA: 0x18167A460 Slot: 87
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x167A0C0 Offset: 0x16786C0 VA: 0x18167A0C0 Slot: 88
	public override void WriteValue(uint value) { }

	// RVA: 0x167A4F0 Offset: 0x1678AF0 VA: 0x18167A4F0 Slot: 89
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x167A2B0 Offset: 0x16788B0 VA: 0x18167A2B0 Slot: 90
	public override void WriteValue(ulong value) { }

	// RVA: 0x167A210 Offset: 0x1678810 VA: 0x18167A210 Slot: 91
	public override void WriteValue(float value) { }

	// RVA: 0x167AB10 Offset: 0x1679110 VA: 0x18167AB10 Slot: 92
	public override void WriteValue(double value) { }

	// RVA: 0x167A8F0 Offset: 0x1678EF0 VA: 0x18167A8F0 Slot: 93
	public override void WriteValue(bool value) { }

	// RVA: 0x167A980 Offset: 0x1678F80 VA: 0x18167A980 Slot: 94
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x167A790 Offset: 0x1678D90 VA: 0x18167A790 Slot: 95
	public override void WriteValue(ushort value) { }

	// RVA: 0x167AA20 Offset: 0x1679020 VA: 0x18167AA20 Slot: 96
	public override void WriteValue(char value) { }

	// RVA: 0x1679FB0 Offset: 0x16785B0 VA: 0x181679FB0 Slot: 97
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1679F20 Offset: 0x1678520 VA: 0x181679F20 Slot: 98
	public override void WriteValue(sbyte value) { }

	// RVA: 0x167A150 Offset: 0x1678750 VA: 0x18167A150 Slot: 99
	public override void WriteValue(Decimal value) { }

	// RVA: 0x167ABB0 Offset: 0x16791B0 VA: 0x18167ABB0 Slot: 100
	public override void WriteValue(DateTime value) { }

	// RVA: 0x167A6D0 Offset: 0x1678CD0 VA: 0x18167A6D0 Slot: 101
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x167A590 Offset: 0x1678B90 VA: 0x18167A590 Slot: 121
	public override void WriteValue(byte[] value) { }

	// RVA: 0x167A830 Offset: 0x1678E30 VA: 0x18167A830 Slot: 103
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x167A610 Offset: 0x1678C10 VA: 0x18167A610 Slot: 102
	public override void WriteValue(Guid value) { }

	// RVA: 0x167A350 Offset: 0x1678950 VA: 0x18167A350 Slot: 122
	public override void WriteValue(Uri value) { }

	[NullableContext(1)]
	// RVA: 0x1679B60 Offset: 0x1678160 VA: 0x181679B60 Slot: 77
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible // TypeDefIndex: 8505
{
	// Fields
	private JTokenType _valueType; // 0x30
	[Nullable(2)]
	private object _value; // 0x38

	// Properties
	public override bool HasValues { get; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public object Value { get; set; }

	// Methods

	// RVA: 0x167E060 Offset: 0x167C660 VA: 0x18167E060 Slot: 12
	public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

	[NullableContext(2)]
	// RVA: 0x167F6F0 Offset: 0x167DCF0 VA: 0x18167F6F0
	internal void .ctor(object value, JTokenType type) { }

	// RVA: 0x167F770 Offset: 0x167DD70 VA: 0x18167F770
	public void .ctor(JValue other) { }

	// RVA: 0x167F490 Offset: 0x167DA90 VA: 0x18167F490
	public void .ctor(long value) { }

	// RVA: 0x167FC90 Offset: 0x167E290 VA: 0x18167FC90
	public void .ctor(Decimal value) { }

	// RVA: 0x167FA20 Offset: 0x167E020 VA: 0x18167FA20
	public void .ctor(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x167F400 Offset: 0x167DA00 VA: 0x18167F400
	public void .ctor(ulong value) { }

	// RVA: 0x167F520 Offset: 0x167DB20 VA: 0x18167F520
	public void .ctor(double value) { }

	// RVA: 0x167F990 Offset: 0x167DF90 VA: 0x18167F990
	public void .ctor(float value) { }

	// RVA: 0x167F640 Offset: 0x167DC40 VA: 0x18167F640
	public void .ctor(DateTime value) { }

	// RVA: 0x167FD40 Offset: 0x167E340 VA: 0x18167FD40
	public void .ctor(DateTimeOffset value) { }

	// RVA: 0x167F5B0 Offset: 0x167DBB0 VA: 0x18167F5B0
	public void .ctor(bool value) { }

	[NullableContext(2)]
	// RVA: 0x167FAB0 Offset: 0x167E0B0 VA: 0x18167FAB0
	public void .ctor(string value) { }

	// RVA: 0x167FBE0 Offset: 0x167E1E0 VA: 0x18167FBE0
	public void .ctor(Guid value) { }

	[NullableContext(2)]
	// RVA: 0x167FB20 Offset: 0x167E120 VA: 0x18167FB20
	public void .ctor(Uri value) { }

	// RVA: 0x167F860 Offset: 0x167DE60 VA: 0x18167F860
	public void .ctor(TimeSpan value) { }

	[NullableContext(2)]
	// RVA: 0x167F910 Offset: 0x167DF10 VA: 0x18167F910
	public void .ctor(object value) { }

	// RVA: 0x167C690 Offset: 0x167AC90 VA: 0x18167C690 Slot: 14
	internal override bool DeepEquals(JToken node) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 16
	public override bool get_HasValues() { }

	// RVA: 0x167B400 Offset: 0x1679A00 VA: 0x18167B400
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	[NullableContext(2)]
	// RVA: 0x167B840 Offset: 0x1679E40 VA: 0x18167B840
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	// RVA: 0x167B730 Offset: 0x1679D30 VA: 0x18167B730
	private static int CompareFloat(object objA, object objB) { }

	[NullableContext(2)]
	// RVA: 0x167CEC0 Offset: 0x167B4C0 VA: 0x18167CEC0
	private static bool Operation(ExpressionType operation, object objA, object objB, out object result) { }

	// RVA: 0x167B2E0 Offset: 0x16798E0 VA: 0x18167B2E0 Slot: 13
	internal override JToken CloneToken() { }

	// RVA: 0x167C430 Offset: 0x167AA30 VA: 0x18167C430
	public static JValue CreateComment(string value) { }

	// RVA: 0x167C560 Offset: 0x167AB60 VA: 0x18167C560
	public static JValue CreateString(string value) { }

	// RVA: 0x167C4D0 Offset: 0x167AAD0 VA: 0x18167C4D0
	public static JValue CreateNull() { }

	// RVA: 0x167C600 Offset: 0x167AC00 VA: 0x18167C600
	public static JValue CreateUndefined() { }

	[NullableContext(2)]
	// RVA: 0x167CA20 Offset: 0x167B020 VA: 0x18167CA20
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	// RVA: 0x167C9C0 Offset: 0x167AFC0 VA: 0x18167C9C0
	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0 Slot: 15
	public override JTokenType get_Type() { }

	[NullableContext(2)]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public object get_Value() { }

	[NullableContext(2)]
	// RVA: 0x167FDF0 Offset: 0x167E3F0 VA: 0x18167FDF0
	public void set_Value(object value) { }

	// RVA: 0x167EA70 Offset: 0x167D070 VA: 0x18167EA70 Slot: 24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x167C860 Offset: 0x167AE60 VA: 0x18167C860 Slot: 25
	internal override int GetDeepHashCode() { }

	// RVA: 0x167E010 Offset: 0x167C610 VA: 0x18167E010
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	[NullableContext(2)]
	// RVA: 0x167C810 Offset: 0x167AE10 VA: 0x18167C810 Slot: 27
	public bool Equals(JValue other) { }

	// RVA: 0x167C750 Offset: 0x167AD50 VA: 0x18167C750 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x167C8C0 Offset: 0x167AEC0 VA: 0x18167C8C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x167DE20 Offset: 0x167C420 VA: 0x18167DE20 Slot: 3
	public override string ToString() { }

	// RVA: 0x167DE60 Offset: 0x167C460 VA: 0x18167DE60
	public string ToString(string format) { }

	// RVA: 0x167E000 Offset: 0x167C600 VA: 0x18167E000 Slot: 46
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x167DED0 Offset: 0x167C4D0 VA: 0x18167DED0 Slot: 28
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x167C8F0 Offset: 0x167AEF0 VA: 0x18167C8F0 Slot: 26
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0x167D7F0 Offset: 0x167BDF0 VA: 0x18167D7F0 Slot: 29
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x167B810 Offset: 0x1679E10 VA: 0x18167B810 Slot: 30
	public int CompareTo(JValue obj) { }

	// RVA: 0x167D8B0 Offset: 0x167BEB0 VA: 0x18167D8B0 Slot: 31
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0x167D990 Offset: 0x167BF90 VA: 0x18167D990 Slot: 32
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x167DA30 Offset: 0x167C030 VA: 0x18167DA30 Slot: 33
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x167DC80 Offset: 0x167C280 VA: 0x18167DC80 Slot: 34
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x167D9E0 Offset: 0x167BFE0 VA: 0x18167D9E0 Slot: 35
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x167DB90 Offset: 0x167C190 VA: 0x18167DB90 Slot: 36
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x167DD30 Offset: 0x167C330 VA: 0x18167DD30 Slot: 37
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x167DBE0 Offset: 0x167C1E0 VA: 0x18167DBE0 Slot: 38
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x167DD80 Offset: 0x167C380 VA: 0x18167DD80 Slot: 39
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x167DC30 Offset: 0x167C230 VA: 0x18167DC30 Slot: 40
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x167DDD0 Offset: 0x167C3D0 VA: 0x18167DDD0 Slot: 41
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x167DCD0 Offset: 0x167C2D0 VA: 0x18167DCD0 Slot: 42
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x167DB40 Offset: 0x167C140 VA: 0x18167DB40 Slot: 43
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x167DAD0 Offset: 0x167C0D0 VA: 0x18167DAD0 Slot: 44
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x167DA80 Offset: 0x167C080 VA: 0x18167DA80 Slot: 45
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x167DD20 Offset: 0x167C320 VA: 0x18167DD20 Slot: 47
	private object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }
}

// Namespace: Newtonsoft.Json.Linq
public enum LineInfoHandling // TypeDefIndex: 8506
{
	// Fields
	public int value__; // 0x0
	public const LineInfoHandling Ignore = 0;
	public const LineInfoHandling Load = 1;
}

// Namespace: Newtonsoft.Json.Linq
public enum MergeArrayHandling // TypeDefIndex: 8507
{
	// Fields
	public int value__; // 0x0
	public const MergeArrayHandling Concat = 0;
	public const MergeArrayHandling Union = 1;
	public const MergeArrayHandling Replace = 2;
	public const MergeArrayHandling Merge = 3;
}

// Namespace: Newtonsoft.Json.Linq
[Flags]
public enum MergeNullValueHandling // TypeDefIndex: 8508
{
	// Fields
	public int value__; // 0x0
	public const MergeNullValueHandling Ignore = 0;
	public const MergeNullValueHandling Merge = 1;
}

