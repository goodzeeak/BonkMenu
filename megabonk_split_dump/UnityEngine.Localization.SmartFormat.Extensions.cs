// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class ChooseFormatter : FormatterBase, IFormatterLiteralExtractor // TypeDefIndex: 11891
{
	// Fields
	[SerializeField]
	private char m_SplitChar; // 0x18

	// Properties
	public char SplitChar { get; set; }
	public override string[] DefaultNames { get; }

	// Methods

	// RVA: 0xA67330 Offset: 0xA65930 VA: 0x180A67330
	public char get_SplitChar() { }

	// RVA: 0x197EBC0 Offset: 0x197D1C0 VA: 0x18197EBC0
	public void set_SplitChar(char value) { }

	// RVA: 0x1EE6320 Offset: 0x1EE4920 VA: 0x181EE6320
	public void .ctor() { }

	// RVA: 0x1EE6370 Offset: 0x1EE4970 VA: 0x181EE6370 Slot: 9
	public override string[] get_DefaultNames() { }

	// RVA: 0x1EE5EC0 Offset: 0x1EE44C0 VA: 0x181EE5EC0 Slot: 10
	public override bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	// RVA: 0x1EE5B90 Offset: 0x1EE4190 VA: 0x181EE5B90
	private static Format DetermineChosenFormat(IFormattingInfo formattingInfo, IList<Format> choiceFormats, string[] chooseOptions) { }

	// RVA: 0x1EE6050 Offset: 0x1EE4650 VA: 0x181EE6050 Slot: 12
	public void WriteAllLiterals(IFormattingInfo formattingInfo) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class ConditionalFormatter : FormatterBase, IFormatterLiteralExtractor // TypeDefIndex: 11892
{
	// Fields
	private static readonly Regex _complexConditionPattern; // 0x0

	// Properties
	public override string[] DefaultNames { get; }

	// Methods

	// RVA: 0x1EE8190 Offset: 0x1EE6790 VA: 0x181EE8190
	public void .ctor() { }

	// RVA: 0x1EE81D0 Offset: 0x1EE67D0 VA: 0x181EE81D0 Slot: 9
	public override string[] get_DefaultNames() { }

	// RVA: 0x1EE73F0 Offset: 0x1EE59F0 VA: 0x181EE73F0 Slot: 10
	public override bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	// RVA: 0x1EE6DB0 Offset: 0x1EE53B0 VA: 0x181EE6DB0
	private static bool TryEvaluateCondition(Format parameter, Decimal value, out bool conditionResult, out Format outputItem) { }

	// RVA: 0x1EE7DE0 Offset: 0x1EE63E0 VA: 0x181EE7DE0 Slot: 12
	public void WriteAllLiterals(IFormattingInfo formattingInfo) { }

	// RVA: 0x1EE8100 Offset: 0x1EE6700 VA: 0x181EE8100
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class DefaultFormatter : FormatterBase // TypeDefIndex: 11893
{
	// Properties
	public override string[] DefaultNames { get; }

	// Methods

	// RVA: 0x1EE8190 Offset: 0x1EE6790 VA: 0x181EE8190
	public void .ctor() { }

	// RVA: 0x1EE8710 Offset: 0x1EE6D10 VA: 0x181EE8710 Slot: 9
	public override string[] get_DefaultNames() { }

	// RVA: 0x1EE8320 Offset: 0x1EE6920 VA: 0x181EE8320 Slot: 10
	public override bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class DefaultSource : ISource // TypeDefIndex: 11894
{
	// Methods

	// RVA: 0x1EE89F0 Offset: 0x1EE6FF0 VA: 0x181EE89F0
	public void .ctor(SmartFormatter formatter) { }

	// RVA: 0x1EE87E0 Offset: 0x1EE6DE0 VA: 0x181EE87E0 Slot: 4
	public bool TryEvaluateSelector(ISelectorInfo selectorInfo) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class DictionarySource : ISource // TypeDefIndex: 11896
{
	// Methods

	// RVA: 0x1EE8EF0 Offset: 0x1EE74F0 VA: 0x181EE8EF0
	public void .ctor(SmartFormatter formatter) { }

	// RVA: 0x1EE8A80 Offset: 0x1EE7080 VA: 0x181EE8A80 Slot: 4
	public bool TryEvaluateSelector(ISelectorInfo selectorInfo) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Obsolete("Please use PersistentVariablesSource instead (UnityUpgradable) -> PersistentVariablesSource")]
[Serializable]
public class GlobalVariablesSource : PersistentVariablesSource // TypeDefIndex: 11897
{
	// Methods

	// RVA: 0x1EEB590 Offset: 0x1EE9B90 VA: 0x181EEB590
	public void .ctor(SmartFormatter formatter) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class IsMatchFormatter : FormatterBase, IFormatterLiteralExtractor // TypeDefIndex: 11898
{
	// Fields
	[CompilerGenerated]
	private RegexOptions <RegexOptions>k__BackingField; // 0x18

	// Properties
	public override string[] DefaultNames { get; }
	public RegexOptions RegexOptions { get; set; }

	// Methods

	// RVA: 0x1EE8190 Offset: 0x1EE6790 VA: 0x181EE8190
	public void .ctor() { }

	// RVA: 0x1EEBAB0 Offset: 0x1EEA0B0 VA: 0x181EEBAB0 Slot: 9
	public override string[] get_DefaultNames() { }

	// RVA: 0x1EEB6D0 Offset: 0x1EE9CD0 VA: 0x181EEB6D0 Slot: 10
	public override bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	// RVA: 0x1EEB920 Offset: 0x1EE9F20 VA: 0x181EEB920 Slot: 12
	public void WriteAllLiterals(IFormattingInfo formattingInfo) { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public RegexOptions get_RegexOptions() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_RegexOptions(RegexOptions value) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class ListFormatter : FormatterBase, ISource, IFormatterLiteralExtractor // TypeDefIndex: 11899
{
	// Fields
	[SerializeReference]
	[HideInInspector]
	private SmartSettings m_SmartSettings; // 0x18
	[CompilerGenerated]
	private static int <CollectionIndex>k__BackingField; // 0x0

	// Properties
	public override string[] DefaultNames { get; }
	private static int CollectionIndex { get; set; }

	// Methods

	// RVA: 0x1EECB10 Offset: 0x1EEB110 VA: 0x181EECB10
	public void .ctor(SmartFormatter formatter) { }

	// RVA: 0x1EECC00 Offset: 0x1EEB200 VA: 0x181EECC00 Slot: 9
	public override string[] get_DefaultNames() { }

	// RVA: 0x1EEC450 Offset: 0x1EEAA50 VA: 0x181EEC450 Slot: 12
	public bool TryEvaluateSelector(ISelectorInfo selectorInfo) { }

	[CompilerGenerated]
	// RVA: 0x1EECBB0 Offset: 0x1EEB1B0 VA: 0x181EECBB0
	private static int get_CollectionIndex() { }

	[CompilerGenerated]
	// RVA: 0x1EECCD0 Offset: 0x1EEB2D0 VA: 0x181EECCD0
	private static void set_CollectionIndex(int value) { }

	// RVA: 0x1EEBB30 Offset: 0x1EEA130 VA: 0x181EEBB30 Slot: 10
	public override bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	// RVA: 0x1EEC6C0 Offset: 0x1EEACC0 VA: 0x181EEC6C0 Slot: 13
	public void WriteAllLiterals(IFormattingInfo formattingInfo) { }

	// RVA: 0x1EECAD0 Offset: 0x1EEB0D0 VA: 0x181EECAD0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[DefaultMember("Item")]
[Serializable]
public class PersistentVariablesSource : ISource, IDictionary<string, VariablesGroupAsset>, ICollection<KeyValuePair<string, VariablesGroupAsset>>, IEnumerable<KeyValuePair<string, VariablesGroupAsset>>, IEnumerable, ISerializationCallbackReceiver // TypeDefIndex: 11905
{
	// Fields
	[SerializeField]
	private List<PersistentVariablesSource.NameValuePair> m_Groups; // 0x10
	private Dictionary<string, PersistentVariablesSource.NameValuePair> m_GroupLookup; // 0x18
	internal static int s_IsUpdating; // 0x0
	[CompilerGenerated]
	private static Action EndUpdate; // 0x8

	// Properties
	public static bool IsUpdating { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	public ICollection<string> Keys { get; }
	public ICollection<VariablesGroupAsset> Values { get; }
	public VariablesGroupAsset Item { get; set; }

	// Methods

	// RVA: 0x1EF7010 Offset: 0x1EF5610 VA: 0x181EF7010
	public static bool get_IsUpdating() { }

	// RVA: 0x1EF6FD0 Offset: 0x1EF55D0 VA: 0x181EF6FD0 Slot: 13
	public int get_Count() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 14
	public bool get_IsReadOnly() { }

	// RVA: 0x1EF70B0 Offset: 0x1EF56B0 VA: 0x181EF70B0 Slot: 7
	public ICollection<string> get_Keys() { }

	// RVA: 0x1EF7100 Offset: 0x1EF5700 VA: 0x181EF7100 Slot: 8
	public ICollection<VariablesGroupAsset> get_Values() { }

	// RVA: 0x1EF7050 Offset: 0x1EF5650 VA: 0x181EF7050 Slot: 5
	public VariablesGroupAsset get_Item(string name) { }

	// RVA: 0x1EF7320 Offset: 0x1EF5920 VA: 0x181EF7320 Slot: 6
	public void set_Item(string name, VariablesGroupAsset value) { }

	[CompilerGenerated]
	// RVA: 0x1EF6F10 Offset: 0x1EF5510 VA: 0x181EF6F10
	public static void add_EndUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1EF7260 Offset: 0x1EF5860 VA: 0x181EF7260
	public static void remove_EndUpdate(Action value) { }

	// RVA: 0x1EEB590 Offset: 0x1EE9B90 VA: 0x181EEB590
	public void .ctor(SmartFormatter formatter) { }

	// RVA: 0x1EF60A0 Offset: 0x1EF46A0 VA: 0x181EF60A0
	public static void BeginUpdating() { }

	// RVA: 0x1EF64B0 Offset: 0x1EF4AB0 VA: 0x181EF64B0
	public static void EndUpdating() { }

	// RVA: 0x1EF6EA0 Offset: 0x1EF54A0 VA: 0x181EF6EA0
	public static IDisposable UpdateScope() { }

	// RVA: 0x1EF6DE0 Offset: 0x1EF53E0 VA: 0x181EF6DE0 Slot: 12
	public bool TryGetValue(string name, out VariablesGroupAsset value) { }

	// RVA: 0x1EF5DD0 Offset: 0x1EF43D0 VA: 0x181EF5DD0 Slot: 10
	public void Add(string name, VariablesGroupAsset group) { }

	// RVA: 0x1EF6040 Offset: 0x1EF4640 VA: 0x181EF6040 Slot: 15
	public void Add(KeyValuePair<string, VariablesGroupAsset> item) { }

	// RVA: 0x1EF6B50 Offset: 0x1EF5150 VA: 0x181EF6B50 Slot: 11
	public bool Remove(string name) { }

	// RVA: 0x1EF6A70 Offset: 0x1EF5070 VA: 0x181EF6A70 Slot: 19
	public bool Remove(KeyValuePair<string, VariablesGroupAsset> item) { }

	// RVA: 0x1EF60E0 Offset: 0x1EF46E0 VA: 0x181EF60E0 Slot: 16
	public void Clear() { }

	// RVA: 0x1EF6170 Offset: 0x1EF4770 VA: 0x181EF6170 Slot: 9
	public bool ContainsKey(string name) { }

	// RVA: 0x1EF61D0 Offset: 0x1EF47D0 VA: 0x181EF61D0 Slot: 17
	public bool Contains(KeyValuePair<string, VariablesGroupAsset> item) { }

	// RVA: 0x1EF62E0 Offset: 0x1EF48E0 VA: 0x181EF62E0 Slot: 18
	public void CopyTo(KeyValuePair<string, VariablesGroupAsset>[] array, int arrayIndex) { }

	[IteratorStateMachine(typeof(PersistentVariablesSource.<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-VariablesGroupAsset>>-GetEnumerator>d__34))]
	// RVA: 0x1EF6C10 Offset: 0x1EF5210 VA: 0x181EF6C10 Slot: 20
	private IEnumerator<KeyValuePair<string, VariablesGroupAsset>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Localization.SmartFormat.PersistentVariables.VariablesGroupAsset>>.GetEnumerator() { }

	[IteratorStateMachine(typeof(PersistentVariablesSource.<GetEnumerator>d__35))]
	// RVA: 0x1EF6830 Offset: 0x1EF4E30 VA: 0x181EF6830 Slot: 21
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1EF6C80 Offset: 0x1EF5280 VA: 0x181EF6C80 Slot: 4
	public bool TryEvaluateSelector(ISelectorInfo selectorInfo) { }

	// RVA: 0x1EF6570 Offset: 0x1EF4B70 VA: 0x181EF6570
	private static bool EvaluateLocalGroup(ISelectorInfo selectorInfo, IVariableGroup variablleGroup) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 22
	public void OnBeforeSerialize() { }

	// RVA: 0x1EF68A0 Offset: 0x1EF4EA0 VA: 0x181EF68A0 Slot: 23
	public void OnAfterDeserialize() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class PluralLocalizationFormatter : FormatterBase, IFormatterLiteralExtractor // TypeDefIndex: 11906
{
	// Fields
	[SerializeField]
	private string m_DefaultTwoLetterISOLanguageName; // 0x18
	private PluralRules.PluralRuleDelegate m_DefaultPluralRule; // 0x20

	// Properties
	public string DefaultTwoLetterISOLanguageName { get; set; }
	public override string[] DefaultNames { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_DefaultTwoLetterISOLanguageName() { }

	// RVA: 0x1EF87D0 Offset: 0x1EF6DD0 VA: 0x181EF87D0
	public void set_DefaultTwoLetterISOLanguageName(string value) { }

	// RVA: 0x1EF8680 Offset: 0x1EF6C80 VA: 0x181EF8680
	public void .ctor() { }

	// RVA: 0x1EF8700 Offset: 0x1EF6D00 VA: 0x181EF8700 Slot: 9
	public override string[] get_DefaultNames() { }

	// RVA: 0x1EF7FB0 Offset: 0x1EF65B0 VA: 0x181EF7FB0 Slot: 10
	public override bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	// RVA: 0x1EF7C00 Offset: 0x1EF6200 VA: 0x181EF7C00 Slot: 13
	protected virtual PluralRules.PluralRuleDelegate GetPluralRule(IFormattingInfo formattingInfo) { }

	// RVA: 0x1EF83D0 Offset: 0x1EF69D0 VA: 0x181EF83D0 Slot: 12
	public void WriteAllLiterals(IFormattingInfo formattingInfo) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
public class CustomPluralRuleProvider : IFormatProvider // TypeDefIndex: 11907
{
	// Fields
	private readonly PluralRules.PluralRuleDelegate _pluralRule; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(PluralRules.PluralRuleDelegate pluralRule) { }

	// RVA: 0x1EE82A0 Offset: 0x1EE68A0 VA: 0x181EE82A0 Slot: 4
	public object GetFormat(Type formatType) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public PluralRules.PluralRuleDelegate GetPluralRule() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class ReflectionSource : ISource // TypeDefIndex: 11909
{
	// Fields
	private static readonly object[] k_Empty; // 0x0
	[TupleElementNames(new[] { null, null, "field", "method" })]
	private Dictionary<ValueTuple<Type, string>, ValueTuple<FieldInfo, MethodInfo>> m_TypeCache; // 0x10

	// Properties
	[TupleElementNames(new[] { null, null, "field", "method" })]
	private Dictionary<ValueTuple<Type, string>, ValueTuple<FieldInfo, MethodInfo>> TypeCache { get; }

	// Methods

	// RVA: 0x1EF92B0 Offset: 0x1EF78B0 VA: 0x181EF92B0
	private Dictionary<ValueTuple<Type, string>, ValueTuple<FieldInfo, MethodInfo>> get_TypeCache() { }

	// RVA: 0x1EF9210 Offset: 0x1EF7810 VA: 0x181EF9210
	public void .ctor(SmartFormatter formatter) { }

	// RVA: 0x1EF8850 Offset: 0x1EF6E50 VA: 0x181EF8850 Slot: 4
	public bool TryEvaluateSelector(ISelectorInfo selectorInfo) { }

	// RVA: 0x1EF91A0 Offset: 0x1EF77A0 VA: 0x181EF91A0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class SubStringFormatter : FormatterBase // TypeDefIndex: 11911
{
	// Fields
	[SerializeField]
	private char m_ParameterDelimiter; // 0x18
	[SerializeField]
	private string m_NullDisplayString; // 0x20
	[SerializeField]
	private SubStringFormatter.SubStringOutOfRangeBehavior m_OutOfRangeBehavior; // 0x28

	// Properties
	public SubStringFormatter.SubStringOutOfRangeBehavior OutOfRangeBehavior { get; set; }
	public override string[] DefaultNames { get; }
	public char ParameterDelimiter { get; set; }
	public string NullDisplayString { get; set; }

	// Methods

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public SubStringFormatter.SubStringOutOfRangeBehavior get_OutOfRangeBehavior() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_OutOfRangeBehavior(SubStringFormatter.SubStringOutOfRangeBehavior value) { }

	// RVA: 0x1EFA490 Offset: 0x1EF8A90 VA: 0x181EFA490
	public void .ctor() { }

	// RVA: 0x1EFA510 Offset: 0x1EF8B10 VA: 0x181EFA510 Slot: 9
	public override string[] get_DefaultNames() { }

	// RVA: 0xA67330 Offset: 0xA65930 VA: 0x180A67330
	public char get_ParameterDelimiter() { }

	// RVA: 0x197EBC0 Offset: 0x197D1C0 VA: 0x18197EBC0
	public void set_ParameterDelimiter(char value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_NullDisplayString() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_NullDisplayString(string value) { }

	// RVA: 0x1EFA290 Offset: 0x1EF8890 VA: 0x181EFA290 Slot: 10
	public override bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class TemplateFormatter : FormatterBase // TypeDefIndex: 11913
{
	// Fields
	[SerializeField]
	private List<TemplateFormatter.Template> m_Templates; // 0x18
	private IDictionary<string, Format> m_TemplatesDict; // 0x20
	private SmartFormatter m_Formatter; // 0x28

	// Properties
	private IDictionary<string, Format> Templates { get; }
	public SmartFormatter Formatter { get; set; }
	public override string[] DefaultNames { get; }

	// Methods

	// RVA: 0x1EFB240 Offset: 0x1EF9840 VA: 0x181EFB240
	private IDictionary<string, Format> get_Templates() { }

	// RVA: 0x1EFB1F0 Offset: 0x1EF97F0 VA: 0x181EFB1F0
	public SmartFormatter get_Formatter() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_Formatter(SmartFormatter value) { }

	// RVA: 0x1EFB0B0 Offset: 0x1EF96B0 VA: 0x181EFB0B0
	public void .ctor() { }

	// RVA: 0x1EFB150 Offset: 0x1EF9750 VA: 0x181EFB150 Slot: 9
	public override string[] get_DefaultNames() { }

	// RVA: 0x1EFAD40 Offset: 0x1EF9340 VA: 0x181EFAD40 Slot: 10
	public override bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	// RVA: 0x1EFAB40 Offset: 0x1EF9140 VA: 0x181EFAB40
	public void Register(string templateName, string template) { }

	// RVA: 0x1EFAC70 Offset: 0x1EF9270 VA: 0x181EFAC70
	public bool Remove(string templateName) { }

	// RVA: 0x1EFAAE0 Offset: 0x1EF90E0 VA: 0x181EFAAE0 Slot: 11
	public override void OnAfterDeserialize() { }

	// RVA: 0x1EFAA80 Offset: 0x1EF9080 VA: 0x181EFAA80
	public void Clear() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class TimeFormatter : FormatterBase // TypeDefIndex: 11914
{
	// Fields
	[SerializeField]
	private TimeSpanFormatOptions m_DefaultFormatOptions; // 0x18
	private string m_DefaultTwoLetterIsoLanguageName; // 0x20

	// Properties
	public override string[] DefaultNames { get; }
	public TimeSpanFormatOptions DefaultFormatOptions { get; set; }
	public string DefaultTwoLetterISOLanguageName { get; set; }

	// Methods

	// RVA: 0x1EFBEA0 Offset: 0x1EFA4A0 VA: 0x181EFBEA0
	public void .ctor() { }

	// RVA: 0x1EFBF80 Offset: 0x1EFA580 VA: 0x181EFBF80 Slot: 9
	public override string[] get_DefaultNames() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public TimeSpanFormatOptions get_DefaultFormatOptions() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_DefaultFormatOptions(TimeSpanFormatOptions value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_DefaultTwoLetterISOLanguageName() { }

	// RVA: 0x1EFC070 Offset: 0x1EFA670 VA: 0x181EFC070
	public void set_DefaultTwoLetterISOLanguageName(string value) { }

	// RVA: 0x1EFB8C0 Offset: 0x1EF9EC0 VA: 0x181EFB8C0 Slot: 10
	public override bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }

	// RVA: 0x1EFB720 Offset: 0x1EF9D20 VA: 0x181EFB720
	private TimeTextInfo GetTimeTextInfo(IFormatProvider provider) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class ValueTupleSource : ISource // TypeDefIndex: 11915
{
	// Fields
	private SmartFormatter m_Formatter; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(SmartFormatter formatter) { }

	// RVA: 0x1EFEBC0 Offset: 0x1EFD1C0 VA: 0x181EFEBC0 Slot: 4
	public bool TryEvaluateSelector(ISelectorInfo selectorInfo) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class XElementFormatter : FormatterBase // TypeDefIndex: 11916
{
	// Properties
	public override string[] DefaultNames { get; }

	// Methods

	// RVA: 0x1EE8190 Offset: 0x1EE6790 VA: 0x181EE8190
	public void .ctor() { }

	// RVA: 0x1F00090 Offset: 0x1EFE690 VA: 0x181F00090 Slot: 9
	public override string[] get_DefaultNames() { }

	// RVA: 0x1EFFEB0 Offset: 0x1EFE4B0 VA: 0x181EFFEB0 Slot: 10
	public override bool TryEvaluateFormat(IFormattingInfo formattingInfo) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Extensions
[Serializable]
public class XmlSource : ISource // TypeDefIndex: 11918
{
	// Methods

	// RVA: 0x1F00360 Offset: 0x1EFE960 VA: 0x181F00360
	public void .ctor(SmartFormatter formatter) { }

	// RVA: 0x1F00180 Offset: 0x1EFE780 VA: 0x181F00180 Slot: 4
	public bool TryEvaluateSelector(ISelectorInfo selectorInfo) { }
}

