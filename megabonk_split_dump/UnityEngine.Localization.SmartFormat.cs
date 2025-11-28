// Namespace: UnityEngine.Localization.SmartFormat
public class FormattingErrorEventArgs : EventArgs // TypeDefIndex: 11819
{
	// Fields
	[CompilerGenerated]
	private string <Placeholder>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <ErrorIndex>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IgnoreError>k__BackingField; // 0x1C

	// Properties
	public string Placeholder { get; set; }
	public int ErrorIndex { get; set; }
	public bool IgnoreError { get; set; }

	// Methods

	// RVA: 0x1EC8DE0 Offset: 0x1EC73E0 VA: 0x181EC8DE0
	internal void .ctor(string rawText, int errorIndex, bool ignoreError) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Placeholder() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_Placeholder(string value) { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_ErrorIndex() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	internal void set_ErrorIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x39A900 Offset: 0x398F00 VA: 0x18039A900
	public bool get_IgnoreError() { }

	[CompilerGenerated]
	// RVA: 0x39A910 Offset: 0x398F10 VA: 0x18039A910
	internal void set_IgnoreError(bool value) { }
}

// Namespace: UnityEngine.Localization.SmartFormat
public static class Smart // TypeDefIndex: 11820
{
	// Fields
	[CompilerGenerated]
	private static SmartFormatter <Default>k__BackingField; // 0x0

	// Properties
	public static SmartFormatter Default { get; set; }

	// Methods

	// RVA: 0x1ED8EA0 Offset: 0x1ED74A0 VA: 0x181ED8EA0
	public static string Format(string format, object[] args) { }

	// RVA: 0x1ED9340 Offset: 0x1ED7940 VA: 0x181ED9340
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x1ED9080 Offset: 0x1ED7680 VA: 0x181ED9080
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1ED9210 Offset: 0x1ED7810 VA: 0x181ED9210
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x1ED8F50 Offset: 0x1ED7550 VA: 0x181ED8F50
	public static string Format(string format, object arg0) { }

	[CompilerGenerated]
	// RVA: 0x1ED9460 Offset: 0x1ED7A60 VA: 0x181ED9460
	public static SmartFormatter get_Default() { }

	[CompilerGenerated]
	// RVA: 0x1ED94B0 Offset: 0x1ED7AB0 VA: 0x181ED94B0
	public static void set_Default(SmartFormatter value) { }

	// RVA: 0x1ED8690 Offset: 0x1ED6C90 VA: 0x181ED8690
	public static SmartFormatter CreateDefaultSmartFormat() { }

	// RVA: 0x1ED9400 Offset: 0x1ED7A00 VA: 0x181ED9400
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat
[Extension]
public static class SmartExtensions // TypeDefIndex: 11821
{
	// Methods

	[Extension]
	// RVA: 0x1ED5D30 Offset: 0x1ED4330 VA: 0x181ED5D30
	public static void AppendSmart(StringBuilder sb, string format, object[] args) { }

	[Extension]
	// RVA: 0x1ED5C30 Offset: 0x1ED4230 VA: 0x181ED5C30
	public static void AppendLineSmart(StringBuilder sb, string format, object[] args) { }

	[Extension]
	// RVA: 0x1ED6060 Offset: 0x1ED4660 VA: 0x181ED6060
	public static void WriteSmart(TextWriter writer, string format, object[] args) { }

	[Extension]
	// RVA: 0x1ED5F50 Offset: 0x1ED4550 VA: 0x181ED5F50
	public static void WriteLineSmart(TextWriter writer, string format, object[] args) { }

	[Extension]
	// RVA: 0x1ED5EF0 Offset: 0x1ED44F0 VA: 0x181ED5EF0
	public static string FormatSmart(string format, object[] args) { }

	[Extension]
	// RVA: 0x1ED5E20 Offset: 0x1ED4420 VA: 0x181ED5E20
	public static string FormatSmart(string format, ref FormatCache cache, object[] args) { }
}

// Namespace: UnityEngine.Localization.SmartFormat
[Serializable]
public class SmartFormatter : ISerializationCallbackReceiver // TypeDefIndex: 11822
{
	// Fields
	[SerializeReference]
	private SmartSettings m_Settings; // 0x10
	[SerializeReference]
	private Parser m_Parser; // 0x18
	[SerializeReference]
	private List<ISource> m_Sources; // 0x20
	[SerializeReference]
	private List<IFormatter> m_Formatters; // 0x28
	private List<string> m_NotEmptyFormatterExtensionNames; // 0x30
	private static readonly object[] k_Empty; // 0x0
	[CompilerGenerated]
	private EventHandler<FormattingErrorEventArgs> OnFormattingFailure; // 0x38

	// Properties
	public List<ISource> SourceExtensions { get; }
	public List<IFormatter> FormatterExtensions { get; }
	public Parser Parser { get; set; }
	public SmartSettings Settings { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1ED8530 Offset: 0x1ED6B30 VA: 0x181ED8530
	public void add_OnFormattingFailure(EventHandler<FormattingErrorEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1ED85E0 Offset: 0x1ED6BE0 VA: 0x181ED85E0
	public void remove_OnFormattingFailure(EventHandler<FormattingErrorEventArgs> value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<ISource> get_SourceExtensions() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public List<IFormatter> get_FormatterExtensions() { }

	// RVA: 0x1ED83F0 Offset: 0x1ED69F0 VA: 0x181ED83F0
	public void .ctor() { }

	// RVA: 0x1ED7E60 Offset: 0x1ED6460 VA: 0x181ED7E60
	public List<string> GetNotEmptyFormatterExtensionNames() { }

	// RVA: 0x1ED6670 Offset: 0x1ED4C70 VA: 0x181ED6670
	public void AddExtensions(ISource[] sourceExtensions) { }

	// RVA: 0x1ED66D0 Offset: 0x1ED4CD0 VA: 0x181ED66D0
	public void AddExtensions(IFormatter[] formatterExtensions) { }

	// RVA: -1 Offset: -1
	public T GetSourceExtension<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79DD60 Offset: 0x79C360 VA: 0x18079DD60
	|-SmartFormatter.GetSourceExtension<object>
	*/

	// RVA: -1 Offset: -1
	public T GetFormatterExtension<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79DD10 Offset: 0x79C310 VA: 0x18079DD10
	|-SmartFormatter.GetFormatterExtension<object>
	*/

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Parser get_Parser() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Parser(Parser value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public SmartSettings get_Settings() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Settings(SmartSettings value) { }

	// RVA: 0x1ED7E40 Offset: 0x1ED6440 VA: 0x181ED7E40
	public string Format(string format, object[] args) { }

	// RVA: 0x1ED7510 Offset: 0x1ED5B10 VA: 0x181ED7510
	public string Format(IList<object> args, string format) { }

	// RVA: 0x1ED7530 Offset: 0x1ED5B30 VA: 0x181ED7530
	public string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x1ED7980 Offset: 0x1ED5F80 VA: 0x181ED7980
	public string Format(IFormatProvider provider, IList<object> args, string format) { }

	// RVA: 0x1ED6E20 Offset: 0x1ED5420 VA: 0x181ED6E20
	public void FormatInto(IOutput output, string format, object[] args) { }

	// RVA: 0x1ED7160 Offset: 0x1ED5760 VA: 0x181ED7160
	public string FormatWithCache(ref FormatCache cache, string format, IList<object> args) { }

	// RVA: 0x1ED7180 Offset: 0x1ED5780 VA: 0x181ED7180
	public string FormatWithCache(ref FormatCache cache, string format, IFormatProvider formatProvider, IList<object> args) { }

	// RVA: 0x1ED6FA0 Offset: 0x1ED55A0 VA: 0x181ED6FA0
	public void FormatWithCacheInto(ref FormatCache cache, IOutput output, string format, object[] args) { }

	// RVA: 0x1ED7CC0 Offset: 0x1ED62C0 VA: 0x181ED7CC0
	private void Format(FormatDetails formatDetails, Format format, object current) { }

	// RVA: 0x1ED7550 Offset: 0x1ED5B50 VA: 0x181ED7550 Slot: 6
	public virtual void Format(FormattingInfo formattingInfo) { }

	// RVA: 0x1ED6B70 Offset: 0x1ED5170 VA: 0x181ED6B70
	private void FormatError(FormatItem errorItem, Exception innerException, int startIndex, FormattingInfo formattingInfo) { }

	// RVA: 0x1ED6740 Offset: 0x1ED4D40 VA: 0x181ED6740
	private void CheckForExtensions() { }

	// RVA: 0x1ED68D0 Offset: 0x1ED4ED0 VA: 0x181ED68D0
	private void EvaluateSelectors(FormattingInfo formattingInfo) { }

	// RVA: 0x1ED8240 Offset: 0x1ED6840 VA: 0x181ED8240
	private bool InvokeSourceExtensions(FormattingInfo formattingInfo) { }

	// RVA: 0x1ED6840 Offset: 0x1ED4E40 VA: 0x181ED6840
	private void EvaluateFormatters(FormattingInfo formattingInfo) { }

	// RVA: 0x1ED8080 Offset: 0x1ED6680 VA: 0x181ED8080
	private bool InvokeFormatterExtensions(FormattingInfo formattingInfo) { }

	// RVA: 0x139C480 Offset: 0x139AA80 VA: 0x18139C480 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x139C480 Offset: 0x139AA80 VA: 0x18139C480 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1ED8380 Offset: 0x1ED6980 VA: 0x181ED8380
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat
internal class SmartFormatterLiteralCharacterExtractor : SmartFormatter // TypeDefIndex: 11823
{
	// Fields
	private IEnumerable<char> m_Characters; // 0x40

	// Methods

	// RVA: 0x1ED65A0 Offset: 0x1ED4BA0 VA: 0x181ED65A0
	public void .ctor(SmartFormatter parent) { }

	// RVA: 0x1ED6150 Offset: 0x1ED4750 VA: 0x181ED6150
	public IEnumerable<char> ExtractLiteralsCharacters(string value) { }

	// RVA: 0x1ED61C0 Offset: 0x1ED47C0 VA: 0x181ED61C0 Slot: 6
	public override void Format(FormattingInfo formattingInfo) { }
}

// Namespace: UnityEngine.Localization.SmartFormat
internal static class FormatCachePool // TypeDefIndex: 11825
{
	// Fields
	internal static readonly ObjectPool<FormatCache> s_Pool; // 0x0

	// Methods

	// RVA: 0x1EC72C0 Offset: 0x1EC58C0 VA: 0x181EC72C0
	public static FormatCache Get(Format format) { }

	// RVA: 0x1EC7360 Offset: 0x1EC5960 VA: 0x181EC7360
	public static PooledObject<FormatCache> Get(Format format, out FormatCache value) { }

	// RVA: 0x1EC7420 Offset: 0x1EC5A20 VA: 0x181EC7420
	public static void Release(FormatCache toRelease) { }

	// RVA: 0x1EC74A0 Offset: 0x1EC5AA0 VA: 0x181EC74A0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat
internal static class FormatDetailsPool // TypeDefIndex: 11827
{
	// Fields
	internal static readonly ObjectPool<FormatDetails> s_Pool; // 0x0

	// Methods

	// RVA: 0x1EC7790 Offset: 0x1EC5D90 VA: 0x181EC7790
	public static FormatDetails Get(SmartFormatter formatter, Format originalFormat, IList<object> originalArgs, FormatCache formatCache, IFormatProvider provider, IOutput output) { }

	// RVA: 0x1EC7680 Offset: 0x1EC5C80 VA: 0x181EC7680
	public static PooledObject<FormatDetails> Get(SmartFormatter formatter, Format originalFormat, object[] originalArgs, FormatCache formatCache, IFormatProvider provider, IOutput output, out FormatDetails value) { }

	// RVA: 0x1EC7880 Offset: 0x1EC5E80 VA: 0x181EC7880
	public static void Release(FormatDetails toRelease) { }

	// RVA: 0x1EC7900 Offset: 0x1EC5F00 VA: 0x181EC7900
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat
internal static class FormatItemPool // TypeDefIndex: 11829
{
	// Fields
	internal static readonly ObjectPool<LiteralText> s_LiteralTextPool; // 0x0
	internal static readonly ObjectPool<Format> s_FormatPool; // 0x8
	internal static readonly ObjectPool<Placeholder> s_PlaceholderPool; // 0x10
	internal static readonly ObjectPool<Selector> s_SelectorPool; // 0x18

	// Methods

	// RVA: 0x1EC7DF0 Offset: 0x1EC63F0 VA: 0x181EC7DF0
	public static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, int startIndex) { }

	// RVA: 0x1EC7EB0 Offset: 0x1EC64B0 VA: 0x181EC7EB0
	public static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, int startIndex, int endIndex) { }

	// RVA: 0x1EC7F90 Offset: 0x1EC6590 VA: 0x181EC7F90
	public static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex) { }

	// RVA: 0x1EC7B70 Offset: 0x1EC6170 VA: 0x181EC7B70
	public static Format GetFormat(SmartSettings smartSettings, string baseString) { }

	// RVA: 0x1EC7D10 Offset: 0x1EC6310 VA: 0x181EC7D10
	public static Format GetFormat(SmartSettings smartSettings, string baseString, int startIndex, int endIndex) { }

	// RVA: 0x1EC7A90 Offset: 0x1EC6090 VA: 0x181EC7A90
	public static Format GetFormat(SmartSettings smartSettings, string baseString, int startIndex, int endIndex, bool nested) { }

	// RVA: 0x1EC7C40 Offset: 0x1EC6240 VA: 0x181EC7C40
	public static Format GetFormat(SmartSettings smartSettings, Placeholder parent, int startIndex) { }

	// RVA: 0x1EC81A0 Offset: 0x1EC67A0 VA: 0x181EC81A0
	public static Placeholder GetPlaceholder(SmartSettings smartSettings, Format parent, int startIndex, int nestedDepth) { }

	// RVA: 0x1EC8070 Offset: 0x1EC6670 VA: 0x181EC8070
	public static Placeholder GetPlaceholder(SmartSettings smartSettings, Format parent, int startIndex, int nestedDepth, Format itemFormat, int endIndex) { }

	// RVA: 0x1EC82B0 Offset: 0x1EC68B0 VA: 0x181EC82B0
	public static Selector GetSelector(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex, int operatorStart, int selectorIndex) { }

	// RVA: 0x1EC8420 Offset: 0x1EC6A20 VA: 0x181EC8420
	public static void ReleaseLiteralText(LiteralText literal) { }

	// RVA: 0x1EC83A0 Offset: 0x1EC69A0 VA: 0x181EC83A0
	public static void ReleaseFormat(Format format) { }

	// RVA: 0x1EC84A0 Offset: 0x1EC6AA0 VA: 0x181EC84A0
	public static void ReleasePlaceholder(Placeholder placeholder) { }

	// RVA: 0x1EC8520 Offset: 0x1EC6B20 VA: 0x181EC8520
	public static void ReleaseSelector(Selector selector) { }

	// RVA: 0x1EC85A0 Offset: 0x1EC6BA0 VA: 0x181EC85A0
	public static void Release(FormatItem format) { }

	// RVA: 0x1EC88E0 Offset: 0x1EC6EE0 VA: 0x181EC88E0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat
internal static class FormattingInfoPool // TypeDefIndex: 11831
{
	// Fields
	internal static readonly ObjectPool<FormattingInfo> s_Pool; // 0x0

	// Methods

	// RVA: 0x1EC9030 Offset: 0x1EC7630 VA: 0x181EC9030
	public static FormattingInfo Get(FormatDetails formatDetails, Format format, object currentValue) { }

	// RVA: 0x1EC8F50 Offset: 0x1EC7550 VA: 0x181EC8F50
	public static FormattingInfo Get(FormattingInfo parent, FormatDetails formatDetails, Format format, object currentValue) { }

	// RVA: 0x1EC8E70 Offset: 0x1EC7470 VA: 0x181EC8E70
	public static FormattingInfo Get(FormattingInfo parent, FormatDetails formatDetails, Placeholder placeholder, object currentValue) { }

	// RVA: 0x1EC90F0 Offset: 0x1EC76F0 VA: 0x181EC90F0
	public static void Release(FormattingInfo toRelease) { }

	// RVA: 0x1EC9170 Offset: 0x1EC7770 VA: 0x181EC9170
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat
internal static class ParsingErrorsPool // TypeDefIndex: 11833
{
	// Fields
	internal static readonly ObjectPool<ParsingErrors> s_Pool; // 0x0

	// Methods

	// RVA: 0x1ECEBF0 Offset: 0x1ECD1F0 VA: 0x181ECEBF0
	public static ParsingErrors Get(Format format) { }

	// RVA: 0x1ECECA0 Offset: 0x1ECD2A0 VA: 0x181ECECA0
	public static void Release(ParsingErrors toRelease) { }

	// RVA: 0x1ECED20 Offset: 0x1ECD320 VA: 0x181ECED20
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat
internal static class SplitListPool // TypeDefIndex: 11835
{
	// Fields
	internal static readonly ObjectPool<Format.SplitList> s_Pool; // 0x0

	// Methods

	// RVA: 0x1ED9520 Offset: 0x1ED7B20 VA: 0x181ED9520
	public static Format.SplitList Get(Format format, List<int> splits) { }

	// RVA: 0x1ED95D0 Offset: 0x1ED7BD0 VA: 0x181ED95D0
	public static void Release(Format.SplitList toRelease) { }

	// RVA: 0x1ED9650 Offset: 0x1ED7C50 VA: 0x181ED9650
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat
internal static class StringOutputPool // TypeDefIndex: 11837
{
	// Fields
	internal static readonly ObjectPool<StringOutput> s_Pool; // 0x0

	// Methods

	// RVA: 0x1ED9C10 Offset: 0x1ED8210 VA: 0x181ED9C10
	public static StringOutput Get(int capacity) { }

	// RVA: 0x1ED9CB0 Offset: 0x1ED82B0 VA: 0x181ED9CB0
	public static PooledObject<StringOutput> Get(int capacity, out StringOutput value) { }

	// RVA: 0x1ED9D70 Offset: 0x1ED8370 VA: 0x181ED9D70
	public static void Release(StringOutput toRelease) { }

	// RVA: 0x1ED9DF0 Offset: 0x1ED83F0 VA: 0x181ED9DF0
	private static void .cctor() { }
}

