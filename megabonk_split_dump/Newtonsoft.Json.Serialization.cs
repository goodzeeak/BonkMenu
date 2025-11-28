// Namespace: Newtonsoft.Json.Serialization
internal static class CachedAttributeGetter<T> // TypeDefIndex: 8355
{
	// Fields
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly ThreadSafeStore<object, T> TypeAttributeCache; // 0x0

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1
	public static T GetAttribute(object type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8D110 Offset: 0xC8B710 VA: 0x180C8D110
	|-CachedAttributeGetter<object>.GetAttribute
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC8D1F0 Offset: 0xC8B7F0 VA: 0x180C8D1F0
	|-CachedAttributeGetter<object>..cctor
	*/
}

// Namespace: Newtonsoft.Json.Serialization
public class CamelCaseNamingStrategy : NamingStrategy // TypeDefIndex: 8356
{
	// Methods

	// RVA: 0x16131D0 Offset: 0x16117D0 VA: 0x1816131D0
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0x1613180 Offset: 0x1611780 VA: 0x181613180
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x1613170 Offset: 0x1611770 VA: 0x181613170 Slot: 7
	protected override string ResolvePropertyName(string name) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class CamelCasePropertyNamesContractResolver : DefaultContractResolver // TypeDefIndex: 8357
{
	// Fields
	private static readonly object TypeContractCacheLock; // 0x0
	private static readonly DefaultJsonNameTable NameTable; // 0x8
	[Nullable(new[] { 2, 0, 1, 1, 1 })]
	private static Dictionary<StructMultiKey<Type, Type>, JsonContract> _contractCache; // 0x10

	// Methods

	// RVA: 0x1613670 Offset: 0x1611C70 VA: 0x181613670
	public void .ctor() { }

	// RVA: 0x1613260 Offset: 0x1611860 VA: 0x181613260 Slot: 5
	public override JsonContract ResolveContract(Type type) { }

	// RVA: 0x1613210 Offset: 0x1611810 VA: 0x181613210 Slot: 20
	internal override DefaultJsonNameTable GetNameTable() { }

	// RVA: 0x16135A0 Offset: 0x1611BA0 VA: 0x1816135A0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class DefaultContractResolver : IContractResolver // TypeDefIndex: 8369
{
	// Fields
	private static readonly IContractResolver _instance; // 0x0
	private static readonly string[] BlacklistedTypeNames; // 0x8
	private static readonly JsonConverter[] BuiltInConverters; // 0x10
	private readonly DefaultJsonNameTable _nameTable; // 0x10
	private readonly ThreadSafeStore<Type, JsonContract> _contractCache; // 0x18
	[CompilerGenerated]
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IgnoreSerializableInterface>k__BackingField; // 0x25
	[CompilerGenerated]
	private bool <IgnoreSerializableAttribute>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <IgnoreIsSpecifiedMembers>k__BackingField; // 0x27
	[CompilerGenerated]
	private bool <IgnoreShouldSerializeMembers>k__BackingField; // 0x28
	[Nullable(2)]
	[CompilerGenerated]
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x30

	// Properties
	internal static IContractResolver Instance { get; }
	public bool DynamicCodeGeneration { get; }
	[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
	public BindingFlags DefaultMembersSearchFlags { get; set; }
	public bool SerializeCompilerGeneratedMembers { get; set; }
	public bool IgnoreSerializableInterface { get; set; }
	public bool IgnoreSerializableAttribute { get; set; }
	public bool IgnoreIsSpecifiedMembers { get; set; }
	public bool IgnoreShouldSerializeMembers { get; set; }
	[Nullable(2)]
	public NamingStrategy NamingStrategy { get; set; }

	// Methods

	// RVA: 0x161BB20 Offset: 0x161A120 VA: 0x18161BB20
	internal static IContractResolver get_Instance() { }

	// RVA: 0x161BAB0 Offset: 0x161A0B0 VA: 0x18161BAB0
	public bool get_DynamicCodeGeneration() { }

	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGenerated]
	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGenerated]
	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	public void set_SerializeCompilerGeneratedMembers(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161BB10 Offset: 0x161A110 VA: 0x18161BB10
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGenerated]
	// RVA: 0x161BB90 Offset: 0x161A190 VA: 0x18161BB90
	public void set_IgnoreSerializableInterface(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161BB00 Offset: 0x161A100 VA: 0x18161BB00
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGenerated]
	// RVA: 0x161BB80 Offset: 0x161A180 VA: 0x18161BB80
	public void set_IgnoreSerializableAttribute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161BAF0 Offset: 0x161A0F0 VA: 0x18161BAF0
	public bool get_IgnoreIsSpecifiedMembers() { }

	[CompilerGenerated]
	// RVA: 0x161BB70 Offset: 0x161A170 VA: 0x18161BB70
	public void set_IgnoreIsSpecifiedMembers(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_IgnoreShouldSerializeMembers() { }

	[CompilerGenerated]
	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	public void set_IgnoreShouldSerializeMembers(bool value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public NamingStrategy get_NamingStrategy() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_NamingStrategy(NamingStrategy value) { }

	// RVA: 0x161B9B0 Offset: 0x1619FB0 VA: 0x18161B9B0
	public void .ctor() { }

	// RVA: 0x16198B0 Offset: 0x1617EB0 VA: 0x1816198B0 Slot: 5
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0x16166A0 Offset: 0x1614CA0 VA: 0x1816166A0
	private static bool FilterMembers(MemberInfo member) { }

	// RVA: 0x1617D20 Offset: 0x1616320 VA: 0x181617D20 Slot: 6
	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0x161B040 Offset: 0x1619640 VA: 0x18161B040
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0x1615200 Offset: 0x1613800 VA: 0x181615200 Slot: 7
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0x161B320 Offset: 0x1619920 VA: 0x18161B320
	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

	// RVA: 0x1617890 Offset: 0x1615E90 VA: 0x181617890
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0x1619A20 Offset: 0x1618020 VA: 0x181619A20
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0x16167C0 Offset: 0x1614DC0 VA: 0x1816167C0
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0x1617A90 Offset: 0x1616090 VA: 0x181617A90
	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	// RVA: 0x1617CB0 Offset: 0x16162B0 VA: 0x181617CB0
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0x1613BB0 Offset: 0x16121B0 VA: 0x181613BB0 Slot: 8
	protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0x1619510 Offset: 0x1617B10 VA: 0x181619510
	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	// RVA: 0x1615E10 Offset: 0x1614410 VA: 0x181615E10 Slot: 9
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0x1619860 Offset: 0x1617E60 VA: 0x181619860 Slot: 10
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0x16177F0 Offset: 0x1615DF0 VA: 0x1816177F0
	private Func<object> GetDefaultCreator(Type createdType) { }

	// RVA: 0x1618700 Offset: 0x1616D00 VA: 0x181618700
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0x16195C0 Offset: 0x1617BC0 VA: 0x1816195C0
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0x1616C10 Offset: 0x1615210 VA: 0x181616C10
	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) { }

	// RVA: 0x16189F0 Offset: 0x1616FF0 VA: 0x1816189F0
	private static bool IsConcurrentOrObservableCollection(Type t) { }

	// RVA: 0x161B160 Offset: 0x1619760 VA: 0x18161B160
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0x161B240 Offset: 0x1619840 VA: 0x18161B240
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0x1617530 Offset: 0x1615B30 VA: 0x181617530
	private List<Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0x16144A0 Offset: 0x1612AA0 VA: 0x1816144A0 Slot: 11
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0x1613810 Offset: 0x1611E10 VA: 0x181613810 Slot: 12
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0x16158F0 Offset: 0x1613EF0 VA: 0x1816158F0 Slot: 13
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0x16150B0 Offset: 0x16136B0 VA: 0x1816150B0 Slot: 14
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0x1614E50 Offset: 0x1613450 VA: 0x181614E50 Slot: 15
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0x1614AC0 Offset: 0x16130C0 VA: 0x181614AC0 Slot: 16
	protected virtual JsonDynamicContract CreateDynamicContract(Type objectType) { }

	// RVA: 0x1616630 Offset: 0x1614C30 VA: 0x181616630 Slot: 17
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0x1613DE0 Offset: 0x16123E0 VA: 0x181613DE0 Slot: 18
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0x1618CB0 Offset: 0x16172B0 VA: 0x181618CB0
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0x1618B30 Offset: 0x1617130 VA: 0x181618B30
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0x1613710 Offset: 0x1611D10 VA: 0x181613710
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0x1618D10 Offset: 0x1617310 VA: 0x181618D10
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	// RVA: 0x16176D0 Offset: 0x1615CD0 VA: 0x1816176D0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1615A20 Offset: 0x1614020 VA: 0x181615A20 Slot: 19
	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 20
	internal virtual DefaultJsonNameTable GetNameTable() { }

	// RVA: 0x1615130 Offset: 0x1613730 VA: 0x181615130 Slot: 21
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0x1616140 Offset: 0x1614740 VA: 0x181616140 Slot: 22
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0x161A910 Offset: 0x1618F10 VA: 0x18161A910
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	// RVA: 0x16163D0 Offset: 0x16149D0 VA: 0x1816163D0
	private Predicate<object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0x161A5E0 Offset: 0x1618BE0 VA: 0x18161A5E0
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0x16199F0 Offset: 0x1617FF0 VA: 0x1816199F0 Slot: 23
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0x16199C0 Offset: 0x1617FC0 VA: 0x1816199C0 Slot: 24
	protected virtual string ResolveExtensionDataName(string extensionDataName) { }

	// RVA: 0x1619970 Offset: 0x1617F70 VA: 0x181619970 Slot: 25
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0x1617D00 Offset: 0x1616300 VA: 0x181617D00
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0x161B3C0 Offset: 0x16199C0 VA: 0x18161B3C0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultNamingStrategy : NamingStrategy // TypeDefIndex: 8370
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470 Slot: 7
	protected override string ResolvePropertyName(string name) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 8371
{
	// Fields
	private int _referenceCount; // 0x10

	// Methods

	// RVA: 0x161BC20 Offset: 0x161A220 VA: 0x18161BC20
	private BidirectionalDictionary<string, object> GetMappings(object context) { }

	// RVA: 0x161BE90 Offset: 0x161A490 VA: 0x18161BE90 Slot: 4
	public object ResolveReference(object context, string reference) { }

	// RVA: 0x161BD20 Offset: 0x161A320 VA: 0x18161BD20 Slot: 5
	public string GetReference(object context, object value) { }

	// RVA: 0x161BBA0 Offset: 0x161A1A0 VA: 0x18161BBA0 Slot: 7
	public void AddReference(object context, string reference, object value) { }

	// RVA: 0x161BE10 Offset: 0x161A410 VA: 0x18161BE10 Slot: 6
	public bool IsReferenced(object context, object value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder // TypeDefIndex: 8372
{
	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	[Nullable(new[] { 1, 0, 2, 1, 1 })]
	private readonly ThreadSafeStore<StructMultiKey<string, string>, Type> _typeCache; // 0x10

	// Methods

	// RVA: 0x161C8B0 Offset: 0x161AEB0 VA: 0x18161C8B0
	public void .ctor() { }

	// RVA: 0x161C370 Offset: 0x161A970 VA: 0x18161C370
	private Type GetTypeFromTypeNameKey(StructMultiKey<string, string> typeNameKey) { }

	// RVA: 0x161C080 Offset: 0x161A680 VA: 0x18161C080
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	// RVA: 0x161C310 Offset: 0x161A910 VA: 0x18161C310
	private Type GetTypeByName(StructMultiKey<string, string> typeNameKey) { }

	// RVA: 0x161BFC0 Offset: 0x161A5C0 VA: 0x18161BFC0 Slot: 5
	public override Type BindToType(string assemblyName, string typeName) { }

	[NullableContext(2)]
	// RVA: 0x161BF20 Offset: 0x161A520 VA: 0x18161BF20 Slot: 4
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: 0x161C7A0 Offset: 0x161ADA0 VA: 0x18161C7A0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
public class DiagnosticsTraceWriter : ITraceWriter // TypeDefIndex: 8373
{
	// Fields
	[CompilerGenerated]
	private TraceLevel <LevelFilter>k__BackingField; // 0x10

	// Properties
	public TraceLevel LevelFilter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 4
	public TraceLevel get_LevelFilter() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_LevelFilter(TraceLevel value) { }

	// RVA: 0x161C970 Offset: 0x161AF70 VA: 0x18161C970
	private TraceEventType GetTraceEventType(TraceLevel level) { }

	[NullableContext(1)]
	// RVA: 0x161CA00 Offset: 0x161B000 VA: 0x18161CA00 Slot: 5
	public void Trace(TraceLevel level, string message, Exception ex) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ErrorContext // TypeDefIndex: 8374
{
	// Fields
	[CompilerGenerated]
	private bool <Traced>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Exception <Error>k__BackingField; // 0x18
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <OriginalObject>k__BackingField; // 0x20
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <Member>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <Handled>k__BackingField; // 0x38

	// Properties
	internal bool Traced { get; set; }
	public Exception Error { get; }
	[Nullable(2)]
	public object OriginalObject { get; }
	[Nullable(2)]
	public object Member { get; }
	public string Path { get; }
	public bool Handled { get; set; }

	// Methods

	// RVA: 0x161CE50 Offset: 0x161B450 VA: 0x18161CE50
	internal void .ctor(object originalObject, object member, string path, Exception error) { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	internal bool get_Traced() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	internal void set_Traced(bool value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Exception get_Error() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public object get_OriginalObject() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public object get_Member() { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_Path() { }

	[CompilerGenerated]
	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_Handled() { }

	[CompilerGenerated]
	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_Handled(bool value) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ErrorEventArgs : EventArgs // TypeDefIndex: 8375
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <CurrentObject>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ErrorContext <ErrorContext>k__BackingField; // 0x18

	// Properties
	[Nullable(2)]
	public object CurrentObject { get; }
	public ErrorContext ErrorContext { get; }

	// Methods

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public object get_CurrentObject() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ErrorContext get_ErrorContext() { }

	// RVA: 0x161CED0 Offset: 0x161B4D0 VA: 0x18161CED0
	public void .ctor(object currentObject, ErrorContext errorContext) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ExpressionValueProvider : IValueProvider // TypeDefIndex: 8376
{
	// Fields
	private readonly MemberInfo _memberInfo; // 0x10
	[Nullable(new[] { 2, 1, 2 })]
	private Func<object, object> _getter; // 0x18
	[Nullable(new[] { 2, 1, 2 })]
	private Action<object, object> _setter; // 0x20

	// Methods

	// RVA: 0x161D330 Offset: 0x161B930 VA: 0x18161D330
	public void .ctor(MemberInfo memberInfo) { }

	// RVA: 0x161D150 Offset: 0x161B750 VA: 0x18161D150 Slot: 4
	public void SetValue(object target, object value) { }

	// RVA: 0x161CF60 Offset: 0x161B560 VA: 0x18161CF60 Slot: 5
	public object GetValue(object target) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IAttributeProvider // TypeDefIndex: 8377
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IList<Attribute> GetAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IList<Attribute> GetAttributes(Type attributeType, bool inherit);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IContractResolver // TypeDefIndex: 8378
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract JsonContract ResolveContract(Type type);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IReferenceResolver // TypeDefIndex: 8379
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object ResolveReference(object context, string reference);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetReference(object context, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsReferenced(object context, object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddReference(object context, string reference, object value);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface ISerializationBinder // TypeDefIndex: 8380
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type BindToType(string assemblyName, string typeName);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void BindToName(Type serializedType, out string assemblyName, out string typeName);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface ITraceWriter // TypeDefIndex: 8381
{
	// Properties
	public abstract TraceLevel LevelFilter { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TraceLevel get_LevelFilter();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Trace(TraceLevel level, string message, Exception ex);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IValueProvider // TypeDefIndex: 8382
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetValue(object target, object value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object GetValue(object target);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 8383
{
	// Fields
	[CompilerGenerated]
	private readonly Type <CollectionItemType>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly bool <IsMultidimensionalArray>k__BackingField; // 0xC8
	private readonly Type _genericCollectionDefinitionType; // 0xD0
	private Type _genericWrapperType; // 0xD8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
	[Nullable(new[] { 2, 1 })]
	private Func<object> _genericTemporaryCollectionCreator; // 0xE8
	[CompilerGenerated]
	private readonly bool <IsArray>k__BackingField; // 0xF0
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0xF1
	[CompilerGenerated]
	private bool <CanDeserialize>k__BackingField; // 0xF2
	private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x100
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x108
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; // 0x110

	// Properties
	public Type CollectionItemType { get; }
	public bool IsMultidimensionalArray { get; }
	internal bool IsArray { get; }
	internal bool ShouldCreateWrapper { get; }
	internal bool CanDeserialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public Type get_CollectionItemType() { }

	[CompilerGenerated]
	// RVA: 0x14938F0 Offset: 0x1491EF0 VA: 0x1814938F0
	public bool get_IsMultidimensionalArray() { }

	[CompilerGenerated]
	// RVA: 0x161EE00 Offset: 0x161D400 VA: 0x18161EE00
	internal bool get_IsArray() { }

	[CompilerGenerated]
	// RVA: 0x161EEF0 Offset: 0x161D4F0 VA: 0x18161EEF0
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGenerated]
	// RVA: 0x161ED70 Offset: 0x161D370 VA: 0x18161ED70
	internal bool get_CanDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x161EF00 Offset: 0x161D500 VA: 0x18161EF00
	private void set_CanDeserialize(bool value) { }

	// RVA: 0x161EE10 Offset: 0x161D410 VA: 0x18161EE10
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x15B3B70 Offset: 0x15B2170 VA: 0x1815B3B70
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x161EF20 Offset: 0x161D520 VA: 0x18161EF20
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x161EDF0 Offset: 0x161D3F0 VA: 0x18161EDF0
	public bool get_HasParameterizedCreator() { }

	[CompilerGenerated]
	// RVA: 0x161EF10 Offset: 0x161D510 VA: 0x18161EF10
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x161ED80 Offset: 0x161D380 VA: 0x18161ED80
	internal bool get_HasParameterizedCreatorInternal() { }

	[NullableContext(1)]
	// RVA: 0x161DCC0 Offset: 0x161C2C0 VA: 0x18161DCC0
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x161D690 Offset: 0x161BC90 VA: 0x18161D690
	internal IWrappedCollection CreateWrapper(object list) { }

	[NullableContext(1)]
	// RVA: 0x161D420 Offset: 0x161BA20 VA: 0x18161D420
	internal IList CreateTemporaryCollection() { }

	[NullableContext(1)]
	// RVA: 0x161DB20 Offset: 0x161C120 VA: 0x18161DB20
	private void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonContainerContract : JsonContract // TypeDefIndex: 8384
{
	// Fields
	private JsonContract _itemContract; // 0x90
	private JsonContract _finalItemContract; // 0x98
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xAC
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xB4

	// Properties
	internal JsonContract ItemContract { get; set; }
	internal JsonContract FinalItemContract { get; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }

	// Methods

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	internal JsonContract get_ItemContract() { }

	// RVA: 0x161F0B0 Offset: 0x161D6B0 VA: 0x18161F0B0
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	internal JsonContract get_FinalItemContract() { }

	[CompilerGenerated]
	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x161F080 Offset: 0x161D680 VA: 0x18161F080
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGenerated]
	// RVA: 0x161F140 Offset: 0x161D740 VA: 0x18161F140
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x161F090 Offset: 0x161D690 VA: 0x18161F090
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x161F150 Offset: 0x161D750 VA: 0x18161F150
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x161F0A0 Offset: 0x161D6A0 VA: 0x18161F0A0
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x161F160 Offset: 0x161D760 VA: 0x18161F160
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[NullableContext(1)]
	// RVA: 0x161EF50 Offset: 0x161D550 VA: 0x18161EF50
	internal void .ctor(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
internal enum JsonContractType // TypeDefIndex: 8385
{
	// Fields
	public int value__; // 0x0
	public const JsonContractType None = 0;
	public const JsonContractType Object = 1;
	public const JsonContractType Array = 2;
	public const JsonContractType Primitive = 3;
	public const JsonContractType String = 4;
	public const JsonContractType Dictionary = 5;
	public const JsonContractType Dynamic = 6;
	public const JsonContractType Serializable = 7;
	public const JsonContractType Linq = 8;
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationCallback : MulticastDelegate // TypeDefIndex: 8386
{
	// Methods

	// RVA: 0xF27130 Offset: 0xF25730 VA: 0x180F27130
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0xF26A10 Offset: 0xF25010 VA: 0x180F26A10 Slot: 13
	public virtual void Invoke(object o, StreamingContext context) { }

	// RVA: 0x1631670 Offset: 0x162FC70 VA: 0x181631670 Slot: 14
	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationErrorCallback : MulticastDelegate // TypeDefIndex: 8387
{
	// Methods

	// RVA: 0x16317C0 Offset: 0x162FDC0 VA: 0x1816317C0
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x1631790 Offset: 0x162FD90 VA: 0x181631790 Slot: 13
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x1631700 Offset: 0x162FD00 VA: 0x181631700 Slot: 14
	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataSetter : MulticastDelegate // TypeDefIndex: 8388
{
	// Methods

	// RVA: 0xF28100 Offset: 0xF26700 VA: 0x180F28100
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x5976A0 Offset: 0x595CA0 VA: 0x1805976A0 Slot: 13
	public virtual void Invoke(object o, string key, object value) { }

	// RVA: 0x161D3E0 Offset: 0x161B9E0 VA: 0x18161D3E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object o, string key, object value, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataGetter : MulticastDelegate // TypeDefIndex: 8389
{
	// Methods

	// RVA: 0x13D0380 Offset: 0x13CE980 VA: 0x1813D0380
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x5D7950 Offset: 0x5D5F50 VA: 0x1805D7950 Slot: 13
	public virtual IEnumerable<KeyValuePair<object, object>> Invoke(object o) { }

	// RVA: 0x346290 Offset: 0x344890 VA: 0x180346290 Slot: 14
	public virtual IAsyncResult BeginInvoke(object o, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual IEnumerable<KeyValuePair<object, object>> EndInvoke(IAsyncResult result) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public abstract class JsonContract // TypeDefIndex: 8392
{
	// Fields
	internal bool IsNullable; // 0x10
	internal bool IsConvertable; // 0x11
	internal bool IsEnum; // 0x12
	internal Type NonNullableUnderlyingType; // 0x18
	internal ReadType InternalReadType; // 0x20
	internal JsonContractType ContractType; // 0x24
	internal bool IsReadOnlyOrFixedSize; // 0x28
	internal bool IsSealed; // 0x29
	internal bool IsInstantiable; // 0x2A
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onDeserializingCallbacks; // 0x38
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onSerializedCallbacks; // 0x40
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onSerializingCallbacks; // 0x48
	[Nullable(new[] { 2, 1 })]
	private List<SerializationErrorCallback> _onErrorCallbacks; // 0x50
	private Type _createdType; // 0x58
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<bool> <IsReference>k__BackingField; // 0x68
	[Nullable(2)]
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; // 0x70
	[Nullable(2)]
	[CompilerGenerated]
	private JsonConverter <InternalConverter>k__BackingField; // 0x78
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Func<object> <DefaultCreator>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <DefaultCreatorNonPublic>k__BackingField; // 0x88

	// Properties
	public Type UnderlyingType { get; }
	public Type CreatedType { get; set; }
	public Nullable<bool> IsReference { get; set; }
	[Nullable(2)]
	public JsonConverter Converter { get; set; }
	[Nullable(2)]
	public JsonConverter InternalConverter { get; set; }
	public IList<SerializationCallback> OnDeserializedCallbacks { get; }
	public IList<SerializationCallback> OnDeserializingCallbacks { get; }
	public IList<SerializationCallback> OnSerializedCallbacks { get; }
	public IList<SerializationCallback> OnSerializingCallbacks { get; }
	public IList<SerializationErrorCallback> OnErrorCallbacks { get; }
	[Nullable(new[] { 2, 1 })]
	public Func<object> DefaultCreator { get; set; }
	public bool DefaultCreatorNonPublic { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public Type get_UnderlyingType() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public Type get_CreatedType() { }

	// RVA: 0x161FDF0 Offset: 0x161E3F0 VA: 0x18161FDF0
	public void set_CreatedType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x161FB60 Offset: 0x161E160 VA: 0x18161FB60
	public Nullable<bool> get_IsReference() { }

	[CompilerGenerated]
	// RVA: 0x161FEF0 Offset: 0x161E4F0 VA: 0x18161FEF0
	public void set_IsReference(Nullable<bool> value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public JsonConverter get_Converter() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void set_Converter(JsonConverter value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public JsonConverter get_InternalConverter() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0x161FB70 Offset: 0x161E170 VA: 0x18161FB70
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0x161FBF0 Offset: 0x161E1F0 VA: 0x18161FBF0
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0x161FCF0 Offset: 0x161E2F0 VA: 0x18161FCF0
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0x161FD70 Offset: 0x161E370 VA: 0x18161FD70
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0x161FC70 Offset: 0x161E270 VA: 0x18161FC70
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGenerated]
	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public Func<object> get_DefaultCreator() { }

	[CompilerGenerated]
	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGenerated]
	// RVA: 0x3A35C0 Offset: 0x3A1BC0 VA: 0x1803A35C0
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGenerated]
	// RVA: 0x498D60 Offset: 0x497360 VA: 0x180498D60
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0x161F9B0 Offset: 0x161DFB0 VA: 0x18161F9B0
	internal void .ctor(Type underlyingType) { }

	// RVA: 0x161F880 Offset: 0x161DE80 VA: 0x18161F880
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0x161F750 Offset: 0x161DD50 VA: 0x18161F750
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0x161F4D0 Offset: 0x161DAD0 VA: 0x18161F4D0
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0x161F3A0 Offset: 0x161D9A0 VA: 0x18161F3A0
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0x161F600 Offset: 0x161DC00 VA: 0x18161F600
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x161F170 Offset: 0x161D770 VA: 0x18161F170
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0x161F220 Offset: 0x161D820 VA: 0x18161F220
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 8393
{
	// Fields
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <DictionaryKeyResolver>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly Type <DictionaryKeyType>k__BackingField; // 0xC8
	[CompilerGenerated]
	private readonly Type <DictionaryValueType>k__BackingField; // 0xD0
	[CompilerGenerated]
	private JsonContract <KeyContract>k__BackingField; // 0xD8
	private readonly Type _genericCollectionDefinitionType; // 0xE0
	private Type _genericWrapperType; // 0xE8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
	[Nullable(new[] { 2, 1 })]
	private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0x100
	private readonly ConstructorInfo _parameterizedConstructor; // 0x108
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x110
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x118
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; // 0x120

	// Properties
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> DictionaryKeyResolver { get; set; }
	public Type DictionaryKeyType { get; }
	public Type DictionaryValueType { get; }
	internal JsonContract KeyContract { get; set; }
	internal bool ShouldCreateWrapper { get; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public Func<string, string> get_DictionaryKeyResolver() { }

	[CompilerGenerated]
	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	public void set_DictionaryKeyResolver(Func<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	public Type get_DictionaryKeyType() { }

	[CompilerGenerated]
	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	public Type get_DictionaryValueType() { }

	[CompilerGenerated]
	// RVA: 0x3A3640 Offset: 0x3A1C40 VA: 0x1803A3640
	internal JsonContract get_KeyContract() { }

	[CompilerGenerated]
	// RVA: 0x15B40E0 Offset: 0x15B26E0 VA: 0x1815B40E0
	internal void set_KeyContract(JsonContract value) { }

	[CompilerGenerated]
	// RVA: 0x16212D0 Offset: 0x161F8D0 VA: 0x1816212D0
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0x16211F0 Offset: 0x161F7F0 VA: 0x1816211F0
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x16212F0 Offset: 0x161F8F0 VA: 0x1816212F0
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x16211E0 Offset: 0x161F7E0 VA: 0x1816211E0
	public bool get_HasParameterizedCreator() { }

	[CompilerGenerated]
	// RVA: 0x16212E0 Offset: 0x161F8E0 VA: 0x1816212E0
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x1621170 Offset: 0x161F770 VA: 0x181621170
	internal bool get_HasParameterizedCreatorInternal() { }

	[NullableContext(1)]
	// RVA: 0x1620500 Offset: 0x161EB00 VA: 0x181620500
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x16201B0 Offset: 0x161E7B0 VA: 0x1816201B0
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	[NullableContext(1)]
	// RVA: 0x161FF00 Offset: 0x161E500 VA: 0x18161FF00
	internal IDictionary CreateTemporaryDictionary() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class JsonDynamicContract : JsonContainerContract // TypeDefIndex: 8394
{
	// Fields
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xC0
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <PropertyNameResolver>k__BackingField; // 0xC8
	private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters; // 0xD0
	[Nullable(new[] { 1, 1, 1, 1, 1, 1, 2, 1 })]
	private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> _callSiteSetters; // 0xD8

	// Properties
	public JsonPropertyCollection Properties { get; }
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> PropertyNameResolver { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public JsonPropertyCollection get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	public Func<string, string> get_PropertyNameResolver() { }

	[CompilerGenerated]
	// RVA: 0x1621970 Offset: 0x161FF70 VA: 0x181621970
	public void set_PropertyNameResolver(Func<string, string> value) { }

	// RVA: 0x1621310 Offset: 0x161F910 VA: 0x181621310
	private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name) { }

	// RVA: 0x1621410 Offset: 0x161FA10 VA: 0x181621410
	private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name) { }

	// RVA: 0x16217C0 Offset: 0x161FDC0 VA: 0x1816217C0
	public void .ctor(Type underlyingType) { }

	// RVA: 0x1621510 Offset: 0x161FB10 VA: 0x181621510
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value) { }

	// RVA: 0x1621670 Offset: 0x161FC70 VA: 0x181621670
	internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 8395
{
	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	[Nullable(2)]
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0x1622210 Offset: 0x1620810 VA: 0x181622210
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: -1 Offset: -1
	private T GetTokenValue<T>(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x711400 Offset: 0x70FA00 VA: 0x180711400
	|-JsonFormatterConverter.GetTokenValue<bool>
	|-JsonFormatterConverter.GetTokenValue<byte>
	|-JsonFormatterConverter.GetTokenValue<sbyte>
	|
	|-RVA: 0x711590 Offset: 0x70FB90 VA: 0x180711590
	|-JsonFormatterConverter.GetTokenValue<char>
	|-JsonFormatterConverter.GetTokenValue<short>
	|-JsonFormatterConverter.GetTokenValue<ushort>
	|
	|-RVA: 0x711720 Offset: 0x70FD20 VA: 0x180711720
	|-JsonFormatterConverter.GetTokenValue<DateTime>
	|-JsonFormatterConverter.GetTokenValue<long>
	|-JsonFormatterConverter.GetTokenValue<ulong>
	|
	|-RVA: 0x7118B0 Offset: 0x70FEB0 VA: 0x1807118B0
	|-JsonFormatterConverter.GetTokenValue<Decimal>
	|
	|-RVA: 0x711A50 Offset: 0x710050 VA: 0x180711A50
	|-JsonFormatterConverter.GetTokenValue<double>
	|
	|-RVA: 0x711DB0 Offset: 0x7103B0 VA: 0x180711DB0
	|-JsonFormatterConverter.GetTokenValue<int>
	|-JsonFormatterConverter.GetTokenValue<uint>
	|
	|-RVA: 0x711F40 Offset: 0x710540 VA: 0x180711F40
	|-JsonFormatterConverter.GetTokenValue<object>
	|
	|-RVA: 0x7120D0 Offset: 0x7106D0 VA: 0x1807120D0
	|-JsonFormatterConverter.GetTokenValue<float>
	|
	|-RVA: 0x711BE0 Offset: 0x7101E0 VA: 0x180711BE0
	|-JsonFormatterConverter.GetTokenValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1621AC0 Offset: 0x16200C0 VA: 0x181621AC0 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x1621990 Offset: 0x161FF90 VA: 0x181621990 Slot: 10
	public object Convert(object value, TypeCode typeCode) { }

	// RVA: 0x1621D40 Offset: 0x1620340 VA: 0x181621D40 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x1621D90 Offset: 0x1620390 VA: 0x181621D90 Slot: 11
	public byte ToByte(object value) { }

	// RVA: 0x1621DE0 Offset: 0x16203E0 VA: 0x181621DE0 Slot: 12
	public char ToChar(object value) { }

	// RVA: 0x1621E30 Offset: 0x1620430 VA: 0x181621E30 Slot: 13
	public DateTime ToDateTime(object value) { }

	// RVA: 0x1621E80 Offset: 0x1620480 VA: 0x181621E80 Slot: 14
	public Decimal ToDecimal(object value) { }

	// RVA: 0x1621EF0 Offset: 0x16204F0 VA: 0x181621EF0 Slot: 15
	public double ToDouble(object value) { }

	// RVA: 0x1621F40 Offset: 0x1620540 VA: 0x181621F40 Slot: 16
	public short ToInt16(object value) { }

	// RVA: 0x1621F90 Offset: 0x1620590 VA: 0x181621F90 Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x1621FE0 Offset: 0x16205E0 VA: 0x181621FE0 Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x1622030 Offset: 0x1620630 VA: 0x181622030 Slot: 17
	public sbyte ToSByte(object value) { }

	// RVA: 0x1622080 Offset: 0x1620680 VA: 0x181622080 Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x16220D0 Offset: 0x16206D0 VA: 0x1816220D0 Slot: 9
	public string ToString(object value) { }

	// RVA: 0x1622120 Offset: 0x1620720 VA: 0x181622120 Slot: 18
	public ushort ToUInt16(object value) { }

	// RVA: 0x1622170 Offset: 0x1620770 VA: 0x181622170 Slot: 19
	public uint ToUInt32(object value) { }

	// RVA: 0x16221C0 Offset: 0x16207C0 VA: 0x1816221C0 Slot: 20
	public ulong ToUInt64(object value) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class JsonISerializableContract : JsonContainerContract // TypeDefIndex: 8396
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private ObjectConstructor<object> <ISerializableCreator>k__BackingField; // 0xC0

	// Properties
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> ISerializableCreator { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public ObjectConstructor<object> get_ISerializableCreator() { }

	[CompilerGenerated]
	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	public void set_ISerializableCreator(ObjectConstructor<object> value) { }

	[NullableContext(1)]
	// RVA: 0x1622350 Offset: 0x1620950 VA: 0x181622350
	public void .ctor(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class JsonLinqContract : JsonContract // TypeDefIndex: 8397
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1622370 Offset: 0x1620970 VA: 0x181622370
	public void .ctor(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 8398
{
	// Fields
	[CompilerGenerated]
	private MemberSerialization <MemberSerialization>k__BackingField; // 0xC0
	[CompilerGenerated]
	private Nullable<MissingMemberHandling> <MissingMemberHandling>k__BackingField; // 0xC4
	[CompilerGenerated]
	private Nullable<Required> <ItemRequired>k__BackingField; // 0xCC
	[CompilerGenerated]
	private Nullable<NullValueHandling> <ItemNullValueHandling>k__BackingField; // 0xD4
	[Nullable(1)]
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xE0
	[CompilerGenerated]
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; // 0xE8
	[CompilerGenerated]
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; // 0xF0
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <ExtensionDataNameResolver>k__BackingField; // 0xF8
	internal bool ExtensionDataIsJToken; // 0x100
	private Nullable<bool> _hasRequiredOrDefaultValueProperties; // 0x101
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x108
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x110
	private JsonPropertyCollection _creatorParameters; // 0x118
	private Type _extensionDataValueType; // 0x120

	// Properties
	public MemberSerialization MemberSerialization { get; set; }
	public Nullable<MissingMemberHandling> MissingMemberHandling { get; set; }
	public Nullable<Required> ItemRequired { get; set; }
	public Nullable<NullValueHandling> ItemNullValueHandling { get; set; }
	[Nullable(1)]
	public JsonPropertyCollection Properties { get; }
	[Nullable(1)]
	public JsonPropertyCollection CreatorParameters { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; set; }
	public ExtensionDataSetter ExtensionDataSetter { get; set; }
	public ExtensionDataGetter ExtensionDataGetter { get; set; }
	public Type ExtensionDataValueType { get; set; }
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> ExtensionDataNameResolver { get; set; }
	internal bool HasRequiredOrDefaultValueProperties { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x145DB40 Offset: 0x145C140 VA: 0x18145DB40
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGenerated]
	// RVA: 0x16229D0 Offset: 0x1620FD0 VA: 0x1816229D0
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGenerated]
	// RVA: 0x16228C0 Offset: 0x1620EC0 VA: 0x1816228C0
	public Nullable<MissingMemberHandling> get_MissingMemberHandling() { }

	[CompilerGenerated]
	// RVA: 0x16229E0 Offset: 0x1620FE0 VA: 0x1816229E0
	public void set_MissingMemberHandling(Nullable<MissingMemberHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x16228B0 Offset: 0x1620EB0 VA: 0x1816228B0
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGenerated]
	// RVA: 0x16229C0 Offset: 0x1620FC0 VA: 0x1816229C0
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGenerated]
	// RVA: 0x16228A0 Offset: 0x1620EA0 VA: 0x1816228A0
	public Nullable<NullValueHandling> get_ItemNullValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x16229B0 Offset: 0x1620FB0 VA: 0x1816229B0
	public void set_ItemNullValueHandling(Nullable<NullValueHandling> value) { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	public JsonPropertyCollection get_Properties() { }

	[NullableContext(1)]
	// RVA: 0x1622530 Offset: 0x1620B30 VA: 0x181622530
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0x15B3B70 Offset: 0x15B2170 VA: 0x1815B3B70
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x15B42C0 Offset: 0x15B28C0 VA: 0x1815B42C0
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x16212F0 Offset: 0x161F8F0 VA: 0x1816212F0
	internal void set_ParameterizedCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x5513E0 Offset: 0x54F9E0 VA: 0x1805513E0
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGenerated]
	// RVA: 0x15B42A0 Offset: 0x15B28A0 VA: 0x1815B42A0
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGenerated]
	// RVA: 0x551B80 Offset: 0x550180 VA: 0x180551B80
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGenerated]
	// RVA: 0x551B90 Offset: 0x550190 VA: 0x180551B90
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0x8DA910 Offset: 0x8D8F10 VA: 0x1808DA910
	public Type get_ExtensionDataValueType() { }

	// RVA: 0x16228D0 Offset: 0x1620ED0 VA: 0x1816228D0
	public void set_ExtensionDataValueType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x5612C0 Offset: 0x55F8C0 VA: 0x1805612C0
	public Func<string, string> get_ExtensionDataNameResolver() { }

	[CompilerGenerated]
	// RVA: 0x15B4860 Offset: 0x15B2E60 VA: 0x1815B4860
	public void set_ExtensionDataNameResolver(Func<string, string> value) { }

	// RVA: 0x16225C0 Offset: 0x1620BC0 VA: 0x1816225C0
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	[NullableContext(1)]
	// RVA: 0x16224A0 Offset: 0x1620AA0 VA: 0x1816224A0
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x1622390 Offset: 0x1620990 VA: 0x181622390
	internal object GetUninitializedObject() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class JsonPrimitiveContract : JsonContract // TypeDefIndex: 8399
{
	// Fields
	[CompilerGenerated]
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x90
	private static readonly Dictionary<Type, ReadType> ReadTypeMap; // 0x0

	// Properties
	internal PrimitiveTypeCode TypeCode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	internal PrimitiveTypeCode get_TypeCode() { }

	[CompilerGenerated]
	// RVA: 0xAC7EF0 Offset: 0xAC64F0 VA: 0x180AC7EF0
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0x1622CD0 Offset: 0x16212D0 VA: 0x181622CD0
	public void .ctor(Type underlyingType) { }

	// RVA: 0x16229F0 Offset: 0x1620FF0 VA: 0x1816229F0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonProperty // TypeDefIndex: 8400
{
	// Fields
	internal Nullable<Required> _required; // 0x10
	internal bool _hasExplicitDefaultValue; // 0x18
	private object _defaultValue; // 0x20
	private bool _hasGeneratedDefaultValue; // 0x28
	private string _propertyName; // 0x30
	internal bool _skipPropertyNameEscape; // 0x38
	private Type _propertyType; // 0x40
	[CompilerGenerated]
	private JsonContract <PropertyContract>k__BackingField; // 0x48
	[CompilerGenerated]
	private Type <DeclaringType>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<int> <Order>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <UnderlyingName>k__BackingField; // 0x60
	[CompilerGenerated]
	private IValueProvider <ValueProvider>k__BackingField; // 0x68
	[CompilerGenerated]
	private IAttributeProvider <AttributeProvider>k__BackingField; // 0x70
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <Ignored>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <Readable>k__BackingField; // 0x81
	[CompilerGenerated]
	private bool <Writable>k__BackingField; // 0x82
	[CompilerGenerated]
	private bool <HasMemberAttribute>k__BackingField; // 0x83
	[CompilerGenerated]
	private Nullable<bool> <IsReference>k__BackingField; // 0x84
	[CompilerGenerated]
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; // 0x88
	[CompilerGenerated]
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; // 0x90
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; // 0x98
	[CompilerGenerated]
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; // 0xA8
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <ShouldSerialize>k__BackingField; // 0xB0
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <ShouldDeserialize>k__BackingField; // 0xB8
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <GetIsSpecified>k__BackingField; // 0xC0
	[Nullable(new[] { 2, 1, 2 })]
	[CompilerGenerated]
	private Action<object, object> <SetIsSpecified>k__BackingField; // 0xC8
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; // 0xD0
	[CompilerGenerated]
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xD8
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xDC
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xE4

	// Properties
	internal JsonContract PropertyContract { get; set; }
	public string PropertyName { get; set; }
	public Type DeclaringType { get; set; }
	public Nullable<int> Order { get; set; }
	public string UnderlyingName { get; set; }
	public IValueProvider ValueProvider { get; set; }
	public IAttributeProvider AttributeProvider { get; set; }
	public Type PropertyType { get; set; }
	public JsonConverter Converter { get; set; }
	[Obsolete("MemberConverter is obsolete. Use Converter instead.")]
	public JsonConverter MemberConverter { get; set; }
	public bool Ignored { get; set; }
	public bool Readable { get; set; }
	public bool Writable { get; set; }
	public bool HasMemberAttribute { get; set; }
	public object DefaultValue { get; set; }
	public Required Required { get; set; }
	public bool IsRequiredSpecified { get; }
	public Nullable<bool> IsReference { get; set; }
	public Nullable<NullValueHandling> NullValueHandling { get; set; }
	public Nullable<DefaultValueHandling> DefaultValueHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling { get; set; }
	public Nullable<ObjectCreationHandling> ObjectCreationHandling { get; set; }
	public Nullable<TypeNameHandling> TypeNameHandling { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> ShouldSerialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> ShouldDeserialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> GetIsSpecified { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Action<object, object> SetIsSpecified { get; set; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal JsonContract get_PropertyContract() { }

	[CompilerGenerated]
	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_PropertyName() { }

	// RVA: 0x1623870 Offset: 0x1621E70 VA: 0x181623870
	public void set_PropertyName(string value) { }

	[CompilerGenerated]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public Type get_DeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_DeclaringType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public Nullable<int> get_Order() { }

	[CompilerGenerated]
	// RVA: 0x1623860 Offset: 0x1621E60 VA: 0x181623860
	public void set_Order(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public string get_UnderlyingName() { }

	[CompilerGenerated]
	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_UnderlyingName(string value) { }

	[CompilerGenerated]
	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public IValueProvider get_ValueProvider() { }

	[CompilerGenerated]
	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGenerated]
	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public IAttributeProvider get_AttributeProvider() { }

	[CompilerGenerated]
	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public Type get_PropertyType() { }

	// RVA: 0x1623900 Offset: 0x1621F00 VA: 0x181623900
	public void set_PropertyType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public JsonConverter get_Converter() { }

	[CompilerGenerated]
	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	public void set_Converter(JsonConverter value) { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public JsonConverter get_MemberConverter() { }

	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	public void set_MemberConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x100F470 Offset: 0x100DA70 VA: 0x18100F470
	public bool get_Ignored() { }

	[CompilerGenerated]
	// RVA: 0x100F480 Offset: 0x100DA80 VA: 0x18100F480
	public void set_Ignored(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1623760 Offset: 0x1621D60 VA: 0x181623760
	public bool get_Readable() { }

	[CompilerGenerated]
	// RVA: 0x1623970 Offset: 0x1621F70 VA: 0x181623970
	public void set_Readable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x15D1080 Offset: 0x15CF680 VA: 0x1815D1080
	public bool get_Writable() { }

	[CompilerGenerated]
	// RVA: 0x15D1230 Offset: 0x15CF830 VA: 0x1815D1230
	public void set_Writable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x16236D0 Offset: 0x1621CD0 VA: 0x1816236D0
	public bool get_HasMemberAttribute() { }

	[CompilerGenerated]
	// RVA: 0x16237F0 Offset: 0x1621DF0 VA: 0x1816237F0
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0x16236C0 Offset: 0x1621CC0 VA: 0x1816236C0
	public object get_DefaultValue() { }

	// RVA: 0x16237D0 Offset: 0x1621DD0 VA: 0x1816237D0
	public void set_DefaultValue(object value) { }

	// RVA: 0x16235A0 Offset: 0x1621BA0 VA: 0x1816235A0
	internal object GetResolvedDefaultValue() { }

	// RVA: 0x1623770 Offset: 0x1621D70 VA: 0x181623770
	public Required get_Required() { }

	// RVA: 0x1623990 Offset: 0x1621F90 VA: 0x181623990
	public void set_Required(Required value) { }

	// RVA: 0x16236F0 Offset: 0x1621CF0 VA: 0x1816236F0
	public bool get_IsRequiredSpecified() { }

	[CompilerGenerated]
	// RVA: 0x16236E0 Offset: 0x1621CE0 VA: 0x1816236E0
	public Nullable<bool> get_IsReference() { }

	[CompilerGenerated]
	// RVA: 0x1623800 Offset: 0x1621E00 VA: 0x181623800
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x1623840 Offset: 0x1621E40 VA: 0x181623840
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGenerated]
	// RVA: 0xC9EC00 Offset: 0xC9D200 VA: 0x180C9EC00
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x1623980 Offset: 0x1621F80 VA: 0x181623980
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGenerated]
	// RVA: 0x1623850 Offset: 0x1621E50 VA: 0x181623850
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x16239F0 Offset: 0x1621FF0 VA: 0x1816239F0
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x16237B0 Offset: 0x1621DB0 VA: 0x1816237B0
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGenerated]
	// RVA: 0x8DA860 Offset: 0x8D8E60 VA: 0x1808DA860
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x131C550 Offset: 0x131AB50 VA: 0x18131C550
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x8221D0 Offset: 0x8207D0 VA: 0x1808221D0
	public void set_ShouldDeserialize(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGenerated]
	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGenerated]
	// RVA: 0x1621970 Offset: 0x161FF70 VA: 0x181621970
	public void set_SetIsSpecified(Action<object, object> value) { }

	[NullableContext(1)]
	// RVA: 0x1623650 Offset: 0x1621C50 VA: 0x181623650 Slot: 3
	public override string ToString() { }

	[CompilerGenerated]
	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	// RVA: 0x510990 Offset: 0x50EF90 VA: 0x180510990
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x1623730 Offset: 0x1621D30 VA: 0x181623730
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGenerated]
	// RVA: 0x1623810 Offset: 0x1621E10 VA: 0x181623810
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1623750 Offset: 0x1621D50 VA: 0x181623750
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x1623830 Offset: 0x1621E30 VA: 0x181623830
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x1623740 Offset: 0x1621D40 VA: 0x181623740
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x1623820 Offset: 0x1621E20 VA: 0x181623820
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[NullableContext(1)]
	// RVA: 0x1623670 Offset: 0x1621C70 VA: 0x181623670
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(new[] { 0, 1, 1 })]
public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 8401
{
	// Fields
	private readonly Type _type; // 0x30
	private readonly List<JsonProperty> _list; // 0x38

	// Methods

	// RVA: 0x16233D0 Offset: 0x16219D0 VA: 0x1816233D0
	public void .ctor(Type type) { }

	// RVA: 0x16230F0 Offset: 0x16216F0 VA: 0x1816230F0 Slot: 39
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0x1622DC0 Offset: 0x16213C0 VA: 0x181622DC0
	public void AddProperty(JsonProperty property) { }

	// RVA: 0x16230B0 Offset: 0x16216B0 VA: 0x1816230B0
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0x16232D0 Offset: 0x16218D0 VA: 0x1816232D0
	private bool TryGetValue(string key, out JsonProperty item) { }

	// RVA: 0x1623110 Offset: 0x1621710 VA: 0x181623110
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal abstract class JsonSerializerInternalBase // TypeDefIndex: 8403
{
	// Fields
	[Nullable(2)]
	private ErrorContext _currentErrorContext; // 0x10
	[Nullable(new[] { 2, 1, 1 })]
	private BidirectionalDictionary<string, object> _mappings; // 0x18
	internal readonly JsonSerializer Serializer; // 0x20
	[Nullable(2)]
	internal readonly ITraceWriter TraceWriter; // 0x28
	[Nullable(2)]
	protected JsonSerializerProxy InternalSerializer; // 0x30

	// Properties
	internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; }

	// Methods

	// RVA: 0x1624090 Offset: 0x1622690 VA: 0x181624090
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0x1624160 Offset: 0x1622760 VA: 0x181624160
	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	// RVA: 0x1623FF0 Offset: 0x16225F0 VA: 0x181623FF0
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0x1623A80 Offset: 0x1622080 VA: 0x181623A80
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0x1623A00 Offset: 0x1622000 VA: 0x181623A00
	protected void ClearErrorContext() { }

	[NullableContext(2)]
	// RVA: 0x1623BC0 Offset: 0x16221C0 VA: 0x181623BC0
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 8408
{
	// Methods

	// RVA: 0x1624090 Offset: 0x1622690 VA: 0x181624090
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x162E8E0 Offset: 0x162CEE0 VA: 0x18162E8E0
	public void Populate(JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x162BA40 Offset: 0x162A040 VA: 0x18162BA40
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0x162BAE0 Offset: 0x162A0E0 VA: 0x18162BAE0
	private JsonContract GetContract(Type type) { }

	[NullableContext(2)]
	// RVA: 0x162AB60 Offset: 0x1629160 VA: 0x18162AB60
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0x162BD20 Offset: 0x162A320 VA: 0x18162BD20
	private JsonSerializerProxy GetInternalSerializer() { }

	[NullableContext(2)]
	// RVA: 0x1626390 Offset: 0x1624990 VA: 0x181626390
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0x1626090 Offset: 0x1624690 VA: 0x181626090
	private JToken CreateJObject(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x162A320 Offset: 0x1628920 VA: 0x18162A320
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	// RVA: 0x1624DA0 Offset: 0x16233A0 VA: 0x181624DA0
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0x162BC20 Offset: 0x162A220 VA: 0x18162BC20
	internal string GetExpectedDescription(JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x162BB40 Offset: 0x162A140 VA: 0x18162BB40
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x16290C0 Offset: 0x16276C0 VA: 0x1816290C0
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	// RVA: 0x162EF90 Offset: 0x162D590 VA: 0x18162EF90
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	// RVA: 0x162F690 Offset: 0x162DC90 VA: 0x18162F690
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	// RVA: 0x1630650 Offset: 0x162EC50 VA: 0x181630650
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0x162B360 Offset: 0x1629960 VA: 0x18162B360
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x1626750 Offset: 0x1624D50 VA: 0x181626750
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	[NullableContext(2)]
	// RVA: 0x162BE10 Offset: 0x162A410 VA: 0x18162BE10
	private bool HasNoDefinedType(JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x162B520 Offset: 0x1629B20 VA: 0x18162B520
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0x1630E30 Offset: 0x162F430 VA: 0x181630E30
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x1624630 Offset: 0x1622C30 VA: 0x181624630
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue) { }

	// RVA: 0x1624360 Offset: 0x1622960 VA: 0x181624360
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0x14042E0 Offset: 0x14028E0 VA: 0x1814042E0
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	[NullableContext(2)]
	// RVA: 0x16313D0 Offset: 0x162F9D0 VA: 0x1816313D0
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	// RVA: 0x16272C0 Offset: 0x16258C0 VA: 0x1816272C0
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x1627010 Offset: 0x1625610 VA: 0x181627010
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x162C090 Offset: 0x162A690 VA: 0x18162C090
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x162BEE0 Offset: 0x162A4E0 VA: 0x18162BEE0
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x162C240 Offset: 0x162A840 VA: 0x18162C240
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x162D2C0 Offset: 0x162B8C0 VA: 0x18162D2C0
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x1631540 Offset: 0x162FB40 VA: 0x181631540
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0x162CCC0 Offset: 0x162B2C0 VA: 0x18162CCC0
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x16258F0 Offset: 0x1623EF0 VA: 0x1816258F0
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0x1625780 Offset: 0x1623D80 VA: 0x181625780
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x1624E90 Offset: 0x1623490 VA: 0x181624E90
	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	// RVA: 0x1627920 Offset: 0x1625F20 VA: 0x181627920
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	// RVA: 0x162A840 Offset: 0x1628E40 VA: 0x18162A840
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0x162FD20 Offset: 0x162E320 VA: 0x18162FD20
	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0x1627630 Offset: 0x1625C30 VA: 0x181627630
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x162DB80 Offset: 0x162C180 VA: 0x18162DB80
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0x1631200 Offset: 0x162F800 VA: 0x181631200
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0x1624C90 Offset: 0x1623290 VA: 0x181624C90
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0x1630BE0 Offset: 0x162F1E0 VA: 0x181630BE0
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0x162EED0 Offset: 0x162D4D0 VA: 0x18162EED0
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0x162AEC0 Offset: 0x16294C0 VA: 0x18162AEC0
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0x1630D10 Offset: 0x162F310 VA: 0x181630D10
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0x162BD90 Offset: 0x162A390 VA: 0x18162BD90
	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 8409
{
	// Fields
	[Nullable(2)]
	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly List<object> _serializeStack; // 0x48

	// Methods

	// RVA: 0x1649320 Offset: 0x1647920 VA: 0x181649320
	public void .ctor(JsonSerializer serializer) { }

	[NullableContext(2)]
	// RVA: 0x16477E0 Offset: 0x1645DE0 VA: 0x1816477E0
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x1641F10 Offset: 0x1640510 VA: 0x181641F10
	private JsonSerializerProxy GetInternalSerializer() { }

	[NullableContext(2)]
	// RVA: 0x1641E10 Offset: 0x1640410 VA: 0x181641E10
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0x1641E90 Offset: 0x1640490 VA: 0x181641E90
	private JsonContract GetContract(object value) { }

	// RVA: 0x1646CF0 Offset: 0x16452F0 VA: 0x181646CF0
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x16470A0 Offset: 0x16456A0 VA: 0x1816470A0
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1642CC0 Offset: 0x16412C0 VA: 0x181642CC0
	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1647E20 Offset: 0x1646420 VA: 0x181647E20
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1647D50 Offset: 0x1646350 VA: 0x181647D50
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	[NullableContext(2)]
	// RVA: 0x1641A00 Offset: 0x1640000 VA: 0x181641A00
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1648A60 Offset: 0x1647060 VA: 0x181648A60
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0x1642520 Offset: 0x1640B20 VA: 0x181642520
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0x1648230 Offset: 0x1646830 VA: 0x181648230
	internal static bool TryConvertToString(object value, Type type, out string s) { }

	// RVA: 0x1646FF0 Offset: 0x16455F0 VA: 0x181646FF0
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0x1642B40 Offset: 0x1641140 VA: 0x181642B40
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x16429C0 Offset: 0x1640FC0 VA: 0x1816429C0
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x1646150 Offset: 0x1644750 VA: 0x181646150
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x16411B0 Offset: 0x163F7B0 VA: 0x1816411B0
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	// RVA: 0x16484E0 Offset: 0x1646AE0 VA: 0x1816484E0
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1642750 Offset: 0x1640D50 VA: 0x181642750
	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	// RVA: 0x16488B0 Offset: 0x1646EB0 VA: 0x1816488B0
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0x1649140 Offset: 0x1647740 VA: 0x181649140
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0x14042E0 Offset: 0x14028E0 VA: 0x1814042E0
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x14042E0 Offset: 0x14028E0 VA: 0x1814042E0
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0x14042E0 Offset: 0x14028E0 VA: 0x1814042E0
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0x1642D50 Offset: 0x1641350 VA: 0x181642D50
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1645580 Offset: 0x1643B80 VA: 0x181645580
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1645F00 Offset: 0x1644500 VA: 0x181645F00
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1645B10 Offset: 0x1644110 VA: 0x181645B10
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0x1648C50 Offset: 0x1647250 VA: 0x181648C50
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1644C10 Offset: 0x1643210 VA: 0x181644C10
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1643C70 Offset: 0x1642270 VA: 0x181643C70
	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1647CA0 Offset: 0x16462A0 VA: 0x181647CA0
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	[NullableContext(2)]
	// RVA: 0x1648010 Offset: 0x1646610 VA: 0x181648010
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x1643180 Offset: 0x1641780 VA: 0x181643180
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x1641FE0 Offset: 0x16405E0 VA: 0x181641FE0
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	// RVA: 0x16426D0 Offset: 0x1640CD0 VA: 0x1816426D0
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0x1647AE0 Offset: 0x16460E0 VA: 0x181647AE0
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0x1642800 Offset: 0x1640E00 VA: 0x181642800
	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 8410
{
	// Fields
	[Nullable(2)]
	private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
	[Nullable(2)]
	private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
	private readonly JsonSerializer _serializer; // 0xF0

	// Properties
	[Nullable(2)]
	public override IReferenceResolver ReferenceResolver { get; set; }
	[Nullable(2)]
	public override ITraceWriter TraceWriter { get; set; }
	[Nullable(2)]
	public override IEqualityComparer EqualityComparer { get; set; }
	public override JsonConverterCollection Converters { get; }
	public override DefaultValueHandling DefaultValueHandling { get; set; }
	public override IContractResolver ContractResolver { get; set; }
	public override MissingMemberHandling MissingMemberHandling { get; set; }
	public override NullValueHandling NullValueHandling { get; set; }
	public override ObjectCreationHandling ObjectCreationHandling { get; set; }
	public override ReferenceLoopHandling ReferenceLoopHandling { get; set; }
	public override PreserveReferencesHandling PreserveReferencesHandling { get; set; }
	public override TypeNameHandling TypeNameHandling { get; set; }
	public override MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public override FormatterAssemblyStyle TypeNameAssemblyFormat { get; set; }
	public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; set; }
	public override ConstructorHandling ConstructorHandling { get; set; }
	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public override SerializationBinder Binder { get; set; }
	public override ISerializationBinder SerializationBinder { get; set; }
	public override StreamingContext Context { get; set; }
	public override Formatting Formatting { get; set; }
	public override DateFormatHandling DateFormatHandling { get; set; }
	public override DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public override DateParseHandling DateParseHandling { get; set; }
	public override FloatFormatHandling FloatFormatHandling { get; set; }
	public override FloatParseHandling FloatParseHandling { get; set; }
	public override StringEscapeHandling StringEscapeHandling { get; set; }
	public override string DateFormatString { get; set; }
	public override CultureInfo Culture { get; set; }
	public override Nullable<int> MaxDepth { get; set; }
	public override bool CheckAdditionalContent { get; set; }

	// Methods

	// RVA: 0x16495E0 Offset: 0x1647BE0 VA: 0x1816495E0 Slot: 4
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x1649BD0 Offset: 0x16481D0 VA: 0x181649BD0 Slot: 5
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	// RVA: 0x1649A80 Offset: 0x1648080 VA: 0x181649A80 Slot: 6
	public override IReferenceResolver get_ReferenceResolver() { }

	[NullableContext(2)]
	// RVA: 0x164A030 Offset: 0x1648630 VA: 0x18164A030 Slot: 7
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	[NullableContext(2)]
	// RVA: 0x1649B10 Offset: 0x1648110 VA: 0x181649B10 Slot: 12
	public override ITraceWriter get_TraceWriter() { }

	[NullableContext(2)]
	// RVA: 0x164A0C0 Offset: 0x16486C0 VA: 0x18164A0C0 Slot: 13
	public override void set_TraceWriter(ITraceWriter value) { }

	[NullableContext(2)]
	// RVA: 0x1649870 Offset: 0x1647E70 VA: 0x181649870 Slot: 14
	public override IEqualityComparer get_EqualityComparer() { }

	[NullableContext(2)]
	// RVA: 0x1649E20 Offset: 0x1648420 VA: 0x181649E20 Slot: 15
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x1649720 Offset: 0x1647D20 VA: 0x181649720 Slot: 38
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0x1649840 Offset: 0x1647E40 VA: 0x181649840 Slot: 30
	public override DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0x1649DF0 Offset: 0x16483F0 VA: 0x181649DF0 Slot: 31
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x16496F0 Offset: 0x1647CF0 VA: 0x1816496F0 Slot: 39
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0x1649CD0 Offset: 0x16482D0 VA: 0x181649CD0 Slot: 40
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x1649990 Offset: 0x1647F90 VA: 0x181649990 Slot: 26
	public override MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x1649F40 Offset: 0x1648540 VA: 0x181649F40 Slot: 27
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x16499C0 Offset: 0x1647FC0 VA: 0x1816499C0 Slot: 28
	public override NullValueHandling get_NullValueHandling() { }

	// RVA: 0x1649F70 Offset: 0x1648570 VA: 0x181649F70 Slot: 29
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x16499F0 Offset: 0x1647FF0 VA: 0x1816499F0 Slot: 32
	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x1649FA0 Offset: 0x16485A0 VA: 0x181649FA0 Slot: 33
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x1649A50 Offset: 0x1648050 VA: 0x181649A50 Slot: 24
	public override ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x164A000 Offset: 0x1648600 VA: 0x18164A000 Slot: 25
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x1649A20 Offset: 0x1648020 VA: 0x181649A20 Slot: 22
	public override PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0x1649FD0 Offset: 0x16485D0 VA: 0x181649FD0 Slot: 23
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x1649BA0 Offset: 0x16481A0 VA: 0x181649BA0 Slot: 16
	public override TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x164A150 Offset: 0x1648750 VA: 0x18164A150 Slot: 17
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x1649960 Offset: 0x1647F60 VA: 0x181649960 Slot: 36
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x1649F10 Offset: 0x1648510 VA: 0x181649F10 Slot: 37
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x1649B70 Offset: 0x1648170 VA: 0x181649B70 Slot: 18
	public override FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	// RVA: 0x164A120 Offset: 0x1648720 VA: 0x18164A120 Slot: 19
	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x1649B40 Offset: 0x1648140 VA: 0x181649B40 Slot: 20
	public override TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0x164A0F0 Offset: 0x16486F0 VA: 0x18164A0F0 Slot: 21
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x1649670 Offset: 0x1647C70 VA: 0x181649670 Slot: 34
	public override ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0x1649C60 Offset: 0x1648260 VA: 0x181649C60 Slot: 35
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x1649610 Offset: 0x1647C10 VA: 0x181649610 Slot: 8
	public override SerializationBinder get_Binder() { }

	// RVA: 0x1649C00 Offset: 0x1648200 VA: 0x181649C00 Slot: 9
	public override void set_Binder(SerializationBinder value) { }

	// RVA: 0x1649AB0 Offset: 0x16480B0 VA: 0x181649AB0 Slot: 10
	public override ISerializationBinder get_SerializationBinder() { }

	// RVA: 0x164A060 Offset: 0x1648660 VA: 0x18164A060 Slot: 11
	public override void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0x16496A0 Offset: 0x1647CA0 VA: 0x1816496A0 Slot: 41
	public override StreamingContext get_Context() { }

	// RVA: 0x1649C90 Offset: 0x1648290 VA: 0x181649C90 Slot: 42
	public override void set_Context(StreamingContext value) { }

	// RVA: 0x1649900 Offset: 0x1647F00 VA: 0x181649900 Slot: 43
	public override Formatting get_Formatting() { }

	// RVA: 0x1649EB0 Offset: 0x16484B0 VA: 0x181649EB0 Slot: 44
	public override void set_Formatting(Formatting value) { }

	// RVA: 0x1649780 Offset: 0x1647D80 VA: 0x181649780 Slot: 45
	public override DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x1649D30 Offset: 0x1648330 VA: 0x181649D30 Slot: 46
	public override void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x1649810 Offset: 0x1647E10 VA: 0x181649810 Slot: 47
	public override DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x1649DC0 Offset: 0x16483C0 VA: 0x181649DC0 Slot: 48
	public override void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x16497E0 Offset: 0x1647DE0 VA: 0x1816497E0 Slot: 49
	public override DateParseHandling get_DateParseHandling() { }

	// RVA: 0x1649D90 Offset: 0x1648390 VA: 0x181649D90 Slot: 50
	public override void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x16498A0 Offset: 0x1647EA0 VA: 0x1816498A0 Slot: 53
	public override FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x1649E50 Offset: 0x1648450 VA: 0x181649E50 Slot: 54
	public override void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0x16498D0 Offset: 0x1647ED0 VA: 0x1816498D0 Slot: 51
	public override FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x1649E80 Offset: 0x1648480 VA: 0x181649E80 Slot: 52
	public override void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x1649AE0 Offset: 0x16480E0 VA: 0x181649AE0 Slot: 55
	public override StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x164A090 Offset: 0x1648690 VA: 0x18164A090 Slot: 56
	public override void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x16497B0 Offset: 0x1647DB0 VA: 0x1816497B0 Slot: 57
	public override string get_DateFormatString() { }

	// RVA: 0x1649D60 Offset: 0x1648360 VA: 0x181649D60 Slot: 58
	public override void set_DateFormatString(string value) { }

	// RVA: 0x1649750 Offset: 0x1647D50 VA: 0x181649750 Slot: 59
	public override CultureInfo get_Culture() { }

	// RVA: 0x1649D00 Offset: 0x1648300 VA: 0x181649D00 Slot: 60
	public override void set_Culture(CultureInfo value) { }

	// RVA: 0x1649930 Offset: 0x1647F30 VA: 0x181649930 Slot: 61
	public override Nullable<int> get_MaxDepth() { }

	// RVA: 0x1649EE0 Offset: 0x16484E0 VA: 0x181649EE0 Slot: 62
	public override void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x1649640 Offset: 0x1647C40 VA: 0x181649640 Slot: 63
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0x1649C30 Offset: 0x1648230 VA: 0x181649C30 Slot: 64
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x1649400 Offset: 0x1647A00 VA: 0x181649400
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0x1649550 Offset: 0x1647B50 VA: 0x181649550
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0x16494C0 Offset: 0x1647AC0 VA: 0x1816494C0
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	[NullableContext(2)]
	// RVA: 0x16493B0 Offset: 0x16479B0 VA: 0x1816493B0 Slot: 66
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0x1649420 Offset: 0x1647A20 VA: 0x181649420 Slot: 65
	internal override void PopulateInternal(JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x1649470 Offset: 0x1647A70 VA: 0x181649470 Slot: 67
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class JsonStringContract : JsonPrimitiveContract // TypeDefIndex: 8411
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x164A180 Offset: 0x1648780 VA: 0x18164A180
	public void .ctor(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal static class JsonTypeReflector // TypeDefIndex: 8414
{
	// Fields
	private static Nullable<bool> _dynamicCodeGeneration; // 0x0
	private static Nullable<bool> _fullyTrusted; // 0x2
	public const string IdPropertyName = "$id";
	public const string RefPropertyName = "$ref";
	public const string TypePropertyName = "$type";
	public const string ValuePropertyName = "$value";
	public const string ArrayValuesPropertyName = "$values";
	public const string ShouldSerializePrefix = "ShouldSerialize";
	public const string SpecifiedPostfix = "Specified";
	public const string ConcurrentDictionaryTypeName = "System.Collections.Concurrent.ConcurrentDictionary`2";
	[Nullable(new[] { 1, 1, 1, 2, 1, 1 })]
	private static readonly ThreadSafeStore<Type, Func<object[], object>> CreatorCache; // 0x8
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; // 0x10
	[Nullable(2)]
	private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

	// Properties
	public static bool DynamicCodeGeneration { get; }
	public static bool FullyTrusted { get; }
	public static ReflectionDelegateFactory ReflectionDelegateFactory { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T GetCachedAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7139A0 Offset: 0x711FA0 VA: 0x1807139A0
	|-JsonTypeReflector.GetCachedAttribute<object>
	*/

	// RVA: 0x164A1F0 Offset: 0x16487F0 VA: 0x18164A1F0
	public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter) { }

	// RVA: 0x164ABF0 Offset: 0x16491F0 VA: 0x18164ABF0
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0x164ACA0 Offset: 0x16492A0 VA: 0x18164ACA0
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0x164B050 Offset: 0x1649650 VA: 0x18164B050
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0x164AF30 Offset: 0x1649530 VA: 0x18164AF30
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0x164A3E0 Offset: 0x16489E0 VA: 0x18164A3E0
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] args) { }

	// RVA: 0x164A4E0 Offset: 0x1648AE0 VA: 0x18164A4E0
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] args) { }

	// RVA: 0x164A8E0 Offset: 0x1648EE0 VA: 0x18164A8E0
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	// RVA: 0x164AA80 Offset: 0x1649080 VA: 0x18164AA80
	private static Func<object[], object> GetCreator(Type type) { }

	// RVA: 0x164A860 Offset: 0x1648E60 VA: 0x18164A860
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0x164A5E0 Offset: 0x1648BE0 VA: 0x18164A5E0
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x713820 Offset: 0x711E20 VA: 0x180713820
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x713210 Offset: 0x711810 VA: 0x180713210
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: 0x164B220 Offset: 0x1649820 VA: 0x18164B220
	public static bool IsNonSerializable(object provider) { }

	// RVA: 0x164B290 Offset: 0x1649890 VA: 0x18164B290
	public static bool IsSerializable(object provider) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x713490 Offset: 0x711A90 VA: 0x180713490
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: 0x164B470 Offset: 0x1649A70 VA: 0x18164B470
	public static bool get_DynamicCodeGeneration() { }

	// RVA: 0x164B560 Offset: 0x1649B60 VA: 0x18164B560
	public static bool get_FullyTrusted() { }

	// RVA: 0x164B680 Offset: 0x1649C80 VA: 0x18164B680
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0x164B300 Offset: 0x1649900 VA: 0x18164B300
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
public class KebabCaseNamingStrategy : NamingStrategy // TypeDefIndex: 8415
{
	// Methods

	// RVA: 0x164B770 Offset: 0x1649D70 VA: 0x18164B770
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0x164B720 Offset: 0x1649D20 VA: 0x18164B720
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x164B710 Offset: 0x1649D10 VA: 0x18164B710 Slot: 7
	protected override string ResolvePropertyName(string name) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 8416
{
	// Fields
	private readonly Queue<string> _traceMessages; // 0x10
	private readonly object _lock; // 0x18
	[CompilerGenerated]
	private TraceLevel <LevelFilter>k__BackingField; // 0x20

	// Properties
	public TraceLevel LevelFilter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 4
	public TraceLevel get_LevelFilter() { }

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_LevelFilter(TraceLevel value) { }

	// RVA: 0x164BC90 Offset: 0x164A290 VA: 0x18164BC90
	public void .ctor() { }

	// RVA: 0x164BA00 Offset: 0x164A000 VA: 0x18164BA00 Slot: 5
	public void Trace(TraceLevel level, string message, Exception ex) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public IEnumerable<string> GetTraceMessages() { }

	// RVA: 0x164B7B0 Offset: 0x1649DB0 VA: 0x18164B7B0 Slot: 3
	public override string ToString() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public abstract class NamingStrategy // TypeDefIndex: 8417
{
	// Fields
	[CompilerGenerated]
	private bool <ProcessDictionaryKeys>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ProcessExtensionDataNames>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <OverrideSpecifiedNames>k__BackingField; // 0x12

	// Properties
	public bool ProcessDictionaryKeys { get; set; }
	public bool ProcessExtensionDataNames { get; set; }
	public bool OverrideSpecifiedNames { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_ProcessDictionaryKeys() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_ProcessDictionaryKeys(bool value) { }

	[CompilerGenerated]
	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_ProcessExtensionDataNames() { }

	[CompilerGenerated]
	// RVA: 0x14B8CA0 Offset: 0x14B72A0 VA: 0x1814B8CA0
	public void set_ProcessExtensionDataNames(bool value) { }

	[CompilerGenerated]
	// RVA: 0xA6C5D0 Offset: 0xA6ABD0 VA: 0x180A6C5D0
	public bool get_OverrideSpecifiedNames() { }

	[CompilerGenerated]
	// RVA: 0xB69DA0 Offset: 0xB683A0 VA: 0x180B69DA0
	public void set_OverrideSpecifiedNames(bool value) { }

	// RVA: 0x164BFF0 Offset: 0x164A5F0 VA: 0x18164BFF0 Slot: 4
	public virtual string GetPropertyName(string name, bool hasSpecifiedName) { }

	// RVA: 0x164BF00 Offset: 0x164A500 VA: 0x18164BF00 Slot: 5
	public virtual string GetExtensionDataName(string name) { }

	// RVA: 0x164BEE0 Offset: 0x164A4E0 VA: 0x18164BEE0 Slot: 6
	public virtual string GetDictionaryKey(string key) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract string ResolvePropertyName(string name);

	// RVA: 0x164BF20 Offset: 0x164A520 VA: 0x18164BF20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x164BDF0 Offset: 0x164A3F0 VA: 0x18164BDF0 Slot: 0
	public override bool Equals(object obj) { }

	[NullableContext(2)]
	// RVA: 0x164BD50 Offset: 0x164A350 VA: 0x18164BD50
	protected bool Equals(NamingStrategy other) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ObjectConstructor<T> : MulticastDelegate // TypeDefIndex: 8418
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD30EE0 Offset: 0xD2F4E0 VA: 0x180D30EE0
	|-ObjectConstructor<object>..ctor
	|-ObjectConstructor<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 13
	public virtual object Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D7950 Offset: 0x5D5F50 VA: 0x1805D7950
	|-ObjectConstructor<object>.Invoke
	|-ObjectConstructor<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(object[] args, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346290 Offset: 0x344890 VA: 0x180346290
	|-ObjectConstructor<object>.BeginInvoke
	|-ObjectConstructor<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0
	|-ObjectConstructor<object>.EndInvoke
	|-ObjectConstructor<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Newtonsoft.Json.Serialization
[Usage(64, Inherited = False)]
public sealed class OnErrorAttribute : Attribute // TypeDefIndex: 8419
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ReflectionAttributeProvider : IAttributeProvider // TypeDefIndex: 8420
{
	// Fields
	private readonly object _attributeProvider; // 0x10

	// Methods

	// RVA: 0x164C0F0 Offset: 0x164A6F0 VA: 0x18164C0F0
	public void .ctor(object attributeProvider) { }

	// RVA: 0x164C090 Offset: 0x164A690 VA: 0x18164C090 Slot: 4
	public IList<Attribute> GetAttributes(bool inherit) { }

	// RVA: 0x164C020 Offset: 0x164A620 VA: 0x18164C020 Slot: 5
	public IList<Attribute> GetAttributes(Type attributeType, bool inherit) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ReflectionValueProvider : IValueProvider // TypeDefIndex: 8421
{
	// Fields
	private readonly MemberInfo _memberInfo; // 0x10

	// Methods

	// RVA: 0x164C4F0 Offset: 0x164AAF0 VA: 0x18164C4F0
	public void .ctor(MemberInfo memberInfo) { }

	// RVA: 0x164C3A0 Offset: 0x164A9A0 VA: 0x18164C3A0 Slot: 4
	public void SetValue(object target, object value) { }

	// RVA: 0x164C160 Offset: 0x164A760 VA: 0x18164C160 Slot: 5
	public object GetValue(object target) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class SerializationBinderAdapter : ISerializationBinder // TypeDefIndex: 8422
{
	// Fields
	public readonly SerializationBinder SerializationBinder; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(SerializationBinder serializationBinder) { }

	// RVA: 0x164C590 Offset: 0x164AB90 VA: 0x18164C590 Slot: 4
	public Type BindToType(string assemblyName, string typeName) { }

	[NullableContext(2)]
	// RVA: 0x164C560 Offset: 0x164AB60 VA: 0x18164C560 Slot: 5
	public void BindToName(Type serializedType, out string assemblyName, out string typeName) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class SnakeCaseNamingStrategy : NamingStrategy // TypeDefIndex: 8423
{
	// Methods

	// RVA: 0x164B770 Offset: 0x1649D70 VA: 0x18164B770
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0x164B720 Offset: 0x1649D20 VA: 0x18164B720
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x164C5C0 Offset: 0x164ABC0 VA: 0x18164C5C0 Slot: 7
	protected override string ResolvePropertyName(string name) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 8424
{
	// Fields
	private readonly JsonReader _innerReader; // 0x78
	private readonly JsonTextWriter _textWriter; // 0x80
	private readonly StringWriter _sw; // 0x88

	// Properties
	public override int Depth { get; }
	public override string Path { get; }
	public override char QuoteChar { get; set; }
	public override JsonToken TokenType { get; }
	[Nullable(2)]
	public override object Value { get; }
	[Nullable(2)]
	public override Type ValueType { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x164CC40 Offset: 0x164B240 VA: 0x18164CC40
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0x164C600 Offset: 0x164AC00 VA: 0x18164C600
	public string GetDeserializedJsonMessage() { }

	// RVA: 0x164CB70 Offset: 0x164B170 VA: 0x18164CB70 Slot: 21
	public override bool Read() { }

	// RVA: 0x164CA70 Offset: 0x164B070 VA: 0x18164CA70 Slot: 22
	public override Nullable<int> ReadAsInt32() { }

	[NullableContext(2)]
	// RVA: 0x164CAF0 Offset: 0x164B0F0 VA: 0x18164CAF0 Slot: 23
	public override string ReadAsString() { }

	[NullableContext(2)]
	// RVA: 0x164C7D0 Offset: 0x164ADD0 VA: 0x18164C7D0 Slot: 24
	public override byte[] ReadAsBytes() { }

	// RVA: 0x164C960 Offset: 0x164AF60 VA: 0x18164C960 Slot: 27
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x164C9F0 Offset: 0x164AFF0 VA: 0x18164C9F0 Slot: 25
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x164C750 Offset: 0x164AD50 VA: 0x18164C750 Slot: 26
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x164C8E0 Offset: 0x164AEE0 VA: 0x18164C8E0 Slot: 28
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x164C850 Offset: 0x164AE50 VA: 0x18164C850 Slot: 29
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x164CBF0 Offset: 0x164B1F0 VA: 0x18164CBF0
	public void WriteCurrentToken() { }

	// RVA: 0x15E3E80 Offset: 0x15E2480 VA: 0x1815E3E80 Slot: 19
	public override int get_Depth() { }

	// RVA: 0x15E3EB0 Offset: 0x15E24B0 VA: 0x1815E3EB0 Slot: 20
	public override string get_Path() { }

	// RVA: 0x15E3EE0 Offset: 0x15E24E0 VA: 0x1815E3EE0 Slot: 14
	public override char get_QuoteChar() { }

	// RVA: 0x164CDB0 Offset: 0x164B3B0 VA: 0x18164CDB0 Slot: 15
	protected internal override void set_QuoteChar(char value) { }

	// RVA: 0x15E3F10 Offset: 0x15E2510 VA: 0x1815E3F10 Slot: 16
	public override JsonToken get_TokenType() { }

	[NullableContext(2)]
	// RVA: 0x15E3F70 Offset: 0x15E2570 VA: 0x1815E3F70 Slot: 17
	public override object get_Value() { }

	[NullableContext(2)]
	// RVA: 0x15E3F40 Offset: 0x15E2540 VA: 0x1815E3F40 Slot: 18
	public override Type get_ValueType() { }

	// RVA: 0x164C5D0 Offset: 0x164ABD0 VA: 0x18164C5D0 Slot: 31
	public override void Close() { }

	// RVA: 0x164C630 Offset: 0x164AC30 VA: 0x18164C630 Slot: 32
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x164C690 Offset: 0x164AC90 VA: 0x18164C690 Slot: 33
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x164C6F0 Offset: 0x164ACF0 VA: 0x18164C6F0 Slot: 34
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 8425
{
	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0x164EB00 Offset: 0x164D100 VA: 0x18164EB00
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0x164CE80 Offset: 0x164B480 VA: 0x18164CE80
	public string GetSerializedJsonMessage() { }

	// RVA: 0x164D7A0 Offset: 0x164BDA0 VA: 0x18164D7A0 Slot: 99
	public override void WriteValue(Decimal value) { }

	// RVA: 0x164DA60 Offset: 0x164C060 VA: 0x18164DA60 Slot: 116
	public override void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0x164D9F0 Offset: 0x164BFF0 VA: 0x18164D9F0 Slot: 93
	public override void WriteValue(bool value) { }

	// RVA: 0x164DC90 Offset: 0x164C290 VA: 0x18164DC90 Slot: 110
	public override void WriteValue(Nullable<bool> value) { }

	// RVA: 0x164D4B0 Offset: 0x164BAB0 VA: 0x18164D4B0 Slot: 97
	public override void WriteValue(byte value) { }

	// RVA: 0x164E000 Offset: 0x164C600 VA: 0x18164E000 Slot: 114
	public override void WriteValue(Nullable<byte> value) { }

	// RVA: 0x164DC20 Offset: 0x164C220 VA: 0x18164DC20 Slot: 96
	public override void WriteValue(char value) { }

	// RVA: 0x164E0B0 Offset: 0x164C6B0 VA: 0x18164E0B0 Slot: 113
	public override void WriteValue(Nullable<char> value) { }

	[NullableContext(2)]
	// RVA: 0x164E8F0 Offset: 0x164CEF0 VA: 0x18164E8F0 Slot: 121
	public override void WriteValue(byte[] value) { }

	// RVA: 0x164E6A0 Offset: 0x164CCA0 VA: 0x18164E6A0 Slot: 100
	public override void WriteValue(DateTime value) { }

	// RVA: 0x164D520 Offset: 0x164BB20 VA: 0x18164D520 Slot: 117
	public override void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0x164D830 Offset: 0x164BE30 VA: 0x18164D830 Slot: 101
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x164DB40 Offset: 0x164C140 VA: 0x18164DB40 Slot: 118
	public override void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0x164D8C0 Offset: 0x164BEC0 VA: 0x18164D8C0 Slot: 92
	public override void WriteValue(double value) { }

	// RVA: 0x164DE60 Offset: 0x164C460 VA: 0x18164DE60 Slot: 109
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0x164D340 Offset: 0x164B940 VA: 0x18164D340 Slot: 83
	public override void WriteUndefined() { }

	// RVA: 0x164D010 Offset: 0x164B610 VA: 0x18164D010 Slot: 82
	public override void WriteNull() { }

	// RVA: 0x164E370 Offset: 0x164C970 VA: 0x18164E370 Slot: 91
	public override void WriteValue(float value) { }

	// RVA: 0x164E7D0 Offset: 0x164CDD0 VA: 0x18164E7D0 Slot: 108
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0x164E220 Offset: 0x164C820 VA: 0x18164E220 Slot: 102
	public override void WriteValue(Guid value) { }

	// RVA: 0x164E3E0 Offset: 0x164C9E0 VA: 0x18164E3E0 Slot: 119
	public override void WriteValue(Nullable<Guid> value) { }

	// RVA: 0x164D740 Offset: 0x164BD40 VA: 0x18164D740 Slot: 87
	public override void WriteValue(int value) { }

	// RVA: 0x164D390 Offset: 0x164B990 VA: 0x18164D390 Slot: 104
	public override void WriteValue(Nullable<int> value) { }

	// RVA: 0x164E520 Offset: 0x164CB20 VA: 0x18164E520 Slot: 89
	public override void WriteValue(long value) { }

	// RVA: 0x164D930 Offset: 0x164BF30 VA: 0x18164D930 Slot: 106
	public override void WriteValue(Nullable<long> value) { }

	[NullableContext(2)]
	// RVA: 0x164E590 Offset: 0x164CB90 VA: 0x18164E590 Slot: 123
	public override void WriteValue(object value) { }

	// RVA: 0x164D440 Offset: 0x164BA40 VA: 0x18164D440 Slot: 98
	public override void WriteValue(sbyte value) { }

	// RVA: 0x164D5E0 Offset: 0x164BBE0 VA: 0x18164D5E0 Slot: 115
	public override void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0x164E970 Offset: 0x164CF70 VA: 0x18164E970 Slot: 94
	public override void WriteValue(short value) { }

	// RVA: 0x164D690 Offset: 0x164BC90 VA: 0x18164D690 Slot: 111
	public override void WriteValue(Nullable<short> value) { }

	[NullableContext(2)]
	// RVA: 0x164DDF0 Offset: 0x164C3F0 VA: 0x18164DDF0 Slot: 86
	public override void WriteValue(string value) { }

	// RVA: 0x164DF20 Offset: 0x164C520 VA: 0x18164DF20 Slot: 103
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x164E160 Offset: 0x164C760 VA: 0x18164E160 Slot: 120
	public override void WriteValue(Nullable<TimeSpan> value) { }

	// RVA: 0x164E4C0 Offset: 0x164CAC0 VA: 0x18164E4C0 Slot: 88
	public override void WriteValue(uint value) { }

	// RVA: 0x164E9E0 Offset: 0x164CFE0 VA: 0x18164E9E0 Slot: 105
	public override void WriteValue(Nullable<uint> value) { }

	// RVA: 0x164E880 Offset: 0x164CE80 VA: 0x18164E880 Slot: 90
	public override void WriteValue(ulong value) { }

	// RVA: 0x164E710 Offset: 0x164CD10 VA: 0x18164E710 Slot: 107
	public override void WriteValue(Nullable<ulong> value) { }

	[NullableContext(2)]
	// RVA: 0x164E2B0 Offset: 0x164C8B0 VA: 0x18164E2B0 Slot: 122
	public override void WriteValue(Uri value) { }

	// RVA: 0x164DF90 Offset: 0x164C590 VA: 0x18164DF90 Slot: 95
	public override void WriteValue(ushort value) { }

	// RVA: 0x164DD40 Offset: 0x164C340 VA: 0x18164DD40 Slot: 112
	public override void WriteValue(Nullable<ushort> value) { }

	// RVA: 0x164EA90 Offset: 0x164D090 VA: 0x18164EA90 Slot: 125
	public override void WriteWhitespace(string ws) { }

	[NullableContext(2)]
	// RVA: 0x164CEB0 Offset: 0x164B4B0 VA: 0x18164CEB0 Slot: 124
	public override void WriteComment(string text) { }

	// RVA: 0x164D230 Offset: 0x164B830 VA: 0x18164D230 Slot: 70
	public override void WriteStartArray() { }

	// RVA: 0x164CF20 Offset: 0x164B520 VA: 0x18164CF20 Slot: 71
	public override void WriteEndArray() { }

	// RVA: 0x164D280 Offset: 0x164B880 VA: 0x18164D280 Slot: 72
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x164CF70 Offset: 0x164B570 VA: 0x18164CF70 Slot: 73
	public override void WriteEndConstructor() { }

	// RVA: 0x164D060 Offset: 0x164B660 VA: 0x18164D060 Slot: 74
	public override void WritePropertyName(string name) { }

	// RVA: 0x164D0D0 Offset: 0x164B6D0 VA: 0x18164D0D0 Slot: 75
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x164D2F0 Offset: 0x164B8F0 VA: 0x18164D2F0 Slot: 68
	public override void WriteStartObject() { }

	// RVA: 0x164CFC0 Offset: 0x164B5C0 VA: 0x18164CFC0 Slot: 69
	public override void WriteEndObject() { }

	[NullableContext(2)]
	// RVA: 0x164D150 Offset: 0x164B750 VA: 0x18164D150 Slot: 85
	public override void WriteRawValue(string json) { }

	[NullableContext(2)]
	// RVA: 0x164D1C0 Offset: 0x164B7C0 VA: 0x18164D1C0 Slot: 84
	public override void WriteRaw(string json) { }

	// RVA: 0x164CDE0 Offset: 0x164B3E0 VA: 0x18164CDE0 Slot: 67
	public override void Close() { }

	// RVA: 0x164CE30 Offset: 0x164B430 VA: 0x18164CE30 Slot: 66
	public override void Flush() { }
}

