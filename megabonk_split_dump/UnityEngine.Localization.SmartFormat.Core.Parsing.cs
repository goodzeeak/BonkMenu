// Namespace: UnityEngine.Localization.SmartFormat.Core.Parsing
public class Format : FormatItem // TypeDefIndex: 11923
{
	// Fields
	public Placeholder parent; // 0x40
	[CompilerGenerated]
	private readonly List<FormatItem> <Items>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <HasNested>k__BackingField; // 0x50
	private List<Format.SplitList> m_Splits; // 0x58
	private char splitCacheChar; // 0x60
	private IList<Format> splitCache; // 0x68

	// Properties
	public List<FormatItem> Items { get; }
	public bool HasNested { get; set; }

	// Methods

	// RVA: 0x1EE9AC0 Offset: 0x1EE80C0 VA: 0x181EE9AC0
	public void ReleaseToPool() { }

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public List<FormatItem> get_Items() { }

	[CompilerGenerated]
	// RVA: 0x95D0B0 Offset: 0x95B6B0 VA: 0x18095D0B0
	public bool get_HasNested() { }

	[CompilerGenerated]
	// RVA: 0x1031CD0 Offset: 0x10302D0 VA: 0x181031CD0
	public void set_HasNested(bool value) { }

	// RVA: 0x1EEA2E0 Offset: 0x1EE88E0 VA: 0x181EEA2E0
	public Format Substring(int startIndex) { }

	// RVA: 0x1EE9F40 Offset: 0x1EE8540 VA: 0x181EE9F40
	public Format Substring(int startIndex, int length) { }

	// RVA: 0x1EE98E0 Offset: 0x1EE7EE0 VA: 0x181EE98E0
	public int IndexOf(char search) { }

	// RVA: 0x1EE98F0 Offset: 0x1EE7EF0 VA: 0x181EE98F0
	public int IndexOf(char search, int startIndex) { }

	// RVA: 0x1EE9580 Offset: 0x1EE7B80 VA: 0x181EE9580
	private List<int> FindAll(char search) { }

	// RVA: 0x1EE9590 Offset: 0x1EE7B90 VA: 0x181EE9590
	private List<int> FindAll(char search, int maxCount) { }

	// RVA: 0x1EE9EF0 Offset: 0x1EE84F0 VA: 0x181EE9EF0
	public IList<Format> Split(char search) { }

	// RVA: 0x1EE9DE0 Offset: 0x1EE83E0 VA: 0x181EE9DE0
	public IList<Format> Split(char search, int maxCount) { }

	// RVA: 0x1EE9670 Offset: 0x1EE7C70 VA: 0x181EE9670
	public string GetLiteralText() { }

	// RVA: 0x1EEA300 Offset: 0x1EE8900 VA: 0x181EEA300 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EEA570 Offset: 0x1EE8B70 VA: 0x181EEA570
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Parsing
public abstract class FormatItem // TypeDefIndex: 11926
{
	// Fields
	public string baseString; // 0x10
	public int endIndex; // 0x18
	protected SmartSettings SmartSettings; // 0x20
	public int startIndex; // 0x28
	protected string m_RawText; // 0x30
	[CompilerGenerated]
	private FormatItem <Parent>k__BackingField; // 0x38

	// Properties
	public FormatItem Parent { get; set; }
	public string RawText { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public FormatItem get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	private void set_Parent(FormatItem value) { }

	// RVA: 0x1EE9340 Offset: 0x1EE7940 VA: 0x181EE9340
	public void Init(SmartSettings smartSettings, FormatItem parent, int startIndex) { }

	// RVA: 0x1EE9250 Offset: 0x1EE7850 VA: 0x181EE9250
	public void Init(SmartSettings smartSettings, FormatItem parent, int startIndex, int endIndex) { }

	// RVA: 0x1EE92D0 Offset: 0x1EE78D0 VA: 0x181EE92D0
	public void Init(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex) { }

	// RVA: 0x1EE91F0 Offset: 0x1EE77F0 VA: 0x181EE91F0 Slot: 4
	public virtual void Clear() { }

	// RVA: 0x1EE9530 Offset: 0x1EE7B30 VA: 0x181EE9530
	public string get_RawText() { }

	// RVA: 0x1EE93D0 Offset: 0x1EE79D0 VA: 0x181EE93D0
	public IEnumerable<char> ToEnumerable() { }

	// RVA: 0x1EE9460 Offset: 0x1EE7A60 VA: 0x181EE9460 Slot: 3
	public override string ToString() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Parsing
public class LiteralText : FormatItem // TypeDefIndex: 11927
{
	// Methods

	// RVA: 0x1EED080 Offset: 0x1EEB680 VA: 0x181EED080 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EECD30 Offset: 0x1EEB330 VA: 0x181EECD30
	private string ConvertCharacterLiteralsToUnicode() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Parsing
[Serializable]
public class Parser // TypeDefIndex: 11933
{
	// Fields
	[SerializeField]
	private char m_OpeningBrace; // 0x10
	[SerializeField]
	private char m_ClosingBrace; // 0x12
	[SerializeReference]
	[HideInInspector]
	private SmartSettings m_Settings; // 0x18
	[Tooltip("If false, only digits are allowed as selectors. If true, selectors can be alpha-numeric. This allows optimized alpha-character detection. Specify any additional selector chars in AllowedSelectorChars.")]
	[SerializeField]
	private bool m_AlphanumericSelectors; // 0x20
	[Tooltip("A list of allowable selector characters, to support additional selector syntaxes such as math. Digits are always included, and letters can be included with AlphanumericSelectors.")]
	[SerializeField]
	private string m_AllowedSelectorChars; // 0x28
	[Tooltip("A list of characters that come between selectors. This can be "." for dot-notation, "[]" for arrays, or even math symbols. By default, there are no operators.")]
	[SerializeField]
	private string m_Operators; // 0x30
	[Tooltip("If false, double-curly braces are escaped. If true, the AlternativeEscapeChar is used for escaping braces.")]
	[SerializeField]
	private bool m_AlternativeEscaping; // 0x38
	[Tooltip("If AlternativeEscaping is true, then this character is used to escape curly braces.")]
	[SerializeField]
	private char m_AlternativeEscapeChar; // 0x3A
	[Tooltip("The character literal escape character e.g. for 	 (TAB) and others. This is kind of overlapping functionality with `UseAlternativeEscapeChar` Note: In a future release escape characters for placeholders  and character literals should become the same.")]
	[SerializeField]
	internal const char m_CharLiteralEscapeChar = '\x5c';
	private static Parser.ParsingErrorText s_ParsingErrorText; // 0x0
	[CompilerGenerated]
	private EventHandler<ParsingErrorEventArgs> OnParsingFailure; // 0x40

	// Properties
	public SmartSettings Settings { get; set; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public SmartSettings get_Settings() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Settings(SmartSettings value) { }

	[CompilerGenerated]
	// RVA: 0x1EF4FA0 Offset: 0x1EF35A0 VA: 0x181EF4FA0
	public void add_OnParsingFailure(EventHandler<ParsingErrorEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1EF5050 Offset: 0x1EF3650 VA: 0x181EF5050
	public void remove_OnParsingFailure(EventHandler<ParsingErrorEventArgs> value) { }

	// RVA: 0x1EF4F00 Offset: 0x1EF3500 VA: 0x181EF4F00
	public void .ctor(SmartSettings settings) { }

	// RVA: 0x50E160 Offset: 0x50C760 VA: 0x18050E160
	public void AddAlphanumericSelectors() { }

	// RVA: 0x1EF3430 Offset: 0x1EF1A30 VA: 0x181EF3430
	public void AddAdditionalSelectorChars(string chars) { }

	// RVA: 0x1EF3500 Offset: 0x1EF1B00 VA: 0x181EF3500
	public void AddOperators(string chars) { }

	// RVA: 0x1EF4EE0 Offset: 0x1EF34E0 VA: 0x181EF4EE0
	public void UseAlternativeEscapeChar(char alternativeEscapeChar = '\x5c') { }

	// RVA: 0x1EF4EF0 Offset: 0x1EF34F0 VA: 0x181EF4EF0
	public void UseBraceEscaping() { }

	// RVA: 0x1EF4ED0 Offset: 0x1EF34D0 VA: 0x181EF4ED0
	public void UseAlternativeBraces(char opening, char closing) { }

	// RVA: 0x1EF3D70 Offset: 0x1EF2370 VA: 0x181EF3D70
	public Format ParseFormat(string format, IList<string> formatterExtensionNames) { }

	// RVA: 0x1EF3730 Offset: 0x1EF1D30 VA: 0x181EF3730
	private Format HandleParsingErrors(ParsingErrors parsingErrors, Format currentResult) { }

	// RVA: 0x1EF35D0 Offset: 0x1EF1BD0 VA: 0x181EF35D0
	private static bool FormatterNameExists(string name, IList<string> formatterExtensionNames) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Parsing
public class ParsingErrorEventArgs : EventArgs // TypeDefIndex: 11934
{
	// Fields
	[CompilerGenerated]
	private ParsingErrors <Errors>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ThrowsException>k__BackingField; // 0x18

	// Properties
	public ParsingErrors Errors { get; set; }
	public bool ThrowsException { get; set; }

	// Methods

	// RVA: 0x1EF5100 Offset: 0x1EF3700 VA: 0x181EF5100
	internal void .ctor(ParsingErrors errors, bool throwsException) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ParsingErrors get_Errors() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_Errors(ParsingErrors value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_ThrowsException() { }

	[CompilerGenerated]
	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	internal void set_ThrowsException(bool value) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Parsing
public class ParsingErrors : Exception // TypeDefIndex: 11937
{
	// Fields
	private Format result; // 0x90
	[CompilerGenerated]
	private readonly List<ParsingErrors.ParsingIssue> <Issues>k__BackingField; // 0x98

	// Properties
	public List<ParsingErrors.ParsingIssue> Issues { get; }
	public bool HasIssues { get; }
	public string MessageShort { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	public void Init(Format result) { }

	// RVA: 0x1EF5420 Offset: 0x1EF3A20 VA: 0x181EF5420
	public void Clear() { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public List<ParsingErrors.ParsingIssue> get_Issues() { }

	// RVA: 0x1EF5530 Offset: 0x1EF3B30 VA: 0x181EF5530
	public bool get_HasIssues() { }

	// RVA: 0x1EF5580 Offset: 0x1EF3B80 VA: 0x181EF5580
	public string get_MessageShort() { }

	// RVA: 0x1EF57A0 Offset: 0x1EF3DA0 VA: 0x181EF57A0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1EF5310 Offset: 0x1EF3910 VA: 0x181EF5310
	public void AddIssue(string issue, int startIndex, int endIndex) { }

	// RVA: 0x1EF5490 Offset: 0x1EF3A90 VA: 0x181EF5490
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Parsing
public class Placeholder : FormatItem // TypeDefIndex: 11938
{
	// Fields
	[CompilerGenerated]
	private int <NestedDepth>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly List<Selector> <Selectors>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <Alignment>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <FormatterName>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <FormatterOptions>k__BackingField; // 0x60
	[CompilerGenerated]
	private Format <Format>k__BackingField; // 0x68

	// Properties
	public int NestedDepth { get; set; }
	public List<Selector> Selectors { get; }
	public int Alignment { get; set; }
	public string FormatterName { get; set; }
	public string FormatterOptions { get; set; }
	public Format Format { get; set; }

	// Methods

	// RVA: 0x1EF7330 Offset: 0x1EF5930 VA: 0x181EF7330
	public void ReleaseToPool() { }

	[CompilerGenerated]
	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	public int get_NestedDepth() { }

	[CompilerGenerated]
	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	public void set_NestedDepth(int value) { }

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public List<Selector> get_Selectors() { }

	[CompilerGenerated]
	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public int get_Alignment() { }

	[CompilerGenerated]
	// RVA: 0x3AA880 Offset: 0x3A8E80 VA: 0x1803AA880
	public void set_Alignment(int value) { }

	[CompilerGenerated]
	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public string get_FormatterName() { }

	[CompilerGenerated]
	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_FormatterName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public string get_FormatterOptions() { }

	[CompilerGenerated]
	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_FormatterOptions(string value) { }

	[CompilerGenerated]
	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public Format get_Format() { }

	[CompilerGenerated]
	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void set_Format(Format value) { }

	// RVA: 0x1EF7500 Offset: 0x1EF5B00 VA: 0x181EF7500 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EF7960 Offset: 0x1EF5F60 VA: 0x181EF7960
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Parsing
public class Selector : FormatItem // TypeDefIndex: 11939
{
	// Fields
	private string m_Operator; // 0x40
	internal int operatorStart; // 0x48
	[CompilerGenerated]
	private int <SelectorIndex>k__BackingField; // 0x4C

	// Properties
	public int SelectorIndex { get; set; }
	public string Operator { get; }

	// Methods

	// RVA: 0x1EF9370 Offset: 0x1EF7970 VA: 0x181EF9370 Slot: 4
	public override void Clear() { }

	[CompilerGenerated]
	// RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	public int get_SelectorIndex() { }

	[CompilerGenerated]
	// RVA: 0x9CC920 Offset: 0x9CAF20 VA: 0x1809CC920
	internal void set_SelectorIndex(int value) { }

	// RVA: 0x1EF93E0 Offset: 0x1EF79E0 VA: 0x181EF93E0
	public string get_Operator() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

