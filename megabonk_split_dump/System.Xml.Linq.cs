// Namespace: System.Xml.Linq
internal class BaseUriAnnotation // TypeDefIndex: 13825
{
	// Fields
	internal string baseUri; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(string baseUri) { }
}

// Namespace: System.Xml.Linq
internal class LineInfoAnnotation // TypeDefIndex: 13826
{
	// Fields
	internal int lineNumber; // 0x10
	internal int linePosition; // 0x14

	// Methods

	// RVA: 0x1669140 Offset: 0x1667740 VA: 0x181669140
	public void .ctor(int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Linq
internal class LineInfoEndElementAnnotation : LineInfoAnnotation // TypeDefIndex: 13827
{
	// Methods

	// RVA: 0x1669140 Offset: 0x1667740 VA: 0x181669140
	public void .ctor(int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Linq
public class XAttribute : XObject // TypeDefIndex: 13828
{
	// Fields
	internal XAttribute next; // 0x20
	internal XName name; // 0x28
	internal string value; // 0x30

	// Properties
	public bool IsNamespaceDeclaration { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x1BC9E50 Offset: 0x1BC8450 VA: 0x181BC9E50
	public void .ctor(XName name, object value) { }

	// RVA: 0x1BC9F60 Offset: 0x1BC8560 VA: 0x181BC9F60
	public void .ctor(XAttribute other) { }

	// RVA: 0x1BCA000 Offset: 0x1BC8600 VA: 0x181BCA000
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public XName get_Name() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_Value() { }

	// RVA: 0x1BCA090 Offset: 0x1BC8690 VA: 0x181BCA090
	public void set_Value(string value) { }

	// RVA: 0x1BC9720 Offset: 0x1BC7D20 VA: 0x181BC9720 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BC95F0 Offset: 0x1BC7BF0 VA: 0x181BC95F0
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1BC9AA0 Offset: 0x1BC80A0 VA: 0x181BC9AA0
	private static void ValidateAttribute(XName name, string value) { }
}

// Namespace: System.Xml.Linq
public class XCData : XText // TypeDefIndex: 13829
{
	// Properties
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x1BCA2F0 Offset: 0x1BC88F0 VA: 0x181BCA2F0
	public void .ctor(string value) { }

	// RVA: 0x1BCA370 Offset: 0x1BC8970 VA: 0x181BCA370
	public void .ctor(XCData other) { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1BCA270 Offset: 0x1BC8870 VA: 0x181BCA270 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1BCA1C0 Offset: 0x1BC87C0 VA: 0x181BCA1C0 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: System.Xml.Linq
public class XComment : XNode // TypeDefIndex: 13830
{
	// Fields
	internal string value; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x1BCA5A0 Offset: 0x1BC8BA0 VA: 0x181BCA5A0
	public void .ctor(string value) { }

	// RVA: 0x1BCA520 Offset: 0x1BC8B20 VA: 0x181BCA520
	public void .ctor(XComment other) { }

	// RVA: 0x44F6B0 Offset: 0x44DCB0 VA: 0x18044F6B0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Value() { }

	// RVA: 0x1BCA620 Offset: 0x1BC8C20 VA: 0x181BCA620
	public void set_Value(string value) { }

	// RVA: 0x1BCA4A0 Offset: 0x1BC8AA0 VA: 0x181BCA4A0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1BCA3F0 Offset: 0x1BC89F0 VA: 0x181BCA3F0 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: System.Xml.Linq
public abstract class XContainer : XNode // TypeDefIndex: 13834
{
	// Fields
	internal object content; // 0x28

	// Properties
	public XNode LastNode { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1BCD000 Offset: 0x1BCB600 VA: 0x181BCD000
	internal void .ctor(XContainer other) { }

	// RVA: 0x1BCD160 Offset: 0x1BCB760 VA: 0x181BCD160
	public XNode get_LastNode() { }

	// RVA: 0x1BCB570 Offset: 0x1BC9B70 VA: 0x181BCB570
	public void Add(object content) { }

	// RVA: 0x1BCBDE0 Offset: 0x1BCA3E0 VA: 0x181BCBDE0
	public IEnumerable<XElement> Elements() { }

	[IteratorStateMachine(typeof(XContainer.<Nodes>d__18))]
	// RVA: 0x1BCC340 Offset: 0x1BCA940 VA: 0x181BCC340
	public IEnumerable<XNode> Nodes() { }

	// RVA: 0x1BCCA50 Offset: 0x1BCB050 VA: 0x181BCCA50
	public void RemoveNodes() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1BCA740 Offset: 0x1BC8D40 VA: 0x181BCA740
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x1BCAF30 Offset: 0x1BC9530 VA: 0x181BCAF30
	internal void AddNode(XNode n) { }

	// RVA: 0x1BCAE90 Offset: 0x1BC9490 VA: 0x181BCAE90
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x1BCB180 Offset: 0x1BC9780 VA: 0x181BCB180
	internal void AddString(string s) { }

	// RVA: 0x1BCAFD0 Offset: 0x1BC95D0 VA: 0x181BCAFD0
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x1BCBAB0 Offset: 0x1BCA0B0 VA: 0x181BCBAB0
	internal void AppendNode(XNode n) { }

	// RVA: 0x1BCB9C0 Offset: 0x1BC9FC0 VA: 0x181BCB9C0
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x1BCBBE0 Offset: 0x1BCA1E0 VA: 0x181BCBBE0 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x1BCBCD0 Offset: 0x1BCA2D0 VA: 0x181BCBCD0
	internal void ConvertTextToNode() { }

	[IteratorStateMachine(typeof(XContainer.<GetElements>d__39))]
	// RVA: 0x1BCBE70 Offset: 0x1BCA470 VA: 0x181BCBE70
	private IEnumerable<XElement> GetElements(XName name) { }

	// RVA: 0x1BCBF00 Offset: 0x1BCA500 VA: 0x181BCBF00
	internal static string GetStringValue(object value) { }

	// RVA: 0x1BCC3C0 Offset: 0x1BCA9C0 VA: 0x181BCC3C0
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x1BCC4D0 Offset: 0x1BCAAD0 VA: 0x181BCC4D0
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1BCC780 Offset: 0x1BCAD80 VA: 0x181BCC780
	internal void RemoveNode(XNode n) { }

	// RVA: 0x1BCC980 Offset: 0x1BCAF80 VA: 0x181BCC980
	private void RemoveNodesSkipNotify() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 14
	internal virtual void ValidateString(string s) { }

	// RVA: 0x1BCCE90 Offset: 0x1BCB490 VA: 0x181BCCE90
	internal void WriteContentTo(XmlWriter writer) { }
}

// Namespace: System.Xml.Linq
public class XDeclaration // TypeDefIndex: 13835
{
	// Fields
	private string _version; // 0x10
	private string _encoding; // 0x18
	private string _standalone; // 0x20

	// Properties
	public string Encoding { get; set; }
	public string Standalone { get; set; }
	public string Version { get; }

	// Methods

	// RVA: 0xA68FD0 Offset: 0xA675D0 VA: 0x180A68FD0
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x1BCD490 Offset: 0x1BCBA90 VA: 0x181BCD490
	public void .ctor(XDeclaration other) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Encoding() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Encoding(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Standalone() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Standalone(string value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Version() { }

	// RVA: 0x1BCD2D0 Offset: 0x1BCB8D0 VA: 0x181BCD2D0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml.Linq
public class XDocument : XContainer // TypeDefIndex: 13836
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Properties
	public XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public XElement Root { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1BCDFC0 Offset: 0x1BCC5C0 VA: 0x181BCDFC0
	public void .ctor(XDocument other) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public XDeclaration get_Declaration() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0x458E50 Offset: 0x457450 VA: 0x180458E50 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1BCE090 Offset: 0x1BCC690 VA: 0x181BCE090
	public XElement get_Root() { }

	// RVA: 0x1BCDE80 Offset: 0x1BCC480 VA: 0x181BCDE80 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1BCD8A0 Offset: 0x1BCBEA0 VA: 0x181BCD8A0 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x1BCD850 Offset: 0x1BCBE50 VA: 0x181BCD850 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1BCD8F0 Offset: 0x1BCBEF0 VA: 0x181BCD8F0 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: -1 Offset: -1
	private T GetFirstNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x813BA0 Offset: 0x8121A0 VA: 0x180813BA0
	|-XDocument.GetFirstNode<object>
	*/

	// RVA: 0x1BCD9E0 Offset: 0x1BCBFE0 VA: 0x181BCD9E0
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x1BCDB90 Offset: 0x1BCC190 VA: 0x181BCDB90 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x1BCDA60 Offset: 0x1BCC060 VA: 0x181BCDA60
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x1BCDDC0 Offset: 0x1BCC3C0 VA: 0x181BCDDC0 Slot: 14
	internal override void ValidateString(string s) { }
}

// Namespace: System.Xml.Linq
public class XDocumentType : XNode // TypeDefIndex: 13837
{
	// Fields
	private string _name; // 0x28
	private string _publicId; // 0x30
	private string _systemId; // 0x38
	private string _internalSubset; // 0x40

	// Properties
	public string InternalSubset { get; }
	public string Name { get; }
	public override XmlNodeType NodeType { get; }
	public string PublicId { get; }
	public string SystemId { get; }

	// Methods

	// RVA: 0x1BCD790 Offset: 0x1BCBD90 VA: 0x181BCD790
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1BCD6D0 Offset: 0x1BCBCD0 VA: 0x181BCD6D0
	public void .ctor(XDocumentType other) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_InternalSubset() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Name() { }

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_PublicId() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_SystemId() { }

	// RVA: 0x1BCD630 Offset: 0x1BCBC30 VA: 0x181BCD630 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1BCD540 Offset: 0x1BCBB40 VA: 0x181BCD540 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: System.Xml.Linq
[XmlSchemaProvider(null, IsAny = True)]
[XmlTypeConvertor("ConvertForAssignment")]
public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 13839
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Properties
	public bool HasAttributes { get; }
	public bool IsEmpty { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x1BCFBD0 Offset: 0x1BCE1D0 VA: 0x181BCFBD0
	public void .ctor(XName name) { }

	// RVA: 0x1BCF9B0 Offset: 0x1BCDFB0 VA: 0x181BCF9B0
	public void .ctor(XElement other) { }

	// RVA: 0x1BCFB40 Offset: 0x1BCE140 VA: 0x181BCFB40
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x1BCFC50 Offset: 0x1BCE250 VA: 0x181BCFC50
	public bool get_HasAttributes() { }

	// RVA: 0x1BCFC60 Offset: 0x1BCE260 VA: 0x181BCFC60
	public bool get_IsEmpty() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public XName get_Name() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1BCFC70 Offset: 0x1BCE270 VA: 0x181BCFC70
	public string get_Value() { }

	// RVA: 0x1BCFD70 Offset: 0x1BCE370 VA: 0x181BCFD70
	public void set_Value(string value) { }

	// RVA: 0x1BCE6C0 Offset: 0x1BCCCC0 VA: 0x181BCE6C0
	public XAttribute Attribute(XName name) { }

	// RVA: 0x1BCE700 Offset: 0x1BCCD00 VA: 0x181BCE700
	public IEnumerable<XAttribute> Attributes() { }

	// RVA: 0x1BCEB00 Offset: 0x1BCD100 VA: 0x181BCEB00
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1BCF8F0 Offset: 0x1BCDEF0 VA: 0x181BCF8F0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 15
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1BCF530 Offset: 0x1BCDB30 VA: 0x181BCF530 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x17A6340 Offset: 0x17A4940 VA: 0x1817A6340 Slot: 17
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1BCE250 Offset: 0x1BCC850 VA: 0x181BCE250 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x1BCE0D0 Offset: 0x1BCC6D0 VA: 0x181BCE0D0 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1BCE540 Offset: 0x1BCCB40 VA: 0x181BCE540
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x1BCE4B0 Offset: 0x1BCCAB0 VA: 0x181BCE4B0
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1BCE790 Offset: 0x1BCCD90 VA: 0x181BCE790 Slot: 10
	internal override XNode CloneNode() { }

	[IteratorStateMachine(typeof(XElement.<GetAttributes>d__116))]
	// RVA: 0x1BCE950 Offset: 0x1BCCF50 VA: 0x181BCE950
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	// RVA: 0x1BCE9E0 Offset: 0x1BCCFE0 VA: 0x181BCE9E0
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x1BCF420 Offset: 0x1BCDA20 VA: 0x181BCF420
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1BCEDB0 Offset: 0x1BCD3B0 VA: 0x181BCEDB0
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x1BCF4B0 Offset: 0x1BCDAB0 VA: 0x181BCF4B0
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1BCF750 Offset: 0x1BCDD50 VA: 0x181BCF750 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }
}

// Namespace: System.Xml.Linq
internal sealed class XHashtable<TValue> // TypeDefIndex: 13843
{
	// Fields
	private XHashtable.XHashtableState<TValue> _state; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC05730 Offset: 0xC03D30 VA: 0x180C05730
	|-XHashtable<object>..ctor
	|
	|-RVA: 0xC05690 Offset: 0xC03C90 VA: 0x180C05690
	|-XHashtable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC05530 Offset: 0xC03B30 VA: 0x180C05530
	|-XHashtable<object>.TryGetValue
	|
	|-RVA: 0xC054E0 Offset: 0xC03AE0 VA: 0x180C054E0
	|-XHashtable<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC05180 Offset: 0xC03780 VA: 0x180C05180
	|-XHashtable<object>.Add
	|
	|-RVA: 0xC052A0 Offset: 0xC038A0 VA: 0x180C052A0
	|-XHashtable<__Il2CppFullySharedGenericType>.Add
	*/
}

// Namespace: System.Xml.Linq
internal struct NamespaceCache // TypeDefIndex: 13844
{
	// Fields
	private XNamespace _ns; // 0x0
	private string _namespaceName; // 0x8

	// Methods

	// RVA: 0x1BC8700 Offset: 0x1BC6D00 VA: 0x181BC8700
	public XNamespace Get(string namespaceName) { }
}

// Namespace: System.Xml.Linq
internal struct ElementWriter // TypeDefIndex: 13845
{
	// Fields
	private XmlWriter _writer; // 0x0
	private NamespaceResolver _resolver; // 0x8

	// Methods

	// RVA: 0x1BC86D0 Offset: 0x1BC6CD0 VA: 0x181BC86D0
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1BC80A0 Offset: 0x1BC66A0 VA: 0x181BC80A0
	public void WriteElement(XElement e) { }

	// RVA: 0x1BC7C00 Offset: 0x1BC6200 VA: 0x181BC7C00
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x1BC7CE0 Offset: 0x1BC62E0 VA: 0x181BC7CE0
	private void PushAncestors(XElement e) { }

	// RVA: 0x1BC7F00 Offset: 0x1BC6500 VA: 0x181BC7F00
	private void PushElement(XElement e) { }

	// RVA: 0x1BC8330 Offset: 0x1BC6930 VA: 0x181BC8330
	private void WriteEndElement() { }

	// RVA: 0x1BC8370 Offset: 0x1BC6970 VA: 0x181BC8370
	private void WriteFullEndElement() { }

	// RVA: 0x1BC83B0 Offset: 0x1BC69B0 VA: 0x181BC83B0
	private void WriteStartElement(XElement e) { }
}

// Namespace: System.Xml.Linq
internal struct NamespaceResolver // TypeDefIndex: 13847
{
	// Fields
	private int _scope; // 0x0
	private NamespaceResolver.NamespaceDeclaration _declaration; // 0x8
	private NamespaceResolver.NamespaceDeclaration _rover; // 0x10

	// Methods

	// RVA: 0x1BC8B60 Offset: 0x1BC7160 VA: 0x181BC8B60
	public void PushScope() { }

	// RVA: 0x1BC8AC0 Offset: 0x1BC70C0 VA: 0x181BC8AC0
	public void PopScope() { }

	// RVA: 0x1BC88B0 Offset: 0x1BC6EB0 VA: 0x181BC88B0
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x1BC87B0 Offset: 0x1BC6DB0 VA: 0x181BC87B0
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x1BC89A0 Offset: 0x1BC6FA0 VA: 0x181BC89A0
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }
}

// Namespace: System.Xml.Linq
public enum XObjectChange // TypeDefIndex: 13848
{
	// Fields
	public int value__; // 0x0
	public const XObjectChange Add = 0;
	public const XObjectChange Remove = 1;
	public const XObjectChange Name = 2;
	public const XObjectChange Value = 3;
}

// Namespace: System.Xml.Linq
[Flags]
public enum LoadOptions // TypeDefIndex: 13849
{
	// Fields
	public int value__; // 0x0
	public const LoadOptions None = 0;
	public const LoadOptions PreserveWhitespace = 1;
	public const LoadOptions SetBaseUri = 2;
	public const LoadOptions SetLineInfo = 4;
}

// Namespace: System.Xml.Linq
[Flags]
public enum SaveOptions // TypeDefIndex: 13850
{
	// Fields
	public int value__; // 0x0
	public const SaveOptions None = 0;
	public const SaveOptions DisableFormatting = 1;
	public const SaveOptions OmitDuplicateNamespaces = 2;
}

// Namespace: System.Xml.Linq
[Serializable]
public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 13851
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _localName; // 0x18
	private int _hashCode; // 0x20

	// Properties
	public string LocalName { get; }
	public XNamespace Namespace { get; }
	public string NamespaceName { get; }

	// Methods

	// RVA: 0x1BD0180 Offset: 0x1BCE780 VA: 0x181BD0180
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_LocalName() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public XNamespace get_Namespace() { }

	// RVA: 0xBE5930 Offset: 0xBE3F30 VA: 0x180BE5930
	public string get_NamespaceName() { }

	// RVA: 0x1BD00F0 Offset: 0x1BCE6F0 VA: 0x181BD00F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BCFDF0 Offset: 0x1BCE3F0 VA: 0x181BCFDF0
	public static XName Get(string expandedName) { }

	// RVA: 0x1BCFFC0 Offset: 0x1BCE5C0 VA: 0x181BCFFC0
	public static XName Get(string localName, string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x1BD0290 Offset: 0x1BCE890 VA: 0x181BD0290
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50 Slot: 4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x1BD00B0 Offset: 0x1BCE6B0 VA: 0x181BD00B0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BD0260 Offset: 0x1BCE860 VA: 0x181BD0260
	internal void .ctor() { }
}

// Namespace: System.Xml.Linq
public sealed class XNamespace // TypeDefIndex: 13852
{
	// Fields
	private static XHashtable<WeakReference> s_namespaces; // 0x0
	private static WeakReference s_refNone; // 0x8
	private static WeakReference s_refXml; // 0x10
	private static WeakReference s_refXmlns; // 0x18
	private string _namespaceName; // 0x10
	private int _hashCode; // 0x18
	private XHashtable<XName> _names; // 0x20

	// Properties
	public string NamespaceName { get; }
	public static XNamespace None { get; }
	public static XNamespace Xml { get; }
	public static XNamespace Xmlns { get; }

	// Methods

	// RVA: 0x1BD0AA0 Offset: 0x1BCF0A0 VA: 0x181BD0AA0
	internal void .ctor(string namespaceName) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_NamespaceName() { }

	// RVA: 0x1BD05D0 Offset: 0x1BCEBD0 VA: 0x181BD05D0
	public XName GetName(string localName) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BD0BA0 Offset: 0x1BCF1A0 VA: 0x181BD0BA0
	public static XNamespace get_None() { }

	// RVA: 0x1BD0BF0 Offset: 0x1BCF1F0 VA: 0x181BD0BF0
	public static XNamespace get_Xml() { }

	// RVA: 0x1BD0C50 Offset: 0x1BCF250 VA: 0x181BD0C50
	public static XNamespace get_Xmlns() { }

	// RVA: 0x1BD0A30 Offset: 0x1BCF030 VA: 0x181BD0A30
	public static XNamespace Get(string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x1BD0CB0 Offset: 0x1BCF2B0 VA: 0x181BD0CB0
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x58E060 Offset: 0x58C660 VA: 0x18058E060
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x1BD0430 Offset: 0x1BCEA30 VA: 0x181BD0430
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x1BD0650 Offset: 0x1BCEC50 VA: 0x181BD0650
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x12E74F0 Offset: 0x12E5AF0 VA: 0x1812E74F0
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x1BD03B0 Offset: 0x1BCE9B0 VA: 0x181BD03B0
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x1BD02A0 Offset: 0x1BCE8A0 VA: 0x181BD02A0
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }
}

// Namespace: System.Xml.Linq
public abstract class XNode : XObject // TypeDefIndex: 13853
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1BD0FC0 Offset: 0x1BCF5C0 VA: 0x181BD0FC0
	public void Remove() { }

	// RVA: 0x1BD1030 Offset: 0x1BCF630 VA: 0x181BD1030 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteTo(XmlWriter writer);

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract XNode CloneNode();

	// RVA: 0x1BD0CD0 Offset: 0x1BCF2D0 VA: 0x181BD0CD0
	private string GetXmlString(SaveOptions o) { }
}

// Namespace: System.Xml.Linq
public abstract class XObject : IXmlLineInfo // TypeDefIndex: 13854
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Properties
	public string BaseUri { get; }
	public abstract XmlNodeType NodeType { get; }
	public XElement Parent { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }
	internal bool HasBaseUri { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1BD1C40 Offset: 0x1BD0240 VA: 0x181BD1C40
	public string get_BaseUri() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x1BD1D00 Offset: 0x1BD0300 VA: 0x181BD1D00
	public XElement get_Parent() { }

	// RVA: 0x1BD12E0 Offset: 0x1BCF8E0 VA: 0x181BD12E0
	public void AddAnnotation(object annotation) { }

	// RVA: 0x1BD15A0 Offset: 0x1BCFBA0 VA: 0x181BD15A0
	private object AnnotationForSealedType(Type type) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8154A0 Offset: 0x813AA0 VA: 0x1808154A0
	|-XObject.Annotation<object>
	*/

	// RVA: 0x1BD1B60 Offset: 0x1BD0160 VA: 0x181BD1B60 Slot: 4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x1BD1BA0 Offset: 0x1BD01A0 VA: 0x181BD1BA0 Slot: 5
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1BD1BF0 Offset: 0x1BD01F0 VA: 0x181BD1BF0 Slot: 6
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x1BD1CC0 Offset: 0x1BD02C0 VA: 0x181BD1CC0
	internal bool get_HasBaseUri() { }

	// RVA: 0x1BD1890 Offset: 0x1BCFE90 VA: 0x181BD1890
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x1BD1940 Offset: 0x1BCFF40 VA: 0x181BD1940
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x1BD19F0 Offset: 0x1BCFFF0 VA: 0x181BD19F0
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x1BD1A70 Offset: 0x1BD0070 VA: 0x181BD1A70
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1BD1AF0 Offset: 0x1BD00F0 VA: 0x181BD1AF0
	internal bool SkipNotify() { }

	// RVA: 0x1BD16D0 Offset: 0x1BCFCD0 VA: 0x181BD16D0
	internal SaveOptions GetSaveOptionsFromAnnotations() { }
}

// Namespace: System.Xml.Linq
internal class XObjectChangeAnnotation // TypeDefIndex: 13855
{
	// Fields
	internal EventHandler<XObjectChangeEventArgs> changing; // 0x10
	internal EventHandler<XObjectChangeEventArgs> changed; // 0x18
}

// Namespace: System.Xml.Linq
public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 13856
{
	// Fields
	private XObjectChange _objectChange; // 0x10
	public static readonly XObjectChangeEventArgs Add; // 0x0
	public static readonly XObjectChangeEventArgs Remove; // 0x8
	public static readonly XObjectChangeEventArgs Name; // 0x10
	public static readonly XObjectChangeEventArgs Value; // 0x18

	// Methods

	// RVA: 0x1BD1280 Offset: 0x1BCF880 VA: 0x181BD1280
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x1BD1060 Offset: 0x1BCF660 VA: 0x181BD1060
	private static void .cctor() { }
}

// Namespace: System.Xml.Linq
public class XProcessingInstruction : XNode // TypeDefIndex: 13857
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Properties
	public string Data { get; set; }
	public override XmlNodeType NodeType { get; }
	public string Target { get; }

	// Methods

	// RVA: 0x1BD1FB0 Offset: 0x1BD05B0 VA: 0x181BD1FB0
	public void .ctor(string target, string data) { }

	// RVA: 0x1BD2110 Offset: 0x1BD0710 VA: 0x181BD2110
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_Data() { }

	// RVA: 0x1BD21B0 Offset: 0x1BD07B0 VA: 0x181BD21B0
	public void set_Data(string value) { }

	// RVA: 0x4565D0 Offset: 0x454BD0 VA: 0x1804565D0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Target() { }

	// RVA: 0x1BD1F30 Offset: 0x1BD0530 VA: 0x181BD1F30 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1BD1D90 Offset: 0x1BD0390 VA: 0x181BD1D90 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: 0x1BD1E50 Offset: 0x1BD0450 VA: 0x181BD1E50
	private static void ValidateName(string name) { }
}

// Namespace: System.Xml.Linq
public class XStreamingElement // TypeDefIndex: 13858
{
	// Fields
	internal XName name; // 0x10
	internal object content; // 0x18
}

// Namespace: System.Xml.Linq
public class XText : XNode // TypeDefIndex: 13859
{
	// Fields
	internal string text; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x1BCA2F0 Offset: 0x1BC88F0 VA: 0x181BCA2F0
	public void .ctor(string value) { }

	// RVA: 0x1BCA370 Offset: 0x1BC8970 VA: 0x181BCA370
	public void .ctor(XText other) { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Value() { }

	// RVA: 0x1BD24B0 Offset: 0x1BD0AB0 VA: 0x181BD24B0
	public void set_Value(string value) { }

	// RVA: 0x1BD23B0 Offset: 0x1BD09B0 VA: 0x181BD23B0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1BD22D0 Offset: 0x1BD08D0 VA: 0x181BD22D0 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x1BD2300 Offset: 0x1BD0900 VA: 0x181BD2300 Slot: 10
	internal override XNode CloneNode() { }
}

