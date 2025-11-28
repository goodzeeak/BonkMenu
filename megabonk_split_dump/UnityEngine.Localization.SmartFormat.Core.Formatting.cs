// Namespace: UnityEngine.Localization.SmartFormat.Core.Formatting
public class FormatCache // TypeDefIndex: 11943
{
	// Fields
	[CompilerGenerated]
	private Format <Format>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Dictionary<string, object> <CachedObjects>k__BackingField; // 0x18
	public LocalizationTable Table; // 0x20
	[CompilerGenerated]
	private IVariableGroup <LocalVariables>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly List<IVariableValueChanged> <VariableTriggers>k__BackingField; // 0x30

	// Properties
	public Format Format { get; set; }
	public Dictionary<string, object> CachedObjects { get; }
	public IVariableGroup LocalVariables { get; set; }
	public List<IVariableValueChanged> VariableTriggers { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Format get_Format() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Format(Format value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Dictionary<string, object> get_CachedObjects() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public IVariableGroup get_LocalVariables() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_LocalVariables(IVariableGroup value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public List<IVariableValueChanged> get_VariableTriggers() { }

	// RVA: 0x1EE9010 Offset: 0x1EE7610 VA: 0x181EE9010
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Formatting
public class FormatDetails // TypeDefIndex: 11944
{
	// Fields
	[CompilerGenerated]
	private SmartFormatter <Formatter>k__BackingField; // 0x10
	[CompilerGenerated]
	private Format <OriginalFormat>k__BackingField; // 0x18
	[CompilerGenerated]
	private IList<object> <OriginalArgs>k__BackingField; // 0x20
	[CompilerGenerated]
	private FormatCache <FormatCache>k__BackingField; // 0x28
	[CompilerGenerated]
	private IFormatProvider <Provider>k__BackingField; // 0x30
	[CompilerGenerated]
	private IOutput <Output>k__BackingField; // 0x38
	[CompilerGenerated]
	private FormattingException <FormattingException>k__BackingField; // 0x40

	// Properties
	public SmartFormatter Formatter { get; set; }
	public Format OriginalFormat { get; set; }
	public IList<object> OriginalArgs { get; set; }
	public FormatCache FormatCache { get; set; }
	public IFormatProvider Provider { get; set; }
	public IOutput Output { get; set; }
	public FormattingException FormattingException { get; set; }
	public SmartSettings Settings { get; }

	// Methods

	// RVA: 0x1EE9160 Offset: 0x1EE7760 VA: 0x181EE9160
	public void Init(SmartFormatter formatter, Format originalFormat, IList<object> originalArgs, FormatCache formatCache, IFormatProvider provider, IOutput output) { }

	// RVA: 0x1EE90D0 Offset: 0x1EE76D0 VA: 0x181EE90D0
	internal void Clear() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public SmartFormatter get_Formatter() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_Formatter(SmartFormatter value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Format get_OriginalFormat() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_OriginalFormat(Format value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public IList<object> get_OriginalArgs() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_OriginalArgs(IList<object> value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public FormatCache get_FormatCache() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	private void set_FormatCache(FormatCache value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public IFormatProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_Provider(IFormatProvider value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public IOutput get_Output() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	private void set_Output(IOutput value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public FormattingException get_FormattingException() { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_FormattingException(FormattingException value) { }

	// RVA: 0xBE5930 Offset: 0xBE3F30 VA: 0x180BE5930
	public SmartSettings get_Settings() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Formatting
public class FormattingException : Exception // TypeDefIndex: 11945
{
	// Fields
	[CompilerGenerated]
	private readonly string <Format>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly FormatItem <ErrorItem>k__BackingField; // 0x98
	[CompilerGenerated]
	private readonly string <Issue>k__BackingField; // 0xA0
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; // 0xA8

	// Properties
	public string Format { get; }
	public FormatItem ErrorItem { get; }
	public string Issue { get; }
	public int Index { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1EEA680 Offset: 0x1EE8C80 VA: 0x181EEA680
	public void .ctor(FormatItem errorItem, Exception formatException, int index) { }

	// RVA: 0x1EEA760 Offset: 0x1EE8D60 VA: 0x181EEA760
	public void .ctor(FormatItem errorItem, string issue, int index) { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public string get_Format() { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public FormatItem get_ErrorItem() { }

	[CompilerGenerated]
	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public string get_Issue() { }

	[CompilerGenerated]
	// RVA: 0x1C59660 Offset: 0x1C57C60 VA: 0x181C59660
	public int get_Index() { }

	// RVA: 0x1EEA830 Offset: 0x1EE8E30 VA: 0x181EEA830 Slot: 5
	public override string get_Message() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Core.Formatting
public class FormattingInfo : IFormattingInfo, ISelectorInfo // TypeDefIndex: 11946
{
	// Fields
	[CompilerGenerated]
	private FormattingInfo <Parent>k__BackingField; // 0x10
	[CompilerGenerated]
	private Selector <Selector>k__BackingField; // 0x18
	[CompilerGenerated]
	private FormatDetails <FormatDetails>k__BackingField; // 0x20
	[CompilerGenerated]
	private object <CurrentValue>k__BackingField; // 0x28
	[CompilerGenerated]
	private Placeholder <Placeholder>k__BackingField; // 0x30
	[CompilerGenerated]
	private Format <Format>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly List<FormattingInfo> <Children>k__BackingField; // 0x40
	[CompilerGenerated]
	private object <Result>k__BackingField; // 0x48

	// Properties
	public FormattingInfo Parent { get; set; }
	public Selector Selector { get; set; }
	public FormatDetails FormatDetails { get; set; }
	public object CurrentValue { get; set; }
	public Placeholder Placeholder { get; set; }
	public int Alignment { get; }
	public string FormatterOptions { get; }
	public Format Format { get; set; }
	public List<FormattingInfo> Children { get; }
	public string SelectorText { get; }
	public int SelectorIndex { get; }
	public string SelectorOperator { get; }
	public object Result { get; set; }

	// Methods

	// RVA: 0x1EEACF0 Offset: 0x1EE92F0 VA: 0x181EEACF0
	public void Init(FormatDetails formatDetails, Format format, object currentValue) { }

	// RVA: 0x1EEAE00 Offset: 0x1EE9400 VA: 0x181EEAE00
	public void Init(FormattingInfo parent, FormatDetails formatDetails, Format format, object currentValue) { }

	// RVA: 0x1EEAD70 Offset: 0x1EE9370 VA: 0x181EEAD70
	public void Init(FormattingInfo parent, FormatDetails formatDetails, Placeholder placeholder, object currentValue) { }

	// RVA: 0x1EEAE70 Offset: 0x1EE9470 VA: 0x181EEAE70
	public void ReleaseToPool() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public FormattingInfo get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_Parent(FormattingInfo value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Selector get_Selector() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Selector(Selector value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 21
	public FormatDetails get_FormatDetails() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_FormatDetails(FormatDetails value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 14
	public object get_CurrentValue() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_CurrentValue(object value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 20
	public Placeholder get_Placeholder() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_Placeholder(Placeholder value) { }

	// RVA: 0x1CF2CE0 Offset: 0x1CF12E0 VA: 0x181CF2CE0 Slot: 7
	public int get_Alignment() { }

	// RVA: 0x1EEB3D0 Offset: 0x1EE99D0 VA: 0x181EEB3D0 Slot: 8
	public string get_FormatterOptions() { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 5
	public Format get_Format() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	private void set_Format(Format value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public List<FormattingInfo> get_Children() { }

	// RVA: 0x1EEB170 Offset: 0x1EE9770 VA: 0x181EEB170 Slot: 10
	public void Write(string text) { }

	// RVA: 0x1EEB250 Offset: 0x1EE9850 VA: 0x181EEB250 Slot: 11
	public void Write(string text, int startIndex, int length) { }

	// RVA: 0x1EEB040 Offset: 0x1EE9640 VA: 0x181EEB040 Slot: 12
	public void Write(Format format, object value) { }

	// RVA: 0x1EEAC50 Offset: 0x1EE9250 VA: 0x181EEAC50 Slot: 13
	public FormattingException FormattingException(string issue, FormatItem problemItem, int startIndex = -1) { }

	// RVA: 0x1EEB470 Offset: 0x1EE9A70 VA: 0x181EEB470 Slot: 15
	public string get_SelectorText() { }

	// RVA: 0x1EEB3F0 Offset: 0x1EE99F0 VA: 0x181EEB3F0 Slot: 16
	public int get_SelectorIndex() { }

	// RVA: 0x1EEB410 Offset: 0x1EE9A10 VA: 0x181EEB410 Slot: 17
	public string get_SelectorOperator() { }

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 18
	public object get_Result() { }

	[CompilerGenerated]
	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810 Slot: 19
	public void set_Result(object value) { }

	// RVA: 0x1EEAA30 Offset: 0x1EE9030 VA: 0x181EEAA30
	private FormattingInfo CreateChild(Format format, object currentValue) { }

	// RVA: 0x1EEAB40 Offset: 0x1EE9140 VA: 0x181EEAB40
	public FormattingInfo CreateChild(Placeholder placeholder) { }

	// RVA: 0x1EEB350 Offset: 0x1EE9950 VA: 0x181EEB350
	public void .ctor() { }
}

