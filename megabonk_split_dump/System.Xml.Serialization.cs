// Namespace: System.Xml.Serialization
public class CodeIdentifier // TypeDefIndex: 6792
{
	// Fields
	internal static CodeDomProvider csharp; // 0x0

	// Methods

	// RVA: 0x1D103F0 Offset: 0x1D0E9F0 VA: 0x181D103F0
	public static string MakePascal(string identifier) { }

	// RVA: 0x1D10730 Offset: 0x1D0ED30 VA: 0x181D10730
	public static string MakeValid(string identifier) { }

	// RVA: 0x1D10320 Offset: 0x1D0E920 VA: 0x181D10320
	private static bool IsValidStart(char c) { }

	// RVA: 0x1D10360 Offset: 0x1D0E960 VA: 0x181D10360
	private static bool IsValid(char c) { }

	// RVA: 0x1D10930 Offset: 0x1D0EF30 VA: 0x181D10930
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public class XmlSerializerNamespaces // TypeDefIndex: 6793
{
	// Fields
	private Hashtable namespaces; // 0x10

	// Properties
	public int Count { get; }
	internal ArrayList NamespaceList { get; }
	internal Hashtable Namespaces { get; set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1D2B720 Offset: 0x1D29D20 VA: 0x181D2B720
	public void Add(string prefix, string ns) { }

	// RVA: 0x1D2B670 Offset: 0x1D29C70 VA: 0x181D2B670
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0x1D2B840 Offset: 0x1D29E40 VA: 0x181D2B840
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0x1D2B930 Offset: 0x1D29F30 VA: 0x181D2B930
	public int get_Count() { }

	// RVA: 0x1D2B9C0 Offset: 0x1D29FC0 VA: 0x181D2B9C0
	internal ArrayList get_NamespaceList() { }

	// RVA: 0x1D2BDC0 Offset: 0x1D2A3C0 VA: 0x181D2BDC0
	internal Hashtable get_Namespaces() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_Namespaces(Hashtable value) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlAttributeEventHandler : MulticastDelegate // TypeDefIndex: 6794
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, XmlAttributeEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class XmlAttributeEventArgs : EventArgs // TypeDefIndex: 6795
{
	// Fields
	private object o; // 0x10
	private XmlAttribute attr; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x1D1E060 Offset: 0x1D1C660 VA: 0x181D1E060
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlElementEventHandler : MulticastDelegate // TypeDefIndex: 6796
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, XmlElementEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class XmlElementEventArgs : EventArgs // TypeDefIndex: 6797
{
	// Fields
	private object o; // 0x10
	private XmlElement elem; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x1D278C0 Offset: 0x1D25EC0 VA: 0x181D278C0
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlNodeEventHandler : MulticastDelegate // TypeDefIndex: 6798
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, XmlNodeEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class XmlNodeEventArgs : EventArgs // TypeDefIndex: 6799
{
	// Fields
	private object o; // 0x10
	private XmlNode xmlNode; // 0x18
	private int lineNumber; // 0x20
	private int linePosition; // 0x24

	// Methods

	// RVA: 0x1D2A070 Offset: 0x1D28670 VA: 0x181D2A070
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }
}

// Namespace: System.Xml.Serialization
public sealed class UnreferencedObjectEventHandler : MulticastDelegate // TypeDefIndex: 6800
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, UnreferencedObjectEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class UnreferencedObjectEventArgs : EventArgs // TypeDefIndex: 6801
{
	// Fields
	private object o; // 0x10
	private string id; // 0x18

	// Methods

	// RVA: 0x1D1A5B0 Offset: 0x1D18BB0 VA: 0x181D1A5B0
	public void .ctor(object o, string id) { }
}

// Namespace: System.Xml.Serialization
public interface IXmlSerializable // TypeDefIndex: 6802
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchema GetSchema();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReadXml(XmlReader reader);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void WriteXml(XmlWriter writer);
}

// Namespace: System.Xml.Serialization
public interface IXmlTextParser // TypeDefIndex: 6803
{
	// Properties
	public abstract bool Normalized { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Normalized();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Normalized(bool value);
}

// Namespace: System.Xml.Serialization
internal class KeyHelper // TypeDefIndex: 6804
{
	// Methods

	// RVA: 0x1D10A80 Offset: 0x1D0F080 VA: 0x181D10A80
	public static void AddField(StringBuilder sb, int n, string val) { }

	// RVA: 0x1D10C40 Offset: 0x1D0F240 VA: 0x181D10C40
	public static void AddField(StringBuilder sb, int n, string val, string def) { }

	// RVA: 0x1D10D20 Offset: 0x1D0F320 VA: 0x181D10D20
	public static void AddField(StringBuilder sb, int n, bool val) { }

	// RVA: 0x1D10B50 Offset: 0x1D0F150 VA: 0x181D10B50
	public static void AddField(StringBuilder sb, int n, bool val, bool def) { }

	// RVA: 0x1D10B90 Offset: 0x1D0F190 VA: 0x181D10B90
	public static void AddField(StringBuilder sb, int n, int val, int def) { }

	// RVA: 0x1D109B0 Offset: 0x1D0EFB0 VA: 0x181D109B0
	public static void AddField(StringBuilder sb, int n, Type val) { }
}

// Namespace: System.Xml.Serialization
internal class ReflectionHelper // TypeDefIndex: 6805
{
	// Fields
	private Hashtable _clrTypes; // 0x10
	private Hashtable _schemaTypes; // 0x18
	private static readonly ParameterModifier[] empty_modifiers; // 0x0

	// Methods

	// RVA: 0x1D11510 Offset: 0x1D0FB10 VA: 0x181D11510
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x1D112E0 Offset: 0x1D0F8E0 VA: 0x181D112E0
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x1D113E0 Offset: 0x1D0F9E0 VA: 0x181D113E0
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x1D11190 Offset: 0x1D0F790 VA: 0x181D11190
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x1D10DE0 Offset: 0x1D0F3E0 VA: 0x181D10DE0
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x1D11640 Offset: 0x1D0FC40 VA: 0x181D11640
	public void .ctor() { }

	// RVA: 0x1D115D0 Offset: 0x1D0FBD0 VA: 0x181D115D0
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
internal enum SchemaTypes // TypeDefIndex: 6806
{
	// Fields
	public int value__; // 0x0
	public const SchemaTypes NotSet = 0;
	public const SchemaTypes Primitive = 1;
	public const SchemaTypes Enum = 2;
	public const SchemaTypes Array = 3;
	public const SchemaTypes Class = 4;
	public const SchemaTypes XmlSerializable = 5;
	public const SchemaTypes XmlNode = 6;
	public const SchemaTypes Void = 7;
}

// Namespace: System.Xml.Serialization
internal abstract class SerializationSource // TypeDefIndex: 6807
{
	// Fields
	private Type[] includedTypes; // 0x10
	private string namspace; // 0x18
	private bool canBeGenerated; // 0x20

	// Methods

	// RVA: 0x1D11960 Offset: 0x1D0FF60 VA: 0x181D11960
	public void .ctor(string namspace, Type[] includedTypes) { }

	// RVA: 0x1D11830 Offset: 0x1D0FE30 VA: 0x181D11830
	protected bool BaseEquals(SerializationSource other) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeSerializationSource : SerializationSource // TypeDefIndex: 6808
{
	// Fields
	private string attributeOverridesHash; // 0x28
	private Type type; // 0x30
	private string rootHash; // 0x38

	// Methods

	// RVA: 0x1D2C030 Offset: 0x1D2A630 VA: 0x181D2C030
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0x1D2BE30 Offset: 0x1D2A430 VA: 0x181D2BE30 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1D2C000 Offset: 0x1D2A600 VA: 0x181D2C000 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Xml.Serialization
[Usage(4, AllowMultiple = False)]
internal class XmlTypeConvertorAttribute : Attribute // TypeDefIndex: 6809
{
	// Fields
	[CompilerGenerated]
	private string <Method>k__BackingField; // 0x10

	// Properties
	public string Method { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Method() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_Method(string value) { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string method) { }
}

// Namespace: System.Xml.Serialization
internal class TypeData // TypeDefIndex: 6810
{
	// Fields
	private Type type; // 0x10
	private string elementName; // 0x18
	private SchemaTypes sType; // 0x20
	private Type listItemType; // 0x28
	private string typeName; // 0x30
	private string fullTypeName; // 0x38
	private TypeData listItemTypeData; // 0x40
	private TypeData mappedType; // 0x48
	private XmlSchemaPatternFacet facet; // 0x50
	private MethodInfo typeConvertor; // 0x58
	private bool hasPublicConstructor; // 0x60
	private bool nullableOverride; // 0x61
	private static string[] keywords; // 0x0

	// Properties
	public string TypeName { get; }
	public string XmlType { get; }
	public Type Type { get; }
	public string FullTypeName { get; }
	public SchemaTypes SchemaType { get; }
	public bool IsListType { get; }
	public bool IsComplexType { get; }
	public bool IsValueType { get; }
	public bool IsNullable { get; set; }
	public TypeData ListItemTypeData { get; }
	public Type ListItemType { get; }
	public bool IsXsdType { get; }
	public bool HasPublicConstructor { get; }

	// Methods

	// RVA: 0x1D13430 Offset: 0x1D11A30 VA: 0x181D13430
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x1D12EE0 Offset: 0x1D114E0 VA: 0x181D12EE0
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x1D11EF0 Offset: 0x1D104F0 VA: 0x181D11EF0
	private void LookupTypeConvertor() { }

	// RVA: 0x1D119C0 Offset: 0x1D0FFC0 VA: 0x181D119C0
	internal void ConvertForAssignment(ref object value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_TypeName() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_XmlType() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_Type() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_FullTypeName() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x1D13480 Offset: 0x1D11A80 VA: 0x181D13480
	public bool get_IsListType() { }

	// RVA: 0x1D13450 Offset: 0x1D11A50 VA: 0x181D13450
	public bool get_IsComplexType() { }

	// RVA: 0x1D135F0 Offset: 0x1D11BF0 VA: 0x181D135F0
	public bool get_IsValueType() { }

	// RVA: 0x1D13490 Offset: 0x1D11A90 VA: 0x181D13490
	public bool get_IsNullable() { }

	// RVA: 0x14C6DE0 Offset: 0x14C53E0 VA: 0x1814C6DE0
	public void set_IsNullable(bool value) { }

	// RVA: 0x1D13680 Offset: 0x1D11C80 VA: 0x181D13680
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x1D13770 Offset: 0x1D11D70 VA: 0x181D13770
	public Type get_ListItemType() { }

	// RVA: 0x1D13670 Offset: 0x1D11C70 VA: 0x181D13670
	public bool get_IsXsdType() { }

	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810
	public bool get_HasPublicConstructor() { }

	// RVA: 0x1D11DC0 Offset: 0x1D103C0 VA: 0x181D11DC0
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x1D11AB0 Offset: 0x1D100B0 VA: 0x181D11AB0
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x1D11BC0 Offset: 0x1D101C0 VA: 0x181D11BC0
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x1D11FA0 Offset: 0x1D105A0 VA: 0x181D11FA0
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
internal sealed class TypeMember // TypeDefIndex: 6811
{
	// Fields
	private Type type; // 0x10
	private string member; // 0x18

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	internal void .ctor(Type type, string member) { }

	// RVA: 0x1D14210 Offset: 0x1D12810 VA: 0x181D14210 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D14090 Offset: 0x1D12690 VA: 0x181D14090 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D14180 Offset: 0x1D12780 VA: 0x181D14180
	public static bool Equals(TypeMember tm1, TypeMember tm2) { }

	// RVA: 0x1D14270 Offset: 0x1D12870 VA: 0x181D14270 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml.Serialization
internal class TypeTranslator // TypeDefIndex: 6812
{
	// Fields
	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18

	// Methods

	// RVA: 0x1D15450 Offset: 0x1D13A50 VA: 0x181D15450
	private static void .cctor() { }

	// RVA: 0x1D15270 Offset: 0x1D13870 VA: 0x181D15270
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x1D14740 Offset: 0x1D12D40 VA: 0x181D14740
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

	// RVA: 0x1D146F0 Offset: 0x1D12CF0 VA: 0x181D146F0
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x1D144A0 Offset: 0x1D12AA0 VA: 0x181D144A0
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x1D142E0 Offset: 0x1D128E0 VA: 0x181D142E0
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x1D143B0 Offset: 0x1D129B0 VA: 0x181D143B0
	public static string GetArrayName(string elemName) { }

	// RVA: 0x1D152C0 Offset: 0x1D138C0 VA: 0x181D152C0
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlAnyAttributeAttribute : Attribute // TypeDefIndex: 6813
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlAnyElementAttribute : Attribute // TypeDefIndex: 6814
{
	// Fields
	private string elementName; // 0x10
	private string ns; // 0x18
	private int order; // 0x20

	// Properties
	public string Name { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x1D1DA60 Offset: 0x1D1C060 VA: 0x181D1DA60
	public void .ctor() { }

	// RVA: 0x1D1DA70 Offset: 0x1D1C070 VA: 0x181D1DA70
	public string get_Name() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Namespace() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_Order() { }

	// RVA: 0x1D1D890 Offset: 0x1D1BE90 VA: 0x181D1D890
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlAnyElementAttributes : CollectionBase // TypeDefIndex: 6815
{
	// Properties
	public XmlAnyElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x1D1DD40 Offset: 0x1D1C340 VA: 0x181D1DD40
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x1D1DC70 Offset: 0x1D1C270 VA: 0x181D1DC70
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x1D1DA90 Offset: 0x1D1C090 VA: 0x181D1DA90
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1D1DE70 Offset: 0x1D1C470 VA: 0x181D1DE70
	internal int get_Order() { }

	// RVA: 0x131ABA0 Offset: 0x13191A0 VA: 0x18131ABA0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = False)]
public class XmlArrayAttribute : Attribute // TypeDefIndex: 6816
{
	// Fields
	private string elementName; // 0x10
	private XmlSchemaForm form; // 0x18
	private bool isNullable; // 0x1C
	private string ns; // 0x20
	private int order; // 0x28

	// Properties
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public bool IsNullable { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x1D1DA70 Offset: 0x1D1C070 VA: 0x181D1DA70
	public string get_ElementName() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x39A900 Offset: 0x398F00 VA: 0x18039A900
	public bool get_IsNullable() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Namespace() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_Order() { }

	// RVA: 0x1D2C910 Offset: 0x1D2AF10 VA: 0x181D2C910
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlArrayItemAttribute : Attribute // TypeDefIndex: 6817
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private bool isNullableSpecified; // 0x31
	private int nestingLevel; // 0x34
	private Type type; // 0x38

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	internal bool IsNullableSpecified { get; }
	public Type Type { get; }
	public int NestingLevel { get; }

	// Methods

	// RVA: 0x1D1DA70 Offset: 0x1D1C070 VA: 0x181D1DA70
	public string get_DataType() { }

	// RVA: 0x1D2CBB0 Offset: 0x1D2B1B0 VA: 0x181D2CBB0
	public string get_ElementName() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public XmlSchemaForm get_Form() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Namespace() { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_IsNullable() { }

	// RVA: 0x16ADFC0 Offset: 0x16AC5C0 VA: 0x1816ADFC0
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public Type get_Type() { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public int get_NestingLevel() { }

	// RVA: 0x1D2CA40 Offset: 0x1D2B040 VA: 0x181D2CA40
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlArrayItemAttributes : CollectionBase // TypeDefIndex: 6818
{
	// Properties
	public XmlArrayItemAttribute Item { get; }

	// Methods

	// RVA: 0x1D2CEF0 Offset: 0x1D2B4F0 VA: 0x181D2CEF0
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x1D2CE80 Offset: 0x1D2B480 VA: 0x181D2CE80
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x1D2CBD0 Offset: 0x1D2B1D0 VA: 0x181D2CBD0
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x131ABA0 Offset: 0x13191A0 VA: 0x18131ABA0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlAttributeAttribute : Attribute // TypeDefIndex: 6819
{
	// Fields
	private string attributeName; // 0x10
	private string dataType; // 0x18
	private Type type; // 0x20
	private XmlSchemaForm form; // 0x28
	private string ns; // 0x30

	// Properties
	public string AttributeName { get; }
	public string DataType { get; set; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string attributeName) { }

	// RVA: 0x1D1DA70 Offset: 0x1D1C070 VA: 0x181D1DA70
	public string get_AttributeName() { }

	// RVA: 0x1D2CBB0 Offset: 0x1D2B1B0 VA: 0x181D2CBB0
	public string get_DataType() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_DataType(string value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public XmlSchemaForm get_Form() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_Namespace() { }

	// RVA: 0x1D2CFB0 Offset: 0x1D2B5B0 VA: 0x181D2CFB0
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlAttributeOverrides // TypeDefIndex: 6820
{
	// Fields
	private Hashtable overrides; // 0x10

	// Properties
	public XmlAttributes Item { get; }
	public XmlAttributes Item { get; }

	// Methods

	// RVA: 0x1D2D580 Offset: 0x1D2BB80 VA: 0x181D2D580
	public void .ctor() { }

	// RVA: 0x1D2D5F0 Offset: 0x1D2BBF0 VA: 0x181D2D5F0
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x1D2D610 Offset: 0x1D2BC10 VA: 0x181D2D610
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x1D2D510 Offset: 0x1D2BB10 VA: 0x181D2D510
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x1D2D0F0 Offset: 0x1D2B6F0 VA: 0x181D2D0F0
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
public class XmlAttributes // TypeDefIndex: 6821
{
	// Fields
	private XmlAnyAttributeAttribute xmlAnyAttribute; // 0x10
	private XmlAnyElementAttributes xmlAnyElements; // 0x18
	private XmlArrayAttribute xmlArray; // 0x20
	private XmlArrayItemAttributes xmlArrayItems; // 0x28
	private XmlAttributeAttribute xmlAttribute; // 0x30
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; // 0x38
	private object xmlDefaultValue; // 0x40
	private XmlElementAttributes xmlElements; // 0x48
	private XmlEnumAttribute xmlEnum; // 0x50
	private bool xmlIgnore; // 0x58
	private bool xmlns; // 0x59
	private XmlRootAttribute xmlRoot; // 0x60
	private XmlTextAttribute xmlText; // 0x68
	private XmlTypeAttribute xmlType; // 0x70

	// Properties
	public XmlAnyAttributeAttribute XmlAnyAttribute { get; }
	public XmlAnyElementAttributes XmlAnyElements { get; }
	public XmlArrayAttribute XmlArray { get; }
	public XmlArrayItemAttributes XmlArrayItems { get; }
	public XmlAttributeAttribute XmlAttribute { get; }
	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier { get; }
	public object XmlDefaultValue { get; }
	public XmlElementAttributes XmlElements { get; }
	public bool XmlIgnore { get; }
	public bool Xmlns { get; }
	public XmlRootAttribute XmlRoot { get; }
	public XmlTextAttribute XmlText { get; }
	public XmlTypeAttribute XmlType { get; }
	internal Nullable<int> Order { get; }
	internal int SortableOrder { get; }

	// Methods

	// RVA: 0x1D2DCA0 Offset: 0x1D2C2A0 VA: 0x181D2DCA0
	public void .ctor() { }

	// RVA: 0x1D2DDC0 Offset: 0x1D2C3C0 VA: 0x181D2DDC0
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public object get_XmlDefaultValue() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	public bool get_XmlIgnore() { }

	// RVA: 0x140E320 Offset: 0x140C920 VA: 0x18140E320
	public bool get_Xmlns() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x1D2D710 Offset: 0x1D2BD10 VA: 0x181D2D710
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1D2E9D0 Offset: 0x1D2CFD0 VA: 0x181D2E9D0
	internal Nullable<int> get_Order() { }

	// RVA: 0x1D2EA90 Offset: 0x1D2D090 VA: 0x181D2EA90
	internal int get_SortableOrder() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = False)]
public class XmlChoiceIdentifierAttribute : Attribute // TypeDefIndex: 6822
{
	// Fields
	private string memberName; // 0x10

	// Properties
	public string MemberName { get; }

	// Methods

	// RVA: 0x1D1DA70 Offset: 0x1D1C070 VA: 0x181D1DA70
	public string get_MemberName() { }

	// RVA: 0x1D2EB10 Offset: 0x1D2D110 VA: 0x181D2EB10
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
internal class XmlCustomFormatter // TypeDefIndex: 6823
{
	// Fields
	private static string[] allTimeFormats; // 0x0

	// Methods

	// RVA: 0x1D2EB90 Offset: 0x1D2D190 VA: 0x181D2EB90
	internal static string FromEnum(long value, string[] values, long[] ids, string typeName) { }

	// RVA: 0x1D2EEA0 Offset: 0x1D2D4A0 VA: 0x181D2EEA0
	internal static string FromXmlName(string name) { }

	// RVA: 0x1D2EE50 Offset: 0x1D2D450 VA: 0x181D2EE50
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x1D2F860 Offset: 0x1D2DE60 VA: 0x181D2F860
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x1D2EEF0 Offset: 0x1D2D4F0 VA: 0x181D2EEF0
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x1D304C0 Offset: 0x1D2EAC0 VA: 0x181D304C0
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlElementAttribute : Attribute // TypeDefIndex: 6824
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private Type type; // 0x38
	private int order; // 0x40

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	public int Order { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1D30B30 Offset: 0x1D2F130 VA: 0x181D30B30
	public void .ctor(string elementName) { }

	// RVA: 0x1D30AD0 Offset: 0x1D2F0D0 VA: 0x181D30AD0
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x1D1DA70 Offset: 0x1D1C070 VA: 0x181D1DA70
	public string get_DataType() { }

	// RVA: 0x1D2CBB0 Offset: 0x1D2B1B0 VA: 0x181D2CBB0
	public string get_ElementName() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public XmlSchemaForm get_Form() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Namespace() { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_IsNullable() { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	public int get_Order() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public Type get_Type() { }

	// RVA: 0x1D30980 Offset: 0x1D2EF80 VA: 0x181D30980
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlElementAttributes : CollectionBase // TypeDefIndex: 6825
{
	// Properties
	public XmlElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x1D30DF0 Offset: 0x1D2F3F0 VA: 0x181D30DF0
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x1D30D80 Offset: 0x1D2F380 VA: 0x181D30D80
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x1D30B70 Offset: 0x1D2F170 VA: 0x181D30B70
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1D30EB0 Offset: 0x1D2F4B0 VA: 0x181D30EB0
	internal int get_Order() { }

	// RVA: 0x131ABA0 Offset: 0x13191A0 VA: 0x18131ABA0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(256)]
public class XmlEnumAttribute : Attribute // TypeDefIndex: 6826
{
	// Fields
	private string name; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string name) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Name() { }

	// RVA: 0x1D310A0 Offset: 0x1D2F6A0 VA: 0x181D310A0
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlIgnoreAttribute : Attribute // TypeDefIndex: 6827
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(1100, AllowMultiple = True)]
public class XmlIncludeAttribute : Attribute // TypeDefIndex: 6828
{
	// Fields
	private Type type; // 0x10

	// Properties
	public Type Type { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_Type() { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlMapping // TypeDefIndex: 6829
{
	// Fields
	private ObjectMap map; // 0x10
	private ArrayList relatedMaps; // 0x18
	private SerializationFormat format; // 0x20
	private SerializationSource source; // 0x28
	internal string _elementName; // 0x30
	internal string _namespace; // 0x38
	private string key; // 0x40

	// Properties
	public string ElementName { get; }
	public string Namespace { get; }
	internal ObjectMap ObjectMap { get; set; }
	internal ArrayList RelatedMaps { get; set; }
	internal SerializationFormat Format { get; set; }
	internal SerializationSource Source { get; }

	// Methods

	// RVA: 0x1D31120 Offset: 0x1D2F720 VA: 0x181D31120
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_ElementName() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_Namespace() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void SetKey(string key) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	internal SerializationFormat get_Format() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal SerializationSource get_Source() { }
}

// Namespace: System.Xml.Serialization
internal class ObjectMap // TypeDefIndex: 6830
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal enum SerializationFormat // TypeDefIndex: 6831
{
	// Fields
	public int value__; // 0x0
	public const SerializationFormat Encoded = 0;
	public const SerializationFormat Literal = 1;
}

// Namespace: System.Xml.Serialization
public class XmlMemberMapping // TypeDefIndex: 6832
{}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlMembersMapping : XmlMapping // TypeDefIndex: 6833
{
	// Fields
	private bool _hasWrapperElement; // 0x48
	private XmlMemberMapping[] _mapping; // 0x50

	// Properties
	public int Count { get; }
	internal bool HasWrapperElement { get; }

	// Methods

	// RVA: 0x1D31170 Offset: 0x1D2F770 VA: 0x181D31170
	public int get_Count() { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	internal bool get_HasWrapperElement() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlNamespaceDeclarationsAttribute : Attribute // TypeDefIndex: 6834
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
public class XmlReflectionImporter // TypeDefIndex: 6836
{
	// Fields
	private string initialDefaultNamespace; // 0x10
	private XmlAttributeOverrides attributeOverrides; // 0x18
	private ArrayList includedTypes; // 0x20
	private ReflectionHelper helper; // 0x28
	private int arrayChoiceCount; // 0x30
	private ArrayList relatedMaps; // 0x38
	private bool allowPrivateTypes; // 0x40
	private static readonly string errSimple; // 0x0
	private static readonly string errSimple2; // 0x8

	// Methods

	// RVA: 0x1D386D0 Offset: 0x1D36CD0 VA: 0x181D386D0
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x1D379D0 Offset: 0x1D35FD0 VA: 0x181D379D0
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x1D379F0 Offset: 0x1D35FF0 VA: 0x181D379F0
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x1D37A10 Offset: 0x1D36010 VA: 0x181D37A10
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1D37580 Offset: 0x1D35B80 VA: 0x181D37580
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1D31F30 Offset: 0x1D30530 VA: 0x181D31F30
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x1D33900 Offset: 0x1D31F00 VA: 0x181D33900
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x1D339A0 Offset: 0x1D31FA0 VA: 0x181D339A0
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x1D38520 Offset: 0x1D36B20 VA: 0x181D38520
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x1D33290 Offset: 0x1D31890 VA: 0x181D33290
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1D36250 Offset: 0x1D34850 VA: 0x181D36250
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x1D362E0 Offset: 0x1D348E0 VA: 0x181D362E0
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x1D37BE0 Offset: 0x1D361E0 VA: 0x181D37BE0
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1D37040 Offset: 0x1D35640 VA: 0x181D37040
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1D35A90 Offset: 0x1D34090 VA: 0x181D35A90
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1D37EA0 Offset: 0x1D364A0 VA: 0x181D37EA0
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1D36120 Offset: 0x1D34720 VA: 0x181D36120
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x1D32580 Offset: 0x1D30B80 VA: 0x181D32580
	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x1D311D0 Offset: 0x1D2F7D0 VA: 0x181D311D0
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x1D34A90 Offset: 0x1D33090 VA: 0x181D34A90
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x1D333D0 Offset: 0x1D319D0 VA: 0x181D333D0
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x1D37200 Offset: 0x1D35800 VA: 0x181D37200
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x1D31190 Offset: 0x1D2F790 VA: 0x181D31190
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x1D380B0 Offset: 0x1D366B0 VA: 0x181D380B0
	public void IncludeType(Type type) { }

	// RVA: 0x1D323C0 Offset: 0x1D309C0 VA: 0x181D323C0
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x1D38620 Offset: 0x1D36C20 VA: 0x181D38620
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public class XmlReflectionMember // TypeDefIndex: 6837
{
	// Fields
	private bool isReturnValue; // 0x10
	private string memberName; // 0x18
	private Type memberType; // 0x20
	private XmlAttributes xmlAttributes; // 0x28
	private Type declaringType; // 0x30

	// Properties
	public bool IsReturnValue { get; }
	public string MemberName { get; }
	public Type MemberType { get; }
	public XmlAttributes XmlAttributes { get; }
	internal Type DeclaringType { get; set; }

	// Methods

	// RVA: 0x1D38840 Offset: 0x1D36E40 VA: 0x181D38840
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_IsReturnValue() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_MemberName() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Type get_MemberType() { }

	// RVA: 0x1D388B0 Offset: 0x1D36EB0 VA: 0x181D388B0
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal Type get_DeclaringType() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	internal void set_DeclaringType(Type value) { }
}

// Namespace: System.Xml.Serialization
[Usage(9244)]
public class XmlRootAttribute : Attribute // TypeDefIndex: 6838
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private bool isNullable; // 0x20
	private string ns; // 0x28

	// Properties
	public string DataType { get; set; }
	public string ElementName { get; set; }
	public bool IsNullable { get; set; }
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x1D389D0 Offset: 0x1D36FD0 VA: 0x181D389D0
	public void .ctor() { }

	// RVA: 0x1D389E0 Offset: 0x1D36FE0 VA: 0x181D389E0
	public void .ctor(string elementName) { }

	// RVA: 0x1D1DA70 Offset: 0x1D1C070 VA: 0x181D1DA70
	public string get_DataType() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_DataType(string value) { }

	// RVA: 0x1D2CBB0 Offset: 0x1D2B1B0 VA: 0x181D2CBB0
	public string get_ElementName() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_ElementName(string value) { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_IsNullable() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_IsNullable(bool value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Namespace() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_Namespace(string value) { }

	// RVA: 0x1D38920 Offset: 0x1D36F20 VA: 0x181D38920
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(1036)]
public sealed class XmlSchemaProviderAttribute : Attribute // TypeDefIndex: 6839
{
	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Properties
	public string MethodName { get; }
	public bool IsAny { get; set; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string methodName) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_MethodName() { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_IsAny() { }

	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	public void set_IsAny(bool value) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationCollectionFixupCallback : MulticastDelegate // TypeDefIndex: 6840
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object collection, object collectionItems) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationFixupCallback : MulticastDelegate // TypeDefIndex: 6841
{
	// Methods

	// RVA: 0xC9DA00 Offset: 0xC9C000 VA: 0x180C9DA00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(object fixup) { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationGeneratedCode // TypeDefIndex: 6842
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationReadCallback : MulticastDelegate // TypeDefIndex: 6843
{
	// Methods

	// RVA: 0x1012020 Offset: 0x1010620 VA: 0x181012020
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1011D00 Offset: 0x1010300 VA: 0x181011D00 Slot: 13
	public virtual object Invoke() { }
}

// Namespace: System.Xml.Serialization
[MonoTODO]
public abstract class XmlSerializationReader : XmlSerializationGeneratedCode // TypeDefIndex: 6848
{
	// Fields
	private XmlDocument document; // 0x10
	private XmlReader reader; // 0x18
	private ArrayList fixups; // 0x20
	private Hashtable collFixups; // 0x28
	private ArrayList collItemFixups; // 0x30
	private Hashtable typesCallbacks; // 0x38
	private ArrayList noIDTargets; // 0x40
	private Hashtable targets; // 0x48
	private Hashtable delayedListFixups; // 0x50
	private XmlSerializer eventSource; // 0x58
	private int delayedFixupId; // 0x60
	private Hashtable referencedObjects; // 0x68
	private int readCount; // 0x70
	private int whileIterationCount; // 0x74
	private string w3SchemaNS; // 0x78
	private string w3InstanceNS; // 0x80
	private string w3InstanceNS2000; // 0x88
	private string w3InstanceNS1999; // 0x90
	private string soapNS; // 0x98
	private string wsdlNS; // 0xA0
	private string nullX; // 0xA8
	private string nil; // 0xB0
	private string typeX; // 0xB8
	private string arrayType; // 0xC0
	private XmlQualifiedName arrayQName; // 0xC8

	// Properties
	protected XmlDocument Document { get; }
	protected XmlReader Reader { get; }

	// Methods

	// RVA: 0x1D40710 Offset: 0x1D3ED10 VA: 0x181D40710
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x1D40190 Offset: 0x1D3E790 VA: 0x181D40190
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x1D401E0 Offset: 0x1D3E7E0 VA: 0x181D401E0
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1D448B0 Offset: 0x1D42EB0 VA: 0x181D448B0
	protected XmlDocument get_Document() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	protected XmlReader get_Reader() { }

	// RVA: 0x1D3F710 Offset: 0x1D3DD10 VA: 0x181D3F710
	protected void AddFixup(XmlSerializationReader.CollectionFixup fixup) { }

	// RVA: 0x1D3F8D0 Offset: 0x1D3DED0 VA: 0x181D3F8D0
	protected void AddFixup(XmlSerializationReader.Fixup fixup) { }

	// RVA: 0x1D3F830 Offset: 0x1D3DE30 VA: 0x181D3F830
	private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup) { }

	// RVA: 0x1D3F970 Offset: 0x1D3DF70 VA: 0x181D3F970
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x1D3FAE0 Offset: 0x1D3E0E0 VA: 0x181D3FAE0
	protected void AddTarget(string id, object o) { }

	// RVA: 0x1D3FF30 Offset: 0x1D3E530 VA: 0x181D3FF30
	private string CurrentTag() { }

	// RVA: 0x1D3FC30 Offset: 0x1D3E230 VA: 0x181D3FC30
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x1D3FCB0 Offset: 0x1D3E2B0 VA: 0x181D3FCB0
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x1D3FD30 Offset: 0x1D3E330 VA: 0x181D3FD30
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x1D3FDB0 Offset: 0x1D3E3B0 VA: 0x181D3FDB0
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x1D400F0 Offset: 0x1D3E6F0 VA: 0x181D400F0
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x1D40330 Offset: 0x1D3E930 VA: 0x181D40330
	protected bool GetNullAttr() { }

	// RVA: 0x1D40410 Offset: 0x1D3EA10 VA: 0x181D40410
	protected object GetTarget(string id) { }

	// RVA: 0x1D441C0 Offset: 0x1D427C0 VA: 0x181D441C0
	private bool TargetReady(string id) { }

	// RVA: 0x1D404F0 Offset: 0x1D3EAF0 VA: 0x181D404F0
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void InitIDs();

	// RVA: 0x1D40BA0 Offset: 0x1D3F1A0 VA: 0x181D40BA0
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x1D41200 Offset: 0x1D3F800 VA: 0x181D41200
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x1D413C0 Offset: 0x1D3F9C0 VA: 0x181D413C0
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x1D414B0 Offset: 0x1D3FAB0 VA: 0x181D414B0
	protected void ReadEndElement() { }

	// RVA: 0x1D41A90 Offset: 0x1D40090 VA: 0x181D41A90
	protected bool ReadNull() { }

	// RVA: 0x1D41C80 Offset: 0x1D40280 VA: 0x181D41C80
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x1D41CB0 Offset: 0x1D402B0 VA: 0x181D41CB0
	protected string ReadNullableString() { }

	// RVA: 0x1D42010 Offset: 0x1D40610 VA: 0x181D42010
	protected object ReadReferencedElement() { }

	// RVA: 0x1D40230 Offset: 0x1D3E830 VA: 0x181D40230
	private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x1D41D00 Offset: 0x1D40300 VA: 0x181D41D00
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x1D41570 Offset: 0x1D3FB70 VA: 0x181D41570
	private bool ReadList(out object resultList) { }

	// RVA: 0x1D42080 Offset: 0x1D40680 VA: 0x181D42080
	protected void ReadReferencedElements() { }

	// RVA: 0x1D43010 Offset: 0x1D41610 VA: 0x181D43010
	protected object ReadReferencingElement(out string fixupReference) { }

	// RVA: 0x1D42FF0 Offset: 0x1D415F0 VA: 0x181D42FF0
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	// RVA: 0x1D430A0 Offset: 0x1D416A0 VA: 0x181D430A0
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	// RVA: 0x1D43430 Offset: 0x1D41A30 VA: 0x181D43430
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x1D43F50 Offset: 0x1D42550 VA: 0x181D43F50
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x1D43620 Offset: 0x1D41C20 VA: 0x181D43620
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x1D44090 Offset: 0x1D42690 VA: 0x181D44090
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x1D43F60 Offset: 0x1D42560 VA: 0x181D43F60
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x1D44100 Offset: 0x1D42700 VA: 0x181D44100
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x1D441F0 Offset: 0x1D427F0 VA: 0x181D441F0
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x1D44440 Offset: 0x1D42A40 VA: 0x181D44440
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x1D445F0 Offset: 0x1D42BF0 VA: 0x181D445F0
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x1D39E70 Offset: 0x1D38470 VA: 0x181D39E70
	protected void UnknownNode(object o) { }

	// RVA: 0x1D447A0 Offset: 0x1D42DA0 VA: 0x181D447A0
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x1D40C20 Offset: 0x1D3F220 VA: 0x181D40C20
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x1D44820 Offset: 0x1D42E20 VA: 0x181D44820
	protected void UnreferencedObject(string id, object o) { }
}

// Namespace: System.Xml.Serialization
internal class XmlSerializationReaderInterpreter : XmlSerializationReader // TypeDefIndex: 6851
{
	// Fields
	private XmlMapping _typeMap; // 0xD0
	private SerializationFormat _format; // 0xD8
	private static readonly XmlQualifiedName AnyType; // 0x0
	private static readonly object[] empty_array; // 0x8

	// Methods

	// RVA: 0x1D3F6C0 Offset: 0x1D3DCC0 VA: 0x181D3F6C0
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x1D39A50 Offset: 0x1D38050 VA: 0x181D39A50 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	protected override void InitIDs() { }

	// RVA: 0x1D3E990 Offset: 0x1D3CF90 VA: 0x181D3E990
	public object ReadRoot() { }

	// RVA: 0x1D3A960 Offset: 0x1D38F60 VA: 0x181D3A960
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x1D3DAD0 Offset: 0x1D3C0D0 VA: 0x181D3DAD0 Slot: 6
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x1D3E880 Offset: 0x1D3CE80 VA: 0x181D3E880
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x1D3E3F0 Offset: 0x1D3C9F0 VA: 0x181D3E3F0 Slot: 7
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x1D3A670 Offset: 0x1D38C70 VA: 0x181D3A670 Slot: 8
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x1D3A5C0 Offset: 0x1D38BC0 VA: 0x181D3A5C0 Slot: 9
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x1D39EE0 Offset: 0x1D384E0 VA: 0x181D39EE0
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1D3B290 Offset: 0x1D39890 VA: 0x181D3B290
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x1D3F010 Offset: 0x1D3D610 VA: 0x181D3F010
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1D39220 Offset: 0x1D37820 VA: 0x181D39220
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x1D39E70 Offset: 0x1D38470 VA: 0x181D39E70 Slot: 10
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x1D39E70 Offset: 0x1D38470 VA: 0x181D39E70 Slot: 11
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x1D39DF0 Offset: 0x1D383F0 VA: 0x181D39DF0
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x1D3F420 Offset: 0x1D3DA20 VA: 0x181D3F420
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x1D3F340 Offset: 0x1D3D940 VA: 0x181D3F340
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x1D39860 Offset: 0x1D37E60 VA: 0x181D39860
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1D3E210 Offset: 0x1D3C810 VA: 0x181D3E210
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x1D3E700 Offset: 0x1D3CD00 VA: 0x181D3E700
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x1D39930 Offset: 0x1D37F30 VA: 0x181D39930
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x1D3AB40 Offset: 0x1D39140 VA: 0x181D3AB40
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x1D3B030 Offset: 0x1D39630 VA: 0x181D3B030
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x1D38A20 Offset: 0x1D37020 VA: 0x181D38A20
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x1D39100 Offset: 0x1D37700 VA: 0x181D39100
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x1D39110 Offset: 0x1D37710 VA: 0x181D39110
	private object CreateInstance(Type type) { }

	// RVA: 0x1D39170 Offset: 0x1D37770 VA: 0x181D39170
	private object CreateList(Type listType) { }

	// RVA: 0x1D39D70 Offset: 0x1D38370 VA: 0x181D39D70
	private object InitializeList(TypeData listType) { }

	// RVA: 0x1D39200 Offset: 0x1D37800 VA: 0x181D39200
	private void FillList(object list, object items) { }

	// RVA: 0x1D38D90 Offset: 0x1D37390 VA: 0x181D38D90
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x1D3EC30 Offset: 0x1D3D230 VA: 0x181D3EC30
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1D3EC60 Offset: 0x1D3D260 VA: 0x181D3EC60
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x1D3E630 Offset: 0x1D3CC30 VA: 0x181D3E630
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1D3AAC0 Offset: 0x1D390C0 VA: 0x181D3AAC0
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1D396E0 Offset: 0x1D37CE0 VA: 0x181D396E0
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x1D3EE10 Offset: 0x1D3D410 VA: 0x181D3EE10
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1D3F5E0 Offset: 0x1D3DBE0 VA: 0x181D3F5E0
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationWriteCallback : MulticastDelegate // TypeDefIndex: 6852
{
	// Methods

	// RVA: 0xC9DA00 Offset: 0xC9C000 VA: 0x180C9DA00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(object o) { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode // TypeDefIndex: 6854
{
	// Fields
	private ObjectIDGenerator idGenerator; // 0x10
	private int qnameCount; // 0x18
	private bool topLevelElement; // 0x1C
	private ArrayList namespaces; // 0x20
	private XmlWriter writer; // 0x28
	private Queue referencedElements; // 0x30
	private Hashtable callbacks; // 0x38
	private Hashtable serializedObjects; // 0x40

	// Properties
	protected XmlWriter Writer { get; }

	// Methods

	// RVA: 0x1D47F10 Offset: 0x1D46510 VA: 0x181D47F10
	protected void .ctor() { }

	// RVA: 0x1D45170 Offset: 0x1D43770 VA: 0x181D45170
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	protected XmlWriter get_Writer() { }

	// RVA: 0x1D44950 Offset: 0x1D42F50 VA: 0x181D44950
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x1D44B40 Offset: 0x1D43140 VA: 0x181D44B40
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x1D44BC0 Offset: 0x1D431C0 VA: 0x181D44BC0
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x1D44C60 Offset: 0x1D43260 VA: 0x181D44C60
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x1D44CE0 Offset: 0x1D432E0 VA: 0x181D44CE0
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x1D44DA0 Offset: 0x1D433A0 VA: 0x181D44DA0
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x1D44A80 Offset: 0x1D43080 VA: 0x181D44A80
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x1D44EB0 Offset: 0x1D434B0 VA: 0x181D44EB0
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x1D44FD0 Offset: 0x1D435D0 VA: 0x181D44FD0
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: 0x1D45380 Offset: 0x1D43980 VA: 0x181D45380
	protected void TopLevelElement() { }

	// RVA: 0x1D456B0 Offset: 0x1D43CB0 VA: 0x181D456B0
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x1D45670 Offset: 0x1D43C70 VA: 0x181D45670
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x1D47D60 Offset: 0x1D46360 VA: 0x181D47D60
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x1D456F0 Offset: 0x1D43CF0 VA: 0x181D456F0
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x1D457C0 Offset: 0x1D43DC0 VA: 0x181D457C0
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x1D45A80 Offset: 0x1D44080 VA: 0x181D45A80
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x1D45890 Offset: 0x1D43E90 VA: 0x181D45890
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x1D45AA0 Offset: 0x1D440A0 VA: 0x181D45AA0
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x1D45AC0 Offset: 0x1D440C0 VA: 0x181D45AC0
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x1D45CA0 Offset: 0x1D442A0 VA: 0x181D45CA0
	protected void WriteEndElement() { }

	// RVA: 0x1D45C50 Offset: 0x1D44250 VA: 0x181D45C50
	protected void WriteEndElement(object o) { }

	// RVA: 0x1D45CD0 Offset: 0x1D442D0 VA: 0x181D45CD0
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x1D46220 Offset: 0x1D44820 VA: 0x181D46220
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x1D462D0 Offset: 0x1D448D0 VA: 0x181D462D0
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x1D46370 Offset: 0x1D44970 VA: 0x181D46370
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x1D46390 Offset: 0x1D44990 VA: 0x181D46390
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x1D46090 Offset: 0x1D44690 VA: 0x181D46090
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x1D46150 Offset: 0x1D44750 VA: 0x181D46150
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x1D463C0 Offset: 0x1D449C0 VA: 0x181D463C0
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x1D46880 Offset: 0x1D44E80 VA: 0x181D46880
	protected void WriteReferencedElements() { }

	// RVA: 0x1D452A0 Offset: 0x1D438A0 VA: 0x181D452A0
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x1D45390 Offset: 0x1D43990 VA: 0x181D45390
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x1D46AF0 Offset: 0x1D450F0 VA: 0x181D46AF0
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x1D44AC0 Offset: 0x1D430C0 VA: 0x181D44AC0
	private void CheckReferenceQueue() { }

	// RVA: 0x1D46D90 Offset: 0x1D45390 VA: 0x181D46D90
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x1D46C50 Offset: 0x1D45250 VA: 0x181D46C50
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x1D46EC0 Offset: 0x1D454C0 VA: 0x181D46EC0
	protected void WriteStartDocument() { }

	// RVA: 0x1D46F50 Offset: 0x1D45550 VA: 0x181D46F50
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x1D46F20 Offset: 0x1D45520 VA: 0x181D46F20
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x1D47680 Offset: 0x1D45C80 VA: 0x181D47680
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x1D47650 Offset: 0x1D45C50 VA: 0x181D47650
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x1D46F80 Offset: 0x1D45580 VA: 0x181D46F80
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x1D476B0 Offset: 0x1D45CB0 VA: 0x181D476B0
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x1D47A30 Offset: 0x1D46030 VA: 0x181D47A30
	protected void WriteValue(string value) { }

	// RVA: 0x1D47A70 Offset: 0x1D46070 VA: 0x181D47A70
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x1D47E30 Offset: 0x1D46430 VA: 0x181D47E30
	protected void WriteXsiType(string name, string ns) { }
}

// Namespace: System.Xml.Serialization
internal class XmlSerializationWriterInterpreter : XmlSerializationWriter // TypeDefIndex: 6856
{
	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x1D5F930 Offset: 0x1D5DF30 VA: 0x181D5F930
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x1D5BE50 Offset: 0x1D5A450 VA: 0x181D5BE50 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x1D5F6A0 Offset: 0x1D5DCA0 VA: 0x181D5F6A0
	public void WriteRoot(object ob) { }

	// RVA: 0x1D5E990 Offset: 0x1D5CF90 VA: 0x181D5E990 Slot: 5
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x1D5E4F0 Offset: 0x1D5CAF0 VA: 0x181D5E4F0 Slot: 6
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x1D5E850 Offset: 0x1D5CE50 VA: 0x181D5E850 Slot: 7
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1D5E6F0 Offset: 0x1D5CCF0 VA: 0x181D5E6F0 Slot: 8
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x1D5E7A0 Offset: 0x1D5CDA0 VA: 0x181D5E7A0 Slot: 9
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x1D5E490 Offset: 0x1D5CA90 VA: 0x181D5E490
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1D5C900 Offset: 0x1D5AF00 VA: 0x181D5C900
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1D5CE50 Offset: 0x1D5B450 VA: 0x181D5CE50
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1D5B720 Offset: 0x1D59D20 VA: 0x181D5B720
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1D5C1A0 Offset: 0x1D5A7A0 VA: 0x181D5C1A0
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1D5DED0 Offset: 0x1D5C4D0 VA: 0x181D5DED0
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x1D5BAD0 Offset: 0x1D5A0D0 VA: 0x181D5BAD0
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x1D5F450 Offset: 0x1D5DA50 VA: 0x181D5F450
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x1D5F1D0 Offset: 0x1D5D7D0 VA: 0x181D5F1D0
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x1D5DBC0 Offset: 0x1D5C1C0 VA: 0x181D5DBC0 Slot: 10
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1D5D4E0 Offset: 0x1D5BAE0 VA: 0x181D5D4E0
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x1D5B600 Offset: 0x1D59C00 VA: 0x181D5B600
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x1D5C3E0 Offset: 0x1D5A9E0 VA: 0x181D5C3E0
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x1D5F180 Offset: 0x1D5D780 VA: 0x181D5F180 Slot: 11
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1D5D410 Offset: 0x1D5BA10 VA: 0x181D5D410 Slot: 12
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1D5B7F0 Offset: 0x1D59DF0 VA: 0x181D5B7F0
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x1D5B550 Offset: 0x1D59B50 VA: 0x181D5B550
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }
}

// Namespace: System.Xml.Serialization
public class XmlSerializer // TypeDefIndex: 6858
{
	// Fields
	private static int generationThreshold; // 0x0
	private static bool backgroundGeneration; // 0x4
	private static bool deleteTempFiles; // 0x5
	private static bool generatorFallback; // 0x6
	private bool customSerializer; // 0x10
	private XmlMapping typeMapping; // 0x18
	private XmlSerializer.SerializerData serializerData; // 0x20
	private static Hashtable serializerTypes; // 0x8
	private UnreferencedObjectEventHandler onUnreferencedObject; // 0x28
	private XmlAttributeEventHandler onUnknownAttribute; // 0x30
	private XmlElementEventHandler onUnknownElement; // 0x38
	private XmlNodeEventHandler onUnknownNode; // 0x40

	// Properties
	internal XmlMapping Mapping { get; }

	// Methods

	// RVA: 0x1D60AF0 Offset: 0x1D5F0F0 VA: 0x181D60AF0
	private static void .cctor() { }

	// RVA: 0x1D60D70 Offset: 0x1D5F370 VA: 0x181D60D70
	public void .ctor(Type type) { }

	// RVA: 0x1D60BF0 Offset: 0x1D5F1F0 VA: 0x181D60BF0
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal XmlMapping get_Mapping() { }

	// RVA: 0x1D60510 Offset: 0x1D5EB10 VA: 0x181D60510 Slot: 4
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0x1D60530 Offset: 0x1D5EB30 VA: 0x181D60530 Slot: 5
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0x1D60550 Offset: 0x1D5EB50 VA: 0x181D60550 Slot: 6
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0x1D60570 Offset: 0x1D5EB70 VA: 0x181D60570 Slot: 7
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0x1D5FDA0 Offset: 0x1D5E3A0 VA: 0x181D5FDA0 Slot: 8
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0x1D60080 Offset: 0x1D5E680 VA: 0x181D60080 Slot: 9
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0x1D60180 Offset: 0x1D5E780 VA: 0x181D60180
	public object Deserialize(TextReader textReader) { }

	// RVA: 0x1D600C0 Offset: 0x1D5E6C0 VA: 0x181D600C0
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0x1D602A0 Offset: 0x1D5E8A0 VA: 0x181D602A0 Slot: 10
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0x1D60630 Offset: 0x1D5EC30 VA: 0x181D60630 Slot: 11
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0x1D60590 Offset: 0x1D5EB90 VA: 0x181D60590
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0x1D60AD0 Offset: 0x1D5F0D0 VA: 0x181D60AD0
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0x1D60830 Offset: 0x1D5EE30 VA: 0x181D60830
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0x1D5FDE0 Offset: 0x1D5E3E0 VA: 0x181D5FDE0
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0x1D5FD40 Offset: 0x1D5E340 VA: 0x181D5FD40
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }
}

// Namespace: System.Xml.Serialization
public class XmlSerializerFactory // TypeDefIndex: 6859
{
	// Fields
	private static Hashtable serializersBySource; // 0x0

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1D5FC20 Offset: 0x1D5E220 VA: 0x181D5FC20
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0x1D5FC50 Offset: 0x1D5E250 VA: 0x181D5FC50
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0x1D5F980 Offset: 0x1D5DF80 VA: 0x181D5F980
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1D5FC80 Offset: 0x1D5E280 VA: 0x181D5FC80
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializerImplementation // TypeDefIndex: 6860
{
	// Properties
	public virtual XmlSerializationWriter Writer { get; }

	// Methods

	// RVA: 0x1D5FD00 Offset: 0x1D5E300 VA: 0x181D5FD00 Slot: 4
	public virtual XmlSerializationWriter get_Writer() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlTextAttribute : Attribute // TypeDefIndex: 6861
{
	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Properties
	public string DataType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x1D1DA70 Offset: 0x1D1C070 VA: 0x181D1DA70
	public string get_DataType() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Type get_Type() { }

	// RVA: 0x1D60DA0 Offset: 0x1D5F3A0 VA: 0x181D60DA0
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(1052)]
public class XmlTypeAttribute : Attribute // TypeDefIndex: 6862
{
	// Fields
	private bool includeInSchema; // 0x10
	private string ns; // 0x18
	private string typeName; // 0x20

	// Properties
	public bool IncludeInSchema { get; }
	public string Namespace { get; }
	public string TypeName { get; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_IncludeInSchema() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Namespace() { }

	// RVA: 0x1D60ED0 Offset: 0x1D5F4D0 VA: 0x181D60ED0
	public string get_TypeName() { }

	// RVA: 0x1D60E30 Offset: 0x1D5F430 VA: 0x181D60E30
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfo // TypeDefIndex: 6863
{
	// Fields
	private string _elementName; // 0x10
	private string _namespace; // 0x18
	private XmlSchemaForm _form; // 0x20
	private XmlTypeMapMember _member; // 0x28
	private object _choiceValue; // 0x30
	private bool _isNullable; // 0x38
	private int _nestingLevel; // 0x3C
	private XmlTypeMapping _mappedType; // 0x40
	private TypeData _type; // 0x48
	private bool _wrappedElement; // 0x50
	private int _explicitOrder; // 0x54

	// Properties
	public TypeData TypeData { get; }
	public object ChoiceValue { get; set; }
	public string ElementName { get; set; }
	public string Namespace { get; set; }
	public string DataTypeNamespace { get; }
	public string DataTypeName { get; }
	public XmlSchemaForm Form { get; set; }
	public XmlTypeMapping MappedType { get; set; }
	public bool IsNullable { get; set; }
	public XmlTypeMapMember Member { get; }
	public int NestingLevel { set; }
	public bool MultiReferenceType { get; }
	public bool WrappedElement { get; set; }
	public bool IsTextElement { get; set; }
	public bool IsUnnamedAnyElement { get; set; }
	public int ExplicitOrder { get; set; }

	// Methods

	// RVA: 0x1D61040 Offset: 0x1D5F640 VA: 0x181D61040
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public TypeData get_TypeData() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public object get_ChoiceValue() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_ChoiceValue(object value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_ElementName() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_ElementName(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Namespace() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Namespace(string value) { }

	// RVA: 0x1D61130 Offset: 0x1D5F730 VA: 0x181D61130
	public string get_DataTypeNamespace() { }

	// RVA: 0x1D61100 Offset: 0x1D5F700 VA: 0x181D61100
	public string get_DataTypeName() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public XmlSchemaForm get_Form() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_IsNullable() { }

	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_IsNullable(bool value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	public void set_NestingLevel(int value) { }

	// RVA: 0x1D611F0 Offset: 0x1D5F7F0 VA: 0x181D611F0
	public bool get_MultiReferenceType() { }

	// RVA: 0x95D0B0 Offset: 0x95B6B0 VA: 0x18095D0B0
	public bool get_WrappedElement() { }

	// RVA: 0x1031CD0 Offset: 0x10302D0 VA: 0x181031CD0
	public void set_WrappedElement(bool value) { }

	// RVA: 0x1D61190 Offset: 0x1D5F790 VA: 0x181D61190
	public bool get_IsTextElement() { }

	// RVA: 0x1D61210 Offset: 0x1D5F810 VA: 0x181D61210
	public void set_IsTextElement(bool value) { }

	// RVA: 0x1D611D0 Offset: 0x1D5F7D0 VA: 0x181D611D0
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0x1D612D0 Offset: 0x1D5F8D0 VA: 0x181D612D0
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x464C80 Offset: 0x463280 VA: 0x180464C80
	public int get_ExplicitOrder() { }

	// RVA: 0x464C90 Offset: 0x463290 VA: 0x180464C90
	public void set_ExplicitOrder(int value) { }

	// RVA: 0x1D60F00 Offset: 0x1D5F500 VA: 0x181D60F00 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfoList : ArrayList // TypeDefIndex: 6864
{
	// Methods

	// RVA: 0x1D60EF0 Offset: 0x1D5F4F0 VA: 0x181D60EF0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMember // TypeDefIndex: 6865
{
	// Fields
	private string _name; // 0x10
	private int _index; // 0x18
	private int _globalIndex; // 0x1C
	private int _specifiedGlobalIndex; // 0x20
	private TypeData _typeData; // 0x28
	private MemberInfo _member; // 0x30
	private MemberInfo _specifiedMember; // 0x38
	private MethodInfo _shouldSerialize; // 0x40
	private object _defaultValue; // 0x48
	private int _flags; // 0x50

	// Properties
	public string Name { get; set; }
	public object DefaultValue { get; set; }
	public TypeData TypeData { get; set; }
	public int Index { get; set; }
	public int GlobalIndex { get; set; }
	public bool IsOptionalValueType { get; set; }
	public bool IsReturnValue { get; set; }

	// Methods

	// RVA: 0x1D631E0 Offset: 0x1D617E0 VA: 0x181D631E0
	public void .ctor() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Name() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Name(string value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public object get_DefaultValue() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_DefaultValue(object value) { }

	// RVA: 0x1D62A30 Offset: 0x1D61030 VA: 0x181D62A30
	public bool IsReadOnly(Type type) { }

	// RVA: 0x1D625E0 Offset: 0x1D60BE0 VA: 0x181D625E0
	public static object GetValue(object ob, string name) { }

	// RVA: 0x1D62460 Offset: 0x1D60A60 VA: 0x181D62460
	public object GetValue(object ob) { }

	// RVA: 0x1D62E70 Offset: 0x1D61470 VA: 0x181D62E70
	public void SetValue(object ob, object value) { }

	// RVA: 0x1D63020 Offset: 0x1D61620 VA: 0x181D63020
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0x1D62780 Offset: 0x1D60D80 VA: 0x181D62780
	private void InitMember(Type type) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public TypeData get_TypeData() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_TypeData(TypeData value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_Index() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_Index(int value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_GlobalIndex() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_GlobalIndex(int value) { }

	// RVA: 0x13EEC00 Offset: 0x13ED200 VA: 0x1813EEC00
	public bool get_IsOptionalValueType() { }

	// RVA: 0x1D63260 Offset: 0x1D61860 VA: 0x181D63260
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0x13EEBE0 Offset: 0x13ED1E0 VA: 0x1813EEBE0
	public bool get_IsReturnValue() { }

	// RVA: 0x1D63290 Offset: 0x1D61890 VA: 0x181D63290
	public void set_IsReturnValue(bool value) { }

	// RVA: 0x1D620C0 Offset: 0x1D606C0 VA: 0x181D620C0
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0x1D62150 Offset: 0x1D60750 VA: 0x181D62150
	public bool GetValueSpecified(object ob) { }

	// RVA: 0x1D62B20 Offset: 0x1D61120 VA: 0x181D62B20
	public void SetValueSpecified(object ob, bool value) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAttribute : XmlTypeMapMember // TypeDefIndex: 6866
{
	// Fields
	private string _attributeName; // 0x58
	private string _namespace; // 0x60
	private XmlSchemaForm _form; // 0x68
	private XmlTypeMapping _mappedType; // 0x70

	// Properties
	public string AttributeName { get; set; }
	public string Namespace { get; set; }
	public XmlSchemaForm Form { set; }
	public XmlTypeMapping MappedType { get; set; }

	// Methods

	// RVA: 0x1D618B0 Offset: 0x1D5FEB0 VA: 0x181D618B0
	public void .ctor() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public string get_AttributeName() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_AttributeName(string value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public string get_Namespace() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_Namespace(string value) { }

	// RVA: 0xC9D9F0 Offset: 0xC9BFF0 VA: 0x180C9D9F0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void set_MappedType(XmlTypeMapping value) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberElement : XmlTypeMapMember // TypeDefIndex: 6867
{
	// Fields
	private XmlTypeMapElementInfoList _elementInfo; // 0x58
	private string _choiceMember; // 0x60
	private bool _isTextCollector; // 0x68
	private TypeData _choiceTypeData; // 0x70

	// Properties
	public XmlTypeMapElementInfoList ElementInfo { get; set; }
	public string ChoiceMember { get; set; }
	public TypeData ChoiceTypeData { get; set; }
	public bool IsXmlTextCollector { get; set; }

	// Methods

	// RVA: 0x1D61370 Offset: 0x1D5F970 VA: 0x181D61370
	public void .ctor() { }

	// RVA: 0x1D62050 Offset: 0x1D60650 VA: 0x181D62050
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public string get_ChoiceMember() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_ChoiceMember(string value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0x1D61900 Offset: 0x1D5FF00 VA: 0x181D61900
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0x1D61E90 Offset: 0x1D60490 VA: 0x181D61E90
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	public bool get_IsXmlTextCollector() { }

	// RVA: 0x528960 Offset: 0x526F60 VA: 0x180528960
	public void set_IsXmlTextCollector(bool value) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberList : XmlTypeMapMemberElement // TypeDefIndex: 6868
{
	// Methods

	// RVA: 0x1D61370 Offset: 0x1D5F970 VA: 0x181D61370
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement // TypeDefIndex: 6869
{
	// Fields
	private int _flatArrayIndex; // 0x78

	// Properties
	public int FlatArrayIndex { get; set; }

	// Methods

	// RVA: 0x1869360 Offset: 0x1867960 VA: 0x181869360
	public int get_FlatArrayIndex() { }

	// RVA: 0x18693A0 Offset: 0x18679A0 VA: 0x1818693A0
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0x1D61370 Offset: 0x1D5F970 VA: 0x181D61370
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable // TypeDefIndex: 6870
{
	// Fields
	private ListMap _listMap; // 0x80

	// Properties
	public ListMap ListMap { get; set; }

	// Methods

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public ListMap get_ListMap() { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	public void set_ListMap(ListMap value) { }

	// RVA: 0x1D61370 Offset: 0x1D5F970 VA: 0x181D61370
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable // TypeDefIndex: 6871
{
	// Properties
	public bool IsDefaultAny { get; }

	// Methods

	// RVA: 0x1D61380 Offset: 0x1D5F980 VA: 0x181D61380
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0x1D61650 Offset: 0x1D5FC50 VA: 0x181D61650
	public bool get_IsDefaultAny() { }

	// RVA: 0x1D61370 Offset: 0x1D5F970 VA: 0x181D61370
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember // TypeDefIndex: 6872
{
	// Methods

	// RVA: 0x1D61370 Offset: 0x1D5F970 VA: 0x181D61370
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberNamespaces : XmlTypeMapMember // TypeDefIndex: 6873
{
	// Methods

	// RVA: 0x1D61370 Offset: 0x1D5F970 VA: 0x181D61370
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
public class XmlTypeMapping : XmlMapping // TypeDefIndex: 6874
{
	// Fields
	private string xmlType; // 0x48
	private string xmlTypeNamespace; // 0x50
	private TypeData type; // 0x58
	private XmlTypeMapping baseMap; // 0x60
	private bool multiReferenceType; // 0x68
	private bool includeInSchema; // 0x69
	private bool isNullable; // 0x6A
	private bool isAny; // 0x6B
	private ArrayList _derivedTypes; // 0x70

	// Properties
	public string TypeFullName { get; }
	internal TypeData TypeData { get; }
	internal string XmlType { get; set; }
	internal string XmlTypeNamespace { get; set; }
	internal bool HasXmlTypeNamespace { get; }
	internal ArrayList DerivedTypes { get; }
	internal bool MultiReferenceType { get; }
	internal XmlTypeMapping BaseMap { get; set; }
	internal bool IncludeInSchema { set; }
	internal bool IsNullable { get; set; }
	internal bool IsAny { get; set; }

	// Methods

	// RVA: 0x1D63770 Offset: 0x1D61D70 VA: 0x181D63770
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0x1D63860 Offset: 0x1D61E60 VA: 0x181D63860
	public string get_TypeFullName() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal TypeData get_TypeData() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal string get_XmlType() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	internal void set_XmlType(string value) { }

	// RVA: 0x1D63880 Offset: 0x1D61E80 VA: 0x181D63880
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0x1D63840 Offset: 0x1D61E40 VA: 0x181D63840
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	internal bool get_MultiReferenceType() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0x534E80 Offset: 0x533480 VA: 0x180534E80
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0x1CC49C0 Offset: 0x1CC2FC0 VA: 0x181CC49C0
	internal bool get_IsNullable() { }

	// RVA: 0x1CC4D60 Offset: 0x1CC3360 VA: 0x181CC4D60
	internal void set_IsNullable(bool value) { }

	// RVA: 0x1D63850 Offset: 0x1D61E50 VA: 0x181D63850
	internal bool get_IsAny() { }

	// RVA: 0x1D638A0 Offset: 0x1D61EA0 VA: 0x181D638A0
	internal void set_IsAny(bool value) { }

	// RVA: 0x1D63540 Offset: 0x1D61B40 VA: 0x181D63540
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0x1D632C0 Offset: 0x1D618C0 VA: 0x181D632C0
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0x1D636E0 Offset: 0x1D61CE0 VA: 0x181D636E0
	internal void UpdateRoot(XmlQualifiedName qname) { }
}

// Namespace: System.Xml.Serialization
internal class XmlSerializableMapping : XmlTypeMapping // TypeDefIndex: 6875
{
	// Fields
	private XmlSchema _schema; // 0x78
	private XmlSchemaComplexType _schemaType; // 0x80
	private XmlQualifiedName _schemaTypeName; // 0x88

	// Methods

	// RVA: 0x1D5AAE0 Offset: 0x1D590E0 VA: 0x181D5AAE0
	internal void .ctor(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }
}

// Namespace: System.Xml.Serialization
internal class ClassMap : ObjectMap // TypeDefIndex: 6876
{
	// Fields
	private Hashtable _elements; // 0x10
	private ArrayList _elementMembers; // 0x18
	private Hashtable _attributeMembers; // 0x20
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; // 0x28
	private ArrayList _flatLists; // 0x30
	private ArrayList _allMembers; // 0x38
	private ArrayList _membersWithDefault; // 0x40
	private ArrayList _listMembers; // 0x48
	private XmlTypeMapMemberAnyElement _defaultAnyElement; // 0x50
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; // 0x58
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; // 0x60
	private XmlTypeMapMember _xmlTextCollector; // 0x68
	private XmlTypeMapMember _returnMember; // 0x70
	private bool _ignoreMemberNamespace; // 0x78
	private bool _canBeSimpleType; // 0x79
	private Nullable<bool> _isOrderDependentMap; // 0x7A

	// Properties
	public bool IsOrderDependentMap { get; }
	public XmlTypeMapMemberAnyElement DefaultAnyElementMember { get; }
	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember { get; }
	public XmlTypeMapMemberNamespaces NamespaceDeclarations { get; }
	public ICollection AttributeMembers { get; }
	public ICollection ElementMembers { get; }
	public ArrayList AllMembers { get; }
	public ArrayList FlatLists { get; }
	public ArrayList ListMembers { get; }
	public XmlTypeMapMember XmlTextCollector { get; }
	public XmlTypeMapMember ReturnMember { get; }
	public XmlQualifiedName SimpleContentBaseType { get; }
	public bool HasSimpleContent { get; }

	// Methods

	// RVA: 0x1D4DFD0 Offset: 0x1D4C5D0 VA: 0x181D4DFD0
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x1D4F3D0 Offset: 0x1D4D9D0 VA: 0x181D4F3D0
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x1D4ED30 Offset: 0x1D4D330 VA: 0x181D4ED30
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x1D4EE90 Offset: 0x1D4D490 VA: 0x181D4EE90
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x1D4F170 Offset: 0x1D4D770 VA: 0x181D4F170
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x1D4EC60 Offset: 0x1D4D260 VA: 0x181D4EC60
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x1D4F8D0 Offset: 0x1D4DED0 VA: 0x181D4F8D0
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x1D4F530 Offset: 0x1D4DB30 VA: 0x181D4F530
	public ICollection get_AttributeMembers() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ICollection get_ElementMembers() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public ArrayList get_AllMembers() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public ArrayList get_FlatLists() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public ArrayList get_ListMembers() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x1D4FB90 Offset: 0x1D4E190 VA: 0x181D4FB90
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x1919C10 Offset: 0x1918210 VA: 0x181919C10
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x1D4F870 Offset: 0x1D4DE70 VA: 0x181D4F870
	public bool get_HasSimpleContent() { }

	// RVA: 0x1D4F490 Offset: 0x1D4DA90 VA: 0x181D4F490
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class ListMap : ObjectMap // TypeDefIndex: 6877
{
	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Properties
	public string ChoiceMember { set; }
	public XmlTypeMapElementInfoList ItemInfo { get; set; }

	// Methods

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_ChoiceMember(string value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x1D52D10 Offset: 0x1D51310 VA: 0x181D52D10
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x1D533B0 Offset: 0x1D519B0 VA: 0x181D533B0
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x1D535E0 Offset: 0x1D51BE0 VA: 0x181D535E0
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x1D53800 Offset: 0x1D51E00 VA: 0x181D53800
	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	// RVA: 0x1D52B80 Offset: 0x1D51180 VA: 0x181D52B80 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class EnumMap : ObjectMap // TypeDefIndex: 6879
{
	// Fields
	private readonly EnumMap.EnumMapMember[] _members; // 0x10
	private readonly bool _isFlags; // 0x18
	private readonly string[] _enumNames; // 0x20
	private readonly string[] _xmlNames; // 0x28
	private readonly long[] _values; // 0x30

	// Properties
	public bool IsFlags { get; }
	public string[] EnumNames { get; }
	public string[] XmlNames { get; }
	public long[] Values { get; }

	// Methods

	// RVA: 0x1D51AA0 Offset: 0x1D500A0 VA: 0x181D51AA0
	public void .ctor(EnumMap.EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_IsFlags() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string[] get_EnumNames() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string[] get_XmlNames() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public long[] get_Values() { }

	// RVA: 0x1D51720 Offset: 0x1D4FD20 VA: 0x181D51720
	public string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x1D51450 Offset: 0x1D4FA50 VA: 0x181D51450
	public string GetEnumName(string typeName, string xmlName) { }
}

