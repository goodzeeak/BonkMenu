// Namespace: System.Data.SqlTypes
internal static class SQLResource // TypeDefIndex: 8770
{
	// Properties
	internal static string NullString { get; }
	internal static string ArithOverflowMessage { get; }
	internal static string DivideByZeroMessage { get; }
	internal static string NullValueMessage { get; }
	internal static string TruncationMessage { get; }
	internal static string DateTimeOverflowMessage { get; }
	internal static string ConcatDiffCollationMessage { get; }
	internal static string CompareDiffCollationMessage { get; }
	internal static string ConversionOverflowMessage { get; }
	internal static string TimeZoneSpecifiedMessage { get; }
	internal static string InvalidPrecScaleMessage { get; }
	internal static string FormatMessage { get; }

	// Methods

	// RVA: 0x1B34650 Offset: 0x1B32C50 VA: 0x181B34650
	internal static string get_NullString() { }

	// RVA: 0x1B344D0 Offset: 0x1B32AD0 VA: 0x181B344D0
	internal static string get_ArithOverflowMessage() { }

	// RVA: 0x1B345C0 Offset: 0x1B32BC0 VA: 0x181B345C0
	internal static string get_DivideByZeroMessage() { }

	// RVA: 0x1B34680 Offset: 0x1B32C80 VA: 0x181B34680
	internal static string get_NullValueMessage() { }

	// RVA: 0x1B346E0 Offset: 0x1B32CE0 VA: 0x181B346E0
	internal static string get_TruncationMessage() { }

	// RVA: 0x1B34590 Offset: 0x1B32B90 VA: 0x181B34590
	internal static string get_DateTimeOverflowMessage() { }

	// RVA: 0x1B34530 Offset: 0x1B32B30 VA: 0x181B34530
	internal static string get_ConcatDiffCollationMessage() { }

	// RVA: 0x1B34500 Offset: 0x1B32B00 VA: 0x181B34500
	internal static string get_CompareDiffCollationMessage() { }

	// RVA: 0x1B34560 Offset: 0x1B32B60 VA: 0x181B34560
	internal static string get_ConversionOverflowMessage() { }

	// RVA: 0x1B346B0 Offset: 0x1B32CB0 VA: 0x181B346B0
	internal static string get_TimeZoneSpecifiedMessage() { }

	// RVA: 0x1B34620 Offset: 0x1B32C20 VA: 0x181B34620
	internal static string get_InvalidPrecScaleMessage() { }

	// RVA: 0x1B345F0 Offset: 0x1B32BF0 VA: 0x181B345F0
	internal static string get_FormatMessage() { }

	// RVA: 0x1B343D0 Offset: 0x1B329D0 VA: 0x181B343D0
	internal static string InvalidOpStreamClosed(string method) { }

	// RVA: 0x1B34490 Offset: 0x1B32A90 VA: 0x181B34490
	internal static string InvalidOpStreamNonWritable(string method) { }

	// RVA: 0x1B34410 Offset: 0x1B32A10 VA: 0x181B34410
	internal static string InvalidOpStreamNonReadable(string method) { }

	// RVA: 0x1B34450 Offset: 0x1B32A50 VA: 0x181B34450
	internal static string InvalidOpStreamNonSeekable(string method) { }
}

// Namespace: System.Data.SqlTypes
public interface INullable // TypeDefIndex: 8771
{
	// Properties
	public abstract bool IsNull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsNull();
}

// Namespace: System.Data.SqlTypes
[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8772
{
	// Fields
	private byte[] _value; // 0x0
	public static readonly SqlBinary Null; // 0x0

	// Properties
	public bool IsNull { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x1B35450 Offset: 0x1B33A50 VA: 0x181B35450
	private void .ctor(bool fNull) { }

	// RVA: 0x1B35460 Offset: 0x1B33A60 VA: 0x181B35460
	public void .ctor(byte[] value) { }

	// RVA: 0x13F37F0 Offset: 0x13F1DF0 VA: 0x1813F37F0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B354F0 Offset: 0x1B33AF0 VA: 0x181B354F0
	public byte[] get_Value() { }

	// RVA: 0x1B357C0 Offset: 0x1B33DC0 VA: 0x181B357C0
	public static SqlBinary op_Implicit(byte[] x) { }

	// RVA: 0x1B352F0 Offset: 0x1B338F0 VA: 0x181B352F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B34F50 Offset: 0x1B33550 VA: 0x181B34F50
	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	// RVA: 0x1B355C0 Offset: 0x1B33BC0 VA: 0x181B355C0
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1B35850 Offset: 0x1B33E50 VA: 0x181B35850
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1B356C0 Offset: 0x1B33CC0 VA: 0x181B356C0
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1B34A50 Offset: 0x1B33050 VA: 0x181B34A50 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B34710 Offset: 0x1B32D10 VA: 0x181B34710
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x1B34B60 Offset: 0x1B33160 VA: 0x181B34B60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B34EE0 Offset: 0x1B334E0 VA: 0x181B34EE0
	internal static int HashByteArray(byte[] rgbValue, int length) { }

	// RVA: 0x1B34D90 Offset: 0x1B33390 VA: 0x181B34D90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B35070 Offset: 0x1B33670 VA: 0x181B35070 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B351D0 Offset: 0x1B337D0 VA: 0x181B351D0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B34E70 Offset: 0x1B33470 VA: 0x181B34E70
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B353E0 Offset: 0x1B339E0 VA: 0x181B353E0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlBoolean : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8773
{
	// Fields
	private byte m_value; // 0x0
	public static readonly SqlBoolean True; // 0x0
	public static readonly SqlBoolean False; // 0x1
	public static readonly SqlBoolean Null; // 0x2
	public static readonly SqlBoolean Zero; // 0x3
	public static readonly SqlBoolean One; // 0x4

	// Properties
	public bool IsNull { get; }
	public bool Value { get; }
	public bool IsTrue { get; }
	public bool IsFalse { get; }
	public byte ByteValue { get; }

	// Methods

	// RVA: 0x1B36530 Offset: 0x1B34B30 VA: 0x181B36530
	public void .ctor(bool value) { }

	// RVA: 0x1B364B0 Offset: 0x1B34AB0 VA: 0x181B364B0
	public void .ctor(int value) { }

	// RVA: 0x1B36510 Offset: 0x1B34B10 VA: 0x181B36510
	private void .ctor(int value, bool fNull) { }

	// RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B365F0 Offset: 0x1B34BF0 VA: 0x181B365F0
	public bool get_Value() { }

	// RVA: 0x1B365E0 Offset: 0x1B34BE0 VA: 0x181B365E0
	public bool get_IsTrue() { }

	// RVA: 0x1B365D0 Offset: 0x1B34BD0 VA: 0x181B365D0
	public bool get_IsFalse() { }

	// RVA: 0x1B368C0 Offset: 0x1B34EC0 VA: 0x181B368C0
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0x1B368D0 Offset: 0x1B34ED0 VA: 0x181B368D0
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0x1B36650 Offset: 0x1B34C50 VA: 0x181B36650
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1B36730 Offset: 0x1B34D30 VA: 0x181B36730
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1B36540 Offset: 0x1B34B40 VA: 0x181B36540
	public byte get_ByteValue() { }

	// RVA: 0x1B362C0 Offset: 0x1B348C0 VA: 0x181B362C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B36810 Offset: 0x1B34E10 VA: 0x181B36810
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1B35950 Offset: 0x1B33F50 VA: 0x181B35950
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1B35F90 Offset: 0x1B34590 VA: 0x181B35F90
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1B35B80 Offset: 0x1B34180 VA: 0x181B35B80 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B35A60 Offset: 0x1B34060 VA: 0x181B35A60
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x1B35C90 Offset: 0x1B34290 VA: 0x181B35C90 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B35E40 Offset: 0x1B34440 VA: 0x181B35E40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B360A0 Offset: 0x1B346A0 VA: 0x181B360A0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B361C0 Offset: 0x1B347C0 VA: 0x181B361C0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B35F20 Offset: 0x1B34520 VA: 0x181B35F20
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B363C0 Offset: 0x1B349C0 VA: 0x181B363C0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8774
{
	// Fields
	private bool m_fNotNull; // 0x0
	private byte m_value; // 0x1
	private static readonly int s_iBitNotByteMax; // 0x0
	public static readonly SqlByte Null; // 0x4
	public static readonly SqlByte Zero; // 0x6
	public static readonly SqlByte MinValue; // 0x8
	public static readonly SqlByte MaxValue; // 0xA

	// Properties
	public bool IsNull { get; }
	public byte Value { get; }

	// Methods

	// RVA: 0x1B37460 Offset: 0x1B35A60 VA: 0x181B37460
	private void .ctor(bool fNull) { }

	// RVA: 0x12B5150 Offset: 0x12B3750 VA: 0x1812B5150
	public void .ctor(byte value) { }

	// RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B37470 Offset: 0x1B35A70 VA: 0x181B37470
	public byte get_Value() { }

	// RVA: 0x1B37A50 Offset: 0x1B36050 VA: 0x181B37A50
	public static SqlByte op_Implicit(byte x) { }

	// RVA: 0x1B37320 Offset: 0x1B35920 VA: 0x181B37320 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B374D0 Offset: 0x1B35AD0 VA: 0x181B374D0
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0x1B37C60 Offset: 0x1B36260 VA: 0x181B37C60
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0x1B37B30 Offset: 0x1B36130 VA: 0x181B37B30
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0x1B37600 Offset: 0x1B35C00 VA: 0x181B37600
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0x1B377F0 Offset: 0x1B35DF0 VA: 0x181B377F0
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0x1B37720 Offset: 0x1B35D20 VA: 0x181B37720
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0x1B37A60 Offset: 0x1B36060 VA: 0x181B37A60
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1B37980 Offset: 0x1B35F80 VA: 0x181B37980
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1B36FA0 Offset: 0x1B355A0 VA: 0x181B36FA0
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1B36F40 Offset: 0x1B35540 VA: 0x181B36F40
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1B37240 Offset: 0x1B35840 VA: 0x181B37240
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1B372B0 Offset: 0x1B358B0 VA: 0x181B372B0
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1B36AE0 Offset: 0x1B350E0 VA: 0x181B36AE0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B36920 Offset: 0x1B34F20 VA: 0x181B36920
	public int CompareTo(SqlByte value) { }

	// RVA: 0x1B36BF0 Offset: 0x1B351F0 VA: 0x181B36BF0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B36E10 Offset: 0x1B35410 VA: 0x181B36E10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B37000 Offset: 0x1B35600 VA: 0x181B37000 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B37120 Offset: 0x1B35720 VA: 0x181B37120 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B36ED0 Offset: 0x1B354D0 VA: 0x181B36ED0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B373A0 Offset: 0x1B359A0 VA: 0x181B373A0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal enum SqlBytesCharsState // TypeDefIndex: 8775
{
	// Fields
	public int value__; // 0x0
	public const SqlBytesCharsState Null = 0;
	public const SqlBytesCharsState Buffer = 1;
	public const SqlBytesCharsState Stream = 3;
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[DefaultMember("Item")]
[Serializable]
public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 8776
{
	// Fields
	internal byte[] _rgbBuf; // 0x10
	private long _lCurLen; // 0x18
	internal Stream _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private byte[] _rgbWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public byte[] Buffer { get; }
	public long Length { get; }
	public byte[] Value { get; }
	public static SqlBytes Null { get; }

	// Methods

	// RVA: 0x1B4CD30 Offset: 0x1B4B330 VA: 0x181B4CD30
	public void .ctor() { }

	// RVA: 0x1B4CE00 Offset: 0x1B4B400 VA: 0x181B4CE00
	public void .ctor(byte[] buffer) { }

	// RVA: 0x1B4CD70 Offset: 0x1B4B370 VA: 0x181B4CD70
	public void .ctor(SqlBinary value) { }

	// RVA: 0x1B4D020 Offset: 0x1B4B620 VA: 0x181B4D020 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B4CE90 Offset: 0x1B4B490 VA: 0x181B4CE90
	public byte[] get_Buffer() { }

	// RVA: 0x1B4D030 Offset: 0x1B4B630 VA: 0x181B4D030
	public long get_Length() { }

	// RVA: 0x1B4D110 Offset: 0x1B4B710 VA: 0x181B4D110
	public byte[] get_Value() { }

	// RVA: 0x1B4C800 Offset: 0x1B4AE00 VA: 0x181B4C800
	public void SetNull() { }

	// RVA: 0x1B4C5A0 Offset: 0x1B4ABA0 VA: 0x181B4C5A0
	private void CopyStreamToBuffer() { }

	// RVA: 0x1B4C720 Offset: 0x1B4AD20 VA: 0x181B4C720
	internal bool FStream() { }

	// RVA: 0x1B4C7A0 Offset: 0x1B4ADA0 VA: 0x181B4C7A0
	private void SetBuffer(byte[] buffer) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B4C880 Offset: 0x1B4AE80 VA: 0x181B4C880 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x1B4CA40 Offset: 0x1B4B040 VA: 0x181B4CA40 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B4C730 Offset: 0x1B4AD30 VA: 0x181B4C730
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B4C840 Offset: 0x1B4AE40 VA: 0x181B4C840 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B4D0C0 Offset: 0x1B4B6C0 VA: 0x181B4D0C0
	public static SqlBytes get_Null() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[DefaultMember("Item")]
[Serializable]
public sealed class SqlChars : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 8777
{
	// Fields
	internal char[] _rgchBuf; // 0x10
	private long _lCurLen; // 0x18
	internal SqlStreamChars _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private char[] _rgchWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public char[] Buffer { get; }
	public long Length { get; }
	public char[] Value { get; }
	public static SqlChars Null { get; }

	// Methods

	// RVA: 0x1B4CD30 Offset: 0x1B4B330 VA: 0x181B4CD30
	public void .ctor() { }

	// RVA: 0x1B4CE00 Offset: 0x1B4B400 VA: 0x181B4CE00
	public void .ctor(char[] buffer) { }

	// RVA: 0x1B4D9D0 Offset: 0x1B4BFD0 VA: 0x181B4D9D0
	public void .ctor(SqlString value) { }

	// RVA: 0x1B4D020 Offset: 0x1B4B620 VA: 0x181B4D020 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B4DA70 Offset: 0x1B4C070 VA: 0x181B4DA70
	public char[] get_Buffer() { }

	// RVA: 0x1B4DC00 Offset: 0x1B4C200 VA: 0x181B4DC00
	public long get_Length() { }

	// RVA: 0x1B4DCE0 Offset: 0x1B4C2E0 VA: 0x181B4DCE0
	public char[] get_Value() { }

	// RVA: 0x1B4C800 Offset: 0x1B4AE00 VA: 0x181B4C800
	public void SetNull() { }

	// RVA: 0x1B4C720 Offset: 0x1B4AD20 VA: 0x181B4C720
	internal bool FStream() { }

	// RVA: 0x1B4D350 Offset: 0x1B4B950 VA: 0x181B4D350
	private void CopyStreamToBuffer() { }

	// RVA: 0x1B4C7A0 Offset: 0x1B4ADA0 VA: 0x181B4C7A0
	private void SetBuffer(char[] buffer) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B4D580 Offset: 0x1B4BB80 VA: 0x181B4D580 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x1B4D6F0 Offset: 0x1B4BCF0 VA: 0x181B4D6F0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B4D4D0 Offset: 0x1B4BAD0 VA: 0x181B4D4D0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B4D540 Offset: 0x1B4BB40 VA: 0x181B4D540 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B4DC90 Offset: 0x1B4C290 VA: 0x181B4DC90
	public static SqlChars get_Null() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDateTime : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8778
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_day; // 0x4
	private int m_time; // 0x8
	private static readonly double s_SQLTicksPerMillisecond; // 0x0
	public static readonly int SQLTicksPerSecond; // 0x8
	public static readonly int SQLTicksPerMinute; // 0xC
	public static readonly int SQLTicksPerHour; // 0x10
	private static readonly int s_SQLTicksPerDay; // 0x14
	private static readonly long s_ticksPerSecond; // 0x18
	private static readonly DateTime s_SQLBaseDate; // 0x20
	private static readonly long s_SQLBaseDateTicks; // 0x28
	private static readonly int s_minYear; // 0x30
	private static readonly int s_maxYear; // 0x34
	private static readonly int s_minDay; // 0x38
	private static readonly int s_maxDay; // 0x3C
	private static readonly int s_minTime; // 0x40
	private static readonly int s_maxTime; // 0x44
	private static readonly int s_dayBase; // 0x48
	private static readonly int[] s_daysToMonth365; // 0x50
	private static readonly int[] s_daysToMonth366; // 0x58
	private static readonly DateTime s_minDateTime; // 0x60
	private static readonly DateTime s_maxDateTime; // 0x68
	private static readonly TimeSpan s_minTimeSpan; // 0x70
	private static readonly TimeSpan s_maxTimeSpan; // 0x78
	private static readonly string s_ISO8601_DateTimeFormat; // 0x80
	private static readonly string[] s_dateTimeFormats; // 0x88
	public static readonly SqlDateTime MinValue; // 0x90
	public static readonly SqlDateTime MaxValue; // 0x9C
	public static readonly SqlDateTime Null; // 0xA8

	// Properties
	public bool IsNull { get; }
	public DateTime Value { get; }
	public int DayTicks { get; }
	public int TimeTicks { get; }

	// Methods

	// RVA: 0x1B4F840 Offset: 0x1B4DE40 VA: 0x181B4F840
	private void .ctor(bool fNull) { }

	// RVA: 0x1B4F7D0 Offset: 0x1B4DDD0 VA: 0x181B4F7D0
	public void .ctor(DateTime value) { }

	// RVA: 0x1B4F850 Offset: 0x1B4DE50 VA: 0x181B4F850
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B4F120 Offset: 0x1B4D720 VA: 0x181B4F120
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0x1B4EF40 Offset: 0x1B4D540 VA: 0x181B4EF40
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0x1B4E590 Offset: 0x1B4CB90 VA: 0x181B4E590
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0x1B4E460 Offset: 0x1B4CA60 VA: 0x181B4E460
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0x1B4FA40 Offset: 0x1B4E040 VA: 0x181B4FA40
	public DateTime get_Value() { }

	// RVA: 0x1B4F980 Offset: 0x1B4DF80 VA: 0x181B4F980
	public int get_DayTicks() { }

	// RVA: 0x1B4F9E0 Offset: 0x1B4DFE0 VA: 0x181B4F9E0
	public int get_TimeTicks() { }

	// RVA: 0x1B4FCC0 Offset: 0x1B4E2C0 VA: 0x181B4FCC0
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0x1B4F050 Offset: 0x1B4D650 VA: 0x181B4F050 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B4FAF0 Offset: 0x1B4E0F0 VA: 0x181B4FAF0
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1B4FD40 Offset: 0x1B4E340 VA: 0x181B4FD40
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1B4FBD0 Offset: 0x1B4E1D0 VA: 0x181B4FBD0
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1B4EA30 Offset: 0x1B4D030 VA: 0x181B4EA30
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1B4E8B0 Offset: 0x1B4CEB0 VA: 0x181B4E8B0
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1B4DF20 Offset: 0x1B4C520 VA: 0x181B4DF20 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B4E050 Offset: 0x1B4C650 VA: 0x181B4E050
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0x1B4E220 Offset: 0x1B4C820 VA: 0x181B4E220 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B4E7A0 Offset: 0x1B4CDA0 VA: 0x181B4E7A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B4EBB0 Offset: 0x1B4D1B0 VA: 0x181B4EBB0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B4EDE0 Offset: 0x1B4D3E0 VA: 0x181B4EDE0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B4E840 Offset: 0x1B4CE40 VA: 0x181B4E840
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B4F1A0 Offset: 0x1B4D7A0 VA: 0x181B4F1A0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8779
{
	// Fields
	internal byte _bStatus; // 0x0
	internal byte _bLen; // 0x1
	internal byte _bPrec; // 0x2
	internal byte _bScale; // 0x3
	internal uint _data1; // 0x4
	internal uint _data2; // 0x8
	internal uint _data3; // 0xC
	internal uint _data4; // 0x10
	private static readonly byte s_NUMERIC_MAX_PRECISION; // 0x0
	public static readonly byte MaxPrecision; // 0x1
	public static readonly byte MaxScale; // 0x2
	private static readonly byte s_bNullMask; // 0x3
	private static readonly byte s_bIsNull; // 0x4
	private static readonly byte s_bNotNull; // 0x5
	private static readonly byte s_bReverseNullMask; // 0x6
	private static readonly byte s_bSignMask; // 0x7
	private static readonly byte s_bPositive; // 0x8
	private static readonly byte s_bNegative; // 0x9
	private static readonly byte s_bReverseSignMask; // 0xA
	private static readonly uint s_uiZero; // 0xC
	private static readonly int s_cNumeMax; // 0x10
	private static readonly long s_lInt32Base; // 0x18
	private static readonly ulong s_ulInt32Base; // 0x20
	private static readonly ulong s_ulInt32BaseForMod; // 0x28
	internal static readonly ulong s_llMax; // 0x30
	private static readonly uint s_ulBase10; // 0x38
	private static readonly double s_DUINT_BASE; // 0x40
	private static readonly double s_DUINT_BASE2; // 0x48
	private static readonly double s_DUINT_BASE3; // 0x50
	private static readonly double s_DMAX_NUME; // 0x58
	private static readonly uint s_DBL_DIG; // 0x60
	private static readonly byte s_cNumeDivScaleMin; // 0x64
	private static readonly uint[] s_rgulShiftBase; // 0x68
	private static readonly uint[] s_decimalHelpersLo; // 0x70
	private static readonly uint[] s_decimalHelpersMid; // 0x78
	private static readonly uint[] s_decimalHelpersHi; // 0x80
	private static readonly uint[] s_decimalHelpersHiHi; // 0x88
	private static readonly byte[] s_rgCLenFromPrec; // 0x90
	private static readonly uint s_ulT1; // 0x98
	private static readonly uint s_ulT2; // 0x9C
	private static readonly uint s_ulT3; // 0xA0
	private static readonly uint s_ulT4; // 0xA4
	private static readonly uint s_ulT5; // 0xA8
	private static readonly uint s_ulT6; // 0xAC
	private static readonly uint s_ulT7; // 0xB0
	private static readonly uint s_ulT8; // 0xB4
	private static readonly uint s_ulT9; // 0xB8
	private static readonly ulong s_dwlT10; // 0xC0
	private static readonly ulong s_dwlT11; // 0xC8
	private static readonly ulong s_dwlT12; // 0xD0
	private static readonly ulong s_dwlT13; // 0xD8
	private static readonly ulong s_dwlT14; // 0xE0
	private static readonly ulong s_dwlT15; // 0xE8
	private static readonly ulong s_dwlT16; // 0xF0
	private static readonly ulong s_dwlT17; // 0xF8
	private static readonly ulong s_dwlT18; // 0x100
	private static readonly ulong s_dwlT19; // 0x108
	public static readonly SqlDecimal Null; // 0x110
	public static readonly SqlDecimal MinValue; // 0x124
	public static readonly SqlDecimal MaxValue; // 0x138

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }
	public bool IsPositive { get; }
	public byte Scale { get; }
	public int[] Data { get; }

	// Methods

	// RVA: 0x1B509A0 Offset: 0x1B4EFA0 VA: 0x181B509A0
	private byte CalculatePrecision() { }

	// RVA: 0x1B54660 Offset: 0x1B52C60 VA: 0x181B54660
	private bool VerifyPrecision(byte precision) { }

	// RVA: 0x1B55330 Offset: 0x1B53930 VA: 0x181B55330
	private void .ctor(bool fNull) { }

	// RVA: 0x1B55710 Offset: 0x1B53D10 VA: 0x181B55710
	public void .ctor(Decimal value) { }

	// RVA: 0x1B550B0 Offset: 0x1B536B0 VA: 0x181B550B0
	public void .ctor(int value) { }

	// RVA: 0x1B553A0 Offset: 0x1B539A0 VA: 0x181B553A0
	public void .ctor(long value) { }

	// RVA: 0x1B554A0 Offset: 0x1B53AA0 VA: 0x181B554A0
	private void .ctor(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	// RVA: 0x1B559D0 Offset: 0x1B53FD0 VA: 0x181B559D0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B55C30 Offset: 0x1B54230 VA: 0x181B55C30
	public Decimal get_Value() { }

	// RVA: 0x1B55A30 Offset: 0x1B54030 VA: 0x181B55A30
	public bool get_IsPositive() { }

	// RVA: 0x1B535A0 Offset: 0x1B51BA0 VA: 0x181B535A0
	private void SetPositive() { }

	// RVA: 0x1B53610 Offset: 0x1B51C10 VA: 0x181B53610
	private void SetSignBit(bool fPositive) { }

	// RVA: 0x1B55B40 Offset: 0x1B54140 VA: 0x181B55B40
	public byte get_Scale() { }

	// RVA: 0x1B55890 Offset: 0x1B53E90 VA: 0x181B55890
	public int[] get_Data() { }

	// RVA: 0x1B54240 Offset: 0x1B52840 VA: 0x181B54240 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B52E80 Offset: 0x1B51480 VA: 0x181B52E80
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x1B53C50 Offset: 0x1B52250 VA: 0x181B53C50
	public double ToDouble() { }

	// RVA: 0x1B53A90 Offset: 0x1B52090 VA: 0x181B53A90
	private Decimal ToDecimal() { }

	// RVA: 0x1B56E60 Offset: 0x1B55460 VA: 0x181B56E60
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0x1B56EA0 Offset: 0x1B554A0 VA: 0x181B56EA0
	public static SqlDecimal op_Implicit(long x) { }

	// RVA: 0x1B58450 Offset: 0x1B56A50 VA: 0x181B58450
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0x1B55CA0 Offset: 0x1B542A0 VA: 0x181B55CA0
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1B581F0 Offset: 0x1B567F0 VA: 0x181B581F0
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1B57570 Offset: 0x1B55B70 VA: 0x181B57570
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1B564A0 Offset: 0x1B54AA0 VA: 0x181B564A0
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1B570F0 Offset: 0x1B556F0 VA: 0x181B570F0
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0x1B56EF0 Offset: 0x1B554F0 VA: 0x181B56EF0
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0x1B572C0 Offset: 0x1B558C0 VA: 0x181B572C0
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0x1B56FD0 Offset: 0x1B555D0 VA: 0x181B56FD0
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0x1B571D0 Offset: 0x1B557D0 VA: 0x181B571D0
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0x1B548A0 Offset: 0x1B52EA0 VA: 0x181B548A0
	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	// RVA: 0x1B518E0 Offset: 0x1B4FEE0 VA: 0x181B518E0
	private bool FZero() { }

	// RVA: 0x1B51850 Offset: 0x1B4FE50 VA: 0x181B51850
	private bool FGt10_38() { }

	// RVA: 0x1B51890 Offset: 0x1B4FE90 VA: 0x181B51890
	private bool FGt10_38(uint[] rglData) { }

	// RVA: 0x1B50470 Offset: 0x1B4EA70 VA: 0x181B50470
	private static byte BGetPrecUI4(uint value) { }

	// RVA: 0x1B50610 Offset: 0x1B4EC10 VA: 0x181B50610
	private static byte BGetPrecUI8(ulong dwlVal) { }

	// RVA: 0x1B4FE30 Offset: 0x1B4E430 VA: 0x181B4FE30
	private void AddULong(uint ulAdd) { }

	// RVA: 0x1B52BD0 Offset: 0x1B511D0 VA: 0x181B52BD0
	private void MultByULong(uint uiMultiplier) { }

	// RVA: 0x1B51290 Offset: 0x1B4F890 VA: 0x181B51290
	private uint DivByULong(uint iDivisor) { }

	// RVA: 0x1B500B0 Offset: 0x1B4E6B0 VA: 0x181B500B0
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0x1B51B60 Offset: 0x1B50160 VA: 0x181B51B60
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0x1B52A30 Offset: 0x1B51030 VA: 0x181B52A30
	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	// RVA: 0x1B52BA0 Offset: 0x1B511A0 VA: 0x181B52BA0
	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	// RVA: 0x1B52B60 Offset: 0x1B51160 VA: 0x181B52B60
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x1B52A90 Offset: 0x1B51090 VA: 0x181B52A90
	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	// RVA: 0x1B51D90 Offset: 0x1B50390 VA: 0x181B51D90
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x1B51280 Offset: 0x1B4F880 VA: 0x181B51280
	internal static ulong DWL(uint lo, uint hi) { }

	// RVA: 0x150FA00 Offset: 0x150E000 VA: 0x18150FA00
	private static uint HI(ulong x) { }

	// RVA: 0x58E1B0 Offset: 0x58C7B0 VA: 0x18058E1B0
	private static uint LO(ulong x) { }

	// RVA: 0x1B51E90 Offset: 0x1B50490 VA: 0x181B51E90
	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	// RVA: 0x1B50CA0 Offset: 0x1B4F2A0 VA: 0x181B50CA0
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0x1B50BC0 Offset: 0x1B4F1C0 VA: 0x181B50BC0
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	// RVA: 0x1B56B20 Offset: 0x1B55120 VA: 0x181B56B20
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1B573D0 Offset: 0x1B559D0 VA: 0x181B573D0
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1B56CC0 Offset: 0x1B552C0 VA: 0x181B56CC0
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1B51D10 Offset: 0x1B50310 VA: 0x181B51D10
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1B51AE0 Offset: 0x1B500E0 VA: 0x181B51AE0
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1B53E30 Offset: 0x1B52430 VA: 0x181B53E30
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1B54000 Offset: 0x1B52600 VA: 0x181B54000
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1B54080 Offset: 0x1B52680 VA: 0x181B54080
	public SqlMoney ToSqlMoney() { }

	// RVA: 0x1B50BB0 Offset: 0x1B4F1B0 VA: 0x181B50BB0
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1B53730 Offset: 0x1B51D30 VA: 0x181B53730
	private void StoreFromWorkingArray(uint[] rguiData) { }

	// RVA: 0x1B536C0 Offset: 0x1B51CC0 VA: 0x181B536C0
	private void SetToZero() { }

	// RVA: 0x1B51150 Offset: 0x1B4F750 VA: 0x181B51150 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B50E90 Offset: 0x1B4F490 VA: 0x181B50E90
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0x1B51470 Offset: 0x1B4FA70 VA: 0x181B51470 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B51900 Offset: 0x1B4FF00 VA: 0x181B51900 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B53780 Offset: 0x1B51D80 VA: 0x181B53780 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B53930 Offset: 0x1B51F30 VA: 0x181B53930 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B51A70 Offset: 0x1B50070 VA: 0x181B51A70
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B54920 Offset: 0x1B52F20 VA: 0x181B54920
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDouble : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8780
{
	// Fields
	private bool m_fNotNull; // 0x0
	private double m_value; // 0x8
	public static readonly SqlDouble Null; // 0x0
	public static readonly SqlDouble Zero; // 0x10
	public static readonly SqlDouble MinValue; // 0x20
	public static readonly SqlDouble MaxValue; // 0x30

	// Properties
	public bool IsNull { get; }
	public double Value { get; }

	// Methods

	// RVA: 0x1B59600 Offset: 0x1B57C00 VA: 0x181B59600
	private void .ctor(bool fNull) { }

	// RVA: 0x1B59570 Offset: 0x1B57B70 VA: 0x181B59570
	public void .ctor(double value) { }

	// RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B59610 Offset: 0x1B57C10 VA: 0x181B59610
	public double get_Value() { }

	// RVA: 0x1B59E40 Offset: 0x1B58440 VA: 0x181B59E40
	public static SqlDouble op_Implicit(double x) { }

	// RVA: 0x1B59300 Offset: 0x1B57900 VA: 0x181B59300 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B5A550 Offset: 0x1B58B50 VA: 0x181B5A550
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0x1B59670 Offset: 0x1B57C70 VA: 0x181B59670
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1B5A400 Offset: 0x1B58A00 VA: 0x181B5A400
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1B5A2B0 Offset: 0x1B588B0 VA: 0x181B5A2B0
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1B597C0 Offset: 0x1B57DC0 VA: 0x181B597C0
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1B5A100 Offset: 0x1B58700 VA: 0x181B5A100
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0x1B5A030 Offset: 0x1B58630 VA: 0x181B5A030
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0x1B59E60 Offset: 0x1B58460 VA: 0x181B59E60
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0x1B59B40 Offset: 0x1B58140 VA: 0x181B59B40
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0x1B59F60 Offset: 0x1B58560 VA: 0x181B59F60
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0x1B59D70 Offset: 0x1B58370 VA: 0x181B59D70
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0x1B59C50 Offset: 0x1B58250 VA: 0x181B59C50
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0x1B59970 Offset: 0x1B57F70 VA: 0x181B59970
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1B5A1E0 Offset: 0x1B587E0 VA: 0x181B5A1E0
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1B59A70 Offset: 0x1B58070 VA: 0x181B59A70
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1B58E20 Offset: 0x1B57420 VA: 0x181B58E20
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1B58D00 Offset: 0x1B57300 VA: 0x181B58D00
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1B59180 Offset: 0x1B57780 VA: 0x181B59180
	public SqlSingle ToSqlSingle() { }

	// RVA: 0x1B58640 Offset: 0x1B56C40 VA: 0x181B58640 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B58770 Offset: 0x1B56D70 VA: 0x181B58770
	public int CompareTo(SqlDouble value) { }

	// RVA: 0x1B589B0 Offset: 0x1B56FB0 VA: 0x181B589B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B58BC0 Offset: 0x1B571C0 VA: 0x181B58BC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B58F40 Offset: 0x1B57540 VA: 0x181B58F40 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B59060 Offset: 0x1B57660 VA: 0x181B59060 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B58C90 Offset: 0x1B57290 VA: 0x181B58C90
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B59360 Offset: 0x1B57960 VA: 0x181B59360
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlGuid : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8781
{
	// Fields
	private static readonly int s_sizeOfGuid; // 0x0
	private static readonly int[] s_rgiGuidOrder; // 0x8
	private byte[] m_value; // 0x0
	public static readonly SqlGuid Null; // 0x10

	// Properties
	public bool IsNull { get; }
	public Guid Value { get; }

	// Methods

	// RVA: 0x1B35450 Offset: 0x1B33A50 VA: 0x181B35450
	private void .ctor(bool fNull) { }

	// RVA: 0x1B5B240 Offset: 0x1B59840 VA: 0x181B5B240
	public void .ctor(Guid g) { }

	// RVA: 0x13F37F0 Offset: 0x13F1DF0 VA: 0x1813F37F0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B5B270 Offset: 0x1B59870 VA: 0x181B5B270
	public Guid get_Value() { }

	// RVA: 0x1B5B500 Offset: 0x1B59B00 VA: 0x181B5B500
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0x1B5B0D0 Offset: 0x1B596D0 VA: 0x181B5B0D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B5A9F0 Offset: 0x1B58FF0 VA: 0x181B5A9F0
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1B5B320 Offset: 0x1B59920 VA: 0x181B5B320
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1B5B540 Offset: 0x1B59B40 VA: 0x181B5B540
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1B5B410 Offset: 0x1B59A10 VA: 0x181B5B410
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1B5A600 Offset: 0x1B58C00 VA: 0x181B5A600 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B5A710 Offset: 0x1B58D10 VA: 0x181B5A710
	public int CompareTo(SqlGuid value) { }

	// RVA: 0x1B5AB00 Offset: 0x1B59100 VA: 0x181B5AB00 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B5ACE0 Offset: 0x1B592E0 VA: 0x181B5ACE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B5AE60 Offset: 0x1B59460 VA: 0x181B5AE60 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B5AF90 Offset: 0x1B59590 VA: 0x181B5AF90 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B5ADF0 Offset: 0x1B593F0 VA: 0x181B5ADF0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B5B150 Offset: 0x1B59750 VA: 0x181B5B150
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt16 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8782
{
	// Fields
	private bool m_fNotNull; // 0x0
	private short m_value; // 0x2
	private static readonly int s_MASKI2; // 0x0
	public static readonly SqlInt16 Null; // 0x4
	public static readonly SqlInt16 Zero; // 0x8
	public static readonly SqlInt16 MinValue; // 0xC
	public static readonly SqlInt16 MaxValue; // 0x10

	// Properties
	public bool IsNull { get; }
	public short Value { get; }

	// Methods

	// RVA: 0x1B5C280 Offset: 0x1B5A880 VA: 0x181B5C280
	private void .ctor(bool fNull) { }

	// RVA: 0x12B5100 Offset: 0x12B3700 VA: 0x1812B5100
	public void .ctor(short value) { }

	// RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B5C290 Offset: 0x1B5A890 VA: 0x181B5C290
	public short get_Value() { }

	// RVA: 0x1B5C970 Offset: 0x1B5AF70 VA: 0x181B5C970
	public static SqlInt16 op_Implicit(short x) { }

	// RVA: 0x1B5C160 Offset: 0x1B5A760 VA: 0x181B5C160 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B5CCF0 Offset: 0x1B5B2F0 VA: 0x181B5CCF0
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0x1B5C2F0 Offset: 0x1B5A8F0 VA: 0x181B5C2F0
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1B5CBD0 Offset: 0x1B5B1D0 VA: 0x181B5CBD0
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1B5CA70 Offset: 0x1B5B070 VA: 0x181B5CA70
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1B5C410 Offset: 0x1B5AA10 VA: 0x181B5C410
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1B5C8A0 Offset: 0x1B5AEA0 VA: 0x181B5C8A0
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0x1B5C670 Offset: 0x1B5AC70 VA: 0x181B5C670
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0x1B5C590 Offset: 0x1B5AB90 VA: 0x181B5C590
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1B5C990 Offset: 0x1B5AF90 VA: 0x181B5C990
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1B5C7C0 Offset: 0x1B5ADC0 VA: 0x181B5C7C0
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1B5BC40 Offset: 0x1B5A240 VA: 0x181B5BC40
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1B5BBE0 Offset: 0x1B5A1E0 VA: 0x181B5BBE0
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1B5BEE0 Offset: 0x1B5A4E0 VA: 0x181B5BEE0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1B5C050 Offset: 0x1B5A650 VA: 0x181B5C050
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1B5B630 Offset: 0x1B59C30 VA: 0x181B5B630 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B5B740 Offset: 0x1B59D40 VA: 0x181B5B740
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0x1B5B8B0 Offset: 0x1B59EB0 VA: 0x181B5B8B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B5BAB0 Offset: 0x1B5A0B0 VA: 0x181B5BAB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B5BCA0 Offset: 0x1B5A2A0 VA: 0x181B5BCA0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B5BDC0 Offset: 0x1B5A3C0 VA: 0x181B5BDC0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B5BB70 Offset: 0x1B5A170 VA: 0x181B5BB70
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B5C1C0 Offset: 0x1B5A7C0 VA: 0x181B5C1C0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt32 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8783
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_value; // 0x4
	private static readonly long s_iIntMin; // 0x0
	private static readonly long s_lBitNotIntMax; // 0x8
	public static readonly SqlInt32 Null; // 0x10
	public static readonly SqlInt32 Zero; // 0x18
	public static readonly SqlInt32 MinValue; // 0x20
	public static readonly SqlInt32 MaxValue; // 0x28

	// Properties
	public bool IsNull { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x1B5DA40 Offset: 0x1B5C040 VA: 0x181B5DA40
	private void .ctor(bool fNull) { }

	// RVA: 0x12B50C0 Offset: 0x12B36C0 VA: 0x1812B50C0
	public void .ctor(int value) { }

	// RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B5DA50 Offset: 0x1B5C050 VA: 0x181B5DA50
	public int get_Value() { }

	// RVA: 0x1B5E1F0 Offset: 0x1B5C7F0 VA: 0x181B5E1F0
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0x1B5D900 Offset: 0x1B5BF00 VA: 0x181B5D900 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B5E690 Offset: 0x1B5CC90 VA: 0x181B5E690
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0x1B5DAE0 Offset: 0x1B5C0E0 VA: 0x181B5DAE0
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1B5E510 Offset: 0x1B5CB10 VA: 0x181B5E510
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1B5E3B0 Offset: 0x1B5C9B0 VA: 0x181B5E3B0
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1B5DC60 Offset: 0x1B5C260 VA: 0x181B5DC60
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1B5E120 Offset: 0x1B5C720 VA: 0x181B5E120
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0x1B5E210 Offset: 0x1B5C810 VA: 0x181B5E210
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0x1B5DEE0 Offset: 0x1B5C4E0 VA: 0x181B5DEE0
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0x1B5D3C0 Offset: 0x1B5B9C0 VA: 0x181B5D3C0
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0x1B5DE00 Offset: 0x1B5C400 VA: 0x181B5DE00
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1B5E2D0 Offset: 0x1B5C8D0 VA: 0x181B5E2D0
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1B5E040 Offset: 0x1B5C640 VA: 0x181B5E040
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1B5D360 Offset: 0x1B5B960 VA: 0x181B5D360
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1B5D300 Offset: 0x1B5B900 VA: 0x181B5D300
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1B5D620 Offset: 0x1B5BC20 VA: 0x181B5D620
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1B5D7C0 Offset: 0x1B5BDC0 VA: 0x181B5D7C0
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1B5CF00 Offset: 0x1B5B500 VA: 0x181B5CF00 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B5CD90 Offset: 0x1B5B390 VA: 0x181B5CD90
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0x1B5D010 Offset: 0x1B5B610 VA: 0x181B5D010 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B5D210 Offset: 0x1B5B810 VA: 0x181B5D210 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B5D3E0 Offset: 0x1B5B9E0 VA: 0x181B5D3E0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B5D500 Offset: 0x1B5BB00 VA: 0x181B5D500 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B5D290 Offset: 0x1B5B890 VA: 0x181B5D290
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B5D960 Offset: 0x1B5BF60 VA: 0x181B5D960
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt64 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8784
{
	// Fields
	private bool m_fNotNull; // 0x0
	private long m_value; // 0x8
	private static readonly long s_lLowIntMask; // 0x0
	private static readonly long s_lHighIntMask; // 0x8
	public static readonly SqlInt64 Null; // 0x10
	public static readonly SqlInt64 Zero; // 0x20
	public static readonly SqlInt64 MinValue; // 0x30
	public static readonly SqlInt64 MaxValue; // 0x40

	// Properties
	public bool IsNull { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x1B59600 Offset: 0x1B57C00 VA: 0x181B59600
	private void .ctor(bool fNull) { }

	// RVA: 0x12B50B0 Offset: 0x12B36B0 VA: 0x1812B50B0
	public void .ctor(long value) { }

	// RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B5F990 Offset: 0x1B5DF90 VA: 0x181B5F990
	public long get_Value() { }

	// RVA: 0x1B603F0 Offset: 0x1B5E9F0 VA: 0x181B603F0
	public static SqlInt64 op_Implicit(long x) { }

	// RVA: 0x1B5F840 Offset: 0x1B5DE40 VA: 0x181B5F840 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B60B20 Offset: 0x1B5F120 VA: 0x181B60B20
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0x1B5F9F0 Offset: 0x1B5DFF0 VA: 0x181B5F9F0
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1B609A0 Offset: 0x1B5EFA0 VA: 0x181B609A0
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1B60670 Offset: 0x1B5EC70 VA: 0x181B60670
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1B5FB60 Offset: 0x1B5E160 VA: 0x181B5FB60
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1B604E0 Offset: 0x1B5EAE0 VA: 0x181B604E0
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1B60320 Offset: 0x1B5E920 VA: 0x181B60320
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0x1B60250 Offset: 0x1B5E850 VA: 0x181B60250
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0x1B60150 Offset: 0x1B5E750 VA: 0x181B60150
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0x1B5FDC0 Offset: 0x1B5E3C0 VA: 0x181B5FDC0
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0x1B5F040 Offset: 0x1B5D640 VA: 0x181B5F040
	private static bool SameSignLong(long x, long y) { }

	// RVA: 0x1B5FCF0 Offset: 0x1B5E2F0 VA: 0x181B5FCF0
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1B60410 Offset: 0x1B5EA10 VA: 0x181B60410
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1B60080 Offset: 0x1B5E680 VA: 0x181B60080
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1B5EF10 Offset: 0x1B5D510 VA: 0x181B5EF10
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1B5EDE0 Offset: 0x1B5D3E0 VA: 0x181B5EDE0
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1B5F2A0 Offset: 0x1B5D8A0 VA: 0x181B5F2A0
	public SqlByte ToSqlByte() { }

	// RVA: 0x1B5F420 Offset: 0x1B5DA20 VA: 0x181B5F420
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1B5F5A0 Offset: 0x1B5DBA0 VA: 0x181B5F5A0
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0x1B5F6F0 Offset: 0x1B5DCF0 VA: 0x181B5F6F0
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0x1B5F300 Offset: 0x1B5D900 VA: 0x181B5F300
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x1B5E980 Offset: 0x1B5CF80 VA: 0x181B5E980 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B5E730 Offset: 0x1B5CD30 VA: 0x181B5E730
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0x1B5EAB0 Offset: 0x1B5D0B0 VA: 0x181B5EAB0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B5ECB0 Offset: 0x1B5D2B0 VA: 0x181B5ECB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B5F060 Offset: 0x1B5D660 VA: 0x181B5F060 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B5F180 Offset: 0x1B5D780 VA: 0x181B5F180 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B5ED70 Offset: 0x1B5D370 VA: 0x181B5ED70
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B5F8A0 Offset: 0x1B5DEA0 VA: 0x181B5F8A0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8785
{
	// Fields
	private bool _fNotNull; // 0x0
	private long _value; // 0x8
	internal static readonly int s_iMoneyScale; // 0x0
	private static readonly long s_lTickBase; // 0x8
	private static readonly double s_dTickBase; // 0x10
	private static readonly long s_minLong; // 0x18
	private static readonly long s_maxLong; // 0x20
	public static readonly SqlMoney Null; // 0x28
	public static readonly SqlMoney Zero; // 0x38
	public static readonly SqlMoney MinValue; // 0x48
	public static readonly SqlMoney MaxValue; // 0x58

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }

	// Methods

	// RVA: 0x1B59600 Offset: 0x1B57C00 VA: 0x181B59600
	private void .ctor(bool fNull) { }

	// RVA: 0x12B50B0 Offset: 0x12B36B0 VA: 0x1812B50B0
	internal void .ctor(long value, int ignored) { }

	// RVA: 0x1B61F70 Offset: 0x1B60570 VA: 0x181B61F70
	public void .ctor(int value) { }

	// RVA: 0x1B61E70 Offset: 0x1B60470 VA: 0x181B61E70
	public void .ctor(long value) { }

	// RVA: 0x1B61FE0 Offset: 0x1B605E0 VA: 0x181B61FE0
	public void .ctor(Decimal value) { }

	// RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B621D0 Offset: 0x1B607D0 VA: 0x181B621D0
	public Decimal get_Value() { }

	// RVA: 0x1B61750 Offset: 0x1B5FD50 VA: 0x181B61750
	public Decimal ToDecimal() { }

	// RVA: 0x1B61860 Offset: 0x1B5FE60 VA: 0x181B61860
	public double ToDouble() { }

	// RVA: 0x1B62960 Offset: 0x1B60F60 VA: 0x181B62960
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0x1B62B60 Offset: 0x1B61160 VA: 0x181B62B60
	public static SqlMoney op_Implicit(long x) { }

	// RVA: 0x1B61C20 Offset: 0x1B60220 VA: 0x181B61C20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B63090 Offset: 0x1B61690 VA: 0x181B63090
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0x1B62280 Offset: 0x1B60880 VA: 0x181B62280
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1B62F00 Offset: 0x1B61500 VA: 0x181B62F00
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1B62D90 Offset: 0x1B61390 VA: 0x181B62D90
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1B62410 Offset: 0x1B60A10 VA: 0x181B62410
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1B62A90 Offset: 0x1B61090 VA: 0x181B62A90
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0x1B62890 Offset: 0x1B60E90 VA: 0x181B62890
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0x1B62990 Offset: 0x1B60F90 VA: 0x181B62990
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0x1B62BB0 Offset: 0x1B611B0 VA: 0x181B62BB0
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0x1B62650 Offset: 0x1B60C50 VA: 0x181B62650
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0x1B62580 Offset: 0x1B60B80 VA: 0x181B62580
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1B62CC0 Offset: 0x1B612C0 VA: 0x181B62CC0
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1B627C0 Offset: 0x1B60DC0 VA: 0x181B627C0
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1B61350 Offset: 0x1B5F950 VA: 0x181B61350
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1B61220 Offset: 0x1B5F820 VA: 0x181B61220
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1B61A30 Offset: 0x1B60030 VA: 0x181B61A30
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1B618F0 Offset: 0x1B5FEF0 VA: 0x181B618F0
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x1B60E20 Offset: 0x1B5F420 VA: 0x181B60E20 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B60BD0 Offset: 0x1B5F1D0 VA: 0x181B60BD0
	public int CompareTo(SqlMoney value) { }

	// RVA: 0x1B60F50 Offset: 0x1B5F550 VA: 0x181B60F50 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B61150 Offset: 0x1B5F750 VA: 0x181B61150 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B61480 Offset: 0x1B5FA80 VA: 0x181B61480 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B61600 Offset: 0x1B5FC00 VA: 0x181B61600 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B611B0 Offset: 0x1B5F7B0 VA: 0x181B611B0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B61CF0 Offset: 0x1B602F0 VA: 0x181B61CF0
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlSingle : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8786
{
	// Fields
	private bool _fNotNull; // 0x0
	private float _value; // 0x4
	public static readonly SqlSingle Null; // 0x0
	public static readonly SqlSingle Zero; // 0x8
	public static readonly SqlSingle MinValue; // 0x10
	public static readonly SqlSingle MaxValue; // 0x18

	// Properties
	public bool IsNull { get; }
	public float Value { get; }

	// Methods

	// RVA: 0x1B5DA40 Offset: 0x1B5C040 VA: 0x181B5DA40
	private void .ctor(bool fNull) { }

	// RVA: 0x1B640D0 Offset: 0x1B626D0 VA: 0x181B640D0
	public void .ctor(float value) { }

	// RVA: 0x1B64070 Offset: 0x1B62670 VA: 0x181B64070
	public void .ctor(double value) { }

	// RVA: 0xC086B0 Offset: 0xC06CB0 VA: 0x180C086B0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B64150 Offset: 0x1B62750 VA: 0x181B64150
	public float get_Value() { }

	// RVA: 0x1B64F10 Offset: 0x1B63510 VA: 0x181B64F10
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x1B63E20 Offset: 0x1B62420 VA: 0x181B63E20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B654F0 Offset: 0x1B63AF0 VA: 0x181B654F0
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0x1B641B0 Offset: 0x1B627B0 VA: 0x181B641B0
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1B65360 Offset: 0x1B63960 VA: 0x181B65360
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1B651D0 Offset: 0x1B637D0 VA: 0x181B651D0
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1B64340 Offset: 0x1B62940 VA: 0x181B64340
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1B64DD0 Offset: 0x1B633D0 VA: 0x181B64DD0
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0x1B64CB0 Offset: 0x1B632B0 VA: 0x181B64CB0
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0x1B64FA0 Offset: 0x1B635A0 VA: 0x181B64FA0
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0x1B64B50 Offset: 0x1B63150 VA: 0x181B64B50
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0x1B64840 Offset: 0x1B62E40 VA: 0x181B64840
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0x1B649A0 Offset: 0x1B62FA0 VA: 0x181B649A0
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0x1B645D0 Offset: 0x1B62BD0 VA: 0x181B645D0
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0x1B644D0 Offset: 0x1B62AD0 VA: 0x181B644D0
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1B650F0 Offset: 0x1B636F0 VA: 0x181B650F0
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1B64760 Offset: 0x1B62D60 VA: 0x181B64760
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1B63A10 Offset: 0x1B62010 VA: 0x181B63A10
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1B639B0 Offset: 0x1B61FB0 VA: 0x181B639B0
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1B63CB0 Offset: 0x1B622B0 VA: 0x181B63CB0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1B63560 Offset: 0x1B61B60 VA: 0x181B63560 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B633F0 Offset: 0x1B619F0 VA: 0x181B633F0
	public int CompareTo(SqlSingle value) { }

	// RVA: 0x1B63670 Offset: 0x1B61C70 VA: 0x181B63670 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B63880 Offset: 0x1B61E80 VA: 0x181B63880 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B63A70 Offset: 0x1B62070 VA: 0x181B63A70 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B63B90 Offset: 0x1B62190 VA: 0x181B63B90 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B63940 Offset: 0x1B61F40 VA: 0x181B63940
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B63E80 Offset: 0x1B62480 VA: 0x181B63E80
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[Flags]
public enum SqlCompareOptions // TypeDefIndex: 8787
{
	// Fields
	public int value__; // 0x0
	public const SqlCompareOptions None = 0;
	public const SqlCompareOptions IgnoreCase = 1;
	public const SqlCompareOptions IgnoreNonSpace = 2;
	public const SqlCompareOptions IgnoreKanaType = 8;
	public const SqlCompareOptions IgnoreWidth = 16;
	public const SqlCompareOptions BinarySort = 32768;
	public const SqlCompareOptions BinarySort2 = 16384;
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 8788
{
	// Fields
	private string m_value; // 0x0
	private CompareInfo m_cmpInfo; // 0x8
	private int m_lcid; // 0x10
	private SqlCompareOptions m_flag; // 0x14
	private bool m_fNotNull; // 0x18
	public static readonly SqlString Null; // 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
	public static readonly int IgnoreCase; // 0x28
	public static readonly int IgnoreWidth; // 0x2C
	public static readonly int IgnoreNonSpace; // 0x30
	public static readonly int IgnoreKanaType; // 0x34
	public static readonly int BinarySort; // 0x38
	public static readonly int BinarySort2; // 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
	internal static readonly int s_lcidUSEnglish; // 0x4C
	private static readonly int s_lcidBinary; // 0x50

	// Properties
	public bool IsNull { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1B67070 Offset: 0x1B65670 VA: 0x181B67070
	private void .ctor(bool fNull) { }

	// RVA: 0x1B66DD0 Offset: 0x1B653D0 VA: 0x181B66DD0
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0x1B66E70 Offset: 0x1B65470 VA: 0x181B66E70
	public void .ctor(string data) { }

	// RVA: 0x1B66FB0 Offset: 0x1B655B0 VA: 0x181B66FB0
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0x173E970 Offset: 0x173CF70 VA: 0x18173E970 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B670B0 Offset: 0x1B656B0 VA: 0x181B670B0
	public string get_Value() { }

	// RVA: 0x1B66400 Offset: 0x1B64A00 VA: 0x181B66400
	private void SetCompareInfo() { }

	// RVA: 0x1B67460 Offset: 0x1B65A60 VA: 0x181B67460
	public static SqlString op_Implicit(string x) { }

	// RVA: 0x1B66AF0 Offset: 0x1B650F0 VA: 0x181B66AF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B67140 Offset: 0x1B65740 VA: 0x181B67140
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0x1B664A0 Offset: 0x1B64AA0 VA: 0x181B664A0
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0x1B65CB0 Offset: 0x1B642B0 VA: 0x181B65CB0
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0x1B672F0 Offset: 0x1B658F0 VA: 0x181B672F0
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0x1B66B50 Offset: 0x1B65150 VA: 0x181B66B50
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x1B65980 Offset: 0x1B63F80 VA: 0x181B65980
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x1B660F0 Offset: 0x1B646F0 VA: 0x181B660F0
	private bool FBinarySort() { }

	// RVA: 0x1B65760 Offset: 0x1B63D60 VA: 0x181B65760
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0x1B655F0 Offset: 0x1B63BF0 VA: 0x181B655F0
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0x1B65A40 Offset: 0x1B64040 VA: 0x181B65A40 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1B65B80 Offset: 0x1B64180 VA: 0x181B65B80
	public int CompareTo(SqlString value) { }

	// RVA: 0x1B65E20 Offset: 0x1B64420 VA: 0x181B65E20 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B66150 Offset: 0x1B64750 VA: 0x181B66150 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B66900 Offset: 0x1B64F00 VA: 0x181B66900 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B66A10 Offset: 0x1B65010 VA: 0x181B66A10 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B66390 Offset: 0x1B64990 VA: 0x181B66390
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B66C00 Offset: 0x1B65200 VA: 0x181B66C00
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal enum EComparison // TypeDefIndex: 8789
{
	// Fields
	public int value__; // 0x0
	public const EComparison LT = 0;
	public const EComparison LE = 1;
	public const EComparison EQ = 2;
	public const EComparison GE = 3;
	public const EComparison GT = 4;
	public const EComparison NE = 5;
}

// Namespace: System.Data.SqlTypes
[Serializable]
public class SqlTypeException : SystemException // TypeDefIndex: 8790
{
	// Methods

	// RVA: 0x1B677F0 Offset: 0x1B65DF0 VA: 0x181B677F0
	public void .ctor() { }

	// RVA: 0x1B677C0 Offset: 0x1B65DC0 VA: 0x181B677C0
	public void .ctor(string message) { }

	// RVA: 0x1B677A0 Offset: 0x1B65DA0 VA: 0x181B677A0
	public void .ctor(string message, Exception e) { }

	// RVA: 0x1B67840 Offset: 0x1B65E40 VA: 0x181B67840
	protected void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1B676D0 Offset: 0x1B65CD0 VA: 0x181B676D0
	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlNullValueException : SqlTypeException // TypeDefIndex: 8791
{
	// Methods

	// RVA: 0x1B63280 Offset: 0x1B61880 VA: 0x181B63280
	public void .ctor() { }

	// RVA: 0x1B633C0 Offset: 0x1B619C0 VA: 0x181B633C0
	public void .ctor(string message) { }

	// RVA: 0x1B632B0 Offset: 0x1B618B0 VA: 0x181B632B0
	public void .ctor(string message, Exception e) { }

	// RVA: 0x1B632D0 Offset: 0x1B618D0 VA: 0x181B632D0
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1B631B0 Offset: 0x1B617B0 VA: 0x181B631B0
	private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlTruncateException : SqlTypeException // TypeDefIndex: 8792
{
	// Methods

	// RVA: 0x1B67580 Offset: 0x1B65B80 VA: 0x181B67580
	public void .ctor() { }

	// RVA: 0x1B676A0 Offset: 0x1B65CA0 VA: 0x181B676A0
	public void .ctor(string message) { }

	// RVA: 0x1B67560 Offset: 0x1B65B60 VA: 0x181B67560
	public void .ctor(string message, Exception e) { }

	// RVA: 0x1B675B0 Offset: 0x1B65BB0 VA: 0x181B675B0
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1B67490 Offset: 0x1B65A90 VA: 0x181B67490
	private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
internal abstract class SqlStreamChars // TypeDefIndex: 8793
{
	// Properties
	public abstract long Length { get; }
	public abstract long Position { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int Read(char[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long Seek(long offset, SeekOrigin origin);
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public sealed class SqlXml : INullable, IXmlSerializable // TypeDefIndex: 8794
{
	// Fields
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; // 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; // 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; // 0x18
	private MethodInfo _createSqlReaderMethodInfo; // 0x10
	private bool _fNotNull; // 0x18
	private Stream _stream; // 0x20
	private bool _firstCreateReader; // 0x28

	// Properties
	private static MethodInfo CreateSqlReaderMethodInfo { get; }
	public bool IsNull { get; }

	// Methods

	// RVA: 0x1B69520 Offset: 0x1B67B20 VA: 0x181B69520
	public void .ctor() { }

	// RVA: 0x1B68B30 Offset: 0x1B67130 VA: 0x181B68B30
	public XmlReader CreateReader() { }

	// RVA: 0x1B68DD0 Offset: 0x1B673D0 VA: 0x181B68DD0
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

	// RVA: 0x1B68CF0 Offset: 0x1B672F0 VA: 0x181B68CF0
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0x1B69560 Offset: 0x1B67B60 VA: 0x181B69560
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0x173E970 Offset: 0x173CF70 VA: 0x18173E970 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1B68FC0 Offset: 0x1B675C0 VA: 0x181B68FC0
	private void SetNull() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B68FF0 Offset: 0x1B675F0 VA: 0x181B68FF0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x1B691E0 Offset: 0x1B677E0 VA: 0x181B691E0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B68F50 Offset: 0x1B67550 VA: 0x181B68F50
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1B69320 Offset: 0x1B67920 VA: 0x181B69320
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal sealed class SqlXmlStreamWrapper : Stream // TypeDefIndex: 8795
{
	// Fields
	private Stream _stream; // 0x28
	private long _lPosition; // 0x30
	private bool _isClosed; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1B68710 Offset: 0x1B66D10 VA: 0x181B68710
	internal void .ctor(Stream stream) { }

	// RVA: 0x1B68790 Offset: 0x1B66D90 VA: 0x181B68790 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B687E0 Offset: 0x1B66DE0 VA: 0x181B687E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1B68830 Offset: 0x1B66E30 VA: 0x181B68830 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1B68880 Offset: 0x1B66E80 VA: 0x181B68880 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1B68950 Offset: 0x1B66F50 VA: 0x181B68950 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1B68A00 Offset: 0x1B67000 VA: 0x181B68A00 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1B67E50 Offset: 0x1B66450 VA: 0x181B67E50 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1B67BD0 Offset: 0x1B661D0 VA: 0x181B67BD0 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B68490 Offset: 0x1B66A90 VA: 0x181B68490 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B67A30 Offset: 0x1B66030 VA: 0x181B67A30 Slot: 33
	public override int ReadByte() { }

	// RVA: 0x1B68340 Offset: 0x1B66940 VA: 0x181B68340 Slot: 36
	public override void WriteByte(byte value) { }

	// RVA: 0x1B67980 Offset: 0x1B65F80 VA: 0x181B67980 Slot: 20
	public override void Flush() { }

	// RVA: 0x1B67930 Offset: 0x1B65F30 VA: 0x181B67930 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B681B0 Offset: 0x1B667B0 VA: 0x181B681B0
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0x1B68120 Offset: 0x1B66720 VA: 0x181B68120
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0x1B68240 Offset: 0x1B66840 VA: 0x181B68240
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0x1B682D0 Offset: 0x1B668D0 VA: 0x181B682D0
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0x1B679A0 Offset: 0x1B65FA0 VA: 0x181B679A0
	private bool IsStreamClosed() { }
}

