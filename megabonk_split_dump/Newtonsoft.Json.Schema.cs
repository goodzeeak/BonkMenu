// Namespace: Newtonsoft.Json.Schema
[Extension]
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public static class Extensions // TypeDefIndex: 8428
{
	// Methods

	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	// RVA: 0x1634C90 Offset: 0x1633290 VA: 0x181634C90
	public static bool IsValid(JToken source, JsonSchema schema) { }

	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	// RVA: 0x1634B40 Offset: 0x1633140 VA: 0x181634B40
	public static bool IsValid(JToken source, JsonSchema schema, out IList<string> errorMessages) { }

	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	// RVA: 0x1635050 Offset: 0x1633650 VA: 0x181635050
	public static void Validate(JToken source, JsonSchema schema) { }

	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	// RVA: 0x1634EB0 Offset: 0x16334B0 VA: 0x181634EB0
	public static void Validate(JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler) { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchema // TypeDefIndex: 8429
{
	// Fields
	[CompilerGenerated]
	private string <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<bool> <Required>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<bool> <ReadOnly>k__BackingField; // 0x22
	[CompilerGenerated]
	private Nullable<bool> <Hidden>k__BackingField; // 0x24
	[CompilerGenerated]
	private Nullable<bool> <Transient>k__BackingField; // 0x26
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<JsonSchemaType> <Type>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Pattern>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<int> <MinimumLength>k__BackingField; // 0x40
	[CompilerGenerated]
	private Nullable<int> <MaximumLength>k__BackingField; // 0x48
	[CompilerGenerated]
	private Nullable<double> <DivisibleBy>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<double> <Minimum>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<double> <Maximum>k__BackingField; // 0x70
	[CompilerGenerated]
	private Nullable<bool> <ExclusiveMinimum>k__BackingField; // 0x80
	[CompilerGenerated]
	private Nullable<bool> <ExclusiveMaximum>k__BackingField; // 0x82
	[CompilerGenerated]
	private Nullable<int> <MinimumItems>k__BackingField; // 0x84
	[CompilerGenerated]
	private Nullable<int> <MaximumItems>k__BackingField; // 0x8C
	[CompilerGenerated]
	private IList<JsonSchema> <Items>k__BackingField; // 0x98
	[CompilerGenerated]
	private bool <PositionalItemsValidation>k__BackingField; // 0xA0
	[CompilerGenerated]
	private JsonSchema <AdditionalItems>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <AllowAdditionalItems>k__BackingField; // 0xB0
	[CompilerGenerated]
	private bool <UniqueItems>k__BackingField; // 0xB1
	[CompilerGenerated]
	private IDictionary<string, JsonSchema> <Properties>k__BackingField; // 0xB8
	[CompilerGenerated]
	private JsonSchema <AdditionalProperties>k__BackingField; // 0xC0
	[CompilerGenerated]
	private IDictionary<string, JsonSchema> <PatternProperties>k__BackingField; // 0xC8
	[CompilerGenerated]
	private bool <AllowAdditionalProperties>k__BackingField; // 0xD0
	[CompilerGenerated]
	private string <Requires>k__BackingField; // 0xD8
	[CompilerGenerated]
	private IList<JToken> <Enum>k__BackingField; // 0xE0
	[CompilerGenerated]
	private Nullable<JsonSchemaType> <Disallow>k__BackingField; // 0xE8
	[CompilerGenerated]
	private JToken <Default>k__BackingField; // 0xF0
	[CompilerGenerated]
	private IList<JsonSchema> <Extends>k__BackingField; // 0xF8
	[CompilerGenerated]
	private string <Format>k__BackingField; // 0x100
	[CompilerGenerated]
	private string <Location>k__BackingField; // 0x108
	private readonly string _internalId; // 0x110
	[CompilerGenerated]
	private string <DeferredReference>k__BackingField; // 0x118
	[CompilerGenerated]
	private bool <ReferencesResolved>k__BackingField; // 0x120

	// Properties
	public string Id { get; set; }
	public string Title { get; set; }
	public Nullable<bool> Required { get; set; }
	public Nullable<bool> ReadOnly { get; set; }
	public Nullable<bool> Hidden { get; set; }
	public Nullable<bool> Transient { get; set; }
	public string Description { get; set; }
	public Nullable<JsonSchemaType> Type { get; set; }
	public string Pattern { get; set; }
	public Nullable<int> MinimumLength { get; set; }
	public Nullable<int> MaximumLength { get; set; }
	public Nullable<double> DivisibleBy { get; set; }
	public Nullable<double> Minimum { get; set; }
	public Nullable<double> Maximum { get; set; }
	public Nullable<bool> ExclusiveMinimum { get; set; }
	public Nullable<bool> ExclusiveMaximum { get; set; }
	public Nullable<int> MinimumItems { get; set; }
	public Nullable<int> MaximumItems { get; set; }
	public IList<JsonSchema> Items { get; set; }
	public bool PositionalItemsValidation { get; set; }
	public JsonSchema AdditionalItems { get; set; }
	public bool AllowAdditionalItems { get; set; }
	public bool UniqueItems { get; set; }
	public IDictionary<string, JsonSchema> Properties { get; set; }
	public JsonSchema AdditionalProperties { get; set; }
	public IDictionary<string, JsonSchema> PatternProperties { get; set; }
	public bool AllowAdditionalProperties { get; set; }
	public string Requires { get; set; }
	public IList<JToken> Enum { get; set; }
	public Nullable<JsonSchemaType> Disallow { get; set; }
	public JToken Default { get; set; }
	public IList<JsonSchema> Extends { get; set; }
	public string Format { get; set; }
	internal string Location { get; set; }
	internal string InternalId { get; }
	internal string DeferredReference { get; set; }
	internal bool ReferencesResolved { get; set; }

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
	// RVA: 0x15B2F60 Offset: 0x15B1560 VA: 0x1815B2F60
	public Nullable<bool> get_Required() { }

	[CompilerGenerated]
	// RVA: 0x15B31B0 Offset: 0x15B17B0 VA: 0x1815B31B0
	public void set_Required(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1641070 Offset: 0x163F670 VA: 0x181641070
	public Nullable<bool> get_ReadOnly() { }

	[CompilerGenerated]
	// RVA: 0x1641170 Offset: 0x163F770 VA: 0x181641170
	public void set_ReadOnly(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1641030 Offset: 0x163F630 VA: 0x181641030
	public Nullable<bool> get_Hidden() { }

	[CompilerGenerated]
	// RVA: 0x1641110 Offset: 0x163F710 VA: 0x181641110
	public void set_Hidden(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1641080 Offset: 0x163F680 VA: 0x181641080
	public Nullable<bool> get_Transient() { }

	[CompilerGenerated]
	// RVA: 0x1641180 Offset: 0x163F780 VA: 0x181641180
	public void set_Transient(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public Nullable<JsonSchemaType> get_Type() { }

	[CompilerGenerated]
	// RVA: 0x1641190 Offset: 0x163F790 VA: 0x181641190
	public void set_Type(Nullable<JsonSchemaType> value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_Pattern() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_Pattern(string value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public Nullable<int> get_MinimumLength() { }

	[CompilerGenerated]
	// RVA: 0xAC52C0 Offset: 0xAC38C0 VA: 0x180AC52C0
	public void set_MinimumLength(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public Nullable<int> get_MaximumLength() { }

	[CompilerGenerated]
	// RVA: 0x1641130 Offset: 0x163F730 VA: 0x181641130
	public void set_MaximumLength(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x9E35B0 Offset: 0x9E1BB0 VA: 0x1809E35B0
	public Nullable<double> get_DivisibleBy() { }

	[CompilerGenerated]
	// RVA: 0x16410E0 Offset: 0x163F6E0 VA: 0x1816410E0
	public void set_DivisibleBy(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x15B7430 Offset: 0x15B5A30 VA: 0x1815B7430
	public Nullable<double> get_Minimum() { }

	[CompilerGenerated]
	// RVA: 0x1641160 Offset: 0x163F760 VA: 0x181641160
	public void set_Minimum(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x1641050 Offset: 0x163F650 VA: 0x181641050
	public Nullable<double> get_Maximum() { }

	[CompilerGenerated]
	// RVA: 0x1641140 Offset: 0x163F740 VA: 0x181641140
	public void set_Maximum(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x15D1070 Offset: 0x15CF670 VA: 0x1815D1070
	public Nullable<bool> get_ExclusiveMinimum() { }

	[CompilerGenerated]
	// RVA: 0x1641100 Offset: 0x163F700 VA: 0x181641100
	public void set_ExclusiveMinimum(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1641020 Offset: 0x163F620 VA: 0x181641020
	public Nullable<bool> get_ExclusiveMaximum() { }

	[CompilerGenerated]
	// RVA: 0x16410F0 Offset: 0x163F6F0 VA: 0x1816410F0
	public void set_ExclusiveMaximum(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1641060 Offset: 0x163F660 VA: 0x181641060
	public Nullable<int> get_MinimumItems() { }

	[CompilerGenerated]
	// RVA: 0x1641150 Offset: 0x163F750 VA: 0x181641150
	public void set_MinimumItems(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x1641040 Offset: 0x163F640 VA: 0x181641040
	public Nullable<int> get_MaximumItems() { }

	[CompilerGenerated]
	// RVA: 0x1641120 Offset: 0x163F720 VA: 0x181641120
	public void set_MaximumItems(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public IList<JsonSchema> get_Items() { }

	[CompilerGenerated]
	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	public void set_Items(IList<JsonSchema> value) { }

	[CompilerGenerated]
	// RVA: 0x156F940 Offset: 0x156DF40 VA: 0x18156F940
	public bool get_PositionalItemsValidation() { }

	[CompilerGenerated]
	// RVA: 0x163E120 Offset: 0x163C720 VA: 0x18163E120
	public void set_PositionalItemsValidation(bool value) { }

	[CompilerGenerated]
	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public JsonSchema get_AdditionalItems() { }

	[CompilerGenerated]
	// RVA: 0x163E0C0 Offset: 0x163C6C0 VA: 0x18163E0C0
	public void set_AdditionalItems(JsonSchema value) { }

	[CompilerGenerated]
	// RVA: 0x1641010 Offset: 0x163F610 VA: 0x181641010
	public bool get_AllowAdditionalItems() { }

	[CompilerGenerated]
	// RVA: 0x16410A0 Offset: 0x163F6A0 VA: 0x1816410A0
	public void set_AllowAdditionalItems(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1641090 Offset: 0x163F690 VA: 0x181641090
	public bool get_UniqueItems() { }

	[CompilerGenerated]
	// RVA: 0x16411A0 Offset: 0x163F7A0 VA: 0x1816411A0
	public void set_UniqueItems(bool value) { }

	[CompilerGenerated]
	// RVA: 0x131C550 Offset: 0x131AB50 VA: 0x18131C550
	public IDictionary<string, JsonSchema> get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x8221D0 Offset: 0x8207D0 VA: 0x1808221D0
	public void set_Properties(IDictionary<string, JsonSchema> value) { }

	[CompilerGenerated]
	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public JsonSchema get_AdditionalProperties() { }

	[CompilerGenerated]
	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	public void set_AdditionalProperties(JsonSchema value) { }

	[CompilerGenerated]
	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	public IDictionary<string, JsonSchema> get_PatternProperties() { }

	[CompilerGenerated]
	// RVA: 0x1621970 Offset: 0x161FF70 VA: 0x181621970
	public void set_PatternProperties(IDictionary<string, JsonSchema> value) { }

	[CompilerGenerated]
	// RVA: 0x47E990 Offset: 0x47CF90 VA: 0x18047E990
	public bool get_AllowAdditionalProperties() { }

	[CompilerGenerated]
	// RVA: 0x47E9A0 Offset: 0x47CFA0 VA: 0x18047E9A0
	public void set_AllowAdditionalProperties(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3A3640 Offset: 0x3A1C40 VA: 0x1803A3640
	public string get_Requires() { }

	[CompilerGenerated]
	// RVA: 0x15B40E0 Offset: 0x15B26E0 VA: 0x1815B40E0
	public void set_Requires(string value) { }

	[CompilerGenerated]
	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	public IList<JToken> get_Enum() { }

	[CompilerGenerated]
	// RVA: 0x12F1A10 Offset: 0x12F0010 VA: 0x1812F1A10
	public void set_Enum(IList<JToken> value) { }

	[CompilerGenerated]
	// RVA: 0x5513E0 Offset: 0x54F9E0 VA: 0x1805513E0
	public Nullable<JsonSchemaType> get_Disallow() { }

	[CompilerGenerated]
	// RVA: 0x16410D0 Offset: 0x163F6D0 VA: 0x1816410D0
	public void set_Disallow(Nullable<JsonSchemaType> value) { }

	[CompilerGenerated]
	// RVA: 0x551B80 Offset: 0x550180 VA: 0x180551B80
	public JToken get_Default() { }

	[CompilerGenerated]
	// RVA: 0x551B90 Offset: 0x550190 VA: 0x180551B90
	public void set_Default(JToken value) { }

	[CompilerGenerated]
	// RVA: 0x5612C0 Offset: 0x55F8C0 VA: 0x1805612C0
	public IList<JsonSchema> get_Extends() { }

	[CompilerGenerated]
	// RVA: 0x15B4860 Offset: 0x15B2E60 VA: 0x1815B4860
	public void set_Extends(IList<JsonSchema> value) { }

	[CompilerGenerated]
	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public string get_Format() { }

	[CompilerGenerated]
	// RVA: 0x15B47E0 Offset: 0x15B2DE0 VA: 0x1815B47E0
	public void set_Format(string value) { }

	[CompilerGenerated]
	// RVA: 0x15B3B70 Offset: 0x15B2170 VA: 0x1815B3B70
	internal string get_Location() { }

	[CompilerGenerated]
	// RVA: 0x15B42C0 Offset: 0x15B28C0 VA: 0x1815B42C0
	internal void set_Location(string value) { }

	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	internal string get_InternalId() { }

	[CompilerGenerated]
	// RVA: 0x1634AF0 Offset: 0x16330F0 VA: 0x181634AF0
	internal string get_DeferredReference() { }

	[CompilerGenerated]
	// RVA: 0x16410B0 Offset: 0x163F6B0 VA: 0x1816410B0
	internal void set_DeferredReference(string value) { }

	[CompilerGenerated]
	// RVA: 0x16211E0 Offset: 0x161F7E0 VA: 0x1816211E0
	internal bool get_ReferencesResolved() { }

	[CompilerGenerated]
	// RVA: 0x16212E0 Offset: 0x161F8E0 VA: 0x1816212E0
	internal void set_ReferencesResolved(bool value) { }

	// RVA: 0x1640F80 Offset: 0x163F580 VA: 0x181640F80
	public void .ctor() { }

	// RVA: 0x16408A0 Offset: 0x163EEA0 VA: 0x1816408A0
	public static JsonSchema Read(JsonReader reader) { }

	// RVA: 0x1640900 Offset: 0x163EF00 VA: 0x181640900
	public static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver) { }

	// RVA: 0x1640700 Offset: 0x163ED00 VA: 0x181640700
	public static JsonSchema Parse(string json) { }

	// RVA: 0x1640760 Offset: 0x163ED60 VA: 0x181640760
	public static JsonSchema Parse(string json, JsonSchemaResolver resolver) { }

	// RVA: 0x1640E50 Offset: 0x163F450 VA: 0x181640E50
	public void WriteTo(JsonWriter writer) { }

	// RVA: 0x1640D50 Offset: 0x163F350 VA: 0x181640D50
	public void WriteTo(JsonWriter writer, JsonSchemaResolver resolver) { }

	// RVA: 0x1640B50 Offset: 0x163F150 VA: 0x181640B50 Slot: 3
	public override string ToString() { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaBuilder // TypeDefIndex: 8431
{
	// Fields
	private readonly IList<JsonSchema> _stack; // 0x10
	private readonly JsonSchemaResolver _resolver; // 0x18
	private readonly IDictionary<string, JsonSchema> _documentSchemas; // 0x20
	private JsonSchema _currentSchema; // 0x28
	private JObject _rootSchema; // 0x30

	// Properties
	private JsonSchema CurrentSchema { get; }

	// Methods

	// RVA: 0x1639F50 Offset: 0x1638550 VA: 0x181639F50
	public void .ctor(JsonSchemaResolver resolver) { }

	// RVA: 0x1639230 Offset: 0x1637830 VA: 0x181639230
	private void Push(JsonSchema value) { }

	// RVA: 0x1636C90 Offset: 0x1635290 VA: 0x181636C90
	private JsonSchema Pop() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	private JsonSchema get_CurrentSchema() { }

	// RVA: 0x1639300 Offset: 0x1637900 VA: 0x181639300
	internal JsonSchema Read(JsonReader reader) { }

	// RVA: 0x1639E90 Offset: 0x1638490 VA: 0x181639E90
	private string UnescapeReference(string reference) { }

	// RVA: 0x1639420 Offset: 0x1637A20 VA: 0x181639420
	private JsonSchema ResolveReferences(JsonSchema schema) { }

	// RVA: 0x16364F0 Offset: 0x1634AF0 VA: 0x1816364F0
	private JsonSchema BuildSchema(JToken token) { }

	// RVA: 0x1637E30 Offset: 0x1636430 VA: 0x181637E30
	private void ProcessSchemaProperties(JObject schemaObject) { }

	// RVA: 0x16372C0 Offset: 0x16358C0 VA: 0x1816372C0
	private void ProcessExtends(JToken token) { }

	// RVA: 0x1636F10 Offset: 0x1635510 VA: 0x181636F10
	private void ProcessEnum(JToken token) { }

	// RVA: 0x1636E30 Offset: 0x1635430 VA: 0x181636E30
	private void ProcessAdditionalProperties(JToken token) { }

	// RVA: 0x1636D50 Offset: 0x1635350 VA: 0x181636D50
	private void ProcessAdditionalItems(JToken token) { }

	// RVA: 0x1637A00 Offset: 0x1636000 VA: 0x181637A00
	private IDictionary<string, JsonSchema> ProcessProperties(JToken token) { }

	// RVA: 0x1637600 Offset: 0x1635C00 VA: 0x181637600
	private void ProcessItems(JToken token) { }

	// RVA: 0x1638E10 Offset: 0x1637410 VA: 0x181638E10
	private Nullable<JsonSchemaType> ProcessType(JToken token) { }

	// RVA: 0x1636B10 Offset: 0x1635110 VA: 0x181636B10
	internal static JsonSchemaType MapType(string type) { }

	// RVA: 0x1636A00 Offset: 0x1635000 VA: 0x181636A00
	internal static string MapType(JsonSchemaType type) { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal static class JsonSchemaConstants // TypeDefIndex: 8432
{
	// Fields
	public const string TypePropertyName = "type";
	public const string PropertiesPropertyName = "properties";
	public const string ItemsPropertyName = "items";
	public const string AdditionalItemsPropertyName = "additionalItems";
	public const string RequiredPropertyName = "required";
	public const string PatternPropertiesPropertyName = "patternProperties";
	public const string AdditionalPropertiesPropertyName = "additionalProperties";
	public const string RequiresPropertyName = "requires";
	public const string MinimumPropertyName = "minimum";
	public const string MaximumPropertyName = "maximum";
	public const string ExclusiveMinimumPropertyName = "exclusiveMinimum";
	public const string ExclusiveMaximumPropertyName = "exclusiveMaximum";
	public const string MinimumItemsPropertyName = "minItems";
	public const string MaximumItemsPropertyName = "maxItems";
	public const string PatternPropertyName = "pattern";
	public const string MaximumLengthPropertyName = "maxLength";
	public const string MinimumLengthPropertyName = "minLength";
	public const string EnumPropertyName = "enum";
	public const string ReadOnlyPropertyName = "readonly";
	public const string TitlePropertyName = "title";
	public const string DescriptionPropertyName = "description";
	public const string FormatPropertyName = "format";
	public const string DefaultPropertyName = "default";
	public const string TransientPropertyName = "transient";
	public const string DivisibleByPropertyName = "divisibleBy";
	public const string HiddenPropertyName = "hidden";
	public const string DisallowPropertyName = "disallow";
	public const string ExtendsPropertyName = "extends";
	public const string IdPropertyName = "id";
	public const string UniqueItemsPropertyName = "uniqueItems";
	public const string OptionValuePropertyName = "value";
	public const string OptionLabelPropertyName = "label";
	public static readonly IDictionary<string, JsonSchemaType> JsonSchemaTypeMapping; // 0x0

	// Methods

	// RVA: 0x163A030 Offset: 0x1638630 VA: 0x18163A030
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
[Serializable]
public class JsonSchemaException : JsonException // TypeDefIndex: 8433
{
	// Fields
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; // 0x94
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x98

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public string Path { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	public int get_LineNumber() { }

	[CompilerGenerated]
	// RVA: 0x12ECA90 Offset: 0x12EB090 VA: 0x1812ECA90
	public int get_LinePosition() { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public string get_Path() { }

	// RVA: 0x1609E40 Offset: 0x1608440 VA: 0x181609E40
	public void .ctor() { }

	// RVA: 0x1609E50 Offset: 0x1608450 VA: 0x181609E50
	public void .ctor(string message) { }

	// RVA: 0x1609DF0 Offset: 0x16083F0 VA: 0x181609DF0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1609DD0 Offset: 0x16083D0 VA: 0x181609DD0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x163A220 Offset: 0x1638820 VA: 0x18163A220
	internal void .ctor(string message, Exception innerException, string path, int lineNumber, int linePosition) { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchemaGenerator // TypeDefIndex: 8436
{
	// Fields
	[CompilerGenerated]
	private UndefinedSchemaIdHandling <UndefinedSchemaIdHandling>k__BackingField; // 0x10
	private IContractResolver _contractResolver; // 0x18
	private JsonSchemaResolver _resolver; // 0x20
	private readonly IList<JsonSchemaGenerator.TypeSchema> _stack; // 0x28
	private JsonSchema _currentSchema; // 0x30

	// Properties
	public UndefinedSchemaIdHandling UndefinedSchemaIdHandling { get; set; }
	public IContractResolver ContractResolver { get; set; }
	private JsonSchema CurrentSchema { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public UndefinedSchemaIdHandling get_UndefinedSchemaIdHandling() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_UndefinedSchemaIdHandling(UndefinedSchemaIdHandling value) { }

	// RVA: 0x163C4B0 Offset: 0x163AAB0 VA: 0x18163C4B0
	public IContractResolver get_ContractResolver() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	private JsonSchema get_CurrentSchema() { }

	// RVA: 0x163C320 Offset: 0x163A920 VA: 0x18163C320
	private void Push(JsonSchemaGenerator.TypeSchema typeSchema) { }

	// RVA: 0x163C1B0 Offset: 0x163A7B0 VA: 0x18163C1B0
	private JsonSchemaGenerator.TypeSchema Pop() { }

	// RVA: 0x163BBB0 Offset: 0x163A1B0 VA: 0x18163BBB0
	public JsonSchema Generate(Type type) { }

	// RVA: 0x163BB90 Offset: 0x163A190 VA: 0x18163BB90
	public JsonSchema Generate(Type type, JsonSchemaResolver resolver) { }

	// RVA: 0x163BA40 Offset: 0x163A040 VA: 0x18163BA40
	public JsonSchema Generate(Type type, bool rootSchemaNullable) { }

	// RVA: 0x163BAD0 Offset: 0x163A0D0 VA: 0x18163BAD0
	public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable) { }

	// RVA: 0x163BF30 Offset: 0x163A530 VA: 0x18163BF30
	private string GetTitle(Type type) { }

	// RVA: 0x163BC30 Offset: 0x163A230 VA: 0x18163BC30
	private string GetDescription(Type type) { }

	// RVA: 0x163BFC0 Offset: 0x163A5C0 VA: 0x18163BFC0
	private string GetTypeId(Type type, bool explicitOnly) { }

	// RVA: 0x163A2A0 Offset: 0x16388A0 VA: 0x18163A2A0
	private JsonSchema GenerateInternal(Type type, Required valueRequired, bool required) { }

	// RVA: 0x163A270 Offset: 0x1638870 VA: 0x18163A270
	private JsonSchemaType AddNullType(JsonSchemaType type, Required valueRequired) { }

	// RVA: 0x14042E0 Offset: 0x14028E0 VA: 0x1814042E0
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x163B680 Offset: 0x1639C80 VA: 0x18163B680
	private void GenerateObjectSchema(Type type, JsonObjectContract contract) { }

	// RVA: 0x163A280 Offset: 0x1638880 VA: 0x18163A280
	private void GenerateISerializableContract(Type type, JsonISerializableContract contract) { }

	// RVA: 0x163C0C0 Offset: 0x163A6C0 VA: 0x18163C0C0
	internal static bool HasFlag(Nullable<JsonSchemaType> value, JsonSchemaType flag) { }

	// RVA: 0x163BD30 Offset: 0x163A330 VA: 0x18163BD30
	private JsonSchemaType GetJsonSchemaType(Type type, Required valueRequired) { }

	// RVA: 0x163C430 Offset: 0x163AA30 VA: 0x18163C430
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaModel // TypeDefIndex: 8437
{
	// Fields
	[CompilerGenerated]
	private bool <Required>k__BackingField; // 0x10
	[CompilerGenerated]
	private JsonSchemaType <Type>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<int> <MinimumLength>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<int> <MaximumLength>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<double> <DivisibleBy>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<double> <Minimum>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<double> <Maximum>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <ExclusiveMinimum>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <ExclusiveMaximum>k__BackingField; // 0x59
	[CompilerGenerated]
	private Nullable<int> <MinimumItems>k__BackingField; // 0x5C
	[CompilerGenerated]
	private Nullable<int> <MaximumItems>k__BackingField; // 0x64
	[CompilerGenerated]
	private IList<string> <Patterns>k__BackingField; // 0x70
	[CompilerGenerated]
	private IList<JsonSchemaModel> <Items>k__BackingField; // 0x78
	[CompilerGenerated]
	private IDictionary<string, JsonSchemaModel> <Properties>k__BackingField; // 0x80
	[CompilerGenerated]
	private IDictionary<string, JsonSchemaModel> <PatternProperties>k__BackingField; // 0x88
	[CompilerGenerated]
	private JsonSchemaModel <AdditionalProperties>k__BackingField; // 0x90
	[CompilerGenerated]
	private JsonSchemaModel <AdditionalItems>k__BackingField; // 0x98
	[CompilerGenerated]
	private bool <PositionalItemsValidation>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <AllowAdditionalProperties>k__BackingField; // 0xA1
	[CompilerGenerated]
	private bool <AllowAdditionalItems>k__BackingField; // 0xA2
	[CompilerGenerated]
	private bool <UniqueItems>k__BackingField; // 0xA3
	[CompilerGenerated]
	private IList<JToken> <Enum>k__BackingField; // 0xA8
	[CompilerGenerated]
	private JsonSchemaType <Disallow>k__BackingField; // 0xB0

	// Properties
	public bool Required { get; set; }
	public JsonSchemaType Type { get; set; }
	public Nullable<int> MinimumLength { get; set; }
	public Nullable<int> MaximumLength { get; set; }
	public Nullable<double> DivisibleBy { get; set; }
	public Nullable<double> Minimum { get; set; }
	public Nullable<double> Maximum { get; set; }
	public bool ExclusiveMinimum { get; set; }
	public bool ExclusiveMaximum { get; set; }
	public Nullable<int> MinimumItems { get; set; }
	public Nullable<int> MaximumItems { get; set; }
	public IList<string> Patterns { get; set; }
	public IList<JsonSchemaModel> Items { get; set; }
	public IDictionary<string, JsonSchemaModel> Properties { get; set; }
	public IDictionary<string, JsonSchemaModel> PatternProperties { get; set; }
	public JsonSchemaModel AdditionalProperties { get; set; }
	public JsonSchemaModel AdditionalItems { get; set; }
	public bool PositionalItemsValidation { get; set; }
	public bool AllowAdditionalProperties { get; set; }
	public bool AllowAdditionalItems { get; set; }
	public bool UniqueItems { get; set; }
	public IList<JToken> Enum { get; set; }
	public JsonSchemaType Disallow { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_Required() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_Required(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public JsonSchemaType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_Type(JsonSchemaType value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Nullable<int> get_MinimumLength() { }

	[CompilerGenerated]
	// RVA: 0x14A5B00 Offset: 0x14A4100 VA: 0x1814A5B00
	public void set_MinimumLength(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Nullable<int> get_MaximumLength() { }

	[CompilerGenerated]
	// RVA: 0x163E100 Offset: 0x163C700 VA: 0x18163E100
	public void set_MaximumLength(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x1116670 Offset: 0x1114C70 VA: 0x181116670
	public Nullable<double> get_DivisibleBy() { }

	[CompilerGenerated]
	// RVA: 0x14DAB40 Offset: 0x14D9140 VA: 0x1814DAB40
	public void set_DivisibleBy(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x163E080 Offset: 0x163C680 VA: 0x18163E080
	public Nullable<double> get_Minimum() { }

	[CompilerGenerated]
	// RVA: 0x163E110 Offset: 0x163C710 VA: 0x18163E110
	public void set_Minimum(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x494CC0 Offset: 0x4932C0 VA: 0x180494CC0
	public Nullable<double> get_Maximum() { }

	[CompilerGenerated]
	// RVA: 0x494CD0 Offset: 0x4932D0 VA: 0x180494CD0
	public void set_Maximum(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	public bool get_ExclusiveMinimum() { }

	[CompilerGenerated]
	// RVA: 0x3B9A60 Offset: 0x3B8060 VA: 0x1803B9A60
	public void set_ExclusiveMinimum(bool value) { }

	[CompilerGenerated]
	// RVA: 0x140E320 Offset: 0x140C920 VA: 0x18140E320
	public bool get_ExclusiveMaximum() { }

	[CompilerGenerated]
	// RVA: 0x163E0E0 Offset: 0x163C6E0 VA: 0x18163E0E0
	public void set_ExclusiveMaximum(bool value) { }

	[CompilerGenerated]
	// RVA: 0x132E3A0 Offset: 0x132C9A0 VA: 0x18132E3A0
	public Nullable<int> get_MinimumItems() { }

	[CompilerGenerated]
	// RVA: 0x132E3E0 Offset: 0x132C9E0 VA: 0x18132E3E0
	public void set_MinimumItems(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x163E070 Offset: 0x163C670 VA: 0x18163E070
	public Nullable<int> get_MaximumItems() { }

	[CompilerGenerated]
	// RVA: 0x163E0F0 Offset: 0x163C6F0 VA: 0x18163E0F0
	public void set_MaximumItems(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public IList<string> get_Patterns() { }

	[CompilerGenerated]
	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void set_Patterns(IList<string> value) { }

	[CompilerGenerated]
	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public IList<JsonSchemaModel> get_Items() { }

	[CompilerGenerated]
	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	public void set_Items(IList<JsonSchemaModel> value) { }

	[CompilerGenerated]
	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public IDictionary<string, JsonSchemaModel> get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	public void set_Properties(IDictionary<string, JsonSchemaModel> value) { }

	[CompilerGenerated]
	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	public IDictionary<string, JsonSchemaModel> get_PatternProperties() { }

	[CompilerGenerated]
	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	public void set_PatternProperties(IDictionary<string, JsonSchemaModel> value) { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public JsonSchemaModel get_AdditionalProperties() { }

	[CompilerGenerated]
	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	public void set_AdditionalProperties(JsonSchemaModel value) { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public JsonSchemaModel get_AdditionalItems() { }

	[CompilerGenerated]
	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	public void set_AdditionalItems(JsonSchemaModel value) { }

	[CompilerGenerated]
	// RVA: 0x156F940 Offset: 0x156DF40 VA: 0x18156F940
	public bool get_PositionalItemsValidation() { }

	[CompilerGenerated]
	// RVA: 0x163E120 Offset: 0x163C720 VA: 0x18163E120
	public void set_PositionalItemsValidation(bool value) { }

	[CompilerGenerated]
	// RVA: 0x163E060 Offset: 0x163C660 VA: 0x18163E060
	public bool get_AllowAdditionalProperties() { }

	[CompilerGenerated]
	// RVA: 0x163E0A0 Offset: 0x163C6A0 VA: 0x18163E0A0
	public void set_AllowAdditionalProperties(bool value) { }

	[CompilerGenerated]
	// RVA: 0x163E050 Offset: 0x163C650 VA: 0x18163E050
	public bool get_AllowAdditionalItems() { }

	[CompilerGenerated]
	// RVA: 0x163E090 Offset: 0x163C690 VA: 0x18163E090
	public void set_AllowAdditionalItems(bool value) { }

	[CompilerGenerated]
	// RVA: 0x353EA0 Offset: 0x3524A0 VA: 0x180353EA0
	public bool get_UniqueItems() { }

	[CompilerGenerated]
	// RVA: 0x163E130 Offset: 0x163C730 VA: 0x18163E130
	public void set_UniqueItems(bool value) { }

	[CompilerGenerated]
	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public IList<JToken> get_Enum() { }

	[CompilerGenerated]
	// RVA: 0x163E0C0 Offset: 0x163C6C0 VA: 0x18163E0C0
	public void set_Enum(IList<JToken> value) { }

	[CompilerGenerated]
	// RVA: 0x3A35F0 Offset: 0x3A1BF0 VA: 0x1803A35F0
	public JsonSchemaType get_Disallow() { }

	[CompilerGenerated]
	// RVA: 0x163E0B0 Offset: 0x163C6B0 VA: 0x18163E0B0
	public void set_Disallow(JsonSchemaType value) { }

	// RVA: 0x163E020 Offset: 0x163C620 VA: 0x18163E020
	public void .ctor() { }

	// RVA: 0x163DE30 Offset: 0x163C430 VA: 0x18163DE30
	public static JsonSchemaModel Create(IList<JsonSchema> schemata) { }

	// RVA: 0x163DAA0 Offset: 0x163C0A0 VA: 0x18163DAA0
	private static void Combine(JsonSchemaModel model, JsonSchema schema) { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaModelBuilder // TypeDefIndex: 8438
{
	// Fields
	private JsonSchemaNodeCollection _nodes; // 0x10
	private Dictionary<JsonSchemaNode, JsonSchemaModel> _nodeModels; // 0x18
	private JsonSchemaNode _node; // 0x20

	// Methods

	// RVA: 0x163D8D0 Offset: 0x163BED0 VA: 0x18163D8D0
	public JsonSchemaModel Build(JsonSchema schema) { }

	// RVA: 0x163CBC0 Offset: 0x163B1C0 VA: 0x18163CBC0
	public JsonSchemaNode AddSchema(JsonSchemaNode existingNode, JsonSchema schema) { }

	// RVA: 0x163C720 Offset: 0x163AD20 VA: 0x18163C720
	public void AddProperties(IDictionary<string, JsonSchema> source, IDictionary<string, JsonSchemaNode> target) { }

	// RVA: 0x163CA50 Offset: 0x163B050 VA: 0x18163CA50
	public void AddProperty(IDictionary<string, JsonSchemaNode> target, string propertyName, JsonSchema schema) { }

	// RVA: 0x163C5D0 Offset: 0x163ABD0 VA: 0x18163C5D0
	public void AddItem(JsonSchemaNode parentNode, int index, JsonSchema schema) { }

	// RVA: 0x163C590 Offset: 0x163AB90 VA: 0x18163C590
	public void AddAdditionalProperties(JsonSchemaNode parentNode, JsonSchema schema) { }

	// RVA: 0x163C550 Offset: 0x163AB50 VA: 0x18163C550
	public void AddAdditionalItems(JsonSchemaNode parentNode, JsonSchema schema) { }

	// RVA: 0x163D230 Offset: 0x163B830 VA: 0x18163D230
	private JsonSchemaModel BuildNodeModel(JsonSchemaNode node) { }

	// RVA: 0x163D9D0 Offset: 0x163BFD0 VA: 0x18163D9D0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaNode // TypeDefIndex: 8440
{
	// Fields
	[CompilerGenerated]
	private readonly string <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<JsonSchema> <Schemas>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Dictionary<string, JsonSchemaNode> <Properties>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Dictionary<string, JsonSchemaNode> <PatternProperties>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly List<JsonSchemaNode> <Items>k__BackingField; // 0x30
	[CompilerGenerated]
	private JsonSchemaNode <AdditionalProperties>k__BackingField; // 0x38
	[CompilerGenerated]
	private JsonSchemaNode <AdditionalItems>k__BackingField; // 0x40

	// Properties
	public string Id { get; }
	public ReadOnlyCollection<JsonSchema> Schemas { get; }
	public Dictionary<string, JsonSchemaNode> Properties { get; }
	public Dictionary<string, JsonSchemaNode> PatternProperties { get; }
	public List<JsonSchemaNode> Items { get; }
	public JsonSchemaNode AdditionalProperties { get; set; }
	public JsonSchemaNode AdditionalItems { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Id() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ReadOnlyCollection<JsonSchema> get_Schemas() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Dictionary<string, JsonSchemaNode> get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Dictionary<string, JsonSchemaNode> get_PatternProperties() { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public List<JsonSchemaNode> get_Items() { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public JsonSchemaNode get_AdditionalProperties() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_AdditionalProperties(JsonSchemaNode value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public JsonSchemaNode get_AdditionalItems() { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_AdditionalItems(JsonSchemaNode value) { }

	// RVA: 0x163E470 Offset: 0x163CA70 VA: 0x18163E470
	public void .ctor(JsonSchema schema) { }

	// RVA: 0x163E650 Offset: 0x163CC50 VA: 0x18163E650
	private void .ctor(JsonSchemaNode source, JsonSchema schema) { }

	// RVA: 0x163E180 Offset: 0x163C780 VA: 0x18163E180
	public JsonSchemaNode Combine(JsonSchema schema) { }

	// RVA: 0x163E1F0 Offset: 0x163C7F0 VA: 0x18163E1F0
	public static string GetId(IEnumerable<JsonSchema> schemata) { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaNodeCollection : KeyedCollection<string, JsonSchemaNode> // TypeDefIndex: 8441
{
	// Methods

	// RVA: 0x3CFB00 Offset: 0x3CE100 VA: 0x1803CFB00 Slot: 39
	protected override string GetKeyForItem(JsonSchemaNode item) { }

	// RVA: 0x163E140 Offset: 0x163C740 VA: 0x18163E140
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchemaResolver // TypeDefIndex: 8443
{
	// Fields
	[CompilerGenerated]
	private IList<JsonSchema> <LoadedSchemas>k__BackingField; // 0x10

	// Properties
	public IList<JsonSchema> LoadedSchemas { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public IList<JsonSchema> get_LoadedSchemas() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	protected void set_LoadedSchemas(IList<JsonSchema> value) { }

	// RVA: 0x163E9F0 Offset: 0x163CFF0 VA: 0x18163E9F0
	public void .ctor() { }

	// RVA: 0x163E8C0 Offset: 0x163CEC0 VA: 0x18163E8C0 Slot: 4
	public virtual JsonSchema GetSchema(string reference) { }
}

// Namespace: Newtonsoft.Json.Schema
[Flags]
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public enum JsonSchemaType // TypeDefIndex: 8444
{
	// Fields
	public int value__; // 0x0
	public const JsonSchemaType None = 0;
	public const JsonSchemaType String = 1;
	public const JsonSchemaType Float = 2;
	public const JsonSchemaType Integer = 4;
	public const JsonSchemaType Boolean = 8;
	public const JsonSchemaType Object = 16;
	public const JsonSchemaType Array = 32;
	public const JsonSchemaType Null = 64;
	public const JsonSchemaType Any = 127;
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaWriter // TypeDefIndex: 8446
{
	// Fields
	private readonly JsonWriter _writer; // 0x10
	private readonly JsonSchemaResolver _resolver; // 0x18

	// Methods

	// RVA: 0x1640680 Offset: 0x163EC80 VA: 0x181640680
	public void .ctor(JsonWriter writer, JsonSchemaResolver resolver) { }

	// RVA: 0x163EA70 Offset: 0x163D070 VA: 0x18163EA70
	private void ReferenceOrWriteSchema(JsonSchema schema) { }

	// RVA: 0x163F0F0 Offset: 0x163D6F0 VA: 0x18163F0F0
	public void WriteSchema(JsonSchema schema) { }

	// RVA: 0x163EE80 Offset: 0x163D480 VA: 0x18163EE80
	private void WriteSchemaDictionaryIfNotNull(JsonWriter writer, string propertyName, IDictionary<string, JsonSchema> properties) { }

	// RVA: 0x163EB80 Offset: 0x163D180 VA: 0x18163EB80
	private void WriteItems(JsonSchema schema) { }

	// RVA: 0x1640230 Offset: 0x163E830 VA: 0x181640230
	private void WriteType(string propertyName, JsonWriter writer, JsonSchemaType type) { }

	// RVA: 0x163EE20 Offset: 0x163D420 VA: 0x18163EE20
	private void WritePropertyIfNotNull(JsonWriter writer, string propertyName, object value) { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public enum UndefinedSchemaIdHandling // TypeDefIndex: 8447
{
	// Fields
	public int value__; // 0x0
	public const UndefinedSchemaIdHandling None = 0;
	public const UndefinedSchemaIdHandling UseTypeName = 1;
	public const UndefinedSchemaIdHandling UseAssemblyQualifiedName = 2;
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class ValidationEventArgs : EventArgs // TypeDefIndex: 8448
{
	// Fields
	private readonly JsonSchemaException _ex; // 0x10

	// Properties
	public JsonSchemaException Exception { get; }
	public string Path { get; }
	public string Message { get; }

	// Methods

	// RVA: 0x1650130 Offset: 0x164E730 VA: 0x181650130
	internal void .ctor(JsonSchemaException ex) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public JsonSchemaException get_Exception() { }

	// RVA: 0x16501F0 Offset: 0x164E7F0 VA: 0x1816501F0
	public string get_Path() { }

	// RVA: 0x16501C0 Offset: 0x164E7C0 VA: 0x1816501C0
	public string get_Message() { }
}

// Namespace: Newtonsoft.Json.Schema
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public sealed class ValidationEventHandler : MulticastDelegate // TypeDefIndex: 8449
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, ValidationEventArgs e) { }

	// RVA: 0x5C34C0 Offset: 0x5C1AC0 VA: 0x1805C34C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ValidationEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

