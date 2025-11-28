// Namespace: System.Xml
[Extension]
internal static class AsyncHelper // TypeDefIndex: 6560
{
	// Fields
	public static readonly Task DoneTask; // 0x0
	public static readonly Task<bool> DoneTaskTrue; // 0x8
	public static readonly Task<bool> DoneTaskFalse; // 0x10
	public static readonly Task<int> DoneTaskZero; // 0x18

	// Methods

	// RVA: 0x1BAFC30 Offset: 0x1BAE230 VA: 0x181BAFC30
	private static void .cctor() { }
}

// Namespace: System.Xml
internal abstract class Base64Encoder // TypeDefIndex: 6561
{
	// Fields
	private byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private char[] charsLine; // 0x20

	// Methods

	// RVA: 0x1BB0400 Offset: 0x1BAEA00 VA: 0x181BB0400
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void WriteChars(char[] chars, int index, int count);

	// RVA: 0x1BAFF90 Offset: 0x1BAE590 VA: 0x181BAFF90
	internal void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x1BB0340 Offset: 0x1BAE940 VA: 0x181BB0340
	internal void Flush() { }
}

// Namespace: System.Xml
internal class XmlRawWriterBase64Encoder : Base64Encoder // TypeDefIndex: 6562
{
	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0x1BB9A70 Offset: 0x1BB8070 VA: 0x181BB9A70
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0x1BB9A40 Offset: 0x1BB8040 VA: 0x181BB9A40 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }
}

// Namespace: System.Xml
internal class XmlTextWriterBase64Encoder : Base64Encoder // TypeDefIndex: 6563
{
	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0x1BB9A70 Offset: 0x1BB8070 VA: 0x181BB9A70
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x1BC6130 Offset: 0x1BC4730 VA: 0x181BC6130 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }
}

// Namespace: System.Xml
internal class BinHexDecoder : IncrementalReadDecoder // TypeDefIndex: 6564
{
	// Fields
	private byte[] buffer; // 0x10
	private int curIndex; // 0x18
	private int endIndex; // 0x1C
	private bool hasHalfByteCached; // 0x20
	private byte cachedHalfByte; // 0x21

	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0x1BB0B10 Offset: 0x1BAF110 VA: 0x181BB0B10 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x1BB08F0 Offset: 0x1BAEEF0 VA: 0x181BB08F0 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x1BB0460 Offset: 0x1BAEA60 VA: 0x181BB0460
	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	// RVA: 0x1BB0770 Offset: 0x1BAED70 VA: 0x181BB0770
	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }
}

// Namespace: System.Xml
internal static class BinHexEncoder // TypeDefIndex: 6565
{
	// Methods

	// RVA: 0x1BB0B20 Offset: 0x1BAF120 VA: 0x181BB0B20
	internal static void Encode(byte[] buffer, int index, int count, XmlWriter writer) { }

	// RVA: 0x1BB0D60 Offset: 0x1BAF360 VA: 0x181BB0D60
	internal static string Encode(byte[] inArray, int offsetIn, int count) { }

	// RVA: 0x1BB0F40 Offset: 0x1BAF540 VA: 0x181BB0F40
	private static int Encode(byte[] inArray, int offsetIn, int count, char[] outArray) { }
}

// Namespace: System.Xml
internal enum BinXmlToken // TypeDefIndex: 6566
{
	// Fields
	public int value__; // 0x0
	public const BinXmlToken Error = 0;
	public const BinXmlToken NotImpl = -2;
	public const BinXmlToken EOF = -1;
	public const BinXmlToken XmlDecl = 254;
	public const BinXmlToken Encoding = 253;
	public const BinXmlToken DocType = 252;
	public const BinXmlToken System = 251;
	public const BinXmlToken Public = 250;
	public const BinXmlToken Subset = 249;
	public const BinXmlToken Element = 248;
	public const BinXmlToken EndElem = 247;
	public const BinXmlToken Attr = 246;
	public const BinXmlToken EndAttrs = 245;
	public const BinXmlToken PI = 244;
	public const BinXmlToken Comment = 243;
	public const BinXmlToken CData = 242;
	public const BinXmlToken EndCData = 241;
	public const BinXmlToken Name = 240;
	public const BinXmlToken QName = 239;
	public const BinXmlToken XmlText = 237;
	public const BinXmlToken Nest = 236;
	public const BinXmlToken EndNest = 235;
	public const BinXmlToken Extn = 234;
	public const BinXmlToken NmFlush = 233;
	public const BinXmlToken SQL_BIT = 6;
	public const BinXmlToken SQL_TINYINT = 7;
	public const BinXmlToken SQL_SMALLINT = 1;
	public const BinXmlToken SQL_INT = 2;
	public const BinXmlToken SQL_BIGINT = 8;
	public const BinXmlToken SQL_REAL = 3;
	public const BinXmlToken SQL_FLOAT = 4;
	public const BinXmlToken SQL_MONEY = 5;
	public const BinXmlToken SQL_SMALLMONEY = 20;
	public const BinXmlToken SQL_DATETIME = 18;
	public const BinXmlToken SQL_SMALLDATETIME = 19;
	public const BinXmlToken SQL_DECIMAL = 10;
	public const BinXmlToken SQL_NUMERIC = 11;
	public const BinXmlToken SQL_UUID = 9;
	public const BinXmlToken SQL_VARBINARY = 15;
	public const BinXmlToken SQL_BINARY = 12;
	public const BinXmlToken SQL_IMAGE = 23;
	public const BinXmlToken SQL_CHAR = 13;
	public const BinXmlToken SQL_VARCHAR = 16;
	public const BinXmlToken SQL_TEXT = 22;
	public const BinXmlToken SQL_NVARCHAR = 17;
	public const BinXmlToken SQL_NCHAR = 14;
	public const BinXmlToken SQL_NTEXT = 24;
	public const BinXmlToken SQL_UDT = 27;
	public const BinXmlToken XSD_KATMAI_DATE = 127;
	public const BinXmlToken XSD_KATMAI_DATETIME = 126;
	public const BinXmlToken XSD_KATMAI_TIME = 125;
	public const BinXmlToken XSD_KATMAI_DATEOFFSET = 124;
	public const BinXmlToken XSD_KATMAI_DATETIMEOFFSET = 123;
	public const BinXmlToken XSD_KATMAI_TIMEOFFSET = 122;
	public const BinXmlToken XSD_BOOLEAN = 134;
	public const BinXmlToken XSD_TIME = 129;
	public const BinXmlToken XSD_DATETIME = 130;
	public const BinXmlToken XSD_DATE = 131;
	public const BinXmlToken XSD_BINHEX = 132;
	public const BinXmlToken XSD_BASE64 = 133;
	public const BinXmlToken XSD_DECIMAL = 135;
	public const BinXmlToken XSD_BYTE = 136;
	public const BinXmlToken XSD_UNSIGNEDSHORT = 137;
	public const BinXmlToken XSD_UNSIGNEDINT = 138;
	public const BinXmlToken XSD_UNSIGNEDLONG = 139;
	public const BinXmlToken XSD_QNAME = 140;
}

// Namespace: System.Xml
internal struct BinXmlSqlDecimal // TypeDefIndex: 6567
{
	// Fields
	internal byte m_bLen; // 0x0
	internal byte m_bPrec; // 0x1
	internal byte m_bScale; // 0x2
	internal byte m_bSign; // 0x3
	internal uint m_data1; // 0x4
	internal uint m_data2; // 0x8
	internal uint m_data3; // 0xC
	internal uint m_data4; // 0x10
	private static readonly byte NUMERIC_MAX_PRECISION; // 0x0
	private static readonly byte MaxPrecision; // 0x1
	private static readonly byte MaxScale; // 0x2
	private static readonly int x_cNumeMax; // 0x4
	private static readonly long x_lInt32Base; // 0x8
	private static readonly ulong x_ulInt32Base; // 0x10
	private static readonly ulong x_ulInt32BaseForMod; // 0x18
	internal static readonly ulong x_llMax; // 0x20
	private static readonly double DUINT_BASE; // 0x28
	private static readonly double DUINT_BASE2; // 0x30
	private static readonly double DUINT_BASE3; // 0x38
	private static readonly uint[] x_rgulShiftBase; // 0x40
	private static readonly byte[] rgCLenFromPrec; // 0x48

	// Properties
	public bool IsPositive { get; }

	// Methods

	// RVA: 0x1BB4CA0 Offset: 0x1BB32A0 VA: 0x181BB4CA0
	public bool get_IsPositive() { }

	// RVA: 0x1BB4920 Offset: 0x1BB2F20 VA: 0x181BB4920
	public void .ctor(byte[] data, int offset, bool trim) { }

	// RVA: 0x140B7C0 Offset: 0x1409DC0 VA: 0x18140B7C0
	private static uint UIntFromByteArray(byte[] data, int offset) { }

	// RVA: 0x1BB3F30 Offset: 0x1BB2530 VA: 0x181BB3F30
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x1B52B60 Offset: 0x1B51160 VA: 0x181B52B60
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x1B50BB0 Offset: 0x1B4F1B0 VA: 0x181B50BB0
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1BB4030 Offset: 0x1BB2630 VA: 0x181BB4030
	public Decimal ToDecimal() { }

	// RVA: 0x1BB44B0 Offset: 0x1BB2AB0 VA: 0x181BB44B0
	private void TrimTrailingZeros() { }

	// RVA: 0x1BB4140 Offset: 0x1BB2740 VA: 0x181BB4140 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BB4710 Offset: 0x1BB2D10 VA: 0x181BB4710
	private static void .cctor() { }
}

// Namespace: System.Xml
internal struct BinXmlSqlMoney // TypeDefIndex: 6568
{
	// Fields
	private long data; // 0x0

	// Methods

	// RVA: 0x1561AA0 Offset: 0x15600A0 VA: 0x181561AA0
	public void .ctor(int v) { }

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	public void .ctor(long v) { }

	// RVA: 0x1BB4CB0 Offset: 0x1BB32B0 VA: 0x181BB4CB0
	public Decimal ToDecimal() { }

	// RVA: 0x1BB4D00 Offset: 0x1BB3300 VA: 0x181BB4D00 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml
internal abstract class BinXmlDateTime // TypeDefIndex: 6569
{
	// Fields
	internal static int[] KatmaiTimeScaleMultiplicator; // 0x0
	private static readonly double SQLTicksPerMillisecond; // 0x8
	public static readonly int SQLTicksPerSecond; // 0x10
	public static readonly int SQLTicksPerMinute; // 0x14
	public static readonly int SQLTicksPerHour; // 0x18
	private static readonly int SQLTicksPerDay; // 0x1C

	// Methods

	// RVA: 0x14E7700 Offset: 0x14E5D00 VA: 0x1814E7700
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x1BB1F30 Offset: 0x1BB0530 VA: 0x181BB1F30
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x1BB1E60 Offset: 0x1BB0460 VA: 0x181BB1E60
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x1BB2080 Offset: 0x1BB0680 VA: 0x181BB2080
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x1BB26A0 Offset: 0x1BB0CA0 VA: 0x181BB26A0
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x1BB21C0 Offset: 0x1BB07C0 VA: 0x181BB21C0
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x1BB25A0 Offset: 0x1BB0BA0 VA: 0x181BB25A0
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x1BB2440 Offset: 0x1BB0A40 VA: 0x181BB2440
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x1BB1090 Offset: 0x1BAF690 VA: 0x181BB1090
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x1BB12B0 Offset: 0x1BAF8B0 VA: 0x181BB12B0
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	// RVA: 0x1BB1450 Offset: 0x1BAFA50 VA: 0x181BB1450
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x1BB28F0 Offset: 0x1BB0EF0 VA: 0x181BB28F0
	public static string XsdDateTimeToString(long val) { }

	// RVA: 0x1BB2C00 Offset: 0x1BB1200 VA: 0x181BB2C00
	public static string XsdDateToString(long val) { }

	// RVA: 0x1BB3C20 Offset: 0x1BB2220 VA: 0x181BB3C20
	public static string XsdTimeToString(long val) { }

	// RVA: 0x1BB1BD0 Offset: 0x1BB01D0 VA: 0x181BB1BD0
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	// RVA: 0x1BB1AF0 Offset: 0x1BB00F0 VA: 0x181BB1AF0
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	// RVA: 0x1BB1D50 Offset: 0x1BB0350 VA: 0x181BB1D50
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	// RVA: 0x1BB1CE0 Offset: 0x1BB02E0 VA: 0x181BB1CE0
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	// RVA: 0x1BB35B0 Offset: 0x1BB1BB0 VA: 0x181BB35B0
	public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset) { }

	// RVA: 0x1BB3350 Offset: 0x1BB1950 VA: 0x181BB3350
	public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x1BB3A50 Offset: 0x1BB2050 VA: 0x181BB3A50
	public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x1BB2E70 Offset: 0x1BB1470 VA: 0x181BB2E70
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x1BB3060 Offset: 0x1BB1660 VA: 0x181BB3060
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x1BB3830 Offset: 0x1BB1E30 VA: 0x181BB3830
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x1BB3670 Offset: 0x1BB1C70 VA: 0x181BB3670
	public static string XsdKatmaiDateToString(byte[] data, int offset) { }

	// RVA: 0x1BB3420 Offset: 0x1BB1A20 VA: 0x181BB3420
	public static string XsdKatmaiDateTimeToString(byte[] data, int offset) { }

	// RVA: 0x1BB3AB0 Offset: 0x1BB20B0 VA: 0x181BB3AB0
	public static string XsdKatmaiTimeToString(byte[] data, int offset) { }

	// RVA: 0x1BB2EF0 Offset: 0x1BB14F0 VA: 0x181BB2EF0
	public static string XsdKatmaiDateOffsetToString(byte[] data, int offset) { }

	// RVA: 0x1BB3190 Offset: 0x1BB1790 VA: 0x181BB3190
	public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x1BB38B0 Offset: 0x1BB1EB0 VA: 0x181BB38B0
	public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x1BB17E0 Offset: 0x1BAFDE0 VA: 0x181BB17E0
	private static long GetKatmaiDateTicks(byte[] data, ref int pos) { }

	// RVA: 0x1BB1850 Offset: 0x1BAFE50 VA: 0x181BB1850
	private static long GetKatmaiTimeTicks(byte[] data, ref int pos) { }

	// RVA: 0x1BB1AA0 Offset: 0x1BB00A0 VA: 0x181BB1AA0
	private static long GetKatmaiTimeZoneTicks(byte[] data, int pos) { }

	// RVA: 0x1BB16D0 Offset: 0x1BAFCD0 VA: 0x181BB16D0
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x1BB15A0 Offset: 0x1BAFBA0 VA: 0x181BB15A0
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x1BB3E20 Offset: 0x1BB2420 VA: 0x181BB3E20
	private static void .cctor() { }
}

// Namespace: System.Xml
internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 6577
{
	// Fields
	internal static readonly Type TypeOfObject; // 0x0
	internal static readonly Type TypeOfString; // 0x8
	private static Type[] TokenTypeMap; // 0x10
	private static byte[] XsdKatmaiTimeScaleToValueLengthMap; // 0x18
	private static ReadState[] ScanState2ReadState; // 0x20
	private Stream inStrm; // 0x10
	private byte[] data; // 0x18
	private int pos; // 0x20
	private int mark; // 0x24
	private int end; // 0x28
	private long offset; // 0x30
	private bool eof; // 0x38
	private bool sniffed; // 0x39
	private bool isEmpty; // 0x3A
	private int docState; // 0x3C
	private XmlSqlBinaryReader.SymbolTables symbolTables; // 0x40
	private XmlNameTable xnt; // 0x60
	private bool xntFromSettings; // 0x68
	private string xml; // 0x70
	private string xmlns; // 0x78
	private string nsxmlns; // 0x80
	private string baseUri; // 0x88
	private XmlSqlBinaryReader.ScanState state; // 0x90
	private XmlNodeType nodetype; // 0x94
	private BinXmlToken token; // 0x98
	private int attrIndex; // 0x9C
	private XmlSqlBinaryReader.QName qnameOther; // 0xA0
	private XmlSqlBinaryReader.QName qnameElement; // 0xB8
	private XmlNodeType parentNodeType; // 0xD0
	private XmlSqlBinaryReader.ElemInfo[] elementStack; // 0xD8
	private int elemDepth; // 0xE0
	private XmlSqlBinaryReader.AttrInfo[] attributes; // 0xE8
	private int[] attrHashTbl; // 0xF0
	private int attrCount; // 0xF8
	private int posAfterAttrs; // 0xFC
	private bool xmlspacePreserve; // 0x100
	private int tokLen; // 0x104
	private int tokDataPos; // 0x108
	private bool hasTypedValue; // 0x10C
	private Type valueType; // 0x110
	private string stringValue; // 0x118
	private Dictionary<string, XmlSqlBinaryReader.NamespaceDecl> namespaces; // 0x120
	private XmlSqlBinaryReader.NestedBinXml prevNameInfo; // 0x128
	private XmlReader textXmlReader; // 0x130
	private bool closeInput; // 0x138
	private bool checkCharacters; // 0x139
	private bool ignoreWhitespace; // 0x13A
	private bool ignorePIs; // 0x13B
	private bool ignoreComments; // 0x13C
	private DtdProcessing dtdProcessing; // 0x140
	private SecureStringHasher hasher; // 0x148
	private XmlCharType xmlCharType; // 0x150
	private Encoding unicode; // 0x158
	private byte version; // 0x160

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override bool HasValue { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override ReadState ReadState { get; }

	// Methods

	// RVA: 0x1BC52B0 Offset: 0x1BC38B0 VA: 0x181BC52B0
	public void .ctor(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0x1BC5B30 Offset: 0x1BC4130 VA: 0x181BC5B30 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x12ECA90 Offset: 0x12EB090 VA: 0x1812ECA90 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x16237B0 Offset: 0x1621DB0 VA: 0x1816237B0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1BC5A00 Offset: 0x1BC4000 VA: 0x181BC5A00 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x1BC5C40 Offset: 0x1BC4240 VA: 0x181BC5C40 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1BC5920 Offset: 0x1BC3F20 VA: 0x181BC5920 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x1BC5A90 Offset: 0x1BC4090 VA: 0x181BC5A90 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1BC60B0 Offset: 0x1BC46B0 VA: 0x181BC60B0 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1BC6020 Offset: 0x1BC4620 VA: 0x181BC6020 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150 Slot: 21
	public override Type get_ValueType() { }

	// RVA: 0x1BC58C0 Offset: 0x1BC3EC0 VA: 0x181BC58C0 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1BBBEC0 Offset: 0x1BBA4C0 VA: 0x181BBBEC0 Slot: 25
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0x1BBC030 Offset: 0x1BBA630 VA: 0x181BBC030 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1BBBE10 Offset: 0x1BBA410 VA: 0x181BBBE10 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1BBE180 Offset: 0x1BBC780 VA: 0x181BBE180 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1BBE0D0 Offset: 0x1BBC6D0 VA: 0x181BBE0D0 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1BBE340 Offset: 0x1BBC940 VA: 0x181BBE340 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1BBE3D0 Offset: 0x1BBC9D0 VA: 0x181BBE3D0 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1BBE210 Offset: 0x1BBC810 VA: 0x181BBE210 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1BC59F0 Offset: 0x1BC3FF0 VA: 0x181BC59F0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x1BBF4A0 Offset: 0x1BBDAA0 VA: 0x181BBF4A0 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1BBA570 Offset: 0x1BB8B70 VA: 0x181BBA570 Slot: 35
	public override void Close() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1BBE010 Offset: 0x1BBC610 VA: 0x181BBE010 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1BC11C0 Offset: 0x1BBF7C0 VA: 0x181BC11C0 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1BC5AB0 Offset: 0x1BC40B0 VA: 0x181BC5AB0 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1BC0BE0 Offset: 0x1BBF1E0 VA: 0x181BC0BE0 Slot: 33
	public override bool Read() { }

	// RVA: 0x1BC2630 Offset: 0x1BC0C30 VA: 0x181BC2630 Slot: 57
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1BC29D0 Offset: 0x1BC0FD0 VA: 0x181BC29D0 Slot: 59
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1BC4E80 Offset: 0x1BC3480 VA: 0x181BC4E80
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0x1BB9AF0 Offset: 0x1BB80F0 VA: 0x181BB9AF0
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0x1BB9C30 Offset: 0x1BB8230 VA: 0x181BB9C30
	private void AddName() { }

	// RVA: 0x1BB9D90 Offset: 0x1BB8390 VA: 0x181BB9D90
	private void AddQName() { }

	// RVA: 0x1BBE480 Offset: 0x1BBCA80 VA: 0x181BBE480
	private void NameFlush() { }

	// RVA: 0x1BC2510 Offset: 0x1BC0B10 VA: 0x181BC2510
	private void SkipExtn() { }

	// RVA: 0x1BC0820 Offset: 0x1BBEE20 VA: 0x181BC0820
	private int ReadQNameRef() { }

	// RVA: 0x1BC0750 Offset: 0x1BBED50 VA: 0x181BC0750
	private int ReadNameRef() { }

	// RVA: 0x1BBA620 Offset: 0x1BB8C20 VA: 0x181BBA620
	private bool FillAllowEOF() { }

	// RVA: 0x1BBA870 Offset: 0x1BB8E70 VA: 0x181BBA870
	private void Fill_(int require) { }

	// RVA: 0x1BBA8F0 Offset: 0x1BB8EF0 VA: 0x181BBA8F0
	private void Fill(int require) { }

	// RVA: 0x1BBF6C0 Offset: 0x1BBDCC0 VA: 0x181BBF6C0
	private byte ReadByte() { }

	// RVA: 0x1BC0B80 Offset: 0x1BBF180 VA: 0x181BC0B80
	private ushort ReadUShort() { }

	// RVA: 0x1BBEAF0 Offset: 0x1BBD0F0 VA: 0x181BBEAF0
	private int ParseMB32() { }

	// RVA: 0x1BBE980 Offset: 0x1BBCF80 VA: 0x181BBE980
	private int ParseMB32_(byte b) { }

	// RVA: 0x1BBEB50 Offset: 0x1BBD150 VA: 0x181BBEB50
	private int ParseMB32(int pos) { }

	// RVA: 0x1BBEAF0 Offset: 0x1BBD0F0 VA: 0x181BBEAF0
	private int ParseMB64() { }

	// RVA: 0x1BBED50 Offset: 0x1BBD350 VA: 0x181BBED50
	private BinXmlToken PeekToken() { }

	// RVA: 0x1BC08F0 Offset: 0x1BBEEF0 VA: 0x181BC08F0
	private BinXmlToken ReadToken() { }

	// RVA: 0x1BBE550 Offset: 0x1BBCB50 VA: 0x181BBE550
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0x1BBE4E0 Offset: 0x1BBCAE0 VA: 0x181BBE4E0
	private BinXmlToken NextToken1() { }

	// RVA: 0x1BBE8E0 Offset: 0x1BBCEE0 VA: 0x181BBE8E0
	private BinXmlToken NextToken() { }

	// RVA: 0x1BBED30 Offset: 0x1BBD330 VA: 0x181BBED30
	private BinXmlToken PeekNextToken() { }

	// RVA: 0x1BC0D60 Offset: 0x1BBF360 VA: 0x181BC0D60
	private BinXmlToken RescanNextToken() { }

	// RVA: 0x1BBEC70 Offset: 0x1BBD270 VA: 0x181BBEC70
	private string ParseText() { }

	// RVA: 0x1BC2210 Offset: 0x1BC0810 VA: 0x181BC2210
	private int ScanText(out int start) { }

	// RVA: 0x1BBC480 Offset: 0x1BBAA80 VA: 0x181BBC480
	private string GetString(int pos, int cch) { }

	// RVA: 0x1BBC440 Offset: 0x1BBAA40 VA: 0x181BBC440
	private string GetStringAligned(byte[] data, int offset, int cch) { }

	// RVA: 0x1BBBC90 Offset: 0x1BBA290 VA: 0x181BBBC90
	private string GetAttributeText(int i) { }

	// RVA: 0x1BBDE60 Offset: 0x1BBC460 VA: 0x181BBDE60
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0x1BBDF10 Offset: 0x1BBC510 VA: 0x181BBDF10
	private int LocateAttribute(string name) { }

	// RVA: 0x1BBF0B0 Offset: 0x1BBD6B0 VA: 0x181BBF0B0
	private void PositionOnAttribute(int i) { }

	// RVA: 0x1BBC930 Offset: 0x1BBAF30 VA: 0x181BBC930
	private void GrowElements() { }

	// RVA: 0x1BBC890 Offset: 0x1BBAE90 VA: 0x181BBC890
	private void GrowAttributes() { }

	// RVA: 0x1BBA550 Offset: 0x1BB8B50 VA: 0x181BBA550
	private void ClearAttributes() { }

	// RVA: 0x1BBF1D0 Offset: 0x1BBD7D0 VA: 0x181BBF1D0
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0x1BBEFD0 Offset: 0x1BBD5D0 VA: 0x181BBEFD0
	private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }

	// RVA: 0x1BBAB40 Offset: 0x1BB9140 VA: 0x181BBAB40
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0x1BC0080 Offset: 0x1BBE680 VA: 0x181BC0080
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0x1BC1200 Offset: 0x1BBF800 VA: 0x181BC1200
	private void ScanAttributes() { }

	// RVA: 0x1BC2370 Offset: 0x1BC0970 VA: 0x181BC2370
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0x1BBC9D0 Offset: 0x1BBAFD0 VA: 0x181BBC9D0
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0x1BC4ED0 Offset: 0x1BC34D0 VA: 0x181BC4ED0
	private string XmlDeclValue() { }

	// RVA: 0x1BBA070 Offset: 0x1BB8670 VA: 0x181BBA070
	private string CDATAValue() { }

	// RVA: 0x1BBA980 Offset: 0x1BB8F80 VA: 0x181BBA980
	private void FinishCDATA() { }

	// RVA: 0x1BBAA20 Offset: 0x1BB9020 VA: 0x181BBAA20
	private void FinishEndElement() { }

	// RVA: 0x1BBF710 Offset: 0x1BBDD10 VA: 0x181BBF710
	private bool ReadDoc() { }

	// RVA: 0x1BBCDD0 Offset: 0x1BBB3D0 VA: 0x181BBCDD0
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0x1BBD370 Offset: 0x1BBB970 VA: 0x181BBD370
	private void ImplReadElement() { }

	// RVA: 0x1BBD740 Offset: 0x1BBBD40 VA: 0x181BBD740
	private void ImplReadEndElement() { }

	// RVA: 0x1BBCF70 Offset: 0x1BBB570 VA: 0x181BBCF70
	private void ImplReadDoctype() { }

	// RVA: 0x1BBD9E0 Offset: 0x1BBBFE0 VA: 0x181BBD9E0
	private void ImplReadPI() { }

	// RVA: 0x1BBCD90 Offset: 0x1BBB390 VA: 0x181BBCD90
	private void ImplReadComment() { }

	// RVA: 0x1BBCD00 Offset: 0x1BBB300 VA: 0x181BBCD00
	private void ImplReadCDATA() { }

	// RVA: 0x1BBD8B0 Offset: 0x1BBBEB0 VA: 0x181BBD8B0
	private void ImplReadNest() { }

	// RVA: 0x1BBD840 Offset: 0x1BBBE40 VA: 0x181BBD840
	private void ImplReadEndNest() { }

	// RVA: 0x1BBDA60 Offset: 0x1BBC060 VA: 0x181BBDA60
	private void ImplReadXmlText() { }

	// RVA: 0x1BC2E00 Offset: 0x1BC1400 VA: 0x181BC2E00
	private void UpdateFromTextReader() { }

	// RVA: 0x1BC2F20 Offset: 0x1BC1520 VA: 0x181BC2F20
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0x1BBA1B0 Offset: 0x1BB87B0 VA: 0x181BBA1B0
	private void CheckAllowContent() { }

	// RVA: 0x1BBAD20 Offset: 0x1BB9320 VA: 0x181BBAD20
	private void GenerateTokenTypeMap() { }

	// RVA: 0x1BBC650 Offset: 0x1BBAC50 VA: 0x181BBC650
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0x1BBF480 Offset: 0x1BBDA80 VA: 0x181BBF480
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0x1BC1FF0 Offset: 0x1BC05F0 VA: 0x181BC1FF0
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x1BC1920 Offset: 0x1BBFF20 VA: 0x181BC1920
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x1BBA2A0 Offset: 0x1BB88A0 VA: 0x181BBA2A0
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0x1BBA210 Offset: 0x1BB8810 VA: 0x181BBA210
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0x1BBA4F0 Offset: 0x1BB8AF0 VA: 0x181BBA4F0
	private void CheckValueTokenBounds() { }

	// RVA: 0x1BBC730 Offset: 0x1BBAD30 VA: 0x181BBC730
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0x1BC5020 Offset: 0x1BC3620 VA: 0x181BC5020
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

	// RVA: 0x1BC3F50 Offset: 0x1BC2550 VA: 0x181BC3F50
	private long ValueAsLong() { }

	// RVA: 0x1BC4DE0 Offset: 0x1BC33E0 VA: 0x181BC4DE0
	private ulong ValueAsULong() { }

	// RVA: 0x1BC3A10 Offset: 0x1BC2010 VA: 0x181BC3A10
	private Decimal ValueAsDecimal() { }

	// RVA: 0x1BC3D50 Offset: 0x1BC2350 VA: 0x181BC3D50
	private double ValueAsDouble() { }

	// RVA: 0x1BC2F40 Offset: 0x1BC1540 VA: 0x181BC2F40
	private string ValueAsDateTimeString() { }

	// RVA: 0x1BC4490 Offset: 0x1BC2A90 VA: 0x181BC4490
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0x1BBC1D0 Offset: 0x1BBA7D0 VA: 0x181BBC1D0
	private short GetInt16(int pos) { }

	// RVA: 0x1BBC1D0 Offset: 0x1BBA7D0 VA: 0x181BBC1D0
	private ushort GetUInt16(int pos) { }

	// RVA: 0x1BBC220 Offset: 0x1BBA820 VA: 0x181BBC220
	private int GetInt32(int pos) { }

	// RVA: 0x1BBC220 Offset: 0x1BBA820 VA: 0x181BBC220
	private uint GetUInt32(int pos) { }

	// RVA: 0x1BBC2A0 Offset: 0x1BBA8A0 VA: 0x181BBC2A0
	private long GetInt64(int pos) { }

	// RVA: 0x1BBC2A0 Offset: 0x1BBA8A0 VA: 0x181BBC2A0
	private ulong GetUInt64(int pos) { }

	// RVA: 0x1BBC3C0 Offset: 0x1BBA9C0 VA: 0x181BBC3C0
	private float GetSingle(int offset) { }

	// RVA: 0x1BBC0A0 Offset: 0x1BBA6A0 VA: 0x181BBC0A0
	private double GetDouble(int offset) { }

	// RVA: 0x1BC2C20 Offset: 0x1BC1220 VA: 0x181BC2C20
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0x1BC2D90 Offset: 0x1BC1390 VA: 0x181BC2D90
	private Exception ThrowXmlException(string res) { }

	// RVA: 0x1BC2CB0 Offset: 0x1BC12B0 VA: 0x181BC2CB0
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0x1BC2BB0 Offset: 0x1BC11B0 VA: 0x181BC2BB0
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0x1BC50F0 Offset: 0x1BC36F0 VA: 0x181BC50F0
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class BitStack // TypeDefIndex: 6578
{
	// Fields
	private uint[] bitStack; // 0x10
	private int stackPos; // 0x18
	private uint curr; // 0x1C

	// Methods

	// RVA: 0x1BB5080 Offset: 0x1BB3680 VA: 0x181BB5080
	public void .ctor() { }

	// RVA: 0x1BB4E90 Offset: 0x1BB3490 VA: 0x181BB4E90
	public void PushBit(bool bit) { }

	// RVA: 0x1BB4DF0 Offset: 0x1BB33F0 VA: 0x181BB4DF0
	public bool PopBit() { }

	// RVA: 0x1BB4DE0 Offset: 0x1BB33E0 VA: 0x181BB4DE0
	public bool PeekBit() { }

	// RVA: 0x1BB4FA0 Offset: 0x1BB35A0 VA: 0x181BB4FA0
	private void PushCurr() { }

	// RVA: 0x1BB4E50 Offset: 0x1BB3450 VA: 0x181BB4E50
	private void PopCurr() { }
}

// Namespace: System.Xml
internal static class Bits // TypeDefIndex: 6579
{
	// Fields
	private static readonly uint MASK_0101010101010101; // 0x0
	private static readonly uint MASK_0011001100110011; // 0x4
	private static readonly uint MASK_0000111100001111; // 0x8
	private static readonly uint MASK_0000000011111111; // 0xC
	private static readonly uint MASK_1111111111111111; // 0x10

	// Methods

	// RVA: 0x1BB50A0 Offset: 0x1BB36A0 VA: 0x181BB50A0
	public static int Count(uint num) { }

	// RVA: 0x1BB5150 Offset: 0x1BB3750 VA: 0x181BB5150
	public static int LeastPosition(uint num) { }

	// RVA: 0x1BB5260 Offset: 0x1BB3860 VA: 0x181BB5260
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class ByteStack // TypeDefIndex: 6580
{
	// Fields
	private byte[] stack; // 0x10
	private int growthRate; // 0x18
	private int top; // 0x1C
	private int size; // 0x20

	// Methods

	// RVA: 0x1BB5410 Offset: 0x1BB3A10 VA: 0x181BB5410
	public void .ctor(int growthRate) { }

	// RVA: 0x1BB5340 Offset: 0x1BB3940 VA: 0x181BB5340
	public void Push(byte data) { }

	// RVA: 0x1BB52F0 Offset: 0x1BB38F0 VA: 0x181BB52F0
	public byte Pop() { }
}

// Namespace: System.Xml
internal class CharEntityEncoderFallback : EncoderFallback // TypeDefIndex: 6581
{
	// Fields
	private CharEntityEncoderFallbackBuffer fallbackBuffer; // 0x10
	private int[] textContentMarks; // 0x18
	private int endMarkPos; // 0x20
	private int curMarkPos; // 0x24
	private int startOffset; // 0x28

	// Properties
	public override int MaxCharCount { get; }
	internal int StartOffset { set; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	internal void .ctor() { }

	// RVA: 0x1BB5B70 Offset: 0x1BB4170 VA: 0x181BB5B70 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x458FC0 Offset: 0x4575C0 VA: 0x180458FC0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	internal void set_StartOffset(int value) { }

	// RVA: 0x1BB5C10 Offset: 0x1BB4210 VA: 0x181BB5C10
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x1BB5B10 Offset: 0x1BB4110 VA: 0x181BB5B10
	internal bool CanReplaceAt(int index) { }
}

// Namespace: System.Xml
internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 6582
{
	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1BB5A80 Offset: 0x1BB4080 VA: 0x181BB5A80
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x1BB5480 Offset: 0x1BB3A80 VA: 0x181BB5480 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1BB56F0 Offset: 0x1BB3CF0 VA: 0x181BB56F0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x1BB59F0 Offset: 0x1BB3FF0 VA: 0x181BB59F0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x1BB5A40 Offset: 0x1BB4040 VA: 0x181BB5A40 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x1BB5AE0 Offset: 0x1BB40E0 VA: 0x181BB5AE0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x1BB5A60 Offset: 0x1BB4060 VA: 0x181BB5A60 Slot: 9
	public override void Reset() { }

	// RVA: 0x1BB5A70 Offset: 0x1BB4070 VA: 0x181BB5A70
	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }
}

// Namespace: System.Xml
public enum ConformanceLevel // TypeDefIndex: 6583
{
	// Fields
	public int value__; // 0x0
	public const ConformanceLevel Auto = 0;
	public const ConformanceLevel Fragment = 1;
	public const ConformanceLevel Document = 2;
}

// Namespace: System.Xml
public enum DtdProcessing // TypeDefIndex: 6584
{
	// Fields
	public int value__; // 0x0
	public const DtdProcessing Prohibit = 0;
	public const DtdProcessing Ignore = 1;
	public const DtdProcessing Parse = 2;
}

// Namespace: System.Xml
public enum EntityHandling // TypeDefIndex: 6585
{
	// Fields
	public int value__; // 0x0
	public const EntityHandling ExpandEntities = 1;
	public const EntityHandling ExpandCharEntities = 2;
}

// Namespace: System.Xml
internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 6586
{
	// Fields
	protected ByteStack elementScope; // 0xC0
	protected ElementProperties currentElementProperties; // 0xC8
	private AttributeProperties currentAttributeProperties; // 0xCC
	private bool endsWithAmpersand; // 0xD0
	private byte[] uriEscapingBuffer; // 0xD8
	private string mediaType; // 0xE0
	private bool doNotEscapeUriAttributes; // 0xE8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x1BB7BD0 Offset: 0x1BB61D0 VA: 0x181BB7BD0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1BB7C00 Offset: 0x1BB6200 VA: 0x181BB7C00
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1BB6880 Offset: 0x1BB4E80 VA: 0x181BB6880 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1BB75A0 Offset: 0x1BB5BA0 VA: 0x181BB75A0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1BB6730 Offset: 0x1BB4D30 VA: 0x181BB6730 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1BB6B40 Offset: 0x1BB5140 VA: 0x181BB6B40 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1BB6CF0 Offset: 0x1BB52F0 VA: 0x181BB6CF0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1BB7400 Offset: 0x1BB5A00 VA: 0x181BB7400 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1BB6AB0 Offset: 0x1BB50B0 VA: 0x181BB6AB0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1BB72C0 Offset: 0x1BB58C0 VA: 0x181BB72C0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1BB76E0 Offset: 0x1BB5CE0 VA: 0x181BB76E0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1BB6C90 Offset: 0x1BB5290 VA: 0x181BB6C90 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1BB6790 Offset: 0x1BB4D90 VA: 0x181BB6790 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1BB77D0 Offset: 0x1BB5DD0 VA: 0x181BB77D0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1BB67F0 Offset: 0x1BB4DF0 VA: 0x181BB67F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1BB6440 Offset: 0x1BB4A40 VA: 0x181BB6440
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1BB71B0 Offset: 0x1BB57B0 VA: 0x181BB71B0
	protected void WriteMetaElement() { }

	// RVA: 0x1BB7190 Offset: 0x1BB5790 VA: 0x181BB7190
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1BB6E40 Offset: 0x1BB5440 VA: 0x181BB6E40
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1BB6E90 Offset: 0x1BB5490 VA: 0x181BB6E90
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1BB7830 Offset: 0x1BB5E30 VA: 0x181BB7830
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1BB6670 Offset: 0x1BB4C70 VA: 0x181BB6670
	private void OutputRestAmps() { }
}

// Namespace: System.Xml
internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter // TypeDefIndex: 6587
{
	// Fields
	private int indentLevel; // 0xF0
	private int endBlockPos; // 0xF4
	private string indentChars; // 0xF8
	private bool newLineOnAttributes; // 0x100

	// Methods

	// RVA: 0x1BB63D0 Offset: 0x1BB49D0 VA: 0x181BB63D0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1BB6360 Offset: 0x1BB4960 VA: 0x181BB6360
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1BB5E30 Offset: 0x1BB4430 VA: 0x181BB5E30 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1BB6160 Offset: 0x1BB4760 VA: 0x181BB6160 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1BB5D60 Offset: 0x1BB4360 VA: 0x181BB5D60 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1BB5E60 Offset: 0x1BB4460 VA: 0x181BB5E60 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1BB60A0 Offset: 0x1BB46A0 VA: 0x181BB60A0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1BB5CE0 Offset: 0x1BB42E0 VA: 0x181BB5CE0 Slot: 56
	protected override void FlushBuffer() { }

	// RVA: 0x1BB5D00 Offset: 0x1BB4300 VA: 0x181BB5D00
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1BB6040 Offset: 0x1BB4640 VA: 0x181BB6040
	private void WriteIndent() { }
}

// Namespace: System.Xml
internal abstract class HtmlTernaryTree // TypeDefIndex: 6588
{
	// Fields
	internal static byte[] htmlElements; // 0x0
	internal static byte[] htmlAttributes; // 0x8

	// Methods

	// RVA: 0x1BB7C30 Offset: 0x1BB6230 VA: 0x181BB7C30
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 6589
{
	// Fields
	protected ByteStack elementScope; // 0x90
	protected ElementProperties currentElementProperties; // 0x98
	private AttributeProperties currentAttributeProperties; // 0x9C
	private bool endsWithAmpersand; // 0xA0
	private byte[] uriEscapingBuffer; // 0xA8
	private string mediaType; // 0xB0
	private bool doNotEscapeUriAttributes; // 0xB8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x1BB9360 Offset: 0x1BB7960 VA: 0x181BB9360
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1BB8200 Offset: 0x1BB6800 VA: 0x181BB8200 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1BB8D90 Offset: 0x1BB7390 VA: 0x181BB8D90 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1BB7FF0 Offset: 0x1BB65F0 VA: 0x181BB7FF0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1BB8460 Offset: 0x1BB6A60 VA: 0x181BB8460 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1BB85D0 Offset: 0x1BB6BD0 VA: 0x181BB85D0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1BB8C30 Offset: 0x1BB7230 VA: 0x181BB8C30 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1BB83F0 Offset: 0x1BB69F0 VA: 0x181BB83F0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1BB8B40 Offset: 0x1BB7140 VA: 0x181BB8B40 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1BB8EA0 Offset: 0x1BB74A0 VA: 0x181BB8EA0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1BB8570 Offset: 0x1BB6B70 VA: 0x181BB8570 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1BB8150 Offset: 0x1BB6750 VA: 0x181BB8150 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1BB8F80 Offset: 0x1BB7580 VA: 0x181BB8F80 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1BB81B0 Offset: 0x1BB67B0 VA: 0x181BB81B0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1BB7D20 Offset: 0x1BB6320 VA: 0x181BB7D20
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1BB8A30 Offset: 0x1BB7030 VA: 0x181BB8A30
	protected void WriteMetaElement() { }

	// RVA: 0x1BB8A10 Offset: 0x1BB7010 VA: 0x181BB8A10
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1BB86E0 Offset: 0x1BB6CE0 VA: 0x181BB86E0
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1BB8730 Offset: 0x1BB6D30 VA: 0x181BB8730
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1BB8FE0 Offset: 0x1BB75E0 VA: 0x181BB8FE0
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1BB7F50 Offset: 0x1BB6550 VA: 0x181BB7F50
	private void OutputRestAmps() { }
}

// Namespace: System.Xml
internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter // TypeDefIndex: 6590
{
	// Fields
	private int indentLevel; // 0xC0
	private int endBlockPos; // 0xC4
	private string indentChars; // 0xC8
	private bool newLineOnAttributes; // 0xD0

	// Methods

	// RVA: 0x1CB7210 Offset: 0x1CB5810 VA: 0x181CB7210
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1CB6CE0 Offset: 0x1CB52E0 VA: 0x181CB6CE0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CB6EF0 Offset: 0x1CB54F0 VA: 0x181CB6EF0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CB6C20 Offset: 0x1CB5220 VA: 0x181CB6C20 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1CB6D10 Offset: 0x1CB5310 VA: 0x181CB6D10 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CB6E30 Offset: 0x1CB5430 VA: 0x181CB6E30 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CB6BA0 Offset: 0x1CB51A0 VA: 0x181CB6BA0 Slot: 56
	protected override void FlushBuffer() { }

	// RVA: 0x1CB6BC0 Offset: 0x1CB51C0 VA: 0x181CB6BC0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1CB6DE0 Offset: 0x1CB53E0 VA: 0x181CB6DE0
	private void WriteIndent() { }
}

// Namespace: System.Xml
internal interface IDtdInfo // TypeDefIndex: 6591
{
	// Properties
	public abstract XmlQualifiedName Name { get; }
	public abstract string InternalDtdSubset { get; }
	public abstract bool HasDefaultAttributes { get; }
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlQualifiedName get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_InternalDtdSubset();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_HasDefaultAttributes();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IDtdEntityInfo LookupEntity(string name);
}

// Namespace: System.Xml
internal interface IDtdAttributeListInfo // TypeDefIndex: 6592
{
	// Properties
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdAttributeInfo LookupAttribute(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();
}

// Namespace: System.Xml
internal interface IDtdAttributeInfo // TypeDefIndex: 6593
{
	// Properties
	public abstract string Prefix { get; }
	public abstract string LocalName { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }
	public abstract bool IsNonCDataType { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsXmlAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_LinePosition();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsNonCDataType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsXmlAttribute();
}

// Namespace: System.Xml
internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo // TypeDefIndex: 6594
{
	// Properties
	public abstract string DefaultValueExpanded { get; }
	public abstract object DefaultValueTyped { get; }
	public abstract int ValueLineNumber { get; }
	public abstract int ValueLinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_DefaultValueExpanded();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_DefaultValueTyped();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_ValueLineNumber();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_ValueLinePosition();
}

// Namespace: System.Xml
internal interface IDtdEntityInfo // TypeDefIndex: 6595
{
	// Properties
	public abstract string Name { get; }
	public abstract bool IsExternal { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsUnparsedEntity { get; }
	public abstract bool IsParameterEntity { get; }
	public abstract string BaseUriString { get; }
	public abstract string DeclaredUriString { get; }
	public abstract string SystemId { get; }
	public abstract string PublicId { get; }
	public abstract string Text { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsExternal();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsUnparsedEntity();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsParameterEntity();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_BaseUriString();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DeclaredUriString();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_SystemId();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_PublicId();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_Text();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_LinePosition();
}

// Namespace: System.Xml
internal interface IDtdParser // TypeDefIndex: 6596
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);
}

// Namespace: System.Xml
internal interface IDtdParserAdapter // TypeDefIndex: 6597
{
	// Properties
	public abstract XmlNameTable NameTable { get; }
	public abstract IXmlNamespaceResolver NamespaceResolver { get; }
	public abstract Uri BaseUri { get; }
	public abstract char[] ParsingBuffer { get; }
	public abstract int ParsingBufferLength { get; }
	public abstract int CurrentPosition { get; set; }
	public abstract int LineNo { get; }
	public abstract int LineStartPosition { get; }
	public abstract bool IsEof { get; }
	public abstract int EntityStackLength { get; }
	public abstract bool IsEntityEolNormalized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNamespaceResolver get_NamespaceResolver();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Uri get_BaseUri();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract char[] get_ParsingBuffer();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_ParsingBufferLength();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_CurrentPosition();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_CurrentPosition(int value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_LineNo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_LineStartPosition();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsEof();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_EntityStackLength();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsEntityEolNormalized();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int ReadData();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnNewLine(int pos);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int ParseNumericCharRef(StringBuilder internalSubsetBuilder);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ParsePI(StringBuilder sb);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void ParseComment(StringBuilder sb);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool PushEntity(IDtdEntityInfo entity, out int entityId);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool PushExternalSubset(string systemId, string publicId);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void PushInternalDtd(string baseUri, string internalDtd);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void Throw(Exception e);
}

// Namespace: System.Xml
internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter // TypeDefIndex: 6598
{
	// Properties
	public abstract bool DtdValidation { get; }
	public abstract IValidationEventHandling ValidationEventHandling { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_DtdValidation();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IValidationEventHandling get_ValidationEventHandling();
}

// Namespace: System.Xml
internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 6599
{
	// Properties
	public abstract bool V1CompatibilityMode { get; }
	public abstract bool Normalization { get; }
	public abstract bool Namespaces { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_V1CompatibilityMode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Normalization();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_Namespaces();
}

// Namespace: System.Xml
internal sealed class OnRemoveWriter : MulticastDelegate // TypeDefIndex: 6600
{
	// Methods

	// RVA: 0x5C3910 Offset: 0x5C1F10 VA: 0x1805C3910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(XmlRawWriter writer) { }
}

// Namespace: System.Xml
internal interface IValidationEventHandling // TypeDefIndex: 6601
{
	// Properties
	public abstract object EventHandler { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_EventHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendEvent(Exception exception, XmlSeverityType severity);
}

// Namespace: System.Xml
internal abstract class IncrementalReadDecoder // TypeDefIndex: 6602
{
	// Properties
	internal abstract bool IsFull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool get_IsFull();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int Decode(char[] chars, int startPos, int len);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml
internal class IncrementalReadDummyDecoder : IncrementalReadDecoder // TypeDefIndex: 6603
{
	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x1CB7270 Offset: 0x1CB5870 VA: 0x181CB7270 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml
[Flags]
public enum NamespaceHandling // TypeDefIndex: 6604
{
	// Fields
	public int value__; // 0x0
	public const NamespaceHandling Default = 0;
	public const NamespaceHandling OmitDuplicates = 1;
}

// Namespace: System.Xml
public enum NewLineHandling // TypeDefIndex: 6605
{
	// Fields
	public int value__; // 0x0
	public const NewLineHandling Replace = 0;
	public const NewLineHandling Entitize = 1;
	public const NewLineHandling None = 2;
}

// Namespace: System.Xml
internal class QueryOutputWriter : XmlRawWriter // TypeDefIndex: 6606
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private bool inCDataSection; // 0x30
	private Dictionary<XmlQualifiedName, int> lookupCDataElems; // 0x38
	private BitStack bitsCData; // 0x40
	private XmlQualifiedName qnameCData; // 0x48
	private bool outputDocType; // 0x50
	private bool checkWellFormedDoc; // 0x51
	private bool hasDocElem; // 0x52
	private bool inAttr; // 0x53
	private string systemId; // 0x58
	private string publicId; // 0x60
	private int depth; // 0x68

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1CB7DB0 Offset: 0x1CB63B0 VA: 0x181CB7DB0
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1CB80A0 Offset: 0x1CB66A0 VA: 0x181CB80A0 Slot: 43
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1CB7D50 Offset: 0x1CB6350 VA: 0x181CB7D50 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1CB7D80 Offset: 0x1CB6380 VA: 0x181CB7D80 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1CB7670 Offset: 0x1CB5C70 VA: 0x181CB7670 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CB7A00 Offset: 0x1CB6000 VA: 0x181CB7A00 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CB76E0 Offset: 0x1CB5CE0 VA: 0x181CB76E0 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CB77A0 Offset: 0x1CB5DA0 VA: 0x181CB77A0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CB74E0 Offset: 0x1CB5AE0 VA: 0x181CB74E0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1CB79C0 Offset: 0x1CB5FC0 VA: 0x181CB79C0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CB76B0 Offset: 0x1CB5CB0 VA: 0x181CB76B0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1CB7800 Offset: 0x1CB5E00 VA: 0x181CB7800 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1CB8070 Offset: 0x1CB6670 VA: 0x181CB8070 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1CB7BD0 Offset: 0x1CB61D0 VA: 0x181CB7BD0 Slot: 52
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1CB7740 Offset: 0x1CB5D40 VA: 0x181CB7740 Slot: 53
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1CB7510 Offset: 0x1CB5B10 VA: 0x181CB7510 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CB7640 Offset: 0x1CB5C40 VA: 0x181CB7640 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1CB7830 Offset: 0x1CB5E30 VA: 0x181CB7830 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1CB7CC0 Offset: 0x1CB62C0 VA: 0x181CB7CC0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CB7C00 Offset: 0x1CB6200 VA: 0x181CB7C00 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1CB7570 Offset: 0x1CB5B70 VA: 0x181CB7570 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CB7770 Offset: 0x1CB5D70 VA: 0x181CB7770 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1CB7540 Offset: 0x1CB5B40 VA: 0x181CB7540 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CB7C90 Offset: 0x1CB6290 VA: 0x181CB7C90 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CB7860 Offset: 0x1CB5E60 VA: 0x181CB7860 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CB7930 Offset: 0x1CB5F30 VA: 0x181CB7930 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CB73C0 Offset: 0x1CB59C0 VA: 0x181CB73C0 Slot: 28
	public override void Close() { }

	// RVA: 0x1CB7470 Offset: 0x1CB5A70 VA: 0x181CB7470 Slot: 29
	public override void Flush() { }

	// RVA: 0x1CB74A0 Offset: 0x1CB5AA0 VA: 0x181CB74A0
	private bool StartCDataSection() { }

	// RVA: 0x3B5CA0 Offset: 0x3B42A0 VA: 0x1803B5CA0
	private void EndCDataSection() { }
}

// Namespace: System.Xml
internal class ReadContentAsBinaryHelper // TypeDefIndex: 6608
{
	// Fields
	private XmlReader reader; // 0x10
	private ReadContentAsBinaryHelper.State state; // 0x18
	private int valueOffset; // 0x1C
	private bool isEnd; // 0x20

	// Methods

	// RVA: 0x1CB80F0 Offset: 0x1CB66F0 VA: 0x181CB80F0
	internal void Finish() { }

	// RVA: 0x1CB8480 Offset: 0x1CB6A80 VA: 0x181CB8480
	internal void Reset() { }

	// RVA: 0x1CB8340 Offset: 0x1CB6940 VA: 0x181CB8340
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }
}

// Namespace: System.Xml
internal enum ElementProperties // TypeDefIndex: 6609
{
	// Fields
	public uint value__; // 0x0
	public const ElementProperties DEFAULT = 0;
	public const ElementProperties URI_PARENT = 1;
	public const ElementProperties BOOL_PARENT = 2;
	public const ElementProperties NAME_PARENT = 4;
	public const ElementProperties EMPTY = 8;
	public const ElementProperties NO_ENTITIES = 16;
	public const ElementProperties HEAD = 32;
	public const ElementProperties BLOCK_WS = 64;
	public const ElementProperties HAS_NS = 128;
}

// Namespace: System.Xml
internal enum AttributeProperties // TypeDefIndex: 6610
{
	// Fields
	public uint value__; // 0x0
	public const AttributeProperties DEFAULT = 0;
	public const AttributeProperties URI = 1;
	public const AttributeProperties BOOLEAN = 2;
	public const AttributeProperties NAME = 4;
}

// Namespace: System.Xml
internal class TernaryTreeReadOnly // TypeDefIndex: 6611
{
	// Fields
	private byte[] nodeBuffer; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(byte[] nodeBuffer) { }

	// RVA: 0x1CB87E0 Offset: 0x1CB6DE0 VA: 0x181CB87E0
	public byte FindCaseInsensitiveString(string stringToFind) { }
}

// Namespace: System.Xml
public enum ReadState // TypeDefIndex: 6612
{
	// Fields
	public int value__; // 0x0
	public const ReadState Initial = 0;
	public const ReadState Interactive = 1;
	public const ReadState Error = 2;
	public const ReadState EndOfFile = 3;
	public const ReadState Closed = 4;
}

// Namespace: System.Xml
internal class SecureStringHasher : IEqualityComparer<string> // TypeDefIndex: 6614
{
	// Fields
	private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x1CB87C0 Offset: 0x1CB6DC0 VA: 0x181CB87C0
	public void .ctor() { }

	// RVA: 0x1CB8490 Offset: 0x1CB6A90 VA: 0x181CB8490 Slot: 4
	public bool Equals(string x, string y) { }

	// RVA: 0x1CB8700 Offset: 0x1CB6D00 VA: 0x181CB8700 Slot: 5
	public int GetHashCode(string key) { }

	// RVA: 0x1CB8680 Offset: 0x1CB6C80 VA: 0x181CB8680
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

	// RVA: 0x1CB84B0 Offset: 0x1CB6AB0 VA: 0x181CB84B0
	private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }
}

// Namespace: System.Xml
internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 6615
{
	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1CB8AC0 Offset: 0x1CB70C0 VA: 0x181CB8AC0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1CB8AD0 Offset: 0x1CB70D0 VA: 0x181CB8AD0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1CB8AB0 Offset: 0x1CB70B0 VA: 0x181CB8AB0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CB8A30 Offset: 0x1CB7030 VA: 0x181CB8A30 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1CB8930 Offset: 0x1CB6F30 VA: 0x181CB8930 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CB8A40 Offset: 0x1CB7040 VA: 0x181CB8A40 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CB8A40 Offset: 0x1CB7040 VA: 0x181CB8A40 Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0x1CB89A0 Offset: 0x1CB6FA0 VA: 0x181CB89A0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CB89A0 Offset: 0x1CB6FA0 VA: 0x181CB89A0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CB8A40 Offset: 0x1CB7040 VA: 0x181CB8A40 Slot: 24
	public override void WriteRaw(string data) { }
}

// Namespace: System.Xml
internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 6616
{
	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1CB8B20 Offset: 0x1CB7120 VA: 0x181CB8B20
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1CB8AB0 Offset: 0x1CB70B0 VA: 0x181CB8AB0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CB8A30 Offset: 0x1CB7030 VA: 0x181CB8A30 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1CB8AE0 Offset: 0x1CB70E0 VA: 0x181CB8AE0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CB8B10 Offset: 0x1CB7110 VA: 0x181CB8B10 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CB8B10 Offset: 0x1CB7110 VA: 0x181CB8B10 Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0x1CB8AF0 Offset: 0x1CB70F0 VA: 0x181CB8AF0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CB8AF0 Offset: 0x1CB70F0 VA: 0x181CB8AF0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CB8B10 Offset: 0x1CB7110 VA: 0x181CB8B10 Slot: 24
	public override void WriteRaw(string data) { }
}

// Namespace: System.Xml
internal class ValidatingReaderNodeData // TypeDefIndex: 6617
{
	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private string nameWPrefix; // 0x28
	private string rawValue; // 0x30
	private string originalStringValue; // 0x38
	private int depth; // 0x40
	private AttributePSVIInfo attributePSVIInfo; // 0x48
	private XmlNodeType nodeType; // 0x50
	private int lineNo; // 0x54
	private int linePos; // 0x58

	// Properties
	public string LocalName { get; set; }
	public string Namespace { get; set; }
	public string Prefix { get; set; }
	public int Depth { get; set; }
	public string RawValue { get; set; }
	public string OriginalStringValue { get; }
	public XmlNodeType NodeType { get; set; }
	public AttributePSVIInfo AttInfo { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x1CB8E50 Offset: 0x1CB7450 VA: 0x181CB8E50
	public void .ctor() { }

	// RVA: 0x1CB8E20 Offset: 0x1CB7420 VA: 0x181CB8E20
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_LocalName() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_LocalName(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Namespace() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Namespace(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Prefix() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Prefix(string value) { }

	// RVA: 0x1CB8BF0 Offset: 0x1CB71F0 VA: 0x181CB8BF0
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	public int get_Depth() { }

	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	public void set_Depth(int value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_RawValue() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_RawValue(string value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_OriginalStringValue() { }

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public XmlNodeType get_NodeType() { }

	// RVA: 0x3AA880 Offset: 0x3A8E80 VA: 0x1803AA880
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x464C80 Offset: 0x463280 VA: 0x180464C80
	public int get_LineNumber() { }

	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0
	public int get_LinePosition() { }

	// RVA: 0x1CB8B30 Offset: 0x1CB7130 VA: 0x181CB8B30
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0x1CB8E10 Offset: 0x1CB7410 VA: 0x181CB8E10
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1CB8DA0 Offset: 0x1CB73A0 VA: 0x181CB8DA0
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x1CB8CA0 Offset: 0x1CB72A0 VA: 0x181CB8CA0
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x1CB8D60 Offset: 0x1CB7360 VA: 0x181CB8D60
	internal void SetItemData(string value) { }

	// RVA: 0x1CB8D20 Offset: 0x1CB7320 VA: 0x181CB8D20
	internal void SetItemData(string value, string originalStringValue) { }
}

// Namespace: System.Xml
public enum ValidationType // TypeDefIndex: 6618
{
	// Fields
	public int value__; // 0x0
	public const ValidationType None = 0;
	[Obsolete("Validation type should be specified as DTD or Schema.")]
	public const ValidationType Auto = 1;
	public const ValidationType DTD = 2;
	[Obsolete("XDR Validation through XmlValidatingReader is obsoleted")]
	public const ValidationType XDR = 3;
	public const ValidationType Schema = 4;
}

// Namespace: System.Xml
public enum WhitespaceHandling // TypeDefIndex: 6619
{
	// Fields
	public int value__; // 0x0
	public const WhitespaceHandling All = 0;
	public const WhitespaceHandling Significant = 1;
	public const WhitespaceHandling None = 2;
}

// Namespace: System.Xml
[DefaultMember("Item")]
internal class XmlAsyncCheckReader : XmlReader // TypeDefIndex: 6620
{
	// Fields
	private readonly XmlReader coreReader; // 0x10
	private Task lastTask; // 0x18

	// Properties
	internal XmlReader CoreReader { get; }
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override bool HasValue { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public override bool HasAttributes { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal XmlReader get_CoreReader() { }

	// RVA: 0x1CB9930 Offset: 0x1CB7F30 VA: 0x181CB9930
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x1CBA2F0 Offset: 0x1CB88F0 VA: 0x181CBA2F0
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1CB9860 Offset: 0x1CB7E60 VA: 0x181CB9860
	private void CheckAsync() { }

	// RVA: 0x1CBA8E0 Offset: 0x1CB8EE0 VA: 0x181CBA8E0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1CBA7A0 Offset: 0x1CB8DA0 VA: 0x181CBA7A0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1CBA6E0 Offset: 0x1CB8CE0 VA: 0x181CBA6E0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1CBA660 Offset: 0x1CB8C60 VA: 0x181CBA660 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1CBA760 Offset: 0x1CB8D60 VA: 0x181CBA760 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1CBA7E0 Offset: 0x1CB8DE0 VA: 0x181CBA7E0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1CBA5A0 Offset: 0x1CB8BA0 VA: 0x181CBA5A0 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x1CBAA20 Offset: 0x1CB9020 VA: 0x181CBAA20 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1CBA4A0 Offset: 0x1CB8AA0 VA: 0x181CBA4A0 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1CBA3E0 Offset: 0x1CB89E0 VA: 0x181CBA3E0 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x1CBA620 Offset: 0x1CB8C20 VA: 0x181CBA620 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1CBA5E0 Offset: 0x1CB8BE0 VA: 0x181CBA5E0 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x1CBA820 Offset: 0x1CB8E20 VA: 0x181CBA820 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1CBAAA0 Offset: 0x1CB90A0 VA: 0x181CBAAA0 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1CBAA60 Offset: 0x1CB9060 VA: 0x181CBAA60 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x1CBA8A0 Offset: 0x1CB8EA0 VA: 0x181CBA8A0 Slot: 20
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1CBA9E0 Offset: 0x1CB8FE0 VA: 0x181CBA9E0 Slot: 21
	public override Type get_ValueType() { }

	// RVA: 0x1CB9FF0 Offset: 0x1CB85F0 VA: 0x181CB9FF0 Slot: 22
	public override string ReadContentAsString() { }

	// RVA: 0x1CBA3A0 Offset: 0x1CB89A0 VA: 0x181CBA3A0 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1CB9C70 Offset: 0x1CB8270 VA: 0x181CB9C70 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1CB9CC0 Offset: 0x1CB82C0 VA: 0x181CB9CC0 Slot: 25
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1CB9C20 Offset: 0x1CB8220 VA: 0x181CB9C20 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1CB9E60 Offset: 0x1CB8460 VA: 0x181CB9E60 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1CB9E10 Offset: 0x1CB8410 VA: 0x181CB9E10 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1CB9F30 Offset: 0x1CB8530 VA: 0x181CB9F30 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1CB9F70 Offset: 0x1CB8570 VA: 0x181CB9F70 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1CB9EF0 Offset: 0x1CB84F0 VA: 0x181CB9EF0 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1CB9FB0 Offset: 0x1CB85B0 VA: 0x181CB9FB0 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1CBA230 Offset: 0x1CB8830 VA: 0x181CBA230 Slot: 33
	public override bool Read() { }

	// RVA: 0x1CBA520 Offset: 0x1CB8B20 VA: 0x181CBA520 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x1CB98F0 Offset: 0x1CB7EF0 VA: 0x181CB98F0 Slot: 35
	public override void Close() { }

	// RVA: 0x1CBA860 Offset: 0x1CB8E60 VA: 0x181CBA860 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1CBA2B0 Offset: 0x1CB88B0 VA: 0x181CBA2B0 Slot: 37
	public override void Skip() { }

	// RVA: 0x1CBA6A0 Offset: 0x1CB8CA0 VA: 0x181CBA6A0 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1CB9DC0 Offset: 0x1CB83C0 VA: 0x181CB9DC0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1CBA460 Offset: 0x1CB8A60 VA: 0x181CBA460 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1CBA270 Offset: 0x1CB8870 VA: 0x181CBA270 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1CBA420 Offset: 0x1CB8A20 VA: 0x181CBA420 Slot: 42
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1CBA1C0 Offset: 0x1CB87C0 VA: 0x181CBA1C0 Slot: 43
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x1CBA180 Offset: 0x1CB8780 VA: 0x181CBA180 Slot: 44
	public override string ReadString() { }

	// RVA: 0x1CB9EB0 Offset: 0x1CB84B0 VA: 0x181CB9EB0 Slot: 45
	public override XmlNodeType MoveToContent() { }

	// RVA: 0x1CBA140 Offset: 0x1CB8740 VA: 0x181CBA140 Slot: 46
	public override void ReadStartElement() { }

	// RVA: 0x1CBA0F0 Offset: 0x1CB86F0 VA: 0x181CBA0F0 Slot: 47
	public override void ReadStartElement(string name) { }

	// RVA: 0x1CBA030 Offset: 0x1CB8630 VA: 0x181CBA030 Slot: 48
	public override string ReadElementString() { }

	// RVA: 0x1CBA070 Offset: 0x1CB8670 VA: 0x181CBA070 Slot: 49
	public override void ReadEndElement() { }

	// RVA: 0x1CB9D20 Offset: 0x1CB8320 VA: 0x181CB9D20 Slot: 50
	public override bool IsStartElement() { }

	// RVA: 0x1CB9D60 Offset: 0x1CB8360 VA: 0x181CB9D60 Slot: 51
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1CBA0B0 Offset: 0x1CB86B0 VA: 0x181CBA0B0 Slot: 52
	public override string ReadInnerXml() { }

	// RVA: 0x1CBA560 Offset: 0x1CB8B60 VA: 0x181CBA560 Slot: 53
	public override bool get_HasAttributes() { }

	// RVA: 0x1CB9BE0 Offset: 0x1CB81E0 VA: 0x181CB9BE0 Slot: 54
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1CBA720 Offset: 0x1CB8D20 VA: 0x181CBA720 Slot: 55
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1CBA4E0 Offset: 0x1CB8AE0 VA: 0x181CBA4E0 Slot: 56
	internal override IDtdInfo get_DtdInfo() { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 6621
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x1CB97B0 Offset: 0x1CB7DB0 VA: 0x181CB97B0
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1CB9690 Offset: 0x1CB7C90 VA: 0x181CB9690 Slot: 57
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1CB96F0 Offset: 0x1CB7CF0 VA: 0x181CB96F0 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1CB9750 Offset: 0x1CB7D50 VA: 0x181CB9750 Slot: 59
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 6622
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0x1CB9540 Offset: 0x1CB7B40 VA: 0x181CB9540
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1CB94F0 Offset: 0x1CB7AF0 VA: 0x181CB94F0 Slot: 60
	public virtual bool HasLineInfo() { }

	// RVA: 0x1CB95F0 Offset: 0x1CB7BF0 VA: 0x181CB95F0 Slot: 61
	public virtual int get_LineNumber() { }

	// RVA: 0x1CB9640 Offset: 0x1CB7C40 VA: 0x181CB9640 Slot: 62
	public virtual int get_LinePosition() { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver // TypeDefIndex: 6623
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0x1CB9440 Offset: 0x1CB7A40 VA: 0x181CB9440
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1CB9320 Offset: 0x1CB7920 VA: 0x181CB9320 Slot: 63
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1CB9380 Offset: 0x1CB7980 VA: 0x181CB9380 Slot: 64
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1CB93E0 Offset: 0x1CB79E0 VA: 0x181CB93E0 Slot: 65
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS, IXmlSchemaInfo // TypeDefIndex: 6624
{
	// Fields
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30

	// Properties
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }

	// Methods

	// RVA: 0x1CB9270 Offset: 0x1CB7870 VA: 0x181CB9270
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1CB9220 Offset: 0x1CB7820 VA: 0x181CB9220 Slot: 66
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1CB8E80 Offset: 0x1CB7480 VA: 0x181CB8E80 Slot: 67
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1CB8ED0 Offset: 0x1CB74D0 VA: 0x181CB8ED0 Slot: 68
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x1CB8F20 Offset: 0x1CB7520 VA: 0x181CB8F20 Slot: 69
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x1CB9160 Offset: 0x1CB7760 VA: 0x181CB9160 Slot: 70
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1CB90A0 Offset: 0x1CB76A0 VA: 0x181CB90A0 Slot: 71
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x1CB8FE0 Offset: 0x1CB75E0 VA: 0x181CB8FE0 Slot: 72
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckWriter : XmlWriter // TypeDefIndex: 6625
{
	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Properties
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x1CBB790 Offset: 0x1CB9D90 VA: 0x181CBB790
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1CBAAE0 Offset: 0x1CB90E0 VA: 0x181CBAAE0
	private void CheckAsync() { }

	// RVA: 0x1CBB310 Offset: 0x1CB9910 VA: 0x181CBB310 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1CBB2C0 Offset: 0x1CB98C0 VA: 0x181CBB2C0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1CBAFC0 Offset: 0x1CB95C0 VA: 0x181CBAFC0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1CBAF10 Offset: 0x1CB9510 VA: 0x181CBAF10 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CBB350 Offset: 0x1CB9950 VA: 0x181CBB350 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CBB000 Offset: 0x1CB9600 VA: 0x181CBB000 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1CBB090 Offset: 0x1CB9690 VA: 0x181CBB090 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1CBB250 Offset: 0x1CB9850 VA: 0x181CBB250 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CBAF80 Offset: 0x1CB9580 VA: 0x181CBAF80 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1CBADB0 Offset: 0x1CB93B0 VA: 0x181CBADB0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CBAEC0 Offset: 0x1CB94C0 VA: 0x181CBAEC0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1CBB130 Offset: 0x1CB9730 VA: 0x181CBB130 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1CBB040 Offset: 0x1CB9640 VA: 0x181CBB040 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1CBAE00 Offset: 0x1CB9400 VA: 0x181CBAE00 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CBB740 Offset: 0x1CB9D40 VA: 0x181CBB740 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CBB3C0 Offset: 0x1CB99C0 VA: 0x181CBB3C0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1CBB410 Offset: 0x1CB9A10 VA: 0x181CBB410 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CBAE50 Offset: 0x1CB9450 VA: 0x181CBAE50 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CBB190 Offset: 0x1CB9790 VA: 0x181CBB190 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CBB200 Offset: 0x1CB9800 VA: 0x181CBB200 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CBACD0 Offset: 0x1CB92D0 VA: 0x181CBACD0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1CBAD40 Offset: 0x1CB9340 VA: 0x181CBAD40 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1CBB820 Offset: 0x1CB9E20 VA: 0x181CBB820 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1CBAB70 Offset: 0x1CB9170 VA: 0x181CBAB70 Slot: 28
	public override void Close() { }

	// RVA: 0x1CBABE0 Offset: 0x1CB91E0 VA: 0x181CBABE0 Slot: 29
	public override void Flush() { }

	// RVA: 0x1CBAC20 Offset: 0x1CB9220 VA: 0x181CBAC20 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1CBB6F0 Offset: 0x1CB9CF0 VA: 0x181CBB6F0 Slot: 31
	public override void WriteValue(object value) { }

	// RVA: 0x1CBB650 Offset: 0x1CB9C50 VA: 0x181CBB650 Slot: 32
	public override void WriteValue(string value) { }

	// RVA: 0x1CBB4C0 Offset: 0x1CB9AC0 VA: 0x181CBB4C0 Slot: 33
	public override void WriteValue(bool value) { }

	// RVA: 0x1CBB560 Offset: 0x1CB9B60 VA: 0x181CBB560 Slot: 34
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1CBB600 Offset: 0x1CB9C00 VA: 0x181CBB600 Slot: 35
	public override void WriteValue(double value) { }

	// RVA: 0x1CBB510 Offset: 0x1CB9B10 VA: 0x181CBB510 Slot: 36
	public override void WriteValue(float value) { }

	// RVA: 0x1CBB470 Offset: 0x1CB9A70 VA: 0x181CBB470 Slot: 37
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1CBB5B0 Offset: 0x1CB9BB0 VA: 0x181CBB5B0 Slot: 38
	public override void WriteValue(int value) { }

	// RVA: 0x1CBB6A0 Offset: 0x1CB9CA0 VA: 0x181CBB6A0 Slot: 39
	public override void WriteValue(long value) { }

	// RVA: 0x1CBAC70 Offset: 0x1CB9270 VA: 0x181CBAC70 Slot: 40
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1CBB0D0 Offset: 0x1CB96D0 VA: 0x181CBB0D0 Slot: 41
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1CBABB0 Offset: 0x1CB91B0 VA: 0x181CBABB0 Slot: 42
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Xml
internal class XmlAutoDetectWriter : XmlRawWriter // TypeDefIndex: 6626
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private OnRemoveWriter onRemove; // 0x30
	private XmlWriterSettings writerSettings; // 0x38
	private XmlEventCache eventCache; // 0x40
	private TextWriter textWriter; // 0x48
	private Stream strm; // 0x50

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1CBC870 Offset: 0x1CBAE70 VA: 0x181CBC870
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0x1CBC830 Offset: 0x1CBAE30 VA: 0x181CBC830
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0x1CBC7F0 Offset: 0x1CBADF0 VA: 0x181CBC7F0
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0x1CBBE60 Offset: 0x1CBA460 VA: 0x181CBBE60 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CBC1A0 Offset: 0x1CBA7A0 VA: 0x181CBC1A0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CBC120 Offset: 0x1CBA720 VA: 0x181CBC120 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CBBEE0 Offset: 0x1CBA4E0 VA: 0x181CBBEE0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1CBBD10 Offset: 0x1CBA310 VA: 0x181CBBD10 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CBBE20 Offset: 0x1CBA420 VA: 0x181CBBE20 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1CBC020 Offset: 0x1CBA620 VA: 0x181CBC020 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1CBC710 Offset: 0x1CBAD10 VA: 0x181CBC710 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CBC350 Offset: 0x1CBA950 VA: 0x181CBC350 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1CBBDE0 Offset: 0x1CBA3E0 VA: 0x181CBBDE0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CBC060 Offset: 0x1CBA660 VA: 0x181CBC060 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CBC0A0 Offset: 0x1CBA6A0 VA: 0x181CBC0A0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CBBF40 Offset: 0x1CBA540 VA: 0x181CBBF40 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1CBBD90 Offset: 0x1CBA390 VA: 0x181CBBD90 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CBC3D0 Offset: 0x1CBA9D0 VA: 0x181CBC3D0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CBBC10 Offset: 0x1CBA210 VA: 0x181CBBC10 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1CBBC90 Offset: 0x1CBA290 VA: 0x181CBBC90 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1CBB860 Offset: 0x1CB9E60 VA: 0x181CBB860 Slot: 28
	public override void Close() { }

	// RVA: 0x1CBBA90 Offset: 0x1CBA090 VA: 0x181CBBA90 Slot: 29
	public override void Flush() { }

	// RVA: 0x1CBC620 Offset: 0x1CBAC20 VA: 0x181CBC620 Slot: 31
	public override void WriteValue(object value) { }

	// RVA: 0x1CBC490 Offset: 0x1CBAA90 VA: 0x181CBC490 Slot: 32
	public override void WriteValue(string value) { }

	// RVA: 0x1CBC580 Offset: 0x1CBAB80 VA: 0x181CBC580 Slot: 33
	public override void WriteValue(bool value) { }

	// RVA: 0x1CBC530 Offset: 0x1CBAB30 VA: 0x181CBC530 Slot: 34
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1CBC5D0 Offset: 0x1CBABD0 VA: 0x181CBC5D0 Slot: 35
	public override void WriteValue(double value) { }

	// RVA: 0x1CBC670 Offset: 0x1CBAC70 VA: 0x181CBC670 Slot: 36
	public override void WriteValue(float value) { }

	// RVA: 0x1CBC430 Offset: 0x1CBAA30 VA: 0x181CBC430 Slot: 37
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1CBC4E0 Offset: 0x1CBAAE0 VA: 0x181CBC4E0 Slot: 38
	public override void WriteValue(int value) { }

	// RVA: 0x1CBC6C0 Offset: 0x1CBACC0 VA: 0x181CBC6C0 Slot: 39
	public override void WriteValue(long value) { }

	// RVA: 0x1CBC950 Offset: 0x1CBAF50 VA: 0x181CBC950 Slot: 43
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1CBC750 Offset: 0x1CBAD50 VA: 0x181CBC750 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1CBC7A0 Offset: 0x1CBADA0 VA: 0x181CBC7A0 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1CB74E0 Offset: 0x1CB5AE0 VA: 0x181CB74E0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1CBBF10 Offset: 0x1CBA510 VA: 0x181CBBF10 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CBBF90 Offset: 0x1CBA590 VA: 0x181CBBF90 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CBBFC0 Offset: 0x1CBA5C0 VA: 0x181CBBFC0 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1CB8070 Offset: 0x1CB6670 VA: 0x181CB8070 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1CBC300 Offset: 0x1CBA900 VA: 0x181CBC300 Slot: 52
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1CB7740 Offset: 0x1CB5D40 VA: 0x181CB7740 Slot: 53
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1CBBAD0 Offset: 0x1CBA0D0 VA: 0x181CBBAD0
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0x1CBBA80 Offset: 0x1CBA080 VA: 0x181CBBA80
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0x1CBBBB0 Offset: 0x1CBA1B0 VA: 0x181CBBBB0
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0x1CBB8A0 Offset: 0x1CB9EA0 VA: 0x181CBB8A0
	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }
}

// Namespace: System.Xml
internal class XmlEncodedRawTextWriter : XmlRawWriter // TypeDefIndex: 6627
{
	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected int bufBytesUsed; // 0x6C
	protected char[] bufChars; // 0x70
	protected Encoder encoder; // 0x78
	protected TextWriter writer; // 0x80
	protected bool trackTextContent; // 0x88
	protected bool inTextContent; // 0x89
	private int lastMarkPos; // 0x8C
	private int[] textContentMarks; // 0x90
	private CharEntityEncoderFallback charEntityFallback; // 0x98
	protected NewLineHandling newLineHandling; // 0xA0
	protected bool closeOutput; // 0xA4
	protected bool omitXmlDeclaration; // 0xA5
	protected string newLineChars; // 0xA8
	protected bool checkCharacters; // 0xB0
	protected XmlStandalone standalone; // 0xB4
	protected XmlOutputMethod outputMethod; // 0xB8
	protected bool autoXmlDeclaration; // 0xBC
	protected bool mergeCDataSections; // 0xBD

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1CC1450 Offset: 0x1CBFA50 VA: 0x181CC1450
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1CC18E0 Offset: 0x1CBFEE0 VA: 0x181CC18E0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1CC1560 Offset: 0x1CBFB60 VA: 0x181CC1560
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1CC1190 Offset: 0x1CBF790 VA: 0x181CC1190 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1CC13E0 Offset: 0x1CBF9E0 VA: 0x181CC13E0 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1CBFA90 Offset: 0x1CBE090 VA: 0x181CBFA90 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CC0C90 Offset: 0x1CBF290 VA: 0x181CC0C90 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CBE630 Offset: 0x1CBCC30 VA: 0x181CBE630 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1CC0140 Offset: 0x1CBE740 VA: 0x181CC0140 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CC0440 Offset: 0x1CBEA40 VA: 0x181CC0440 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CC0B40 Offset: 0x1CBF140 VA: 0x181CC0B40 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CC00D0 Offset: 0x1CBE6D0 VA: 0x181CC00D0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1CC0590 Offset: 0x1CBEB90 VA: 0x181CC0590 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1CC0D90 Offset: 0x1CBF390 VA: 0x181CC0D90 Slot: 52
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1CC02F0 Offset: 0x1CBE8F0 VA: 0x181CC02F0 Slot: 53
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1CBF100 Offset: 0x1CBD700 VA: 0x181CBF100 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CBF920 Offset: 0x1CBDF20 VA: 0x181CBF920 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1CC0680 Offset: 0x1CBEC80 VA: 0x181CC0680 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1CC0360 Offset: 0x1CBE960 VA: 0x181CC0360 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1CBF360 Offset: 0x1CBD960 VA: 0x181CBF360 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CC1110 Offset: 0x1CBF710 VA: 0x181CC1110 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CC0F10 Offset: 0x1CBF510 VA: 0x181CC0F10 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1CC0F90 Offset: 0x1CBF590 VA: 0x181CC0F90 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1BB67F0 Offset: 0x1BB4DF0 VA: 0x181BB67F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CC0AB0 Offset: 0x1CBF0B0 VA: 0x181CC0AB0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CB8930 Offset: 0x1CB6F30 VA: 0x181CB8930 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CBD860 Offset: 0x1CBBE60 VA: 0x181CBD860 Slot: 28
	public override void Close() { }

	// RVA: 0x1CBE150 Offset: 0x1CBC750 VA: 0x181CBE150 Slot: 29
	public override void Flush() { }

	// RVA: 0x1CBDCA0 Offset: 0x1CBC2A0 VA: 0x181CBDCA0 Slot: 56
	protected virtual void FlushBuffer() { }

	// RVA: 0x1CBD9B0 Offset: 0x1CBBFB0 VA: 0x181CBD9B0
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x1CBE080 Offset: 0x1CBC680 VA: 0x181CBE080
	private void FlushEncoder() { }

	// RVA: 0x1CBEA30 Offset: 0x1CBD030 VA: 0x181CBEA30
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1CBFD80 Offset: 0x1CBE380 VA: 0x181CBFD80
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1CBE5E0 Offset: 0x1CBCBE0 VA: 0x181CBE5E0
	protected void RawText(string s) { }

	// RVA: 0x1CBE440 Offset: 0x1CBCA40 VA: 0x181CBE440
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1CC07F0 Offset: 0x1CBEDF0 VA: 0x181CC07F0
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1CBF550 Offset: 0x1CBDB50 VA: 0x181CBF550
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1CBED40 Offset: 0x1CBD340 VA: 0x181CBED40
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1CBDB30 Offset: 0x1CBC130 VA: 0x181CBDB30
	private static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst) { }

	// RVA: 0x1CBE280 Offset: 0x1CBC880 VA: 0x181CBE280
	private char* InvalidXmlChar(int ch, char* pDst, bool entitize) { }

	// RVA: 0x1CBD8D0 Offset: 0x1CBBED0 VA: 0x181CBD8D0
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst) { }

	// RVA: 0x1CBD6C0 Offset: 0x1CBBCC0 VA: 0x181CBD6C0
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x1CBE1D0 Offset: 0x1CBC7D0 VA: 0x181CBE1D0
	private void GrowTextContentMarks() { }

	// RVA: 0x1CC05F0 Offset: 0x1CBEBF0 VA: 0x181CC05F0
	protected char* WriteNewLine(char* pDst) { }

	// RVA: 0x1CBE3B0 Offset: 0x1CBC9B0 VA: 0x181CBE3B0
	protected static char* LtEntity(char* pDst) { }

	// RVA: 0x1CBE260 Offset: 0x1CBC860 VA: 0x181CBE260
	protected static char* GtEntity(char* pDst) { }

	// RVA: 0x1CBD680 Offset: 0x1CBBC80 VA: 0x181CBD680
	protected static char* AmpEntity(char* pDst) { }

	// RVA: 0x1CBE3D0 Offset: 0x1CBC9D0 VA: 0x181CBE3D0
	protected static char* QuoteEntity(char* pDst) { }

	// RVA: 0x1CBE680 Offset: 0x1CBCC80 VA: 0x181CBE680
	protected static char* TabEntity(char* pDst) { }

	// RVA: 0x1CBE390 Offset: 0x1CBC990 VA: 0x181CBE390
	protected static char* LineFeedEntity(char* pDst) { }

	// RVA: 0x1CBD6A0 Offset: 0x1CBBCA0 VA: 0x181CBD6A0
	protected static char* CarriageReturnEntity(char* pDst) { }

	// RVA: 0x1CBD7B0 Offset: 0x1CBBDB0 VA: 0x181CBD7B0
	private static char* CharEntity(char* pDst, char ch) { }

	// RVA: 0x1CBE410 Offset: 0x1CBCA10 VA: 0x181CBE410
	protected static char* RawStartCData(char* pDst) { }

	// RVA: 0x1CBE3F0 Offset: 0x1CBC9F0 VA: 0x181CBE3F0
	protected static char* RawEndCData(char* pDst) { }

	// RVA: 0x1CBE6A0 Offset: 0x1CBCCA0 VA: 0x181CBE6A0
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }
}

// Namespace: System.Xml
internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter // TypeDefIndex: 6628
{
	// Fields
	protected int indentLevel; // 0xC0
	protected bool newLineOnAttributes; // 0xC4
	protected string indentChars; // 0xC8
	protected bool mixedContent; // 0xD0
	private BitStack mixedContentStack; // 0xD8
	protected ConformanceLevel conformanceLevel; // 0xE0

	// Methods

	// RVA: 0x1CBD620 Offset: 0x1CBBC20 VA: 0x181CBD620
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1CBD650 Offset: 0x1CBBC50 VA: 0x181CBD650
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1CBCE00 Offset: 0x1CBB400 VA: 0x181CBCE00 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CBD3D0 Offset: 0x1CBB9D0 VA: 0x181CBD3D0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CBCBC0 Offset: 0x1CBB1C0 VA: 0x181CBCBC0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x16EE3B0 Offset: 0x16EC9B0 VA: 0x1816EE3B0 Slot: 47
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x1CBCE70 Offset: 0x1CBB470 VA: 0x181CBCE70 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CBCFF0 Offset: 0x1CBB5F0 VA: 0x181CBCFF0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CBD370 Offset: 0x1CBB970 VA: 0x181CBD370 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CBCD00 Offset: 0x1CBB300 VA: 0x181CBCD00 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CBCDC0 Offset: 0x1CBB3C0 VA: 0x181CBCDC0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1CBD220 Offset: 0x1CBB820 VA: 0x181CBD220 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1CBCF00 Offset: 0x1CBB500 VA: 0x181CBCF00 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1CBCD10 Offset: 0x1CBB310 VA: 0x181CBCD10 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CBD590 Offset: 0x1CBBB90 VA: 0x181CBD590 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CBD5A0 Offset: 0x1CBBBA0 VA: 0x181CBD5A0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CBD510 Offset: 0x1CBBB10 VA: 0x181CBD510 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1CBCD20 Offset: 0x1CBB320 VA: 0x181CBCD20 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CBD270 Offset: 0x1CBB870 VA: 0x181CBD270 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CBD300 Offset: 0x1CBB900 VA: 0x181CBD300 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CBCC40 Offset: 0x1CBB240 VA: 0x181CBCC40 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1CBCA90 Offset: 0x1CBB090 VA: 0x181CBCA90
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1CBD180 Offset: 0x1CBB780 VA: 0x181CBD180
	private void WriteIndent() { }
}

// Namespace: System.Xml
internal sealed class XmlEventCache : XmlRawWriter // TypeDefIndex: 6631
{
	// Fields
	private List<XmlEventCache.XmlEvent[]> pages; // 0x28
	private XmlEventCache.XmlEvent[] pageCurr; // 0x30
	private int pageSize; // 0x38
	private bool hasRootNode; // 0x3C
	private StringConcat singleText; // 0x40
	private string baseUri; // 0x78

	// Methods

	// RVA: 0x1CC3340 Offset: 0x1CC1940 VA: 0x181CC3340
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x1CC1DE0 Offset: 0x1CC03E0 VA: 0x181CC1DE0
	public void EndEvents() { }

	// RVA: 0x1CC1E30 Offset: 0x1CC0430 VA: 0x181CC1E30
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x1CC2CE0 Offset: 0x1CC12E0 VA: 0x181CC2CE0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CC2FC0 Offset: 0x1CC15C0 VA: 0x181CC2FC0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CC2F90 Offset: 0x1CC1590 VA: 0x181CC2F90 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CC2D90 Offset: 0x1CC1390 VA: 0x181CC2D90 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1CC2BA0 Offset: 0x1CC11A0 VA: 0x181CC2BA0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CC2C80 Offset: 0x1CC1280 VA: 0x181CC2C80 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1CC2F00 Offset: 0x1CC1500 VA: 0x181CC2F00 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1CC31E0 Offset: 0x1CC17E0 VA: 0x181CC31E0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CC2FF0 Offset: 0x1CC15F0 VA: 0x181CC2FF0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1CBBDE0 Offset: 0x1CBA3E0 VA: 0x181CBBDE0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CBC060 Offset: 0x1CBA660 VA: 0x181CBC060 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CC2F30 Offset: 0x1CC1530 VA: 0x181CC2F30 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CC2E40 Offset: 0x1CC1440 VA: 0x181CC2E40 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1CC2C00 Offset: 0x1CC1200 VA: 0x181CC2C00 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CC3070 Offset: 0x1CC1670 VA: 0x181CC3070 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CC2AA0 Offset: 0x1CC10A0 VA: 0x181CC2AA0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1CC2B20 Offset: 0x1CC1120 VA: 0x181CC2B20 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1CC1CF0 Offset: 0x1CC02F0 VA: 0x181CC1CF0 Slot: 28
	public override void Close() { }

	// RVA: 0x1CC27D0 Offset: 0x1CC0DD0 VA: 0x181CC27D0 Slot: 29
	public override void Flush() { }

	// RVA: 0x1CC3140 Offset: 0x1CC1740 VA: 0x181CC3140 Slot: 31
	public override void WriteValue(object value) { }

	// RVA: 0x1AB1830 Offset: 0x1AAFE30 VA: 0x181AB1830 Slot: 32
	public override void WriteValue(string value) { }

	// RVA: 0x1CC1D30 Offset: 0x1CC0330 VA: 0x181CC1D30 Slot: 42
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1CC3240 Offset: 0x1CC1840 VA: 0x181CC3240 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1CC32E0 Offset: 0x1CC18E0 VA: 0x181CC32E0 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1CC29A0 Offset: 0x1CC0FA0 VA: 0x181CC29A0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1CC2E10 Offset: 0x1CC1410 VA: 0x181CC2E10 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CC2EA0 Offset: 0x1CC14A0 VA: 0x181CC2EA0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CC2ED0 Offset: 0x1CC14D0 VA: 0x181CC2ED0 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1CC2DD0 Offset: 0x1CC13D0 VA: 0x181CC2DD0 Slot: 54
	internal override void WriteEndBase64() { }

	// RVA: 0x1CC1A80 Offset: 0x1CC0080 VA: 0x181CC1A80
	private void AddEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0x1CC1BF0 Offset: 0x1CC01F0 VA: 0x181CC1BF0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x1CC1C60 Offset: 0x1CC0260 VA: 0x181CC1C60
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x1CC19E0 Offset: 0x1CBFFE0 VA: 0x181CC19E0
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1CC1B40 Offset: 0x1CC0140 VA: 0x181CC1B40
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1CC1AD0 Offset: 0x1CC00D0 VA: 0x181CC1AD0
	private void AddEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x1CC2810 Offset: 0x1CC0E10 VA: 0x181CC2810
	private int NewEvent() { }

	// RVA: 0x1CC29E0 Offset: 0x1CC0FE0 VA: 0x181CC29E0
	private static byte[] ToBytes(byte[] buffer, int index, int count) { }
}

// Namespace: System.Xml
public class XmlParserContext // TypeDefIndex: 6632
{
	// Fields
	private XmlNameTable _nt; // 0x10
	private XmlNamespaceManager _nsMgr; // 0x18
	private string _docTypeName; // 0x20
	private string _pubId; // 0x28
	private string _sysId; // 0x30
	private string _internalSubset; // 0x38
	private string _xmlLang; // 0x40
	private XmlSpace _xmlSpace; // 0x48
	private string _baseURI; // 0x50
	private Encoding _encoding; // 0x58

	// Properties
	public XmlNameTable NameTable { get; }
	public XmlNamespaceManager NamespaceManager { get; }
	public string DocTypeName { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string BaseURI { get; }
	public string InternalSubset { get; }
	public string XmlLang { get; }
	public XmlSpace XmlSpace { get; }
	public Encoding Encoding { get; }
	internal bool HasDtdInfo { get; }

	// Methods

	// RVA: 0x1CC34A0 Offset: 0x1CC1AA0 VA: 0x181CC34A0
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x1CC3500 Offset: 0x1CC1B00 VA: 0x181CC3500
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x1CC3570 Offset: 0x1CC1B70 VA: 0x181CC3570
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public XmlNameTable get_NameTable() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_DocTypeName() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_PublicId() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_SystemId() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_BaseURI() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_InternalSubset() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_XmlLang() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public Encoding get_Encoding() { }

	// RVA: 0x1CC3820 Offset: 0x1CC1E20 VA: 0x181CC3820
	internal bool get_HasDtdInfo() { }
}

// Namespace: System.Xml
internal abstract class XmlRawWriter : XmlWriter // TypeDefIndex: 6633
{
	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal virtual IXmlNamespaceResolver NamespaceResolver { set; }
	internal virtual bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1CC3CD0 Offset: 0x1CC22D0 VA: 0x181CC3CD0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1CC3D30 Offset: 0x1CC2330 VA: 0x181CC3D30 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1CC3AF0 Offset: 0x1CC20F0 VA: 0x181CC3AF0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CC3B50 Offset: 0x1CC2150 VA: 0x181CC3B50 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1CC3BF0 Offset: 0x1CC21F0 VA: 0x181CC3BF0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1CC3980 Offset: 0x1CC1F80 VA: 0x181CC3980 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1CC38C0 Offset: 0x1CC1EC0 VA: 0x181CC38C0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1CC3F60 Offset: 0x1CC2560 VA: 0x181CC3F60 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1AB1830 Offset: 0x1AAFE30 VA: 0x181AB1830 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CC3A40 Offset: 0x1CC2040 VA: 0x181CC3A40 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CC3DD0 Offset: 0x1CC23D0 VA: 0x181CC3DD0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1AB1830 Offset: 0x1AAFE30 VA: 0x181AB1830 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CBBDE0 Offset: 0x1CBA3E0 VA: 0x181CBBDE0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CBBDE0 Offset: 0x1CBA3E0 VA: 0x181CBBDE0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1AB1830 Offset: 0x1AAFE30 VA: 0x181AB1830 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CC3E70 Offset: 0x1CC2470 VA: 0x181CC3E70 Slot: 31
	public override void WriteValue(object value) { }

	// RVA: 0x1AB1830 Offset: 0x1AAFE30 VA: 0x181AB1830 Slot: 32
	public override void WriteValue(string value) { }

	// RVA: 0x1CC3920 Offset: 0x1CC1F20 VA: 0x181CC3920 Slot: 40
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1CC3C70 Offset: 0x1CC2270 VA: 0x181CC3C70 Slot: 41
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10 Slot: 43
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 45
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1 Offset: -1 Slot: 46
	internal abstract void StartElementContent();

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 47
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1 Offset: -1 Slot: 48
	internal abstract void WriteEndElement(string prefix, string localName, string ns);

	// RVA: 0x1CC3C50 Offset: 0x1CC2250 VA: 0x181CC3C50 Slot: 49
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 50
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 51
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1CC3D90 Offset: 0x1CC2390 VA: 0x181CC3D90 Slot: 52
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1CC3BB0 Offset: 0x1CC21B0 VA: 0x181CC3BB0 Slot: 53
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1CC3AD0 Offset: 0x1CC20D0 VA: 0x181CC3AD0 Slot: 54
	internal virtual void WriteEndBase64() { }

	// RVA: 0x1CC38A0 Offset: 0x1CC1EA0 VA: 0x181CC38A0 Slot: 55
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: System.Xml
[DefaultMember("Item")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XmlReader : IDisposable // TypeDefIndex: 6634
{
	// Fields
	private static uint IsTextualNodeBitmap; // 0x0
	private static uint CanReadContentAsBitmap; // 0x4
	private static uint HasValueBitmap; // 0x8

	// Properties
	public virtual XmlReaderSettings Settings { get; }
	public abstract XmlNodeType NodeType { get; }
	public virtual string Name { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public virtual bool HasValue { get; }
	public abstract string Value { get; }
	public abstract int Depth { get; }
	public abstract string BaseURI { get; }
	public abstract bool IsEmptyElement { get; }
	public virtual bool IsDefault { get; }
	public virtual char QuoteChar { get; }
	public virtual XmlSpace XmlSpace { get; }
	public virtual string XmlLang { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual Type ValueType { get; }
	public abstract int AttributeCount { get; }
	public abstract bool EOF { get; }
	public abstract ReadState ReadState { get; }
	public abstract XmlNameTable NameTable { get; }
	public virtual bool CanResolveEntity { get; }
	public virtual bool CanReadValueChunk { get; }
	public virtual bool HasAttributes { get; }
	internal virtual XmlNamespaceManager NamespaceManager { get; }
	internal bool IsDefaultInternal { get; }
	internal virtual IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x1CC8060 Offset: 0x1CC6660 VA: 0x181CC8060 Slot: 7
	public virtual string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_Prefix();

	// RVA: 0x1CC7F20 Offset: 0x1CC6520 VA: 0x181CC7F20 Slot: 11
	public virtual bool get_HasValue() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int get_Depth();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract string get_BaseURI();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsEmptyElement();

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 16
	public virtual bool get_IsDefault() { }

	// RVA: 0x1CC8170 Offset: 0x1CC6770 VA: 0x181CC8170 Slot: 17
	public virtual char get_QuoteChar() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 18
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x37A870 Offset: 0x378E70 VA: 0x18037A870 Slot: 19
	public virtual string get_XmlLang() { }

	// RVA: 0x1CC8180 Offset: 0x1CC6780 VA: 0x181CC8180 Slot: 20
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1CC81C0 Offset: 0x1CC67C0 VA: 0x181CC81C0 Slot: 21
	public virtual Type get_ValueType() { }

	// RVA: 0x1CC6700 Offset: 0x1CC4D00 VA: 0x181CC6700 Slot: 22
	public virtual string ReadContentAsString() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int get_AttributeCount();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string GetAttribute(string name);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string GetAttribute(string name, string namespaceURI);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string GetAttribute(int i);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool MoveToAttribute(string name);

	// RVA: 0x1CC6590 Offset: 0x1CC4B90 VA: 0x181CC6590 Slot: 28
	public virtual void MoveToAttribute(int i) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool MoveToFirstAttribute();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool MoveToNextAttribute();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool MoveToElement();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool ReadAttributeValue();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool Read();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract bool get_EOF();

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 35
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract ReadState get_ReadState();

	// RVA: 0x1CC7710 Offset: 0x1CC5D10 VA: 0x181CC7710 Slot: 37
	public virtual void Skip() { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract string LookupNamespace(string prefix);

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 40
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract void ResolveEntity();

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 42
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0x1CC74D0 Offset: 0x1CC5AD0 VA: 0x181CC74D0 Slot: 43
	public virtual int ReadValueChunk(char[] buffer, int index, int count) { }

	[EditorBrowsable(1)]
	// RVA: 0x1CC7290 Offset: 0x1CC5890 VA: 0x181CC7290 Slot: 44
	public virtual string ReadString() { }

	// RVA: 0x1CC6660 Offset: 0x1CC4C60 VA: 0x181CC6660 Slot: 45
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0x1CC6FF0 Offset: 0x1CC55F0 VA: 0x181CC6FF0 Slot: 46
	public virtual void ReadStartElement() { }

	// RVA: 0x1CC70F0 Offset: 0x1CC56F0 VA: 0x181CC70F0 Slot: 47
	public virtual void ReadStartElement(string name) { }

	[EditorBrowsable(1)]
	// RVA: 0x1CC6800 Offset: 0x1CC4E00 VA: 0x181CC6800 Slot: 48
	public virtual string ReadElementString() { }

	// RVA: 0x1CC6A90 Offset: 0x1CC5090 VA: 0x181CC6A90 Slot: 49
	public virtual void ReadEndElement() { }

	// RVA: 0x1CC6450 Offset: 0x1CC4A50 VA: 0x181CC6450 Slot: 50
	public virtual bool IsStartElement() { }

	// RVA: 0x1CC6480 Offset: 0x1CC4A80 VA: 0x181CC6480 Slot: 51
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1CC6B90 Offset: 0x1CC5190 VA: 0x181CC6B90 Slot: 52
	public virtual string ReadInnerXml() { }

	// RVA: 0x1CC7940 Offset: 0x1CC5F40 VA: 0x181CC7940
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0x1CC7820 Offset: 0x1CC5E20 VA: 0x181CC7820
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0x1CC5BA0 Offset: 0x1CC41A0 VA: 0x181CC5BA0
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0x1CC7530 Offset: 0x1CC5B30 VA: 0x181CC7530
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0x1CC7EF0 Offset: 0x1CC64F0 VA: 0x181CC7EF0 Slot: 53
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1CC6170 Offset: 0x1CC4770 VA: 0x181CC6170 Slot: 4
	public void Dispose() { }

	// RVA: 0x1CC6190 Offset: 0x1CC4790 VA: 0x181CC6190 Slot: 54
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 55
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1CC6520 Offset: 0x1CC4B20 VA: 0x181CC6520
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0x1CC53D0 Offset: 0x1CC39D0 VA: 0x181CC53D0
	internal static bool CanReadContentAs(XmlNodeType nodeType) { }

	// RVA: 0x1CC61D0 Offset: 0x1CC47D0 VA: 0x181CC61D0
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0x1CC7620 Offset: 0x1CC5C20 VA: 0x181CC7620
	private bool SkipSubtree() { }

	// RVA: 0x1CC54F0 Offset: 0x1CC3AF0 VA: 0x181CC54F0
	internal Exception CreateReadContentAsException(string methodName) { }

	// RVA: 0x1CC5440 Offset: 0x1CC3A40 VA: 0x181CC5440
	internal bool CanReadContentAs() { }

	// RVA: 0x1CC5590 Offset: 0x1CC3B90 VA: 0x181CC5590
	internal static Exception CreateReadContentAsException(string methodName, XmlNodeType nodeType, IXmlLineInfo lineInfo) { }

	// RVA: 0x1CC51B0 Offset: 0x1CC37B0 VA: 0x181CC51B0
	private static string AddLineInfo(string message, IXmlLineInfo lineInfo) { }

	// RVA: 0x1CC6240 Offset: 0x1CC4840 VA: 0x181CC6240
	internal string InternalReadContentAsString() { }

	// RVA: 0x1CC7FD0 Offset: 0x1CC65D0 VA: 0x181CC7FD0
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 56
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0x1CC5CC0 Offset: 0x1CC42C0 VA: 0x181CC5CC0
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1CC5FE0 Offset: 0x1CC45E0 VA: 0x181CC5FE0
	public static XmlReader Create(TextReader input) { }

	// RVA: 0x1CC5E80 Offset: 0x1CC4480 VA: 0x181CC5E80
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1CC5830 Offset: 0x1CC3E30 VA: 0x181CC5830
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0x1CC5330 Offset: 0x1CC3930 VA: 0x181CC5330
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1CC7E80 Offset: 0x1CC6480 VA: 0x181CC7E80
	private static void .cctor() { }
}

// Namespace: System.Xml
public sealed class XmlReaderSettings // TypeDefIndex: 6635
{
	// Fields
	private bool useAsync; // 0x10
	private XmlNameTable nameTable; // 0x18
	private XmlResolver xmlResolver; // 0x20
	private int lineNumberOffset; // 0x28
	private int linePositionOffset; // 0x2C
	private ConformanceLevel conformanceLevel; // 0x30
	private bool checkCharacters; // 0x34
	private long maxCharactersInDocument; // 0x38
	private long maxCharactersFromEntities; // 0x40
	private bool ignoreWhitespace; // 0x48
	private bool ignorePIs; // 0x49
	private bool ignoreComments; // 0x4A
	private DtdProcessing dtdProcessing; // 0x4C
	private ValidationType validationType; // 0x50
	private XmlSchemaValidationFlags validationFlags; // 0x54
	private XmlSchemaSet schemas; // 0x58
	private ValidationEventHandler valEventHandler; // 0x60
	private bool closeInput; // 0x68
	private bool isReadOnly; // 0x69
	[CompilerGenerated]
	private bool <IsXmlResolverSet>k__BackingField; // 0x6A
	private static Nullable<bool> s_enableLegacyXmlSettings; // 0x0

	// Properties
	public bool Async { get; set; }
	public XmlNameTable NameTable { get; set; }
	internal bool IsXmlResolverSet { get; set; }
	public XmlResolver XmlResolver { set; }
	public int LineNumberOffset { get; set; }
	public int LinePositionOffset { get; set; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; set; }
	public long MaxCharactersInDocument { get; set; }
	public long MaxCharactersFromEntities { get; set; }
	public bool IgnoreWhitespace { get; set; }
	public bool IgnoreProcessingInstructions { get; set; }
	public bool IgnoreComments { get; set; }
	public DtdProcessing DtdProcessing { get; set; }
	public bool CloseInput { get; set; }
	public ValidationType ValidationType { get; set; }
	public XmlSchemaValidationFlags ValidationFlags { get; set; }
	public XmlSchemaSet Schemas { get; set; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x1CC48F0 Offset: 0x1CC2EF0 VA: 0x181CC48F0
	public void .ctor() { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_Async() { }

	// RVA: 0x1CC4A40 Offset: 0x1CC3040 VA: 0x181CC4A40
	public void set_Async(bool value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1CC4F50 Offset: 0x1CC3550 VA: 0x181CC4F50
	public void set_NameTable(XmlNameTable value) { }

	[CompilerGenerated]
	// RVA: 0x1CC49C0 Offset: 0x1CC2FC0 VA: 0x181CC49C0
	internal bool get_IsXmlResolverSet() { }

	[CompilerGenerated]
	// RVA: 0x1CC4D60 Offset: 0x1CC3360 VA: 0x181CC4D60
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x1CC5150 Offset: 0x1CC3750 VA: 0x181CC5150
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0x1CC4730 Offset: 0x1CC2D30 VA: 0x181CC4730
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_LineNumberOffset() { }

	// RVA: 0x1CC4D70 Offset: 0x1CC3370 VA: 0x181CC4D70
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public int get_LinePositionOffset() { }

	// RVA: 0x1CC4DC0 Offset: 0x1CC33C0 VA: 0x181CC4DC0
	public void set_LinePositionOffset(int value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x1CC4B30 Offset: 0x1CC3130 VA: 0x181CC4B30
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_CheckCharacters() { }

	// RVA: 0x1CC4A90 Offset: 0x1CC3090 VA: 0x181CC4A90
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public long get_MaxCharactersInDocument() { }

	// RVA: 0x1CC4EB0 Offset: 0x1CC34B0 VA: 0x181CC4EB0
	public void set_MaxCharactersInDocument(long value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public long get_MaxCharactersFromEntities() { }

	// RVA: 0x1CC4E10 Offset: 0x1CC3410 VA: 0x181CC4E10
	public void set_MaxCharactersFromEntities(long value) { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	public bool get_IgnoreWhitespace() { }

	// RVA: 0x1CC4D10 Offset: 0x1CC3310 VA: 0x181CC4D10
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x16EE300 Offset: 0x16EC900 VA: 0x1816EE300
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x1CC4CC0 Offset: 0x1CC32C0 VA: 0x181CC4CC0
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x16EE320 Offset: 0x16EC920 VA: 0x1816EE320
	public bool get_IgnoreComments() { }

	// RVA: 0x1CC4C70 Offset: 0x1CC3270 VA: 0x181CC4C70
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0x1CC4BD0 Offset: 0x1CC31D0 VA: 0x181CC4BD0
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	public bool get_CloseInput() { }

	// RVA: 0x1CC4AE0 Offset: 0x1CC30E0 VA: 0x181CC4AE0
	public void set_CloseInput(bool value) { }

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public ValidationType get_ValidationType() { }

	// RVA: 0x1CC50B0 Offset: 0x1CC36B0 VA: 0x181CC50B0
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x464C80 Offset: 0x463280 VA: 0x180464C80
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1CC5010 Offset: 0x1CC3610 VA: 0x181CC5010
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x1CC49D0 Offset: 0x1CC2FD0 VA: 0x181CC49D0
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0x1CC4FB0 Offset: 0x1CC35B0 VA: 0x181CC4FB0
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x1CC4260 Offset: 0x1CC2860 VA: 0x181CC4260
	public XmlReaderSettings Clone() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1CC44C0 Offset: 0x1CC2AC0 VA: 0x181CC44C0
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1CC43A0 Offset: 0x1CC29A0 VA: 0x181CC43A0
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x534E80 Offset: 0x533480 VA: 0x180534E80
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x1CC41B0 Offset: 0x1CC27B0 VA: 0x181CC41B0
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x1CC4830 Offset: 0x1CC2E30 VA: 0x181CC4830
	private void Initialize() { }

	// RVA: 0x1CC4760 Offset: 0x1CC2D60 VA: 0x181CC4760
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0x1CC42C0 Offset: 0x1CC28C0 VA: 0x181CC42C0
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x1CC3FC0 Offset: 0x1CC25C0 VA: 0x181CC3FC0
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x1CC4310 Offset: 0x1CC2910 VA: 0x181CC4310
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x1CC4660 Offset: 0x1CC2C60 VA: 0x181CC4660
	internal static bool EnableLegacyXmlSettings() { }
}

// Namespace: System.Xml
public enum XmlSpace // TypeDefIndex: 6636
{
	// Fields
	public int value__; // 0x0
	public const XmlSpace None = 0;
	public const XmlSpace Default = 1;
	public const XmlSpace Preserve = 2;
}

// Namespace: System.Xml
internal class XmlTextEncoder // TypeDefIndex: 6637
{
	// Fields
	private TextWriter textWriter; // 0x10
	private bool inAttribute; // 0x18
	private char quoteChar; // 0x1A
	private StringBuilder attrValue; // 0x20
	private bool cacheAttrValue; // 0x28
	private XmlCharType xmlCharType; // 0x30

	// Properties
	internal char QuoteChar { set; }
	internal string AttributeValue { get; }

	// Methods

	// RVA: 0x1CC9820 Offset: 0x1CC7E20 VA: 0x181CC9820
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0x197E810 Offset: 0x197CE10 VA: 0x18197E810
	internal void set_QuoteChar(char value) { }

	// RVA: 0x1CC8240 Offset: 0x1CC6840 VA: 0x181CC8240
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0x1CC8200 Offset: 0x1CC6800 VA: 0x181CC8200
	internal void EndAttribute() { }

	// RVA: 0x1CC9870 Offset: 0x1CC7E70 VA: 0x181CC9870
	internal string get_AttributeValue() { }

	// RVA: 0x1CC8C20 Offset: 0x1CC7220 VA: 0x181CC8C20
	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	// RVA: 0x1CC92B0 Offset: 0x1CC78B0 VA: 0x181CC92B0
	internal void Write(char[] array, int offset, int count) { }

	// RVA: 0x1CC8AA0 Offset: 0x1CC70A0 VA: 0x181CC8AA0
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CC8CE0 Offset: 0x1CC72E0 VA: 0x181CC8CE0
	internal void Write(string text) { }

	// RVA: 0x1CC8620 Offset: 0x1CC6C20 VA: 0x181CC8620
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0x1CC8830 Offset: 0x1CC6E30 VA: 0x181CC8830
	internal void WriteRaw(char[] array, int offset, int count) { }

	// RVA: 0x1CC83E0 Offset: 0x1CC69E0 VA: 0x181CC83E0
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x1CC85A0 Offset: 0x1CC6BA0 VA: 0x181CC85A0
	internal void WriteEntityRef(string name) { }

	// RVA: 0x1CC89F0 Offset: 0x1CC6FF0 VA: 0x181CC89F0
	private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer) { }

	// RVA: 0x1CC82D0 Offset: 0x1CC68D0 VA: 0x181CC82D0
	private void WriteCharEntityImpl(char ch) { }

	// RVA: 0x1CC8340 Offset: 0x1CC6940 VA: 0x181CC8340
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0x1CC8520 Offset: 0x1CC6B20 VA: 0x181CC8520
	private void WriteEntityRefImpl(string name) { }
}

// Namespace: System.Xml
[EditorBrowsable(1)]
public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 6638
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override bool HasValue { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public bool Namespaces { get; }
	public bool Normalization { get; set; }
	public WhitespaceHandling WhitespaceHandling { set; }
	public EntityHandling EntityHandling { set; }
	public XmlResolver XmlResolver { set; }
	internal XmlTextReaderImpl Impl { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1CC9970 Offset: 0x1CC7F70 VA: 0x181CC9970
	public void .ctor(Stream input) { }

	// RVA: 0x1CC9BC0 Offset: 0x1CC81C0 VA: 0x181CC9BC0
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1CC9B00 Offset: 0x1CC8100 VA: 0x181CC9B00
	public void .ctor(TextReader input) { }

	// RVA: 0x1CC9A30 Offset: 0x1CC8030 VA: 0x181CC9A30
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x1B31740 Offset: 0x1B2FD40 VA: 0x181B31740 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1699E80 Offset: 0x1698480 VA: 0x181699E80 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1B316E0 Offset: 0x1B2FCE0 VA: 0x181B316E0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x140B6A0 Offset: 0x1409CA0 VA: 0x18140B6A0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x140B790 Offset: 0x1409D90 VA: 0x18140B790 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x140B760 Offset: 0x1409D60 VA: 0x18140B760 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x1B31770 Offset: 0x1B2FD70 VA: 0x181B31770 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1B31680 Offset: 0x1B2FC80 VA: 0x181B31680 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1B31620 Offset: 0x1B2FC20 VA: 0x181B31620 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x140B730 Offset: 0x1409D30 VA: 0x18140B730 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x140B670 Offset: 0x1409C70 VA: 0x18140B670 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x140B700 Offset: 0x1409D00 VA: 0x18140B700 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1B317D0 Offset: 0x1B2FDD0 VA: 0x181B317D0 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1B317A0 Offset: 0x1B2FDA0 VA: 0x181B317A0 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x14A4A00 Offset: 0x14A3000 VA: 0x1814A4A00 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1B31400 Offset: 0x1B2FA00 VA: 0x181B31400 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1B313D0 Offset: 0x1B2F9D0 VA: 0x181B313D0 Slot: 25
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x86F3B0 Offset: 0x86D9B0 VA: 0x18086F3B0 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1B31460 Offset: 0x1B2FA60 VA: 0x181B31460 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1B31490 Offset: 0x1B2FA90 VA: 0x181B31490 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x13703A0 Offset: 0x136E9A0 VA: 0x1813703A0 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1699D40 Offset: 0x1698340 VA: 0x181699D40 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1B314C0 Offset: 0x1B2FAC0 VA: 0x181B314C0 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1B314F0 Offset: 0x1B2FAF0 VA: 0x181B314F0 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1699DA0 Offset: 0x16983A0 VA: 0x181699DA0 Slot: 33
	public override bool Read() { }

	// RVA: 0x1B316B0 Offset: 0x1B2FCB0 VA: 0x181B316B0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x1B31300 Offset: 0x1B2F900 VA: 0x181B31300 Slot: 35
	public override void Close() { }

	// RVA: 0x1699D70 Offset: 0x1698370 VA: 0x181699D70 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1B31580 Offset: 0x1B2FB80 VA: 0x181B31580 Slot: 37
	public override void Skip() { }

	// RVA: 0x1B31710 Offset: 0x1B2FD10 VA: 0x181B31710 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1CC98C0 Offset: 0x1CC7EC0 VA: 0x181CC98C0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1B31550 Offset: 0x1B2FB50 VA: 0x181B31550 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 42
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1CC9900 Offset: 0x1CC7F00 VA: 0x181CC9900 Slot: 44
	public override string ReadString() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 57
	public bool HasLineInfo() { }

	// RVA: 0x1CC9CE0 Offset: 0x1CC82E0 VA: 0x181CC9CE0 Slot: 58
	public int get_LineNumber() { }

	// RVA: 0x1CC9D00 Offset: 0x1CC8300 VA: 0x181CC9D00 Slot: 59
	public int get_LinePosition() { }

	// RVA: 0x1CC9930 Offset: 0x1CC7F30 VA: 0x181CC9930 Slot: 60
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1B31430 Offset: 0x1B2FA30 VA: 0x181B31430 Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1CC9950 Offset: 0x1CC7F50 VA: 0x181CC9950 Slot: 62
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1CB6700 Offset: 0x1CB4D00 VA: 0x181CB6700
	public bool get_Namespaces() { }

	// RVA: 0x1CB6720 Offset: 0x1CB4D20 VA: 0x181CB6720
	public bool get_Normalization() { }

	// RVA: 0x1CC9D70 Offset: 0x1CC8370 VA: 0x181CC9D70
	public void set_Normalization(bool value) { }

	// RVA: 0x1CC9D90 Offset: 0x1CC8390 VA: 0x181CC9D90
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1CC9D50 Offset: 0x1CC8350 VA: 0x181CC9D50
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1CC9DB0 Offset: 0x1CC83B0 VA: 0x181CC9DB0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0x1CC9D20 Offset: 0x1CC8320 VA: 0x181CC9D20 Slot: 55
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1CC9DD0 Offset: 0x1CC83D0 VA: 0x181CC9DD0
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x1CC9CB0 Offset: 0x1CC82B0 VA: 0x181CC9CB0 Slot: 56
	internal override IDtdInfo get_DtdInfo() { }
}

// Namespace: System.Xml
internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 6653
{
	// Fields
	private readonly bool useAsync; // 0x10
	private XmlTextReaderImpl.LaterInitParam laterInitParam; // 0x18
	private XmlCharType xmlCharType; // 0x20
	private XmlTextReaderImpl.ParsingState ps; // 0x28
	private XmlTextReaderImpl.ParsingFunction parsingFunction; // 0xA0
	private XmlTextReaderImpl.ParsingFunction nextParsingFunction; // 0xA4
	private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction; // 0xA8
	private XmlTextReaderImpl.NodeData[] nodes; // 0xB0
	private XmlTextReaderImpl.NodeData curNode; // 0xB8
	private int index; // 0xC0
	private int curAttrIndex; // 0xC4
	private int attrCount; // 0xC8
	private int attrHashtable; // 0xCC
	private int attrDuplWalkCount; // 0xD0
	private bool attrNeedNamespaceLookup; // 0xD4
	private bool fullAttrCleanup; // 0xD5
	private XmlTextReaderImpl.NodeData[] attrDuplSortingArray; // 0xD8
	private XmlNameTable nameTable; // 0xE0
	private bool nameTableFromSettings; // 0xE8
	private XmlResolver xmlResolver; // 0xF0
	private string url; // 0xF8
	private bool normalize; // 0x100
	private bool supportNamespaces; // 0x101
	private WhitespaceHandling whitespaceHandling; // 0x104
	private DtdProcessing dtdProcessing; // 0x108
	private EntityHandling entityHandling; // 0x10C
	private bool ignorePIs; // 0x110
	private bool ignoreComments; // 0x111
	private bool checkCharacters; // 0x112
	private int lineNumberOffset; // 0x114
	private int linePositionOffset; // 0x118
	private bool closeInput; // 0x11C
	private long maxCharactersInDocument; // 0x120
	private long maxCharactersFromEntities; // 0x128
	private bool v1Compat; // 0x130
	private XmlNamespaceManager namespaceManager; // 0x138
	private string lastPrefix; // 0x140
	private XmlTextReaderImpl.XmlContext xmlContext; // 0x148
	private XmlTextReaderImpl.ParsingState[] parsingStatesStack; // 0x150
	private int parsingStatesStackTop; // 0x158
	private string reportedBaseUri; // 0x160
	private Encoding reportedEncoding; // 0x168
	private IDtdInfo dtdInfo; // 0x170
	private XmlNodeType fragmentType; // 0x178
	private XmlParserContext fragmentParserContext; // 0x180
	private bool fragment; // 0x188
	private IncrementalReadDecoder incReadDecoder; // 0x190
	private XmlTextReaderImpl.IncrementalReadState incReadState; // 0x198
	private LineInfo incReadLineInfo; // 0x19C
	private int incReadDepth; // 0x1A4
	private int incReadLeftStartPos; // 0x1A8
	private int incReadLeftEndPos; // 0x1AC
	private int attributeValueBaseEntityId; // 0x1B0
	private bool emptyEntityInAttributeResolved; // 0x1B4
	private IValidationEventHandling validationEventHandling; // 0x1B8
	private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1C0
	private bool validatingReaderCompatFlag; // 0x1C8
	private bool addDefaultAttributesAndNormalize; // 0x1C9
	private StringBuilder stringBuilder; // 0x1D0
	private bool rootElementParsed; // 0x1D8
	private bool standalone; // 0x1D9
	private int nextEntityId; // 0x1DC
	private XmlTextReaderImpl.ParsingMode parsingMode; // 0x1E0
	private ReadState readState; // 0x1E4
	private IDtdEntityInfo lastEntity; // 0x1E8
	private bool afterResetState; // 0x1F0
	private int documentStartBytePos; // 0x1F4
	private int readValueOffset; // 0x1F8
	private long charactersInDocument; // 0x200
	private long charactersFromEntities; // 0x208
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; // 0x210
	private bool disableUndeclaredEntityCheck; // 0x218
	private XmlReader outerReader; // 0x220
	private bool xmlResolverIsSet; // 0x228
	private string Xml; // 0x230
	private string XmlNs; // 0x238
	private Task<Tuple<int, int, int, bool>> parseText_dummyTask; // 0x240

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override int AttributeCount { get; }
	internal XmlReader OuterReader { set; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal bool Namespaces { get; set; }
	internal bool Normalization { get; set; }
	internal WhitespaceHandling WhitespaceHandling { set; }
	internal EntityHandling EntityHandling { set; }
	internal bool IsResolverSet { get; }
	internal XmlResolver XmlResolver { set; }
	internal XmlNameTable DtdParserProxy_NameTable { get; }
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver { get; }
	internal bool DtdParserProxy_DtdValidation { get; }
	internal bool DtdParserProxy_Normalization { get; }
	internal bool DtdParserProxy_Namespaces { get; }
	internal bool DtdParserProxy_V1CompatibilityMode { get; }
	internal Uri DtdParserProxy_BaseUri { get; }
	internal bool DtdParserProxy_IsEof { get; }
	internal char[] DtdParserProxy_ParsingBuffer { get; }
	internal int DtdParserProxy_ParsingBufferLength { get; }
	internal int DtdParserProxy_CurrentPosition { get; set; }
	internal int DtdParserProxy_EntityStackLength { get; }
	internal bool DtdParserProxy_IsEntityEolNormalized { get; }
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling { get; }
	internal int DtdParserProxy_LineNo { get; }
	internal int DtdParserProxy_LineStartPosition { get; }
	private bool IsResolverNull { get; }
	private bool InAttributeValueIterator { get; }
	private bool DtdValidation { get; }
	private bool InEntity { get; }
	internal override IDtdInfo DtdInfo { get; }
	internal IValidationEventHandling ValidationEventHandling { set; }
	internal XmlTextReaderImpl.OnDefaultAttributeUseDelegate OnDefaultAttributeUse { set; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal XmlNodeType FragmentType { get; }
	internal object InternalSchemaType { set; }
	internal object InternalTypedValue { get; set; }
	internal bool StandAlone { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool V1Compat { get; }
	internal bool DisableUndeclaredEntityCheck { set; }

	// Methods

	// RVA: 0x1BE6810 Offset: 0x1BE4E10 VA: 0x181BE6810
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0x1BE6DE0 Offset: 0x1BE53E0 VA: 0x181BE6DE0
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x1BE6580 Offset: 0x1BE4B80 VA: 0x181BE6580
	internal void .ctor(Stream input) { }

	// RVA: 0x1BE7440 Offset: 0x1BE5A40 VA: 0x181BE7440
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1BE73B0 Offset: 0x1BE59B0 VA: 0x181BE73B0
	internal void .ctor(TextReader input) { }

	// RVA: 0x1BE66D0 Offset: 0x1BE4CD0 VA: 0x181BE66D0
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x1BE6710 Offset: 0x1BE4D10 VA: 0x181BE6710
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x1BE6300 Offset: 0x1BE4900 VA: 0x181BE6300
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x1BE6CA0 Offset: 0x1BE52A0 VA: 0x181BE6CA0
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x1BD5DE0 Offset: 0x1BD43E0 VA: 0x181BD5DE0
	private void FinishInitUriString() { }

	// RVA: 0x1BE75F0 Offset: 0x1BE5BF0 VA: 0x181BE75F0
	internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x1BD5C60 Offset: 0x1BD4260 VA: 0x181BD5C60
	private void FinishInitStream() { }

	// RVA: 0x1BE6430 Offset: 0x1BE4A30 VA: 0x181BE6430
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x1BD5D40 Offset: 0x1BD4340 VA: 0x181BD5D40
	private void FinishInitTextReader() { }

	// RVA: 0x1BE7550 Offset: 0x1BE5B50 VA: 0x181BE7550
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1BE7CB0 Offset: 0x1BE62B0 VA: 0x181BE7CB0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1BE7C30 Offset: 0x1BE6230 VA: 0x181BE7C30 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1BE7BE0 Offset: 0x1BE61E0 VA: 0x181BE7BE0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1BE7BC0 Offset: 0x1BE61C0 VA: 0x181BE7BC0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1BE7C10 Offset: 0x1BE6210 VA: 0x181BE7C10 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1BE7C50 Offset: 0x1BE6250 VA: 0x181BE7C50 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1BE7E50 Offset: 0x1BE6450 VA: 0x181BE7E50 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1BE7900 Offset: 0x1BE5F00 VA: 0x181BE7900 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1BE78F0 Offset: 0x1BE5EF0 VA: 0x181BE78F0 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x1BE7AE0 Offset: 0x1BE60E0 VA: 0x181BE7AE0 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1BE7AB0 Offset: 0x1BE60B0 VA: 0x181BE7AB0 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x1BE7C70 Offset: 0x1BE6270 VA: 0x181BE7C70 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1BE7FC0 Offset: 0x1BE65C0 VA: 0x181BE7FC0 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1BE7FA0 Offset: 0x1BE65A0 VA: 0x181BE7FA0 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x1BE7CA0 Offset: 0x1BE62A0 VA: 0x181BE7CA0 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1BE7A40 Offset: 0x1BE6040 VA: 0x181BE7A40 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x145DAB0 Offset: 0x145C0B0 VA: 0x18145DAB0 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1BD67D0 Offset: 0x1BD4DD0 VA: 0x181BD67D0 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1BD6860 Offset: 0x1BD4E60 VA: 0x181BD6860 Slot: 25
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1BD6720 Offset: 0x1BD4D20 VA: 0x181BD6720 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1BD8DE0 Offset: 0x1BD73E0 VA: 0x181BD8DE0 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1BD8EB0 Offset: 0x1BD74B0 VA: 0x181BD8EB0 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1BD9020 Offset: 0x1BD7620 VA: 0x181BD9020 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1BD90A0 Offset: 0x1BD76A0 VA: 0x181BD90A0 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1BD8F90 Offset: 0x1BD7590 VA: 0x181BD8F90 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1BD6170 Offset: 0x1BD4770 VA: 0x181BD6170
	private void FinishInit() { }

	// RVA: 0x1BE2C60 Offset: 0x1BE1260 VA: 0x181BE2C60 Slot: 33
	public override bool Read() { }

	// RVA: 0x1BD4A40 Offset: 0x1BD3040 VA: 0x181BD4A40 Slot: 35
	public override void Close() { }

	// RVA: 0x1BE4C90 Offset: 0x1BE3290 VA: 0x181BE4C90 Slot: 37
	public override void Skip() { }

	// RVA: 0x1BD8BC0 Offset: 0x1BD71C0 VA: 0x181BD8BC0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1BE1E10 Offset: 0x1BE0410 VA: 0x181BE1E10 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1BE3790 Offset: 0x1BE1D90 VA: 0x181BE3790 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1BE8420 Offset: 0x1BE6A20 VA: 0x181BE8420
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0x1BD8D10 Offset: 0x1BD7310 VA: 0x181BD8D10
	internal void MoveOffEntityReference() { }

	// RVA: 0x1BE2650 Offset: 0x1BE0C50 VA: 0x181BE2650 Slot: 44
	public override string ReadString() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 42
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1BE2720 Offset: 0x1BE0D20 VA: 0x181BE2720 Slot: 43
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 57
	public bool HasLineInfo() { }

	// RVA: 0x1BE7B60 Offset: 0x1BE6160 VA: 0x181BE7B60 Slot: 58
	public int get_LineNumber() { }

	// RVA: 0x1BE7B90 Offset: 0x1BE6190 VA: 0x181BE7B90 Slot: 59
	public int get_LinePosition() { }

	// RVA: 0x1BD6CC0 Offset: 0x1BD52C0 VA: 0x181BD6CC0 Slot: 60
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1BE5360 Offset: 0x1BE3960 VA: 0x181BE5360 Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1BD8CE0 Offset: 0x1BD72E0 VA: 0x181BD8CE0 Slot: 62
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1BD6CC0 Offset: 0x1BD52C0 VA: 0x181BD6CC0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1BD8CE0 Offset: 0x1BD72E0 VA: 0x181BD8CE0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1BE7A20 Offset: 0x1BE6020 VA: 0x181BE7A20
	internal bool get_Namespaces() { }

	// RVA: 0x1BE80E0 Offset: 0x1BE66E0 VA: 0x181BE80E0
	internal void set_Namespaces(bool value) { }

	// RVA: 0x16212D0 Offset: 0x161F8D0 VA: 0x1816212D0
	internal bool get_Normalization() { }

	// RVA: 0x1BE8330 Offset: 0x1BE6930 VA: 0x181BE8330
	internal void set_Normalization(bool value) { }

	// RVA: 0x1BE8460 Offset: 0x1BE6A60 VA: 0x181BE8460
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1BE7FF0 Offset: 0x1BE65F0 VA: 0x181BE7FF0
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1BE7B50 Offset: 0x1BE6150 VA: 0x181BE7B50
	internal bool get_IsResolverSet() { }

	// RVA: 0x1BE8540 Offset: 0x1BE6B40 VA: 0x181BE8540
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x1791C80 Offset: 0x1790280 VA: 0x181791C80
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x1BE79F0 Offset: 0x1BE5FF0 VA: 0x181BE79F0
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x16212D0 Offset: 0x161F8D0 VA: 0x1816212D0
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0x1BE7A20 Offset: 0x1BE6020 VA: 0x181BE7A20
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0x17A4D50 Offset: 0x17A3350 VA: 0x1817A4D50
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x1BE7920 Offset: 0x1BE5F20 VA: 0x181BE7920
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x3A35C0 Offset: 0x3A1BC0 VA: 0x1803A35C0
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x1BE7A00 Offset: 0x1BE6000 VA: 0x181BE7A00
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x1BE7A10 Offset: 0x1BE6010 VA: 0x181BE7A10
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x1BE7A30 Offset: 0x1BE6030 VA: 0x181BE7A30
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x1BD4D50 Offset: 0x1BD3350 VA: 0x181BD4D50
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0x19774D0 Offset: 0x1975AD0 VA: 0x1819774D0
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x1BD5760 Offset: 0x1BD3D60 VA: 0x181BD5760
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0x1BD52F0 Offset: 0x1BD38F0 VA: 0x181BD52F0
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1BD52E0 Offset: 0x1BD38E0 VA: 0x181BD52E0
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1BD53A0 Offset: 0x1BD39A0 VA: 0x181BD53A0
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x1BD4F20 Offset: 0x1BD3520 VA: 0x181BD4F20
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x1BE7B10 Offset: 0x1BE6110 VA: 0x181BE7B10
	private bool get_IsResolverNull() { }

	// RVA: 0x1BD6D30 Offset: 0x1BD5330 VA: 0x181BD6D30
	private XmlResolver GetTempResolver() { }

	// RVA: 0x1BD5470 Offset: 0x1BD3A70 VA: 0x181BD5470
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x1BD53F0 Offset: 0x1BD39F0 VA: 0x181BD53F0
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x1BD5540 Offset: 0x1BD3B40 VA: 0x181BD5540
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1BD56C0 Offset: 0x1BD3CC0 VA: 0x181BD56C0
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1BD5770 Offset: 0x1BD3D70 VA: 0x181BD5770
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x1BD4E40 Offset: 0x1BD3440 VA: 0x181BD4E40
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1BD4D60 Offset: 0x1BD3360 VA: 0x181BD4D60
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x1BE5EE0 Offset: 0x1BE44E0 VA: 0x181BE5EE0
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0x1BE5FC0 Offset: 0x1BE45C0 VA: 0x181BE5FC0
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0x1BE5D40 Offset: 0x1BE4340 VA: 0x181BE5D40
	private void Throw(int pos, string res) { }

	// RVA: 0x1BE5F00 Offset: 0x1BE4500 VA: 0x181BE5F00
	private void Throw(string res) { }

	// RVA: 0x1BE5CA0 Offset: 0x1BE42A0 VA: 0x181BE5CA0
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x1BE5D80 Offset: 0x1BE4380 VA: 0x181BE5D80
	private void Throw(string res, string arg) { }

	// RVA: 0x1BE5F30 Offset: 0x1BE4530 VA: 0x181BE5F30
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1BE5BF0 Offset: 0x1BE41F0 VA: 0x181BE5BF0
	private void Throw(string res, string[] args) { }

	// RVA: 0x1BE5B60 Offset: 0x1BE4160 VA: 0x181BE5B60
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x1BE5FE0 Offset: 0x1BE45E0 VA: 0x181BE5FE0
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x1BE5E30 Offset: 0x1BE4430 VA: 0x181BE5E30
	private void Throw(Exception e) { }

	// RVA: 0x1BE1D70 Offset: 0x1BE0370 VA: 0x181BE1D70
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x1BE5AD0 Offset: 0x1BE40D0 VA: 0x181BE5AD0
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x1BE59C0 Offset: 0x1BE3FC0 VA: 0x181BE59C0
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x1BE5A40 Offset: 0x1BE4040 VA: 0x181BE5A40
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x1BE5400 Offset: 0x1BE3A00 VA: 0x181BE5400
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x1BE3D10 Offset: 0x1BE2310 VA: 0x181BE3D10
	private void SetErrorState() { }

	// RVA: 0x1BE3B10 Offset: 0x1BE2110 VA: 0x181BE3B10
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x1BE3A40 Offset: 0x1BE2040 VA: 0x181BE3A40
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x1BE7A50 Offset: 0x1BE6050 VA: 0x181BE7A50
	private bool get_InAttributeValueIterator() { }

	// RVA: 0x1BD5A50 Offset: 0x1BD4050 VA: 0x181BD5A50
	private void FinishAttributeValueIterator() { }

	// RVA: 0x1BE79F0 Offset: 0x1BE5FF0 VA: 0x181BE79F0
	private bool get_DtdValidation() { }

	// RVA: 0x1BD8710 Offset: 0x1BD6D10 VA: 0x181BD8710
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x1BD87D0 Offset: 0x1BD6DD0 VA: 0x181BD87D0
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1BD8750 Offset: 0x1BD6D50 VA: 0x181BD8750
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x1BD8800 Offset: 0x1BD6E00 VA: 0x181BD8800
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1BD8460 Offset: 0x1BD6A60 VA: 0x181BD8460
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x1BD8950 Offset: 0x1BD6F50 VA: 0x181BD8950
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x1BD8970 Offset: 0x1BD6F70 VA: 0x181BD8970
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x1BD8830 Offset: 0x1BD6E30 VA: 0x181BD8830
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x1BD81A0 Offset: 0x1BD67A0 VA: 0x181BD81A0
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x1BE1440 Offset: 0x1BDFA40 VA: 0x181BE1440
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x1BD9BB0 Offset: 0x1BD81B0 VA: 0x181BD9BB0
	private void OpenUrl() { }

	// RVA: 0x1BD9A20 Offset: 0x1BD8020 VA: 0x181BD9A20
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x1BD4B50 Offset: 0x1BD3150 VA: 0x181BD4B50
	private Encoding DetectEncoding() { }

	// RVA: 0x1BE3D30 Offset: 0x1BE2330 VA: 0x181BE3D30
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0x1BE51C0 Offset: 0x1BE37C0 VA: 0x181BE51C0
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x1BD45F0 Offset: 0x1BD2BF0 VA: 0x181BD45F0
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x1BE6090 Offset: 0x1BE4690 VA: 0x181BE6090
	private void UnDecodeChars() { }

	// RVA: 0x1BE5150 Offset: 0x1BE3750 VA: 0x181BE5150
	private void SwitchEncodingToUTF8() { }

	// RVA: 0x1BE21C0 Offset: 0x1BE07C0 VA: 0x181BE21C0
	private int ReadData() { }

	// RVA: 0x1BD69E0 Offset: 0x1BD4FE0 VA: 0x181BD69E0
	private int GetChars(int maxCharsCount) { }

	// RVA: 0x1BD8A70 Offset: 0x1BD7070 VA: 0x181BD8A70
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0x1BD4940 Offset: 0x1BD2F40 VA: 0x181BD4940
	internal void Close(bool closeInput) { }

	// RVA: 0x1BE4350 Offset: 0x1BE2950 VA: 0x181BE4350
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x1BE00E0 Offset: 0x1BDE6E0 VA: 0x181BE00E0
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x1BDC1F0 Offset: 0x1BDA7F0 VA: 0x181BDC1F0
	private bool ParseDocumentContent() { }

	// RVA: 0x1BDCBF0 Offset: 0x1BDB1F0 VA: 0x181BDCBF0
	private bool ParseElementContent() { }

	// RVA: 0x1BE5640 Offset: 0x1BE3C40 VA: 0x181BE5640
	private void ThrowUnclosedElements() { }

	// RVA: 0x1BDCF80 Offset: 0x1BDB580 VA: 0x181BDCF80
	private void ParseElement() { }

	// RVA: 0x1BD3520 Offset: 0x1BD1B20 VA: 0x181BD3520
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x1BDD4D0 Offset: 0x1BDBAD0 VA: 0x181BDD4D0
	private void ParseEndElement() { }

	// RVA: 0x1BE5470 Offset: 0x1BE3A70 VA: 0x181BE5470
	private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

	// RVA: 0x1BDB090 Offset: 0x1BD9690 VA: 0x181BDB090
	private void ParseAttributes() { }

	// RVA: 0x1BD59C0 Offset: 0x1BD3FC0 VA: 0x181BD59C0
	private void ElementNamespaceLookup() { }

	// RVA: 0x1BD4500 Offset: 0x1BD2B00 VA: 0x181BD4500
	private void AttributeNamespaceLookup() { }

	// RVA: 0x1BD40E0 Offset: 0x1BD26E0 VA: 0x181BD40E0
	private void AttributeDuplCheck() { }

	// RVA: 0x1BD9250 Offset: 0x1BD7850 VA: 0x181BD9250
	private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1BD9450 Offset: 0x1BD7A50 VA: 0x181BD9450
	private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1BD9540 Offset: 0x1BD7B40 VA: 0x181BD9540
	private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1BDA5E0 Offset: 0x1BD8BE0 VA: 0x181BDA5E0
	private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1BD25E0 Offset: 0x1BD0BE0 VA: 0x181BD25E0
	private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

	// RVA: 0x1BDF3C0 Offset: 0x1BDD9C0 VA: 0x181BDF3C0
	private bool ParseText() { }

	// RVA: 0x1BDF850 Offset: 0x1BDDE50 VA: 0x181BDF850
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0x1BD62F0 Offset: 0x1BD48F0 VA: 0x181BD62F0
	private void FinishPartialValue() { }

	// RVA: 0x1BD61C0 Offset: 0x1BD47C0 VA: 0x181BD61C0
	private void FinishOtherValueIterator() { }

	// RVA: 0x1BE4710 Offset: 0x1BE2D10 VA: 0x181BE4710
	private void SkipPartialTextValue() { }

	// RVA: 0x1BD6640 Offset: 0x1BD4C40 VA: 0x181BD6640
	private void FinishReadValueChunk() { }

	// RVA: 0x1BD6430 Offset: 0x1BD4A30 VA: 0x181BD6430
	private void FinishReadContentAsBinary() { }

	// RVA: 0x1BD6580 Offset: 0x1BD4B80 VA: 0x181BD6580
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0x1BDF130 Offset: 0x1BDD730 VA: 0x181BDF130
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0x1BDD9A0 Offset: 0x1BDBFA0 VA: 0x181BDD9A0
	private void ParseEntityReference() { }

	// RVA: 0x1BD6FE0 Offset: 0x1BD55E0 VA: 0x181BD6FE0
	private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0x1BD7270 Offset: 0x1BD5870 VA: 0x181BD7270
	private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x1BE7A70 Offset: 0x1BE6070 VA: 0x181BE7A70
	private bool get_InEntity() { }

	// RVA: 0x1BD6E40 Offset: 0x1BD5440 VA: 0x181BD6E40
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x1BE3F50 Offset: 0x1BE2550 VA: 0x181BE3F50
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0x1BE3EC0 Offset: 0x1BE24C0 VA: 0x181BE3EC0
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x1BDEE60 Offset: 0x1BDD460 VA: 0x181BDEE60
	private bool ParsePI() { }

	// RVA: 0x1BDEA60 Offset: 0x1BDD060 VA: 0x181BDEA60
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x1BDE700 Offset: 0x1BDCD00 VA: 0x181BDE700
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0x1BDBCF0 Offset: 0x1BDA2F0 VA: 0x181BDBCF0
	private bool ParseComment() { }

	// RVA: 0x1BDBC60 Offset: 0x1BDA260 VA: 0x181BDBC60
	private void ParseCData() { }

	// RVA: 0x1BDBAA0 Offset: 0x1BDA0A0 VA: 0x181BDBAA0
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x1BDB680 Offset: 0x1BD9C80 VA: 0x181BDB680
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0x1BDBF20 Offset: 0x1BDA520 VA: 0x181BDBF20
	private bool ParseDoctypeDecl() { }

	// RVA: 0x1BDC940 Offset: 0x1BDAF40 VA: 0x181BDC940
	private void ParseDtd() { }

	// RVA: 0x1BE4380 Offset: 0x1BE2980 VA: 0x181BE4380
	private void SkipDtd() { }

	// RVA: 0x1BE4770 Offset: 0x1BE2D70 VA: 0x181BE4770
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x1BE4800 Offset: 0x1BE2E00 VA: 0x181BE4800
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	// RVA: 0x1BD5780 Offset: 0x1BD3D80 VA: 0x181BD5780
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x1BDBC70 Offset: 0x1BDA270 VA: 0x181BDBC70
	private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1BDE630 Offset: 0x1BDCC30 VA: 0x181BDE630
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1BDDE80 Offset: 0x1BDC480 VA: 0x181BDDE80
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1BDDE00 Offset: 0x1BDC400 VA: 0x181BDDE00
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1BDDAF0 Offset: 0x1BDC0F0 VA: 0x181BDDAF0
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1BDDAC0 Offset: 0x1BDC0C0 VA: 0x181BDDAC0
	private int ParseName() { }

	// RVA: 0x1BDF110 Offset: 0x1BDD710 VA: 0x181BDF110
	private int ParseQName(out int colonPos) { }

	// RVA: 0x1BDEE70 Offset: 0x1BDD470 VA: 0x181BDEE70
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0x1BE2170 Offset: 0x1BE0770 VA: 0x181BE2170
	private bool ReadDataInName(ref int pos) { }

	// RVA: 0x1BDD8B0 Offset: 0x1BDBEB0 VA: 0x181BDD8B0
	private string ParseEntityName() { }

	// RVA: 0x1BD3DB0 Offset: 0x1BD23B0 VA: 0x181BD3DB0
	private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1BD3F60 Offset: 0x1BD2560 VA: 0x181BD3F60
	private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1BD2660 Offset: 0x1BD0C60 VA: 0x181BD2660
	private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x1BD26F0 Offset: 0x1BD0CF0 VA: 0x181BD26F0
	private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x1BD2900 Offset: 0x1BD0F00 VA: 0x181BD2900
	private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1BE1200 Offset: 0x1BDF800 VA: 0x181BE1200
	private void PopElementContext() { }

	// RVA: 0x1BD4D50 Offset: 0x1BD3350 VA: 0x181BD4D50
	private void OnNewLine(int pos) { }

	// RVA: 0x1BD9380 Offset: 0x1BD7980 VA: 0x181BD9380
	private void OnEof() { }

	// RVA: 0x1BD8C00 Offset: 0x1BD7200 VA: 0x181BD8C00
	private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

	// RVA: 0x1BD3B40 Offset: 0x1BD2140 VA: 0x181BD3B40
	private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1BE36C0 Offset: 0x1BE1CC0 VA: 0x181BE36C0
	private void ResetAttributes() { }

	// RVA: 0x1BD6680 Offset: 0x1BD4C80 VA: 0x181BD6680
	private void FullAttributeCleanup() { }

	// RVA: 0x1BE1CE0 Offset: 0x1BE02E0 VA: 0x181BE1CE0
	private void PushXmlContext() { }

	// RVA: 0x1BE13F0 Offset: 0x1BDF9F0 VA: 0x181BE13F0
	private void PopXmlContext() { }

	// RVA: 0x1BD6DF0 Offset: 0x1BD53F0 VA: 0x181BD6DF0
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0x1BD6D90 Offset: 0x1BD5390 VA: 0x181BD6D90
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x1BE14B0 Offset: 0x1BDFAB0 VA: 0x181BE14B0
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x1BD9770 Offset: 0x1BD7D70 VA: 0x181BD9770
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0x1BE17F0 Offset: 0x1BDFDF0 VA: 0x181BE17F0
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1BE19F0 Offset: 0x1BDFFF0 VA: 0x181BE19F0
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1BE1280 Offset: 0x1BDF880 VA: 0x181BE1280
	private void PopEntity() { }

	// RVA: 0x1BE3490 Offset: 0x1BE1A90 VA: 0x181BE3490
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1BE6140 Offset: 0x1BE4740 VA: 0x181BE6140
	private void UnregisterEntity() { }

	// RVA: 0x1BE1B60 Offset: 0x1BE0160 VA: 0x181BE1B60
	private void PushParsingState() { }

	// RVA: 0x1BE1320 Offset: 0x1BDF920 VA: 0x181BE1320
	private void PopParsingState() { }

	// RVA: 0x1BD76F0 Offset: 0x1BD5CF0 VA: 0x181BD76F0
	private int IncrementalRead() { }

	// RVA: 0x1BD5BD0 Offset: 0x1BD41D0 VA: 0x181BD5BD0
	private void FinishIncrementalRead() { }

	// RVA: 0x1BDDA20 Offset: 0x1BDC020 VA: 0x181BDDA20
	private bool ParseFragmentAttribute() { }

	// RVA: 0x1BD9EF0 Offset: 0x1BD84F0 VA: 0x181BD9EF0
	private bool ParseAttributeValueChunk() { }

	// RVA: 0x1BE0050 Offset: 0x1BDE650 VA: 0x181BE0050
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0x1BE5850 Offset: 0x1BE3E50 VA: 0x181BE5850
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x1BE5840 Offset: 0x1BE3E40 VA: 0x181BE5840
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x1BE5820 Offset: 0x1BE3E20 VA: 0x181BE5820
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x1BE5870 Offset: 0x1BE3E70 VA: 0x181BE5870
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x1BDFF60 Offset: 0x1BDE560 VA: 0x181BDFF60
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0x1BDFF70 Offset: 0x1BDE570 VA: 0x181BDFF70
	private string ParseUnexpectedToken() { }

	// RVA: 0x1BE5380 Offset: 0x1BE3980 VA: 0x181BE5380
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x1BD6BB0 Offset: 0x1BD51B0 VA: 0x181BD6BB0
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x1BD6AC0 Offset: 0x1BD50C0 VA: 0x181BD6AC0
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x1BE6290 Offset: 0x1BE4890 VA: 0x181BE6290
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0x1BDC740 Offset: 0x1BDAD40 VA: 0x181BDC740
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1BD9140 Offset: 0x1BD7740 VA: 0x181BD9140
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x1BE4090 Offset: 0x1BE2690 VA: 0x181BE4090
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1793F00 Offset: 0x1792500 VA: 0x181793F00 Slot: 56
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1BE3C50 Offset: 0x1BE2250 VA: 0x181BE3C50
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x1BE8440 Offset: 0x1BE6A40 VA: 0x181BE8440
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x1BE8400 Offset: 0x1BE6A00 VA: 0x181BE8400
	internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x1BE85F0 Offset: 0x1BE6BF0 VA: 0x181BE85F0
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x17A24A0 Offset: 0x17A0AA0 VA: 0x1817A24A0
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0x1BD45D0 Offset: 0x1BD2BD0 VA: 0x181BD45D0
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x1BD6CF0 Offset: 0x1BD52F0 VA: 0x181BD6CF0
	internal XmlResolver GetResolver() { }

	// RVA: 0x1BE8080 Offset: 0x1BE6680 VA: 0x181BE8080
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0x1BE7A80 Offset: 0x1BE6080 VA: 0x181BE7A80
	internal object get_InternalTypedValue() { }

	// RVA: 0x1BE80B0 Offset: 0x1BE66B0 VA: 0x181BE80B0
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0x1BE7E40 Offset: 0x1BE6440 VA: 0x181BE7E40
	internal bool get_StandAlone() { }

	// RVA: 0x1791C80 Offset: 0x1790280 VA: 0x181791C80 Slot: 55
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x17A4D50 Offset: 0x17A3350 VA: 0x1817A4D50
	internal bool get_V1Compat() { }

	// RVA: 0x1BD2A70 Offset: 0x1BD1070 VA: 0x181BD2A70
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

	// RVA: 0x1BD32A0 Offset: 0x1BD18A0 VA: 0x181BD32A0
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x1BD2FE0 Offset: 0x1BD15E0 VA: 0x181BD2FE0
	private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x1BE7FE0 Offset: 0x1BE65E0 VA: 0x181BE7FE0
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x1BE61A0 Offset: 0x1BE47A0 VA: 0x181BE61A0
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x1BE3360 Offset: 0x1BE1960 VA: 0x181BE3360
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	// RVA: 0x1BE4E50 Offset: 0x1BE3450 VA: 0x181BE4E50
	internal static string StripSpaces(string value) { }

	// RVA: 0x1BE5030 Offset: 0x1BE3630 VA: 0x181BE5030
	internal static void StripSpaces(char[] value, int index, ref int len) { }

	// RVA: 0x15B8470 Offset: 0x15B6A70 VA: 0x1815B8470
	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x1BD45C0 Offset: 0x1BD2BC0 VA: 0x181BD45C0
	internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) { }
}

// Namespace: System.Xml
public enum Formatting // TypeDefIndex: 6654
{
	// Fields
	public int value__; // 0x0
	public const Formatting None = 0;
	public const Formatting Indented = 1;
}

// Namespace: System.Xml
[EditorBrowsable(1)]
public class XmlTextWriter : XmlWriter // TypeDefIndex: 6661
{
	// Fields
	private TextWriter textWriter; // 0x18
	private XmlTextEncoder xmlEncoder; // 0x20
	private Encoding encoding; // 0x28
	private Formatting formatting; // 0x30
	private bool indented; // 0x34
	private int indentation; // 0x38
	private char indentChar; // 0x3C
	private XmlTextWriter.TagInfo[] stack; // 0x40
	private int top; // 0x48
	private XmlTextWriter.State[] stateTable; // 0x50
	private XmlTextWriter.State currentState; // 0x58
	private XmlTextWriter.Token lastToken; // 0x5C
	private XmlTextWriterBase64Encoder base64Encoder; // 0x60
	private char quoteChar; // 0x68
	private char curQuoteChar; // 0x6A
	private bool namespaces; // 0x6C
	private XmlTextWriter.SpecialAttr specialAttr; // 0x70
	private string prefixForXmlNs; // 0x78
	private bool flush; // 0x80
	private XmlTextWriter.Namespace[] nsStack; // 0x88
	private int nsTop; // 0x90
	private Dictionary<string, int> nsHashtable; // 0x98
	private bool useNsHashtable; // 0xA0
	private XmlCharType xmlCharType; // 0xA8
	private static string[] stateName; // 0x0
	private static string[] tokenName; // 0x8
	private static readonly XmlTextWriter.State[] stateTableDefault; // 0x10
	private static readonly XmlTextWriter.State[] stateTableDocument; // 0x18

	// Properties
	public Stream BaseStream { get; }
	public bool Namespaces { set; }
	public Formatting Formatting { set; }
	public char QuoteChar { set; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x1CCFEE0 Offset: 0x1CCE4E0 VA: 0x181CCFEE0
	internal void .ctor() { }

	// RVA: 0x1CD02A0 Offset: 0x1CCE8A0 VA: 0x181CD02A0
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x1CD0150 Offset: 0x1CCE750 VA: 0x181CD0150
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x1CD0080 Offset: 0x1CCE680 VA: 0x181CD0080
	public void .ctor(TextWriter w) { }

	// RVA: 0x1CD03A0 Offset: 0x1CCE9A0 VA: 0x181CD03A0
	public Stream get_BaseStream() { }

	// RVA: 0x1CD04A0 Offset: 0x1CCEAA0 VA: 0x181CD04A0
	public void set_Namespaces(bool value) { }

	// RVA: 0x1CD0490 Offset: 0x1CCEA90 VA: 0x181CD0490
	public void set_Formatting(Formatting value) { }

	// RVA: 0x1CD0520 Offset: 0x1CCEB20 VA: 0x181CD0520
	public void set_QuoteChar(char value) { }

	// RVA: 0x1CCF160 Offset: 0x1CCD760 VA: 0x181CCF160 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1CCF140 Offset: 0x1CCD740 VA: 0x181CCF140 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1CCE040 Offset: 0x1CCC640 VA: 0x181CCE040 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1CCDBC0 Offset: 0x1CCC1C0 VA: 0x181CCDBC0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CCF170 Offset: 0x1CCD770 VA: 0x181CCF170 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CCE1E0 Offset: 0x1CCC7E0 VA: 0x181CCE1E0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1CCE640 Offset: 0x1CCCC40 VA: 0x181CCE640 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1CCE930 Offset: 0x1CCCF30 VA: 0x181CCE930 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CCDFF0 Offset: 0x1CCC5F0 VA: 0x181CCDFF0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1CCD7A0 Offset: 0x1CCBDA0 VA: 0x181CCD7A0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CCDA20 Offset: 0x1CCC020 VA: 0x181CCDA20 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1CCE650 Offset: 0x1CCCC50 VA: 0x181CCE650 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1CCE5C0 Offset: 0x1CCCBC0 VA: 0x181CCE5C0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1CCD910 Offset: 0x1CCBF10 VA: 0x181CCD910 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CCF850 Offset: 0x1CCDE50 VA: 0x181CCF850 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CCF750 Offset: 0x1CCDD50 VA: 0x181CCF750 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1CCF7D0 Offset: 0x1CCDDD0 VA: 0x181CCF7D0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CCD980 Offset: 0x1CCBF80 VA: 0x181CCD980 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CCE820 Offset: 0x1CCCE20 VA: 0x181CCE820 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CCE8C0 Offset: 0x1CCCEC0 VA: 0x181CCE8C0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CCD600 Offset: 0x1CCBC00 VA: 0x181CCD600 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1CCD710 Offset: 0x1CCBD10 VA: 0x181CCD710 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1CD0420 Offset: 0x1CCEA20 VA: 0x181CD0420 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1CCBAA0 Offset: 0x1CCA0A0 VA: 0x181CCBAA0 Slot: 28
	public override void Close() { }

	// RVA: 0x1B31A70 Offset: 0x1B30070 VA: 0x181B31A70 Slot: 29
	public override void Flush() { }

	// RVA: 0x1CCC840 Offset: 0x1CCAE40 VA: 0x181CCC840 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1CCCFC0 Offset: 0x1CCB5C0 VA: 0x181CCCFC0
	private void StartDocument(int standalone) { }

	// RVA: 0x1CCB490 Offset: 0x1CC9A90 VA: 0x181CCB490
	private void AutoComplete(XmlTextWriter.Token token) { }

	// RVA: 0x1CCB440 Offset: 0x1CC9A40 VA: 0x181CCB440
	private void AutoCompleteAll() { }

	// RVA: 0x1CCC100 Offset: 0x1CCA700 VA: 0x181CCC100
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x1CCE1F0 Offset: 0x1CCC7F0 VA: 0x181CCE1F0
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x1CCDFA0 Offset: 0x1CCC5A0 VA: 0x181CCDFA0
	private void WriteEndAttributeQuote() { }

	// RVA: 0x1CCC020 Offset: 0x1CCA620 VA: 0x181CCC020
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x1CCCA30 Offset: 0x1CCB030 VA: 0x181CCCA30
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1CCB180 Offset: 0x1CC9780 VA: 0x181CCB180
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1CCB350 Offset: 0x1CC9950 VA: 0x181CCB350
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1CCC930 Offset: 0x1CCAF30 VA: 0x181CCC930
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1CCBCE0 Offset: 0x1CCA2E0 VA: 0x181CCBCE0
	private string GeneratePrefix() { }

	// RVA: 0x1CCC4F0 Offset: 0x1CCAAF0 VA: 0x181CCC4F0
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1CCC730 Offset: 0x1CCAD30 VA: 0x181CCC730
	private int LookupNamespace(string prefix) { }

	// RVA: 0x1CCC5F0 Offset: 0x1CCABF0 VA: 0x181CCC5F0
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x1CCBBD0 Offset: 0x1CCA1D0 VA: 0x181CCBBD0
	private string FindPrefix(string ns) { }

	// RVA: 0x1CCD2B0 Offset: 0x1CCB8B0 VA: 0x181CCD2B0
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x1CCBDE0 Offset: 0x1CCA3E0 VA: 0x181CCBDE0
	private void HandleSpecialAttribute() { }

	// RVA: 0x1CCD4D0 Offset: 0x1CCBAD0 VA: 0x181CCD4D0
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x1CCCE90 Offset: 0x1CCB490 VA: 0x181CCCE90
	private void PushStack() { }

	// RVA: 0x1CCBCA0 Offset: 0x1CCA2A0 VA: 0x181CCBCA0
	private void FlushEncoders() { }

	// RVA: 0x1CCF950 Offset: 0x1CCDF50 VA: 0x181CCF950
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class XmlUtf8RawTextWriter : XmlRawWriter // TypeDefIndex: 6662
{
	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected NewLineHandling newLineHandling; // 0x6C
	protected bool closeOutput; // 0x70
	protected bool omitXmlDeclaration; // 0x71
	protected string newLineChars; // 0x78
	protected bool checkCharacters; // 0x80
	protected XmlStandalone standalone; // 0x84
	protected XmlOutputMethod outputMethod; // 0x88
	protected bool autoXmlDeclaration; // 0x8C
	protected bool mergeCDataSections; // 0x8D

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1CD4960 Offset: 0x1CD2F60 VA: 0x181CD4960
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1CD4720 Offset: 0x1CD2D20 VA: 0x181CD4720
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1CD4490 Offset: 0x1CD2A90 VA: 0x181CD4490 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1CD46B0 Offset: 0x1CD2CB0 VA: 0x181CD46B0 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1CD3120 Offset: 0x1CD1720 VA: 0x181CD3120 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CD40F0 Offset: 0x1CD26F0 VA: 0x181CD40F0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CD1DC0 Offset: 0x1CD03C0 VA: 0x181CD1DC0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1CD3700 Offset: 0x1CD1D00 VA: 0x181CD3700 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CD3950 Offset: 0x1CD1F50 VA: 0x181CD3950 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CD3FE0 Offset: 0x1CD25E0 VA: 0x181CD3FE0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CD36C0 Offset: 0x1CD1CC0 VA: 0x181CD36C0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1CC0590 Offset: 0x1CBEB90 VA: 0x181CC0590 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1CD41C0 Offset: 0x1CD27C0 VA: 0x181CD41C0 Slot: 52
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1CD3860 Offset: 0x1CD1E60 VA: 0x181CD3860 Slot: 53
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1CD2860 Offset: 0x1CD0E60 VA: 0x181CD2860 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CD3000 Offset: 0x1CD1600 VA: 0x181CD3000 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1CD3AE0 Offset: 0x1CD20E0 VA: 0x181CD3AE0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1CD38A0 Offset: 0x1CD1EA0 VA: 0x181CD38A0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1CD2A50 Offset: 0x1CD1050 VA: 0x181CD2A50 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CD42F0 Offset: 0x1CD28F0 VA: 0x181CD42F0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CD42F0 Offset: 0x1CD28F0 VA: 0x181CD42F0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1CD4350 Offset: 0x1CD2950 VA: 0x181CD4350 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1BB81B0 Offset: 0x1BB67B0 VA: 0x181BB81B0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CD3F40 Offset: 0x1CD2540 VA: 0x181CD3F40 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CD3F90 Offset: 0x1CD2590 VA: 0x181CD3F90 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CD1440 Offset: 0x1CCFA40 VA: 0x181CD1440 Slot: 28
	public override void Close() { }

	// RVA: 0x1CD1900 Offset: 0x1CCFF00 VA: 0x181CD1900 Slot: 29
	public override void Flush() { }

	// RVA: 0x1CD1780 Offset: 0x1CCFD80 VA: 0x181CD1780 Slot: 56
	protected virtual void FlushBuffer() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void FlushEncoder() { }

	// RVA: 0x1CD21A0 Offset: 0x1CD07A0 VA: 0x181CD21A0
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1CD33D0 Offset: 0x1CD19D0 VA: 0x181CD33D0
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1CD1B40 Offset: 0x1CD0140 VA: 0x181CD1B40
	protected void RawText(string s) { }

	// RVA: 0x1CD1B90 Offset: 0x1CD0190 VA: 0x181CD1B90
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1CD3C00 Offset: 0x1CD2200 VA: 0x181CD3C00
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1CD2C00 Offset: 0x1CD1200 VA: 0x181CD2C00
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1CD2480 Offset: 0x1CD0A80 VA: 0x181CD2480
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1CD1AC0 Offset: 0x1CD00C0 VA: 0x181CD1AC0
	private static bool IsSurrogateByte(byte b) { }

	// RVA: 0x1CD15D0 Offset: 0x1CCFBD0 VA: 0x181CD15D0
	private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

	// RVA: 0x1CD1950 Offset: 0x1CCFF50 VA: 0x181CD1950
	private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

	// RVA: 0x1CD14A0 Offset: 0x1CCFAA0 VA: 0x181CD14A0
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1CD1580 Offset: 0x1CCFB80 VA: 0x181CD1580
	internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

	// RVA: 0x1CD1390 Offset: 0x1CCF990 VA: 0x181CD1390
	internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1CD3A60 Offset: 0x1CD2060 VA: 0x181CD3A60
	protected byte* WriteNewLine(byte* pDst) { }

	// RVA: 0x1CD1AE0 Offset: 0x1CD00E0 VA: 0x181CD1AE0
	protected static byte* LtEntity(byte* pDst) { }

	// RVA: 0x1CD1940 Offset: 0x1CCFF40 VA: 0x181CD1940
	protected static byte* GtEntity(byte* pDst) { }

	// RVA: 0x1CD12D0 Offset: 0x1CCF8D0 VA: 0x181CD12D0
	protected static byte* AmpEntity(byte* pDst) { }

	// RVA: 0x1CD1AF0 Offset: 0x1CD00F0 VA: 0x181CD1AF0
	protected static byte* QuoteEntity(byte* pDst) { }

	// RVA: 0x1CD1E00 Offset: 0x1CD0400 VA: 0x181CD1E00
	protected static byte* TabEntity(byte* pDst) { }

	// RVA: 0x1CD1AD0 Offset: 0x1CD00D0 VA: 0x181CD1AD0
	protected static byte* LineFeedEntity(byte* pDst) { }

	// RVA: 0x1CD12E0 Offset: 0x1CCF8E0 VA: 0x181CD12E0
	protected static byte* CarriageReturnEntity(byte* pDst) { }

	// RVA: 0x1CD12F0 Offset: 0x1CCF8F0 VA: 0x181CD12F0
	private static byte* CharEntity(byte* pDst, char ch) { }

	// RVA: 0x1CD1B20 Offset: 0x1CD0120 VA: 0x181CD1B20
	protected static byte* RawStartCData(byte* pDst) { }

	// RVA: 0x1CD1B10 Offset: 0x1CD0110 VA: 0x181CD1B10
	protected static byte* RawEndCData(byte* pDst) { }

	// RVA: 0x1CD1E10 Offset: 0x1CD0410 VA: 0x181CD1E10
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }
}

// Namespace: System.Xml
internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter // TypeDefIndex: 6663
{
	// Fields
	protected int indentLevel; // 0x90
	protected bool newLineOnAttributes; // 0x94
	protected string indentChars; // 0x98
	protected bool mixedContent; // 0xA0
	private BitStack mixedContentStack; // 0xA8
	protected ConformanceLevel conformanceLevel; // 0xB0

	// Methods

	// RVA: 0x1CD11A0 Offset: 0x1CCF7A0 VA: 0x181CD11A0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1CD0820 Offset: 0x1CCEE20 VA: 0x181CD0820 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CD0EE0 Offset: 0x1CCF4E0 VA: 0x181CD0EE0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CD06E0 Offset: 0x1CCECE0 VA: 0x181CD06E0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x163E0B0 Offset: 0x163C6B0 VA: 0x18163E0B0 Slot: 47
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x1CD0890 Offset: 0x1CCEE90 VA: 0x181CD0890 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CD09E0 Offset: 0x1CCEFE0 VA: 0x181CD09E0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CD0DC0 Offset: 0x1CCF3C0 VA: 0x181CD0DC0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1CD0770 Offset: 0x1CCED70 VA: 0x181CD0770 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CD07E0 Offset: 0x1CCEDE0 VA: 0x181CD07E0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1CD0BD0 Offset: 0x1CCF1D0 VA: 0x181CD0BD0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1CD0920 Offset: 0x1CCEF20 VA: 0x181CD0920 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1CD0780 Offset: 0x1CCED80 VA: 0x181CD0780 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CD1060 Offset: 0x1CCF660 VA: 0x181CD1060 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CD0FF0 Offset: 0x1CCF5F0 VA: 0x181CD0FF0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CD0FF0 Offset: 0x1CCF5F0 VA: 0x181CD0FF0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1CD0790 Offset: 0x1CCED90 VA: 0x181CD0790 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CD0D70 Offset: 0x1CCF370 VA: 0x181CD0D70 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CD0D10 Offset: 0x1CCF310 VA: 0x181CD0D10 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CD0750 Offset: 0x1CCED50 VA: 0x181CD0750 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1CD05C0 Offset: 0x1CCEBC0 VA: 0x181CD05C0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1CD0B30 Offset: 0x1CCF130 VA: 0x181CD0B30
	private void WriteIndent() { }
}

// Namespace: System.Xml
[Obsolete("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. https://go.microsoft.com/fwlink/?linkid=14202")]
public class XmlValidatingReader : XmlReader // TypeDefIndex: 6664
{
	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public bool Namespaces { get; }

	// Methods

	// RVA: 0x1B31740 Offset: 0x1B2FD40 VA: 0x181B31740 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B316E0 Offset: 0x1B2FCE0 VA: 0x181B316E0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x140B6A0 Offset: 0x1409CA0 VA: 0x18140B6A0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x140B790 Offset: 0x1409D90 VA: 0x18140B790 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1B31770 Offset: 0x1B2FD70 VA: 0x181B31770 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1B31680 Offset: 0x1B2FC80 VA: 0x181B31680 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1B31620 Offset: 0x1B2FC20 VA: 0x181B31620 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x140B730 Offset: 0x1409D30 VA: 0x18140B730 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x14A4A00 Offset: 0x14A3000 VA: 0x1814A4A00 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1B31400 Offset: 0x1B2FA00 VA: 0x181B31400 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1B313D0 Offset: 0x1B2F9D0 VA: 0x181B313D0 Slot: 25
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x86F3B0 Offset: 0x86D9B0 VA: 0x18086F3B0 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1B31460 Offset: 0x1B2FA60 VA: 0x181B31460 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x13703A0 Offset: 0x136E9A0 VA: 0x1813703A0 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1699D40 Offset: 0x1698340 VA: 0x181699D40 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1B314C0 Offset: 0x1B2FAC0 VA: 0x181B314C0 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1B314F0 Offset: 0x1B2FAF0 VA: 0x181B314F0 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1699DA0 Offset: 0x16983A0 VA: 0x181699DA0 Slot: 33
	public override bool Read() { }

	// RVA: 0x1B316B0 Offset: 0x1B2FCB0 VA: 0x181B316B0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x1699D70 Offset: 0x1698370 VA: 0x181699D70 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1B31710 Offset: 0x1B2FD10 VA: 0x181B31710 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1CC98C0 Offset: 0x1CC7EC0 VA: 0x181CC98C0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1B31550 Offset: 0x1B2FB50 VA: 0x181B31550 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1CD6390 Offset: 0x1CD4990 VA: 0x181CD6390
	public bool get_Namespaces() { }
}

// Namespace: System.Xml
internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 6667
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlTextReaderImpl coreReaderImpl; // 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x20
	private ValidationType validationType; // 0x28
	private BaseValidator validator; // 0x30
	private XmlSchemaCollection schemaCollection; // 0x38
	private bool processIdentityConstraints; // 0x40
	private XmlValidatingReaderImpl.ParsingFunction parsingFunction; // 0x44
	private XmlValidatingReaderImpl.ValidationEventHandling eventHandling; // 0x48
	private XmlParserContext parserContext; // 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x58
	private XmlReader outerReader; // 0x60
	private static XmlResolver s_tempResolver; // 0x0

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override bool HasValue { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override int AttributeCount { get; }
	public override bool CanResolveEntity { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal ValidationType ValidationType { get; }
	internal XmlSchemaCollection Schemas { get; }
	internal bool Namespaces { get; }
	internal BaseValidator Validator { get; set; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool StandAlone { get; }
	internal object SchemaTypeObject { set; }
	internal object TypedValueObject { get; set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1CD5AD0 Offset: 0x1CD40D0 VA: 0x181CD5AD0
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x1CD6240 Offset: 0x1CD4840 VA: 0x181CD6240 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1B31740 Offset: 0x1B2FD40 VA: 0x181B31740 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1699E80 Offset: 0x1698480 VA: 0x181699E80 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1B316E0 Offset: 0x1B2FCE0 VA: 0x181B316E0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x140B6A0 Offset: 0x1409CA0 VA: 0x18140B6A0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x140B790 Offset: 0x1409D90 VA: 0x18140B790 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x140B760 Offset: 0x1409D60 VA: 0x18140B760 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x1B31770 Offset: 0x1B2FD70 VA: 0x181B31770 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1B31680 Offset: 0x1B2FC80 VA: 0x181B31680 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1B31620 Offset: 0x1B2FC20 VA: 0x181B31620 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x140B730 Offset: 0x1409D30 VA: 0x18140B730 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x140B670 Offset: 0x1409C70 VA: 0x18140B670 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x140B700 Offset: 0x1409D00 VA: 0x18140B700 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1B317D0 Offset: 0x1B2FDD0 VA: 0x181B317D0 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1B317A0 Offset: 0x1B2FDA0 VA: 0x181B317A0 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x1CD6200 Offset: 0x1CD4800 VA: 0x181CD6200 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1B316B0 Offset: 0x1B2FCB0 VA: 0x181B316B0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x1B31710 Offset: 0x1B2FD10 VA: 0x181B31710 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x14A4A00 Offset: 0x14A3000 VA: 0x1814A4A00 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1B31400 Offset: 0x1B2FA00 VA: 0x181B31400 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1B313D0 Offset: 0x1B2F9D0 VA: 0x181B313D0 Slot: 25
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x86F3B0 Offset: 0x86D9B0 VA: 0x18086F3B0 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1CD4E00 Offset: 0x1CD3400 VA: 0x181CD4E00 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1CD4DC0 Offset: 0x1CD33C0 VA: 0x181CD4DC0 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1CD4EA0 Offset: 0x1CD34A0 VA: 0x181CD4EA0 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1CD4EF0 Offset: 0x1CD34F0 VA: 0x181CD4EF0 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1CD4E50 Offset: 0x1CD3450 VA: 0x181CD4E50 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1CD5360 Offset: 0x1CD3960 VA: 0x181CD5360 Slot: 33
	public override bool Read() { }

	// RVA: 0x1CD4A80 Offset: 0x1CD3080 VA: 0x181CD4A80 Slot: 35
	public override void Close() { }

	// RVA: 0x1CD4C70 Offset: 0x1CD3270 VA: 0x181CD4C70 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1CD5220 Offset: 0x1CD3820 VA: 0x181CD5220 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1CD5710 Offset: 0x1CD3D10 VA: 0x181CD5710 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1CD4D00 Offset: 0x1CD3300 VA: 0x181CD4D00
	internal void MoveOffEntityReference() { }

	// RVA: 0x1CD5290 Offset: 0x1CD3890 VA: 0x181CD5290 Slot: 44
	public override string ReadString() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 57
	public bool HasLineInfo() { }

	// RVA: 0x1CD6070 Offset: 0x1CD4670 VA: 0x181CD6070 Slot: 58
	public int get_LineNumber() { }

	// RVA: 0x1CD6110 Offset: 0x1CD4710 VA: 0x181CD6110 Slot: 59
	public int get_LinePosition() { }

	// RVA: 0x1CD4AC0 Offset: 0x1CD30C0 VA: 0x181CD4AC0 Slot: 60
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1BE5360 Offset: 0x1BE3960 VA: 0x181BE5360 Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1CD4CA0 Offset: 0x1CD32A0 VA: 0x181CD4CA0 Slot: 62
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1CD4AC0 Offset: 0x1CD30C0 VA: 0x181CD4AC0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1CD4CA0 Offset: 0x1CD32A0 VA: 0x181CD4CA0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	internal ValidationType get_ValidationType() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x1CD61E0 Offset: 0x1CD47E0 VA: 0x181CD61E0
	internal bool get_Namespaces() { }

	// RVA: 0x1CD4F40 Offset: 0x1CD3540 VA: 0x181CD4F40
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1CD5A50 Offset: 0x1CD4050 VA: 0x181CD5A50
	private void ValidateDtd() { }

	// RVA: 0x1CD5670 Offset: 0x1CD3C70 VA: 0x181CD5670
	private void ResolveEntityInternally() { }

	// RVA: 0x1CD5750 Offset: 0x1CD3D50 VA: 0x181CD5750
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x1CD4B70 Offset: 0x1CD3170 VA: 0x181CD4B70
	private XmlResolver GetResolver() { }

	// RVA: 0x1CD5110 Offset: 0x1CD3710 VA: 0x181CD5110
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal BaseValidator get_Validator() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x1CD61B0 Offset: 0x1CD47B0 VA: 0x181CD61B0 Slot: 55
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1CD6310 Offset: 0x1CD4910 VA: 0x181CD6310
	internal bool get_StandAlone() { }

	// RVA: 0x1CD6350 Offset: 0x1CD4950 VA: 0x181CD6350
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x1CD6330 Offset: 0x1CD4930 VA: 0x181CD6330
	internal object get_TypedValueObject() { }

	// RVA: 0x1CD6370 Offset: 0x1CD4970 VA: 0x181CD6370
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x1CD4A60 Offset: 0x1CD3060 VA: 0x181CD4A60
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x1CD6040 Offset: 0x1CD4640 VA: 0x181CD6040 Slot: 56
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1CD5900 Offset: 0x1CD3F00 VA: 0x181CD5900
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }
}

// Namespace: System.Xml
internal class XmlWellFormedWriter : XmlWriter // TypeDefIndex: 6680
{
	// Fields
	private XmlWriter writer; // 0x18
	private XmlRawWriter rawWriter; // 0x20
	private IXmlNamespaceResolver predefinedNamespaces; // 0x28
	private XmlWellFormedWriter.Namespace[] nsStack; // 0x30
	private int nsTop; // 0x38
	private Dictionary<string, int> nsHashtable; // 0x40
	private bool useNsHashtable; // 0x48
	private XmlWellFormedWriter.ElementScope[] elemScopeStack; // 0x50
	private int elemTop; // 0x58
	private XmlWellFormedWriter.AttrName[] attrStack; // 0x60
	private int attrCount; // 0x68
	private Dictionary<string, int> attrHashTable; // 0x70
	private XmlWellFormedWriter.SpecialAttribute specAttr; // 0x78
	private XmlWellFormedWriter.AttributeValueCache attrValueCache; // 0x80
	private string curDeclPrefix; // 0x88
	private XmlWellFormedWriter.State[] stateTable; // 0x90
	private XmlWellFormedWriter.State currentState; // 0x98
	private bool checkCharacters; // 0x9C
	private bool omitDuplNamespaces; // 0x9D
	private bool writeEndDocumentOnClose; // 0x9E
	private ConformanceLevel conformanceLevel; // 0xA0
	private bool dtdWritten; // 0xA4
	private bool xmlDeclFollows; // 0xA5
	private XmlCharType xmlCharType; // 0xA8
	private SecureStringHasher hasher; // 0xB0
	internal static readonly string[] stateName; // 0x0
	internal static readonly string[] tokenName; // 0x8
	private static WriteState[] state2WriteState; // 0x10
	private static readonly XmlWellFormedWriter.State[] StateTableDocument; // 0x18
	private static readonly XmlWellFormedWriter.State[] StateTableAuto; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal XmlRawWriter RawWriter { get; }
	private bool SaveAttrValue { get; }
	private bool InBase64 { get; }
	private bool IsClosedOrErrorState { get; }

	// Methods

	// RVA: 0x1CDC270 Offset: 0x1CDA870 VA: 0x181CDC270
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1CDC7A0 Offset: 0x1CDADA0 VA: 0x181CDC7A0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1CDAF40 Offset: 0x1CD9540 VA: 0x181CDAF40 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1CDAF10 Offset: 0x1CD9510 VA: 0x181CDAF10 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1CD9C50 Offset: 0x1CD8250 VA: 0x181CD9C50 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1CD8F40 Offset: 0x1CD7540 VA: 0x181CD8F40 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1CDAF50 Offset: 0x1CD9550 VA: 0x181CDAF50 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1CD9D60 Offset: 0x1CD8360 VA: 0x181CD9D60 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1CDA010 Offset: 0x1CD8610 VA: 0x181CDA010 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1CDA6C0 Offset: 0x1CD8CC0 VA: 0x181CDA6C0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1CD93B0 Offset: 0x1CD79B0 VA: 0x181CD93B0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1CD8AD0 Offset: 0x1CD70D0 VA: 0x181CD8AD0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1CD8EA0 Offset: 0x1CD74A0 VA: 0x181CD8EA0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1CDA1B0 Offset: 0x1CD87B0 VA: 0x181CDA1B0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1CD9F00 Offset: 0x1CD8500 VA: 0x181CD9F00 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1CD8B70 Offset: 0x1CD7170 VA: 0x181CD8B70 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1CDB370 Offset: 0x1CD9970 VA: 0x181CDB370 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1CDB9D0 Offset: 0x1CD9FD0 VA: 0x181CDB9D0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1CDB2C0 Offset: 0x1CD98C0 VA: 0x181CDB2C0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1CD8C90 Offset: 0x1CD7290 VA: 0x181CD8C90 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1CDA4B0 Offset: 0x1CD8AB0 VA: 0x181CDA4B0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1CDA400 Offset: 0x1CD8A00 VA: 0x181CDA400 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1CD8800 Offset: 0x1CD6E00 VA: 0x181CD8800 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1CD6F80 Offset: 0x1CD5580 VA: 0x181CD6F80 Slot: 28
	public override void Close() { }

	// RVA: 0x1CD71C0 Offset: 0x1CD57C0 VA: 0x181CD71C0 Slot: 29
	public override void Flush() { }

	// RVA: 0x1CD77E0 Offset: 0x1CD5DE0 VA: 0x181CD77E0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1CDB590 Offset: 0x1CD9B90 VA: 0x181CDB590 Slot: 33
	public override void WriteValue(bool value) { }

	// RVA: 0x1CDB950 Offset: 0x1CD9F50 VA: 0x181CDB950 Slot: 34
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1CDB750 Offset: 0x1CD9D50 VA: 0x181CDB750 Slot: 35
	public override void WriteValue(double value) { }

	// RVA: 0x1CDB490 Offset: 0x1CD9A90 VA: 0x181CDB490 Slot: 36
	public override void WriteValue(float value) { }

	// RVA: 0x1CDB7D0 Offset: 0x1CD9DD0 VA: 0x181CDB7D0 Slot: 37
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1CDB510 Offset: 0x1CD9B10 VA: 0x181CDB510 Slot: 38
	public override void WriteValue(int value) { }

	// RVA: 0x1CDB610 Offset: 0x1CD9C10 VA: 0x181CDB610 Slot: 39
	public override void WriteValue(long value) { }

	// RVA: 0x1CDB690 Offset: 0x1CD9C90 VA: 0x181CDB690 Slot: 32
	public override void WriteValue(string value) { }

	// RVA: 0x1CDB860 Offset: 0x1CD9E60 VA: 0x181CDB860 Slot: 31
	public override void WriteValue(object value) { }

	// RVA: 0x1CD89E0 Offset: 0x1CD6FE0 VA: 0x181CD89E0 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0x127D810 Offset: 0x127BE10 VA: 0x18127D810
	private bool get_SaveAttrValue() { }

	// RVA: 0x1CDC770 Offset: 0x1CDAD70 VA: 0x181CDC770
	private bool get_InBase64() { }

	// RVA: 0x1CD8470 Offset: 0x1CD6A70 VA: 0x181CD8470
	private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special) { }

	// RVA: 0x1CDAD80 Offset: 0x1CD9380 VA: 0x181CDAD80
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x1CD85D0 Offset: 0x1CD6BD0 VA: 0x181CD85D0
	private void StartFragment() { }

	// RVA: 0x1CD8000 Offset: 0x1CD6600 VA: 0x181CD8000
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x1CD7AA0 Offset: 0x1CD60A0 VA: 0x181CD7AA0
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x1CD66A0 Offset: 0x1CD4CA0 VA: 0x181CD66A0
	private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1CD6960 Offset: 0x1CD4F60 VA: 0x181CD6960
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1CD75E0 Offset: 0x1CD5BE0 VA: 0x181CD75E0
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x1CD79A0 Offset: 0x1CD5FA0 VA: 0x181CD79A0
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1CD70C0 Offset: 0x1CD56C0 VA: 0x181CD70C0
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x1CD6A40 Offset: 0x1CD5040 VA: 0x181CD6A40
	private void AdvanceState(XmlWellFormedWriter.Token token) { }

	// RVA: 0x1CD8510 Offset: 0x1CD6B10 VA: 0x181CD8510
	private void StartElementContent() { }

	// RVA: 0x1CD7360 Offset: 0x1CD5960 VA: 0x181CD7360
	private static string GetStateName(XmlWellFormedWriter.State state) { }

	// RVA: 0x1CD76F0 Offset: 0x1CD5CF0 VA: 0x181CD76F0
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x1CD7510 Offset: 0x1CD5B10 VA: 0x181CD7510
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x1CD7220 Offset: 0x1CD5820 VA: 0x181CD7220
	private string GeneratePrefix() { }

	// RVA: 0x1CD6E40 Offset: 0x1CD5440 VA: 0x181CD6E40
	private void CheckNCName(string ncname) { }

	// RVA: 0x1CD73F0 Offset: 0x1CD59F0 VA: 0x181CD73F0
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x1CD85E0 Offset: 0x1CD6BE0 VA: 0x181CD85E0
	private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState) { }

	// RVA: 0x1CDC790 Offset: 0x1CDAD90 VA: 0x181CDC790
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x1CD63C0 Offset: 0x1CD49C0 VA: 0x181CD63C0
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1CD6830 Offset: 0x1CD4E30 VA: 0x181CD6830
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x1CDBB10 Offset: 0x1CDA110 VA: 0x181CDBB10
	private static void .cctor() { }
}

// Namespace: System.Xml
public enum WriteState // TypeDefIndex: 6681
{
	// Fields
	public int value__; // 0x0
	public const WriteState Start = 0;
	public const WriteState Prolog = 1;
	public const WriteState Element = 2;
	public const WriteState Attribute = 3;
	public const WriteState Content = 4;
	public const WriteState Closed = 5;
	public const WriteState Error = 6;
}

// Namespace: System.Xml
public abstract class XmlWriter : IDisposable // TypeDefIndex: 6682
{
	// Fields
	private char[] writeNodeBuffer; // 0x10

	// Properties
	public abstract WriteState WriteState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteStartDocument();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void WriteStartDocument(bool standalone);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void WriteEndDocument();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

	// RVA: 0x1CF0D40 Offset: 0x1CEF340 VA: 0x181CF0D40
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteStartElement(string prefix, string localName, string ns);

	// RVA: 0x1CF0D10 Offset: 0x1CEF310 VA: 0x181CF0D10
	public void WriteStartElement(string localName) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void WriteEndElement();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void WriteFullEndElement();

	// RVA: 0x1CF02E0 Offset: 0x1CEE8E0 VA: 0x181CF02E0
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x1CF0350 Offset: 0x1CEE950 VA: 0x181CF0350
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x1CF03C0 Offset: 0x1CEE9C0 VA: 0x181CF03C0
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteStartAttribute(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void WriteEndAttribute();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void WriteCData(string text);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void WriteComment(string text);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void WriteProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteEntityRef(string name);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void WriteCharEntity(char ch);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void WriteWhitespace(string ws);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void WriteString(string text);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void WriteChars(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WriteRaw(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteRaw(string data);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void WriteBase64(byte[] buffer, int index, int count);

	// RVA: 0x1CF0700 Offset: 0x1CEED00 VA: 0x181CF0700 Slot: 26
	public virtual void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract WriteState get_WriteState();

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 28
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string LookupPrefix(string ns);

	// RVA: 0x1CF0F70 Offset: 0x1CEF570 VA: 0x181CF0F70 Slot: 31
	public virtual void WriteValue(object value) { }

	// RVA: 0x1CF0D70 Offset: 0x1CEF370 VA: 0x181CF0D70 Slot: 32
	public virtual void WriteValue(string value) { }

	// RVA: 0x1CF1140 Offset: 0x1CEF740 VA: 0x181CF1140 Slot: 33
	public virtual void WriteValue(bool value) { }

	// RVA: 0x1CF0EF0 Offset: 0x1CEF4F0 VA: 0x181CF0EF0 Slot: 34
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0x1CF10D0 Offset: 0x1CEF6D0 VA: 0x181CF10D0 Slot: 35
	public virtual void WriteValue(double value) { }

	// RVA: 0x1CF1060 Offset: 0x1CEF660 VA: 0x181CF1060 Slot: 36
	public virtual void WriteValue(float value) { }

	// RVA: 0x1CF0E00 Offset: 0x1CEF400 VA: 0x181CF0E00 Slot: 37
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0x1CF0D90 Offset: 0x1CEF390 VA: 0x181CF0D90 Slot: 38
	public virtual void WriteValue(int value) { }

	// RVA: 0x1CF0E80 Offset: 0x1CEF480 VA: 0x181CF0E80 Slot: 39
	public virtual void WriteValue(long value) { }

	// RVA: 0x1CF0410 Offset: 0x1CEEA10 VA: 0x181CF0410 Slot: 40
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1CF07A0 Offset: 0x1CEEDA0 VA: 0x181CF07A0 Slot: 41
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1CF0730 Offset: 0x1CEED30 VA: 0x181CF0730
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x1CF02C0 Offset: 0x1CEE8C0 VA: 0x181CF02C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1CF0280 Offset: 0x1CEE880 VA: 0x181CF0280 Slot: 42
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1CF01A0 Offset: 0x1CEE7A0 VA: 0x181CF01A0
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x1CF0130 Offset: 0x1CEE730 VA: 0x181CF0130
	public static XmlWriter Create(TextWriter output) { }

	// RVA: 0x1CF0210 Offset: 0x1CEE810 VA: 0x181CF0210
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml
public enum XmlOutputMethod // TypeDefIndex: 6683
{
	// Fields
	public int value__; // 0x0
	public const XmlOutputMethod Xml = 0;
	public const XmlOutputMethod Html = 1;
	public const XmlOutputMethod Text = 2;
	public const XmlOutputMethod AutoDetect = 3;
}

// Namespace: System.Xml
internal enum TriState // TypeDefIndex: 6684
{
	// Fields
	public int value__; // 0x0
	public const TriState Unknown = -1;
	public const TriState False = 0;
	public const TriState True = 1;
}

// Namespace: System.Xml
internal enum XmlStandalone // TypeDefIndex: 6685
{
	// Fields
	public int value__; // 0x0
	public const XmlStandalone Omit = 0;
	public const XmlStandalone Yes = 1;
	public const XmlStandalone No = 2;
}

// Namespace: System.Xml
public sealed class XmlWriterSettings // TypeDefIndex: 6686
{
	// Fields
	private bool useAsync; // 0x10
	private Encoding encoding; // 0x18
	private bool omitXmlDecl; // 0x20
	private NewLineHandling newLineHandling; // 0x24
	private string newLineChars; // 0x28
	private TriState indent; // 0x30
	private string indentChars; // 0x38
	private bool newLineOnAttributes; // 0x40
	private bool closeOutput; // 0x41
	private NamespaceHandling namespaceHandling; // 0x44
	private ConformanceLevel conformanceLevel; // 0x48
	private bool checkCharacters; // 0x4C
	private bool writeEndDocumentOnClose; // 0x4D
	private XmlOutputMethod outputMethod; // 0x50
	private List<XmlQualifiedName> cdataSections; // 0x58
	private bool doNotEscapeUriAttributes; // 0x60
	private bool mergeCDataSections; // 0x61
	private string mediaType; // 0x68
	private string docTypeSystem; // 0x70
	private string docTypePublic; // 0x78
	private XmlStandalone standalone; // 0x80
	private bool autoXmlDecl; // 0x84
	private bool isReadOnly; // 0x85

	// Properties
	public bool Async { get; }
	public Encoding Encoding { get; }
	public bool OmitXmlDeclaration { get; set; }
	public NewLineHandling NewLineHandling { get; }
	public string NewLineChars { get; }
	public bool Indent { get; set; }
	public string IndentChars { get; }
	public bool NewLineOnAttributes { get; }
	public bool CloseOutput { get; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; }
	public NamespaceHandling NamespaceHandling { get; set; }
	public bool WriteEndDocumentOnClose { get; }
	public XmlOutputMethod OutputMethod { get; set; }
	internal List<XmlQualifiedName> CDataSectionElements { get; }
	public bool DoNotEscapeUriAttributes { get; }
	internal bool MergeCDataSections { get; }
	internal string MediaType { get; }
	internal string DocTypeSystem { get; }
	internal string DocTypePublic { get; }
	internal XmlStandalone Standalone { get; }
	internal bool AutoXmlDeclaration { get; }
	internal TriState IndentInternal { get; }
	internal bool IsQuerySpecific { get; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x1CEFD40 Offset: 0x1CEE340 VA: 0x181CEFD40
	public void .ctor() { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_Async() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Encoding get_Encoding() { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x1CF00D0 Offset: 0x1CEE6D0 VA: 0x181CF00D0
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_NewLineChars() { }

	// RVA: 0x1CEFEC0 Offset: 0x1CEE4C0 VA: 0x181CEFEC0
	public bool get_Indent() { }

	// RVA: 0x1CEFFD0 Offset: 0x1CEE5D0 VA: 0x181CEFFD0
	public void set_Indent(bool value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_IndentChars() { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_NewLineOnAttributes() { }

	// RVA: 0x14BFB70 Offset: 0x14BE170 VA: 0x1814BFB70
	public bool get_CloseOutput() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x1CEFF30 Offset: 0x1CEE530 VA: 0x181CEFF30
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x16EE360 Offset: 0x16EC960 VA: 0x1816EE360
	public bool get_CheckCharacters() { }

	// RVA: 0x15EEFB0 Offset: 0x15ED5B0 VA: 0x1815EEFB0
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x1CF0030 Offset: 0x1CEE630 VA: 0x181CF0030
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x16EE380 Offset: 0x16EC980 VA: 0x1816EE380
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x3AA880 Offset: 0x3A8E80 VA: 0x1803AA880
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x1CEF410 Offset: 0x1CEDA10 VA: 0x181CEF410
	public XmlWriterSettings Clone() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x1380E10 Offset: 0x137F410 VA: 0x181380E10
	internal bool get_MergeCDataSections() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	internal string get_MediaType() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	internal string get_DocTypeSystem() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	internal string get_DocTypePublic() { }

	// RVA: 0x498D50 Offset: 0x497350 VA: 0x180498D50
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x4C1600 Offset: 0x4BFC00 VA: 0x1804C1600
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	internal TriState get_IndentInternal() { }

	// RVA: 0x1CEFED0 Offset: 0x1CEE4D0 VA: 0x181CEFED0
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x1CEF500 Offset: 0x1CEDB00 VA: 0x181CEF500
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x1CEF940 Offset: 0x1CEDF40 VA: 0x181CEF940
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x1CF0120 Offset: 0x1CEE720 VA: 0x181CF0120
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x1CEF360 Offset: 0x1CED960 VA: 0x181CEF360
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x1CEFC10 Offset: 0x1CEE210 VA: 0x181CEFC10
	private void Initialize() { }
}

// Namespace: System.Xml
[DefaultMember("Item")]
internal class XsdCachingReader : XmlReader, IXmlLineInfo // TypeDefIndex: 6688
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlNameTable coreReaderNameTable; // 0x18
	private ValidatingReaderNodeData[] contentEvents; // 0x20
	private ValidatingReaderNodeData[] attributeEvents; // 0x28
	private ValidatingReaderNodeData cachedNode; // 0x30
	private XsdCachingReader.CachingReaderState cacheState; // 0x38
	private int contentIndex; // 0x3C
	private int attributeCount; // 0x40
	private bool returnOriginalStringValues; // 0x44
	private CachingEventHandler cacheHandler; // 0x48
	private int currentAttrIndex; // 0x50
	private int currentContentIndex; // 0x54
	private bool readAhead; // 0x58
	private IXmlLineInfo lineInfo; // 0x60
	private ValidatingReaderNodeData textNode; // 0x68

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override bool HasValue { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x1CF2AB0 Offset: 0x1CF10B0 VA: 0x181CF2AB0
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x1CF19A0 Offset: 0x1CEFFA0 VA: 0x181CF19A0
	private void Init() { }

	// RVA: 0x1CF2710 Offset: 0x1CF0D10 VA: 0x181CF2710
	internal void Reset(XmlReader reader) { }

	// RVA: 0x16501C0 Offset: 0x164E7C0 VA: 0x1816501C0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1CF2CE0 Offset: 0x1CF12E0 VA: 0x181CF2CE0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1CF2C90 Offset: 0x1CF1290 VA: 0x181CF2C90 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1CF2C70 Offset: 0x1CF1270 VA: 0x181CF2C70 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1CF2CC0 Offset: 0x1CF12C0 VA: 0x181CF2CC0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1CF2D00 Offset: 0x1CF1300 VA: 0x181CF2D00 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1CF2C10 Offset: 0x1CF1210 VA: 0x181CF2C10 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x1CF2D20 Offset: 0x1CF1320 VA: 0x181CF2D20 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1CF2BB0 Offset: 0x1CF11B0 VA: 0x181CF2BB0 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1B31620 Offset: 0x1B2FC20 VA: 0x181B31620 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x140B700 Offset: 0x1409D00 VA: 0x18140B700 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1B317D0 Offset: 0x1B2FDD0 VA: 0x181B317D0 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1B317A0 Offset: 0x1B2FDA0 VA: 0x181B317A0 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1CF1910 Offset: 0x1CEFF10 VA: 0x181CF1910 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1CF1800 Offset: 0x1CEFE00 VA: 0x181CF1800 Slot: 25
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1CF1770 Offset: 0x1CEFD70 VA: 0x181CF1770 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1CF1BF0 Offset: 0x1CF01F0 VA: 0x181CF1BF0 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1CF1B50 Offset: 0x1CF0150 VA: 0x181CF1B50 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1CF1CD0 Offset: 0x1CF02D0 VA: 0x181CF1CD0 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1CF1D20 Offset: 0x1CF0320 VA: 0x181CF1D20 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1CF1C80 Offset: 0x1CF0280 VA: 0x181CF1C80 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1CF1E90 Offset: 0x1CF0490 VA: 0x181CF1E90 Slot: 33
	public override bool Read() { }

	// RVA: 0x1CF2690 Offset: 0x1CF0C90 VA: 0x181CF2690
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x1CF28F0 Offset: 0x1CF0EF0 VA: 0x181CF28F0
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x1CF2530 Offset: 0x1CF0B30 VA: 0x181CF2530
	internal void RecordEndElementNode() { }

	// RVA: 0x1CF1E70 Offset: 0x1CF0470 VA: 0x181CF1E70
	internal string ReadOriginalContentAsString() { }

	// RVA: 0x1CF2BD0 Offset: 0x1CF11D0 VA: 0x181CF2BD0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x1CF14F0 Offset: 0x1CEFAF0 VA: 0x181CF14F0 Slot: 35
	public override void Close() { }

	// RVA: 0x1699D70 Offset: 0x1698370 VA: 0x181699D70 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1CF27B0 Offset: 0x1CF0DB0 VA: 0x181CF27B0 Slot: 37
	public override void Skip() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1B31430 Offset: 0x1B2FA30 VA: 0x181B31430 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1CF2740 Offset: 0x1CF0D40 VA: 0x181CF2740 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1CF1D80 Offset: 0x1CF0380 VA: 0x181CF1D80 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 57
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x1CF2A70 Offset: 0x1CF1070 VA: 0x181CF2A70 Slot: 58
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1CF2A90 Offset: 0x1CF1090 VA: 0x181CF2A90 Slot: 59
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x1CF2780 Offset: 0x1CF0D80 VA: 0x181CF2780
	internal void SetToReplayMode() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal XmlReader GetCoreReader() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x1CF14E0 Offset: 0x1CEFAE0 VA: 0x181CF14E0
	private void ClearAttributesInfo() { }

	// RVA: 0x1CF11B0 Offset: 0x1CEF7B0 VA: 0x181CF11B0
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x1CF1340 Offset: 0x1CEF940 VA: 0x181CF1340
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x1CF2210 Offset: 0x1CF0810 VA: 0x181CF2210
	private void RecordAttributes() { }

	// RVA: 0x1CF16B0 Offset: 0x1CEFCB0 VA: 0x181CF16B0
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x1CF15F0 Offset: 0x1CEFBF0 VA: 0x181CF15F0
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x1CF1530 Offset: 0x1CEFB30 VA: 0x181CF1530
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }
}

// Namespace: System.Xml
internal sealed class CachingEventHandler : MulticastDelegate // TypeDefIndex: 6689
{
	// Methods

	// RVA: 0x5C3910 Offset: 0x5C1F10 VA: 0x1805C3910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(XsdCachingReader cachingReader) { }
}

// Namespace: System.Xml
internal class AttributePSVIInfo // TypeDefIndex: 6690
{
	// Fields
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal object typedAttributeValue; // 0x20
	internal XmlSchemaInfo attributeSchemaInfo; // 0x28

	// Methods

	// RVA: 0x1CDC9A0 Offset: 0x1CDAFA0 VA: 0x181CDC9A0
	internal void .ctor() { }

	// RVA: 0x1CDC920 Offset: 0x1CDAF20 VA: 0x181CDC920
	internal void Reset() { }
}

// Namespace: System.Xml
internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 6692
{
	// Fields
	private XmlReader coreReader; // 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x18
	private IXmlNamespaceResolver thisNSResolver; // 0x20
	private XmlSchemaValidator validator; // 0x28
	private XmlResolver xmlResolver; // 0x30
	private ValidationEventHandler validationEvent; // 0x38
	private XsdValidatingReader.ValidatingReaderState validationState; // 0x40
	private XmlValueGetter valueGetter; // 0x48
	private XmlNamespaceManager nsManager; // 0x50
	private bool manageNamespaces; // 0x58
	private bool processInlineSchema; // 0x59
	private bool replayCache; // 0x5A
	private ValidatingReaderNodeData cachedNode; // 0x60
	private AttributePSVIInfo attributePSVI; // 0x68
	private int attributeCount; // 0x70
	private int coreReaderAttributeCount; // 0x74
	private int currentAttrIndex; // 0x78
	private AttributePSVIInfo[] attributePSVINodes; // 0x80
	private ArrayList defaultAttributes; // 0x88
	private Parser inlineSchemaParser; // 0x90
	private object atomicValue; // 0x98
	private XmlSchemaInfo xmlSchemaInfo; // 0xA0
	private string originalAtomicValueString; // 0xA8
	private XmlNameTable coreReaderNameTable; // 0xB0
	private XsdCachingReader cachingReader; // 0xB8
	private ValidatingReaderNodeData textNode; // 0xC0
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsdSchema; // 0xF0
	private string XsiSchemaLocation; // 0xF8
	private string XsiNoNamespaceSchemaLocation; // 0x100
	private XmlCharType xmlCharType; // 0x108
	private IXmlLineInfo lineInfo; // 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x118
	private XsdValidatingReader.ValidatingReaderState savedState; // 0x120
	private static Type TypeOfString; // 0x0

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override bool HasValue { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	private XmlSchemaType ElementXmlType { get; }
	private XmlSchemaType AttributeXmlType { get; }
	private XmlSchemaInfo AttributeSchemaInfo { get; }

	// Methods

	// RVA: 0x1CF7780 Offset: 0x1CF5D80 VA: 0x181CF7780
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x1CF7990 Offset: 0x1CF5F90 VA: 0x181CF7990
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x1CF40A0 Offset: 0x1CF26A0 VA: 0x181CF40A0
	private void Init() { }

	// RVA: 0x1CF6A70 Offset: 0x1CF5070 VA: 0x181CF6A70
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x1CF7ED0 Offset: 0x1CF64D0 VA: 0x181CF7ED0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1CF7DA0 Offset: 0x1CF63A0 VA: 0x181CF7DA0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1CF7C10 Offset: 0x1CF6210 VA: 0x181CF7C10 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1CF7BC0 Offset: 0x1CF61C0 VA: 0x181CF7BC0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1CF7D50 Offset: 0x1CF6350 VA: 0x181CF7D50 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1CF7E40 Offset: 0x1CF6440 VA: 0x181CF7E40 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1CF7A80 Offset: 0x1CF6080 VA: 0x181CF7A80 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x1CF8090 Offset: 0x1CF6690 VA: 0x181CF8090 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1CF7A00 Offset: 0x1CF6000 VA: 0x181CF7A00 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1B31620 Offset: 0x1B2FC20 VA: 0x181B31620 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x140B730 Offset: 0x1409D30 VA: 0x18140B730 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1CF7AC0 Offset: 0x1CF60C0 VA: 0x181CF7AC0 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x140B700 Offset: 0x1409D00 VA: 0x18140B700 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1B317D0 Offset: 0x1B2FDD0 VA: 0x181B317D0 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1B317A0 Offset: 0x1B2FDA0 VA: 0x181B317A0 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 20
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1CF7FB0 Offset: 0x1CF65B0 VA: 0x181CF7FB0 Slot: 21
	public override Type get_ValueType() { }

	// RVA: 0x1CF6010 Offset: 0x1CF4610 VA: 0x181CF6010 Slot: 22
	public override string ReadContentAsString() { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1CF34C0 Offset: 0x1CF1AC0 VA: 0x181CF34C0 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1CF3540 Offset: 0x1CF1B40 VA: 0x181CF3540 Slot: 25
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1CF33D0 Offset: 0x1CF19D0 VA: 0x181CF33D0 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1CF4820 Offset: 0x1CF2E20 VA: 0x181CF4820 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1CF4910 Offset: 0x1CF2F10 VA: 0x181CF4910 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1CF4B90 Offset: 0x1CF3190 VA: 0x181CF4B90 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1CF4D80 Offset: 0x1CF3380 VA: 0x181CF4D80 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1CF4B30 Offset: 0x1CF3130 VA: 0x181CF4B30 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1CF65D0 Offset: 0x1CF4BD0 VA: 0x181CF65D0 Slot: 33
	public override bool Read() { }

	// RVA: 0x1B316B0 Offset: 0x1B2FCB0 VA: 0x181B316B0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x1CF3050 Offset: 0x1CF1650 VA: 0x181CF3050 Slot: 35
	public override void Close() { }

	// RVA: 0x1CF7E90 Offset: 0x1CF6490 VA: 0x181CF7E90 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1CF6CD0 Offset: 0x1CF52D0 VA: 0x181CF6CD0 Slot: 37
	public override void Skip() { }

	// RVA: 0x16237B0 Offset: 0x1621DB0 VA: 0x1816237B0 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1CF47C0 Offset: 0x1CF2DC0 VA: 0x181CF47C0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1CF68A0 Offset: 0x1CF4EA0 VA: 0x181CF68A0 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1CF5E90 Offset: 0x1CF4490 VA: 0x181CF5E90 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1CF70E0 Offset: 0x1CF56E0 VA: 0x181CF70E0 Slot: 58
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1CF7180 Offset: 0x1CF5780 VA: 0x181CF7180 Slot: 59
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x1CF7490 Offset: 0x1CF5A90 VA: 0x181CF7490 Slot: 57
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1CF71D0 Offset: 0x1CF57D0 VA: 0x181CF71D0 Slot: 60
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x1CF7430 Offset: 0x1CF5A30 VA: 0x181CF7430 Slot: 61
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1CF73D0 Offset: 0x1CF59D0 VA: 0x181CF73D0 Slot: 62
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x1CF7380 Offset: 0x1CF5980 VA: 0x181CF7380 Slot: 63
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 64
	public bool HasLineInfo() { }

	// RVA: 0x1CF7B00 Offset: 0x1CF6100 VA: 0x181CF7B00 Slot: 65
	public int get_LineNumber() { }

	// RVA: 0x1CF7B60 Offset: 0x1CF6160 VA: 0x181CF7B60 Slot: 66
	public int get_LinePosition() { }

	// RVA: 0x1CF6ED0 Offset: 0x1CF54D0 VA: 0x181CF6ED0 Slot: 67
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1CF6FC0 Offset: 0x1CF55C0 VA: 0x181CF6FC0 Slot: 68
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1CF7050 Offset: 0x1CF5650 VA: 0x181CF7050 Slot: 69
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1B31770 Offset: 0x1B2FD70 VA: 0x181B31770
	private object GetStringValue() { }

	// RVA: 0x1CF7A50 Offset: 0x1CF6050 VA: 0x181CF7A50
	private XmlSchemaType get_ElementXmlType() { }

	// RVA: 0x1CF79D0 Offset: 0x1CF5FD0 VA: 0x181CF79D0
	private XmlSchemaType get_AttributeXmlType() { }

	// RVA: 0x1CF79B0 Offset: 0x1CF5FB0 VA: 0x181CF79B0
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x1CF5A00 Offset: 0x1CF4000 VA: 0x181CF5A00
	private void ProcessReaderEvent() { }

	// RVA: 0x1CF4F60 Offset: 0x1CF3560 VA: 0x181CF4F60
	private void ProcessElementEvent() { }

	// RVA: 0x1CF55B0 Offset: 0x1CF3BB0 VA: 0x181CF55B0
	private void ProcessEndElementEvent() { }

	// RVA: 0x1CF7540 Offset: 0x1CF5B40 VA: 0x181CF7540
	private void ValidateAttributes() { }

	// RVA: 0x1CF2FF0 Offset: 0x1CF15F0 VA: 0x181CF2FF0
	private void ClearAttributesInfo() { }

	// RVA: 0x1CF3210 Offset: 0x1CF1810 VA: 0x181CF3210
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x1CF3160 Offset: 0x1CF1760 VA: 0x181CF3160
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x1CF3A80 Offset: 0x1CF2080 VA: 0x181CF3A80
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x1CF3900 Offset: 0x1CF1F00 VA: 0x181CF3900
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x1CF2D50 Offset: 0x1CF1350 VA: 0x181CF2D50
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x1CF4770 Offset: 0x1CF2D70 VA: 0x181CF4770
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1CF58D0 Offset: 0x1CF3ED0 VA: 0x181CF58D0
	private void ProcessInlineSchema() { }

	// RVA: 0x1CF4740 Offset: 0x1CF2D40 VA: 0x181CF4740
	private object InternalReadContentAsObject() { }

	// RVA: 0x1CF4490 Offset: 0x1CF2A90 VA: 0x181CF4490
	private object InternalReadContentAsObject(bool unwrapTypedValue) { }

	// RVA: 0x1CF44B0 Offset: 0x1CF2AB0 VA: 0x181CF44B0
	private object InternalReadContentAsObject(bool unwrapTypedValue, out string originalStringValue) { }

	// RVA: 0x1CF6300 Offset: 0x1CF4900 VA: 0x181CF6300
	private object ReadTillEndElement() { }

	// RVA: 0x1CF6E50 Offset: 0x1CF5450 VA: 0x181CF6E50
	private void SwitchReader() { }

	// RVA: 0x1CF5C10 Offset: 0x1CF4210 VA: 0x181CF5C10
	private void ReadAheadForMemberType() { }

	// RVA: 0x1CF3BD0 Offset: 0x1CF21D0 VA: 0x181CF3BD0
	private void GetIsDefault() { }

	// RVA: 0x1CF3F10 Offset: 0x1CF2510 VA: 0x181CF3F10
	private void GetMemberType() { }

	// RVA: 0x1CF68E0 Offset: 0x1CF4EE0 VA: 0x181CF68E0
	private object ReturnBoxedValue(object typedValue, XmlSchemaType xmlType, bool unWrap) { }

	// RVA: 0x1CF3650 Offset: 0x1CF1C50 VA: 0x181CF3650
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x1CF3090 Offset: 0x1CF1690 VA: 0x181CF3090
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x1CF2F90 Offset: 0x1CF1590 VA: 0x181CF2F90
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x1CF4020 Offset: 0x1CF2620 VA: 0x181CF4020
	private string GetOriginalAtomicValueStringOfElement() { }
}

// Namespace: System.Xml
internal class DomNameTable // TypeDefIndex: 6693
{
	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x1CDE460 Offset: 0x1CDCA60 VA: 0x181CDE460
	public void .ctor(XmlDocument document) { }

	// RVA: 0x1CDE1C0 Offset: 0x1CDC7C0 VA: 0x181CDE1C0
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1CDDDF0 Offset: 0x1CDC3F0 VA: 0x181CDDDF0
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1CDE300 Offset: 0x1CDC900 VA: 0x181CDE300
	private void Grow() { }
}

// Namespace: System.Xml
public class XmlAttribute : XmlNode // TypeDefIndex: 6694
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Properties
	internal int LocalNameHash { get; }
	internal XmlName XmlName { get; set; }
	public override XmlNode ParentNode { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string Value { get; set; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerText { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public virtual bool Specified { get; }
	public virtual XmlElement OwnerElement { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }
	internal override XmlSpace XmlSpace { get; }
	internal override string XmlLang { get; }

	// Methods

	// RVA: 0x1CE0A10 Offset: 0x1CDF010 VA: 0x181CE0A10
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x1CE0BB0 Offset: 0x1CDF1B0 VA: 0x181CE0BB0
	internal int get_LocalNameHash() { }

	// RVA: 0x1CE09C0 Offset: 0x1CDEFC0 VA: 0x181CE09C0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal XmlName get_XmlName() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x1CE0270 Offset: 0x1CDE870 VA: 0x181CE0270 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1CE0BD0 Offset: 0x1CDF1D0 VA: 0x181CE0BD0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x168F790 Offset: 0x168DD90 VA: 0x18168F790 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x168F7B0 Offset: 0x168DDB0 VA: 0x18168F7B0 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0x168F7D0 Offset: 0x168DDD0 VA: 0x18168F7D0 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0x1CE0EA0 Offset: 0x1CDF4A0 VA: 0x181CE0EA0 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x168F930 Offset: 0x168DF30 VA: 0x18168F930 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1CE0C80 Offset: 0x1CDF280 VA: 0x181CE0C80 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1CE0F70 Offset: 0x1CDF570 VA: 0x181CE0F70 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1CE0D90 Offset: 0x1CDF390 VA: 0x181CE0D90 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1CE04B0 Offset: 0x1CDEAB0 VA: 0x181CE04B0
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x1CE0750 Offset: 0x1CDED50 VA: 0x181CE0750
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1CE0030 Offset: 0x1CDE630 VA: 0x181CE0030 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1CE04A0 Offset: 0x1CDEAA0 VA: 0x181CE04A0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 56
	public virtual bool get_Specified() { }

	// RVA: 0x1CE0400 Offset: 0x1CDEA00 VA: 0x181CE0400 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1CE0360 Offset: 0x1CDE960 VA: 0x181CE0360 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1CE06D0 Offset: 0x1CDECD0 VA: 0x181CE06D0 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1CE0650 Offset: 0x1CDEC50 VA: 0x181CE0650 Slot: 24
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x1CE01F0 Offset: 0x1CDE7F0 VA: 0x181CE01F0 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1CE0BF0 Offset: 0x1CDF1F0 VA: 0x181CE0BF0 Slot: 57
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0x1CE0E00 Offset: 0x1CDF400 VA: 0x181CE0E00 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x1CE08F0 Offset: 0x1CDEEF0 VA: 0x181CE08F0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1CE0880 Offset: 0x1CDEE80 VA: 0x181CE0880 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1CE0B30 Offset: 0x1CDF130 VA: 0x181CE0B30 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x1CE0D20 Offset: 0x1CDF320 VA: 0x181CE0D20 Slot: 53
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0x1CE0CA0 Offset: 0x1CDF2A0 VA: 0x181CE0CA0 Slot: 54
	internal override string get_XmlLang() { }
}

// Namespace: System.Xml
[DefaultMember("ItemOf")]
public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable // TypeDefIndex: 6695
{
	// Properties
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x1CDFC90 Offset: 0x1CDE290 VA: 0x181CDFC90
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x1CDFE10 Offset: 0x1CDE410 VA: 0x181CDFE10
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x1CDFF00 Offset: 0x1CDE500 VA: 0x181CDFF00
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0x1CDFCA0 Offset: 0x1CDE2A0 VA: 0x181CDFCA0
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0x1CDEBC0 Offset: 0x1CDD1C0 VA: 0x181CDEBC0
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0x1CDFA50 Offset: 0x1CDE050 VA: 0x181CDFA50 Slot: 6
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x1CDE900 Offset: 0x1CDCF00 VA: 0x181CDE900
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x1CDF8E0 Offset: 0x1CDDEE0 VA: 0x181CDF8E0
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x1CDF230 Offset: 0x1CDD830 VA: 0x181CDF230
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0x1CDF150 Offset: 0x1CDD750 VA: 0x181CDF150
	public void RemoveAll() { }

	// RVA: 0x1CDFBF0 Offset: 0x1CDE1F0 VA: 0x181CDFBF0 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1CDFC80 Offset: 0x1CDE280 VA: 0x181CDFC80 Slot: 14
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1CDE800 Offset: 0x1CDCE00 VA: 0x181CDE800 Slot: 9
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0x1CDED70 Offset: 0x1CDD370 VA: 0x181CDED70 Slot: 12
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x1CDF570 Offset: 0x1CDDB70 VA: 0x181CDF570 Slot: 11
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x1CDEAE0 Offset: 0x1CDD0E0 VA: 0x181CDEAE0
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0x1CDEE10 Offset: 0x1CDD410 VA: 0x181CDEE10
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x1CDF750 Offset: 0x1CDDD50 VA: 0x181CDF750
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x1CDF2F0 Offset: 0x1CDD8F0 VA: 0x181CDF2F0
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x1CDF050 Offset: 0x1CDD650 VA: 0x181CDF050
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x1CDF970 Offset: 0x1CDDF70 VA: 0x181CDF970
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x1CDEFA0 Offset: 0x1CDD5A0 VA: 0x181CDEFA0
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }
}

// Namespace: System.Xml
public class XmlCDataSection : XmlCharacterData // TypeDefIndex: 6696
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1CE1050 Offset: 0x1CDF650 VA: 0x181CE1050
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x1CE10A0 Offset: 0x1CDF6A0 VA: 0x181CE10A0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1CE10A0 Offset: 0x1CDF6A0 VA: 0x181CE10A0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1CE10D0 Offset: 0x1CDF6D0 VA: 0x181CE10D0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1CE0F90 Offset: 0x1CDF590 VA: 0x181CE0F90 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1CE1000 Offset: 0x1CDF600 VA: 0x181CE1000 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 55
	internal override bool get_IsText() { }
}

// Namespace: System.Xml
public abstract class XmlCharacterData : XmlLinkedNode // TypeDefIndex: 6697
{
	// Fields
	private string data; // 0x20

	// Properties
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public virtual string Data { get; set; }

	// Methods

	// RVA: 0x1CE1050 Offset: 0x1CDF650 VA: 0x181CE1050
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x1532550 Offset: 0x1530B50 VA: 0x181532550 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1CE12A0 Offset: 0x1CDF8A0 VA: 0x181CE12A0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x14542D0 Offset: 0x14528D0 VA: 0x1814542D0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x17A6340 Offset: 0x17A4940 VA: 0x1817A6340 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1CE11A0 Offset: 0x1CDF7A0 VA: 0x181CE11A0 Slot: 56
	public virtual string get_Data() { }

	// RVA: 0x1CE11C0 Offset: 0x1CDF7C0 VA: 0x181CE11C0 Slot: 57
	public virtual void set_Data(string value) { }

	// RVA: 0x1CE1170 Offset: 0x1CDF770 VA: 0x181CE1170
	internal bool CheckOnData(string data) { }
}

// Namespace: System.Xml
internal sealed class XmlChildEnumerator : IEnumerator // TypeDefIndex: 6698
{
	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal bool isFirst; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	internal XmlNode Current { get; }

	// Methods

	// RVA: 0x1CE1430 Offset: 0x1CDFA30 VA: 0x181CE1430
	internal void .ctor(XmlNode container) { }

	// RVA: 0x1CE12C0 Offset: 0x1CDF8C0 VA: 0x181CE12C0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1CE12C0 Offset: 0x1CDF8C0 VA: 0x181CE12C0
	internal bool MoveNext() { }

	// RVA: 0x1CE1350 Offset: 0x1CDF950 VA: 0x181CE1350 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1CE13A0 Offset: 0x1CDF9A0 VA: 0x181CE13A0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1CE13A0 Offset: 0x1CDF9A0 VA: 0x181CE13A0
	internal XmlNode get_Current() { }
}

// Namespace: System.Xml
internal class XmlChildNodes : XmlNodeList // TypeDefIndex: 6699
{
	// Fields
	private XmlNode container; // 0x10

	// Properties
	public override int Count { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(XmlNode container) { }

	// RVA: 0x1CE15A0 Offset: 0x1CDFBA0 VA: 0x181CE15A0 Slot: 6
	public override XmlNode Item(int i) { }

	// RVA: 0x1CE1610 Offset: 0x1CDFC10 VA: 0x181CE1610 Slot: 7
	public override int get_Count() { }

	// RVA: 0x1CE14A0 Offset: 0x1CDFAA0 VA: 0x181CE14A0 Slot: 8
	public override IEnumerator GetEnumerator() { }
}

// Namespace: System.Xml
public class XmlComment : XmlCharacterData // TypeDefIndex: 6700
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x1CE1050 Offset: 0x1CDF650 VA: 0x181CE1050
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0x1CE1730 Offset: 0x1CDFD30 VA: 0x181CE1730 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1CE1730 Offset: 0x1CDFD30 VA: 0x181CE1730 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x44F6B0 Offset: 0x44DCB0 VA: 0x18044F6B0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1CE1670 Offset: 0x1CDFC70 VA: 0x181CE1670 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1CE16E0 Offset: 0x1CDFCE0 VA: 0x181CE16E0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

// Namespace: System.Xml
public class XmlDeclaration : XmlLinkedNode // TypeDefIndex: 6701
{
	// Fields
	private string version; // 0x20
	private string encoding; // 0x28
	private string standalone; // 0x30

	// Properties
	public string Version { get; set; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x1CE18B0 Offset: 0x1CDFEB0 VA: 0x181CE18B0
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Version() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_Version(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Encoding() { }

	// RVA: 0x1CE1C90 Offset: 0x1CE0290 VA: 0x181CE1C90
	public void set_Encoding(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_Standalone() { }

	// RVA: 0x1CE1FC0 Offset: 0x1CE05C0 VA: 0x181CE1FC0
	public void set_Standalone(string value) { }

	// RVA: 0x1CE0C80 Offset: 0x1CDF280 VA: 0x181CE0C80 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1CE0F70 Offset: 0x1CDF570 VA: 0x181CE0F70 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1CE1B00 Offset: 0x1CE0100 VA: 0x181CE1B00 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x1CE1CD0 Offset: 0x1CE02D0 VA: 0x181CE1CD0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1CE1C60 Offset: 0x1CE0260 VA: 0x181CE1C60 Slot: 6
	public override string get_Name() { }

	// RVA: 0x53F9C0 Offset: 0x53DFC0 VA: 0x18053F9C0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x455580 Offset: 0x453B80 VA: 0x180455580 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1CE1760 Offset: 0x1CDFD60 VA: 0x181CE1760 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1CE1830 Offset: 0x1CDFE30 VA: 0x181CE1830 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1CE17C0 Offset: 0x1CDFDC0 VA: 0x181CE17C0
	private bool IsValidXmlVersion(string ver) { }
}

// Namespace: System.Xml
public class XmlDocument : XmlNode // TypeDefIndex: 6702
{
	// Fields
	private XmlImplementation implementation; // 0x18
	private DomNameTable domNameTable; // 0x20
	private XmlLinkedNode lastChild; // 0x28
	private XmlNamedNodeMap entities; // 0x30
	private Hashtable htElementIdMap; // 0x38
	private Hashtable htElementIDAttrDecl; // 0x40
	private SchemaInfo schemaInfo; // 0x48
	private XmlSchemaSet schemas; // 0x50
	private bool reportValidity; // 0x58
	private bool actualLoadingStatus; // 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
	internal bool fEntRefNodesPresent; // 0x90
	internal bool fCDataNodesPresent; // 0x91
	private bool preserveWhitespace; // 0x92
	private bool isLoading; // 0x93
	internal string strDocumentName; // 0x98
	internal string strDocumentFragmentName; // 0xA0
	internal string strCommentName; // 0xA8
	internal string strTextName; // 0xB0
	internal string strCDataSectionName; // 0xB8
	internal string strEntityName; // 0xC0
	internal string strID; // 0xC8
	internal string strXmlns; // 0xD0
	internal string strXml; // 0xD8
	internal string strSpace; // 0xE0
	internal string strLang; // 0xE8
	internal string strEmpty; // 0xF0
	internal string strNonSignificantWhitespaceName; // 0xF8
	internal string strSignificantWhitespaceName; // 0x100
	internal string strReservedXmlns; // 0x108
	internal string strReservedXml; // 0x110
	internal string baseURI; // 0x118
	private XmlResolver resolver; // 0x120
	internal bool bSetResolver; // 0x128
	internal object objLock; // 0x130
	internal static EmptyEnumerator EmptyEnumerator; // 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; // 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; // 0x18

	// Properties
	internal SchemaInfo DtdSchemaInfo { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public virtual XmlDocumentType DocumentType { get; }
	internal virtual XmlDeclaration Declaration { get; }
	public XmlImplementation Implementation { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public XmlElement DocumentElement { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlDocument OwnerDocument { get; }
	public XmlSchemaSet Schemas { set; }
	internal bool CanReportValidity { get; }
	internal bool HasSetResolver { get; }
	public virtual XmlResolver XmlResolver { set; }
	public XmlNameTable NameTable { get; }
	public override bool IsReadOnly { get; }
	internal XmlNamedNodeMap Entities { get; set; }
	internal bool IsLoading { get; set; }
	internal bool ActualLoadingStatus { get; }
	public override string InnerText { set; }
	public override string InnerXml { set; }
	internal string Version { get; }
	internal string Encoding { get; }
	internal string Standalone { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x1CE6CA0 Offset: 0x1CE52A0 VA: 0x181CE6CA0
	public void .ctor() { }

	// RVA: 0x1CE6D50 Offset: 0x1CE5350 VA: 0x181CE6D50
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x1CE6DD0 Offset: 0x1CE53D0 VA: 0x181CE6DD0
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x1CE3800 Offset: 0x1CE1E00 VA: 0x181CE3800
	internal static void CheckName(string name) { }

	// RVA: 0x1CE3180 Offset: 0x1CE1780 VA: 0x181CE3180
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1CE51A0 Offset: 0x1CE37A0 VA: 0x181CE51A0
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1CE2A40 Offset: 0x1CE1040 VA: 0x181CE2A40
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1CE30A0 Offset: 0x1CE16A0 VA: 0x181CE30A0
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x1CE4DB0 Offset: 0x1CE33B0 VA: 0x181CE4DB0
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x1CE4F90 Offset: 0x1CE3590 VA: 0x181CE4F90
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x1CE46F0 Offset: 0x1CE2CF0 VA: 0x181CE46F0
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x1CE2E90 Offset: 0x1CE1490 VA: 0x181CE2E90
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x1CE6450 Offset: 0x1CE4A50 VA: 0x181CE6450
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x1CE38D0 Offset: 0x1CE1ED0 VA: 0x181CE38D0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x458E50 Offset: 0x457450 VA: 0x180458E50 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1CE74A0 Offset: 0x1CE5AA0 VA: 0x181CE74A0 Slot: 56
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0x1CE7360 Offset: 0x1CE5960 VA: 0x181CE7360 Slot: 57
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public XmlImplementation get_Implementation() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910 Slot: 6
	public override string get_Name() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1CE7410 Offset: 0x1CE5A10 VA: 0x181CE7410
	public XmlElement get_DocumentElement() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	internal bool get_CanReportValidity() { }

	// RVA: 0x1CE75D0 Offset: 0x1CE5BD0 VA: 0x181CE75D0
	internal bool get_HasSetResolver() { }

	// RVA: 0x8DA910 Offset: 0x8D8F10 VA: 0x1808DA910
	internal XmlResolver GetResolver() { }

	// RVA: 0x1CE77C0 Offset: 0x1CE5DC0 VA: 0x181CE77C0 Slot: 58
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1CE5DC0 Offset: 0x1CE43C0 VA: 0x181CE5DC0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1CE5370 Offset: 0x1CE3970 VA: 0x181CE5370
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x1CE52F0 Offset: 0x1CE38F0 VA: 0x181CE52F0
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x1CE3630 Offset: 0x1CE1C30 VA: 0x181CE3630 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1CE34D0 Offset: 0x1CE1AD0 VA: 0x181CE34D0 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1CE3A50 Offset: 0x1CE2050 VA: 0x181CE3A50
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0x1CE6800 Offset: 0x1CE4E00 VA: 0x181CE6800
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0x1CE3BF0 Offset: 0x1CE21F0 VA: 0x181CE3BF0 Slot: 59
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x1CE3C80 Offset: 0x1CE2280 VA: 0x181CE3C80 Slot: 60
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0x1CE3E60 Offset: 0x1CE2460 VA: 0x181CE3E60 Slot: 61
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1CE3DA0 Offset: 0x1CE23A0 VA: 0x181CE3DA0 Slot: 62
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x1CE4080 Offset: 0x1CE2680 VA: 0x181CE4080
	public XmlElement CreateElement(string name) { }

	// RVA: 0x1CE2B80 Offset: 0x1CE1180 VA: 0x181CE2B80
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x1CE5080 Offset: 0x1CE3680 VA: 0x181CE5080
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x1CE6230 Offset: 0x1CE4830 VA: 0x181CE6230
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x1CE41E0 Offset: 0x1CE27E0 VA: 0x181CE41E0 Slot: 63
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x1CE4250 Offset: 0x1CE2850 VA: 0x181CE4250 Slot: 64
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x1CE4420 Offset: 0x1CE2A20 VA: 0x181CE4420 Slot: 65
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x1CE4340 Offset: 0x1CE2940 VA: 0x181CE4340 Slot: 66
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0x1CE42D0 Offset: 0x1CE28D0 VA: 0x181CE42D0 Slot: 67
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x1CE43B0 Offset: 0x1CE29B0 VA: 0x181CE43B0 Slot: 68
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x1CE3B60 Offset: 0x1CE2160 VA: 0x181CE3B60
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0x1CE3FF0 Offset: 0x1CE25F0 VA: 0x181CE3FF0
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0x1CE5690 Offset: 0x1CE3C90 VA: 0x181CE5690
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x1CE5460 Offset: 0x1CE3A60 VA: 0x181CE5460
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x1CE55D0 Offset: 0x1CE3BD0 VA: 0x181CE55D0
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x168F7D0 Offset: 0x168DDD0 VA: 0x18168F7D0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1CE39B0 Offset: 0x1CE1FB0 VA: 0x181CE39B0 Slot: 69
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1CE3D10 Offset: 0x1CE2310 VA: 0x181CE3D10 Slot: 70
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1CE4110 Offset: 0x1CE2710 VA: 0x181CE4110 Slot: 71
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x1CE7560 Offset: 0x1CE5B60 VA: 0x181CE7560
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x1AAA360 Offset: 0x1AA8960 VA: 0x181AAA360
	internal bool get_IsLoading() { }

	// RVA: 0x1CDC830 Offset: 0x1CDAE30 VA: 0x181CDC830
	internal void set_IsLoading(bool value) { }

	// RVA: 0x140E320 Offset: 0x140C920 VA: 0x18140E320
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0x1CE6380 Offset: 0x1CE4980 VA: 0x181CE6380 Slot: 72
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0x1CE68B0 Offset: 0x1CE4EB0 VA: 0x181CE68B0
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x1CE6100 Offset: 0x1CE4700 VA: 0x181CE6100 Slot: 73
	public virtual void Load(XmlReader reader) { }

	// RVA: 0x1CE5F90 Offset: 0x1CE4590 VA: 0x181CE5F90 Slot: 74
	public virtual void LoadXml(string xml) { }

	// RVA: 0x1CE7760 Offset: 0x1CE5D60 VA: 0x181CE7760 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x15E7540 Offset: 0x15E5B40 VA: 0x1815E7540 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x1CE65B0 Offset: 0x1CE4BB0 VA: 0x181CE65B0 Slot: 75
	public virtual void Save(XmlWriter w) { }

	// RVA: 0x178ACF0 Offset: 0x17892F0 VA: 0x18178ACF0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1CE6910 Offset: 0x1CE4F10 VA: 0x181CE6910 Slot: 44
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0x1CE4CB0 Offset: 0x1CE32B0 VA: 0x181CE4CB0 Slot: 50
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1CE4FB0 Offset: 0x1CE35B0 VA: 0x181CE4FB0
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x1CE3470 Offset: 0x1CE1A70 VA: 0x181CE3470 Slot: 51
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1CE31B0 Offset: 0x1CE17B0 VA: 0x181CE31B0 Slot: 52
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1CE44B0 Offset: 0x1CE2AB0 VA: 0x181CE44B0
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x1CE7730 Offset: 0x1CE5D30 VA: 0x181CE7730
	internal string get_Version() { }

	// RVA: 0x1CE7530 Offset: 0x1CE5B30 VA: 0x181CE7530
	internal string get_Encoding() { }

	// RVA: 0x1CE7700 Offset: 0x1CE5D00 VA: 0x181CE7700
	internal string get_Standalone() { }

	// RVA: 0x1CE4BC0 Offset: 0x1CE31C0 VA: 0x181CE4BC0
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0x1CE75E0 Offset: 0x1CE5BE0 VA: 0x181CE75E0 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1634AF0 Offset: 0x16330F0 VA: 0x181634AF0 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x16410B0 Offset: 0x163F6B0 VA: 0x1816410B0
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0x1CE3210 Offset: 0x1CE1810 VA: 0x181CE3210 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1CE6B40 Offset: 0x1CE5140 VA: 0x181CE6B40
	private static void .cctor() { }
}

// Namespace: System.Xml
public class XmlDocumentFragment : XmlNode // TypeDefIndex: 6703
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string InnerXml { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }

	// Methods

	// RVA: 0x1CE2580 Offset: 0x1CE0B80 VA: 0x181CE2580
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x1CE2610 Offset: 0x1CE0C10 VA: 0x181CE2610 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1CE2610 Offset: 0x1CE0C10 VA: 0x181CE2610 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x455BB0 Offset: 0x4541B0 VA: 0x180455BB0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1CE2640 Offset: 0x1CE0C40 VA: 0x181CE2640 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1CE26B0 Offset: 0x1CE0CB0 VA: 0x181CE26B0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x1CE2200 Offset: 0x1CE0800 VA: 0x181CE2200 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1CE22A0 Offset: 0x1CE08A0 VA: 0x181CE22A0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1CE2100 Offset: 0x1CE0700 VA: 0x181CE2100 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1CE2180 Offset: 0x1CE0780 VA: 0x181CE2180 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x178ACF0 Offset: 0x17892F0 VA: 0x18178ACF0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1CE2350 Offset: 0x1CE0950 VA: 0x181CE2350 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

// Namespace: System.Xml
public class XmlDocumentType : XmlLinkedNode // TypeDefIndex: 6704
{
	// Fields
	private string name; // 0x20
	private string publicId; // 0x28
	private string systemId; // 0x30
	private string internalSubset; // 0x38
	private bool namespaces; // 0x40
	private XmlNamedNodeMap entities; // 0x48
	private XmlNamedNodeMap notations; // 0x50
	private SchemaInfo schemaInfo; // 0x58

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public XmlNamedNodeMap Entities { get; }
	public XmlNamedNodeMap Notations { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string InternalSubset { get; }
	internal bool ParseWithNamespaces { get; }
	internal SchemaInfo DtdSchemaInfo { get; set; }

	// Methods

	// RVA: 0x1CE2800 Offset: 0x1CE0E00 VA: 0x181CE2800
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1CE2750 Offset: 0x1CE0D50 VA: 0x181CE2750 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x1CE2960 Offset: 0x1CE0F60 VA: 0x181CE2960
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x1CE29D0 Offset: 0x1CE0FD0 VA: 0x181CE29D0
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_PublicId() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_SystemId() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_InternalSubset() { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x1CE27B0 Offset: 0x1CE0DB0 VA: 0x181CE27B0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	internal void set_DtdSchemaInfo(SchemaInfo value) { }
}

// Namespace: System.Xml
public class XmlElement : XmlLinkedNode // TypeDefIndex: 6705
{
	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Properties
	internal XmlName XmlName { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	internal override bool IsContainer { get; }
	public bool IsEmpty { get; set; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlAttributeCollection Attributes { get; }
	public virtual bool HasAttributes { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerXml { set; }
	public override string InnerText { get; set; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x1CE8F50 Offset: 0x1CE7550 VA: 0x181CE8F50
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x1CE8EE0 Offset: 0x1CE74E0 VA: 0x181CE8EE0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal XmlName get_XmlName() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x1CE7AE0 Offset: 0x1CE60E0 VA: 0x181CE7AE0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1CE9260 Offset: 0x1CE7860 VA: 0x181CE9260 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1CE9240 Offset: 0x1CE7840 VA: 0x181CE9240 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x19AA690 Offset: 0x19A8C90 VA: 0x1819AA690 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0x1CE92E0 Offset: 0x1CE78E0 VA: 0x181CE92E0 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0x1CE94D0 Offset: 0x1CE7AD0 VA: 0x181CE94D0 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1CE92C0 Offset: 0x1CE78C0 VA: 0x181CE92C0 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1CE7910 Offset: 0x1CE5F10 VA: 0x181CE7910 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1CE9220 Offset: 0x1CE7820 VA: 0x181CE9220
	public bool get_IsEmpty() { }

	// RVA: 0x1CE9470 Offset: 0x1CE7A70 VA: 0x181CE9470
	public void set_IsEmpty(bool value) { }

	// RVA: 0x1CE9230 Offset: 0x1CE7830 VA: 0x181CE9230 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1CE83E0 Offset: 0x1CE69E0 VA: 0x181CE83E0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1CE90B0 Offset: 0x1CE76B0 VA: 0x181CE90B0 Slot: 14
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x1CE91D0 Offset: 0x1CE77D0 VA: 0x181CE91D0 Slot: 56
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1CE8310 Offset: 0x1CE6910 VA: 0x181CE8310 Slot: 57
	public virtual string GetAttribute(string name) { }

	// RVA: 0x1CE87A0 Offset: 0x1CE6DA0 VA: 0x181CE87A0 Slot: 58
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x1CE7FE0 Offset: 0x1CE65E0 VA: 0x181CE7FE0 Slot: 59
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x1CE8660 Offset: 0x1CE6C60 VA: 0x181CE8660 Slot: 60
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x1CE8360 Offset: 0x1CE6960 VA: 0x181CE8360 Slot: 61
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1CE8970 Offset: 0x1CE6F70 VA: 0x181CE8970 Slot: 62
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x1CE8160 Offset: 0x1CE6760 VA: 0x181CE8160 Slot: 63
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x1CE8590 Offset: 0x1CE6B90 VA: 0x181CE8590 Slot: 64
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x1CE83B0 Offset: 0x1CE69B0 VA: 0x181CE83B0 Slot: 65
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x1CE8DE0 Offset: 0x1CE73E0 VA: 0x181CE8DE0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1CE8A80 Offset: 0x1CE7080 VA: 0x181CE8A80
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x1CE8CA0 Offset: 0x1CE72A0 VA: 0x181CE8CA0
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0x1CE0880 Offset: 0x1CDEE80 VA: 0x181CE0880 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1CE8440 Offset: 0x1CE6A40 VA: 0x181CE8440 Slot: 66
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x1CE8560 Offset: 0x1CE6B60 VA: 0x181CE8560 Slot: 45
	public override void RemoveAll() { }

	// RVA: 0x1CE8550 Offset: 0x1CE6B50 VA: 0x181CE8550
	internal void RemoveAllChildren() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1CE93F0 Offset: 0x1CE79F0 VA: 0x181CE93F0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x1CE9210 Offset: 0x1CE7810 VA: 0x181CE9210 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x1CE9300 Offset: 0x1CE7900 VA: 0x181CE9300 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1CE9280 Offset: 0x1CE7880 VA: 0x181CE9280 Slot: 13
	public override XmlNode get_NextSibling() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 47
	internal override void SetParent(XmlNode node) { }
}

// Namespace: System.Xml
public class XmlEntity : XmlNode // TypeDefIndex: 6706
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string notationName; // 0x28
	private string name; // 0x30
	private string unparsedReplacementStr; // 0x38
	private string baseURI; // 0x40
	private XmlLinkedNode lastChild; // 0x48
	private bool childrenFoliating; // 0x50

	// Properties
	public override bool IsReadOnly { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string InnerText { get; set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlNodeType NodeType { get; }
	public string SystemId { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x1CE9E40 Offset: 0x1CE8440 VA: 0x181CE9E40
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x1CE9DC0 Offset: 0x1CE83C0 VA: 0x181CE9DC0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1CE9210 Offset: 0x1CE7810 VA: 0x181CE9210 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x1CEA030 Offset: 0x1CE8630 VA: 0x181CEA030 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1CE9F30 Offset: 0x1CE8530 VA: 0x181CE9F30 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1CE9E20 Offset: 0x1CE8420 VA: 0x181CE9E20 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x45C3F0 Offset: 0x45A9F0 VA: 0x18045C3F0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_SystemId() { }

	// RVA: 0x1CEA090 Offset: 0x1CE8690 VA: 0x181CEA090 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void SetBaseURI(string inBaseURI) { }
}

// Namespace: System.Xml
public class XmlEntityReference : XmlLinkedNode // TypeDefIndex: 6707
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override string BaseURI { get; }
	internal string ChildBaseURI { get; }

	// Methods

	// RVA: 0x1CE99E0 Offset: 0x1CE7FE0 VA: 0x181CE99E0
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1CE9D60 Offset: 0x1CE8360 VA: 0x181CE9D60 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1CE95B0 Offset: 0x1CE7BB0 VA: 0x181CE95B0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1CE96C0 Offset: 0x1CE7CC0 VA: 0x181CE96C0 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x178AD30 Offset: 0x1789330 VA: 0x18178AD30 Slot: 48
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1CE83E0 Offset: 0x1CE69E0 VA: 0x181CE83E0 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1CE99B0 Offset: 0x1CE7FB0 VA: 0x181CE99B0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1CE9780 Offset: 0x1CE7D80 VA: 0x181CE9780 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1CE9AF0 Offset: 0x1CE80F0 VA: 0x181CE9AF0 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x1CE9600 Offset: 0x1CE7C00 VA: 0x181CE9600
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x1CE9B30 Offset: 0x1CE8130 VA: 0x181CE9B30
	internal string get_ChildBaseURI() { }
}

// Namespace: System.Xml
public enum XmlNodeChangedAction // TypeDefIndex: 6708
{
	// Fields
	public int value__; // 0x0
	public const XmlNodeChangedAction Insert = 0;
	public const XmlNodeChangedAction Remove = 1;
	public const XmlNodeChangedAction Change = 2;
}

// Namespace: System.Xml
public class XmlImplementation // TypeDefIndex: 6709
{
	// Fields
	private XmlNameTable nameTable; // 0x10

	// Properties
	internal XmlNameTable NameTable { get; }

	// Methods

	// RVA: 0x1CEA150 Offset: 0x1CE8750 VA: 0x181CEA150
	public void .ctor() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x1CEA0F0 Offset: 0x1CE86F0 VA: 0x181CEA0F0 Slot: 4
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal XmlNameTable get_NameTable() { }
}

// Namespace: System.Xml
public abstract class XmlLinkedNode : XmlNode // TypeDefIndex: 6710
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Properties
	public override XmlNode PreviousSibling { get; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x1CEA1C0 Offset: 0x1CE87C0 VA: 0x181CEA1C0
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x1CEA250 Offset: 0x1CE8850 VA: 0x181CEA250 Slot: 12
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x1CEA1F0 Offset: 0x1CE87F0 VA: 0x181CEA1F0 Slot: 13
	public override XmlNode get_NextSibling() { }
}

// Namespace: System.Xml
internal class XmlLoader // TypeDefIndex: 6711
{
	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private bool preserveWhitespace; // 0x20

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1CEE270 Offset: 0x1CEC870 VA: 0x181CEE270
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x1CEC150 Offset: 0x1CEA750 VA: 0x181CEC150
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x1CEED70 Offset: 0x1CED370 VA: 0x181CEED70
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x1CEDB30 Offset: 0x1CEC130 VA: 0x181CEDB30
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x1CEB6B0 Offset: 0x1CE9CB0 VA: 0x181CEB6B0
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x1CEBF50 Offset: 0x1CEA550 VA: 0x181CEBF50
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x1CEBA40 Offset: 0x1CEA040 VA: 0x181CEBA40
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x1CED130 Offset: 0x1CEB730 VA: 0x181CED130
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x1CEBD60 Offset: 0x1CEA360 VA: 0x181CEBD60
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x1CEC1D0 Offset: 0x1CEA7D0 VA: 0x181CEC1D0
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x1CED530 Offset: 0x1CEBB30 VA: 0x181CED530
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x1CEB4E0 Offset: 0x1CE9AE0 VA: 0x181CEB4E0
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x1CEE7F0 Offset: 0x1CECDF0 VA: 0x181CEE7F0
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x1CEE540 Offset: 0x1CECB40 VA: 0x181CEE540
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x1CEC420 Offset: 0x1CEAA20 VA: 0x181CEC420
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x1CEABF0 Offset: 0x1CE91F0 VA: 0x181CEABF0
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x1CEE870 Offset: 0x1CECE70 VA: 0x181CEE870
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x1CED3A0 Offset: 0x1CEB9A0 VA: 0x181CED3A0
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x1CED380 Offset: 0x1CEB980 VA: 0x181CED380
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x1CEEF30 Offset: 0x1CED530 VA: 0x181CEEF30
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x1CEA540 Offset: 0x1CE8B40 VA: 0x181CEA540
	private string EntitizeName(string name) { }

	// RVA: 0x1CEAB40 Offset: 0x1CE9140 VA: 0x181CEAB40
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x1CEA590 Offset: 0x1CE8B90 VA: 0x181CEA590
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x1CEA2E0 Offset: 0x1CE88E0 VA: 0x181CEA2E0
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x1CEEAE0 Offset: 0x1CED0E0 VA: 0x181CEEAE0
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x1CEF270 Offset: 0x1CED870 VA: 0x181CEF270
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }
}

// Namespace: System.Xml
internal class XmlName : IXmlSchemaInfo // TypeDefIndex: 6712
{
	// Fields
	private string prefix; // 0x10
	private string localName; // 0x18
	private string ns; // 0x20
	private string name; // 0x28
	private int hashCode; // 0x30
	internal XmlDocument ownerDoc; // 0x38
	internal XmlName next; // 0x40

	// Properties
	public string LocalName { get; }
	public string NamespaceURI { get; }
	public string Prefix { get; }
	public int HashCode { get; }
	public XmlDocument OwnerDocument { get; }
	public string Name { get; }
	public virtual XmlSchemaValidity Validity { get; }
	public virtual bool IsDefault { get; }
	public virtual bool IsNil { get; }
	public virtual XmlSchemaSimpleType MemberType { get; }
	public virtual XmlSchemaType SchemaType { get; }
	public virtual XmlSchemaElement SchemaElement { get; }
	public virtual XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x1D05B40 Offset: 0x1D04140 VA: 0x181D05B40
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1D05CC0 Offset: 0x1D042C0 VA: 0x181D05CC0
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_LocalName() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_NamespaceURI() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Prefix() { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public int get_HashCode() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x1D05D70 Offset: 0x1D04370 VA: 0x181D05D70
	public string get_Name() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 11
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 12
	public virtual bool get_IsDefault() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 13
	public virtual bool get_IsNil() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 14
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 15
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 16
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 17
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x86A130 Offset: 0x868730 VA: 0x18086A130 Slot: 18
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1D05C50 Offset: 0x1D04250 VA: 0x181D05C50
	public static int GetHashCode(string name) { }
}

// Namespace: System.Xml
internal sealed class XmlNameEx : XmlName // TypeDefIndex: 6713
{
	// Fields
	private byte flags; // 0x48
	private XmlSchemaSimpleType memberType; // 0x50
	private XmlSchemaType schemaType; // 0x58
	private object decl; // 0x60

	// Properties
	public override XmlSchemaValidity Validity { get; }
	public override bool IsDefault { get; }
	public override bool IsNil { get; }
	public override XmlSchemaSimpleType MemberType { get; }
	public override XmlSchemaType SchemaType { get; }
	public override XmlSchemaElement SchemaElement { get; }
	public override XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x1D05820 Offset: 0x1D03E20 VA: 0x181D05820
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1D05B10 Offset: 0x1D04110 VA: 0x181D05B10 Slot: 11
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x1D059D0 Offset: 0x1D03FD0 VA: 0x181D059D0 Slot: 12
	public override bool get_IsDefault() { }

	// RVA: 0x1D059E0 Offset: 0x1D03FE0 VA: 0x181D059E0 Slot: 13
	public override bool get_IsNil() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 14
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 15
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x1D05A80 Offset: 0x1D04080 VA: 0x181D05A80 Slot: 16
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1D059F0 Offset: 0x1D03FF0 VA: 0x181D059F0 Slot: 17
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1D05810 Offset: 0x1D03E10 VA: 0x181D05810
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x1D057B0 Offset: 0x1D03DB0 VA: 0x181D057B0
	public void SetIsDefault(bool value) { }

	// RVA: 0x1D057E0 Offset: 0x1D03DE0 VA: 0x181D057E0
	public void SetIsNil(bool value) { }

	// RVA: 0x1D055B0 Offset: 0x1D03BB0 VA: 0x181D055B0 Slot: 18
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }
}

// Namespace: System.Xml
public class XmlNamedNodeMap : IEnumerable // TypeDefIndex: 6716
{
	// Fields
	internal XmlNode parent; // 0x10
	internal XmlNamedNodeMap.SmallXmlNodeList nodes; // 0x18

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x1D063D0 Offset: 0x1D049D0 VA: 0x181D063D0 Slot: 5
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x1D068E0 Offset: 0x1D04EE0 VA: 0x181D068E0 Slot: 6
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x1D06AD0 Offset: 0x1D050D0 VA: 0x181D06AD0 Slot: 7
	public virtual int get_Count() { }

	// RVA: 0x1D063C0 Offset: 0x1D049C0 VA: 0x181D063C0 Slot: 8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1D06170 Offset: 0x1D04770 VA: 0x181D06170
	internal int FindNodeOffset(string name) { }

	// RVA: 0x1D06270 Offset: 0x1D04870 VA: 0x181D06270
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x1D05FD0 Offset: 0x1D045D0 VA: 0x181D05FD0 Slot: 9
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x1D05F10 Offset: 0x1D04510 VA: 0x181D05F10 Slot: 10
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x1D06700 Offset: 0x1D04D00 VA: 0x181D06700 Slot: 11
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x1D06870 Offset: 0x1D04E70 VA: 0x181D06870
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x1D06550 Offset: 0x1D04B50 VA: 0x181D06550 Slot: 12
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }
}

// Namespace: System.Xml
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
public abstract class XmlNode : ICloneable, IEnumerable // TypeDefIndex: 6717
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Properties
	public abstract string Name { get; }
	public virtual string Value { get; set; }
	public abstract XmlNodeType NodeType { get; }
	public virtual XmlNode ParentNode { get; }
	public virtual XmlNodeList ChildNodes { get; }
	public virtual XmlNode PreviousSibling { get; }
	public virtual XmlNode NextSibling { get; }
	public virtual XmlAttributeCollection Attributes { get; }
	public virtual XmlDocument OwnerDocument { get; }
	public virtual XmlNode FirstChild { get; }
	public virtual XmlNode LastChild { get; }
	internal virtual bool IsContainer { get; }
	internal virtual XmlLinkedNode LastNode { get; set; }
	public virtual bool HasChildNodes { get; }
	public virtual string NamespaceURI { get; }
	public virtual string Prefix { get; set; }
	public abstract string LocalName { get; }
	public virtual bool IsReadOnly { get; }
	public virtual string InnerText { get; set; }
	public virtual string InnerXml { set; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual string BaseURI { get; }
	internal XmlDocument Document { get; }
	internal virtual XmlSpace XmlSpace { get; }
	internal virtual string XmlLang { get; }
	internal virtual bool IsText { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1D0EAD0 Offset: 0x1D0D0D0 VA: 0x181D0EAD0
	internal void .ctor(XmlDocument doc) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Name();

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x1D0F5C0 Offset: 0x1D0DBC0 VA: 0x181D0F5C0 Slot: 8
	public virtual void set_Value(string value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x1D0F0B0 Offset: 0x1D0D6B0 VA: 0x181D0F0B0 Slot: 10
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x1D0EC70 Offset: 0x1D0D270 VA: 0x181D0EC70 Slot: 11
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 12
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 13
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 14
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x1D0EFF0 Offset: 0x1D0D5F0 VA: 0x181D0EFF0 Slot: 15
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x1D0ED70 Offset: 0x1D0D370 VA: 0x181D0ED70 Slot: 16
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x1D0EFD0 Offset: 0x1D0D5D0 VA: 0x181D0EFD0 Slot: 17
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 18
	internal virtual bool get_IsContainer() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 19
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1D0C170 Offset: 0x1D0A770 VA: 0x181D0C170
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x1D0DB60 Offset: 0x1D0C160 VA: 0x181D0DB60 Slot: 21
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1D0D3D0 Offset: 0x1D0B9D0 VA: 0x181D0D3D0 Slot: 22
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1D0E420 Offset: 0x1D0CA20 VA: 0x181D0E420 Slot: 23
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1D0E350 Offset: 0x1D0C950 VA: 0x181D0E350 Slot: 24
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x1D0C510 Offset: 0x1D0AB10 VA: 0x181D0C510 Slot: 25
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1D0C1F0 Offset: 0x1D0A7F0 VA: 0x181D0C1F0 Slot: 26
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 27
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 28
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 29
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1D0EDA0 Offset: 0x1D0D3A0 VA: 0x181D0EDA0 Slot: 30
	public virtual bool get_HasChildNodes() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract XmlNode CloneNode(bool deep);

	// RVA: 0x1D0CBA0 Offset: 0x1D0B1A0 VA: 0x181D0CBA0 Slot: 32
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x37A870 Offset: 0x378E70 VA: 0x18037A870 Slot: 33
	public virtual string get_NamespaceURI() { }

	// RVA: 0x37A870 Offset: 0x378E70 VA: 0x18037A870 Slot: 34
	public virtual string get_Prefix() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 35
	public virtual void set_Prefix(string value) { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract string get_LocalName();

	// RVA: 0x1D0EEF0 Offset: 0x1D0D4F0 VA: 0x181D0EEF0 Slot: 37
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1D0D300 Offset: 0x1D0B900 VA: 0x181D0D300
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x1D0EA60 Offset: 0x1D0D060 VA: 0x181D0EA60 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1D0EA00 Offset: 0x1D0D000 VA: 0x181D0EA00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D0CCF0 Offset: 0x1D0B2F0 VA: 0x181D0CCF0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1D0C3E0 Offset: 0x1D0A9E0 VA: 0x181D0C3E0
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x1D0EDD0 Offset: 0x1D0D3D0 VA: 0x181D0EDD0 Slot: 38
	public virtual string get_InnerText() { }

	// RVA: 0x1D0F450 Offset: 0x1D0DA50 VA: 0x181D0F450 Slot: 39
	public virtual void set_InnerText(string value) { }

	// RVA: 0x1D0F560 Offset: 0x1D0DB60 VA: 0x181D0F560 Slot: 40
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x1D0F190 Offset: 0x1D0D790 VA: 0x181D0F190 Slot: 41
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1D0EB60 Offset: 0x1D0D160 VA: 0x181D0EB60 Slot: 42
	public virtual string get_BaseURI() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void WriteTo(XmlWriter w);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract void WriteContentTo(XmlWriter w);

	// RVA: 0x1D0E3A0 Offset: 0x1D0C9A0 VA: 0x181D0E3A0 Slot: 45
	public virtual void RemoveAll() { }

	// RVA: 0x1D0ECD0 Offset: 0x1D0D2D0 VA: 0x181D0ECD0
	internal XmlDocument get_Document() { }

	// RVA: 0x1D0D2D0 Offset: 0x1D0B8D0 VA: 0x181D0D2D0 Slot: 46
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x1D0CE90 Offset: 0x1D0B490 VA: 0x181D0CE90
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x1D0E8F0 Offset: 0x1D0CEF0 VA: 0x181D0E8F0 Slot: 47
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 48
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x1D0E930 Offset: 0x1D0CF30 VA: 0x181D0E930
	internal static void SplitName(string name, out string prefix, out string localName) { }

	// RVA: 0x1D0CC60 Offset: 0x1D0B260 VA: 0x181D0CC60 Slot: 49
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x1D0CD50 Offset: 0x1D0B350 VA: 0x181D0CD50 Slot: 50
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1D0CB50 Offset: 0x1D0B150 VA: 0x181D0CB50 Slot: 51
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1D0C120 Offset: 0x1D0A720 VA: 0x181D0C120 Slot: 52
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1D0F2D0 Offset: 0x1D0D8D0 VA: 0x181D0F2D0 Slot: 53
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x1D0F1E0 Offset: 0x1D0D7E0 VA: 0x181D0F1E0 Slot: 54
	internal virtual string get_XmlLang() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 55
	internal virtual bool get_IsText() { }

	// RVA: 0x1D0E320 Offset: 0x1D0C920 VA: 0x181D0E320
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x1D0EA80 Offset: 0x1D0D080 VA: 0x181D0EA80
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }
}

// Namespace: System.Xml
public class XmlNodeChangedEventArgs : EventArgs // TypeDefIndex: 6718
{
	// Fields
	private XmlNodeChangedAction action; // 0x10
	private XmlNode node; // 0x18
	private XmlNode oldParent; // 0x20
	private XmlNode newParent; // 0x28
	private string oldValue; // 0x30
	private string newValue; // 0x38

	// Properties
	public XmlNodeChangedAction Action { get; }

	// Methods

	// RVA: 0x1D06AE0 Offset: 0x1D050E0 VA: 0x181D06AE0
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public XmlNodeChangedAction get_Action() { }
}

// Namespace: System.Xml
public sealed class XmlNodeChangedEventHandler : MulticastDelegate // TypeDefIndex: 6719
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, XmlNodeChangedEventArgs e) { }
}

// Namespace: System.Xml
[DefaultMember("ItemOf")]
public abstract class XmlNodeList : IEnumerable, IDisposable // TypeDefIndex: 6720
{
	// Properties
	public abstract int Count { get; }
	public virtual XmlNode ItemOf { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNode Item(int index);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IEnumerator GetEnumerator();

	// RVA: 0x155E990 Offset: 0x155CF90 VA: 0x18155E990 Slot: 9
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0x49CF60 Offset: 0x49B560 VA: 0x18049CF60 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml
internal class XmlNodeReaderNavigator // TypeDefIndex: 6722
{
	// Fields
	private XmlNode curNode; // 0x10
	private XmlNode elemNode; // 0x18
	private XmlNode logNode; // 0x20
	private int attrIndex; // 0x28
	private int logAttrIndex; // 0x2C
	private XmlNameTable nameTable; // 0x30
	private XmlDocument doc; // 0x38
	private int nAttrInd; // 0x40
	private int nDeclarationAttrCount; // 0x44
	private int nDocTypeAttrCount; // 0x48
	private int nLogLevel; // 0x4C
	private int nLogAttrInd; // 0x50
	private bool bLogOnAttrVal; // 0x54
	private bool bCreatedOnAttribute; // 0x55
	internal XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes; // 0x58
	internal XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes; // 0x60
	private bool bOnAttrVal; // 0x68

	// Properties
	public XmlNodeType NodeType { get; }
	public string NamespaceURI { get; }
	public string Name { get; }
	public string LocalName { get; }
	internal bool CreatedOnAttribute { get; }
	public string Prefix { get; }
	public bool HasValue { get; }
	public string Value { get; }
	public string BaseURI { get; }
	public XmlSpace XmlSpace { get; }
	public string XmlLang { get; }
	public bool IsEmptyElement { get; }
	public bool IsDefault { get; }
	public IXmlSchemaInfo SchemaInfo { get; }
	public XmlNameTable NameTable { get; }
	public int AttributeCount { get; }
	private bool IsOnDeclOrDocType { get; }
	public XmlDocument Document { get; }

	// Methods

	// RVA: 0x1D09A40 Offset: 0x1D08040 VA: 0x181D09A40
	public void .ctor(XmlNode node) { }

	// RVA: 0x1D0A310 Offset: 0x1D08910 VA: 0x181D0A310
	public XmlNodeType get_NodeType() { }

	// RVA: 0x1699DA0 Offset: 0x16983A0 VA: 0x181699DA0
	public string get_NamespaceURI() { }

	// RVA: 0x1D0A1F0 Offset: 0x1D087F0 VA: 0x181D0A1F0
	public string get_Name() { }

	// RVA: 0x1D0A130 Offset: 0x1D08730 VA: 0x181D0A130
	public string get_LocalName() { }

	// RVA: 0x1D09F20 Offset: 0x1D08520 VA: 0x181D09F20
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0x1D082E0 Offset: 0x1D068E0 VA: 0x181D082E0
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0x1B316B0 Offset: 0x1B2FCB0 VA: 0x181B316B0
	public string get_Prefix() { }

	// RVA: 0x1D09F30 Offset: 0x1D08530 VA: 0x181D09F30
	public bool get_HasValue() { }

	// RVA: 0x1D0A360 Offset: 0x1D08960 VA: 0x181D0A360
	public string get_Value() { }

	// RVA: 0x1B31650 Offset: 0x1B2FC50 VA: 0x181B31650
	public string get_BaseURI() { }

	// RVA: 0x1D0A620 Offset: 0x1D08C20 VA: 0x181D0A620
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x1D0A5F0 Offset: 0x1D08BF0 VA: 0x181D0A5F0
	public string get_XmlLang() { }

	// RVA: 0x1D0A050 Offset: 0x1D08650 VA: 0x181D0A050
	public bool get_IsEmptyElement() { }

	// RVA: 0x1D09FA0 Offset: 0x1D085A0 VA: 0x181D09FA0
	public bool get_IsDefault() { }

	// RVA: 0x1A1EC90 Offset: 0x1A1D290 VA: 0x181A1EC90
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1D09DD0 Offset: 0x1D083D0 VA: 0x181D09DD0
	public int get_AttributeCount() { }

	// RVA: 0x1D06BB0 Offset: 0x1D051B0 VA: 0x181D06BB0
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0x1D07F20 Offset: 0x1D06520 VA: 0x181D07F20
	private void InitDecAttr() { }

	// RVA: 0x1D07780 Offset: 0x1D05D80 VA: 0x181D07780
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0x1D07730 Offset: 0x1D05D30 VA: 0x181D07730
	public string GetDeclarationAttr(int i) { }

	// RVA: 0x1D07690 Offset: 0x1D05C90 VA: 0x181D07690
	public int GetDecAttrInd(string name) { }

	// RVA: 0x1D08160 Offset: 0x1D06760 VA: 0x181D08160
	private void InitDocTypeAttr() { }

	// RVA: 0x1D07950 Offset: 0x1D05F50 VA: 0x181D07950
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0x1D07900 Offset: 0x1D05F00 VA: 0x181D07900
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0x1D07860 Offset: 0x1D05E60 VA: 0x181D07860
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0x1D06DE0 Offset: 0x1D053E0 VA: 0x181D06DE0
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0x1D06E40 Offset: 0x1D05440 VA: 0x181D06E40
	public string GetAttribute(string name) { }

	// RVA: 0x1D06D80 Offset: 0x1D05380 VA: 0x181D06D80
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x1D07120 Offset: 0x1D05720 VA: 0x181D07120
	public string GetAttribute(string name, string ns) { }

	// RVA: 0x1D07430 Offset: 0x1D05A30 VA: 0x181D07430
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0x1D08330 Offset: 0x1D06930 VA: 0x181D08330
	public void LogMove(int level) { }

	// RVA: 0x1D099F0 Offset: 0x1D07FF0 VA: 0x181D099F0
	public void RollBackMove(ref int level) { }

	// RVA: 0x1D0A0F0 Offset: 0x1D086F0 VA: 0x181D0A0F0
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0x1D09910 Offset: 0x1D07F10 VA: 0x181D09910
	public void ResetToAttribute(ref int level) { }

	// RVA: 0x1D09670 Offset: 0x1D07C70 VA: 0x181D09670
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	// RVA: 0x1D08FD0 Offset: 0x1D075D0 VA: 0x181D08FD0
	public bool MoveToAttribute(string name) { }

	// RVA: 0x1D08AA0 Offset: 0x1D070A0 VA: 0x181D08AA0
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x1D08D80 Offset: 0x1D07380 VA: 0x181D08D80
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0x1D08B90 Offset: 0x1D07190 VA: 0x181D08B90
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x1D090E0 Offset: 0x1D076E0 VA: 0x181D090E0
	public bool MoveToNextAttribute(ref int level) { }

	// RVA: 0x1D093D0 Offset: 0x1D079D0 VA: 0x181D093D0
	public bool MoveToParent() { }

	// RVA: 0x1D09080 Offset: 0x1D07680 VA: 0x181D09080
	public bool MoveToFirstChild() { }

	// RVA: 0x1D092E0 Offset: 0x1D078E0 VA: 0x181D092E0
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0x1D09340 Offset: 0x1D07940 VA: 0x181D09340
	public bool MoveToNext() { }

	// RVA: 0x1D08FF0 Offset: 0x1D075F0 VA: 0x181D08FF0
	public bool MoveToElement() { }

	// RVA: 0x1D08380 Offset: 0x1D06980 VA: 0x181D08380
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1D06C20 Offset: 0x1D05220 VA: 0x181D06C20
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0x1D08680 Offset: 0x1D06C80 VA: 0x181D08680
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1D079F0 Offset: 0x1D05FF0 VA: 0x181D079F0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1D09430 Offset: 0x1D07A30 VA: 0x181D09430
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public XmlDocument get_Document() { }
}

// Namespace: System.Xml
public class XmlNodeReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 6723
{
	// Fields
	private XmlNodeReaderNavigator readerNav; // 0x10
	private XmlNodeType nodeType; // 0x18
	private int curDepth; // 0x1C
	private ReadState readState; // 0x20
	private bool fEOF; // 0x24
	private bool bResolveEntity; // 0x25
	private bool bStartFromDocument; // 0x26
	private bool bInReadBinary; // 0x27
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override bool HasValue { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool CanResolveEntity { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override bool HasAttributes { get; }
	public override XmlNameTable NameTable { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1D0BA80 Offset: 0x1D0A080 VA: 0x181D0BA80
	public void .ctor(XmlNode node) { }

	// RVA: 0x1D0A790 Offset: 0x1D08D90 VA: 0x181D0A790
	internal bool IsInReadingStates() { }

	// RVA: 0x1D0BF90 Offset: 0x1D0A590 VA: 0x181D0BF90 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1D0BF00 Offset: 0x1D0A500 VA: 0x181D0BF00 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1D0BDE0 Offset: 0x1D0A3E0 VA: 0x181D0BDE0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1D0BF40 Offset: 0x1D0A540 VA: 0x181D0BF40 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1D0BFA0 Offset: 0x1D0A5A0 VA: 0x181D0BFA0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1D0BC40 Offset: 0x1D0A240 VA: 0x181D0BC40 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x1D0C040 Offset: 0x1D0A640 VA: 0x181D0C040 Slot: 12
	public override string get_Value() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1D0BBC0 Offset: 0x1D0A1C0 VA: 0x181D0BBC0 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1D0BDB0 Offset: 0x1D0A3B0 VA: 0x181D0BDB0 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1D0BCD0 Offset: 0x1D0A2D0 VA: 0x181D0BCD0 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x1D0C0D0 Offset: 0x1D0A6D0 VA: 0x181D0C0D0 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1D0C080 Offset: 0x1D0A680 VA: 0x181D0C080 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x1D0BFF0 Offset: 0x1D0A5F0 VA: 0x181D0BFF0 Slot: 20
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1D0BB80 Offset: 0x1D0A180 VA: 0x181D0BB80 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1D0A710 Offset: 0x1D08D10 VA: 0x181D0A710 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1D0A740 Offset: 0x1D08D40 VA: 0x181D0A740 Slot: 25
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1D0A690 Offset: 0x1D08C90 VA: 0x181D0A690 Slot: 26
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x1D0A9A0 Offset: 0x1D08FA0 VA: 0x181D0A9A0 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1D0A7E0 Offset: 0x1D08DE0 VA: 0x181D0A7E0 Slot: 28
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x1D0AC70 Offset: 0x1D09270 VA: 0x181D0AC70 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1D0AD90 Offset: 0x1D09390 VA: 0x181D0AD90 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1D0AAB0 Offset: 0x1D090B0 VA: 0x181D0AAB0 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1D0B5B0 Offset: 0x1D09BB0 VA: 0x181D0B5B0 Slot: 33
	public override bool Read() { }

	// RVA: 0x1D0B5C0 Offset: 0x1D09BC0 VA: 0x181D0B5C0
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x1D0B220 Offset: 0x1D09820 VA: 0x181D0B220
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x1D0B820 Offset: 0x1D09E20 VA: 0x181D0B820
	private void SetEndOfFile() { }

	// RVA: 0x1D0AF10 Offset: 0x1D09510 VA: 0x181D0AF10
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x1D0B000 Offset: 0x1D09600 VA: 0x181D0B000
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x1D0AEE0 Offset: 0x1D094E0 VA: 0x181D0AEE0
	private void ReSetReadingMarks() { }

	// RVA: 0x1D0BC30 Offset: 0x1D0A230 VA: 0x181D0BC30 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x1D0A650 Offset: 0x1D08C50 VA: 0x181D0A650 Slot: 35
	public override void Close() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1D0B840 Offset: 0x1D09E40 VA: 0x181D0B840 Slot: 37
	public override void Skip() { }

	// RVA: 0x1D0B500 Offset: 0x1D09B00 VA: 0x181D0B500 Slot: 44
	public override string ReadString() { }

	// RVA: 0x1CC7EF0 Offset: 0x1CC64F0 VA: 0x181CC7EF0 Slot: 53
	public override bool get_HasAttributes() { }

	// RVA: 0x1D0BEE0 Offset: 0x1D0A4E0 VA: 0x181D0BEE0 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1D0A7A0 Offset: 0x1D08DA0 VA: 0x181D0A7A0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1D0B790 Offset: 0x1D09D90 VA: 0x181D0B790 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1D0AFB0 Offset: 0x1D095B0 VA: 0x181D0AFB0 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1D0A660 Offset: 0x1D08C60 VA: 0x181D0A660
	private void FinishReadBinary() { }

	// RVA: 0x1D0B850 Offset: 0x1D09E50 VA: 0x181D0B850 Slot: 57
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1D0BA60 Offset: 0x1D0A060 VA: 0x181D0BA60 Slot: 59
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1D0B870 Offset: 0x1D09E70 VA: 0x181D0B870 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1D0BC00 Offset: 0x1D0A200 VA: 0x181D0BC00 Slot: 56
	internal override IDtdInfo get_DtdInfo() { }
}

// Namespace: System.Xml
public class XmlNotation : XmlNode // TypeDefIndex: 6724
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string name; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public override string InnerXml { set; }

	// Methods

	// RVA: 0x1D0F700 Offset: 0x1D0DD00 VA: 0x181D0F700
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x458FC0 Offset: 0x4575C0 VA: 0x180458FC0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1D0F6A0 Offset: 0x1D0DCA0 VA: 0x181D0F6A0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x1D0F820 Offset: 0x1D0DE20 VA: 0x181D0F820 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

// Namespace: System.Xml
public class XmlProcessingInstruction : XmlLinkedNode // TypeDefIndex: 6725
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public string Data { set; }
	public override string InnerText { get; set; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x1D0F910 Offset: 0x1D0DF10 VA: 0x181D0F910
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x1CE11A0 Offset: 0x1CDF7A0 VA: 0x181CE11A0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x53F9C0 Offset: 0x53DFC0 VA: 0x18053F9C0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1D0FA50 Offset: 0x1D0E050 VA: 0x181D0FA50 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1D0F970 Offset: 0x1D0DF70 VA: 0x181D0F970
	public void set_Data(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x1D0FA50 Offset: 0x1D0E050 VA: 0x181D0FA50 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x4565D0 Offset: 0x454BD0 VA: 0x1804565D0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1D0F880 Offset: 0x1D0DE80 VA: 0x181D0F880 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1D0F8D0 Offset: 0x1D0DED0 VA: 0x181D0F8D0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

// Namespace: System.Xml
public class XmlSignificantWhitespace : XmlCharacterData // TypeDefIndex: 6726
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1D0FB20 Offset: 0x1D0E120 VA: 0x181D0FB20
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1D0FBD0 Offset: 0x1D0E1D0 VA: 0x181D0FBD0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1D0FBD0 Offset: 0x1D0E1D0 VA: 0x181D0FBD0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x45A9B0 Offset: 0x458FB0 VA: 0x18045A9B0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1D0FC00 Offset: 0x1D0E200 VA: 0x181D0FC00 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1D0FA60 Offset: 0x1D0E060 VA: 0x181D0FA60 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1532550 Offset: 0x1530B50 VA: 0x181532550 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1D0FCB0 Offset: 0x1D0E2B0 VA: 0x181D0FCB0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1D0FAD0 Offset: 0x1D0E0D0 VA: 0x181D0FAD0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 55
	internal override bool get_IsText() { }
}

// Namespace: System.Xml
public class XmlText : XmlCharacterData // TypeDefIndex: 6727
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1D0FDD0 Offset: 0x1D0E3D0 VA: 0x181D0FDD0
	internal void .ctor(string strData) { }

	// RVA: 0x1D0FDC0 Offset: 0x1D0E3C0 VA: 0x181D0FDC0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1D0FDE0 Offset: 0x1D0E3E0 VA: 0x181D0FDE0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1D0FDE0 Offset: 0x1D0E3E0 VA: 0x181D0FDE0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1CE10D0 Offset: 0x1CDF6D0 VA: 0x181CE10D0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1D0FD50 Offset: 0x1D0E350 VA: 0x181D0FD50 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1532550 Offset: 0x1530B50 VA: 0x181532550 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1D0FE10 Offset: 0x1D0E410 VA: 0x181D0FE10 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1D0FAD0 Offset: 0x1D0E0D0 VA: 0x181D0FAD0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 55
	internal override bool get_IsText() { }
}

// Namespace: System.Xml
internal class XmlUnspecifiedAttribute : XmlAttribute // TypeDefIndex: 6728
{
	// Fields
	private bool fSpecified; // 0x28

	// Properties
	public override bool Specified { get; }
	public override string InnerText { set; }

	// Methods

	// RVA: 0x1D100B0 Offset: 0x1D0E6B0 VA: 0x181D100B0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150 Slot: 56
	public override bool get_Specified() { }

	// RVA: 0x1D0FEF0 Offset: 0x1D0E4F0 VA: 0x181D0FEF0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1D100C0 Offset: 0x1D0E6C0 VA: 0x181D100C0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1D10060 Offset: 0x1D0E660 VA: 0x181D10060 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1D10040 Offset: 0x1D0E640 VA: 0x181D10040 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1D10080 Offset: 0x1D0E680 VA: 0x181D10080 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1D0FED0 Offset: 0x1D0E4D0 VA: 0x181D0FED0 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1D100A0 Offset: 0x1D0E6A0 VA: 0x181D100A0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	internal void SetSpecified(bool f) { }
}

// Namespace: System.Xml
public class XmlWhitespace : XmlCharacterData // TypeDefIndex: 6729
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1D101A0 Offset: 0x1D0E7A0 VA: 0x181D101A0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1D10250 Offset: 0x1D0E850 VA: 0x181D10250 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1D10250 Offset: 0x1D0E850 VA: 0x181D10250 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x459940 Offset: 0x457F40 VA: 0x180459940 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1D0FC00 Offset: 0x1D0E200 VA: 0x181D0FC00 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1532550 Offset: 0x1530B50 VA: 0x181532550 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1D10280 Offset: 0x1D0E880 VA: 0x181D10280 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1D100E0 Offset: 0x1D0E6E0 VA: 0x181D100E0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1D10150 Offset: 0x1D0E750 VA: 0x181D10150 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 55
	internal override bool get_IsText() { }
}

// Namespace: System.Xml
internal sealed class EmptyEnumerator : IEnumerator // TypeDefIndex: 6730
{
	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1D03CF0 Offset: 0x1D022F0 VA: 0x181D03CF0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml
[DefaultMember("Item")]
internal class HWStack : ICloneable // TypeDefIndex: 6731
{
	// Fields
	private object[] stack; // 0x10
	private int growthRate; // 0x18
	private int used; // 0x1C
	private int size; // 0x20
	private int limit; // 0x24

	// Properties
	internal object Item { get; set; }
	internal int Length { get; }

	// Methods

	// RVA: 0x1D04180 Offset: 0x1D02780 VA: 0x181D04180
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x1D04100 Offset: 0x1D02700 VA: 0x181D04100
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x1D03F70 Offset: 0x1D02570 VA: 0x181D03F70
	internal object Push() { }

	// RVA: 0x1D03F30 Offset: 0x1D02530 VA: 0x181D03F30
	internal object Pop() { }

	// RVA: 0x1D03EF0 Offset: 0x1D024F0 VA: 0x181D03EF0
	internal object Peek() { }

	// RVA: 0x1D03D50 Offset: 0x1D02350 VA: 0x181D03D50
	internal void AddToTop(object o) { }

	// RVA: 0x1D04200 Offset: 0x1D02800 VA: 0x181D04200
	internal object get_Item(int index) { }

	// RVA: 0x1D04280 Offset: 0x1D02880 VA: 0x181D04280
	internal void set_Item(int index, object value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	internal int get_Length() { }

	// RVA: 0x1D040A0 Offset: 0x1D026A0 VA: 0x181D040A0
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x1D03DE0 Offset: 0x1D023E0 VA: 0x181D03DE0 Slot: 4
	public object Clone() { }
}

// Namespace: System.Xml
public interface IXmlLineInfo // TypeDefIndex: 6732
{
	// Properties
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasLineInfo();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LinePosition();
}

// Namespace: System.Xml
internal class PositionInfo : IXmlLineInfo // TypeDefIndex: 6733
{
	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public virtual bool HasLineInfo() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 8
	public virtual int get_LineNumber() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 9
	public virtual int get_LinePosition() { }

	// RVA: 0x1D04C00 Offset: 0x1D03200 VA: 0x181D04C00
	public static PositionInfo GetPositionInfo(object o) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml
internal class ReaderPositionInfo : PositionInfo // TypeDefIndex: 6734
{
	// Fields
	private IXmlLineInfo lineInfo; // 0x10

	// Properties
	public override int LineNumber { get; }
	public override int LinePosition { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(IXmlLineInfo lineInfo) { }

	// RVA: 0x1D04CC0 Offset: 0x1D032C0 VA: 0x181D04CC0 Slot: 7
	public override bool HasLineInfo() { }

	// RVA: 0x1D04D10 Offset: 0x1D03310 VA: 0x181D04D10 Slot: 8
	public override int get_LineNumber() { }

	// RVA: 0x1D04D60 Offset: 0x1D03360 VA: 0x181D04D60 Slot: 9
	public override int get_LinePosition() { }
}

// Namespace: System.Xml
public interface IXmlNamespaceResolver // TypeDefIndex: 6735
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string LookupNamespace(string prefix);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string LookupPrefix(string namespaceName);
}

// Namespace: System.Xml
internal struct LineInfo // TypeDefIndex: 6736
{
	// Fields
	internal int lineNo; // 0x0
	internal int linePos; // 0x4

	// Methods

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	public void .ctor(int lineNo, int linePos) { }

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	public void Set(int lineNo, int linePos) { }
}

// Namespace: System.Xml
public class NameTable : XmlNameTable // TypeDefIndex: 6738
{
	// Fields
	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0x1D04B90 Offset: 0x1D03190 VA: 0x181D04B90
	public void .ctor() { }

	// RVA: 0x1D045B0 Offset: 0x1D02BB0 VA: 0x181D045B0 Slot: 6
	public override string Add(string key) { }

	// RVA: 0x1D04720 Offset: 0x1D02D20 VA: 0x181D04720 Slot: 5
	public override string Add(char[] key, int start, int len) { }

	// RVA: 0x1D048D0 Offset: 0x1D02ED0 VA: 0x181D048D0 Slot: 4
	public override string Get(string value) { }

	// RVA: 0x1D04350 Offset: 0x1D02950 VA: 0x181D04350
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x1D04A30 Offset: 0x1D03030 VA: 0x181D04A30
	private void Grow() { }

	// RVA: 0x15A6EE0 Offset: 0x15A54E0 VA: 0x1815A6EE0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}

// Namespace: System.Xml
internal static class Ref // TypeDefIndex: 6739
{
	// Methods

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50
	public static bool Equal(string strA, string strB) { }
}

// Namespace: System.Xml
internal class DtdParser : IDtdParser // TypeDefIndex: 6745
{
	// Fields
	private IDtdParserAdapter readerAdapter; // 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaInfo schemaInfo; // 0x28
	private XmlCharType xmlCharType; // 0x30
	private string systemId; // 0x38
	private string publicId; // 0x40
	private bool normalize; // 0x48
	private bool validate; // 0x49
	private bool supportNamespaces; // 0x4A
	private bool v1Compat; // 0x4B
	private char[] chars; // 0x50
	private int charsUsed; // 0x58
	private int curPos; // 0x5C
	private DtdParser.ScanningFunction scanningFunction; // 0x60
	private DtdParser.ScanningFunction nextScaningFunction; // 0x64
	private DtdParser.ScanningFunction savedScanningFunction; // 0x68
	private bool whitespaceSeen; // 0x6C
	private int tokenStartPos; // 0x70
	private int colonPos; // 0x74
	private StringBuilder internalSubsetValueSb; // 0x78
	private int externalEntitiesDepth; // 0x80
	private int currentEntityId; // 0x84
	private bool freeFloatingDtd; // 0x88
	private bool hasFreeFloatingInternalSubset; // 0x89
	private StringBuilder stringBuilder; // 0x90
	private int condSectionDepth; // 0x98
	private LineInfo literalLineInfo; // 0x9C
	private char literalQuoteChar; // 0xA4
	private string documentBaseUri; // 0xA8
	private string externalDtdBaseUri; // 0xB0
	private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations; // 0xB8
	private int[] condSectionEntityIds; // 0xC0

	// Properties
	private bool ParsingInternalSubset { get; }
	private bool IgnoreEntityReferences { get; }
	private bool SaveInternalSubsetValue { get; }
	private bool ParsingTopLevelMarkup { get; }
	private bool SupportNamespaces { get; }
	private bool Normalize { get; }
	private int LineNo { get; }
	private int LinePos { get; }
	private string BaseUriStr { get; }

	// Methods

	// RVA: 0x1D03A00 Offset: 0x1D02000 VA: 0x181D03A00
	private void .ctor() { }

	// RVA: 0x1CF8300 Offset: 0x1CF6900 VA: 0x181CF8300
	internal static IDtdParser Create() { }

	// RVA: 0x1CFA3E0 Offset: 0x1CF89E0 VA: 0x181CFA3E0
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1CF9FF0 Offset: 0x1CF85F0 VA: 0x181CF9FF0
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x1D03000 Offset: 0x1D01600 VA: 0x181D03000 Slot: 4
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x1D02FB0 Offset: 0x1D015B0 VA: 0x181D02FB0 Slot: 5
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x1D03C60 Offset: 0x1D02260 VA: 0x181D03C60
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x1D03BA0 Offset: 0x1D021A0 VA: 0x181D03BA0
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x1D03C90 Offset: 0x1D02290 VA: 0x181D03C90
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x1D03C70 Offset: 0x1D02270 VA: 0x181D03C70
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x16EE320 Offset: 0x16EC920 VA: 0x1816EE320
	private bool get_SupportNamespaces() { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	private bool get_Normalize() { }

	// RVA: 0x1CFDE50 Offset: 0x1CFC450 VA: 0x181CFDE50
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x1CFD270 Offset: 0x1CFB870 VA: 0x181CFD270
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x1CFD1A0 Offset: 0x1CFB7A0 VA: 0x181CFD1A0
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x1CFD470 Offset: 0x1CFBA70 VA: 0x181CFD470
	private void ParseInternalSubset() { }

	// RVA: 0x1CFD000 Offset: 0x1CFB600 VA: 0x181CFD000
	private void ParseExternalSubset() { }

	// RVA: 0x1CFD870 Offset: 0x1CFBE70 VA: 0x181CFD870
	private void ParseSubset() { }

	// RVA: 0x1CFA820 Offset: 0x1CF8E20 VA: 0x181CFA820
	private void ParseAttlistDecl() { }

	// RVA: 0x1CFB0B0 Offset: 0x1CF96B0 VA: 0x181CFB0B0
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x1CFAE40 Offset: 0x1CF9440 VA: 0x181CFAE40
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x1CFBC40 Offset: 0x1CFA240 VA: 0x181CFBC40
	private void ParseElementDecl() { }

	// RVA: 0x1CFC380 Offset: 0x1CFA980 VA: 0x181CFC380
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x1CFD200 Offset: 0x1CFB800 VA: 0x181CFD200
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x1CFC0A0 Offset: 0x1CFA6A0 VA: 0x181CFC0A0
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x1CFC770 Offset: 0x1CFAD70 VA: 0x181CFC770
	private void ParseEntityDecl() { }

	// RVA: 0x1CFD480 Offset: 0x1CFBA80 VA: 0x181CFD480
	private void ParseNotationDecl() { }

	// RVA: 0x1CF80E0 Offset: 0x1CF66E0 VA: 0x181CF80E0
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x1CFB7F0 Offset: 0x1CF9DF0 VA: 0x181CFB7F0
	private void ParseComment() { }

	// RVA: 0x1CFD770 Offset: 0x1CFBD70 VA: 0x181CFD770
	private void ParsePI() { }

	// RVA: 0x1CFB990 Offset: 0x1CF9F90 VA: 0x181CFB990
	private void ParseCondSection() { }

	// RVA: 0x1CFCB60 Offset: 0x1CFB160 VA: 0x181CFCB60
	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	// RVA: 0x1CF8760 Offset: 0x1CF6D60 VA: 0x181CF8760
	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x1D02110 Offset: 0x1D00710 VA: 0x181D02110
	private DtdParser.Token ScanSubsetContent() { }

	// RVA: 0x1D01900 Offset: 0x1CFFF00 VA: 0x181D01900
	private DtdParser.Token ScanNameExpected() { }

	// RVA: 0x1D01DA0 Offset: 0x1D003A0 VA: 0x181D01DA0
	private DtdParser.Token ScanQNameExpected() { }

	// RVA: 0x1D01940 Offset: 0x1CFFF40 VA: 0x181D01940
	private DtdParser.Token ScanNmtokenExpected() { }

	// RVA: 0x1CFFCC0 Offset: 0x1CFE2C0 VA: 0x181CFFCC0
	private DtdParser.Token ScanDoctype1() { }

	// RVA: 0x1CFFE40 Offset: 0x1CFE440 VA: 0x181CFFE40
	private DtdParser.Token ScanDoctype2() { }

	// RVA: 0x1CFF260 Offset: 0x1CFD860 VA: 0x181CFF260
	private DtdParser.Token ScanClosingTag() { }

	// RVA: 0x1CFFF00 Offset: 0x1CFE500 VA: 0x181CFFF00
	private DtdParser.Token ScanElement1() { }

	// RVA: 0x1D00180 Offset: 0x1CFE780 VA: 0x181D00180
	private DtdParser.Token ScanElement2() { }

	// RVA: 0x1D003A0 Offset: 0x1CFE9A0 VA: 0x181D003A0
	private DtdParser.Token ScanElement3() { }

	// RVA: 0x1D00420 Offset: 0x1CFEA20 VA: 0x181D00420
	private DtdParser.Token ScanElement4() { }

	// RVA: 0x1D00500 Offset: 0x1CFEB00 VA: 0x181D00500
	private DtdParser.Token ScanElement5() { }

	// RVA: 0x1D00600 Offset: 0x1CFEC00 VA: 0x181D00600
	private DtdParser.Token ScanElement6() { }

	// RVA: 0x1D006C0 Offset: 0x1CFECC0 VA: 0x181D006C0
	private DtdParser.Token ScanElement7() { }

	// RVA: 0x1CFE2A0 Offset: 0x1CFC8A0 VA: 0x181CFE2A0
	private DtdParser.Token ScanAttlist1() { }

	// RVA: 0x1CFE370 Offset: 0x1CFC970 VA: 0x181CFE370
	private DtdParser.Token ScanAttlist2() { }

	// RVA: 0x1CFEB20 Offset: 0x1CFD120 VA: 0x181CFEB20
	private DtdParser.Token ScanAttlist3() { }

	// RVA: 0x1CFEBB0 Offset: 0x1CFD1B0 VA: 0x181CFEBB0
	private DtdParser.Token ScanAttlist4() { }

	// RVA: 0x1CFEC70 Offset: 0x1CFD270 VA: 0x181CFEC70
	private DtdParser.Token ScanAttlist5() { }

	// RVA: 0x1CFED30 Offset: 0x1CFD330 VA: 0x181CFED30
	private DtdParser.Token ScanAttlist6() { }

	// RVA: 0x1CFF1B0 Offset: 0x1CFD7B0 VA: 0x181CFF1B0
	private DtdParser.Token ScanAttlist7() { }

	// RVA: 0x1D00B10 Offset: 0x1CFF110 VA: 0x181D00B10
	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	// RVA: 0x1D00A00 Offset: 0x1CFF000 VA: 0x181D00A00
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x1D01B40 Offset: 0x1D00140 VA: 0x181D01B40
	private DtdParser.Token ScanNotation1() { }

	// RVA: 0x1D02960 Offset: 0x1D00F60 VA: 0x181D02960
	private DtdParser.Token ScanSystemId() { }

	// RVA: 0x1D00710 Offset: 0x1CFED10 VA: 0x181D00710
	private DtdParser.Token ScanEntity1() { }

	// RVA: 0x1D00780 Offset: 0x1CFED80 VA: 0x181D00780
	private DtdParser.Token ScanEntity2() { }

	// RVA: 0x1D00900 Offset: 0x1CFEF00 VA: 0x181D00900
	private DtdParser.Token ScanEntity3() { }

	// RVA: 0x1D01C80 Offset: 0x1D00280 VA: 0x181D01C80
	private DtdParser.Token ScanPublicId1() { }

	// RVA: 0x1D01D30 Offset: 0x1D00330 VA: 0x181D01D30
	private DtdParser.Token ScanPublicId2() { }

	// RVA: 0x1CFF2E0 Offset: 0x1CFD8E0 VA: 0x181CFF2E0
	private DtdParser.Token ScanCondSection1() { }

	// RVA: 0x1CFF640 Offset: 0x1CFDC40 VA: 0x181CFF640
	private DtdParser.Token ScanCondSection2() { }

	// RVA: 0x1CFF6C0 Offset: 0x1CFDCC0 VA: 0x181CFF6C0
	private DtdParser.Token ScanCondSection3() { }

	// RVA: 0x1D01930 Offset: 0x1CFFF30 VA: 0x181D01930
	private void ScanName() { }

	// RVA: 0x1D02100 Offset: 0x1D00700 VA: 0x181D02100
	private void ScanQName() { }

	// RVA: 0x1D01DD0 Offset: 0x1D003D0 VA: 0x181D01DD0
	private void ScanQName(bool isQName) { }

	// RVA: 0x1CFE0D0 Offset: 0x1CFC6D0 VA: 0x181CFE0D0
	private bool ReadDataInName() { }

	// RVA: 0x1D01970 Offset: 0x1CFFF70 VA: 0x181D01970
	private void ScanNmtoken() { }

	// RVA: 0x1CF8400 Offset: 0x1CF6A00 VA: 0x181CF8400
	private bool EatPublicKeyword() { }

	// RVA: 0x1CF84C0 Offset: 0x1CF6AC0 VA: 0x181CF84C0
	private bool EatSystemKeyword() { }

	// RVA: 0x1CF8580 Offset: 0x1CF6B80 VA: 0x181CF8580
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x1CF8730 Offset: 0x1CF6D30 VA: 0x181CF8730
	private string GetNameString() { }

	// RVA: 0x1CF8730 Offset: 0x1CF6D30 VA: 0x181CF8730
	private string GetNmtokenString() { }

	// RVA: 0x1CF9B10 Offset: 0x1CF8110 VA: 0x181CF9B10
	private string GetValue() { }

	// RVA: 0x1CF9A80 Offset: 0x1CF8080 VA: 0x181CF9A80
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x1CFE120 Offset: 0x1CFC720 VA: 0x181CFE120
	private int ReadData() { }

	// RVA: 0x1CFA6B0 Offset: 0x1CF8CB0 VA: 0x181CFA6B0
	private void LoadParsingBuffer() { }

	// RVA: 0x1CFE290 Offset: 0x1CFC890 VA: 0x181CFE290
	private void SaveParsingBuffer() { }

	// RVA: 0x1CFE1A0 Offset: 0x1CFC7A0 VA: 0x181CFE1A0
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x1CF9F80 Offset: 0x1CF8580 VA: 0x181CF9F80
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x1CF9CF0 Offset: 0x1CF82F0 VA: 0x181CF9CF0
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x1CF9B90 Offset: 0x1CF8190 VA: 0x181CF9B90
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x1D037C0 Offset: 0x1D01DC0 VA: 0x181D037C0
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x1D02A10 Offset: 0x1D01010 VA: 0x181D02A10
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x1D02B80 Offset: 0x1D01180 VA: 0x181D02B80
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x1D02CD0 Offset: 0x1D012D0 VA: 0x181D02CD0
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x1CFA6A0 Offset: 0x1CF8CA0 VA: 0x181CFA6A0
	private bool IsAttributeValueType(DtdParser.Token token) { }

	// RVA: 0x1D03BB0 Offset: 0x1D021B0 VA: 0x181D03BB0
	private int get_LineNo() { }

	// RVA: 0x1D03C00 Offset: 0x1D02200 VA: 0x181D03C00
	private int get_LinePos() { }

	// RVA: 0x1D03AE0 Offset: 0x1D020E0 VA: 0x181D03AE0
	private string get_BaseUriStr() { }

	// RVA: 0x1CFA7C0 Offset: 0x1CF8DC0 VA: 0x181CFA7C0
	private void OnUnexpectedError() { }

	// RVA: 0x1D032D0 Offset: 0x1D018D0 VA: 0x181D032D0
	private void Throw(int curPos, string res) { }

	// RVA: 0x1D03300 Offset: 0x1D01900 VA: 0x181D03300
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x1D03600 Offset: 0x1D01C00 VA: 0x181D03600
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x1D034C0 Offset: 0x1D01AC0 VA: 0x181D034C0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1D030C0 Offset: 0x1D016C0 VA: 0x181D030C0
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x1D03040 Offset: 0x1D01640 VA: 0x181D03040
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x1D03140 Offset: 0x1D01740 VA: 0x181D03140
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x1D03160 Offset: 0x1D01760 VA: 0x181D03160
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x1CFDD80 Offset: 0x1CFC380 VA: 0x181CFDD80
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x1D02DD0 Offset: 0x1D013D0 VA: 0x181D02DD0
	internal static string StripSpaces(string value) { }
}

// Namespace: System.Xml
public enum XmlTokenizedType // TypeDefIndex: 6746
{
	// Fields
	public int value__; // 0x0
	public const XmlTokenizedType CDATA = 0;
	public const XmlTokenizedType ID = 1;
	public const XmlTokenizedType IDREF = 2;
	public const XmlTokenizedType IDREFS = 3;
	public const XmlTokenizedType ENTITY = 4;
	public const XmlTokenizedType ENTITIES = 5;
	public const XmlTokenizedType NMTOKEN = 6;
	public const XmlTokenizedType NMTOKENS = 7;
	public const XmlTokenizedType NOTATION = 8;
	public const XmlTokenizedType ENUMERATION = 9;
	public const XmlTokenizedType QName = 10;
	public const XmlTokenizedType NCName = 11;
	public const XmlTokenizedType None = 12;
}

// Namespace: System.Xml
internal static class ValidateNames // TypeDefIndex: 6747
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0

	// Methods

	// RVA: 0x1D1ACA0 Offset: 0x1D192A0 VA: 0x181D1ACA0
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0x1D1ABD0 Offset: 0x1D191D0 VA: 0x181D1ABD0
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x1D1AA80 Offset: 0x1D19080 VA: 0x181D1AA80
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x1D1A8A0 Offset: 0x1D18EA0 VA: 0x181D1A8A0
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0x1D1A960 Offset: 0x1D18F60 VA: 0x181D1A960
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0x1D1A910 Offset: 0x1D18F10 VA: 0x181D1A910
	internal static int ParseNCName(string s) { }

	// RVA: 0x1D1AF10 Offset: 0x1D19510 VA: 0x181D1AF10
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0x1D1AD60 Offset: 0x1D19360 VA: 0x181D1AD60
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0x1D1B140 Offset: 0x1D19740 VA: 0x181D1B140
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x1D1A640 Offset: 0x1D18C40 VA: 0x181D1A640
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x1D1AFF0 Offset: 0x1D195F0 VA: 0x181D1AFF0
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0x1D1B320 Offset: 0x1D19920 VA: 0x181D1B320
	private static void .cctor() { }
}

// Namespace: System.Xml
internal struct XmlCharType // TypeDefIndex: 6748
{
	// Fields
	private static object s_Lock; // 0x0
	private static byte[] s_CharProperties; // 0x8
	internal byte[] charProperties; // 0x0

	// Properties
	private static object StaticLock { get; }
	public static XmlCharType Instance { get; }

	// Methods

	// RVA: 0x1D1EF50 Offset: 0x1D1D550 VA: 0x181D1EF50
	private static object get_StaticLock() { }

	// RVA: 0x1D1E290 Offset: 0x1D1C890 VA: 0x181D1E290
	private static void InitInstance() { }

	// RVA: 0x1D1EDE0 Offset: 0x1D1D3E0 VA: 0x181D1EDE0
	private static void SetProperties(byte[] chProps, string ranges, byte value) { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	private void .ctor(byte[] charProperties) { }

	// RVA: 0x1D1EED0 Offset: 0x1D1D4D0 VA: 0x181D1EED0
	public static XmlCharType get_Instance() { }

	// RVA: 0x1D1EDB0 Offset: 0x1D1D3B0 VA: 0x181D1EDB0
	public bool IsWhiteSpace(char ch) { }

	// RVA: 0x1D1E910 Offset: 0x1D1CF10 VA: 0x181D1E910
	public bool IsNCNameSingleChar(char ch) { }

	// RVA: 0x1D1ED40 Offset: 0x1D1D340 VA: 0x181D1ED40
	public bool IsStartNCNameSingleChar(char ch) { }

	// RVA: 0x1D1E980 Offset: 0x1D1CF80 VA: 0x181D1E980
	public bool IsNameSingleChar(char ch) { }

	// RVA: 0x1D1E860 Offset: 0x1D1CE60 VA: 0x181D1E860
	public bool IsCharData(char ch) { }

	// RVA: 0x1D1EC10 Offset: 0x1D1D210 VA: 0x181D1EC10
	public bool IsPubidChar(char ch) { }

	// RVA: 0x1D1ED80 Offset: 0x1D1D380 VA: 0x181D1ED80
	internal bool IsTextChar(char ch) { }

	// RVA: 0x1D1E8A0 Offset: 0x1D1CEA0 VA: 0x181D1E8A0
	public bool IsLetter(char ch) { }

	// RVA: 0x1D1E8E0 Offset: 0x1D1CEE0 VA: 0x181D1E8E0
	public bool IsNCNameCharXml4e(char ch) { }

	// RVA: 0x1D1ED00 Offset: 0x1D1D300 VA: 0x181D1ED00
	public bool IsStartNCNameCharXml4e(char ch) { }

	// RVA: 0x1D1E940 Offset: 0x1D1CF40 VA: 0x181D1E940
	public bool IsNameCharXml4e(char ch) { }

	// RVA: 0x14F3810 Offset: 0x14F1E10 VA: 0x1814F3810
	public static bool IsDigit(char ch) { }

	// RVA: 0x1D1E890 Offset: 0x1D1CE90 VA: 0x181D1E890
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0x1D1E8D0 Offset: 0x1D1CED0 VA: 0x181D1E8D0
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0x1D1ED70 Offset: 0x1D1D370 VA: 0x181D1ED70
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0x1D1E270 Offset: 0x1D1C870 VA: 0x181D1E270
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x1D1EE90 Offset: 0x1D1D490 VA: 0x181D1EE90
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

	// RVA: 0x1D1EB90 Offset: 0x1D1D190 VA: 0x181D1EB90
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x1D1EB10 Offset: 0x1D1D110 VA: 0x181D1EB10
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x1D1E9C0 Offset: 0x1D1CFC0 VA: 0x181D1E9C0
	internal int IsOnlyCharData(string str) { }

	// RVA: 0x1D1EAA0 Offset: 0x1D1D0A0 VA: 0x181D1EAA0
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x1D1EC90 Offset: 0x1D1D290 VA: 0x181D1EC90
	internal int IsPublicId(string str) { }

	// RVA: 0x137E9D0 Offset: 0x137CFD0 VA: 0x18137E9D0
	private static bool InRange(int value, int start, int end) { }
}

// Namespace: System.Xml
internal static class XmlComplianceUtil // TypeDefIndex: 6749
{
	// Methods

	// RVA: 0x1D1F1A0 Offset: 0x1D1D7A0 VA: 0x181D1F1A0
	public static string NonCDataNormalize(string value) { }

	// RVA: 0x1D1EFF0 Offset: 0x1D1D5F0 VA: 0x181D1EFF0
	public static string CDataNormalize(string value) { }
}

// Namespace: System.Xml
internal enum ExceptionType // TypeDefIndex: 6750
{
	// Fields
	public int value__; // 0x0
	public const ExceptionType ArgumentException = 0;
	public const ExceptionType XmlException = 1;
}

// Namespace: System.Xml
public enum XmlDateTimeSerializationMode // TypeDefIndex: 6751
{
	// Fields
	public int value__; // 0x0
	public const XmlDateTimeSerializationMode Local = 0;
	public const XmlDateTimeSerializationMode Utc = 1;
	public const XmlDateTimeSerializationMode Unspecified = 2;
	public const XmlDateTimeSerializationMode RoundtripKind = 3;
}

// Namespace: System.Xml
public class XmlConvert // TypeDefIndex: 6752
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0
	internal static char[] crt; // 0x8
	private static readonly int c_EncodedCharLength; // 0x10
	private static Regex c_EncodeCharPattern; // 0x18
	private static Regex c_DecodeCharPattern; // 0x20
	private static string[] s_allDateTimeFormats; // 0x28
	internal static readonly char[] WhitespaceChars; // 0x30

	// Properties
	private static string[] AllDateTimeFormats { get; }

	// Methods

	// RVA: 0x1D21110 Offset: 0x1D1F710 VA: 0x181D21110
	public static string EncodeName(string name) { }

	// RVA: 0x1D210B0 Offset: 0x1D1F6B0 VA: 0x181D210B0
	public static string EncodeLocalName(string name) { }

	// RVA: 0x1D20890 Offset: 0x1D1EE90 VA: 0x181D20890
	public static string DecodeName(string name) { }

	// RVA: 0x1D21160 Offset: 0x1D1F760 VA: 0x181D21160
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0x1D21B00 Offset: 0x1D20100 VA: 0x181D21B00
	private static int FromHex(char digit) { }

	// RVA: 0x1D219D0 Offset: 0x1D1FFD0 VA: 0x181D219D0
	internal static byte[] FromBinHexString(string s) { }

	// RVA: 0x1D21A80 Offset: 0x1D20080 VA: 0x181D21A80
	internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x1D21E50 Offset: 0x1D20450 VA: 0x181D21E50
	internal static string ToBinHexString(byte[] inArray) { }

	// RVA: 0x1D267D0 Offset: 0x1D24DD0 VA: 0x181D267D0
	public static string VerifyName(string name) { }

	// RVA: 0x1D25EC0 Offset: 0x1D244C0 VA: 0x181D25EC0
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0x1D26930 Offset: 0x1D24F30 VA: 0x181D26930
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1D264D0 Offset: 0x1D24AD0 VA: 0x181D264D0
	public static string VerifyNCName(string name) { }

	// RVA: 0x1D26660 Offset: 0x1D24C60 VA: 0x181D26660
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1D25BF0 Offset: 0x1D241F0 VA: 0x181D25BF0
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0x1D26B00 Offset: 0x1D25100 VA: 0x181D26B00
	public static string VerifyTOKEN(string token) { }

	// RVA: 0x1D26130 Offset: 0x1D24730 VA: 0x181D26130
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x1D25CC0 Offset: 0x1D242C0 VA: 0x181D25CC0
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x1D26060 Offset: 0x1D24660 VA: 0x181D26060
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x1D23290 Offset: 0x1D21890 VA: 0x181D23290
	public static string ToString(bool value) { }

	// RVA: 0x1D22F50 Offset: 0x1D21550 VA: 0x181D22F50
	public static string ToString(char value) { }

	// RVA: 0x1D22EE0 Offset: 0x1D214E0 VA: 0x181D22EE0
	public static string ToString(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D233D0 Offset: 0x1D219D0 VA: 0x181D233D0
	public static string ToString(sbyte value) { }

	// RVA: 0x1D22E40 Offset: 0x1D21440 VA: 0x181D22E40
	public static string ToString(short value) { }

	// RVA: 0x1D22E70 Offset: 0x1D21470 VA: 0x181D22E70
	public static string ToString(int value) { }

	// RVA: 0x1D23400 Offset: 0x1D21A00 VA: 0x181D23400
	public static string ToString(long value) { }

	// RVA: 0x1D22EB0 Offset: 0x1D214B0 VA: 0x181D22EB0
	public static string ToString(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D22E10 Offset: 0x1D21410 VA: 0x181D22E10
	public static string ToString(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D22F90 Offset: 0x1D21590 VA: 0x181D22F90
	public static string ToString(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1D23030 Offset: 0x1D21630 VA: 0x181D23030
	public static string ToString(ulong value) { }

	// RVA: 0x1D22D10 Offset: 0x1D21310 VA: 0x181D22D10
	public static string ToString(float value) { }

	// RVA: 0x1D22C10 Offset: 0x1D21210 VA: 0x181D22C10
	public static string ToString(double value) { }

	// RVA: 0x1D232E0 Offset: 0x1D218E0 VA: 0x181D232E0
	public static string ToString(TimeSpan value) { }

	// RVA: 0x1D23340 Offset: 0x1D21940 VA: 0x181D23340
	public static string ToString(DateTime value, string format) { }

	// RVA: 0x1D23060 Offset: 0x1D21660 VA: 0x181D23060
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x1D22FC0 Offset: 0x1D215C0 VA: 0x181D22FC0
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x1D22EA0 Offset: 0x1D214A0 VA: 0x181D22EA0
	public static string ToString(Guid value) { }

	// RVA: 0x1D21EC0 Offset: 0x1D204C0 VA: 0x181D21EC0
	public static bool ToBoolean(string s) { }

	// RVA: 0x1D23C50 Offset: 0x1D22250 VA: 0x181D23C50
	internal static Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0x1D22110 Offset: 0x1D20710 VA: 0x181D22110
	public static char ToChar(string s) { }

	// RVA: 0x1D24070 Offset: 0x1D22670 VA: 0x181D24070
	internal static Exception TryToChar(string s, out char result) { }

	// RVA: 0x1D22730 Offset: 0x1D20D30 VA: 0x181D22730
	public static Decimal ToDecimal(string s) { }

	// RVA: 0x1D24200 Offset: 0x1D22800 VA: 0x181D24200
	internal static Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0x1D229E0 Offset: 0x1D20FE0 VA: 0x181D229E0
	internal static Decimal ToInteger(string s) { }

	// RVA: 0x1D24D90 Offset: 0x1D23390 VA: 0x181D24D90
	internal static Exception TryToInteger(string s, out Decimal result) { }

	[CLSCompliant(False)]
	// RVA: 0x1D22A70 Offset: 0x1D21070 VA: 0x181D22A70
	public static sbyte ToSByte(string s) { }

	// RVA: 0x1D24F50 Offset: 0x1D23550 VA: 0x181D24F50
	internal static Exception TryToSByte(string s, out sbyte result) { }

	// RVA: 0x1D22950 Offset: 0x1D20F50 VA: 0x181D22950
	public static short ToInt16(string s) { }

	// RVA: 0x1D248E0 Offset: 0x1D22EE0 VA: 0x181D248E0
	internal static Exception TryToInt16(string s, out short result) { }

	// RVA: 0x1D22980 Offset: 0x1D20F80 VA: 0x181D22980
	public static int ToInt32(string s) { }

	// RVA: 0x1D24A70 Offset: 0x1D23070 VA: 0x181D24A70
	internal static Exception TryToInt32(string s, out int result) { }

	// RVA: 0x1D229B0 Offset: 0x1D20FB0 VA: 0x181D229B0
	public static long ToInt64(string s) { }

	// RVA: 0x1D24C00 Offset: 0x1D23200 VA: 0x181D24C00
	internal static Exception TryToInt64(string s, out long result) { }

	// RVA: 0x1D220E0 Offset: 0x1D206E0 VA: 0x181D220E0
	public static byte ToByte(string s) { }

	// RVA: 0x1D23EE0 Offset: 0x1D224E0 VA: 0x181D23EE0
	internal static Exception TryToByte(string s, out byte result) { }

	[CLSCompliant(False)]
	// RVA: 0x1D23590 Offset: 0x1D21B90 VA: 0x181D23590
	public static ushort ToUInt16(string s) { }

	// RVA: 0x1D25440 Offset: 0x1D23A40 VA: 0x181D25440
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[CLSCompliant(False)]
	// RVA: 0x1D235C0 Offset: 0x1D21BC0 VA: 0x181D235C0
	public static uint ToUInt32(string s) { }

	// RVA: 0x1D255D0 Offset: 0x1D23BD0 VA: 0x181D255D0
	internal static Exception TryToUInt32(string s, out uint result) { }

	[CLSCompliant(False)]
	// RVA: 0x1D235F0 Offset: 0x1D21BF0 VA: 0x181D235F0
	public static ulong ToUInt64(string s) { }

	// RVA: 0x1D25760 Offset: 0x1D23D60 VA: 0x181D25760
	internal static Exception TryToUInt64(string s, out ulong result) { }

	// RVA: 0x1D22AA0 Offset: 0x1D210A0 VA: 0x181D22AA0
	public static float ToSingle(string s) { }

	// RVA: 0x1D250E0 Offset: 0x1D236E0 VA: 0x181D250E0
	internal static Exception TryToSingle(string s, out float result) { }

	// RVA: 0x1D227C0 Offset: 0x1D20DC0 VA: 0x181D227C0
	public static double ToDouble(string s) { }

	// RVA: 0x1D243C0 Offset: 0x1D229C0 VA: 0x181D243C0
	internal static Exception TryToDouble(string s, out double result) { }

	// RVA: 0x1D23900 Offset: 0x1D21F00 VA: 0x181D23900
	internal static double ToXPathDouble(object o) { }

	// RVA: 0x1D23430 Offset: 0x1D21A30 VA: 0x181D23430
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0x1D25390 Offset: 0x1D23990 VA: 0x181D25390
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0x1D26D60 Offset: 0x1D25360 VA: 0x181D26D60
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0x1D1F480 Offset: 0x1D1DA80 VA: 0x181D1F480
	private static void CreateAllDateTimeFormats() { }

	[Obsolete("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
	// RVA: 0x1D22520 Offset: 0x1D20B20 VA: 0x181D22520
	public static DateTime ToDateTime(string s) { }

	// RVA: 0x1D22690 Offset: 0x1D20C90 VA: 0x181D22690
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0x1D222C0 Offset: 0x1D208C0 VA: 0x181D222C0
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x1D221E0 Offset: 0x1D207E0 VA: 0x181D221E0
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0x1D22930 Offset: 0x1D20F30 VA: 0x181D22930
	public static Guid ToGuid(string s) { }

	// RVA: 0x1D24680 Offset: 0x1D22C80 VA: 0x181D24680
	internal static Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0x1D21CB0 Offset: 0x1D202B0 VA: 0x181D21CB0
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x1D21D80 Offset: 0x1D20380 VA: 0x181D21D80
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x1D23620 Offset: 0x1D21C20 VA: 0x181D23620
	internal static Uri ToUri(string s) { }

	// RVA: 0x1D258F0 Offset: 0x1D23EF0 VA: 0x181D258F0
	internal static Exception TryToUri(string s, out Uri result) { }

	// RVA: 0x1D21C10 Offset: 0x1D20210 VA: 0x181D21C10
	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x1D23BE0 Offset: 0x1D221E0 VA: 0x181D23BE0
	internal static string TrimString(string value) { }

	// RVA: 0x1D23B70 Offset: 0x1D22170 VA: 0x181D23B70
	internal static string TrimStringStart(string value) { }

	// RVA: 0x1D23B00 Offset: 0x1D22100 VA: 0x181D23B00
	internal static string TrimStringEnd(string value) { }

	// RVA: 0x1D21BA0 Offset: 0x1D201A0 VA: 0x181D21BA0
	internal static string[] SplitString(string value) { }

	// RVA: 0x1D21B30 Offset: 0x1D20130 VA: 0x181D21B30
	internal static bool IsNegativeZero(double value) { }

	// RVA: 0x146EDD0 Offset: 0x146D3D0 VA: 0x18146EDD0
	private static long DoubleToInt64Bits(double value) { }

	// RVA: 0x1D26250 Offset: 0x1D24850 VA: 0x181D26250
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0x1D1FBD0 Offset: 0x1D1E1D0 VA: 0x181D1FBD0
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1D1F9A0 Offset: 0x1D1DFA0 VA: 0x181D1F9A0
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1D1FCA0 Offset: 0x1D1E2A0 VA: 0x181D1FCA0
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0x1D1FAF0 Offset: 0x1D1E0F0 VA: 0x181D1FAF0
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1D20600 Offset: 0x1D1EC00 VA: 0x181D20600
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	// RVA: 0x1D206A0 Offset: 0x1D1ECA0 VA: 0x181D206A0
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	// RVA: 0x1D20720 Offset: 0x1D1ED20 VA: 0x181D20720
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1D203E0 Offset: 0x1D1E9E0 VA: 0x181D203E0
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	// RVA: 0x1D20000 Offset: 0x1D1E600 VA: 0x181D20000
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	// RVA: 0x1D20200 Offset: 0x1D1E800 VA: 0x181D20200
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1D1FDF0 Offset: 0x1D1E3F0 VA: 0x181D1FDF0
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0x1D1FED0 Offset: 0x1D1E4D0 VA: 0x181D1FED0
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	// RVA: 0x1D1FD20 Offset: 0x1D1E320 VA: 0x181D1FD20
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	// RVA: 0x1D204F0 Offset: 0x1D1EAF0 VA: 0x181D204F0
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x1D20430 Offset: 0x1D1EA30 VA: 0x181D20430
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x1D26C20 Offset: 0x1D25220 VA: 0x181D26C20
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class XmlDownloadManager // TypeDefIndex: 6755
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x1D27670 Offset: 0x1D25C70 VA: 0x181D27670
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x1D26F80 Offset: 0x1D25580 VA: 0x181D26F80
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x1D27770 Offset: 0x1D25D70 VA: 0x181D27770
	internal void Remove(string host) { }

	// RVA: 0x1D27400 Offset: 0x1D25A00 VA: 0x181D27400
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachine(typeof(XmlDownloadManager.<GetNonFileStreamAsync>d__5))]
	// RVA: 0x1D26E10 Offset: 0x1D25410 VA: 0x181D26E10
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml
internal class OpenedHost // TypeDefIndex: 6756
{
	// Fields
	internal int nonCachedConnectionsCount; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml
internal class XmlRegisteredNonCachedStream : Stream // TypeDefIndex: 6757
{
	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private string host; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1D2B1C0 Offset: 0x1D297C0 VA: 0x181D2B1C0
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x1D2B040 Offset: 0x1D29640 VA: 0x181D2B040 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1D2AEC0 Offset: 0x1D294C0 VA: 0x181D2AEC0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1D2AE40 Offset: 0x1D29440 VA: 0x181D2AE40 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1D2AE80 Offset: 0x1D29480 VA: 0x181D2AE80 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1D2AFE0 Offset: 0x1D295E0 VA: 0x181D2AFE0 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1D2B010 Offset: 0x1D29610 VA: 0x181D2B010 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1A75CD0 Offset: 0x1A742D0 VA: 0x181A75CD0 Slot: 20
	public override void Flush() { }

	// RVA: 0x1D2B100 Offset: 0x1D29700 VA: 0x181D2B100 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1D2B0D0 Offset: 0x1D296D0 VA: 0x181D2B0D0 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x1D2B130 Offset: 0x1D29730 VA: 0x181D2B130 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1D2B190 Offset: 0x1D29790 VA: 0x181D2B190 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1D2B160 Offset: 0x1D29760 VA: 0x181D2B160 Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x1D2B260 Offset: 0x1D29860 VA: 0x181D2B260 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1D2B290 Offset: 0x1D29890 VA: 0x181D2B290 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1D2B2C0 Offset: 0x1D298C0 VA: 0x181D2B2C0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1A77AC0 Offset: 0x1A760C0 VA: 0x181A77AC0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1A77C00 Offset: 0x1A76200 VA: 0x181A77C00 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1D2B2F0 Offset: 0x1D298F0 VA: 0x181D2B2F0 Slot: 13
	public override void set_Position(long value) { }
}

// Namespace: System.Xml
internal class XmlCachedStream : MemoryStream // TypeDefIndex: 6758
{
	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0x1D1E110 Offset: 0x1D1C710 VA: 0x181D1E110
	internal void .ctor(Uri uri, Stream stream) { }
}

// Namespace: System.Xml
internal class UTF16Decoder : Decoder // TypeDefIndex: 6759
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x1D18CE0 Offset: 0x1D172E0 VA: 0x181D18CE0
	public void .ctor(bool bigEndian) { }

	// RVA: 0x1380FB0 Offset: 0x137F5B0 VA: 0x181380FB0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1D189F0 Offset: 0x1D16FF0 VA: 0x181D189F0 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x1D18AE0 Offset: 0x1D170E0 VA: 0x181D18AE0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1D18780 Offset: 0x1D16D80 VA: 0x181D18780 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

// Namespace: System.Xml
internal class SafeAsciiDecoder : Decoder // TypeDefIndex: 6760
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x1CB7270 Offset: 0x1CB5870 VA: 0x181CB7270 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1D117A0 Offset: 0x1D0FDA0 VA: 0x181D117A0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1D116F0 Offset: 0x1D0FCF0 VA: 0x181D116F0 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

// Namespace: System.Xml
internal class Ucs4Encoding : Encoding // TypeDefIndex: 6761
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Properties
	public override string WebName { get; }
	public override int CodePage { get; }
	internal static Encoding UCS4_Littleendian { get; }
	internal static Encoding UCS4_Bigendian { get; }
	internal static Encoding UCS4_2143 { get; }
	internal static Encoding UCS4_3412 { get; }

	// Methods

	// RVA: 0x1531350 Offset: 0x152F950 VA: 0x181531350 Slot: 9
	public override string get_WebName() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 30
	public override Decoder GetDecoder() { }

	// RVA: 0x1D1A100 Offset: 0x1D18700 VA: 0x181D1A100 Slot: 12
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 18
	public override byte[] GetBytes(string s) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 17
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 32
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1D1A170 Offset: 0x1D18770 VA: 0x181D1A170 Slot: 22
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1D1A1A0 Offset: 0x1D187A0 VA: 0x181D1A1A0 Slot: 26
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1D1A1E0 Offset: 0x1D187E0 VA: 0x181D1A1E0 Slot: 33
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 29
	public override int get_CodePage() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 31
	public override Encoder GetEncoder() { }

	// RVA: 0x1D1A470 Offset: 0x1D18A70 VA: 0x181D1A470
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0x1D1A3A0 Offset: 0x1D189A0 VA: 0x181D1A3A0
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0x1D1A200 Offset: 0x1D18800 VA: 0x181D1A200
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0x1D1A2D0 Offset: 0x1D188D0 VA: 0x181D1A2D0
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0x1D1A1F0 Offset: 0x1D187F0 VA: 0x181D1A1F0
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding1234 : Ucs4Encoding // TypeDefIndex: 6762
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x1D19C60 Offset: 0x1D18260 VA: 0x181D19C60
	public void .ctor() { }

	// RVA: 0x1D19D10 Offset: 0x1D18310 VA: 0x181D19D10 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x1D19C00 Offset: 0x1D18200 VA: 0x181D19C00 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding4321 : Ucs4Encoding // TypeDefIndex: 6763
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x1D1A020 Offset: 0x1D18620 VA: 0x181D1A020
	public void .ctor() { }

	// RVA: 0x1D1A0D0 Offset: 0x1D186D0 VA: 0x181D1A0D0 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x1D19FC0 Offset: 0x1D185C0 VA: 0x181D19FC0 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding2143 : Ucs4Encoding // TypeDefIndex: 6764
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x1D19DA0 Offset: 0x1D183A0 VA: 0x181D19DA0
	public void .ctor() { }

	// RVA: 0x1D19E50 Offset: 0x1D18450 VA: 0x181D19E50 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x1D19D40 Offset: 0x1D18340 VA: 0x181D19D40 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding3412 : Ucs4Encoding // TypeDefIndex: 6765
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x1D19EE0 Offset: 0x1D184E0 VA: 0x181D19EE0
	public void .ctor() { }

	// RVA: 0x1D19F90 Offset: 0x1D18590 VA: 0x181D19F90 Slot: 8
	public override string get_EncodingName() { }

	// RVA: 0x1D19E80 Offset: 0x1D18480 VA: 0x181D19E80 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 6766
{
	// Fields
	internal byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x1D199E0 Offset: 0x1D17FE0 VA: 0x181D199E0 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x1D199F0 Offset: 0x1D17FF0 VA: 0x181D199F0 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1D197B0 Offset: 0x1D17DB0 VA: 0x181D197B0 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x1D19B90 Offset: 0x1D18190 VA: 0x181D19B90
	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	// RVA: 0x1D18FA0 Offset: 0x1D175A0 VA: 0x181D18FA0
	protected void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder4321 : Ucs4Decoder // TypeDefIndex: 6767
{
	// Methods

	// RVA: 0x1D19520 Offset: 0x1D17B20 VA: 0x181D19520 Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1D18FA0 Offset: 0x1D175A0 VA: 0x181D18FA0
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder1234 : Ucs4Decoder // TypeDefIndex: 6768
{
	// Methods

	// RVA: 0x1D18D10 Offset: 0x1D17310 VA: 0x181D18D10 Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1D18FA0 Offset: 0x1D175A0 VA: 0x181D18FA0
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder2143 : Ucs4Decoder // TypeDefIndex: 6769
{
	// Methods

	// RVA: 0x1D19000 Offset: 0x1D17600 VA: 0x181D19000 Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1D18FA0 Offset: 0x1D175A0 VA: 0x181D18FA0
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder3412 : Ucs4Decoder // TypeDefIndex: 6770
{
	// Methods

	// RVA: 0x1D19290 Offset: 0x1D17890 VA: 0x181D19290 Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1D18FA0 Offset: 0x1D175A0 VA: 0x181D18FA0
	public void .ctor() { }
}

// Namespace: System.Xml
[Serializable]
public class XmlException : SystemException // TypeDefIndex: 6771
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private int lineNumber; // 0xA0
	private int linePosition; // 0xA4
	[OptionalField]
	private string sourceUri; // 0xA8
	private string message; // 0xB0

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public override string Message { get; }
	internal string ResString { get; }

	// Methods

	// RVA: 0x1D28220 Offset: 0x1D26820 VA: 0x181D28220
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D27FA0 Offset: 0x1D265A0 VA: 0x181D27FA0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D286C0 Offset: 0x1D26CC0 VA: 0x181D286C0
	public void .ctor() { }

	// RVA: 0x1D28690 Offset: 0x1D26C90 VA: 0x181D28690
	public void .ctor(string message) { }

	// RVA: 0x1D281F0 Offset: 0x1D267F0 VA: 0x181D281F0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1D280F0 Offset: 0x1D266F0 VA: 0x181D280F0
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1D28A90 Offset: 0x1D27090 VA: 0x181D28A90
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1D28CA0 Offset: 0x1D272A0 VA: 0x181D28CA0
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1D28F20 Offset: 0x1D27520 VA: 0x181D28F20
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1D28E60 Offset: 0x1D27460 VA: 0x181D28E60
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x1D28930 Offset: 0x1D26F30 VA: 0x181D28930
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x1D28820 Offset: 0x1D26E20 VA: 0x181D28820
	internal void .ctor(string res, string arg, Exception innerException, IXmlLineInfo lineInfo) { }

	// RVA: 0x1D28DA0 Offset: 0x1D273A0 VA: 0x181D28DA0
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x1D28FD0 Offset: 0x1D275D0 VA: 0x181D28FD0
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x1D28120 Offset: 0x1D26720 VA: 0x181D28120
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x1D28720 Offset: 0x1D26D20 VA: 0x181D28720
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1D287F0 Offset: 0x1D26DF0 VA: 0x181D287F0
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x1D28A50 Offset: 0x1D27050 VA: 0x181D28A50
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1D286F0 Offset: 0x1D26CF0 VA: 0x181D286F0
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1D28CD0 Offset: 0x1D272D0 VA: 0x181D28CD0
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1D27E90 Offset: 0x1D26490 VA: 0x181D27E90
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x1D27CD0 Offset: 0x1D262D0 VA: 0x181D27CD0
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x1D27970 Offset: 0x1D25F70 VA: 0x181D27970
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x1D27C70 Offset: 0x1D26270 VA: 0x181D27C70
	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

	// RVA: 0x1D279E0 Offset: 0x1D25FE0 VA: 0x181D279E0
	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	// RVA: 0x1BD25D0 Offset: 0x1BD0BD0 VA: 0x181BD25D0
	public int get_LineNumber() { }

	// RVA: 0x53C820 Offset: 0x53AE20 VA: 0x18053C820
	public int get_LinePosition() { }

	// RVA: 0x1D29090 Offset: 0x1D27690 VA: 0x181D29090 Slot: 5
	public override string get_Message() { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	internal string get_ResString() { }
}

// Namespace: System.Xml
public abstract class XmlNameTable // TypeDefIndex: 6772
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string Get(string array);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string Add(char[] array, int offset, int length);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string Add(string array);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml
public enum XmlNamespaceScope // TypeDefIndex: 6773
{
	// Fields
	public int value__; // 0x0
	public const XmlNamespaceScope All = 0;
	public const XmlNamespaceScope ExcludeXml = 1;
	public const XmlNamespaceScope Local = 2;
}

// Namespace: System.Xml
public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable // TypeDefIndex: 6775
{
	// Fields
	private XmlNamespaceManager.NamespaceDeclaration[] nsdecls; // 0x10
	private int lastDecl; // 0x18
	private XmlNameTable nameTable; // 0x20
	private int scopeId; // 0x28
	private Dictionary<string, int> hashTable; // 0x30
	private bool useHashtable; // 0x38
	private string xml; // 0x40
	private string xmlNs; // 0x48

	// Properties
	public virtual XmlNameTable NameTable { get; }
	public virtual string DefaultNamespace { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1D29DB0 Offset: 0x1D283B0 VA: 0x181D29DB0
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 8
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x1D2A020 Offset: 0x1D28620 VA: 0x181D2A020 Slot: 9
	public virtual string get_DefaultNamespace() { }

	// RVA: 0xA5BAA0 Offset: 0xA5A0A0 VA: 0x180A5BAA0 Slot: 10
	public virtual void PushScope() { }

	// RVA: 0x1D29B30 Offset: 0x1D28130 VA: 0x181D29B30 Slot: 11
	public virtual bool PopScope() { }

	// RVA: 0x1D290B0 Offset: 0x1D276B0 VA: 0x181D290B0 Slot: 12
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x1D29C10 Offset: 0x1D28210 VA: 0x181D29C10 Slot: 13
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x1D29530 Offset: 0x1D27B30 VA: 0x181D29530 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1D296B0 Offset: 0x1D27CB0 VA: 0x181D296B0 Slot: 15
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1D29A10 Offset: 0x1D28010 VA: 0x181D29A10 Slot: 16
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x1D29850 Offset: 0x1D27E50 VA: 0x181D29850
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x1D29A60 Offset: 0x1D28060 VA: 0x181D29A60 Slot: 17
	public virtual string LookupPrefix(string uri) { }
}

// Namespace: System.Xml
public enum XmlNodeType // TypeDefIndex: 6776
{
	// Fields
	public int value__; // 0x0
	public const XmlNodeType None = 0;
	public const XmlNodeType Element = 1;
	public const XmlNodeType Attribute = 2;
	public const XmlNodeType Text = 3;
	public const XmlNodeType CDATA = 4;
	public const XmlNodeType EntityReference = 5;
	public const XmlNodeType Entity = 6;
	public const XmlNodeType ProcessingInstruction = 7;
	public const XmlNodeType Comment = 8;
	public const XmlNodeType Document = 9;
	public const XmlNodeType DocumentType = 10;
	public const XmlNodeType DocumentFragment = 11;
	public const XmlNodeType Notation = 12;
	public const XmlNodeType Whitespace = 13;
	public const XmlNodeType SignificantWhitespace = 14;
	public const XmlNodeType EndElement = 15;
	public const XmlNodeType EndEntity = 16;
	public const XmlNodeType XmlDeclaration = 17;
}

// Namespace: System.Xml
[Serializable]
public class XmlQualifiedName // TypeDefIndex: 6778
{
	// Fields
	private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private string name; // 0x10
	private string ns; // 0x18
	private int hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Properties
	public string Namespace { get; }
	public string Name { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1D2AC50 Offset: 0x1D29250 VA: 0x181D2AC50
	public void .ctor() { }

	// RVA: 0x1D2AB20 Offset: 0x1D29120 VA: 0x181D2AB20
	public void .ctor(string name) { }

	// RVA: 0x1D2ABC0 Offset: 0x1D291C0 VA: 0x181D2ABC0
	public void .ctor(string name, string ns) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Namespace() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Name() { }

	// RVA: 0x1D2A530 Offset: 0x1D28B30 VA: 0x181D2A530 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D2ACF0 Offset: 0x1D292F0 VA: 0x181D2ACF0
	public bool get_IsEmpty() { }

	// RVA: 0x1D2A890 Offset: 0x1D28E90 VA: 0x181D2A890 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D2A210 Offset: 0x1D28810 VA: 0x181D2A210 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1D2AD30 Offset: 0x1D29330 VA: 0x181D2AD30
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x1D2ADA0 Offset: 0x1D293A0 VA: 0x181D2ADA0
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x1D2A8F0 Offset: 0x1D28EF0 VA: 0x181D2A8F0
	public static string ToString(string name, string ns) { }

	// RVA: 0x1D2A330 Offset: 0x1D28930 VA: 0x181D2A330
	private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0xA4D9C0 Offset: 0xA4BFC0 VA: 0x180A4D9C0
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	// RVA: 0x1D2A630 Offset: 0x1D28C30 VA: 0x181D2A630
	internal void Init(string name, string ns) { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void SetNamespace(string ns) { }

	// RVA: 0x1D2A960 Offset: 0x1D28F60 VA: 0x181D2A960
	internal void Verify() { }

	// RVA: 0x1D2A110 Offset: 0x1D28710 VA: 0x181D2A110
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x1D2A670 Offset: 0x1D28C70 VA: 0x181D2A670
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0x1D2A190 Offset: 0x1D28790 VA: 0x181D2A190
	internal XmlQualifiedName Clone() { }

	// RVA: 0x1D2A9F0 Offset: 0x1D28FF0 VA: 0x181D2A9F0
	private static void .cctor() { }
}

// Namespace: System.Xml
public abstract class XmlResolver // TypeDefIndex: 6779
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

	// RVA: 0x1D2B360 Offset: 0x1D29960 VA: 0x181D2B360 Slot: 5
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x1D2B550 Offset: 0x1D29B50 VA: 0x181D2B550 Slot: 6
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x1D2B320 Offset: 0x1D29920 VA: 0x181D2B320 Slot: 7
	public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml
public class XmlUrlResolver : XmlResolver // TypeDefIndex: 6781
{
	// Fields
	private static object s_DownloadManager; // 0x0
	private ICredentials _credentials; // 0x10
	private IWebProxy _proxy; // 0x18
	private RequestCachePolicy _cachePolicy; // 0x20

	// Properties
	private static XmlDownloadManager DownloadManager { get; }

	// Methods

	// RVA: 0x1D2C530 Offset: 0x1D2AB30 VA: 0x181D2C530
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1D2C2E0 Offset: 0x1D2A8E0 VA: 0x181D2C2E0 Slot: 4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x1D2C520 Offset: 0x1D2AB20 VA: 0x181D2C520 Slot: 5
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachine(typeof(XmlUrlResolver.<GetEntityAsync>d__15))]
	// RVA: 0x1D2C190 Offset: 0x1D2A790 VA: 0x181D2C190 Slot: 7
	public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }
}

// Namespace: System.Xml
internal static class BinaryCompatibility // TypeDefIndex: 6782
{
	// Properties
	public static bool TargetsAtLeast_Desktop_V4_5_2 { get; }

	// Methods

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	public static bool get_TargetsAtLeast_Desktop_V4_5_2() { }
}

// Namespace: System.Xml
internal static class Res // TypeDefIndex: 6783
{
	// Methods

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static string GetString(string name) { }

	// RVA: 0x1D116D0 Offset: 0x1D0FCD0 VA: 0x181D116D0
	public static string GetString(string name, object[] args) { }
}

