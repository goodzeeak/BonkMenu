// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class Expression // TypeDefIndex: 4549
{
	// Fields
	public ExpressionType type; // 0x10
	public ExpressionMultiplier multiplier; // 0x14
	public DataType dataType; // 0x20
	public ExpressionCombinator combinator; // 0x24
	public Expression[] subExpressions; // 0x28
	public string keyword; // 0x30

	// Methods

	// RVA: 0x253C920 Offset: 0x253AF20 VA: 0x18253C920
	public void .ctor(ExpressionType type) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum ExpressionType // TypeDefIndex: 4550
{
	// Fields
	public int value__; // 0x0
	public const ExpressionType Unknown = 0;
	public const ExpressionType Data = 1;
	public const ExpressionType Keyword = 2;
	public const ExpressionType Combinator = 3;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum DataType // TypeDefIndex: 4551
{
	// Fields
	public int value__; // 0x0
	public const DataType None = 0;
	public const DataType Number = 1;
	public const DataType Integer = 2;
	public const DataType Length = 3;
	public const DataType Percentage = 4;
	public const DataType Color = 5;
	public const DataType Resource = 6;
	public const DataType Url = 7;
	public const DataType Time = 8;
	public const DataType Angle = 9;
	public const DataType CustomIdent = 10;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum ExpressionCombinator // TypeDefIndex: 4552
{
	// Fields
	public int value__; // 0x0
	public const ExpressionCombinator None = 0;
	public const ExpressionCombinator Or = 1;
	public const ExpressionCombinator OrOr = 2;
	public const ExpressionCombinator AndAnd = 3;
	public const ExpressionCombinator Juxtaposition = 4;
	public const ExpressionCombinator Group = 5;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum ExpressionMultiplierType // TypeDefIndex: 4553
{
	// Fields
	public int value__; // 0x0
	public const ExpressionMultiplierType None = 0;
	public const ExpressionMultiplierType ZeroOrMore = 1;
	public const ExpressionMultiplierType OneOrMore = 2;
	public const ExpressionMultiplierType ZeroOrOne = 3;
	public const ExpressionMultiplierType Ranges = 4;
	public const ExpressionMultiplierType OneOrMoreComma = 5;
	public const ExpressionMultiplierType GroupAtLeastOne = 6;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal struct ExpressionMultiplier // TypeDefIndex: 4554
{
	// Fields
	public const int Infinity = 100;
	private ExpressionMultiplierType m_Type; // 0x0
	public int min; // 0x4
	public int max; // 0x8

	// Properties
	public ExpressionMultiplierType type { get; set; }

	// Methods

	// RVA: 0x9C1450 Offset: 0x9BFA50 VA: 0x1809C1450
	public ExpressionMultiplierType get_type() { }

	// RVA: 0x253C910 Offset: 0x253AF10 VA: 0x18253C910
	public void set_type(ExpressionMultiplierType value) { }

	// RVA: 0x253C8F0 Offset: 0x253AEF0 VA: 0x18253C8F0
	public void .ctor(ExpressionMultiplierType type = 0) { }

	// RVA: 0x253C870 Offset: 0x253AE70 VA: 0x18253C870
	private void SetType(ExpressionMultiplierType value) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class StyleSyntaxParser // TypeDefIndex: 4555
{
	// Fields
	private List<Expression> m_ProcessExpressionList; // 0x10
	private Stack<Expression> m_ExpressionStack; // 0x18
	private Stack<ExpressionCombinator> m_CombinatorStack; // 0x20
	private Dictionary<string, Expression> m_ParsedExpressionCache; // 0x28

	// Methods

	// RVA: 0x2548BE0 Offset: 0x25471E0 VA: 0x182548BE0
	public Expression Parse(string syntax) { }

	// RVA: 0x2547A20 Offset: 0x2546020 VA: 0x182547A20
	private Expression ParseExpression(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2548D90 Offset: 0x2547390 VA: 0x182548D90
	private void ProcessCombinatorStack() { }

	// RVA: 0x2548A40 Offset: 0x2547040 VA: 0x182548A40
	private Expression ParseTerm(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x25471D0 Offset: 0x25457D0 VA: 0x1825471D0
	private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2547CC0 Offset: 0x25462C0 VA: 0x182547CC0
	private Expression ParseGroup(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2547430 Offset: 0x2545A30 VA: 0x182547430
	private Expression ParseDataType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2548290 Offset: 0x2546890 VA: 0x182548290
	private Expression ParseNonTerminalValue(string syntax) { }

	// RVA: 0x2548440 Offset: 0x2546A40 VA: 0x182548440
	private Expression ParseProperty(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2547FB0 Offset: 0x25465B0 VA: 0x182547FB0
	private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier) { }

	// RVA: 0x25488D0 Offset: 0x2546ED0 VA: 0x1825488D0
	private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max) { }

	// RVA: 0x2547100 Offset: 0x2545700 VA: 0x182547100
	private static void EatSpace(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x2547180 Offset: 0x2545780 VA: 0x182547180
	private static bool IsExpressionEnd(StyleSyntaxToken token) { }

	// RVA: 0x2547160 Offset: 0x2545760 VA: 0x182547160
	private static bool IsCombinator(StyleSyntaxToken token) { }

	// RVA: 0x25471A0 Offset: 0x25457A0 VA: 0x1825471A0
	private static bool IsMultiplier(StyleSyntaxToken token) { }

	// RVA: 0x2549100 Offset: 0x2547700 VA: 0x182549100
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum StyleSyntaxTokenType // TypeDefIndex: 4556
{
	// Fields
	public int value__; // 0x0
	public const StyleSyntaxTokenType Unknown = 0;
	public const StyleSyntaxTokenType String = 1;
	public const StyleSyntaxTokenType Number = 2;
	public const StyleSyntaxTokenType Space = 3;
	public const StyleSyntaxTokenType SingleBar = 4;
	public const StyleSyntaxTokenType DoubleBar = 5;
	public const StyleSyntaxTokenType DoubleAmpersand = 6;
	public const StyleSyntaxTokenType Comma = 7;
	public const StyleSyntaxTokenType SingleQuote = 8;
	public const StyleSyntaxTokenType Asterisk = 9;
	public const StyleSyntaxTokenType Plus = 10;
	public const StyleSyntaxTokenType QuestionMark = 11;
	public const StyleSyntaxTokenType HashMark = 12;
	public const StyleSyntaxTokenType ExclamationPoint = 13;
	public const StyleSyntaxTokenType OpenBracket = 14;
	public const StyleSyntaxTokenType CloseBracket = 15;
	public const StyleSyntaxTokenType OpenBrace = 16;
	public const StyleSyntaxTokenType CloseBrace = 17;
	public const StyleSyntaxTokenType LessThan = 18;
	public const StyleSyntaxTokenType GreaterThan = 19;
	public const StyleSyntaxTokenType End = 20;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal struct StyleSyntaxToken // TypeDefIndex: 4557
{
	// Fields
	public StyleSyntaxTokenType type; // 0x0
	public string text; // 0x8
	public int number; // 0x10

	// Methods

	// RVA: 0x2549250 Offset: 0x2547850 VA: 0x182549250
	public void .ctor(StyleSyntaxTokenType t) { }

	// RVA: 0x2549280 Offset: 0x2547880 VA: 0x182549280
	public void .ctor(StyleSyntaxTokenType type, string text) { }

	// RVA: 0x25492B0 Offset: 0x25478B0 VA: 0x1825492B0
	public void .ctor(StyleSyntaxTokenType type, int number) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class StyleSyntaxTokenizer // TypeDefIndex: 4558
{
	// Fields
	private List<StyleSyntaxToken> m_Tokens; // 0x10
	private int m_CurrentTokenIndex; // 0x18

	// Properties
	public StyleSyntaxToken current { get; }

	// Methods

	// RVA: 0x254A4A0 Offset: 0x2548AA0 VA: 0x18254A4A0
	public StyleSyntaxToken get_current() { }

	// RVA: 0x25494C0 Offset: 0x2547AC0 VA: 0x1825494C0
	public StyleSyntaxToken MoveNext() { }

	// RVA: 0x2549580 Offset: 0x2547B80 VA: 0x182549580
	public StyleSyntaxToken PeekNext() { }

	// RVA: 0x2549640 Offset: 0x2547C40 VA: 0x182549640
	public void Tokenize(string syntax) { }

	// RVA: 0x2549360 Offset: 0x2547960 VA: 0x182549360
	private static bool IsNextCharacter(string s, int index, char c) { }

	// RVA: 0x25493B0 Offset: 0x25479B0 VA: 0x1825493B0
	private static bool IsNextLetterOrDash(string s, int index) { }

	// RVA: 0x2549460 Offset: 0x2547A60 VA: 0x182549460
	private static bool IsNextNumber(string s, int index) { }

	// RVA: 0x25492F0 Offset: 0x25478F0 VA: 0x1825492F0
	private static int GlobCharacter(string s, int index, char c) { }

	// RVA: 0x254A420 Offset: 0x2548A20 VA: 0x18254A420
	public void .ctor() { }
}

