// Namespace: System.Xml.XPath
public class XPathDocument // TypeDefIndex: 6784
{
	// Fields
	private XPathNode[] pageXmlNmsp; // 0x10
	private int idxXmlNmsp; // 0x18
	private XmlNameTable nameTable; // 0x20
	private bool hasLineInfo; // 0x28
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; // 0x30

	// Properties
	internal XmlNameTable NameTable { get; }
	internal bool HasLineInfo { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	internal bool get_HasLineInfo() { }

	// RVA: 0x1D1B380 Offset: 0x1D19980 VA: 0x181D1B380
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0x1D1B3B0 Offset: 0x1D199B0 VA: 0x181D1B3B0
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }
}

// Namespace: System.Xml.XPath
[Serializable]
public class XPathException : SystemException // TypeDefIndex: 6785
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string message; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1D1B9F0 Offset: 0x1D19FF0 VA: 0x181D1B9F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D1B770 Offset: 0x1D19D70 VA: 0x181D1B770 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D1B930 Offset: 0x1D19F30 VA: 0x181D1B930
	public void .ctor() { }

	// RVA: 0x1D1B870 Offset: 0x1D19E70 VA: 0x181D1B870
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1D1B570 Offset: 0x1D19B70 VA: 0x181D1B570
	internal static XPathException Create(string res) { }

	// RVA: 0x1D1B5D0 Offset: 0x1D19BD0 VA: 0x181D1B5D0
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0x1D1B690 Offset: 0x1D19C90 VA: 0x181D1B690
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x1D1B850 Offset: 0x1D19E50 VA: 0x181D1B850
	private void .ctor(string res, string[] args) { }

	// RVA: 0x1D1BCA0 Offset: 0x1D1A2A0 VA: 0x181D1BCA0
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x1D1B4C0 Offset: 0x1D19AC0 VA: 0x181D1B4C0
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0x1D1BD30 Offset: 0x1D1A330 VA: 0x181D1BD30 Slot: 5
	public override string get_Message() { }
}

// Namespace: System.Xml.XPath
public enum XPathResultType // TypeDefIndex: 6786
{
	// Fields
	public int value__; // 0x0
	public const XPathResultType Number = 0;
	public const XPathResultType String = 1;
	public const XPathResultType Boolean = 2;
	public const XPathResultType NodeSet = 3;
	public const XPathResultType Navigator = 1;
	public const XPathResultType Any = 5;
	public const XPathResultType Error = 6;
}

// Namespace: System.Xml.XPath
public abstract class XPathItem // TypeDefIndex: 6787
{
	// Properties
	public abstract XmlSchemaType XmlType { get; }
	public abstract string Value { get; }
	public abstract object TypedValue { get; }
	public abstract Type ValueType { get; }
	public abstract bool ValueAsBoolean { get; }
	public abstract DateTime ValueAsDateTime { get; }
	public abstract double ValueAsDouble { get; }
	public abstract int ValueAsInt { get; }
	public abstract long ValueAsLong { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_XmlType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object get_TypedValue();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_ValueAsBoolean();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DateTime get_ValueAsDateTime();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract double get_ValueAsDouble();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_ValueAsInt();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_ValueAsLong();

	// RVA: 0x1D1BD50 Offset: 0x1D1A350 VA: 0x181D1BD50 Slot: 13
	public virtual object ValueAs(Type returnType) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.XPath
public enum XPathNamespaceScope // TypeDefIndex: 6788
{
	// Fields
	public int value__; // 0x0
	public const XPathNamespaceScope All = 0;
	public const XPathNamespaceScope ExcludeXml = 1;
	public const XPathNamespaceScope Local = 2;
}

// Namespace: System.Xml.XPath
[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver // TypeDefIndex: 6789
{
	// Fields
	internal static readonly XPathNavigatorKeyComparer comparer; // 0x0
	internal static readonly char[] NodeTypeLetter; // 0x8
	internal static readonly char[] UniqueIdTbl; // 0x10
	internal static readonly int[] ContentKindMasks; // 0x18

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override object TypedValue { get; }
	public override Type ValueType { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public abstract XmlNameTable NameTable { get; }
	public abstract XPathNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public virtual object UnderlyingObject { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0x5482B0 Offset: 0x5468B0 VA: 0x1805482B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D1D800 Offset: 0x1D1BE00 VA: 0x181D1D800 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x1D1CB80 Offset: 0x1D1B180 VA: 0x181D1CB80 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x1D1D720 Offset: 0x1D1BD20 VA: 0x181D1D720 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1D1CD70 Offset: 0x1D1B370 VA: 0x181D1CD70 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x1D1CF60 Offset: 0x1D1B560 VA: 0x181D1CF60 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x1D1D150 Offset: 0x1D1B750 VA: 0x181D1D150 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x1D1D340 Offset: 0x1D1B940 VA: 0x181D1D340 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x1D1D530 Offset: 0x1D1BB30 VA: 0x181D1D530 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x1D1C760 Offset: 0x1D1AD60 VA: 0x181D1C760 Slot: 14
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1CA5FA0 Offset: 0x1CA45A0 VA: 0x181CA5FA0 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract XmlNameTable get_NameTable();

	// RVA: 0x1D1C2C0 Offset: 0x1D1A8C0 VA: 0x181D1C2C0 Slot: 20
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x1D1C470 Offset: 0x1D1AA70 VA: 0x181D1C470 Slot: 21
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0x1D1C0A0 Offset: 0x1D1A6A0 VA: 0x181D1C0A0 Slot: 22
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract XPathNavigator Clone();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract XPathNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Prefix();

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 28
	public virtual object get_UnderlyingObject() { }

	// RVA: 0x1D1C6B0 Offset: 0x1D1ACB0 VA: 0x181D1C6B0 Slot: 29
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool MoveToParent();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool IsSamePosition(XPathNavigator other);

	// RVA: 0x1D1CB40 Offset: 0x1D1B140 VA: 0x181D1CB40 Slot: 34
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1D1C2B0 Offset: 0x1D1A8B0 VA: 0x181D1C2B0
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1D1C990 Offset: 0x1D1AF90 VA: 0x181D1C990
	private static void .cctor() { }
}

// Namespace: System.Xml.XPath
internal class XPathNavigatorKeyComparer : IEqualityComparer // TypeDefIndex: 6790
{
	// Methods

	// RVA: 0x1D1BD70 Offset: 0x1D1A370 VA: 0x181D1BD70 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0x1D1BE60 Offset: 0x1D1A460 VA: 0x181D1BE60 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.XPath
public enum XPathNodeType // TypeDefIndex: 6791
{
	// Fields
	public int value__; // 0x0
	public const XPathNodeType Root = 0;
	public const XPathNodeType Element = 1;
	public const XPathNodeType Attribute = 2;
	public const XPathNodeType Namespace = 3;
	public const XPathNodeType Text = 4;
	public const XPathNodeType SignificantWhitespace = 5;
	public const XPathNodeType Whitespace = 6;
	public const XPathNodeType ProcessingInstruction = 7;
	public const XPathNodeType Comment = 8;
	public const XPathNodeType All = 9;
}

