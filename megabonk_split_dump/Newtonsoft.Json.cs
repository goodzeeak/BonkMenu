// Namespace: Newtonsoft.Json
public enum ConstructorHandling // TypeDefIndex: 8122
{
	// Fields
	public int value__; // 0x0
	public const ConstructorHandling Default = 0;
	public const ConstructorHandling AllowNonPublicDefaultConstructor = 1;
}

// Namespace: Newtonsoft.Json
public enum DateFormatHandling // TypeDefIndex: 8123
{
	// Fields
	public int value__; // 0x0
	public const DateFormatHandling IsoDateFormat = 0;
	public const DateFormatHandling MicrosoftDateFormat = 1;
}

// Namespace: Newtonsoft.Json
public enum DateParseHandling // TypeDefIndex: 8124
{
	// Fields
	public int value__; // 0x0
	public const DateParseHandling None = 0;
	public const DateParseHandling DateTime = 1;
	public const DateParseHandling DateTimeOffset = 2;
}

// Namespace: Newtonsoft.Json
public enum DateTimeZoneHandling // TypeDefIndex: 8125
{
	// Fields
	public int value__; // 0x0
	public const DateTimeZoneHandling Local = 0;
	public const DateTimeZoneHandling Utc = 1;
	public const DateTimeZoneHandling Unspecified = 2;
	public const DateTimeZoneHandling RoundtripKind = 3;
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class DefaultJsonNameTable : JsonNameTable // TypeDefIndex: 8127
{
	// Fields
	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private DefaultJsonNameTable.Entry[] _entries; // 0x18
	private int _mask; // 0x20

	// Methods

	// RVA: 0x15A6F70 Offset: 0x15A5570 VA: 0x1815A6F70
	private static void .cctor() { }

	// RVA: 0x15A6FB0 Offset: 0x15A55B0 VA: 0x1815A6FB0
	public void .ctor() { }

	// RVA: 0x15A6BA0 Offset: 0x15A51A0 VA: 0x1815A6BA0 Slot: 4
	public override string Get(char[] key, int start, int length) { }

	// RVA: 0x15A69F0 Offset: 0x15A4FF0 VA: 0x1815A69F0
	public string Add(string key) { }

	// RVA: 0x15A6790 Offset: 0x15A4D90 VA: 0x1815A6790
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x15A6D80 Offset: 0x15A5380 VA: 0x1815A6D80
	private void Grow() { }

	// RVA: 0x15A6EE0 Offset: 0x15A54E0 VA: 0x1815A6EE0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}

// Namespace: Newtonsoft.Json
[Flags]
public enum DefaultValueHandling // TypeDefIndex: 8128
{
	// Fields
	public int value__; // 0x0
	public const DefaultValueHandling Include = 0;
	public const DefaultValueHandling Ignore = 1;
	public const DefaultValueHandling Populate = 2;
	public const DefaultValueHandling IgnoreAndPopulate = 3;
}

// Namespace: Newtonsoft.Json
public enum FloatFormatHandling // TypeDefIndex: 8129
{
	// Fields
	public int value__; // 0x0
	public const FloatFormatHandling String = 0;
	public const FloatFormatHandling Symbol = 1;
	public const FloatFormatHandling DefaultValue = 2;
}

// Namespace: Newtonsoft.Json
public enum FloatParseHandling // TypeDefIndex: 8130
{
	// Fields
	public int value__; // 0x0
	public const FloatParseHandling Double = 0;
	public const FloatParseHandling Decimal = 1;
}

// Namespace: Newtonsoft.Json
public enum Formatting // TypeDefIndex: 8131
{
	// Fields
	public int value__; // 0x0
	public const Formatting None = 0;
	public const Formatting Indented = 1;
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
public interface IArrayPool<T> // TypeDefIndex: 8132
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Return(T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<__Il2CppFullySharedGenericType>.Return
	*/
}

// Namespace: Newtonsoft.Json
public interface IJsonLineInfo // TypeDefIndex: 8133
{
	// Properties
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasLineInfo();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LinePosition();
}

// Namespace: Newtonsoft.Json
[Usage(1028, AllowMultiple = False)]
public sealed class JsonArrayAttribute : JsonContainerAttribute // TypeDefIndex: 8134
{
	// Fields
	private bool _allowNullItems; // 0x68

	// Properties
	public bool AllowNullItems { get; set; }

	// Methods

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	public bool get_AllowNullItems() { }

	// RVA: 0x528960 Offset: 0x526F60 VA: 0x180528960
	public void set_AllowNullItems(bool value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x15A7070 Offset: 0x15A5670 VA: 0x1815A7070
	public void .ctor(bool allowNullItems) { }

	[NullableContext(1)]
	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string id) { }
}

// Namespace: Newtonsoft.Json
[Usage(32, AllowMultiple = False)]
public sealed class JsonConstructorAttribute : Attribute // TypeDefIndex: 8135
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Nullable(0)]
[Usage(1028, AllowMultiple = False)]
public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 8136
{
	// Fields
	[CompilerGenerated]
	private string <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x20
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; // 0x28
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <ItemConverterParameters>k__BackingField; // 0x30
	[CompilerGenerated]
	private NamingStrategy <NamingStrategyInstance>k__BackingField; // 0x38
	internal Nullable<bool> _isReference; // 0x40
	internal Nullable<bool> _itemIsReference; // 0x42
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x44
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x4C
	private Type _namingStrategyType; // 0x58
	[Nullable(new[] { 2, 1 })]
	private object[] _namingStrategyParameters; // 0x60

	// Properties
	public string Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public Type ItemConverterType { get; set; }
	[Nullable(new[] { 2, 1 })]
	public object[] ItemConverterParameters { get; set; }
	public Type NamingStrategyType { get; set; }
	[Nullable(new[] { 2, 1 })]
	public object[] NamingStrategyParameters { get; set; }
	internal NamingStrategy NamingStrategyInstance { get; set; }
	public bool IsReference { get; set; }
	public bool ItemIsReference { get; set; }
	public ReferenceLoopHandling ItemReferenceLoopHandling { get; set; }
	public TypeNameHandling ItemTypeNameHandling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Id() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Id(string value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Title(string value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_ItemConverterType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_ItemConverterParameters(object[] value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public Type get_NamingStrategyType() { }

	// RVA: 0x15A7350 Offset: 0x15A5950 VA: 0x1815A7350
	public void set_NamingStrategyType(Type value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public object[] get_NamingStrategyParameters() { }

	// RVA: 0x15A7320 Offset: 0x15A5920 VA: 0x1815A7320
	public void set_NamingStrategyParameters(object[] value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal NamingStrategy get_NamingStrategyInstance() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	internal void set_NamingStrategyInstance(NamingStrategy value) { }

	// RVA: 0x15A70A0 Offset: 0x15A56A0 VA: 0x1815A70A0
	public bool get_IsReference() { }

	// RVA: 0x15A71A0 Offset: 0x15A57A0 VA: 0x1815A71A0
	public void set_IsReference(bool value) { }

	// RVA: 0x15A70E0 Offset: 0x15A56E0 VA: 0x1815A70E0
	public bool get_ItemIsReference() { }

	// RVA: 0x15A7200 Offset: 0x15A5800 VA: 0x1815A7200
	public void set_ItemIsReference(bool value) { }

	// RVA: 0x15A7120 Offset: 0x15A5720 VA: 0x1815A7120
	public ReferenceLoopHandling get_ItemReferenceLoopHandling() { }

	// RVA: 0x15A7260 Offset: 0x15A5860 VA: 0x1815A7260
	public void set_ItemReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x15A7160 Offset: 0x15A5760 VA: 0x1815A7160
	public TypeNameHandling get_ItemTypeNameHandling() { }

	// RVA: 0x15A72C0 Offset: 0x15A58C0 VA: 0x1815A72C0
	public void set_ItemTypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	protected void .ctor(string id) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public static class JsonConvert // TypeDefIndex: 8137
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; // 0x0
	public static readonly string True; // 0x8
	public static readonly string False; // 0x10
	public static readonly string Null; // 0x18
	public static readonly string Undefined; // 0x20
	public static readonly string PositiveInfinity; // 0x28
	public static readonly string NegativeInfinity; // 0x30
	public static readonly string NaN; // 0x38

	// Properties
	[Nullable(new[] { 2, 1 })]
	public static Func<JsonSerializerSettings> DefaultSettings { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x15ABD10 Offset: 0x15AA310 VA: 0x1815ABD10
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[CompilerGenerated]
	// RVA: 0x15ABD60 Offset: 0x15AA360 VA: 0x1815ABD60
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	// RVA: 0x15AB7C0 Offset: 0x15A9DC0 VA: 0x1815AB7C0
	public static string ToString(DateTime value) { }

	// RVA: 0x15AAF90 Offset: 0x15A9590 VA: 0x1815AAF90
	public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling) { }

	// RVA: 0x15AB810 Offset: 0x15A9E10 VA: 0x1815AB810
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x15AABA0 Offset: 0x15A91A0 VA: 0x1815AABA0
	public static string ToString(DateTimeOffset value, DateFormatHandling format) { }

	// RVA: 0x15AAF00 Offset: 0x15A9500 VA: 0x1815AAF00
	public static string ToString(bool value) { }

	// RVA: 0x15A9770 Offset: 0x15A7D70 VA: 0x1815A9770
	public static string ToString(char value) { }

	// RVA: 0x15ABAC0 Offset: 0x15AA0C0 VA: 0x1815ABAC0
	public static string ToString(Enum value) { }

	// RVA: 0x15A97E0 Offset: 0x15A7DE0 VA: 0x1815A97E0
	public static string ToString(int value) { }

	// RVA: 0x15AB170 Offset: 0x15A9770 VA: 0x1815AB170
	public static string ToString(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x15AB1D0 Offset: 0x15A97D0 VA: 0x1815AB1D0
	public static string ToString(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x15AB230 Offset: 0x15A9830 VA: 0x1815AB230
	public static string ToString(uint value) { }

	// RVA: 0x15AB6A0 Offset: 0x15A9CA0 VA: 0x1815AB6A0
	public static string ToString(long value) { }

	// RVA: 0x15A9480 Offset: 0x15A7A80 VA: 0x1815A9480
	private static string ToStringInternal(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x15A9710 Offset: 0x15A7D10 VA: 0x1815A9710
	public static string ToString(ulong value) { }

	// RVA: 0x15AAE40 Offset: 0x15A9440 VA: 0x1815AAE40
	public static string ToString(float value) { }

	// RVA: 0x15AB540 Offset: 0x15A9B40 VA: 0x1815AB540
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x15A81A0 Offset: 0x15A67A0 VA: 0x1815A81A0
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x15AB700 Offset: 0x15A9D00 VA: 0x1815AB700
	public static string ToString(double value) { }

	// RVA: 0x15AB930 Offset: 0x15A9F30 VA: 0x1815AB930
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x15A8060 Offset: 0x15A6660 VA: 0x1815A8060
	private static string EnsureDecimalPlace(double value, string text) { }

	// RVA: 0x15A8130 Offset: 0x15A6730 VA: 0x1815A8130
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0x15AAB40 Offset: 0x15A9140 VA: 0x1815AAB40
	public static string ToString(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x15AB640 Offset: 0x15A9C40 VA: 0x1815AB640
	public static string ToString(sbyte value) { }

	// RVA: 0x15A9510 Offset: 0x15A7B10 VA: 0x1815A9510
	public static string ToString(Decimal value) { }

	// RVA: 0x15A9610 Offset: 0x15A7C10 VA: 0x1815A9610
	public static string ToString(Guid value) { }

	// RVA: 0x15AB870 Offset: 0x15A9E70 VA: 0x1815AB870
	internal static string ToString(Guid value, char quoteChar) { }

	// RVA: 0x15AB410 Offset: 0x15A9A10 VA: 0x1815AB410
	public static string ToString(TimeSpan value) { }

	// RVA: 0x15ABA30 Offset: 0x15AA030 VA: 0x1815ABA30
	internal static string ToString(TimeSpan value, char quoteChar) { }

	// RVA: 0x15AB290 Offset: 0x15A9890 VA: 0x1815AB290
	public static string ToString(Uri value) { }

	// RVA: 0x15AAAC0 Offset: 0x15A90C0 VA: 0x1815AAAC0
	internal static string ToString(Uri value, char quoteChar) { }

	// RVA: 0x15AAD80 Offset: 0x15A9380 VA: 0x1815AAD80
	public static string ToString(string value) { }

	// RVA: 0x15AA9C0 Offset: 0x15A8FC0 VA: 0x1815AA9C0
	public static string ToString(string value, char delimiter) { }

	// RVA: 0x15AA8E0 Offset: 0x15A8EE0 VA: 0x1815AA8E0
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x15A9840 Offset: 0x15A7E40 VA: 0x1815A9840
	public static string ToString(object value) { }

	[DebuggerStepThrough]
	// RVA: 0x15A8900 Offset: 0x15A6F00 VA: 0x1815A8900
	public static string SerializeObject(object value) { }

	[DebuggerStepThrough]
	// RVA: 0x15A89A0 Offset: 0x15A6FA0 VA: 0x1815A89A0
	public static string SerializeObject(object value, Formatting formatting) { }

	[DebuggerStepThrough]
	// RVA: 0x15A87F0 Offset: 0x15A6DF0 VA: 0x1815A87F0
	public static string SerializeObject(object value, JsonConverter[] converters) { }

	[DebuggerStepThrough]
	// RVA: 0x15A8B20 Offset: 0x15A7120 VA: 0x1815A8B20
	public static string SerializeObject(object value, Formatting formatting, JsonConverter[] converters) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x15A8CC0 Offset: 0x15A72C0 VA: 0x1815A8CC0
	public static string SerializeObject(object value, JsonSerializerSettings settings) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x15A8760 Offset: 0x15A6D60 VA: 0x1815A8760
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x15A8AA0 Offset: 0x15A70A0 VA: 0x1815A8AA0
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x15A8C00 Offset: 0x15A7200 VA: 0x1815A8C00
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	// RVA: 0x15A8550 Offset: 0x15A6B50 VA: 0x1815A8550
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	[DebuggerStepThrough]
	// RVA: 0x15A7670 Offset: 0x15A5C70 VA: 0x1815A7670
	public static object DeserializeObject(string value) { }

	[DebuggerStepThrough]
	// RVA: 0x15A7450 Offset: 0x15A5A50 VA: 0x1815A7450
	public static object DeserializeObject(string value, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x15A76C0 Offset: 0x15A5CC0 VA: 0x1815A76C0
	public static object DeserializeObject(string value, Type type) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7111F0 Offset: 0x70F7F0 VA: 0x1807111F0
	|-JsonConvert.DeserializeObject<object>
	|
	|-RVA: 0x7110A0 Offset: 0x70F6A0 VA: 0x1807110A0
	|-JsonConvert.DeserializeObject<PlayerSaveData>
	|
	|-RVA: 0x710D60 Offset: 0x70F360 VA: 0x180710D60
	|-JsonConvert.DeserializeObject<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x710B50 Offset: 0x70F150 VA: 0x180710B50
	|-JsonConvert.DeserializeAnonymousType<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x710A60 Offset: 0x70F060 VA: 0x180710A60
	|-JsonConvert.DeserializeAnonymousType<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value, JsonConverter[] converters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x710C30 Offset: 0x70F230 VA: 0x180710C30
	|-JsonConvert.DeserializeObject<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x711310 Offset: 0x70F910 VA: 0x180711310
	|-JsonConvert.DeserializeObject<object>
	|
	|-RVA: 0x710F80 Offset: 0x70F580 VA: 0x180710F80
	|-JsonConvert.DeserializeObject<PlayerSaveData>
	|
	|-RVA: 0x710E50 Offset: 0x70F450 VA: 0x180710E50
	|-JsonConvert.DeserializeObject<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	// RVA: 0x15A7380 Offset: 0x15A5980 VA: 0x1815A7380
	public static object DeserializeObject(string value, Type type, JsonConverter[] converters) { }

	[NullableContext(2)]
	// RVA: 0x15A74B0 Offset: 0x15A5AB0 VA: 0x1815A74B0
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x15A84F0 Offset: 0x15A6AF0 VA: 0x1815A84F0
	public static void PopulateObject(string value, object target) { }

	// RVA: 0x15A82F0 Offset: 0x15A68F0 VA: 0x1815A82F0
	public static void PopulateObject(string value, object target, JsonSerializerSettings settings) { }

	// RVA: 0x15A9130 Offset: 0x15A7730 VA: 0x1815A9130
	public static string SerializeXmlNode(XmlNode node) { }

	// RVA: 0x15A9370 Offset: 0x15A7970 VA: 0x1815A9370
	public static string SerializeXmlNode(XmlNode node, Formatting formatting) { }

	// RVA: 0x15A9260 Offset: 0x15A7860 VA: 0x1815A9260
	public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject) { }

	// RVA: 0x15A7F80 Offset: 0x15A6580 VA: 0x1815A7F80
	public static XmlDocument DeserializeXmlNode(string value) { }

	[NullableContext(2)]
	// RVA: 0x15A8000 Offset: 0x15A6600 VA: 0x1815A8000
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName) { }

	[NullableContext(2)]
	// RVA: 0x15A7BC0 Offset: 0x15A61C0 VA: 0x1815A7BC0
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[NullableContext(2)]
	// RVA: 0x15A7DB0 Offset: 0x15A63B0 VA: 0x1815A7DB0
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	// RVA: 0x15A8D80 Offset: 0x15A7380 VA: 0x1815A8D80
	public static string SerializeXNode(XObject node) { }

	// RVA: 0x15A8FF0 Offset: 0x15A75F0 VA: 0x1815A8FF0
	public static string SerializeXNode(XObject node, Formatting formatting) { }

	// RVA: 0x15A8EE0 Offset: 0x15A74E0 VA: 0x1815A8EE0
	public static string SerializeXNode(XObject node, Formatting formatting, bool omitRootObject) { }

	// RVA: 0x15A7B40 Offset: 0x15A6140 VA: 0x1815A7B40
	public static XDocument DeserializeXNode(string value) { }

	[NullableContext(2)]
	// RVA: 0x15A7910 Offset: 0x15A5F10 VA: 0x1815A7910
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName) { }

	[NullableContext(2)]
	// RVA: 0x15A7720 Offset: 0x15A5D20 VA: 0x1815A7720
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[NullableContext(2)]
	// RVA: 0x15A7970 Offset: 0x15A5F70 VA: 0x1815A7970
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	// RVA: 0x15ABB10 Offset: 0x15AA110 VA: 0x1815ABB10
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public abstract class JsonConverter // TypeDefIndex: 8138
{
	// Properties
	public virtual bool CanRead { get; }
	public virtual bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool CanConvert(Type objectType);

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 7
	public virtual bool get_CanRead() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 8
	public virtual bool get_CanWrite() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public abstract class JsonConverter<T> : JsonConverter // TypeDefIndex: 8139
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public sealed override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CB120 Offset: 0x10C9720 VA: 0x1810CB120
	|-JsonConverter<__Il2CppFullySharedGenericType>.WriteJson
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteJson(JsonWriter writer, T value, JsonSerializer serializer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-JsonConverter<__Il2CppFullySharedGenericType>.WriteJson
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public sealed override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CAE70 Offset: 0x10C9470 VA: 0x1810CAE70
	|-JsonConverter<__Il2CppFullySharedGenericType>.ReadJson
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-JsonConverter<__Il2CppFullySharedGenericType>.ReadJson
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public sealed override bool CanConvert(Type objectType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10CAE00 Offset: 0x10C9400 VA: 0x1810CAE00
	|-JsonConverter<__Il2CppFullySharedGenericType>.CanConvert
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	|-JsonConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Usage(3484, AllowMultiple = False)]
public sealed class JsonConverterAttribute : Attribute // TypeDefIndex: 8140
{
	// Fields
	private readonly Type _converterType; // 0x10
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private readonly object[] <ConverterParameters>k__BackingField; // 0x18

	// Properties
	public Type ConverterType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] ConverterParameters { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_ConverterType() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public object[] get_ConverterParameters() { }

	// RVA: 0x15ABE90 Offset: 0x15AA490 VA: 0x1815ABE90
	public void .ctor(Type converterType) { }

	// RVA: 0x15ABDD0 Offset: 0x15AA3D0 VA: 0x1815ABDD0
	public void .ctor(Type converterType, object[] converterParameters) { }
}

// Namespace: Newtonsoft.Json
[Nullable(new[] { 0, 1 })]
public class JsonConverterCollection : Collection<JsonConverter> // TypeDefIndex: 8141
{
	// Methods

	// RVA: 0x15ABF30 Offset: 0x15AA530 VA: 0x1815ABF30
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
[Usage(1028, AllowMultiple = False)]
public sealed class JsonDictionaryAttribute : JsonContainerAttribute // TypeDefIndex: 8142
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string id) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class JsonException : Exception // TypeDefIndex: 8143
{
	// Methods

	// RVA: 0x15AC040 Offset: 0x15AA640 VA: 0x1815AC040
	public void .ctor() { }

	// RVA: 0x15AC090 Offset: 0x15AA690 VA: 0x1815AC090
	public void .ctor(string message) { }

	// RVA: 0x15AC0F0 Offset: 0x15AA6F0 VA: 0x1815AC0F0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15AC160 Offset: 0x15AA760 VA: 0x1815AC160
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15ABF70 Offset: 0x15AA570 VA: 0x1815ABF70
	internal static JsonException Create(IJsonLineInfo lineInfo, string path, string message) { }
}

// Namespace: Newtonsoft.Json
[Usage(384, AllowMultiple = False)]
public class JsonExtensionDataAttribute : Attribute // TypeDefIndex: 8144
{
	// Fields
	[CompilerGenerated]
	private bool <WriteData>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ReadData>k__BackingField; // 0x11

	// Properties
	public bool WriteData { get; set; }
	public bool ReadData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_WriteData() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_WriteData(bool value) { }

	[CompilerGenerated]
	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_ReadData() { }

	[CompilerGenerated]
	// RVA: 0x14B8CA0 Offset: 0x14B72A0 VA: 0x1814B8CA0
	public void set_ReadData(bool value) { }

	// RVA: 0x15AC1E0 Offset: 0x15AA7E0 VA: 0x1815AC1E0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
[Usage(384, AllowMultiple = False)]
public sealed class JsonIgnoreAttribute : Attribute // TypeDefIndex: 8145
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
public abstract class JsonNameTable // TypeDefIndex: 8146
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract string Get(char[] key, int start, int length);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json
[Usage(1036, AllowMultiple = False)]
public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 8147
{
	// Fields
	private MemberSerialization _memberSerialization; // 0x68
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x6C
	internal Nullable<Required> _itemRequired; // 0x74
	internal Nullable<NullValueHandling> _itemNullValueHandling; // 0x7C

	// Properties
	public MemberSerialization MemberSerialization { get; set; }
	public MissingMemberHandling MissingMemberHandling { get; set; }
	public NullValueHandling ItemNullValueHandling { get; set; }
	public Required ItemRequired { get; set; }

	// Methods

	// RVA: 0xC9D690 Offset: 0xC9BC90 VA: 0x180C9D690
	public MemberSerialization get_MemberSerialization() { }

	// RVA: 0xC9D9F0 Offset: 0xC9BFF0 VA: 0x180C9D9F0
	public void set_MemberSerialization(MemberSerialization value) { }

	// RVA: 0x15AC2B0 Offset: 0x15AA8B0 VA: 0x1815AC2B0
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x15AC3B0 Offset: 0x15AA9B0 VA: 0x1815AC3B0
	public void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x15AC230 Offset: 0x15AA830 VA: 0x1815AC230
	public NullValueHandling get_ItemNullValueHandling() { }

	// RVA: 0x15AC2F0 Offset: 0x15AA8F0 VA: 0x1815AC2F0
	public void set_ItemNullValueHandling(NullValueHandling value) { }

	// RVA: 0x15AC270 Offset: 0x15AA870 VA: 0x1815AC270
	public Required get_ItemRequired() { }

	// RVA: 0x15AC350 Offset: 0x15AA950 VA: 0x1815AC350
	public void set_ItemRequired(Required value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x15AC200 Offset: 0x15AA800 VA: 0x1815AC200
	public void .ctor(MemberSerialization memberSerialization) { }

	[NullableContext(1)]
	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string id) { }
}

// Namespace: Newtonsoft.Json
internal enum JsonContainerType // TypeDefIndex: 8148
{
	// Fields
	public int value__; // 0x0
	public const JsonContainerType None = 0;
	public const JsonContainerType Object = 1;
	public const JsonContainerType Array = 2;
	public const JsonContainerType Constructor = 3;
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
internal struct JsonPosition // TypeDefIndex: 8149
{
	// Fields
	private static readonly char[] SpecialCharacters; // 0x0
	internal JsonContainerType Type; // 0x0
	internal int Position; // 0x4
	[Nullable(2)]
	internal string PropertyName; // 0x8
	internal bool HasIndex; // 0x10

	// Methods

	// RVA: 0x15ACDB0 Offset: 0x15AB3B0 VA: 0x1815ACDB0
	public void .ctor(JsonContainerType type) { }

	// RVA: 0x15AC840 Offset: 0x15AAE40 VA: 0x1815AC840
	internal int CalculateLength() { }

	[NullableContext(2)]
	// RVA: 0x15ACB10 Offset: 0x15AB110 VA: 0x1815ACB10
	internal void WriteTo(StringBuilder sb, ref StringWriter writer, ref char[] buffer) { }

	// RVA: 0x15ACB00 Offset: 0x15AB100 VA: 0x1815ACB00
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0x15AC410 Offset: 0x15AAA10 VA: 0x1815AC410
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	// RVA: 0x15AC8E0 Offset: 0x15AAEE0 VA: 0x1815AC8E0
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0x15ACD20 Offset: 0x15AB320 VA: 0x1815ACD20
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Nullable(0)]
[Usage(2432, AllowMultiple = False)]
public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 8150
{
	// Fields
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x10
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x18
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x20
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x28
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0x30
	internal Nullable<bool> _isReference; // 0x38
	internal Nullable<int> _order; // 0x3C
	internal Nullable<Required> _required; // 0x44
	internal Nullable<bool> _itemIsReference; // 0x4C
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x50
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x58
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; // 0x60
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <ItemConverterParameters>k__BackingField; // 0x68
	[CompilerGenerated]
	private Type <NamingStrategyType>k__BackingField; // 0x70
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <NamingStrategyParameters>k__BackingField; // 0x78
	[CompilerGenerated]
	private string <PropertyName>k__BackingField; // 0x80

	// Properties
	public Type ItemConverterType { get; set; }
	[Nullable(new[] { 2, 1 })]
	public object[] ItemConverterParameters { get; set; }
	public Type NamingStrategyType { get; set; }
	[Nullable(new[] { 2, 1 })]
	public object[] NamingStrategyParameters { get; set; }
	public NullValueHandling NullValueHandling { get; set; }
	public DefaultValueHandling DefaultValueHandling { get; set; }
	public ReferenceLoopHandling ReferenceLoopHandling { get; set; }
	public ObjectCreationHandling ObjectCreationHandling { get; set; }
	public TypeNameHandling TypeNameHandling { get; set; }
	public bool IsReference { get; set; }
	public int Order { get; set; }
	public Required Required { get; set; }
	public string PropertyName { get; set; }
	public ReferenceLoopHandling ItemReferenceLoopHandling { get; set; }
	public TypeNameHandling ItemTypeNameHandling { get; set; }
	public bool ItemIsReference { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_ItemConverterType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void set_ItemConverterParameters(object[] value) { }

	[CompilerGenerated]
	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public Type get_NamingStrategyType() { }

	[CompilerGenerated]
	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void set_NamingStrategyType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public object[] get_NamingStrategyParameters() { }

	[CompilerGenerated]
	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	public void set_NamingStrategyParameters(object[] value) { }

	// RVA: 0x15ACFB0 Offset: 0x15AB5B0 VA: 0x1815ACFB0
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0x15AD310 Offset: 0x15AB910 VA: 0x1815AD310
	public void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x15ACE70 Offset: 0x15AB470 VA: 0x1815ACE70
	public DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0x15AD130 Offset: 0x15AB730 VA: 0x1815AD130
	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x15AD070 Offset: 0x15AB670 VA: 0x1815AD070
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x15AD430 Offset: 0x15ABA30 VA: 0x1815AD430
	public void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x15ACFF0 Offset: 0x15AB5F0 VA: 0x1815ACFF0
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x15AD370 Offset: 0x15AB970 VA: 0x1815AD370
	public void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x15AD0F0 Offset: 0x15AB6F0 VA: 0x1815AD0F0
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x15AD4F0 Offset: 0x15ABAF0 VA: 0x1815AD4F0
	public void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x15ACEB0 Offset: 0x15AB4B0 VA: 0x1815ACEB0
	public bool get_IsReference() { }

	// RVA: 0x15AD190 Offset: 0x15AB790 VA: 0x1815AD190
	public void set_IsReference(bool value) { }

	// RVA: 0x15AD030 Offset: 0x15AB630 VA: 0x1815AD030
	public int get_Order() { }

	// RVA: 0x15AD3D0 Offset: 0x15AB9D0 VA: 0x1815AD3D0
	public void set_Order(int value) { }

	// RVA: 0x15AD0B0 Offset: 0x15AB6B0 VA: 0x1815AD0B0
	public Required get_Required() { }

	// RVA: 0x15AD490 Offset: 0x15ABA90 VA: 0x1815AD490
	public void set_Required(Required value) { }

	[CompilerGenerated]
	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public string get_PropertyName() { }

	[CompilerGenerated]
	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	public void set_PropertyName(string value) { }

	// RVA: 0x15ACF30 Offset: 0x15AB530 VA: 0x1815ACF30
	public ReferenceLoopHandling get_ItemReferenceLoopHandling() { }

	// RVA: 0x15AD250 Offset: 0x15AB850 VA: 0x1815AD250
	public void set_ItemReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x15ACF70 Offset: 0x15AB570 VA: 0x1815ACF70
	public TypeNameHandling get_ItemTypeNameHandling() { }

	// RVA: 0x15AD2B0 Offset: 0x15AB8B0 VA: 0x1815AD2B0
	public void set_ItemTypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x15ACEF0 Offset: 0x15AB4F0 VA: 0x1815ACEF0
	public bool get_ItemIsReference() { }

	// RVA: 0x15AD1F0 Offset: 0x15AB7F0 VA: 0x1815AD1F0
	public void set_ItemIsReference(bool value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x15ACE30 Offset: 0x15AB430 VA: 0x1815ACE30
	public void .ctor(string propertyName) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Nullable(0)]
public abstract class JsonReader : IDisposable // TypeDefIndex: 8157
{
	// Fields
	private JsonToken _tokenType; // 0x10
	private object _value; // 0x18
	internal char _quoteChar; // 0x20
	internal JsonReader.State _currentState; // 0x24
	private JsonPosition _currentPosition; // 0x28
	private CultureInfo _culture; // 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
	private Nullable<int> _maxDepth; // 0x4C
	private bool _hasExceededMaxDepth; // 0x54
	internal DateParseHandling _dateParseHandling; // 0x58
	internal FloatParseHandling _floatParseHandling; // 0x5C
	private string _dateFormatString; // 0x60
	private List<JsonPosition> _stack; // 0x68
	[CompilerGenerated]
	private bool <CloseInput>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <SupportMultipleContent>k__BackingField; // 0x71

	// Properties
	protected JsonReader.State CurrentState { get; }
	public bool CloseInput { get; set; }
	public bool SupportMultipleContent { get; set; }
	public virtual char QuoteChar { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public DateParseHandling DateParseHandling { get; set; }
	public FloatParseHandling FloatParseHandling { get; set; }
	public string DateFormatString { get; set; }
	public Nullable<int> MaxDepth { get; set; }
	public virtual JsonToken TokenType { get; }
	public virtual object Value { get; }
	public virtual Type ValueType { get; }
	public virtual int Depth { get; }
	[Nullable(1)]
	public virtual string Path { get; }
	[Nullable(1)]
	public CultureInfo Culture { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x15B0E00 Offset: 0x15AF400 VA: 0x1815B0E00 Slot: 5
	public virtual Task<bool> ReadAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	[AsyncStateMachine(typeof(JsonReader.<SkipAsync>d__1))]
	// RVA: 0x15B27C0 Offset: 0x15B0DC0 VA: 0x1815B27C0
	public Task SkipAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	[AsyncStateMachine(typeof(JsonReader.<ReaderReadAndAssertAsync>d__2))]
	// RVA: 0x15B2310 Offset: 0x15B0910 VA: 0x1815B2310
	internal Task ReaderReadAndAssertAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x15AE990 Offset: 0x15ACF90 VA: 0x1815AE990 Slot: 6
	public virtual Task<Nullable<bool>> ReadAsBooleanAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15AEE20 Offset: 0x15AD420 VA: 0x1815AEE20 Slot: 7
	public virtual Task<byte[]> ReadAsBytesAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonReader.<ReadArrayIntoByteArrayAsync>d__5))]
	// RVA: 0x15AE760 Offset: 0x15ACD60 VA: 0x1815AE760
	internal Task<byte[]> ReadArrayIntoByteArrayAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x15AF350 Offset: 0x15AD950 VA: 0x1815AF350 Slot: 8
	public virtual Task<Nullable<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x15AF430 Offset: 0x15ADA30 VA: 0x1815AF430 Slot: 9
	public virtual Task<Nullable<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x15AFB80 Offset: 0x15AE180 VA: 0x1815AFB80 Slot: 10
	public virtual Task<Nullable<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x15B0120 Offset: 0x15AE720 VA: 0x1815B0120 Slot: 11
	public virtual Task<Nullable<double>> ReadAsDoubleAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x15B0550 Offset: 0x15AEB50 VA: 0x1815B0550 Slot: 12
	public virtual Task<Nullable<int>> ReadAsInt32Async(CancellationToken cancellationToken) { }

	// RVA: 0x15B0A20 Offset: 0x15AF020 VA: 0x1815B0A20 Slot: 13
	public virtual Task<string> ReadAsStringAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	[AsyncStateMachine(typeof(JsonReader.<ReadAndMoveToContentAsync>d__12))]
	// RVA: 0x15AE390 Offset: 0x15AC990 VA: 0x1815AE390
	internal Task<bool> ReadAndMoveToContentAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	// RVA: 0x15ADBA0 Offset: 0x15AC1A0 VA: 0x1815ADBA0
	internal Task<bool> MoveToContentAsync(CancellationToken cancellationToken) { }

	[NullableContext(1)]
	[AsyncStateMachine(typeof(JsonReader.<MoveToContentFromNonContentAsync>d__14))]
	// RVA: 0x15ADD30 Offset: 0x15AC330 VA: 0x1815ADD30
	private Task<bool> MoveToContentFromNonContentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	protected JsonReader.State get_CurrentState() { }

	[CompilerGenerated]
	// RVA: 0xBCFCF0 Offset: 0xBCE2F0 VA: 0x180BCFCF0
	public bool get_CloseInput() { }

	[CompilerGenerated]
	// RVA: 0xBD0F40 Offset: 0xBCF540 VA: 0x180BD0F40
	public void set_CloseInput(bool value) { }

	[CompilerGenerated]
	// RVA: 0x15B2F70 Offset: 0x15B1570 VA: 0x1815B2F70
	public bool get_SupportMultipleContent() { }

	[CompilerGenerated]
	// RVA: 0x15B31C0 Offset: 0x15B17C0 VA: 0x1815B31C0
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0x15B2F60 Offset: 0x15B1560 VA: 0x1815B2F60 Slot: 14
	public virtual char get_QuoteChar() { }

	// RVA: 0x15B31B0 Offset: 0x15B17B0 VA: 0x1815B31B0 Slot: 15
	protected internal virtual void set_QuoteChar(char value) { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x15B3010 Offset: 0x15B1610 VA: 0x1815B3010
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0x15B2FA0 Offset: 0x15B15A0 VA: 0x1815B2FA0
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x15B2E40 Offset: 0x15B1440 VA: 0x1815B2E40
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x15B3080 Offset: 0x15B1680 VA: 0x1815B3080
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public string get_DateFormatString() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_DateFormatString(string value) { }

	// RVA: 0x15B2E50 Offset: 0x15B1450 VA: 0x1815B2E50
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0x15B30F0 Offset: 0x15B16F0 VA: 0x1815B30F0
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 16
	public virtual JsonToken get_TokenType() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 17
	public virtual object get_Value() { }

	// RVA: 0x15B2F80 Offset: 0x15B1580 VA: 0x1815B2F80 Slot: 18
	public virtual Type get_ValueType() { }

	// RVA: 0x15B2DC0 Offset: 0x15B13C0 VA: 0x1815B2DC0 Slot: 19
	public virtual int get_Depth() { }

	[NullableContext(1)]
	// RVA: 0x15B2E60 Offset: 0x15B1460 VA: 0x1815B2E60 Slot: 20
	public virtual string get_Path() { }

	[NullableContext(1)]
	// RVA: 0x15B2D60 Offset: 0x15B1360 VA: 0x1815B2D60
	public CultureInfo get_Culture() { }

	[NullableContext(1)]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x15ADA10 Offset: 0x15AC010 VA: 0x1815ADA10
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0x15B2CF0 Offset: 0x15B12F0 VA: 0x1815B2CF0
	protected void .ctor() { }

	// RVA: 0x15ADFE0 Offset: 0x15AC5E0 VA: 0x1815ADFE0
	private void Push(JsonContainerType value) { }

	// RVA: 0x15ADEB0 Offset: 0x15AC4B0 VA: 0x1815ADEB0
	private JsonContainerType Pop() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool Read();

	// RVA: 0x15B0620 Offset: 0x15AEC20 VA: 0x1815B0620 Slot: 22
	public virtual Nullable<int> ReadAsInt32() { }

	// RVA: 0x15B1E90 Offset: 0x15B0490 VA: 0x1815B1E90
	internal Nullable<int> ReadInt32String(string s) { }

	// RVA: 0x15B0AF0 Offset: 0x15AF0F0 VA: 0x1815B0AF0 Slot: 23
	public virtual string ReadAsString() { }

	// RVA: 0x15AEEF0 Offset: 0x15AD4F0 VA: 0x1815AEEF0 Slot: 24
	public virtual byte[] ReadAsBytes() { }

	[NullableContext(1)]
	// RVA: 0x15AE880 Offset: 0x15ACE80 VA: 0x1815AE880
	internal byte[] ReadArrayIntoByteArray() { }

	[NullableContext(1)]
	// RVA: 0x15AE510 Offset: 0x15ACB10 VA: 0x1815AE510
	private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer) { }

	// RVA: 0x15B01B0 Offset: 0x15AE7B0 VA: 0x1815B01B0 Slot: 25
	public virtual Nullable<double> ReadAsDouble() { }

	// RVA: 0x15B19B0 Offset: 0x15AFFB0 VA: 0x1815B19B0
	internal Nullable<double> ReadDoubleString(string s) { }

	// RVA: 0x15AEA60 Offset: 0x15AD060 VA: 0x1815AEA60 Slot: 26
	public virtual Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x15B0EB0 Offset: 0x15AF4B0 VA: 0x1815B0EB0
	internal Nullable<bool> ReadBooleanString(string s) { }

	// RVA: 0x15AFC70 Offset: 0x15AE270 VA: 0x1815AFC70 Slot: 27
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x15B1690 Offset: 0x15AFC90 VA: 0x1815B1690
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	// RVA: 0x15AF850 Offset: 0x15ADE50 VA: 0x1815AF850 Slot: 28
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x15B13B0 Offset: 0x15AF9B0 VA: 0x1815B13B0
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	// RVA: 0x15AF520 Offset: 0x15ADB20 VA: 0x1815AF520 Slot: 29
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x15B1060 Offset: 0x15AF660 VA: 0x1815B1060
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0x15B2400 Offset: 0x15B0A00 VA: 0x1815B2400
	internal void ReaderReadAndAssert() { }

	[NullableContext(1)]
	// RVA: 0x15AD930 Offset: 0x15ABF30 VA: 0x1815AD930
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0x15B2070 Offset: 0x15B0670 VA: 0x1815B2070
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0x15B28C0 Offset: 0x15B0EC0 VA: 0x1815B28C0
	public void Skip() { }

	// RVA: 0x15B27A0 Offset: 0x15B0DA0 VA: 0x1815B27A0
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0x15B2780 Offset: 0x15B0D80 VA: 0x1815B2780
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0x15B25B0 Offset: 0x15B0BB0 VA: 0x1815B25B0
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0x15B2470 Offset: 0x15B0A70 VA: 0x1815B2470
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0x15B29E0 Offset: 0x15B0FE0 VA: 0x1815B29E0
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0x15B29F0 Offset: 0x15B0FF0 VA: 0x1815B29F0
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0x15B24A0 Offset: 0x15B0AA0 VA: 0x1815B24A0
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0x15B2450 Offset: 0x15B0A50 VA: 0x1815B2450
	private void SetFinished() { }

	// RVA: 0x15ADAC0 Offset: 0x15AC0C0 VA: 0x1815ADAC0
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0x15B2980 Offset: 0x15B0F80 VA: 0x1815B2980 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x15AD970 Offset: 0x15ABF70 VA: 0x1815AD970 Slot: 30
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15AD910 Offset: 0x15ABF10 VA: 0x1815AD910 Slot: 31
	public virtual void Close() { }

	// RVA: 0x15AE330 Offset: 0x15AC930 VA: 0x1815AE330
	internal void ReadAndAssert() { }

	// RVA: 0x15B1B90 Offset: 0x15B0190 VA: 0x1815B1B90
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	// RVA: 0x15B1BE0 Offset: 0x15B01E0 VA: 0x1815B1BE0
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	// RVA: 0x15AE4B0 Offset: 0x15ACAB0 VA: 0x1815AE4B0
	internal bool ReadAndMoveToContent() { }

	// RVA: 0x15ADE50 Offset: 0x15AC450 VA: 0x1815ADE50
	internal bool MoveToContent() { }

	// RVA: 0x15AD9A0 Offset: 0x15ABFA0 VA: 0x1815AD9A0
	private JsonToken GetContentToken() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class JsonReaderException : JsonException // TypeDefIndex: 8158
{
	// Fields
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; // 0x94
	[Nullable(2)]
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x98

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	[Nullable(2)]
	public string Path { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	public int get_LineNumber() { }

	[CompilerGenerated]
	// RVA: 0x12ECA90 Offset: 0x12EB090 VA: 0x1812ECA90
	public int get_LinePosition() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public string get_Path() { }

	// RVA: 0x15AC040 Offset: 0x15AA640 VA: 0x1815AC040
	public void .ctor() { }

	// RVA: 0x15AC090 Offset: 0x15AA690 VA: 0x1815AC090
	public void .ctor(string message) { }

	// RVA: 0x15AC0F0 Offset: 0x15AA6F0 VA: 0x1815AC0F0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15AC160 Offset: 0x15AA760 VA: 0x1815AC160
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15AD870 Offset: 0x15ABE70 VA: 0x1815AD870
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0x15AD860 Offset: 0x15ABE60 VA: 0x1815AD860
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0x15AD6B0 Offset: 0x15ABCB0 VA: 0x1815AD6B0
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0x15AD550 Offset: 0x15ABB50 VA: 0x1815AD550
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }
}

// Namespace: Newtonsoft.Json
[Usage(384, AllowMultiple = False)]
public sealed class JsonRequiredAttribute : Attribute // TypeDefIndex: 8159
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class JsonSerializationException : JsonException // TypeDefIndex: 8160
{
	// Fields
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; // 0x94
	[Nullable(2)]
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x98

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	[Nullable(2)]
	public string Path { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	public int get_LineNumber() { }

	[CompilerGenerated]
	// RVA: 0x12ECA90 Offset: 0x12EB090 VA: 0x1812ECA90
	public int get_LinePosition() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public string get_Path() { }

	// RVA: 0x15AC040 Offset: 0x15AA640 VA: 0x1815AC040
	public void .ctor() { }

	// RVA: 0x15AC090 Offset: 0x15AA690 VA: 0x1815AC090
	public void .ctor(string message) { }

	// RVA: 0x15AC0F0 Offset: 0x15AA6F0 VA: 0x1815AC0F0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15AC160 Offset: 0x15AA760 VA: 0x1815AC160
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15AD870 Offset: 0x15ABE70 VA: 0x1815AD870
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0x15B31D0 Offset: 0x15B17D0 VA: 0x1815B31D0
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0x15B3380 Offset: 0x15B1980 VA: 0x1815B3380
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0x15B3530 Offset: 0x15B1B30 VA: 0x1815B3530
	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class JsonSerializer // TypeDefIndex: 8161
{
	// Fields
	internal TypeNameHandling _typeNameHandling; // 0x10
	internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; // 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
	internal MissingMemberHandling _missingMemberHandling; // 0x20
	internal ObjectCreationHandling _objectCreationHandling; // 0x24
	internal NullValueHandling _nullValueHandling; // 0x28
	internal DefaultValueHandling _defaultValueHandling; // 0x2C
	internal ConstructorHandling _constructorHandling; // 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
	[Nullable(2)]
	internal JsonConverterCollection _converters; // 0x38
	internal IContractResolver _contractResolver; // 0x40
	[Nullable(2)]
	internal ITraceWriter _traceWriter; // 0x48
	[Nullable(2)]
	internal IEqualityComparer _equalityComparer; // 0x50
	internal ISerializationBinder _serializationBinder; // 0x58
	internal StreamingContext _context; // 0x60
	[Nullable(2)]
	private IReferenceResolver _referenceResolver; // 0x70
	private Nullable<Formatting> _formatting; // 0x78
	private Nullable<DateFormatHandling> _dateFormatHandling; // 0x80
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x88
	private Nullable<DateParseHandling> _dateParseHandling; // 0x90
	private Nullable<FloatFormatHandling> _floatFormatHandling; // 0x98
	private Nullable<FloatParseHandling> _floatParseHandling; // 0xA0
	private Nullable<StringEscapeHandling> _stringEscapeHandling; // 0xA8
	private CultureInfo _culture; // 0xB0
	private Nullable<int> _maxDepth; // 0xB8
	private bool _maxDepthSet; // 0xC0
	private Nullable<bool> _checkAdditionalContent; // 0xC1
	[Nullable(2)]
	private string _dateFormatString; // 0xC8
	private bool _dateFormatStringSet; // 0xD0
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private EventHandler<ErrorEventArgs> Error; // 0xD8

	// Properties
	[Nullable(2)]
	public virtual IReferenceResolver ReferenceResolver { get; set; }
	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public virtual SerializationBinder Binder { get; set; }
	public virtual ISerializationBinder SerializationBinder { get; set; }
	[Nullable(2)]
	public virtual ITraceWriter TraceWriter { get; set; }
	[Nullable(2)]
	public virtual IEqualityComparer EqualityComparer { get; set; }
	public virtual TypeNameHandling TypeNameHandling { get; set; }
	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public virtual FormatterAssemblyStyle TypeNameAssemblyFormat { get; set; }
	public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; set; }
	public virtual PreserveReferencesHandling PreserveReferencesHandling { get; set; }
	public virtual ReferenceLoopHandling ReferenceLoopHandling { get; set; }
	public virtual MissingMemberHandling MissingMemberHandling { get; set; }
	public virtual NullValueHandling NullValueHandling { get; set; }
	public virtual DefaultValueHandling DefaultValueHandling { get; set; }
	public virtual ObjectCreationHandling ObjectCreationHandling { get; set; }
	public virtual ConstructorHandling ConstructorHandling { get; set; }
	public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public virtual JsonConverterCollection Converters { get; }
	public virtual IContractResolver ContractResolver { get; set; }
	public virtual StreamingContext Context { get; set; }
	public virtual Formatting Formatting { get; set; }
	public virtual DateFormatHandling DateFormatHandling { get; set; }
	public virtual DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public virtual DateParseHandling DateParseHandling { get; set; }
	public virtual FloatParseHandling FloatParseHandling { get; set; }
	public virtual FloatFormatHandling FloatFormatHandling { get; set; }
	public virtual StringEscapeHandling StringEscapeHandling { get; set; }
	public virtual string DateFormatString { get; set; }
	public virtual CultureInfo Culture { get; set; }
	public virtual Nullable<int> MaxDepth { get; set; }
	public virtual bool CheckAdditionalContent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x15B7240 Offset: 0x15B5840 VA: 0x1815B7240 Slot: 4
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x15B7780 Offset: 0x15B5D80 VA: 0x1815B7780 Slot: 5
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	// RVA: 0x15B5DC0 Offset: 0x15B43C0 VA: 0x1815B5DC0 Slot: 6
	public virtual IReferenceResolver get_ReferenceResolver() { }

	[NullableContext(2)]
	// RVA: 0x15B8120 Offset: 0x15B6720 VA: 0x1815B8120 Slot: 7
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0x15B7300 Offset: 0x15B5900 VA: 0x1815B7300 Slot: 8
	public virtual SerializationBinder get_Binder() { }

	// RVA: 0x15B7840 Offset: 0x15B5E40 VA: 0x1815B7840 Slot: 9
	public virtual void set_Binder(SerializationBinder value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 10
	public virtual ISerializationBinder get_SerializationBinder() { }

	// RVA: 0x15B81B0 Offset: 0x15B67B0 VA: 0x1815B81B0 Slot: 11
	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	[NullableContext(2)]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 12
	public virtual ITraceWriter get_TraceWriter() { }

	[NullableContext(2)]
	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810 Slot: 13
	public virtual void set_TraceWriter(ITraceWriter value) { }

	[NullableContext(2)]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 14
	public virtual IEqualityComparer get_EqualityComparer() { }

	[NullableContext(2)]
	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830 Slot: 15
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 16
	public virtual TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x15B8380 Offset: 0x15B6980 VA: 0x1815B8380 Slot: 17
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30 Slot: 18
	public virtual FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	// RVA: 0x15B8310 Offset: 0x15B6910 VA: 0x1815B8310 Slot: 19
	public virtual void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30 Slot: 20
	public virtual TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0x15B82A0 Offset: 0x15B68A0 VA: 0x1815B82A0 Slot: 21
	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 22
	public virtual PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0x15B8040 Offset: 0x15B6640 VA: 0x1815B8040 Slot: 23
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30 Slot: 24
	public virtual ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x15B80B0 Offset: 0x15B66B0 VA: 0x1815B80B0 Slot: 25
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 26
	public virtual MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x15B7EF0 Offset: 0x15B64F0 VA: 0x1815B7EF0 Slot: 27
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60 Slot: 28
	public virtual NullValueHandling get_NullValueHandling() { }

	// RVA: 0x15B7F60 Offset: 0x15B6560 VA: 0x1815B7F60 Slot: 29
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00 Slot: 30
	public virtual DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0x15B7C30 Offset: 0x15B6230 VA: 0x1815B7C30 Slot: 31
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160 Slot: 32
	public virtual ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x15B7FD0 Offset: 0x15B65D0 VA: 0x1815B7FD0 Slot: 33
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0 Slot: 34
	public virtual ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0x15B79A0 Offset: 0x15B5FA0 VA: 0x1815B79A0 Slot: 35
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0 Slot: 36
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x15B7E80 Offset: 0x15B6480 VA: 0x1815B7E80 Slot: 37
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x15B7440 Offset: 0x15B5A40 VA: 0x1815B7440 Slot: 38
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 39
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0x15B7A30 Offset: 0x15B6030 VA: 0x1815B7A30 Slot: 40
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x15B7430 Offset: 0x15B5A30 VA: 0x1815B7430 Slot: 41
	public virtual StreamingContext get_Context() { }

	// RVA: 0x15B7A10 Offset: 0x15B6010 VA: 0x1815B7A10 Slot: 42
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0x15B7700 Offset: 0x15B5D00 VA: 0x1815B7700 Slot: 43
	public virtual Formatting get_Formatting() { }

	// RVA: 0x15B7D60 Offset: 0x15B6360 VA: 0x1815B7D60 Slot: 44
	public virtual void set_Formatting(Formatting value) { }

	// RVA: 0x15B7540 Offset: 0x15B5B40 VA: 0x1815B7540 Slot: 45
	public virtual DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x15B7AE0 Offset: 0x15B60E0 VA: 0x1815B7AE0 Slot: 46
	public virtual void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x15B7620 Offset: 0x15B5C20 VA: 0x1815B7620 Slot: 47
	public virtual DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x15B7BD0 Offset: 0x15B61D0 VA: 0x1815B7BD0 Slot: 48
	public virtual void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x15B75C0 Offset: 0x15B5BC0 VA: 0x1815B75C0 Slot: 49
	public virtual DateParseHandling get_DateParseHandling() { }

	// RVA: 0x15B7B70 Offset: 0x15B6170 VA: 0x1815B7B70 Slot: 50
	public virtual void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x15B76C0 Offset: 0x15B5CC0 VA: 0x1815B76C0 Slot: 51
	public virtual FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x15B7D00 Offset: 0x15B6300 VA: 0x1815B7D00 Slot: 52
	public virtual void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x15B7680 Offset: 0x15B5C80 VA: 0x1815B7680 Slot: 53
	public virtual FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x15B7CA0 Offset: 0x15B62A0 VA: 0x1815B7CA0 Slot: 54
	public virtual void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0x15B7740 Offset: 0x15B5D40 VA: 0x1815B7740 Slot: 55
	public virtual StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x15B8240 Offset: 0x15B6840 VA: 0x1815B8240 Slot: 56
	public virtual void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x15B7580 Offset: 0x15B5B80 VA: 0x1815B7580 Slot: 57
	public virtual string get_DateFormatString() { }

	// RVA: 0x15B7B40 Offset: 0x15B6140 VA: 0x1815B7B40 Slot: 58
	public virtual void set_DateFormatString(string value) { }

	// RVA: 0x15B74D0 Offset: 0x15B5AD0 VA: 0x1815B74D0 Slot: 59
	public virtual CultureInfo get_Culture() { }

	// RVA: 0x8DA860 Offset: 0x8D8E60 VA: 0x1808DA860 Slot: 60
	public virtual void set_Culture(CultureInfo value) { }

	// RVA: 0x131C550 Offset: 0x131AB50 VA: 0x18131C550 Slot: 61
	public virtual Nullable<int> get_MaxDepth() { }

	// RVA: 0x15B7DC0 Offset: 0x15B63C0 VA: 0x1815B7DC0 Slot: 62
	public virtual void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x15B73F0 Offset: 0x15B59F0 VA: 0x1815B73F0 Slot: 63
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0x15B7940 Offset: 0x15B5F40 VA: 0x1815B7940 Slot: 64
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x15B5E30 Offset: 0x15B4430 VA: 0x1815B5E30
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0x15B70E0 Offset: 0x15B56E0 VA: 0x1815B70E0
	public void .ctor() { }

	// RVA: 0x15B56D0 Offset: 0x15B3CD0 VA: 0x1815B56D0
	public static JsonSerializer Create() { }

	// RVA: 0x15B5520 Offset: 0x15B3B20 VA: 0x1815B5520
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0x15B5210 Offset: 0x15B3810 VA: 0x1815B5210
	public static JsonSerializer CreateDefault() { }

	// RVA: 0x15B5450 Offset: 0x15B3A50 VA: 0x1815B5450
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0x15B4940 Offset: 0x15B2F40 VA: 0x1815B4940
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x15B6190 Offset: 0x15B4790 VA: 0x1815B6190
	public void Populate(TextReader reader, object target) { }

	[DebuggerStepThrough]
	// RVA: 0x15B6170 Offset: 0x15B4770 VA: 0x1815B6170
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0x15B5E90 Offset: 0x15B4490 VA: 0x1815B5E90 Slot: 65
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	[DebuggerStepThrough]
	// RVA: 0x15B5B50 Offset: 0x15B4150 VA: 0x1815B5B50
	public object Deserialize(JsonReader reader) { }

	[DebuggerStepThrough]
	// RVA: 0x15B5B90 Offset: 0x15B4190 VA: 0x1815B5B90
	public object Deserialize(TextReader reader, Type objectType) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public T Deserialize<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x713090 Offset: 0x711690 VA: 0x180713090
	|-JsonSerializer.Deserialize<Int32Enum>
	|
	|-RVA: 0x712F90 Offset: 0x711590 VA: 0x180712F90
	|-JsonSerializer.Deserialize<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x15B5B70 Offset: 0x15B4170 VA: 0x1815B5B70
	public object Deserialize(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x15B5860 Offset: 0x15B3E60 VA: 0x1815B5860 Slot: 66
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x15B6C60 Offset: 0x15B5260 VA: 0x1815B6C60
	private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	[NullableContext(2)]
	// RVA: 0x15B6220 Offset: 0x15B4820 VA: 0x1815B6220
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0x15B6BA0 Offset: 0x15B51A0 VA: 0x1815B6BA0
	public void Serialize(TextWriter textWriter, object value) { }

	[NullableContext(2)]
	// RVA: 0x15B6B80 Offset: 0x15B5180 VA: 0x1815B6B80
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x15B6AE0 Offset: 0x15B50E0 VA: 0x1815B6AE0
	public void Serialize(TextWriter textWriter, object value, Type objectType) { }

	// RVA: 0x15B6C30 Offset: 0x15B5230 VA: 0x1815B6C30
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0x15B5490 Offset: 0x15B3A90 VA: 0x1815B5490
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x15B6520 Offset: 0x15B4B20 VA: 0x1815B6520 Slot: 67
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x15B5DC0 Offset: 0x15B43C0 VA: 0x1815B5DC0
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0x15B5C20 Offset: 0x15B4220 VA: 0x1815B5C20
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0x15B5CF0 Offset: 0x15B42F0 VA: 0x1815B5CF0
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	// RVA: 0x15B5E70 Offset: 0x15B4470 VA: 0x1815B5E70
	internal void OnError(ErrorEventArgs e) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Nullable(0)]
public class JsonSerializerSettings // TypeDefIndex: 8163
{
	// Fields
	internal const ReferenceLoopHandling DefaultReferenceLoopHandling = 0;
	internal const MissingMemberHandling DefaultMissingMemberHandling = 0;
	internal const NullValueHandling DefaultNullValueHandling = 0;
	internal const DefaultValueHandling DefaultDefaultValueHandling = 0;
	internal const ObjectCreationHandling DefaultObjectCreationHandling = 0;
	internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = 0;
	internal const ConstructorHandling DefaultConstructorHandling = 0;
	internal const TypeNameHandling DefaultTypeNameHandling = 0;
	internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = 0;
	internal static readonly StreamingContext DefaultContext; // 0x0
	internal const Formatting DefaultFormatting = 0;
	internal const DateFormatHandling DefaultDateFormatHandling = 0;
	internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = 3;
	internal const DateParseHandling DefaultDateParseHandling = 1;
	internal const FloatParseHandling DefaultFloatParseHandling = 0;
	internal const FloatFormatHandling DefaultFloatFormatHandling = 0;
	internal const StringEscapeHandling DefaultStringEscapeHandling = 0;
	internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = 0;
	[Nullable(1)]
	internal static readonly CultureInfo DefaultCulture; // 0x10
	internal const bool DefaultCheckAdditionalContent = False;
	[Nullable(1)]
	internal const string DefaultDateFormatString = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK";
	internal const int DefaultMaxDepth = 64;
	internal Nullable<Formatting> _formatting; // 0x10
	internal Nullable<DateFormatHandling> _dateFormatHandling; // 0x18
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x20
	internal Nullable<DateParseHandling> _dateParseHandling; // 0x28
	internal Nullable<FloatFormatHandling> _floatFormatHandling; // 0x30
	internal Nullable<FloatParseHandling> _floatParseHandling; // 0x38
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; // 0x40
	internal CultureInfo _culture; // 0x48
	internal Nullable<bool> _checkAdditionalContent; // 0x50
	internal Nullable<int> _maxDepth; // 0x54
	internal bool _maxDepthSet; // 0x5C
	internal string _dateFormatString; // 0x60
	internal bool _dateFormatStringSet; // 0x68
	internal Nullable<TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling; // 0x6C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x74
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; // 0x7C
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x84
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x8C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x94
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x9C
	internal Nullable<StreamingContext> _context; // 0xA8
	internal Nullable<ConstructorHandling> _constructorHandling; // 0xC0
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0xC8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; // 0xD0
	[Nullable(1)]
	[CompilerGenerated]
	private IList<JsonConverter> <Converters>k__BackingField; // 0xD8
	[CompilerGenerated]
	private IContractResolver <ContractResolver>k__BackingField; // 0xE0
	[CompilerGenerated]
	private IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
	[CompilerGenerated]
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
	[CompilerGenerated]
	private ITraceWriter <TraceWriter>k__BackingField; // 0xF8
	[CompilerGenerated]
	private ISerializationBinder <SerializationBinder>k__BackingField; // 0x100
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; // 0x108

	// Properties
	public ReferenceLoopHandling ReferenceLoopHandling { get; set; }
	public MissingMemberHandling MissingMemberHandling { get; set; }
	public ObjectCreationHandling ObjectCreationHandling { get; set; }
	public NullValueHandling NullValueHandling { get; set; }
	public DefaultValueHandling DefaultValueHandling { get; set; }
	[Nullable(1)]
	public IList<JsonConverter> Converters { get; set; }
	public PreserveReferencesHandling PreserveReferencesHandling { get; set; }
	public TypeNameHandling TypeNameHandling { get; set; }
	public MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public FormatterAssemblyStyle TypeNameAssemblyFormat { get; set; }
	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; set; }
	public ConstructorHandling ConstructorHandling { get; set; }
	public IContractResolver ContractResolver { get; set; }
	public IEqualityComparer EqualityComparer { get; set; }
	[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
	public IReferenceResolver ReferenceResolver { get; set; }
	public Func<IReferenceResolver> ReferenceResolverProvider { get; set; }
	public ITraceWriter TraceWriter { get; set; }
	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public SerializationBinder Binder { get; set; }
	public ISerializationBinder SerializationBinder { get; set; }
	[Nullable(new[] { 2, 1 })]
	public EventHandler<ErrorEventArgs> Error { get; set; }
	public StreamingContext Context { get; set; }
	[Nullable(1)]
	public string DateFormatString { get; set; }
	public Nullable<int> MaxDepth { get; set; }
	public Formatting Formatting { get; set; }
	public DateFormatHandling DateFormatHandling { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public DateParseHandling DateParseHandling { get; set; }
	public FloatFormatHandling FloatFormatHandling { get; set; }
	public FloatParseHandling FloatParseHandling { get; set; }
	public StringEscapeHandling StringEscapeHandling { get; set; }
	[Nullable(1)]
	public CultureInfo Culture { get; set; }
	public bool CheckAdditionalContent { get; set; }

	// Methods

	// RVA: 0x15B3DE0 Offset: 0x15B23E0 VA: 0x1815B3DE0
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x15B46A0 Offset: 0x15B2CA0 VA: 0x1815B46A0
	public void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x15B3CE0 Offset: 0x15B22E0 VA: 0x1815B3CE0
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x15B4520 Offset: 0x15B2B20 VA: 0x1815B4520
	public void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x15B3D60 Offset: 0x15B2360 VA: 0x1815B3D60
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x15B45E0 Offset: 0x15B2BE0 VA: 0x1815B45E0
	public void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x15B3D20 Offset: 0x15B2320 VA: 0x1815B3D20
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0x15B4580 Offset: 0x15B2B80 VA: 0x1815B4580
	public void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x15B3B30 Offset: 0x15B2130 VA: 0x1815B3B30
	public DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0x15B4240 Offset: 0x15B2840 VA: 0x1815B4240
	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x3A3640 Offset: 0x3A1C40 VA: 0x1803A3640
	public IList<JsonConverter> get_Converters() { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x15B40E0 Offset: 0x15B26E0 VA: 0x1815B40E0
	public void set_Converters(IList<JsonConverter> value) { }

	// RVA: 0x15B3DA0 Offset: 0x15B23A0 VA: 0x1815B3DA0
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0x15B4640 Offset: 0x15B2C40 VA: 0x1815B4640
	public void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x15B3EC0 Offset: 0x15B24C0 VA: 0x1815B3EC0
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x15B48E0 Offset: 0x15B2EE0 VA: 0x1815B48E0
	public void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x15B3CA0 Offset: 0x15B22A0 VA: 0x1815B3CA0
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x15B44C0 Offset: 0x15B2AC0 VA: 0x1815B44C0
	public void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x15B3E80 Offset: 0x15B2480 VA: 0x1815B3E80
	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	// RVA: 0x15B4880 Offset: 0x15B2E80 VA: 0x1815B4880
	public void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x15B3E80 Offset: 0x15B2480 VA: 0x1815B3E80
	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0x15B4880 Offset: 0x15B2E80 VA: 0x1815B4880
	public void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x15B38A0 Offset: 0x15B1EA0 VA: 0x1815B38A0
	public ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0x15B3FF0 Offset: 0x15B25F0 VA: 0x1815B3FF0
	public void set_ConstructorHandling(ConstructorHandling value) { }

	[CompilerGenerated]
	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	public IContractResolver get_ContractResolver() { }

	[CompilerGenerated]
	// RVA: 0x12F1A10 Offset: 0x12F0010 VA: 0x1812F1A10
	public void set_ContractResolver(IContractResolver value) { }

	[CompilerGenerated]
	// RVA: 0x5513E0 Offset: 0x54F9E0 VA: 0x1805513E0
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGenerated]
	// RVA: 0x15B42A0 Offset: 0x15B28A0 VA: 0x1815B42A0
	public void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x15B3E20 Offset: 0x15B2420 VA: 0x1815B3E20
	public IReferenceResolver get_ReferenceResolver() { }

	// RVA: 0x15B4700 Offset: 0x15B2D00 VA: 0x1815B4700
	public void set_ReferenceResolver(IReferenceResolver value) { }

	[CompilerGenerated]
	// RVA: 0x551B80 Offset: 0x550180 VA: 0x180551B80
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGenerated]
	// RVA: 0x551B90 Offset: 0x550190 VA: 0x180551B90
	public void set_ReferenceResolverProvider(Func<IReferenceResolver> value) { }

	[CompilerGenerated]
	// RVA: 0x5612C0 Offset: 0x55F8C0 VA: 0x1805612C0
	public ITraceWriter get_TraceWriter() { }

	[CompilerGenerated]
	// RVA: 0x15B4860 Offset: 0x15B2E60 VA: 0x1815B4860
	public void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0x15B37A0 Offset: 0x15B1DA0 VA: 0x1815B37A0
	public SerializationBinder get_Binder() { }

	// RVA: 0x15B3F00 Offset: 0x15B2500 VA: 0x1815B3F00
	public void set_Binder(SerializationBinder value) { }

	[CompilerGenerated]
	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public ISerializationBinder get_SerializationBinder() { }

	[CompilerGenerated]
	// RVA: 0x15B47E0 Offset: 0x15B2DE0 VA: 0x1815B47E0
	public void set_SerializationBinder(ISerializationBinder value) { }

	[CompilerGenerated]
	// RVA: 0x15B3B70 Offset: 0x15B2170 VA: 0x1815B3B70
	public EventHandler<ErrorEventArgs> get_Error() { }

	[CompilerGenerated]
	// RVA: 0x15B42C0 Offset: 0x15B28C0 VA: 0x1815B42C0
	public void set_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x15B38E0 Offset: 0x15B1EE0 VA: 0x1815B38E0
	public StreamingContext get_Context() { }

	// RVA: 0x15B4050 Offset: 0x15B2650 VA: 0x1815B4050
	public void set_Context(StreamingContext value) { }

	[NullableContext(1)]
	// RVA: 0x15B3A50 Offset: 0x15B2050 VA: 0x1815B3A50
	public string get_DateFormatString() { }

	[NullableContext(1)]
	// RVA: 0x15B4160 Offset: 0x15B2760 VA: 0x1815B4160
	public void set_DateFormatString(string value) { }

	// RVA: 0x15B3C40 Offset: 0x15B2240 VA: 0x1815B3C40
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0x15B4400 Offset: 0x15B2A00 VA: 0x1815B4400
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x15B3C00 Offset: 0x15B2200 VA: 0x1815B3C00
	public Formatting get_Formatting() { }

	// RVA: 0x15B43A0 Offset: 0x15B29A0 VA: 0x1815B43A0
	public void set_Formatting(Formatting value) { }

	// RVA: 0x15B3A10 Offset: 0x15B2010 VA: 0x1815B3A10
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x15B4100 Offset: 0x15B2700 VA: 0x1815B4100
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x15B3AE0 Offset: 0x15B20E0 VA: 0x1815B3AE0
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x15B41E0 Offset: 0x15B27E0 VA: 0x1815B41E0
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x15B3A90 Offset: 0x15B2090 VA: 0x1815B3A90
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0x15B4180 Offset: 0x15B2780 VA: 0x1815B4180
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x15B3B80 Offset: 0x15B2180 VA: 0x1815B3B80
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x15B42E0 Offset: 0x15B28E0 VA: 0x1815B42E0
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0x15B3BC0 Offset: 0x15B21C0 VA: 0x1815B3BC0
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x15B4340 Offset: 0x15B2940 VA: 0x1815B4340
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x15B3E40 Offset: 0x15B2440 VA: 0x1815B3E40
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x15B4800 Offset: 0x15B2E00 VA: 0x1815B4800
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	[NullableContext(1)]
	// RVA: 0x15B39B0 Offset: 0x15B1FB0 VA: 0x1815B39B0
	public CultureInfo get_Culture() { }

	[NullableContext(1)]
	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x15B3860 Offset: 0x15B1E60 VA: 0x1815B3860
	public bool get_CheckAdditionalContent() { }

	// RVA: 0x15B3F90 Offset: 0x15B2590 VA: 0x1815B3F90
	public void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x15B3690 Offset: 0x15B1C90 VA: 0x1815B3690
	private static void .cctor() { }

	[DebuggerStepThrough]
	// RVA: 0x15B3720 Offset: 0x15B1D20 VA: 0x1815B3720
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 8202
{
	// Fields
	private readonly bool _safeAsync; // 0x78
	private const char UnicodeReplacementChar = '\xfffd';
	private const int MaximumJavascriptIntegerCharacterLength = 380;
	private const int LargeBufferLength = 1073741823;
	private readonly TextReader _reader; // 0x80
	[Nullable(2)]
	private char[] _chars; // 0x88
	private int _charsUsed; // 0x90
	private int _charPos; // 0x94
	private int _lineStartPos; // 0x98
	private int _lineNumber; // 0x9C
	private bool _isEndOfFile; // 0xA0
	private StringBuffer _stringBuffer; // 0xA8
	private StringReference _stringReference; // 0xB8
	[Nullable(2)]
	private IArrayPool<char> _arrayPool; // 0xC8
	[Nullable(2)]
	[CompilerGenerated]
	private JsonNameTable <PropertyNameTable>k__BackingField; // 0xD0

	// Properties
	[Nullable(2)]
	public JsonNameTable PropertyNameTable { get; set; }
	[Nullable(2)]
	public IArrayPool<char> ArrayPool { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x15C3400 Offset: 0x15C1A00 VA: 0x1815C3400 Slot: 5
	public override Task<bool> ReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15B90D0 Offset: 0x15B76D0 VA: 0x1815B90D0
	internal Task<bool> DoReadAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsync>d__3))]
	// RVA: 0x15B97E0 Offset: 0x15B7DE0 VA: 0x1815B97E0
	private Task<bool> DoReadAsync(Task<bool> task, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParsePostValueAsync>d__4))]
	// RVA: 0x15BD330 Offset: 0x15BB930 VA: 0x1815BD330
	private Task<bool> ParsePostValueAsync(bool ignoreComments, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadFromFinishedAsync>d__5))]
	// RVA: 0x15C3CE0 Offset: 0x15C22E0 VA: 0x1815C3CE0
	private Task<bool> ReadFromFinishedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C3890 Offset: 0x15C1E90 VA: 0x1815C3890
	private Task<int> ReadDataAsync(bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadDataAsync>d__7))]
	// RVA: 0x15C3750 Offset: 0x15C1D50 VA: 0x1815C3750
	private Task<int> ReadDataAsync(bool append, int charsRequired, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseValueAsync>d__8))]
	// RVA: 0x15BFAF0 Offset: 0x15BE0F0 VA: 0x1815BFAF0
	private Task<bool> ParseValueAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadStringIntoBufferAsync>d__9))]
	// RVA: 0x15C50B0 Offset: 0x15C36B0 VA: 0x1815C50B0
	private Task ReadStringIntoBufferAsync(char quote, CancellationToken cancellationToken) { }

	// RVA: 0x15C08C0 Offset: 0x15BEEC0 VA: 0x1815C08C0
	private Task ProcessCarriageReturnAsync(bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ProcessCarriageReturnAsync>d__11))]
	// RVA: 0x15C07C0 Offset: 0x15BEDC0 VA: 0x1815C07C0
	private Task ProcessCarriageReturnAsync(Task<bool> task) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseUnicodeAsync>d__12))]
	// RVA: 0x15BF500 Offset: 0x15BDB00 VA: 0x1815BF500
	private Task<char> ParseUnicodeAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15B9C90 Offset: 0x15B8290 VA: 0x1815B9C90
	private Task<bool> EnsureCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadCharsAsync>d__14))]
	// RVA: 0x15C34C0 Offset: 0x15C1AC0 VA: 0x1815C34C0
	private Task<bool> ReadCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseObjectAsync>d__15))]
	// RVA: 0x15BD020 Offset: 0x15BB620 VA: 0x1815BD020
	private Task<bool> ParseObjectAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseCommentAsync>d__16))]
	// RVA: 0x15BB020 Offset: 0x15B9620 VA: 0x1815BB020
	private Task ParseCommentAsync(bool setToken, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<EatWhitespaceAsync>d__17))]
	// RVA: 0x15B9920 Offset: 0x15B7F20 VA: 0x1815B9920
	private Task EatWhitespaceAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseStringAsync>d__18))]
	// RVA: 0x15BF080 Offset: 0x15BD680 VA: 0x1815BF080
	private Task ParseStringAsync(char quote, ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<MatchValueAsync>d__19))]
	// RVA: 0x15BA990 Offset: 0x15B8F90 VA: 0x1815BA990
	private Task<bool> MatchValueAsync(string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<MatchValueWithTrailingSeparatorAsync>d__20))]
	// RVA: 0x15BAAD0 Offset: 0x15B90D0 VA: 0x1815BAAD0
	private Task<bool> MatchValueWithTrailingSeparatorAsync(string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<MatchAndSetAsync>d__21))]
	// RVA: 0x15BA840 Offset: 0x15B8E40 VA: 0x1815BA840
	private Task MatchAndSetAsync(string value, JsonToken newToken, object tokenValue, CancellationToken cancellationToken) { }

	// RVA: 0x15BF200 Offset: 0x15BD800 VA: 0x1815BF200
	private Task ParseTrueAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15BBA70 Offset: 0x15BA070 VA: 0x1815BBA70
	private Task ParseFalseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15BBC10 Offset: 0x15BA210 VA: 0x1815BBC10
	private Task ParseNullAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseConstructorAsync>d__25))]
	// RVA: 0x15BB520 Offset: 0x15B9B20 VA: 0x1815BB520
	private Task ParseConstructorAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberNaNAsync>d__26))]
	// RVA: 0x15BBE80 Offset: 0x15BA480 VA: 0x1815BBE80
	private Task<object> ParseNumberNaNAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberPositiveInfinityAsync>d__27))]
	// RVA: 0x15BC8C0 Offset: 0x15BAEC0 VA: 0x1815BC8C0
	private Task<object> ParseNumberPositiveInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberNegativeInfinityAsync>d__28))]
	// RVA: 0x15BC3A0 Offset: 0x15BA9A0 VA: 0x1815BC3A0
	private Task<object> ParseNumberNegativeInfinityAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseNumberAsync>d__29))]
	// RVA: 0x15BBD70 Offset: 0x15BA370 VA: 0x1815BBD70
	private Task ParseNumberAsync(ReadType readType, CancellationToken cancellationToken) { }

	// RVA: 0x15BF3A0 Offset: 0x15BD9A0 VA: 0x1815BF3A0
	private Task ParseUndefinedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParsePropertyAsync>d__31))]
	// RVA: 0x15BD7D0 Offset: 0x15BBDD0 VA: 0x1815BD7D0
	private Task<bool> ParsePropertyAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadNumberIntoBufferAsync>d__32))]
	// RVA: 0x15C4200 Offset: 0x15C2800 VA: 0x1815C4200
	private Task ReadNumberIntoBufferAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ParseUnquotedPropertyAsync>d__33))]
	// RVA: 0x15BF7D0 Offset: 0x15BDDD0 VA: 0x1815BF7D0
	private Task ParseUnquotedPropertyAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadNullCharAsync>d__34))]
	// RVA: 0x15C3F00 Offset: 0x15C2500 VA: 0x1815C3F00
	private Task<bool> ReadNullCharAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<HandleNullAsync>d__35))]
	// RVA: 0x15BA510 Offset: 0x15B8B10 VA: 0x1815BA510
	private Task HandleNullAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadFinishedAsync>d__36))]
	// RVA: 0x15C3AA0 Offset: 0x15C20A0 VA: 0x1815C3AA0
	private Task ReadFinishedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadStringValueAsync>d__37))]
	// RVA: 0x15C58D0 Offset: 0x15C3ED0 VA: 0x1815C58D0
	private Task<object> ReadStringValueAsync(ReadType readType, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadNumberValueAsync>d__38))]
	// RVA: 0x15C44F0 Offset: 0x15C2AF0 VA: 0x1815C44F0
	private Task<object> ReadNumberValueAsync(ReadType readType, CancellationToken cancellationToken) { }

	// RVA: 0x15C0D30 Offset: 0x15BF330 VA: 0x1815C0D30 Slot: 6
	public override Task<Nullable<bool>> ReadAsBooleanAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsBooleanAsync>d__40))]
	// RVA: 0x15B87A0 Offset: 0x15B6DA0 VA: 0x1815B87A0
	internal Task<Nullable<bool>> DoReadAsBooleanAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C1980 Offset: 0x15BFF80 VA: 0x1815C1980 Slot: 7
	public override Task<byte[]> ReadAsBytesAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsBytesAsync>d__42))]
	// RVA: 0x15B88E0 Offset: 0x15B6EE0 VA: 0x1815B88E0
	internal Task<byte[]> DoReadAsBytesAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<ReadIntoWrappedTypeObjectAsync>d__43))]
	// RVA: 0x15C3E10 Offset: 0x15C2410 VA: 0x1815C3E10
	private Task ReadIntoWrappedTypeObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C24B0 Offset: 0x15C0AB0 VA: 0x1815C24B0 Slot: 8
	public override Task<Nullable<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsDateTimeAsync>d__45))]
	// RVA: 0x15B8A10 Offset: 0x15B7010 VA: 0x1815B8A10
	internal Task<Nullable<DateTime>> DoReadAsDateTimeAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C26B0 Offset: 0x15C0CB0 VA: 0x1815C26B0 Slot: 9
	public override Task<Nullable<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsDateTimeOffsetAsync>d__47))]
	// RVA: 0x15B8B30 Offset: 0x15B7130 VA: 0x1815B8B30
	internal Task<Nullable<DateTimeOffset>> DoReadAsDateTimeOffsetAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C2A30 Offset: 0x15C1030 VA: 0x1815C2A30 Slot: 10
	public override Task<Nullable<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsDecimalAsync>d__49))]
	// RVA: 0x15B8C50 Offset: 0x15B7250 VA: 0x1815B8C50
	internal Task<Nullable<Decimal>> DoReadAsDecimalAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C2D10 Offset: 0x15C1310 VA: 0x1815C2D10 Slot: 11
	public override Task<Nullable<double>> ReadAsDoubleAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsDoubleAsync>d__51))]
	// RVA: 0x15B8D70 Offset: 0x15B7370 VA: 0x1815B8D70
	internal Task<Nullable<double>> DoReadAsDoubleAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C2F70 Offset: 0x15C1570 VA: 0x1815C2F70 Slot: 12
	public override Task<Nullable<int>> ReadAsInt32Async(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsInt32Async>d__53))]
	// RVA: 0x15B8E90 Offset: 0x15B7490 VA: 0x1815B8E90
	internal Task<Nullable<int>> DoReadAsInt32Async(CancellationToken cancellationToken) { }

	// RVA: 0x15C31E0 Offset: 0x15C17E0 VA: 0x1815C31E0 Slot: 13
	public override Task<string> ReadAsStringAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextReader.<DoReadAsStringAsync>d__55))]
	// RVA: 0x15B8FB0 Offset: 0x15B75B0 VA: 0x1815B8FB0
	internal Task<string> DoReadAsStringAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C6C10 Offset: 0x15C5210 VA: 0x1815C6C10
	public void .ctor(TextReader reader) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	public JsonNameTable get_PropertyNameTable() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x510990 Offset: 0x50EF90 VA: 0x180510990
	public void set_PropertyNameTable(JsonNameTable value) { }

	[NullableContext(2)]
	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	public IArrayPool<char> get_ArrayPool() { }

	[NullableContext(2)]
	// RVA: 0x15C6DD0 Offset: 0x15C53D0 VA: 0x1815C6DD0
	public void set_ArrayPool(IArrayPool<char> value) { }

	// RVA: 0x15B9BC0 Offset: 0x15B81C0 VA: 0x1815B9BC0
	private void EnsureBufferNotEmpty() { }

	// RVA: 0x15C6990 Offset: 0x15C4F90 VA: 0x1815C6990
	private void SetNewLine(bool hasNextChar) { }

	// RVA: 0x15BB010 Offset: 0x15B9610 VA: 0x1815BB010
	private void OnNewLine(int pos) { }

	// RVA: 0x15BF1A0 Offset: 0x15BD7A0 VA: 0x1815BF1A0
	private void ParseString(char quote, ReadType readType) { }

	// RVA: 0x15BECC0 Offset: 0x15BD2C0 VA: 0x1815BECC0
	private void ParseReadString(char quote, ReadType readType) { }

	// RVA: 0x15B8470 Offset: 0x15B6A70 VA: 0x1815B8470
	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x15C69F0 Offset: 0x15C4FF0 VA: 0x1815C69F0
	private void ShiftBufferIfNeeded() { }

	// RVA: 0x15C39D0 Offset: 0x15C1FD0 VA: 0x1815C39D0
	private int ReadData(bool append) { }

	// RVA: 0x15C05B0 Offset: 0x15BEBB0 VA: 0x1815C05B0
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	// RVA: 0x15C39E0 Offset: 0x15C1FE0 VA: 0x1815C39E0
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0x15B9E70 Offset: 0x15B8470 VA: 0x1815B9E70
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0x15C3610 Offset: 0x15C1C10 VA: 0x1815C3610
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0x15C6680 Offset: 0x15C4C80 VA: 0x1815C6680 Slot: 21
	public override bool Read() { }

	// RVA: 0x15C3150 Offset: 0x15C1750 VA: 0x1815C3150 Slot: 22
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x15C2990 Offset: 0x15C0F90 VA: 0x1815C2990 Slot: 28
	public override Nullable<DateTime> ReadAsDateTime() { }

	[NullableContext(2)]
	// RVA: 0x15C33C0 Offset: 0x15C19C0 VA: 0x1815C33C0 Slot: 23
	public override string ReadAsString() { }

	[NullableContext(2)]
	// RVA: 0x15C1B80 Offset: 0x15C0180 VA: 0x1815C1B80 Slot: 24
	public override byte[] ReadAsBytes() { }

	[NullableContext(2)]
	// RVA: 0x15C5A10 Offset: 0x15C4010 VA: 0x1815C5A10
	private object ReadStringValue(ReadType readType) { }

	[NullableContext(2)]
	// RVA: 0x15BA130 Offset: 0x15B8730 VA: 0x1815BA130
	private object FinishReadQuotedStringValue(ReadType readType) { }

	// RVA: 0x15B86F0 Offset: 0x15B6CF0 VA: 0x1815B86F0
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	// RVA: 0x15C0F30 Offset: 0x15BF530 VA: 0x1815C0F30 Slot: 26
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x15C0CB0 Offset: 0x15BF2B0 VA: 0x1815C0CB0
	private void ProcessValueComma() { }

	[NullableContext(2)]
	// RVA: 0x15C4630 Offset: 0x15C2C30 VA: 0x1815C4630
	private object ReadNumberValue(ReadType readType) { }

	[NullableContext(2)]
	// RVA: 0x15B9FC0 Offset: 0x15B85C0 VA: 0x1815B9FC0
	private object FinishReadQuotedNumber(ReadType readType) { }

	// RVA: 0x15C28E0 Offset: 0x15C0EE0 VA: 0x1815C28E0 Slot: 29
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x15C2C60 Offset: 0x15C1260 VA: 0x1815C2C60 Slot: 27
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x15C2ED0 Offset: 0x15C14D0 VA: 0x1815C2ED0 Slot: 25
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x15BA610 Offset: 0x15B8C10 VA: 0x1815BA610
	private void HandleNull() { }

	// RVA: 0x15C3BA0 Offset: 0x15C21A0 VA: 0x1815C3BA0
	private void ReadFinished() { }

	// RVA: 0x15C4020 Offset: 0x15C2620 VA: 0x1815C4020
	private bool ReadNullChar() { }

	// RVA: 0x15B9C20 Offset: 0x15B8220 VA: 0x1815B9C20
	private void EnsureBuffer() { }

	// RVA: 0x15C51E0 Offset: 0x15C37E0 VA: 0x1815C51E0
	private void ReadStringIntoBuffer(char quote) { }

	// RVA: 0x15BA400 Offset: 0x15B8A00 VA: 0x1815BA400
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	// RVA: 0x15C6BA0 Offset: 0x15C51A0 VA: 0x1815C6BA0
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0x15B8550 Offset: 0x15B6B50 VA: 0x1815B8550
	private char ConvertUnicode(bool enoughChars) { }

	// RVA: 0x15BF620 Offset: 0x15BDC20 VA: 0x1815BF620
	private char ParseUnicode() { }

	// RVA: 0x15C4300 Offset: 0x15C2900 VA: 0x1815C4300
	private void ReadNumberIntoBuffer() { }

	// RVA: 0x15C4070 Offset: 0x15C2670 VA: 0x1815C4070
	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) { }

	// RVA: 0x15B8490 Offset: 0x15B6A90 VA: 0x1815B8490
	private void ClearRecentString() { }

	// RVA: 0x15BD470 Offset: 0x15BBA70 VA: 0x1815BD470
	private bool ParsePostValue(bool ignoreComments) { }

	// RVA: 0x15BD150 Offset: 0x15BB750 VA: 0x1815BD150
	private bool ParseObject() { }

	// RVA: 0x15BD900 Offset: 0x15BBF00 VA: 0x1815BD900
	private bool ParseProperty() { }

	// RVA: 0x15C6B50 Offset: 0x15C5150 VA: 0x1815C6B50
	private bool ValidIdentifierChar(char value) { }

	// RVA: 0x15BF8D0 Offset: 0x15BDED0 VA: 0x1815BF8D0
	private void ParseUnquotedProperty() { }

	// RVA: 0x15C6510 Offset: 0x15C4B10 VA: 0x1815C6510
	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) { }

	// RVA: 0x15BFC20 Offset: 0x15BE220 VA: 0x1815BFC20
	private bool ParseValue() { }

	// RVA: 0x15C0C90 Offset: 0x15BF290 VA: 0x1815C0C90
	private void ProcessLineFeed() { }

	// RVA: 0x15C0C20 Offset: 0x15BF220 VA: 0x1815C0C20
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0x15B9A20 Offset: 0x15B8020 VA: 0x1815B9A20
	private void EatWhitespace() { }

	// RVA: 0x15BB630 Offset: 0x15B9C30 VA: 0x1815BB630
	private void ParseConstructor() { }

	// RVA: 0x15BCDE0 Offset: 0x15BB3E0 VA: 0x1815BCDE0
	private void ParseNumber(ReadType readType) { }

	// RVA: 0x15BDC50 Offset: 0x15BC250 VA: 0x1815BDC50
	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) { }

	// RVA: 0x15C6AD0 Offset: 0x15C50D0 VA: 0x1815C6AD0
	private JsonReaderException ThrowReaderError(string message, Exception ex) { }

	// RVA: 0x15B83F0 Offset: 0x15B69F0 VA: 0x1815B83F0
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	// RVA: 0x15BB140 Offset: 0x15B9740 VA: 0x1815BB140
	private void ParseComment(bool setToken) { }

	// RVA: 0x15B9B70 Offset: 0x15B8170 VA: 0x1815B9B70
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0x15BAF20 Offset: 0x15B9520 VA: 0x1815BAF20
	private bool MatchValue(string value) { }

	// RVA: 0x15BAE40 Offset: 0x15B9440 VA: 0x1815BAE40
	private bool MatchValue(bool enoughChars, string value) { }

	// RVA: 0x15BAC10 Offset: 0x15B9210 VA: 0x1815BAC10
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0x15BA720 Offset: 0x15B8D20 VA: 0x1815BA720
	private bool IsSeparator(char c) { }

	// RVA: 0x15BF2B0 Offset: 0x15BD8B0 VA: 0x1815BF2B0
	private void ParseTrue() { }

	// RVA: 0x15BBC90 Offset: 0x15BA290 VA: 0x1815BBC90
	private void ParseNull() { }

	// RVA: 0x15BF420 Offset: 0x15BDA20 VA: 0x1815BF420
	private void ParseUndefined() { }

	// RVA: 0x15BBB20 Offset: 0x15BA120 VA: 0x1815BBB20
	private void ParseFalse() { }

	// RVA: 0x15BC6A0 Offset: 0x15BACA0 VA: 0x1815BC6A0
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0x15BC4D0 Offset: 0x15BAAD0 VA: 0x1815BC4D0
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	// RVA: 0x15BCBC0 Offset: 0x15BB1C0 VA: 0x1815BCBC0
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0x15BC9F0 Offset: 0x15BAFF0 VA: 0x1815BC9F0
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	// RVA: 0x15BBFB0 Offset: 0x15BA5B0 VA: 0x1815BBFB0
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0x15BC1D0 Offset: 0x15BA7D0 VA: 0x1815BC1D0
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	// RVA: 0x15B84B0 Offset: 0x15B6AB0 VA: 0x1815B84B0 Slot: 31
	public override void Close() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 32
	public bool HasLineInfo() { }

	// RVA: 0x15C6D70 Offset: 0x15C5370 VA: 0x1815C6D70 Slot: 33
	public int get_LineNumber() { }

	// RVA: 0x15C6DC0 Offset: 0x15C53C0 VA: 0x1815C6DC0 Slot: 34
	public int get_LinePosition() { }
}

// Namespace: Newtonsoft.Json
internal enum ReadType // TypeDefIndex: 8203
{
	// Fields
	public int value__; // 0x0
	public const ReadType Read = 0;
	public const ReadType ReadAsInt32 = 1;
	public const ReadType ReadAsInt64 = 2;
	public const ReadType ReadAsBytes = 3;
	public const ReadType ReadAsString = 4;
	public const ReadType ReadAsDecimal = 5;
	public const ReadType ReadAsDateTime = 6;
	public const ReadType ReadAsDateTimeOffset = 7;
	public const ReadType ReadAsDouble = 8;
	public const ReadType ReadAsBoolean = 9;
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class JsonTextWriter : JsonWriter // TypeDefIndex: 8223
{
	// Fields
	private readonly bool _safeAsync; // 0x60
	private const int IndentCharBufferSize = 12;
	private readonly TextWriter _writer; // 0x68
	[Nullable(2)]
	private Base64Encoder _base64Encoder; // 0x70
	private char _indentChar; // 0x78
	private int _indentation; // 0x7C
	private char _quoteChar; // 0x80
	private bool _quoteName; // 0x82
	[Nullable(2)]
	private bool[] _charEscapeFlags; // 0x88
	[Nullable(2)]
	private char[] _writeBuffer; // 0x90
	[Nullable(2)]
	private IArrayPool<char> _arrayPool; // 0x98
	[Nullable(2)]
	private char[] _indentChars; // 0xA0

	// Properties
	private Base64Encoder Base64Encoder { get; }
	[Nullable(2)]
	public IArrayPool<char> ArrayPool { get; set; }
	public int Indentation { get; set; }
	public char QuoteChar { get; set; }
	public char IndentChar { get; set; }
	public bool QuoteName { get; set; }

	// Methods

	// RVA: 0x15CAF40 Offset: 0x15C9540 VA: 0x1815CAF40 Slot: 6
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C8370 Offset: 0x15C6970 VA: 0x1815C8370
	internal Task DoFlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CF0E0 Offset: 0x15CD6E0 VA: 0x1815CF0E0 Slot: 9
	protected override Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CAD20 Offset: 0x15C9320 VA: 0x1815CAD20
	internal Task DoWriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CB4C0 Offset: 0x15C9AC0 VA: 0x1815CB4C0 Slot: 7
	protected override Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x15C8510 Offset: 0x15C6B10 VA: 0x1815C8510
	internal Task DoWriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x15C8070 Offset: 0x15C6670 VA: 0x1815C8070 Slot: 5
	public override Task CloseAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoCloseAsync>d__8))]
	// RVA: 0x15C8280 Offset: 0x15C6880 VA: 0x1815C8280
	internal Task DoCloseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CB4A0 Offset: 0x15C9AA0 VA: 0x1815CB4A0 Slot: 12
	public override Task WriteEndAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CB990 Offset: 0x15C9F90 VA: 0x1815CB990 Slot: 8
	protected override Task WriteIndentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C8650 Offset: 0x15C6C50 VA: 0x1815C8650
	internal Task DoWriteIndentAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteIndentAsync>d__12))]
	// RVA: 0x15CBB70 Offset: 0x15CA170 VA: 0x1815CBB70
	private Task WriteIndentAsync(int currentIndentCount, int newLineLen, CancellationToken cancellationToken) { }

	// RVA: 0x15CF2D0 Offset: 0x15CD8D0 VA: 0x1815CF2D0
	private Task WriteValueInternalAsync(JsonToken token, string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteValueInternalAsync>d__14))]
	// RVA: 0x15CF190 Offset: 0x15CD790 VA: 0x1815CF190
	private Task WriteValueInternalAsync(Task task, string value, CancellationToken cancellationToken) { }

	// RVA: 0x15CBC90 Offset: 0x15CA290 VA: 0x1815CBC90 Slot: 10
	protected override Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C8810 Offset: 0x15C6E10 VA: 0x1815C8810
	internal Task DoWriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CCA50 Offset: 0x15CB050 VA: 0x1815CCA50 Slot: 11
	public override Task WriteRawAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x15C8DC0 Offset: 0x15C73C0 VA: 0x1815C8DC0
	internal Task DoWriteRawAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x15CC4E0 Offset: 0x15CAAE0 VA: 0x1815CC4E0 Slot: 16
	public override Task WriteNullAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C8880 Offset: 0x15C6E80 VA: 0x1815C8880
	internal Task DoWriteNullAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CB390 Offset: 0x15C9990 VA: 0x1815CB390
	private Task WriteDigitsAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	// RVA: 0x15CBE80 Offset: 0x15CA480 VA: 0x1815CBE80
	private Task WriteIntegerValueAsync(ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteIntegerValueAsync>d__23))]
	// RVA: 0x15CC120 Offset: 0x15CA720 VA: 0x1815CC120
	private Task WriteIntegerValueAsync(Task task, ulong uvalue, bool negative, CancellationToken cancellationToken) { }

	// RVA: 0x15CC0E0 Offset: 0x15CA6E0 VA: 0x1815CC0E0
	internal Task WriteIntegerValueAsync(long value, CancellationToken cancellationToken) { }

	// RVA: 0x15CC270 Offset: 0x15CA870 VA: 0x1815CC270
	internal Task WriteIntegerValueAsync(ulong uvalue, CancellationToken cancellationToken) { }

	// RVA: 0x15CB7B0 Offset: 0x15C9DB0 VA: 0x1815CB7B0
	private Task WriteEscapedStringAsync(string value, bool quote, CancellationToken cancellationToken) { }

	// RVA: 0x15CC8F0 Offset: 0x15CAEF0 VA: 0x1815CC8F0 Slot: 17
	public override Task WritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x15C8B70 Offset: 0x15C7170 VA: 0x1815C8B70
	internal Task DoWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWritePropertyNameAsync>d__29))]
	// RVA: 0x15C8A30 Offset: 0x15C7030 VA: 0x1815C8A30
	private Task DoWritePropertyNameAsync(Task task, string name, CancellationToken cancellationToken) { }

	// RVA: 0x15CC7A0 Offset: 0x15CADA0 VA: 0x1815CC7A0 Slot: 18
	public override Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWritePropertyNameAsync>d__31))]
	// RVA: 0x15C8900 Offset: 0x15C6F00 VA: 0x1815C8900
	internal Task DoWritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken) { }

	// RVA: 0x15CCD10 Offset: 0x15CB310 VA: 0x1815CCD10 Slot: 19
	public override Task WriteStartArrayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C9120 Offset: 0x15C7720 VA: 0x1815C9120
	internal Task DoWriteStartArrayAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteStartArrayAsync>d__34))]
	// RVA: 0x15C92D0 Offset: 0x15C78D0 VA: 0x1815C92D0
	internal Task DoWriteStartArrayAsync(Task task, CancellationToken cancellationToken) { }

	// RVA: 0x15CD130 Offset: 0x15CB730 VA: 0x1815CD130 Slot: 23
	public override Task WriteStartObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C9510 Offset: 0x15C7B10 VA: 0x1815C9510
	internal Task DoWriteStartObjectAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteStartObjectAsync>d__37))]
	// RVA: 0x15C96C0 Offset: 0x15C7CC0 VA: 0x1815C96C0
	internal Task DoWriteStartObjectAsync(Task task, CancellationToken cancellationToken) { }

	// RVA: 0x15CCF50 Offset: 0x15CB550 VA: 0x1815CCF50 Slot: 22
	public override Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteStartConstructorAsync>d__39))]
	// RVA: 0x15C93F0 Offset: 0x15C79F0 VA: 0x1815C93F0
	internal Task DoWriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x15CD370 Offset: 0x15CB970 VA: 0x1815CD370 Slot: 63
	public override Task WriteUndefinedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15C97E0 Offset: 0x15C7DE0 VA: 0x1815C97E0
	internal Task DoWriteUndefinedAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteUndefinedAsync>d__42))]
	// RVA: 0x15C99B0 Offset: 0x15C7FB0 VA: 0x1815C99B0
	private Task DoWriteUndefinedAsync(Task task, CancellationToken cancellationToken) { }

	// RVA: 0x15D0DA0 Offset: 0x15CF3A0 VA: 0x1815D0DA0 Slot: 64
	public override Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken) { }

	// RVA: 0x15CAD90 Offset: 0x15C9390 VA: 0x1815CAD90
	internal Task DoWriteWhitespaceAsync(string ws, CancellationToken cancellationToken) { }

	// RVA: 0x15CDDB0 Offset: 0x15CC3B0 VA: 0x1815CDDB0 Slot: 25
	public override Task WriteValueAsync(bool value, CancellationToken cancellationToken) { }

	// RVA: 0x15CA740 Offset: 0x15C8D40 VA: 0x1815CA740
	internal Task DoWriteValueAsync(bool value, CancellationToken cancellationToken) { }

	// RVA: 0x15CE750 Offset: 0x15CCD50 VA: 0x1815CE750 Slot: 26
	public override Task WriteValueAsync(Nullable<bool> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CA6B0 Offset: 0x15C8CB0 VA: 0x1815CA6B0
	internal Task DoWriteValueAsync(Nullable<bool> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CEBA0 Offset: 0x15CD1A0 VA: 0x1815CEBA0 Slot: 27
	public override Task WriteValueAsync(byte value, CancellationToken cancellationToken) { }

	// RVA: 0x15CE6A0 Offset: 0x15CCCA0 VA: 0x1815CE6A0 Slot: 28
	public override Task WriteValueAsync(Nullable<byte> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CA620 Offset: 0x15C8C20 VA: 0x1815CA620
	internal Task DoWriteValueAsync(Nullable<byte> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CE330 Offset: 0x15CC930 VA: 0x1815CE330 Slot: 29
	public override Task WriteValueAsync(byte[] value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteValueNonNullAsync>d__53))]
	// RVA: 0x15CF4C0 Offset: 0x15CDAC0 VA: 0x1815CF4C0
	internal Task WriteValueNonNullAsync(byte[] value, CancellationToken cancellationToken) { }

	// RVA: 0x15CDEC0 Offset: 0x15CC4C0 VA: 0x1815CDEC0 Slot: 30
	public override Task WriteValueAsync(char value, CancellationToken cancellationToken) { }

	// RVA: 0x15CA460 Offset: 0x15C8A60 VA: 0x1815CA460
	internal Task DoWriteValueAsync(char value, CancellationToken cancellationToken) { }

	// RVA: 0x15CEB00 Offset: 0x15CD100 VA: 0x1815CEB00 Slot: 31
	public override Task WriteValueAsync(Nullable<char> value, CancellationToken cancellationToken) { }

	// RVA: 0x15C9F60 Offset: 0x15C8560 VA: 0x1815C9F60
	internal Task DoWriteValueAsync(Nullable<char> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CE2E0 Offset: 0x15CC8E0 VA: 0x1815CE2E0 Slot: 32
	public override Task WriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__59))]
	// RVA: 0x15CA350 Offset: 0x15C8950 VA: 0x1815CA350
	internal Task DoWriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	// RVA: 0x15CDAE0 Offset: 0x15CC0E0 VA: 0x1815CDAE0 Slot: 33
	public override Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CA7C0 Offset: 0x15C8DC0 VA: 0x1815CA7C0
	internal Task DoWriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CDEE0 Offset: 0x15CC4E0 VA: 0x1815CDEE0 Slot: 34
	public override Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__63))]
	// RVA: 0x15CA100 Offset: 0x15C8700 VA: 0x1815CA100
	internal Task DoWriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	// RVA: 0x15CE480 Offset: 0x15CCA80 VA: 0x1815CE480 Slot: 35
	public override Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	// RVA: 0x15C9AD0 Offset: 0x15C80D0 VA: 0x1815C9AD0
	internal Task DoWriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CD820 Offset: 0x15CBE20 VA: 0x1815CD820 Slot: 36
	public override Task WriteValueAsync(Decimal value, CancellationToken cancellationToken) { }

	// RVA: 0x15CAAE0 Offset: 0x15C90E0 VA: 0x1815CAAE0
	internal Task DoWriteValueAsync(Decimal value, CancellationToken cancellationToken) { }

	// RVA: 0x15CD6D0 Offset: 0x15CBCD0 VA: 0x1815CD6D0 Slot: 37
	public override Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CA840 Offset: 0x15C8E40 VA: 0x1815CA840
	internal Task DoWriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CE530 Offset: 0x15CCB30 VA: 0x1815CE530 Slot: 38
	public override Task WriteValueAsync(double value, CancellationToken cancellationToken) { }

	// RVA: 0x15CD610 Offset: 0x15CBC10 VA: 0x1815CD610
	internal Task WriteValueAsync(double value, bool nullable, CancellationToken cancellationToken) { }

	// RVA: 0x15CEBE0 Offset: 0x15CD1E0 VA: 0x1815CEBE0 Slot: 39
	public override Task WriteValueAsync(Nullable<double> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CE300 Offset: 0x15CC900 VA: 0x1815CE300 Slot: 40
	public override Task WriteValueAsync(float value, CancellationToken cancellationToken) { }

	// RVA: 0x15CE560 Offset: 0x15CCB60 VA: 0x1815CE560
	internal Task WriteValueAsync(float value, bool nullable, CancellationToken cancellationToken) { }

	// RVA: 0x15CE220 Offset: 0x15CC820 VA: 0x1815CE220 Slot: 41
	public override Task WriteValueAsync(Nullable<float> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CEA10 Offset: 0x15CD010 VA: 0x1815CEA10 Slot: 42
	public override Task WriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__77))]
	// RVA: 0x15CA9D0 Offset: 0x15C8FD0 VA: 0x1815CA9D0
	internal Task DoWriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	// RVA: 0x15CDC30 Offset: 0x15CC230 VA: 0x1815CDC30 Slot: 43
	public override Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CAB70 Offset: 0x15C9170 VA: 0x1815CAB70
	internal Task DoWriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CEFC0 Offset: 0x15CD5C0 VA: 0x1815CEFC0 Slot: 44
	public override Task WriteValueAsync(int value, CancellationToken cancellationToken) { }

	// RVA: 0x15CF010 Offset: 0x15CD610 VA: 0x1815CF010 Slot: 45
	public override Task WriteValueAsync(Nullable<int> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CA920 Offset: 0x15C8F20 VA: 0x1815CA920
	internal Task DoWriteValueAsync(Nullable<int> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CE980 Offset: 0x15CCF80 VA: 0x1815CE980 Slot: 46
	public override Task WriteValueAsync(long value, CancellationToken cancellationToken) { }

	// RVA: 0x15CEA40 Offset: 0x15CD040 VA: 0x1815CEA40 Slot: 47
	public override Task WriteValueAsync(Nullable<long> value, CancellationToken cancellationToken) { }

	// RVA: 0x15C9BE0 Offset: 0x15C81E0 VA: 0x1815C9BE0
	internal Task DoWriteValueAsync(Nullable<long> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CE160 Offset: 0x15CC760 VA: 0x1815CE160
	internal Task WriteValueAsync(BigInteger value, CancellationToken cancellationToken) { }

	// RVA: 0x15CD8E0 Offset: 0x15CBEE0 VA: 0x1815CD8E0 Slot: 48
	public override Task WriteValueAsync(object value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15CE650 Offset: 0x15CCC50 VA: 0x1815CE650 Slot: 49
	public override Task WriteValueAsync(sbyte value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15CE8B0 Offset: 0x15CCEB0 VA: 0x1815CE8B0 Slot: 50
	public override Task WriteValueAsync(Nullable<sbyte> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CA570 Offset: 0x15C8B70 VA: 0x1815CA570
	internal Task DoWriteValueAsync(Nullable<sbyte> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CD7D0 Offset: 0x15CBDD0 VA: 0x1815CD7D0 Slot: 51
	public override Task WriteValueAsync(short value, CancellationToken cancellationToken) { }

	// RVA: 0x15CDCE0 Offset: 0x15CC2E0 VA: 0x1815CDCE0 Slot: 52
	public override Task WriteValueAsync(Nullable<short> value, CancellationToken cancellationToken) { }

	// RVA: 0x15C9C90 Offset: 0x15C8290 VA: 0x1815C9C90
	internal Task DoWriteValueAsync(Nullable<short> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CED70 Offset: 0x15CD370 VA: 0x1815CED70 Slot: 53
	public override Task WriteValueAsync(string value, CancellationToken cancellationToken) { }

	// RVA: 0x15C9D40 Offset: 0x15C8340 VA: 0x1815C9D40
	internal Task DoWriteValueAsync(string value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__96))]
	// RVA: 0x15CA210 Offset: 0x15C8810 VA: 0x1815CA210
	private Task DoWriteValueAsync(Task task, string value, CancellationToken cancellationToken) { }

	// RVA: 0x15CECB0 Offset: 0x15CD2B0 VA: 0x1815CECB0 Slot: 54
	public override Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteValueAsync>d__98))]
	// RVA: 0x15C9FF0 Offset: 0x15C85F0 VA: 0x1815C9FF0
	internal Task DoWriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	// RVA: 0x15CECD0 Offset: 0x15CD2D0 VA: 0x1815CECD0 Slot: 55
	public override Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	// RVA: 0x15C9B60 Offset: 0x15C8160 VA: 0x1815C9B60
	internal Task DoWriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15CDDD0 Offset: 0x15CC3D0 VA: 0x1815CDDD0 Slot: 56
	public override Task WriteValueAsync(uint value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15CDB80 Offset: 0x15CC180 VA: 0x1815CDB80 Slot: 57
	public override Task WriteValueAsync(Nullable<uint> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CA4E0 Offset: 0x15C8AE0 VA: 0x1815CA4E0
	internal Task DoWriteValueAsync(Nullable<uint> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15CE620 Offset: 0x15CCC20 VA: 0x1815CE620 Slot: 58
	public override Task WriteValueAsync(ulong value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15CDE10 Offset: 0x15CC410 VA: 0x1815CDE10 Slot: 59
	public override Task WriteValueAsync(Nullable<ulong> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CAC90 Offset: 0x15C9290 VA: 0x1815CAC90
	internal Task DoWriteValueAsync(Nullable<ulong> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CDF10 Offset: 0x15CC510 VA: 0x1815CDF10 Slot: 60
	public override Task WriteValueAsync(Uri value, CancellationToken cancellationToken) { }

	// RVA: 0x15CF720 Offset: 0x15CDD20 VA: 0x1815CF720
	internal Task WriteValueNotNullAsync(Uri value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<WriteValueNotNullAsync>d__109))]
	// RVA: 0x15CF5E0 Offset: 0x15CDBE0 VA: 0x1815CF5E0
	internal Task WriteValueNotNullAsync(Task task, Uri value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15CE9D0 Offset: 0x15CCFD0 VA: 0x1815CE9D0 Slot: 61
	public override Task WriteValueAsync(ushort value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15CE800 Offset: 0x15CCE00 VA: 0x1815CE800 Slot: 62
	public override Task WriteValueAsync(Nullable<ushort> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CAC00 Offset: 0x15C9200 VA: 0x1815CAC00
	internal Task DoWriteValueAsync(Nullable<ushort> value, CancellationToken cancellationToken) { }

	// RVA: 0x15CB1B0 Offset: 0x15C97B0 VA: 0x1815CB1B0 Slot: 20
	public override Task WriteCommentAsync(string text, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteCommentAsync>d__114))]
	// RVA: 0x15C83F0 Offset: 0x15C69F0 VA: 0x1815C83F0
	internal Task DoWriteCommentAsync(string text, CancellationToken cancellationToken) { }

	// RVA: 0x15CB480 Offset: 0x15C9A80 VA: 0x1815CB480 Slot: 13
	public override Task WriteEndArrayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CB660 Offset: 0x15C9C60 VA: 0x1815CB660 Slot: 14
	public override Task WriteEndConstructorAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CB680 Offset: 0x15C9C80 VA: 0x1815CB680 Slot: 15
	public override Task WriteEndObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CCAE0 Offset: 0x15CB0E0 VA: 0x1815CCAE0 Slot: 21
	public override Task WriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x15C8E30 Offset: 0x15C7430 VA: 0x1815C8E30
	internal Task DoWriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonTextWriter.<DoWriteRawValueAsync>d__120))]
	// RVA: 0x15C8FE0 Offset: 0x15C75E0 VA: 0x1815C8FE0
	private Task DoWriteRawValueAsync(Task task, string json, CancellationToken cancellationToken) { }

	// RVA: 0x15CAE10 Offset: 0x15C9410 VA: 0x1815CAE10
	internal char[] EnsureWriteBuffer(int length, int copyTo) { }

	// RVA: 0x15D0FD0 Offset: 0x15CF5D0 VA: 0x1815D0FD0
	private Base64Encoder get_Base64Encoder() { }

	[NullableContext(2)]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public IArrayPool<char> get_ArrayPool() { }

	[NullableContext(2)]
	// RVA: 0x15D1090 Offset: 0x15CF690 VA: 0x1815D1090
	public void set_ArrayPool(IArrayPool<char> value) { }

	// RVA: 0x15D1060 Offset: 0x15CF660 VA: 0x1815D1060
	public int get_Indentation() { }

	// RVA: 0x15D1140 Offset: 0x15CF740 VA: 0x1815D1140
	public void set_Indentation(int value) { }

	// RVA: 0x15D1070 Offset: 0x15CF670 VA: 0x1815D1070
	public char get_QuoteChar() { }

	// RVA: 0x15D11B0 Offset: 0x15CF7B0 VA: 0x1815D11B0
	public void set_QuoteChar(char value) { }

	// RVA: 0x15D1050 Offset: 0x15CF650 VA: 0x1815D1050
	public char get_IndentChar() { }

	// RVA: 0x15D1110 Offset: 0x15CF710 VA: 0x1815D1110
	public void set_IndentChar(char value) { }

	// RVA: 0x15D1080 Offset: 0x15CF680 VA: 0x1815D1080
	public bool get_QuoteName() { }

	// RVA: 0x15D1230 Offset: 0x15CF830 VA: 0x1815D1230
	public void set_QuoteName(bool value) { }

	// RVA: 0x15D0E90 Offset: 0x15CF490 VA: 0x1815D0E90
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0x15CAFE0 Offset: 0x15C95E0 VA: 0x1815CAFE0 Slot: 66
	public override void Flush() { }

	// RVA: 0x15C8200 Offset: 0x15C6800 VA: 0x1815C8200 Slot: 67
	public override void Close() { }

	// RVA: 0x15C8190 Offset: 0x15C6790 VA: 0x1815C8190
	private void CloseBufferAndWriter() { }

	// RVA: 0x15CD320 Offset: 0x15CB920 VA: 0x1815CD320 Slot: 68
	public override void WriteStartObject() { }

	// RVA: 0x15CCF00 Offset: 0x15CB500 VA: 0x1815CCF00 Slot: 70
	public override void WriteStartArray() { }

	// RVA: 0x15CD080 Offset: 0x15CB680 VA: 0x1815CD080 Slot: 72
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x15CB6A0 Offset: 0x15C9CA0 VA: 0x1815CB6A0 Slot: 78
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0x15CC910 Offset: 0x15CAF10 VA: 0x1815CC910 Slot: 74
	public override void WritePropertyName(string name) { }

	// RVA: 0x15CC970 Offset: 0x15CAF70 VA: 0x1815CC970 Slot: 75
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x15CB010 Offset: 0x15C9610 VA: 0x1815CB010 Slot: 65
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0x15CB130 Offset: 0x15C9730 VA: 0x1815CB130
	private void UpdateCharEscapeFlags() { }

	// RVA: 0x15CBD40 Offset: 0x15CA340 VA: 0x1815CBD40 Slot: 79
	protected override void WriteIndent() { }

	// RVA: 0x15CB020 Offset: 0x15C9620 VA: 0x1815CB020
	private int SetIndentChars() { }

	// RVA: 0x15CF160 Offset: 0x15CD760 VA: 0x1815CF160 Slot: 80
	protected override void WriteValueDelimiter() { }

	// RVA: 0x15CBD10 Offset: 0x15CA310 VA: 0x1815CBD10 Slot: 81
	protected override void WriteIndentSpace() { }

	// RVA: 0x15CF490 Offset: 0x15CDA90 VA: 0x1815CF490
	private void WriteValueInternal(string value, JsonToken token) { }

	[NullableContext(2)]
	// RVA: 0x15CFD20 Offset: 0x15CE320 VA: 0x1815CFD20 Slot: 123
	public override void WriteValue(object value) { }

	// RVA: 0x15CC500 Offset: 0x15CAB00 VA: 0x1815CC500 Slot: 82
	public override void WriteNull() { }

	// RVA: 0x15CD580 Offset: 0x15CBB80 VA: 0x1815CD580 Slot: 83
	public override void WriteUndefined() { }

	[NullableContext(2)]
	// RVA: 0x15CCCC0 Offset: 0x15CB2C0 VA: 0x1815CCCC0 Slot: 84
	public override void WriteRaw(string json) { }

	[NullableContext(2)]
	// RVA: 0x15D0500 Offset: 0x15CEB00 VA: 0x1815D0500 Slot: 86
	public override void WriteValue(string value) { }

	// RVA: 0x15CB890 Offset: 0x15C9E90 VA: 0x1815CB890
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0x15CFE50 Offset: 0x15CE450 VA: 0x1815CFE50 Slot: 87
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x15D0100 Offset: 0x15CE700 VA: 0x1815D0100 Slot: 88
	public override void WriteValue(uint value) { }

	// RVA: 0x15D0B70 Offset: 0x15CF170 VA: 0x1815D0B70 Slot: 89
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x15D0B30 Offset: 0x15CF130 VA: 0x1815D0B30 Slot: 90
	public override void WriteValue(ulong value) { }

	// RVA: 0x15D0BF0 Offset: 0x15CF1F0 VA: 0x1815D0BF0 Slot: 91
	public override void WriteValue(float value) { }

	// RVA: 0x15D0CB0 Offset: 0x15CF2B0 VA: 0x1815D0CB0 Slot: 108
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0x15D0A70 Offset: 0x15CF070 VA: 0x1815D0A70 Slot: 92
	public override void WriteValue(double value) { }

	// RVA: 0x15CFE90 Offset: 0x15CE490 VA: 0x1815CFE90 Slot: 109
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0x15D02E0 Offset: 0x15CE8E0 VA: 0x1815D02E0 Slot: 93
	public override void WriteValue(bool value) { }

	// RVA: 0x15CFF90 Offset: 0x15CE590 VA: 0x1815CFF90 Slot: 94
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x15D00C0 Offset: 0x15CE6C0 VA: 0x1815D00C0 Slot: 95
	public override void WriteValue(ushort value) { }

	// RVA: 0x15D09E0 Offset: 0x15CEFE0 VA: 0x1815D09E0 Slot: 96
	public override void WriteValue(char value) { }

	// RVA: 0x15D09A0 Offset: 0x15CEFA0 VA: 0x1815D09A0 Slot: 97
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x15D04C0 Offset: 0x15CEAC0 VA: 0x1815D04C0 Slot: 98
	public override void WriteValue(sbyte value) { }

	// RVA: 0x15D0370 Offset: 0x15CE970 VA: 0x1815D0370 Slot: 99
	public override void WriteValue(Decimal value) { }

	// RVA: 0x15D05B0 Offset: 0x15CEBB0 VA: 0x1815D05B0 Slot: 100
	public override void WriteValue(DateTime value) { }

	// RVA: 0x15CFAC0 Offset: 0x15CE0C0 VA: 0x1815CFAC0
	private int WriteValueToBuffer(DateTime value) { }

	[NullableContext(2)]
	// RVA: 0x15CFC40 Offset: 0x15CE240 VA: 0x1815CFC40 Slot: 121
	public override void WriteValue(byte[] value) { }

	// RVA: 0x15D0170 Offset: 0x15CE770 VA: 0x1815D0170 Slot: 101
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x15CF8F0 Offset: 0x15CDEF0 VA: 0x1815CF8F0
	private int WriteValueToBuffer(DateTimeOffset value) { }

	// RVA: 0x15CFFD0 Offset: 0x15CE5D0 VA: 0x1815CFFD0 Slot: 102
	public override void WriteValue(Guid value) { }

	// RVA: 0x15D08A0 Offset: 0x15CEEA0 VA: 0x1815D08A0 Slot: 103
	public override void WriteValue(TimeSpan value) { }

	[NullableContext(2)]
	// RVA: 0x15D0410 Offset: 0x15CEA10 VA: 0x1815D0410 Slot: 122
	public override void WriteValue(Uri value) { }

	[NullableContext(2)]
	// RVA: 0x15CB2E0 Offset: 0x15C98E0 VA: 0x1815CB2E0 Slot: 124
	public override void WriteComment(string text) { }

	// RVA: 0x15D0E40 Offset: 0x15CF440 VA: 0x1815D0E40 Slot: 125
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x15CAEF0 Offset: 0x15C94F0 VA: 0x1815CAEF0
	private void EnsureWriteBuffer() { }

	// RVA: 0x15CC480 Offset: 0x15CAA80 VA: 0x1815CC480
	private void WriteIntegerValue(long value) { }

	// RVA: 0x15CC290 Offset: 0x15CA890 VA: 0x1815CC290
	private void WriteIntegerValue(ulong value, bool negative) { }

	// RVA: 0x15CC590 Offset: 0x15CAB90 VA: 0x1815CC590
	private int WriteNumberToBuffer(ulong value, bool negative) { }

	// RVA: 0x15CC3B0 Offset: 0x15CA9B0 VA: 0x1815CC3B0
	private void WriteIntegerValue(int value) { }

	// RVA: 0x15CC320 Offset: 0x15CA920 VA: 0x1815CC320
	private void WriteIntegerValue(uint value, bool negative) { }

	// RVA: 0x15CC6B0 Offset: 0x15CACB0 VA: 0x1815CC6B0
	private int WriteNumberToBuffer(uint value, bool negative) { }
}

// Namespace: Newtonsoft.Json
public enum JsonToken // TypeDefIndex: 8224
{
	// Fields
	public int value__; // 0x0
	public const JsonToken None = 0;
	public const JsonToken StartObject = 1;
	public const JsonToken StartArray = 2;
	public const JsonToken StartConstructor = 3;
	public const JsonToken PropertyName = 4;
	public const JsonToken Comment = 5;
	public const JsonToken Raw = 6;
	public const JsonToken Integer = 7;
	public const JsonToken Float = 8;
	public const JsonToken String = 9;
	public const JsonToken Boolean = 10;
	public const JsonToken Null = 11;
	public const JsonToken Undefined = 12;
	public const JsonToken EndObject = 13;
	public const JsonToken EndArray = 14;
	public const JsonToken EndConstructor = 15;
	public const JsonToken Date = 16;
	public const JsonToken Bytes = 17;
}

// Namespace: Newtonsoft.Json
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonValidatingReader : JsonReader, IJsonLineInfo // TypeDefIndex: 8228
{
	// Fields
	private readonly JsonReader _reader; // 0x78
	private readonly Stack<JsonValidatingReader.SchemaScope> _stack; // 0x80
	private JsonSchema _schema; // 0x88
	private JsonSchemaModel _model; // 0x90
	private JsonValidatingReader.SchemaScope _currentScope; // 0x98
	[CompilerGenerated]
	private ValidationEventHandler ValidationEventHandler; // 0xA0
	private static readonly IList<JsonSchemaModel> EmptySchemaList; // 0x0

	// Properties
	public override object Value { get; }
	public override int Depth { get; }
	public override string Path { get; }
	public override char QuoteChar { get; set; }
	public override JsonToken TokenType { get; }
	public override Type ValueType { get; }
	private IList<JsonSchemaModel> CurrentSchemas { get; }
	private IList<JsonSchemaModel> CurrentMemberSchemas { get; }
	public JsonSchema Schema { get; set; }
	public JsonReader Reader { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x15E33F0 Offset: 0x15E19F0 VA: 0x1815E33F0
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x15E3FA0 Offset: 0x15E25A0 VA: 0x1815E3FA0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x15E3F70 Offset: 0x15E2570 VA: 0x1815E3F70 Slot: 17
	public override object get_Value() { }

	// RVA: 0x15E3E80 Offset: 0x15E2480 VA: 0x1815E3E80 Slot: 19
	public override int get_Depth() { }

	// RVA: 0x15E3EB0 Offset: 0x15E24B0 VA: 0x1815E3EB0 Slot: 20
	public override string get_Path() { }

	// RVA: 0x15E3EE0 Offset: 0x15E24E0 VA: 0x1815E3EE0 Slot: 14
	public override char get_QuoteChar() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 15
	protected internal override void set_QuoteChar(char value) { }

	// RVA: 0x15E3F10 Offset: 0x15E2510 VA: 0x1815E3F10 Slot: 16
	public override JsonToken get_TokenType() { }

	// RVA: 0x15E3F40 Offset: 0x15E2540 VA: 0x1815E3F40 Slot: 18
	public override Type get_ValueType() { }

	// RVA: 0x15DFAE0 Offset: 0x15DE0E0 VA: 0x1815DFAE0
	private void Push(JsonValidatingReader.SchemaScope scope) { }

	// RVA: 0x15DF750 Offset: 0x15DDD50 VA: 0x1815DF750
	private JsonValidatingReader.SchemaScope Pop() { }

	// RVA: 0x15E3E60 Offset: 0x15E2460 VA: 0x1815E3E60
	private IList<JsonSchemaModel> get_CurrentSchemas() { }

	// RVA: 0x15E34A0 Offset: 0x15E1AA0 VA: 0x1815E34A0
	private IList<JsonSchemaModel> get_CurrentMemberSchemas() { }

	// RVA: 0x15DFB50 Offset: 0x15DE150 VA: 0x1815DFB50
	private void RaiseError(string message, JsonSchemaModel schema) { }

	// RVA: 0x15DF6B0 Offset: 0x15DDCB0 VA: 0x1815DF6B0
	private void OnValidationEvent(JsonSchemaException exception) { }

	// RVA: 0x15E3340 Offset: 0x15E1940 VA: 0x1815E3340
	public void .ctor(JsonReader reader) { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	public JsonSchema get_Schema() { }

	// RVA: 0x15E4050 Offset: 0x15E2650 VA: 0x1815E4050
	public void set_Schema(JsonSchema value) { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public JsonReader get_Reader() { }

	// RVA: 0x15DF050 Offset: 0x15DD650 VA: 0x1815DF050 Slot: 31
	public override void Close() { }

	// RVA: 0x15E2160 Offset: 0x15E0760 VA: 0x1815E2160
	private void ValidateNotDisallowed(JsonSchemaModel schema) { }

	// RVA: 0x15DF100 Offset: 0x15DD700 VA: 0x1815DF100
	private Nullable<JsonSchemaType> GetCurrentNodeSchemaType() { }

	// RVA: 0x15DFFB0 Offset: 0x15DE5B0 VA: 0x1815DFFB0 Slot: 22
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x15DFDE0 Offset: 0x15DE3E0 VA: 0x1815DFDE0 Slot: 24
	public override byte[] ReadAsBytes() { }

	// RVA: 0x15DFEF0 Offset: 0x15DE4F0 VA: 0x1815DFEF0 Slot: 27
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x15DFF50 Offset: 0x15DE550 VA: 0x1815DFF50 Slot: 25
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x15DFD90 Offset: 0x15DE390 VA: 0x1815DFD90 Slot: 26
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x15E0000 Offset: 0x15DE600 VA: 0x1815E0000 Slot: 23
	public override string ReadAsString() { }

	// RVA: 0x15DFE90 Offset: 0x15DE490 VA: 0x1815DFE90 Slot: 28
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x15DFE30 Offset: 0x15DE430 VA: 0x1815DFE30 Slot: 29
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x15E0050 Offset: 0x15DE650 VA: 0x1815E0050 Slot: 21
	public override bool Read() { }

	// RVA: 0x15E0260 Offset: 0x15DE860 VA: 0x1815E0260
	private void ValidateCurrentToken() { }

	// RVA: 0x15E2A10 Offset: 0x15E1010 VA: 0x1815E2A10
	private void WriteToken(IList<JsonSchemaModel> schemas) { }

	// RVA: 0x15E1160 Offset: 0x15DF760 VA: 0x1815E1160
	private void ValidateEndObject(JsonSchemaModel schema) { }

	// RVA: 0x15E0F60 Offset: 0x15DF560 VA: 0x1815E0F60
	private void ValidateEndArray(JsonSchemaModel schema) { }

	// RVA: 0x15E2420 Offset: 0x15E0A20 VA: 0x1815E2420
	private void ValidateNull(JsonSchemaModel schema) { }

	// RVA: 0x15E0220 Offset: 0x15DE820 VA: 0x1815E0220
	private void ValidateBoolean(JsonSchemaModel schema) { }

	// RVA: 0x15E2650 Offset: 0x15E0C50 VA: 0x1815E2650
	private void ValidateString(JsonSchemaModel schema) { }

	// RVA: 0x15E1A80 Offset: 0x15E0080 VA: 0x1815E1A80
	private void ValidateInteger(JsonSchemaModel schema) { }

	// RVA: 0x15DF800 Offset: 0x15DDE00 VA: 0x1815DF800
	private void ProcessValue() { }

	// RVA: 0x15E1510 Offset: 0x15DFB10 VA: 0x1815E1510
	private void ValidateFloat(JsonSchemaModel schema) { }

	// RVA: 0x15DF090 Offset: 0x15DD690 VA: 0x1815DF090
	private static double FloatingPointRemainder(double dividend, double divisor) { }

	// RVA: 0x15DF530 Offset: 0x15DDB30 VA: 0x1815DF530
	private static bool IsZero(double value) { }

	// RVA: 0x15E2480 Offset: 0x15E0A80 VA: 0x1815E2480
	private void ValidatePropertyName(JsonSchemaModel schema) { }

	// RVA: 0x15DF2D0 Offset: 0x15DD8D0 VA: 0x1815DF2D0
	private bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName) { }

	// RVA: 0x15E0200 Offset: 0x15DE800 VA: 0x1815E0200
	private bool ValidateArray(JsonSchemaModel schema) { }

	// RVA: 0x15E2460 Offset: 0x15E0A60 VA: 0x1815E2460
	private bool ValidateObject(JsonSchemaModel schema) { }

	// RVA: 0x15E00C0 Offset: 0x15DE6C0 VA: 0x1815E00C0
	private bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType) { }

	// RVA: 0x15DF590 Offset: 0x15DDB90 VA: 0x1815DF590 Slot: 32
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x15DF5F0 Offset: 0x15DDBF0 VA: 0x1815DF5F0 Slot: 33
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x15DF650 Offset: 0x15DDC50 VA: 0x1815DF650 Slot: 34
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x15E32B0 Offset: 0x15E18B0 VA: 0x1815E32B0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public abstract class JsonWriter : IDisposable // TypeDefIndex: 8239
{
	// Fields
	private static readonly JsonWriter.State[][] StateArray; // 0x0
	internal static readonly JsonWriter.State[][] StateArrayTemplate; // 0x8
	[Nullable(2)]
	private List<JsonPosition> _stack; // 0x10
	private JsonPosition _currentPosition; // 0x18
	private JsonWriter.State _currentState; // 0x30
	private Formatting _formatting; // 0x34
	[CompilerGenerated]
	private bool <CloseOutput>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <AutoCompleteOnClose>k__BackingField; // 0x39
	private DateFormatHandling _dateFormatHandling; // 0x3C
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
	private StringEscapeHandling _stringEscapeHandling; // 0x44
	private FloatFormatHandling _floatFormatHandling; // 0x48
	[Nullable(2)]
	private string _dateFormatString; // 0x50
	[Nullable(2)]
	private CultureInfo _culture; // 0x58

	// Properties
	public bool CloseOutput { get; set; }
	public bool AutoCompleteOnClose { get; set; }
	protected internal int Top { get; }
	public WriteState WriteState { get; }
	internal string ContainerPath { get; }
	public string Path { get; }
	public Formatting Formatting { get; set; }
	public DateFormatHandling DateFormatHandling { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public StringEscapeHandling StringEscapeHandling { get; set; }
	public FloatFormatHandling FloatFormatHandling { get; set; }
	[Nullable(2)]
	public string DateFormatString { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x15E4170 Offset: 0x15E2770 VA: 0x1815E4170
	internal Task AutoCompleteAsync(JsonToken tokenBeingWritten, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<AutoCompleteAsync>d__1))]
	// RVA: 0x15E4470 Offset: 0x15E2A70 VA: 0x1815E4470
	private Task AutoCompleteAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E4C10 Offset: 0x15E3210 VA: 0x1815E4C10 Slot: 5
	public virtual Task CloseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E4E30 Offset: 0x15E3430 VA: 0x1815E4E30 Slot: 6
	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E6AE0 Offset: 0x15E50E0 VA: 0x1815E6AE0 Slot: 7
	protected virtual Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x15E70D0 Offset: 0x15E56D0 VA: 0x1815E70D0 Slot: 8
	protected virtual Task WriteIndentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15ECAD0 Offset: 0x15EB0D0 VA: 0x1815ECAD0 Slot: 9
	protected virtual Task WriteValueDelimiterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E71A0 Offset: 0x15E57A0 VA: 0x1815E71A0 Slot: 10
	protected virtual Task WriteIndentSpaceAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E7560 Offset: 0x15E5B60 VA: 0x1815E7560 Slot: 11
	public virtual Task WriteRawAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x15E6A10 Offset: 0x15E5010 VA: 0x1815E6A10 Slot: 12
	public virtual Task WriteEndAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E6CA0 Offset: 0x15E52A0 VA: 0x1815E6CA0
	internal Task WriteEndInternalAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E4FE0 Offset: 0x15E35E0 VA: 0x1815E4FE0
	internal Task InternalWriteEndAsync(JsonContainerType type, CancellationToken cancellationToken) { }

	// RVA: 0x15E6930 Offset: 0x15E4F30 VA: 0x1815E6930 Slot: 13
	public virtual Task WriteEndArrayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E6BC0 Offset: 0x15E51C0 VA: 0x1815E6BC0 Slot: 14
	public virtual Task WriteEndConstructorAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E6E20 Offset: 0x15E5420 VA: 0x1815E6E20 Slot: 15
	public virtual Task WriteEndObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E7270 Offset: 0x15E5870 VA: 0x1815E7270 Slot: 16
	public virtual Task WriteNullAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E7360 Offset: 0x15E5960 VA: 0x1815E7360 Slot: 17
	public virtual Task WritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x15E7440 Offset: 0x15E5A40 VA: 0x1815E7440 Slot: 18
	public virtual Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken) { }

	// RVA: 0x15E5260 Offset: 0x15E3860 VA: 0x1815E5260
	internal Task InternalWritePropertyNameAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x15E7770 Offset: 0x15E5D70 VA: 0x1815E7770 Slot: 19
	public virtual Task WriteStartArrayAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<InternalWriteStartAsync>d__20))]
	// RVA: 0x15E5350 Offset: 0x15E3950 VA: 0x1815E5350
	internal Task InternalWriteStartAsync(JsonToken token, JsonContainerType container, CancellationToken cancellationToken) { }

	// RVA: 0x15E6670 Offset: 0x15E4C70 VA: 0x1815E6670 Slot: 20
	public virtual Task WriteCommentAsync(string text, CancellationToken cancellationToken) { }

	// RVA: 0x15E4FC0 Offset: 0x15E35C0 VA: 0x1815E4FC0
	internal Task InternalWriteCommentAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E7640 Offset: 0x15E5C40 VA: 0x1815E7640 Slot: 21
	public virtual Task WriteRawValueAsync(string json, CancellationToken cancellationToken) { }

	// RVA: 0x15E7880 Offset: 0x15E5E80 VA: 0x1815E7880 Slot: 22
	public virtual Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken) { }

	// RVA: 0x15E79A0 Offset: 0x15E5FA0 VA: 0x1815E79A0 Slot: 23
	public virtual Task WriteStartObjectAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15E7BF0 Offset: 0x15E61F0 VA: 0x1815E7BF0
	public Task WriteTokenAsync(JsonReader reader, CancellationToken cancellationToken) { }

	// RVA: 0x15E8650 Offset: 0x15E6C50 VA: 0x1815E8650
	public Task WriteTokenAsync(JsonReader reader, bool writeChildren, CancellationToken cancellationToken) { }

	// RVA: 0x15E86F0 Offset: 0x15E6CF0 VA: 0x1815E86F0
	public Task WriteTokenAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x15E7C80 Offset: 0x15E6280 VA: 0x1815E7C80
	public Task WriteTokenAsync(JsonToken token, object value, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<WriteTokenAsync>d__30))]
	// RVA: 0x15E7AB0 Offset: 0x15E60B0 VA: 0x1815E7AB0 Slot: 24
	internal virtual Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<WriteTokenSyncReadingAsync>d__31))]
	// RVA: 0x15E8710 Offset: 0x15E6D10 VA: 0x1815E8710
	internal Task WriteTokenSyncReadingAsync(JsonReader reader, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<WriteConstructorDateAsync>d__32))]
	// RVA: 0x15E6750 Offset: 0x15E4D50 VA: 0x1815E6750
	private Task WriteConstructorDateAsync(JsonReader reader, CancellationToken cancellationToken) { }

	// RVA: 0x15EB210 Offset: 0x15E9810 VA: 0x1815EB210 Slot: 25
	public virtual Task WriteValueAsync(bool value, CancellationToken cancellationToken) { }

	// RVA: 0x15E9E70 Offset: 0x15E8470 VA: 0x1815E9E70 Slot: 26
	public virtual Task WriteValueAsync(Nullable<bool> value, CancellationToken cancellationToken) { }

	// RVA: 0x15E9D90 Offset: 0x15E8390 VA: 0x1815E9D90 Slot: 27
	public virtual Task WriteValueAsync(byte value, CancellationToken cancellationToken) { }

	// RVA: 0x15EABD0 Offset: 0x15E91D0 VA: 0x1815EABD0 Slot: 28
	public virtual Task WriteValueAsync(Nullable<byte> value, CancellationToken cancellationToken) { }

	// RVA: 0x15E9CB0 Offset: 0x15E82B0 VA: 0x1815E9CB0 Slot: 29
	public virtual Task WriteValueAsync(byte[] value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA680 Offset: 0x15E8C80 VA: 0x1815EA680 Slot: 30
	public virtual Task WriteValueAsync(char value, CancellationToken cancellationToken) { }

	// RVA: 0x15EAD90 Offset: 0x15E9390 VA: 0x1815EAD90 Slot: 31
	public virtual Task WriteValueAsync(Nullable<char> value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA030 Offset: 0x15E8630 VA: 0x1815EA030 Slot: 32
	public virtual Task WriteValueAsync(DateTime value, CancellationToken cancellationToken) { }

	// RVA: 0x15EC720 Offset: 0x15EAD20 VA: 0x1815EC720 Slot: 33
	public virtual Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA590 Offset: 0x15E8B90 VA: 0x1815EA590 Slot: 34
	public virtual Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken) { }

	// RVA: 0x15EC8F0 Offset: 0x15EAEF0 VA: 0x1815EC8F0 Slot: 35
	public virtual Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken) { }

	// RVA: 0x15EAE70 Offset: 0x15E9470 VA: 0x1815EAE70 Slot: 36
	public virtual Task WriteValueAsync(Decimal value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA110 Offset: 0x15E8710 VA: 0x1815EA110 Slot: 37
	public virtual Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA4B0 Offset: 0x15E8AB0 VA: 0x1815EA4B0 Slot: 38
	public virtual Task WriteValueAsync(double value, CancellationToken cancellationToken) { }

	// RVA: 0x15E9660 Offset: 0x15E7C60 VA: 0x1815E9660 Slot: 39
	public virtual Task WriteValueAsync(Nullable<double> value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA3D0 Offset: 0x15E89D0 VA: 0x1815EA3D0 Slot: 40
	public virtual Task WriteValueAsync(float value, CancellationToken cancellationToken) { }

	// RVA: 0x15EAA10 Offset: 0x15E9010 VA: 0x1815EAA10 Slot: 41
	public virtual Task WriteValueAsync(Nullable<float> value, CancellationToken cancellationToken) { }

	// RVA: 0x15E9AD0 Offset: 0x15E80D0 VA: 0x1815E9AD0 Slot: 42
	public virtual Task WriteValueAsync(Guid value, CancellationToken cancellationToken) { }

	// RVA: 0x15EB120 Offset: 0x15E9720 VA: 0x1815EB120 Slot: 43
	public virtual Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken) { }

	// RVA: 0x15EC9F0 Offset: 0x15EAFF0 VA: 0x1815EC9F0 Slot: 44
	public virtual Task WriteValueAsync(int value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA210 Offset: 0x15E8810 VA: 0x1815EA210 Slot: 45
	public virtual Task WriteValueAsync(Nullable<int> value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA850 Offset: 0x15E8E50 VA: 0x1815EA850 Slot: 46
	public virtual Task WriteValueAsync(long value, CancellationToken cancellationToken) { }

	// RVA: 0x15E9570 Offset: 0x15E7B70 VA: 0x1815E9570 Slot: 47
	public virtual Task WriteValueAsync(Nullable<long> value, CancellationToken cancellationToken) { }

	// RVA: 0x15E9F50 Offset: 0x15E8550 VA: 0x1815E9F50 Slot: 48
	public virtual Task WriteValueAsync(object value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15EC810 Offset: 0x15EAE10 VA: 0x1815EC810 Slot: 49
	public virtual Task WriteValueAsync(sbyte value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15E99F0 Offset: 0x15E7FF0 VA: 0x1815E99F0 Slot: 50
	public virtual Task WriteValueAsync(Nullable<sbyte> value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA2F0 Offset: 0x15E88F0 VA: 0x1815EA2F0 Slot: 51
	public virtual Task WriteValueAsync(short value, CancellationToken cancellationToken) { }

	// RVA: 0x15EAF60 Offset: 0x15E9560 VA: 0x1815EAF60 Slot: 52
	public virtual Task WriteValueAsync(Nullable<short> value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA930 Offset: 0x15E8F30 VA: 0x1815EA930 Slot: 53
	public virtual Task WriteValueAsync(string value, CancellationToken cancellationToken) { }

	// RVA: 0x15EAAF0 Offset: 0x15E90F0 VA: 0x1815EAAF0 Slot: 54
	public virtual Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken) { }

	// RVA: 0x15EA760 Offset: 0x15E8D60 VA: 0x1815EA760 Slot: 55
	public virtual Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15EB2F0 Offset: 0x15E98F0 VA: 0x1815EB2F0 Slot: 56
	public virtual Task WriteValueAsync(uint value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15EACB0 Offset: 0x15E92B0 VA: 0x1815EACB0 Slot: 57
	public virtual Task WriteValueAsync(Nullable<uint> value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15EB040 Offset: 0x15E9640 VA: 0x1815EB040 Slot: 58
	public virtual Task WriteValueAsync(ulong value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15E9BC0 Offset: 0x15E81C0 VA: 0x1815E9BC0 Slot: 59
	public virtual Task WriteValueAsync(Nullable<ulong> value, CancellationToken cancellationToken) { }

	// RVA: 0x15E9910 Offset: 0x15E7F10 VA: 0x1815E9910 Slot: 60
	public virtual Task WriteValueAsync(Uri value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15E9750 Offset: 0x15E7D50 VA: 0x1815E9750 Slot: 61
	public virtual Task WriteValueAsync(ushort value, CancellationToken cancellationToken) { }

	[CLSCompliant(False)]
	// RVA: 0x15E9830 Offset: 0x15E7E30 VA: 0x1815E9830 Slot: 62
	public virtual Task WriteValueAsync(Nullable<ushort> value, CancellationToken cancellationToken) { }

	// RVA: 0x15E9480 Offset: 0x15E7A80 VA: 0x1815E9480 Slot: 63
	public virtual Task WriteUndefinedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15EE990 Offset: 0x15ECF90 VA: 0x1815EE990 Slot: 64
	public virtual Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken) { }

	// RVA: 0x15E54B0 Offset: 0x15E3AB0 VA: 0x1815E54B0
	internal Task InternalWriteValueAsync(JsonToken token, CancellationToken cancellationToken) { }

	// RVA: 0x15E5AC0 Offset: 0x15E40C0 VA: 0x1815E5AC0
	protected Task SetWriteStateAsync(JsonToken token, object value, CancellationToken cancellationToken) { }

	// RVA: 0x15EB3D0 Offset: 0x15E99D0 VA: 0x1815EB3D0
	internal static Task WriteValueAsync(JsonWriter writer, PrimitiveTypeCode typeCode, object value, CancellationToken cancellationToken) { }

	// RVA: 0x15E4850 Offset: 0x15E2E50 VA: 0x1815E4850
	internal static JsonWriter.State[][] BuildStateArray() { }

	// RVA: 0x15EEA70 Offset: 0x15ED070 VA: 0x1815EEA70
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_CloseOutput() { }

	[CompilerGenerated]
	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_CloseOutput(bool value) { }

	[CompilerGenerated]
	// RVA: 0xADABC0 Offset: 0xAD91C0 VA: 0x180ADABC0
	public bool get_AutoCompleteOnClose() { }

	[CompilerGenerated]
	// RVA: 0xADB1E0 Offset: 0xAD97E0 VA: 0x180ADB1E0
	public void set_AutoCompleteOnClose(bool value) { }

	// RVA: 0x15EEFC0 Offset: 0x15ED5C0 VA: 0x1815EEFC0
	protected internal int get_Top() { }

	// RVA: 0x15EF020 Offset: 0x15ED620 VA: 0x1815EF020
	public WriteState get_WriteState() { }

	// RVA: 0x15EEDC0 Offset: 0x15ED3C0 VA: 0x1815EEDC0
	internal string get_ContainerPath() { }

	// RVA: 0x15EEEB0 Offset: 0x15ED4B0 VA: 0x1815EEEB0
	public string get_Path() { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public Formatting get_Formatting() { }

	// RVA: 0x15EF290 Offset: 0x15ED890 VA: 0x1815EF290
	public void set_Formatting(Formatting value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x15EF140 Offset: 0x15ED740 VA: 0x1815EF140
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x15EF1B0 Offset: 0x15ED7B0 VA: 0x1815EF1B0
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x15EEFB0 Offset: 0x15ED5B0 VA: 0x1815EEFB0
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x15EF300 Offset: 0x15ED900 VA: 0x1815EF300
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 65
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x15EF220 Offset: 0x15ED820 VA: 0x1815EF220
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	[NullableContext(2)]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_DateFormatString() { }

	[NullableContext(2)]
	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_DateFormatString(string value) { }

	// RVA: 0x15EEE50 Offset: 0x15ED450 VA: 0x1815EEE50
	public CultureInfo get_Culture() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x15EED90 Offset: 0x15ED390 VA: 0x1815EED90
	protected void .ctor() { }

	// RVA: 0x15E6660 Offset: 0x15E4C60 VA: 0x1815E6660
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0x15E57C0 Offset: 0x15E3DC0 VA: 0x1815E57C0
	private void Push(JsonContainerType value) { }

	// RVA: 0x15E56D0 Offset: 0x15E3CD0 VA: 0x1815E56D0
	private JsonContainerType Pop() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 66
	public abstract void Flush();

	// RVA: 0x15E4CE0 Offset: 0x15E32E0 VA: 0x1815E4CE0 Slot: 67
	public virtual void Close() { }

	// RVA: 0x15E7A70 Offset: 0x15E6070 VA: 0x1815E7A70 Slot: 68
	public virtual void WriteStartObject() { }

	// RVA: 0x15E6EF0 Offset: 0x15E54F0 VA: 0x1815E6EF0 Slot: 69
	public virtual void WriteEndObject() { }

	// RVA: 0x15E7840 Offset: 0x15E5E40 VA: 0x1815E7840 Slot: 70
	public virtual void WriteStartArray() { }

	// RVA: 0x15E6A00 Offset: 0x15E5000 VA: 0x1815E6A00 Slot: 71
	public virtual void WriteEndArray() { }

	// RVA: 0x15E7960 Offset: 0x15E5F60 VA: 0x1815E7960 Slot: 72
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0x15E6C90 Offset: 0x15E5290 VA: 0x1815E6C90 Slot: 73
	public virtual void WriteEndConstructor() { }

	// RVA: 0x15E5320 Offset: 0x15E3920 VA: 0x1815E5320 Slot: 74
	public virtual void WritePropertyName(string name) { }

	// RVA: 0x15E7540 Offset: 0x15E5B40 VA: 0x1815E7540 Slot: 75
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0x15E6F00 Offset: 0x15E5500 VA: 0x1815E6F00 Slot: 76
	public virtual void WriteEnd() { }

	// RVA: 0x15E8AB0 Offset: 0x15E70B0 VA: 0x1815E8AB0
	public void WriteToken(JsonReader reader) { }

	// RVA: 0x15E9400 Offset: 0x15E7A00 VA: 0x1815E9400
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	[NullableContext(2)]
	// RVA: 0x15E8B40 Offset: 0x15E7140 VA: 0x1815E8B40
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0x15E8B30 Offset: 0x15E7130 VA: 0x1815E8B30
	public void WriteToken(JsonToken token) { }

	// RVA: 0x15E8830 Offset: 0x15E6E30 VA: 0x1815E8830 Slot: 77
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0x15E55F0 Offset: 0x15E3BF0 VA: 0x1815E55F0
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	// RVA: 0x15E4BA0 Offset: 0x15E31A0 VA: 0x1815E4BA0
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	// RVA: 0x15E4B30 Offset: 0x15E3130 VA: 0x1815E4B30
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	// RVA: 0x15E6870 Offset: 0x15E4E70 VA: 0x1815E6870
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0x15E6FF0 Offset: 0x15E55F0 VA: 0x1815E6FF0
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0x15E4100 Offset: 0x15E2700 VA: 0x1815E4100
	private void AutoCompleteAll() { }

	// RVA: 0x15E4F00 Offset: 0x15E3500 VA: 0x1815E4F00
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0x15E4560 Offset: 0x15E2B60 VA: 0x1815E4560
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0x15E4A20 Offset: 0x15E3020 VA: 0x1815E4A20
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	// RVA: 0x15E6590 Offset: 0x15E4B90 VA: 0x1815E6590
	private void UpdateCurrentState() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 78
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 79
	protected virtual void WriteIndent() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 80
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 81
	protected virtual void WriteIndentSpace() { }

	// RVA: 0x15E4620 Offset: 0x15E2C20 VA: 0x1815E4620
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0x15E7340 Offset: 0x15E5940 VA: 0x1815E7340 Slot: 82
	public virtual void WriteNull() { }

	// RVA: 0x15E9550 Offset: 0x15E7B50 VA: 0x1815E9550 Slot: 83
	public virtual void WriteUndefined() { }

	[NullableContext(2)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 84
	public virtual void WriteRaw(string json) { }

	[NullableContext(2)]
	// RVA: 0x15E7720 Offset: 0x15E5D20 VA: 0x1815E7720 Slot: 85
	public virtual void WriteRawValue(string json) { }

	[NullableContext(2)]
	// RVA: 0x15ECF90 Offset: 0x15EB590 VA: 0x1815ECF90 Slot: 86
	public virtual void WriteValue(string value) { }

	// RVA: 0x15ECC20 Offset: 0x15EB220 VA: 0x1815ECC20 Slot: 87
	public virtual void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x15ECC20 Offset: 0x15EB220 VA: 0x1815ECC20 Slot: 88
	public virtual void WriteValue(uint value) { }

	// RVA: 0x15ECC20 Offset: 0x15EB220 VA: 0x1815ECC20 Slot: 89
	public virtual void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x15ECC20 Offset: 0x15EB220 VA: 0x1815ECC20 Slot: 90
	public virtual void WriteValue(ulong value) { }

	// RVA: 0x15ECDF0 Offset: 0x15EB3F0 VA: 0x1815ECDF0 Slot: 91
	public virtual void WriteValue(float value) { }

	// RVA: 0x15ECDF0 Offset: 0x15EB3F0 VA: 0x1815ECDF0 Slot: 92
	public virtual void WriteValue(double value) { }

	// RVA: 0x15ED0B0 Offset: 0x15EB6B0 VA: 0x1815ED0B0 Slot: 93
	public virtual void WriteValue(bool value) { }

	// RVA: 0x15ECC20 Offset: 0x15EB220 VA: 0x1815ECC20 Slot: 94
	public virtual void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x15ECC20 Offset: 0x15EB220 VA: 0x1815ECC20 Slot: 95
	public virtual void WriteValue(ushort value) { }

	// RVA: 0x15ECF90 Offset: 0x15EB590 VA: 0x1815ECF90 Slot: 96
	public virtual void WriteValue(char value) { }

	// RVA: 0x15ECC20 Offset: 0x15EB220 VA: 0x1815ECC20 Slot: 97
	public virtual void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x15ECC20 Offset: 0x15EB220 VA: 0x1815ECC20 Slot: 98
	public virtual void WriteValue(sbyte value) { }

	// RVA: 0x15ECDF0 Offset: 0x15EB3F0 VA: 0x1815ECDF0 Slot: 99
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0x15ECC40 Offset: 0x15EB240 VA: 0x1815ECC40 Slot: 100
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0x15ECC40 Offset: 0x15EB240 VA: 0x1815ECC40 Slot: 101
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0x15ECF90 Offset: 0x15EB590 VA: 0x1815ECF90 Slot: 102
	public virtual void WriteValue(Guid value) { }

	// RVA: 0x15ECF90 Offset: 0x15EB590 VA: 0x1815ECF90 Slot: 103
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0x15EE800 Offset: 0x15ECE00 VA: 0x1815EE800 Slot: 104
	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliant(False)]
	// RVA: 0x15ECF10 Offset: 0x15EB510 VA: 0x1815ECF10 Slot: 105
	public virtual void WriteValue(Nullable<uint> value) { }

	// RVA: 0x15EE500 Offset: 0x15ECB00 VA: 0x1815EE500 Slot: 106
	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliant(False)]
	// RVA: 0x15ED0D0 Offset: 0x15EB6D0 VA: 0x1815ED0D0 Slot: 107
	public virtual void WriteValue(Nullable<ulong> value) { }

	// RVA: 0x15ECE10 Offset: 0x15EB410 VA: 0x1815ECE10 Slot: 108
	public virtual void WriteValue(Nullable<float> value) { }

	// RVA: 0x15ECFB0 Offset: 0x15EB5B0 VA: 0x1815ECFB0 Slot: 109
	public virtual void WriteValue(Nullable<double> value) { }

	// RVA: 0x15EE750 Offset: 0x15ECD50 VA: 0x1815EE750 Slot: 110
	public virtual void WriteValue(Nullable<bool> value) { }

	// RVA: 0x15ED150 Offset: 0x15EB750 VA: 0x1815ED150 Slot: 111
	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliant(False)]
	// RVA: 0x15EE910 Offset: 0x15ECF10 VA: 0x1815EE910 Slot: 112
	public virtual void WriteValue(Nullable<ushort> value) { }

	// RVA: 0x15ECBA0 Offset: 0x15EB1A0 VA: 0x1815ECBA0 Slot: 113
	public virtual void WriteValue(Nullable<char> value) { }

	// RVA: 0x15ED030 Offset: 0x15EB630 VA: 0x1815ED030 Slot: 114
	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliant(False)]
	// RVA: 0x15ECD70 Offset: 0x15EB370 VA: 0x1815ECD70 Slot: 115
	public virtual void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0x15ECCE0 Offset: 0x15EB2E0 VA: 0x1815ECCE0 Slot: 116
	public virtual void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0x15ECC60 Offset: 0x15EB260 VA: 0x1815ECC60 Slot: 117
	public virtual void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0x15ED1D0 Offset: 0x15EB7D0 VA: 0x1815ED1D0 Slot: 118
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0x15EE880 Offset: 0x15ECE80 VA: 0x1815EE880 Slot: 119
	public virtual void WriteValue(Nullable<Guid> value) { }

	// RVA: 0x15ECE90 Offset: 0x15EB490 VA: 0x1815ECE90 Slot: 120
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	[NullableContext(2)]
	// RVA: 0x15EE7D0 Offset: 0x15ECDD0 VA: 0x1815EE7D0 Slot: 121
	public virtual void WriteValue(byte[] value) { }

	[NullableContext(2)]
	// RVA: 0x15EE580 Offset: 0x15ECB80 VA: 0x1815EE580 Slot: 122
	public virtual void WriteValue(Uri value) { }

	[NullableContext(2)]
	// RVA: 0x15EE620 Offset: 0x15ECC20 VA: 0x1815EE620 Slot: 123
	public virtual void WriteValue(object value) { }

	[NullableContext(2)]
	// RVA: 0x15E4FD0 Offset: 0x15E35D0 VA: 0x1815E4FD0 Slot: 124
	public virtual void WriteComment(string text) { }

	// RVA: 0x15E5590 Offset: 0x15E3B90 VA: 0x1815E5590 Slot: 125
	public virtual void WriteWhitespace(string ws) { }

	// RVA: 0x15E6070 Offset: 0x15E4670 VA: 0x1815E6070 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x15E4E00 Offset: 0x15E3400 VA: 0x1815E4E00 Slot: 126
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15ED260 Offset: 0x15EB860 VA: 0x1815ED260
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0x15E5930 Offset: 0x15E3F30 VA: 0x1815E5930
	private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) { }

	// RVA: 0x15E4D50 Offset: 0x15E3350 VA: 0x1815E4D50
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0x15E5E20 Offset: 0x15E4420 VA: 0x1815E5E20
	protected void SetWriteState(JsonToken token, object value) { }

	// RVA: 0x15E4560 Offset: 0x15E2B60 VA: 0x1815E4560
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0x15E5320 Offset: 0x15E3920 VA: 0x1815E5320
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void InternalWriteRaw() { }

	// RVA: 0x15E5470 Offset: 0x15E3A70 VA: 0x1815E5470
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0x15E5570 Offset: 0x15E3B70 VA: 0x1815E5570
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0x15E5590 Offset: 0x15E3B90 VA: 0x1815E5590
	internal void InternalWriteWhitespace(string ws) { }

	// RVA: 0x15E4FD0 Offset: 0x15E35D0 VA: 0x1815E4FD0
	internal void InternalWriteComment() { }

	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d))]
	[CompilerGenerated]
	// RVA: 0x15E6340 Offset: 0x15E4940 VA: 0x1815E6340
	private Task <InternalWriteEndAsync>g__AwaitProperty|11_0(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d))]
	[CompilerGenerated]
	// RVA: 0x15E6200 Offset: 0x15E4800 VA: 0x1815E6200
	private Task <InternalWriteEndAsync>g__AwaitIndent|11_1(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d))]
	[CompilerGenerated]
	// RVA: 0x15E60D0 Offset: 0x15E46D0 VA: 0x1815E60D0
	private Task <InternalWriteEndAsync>g__AwaitEnd|11_2(Task task, int LevelsToComplete, CancellationToken CancellationToken) { }

	[AsyncStateMachine(typeof(JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d))]
	[CompilerGenerated]
	// RVA: 0x15E6480 Offset: 0x15E4A80 VA: 0x1815E6480
	private Task <InternalWriteEndAsync>g__AwaitRemaining|11_3(int LevelsToComplete, CancellationToken CancellationToken) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class JsonWriterException : JsonException // TypeDefIndex: 8240
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x90

	// Properties
	[Nullable(2)]
	public string Path { get; }

	// Methods

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public string get_Path() { }

	// RVA: 0x1609E40 Offset: 0x1608440 VA: 0x181609E40
	public void .ctor() { }

	// RVA: 0x1609E50 Offset: 0x1608450 VA: 0x181609E50
	public void .ctor(string message) { }

	// RVA: 0x1609DF0 Offset: 0x16083F0 VA: 0x181609DF0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1609DD0 Offset: 0x16083D0 VA: 0x181609DD0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1609E00 Offset: 0x1608400 VA: 0x181609E00
	public void .ctor(string message, string path, Exception innerException) { }

	// RVA: 0x1609CF0 Offset: 0x16082F0 VA: 0x181609CF0
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0x1609C30 Offset: 0x1608230 VA: 0x181609C30
	internal static JsonWriterException Create(string path, string message, Exception ex) { }
}

// Namespace: Newtonsoft.Json
public enum MemberSerialization // TypeDefIndex: 8241
{
	// Fields
	public int value__; // 0x0
	public const MemberSerialization OptOut = 0;
	public const MemberSerialization OptIn = 1;
	public const MemberSerialization Fields = 2;
}

// Namespace: Newtonsoft.Json
public enum MetadataPropertyHandling // TypeDefIndex: 8242
{
	// Fields
	public int value__; // 0x0
	public const MetadataPropertyHandling Default = 0;
	public const MetadataPropertyHandling ReadAhead = 1;
	public const MetadataPropertyHandling Ignore = 2;
}

// Namespace: Newtonsoft.Json
public enum MissingMemberHandling // TypeDefIndex: 8243
{
	// Fields
	public int value__; // 0x0
	public const MissingMemberHandling Ignore = 0;
	public const MissingMemberHandling Error = 1;
}

// Namespace: Newtonsoft.Json
public enum NullValueHandling // TypeDefIndex: 8244
{
	// Fields
	public int value__; // 0x0
	public const NullValueHandling Include = 0;
	public const NullValueHandling Ignore = 1;
}

// Namespace: Newtonsoft.Json
public enum ObjectCreationHandling // TypeDefIndex: 8245
{
	// Fields
	public int value__; // 0x0
	public const ObjectCreationHandling Auto = 0;
	public const ObjectCreationHandling Reuse = 1;
	public const ObjectCreationHandling Replace = 2;
}

// Namespace: Newtonsoft.Json
[Flags]
public enum PreserveReferencesHandling // TypeDefIndex: 8246
{
	// Fields
	public int value__; // 0x0
	public const PreserveReferencesHandling None = 0;
	public const PreserveReferencesHandling Objects = 1;
	public const PreserveReferencesHandling Arrays = 2;
	public const PreserveReferencesHandling All = 3;
}

// Namespace: Newtonsoft.Json
public enum ReferenceLoopHandling // TypeDefIndex: 8247
{
	// Fields
	public int value__; // 0x0
	public const ReferenceLoopHandling Error = 0;
	public const ReferenceLoopHandling Ignore = 1;
	public const ReferenceLoopHandling Serialize = 2;
}

// Namespace: Newtonsoft.Json
public enum Required // TypeDefIndex: 8248
{
	// Fields
	public int value__; // 0x0
	public const Required Default = 0;
	public const Required AllowNull = 1;
	public const Required Always = 2;
	public const Required DisallowNull = 3;
}

// Namespace: Newtonsoft.Json
public enum StringEscapeHandling // TypeDefIndex: 8249
{
	// Fields
	public int value__; // 0x0
	public const StringEscapeHandling Default = 0;
	public const StringEscapeHandling EscapeNonAscii = 1;
	public const StringEscapeHandling EscapeHtml = 2;
}

// Namespace: Newtonsoft.Json
public enum TypeNameAssemblyFormatHandling // TypeDefIndex: 8250
{
	// Fields
	public int value__; // 0x0
	public const TypeNameAssemblyFormatHandling Simple = 0;
	public const TypeNameAssemblyFormatHandling Full = 1;
}

// Namespace: Newtonsoft.Json
[Flags]
public enum TypeNameHandling // TypeDefIndex: 8251
{
	// Fields
	public int value__; // 0x0
	public const TypeNameHandling None = 0;
	public const TypeNameHandling Objects = 1;
	public const TypeNameHandling Arrays = 2;
	public const TypeNameHandling All = 3;
	public const TypeNameHandling Auto = 4;
}

// Namespace: Newtonsoft.Json
public enum WriteState // TypeDefIndex: 8252
{
	// Fields
	public int value__; // 0x0
	public const WriteState Error = 0;
	public const WriteState Closed = 1;
	public const WriteState Object = 2;
	public const WriteState Array = 3;
	public const WriteState Constructor = 4;
	public const WriteState Property = 5;
	public const WriteState Start = 6;
}

