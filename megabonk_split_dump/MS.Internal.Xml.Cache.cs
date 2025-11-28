// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 7196
{
	// Fields
	private XPathNode[] _pageCurrent; // 0x10
	private XPathNode[] _pageParent; // 0x18
	private int _idxCurrent; // 0x20
	private int _idxParent; // 0x24

	// Properties
	public override string Value { get; }
	public override XPathNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override XmlNameTable NameTable { get; }
	public override object UnderlyingObject { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x1CA5C90 Offset: 0x1CA4290 VA: 0x181CA5C90
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x1CA5FC0 Offset: 0x1CA45C0 VA: 0x181CA5FC0 Slot: 5
	public override string get_Value() { }

	// RVA: 0x1CA5580 Offset: 0x1CA3B80 VA: 0x181CA5580 Slot: 23
	public override XPathNavigator Clone() { }

	// RVA: 0x1CA5F20 Offset: 0x1CA4520 VA: 0x181CA5F20 Slot: 24
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x1CA5E50 Offset: 0x1CA4450 VA: 0x181CA5E50 Slot: 25
	public override string get_LocalName() { }

	// RVA: 0x1CA5EE0 Offset: 0x1CA44E0 VA: 0x181CA5EE0 Slot: 26
	public override string get_NamespaceURI() { }

	// RVA: 0x1CA5F60 Offset: 0x1CA4560 VA: 0x181CA5F60 Slot: 27
	public override string get_Prefix() { }

	// RVA: 0x1CA5E90 Offset: 0x1CA4490 VA: 0x181CA5E90 Slot: 19
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1CA5750 Offset: 0x1CA3D50 VA: 0x181CA5750 Slot: 30
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x1CA59D0 Offset: 0x1CA3FD0 VA: 0x181CA59D0 Slot: 31
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x1CA5BA0 Offset: 0x1CA41A0 VA: 0x181CA5BA0 Slot: 32
	public override bool MoveToParent() { }

	// RVA: 0x1CA56C0 Offset: 0x1CA3CC0 VA: 0x181CA56C0 Slot: 33
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x1CA5FA0 Offset: 0x1CA45A0 VA: 0x181CA5FA0 Slot: 28
	public override object get_UnderlyingObject() { }

	// RVA: 0x1CA5670 Offset: 0x1CA3C70 VA: 0x181CA5670 Slot: 35
	public bool HasLineInfo() { }

	// RVA: 0x1CA5D30 Offset: 0x1CA4330 VA: 0x181CA5D30 Slot: 36
	public int get_LineNumber() { }

	// RVA: 0x1CA5DB0 Offset: 0x1CA43B0 VA: 0x181CA5DB0 Slot: 37
	public int get_LinePosition() { }

	// RVA: 0x1CA5660 Offset: 0x1CA3C60 VA: 0x181CA5660
	public int GetPositionHashCode() { }
}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNode // TypeDefIndex: 7197
{
	// Fields
	private XPathNodeInfoAtom _info; // 0x0
	private ushort _idxSibling; // 0x8
	private ushort _idxParent; // 0xA
	private ushort _idxSimilar; // 0xC
	private ushort _posOffset; // 0xE
	private uint _props; // 0x10
	private string _value; // 0x18

	// Properties
	public XPathNodeType NodeType { get; }
	public string Prefix { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public XPathDocument Document { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public int CollapsedLinePosition { get; }
	public XPathNodePageInfo PageInfo { get; }
	public bool IsXmlNamespaceNode { get; }
	public bool HasSibling { get; }
	public bool HasCollapsedText { get; }
	public bool IsText { get; }
	public bool HasNamespaceDecls { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1CA6AA0 Offset: 0x1CA50A0 VA: 0x181CA6AA0
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1CA6AD0 Offset: 0x1CA50D0 VA: 0x181CA6AD0
	public string get_Prefix() { }

	// RVA: 0x133DCF0 Offset: 0x133C2F0 VA: 0x18133DCF0
	public string get_LocalName() { }

	// RVA: 0x1CA6A80 Offset: 0x1CA5080 VA: 0x181CA6A80
	public string get_NamespaceUri() { }

	// RVA: 0x1CA6920 Offset: 0x1CA4F20 VA: 0x181CA6920
	public XPathDocument get_Document() { }

	// RVA: 0x1CA6A30 Offset: 0x1CA5030 VA: 0x181CA6A30
	public int get_LineNumber() { }

	// RVA: 0x1CA6A60 Offset: 0x1CA5060 VA: 0x181CA6A60
	public int get_LinePosition() { }

	// RVA: 0x1CA68F0 Offset: 0x1CA4EF0 VA: 0x181CA68F0
	public int get_CollapsedLinePosition() { }

	// RVA: 0x1CA6AB0 Offset: 0x1CA50B0 VA: 0x181CA6AB0
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x1CA6870 Offset: 0x1CA4E70 VA: 0x181CA6870
	public int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x1CA68B0 Offset: 0x1CA4EB0 VA: 0x181CA68B0
	public int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x1CA69C0 Offset: 0x1CA4FC0 VA: 0x181CA69C0
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x1CA6960 Offset: 0x1CA4F60 VA: 0x181CA6960
	public bool get_HasSibling() { }

	// RVA: 0x1CA6940 Offset: 0x1CA4F40 VA: 0x181CA6940
	public bool get_HasCollapsedText() { }

	// RVA: 0x1CA6970 Offset: 0x1CA4F70 VA: 0x181CA6970
	public bool get_IsText() { }

	// RVA: 0x1CA6950 Offset: 0x1CA4F50 VA: 0x181CA6950
	public bool get_HasNamespaceDecls() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Value() { }
}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNodeRef // TypeDefIndex: 7198
{
	// Fields
	private XPathNode[] _page; // 0x0
	private int _idx; // 0x8

	// Properties
	public XPathNode[] Page { get; }
	public int Index { get; }

	// Methods

	// RVA: 0x970F90 Offset: 0x96F590 VA: 0x180970F90
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public XPathNode[] get_Page() { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public int get_Index() { }

	// RVA: 0x1CA6830 Offset: 0x1CA4E30 VA: 0x181CA6830 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper // TypeDefIndex: 7199
{
	// Methods

	// RVA: 0x1CA63C0 Offset: 0x1CA49C0 VA: 0x181CA63C0
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x1CA6280 Offset: 0x1CA4880 VA: 0x181CA6280
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x1CA6580 Offset: 0x1CA4B80 VA: 0x181CA6580
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x1CA6450 Offset: 0x1CA4A50 VA: 0x181CA6450
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1CA6620 Offset: 0x1CA4C20 VA: 0x181CA6620
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x1CA6490 Offset: 0x1CA4A90 VA: 0x181CA6490
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }
}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodePageInfo // TypeDefIndex: 7200
{
	// Fields
	private int _pageNum; // 0x10
	private int _nodeCount; // 0x14
	private XPathNode[] _pageNext; // 0x18

	// Properties
	public int PageNumber { get; }
	public int NodeCount { get; }
	public XPathNode[] NextPage { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_PageNumber() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_NodeCount() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public XPathNode[] get_NextPage() { }
}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodeInfoAtom // TypeDefIndex: 7201
{
	// Fields
	private string _localName; // 0x10
	private string _namespaceUri; // 0x18
	private string _prefix; // 0x20
	private XPathNode[] _pageParent; // 0x28
	private XPathNode[] _pageSibling; // 0x30
	private XPathDocument _doc; // 0x38
	private int _lineNumBase; // 0x40
	private int _linePosBase; // 0x44
	private XPathNodePageInfo _pageInfo; // 0x48

	// Properties
	public XPathNodePageInfo PageInfo { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public string Prefix { get; }
	public XPathNode[] SiblingPage { get; }
	public XPathNode[] ParentPage { get; }
	public XPathDocument Document { get; }
	public int LineNumberBase { get; }
	public int LinePositionBase { get; }

	// Methods

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_LocalName() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_NamespaceUri() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Prefix() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public XPathDocument get_Document() { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	public int get_LineNumberBase() { }

	// RVA: 0x15EEFB0 Offset: 0x15ED5B0 VA: 0x1815EEFB0
	public int get_LinePositionBase() { }
}

