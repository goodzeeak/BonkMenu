// Namespace: MS.Internal.Xml.XPath
internal abstract class AstNode // TypeDefIndex: 7180
{
	// Properties
	public abstract AstNode.AstType Type { get; }
	public abstract XPathResultType ReturnType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract AstNode.AstType get_Type();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XPathResultType get_ReturnType();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Axis : AstNode // TypeDefIndex: 7182
{
	// Fields
	private Axis.AxisType _axisType; // 0x10
	private AstNode _input; // 0x18
	private string _prefix; // 0x20
	private string _name; // 0x28
	private XPathNodeType _nodeType; // 0x30
	protected bool abbrAxis; // 0x34
	private string _urn; // 0x38

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; set; }
	public string Prefix { get; }
	public string Name { get; }
	public XPathNodeType NodeType { get; }
	public Axis.AxisType TypeOfAxis { get; }
	public bool AbbrAxis { get; }
	public string Urn { get; set; }

	// Methods

	// RVA: 0x1CA3150 Offset: 0x1CA1750 VA: 0x181CA3150
	public void .ctor(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x1CA31F0 Offset: 0x1CA17F0 VA: 0x181CA31F0
	public void .ctor(Axis.AxisType axisType, AstNode input) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public AstNode get_Input() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Input(AstNode value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Prefix() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Name() { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public XPathNodeType get_NodeType() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public Axis.AxisType get_TypeOfAxis() { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_AbbrAxis() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_Urn() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_Urn(string value) { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Filter : AstNode // TypeDefIndex: 7183
{
	// Fields
	private AstNode _input; // 0x10
	private AstNode _condition; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Function : AstNode // TypeDefIndex: 7185
{
	// Fields
	private Function.FunctionType _functionType; // 0x10
	private List<AstNode> _argumentList; // 0x18
	private string _name; // 0x20
	private string _prefix; // 0x28
	internal static XPathResultType[] ReturnTypes; // 0x0

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x1CA3500 Offset: 0x1CA1B00 VA: 0x181CA3500
	public void .ctor(Function.FunctionType ftype, List<AstNode> argumentList) { }

	// RVA: 0x1CA3590 Offset: 0x1CA1B90 VA: 0x181CA3590
	public void .ctor(string prefix, string name, List<AstNode> argumentList) { }

	// RVA: 0x1CA33F0 Offset: 0x1CA19F0 VA: 0x181CA33F0
	public void .ctor(Function.FunctionType ftype, AstNode arg) { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1CA3650 Offset: 0x1CA1C50 VA: 0x181CA3650 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1CA3360 Offset: 0x1CA1960 VA: 0x181CA3360
	private static void .cctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Group : AstNode // TypeDefIndex: 7186
{
	// Fields
	private AstNode _groupNode; // 0x10

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(AstNode groupNode) { }

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Operand : AstNode // TypeDefIndex: 7187
{
	// Fields
	private XPathResultType _type; // 0x10
	private object _val; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x1CA36D0 Offset: 0x1CA1CD0 VA: 0x181CA36D0
	public void .ctor(string val) { }

	// RVA: 0x1CA3710 Offset: 0x1CA1D10 VA: 0x181CA3710
	public void .ctor(double val) { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Operator : AstNode // TypeDefIndex: 7189
{
	// Fields
	private static Operator.Op[] s_invertOp; // 0x0
	private Operator.Op _opType; // 0x10
	private AstNode _opnd1; // 0x18
	private AstNode _opnd2; // 0x20

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0xE91640 Offset: 0xE8FC40 VA: 0x180E91640
	public void .ctor(Operator.Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1CA3800 Offset: 0x1CA1E00 VA: 0x181CA3800 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1CA3770 Offset: 0x1CA1D70 VA: 0x181CA3770
	private static void .cctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Root : AstNode // TypeDefIndex: 7190
{
	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x45C3F0 Offset: 0x45A9F0 VA: 0x18045C3F0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Variable : AstNode // TypeDefIndex: 7191
{
	// Fields
	private string _localname; // 0x10
	private string _prefix; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(string name, string prefix) { }

	// RVA: 0x4565D0 Offset: 0x454BD0 VA: 0x1804565D0 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class XPathParser // TypeDefIndex: 7193
{
	// Fields
	private XPathScanner _scanner; // 0x10
	private int _parseDepth; // 0x18
	private static readonly XPathResultType[] s_temparray1; // 0x0
	private static readonly XPathResultType[] s_temparray2; // 0x8
	private static readonly XPathResultType[] s_temparray3; // 0x10
	private static readonly XPathResultType[] s_temparray4; // 0x18
	private static readonly XPathResultType[] s_temparray5; // 0x20
	private static readonly XPathResultType[] s_temparray6; // 0x28
	private static readonly XPathResultType[] s_temparray7; // 0x30
	private static readonly XPathResultType[] s_temparray8; // 0x38
	private static readonly XPathResultType[] s_temparray9; // 0x40
	private static Dictionary<string, XPathParser.ParamInfo> s_functionTable; // 0x48
	private static Dictionary<string, Axis.AxisType> s_AxesTable; // 0x50

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x1CAA480 Offset: 0x1CA8A80 VA: 0x181CAA480
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	// RVA: 0x1CA8170 Offset: 0x1CA6770 VA: 0x181CA8170
	private AstNode ParseExpression(AstNode qyInput) { }

	// RVA: 0x1CA9360 Offset: 0x1CA7960 VA: 0x181CA9360
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x1CA7EF0 Offset: 0x1CA64F0 VA: 0x181CA7EF0
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x1CA8050 Offset: 0x1CA6650 VA: 0x181CA8050
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x1CA9CA0 Offset: 0x1CA82A0 VA: 0x181CA9CA0
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x1CA7DD0 Offset: 0x1CA63D0 VA: 0x181CA7DD0
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x1CA8D80 Offset: 0x1CA7380 VA: 0x181CA8D80
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x1CAA140 Offset: 0x1CA8740 VA: 0x181CAA140
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x1CAA280 Offset: 0x1CA8880 VA: 0x181CAA280
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x1CA7C20 Offset: 0x1CA6220 VA: 0x181CA7C20
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x1CA94C0 Offset: 0x1CA7AC0 VA: 0x181CA94C0
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x1CA8310 Offset: 0x1CA6910 VA: 0x181CA8310
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x1CA97D0 Offset: 0x1CA7DD0 VA: 0x181CA97D0
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x1CA83E0 Offset: 0x1CA69E0 VA: 0x181CA83E0
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x1CA9DD0 Offset: 0x1CA83D0 VA: 0x181CA9DD0
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x1CA7D80 Offset: 0x1CA6380 VA: 0x181CA7D80
	private static bool IsStep(XPathScanner.LexKind lexKind) { }

	// RVA: 0x1CA9EB0 Offset: 0x1CA84B0 VA: 0x181CA9EB0
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x1CA8F40 Offset: 0x1CA7540 VA: 0x181CA8F40
	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x1CA7CF0 Offset: 0x1CA62F0 VA: 0x181CA7CF0
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x1CA9960 Offset: 0x1CA7F60 VA: 0x181CA9960
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x1CA8540 Offset: 0x1CA6B40 VA: 0x181CA8540
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x1CA6B60 Offset: 0x1CA5160 VA: 0x181CA6B60
	private void CheckToken(XPathScanner.LexKind t) { }

	// RVA: 0x1CAA630 Offset: 0x1CA8C30 VA: 0x181CAA630
	private void PassToken(XPathScanner.LexKind t) { }

	// RVA: 0x1CA7DB0 Offset: 0x1CA63B0 VA: 0x181CA7DB0
	private void NextLex() { }

	// RVA: 0x1CAA660 Offset: 0x1CA8C60 VA: 0x181CAA660
	private bool TestOp(string op) { }

	// RVA: 0x1CA6AF0 Offset: 0x1CA50F0 VA: 0x181CA6AF0
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x1CA6E60 Offset: 0x1CA5460 VA: 0x181CA6E60
	private static Dictionary<string, XPathParser.ParamInfo> CreateFunctionTable() { }

	// RVA: 0x1CA6BE0 Offset: 0x1CA51E0 VA: 0x181CA6BE0
	private static Dictionary<string, Axis.AxisType> CreateAxesTable() { }

	// RVA: 0x1CA7B30 Offset: 0x1CA6130 VA: 0x181CA7B30
	private Axis.AxisType GetAxis() { }

	// RVA: 0x1CAA6B0 Offset: 0x1CA8CB0 VA: 0x181CAA6B0
	private static void .cctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathScanner // TypeDefIndex: 7195
{
	// Fields
	private string _xpathExpr; // 0x10
	private int _xpathExprIndex; // 0x18
	private XPathScanner.LexKind _kind; // 0x1C
	private char _currentChar; // 0x20
	private string _name; // 0x28
	private string _prefix; // 0x30
	private string _stringValue; // 0x38
	private double _numberValue; // 0x40
	private bool _canBeFunction; // 0x48
	private XmlCharType _xmlCharType; // 0x50

	// Properties
	public string SourceText { get; }
	private char CurrentChar { get; }
	public XPathScanner.LexKind Kind { get; }
	public string Name { get; }
	public string Prefix { get; }
	public string StringValue { get; }
	public double NumberValue { get; }
	public bool CanBeFunction { get; }

	// Methods

	// RVA: 0x1CAB770 Offset: 0x1CA9D70 VA: 0x181CAB770
	public void .ctor(string xpathExpr) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_SourceText() { }

	// RVA: 0x15B2F60 Offset: 0x15B1560 VA: 0x1815B2F60
	private char get_CurrentChar() { }

	// RVA: 0x1CAAAB0 Offset: 0x1CA90B0 VA: 0x181CAAAB0
	private bool NextChar() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public XPathScanner.LexKind get_Kind() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Name() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_Prefix() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_StringValue() { }

	// RVA: 0xAC52B0 Offset: 0xAC38B0 VA: 0x180AC52B0
	public double get_NumberValue() { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	public bool get_CanBeFunction() { }

	// RVA: 0x1CAB700 Offset: 0x1CA9D00 VA: 0x181CAB700
	private void SkipSpace() { }

	// RVA: 0x1CAAB10 Offset: 0x1CA9110 VA: 0x181CAAB10
	public bool NextLex() { }

	// RVA: 0x1CAB440 Offset: 0x1CA9A40 VA: 0x181CAB440
	private double ScanNumber() { }

	// RVA: 0x1CAB290 Offset: 0x1CA9890 VA: 0x181CAB290
	private double ScanFraction() { }

	// RVA: 0x1CAB5C0 Offset: 0x1CA9BC0 VA: 0x181CAB5C0
	private string ScanString() { }

	// RVA: 0x1CAB380 Offset: 0x1CA9980 VA: 0x181CAB380
	private string ScanName() { }
}

