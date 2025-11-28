// Namespace: Mono.Security
[DefaultMember("Item")]
internal class ASN1 // TypeDefIndex: 92
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x13089E0 Offset: 0x1306FE0 VA: 0x1813089E0
	public void .ctor(byte tag) { }

	// RVA: 0x1308A20 Offset: 0x1307020 VA: 0x181308A20
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1336830 Offset: 0x1334E30 VA: 0x181336830
	public void .ctor(byte[] data) { }

	// RVA: 0x1308A70 Offset: 0x1307070 VA: 0x181308A70
	public int get_Count() { }

	// RVA: 0x13369C0 Offset: 0x1334FC0 VA: 0x1813369C0
	public byte[] get_Value() { }

	// RVA: 0x1335B00 Offset: 0x1334100 VA: 0x181335B00
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1335EA0 Offset: 0x13344A0 VA: 0x181335EA0 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1335CC0 Offset: 0x13342C0 VA: 0x181335CC0
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1335BA0 Offset: 0x13341A0 VA: 0x181335BA0
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1336520 Offset: 0x1334B20 VA: 0x181336520 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 93
{
	// Methods

	// RVA: 0x1337C70 Offset: 0x1336270 VA: 0x181337C70
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1337CF0 Offset: 0x13362F0 VA: 0x181337CF0
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1337B10 Offset: 0x1336110 VA: 0x181337B10
	internal static byte[] GetBytes(float value) { }

	// RVA: 0x1337BA0 Offset: 0x13361A0 VA: 0x181337BA0
	internal static byte[] GetBytes(double value) { }

	// RVA: 0x1309EB0 Offset: 0x13084B0 VA: 0x181309EB0
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1337E80 Offset: 0x1336480 VA: 0x181337E80
	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1337E00 Offset: 0x1336400 VA: 0x181337E00
	internal static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x1337DB0 Offset: 0x13363B0 VA: 0x181337DB0
	internal static double ToDouble(byte[] value, int startIndex) { }
}

// Namespace: Mono.Security
internal enum UriPartial // TypeDefIndex: 94
{
	// Fields
	public int value__; // 0x0
	public const UriPartial Scheme = 0;
	public const UriPartial Authority = 1;
	public const UriPartial Path = 2;
}

// Namespace: Mono.Security
internal class Uri // TypeDefIndex: 96
{
	// Fields
	private bool isUnixFilePath; // 0x10
	private string source; // 0x18
	private string scheme; // 0x20
	private string host; // 0x28
	private int port; // 0x30
	private string path; // 0x38
	private string query; // 0x40
	private string fragment; // 0x48
	private string userinfo; // 0x50
	private bool isUnc; // 0x58
	private bool isOpaquePart; // 0x59
	private bool userEscaped; // 0x5A
	private string cachedToString; // 0x60
	private string cachedLocalPath; // 0x68
	private int cachedHashCode; // 0x70
	private bool reduce; // 0x74
	private static readonly string hexUpperChars; // 0x0
	public static readonly string SchemeDelimiter; // 0x8
	public static readonly string UriSchemeFile; // 0x10
	public static readonly string UriSchemeFtp; // 0x18
	public static readonly string UriSchemeGopher; // 0x20
	public static readonly string UriSchemeHttp; // 0x28
	public static readonly string UriSchemeHttps; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	private static Uri.UriScheme[] schemes; // 0x50

	// Properties
	public string AbsolutePath { get; }
	public bool IsFile { get; }
	public bool IsUnc { get; }
	public string LocalPath { get; }

	// Methods

	// RVA: 0x134B960 Offset: 0x1349F60 VA: 0x18134B960
	public void .ctor(string uriString) { }

	// RVA: 0x134B780 Offset: 0x1349D80 VA: 0x18134B780
	public void .ctor(string uriString, bool dontEscape) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_AbsolutePath() { }

	// RVA: 0x134B970 Offset: 0x1349F70 VA: 0x18134B970
	public bool get_IsFile() { }

	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	public bool get_IsUnc() { }

	// RVA: 0x134B9E0 Offset: 0x1349FE0 VA: 0x18134B9E0
	public string get_LocalPath() { }

	// RVA: 0x1347EA0 Offset: 0x13464A0 VA: 0x181347EA0 Slot: 0
	public override bool Equals(object comparant) { }

	// RVA: 0x13486E0 Offset: 0x1346CE0 VA: 0x1813486E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13487E0 Offset: 0x1346DE0 VA: 0x1813487E0
	public string GetLeftPart(UriPartial part) { }

	// RVA: 0x1348510 Offset: 0x1346B10 VA: 0x181348510
	public static int FromHex(char digit) { }

	// RVA: 0x1348F30 Offset: 0x1347530 VA: 0x181348F30
	public static string HexEscape(char character) { }

	// RVA: 0x1349090 Offset: 0x1347690 VA: 0x181349090
	public static char HexUnescape(string pattern, ref int index) { }

	// RVA: 0x1349390 Offset: 0x1347990 VA: 0x181349390
	public static bool IsHexDigit(char digit) { }

	// RVA: 0x13493C0 Offset: 0x13479C0 VA: 0x1813493C0
	public static bool IsHexEncoding(string pattern, int index) { }

	// RVA: 0x134AE70 Offset: 0x1349470 VA: 0x18134AE70 Slot: 3
	public override string ToString() { }

	// RVA: 0x13484B0 Offset: 0x1346AB0 VA: 0x1813484B0
	protected static string EscapeString(string str) { }

	// RVA: 0x13480C0 Offset: 0x13466C0 VA: 0x1813480C0
	internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets) { }

	// RVA: 0x1349B80 Offset: 0x1348180 VA: 0x181349B80
	protected void Parse() { }

	// RVA: 0x134B110 Offset: 0x1349710 VA: 0x18134B110
	protected string Unescape(string str) { }

	// RVA: 0x134AF80 Offset: 0x1349580 VA: 0x18134AF80
	internal string Unescape(string str, bool excludeSharp) { }

	// RVA: 0x1349990 Offset: 0x1347F90 VA: 0x181349990
	private void ParseAsWindowsUNC(string uriString) { }

	// RVA: 0x13497F0 Offset: 0x1347DF0 VA: 0x1813497F0
	private void ParseAsWindowsAbsoluteFilePath(string uriString) { }

	// RVA: 0x1349640 Offset: 0x1347C40 VA: 0x181349640
	private void ParseAsUnixAbsoluteFilePath(string uriString) { }

	// RVA: 0x1349C70 Offset: 0x1348270 VA: 0x181349C70
	private void Parse(string uriString) { }

	// RVA: 0x134ABB0 Offset: 0x13491B0 VA: 0x18134ABB0
	private static string Reduce(string path) { }

	// RVA: 0x1348DE0 Offset: 0x13473E0 VA: 0x181348DE0
	internal static string GetSchemeDelimiter(string scheme) { }

	// RVA: 0x13485B0 Offset: 0x1346BB0 VA: 0x1813485B0
	internal static int GetDefaultPort(string scheme) { }

	// RVA: 0x1348C30 Offset: 0x1347230 VA: 0x181348C30
	private string GetOpaqueWiseSchemeDelimiter() { }

	// RVA: 0x13494E0 Offset: 0x1347AE0 VA: 0x1813494E0
	private static bool IsPredefinedScheme(string scheme) { }

	// RVA: 0x134B120 Offset: 0x1349720 VA: 0x18134B120
	private static void .cctor() { }
}

// Namespace: Mono.Security
[DefaultMember("Item")]
public class ASN1 // TypeDefIndex: 12803
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x13089E0 Offset: 0x1306FE0 VA: 0x1813089E0
	public void .ctor(byte tag) { }

	// RVA: 0x1308A20 Offset: 0x1307020 VA: 0x181308A20
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1308850 Offset: 0x1306E50 VA: 0x181308850
	public void .ctor(byte[] data) { }

	// RVA: 0x1308A70 Offset: 0x1307070 VA: 0x181308A70
	public int get_Count() { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public byte get_Tag() { }

	// RVA: 0x1115810 Offset: 0x1113E10 VA: 0x181115810
	public int get_Length() { }

	// RVA: 0x1308B70 Offset: 0x1307170 VA: 0x181308B70
	public byte[] get_Value() { }

	// RVA: 0x1308C10 Offset: 0x1307210 VA: 0x181308C10
	public void set_Value(byte[] value) { }

	// RVA: 0x13079F0 Offset: 0x1305FF0 VA: 0x1813079F0
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x1307A80 Offset: 0x1306080 VA: 0x181307A80
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1307950 Offset: 0x1305F50 VA: 0x181307950
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1307EF0 Offset: 0x13064F0 VA: 0x181307EF0 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1307C30 Offset: 0x1306230 VA: 0x181307C30
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1307B10 Offset: 0x1306110 VA: 0x181307B10
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1308AA0 Offset: 0x13070A0 VA: 0x181308AA0
	public ASN1 get_Item(int index) { }

	// RVA: 0x1307E10 Offset: 0x1306410 VA: 0x181307E10
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1308540 Offset: 0x1306B40 VA: 0x181308540 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security
public static class ASN1Convert // TypeDefIndex: 12804
{
	// Methods

	// RVA: 0x13069C0 Offset: 0x1304FC0 VA: 0x1813069C0
	public static ASN1 FromInt32(int value) { }

	// RVA: 0x1306D10 Offset: 0x1305310 VA: 0x181306D10
	public static ASN1 FromOid(string oid) { }

	// RVA: 0x1306DF0 Offset: 0x13053F0 VA: 0x181306DF0
	public static ASN1 FromUnsignedBigInteger(byte[] big) { }

	// RVA: 0x1307510 Offset: 0x1305B10 VA: 0x181307510
	public static int ToInt32(ASN1 asn1) { }

	// RVA: 0x13076C0 Offset: 0x1305CC0 VA: 0x1813076C0
	public static string ToOid(ASN1 asn1) { }

	// RVA: 0x1306F10 Offset: 0x1305510 VA: 0x181306F10
	public static DateTime ToDateTime(ASN1 time) { }
}

// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 12805
{
	// Methods

	// RVA: 0x1309CB0 Offset: 0x13082B0 VA: 0x181309CB0
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1309D30 Offset: 0x1308330 VA: 0x181309D30
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1309C20 Offset: 0x1308220 VA: 0x181309C20
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1309B50 Offset: 0x1308150 VA: 0x181309B50
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x1309F20 Offset: 0x1308520 VA: 0x181309F20
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1309EB0 Offset: 0x13084B0 VA: 0x181309EB0
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1309DF0 Offset: 0x13083F0 VA: 0x181309DF0
	internal static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x1309E60 Offset: 0x1308460 VA: 0x181309E60
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x1309DF0 Offset: 0x13083F0 VA: 0x181309DF0
	internal static uint ToUInt32(byte[] value, int startIndex) { }
}

// Namespace: Mono.Security
public sealed class PKCS7 // TypeDefIndex: 12810
{}

