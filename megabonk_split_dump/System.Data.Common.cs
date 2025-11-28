// Namespace: System.Data.Common
internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 8798
{
	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x1B4C400 Offset: 0x1B4AA00 VA: 0x181B4C400
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x1B48FD0 Offset: 0x1B475D0 VA: 0x181B48FD0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B496D0 Offset: 0x1B47CD0 VA: 0x181B496D0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B49150 Offset: 0x1B47750 VA: 0x181B49150 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x1B49010 Offset: 0x1B47610 VA: 0x181B49010
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x1B492D0 Offset: 0x1B478D0 VA: 0x181B492D0
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x1B4AB40 Offset: 0x1B49140 VA: 0x181B4AB40 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B4B400 Offset: 0x1B49A00 VA: 0x181B4B400 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x1B4AC10 Offset: 0x1B49210 VA: 0x181B4AC10
	private ObjectStorage.Families GetFamily(Type dataType) { }

	// RVA: 0x1B4B440 Offset: 0x1B49A40 VA: 0x181B4B440 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B4B7A0 Offset: 0x1B49DA0 VA: 0x181B4B7A0 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x1B4B470 Offset: 0x1B49A70 VA: 0x181B4B470 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B49E60 Offset: 0x1B48460 VA: 0x181B49E60 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B4A290 Offset: 0x1B48890 VA: 0x181B4A290 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1B49920 Offset: 0x1B47F20 VA: 0x181B49920 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B497F0 Offset: 0x1B47DF0 VA: 0x181B497F0 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1B4ABD0 Offset: 0x1B491D0 VA: 0x181B4ABD0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B4A8C0 Offset: 0x1B48EC0 VA: 0x181B4A8C0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B4B540 Offset: 0x1B49B40 VA: 0x181B4B540 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1B4C1D0 Offset: 0x1B4A7D0 VA: 0x181B4C1D0
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x1B4AD50 Offset: 0x1B49350 VA: 0x181B4AD50
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x1B4ADD0 Offset: 0x1B493D0 VA: 0x181B4ADD0
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x1B4C300 Offset: 0x1B4A900 VA: 0x181B4C300
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal static class ADP // TypeDefIndex: 8799
{
	// Fields
	private static readonly Type s_stackOverflowType; // 0x0
	private static readonly Type s_outOfMemoryType; // 0x8
	private static readonly Type s_threadAbortType; // 0x10
	private static readonly Type s_nullReferenceType; // 0x18
	private static readonly Type s_accessViolationType; // 0x20
	private static readonly Type s_securityType; // 0x28
	internal static readonly string StrEmpty; // 0x30
	internal static readonly string[] AzureSqlServerEndpoints; // 0x38
	internal static readonly IntPtr PtrZero; // 0x40
	internal static readonly int PtrSize; // 0x48

	// Methods

	// RVA: 0x1B6A2C0 Offset: 0x1B688C0 VA: 0x181B6A2C0
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x1B6A120 Offset: 0x1B68720 VA: 0x181B6A120
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x1B6A1F0 Offset: 0x1B687F0 VA: 0x181B6A1F0
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x1B69840 Offset: 0x1B67E40 VA: 0x181B69840
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x1B69730 Offset: 0x1B67D30 VA: 0x181B69730
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x1B697B0 Offset: 0x1B67DB0 VA: 0x181B697B0
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x1B69AE0 Offset: 0x1B680E0 VA: 0x181B69AE0
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x1B6A0A0 Offset: 0x1B686A0 VA: 0x181B6A0A0
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x1B69C50 Offset: 0x1B68250 VA: 0x181B69C50
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x1B69EA0 Offset: 0x1B684A0 VA: 0x181B69EA0
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x1B69950 Offset: 0x1B67F50 VA: 0x181B69950
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x1B69BF0 Offset: 0x1B681F0 VA: 0x181B69BF0
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x1B698C0 Offset: 0x1B67EC0 VA: 0x181B698C0
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x1B69A50 Offset: 0x1B68050 VA: 0x181B69A50
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x1B69B60 Offset: 0x1B68160 VA: 0x181B69B60
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x1B6A350 Offset: 0x1B68950 VA: 0x181B6A350
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x1B6A470 Offset: 0x1B68A70 VA: 0x181B6A470
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 8800
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x1B6C0F0 Offset: 0x1B6A6F0 VA: 0x181B6C0F0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B6A810 Offset: 0x1B68E10 VA: 0x181B6A810 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B6A9C0 Offset: 0x1B68FC0 VA: 0x181B6A9C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B6A850 Offset: 0x1B68E50 VA: 0x181B6A850 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B6B2B0 Offset: 0x1B698B0 VA: 0x181B6B2B0
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1B6AB10 Offset: 0x1B69110 VA: 0x181B6AB10
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1B6B970 Offset: 0x1B69F70 VA: 0x181B6B970 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B6BBF0 Offset: 0x1B6A1F0 VA: 0x181B6BBF0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B6BCE0 Offset: 0x1B6A2E0 VA: 0x181B6BCE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B6BF70 Offset: 0x1B6A570 VA: 0x181B6BF70 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B6BDD0 Offset: 0x1B6A3D0 VA: 0x181B6BDD0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B6BA10 Offset: 0x1B6A010 VA: 0x181B6BA10 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B6B1E0 Offset: 0x1B697E0 VA: 0x181B6B1E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B6BCA0 Offset: 0x1B6A2A0 VA: 0x181B6BCA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B6BAB0 Offset: 0x1B6A0B0 VA: 0x181B6BAB0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B6BEB0 Offset: 0x1B6A4B0 VA: 0x181B6BEB0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 8801
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x1B6CD80 Offset: 0x1B6B380 VA: 0x181B6CD80
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B6C230 Offset: 0x1B6A830 VA: 0x181B6C230 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B6C5D0 Offset: 0x1B6ABD0 VA: 0x181B6C5D0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B6C4E0 Offset: 0x1B6AAE0 VA: 0x181B6C4E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B6C700 Offset: 0x1B6AD00 VA: 0x181B6C700 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B6C960 Offset: 0x1B6AF60 VA: 0x181B6C960 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B6CA30 Offset: 0x1B6B030 VA: 0x181B6CA30 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B6CC50 Offset: 0x1B6B250 VA: 0x181B6CC50 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B6CAB0 Offset: 0x1B6B0B0 VA: 0x181B6CAB0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B6C7F0 Offset: 0x1B6ADF0 VA: 0x181B6C7F0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B6C680 Offset: 0x1B6AC80 VA: 0x181B6C680 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B6C9F0 Offset: 0x1B6AFF0 VA: 0x181B6C9F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B6C850 Offset: 0x1B6AE50 VA: 0x181B6C850 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B6CB90 Offset: 0x1B6B190 VA: 0x181B6CB90 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class ByteStorage : DataStorage // TypeDefIndex: 8802
{
	// Fields
	private byte[] _values; // 0x50

	// Methods

	// RVA: 0x1B6DDE0 Offset: 0x1B6C3E0 VA: 0x181B6DDE0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B6CE50 Offset: 0x1B6B450 VA: 0x181B6CE50 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B6D660 Offset: 0x1B6BC60 VA: 0x181B6D660 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B6D590 Offset: 0x1B6BB90 VA: 0x181B6D590 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B6D760 Offset: 0x1B6BD60 VA: 0x181B6D760 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B6D9C0 Offset: 0x1B6BFC0 VA: 0x181B6D9C0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B6DA90 Offset: 0x1B6C090 VA: 0x181B6DA90 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B6DCB0 Offset: 0x1B6C2B0 VA: 0x181B6DCB0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B6DB10 Offset: 0x1B6C110 VA: 0x181B6DB10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B6D850 Offset: 0x1B6BE50 VA: 0x181B6D850 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B6D6E0 Offset: 0x1B6BCE0 VA: 0x181B6D6E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B6DA50 Offset: 0x1B6C050 VA: 0x181B6DA50 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B6D8B0 Offset: 0x1B6BEB0 VA: 0x181B6D8B0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B6DBF0 Offset: 0x1B6C1F0 VA: 0x181B6DBF0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class CharStorage : DataStorage // TypeDefIndex: 8803
{
	// Fields
	private char[] _values; // 0x50

	// Methods

	// RVA: 0x1B6EAA0 Offset: 0x1B6D0A0 VA: 0x181B6EAA0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B6DEB0 Offset: 0x1B6C4B0 VA: 0x181B6DEB0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B6E2A0 Offset: 0x1B6C8A0 VA: 0x181B6E2A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B6E1B0 Offset: 0x1B6C7B0 VA: 0x181B6E1B0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B6E3B0 Offset: 0x1B6C9B0 VA: 0x181B6E3B0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B6E610 Offset: 0x1B6CC10 VA: 0x181B6E610 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B6E6E0 Offset: 0x1B6CCE0 VA: 0x181B6E6E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B6E900 Offset: 0x1B6CF00 VA: 0x181B6E900 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B6E760 Offset: 0x1B6CD60 VA: 0x181B6E760 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B6E4A0 Offset: 0x1B6CAA0 VA: 0x181B6E4A0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B6E330 Offset: 0x1B6C930 VA: 0x181B6E330 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B6E6A0 Offset: 0x1B6CCA0 VA: 0x181B6E6A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B6E500 Offset: 0x1B6CB00 VA: 0x181B6E500 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B6E840 Offset: 0x1B6CE40 VA: 0x181B6E840 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal enum StorageType // TypeDefIndex: 8804
{
	// Fields
	public int value__; // 0x0
	public const StorageType Empty = 0;
	public const StorageType Object = 1;
	public const StorageType DBNull = 2;
	public const StorageType Boolean = 3;
	public const StorageType Char = 4;
	public const StorageType SByte = 5;
	public const StorageType Byte = 6;
	public const StorageType Int16 = 7;
	public const StorageType UInt16 = 8;
	public const StorageType Int32 = 9;
	public const StorageType UInt32 = 10;
	public const StorageType Int64 = 11;
	public const StorageType UInt64 = 12;
	public const StorageType Single = 13;
	public const StorageType Double = 14;
	public const StorageType Decimal = 15;
	public const StorageType DateTime = 16;
	public const StorageType TimeSpan = 17;
	public const StorageType String = 18;
	public const StorageType Guid = 19;
	public const StorageType ByteArray = 20;
	public const StorageType CharArray = 21;
	public const StorageType Type = 22;
	public const StorageType DateTimeOffset = 23;
	public const StorageType BigInteger = 24;
	public const StorageType Uri = 25;
	public const StorageType SqlBinary = 26;
	public const StorageType SqlBoolean = 27;
	public const StorageType SqlByte = 28;
	public const StorageType SqlBytes = 29;
	public const StorageType SqlChars = 30;
	public const StorageType SqlDateTime = 31;
	public const StorageType SqlDecimal = 32;
	public const StorageType SqlDouble = 33;
	public const StorageType SqlGuid = 34;
	public const StorageType SqlInt16 = 35;
	public const StorageType SqlInt32 = 36;
	public const StorageType SqlInt64 = 37;
	public const StorageType SqlMoney = 38;
	public const StorageType SqlSingle = 39;
	public const StorageType SqlString = 40;
}

// Namespace: System.Data.Common
internal abstract class DataStorage // TypeDefIndex: 8805
{
	// Fields
	private static readonly Type[] s_storageClassType; // 0x0
	internal readonly DataColumn _column; // 0x10
	internal readonly DataTable _table; // 0x18
	internal readonly Type _dataType; // 0x20
	internal readonly StorageType _storageTypeCode; // 0x28
	private BitArray _dbNullBits; // 0x30
	private readonly object _defaultValue; // 0x38
	internal readonly object _nullValue; // 0x40
	internal readonly bool _isCloneable; // 0x48
	internal readonly bool _isCustomDefinedType; // 0x49
	internal readonly bool _isStringType; // 0x4A
	internal readonly bool _isValueType; // 0x4B
	private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces; // 0x8
	private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface; // 0x10

	// Properties
	internal DataSetDateTime DateTimeMode { get; }
	internal IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x1B72290 Offset: 0x1B70890 VA: 0x181B72290
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x1B720C0 Offset: 0x1B706C0 VA: 0x181B720C0
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x1B720F0 Offset: 0x1B706F0 VA: 0x181B720F0
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x1B72340 Offset: 0x1B70940 VA: 0x181B72340
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1B72360 Offset: 0x1B70960 VA: 0x181B72360
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1B6EC00 Offset: 0x1B6D200 VA: 0x181B6EC00 Slot: 4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1B6EB70 Offset: 0x1B6D170 VA: 0x181B6EB70
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x1B6ECA0 Offset: 0x1B6D2A0 VA: 0x181B6ECA0
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int CompareValueTo(int recordNo1, object value);

	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470 Slot: 7
	public virtual object ConvertValue(object value) { }

	// RVA: 0x1B6EDC0 Offset: 0x1B6D3C0 VA: 0x181B6EDC0
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Copy(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object Get(int recordNo);

	// RVA: 0x1B70340 Offset: 0x1B6E940 VA: 0x181B70340
	protected object GetBits(int recordNo) { }

	// RVA: 0x1B70530 Offset: 0x1B6EB30 VA: 0x181B70530 Slot: 10
	public virtual int GetStringLength(int record) { }

	// RVA: 0x1B706C0 Offset: 0x1B6ECC0 VA: 0x181B706C0
	protected bool HasValue(int recordNo) { }

	// RVA: 0x1B70AD0 Offset: 0x1B6F0D0 VA: 0x181B70AD0 Slot: 11
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Set(int recordNo, object value);

	// RVA: 0x1B70F30 Offset: 0x1B6F530 VA: 0x181B70F30
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x1B70EA0 Offset: 0x1B6F4A0 VA: 0x181B70EA0 Slot: 13
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ConvertXmlToObject(string s);

	// RVA: 0x1B6ED70 Offset: 0x1B6D370 VA: 0x181B6ED70 Slot: 15
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string ConvertObjectToXml(object value);

	// RVA: 0x1B6ED20 Offset: 0x1B6D320 VA: 0x181B6ED20 Slot: 17
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1B6EE30 Offset: 0x1B6D430 VA: 0x181B6EE30
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x1B70410 Offset: 0x1B6EA10 VA: 0x181B70410
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x1B70540 Offset: 0x1B6EB40 VA: 0x181B70540
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x1B70E40 Offset: 0x1B6F440 VA: 0x181B70E40
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x1B70E30 Offset: 0x1B6F430 VA: 0x181B70E30
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x1B70E20 Offset: 0x1B6F420 VA: 0x181B70E20
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x1B70D10 Offset: 0x1B6F310 VA: 0x181B70D10
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x1B702B0 Offset: 0x1B6E8B0 VA: 0x181B702B0
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x1B707B0 Offset: 0x1B6EDB0 VA: 0x181B707B0
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0x1B70920 Offset: 0x1B6EF20 VA: 0x181B70920
	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x1B706F0 Offset: 0x1B6ECF0 VA: 0x181B706F0
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x1B70AF0 Offset: 0x1B6F0F0 VA: 0x181B70AF0
	public static bool IsObjectNull(object value) { }

	// RVA: 0x1B70C40 Offset: 0x1B6F240 VA: 0x181B70C40
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x1B70380 Offset: 0x1B6E980 VA: 0x181B70380
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x1B6EE10 Offset: 0x1B6D410 VA: 0x181B6EE10
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B70F50 Offset: 0x1B6F550 VA: 0x181B70F50
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract object GetEmptyStorage(int recordCount);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void SetStorage(object store, BitArray nullbits);

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x1B705B0 Offset: 0x1B6EBB0 VA: 0x181B705B0
	internal static Type GetType(string value) { }

	// RVA: 0x1B703A0 Offset: 0x1B6E9A0 VA: 0x181B703A0
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x1B70F70 Offset: 0x1B6F570 VA: 0x181B70F70
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 8806
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0x1B733B0 Offset: 0x1B719B0 VA: 0x181B733B0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B72380 Offset: 0x1B70980 VA: 0x181B72380 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B729A0 Offset: 0x1B70FA0 VA: 0x181B729A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B72800 Offset: 0x1B70E00 VA: 0x181B72800 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B72C10 Offset: 0x1B71210 VA: 0x181B72C10 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B72E60 Offset: 0x1B71460 VA: 0x181B72E60 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B72F30 Offset: 0x1B71530 VA: 0x181B72F30 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B73210 Offset: 0x1B71810 VA: 0x181B73210 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B73070 Offset: 0x1B71670 VA: 0x181B73070 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B72CB0 Offset: 0x1B712B0 VA: 0x181B72CB0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B72B80 Offset: 0x1B71180 VA: 0x181B72B80 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B72EF0 Offset: 0x1B714F0 VA: 0x181B72EF0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B72D30 Offset: 0x1B71330 VA: 0x181B72D30 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B73150 Offset: 0x1B71750 VA: 0x181B73150 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1B73340 Offset: 0x1B71940 VA: 0x181B73340
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 8807
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x1B748A0 Offset: 0x1B72EA0 VA: 0x181B748A0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B734C0 Offset: 0x1B71AC0 VA: 0x181B734C0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B73A70 Offset: 0x1B72070 VA: 0x181B73A70 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B738F0 Offset: 0x1B71EF0 VA: 0x181B738F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B73CD0 Offset: 0x1B722D0 VA: 0x181B73CD0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B73FF0 Offset: 0x1B725F0 VA: 0x181B73FF0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B740C0 Offset: 0x1B726C0 VA: 0x181B740C0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B744F0 Offset: 0x1B72AF0 VA: 0x181B744F0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B741D0 Offset: 0x1B727D0 VA: 0x181B741D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B73DD0 Offset: 0x1B723D0 VA: 0x181B73DD0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B73BE0 Offset: 0x1B721E0 VA: 0x181B73BE0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B74080 Offset: 0x1B72680 VA: 0x181B74080 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B73E80 Offset: 0x1B72480 VA: 0x181B73E80 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B742B0 Offset: 0x1B728B0 VA: 0x181B742B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1B74830 Offset: 0x1B72E30 VA: 0x181B74830
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 8808
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x1B75E10 Offset: 0x1B74410 VA: 0x181B75E10
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B749B0 Offset: 0x1B72FB0 VA: 0x181B749B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B75520 Offset: 0x1B73B20 VA: 0x181B75520 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B75380 Offset: 0x1B73980 VA: 0x181B75380 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B75760 Offset: 0x1B73D60 VA: 0x181B75760 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B72E60 Offset: 0x1B71460 VA: 0x181B72E60 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B75A60 Offset: 0x1B74060 VA: 0x181B75A60 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B75CA0 Offset: 0x1B742A0 VA: 0x181B75CA0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B75B00 Offset: 0x1B74100 VA: 0x181B75B00 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B75870 Offset: 0x1B73E70 VA: 0x181B75870 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B756D0 Offset: 0x1B73CD0 VA: 0x181B756D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B75A20 Offset: 0x1B74020 VA: 0x181B75A20 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B758F0 Offset: 0x1B73EF0 VA: 0x181B758F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B75BE0 Offset: 0x1B741E0 VA: 0x181B75BE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 8809
{
	// Fields
	private double[] _values; // 0x50

	// Methods

	// RVA: 0x1B76E40 Offset: 0x1B75440 VA: 0x181B76E40
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B75F10 Offset: 0x1B74510 VA: 0x181B75F10 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B76680 Offset: 0x1B74C80 VA: 0x181B76680 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B765A0 Offset: 0x1B74BA0 VA: 0x181B765A0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B76790 Offset: 0x1B74D90 VA: 0x181B76790 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B76A10 Offset: 0x1B75010 VA: 0x181B76A10 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B76AE0 Offset: 0x1B750E0 VA: 0x181B76AE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B76D00 Offset: 0x1B75300 VA: 0x181B76D00 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B76B60 Offset: 0x1B75160 VA: 0x181B76B60 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B76880 Offset: 0x1B74E80 VA: 0x181B76880 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B76710 Offset: 0x1B74D10 VA: 0x181B76710 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B76AA0 Offset: 0x1B750A0 VA: 0x181B76AA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B768F0 Offset: 0x1B74EF0 VA: 0x181B768F0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B76C40 Offset: 0x1B75240 VA: 0x181B76C40 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int16Storage : DataStorage // TypeDefIndex: 8810
{
	// Fields
	private short[] _values; // 0x50

	// Methods

	// RVA: 0x1B77E80 Offset: 0x1B76480 VA: 0x181B77E80
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B76F10 Offset: 0x1B75510 VA: 0x181B76F10 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B777A0 Offset: 0x1B75DA0 VA: 0x181B777A0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B776D0 Offset: 0x1B75CD0 VA: 0x181B776D0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B77890 Offset: 0x1B75E90 VA: 0x181B77890 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B6E610 Offset: 0x1B6CC10 VA: 0x181B6E610 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B77B30 Offset: 0x1B76130 VA: 0x181B77B30 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B77D50 Offset: 0x1B76350 VA: 0x181B77D50 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B77BB0 Offset: 0x1B761B0 VA: 0x181B77BB0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B77980 Offset: 0x1B75F80 VA: 0x181B77980 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B77810 Offset: 0x1B75E10 VA: 0x181B77810 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B77AF0 Offset: 0x1B760F0 VA: 0x181B77AF0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B779E0 Offset: 0x1B75FE0 VA: 0x181B779E0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B77C90 Offset: 0x1B76290 VA: 0x181B77C90 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int32Storage : DataStorage // TypeDefIndex: 8811
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x1B78F40 Offset: 0x1B77540 VA: 0x181B78F40
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B77F50 Offset: 0x1B76550 VA: 0x181B77F50 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B787C0 Offset: 0x1B76DC0 VA: 0x181B787C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B78700 Offset: 0x1B76D00 VA: 0x181B78700 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B788D0 Offset: 0x1B76ED0 VA: 0x181B788D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B78B20 Offset: 0x1B77120 VA: 0x181B78B20 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B78BF0 Offset: 0x1B771F0 VA: 0x181B78BF0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B78E10 Offset: 0x1B77410 VA: 0x181B78E10 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B78C70 Offset: 0x1B77270 VA: 0x181B78C70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B789C0 Offset: 0x1B76FC0 VA: 0x181B789C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B78850 Offset: 0x1B76E50 VA: 0x181B78850 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B78BB0 Offset: 0x1B771B0 VA: 0x181B78BB0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B78A20 Offset: 0x1B77020 VA: 0x181B78A20 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B78D50 Offset: 0x1B77350 VA: 0x181B78D50 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int64Storage : DataStorage // TypeDefIndex: 8812
{
	// Fields
	private long[] _values; // 0x50

	// Methods

	// RVA: 0x1B7A010 Offset: 0x1B78610 VA: 0x181B7A010
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1B79010 Offset: 0x1B77610 VA: 0x181B79010 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B79890 Offset: 0x1B77E90 VA: 0x181B79890 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B797C0 Offset: 0x1B77DC0 VA: 0x181B797C0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B79990 Offset: 0x1B77F90 VA: 0x181B79990 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B79BE0 Offset: 0x1B781E0 VA: 0x181B79BE0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B79CB0 Offset: 0x1B782B0 VA: 0x181B79CB0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B79ED0 Offset: 0x1B784D0 VA: 0x181B79ED0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B79D30 Offset: 0x1B78330 VA: 0x181B79D30 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B79A80 Offset: 0x1B78080 VA: 0x181B79A80 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B79910 Offset: 0x1B77F10 VA: 0x181B79910 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B79C70 Offset: 0x1B78270 VA: 0x181B79C70 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B79AE0 Offset: 0x1B780E0 VA: 0x181B79AE0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B79E10 Offset: 0x1B78410 VA: 0x181B79E10 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SByteStorage : DataStorage // TypeDefIndex: 8813
{
	// Fields
	private sbyte[] _values; // 0x50

	// Methods

	// RVA: 0x1B7B050 Offset: 0x1B79650 VA: 0x181B7B050
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B7A0E0 Offset: 0x1B786E0 VA: 0x181B7A0E0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B7A900 Offset: 0x1B78F00 VA: 0x181B7A900 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B7A830 Offset: 0x1B78E30 VA: 0x181B7A830 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B7AA40 Offset: 0x1B79040 VA: 0x181B7AA40 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B6D9C0 Offset: 0x1B6BFC0 VA: 0x181B6D9C0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B7ACE0 Offset: 0x1B792E0 VA: 0x181B7ACE0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B7AF20 Offset: 0x1B79520 VA: 0x181B7AF20 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B7AD80 Offset: 0x1B79380 VA: 0x181B7AD80 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B7AB30 Offset: 0x1B79130 VA: 0x181B7AB30 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B7A9C0 Offset: 0x1B78FC0 VA: 0x181B7A9C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B7ACA0 Offset: 0x1B792A0 VA: 0x181B7ACA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B7AB90 Offset: 0x1B79190 VA: 0x181B7AB90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B7AE60 Offset: 0x1B79460 VA: 0x181B7AE60 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal static class SqlConvert // TypeDefIndex: 8814
{
	// Methods

	// RVA: 0x1B829F0 Offset: 0x1B80FF0 VA: 0x181B829F0
	public static SqlByte ConvertToSqlByte(object value) { }

	// RVA: 0x1B83FF0 Offset: 0x1B825F0 VA: 0x181B83FF0
	public static SqlInt16 ConvertToSqlInt16(object value) { }

	// RVA: 0x1B84270 Offset: 0x1B82870 VA: 0x181B84270
	public static SqlInt32 ConvertToSqlInt32(object value) { }

	// RVA: 0x1B84600 Offset: 0x1B82C00 VA: 0x181B84600
	public static SqlInt64 ConvertToSqlInt64(object value) { }

	// RVA: 0x1B836C0 Offset: 0x1B81CC0 VA: 0x181B836C0
	public static SqlDouble ConvertToSqlDouble(object value) { }

	// RVA: 0x1B83030 Offset: 0x1B81630 VA: 0x181B83030
	public static SqlDecimal ConvertToSqlDecimal(object value) { }

	// RVA: 0x1B85090 Offset: 0x1B83690 VA: 0x181B85090
	public static SqlSingle ConvertToSqlSingle(object value) { }

	// RVA: 0x1B84AA0 Offset: 0x1B830A0 VA: 0x181B84AA0
	public static SqlMoney ConvertToSqlMoney(object value) { }

	// RVA: 0x1B82E30 Offset: 0x1B81430 VA: 0x181B82E30
	public static SqlDateTime ConvertToSqlDateTime(object value) { }

	// RVA: 0x1B82840 Offset: 0x1B80E40 VA: 0x181B82840
	public static SqlBoolean ConvertToSqlBoolean(object value) { }

	// RVA: 0x1B83E20 Offset: 0x1B82420 VA: 0x181B83E20
	public static SqlGuid ConvertToSqlGuid(object value) { }

	// RVA: 0x1B82680 Offset: 0x1B80C80 VA: 0x181B82680
	public static SqlBinary ConvertToSqlBinary(object value) { }

	// RVA: 0x1B85780 Offset: 0x1B83D80 VA: 0x181B85780
	public static SqlString ConvertToSqlString(object value) { }

	// RVA: 0x1B82CF0 Offset: 0x1B812F0 VA: 0x181B82CF0
	public static SqlChars ConvertToSqlChars(object value) { }

	// RVA: 0x1B82BB0 Offset: 0x1B811B0 VA: 0x181B82BB0
	public static SqlBytes ConvertToSqlBytes(object value) { }

	// RVA: 0x1B82600 Offset: 0x1B80C00 VA: 0x181B82600
	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	// RVA: 0x1B804F0 Offset: 0x1B7EAF0 VA: 0x181B804F0
	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1B7EA40 Offset: 0x1B7D040 VA: 0x181B7EA40
	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1B806B0 Offset: 0x1B7ECB0 VA: 0x181B806B0
	public static object ChangeTypeForXML(object value, Type type) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 8815
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x1B7BCA0 Offset: 0x1B7A2A0 VA: 0x181B7BCA0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B7B120 Offset: 0x1B79720 VA: 0x181B7B120 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B7B390 Offset: 0x1B79990 VA: 0x181B7B390 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B7B2E0 Offset: 0x1B798E0 VA: 0x181B7B2E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B7B5E0 Offset: 0x1B79BE0 VA: 0x181B7B5E0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B7B950 Offset: 0x1B79F50 VA: 0x181B7B950 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B7B9E0 Offset: 0x1B79FE0 VA: 0x181B7B9E0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B7BA50 Offset: 0x1B7A050 VA: 0x181B7BA50 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B7BC40 Offset: 0x1B7A240 VA: 0x181B7BC40 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B7BAD0 Offset: 0x1B7A0D0 VA: 0x181B7BAD0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B7B650 Offset: 0x1B79C50 VA: 0x181B7B650 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B7B430 Offset: 0x1B79A30 VA: 0x181B7B430 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B7B9A0 Offset: 0x1B79FA0 VA: 0x181B7B9A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B7B830 Offset: 0x1B79E30 VA: 0x181B7B830 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B7BBA0 Offset: 0x1B7A1A0 VA: 0x181B7BBA0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 8816
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x1B7D450 Offset: 0x1B7BA50 VA: 0x181B7D450
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B7BDD0 Offset: 0x1B7A3D0 VA: 0x181B7BDD0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B7CB80 Offset: 0x1B7B180 VA: 0x181B7CB80 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B7CAD0 Offset: 0x1B7B0D0 VA: 0x181B7CAD0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B7CDD0 Offset: 0x1B7B3D0 VA: 0x181B7CDD0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B7D120 Offset: 0x1B7B720 VA: 0x181B7D120 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B7D1A0 Offset: 0x1B7B7A0 VA: 0x181B7D1A0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B7D210 Offset: 0x1B7B810 VA: 0x181B7D210 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B7D400 Offset: 0x1B7BA00 VA: 0x181B7D400 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B7D290 Offset: 0x1B7B890 VA: 0x181B7D290 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B7CE40 Offset: 0x1B7B440 VA: 0x181B7CE40 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B7CC20 Offset: 0x1B7B220 VA: 0x181B7CC20 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B7D160 Offset: 0x1B7B760 VA: 0x181B7D160 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B7D010 Offset: 0x1B7B610 VA: 0x181B7D010 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B7D360 Offset: 0x1B7B960 VA: 0x181B7D360 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 8817
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x1B7DF40 Offset: 0x1B7C540 VA: 0x181B7DF40
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B7D580 Offset: 0x1B7BB80 VA: 0x181B7D580 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B7DBD0 Offset: 0x1B7C1D0 VA: 0x181B7DBD0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B7DC60 Offset: 0x1B7C260 VA: 0x181B7DC60 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B7DC90 Offset: 0x1B7C290 VA: 0x181B7DC90 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B7DE40 Offset: 0x1B7C440 VA: 0x181B7DE40 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B7DCD0 Offset: 0x1B7C2D0 VA: 0x181B7DCD0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B7D8B0 Offset: 0x1B7BEB0 VA: 0x181B7D8B0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B7D700 Offset: 0x1B7BD00 VA: 0x181B7D700 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B7DC20 Offset: 0x1B7C220 VA: 0x181B7DC20 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B7DAB0 Offset: 0x1B7C0B0 VA: 0x181B7DAB0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B7DDA0 Offset: 0x1B7C3A0 VA: 0x181B7DDA0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 8818
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x1B7E950 Offset: 0x1B7CF50 VA: 0x181B7E950
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B7E030 Offset: 0x1B7C630 VA: 0x181B7E030 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B7DBD0 Offset: 0x1B7C1D0 VA: 0x181B7DBD0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B7DC60 Offset: 0x1B7C260 VA: 0x181B7DC60 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B7DC90 Offset: 0x1B7C290 VA: 0x181B7DC90 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B7E850 Offset: 0x1B7CE50 VA: 0x181B7E850 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B7E6E0 Offset: 0x1B7CCE0 VA: 0x181B7E6E0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B7E360 Offset: 0x1B7C960 VA: 0x181B7E360 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B7E1B0 Offset: 0x1B7C7B0 VA: 0x181B7E1B0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B7E6A0 Offset: 0x1B7CCA0 VA: 0x181B7E6A0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B7E580 Offset: 0x1B7CB80 VA: 0x181B7E580 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B7E7B0 Offset: 0x1B7CDB0 VA: 0x181B7E7B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 8819
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x1B86900 Offset: 0x1B84F00 VA: 0x181B86900
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B85960 Offset: 0x1B83F60 VA: 0x181B85960 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B85F80 Offset: 0x1B84580 VA: 0x181B85F80 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B85EB0 Offset: 0x1B844B0 VA: 0x181B85EB0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B86200 Offset: 0x1B84800 VA: 0x181B86200 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B865A0 Offset: 0x1B84BA0 VA: 0x181B865A0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B86630 Offset: 0x1B84C30 VA: 0x181B86630 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B866B0 Offset: 0x1B84CB0 VA: 0x181B866B0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B868A0 Offset: 0x1B84EA0 VA: 0x181B868A0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B86730 Offset: 0x1B84D30 VA: 0x181B86730 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B86280 Offset: 0x1B84880 VA: 0x181B86280 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B86050 Offset: 0x1B84650 VA: 0x181B86050 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B865F0 Offset: 0x1B84BF0 VA: 0x181B865F0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B86470 Offset: 0x1B84A70 VA: 0x181B86470 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B86800 Offset: 0x1B84E00 VA: 0x181B86800 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 8820
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x1B88220 Offset: 0x1B86820 VA: 0x181B88220
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B86A60 Offset: 0x1B85060 VA: 0x181B86A60 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B878B0 Offset: 0x1B85EB0 VA: 0x181B878B0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B877E0 Offset: 0x1B85DE0 VA: 0x181B877E0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B87B20 Offset: 0x1B86120 VA: 0x181B87B20 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B87EC0 Offset: 0x1B864C0 VA: 0x181B87EC0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B87F50 Offset: 0x1B86550 VA: 0x181B87F50 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B87FD0 Offset: 0x1B865D0 VA: 0x181B87FD0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B881C0 Offset: 0x1B867C0 VA: 0x181B881C0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B88050 Offset: 0x1B86650 VA: 0x181B88050 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B87BA0 Offset: 0x1B861A0 VA: 0x181B87BA0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B87970 Offset: 0x1B85F70 VA: 0x181B87970 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B87F10 Offset: 0x1B86510 VA: 0x181B87F10 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B87D90 Offset: 0x1B86390 VA: 0x181B87D90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B88120 Offset: 0x1B86720 VA: 0x181B88120 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 8821
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x1B8BAC0 Offset: 0x1B8A0C0 VA: 0x181B8BAC0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B8A3F0 Offset: 0x1B889F0 VA: 0x181B8A3F0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B8B150 Offset: 0x1B89750 VA: 0x181B8B150 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B8B090 Offset: 0x1B89690 VA: 0x181B8B090 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B8B3C0 Offset: 0x1B899C0 VA: 0x181B8B3C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B8B760 Offset: 0x1B89D60 VA: 0x181B8B760 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B8B7F0 Offset: 0x1B89DF0 VA: 0x181B8B7F0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B8B870 Offset: 0x1B89E70 VA: 0x181B8B870 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B8BA60 Offset: 0x1B8A060 VA: 0x181B8BA60 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B8B8F0 Offset: 0x1B89EF0 VA: 0x181B8B8F0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B8B440 Offset: 0x1B89A40 VA: 0x181B8B440 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B8B210 Offset: 0x1B89810 VA: 0x181B8B210 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B8B7B0 Offset: 0x1B89DB0 VA: 0x181B8B7B0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B8B630 Offset: 0x1B89C30 VA: 0x181B8B630 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B8B9C0 Offset: 0x1B89FC0 VA: 0x181B8B9C0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 8822
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x1B8C730 Offset: 0x1B8AD30 VA: 0x181B8C730
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B8BC00 Offset: 0x1B8A200 VA: 0x181B8BC00 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B8BE70 Offset: 0x1B8A470 VA: 0x181B8BE70 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B8BDC0 Offset: 0x1B8A3C0 VA: 0x181B8BDC0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B8C0C0 Offset: 0x1B8A6C0 VA: 0x181B8C0C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B7B950 Offset: 0x1B79F50 VA: 0x181B7B950 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B8C470 Offset: 0x1B8AA70 VA: 0x181B8C470 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B8C4E0 Offset: 0x1B8AAE0 VA: 0x181B8C4E0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B8C6D0 Offset: 0x1B8ACD0 VA: 0x181B8C6D0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B8C560 Offset: 0x1B8AB60 VA: 0x181B8C560 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B8C130 Offset: 0x1B8A730 VA: 0x181B8C130 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B8BF10 Offset: 0x1B8A510 VA: 0x181B8BF10 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B8C430 Offset: 0x1B8AA30 VA: 0x181B8C430 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B8C310 Offset: 0x1B8A910 VA: 0x181B8C310 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B8C630 Offset: 0x1B8AC30 VA: 0x181B8C630 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 8823
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x1B8DEC0 Offset: 0x1B8C4C0 VA: 0x181B8DEC0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B8C860 Offset: 0x1B8AE60 VA: 0x181B8C860 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B8D600 Offset: 0x1B8BC00 VA: 0x181B8D600 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B8D550 Offset: 0x1B8BB50 VA: 0x181B8D550 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B8D850 Offset: 0x1B8BE50 VA: 0x181B8D850 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B8DBA0 Offset: 0x1B8C1A0 VA: 0x181B8DBA0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B8DC20 Offset: 0x1B8C220 VA: 0x181B8DC20 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B8DC90 Offset: 0x1B8C290 VA: 0x181B8DC90 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B8DE80 Offset: 0x1B8C480 VA: 0x181B8DE80 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B8DD10 Offset: 0x1B8C310 VA: 0x181B8DD10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B8D8C0 Offset: 0x1B8BEC0 VA: 0x181B8D8C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B8D6A0 Offset: 0x1B8BCA0 VA: 0x181B8D6A0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B8DBE0 Offset: 0x1B8C1E0 VA: 0x181B8DBE0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B8DA90 Offset: 0x1B8C090 VA: 0x181B8DA90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B8DDE0 Offset: 0x1B8C3E0 VA: 0x181B8DDE0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 8824
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x1B8F680 Offset: 0x1B8DC80 VA: 0x181B8F680
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B8DFF0 Offset: 0x1B8C5F0 VA: 0x181B8DFF0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B8EDA0 Offset: 0x1B8D3A0 VA: 0x181B8EDA0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B8ECF0 Offset: 0x1B8D2F0 VA: 0x181B8ECF0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B8EFF0 Offset: 0x1B8D5F0 VA: 0x181B8EFF0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B8F350 Offset: 0x1B8D950 VA: 0x181B8F350 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B8F3D0 Offset: 0x1B8D9D0 VA: 0x181B8F3D0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B8F440 Offset: 0x1B8DA40 VA: 0x181B8F440 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B8F630 Offset: 0x1B8DC30 VA: 0x181B8F630 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B8F4C0 Offset: 0x1B8DAC0 VA: 0x181B8F4C0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B8F060 Offset: 0x1B8D660 VA: 0x181B8F060 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B8EE40 Offset: 0x1B8D440 VA: 0x181B8EE40 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B8F390 Offset: 0x1B8D990 VA: 0x181B8F390 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B8F240 Offset: 0x1B8D840 VA: 0x181B8F240 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B8F590 Offset: 0x1B8DB90 VA: 0x181B8F590 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 8825
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x1B90F50 Offset: 0x1B8F550 VA: 0x181B90F50
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B8F7B0 Offset: 0x1B8DDB0 VA: 0x181B8F7B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B90630 Offset: 0x1B8EC30 VA: 0x181B90630 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B90570 Offset: 0x1B8EB70 VA: 0x181B90570 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B908A0 Offset: 0x1B8EEA0 VA: 0x181B908A0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B8B760 Offset: 0x1B89D60 VA: 0x181B8B760 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B90C80 Offset: 0x1B8F280 VA: 0x181B90C80 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B90D00 Offset: 0x1B8F300 VA: 0x181B90D00 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B90EF0 Offset: 0x1B8F4F0 VA: 0x181B90EF0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B90D80 Offset: 0x1B8F380 VA: 0x181B90D80 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B90920 Offset: 0x1B8EF20 VA: 0x181B90920 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B906F0 Offset: 0x1B8ECF0 VA: 0x181B906F0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B90C40 Offset: 0x1B8F240 VA: 0x181B90C40 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B90B10 Offset: 0x1B8F110 VA: 0x181B90B10 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B90E50 Offset: 0x1B8F450 VA: 0x181B90E50 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 8826
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x1B92870 Offset: 0x1B90E70 VA: 0x181B92870
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B91090 Offset: 0x1B8F690 VA: 0x181B91090 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B91F50 Offset: 0x1B90550 VA: 0x181B91F50 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B91E90 Offset: 0x1B90490 VA: 0x181B91E90 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B921C0 Offset: 0x1B907C0 VA: 0x181B921C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B8B760 Offset: 0x1B89D60 VA: 0x181B8B760 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B925A0 Offset: 0x1B90BA0 VA: 0x181B925A0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B92620 Offset: 0x1B90C20 VA: 0x181B92620 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B92810 Offset: 0x1B90E10 VA: 0x181B92810 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B926A0 Offset: 0x1B90CA0 VA: 0x181B926A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B92240 Offset: 0x1B90840 VA: 0x181B92240 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B92010 Offset: 0x1B90610 VA: 0x181B92010 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B92560 Offset: 0x1B90B60 VA: 0x181B92560 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B92430 Offset: 0x1B90A30 VA: 0x181B92430 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B92770 Offset: 0x1B90D70 VA: 0x181B92770 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 8827
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x1B93FC0 Offset: 0x1B925C0 VA: 0x181B93FC0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B929B0 Offset: 0x1B90FB0 VA: 0x181B929B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B93720 Offset: 0x1B91D20 VA: 0x181B93720 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B93670 Offset: 0x1B91C70 VA: 0x181B93670 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B93970 Offset: 0x1B91F70 VA: 0x181B93970 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B8F350 Offset: 0x1B8D950 VA: 0x181B8F350 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B93D10 Offset: 0x1B92310 VA: 0x181B93D10 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B93D80 Offset: 0x1B92380 VA: 0x181B93D80 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B93F70 Offset: 0x1B92570 VA: 0x181B93F70 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B93E00 Offset: 0x1B92400 VA: 0x181B93E00 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B939E0 Offset: 0x1B91FE0 VA: 0x181B939E0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B937C0 Offset: 0x1B91DC0 VA: 0x181B937C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B93CD0 Offset: 0x1B922D0 VA: 0x181B93CD0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B93BC0 Offset: 0x1B921C0 VA: 0x181B93BC0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B93ED0 Offset: 0x1B924D0 VA: 0x181B93ED0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 8828
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x1B95130 Offset: 0x1B93730 VA: 0x181B95130
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B940F0 Offset: 0x1B926F0 VA: 0x181B940F0 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1B94540 Offset: 0x1B92B40 VA: 0x181B94540 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B945C0 Offset: 0x1B92BC0 VA: 0x181B945C0
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x1B94450 Offset: 0x1B92A50 VA: 0x181B94450 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B948D0 Offset: 0x1B92ED0 VA: 0x181B948D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B94CB0 Offset: 0x1B932B0 VA: 0x181B94CB0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B94E40 Offset: 0x1B93440 VA: 0x181B94E40 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B94D60 Offset: 0x1B93360 VA: 0x181B94D60 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x1B94EC0 Offset: 0x1B934C0 VA: 0x181B94EC0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B950B0 Offset: 0x1B936B0 VA: 0x181B950B0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B94F40 Offset: 0x1B93540 VA: 0x181B94F40 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B94950 Offset: 0x1B92F50 VA: 0x181B94950 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B94720 Offset: 0x1B92D20 VA: 0x181B94720 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B94D20 Offset: 0x1B93320 VA: 0x181B94D20 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B94B50 Offset: 0x1B93150 VA: 0x181B94B50 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B95010 Offset: 0x1B93610 VA: 0x181B95010 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 8829
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x1B8A2C0 Offset: 0x1B888C0 VA: 0x181B8A2C0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B895B0 Offset: 0x1B87BB0 VA: 0x181B895B0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B89A00 Offset: 0x1B88000 VA: 0x181B89A00 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B89950 Offset: 0x1B87F50 VA: 0x181B89950 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B89C50 Offset: 0x1B88250 VA: 0x181B89C50 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B89FA0 Offset: 0x1B885A0 VA: 0x181B89FA0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B8A020 Offset: 0x1B88620 VA: 0x181B8A020 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B8A090 Offset: 0x1B88690 VA: 0x181B8A090 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B8A280 Offset: 0x1B88880 VA: 0x181B8A280 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B8A110 Offset: 0x1B88710 VA: 0x181B8A110 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B89CC0 Offset: 0x1B882C0 VA: 0x181B89CC0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B89AA0 Offset: 0x1B880A0 VA: 0x181B89AA0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B89FE0 Offset: 0x1B885E0 VA: 0x181B89FE0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B89E90 Offset: 0x1B88490 VA: 0x181B89E90 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B8A1E0 Offset: 0x1B887E0 VA: 0x181B8A1E0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SingleStorage : DataStorage // TypeDefIndex: 8830
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x1B894E0 Offset: 0x1B87AE0 VA: 0x181B894E0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B88610 Offset: 0x1B86C10 VA: 0x181B88610 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B88DA0 Offset: 0x1B873A0 VA: 0x181B88DA0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B88CC0 Offset: 0x1B872C0 VA: 0x181B88CC0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B88EA0 Offset: 0x1B874A0 VA: 0x181B88EA0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B89120 Offset: 0x1B87720 VA: 0x181B89120 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B891C0 Offset: 0x1B877C0 VA: 0x181B891C0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B893C0 Offset: 0x1B879C0 VA: 0x181B893C0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B89220 Offset: 0x1B87820 VA: 0x181B89220 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B88F90 Offset: 0x1B87590 VA: 0x181B88F90 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B88E20 Offset: 0x1B87420 VA: 0x181B88E20 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B89180 Offset: 0x1B87780 VA: 0x181B89180 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B89000 Offset: 0x1B87600 VA: 0x181B89000 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B89300 Offset: 0x1B87900 VA: 0x181B89300 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 8832
{
	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly ConcurrentDictionary<Type, object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x1B96720 Offset: 0x1B94D20 VA: 0x181B96720
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x1B965A0 Offset: 0x1B94BA0 VA: 0x181B965A0
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x1B95FA0 Offset: 0x1B945A0 VA: 0x181B95FA0
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x1B960C0 Offset: 0x1B946C0 VA: 0x181B960C0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B95280 Offset: 0x1B93880 VA: 0x181B95280 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B95540 Offset: 0x1B93B40 VA: 0x181B95540 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B952C0 Offset: 0x1B938C0 VA: 0x181B952C0 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x1B95EB0 Offset: 0x1B944B0 VA: 0x181B95EB0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B7DC60 Offset: 0x1B7C260 VA: 0x181B7DC60 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x1B962F0 Offset: 0x1B948F0 VA: 0x181B962F0 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x1B96170 Offset: 0x1B94770 VA: 0x181B96170 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B95AF0 Offset: 0x1B940F0 VA: 0x181B95AF0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B958B0 Offset: 0x1B93EB0 VA: 0x181B958B0 Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1B95690 Offset: 0x1B93C90 VA: 0x181B95690 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B95580 Offset: 0x1B93B80 VA: 0x181B95580 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1B95F60 Offset: 0x1B94560 VA: 0x181B95F60 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B95D30 Offset: 0x1B94330 VA: 0x181B95D30 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B96250 Offset: 0x1B94850 VA: 0x181B96250 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1B96510 Offset: 0x1B94B10 VA: 0x181B96510
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class StringStorage : DataStorage // TypeDefIndex: 8833
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x1B97180 Offset: 0x1B95780 VA: 0x181B97180
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B969C0 Offset: 0x1B94FC0 VA: 0x181B969C0 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1B96CF0 Offset: 0x1B952F0 VA: 0x181B96CF0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B96C60 Offset: 0x1B95260 VA: 0x181B96C60 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B96DA0 Offset: 0x1B953A0 VA: 0x181B96DA0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B7DBD0 Offset: 0x1B7C1D0 VA: 0x181B7DBD0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B4B400 Offset: 0x1B49A00 VA: 0x181B4B400 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x1B96F30 Offset: 0x1B95530 VA: 0x181B96F30 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x1B4B440 Offset: 0x1B49A40 VA: 0x181B4B440 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B970E0 Offset: 0x1B956E0 VA: 0x181B970E0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B96F70 Offset: 0x1B95570 VA: 0x181B96F70 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B96D70 Offset: 0x1B95370 VA: 0x181B96D70 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B96EF0 Offset: 0x1B954F0 VA: 0x181B96EF0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B96DD0 Offset: 0x1B953D0 VA: 0x181B96DD0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B97040 Offset: 0x1B95640 VA: 0x181B97040 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 8834
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x1B989D0 Offset: 0x1B96FD0 VA: 0x181B989D0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B97240 Offset: 0x1B95840 VA: 0x181B97240 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B97F30 Offset: 0x1B96530 VA: 0x181B97F30 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B97DA0 Offset: 0x1B963A0 VA: 0x181B97DA0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B98130 Offset: 0x1B96730 VA: 0x181B98130
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x1B98310 Offset: 0x1B96910 VA: 0x181B98310 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B98530 Offset: 0x1B96B30 VA: 0x181B98530 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B985D0 Offset: 0x1B96BD0 VA: 0x181B985D0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B98870 Offset: 0x1B96E70 VA: 0x181B98870 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B986D0 Offset: 0x1B96CD0 VA: 0x181B986D0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B983B0 Offset: 0x1B969B0 VA: 0x181B983B0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B980A0 Offset: 0x1B966A0 VA: 0x181B980A0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B98590 Offset: 0x1B96B90 VA: 0x181B98590 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B98420 Offset: 0x1B96A20 VA: 0x181B98420 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B987B0 Offset: 0x1B96DB0 VA: 0x181B987B0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1B98960 Offset: 0x1B96F60 VA: 0x181B98960
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class UInt16Storage : DataStorage // TypeDefIndex: 8835
{
	// Fields
	private static readonly ushort s_defaultValue; // 0x0
	private ushort[] _values; // 0x50

	// Methods

	// RVA: 0x1B99C90 Offset: 0x1B98290 VA: 0x181B99C90
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B98C20 Offset: 0x1B97220 VA: 0x181B98C20 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B994C0 Offset: 0x1B97AC0 VA: 0x181B994C0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B993B0 Offset: 0x1B979B0 VA: 0x181B993B0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B99600 Offset: 0x1B97C00 VA: 0x181B99600 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B99850 Offset: 0x1B97E50 VA: 0x181B99850 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B998F0 Offset: 0x1B97EF0 VA: 0x181B998F0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B99B50 Offset: 0x1B98150 VA: 0x181B99B50 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B999B0 Offset: 0x1B97FB0 VA: 0x181B999B0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B996F0 Offset: 0x1B97CF0 VA: 0x181B996F0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B99580 Offset: 0x1B97B80 VA: 0x181B99580 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B998B0 Offset: 0x1B97EB0 VA: 0x181B998B0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B99750 Offset: 0x1B97D50 VA: 0x181B99750 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B99A90 Offset: 0x1B98090 VA: 0x181B99A90 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 8836
{
	// Fields
	private static readonly uint s_defaultValue; // 0x0
	private uint[] _values; // 0x50

	// Methods

	// RVA: 0x1B9ADC0 Offset: 0x1B993C0 VA: 0x181B9ADC0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B99D80 Offset: 0x1B98380 VA: 0x181B99D80 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B9A600 Offset: 0x1B98C00 VA: 0x181B9A600 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B9A4F0 Offset: 0x1B98AF0 VA: 0x181B9A4F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B9A750 Offset: 0x1B98D50 VA: 0x181B9A750 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B9A9A0 Offset: 0x1B98FA0 VA: 0x181B9A9A0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B9AA40 Offset: 0x1B99040 VA: 0x181B9AA40 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B9AC90 Offset: 0x1B99290 VA: 0x181B9AC90 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B9AAF0 Offset: 0x1B990F0 VA: 0x181B9AAF0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B9A840 Offset: 0x1B98E40 VA: 0x181B9A840 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B9A6D0 Offset: 0x1B98CD0 VA: 0x181B9A6D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B9AA00 Offset: 0x1B99000 VA: 0x181B9AA00 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B9A8A0 Offset: 0x1B98EA0 VA: 0x181B9A8A0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B9ABD0 Offset: 0x1B991D0 VA: 0x181B9ABD0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 8837
{
	// Fields
	private static readonly ulong s_defaultValue; // 0x0
	private ulong[] _values; // 0x50

	// Methods

	// RVA: 0x1B9BFD0 Offset: 0x1B9A5D0 VA: 0x181B9BFD0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B9AEA0 Offset: 0x1B994A0 VA: 0x181B9AEA0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B9B7B0 Offset: 0x1B99DB0 VA: 0x181B9B7B0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B9B6A0 Offset: 0x1B99CA0 VA: 0x181B9B6A0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B9B950 Offset: 0x1B99F50 VA: 0x181B9B950 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B9BBA0 Offset: 0x1B9A1A0 VA: 0x181B9BBA0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B9BC40 Offset: 0x1B9A240 VA: 0x181B9BC40 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B9BE90 Offset: 0x1B9A490 VA: 0x181B9BE90 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B9BCF0 Offset: 0x1B9A2F0 VA: 0x181B9BCF0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B9BA40 Offset: 0x1B9A040 VA: 0x181B9BA40 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B9B8D0 Offset: 0x1B99ED0 VA: 0x181B9B8D0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B9BC00 Offset: 0x1B9A200 VA: 0x181B9BC00 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B9BAA0 Offset: 0x1B9A0A0 VA: 0x181B9BAA0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B9BDD0 Offset: 0x1B9A3D0 VA: 0x181B9BDD0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

