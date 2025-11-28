// Namespace: System.Data
[ToolboxItem(False)]
[DesignTimeVisible(False)]
[DefaultProperty("ColumnName")]
[DefaultMember("Item")]
public class DataColumn : MarshalByValueComponent // TypeDefIndex: 8613
{
	// Fields
	private bool _allowNull; // 0x20
	private string _caption; // 0x28
	private string _columnName; // 0x30
	private Type _dataType; // 0x38
	private StorageType _storageType; // 0x40
	internal object _defaultValue; // 0x48
	private DataSetDateTime _dateTimeMode; // 0x50
	private DataExpression _expression; // 0x58
	private int _maxLength; // 0x60
	private int _ordinal; // 0x64
	private bool _readOnly; // 0x68
	internal Index _sortIndex; // 0x70
	internal DataTable _table; // 0x78
	private bool _unique; // 0x80
	internal MappingType _columnMapping; // 0x84
	internal int _hashCode; // 0x88
	internal int _errors; // 0x8C
	private bool _isSqlType; // 0x90
	private bool _implementsINullable; // 0x91
	private bool _implementsIChangeTracking; // 0x92
	private bool _implementsIRevertibleChangeTracking; // 0x93
	private bool _implementsIXMLSerializable; // 0x94
	private bool _defaultValueIsNull; // 0x95
	internal List<DataColumn> _dependentColumns; // 0x98
	internal PropertyCollection _extendedProperties; // 0xA0
	private DataStorage _storage; // 0xA8
	private AutoIncrementValue _autoInc; // 0xB0
	internal string _columnUri; // 0xB8
	private string _columnPrefix; // 0xC0
	internal string _encodedColumnName; // 0xC8
	internal SimpleType _simpleType; // 0xD0
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0xD8
	[CompilerGenerated]
	private string <XmlDataType>k__BackingField; // 0xE0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0xE8

	// Properties
	[DefaultValue(True)]
	public bool AllowDBNull { get; set; }
	[DefaultValue(False)]
	[RefreshProperties(1)]
	public bool AutoIncrement { get; set; }
	internal object AutoIncrementCurrent { get; set; }
	internal AutoIncrementValue AutoInc { get; }
	[DefaultValue(0)]
	public long AutoIncrementSeed { get; set; }
	[DefaultValue(1)]
	public long AutoIncrementStep { get; set; }
	public string Caption { get; set; }
	[DefaultValue("")]
	[RefreshProperties(1)]
	public string ColumnName { get; set; }
	internal string EncodedColumnName { get; }
	internal IFormatProvider FormatProvider { get; }
	internal CultureInfo Locale { get; }
	internal int ObjectID { get; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal bool Computed { get; }
	internal DataExpression DataExpression { get; }
	[DefaultValue(typeof(string))]
	[RefreshProperties(1)]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType { get; set; }
	[RefreshProperties(1)]
	[DefaultValue(3)]
	public DataSetDateTime DateTimeMode { get; set; }
	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue { get; set; }
	internal bool DefaultValueIsNull { get; }
	[RefreshProperties(1)]
	[DefaultValue("")]
	public string Expression { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool HasData { get; }
	internal bool ImplementsINullable { get; }
	internal bool ImplementsIChangeTracking { get; }
	internal bool ImplementsIRevertibleChangeTracking { get; }
	internal bool IsValueType { get; }
	internal bool IsSqlType { get; }
	[DefaultValue(-1)]
	public int MaxLength { get; set; }
	public string Namespace { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public int Ordinal { get; }
	[DefaultValue(False)]
	public bool ReadOnly { get; set; }
	[DebuggerBrowsable(0)]
	private Index SortIndex { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public DataTable Table { get; }
	internal object Item { get; set; }
	[DefaultValue(False)]
	[DesignerSerializationVisibility(0)]
	public bool Unique { get; set; }
	internal string XmlDataType { get; set; }
	internal SimpleType SimpleType { get; set; }
	[DefaultValue(1)]
	public virtual MappingType ColumnMapping { get; set; }
	internal bool IsCustomType { get; }
	internal bool ImplementsIXMLSerializable { get; }

	// Methods

	// RVA: 0x1AA9A30 Offset: 0x1AA8030 VA: 0x181AA9A30
	public void .ctor() { }

	// RVA: 0x1AA9A00 Offset: 0x1AA8000 VA: 0x181AA9A00
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0x1AA9A90 Offset: 0x1AA8090 VA: 0x181AA9A90
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0x1AA98D0 Offset: 0x1AA7ED0 VA: 0x181AA98D0
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_AllowDBNull() { }

	// RVA: 0x1AAA5D0 Offset: 0x1AA8BD0 VA: 0x181AAA5D0
	public void set_AllowDBNull(bool value) { }

	// RVA: 0x1AA9FB0 Offset: 0x1AA85B0 VA: 0x181AA9FB0
	public bool get_AutoIncrement() { }

	// RVA: 0x1AAAAF0 Offset: 0x1AA90F0 VA: 0x181AAAAF0
	public void set_AutoIncrement(bool value) { }

	// RVA: 0x1AA9F00 Offset: 0x1AA8500 VA: 0x181AA9F00
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0x1AAA750 Offset: 0x1AA8D50 VA: 0x181AAA750
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0x1AA9E00 Offset: 0x1AA8400 VA: 0x181AA9E00
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0x1AA9F50 Offset: 0x1AA8550 VA: 0x181AA9F50
	public long get_AutoIncrementSeed() { }

	// RVA: 0x1AAA8F0 Offset: 0x1AA8EF0 VA: 0x181AAA8F0
	public void set_AutoIncrementSeed(long value) { }

	// RVA: 0x1AA9F80 Offset: 0x1AA8580 VA: 0x181AA9F80
	public long get_AutoIncrementStep() { }

	// RVA: 0x1AAA9F0 Offset: 0x1AA8FF0 VA: 0x181AAA9F0
	public void set_AutoIncrementStep(long value) { }

	// RVA: 0x1AA9FD0 Offset: 0x1AA85D0 VA: 0x181AA9FD0
	public string get_Caption() { }

	// RVA: 0x1AAACD0 Offset: 0x1AA92D0 VA: 0x181AAACD0
	public void set_Caption(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_ColumnName() { }

	// RVA: 0x1AAB060 Offset: 0x1AA9660 VA: 0x181AAB060
	public void set_ColumnName(string value) { }

	// RVA: 0x1AAA180 Offset: 0x1AA8780 VA: 0x181AAA180
	internal string get_EncodedColumnName() { }

	// RVA: 0x1AAA2D0 Offset: 0x1AA88D0 VA: 0x181AAA2D0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1AAA440 Offset: 0x1AA8A40 VA: 0x181AAA440
	internal CultureInfo get_Locale() { }

	// RVA: 0x1AAA4E0 Offset: 0x1AA8AE0 VA: 0x181AAA4E0
	internal int get_ObjectID() { }

	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public string get_Prefix() { }

	// RVA: 0x1AAD340 Offset: 0x1AAB940 VA: 0x181AAD340
	public void set_Prefix(string value) { }

	// RVA: 0x1AA8180 Offset: 0x1AA6780 VA: 0x181AA8180
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0x1AA9FF0 Offset: 0x1AA85F0 VA: 0x181AA9FF0
	internal bool get_Computed() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal DataExpression get_DataExpression() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public Type get_DataType() { }

	// RVA: 0x1AAB4A0 Offset: 0x1AA9AA0 VA: 0x181AAB4A0
	public void set_DataType(Type value) { }

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1AABFE0 Offset: 0x1AAA5E0 VA: 0x181AABFE0
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0x1AAA010 Offset: 0x1AA8610 VA: 0x181AAA010
	public object get_DefaultValue() { }

	// RVA: 0x1AAC150 Offset: 0x1AAA750 VA: 0x181AAC150
	public void set_DefaultValue(object value) { }

	// RVA: 0x1AAA000 Offset: 0x1AA8600 VA: 0x181AAA000
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0x1AAA200 Offset: 0x1AA8800 VA: 0x181AAA200
	public string get_Expression() { }

	// RVA: 0x1AAC440 Offset: 0x1AAAA40 VA: 0x181AAC440
	public void set_Expression(string value) { }

	// RVA: 0x1AAA250 Offset: 0x1AA8850 VA: 0x181AAA250
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1AAA330 Offset: 0x1AA8930 VA: 0x181AAA330
	internal bool get_HasData() { }

	// RVA: 0x1AAA350 Offset: 0x1AA8950 VA: 0x181AAA350
	internal bool get_ImplementsINullable() { }

	// RVA: 0x1AAA340 Offset: 0x1AA8940 VA: 0x181AAA340
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0x1AAA360 Offset: 0x1AA8960 VA: 0x181AAA360
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0x1AAA3F0 Offset: 0x1AA89F0 VA: 0x181AAA3F0
	internal bool get_IsValueType() { }

	// RVA: 0x534920 Offset: 0x532F20 VA: 0x180534920
	internal bool get_IsSqlType() { }

	// RVA: 0x1AA93A0 Offset: 0x1AA79A0 VA: 0x181AA93A0
	private void SetMaxLengthSimpleType() { }

	// RVA: 0x3848A0 Offset: 0x382EA0 VA: 0x1803848A0
	public int get_MaxLength() { }

	// RVA: 0x1AACDB0 Offset: 0x1AAB3B0 VA: 0x181AACDB0
	public void set_MaxLength(int value) { }

	// RVA: 0x1AAA4A0 Offset: 0x1AA8AA0 VA: 0x181AAA4A0
	public string get_Namespace() { }

	// RVA: 0x1AAD1C0 Offset: 0x1AAB7C0 VA: 0x181AAD1C0
	public void set_Namespace(string value) { }

	// RVA: 0x3F3740 Offset: 0x3F1D40 VA: 0x1803F3740
	public int get_Ordinal() { }

	// RVA: 0x1AA94D0 Offset: 0x1AA7AD0 VA: 0x181AA94D0
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	public bool get_ReadOnly() { }

	// RVA: 0x1AAD4B0 Offset: 0x1AABAB0 VA: 0x181AAD4B0
	public void set_ReadOnly(bool value) { }

	// RVA: 0x1AAA4F0 Offset: 0x1AA8AF0 VA: 0x181AAA4F0
	private Index get_SortIndex() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public DataTable get_Table() { }

	// RVA: 0x1AA9660 Offset: 0x1AA7C60 VA: 0x181AA9660
	internal void SetTable(DataTable table) { }

	// RVA: 0x1AA8270 Offset: 0x1AA6870 VA: 0x181AA8270
	private DataRow GetDataRow(int index) { }

	// RVA: 0x1AAA410 Offset: 0x1AA8A10 VA: 0x181AAA410
	internal object get_Item(int record) { }

	// RVA: 0x1AACC10 Offset: 0x1AAB210 VA: 0x181AACC10
	internal void set_Item(int record, object value) { }

	// RVA: 0x1AA8690 Offset: 0x1AA6C90 VA: 0x181AA8690
	internal void InitializeRecord(int record) { }

	// RVA: 0x1AA9740 Offset: 0x1AA7D40 VA: 0x181AA9740
	internal void SetValue(int record, object value) { }

	// RVA: 0x1AA8060 Offset: 0x1AA6660 VA: 0x181AA8060
	internal void FreeRecord(int record) { }

	// RVA: 0x100F470 Offset: 0x100DA70 VA: 0x18100F470
	public bool get_Unique() { }

	// RVA: 0x1AAD5F0 Offset: 0x1AABBF0 VA: 0x181AAD5F0
	public void set_Unique(bool value) { }

	// RVA: 0x100F480 Offset: 0x100DA80 VA: 0x18100F480
	internal void InternalUnique(bool value) { }

	[CompilerGenerated]
	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	internal string get_XmlDataType() { }

	[CompilerGenerated]
	// RVA: 0x12F1A10 Offset: 0x12F0010 VA: 0x1812F1A10
	internal void set_XmlDataType(string value) { }

	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	internal SimpleType get_SimpleType() { }

	// RVA: 0x1AAD590 Offset: 0x1AABB90 VA: 0x181AAD590
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0x486A80 Offset: 0x485080 VA: 0x180486A80 Slot: 10
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0x1AAAD90 Offset: 0x1AA9390 VA: 0x181AAAD90 Slot: 11
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0x1AA6D60 Offset: 0x1AA5360 VA: 0x181AA6D60
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x1AA6F20 Offset: 0x1AA5520 VA: 0x181AA6F20
	internal bool CheckMaxLength() { }

	// RVA: 0x1AA6E90 Offset: 0x1AA5490 VA: 0x181AA6E90
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0x1AA71C0 Offset: 0x1AA57C0 VA: 0x181AA71C0
	protected internal void CheckNotAllowNull() { }

	// RVA: 0x1AA7510 Offset: 0x1AA5B10 VA: 0x181AA7510
	internal void CheckNullable(DataRow row) { }

	// RVA: 0x1AA75A0 Offset: 0x1AA5BA0 VA: 0x181AA75A0
	protected void CheckUnique() { }

	// RVA: 0x1AA7E30 Offset: 0x1AA6430 VA: 0x181AA7E30
	internal int Compare(int record1, int record2) { }

	// RVA: 0x1AA7C20 Offset: 0x1AA6220 VA: 0x181AA7C20
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0x1AA7E00 Offset: 0x1AA6400 VA: 0x181AA7E00
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0x1AA7F20 Offset: 0x1AA6520 VA: 0x181AA7F20
	internal object ConvertValue(object value) { }

	// RVA: 0x1AA8030 Offset: 0x1AA6630 VA: 0x181AA8030
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x1AA7600 Offset: 0x1AA5C00 VA: 0x181AA7600
	internal DataColumn Clone() { }

	// RVA: 0x1AA80A0 Offset: 0x1AA66A0 VA: 0x181AA80A0
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0x1AA82E0 Offset: 0x1AA68E0 VA: 0x181AA82E0
	private int GetStringLength(int record) { }

	// RVA: 0x1AA85D0 Offset: 0x1AA6BD0 VA: 0x181AA85D0
	internal void Init(int record) { }

	// RVA: 0x1AA8770 Offset: 0x1AA6D70 VA: 0x181AA8770
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0x1AAA380 Offset: 0x1AA8980 VA: 0x181AAA380
	internal bool get_IsCustomType() { }

	// RVA: 0x1AA9140 Offset: 0x1AA7740 VA: 0x181AA9140
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0x1AAA370 Offset: 0x1AA8970 VA: 0x181AAA370
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0x1AA8A00 Offset: 0x1AA7000 VA: 0x181AA8A00
	internal bool IsInRelation() { }

	// RVA: 0x1AA8B50 Offset: 0x1AA7150 VA: 0x181AA8B50
	internal bool IsMaxLengthViolated() { }

	// RVA: 0x1AA8F90 Offset: 0x1AA7590 VA: 0x181AA8F90
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0x1AA9210 Offset: 0x1AA7810 VA: 0x181AA9210 Slot: 12
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1AA9230 Offset: 0x1AA7830 VA: 0x181AA9230
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1AA86E0 Offset: 0x1AA6CE0 VA: 0x181AA86E0
	private void InsureStorage() { }

	// RVA: 0x1AA9350 Offset: 0x1AA7950 VA: 0x181AA9350
	internal void SetCapacity(int capacity) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void OnSetDataSet() { }

	// RVA: 0x1AA9830 Offset: 0x1AA7E30 VA: 0x181AA9830 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AA7F50 Offset: 0x1AA6550 VA: 0x181AA7F50
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0x1AA7FA0 Offset: 0x1AA65A0 VA: 0x181AA7FA0
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1AA7E60 Offset: 0x1AA6460 VA: 0x181AA7E60
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0x1AA7EB0 Offset: 0x1AA64B0 VA: 0x181AA7EB0
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1AA82A0 Offset: 0x1AA68A0 VA: 0x181AA82A0
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0x1AA8000 Offset: 0x1AA6600 VA: 0x181AA8000
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AA9610 Offset: 0x1AA7C10 VA: 0x181AA9610
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1AA6C40 Offset: 0x1AA5240 VA: 0x181AA6C40
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1AA92B0 Offset: 0x1AA78B0 VA: 0x181AA92B0
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1AA8310 Offset: 0x1AA6910 VA: 0x181AA8310
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }
}

// Namespace: System.Data
internal abstract class AutoIncrementValue // TypeDefIndex: 8614
{
	// Fields
	[CompilerGenerated]
	private bool <Auto>k__BackingField; // 0x10

	// Properties
	internal bool Auto { get; set; }
	internal abstract object Current { get; set; }
	internal abstract long Seed { get; set; }
	internal abstract long Step { get; set; }
	internal abstract Type DataType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	internal bool get_Auto() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	internal void set_Auto(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void set_Current(object value);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract long get_Seed();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void set_Seed(long value);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract long get_Step();

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void set_Step(long value);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract Type get_DataType();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract void SetCurrent(object value, IFormatProvider formatProvider);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract void SetCurrentAndIncrement(object value);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void MoveAfter();

	// RVA: 0x1AA6A00 Offset: 0x1AA5000 VA: 0x181AA6A00
	internal AutoIncrementValue Clone() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Data
internal sealed class AutoIncrementInt64 : AutoIncrementValue // TypeDefIndex: 8615
{
	// Fields
	private long _current; // 0x18
	private long _seed; // 0x20
	private long _step; // 0x28

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x1AA6820 Offset: 0x1AA4E20 VA: 0x181AA6820 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1AA6890 Offset: 0x1AA4E90 VA: 0x181AA6890 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1AA6850 Offset: 0x1AA4E50 VA: 0x181AA6850 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1AA68E0 Offset: 0x1AA4EE0 VA: 0x181AA68E0 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1AA6970 Offset: 0x1AA4F70 VA: 0x181AA6970 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1AA6660 Offset: 0x1AA4C60 VA: 0x181AA6660 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1AA67A0 Offset: 0x1AA4DA0 VA: 0x181AA67A0 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1AA6670 Offset: 0x1AA4C70 VA: 0x181AA6670 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1AA6590 Offset: 0x1AA4B90 VA: 0x181AA6590
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x1AA6810 Offset: 0x1AA4E10 VA: 0x181AA6810
	public void .ctor() { }
}

// Namespace: System.Data
internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 8616
{
	// Fields
	private BigInteger _current; // 0x18
	private long _seed; // 0x28
	private BigInteger _step; // 0x30

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x1AA6130 Offset: 0x1AA4730 VA: 0x181AA6130 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1AA6230 Offset: 0x1AA4830 VA: 0x181AA6230 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1AA6180 Offset: 0x1AA4780 VA: 0x181AA6180 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1AA62B0 Offset: 0x1AA48B0 VA: 0x181AA62B0 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x1AA61D0 Offset: 0x1AA47D0 VA: 0x181AA61D0 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1AA63B0 Offset: 0x1AA49B0 VA: 0x181AA63B0 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1AA5F10 Offset: 0x1AA4510 VA: 0x181AA5F10 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1AA6090 Offset: 0x1AA4690 VA: 0x181AA6090 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1AA5FA0 Offset: 0x1AA45A0 VA: 0x181AA5FA0 Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1AA5DD0 Offset: 0x1AA43D0 VA: 0x181AA5DD0
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x1AA60C0 Offset: 0x1AA46C0 VA: 0x181AA60C0
	public void .ctor() { }
}

// Namespace: System.Data
[Serializable]
public class DataException : SystemException // TypeDefIndex: 8617
{
	// Methods

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AADA60 Offset: 0x1AAC060 VA: 0x181AADA60
	public void .ctor() { }

	// RVA: 0x1AADA40 Offset: 0x1AAC040 VA: 0x181AADA40
	public void .ctor(string s) { }

	// RVA: 0x13CADC0 Offset: 0x13C93C0 VA: 0x1813CADC0
	public void .ctor(string s, Exception innerException) { }
}

// Namespace: System.Data
[Serializable]
public class ConstraintException : DataException // TypeDefIndex: 8618
{
	// Methods

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AA6B30 Offset: 0x1AA5130 VA: 0x181AA6B30
	public void .ctor() { }

	// RVA: 0x1AA6B80 Offset: 0x1AA5180 VA: 0x181AA6B80
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class DeletedRowInaccessibleException : DataException // TypeDefIndex: 8619
{
	// Methods

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AB9E60 Offset: 0x1AB8460 VA: 0x181AB9E60
	public void .ctor() { }

	// RVA: 0x1AB9EB0 Offset: 0x1AB84B0 VA: 0x181AB9EB0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class DuplicateNameException : DataException // TypeDefIndex: 8620
{
	// Methods

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AB9EF0 Offset: 0x1AB84F0 VA: 0x181AB9EF0
	public void .ctor() { }

	// RVA: 0x1AB9ED0 Offset: 0x1AB84D0 VA: 0x181AB9ED0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class InRowChangingEventException : DataException // TypeDefIndex: 8621
{
	// Methods

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AC8D50 Offset: 0x1AC7350 VA: 0x181AC8D50
	public void .ctor() { }

	// RVA: 0x1AC8DA0 Offset: 0x1AC73A0 VA: 0x181AC8DA0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class InvalidConstraintException : DataException // TypeDefIndex: 8622
{
	// Methods

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AC8DE0 Offset: 0x1AC73E0 VA: 0x181AC8DE0
	public void .ctor() { }

	// RVA: 0x1AC8DC0 Offset: 0x1AC73C0 VA: 0x181AC8DC0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class NoNullAllowedException : DataException // TypeDefIndex: 8623
{
	// Methods

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AC9220 Offset: 0x1AC7820 VA: 0x181AC9220
	public void .ctor() { }

	// RVA: 0x1AC9200 Offset: 0x1AC7800 VA: 0x181AC9200
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class ReadOnlyException : DataException // TypeDefIndex: 8624
{
	// Methods

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AC92F0 Offset: 0x1AC78F0 VA: 0x181AC92F0
	public void .ctor() { }

	// RVA: 0x1AC9340 Offset: 0x1AC7940 VA: 0x181AC9340
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class RowNotInTableException : DataException // TypeDefIndex: 8625
{
	// Methods

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AC93A0 Offset: 0x1AC79A0 VA: 0x181AC93A0
	public void .ctor() { }

	// RVA: 0x1AC93F0 Offset: 0x1AC79F0 VA: 0x181AC93F0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class VersionNotFoundException : DataException // TypeDefIndex: 8626
{
	// Methods

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AC9670 Offset: 0x1AC7C70 VA: 0x181AC9670
	public void .ctor() { }

	// RVA: 0x1AC96C0 Offset: 0x1AC7CC0 VA: 0x181AC96C0
	public void .ctor(string s) { }
}

// Namespace: System.Data
internal static class ExceptionBuilder // TypeDefIndex: 8627
{
	// Methods

	// RVA: 0x1AC3A00 Offset: 0x1AC2000 VA: 0x181AC3A00
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x1AC37C0 Offset: 0x1AC1DC0 VA: 0x181AC37C0
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x1AC3880 Offset: 0x1AC1E80 VA: 0x181AC3880
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0x1AC3940 Offset: 0x1AC1F40 VA: 0x181AC3940
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x1AC41D0 Offset: 0x1AC27D0 VA: 0x181AC41D0
	internal static Exception _Argument(string error) { }

	// RVA: 0x1AC4160 Offset: 0x1AC2760 VA: 0x181AC4160
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0x1AC4080 Offset: 0x1AC2680 VA: 0x181AC4080
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0x1AC40F0 Offset: 0x1AC26F0 VA: 0x181AC40F0
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0x1AC43F0 Offset: 0x1AC29F0 VA: 0x181AC43F0
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0x1AC4520 Offset: 0x1AC2B20 VA: 0x181AC4520
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0x1AC44C0 Offset: 0x1AC2AC0 VA: 0x181AC44C0
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: -1 Offset: -1
	private static Exception _InvalidEnumArgumentException<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F9240 Offset: 0x6F7840 VA: 0x1806F9240
	|-ExceptionBuilder._InvalidEnumArgumentException<Int32Enum>
	|
	|-RVA: 0x6F90E0 Offset: 0x6F76E0 VA: 0x1806F90E0
	|-ExceptionBuilder._InvalidEnumArgumentException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1AC3670 Offset: 0x1AC1C70 VA: 0x181AC3670
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0x1ABFE70 Offset: 0x1ABE470 VA: 0x181ABFE70
	private static Exception _Data(string error) { }

	// RVA: 0x1AC4230 Offset: 0x1AC2830 VA: 0x181AC4230
	private static Exception _Constraint(string error) { }

	// RVA: 0x1AC4450 Offset: 0x1AC2A50 VA: 0x181AC4450
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0x1AC42A0 Offset: 0x1AC28A0 VA: 0x181AC42A0
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0x1AC4310 Offset: 0x1AC2910 VA: 0x181AC4310
	private static Exception _DuplicateName(string error) { }

	// RVA: 0x1AC4380 Offset: 0x1AC2980 VA: 0x181AC4380
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0x1AC4580 Offset: 0x1AC2B80 VA: 0x181AC4580
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0x1AC45F0 Offset: 0x1AC2BF0 VA: 0x181AC45F0
	private static Exception _ReadOnly(string error) { }

	// RVA: 0x1AC4660 Offset: 0x1AC2C60 VA: 0x181AC4660
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0x1AC46D0 Offset: 0x1AC2CD0 VA: 0x181AC46D0
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0x1ABA1D0 Offset: 0x1AB87D0 VA: 0x181ABA1D0
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0x1ABA2B0 Offset: 0x1AB88B0 VA: 0x181ABA2B0
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x1ABA690 Offset: 0x1AB8C90 VA: 0x181ABA690
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0x1AC3A90 Offset: 0x1AC2090 VA: 0x181AC3A90
	public static Exception TypeNotAllowed(Type type) { }

	// RVA: 0x1ABBE90 Offset: 0x1ABA490 VA: 0x181ABBE90
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0x1AC0430 Offset: 0x1ABEA30 VA: 0x181AC0430
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0x1ABEFB0 Offset: 0x1ABD5B0 VA: 0x181ABEFB0
	public static Exception InvalidOffsetLength() { }

	// RVA: 0x1ABC230 Offset: 0x1ABA830 VA: 0x181ABC230
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0x1ABC1B0 Offset: 0x1ABA7B0 VA: 0x181ABC1B0
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0x1ABC2D0 Offset: 0x1ABA8D0 VA: 0x181ABC2D0
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0x1ABC3E0 Offset: 0x1ABA9E0 VA: 0x181ABC3E0
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0x1ABACA0 Offset: 0x1AB92A0 VA: 0x181ABACA0
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0x1ABAD70 Offset: 0x1AB9370 VA: 0x181ABAD70
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0x1ABAE40 Offset: 0x1AB9440 VA: 0x181ABAE40
	public static Exception CannotAddColumn3() { }

	// RVA: 0x1ABAEC0 Offset: 0x1AB94C0 VA: 0x181ABAEC0
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0x1ABB130 Offset: 0x1AB9730 VA: 0x181ABB130
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0x1ABAF90 Offset: 0x1AB9590 VA: 0x181ABAF90
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0x1ABB060 Offset: 0x1AB9660 VA: 0x181ABB060
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0x1ABB5B0 Offset: 0x1AB9BB0 VA: 0x181ABB5B0
	public static Exception CannotRemoveColumn() { }

	// RVA: 0x1ABB770 Offset: 0x1AB9D70 VA: 0x181ABB770
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0x1ABB4E0 Offset: 0x1AB9AE0 VA: 0x181ABB4E0
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0x1ABB630 Offset: 0x1AB9C30 VA: 0x181ABB630
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0x1ABB6D0 Offset: 0x1AB9CD0 VA: 0x181ABB6D0
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0x1ABA050 Offset: 0x1AB8650 VA: 0x181ABA050
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0x1AC0730 Offset: 0x1ABED30 VA: 0x181AC0730
	public static Exception NoConstraintName() { }

	// RVA: 0x1ABCA60 Offset: 0x1ABB060 VA: 0x181ABCA60
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0x1ABFB30 Offset: 0x1ABE130 VA: 0x181ABFB30
	public static string KeysToString(object[] keys) { }

	// RVA: 0x1AC3DB0 Offset: 0x1AC23B0 VA: 0x181AC3DB0
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0x1ABC9F0 Offset: 0x1ABAFF0 VA: 0x181ABC9F0
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0x1ABC7E0 Offset: 0x1ABADE0 VA: 0x181ABC7E0
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0x1ABD600 Offset: 0x1ABBC00 VA: 0x181ABD600
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0x1ABD460 Offset: 0x1ABBA60 VA: 0x181ABD460
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0x1AC0500 Offset: 0x1ABEB00 VA: 0x181AC0500
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0x1AC3F80 Offset: 0x1AC2580 VA: 0x181AC3F80
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0x1ABC760 Offset: 0x1ABAD60 VA: 0x181ABC760
	public static Exception ConstraintForeignTable() { }

	// RVA: 0x1ABC8F0 Offset: 0x1ABAEF0 VA: 0x181ABC8F0
	public static Exception ConstraintParentValues() { }

	// RVA: 0x1ABC670 Offset: 0x1ABAC70 VA: 0x181ABC670
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0x1ABC970 Offset: 0x1ABAF70 VA: 0x181ABC970
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0x1ABE000 Offset: 0x1ABC600 VA: 0x181ABE000
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0x1ABE0D0 Offset: 0x1ABC6D0 VA: 0x181ABE0D0
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0x1ABE1A0 Offset: 0x1ABC7A0 VA: 0x181ABE1A0
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0x1ABE250 Offset: 0x1ABC850 VA: 0x181ABE250
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0x1AC1FB0 Offset: 0x1AC05B0 VA: 0x181AC1FB0
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0x1ABFDE0 Offset: 0x1ABE3E0 VA: 0x181ABFDE0
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0x1AC0AB0 Offset: 0x1ABF0B0 VA: 0x181AC0AB0
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0x1ABBC50 Offset: 0x1ABA250 VA: 0x181ABBC50
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0x1ABA4C0 Offset: 0x1AB8AC0 VA: 0x181ABA4C0
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0x1ABA440 Offset: 0x1AB8A40 VA: 0x181ABA440
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0x1ABA610 Offset: 0x1AB8C10 VA: 0x181ABA610
	public static Exception AutoIncrementSeed() { }

	// RVA: 0x1ABBD20 Offset: 0x1ABA320 VA: 0x181ABBD20
	public static Exception CantChangeDataType() { }

	// RVA: 0x1AC0BD0 Offset: 0x1ABF1D0 VA: 0x181AC0BD0
	public static Exception NullDataType() { }

	// RVA: 0x1ABC130 Offset: 0x1ABA730 VA: 0x181ABC130
	public static Exception ColumnNameRequired() { }

	// RVA: 0x1ABCF40 Offset: 0x1ABB540 VA: 0x181ABCF40
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0x1ABD0C0 Offset: 0x1ABB6C0 VA: 0x181ABD0C0
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x1ABCFC0 Offset: 0x1ABB5C0 VA: 0x181ABCFC0
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x1ABDE20 Offset: 0x1ABC420 VA: 0x181ABDE20
	public static Exception ExpressionAndUnique() { }

	// RVA: 0x1ABDDA0 Offset: 0x1ABC3A0 VA: 0x181ABDDA0
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0x1ABDCE0 Offset: 0x1ABC2E0 VA: 0x181ABDCE0
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0x1ABDF20 Offset: 0x1ABC520 VA: 0x181ABDF20
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0x1ABDEA0 Offset: 0x1ABC4A0 VA: 0x181ABDEA0
	public static Exception ExpressionCircular() { }

	// RVA: 0x1AC09E0 Offset: 0x1ABEFE0 VA: 0x181AC09E0
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0x1AC0C50 Offset: 0x1ABF250 VA: 0x181AC0C50
	public static Exception NullKeyValues(string column) { }

	// RVA: 0x1AC0DB0 Offset: 0x1ABF3B0 VA: 0x181AC0DB0
	public static Exception NullValues(string column) { }

	// RVA: 0x1AC1290 Offset: 0x1ABF890 VA: 0x181AC1290
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0x1AC1320 Offset: 0x1ABF920 VA: 0x181AC1320
	public static Exception ReadOnly(string column) { }

	// RVA: 0x1AC3D30 Offset: 0x1AC2330 VA: 0x181AC3D30
	public static Exception UniqueAndExpression() { }

	// RVA: 0x1AC2AD0 Offset: 0x1AC10D0 VA: 0x181AC2AD0
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0x1ABBB70 Offset: 0x1ABA170 VA: 0x181ABBB70
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0x1ABFC30 Offset: 0x1ABE230 VA: 0x181ABFC30
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0x1ABB950 Offset: 0x1AB9F50 VA: 0x181ABB950
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0x1ABB870 Offset: 0x1AB9E70 VA: 0x181ABB870
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0x1ABBA30 Offset: 0x1ABA030 VA: 0x181ABBA30
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0x1ABBAD0 Offset: 0x1ABA0D0 VA: 0x181ABBAD0
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0x1ABB2A0 Offset: 0x1AB98A0 VA: 0x181ABB2A0
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0x1ABE5C0 Offset: 0x1ABCBC0 VA: 0x181ABE5C0
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0x1ABA540 Offset: 0x1AB8B40 VA: 0x181ABA540
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0x1ABE770 Offset: 0x1ABCD70 VA: 0x181ABE770
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0x1ABE6A0 Offset: 0x1ABCCA0 VA: 0x181ABE6A0
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0x1AC3B90 Offset: 0x1AC2190 VA: 0x181AC3B90
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0x1ABEC30 Offset: 0x1ABD230 VA: 0x181ABEC30
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0x1ABB7F0 Offset: 0x1AB9DF0 VA: 0x181ABB7F0
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0x1ABED30 Offset: 0x1ABD330 VA: 0x181ABED30
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0x1ABBDA0 Offset: 0x1ABA3A0 VA: 0x181ABBDA0
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0x1ABC580 Offset: 0x1ABAB80 VA: 0x181ABC580
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0x1AC2C20 Offset: 0x1AC1220 VA: 0x181AC2C20
	public static Exception SetFailed(string name) { }

	// RVA: 0x1ABAB80 Offset: 0x1AB9180 VA: 0x181ABAB80
	public static Exception CanNotUse() { }

	// RVA: 0x1AC2CF0 Offset: 0x1AC12F0 VA: 0x181AC2CF0
	public static Exception SetIListObject() { }

	// RVA: 0x1AB9FC0 Offset: 0x1AB85C0 VA: 0x181AB9FC0
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0x1AC0B40 Offset: 0x1ABF140 VA: 0x181AC0B40
	public static Exception NotOpen() { }

	// RVA: 0x1ABCC10 Offset: 0x1ABB210 VA: 0x181ABCC10
	public static Exception CreateChildView() { }

	// RVA: 0x1ABA870 Offset: 0x1AB8E70 VA: 0x181ABA870
	public static Exception CanNotDelete() { }

	// RVA: 0x1ABE410 Offset: 0x1ABCA10 VA: 0x181ABE410
	public static Exception GetElementIndex(int index) { }

	// RVA: 0x1AB9F40 Offset: 0x1AB8540 VA: 0x181AB9F40
	public static Exception AddExternalObject() { }

	// RVA: 0x1ABA7F0 Offset: 0x1AB8DF0 VA: 0x181ABA7F0
	public static Exception CanNotClear() { }

	// RVA: 0x1ABEA20 Offset: 0x1ABD020 VA: 0x181ABEA20
	public static Exception InsertExternalObject() { }

	// RVA: 0x1AC1F30 Offset: 0x1AC0530 VA: 0x181AC1F30
	public static Exception RemoveExternalObject() { }

	// RVA: 0x1ABF990 Offset: 0x1ABDF90 VA: 0x181ABF990
	public static Exception KeyTableMismatch() { }

	// RVA: 0x1ABF900 Offset: 0x1ABDF00 VA: 0x181ABF900
	public static Exception KeyNoColumns() { }

	// RVA: 0x1ABFA20 Offset: 0x1ABE020 VA: 0x181ABFA20
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0x1ABF730 Offset: 0x1ABDD30 VA: 0x181ABF730
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0x1AC1790 Offset: 0x1ABFD90 VA: 0x181AC1790
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0x1ABC5E0 Offset: 0x1ABABE0 VA: 0x181ABC5E0
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0x1ABF800 Offset: 0x1ABDE00 VA: 0x181ABF800
	public static Exception KeyLengthMismatch() { }

	// RVA: 0x1ABF880 Offset: 0x1ABDE80 VA: 0x181ABF880
	public static Exception KeyLengthZero() { }

	// RVA: 0x1ABE300 Offset: 0x1ABC900 VA: 0x181ABE300
	public static Exception ForeignRelation() { }

	// RVA: 0x1ABF6A0 Offset: 0x1ABDCA0 VA: 0x181ABF6A0
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0x1AC19A0 Offset: 0x1ABFFA0 VA: 0x181AC19A0
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0x1ABE520 Offset: 0x1ABCB20 VA: 0x181ABE520
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x1AC2D70 Offset: 0x1AC1370 VA: 0x181AC2D70
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x1AC1920 Offset: 0x1ABFF20 VA: 0x181AC1920
	public static Exception RelationForeignRow() { }

	// RVA: 0x1AC1A40 Offset: 0x1AC0040 VA: 0x181AC1A40
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0x1AC30A0 Offset: 0x1AC16A0 VA: 0x181AC30A0
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0x1ABFD10 Offset: 0x1ABE310 VA: 0x181ABFD10
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0x1AC18A0 Offset: 0x1ABFEA0 VA: 0x181AC18A0
	public static Exception RelationDoesNotExist() { }

	// RVA: 0x1AC0E80 Offset: 0x1ABF480 VA: 0x181AC0E80
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0x1ABE840 Offset: 0x1ABCE40 VA: 0x181ABE840
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0x1ABF030 Offset: 0x1ABD630 VA: 0x181ABF030
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0x1AC2600 Offset: 0x1AC0C00 VA: 0x181AC2600
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0x1AC2680 Offset: 0x1AC0C80 VA: 0x181AC2680
	public static Exception RowNotInTheTable() { }

	// RVA: 0x1ABD9E0 Offset: 0x1ABBFE0 VA: 0x181ABD9E0
	public static Exception EditInRowChanging() { }

	// RVA: 0x1ABDB40 Offset: 0x1ABC140 VA: 0x181ABDB40
	public static Exception EndEditInRowChanging() { }

	// RVA: 0x1ABA760 Offset: 0x1AB8D60 VA: 0x181ABA760
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0x1ABAC10 Offset: 0x1AB9210 VA: 0x181ABAC10
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0x1ABD1E0 Offset: 0x1ABB7E0 VA: 0x181ABD1E0
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0x1AC4000 Offset: 0x1AC2600 VA: 0x181AC4000
	public static Exception ValueArrayLength() { }

	// RVA: 0x1AC07B0 Offset: 0x1ABEDB0 VA: 0x181AC07B0
	public static Exception NoCurrentData() { }

	// RVA: 0x1AC0840 Offset: 0x1ABEE40 VA: 0x181AC0840
	public static Exception NoOriginalData() { }

	// RVA: 0x1AC08D0 Offset: 0x1ABEED0 VA: 0x181AC08D0
	public static Exception NoProposedData() { }

	// RVA: 0x1AC2820 Offset: 0x1AC0E20 VA: 0x181AC2820
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0x1ABD270 Offset: 0x1ABB870 VA: 0x181ABD270
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0x1AC21C0 Offset: 0x1AC07C0 VA: 0x181AC21C0
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0x1AC23E0 Offset: 0x1AC09E0 VA: 0x181AC23E0
	public static Exception RowEmpty() { }

	// RVA: 0x1ABF2D0 Offset: 0x1ABD8D0 VA: 0x181ABF2D0
	public static Exception InvalidRowVersion() { }

	// RVA: 0x1AC2710 Offset: 0x1AC0D10 VA: 0x181AC2710
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0x1AC2530 Offset: 0x1AC0B30 VA: 0x181AC2530
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0x1AC2460 Offset: 0x1AC0A60 VA: 0x181AC2460
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0x1AC2350 Offset: 0x1AC0950 VA: 0x181AC2350
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0x1AC0320 Offset: 0x1ABE920 VA: 0x181AC0320
	public static Exception MultipleParents() { }

	// RVA: 0x1ABF290 Offset: 0x1ABD890 VA: 0x181ABF290
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0x1ABF210 Offset: 0x1ABD810 VA: 0x181ABF210
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0x1AC2A50 Offset: 0x1AC1050 VA: 0x181AC2A50
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0x1AC2980 Offset: 0x1AC0F80 VA: 0x181AC2980
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0x1ABCC90 Offset: 0x1ABB290 VA: 0x181ABCC90
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0x1ABFEE0 Offset: 0x1ABE4E0 VA: 0x181ABFEE0
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0x1AC35F0 Offset: 0x1AC1BF0 VA: 0x181AC35F0
	public static Exception TablesInDifferentSets() { }

	// RVA: 0x1AC1470 Offset: 0x1ABFA70 VA: 0x181AC1470
	public static Exception RelationAlreadyExists() { }

	// RVA: 0x1AC2250 Offset: 0x1AC0850 VA: 0x181AC2250
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0x1AC22D0 Offset: 0x1AC08D0 VA: 0x181AC22D0
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0x1AC13F0 Offset: 0x1ABF9F0 VA: 0x181AC13F0
	public static Exception RecordStateRange() { }

	// RVA: 0x1ABE910 Offset: 0x1ABCF10 VA: 0x181ABE910
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0x1AC20B0 Offset: 0x1AC06B0 VA: 0x181AC20B0
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0x1AC14F0 Offset: 0x1ABFAF0 VA: 0x181AC14F0
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0x1AC1570 Offset: 0x1ABFB70 VA: 0x181AC1570
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0x1AC1AC0 Offset: 0x1AC00C0 VA: 0x181AC1AC0
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0x1AC1B90 Offset: 0x1AC0190 VA: 0x181AC1B90
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0x1ABD7A0 Offset: 0x1ABBDA0 VA: 0x181ABD7A0
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0x1AC1E30 Offset: 0x1AC0430 VA: 0x181AC1E30
	public static Exception RelationTableNull() { }

	// RVA: 0x1AC1820 Offset: 0x1ABFE20 VA: 0x181AC1820
	public static Exception RelationDataSetNull() { }

	// RVA: 0x1AC1EB0 Offset: 0x1AC04B0 VA: 0x181AC1EB0
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0x1AC0F10 Offset: 0x1ABF510 VA: 0x181AC0F10
	public static Exception ParentTableMismatch() { }

	// RVA: 0x1ABBFE0 Offset: 0x1ABA5E0 VA: 0x181ABBFE0
	public static Exception ChildTableMismatch() { }

	// RVA: 0x1ABDBD0 Offset: 0x1ABC1D0 VA: 0x181ABDBD0
	public static Exception EnforceConstraint() { }

	// RVA: 0x1ABBF60 Offset: 0x1ABA560 VA: 0x181ABBF60
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0x1ABB200 Offset: 0x1AB9800 VA: 0x181ABB200
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0x1ABB210 Offset: 0x1AB9810 VA: 0x181ABB210
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0x1ABF1D0 Offset: 0x1ABD7D0 VA: 0x181ABF1D0
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0x1AC3170 Offset: 0x1AC1770 VA: 0x181AC3170
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0x1AC3020 Offset: 0x1AC1620 VA: 0x181AC3020
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0x1AC0960 Offset: 0x1ABEF60 VA: 0x181AC0960
	public static Exception NoTableName() { }

	// RVA: 0x1AC03B0 Offset: 0x1ABE9B0 VA: 0x181AC03B0
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0x1ABF430 Offset: 0x1ABDA30 VA: 0x181ABF430
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0x1ABD910 Offset: 0x1ABBF10 VA: 0x181ABD910
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0x1ABD870 Offset: 0x1ABBE70 VA: 0x181ABD870
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0x1AC28B0 Offset: 0x1AC0EB0 VA: 0x181AC28B0
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0x1ABCDE0 Offset: 0x1ABB3E0 VA: 0x181ABCDE0
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0x1AC2F20 Offset: 0x1AC1520 VA: 0x181AC2F20
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0x1AC2FA0 Offset: 0x1AC15A0 VA: 0x181AC2FA0
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0x1AC34E0 Offset: 0x1AC1AE0 VA: 0x181AC34E0
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0x1AC3410 Offset: 0x1AC1A10 VA: 0x181AC3410
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0x1AC32C0 Offset: 0x1AC18C0 VA: 0x181AC32C0
	public static Exception TableInRelation() { }

	// RVA: 0x1AC31F0 Offset: 0x1AC17F0 VA: 0x181AC31F0
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0x1ABAA00 Offset: 0x1AB9000 VA: 0x181ABAA00
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0x1ABA980 Offset: 0x1AB8F80 VA: 0x181ABA980
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0x1ABAB00 Offset: 0x1AB9100 VA: 0x181ABAB00
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0x1ABAA80 Offset: 0x1AB9080 VA: 0x181ABAA80
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0x1AC3340 Offset: 0x1AC1940 VA: 0x181AC3340
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0x1ABA0D0 Offset: 0x1AB86D0 VA: 0x181ABA0D0
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0x1ABF500 Offset: 0x1ABDB00 VA: 0x181ABF500
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0x1AC11A0 Offset: 0x1ABF7A0 VA: 0x181AC11A0
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0x1AC0D20 Offset: 0x1ABF320 VA: 0x181AC0D20
	public static Exception NullRange() { }

	// RVA: 0x1AC05E0 Offset: 0x1ABEBE0 VA: 0x181AC05E0
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0x1AC1060 Offset: 0x1ABF660 VA: 0x181AC1060
	public static Exception ProblematicChars(char charValue) { }

	// RVA: 0x1AC2EA0 Offset: 0x1AC14A0 VA: 0x181AC2EA0
	public static Exception StorageSetFailed() { }

	// RVA: 0x1AC2E10 Offset: 0x1AC1410 VA: 0x181AC2E10
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0x1AC00E0 Offset: 0x1ABE6E0 VA: 0x181AC00E0
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0x1AC0040 Offset: 0x1ABE640 VA: 0x181AC0040
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0x1ABEB90 Offset: 0x1ABD190 VA: 0x181ABEB90
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0x1ABA390 Offset: 0x1AB8990 VA: 0x181ABA390
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0x1ABDA70 Offset: 0x1ABC070 VA: 0x181ABDA70
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0x1AC1C90 Offset: 0x1AC0290 VA: 0x181AC1C90
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0x1AC16C0 Offset: 0x1ABFCC0 VA: 0x181AC16C0
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0x1AC1D60 Offset: 0x1AC0360 VA: 0x181AC1D60
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0x1AC15F0 Offset: 0x1ABFBF0 VA: 0x181AC15F0
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0x1AC3C60 Offset: 0x1AC2260 VA: 0x181AC3C60
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0x1ABCEB0 Offset: 0x1ABB4B0 VA: 0x181ABCEB0
	public static Exception DatatypeNotDefined() { }

	// RVA: 0x1ABFFB0 Offset: 0x1ABE5B0 VA: 0x181ABFFB0
	public static Exception MismatchKeyLength() { }

	// RVA: 0x1ABEE10 Offset: 0x1ABD410 VA: 0x181ABEE10
	public static Exception InvalidField(string name) { }

	// RVA: 0x1ABF360 Offset: 0x1ABD960 VA: 0x181ABF360
	public static Exception InvalidSelector(string name) { }

	// RVA: 0x1ABC060 Offset: 0x1ABA660 VA: 0x181ABC060
	public static Exception CircularComplexType(string name) { }

	// RVA: 0x1ABB410 Offset: 0x1AB9A10 VA: 0x181ABB410
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0x1ABEEE0 Offset: 0x1ABD4E0 VA: 0x181ABEEE0
	public static Exception InvalidKey(string name) { }

	// RVA: 0x1ABD390 Offset: 0x1ABB990 VA: 0x181ABD390
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0x1ABD300 Offset: 0x1ABB900 VA: 0x181ABD300
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0x1ABD530 Offset: 0x1ABBB30 VA: 0x181ABD530
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0x1ABC4B0 Offset: 0x1ABAAB0 VA: 0x181ABC4B0
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0x1ABB370 Offset: 0x1AB9970 VA: 0x181ABB370
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0x1AC0190 Offset: 0x1ABE790 VA: 0x181AC0190
	public static Exception MissingRefer(string name) { }

	// RVA: 0x1ABF100 Offset: 0x1ABD700 VA: 0x181ABF100
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0x1ABA900 Offset: 0x1AB8F00 VA: 0x181ABA900
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0x1ABF610 Offset: 0x1ABDC10 VA: 0x181ABF610
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0x1AC3730 Offset: 0x1AC1D30 VA: 0x181AC3730
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0x1AC0660 Offset: 0x1ABEC60 VA: 0x181AC0660
	public static Exception NestedCircular(string name) { }

	// RVA: 0x1AC0250 Offset: 0x1ABE850 VA: 0x181AC0250
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0x1AC0F90 Offset: 0x1ABF590 VA: 0x181AC0F90
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0x1ABCD60 Offset: 0x1ABB360 VA: 0x181ABCD60
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0x1AC36E0 Offset: 0x1AC1CE0 VA: 0x181AC36E0
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0x1ABD6D0 Offset: 0x1ABBCD0 VA: 0x181ABD6D0
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0x1ABE380 Offset: 0x1ABC980 VA: 0x181ABE380
	public static Exception FoundEntity() { }

	// RVA: 0x1ABFE70 Offset: 0x1ABE470 VA: 0x181ABFE70
	public static Exception MergeFailed(string name) { }

	// RVA: 0x1ABCB30 Offset: 0x1ABB130 VA: 0x181ABCB30
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0x1ABED70 Offset: 0x1ABD370 VA: 0x181ABED70
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0x1ABEAA0 Offset: 0x1ABD0A0 VA: 0x181ABEAA0
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0x1ABDC60 Offset: 0x1ABC260 VA: 0x181ABDC60
	public static Exception EnumeratorModified() { }
}

// Namespace: System.Data
[DefaultProperty("DataSetName")]
[XmlSchemaProvider("GetDataSetSchema")]
[XmlRoot("DataSet")]
[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[Serializable]
public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable // TypeDefIndex: 8628
{
	// Fields
	private DataViewManager _defaultViewManager; // 0x20
	private readonly DataTableCollection _tableCollection; // 0x28
	private readonly DataRelationCollection _relationCollection; // 0x30
	internal PropertyCollection _extendedProperties; // 0x38
	private string _dataSetName; // 0x40
	private string _datasetPrefix; // 0x48
	internal string _namespaceURI; // 0x50
	private bool _enforceConstraints; // 0x58
	private bool _caseSensitive; // 0x59
	private CultureInfo _culture; // 0x60
	private bool _cultureUserSet; // 0x68
	internal bool _fInReadXml; // 0x69
	internal bool _fInLoadDiffgram; // 0x6A
	internal bool _fTopLevelTable; // 0x6B
	internal bool _fInitInProgress; // 0x6C
	internal bool _fEnableCascading; // 0x6D
	internal bool _fIsSchemaLoading; // 0x6E
	internal string _mainTableName; // 0x70
	private SerializationFormat _remotingFormat; // 0x78
	private object _defaultViewManagerLock; // 0x80
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x88
	private static XmlSchemaComplexType s_schemaTypeForWSDL; // 0x8
	internal bool _useDataSetSchemaOnly; // 0x8C
	internal bool _udtIsWrapped; // 0x8D
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x90
	[CompilerGenerated]
	private MergeFailedEventHandler MergeFailed; // 0x98
	[CompilerGenerated]
	private DataRowCreatedEventHandler DataRowCreated; // 0xA0
	[CompilerGenerated]
	private DataSetClearEventhandler ClearFunctionCalled; // 0xA8

	// Properties
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual SchemaSerializationMode SchemaSerializationMode { get; }
	[DefaultValue(False)]
	public bool CaseSensitive { get; set; }
	[DefaultValue(True)]
	public bool EnforceConstraints { get; set; }
	[DefaultValue("")]
	public string DataSetName { get; set; }
	[DefaultValue("")]
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	public CultureInfo Locale { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override ISite Site { get; }
	[DesignerSerializationVisibility(2)]
	public DataRelationCollection Relations { get; }
	[DesignerSerializationVisibility(2)]
	public DataTableCollection Tables { get; }
	internal string MainTableName { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1AB8C20 Offset: 0x1AB7220 VA: 0x181AB8C20
	public void .ctor() { }

	// RVA: 0x1AB90F0 Offset: 0x1AB76F0 VA: 0x181AB90F0
	public void .ctor(string dataSetName) { }

	// RVA: 0x1869360 Offset: 0x1867960 VA: 0x181869360
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x1AB9DA0 Offset: 0x1AB83A0 VA: 0x181AB9DA0
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 14
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0x1AB90C0 Offset: 0x1AB76C0 VA: 0x181AB90C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AB8EB0 Offset: 0x1AB74B0 VA: 0x181AB8EB0
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0x1AB0A60 Offset: 0x1AAF060 VA: 0x181AB0A60 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 16
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0x1AB6370 Offset: 0x1AB4970 VA: 0x181AB6370
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x1AAF680 Offset: 0x1AADC80 VA: 0x181AAF680
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x1AAF1A0 Offset: 0x1AAD7A0 VA: 0x181AAF1A0
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x1AAED40 Offset: 0x1AAD340 VA: 0x181AAED40
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x1AB61D0 Offset: 0x1AB47D0 VA: 0x181AB61D0
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AAEEF0 Offset: 0x1AAD4F0 VA: 0x181AAEEF0
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AB6B20 Offset: 0x1AB5120 VA: 0x181AB6B20
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AAF700 Offset: 0x1AADD00 VA: 0x181AAF700
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AB05D0 Offset: 0x1AAEBD0 VA: 0x181AB05D0
	internal void FailedEnableConstraints() { }

	// RVA: 0x140E320 Offset: 0x140C920 VA: 0x18140E320
	public bool get_CaseSensitive() { }

	// RVA: 0x1AB9190 Offset: 0x1AB7790 VA: 0x181AB9190
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	public bool get_EnforceConstraints() { }

	// RVA: 0x1AB95A0 Offset: 0x1AB7BA0 VA: 0x181AB95A0
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0x3B9A60 Offset: 0x3B8060 VA: 0x1803B9A60
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0x1AAFE00 Offset: 0x1AAE400 VA: 0x181AAFE00
	internal void EnableConstraints() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_DataSetName() { }

	// RVA: 0x1AB9430 Offset: 0x1AB7A30 VA: 0x181AB9430
	public void set_DataSetName(string value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_Namespace() { }

	// RVA: 0x1AB98A0 Offset: 0x1AB7EA0 VA: 0x181AB98A0
	public void set_Namespace(string value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public string get_Prefix() { }

	// RVA: 0x1AB9C80 Offset: 0x1AB8280 VA: 0x181AB9C80
	public void set_Prefix(string value) { }

	// RVA: 0x1AB9120 Offset: 0x1AB7720 VA: 0x181AB9120
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public CultureInfo get_Locale() { }

	// RVA: 0x1AB9710 Offset: 0x1AB7D10 VA: 0x181AB9710
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x1AB70B0 Offset: 0x1AB56B0 VA: 0x181AB70B0
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public DataRelationCollection get_Relations() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public DataTableCollection get_Tables() { }

	// RVA: 0x1AADAB0 Offset: 0x1AAC0B0 VA: 0x181AADAB0
	public void Clear() { }

	// RVA: 0x1AADCB0 Offset: 0x1AAC2B0 VA: 0x181AADCB0 Slot: 17
	public virtual DataSet Clone() { }

	// RVA: 0x1AB0470 Offset: 0x1AAEA70 VA: 0x181AB0470
	internal int EstimatedXmlStringSize() { }

	// RVA: 0x1AB0A90 Offset: 0x1AAF090 VA: 0x181AB0A90
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0x1AB0BC0 Offset: 0x1AAF1C0 VA: 0x181AB0BC0
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0x1AB3040 Offset: 0x1AB1640 VA: 0x181AB3040
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0x1AB3050 Offset: 0x1AB1650 VA: 0x181AB3050
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1A98B10 Offset: 0x1A97110 VA: 0x181A98B10
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x1AB16C0 Offset: 0x1AAFCC0 VA: 0x181AB16C0
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0x1A9A610 Offset: 0x1A98C10 VA: 0x181A9A610
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x1AB1B80 Offset: 0x1AB0180 VA: 0x181AB1B80
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1AB1A10 Offset: 0x1AB0010 VA: 0x181AB1A10
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x1AB8780 Offset: 0x1AB6D80 VA: 0x181AB8780
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x1AB5F10 Offset: 0x1AB4510 VA: 0x181AB5F10
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0x1AB4C80 Offset: 0x1AB3280 VA: 0x181AB4C80
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1AB0D70 Offset: 0x1AAF370 VA: 0x181AB0D70
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0x1AB10B0 Offset: 0x1AAF6B0 VA: 0x181AB10B0
	private bool IsEmpty() { }

	// RVA: 0x1AB1E40 Offset: 0x1AB0440 VA: 0x181AB1E40
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x1AB3DF0 Offset: 0x1AB23F0 VA: 0x181AB3DF0
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0x1AB3E10 Offset: 0x1AB2410 VA: 0x181AB3E10
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x1AB89C0 Offset: 0x1AB6FC0 VA: 0x181AB89C0
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0x1AB12D0 Offset: 0x1AAF8D0 VA: 0x181AB12D0
	public void Merge(DataSet dataSet) { }

	// RVA: 0x1AB1450 Offset: 0x1AAFA50 VA: 0x181AB1450
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1AB1810 Offset: 0x1AAFE10 VA: 0x181AB1810 Slot: 18
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1AB1790 Offset: 0x1AAFD90 VA: 0x181AB1790
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0x1AB1880 Offset: 0x1AAFE80 VA: 0x181AB1880
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1AB1770 Offset: 0x1AAFD70 VA: 0x181AB1770
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0x1AB1750 Offset: 0x1AAFD50 VA: 0x181AB1750
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 19
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0x1AB1850 Offset: 0x1AAFE50 VA: 0x181AB1850
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0x1AB1830 Offset: 0x1AAFE30 VA: 0x181AB1830
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0x1AB1990 Offset: 0x1AAFF90 VA: 0x181AB1990
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1AB7B30 Offset: 0x1AB6130 VA: 0x181AB7B30
	internal DataTable[] TopLevelTables() { }

	// RVA: 0x1AB7B40 Offset: 0x1AB6140 VA: 0x181AB7B40
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0x1AB5F20 Offset: 0x1AB4520 VA: 0x181AB5F20 Slot: 21
	public virtual void Reset() { }

	// RVA: 0x1AB7D70 Offset: 0x1AB6370 VA: 0x181AB7D70
	internal bool ValidateCaseConstraint() { }

	// RVA: 0x1AB8230 Offset: 0x1AB6830 VA: 0x181AB8230
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0x1AB0610 Offset: 0x1AAEC10 VA: 0x181AB0610
	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	// RVA: 0x1AB3AC0 Offset: 0x1AB20C0 VA: 0x181AB3AC0 Slot: 22
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x1AB0790 Offset: 0x1AAED90 VA: 0x181AB0790
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AB77D0 Offset: 0x1AB5DD0 VA: 0x181AB77D0 Slot: 10
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AB7990 Offset: 0x1AB5F90 VA: 0x181AB7990 Slot: 11
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1AB7AE0 Offset: 0x1AB60E0 VA: 0x181AB7AE0 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	internal string get_MainTableName() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	internal void set_MainTableName(string value) { }

	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90
	internal int get_ObjectID() { }
}

// Namespace: System.Data
[DesignTimeVisible(False)]
[DefaultProperty("TableName")]
[DefaultEvent("RowChanging")]
[XmlSchemaProvider("GetDataTableSchema")]
[ToolboxItem(False)]
[Serializable]
public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable // TypeDefIndex: 8631
{
	// Fields
	private DataSet _dataSet; // 0x20
	private DataView _defaultView; // 0x28
	internal long _nextRowID; // 0x30
	internal readonly DataRowCollection _rowCollection; // 0x38
	internal readonly DataColumnCollection _columnCollection; // 0x40
	private readonly ConstraintCollection _constraintCollection; // 0x48
	private int _elementColumnCount; // 0x50
	internal DataRelationCollection _parentRelationsCollection; // 0x58
	internal DataRelationCollection _childRelationsCollection; // 0x60
	internal readonly RecordManager _recordManager; // 0x68
	internal readonly List<Index> _indexes; // 0x70
	private List<Index> _shadowIndexes; // 0x78
	private int _shadowCount; // 0x80
	internal PropertyCollection _extendedProperties; // 0x88
	private string _tableName; // 0x90
	internal string _tableNamespace; // 0x98
	private string _tablePrefix; // 0xA0
	internal DataExpression _displayExpression; // 0xA8
	internal bool _fNestedInDataset; // 0xB0
	private CultureInfo _culture; // 0xB8
	private bool _cultureUserSet; // 0xC0
	private CompareInfo _compareInfo; // 0xC8
	private CompareOptions _compareFlags; // 0xD0
	private IFormatProvider _formatProvider; // 0xD8
	private StringComparer _hashCodeProvider; // 0xE0
	private bool _caseSensitive; // 0xE8
	private bool _caseSensitiveUserSet; // 0xE9
	internal string _encodedTableName; // 0xF0
	internal DataColumn _xmlText; // 0xF8
	internal DataColumn _colUnique; // 0x100
	internal Decimal _minOccurs; // 0x108
	internal Decimal _maxOccurs; // 0x118
	internal bool _repeatableElement; // 0x128
	private object _typeName; // 0x130
	internal UniqueConstraint _primaryKey; // 0x138
	internal IndexField[] _primaryIndex; // 0x140
	private DataColumn[] _delayedSetPrimaryKey; // 0x148
	private Index _loadIndex; // 0x150
	private Index _loadIndexwithOriginalAdded; // 0x158
	private Index _loadIndexwithCurrentDeleted; // 0x160
	private int _suspendIndexEvents; // 0x168
	private bool _inDataLoad; // 0x16C
	private bool _schemaLoading; // 0x16D
	private bool _enforceConstraints; // 0x16E
	internal bool _suspendEnforceConstraints; // 0x16F
	protected internal bool fInitInProgress; // 0x170
	private bool _inLoad; // 0x171
	internal bool _fInLoadDiffgram; // 0x172
	private byte _isTypedDataTable; // 0x173
	private DataRow[] _emptyDataRowArray; // 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
	private DataRelation[] _nestedParentRelations; // 0x188
	internal List<DataColumn> _dependentColumns; // 0x190
	private bool _mergingData; // 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
	private readonly DataRowBuilder _rowBuilder; // 0x1F0
	internal readonly List<DataView> _delayedViews; // 0x1F8
	private readonly List<DataViewListener> _dataViewListeners; // 0x200
	internal Hashtable _rowDiffId; // 0x208
	internal readonly ReaderWriterLockSlim _indexesLock; // 0x210
	internal int _ukColumnPositionForInference; // 0x218
	private SerializationFormat _remotingFormat; // 0x21C
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x220

	// Properties
	public bool CaseSensitive { get; set; }
	internal bool AreIndexEventsSuspended { get; }
	private bool IsTypedDataTable { get; }
	internal bool SelfNested { get; }
	[DebuggerBrowsable(0)]
	internal List<Index> LiveIndexes { get; }
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	internal int UKColumnPositionForInference { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ChildRelations { get; }
	[DesignerSerializationVisibility(2)]
	public DataColumnCollection Columns { get; }
	private CompareInfo CompareInfo { get; }
	[DesignerSerializationVisibility(2)]
	public ConstraintCollection Constraints { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public DataSet DataSet { get; }
	internal string DisplayExpressionInternal { get; }
	internal bool EnforceConstraints { get; set; }
	internal bool SuspendEnforceConstraints { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal IFormatProvider FormatProvider { get; }
	public CultureInfo Locale { get; set; }
	[DefaultValue(50)]
	public int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; }
	internal int ElementColumnCount { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ParentRelations { get; }
	internal bool MergingData { get; set; }
	internal DataRelation[] NestedParentRelations { get; }
	internal bool SchemaLoading { get; }
	internal int NestedParentsCount { get; }
	[TypeConverter(typeof(PrimaryKeyTypeConverter))]
	public DataColumn[] PrimaryKey { get; set; }
	[Browsable(False)]
	public DataRowCollection Rows { get; }
	[DefaultValue("")]
	[RefreshProperties(1)]
	public string TableName { get; set; }
	internal string EncodedTableName { get; }
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal DataColumn XmlText { get; set; }
	internal Decimal MaxOccurs { get; set; }
	internal Decimal MinOccurs { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override ISite Site { get; }
	internal bool NeedColumnChangeEvents { get; }
	internal XmlQualifiedName TypeName { get; set; }
	internal Hashtable RowDiffId { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1AA2FE0 Offset: 0x1AA15E0 VA: 0x181AA2FE0
	public void .ctor() { }

	// RVA: 0x1AA34A0 Offset: 0x1AA1AA0 VA: 0x181AA34A0
	public void .ctor(string tableName) { }

	// RVA: 0x1AA3510 Offset: 0x1AA1B10 VA: 0x181AA3510
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A96810 Offset: 0x1A94E10 VA: 0x181A96810 Slot: 14
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A9F0E0 Offset: 0x1A9D6E0 VA: 0x181A9F0E0
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x1A91A00 Offset: 0x1A90000 VA: 0x181A91A00
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x1A9FB70 Offset: 0x1A9E170 VA: 0x181A9FB70
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x1A92C50 Offset: 0x1A91250 VA: 0x181A92C50
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x1A9E970 Offset: 0x1A9CF70 VA: 0x181A9E970
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x1A90E90 Offset: 0x1A8F490 VA: 0x181A90E90
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x1A9F3C0 Offset: 0x1A9D9C0 VA: 0x181A9F3C0
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1A91D30 Offset: 0x1A90330 VA: 0x181A91D30
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1A9F540 Offset: 0x1A9DB40 VA: 0x181A9F540
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1A91EB0 Offset: 0x1A904B0 VA: 0x181A91EB0
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1A902C0 Offset: 0x1A8E8C0 VA: 0x181A902C0
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0x1A96C10 Offset: 0x1A95210 VA: 0x181A96C10
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x1A8FFD0 Offset: 0x1A8E5D0 VA: 0x181A8FFD0
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x3A3620 Offset: 0x3A1C20 VA: 0x1803A3620
	public bool get_CaseSensitive() { }

	// RVA: 0x1AA4330 Offset: 0x1AA2930 VA: 0x181AA4330
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x1AA36A0 Offset: 0x1AA1CA0 VA: 0x181AA36A0
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0x1A9E520 Offset: 0x1A9CB20 VA: 0x181A9E520
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0x1AA24E0 Offset: 0x1AA0AE0 VA: 0x181AA24E0
	internal void SuspendIndexEvents() { }

	// RVA: 0x1AA39C0 Offset: 0x1AA1FC0 VA: 0x181AA39C0
	private bool get_IsTypedDataTable() { }

	// RVA: 0x1AA08B0 Offset: 0x1A9EEB0 VA: 0x181AA08B0
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0x3A3610 Offset: 0x3A1C10 VA: 0x1803A3610
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0x1AA4030 Offset: 0x1AA2630 VA: 0x181AA4030
	internal bool get_SelfNested() { }

	// RVA: 0x1AA3A60 Offset: 0x1AA2060 VA: 0x181AA3A60
	internal List<Index> get_LiveIndexes() { }

	// RVA: 0x1AA3FA0 Offset: 0x1AA25A0 VA: 0x181AA3FA0
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x1AA5190 Offset: 0x1AA3790 VA: 0x181AA5190
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x1AA4320 Offset: 0x1AA2920 VA: 0x181AA4320
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0x1AA57F0 Offset: 0x1AA3DF0 VA: 0x181AA57F0
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0x1AA36B0 Offset: 0x1AA1CB0 VA: 0x181AA36B0
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public DataColumnCollection get_Columns() { }

	// RVA: 0x1AA3730 Offset: 0x1AA1D30 VA: 0x181AA3730
	private CompareInfo get_CompareInfo() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public ConstraintCollection get_Constraints() { }

	// RVA: 0x1A9DFE0 Offset: 0x1A9C5E0 VA: 0x181A9DFE0
	private void ResetConstraints() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public DataSet get_DataSet() { }

	// RVA: 0x1AA0B50 Offset: 0x1A9F150 VA: 0x181AA0B50
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x1AA37A0 Offset: 0x1AA1DA0 VA: 0x181AA37A0
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0x1AA3860 Offset: 0x1AA1E60 VA: 0x181AA3860
	internal bool get_EnforceConstraints() { }

	// RVA: 0x1AA4440 Offset: 0x1AA2A40 VA: 0x181AA4440
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0x1AA4260 Offset: 0x1AA2860 VA: 0x181AA4260
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0x1AA5210 Offset: 0x1AA3810 VA: 0x181AA5210
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0x1A94080 Offset: 0x1A92680 VA: 0x181A94080
	internal void EnableConstraints() { }

	// RVA: 0x1AA3890 Offset: 0x1AA1E90 VA: 0x181AA3890
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1AA3910 Offset: 0x1AA1F10 VA: 0x181AA3910
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x131C550 Offset: 0x131AB50 VA: 0x18131C550
	public CultureInfo get_Locale() { }

	// RVA: 0x1AA4480 Offset: 0x1AA2A80 VA: 0x181AA4480
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x1AA0CB0 Offset: 0x1A9F2B0 VA: 0x181AA0CB0
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0x1AA21F0 Offset: 0x1AA07F0 VA: 0x181AA21F0
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x1AA3B30 Offset: 0x1AA2130 VA: 0x181AA3B30
	public int get_MinimumCapacity() { }

	// RVA: 0x1AA48B0 Offset: 0x1AA2EB0 VA: 0x181AA48B0
	public void set_MinimumCapacity(int value) { }

	// RVA: 0x1AA3F80 Offset: 0x1AA2580 VA: 0x181AA3F80
	internal int get_RecordCapacity() { }

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	internal int get_ElementColumnCount() { }

	// RVA: 0x1AA43F0 Offset: 0x1AA29F0 VA: 0x181AA43F0
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0x1AA3EA0 Offset: 0x1AA24A0 VA: 0x181AA3EA0
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0x1AA3B10 Offset: 0x1AA2110 VA: 0x181AA3B10
	internal bool get_MergingData() { }

	// RVA: 0x1AA4890 Offset: 0x1AA2E90 VA: 0x181AA4890
	internal void set_MergingData(bool value) { }

	// RVA: 0x37EAE0 Offset: 0x37D0E0 VA: 0x18037EAE0
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0x1791AA0 Offset: 0x17900A0 VA: 0x181791AA0
	internal bool get_SchemaLoading() { }

	// RVA: 0x1A8D010 Offset: 0x1A8B610 VA: 0x181A8D010
	internal void CacheNestedParent() { }

	// RVA: 0x1A95C50 Offset: 0x1A94250 VA: 0x181A95C50
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0x1AA3C10 Offset: 0x1AA2210 VA: 0x181AA3C10
	internal int get_NestedParentsCount() { }

	// RVA: 0x1AA3F20 Offset: 0x1AA2520 VA: 0x181AA3F20
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0x1AA4D00 Offset: 0x1AA3300 VA: 0x181AA4D00
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public DataRowCollection get_Rows() { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public string get_TableName() { }

	// RVA: 0x1AA5220 Offset: 0x1AA3820 VA: 0x181AA5220
	public void set_TableName(string value) { }

	// RVA: 0x1AA37D0 Offset: 0x1AA1DD0 VA: 0x181AA37D0
	internal string get_EncodedTableName() { }

	// RVA: 0x1A96570 Offset: 0x1A94B70 VA: 0x181A96570
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	// RVA: 0x1AA3B50 Offset: 0x1AA2150 VA: 0x181AA3B50
	public string get_Namespace() { }

	// RVA: 0x1AA48E0 Offset: 0x1AA2EE0 VA: 0x181AA48E0
	public void set_Namespace(string value) { }

	// RVA: 0x1A98100 Offset: 0x1A96700 VA: 0x181A98100
	internal bool IsNamespaceInherited() { }

	// RVA: 0x1A8D110 Offset: 0x1A8B710 VA: 0x181A8D110
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0x1A8DBA0 Offset: 0x1A8C1A0 VA: 0x181A8DBA0
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0x1A8D900 Offset: 0x1A8BF00 VA: 0x181A8D900
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0x1A93AE0 Offset: 0x1A920E0 VA: 0x181A93AE0
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public string get_Prefix() { }

	// RVA: 0x1AA4B90 Offset: 0x1AA3190 VA: 0x181AA4B90
	public void set_Prefix(string value) { }

	// RVA: 0x5612C0 Offset: 0x55F8C0 VA: 0x1805612C0
	internal DataColumn get_XmlText() { }

	// RVA: 0x1AA5800 Offset: 0x1AA3E00 VA: 0x181AA5800
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0x1AA3B00 Offset: 0x1AA2100 VA: 0x181AA3B00
	internal Decimal get_MaxOccurs() { }

	// RVA: 0x1AA4880 Offset: 0x1AA2E80 VA: 0x181AA4880
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0x1AA3B20 Offset: 0x1AA2120 VA: 0x181AA3B20
	internal Decimal get_MinOccurs() { }

	// RVA: 0x1AA48A0 Offset: 0x1AA2EA0 VA: 0x181AA48A0
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0x1AA0C30 Offset: 0x1A9F230 VA: 0x181AA0C30
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0x1A95AB0 Offset: 0x1A940B0 VA: 0x181A95AB0
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0x1A95B50 Offset: 0x1A94150 VA: 0x181A95B50
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0x1AA12F0 Offset: 0x1A9F8F0 VA: 0x181AA12F0
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0x1A981D0 Offset: 0x1A967D0 VA: 0x181A981D0
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0x1A906E0 Offset: 0x1A8ECE0 VA: 0x181A906E0 Slot: 15
	protected virtual DataTable CreateInstance() { }

	// RVA: 0x1A8FB80 Offset: 0x1A8E180 VA: 0x181A8FB80 Slot: 16
	public virtual DataTable Clone() { }

	// RVA: 0x1A8F970 Offset: 0x1A8DF70 VA: 0x181A8F970
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0x1A971A0 Offset: 0x1A957A0 VA: 0x181A971A0
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0x1A8E770 Offset: 0x1A8CD70 VA: 0x181A8E770
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0x1A8EBB0 Offset: 0x1A8D1B0 VA: 0x181A8EBB0
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0x1A8CCC0 Offset: 0x1A8B2C0 VA: 0x181A8CCC0
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0x1A97EC0 Offset: 0x1A964C0 VA: 0x181A97EC0
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0x1A97AE0 Offset: 0x1A960E0 VA: 0x181A97AE0
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	// RVA: 0x1A8DF00 Offset: 0x1A8C500 VA: 0x181A8DF00
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0x1A8DF30 Offset: 0x1A8C530 VA: 0x181A8DF30
	public void Clear() { }

	// RVA: 0x1A8DF40 Offset: 0x1A8C540 VA: 0x181A8DF40
	internal void Clear(bool clearAll) { }

	// RVA: 0x1A8D040 Offset: 0x1A8B640 VA: 0x181A8D040
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0x1A8FB90 Offset: 0x1A8E190 VA: 0x181A8FB90
	internal void CommitRow(DataRow row) { }

	// RVA: 0x1A8FE70 Offset: 0x1A8E470 VA: 0x181A8FE70
	internal int Compare(string s1, string s2) { }

	// RVA: 0x1A8FCD0 Offset: 0x1A8E2D0 VA: 0x181A8FCD0
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0x1A97450 Offset: 0x1A95A50 VA: 0x181A97450
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0x1A98110 Offset: 0x1A96710 VA: 0x181A98110
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0x1A90DE0 Offset: 0x1A8F3E0 VA: 0x181A90DE0
	internal void DeleteRow(DataRow row) { }

	// RVA: 0x1A95F80 Offset: 0x1A94580 VA: 0x181A95F80
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0x1A960B0 Offset: 0x1A946B0 VA: 0x181A960B0
	internal void FreeRecord(ref int record) { }

	// RVA: 0x1A96520 Offset: 0x1A94B20 VA: 0x181A96520
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1A96330 Offset: 0x1A94930 VA: 0x181A96330
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1A96800 Offset: 0x1A94E00 VA: 0x181A96800
	internal List<DataViewListener> GetListeners() { }

	// RVA: 0x1A97090 Offset: 0x1A95690 VA: 0x181A97090
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0x1A976A0 Offset: 0x1A95CA0 VA: 0x181A976A0
	internal void InsertRow(DataRow row, long proposedID) { }

	// RVA: 0x1A98C50 Offset: 0x1A97250 VA: 0x181A98C50
	internal int NewRecord() { }

	// RVA: 0x1A99160 Offset: 0x1A97760 VA: 0x181A99160
	internal int NewUninitializedRecord() { }

	// RVA: 0x1A98C60 Offset: 0x1A97260 VA: 0x181A98C60
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0x1A98BE0 Offset: 0x1A971E0 VA: 0x181A98BE0
	internal DataRow NewEmptyRow() { }

	// RVA: 0x1A99180 Offset: 0x1A97780 VA: 0x181A99180
	private DataRow NewUninitializedRow() { }

	// RVA: 0x1A99060 Offset: 0x1A97660 VA: 0x181A99060
	public DataRow NewRow() { }

	// RVA: 0x1A903A0 Offset: 0x1A8E9A0 VA: 0x181A903A0
	internal DataRow CreateEmptyRow() { }

	// RVA: 0x1A98EE0 Offset: 0x1A974E0 VA: 0x181A98EE0
	private void NewRowCreated(DataRow row) { }

	// RVA: 0x1A98FC0 Offset: 0x1A975C0 VA: 0x181A98FC0
	internal DataRow NewRow(int record) { }

	// RVA: 0x1A98F60 Offset: 0x1A97560 VA: 0x181A98F60 Slot: 17
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0x1A96E80 Offset: 0x1A95480 VA: 0x181A96E80 Slot: 18
	protected virtual Type GetRowType() { }

	// RVA: 0x1A98D50 Offset: 0x1A97350 VA: 0x181A98D50
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0x1AA3BD0 Offset: 0x1AA21D0 VA: 0x181AA3BD0
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0x1A99290 Offset: 0x1A97890 VA: 0x181A99290 Slot: 19
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0x1A991C0 Offset: 0x1A977C0 VA: 0x181A991C0 Slot: 20
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0x1A99360 Offset: 0x1A97960 VA: 0x181A99360 Slot: 21
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1A99430 Offset: 0x1A97A30 VA: 0x181A99430
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 22
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0x1A99450 Offset: 0x1A97A50 VA: 0x181A99450
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1A995D0 Offset: 0x1A97BD0 VA: 0x181A995D0
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1A99500 Offset: 0x1A97B00 VA: 0x181A99500 Slot: 23
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0x1A99680 Offset: 0x1A97C80 VA: 0x181A99680 Slot: 24
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0x1A99820 Offset: 0x1A97E20 VA: 0x181A99820 Slot: 25
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0x1A99750 Offset: 0x1A97D50 VA: 0x181A99750 Slot: 26
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0x1A998F0 Offset: 0x1A97EF0 VA: 0x181A998F0 Slot: 27
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0x1A999C0 Offset: 0x1A97FC0 VA: 0x181A999C0 Slot: 28
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0x1A99A90 Offset: 0x1A98090 VA: 0x181A99A90 Slot: 29
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0x1A99B60 Offset: 0x1A98160 VA: 0x181A99B60
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0x1A99EE0 Offset: 0x1A984E0 VA: 0x181A99EE0
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1A9D4E0 Offset: 0x1A9BAE0 VA: 0x181A9D4E0
	internal void RecordChanged(int record) { }

	// RVA: 0x1A9D660 Offset: 0x1A9BC60 VA: 0x181A9D660
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0x1A9DA30 Offset: 0x1A9C030 VA: 0x181A9DA30
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x1A9D820 Offset: 0x1A9BE20 VA: 0x181A9D820
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0x1A9DC50 Offset: 0x1A9C250 VA: 0x181A9DC50
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A97510 Offset: 0x1A95B10 VA: 0x181A97510
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x1AA2200 Offset: 0x1AA0800 VA: 0x181AA2200
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0x1A9DE20 Offset: 0x1A9C420 VA: 0x181A9DE20
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0x1A9E1E0 Offset: 0x1A9C7E0 VA: 0x181A9E1E0 Slot: 30
	public virtual void Reset() { }

	// RVA: 0x1A9E000 Offset: 0x1A9C600 VA: 0x181A9E000
	internal void ResetIndexes() { }

	// RVA: 0x1A9E010 Offset: 0x1A9C610 VA: 0x181A9E010
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0x1A9E8D0 Offset: 0x1A9CED0 VA: 0x181A9E8D0
	internal void RollbackRow(DataRow row) { }

	// RVA: 0x1A99F60 Offset: 0x1A98560 VA: 0x181A99F60
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1A9A380 Offset: 0x1A98980 VA: 0x181A9A380
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1A9A1B0 Offset: 0x1A987B0 VA: 0x181A9A1B0
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0x1AA1DA0 Offset: 0x1AA03A0 VA: 0x181AA1DA0
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	// RVA: 0x1AA1430 Offset: 0x1A9FA30 VA: 0x181AA1430
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0x1AA1E20 Offset: 0x1AA0420 VA: 0x181AA1E20
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0x1A9E8B0 Offset: 0x1A9CEB0 VA: 0x181A9E8B0
	private void RestoreShadowIndexes() { }

	// RVA: 0x1AA2110 Offset: 0x1AA0710 VA: 0x181AA2110
	private void SetShadowIndexes() { }

	// RVA: 0x1AA2160 Offset: 0x1AA0760 VA: 0x181AA2160
	internal void ShadowIndexCopy() { }

	// RVA: 0x1AA26B0 Offset: 0x1AA0CB0 VA: 0x181AA26B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AA2750 Offset: 0x1AA0D50 VA: 0x181AA2750
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0x1A8CD00 Offset: 0x1A8B300 VA: 0x181A8CD00
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0x1A8CCF0 Offset: 0x1A8B2F0 VA: 0x181A8CCF0
	internal DataColumn AddUniqueKey() { }

	// RVA: 0x1A8CC00 Offset: 0x1A8B200 VA: 0x181A8CC00
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0x1AA2730 Offset: 0x1AA0D30 VA: 0x181AA2730
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0x1A96900 Offset: 0x1A94F00 VA: 0x181A96900
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0x1AA4270 Offset: 0x1AA2870 VA: 0x181AA4270
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0x1AA57D0 Offset: 0x1AA3DD0 VA: 0x181AA57D0
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0x1A98880 Offset: 0x1A96E80 VA: 0x181A98880
	public void Merge(DataTable table) { }

	// RVA: 0x1A988A0 Offset: 0x1A96EA0 VA: 0x181A988A0
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1AA2BA0 Offset: 0x1AA11A0 VA: 0x181AA2BA0
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0x1A8D7E0 Offset: 0x1A8BDE0 VA: 0x181A8D7E0
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1A8D420 Offset: 0x1A8BA20 VA: 0x181A8D420
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	// RVA: 0x1AA2780 Offset: 0x1AA0D80 VA: 0x181AA2780
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0x1A9E4B0 Offset: 0x1A9CAB0 VA: 0x181A9E4B0
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0x1A97EE0 Offset: 0x1A964E0 VA: 0x181A97EE0
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0x1A9C530 Offset: 0x1A9AB30 VA: 0x181A9C530
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x1A9A610 Offset: 0x1A98C10 VA: 0x181A9A610
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x1A9A6C0 Offset: 0x1A98CC0 VA: 0x181A9A6C0
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x1A98B10 Offset: 0x1A97110 VA: 0x181A98B10
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x1A9A940 Offset: 0x1A98F40 VA: 0x181A9A940
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x1A9A730 Offset: 0x1A98D30 VA: 0x181A9A730
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1A9B3B0 Offset: 0x1A999B0 VA: 0x181A9B3B0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1A90AE0 Offset: 0x1A8F0E0 VA: 0x181A90AE0
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	// RVA: 0x1A90770 Offset: 0x1A8ED70 VA: 0x181A90770
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	// RVA: 0x1A960D0 Offset: 0x1A946D0 VA: 0x181A960D0
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xBCC730 Offset: 0xBCAD30 VA: 0x180BCC730 Slot: 11
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1A96ED0 Offset: 0x1A954D0 VA: 0x181A96ED0 Slot: 31
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0x1AA2590 Offset: 0x1AA0B90 VA: 0x181AA2590 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1AA2660 Offset: 0x1AA0C60 VA: 0x181AA2660 Slot: 13
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1A9C510 Offset: 0x1A9AB10 VA: 0x181A9C510 Slot: 32
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x1AA3FB0 Offset: 0x1AA25B0 VA: 0x181AA3FB0
	internal Hashtable get_RowDiffId() { }

	// RVA: 0x1AA3E90 Offset: 0x1AA2490 VA: 0x181AA3E90
	internal int get_ObjectID() { }

	// RVA: 0x1A8CAC0 Offset: 0x1A8B0C0 VA: 0x181A8CAC0
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1A9DBC0 Offset: 0x1A9C1C0 VA: 0x181A9DBC0
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1A95220 Offset: 0x1A93820 VA: 0x181A95220
	internal void EvaluateExpressions() { }

	// RVA: 0x1A95500 Offset: 0x1A93B00 VA: 0x181A95500
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	// RVA: 0x1A94FB0 Offset: 0x1A935B0 VA: 0x181A94FB0
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0x1A94E70 Offset: 0x1A93470 VA: 0x181A94E70
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0x1A94600 Offset: 0x1A92C00 VA: 0x181A94600
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }
}

// Namespace: System.Data
internal sealed class FunctionNode : ExpressionNode // TypeDefIndex: 8632
{
	// Fields
	internal readonly string _name; // 0x18
	internal readonly int _info; // 0x20
	internal int _argumentCount; // 0x24
	internal ExpressionNode[] _arguments; // 0x28
	[Nullable(2)]
	private readonly TypeLimiter _capturedLimiter; // 0x30
	private static readonly Function[] s_funcs; // 0x0

	// Properties
	internal FunctionId Aggregate { get; }
	internal bool IsAggregate { get; }

	// Methods

	// RVA: 0x1AC8900 Offset: 0x1AC6F00 VA: 0x181AC8900
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x1AC4740 Offset: 0x1AC2D40 VA: 0x181AC4740
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0x1AC4940 Offset: 0x1AC2F40 VA: 0x181AC4940 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1AC7760 Offset: 0x1AC5D60 VA: 0x181AC7760 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1AC6C50 Offset: 0x1AC5250 VA: 0x181AC6C50 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1AC7720 Offset: 0x1AC5D20 VA: 0x181AC7720 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1AC7B40 Offset: 0x1AC6140 VA: 0x181AC7B40 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1AC7BC0 Offset: 0x1AC61C0 VA: 0x181AC7BC0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1AC7A40 Offset: 0x1AC6040 VA: 0x181AC7A40 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1AC7AC0 Offset: 0x1AC60C0 VA: 0x181AC7AC0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1AC4EB0 Offset: 0x1AC34B0 VA: 0x181AC4EB0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1AC7C40 Offset: 0x1AC6240 VA: 0x181AC7C40 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1AC7780 Offset: 0x1AC5D80 VA: 0x181AC7780
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0x1AC4F40 Offset: 0x1AC3540 VA: 0x181AC4F40
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0x1AC8A60 Offset: 0x1AC7060 VA: 0x181AC8A60
	internal FunctionId get_Aggregate() { }

	// RVA: 0x1AC8B00 Offset: 0x1AC7100 VA: 0x181AC8B00
	internal bool get_IsAggregate() { }

	// RVA: 0x1AC4C50 Offset: 0x1AC3250 VA: 0x181AC4C50
	internal void Check() { }

	// RVA: 0x1AC7E30 Offset: 0x1AC6430 VA: 0x181AC7E30
	private static void .cctor() { }
}

// Namespace: System.Data
internal enum FunctionId // TypeDefIndex: 8633
{
	// Fields
	public int value__; // 0x0
	public const FunctionId none = -1;
	public const FunctionId Ascii = 0;
	public const FunctionId Char = 1;
	public const FunctionId Charindex = 2;
	public const FunctionId Difference = 3;
	public const FunctionId Len = 4;
	public const FunctionId Lower = 5;
	public const FunctionId LTrim = 6;
	public const FunctionId Patindex = 7;
	public const FunctionId Replicate = 8;
	public const FunctionId Reverse = 9;
	public const FunctionId Right = 10;
	public const FunctionId RTrim = 11;
	public const FunctionId Soundex = 12;
	public const FunctionId Space = 13;
	public const FunctionId Str = 14;
	public const FunctionId Stuff = 15;
	public const FunctionId Substring = 16;
	public const FunctionId Upper = 17;
	public const FunctionId IsNull = 18;
	public const FunctionId Iif = 19;
	public const FunctionId Convert = 20;
	public const FunctionId cInt = 21;
	public const FunctionId cBool = 22;
	public const FunctionId cDate = 23;
	public const FunctionId cDbl = 24;
	public const FunctionId cStr = 25;
	public const FunctionId Abs = 26;
	public const FunctionId Acos = 27;
	public const FunctionId In = 28;
	public const FunctionId Trim = 29;
	public const FunctionId Sum = 30;
	public const FunctionId Avg = 31;
	public const FunctionId Min = 32;
	public const FunctionId Max = 33;
	public const FunctionId Count = 34;
	public const FunctionId StDev = 35;
	public const FunctionId Var = 37;
	public const FunctionId DateTimeOffset = 38;
}

// Namespace: System.Data
internal sealed class Function // TypeDefIndex: 8634
{
	// Fields
	internal readonly string _name; // 0x10
	internal readonly FunctionId _id; // 0x18
	internal readonly Type _result; // 0x20
	internal readonly bool _isValidateArguments; // 0x28
	internal readonly bool _isVariantArgumentList; // 0x29
	internal readonly int _argumentCount; // 0x2C
	internal readonly Type[] _parameters; // 0x30
	internal static string[] s_functionName; // 0x0

	// Methods

	// RVA: 0x1AE36F0 Offset: 0x1AE1CF0 VA: 0x181AE36F0
	internal void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	// RVA: 0x1AE2F60 Offset: 0x1AE1560 VA: 0x181AE2F60
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class TypeLimiter // TypeDefIndex: 8638
{
	// Fields
	[ThreadStatic]
	[Nullable(2)]
	private static TypeLimiter.Scope s_activeScope; // 0x80000000
	private TypeLimiter.Scope m_instanceScope; // 0x10

	// Properties
	private static bool IsTypeLimitingDisabled { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	private void .ctor(TypeLimiter.Scope scope) { }

	// RVA: 0x1AE5260 Offset: 0x1AE3860 VA: 0x181AE5260
	private static bool get_IsTypeLimitingDisabled() { }

	[NullableContext(2)]
	// RVA: 0x1AE49F0 Offset: 0x1AE2FF0 VA: 0x181AE49F0
	public static TypeLimiter Capture() { }

	[NullableContext(2)]
	// RVA: 0x1AE4A70 Offset: 0x1AE3070 VA: 0x181AE4A70
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0x1AE4C50 Offset: 0x1AE3250 VA: 0x181AE4C50
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0x1AE4E90 Offset: 0x1AE3490 VA: 0x181AE4E90
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0x1AE5100 Offset: 0x1AE3700 VA: 0x181AE5100
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0x1AE4FA0 Offset: 0x1AE35A0 VA: 0x181AE4FA0
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }
}

// Namespace: System.Data
public enum AcceptRejectRule // TypeDefIndex: 8639
{
	// Fields
	public int value__; // 0x0
	public const AcceptRejectRule None = 0;
	public const AcceptRejectRule Cascade = 1;
}

// Namespace: System.Data
internal enum AggregateType // TypeDefIndex: 8640
{
	// Fields
	public int value__; // 0x0
	public const AggregateType None = 0;
	public const AggregateType Sum = 4;
	public const AggregateType Mean = 5;
	public const AggregateType Min = 6;
	public const AggregateType Max = 7;
	public const AggregateType First = 8;
	public const AggregateType Count = 9;
	public const AggregateType Var = 10;
	public const AggregateType StDev = 11;
}

// Namespace: System.Data
public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 8641
{
	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x0

	// Properties
	[Browsable(False)]
	public virtual int Count { get; }
	[Browsable(False)]
	public bool IsSynchronized { get; }
	[Browsable(False)]
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0x1AE3B50 Offset: 0x1AE2150 VA: 0x181AE3B50 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x1AE3930 Offset: 0x1AE1F30 VA: 0x181AE3930 Slot: 10
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0x1AE3990 Offset: 0x1AE1F90 VA: 0x181AE3990 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1AE39D0 Offset: 0x1AE1FD0 VA: 0x181AE39D0
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 12
	protected virtual ArrayList get_List() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1AE3AD0 Offset: 0x1AE20D0 VA: 0x181AE3AD0
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class ColumnTypeConverter : TypeConverter // TypeDefIndex: 8642
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private TypeConverter.StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x1AC98C0 Offset: 0x1AC7EC0 VA: 0x181AC98C0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1AC9B60 Offset: 0x1AC8160 VA: 0x181AC9B60 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1AC9840 Offset: 0x1AC7E40 VA: 0x181AC9840 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1AC9960 Offset: 0x1AC7F60 VA: 0x181AC9960 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1ACA0A0 Offset: 0x1AC86A0 VA: 0x181ACA0A0 Slot: 8
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 9
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1ACA1E0 Offset: 0x1AC87E0 VA: 0x181ACA1E0
	private static void .cctor() { }
}

// Namespace: System.Data
[EventSource(Name = "System.Data.DataCommonEventSource")]
internal class DataCommonEventSource : EventSource // TypeDefIndex: 8643
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8

	// Methods

	[Event(1, Level = 4)]
	// RVA: 0x1AD2820 Offset: 0x1AD0E20 VA: 0x181AD2820
	internal void Trace(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CECC0 Offset: 0x6CD2C0 VA: 0x1806CECC0
	|-DataCommonEventSource.Trace<int>
	|
	|-RVA: 0x6CED90 Offset: 0x6CD390 VA: 0x1806CED90
	|-DataCommonEventSource.Trace<object>
	|
	|-RVA: 0x6CD7E0 Offset: 0x6CBDE0 VA: 0x1806CD7E0
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CD900 Offset: 0x6CBF00 VA: 0x1806CD900
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-RVA: 0x6CDA00 Offset: 0x6CC000 VA: 0x1806CDA00
	|-DataCommonEventSource.Trace<int, int>
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-RVA: 0x6CE3A0 Offset: 0x6CC9A0 VA: 0x1806CE3A0
	|-DataCommonEventSource.Trace<int, long>
	|
	|-RVA: 0x6CEBE0 Offset: 0x6CD1E0 VA: 0x1806CEBE0
	|-DataCommonEventSource.Trace<int, object>
	|
	|-RVA: 0x6CD640 Offset: 0x6CBC40 VA: 0x1806CD640
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CDB00 Offset: 0x6CC100 VA: 0x1806CDB00
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-RVA: 0x6CE280 Offset: 0x6CC880 VA: 0x1806CE280
	|-DataCommonEventSource.Trace<int, int, int>
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-RVA: 0x6CE4A0 Offset: 0x6CCAA0 VA: 0x1806CE4A0
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|
	|-RVA: 0x6CEAF0 Offset: 0x6CD0F0 VA: 0x1806CEAF0
	|-DataCommonEventSource.Trace<int, object, object>
	|
	|-RVA: 0x6CD410 Offset: 0x6CBA10 VA: 0x1806CD410
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CDFF0 Offset: 0x6CC5F0 VA: 0x1806CDFF0
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x6CE890 Offset: 0x6CCE90 VA: 0x1806CE890
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|
	|-RVA: 0x6CD030 Offset: 0x6CB630 VA: 0x1806CD030
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CE5B0 Offset: 0x6CCBB0 VA: 0x1806CE5B0
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|
	|-RVA: 0x6CCB90 Offset: 0x6CB190 VA: 0x1806CCB90
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CDC20 Offset: 0x6CC220 VA: 0x1806CDC20
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x6CC570 Offset: 0x6CAB70 VA: 0x1806CC570
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(2, Level = 5)]
	// RVA: 0x1AD2740 Offset: 0x1AD0D40 VA: 0x181AD2740
	internal long EnterScope(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CC4A0 Offset: 0x6CAAA0 VA: 0x1806CC4A0
	|-DataCommonEventSource.EnterScope<int>
	|
	|-RVA: 0x6CBAA0 Offset: 0x6CA0A0 VA: 0x1806CBAA0
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CBBD0 Offset: 0x6CA1D0 VA: 0x1806CBBD0
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-RVA: 0x6CBE00 Offset: 0x6CA400 VA: 0x1806CBE00
	|-DataCommonEventSource.EnterScope<int, int>
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-RVA: 0x6CC3C0 Offset: 0x6CA9C0 VA: 0x1806CC3C0
	|-DataCommonEventSource.EnterScope<int, object>
	|
	|-RVA: 0x6CB900 Offset: 0x6C9F00 VA: 0x1806CB900
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CBCD0 Offset: 0x6CA2D0 VA: 0x1806CBCD0
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-RVA: 0x6CC1A0 Offset: 0x6CA7A0 VA: 0x1806CC1A0
	|-DataCommonEventSource.EnterScope<int, int, object>
	|
	|-RVA: 0x6CC2B0 Offset: 0x6CA8B0 VA: 0x1806CC2B0
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|
	|-RVA: 0x6CB6D0 Offset: 0x6C9CD0 VA: 0x1806CB6D0
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CBF00 Offset: 0x6CA500 VA: 0x1806CBF00
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-RVA: 0x6CB2E0 Offset: 0x6C98E0 VA: 0x1806CB2E0
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(3, Level = 5)]
	// RVA: 0x1AD2810 Offset: 0x1AD0E10 VA: 0x181AD2810
	internal void ExitScope(long scopeId) { }

	// RVA: 0x1AD28B0 Offset: 0x1AD0EB0 VA: 0x181AD28B0
	public void .ctor() { }

	// RVA: 0x1AD2830 Offset: 0x1AD0E30 VA: 0x181AD2830
	private static void .cctor() { }
}

// Namespace: System.Data
[TypeConverter(typeof(ConstraintConverter))]
[DefaultProperty("ConstraintName")]
public abstract class Constraint // TypeDefIndex: 8644
{
	// Fields
	private string _schemaName; // 0x10
	private bool _inCollection; // 0x18
	private DataSet _dataSet; // 0x20
	internal string _name; // 0x28
	internal PropertyCollection _extendedProperties; // 0x30

	// Properties
	[DefaultValue("")]
	public virtual string ConstraintName { get; set; }
	internal string SchemaName { get; set; }
	internal virtual bool InCollection { get; set; }
	public abstract DataTable Table { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	[CLSCompliant(False)]
	protected virtual DataSet _DataSet { get; }

	// Methods

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 4
	public virtual string get_ConstraintName() { }

	// RVA: 0x1ACEA90 Offset: 0x1ACD090 VA: 0x181ACEA90 Slot: 5
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0x1ACEA50 Offset: 0x1ACD050 VA: 0x181ACEA50
	internal string get_SchemaName() { }

	// RVA: 0x1ACED20 Offset: 0x1ACD320 VA: 0x181ACED20
	internal void set_SchemaName(string value) { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10 Slot: 6
	internal virtual bool get_InCollection() { }

	// RVA: 0x1ACECC0 Offset: 0x1ACD2C0 VA: 0x181ACECC0 Slot: 7
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DataTable get_Table();

	// RVA: 0x1ACE9E0 Offset: 0x1ACCFE0 VA: 0x181ACE9E0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool ContainsColumn(DataColumn column);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool CanEnableConstraint();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract Constraint Clone(DataSet destination);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	// RVA: 0x1ACE810 Offset: 0x1ACCE10 VA: 0x181ACE810
	internal void CheckConstraint() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void CheckState();

	// RVA: 0x1ACE870 Offset: 0x1ACCE70 VA: 0x181ACE870
	protected void CheckStateForProperty() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 17
	protected virtual DataSet get__DataSet() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract bool IsConstraintViolated();

	// RVA: 0x15267C0 Offset: 0x1524DC0 VA: 0x1815267C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ACE980 Offset: 0x1ACCF80 VA: 0x181ACE980
	protected void .ctor() { }
}

// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class ConstraintCollection : InternalDataCollectionBase // TypeDefIndex: 8645
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private CollectionChangeEventHandler _onCollectionChanged; // 0x28
	private Constraint[] _delayLoadingConstraints; // 0x30
	private bool _fLoadForeignKeyConstraintsOnly; // 0x38

	// Properties
	protected override ArrayList List { get; }
	public Constraint Item { get; }
	internal DataTable Table { get; }
	public Constraint Item { get; }

	// Methods

	// RVA: 0x1ACD5C0 Offset: 0x1ACBBC0 VA: 0x181ACD5C0
	internal void .ctor(DataTable table) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x1ACD670 Offset: 0x1ACBC70 VA: 0x181ACD670
	public Constraint get_Item(int index) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal DataTable get_Table() { }

	// RVA: 0x1ACD7A0 Offset: 0x1ACBDA0 VA: 0x181ACD7A0
	public Constraint get_Item(string name) { }

	// RVA: 0x1ACB1D0 Offset: 0x1AC97D0 VA: 0x181ACB1D0
	public void Add(Constraint constraint) { }

	// RVA: 0x1ACB2A0 Offset: 0x1AC98A0 VA: 0x181ACB2A0
	internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	// RVA: 0x1ACB1E0 Offset: 0x1AC97E0 VA: 0x181ACB1E0
	public Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	// RVA: 0x1ACB0D0 Offset: 0x1AC96D0 VA: 0x181ACB0D0
	private void AddUniqueConstraint(UniqueConstraint constraint) { }

	// RVA: 0x1ACB050 Offset: 0x1AC9650 VA: 0x181ACB050
	private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	// RVA: 0x1ACBA30 Offset: 0x1ACA030 VA: 0x181ACBA30
	private bool AutoGenerated(Constraint constraint) { }

	// RVA: 0x1ACB970 Offset: 0x1AC9F70 VA: 0x181ACB970
	private void ArrayAdd(Constraint constraint) { }

	// RVA: 0x1ACB9C0 Offset: 0x1AC9FC0 VA: 0x181ACB9C0
	private void ArrayRemove(Constraint constraint) { }

	// RVA: 0x1ACBA10 Offset: 0x1ACA010 VA: 0x181ACBA10
	internal string AssignName() { }

	// RVA: 0x1ACBAF0 Offset: 0x1ACA0F0 VA: 0x181ACBAF0
	private void BaseAdd(Constraint constraint) { }

	// RVA: 0x1ACBBE0 Offset: 0x1ACA1E0 VA: 0x181ACBBE0
	private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	// RVA: 0x1ACBDD0 Offset: 0x1ACA3D0 VA: 0x181ACBDD0
	private void BaseRemove(Constraint constraint) { }

	// RVA: 0x1ACC130 Offset: 0x1ACA730 VA: 0x181ACC130
	internal bool CanRemove(Constraint constraint, bool fThrowException) { }

	// RVA: 0x1ACC160 Offset: 0x1ACA760 VA: 0x181ACC160
	public void Clear() { }

	// RVA: 0x1ACC730 Offset: 0x1ACAD30 VA: 0x181ACC730
	public bool Contains(string name) { }

	// RVA: 0x1ACC750 Offset: 0x1ACAD50 VA: 0x181ACC750
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1ACC880 Offset: 0x1ACAE80 VA: 0x181ACC880
	internal Constraint FindConstraint(Constraint constraint) { }

	// RVA: 0x1ACCBC0 Offset: 0x1ACB1C0 VA: 0x181ACCBC0
	internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	// RVA: 0x1ACCD10 Offset: 0x1ACB310 VA: 0x181ACCD10
	internal UniqueConstraint FindKeyConstraint(DataColumn column) { }

	// RVA: 0x1ACCA50 Offset: 0x1ACB050 VA: 0x181ACCA50
	internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1ACC690 Offset: 0x1ACAC90 VA: 0x181ACC690
	private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	// RVA: 0x1ACCE50 Offset: 0x1ACB450 VA: 0x181ACCE50
	internal int InternalIndexOf(string constraintName) { }

	// RVA: 0x1ACD070 Offset: 0x1ACB670 VA: 0x181ACD070
	private string MakeName(int index) { }

	// RVA: 0x1ACD110 Offset: 0x1ACB710 VA: 0x181ACD110
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1ACD130 Offset: 0x1ACB730 VA: 0x181ACD130
	internal void RegisterName(string name) { }

	// RVA: 0x1ACD370 Offset: 0x1ACB970 VA: 0x181ACD370
	public void Remove(Constraint constraint) { }

	// RVA: 0x1ACD530 Offset: 0x1ACBB30 VA: 0x181ACD530
	internal void UnregisterName(string name) { }
}

// Namespace: System.Data
internal sealed class ConstraintConverter : ExpandableObjectConverter // TypeDefIndex: 8646
{
	// Methods

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }

	// RVA: 0x1ACD8C0 Offset: 0x1ACBEC0 VA: 0x181ACD8C0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1ACD960 Offset: 0x1ACBF60 VA: 0x181ACD960 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
internal class ConstraintEnumerator // TypeDefIndex: 8647
{
	// Fields
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	// Properties
	protected Constraint CurrentObject { get; }

	// Methods

	// RVA: 0x1ACE790 Offset: 0x1ACCD90 VA: 0x181ACE790
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x1ACE550 Offset: 0x1ACCB50 VA: 0x181ACE550
	public bool GetNext() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Constraint GetConstraint() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 4
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	protected Constraint get_CurrentObject() { }
}

// Namespace: System.Data
internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator // TypeDefIndex: 8648
{
	// Methods

	// RVA: 0x1ACE790 Offset: 0x1ACCD90 VA: 0x181ACE790
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x1AE2EE0 Offset: 0x1AE14E0 VA: 0x181AE2EE0 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x1AE2E70 Offset: 0x1AE1470 VA: 0x181AE2E70
	public ForeignKeyConstraint GetForeignKeyConstraint() { }
}

// Namespace: System.Data
internal sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator // TypeDefIndex: 8649
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0x1AC97A0 Offset: 0x1AC7DA0 VA: 0x181AC97A0
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0x1AC96E0 Offset: 0x1AC7CE0 VA: 0x181AC96E0 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }
}

// Namespace: System.Data
internal sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator // TypeDefIndex: 8650
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0x1AC97A0 Offset: 0x1AC7DA0 VA: 0x181AC97A0
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0x1AE3B90 Offset: 0x1AE2190 VA: 0x181AE3B90 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }
}

// Namespace: System.Data
public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 8651
{
	// Fields
	private DataColumn _column; // 0x10
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x18
	[CompilerGenerated]
	private object <ProposedValue>k__BackingField; // 0x20

	// Properties
	public object ProposedValue { get; set; }

	// Methods

	// RVA: 0x1ACEDA0 Offset: 0x1ACD3A0 VA: 0x181ACEDA0
	internal void .ctor(DataRow row) { }

	// RVA: 0x1ACEE10 Offset: 0x1ACD410 VA: 0x181ACEE10
	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public object get_ProposedValue() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_ProposedValue(object value) { }

	// RVA: 0x1ACED60 Offset: 0x1ACD360 VA: 0x181ACED60
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }
}

// Namespace: System.Data
public sealed class DataColumnChangeEventHandler : MulticastDelegate // TypeDefIndex: 8652
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }
}

// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 8653
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataColumn[] _delayedAddRangeColumns; // 0x28
	private readonly Dictionary<string, DataColumn> _columnFromName; // 0x30
	private bool _fInClear; // 0x38
	private DataColumn[] _columnsImplementingIChangeTracking; // 0x40
	private int _nColumnsImplementingIChangeTracking; // 0x48
	private int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanged; // 0x50
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanging; // 0x58
	[CompilerGenerated]
	private CollectionChangeEventHandler ColumnPropertyChanged; // 0x60

	// Properties
	protected override ArrayList List { get; }
	internal DataColumn[] ColumnsImplementingIChangeTracking { get; }
	internal int ColumnsImplementingIChangeTrackingCount { get; }
	internal int ColumnsImplementingIRevertibleChangeTrackingCount { get; }
	public DataColumn Item { get; }
	public DataColumn Item { get; }
	internal DataColumn Item { get; }

	// Methods

	// RVA: 0x1AD1990 Offset: 0x1ACFF90 VA: 0x181AD1990
	internal void .ctor(DataTable table) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0x9CC880 Offset: 0x9CAE80 VA: 0x1809CC880
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0x1AD1CA0 Offset: 0x1AD02A0 VA: 0x181AD1CA0
	public DataColumn get_Item(int index) { }

	// RVA: 0x1AD1D80 Offset: 0x1AD0380 VA: 0x181AD1D80
	public DataColumn get_Item(string name) { }

	// RVA: 0x1AD1BF0 Offset: 0x1AD01F0 VA: 0x181AD1BF0
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0x1ACF340 Offset: 0x1ACD940 VA: 0x181ACF340
	public void Add(DataColumn column) { }

	// RVA: 0x1ACEEB0 Offset: 0x1ACD4B0 VA: 0x181ACEEB0
	internal void AddAt(int index, DataColumn column) { }

	[CompilerGenerated]
	// RVA: 0x1AD1AB0 Offset: 0x1AD00B0 VA: 0x181AD1AB0
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1AD1F10 Offset: 0x1AD0510 VA: 0x181AD1F10
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1AD1B50 Offset: 0x1AD0150 VA: 0x181AD1B50
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1AD1FB0 Offset: 0x1AD05B0 VA: 0x181AD1FB0
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1ACF3C0 Offset: 0x1ACD9C0 VA: 0x181ACF3C0
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0x1ACF350 Offset: 0x1ACD950 VA: 0x181ACF350
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0x1ACF460 Offset: 0x1ACDA60 VA: 0x181ACF460
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0x1ACF6A0 Offset: 0x1ACDCA0 VA: 0x181ACF6A0
	internal string AssignName() { }

	// RVA: 0x1ACF7C0 Offset: 0x1ACDDC0 VA: 0x181ACF7C0
	private void BaseAdd(DataColumn column) { }

	// RVA: 0x1ACFBF0 Offset: 0x1ACE1F0 VA: 0x181ACFBF0
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0x1ACFE00 Offset: 0x1ACE400 VA: 0x181ACFE00
	private void BaseRemove(DataColumn column) { }

	// RVA: 0x1AD0060 Offset: 0x1ACE660 VA: 0x181AD0060
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0x1AD0990 Offset: 0x1ACEF90 VA: 0x181AD0990
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0x1AD09E0 Offset: 0x1ACEFE0 VA: 0x181AD09E0
	public void Clear() { }

	// RVA: 0x1AD0F10 Offset: 0x1ACF510 VA: 0x181AD0F10
	public bool Contains(string name) { }

	// RVA: 0x1AD0E50 Offset: 0x1ACF450 VA: 0x181AD0E50
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1AD1150 Offset: 0x1ACF750 VA: 0x181AD1150
	public int IndexOf(string columnName) { }

	// RVA: 0x1AD0FA0 Offset: 0x1ACF5A0 VA: 0x181AD0FA0
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0x1AD1260 Offset: 0x1ACF860 VA: 0x181AD1260
	private string MakeName(int index) { }

	// RVA: 0x1AD1300 Offset: 0x1ACF900 VA: 0x181AD1300
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1AD13A0 Offset: 0x1ACF9A0 VA: 0x181AD13A0
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1AD13C0 Offset: 0x1ACF9C0 VA: 0x181AD13C0
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1AD1410 Offset: 0x1ACFA10 VA: 0x181AD1410
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0x1AD0000 Offset: 0x1ACE600 VA: 0x181AD0000
	internal bool CanRegisterName(string name) { }

	// RVA: 0x1AD16E0 Offset: 0x1ACFCE0 VA: 0x181AD16E0
	public void Remove(DataColumn column) { }

	// RVA: 0x1AD1860 Offset: 0x1ACFE60 VA: 0x181AD1860
	internal void UnregisterName(string name) { }

	// RVA: 0x1ACF250 Offset: 0x1ACD850 VA: 0x181ACF250
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0x1AD15B0 Offset: 0x1ACFBB0 VA: 0x181AD15B0
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }
}

// Namespace: System.Data
internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 8654
{
	// Fields
	[CompilerGenerated]
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Properties
	public override AttributeCollection Attributes { get; }
	internal DataColumn Column { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1AD2490 Offset: 0x1AD0A90 VA: 0x181AD2490
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0x1AD24E0 Offset: 0x1AD0AE0 VA: 0x181AD24E0 Slot: 6
	public override AttributeCollection get_Attributes() { }

	[CompilerGenerated]
	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	internal DataColumn get_Column() { }

	// RVA: 0x1AD26B0 Offset: 0x1AD0CB0 VA: 0x181AD26B0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1AD2700 Offset: 0x1AD0D00 VA: 0x181AD2700 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1AD2720 Offset: 0x1AD0D20 VA: 0x181AD2720 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1AD2180 Offset: 0x1AD0780 VA: 0x181AD2180 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1AD2220 Offset: 0x1AD0820 VA: 0x181AD2220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD2050 Offset: 0x1AD0650 VA: 0x181AD2050 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x1AD2250 Offset: 0x1AD0850 VA: 0x181AD2250 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x1AD22E0 Offset: 0x1AD08E0 VA: 0x181AD22E0 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x1AD23A0 Offset: 0x1AD09A0 VA: 0x181AD23A0 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: System.Data
internal sealed class DataError // TypeDefIndex: 8656
{
	// Fields
	private string _rowError; // 0x10
	private int _count; // 0x18
	private DataError.ColumnError[] _errorList; // 0x20

	// Properties
	internal string Text { get; set; }
	internal bool HasErrors { get; }

	// Methods

	// RVA: 0x1AD3010 Offset: 0x1AD1610 VA: 0x181AD3010
	internal void .ctor() { }

	// RVA: 0x1AD2FA0 Offset: 0x1AD15A0 VA: 0x181AD2FA0
	internal void .ctor(string rowError) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal string get_Text() { }

	// RVA: 0x1AD2F70 Offset: 0x1AD1570 VA: 0x181AD2F70
	internal void set_Text(string value) { }

	// RVA: 0x1AD3050 Offset: 0x1AD1650 VA: 0x181AD3050
	internal bool get_HasErrors() { }

	// RVA: 0x1AD2CB0 Offset: 0x1AD12B0 VA: 0x181AD2CB0
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x1AD29F0 Offset: 0x1AD0FF0 VA: 0x181AD29F0
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0x1AD28C0 Offset: 0x1AD0EC0 VA: 0x181AD28C0
	internal void Clear(DataColumn column) { }

	// RVA: 0x1AD2970 Offset: 0x1AD0F70 VA: 0x181AD2970
	internal void Clear() { }

	// RVA: 0x1AD2A60 Offset: 0x1AD1060 VA: 0x181AD2A60
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0x1AD2F70 Offset: 0x1AD1570 VA: 0x181AD2F70
	private void SetText(string errorText) { }

	// RVA: 0x1AD2B50 Offset: 0x1AD1150 VA: 0x181AD2B50
	internal int IndexOf(DataColumn column) { }
}

// Namespace: System.Data
[IsReadOnly]
internal struct DataKey // TypeDefIndex: 8657
{
	// Fields
	private readonly DataColumn[] _columns; // 0x0

	// Properties
	internal DataColumn[] ColumnsReference { get; }
	internal bool HasValue { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x1AD3A10 Offset: 0x1AD2010 VA: 0x181AD3A10
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x1575E10 Offset: 0x1574410 VA: 0x181575E10
	internal bool get_HasValue() { }

	// RVA: 0x1AD3CC0 Offset: 0x1AD22C0 VA: 0x181AD3CC0
	internal DataTable get_Table() { }

	// RVA: 0x1AD3080 Offset: 0x1AD1680 VA: 0x181AD3080
	internal void CheckState() { }

	// RVA: 0x1AD3230 Offset: 0x1AD1830 VA: 0x181AD3230
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0x1AD3180 Offset: 0x1AD1780 VA: 0x181AD3180
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0x1AD32E0 Offset: 0x1AD18E0 VA: 0x181AD32E0
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1AD3520 Offset: 0x1AD1B20 VA: 0x181AD3520 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD33D0 Offset: 0x1AD19D0 VA: 0x181AD33D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AD3330 Offset: 0x1AD1930 VA: 0x181AD3330
	internal bool Equals(DataKey value) { }

	// RVA: 0x1AD3450 Offset: 0x1AD1A50 VA: 0x181AD3450
	internal string[] GetColumnNames() { }

	// RVA: 0x1AD3570 Offset: 0x1AD1B70 VA: 0x181AD3570
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0x1AD3670 Offset: 0x1AD1C70 VA: 0x181AD3670
	internal object[] GetKeyValues(int record) { }

	// RVA: 0x1AD3810 Offset: 0x1AD1E10 VA: 0x181AD3810
	internal Index GetSortIndex() { }

	// RVA: 0x1AD37A0 Offset: 0x1AD1DA0 VA: 0x181AD37A0
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0x1AD3870 Offset: 0x1AD1E70 VA: 0x181AD3870
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0x1AD3910 Offset: 0x1AD1F10 VA: 0x181AD3910
	internal DataColumn[] ToArray() { }
}

// Namespace: System.Data
[DefaultProperty("RelationName")]
[TypeConverter(typeof(RelationshipConverter))]
public class DataRelation // TypeDefIndex: 8658
{
	// Fields
	private DataSet _dataSet; // 0x10
	internal PropertyCollection _extendedProperties; // 0x18
	internal string _relationName; // 0x20
	private DataKey _childKey; // 0x28
	private DataKey _parentKey; // 0x30
	private UniqueConstraint _parentKeyConstraint; // 0x38
	private ForeignKeyConstraint _childKeyConstraint; // 0x40
	internal string[] _parentColumnNames; // 0x48
	internal string[] _childColumnNames; // 0x50
	internal string _parentTableName; // 0x58
	internal string _childTableName; // 0x60
	internal string _parentTableNamespace; // 0x68
	internal string _childTableNamespace; // 0x70
	internal bool _nested; // 0x78
	internal bool _createConstraints; // 0x79
	private bool _checkMultipleNested; // 0x7A
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x7C
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x80

	// Properties
	public virtual DataColumn[] ChildColumns { get; }
	internal DataColumn[] ChildColumnsReference { get; }
	internal DataKey ChildKey { get; }
	public virtual DataTable ChildTable { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual DataSet DataSet { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	public virtual DataColumn[] ParentColumns { get; }
	internal DataColumn[] ParentColumnsReference { get; }
	internal DataKey ParentKey { get; }
	public virtual DataTable ParentTable { get; }
	[DefaultValue("")]
	public virtual string RelationName { get; }
	[DefaultValue(False)]
	public virtual bool Nested { get; set; }
	public virtual UniqueConstraint ParentKeyConstraint { get; }
	public virtual ForeignKeyConstraint ChildKeyConstraint { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool CheckMultipleNested { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1AD7970 Offset: 0x1AD5F70 VA: 0x181AD7970
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0x1AD7C80 Offset: 0x1AD6280 VA: 0x181AD7C80
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1AD7BC0 Offset: 0x1AD61C0 VA: 0x181AD7BC0
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	[Browsable(False)]
	// RVA: 0x1AD7DC0 Offset: 0x1AD63C0 VA: 0x181AD7DC0
	public void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	[Browsable(False)]
	// RVA: 0x1AD7CA0 Offset: 0x1AD62A0 VA: 0x181AD7CA0
	public void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0x1AD7F00 Offset: 0x1AD6500 VA: 0x181AD7F00 Slot: 4
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0x1AD7EE0 Offset: 0x1AD64E0 VA: 0x181AD7EE0
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0x1AD7EE0 Offset: 0x1AD64E0 VA: 0x181AD7EE0
	internal DataKey get_ChildKey() { }

	// RVA: 0x1AD7F40 Offset: 0x1AD6540 VA: 0x181AD7F40 Slot: 5
	public virtual DataTable get_ChildTable() { }

	// RVA: 0x1AD7F80 Offset: 0x1AD6580 VA: 0x181AD7F80 Slot: 6
	public virtual DataSet get_DataSet() { }

	// RVA: 0x1AD8030 Offset: 0x1AD6630 VA: 0x181AD8030
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x1AD7ED0 Offset: 0x1AD64D0 VA: 0x181AD7ED0
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x1AD7230 Offset: 0x1AD5830 VA: 0x181AD7230
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0x1AD6B70 Offset: 0x1AD5170 VA: 0x181AD6B70
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0x1AD6EF0 Offset: 0x1AD54F0 VA: 0x181AD6EF0
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1AD6CF0 Offset: 0x1AD52F0 VA: 0x181AD6CF0
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1AD74C0 Offset: 0x1AD5AC0 VA: 0x181AD74C0
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x1AD8040 Offset: 0x1AD6640 VA: 0x181AD8040 Slot: 7
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0x1AD8080 Offset: 0x1AD6680 VA: 0x181AD8080
	internal DataKey get_ParentKey() { }

	// RVA: 0x1AD80A0 Offset: 0x1AD66A0 VA: 0x181AD80A0 Slot: 8
	public virtual DataTable get_ParentTable() { }

	// RVA: 0x1AD80E0 Offset: 0x1AD66E0 VA: 0x181AD80E0 Slot: 9
	public virtual string get_RelationName() { }

	// RVA: 0x1AD5630 Offset: 0x1AD3C30 VA: 0x181AD5630
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0x1AD5900 Offset: 0x1AD3F00 VA: 0x181AD5900
	internal void CheckNestedRelations() { }

	// RVA: 0x1AD8010 Offset: 0x1AD6610 VA: 0x181AD8010 Slot: 10
	public virtual bool get_Nested() { }

	// RVA: 0x1AD8110 Offset: 0x1AD6710 VA: 0x181AD8110 Slot: 11
	public virtual void set_Nested(bool value) { }

	// RVA: 0x1AD8060 Offset: 0x1AD6660 VA: 0x181AD8060 Slot: 12
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0x1AD7F20 Offset: 0x1AD6520 VA: 0x181AD7F20 Slot: 13
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0x1AD7FA0 Offset: 0x1AD65A0 VA: 0x181AD7FA0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1AD7EC0 Offset: 0x1AD64C0 VA: 0x181AD7EC0
	internal bool get_CheckMultipleNested() { }

	// RVA: 0x1AD8100 Offset: 0x1AD6700 VA: 0x181AD8100
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0x1AD5E20 Offset: 0x1AD4420 VA: 0x181AD5E20
	internal void CheckState() { }

	// RVA: 0x1AD5D20 Offset: 0x1AD4320 VA: 0x181AD5D20
	protected void CheckStateForProperty() { }

	// RVA: 0x1AD6830 Offset: 0x1AD4E30 VA: 0x181AD6830
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x1AD6110 Offset: 0x1AD4710 VA: 0x181AD6110
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0x1AD72E0 Offset: 0x1AD58E0 VA: 0x181AD72E0
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1AD73B0 Offset: 0x1AD59B0 VA: 0x181AD73B0
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1557280 Offset: 0x1555880 VA: 0x181557280 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AD74E0 Offset: 0x1AD5AE0 VA: 0x181AD74E0
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0x1AD7070 Offset: 0x1AD5670 VA: 0x181AD7070
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0x15D1060 Offset: 0x15CF660 VA: 0x1815D1060
	internal int get_ObjectID() { }
}

// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 8661
{
	// Fields
	private DataRelation _inTransition; // 0x10
	private int _defaultNameIndex; // 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x30

	// Properties
	internal int ObjectID { get; }
	public abstract DataRelation Item { get; }
	public abstract DataRelation Item { get; }

	// Methods

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	internal int get_ObjectID() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract DataRelation get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract DataRelation get_Item(string name);

	// RVA: 0x1AD4010 Offset: 0x1AD2610 VA: 0x181AD4010
	public void Add(DataRelation relation) { }

	// RVA: 0x1AD3CF0 Offset: 0x1AD22F0 VA: 0x181AD3CF0 Slot: 15
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0x1AD51D0 Offset: 0x1AD37D0 VA: 0x181AD51D0
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1AD52E0 Offset: 0x1AD38E0 VA: 0x181AD52E0
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1AD42F0 Offset: 0x1AD28F0 VA: 0x181AD42F0
	internal string AssignName() { }

	// RVA: 0x1AD4310 Offset: 0x1AD2910 VA: 0x181AD4310 Slot: 16
	public virtual void Clear() { }

	// RVA: 0x1AD4570 Offset: 0x1AD2B70 VA: 0x181AD4570 Slot: 17
	public virtual bool Contains(string name) { }

	// RVA: 0x1AD4590 Offset: 0x1AD2B90 VA: 0x181AD4590
	internal int InternalIndexOf(string name) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract DataSet GetDataSet();

	// RVA: 0x1AD47B0 Offset: 0x1AD2DB0 VA: 0x181AD47B0
	private string MakeName(int index) { }

	// RVA: 0x1AD4850 Offset: 0x1AD2E50 VA: 0x181AD4850 Slot: 19
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1AD4910 Offset: 0x1AD2F10 VA: 0x181AD4910 Slot: 20
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1AD49D0 Offset: 0x1AD2FD0 VA: 0x181AD49D0
	internal void RegisterName(string name) { }

	// RVA: 0x1AD4E30 Offset: 0x1AD3430 VA: 0x181AD4E30
	public void Remove(DataRelation relation) { }

	// RVA: 0x1AD4BB0 Offset: 0x1AD31B0 VA: 0x181AD4BB0
	public void RemoveAt(int index) { }

	// RVA: 0x1AD4C30 Offset: 0x1AD3230 VA: 0x181AD4C30 Slot: 21
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0x1AD5010 Offset: 0x1AD3610 VA: 0x181AD5010
	internal void UnregisterName(string name) { }

	// RVA: 0x1AD5150 Offset: 0x1AD3750 VA: 0x181AD5150
	protected void .ctor() { }
}

// Namespace: System.Data
internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 8662
{
	// Fields
	[CompilerGenerated]
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Properties
	internal DataRelation Relation { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1AD5520 Offset: 0x1AD3B20 VA: 0x181AD5520
	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGenerated]
	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	internal DataRelation get_Relation() { }

	// RVA: 0x1AD5590 Offset: 0x1AD3B90 VA: 0x181AD5590 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1AD55E0 Offset: 0x1AD3BE0 VA: 0x181AD55E0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1AD53F0 Offset: 0x1AD39F0 VA: 0x181AD53F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1AD2220 Offset: 0x1AD0820 VA: 0x181AD2220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x1AD5490 Offset: 0x1AD3A90 VA: 0x181AD5490 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataRow // TypeDefIndex: 8663
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataColumnCollection _columns; // 0x18
	internal int _oldRecord; // 0x20
	internal int _newRecord; // 0x24
	internal int _tempRecord; // 0x28
	internal long _rowID; // 0x30
	internal DataRowAction _action; // 0x38
	internal bool _inChangingEvent; // 0x3C
	internal bool _inDeletingEvent; // 0x3D
	internal bool _inCascade; // 0x3E
	private DataColumn _lastChangedColumn; // 0x40
	private int _countColumnChange; // 0x48
	private DataError _error; // 0x50
	private int _rbTreeNodeId; // 0x58
	private static int s_objectTypeCount; // 0x0
	internal readonly int _objectID; // 0x5C

	// Properties
	internal DataColumn LastChangedColumn { get; set; }
	internal bool HasPropertyChanged { get; }
	internal int RBTreeNodeId { get; set; }
	public string RowError { get; set; }
	internal long rowID { get; set; }
	public DataRowState RowState { get; }
	public DataTable Table { get; }
	public string Item { set; }
	public object Item { get; set; }
	public object Item { get; }
	public object[] ItemArray { set; }
	public bool HasErrors { get; }

	// Methods

	// RVA: 0x1ADD8A0 Offset: 0x1ADBEA0 VA: 0x181ADD8A0
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0x1ADDB90 Offset: 0x1ADC190 VA: 0x181ADDB90
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0x1ADE7A0 Offset: 0x1ADCDA0 VA: 0x181ADE7A0
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0x1ADD990 Offset: 0x1ADBF90 VA: 0x181ADD990
	internal bool get_HasPropertyChanged() { }

	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0
	internal int get_RBTreeNodeId() { }

	// RVA: 0x1ADE7B0 Offset: 0x1ADCDB0 VA: 0x181ADE7B0
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0x1ADDBA0 Offset: 0x1ADC1A0 VA: 0x181ADDBA0
	public string get_RowError() { }

	// RVA: 0x1ADE860 Offset: 0x1ADCE60 VA: 0x181ADE860
	public void set_RowError(string value) { }

	// RVA: 0x1ADC960 Offset: 0x1ADAF60 VA: 0x181ADC960
	private void RowErrorChanged() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal long get_rowID() { }

	// RVA: 0x1ADEA30 Offset: 0x1ADD030 VA: 0x181ADEA30
	internal void set_rowID(long value) { }

	// RVA: 0x1ADDBD0 Offset: 0x1ADC1D0 VA: 0x181ADDBD0
	public DataRowState get_RowState() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public DataTable get_Table() { }

	// RVA: 0x1ADA860 Offset: 0x1AD8E60 VA: 0x181ADA860
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0x1ADB8A0 Offset: 0x1AD9EA0 VA: 0x181ADB8A0
	internal int GetNestedParentCount() { }

	// RVA: 0x1ADE250 Offset: 0x1ADC850 VA: 0x181ADE250
	public void set_Item(string columnName, object value) { }

	// RVA: 0x1ADDA80 Offset: 0x1ADC080 VA: 0x181ADDA80
	public object get_Item(DataColumn column) { }

	// RVA: 0x1ADE2F0 Offset: 0x1ADC8F0 VA: 0x181ADE2F0
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0x1ADD9A0 Offset: 0x1ADBFA0 VA: 0x181ADD9A0
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0x1ADDD80 Offset: 0x1ADC380 VA: 0x181ADDD80
	public void set_ItemArray(object[] value) { }

	// RVA: 0x1ADA370 Offset: 0x1AD8970 VA: 0x181ADA370
	public void AcceptChanges() { }

	[EditorBrowsable(2)]
	// RVA: 0x1ADA720 Offset: 0x1AD8D20 VA: 0x181ADA720
	public void BeginEdit() { }

	// RVA: 0x1ADA640 Offset: 0x1AD8C40 VA: 0x181ADA640
	private bool BeginEditInternal() { }

	[EditorBrowsable(2)]
	// RVA: 0x1ADA730 Offset: 0x1AD8D30 VA: 0x181ADA730
	public void CancelEdit() { }

	// RVA: 0x1ADA7A0 Offset: 0x1AD8DA0 VA: 0x181ADA7A0
	private void CheckColumn(DataColumn column) { }

	// RVA: 0x1ADA960 Offset: 0x1AD8F60 VA: 0x181ADA960
	internal void CheckInTable() { }

	// RVA: 0x1ADAF10 Offset: 0x1AD9510 VA: 0x181ADAF10
	public void Delete() { }

	[EditorBrowsable(2)]
	// RVA: 0x1ADAF80 Offset: 0x1AD9580 VA: 0x181ADAF80
	public void EndEdit() { }

	// RVA: 0x1ADCCB0 Offset: 0x1ADB2B0 VA: 0x181ADCCB0
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0x1ADC9B0 Offset: 0x1ADAFB0 VA: 0x181ADC9B0
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x1ADB310 Offset: 0x1AD9910 VA: 0x181ADB310
	public string GetColumnError(DataColumn column) { }

	// RVA: 0x1ADAAA0 Offset: 0x1AD90A0 VA: 0x181ADAAA0
	public void ClearErrors() { }

	// RVA: 0x1ADA9A0 Offset: 0x1AD8FA0 VA: 0x181ADA9A0
	internal void ClearError(DataColumn column) { }

	// RVA: 0x1ADD950 Offset: 0x1ADBF50 VA: 0x181ADD950
	public bool get_HasErrors() { }

	// RVA: 0x1ADB570 Offset: 0x1AD9B70 VA: 0x181ADB570
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0x1ADB060 Offset: 0x1AD9660 VA: 0x181ADB060
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0x1ADB070 Offset: 0x1AD9670 VA: 0x181ADB070
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x1ADB6E0 Offset: 0x1AD9CE0 VA: 0x181ADB6E0
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0x1ADBC00 Offset: 0x1ADA200 VA: 0x181ADBC00
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0x1ADBA80 Offset: 0x1ADA080 VA: 0x181ADBA80
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x1ADB970 Offset: 0x1AD9F70 VA: 0x181ADB970
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0x1ADBEB0 Offset: 0x1ADA4B0 VA: 0x181ADBEB0
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0x1ADBC10 Offset: 0x1ADA210 VA: 0x181ADBC10
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x1ADB520 Offset: 0x1AD9B20 VA: 0x181ADB520
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0x1ADB4C0 Offset: 0x1AD9AC0 VA: 0x181ADB4C0
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0x1ADB7F0 Offset: 0x1AD9DF0 VA: 0x181ADB7F0
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0x1ADB870 Offset: 0x1AD9E70 VA: 0x181ADB870
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0x1ADB6A0 Offset: 0x1AD9CA0 VA: 0x181ADB6A0
	internal int GetCurrentRecordNo() { }

	// RVA: 0x1ADB760 Offset: 0x1AD9D60 VA: 0x181ADB760
	internal int GetDefaultRecord() { }

	// RVA: 0x1ADBA40 Offset: 0x1ADA040 VA: 0x181ADBA40
	internal int GetOriginalRecordNo() { }

	// RVA: 0x1ADBEC0 Offset: 0x1ADA4C0 VA: 0x181ADBEC0
	private int GetProposedRecordNo() { }

	// RVA: 0x1ADBF00 Offset: 0x1ADA500 VA: 0x181ADBF00
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0x1ADB7C0 Offset: 0x1AD9DC0 VA: 0x181ADB7C0
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0x1ADBFF0 Offset: 0x1ADA5F0 VA: 0x181ADBFF0
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0x1ADC040 Offset: 0x1ADA640 VA: 0x181ADC040
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0x1ADC070 Offset: 0x1ADA670 VA: 0x181ADC070
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x1ADC110 Offset: 0x1ADA710 VA: 0x181ADC110
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0x1ADC1A0 Offset: 0x1ADA7A0 VA: 0x181ADC1A0
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0x1ADC1D0 Offset: 0x1ADA7D0 VA: 0x181ADC1D0
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x1ADC450 Offset: 0x1ADAA50 VA: 0x181ADC450
	public void RejectChanges() { }

	// RVA: 0x1ADC930 Offset: 0x1ADAF30 VA: 0x181ADC930
	internal void ResetLastChangedColumn() { }

	// RVA: 0x1ADCD30 Offset: 0x1ADB330 VA: 0x181ADCD30
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0x1ADCE50 Offset: 0x1ADB450 VA: 0x181ADCE50
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0x1ADD2E0 Offset: 0x1ADB8E0 VA: 0x181ADD2E0
	internal void SetParentRowToDBNull() { }

	// RVA: 0x1ADD6E0 Offset: 0x1ADBCE0 VA: 0x181ADD6E0
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0x1ADAB70 Offset: 0x1AD9170 VA: 0x181ADAB70
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }
}

// Namespace: System.Data
public sealed class DataRowBuilder // TypeDefIndex: 8664
{
	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xC05940 Offset: 0xC03F40 VA: 0x180C05940
	internal void .ctor(DataTable table, int record) { }
}

// Namespace: System.Data
[Flags]
public enum DataRowAction // TypeDefIndex: 8665
{
	// Fields
	public int value__; // 0x0
	public const DataRowAction Nothing = 0;
	public const DataRowAction Delete = 1;
	public const DataRowAction Change = 2;
	public const DataRowAction Rollback = 4;
	public const DataRowAction Commit = 8;
	public const DataRowAction Add = 16;
	public const DataRowAction ChangeOriginal = 32;
	public const DataRowAction ChangeCurrentAndOriginal = 64;
}

// Namespace: System.Data
public class DataRowChangeEventArgs : EventArgs // TypeDefIndex: 8666
{
	// Fields
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly DataRowAction <Action>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1AD90D0 Offset: 0x1AD76D0 VA: 0x181AD90D0
	public void .ctor(DataRow row, DataRowAction action) { }
}

// Namespace: System.Data
public sealed class DataRowChangeEventHandler : MulticastDelegate // TypeDefIndex: 8667
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 8669
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataRowCollection.DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

	// Properties
	public override int Count { get; }
	public DataRow Item { get; }

	// Methods

	// RVA: 0x1AD97E0 Offset: 0x1AD7DE0 VA: 0x181AD97E0
	internal void .ctor(DataTable table) { }

	// RVA: 0x1AD98B0 Offset: 0x1AD7EB0 VA: 0x181AD98B0 Slot: 9
	public override int get_Count() { }

	// RVA: 0x1AD9900 Offset: 0x1AD7F00 VA: 0x181AD9900
	public DataRow get_Item(int index) { }

	// RVA: 0x1AD91D0 Offset: 0x1AD77D0 VA: 0x181AD91D0
	public void Add(DataRow row) { }

	// RVA: 0x1AD94C0 Offset: 0x1AD7AC0 VA: 0x181AD94C0
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0x1AD9750 Offset: 0x1AD7D50 VA: 0x181AD9750
	public int IndexOf(DataRow row) { }

	// RVA: 0x1AD9150 Offset: 0x1AD7750 VA: 0x181AD9150
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0x1AD9200 Offset: 0x1AD7800 VA: 0x181AD9200
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0x1AD92C0 Offset: 0x1AD78C0 VA: 0x181AD92C0
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0x1AD9270 Offset: 0x1AD7870 VA: 0x181AD9270
	internal void ArrayClear() { }

	// RVA: 0x1AD9340 Offset: 0x1AD7940 VA: 0x181AD9340
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0x1AD9450 Offset: 0x1AD7A50 VA: 0x181AD9450 Slot: 10
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0x1AD93E0 Offset: 0x1AD79E0 VA: 0x181AD93E0
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0x1AD9700 Offset: 0x1AD7D00 VA: 0x181AD9700 Slot: 11
	public override IEnumerator GetEnumerator() { }
}

// Namespace: System.Data
internal sealed class DataRowCreatedEventHandler : MulticastDelegate // TypeDefIndex: 8670
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, DataRow r) { }
}

// Namespace: System.Data
internal sealed class DataSetClearEventhandler : MulticastDelegate // TypeDefIndex: 8671
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, DataTable table) { }
}

// Namespace: System.Data
[Flags]
public enum DataRowState // TypeDefIndex: 8672
{
	// Fields
	public int value__; // 0x0
	public const DataRowState Detached = 1;
	public const DataRowState Unchanged = 2;
	public const DataRowState Added = 4;
	public const DataRowState Deleted = 8;
	public const DataRowState Modified = 16;
}

// Namespace: System.Data
public enum DataRowVersion // TypeDefIndex: 8673
{
	// Fields
	public int value__; // 0x0
	public const DataRowVersion Original = 256;
	public const DataRowVersion Current = 512;
	public const DataRowVersion Proposed = 1024;
	public const DataRowVersion Default = 1536;
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataRowView : ICustomTypeDescriptor, INotifyPropertyChanged // TypeDefIndex: 8674
{
	// Fields
	private readonly DataView _dataView; // 0x10
	private readonly DataRow _row; // 0x18
	private bool _delayBeginEdit; // 0x20
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x28

	// Properties
	public DataView DataView { get; }
	private DataRowVersion RowVersionDefault { get; }
	public DataRow Row { get; }
	public bool IsNew { get; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0x58EA50 Offset: 0x58D050 VA: 0x18058EA50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1AD9DB0 Offset: 0x1AD83B0 VA: 0x181AD9DB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public DataView get_DataView() { }

	// RVA: 0x1ADA310 Offset: 0x1AD8910 VA: 0x181ADA310
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0x1AD9DE0 Offset: 0x1AD83E0 VA: 0x181AD9DE0
	internal int GetRecord() { }

	// RVA: 0x1AD9E60 Offset: 0x1AD8460 VA: 0x181AD9E60
	internal bool HasRecord() { }

	// RVA: 0x1AD9C90 Offset: 0x1AD8290 VA: 0x181AD9C90
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0x1AD9F70 Offset: 0x1AD8570 VA: 0x181AD9F70
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0x1AD9A00 Offset: 0x1AD8000 VA: 0x181AD9A00
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0x1AD9C20 Offset: 0x1AD8220 VA: 0x181AD9C20
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public DataRow get_Row() { }

	// RVA: 0x1AD9C30 Offset: 0x1AD8230 VA: 0x181AD9C30 Slot: 16
	public void EndEdit() { }

	// RVA: 0x1ADA2E0 Offset: 0x1AD88E0 VA: 0x181ADA2E0
	public bool get_IsNew() { }

	// RVA: 0x1AD9EE0 Offset: 0x1AD84E0 VA: 0x181AD9EE0
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0x1ADA030 Offset: 0x1AD8630 VA: 0x181ADA030 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 9
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 10
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1ADA080 Offset: 0x1AD8680 VA: 0x181ADA080 Slot: 11
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1ADA0D0 Offset: 0x1AD86D0 VA: 0x181ADA0D0 Slot: 12
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1ADA1B0 Offset: 0x1AD87B0 VA: 0x181ADA1B0 Slot: 13
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1ADA120 Offset: 0x1AD8720 VA: 0x181ADA120 Slot: 14
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 15
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x1ADA260 Offset: 0x1AD8860 VA: 0x181ADA260
	private static void .cctor() { }
}

// Namespace: System.Data
public enum SerializationFormat // TypeDefIndex: 8675
{
	// Fields
	public int value__; // 0x0
	public const SerializationFormat Xml = 0;
	public const SerializationFormat Binary = 1;
}

// Namespace: System.Data
public enum DataSetDateTime // TypeDefIndex: 8676
{
	// Fields
	public int value__; // 0x0
	public const DataSetDateTime Local = 1;
	public const DataSetDateTime Unspecified = 2;
	public const DataSetDateTime UnspecifiedLocal = 3;
	public const DataSetDateTime Utc = 4;
}

// Namespace: System.Data
public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 8677
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1ADF810 Offset: 0x1ADDE10 VA: 0x181ADF810
	public void .ctor(DataTable dataTable) { }
}

// Namespace: System.Data
public sealed class DataTableClearEventHandler : MulticastDelegate // TypeDefIndex: 8678
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }
}

// Namespace: System.Data
[DefaultMember("Item")]
[DefaultEvent("CollectionChanged")]
[ListBindable(False)]
public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 8679
{
	// Fields
	private readonly DataSet _dataSet; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataTable[] _delayedAddRangeTables; // 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x40

	// Properties
	protected override ArrayList List { get; }
	internal int ObjectID { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }

	// Methods

	// RVA: 0x1AE20E0 Offset: 0x1AE06E0 VA: 0x181AE20E0
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	internal int get_ObjectID() { }

	// RVA: 0x1AE2360 Offset: 0x1AE0960 VA: 0x181AE2360
	public DataTable get_Item(int index) { }

	// RVA: 0x1AE2240 Offset: 0x1AE0840 VA: 0x181AE2240
	public DataTable get_Item(string name) { }

	// RVA: 0x1AE2440 Offset: 0x1AE0A40 VA: 0x181AE2440
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0x1AE1120 Offset: 0x1ADF720 VA: 0x181AE1120
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0x1AE0FC0 Offset: 0x1ADF5C0 VA: 0x181AE0FC0
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0x1ADF880 Offset: 0x1ADDE80 VA: 0x181ADF880
	public void Add(DataTable table) { }

	// RVA: 0x1ADFB10 Offset: 0x1ADE110 VA: 0x181ADFB10
	private void ArrayAdd(DataTable table) { }

	// RVA: 0x1ADFB40 Offset: 0x1ADE140 VA: 0x181ADFB40
	internal string AssignName() { }

	// RVA: 0x1ADFC10 Offset: 0x1ADE210 VA: 0x181ADFC10
	private void BaseAdd(DataTable table) { }

	// RVA: 0x1ADFE60 Offset: 0x1ADE460 VA: 0x181ADFE60
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0x1ADFFF0 Offset: 0x1ADE5F0 VA: 0x181ADFFF0
	private void BaseRemove(DataTable table) { }

	// RVA: 0x1AE0170 Offset: 0x1ADE770 VA: 0x181AE0170
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0x1AE0930 Offset: 0x1ADEF30 VA: 0x181AE0930
	public void Clear() { }

	// RVA: 0x1AE0DD0 Offset: 0x1ADF3D0 VA: 0x181AE0DD0
	public bool Contains(string name) { }

	// RVA: 0x1AE0DF0 Offset: 0x1ADF3F0 VA: 0x181AE0DF0
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0x1AE0C60 Offset: 0x1ADF260 VA: 0x181AE0C60
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1AE1310 Offset: 0x1ADF910 VA: 0x181AE1310
	public int IndexOf(DataTable table) { }

	// RVA: 0x1AE1260 Offset: 0x1ADF860 VA: 0x181AE1260
	public int IndexOf(string tableName) { }

	// RVA: 0x1AE1280 Offset: 0x1ADF880 VA: 0x181AE1280
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0x1AE1F70 Offset: 0x1AE0570 VA: 0x181AE1F70
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	// RVA: 0x1AE1410 Offset: 0x1ADFA10 VA: 0x181AE1410
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0x1AE16A0 Offset: 0x1ADFCA0 VA: 0x181AE16A0
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0x1AE18D0 Offset: 0x1ADFED0 VA: 0x181AE18D0
	private string MakeName(int index) { }

	// RVA: 0x1AE1970 Offset: 0x1ADFF70 VA: 0x181AE1970
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1AE1A30 Offset: 0x1AE0030 VA: 0x181AE1A30
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1AE1AF0 Offset: 0x1AE00F0 VA: 0x181AE1AF0
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0x1AE1D80 Offset: 0x1AE0380 VA: 0x181AE1D80
	public void Remove(DataTable table) { }

	// RVA: 0x1AE1FD0 Offset: 0x1AE05D0 VA: 0x181AE1FD0
	internal void UnregisterName(string name) { }
}

// Namespace: System.Data
public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 8680
{
	// Fields
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1AEE580 Offset: 0x1AECB80 VA: 0x181AEE580
	public void .ctor(DataRow dataRow) { }
}

// Namespace: System.Data
public sealed class DataTableNewRowEventHandler : MulticastDelegate // TypeDefIndex: 8681
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }
}

// Namespace: System.Data
internal sealed class DataTablePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 8682
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x88

	// Properties
	public DataTable Table { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	public DataTable get_Table() { }

	// RVA: 0x1AEE710 Offset: 0x1AECD10 VA: 0x181AEE710 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1AEE760 Offset: 0x1AECD60 VA: 0x181AEE760 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x1AEE5F0 Offset: 0x1AECBF0 VA: 0x181AEE5F0 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: System.Data
internal sealed class DataTableTypeConverter : ReferenceConverter // TypeDefIndex: 8683
{
	// Methods

	// RVA: 0x1AEE7B0 Offset: 0x1AECDB0 VA: 0x181AEE7B0
	public void .ctor() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
[DefaultEvent("PositionChanged")]
[DefaultProperty("Table")]
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList // TypeDefIndex: 8685
{
	// Fields
	private DataViewManager _dataViewManager; // 0x20
	private DataTable _table; // 0x28
	private bool _locked; // 0x30
	private Index _index; // 0x38
	private Dictionary<string, Index> _findIndexes; // 0x40
	private string _sort; // 0x48
	private Comparison<DataRow> _comparison; // 0x50
	private IFilter _rowFilter; // 0x58
	private DataViewRowState _recordStates; // 0x60
	private bool _shouldOpen; // 0x64
	private bool _open; // 0x65
	private bool _allowNew; // 0x66
	private bool _allowEdit; // 0x67
	private bool _allowDelete; // 0x68
	private bool _applyDefaultSort; // 0x69
	internal DataRow _addNewRow; // 0x70
	private ListChangedEventArgs _addNewMoved; // 0x78
	private ListChangedEventHandler _onListChanged; // 0x80
	internal static ListChangedEventArgs s_resetEventArgs; // 0x0
	private string _delayedSort; // 0x88
	private DataViewRowState _delayedRecordStates; // 0x90
	private bool _fInitInProgress; // 0x94
	private bool _fEndInitInProgress; // 0x95
	private Dictionary<DataRow, DataRowView> _rowViewCache; // 0x98
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; // 0xA0
	private DataViewListener _dvListener; // 0xA8
	private static int s_objectTypeCount; // 0x8
	private readonly int _objectID; // 0xB0

	// Properties
	[DefaultValue(True)]
	public bool AllowDelete { get; }
	[DefaultValue(True)]
	public bool AllowEdit { get; }
	[DefaultValue(True)]
	public bool AllowNew { get; }
	[Browsable(False)]
	public int Count { get; }
	private int CountFromIndex { get; }
	[Browsable(False)]
	public DataViewManager DataViewManager { get; }
	[Browsable(False)]
	protected bool IsOpen { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	[DefaultValue(22)]
	public DataViewRowState RowStateFilter { get; }
	[DefaultValue("")]
	public string Sort { get; set; }
	internal Comparison<DataRow> SortComparison { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	[DefaultValue(null)]
	[RefreshProperties(1)]
	[TypeConverter(typeof(DataTableTypeConverter))]
	public DataTable Table { get; }
	private object System.Collections.IList.Item { get; set; }
	public DataRowView Item { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1AF3510 Offset: 0x1AF1B10 VA: 0x181AF3510
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0x1AF3850 Offset: 0x1AF1E50 VA: 0x181AF3850
	public void .ctor(DataTable table) { }

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	public bool get_AllowDelete() { }

	// RVA: 0x1AF2E20 Offset: 0x1AF1420 VA: 0x181AF2E20
	public bool get_AllowEdit() { }

	// RVA: 0x1AF2E30 Offset: 0x1AF1430 VA: 0x181AF2E30
	public bool get_AllowNew() { }

	// RVA: 0x1AF38F0 Offset: 0x1AF1EF0 VA: 0x181AF38F0 Slot: 37
	public int get_Count() { }

	// RVA: 0x1AF38C0 Offset: 0x1AF1EC0 VA: 0x181AF38C0
	private int get_CountFromIndex() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public DataViewManager get_DataViewManager() { }

	// RVA: 0x1AF3940 Offset: 0x1AF1F40 VA: 0x181AF3940
	protected bool get_IsOpen() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 39
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3848A0 Offset: 0x382EA0 VA: 0x1803848A0
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x1AF3950 Offset: 0x1AF1F50 VA: 0x181AF3950
	public string get_Sort() { }

	// RVA: 0x1AF39B0 Offset: 0x1AF1FB0 VA: 0x181AF39B0
	public void set_Sort(string value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal Comparison<DataRow> get_SortComparison() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 38
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public DataTable get_Table() { }

	// RVA: 0x1AF2860 Offset: 0x1AF0E60 VA: 0x181AF2860 Slot: 25
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0x1AF28C0 Offset: 0x1AF0EC0 VA: 0x181AF28C0 Slot: 26
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0x1AF2860 Offset: 0x1AF0E60 VA: 0x181AF2860
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0x1AEFAC0 Offset: 0x1AEE0C0 VA: 0x181AEFAC0 Slot: 43
	public virtual DataRowView AddNew() { }

	// RVA: 0x1AEFDB0 Offset: 0x1AEE3B0 VA: 0x181AEFDB0
	private void CheckOpen() { }

	// RVA: 0x1AEFDF0 Offset: 0x1AEE3F0 VA: 0x181AEFDF0
	private void CheckSort(string sort) { }

	// RVA: 0x1AF00A0 Offset: 0x1AEE6A0 VA: 0x181AF00A0
	protected void Close() { }

	// RVA: 0x1AF0350 Offset: 0x1AEE950 VA: 0x181AF0350 Slot: 36
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1AF04B0 Offset: 0x1AEEAB0 VA: 0x181AF04B0
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0x1AF09C0 Offset: 0x1AEEFC0 VA: 0x181AF09C0
	public void Delete(int index) { }

	// RVA: 0x1AF07A0 Offset: 0x1AEEDA0 VA: 0x181AF07A0
	internal void Delete(DataRow row) { }

	// RVA: 0x1AF09F0 Offset: 0x1AEEFF0 VA: 0x181AF09F0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AF0A50 Offset: 0x1AEF050 VA: 0x181AF0A50
	internal void FinishAddNew(bool success) { }

	// RVA: 0x1AF0C40 Offset: 0x1AEF240 VA: 0x181AF0C40 Slot: 40
	public IEnumerator GetEnumerator() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 30
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 31
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1AF2520 Offset: 0x1AF0B20 VA: 0x181AF2520 Slot: 27
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1AF25B0 Offset: 0x1AF0BB0 VA: 0x181AF25B0 Slot: 29
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1AF25E0 Offset: 0x1AF0BE0 VA: 0x181AF25E0 Slot: 28
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1AF2670 Offset: 0x1AF0C70 VA: 0x181AF2670 Slot: 32
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1AF13E0 Offset: 0x1AEF9E0 VA: 0x181AF13E0
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0x1AF1380 Offset: 0x1AEF980 VA: 0x181AF1380
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0x1AF2700 Offset: 0x1AF0D00 VA: 0x181AF2700 Slot: 33
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1AF2730 Offset: 0x1AF0D30 VA: 0x181AF2730 Slot: 34
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1AF09C0 Offset: 0x1AEEFC0 VA: 0x181AF09C0 Slot: 35
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1AF0CE0 Offset: 0x1AEF2E0 VA: 0x181AF0CE0
	internal Index GetFindIndex(string column, bool keepIndex) { }

	// RVA: 0x1AF2E30 Offset: 0x1AF1430 VA: 0x181AF2E30 Slot: 10
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x1AF2940 Offset: 0x1AF0F40 VA: 0x181AF2940 Slot: 11
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x1AF2E20 Offset: 0x1AF1420 VA: 0x181AF2E20 Slot: 12
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950 Slot: 13
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 14
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 15
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 16
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x1AF2E40 Offset: 0x1AF1440 VA: 0x181AF2E40 Slot: 17
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x1AF2EE0 Offset: 0x1AF14E0 VA: 0x181AF2EE0 Slot: 18
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x1AF11A0 Offset: 0x1AEF7A0 VA: 0x181AF11A0
	internal PropertyDescriptor GetSortProperty() { }

	// RVA: 0x1AF2EA0 Offset: 0x1AF14A0 VA: 0x181AF2EA0 Slot: 19
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0x1AF28F0 Offset: 0x1AF0EF0 VA: 0x181AF28F0 Slot: 20
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0x1AF2960 Offset: 0x1AF0F60 VA: 0x181AF2960 Slot: 21
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x1AF2A70 Offset: 0x1AF1070 VA: 0x181AF2A70 Slot: 22
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0x1AF2D20 Offset: 0x1AF1320 VA: 0x181AF2D20 Slot: 23
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x1AF2D70 Offset: 0x1AF1370 VA: 0x181AF2D70 Slot: 24
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x1AF06B0 Offset: 0x1AEECB0 VA: 0x181AF06B0
	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x1AF3040 Offset: 0x1AF1640 VA: 0x181AF3040 Slot: 41
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x1AF2F70 Offset: 0x1AF1570 VA: 0x181AF2F70 Slot: 42
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 44
	internal virtual IFilter GetFilter() { }

	// RVA: 0x1AF0EA0 Offset: 0x1AEF4A0 VA: 0x181AF0EA0
	private int GetRecord(int recordIndex) { }

	// RVA: 0x1AF1040 Offset: 0x1AEF640 VA: 0x181AF1040
	internal DataRow GetRow(int index) { }

	// RVA: 0x1AF0FC0 Offset: 0x1AEF5C0 VA: 0x181AF0FC0
	private DataRowView GetRowView(int record) { }

	// RVA: 0x1AF0F60 Offset: 0x1AEF560 VA: 0x181AF0F60
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0x1AF1300 Offset: 0x1AEF900 VA: 0x181AF1300 Slot: 45
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0x1AF1230 Offset: 0x1AEF830 VA: 0x181AF1230
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0x1AF1530 Offset: 0x1AEFB30 VA: 0x181AF1530
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x1AF1820 Offset: 0x1AEFE20 VA: 0x181AF1820 Slot: 46
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1AF2050 Offset: 0x1AF0650 VA: 0x181AF2050
	protected void Reset() { }

	// RVA: 0x1AF1DD0 Offset: 0x1AF03D0 VA: 0x181AF1DD0
	internal void ResetRowViewCache() { }

	// RVA: 0x1AF2080 Offset: 0x1AF0680 VA: 0x181AF2080
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x1AF2500 Offset: 0x1AF0B00 VA: 0x181AF2500 Slot: 47
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0x1AF22C0 Offset: 0x1AF08C0 VA: 0x181AF22C0
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0x1AF3460 Offset: 0x1AF1A60 VA: 0x181AF3460
	protected void UpdateIndex() { }

	// RVA: 0x1AF3480 Offset: 0x1AF1A80 VA: 0x181AF3480 Slot: 48
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0x1AF30C0 Offset: 0x1AF16C0 VA: 0x181AF30C0
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0x1AEFE50 Offset: 0x1AEE450 VA: 0x181AEFE50
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1AF1B80 Offset: 0x1AF0180 VA: 0x181AF1B80
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1AF0100 Offset: 0x1AEE700 VA: 0x181AF0100 Slot: 49
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1AF00E0 Offset: 0x1AEE6E0 VA: 0x181AF00E0
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x3A35F0 Offset: 0x3A1BF0 VA: 0x1803A35F0
	internal int get_ObjectID() { }

	// RVA: 0x1AF3490 Offset: 0x1AF1A90 VA: 0x181AF3490
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class DataViewListener // TypeDefIndex: 8686
{
	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0x1AEF600 Offset: 0x1AEDC00 VA: 0x181AEF600
	internal void .ctor(DataView dv) { }

	// RVA: 0x1AEE840 Offset: 0x1AECE40 VA: 0x181AEE840
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1AEECA0 Offset: 0x1AED2A0 VA: 0x181AEECA0
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1AEE940 Offset: 0x1AECF40 VA: 0x181AEE940
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1AEEBB0 Offset: 0x1AED1B0 VA: 0x181AEEBB0
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x1AEEA30 Offset: 0x1AED030 VA: 0x181AEEA30
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1AEF040 Offset: 0x1AED640 VA: 0x181AEF040
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0x1AEF5F0 Offset: 0x1AEDBF0 VA: 0x181AEF5F0
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0x1AEF340 Offset: 0x1AED940 VA: 0x181AEF340
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0x1AEED80 Offset: 0x1AED380 VA: 0x181AEED80
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0x1AEF260 Offset: 0x1AED860 VA: 0x181AEF260
	internal void UnregisterListChangedEvent() { }

	// RVA: 0x1AEE920 Offset: 0x1AECF20 VA: 0x181AEE920
	private void CleanUp(bool updateListeners) { }

	// RVA: 0x1AEEE40 Offset: 0x1AED440 VA: 0x181AEEE40
	private void RegisterListener(DataTable table) { }
}

// Namespace: System.Data
public class DataViewManager : MarshalByValueComponent // TypeDefIndex: 8687
{
	// Fields
	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	internal int _nViews; // 0x28
	private static NotSupportedException s_notSupported; // 0x0

	// Properties
	[DesignerSerializationVisibility(2)]
	public DataViewSettingCollection DataViewSettings { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0x1AEF750 Offset: 0x1AEDD50 VA: 0x181AEF750
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class DataViewManagerListItemTypeDescriptor // TypeDefIndex: 8688
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10

	// Methods

	// RVA: 0x1AEF690 Offset: 0x1AEDC90 VA: 0x181AEF690
	internal DataView GetDataView(DataTable table) { }
}

// Namespace: System.Data
[Flags]
public enum DataViewRowState // TypeDefIndex: 8689
{
	// Fields
	public int value__; // 0x0
	public const DataViewRowState None = 0;
	public const DataViewRowState Unchanged = 2;
	public const DataViewRowState Added = 4;
	public const DataViewRowState Deleted = 8;
	public const DataViewRowState ModifiedCurrent = 16;
	public const DataViewRowState ModifiedOriginal = 32;
	public const DataViewRowState OriginalRows = 42;
	public const DataViewRowState CurrentRows = 22;
}

// Namespace: System.Data
[TypeConverter(typeof(ExpandableObjectConverter))]
public class DataViewSetting // TypeDefIndex: 8690
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private DataTable _table; // 0x18
	private string _sort; // 0x20
	private string _rowFilter; // 0x28
	private DataViewRowState _rowStateFilter; // 0x30
	private bool _applyDefaultSort; // 0x34

	// Properties
	public bool ApplyDefaultSort { get; }
	public string RowFilter { get; }
	public DataViewRowState RowStateFilter { get; }
	public string Sort { get; }

	// Methods

	// RVA: 0x1AEFA60 Offset: 0x1AEE060 VA: 0x181AEFA60
	internal void .ctor() { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_ApplyDefaultSort() { }

	// RVA: 0x1AD74C0 Offset: 0x1AD5AC0 VA: 0x181AD74C0
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x1AEFA40 Offset: 0x1AEE040 VA: 0x181AEFA40
	internal void SetDataTable(DataTable table) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_RowFilter() { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Sort() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataViewSettingCollection // TypeDefIndex: 8691
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Properties
	public virtual DataViewSetting Item { get; set; }

	// Methods

	// RVA: 0x1AEF800 Offset: 0x1AEDE00 VA: 0x181AEF800 Slot: 4
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0x1AEF980 Offset: 0x1AEDF80 VA: 0x181AEF980 Slot: 5
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0x1AEF7D0 Offset: 0x1AEDDD0 VA: 0x181AEF7D0
	internal void Remove(DataTable table) { }
}

// Namespace: System.Data
internal sealed class DefaultValueTypeConverter : StringConverter // TypeDefIndex: 8692
{
	// Methods

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }

	// RVA: 0x1AF3CE0 Offset: 0x1AF22E0 VA: 0x181AF3CE0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1AF3B80 Offset: 0x1AF2180 VA: 0x181AF3B80 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }
}

// Namespace: System.Data
internal enum Aggregate // TypeDefIndex: 8693
{
	// Fields
	public int value__; // 0x0
	public const Aggregate None = -1;
	public const Aggregate Sum = 30;
	public const Aggregate Avg = 31;
	public const Aggregate Min = 32;
	public const Aggregate Max = 33;
	public const Aggregate Count = 34;
	public const Aggregate StDev = 35;
	public const Aggregate Var = 37;
}

// Namespace: System.Data
internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 8694
{
	// Fields
	private readonly AggregateType _type; // 0x18
	private readonly Aggregate _aggregate; // 0x1C
	private readonly bool _local; // 0x20
	private readonly string _relationName; // 0x28
	private readonly string _columnName; // 0x30
	private DataTable _childTable; // 0x38
	private DataColumn _column; // 0x40
	private DataRelation _relation; // 0x48

	// Methods

	// RVA: 0x1AE5EA0 Offset: 0x1AE44A0 VA: 0x181AE5EA0
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0x1AE5D60 Offset: 0x1AE4360 VA: 0x181AE5D60
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0x1AE53E0 Offset: 0x1AE39E0 VA: 0x181AE53E0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1AE57B0 Offset: 0x1AE3DB0 VA: 0x181AE57B0
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	// RVA: 0x1AC7760 Offset: 0x1AC5D60 VA: 0x181AC7760 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1AE5A20 Offset: 0x1AE4020 VA: 0x181AE5A20 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1AE5980 Offset: 0x1AE3F80 VA: 0x181AE5980 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1AE5D50 Offset: 0x1AE4350 VA: 0x181AE5D50 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1AE58F0 Offset: 0x1AE3EF0 VA: 0x181AE58F0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
internal class BinaryNode : ExpressionNode // TypeDefIndex: 8696
{
	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0x1AECF40 Offset: 0x1AEB540 VA: 0x181AECF40
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x1AE6DD0 Offset: 0x1AE53D0 VA: 0x181AE6DD0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1AC7760 Offset: 0x1AC5D60 VA: 0x181AC7760 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1AEBCF0 Offset: 0x1AEA2F0 VA: 0x181AEBCF0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1AEBC60 Offset: 0x1AEA260 VA: 0x181AEBC60 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1AEC0E0 Offset: 0x1AEA6E0 VA: 0x181AEC0E0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1AEC230 Offset: 0x1AEA830 VA: 0x181AEC230 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1AEC020 Offset: 0x1AEA620 VA: 0x181AEC020 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1AEC080 Offset: 0x1AEA680 VA: 0x181AEC080 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1AE6E50 Offset: 0x1AE5450 VA: 0x181AE6E50 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1AEC290 Offset: 0x1AEA890 VA: 0x181AEC290 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1AECE10 Offset: 0x1AEB410 VA: 0x181AECE10
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0x1AEBCA0 Offset: 0x1AEA2A0 VA: 0x181AEBCA0
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x1AE5EC0 Offset: 0x1AE44C0 VA: 0x181AE5EC0
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0x1AE5EF0 Offset: 0x1AE44F0 VA: 0x181AE5EF0
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0x1AE6EC0 Offset: 0x1AE54C0 VA: 0x181AE6EC0
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x1AEBE90 Offset: 0x1AEA490 VA: 0x181AEBE90
	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0x1AEBD20 Offset: 0x1AEA320 VA: 0x181AEBD20
	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	// RVA: 0x1AEC1C0 Offset: 0x1AEA7C0 VA: 0x181AEC1C0
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0x1AEC140 Offset: 0x1AEA740 VA: 0x181AEC140
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0x1AECAC0 Offset: 0x1AEB0C0 VA: 0x181AECAC0
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1AEC620 Offset: 0x1AEAC20 VA: 0x181AEC620
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1AECE50 Offset: 0x1AEB450 VA: 0x181AECE50
	private int SqlResultType(int typeCode) { }
}

// Namespace: System.Data
internal sealed class LikeNode : BinaryNode // TypeDefIndex: 8697
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0x1AECF40 Offset: 0x1AEB540 VA: 0x181AECF40
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x1AF9890 Offset: 0x1AF7E90 VA: 0x181AF9890 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1AF9560 Offset: 0x1AF7B60 VA: 0x181AF9560
	internal string AnalyzePattern(string pat) { }
}

// Namespace: System.Data
internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 8698
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0x1AED860 Offset: 0x1AEBE60 VA: 0x181AED860
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0x1AED510 Offset: 0x1AEBB10 VA: 0x181AED510
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 6
	internal override object Eval() { }

	// RVA: 0x53F9C0 Offset: 0x53DFC0 VA: 0x18053F9C0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x53F9C0 Offset: 0x53DFC0 VA: 0x18053F9C0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1AECFB0 Offset: 0x1AEB5B0 VA: 0x181AECFB0
	private object SmallestDecimal(object constant) { }

	// RVA: 0x1AED220 Offset: 0x1AEB820 VA: 0x181AED220
	private object SmallestNumeric(object constant) { }
}

// Namespace: System.Data
internal sealed class DataExpression : IFilter // TypeDefIndex: 8699
{
	// Fields
	internal string _originalExpression; // 0x10
	private bool _parsed; // 0x18
	private bool _bound; // 0x19
	private ExpressionNode _expr; // 0x20
	private DataTable _table; // 0x28
	private readonly StorageType _storageType; // 0x30
	private readonly Type _dataType; // 0x38
	private DataColumn[] _dependency; // 0x40

	// Properties
	internal string Expression { get; }
	internal bool HasValue { get; }

	// Methods

	// RVA: 0x1AEE070 Offset: 0x1AEC670 VA: 0x181AEE070
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0x1AEE090 Offset: 0x1AEC690 VA: 0x181AEE090
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0x1AEE4A0 Offset: 0x1AECAA0 VA: 0x181AEE4A0
	internal string get_Expression() { }

	// RVA: 0x1A33C90 Offset: 0x1A32290 VA: 0x181A33C90
	internal bool get_HasValue() { }

	// RVA: 0x1AED880 Offset: 0x1AEBE80 VA: 0x181AED880
	internal void Bind(DataTable table) { }

	// RVA: 0x1AED9B0 Offset: 0x1AEBFB0 VA: 0x181AED9B0
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0x1AEDBE0 Offset: 0x1AEC1E0 VA: 0x181AEDBE0
	internal object Evaluate() { }

	// RVA: 0x1AED9E0 Offset: 0x1AEBFE0 VA: 0x181AED9E0
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0x1AEDC50 Offset: 0x1AEC250 VA: 0x181AEDC50 Slot: 4
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal DataColumn[] GetDependency() { }

	// RVA: 0x1AEDD00 Offset: 0x1AEC300 VA: 0x181AEDD00
	internal bool IsTableAggregate() { }

	// RVA: 0x1AEDD30 Offset: 0x1AEC330 VA: 0x181AEDD30
	internal static bool IsUnknown(object value) { }

	// RVA: 0x1AEDBF0 Offset: 0x1AEC1F0 VA: 0x181AEDBF0
	internal bool HasLocalAggregate() { }

	// RVA: 0x1AEDC20 Offset: 0x1AEC220 VA: 0x181AEDC20
	internal bool HasRemoteAggregate() { }

	// RVA: 0x1AEDD80 Offset: 0x1AEC380 VA: 0x181AEDD80
	internal static bool ToBoolean(object value) { }
}

// Namespace: System.Data
internal abstract class ExpressionNode // TypeDefIndex: 8700
{
	// Fields
	private DataTable _table; // 0x10

	// Properties
	internal IFormatProvider FormatProvider { get; }
	internal virtual bool IsSqlColumn { get; }
	protected DataTable table { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	protected void .ctor(DataTable table) { }

	// RVA: 0x1AF5F90 Offset: 0x1AF4590 VA: 0x181AF5F90
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 4
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	protected DataTable get_table() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	protected void BindTable(DataTable table) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void Bind(DataTable table, List<DataColumn> list);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract object Eval();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract object Eval(DataRow row, DataRowVersion version);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract object Eval(int[] recordNos);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool IsConstant();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool IsTableConstant();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool HasLocalAggregate();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool HasRemoteAggregate();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract ExpressionNode Optimize();

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 14
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0x1AF5E60 Offset: 0x1AF4460 VA: 0x181AF5E60
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0x1AF5E40 Offset: 0x1AF4440 VA: 0x181AF5E40
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0x1AF5F30 Offset: 0x1AF4530 VA: 0x181AF5F30
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0x1AF5EF0 Offset: 0x1AF44F0 VA: 0x181AF5EF0
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0x1AF5F70 Offset: 0x1AF4570 VA: 0x181AF5F70
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0x1AF5F50 Offset: 0x1AF4550 VA: 0x181AF5F50
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0x1AF5EC0 Offset: 0x1AF44C0 VA: 0x181AF5EC0
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0x1AF5E80 Offset: 0x1AF4480 VA: 0x181AF5E80
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0x1AF5E20 Offset: 0x1AF4420 VA: 0x181AF5E20
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0x1AF5E00 Offset: 0x1AF4400 VA: 0x181AF5E00
	internal static bool IsFloatSql(StorageType type) { }
}

// Namespace: System.Data
internal enum ValueType // TypeDefIndex: 8701
{
	// Fields
	public int value__; // 0x0
	public const ValueType Unknown = -1;
	public const ValueType Null = 0;
	public const ValueType Bool = 1;
	public const ValueType Numeric = 2;
	public const ValueType Str = 3;
	public const ValueType Float = 4;
	public const ValueType Decimal = 5;
	public const ValueType Object = 6;
	public const ValueType Date = 7;
}

// Namespace: System.Data
internal enum Nodes // TypeDefIndex: 8702
{
	// Fields
	public int value__; // 0x0
	public const Nodes Noop = 0;
	public const Nodes Unop = 1;
	public const Nodes UnopSpec = 2;
	public const Nodes Binop = 3;
	public const Nodes BinopSpec = 4;
	public const Nodes Zop = 5;
	public const Nodes Call = 6;
	public const Nodes Const = 7;
	public const Nodes Name = 8;
	public const Nodes Paren = 9;
	public const Nodes Conv = 10;
}

// Namespace: System.Data
internal sealed class ExpressionParser // TypeDefIndex: 8704
{
	// Fields
	private static readonly ExpressionParser.ReservedWords[] s_reservedwords; // 0x0
	private char _escape; // 0x10
	private char _decimalSeparator; // 0x12
	private char _listSeparator; // 0x14
	private char _exponentL; // 0x16
	private char _exponentU; // 0x18
	internal char[] _text; // 0x20
	internal int _pos; // 0x28
	internal int _start; // 0x2C
	internal Tokens _token; // 0x30
	internal int _op; // 0x34
	internal OperatorInfo[] _ops; // 0x38
	internal int _topOperator; // 0x40
	internal int _topNode; // 0x44
	private readonly DataTable _table; // 0x48
	internal ExpressionNode[] _nodeStack; // 0x50
	internal int _prevOperand; // 0x58
	internal ExpressionNode _expression; // 0x60

	// Methods

	// RVA: 0x1AF94A0 Offset: 0x1AF7AA0 VA: 0x181AF94A0
	internal void .ctor(DataTable table) { }

	// RVA: 0x1AF6550 Offset: 0x1AF4B50 VA: 0x181AF6550
	internal void LoadExpression(string data) { }

	// RVA: 0x1AF8F80 Offset: 0x1AF7580 VA: 0x181AF8F80
	internal void StartScan() { }

	// RVA: 0x1AF6B50 Offset: 0x1AF5150 VA: 0x181AF6B50
	internal ExpressionNode Parse() { }

	// RVA: 0x1AF6770 Offset: 0x1AF4D70 VA: 0x181AF6770
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0x1AF6680 Offset: 0x1AF4C80 VA: 0x181AF6680
	private ExpressionNode NodePop() { }

	// RVA: 0x1AF6640 Offset: 0x1AF4C40 VA: 0x181AF6640
	private ExpressionNode NodePeek() { }

	// RVA: 0x1AF66C0 Offset: 0x1AF4CC0 VA: 0x181AF66C0
	private void NodePush(ExpressionNode node) { }

	// RVA: 0x1AF5FF0 Offset: 0x1AF45F0 VA: 0x181AF5FF0
	private void BuildExpression(int pri) { }

	// RVA: 0x1AF6380 Offset: 0x1AF4980 VA: 0x181AF6380
	internal void CheckToken(Tokens token) { }

	// RVA: 0x1AF8850 Offset: 0x1AF6E50 VA: 0x181AF8850
	internal Tokens Scan() { }

	// RVA: 0x1AF8240 Offset: 0x1AF6840 VA: 0x181AF8240
	private void ScanNumeric() { }

	// RVA: 0x1AF8030 Offset: 0x1AF6630 VA: 0x181AF8030
	private void ScanName() { }

	// RVA: 0x1AF8110 Offset: 0x1AF6710 VA: 0x181AF8110
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	// RVA: 0x1AF7F10 Offset: 0x1AF6510 VA: 0x181AF7F10
	private void ScanDate() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void ScanBinaryConstant() { }

	// RVA: 0x1AF8420 Offset: 0x1AF6A20 VA: 0x181AF8420
	private void ScanReserved() { }

	// RVA: 0x1AF86C0 Offset: 0x1AF6CC0 VA: 0x181AF86C0
	private void ScanString(char escape) { }

	// RVA: 0x1AF87A0 Offset: 0x1AF6DA0 VA: 0x181AF87A0
	internal void ScanToken(Tokens token) { }

	// RVA: 0x1AF8800 Offset: 0x1AF6E00 VA: 0x181AF8800
	private void ScanWhite() { }

	// RVA: 0x1AF6540 Offset: 0x1AF4B40 VA: 0x181AF6540
	private bool IsWhiteSpace(char ch) { }

	// RVA: 0x1AF63D0 Offset: 0x1AF49D0 VA: 0x181AF63D0
	private bool IsAlphaNumeric(char ch) { }

	// RVA: 0x1AF64F0 Offset: 0x1AF4AF0 VA: 0x181AF64F0
	private bool IsDigit(char ch) { }

	// RVA: 0x1AF6470 Offset: 0x1AF4A70 VA: 0x181AF6470
	private bool IsAlpha(char ch) { }

	// RVA: 0x1AF9020 Offset: 0x1AF7620 VA: 0x181AF9020
	private static void .cctor() { }
}

// Namespace: System.Data
internal enum Tokens // TypeDefIndex: 8705
{
	// Fields
	public int value__; // 0x0
	public const Tokens None = 0;
	public const Tokens Name = 1;
	public const Tokens Numeric = 2;
	public const Tokens Decimal = 3;
	public const Tokens Float = 4;
	public const Tokens BinaryConst = 5;
	public const Tokens StringConst = 6;
	public const Tokens Date = 7;
	public const Tokens ListSeparator = 8;
	public const Tokens LeftParen = 9;
	public const Tokens RightParen = 10;
	public const Tokens ZeroOp = 11;
	public const Tokens UnaryOp = 12;
	public const Tokens BinaryOp = 13;
	public const Tokens Child = 14;
	public const Tokens Parent = 15;
	public const Tokens Dot = 16;
	public const Tokens Unknown = 17;
	public const Tokens EOS = 18;
}

// Namespace: System.Data
internal sealed class OperatorInfo // TypeDefIndex: 8706
{
	// Fields
	internal Nodes _type; // 0x10
	internal int _op; // 0x14
	internal int _priority; // 0x18

	// Methods

	// RVA: 0x139BDD0 Offset: 0x139A3D0 VA: 0x18139BDD0
	internal void .ctor(Nodes type, int op, int pri) { }
}

// Namespace: System.Data
[Serializable]
public class InvalidExpressionException : DataException // TypeDefIndex: 8707
{
	// Methods

	// RVA: 0x14154C0 Offset: 0x1413AC0 VA: 0x1814154C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AF3E70 Offset: 0x1AF2470 VA: 0x181AF3E70
	public void .ctor() { }

	// RVA: 0x1AF3E80 Offset: 0x1AF2480 VA: 0x181AF3E80
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class EvaluateException : InvalidExpressionException // TypeDefIndex: 8708
{
	// Methods

	// RVA: 0x14154C0 Offset: 0x1413AC0 VA: 0x1814154C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AF3E70 Offset: 0x1AF2470 VA: 0x181AF3E70
	public void .ctor() { }

	// RVA: 0x1AF3E80 Offset: 0x1AF2480 VA: 0x181AF3E80
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class SyntaxErrorException : InvalidExpressionException // TypeDefIndex: 8709
{
	// Methods

	// RVA: 0x14154C0 Offset: 0x1413AC0 VA: 0x1814154C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AF3E70 Offset: 0x1AF2470 VA: 0x181AF3E70
	public void .ctor() { }

	// RVA: 0x1AF3E80 Offset: 0x1AF2480 VA: 0x181AF3E80
	public void .ctor(string s) { }
}

// Namespace: System.Data
internal sealed class ExprException // TypeDefIndex: 8710
{
	// Methods

	// RVA: 0x1AF5D40 Offset: 0x1AF4340 VA: 0x181AF5D40
	private static OverflowException _Overflow(string error) { }

	// RVA: 0x1AF5CE0 Offset: 0x1AF42E0 VA: 0x181AF5CE0
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0x1AF5DA0 Offset: 0x1AF43A0 VA: 0x181AF5DA0
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0x1AF5C80 Offset: 0x1AF4280 VA: 0x181AF5C80
	private static EvaluateException _Eval(string error) { }

	// RVA: 0x1AF5C20 Offset: 0x1AF4220 VA: 0x181AF5C20
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0x1AF4EF0 Offset: 0x1AF34F0 VA: 0x181AF4EF0
	public static Exception InvokeArgument() { }

	// RVA: 0x1AF52A0 Offset: 0x1AF38A0 VA: 0x181AF52A0
	public static Exception NYI(string moreinfo) { }

	// RVA: 0x1AF50C0 Offset: 0x1AF36C0 VA: 0x181AF50C0
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0x1AF5190 Offset: 0x1AF3790 VA: 0x181AF5190
	public static Exception MissingOperator(string token) { }

	// RVA: 0x1AF5690 Offset: 0x1AF3C90 VA: 0x181AF5690
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0x1AF4830 Offset: 0x1AF2E30 VA: 0x181AF4830
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0x1AF4600 Offset: 0x1AF2C00 VA: 0x181AF4600
	public static Exception ExpressionTooComplex() { }

	// RVA: 0x1AF5720 Offset: 0x1AF3D20 VA: 0x181AF5720
	public static Exception UnboundName(string name) { }

	// RVA: 0x1AF4D50 Offset: 0x1AF3350 VA: 0x181AF4D50
	public static Exception InvalidString(string str) { }

	// RVA: 0x1AF57B0 Offset: 0x1AF3DB0 VA: 0x181AF57B0
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0x1AF5470 Offset: 0x1AF3A70 VA: 0x181AF5470
	public static Exception SyntaxError() { }

	// RVA: 0x1AF47A0 Offset: 0x1AF2DA0 VA: 0x181AF47A0
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0x1AF5220 Offset: 0x1AF3820 VA: 0x181AF5220
	public static Exception MissingRightParen() { }

	// RVA: 0x1AF5980 Offset: 0x1AF3F80 VA: 0x181AF5980
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0x1AF5840 Offset: 0x1AF3E40 VA: 0x181AF5840
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0x1AF43C0 Offset: 0x1AF29C0 VA: 0x181AF43C0
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0x1AF44A0 Offset: 0x1AF2AA0 VA: 0x181AF44A0
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0x1AF4C30 Offset: 0x1AF3230 VA: 0x181AF4C30
	public static Exception InvalidName(string name) { }

	// RVA: 0x1AF4990 Offset: 0x1AF2F90 VA: 0x181AF4990
	public static Exception InvalidDate(string date) { }

	// RVA: 0x1AF5330 Offset: 0x1AF3930 VA: 0x181AF5330
	public static Exception NonConstantArgument() { }

	// RVA: 0x1AF4CC0 Offset: 0x1AF32C0 VA: 0x181AF4CC0
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0x1AF4910 Offset: 0x1AF2F10 VA: 0x181AF4910
	public static Exception InWithoutParentheses() { }

	// RVA: 0x1AF4890 Offset: 0x1AF2E90 VA: 0x181AF4890
	public static Exception InWithoutList() { }

	// RVA: 0x1AF4AA0 Offset: 0x1AF30A0 VA: 0x181AF4AA0
	public static Exception InvalidIsSyntax() { }

	// RVA: 0x1AF53B0 Offset: 0x1AF39B0 VA: 0x181AF53B0
	public static Exception Overflow(Type type) { }

	// RVA: 0x1AF4190 Offset: 0x1AF2790 VA: 0x181AF4190
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0x1AF40C0 Offset: 0x1AF26C0 VA: 0x181AF40C0
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0x1AF5570 Offset: 0x1AF3B70 VA: 0x181AF5570
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0x1AF3FA0 Offset: 0x1AF25A0 VA: 0x181AF3FA0
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0x1AF5B60 Offset: 0x1AF4160 VA: 0x181AF5B60
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0x1AF4BA0 Offset: 0x1AF31A0 VA: 0x181AF4BA0
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0x1AF5030 Offset: 0x1AF3630 VA: 0x181AF5030
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0x1AF54F0 Offset: 0x1AF3AF0 VA: 0x181AF54F0
	public static Exception TooManyRightParentheses() { }

	// RVA: 0x1AF5A50 Offset: 0x1AF4050 VA: 0x181AF5A50
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0x1AF42A0 Offset: 0x1AF28A0 VA: 0x181AF42A0
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0x1AF3E90 Offset: 0x1AF2490 VA: 0x181AF3E90
	public static Exception AggregateArgument() { }

	// RVA: 0x1AF3F10 Offset: 0x1AF2510 VA: 0x181AF3F10
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0x1AF4580 Offset: 0x1AF2B80 VA: 0x181AF4580
	public static Exception EvalNoContext() { }

	// RVA: 0x1AF4680 Offset: 0x1AF2C80 VA: 0x181AF4680
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0x1AF4330 Offset: 0x1AF2930 VA: 0x181AF4330
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0x1AF4710 Offset: 0x1AF2D10 VA: 0x181AF4710
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0x1AF4F30 Offset: 0x1AF3530 VA: 0x181AF4F30
	public static Exception LookupArgument() { }

	// RVA: 0x1AF4E60 Offset: 0x1AF3460 VA: 0x181AF4E60
	public static Exception InvalidType(string typeName) { }

	// RVA: 0x1AF4A20 Offset: 0x1AF3020 VA: 0x181AF4A20
	public static Exception InvalidHoursArgument() { }

	// RVA: 0x1AF4B20 Offset: 0x1AF3120 VA: 0x181AF4B20
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0x1AF4DE0 Offset: 0x1AF33E0 VA: 0x181AF4DE0
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0x1AF4FB0 Offset: 0x1AF35B0 VA: 0x181AF4FB0
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0x1AF5AF0 Offset: 0x1AF40F0 VA: 0x181AF5AF0
	public static Exception UnsupportedDataType(Type type) { }
}

// Namespace: System.Data
internal interface IFilter // TypeDefIndex: 8711
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Invoke(DataRow row, DataRowVersion version);
}

// Namespace: System.Data
internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 8712
{
	// Fields
	private readonly string _relationName; // 0x18
	private readonly string _columnName; // 0x20
	private DataColumn _column; // 0x28
	private DataRelation _relation; // 0x30

	// Methods

	// RVA: 0x1AFA680 Offset: 0x1AF8C80 VA: 0x181AFA680
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0x1AFA150 Offset: 0x1AF8750 VA: 0x181AFA150 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1AFA4F0 Offset: 0x1AF8AF0 VA: 0x181AFA4F0 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1AFA560 Offset: 0x1AF8B60 VA: 0x181AFA560 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1AFA520 Offset: 0x1AF8B20 VA: 0x181AFA520 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1AFA4E0 Offset: 0x1AF8AE0 VA: 0x181AFA4E0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
internal sealed class NameNode : ExpressionNode // TypeDefIndex: 8713
{
	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Properties
	internal override bool IsSqlColumn { get; }

	// Methods

	// RVA: 0x1AFAE60 Offset: 0x1AF9460 VA: 0x181AFAE60
	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x1AFAED0 Offset: 0x1AF94D0 VA: 0x181AFAED0 Slot: 4
	internal override bool get_IsSqlColumn() { }

	// RVA: 0x1AFA6F0 Offset: 0x1AF8CF0 VA: 0x181AFA6F0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1AFAA80 Offset: 0x1AF9080 VA: 0x181AFAA80 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1AFA960 Offset: 0x1AF8F60 VA: 0x181AFA960 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1AFAA40 Offset: 0x1AF9040 VA: 0x181AFAA40 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1AFAB90 Offset: 0x1AF9190 VA: 0x181AFAB90 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1AFAAB0 Offset: 0x1AF90B0 VA: 0x181AFAAB0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1AFAB20 Offset: 0x1AF9120 VA: 0x181AFAB20 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1AFA8D0 Offset: 0x1AF8ED0 VA: 0x181AFA8D0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1AFAC00 Offset: 0x1AF9200 VA: 0x181AFAC00
	internal static string ParseName(char[] text, int start, int pos) { }
}

// Namespace: System.Data
internal sealed class Operators // TypeDefIndex: 8714
{
	// Fields
	private static readonly int[] s_priority; // 0x0
	private static readonly string[] s_looks; // 0x8

	// Methods

	// RVA: 0x1B05940 Offset: 0x1B03F40 VA: 0x181B05940
	internal static bool IsArithmetical(int op) { }

	// RVA: 0x1B05960 Offset: 0x1B03F60 VA: 0x181B05960
	internal static bool IsLogical(int op) { }

	// RVA: 0x1B05980 Offset: 0x1B03F80 VA: 0x181B05980
	internal static bool IsRelational(int op) { }

	// RVA: 0x1B05990 Offset: 0x1B03F90 VA: 0x181B05990
	internal static int Priority(int op) { }

	// RVA: 0x1B05A30 Offset: 0x1B04030 VA: 0x181B05A30
	internal static string ToString(int op) { }

	// RVA: 0x1B05AE0 Offset: 0x1B040E0 VA: 0x181B05AE0
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 8715
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0x1B0ADE0 Offset: 0x1B093E0 VA: 0x181B0ADE0
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0x1B0A1C0 Offset: 0x1B087C0 VA: 0x181B0A1C0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1AC7760 Offset: 0x1AC5D60 VA: 0x181AC7760 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1B0ABE0 Offset: 0x1B091E0 VA: 0x181B0ABE0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1B0ABB0 Offset: 0x1B091B0 VA: 0x181B0ABB0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1B0A250 Offset: 0x1B08850 VA: 0x181B0A250
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0x1B0AC90 Offset: 0x1B09290 VA: 0x181B0AC90 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1B0ACC0 Offset: 0x1B092C0 VA: 0x181B0ACC0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1B0AC30 Offset: 0x1B09230 VA: 0x181B0AC30 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1B0AC60 Offset: 0x1B09260 VA: 0x181B0AC60 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1B0A220 Offset: 0x1B08820 VA: 0x181B0A220 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1B0ACF0 Offset: 0x1B092F0 VA: 0x181B0ACF0 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 8716
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0x1B13FD0 Offset: 0x1B125D0 VA: 0x181B13FD0
	internal void .ctor(int op) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1B13F40 Offset: 0x1B12540 VA: 0x181B13F40 Slot: 6
	internal override object Eval() { }

	// RVA: 0x53F9C0 Offset: 0x53DFC0 VA: 0x18053F9C0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x53F9C0 Offset: 0x53DFC0 VA: 0x18053F9C0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
[DefaultProperty("ConstraintName")]
public class ForeignKeyConstraint : Constraint // TypeDefIndex: 8717
{
	// Fields
	internal Rule _deleteRule; // 0x38
	internal Rule _updateRule; // 0x3C
	internal AcceptRejectRule _acceptRejectRule; // 0x40
	private DataKey _childKey; // 0x48
	private DataKey _parentKey; // 0x50
	internal string _constraintName; // 0x58
	internal string[] _parentColumnNames; // 0x60
	internal string[] _childColumnNames; // 0x68
	internal string _parentTableName; // 0x70

	// Properties
	internal DataKey ChildKey { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	[DefaultValue(0)]
	public virtual AcceptRejectRule AcceptRejectRule { get; set; }
	[DefaultValue(1)]
	public virtual Rule DeleteRule { get; set; }
	[ReadOnly(True)]
	public virtual DataColumn[] RelatedColumns { get; }
	internal DataColumn[] RelatedColumnsReference { get; }
	internal DataKey ParentKey { get; }
	[ReadOnly(True)]
	public virtual DataTable RelatedTable { get; }
	[DefaultValue(1)]
	public virtual Rule UpdateRule { get; set; }

	// Methods

	// RVA: 0x1AFE840 Offset: 0x1AFCE40 VA: 0x181AFE840
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1AFE8A0 Offset: 0x1AFCEA0 VA: 0x181AFE8A0
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Browsable(False)]
	// RVA: 0x1AFE790 Offset: 0x1AFCD90 VA: 0x181AFE790
	public void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0x1AFE940 Offset: 0x1AFCF40 VA: 0x181AFE940
	internal DataKey get_ChildKey() { }

	// RVA: 0x1AFE960 Offset: 0x1AFCF60 VA: 0x181AFE960 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x1AFEA10 Offset: 0x1AFD010 VA: 0x181AFEA10 Slot: 8
	public override DataTable get_Table() { }

	// RVA: 0x1AFE9A0 Offset: 0x1AFCFA0 VA: 0x181AFE9A0
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x1AFE930 Offset: 0x1AFCF30 VA: 0x181AFE930
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x1AFC230 Offset: 0x1AFA830 VA: 0x181AFC230 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x1AFE420 Offset: 0x1AFCA20 VA: 0x181AFE420
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0x1AFDC90 Offset: 0x1AFC290 VA: 0x181AFDC90 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x1AFAEF0 Offset: 0x1AF94F0 VA: 0x181AFAEF0 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x1AFB350 Offset: 0x1AF9950 VA: 0x181AFB350
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0x1AFB4C0 Offset: 0x1AF9AC0 VA: 0x181AFB4C0
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0x1AFBA50 Offset: 0x1AFA050 VA: 0x181AFBA50
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0x1AFBCC0 Offset: 0x1AFA2C0 VA: 0x181AFBCC0
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0x1AFC3B0 Offset: 0x1AFA9B0 VA: 0x181AFC3B0
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0x1AFC4C0 Offset: 0x1AFAAC0 VA: 0x181AFC4C0
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0x1AFC580 Offset: 0x1AFAB80 VA: 0x181AFC580
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0x1AFC880 Offset: 0x1AFAE80 VA: 0x181AFC880 Slot: 15
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0x1AFE4D0 Offset: 0x1AFCAD0 VA: 0x181AFE4D0
	private void NonVirtualCheckState() { }

	// RVA: 0x1AFCB70 Offset: 0x1AFB170 VA: 0x181AFCB70 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x1AFE910 Offset: 0x1AFCF10 VA: 0x181AFE910 Slot: 20
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0x1AFEA50 Offset: 0x1AFD050 VA: 0x181AFEA50 Slot: 21
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x1AFD830 Offset: 0x1AFBE30 VA: 0x181AFD830 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1AFD810 Offset: 0x1AFBE10 VA: 0x181AFD810 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x1AFCB80 Offset: 0x1AFB180 VA: 0x181AFCB80 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x1AFD250 Offset: 0x1AFB850 VA: 0x181AFD250
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0x1AFD880 Offset: 0x1AFBE80 VA: 0x181AFD880
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1AFE980 Offset: 0x1AFCF80 VA: 0x181AFE980 Slot: 22
	public virtual Rule get_DeleteRule() { }

	// RVA: 0x1AFEAA0 Offset: 0x1AFD0A0 VA: 0x181AFEAA0 Slot: 23
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0x1AFDA90 Offset: 0x1AFC090 VA: 0x181AFDA90 Slot: 0
	public override bool Equals(object key) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AFE9D0 Offset: 0x1AFCFD0 VA: 0x181AFE9D0 Slot: 24
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0x1AFE9B0 Offset: 0x1AFCFB0 VA: 0x181AFE9B0
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0x1AFE9B0 Offset: 0x1AFCFB0 VA: 0x181AFE9B0
	internal DataKey get_ParentKey() { }

	// RVA: 0x1AFDBA0 Offset: 0x1AFC1A0 VA: 0x181AFDBA0
	internal DataRelation FindParentRelation() { }

	// RVA: 0x1AFE9F0 Offset: 0x1AFCFF0 VA: 0x181AFE9F0 Slot: 25
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0x1AFEA30 Offset: 0x1AFD030 VA: 0x181AFEA30 Slot: 26
	public virtual Rule get_UpdateRule() { }

	// RVA: 0x1AFEAF0 Offset: 0x1AFD0F0 VA: 0x181AFEAF0 Slot: 27
	public virtual void set_UpdateRule(Rule value) { }
}

// Namespace: System.Data
public enum MappingType // TypeDefIndex: 8718
{
	// Fields
	public int value__; // 0x0
	public const MappingType Element = 1;
	public const MappingType Attribute = 2;
	public const MappingType SimpleContent = 3;
	public const MappingType Hidden = 4;
}

// Namespace: System.Data
public class MergeFailedEventArgs : EventArgs // TypeDefIndex: 8719
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Conflict>k__BackingField; // 0x18

	// Properties
	public string Conflict { get; }

	// Methods

	// RVA: 0x1B02960 Offset: 0x1B00F60 VA: 0x181B02960
	public void .ctor(DataTable table, string conflict) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Conflict() { }
}

// Namespace: System.Data
public sealed class MergeFailedEventHandler : MulticastDelegate // TypeDefIndex: 8720
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, MergeFailedEventArgs e) { }
}

// Namespace: System.Data
internal sealed class Merger // TypeDefIndex: 8721
{
	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0x1B05890 Offset: 0x1B03E90 VA: 0x181B05890
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1B05820 Offset: 0x1B03E20 VA: 0x181B05820
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1B02EC0 Offset: 0x1B014C0 VA: 0x181B02EC0
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0x1B04FC0 Offset: 0x1B035C0 VA: 0x181B04FC0
	internal void MergeTable(DataTable src) { }

	// RVA: 0x1B05240 Offset: 0x1B03840 VA: 0x181B05240
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0x1B046F0 Offset: 0x1B02CF0 VA: 0x181B046F0
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0x1B04F20 Offset: 0x1B03520 VA: 0x181B04F20
	private void MergeTableData(DataTable src) { }

	// RVA: 0x1B02B60 Offset: 0x1B01160 VA: 0x181B02B60
	private void MergeConstraints(DataSet source) { }

	// RVA: 0x1B02BF0 Offset: 0x1B011F0 VA: 0x181B02BF0
	private void MergeConstraints(DataTable table) { }

	// RVA: 0x1B03DD0 Offset: 0x1B023D0 VA: 0x181B03DD0
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0x1B03C10 Offset: 0x1B02210 VA: 0x181B03C10
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0x1B029F0 Offset: 0x1B00FF0 VA: 0x181B029F0
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }
}

// Namespace: System.Data
public enum MissingSchemaAction // TypeDefIndex: 8722
{
	// Fields
	public int value__; // 0x0
	public const MissingSchemaAction Add = 1;
	public const MissingSchemaAction Ignore = 2;
	public const MissingSchemaAction Error = 3;
	public const MissingSchemaAction AddWithKey = 4;
}

// Namespace: System.Data
internal sealed class PrimaryKeyTypeConverter : ReferenceConverter // TypeDefIndex: 8723
{
	// Methods

	// RVA: 0x1B06450 Offset: 0x1B04A50 VA: 0x181B06450
	public void .ctor() { }

	// RVA: 0x1AC9840 Offset: 0x1AC7E40 VA: 0x181AC9840 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1B062E0 Offset: 0x1B048E0 VA: 0x181B062E0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
[Serializable]
public class PropertyCollection : Hashtable, ICloneable // TypeDefIndex: 8724
{
	// Methods

	// RVA: 0x1B06760 Offset: 0x1B04D60 VA: 0x181B06760
	public void .ctor() { }

	// RVA: 0x1B06770 Offset: 0x1B04D70 VA: 0x181B06770
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B064E0 Offset: 0x1B04AE0 VA: 0x181B064E0 Slot: 25
	public override object Clone() { }
}

// Namespace: System.Data
internal struct Range // TypeDefIndex: 8725
{
	// Fields
	private int _min; // 0x0
	private int _max; // 0x4
	private bool _isNotNull; // 0x8

	// Properties
	public int Count { get; }
	public bool IsNull { get; }
	public int Min { get; }

	// Methods

	// RVA: 0x1B067D0 Offset: 0x1B04DD0 VA: 0x181B067D0
	public void .ctor(int min, int max) { }

	// RVA: 0x1B06820 Offset: 0x1B04E20 VA: 0x181B06820
	public int get_Count() { }

	// RVA: 0x1B06840 Offset: 0x1B04E40 VA: 0x181B06840
	public bool get_IsNull() { }

	// RVA: 0x1B06850 Offset: 0x1B04E50 VA: 0x181B06850
	public int get_Min() { }

	// RVA: 0x1B06790 Offset: 0x1B04D90 VA: 0x181B06790
	internal void CheckNull() { }
}

// Namespace: System.Data
internal enum RBTreeError // TypeDefIndex: 8726
{
	// Fields
	public int value__; // 0x0
	public const RBTreeError InvalidPageSize = 1;
	public const RBTreeError PagePositionInSlotInUse = 3;
	public const RBTreeError NoFreeSlots = 4;
	public const RBTreeError InvalidStateinInsert = 5;
	public const RBTreeError InvalidNextSizeInDelete = 7;
	public const RBTreeError InvalidStateinDelete = 8;
	public const RBTreeError InvalidNodeSizeinDelete = 9;
	public const RBTreeError InvalidStateinEndDelete = 10;
	public const RBTreeError CannotRotateInvalidsuccessorNodeinDelete = 11;
	public const RBTreeError IndexOutOFRangeinGetNodeByIndex = 13;
	public const RBTreeError RBDeleteFixup = 14;
	public const RBTreeError UnsupportedAccessMethod1 = 15;
	public const RBTreeError UnsupportedAccessMethod2 = 16;
	public const RBTreeError UnsupportedAccessMethodInNonNillRootSubtree = 17;
	public const RBTreeError AttachedNodeWithZerorbTreeNodeId = 18;
	public const RBTreeError CompareNodeInDataRowTree = 19;
	public const RBTreeError CompareSateliteTreeNodeInDataRowTree = 20;
	public const RBTreeError NestedSatelliteTreeEnumerator = 21;
}

// Namespace: System.Data
internal enum TreeAccessMethod // TypeDefIndex: 8727
{
	// Fields
	public int value__; // 0x0
	public const TreeAccessMethod KEY_SEARCH_AND_INDEX = 1;
	public const TreeAccessMethod INDEX_ONLY = 2;
}

// Namespace: System.Data
[DefaultMember("Item")]
internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 8733
{
	// Fields
	private RBTree.TreePage<K>[] _pageTable; // 0x0
	private int[] _pageTableMap; // 0x0
	private int _inUsePageCount; // 0x0
	private int _nextFreePageLine; // 0x0
	public int root; // 0x0
	private int _version; // 0x0
	private int _inUseNodeCount; // 0x0
	private int _inUseSatelliteTreeCount; // 0x0
	private readonly TreeAccessMethod _accessMethod; // 0x0

	// Properties
	public int Count { get; }
	public bool HasDuplicates { get; }
	public K Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int CompareNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareNode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int CompareSateliteTreeNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareSateliteTreeNode
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(TreeAccessMethod accessMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EFD80 Offset: 0x8EE380 VA: 0x1808EFD80
	|-RBTree<int>..ctor
	|
	|-RVA: 0x8EFDD0 Offset: 0x8EE3D0 VA: 0x1808EFDD0
	|-RBTree<object>..ctor
	|
	|-RVA: 0x8F8B10 Offset: 0x8F7110 VA: 0x1808F8B10
	|-RBTree<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E58B0 Offset: 0x8E3EB0 VA: 0x1808E58B0
	|-RBTree<int>.InitTree
	|
	|-RVA: 0x8E5A20 Offset: 0x8E4020 VA: 0x1808E5A20
	|-RBTree<object>.InitTree
	|
	|-RVA: 0x8F2930 Offset: 0x8F0F30 VA: 0x1808F2930
	|-RBTree<__Il2CppFullySharedGenericType>.InitTree
	*/

	// RVA: -1 Offset: -1
	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E3F40 Offset: 0x8E2540 VA: 0x1808E3F40
	|-RBTree<int>.FreePage
	|-RBTree<object>.FreePage
	|
	|-RVA: 0x8F1450 Offset: 0x8EFA50 VA: 0x1808F1450
	|-RBTree<__Il2CppFullySharedGenericType>.FreePage
	*/

	// RVA: -1 Offset: -1
	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E21A0 Offset: 0x8E07A0 VA: 0x1808E21A0
	|-RBTree<int>.AllocPage
	|
	|-RVA: 0x8E1EF0 Offset: 0x8E04F0 VA: 0x1808E1EF0
	|-RBTree<object>.AllocPage
	|
	|-RVA: 0x8F0110 Offset: 0x8EE710 VA: 0x1808F0110
	|-RBTree<__Il2CppFullySharedGenericType>.AllocPage
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E7240 Offset: 0x8E5840 VA: 0x1808E7240
	|-RBTree<int>.MarkPageFull
	|-RBTree<object>.MarkPageFull
	|
	|-RVA: 0x8F3730 Offset: 0x8F1D30 VA: 0x1808F3730
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFull
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E71E0 Offset: 0x8E57E0 VA: 0x1808E71E0
	|-RBTree<int>.MarkPageFree
	|-RBTree<object>.MarkPageFree
	|
	|-RVA: 0x8F3660 Offset: 0x8F1C60 VA: 0x1808F3660
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFree
	*/

	// RVA: -1 Offset: -1
	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E4A40 Offset: 0x8E3040 VA: 0x1808E4A40
	|-RBTree<int>.GetIntValueFromBitMap
	|-RBTree<object>.GetIntValueFromBitMap
	|-RBTree<__Il2CppFullySharedGenericType>.GetIntValueFromBitMap
	*/

	// RVA: -1 Offset: -1
	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E3C20 Offset: 0x8E2220 VA: 0x1808E3C20
	|-RBTree<int>.FreeNode
	|
	|-RVA: 0x8E3DB0 Offset: 0x8E23B0 VA: 0x1808E3DB0
	|-RBTree<object>.FreeNode
	|
	|-RVA: 0x8F1280 Offset: 0x8EF880 VA: 0x1808F1280
	|-RBTree<__Il2CppFullySharedGenericType>.FreeNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E48A0 Offset: 0x8E2EA0 VA: 0x1808E48A0
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x8F1A20 Offset: 0x8F0020 VA: 0x1808F1A20
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexOfPageWithFreeSlot
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EFEE0 Offset: 0x8EE4E0 VA: 0x1808EFEE0
	|-RBTree<int>.get_Count
	|-RBTree<object>.get_Count
	|-RBTree<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EFEF0 Offset: 0x8EE4F0 VA: 0x1808EFEF0
	|-RBTree<int>.get_HasDuplicates
	|-RBTree<object>.get_HasDuplicates
	|-RBTree<__Il2CppFullySharedGenericType>.get_HasDuplicates
	*/

	// RVA: -1 Offset: -1
	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E4CE0 Offset: 0x8E32E0 VA: 0x1808E4CE0
	|-RBTree<int>.GetNewNode
	|
	|-RVA: 0x8E4AB0 Offset: 0x8E30B0 VA: 0x1808E4AB0
	|-RBTree<object>.GetNewNode
	|
	|-RVA: 0x8F1BF0 Offset: 0x8F01F0 VA: 0x1808F1BF0
	|-RBTree<__Il2CppFullySharedGenericType>.GetNewNode
	*/

	// RVA: -1 Offset: -1
	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EFA10 Offset: 0x8EE010 VA: 0x1808EFA10
	|-RBTree<int>.Successor
	|
	|-RVA: 0x8EF740 Offset: 0x8EDD40 VA: 0x1808EF740
	|-RBTree<object>.Successor
	|
	|-RVA: 0x8F85A0 Offset: 0x8F6BA0 VA: 0x1808F85A0
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EF8B0 Offset: 0x8EDEB0 VA: 0x1808EF8B0
	|-RBTree<int>.Successor
	|
	|-RVA: 0x8EF5E0 Offset: 0x8EDBE0 VA: 0x1808EF5E0
	|-RBTree<object>.Successor
	|
	|-RVA: 0x8F8710 Offset: 0x8F6D10 VA: 0x1808F8710
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E7330 Offset: 0x8E5930 VA: 0x1808E7330
	|-RBTree<int>.Minimum
	|
	|-RVA: 0x8E72A0 Offset: 0x8E58A0 VA: 0x1808E72A0
	|-RBTree<object>.Minimum
	|
	|-RVA: 0x8F3800 Offset: 0x8F1E00 VA: 0x1808F3800
	|-RBTree<__Il2CppFullySharedGenericType>.Minimum
	*/

	// RVA: -1 Offset: -1
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E67E0 Offset: 0x8E4DE0 VA: 0x1808E67E0
	|-RBTree<int>.LeftRotate
	|
	|-RVA: 0x8E5ED0 Offset: 0x8E44D0 VA: 0x1808E5ED0
	|-RBTree<object>.LeftRotate
	|
	|-RVA: 0x8F2E70 Offset: 0x8F1470 VA: 0x1808F2E70
	|-RBTree<__Il2CppFullySharedGenericType>.LeftRotate
	*/

	// RVA: -1 Offset: -1
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EDB20 Offset: 0x8EC120 VA: 0x1808EDB20
	|-RBTree<int>.RightRotate
	|
	|-RVA: 0x8EE460 Offset: 0x8ECA60 VA: 0x1808EE460
	|-RBTree<object>.RightRotate
	|
	|-RVA: 0x8F74C0 Offset: 0x8F5AC0 VA: 0x1808F74C0
	|-RBTree<__Il2CppFullySharedGenericType>.RightRotate
	*/

	// RVA: -1 Offset: -1
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAE70 Offset: 0x8E9470 VA: 0x1808EAE70
	|-RBTree<int>.RBInsert
	|
	|-RVA: 0x8EC200 Offset: 0x8EA800 VA: 0x1808EC200
	|-RBTree<object>.RBInsert
	|
	|-RVA: 0x8F5930 Offset: 0x8F3F30 VA: 0x1808F5930
	|-RBTree<__Il2CppFullySharedGenericType>.RBInsert
	*/

	// RVA: -1 Offset: -1
	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EFC70 Offset: 0x8EE270 VA: 0x1808EFC70
	|-RBTree<int>.UpdateNodeKey
	|
	|-RVA: 0x8EFB80 Offset: 0x8EE180 VA: 0x1808EFB80
	|-RBTree<object>.UpdateNodeKey
	|
	|-RVA: 0x8F88A0 Offset: 0x8F6EA0 VA: 0x1808F88A0
	|-RBTree<__Il2CppFullySharedGenericType>.UpdateNodeKey
	*/

	// RVA: -1 Offset: -1
	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E3AA0 Offset: 0x8E20A0 VA: 0x1808E3AA0
	|-RBTree<int>.DeleteByIndex
	|
	|-RVA: 0x8E3B60 Offset: 0x8E2160 VA: 0x1808E3B60
	|-RBTree<object>.DeleteByIndex
	|
	|-RVA: 0x8F1150 Offset: 0x8EF750 VA: 0x1808F1150
	|-RBTree<__Il2CppFullySharedGenericType>.DeleteByIndex
	*/

	// RVA: -1 Offset: -1
	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EAE40 Offset: 0x8E9440 VA: 0x1808EAE40
	|-RBTree<int>.RBDelete
	|
	|-RVA: 0x8EAE10 Offset: 0x8E9410 VA: 0x1808EAE10
	|-RBTree<object>.RBDelete
	|
	|-RVA: 0x8F58F0 Offset: 0x8F3EF0 VA: 0x1808F58F0
	|-RBTree<__Il2CppFullySharedGenericType>.RBDelete
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E9AD0 Offset: 0x8E80D0 VA: 0x1808E9AD0
	|-RBTree<int>.RBDeleteX
	|
	|-RVA: 0x8E8760 Offset: 0x8E6D60 VA: 0x1808E8760
	|-RBTree<object>.RBDeleteX
	|
	|-RVA: 0x8F4670 Offset: 0x8F2C70 VA: 0x1808F4670
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteX
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E7540 Offset: 0x8E5B40 VA: 0x1808E7540
	|-RBTree<int>.RBDeleteFixup
	|
	|-RVA: 0x8E7E50 Offset: 0x8E6450 VA: 0x1808E7E50
	|-RBTree<object>.RBDeleteFixup
	|
	|-RVA: 0x8F39E0 Offset: 0x8F1FE0 VA: 0x1808F39E0
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteFixup
	*/

	// RVA: -1 Offset: -1
	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EEE30 Offset: 0x8ED430 VA: 0x1808EEE30
	|-RBTree<int>.SearchSubTree
	|
	|-RVA: 0x8EEF30 Offset: 0x8ED530 VA: 0x1808EEF30
	|-RBTree<object>.SearchSubTree
	|
	|-RVA: 0x8F7CB0 Offset: 0x8F62B0 VA: 0x1808F7CB0
	|-RBTree<__Il2CppFullySharedGenericType>.SearchSubTree
	*/

	// RVA: -1 Offset: -1
	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EFF70 Offset: 0x8EE570 VA: 0x1808EFF70
	|-RBTree<int>.get_Item
	|
	|-RVA: 0x8EFF00 Offset: 0x8EE500 VA: 0x1808EFF00
	|-RBTree<object>.get_Item
	|
	|-RVA: 0x8F8BF0 Offset: 0x8F71F0 VA: 0x1808F8BF0
	|-RBTree<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E52F0 Offset: 0x8E38F0 VA: 0x1808E52F0
	|-RBTree<int>.GetNodeByKey
	|
	|-RVA: 0x8E50C0 Offset: 0x8E36C0 VA: 0x1808E50C0
	|-RBTree<object>.GetNodeByKey
	|
	|-RVA: 0x8F2130 Offset: 0x8F0730 VA: 0x1808F2130
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E4220 Offset: 0x8E2820 VA: 0x1808E4220
	|-RBTree<int>.GetIndexByKey
	|
	|-RVA: 0x8E4100 Offset: 0x8E2700 VA: 0x1808E4100
	|-RBTree<object>.GetIndexByKey
	|
	|-RVA: 0x8F15C0 Offset: 0x8EFBC0 VA: 0x1808F15C0
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E46B0 Offset: 0x8E2CB0 VA: 0x1808E46B0
	|-RBTree<int>.GetIndexByNode
	|
	|-RVA: 0x8E44C0 Offset: 0x8E2AC0 VA: 0x1808E44C0
	|-RBTree<object>.GetIndexByNode
	|
	|-RVA: 0x8F17F0 Offset: 0x8EFDF0 VA: 0x1808F17F0
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E4400 Offset: 0x8E2A00 VA: 0x1808E4400
	|-RBTree<int>.GetIndexByNodePath
	|
	|-RVA: 0x8E4340 Offset: 0x8E2940 VA: 0x1808E4340
	|-RBTree<object>.GetIndexByNodePath
	|
	|-RVA: 0x8F1700 Offset: 0x8EFD00 VA: 0x1808F1700
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNodePath
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E2670 Offset: 0x8E0C70 VA: 0x1808E2670
	|-RBTree<int>.ComputeIndexByNode
	|
	|-RVA: 0x8E24B0 Offset: 0x8E0AB0 VA: 0x1808E24B0
	|-RBTree<object>.ComputeIndexByNode
	|
	|-RVA: 0x8F0420 Offset: 0x8EEA20 VA: 0x1808F0420
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E2A60 Offset: 0x8E1060 VA: 0x1808E2A60
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0x8E2830 Offset: 0x8E0E30 VA: 0x1808E2830
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0x8F05A0 Offset: 0x8EEBA0 VA: 0x1808F05A0
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexWithSatelliteByNode
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E4F00 Offset: 0x8E3500 VA: 0x1808E4F00
	|-RBTree<int>.GetNodeByIndex
	|
	|-RVA: 0x8E4FE0 Offset: 0x8E35E0 VA: 0x1808E4FE0
	|-RBTree<object>.GetNodeByIndex
	|
	|-RVA: 0x8F2030 Offset: 0x8F0630 VA: 0x1808F2030
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E3120 Offset: 0x8E1720 VA: 0x1808E3120
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0x8E2EB0 Offset: 0x8E14B0 VA: 0x1808E2EB0
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0x8F07C0 Offset: 0x8EEDC0 VA: 0x1808F07C0
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E2DA0 Offset: 0x8E13A0 VA: 0x1808E2DA0
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0x8E2C90 Offset: 0x8E1290 VA: 0x1808E2C90
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0x8F0AD0 Offset: 0x8EF0D0 VA: 0x1808F0AD0
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E1DF0 Offset: 0x8E03F0 VA: 0x1808E1DF0
	|-RBTree<int>.Insert
	|
	|-RVA: 0x8E1E70 Offset: 0x8E0470 VA: 0x1808E1E70
	|-RBTree<object>.Insert
	|
	|-RVA: 0x8EFFE0 Offset: 0x8EE5E0 VA: 0x1808EFFE0
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E1DF0 Offset: 0x8E03F0 VA: 0x1808E1DF0
	|-RBTree<int>.Add
	|
	|-RVA: 0x8E1E70 Offset: 0x8E0470 VA: 0x1808E1E70
	|-RBTree<object>.Add
	|
	|-RVA: 0x8EFFE0 Offset: 0x8EE5E0 VA: 0x1808EFFE0
	|-RBTree<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E4070 Offset: 0x8E2670 VA: 0x1808E4070
	|-RBTree<int>.GetEnumerator
	|
	|-RVA: 0x8E3FD0 Offset: 0x8E25D0 VA: 0x1808E3FD0
	|-RBTree<object>.GetEnumerator
	|
	|-RVA: 0x8F1500 Offset: 0x8EFB00 VA: 0x1808F1500
	|-RBTree<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5600 Offset: 0x8E3C00 VA: 0x1808E5600
	|-RBTree<int>.IndexOf
	|
	|-RVA: 0x8E5780 Offset: 0x8E3D80 VA: 0x1808E5780
	|-RBTree<object>.IndexOf
	|
	|-RVA: 0x8F25E0 Offset: 0x8F0BE0 VA: 0x1808F25E0
	|-RBTree<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5CD0 Offset: 0x8E42D0 VA: 0x1808E5CD0
	|-RBTree<int>.Insert
	|
	|-RVA: 0x8E5D70 Offset: 0x8E4370 VA: 0x1808E5D70
	|-RBTree<object>.Insert
	|
	|-RVA: 0x8F2C50 Offset: 0x8F1250 VA: 0x1808F2C50
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5C30 Offset: 0x8E4230 VA: 0x1808E5C30
	|-RBTree<int>.InsertAt
	|
	|-RVA: 0x8E5B90 Offset: 0x8E4190 VA: 0x1808E5B90
	|-RBTree<object>.InsertAt
	|
	|-RVA: 0x8F2B20 Offset: 0x8F1120 VA: 0x1808F2B20
	|-RBTree<__Il2CppFullySharedGenericType>.InsertAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8ED9C0 Offset: 0x8EBFC0 VA: 0x1808ED9C0
	|-RBTree<int>.RemoveAt
	|
	|-RVA: 0x8EDA70 Offset: 0x8EC070 VA: 0x1808EDA70
	|-RBTree<object>.RemoveAt
	|
	|-RVA: 0x8F7410 Offset: 0x8F5A10 VA: 0x1808F7410
	|-RBTree<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E2480 Offset: 0x8E0A80 VA: 0x1808E2480
	|-RBTree<int>.Clear
	|
	|-RVA: 0x8E2450 Offset: 0x8E0A50 VA: 0x1808E2450
	|-RBTree<object>.Clear
	|
	|-RVA: 0x8F03F0 Offset: 0x8EE9F0 VA: 0x1808F03F0
	|-RBTree<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E36B0 Offset: 0x8E1CB0 VA: 0x1808E36B0
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0x8E3390 Offset: 0x8E1990 VA: 0x1808E3390
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x8F0BE0 Offset: 0x8EF1E0 VA: 0x1808F0BE0
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E3860 Offset: 0x8E1E60 VA: 0x1808E3860
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0x8E3510 Offset: 0x8E1B10 VA: 0x1808E3510
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x8F0E20 Offset: 0x8EF420 VA: 0x1808F0E20
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EF410 Offset: 0x8EDA10 VA: 0x1808EF410
	|-RBTree<int>.SetRight
	|
	|-RVA: 0x8EF3C0 Offset: 0x8ED9C0 VA: 0x1808EF3C0
	|-RBTree<object>.SetRight
	|
	|-RVA: 0x8F8380 Offset: 0x8F6980 VA: 0x1808F8380
	|-RBTree<__Il2CppFullySharedGenericType>.SetRight
	*/

	// RVA: -1 Offset: -1
	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EF200 Offset: 0x8ED800 VA: 0x1808EF200
	|-RBTree<int>.SetLeft
	|
	|-RVA: 0x8EF1B0 Offset: 0x8ED7B0 VA: 0x1808EF1B0
	|-RBTree<object>.SetLeft
	|
	|-RVA: 0x8F8130 Offset: 0x8F6730 VA: 0x1808F8130
	|-RBTree<__Il2CppFullySharedGenericType>.SetLeft
	*/

	// RVA: -1 Offset: -1
	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EF310 Offset: 0x8ED910 VA: 0x1808EF310
	|-RBTree<int>.SetParent
	|
	|-RVA: 0x8EF370 Offset: 0x8ED970 VA: 0x1808EF370
	|-RBTree<object>.SetParent
	|
	|-RVA: 0x8F82C0 Offset: 0x8F68C0 VA: 0x1808F82C0
	|-RBTree<__Il2CppFullySharedGenericType>.SetParent
	*/

	// RVA: -1 Offset: -1
	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EF030 Offset: 0x8ED630 VA: 0x1808EF030
	|-RBTree<int>.SetColor
	|
	|-RVA: 0x8EF090 Offset: 0x8ED690 VA: 0x1808EF090
	|-RBTree<object>.SetColor
	|
	|-RVA: 0x8F7F20 Offset: 0x8F6520 VA: 0x1808F7F20
	|-RBTree<__Il2CppFullySharedGenericType>.SetColor
	*/

	// RVA: -1 Offset: -1
	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EF0E0 Offset: 0x8ED6E0 VA: 0x1808EF0E0
	|-RBTree<int>.SetKey
	|
	|-RVA: 0x8EF140 Offset: 0x8ED740 VA: 0x1808EF140
	|-RBTree<object>.SetKey
	|
	|-RVA: 0x8F7FF0 Offset: 0x8F65F0 VA: 0x1808F7FF0
	|-RBTree<__Il2CppFullySharedGenericType>.SetKey
	*/

	// RVA: -1 Offset: -1
	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EF260 Offset: 0x8ED860 VA: 0x1808EF260
	|-RBTree<int>.SetNext
	|
	|-RVA: 0x8EF2C0 Offset: 0x8ED8C0 VA: 0x1808EF2C0
	|-RBTree<object>.SetNext
	|
	|-RVA: 0x8F81F0 Offset: 0x8F67F0 VA: 0x1808F81F0
	|-RBTree<__Il2CppFullySharedGenericType>.SetNext
	*/

	// RVA: -1 Offset: -1
	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EF4C0 Offset: 0x8EDAC0 VA: 0x1808EF4C0
	|-RBTree<int>.SetSubTreeSize
	|
	|-RVA: 0x8EF470 Offset: 0x8EDA70 VA: 0x1808EF470
	|-RBTree<object>.SetSubTreeSize
	|
	|-RVA: 0x8F8440 Offset: 0x8F6A40 VA: 0x1808F8440
	|-RBTree<__Il2CppFullySharedGenericType>.SetSubTreeSize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5550 Offset: 0x8E3B50 VA: 0x1808E5550
	|-RBTree<int>.IncreaseSize
	|
	|-RVA: 0x8E55B0 Offset: 0x8E3BB0 VA: 0x1808E55B0
	|-RBTree<object>.IncreaseSize
	|
	|-RVA: 0x8F2550 Offset: 0x8F0B50 VA: 0x1808F2550
	|-RBTree<__Il2CppFullySharedGenericType>.IncreaseSize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8ED7A0 Offset: 0x8EBDA0 VA: 0x1808ED7A0
	|-RBTree<int>.RecomputeSize
	|
	|-RVA: 0x8ED580 Offset: 0x8EBB80 VA: 0x1808ED580
	|-RBTree<object>.RecomputeSize
	|
	|-RVA: 0x8F71D0 Offset: 0x8F57D0 VA: 0x1808F71D0
	|-RBTree<__Il2CppFullySharedGenericType>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E39F0 Offset: 0x8E1FF0 VA: 0x1808E39F0
	|-RBTree<int>.DecreaseSize
	|
	|-RVA: 0x8E3A50 Offset: 0x8E2050 VA: 0x1808E3A50
	|-RBTree<object>.DecreaseSize
	|
	|-RVA: 0x8F10C0 Offset: 0x8EF6C0 VA: 0x1808F10C0
	|-RBTree<__Il2CppFullySharedGenericType>.DecreaseSize
	*/

	// RVA: -1 Offset: -1
	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EED70 Offset: 0x8ED370 VA: 0x1808EED70
	|-RBTree<int>.Right
	|
	|-RVA: 0x8EEDD0 Offset: 0x8ED3D0 VA: 0x1808EEDD0
	|-RBTree<object>.Right
	|
	|-RVA: 0x8F7C30 Offset: 0x8F6230 VA: 0x1808F7C30
	|-RBTree<__Il2CppFullySharedGenericType>.Right
	*/

	// RVA: -1 Offset: -1
	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E7120 Offset: 0x8E5720 VA: 0x1808E7120
	|-RBTree<int>.Left
	|
	|-RVA: 0x8E7180 Offset: 0x8E5780 VA: 0x1808E7180
	|-RBTree<object>.Left
	|
	|-RVA: 0x8F35E0 Offset: 0x8F1BE0 VA: 0x1808F35E0
	|-RBTree<__Il2CppFullySharedGenericType>.Left
	*/

	// RVA: -1 Offset: -1
	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E7480 Offset: 0x8E5A80 VA: 0x1808E7480
	|-RBTree<int>.Parent
	|
	|-RVA: 0x8E74E0 Offset: 0x8E5AE0 VA: 0x1808E74E0
	|-RBTree<object>.Parent
	|
	|-RVA: 0x8F3960 Offset: 0x8F1F60 VA: 0x1808F3960
	|-RBTree<__Il2CppFullySharedGenericType>.Parent
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EFE20 Offset: 0x8EE420 VA: 0x1808EFE20
	|-RBTree<int>.color
	|
	|-RVA: 0x8EFE80 Offset: 0x8EE480 VA: 0x1808EFE80
	|-RBTree<object>.color
	|
	|-RVA: 0x8F8B60 Offset: 0x8F7160 VA: 0x1808F8B60
	|-RBTree<__Il2CppFullySharedGenericType>.color
	*/

	// RVA: -1 Offset: -1
	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E7420 Offset: 0x8E5A20 VA: 0x1808E7420
	|-RBTree<int>.Next
	|
	|-RVA: 0x8E73C0 Offset: 0x8E59C0 VA: 0x1808E73C0
	|-RBTree<object>.Next
	|
	|-RVA: 0x8F38D0 Offset: 0x8F1ED0 VA: 0x1808F38D0
	|-RBTree<__Il2CppFullySharedGenericType>.Next
	*/

	// RVA: -1 Offset: -1
	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8EF520 Offset: 0x8EDB20 VA: 0x1808EF520
	|-RBTree<int>.SubTreeSize
	|
	|-RVA: 0x8EF580 Offset: 0x8EDB80 VA: 0x1808EF580
	|-RBTree<object>.SubTreeSize
	|
	|-RVA: 0x8F8510 Offset: 0x8F6B10 VA: 0x1808F8510
	|-RBTree<__Il2CppFullySharedGenericType>.SubTreeSize
	*/

	// RVA: -1 Offset: -1
	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E5E70 Offset: 0x8E4470 VA: 0x1808E5E70
	|-RBTree<int>.Key
	|
	|-RVA: 0x8E5E10 Offset: 0x8E4410 VA: 0x1808E5E10
	|-RBTree<object>.Key
	|
	|-RVA: 0x8F2D60 Offset: 0x8F1360 VA: 0x1808F2D60
	|-RBTree<__Il2CppFullySharedGenericType>.Key
	*/
}

// Namespace: System.Data
[DefaultMember("Item")]
internal sealed class RecordManager // TypeDefIndex: 8734
{
	// Fields
	private readonly DataTable _table; // 0x10
	private int _lastFreeRecord; // 0x18
	private int _minimumCapacity; // 0x1C
	private int _recordCapacity; // 0x20
	private readonly List<int> _freeRecordList; // 0x28
	private DataRow[] _rows; // 0x30

	// Properties
	internal int LastFreeRecord { get; }
	internal int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; set; }
	internal DataRow Item { get; set; }

	// Methods

	// RVA: 0x1B07280 Offset: 0x1B05880 VA: 0x181B07280
	internal void .ctor(DataTable table) { }

	// RVA: 0x1B06EF0 Offset: 0x1B054F0 VA: 0x181B06EF0
	private void GrowRecordCapacity() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	internal int get_LastFreeRecord() { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	internal int get_MinimumCapacity() { }

	// RVA: 0x1B07410 Offset: 0x1B05A10 VA: 0x181B07410
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	internal int get_RecordCapacity() { }

	// RVA: 0x1B07450 Offset: 0x1B05A50 VA: 0x181B07450
	internal void set_RecordCapacity(int value) { }

	// RVA: 0x1B07110 Offset: 0x1B05710 VA: 0x181B07110
	internal static int NewCapacity(int capacity) { }

	// RVA: 0x1B07200 Offset: 0x1B05800 VA: 0x181B07200
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0x1B07130 Offset: 0x1B05730 VA: 0x181B07130
	internal int NewRecordBase() { }

	// RVA: 0x1B06D80 Offset: 0x1B05380 VA: 0x181B06D80
	internal void FreeRecord(ref int record) { }

	// RVA: 0x1B06890 Offset: 0x1B04E90 VA: 0x181B06890
	internal void Clear(bool clearAll) { }

	// RVA: 0x1B07360 Offset: 0x1B05960 VA: 0x181B07360
	internal DataRow get_Item(int record) { }

	// RVA: 0x1B07390 Offset: 0x1B05990 VA: 0x181B07390
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0x1B070F0 Offset: 0x1B056F0 VA: 0x181B070F0
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0x1B06AA0 Offset: 0x1B050A0 VA: 0x181B06AA0
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0x1B07240 Offset: 0x1B05840 VA: 0x181B07240
	internal void SetRowCache(DataRow[] newRows) { }
}

// Namespace: System.Data
internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 8735
{
	// Fields
	private readonly Nullable<DataKey> _parentKey; // 0xB8
	private readonly DataKey _childKey; // 0xC8
	private readonly DataRowView _parentRowView; // 0xD0
	private readonly object[] _filterValues; // 0xD8

	// Methods

	// RVA: 0x1B077A0 Offset: 0x1B05DA0 VA: 0x181B077A0
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0x1B07910 Offset: 0x1B05F10 VA: 0x181B07910
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0x1B07570 Offset: 0x1B05B70 VA: 0x181B07570
	private object[] GetParentValues() { }

	// RVA: 0x1B07620 Offset: 0x1B05C20 VA: 0x181B07620 Slot: 50
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 44
	internal override IFilter GetFilter() { }

	// RVA: 0x1B07500 Offset: 0x1B05B00 VA: 0x181B07500 Slot: 43
	public override DataRowView AddNew() { }

	// RVA: 0x1B07770 Offset: 0x1B05D70 VA: 0x181B07770 Slot: 47
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }
}

// Namespace: System.Data
internal sealed class RelationshipConverter : ExpandableObjectConverter // TypeDefIndex: 8736
{
	// Methods

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }

	// RVA: 0x1B07A60 Offset: 0x1B06060 VA: 0x181B07A60 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1B07B00 Offset: 0x1B06100 VA: 0x181B07B00 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
public enum Rule // TypeDefIndex: 8737
{
	// Fields
	public int value__; // 0x0
	public const Rule None = 0;
	public const Rule Cascade = 1;
	public const Rule SetNull = 2;
	public const Rule SetDefault = 3;
}

// Namespace: System.Data
public enum SchemaSerializationMode // TypeDefIndex: 8738
{
	// Fields
	public int value__; // 0x0
	public const SchemaSerializationMode IncludeSchema = 1;
	public const SchemaSerializationMode ExcludeSchema = 2;
}

// Namespace: System.Data
[IsReadOnly]
internal struct IndexField // TypeDefIndex: 8739
{
	// Fields
	public readonly DataColumn Column; // 0x0
	public readonly bool IsDescending; // 0x8

	// Methods

	// RVA: 0xB1E970 Offset: 0xB1CF70 VA: 0x180B1E970
	internal void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0x1AFEC40 Offset: 0x1AFD240 VA: 0x181AFEC40
	public static bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0x1AFEB40 Offset: 0x1AFD140 VA: 0x181AFEB40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AFEBE0 Offset: 0x1AFD1E0 VA: 0x181AFEBE0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Data
internal sealed class Index // TypeDefIndex: 8743
{
	// Fields
	private readonly DataTable _table; // 0x10
	internal readonly IndexField[] _indexFields; // 0x18
	private readonly Comparison<DataRow> _comparison; // 0x20
	private readonly DataViewRowState _recordStates; // 0x28
	private WeakReference _rowFilter; // 0x30
	private Index.IndexTree _records; // 0x38
	private int _recordCount; // 0x40
	private int _refCount; // 0x44
	private Listeners<DataViewListener> _listeners; // 0x48
	private bool _suspendEvents; // 0x50
	private readonly bool _isSharable; // 0x51
	private readonly bool _hasRemoteAggregate; // 0x52
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x54

	// Properties
	internal bool HasRemoteAggregate { get; }
	internal int ObjectID { get; }
	public DataViewRowState RecordStates { get; }
	public IFilter RowFilter { get; }
	public bool HasDuplicates { get; }
	public int RecordCount { get; }
	public int RefCount { get; }
	private bool DoListChanged { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x1B027D0 Offset: 0x1B00DD0 VA: 0x181B027D0
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1B02350 Offset: 0x1B00950 VA: 0x181B02350
	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1B00080 Offset: 0x1AFE680 VA: 0x181B00080
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0x1B024A0 Offset: 0x1B00AA0 VA: 0x181B024A0
	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1AFF820 Offset: 0x1AFDE20 VA: 0x181AFF820
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1B028C0 Offset: 0x1B00EC0 VA: 0x181B028C0
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0x464C80 Offset: 0x463280 VA: 0x180464C80
	internal int get_ObjectID() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public DataViewRowState get_RecordStates() { }

	// RVA: 0x1B028D0 Offset: 0x1B00ED0 VA: 0x181B028D0
	public IFilter get_RowFilter() { }

	// RVA: 0x1B005C0 Offset: 0x1AFEBC0 VA: 0x181B005C0
	public int GetRecord(int recordIndex) { }

	// RVA: 0x1B02870 Offset: 0x1B00E70 VA: 0x181B02870
	public bool get_HasDuplicates() { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	public int get_RecordCount() { }

	// RVA: 0x1AFEE50 Offset: 0x1AFD450 VA: 0x181AFEE50
	private bool AcceptRecord(int record) { }

	// RVA: 0x1AFED00 Offset: 0x1AFD300 VA: 0x181AFED00
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0x1B01350 Offset: 0x1AFF950 VA: 0x181B01350
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0x1B013B0 Offset: 0x1AFF9B0 VA: 0x181B013B0
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0x15EEFB0 Offset: 0x15ED5B0 VA: 0x1815EEFB0
	public int get_RefCount() { }

	// RVA: 0x1AFEE80 Offset: 0x1AFD480 VA: 0x181AFEE80
	public void AddRef() { }

	// RVA: 0x1B01FC0 Offset: 0x1B005C0 VA: 0x181B01FC0
	public int RemoveRef() { }

	// RVA: 0x1AFF080 Offset: 0x1AFD680 VA: 0x181AFF080
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0x1AFF150 Offset: 0x1AFD750 VA: 0x181AFF150
	public bool CheckUnique() { }

	// RVA: 0x1AFF4E0 Offset: 0x1AFDAE0 VA: 0x181AFF4E0
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0x1AFF1A0 Offset: 0x1AFD7A0 VA: 0x181AFF1A0
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0x1AFF220 Offset: 0x1AFD820 VA: 0x181AFF220
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0x1AFF400 Offset: 0x1AFDA00 VA: 0x181AFF400
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0x1AFF6E0 Offset: 0x1AFDCE0 VA: 0x181AFF6E0
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0x1AFF810 Offset: 0x1AFDE10 VA: 0x181AFF810
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0x1AFF6F0 Offset: 0x1AFDCF0 VA: 0x181AFF6F0
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0x1B001A0 Offset: 0x1AFE7A0 VA: 0x181B001A0
	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	// RVA: 0x1B00210 Offset: 0x1AFE810 VA: 0x181B00210
	public int GetIndex(int record) { }

	// RVA: 0x1B00270 Offset: 0x1AFE870 VA: 0x181B00270
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0x1B008E0 Offset: 0x1AFEEE0 VA: 0x181B008E0
	public object[] GetUniqueKeyValues() { }

	// RVA: 0x1AFF9B0 Offset: 0x1AFDFB0 VA: 0x181AFF9B0
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0x1AFFBC0 Offset: 0x1AFE1C0 VA: 0x181AFFBC0
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0x1AFF8D0 Offset: 0x1AFDED0 VA: 0x181AFF8D0
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0x1B00440 Offset: 0x1AFEA40 VA: 0x181B00440
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0x1AFFF00 Offset: 0x1AFE500 VA: 0x181AFFF00
	public Range FindRecords(object key) { }

	// RVA: 0x1AFFEB0 Offset: 0x1AFE4B0 VA: 0x181AFFEB0
	public Range FindRecords(object[] key) { }

	// RVA: 0x1AFFF50 Offset: 0x1AFE550 VA: 0x181AFFF50
	internal void FireResetEvent() { }

	// RVA: 0x1B00180 Offset: 0x1AFE780 VA: 0x181B00180
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x1B00620 Offset: 0x1AFEC20 VA: 0x181B00620
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0x1B00640 Offset: 0x1AFEC40 VA: 0x181B00640
	public DataRow GetRow(int i) { }

	// RVA: 0x1B00890 Offset: 0x1AFEE90 VA: 0x181B00890
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0x1B006D0 Offset: 0x1AFECD0 VA: 0x181B006D0
	public DataRow[] GetRows(Range range) { }

	// RVA: 0x1B00C00 Offset: 0x1AFF200 VA: 0x181B00C00
	private void InitRecords(IFilter filter) { }

	// RVA: 0x1B00FA0 Offset: 0x1AFF5A0 VA: 0x181B00FA0
	public int InsertRecordToIndex(int record) { }

	// RVA: 0x1B01000 Offset: 0x1AFF600 VA: 0x181B01000
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0x1B01230 Offset: 0x1AFF830 VA: 0x181B01230
	public bool IsKeyInIndex(object key) { }

	// RVA: 0x1B01250 Offset: 0x1AFF850 VA: 0x181B01250
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0x1B01270 Offset: 0x1AFF870 VA: 0x181B01270
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0x1B02800 Offset: 0x1B00E00 VA: 0x181B02800
	private bool get_DoListChanged() { }

	// RVA: 0x1B01610 Offset: 0x1AFFC10 VA: 0x181B01610
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0x1B01540 Offset: 0x1AFFB40 VA: 0x181B01540
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0x1B01700 Offset: 0x1AFFD00 VA: 0x181B01700
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1B01410 Offset: 0x1AFFA10 VA: 0x181B01410
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0x1B02170 Offset: 0x1B00770 VA: 0x181B02170
	public void Reset() { }

	// RVA: 0x1B019F0 Offset: 0x1AFFFF0 VA: 0x181B019F0
	public void RecordChanged(int record) { }

	// RVA: 0x1B018B0 Offset: 0x1AFFEB0 VA: 0x181B018B0
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0x1B01EB0 Offset: 0x1B004B0 VA: 0x181B01EB0
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x1B01B30 Offset: 0x1B00130 VA: 0x181B01B30
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal DataTable get_Table() { }

	// RVA: 0x1B009B0 Offset: 0x1AFEFB0 VA: 0x181B009B0
	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	// RVA: -1 Offset: -1
	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70C150 Offset: 0x70A750 VA: 0x18070C150
	|-Index.IndexOfReference<object>
	*/
}

// Namespace: System.Data
internal sealed class Listeners<TElem> // TypeDefIndex: 8746
{
	// Fields
	private readonly List<TElem> _listeners; // 0x0
	private readonly Listeners.Func<TElem, TElem, bool> _filter; // 0x0
	private readonly int _objectID; // 0x0
	private int _listenerReaderCount; // 0x0

	// Properties
	internal bool HasListeners { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int ObjectID, Listeners.Func<TElem, TElem, bool> notifyFilter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12799F0 Offset: 0x1277FF0 VA: 0x1812799F0
	|-Listeners<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279AB0 Offset: 0x12780B0 VA: 0x181279AB0
	|-Listeners<object>.get_HasListeners
	*/

	// RVA: -1 Offset: -1
	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279810 Offset: 0x1277E10 VA: 0x181279810
	|-Listeners<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279890 Offset: 0x1277E90 VA: 0x181279890
	|-Listeners<object>.IndexOfReference
	*/

	// RVA: -1 Offset: -1
	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1279930 Offset: 0x1277F30 VA: 0x181279930
	|-Listeners<object>.Remove
	*/

	// RVA: -1 Offset: -1
	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x604C40 Offset: 0x603240 VA: 0x180604C40
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-RVA: 0x604E30 Offset: 0x603430 VA: 0x180604E30
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-RVA: 0x6048E0 Offset: 0x602EE0 VA: 0x1806048E0
	|-Listeners<object>.Notify<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12798B0 Offset: 0x1277EB0 VA: 0x1812798B0
	|-Listeners<object>.RemoveNullListeners
	*/
}

// Namespace: System.Data
[Serializable]
internal sealed class SimpleType : ISerializable // TypeDefIndex: 8747
{
	// Fields
	private string _baseType; // 0x10
	private SimpleType _baseSimpleType; // 0x18
	private XmlQualifiedName _xmlBaseType; // 0x20
	private string _name; // 0x28
	private int _length; // 0x30
	private int _minLength; // 0x34
	private int _maxLength; // 0x38
	private string _pattern; // 0x40
	private string _ns; // 0x48
	private string _maxExclusive; // 0x50
	private string _maxInclusive; // 0x58
	private string _minExclusive; // 0x60
	private string _minInclusive; // 0x68
	internal string _enumeration; // 0x70

	// Properties
	internal string BaseType { get; }
	internal XmlQualifiedName XmlBaseType { get; }
	internal string Name { get; }
	internal string Namespace { get; }
	internal int Length { get; }
	internal int MaxLength { get; set; }
	internal SimpleType BaseSimpleType { get; }
	public string SimpleTypeQualifiedName { get; }

	// Methods

	// RVA: 0x1B09D60 Offset: 0x1B08360 VA: 0x181B09D60
	internal void .ctor(string baseType) { }

	// RVA: 0x1B09EA0 Offset: 0x1B084A0 VA: 0x181B09EA0
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0x1B09810 Offset: 0x1B07E10 VA: 0x181B09810 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B08ED0 Offset: 0x1B074D0 VA: 0x181B08ED0
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0x1B08DC0 Offset: 0x1B073C0 VA: 0x181B08DC0
	internal bool IsPlainString() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal string get_BaseType() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal string get_Name() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal string get_Namespace() { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	internal int get_Length() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	internal int get_MaxLength() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	internal void set_MaxLength(int value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0x1B0A080 Offset: 0x1B08680 VA: 0x181B0A080
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0x1B097A0 Offset: 0x1B07DA0 VA: 0x181B097A0
	internal string QualifiedName(string name) { }

	// RVA: 0x1B09850 Offset: 0x1B07E50 VA: 0x181B09850
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0x1B08AE0 Offset: 0x1B070E0 VA: 0x181B08AE0
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0x1B08A80 Offset: 0x1B07080 VA: 0x181B08A80
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0x1B08B60 Offset: 0x1B07160 VA: 0x181B08B60
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0x1B08BE0 Offset: 0x1B071E0 VA: 0x181B08BE0
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0x1B08CB0 Offset: 0x1B072B0 VA: 0x181B08CB0
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0x1B08960 Offset: 0x1B06F60 VA: 0x181B08960
	internal bool CanHaveMaxLength() { }

	// RVA: 0x1B089D0 Offset: 0x1B06FD0 VA: 0x181B089D0
	internal void ConvertToAnnonymousSimpleType() { }
}

// Namespace: System.Data
[DefaultProperty("ConstraintName")]
public class UniqueConstraint : Constraint // TypeDefIndex: 8748
{
	// Fields
	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48
	internal string _constraintName; // 0x50
	internal string[] _columnNames; // 0x58

	// Properties
	internal string[] ColumnNames { get; }
	internal Index ConstraintIndex { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	internal DataColumn[] ColumnsReference { get; }
	public bool IsPrimaryKey { get; }
	internal override bool InCollection { set; }
	internal DataKey Key { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }

	// Methods

	// RVA: 0x1B0C0F0 Offset: 0x1B0A6F0 VA: 0x181B0C0F0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B0C1B0 Offset: 0x1B0A7B0 VA: 0x181B0C1B0
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0x1B0C0B0 Offset: 0x1B0A6B0 VA: 0x181B0C0B0
	public void .ctor(DataColumn[] columns) { }

	[Browsable(False)]
	// RVA: 0x1B0C240 Offset: 0x1B0A840 VA: 0x181B0C240
	public void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0x1B0C1F0 Offset: 0x1B0A7F0 VA: 0x181B0C1F0
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0x1B0C2B0 Offset: 0x1B0A8B0 VA: 0x181B0C2B0
	internal string[] get_ColumnNames() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal Index get_ConstraintIndex() { }

	// RVA: 0x1B0BB80 Offset: 0x1B0A180 VA: 0x181B0BB80
	internal void ConstraintIndexClear() { }

	// RVA: 0x1B0BBC0 Offset: 0x1B0A1C0 VA: 0x181B0BBC0
	internal void ConstraintIndexInitialize() { }

	// RVA: 0x1B0B260 Offset: 0x1B09860 VA: 0x181B0B260 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x1B0B260 Offset: 0x1B09860 VA: 0x181B0B260
	private void NonVirtualCheckState() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x1B0AE30 Offset: 0x1B09430 VA: 0x181B0AE30 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x1B0AFF0 Offset: 0x1B095F0 VA: 0x181B0AFF0 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x1B0BDF0 Offset: 0x1B0A3F0 VA: 0x181B0BDF0 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x1B0B080 Offset: 0x1B09680 VA: 0x181B0B080 Slot: 15
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x1B0BC10 Offset: 0x1B0A210 VA: 0x181B0BC10 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1AFD810 Offset: 0x1AFBE10 VA: 0x181AFD810 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x1B0B690 Offset: 0x1B09C90 VA: 0x181B0B690 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x1B0B270 Offset: 0x1B09870 VA: 0x181B0B270
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0x1B0C2C0 Offset: 0x1B0A8C0 VA: 0x181B0C2C0 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x1B0C2D0 Offset: 0x1B0A8D0 VA: 0x181B0C2D0
	public bool get_IsPrimaryKey() { }

	// RVA: 0x1B0BC20 Offset: 0x1B0A220 VA: 0x181B0BC20
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0x1B0BD30 Offset: 0x1B0A330 VA: 0x181B0BD30 Slot: 0
	public override bool Equals(object key2) { }

	// RVA: 0x137F480 Offset: 0x137DA80 VA: 0x18137F480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B0C360 Offset: 0x1B0A960 VA: 0x181B0C360 Slot: 7
	internal override void set_InCollection(bool value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal DataKey get_Key() { }

	// RVA: 0x1B0C330 Offset: 0x1B0A930 VA: 0x181B0C330 Slot: 8
	public override DataTable get_Table() { }
}

// Namespace: System.Data
internal sealed class XDRSchema : XMLSchema // TypeDefIndex: 8750
{
	// Fields
	internal string _schemaName; // 0x10
	internal string _schemaUri; // 0x18
	internal XmlElement _schemaRoot; // 0x20
	internal DataSet _ds; // 0x28
	private static readonly char[] s_colonArray; // 0x0
	private static XDRSchema.NameType[] s_mapNameTypeXdr; // 0x8
	private static XDRSchema.NameType s_enumerationNameType; // 0x10

	// Methods

	// RVA: 0x1B10EC0 Offset: 0x1B0F4C0 VA: 0x181B10EC0
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0x1B0ECD0 Offset: 0x1B0D2D0 VA: 0x181B0ECD0
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0x1B0C490 Offset: 0x1B0AA90 VA: 0x181B0C490
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0x1B0E790 Offset: 0x1B0CD90 VA: 0x181B0E790
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0x1B0E950 Offset: 0x1B0CF50 VA: 0x181B0E950
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0x1B0DB70 Offset: 0x1B0C170 VA: 0x181B0DB70
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0x1B0C3B0 Offset: 0x1B0A9B0 VA: 0x181B0C3B0
	private static XDRSchema.NameType FindNameType(string name) { }

	// RVA: 0x1B0FA10 Offset: 0x1B0E010 VA: 0x181B0FA10
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0x1B0C960 Offset: 0x1B0AF60 VA: 0x181B0C960
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0x1B0CF80 Offset: 0x1B0B580 VA: 0x181B0CF80
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0x1B0CF50 Offset: 0x1B0B550 VA: 0x181B0CF50
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x1B0CB90 Offset: 0x1B0B190 VA: 0x181B0CB90
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x1B0DD30 Offset: 0x1B0C330 VA: 0x181B0DD30
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0x1B0E1A0 Offset: 0x1B0C7A0 VA: 0x181B0E1A0
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0x1B0DF40 Offset: 0x1B0C540 VA: 0x181B0DF40
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0x1B0FB60 Offset: 0x1B0E160 VA: 0x181B0FB60
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class XMLDiffLoader // TypeDefIndex: 8751
{
	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0x1B11450 Offset: 0x1B0FA50 VA: 0x181B11450
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0x1B10F40 Offset: 0x1B0F540 VA: 0x181B10F40
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1B115E0 Offset: 0x1B0FBE0 VA: 0x181B115E0
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0x1B117E0 Offset: 0x1B0FDE0 VA: 0x181B117E0
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0x1B11B80 Offset: 0x1B10180 VA: 0x181B11B80
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0x1B12420 Offset: 0x1B10A20 VA: 0x181B12420
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0x1B11ED0 Offset: 0x1B104D0 VA: 0x181B11ED0
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0x1B11240 Offset: 0x1B0F840 VA: 0x181B11240
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0x1B12840 Offset: 0x1B10E40 VA: 0x181B12840
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0x1B13780 Offset: 0x1B11D80 VA: 0x181B13780
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Data
internal class XMLSchema // TypeDefIndex: 8752
{
	// Methods

	// RVA: 0x1B13AF0 Offset: 0x1B120F0 VA: 0x181B13AF0
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0x1B13B40 Offset: 0x1B12140 VA: 0x181B13B40
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0x1B137F0 Offset: 0x1B11DF0 VA: 0x181B137F0
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0x1B139B0 Offset: 0x1B11FB0 VA: 0x181B139B0
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0x1B13880 Offset: 0x1B11E80 VA: 0x181B13880
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Data
internal sealed class ConstraintTable // TypeDefIndex: 8753
{
	// Fields
	public DataTable table; // 0x10
	public XmlSchemaIdentityConstraint constraint; // 0x18

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(DataTable t, XmlSchemaIdentityConstraint c) { }
}

// Namespace: System.Data
internal sealed class XSDSchema : XMLSchema // TypeDefIndex: 8755
{
	// Fields
	private XmlSchemaSet _schemaSet; // 0x10
	private XmlSchemaElement _dsElement; // 0x18
	private DataSet _ds; // 0x20
	private string _schemaName; // 0x28
	private ArrayList _columnExpressions; // 0x30
	private Hashtable _constraintNodes; // 0x38
	private ArrayList _refTables; // 0x40
	private ArrayList _complexTypes; // 0x48
	private XmlSchemaObjectCollection _annotations; // 0x50
	private XmlSchemaObjectCollection _elements; // 0x58
	private Hashtable _attributes; // 0x60
	private Hashtable _elementsTable; // 0x68
	private Hashtable _attributeGroups; // 0x70
	private Hashtable _schemaTypes; // 0x78
	private Hashtable _expressions; // 0x80
	private Dictionary<DataTable, List<DataTable>> _tableDictionary; // 0x88
	private Hashtable _udSimpleTypes; // 0x90
	private Hashtable _existingSimpleTypeMap; // 0x98
	private bool _fromInference; // 0xA0
	private static readonly XSDSchema.NameType[] s_mapNameTypeXsd; // 0x0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x156F940 Offset: 0x156DF40 VA: 0x18156F940
	internal bool get_FromInference() { }

	// RVA: 0x163E120 Offset: 0x163C720 VA: 0x18163E120
	internal void set_FromInference(bool value) { }

	// RVA: 0x1B14DA0 Offset: 0x1B133A0 VA: 0x181B14DA0
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0x1B14420 Offset: 0x1B12A20 VA: 0x181B14420
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0x1B24A50 Offset: 0x1B23050 VA: 0x181B24A50
	internal static string QualifiedName(string name) { }

	// RVA: 0x1B250E0 Offset: 0x1B236E0 VA: 0x181B250E0
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x1B24D30 Offset: 0x1B23330 VA: 0x181B24D30
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x1B17F00 Offset: 0x1B16500 VA: 0x181B17F00
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x1B15EF0 Offset: 0x1B144F0 VA: 0x181B15EF0
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0x1B24AC0 Offset: 0x1B230C0 VA: 0x181B24AC0
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0x1B1CA10 Offset: 0x1B1B010 VA: 0x181B1CA10
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0x1B1CB10 Offset: 0x1B1B110 VA: 0x181B1CB10
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0x1B1EA40 Offset: 0x1B1D040 VA: 0x181B1EA40
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1B22100 Offset: 0x1B20700 VA: 0x181B22100
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0x1B14E30 Offset: 0x1B13430 VA: 0x181B14E30
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0x1B15020 Offset: 0x1B13620 VA: 0x181B15020
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0x1B24770 Offset: 0x1B22D70 VA: 0x181B24770
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0x1B22B40 Offset: 0x1B21140 VA: 0x181B22B40
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0x1B1D490 Offset: 0x1B1BA90 VA: 0x181B1D490
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0x1B16300 Offset: 0x1B14900 VA: 0x181B16300
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0x1B1BAF0 Offset: 0x1B1A0F0 VA: 0x181B1BAF0
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0x1B17C30 Offset: 0x1B16230 VA: 0x181B17C30
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0x1B17890 Offset: 0x1B15E90 VA: 0x181B17890
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0x1B18110 Offset: 0x1B16710 VA: 0x181B18110
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0x1B165D0 Offset: 0x1B14BD0 VA: 0x181B165D0
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0x1B155A0 Offset: 0x1B13BA0 VA: 0x181B155A0
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0x1B141A0 Offset: 0x1B127A0 VA: 0x181B141A0
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0x1B15C40 Offset: 0x1B14240 VA: 0x181B15C40
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0x1B16A30 Offset: 0x1B15030 VA: 0x181B16A30
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0x1B255D0 Offset: 0x1B23BD0 VA: 0x181B255D0
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0x1B25640 Offset: 0x1B23C40 VA: 0x181B25640
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0x1B1B180 Offset: 0x1B19780 VA: 0x181B1B180
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0x1B189C0 Offset: 0x1B16FC0 VA: 0x181B189C0
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0x1B1ECB0 Offset: 0x1B1D2B0 VA: 0x181B1ECB0
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0x1B15DA0 Offset: 0x1B143A0 VA: 0x181B15DA0
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0x1B1FCE0 Offset: 0x1B1E2E0 VA: 0x181B1FCE0
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0x1B25710 Offset: 0x1B23D10 VA: 0x181B25710
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0x1B15760 Offset: 0x1B13D60 VA: 0x181B15760
	private static XSDSchema.NameType FindNameType(string name) { }

	// RVA: 0x1B247A0 Offset: 0x1B22DA0 VA: 0x181B247A0
	private Type ParseDataType(string dt) { }

	// RVA: 0x1B22AD0 Offset: 0x1B210D0 VA: 0x181B22AD0
	internal static bool IsXsdType(string name) { }

	// RVA: 0x1B15840 Offset: 0x1B13E40 VA: 0x181B15840
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0x1B1DEC0 Offset: 0x1B1C4C0 VA: 0x181B1DEC0
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x1B1D750 Offset: 0x1B1BD50 VA: 0x181B1D750
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x1B16D60 Offset: 0x1B15360 VA: 0x181B16D60
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0x1B1A250 Offset: 0x1B18850 VA: 0x181B1A250
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0x1B18EA0 Offset: 0x1B174A0 VA: 0x181B18EA0
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0x1B14000 Offset: 0x1B12600 VA: 0x181B14000
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	// RVA: 0x1B16770 Offset: 0x1B14D70 VA: 0x181B16770
	private string GetPrefix(string ns) { }

	// RVA: 0x1B16030 Offset: 0x1B14630 VA: 0x181B16030
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0x1B16BD0 Offset: 0x1B151D0 VA: 0x181B16BD0
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x1B16AB0 Offset: 0x1B150B0 VA: 0x181B16AB0
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x1B227F0 Offset: 0x1B20DF0 VA: 0x181B227F0
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0x1B1E880 Offset: 0x1B1CE80 VA: 0x181B1E880
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x1B25800 Offset: 0x1B23E00 VA: 0x181B25800
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader // TypeDefIndex: 8756
{
	// Fields
	private List<string> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0x1B2D980 Offset: 0x1B2BF80 VA: 0x181B2D980
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0x1B2D740 Offset: 0x1B2BD40 VA: 0x181B2D740 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1B2D860 Offset: 0x1B2BE60 VA: 0x181B2D860 Slot: 30
	public override bool MoveToNextAttribute() { }
}

// Namespace: System.Data
internal sealed class XmlDataLoader // TypeDefIndex: 8757
{
	// Fields
	private DataSet _dataSet; // 0x10
	private XmlToDatasetMap _nodeToSchemaMap; // 0x18
	private Hashtable _nodeToRowMap; // 0x20
	private Stack _childRowsStack; // 0x28
	private Hashtable _htableExcludedNS; // 0x30
	private bool _fIsXdr; // 0x38
	internal bool _isDiffgram; // 0x39
	private XmlElement _topMostNode; // 0x40
	private bool _ignoreSchema; // 0x48
	private DataTable _dataTable; // 0x50
	private bool _isTableLevel; // 0x58
	private bool _fromInference; // 0x59
	private XmlReader _dataReader; // 0x60
	private object _XSD_XMLNS_NS; // 0x68
	private object _XDR_SCHEMA; // 0x70
	private object _XDRNS; // 0x78
	private object _SQL_SYNC; // 0x80
	private object _UPDGNS; // 0x88
	private object _XSD_SCHEMA; // 0x90
	private object _XSDNS; // 0x98
	private object _DFFNS; // 0xA0
	private object _MSDNS; // 0xA8
	private object _DIFFID; // 0xB0
	private object _HASCHANGES; // 0xB8
	private object _ROWORDER; // 0xC0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x1B2D3E0 Offset: 0x1B2B9E0 VA: 0x181B2D3E0
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1B2D650 Offset: 0x1B2BC50 VA: 0x181B2D650
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x1B2D480 Offset: 0x1B2BA80 VA: 0x181B2D480
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1B2D540 Offset: 0x1B2BB40 VA: 0x181B2D540
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x140E320 Offset: 0x140C920 VA: 0x18140E320
	internal bool get_FromInference() { }

	// RVA: 0x163E0E0 Offset: 0x163C6E0 VA: 0x18163E0E0
	internal void set_FromInference(bool value) { }

	// RVA: 0x1B26EB0 Offset: 0x1B254B0 VA: 0x181B26EB0
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1B27040 Offset: 0x1B25640 VA: 0x181B27040
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0x1B279B0 Offset: 0x1B25FB0 VA: 0x181B279B0
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0x1B27550 Offset: 0x1B25B50 VA: 0x181B27550
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0x1B27900 Offset: 0x1B25F00 VA: 0x181B27900
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0x1B27850 Offset: 0x1B25E50 VA: 0x181B27850
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0x1B271F0 Offset: 0x1B257F0 VA: 0x181B271F0
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0x1B27310 Offset: 0x1B25910 VA: 0x181B27310
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0x1B27440 Offset: 0x1B25A40 VA: 0x181B27440
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0x1B273B0 Offset: 0x1B259B0 VA: 0x181B273B0
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0x1B27FC0 Offset: 0x1B265C0 VA: 0x181B27FC0
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0x1B28020 Offset: 0x1B26620 VA: 0x181B28020
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0x1B28B00 Offset: 0x1B27100 VA: 0x181B28B00
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0x1B291D0 Offset: 0x1B277D0 VA: 0x181B291D0
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0x1B2A9A0 Offset: 0x1B28FA0 VA: 0x181B2A9A0
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1B2D390 Offset: 0x1B2B990 VA: 0x181B2D390
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0x1B27C70 Offset: 0x1B26270 VA: 0x181B27C70
	private void InitNameTable() { }

	// RVA: 0x1B28DF0 Offset: 0x1B273F0 VA: 0x181B28DF0
	internal void LoadData(XmlReader reader) { }

	// RVA: 0x1B2C4F0 Offset: 0x1B2AAF0 VA: 0x181B2C4F0
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0x1B2B5F0 Offset: 0x1B29BF0 VA: 0x181B2B5F0
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0x1B28060 Offset: 0x1B26660 VA: 0x181B28060
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0x1B2D140 Offset: 0x1B2B740 VA: 0x181B2D140
	private bool ProcessXsdSchema() { }
}

// Namespace: System.Data
public enum XmlReadMode // TypeDefIndex: 8758
{
	// Fields
	public int value__; // 0x0
	public const XmlReadMode Auto = 0;
	public const XmlReadMode ReadSchema = 1;
	public const XmlReadMode IgnoreSchema = 2;
	public const XmlReadMode InferSchema = 3;
	public const XmlReadMode DiffGram = 4;
	public const XmlReadMode Fragment = 5;
	public const XmlReadMode InferTypedSchema = 6;
}

// Namespace: System.Data
internal sealed class XmlToDatasetMap // TypeDefIndex: 8762
{
	// Fields
	private XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0x1B31280 Offset: 0x1B2F880 VA: 0x181B31280
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1B31200 Offset: 0x1B2F800 VA: 0x181B31200
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1B312C0 Offset: 0x1B2F8C0 VA: 0x181B312C0
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1B31240 Offset: 0x1B2F840 VA: 0x181B31240
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1B311D0 Offset: 0x1B2F7D0 VA: 0x181B311D0
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0x1B2DE60 Offset: 0x1B2C460 VA: 0x181B2DE60
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0x1B2DFC0 Offset: 0x1B2C5C0 VA: 0x181B2DFC0
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0x1B2DAC0 Offset: 0x1B2C0C0 VA: 0x181B2DAC0
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1B2DC40 Offset: 0x1B2C240 VA: 0x181B2DC40
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1B2E190 Offset: 0x1B2C790 VA: 0x181B2E190
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1B2EE80 Offset: 0x1B2D480 VA: 0x181B2EE80
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1B2E930 Offset: 0x1B2CF30 VA: 0x181B2E930
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1B2FB00 Offset: 0x1B2E100 VA: 0x181B2FB00
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1B30BF0 Offset: 0x1B2F1F0 VA: 0x181B30BF0
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0x1B30750 Offset: 0x1B2ED50 VA: 0x181B30750
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1B30960 Offset: 0x1B2EF60 VA: 0x181B30960
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0x1B30AF0 Offset: 0x1B2F0F0 VA: 0x181B30AF0
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1B30F40 Offset: 0x1B2F540 VA: 0x181B30F40
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0x1B31030 Offset: 0x1B2F630 VA: 0x181B31030
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }
}

// Namespace: System.Data
public enum XmlWriteMode // TypeDefIndex: 8763
{
	// Fields
	public int value__; // 0x0
	public const XmlWriteMode WriteSchema = 0;
	public const XmlWriteMode IgnoreSchema = 1;
	public const XmlWriteMode DiffGram = 2;
}

// Namespace: System.Data
internal enum SchemaFormat // TypeDefIndex: 8764
{
	// Fields
	public int value__; // 0x0
	public const SchemaFormat Public = 1;
	public const SchemaFormat Remoting = 2;
	public const SchemaFormat WebService = 3;
	public const SchemaFormat RemotingSkipSchema = 4;
	public const SchemaFormat WebServiceSkipSchema = 5;
}

// Namespace: System.Data
internal sealed class XmlTreeGen // TypeDefIndex: 8765
{
	// Fields
	private ArrayList _constraintNames; // 0x10
	private Hashtable _namespaces; // 0x18
	private Hashtable _autogenerated; // 0x20
	private Hashtable _prefixes; // 0x28
	private DataSet _ds; // 0x30
	private ArrayList _tables; // 0x38
	private ArrayList _relations; // 0x40
	private XmlDocument _dc; // 0x48
	private XmlElement _sRoot; // 0x50
	private int _prefixCount; // 0x58
	private SchemaFormat _schFormat; // 0x5C
	private string _filePath; // 0x60
	private string _fileName; // 0x68
	private string _fileExt; // 0x70
	private XmlElement _dsElement; // 0x78
	private XmlElement _constraintSeparator; // 0x80
	private Converter<Type, string> _targetConverter; // 0x88

	// Methods

	// RVA: 0x1B48F20 Offset: 0x1B47520 VA: 0x181B48F20
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0x1B3BBA0 Offset: 0x1B3A1A0 VA: 0x181B3BBA0
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0x1B3BBB0 Offset: 0x1B3A1B0 VA: 0x181B3BBB0
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0x1B3C1B0 Offset: 0x1B3A7B0 VA: 0x181B3C1B0
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1B3C370 Offset: 0x1B3A970 VA: 0x181B3C370
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1B48250 Offset: 0x1B46850 VA: 0x181B48250
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0x1B3ED70 Offset: 0x1B3D370 VA: 0x181B3ED70
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0x1B3EA30 Offset: 0x1B3D030 VA: 0x181B3EA30
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0x1B3EB30 Offset: 0x1B3D130 VA: 0x181B3EB30
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0x1B48EF0 Offset: 0x1B474F0 VA: 0x181B48EF0
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0x1B43780 Offset: 0x1B41D80 VA: 0x181B43780
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0x1B48040 Offset: 0x1B46640 VA: 0x181B48040
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0x1B47FC0 Offset: 0x1B465C0 VA: 0x181B47FC0
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0x1B46E50 Offset: 0x1B45450 VA: 0x181B46E50
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0x1B47DB0 Offset: 0x1B463B0 VA: 0x181B47DB0
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0x1B47090 Offset: 0x1B45690 VA: 0x181B47090
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0x1B3D8F0 Offset: 0x1B3BEF0 VA: 0x181B3D8F0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1B3D620 Offset: 0x1B3BC20 VA: 0x181B3D620
	private void CreateRelations(DataTable dt) { }

	// RVA: 0x1B3DBF0 Offset: 0x1B3C1F0 VA: 0x181B3DBF0
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1B442A0 Offset: 0x1B428A0 VA: 0x181B442A0
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1B43D90 Offset: 0x1B42390 VA: 0x181B43D90
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0x1B3DF00 Offset: 0x1B3C500 VA: 0x181B3DF00
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0x1B46B90 Offset: 0x1B45190 VA: 0x181B46B90
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0x1B43C90 Offset: 0x1B42290 VA: 0x181B43C90
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0x1B43CC0 Offset: 0x1B422C0 VA: 0x181B43CC0
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0x1B43B10 Offset: 0x1B42110 VA: 0x181B43B10
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0x1B439B0 Offset: 0x1B41FB0 VA: 0x181B439B0
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0x1B43B30 Offset: 0x1B42130 VA: 0x181B43B30
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x1B403B0 Offset: 0x1B3E9B0 VA: 0x181B403B0
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0x1B3E5F0 Offset: 0x1B3CBF0 VA: 0x181B3E5F0
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0x1B3F1B0 Offset: 0x1B3D7B0 VA: 0x181B3F1B0
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0x1B3F450 Offset: 0x1B3DA50 VA: 0x181B3F450
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0x1B3B550 Offset: 0x1B39B50 VA: 0x181B3B550
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0x1B3E720 Offset: 0x1B3CD20 VA: 0x181B3E720
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0x1B3F8E0 Offset: 0x1B3DEE0 VA: 0x181B3F8E0
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0x1B47EC0 Offset: 0x1B464C0 VA: 0x181B47EC0
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0x1B47F20 Offset: 0x1B46520 VA: 0x181B47F20
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0x1B3CCF0 Offset: 0x1B3B2F0 VA: 0x181B3CCF0
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0x1B3E840 Offset: 0x1B3CE40 VA: 0x181B3E840
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0x1B434B0 Offset: 0x1B41AB0 VA: 0x181B434B0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0x1B434D0 Offset: 0x1B41AD0 VA: 0x181B434D0
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0x1B3D1E0 Offset: 0x1B3B7E0 VA: 0x181B3D1E0
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0x1B3D0D0 Offset: 0x1B3B6D0 VA: 0x181B3D0D0
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0x1B3CDA0 Offset: 0x1B3B3A0 VA: 0x181B3CDA0
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0x1B3CE70 Offset: 0x1B3B470 VA: 0x181B3CE70
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0x1B3CE80 Offset: 0x1B3B480 VA: 0x181B3CE80
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0x1B43970 Offset: 0x1B41F70 VA: 0x181B43970
	private bool IsAutoGenerated(object o) { }

	// RVA: 0x1B409C0 Offset: 0x1B3EFC0 VA: 0x181B409C0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0x1B469B0 Offset: 0x1B44FB0 VA: 0x181B469B0
	private void SetMSDataAttribute(XmlElement root, Type type) { }
}

// Namespace: System.Data
internal sealed class NewDiffgramGen // TypeDefIndex: 8766
{
	// Fields
	internal XmlDocument _doc; // 0x10
	internal DataSet _ds; // 0x18
	internal DataTable _dt; // 0x20
	internal XmlWriter _xmlw; // 0x28
	private bool _fBefore; // 0x30
	private bool _fErrors; // 0x31
	internal Hashtable _rowsOrder; // 0x38
	private ArrayList _tables; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x1B34270 Offset: 0x1B32870 VA: 0x181B34270
	internal void .ctor(DataSet ds) { }

	// RVA: 0x1B34140 Offset: 0x1B32740 VA: 0x181B34140
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1B31D90 Offset: 0x1B30390 VA: 0x181B31D90
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0x1B32090 Offset: 0x1B30690 VA: 0x181B32090
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0x1B32310 Offset: 0x1B30910 VA: 0x181B32310
	private bool EmptyData() { }

	// RVA: 0x1B34130 Offset: 0x1B32730 VA: 0x181B34130
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0x1B33AB0 Offset: 0x1B320B0 VA: 0x181B33AB0
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0x1B339C0 Offset: 0x1B31FC0 VA: 0x181B339C0
	private void GenerateTable(DataTable table) { }

	// RVA: 0x1B333E0 Offset: 0x1B319E0 VA: 0x181B333E0
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0x1B32D80 Offset: 0x1B31380 VA: 0x181B32D80
	private void GenerateRow(DataRow row) { }

	// RVA: 0x1B32430 Offset: 0x1B30A30 VA: 0x181B32430
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0x1B33A50 Offset: 0x1B32050 VA: 0x181B33A50
	internal static string QualifiedName(string prefix, string name) { }
}

// Namespace: System.Data
internal sealed class XmlDataTreeWriter // TypeDefIndex: 8767
{
	// Fields
	private XmlWriter _xmlw; // 0x10
	private DataSet _ds; // 0x18
	private DataTable _dt; // 0x20
	private ArrayList _dTables; // 0x28
	private DataTable[] _topLevelTables; // 0x30
	private bool _fFromTable; // 0x38
	private bool _isDiffgram; // 0x39
	private Hashtable _rowsOrder; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x1B3AF70 Offset: 0x1B39570 VA: 0x181B3AF70
	internal void .ctor(DataSet ds) { }

	// RVA: 0x1B3AD70 Offset: 0x1B39370 VA: 0x181B3AD70
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1B381C0 Offset: 0x1B367C0 VA: 0x181B381C0
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1B37EC0 Offset: 0x1B364C0 VA: 0x181B37EC0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1B38820 Offset: 0x1B36E20 VA: 0x181B38820
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0x1B38900 Offset: 0x1B36F00 VA: 0x181B38900
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x1B38F40 Offset: 0x1B37540 VA: 0x181B38F40
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x1B384D0 Offset: 0x1B36AD0 VA: 0x181B384D0
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0x1B397D0 Offset: 0x1B37DD0 VA: 0x181B397D0
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0x1B38790 Offset: 0x1B36D90 VA: 0x181B38790
	internal static bool PreserveSpace(object value) { }
}

// Namespace: System.Data
internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 8768
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Properties
	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x1B31830 Offset: 0x1B2FE30 VA: 0x181B31830
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x1B31CE0 Offset: 0x1B302E0 VA: 0x181B31CE0
	private void .ctor(XmlWriter w) { }

	// RVA: 0x1B31D20 Offset: 0x1B30320 VA: 0x181B31D20
	internal Stream get_BaseStream() { }

	// RVA: 0x1B31BC0 Offset: 0x1B301C0 VA: 0x181B31BC0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1B31BF0 Offset: 0x1B301F0 VA: 0x181B31BF0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x14C9840 Offset: 0x14C7E40 VA: 0x1814C9840 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1B31A10 Offset: 0x1B30010 VA: 0x181B31A10 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1B31C20 Offset: 0x1B30220 VA: 0x181B31C20 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1B31A70 Offset: 0x1B30070 VA: 0x181B31A70 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1B31AD0 Offset: 0x1B300D0 VA: 0x181B31AD0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1B31B90 Offset: 0x1B30190 VA: 0x181B31B90 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1B31A40 Offset: 0x1B30040 VA: 0x181B31A40 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1B31950 Offset: 0x1B2FF50 VA: 0x181B31950 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1B319E0 Offset: 0x1B2FFE0 VA: 0x181B319E0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1B31B00 Offset: 0x1B30100 VA: 0x181B31B00 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1B31AA0 Offset: 0x1B300A0 VA: 0x181B31AA0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1B31980 Offset: 0x1B2FF80 VA: 0x181B31980 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1B31CB0 Offset: 0x1B302B0 VA: 0x181B31CB0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1B31C50 Offset: 0x1B30250 VA: 0x181B31C50 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1B31C80 Offset: 0x1B30280 VA: 0x181B31C80 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1B319B0 Offset: 0x1B2FFB0 VA: 0x181B319B0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1B31B30 Offset: 0x1B30130 VA: 0x181B31B30 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1B31B60 Offset: 0x1B30160 VA: 0x181B31B60 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1B318F0 Offset: 0x1B2FEF0 VA: 0x181B318F0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1B31920 Offset: 0x1B2FF20 VA: 0x181B31920 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1450BC0 Offset: 0x144F1C0 VA: 0x181450BC0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1B31800 Offset: 0x1B2FE00 VA: 0x181B31800 Slot: 28
	public override void Close() { }

	// RVA: 0x1B31890 Offset: 0x1B2FE90 VA: 0x181B31890 Slot: 29
	public override void Flush() { }

	// RVA: 0x1B318C0 Offset: 0x1B2FEC0 VA: 0x181B318C0 Slot: 30
	public override string LookupPrefix(string ns) { }
}

// Namespace: System.Data
internal sealed class DataTextReader : XmlReader // TypeDefIndex: 8769
{
	// Fields
	private XmlReader _xmlreader; // 0x10

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
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }

	// Methods

	// RVA: 0x1B31330 Offset: 0x1B2F930 VA: 0x181B31330
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0x1B315B0 Offset: 0x1B2FBB0 VA: 0x181B315B0
	private void .ctor(XmlReader input) { }

	// RVA: 0x16501C0 Offset: 0x164E7C0 VA: 0x1816501C0 Slot: 5
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

	// RVA: 0x1B31430 Offset: 0x1B2FA30 VA: 0x181B31430 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x14ACB80 Offset: 0x14AB180 VA: 0x1814ACB80 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1B31550 Offset: 0x1B2FB50 VA: 0x181B31550 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1B31650 Offset: 0x1B2FC50 VA: 0x181B31650 Slot: 42
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1B31520 Offset: 0x1B2FB20 VA: 0x181B31520 Slot: 44
	public override string ReadString() { }
}

