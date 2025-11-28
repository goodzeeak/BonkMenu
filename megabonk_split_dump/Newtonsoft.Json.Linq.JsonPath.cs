// Namespace: Newtonsoft.Json.Linq.JsonPath
internal class ArrayIndexFilter : PathFilter // TypeDefIndex: 8510
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <Index>k__BackingField; // 0x10

	// Properties
	public Nullable<int> Index { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Nullable<int> get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	public void set_Index(Nullable<int> value) { }

	[NullableContext(1)]
	[IteratorStateMachine(typeof(ArrayIndexFilter.<ExecuteFilter>d__4))]
	// RVA: 0x166E660 Offset: 0x166CC60 VA: 0x18166E660 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class ArrayMultipleIndexFilter : PathFilter // TypeDefIndex: 8512
{
	// Fields
	internal List<int> Indexes; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(List<int> indexes) { }

	[IteratorStateMachine(typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__2))]
	// RVA: 0x166E710 Offset: 0x166CD10 VA: 0x18166E710 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
internal class ArraySliceFilter : PathFilter // TypeDefIndex: 8514
{
	// Fields
	[CompilerGenerated]
	private Nullable<int> <Start>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<int> <End>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<int> <Step>k__BackingField; // 0x20

	// Properties
	public Nullable<int> Start { get; set; }
	public Nullable<int> End { get; set; }
	public Nullable<int> Step { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Nullable<int> get_Start() { }

	[CompilerGenerated]
	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	public void set_Start(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Nullable<int> get_End() { }

	[CompilerGenerated]
	// RVA: 0x14A5B00 Offset: 0x14A4100 VA: 0x1814A5B00
	public void set_End(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Nullable<int> get_Step() { }

	[CompilerGenerated]
	// RVA: 0x163E100 Offset: 0x163C700 VA: 0x18163E100
	public void set_Step(Nullable<int> value) { }

	[NullableContext(1)]
	[IteratorStateMachine(typeof(ArraySliceFilter.<ExecuteFilter>d__12))]
	// RVA: 0x166E7C0 Offset: 0x166CDC0 VA: 0x18166E7C0 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	// RVA: 0x166E870 Offset: 0x166CE70 VA: 0x18166E870
	private bool IsValid(int index, int stopIndex, bool positiveStep) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(2)]
[Nullable(0)]
internal class FieldFilter : PathFilter // TypeDefIndex: 8516
{
	// Fields
	internal string Name; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(string name) { }

	[NullableContext(1)]
	[IteratorStateMachine(typeof(FieldFilter.<ExecuteFilter>d__2))]
	// RVA: 0x1675360 Offset: 0x1673960 VA: 0x181675360 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class FieldMultipleFilter : PathFilter // TypeDefIndex: 8519
{
	// Fields
	internal List<string> Names; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(List<string> names) { }

	[IteratorStateMachine(typeof(FieldMultipleFilter.<ExecuteFilter>d__2))]
	// RVA: 0x1675410 Offset: 0x1673A10 VA: 0x181675410 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class JPath // TypeDefIndex: 8520
{
	// Fields
	private static readonly char[] FloatCharacters; // 0x0
	private readonly string _expression; // 0x10
	[CompilerGenerated]
	private readonly List<PathFilter> <Filters>k__BackingField; // 0x18
	private int _currentIndex; // 0x20

	// Properties
	public List<PathFilter> Filters { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public List<PathFilter> get_Filters() { }

	// RVA: 0x1679260 Offset: 0x1677860 VA: 0x181679260
	public void .ctor(string expression) { }

	// RVA: 0x16771B0 Offset: 0x16757B0 VA: 0x1816771B0
	private void ParseMain() { }

	// RVA: 0x1677940 Offset: 0x1675F40 VA: 0x181677940
	private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query) { }

	// RVA: 0x1675E60 Offset: 0x1674460 VA: 0x181675E60
	private static PathFilter CreatePathFilter(string member, bool scan) { }

	// RVA: 0x1677040 Offset: 0x1675640 VA: 0x181677040
	private PathFilter ParseIndexer(char indexerOpenChar, bool scan) { }

	// RVA: 0x1676380 Offset: 0x1674980 VA: 0x181676380
	private PathFilter ParseArrayIndexer(char indexerCloseChar) { }

	// RVA: 0x1675FA0 Offset: 0x16745A0 VA: 0x181675FA0
	private void EatWhitespace() { }

	// RVA: 0x1677E60 Offset: 0x1676460 VA: 0x181677E60
	private PathFilter ParseQuery(char indexerCloseChar, bool scan) { }

	// RVA: 0x1678B80 Offset: 0x1677180 VA: 0x181678B80
	private bool TryParseExpression(out List<PathFilter> expressionPath) { }

	// RVA: 0x1675EE0 Offset: 0x16744E0 VA: 0x181675EE0
	private JsonException CreateUnexpectedCharacterException() { }

	// RVA: 0x16784D0 Offset: 0x1676AD0 VA: 0x1816784D0
	private object ParseSide() { }

	// RVA: 0x1676C80 Offset: 0x1675280 VA: 0x181676C80
	private QueryExpression ParseExpression() { }

	[NullableContext(2)]
	// RVA: 0x1678D50 Offset: 0x1677350 VA: 0x181678D50
	private bool TryParseValue(out object value) { }

	// RVA: 0x1678740 Offset: 0x1676D40 VA: 0x181678740
	private string ReadQuotedString() { }

	// RVA: 0x1678A00 Offset: 0x1677000 VA: 0x181678A00
	private string ReadRegexString() { }

	// RVA: 0x16762E0 Offset: 0x16748E0 VA: 0x1816762E0
	private bool Match(string s) { }

	// RVA: 0x1677390 Offset: 0x1675990 VA: 0x181677390
	private QueryOperator ParseOperator() { }

	// RVA: 0x1678150 Offset: 0x1676750 VA: 0x181678150
	private PathFilter ParseQuotedField(char indexerCloseChar, bool scan) { }

	// RVA: 0x1676000 Offset: 0x1674600 VA: 0x181676000
	private void EnsureLength(string message) { }

	// RVA: 0x1676250 Offset: 0x1674850 VA: 0x181676250
	internal IEnumerable<JToken> Evaluate(JToken root, JToken t, JsonSelectSettings settings) { }

	// RVA: 0x1676070 Offset: 0x1674670 VA: 0x181676070
	internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken root, JToken t, JsonSelectSettings settings) { }

	// RVA: 0x16791D0 Offset: 0x16777D0 VA: 0x1816791D0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(2)]
[Nullable(0)]
internal abstract class PathFilter // TypeDefIndex: 8521
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings);

	// RVA: 0x1681010 Offset: 0x167F610 VA: 0x181681010
	protected static JToken GetTokenIndex(JToken t, JsonSelectSettings settings, int index) { }

	// RVA: 0x1680F40 Offset: 0x167F540 VA: 0x181680F40
	protected static JToken GetNextScanValue(JToken originalParent, JToken container, JToken value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
internal enum QueryOperator // TypeDefIndex: 8522
{
	// Fields
	public int value__; // 0x0
	public const QueryOperator None = 0;
	public const QueryOperator Equals = 1;
	public const QueryOperator NotEquals = 2;
	public const QueryOperator Exists = 3;
	public const QueryOperator LessThan = 4;
	public const QueryOperator LessThanOrEquals = 5;
	public const QueryOperator GreaterThan = 6;
	public const QueryOperator GreaterThanOrEquals = 7;
	public const QueryOperator And = 8;
	public const QueryOperator Or = 9;
	public const QueryOperator RegexEquals = 10;
	public const QueryOperator StrictEquals = 11;
	public const QueryOperator StrictNotEquals = 12;
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal abstract class QueryExpression // TypeDefIndex: 8523
{
	// Fields
	internal QueryOperator Operator; // 0x10

	// Methods

	// RVA: 0x3757E0 Offset: 0x373DE0 VA: 0x1803757E0
	public void .ctor(QueryOperator operator) { }

	// RVA: 0x1681370 Offset: 0x167F970 VA: 0x181681370
	public bool IsMatch(JToken root, JToken t) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsMatch(JToken root, JToken t, JsonSelectSettings settings);
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class CompositeExpression : QueryExpression // TypeDefIndex: 8524
{
	// Fields
	[CompilerGenerated]
	private List<QueryExpression> <Expressions>k__BackingField; // 0x18

	// Properties
	public List<QueryExpression> Expressions { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public List<QueryExpression> get_Expressions() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Expressions(List<QueryExpression> value) { }

	// RVA: 0x1670F40 Offset: 0x166F540 VA: 0x181670F40
	public void .ctor(QueryOperator operator) { }

	// RVA: 0x1670CA0 Offset: 0x166F2A0 VA: 0x181670CA0 Slot: 4
	public override bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class BooleanQueryExpression : QueryExpression // TypeDefIndex: 8525
{
	// Fields
	public readonly object Left; // 0x18
	[Nullable(2)]
	public readonly object Right; // 0x20

	// Methods

	// RVA: 0xE91640 Offset: 0xE8FC40 VA: 0x180E91640
	public void .ctor(QueryOperator operator, object left, object right) { }

	// RVA: 0x166FB60 Offset: 0x166E160 VA: 0x18166FB60
	private IEnumerable<JToken> GetResult(JToken root, JToken t, object o) { }

	// RVA: 0x166FD50 Offset: 0x166E350 VA: 0x18166FD50 Slot: 4
	public override bool IsMatch(JToken root, JToken t, JsonSelectSettings settings) { }

	// RVA: 0x1670200 Offset: 0x166E800 VA: 0x181670200
	private bool MatchTokens(JToken leftResult, JToken rightResult, JsonSelectSettings settings) { }

	// RVA: 0x16707C0 Offset: 0x166EDC0 VA: 0x1816707C0
	private static bool RegexEquals(JValue input, JValue pattern, JsonSelectSettings settings) { }

	// RVA: 0x166F620 Offset: 0x166DC20 VA: 0x18166F620
	internal static bool EqualsWithStringCoercion(JValue value, JValue queryValue) { }

	// RVA: 0x166F4C0 Offset: 0x166DAC0 VA: 0x18166F4C0
	internal static bool EqualsWithStrictMatch(JValue value, JValue queryValue) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class QueryFilter : PathFilter // TypeDefIndex: 8527
{
	// Fields
	internal QueryExpression Expression; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(QueryExpression expression) { }

	[IteratorStateMachine(typeof(QueryFilter.<ExecuteFilter>d__2))]
	// RVA: 0x16813A0 Offset: 0x167F9A0 VA: 0x1816813A0 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class QueryScanFilter : PathFilter // TypeDefIndex: 8529
{
	// Fields
	internal QueryExpression Expression; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(QueryExpression expression) { }

	[IteratorStateMachine(typeof(QueryScanFilter.<ExecuteFilter>d__2))]
	// RVA: 0x1681470 Offset: 0x167FA70 VA: 0x181681470 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class RootFilter : PathFilter // TypeDefIndex: 8530
{
	// Fields
	public static readonly RootFilter Instance; // 0x0

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x1682190 Offset: 0x1680790 VA: 0x181682190 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }

	// RVA: 0x1682230 Offset: 0x1680830 VA: 0x181682230
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(2)]
[Nullable(0)]
internal class ScanFilter : PathFilter // TypeDefIndex: 8532
{
	// Fields
	internal string Name; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(string name) { }

	[NullableContext(1)]
	[IteratorStateMachine(typeof(ScanFilter.<ExecuteFilter>d__2))]
	// RVA: 0x16822A0 Offset: 0x16808A0 VA: 0x1816822A0 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq.JsonPath
[NullableContext(1)]
[Nullable(0)]
internal class ScanMultipleFilter : PathFilter // TypeDefIndex: 8534
{
	// Fields
	private List<string> _names; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(List<string> names) { }

	[IteratorStateMachine(typeof(ScanMultipleFilter.<ExecuteFilter>d__2))]
	// RVA: 0x1682330 Offset: 0x1680930 VA: 0x181682330 Slot: 4
	public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings) { }
}

