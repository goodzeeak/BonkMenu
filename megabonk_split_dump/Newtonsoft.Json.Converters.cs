// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class BinaryConverter : JsonConverter // TypeDefIndex: 8535
{
	// Fields
	private const string BinaryTypeName = "System.Data.Linq.Binary";
	private const string BinaryToArrayName = "ToArray";
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0x166F450 Offset: 0x166DA50 VA: 0x18166F450 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x166EB50 Offset: 0x166D150 VA: 0x18166EB50
	private byte[] GetByteArray(object value) { }

	// RVA: 0x166E9A0 Offset: 0x166CFA0 VA: 0x18166E9A0
	private static void EnsureReflectionObject(Type t) { }

	// RVA: 0x166EFD0 Offset: 0x166D5D0 VA: 0x18166EFD0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x166ED70 Offset: 0x166D370 VA: 0x18166ED70
	private byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0x166E890 Offset: 0x166CE90 VA: 0x18166E890 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 8536
{
	// Methods

	// RVA: 0x1670BA0 Offset: 0x166F1A0 VA: 0x181670BA0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1670A10 Offset: 0x166F010 VA: 0x181670A10 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x16709A0 Offset: 0x166EFA0 VA: 0x1816709A0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public abstract class CustomCreationConverter<T> : JsonConverter // TypeDefIndex: 8537
{
	// Properties
	public override bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD31270 Offset: 0xD2F870 VA: 0x180D31270
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.WriteJson
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD31060 Offset: 0xD2F660 VA: 0x180D31060
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.ReadJson
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract T Create(Type objectType);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool CanConvert(Type objectType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD30FF0 Offset: 0xD2F5F0 VA: 0x180D30FF0
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.CanConvert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool get_CanWrite() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.get_CanWrite
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class DataSetConverter : JsonConverter // TypeDefIndex: 8538
{
	// Methods

	// RVA: 0x1671330 Offset: 0x166F930 VA: 0x181671330 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1671040 Offset: 0x166F640 VA: 0x181671040 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1670FC0 Offset: 0x166F5C0 VA: 0x181670FC0 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class DataTableConverter : JsonConverter // TypeDefIndex: 8539
{
	// Methods

	// RVA: 0x1672180 Offset: 0x1670780 VA: 0x181672180 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1671E80 Offset: 0x1670480 VA: 0x181671E80 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x16717C0 Offset: 0x166FDC0 VA: 0x1816717C0
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	// RVA: 0x1671C60 Offset: 0x1670260 VA: 0x181671C60
	private static Type GetColumnDataType(JsonReader reader) { }

	// RVA: 0x1671740 Offset: 0x166FD40 VA: 0x181671740 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
public abstract class DateTimeConverterBase : JsonConverter // TypeDefIndex: 8540
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1672740 Offset: 0x1670D40 VA: 0x181672740 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class DiscriminatedUnionConverter : JsonConverter // TypeDefIndex: 8545
{
	// Fields
	private const string CasePropertyName = "Case";
	private const string FieldsPropertyName = "Fields";
	private static readonly ThreadSafeStore<Type, DiscriminatedUnionConverter.Union> UnionCache; // 0x0
	private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache; // 0x8

	// Methods

	// RVA: 0x1672B00 Offset: 0x1671100 VA: 0x181672B00
	private static Type CreateUnionTypeLookup(Type t) { }

	// RVA: 0x1672D50 Offset: 0x1671350 VA: 0x181672D50
	private static DiscriminatedUnionConverter.Union CreateUnion(Type t) { }

	// RVA: 0x1673E80 Offset: 0x1672480 VA: 0x181673E80 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x16736D0 Offset: 0x1671CD0 VA: 0x1816736D0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1672890 Offset: 0x1670E90 VA: 0x181672890 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x16743B0 Offset: 0x16729B0 VA: 0x1816743B0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class EntityKeyMemberConverter : JsonConverter // TypeDefIndex: 8546
{
	// Fields
	private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
	private const string KeyPropertyName = "Key";
	private const string TypePropertyName = "Type";
	private const string ValuePropertyName = "Value";
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0x16749F0 Offset: 0x1672FF0 VA: 0x1816749F0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1674660 Offset: 0x1672C60 VA: 0x181674660
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	// RVA: 0x1674770 Offset: 0x1672D70 VA: 0x181674770 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1674560 Offset: 0x1672B60 VA: 0x181674560
	private static void EnsureReflectionObject(Type objectType) { }

	// RVA: 0x1674520 Offset: 0x1672B20 VA: 0x181674520 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class ExpandoObjectConverter : JsonConverter // TypeDefIndex: 8547
{
	// Properties
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1674DB0 Offset: 0x16733B0 VA: 0x181674DB0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x16750C0 Offset: 0x16736C0 VA: 0x1816750C0
	private object ReadValue(JsonReader reader) { }

	// RVA: 0x1674DC0 Offset: 0x16733C0 VA: 0x181674DC0
	private object ReadList(JsonReader reader) { }

	// RVA: 0x1674EF0 Offset: 0x16734F0 VA: 0x181674EF0
	private object ReadObject(JsonReader reader) { }

	// RVA: 0x1674D40 Offset: 0x1673340 VA: 0x181674D40 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 8
	public override bool get_CanWrite() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 8548
{
	// Fields
	private const string DefaultDateTimeFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK";
	private DateTimeStyles _dateTimeStyles; // 0x10
	[Nullable(2)]
	private string _dateTimeFormat; // 0x18
	[Nullable(2)]
	private CultureInfo _culture; // 0x20

	// Properties
	public DateTimeStyles DateTimeStyles { get; set; }
	[Nullable(2)]
	public string DateTimeFormat { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public DateTimeStyles get_DateTimeStyles() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_DateTimeStyles(DateTimeStyles value) { }

	[NullableContext(2)]
	// RVA: 0x1486980 Offset: 0x1484F80 VA: 0x181486980
	public string get_DateTimeFormat() { }

	[NullableContext(2)]
	// RVA: 0x1675E10 Offset: 0x1674410 VA: 0x181675E10
	public void set_DateTimeFormat(string value) { }

	// RVA: 0x1675DB0 Offset: 0x16743B0 VA: 0x181675DB0
	public CultureInfo get_Culture() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x1675A70 Offset: 0x1674070 VA: 0x181675A70 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x16754C0 Offset: 0x1673AC0 VA: 0x1816754C0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1675DA0 Offset: 0x16743A0 VA: 0x181675DA0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class JavaScriptDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 8549
{
	// Methods

	// RVA: 0x1680280 Offset: 0x167E880 VA: 0x181680280 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x167FED0 Offset: 0x167E4D0 VA: 0x18167FED0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 8550
{
	// Fields
	private const string KeyName = "Key";
	private const string ValueName = "Value";
	private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType; // 0x0

	// Methods

	// RVA: 0x1680590 Offset: 0x167EB90 VA: 0x181680590
	private static ReflectionObject InitializeReflectionObject(Type t) { }

	// RVA: 0x1680BF0 Offset: 0x167F1F0 VA: 0x181680BF0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1680790 Offset: 0x167ED90 VA: 0x181680790 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x16804A0 Offset: 0x167EAA0 VA: 0x1816804A0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x1680E70 Offset: 0x167F470 VA: 0x181680E70
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class RegexConverter : JsonConverter // TypeDefIndex: 8551
{
	// Fields
	private const string PatternName = "Pattern";
	private const string OptionsName = "Options";

	// Methods

	// RVA: 0x1681F70 Offset: 0x1680570 VA: 0x181681F70 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x14042E0 Offset: 0x14028E0 VA: 0x1814042E0
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0x1681C60 Offset: 0x1680260 VA: 0x181681C60
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0x1681DA0 Offset: 0x16803A0 VA: 0x181681DA0
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0x1681640 Offset: 0x167FC40 VA: 0x181681640 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1681B00 Offset: 0x1680100 VA: 0x181681B00
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0x1681830 Offset: 0x167FE30 VA: 0x181681830
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0x1681540 Offset: 0x167FB40 VA: 0x181681540 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x16815D0 Offset: 0x167FBD0 VA: 0x1816815D0
	private bool IsRegex(Type objectType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class StringEnumConverter : JsonConverter // TypeDefIndex: 8552
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <AllowIntegerValues>k__BackingField; // 0x18

	// Properties
	[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
	public bool CamelCaseText { get; set; }
	[Nullable(2)]
	public NamingStrategy NamingStrategy { get; set; }
	public bool AllowIntegerValues { get; set; }

	// Methods

	// RVA: 0x1682D80 Offset: 0x1681380 VA: 0x181682D80
	public bool get_CamelCaseText() { }

	// RVA: 0x1682DF0 Offset: 0x16813F0 VA: 0x181682DF0
	public void set_CamelCaseText(bool value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public NamingStrategy get_NamingStrategy() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_NamingStrategy(NamingStrategy value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_AllowIntegerValues() { }

	[CompilerGenerated]
	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0x1682B60 Offset: 0x1681160 VA: 0x181682B60
	public void .ctor() { }

	[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
	// RVA: 0x1682AE0 Offset: 0x16810E0 VA: 0x181682AE0
	public void .ctor(bool camelCaseText) { }

	// RVA: 0x1682A90 Offset: 0x1681090 VA: 0x181682A90
	public void .ctor(NamingStrategy namingStrategy, bool allowIntegerValues = True) { }

	// RVA: 0x1682B70 Offset: 0x1681170 VA: 0x181682B70
	public void .ctor(Type namingStrategyType) { }

	// RVA: 0x1682C10 Offset: 0x1681210 VA: 0x181682C10
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters) { }

	// RVA: 0x1682CC0 Offset: 0x16812C0 VA: 0x181682CC0
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

	// RVA: 0x1682890 Offset: 0x1680E90 VA: 0x181682890 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1682430 Offset: 0x1680A30 VA: 0x181682430 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x16823C0 Offset: 0x16809C0 VA: 0x1816823C0 Slot: 6
	public override bool CanConvert(Type objectType) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class UnixDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 8553
{
	// Fields
	internal static readonly DateTime UnixEpoch; // 0x0

	// Methods

	// RVA: 0x1688020 Offset: 0x1686620 VA: 0x181688020 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1687B60 Offset: 0x1686160 VA: 0x181687B60 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x16882E0 Offset: 0x16868E0 VA: 0x1816882E0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class VersionConverter : JsonConverter // TypeDefIndex: 8554
{
	// Methods

	// RVA: 0x1688620 Offset: 0x1686C20 VA: 0x181688620 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x16883D0 Offset: 0x16869D0 VA: 0x1816883D0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1688360 Offset: 0x1686960 VA: 0x181688360 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 8555
{
	// Fields
	private readonly XmlDocument _document; // 0x28

	// Properties
	[Nullable(2)]
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0x1691770 Offset: 0x168FD70 VA: 0x181691770
	public void .ctor(XmlDocument document) { }

	// RVA: 0x1691AE0 Offset: 0x16900E0 VA: 0x181691AE0 Slot: 16
	public IXmlNode CreateComment(string data) { }

	// RVA: 0x1691DD0 Offset: 0x16903D0 VA: 0x181691DD0 Slot: 17
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0x1691A50 Offset: 0x1690050 VA: 0x181691A50 Slot: 18
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x1691E60 Offset: 0x1690460 VA: 0x181691E60 Slot: 19
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x1691D40 Offset: 0x1690340 VA: 0x181691D40 Slot: 20
	public IXmlNode CreateSignificantWhitespace(string text) { }

	[NullableContext(2)]
	// RVA: 0x1691EF0 Offset: 0x16904F0 VA: 0x181691EF0 Slot: 21
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	// RVA: 0x1691FC0 Offset: 0x16905C0 VA: 0x181691FC0 Slot: 22
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1691CA0 Offset: 0x16902A0 VA: 0x181691CA0 Slot: 23
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x1691B70 Offset: 0x1690170 VA: 0x181691B70 Slot: 24
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0x1691C00 Offset: 0x1690200 VA: 0x181691C00 Slot: 25
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x16918E0 Offset: 0x168FEE0 VA: 0x1816918E0 Slot: 26
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x1691990 Offset: 0x168FF90 VA: 0x181691990 Slot: 27
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[NullableContext(2)]
	// RVA: 0x1692090 Offset: 0x1690690 VA: 0x181692090 Slot: 28
	public IXmlElement get_DocumentElement() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode // TypeDefIndex: 8556
{
	// Fields
	private readonly XmlElement _element; // 0x28

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1691770 Offset: 0x168FD70 VA: 0x181691770
	public void .ctor(XmlElement element) { }

	// RVA: 0x1692170 Offset: 0x1690770 VA: 0x181692170 Slot: 16
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0x1692140 Offset: 0x1690740 VA: 0x181692140 Slot: 17
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0x1692260 Offset: 0x1690860 VA: 0x181692260 Slot: 18
	public bool get_IsEmpty() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 8557
{
	// Fields
	private readonly XmlDeclaration _declaration; // 0x28

	// Properties
	public string Version { get; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }

	// Methods

	// RVA: 0x1691770 Offset: 0x168FD70 VA: 0x181691770
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0x1691800 Offset: 0x168FE00 VA: 0x181691800 Slot: 16
	public string get_Version() { }

	// RVA: 0x16917C0 Offset: 0x168FDC0 VA: 0x1816917C0 Slot: 17
	public string get_Encoding() { }

	// RVA: 0x1691820 Offset: 0x168FE20 VA: 0x181691820 Slot: 18
	public void set_Encoding(string value) { }

	// RVA: 0x16917E0 Offset: 0x168FDE0 VA: 0x1816917E0 Slot: 19
	public string get_Standalone() { }

	// RVA: 0x1691840 Offset: 0x168FE40 VA: 0x181691840 Slot: 20
	public void set_Standalone(string value) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 8558
{
	// Fields
	private readonly XmlDocumentType _documentType; // 0x28

	// Properties
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	[Nullable(2)]
	public override string LocalName { get; }

	// Methods

	// RVA: 0x1691770 Offset: 0x168FD70 VA: 0x181691770
	public void .ctor(XmlDocumentType documentType) { }

	// RVA: 0x16918B0 Offset: 0x168FEB0 VA: 0x1816918B0 Slot: 16
	public string get_Name() { }

	// RVA: 0x16917E0 Offset: 0x168FDE0 VA: 0x1816917E0 Slot: 17
	public string get_System() { }

	// RVA: 0x16917C0 Offset: 0x168FDC0 VA: 0x1816917C0 Slot: 18
	public string get_Public() { }

	// RVA: 0x1691860 Offset: 0x168FE60 VA: 0x181691860 Slot: 19
	public string get_InternalSubset() { }

	[NullableContext(2)]
	// RVA: 0x1691880 Offset: 0x168FE80 VA: 0x181691880 Slot: 14
	public override string get_LocalName() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 8559
{
	// Fields
	[Nullable(1)]
	private readonly XmlNode _node; // 0x10
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _childNodes; // 0x18
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	public object WrappedNode { get; }
	public XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	[Nullable(1)]
	public List<IXmlNode> ChildNodes { get; }
	protected virtual bool HasChildNodes { get; }
	[Nullable(1)]
	public List<IXmlNode> Attributes { get; }
	private bool HasAttributes { get; }
	public IXmlNode ParentNode { get; }
	public string Value { get; set; }
	public string NamespaceUri { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(XmlNode node) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 13
	public object get_WrappedNode() { }

	// RVA: 0x140B6A0 Offset: 0x1409CA0 VA: 0x18140B6A0 Slot: 4
	public XmlNodeType get_NodeType() { }

	// RVA: 0x1699D70 Offset: 0x1698370 VA: 0x181699D70 Slot: 14
	public virtual string get_LocalName() { }

	[NullableContext(1)]
	// RVA: 0x16996C0 Offset: 0x1697CC0 VA: 0x1816996C0 Slot: 6
	public List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x1699D40 Offset: 0x1698340 VA: 0x181699D40 Slot: 15
	protected virtual bool get_HasChildNodes() { }

	[NullableContext(1)]
	// RVA: 0x1698E90 Offset: 0x1697490 VA: 0x181698E90
	internal static IXmlNode WrapNode(XmlNode node) { }

	[NullableContext(1)]
	// RVA: 0x1699080 Offset: 0x1697680 VA: 0x181699080 Slot: 7
	public List<IXmlNode> get_Attributes() { }

	// RVA: 0x1699C80 Offset: 0x1698280 VA: 0x181699C80
	private bool get_HasAttributes() { }

	// RVA: 0x1699DD0 Offset: 0x16983D0 VA: 0x181699DD0 Slot: 8
	public IXmlNode get_ParentNode() { }

	// RVA: 0x1699E80 Offset: 0x1698480 VA: 0x181699E80 Slot: 9
	public string get_Value() { }

	// RVA: 0x1699EB0 Offset: 0x16984B0 VA: 0x181699EB0 Slot: 10
	public void set_Value(string value) { }

	[NullableContext(1)]
	// RVA: 0x1698DD0 Offset: 0x16973D0 VA: 0x181698DD0 Slot: 11
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x1699DA0 Offset: 0x16983A0 VA: 0x181699DA0 Slot: 12
	public string get_NamespaceUri() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
internal interface IXmlDocument : IXmlNode // TypeDefIndex: 8560
{
	// Properties
	[Nullable(2)]
	public abstract IXmlElement DocumentElement { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IXmlNode CreateComment(string text);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNode CreateTextNode(string text);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IXmlNode CreateCDataSection(string data);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IXmlNode CreateWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode CreateSignificantWhitespace(string text);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IXmlNode CreateProcessingInstruction(string target, string data);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IXmlElement CreateElement(string elementName);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IXmlElement CreateElement(string qualifiedName, string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IXmlNode CreateAttribute(string name, string value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract IXmlElement get_DocumentElement();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
internal interface IXmlDeclaration : IXmlNode // TypeDefIndex: 8561
{
	// Properties
	public abstract string Version { get; }
	public abstract string Encoding { get; set; }
	public abstract string Standalone { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Encoding();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_Encoding(string value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_Standalone();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_Standalone(string value);
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
internal interface IXmlDocumentType : IXmlNode // TypeDefIndex: 8562
{
	// Properties
	public abstract string Name { get; }
	public abstract string System { get; }
	public abstract string Public { get; }
	public abstract string InternalSubset { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_System();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Public();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_InternalSubset();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
internal interface IXmlElement : IXmlNode // TypeDefIndex: 8563
{
	// Properties
	public abstract bool IsEmpty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetAttributeNode(IXmlNode attribute);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetPrefixOfNamespace(string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsEmpty();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
internal interface IXmlNode // TypeDefIndex: 8564
{
	// Properties
	public abstract XmlNodeType NodeType { get; }
	public abstract string LocalName { get; }
	[Nullable(1)]
	public abstract List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public abstract List<IXmlNode> Attributes { get; }
	public abstract IXmlNode ParentNode { get; }
	public abstract string Value { get; set; }
	public abstract string NamespaceUri { get; }
	public abstract object WrappedNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<IXmlNode> get_ChildNodes();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract List<IXmlNode> get_Attributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode get_ParentNode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_Value(string value);

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract IXmlNode AppendChild(IXmlNode newChild);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_NamespaceUri();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object get_WrappedNode();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 8565
{
	// Fields
	[CompilerGenerated]
	private readonly XDeclaration <Declaration>k__BackingField; // 0x18

	// Properties
	internal XDeclaration Declaration { get; }
	public override XmlNodeType NodeType { get; }
	public string Version { get; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal XDeclaration get_Declaration() { }

	// RVA: 0x168F740 Offset: 0x168DD40 VA: 0x18168F740
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0x455580 Offset: 0x453B80 VA: 0x180455580 Slot: 14
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x168F7D0 Offset: 0x168DDD0 VA: 0x18168F7D0 Slot: 23
	public string get_Version() { }

	// RVA: 0x168F790 Offset: 0x168DD90 VA: 0x18168F790 Slot: 24
	public string get_Encoding() { }

	// RVA: 0x168F7F0 Offset: 0x168DDF0 VA: 0x18168F7F0 Slot: 25
	public void set_Encoding(string value) { }

	// RVA: 0x168F7B0 Offset: 0x168DDB0 VA: 0x18168F7B0 Slot: 26
	public string get_Standalone() { }

	// RVA: 0x168F820 Offset: 0x168DE20 VA: 0x18168F820 Slot: 27
	public void set_Standalone(string value) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 8566
{
	// Fields
	private readonly XDocumentType _documentType; // 0x18

	// Properties
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	[Nullable(2)]
	public override string LocalName { get; }

	// Methods

	// RVA: 0x168F850 Offset: 0x168DE50 VA: 0x18168F850
	public void .ctor(XDocumentType documentType) { }

	// RVA: 0x168F8F0 Offset: 0x168DEF0 VA: 0x18168F8F0 Slot: 23
	public string get_Name() { }

	// RVA: 0x168F930 Offset: 0x168DF30 VA: 0x18168F930 Slot: 24
	public string get_System() { }

	// RVA: 0x168F910 Offset: 0x168DF10 VA: 0x18168F910 Slot: 25
	public string get_Public() { }

	// RVA: 0x168F8A0 Offset: 0x168DEA0 VA: 0x18168F8A0 Slot: 26
	public string get_InternalSubset() { }

	[NullableContext(2)]
	// RVA: 0x168F8C0 Offset: 0x168DEC0 VA: 0x18168F8C0 Slot: 15
	public override string get_LocalName() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 8567
{
	// Properties
	private XDocument Document { get; }
	public override List<IXmlNode> ChildNodes { get; }
	protected override bool HasChildNodes { get; }
	[Nullable(2)]
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0x1690470 Offset: 0x168EA70 VA: 0x181690470
	private XDocument get_Document() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(XDocument document) { }

	// RVA: 0x16901D0 Offset: 0x168E7D0 VA: 0x1816901D0 Slot: 16
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x16904E0 Offset: 0x168EAE0 VA: 0x1816904E0 Slot: 23
	protected override bool get_HasChildNodes() { }

	// RVA: 0x168FC00 Offset: 0x168E200 VA: 0x18168FC00 Slot: 24
	public IXmlNode CreateComment(string text) { }

	// RVA: 0x168FF10 Offset: 0x168E510 VA: 0x18168FF10 Slot: 25
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0x168FB70 Offset: 0x168E170 VA: 0x18168FB70 Slot: 26
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x168FFA0 Offset: 0x168E5A0 VA: 0x18168FFA0 Slot: 27
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x168FE80 Offset: 0x168E480 VA: 0x18168FE80 Slot: 28
	public IXmlNode CreateSignificantWhitespace(string text) { }

	[NullableContext(2)]
	// RVA: 0x1690030 Offset: 0x168E630 VA: 0x181690030 Slot: 29
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	// RVA: 0x1690100 Offset: 0x168E700 VA: 0x181690100 Slot: 30
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x168FDE0 Offset: 0x168E3E0 VA: 0x18168FDE0 Slot: 31
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x168FC90 Offset: 0x168E290 VA: 0x18168FC90 Slot: 32
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0x168FD30 Offset: 0x168E330 VA: 0x18168FD30 Slot: 33
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x168FA00 Offset: 0x168E000 VA: 0x18168FA00 Slot: 34
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x168FAB0 Offset: 0x168E0B0 VA: 0x18168FAB0 Slot: 35
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[NullableContext(2)]
	// RVA: 0x1690370 Offset: 0x168E970 VA: 0x181690370 Slot: 36
	public IXmlElement get_DocumentElement() { }

	// RVA: 0x168F950 Offset: 0x168DF50 VA: 0x18168F950 Slot: 21
	public override IXmlNode AppendChild(IXmlNode newChild) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XTextWrapper : XObjectWrapper // TypeDefIndex: 8568
{
	// Properties
	[Nullable(1)]
	private XText Text { get; }
	public override string Value { get; set; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x16915F0 Offset: 0x168FBF0 VA: 0x1816915F0
	private XText get_Text() { }

	[NullableContext(1)]
	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(XText text) { }

	// RVA: 0x1691660 Offset: 0x168FC60 VA: 0x181691660 Slot: 19
	public override string get_Value() { }

	// RVA: 0x16916E0 Offset: 0x168FCE0 VA: 0x1816916E0 Slot: 20
	public override void set_Value(string value) { }

	// RVA: 0x1691540 Offset: 0x168FB40 VA: 0x181691540 Slot: 18
	public override IXmlNode get_ParentNode() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XCommentWrapper : XObjectWrapper // TypeDefIndex: 8569
{
	// Properties
	[Nullable(1)]
	private XComment Text { get; }
	public override string Value { get; set; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x168ED20 Offset: 0x168D320 VA: 0x18168ED20
	private XComment get_Text() { }

	[NullableContext(1)]
	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(XComment text) { }

	// RVA: 0x168ED90 Offset: 0x168D390 VA: 0x18168ED90 Slot: 19
	public override string get_Value() { }

	// RVA: 0x168EE10 Offset: 0x168D410 VA: 0x18168EE10 Slot: 20
	public override void set_Value(string value) { }

	// RVA: 0x168EC70 Offset: 0x168D270 VA: 0x18168EC70 Slot: 18
	public override IXmlNode get_ParentNode() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XProcessingInstructionWrapper : XObjectWrapper // TypeDefIndex: 8570
{
	// Properties
	[Nullable(1)]
	private XProcessingInstruction ProcessingInstruction { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x16913C0 Offset: 0x168F9C0 VA: 0x1816913C0
	private XProcessingInstruction get_ProcessingInstruction() { }

	[NullableContext(1)]
	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0x1691340 Offset: 0x168F940 VA: 0x181691340 Slot: 15
	public override string get_LocalName() { }

	// RVA: 0x1691430 Offset: 0x168FA30 VA: 0x181691430 Slot: 19
	public override string get_Value() { }

	// RVA: 0x16914B0 Offset: 0x168FAB0 VA: 0x1816914B0 Slot: 20
	public override void set_Value(string value) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 8571
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _childNodes; // 0x18

	// Properties
	private XContainer Container { get; }
	public override List<IXmlNode> ChildNodes { get; }
	protected virtual bool HasChildNodes { get; }
	[Nullable(2)]
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0x168F5A0 Offset: 0x168DBA0 VA: 0x18168F5A0
	private XContainer get_Container() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(XContainer container) { }

	// RVA: 0x168F280 Offset: 0x168D880 VA: 0x18168F280 Slot: 16
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x168F610 Offset: 0x168DC10 VA: 0x18168F610 Slot: 23
	protected virtual bool get_HasChildNodes() { }

	[NullableContext(2)]
	// RVA: 0x168F690 Offset: 0x168DC90 VA: 0x18168F690 Slot: 18
	public override IXmlNode get_ParentNode() { }

	// RVA: 0x168EF90 Offset: 0x168D590 VA: 0x18168EF90
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0x168EEA0 Offset: 0x168D4A0 VA: 0x18168EEA0 Slot: 21
	public override IXmlNode AppendChild(IXmlNode newChild) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XObjectWrapper : IXmlNode // TypeDefIndex: 8572
{
	// Fields
	private readonly XObject _xmlObject; // 0x10

	// Properties
	public object WrappedNode { get; }
	public virtual XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	[Nullable(1)]
	public virtual List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public virtual List<IXmlNode> Attributes { get; }
	public virtual IXmlNode ParentNode { get; }
	public virtual string Value { get; set; }
	public virtual string NamespaceUri { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(XObject xmlObject) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 13
	public object get_WrappedNode() { }

	// RVA: 0x16912E0 Offset: 0x168F8E0 VA: 0x1816912E0 Slot: 14
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 15
	public virtual string get_LocalName() { }

	[NullableContext(1)]
	// RVA: 0x1691290 Offset: 0x168F890 VA: 0x181691290 Slot: 16
	public virtual List<IXmlNode> get_ChildNodes() { }

	[NullableContext(1)]
	// RVA: 0x1691240 Offset: 0x168F840 VA: 0x181691240 Slot: 17
	public virtual List<IXmlNode> get_Attributes() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 18
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 19
	public virtual string get_Value() { }

	// RVA: 0x1691300 Offset: 0x168F900 VA: 0x181691300 Slot: 20
	public virtual void set_Value(string value) { }

	[NullableContext(1)]
	// RVA: 0x1691200 Offset: 0x168F800 VA: 0x181691200 Slot: 21
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 22
	public virtual string get_NamespaceUri() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XAttributeWrapper : XObjectWrapper // TypeDefIndex: 8573
{
	// Properties
	[Nullable(1)]
	private XAttribute Attribute { get; }
	public override string Value { get; set; }
	public override string LocalName { get; }
	public override string NamespaceUri { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x168E940 Offset: 0x168CF40 VA: 0x18168E940
	private XAttribute get_Attribute() { }

	[NullableContext(1)]
	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(XAttribute attribute) { }

	// RVA: 0x168EB60 Offset: 0x168D160 VA: 0x18168EB60 Slot: 19
	public override string get_Value() { }

	// RVA: 0x168EBE0 Offset: 0x168D1E0 VA: 0x18168EBE0 Slot: 20
	public override void set_Value(string value) { }

	// RVA: 0x168E9B0 Offset: 0x168CFB0 VA: 0x18168E9B0 Slot: 15
	public override string get_LocalName() { }

	// RVA: 0x168EA30 Offset: 0x168D030 VA: 0x18168EA30 Slot: 22
	public override string get_NamespaceUri() { }

	// RVA: 0x168EAB0 Offset: 0x168D0B0 VA: 0x18168EAB0 Slot: 18
	public override IXmlNode get_ParentNode() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode // TypeDefIndex: 8574
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	private XElement Element { get; }
	public override List<IXmlNode> Attributes { get; }
	[Nullable(2)]
	public override string Value { get; set; }
	[Nullable(2)]
	public override string LocalName { get; }
	[Nullable(2)]
	public override string NamespaceUri { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1690F00 Offset: 0x168F500 VA: 0x181690F00
	private XElement get_Element() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(XElement element) { }

	// RVA: 0x16909A0 Offset: 0x168EFA0 VA: 0x1816909A0 Slot: 24
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0x1690AB0 Offset: 0x168F0B0 VA: 0x181690AB0 Slot: 17
	public override List<IXmlNode> get_Attributes() { }

	// RVA: 0x1690660 Offset: 0x168EC60 VA: 0x181690660
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	// RVA: 0x1690580 Offset: 0x168EB80 VA: 0x181690580 Slot: 21
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(2)]
	// RVA: 0x16910F0 Offset: 0x168F6F0 VA: 0x1816910F0 Slot: 19
	public override string get_Value() { }

	[NullableContext(2)]
	// RVA: 0x1691170 Offset: 0x168F770 VA: 0x181691170 Slot: 20
	public override void set_Value(string value) { }

	[NullableContext(2)]
	// RVA: 0x1690FF0 Offset: 0x168F5F0 VA: 0x181690FF0 Slot: 15
	public override string get_LocalName() { }

	[NullableContext(2)]
	// RVA: 0x1691070 Offset: 0x168F670 VA: 0x181691070 Slot: 22
	public override string get_NamespaceUri() { }

	// RVA: 0x16905C0 Offset: 0x168EBC0 VA: 0x1816905C0 Slot: 25
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0x1690F70 Offset: 0x168F570 VA: 0x181690F70 Slot: 26
	public bool get_IsEmpty() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class XmlNodeConverter : JsonConverter // TypeDefIndex: 8575
{
	// Fields
	internal static readonly List<IXmlNode> EmptyChildNodes; // 0x0
	private const string TextName = "#text";
	private const string CommentName = "#comment";
	private const string CDataName = "#cdata-section";
	private const string WhitespaceName = "#whitespace";
	private const string SignificantWhitespaceName = "#significant-whitespace";
	private const string DeclarationName = "?xml";
	private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";
	[Nullable(2)]
	[CompilerGenerated]
	private string <DeserializeRootElementName>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <WriteArrayAttribute>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <OmitRootObject>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <EncodeSpecialCharacters>k__BackingField; // 0x1A

	// Properties
	[Nullable(2)]
	public string DeserializeRootElementName { get; set; }
	public bool WriteArrayAttribute { get; set; }
	public bool OmitRootObject { get; set; }
	public bool EncodeSpecialCharacters { get; set; }

	// Methods

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_DeserializeRootElementName() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_DeserializeRootElementName(string value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_WriteArrayAttribute() { }

	[CompilerGenerated]
	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	public void set_WriteArrayAttribute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B20 Offset: 0x4E4120 VA: 0x1804E5B20
	public bool get_OmitRootObject() { }

	[CompilerGenerated]
	// RVA: 0x4E5B50 Offset: 0x4E4150 VA: 0x1804E5B50
	public void set_OmitRootObject(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1698DB0 Offset: 0x16973B0 VA: 0x181698DB0
	public bool get_EncodeSpecialCharacters() { }

	[CompilerGenerated]
	// RVA: 0x1698DC0 Offset: 0x16973C0 VA: 0x181698DC0
	public void set_EncodeSpecialCharacters(bool value) { }

	// RVA: 0x1698BD0 Offset: 0x16971D0 VA: 0x181698BD0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x16983C0 Offset: 0x16969C0 VA: 0x1816983C0
	private IXmlNode WrapXml(object value) { }

	// RVA: 0x1695010 Offset: 0x1693610 VA: 0x181695010
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x16969B0 Offset: 0x1694FB0 VA: 0x1816969B0
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x1694890 Offset: 0x1692E90 VA: 0x181694890
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x1694C20 Offset: 0x1693220 VA: 0x181694C20
	private bool IsArray(IXmlNode node) { }

	// RVA: 0x1696B60 Offset: 0x1695160 VA: 0x181696B60
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0x1698980 Offset: 0x1696F80 VA: 0x181698980
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames) { }

	// RVA: 0x1698AF0 Offset: 0x16970F0 VA: 0x181698AF0
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	// RVA: 0x16973A0 Offset: 0x16959A0 VA: 0x1816973A0
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0x16926B0 Offset: 0x1690CB0 VA: 0x1816926B0
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0x1696240 Offset: 0x1694840 VA: 0x181696240 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1694580 Offset: 0x1692B80 VA: 0x181694580
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0x1695E40 Offset: 0x1694440 VA: 0x181695E40
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0x1693370 Offset: 0x1691970 VA: 0x181693370
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) { }

	// RVA: 0x1692280 Offset: 0x1690880 VA: 0x181692280
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0x16928F0 Offset: 0x1690EF0 VA: 0x1816928F0
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0x16954D0 Offset: 0x1693AD0 VA: 0x1816954D0
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0x16924B0 Offset: 0x1690AB0 VA: 0x1816924B0
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0x1698150 Offset: 0x1696750 VA: 0x181698150
	private bool ShouldReadInto(JsonReader reader) { }

	// RVA: 0x16957A0 Offset: 0x1693DA0 VA: 0x1816957A0
	private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0x1693980 Offset: 0x1691F80 VA: 0x181693980
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0x1692FE0 Offset: 0x16915E0 VA: 0x181692FE0
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0x1693840 Offset: 0x1691E40 VA: 0x181693840
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0x1693CE0 Offset: 0x16922E0 VA: 0x181693CE0
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0x1694E30 Offset: 0x1693430 VA: 0x181694E30
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	// RVA: 0x16981E0 Offset: 0x16967E0 VA: 0x1816981E0
	private bool ValueAttributes(List<IXmlNode> c) { }

	// RVA: 0x1692840 Offset: 0x1690E40 VA: 0x181692840 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x1694F10 Offset: 0x1693510 VA: 0x181694F10
	private bool IsXObject(Type valueType) { }

	// RVA: 0x1694F90 Offset: 0x1693590 VA: 0x181694F90
	private bool IsXmlNode(Type valueType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x1698D20 Offset: 0x1697320 VA: 0x181698D20
	private static void .cctor() { }
}

