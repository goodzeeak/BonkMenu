// Namespace: Newtonsoft.Json.Bson
internal enum BsonBinaryType // TypeDefIndex: 8576
{
	// Fields
	public byte value__; // 0x0
	public const BsonBinaryType Binary = 0;
	public const BsonBinaryType Function = 1;
	[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
	public const BsonBinaryType BinaryOld = 2;
	[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
	public const BsonBinaryType UuidOld = 3;
	public const BsonBinaryType Uuid = 4;
	public const BsonBinaryType Md5 = 5;
	public const BsonBinaryType UserDefined = 128;
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonBinaryWriter // TypeDefIndex: 8577
{
	// Fields
	private static readonly Encoding Encoding; // 0x0
	private readonly BinaryWriter _writer; // 0x10
	private byte[] _largeByteBuffer; // 0x18
	[CompilerGenerated]
	private DateTimeKind <DateTimeKindHandling>k__BackingField; // 0x20

	// Properties
	public DateTimeKind DateTimeKindHandling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public DateTimeKind get_DateTimeKindHandling() { }

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	// RVA: 0x168A260 Offset: 0x1688860 VA: 0x18168A260
	public void .ctor(BinaryWriter writer) { }

	// RVA: 0x1689010 Offset: 0x1687610 VA: 0x181689010
	public void Flush() { }

	// RVA: 0x1688FE0 Offset: 0x16875E0 VA: 0x181688FE0
	public void Close() { }

	// RVA: 0x168A020 Offset: 0x1688620 VA: 0x18168A020
	public void WriteToken(BsonToken t) { }

	// RVA: 0x1689250 Offset: 0x1687850 VA: 0x181689250
	private void WriteTokenInternal(BsonToken t) { }

	// RVA: 0x1689040 Offset: 0x1687640 VA: 0x181689040
	private void WriteString(string s, int byteCount, Nullable<int> calculatedlengthPrefix) { }

	// RVA: 0x168A050 Offset: 0x1688650 VA: 0x18168A050
	public void WriteUtf8Bytes(string s, int byteCount) { }

	// RVA: 0x1688910 Offset: 0x1686F10 VA: 0x181688910
	private int CalculateSize(int stringByteCount) { }

	// RVA: 0x1688900 Offset: 0x1686F00 VA: 0x181688900
	private int CalculateSizeWithLength(int stringByteCount, bool includeSize) { }

	// RVA: 0x1688920 Offset: 0x1686F20 VA: 0x181688920
	private int CalculateSize(BsonToken t) { }

	// RVA: 0x168A1E0 Offset: 0x16887E0 VA: 0x18168A1E0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Bson
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonObjectId // TypeDefIndex: 8578
{
	// Fields
	[CompilerGenerated]
	private readonly byte[] <Value>k__BackingField; // 0x10

	// Properties
	public byte[] Value { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public byte[] get_Value() { }

	// RVA: 0x168A540 Offset: 0x1688B40 VA: 0x18168A540
	public void .ctor(byte[] value) { }
}

// Namespace: Newtonsoft.Json.Bson
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonReader : JsonReader // TypeDefIndex: 8581
{
	// Fields
	private const int MaxCharBytesSize = 128;
	private static readonly byte[] SeqRange1; // 0x0
	private static readonly byte[] SeqRange2; // 0x8
	private static readonly byte[] SeqRange3; // 0x10
	private static readonly byte[] SeqRange4; // 0x18
	private readonly BinaryReader _reader; // 0x78
	private readonly List<BsonReader.ContainerContext> _stack; // 0x80
	private byte[] _byteBuffer; // 0x88
	private char[] _charBuffer; // 0x90
	private BsonType _currentElementType; // 0x98
	private BsonReader.BsonReaderState _bsonReaderState; // 0x9C
	private BsonReader.ContainerContext _currentContext; // 0xA0
	private bool _readRootValueAsArray; // 0xA8
	private bool _jsonNet35BinaryCompatibility; // 0xA9
	private DateTimeKind _dateTimeKindHandling; // 0xAC

	// Properties
	[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
	public bool JsonNet35BinaryCompatibility { get; set; }
	public bool ReadRootValueAsArray { get; set; }
	public DateTimeKind DateTimeKindHandling { get; set; }

	// Methods

	// RVA: 0x3A35A0 Offset: 0x3A1BA0 VA: 0x1803A35A0
	public bool get_JsonNet35BinaryCompatibility() { }

	// RVA: 0x168CD10 Offset: 0x168B310 VA: 0x18168CD10
	public void set_JsonNet35BinaryCompatibility(bool value) { }

	// RVA: 0x3A3490 Offset: 0x3A1A90 VA: 0x1803A3490
	public bool get_ReadRootValueAsArray() { }

	// RVA: 0x3A3990 Offset: 0x3A1F90 VA: 0x1803A3990
	public void set_ReadRootValueAsArray(bool value) { }

	// RVA: 0x3A3480 Offset: 0x3A1A80 VA: 0x1803A3480
	public DateTimeKind get_DateTimeKindHandling() { }

	// RVA: 0x168CD00 Offset: 0x168B300 VA: 0x18168CD00
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	// RVA: 0x168CAF0 Offset: 0x168B0F0 VA: 0x18168CAF0
	public void .ctor(Stream stream) { }

	// RVA: 0x168CA30 Offset: 0x168B030 VA: 0x18168CA30
	public void .ctor(BinaryReader reader) { }

	// RVA: 0x168CBF0 Offset: 0x168B1F0 VA: 0x18168CBF0
	public void .ctor(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling) { }

	// RVA: 0x168C950 Offset: 0x168AF50 VA: 0x18168C950
	public void .ctor(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling) { }

	// RVA: 0x168B520 Offset: 0x1689B20 VA: 0x18168B520
	private string ReadElement() { }

	// RVA: 0x168C660 Offset: 0x168AC60 VA: 0x18168C660 Slot: 21
	public override bool Read() { }

	// RVA: 0x168AA90 Offset: 0x1689090 VA: 0x18168AA90 Slot: 31
	public override void Close() { }

	// RVA: 0x168B270 Offset: 0x1689870 VA: 0x18168B270
	private bool ReadCodeWScope() { }

	// RVA: 0x168B9C0 Offset: 0x1689FC0 VA: 0x18168B9C0
	private bool ReadReference() { }

	// RVA: 0x168B680 Offset: 0x1689C80 VA: 0x18168B680
	private bool ReadNormal() { }

	// RVA: 0x168AF70 Offset: 0x1689570 VA: 0x18168AF70
	private void PopContext() { }

	// RVA: 0x168B030 Offset: 0x1689630 VA: 0x18168B030
	private void PushContext(BsonReader.ContainerContext newContext) { }

	// RVA: 0x168B1F0 Offset: 0x16897F0 VA: 0x18168B1F0
	private byte ReadByte() { }

	// RVA: 0x168BF70 Offset: 0x168A570 VA: 0x18168BF70
	private void ReadType(BsonType type) { }

	// RVA: 0x168B0F0 Offset: 0x16896F0 VA: 0x18168B0F0
	private byte[] ReadBinary(out BsonBinaryType binaryType) { }

	// RVA: 0x168BC90 Offset: 0x168A290 VA: 0x18168BC90
	private string ReadString() { }

	// RVA: 0x168B5F0 Offset: 0x1689BF0 VA: 0x18168B5F0
	private string ReadLengthString() { }

	// RVA: 0x168AC30 Offset: 0x1689230 VA: 0x18168AC30
	private string GetString(int length) { }

	// RVA: 0x168ABA0 Offset: 0x16891A0 VA: 0x18168ABA0
	private int GetLastFullCharStop(int start) { }

	// RVA: 0x168A8A0 Offset: 0x1688EA0 VA: 0x18168A8A0
	private int BytesInSequence(byte b) { }

	// RVA: 0x168AAD0 Offset: 0x16890D0 VA: 0x18168AAD0
	private void EnsureBuffers() { }

	// RVA: 0x168B4E0 Offset: 0x1689AE0 VA: 0x18168B4E0
	private double ReadDouble() { }

	// RVA: 0x168B570 Offset: 0x1689B70 VA: 0x18168B570
	private int ReadInt32() { }

	// RVA: 0x168B5B0 Offset: 0x1689BB0 VA: 0x18168B5B0
	private long ReadInt64() { }

	// RVA: 0x168C620 Offset: 0x168AC20 VA: 0x18168C620
	private BsonType ReadType() { }

	// RVA: 0x168AF50 Offset: 0x1689550 VA: 0x18168AF50
	private void MovePosition(int count) { }

	// RVA: 0x168B230 Offset: 0x1689830 VA: 0x18168B230
	private byte[] ReadBytes(int count) { }

	// RVA: 0x168C7A0 Offset: 0x168ADA0 VA: 0x18168C7A0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal abstract class BsonToken // TypeDefIndex: 8582
{
	// Fields
	[CompilerGenerated]
	private BsonToken <Parent>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <CalculatedSize>k__BackingField; // 0x18

	// Properties
	public abstract BsonType Type { get; }
	public BsonToken Parent { get; set; }
	public int CalculatedSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract BsonType get_Type();

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public BsonToken get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Parent(BsonToken value) { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_CalculatedSize() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_CalculatedSize(int value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable // TypeDefIndex: 8583
{
	// Fields
	private readonly List<BsonProperty> _children; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x168A610 Offset: 0x1688C10 VA: 0x18168A610
	public void Add(string name, BsonToken token) { }

	// RVA: 0x168A890 Offset: 0x1688E90 VA: 0x18168A890 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0x168A780 Offset: 0x1688D80 VA: 0x18168A780 Slot: 5
	public IEnumerator<BsonProperty> GetEnumerator() { }

	// RVA: 0x168A800 Offset: 0x1688E00 VA: 0x18168A800 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x168A810 Offset: 0x1688E10 VA: 0x18168A810
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable // TypeDefIndex: 8584
{
	// Fields
	private readonly List<BsonToken> _children; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x1688720 Offset: 0x1686D20 VA: 0x181688720
	public void Add(BsonToken token) { }

	// RVA: 0x16888F0 Offset: 0x1686EF0 VA: 0x1816888F0 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0x16887E0 Offset: 0x1686DE0 VA: 0x1816887E0 Slot: 5
	public IEnumerator<BsonToken> GetEnumerator() { }

	// RVA: 0x1688860 Offset: 0x1686E60 VA: 0x181688860 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1688870 Offset: 0x1686E70 VA: 0x181688870
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonEmpty : BsonToken // TypeDefIndex: 8585
{
	// Fields
	public static readonly BsonToken Null; // 0x0
	public static readonly BsonToken Undefined; // 0x8
	[CompilerGenerated]
	private readonly BsonType <Type>k__BackingField; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x168A510 Offset: 0x1688B10 VA: 0x18168A510
	private void .ctor(BsonType type) { }

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0x168A450 Offset: 0x1688A50 VA: 0x18168A450
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonValue : BsonToken // TypeDefIndex: 8586
{
	// Fields
	private readonly object _value; // 0x20
	private readonly BsonType _type; // 0x28

	// Properties
	public object Value { get; }
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x168CE60 Offset: 0x168B460 VA: 0x18168CE60
	public void .ctor(object value, BsonType type) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public object get_Value() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150 Slot: 4
	public override BsonType get_Type() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonBoolean : BsonValue // TypeDefIndex: 8587
{
	// Fields
	public static readonly BsonBoolean False; // 0x0
	public static readonly BsonBoolean True; // 0x8

	// Methods

	// RVA: 0x168A400 Offset: 0x1688A00 VA: 0x18168A400
	private void .ctor(bool value) { }

	// RVA: 0x168A2F0 Offset: 0x16888F0 VA: 0x18168A2F0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonString : BsonValue // TypeDefIndex: 8588
{
	// Fields
	[CompilerGenerated]
	private int <ByteCount>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly bool <IncludeLength>k__BackingField; // 0x34

	// Properties
	public int ByteCount { get; set; }
	public bool IncludeLength { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public int get_ByteCount() { }

	[CompilerGenerated]
	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	public void set_ByteCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_IncludeLength() { }

	// RVA: 0x168CE10 Offset: 0x168B410 VA: 0x18168CE10
	public void .ctor(object value, bool includeLength) { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonBinary : BsonValue // TypeDefIndex: 8589
{
	// Fields
	[CompilerGenerated]
	private BsonBinaryType <BinaryType>k__BackingField; // 0x30

	// Properties
	public BsonBinaryType BinaryType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public BsonBinaryType get_BinaryType() { }

	[CompilerGenerated]
	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	public void set_BinaryType(BsonBinaryType value) { }

	// RVA: 0x168A2A0 Offset: 0x16888A0 VA: 0x18168A2A0
	public void .ctor(byte[] value, BsonBinaryType binaryType) { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonRegex : BsonToken // TypeDefIndex: 8590
{
	// Fields
	[CompilerGenerated]
	private BsonString <Pattern>k__BackingField; // 0x20
	[CompilerGenerated]
	private BsonString <Options>k__BackingField; // 0x28

	// Properties
	public BsonString Pattern { get; set; }
	public BsonString Options { get; set; }
	public override BsonType Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public BsonString get_Pattern() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Pattern(BsonString value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public BsonString get_Options() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_Options(BsonString value) { }

	// RVA: 0x168CD20 Offset: 0x168B320 VA: 0x18168CD20
	public void .ctor(string pattern, string options) { }

	// RVA: 0x168CE00 Offset: 0x168B400 VA: 0x18168CE00 Slot: 4
	public override BsonType get_Type() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonProperty // TypeDefIndex: 8591
{
	// Fields
	[CompilerGenerated]
	private BsonString <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private BsonToken <Value>k__BackingField; // 0x18

	// Properties
	public BsonString Name { get; set; }
	public BsonToken Value { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public BsonString get_Name() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Name(BsonString value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public BsonToken get_Value() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Value(BsonToken value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal enum BsonType // TypeDefIndex: 8592
{
	// Fields
	public sbyte value__; // 0x0
	public const BsonType Number = 1;
	public const BsonType String = 2;
	public const BsonType Object = 3;
	public const BsonType Array = 4;
	public const BsonType Binary = 5;
	public const BsonType Undefined = 6;
	public const BsonType Oid = 7;
	public const BsonType Boolean = 8;
	public const BsonType Date = 9;
	public const BsonType Null = 10;
	public const BsonType Regex = 11;
	public const BsonType Reference = 12;
	public const BsonType Code = 13;
	public const BsonType Symbol = 14;
	public const BsonType CodeWScope = 15;
	public const BsonType Integer = 16;
	public const BsonType TimeStamp = 17;
	public const BsonType Long = 18;
	public const BsonType MinKey = -1;
	public const BsonType MaxKey = 127;
}

// Namespace: Newtonsoft.Json.Bson
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonWriter : JsonWriter // TypeDefIndex: 8593
{
	// Fields
	private readonly BsonBinaryWriter _writer; // 0x60
	private BsonToken _root; // 0x68
	private BsonToken _parent; // 0x70
	private string _propertyName; // 0x78

	// Properties
	public DateTimeKind DateTimeKindHandling { get; set; }

	// Methods

	// RVA: 0x168E900 Offset: 0x168CF00 VA: 0x18168E900
	public DateTimeKind get_DateTimeKindHandling() { }

	// RVA: 0x168E920 Offset: 0x168CF20 VA: 0x18168E920
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	// RVA: 0x168E800 Offset: 0x168CE00 VA: 0x18168E800
	public void .ctor(Stream stream) { }

	// RVA: 0x168E730 Offset: 0x168CD30 VA: 0x18168E730
	public void .ctor(BinaryWriter writer) { }

	// RVA: 0x168D3C0 Offset: 0x168B9C0 VA: 0x18168D3C0 Slot: 66
	public override void Flush() { }

	// RVA: 0x168D480 Offset: 0x168BA80 VA: 0x18168D480 Slot: 78
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0x168D430 Offset: 0x168BA30 VA: 0x18168D430 Slot: 124
	public override void WriteComment(string text) { }

	// RVA: 0x168D940 Offset: 0x168BF40 VA: 0x18168D940 Slot: 72
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x168D6C0 Offset: 0x168BCC0 VA: 0x18168D6C0 Slot: 84
	public override void WriteRaw(string json) { }

	// RVA: 0x168D670 Offset: 0x168BC70 VA: 0x18168D670 Slot: 85
	public override void WriteRawValue(string json) { }

	// RVA: 0x168D860 Offset: 0x168BE60 VA: 0x18168D860 Slot: 70
	public override void WriteStartArray() { }

	// RVA: 0x168D990 Offset: 0x168BF90 VA: 0x18168D990 Slot: 68
	public override void WriteStartObject() { }

	// RVA: 0x168D630 Offset: 0x168BC30 VA: 0x18168D630 Slot: 74
	public override void WritePropertyName(string name) { }

	// RVA: 0x168D370 Offset: 0x168B970 VA: 0x18168D370 Slot: 67
	public override void Close() { }

	// RVA: 0x168CEB0 Offset: 0x168B4B0 VA: 0x18168CEB0
	private void AddParent(BsonToken container) { }

	// RVA: 0x168D400 Offset: 0x168BA00 VA: 0x18168D400
	private void RemoveParent() { }

	// RVA: 0x168D2E0 Offset: 0x168B8E0 VA: 0x18168D2E0
	private void AddValue(object value, BsonType type) { }

	// RVA: 0x168CEF0 Offset: 0x168B4F0 VA: 0x18168CEF0
	internal void AddToken(BsonToken token) { }

	// RVA: 0x168DB30 Offset: 0x168C130 VA: 0x18168DB30 Slot: 123
	public override void WriteValue(object value) { }

	// RVA: 0x168D500 Offset: 0x168BB00 VA: 0x18168D500 Slot: 82
	public override void WriteNull() { }

	// RVA: 0x168DA70 Offset: 0x168C070 VA: 0x18168DA70 Slot: 83
	public override void WriteUndefined() { }

	// RVA: 0x168E540 Offset: 0x168CB40 VA: 0x18168E540 Slot: 86
	public override void WriteValue(string value) { }

	// RVA: 0x168DD90 Offset: 0x168C390 VA: 0x18168DD90 Slot: 87
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x168DC60 Offset: 0x168C260 VA: 0x18168DC60 Slot: 88
	public override void WriteValue(uint value) { }

	// RVA: 0x168DDE0 Offset: 0x168C3E0 VA: 0x18168DDE0 Slot: 89
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x168DCF0 Offset: 0x168C2F0 VA: 0x18168DCF0 Slot: 90
	public override void WriteValue(ulong value) { }

	// RVA: 0x168E4A0 Offset: 0x168CAA0 VA: 0x18168E4A0 Slot: 91
	public override void WriteValue(float value) { }

	// RVA: 0x168E240 Offset: 0x168C840 VA: 0x18168E240 Slot: 92
	public override void WriteValue(double value) { }

	// RVA: 0x168E3F0 Offset: 0x168C9F0 VA: 0x18168E3F0 Slot: 93
	public override void WriteValue(bool value) { }

	// RVA: 0x168DFA0 Offset: 0x168C5A0 VA: 0x18168DFA0 Slot: 94
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x168DAE0 Offset: 0x168C0E0 VA: 0x18168DAE0 Slot: 95
	public override void WriteValue(ushort value) { }

	// RVA: 0x168DE30 Offset: 0x168C430 VA: 0x18168DE30 Slot: 96
	public override void WriteValue(char value) { }

	// RVA: 0x168E120 Offset: 0x168C720 VA: 0x18168E120 Slot: 97
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x168E4F0 Offset: 0x168CAF0 VA: 0x18168E4F0 Slot: 98
	public override void WriteValue(sbyte value) { }

	// RVA: 0x168DFF0 Offset: 0x168C5F0 VA: 0x18168DFF0 Slot: 99
	public override void WriteValue(Decimal value) { }

	// RVA: 0x168E290 Offset: 0x168C890 VA: 0x18168E290 Slot: 100
	public override void WriteValue(DateTime value) { }

	// RVA: 0x168DF20 Offset: 0x168C520 VA: 0x18168DF20 Slot: 101
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x168E070 Offset: 0x168C670 VA: 0x18168E070 Slot: 121
	public override void WriteValue(byte[] value) { }

	// RVA: 0x168E340 Offset: 0x168C940 VA: 0x18168E340 Slot: 102
	public override void WriteValue(Guid value) { }

	// RVA: 0x168E170 Offset: 0x168C770 VA: 0x18168E170 Slot: 103
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x168E620 Offset: 0x168CC20 VA: 0x18168E620 Slot: 122
	public override void WriteValue(Uri value) { }

	// RVA: 0x168D570 Offset: 0x168BB70 VA: 0x18168D570
	public void WriteObjectId(byte[] value) { }

	// RVA: 0x168D710 Offset: 0x168BD10 VA: 0x18168D710
	public void WriteRegex(string pattern, string options) { }
}

