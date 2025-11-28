// Namespace: Mono.Globalization.Unicode
internal class CodePointIndexer // TypeDefIndex: 77
{
	// Fields
	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20

	// Methods

	// RVA: 0x1337F60 Offset: 0x1336560 VA: 0x181337F60
	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	// RVA: 0x1337EC0 Offset: 0x13364C0 VA: 0x181337EC0
	public int ToIndex(int cp) { }
}

// Namespace: Mono.Globalization.Unicode
internal class TailoringInfo // TypeDefIndex: 78
{
	// Fields
	public readonly int LCID; // 0x10
	public readonly int TailoringIndex; // 0x14
	public readonly int TailoringCount; // 0x18
	public readonly bool FrenchSort; // 0x1C

	// Methods

	// RVA: 0xA6C210 Offset: 0xA6A810 VA: 0x180A6C210
	public void .ctor(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort) { }
}

// Namespace: Mono.Globalization.Unicode
internal class Contraction // TypeDefIndex: 79
{
	// Fields
	public int Index; // 0x10
	public readonly char[] Source; // 0x18
	public readonly string Replacement; // 0x20
	public readonly byte[] SortKey; // 0x28

	// Methods

	// RVA: 0x13382C0 Offset: 0x13368C0 VA: 0x1813382C0
	public void .ctor(int index, char[] source, string replacement, byte[] sortkey) { }
}

// Namespace: Mono.Globalization.Unicode
internal class ContractionComparer : IComparer<Contraction> // TypeDefIndex: 80
{
	// Fields
	public static readonly ContractionComparer Instance; // 0x0

	// Methods

	// RVA: 0x1338150 Offset: 0x1336750 VA: 0x181338150 Slot: 4
	public int Compare(Contraction c1, Contraction c2) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1338250 Offset: 0x1336850 VA: 0x181338250
	private static void .cctor() { }
}

// Namespace: Mono.Globalization.Unicode
internal class Level2Map // TypeDefIndex: 81
{
	// Fields
	public byte Source; // 0x10
	public byte Replace; // 0x11

	// Methods

	// RVA: 0x133A310 Offset: 0x1338910 VA: 0x18133A310
	public void .ctor(byte source, byte replace) { }
}

// Namespace: Mono.Globalization.Unicode
internal class MSCompatUnicodeTable // TypeDefIndex: 83
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x133B850 Offset: 0x1339E50 VA: 0x18133B850
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x133A940 Offset: 0x1338F40 VA: 0x18133A940
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x133BEF0 Offset: 0x133A4F0 VA: 0x18133BEF0
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x133B000 Offset: 0x1339600 VA: 0x18133B000
	public static byte Category(int cp) { }

	// RVA: 0x133BCE0 Offset: 0x133A2E0 VA: 0x18133BCE0
	public static byte Level1(int cp) { }

	// RVA: 0x133BD90 Offset: 0x133A390 VA: 0x18133BD90
	public static byte Level2(int cp) { }

	// RVA: 0x133BE40 Offset: 0x133A440 VA: 0x18133BE40
	public static byte Level3(int cp) { }

	// RVA: 0x133BA60 Offset: 0x133A060 VA: 0x18133BA60
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x133BA10 Offset: 0x133A010 VA: 0x18133BA10
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x133C1C0 Offset: 0x133A7C0 VA: 0x18133C1C0
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x133C1E0 Offset: 0x133A7E0 VA: 0x18133C1E0
	public static int ToWidthCompat(int i) { }

	// RVA: 0x133B960 Offset: 0x1339F60 VA: 0x18133B960
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x133B9D0 Offset: 0x1339FD0 VA: 0x18133B9D0
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x133B9F0 Offset: 0x1339FF0 VA: 0x18133B9F0
	public static bool IsHiragana(char c) { }

	// RVA: 0x133BB80 Offset: 0x133A180 VA: 0x18133BB80
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x133C980 Offset: 0x133AF80 VA: 0x18133C980
	public static bool get_IsReady() { }

	// RVA: 0x133B790 Offset: 0x1339D90 VA: 0x18133B790
	private static IntPtr GetResource(string name) { }

	// RVA: 0x133C360 Offset: 0x133A960 VA: 0x18133C360
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x133C3A0 Offset: 0x133A9A0 VA: 0x18133C3A0
	private static void .cctor() { }

	// RVA: 0x133B620 Offset: 0x1339C20 VA: 0x18133B620
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x133B0B0 Offset: 0x13396B0 VA: 0x18133B0B0
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

// Namespace: Mono.Globalization.Unicode
internal class MSCompatUnicodeTableUtil // TypeDefIndex: 84
{
	// Fields
	public static readonly CodePointIndexer Ignorable; // 0x0
	public static readonly CodePointIndexer Category; // 0x8
	public static readonly CodePointIndexer Level1; // 0x10
	public static readonly CodePointIndexer Level2; // 0x18
	public static readonly CodePointIndexer Level3; // 0x20
	public static readonly CodePointIndexer CjkCHS; // 0x28
	public static readonly CodePointIndexer Cjk; // 0x30

	// Methods

	// RVA: 0x133A350 Offset: 0x1338950 VA: 0x18133A350
	private static void .cctor() { }
}

// Namespace: Mono.Globalization.Unicode
internal class NormalizationTableUtil // TypeDefIndex: 85
{
	// Fields
	public static readonly CodePointIndexer Prop; // 0x0
	public static readonly CodePointIndexer Map; // 0x8
	public static readonly CodePointIndexer Combining; // 0x10
	public static readonly CodePointIndexer Composite; // 0x18
	public static readonly CodePointIndexer Helper; // 0x20

	// Methods

	// RVA: 0x133CAC0 Offset: 0x133B0C0 VA: 0x18133CAC0
	private static void .cctor() { }

	// RVA: 0x133CA50 Offset: 0x133B050 VA: 0x18133CA50
	public static int PropIdx(int cp) { }

	// RVA: 0x133C9E0 Offset: 0x133AFE0 VA: 0x18133C9E0
	public static int MapIdx(int cp) { }
}

// Namespace: Mono.Globalization.Unicode
internal class SimpleCollator : ISimpleCollator // TypeDefIndex: 90
{
	// Fields
	private static SimpleCollator invariant; // 0x0
	private readonly TextInfo textInfo; // 0x10
	private readonly CodePointIndexer cjkIndexer; // 0x18
	private readonly Contraction[] contractions; // 0x20
	private readonly Level2Map[] level2Maps; // 0x28
	private readonly byte[] unsafeFlags; // 0x30
	private readonly byte* cjkCatTable; // 0x38
	private readonly byte* cjkLv1Table; // 0x40
	private readonly byte* cjkLv2Table; // 0x48
	private readonly CodePointIndexer cjkLv2Indexer; // 0x50
	private readonly int lcid; // 0x58
	private readonly bool frenchSort; // 0x5C

	// Methods

	// RVA: 0x1343F70 Offset: 0x1342570 VA: 0x181343F70
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x1343D40 Offset: 0x1342340 VA: 0x181343D40
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x13408F0 Offset: 0x133EEF0 VA: 0x1813408F0
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x133E7E0 Offset: 0x133CDE0 VA: 0x18133E7E0
	private byte Category(int cp) { }

	// RVA: 0x1342A50 Offset: 0x1341050 VA: 0x181342A50
	private byte Level1(int cp) { }

	// RVA: 0x1342AF0 Offset: 0x13410F0 VA: 0x181342AF0
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x1341BF0 Offset: 0x13401F0 VA: 0x181341BF0
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x1340750 Offset: 0x133ED50 VA: 0x181340750
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x1340620 Offset: 0x133EC20 VA: 0x181340620
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x13410E0 Offset: 0x133F6E0 VA: 0x1813410E0
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x1340EF0 Offset: 0x133F4F0 VA: 0x181340EF0
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x1340380 Offset: 0x133E980 VA: 0x181340380
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x1340830 Offset: 0x133EE30 VA: 0x181340830
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x1343EB0 Offset: 0x13424B0 VA: 0x181343EB0
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x1340170 Offset: 0x133E770 VA: 0x181340170
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x1341C70 Offset: 0x1340270 VA: 0x181341C70
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x1341EC0 Offset: 0x13404C0 VA: 0x181341EC0
	private bool IsSafe(int i) { }

	// RVA: 0x1340E00 Offset: 0x133F400 VA: 0x181340E00 Slot: 4
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x1340990 Offset: 0x133EF90 VA: 0x181340990
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x1340A90 Offset: 0x133F090 VA: 0x181340A90
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x133FB60 Offset: 0x133E160 VA: 0x18133FB60
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x13400A0 Offset: 0x133E6A0 VA: 0x1813400A0
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x1343EA0 Offset: 0x13424A0 VA: 0x181343EA0 Slot: 5
	private int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x133FA60 Offset: 0x133E060 VA: 0x18133FA60
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x133E880 Offset: 0x133CE80 VA: 0x18133E880
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x133E8C0 Offset: 0x133CEC0 VA: 0x18133E8C0
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x133E8A0 Offset: 0x133CEA0 VA: 0x18133E8A0
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x1341D80 Offset: 0x1340380 VA: 0x181341D80 Slot: 6
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x1341DC0 Offset: 0x13403C0 VA: 0x181341DC0
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1341D00 Offset: 0x1340300 VA: 0x181341D00
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1342000 Offset: 0x1340600 VA: 0x181342000 Slot: 7
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x1341F40 Offset: 0x1340540 VA: 0x181341F40
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1343C00 Offset: 0x1342200 VA: 0x181343C00
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x1341920 Offset: 0x133FF20 VA: 0x181341920 Slot: 8
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x13411C0 Offset: 0x133F7C0 VA: 0x1813411C0
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x1341280 Offset: 0x133F880 VA: 0x181341280
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x1341300 Offset: 0x133F900 VA: 0x181341300
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x13413C0 Offset: 0x133F9C0 VA: 0x1813413C0
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x13428A0 Offset: 0x1340EA0 VA: 0x1813428A0 Slot: 9
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x13420C0 Offset: 0x13406C0 VA: 0x1813420C0
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x1342210 Offset: 0x1340810 VA: 0x181342210
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x13422E0 Offset: 0x13408E0 VA: 0x1813422E0
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1343850 Offset: 0x1341E50 VA: 0x181343850
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1343490 Offset: 0x1341A90 VA: 0x181343490
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1343A30 Offset: 0x1342030 VA: 0x181343A30
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x13432B0 Offset: 0x13418B0 VA: 0x1813432B0
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1342C90 Offset: 0x1341290 VA: 0x181342C90
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1343ED0 Offset: 0x13424D0 VA: 0x181343ED0
	private static void .cctor() { }
}

// Namespace: Mono.Globalization.Unicode
internal class SortKeyBuffer // TypeDefIndex: 91
{
	// Fields
	private byte[] l1b; // 0x10
	private byte[] l2b; // 0x18
	private byte[] l3b; // 0x20
	private byte[] l4sb; // 0x28
	private byte[] l4tb; // 0x30
	private byte[] l4kb; // 0x38
	private byte[] l4wb; // 0x40
	private byte[] l5b; // 0x48
	private string source; // 0x50
	private int l1; // 0x58
	private int l2; // 0x5C
	private int l3; // 0x60
	private int l4s; // 0x64
	private int l4t; // 0x68
	private int l4k; // 0x6C
	private int l4w; // 0x70
	private int l5; // 0x74
	private int lcid; // 0x78
	private CompareOptions options; // 0x7C
	private bool processLevel2; // 0x80
	private bool frenchSort; // 0x81
	private bool frenchSorted; // 0x82

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor(int lcid) { }

	// RVA: 0x1347C60 Offset: 0x1346260 VA: 0x181347C60
	public void Reset() { }

	// RVA: 0x1347A60 Offset: 0x1346060 VA: 0x181347A60
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	// RVA: 0x1346ED0 Offset: 0x13454D0 VA: 0x181346ED0
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	// RVA: 0x1346FA0 Offset: 0x13455A0 VA: 0x181346FA0
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	// RVA: 0x1347150 Offset: 0x1345750 VA: 0x181347150
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	// RVA: 0x1347070 Offset: 0x1345670 VA: 0x181347070
	private void AppendLevel5(byte category, byte lv1) { }

	// RVA: 0x1346E10 Offset: 0x1345410 VA: 0x181346E10
	private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx) { }

	// RVA: 0x1347390 Offset: 0x1345990 VA: 0x181347390
	public SortKey GetResultAndReset() { }

	// RVA: 0x1347340 Offset: 0x1345940 VA: 0x181347340
	private int GetOptimizedLength(byte[] data, int len, byte defaultValue) { }

	// RVA: 0x13473C0 Offset: 0x13459C0 VA: 0x1813473C0
	public SortKey GetResult() { }
}

