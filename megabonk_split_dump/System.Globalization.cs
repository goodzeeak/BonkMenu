// Namespace: System.Globalization
public static class CharUnicodeInfo // TypeDefIndex: 1330
{
	// Properties
	private static ReadOnlySpan<byte> CategoryLevel1Index { get; }
	private static ReadOnlySpan<byte> CategoryLevel2Index { get; }
	private static ReadOnlySpan<byte> CategoryLevel3Index { get; }
	private static ReadOnlySpan<byte> CategoriesValue { get; }

	// Methods

	// RVA: 0x142E6F0 Offset: 0x142CCF0 VA: 0x18142E6F0
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x142E790 Offset: 0x142CD90 VA: 0x18142E790
	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	// RVA: 0x142E6E0 Offset: 0x142CCE0 VA: 0x18142E6E0
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x142E5B0 Offset: 0x142CBB0 VA: 0x18142E5B0
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x142E450 Offset: 0x142CA50 VA: 0x18142E450
	public static UnicodeCategory GetUnicodeCategory(int codePoint) { }

	// RVA: 0x142E830 Offset: 0x142CE30 VA: 0x18142E830
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x142E9A0 Offset: 0x142CFA0 VA: 0x18142E9A0
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x142EA30 Offset: 0x142D030 VA: 0x18142EA30
	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	// RVA: 0x142EAE0 Offset: 0x142D0E0 VA: 0x18142EAE0
	internal static bool IsCombiningCategory(UnicodeCategory uc) { }

	// RVA: 0x142EB20 Offset: 0x142D120 VA: 0x18142EB20
	internal static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x142EB00 Offset: 0x142D100 VA: 0x18142EB00
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x142ECB0 Offset: 0x142D2B0 VA: 0x18142ECB0
	private static ReadOnlySpan<byte> get_CategoryLevel1Index() { }

	// RVA: 0x142ED00 Offset: 0x142D300 VA: 0x18142ED00
	private static ReadOnlySpan<byte> get_CategoryLevel2Index() { }

	// RVA: 0x142ED50 Offset: 0x142D350 VA: 0x18142ED50
	private static ReadOnlySpan<byte> get_CategoryLevel3Index() { }

	// RVA: 0x142EC60 Offset: 0x142D260 VA: 0x18142EC60
	private static ReadOnlySpan<byte> get_CategoriesValue() { }
}

// Namespace: System.Globalization
[Serializable]
public class CompareInfo : IDeserializationCallback // TypeDefIndex: 1331
{
	// Fields
	private const CompareOptions ValidIndexMaskOffFlags = -32;
	private const CompareOptions ValidCompareMaskOffFlags = -536870944;
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32;
	private const CompareOptions ValidSortkeyCtorMaskOffFlags = -536870944;
	internal static readonly CompareInfo Invariant; // 0x0
	[OptionalField(VersionAdded = 2)]
	private string m_name; // 0x10
	private string _sortName; // 0x18
	[OptionalField(VersionAdded = 3)]
	private SortVersion m_SortVersion; // 0x20
	private int culture; // 0x28
	private ISimpleCollator collator; // 0x30
	private static Dictionary<string, ISimpleCollator> collators; // 0x8
	private static bool managedCollation; // 0x10
	private static bool managedCollationChecked; // 0x11

	// Properties
	public virtual string Name { get; }
	private static bool UseManagedCollation { get; }

	// Methods

	// RVA: 0x14326D0 Offset: 0x1430CD0 VA: 0x1814326D0
	internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x14327B0 Offset: 0x1430DB0 VA: 0x1814327B0
	internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x14322F0 Offset: 0x14308F0 VA: 0x1814322F0
	private static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start) { }

	// RVA: 0x14328A0 Offset: 0x1430EA0 VA: 0x1814328A0
	private static char InvariantToUpper(char c) { }

	// RVA: 0x1432030 Offset: 0x1430630 VA: 0x181432030
	private SortKey InvariantCreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x1433770 Offset: 0x1431D70 VA: 0x181433770
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x1430D00 Offset: 0x142F300 VA: 0x181430D00
	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializing]
	// RVA: 0x1433460 Offset: 0x1431A60 VA: 0x181433460
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x1433450 Offset: 0x1431A50 VA: 0x181433450 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[OnDeserialized]
	// RVA: 0x1433450 Offset: 0x1431A50 VA: 0x181433450
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x1433390 Offset: 0x1431990 VA: 0x181433390
	private void OnDeserialized() { }

	[OnSerializing]
	// RVA: 0x1433480 Offset: 0x1431A80 VA: 0x181433480
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x14337C0 Offset: 0x1431DC0 VA: 0x1814337C0 Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x142FFC0 Offset: 0x142E5C0 VA: 0x18142FFC0 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x142F7A0 Offset: 0x142DDA0 VA: 0x18142F7A0 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x142FFF0 Offset: 0x142E5F0 VA: 0x18142FFF0
	internal int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options) { }

	// RVA: 0x142EDA0 Offset: 0x142D3A0 VA: 0x18142EDA0
	internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2) { }

	// RVA: 0x142FA40 Offset: 0x142E040 VA: 0x18142FA40 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x142F2F0 Offset: 0x142D8F0 VA: 0x18142F2F0
	internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB) { }

	// RVA: 0x142EFD0 Offset: 0x142D5D0 VA: 0x18142EFD0
	internal static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB) { }

	// RVA: 0x14328C0 Offset: 0x1430EC0 VA: 0x1814328C0 Slot: 9
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x1432B50 Offset: 0x1431150 VA: 0x181432B50 Slot: 10
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x14308C0 Offset: 0x142EEC0 VA: 0x1814308C0
	internal bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options) { }

	// RVA: 0x1431F70 Offset: 0x1430570 VA: 0x181431F70 Slot: 11
	public virtual int IndexOf(string source, char value, CompareOptions options) { }

	// RVA: 0x1431870 Offset: 0x142FE70 VA: 0x181431870 Slot: 12
	public virtual int IndexOf(string source, string value, CompareOptions options) { }

	// RVA: 0x1431900 Offset: 0x142FF00 VA: 0x181431900 Slot: 13
	public virtual int IndexOf(string source, char value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x1431C00 Offset: 0x1430200 VA: 0x181431C00 Slot: 14
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x14316B0 Offset: 0x142FCB0 VA: 0x1814316B0
	internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x1432EE0 Offset: 0x14314E0 VA: 0x181432EE0 Slot: 15
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x1432DA0 Offset: 0x14313A0 VA: 0x181432DA0
	internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x1431520 Offset: 0x142FB20 VA: 0x181431520 Slot: 16
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x1430940 Offset: 0x142EF40 VA: 0x181430940 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1431110 Offset: 0x142F710 VA: 0x181431110 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1431150 Offset: 0x142F750 VA: 0x181431150
	internal static int GetIgnoreCaseHash(string source) { }

	// RVA: 0x1430E00 Offset: 0x142F400 VA: 0x181430E00
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x1431000 Offset: 0x142F600 VA: 0x181431000 Slot: 17
	public virtual int GetHashCode(string source, CompareOptions options) { }

	// RVA: 0x1433640 Offset: 0x1431C40 VA: 0x181433640 Slot: 3
	public override string ToString() { }

	// RVA: 0x1433840 Offset: 0x1431E40 VA: 0x181433840
	private static bool get_UseManagedCollation() { }

	// RVA: 0x1430A00 Offset: 0x142F000 VA: 0x181430A00
	private ISimpleCollator GetCollator() { }

	// RVA: 0x1430440 Offset: 0x142EA40 VA: 0x181430440
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x1433EF0 Offset: 0x14324F0 VA: 0x181433EF0
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x1433B70 Offset: 0x1432170 VA: 0x181433B70
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x1433A80 Offset: 0x1432080 VA: 0x181433A80
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x1433E40 Offset: 0x1432440 VA: 0x181433E40
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x14339C0 Offset: 0x1431FC0 VA: 0x1814339C0
	private static int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options) { }

	// RVA: 0x14339D0 Offset: 0x1431FD0 VA: 0x1814339D0
	private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x1433D70 Offset: 0x1432370 VA: 0x181433D70
	private static int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first) { }

	// RVA: 0x1433D80 Offset: 0x1432380 VA: 0x181433D80
	private static int internal_index(string source, int sindex, int count, string value, bool first) { }

	// RVA: 0x1432000 Offset: 0x1430600 VA: 0x181432000
	private void InitSort(CultureInfo culture) { }

	// RVA: 0x142F490 Offset: 0x142DA90 VA: 0x18142F490
	private static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2) { }

	// RVA: 0x1431670 Offset: 0x142FC70 VA: 0x181431670
	internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x1432D60 Offset: 0x1431360 VA: 0x181432D60
	internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x1432D20 Offset: 0x1431320 VA: 0x181432D20
	private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x14315F0 Offset: 0x142FBF0 VA: 0x1814315F0
	private int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr) { }

	// RVA: 0x142F720 Offset: 0x142DD20 VA: 0x18142F720
	private int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options) { }

	// RVA: 0x142F600 Offset: 0x142DC00 VA: 0x18142F600
	private int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options) { }

	// RVA: 0x1430590 Offset: 0x142EB90 VA: 0x181430590
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x1433520 Offset: 0x1431B20 VA: 0x181433520
	private bool StartsWith(string source, string prefix, CompareOptions options) { }

	// RVA: 0x14307A0 Offset: 0x142EDA0 VA: 0x1814307A0
	private bool EndsWith(string source, string suffix, CompareOptions options) { }

	// RVA: 0x14308C0 Offset: 0x142EEC0 VA: 0x1814308C0
	private bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options) { }

	// RVA: 0x1430DC0 Offset: 0x142F3C0 VA: 0x181430DC0
	internal int GetHashCodeOfStringCore(string source, CompareOptions options) { }

	// RVA: 0x14336A0 Offset: 0x1431CA0 VA: 0x1814336A0
	private static void .cctor() { }

	// RVA: 0x1433740 Offset: 0x1431D40 VA: 0x181433740
	internal void .ctor() { }
}

// Namespace: System.Globalization
[Flags]
public enum CompareOptions // TypeDefIndex: 1332
{
	// Fields
	public int value__; // 0x0
	public const CompareOptions None = 0;
	public const CompareOptions IgnoreCase = 1;
	public const CompareOptions IgnoreNonSpace = 2;
	public const CompareOptions IgnoreSymbols = 4;
	public const CompareOptions IgnoreKanaType = 8;
	public const CompareOptions IgnoreWidth = 16;
	public const CompareOptions OrdinalIgnoreCase = 268435456;
	public const CompareOptions StringSort = 536870912;
	public const CompareOptions Ordinal = 1073741824;
}

// Namespace: System.Globalization
[Serializable]
public class CultureNotFoundException : ArgumentException // TypeDefIndex: 1333
{
	// Fields
	private string _invalidCultureName; // 0x98
	private Nullable<int> _invalidCultureId; // 0xA0

	// Properties
	public virtual Nullable<int> InvalidCultureId { get; }
	public virtual string InvalidCultureName { get; }
	private static string DefaultMessage { get; }
	private string FormatedInvalidCultureId { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x14345A0 Offset: 0x1432BA0 VA: 0x1814345A0
	public void .ctor() { }

	// RVA: 0x1434580 Offset: 0x1432B80 VA: 0x181434580
	public void .ctor(string paramName, string message) { }

	// RVA: 0x14345E0 Offset: 0x1432BE0 VA: 0x1814345E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1434440 Offset: 0x1432A40 VA: 0x181434440 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0 Slot: 12
	public virtual Nullable<int> get_InvalidCultureId() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910 Slot: 13
	public virtual string get_InvalidCultureName() { }

	// RVA: 0x14347A0 Offset: 0x1432DA0 VA: 0x1814347A0
	private static string get_DefaultMessage() { }

	// RVA: 0x14347D0 Offset: 0x1432DD0 VA: 0x1814347D0
	private string get_FormatedInvalidCultureId() { }

	// RVA: 0x14348F0 Offset: 0x1432EF0 VA: 0x1814348F0 Slot: 5
	public override string get_Message() { }
}

// Namespace: System.Globalization
[Flags]
public enum CultureTypes // TypeDefIndex: 1334
{
	// Fields
	public int value__; // 0x0
	public const CultureTypes NeutralCultures = 1;
	public const CultureTypes SpecificCultures = 2;
	public const CultureTypes InstalledWin32Cultures = 4;
	public const CultureTypes AllCultures = 7;
	public const CultureTypes UserCustomCulture = 8;
	public const CultureTypes ReplacementCultures = 16;
	[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
	public const CultureTypes WindowsOnlyCultures = 32;
	[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
	public const CultureTypes FrameworkCultures = 64;
}

// Namespace: System.Globalization
[Flags]
internal enum MonthNameStyles // TypeDefIndex: 1335
{
	// Fields
	public int value__; // 0x0
	public const MonthNameStyles Regular = 0;
	public const MonthNameStyles Genitive = 1;
	public const MonthNameStyles LeapYear = 2;
}

// Namespace: System.Globalization
[Flags]
internal enum DateTimeFormatFlags // TypeDefIndex: 1336
{
	// Fields
	public int value__; // 0x0
	public const DateTimeFormatFlags None = 0;
	public const DateTimeFormatFlags UseGenitiveMonth = 1;
	public const DateTimeFormatFlags UseLeapYearMonth = 2;
	public const DateTimeFormatFlags UseSpacesInMonthNames = 4;
	public const DateTimeFormatFlags UseHebrewRule = 8;
	public const DateTimeFormatFlags UseSpacesInDayNames = 16;
	public const DateTimeFormatFlags UseDigitPrefixInTokens = 32;
	public const DateTimeFormatFlags NotInitialized = -1;
}

// Namespace: System.Globalization
[Serializable]
public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable // TypeDefIndex: 1338
{
	// Fields
	private static DateTimeFormatInfo s_invariantInfo; // 0x0
	private CultureData _cultureData; // 0x10
	private string _name; // 0x18
	private string _langName; // 0x20
	private CompareInfo _compareInfo; // 0x28
	private CultureInfo _cultureInfo; // 0x30
	private string amDesignator; // 0x38
	private string pmDesignator; // 0x40
	private string dateSeparator; // 0x48
	private string generalShortTimePattern; // 0x50
	private string generalLongTimePattern; // 0x58
	private string timeSeparator; // 0x60
	private string monthDayPattern; // 0x68
	private string dateTimeOffsetPattern; // 0x70
	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
	private const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
	private const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	private Calendar calendar; // 0x78
	private int firstDayOfWeek; // 0x80
	private int calendarWeekRule; // 0x84
	private string fullDateTimePattern; // 0x88
	private string[] abbreviatedDayNames; // 0x90
	private string[] m_superShortDayNames; // 0x98
	private string[] dayNames; // 0xA0
	private string[] abbreviatedMonthNames; // 0xA8
	private string[] monthNames; // 0xB0
	private string[] genitiveMonthNames; // 0xB8
	private string[] m_genitiveAbbreviatedMonthNames; // 0xC0
	private string[] leapYearMonthNames; // 0xC8
	private string longDatePattern; // 0xD0
	private string shortDatePattern; // 0xD8
	private string yearMonthPattern; // 0xE0
	private string longTimePattern; // 0xE8
	private string shortTimePattern; // 0xF0
	private string[] allYearMonthPatterns; // 0xF8
	private string[] allShortDatePatterns; // 0x100
	private string[] allLongDatePatterns; // 0x108
	private string[] allShortTimePatterns; // 0x110
	private string[] allLongTimePatterns; // 0x118
	private string[] m_eraNames; // 0x120
	private string[] m_abbrevEraNames; // 0x128
	private string[] m_abbrevEnglishEraNames; // 0x130
	private CalendarId[] optionalCalendars; // 0x138
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;
	internal bool _isReadOnly; // 0x140
	private DateTimeFormatFlags formatFlags; // 0x144
	private static readonly char[] s_monthSpaces; // 0x8
	internal const string RoundtripFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.fffffffK";
	internal const string RoundtripDateTimeUnfixed = "yyyy\'-\'MM\'-\'ddTHH\':\'mm\':\'ss zzz";
	private string _fullTimeSpanPositivePattern; // 0x148
	private string _fullTimeSpanNegativePattern; // 0x150
	internal const DateTimeStyles InvalidDateTimeStyles = -256;
	private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash; // 0x158
	private const int TOKEN_HASH_SIZE = 199;
	private const int SECOND_PRIME = 197;
	private const string dateSeparatorOrTimeZoneOffset = "-";
	private const string invariantDateSeparator = "/";
	private const string invariantTimeSeparator = ":";
	internal const string IgnorablePeriod = ".";
	internal const string IgnorableComma = ",";
	internal const string CJKYearSuff = "年";
	internal const string CJKMonthSuff = "月";
	internal const string CJKDaySuff = "日";
	internal const string KoreanYearSuff = "년";
	internal const string KoreanMonthSuff = "월";
	internal const string KoreanDaySuff = "일";
	internal const string KoreanHourSuff = "시";
	internal const string KoreanMinuteSuff = "분";
	internal const string KoreanSecondSuff = "초";
	internal const string CJKHourSuff = "時";
	internal const string ChineseHourSuff = "时";
	internal const string CJKMinuteSuff = "分";
	internal const string CJKSecondSuff = "秒";
	internal const string JapaneseEraStart = "元";
	internal const string LocalTimeMark = "T";
	internal const string GMTName = "GMT";
	internal const string ZuluName = "Z";
	internal const string KoreanLangName = "ko";
	internal const string JapaneseLangName = "ja";
	internal const string EnglishLangName = "en";
	private static DateTimeFormatInfo s_jajpDTFI; // 0x10
	private static DateTimeFormatInfo s_zhtwDTFI; // 0x18

	// Properties
	private string CultureName { get; }
	private CultureInfo Culture { get; }
	private string LanguageName { get; }
	public static DateTimeFormatInfo InvariantInfo { get; }
	public static DateTimeFormatInfo CurrentInfo { get; }
	public string AMDesignator { get; }
	public Calendar Calendar { get; set; }
	private CalendarId[] OptionalCalendars { get; }
	internal string[] EraNames { get; }
	internal string[] AbbreviatedEraNames { get; }
	internal string[] AbbreviatedEnglishEraNames { get; }
	public string DateSeparator { get; }
	public string FullDateTimePattern { get; }
	public string LongDatePattern { get; }
	public string LongTimePattern { get; }
	public string MonthDayPattern { get; }
	public string PMDesignator { get; }
	public string RFC1123Pattern { get; }
	public string ShortDatePattern { get; }
	public string ShortTimePattern { get; }
	public string SortableDateTimePattern { get; }
	internal string GeneralShortTimePattern { get; }
	internal string GeneralLongTimePattern { get; }
	internal string DateTimeOffsetPattern { get; }
	public string TimeSeparator { get; }
	public string UniversalSortableDateTimePattern { get; }
	public string YearMonthPattern { get; }
	public string[] AbbreviatedDayNames { get; }
	public string[] DayNames { get; }
	public string[] AbbreviatedMonthNames { get; }
	public string[] MonthNames { get; }
	internal bool HasSpacesInMonthNames { get; }
	internal bool HasSpacesInDayNames { get; }
	private string[] AllYearMonthPatterns { get; }
	private string[] AllShortDatePatterns { get; }
	private string[] AllShortTimePatterns { get; }
	private string[] AllLongDatePatterns { get; }
	private string[] AllLongTimePatterns { get; }
	private string[] UnclonedYearMonthPatterns { get; }
	private string[] UnclonedShortDatePatterns { get; }
	private string[] UnclonedLongDatePatterns { get; }
	private string[] UnclonedShortTimePatterns { get; }
	private string[] UnclonedLongTimePatterns { get; }
	public bool IsReadOnly { get; }
	public string[] MonthGenitiveNames { get; }
	internal string FullTimeSpanPositivePattern { get; }
	internal string FullTimeSpanNegativePattern { get; }
	internal CompareInfo CompareInfo { get; }
	internal DateTimeFormatFlags FormatFlags { get; }
	internal bool HasForceTwoDigitYears { get; }
	internal bool HasYearMonthAdjustment { get; }

	// Methods

	// RVA: 0x143CE10 Offset: 0x143B410 VA: 0x18143CE10
	private string get_CultureName() { }

	// RVA: 0x143CE50 Offset: 0x143B450 VA: 0x18143CE50
	private CultureInfo get_Culture() { }

	// RVA: 0x143DAF0 Offset: 0x143C0F0 VA: 0x18143DAF0
	private string get_LanguageName() { }

	// RVA: 0x143E330 Offset: 0x143C930 VA: 0x18143E330
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x143E2C0 Offset: 0x143C8C0 VA: 0x18143E2C0
	private string[] internalGetAbbreviatedDayOfWeekNamesCore() { }

	// RVA: 0x143E450 Offset: 0x143CA50 VA: 0x18143E450
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x143E3E0 Offset: 0x143C9E0 VA: 0x18143E3E0
	private string[] internalGetDayOfWeekNamesCore() { }

	// RVA: 0x143E3C0 Offset: 0x143C9C0 VA: 0x18143E3C0
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x143E350 Offset: 0x143C950 VA: 0x18143E350
	private string[] internalGetAbbreviatedMonthNamesCore() { }

	// RVA: 0x143E810 Offset: 0x143CE10 VA: 0x18143E810
	private string[] internalGetMonthNames() { }

	// RVA: 0x143E7A0 Offset: 0x143CDA0 VA: 0x18143E7A0
	private string[] internalGetMonthNamesCore() { }

	// RVA: 0x143C410 Offset: 0x143AA10 VA: 0x18143C410
	public void .ctor() { }

	// RVA: 0x143C6A0 Offset: 0x143ACA0 VA: 0x18143C6A0
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x1439E30 Offset: 0x1438430 VA: 0x181439E30
	private void InitializeOverridableProperties(CultureData cultureData, int calendarId) { }

	// RVA: 0x143D950 Offset: 0x143BF50 VA: 0x18143D950
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x143CEF0 Offset: 0x143B4F0 VA: 0x18143CEF0
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x14392D0 Offset: 0x14378D0 VA: 0x1814392D0
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x1439250 Offset: 0x1437850 VA: 0x181439250 Slot: 4
	public object GetFormat(Type formatType) { }

	// RVA: 0x14378F0 Offset: 0x1435EF0 VA: 0x1814378F0 Slot: 5
	public object Clone() { }

	// RVA: 0x143C710 Offset: 0x143AD10 VA: 0x18143C710
	public string get_AMDesignator() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public Calendar get_Calendar() { }

	// RVA: 0x143E830 Offset: 0x143CE30 VA: 0x18143E830
	public void set_Calendar(Calendar value) { }

	// RVA: 0x143DDF0 Offset: 0x143C3F0 VA: 0x18143DDF0
	private CalendarId[] get_OptionalCalendars() { }

	// RVA: 0x143D350 Offset: 0x143B950 VA: 0x18143D350
	internal string[] get_EraNames() { }

	// RVA: 0x1439110 Offset: 0x1437710 VA: 0x181439110
	public string GetEraName(int era) { }

	// RVA: 0x143C860 Offset: 0x143AE60 VA: 0x18143C860
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x1438780 Offset: 0x1436D80 VA: 0x181438780
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x143C7E0 Offset: 0x143ADE0 VA: 0x18143C7E0
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x143D000 Offset: 0x143B600 VA: 0x18143D000
	public string get_DateSeparator() { }

	// RVA: 0x143D3F0 Offset: 0x143B9F0 VA: 0x18143D3F0
	public string get_FullDateTimePattern() { }

	// RVA: 0x143DB30 Offset: 0x143C130 VA: 0x18143DB30
	public string get_LongDatePattern() { }

	// RVA: 0x143DB90 Offset: 0x143C190 VA: 0x18143DB90
	public string get_LongTimePattern() { }

	// RVA: 0x143DC20 Offset: 0x143C220 VA: 0x18143DC20
	public string get_MonthDayPattern() { }

	// RVA: 0x143DE40 Offset: 0x143C440 VA: 0x18143DE40
	public string get_PMDesignator() { }

	// RVA: 0x143DE80 Offset: 0x143C480 VA: 0x18143DE80
	public string get_RFC1123Pattern() { }

	// RVA: 0x143DEB0 Offset: 0x143C4B0 VA: 0x18143DEB0
	public string get_ShortDatePattern() { }

	// RVA: 0x143DF10 Offset: 0x143C510 VA: 0x18143DF10
	public string get_ShortTimePattern() { }

	// RVA: 0x143DFA0 Offset: 0x143C5A0 VA: 0x18143DFA0
	public string get_SortableDateTimePattern() { }

	// RVA: 0x143D7C0 Offset: 0x143BDC0 VA: 0x18143D7C0
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x143D700 Offset: 0x143BD00 VA: 0x18143D700
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x143D070 Offset: 0x143B670 VA: 0x18143D070
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x143DFD0 Offset: 0x143C5D0 VA: 0x18143DFD0
	public string get_TimeSeparator() { }

	// RVA: 0x143E230 Offset: 0x143C830 VA: 0x18143E230
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x143E260 Offset: 0x143C860 VA: 0x18143E260
	public string get_YearMonthPattern() { }

	// RVA: 0x143C750 Offset: 0x143AD50 VA: 0x18143C750
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x143D2C0 Offset: 0x143B8C0 VA: 0x18143D2C0
	public string[] get_DayNames() { }

	// RVA: 0x143C8E0 Offset: 0x143AEE0 VA: 0x18143C8E0
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x143DD60 Offset: 0x143C360 VA: 0x18143DD60
	public string[] get_MonthNames() { }

	// RVA: 0x143D8F0 Offset: 0x143BEF0 VA: 0x18143D8F0
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x143D8C0 Offset: 0x143BEC0 VA: 0x18143D8C0
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x143E5E0 Offset: 0x143CBE0 VA: 0x18143E5E0
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x143E470 Offset: 0x143CA70 VA: 0x18143E470
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x143E560 Offset: 0x143CB60 VA: 0x18143E560
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x1438670 Offset: 0x1436C70 VA: 0x181438670
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x1438ED0 Offset: 0x14374D0 VA: 0x181438ED0
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x14389F0 Offset: 0x1436FF0 VA: 0x1814389F0
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x1439000 Offset: 0x1437600 VA: 0x181439000
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x14388F0 Offset: 0x1436EF0 VA: 0x1814388F0
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x1439820 Offset: 0x1437E20 VA: 0x181439820
	public string GetMonthName(int month) { }

	// RVA: 0x1439650 Offset: 0x1437C50 VA: 0x181439650
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x143CC30 Offset: 0x143B230 VA: 0x18143CC30
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x143CAD0 Offset: 0x143B0D0 VA: 0x18143CAD0
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x143CB80 Offset: 0x143B180 VA: 0x18143CB80
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x143C970 Offset: 0x143AF70 VA: 0x18143C970
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x143CA20 Offset: 0x143B020 VA: 0x18143CA20
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x143E1B0 Offset: 0x143C7B0 VA: 0x18143E1B0
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x143E0E0 Offset: 0x143C6E0 VA: 0x18143E0E0
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x143E010 Offset: 0x143C610 VA: 0x18143E010
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x143E160 Offset: 0x143C760 VA: 0x18143E160
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x143E090 Offset: 0x143C690 VA: 0x18143E090
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x143DA60 Offset: 0x143C060 VA: 0x18143DA60
	public bool get_IsReadOnly() { }

	// RVA: 0x143DC90 Offset: 0x143C290 VA: 0x18143DC90
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x143D610 Offset: 0x143BC10 VA: 0x18143D610
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x143D4C0 Offset: 0x143BAC0 VA: 0x18143D4C0
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x143CCE0 Offset: 0x143B2E0 VA: 0x18143CCE0
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x143C110 Offset: 0x143A710 VA: 0x18143C110
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x143D3D0 Offset: 0x143B9D0 VA: 0x18143D3D0
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x1439AD0 Offset: 0x14380D0 VA: 0x181439AD0
	private DateTimeFormatFlags InitializeFormatFlags() { }

	// RVA: 0x143D880 Offset: 0x143BE80 VA: 0x18143D880
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x143D920 Offset: 0x143BF20 VA: 0x18143D920
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x143C230 Offset: 0x143A830 VA: 0x18143C230
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x14394A0 Offset: 0x1437AA0 VA: 0x1814394A0
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x1439920 Offset: 0x1437F20 VA: 0x181439920
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x14378B0 Offset: 0x1435EB0 VA: 0x1814378B0
	private void ClearTokenHashTable() { }

	// RVA: 0x1437B60 Offset: 0x1436160 VA: 0x181437B60
	internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x143A8B0 Offset: 0x1438EB0 VA: 0x18143A8B0
	private void PopulateSpecialTokenHashTable(DateTimeFormatInfo.TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol) { }

	// RVA: 0x143A780 Offset: 0x1438D80 VA: 0x18143A780
	private static bool IsJapaneseCalendar(Calendar calendar) { }

	// RVA: 0x14377E0 Offset: 0x1435DE0 VA: 0x1814377E0
	private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x143BFB0 Offset: 0x143A5B0 VA: 0x18143BFB0
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x143A760 Offset: 0x1438D60 VA: 0x18143A760
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x143A640 Offset: 0x1438C40 VA: 0x18143A640
	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh) { }

	// RVA: 0x143B7C0 Offset: 0x1439DC0 VA: 0x18143B7C0
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x1439FF0 Offset: 0x14385F0 VA: 0x181439FF0
	private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x143A230 Offset: 0x1438830 VA: 0x18143A230
	private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x1437A40 Offset: 0x1436040 VA: 0x181437A40
	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x143C370 Offset: 0x143A970 VA: 0x18143C370
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal enum FORMATFLAGS // TypeDefIndex: 1339
{
	// Fields
	public int value__; // 0x0
	public const FORMATFLAGS None = 0;
	public const FORMATFLAGS UseGenitiveMonth = 1;
	public const FORMATFLAGS UseLeapYearMonth = 2;
	public const FORMATFLAGS UseSpacesInMonthNames = 4;
	public const FORMATFLAGS UseHebrewParsing = 8;
	public const FORMATFLAGS UseSpacesInDayNames = 16;
	public const FORMATFLAGS UseDigitPrefixInTokens = 32;
}

// Namespace: System.Globalization
internal enum CalendarId // TypeDefIndex: 1340
{
	// Fields
	public ushort value__; // 0x0
	public const CalendarId UNINITIALIZED_VALUE = 0;
	public const CalendarId GREGORIAN = 1;
	public const CalendarId GREGORIAN_US = 2;
	public const CalendarId JAPAN = 3;
	public const CalendarId TAIWAN = 4;
	public const CalendarId KOREA = 5;
	public const CalendarId HIJRI = 6;
	public const CalendarId THAI = 7;
	public const CalendarId HEBREW = 8;
	public const CalendarId GREGORIAN_ME_FRENCH = 9;
	public const CalendarId GREGORIAN_ARABIC = 10;
	public const CalendarId GREGORIAN_XLIT_ENGLISH = 11;
	public const CalendarId GREGORIAN_XLIT_FRENCH = 12;
	public const CalendarId JULIAN = 13;
	public const CalendarId JAPANESELUNISOLAR = 14;
	public const CalendarId CHINESELUNISOLAR = 15;
	public const CalendarId SAKA = 16;
	public const CalendarId LUNAR_ETO_CHN = 17;
	public const CalendarId LUNAR_ETO_KOR = 18;
	public const CalendarId LUNAR_ETO_ROKUYOU = 19;
	public const CalendarId KOREANLUNISOLAR = 20;
	public const CalendarId TAIWANLUNISOLAR = 21;
	public const CalendarId PERSIAN = 22;
	public const CalendarId UMALQURA = 23;
	public const CalendarId LAST_CALENDAR = 23;
}

// Namespace: System.Globalization
internal class DateTimeFormatInfoScanner // TypeDefIndex: 1342
{
	// Fields
	internal List<string> m_dateWords; // 0x10
	private static Dictionary<string, string> s_knownWords; // 0x0
	private DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags; // 0x18

	// Properties
	private static Dictionary<string, string> KnownWords { get; }

	// Methods

	// RVA: 0x1455790 Offset: 0x1453D90 VA: 0x181455790
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x1455660 Offset: 0x1453C60 VA: 0x181455660
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x1454620 Offset: 0x1452C20 VA: 0x181454620
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x1454850 Offset: 0x1452E50 VA: 0x181454850
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x14555F0 Offset: 0x1453BF0 VA: 0x1814555F0
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x1454A60 Offset: 0x1453060 VA: 0x181454A60
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x14553C0 Offset: 0x14539C0 VA: 0x1814553C0
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x1454F00 Offset: 0x1453500 VA: 0x181454F00
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x1455190 Offset: 0x1453790 VA: 0x181455190
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x1455300 Offset: 0x1453900 VA: 0x181455300
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x14552C0 Offset: 0x14538C0 VA: 0x1814552C0
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x14552B0 Offset: 0x14538B0 VA: 0x1814552B0
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x1454E60 Offset: 0x1453460 VA: 0x181454E60
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x1454DB0 Offset: 0x14533B0 VA: 0x181454DB0
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x1454B60 Offset: 0x1453160 VA: 0x181454B60
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x1455710 Offset: 0x1453D10 VA: 0x181455710
	public void .ctor() { }
}

// Namespace: System.Globalization
[Flags]
public enum DateTimeStyles // TypeDefIndex: 1343
{
	// Fields
	public int value__; // 0x0
	public const DateTimeStyles None = 0;
	public const DateTimeStyles AllowLeadingWhite = 1;
	public const DateTimeStyles AllowTrailingWhite = 2;
	public const DateTimeStyles AllowInnerWhite = 4;
	public const DateTimeStyles AllowWhiteSpaces = 7;
	public const DateTimeStyles NoCurrentDateDefault = 8;
	public const DateTimeStyles AdjustToUniversal = 16;
	public const DateTimeStyles AssumeLocal = 32;
	public const DateTimeStyles AssumeUniversal = 64;
	public const DateTimeStyles RoundtripKind = 128;
}

// Namespace: System.Globalization
[IsReadOnly]
internal struct DaylightTimeStruct // TypeDefIndex: 1344
{
	// Fields
	public readonly DateTime Start; // 0x0
	public readonly DateTime End; // 0x8
	public readonly TimeSpan Delta; // 0x10

	// Methods

	// RVA: 0x1455BB0 Offset: 0x14541B0 VA: 0x181455BB0
	public void .ctor(DateTime start, DateTime end, TimeSpan delta) { }
}

// Namespace: System.Globalization
internal struct HebrewNumberParsingContext // TypeDefIndex: 1345
{
	// Fields
	internal HebrewNumber.HS state; // 0x0
	internal int result; // 0x4

	// Methods

	// RVA: 0x14597B0 Offset: 0x1457DB0 VA: 0x1814597B0
	public void .ctor(int result) { }
}

// Namespace: System.Globalization
internal enum HebrewNumberParsingState // TypeDefIndex: 1346
{
	// Fields
	public int value__; // 0x0
	public const HebrewNumberParsingState InvalidHebrewNumber = 0;
	public const HebrewNumberParsingState NotHebrewDigit = 1;
	public const HebrewNumberParsingState FoundEndOfHebrewNumber = 2;
	public const HebrewNumberParsingState ContinueParsing = 3;
}

// Namespace: System.Globalization
internal class HebrewNumber // TypeDefIndex: 1350
{
	// Fields
	private static readonly HebrewNumber.HebrewValue[] s_hebrewValues; // 0x0
	private static char s_maxHebrewNumberCh; // 0x8
	private static readonly HebrewNumber.HS[] s_numberPasingState; // 0x10

	// Methods

	// RVA: 0x1459A40 Offset: 0x1458040 VA: 0x181459A40
	internal static string ToString(int Number) { }

	// RVA: 0x1459890 Offset: 0x1457E90 VA: 0x181459890
	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	// RVA: 0x14597C0 Offset: 0x1457DC0 VA: 0x1814597C0
	internal static bool IsDigit(char ch) { }

	// RVA: 0x1459CE0 Offset: 0x14582E0 VA: 0x181459CE0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[Flags]
public enum NumberStyles // TypeDefIndex: 1351
{
	// Fields
	public int value__; // 0x0
	public const NumberStyles None = 0;
	public const NumberStyles AllowLeadingWhite = 1;
	public const NumberStyles AllowTrailingWhite = 2;
	public const NumberStyles AllowLeadingSign = 4;
	public const NumberStyles AllowTrailingSign = 8;
	public const NumberStyles AllowParentheses = 16;
	public const NumberStyles AllowDecimalPoint = 32;
	public const NumberStyles AllowThousands = 64;
	public const NumberStyles AllowExponent = 128;
	public const NumberStyles AllowCurrencySymbol = 256;
	public const NumberStyles AllowHexSpecifier = 512;
	public const NumberStyles Integer = 7;
	public const NumberStyles HexNumber = 515;
	public const NumberStyles Number = 111;
	public const NumberStyles Float = 167;
	public const NumberStyles Currency = 383;
	public const NumberStyles Any = 511;
}

// Namespace: System.Globalization
[Serializable]
public sealed class SortVersion // TypeDefIndex: 1352
{}

// Namespace: System.Globalization
internal static class TimeSpanFormat // TypeDefIndex: 1355
{
	// Fields
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28

	// Methods

	// RVA: 0x1460870 Offset: 0x145EE70 VA: 0x181460870
	private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits) { }

	// RVA: 0x1461990 Offset: 0x145FF90 VA: 0x181461990
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	// RVA: 0x1461A60 Offset: 0x1460060 VA: 0x181461A60
	internal static bool TryFormat(TimeSpan value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x1461690 Offset: 0x145FC90 VA: 0x181461690
	private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x1461130 Offset: 0x145F730 VA: 0x181461130
	private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<char> format, TimeSpanFormat.Pattern pattern) { }

	// RVA: 0x1460960 Offset: 0x145EF60 VA: 0x181460960
	private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, StringBuilder result) { }

	// RVA: 0x1461B70 Offset: 0x1460170 VA: 0x181461B70
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal static class TimeSpanParse // TypeDefIndex: 1363
{
	// Methods

	// RVA: 0x1461C70 Offset: 0x1460270 VA: 0x181461C70
	internal static long Pow10(int pow) { }

	// RVA: 0x1466F50 Offset: 0x1465550 VA: 0x181466F50
	private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result) { }

	// RVA: 0x1461C30 Offset: 0x1460230 VA: 0x181461C30
	internal static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider) { }

	// RVA: 0x1466EF0 Offset: 0x14654F0 VA: 0x181466EF0
	internal static bool TryParse(ReadOnlySpan<char> input, IFormatProvider formatProvider, out TimeSpan result) { }

	// RVA: 0x1465C30 Offset: 0x1464230 VA: 0x181465C30
	private static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1461D60 Offset: 0x1460360 VA: 0x181461D60
	private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1461EC0 Offset: 0x14604C0 VA: 0x181461EC0
	private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1462620 Offset: 0x1460C20 VA: 0x181462620
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1464120 Offset: 0x1462720 VA: 0x181464120
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x14658B0 Offset: 0x1463EB0 VA: 0x1814658B0
	private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x14622F0 Offset: 0x14608F0 VA: 0x1814622F0
	private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }
}

// Namespace: System.Globalization
public enum UnicodeCategory // TypeDefIndex: 1364
{
	// Fields
	public int value__; // 0x0
	public const UnicodeCategory UppercaseLetter = 0;
	public const UnicodeCategory LowercaseLetter = 1;
	public const UnicodeCategory TitlecaseLetter = 2;
	public const UnicodeCategory ModifierLetter = 3;
	public const UnicodeCategory OtherLetter = 4;
	public const UnicodeCategory NonSpacingMark = 5;
	public const UnicodeCategory SpacingCombiningMark = 6;
	public const UnicodeCategory EnclosingMark = 7;
	public const UnicodeCategory DecimalDigitNumber = 8;
	public const UnicodeCategory LetterNumber = 9;
	public const UnicodeCategory OtherNumber = 10;
	public const UnicodeCategory SpaceSeparator = 11;
	public const UnicodeCategory LineSeparator = 12;
	public const UnicodeCategory ParagraphSeparator = 13;
	public const UnicodeCategory Control = 14;
	public const UnicodeCategory Format = 15;
	public const UnicodeCategory Surrogate = 16;
	public const UnicodeCategory PrivateUse = 17;
	public const UnicodeCategory ConnectorPunctuation = 18;
	public const UnicodeCategory DashPunctuation = 19;
	public const UnicodeCategory OpenPunctuation = 20;
	public const UnicodeCategory ClosePunctuation = 21;
	public const UnicodeCategory InitialQuotePunctuation = 22;
	public const UnicodeCategory FinalQuotePunctuation = 23;
	public const UnicodeCategory OtherPunctuation = 24;
	public const UnicodeCategory MathSymbol = 25;
	public const UnicodeCategory CurrencySymbol = 26;
	public const UnicodeCategory ModifierSymbol = 27;
	public const UnicodeCategory OtherSymbol = 28;
	public const UnicodeCategory OtherNotAssigned = 29;
}

// Namespace: System.Globalization
internal static class GlobalizationMode // TypeDefIndex: 1365
{
	// Fields
	[CompilerGenerated]
	private static readonly bool <Invariant>k__BackingField; // 0x0

	// Properties
	internal static bool Invariant { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1456500 Offset: 0x1454B00 VA: 0x181456500
	internal static bool get_Invariant() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	private static bool GetGlobalizationInvariantMode() { }

	// RVA: 0x14564C0 Offset: 0x1454AC0 VA: 0x1814564C0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 1366
{
	// Fields
	internal int m_currentEraValue; // 0x10
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x14
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisible(False)]
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x14545A0 Offset: 0x1452BA0 VA: 0x1814545A0 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1454550 Offset: 0x1452B50 VA: 0x181454550 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x14542B0 Offset: 0x14528B0 VA: 0x1814542B0
	protected void .ctor() { }

	// RVA: 0x37A690 Offset: 0x378C90 VA: 0x18037A690 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x14542D0 Offset: 0x14528D0 VA: 0x1814542D0 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisible(False)]
	// RVA: 0x1453B50 Offset: 0x1452150 VA: 0x181453B50 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x1454230 Offset: 0x1452830 VA: 0x181454230
	internal void VerifyWritable() { }

	// RVA: 0x1453DF0 Offset: 0x14523F0 VA: 0x181453DF0
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x14542F0 Offset: 0x14528F0 VA: 0x1814542F0 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetDaysInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int GetEra(DateTime time);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int[] get_Eras();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetMonthsInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetYear(DateTime time);

	// RVA: 0x1453C30 Offset: 0x1452230 VA: 0x181453C30 Slot: 20
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool IsLeapYear(int year, int era);

	// RVA: 0x1453FC0 Offset: 0x14525C0 VA: 0x181453FC0 Slot: 22
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

	// RVA: 0x1454130 Offset: 0x1452730 VA: 0x181454130 Slot: 24
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x1453D60 Offset: 0x1452360 VA: 0x181453D60 Slot: 25
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x1453CE0 Offset: 0x14522E0 VA: 0x181453CE0 Slot: 26
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x1453C50 Offset: 0x1452250 VA: 0x181453C50 Slot: 27
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 28
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x14545F0 Offset: 0x1452BF0 VA: 0x1814545F0 Slot: 29
	public virtual void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1454020 Offset: 0x1452620 VA: 0x181454020 Slot: 30
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x1453E00 Offset: 0x1452400 VA: 0x181453E00
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x1453BE0 Offset: 0x14521E0 VA: 0x181453BE0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

// Namespace: System.Globalization
internal class CalendarData // TypeDefIndex: 1367
{
	// Fields
	internal const int MAX_CALENDARS = 23;
	internal string sNativeName; // 0x10
	internal string[] saShortDates; // 0x18
	internal string[] saYearMonths; // 0x20
	internal string[] saLongDates; // 0x28
	internal string sMonthDay; // 0x30
	internal string[] saEraNames; // 0x38
	internal string[] saAbbrevEraNames; // 0x40
	internal string[] saAbbrevEnglishEraNames; // 0x48
	internal string[] saDayNames; // 0x50
	internal string[] saAbbrevDayNames; // 0x58
	internal string[] saSuperShortDayNames; // 0x60
	internal string[] saMonthNames; // 0x68
	internal string[] saAbbrevMonthNames; // 0x70
	internal string[] saMonthGenitiveNames; // 0x78
	internal string[] saAbbrevMonthGenitiveNames; // 0x80
	internal string[] saLeapYearMonthNames; // 0x88
	internal int iTwoDigitYearMax; // 0x90
	internal int iCurrentEra; // 0x94
	internal bool bUseUserOverrides; // 0x98
	internal static CalendarData Invariant; // 0x0
	private static string[] HEBREW_MONTH_NAMES; // 0x8
	private static string[] HEBREW_LEAP_MONTH_NAMES; // 0x10

	// Methods

	// RVA: 0x1453A30 Offset: 0x1452030 VA: 0x181453A30
	private void .ctor() { }

	// RVA: 0x14520B0 Offset: 0x14506B0 VA: 0x1814520B0
	private static void .cctor() { }

	// RVA: 0x1453100 Offset: 0x1451700 VA: 0x181453100
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x1451AC0 Offset: 0x14500C0 VA: 0x181451AC0
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x1451580 Offset: 0x144FB80 VA: 0x181451580
	private static string[] GetJapaneseEraNames() { }

	// RVA: 0x14513C0 Offset: 0x144F9C0 VA: 0x1814513C0
	private static string[] GetJapaneseEnglishEraNames() { }

	// RVA: 0x1451740 Offset: 0x144FD40 VA: 0x181451740
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x14511D0 Offset: 0x144F7D0 VA: 0x1814511D0
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x1451040 Offset: 0x144F640 VA: 0x181451040
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0x37A690 Offset: 0x378C90 VA: 0x18037A690
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x1453A60 Offset: 0x1452060 VA: 0x181453A60
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x1453A50 Offset: 0x1452050 VA: 0x181453A50
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class GregorianCalendar : Calendar // TypeDefIndex: 1368
{
	// Fields
	internal GregorianCalendarTypes m_type; // 0x20
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	private static Calendar s_defaultInstance; // 0x10

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	[OnDeserialized]
	// RVA: 0x1458E80 Offset: 0x1457480 VA: 0x181458E80
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x14595E0 Offset: 0x1457BE0 VA: 0x1814595E0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1459590 Offset: 0x1457B90 VA: 0x181459590 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1458950 Offset: 0x1456F50 VA: 0x181458950
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x14593B0 Offset: 0x14579B0 VA: 0x1814593B0
	public void .ctor() { }

	// RVA: 0x14593E0 Offset: 0x14579E0 VA: 0x1814593E0
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x14581D0 Offset: 0x14567D0 VA: 0x1814581D0 Slot: 31
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x1457FD0 Offset: 0x14565D0 VA: 0x181457FD0
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x1458390 Offset: 0x1456990 VA: 0x181458390 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1458400 Offset: 0x1456A00 VA: 0x181458400 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1458480 Offset: 0x1456A80 VA: 0x181458480 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1458780 Offset: 0x1456D80 VA: 0x181458780 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x1459530 Offset: 0x1457B30 VA: 0x181459530 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x1458A60 Offset: 0x1457060 VA: 0x181458A60 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x1458AD0 Offset: 0x14570D0 VA: 0x181458AD0 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1458C50 Offset: 0x1457250 VA: 0x181458C50 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x1458CC0 Offset: 0x14572C0 VA: 0x181458CC0 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x1458F70 Offset: 0x1457570 VA: 0x181458F70 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x14591C0 Offset: 0x14577C0 VA: 0x1814591C0 Slot: 24
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x1459630 Offset: 0x1457C30 VA: 0x181459630 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x14596A0 Offset: 0x1457CA0 VA: 0x1814596A0 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1459050 Offset: 0x1457650 VA: 0x181459050 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x14592C0 Offset: 0x14578C0 VA: 0x1814592C0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[Serializable]
internal class EraInfo // TypeDefIndex: 1369
{
	// Fields
	internal int era; // 0x10
	internal long ticks; // 0x18
	internal int yearOffset; // 0x20
	internal int minEraYear; // 0x24
	internal int maxEraYear; // 0x28
	[OptionalField(VersionAdded = 4)]
	internal string eraName; // 0x30
	[OptionalField(VersionAdded = 4)]
	internal string abbrevEraName; // 0x38
	[OptionalField(VersionAdded = 4)]
	internal string englishEraName; // 0x40

	// Methods

	// RVA: 0x1455CD0 Offset: 0x14542D0 VA: 0x181455CD0
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	// RVA: 0x1455BC0 Offset: 0x14541C0 VA: 0x181455BC0
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }
}

// Namespace: System.Globalization
[Serializable]
internal class GregorianCalendarHelper // TypeDefIndex: 1370
{
	// Fields
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	[OptionalField(VersionAdded = 1)]
	internal int m_maxYear; // 0x10
	[OptionalField(VersionAdded = 1)]
	internal int m_minYear; // 0x14
	internal Calendar m_Cal; // 0x18
	[OptionalField(VersionAdded = 1)]
	internal EraInfo[] m_EraInfo; // 0x20
	[OptionalField(VersionAdded = 1)]
	internal int[] m_eras; // 0x28
	[OptionalField(VersionAdded = 1)]
	internal DateTime m_minDate; // 0x30

	// Properties
	internal int MaxYear { get; }
	public int[] Eras { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	internal int get_MaxYear() { }

	// RVA: 0x1457DD0 Offset: 0x14563D0 VA: 0x181457DD0
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x14570F0 Offset: 0x14556F0 VA: 0x1814570F0
	private int GetYearOffset(int year, int era, bool throwOnError) { }

	// RVA: 0x1457030 Offset: 0x1455630 VA: 0x181457030
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x1457630 Offset: 0x1455C30 VA: 0x181457630
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x14569D0 Offset: 0x1454FD0 VA: 0x1814569D0 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x14567D0 Offset: 0x1454DD0 VA: 0x1814567D0
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x1456750 Offset: 0x1454D50 VA: 0x181456750
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x1457650 Offset: 0x1455C50 VA: 0x181457650
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x1456550 Offset: 0x1454B50 VA: 0x181456550
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x1456BC0 Offset: 0x14551C0 VA: 0x181456BC0
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1456C30 Offset: 0x1455230 VA: 0x181456C30
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1456CE0 Offset: 0x14552E0 VA: 0x181456CE0
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1456E90 Offset: 0x1455490 VA: 0x181456E90
	public int GetDaysInYear(int year, int era) { }

	// RVA: 0x1456F20 Offset: 0x1455520 VA: 0x181456F20
	public int GetEra(DateTime time) { }

	// RVA: 0x1457E90 Offset: 0x1456490 VA: 0x181457E90
	public int[] get_Eras() { }

	// RVA: 0x1457060 Offset: 0x1455660 VA: 0x181457060
	public int GetMonth(DateTime time) { }

	// RVA: 0x14570D0 Offset: 0x14556D0 VA: 0x1814570D0
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1457480 Offset: 0x1455A80 VA: 0x181457480
	public int GetYear(DateTime time) { }

	// RVA: 0x14575B0 Offset: 0x1455BB0 VA: 0x1814575B0
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x1457810 Offset: 0x1455E10 VA: 0x181457810
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1457AF0 Offset: 0x14560F0 VA: 0x181457AF0
	public int ToFourDigitYear(int year, int twoDigitYearMax) { }

	// RVA: 0x1457CE0 Offset: 0x14562E0 VA: 0x181457CE0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public enum GregorianCalendarTypes // TypeDefIndex: 1371
{
	// Fields
	public int value__; // 0x0
	public const GregorianCalendarTypes Localized = 1;
	public const GregorianCalendarTypes USEnglish = 2;
	public const GregorianCalendarTypes MiddleEastFrench = 9;
	public const GregorianCalendarTypes Arabic = 10;
	public const GregorianCalendarTypes TransliteratedEnglish = 11;
	public const GregorianCalendarTypes TransliteratedFrench = 12;
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class HijriCalendar : Calendar // TypeDefIndex: 1372
{
	// Fields
	public static readonly int HijriEra; // 0x0
	internal static readonly int[] HijriMonthDays; // 0x8
	private int m_HijriAdvance; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10
	internal static readonly DateTime calendarMaxValue; // 0x18

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public int HijriAdjustment { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x145B890 Offset: 0x1459E90 VA: 0x18145B890 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x145B840 Offset: 0x1459E40 VA: 0x18145B840 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x145B730 Offset: 0x1459D30 VA: 0x18145B730
	public void .ctor() { }

	// RVA: 0x45C3F0 Offset: 0x45A9F0 VA: 0x18045C3F0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x145A7E0 Offset: 0x1458DE0 VA: 0x18145A7E0
	private long GetAbsoluteDateHijri(int y, int m, int d) { }

	// RVA: 0x145A720 Offset: 0x1458D20 VA: 0x18145A720
	private long DaysUpToHijriYear(int HijriYear) { }

	// RVA: 0x145B7E0 Offset: 0x1459DE0 VA: 0x18145B7E0
	public int get_HijriAdjustment() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	private static int GetAdvanceHijriDate() { }

	// RVA: 0x145A180 Offset: 0x1458780 VA: 0x18145A180
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x145A0B0 Offset: 0x14586B0 VA: 0x18145A0B0
	internal static void CheckEraRange(int era) { }

	// RVA: 0x145A540 Offset: 0x1458B40 VA: 0x18145A540
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x145A380 Offset: 0x1458980 VA: 0x18145A380
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x145A8F0 Offset: 0x1458EF0 VA: 0x18145A8F0 Slot: 31
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x145AB90 Offset: 0x1459190 VA: 0x18145AB90 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x145AC00 Offset: 0x1459200 VA: 0x18145AC00 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x145AC80 Offset: 0x1459280 VA: 0x18145AC80 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x145AED0 Offset: 0x14594D0 VA: 0x18145AED0 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x145AF60 Offset: 0x1459560 VA: 0x18145AF60 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x145B750 Offset: 0x1459D50 VA: 0x18145B750 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x145AFF0 Offset: 0x14595F0 VA: 0x18145AFF0 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x145B060 Offset: 0x1459660 VA: 0x18145B060 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x145B0C0 Offset: 0x14596C0 VA: 0x18145B0C0 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x145B130 Offset: 0x1459730 VA: 0x18145B130 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x145B1B0 Offset: 0x14597B0 VA: 0x18145B1B0 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x145B8E0 Offset: 0x1459EE0 VA: 0x18145B8E0 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x145B950 Offset: 0x1459F50 VA: 0x18145B950 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x145B470 Offset: 0x1459A70 VA: 0x18145B470 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x145B600 Offset: 0x1459C00 VA: 0x18145B600
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class JapaneseCalendar : Calendar // TypeDefIndex: 1373
{
	// Fields
	internal static readonly DateTime calendarMinValue; // 0x0
	internal static EraInfo[] japaneseEraInfo; // 0x8
	internal static Calendar s_defaultInstance; // 0x10
	internal GregorianCalendarHelper helper; // 0x20

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x145C860 Offset: 0x145AE60 VA: 0x18145C860 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x145C810 Offset: 0x145AE10 VA: 0x18145C810 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x145BDA0 Offset: 0x145A3A0 VA: 0x18145BDA0
	internal static EraInfo[] GetEraInfo() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	private static EraInfo[] GetErasFromRegistry() { }

	// RVA: 0x145BCB0 Offset: 0x145A2B0 VA: 0x18145BCB0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x145C680 Offset: 0x145AC80 VA: 0x18145C680
	public void .ctor() { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x145BC60 Offset: 0x145A260 VA: 0x18145BC60 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x145BC90 Offset: 0x145A290 VA: 0x18145BC90 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x145BC20 Offset: 0x145A220 VA: 0x18145BC20 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x145BC40 Offset: 0x145A240 VA: 0x18145BC40 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x145C3C0 Offset: 0x145A9C0 VA: 0x18145C3C0 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x145C380 Offset: 0x145A980 VA: 0x18145C380 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x145C3A0 Offset: 0x145A9A0 VA: 0x18145C3A0 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x145C3F0 Offset: 0x145A9F0 VA: 0x18145C3F0 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x145C410 Offset: 0x145AA10 VA: 0x18145C410 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x145C460 Offset: 0x145AA60 VA: 0x18145C460 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x145C490 Offset: 0x145AA90 VA: 0x18145C490 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x145C7F0 Offset: 0x145ADF0 VA: 0x18145C7F0 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x145BB40 Offset: 0x145A140 VA: 0x18145BB40
	internal static string[] EraNames() { }

	// RVA: 0x145BA60 Offset: 0x145A060 VA: 0x18145BA60
	internal static string[] EnglishEraNames() { }

	// RVA: 0x145C430 Offset: 0x145AA30 VA: 0x18145C430 Slot: 25
	internal override bool IsValidYear(int year, int era) { }

	// RVA: 0x145C8B0 Offset: 0x145AEB0 VA: 0x18145C8B0 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x145C920 Offset: 0x145AF20 VA: 0x18145C920 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x145C620 Offset: 0x145AC20 VA: 0x18145C620
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 1374
{
	// Fields
	private static NumberFormatInfo invariantInfo; // 0x0
	internal int[] numberGroupSizes; // 0x10
	internal int[] currencyGroupSizes; // 0x18
	internal int[] percentGroupSizes; // 0x20
	internal string positiveSign; // 0x28
	internal string negativeSign; // 0x30
	internal string numberDecimalSeparator; // 0x38
	internal string numberGroupSeparator; // 0x40
	internal string currencyGroupSeparator; // 0x48
	internal string currencyDecimalSeparator; // 0x50
	internal string currencySymbol; // 0x58
	internal string ansiCurrencySymbol; // 0x60
	internal string nanSymbol; // 0x68
	internal string positiveInfinitySymbol; // 0x70
	internal string negativeInfinitySymbol; // 0x78
	internal string percentDecimalSeparator; // 0x80
	internal string percentGroupSeparator; // 0x88
	internal string percentSymbol; // 0x90
	internal string perMilleSymbol; // 0x98
	[OptionalField(VersionAdded = 2)]
	internal string[] nativeDigits; // 0xA0
	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem; // 0xA8
	internal int numberDecimalDigits; // 0xAC
	internal int currencyDecimalDigits; // 0xB0
	internal int currencyPositivePattern; // 0xB4
	internal int currencyNegativePattern; // 0xB8
	internal int numberNegativePattern; // 0xBC
	internal int percentPositivePattern; // 0xC0
	internal int percentNegativePattern; // 0xC4
	internal int percentDecimalDigits; // 0xC8
	[OptionalField(VersionAdded = 2)]
	internal int digitSubstitution; // 0xCC
	internal bool isReadOnly; // 0xD0
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; // 0xD1
	[OptionalField(VersionAdded = 2)]
	internal bool m_isInvariant; // 0xD2
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsNumber; // 0xD3
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsCurrency; // 0xD4
	private const NumberStyles InvalidNumberStyles = -1024;

	// Properties
	public static NumberFormatInfo InvariantInfo { get; }
	public int CurrencyDecimalDigits { get; }
	public string CurrencyDecimalSeparator { get; }
	public bool IsReadOnly { get; }
	public int[] CurrencyGroupSizes { get; }
	public int[] NumberGroupSizes { get; }
	public int[] PercentGroupSizes { get; }
	public string CurrencyGroupSeparator { get; }
	public string CurrencySymbol { get; }
	public static NumberFormatInfo CurrentInfo { get; }
	public string NaNSymbol { get; set; }
	public int CurrencyNegativePattern { get; }
	public int NumberNegativePattern { get; }
	public int PercentPositivePattern { get; }
	public int PercentNegativePattern { get; }
	public string NegativeInfinitySymbol { get; }
	public string NegativeSign { get; }
	public int NumberDecimalDigits { get; }
	public string NumberDecimalSeparator { get; }
	public string NumberGroupSeparator { get; }
	public int CurrencyPositivePattern { get; }
	public string PositiveInfinitySymbol { get; }
	public string PositiveSign { get; }
	public int PercentDecimalDigits { get; }
	public string PercentDecimalSeparator { get; }
	public string PercentGroupSeparator { get; }
	public string PercentSymbol { get; }
	public string PerMilleSymbol { get; }

	// Methods

	// RVA: 0x145D1A0 Offset: 0x145B7A0 VA: 0x18145D1A0
	public void .ctor() { }

	[OnSerializing]
	// RVA: 0x145CDF0 Offset: 0x145B3F0 VA: 0x18145CDF0
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializing]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x145D1B0 Offset: 0x145B7B0 VA: 0x18145D1B0
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x145D120 Offset: 0x145B720 VA: 0x18145D120
	private void VerifyWritable() { }

	// RVA: 0x145D900 Offset: 0x145BF00 VA: 0x18145D900
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x145CB50 Offset: 0x145B150 VA: 0x18145CB50
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x145CA60 Offset: 0x145B060 VA: 0x18145CA60 Slot: 4
	public object Clone() { }

	// RVA: 0x3A35F0 Offset: 0x3A1BF0 VA: 0x1803A35F0
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0x47E990 Offset: 0x47CF90 VA: 0x18047E990
	public bool get_IsReadOnly() { }

	// RVA: 0x145D780 Offset: 0x145BD80 VA: 0x18145D780
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x145DA20 Offset: 0x145C020 VA: 0x18145DA20
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x145DAC0 Offset: 0x145C0C0 VA: 0x18145DAC0
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public string get_CurrencySymbol() { }

	// RVA: 0x145D800 Offset: 0x145BE00 VA: 0x18145D800
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public string get_NaNSymbol() { }

	// RVA: 0x145DB50 Offset: 0x145C150 VA: 0x18145DB50
	public void set_NaNSymbol(string value) { }

	// RVA: 0x3A3470 Offset: 0x3A1A70 VA: 0x1803A3470
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x145DAA0 Offset: 0x145C0A0 VA: 0x18145DAA0
	public int get_NumberNegativePattern() { }

	// RVA: 0x145DB40 Offset: 0x145C140 VA: 0x18145DB40
	public int get_PercentPositivePattern() { }

	// RVA: 0x12ECAA0 Offset: 0x12EB0A0 VA: 0x1812ECAA0
	public int get_PercentNegativePattern() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_NegativeSign() { }

	// RVA: 0x3A3480 Offset: 0x3A1A80 VA: 0x1803A3480
	public int get_NumberDecimalDigits() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_NumberGroupSeparator() { }

	// RVA: 0x3A35B0 Offset: 0x3A1BB0 VA: 0x1803A35B0
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_PositiveSign() { }

	// RVA: 0x145DAB0 Offset: 0x145C0B0 VA: 0x18145DAB0
	public int get_PercentDecimalDigits() { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	public string get_PercentGroupSeparator() { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public string get_PercentSymbol() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public string get_PerMilleSymbol() { }

	// RVA: 0x145CAD0 Offset: 0x145B0D0 VA: 0x18145CAD0 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x145CE80 Offset: 0x145B480 VA: 0x18145CE80
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x145D030 Offset: 0x145B630 VA: 0x18145D030
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x145CF50 Offset: 0x145B550 VA: 0x18145CF50
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class StringInfo // TypeDefIndex: 1375
{
	// Fields
	[OptionalField(VersionAdded = 2)]
	private string m_str; // 0x10
	private int[] m_indexes; // 0x18

	// Properties
	private int[] Indexes { get; }
	public string String { get; set; }
	public int LengthInTextElements { get; }

	// Methods

	// RVA: 0x145E160 Offset: 0x145C760 VA: 0x18145E160
	public void .ctor() { }

	// RVA: 0x145E0B0 Offset: 0x145C6B0 VA: 0x18145E0B0
	public void .ctor(string value) { }

	[OnDeserializing]
	// RVA: 0x145DE50 Offset: 0x145C450 VA: 0x18145DE50
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x145DE10 Offset: 0x145C410 VA: 0x18145DE10
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisible(False)]
	// RVA: 0x145DC40 Offset: 0x145C240 VA: 0x18145DC40 Slot: 0
	public override bool Equals(object value) { }

	[ComVisible(False)]
	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x145E240 Offset: 0x145C840 VA: 0x18145E240
	private int[] get_Indexes() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_String() { }

	// RVA: 0x145E2F0 Offset: 0x145C8F0 VA: 0x18145E2F0
	public void set_String(string value) { }

	// RVA: 0x145E290 Offset: 0x145C890 VA: 0x18145E290
	public int get_LengthInTextElements() { }

	// RVA: 0x145DCD0 Offset: 0x145C2D0 VA: 0x18145DCD0
	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	// RVA: 0x145DE70 Offset: 0x145C470 VA: 0x18145DE70
	public static int[] ParseCombiningCharacters(string str) { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class TaiwanCalendar : Calendar // TypeDefIndex: 1376
{
	// Fields
	internal static EraInfo[] taiwanEraInfo; // 0x0
	internal static Calendar s_defaultInstance; // 0x8
	internal GregorianCalendarHelper helper; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x145E3A0 Offset: 0x145C9A0 VA: 0x18145E3A0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x145E9B0 Offset: 0x145CFB0 VA: 0x18145E9B0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x145E960 Offset: 0x145CF60 VA: 0x18145E960 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x145E7E0 Offset: 0x145CDE0 VA: 0x18145E7E0
	public void .ctor() { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x145BC60 Offset: 0x145A260 VA: 0x18145BC60 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x145BC90 Offset: 0x145A290 VA: 0x18145BC90 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x145BC20 Offset: 0x145A220 VA: 0x18145BC20 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x145BC40 Offset: 0x145A240 VA: 0x18145BC40 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x145C3C0 Offset: 0x145A9C0 VA: 0x18145C3C0 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x145C380 Offset: 0x145A980 VA: 0x18145C380 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x145C3A0 Offset: 0x145A9A0 VA: 0x18145C3A0 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x145C3F0 Offset: 0x145A9F0 VA: 0x18145C3F0 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x145C410 Offset: 0x145AA10 VA: 0x18145C410 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x145C460 Offset: 0x145AA60 VA: 0x18145C460 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x145C7F0 Offset: 0x145ADF0 VA: 0x18145C7F0 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x145C8B0 Offset: 0x145AEB0 VA: 0x18145C8B0 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x145EA00 Offset: 0x145D000 VA: 0x18145EA00 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x145E490 Offset: 0x145CA90 VA: 0x18145E490 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x145E620 Offset: 0x145CC20 VA: 0x18145E620
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 1377
{
	// Fields
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x10
	[OptionalField(VersionAdded = 3)]
	private string m_cultureName; // 0x18
	private CultureData m_cultureData; // 0x20
	private string m_textInfoName; // 0x28
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant; // 0x30
	internal static TextInfo s_Invariant; // 0x0
	[OptionalField(VersionAdded = 2)]
	private string customCultureName; // 0x38
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; // 0x40
	[OptionalField(VersionAdded = 1)]
	internal int m_win32LangID; // 0x44

	// Properties
	internal static TextInfo Invariant { get; }
	[ComVisible(False)]
	public string CultureName { get; }
	private bool IsAsciiCasingSameAsInvariant { get; }

	// Methods

	// RVA: 0x1460140 Offset: 0x145E740 VA: 0x181460140
	internal static TextInfo get_Invariant() { }

	// RVA: 0x14600A0 Offset: 0x145E6A0 VA: 0x1814600A0
	internal void .ctor(CultureData cultureData) { }

	[OnDeserializing]
	// RVA: 0x145EF30 Offset: 0x145D530 VA: 0x18145EF30
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x145EDF0 Offset: 0x145D3F0 VA: 0x18145EDF0
	private void OnDeserialized() { }

	[OnDeserialized]
	// RVA: 0x145EF20 Offset: 0x145D520 VA: 0x18145EF20
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x145EF70 Offset: 0x145D570 VA: 0x18145EF70
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_CultureName() { }

	[ComVisible(False)]
	// RVA: 0x145EC90 Offset: 0x145D290 VA: 0x18145EC90 Slot: 6
	public virtual object Clone() { }

	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x145F5E0 Offset: 0x145DBE0 VA: 0x18145F5E0 Slot: 7
	public virtual char ToLower(char c) { }

	// RVA: 0x145F640 Offset: 0x145DC40 VA: 0x18145F640 Slot: 8
	public virtual string ToLower(string str) { }

	// RVA: 0x145F010 Offset: 0x145D610 VA: 0x18145F010
	private static char ToLowerAsciiInvariant(char c) { }

	// RVA: 0x1460040 Offset: 0x145E640 VA: 0x181460040 Slot: 9
	public virtual char ToUpper(char c) { }

	// RVA: 0x145FF20 Offset: 0x145E520 VA: 0x18145FF20 Slot: 10
	public virtual string ToUpper(string str) { }

	// RVA: 0x145F860 Offset: 0x145DE60 VA: 0x18145F860
	internal static char ToUpperAsciiInvariant(char c) { }

	// RVA: 0x145EDE0 Offset: 0x145D3E0 VA: 0x18145EDE0
	private static bool IsAscii(char c) { }

	// RVA: 0x1460250 Offset: 0x145E850 VA: 0x181460250
	private bool get_IsAsciiCasingSameAsInvariant() { }

	// RVA: 0x145ED20 Offset: 0x145D320 VA: 0x18145ED20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x145EDB0 Offset: 0x145D3B0 VA: 0x18145EDB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x145F760 Offset: 0x145DD60 VA: 0x18145F760 Slot: 3
	public override string ToString() { }

	// RVA: 0x145EF20 Offset: 0x145D520 VA: 0x18145EF20 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x145FE40 Offset: 0x145E440 VA: 0x18145FE40
	private string ToUpperInternal(string str) { }

	// RVA: 0x145F500 Offset: 0x145DB00 VA: 0x18145F500
	private string ToLowerInternal(string str) { }

	// RVA: 0x145F880 Offset: 0x145DE80 VA: 0x18145F880
	private char ToUpperInternal(char c) { }

	// RVA: 0x145F030 Offset: 0x145D630 VA: 0x18145F030
	private char ToLowerInternal(char c) { }

	// RVA: 0x145F7B0 Offset: 0x145DDB0 VA: 0x18145F7B0
	internal void ToUpperAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination) { }

	// RVA: 0x145EB40 Offset: 0x145D140 VA: 0x18145EB40
	internal void ChangeCase(ReadOnlySpan<char> source, Span<char> destination, bool toUpper) { }

	// RVA: 0x1460110 Offset: 0x145E710 VA: 0x181460110
	internal void .ctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class ThaiBuddhistCalendar : Calendar // TypeDefIndex: 1378
{
	// Fields
	internal static EraInfo[] thaiBuddhistEraInfo; // 0x0
	internal GregorianCalendarHelper helper; // 0x20

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x1460670 Offset: 0x145EC70 VA: 0x181460670 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1460620 Offset: 0x145EC20 VA: 0x181460620 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1460560 Offset: 0x145EB60 VA: 0x181460560
	public void .ctor() { }

	// RVA: 0x4565D0 Offset: 0x454BD0 VA: 0x1804565D0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x145BC60 Offset: 0x145A260 VA: 0x18145BC60 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x145BC90 Offset: 0x145A290 VA: 0x18145BC90 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x145BC20 Offset: 0x145A220 VA: 0x18145BC20 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x145BC40 Offset: 0x145A240 VA: 0x18145BC40 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x145C3C0 Offset: 0x145A9C0 VA: 0x18145C3C0 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x145C380 Offset: 0x145A980 VA: 0x18145C380 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x145C3A0 Offset: 0x145A9A0 VA: 0x18145C3A0 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x145C3F0 Offset: 0x145A9F0 VA: 0x18145C3F0 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x145C410 Offset: 0x145AA10 VA: 0x18145C410 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x145C460 Offset: 0x145AA60 VA: 0x18145C460 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x145C7F0 Offset: 0x145ADF0 VA: 0x18145C7F0 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x14606C0 Offset: 0x145ECC0 VA: 0x1814606C0 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1460730 Offset: 0x145ED30 VA: 0x181460730 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1460330 Offset: 0x145E930 VA: 0x181460330 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x14603F0 Offset: 0x145E9F0 VA: 0x1814603F0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[Serializable]
public class UmAlQuraCalendar : Calendar // TypeDefIndex: 1380
{
	// Fields
	private static readonly UmAlQuraCalendar.DateMapping[] HijriYearInfo; // 0x0
	internal static DateTime minDate; // 0x8
	internal static DateTime maxDate; // 0x10

	// Properties
	public override DateTime MinSupportedDateTime { get; }
	public override DateTime MaxSupportedDateTime { get; }
	internal override int BaseCalendarID { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x146A500 Offset: 0x1468B00 VA: 0x18146A500
	private static UmAlQuraCalendar.DateMapping[] InitDateMapping() { }

	// RVA: 0x146AEF0 Offset: 0x14694F0 VA: 0x18146AEF0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x146AEA0 Offset: 0x14694A0 VA: 0x18146AEA0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x14542B0 Offset: 0x14528B0 VA: 0x1814542B0
	public void .ctor() { }

	// RVA: 0x45C3F0 Offset: 0x45A9F0 VA: 0x18045C3F0 Slot: 8
	internal override int get_BaseCalendarID() { }

	// RVA: 0x146AE90 Offset: 0x1469490 VA: 0x18146AE90 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x1469D40 Offset: 0x1468340 VA: 0x181469D40
	private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg) { }

	// RVA: 0x1469EB0 Offset: 0x14684B0 VA: 0x181469EB0
	private static long GetAbsoluteDateUmAlQura(int year, int month, int day) { }

	// RVA: 0x14695B0 Offset: 0x1467BB0 VA: 0x1814695B0
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x1469520 Offset: 0x1467B20 VA: 0x181469520
	internal static void CheckEraRange(int era) { }

	// RVA: 0x1469880 Offset: 0x1467E80 VA: 0x181469880
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x14697B0 Offset: 0x1467DB0 VA: 0x1814697B0
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x1469A30 Offset: 0x1468030 VA: 0x181469A30
	private static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay) { }

	// RVA: 0x146A070 Offset: 0x1468670 VA: 0x18146A070 Slot: 31
	internal virtual int GetDatePart(DateTime time, int part) { }

	// RVA: 0x146A220 Offset: 0x1468820 VA: 0x18146A220 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x146A240 Offset: 0x1468840 VA: 0x18146A240 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x146A2C0 Offset: 0x14688C0 VA: 0x18146A2C0 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x146A6E0 Offset: 0x1468CE0 VA: 0x18146A6E0
	internal static int RealGetDaysInYear(int year) { }

	// RVA: 0x146A380 Offset: 0x1468980 VA: 0x18146A380 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x146A3E0 Offset: 0x14689E0 VA: 0x18146A3E0 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x146AE30 Offset: 0x1469430 VA: 0x18146AE30 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x146A460 Offset: 0x1468A60 VA: 0x18146A460 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x146A480 Offset: 0x1468A80 VA: 0x18146A480 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x146A4E0 Offset: 0x1468AE0 VA: 0x18146A4E0 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x146A670 Offset: 0x1468C70 VA: 0x18146A670 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x146A780 Offset: 0x1468D80 VA: 0x18146A780 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x145B8E0 Offset: 0x1459EE0 VA: 0x18145B8E0 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x146AF40 Offset: 0x1469540 VA: 0x18146AF40 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x146A9E0 Offset: 0x1468FE0 VA: 0x18146A9E0 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x146AB70 Offset: 0x1469170 VA: 0x18146AB70
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class SortKey // TypeDefIndex: 1381
{
	// Fields
	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	// Properties
	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }

	// Methods

	// RVA: 0x149EBB0 Offset: 0x149D1B0 VA: 0x18149EBB0
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x149F1D0 Offset: 0x149D7D0 VA: 0x18149F1D0
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x149F110 Offset: 0x149D710 VA: 0x18149F110
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x149F180 Offset: 0x149D780 VA: 0x18149F180
	internal void .ctor(string localeName, string str, CompareOptions options, byte[] keyData) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x149EDC0 Offset: 0x149D3C0 VA: 0x18149EDC0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x149EF40 Offset: 0x149D540 VA: 0x18149EF40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x149EFB0 Offset: 0x149D5B0 VA: 0x18149EFB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x149F2B0 Offset: 0x149D8B0 VA: 0x18149F2B0
	internal void .ctor() { }
}

// Namespace: System.Globalization
internal interface ISimpleCollator // TypeDefIndex: 1382
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SortKey GetSortKey(string source, CompareOptions options);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsPrefix(string src, string target, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsSuffix(string src, string target, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int IndexOf(string s, string target, int start, int length, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int LastIndexOf(string s, string target, int start, int length, CompareOptions opt);
}

// Namespace: System.Globalization
internal class CultureData // TypeDefIndex: 1384
{
	// Fields
	private string sAM1159; // 0x10
	private string sPM2359; // 0x18
	private string sTimeSeparator; // 0x20
	private string[] saLongTimes; // 0x28
	private string[] saShortTimes; // 0x30
	private int iFirstDayOfWeek; // 0x38
	private int iFirstWeekOfYear; // 0x3C
	private int[] waCalendars; // 0x40
	private CalendarData[] calendars; // 0x48
	private string sISO639Language; // 0x50
	private readonly string sRealName; // 0x58
	private bool bUseOverrides; // 0x60
	private int calendarId; // 0x64
	private int numberIndex; // 0x68
	private int iDefaultAnsiCodePage; // 0x6C
	private int iDefaultOemCodePage; // 0x70
	private int iDefaultMacCodePage; // 0x74
	private int iDefaultEbcdicCodePage; // 0x78
	private bool isRightToLeft; // 0x7C
	private string sListSeparator; // 0x80
	private static CultureData s_Invariant; // 0x0

	// Properties
	public static CultureData Invariant { get; }
	internal string[] LongTimes { get; }
	internal string[] ShortTimes { get; }
	internal string SISO639LANGNAME { get; }
	internal int IFIRSTDAYOFWEEK { get; }
	internal int IFIRSTWEEKOFYEAR { get; }
	internal string SAM1159 { get; }
	internal string SPM2359 { get; }
	internal string TimeSeparator { get; }
	internal int[] CalendarIds { get; }
	internal bool IsInvariantCulture { get; }
	internal string CultureName { get; }
	internal string SCOMPAREINFO { get; }
	internal string STEXTINFO { get; }
	internal bool UseUserOverride { get; }

	// Methods

	// RVA: 0x148DF00 Offset: 0x148C500 VA: 0x18148DF00
	private void .ctor(string name) { }

	// RVA: 0x148E1C0 Offset: 0x148C7C0 VA: 0x18148E1C0
	public static CultureData get_Invariant() { }

	// RVA: 0x148D3A0 Offset: 0x148B9A0 VA: 0x18148D3A0
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x148D280 Offset: 0x148B880 VA: 0x18148D280
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x148DFF0 Offset: 0x148C5F0 VA: 0x18148DFF0
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x148D140 Offset: 0x148B740 VA: 0x18148D140
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0x995FE0 Offset: 0x9945E0 VA: 0x180995FE0
	internal string[] get_LongTimes() { }

	// RVA: 0x148E600 Offset: 0x148CC00 VA: 0x18148E600
	internal string[] get_ShortTimes() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal string get_SAM1159() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal string get_SPM2359() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal string get_TimeSeparator() { }

	// RVA: 0x148E010 Offset: 0x148C610 VA: 0x18148E010
	internal int[] get_CalendarIds() { }

	// RVA: 0x148CED0 Offset: 0x148B4D0 VA: 0x18148CED0
	internal CalendarId[] GetCalendarIds() { }

	// RVA: 0x148E5C0 Offset: 0x148CBC0 VA: 0x18148E5C0
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal string get_CultureName() { }

	// RVA: 0x148E5D0 Offset: 0x148CBD0 VA: 0x18148E5D0
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal string get_STEXTINFO() { }

	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810
	internal bool get_UseUserOverride() { }

	// RVA: 0x148CE90 Offset: 0x148B490 VA: 0x18148CE90
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x148CCF0 Offset: 0x148B2F0 VA: 0x18148CCF0
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x148CD30 Offset: 0x148B330 VA: 0x18148CD30
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x148DD20 Offset: 0x148C320 VA: 0x18148DD20
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x148DCC0 Offset: 0x148C2C0 VA: 0x18148DCC0
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x148DEE0 Offset: 0x148C4E0 VA: 0x18148DEE0
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x148CE70 Offset: 0x148B470 VA: 0x18148CE70
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x148CD10 Offset: 0x148B310 VA: 0x18148CD10
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x148DD00 Offset: 0x148C300 VA: 0x18148DD00
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x148CEB0 Offset: 0x148B4B0 VA: 0x18148CEB0
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x148CD80 Offset: 0x148B380 VA: 0x18148CD80
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x148CD50 Offset: 0x148B350 VA: 0x18148CD50
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x148DC90 Offset: 0x148C290 VA: 0x18148DC90
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x148DCE0 Offset: 0x148C2E0 VA: 0x18148DCE0
	internal string MonthDay(int calendarId) { }

	// RVA: 0x148CDA0 Offset: 0x148B3A0 VA: 0x18148CDA0
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x148D420 Offset: 0x148BA20 VA: 0x18148D420
	private static string GetDateSeparator(string format) { }

	// RVA: 0x148D9C0 Offset: 0x148BFC0 VA: 0x18148D9C0
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x148DBA0 Offset: 0x148C1A0 VA: 0x18148DBA0
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x148DD40 Offset: 0x148C340 VA: 0x18148DD40
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x148E690 Offset: 0x148CC90 VA: 0x18148E690
	private static int strlen(byte* s) { }

	// RVA: 0x148E620 Offset: 0x148CC20 VA: 0x18148E620
	private static string idx2string(byte* data, int idx) { }

	// RVA: 0x148DF40 Offset: 0x148C540 VA: 0x18148DF40
	private int[] create_group_sizes_array(int gs0, int gs1) { }

	// RVA: 0x148D460 Offset: 0x148BA60 VA: 0x18148D460
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x148E000 Offset: 0x148C600 VA: 0x18148E000
	private static byte* fill_number_data(int index, ref CultureData.NumberFormatEntryManaged nfe) { }
}

// Namespace: System.Globalization
[Serializable]
internal class CodePageDataItem // TypeDefIndex: 1385
{
	// Fields
	internal int m_dataIndex; // 0x10
	internal int m_uiFamilyCodePage; // 0x14
	internal string m_webName; // 0x18
	internal uint m_flags; // 0x20
	private static readonly char[] sep; // 0x0

	// Properties
	public string WebName { get; }

	// Methods

	// RVA: 0x148CAE0 Offset: 0x148B0E0 VA: 0x18148CAE0
	internal void .ctor(int dataIndex) { }

	// RVA: 0x148C9A0 Offset: 0x148AFA0 VA: 0x18148C9A0
	internal static string CreateString(string pStrings, uint index) { }

	// RVA: 0x148CBA0 Offset: 0x148B1A0 VA: 0x18148CBA0
	public string get_WebName() { }

	// RVA: 0x148CA50 Offset: 0x148B050 VA: 0x18148CA50
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal static class EncodingTable // TypeDefIndex: 1386
{
	// Fields
	internal static InternalEncodingDataItem[] encodingDataPtr; // 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; // 0x8
	private static int lastEncodingItem; // 0x10
	private static Dictionary<string, int> hashByName; // 0x18
	private static Dictionary<int, CodePageDataItem> hashByCodePage; // 0x20

	// Methods

	// RVA: 0x1494260 Offset: 0x1492860 VA: 0x181494260
	private static int GetNumEncodingItems() { }

	// RVA: 0x1493D20 Offset: 0x1492320 VA: 0x181493D20
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x14942C0 Offset: 0x14928C0 VA: 0x1814942C0
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x1494300 Offset: 0x1492900 VA: 0x181494300
	private static void .cctor() { }

	// RVA: 0x149E930 Offset: 0x149CF30 VA: 0x18149E930
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x1494020 Offset: 0x1492620 VA: 0x181494020
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x1493D60 Offset: 0x1492360 VA: 0x181493D60
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }
}

// Namespace: System.Globalization
internal struct InternalEncodingDataItem // TypeDefIndex: 1387
{
	// Fields
	internal string webName; // 0x0
	internal ushort codePage; // 0x8
}

// Namespace: System.Globalization
internal struct InternalCodePageDataItem // TypeDefIndex: 1388
{
	// Fields
	internal ushort codePage; // 0x0
	internal ushort uiFamilyCodePage; // 0x2
	internal uint flags; // 0x4
	internal string Names; // 0x8
}

// Namespace: System.Globalization
internal static class TextInfoToUpperData // TypeDefIndex: 1389
{
	// Fields
	public static readonly char[] range_00e0_0586; // 0x0
	public static readonly char[] range_1e01_1ff3; // 0x8
	public static readonly char[] range_2170_2184; // 0x10
	public static readonly char[] range_24d0_24e9; // 0x18
	public static readonly char[] range_2c30_2ce3; // 0x20
	public static readonly char[] range_2d00_2d25; // 0x28
	public static readonly char[] range_a641_a697; // 0x30
	public static readonly char[] range_a723_a78c; // 0x38

	// Methods

	// RVA: 0x149F660 Offset: 0x149DC60 VA: 0x18149F660
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal static class TextInfoToLowerData // TypeDefIndex: 1390
{
	// Fields
	public static readonly char[] range_00c0_0556; // 0x0
	public static readonly char[] range_10a0_10c5; // 0x8
	public static readonly char[] range_1e00_1ffc; // 0x10
	public static readonly char[] range_2160_216f; // 0x18
	public static readonly char[] range_24b6_24cf; // 0x20
	public static readonly char[] range_2c00_2c2e; // 0x28
	public static readonly char[] range_2c60_2ce2; // 0x30
	public static readonly char[] range_a640_a696; // 0x38
	public static readonly char[] range_a722_a78b; // 0x40

	// Methods

	// RVA: 0x149F2E0 Offset: 0x149D8E0 VA: 0x18149F2E0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 1393
{
	// Fields
	private static CultureInfo invariant_culture_info; // 0x0
	private static object shared_table_lock; // 0x8
	private static CultureInfo default_current_culture; // 0x10
	private bool m_isReadOnly; // 0x10
	private int cultureID; // 0x14
	private int parent_lcid; // 0x18
	private int datetime_index; // 0x1C
	private int number_index; // 0x20
	private int default_calendar_type; // 0x24
	private bool m_useUserOverride; // 0x28
	internal NumberFormatInfo numInfo; // 0x30
	internal DateTimeFormatInfo dateTimeInfo; // 0x38
	private TextInfo textInfo; // 0x40
	internal string m_name; // 0x48
	private string englishname; // 0x50
	private string nativename; // 0x58
	private string iso3lang; // 0x60
	private string iso2lang; // 0x68
	private string win3lang; // 0x70
	private string territory; // 0x78
	private string[] native_calendar_names; // 0x80
	private CompareInfo compareInfo; // 0x88
	private readonly void* textinfo_data; // 0x90
	private int m_dataItem; // 0x98
	private Calendar calendar; // 0xA0
	private CultureInfo parent_culture; // 0xA8
	private bool constructed; // 0xB0
	internal byte[] cached_serialized_form; // 0xB8
	internal CultureData m_cultureData; // 0xC0
	internal bool m_isInherited; // 0xC8
	internal const int InvariantCultureId = 127;
	private const int CalendarTypeBits = 8;
	internal const int LOCALE_INVARIANT = 127;
	private const string MSG_READONLY = "This instance is read only";
	private static CultureInfo s_DefaultThreadCurrentUICulture; // 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; // 0x20
	private static Dictionary<int, CultureInfo> shared_by_number; // 0x28
	private static Dictionary<string, CultureInfo> shared_by_name; // 0x30
	private static CultureInfo s_UserPreferredCultureInfoInAppX; // 0x38
	internal static readonly bool IsTaiwanSku; // 0x40

	// Properties
	internal CultureData _cultureData { get; }
	internal bool _isInherited { get; }
	public static CultureInfo InvariantCulture { get; }
	public static CultureInfo CurrentCulture { get; }
	public static CultureInfo CurrentUICulture { get; }
	internal string Territory { get; }
	internal string _name { get; }
	public virtual int LCID { get; }
	public virtual string Name { get; }
	public virtual Calendar Calendar { get; }
	public virtual CultureInfo Parent { get; }
	public virtual TextInfo TextInfo { get; }
	public virtual string TwoLetterISOLanguageName { get; }
	public virtual CompareInfo CompareInfo { get; }
	public virtual bool IsNeutralCulture { get; }
	public virtual NumberFormatInfo NumberFormat { get; set; }
	public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
	public virtual string EnglishName { get; }
	internal int CalendarType { get; }
	public static CultureInfo DefaultThreadCurrentCulture { get; }
	public static CultureInfo DefaultThreadCurrentUICulture { get; }
	internal string SortName { get; }
	internal static CultureInfo UserDefaultUICulture { get; }
	internal static CultureInfo UserDefaultCulture { get; }

	// Methods

	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	internal CultureData get__cultureData() { }

	// RVA: 0x14938F0 Offset: 0x1491EF0 VA: 0x1814938F0
	internal bool get__isInherited() { }

	// RVA: 0x1493280 Offset: 0x1491880 VA: 0x181493280
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x1492F90 Offset: 0x1491590 VA: 0x181492F90
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x1492FC0 Offset: 0x14915C0 VA: 0x181492FC0
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x148E880 Offset: 0x148CE80 VA: 0x18148E880
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x148EA70 Offset: 0x148D070 VA: 0x18148EA70
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	internal string get_Territory() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal string get__name() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30 Slot: 6
	public virtual int get_LCID() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x1492DB0 Offset: 0x14913B0 VA: 0x181492DB0 Slot: 8
	public virtual Calendar get_Calendar() { }

	// RVA: 0x14933D0 Offset: 0x14919D0 VA: 0x1814933D0 Slot: 9
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x14936A0 Offset: 0x1491CA0 VA: 0x1814936A0 Slot: 10
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x14937F0 Offset: 0x1491DF0 VA: 0x1814937F0 Slot: 11
	public virtual string get_TwoLetterISOLanguageName() { }

	// RVA: 0x148E6B0 Offset: 0x148CCB0 VA: 0x18148E6B0 Slot: 12
	public virtual object Clone() { }

	// RVA: 0x1491610 Offset: 0x148FC10 VA: 0x181491610 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1491C50 Offset: 0x1490250 VA: 0x181491C50
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	// RVA: 0x1492130 Offset: 0x1490730 VA: 0x181492130
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x1492120 Offset: 0x1490720 VA: 0x181492120 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1492E50 Offset: 0x1491450 VA: 0x181492E50 Slot: 13
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x14932E0 Offset: 0x14918E0 VA: 0x1814932E0 Slot: 14
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void CheckNeutral() { }

	// RVA: 0x1493320 Offset: 0x1491920 VA: 0x181493320 Slot: 15
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x1493BE0 Offset: 0x14921E0 VA: 0x181493BE0 Slot: 16
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x1492FF0 Offset: 0x14915F0 VA: 0x181492FF0 Slot: 17
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x1493AF0 Offset: 0x14920F0 VA: 0x181493AF0 Slot: 18
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x1493240 Offset: 0x1491840 VA: 0x181493240 Slot: 19
	public virtual string get_EnglishName() { }

	// RVA: 0x1492020 Offset: 0x1490620 VA: 0x181492020 Slot: 20
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x148ED30 Offset: 0x148D330 VA: 0x18148ED30
	private void Construct() { }

	// RVA: 0x1492CF0 Offset: 0x14912F0 VA: 0x181492CF0
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x1492D00 Offset: 0x1491300 VA: 0x181492D00
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x1493900 Offset: 0x1491F00 VA: 0x181493900
	private static string get_current_locale_name() { }

	// RVA: 0x1493AE0 Offset: 0x14920E0 VA: 0x181493AE0
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	// RVA: 0x148EAB0 Offset: 0x148D0B0 VA: 0x18148EAB0
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x1491590 Offset: 0x148FB90 VA: 0x181491590
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x1492CD0 Offset: 0x14912D0 VA: 0x181492CD0
	public void .ctor(int culture) { }

	// RVA: 0x1492960 Offset: 0x1490F60 VA: 0x181492960
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x1492980 Offset: 0x1490F80 VA: 0x181492980
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x1492920 Offset: 0x1490F20 VA: 0x181492920
	public void .ctor(string name) { }

	// RVA: 0x1492CB0 Offset: 0x14912B0 VA: 0x181492CB0
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x1492640 Offset: 0x1490C40 VA: 0x181492640
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x1492940 Offset: 0x1490F40 VA: 0x181492940
	private void .ctor() { }

	// RVA: 0x1493910 Offset: 0x1491F10 VA: 0x181493910
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x1491790 Offset: 0x148FD90 VA: 0x181491790
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x14919F0 Offset: 0x148FFF0 VA: 0x1814919F0
	public static CultureInfo GetCultureInfo(string name) { }

	// RVA: 0x148EF60 Offset: 0x148D560 VA: 0x18148EF60
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x1491270 Offset: 0x148F870 VA: 0x181491270
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x148EC90 Offset: 0x148D290 VA: 0x18148EC90
	private bool ConstructLocaleFromName(string name) { }

	// RVA: 0x148F090 Offset: 0x148D690 VA: 0x18148F090
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x1492D10 Offset: 0x1491310 VA: 0x181492D10
	internal int get_CalendarType() { }

	// RVA: 0x148ED50 Offset: 0x148D350 VA: 0x18148ED50
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x148EFF0 Offset: 0x148D5F0 VA: 0x18148EFF0
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x1493180 Offset: 0x1491780 VA: 0x181493180
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x14931E0 Offset: 0x14917E0 VA: 0x1814931E0
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal string get_SortName() { }

	// RVA: 0x1493870 Offset: 0x1491E70 VA: 0x181493870
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x1493830 Offset: 0x1491E30 VA: 0x181493830
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x1492150 Offset: 0x1490750 VA: 0x181492150
	private static extern void InitializeUserPreferredCultureInfoInAppX(CultureInfo.OnCultureInfoChangedDelegate onCultureInfoChangedInAppX) { }

	[MonoPInvokeCallback(typeof(CultureInfo.OnCultureInfoChangedDelegate))]
	// RVA: 0x1492170 Offset: 0x1490770 VA: 0x181492170
	private static void OnCultureInfoChangedInAppX(string language) { }

	// RVA: 0x14916A0 Offset: 0x148FCA0 VA: 0x1814916A0
	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX() { }

	// RVA: 0x1492250 Offset: 0x1490850 VA: 0x181492250
	private static void .cctor() { }
}

// Namespace: System.Globalization
public sealed class IdnMapping // TypeDefIndex: 1394
{
	// Fields
	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18

	// Methods

	// RVA: 0x14AC650 Offset: 0x14AAC50 VA: 0x1814AC650
	public void .ctor() { }

	// RVA: 0x14AB600 Offset: 0x14A9C00 VA: 0x1814AB600 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14AB870 Offset: 0x14A9E70 VA: 0x1814AB870 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14AB680 Offset: 0x14A9C80 VA: 0x1814AB680
	public string GetAscii(string unicode) { }

	// RVA: 0x14AB750 Offset: 0x14A9D50 VA: 0x1814AB750
	public string GetAscii(string unicode, int index, int count) { }

	// RVA: 0x14AB400 Offset: 0x14A9A00 VA: 0x1814AB400
	private string Convert(string input, int index, int count, bool toAscii) { }

	// RVA: 0x14ABBA0 Offset: 0x14AA1A0 VA: 0x1814ABBA0
	private string ToAscii(string s, int offset) { }

	// RVA: 0x14AC0C0 Offset: 0x14AA6C0 VA: 0x1814AC0C0
	private void VerifyLength(string s, int offset) { }

	// RVA: 0x14ABA80 Offset: 0x14AA080 VA: 0x1814ABA80
	private string NamePrep(string s, int offset) { }

	// RVA: 0x14AC1F0 Offset: 0x14AA7F0 VA: 0x1814AC1F0
	private void VerifyProhibitedCharacters(string s, int offset) { }

	// RVA: 0x14AC3F0 Offset: 0x14AA9F0 VA: 0x1814AC3F0
	private void VerifyStd3AsciiRules(string s, int offset) { }

	// RVA: 0x14AB9B0 Offset: 0x14A9FB0 VA: 0x1814AB9B0
	public string GetUnicode(string ascii) { }

	// RVA: 0x14AB890 Offset: 0x14A9E90 VA: 0x1814AB890
	public string GetUnicode(string ascii, int index, int count) { }

	// RVA: 0x14ABF00 Offset: 0x14AA500 VA: 0x1814ABF00
	private string ToUnicode(string s, int offset) { }
}

// Namespace: System.Globalization
internal class Bootstring // TypeDefIndex: 1395
{
	// Fields
	private readonly char delimiter; // 0x10
	private readonly int base_num; // 0x14
	private readonly int tmin; // 0x18
	private readonly int tmax; // 0x1C
	private readonly int skew; // 0x20
	private readonly int damp; // 0x24
	private readonly int initial_bias; // 0x28
	private readonly int initial_n; // 0x2C

	// Methods

	// RVA: 0x14A3710 Offset: 0x14A1D10 VA: 0x1814A3710
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x14A3300 Offset: 0x14A1900 VA: 0x1814A3300
	public string Encode(string s, int offset) { }

	// RVA: 0x14A32E0 Offset: 0x14A18E0 VA: 0x1814A32E0
	private char EncodeDigit(int d) { }

	// RVA: 0x14A3010 Offset: 0x14A1610 VA: 0x1814A3010
	private int DecodeDigit(char c) { }

	// RVA: 0x14A2F90 Offset: 0x14A1590 VA: 0x1814A2F90
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x14A3040 Offset: 0x14A1640 VA: 0x1814A3040
	public string Decode(string s, int offset) { }
}

// Namespace: System.Globalization
internal class Punycode : Bootstring // TypeDefIndex: 1396
{
	// Methods

	// RVA: 0x14AE6C0 Offset: 0x14ACCC0 VA: 0x1814AE6C0
	public void .ctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class RegionInfo // TypeDefIndex: 1397
{
	// Fields
	private static RegionInfo currentRegion; // 0x0
	private int regionId; // 0x10
	private string iso2Name; // 0x18
	private string iso3Name; // 0x20
	private string win3Name; // 0x28
	private string englishName; // 0x30
	private string nativeName; // 0x38
	private string currencySymbol; // 0x40
	private string isoCurrencySymbol; // 0x48
	private string currencyEnglishName; // 0x50
	private string currencyNativeName; // 0x58

	// Properties
	public static RegionInfo CurrentRegion { get; }
	[ComVisible(False)]
	public virtual string CurrencyEnglishName { get; }
	public virtual string CurrencySymbol { get; }
	[MonoTODO("DisplayName currently only returns the EnglishName")]
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	[ComVisible(False)]
	public virtual int GeoId { get; }
	public virtual bool IsMetric { get; }
	public virtual string ISOCurrencySymbol { get; }
	[ComVisible(False)]
	public virtual string NativeName { get; }
	[ComVisible(False)]
	public virtual string CurrencyNativeName { get; }
	public virtual string Name { get; }
	public virtual string ThreeLetterISORegionName { get; }
	public virtual string ThreeLetterWindowsRegionName { get; }
	public virtual string TwoLetterISORegionName { get; }

	// Methods

	// RVA: 0x14B0810 Offset: 0x14AEE10 VA: 0x1814B0810
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x14B0680 Offset: 0x14AEC80 VA: 0x1814B0680
	public void .ctor(int culture) { }

	// RVA: 0x14B02B0 Offset: 0x14AE8B0 VA: 0x1814B02B0
	public void .ctor(string name) { }

	// RVA: 0x14B0470 Offset: 0x14AEA70 VA: 0x1814B0470
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x14B01A0 Offset: 0x14AE7A0 VA: 0x1814B01A0
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x14B0800 Offset: 0x14AEE00 VA: 0x1814B0800
	private bool construct_internal_region_from_name(string name) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 4
	public virtual string get_CurrencyEnglishName() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 5
	public virtual string get_CurrencySymbol() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 6
	public virtual string get_DisplayName() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 7
	public virtual string get_EnglishName() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 8
	public virtual int get_GeoId() { }

	// RVA: 0x14B08E0 Offset: 0x14AEEE0 VA: 0x1814B08E0 Slot: 9
	public virtual bool get_IsMetric() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 10
	public virtual string get_ISOCurrencySymbol() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 11
	public virtual string get_NativeName() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 12
	public virtual string get_CurrencyNativeName() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 13
	public virtual string get_Name() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 14
	public virtual string get_ThreeLetterISORegionName() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x14B00E0 Offset: 0x14AE6E0 VA: 0x1814B00E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x14B0250 Offset: 0x14AE850 VA: 0x1814B0250 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14B0290 Offset: 0x14AE890 VA: 0x1814B0290 Slot: 3
	public override string ToString() { }

	// RVA: 0x14B0090 Offset: 0x14AE690 VA: 0x1814B0090
	internal static void ClearCachedData() { }
}

// Namespace: System.Globalization
internal class FormatProvider // TypeDefIndex: 13644
{
	// Methods

	// RVA: 0x1BAA4E0 Offset: 0x1BA8AE0 VA: 0x181BAA4E0
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x1BAA650 Offset: 0x1BA8C50 VA: 0x181BAA650
	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }
}

