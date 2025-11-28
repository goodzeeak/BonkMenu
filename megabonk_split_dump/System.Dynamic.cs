// Namespace: System.Dynamic
public abstract class BinaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 11288
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <Operation>k__BackingField; // 0x18

	// Properties
	public ExpressionType Operation { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public ExpressionType get_Operation() { }

	// RVA: 0x1A4A260 Offset: 0x1A48860 VA: 0x181A4A260
	public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A4A180 Offset: 0x1A48780 VA: 0x181A4A180 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
[DebuggerTypeProxy(typeof(BindingRestrictions.BindingRestrictionsProxy))]
[DebuggerDisplay("{DebugView}")]
public abstract class BindingRestrictions // TypeDefIndex: 11296
{
	// Fields
	public static readonly BindingRestrictions Empty; // 0x0

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract Expression GetExpression();

	// RVA: 0x1A4A770 Offset: 0x1A48D70 VA: 0x181A4A770
	public BindingRestrictions Merge(BindingRestrictions restrictions) { }

	// RVA: 0x1A4A680 Offset: 0x1A48C80 VA: 0x181A4A680
	public static BindingRestrictions GetTypeRestriction(Expression expression, Type type) { }

	// RVA: 0x1A4A360 Offset: 0x1A48960 VA: 0x181A4A360
	internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj) { }

	// RVA: 0x1A4A290 Offset: 0x1A48890 VA: 0x181A4A290
	public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance) { }

	// RVA: 0x15267C0 Offset: 0x1524DC0 VA: 0x1815267C0
	public Expression ToExpression() { }

	// RVA: 0x1A4A8C0 Offset: 0x1A48EC0 VA: 0x181A4A8C0
	private static void .cctor() { }
}

// Namespace: System.Dynamic
public abstract class ConvertBinder : DynamicMetaObjectBinder // TypeDefIndex: 11297
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public Type Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Type get_Type() { }

	// RVA: 0x1333EB0 Offset: 0x13324B0 VA: 0x181333EB0
	public DynamicMetaObject FallbackConvert(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A4CDB0 Offset: 0x1A4B3B0 VA: 0x181A4CDB0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public abstract class CreateInstanceBinder : DynamicMetaObjectBinder // TypeDefIndex: 11298
{
	// Methods

	// RVA: 0x1A4A260 Offset: 0x1A48860 VA: 0x181A4A260
	public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A4D070 Offset: 0x1A4B670 VA: 0x181A4D070 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public abstract class DeleteIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 11299
{
	// Methods

	// RVA: 0x1A4E580 Offset: 0x1A4CB80 VA: 0x181A4E580 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1A4A260 Offset: 0x1A48860 VA: 0x181A4A260
	public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class DeleteMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 11300
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public string Name { get; }
	public bool IgnoreCase { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_IgnoreCase() { }

	// RVA: 0x1333EB0 Offset: 0x13324B0 VA: 0x181333EB0
	public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A4E630 Offset: 0x1A4CC30 VA: 0x181A4E630 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public class DynamicMetaObject // TypeDefIndex: 11301
{
	// Fields
	public static readonly DynamicMetaObject[] EmptyMetaObjects; // 0x0
	private static readonly object s_noValueSentinel; // 0x8
	private readonly object _value; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly BindingRestrictions <Restrictions>k__BackingField; // 0x20

	// Properties
	public Expression Expression { get; }
	public BindingRestrictions Restrictions { get; }
	public object Value { get; }
	public bool HasValue { get; }
	public Type RuntimeType { get; }
	public Type LimitType { get; }

	// Methods

	// RVA: 0x1A4FCE0 Offset: 0x1A4E2E0 VA: 0x181A4FCE0
	public void .ctor(Expression expression, BindingRestrictions restrictions) { }

	// RVA: 0x1A4FBE0 Offset: 0x1A4E1E0 VA: 0x181A4FBE0
	public void .ctor(Expression expression, BindingRestrictions restrictions, object value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Expression get_Expression() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public BindingRestrictions get_Restrictions() { }

	// RVA: 0x1A4FFD0 Offset: 0x1A4E5D0 VA: 0x181A4FFD0
	public object get_Value() { }

	// RVA: 0x1A4FDC0 Offset: 0x1A4E3C0 VA: 0x181A4FDC0
	public bool get_HasValue() { }

	// RVA: 0x1A4FF00 Offset: 0x1A4E500 VA: 0x181A4FF00
	public Type get_RuntimeType() { }

	// RVA: 0x1A4FE20 Offset: 0x1A4E420 VA: 0x181A4FE20
	public Type get_LimitType() { }

	// RVA: 0x1A4F300 Offset: 0x1A4D900 VA: 0x181A4F300 Slot: 4
	public virtual DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x1A4F580 Offset: 0x1A4DB80 VA: 0x181A4F580 Slot: 5
	public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x1A4F780 Offset: 0x1A4DD80 VA: 0x181A4F780 Slot: 6
	public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x1A4F490 Offset: 0x1A4DA90 VA: 0x181A4F490 Slot: 7
	public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x1A4F500 Offset: 0x1A4DB00 VA: 0x181A4F500 Slot: 8
	public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x1A4F6F0 Offset: 0x1A4DCF0 VA: 0x181A4F6F0 Slot: 9
	public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x1A4F400 Offset: 0x1A4DA00 VA: 0x181A4F400 Slot: 10
	public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x1A4F5F0 Offset: 0x1A4DBF0 VA: 0x181A4F5F0 Slot: 11
	public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1A4F670 Offset: 0x1A4DC70 VA: 0x181A4F670 Slot: 12
	public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1A4F370 Offset: 0x1A4D970 VA: 0x181A4F370 Slot: 13
	public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x1A4F800 Offset: 0x1A4DE00 VA: 0x181A4F800 Slot: 14
	public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x1A4F270 Offset: 0x1A4D870 VA: 0x181A4F270 Slot: 15
	public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x1A4FAF0 Offset: 0x1A4E0F0 VA: 0x181A4FAF0 Slot: 16
	public virtual IEnumerable<string> GetDynamicMemberNames() { }

	// RVA: 0x1A4F870 Offset: 0x1A4DE70 VA: 0x181A4F870
	public static DynamicMetaObject Create(object value, Expression expression) { }

	// RVA: 0x1A4FB20 Offset: 0x1A4E120 VA: 0x181A4FB20
	private static void .cctor() { }
}

// Namespace: System.Dynamic
public abstract class DynamicMetaObjectBinder : CallSiteBinder // TypeDefIndex: 11302
{
	// Properties
	public virtual Type ReturnType { get; }
	internal virtual bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x1A4F220 Offset: 0x1A4D820 VA: 0x181A4F220
	protected void .ctor() { }

	// RVA: 0x16592C0 Offset: 0x16578C0 VA: 0x1816592C0 Slot: 6
	public virtual Type get_ReturnType() { }

	// RVA: 0x1A4E7B0 Offset: 0x1A4CDB0 VA: 0x181A4E7B0 Slot: 4
	public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	// RVA: 0x1A4EFE0 Offset: 0x1A4D5E0 VA: 0x181A4EFE0
	private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);

	// RVA: 0x1A4F160 Offset: 0x1A4D760 VA: 0x181A4F160
	public Expression GetUpdateExpression(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	internal virtual bool get_IsStandardBinder() { }
}

// Namespace: System.Dynamic
internal class ExpandoClass // TypeDefIndex: 11303
{
	// Fields
	private readonly string[] _keys; // 0x10
	private readonly int _hashCode; // 0x18
	private Dictionary<int, List<WeakReference>> _transitions; // 0x20
	internal static readonly ExpandoClass Empty; // 0x0

	// Properties
	internal string[] Keys { get; }

	// Methods

	// RVA: 0x1A50A90 Offset: 0x1A4F090 VA: 0x181A50A90
	internal void .ctor() { }

	// RVA: 0x1A50A40 Offset: 0x1A4F040 VA: 0x181A50A40
	internal void .ctor(string[] keys, int hashCode) { }

	// RVA: 0x1A50150 Offset: 0x1A4E750 VA: 0x181A50150
	internal ExpandoClass FindNewClass(string newKey) { }

	// RVA: 0x1A50630 Offset: 0x1A4EC30 VA: 0x181A50630
	private List<WeakReference> GetTransitionList(int hashCode) { }

	// RVA: 0x1A50970 Offset: 0x1A4EF70 VA: 0x181A50970
	internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj) { }

	// RVA: 0x1A508D0 Offset: 0x1A4EED0 VA: 0x181A508D0
	internal int GetValueIndexCaseSensitive(string name) { }

	// RVA: 0x1A50760 Offset: 0x1A4ED60 VA: 0x181A50760
	private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal string[] get_Keys() { }

	// RVA: 0x1A50990 Offset: 0x1A4EF90 VA: 0x181A50990
	private static void .cctor() { }
}

// Namespace: System.Dynamic
public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged // TypeDefIndex: 11315
{
	// Fields
	private static readonly MethodInfo s_expandoTryGetValue; // 0x0
	private static readonly MethodInfo s_expandoTrySetValue; // 0x8
	private static readonly MethodInfo s_expandoTryDeleteValue; // 0x10
	private static readonly MethodInfo s_expandoPromoteClass; // 0x18
	private static readonly MethodInfo s_expandoCheckVersion; // 0x20
	internal readonly object LockObject; // 0x10
	private ExpandoObject.ExpandoData _data; // 0x18
	private int _count; // 0x20
	internal static readonly object Uninitialized; // 0x28
	private PropertyChangedEventHandler _propertyChanged; // 0x28

	// Properties
	internal ExpandoClass Class { get; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get; }
	private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values { get; }
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.Item { get; set; }
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x1A523A0 Offset: 0x1A509A0 VA: 0x181A523A0
	public void .ctor() { }

	// RVA: 0x1A51C60 Offset: 0x1A50260 VA: 0x181A51C60
	internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) { }

	// RVA: 0x1A51DB0 Offset: 0x1A503B0 VA: 0x181A51DB0
	internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) { }

	// RVA: 0x1A51960 Offset: 0x1A4FF60 VA: 0x181A51960
	internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) { }

	// RVA: 0x1A50BC0 Offset: 0x1A4F1C0 VA: 0x181A50BC0
	internal bool IsDeletedMember(int index) { }

	// RVA: 0x168F7D0 Offset: 0x168DDD0 VA: 0x18168F7D0
	internal ExpandoClass get_Class() { }

	// RVA: 0x1A50C60 Offset: 0x1A4F260 VA: 0x181A50C60
	private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) { }

	// RVA: 0x1A50CB0 Offset: 0x1A4F2B0 VA: 0x181A50CB0
	internal void PromoteClass(object oldClass, object newClass) { }

	// RVA: 0x1A51870 Offset: 0x1A4FE70 VA: 0x181A51870 Slot: 4
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0x1A518E0 Offset: 0x1A4FEE0 VA: 0x181A518E0
	private void TryAddMember(string key, object value) { }

	// RVA: 0x1A51660 Offset: 0x1A4FC60 VA: 0x181A51660
	private bool TryGetValueForKey(string key, out object value) { }

	// RVA: 0x1A50AF0 Offset: 0x1A4F0F0 VA: 0x181A50AF0
	private bool ExpandoContainsKey(string key) { }

	// RVA: 0x1A51700 Offset: 0x1A4FD00 VA: 0x181A51700 Slot: 7
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }

	// RVA: 0x1A51760 Offset: 0x1A4FD60 VA: 0x181A51760 Slot: 8
	private ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values() { }

	// RVA: 0x1A51690 Offset: 0x1A4FC90 VA: 0x181A51690 Slot: 5
	private object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(string key) { }

	// RVA: 0x1A517C0 Offset: 0x1A4FDC0 VA: 0x181A517C0 Slot: 6
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(string key, object value) { }

	// RVA: 0x1A514D0 Offset: 0x1A4FAD0 VA: 0x181A514D0 Slot: 10
	private void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value) { }

	// RVA: 0x1A514E0 Offset: 0x1A4FAE0 VA: 0x181A514E0 Slot: 9
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(string key) { }

	// RVA: 0x1A515B0 Offset: 0x1A4FBB0 VA: 0x181A515B0 Slot: 11
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(string key) { }

	// RVA: 0x1A51660 Offset: 0x1A4FC60 VA: 0x181A51660 Slot: 12
	private bool System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(string key, out object value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 13
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 14
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x1A50E30 Offset: 0x1A4F430 VA: 0x181A50E30 Slot: 15
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x1A50E90 Offset: 0x1A4F490 VA: 0x181A50E90 Slot: 16
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }

	// RVA: 0x1A510C0 Offset: 0x1A4F6C0 VA: 0x181A510C0 Slot: 17
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x1A51160 Offset: 0x1A4F760 VA: 0x181A51160 Slot: 18
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x1A51460 Offset: 0x1A4FA60 VA: 0x181A51460 Slot: 19
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	// RVA: 0x1A51840 Offset: 0x1A4FE40 VA: 0x181A51840 Slot: 20
	private IEnumerator<KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }

	// RVA: 0x1A51840 Offset: 0x1A4FE40 VA: 0x181A51840 Slot: 21
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachine(typeof(ExpandoObject.<GetExpandoEnumerator>d__51))]
	// RVA: 0x1A50B20 Offset: 0x1A4F120 VA: 0x181A50B20
	private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version) { }

	// RVA: 0x1A52110 Offset: 0x1A50710 VA: 0x181A52110
	private static void .cctor() { }
}

// Namespace: System.Dynamic
public abstract class GetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 11316
{
	// Methods

	// RVA: 0x1A68790 Offset: 0x1A66D90 VA: 0x181A68790 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1A4A260 Offset: 0x1A48860 VA: 0x181A4A260
	public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class GetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 11317
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public sealed override Type ReturnType { get; }
	public string Name { get; }
	public bool IgnoreCase { get; }
	internal sealed override bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x1A68970 Offset: 0x1A66F70 VA: 0x181A68970
	protected void .ctor(string name, bool ignoreCase) { }

	// RVA: 0x16592C0 Offset: 0x16578C0 VA: 0x1816592C0 Slot: 6
	public sealed override Type get_ReturnType() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_IgnoreCase() { }

	// RVA: 0x1333EB0 Offset: 0x13324B0 VA: 0x181333EB0
	public DynamicMetaObject FallbackGetMember(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A68880 Offset: 0x1A66E80 VA: 0x181A68880 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 8
	internal sealed override bool get_IsStandardBinder() { }
}

// Namespace: System.Dynamic
public interface IDynamicMetaObjectProvider // TypeDefIndex: 11318
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DynamicMetaObject GetMetaObject(Expression parameter);
}

// Namespace: System.Dynamic
public abstract class InvokeBinder : DynamicMetaObjectBinder // TypeDefIndex: 11319
{
	// Methods

	// RVA: 0x1A4A260 Offset: 0x1A48860 VA: 0x181A4A260
	public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A68A30 Offset: 0x1A67030 VA: 0x181A68A30 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

// Namespace: System.Dynamic
public abstract class InvokeMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 11320
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public string Name { get; }
	public bool IgnoreCase { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_IgnoreCase() { }

	// RVA: 0x1A68B20 Offset: 0x1A67120 VA: 0x181A68B20 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1A4A260 Offset: 0x1A48860 VA: 0x181A4A260
	public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class SetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 11321
{
	// Methods

	// RVA: 0x1A6CC10 Offset: 0x1A6B210 VA: 0x181A6CC10 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x1A6CE10 Offset: 0x1A6B410 VA: 0x181A6CE10
	public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class SetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 11322
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public sealed override Type ReturnType { get; }
	public string Name { get; }
	public bool IgnoreCase { get; }
	internal sealed override bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x1A6CFD0 Offset: 0x1A6B5D0 VA: 0x181A6CFD0
	protected void .ctor(string name, bool ignoreCase) { }

	// RVA: 0x16592C0 Offset: 0x16578C0 VA: 0x1816592C0 Slot: 6
	public sealed override Type get_ReturnType() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_IgnoreCase() { }

	// RVA: 0x1A6CE40 Offset: 0x1A6B440 VA: 0x181A6CE40 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 8
	internal sealed override bool get_IsStandardBinder() { }

	// RVA: 0x1A4A260 Offset: 0x1A48860 VA: 0x181A4A260
	public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}

// Namespace: System.Dynamic
public abstract class UnaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 11323
{
	// Methods

	// RVA: 0x1333EB0 Offset: 0x13324B0 VA: 0x181333EB0
	public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x1A722B0 Offset: 0x1A708B0 VA: 0x181A722B0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}

