// Namespace: UnityEngine.Localization.SmartFormat.Utilities
public class FormatDelegate : IFormattable // TypeDefIndex: 11842
{
	// Fields
	private readonly Func<string, string> getFormat1; // 0x10
	private readonly Func<string, IFormatProvider, string> getFormat2; // 0x18

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(Func<string, string> getFormat) { }

	// RVA: 0x13E9320 Offset: 0x13E7920 VA: 0x1813E9320
	public void .ctor(Func<string, IFormatProvider, string> getFormat) { }

	// RVA: 0x1EC7630 Offset: 0x1EC5C30 VA: 0x181EC7630 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Utilities
[Extension]
public static class PluralRules // TypeDefIndex: 11845
{
	// Fields
	public static readonly Dictionary<string, PluralRules.PluralRuleDelegate> IsoLangToDelegate; // 0x0

	// Properties
	private static PluralRules.PluralRuleDelegate Singular { get; }
	private static PluralRules.PluralRuleDelegate DualOneOther { get; }
	private static PluralRules.PluralRuleDelegate DualWithZero { get; }
	private static PluralRules.PluralRuleDelegate DualFromZeroToTwo { get; }
	private static PluralRules.PluralRuleDelegate TripleOneTwoOther { get; }
	private static PluralRules.PluralRuleDelegate RussianSerboCroatian { get; }
	private static PluralRules.PluralRuleDelegate Arabic { get; }
	private static PluralRules.PluralRuleDelegate Breton { get; }
	private static PluralRules.PluralRuleDelegate Czech { get; }
	private static PluralRules.PluralRuleDelegate Welsh { get; }
	private static PluralRules.PluralRuleDelegate Manx { get; }
	private static PluralRules.PluralRuleDelegate Langi { get; }
	private static PluralRules.PluralRuleDelegate Lithuanian { get; }
	private static PluralRules.PluralRuleDelegate Latvian { get; }
	private static PluralRules.PluralRuleDelegate Macedonian { get; }
	private static PluralRules.PluralRuleDelegate Moldavian { get; }
	private static PluralRules.PluralRuleDelegate Maltese { get; }
	private static PluralRules.PluralRuleDelegate Polish { get; }
	private static PluralRules.PluralRuleDelegate Romanian { get; }
	private static PluralRules.PluralRuleDelegate Tachelhit { get; }
	private static PluralRules.PluralRuleDelegate Slovak { get; }
	private static PluralRules.PluralRuleDelegate Slovenian { get; }
	private static PluralRules.PluralRuleDelegate CentralMoroccoTamazight { get; }

	// Methods

	// RVA: 0x1ED3AE0 Offset: 0x1ED20E0 VA: 0x181ED3AE0
	private static PluralRules.PluralRuleDelegate get_Singular() { }

	// RVA: 0x1ED28E0 Offset: 0x1ED0EE0 VA: 0x181ED28E0
	private static PluralRules.PluralRuleDelegate get_DualOneOther() { }

	// RVA: 0x1ED2A60 Offset: 0x1ED1060 VA: 0x181ED2A60
	private static PluralRules.PluralRuleDelegate get_DualWithZero() { }

	// RVA: 0x1ED2760 Offset: 0x1ED0D60 VA: 0x181ED2760
	private static PluralRules.PluralRuleDelegate get_DualFromZeroToTwo() { }

	// RVA: 0x1ED40E0 Offset: 0x1ED26E0 VA: 0x181ED40E0
	private static PluralRules.PluralRuleDelegate get_TripleOneTwoOther() { }

	// RVA: 0x1ED3960 Offset: 0x1ED1F60 VA: 0x181ED3960
	private static PluralRules.PluralRuleDelegate get_RussianSerboCroatian() { }

	// RVA: 0x1ED2160 Offset: 0x1ED0760 VA: 0x181ED2160
	private static PluralRules.PluralRuleDelegate get_Arabic() { }

	// RVA: 0x1ED22E0 Offset: 0x1ED08E0 VA: 0x181ED22E0
	private static PluralRules.PluralRuleDelegate get_Breton() { }

	// RVA: 0x1ED25E0 Offset: 0x1ED0BE0 VA: 0x181ED25E0
	private static PluralRules.PluralRuleDelegate get_Czech() { }

	// RVA: 0x1ED4260 Offset: 0x1ED2860 VA: 0x181ED4260
	private static PluralRules.PluralRuleDelegate get_Welsh() { }

	// RVA: 0x1ED3360 Offset: 0x1ED1960 VA: 0x181ED3360
	private static PluralRules.PluralRuleDelegate get_Manx() { }

	// RVA: 0x1ED2BE0 Offset: 0x1ED11E0 VA: 0x181ED2BE0
	private static PluralRules.PluralRuleDelegate get_Langi() { }

	// RVA: 0x1ED2EE0 Offset: 0x1ED14E0 VA: 0x181ED2EE0
	private static PluralRules.PluralRuleDelegate get_Lithuanian() { }

	// RVA: 0x1ED2D60 Offset: 0x1ED1360 VA: 0x181ED2D60
	private static PluralRules.PluralRuleDelegate get_Latvian() { }

	// RVA: 0x1ED3060 Offset: 0x1ED1660 VA: 0x181ED3060
	private static PluralRules.PluralRuleDelegate get_Macedonian() { }

	// RVA: 0x1ED34E0 Offset: 0x1ED1AE0 VA: 0x181ED34E0
	private static PluralRules.PluralRuleDelegate get_Moldavian() { }

	// RVA: 0x1ED31E0 Offset: 0x1ED17E0 VA: 0x181ED31E0
	private static PluralRules.PluralRuleDelegate get_Maltese() { }

	// RVA: 0x1ED3660 Offset: 0x1ED1C60 VA: 0x181ED3660
	private static PluralRules.PluralRuleDelegate get_Polish() { }

	// RVA: 0x1ED37E0 Offset: 0x1ED1DE0 VA: 0x181ED37E0
	private static PluralRules.PluralRuleDelegate get_Romanian() { }

	// RVA: 0x1ED3F60 Offset: 0x1ED2560 VA: 0x181ED3F60
	private static PluralRules.PluralRuleDelegate get_Tachelhit() { }

	// RVA: 0x1ED3C60 Offset: 0x1ED2260 VA: 0x181ED3C60
	private static PluralRules.PluralRuleDelegate get_Slovak() { }

	// RVA: 0x1ED3DE0 Offset: 0x1ED23E0 VA: 0x181ED3DE0
	private static PluralRules.PluralRuleDelegate get_Slovenian() { }

	// RVA: 0x1ED2460 Offset: 0x1ED0A60 VA: 0x181ED2460
	private static PluralRules.PluralRuleDelegate get_CentralMoroccoTamazight() { }

	// RVA: 0x1ECF140 Offset: 0x1ECD740 VA: 0x181ECF140
	public static PluralRules.PluralRuleDelegate GetPluralRule(string twoLetterIsoLanguageName) { }

	[Extension]
	// RVA: 0x1ECF000 Offset: 0x1ECD600 VA: 0x181ECF000
	private static bool Between(Decimal value, Decimal min, Decimal max) { }

	// RVA: 0x1ECF250 Offset: 0x1ECD850 VA: 0x181ECF250
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Utilities
[Extension]
public static class TimeSpanUtility // TypeDefIndex: 11846
{
	// Fields
	internal const TimeSpanFormatOptions AbbreviateAll = 3;
	internal const TimeSpanFormatOptions LessThanAll = 12;
	internal const TimeSpanFormatOptions RangeAll = 16128;
	internal const TimeSpanFormatOptions TruncateAll = 240;
	[CompilerGenerated]
	private static TimeSpanFormatOptions <DefaultFormatOptions>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly TimeSpanFormatOptions <AbsoluteDefaults>k__BackingField; // 0x4

	// Properties
	public static TimeSpanFormatOptions DefaultFormatOptions { get; set; }
	public static TimeSpanFormatOptions AbsoluteDefaults { get; }

	// Methods

	[Extension]
	// RVA: 0x1EDEEF0 Offset: 0x1EDD4F0 VA: 0x181EDEEF0
	public static string ToTimeString(TimeSpan FromTime, TimeSpanFormatOptions options, TimeTextInfo timeTextInfo) { }

	// RVA: 0x1EDF980 Offset: 0x1EDDF80 VA: 0x181EDF980
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1EDFA90 Offset: 0x1EDE090 VA: 0x181EDFA90
	public static TimeSpanFormatOptions get_DefaultFormatOptions() { }

	[CompilerGenerated]
	// RVA: 0x1EDFAE0 Offset: 0x1EDE0E0 VA: 0x181EDFAE0
	public static void set_DefaultFormatOptions(TimeSpanFormatOptions value) { }

	[CompilerGenerated]
	// RVA: 0x1EDFA40 Offset: 0x1EDE040 VA: 0x181EDFA40
	public static TimeSpanFormatOptions get_AbsoluteDefaults() { }

	[Extension]
	// RVA: 0x1EDEE50 Offset: 0x1EDD450 VA: 0x181EDEE50
	public static TimeSpan Round(TimeSpan fromTime, long intervalTicks) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Utilities
[Flags]
public enum TimeSpanFormatOptions // TypeDefIndex: 11847
{
	// Fields
	public int value__; // 0x0
	public const TimeSpanFormatOptions InheritDefaults = 0;
	public const TimeSpanFormatOptions Abbreviate = 1;
	public const TimeSpanFormatOptions AbbreviateOff = 2;
	public const TimeSpanFormatOptions LessThan = 4;
	public const TimeSpanFormatOptions LessThanOff = 8;
	public const TimeSpanFormatOptions TruncateShortest = 16;
	public const TimeSpanFormatOptions TruncateAuto = 32;
	public const TimeSpanFormatOptions TruncateFill = 64;
	public const TimeSpanFormatOptions TruncateFull = 128;
	public const TimeSpanFormatOptions RangeMilliSeconds = 256;
	public const TimeSpanFormatOptions RangeSeconds = 512;
	public const TimeSpanFormatOptions RangeMinutes = 1024;
	public const TimeSpanFormatOptions RangeHours = 2048;
	public const TimeSpanFormatOptions RangeDays = 4096;
	public const TimeSpanFormatOptions RangeWeeks = 8192;
}

// Namespace: UnityEngine.Localization.SmartFormat.Utilities
[Extension]
internal static class TimeSpanFormatOptionsConverter // TypeDefIndex: 11849
{
	// Fields
	private static readonly Regex parser; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1EDE4F0 Offset: 0x1EDCAF0 VA: 0x181EDE4F0
	public static TimeSpanFormatOptions Merge(TimeSpanFormatOptions left, TimeSpanFormatOptions right) { }

	[Extension]
	// RVA: 0x15808B0 Offset: 0x157EEB0 VA: 0x1815808B0
	public static TimeSpanFormatOptions Mask(TimeSpanFormatOptions timeSpanFormatOptions, TimeSpanFormatOptions mask) { }

	[IteratorStateMachine(typeof(TimeSpanFormatOptionsConverter.<AllFlags>d__3))]
	[Extension]
	// RVA: 0x1EDE480 Offset: 0x1EDCA80 VA: 0x181EDE480
	public static IEnumerable<TimeSpanFormatOptions> AllFlags(TimeSpanFormatOptions timeSpanFormatOptions) { }

	// RVA: 0x1EDE5A0 Offset: 0x1EDCBA0 VA: 0x181EDE5A0
	public static TimeSpanFormatOptions Parse(string formatOptionsString) { }

	// RVA: 0x1EDEDC0 Offset: 0x1EDD3C0 VA: 0x181EDEDC0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Utilities
public class TimeTextInfo // TypeDefIndex: 11851
{
	// Fields
	private readonly string[] d; // 0x10
	private readonly string[] day; // 0x18
	private readonly string[] h; // 0x20
	private readonly string[] hour; // 0x28
	private readonly string lessThan; // 0x30
	private readonly string[] m; // 0x38
	private readonly string[] millisecond; // 0x40
	private readonly string[] minute; // 0x48
	private readonly string[] ms; // 0x50
	private readonly PluralRules.PluralRuleDelegate PluralRule; // 0x58
	private readonly string[] s; // 0x60
	private readonly string[] second; // 0x68
	private readonly string[] w; // 0x70
	private readonly string[] week; // 0x78

	// Methods

	// RVA: 0x1EE0170 Offset: 0x1EDE770 VA: 0x181EE0170
	public void .ctor(PluralRules.PluralRuleDelegate pluralRule, string[] week, string[] day, string[] hour, string[] minute, string[] second, string[] millisecond, string[] w, string[] d, string[] h, string[] m, string[] s, string[] ms, string lessThan) { }

	// RVA: 0x1EDFD80 Offset: 0x1EDE380 VA: 0x181EDFD80
	public void .ctor(string week, string day, string hour, string minute, string second, string millisecond, string lessThan) { }

	// RVA: 0x1EDFCA0 Offset: 0x1EDE2A0 VA: 0x181EDFCA0
	private static string GetValue(PluralRules.PluralRuleDelegate pluralRule, int value, string[] units) { }

	// RVA: 0x1EDFB40 Offset: 0x1EDE140 VA: 0x181EDFB40
	public string GetLessThanText(string minimumValue) { }

	// RVA: 0x1EDFB50 Offset: 0x1EDE150 VA: 0x181EDFB50 Slot: 4
	public virtual string GetUnitText(TimeSpanFormatOptions unit, int value, bool abbr) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Utilities
public static class CommonLanguagesTimeTextInfo // TypeDefIndex: 11852
{
	// Properties
	public static TimeTextInfo English { get; }

	// Methods

	// RVA: 0x1EE67A0 Offset: 0x1EE4DA0 VA: 0x181EE67A0
	public static TimeTextInfo get_English() { }

	// RVA: 0x1EE6750 Offset: 0x1EE4D50 VA: 0x181EE6750
	public static TimeTextInfo GetTimeTextInfo(string twoLetterIsoLanguageName) { }
}

// Namespace: UnityEngine.Localization.SmartFormat.Utilities
[Extension]
public static class TupleExtensions // TypeDefIndex: 11856
{
	// Fields
	private static readonly HashSet<Type> ValueTupleTypes; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1EFC6C0 Offset: 0x1EFACC0 VA: 0x181EFC6C0
	public static bool IsValueTuple(object obj) { }

	[Extension]
	// RVA: 0x1EFC5E0 Offset: 0x1EFABE0 VA: 0x181EFC5E0
	public static bool IsValueTupleType(Type type) { }

	[Extension]
	// RVA: 0x1EFC380 Offset: 0x1EFA980 VA: 0x181EFC380
	public static IEnumerable<object> GetValueTupleItemObjects(object tuple) { }

	[Extension]
	// RVA: 0x1EFC490 Offset: 0x1EFAA90 VA: 0x181EFC490
	public static IEnumerable<Type> GetValueTupleItemTypes(Type tupleType) { }

	[Extension]
	// RVA: 0x1EFC150 Offset: 0x1EFA750 VA: 0x181EFC150
	public static List<FieldInfo> GetValueTupleItemFields(Type tupleType) { }

	[IteratorStateMachine(typeof(TupleExtensions.<GetValueTupleItemObjectsFlattened>d__6))]
	[Extension]
	// RVA: 0x1EFC300 Offset: 0x1EFA900 VA: 0x181EFC300
	public static IEnumerable<object> GetValueTupleItemObjectsFlattened(object tuple) { }

	// RVA: 0x1EFC7F0 Offset: 0x1EFADF0 VA: 0x181EFC7F0
	private static void .cctor() { }
}

