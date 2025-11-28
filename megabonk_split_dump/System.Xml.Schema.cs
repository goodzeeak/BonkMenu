// Namespace: System.Xml.Schema
internal class AxisElement // TypeDefIndex: 6882
{
	// Fields
	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	// Properties
	internal DoubleLinkAxis CurNode { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0x1D49BF0 Offset: 0x1D481F0 VA: 0x181D49BF0
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x1D49BE0 Offset: 0x1D481E0 VA: 0x181D49BE0
	internal void SetDepth(int depth) { }

	// RVA: 0x1D49A90 Offset: 0x1D48090 VA: 0x181D49A90
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x1D49900 Offset: 0x1D47F00 VA: 0x181D49900
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }
}

// Namespace: System.Xml.Schema
internal class AxisStack // TypeDefIndex: 6883
{
	// Fields
	private ArrayList _stack; // 0x10
	private ForwardAxis _subtree; // 0x18
	private ActiveAxis _parent; // 0x20

	// Properties
	internal ForwardAxis Subtree { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal ForwardAxis get_Subtree() { }

	// RVA: 0x14A4DA0 Offset: 0x14A33A0 VA: 0x1814A4DA0
	internal int get_Length() { }

	// RVA: 0x1D4A490 Offset: 0x1D48A90 VA: 0x181D4A490
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x1D4A3E0 Offset: 0x1D489E0 VA: 0x181D4A3E0
	internal void Push(int depth) { }

	// RVA: 0x1D4A390 Offset: 0x1D48990 VA: 0x181D4A390
	internal void Pop() { }

	// RVA: 0x1D49C40 Offset: 0x1D48240 VA: 0x181D49C40
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x1D4A090 Offset: 0x1D48690 VA: 0x181D4A090
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x1D49EC0 Offset: 0x1D484C0 VA: 0x181D49EC0
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x1D49CC0 Offset: 0x1D482C0 VA: 0x181D49CC0
	internal bool MoveToAttribute(string name, string URN, int depth) { }
}

// Namespace: System.Xml.Schema
internal class ActiveAxis // TypeDefIndex: 6884
{
	// Fields
	private int _currentDepth; // 0x10
	private bool _isActive; // 0x14
	private Asttree _axisTree; // 0x18
	private ArrayList _axisStack; // 0x20

	// Properties
	public int CurrentDepth { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_CurrentDepth() { }

	// RVA: 0x1D483C0 Offset: 0x1D469C0 VA: 0x181D483C0
	internal void Reactivate() { }

	// RVA: 0x1D483D0 Offset: 0x1D469D0 VA: 0x181D483D0
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0x1D48230 Offset: 0x1D46830 VA: 0x181D48230
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x1D47F80 Offset: 0x1D46580 VA: 0x181D47F80 Slot: 4
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0x1D480C0 Offset: 0x1D466C0 VA: 0x181D480C0
	public bool MoveToAttribute(string localname, string URN) { }
}

// Namespace: System.Xml.Schema
internal class DoubleLinkAxis : Axis // TypeDefIndex: 6885
{
	// Fields
	internal Axis next; // 0x40

	// Properties
	internal Axis Next { get; set; }

	// Methods

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal Axis get_Next() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void set_Next(Axis value) { }

	// RVA: 0x1D51350 Offset: 0x1D4F950 VA: 0x181D51350
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x1D51220 Offset: 0x1D4F820 VA: 0x181D51220
	internal static DoubleLinkAxis ConvertTree(Axis axis) { }
}

// Namespace: System.Xml.Schema
internal class ForwardAxis // TypeDefIndex: 6886
{
	// Fields
	private DoubleLinkAxis _topNode; // 0x10
	private DoubleLinkAxis _rootNode; // 0x18
	private bool _isAttribute; // 0x20
	private bool _isDss; // 0x21
	private bool _isSelfAxis; // 0x22

	// Properties
	internal DoubleLinkAxis RootNode { get; }
	internal DoubleLinkAxis TopNode { get; }
	internal bool IsAttribute { get; }
	internal bool IsDss { get; }
	internal bool IsSelfAxis { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	internal bool get_IsAttribute() { }

	// RVA: 0x38E1B0 Offset: 0x38C7B0 VA: 0x18038E1B0
	internal bool get_IsDss() { }

	// RVA: 0x38E1C0 Offset: 0x38C7C0 VA: 0x18038E1C0
	internal bool get_IsSelfAxis() { }

	// RVA: 0x1D51C60 Offset: 0x1D50260 VA: 0x181D51C60
	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }
}

// Namespace: System.Xml.Schema
internal class Asttree // TypeDefIndex: 6887
{
	// Fields
	private ArrayList _fAxisArray; // 0x10
	private string _xpathexpr; // 0x18
	private bool _isField; // 0x20
	private XmlNamespaceManager _nsmgr; // 0x28

	// Properties
	internal ArrayList SubtreeArray { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0x1D49300 Offset: 0x1D47900 VA: 0x181D49300
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x1D49170 Offset: 0x1D47770 VA: 0x181D49170
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0x1D49110 Offset: 0x1D47710 VA: 0x181D49110
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0x1D49140 Offset: 0x1D47740 VA: 0x181D49140
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x1D491A0 Offset: 0x1D477A0 VA: 0x181D491A0
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0x1D48640 Offset: 0x1D46C40 VA: 0x181D48640
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x1D491D0 Offset: 0x1D477D0 VA: 0x181D491D0
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }
}

// Namespace: System.Xml.Schema
internal class AutoValidator : BaseValidator // TypeDefIndex: 6888
{
	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1D49860 Offset: 0x1D47E60 VA: 0x181D49860
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1D49770 Offset: 0x1D47D70 VA: 0x181D49770 Slot: 5
	public override void Validate() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1D49380 Offset: 0x1D47980 VA: 0x181D49380
	private ValidationType DetectValidationType() { }
}

// Namespace: System.Xml.Schema
internal class BaseProcessor // TypeDefIndex: 6889
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private ValidationEventHandler eventHandler; // 0x20
	private XmlSchemaCompilationSettings compilationSettings; // 0x28
	private int errorCount; // 0x30
	private string NsXml; // 0x38

	// Properties
	protected XmlNameTable NameTable { get; }
	protected SchemaNames SchemaNames { get; }
	protected ValidationEventHandler EventHandler { get; }
	protected XmlSchemaCompilationSettings CompilationSettings { get; }
	protected bool HasErrors { get; }

	// Methods

	// RVA: 0x1D4B920 Offset: 0x1D49F20 VA: 0x181D4B920
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1D4BA40 Offset: 0x1D4A040 VA: 0x181D4BA40
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	protected XmlNameTable get_NameTable() { }

	// RVA: 0x1D4BB20 Offset: 0x1D4A120 VA: 0x181D4BB20
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x1391AC0 Offset: 0x13900C0 VA: 0x181391AC0
	protected bool get_HasErrors() { }

	// RVA: 0x1D4A560 Offset: 0x1D48B60 VA: 0x181D4A560
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1D4AC10 Offset: 0x1D49210 VA: 0x181D4AC10
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x1D4AD40 Offset: 0x1D49340 VA: 0x181D4AD40
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x1D4AE70 Offset: 0x1D49470 VA: 0x181D4AE70
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x1D4B610 Offset: 0x1D49C10 VA: 0x181D4B610
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x1D4B220 Offset: 0x1D49820 VA: 0x181D4B220
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x1D4B700 Offset: 0x1D49D00 VA: 0x181D4B700
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x1D4B4B0 Offset: 0x1D49AB0 VA: 0x181D4B4B0
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x1D4B330 Offset: 0x1D49930 VA: 0x181D4B330
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1D4B0F0 Offset: 0x1D496F0 VA: 0x181D4B0F0
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x1D4B870 Offset: 0x1D49E70 VA: 0x181D4B870
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1D4B180 Offset: 0x1D49780 VA: 0x181D4B180
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x1D4B030 Offset: 0x1D49630 VA: 0x181D4B030
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1D4AFA0 Offset: 0x1D495A0 VA: 0x181D4AFA0
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }
}

// Namespace: System.Xml.Schema
internal class BaseValidator // TypeDefIndex: 6890
{
	// Fields
	private XmlSchemaCollection schemaCollection; // 0x10
	private IValidationEventHandling eventHandling; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaNames schemaNames; // 0x28
	private PositionInfo positionInfo; // 0x30
	private XmlResolver xmlResolver; // 0x38
	private Uri baseUri; // 0x40
	protected SchemaInfo schemaInfo; // 0x48
	protected XmlValidatingReaderImpl reader; // 0x50
	protected XmlQualifiedName elementName; // 0x58
	protected ValidationState context; // 0x60
	protected StringBuilder textValue; // 0x68
	protected string textString; // 0x70
	protected bool hasSibling; // 0x78
	protected bool checkDatatype; // 0x79

	// Properties
	public XmlValidatingReaderImpl Reader { get; }
	public XmlSchemaCollection SchemaCollection { get; }
	public XmlNameTable NameTable { get; }
	public SchemaNames SchemaNames { get; }
	public PositionInfo PositionInfo { get; }
	public XmlResolver XmlResolver { get; set; }
	public Uri BaseUri { get; set; }
	public ValidationEventHandler EventHandler { get; }
	public SchemaInfo SchemaInfo { get; }
	public IDtdInfo DtdInfo { set; }
	public virtual bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1D4CCE0 Offset: 0x1D4B2E0 VA: 0x181D4CCE0
	public void .ctor(BaseValidator other) { }

	// RVA: 0x1D4CBE0 Offset: 0x1D4B1E0 VA: 0x181D4CBE0
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1D4CE30 Offset: 0x1D4B430 VA: 0x181D4CE30
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public Uri get_BaseUri() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_BaseUri(Uri value) { }

	// RVA: 0x1D4CDB0 Offset: 0x1D4B3B0 VA: 0x181D4CDB0
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0x1D4CEE0 Offset: 0x1D4B4E0 VA: 0x181D4CEE0
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 4
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public virtual void Validate() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public virtual void CompleteValidation() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public virtual object FindId(string name) { }

	// RVA: 0x1D4C720 Offset: 0x1D4AD20 VA: 0x181D4C720
	public void ValidateText() { }

	// RVA: 0x1D4CA90 Offset: 0x1D4B090 VA: 0x181D4CA90
	public void ValidateWhitespace() { }

	// RVA: 0x1D4C100 Offset: 0x1D4A700 VA: 0x181D4C100
	private void SaveTextValue(string value) { }

	// RVA: 0x1D4C2A0 Offset: 0x1D4A8A0 VA: 0x181D4C2A0
	protected void SendValidationEvent(string code) { }

	// RVA: 0x1D4C610 Offset: 0x1D4AC10 VA: 0x181D4C610
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x1D4C470 Offset: 0x1D4AA70 VA: 0x181D4C470
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0x1D4C3E0 Offset: 0x1D4A9E0 VA: 0x181D4C3E0
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1D4C2C0 Offset: 0x1D4A8C0 VA: 0x181D4C2C0
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x1D4C180 Offset: 0x1D4A780 VA: 0x181D4C180
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1D4C580 Offset: 0x1D4AB80 VA: 0x181D4C580
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1D4BD80 Offset: 0x1D4A380 VA: 0x181D4BD80
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x1D4BF50 Offset: 0x1D4A550 VA: 0x181D4BF50
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x1D4BBA0 Offset: 0x1D4A1A0 VA: 0x181D4BBA0
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal sealed class BitSet // TypeDefIndex: 6891
{
	// Fields
	private int count; // 0x10
	private uint[] bits; // 0x18

	// Properties
	public int Count { get; }
	public bool Item { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x1D4D6D0 Offset: 0x1D4BCD0 VA: 0x181D4D6D0
	public void .ctor(int count) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_Count() { }

	// RVA: 0x1D4D410 Offset: 0x1D4BA10 VA: 0x181D4D410
	public bool get_Item(int index) { }

	// RVA: 0x1D4D090 Offset: 0x1D4B690 VA: 0x181D4D090
	public void Clear() { }

	// RVA: 0x1D4D650 Offset: 0x1D4BC50 VA: 0x181D4D650
	public void Set(int index) { }

	// RVA: 0x1D4D410 Offset: 0x1D4BA10 VA: 0x181D4D410
	public bool Get(int index) { }

	// RVA: 0x1D4D530 Offset: 0x1D4BB30 VA: 0x181D4D530
	public int NextSet(int startFrom) { }

	// RVA: 0x1D4CFC0 Offset: 0x1D4B5C0 VA: 0x181D4CFC0
	public void And(BitSet other) { }

	// RVA: 0x1D4D5C0 Offset: 0x1D4BBC0 VA: 0x181D4D5C0
	public void Or(BitSet other) { }

	// RVA: 0x1D4D3D0 Offset: 0x1D4B9D0 VA: 0x181D4D3D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D4D260 Offset: 0x1D4B860 VA: 0x181D4D260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D4D0E0 Offset: 0x1D4B6E0 VA: 0x181D4D0E0
	public BitSet Clone() { }

	// RVA: 0x1D4D740 Offset: 0x1D4BD40 VA: 0x181D4D740
	public bool get_IsEmpty() { }

	// RVA: 0x1D4D460 Offset: 0x1D4BA60 VA: 0x181D4D460
	public bool Intersects(BitSet other) { }

	// RVA: 0x1D4D6C0 Offset: 0x1D4BCC0 VA: 0x181D4D6C0
	private int Subscript(int bitIndex) { }

	// RVA: 0x1D4D1D0 Offset: 0x1D4B7D0 VA: 0x181D4D1D0
	private void EnsureLength(int nRequiredLength) { }
}

// Namespace: System.Xml.Schema
internal class ChameleonKey // TypeDefIndex: 6892
{
	// Fields
	internal string targetNS; // 0x10
	internal Uri chameleonLocation; // 0x18
	internal XmlSchema originalSchema; // 0x20
	private int hashCode; // 0x28

	// Methods

	// RVA: 0x1D4D9D0 Offset: 0x1D4BFD0 VA: 0x181D4D9D0
	public void .ctor(string ns, XmlSchema originalSchema) { }

	// RVA: 0x1D4D930 Offset: 0x1D4BF30 VA: 0x181D4D930 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D4D850 Offset: 0x1D4BE50 VA: 0x181D4D850 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: System.Xml.Schema
internal class CompiledIdentityConstraint // TypeDefIndex: 6894
{
	// Fields
	internal XmlQualifiedName name; // 0x10
	private CompiledIdentityConstraint.ConstraintRole role; // 0x18
	private Asttree selector; // 0x20
	private Asttree[] fields; // 0x28
	internal XmlQualifiedName refer; // 0x30
	public static readonly CompiledIdentityConstraint Empty; // 0x0

	// Properties
	public CompiledIdentityConstraint.ConstraintRole Role { get; }
	public Asttree Selector { get; }
	public Asttree[] Fields { get; }

	// Methods

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public CompiledIdentityConstraint.ConstraintRole get_Role() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Asttree get_Selector() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Asttree[] get_Fields() { }

	// RVA: 0x1D4FEA0 Offset: 0x1D4E4A0 VA: 0x181D4FEA0
	private void .ctor() { }

	// RVA: 0x1D4FF30 Offset: 0x1D4E530 VA: 0x181D4FF30
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x1D4FDC0 Offset: 0x1D4E3C0 VA: 0x181D4FDC0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class ConstraintStruct // TypeDefIndex: 6895
{
	// Fields
	internal CompiledIdentityConstraint constraint; // 0x10
	internal SelectorActiveAxis axisSelector; // 0x18
	internal ArrayList axisFields; // 0x20
	internal Hashtable qualifiedTable; // 0x28
	internal Hashtable keyrefTable; // 0x30
	private int tableDim; // 0x38

	// Properties
	internal int TableDim { get; }

	// Methods

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	internal int get_TableDim() { }

	// RVA: 0x1D503F0 Offset: 0x1D4E9F0 VA: 0x181D503F0
	internal void .ctor(CompiledIdentityConstraint constraint) { }
}

// Namespace: System.Xml.Schema
internal class LocatedActiveAxis : ActiveAxis // TypeDefIndex: 6896
{
	// Fields
	private int column; // 0x28
	internal bool isMatched; // 0x2C
	internal KeySequence Ks; // 0x30

	// Properties
	internal int Column { get; }

	// Methods

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	internal int get_Column() { }

	// RVA: 0x1D53A90 Offset: 0x1D52090 VA: 0x181D53A90
	internal void .ctor(Asttree astfield, KeySequence ks, int column) { }

	// RVA: 0x1D53A70 Offset: 0x1D52070 VA: 0x181D53A70
	internal void Reactivate(KeySequence ks) { }
}

// Namespace: System.Xml.Schema
internal class SelectorActiveAxis : ActiveAxis // TypeDefIndex: 6897
{
	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Properties
	public int lastDepth { get; }

	// Methods

	// RVA: 0x1D58010 Offset: 0x1D56610 VA: 0x181D58010
	public int get_lastDepth() { }

	// RVA: 0x1D57F80 Offset: 0x1D56580 VA: 0x181D57F80
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x1D57900 Offset: 0x1D55F00 VA: 0x181D57900 Slot: 4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0x1D57B90 Offset: 0x1D56190 VA: 0x181D57B90
	public int PushKS(int errline, int errcol) { }

	// RVA: 0x1D57AF0 Offset: 0x1D560F0 VA: 0x181D57AF0
	public KeySequence PopKS() { }
}

// Namespace: System.Xml.Schema
internal class KSStruct // TypeDefIndex: 6898
{
	// Fields
	public int depth; // 0x10
	public KeySequence ks; // 0x18
	public LocatedActiveAxis[] fields; // 0x20

	// Methods

	// RVA: 0x1D52090 Offset: 0x1D50690 VA: 0x181D52090
	public void .ctor(KeySequence ks, int dim) { }
}

// Namespace: System.Xml.Schema
internal class TypedObject // TypeDefIndex: 6900
{
	// Fields
	private TypedObject.DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	// Properties
	public int Dim { get; }
	public bool IsList { get; }
	public bool IsDecimal { get; }
	public Decimal[] Dvalue { get; }
	public object Value { get; }
	public XmlSchemaDatatype Type { get; }

	// Methods

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public int get_Dim() { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_IsList() { }

	// RVA: 0x1D5A9E0 Offset: 0x1D58FE0 VA: 0x181D5A9E0
	public bool get_IsDecimal() { }

	// RVA: 0xACFA50 Offset: 0xACE050 VA: 0x180ACFA50
	public Decimal[] get_Dvalue() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public object get_Value() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0x1D5A870 Offset: 0x1D58E70 VA: 0x181D5A870
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D5A5E0 Offset: 0x1D58BE0 VA: 0x181D5A5E0
	public void SetDecimal() { }

	// RVA: 0x1D5A4C0 Offset: 0x1D58AC0 VA: 0x181D5A4C0
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x1D5A130 Offset: 0x1D58730 VA: 0x181D5A130
	public bool Equals(TypedObject other) { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class KeySequence // TypeDefIndex: 6901
{
	// Fields
	private TypedObject[] ks; // 0x10
	private int dim; // 0x18
	private int hashcode; // 0x1C
	private int posline; // 0x20
	private int poscol; // 0x24

	// Properties
	public int PosLine { get; }
	public int PosCol { get; }
	public object Item { get; set; }

	// Methods

	// RVA: 0x1D527E0 Offset: 0x1D50DE0 VA: 0x181D527E0
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_PosLine() { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public int get_PosCol() { }

	// RVA: 0x1D52870 Offset: 0x1D50E70 VA: 0x181D52870
	public object get_Item(int index) { }

	// RVA: 0x1D528A0 Offset: 0x1D50EA0 VA: 0x181D528A0
	public void set_Item(int index, object value) { }

	// RVA: 0x1D52630 Offset: 0x1D50C30 VA: 0x181D52630
	internal bool IsQualified() { }

	// RVA: 0x1D52220 Offset: 0x1D50820 VA: 0x181D52220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D52110 Offset: 0x1D50710 VA: 0x181D52110 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1D52690 Offset: 0x1D50C90 VA: 0x181D52690 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml.Schema
internal class UpaException : Exception // TypeDefIndex: 6902
{
	// Fields
	private object particle1; // 0x90
	private object particle2; // 0x98

	// Properties
	public object Particle1 { get; }
	public object Particle2 { get; }

	// Methods

	// RVA: 0x1D5AA00 Offset: 0x1D59000 VA: 0x181D5AA00
	public void .ctor(object particle1, object particle2) { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public object get_Particle1() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public object get_Particle2() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class SymbolsDictionary // TypeDefIndex: 6903
{
	// Fields
	private int last; // 0x10
	private Hashtable names; // 0x18
	private Hashtable wildcards; // 0x20
	private ArrayList particles; // 0x28
	private object particleLast; // 0x30
	private bool isUpaEnforced; // 0x38

	// Properties
	public int Count { get; }
	public bool IsUpaEnforced { get; set; }
	public int Item { get; }

	// Methods

	// RVA: 0x1D59FB0 Offset: 0x1D585B0 VA: 0x181D59FB0
	public void .ctor() { }

	// RVA: 0x1D5A050 Offset: 0x1D58650 VA: 0x181D5A050
	public int get_Count() { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_IsUpaEnforced() { }

	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	public void set_IsUpaEnforced(bool value) { }

	// RVA: 0x1D58EB0 Offset: 0x1D574B0 VA: 0x181D58EB0
	public int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x1D58FD0 Offset: 0x1D575D0 VA: 0x181D58FD0
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x1D59280 Offset: 0x1D57880 VA: 0x181D59280
	private void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x1D59430 Offset: 0x1D57A30 VA: 0x181D59430
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x1D5A060 Offset: 0x1D58660 VA: 0x181D5A060
	public int get_Item(XmlQualifiedName name) { }

	// RVA: 0x1D593F0 Offset: 0x1D579F0 VA: 0x181D593F0
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x1D59AA0 Offset: 0x1D580A0 VA: 0x181D59AA0
	public object GetParticle(int symbol) { }

	// RVA: 0x1D59AE0 Offset: 0x1D580E0 VA: 0x181D59AE0
	public string NameOf(int symbol) { }
}

// Namespace: System.Xml.Schema
internal struct Position // TypeDefIndex: 6904
{
	// Fields
	public int symbol; // 0x0
	public object particle; // 0x8

	// Methods

	// RVA: 0xA4BD30 Offset: 0xA4A330 VA: 0x180A4BD30
	public void .ctor(int symbol, object particle) { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class Positions // TypeDefIndex: 6905
{
	// Fields
	private ArrayList positions; // 0x10

	// Properties
	public Position Item { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x1D57710 Offset: 0x1D55D10 VA: 0x181D57710
	public int Add(int symbol, object particle) { }

	// RVA: 0x1D57830 Offset: 0x1D55E30 VA: 0x181D57830
	public Position get_Item(int pos) { }

	// RVA: 0x14A4DA0 Offset: 0x14A33A0 VA: 0x1814A4DA0
	public int get_Count() { }

	// RVA: 0x1D577C0 Offset: 0x1D55DC0 VA: 0x181D577C0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class SyntaxTreeNode // TypeDefIndex: 6906
{
	// Properties
	public abstract bool IsNullable { get; }
	public virtual bool IsRangeNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsNullable();

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	public virtual bool get_IsRangeNode() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class LeafNode : SyntaxTreeNode // TypeDefIndex: 6907
{
	// Fields
	private int pos; // 0x10

	// Properties
	public int Pos { get; set; }
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x3757E0 Offset: 0x373DE0 VA: 0x1803757E0
	public void .ctor(int pos) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_Pos() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_Pos(int value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1D529C0 Offset: 0x1D50FC0 VA: 0x181D529C0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	public override bool get_IsNullable() { }
}

// Namespace: System.Xml.Schema
internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 6908
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x1D53EC0 Offset: 0x1D524C0 VA: 0x181D53EC0 Slot: 8
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x1D53B20 Offset: 0x1D52120 VA: 0x181D53B20 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1D53AE0 Offset: 0x1D520E0 VA: 0x181D53AE0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1D53EF0 Offset: 0x1D524F0 VA: 0x181D53EF0 Slot: 6
	public override bool get_IsNullable() { }
}

// Namespace: System.Xml.Schema
internal abstract class InteriorNode : SyntaxTreeNode // TypeDefIndex: 6909
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Properties
	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x1D51DF0 Offset: 0x1D503F0 VA: 0x181D51DF0
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1D52010 Offset: 0x1D50610 VA: 0x181D52010 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class SequenceNode : InteriorNode // TypeDefIndex: 6911
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1D58130 Offset: 0x1D56730 VA: 0x181D58130 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1D58980 Offset: 0x1D56F80 VA: 0x181D58980 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x1D4DF30 Offset: 0x1D4C530 VA: 0x181D4DF30 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class ChoiceNode : InteriorNode // TypeDefIndex: 6912
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1D4DA60 Offset: 0x1D4C060 VA: 0x181D4DA60
	private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1D4DCA0 Offset: 0x1D4C2A0 VA: 0x181D4DCA0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1D4DF40 Offset: 0x1D4C540 VA: 0x181D4DF40 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x1D4DF30 Offset: 0x1D4C530 VA: 0x181D4DF30 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class PlusNode : InteriorNode // TypeDefIndex: 6913
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1D574F0 Offset: 0x1D55AF0 VA: 0x181D574F0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1B31740 Offset: 0x1B2FD40 VA: 0x181B31740 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class QmarkNode : InteriorNode // TypeDefIndex: 6914
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1D578D0 Offset: 0x1D55ED0 VA: 0x181D578D0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class StarNode : InteriorNode // TypeDefIndex: 6915
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1D574F0 Offset: 0x1D55AF0 VA: 0x181D574F0 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class LeafRangeNode : LeafNode // TypeDefIndex: 6916
{
	// Fields
	private Decimal min; // 0x18
	private Decimal max; // 0x28
	private BitSet nextIteration; // 0x38

	// Properties
	public Decimal Max { get; }
	public Decimal Min { get; }
	public BitSet NextIteration { get; set; }
	public override bool IsRangeNode { get; }

	// Methods

	// RVA: 0x1D52AE0 Offset: 0x1D510E0 VA: 0x181D52AE0
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x1D52B30 Offset: 0x1D51130 VA: 0x181D52B30
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x1116670 Offset: 0x1114C70 VA: 0x181116670
	public Decimal get_Max() { }

	// RVA: 0x8641A0 Offset: 0x8627A0 VA: 0x1808641A0
	public Decimal get_Min() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public BitSet get_NextIteration() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 7
	public override bool get_IsRangeNode() { }

	// RVA: 0x1D52A90 Offset: 0x1D51090 VA: 0x181D52A90 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }
}

// Namespace: System.Xml.Schema
internal class ContentValidator // TypeDefIndex: 6917
{
	// Fields
	private XmlSchemaContentType contentType; // 0x10
	private bool isOpen; // 0x14
	private bool isEmptiable; // 0x15
	public static readonly ContentValidator Empty; // 0x0
	public static readonly ContentValidator TextOnly; // 0x8
	public static readonly ContentValidator Mixed; // 0x10
	public static readonly ContentValidator Any; // 0x18

	// Properties
	public XmlSchemaContentType ContentType { get; }
	public bool PreserveWhitespace { get; }
	public virtual bool IsEmptiable { get; }
	public bool IsOpen { get; set; }

	// Methods

	// RVA: 0x1D50A20 Offset: 0x1D4F020 VA: 0x181D50A20
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x1D50A50 Offset: 0x1D4F050 VA: 0x181D50A50
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1D50AC0 Offset: 0x1D4F0C0 VA: 0x181D50AC0
	public bool get_PreserveWhitespace() { }

	// RVA: 0x146E7F0 Offset: 0x146CDF0 VA: 0x18146E7F0 Slot: 4
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x1D50AA0 Offset: 0x1D4F0A0 VA: 0x181D50AA0
	public bool get_IsOpen() { }

	// RVA: 0x1453DF0 Offset: 0x14523F0 VA: 0x181453DF0
	public void set_IsOpen(bool value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x1D50880 Offset: 0x1D4EE80 VA: 0x181D50880 Slot: 6
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 7
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 8
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 9
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x1D50800 Offset: 0x1D4EE00 VA: 0x181D50800
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x1D50570 Offset: 0x1D4EB70 VA: 0x181D50570
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x1D508B0 Offset: 0x1D4EEB0 VA: 0x181D508B0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class ParticleContentValidator : ContentValidator // TypeDefIndex: 6918
{
	// Fields
	private SymbolsDictionary symbols; // 0x18
	private Positions positions; // 0x20
	private Stack stack; // 0x28
	private SyntaxTreeNode contentNode; // 0x30
	private bool isPartial; // 0x38
	private int minMaxNodesCount; // 0x3C
	private bool enableUpaCheck; // 0x40

	// Methods

	// RVA: 0x1D57420 Offset: 0x1D55A20 VA: 0x181D57420
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x1D57480 Offset: 0x1D55A80 VA: 0x181D57480
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x1D571D0 Offset: 0x1D557D0 VA: 0x181D571D0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1D573E0 Offset: 0x1D559E0 VA: 0x181D573E0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1D558D0 Offset: 0x1D53ED0 VA: 0x181D558D0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1D57240 Offset: 0x1D55840 VA: 0x181D57240
	public void Start() { }

	// RVA: 0x1D57210 Offset: 0x1D55810 VA: 0x181D57210
	public void OpenGroup() { }

	// RVA: 0x1D55560 Offset: 0x1D53B60 VA: 0x181D55560
	public void CloseGroup() { }

	// RVA: 0x1D55910 Offset: 0x1D53F10 VA: 0x181D55910
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x1D54220 Offset: 0x1D52820 VA: 0x181D54220
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x1D542D0 Offset: 0x1D528D0 VA: 0x181D542D0
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x1D54030 Offset: 0x1D52630 VA: 0x181D54030
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x1D53F30 Offset: 0x1D52530 VA: 0x181D53F30
	public void AddChoice() { }

	// RVA: 0x1D54450 Offset: 0x1D52A50 VA: 0x181D54450
	public void AddSequence() { }

	// RVA: 0x1D54550 Offset: 0x1D52B50 VA: 0x181D54550
	public void AddStar() { }

	// RVA: 0x1D54390 Offset: 0x1D52990 VA: 0x181D54390
	public void AddPlus() { }

	// RVA: 0x1D543F0 Offset: 0x1D529F0 VA: 0x181D543F0
	public void AddQMark() { }

	// RVA: 0x1D54130 Offset: 0x1D52730 VA: 0x181D54130
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x1D55710 Offset: 0x1D53D10 VA: 0x181D55710
	private void Closure(InteriorNode node) { }

	// RVA: 0x1D55950 Offset: 0x1D53F50 VA: 0x181D55950
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0x1D54BF0 Offset: 0x1D531F0 VA: 0x181D54BF0
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0x1D55000 Offset: 0x1D53600 VA: 0x181D55000
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x1D56CA0 Offset: 0x1D552A0 VA: 0x181D56CA0
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x1D554C0 Offset: 0x1D53AC0 VA: 0x181D554C0
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x1D55220 Offset: 0x1D53820 VA: 0x181D55220
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x1D545B0 Offset: 0x1D52BB0 VA: 0x181D545B0
	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }
}

// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 6919
{
	// Fields
	private int[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x1D51170 Offset: 0x1D4F770 VA: 0x181D51170
	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1D50F20 Offset: 0x1D4F520 VA: 0x181D50F20 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1D50F80 Offset: 0x1D4F580 VA: 0x181D50F80 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1D50BA0 Offset: 0x1D4F1A0 VA: 0x181D50BA0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1D50BC0 Offset: 0x1D4F1C0 VA: 0x181D50BC0 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1D50D90 Offset: 0x1D4F390 VA: 0x181D50D90 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 6920
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0x1D81260 Offset: 0x1D7F860 VA: 0x181D81260
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1D80FB0 Offset: 0x1D7F5B0 VA: 0x181D80FB0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1D810A0 Offset: 0x1D7F6A0 VA: 0x181D810A0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1D80BE0 Offset: 0x1D7F1E0 VA: 0x181D80BE0 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1D80C30 Offset: 0x1D7F230 VA: 0x181D80C30 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1D80E30 Offset: 0x1D7F430 VA: 0x181D80E30 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
internal struct RangePositionInfo // TypeDefIndex: 6921
{
	// Fields
	public BitSet curpos; // 0x0
	public Decimal[] rangeCounters; // 0x8
}

// Namespace: System.Xml.Schema
internal sealed class RangeContentValidator : ContentValidator // TypeDefIndex: 6922
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private BitSet positionsWithRangeTerminals; // 0x28
	private SymbolsDictionary symbols; // 0x30
	private Positions positions; // 0x38
	private int minMaxNodesCount; // 0x40
	private int endMarkerPos; // 0x44

	// Methods

	// RVA: 0x1D83910 Offset: 0x1D81F10 VA: 0x181D83910
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x1D82DE0 Offset: 0x1D813E0 VA: 0x181D82DE0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1D82FC0 Offset: 0x1D815C0 VA: 0x181D82FC0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1D82900 Offset: 0x1D80F00 VA: 0x181D82900 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1D82920 Offset: 0x1D80F20 VA: 0x181D82920 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1D82BC0 Offset: 0x1D811C0 VA: 0x181D82BC0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 6923
{
	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Properties
	public override bool IsEmptiable { get; }

	// Methods

	// RVA: 0x1D643B0 Offset: 0x1D629B0 VA: 0x181D643B0
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x1D638B0 Offset: 0x1D61EB0 VA: 0x181D638B0
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x1D644D0 Offset: 0x1D62AD0 VA: 0x181D644D0 Slot: 4
	public override bool get_IsEmptiable() { }

	// RVA: 0x1D641E0 Offset: 0x1D627E0 VA: 0x181D641E0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1D64280 Offset: 0x1D62880 VA: 0x181D64280 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1D63A00 Offset: 0x1D62000 VA: 0x181D63A00 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1D63A50 Offset: 0x1D62050 VA: 0x181D63A50 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1D63DC0 Offset: 0x1D623C0 VA: 0x181D63DC0 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaDatatypeVariety // TypeDefIndex: 6924
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaDatatypeVariety Atomic = 0;
	public const XmlSchemaDatatypeVariety List = 1;
	public const XmlSchemaDatatypeVariety Union = 2;
}

// Namespace: System.Xml.Schema
internal class XsdSimpleValue // TypeDefIndex: 6925
{
	// Fields
	private XmlSchemaSimpleType xmlType; // 0x10
	private object typedValue; // 0x18

	// Properties
	public XmlSchemaSimpleType XmlType { get; }
	public object TypedValue { get; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public object get_TypedValue() { }
}

// Namespace: System.Xml.Schema
[Flags]
internal enum RestrictionFlags // TypeDefIndex: 6926
{
	// Fields
	public int value__; // 0x0
	public const RestrictionFlags Length = 1;
	public const RestrictionFlags MinLength = 2;
	public const RestrictionFlags MaxLength = 4;
	public const RestrictionFlags Pattern = 8;
	public const RestrictionFlags Enumeration = 16;
	public const RestrictionFlags WhiteSpace = 32;
	public const RestrictionFlags MaxInclusive = 64;
	public const RestrictionFlags MaxExclusive = 128;
	public const RestrictionFlags MinInclusive = 256;
	public const RestrictionFlags MinExclusive = 512;
	public const RestrictionFlags TotalDigits = 1024;
	public const RestrictionFlags FractionDigits = 2048;
}

// Namespace: System.Xml.Schema
internal enum XmlSchemaWhiteSpace // TypeDefIndex: 6927
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaWhiteSpace Preserve = 0;
	public const XmlSchemaWhiteSpace Replace = 1;
	public const XmlSchemaWhiteSpace Collapse = 2;
}

// Namespace: System.Xml.Schema
internal class RestrictionFacets // TypeDefIndex: 6928
{
	// Fields
	internal int Length; // 0x10
	internal int MinLength; // 0x14
	internal int MaxLength; // 0x18
	internal ArrayList Patterns; // 0x20
	internal ArrayList Enumeration; // 0x28
	internal XmlSchemaWhiteSpace WhiteSpace; // 0x30
	internal object MaxInclusive; // 0x38
	internal object MaxExclusive; // 0x40
	internal object MinInclusive; // 0x48
	internal object MinExclusive; // 0x50
	internal int TotalDigits; // 0x58
	internal int FractionDigits; // 0x5C
	internal RestrictionFlags Flags; // 0x60
	internal RestrictionFlags FixedFlags; // 0x64

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class DatatypeImplementation : XmlSchemaDatatype // TypeDefIndex: 6930
{
	// Fields
	private XmlSchemaDatatypeVariety variety; // 0x10
	private RestrictionFacets restriction; // 0x18
	private DatatypeImplementation baseType; // 0x20
	private XmlValueConverter valueConverter; // 0x28
	private XmlSchemaType parentSchemaType; // 0x30
	private static Hashtable builtinTypes; // 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; // 0x8
	private static XmlSchemaSimpleType anySimpleType; // 0x10
	private static XmlSchemaSimpleType anyAtomicType; // 0x18
	private static XmlSchemaSimpleType untypedAtomicType; // 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; // 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; // 0x30
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; // 0x38
	private static XmlSchemaSimpleType tokenTypeV1Compat; // 0x40
	internal static XmlQualifiedName QnAnySimpleType; // 0x48
	internal static XmlQualifiedName QnAnyType; // 0x50
	internal static FacetsChecker stringFacetsChecker; // 0x58
	internal static FacetsChecker miscFacetsChecker; // 0x60
	internal static FacetsChecker numeric2FacetsChecker; // 0x68
	internal static FacetsChecker binaryFacetsChecker; // 0x70
	internal static FacetsChecker dateTimeFacetsChecker; // 0x78
	internal static FacetsChecker durationFacetsChecker; // 0x80
	internal static FacetsChecker listFacetsChecker; // 0x88
	internal static FacetsChecker qnameFacetsChecker; // 0x90
	internal static FacetsChecker unionFacetsChecker; // 0x98
	private static readonly DatatypeImplementation c_anySimpleType; // 0xA0
	private static readonly DatatypeImplementation c_anyURI; // 0xA8
	private static readonly DatatypeImplementation c_base64Binary; // 0xB0
	private static readonly DatatypeImplementation c_boolean; // 0xB8
	private static readonly DatatypeImplementation c_byte; // 0xC0
	private static readonly DatatypeImplementation c_char; // 0xC8
	private static readonly DatatypeImplementation c_date; // 0xD0
	private static readonly DatatypeImplementation c_dateTime; // 0xD8
	private static readonly DatatypeImplementation c_dateTimeNoTz; // 0xE0
	private static readonly DatatypeImplementation c_dateTimeTz; // 0xE8
	private static readonly DatatypeImplementation c_day; // 0xF0
	private static readonly DatatypeImplementation c_decimal; // 0xF8
	private static readonly DatatypeImplementation c_double; // 0x100
	private static readonly DatatypeImplementation c_doubleXdr; // 0x108
	private static readonly DatatypeImplementation c_duration; // 0x110
	private static readonly DatatypeImplementation c_ENTITY; // 0x118
	private static readonly DatatypeImplementation c_ENTITIES; // 0x120
	private static readonly DatatypeImplementation c_ENUMERATION; // 0x128
	private static readonly DatatypeImplementation c_fixed; // 0x130
	private static readonly DatatypeImplementation c_float; // 0x138
	private static readonly DatatypeImplementation c_floatXdr; // 0x140
	private static readonly DatatypeImplementation c_hexBinary; // 0x148
	private static readonly DatatypeImplementation c_ID; // 0x150
	private static readonly DatatypeImplementation c_IDREF; // 0x158
	private static readonly DatatypeImplementation c_IDREFS; // 0x160
	private static readonly DatatypeImplementation c_int; // 0x168
	private static readonly DatatypeImplementation c_integer; // 0x170
	private static readonly DatatypeImplementation c_language; // 0x178
	private static readonly DatatypeImplementation c_long; // 0x180
	private static readonly DatatypeImplementation c_month; // 0x188
	private static readonly DatatypeImplementation c_monthDay; // 0x190
	private static readonly DatatypeImplementation c_Name; // 0x198
	private static readonly DatatypeImplementation c_NCName; // 0x1A0
	private static readonly DatatypeImplementation c_negativeInteger; // 0x1A8
	private static readonly DatatypeImplementation c_NMTOKEN; // 0x1B0
	private static readonly DatatypeImplementation c_NMTOKENS; // 0x1B8
	private static readonly DatatypeImplementation c_nonNegativeInteger; // 0x1C0
	private static readonly DatatypeImplementation c_nonPositiveInteger; // 0x1C8
	private static readonly DatatypeImplementation c_normalizedString; // 0x1D0
	private static readonly DatatypeImplementation c_NOTATION; // 0x1D8
	private static readonly DatatypeImplementation c_positiveInteger; // 0x1E0
	private static readonly DatatypeImplementation c_QName; // 0x1E8
	private static readonly DatatypeImplementation c_QNameXdr; // 0x1F0
	private static readonly DatatypeImplementation c_short; // 0x1F8
	private static readonly DatatypeImplementation c_string; // 0x200
	private static readonly DatatypeImplementation c_time; // 0x208
	private static readonly DatatypeImplementation c_timeNoTz; // 0x210
	private static readonly DatatypeImplementation c_timeTz; // 0x218
	private static readonly DatatypeImplementation c_token; // 0x220
	private static readonly DatatypeImplementation c_unsignedByte; // 0x228
	private static readonly DatatypeImplementation c_unsignedInt; // 0x230
	private static readonly DatatypeImplementation c_unsignedLong; // 0x238
	private static readonly DatatypeImplementation c_unsignedShort; // 0x240
	private static readonly DatatypeImplementation c_uuid; // 0x248
	private static readonly DatatypeImplementation c_year; // 0x250
	private static readonly DatatypeImplementation c_yearMonth; // 0x258
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; // 0x260
	internal static readonly DatatypeImplementation c_tokenV1Compat; // 0x268
	private static readonly DatatypeImplementation c_anyAtomicType; // 0x270
	private static readonly DatatypeImplementation c_dayTimeDuration; // 0x278
	private static readonly DatatypeImplementation c_untypedAtomicType; // 0x280
	private static readonly DatatypeImplementation c_yearMonthDuration; // 0x288
	private static readonly DatatypeImplementation[] c_tokenizedTypes; // 0x290
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; // 0x298
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes; // 0x2A0
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes; // 0x2A8

	// Properties
	internal static XmlSchemaSimpleType AnySimpleType { get; }
	internal static XmlSchemaSimpleType UntypedAtomicType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override XmlValueConverter ValueConverter { get; }
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	public override XmlSchemaDatatypeVariety Variety { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFacets Restriction { get; }
	internal override bool HasLexicalFacets { get; }
	internal override bool HasValueFacets { get; }
	protected DatatypeImplementation Base { get; }
	internal abstract Type ListValueType { get; }
	internal abstract RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1D67350 Offset: 0x1D65950 VA: 0x181D67350
	private static void .cctor() { }

	// RVA: 0x1D6D5F0 Offset: 0x1D6BBF0 VA: 0x181D6D5F0
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x1D6D6D0 Offset: 0x1D6BCD0 VA: 0x181D6D6D0
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x1D65F90 Offset: 0x1D64590 VA: 0x181D65F90
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x1D65F10 Offset: 0x1D64510 VA: 0x181D65F10
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x1D65E40 Offset: 0x1D64440 VA: 0x181D65E40
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x1D65D70 Offset: 0x1D64370 VA: 0x181D65D70
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x1D66F30 Offset: 0x1D65530 VA: 0x181D66F30
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x1D65AD0 Offset: 0x1D640D0 VA: 0x181D65AD0
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x1D64580 Offset: 0x1D62B80 VA: 0x181D64580
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x1D663C0 Offset: 0x1D649C0 VA: 0x181D663C0
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1D66430 Offset: 0x1D64A30 VA: 0x181D66430
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x1D66060 Offset: 0x1D64660 VA: 0x181D66060
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x1D66500 Offset: 0x1D64B00 VA: 0x181D66500
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x1D66010 Offset: 0x1D64610 VA: 0x181D66010
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x1D66260 Offset: 0x1D64860 VA: 0x181D66260
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1D65850 Offset: 0x1D63E50 VA: 0x181D65850 Slot: 20
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x1D65550 Offset: 0x1D63B50 VA: 0x181D65550 Slot: 21
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x1D65560 Offset: 0x1D63B60 VA: 0x181D65560
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x1D659A0 Offset: 0x1D63FA0 VA: 0x181D659A0
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x1D66880 Offset: 0x1D64E80 VA: 0x181D66880 Slot: 9
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x1D66B50 Offset: 0x1D65150 VA: 0x181D66B50 Slot: 23
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x1D66780 Offset: 0x1D64D80 VA: 0x181D66780 Slot: 24
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 25
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D6D640 Offset: 0x1D6BC40 VA: 0x181D6D640 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1D6D720 Offset: 0x1D6BD20 VA: 0x181D6D720 Slot: 12
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0x458FC0 Offset: 0x4575C0 VA: 0x180458FC0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CC81C0 Offset: 0x1CC67C0 VA: 0x181CC81C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 7
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 13
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x1D6D690 Offset: 0x1D6BC90 VA: 0x181D6D690 Slot: 10
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x1D6D6B0 Offset: 0x1D6BCB0 VA: 0x181D6D6B0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	protected DatatypeImplementation get_Base() { }

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract Type get_ListValueType();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract RestrictionFlags get_ValidRestrictionFlags();

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D66D20 Offset: 0x1D65320 VA: 0x181D66D20 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1D66B80 Offset: 0x1D65180 VA: 0x181D66B80 Slot: 15
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x1D67010 Offset: 0x1D65610 VA: 0x181D67010 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x1D66700 Offset: 0x1D64D00 VA: 0x181D66700
	internal string GetTypeName() { }

	// RVA: 0x1D644F0 Offset: 0x1D62AF0 VA: 0x181D644F0
	protected int Compare(byte[] value1, byte[] value2) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_List : Datatype_anySimpleType // TypeDefIndex: 6931
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Properties
	public override Type ValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override Type ListValueType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal DatatypeImplementation ItemType { get; }

	// Methods

	// RVA: 0x1D6DA60 Offset: 0x1D6C060 VA: 0x181D6DA60 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D6E800 Offset: 0x1D6CE00 VA: 0x181D6E800
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x1D6D790 Offset: 0x1D6BD90 VA: 0x181D6D790 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D6E9B0 Offset: 0x1D6CFB0 VA: 0x181D6E9B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D6E940 Offset: 0x1D6CF40 VA: 0x181D6E940 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1D6E910 Offset: 0x1D6CF10 VA: 0x181D6E910 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1D6E8B0 Offset: 0x1D6CEB0 VA: 0x181D6E8B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1D6E970 Offset: 0x1D6CF70 VA: 0x181D6E970 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D6E9A0 Offset: 0x1D6CFA0 VA: 0x181D6E9A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal DatatypeImplementation get_ItemType() { }

	// RVA: 0x1D6DD90 Offset: 0x1D6C390 VA: 0x181D6DD90 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x1D6E320 Offset: 0x1D6C920 VA: 0x181D6E320 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }
}

// Namespace: System.Xml.Schema
internal class Datatype_union : Datatype_anySimpleType // TypeDefIndex: 6932
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Properties
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x1D75910 Offset: 0x1D73F10 VA: 0x181D75910 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D761E0 Offset: 0x1D747E0 VA: 0x181D761E0
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x1D75800 Offset: 0x1D73E00 VA: 0x181D75800 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D76330 Offset: 0x1D74930 VA: 0x181D76330 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D76280 Offset: 0x1D74880 VA: 0x181D76280 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1D762E0 Offset: 0x1D748E0 VA: 0x181D762E0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x80F2C0 Offset: 0x80D8C0 VA: 0x18080F2C0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x1D75920 Offset: 0x1D73F20 VA: 0x181D75920
	internal bool HasAtomicMembers() { }

	// RVA: 0x1D759C0 Offset: 0x1D73FC0 VA: 0x181D759C0
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x1D75A70 Offset: 0x1D74070 VA: 0x181D75A70 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D75CF0 Offset: 0x1D742F0 VA: 0x181D75CF0 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D76120 Offset: 0x1D74720 VA: 0x181D76120
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType : DatatypeImplementation // TypeDefIndex: 6933
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override Type ListValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1D6FB60 Offset: 0x1D6E160 VA: 0x181D6FB60 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D6FCF0 Offset: 0x1D6E2F0 VA: 0x181D6FCF0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1D6FD90 Offset: 0x1D6E390 VA: 0x181D6FD90 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D6FD40 Offset: 0x1D6E340 VA: 0x181D6FD40 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x458FC0 Offset: 0x4575C0 VA: 0x180458FC0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D6FAF0 Offset: 0x1D6E0F0 VA: 0x181D6FAF0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D6FBB0 Offset: 0x1D6E1B0 VA: 0x181D6FBB0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D6FCA0 Offset: 0x1D6E2A0 VA: 0x181D6FCA0
	public void .ctor() { }

	// RVA: 0x1D6FBE0 Offset: 0x1D6E1E0 VA: 0x181D6FBE0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anyAtomicType : Datatype_anySimpleType // TypeDefIndex: 6934
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1D6FA20 Offset: 0x1D6E020 VA: 0x181D6FA20 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D6FA70 Offset: 0x1D6E070 VA: 0x181D6FA70
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_untypedAtomicType : Datatype_anyAtomicType // TypeDefIndex: 6935
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1D77670 Offset: 0x1D75C70 VA: 0x181D77670 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x455BB0 Offset: 0x4541B0 VA: 0x180455BB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D776C0 Offset: 0x1D75CC0 VA: 0x181D776C0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_string : Datatype_anySimpleType // TypeDefIndex: 6936
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D75520 Offset: 0x1D73B20 VA: 0x181D75520 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D756C0 Offset: 0x1D73CC0 VA: 0x181D756C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x458FC0 Offset: 0x4575C0 VA: 0x180458FC0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1D6E9A0 Offset: 0x1D6CFA0 VA: 0x181D6E9A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D75530 Offset: 0x1D73B30 VA: 0x181D75530 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D75640 Offset: 0x1D73C40 VA: 0x181D75640
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_boolean : Datatype_anySimpleType // TypeDefIndex: 6937
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D707D0 Offset: 0x1D6EDD0 VA: 0x181D707D0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D70A40 Offset: 0x1D6F040 VA: 0x181D70A40 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x459940 Offset: 0x457F40 VA: 0x180459940 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D70AE0 Offset: 0x1D6F0E0 VA: 0x181D70AE0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D70A90 Offset: 0x1D6F090 VA: 0x181D70A90 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x5513C0 Offset: 0x54F9C0 VA: 0x1805513C0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D70760 Offset: 0x1D6ED60 VA: 0x181D70760 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D707E0 Offset: 0x1D6EDE0 VA: 0x181D707E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D709C0 Offset: 0x1D6EFC0 VA: 0x181D709C0
	public void .ctor() { }

	// RVA: 0x1D70900 Offset: 0x1D6EF00 VA: 0x181D70900
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_float : Datatype_anySimpleType // TypeDefIndex: 6938
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D72710 Offset: 0x1D70D10 VA: 0x181D72710 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D73930 Offset: 0x1D71F30 VA: 0x181D73930 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x457F50 Offset: 0x456550 VA: 0x180457F50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D739D0 Offset: 0x1D71FD0 VA: 0x181D739D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D73980 Offset: 0x1D71F80 VA: 0x181D73980 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D71AF0 Offset: 0x1D700F0 VA: 0x181D71AF0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D73610 Offset: 0x1D71C10 VA: 0x181D73610 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D73670 Offset: 0x1D71C70 VA: 0x181D73670 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D738B0 Offset: 0x1D71EB0 VA: 0x181D738B0
	public void .ctor() { }

	// RVA: 0x1D737F0 Offset: 0x1D71DF0 VA: 0x181D737F0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_double : Datatype_anySimpleType // TypeDefIndex: 6939
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D72710 Offset: 0x1D70D10 VA: 0x181D72710 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D729E0 Offset: 0x1D70FE0 VA: 0x181D729E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x44EB70 Offset: 0x44D170 VA: 0x18044EB70 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D72A80 Offset: 0x1D71080 VA: 0x181D72A80 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D72A30 Offset: 0x1D71030 VA: 0x181D72A30 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D71AF0 Offset: 0x1D700F0 VA: 0x181D71AF0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D726B0 Offset: 0x1D70CB0 VA: 0x181D726B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D72720 Offset: 0x1D70D20 VA: 0x181D72720 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D72960 Offset: 0x1D70F60 VA: 0x181D72960
	public void .ctor() { }

	// RVA: 0x1D728A0 Offset: 0x1D70EA0 VA: 0x181D728A0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_decimal : Datatype_anySimpleType // TypeDefIndex: 6940
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D71FF0 Offset: 0x1D705F0 VA: 0x181D71FF0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D723B0 Offset: 0x1D709B0 VA: 0x181D723B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x45A9B0 Offset: 0x458FB0 VA: 0x18045A9B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D72460 Offset: 0x1D70A60 VA: 0x181D72460 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D72400 Offset: 0x1D70A00 VA: 0x181D72400 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D72450 Offset: 0x1D70A50 VA: 0x181D72450 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D71F50 Offset: 0x1D70550 VA: 0x181D71F50 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D72000 Offset: 0x1D70600 VA: 0x181D72000 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D72330 Offset: 0x1D70930 VA: 0x181D72330
	public void .ctor() { }

	// RVA: 0x1D72190 Offset: 0x1D70790 VA: 0x181D72190
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_duration : Datatype_anySimpleType // TypeDefIndex: 6941
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D6EB10 Offset: 0x1D6D110 VA: 0x181D6EB10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D72EC0 Offset: 0x1D714C0 VA: 0x181D72EC0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x455580 Offset: 0x453B80 VA: 0x180455580 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D72F70 Offset: 0x1D71570 VA: 0x181D72F70 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D72F20 Offset: 0x1D71520 VA: 0x181D72F20 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D71AF0 Offset: 0x1D700F0 VA: 0x181D71AF0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D72AD0 Offset: 0x1D710D0 VA: 0x181D72AD0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D72B70 Offset: 0x1D71170 VA: 0x181D72B70 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D72E40 Offset: 0x1D71440 VA: 0x181D72E40
	public void .ctor() { }

	// RVA: 0x1D72D70 Offset: 0x1D71370 VA: 0x181D72D70
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonthDuration : Datatype_duration // TypeDefIndex: 6942
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1D77B80 Offset: 0x1D76180 VA: 0x181D77B80 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1A1B250 Offset: 0x1A19850 VA: 0x181A1B250 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D77D90 Offset: 0x1D76390 VA: 0x181D77D90
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dayTimeDuration : Datatype_duration // TypeDefIndex: 6943
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1D71C90 Offset: 0x1D70290 VA: 0x181D71C90 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D71EF0 Offset: 0x1D704F0 VA: 0x181D71EF0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D71EA0 Offset: 0x1D704A0 VA: 0x181D71EA0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeBase : Datatype_anySimpleType // TypeDefIndex: 6944
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D71590 Offset: 0x1D6FB90 VA: 0x181D71590 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D71A50 Offset: 0x1D70050 VA: 0x181D71A50 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x45BCA0 Offset: 0x45A2A0 VA: 0x18045BCA0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D719C0 Offset: 0x1D6FFC0 VA: 0x181D719C0
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x1D71B00 Offset: 0x1D70100 VA: 0x181D71B00 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D71AA0 Offset: 0x1D700A0 VA: 0x181D71AA0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D71AF0 Offset: 0x1D700F0 VA: 0x181D71AF0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D71430 Offset: 0x1D6FA30 VA: 0x181D71430 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D715A0 Offset: 0x1D6FBA0 VA: 0x181D715A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D718F0 Offset: 0x1D6FEF0 VA: 0x181D718F0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 6945
{
	// Methods

	// RVA: 0x1D71B50 Offset: 0x1D70150 VA: 0x181D71B50
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 6946
{
	// Methods

	// RVA: 0x1D71BA0 Offset: 0x1D701A0 VA: 0x181D71BA0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTime : Datatype_dateTimeBase // TypeDefIndex: 6947
{
	// Methods

	// RVA: 0x1D71BF0 Offset: 0x1D701F0 VA: 0x181D71BF0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_timeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 6948
{
	// Methods

	// RVA: 0x1D75710 Offset: 0x1D73D10 VA: 0x181D75710
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_timeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 6949
{
	// Methods

	// RVA: 0x1D75760 Offset: 0x1D73D60 VA: 0x181D75760
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_time : Datatype_dateTimeBase // TypeDefIndex: 6950
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x458780 Offset: 0x456D80 VA: 0x180458780 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D757B0 Offset: 0x1D73DB0 VA: 0x181D757B0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_date : Datatype_dateTimeBase // TypeDefIndex: 6951
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x412DA0 Offset: 0x4113A0 VA: 0x180412DA0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D71C40 Offset: 0x1D70240 VA: 0x181D71C40
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonth : Datatype_dateTimeBase // TypeDefIndex: 6952
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1D77E30 Offset: 0x1D76430 VA: 0x181D77E30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D77DE0 Offset: 0x1D763E0 VA: 0x181D77DE0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_year : Datatype_dateTimeBase // TypeDefIndex: 6953
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x16A1FB0 Offset: 0x16A05B0 VA: 0x1816A1FB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D77E40 Offset: 0x1D76440 VA: 0x181D77E40
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_monthDay : Datatype_dateTimeBase // TypeDefIndex: 6954
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x146AE90 Offset: 0x1469490 VA: 0x18146AE90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D74990 Offset: 0x1D72F90 VA: 0x181D74990
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_day : Datatype_dateTimeBase // TypeDefIndex: 6955
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x80F2C0 Offset: 0x80D8C0 VA: 0x18080F2C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D71F00 Offset: 0x1D70500 VA: 0x181D71F00
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_month : Datatype_dateTimeBase // TypeDefIndex: 6956
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1D74A30 Offset: 0x1D73030 VA: 0x181D74A30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D749E0 Offset: 0x1D72FE0 VA: 0x181D749E0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_hexBinary : Datatype_anySimpleType // TypeDefIndex: 6957
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D6EB10 Offset: 0x1D6D110 VA: 0x181D6EB10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D73DF0 Offset: 0x1D723F0 VA: 0x181D73DF0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1D73E90 Offset: 0x1D72490 VA: 0x181D73E90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D73EA0 Offset: 0x1D724A0 VA: 0x181D73EA0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D73E40 Offset: 0x1D72440 VA: 0x181D73E40 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D6E9A0 Offset: 0x1D6CFA0 VA: 0x181D6E9A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D73A20 Offset: 0x1D72020 VA: 0x181D73A20 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D73B40 Offset: 0x1D72140 VA: 0x181D73B40 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D73D70 Offset: 0x1D72370 VA: 0x181D73D70
	public void .ctor() { }

	// RVA: 0x1D73CA0 Offset: 0x1D722A0 VA: 0x181D73CA0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_base64Binary : Datatype_anySimpleType // TypeDefIndex: 6958
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D6EB10 Offset: 0x1D6D110 VA: 0x181D6EB10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D70670 Offset: 0x1D6EC70 VA: 0x181D70670 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1742A40 Offset: 0x1741040 VA: 0x181742A40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D70710 Offset: 0x1D6ED10 VA: 0x181D70710 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D706C0 Offset: 0x1D6ECC0 VA: 0x181D706C0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D6E9A0 Offset: 0x1D6CFA0 VA: 0x181D6E9A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D702A0 Offset: 0x1D6E8A0 VA: 0x181D702A0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D703C0 Offset: 0x1D6E9C0 VA: 0x181D703C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D705F0 Offset: 0x1D6EBF0 VA: 0x181D705F0
	public void .ctor() { }

	// RVA: 0x1D70520 Offset: 0x1D6EB20 VA: 0x181D70520
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anyURI : Datatype_anySimpleType // TypeDefIndex: 6959
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override bool HasValueFacets { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D6EB10 Offset: 0x1D6D110 VA: 0x181D6EB10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D701B0 Offset: 0x1D6E7B0 VA: 0x181D701B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x810020 Offset: 0x80E620 VA: 0x180810020 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D70250 Offset: 0x1D6E850 VA: 0x181D70250 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1D70200 Offset: 0x1D6E800 VA: 0x181D70200 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D6E9A0 Offset: 0x1D6CFA0 VA: 0x181D6E9A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D6FDE0 Offset: 0x1D6E3E0 VA: 0x181D6FDE0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D6FEB0 Offset: 0x1D6E4B0 VA: 0x181D6FEB0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D70130 Offset: 0x1D6E730 VA: 0x181D70130
	public void .ctor() { }

	// RVA: 0x1D70060 Offset: 0x1D6E660 VA: 0x181D70060
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_QName : Datatype_anySimpleType // TypeDefIndex: 6960
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1D6EB10 Offset: 0x1D6D110 VA: 0x181D6EB10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D6F920 Offset: 0x1D6DF20 VA: 0x181D6F920 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x175EC40 Offset: 0x175D240 VA: 0x18175EC40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1D6E9A0 Offset: 0x1D6CFA0 VA: 0x181D6E9A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D6F9D0 Offset: 0x1D6DFD0 VA: 0x181D6F9D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D6F980 Offset: 0x1D6DF80 VA: 0x181D6F980 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D6F5F0 Offset: 0x1D6DBF0 VA: 0x181D6F5F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D6F8A0 Offset: 0x1D6DEA0 VA: 0x181D6F8A0
	public void .ctor() { }

	// RVA: 0x1D6F7D0 Offset: 0x1D6DDD0 VA: 0x181D6F7D0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedString : Datatype_string // TypeDefIndex: 6961
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1758D60 Offset: 0x1757360 VA: 0x181758D60 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedStringV1Compat : Datatype_string // TypeDefIndex: 6962
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1758D60 Offset: 0x1757360 VA: 0x181758D60 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_token : Datatype_normalizedString // TypeDefIndex: 6963
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x44EB30 Offset: 0x44D130 VA: 0x18044EB30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat // TypeDefIndex: 6964
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x44EB30 Offset: 0x44D130 VA: 0x18044EB30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_language : Datatype_token // TypeDefIndex: 6965
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x17575E0 Offset: 0x1755BE0 VA: 0x1817575E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NMTOKEN : Datatype_token // TypeDefIndex: 6966
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1CC8170 Offset: 0x1CC6770 VA: 0x181CC8170 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x45C3F0 Offset: 0x45A9F0 VA: 0x18045C3F0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_Name : Datatype_token // TypeDefIndex: 6967
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1756060 Offset: 0x1754660 VA: 0x181756060 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NCName : Datatype_Name // TypeDefIndex: 6968
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x80F2D0 Offset: 0x80D8D0 VA: 0x18080F2D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D6E9D0 Offset: 0x1D6CFD0 VA: 0x181D6E9D0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ID : Datatype_NCName // TypeDefIndex: 6969
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1755D20 Offset: 0x1754320 VA: 0x181755D20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_IDREF : Datatype_NCName // TypeDefIndex: 6970
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x175B970 Offset: 0x1759F70 VA: 0x18175B970 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ENTITY : Datatype_NCName // TypeDefIndex: 6971
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1D6D780 Offset: 0x1D6BD80 VA: 0x181D6D780 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NOTATION : Datatype_anySimpleType // TypeDefIndex: 6972
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1D6EB10 Offset: 0x1D6D110 VA: 0x181D6EB10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1D6F0F0 Offset: 0x1D6D6F0 VA: 0x181D6F0F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1753F60 Offset: 0x1752560 VA: 0x181753F60 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x44F6B0 Offset: 0x44DCB0 VA: 0x18044F6B0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1D6E9A0 Offset: 0x1D6CFA0 VA: 0x181D6E9A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D6F1A0 Offset: 0x1D6D7A0 VA: 0x181D6F1A0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D6F150 Offset: 0x1D6D750 VA: 0x181D6F150 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1D6EB20 Offset: 0x1D6D120 VA: 0x181D6EB20 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D6ED00 Offset: 0x1D6D300 VA: 0x181D6ED00 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x1D6F070 Offset: 0x1D6D670 VA: 0x181D6F070
	public void .ctor() { }

	// RVA: 0x1D6EFA0 Offset: 0x1D6D5A0 VA: 0x181D6EFA0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_integer : Datatype_decimal // TypeDefIndex: 6973
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x5513C0 Offset: 0x54F9C0 VA: 0x1805513C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D743A0 Offset: 0x1D729A0 VA: 0x181D743A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D74500 Offset: 0x1D72B00 VA: 0x181D74500
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_nonPositiveInteger : Datatype_integer // TypeDefIndex: 6974
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1D74E60 Offset: 0x1D73460 VA: 0x181D74E60 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1D74EB0 Offset: 0x1D734B0 VA: 0x181D74EB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1D74500 Offset: 0x1D72B00 VA: 0x181D74500
	public void .ctor() { }

	// RVA: 0x1D74D60 Offset: 0x1D73360 VA: 0x181D74D60
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_negativeInteger : Datatype_nonPositiveInteger // TypeDefIndex: 6975
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1D74BC0 Offset: 0x1D731C0 VA: 0x181D74BC0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x175BF70 Offset: 0x175A570 VA: 0x18175BF70 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D74B40 Offset: 0x1D73140 VA: 0x181D74B40
	public void .ctor() { }

	// RVA: 0x1D74A40 Offset: 0x1D73040 VA: 0x181D74A40
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_long : Datatype_integer // TypeDefIndex: 6976
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	internal override bool HasValueFacets { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1D748A0 Offset: 0x1D72EA0 VA: 0x181D748A0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x175D6C0 Offset: 0x175BCC0 VA: 0x18175D6C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D74550 Offset: 0x1D72B50 VA: 0x181D74550 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D74940 Offset: 0x1D72F40 VA: 0x181D74940 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D748F0 Offset: 0x1D72EF0 VA: 0x181D748F0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1D745B0 Offset: 0x1D72BB0 VA: 0x181D745B0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D74500 Offset: 0x1D72B00 VA: 0x181D74500
	public void .ctor() { }

	// RVA: 0x1D74720 Offset: 0x1D72D20 VA: 0x181D74720
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_int : Datatype_long // TypeDefIndex: 6977
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1D742B0 Offset: 0x1D728B0 VA: 0x181D742B0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x810010 Offset: 0x80E610 VA: 0x180810010 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D73EF0 Offset: 0x1D724F0 VA: 0x181D73EF0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D74350 Offset: 0x1D72950 VA: 0x181D74350 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D74300 Offset: 0x1D72900 VA: 0x181D74300 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1D73F50 Offset: 0x1D72550 VA: 0x181D73F50 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D74230 Offset: 0x1D72830 VA: 0x181D74230
	public void .ctor() { }

	// RVA: 0x1D740C0 Offset: 0x1D726C0 VA: 0x181D740C0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_short : Datatype_int // TypeDefIndex: 6978
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1D75420 Offset: 0x1D73A20 VA: 0x181D75420 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1D754C0 Offset: 0x1D73AC0 VA: 0x181D754C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D75090 Offset: 0x1D73690 VA: 0x181D75090 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D754D0 Offset: 0x1D73AD0 VA: 0x181D754D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D75470 Offset: 0x1D73A70 VA: 0x181D75470 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1D750F0 Offset: 0x1D736F0 VA: 0x181D750F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D753D0 Offset: 0x1D739D0 VA: 0x181D753D0
	public void .ctor() { }

	// RVA: 0x1D75260 Offset: 0x1D73860 VA: 0x181D75260
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_byte : Datatype_short // TypeDefIndex: 6979
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1D70EF0 Offset: 0x1D6F4F0 VA: 0x181D70EF0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x19E5A40 Offset: 0x19E4040 VA: 0x1819E5A40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D70B30 Offset: 0x1D6F130 VA: 0x181D70B30 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D70F90 Offset: 0x1D6F590 VA: 0x181D70F90 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D70F40 Offset: 0x1D6F540 VA: 0x181D70F40 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1D70B90 Offset: 0x1D6F190 VA: 0x181D70B90 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D70E70 Offset: 0x1D6F470 VA: 0x181D70E70
	public void .ctor() { }

	// RVA: 0x1D70D00 Offset: 0x1D6F300 VA: 0x181D70D00
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_nonNegativeInteger : Datatype_integer // TypeDefIndex: 6980
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1D74D10 Offset: 0x1D73310 VA: 0x181D74D10 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1A0A880 Offset: 0x1A08E80 VA: 0x181A0A880 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1D74500 Offset: 0x1D72B00 VA: 0x181D74500
	public void .ctor() { }

	// RVA: 0x1D74C10 Offset: 0x1D73210 VA: 0x181D74C10
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedLong : Datatype_nonNegativeInteger // TypeDefIndex: 6981
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1D770C0 Offset: 0x1D756C0 VA: 0x181D770C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x80F2E0 Offset: 0x80D8E0 VA: 0x18080F2E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D76CA0 Offset: 0x1D752A0 VA: 0x181D76CA0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D77160 Offset: 0x1D75760 VA: 0x181D77160 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D77110 Offset: 0x1D75710 VA: 0x181D77110 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1D76D00 Offset: 0x1D75300 VA: 0x181D76D00 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D77040 Offset: 0x1D75640 VA: 0x181D77040
	public void .ctor() { }

	// RVA: 0x1D76EC0 Offset: 0x1D754C0 VA: 0x181D76EC0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedInt : Datatype_unsignedLong // TypeDefIndex: 6982
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1D76BB0 Offset: 0x1D751B0 VA: 0x181D76BB0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x191FD00 Offset: 0x191E300 VA: 0x18191FD00 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D76810 Offset: 0x1D74E10 VA: 0x181D76810 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D76C50 Offset: 0x1D75250 VA: 0x181D76C50 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D76C00 Offset: 0x1D75200 VA: 0x181D76C00 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1D76870 Offset: 0x1D74E70 VA: 0x181D76870 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D76B60 Offset: 0x1D75160 VA: 0x181D76B60
	public void .ctor() { }

	// RVA: 0x1D769E0 Offset: 0x1D74FE0 VA: 0x181D769E0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedShort : Datatype_unsignedInt // TypeDefIndex: 6983
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1D77580 Offset: 0x1D75B80 VA: 0x181D77580 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1830DB0 Offset: 0x182F3B0 VA: 0x181830DB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D771B0 Offset: 0x1D757B0 VA: 0x181D771B0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D77620 Offset: 0x1D75C20 VA: 0x181D77620 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D775D0 Offset: 0x1D75BD0 VA: 0x181D775D0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1D77210 Offset: 0x1D75810 VA: 0x181D77210 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D77500 Offset: 0x1D75B00 VA: 0x181D77500
	public void .ctor() { }

	// RVA: 0x1D77380 Offset: 0x1D75980 VA: 0x181D77380
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedByte : Datatype_unsignedShort // TypeDefIndex: 6984
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1D76720 Offset: 0x1D74D20 VA: 0x181D76720 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1A0D8D0 Offset: 0x1A0BED0 VA: 0x181A0D8D0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D76380 Offset: 0x1D74980 VA: 0x181D76380 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D767C0 Offset: 0x1D74DC0 VA: 0x181D767C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D76770 Offset: 0x1D74D70 VA: 0x181D76770 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1D763E0 Offset: 0x1D749E0 VA: 0x181D763E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D766D0 Offset: 0x1D74CD0 VA: 0x181D766D0
	public void .ctor() { }

	// RVA: 0x1D76550 Offset: 0x1D74B50 VA: 0x181D76550
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_positiveInteger : Datatype_nonNegativeInteger // TypeDefIndex: 6985
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1D75040 Offset: 0x1D73640 VA: 0x181D75040 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x80F330 Offset: 0x80D930 VA: 0x18080F330 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1D74FC0 Offset: 0x1D735C0 VA: 0x181D74FC0
	public void .ctor() { }

	// RVA: 0x1D74EC0 Offset: 0x1D734C0 VA: 0x181D74EC0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_doubleXdr : Datatype_double // TypeDefIndex: 6986
{
	// Methods

	// RVA: 0x1D724B0 Offset: 0x1D70AB0 VA: 0x181D724B0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1D72660 Offset: 0x1D70C60 VA: 0x181D72660
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_floatXdr : Datatype_float // TypeDefIndex: 6987
{
	// Methods

	// RVA: 0x1D73420 Offset: 0x1D71A20 VA: 0x181D73420 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1D735C0 Offset: 0x1D71BC0 VA: 0x181D735C0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr : Datatype_anySimpleType // TypeDefIndex: 6988
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1D6F1F0 Offset: 0x1D6D7F0 VA: 0x181D6F1F0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1D6F5A0 Offset: 0x1D6DBA0 VA: 0x181D6F5A0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D6F550 Offset: 0x1D6DB50 VA: 0x181D6F550 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1D6F4D0 Offset: 0x1D6DAD0 VA: 0x181D6F4D0
	public void .ctor() { }

	// RVA: 0x1D6F400 Offset: 0x1D6DA00 VA: 0x181D6F400
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ENUMERATION : Datatype_NMTOKEN // TypeDefIndex: 6989
{
	// Properties
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x458E50 Offset: 0x457450 VA: 0x180458E50 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1D6D770 Offset: 0x1D6BD70 VA: 0x181D6D770
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_char : Datatype_anySimpleType // TypeDefIndex: 6990
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D713E0 Offset: 0x1D6F9E0 VA: 0x181D713E0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D71390 Offset: 0x1D6F990 VA: 0x181D71390 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D70FE0 Offset: 0x1D6F5E0 VA: 0x181D70FE0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D71050 Offset: 0x1D6F650 VA: 0x181D71050 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1D711A0 Offset: 0x1D6F7A0 VA: 0x181D711A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D71310 Offset: 0x1D6F910 VA: 0x181D71310
	public void .ctor() { }

	// RVA: 0x1D71250 Offset: 0x1D6F850 VA: 0x181D71250
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_fixed : Datatype_decimal // TypeDefIndex: 6991
{
	// Methods

	// RVA: 0x1D72FC0 Offset: 0x1D715C0 VA: 0x181D72FC0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1D73230 Offset: 0x1D71830 VA: 0x181D73230 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D733D0 Offset: 0x1D719D0 VA: 0x181D733D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_uuid : Datatype_anySimpleType // TypeDefIndex: 6992
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1D77B30 Offset: 0x1D76130 VA: 0x181D77B30 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1D77AE0 Offset: 0x1D760E0 VA: 0x181D77AE0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1D776D0 Offset: 0x1D75CD0 VA: 0x181D776D0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1D77760 Offset: 0x1D75D60 VA: 0x181D77760 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1D778D0 Offset: 0x1D75ED0 VA: 0x181D778D0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1D77A60 Offset: 0x1D76060 VA: 0x181D77A60
	public void .ctor() { }

	// RVA: 0x1D77990 Offset: 0x1D75F90 VA: 0x181D77990
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class DtdValidator : BaseValidator // TypeDefIndex: 6994
{
	// Fields
	private static DtdValidator.NamespaceManager namespaceManager; // 0x0
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private Hashtable IDs; // 0x98
	private IdRefNode idRefListHead; // 0xA0
	private bool processIdentityConstraints; // 0xA8

	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1D7B140 Offset: 0x1D79740 VA: 0x181D7B140
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x1D793B0 Offset: 0x1D779B0 VA: 0x181D793B0
	private void Init() { }

	// RVA: 0x1D7AD40 Offset: 0x1D79340 VA: 0x181D7AD40 Slot: 5
	public override void Validate() { }

	// RVA: 0x1D79520 Offset: 0x1D77B20 VA: 0x181D79520
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x1D7A840 Offset: 0x1D78E40 VA: 0x181D7A840
	private void ValidatePIComment() { }

	// RVA: 0x1D7A0A0 Offset: 0x1D786A0 VA: 0x181D7A0A0
	private void ValidateElement() { }

	// RVA: 0x1D79EE0 Offset: 0x1D784E0 VA: 0x181D79EE0
	private void ValidateChildElement() { }

	// RVA: 0x1D7A8F0 Offset: 0x1D78EF0 VA: 0x181D7A8F0
	private void ValidateStartElement() { }

	// RVA: 0x1D7A6A0 Offset: 0x1D78CA0 VA: 0x181D7A6A0
	private void ValidateEndStartElement() { }

	// RVA: 0x1D79690 Offset: 0x1D77C90 VA: 0x181D79690
	private void ProcessElement() { }

	// RVA: 0x1D78F60 Offset: 0x1D77560 VA: 0x181D78F60 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1D7A4A0 Offset: 0x1D78AA0 VA: 0x181D7A4A0
	private void ValidateEndElement() { }

	// RVA: 0x1C51190 Offset: 0x1C4F790 VA: 0x181C51190 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1D797E0 Offset: 0x1D77DE0 VA: 0x181D797E0
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1D78A80 Offset: 0x1D77080 VA: 0x181D78A80
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1D78550 Offset: 0x1D76B50 VA: 0x181D78550
	internal void AddID(string name, object node) { }

	// RVA: 0x1D790E0 Offset: 0x1D776E0 VA: 0x181D790E0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1D79110 Offset: 0x1D77710 VA: 0x181D79110
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x1D79300 Offset: 0x1D77900 VA: 0x181D79300
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x1D78930 Offset: 0x1D76F30 VA: 0x181D78930
	private void CheckForwardRefs() { }

	// RVA: 0x1D79AB0 Offset: 0x1D780B0 VA: 0x181D79AB0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1D795B0 Offset: 0x1D77BB0 VA: 0x181D795B0
	private bool Pop() { }

	// RVA: 0x1D79C20 Offset: 0x1D78220 VA: 0x181D79C20
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1D78600 Offset: 0x1D76C00 VA: 0x181D78600
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x1D7B0C0 Offset: 0x1D796C0 VA: 0x181D7B0C0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class FacetsChecker // TypeDefIndex: 6997
{
	// Methods

	// RVA: 0x1D7B9C0 Offset: 0x1D79FC0 VA: 0x181D7B9C0 Slot: 4
	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 8
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 9
	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 10
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 11
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 12
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 13
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 14
	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 15
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 16
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D7BCF0 Offset: 0x1D7A2F0 VA: 0x181D7BCF0
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D7BB70 Offset: 0x1D7A170 VA: 0x181D7BB70
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 17
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D7BDF0 Offset: 0x1D7A3F0 VA: 0x181D7BDF0 Slot: 18
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x1D7C330 Offset: 0x1D7A930 VA: 0x181D7C330
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 6998
{
	// Fields
	private static readonly char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0x1D82300 Offset: 0x1D80900 VA: 0x181D82300
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x1D81770 Offset: 0x1D7FD70 VA: 0x181D81770 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D81810 Offset: 0x1D7FE10 VA: 0x181D81810 Slot: 6
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D81F10 Offset: 0x1D80510 VA: 0x181D81F10 Slot: 7
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D81E80 Offset: 0x1D80480 VA: 0x181D81E80 Slot: 8
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D816E0 Offset: 0x1D7FCE0 VA: 0x181D816E0 Slot: 9
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D81FA0 Offset: 0x1D805A0 VA: 0x181D81FA0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D82130 Offset: 0x1D80730 VA: 0x181D82130
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x1D81340 Offset: 0x1D7F940 VA: 0x181D81340
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x1D82260 Offset: 0x1D80860 VA: 0x181D82260
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker : FacetsChecker // TypeDefIndex: 6999
{
	// Methods

	// RVA: 0x1D82690 Offset: 0x1D80C90 VA: 0x181D82690 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D82340 Offset: 0x1D80940 VA: 0x181D82340 Slot: 11
	internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D82670 Offset: 0x1D80C70 VA: 0x181D82670 Slot: 12
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D827E0 Offset: 0x1D80DE0 VA: 0x181D827E0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D82720 Offset: 0x1D80D20 VA: 0x181D82720
	private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class DurationFacetsChecker : FacetsChecker // TypeDefIndex: 7000
{
	// Methods

	// RVA: 0x1D7B700 Offset: 0x1D79D00 VA: 0x181D7B700 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D7B350 Offset: 0x1D79950 VA: 0x181D7B350 Slot: 15
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D7B820 Offset: 0x1D79E20 VA: 0x181D7B820 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D7B8B0 Offset: 0x1D79EB0 VA: 0x181D7B8B0
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class DateTimeFacetsChecker : FacetsChecker // TypeDefIndex: 7001
{
	// Methods

	// RVA: 0x1D782F0 Offset: 0x1D768F0 VA: 0x181D782F0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D77E90 Offset: 0x1D76490 VA: 0x181D77E90 Slot: 10
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D78380 Offset: 0x1D76980 VA: 0x181D78380 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D78410 Offset: 0x1D76A10 VA: 0x181D78410
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 7002
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0x1D843D0 Offset: 0x1D829D0 VA: 0x181D843D0
	private static Regex get_LanguagePattern() { }

	// RVA: 0x1D83D10 Offset: 0x1D82310 VA: 0x181D83D10 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D83CF0 Offset: 0x1D822F0 VA: 0x181D83CF0 Slot: 13
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D83DA0 Offset: 0x1D823A0 VA: 0x181D83DA0
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x1D841C0 Offset: 0x1D827C0 VA: 0x181D841C0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D83FF0 Offset: 0x1D825F0 VA: 0x181D83FF0
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1D83A00 Offset: 0x1D82000 VA: 0x181D83A00
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class QNameFacetsChecker : FacetsChecker // TypeDefIndex: 7003
{
	// Methods

	// RVA: 0x1BF97A0 Offset: 0x1BF7DA0 VA: 0x181BF97A0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1BF95B0 Offset: 0x1BF7BB0 VA: 0x181BF95B0 Slot: 16
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1BF9A00 Offset: 0x1BF8000 VA: 0x181BF9A00 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1BF98E0 Offset: 0x1BF7EE0 VA: 0x181BF98E0
	private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class MiscFacetsChecker : FacetsChecker // TypeDefIndex: 7004
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class BinaryFacetsChecker : FacetsChecker // TypeDefIndex: 7005
{
	// Methods

	// RVA: 0x1BE8880 Offset: 0x1BE6E80 VA: 0x181BE8880 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1BE8920 Offset: 0x1BE6F20 VA: 0x181BE8920 Slot: 14
	internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1BE8B00 Offset: 0x1BE7100 VA: 0x181BE8B00 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1BE8C60 Offset: 0x1BE7260 VA: 0x181BE8C60
	private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class ListFacetsChecker : FacetsChecker // TypeDefIndex: 7006
{
	// Methods

	// RVA: 0x1BE8D70 Offset: 0x1BE7370 VA: 0x181BE8D70 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1BE8FC0 Offset: 0x1BE75C0 VA: 0x181BE8FC0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class UnionFacetsChecker : FacetsChecker // TypeDefIndex: 7007
{
	// Methods

	// RVA: 0x1BF9B30 Offset: 0x1BF8130 VA: 0x181BF9B30 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1BE8FC0 Offset: 0x1BE75C0 VA: 0x181BE8FC0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public interface IXmlSchemaInfo // TypeDefIndex: 7008
{
	// Properties
	public abstract XmlSchemaValidity Validity { get; }
	public abstract bool IsDefault { get; }
	public abstract bool IsNil { get; }
	public abstract XmlSchemaSimpleType MemberType { get; }
	public abstract XmlSchemaType SchemaType { get; }
	public abstract XmlSchemaElement SchemaElement { get; }
	public abstract XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchemaValidity get_Validity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsDefault();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsNil();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract XmlSchemaSimpleType get_MemberType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_SchemaType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlSchemaElement get_SchemaElement();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlSchemaAttribute get_SchemaAttribute();
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaInference // TypeDefIndex: 7010
{
	// Fields
	internal static XmlQualifiedName ST_boolean; // 0x0
	internal static XmlQualifiedName ST_byte; // 0x8
	internal static XmlQualifiedName ST_unsignedByte; // 0x10
	internal static XmlQualifiedName ST_short; // 0x18
	internal static XmlQualifiedName ST_unsignedShort; // 0x20
	internal static XmlQualifiedName ST_int; // 0x28
	internal static XmlQualifiedName ST_unsignedInt; // 0x30
	internal static XmlQualifiedName ST_long; // 0x38
	internal static XmlQualifiedName ST_unsignedLong; // 0x40
	internal static XmlQualifiedName ST_integer; // 0x48
	internal static XmlQualifiedName ST_decimal; // 0x50
	internal static XmlQualifiedName ST_float; // 0x58
	internal static XmlQualifiedName ST_double; // 0x60
	internal static XmlQualifiedName ST_duration; // 0x68
	internal static XmlQualifiedName ST_dateTime; // 0x70
	internal static XmlQualifiedName ST_time; // 0x78
	internal static XmlQualifiedName ST_date; // 0x80
	internal static XmlQualifiedName ST_gYearMonth; // 0x88
	internal static XmlQualifiedName ST_string; // 0x90
	internal static XmlQualifiedName ST_anySimpleType; // 0x98
	internal static XmlQualifiedName[] SimpleTypes; // 0xA0
	private XmlSchema rootSchema; // 0x10
	private XmlSchemaSet schemaSet; // 0x18
	private XmlReader xtr; // 0x20
	private NameTable nametable; // 0x28
	private string TargetNamespace; // 0x30
	private XmlNamespaceManager NamespaceManager; // 0x38
	private ArrayList schemaList; // 0x40
	private XmlSchemaInference.InferenceOption occurrence; // 0x48
	private XmlSchemaInference.InferenceOption typeInference; // 0x4C

	// Properties
	public XmlSchemaInference.InferenceOption Occurrence { get; set; }
	public XmlSchemaInference.InferenceOption TypeInference { set; }

	// Methods

	// RVA: 0x12DF9A0 Offset: 0x12DDFA0 VA: 0x1812DF9A0
	public void set_Occurrence(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public XmlSchemaInference.InferenceOption get_Occurrence() { }

	// RVA: 0x9CC920 Offset: 0x9CAF20 VA: 0x1809CC920
	public void set_TypeInference(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x1C04070 Offset: 0x1C02670 VA: 0x181C04070
	public void .ctor() { }

	// RVA: 0x1C00380 Offset: 0x1BFE980 VA: 0x181C00380
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x1BFFAB0 Offset: 0x1BFE0B0 VA: 0x181BFFAB0
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x1BF9D70 Offset: 0x1BF8370 VA: 0x181BF9D70
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x1BFB1F0 Offset: 0x1BF97F0 VA: 0x181BFB1F0
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x1BFA690 Offset: 0x1BF8C90 VA: 0x181BFA690
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x1BFDE10 Offset: 0x1BFC410 VA: 0x181BFDE10
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1BFADC0 Offset: 0x1BF93C0 VA: 0x181BFADC0
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x1BFD220 Offset: 0x1BFB820 VA: 0x181BFD220
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x1BFBD50 Offset: 0x1BFA350 VA: 0x181BFBD50
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x1C01930 Offset: 0x1BFFF30 VA: 0x181C01930
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1C01590 Offset: 0x1BFFB90 VA: 0x181C01590
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x1C01630 Offset: 0x1BFFC30 VA: 0x181C01630
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x1BFB5F0 Offset: 0x1BF9BF0 VA: 0x181BFB5F0
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x1BFBAE0 Offset: 0x1BFA0E0 VA: 0x181BFBAE0
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	// RVA: 0x1BFB9B0 Offset: 0x1BF9FB0 VA: 0x181BFB9B0
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x1BFB360 Offset: 0x1BF9960 VA: 0x181BFB360
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x1BFB840 Offset: 0x1BF9E40 VA: 0x181BFB840
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x1C014C0 Offset: 0x1BFFAC0 VA: 0x181C014C0
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x1C03010 Offset: 0x1C01610 VA: 0x181C03010
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x1C02150 Offset: 0x1C00750 VA: 0x181C02150
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	// RVA: 0x1C00400 Offset: 0x1BFEA00 VA: 0x181C00400
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	// RVA: 0x1BFB290 Offset: 0x1BF9890 VA: 0x181BFB290
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x1BFAF40 Offset: 0x1BF9540 VA: 0x181BFAF40
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x1BFD3A0 Offset: 0x1BFB9A0 VA: 0x181BFD3A0
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x1C02E30 Offset: 0x1C01430 VA: 0x181C02E30
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x1C03160 Offset: 0x1C01760 VA: 0x181C03160
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaInferenceException : XmlSchemaException // TypeDefIndex: 7011
{
	// Methods

	// RVA: 0x1BF9D40 Offset: 0x1BF8340 VA: 0x181BF9D40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BF9C30 Offset: 0x1BF8230 VA: 0x181BF9C30 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BF9D60 Offset: 0x1BF8360 VA: 0x181BF9D60
	public void .ctor() { }

	// RVA: 0x1BF9C80 Offset: 0x1BF8280 VA: 0x181BF9C80
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1BF9C50 Offset: 0x1BF8250 VA: 0x181BF9C50
	internal void .ctor(string res, int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Schema
internal class NamespaceList // TypeDefIndex: 7013
{
	// Fields
	private NamespaceList.ListType type; // 0x10
	private Hashtable set; // 0x18
	private string targetNamespace; // 0x20

	// Properties
	public NamespaceList.ListType Type { get; }
	public string Excluded { get; }
	public ICollection Enumerate { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1BEA4F0 Offset: 0x1BE8AF0 VA: 0x181BEA4F0
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x1BE91F0 Offset: 0x1BE77F0 VA: 0x181BE91F0
	public NamespaceList Clone() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public NamespaceList.ListType get_Type() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Excluded() { }

	// RVA: 0x1BEA7A0 Offset: 0x1BE8DA0 VA: 0x181BEA7A0
	public ICollection get_Enumerate() { }

	// RVA: 0x1BE9130 Offset: 0x1BE7730 VA: 0x181BE9130 Slot: 4
	public virtual bool Allows(string ns) { }

	// RVA: 0x1BE91C0 Offset: 0x1BE77C0 VA: 0x181BE91C0
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1BE9C70 Offset: 0x1BE8270 VA: 0x181BE9C70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BE9960 Offset: 0x1BE7F60 VA: 0x181BE9960
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x1BEA050 Offset: 0x1BE8650 VA: 0x181BEA050
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1BE9370 Offset: 0x1BE7970 VA: 0x181BE9370
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x1BE94E0 Offset: 0x1BE7AE0 VA: 0x181BE94E0
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1BE9C10 Offset: 0x1BE8210 VA: 0x181BE9C10
	private void RemoveNamespace(string tns) { }
}

// Namespace: System.Xml.Schema
internal class NamespaceListV1Compat : NamespaceList // TypeDefIndex: 7014
{
	// Methods

	// RVA: 0x1BE9120 Offset: 0x1BE7720 VA: 0x181BE9120
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x1BE9080 Offset: 0x1BE7680 VA: 0x181BE9080 Slot: 4
	public override bool Allows(string ns) { }
}

// Namespace: System.Xml.Schema
internal sealed class Parser // TypeDefIndex: 7015
{
	// Fields
	private SchemaType schemaType; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ValidationEventHandler eventHandler; // 0x28
	private XmlNamespaceManager namespaceManager; // 0x30
	private XmlReader reader; // 0x38
	private PositionInfo positionInfo; // 0x40
	private bool isProcessNamespaces; // 0x48
	private int schemaXmlDepth; // 0x4C
	private int markupDepth; // 0x50
	private SchemaBuilder builder; // 0x58
	private XmlSchema schema; // 0x60
	private SchemaInfo xdrSchema; // 0x68
	private XmlResolver xmlResolver; // 0x70
	private XmlDocument dummyDocument; // 0x78
	private bool processMarkup; // 0x80
	private XmlNode parentNode; // 0x88
	private XmlNamespaceManager annotationNSManager; // 0x90
	private string xmlns; // 0x98
	private XmlCharType xmlCharType; // 0xA0

	// Properties
	public XmlSchema XmlSchema { get; }
	internal XmlResolver XmlResolver { set; }
	public SchemaInfo XdrSchema { get; }

	// Methods

	// RVA: 0x1BEC570 Offset: 0x1BEAB70 VA: 0x181BEC570
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1BEBC40 Offset: 0x1BEA240 VA: 0x181BEBC40
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1BEBFF0 Offset: 0x1BEA5F0 VA: 0x181BEBFF0
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1BEA820 Offset: 0x1BE8E20 VA: 0x181BEA820
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public SchemaType FinishParsing() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0x1BEB360 Offset: 0x1BE9960 VA: 0x181BEB360
	public bool ParseReaderNode() { }

	// RVA: 0x1BEBCB0 Offset: 0x1BEA2B0 VA: 0x181BEBCB0
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0x1BEAC30 Offset: 0x1BE9230 VA: 0x181BEAC30
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0x1BEA940 Offset: 0x1BE8F40 VA: 0x181BEA940
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0x1BEAA70 Offset: 0x1BE9070 VA: 0x181BEAA70
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x1BEB100 Offset: 0x1BE9700 VA: 0x181BEB100
	private XmlEntityReference LoadEntityReferenceInAttribute() { }
}

// Namespace: System.Xml.Schema
internal enum Compositor // TypeDefIndex: 7016
{
	// Fields
	public int value__; // 0x0
	public const Compositor Root = 0;
	public const Compositor Include = 1;
	public const Compositor Import = 2;
	public const Compositor Redefine = 3;
}

// Namespace: System.Xml.Schema
internal class RedefineEntry // TypeDefIndex: 7017
{
	// Fields
	internal XmlSchemaRedefine redefine; // 0x10
	internal XmlSchema schemaToUpdate; // 0x18

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(XmlSchemaRedefine external, XmlSchema schema) { }
}

// Namespace: System.Xml.Schema
internal sealed class Preprocessor : BaseProcessor // TypeDefIndex: 7018
{
	// Fields
	private string Xmlns; // 0x40
	private string NsXsi; // 0x48
	private string targetNamespace; // 0x50
	private XmlSchema rootSchema; // 0x58
	private XmlSchema currentSchema; // 0x60
	private XmlSchemaForm elementFormDefault; // 0x68
	private XmlSchemaForm attributeFormDefault; // 0x6C
	private XmlSchemaDerivationMethod blockDefault; // 0x70
	private XmlSchemaDerivationMethod finalDefault; // 0x74
	private Hashtable schemaLocations; // 0x78
	private Hashtable chameleonSchemas; // 0x80
	private Hashtable referenceNamespaces; // 0x88
	private Hashtable processedExternals; // 0x90
	private SortedList lockList; // 0x98
	private XmlReaderSettings readerSettings; // 0xA0
	private XmlSchema rootSchemaForRedefine; // 0xA8
	private ArrayList redefinedList; // 0xB0
	private static XmlSchema builtInSchemaForXmlNS; // 0x0
	private XmlResolver xmlResolver; // 0xB8

	// Properties
	internal XmlResolver XmlResolver { set; }
	internal XmlReaderSettings ReaderSettings { set; }
	internal Hashtable SchemaLocations { set; }
	internal Hashtable ChameleonSchemas { set; }
	internal XmlSchema RootSchema { get; }

	// Methods

	// RVA: 0x1BF94A0 Offset: 0x1BF7AA0 VA: 0x181BF94A0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1BEE690 Offset: 0x1BECC90 VA: 0x181BEE690
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x1BED2A0 Offset: 0x1BEB8A0 VA: 0x181BED2A0
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x1BED200 Offset: 0x1BEB800 VA: 0x181BED200
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x8221D0 Offset: 0x8207D0 VA: 0x1808221D0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal XmlSchema get_RootSchema() { }

	// RVA: 0x1BEC910 Offset: 0x1BEAF10 VA: 0x181BEC910
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x1BEF710 Offset: 0x1BEDD10 VA: 0x181BEF710
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0x1BEED10 Offset: 0x1BED310 VA: 0x181BEED10
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0x1BEC670 Offset: 0x1BEAC70 VA: 0x181BEC670
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x1BF0520 Offset: 0x1BEEB20 VA: 0x181BF0520
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x1BF6B40 Offset: 0x1BF5140 VA: 0x181BF6B40
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x1BED3A0 Offset: 0x1BEB9A0 VA: 0x181BED3A0
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x1BF43B0 Offset: 0x1BF29B0 VA: 0x181BF43B0
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x1BEF500 Offset: 0x1BEDB00 VA: 0x181BEF500
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x1BEF660 Offset: 0x1BEDC60 VA: 0x181BEF660
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x1BF8C50 Offset: 0x1BF7250 VA: 0x181BF8C50
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x1BEE370 Offset: 0x1BEC970 VA: 0x181BEE370
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x1BED010 Offset: 0x1BEB610 VA: 0x181BED010
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x1BECAB0 Offset: 0x1BEB0B0 VA: 0x181BECAB0
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1BED0C0 Offset: 0x1BEB6C0 VA: 0x181BED0C0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x1BECC10 Offset: 0x1BEB210 VA: 0x181BECC10
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1BF0AA0 Offset: 0x1BEF0A0 VA: 0x181BF0AA0
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1BF3170 Offset: 0x1BF1770 VA: 0x181BF3170
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1BF0750 Offset: 0x1BEED50 VA: 0x181BF0750
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1BF0970 Offset: 0x1BEEF70 VA: 0x181BF0970
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1BF2970 Offset: 0x1BF0F70 VA: 0x181BF2970
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1BF3330 Offset: 0x1BF1930 VA: 0x181BF3330
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1BF1E50 Offset: 0x1BF0450 VA: 0x181BF1E50
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x1BF2DC0 Offset: 0x1BF13C0 VA: 0x181BF2DC0
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1BF6170 Offset: 0x1BF4770 VA: 0x181BF6170
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1BF1420 Offset: 0x1BEFA20 VA: 0x181BF1420
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x1BF2BE0 Offset: 0x1BF11E0 VA: 0x181BF2BE0
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1BF3700 Offset: 0x1BF1D00 VA: 0x181BF3700
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1BF3920 Offset: 0x1BF1F20 VA: 0x181BF3920
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1BF0C30 Offset: 0x1BEF230 VA: 0x181BF0C30
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x1BF8D50 Offset: 0x1BF7350 VA: 0x181BF8D50
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1BF8FD0 Offset: 0x1BF75D0 VA: 0x181BF8FD0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1BF92D0 Offset: 0x1BF78D0 VA: 0x181BF92D0
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x1BF8BD0 Offset: 0x1BF71D0 VA: 0x181BF8BD0
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x1BEF6D0 Offset: 0x1BEDCD0 VA: 0x181BEF6D0
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x1BEF390 Offset: 0x1BED990 VA: 0x181BEF390
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x1BF8C20 Offset: 0x1BF7220 VA: 0x181BF8C20
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x1BF05F0 Offset: 0x1BEEBF0 VA: 0x181BF05F0
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1BF06C0 Offset: 0x1BEECC0 VA: 0x181BF06C0
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo // TypeDefIndex: 7020
{
	// Fields
	private string defExpanded; // 0x60
	private int lineNum; // 0x68
	private int linePos; // 0x6C
	private int valueLineNum; // 0x70
	private int valueLinePos; // 0x74
	private SchemaAttDef.Reserve reserved; // 0x78
	private bool defaultValueChecked; // 0x7C
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	// Properties
	private string System.Xml.IDtdAttributeInfo.Prefix { get; }
	private string System.Xml.IDtdAttributeInfo.LocalName { get; }
	private int System.Xml.IDtdAttributeInfo.LineNumber { get; }
	private int System.Xml.IDtdAttributeInfo.LinePosition { get; }
	private bool System.Xml.IDtdAttributeInfo.IsNonCDataType { get; }
	private bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdAttributeInfo.IsXmlAttribute { get; }
	private string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded { get; }
	private object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition { get; }
	internal int LinePosition { get; set; }
	internal int LineNumber { get; set; }
	internal int ValueLinePosition { get; set; }
	internal int ValueLineNumber { get; set; }
	internal string DefaultValueExpanded { get; set; }
	internal XmlTokenizedType TokenizedType { get; set; }
	internal SchemaAttDef.Reserve Reserved { get; set; }
	internal bool DefaultValueChecked { get; }
	internal XmlSchemaAttribute SchemaAttribute { get; set; }

	// Methods

	// RVA: 0x1C046E0 Offset: 0x1C02CE0 VA: 0x181C046E0
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1C046D0 Offset: 0x1C02CD0 VA: 0x181C046D0
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0x1C046F0 Offset: 0x1C02CF0 VA: 0x181C046F0
	private void .ctor() { }

	// RVA: 0x1C04630 Offset: 0x1C02C30 VA: 0x181C04630 Slot: 8
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0xBE5930 Offset: 0xBE3F30 VA: 0x180BE5930 Slot: 9
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0xC9D690 Offset: 0xC9BC90 VA: 0x180C9D690 Slot: 10
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0xC9D570 Offset: 0xC9BB70 VA: 0x180C9D570 Slot: 11
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x1C04600 Offset: 0x1C02C00 VA: 0x181C04600 Slot: 12
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180 Slot: 13
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x127D810 Offset: 0x127BE10 VA: 0x18127D810 Slot: 14
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x1C04640 Offset: 0x1C02C40 VA: 0x181C04640 Slot: 4
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 5
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0 Slot: 6
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0x19774D0 Offset: 0x1975AD0 VA: 0x1819774D0 Slot: 7
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0xC9D570 Offset: 0xC9BB70 VA: 0x180C9D570
	internal int get_LinePosition() { }

	// RVA: 0xC9D7A0 Offset: 0xC9BDA0 VA: 0x180C9D7A0
	internal void set_LinePosition(int value) { }

	// RVA: 0xC9D690 Offset: 0xC9BC90 VA: 0x180C9D690
	internal int get_LineNumber() { }

	// RVA: 0xC9D9F0 Offset: 0xC9BFF0 VA: 0x180C9D9F0
	internal void set_LineNumber(int value) { }

	// RVA: 0x19774D0 Offset: 0x1975AD0 VA: 0x1819774D0
	internal int get_ValueLinePosition() { }

	// RVA: 0x19774C0 Offset: 0x1975AC0 VA: 0x1819774C0
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0
	internal int get_ValueLineNumber() { }

	// RVA: 0x4A4300 Offset: 0x4A2900 VA: 0x1804A4300
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0x1C04710 Offset: 0x1C02D10 VA: 0x181C04710
	internal string get_DefaultValueExpanded() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0x1C04730 Offset: 0x1C02D30 VA: 0x181C04730
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1C04760 Offset: 0x1C02D60 VA: 0x181C04760
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x1869360 Offset: 0x1867960 VA: 0x181869360
	internal SchemaAttDef.Reserve get_Reserved() { }

	// RVA: 0x18693A0 Offset: 0x18679A0 VA: 0x1818693A0
	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	// RVA: 0x1C04700 Offset: 0x1C02D00 VA: 0x181C04700
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x1C042F0 Offset: 0x1C028F0 VA: 0x181C042F0
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x1C045A0 Offset: 0x1C02BA0 VA: 0x181C045A0
	internal SchemaAttDef Clone() { }

	// RVA: 0x1C04660 Offset: 0x1C02C60 VA: 0x181C04660
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class SchemaBuilder // TypeDefIndex: 7021
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool ProcessElement(string prefix, string name, string ns);

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void ProcessAttribute(string prefix, string name, string ns, string value);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool IsContentParsed();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void ProcessMarkup(XmlNode[] markup);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void ProcessCData(string value);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void StartChildren();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract void EndChildren();

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 7022
{
	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0x1C17AC0 Offset: 0x1C160C0 VA: 0x181C17AC0
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x1C143B0 Offset: 0x1C129B0 VA: 0x181C143B0
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x1C17700 Offset: 0x1C15D00 VA: 0x181C17700
	private void Prepare() { }

	// RVA: 0x1C08A90 Offset: 0x1C07090 VA: 0x181C08A90
	private void Cleanup() { }

	// RVA: 0x1C09840 Offset: 0x1C07E40 VA: 0x181C09840
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0x1C12090 Offset: 0x1C10690 VA: 0x181C12090
	private void Compile() { }

	// RVA: 0x1C16990 Offset: 0x1C14F90 VA: 0x181C16990
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1C080B0 Offset: 0x1C066B0 VA: 0x181C080B0
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1C08050 Offset: 0x1C06650 VA: 0x181C08050
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1C08200 Offset: 0x1C06800 VA: 0x181C08200
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C08A70 Offset: 0x1C07070 VA: 0x181C08A70
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1C08660 Offset: 0x1C06C60 VA: 0x181C08660
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1C08100 Offset: 0x1C06700 VA: 0x181C08100
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1C08830 Offset: 0x1C06E30 VA: 0x181C08830
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1C08870 Offset: 0x1C06E70 VA: 0x181C08870
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1C11B20 Offset: 0x1C10120 VA: 0x181C11B20
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x1C07CC0 Offset: 0x1C062C0 VA: 0x181C07CC0
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1C0EE70 Offset: 0x1C0D470 VA: 0x181C0EE70
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1C11150 Offset: 0x1C0F750 VA: 0x181C11150
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1C0B4E0 Offset: 0x1C09AE0 VA: 0x181C0B4E0
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1C07F10 Offset: 0x1C06510 VA: 0x181C07F10
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1C0D080 Offset: 0x1C0B680 VA: 0x181C0D080
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C10A70 Offset: 0x1C0F070 VA: 0x181C10A70
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1C10D10 Offset: 0x1C0F310 VA: 0x181C10D10
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1C0BA90 Offset: 0x1C0A090 VA: 0x181C0BA90
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x1C0BF90 Offset: 0x1C0A590 VA: 0x181C0BF90
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1C07B80 Offset: 0x1C06180 VA: 0x181C07B80
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C0DD20 Offset: 0x1C0C320 VA: 0x181C0DD20
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x1C070B0 Offset: 0x1C056B0 VA: 0x181C070B0
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x1C06870 Offset: 0x1C04E70 VA: 0x181C06870
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x1C06A20 Offset: 0x1C05020 VA: 0x181C06A20
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x1C05C20 Offset: 0x1C04220 VA: 0x181C05C20
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x1C061E0 Offset: 0x1C047E0 VA: 0x181C061E0
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x1C07570 Offset: 0x1C05B70 VA: 0x181C07570
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x1C15DB0 Offset: 0x1C143B0 VA: 0x181C15DB0
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1C14A60 Offset: 0x1C13060 VA: 0x181C14A60
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x1C149F0 Offset: 0x1C12FF0 VA: 0x181C149F0
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x1C14990 Offset: 0x1C12F90 VA: 0x181C14990
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x1C14F40 Offset: 0x1C13540 VA: 0x181C14F40
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1C14BA0 Offset: 0x1C131A0 VA: 0x181C14BA0
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1C15210 Offset: 0x1C13810 VA: 0x181C15210
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1C155A0 Offset: 0x1C13BA0 VA: 0x181C155A0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1C15910 Offset: 0x1C13F10 VA: 0x181C15910
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1C057F0 Offset: 0x1C03DF0 VA: 0x181C057F0
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1C15CA0 Offset: 0x1C142A0 VA: 0x181C15CA0
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1C15BD0 Offset: 0x1C141D0 VA: 0x181C15BD0
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1C146B0 Offset: 0x1C12CB0 VA: 0x181C146B0
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x1C154F0 Offset: 0x1C13AF0 VA: 0x181C154F0
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x1C04E20 Offset: 0x1C03420 VA: 0x181C04E20
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1C17A90 Offset: 0x1C16090 VA: 0x181C17A90
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C147B0 Offset: 0x1C12DB0 VA: 0x181C147B0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1C0A170 Offset: 0x1C08770 VA: 0x181C0A170
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1C0F600 Offset: 0x1C0DC00 VA: 0x181C0F600
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x1C0A0C0 Offset: 0x1C086C0 VA: 0x181C0A0C0
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1C0A010 Offset: 0x1C08610 VA: 0x181C0A010
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1C0A8D0 Offset: 0x1C08ED0 VA: 0x181C0A8D0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x1C0EF60 Offset: 0x1C0D560 VA: 0x181C0EF60
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x1C0DED0 Offset: 0x1C0C4D0 VA: 0x181C0DED0
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x1C0C310 Offset: 0x1C0A910 VA: 0x181C0C310
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C04790 Offset: 0x1C02D90 VA: 0x181C04790
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1C10770 Offset: 0x1C0ED70 VA: 0x181C10770
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x1C0B9C0 Offset: 0x1C09FC0 VA: 0x181C0B9C0
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C14830 Offset: 0x1C12E30 VA: 0x181C14830
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x1C145F0 Offset: 0x1C12BF0 VA: 0x181C145F0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x1C14430 Offset: 0x1C12A30 VA: 0x181C14430
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionPreprocessor : BaseProcessor // TypeDefIndex: 7024
{
	// Fields
	private XmlSchema schema; // 0x40
	private string targetNamespace; // 0x48
	private bool buildinIncluded; // 0x50
	private XmlSchemaForm elementFormDefault; // 0x54
	private XmlSchemaForm attributeFormDefault; // 0x58
	private XmlSchemaDerivationMethod blockDefault; // 0x5C
	private XmlSchemaDerivationMethod finalDefault; // 0x60
	private Hashtable schemaLocations; // 0x68
	private Hashtable referenceNamespaces; // 0x70
	private string Xmlns; // 0x78
	private XmlResolver xmlResolver; // 0x80

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x1C224D0 Offset: 0x1C20AD0 VA: 0x181C224D0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1C18A60 Offset: 0x1C17060 VA: 0x181C18A60
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x1C184F0 Offset: 0x1C16AF0 VA: 0x181C184F0
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1C18D90 Offset: 0x1C17390 VA: 0x181C18D90
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x1C17B90 Offset: 0x1C16190 VA: 0x181C17B90
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x1C1F990 Offset: 0x1C1DF90 VA: 0x181C1F990
	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	// RVA: 0x1C1CED0 Offset: 0x1C1B4D0 VA: 0x181C1CED0
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x1C18770 Offset: 0x1C16D70 VA: 0x181C18770
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x1C18320 Offset: 0x1C16920 VA: 0x181C18320
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x1C17DC0 Offset: 0x1C163C0 VA: 0x181C17DC0
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1C183B0 Offset: 0x1C169B0 VA: 0x181C183B0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x1C17F20 Offset: 0x1C16520 VA: 0x181C17F20
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1C19E10 Offset: 0x1C18410 VA: 0x181C19E10
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1C1BD90 Offset: 0x1C1A390 VA: 0x181C1BD90
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1C19AB0 Offset: 0x1C180B0 VA: 0x181C19AB0
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1C19CE0 Offset: 0x1C182E0 VA: 0x181C19CE0
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1C1B590 Offset: 0x1C19B90 VA: 0x181C1B590
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1C1BF50 Offset: 0x1C1A550 VA: 0x181C1BF50
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1C1B180 Offset: 0x1C19780 VA: 0x181C1B180
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x1C1B9E0 Offset: 0x1C19FE0 VA: 0x181C1B9E0
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1C1EFC0 Offset: 0x1C1D5C0 VA: 0x181C1EFC0
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1C1A750 Offset: 0x1C18D50 VA: 0x181C1A750
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x1C1B800 Offset: 0x1C19E00 VA: 0x181C1B800
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1C1C320 Offset: 0x1C1A920 VA: 0x181C1C320
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1C1C510 Offset: 0x1C1AB10 VA: 0x181C1C510
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1C19FA0 Offset: 0x1C185A0 VA: 0x181C19FA0
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x1C21E90 Offset: 0x1C20490 VA: 0x181C21E90
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1C220B0 Offset: 0x1C206B0 VA: 0x181C220B0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1C223B0 Offset: 0x1C209B0 VA: 0x181C223B0
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x1BF8C20 Offset: 0x1BF7220 VA: 0x181BF8C20
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x1C199A0 Offset: 0x1C17FA0 VA: 0x181C199A0
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1C21E40 Offset: 0x1C20440 VA: 0x181C21E40
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x1C18CE0 Offset: 0x1C172E0 VA: 0x181C18CE0
	private Stream GetSchemaEntity(Uri ruri) { }
}

// Namespace: System.Xml.Schema
internal abstract class SchemaDeclBase // TypeDefIndex: 7026
{
	// Fields
	protected XmlQualifiedName name; // 0x10
	protected string prefix; // 0x18
	protected bool isDeclaredInExternal; // 0x20
	protected SchemaDeclBase.Use presence; // 0x24
	protected XmlSchemaType schemaType; // 0x28
	protected XmlSchemaDatatype datatype; // 0x30
	protected string defaultValueRaw; // 0x38
	protected object defaultValueTyped; // 0x40
	protected long maxLength; // 0x48
	protected long minLength; // 0x50
	protected List<string> values; // 0x58

	// Properties
	internal XmlQualifiedName Name { get; set; }
	internal string Prefix { get; set; }
	internal bool IsDeclaredInExternal { get; set; }
	internal SchemaDeclBase.Use Presence { get; set; }
	internal long MaxLength { get; set; }
	internal long MinLength { get; set; }
	internal XmlSchemaType SchemaType { get; set; }
	internal XmlSchemaDatatype Datatype { get; set; }
	internal List<string> Values { get; set; }
	internal string DefaultValueRaw { get; set; }
	internal object DefaultValueTyped { get; set; }

	// Methods

	// RVA: 0x1C39FC0 Offset: 0x1C385C0 VA: 0x181C39FC0
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1C3A080 Offset: 0x1C38680 VA: 0x181C3A080
	protected void .ctor() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0x1C3A110 Offset: 0x1C38710 VA: 0x181C3A110
	internal string get_Prefix() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_Prefix(string value) { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	internal SchemaDeclBase.Use get_Presence() { }

	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	internal void set_Presence(SchemaDeclBase.Use value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal long get_MaxLength() { }

	// RVA: 0x1641130 Offset: 0x163F730 VA: 0x181641130
	internal void set_MaxLength(long value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal long get_MinLength() { }

	// RVA: 0x1C3A130 Offset: 0x1C38730 VA: 0x181C3A130
	internal void set_MinLength(long value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x1C39D90 Offset: 0x1C38390 VA: 0x181C39D90
	internal void AddValue(string value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	internal List<string> get_Values() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	internal void set_Values(List<string> value) { }

	// RVA: 0x1C3A0F0 Offset: 0x1C386F0 VA: 0x181C3A0F0
	internal string get_DefaultValueRaw() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal object get_DefaultValueTyped() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0x1C39E90 Offset: 0x1C38490 VA: 0x181C39E90
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0x1C39F60 Offset: 0x1C38560 VA: 0x181C39F60
	internal bool CheckValue(object pVal) { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo // TypeDefIndex: 7027
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; // 0x60
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; // 0x68
	private bool isIdDeclared; // 0x70
	private bool hasNonCDataAttribute; // 0x71
	private bool isAbstract; // 0x72
	private bool isNillable; // 0x73
	private bool hasRequiredAttribute; // 0x74
	private bool isNotationDeclared; // 0x75
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; // 0x78
	private ContentValidator contentValidator; // 0x80
	private XmlSchemaAnyAttribute anyAttribute; // 0x88
	private XmlSchemaDerivationMethod block; // 0x90
	private CompiledIdentityConstraint[] constraints; // 0x98
	private XmlSchemaElement schemaElement; // 0xA0
	internal static readonly SchemaElementDecl Empty; // 0x0

	// Properties
	private bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes { get; }
	internal bool IsIdDeclared { get; set; }
	internal bool HasNonCDataAttribute { get; set; }
	internal bool IsAbstract { get; set; }
	internal bool IsNillable { get; set; }
	internal XmlSchemaDerivationMethod Block { get; set; }
	internal bool IsNotationDeclared { get; set; }
	internal bool HasDefaultAttribute { get; }
	internal bool HasRequiredAttribute { get; }
	internal ContentValidator ContentValidator { get; set; }
	internal XmlSchemaAnyAttribute AnyAttribute { get; set; }
	internal CompiledIdentityConstraint[] Constraints { get; set; }
	internal XmlSchemaElement SchemaElement { get; set; }
	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs { get; }
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes { get; }

	// Methods

	// RVA: 0x1C3AAD0 Offset: 0x1C390D0 VA: 0x181C3AAD0
	internal void .ctor() { }

	// RVA: 0x1C3A7F0 Offset: 0x1C38DF0 VA: 0x181C3A7F0
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x1C3A970 Offset: 0x1C38F70 VA: 0x181C3A970
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1C3A580 Offset: 0x1C38B80 VA: 0x181C3A580
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x15B2F70 Offset: 0x15B1570 VA: 0x1815B2F70 Slot: 4
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x1C3A6D0 Offset: 0x1C38CD0 VA: 0x181C3A6D0 Slot: 5
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950 Slot: 6
	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0xBCFCF0 Offset: 0xBCE2F0 VA: 0x180BCFCF0
	internal bool get_IsIdDeclared() { }

	// RVA: 0xBD0F40 Offset: 0xBCF540 VA: 0x180BD0F40
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0x15B2F70 Offset: 0x15B1570 VA: 0x1815B2F70
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0x15B31C0 Offset: 0x15B17C0 VA: 0x1815B31C0
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x1C3A520 Offset: 0x1C38B20 VA: 0x181C3A520
	internal SchemaElementDecl Clone() { }

	// RVA: 0x1C3AC00 Offset: 0x1C39200 VA: 0x181C3AC00
	internal bool get_IsAbstract() { }

	// RVA: 0x1C3AC30 Offset: 0x1C39230 VA: 0x181C3AC30
	internal void set_IsAbstract(bool value) { }

	// RVA: 0x1C3AC10 Offset: 0x1C39210 VA: 0x181C3AC10
	internal bool get_IsNillable() { }

	// RVA: 0x1C3AC40 Offset: 0x1C39240 VA: 0x181C3AC40
	internal void set_IsNillable(bool value) { }

	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0xAC7EF0 Offset: 0xAC64F0 VA: 0x180AC7EF0
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1C3AC20 Offset: 0x1C39220 VA: 0x181C3AC20
	internal bool get_IsNotationDeclared() { }

	// RVA: 0x1C3AC50 Offset: 0x1C39250 VA: 0x181C3AC50
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0x1C3ABE0 Offset: 0x1C391E0 VA: 0x181C3ABE0
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0x1C3ABF0 Offset: 0x1C391F0 VA: 0x181C3ABF0
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x1C3A140 Offset: 0x1C38740 VA: 0x181C3A140
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x1C3A650 Offset: 0x1C38C50 VA: 0x181C3A650
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x1C3A2A0 Offset: 0x1C388A0 VA: 0x181C3A2A0
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x1C3A780 Offset: 0x1C38D80 VA: 0x181C3A780
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaEntity : IDtdEntityInfo // TypeDefIndex: 7028
{
	// Fields
	private XmlQualifiedName qname; // 0x10
	private string url; // 0x18
	private string pubid; // 0x20
	private string text; // 0x28
	private XmlQualifiedName ndata; // 0x30
	private int lineNumber; // 0x38
	private int linePosition; // 0x3C
	private bool isParameter; // 0x40
	private bool isExternal; // 0x41
	private bool parsingInProgress; // 0x42
	private bool isDeclaredInExternal; // 0x43
	private string baseURI; // 0x48
	private string declaredURI; // 0x50

	// Properties
	private string System.Xml.IDtdEntityInfo.Name { get; }
	private bool System.Xml.IDtdEntityInfo.IsExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsUnparsedEntity { get; }
	private bool System.Xml.IDtdEntityInfo.IsParameterEntity { get; }
	private string System.Xml.IDtdEntityInfo.BaseUriString { get; }
	private string System.Xml.IDtdEntityInfo.DeclaredUriString { get; }
	private string System.Xml.IDtdEntityInfo.SystemId { get; }
	private string System.Xml.IDtdEntityInfo.PublicId { get; }
	private string System.Xml.IDtdEntityInfo.Text { get; }
	private int System.Xml.IDtdEntityInfo.LineNumber { get; }
	private int System.Xml.IDtdEntityInfo.LinePosition { get; }
	internal XmlQualifiedName Name { get; }
	internal string Url { get; set; }
	internal string Pubid { get; set; }
	internal bool IsExternal { get; set; }
	internal bool DeclaredInExternal { get; set; }
	internal XmlQualifiedName NData { get; set; }
	internal string Text { get; set; }
	internal int Line { get; set; }
	internal int Pos { get; set; }
	internal string BaseURI { get; set; }
	internal bool ParsingInProgress { get; set; }
	internal string DeclaredURI { get; set; }

	// Methods

	// RVA: 0x1C3ADA0 Offset: 0x1C393A0 VA: 0x181C3ADA0
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0xBE5930 Offset: 0xBE3F30 VA: 0x180BE5930 Slot: 4
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x14BFB70 Offset: 0x14BE170 VA: 0x1814BFB70 Slot: 5
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x14BFB60 Offset: 0x14BE160 VA: 0x1814BFB60 Slot: 6
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x1C3AD70 Offset: 0x1C39370 VA: 0x181C3AD70 Slot: 7
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0 Slot: 8
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x1C3AD30 Offset: 0x1C39330 VA: 0x181C3AD30 Slot: 9
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x1C3AD50 Offset: 0x1C39350 VA: 0x181C3AD50 Slot: 10
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 11
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 12
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 13
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 14
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0 Slot: 15
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x1C3AC60 Offset: 0x1C39260 VA: 0x181C3AC60
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal string get_Url() { }

	// RVA: 0x1C3AED0 Offset: 0x1C394D0 VA: 0x181C3AED0
	internal void set_Url(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal string get_Pubid() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_Pubid(string value) { }

	// RVA: 0x14BFB70 Offset: 0x14BE170 VA: 0x1814BFB70
	internal bool get_IsExternal() { }

	// RVA: 0x1C3AE90 Offset: 0x1C39490 VA: 0x181C3AE90
	internal void set_IsExternal(bool value) { }

	// RVA: 0x14BFB60 Offset: 0x14BE160 VA: 0x1814BFB60
	internal bool get_DeclaredInExternal() { }

	// RVA: 0x1C3AE80 Offset: 0x1C39480 VA: 0x181C3AE80
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal string get_Text() { }

	// RVA: 0x1C3AEB0 Offset: 0x1C394B0 VA: 0x181C3AEB0
	internal void set_Text(string value) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	internal int get_Line() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	internal void set_Line(int value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	internal int get_Pos() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	internal void set_Pos(int value) { }

	// RVA: 0x1C3AE40 Offset: 0x1C39440 VA: 0x181C3AE40
	internal string get_BaseURI() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	internal void set_BaseURI(string value) { }

	// RVA: 0x178BFD0 Offset: 0x178A5D0 VA: 0x18178BFD0
	internal bool get_ParsingInProgress() { }

	// RVA: 0x1C3AEA0 Offset: 0x1C394A0 VA: 0x181C3AEA0
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0x1C3AE60 Offset: 0x1C39460 VA: 0x181C3AE60
	internal string get_DeclaredURI() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	internal void set_DeclaredURI(string value) { }
}

// Namespace: System.Xml.Schema
internal enum AttributeMatchState // TypeDefIndex: 7029
{
	// Fields
	public int value__; // 0x0
	public const AttributeMatchState AttributeFound = 0;
	public const AttributeMatchState AnyIdAttributeFound = 1;
	public const AttributeMatchState UndeclaredElementAndAttribute = 2;
	public const AttributeMatchState UndeclaredAttribute = 3;
	public const AttributeMatchState AnyAttributeLax = 4;
	public const AttributeMatchState AnyAttributeSkip = 5;
	public const AttributeMatchState ProhibitedAnyAttribute = 6;
	public const AttributeMatchState ProhibitedAttribute = 7;
	public const AttributeMatchState AttributeNameMismatch = 8;
	public const AttributeMatchState ValidateAttributeInvalidCall = 9;
}

// Namespace: System.Xml.Schema
internal class SchemaInfo : IDtdInfo // TypeDefIndex: 7030
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; // 0x10
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; // 0x18
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; // 0x20
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; // 0x28
	private XmlQualifiedName docTypeName; // 0x30
	private string internalDtdSubset; // 0x38
	private bool hasNonCDataAttributes; // 0x40
	private bool hasDefaultAttributes; // 0x41
	private Dictionary<string, bool> targetNamespaces; // 0x48
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; // 0x50
	private int errorCount; // 0x58
	private SchemaType schemaType; // 0x5C
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; // 0x60
	private Dictionary<string, SchemaNotation> notations; // 0x68

	// Properties
	public XmlQualifiedName DocTypeName { get; set; }
	internal string InternalDtdSubset { set; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities { get; }
	internal SchemaType SchemaType { get; set; }
	internal Dictionary<string, bool> TargetNamespaces { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls { get; }
	internal Dictionary<string, SchemaNotation> Notations { get; }
	internal int ErrorCount { get; set; }
	private bool System.Xml.IDtdInfo.HasDefaultAttributes { get; }
	private bool System.Xml.IDtdInfo.HasNonCDataAttributes { get; }
	private XmlQualifiedName System.Xml.IDtdInfo.Name { get; }
	private string System.Xml.IDtdInfo.InternalDtdSubset { get; }

	// Methods

	// RVA: 0x1C3C340 Offset: 0x1C3A940 VA: 0x181C3C340
	internal void .ctor() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x1C3C510 Offset: 0x1C3AB10 VA: 0x181C3C510
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x1C3C610 Offset: 0x1C3AC10 VA: 0x181C3C610
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x15B2E40 Offset: 0x15B1440 VA: 0x1815B2E40
	internal SchemaType get_SchemaType() { }

	// RVA: 0x1C3C690 Offset: 0x1C3AC90 VA: 0x181C3C690
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal Dictionary<string, bool> get_TargetNamespaces() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x1C3C590 Offset: 0x1C3AB90 VA: 0x181C3C590
	internal Dictionary<string, SchemaNotation> get_Notations() { }

	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0
	internal int get_ErrorCount() { }

	// RVA: 0x399820 Offset: 0x397E20 VA: 0x180399820
	internal void set_ErrorCount(int value) { }

	// RVA: 0x1C3BFB0 Offset: 0x1C3A5B0 VA: 0x181C3BFB0
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x1C3C0C0 Offset: 0x1C3A6C0 VA: 0x181C3C0C0
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x1C3C030 Offset: 0x1C3A630 VA: 0x181C3C030
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x1C3C140 Offset: 0x1C3A740 VA: 0x181C3C140
	internal bool HasSchema(string ns) { }

	// RVA: 0x1C3B830 Offset: 0x1C39E30 VA: 0x181C3B830
	internal bool Contains(string ns) { }

	// RVA: 0x1C3BA20 Offset: 0x1C3A020 VA: 0x181C3BA20
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x1C3BD30 Offset: 0x1C3A330 VA: 0x181C3BD30
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	// RVA: 0x1C3BBE0 Offset: 0x1C3A1E0 VA: 0x181C3BBE0
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	// RVA: 0x1C3AEF0 Offset: 0x1C394F0 VA: 0x181C3AEF0
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x1C3B890 Offset: 0x1C39E90 VA: 0x181C3B890
	internal void Finish() { }

	// RVA: 0x14BFB70 Offset: 0x14BE170 VA: 0x1814BFB70 Slot: 6
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0 Slot: 7
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x1C3C1A0 Offset: 0x1C3A7A0 VA: 0x181C3C1A0 Slot: 8
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x1C3C270 Offset: 0x1C3A870 VA: 0x181C3C270 Slot: 9
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 4
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 5
	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaNames // TypeDefIndex: 7032
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	public string NsDataType; // 0x18
	public string NsDataTypeAlias; // 0x20
	public string NsDataTypeOld; // 0x28
	public string NsXml; // 0x30
	public string NsXmlNs; // 0x38
	public string NsXdr; // 0x40
	public string NsXdrAlias; // 0x48
	public string NsXs; // 0x50
	public string NsXsi; // 0x58
	public string XsiType; // 0x60
	public string XsiNil; // 0x68
	public string XsiSchemaLocation; // 0x70
	public string XsiNoNamespaceSchemaLocation; // 0x78
	public string XsdSchema; // 0x80
	public string XdrSchema; // 0x88
	public XmlQualifiedName QnPCData; // 0x90
	public XmlQualifiedName QnXml; // 0x98
	public XmlQualifiedName QnXmlNs; // 0xA0
	public XmlQualifiedName QnDtDt; // 0xA8
	public XmlQualifiedName QnXmlLang; // 0xB0
	public XmlQualifiedName QnName; // 0xB8
	public XmlQualifiedName QnType; // 0xC0
	public XmlQualifiedName QnMaxOccurs; // 0xC8
	public XmlQualifiedName QnMinOccurs; // 0xD0
	public XmlQualifiedName QnInfinite; // 0xD8
	public XmlQualifiedName QnModel; // 0xE0
	public XmlQualifiedName QnOpen; // 0xE8
	public XmlQualifiedName QnClosed; // 0xF0
	public XmlQualifiedName QnContent; // 0xF8
	public XmlQualifiedName QnMixed; // 0x100
	public XmlQualifiedName QnEmpty; // 0x108
	public XmlQualifiedName QnEltOnly; // 0x110
	public XmlQualifiedName QnTextOnly; // 0x118
	public XmlQualifiedName QnOrder; // 0x120
	public XmlQualifiedName QnSeq; // 0x128
	public XmlQualifiedName QnOne; // 0x130
	public XmlQualifiedName QnMany; // 0x138
	public XmlQualifiedName QnRequired; // 0x140
	public XmlQualifiedName QnYes; // 0x148
	public XmlQualifiedName QnNo; // 0x150
	public XmlQualifiedName QnString; // 0x158
	public XmlQualifiedName QnID; // 0x160
	public XmlQualifiedName QnIDRef; // 0x168
	public XmlQualifiedName QnIDRefs; // 0x170
	public XmlQualifiedName QnEntity; // 0x178
	public XmlQualifiedName QnEntities; // 0x180
	public XmlQualifiedName QnNmToken; // 0x188
	public XmlQualifiedName QnNmTokens; // 0x190
	public XmlQualifiedName QnEnumeration; // 0x198
	public XmlQualifiedName QnDefault; // 0x1A0
	public XmlQualifiedName QnXdrSchema; // 0x1A8
	public XmlQualifiedName QnXdrElementType; // 0x1B0
	public XmlQualifiedName QnXdrElement; // 0x1B8
	public XmlQualifiedName QnXdrGroup; // 0x1C0
	public XmlQualifiedName QnXdrAttributeType; // 0x1C8
	public XmlQualifiedName QnXdrAttribute; // 0x1D0
	public XmlQualifiedName QnXdrDataType; // 0x1D8
	public XmlQualifiedName QnXdrDescription; // 0x1E0
	public XmlQualifiedName QnXdrExtends; // 0x1E8
	public XmlQualifiedName QnXdrAliasSchema; // 0x1F0
	public XmlQualifiedName QnDtType; // 0x1F8
	public XmlQualifiedName QnDtValues; // 0x200
	public XmlQualifiedName QnDtMaxLength; // 0x208
	public XmlQualifiedName QnDtMinLength; // 0x210
	public XmlQualifiedName QnDtMax; // 0x218
	public XmlQualifiedName QnDtMin; // 0x220
	public XmlQualifiedName QnDtMinExclusive; // 0x228
	public XmlQualifiedName QnDtMaxExclusive; // 0x230
	public XmlQualifiedName QnTargetNamespace; // 0x238
	public XmlQualifiedName QnVersion; // 0x240
	public XmlQualifiedName QnFinalDefault; // 0x248
	public XmlQualifiedName QnBlockDefault; // 0x250
	public XmlQualifiedName QnFixed; // 0x258
	public XmlQualifiedName QnAbstract; // 0x260
	public XmlQualifiedName QnBlock; // 0x268
	public XmlQualifiedName QnSubstitutionGroup; // 0x270
	public XmlQualifiedName QnFinal; // 0x278
	public XmlQualifiedName QnNillable; // 0x280
	public XmlQualifiedName QnRef; // 0x288
	public XmlQualifiedName QnBase; // 0x290
	public XmlQualifiedName QnDerivedBy; // 0x298
	public XmlQualifiedName QnNamespace; // 0x2A0
	public XmlQualifiedName QnProcessContents; // 0x2A8
	public XmlQualifiedName QnRefer; // 0x2B0
	public XmlQualifiedName QnPublic; // 0x2B8
	public XmlQualifiedName QnSystem; // 0x2C0
	public XmlQualifiedName QnSchemaLocation; // 0x2C8
	public XmlQualifiedName QnValue; // 0x2D0
	public XmlQualifiedName QnUse; // 0x2D8
	public XmlQualifiedName QnForm; // 0x2E0
	public XmlQualifiedName QnElementFormDefault; // 0x2E8
	public XmlQualifiedName QnAttributeFormDefault; // 0x2F0
	public XmlQualifiedName QnItemType; // 0x2F8
	public XmlQualifiedName QnMemberTypes; // 0x300
	public XmlQualifiedName QnXPath; // 0x308
	public XmlQualifiedName QnXsdSchema; // 0x310
	public XmlQualifiedName QnXsdAnnotation; // 0x318
	public XmlQualifiedName QnXsdInclude; // 0x320
	public XmlQualifiedName QnXsdImport; // 0x328
	public XmlQualifiedName QnXsdElement; // 0x330
	public XmlQualifiedName QnXsdAttribute; // 0x338
	public XmlQualifiedName QnXsdAttributeGroup; // 0x340
	public XmlQualifiedName QnXsdAnyAttribute; // 0x348
	public XmlQualifiedName QnXsdGroup; // 0x350
	public XmlQualifiedName QnXsdAll; // 0x358
	public XmlQualifiedName QnXsdChoice; // 0x360
	public XmlQualifiedName QnXsdSequence; // 0x368
	public XmlQualifiedName QnXsdAny; // 0x370
	public XmlQualifiedName QnXsdNotation; // 0x378
	public XmlQualifiedName QnXsdSimpleType; // 0x380
	public XmlQualifiedName QnXsdComplexType; // 0x388
	public XmlQualifiedName QnXsdUnique; // 0x390
	public XmlQualifiedName QnXsdKey; // 0x398
	public XmlQualifiedName QnXsdKeyRef; // 0x3A0
	public XmlQualifiedName QnXsdSelector; // 0x3A8
	public XmlQualifiedName QnXsdField; // 0x3B0
	public XmlQualifiedName QnXsdMinExclusive; // 0x3B8
	public XmlQualifiedName QnXsdMinInclusive; // 0x3C0
	public XmlQualifiedName QnXsdMaxInclusive; // 0x3C8
	public XmlQualifiedName QnXsdMaxExclusive; // 0x3D0
	public XmlQualifiedName QnXsdTotalDigits; // 0x3D8
	public XmlQualifiedName QnXsdFractionDigits; // 0x3E0
	public XmlQualifiedName QnXsdLength; // 0x3E8
	public XmlQualifiedName QnXsdMinLength; // 0x3F0
	public XmlQualifiedName QnXsdMaxLength; // 0x3F8
	public XmlQualifiedName QnXsdEnumeration; // 0x400
	public XmlQualifiedName QnXsdPattern; // 0x408
	public XmlQualifiedName QnXsdDocumentation; // 0x410
	public XmlQualifiedName QnXsdAppinfo; // 0x418
	public XmlQualifiedName QnSource; // 0x420
	public XmlQualifiedName QnXsdComplexContent; // 0x428
	public XmlQualifiedName QnXsdSimpleContent; // 0x430
	public XmlQualifiedName QnXsdRestriction; // 0x438
	public XmlQualifiedName QnXsdExtension; // 0x440
	public XmlQualifiedName QnXsdUnion; // 0x448
	public XmlQualifiedName QnXsdList; // 0x450
	public XmlQualifiedName QnXsdWhiteSpace; // 0x458
	public XmlQualifiedName QnXsdRedefine; // 0x460
	public XmlQualifiedName QnXsdAnyType; // 0x468
	internal XmlQualifiedName[] TokenToQName; // 0x470

	// Methods

	// RVA: 0x1C3F830 Offset: 0x1C3DE30 VA: 0x181C3F830
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1C3C6A0 Offset: 0x1C3ACA0 VA: 0x181C3C6A0
	public void CreateTokenToQNameTable() { }

	// RVA: 0x1C3F770 Offset: 0x1C3DD70 VA: 0x181C3F770
	public SchemaType SchemaTypeFromRoot(string localName, string ns) { }

	// RVA: 0x1C3F720 Offset: 0x1C3DD20 VA: 0x181C3F720
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1C3F6D0 Offset: 0x1C3DCD0 VA: 0x181C3F6D0
	public bool IsXDRRoot(string localName, string ns) { }
}

// Namespace: System.Xml.Schema
internal class SchemaNamespaceManager : XmlNamespaceManager // TypeDefIndex: 7033
{
	// Fields
	private XmlSchemaObject node; // 0x50

	// Methods

	// RVA: 0x1C42FA0 Offset: 0x1C415A0 VA: 0x181C42FA0
	public void .ctor(XmlSchemaObject node) { }

	// RVA: 0x1C42B40 Offset: 0x1C41140 VA: 0x181C42B40 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1C42CA0 Offset: 0x1C412A0 VA: 0x181C42CA0 Slot: 17
	public override string LookupPrefix(string ns) { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaNotation // TypeDefIndex: 7034
{
	// Fields
	private XmlQualifiedName name; // 0x10
	private string systemLiteral; // 0x18
	private string pubid; // 0x20

	// Properties
	internal XmlQualifiedName Name { get; }
	internal string SystemLiteral { get; set; }
	internal string Pubid { get; set; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal string get_SystemLiteral() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal string get_Pubid() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_Pubid(string value) { }
}

// Namespace: System.Xml.Schema
internal sealed class Compiler : BaseProcessor // TypeDefIndex: 7035
{
	// Fields
	private string restrictionErrorMsg; // 0x40
	private XmlSchemaObjectTable attributes; // 0x48
	private XmlSchemaObjectTable attributeGroups; // 0x50
	private XmlSchemaObjectTable elements; // 0x58
	private XmlSchemaObjectTable schemaTypes; // 0x60
	private XmlSchemaObjectTable groups; // 0x68
	private XmlSchemaObjectTable notations; // 0x70
	private XmlSchemaObjectTable examplars; // 0x78
	private XmlSchemaObjectTable identityConstraints; // 0x80
	private Stack complexTypeStack; // 0x88
	private Hashtable schemasToCompile; // 0x90
	private Hashtable importedSchemas; // 0x98
	private XmlSchema schemaForSchema; // 0xA0

	// Methods

	// RVA: 0x1C39B00 Offset: 0x1C38100 VA: 0x181C39B00
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1C31510 Offset: 0x1C2FB10 VA: 0x181C31510
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x1C36CC0 Offset: 0x1C352C0 VA: 0x181C36CC0
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x1C399B0 Offset: 0x1C37FB0 VA: 0x181C399B0
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0x1C35DE0 Offset: 0x1C343E0 VA: 0x181C35DE0
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1C31A20 Offset: 0x1C30020 VA: 0x181C31A20
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x1C2F530 Offset: 0x1C2DB30 VA: 0x181C2F530
	internal bool Compile() { }

	// RVA: 0x1C26410 Offset: 0x1C24A10 VA: 0x181C26410
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1C26390 Offset: 0x1C24990 VA: 0x181C26390
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1C266C0 Offset: 0x1C24CC0 VA: 0x181C266C0
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C27310 Offset: 0x1C25910 VA: 0x181C27310
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1C26C30 Offset: 0x1C25230 VA: 0x181C26C30
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1C26510 Offset: 0x1C24B10 VA: 0x181C26510
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1C26EB0 Offset: 0x1C254B0 VA: 0x181C26EB0
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1C26F10 Offset: 0x1C25510 VA: 0x181C26F10
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1C38E30 Offset: 0x1C37430 VA: 0x181C38E30
	private void ProcessSubstitutionGroups() { }

	// RVA: 0x1C2EF40 Offset: 0x1C2D540 VA: 0x181C2EF40
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1C39610 Offset: 0x1C37C10 VA: 0x181C39610
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x1C39580 Offset: 0x1C37B80 VA: 0x181C39580
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x1C2BFF0 Offset: 0x1C2A5F0 VA: 0x181C2BFF0
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1C2E540 Offset: 0x1C2CB40 VA: 0x181C2E540
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1C28750 Offset: 0x1C26D50 VA: 0x181C28750
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1C26250 Offset: 0x1C24850 VA: 0x181C26250
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1C2A1F0 Offset: 0x1C287F0 VA: 0x181C2A1F0
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C2DE60 Offset: 0x1C2C460 VA: 0x181C2DE60
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1C2E100 Offset: 0x1C2C700 VA: 0x181C2E100
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1C28C30 Offset: 0x1C27230 VA: 0x181C28C30
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x1C29050 Offset: 0x1C27650 VA: 0x181C29050
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1C25C20 Offset: 0x1C24220 VA: 0x181C25C20
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C26170 Offset: 0x1C24770 VA: 0x181C26170
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1C2ADB0 Offset: 0x1C293B0 VA: 0x181C2ADB0
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1C24640 Offset: 0x1C22C40 VA: 0x181C24640
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x1C23D20 Offset: 0x1C22320 VA: 0x181C23D20
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x1C23FC0 Offset: 0x1C225C0 VA: 0x181C23FC0
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x1C23350 Offset: 0x1C21950 VA: 0x181C23350
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x1C23660 Offset: 0x1C21C60 VA: 0x181C23660
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x1C24E00 Offset: 0x1C23400 VA: 0x181C24E00
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x1C24940 Offset: 0x1C22F40 VA: 0x181C24940
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x1C34210 Offset: 0x1C32810 VA: 0x181C34210
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1C31FF0 Offset: 0x1C305F0 VA: 0x181C31FF0
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x1C31E00 Offset: 0x1C30400 VA: 0x181C31E00
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x1C31B30 Offset: 0x1C30130 VA: 0x181C31B30
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x1C32E80 Offset: 0x1C31480 VA: 0x181C32E80
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1C32270 Offset: 0x1C30870 VA: 0x181C32270
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x1C31C40 Offset: 0x1C30240 VA: 0x181C31C40
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1C33370 Offset: 0x1C31970 VA: 0x181C33370
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1C33860 Offset: 0x1C31E60 VA: 0x181C33860
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1C33BD0 Offset: 0x1C321D0 VA: 0x181C33BD0
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1C34100 Offset: 0x1C32700 VA: 0x181C34100
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1C34030 Offset: 0x1C32630 VA: 0x181C34030
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1C31840 Offset: 0x1C2FE40 VA: 0x181C31840
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x1C336D0 Offset: 0x1C31CD0 VA: 0x181C336D0
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x1C22B70 Offset: 0x1C21170 VA: 0x181C22B70
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1C39550 Offset: 0x1C37B50 VA: 0x181C39550
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C147B0 Offset: 0x1C12DB0 VA: 0x181C147B0
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1C27530 Offset: 0x1C25B30 VA: 0x181C27530
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1C2C770 Offset: 0x1C2AD70 VA: 0x181C2C770
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x1C25420 Offset: 0x1C23A20 VA: 0x181C25420
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x1C33780 Offset: 0x1C31D80 VA: 0x181C33780
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x1C27480 Offset: 0x1C25A80 VA: 0x181C27480
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1C273D0 Offset: 0x1C259D0 VA: 0x181C273D0
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1C27DC0 Offset: 0x1C263C0 VA: 0x181C27DC0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x1C397B0 Offset: 0x1C37DB0 VA: 0x181C397B0
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x1C2C0D0 Offset: 0x1C2A6D0 VA: 0x181C2C0D0
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x1C2AF50 Offset: 0x1C29550 VA: 0x181C2AF50
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x1C293A0 Offset: 0x1C279A0 VA: 0x181C293A0
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C224E0 Offset: 0x1C20AE0 VA: 0x181C224E0
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1C2DB60 Offset: 0x1C2C160 VA: 0x181C2DB60
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x1C2D950 Offset: 0x1C2BF50 VA: 0x181C2D950
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x1C2A0C0 Offset: 0x1C286C0 VA: 0x181C2A0C0
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1C31940 Offset: 0x1C2FF40 VA: 0x181C31940
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x1C31790 Offset: 0x1C2FD90 VA: 0x181C31790
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x1C315E0 Offset: 0x1C2FBE0 VA: 0x181C315E0
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x1C31480 Offset: 0x1C2FA80 VA: 0x181C31480
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x1C32CF0 Offset: 0x1C312F0 VA: 0x181C32CF0
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }
}

// Namespace: System.Xml.Schema
internal enum SchemaType // TypeDefIndex: 7036
{
	// Fields
	public int value__; // 0x0
	public const SchemaType None = 0;
	public const SchemaType DTD = 1;
	public const SchemaType XDR = 2;
	public const SchemaType XSD = 3;
}

// Namespace: System.Xml.Schema
public class ValidationEventArgs : EventArgs // TypeDefIndex: 7037
{
	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Properties
	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }

	// Methods

	// RVA: 0x1C43320 Offset: 0x1C41920 VA: 0x181C43320
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0x1C43390 Offset: 0x1C41990 VA: 0x181C43390
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public XmlSeverityType get_Severity() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public XmlSchemaException get_Exception() { }
}

// Namespace: System.Xml.Schema
public sealed class ValidationEventHandler : MulticastDelegate // TypeDefIndex: 7038
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, ValidationEventArgs e) { }
}

// Namespace: System.Xml.Schema
internal struct StateUnion // TypeDefIndex: 7039
{
	// Fields
	public int State; // 0x0
	public int AllElementsRequired; // 0x0
	public int CurPosIndex; // 0x0
	public int NumberOfRunningPos; // 0x0
}

// Namespace: System.Xml.Schema
internal sealed class ValidationState // TypeDefIndex: 7040
{
	// Fields
	public bool IsNill; // 0x10
	public bool IsDefault; // 0x11
	public bool NeedValidateChildren; // 0x12
	public bool CheckRequiredAttribute; // 0x13
	public bool ValidationSkipped; // 0x14
	public XmlSchemaContentProcessing ProcessContents; // 0x18
	public XmlSchemaValidity Validity; // 0x1C
	public SchemaElementDecl ElementDecl; // 0x20
	public SchemaElementDecl ElementDeclBeforeXsi; // 0x28
	public string LocalName; // 0x30
	public string Namespace; // 0x38
	public ConstraintStruct[] Constr; // 0x40
	public StateUnion CurrentState; // 0x48
	public bool HasMatched; // 0x4C
	public BitSet[] CurPos; // 0x50
	public BitSet AllElementsSet; // 0x58
	public List<RangePositionInfo> RunningPositions; // 0x60
	public bool TooComplex; // 0x68

	// Methods

	// RVA: 0x1C43410 Offset: 0x1C41A10 VA: 0x181C43410
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class XdrBuilder : SchemaBuilder // TypeDefIndex: 7051
{
	// Fields
	private static readonly int[] S_XDR_Root_Element; // 0x0
	private static readonly int[] S_XDR_Root_SubElements; // 0x8
	private static readonly int[] S_XDR_ElementType_SubElements; // 0x10
	private static readonly int[] S_XDR_AttributeType_SubElements; // 0x18
	private static readonly int[] S_XDR_Group_SubElements; // 0x20
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes; // 0x28
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes; // 0x30
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes; // 0x38
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes; // 0x40
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes; // 0x48
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes; // 0x50
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; // 0x58
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; // 0x60
	private static readonly XdrBuilder.XdrEntry[] S_SchemaEntries; // 0x68
	private SchemaInfo _SchemaInfo; // 0x10
	private string _TargetNamespace; // 0x18
	private XmlReader _reader; // 0x20
	private PositionInfo positionInfo; // 0x28
	private ParticleContentValidator _contentValidator; // 0x30
	private XdrBuilder.XdrEntry _CurState; // 0x38
	private XdrBuilder.XdrEntry _NextState; // 0x40
	private HWStack _StateHistory; // 0x48
	private HWStack _GroupStack; // 0x50
	private string _XdrName; // 0x58
	private string _XdrPrefix; // 0x60
	private XdrBuilder.ElementContent _ElementDef; // 0x68
	private XdrBuilder.GroupContent _GroupDef; // 0x70
	private XdrBuilder.AttributeContent _AttributeDef; // 0x78
	private XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes; // 0x80
	private XdrBuilder.DeclBaseInfo _BaseDecl; // 0x88
	private XmlNameTable _NameTable; // 0x90
	private SchemaNames _SchemaNames; // 0x98
	private XmlNamespaceManager _CurNsMgr; // 0xA0
	private string _Text; // 0xA8
	private ValidationEventHandler validationEventHandler; // 0xB0
	private Hashtable _UndeclaredElements; // 0xB8
	private XmlResolver xmlResolver; // 0xC0

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x1C4D5B0 Offset: 0x1C4BBB0 VA: 0x181C4D5B0
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x1C455D0 Offset: 0x1C43BD0 VA: 0x181C455D0 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x1C45150 Offset: 0x1C43750 VA: 0x181C45150 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1C44640 Offset: 0x1C42C40 VA: 0x181C44640
	private bool LoadSchema(string uri) { }

	// RVA: 0x1C44470 Offset: 0x1C42A70 VA: 0x181C44470
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x1C45820 Offset: 0x1C43E20 VA: 0x181C45820 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x1C45550 Offset: 0x1C43B50 VA: 0x181C45550 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x1C45D80 Offset: 0x1C44380 VA: 0x181C45D80 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x1C439D0 Offset: 0x1C41FD0 VA: 0x181C439D0 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x1C45940 Offset: 0x1C43F40 VA: 0x181C45940
	private void Push() { }

	// RVA: 0x1C450A0 Offset: 0x1C436A0 VA: 0x181C450A0
	private void Pop() { }

	// RVA: 0x1C45880 Offset: 0x1C43E80 VA: 0x181C45880
	private void PushGroupInfo() { }

	// RVA: 0x1C44FF0 Offset: 0x1C435F0 VA: 0x181C44FF0
	private void PopGroupInfo() { }

	// RVA: 0x1C49DE0 Offset: 0x1C483E0 VA: 0x181C49DE0
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x1C48170 Offset: 0x1C46770 VA: 0x181C48170
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C46610 Offset: 0x1C44C10 VA: 0x181C46610
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x1C49260 Offset: 0x1C47860 VA: 0x181C49260
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x1C499E0 Offset: 0x1C47FE0 VA: 0x181C499E0
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x1C479E0 Offset: 0x1C45FE0 VA: 0x181C479E0
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47270 Offset: 0x1C45870 VA: 0x181C47270
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47860 Offset: 0x1C45E60 VA: 0x181C47860
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47BE0 Offset: 0x1C461E0 VA: 0x181C47BE0
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C475F0 Offset: 0x1C45BF0 VA: 0x181C475F0
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47760 Offset: 0x1C45D60 VA: 0x181C47760
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47310 Offset: 0x1C45910 VA: 0x181C47310
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47480 Offset: 0x1C45A80 VA: 0x181C47480
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C462A0 Offset: 0x1C448A0 VA: 0x181C462A0
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x1C48890 Offset: 0x1C46E90 VA: 0x181C48890
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x1C49770 Offset: 0x1C47D70 VA: 0x181C49770
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x1C46D60 Offset: 0x1C45360 VA: 0x181C46D60
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47030 Offset: 0x1C45630 VA: 0x181C47030
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C46700 Offset: 0x1C44D00 VA: 0x181C46700
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C46A10 Offset: 0x1C45010 VA: 0x181C46A10
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C46C60 Offset: 0x1C45260 VA: 0x181C46C60
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C46730 Offset: 0x1C44D30 VA: 0x181C46730
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C468A0 Offset: 0x1C44EA0 VA: 0x181C468A0
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C45DC0 Offset: 0x1C443C0 VA: 0x181C45DC0
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x1C48410 Offset: 0x1C46A10 VA: 0x181C48410
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x1C49B80 Offset: 0x1C48180 VA: 0x181C49B80
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x1C47DA0 Offset: 0x1C463A0 VA: 0x181C47DA0
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47D20 Offset: 0x1C46320 VA: 0x181C47D20
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47CA0 Offset: 0x1C462A0 VA: 0x181C47CA0
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C48F40 Offset: 0x1C47540 VA: 0x181C48F40
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x1C49890 Offset: 0x1C47E90 VA: 0x181C49890
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x1C47160 Offset: 0x1C45760 VA: 0x181C47160
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C470E0 Offset: 0x1C456E0 VA: 0x181C470E0
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C470B0 Offset: 0x1C456B0 VA: 0x181C470B0
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C45E40 Offset: 0x1C44440 VA: 0x181C45E40
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x1C48750 Offset: 0x1C46D50 VA: 0x181C48750
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x1C49C30 Offset: 0x1C48230 VA: 0x181C49C30
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x1C48080 Offset: 0x1C46680 VA: 0x181C48080
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47FF0 Offset: 0x1C465F0 VA: 0x181C47FF0
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C47F60 Offset: 0x1C46560 VA: 0x181C47F60
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1C49050 Offset: 0x1C47650 VA: 0x181C49050
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x1C49930 Offset: 0x1C47F30 VA: 0x181C49930
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x1C48780 Offset: 0x1C46D80 VA: 0x181C48780
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x1C49700 Offset: 0x1C47D00 VA: 0x181C49700
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x1C48320 Offset: 0x1C46920 VA: 0x181C48320
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x1C43DD0 Offset: 0x1C423D0 VA: 0x181C43DD0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x1C44370 Offset: 0x1C42970 VA: 0x181C44370
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x1C441B0 Offset: 0x1C427B0 VA: 0x181C441B0
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x1C43FB0 Offset: 0x1C425B0 VA: 0x181C43FB0
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x1C435B0 Offset: 0x1C41BB0 VA: 0x181C435B0
	private void AddOrder() { }

	// RVA: 0x1C44510 Offset: 0x1C42B10 VA: 0x181C44510
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x1C44EF0 Offset: 0x1C434F0 VA: 0x181C44EF0
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x1C44DD0 Offset: 0x1C433D0 VA: 0x181C44DD0
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x1C44170 Offset: 0x1C42770 VA: 0x181C44170
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	// RVA: 0x1C44B10 Offset: 0x1C43110 VA: 0x181C44B10
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x1C44C50 Offset: 0x1C43250 VA: 0x181C44C50
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x1C43950 Offset: 0x1C41F50 VA: 0x181C43950
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	// RVA: 0x1C44D90 Offset: 0x1C43390 VA: 0x181C44D90
	private static bool ParseInteger(string str, ref uint n) { }

	// RVA: 0x1C48210 Offset: 0x1C46810 VA: 0x181C48210
	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x1C45D30 Offset: 0x1C44330 VA: 0x181C45D30
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x1C43AA0 Offset: 0x1C420A0 VA: 0x181C43AA0
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x1C43CB0 Offset: 0x1C422B0 VA: 0x181C43CB0
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x1C43670 Offset: 0x1C41C70 VA: 0x181C43670
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x1C43820 Offset: 0x1C41E20 VA: 0x181C43820
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x1C441A0 Offset: 0x1C427A0 VA: 0x181C441A0
	private bool IsGlobal(int flags) { }

	// RVA: 0x1C459A0 Offset: 0x1C43FA0 VA: 0x181C459A0
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1C45D10 Offset: 0x1C44310 VA: 0x181C45D10
	private void SendValidationEvent(string code) { }

	// RVA: 0x1C45C00 Offset: 0x1C44200 VA: 0x181C45C00
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x1C45AE0 Offset: 0x1C440E0 VA: 0x181C45AE0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1C49E60 Offset: 0x1C48460 VA: 0x181C49E60
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class XdrValidator : BaseValidator // TypeDefIndex: 7052
{
	// Fields
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool isProcessContents; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1C510D0 Offset: 0x1C4F6D0 VA: 0x181C510D0
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1C51010 Offset: 0x1C4F610 VA: 0x181C51010
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1C4E780 Offset: 0x1C4CD80 VA: 0x181C4E780
	private void Init() { }

	// RVA: 0x1C50F30 Offset: 0x1C4F530 VA: 0x181C50F30 Slot: 5
	public override void Validate() { }

	// RVA: 0x1C50050 Offset: 0x1C4E650 VA: 0x181C50050
	private void ValidateElement() { }

	// RVA: 0x1C4FE90 Offset: 0x1C4E490 VA: 0x181C4FE90
	private void ValidateChildElement() { }

	// RVA: 0x1C51180 Offset: 0x1C4F780 VA: 0x181C51180
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1C4F340 Offset: 0x1C4D940 VA: 0x181C4F340
	private void ProcessInlineSchema() { }

	// RVA: 0x1C4F260 Offset: 0x1C4D860 VA: 0x181C4F260
	private void ProcessElement() { }

	// RVA: 0x1C50480 Offset: 0x1C4EA80 VA: 0x181C50480
	private void ValidateEndElement() { }

	// RVA: 0x1C4FA80 Offset: 0x1C4E080 VA: 0x181C4FA80
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x1C50AB0 Offset: 0x1C4F0B0 VA: 0x181C50AB0
	private void ValidateStartElement() { }

	// RVA: 0x1C50760 Offset: 0x1C4ED60 VA: 0x181C50760
	private void ValidateEndStartElement() { }

	// RVA: 0x1C4E9A0 Offset: 0x1C4CFA0 VA: 0x181C4E9A0
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x1C4EF70 Offset: 0x1C4D570 VA: 0x181C4EF70
	private void LoadSchema(string uri) { }

	// RVA: 0x1C51160 Offset: 0x1C4F760 VA: 0x181C51160
	private bool get_HasSchema() { }

	// RVA: 0x1C51190 Offset: 0x1C4F790 VA: 0x181C51190 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1C4F580 Offset: 0x1C4DB80 VA: 0x181C4F580
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1C4E4E0 Offset: 0x1C4CAE0 VA: 0x181C4E4E0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1C4DFA0 Offset: 0x1C4C5A0 VA: 0x181C4DFA0
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1C4D9D0 Offset: 0x1C4BFD0 VA: 0x181C4D9D0
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x1C4D920 Offset: 0x1C4BF20 VA: 0x181C4D920
	internal void AddID(string name, object node) { }

	// RVA: 0x1C4E750 Offset: 0x1C4CD50 VA: 0x181C4E750 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1C4F830 Offset: 0x1C4DE30 VA: 0x181C4F830
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1C4F190 Offset: 0x1C4D790 VA: 0x181C4F190
	private void Pop() { }

	// RVA: 0x1C4DE50 Offset: 0x1C4C450 VA: 0x181C4DE50
	private void CheckForwardRefs() { }

	// RVA: 0x1C4F9E0 Offset: 0x1C4DFE0 VA: 0x181C4F9E0
	private XmlQualifiedName QualifiedName(string name, string ns) { }
}

// Namespace: System.Xml.Schema
public sealed class XmlAtomicValue : XPathItem, ICloneable // TypeDefIndex: 7055
{
	// Fields
	private XmlSchemaType xmlType; // 0x10
	private object objVal; // 0x18
	private TypeCode clrType; // 0x20
	private XmlAtomicValue.Union unionVal; // 0x28
	private XmlAtomicValue.NamespacePrefixForQName nsPrefix; // 0x30

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override Type ValueType { get; }
	public override object TypedValue { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0x1C514A0 Offset: 0x1C4FAA0 VA: 0x181C514A0
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x1C51CD0 Offset: 0x1C502D0 VA: 0x181C51CD0
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x1C51D70 Offset: 0x1C50370 VA: 0x181C51D70
	internal void .ctor(XmlSchemaType xmlType, double value) { }

	// RVA: 0x1C51910 Offset: 0x1C4FF10 VA: 0x181C51910
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x1C51870 Offset: 0x1C4FE70 VA: 0x181C51870
	internal void .ctor(XmlSchemaType xmlType, long value) { }

	// RVA: 0x1C51BE0 Offset: 0x1C501E0 VA: 0x181C51BE0
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x1C51630 Offset: 0x1C4FC30 VA: 0x181C51630
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C51540 Offset: 0x1C4FB40 VA: 0x181C51540
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x1C519B0 Offset: 0x1C4FFB0 VA: 0x181C519B0
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x1C52570 Offset: 0x1C50B70 VA: 0x181C52570 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1C51E10 Offset: 0x1C50410 VA: 0x181C51E10 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x1C52020 Offset: 0x1C50620 VA: 0x181C52020 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x1C52130 Offset: 0x1C50730 VA: 0x181C52130 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x1C52240 Offset: 0x1C50840 VA: 0x181C52240 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x1C52350 Offset: 0x1C50950 VA: 0x181C52350 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x1C52460 Offset: 0x1C50A60 VA: 0x181C52460 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x1C51280 Offset: 0x1C4F880 VA: 0x181C51280 Slot: 14
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C525B0 Offset: 0x1C50BB0 VA: 0x181C525B0 Slot: 5
	public override string get_Value() { }

	// RVA: 0x5482B0 Offset: 0x5468B0 VA: 0x1805482B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C511D0 Offset: 0x1C4F7D0 VA: 0x181C511D0
	private string GetPrefixFromQName(string value) { }
}

// Namespace: System.Xml.Schema
[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
public class XmlSchema : XmlSchemaObject // TypeDefIndex: 7056
{
	// Fields
	private XmlSchemaForm attributeFormDefault; // 0x38
	private XmlSchemaForm elementFormDefault; // 0x3C
	private XmlSchemaDerivationMethod blockDefault; // 0x40
	private XmlSchemaDerivationMethod finalDefault; // 0x44
	private string targetNs; // 0x48
	private string version; // 0x50
	private XmlSchemaObjectCollection includes; // 0x58
	private XmlSchemaObjectCollection items; // 0x60
	private string id; // 0x68
	private XmlAttribute[] moreAttributes; // 0x70
	private bool isCompiled; // 0x78
	private bool isCompiledBySet; // 0x79
	private bool isPreprocessed; // 0x7A
	private bool isRedefined; // 0x7B
	private int errorCount; // 0x7C
	private XmlSchemaObjectTable attributes; // 0x80
	private XmlSchemaObjectTable attributeGroups; // 0x88
	private XmlSchemaObjectTable elements; // 0x90
	private XmlSchemaObjectTable types; // 0x98
	private XmlSchemaObjectTable groups; // 0xA0
	private XmlSchemaObjectTable notations; // 0xA8
	private XmlSchemaObjectTable identityConstraints; // 0xB0
	private static int globalIdCounter; // 0x0
	private ArrayList importedSchemas; // 0xB8
	private ArrayList importedNamespaces; // 0xC0
	private int schemaId; // 0xC8
	private Uri baseUri; // 0xD0
	private bool isChameleon; // 0xD8
	private Hashtable ids; // 0xE0
	private XmlDocument document; // 0xE8

	// Properties
	[Xml("attributeFormDefault")]
	[DefaultValue(0)]
	public XmlSchemaForm AttributeFormDefault { get; set; }
	[DefaultValue(256)]
	[Xml("blockDefault")]
	public XmlSchemaDerivationMethod BlockDefault { get; set; }
	[Xml("finalDefault")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod FinalDefault { get; set; }
	[Xml("elementFormDefault")]
	[DefaultValue(0)]
	public XmlSchemaForm ElementFormDefault { get; set; }
	[Xml("targetNamespace", DataType = "anyURI")]
	public string TargetNamespace { get; set; }
	[Xml("version", DataType = "token")]
	public string Version { get; set; }
	[XmlElement("import", typeof(XmlSchemaImport))]
	[XmlElement("include", typeof(XmlSchemaInclude))]
	[XmlElement("redefine", typeof(XmlSchemaRedefine))]
	public XmlSchemaObjectCollection Includes { get; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("notation", typeof(XmlSchemaNotation))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	internal bool IsCompiledBySet { get; set; }
	[XmlIgnore]
	internal bool IsPreprocessed { get; set; }
	[XmlIgnore]
	internal bool IsRedefined { get; set; }
	[XmlIgnore]
	public XmlSchemaObjectTable Attributes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Elements { get; }
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlIgnore]
	public XmlSchemaObjectTable Groups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Notations { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable IdentityConstraints { get; }
	[XmlIgnore]
	internal Uri BaseUri { get; set; }
	[XmlIgnore]
	internal int SchemaId { get; }
	[XmlIgnore]
	internal bool IsChameleon { get; set; }
	[XmlIgnore]
	internal Hashtable Ids { get; }
	[XmlIgnore]
	internal XmlDocument Document { get; }
	[XmlIgnore]
	internal int ErrorCount { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }
	internal ArrayList ImportedSchemas { get; }
	internal ArrayList ImportedNamespaces { get; }

	// Methods

	// RVA: 0x1C5B4B0 Offset: 0x1C59AB0 VA: 0x181C5B4B0
	public void .ctor() { }

	// RVA: 0x1C5B320 Offset: 0x1C59920 VA: 0x181C5B320
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x1C5AB00 Offset: 0x1C59100 VA: 0x181C5AB00
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x1C5AA40 Offset: 0x1C59040 VA: 0x181C5AA40
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x15EEFB0 Offset: 0x15ED5B0 VA: 0x1815EEFB0
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x1978180 Offset: 0x1976780 VA: 0x181978180
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public string get_TargetNamespace() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_TargetNamespace(string value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_Version() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Version(string value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1C586F0 Offset: 0x1C56CF0 VA: 0x181C586F0
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x1919C10 Offset: 0x1918210 VA: 0x181919C10
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x1AD7EC0 Offset: 0x1AD64C0 VA: 0x181AD7EC0
	internal bool get_IsPreprocessed() { }

	// RVA: 0x1AD8100 Offset: 0x1AD6700 VA: 0x181AD8100
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x1C58730 Offset: 0x1C56D30 VA: 0x181C58730
	internal bool get_IsRedefined() { }

	// RVA: 0x1C5BAE0 Offset: 0x1C5A0E0 VA: 0x181C5BAE0
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x1C5B740 Offset: 0x1C59D40 VA: 0x181C5B740
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x1C5B6C0 Offset: 0x1C59CC0 VA: 0x181C5B6C0
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x1C5BA40 Offset: 0x1C5A040 VA: 0x181C5BA40
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x1C5B840 Offset: 0x1C59E40 VA: 0x181C5B840
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public string get_Id() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void set_Id(string value) { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x16237B0 Offset: 0x1621DB0 VA: 0x1816237B0
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	internal Uri get_BaseUri() { }

	// RVA: 0x510990 Offset: 0x50EF90 VA: 0x180510990
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x1C5B9D0 Offset: 0x1C59FD0 VA: 0x181C5B9D0
	internal int get_SchemaId() { }

	// RVA: 0x1C5B9C0 Offset: 0x1C59FC0 VA: 0x181C5B9C0
	internal bool get_IsChameleon() { }

	// RVA: 0x1C5BAD0 Offset: 0x1C5A0D0 VA: 0x181C5BAD0
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	internal Hashtable get_Ids() { }

	// RVA: 0x1C5B7C0 Offset: 0x1C59DC0 VA: 0x181C5B7C0
	internal XmlDocument get_Document() { }

	// RVA: 0x15D1060 Offset: 0x15CF660 VA: 0x1815D1060
	internal int get_ErrorCount() { }

	// RVA: 0x1C5BAC0 Offset: 0x1C5A0C0 VA: 0x181C5BAC0
	internal void set_ErrorCount(int value) { }

	// RVA: 0x1C5A8F0 Offset: 0x1C58EF0 VA: 0x181C5A8F0
	internal XmlSchema Clone() { }

	// RVA: 0x1C5ACF0 Offset: 0x1C592F0 VA: 0x181C5ACF0
	internal XmlSchema DeepClone() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1918FF0 Offset: 0x19175F0 VA: 0x181918FF0
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1C5A880 Offset: 0x1C58E80 VA: 0x181C5A880 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1C5B940 Offset: 0x1C59F40 VA: 0x181C5B940
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x1C5B8C0 Offset: 0x1C59EC0 VA: 0x181C5B8C0
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x1C5B150 Offset: 0x1C59750 VA: 0x181C5B150
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x1C5B470 Offset: 0x1C59A70 VA: 0x181C5B470
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAll : XmlSchemaGroupBase // TypeDefIndex: 7057
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1C52790 Offset: 0x1C50D90 VA: 0x181C52790 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1C526F0 Offset: 0x1C50CF0 VA: 0x181C526F0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotated : XmlSchemaObject // TypeDefIndex: 7058
{
	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	public XmlSchemaAnnotation Annotation { get; set; }
	[XmlAny]
	public XmlAttribute[] UnhandledAttributes { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_Id() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_Id(string value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotation : XmlSchemaObject // TypeDefIndex: 7059
{
	// Fields
	private string id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
	[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_Id() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_Id(string value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1C527D0 Offset: 0x1C50DD0 VA: 0x181C527D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAny : XmlSchemaParticle // TypeDefIndex: 7060
{
	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Properties
	[Xml("namespace")]
	public string Namespace { get; set; }
	[Xml("processContents")]
	[DefaultValue(0)]
	public XmlSchemaContentProcessing ProcessContents { set; }
	[XmlIgnore]
	internal NamespaceList NamespaceList { get; }
	[XmlIgnore]
	internal string ResolvedNamespace { get; }
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }
	internal override string NameString { get; }

	// Methods

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public string get_Namespace() { }

	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	public void set_Namespace(string value) { }

	// RVA: 0x498D70 Offset: 0x497370 VA: 0x180498D70
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x1C53210 Offset: 0x1C51810 VA: 0x181C53210
	internal string get_ResolvedNamespace() { }

	// RVA: 0x1C531F0 Offset: 0x1C517F0 VA: 0x181C531F0
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x1C52DD0 Offset: 0x1C513D0 VA: 0x181C52DD0 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x1C52CD0 Offset: 0x1C512D0 VA: 0x181C52CD0
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x1C52C10 Offset: 0x1C51210 VA: 0x181C52C10
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x1C52BD0 Offset: 0x1C511D0 VA: 0x181C52BD0
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1C52D80 Offset: 0x1C51380 VA: 0x181C52D80
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAnyAttribute : XmlSchemaAnnotated // TypeDefIndex: 7061
{
	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Properties
	[Xml("namespace")]
	public string Namespace { set; }
	[DefaultValue(0)]
	[Xml("processContents")]
	public XmlSchemaContentProcessing ProcessContents { get; set; }
	[XmlIgnore]
	internal NamespaceList NamespaceList { get; }
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }

	// Methods

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Namespace(string value) { }

	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x399820 Offset: 0x397E20 VA: 0x180399820
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x1C52BC0 Offset: 0x1C511C0 VA: 0x181C52BC0
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x1C52930 Offset: 0x1C50F30 VA: 0x181C52930
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x1C52880 Offset: 0x1C50E80 VA: 0x181C52880
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x1C52840 Offset: 0x1C50E40 VA: 0x181C52840
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1C52AB0 Offset: 0x1C510B0 VA: 0x181C52AB0
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x1C529D0 Offset: 0x1C50FD0 VA: 0x181C529D0
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x1C52AE0 Offset: 0x1C510E0 VA: 0x181C52AE0
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAppInfo : XmlSchemaObject // TypeDefIndex: 7062
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Properties
	[Xml("source", DataType = "anyURI")]
	public string Source { set; }
	[XmlText]
	[XmlAnyElement]
	public XmlNode[] Markup { get; set; }

	// Methods

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_Source(string value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public XmlNode[] get_Markup() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAttribute : XmlSchemaAnnotated // TypeDefIndex: 7063
{
	// Fields
	private string defaultValue; // 0x50
	private string fixedValue; // 0x58
	private string name; // 0x60
	private XmlSchemaForm form; // 0x68
	private XmlSchemaUse use; // 0x6C
	private XmlQualifiedName refName; // 0x70
	private XmlQualifiedName typeName; // 0x78
	private XmlQualifiedName qualifiedName; // 0x80
	private XmlSchemaSimpleType type; // 0x88
	private XmlSchemaSimpleType attributeType; // 0x90
	private SchemaAttDef attDef; // 0x98

	// Properties
	[Xml("default")]
	[DefaultValue(null)]
	public string DefaultValue { get; set; }
	[DefaultValue(null)]
	[Xml("fixed")]
	public string FixedValue { get; set; }
	[DefaultValue(0)]
	[Xml("form")]
	public XmlSchemaForm Form { get; set; }
	[Xml("name")]
	public string Name { get; set; }
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[Xml("type")]
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElement("simpleType")]
	public XmlSchemaSimpleType SchemaType { get; set; }
	[DefaultValue(0)]
	[Xml("use")]
	public XmlSchemaUse Use { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaSimpleType AttributeSchemaType { get; }
	[XmlIgnore]
	internal XmlSchemaDatatype Datatype { get; }
	internal SchemaAttDef AttDef { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_DefaultValue() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_DefaultValue(string value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public string get_FixedValue() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_FixedValue(string value) { }

	// RVA: 0xC9D690 Offset: 0xC9BC90 VA: 0x180C9D690
	public XmlSchemaForm get_Form() { }

	// RVA: 0xC9D9F0 Offset: 0xC9BFF0 VA: 0x180C9D9F0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public string get_Name() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_Name(string value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1C537A0 Offset: 0x1C51DA0 VA: 0x181C537A0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x1C53850 Offset: 0x1C51E50 VA: 0x181C53850
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0xC9D570 Offset: 0xC9BB70 VA: 0x180C9D570
	public XmlSchemaUse get_Use() { }

	// RVA: 0xC9D7A0 Offset: 0xC9BDA0 VA: 0x180C9D7A0
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x1C53780 Offset: 0x1C51D80 VA: 0x181C53780
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1C535D0 Offset: 0x1C51BD0 VA: 0x181C535D0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1C536D0 Offset: 0x1C51CD0 VA: 0x181C536D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroup : XmlSchemaAnnotated // TypeDefIndex: 7064
{
	// Fields
	private string name; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaAttributeGroup redefined; // 0x70
	private XmlSchemaObjectTable attributeUses; // 0x78
	private XmlSchemaAnyAttribute attributeWildcard; // 0x80
	private int selfReferenceCount; // 0x88

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnore]
	internal XmlSchemaAnyAttribute AttributeWildcard { get; set; }
	[XmlIgnore]
	public XmlSchemaAttributeGroup RedefinedAttributeGroup { get; }
	[XmlIgnore]
	internal XmlSchemaAttributeGroup Redefined { get; set; }
	[XmlIgnore]
	internal int SelfReferenceCount { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_Name() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Name(string value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1C53560 Offset: 0x1C51B60 VA: 0x181C53560
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90
	internal int get_SelfReferenceCount() { }

	// RVA: 0x3AAD20 Offset: 0x3A9320 VA: 0x1803AAD20
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1C53380 Offset: 0x1C51980 VA: 0x181C53380 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1C534B0 Offset: 0x1C51AB0 VA: 0x181C534B0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated // TypeDefIndex: 7065
{
	// Fields
	private XmlQualifiedName refName; // 0x50

	// Properties
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1C532D0 Offset: 0x1C518D0 VA: 0x181C532D0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1C53260 Offset: 0x1C51860 VA: 0x181C53260
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaChoice : XmlSchemaGroupBase // TypeDefIndex: 7066
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1C539A0 Offset: 0x1C51FA0 VA: 0x181C539A0 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1C53900 Offset: 0x1C51F00 VA: 0x181C53900
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
[Obsolete("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
public sealed class XmlSchemaCollection : ICollection, IEnumerable // TypeDefIndex: 7067
{
	// Fields
	private Hashtable collection; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ReaderWriterLock wLock; // 0x28
	private int timeout; // 0x30
	private bool isThreadSafe; // 0x34
	private ValidationEventHandler validationEventHandler; // 0x38
	private XmlResolver xmlResolver; // 0x40

	// Properties
	public int Count { get; }
	public XmlNameTable NameTable { get; }
	internal XmlResolver XmlResolver { set; }
	public XmlSchema Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	internal ValidationEventHandler EventHandler { get; set; }

	// Methods

	// RVA: 0x1C54510 Offset: 0x1C52B10 VA: 0x181C54510
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x1A1EC90 Offset: 0x1A1D290 VA: 0x181A1EC90
	public int get_Count() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public XmlNameTable get_NameTable() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1C54650 Offset: 0x1C52C50 VA: 0x181C54650
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x1C54480 Offset: 0x1C52A80 VA: 0x181C54480 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1C54070 Offset: 0x1C52670 VA: 0x181C54070
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x1C54270 Offset: 0x1C52870 VA: 0x181C54270 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1A1EC90 Offset: 0x1A1D290 VA: 0x181A1EC90 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1C54100 Offset: 0x1C52700 VA: 0x181C54100
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x1C541B0 Offset: 0x1C527B0 VA: 0x181C541B0
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1C53D60 Offset: 0x1C52360 VA: 0x181C53D60
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x1C53EF0 Offset: 0x1C524F0 VA: 0x181C53EF0
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x1C53C20 Offset: 0x1C52220 VA: 0x181C53C20
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	internal void set_EventHandler(ValidationEventHandler value) { }
}

// Namespace: System.Xml.Schema
internal sealed class XmlSchemaCollectionNode // TypeDefIndex: 7068
{
	// Fields
	private string namespaceUri; // 0x10
	private SchemaInfo schemaInfo; // 0x18
	private XmlSchema schema; // 0x20

	// Properties
	internal string NamespaceURI { set; }
	internal SchemaInfo SchemaInfo { get; set; }
	internal XmlSchema Schema { get; set; }

	// Methods

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal XmlSchema get_Schema() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void set_Schema(XmlSchema value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollectionEnumerator : IEnumerator // TypeDefIndex: 7069
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public XmlSchema Current { get; }
	internal XmlSchemaCollectionNode CurrentNode { get; }

	// Methods

	// RVA: 0x1C53AB0 Offset: 0x1C520B0 VA: 0x181C53AB0
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x1C53A50 Offset: 0x1C52050 VA: 0x181C53A50 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1C53A00 Offset: 0x1C52000 VA: 0x181C53A00 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1C539B0 Offset: 0x1C51FB0 VA: 0x181C539B0
	public bool MoveNext() { }

	// RVA: 0x1C53AA0 Offset: 0x1C520A0 VA: 0x181C53AA0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1C53B90 Offset: 0x1C52190 VA: 0x181C53B90
	public XmlSchema get_Current() { }

	// RVA: 0x1C53B10 Offset: 0x1C52110 VA: 0x181C53B10
	internal XmlSchemaCollectionNode get_CurrentNode() { }
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCompilationSettings // TypeDefIndex: 7070
{
	// Fields
	private bool enableUpaCheck; // 0x10

	// Properties
	public bool EnableUpaCheck { get; }

	// Methods

	// RVA: 0x1C54700 Offset: 0x1C52D00 VA: 0x181C54700
	public void .ctor() { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_EnableUpaCheck() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContent : XmlSchemaContentModel // TypeDefIndex: 7071
{
	// Fields
	private XmlSchemaContent content; // 0x50
	private bool isMixed; // 0x58
	private bool hasMixedAttribute; // 0x59

	// Properties
	[Xml("mixed")]
	public bool IsMixed { get; set; }
	[XmlElement("restriction", typeof(XmlSchemaComplexContentRestriction))]
	[XmlElement("extension", typeof(XmlSchemaComplexContentExtension))]
	public override XmlSchemaContent Content { get; set; }
	[XmlIgnore]
	internal bool HasMixedAttribute { get; }

	// Methods

	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	public bool get_IsMixed() { }

	// RVA: 0x1C549E0 Offset: 0x1C52FE0 VA: 0x181C549E0
	public void set_IsMixed(bool value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x140E320 Offset: 0x140C920 VA: 0x18140E320
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentExtension : XmlSchemaContent // TypeDefIndex: 7072
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1C547D0 Offset: 0x1C52DD0 VA: 0x181C547D0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1C54720 Offset: 0x1C52D20 VA: 0x181C54720
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentRestriction : XmlSchemaContent // TypeDefIndex: 7073
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1C54930 Offset: 0x1C52F30 VA: 0x181C54930
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1C54880 Offset: 0x1C52E80 VA: 0x181C54880
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexType : XmlSchemaType // TypeDefIndex: 7074
{
	// Fields
	private XmlSchemaDerivationMethod block; // 0x98
	private XmlSchemaContentModel contentModel; // 0xA0
	private XmlSchemaParticle particle; // 0xA8
	private XmlSchemaObjectCollection attributes; // 0xB0
	private XmlSchemaAnyAttribute anyAttribute; // 0xB8
	private XmlSchemaParticle contentTypeParticle; // 0xC0
	private XmlSchemaDerivationMethod blockResolved; // 0xC8
	private XmlSchemaObjectTable localElements; // 0xD0
	private XmlSchemaObjectTable attributeUses; // 0xD8
	private XmlSchemaAnyAttribute attributeWildcard; // 0xE0
	private static XmlSchemaComplexType anyTypeLax; // 0x0
	private static XmlSchemaComplexType anyTypeSkip; // 0x8
	private static XmlSchemaComplexType untypedAnyType; // 0x10
	private byte pvFlags; // 0xE8

	// Properties
	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType { get; }
	[XmlIgnore]
	internal static XmlSchemaComplexType UntypedAnyType { get; }
	internal static ContentValidator AnyTypeContentValidator { get; }
	[Xml("abstract")]
	[DefaultValue(False)]
	public bool IsAbstract { get; set; }
	[Xml("block")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod Block { get; set; }
	[Xml("mixed")]
	[DefaultValue(False)]
	public override bool IsMixed { get; set; }
	[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
	[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
	public XmlSchemaContentModel ContentModel { get; set; }
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnore]
	public XmlSchemaContentType ContentType { get; }
	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnore]
	public XmlSchemaAnyAttribute AttributeWildcard { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable LocalElements { get; }
	internal bool HasWildCard { set; }

	// Methods

	// RVA: 0x1C56970 Offset: 0x1C54F70 VA: 0x181C56970
	private static void .cctor() { }

	// RVA: 0x1C56000 Offset: 0x1C54600 VA: 0x181C56000
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x1C56D00 Offset: 0x1C55300 VA: 0x181C56D00
	public void .ctor() { }

	// RVA: 0x1C56DF0 Offset: 0x1C553F0 VA: 0x181C56DF0
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x1C56FE0 Offset: 0x1C555E0 VA: 0x181C56FE0
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x1C56D80 Offset: 0x1C55380 VA: 0x181C56D80
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x1C56F40 Offset: 0x1C55540 VA: 0x181C56F40
	public bool get_IsAbstract() { }

	// RVA: 0x1C57060 Offset: 0x1C55660 VA: 0x181C57060
	public void set_IsAbstract(bool value) { }

	// RVA: 0x12ECB50 Offset: 0x12EB150 VA: 0x1812ECB50
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x5266C0 Offset: 0x524CC0 VA: 0x1805266C0
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1C56F50 Offset: 0x1C55550 VA: 0x181C56F50 Slot: 14
	public override bool get_IsMixed() { }

	// RVA: 0x1C57090 Offset: 0x1C55690 VA: 0x181C57090 Slot: 15
	public override void set_IsMixed(bool value) { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x163E0C0 Offset: 0x163C6C0 VA: 0x18163E0C0
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1C56EC0 Offset: 0x1C554C0 VA: 0x181C56EC0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x131C550 Offset: 0x131AB50 VA: 0x18131C550
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x8221D0 Offset: 0x8207D0 VA: 0x1808221D0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x145DAB0 Offset: 0x145C0B0 VA: 0x18145DAB0
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1C56E40 Offset: 0x1C55440 VA: 0x181C56E40
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x1C56F60 Offset: 0x1C55560 VA: 0x181C56F60
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x1C56960 Offset: 0x1C54F60 VA: 0x181C56960
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x12F1A10 Offset: 0x12F0010 VA: 0x1812F1A10
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1C57030 Offset: 0x1C55630 VA: 0x181C57030
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x8DA860 Offset: 0x8D8E60 VA: 0x1808DA860
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1C55D10 Offset: 0x1C54310 VA: 0x181C55D10
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x1C55D00 Offset: 0x1C54300 VA: 0x181C55D00 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1C55330 Offset: 0x1C53930 VA: 0x181C55330
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1C549F0 Offset: 0x1C52FF0 VA: 0x181C549F0
	private void ClearCompiledState() { }

	// RVA: 0x1C54AB0 Offset: 0x1C530B0 VA: 0x181C54AB0
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1C54D40 Offset: 0x1C53340 VA: 0x181C54D40
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x1C54E90 Offset: 0x1C53490 VA: 0x181C54E90
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x1C564D0 Offset: 0x1C54AD0 VA: 0x181C564D0
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x1C56670 Offset: 0x1C54C70 VA: 0x181C56670
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x1C56500 Offset: 0x1C54B00 VA: 0x181C56500
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContent : XmlSchemaAnnotated // TypeDefIndex: 7075
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContentModel : XmlSchemaAnnotated // TypeDefIndex: 7076
{
	// Properties
	[XmlIgnore]
	public abstract XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	public abstract XmlSchemaContent get_Content();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_Content(XmlSchemaContent value);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaContentProcessing // TypeDefIndex: 7077
{
	// Fields
	public int value__; // 0x0
	[XmlIgnore]
	public const XmlSchemaContentProcessing None = 0;
	[XmlEnum("skip")]
	public const XmlSchemaContentProcessing Skip = 1;
	[XmlEnum("lax")]
	public const XmlSchemaContentProcessing Lax = 2;
	[XmlEnum("strict")]
	public const XmlSchemaContentProcessing Strict = 3;
}

// Namespace: System.Xml.Schema
public enum XmlSchemaContentType // TypeDefIndex: 7078
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaContentType TextOnly = 0;
	public const XmlSchemaContentType Empty = 1;
	public const XmlSchemaContentType ElementOnly = 2;
	public const XmlSchemaContentType Mixed = 3;
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaDatatype // TypeDefIndex: 7079
{
	// Properties
	public abstract Type ValueType { get; }
	public abstract XmlTokenizedType TokenizedType { get; }
	public virtual XmlSchemaDatatypeVariety Variety { get; }
	public virtual XmlTypeCode TypeCode { get; }
	internal abstract bool HasLexicalFacets { get; }
	internal abstract bool HasValueFacets { get; }
	internal abstract XmlValueConverter ValueConverter { get; }
	internal abstract RestrictionFacets Restriction { get; }
	internal abstract FacetsChecker FacetsChecker { get; }
	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal string TypeCodeString { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlTokenizedType get_TokenizedType();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 8
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 9
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool get_HasLexicalFacets();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool get_HasValueFacets();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract XmlValueConverter get_ValueConverter();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract RestrictionFacets get_Restriction();

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int Compare(object value1, object value2);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract FacetsChecker get_FacetsChecker();

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 22
	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

	// RVA: -1 Offset: -1 Slot: 23
	internal abstract bool IsEqual(object o1, object o2);

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract bool IsComparable(XmlSchemaDatatype dtype);

	// RVA: 0x1C57F40 Offset: 0x1C56540 VA: 0x181C57F40
	internal string get_TypeCodeString() { }

	// RVA: 0x1C57800 Offset: 0x1C55E00 VA: 0x181C57800
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x1C570C0 Offset: 0x1C556C0 VA: 0x181C570C0
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x1C577B0 Offset: 0x1C55DB0 VA: 0x181C577B0
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x1C57760 Offset: 0x1C55D60 VA: 0x181C57760
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x1C57710 Offset: 0x1C55D10 VA: 0x181C57710
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x1C576B0 Offset: 0x1C55CB0 VA: 0x181C576B0
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x1C57D90 Offset: 0x1C56390 VA: 0x181C57D90
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
[Flags]
public enum XmlSchemaDerivationMethod // TypeDefIndex: 7080
{
	// Fields
	public int value__; // 0x0
	[XmlEnum("")]
	public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnum("substitution")]
	public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnum("extension")]
	public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnum("restriction")]
	public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnum("list")]
	public const XmlSchemaDerivationMethod List = 8;
	[XmlEnum("union")]
	public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnum("#all")]
	public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnore]
	public const XmlSchemaDerivationMethod None = 256;
}

// Namespace: System.Xml.Schema
public class XmlSchemaDocumentation : XmlSchemaObject // TypeDefIndex: 7081
{
	// Fields
	private string source; // 0x38
	private string language; // 0x40
	private XmlNode[] markup; // 0x48
	private static XmlSchemaSimpleType languageType; // 0x0

	// Properties
	[Xml("source", DataType = "anyURI")]
	public string Source { set; }
	[Xml("xml:lang")]
	public string Language { set; }
	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup { set; }

	// Methods

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_Source(string value) { }

	// RVA: 0x1C58160 Offset: 0x1C56760 VA: 0x181C58160
	public void set_Language(string value) { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1C58090 Offset: 0x1C56690 VA: 0x181C58090
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaElement : XmlSchemaParticle // TypeDefIndex: 7082
{
	// Fields
	private bool isAbstract; // 0x78
	private bool hasAbstractAttribute; // 0x79
	private bool isNillable; // 0x7A
	private bool hasNillableAttribute; // 0x7B
	private bool isLocalTypeDerivationChecked; // 0x7C
	private XmlSchemaDerivationMethod block; // 0x80
	private XmlSchemaDerivationMethod final; // 0x84
	private XmlSchemaForm form; // 0x88
	private string defaultValue; // 0x90
	private string fixedValue; // 0x98
	private string name; // 0xA0
	private XmlQualifiedName refName; // 0xA8
	private XmlQualifiedName substitutionGroup; // 0xB0
	private XmlQualifiedName typeName; // 0xB8
	private XmlSchemaType type; // 0xC0
	private XmlQualifiedName qualifiedName; // 0xC8
	private XmlSchemaType elementType; // 0xD0
	private XmlSchemaDerivationMethod blockResolved; // 0xD8
	private XmlSchemaDerivationMethod finalResolved; // 0xDC
	private XmlSchemaObjectCollection constraints; // 0xE0
	private SchemaElementDecl elementDecl; // 0xE8

	// Properties
	[DefaultValue(False)]
	[Xml("abstract")]
	public bool IsAbstract { get; set; }
	[DefaultValue(256)]
	[Xml("block")]
	public XmlSchemaDerivationMethod Block { get; set; }
	[Xml("default")]
	[DefaultValue(null)]
	public string DefaultValue { get; set; }
	[DefaultValue(256)]
	[Xml("final")]
	public XmlSchemaDerivationMethod Final { get; set; }
	[DefaultValue(null)]
	[Xml("fixed")]
	public string FixedValue { get; set; }
	[DefaultValue(0)]
	[Xml("form")]
	public XmlSchemaForm Form { get; set; }
	[Xml("name")]
	[DefaultValue("")]
	public string Name { get; set; }
	[Xml("nillable")]
	[DefaultValue(False)]
	public bool IsNillable { get; set; }
	[XmlIgnore]
	internal bool HasNillableAttribute { get; }
	[XmlIgnore]
	internal bool HasAbstractAttribute { get; }
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[Xml("substitutionGroup")]
	public XmlQualifiedName SubstitutionGroup { get; set; }
	[Xml("type")]
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	public XmlSchemaType SchemaType { get; set; }
	[XmlElement("key", typeof(XmlSchemaKey))]
	[XmlElement("keyref", typeof(XmlSchemaKeyref))]
	[XmlElement("unique", typeof(XmlSchemaUnique))]
	public XmlSchemaObjectCollection Constraints { get; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaType ElementSchemaType { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved { get; }
	internal bool HasConstraints { get; }
	internal bool IsLocalTypeDerivationChecked { get; set; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }
	[XmlIgnore]
	internal override string NameString { get; }

	// Methods

	// RVA: 0x1C58740 Offset: 0x1C56D40 VA: 0x181C58740
	public bool get_IsAbstract() { }

	// RVA: 0x1C58780 Offset: 0x1C56D80 VA: 0x181C58780
	public void set_IsAbstract(bool value) { }

	// RVA: 0x498D50 Offset: 0x497350 VA: 0x180498D50
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x498D70 Offset: 0x497370 VA: 0x180498D70
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public string get_DefaultValue() { }

	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	public void set_DefaultValue(string value) { }

	// RVA: 0x486A80 Offset: 0x485080 VA: 0x180486A80
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x486AE0 Offset: 0x4850E0 VA: 0x180486AE0
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public string get_FixedValue() { }

	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	public void set_FixedValue(string value) { }

	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90
	public XmlSchemaForm get_Form() { }

	// RVA: 0x3AAD20 Offset: 0x3A9320 VA: 0x1803AAD20
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public string get_Name() { }

	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120
	public void set_Name(string value) { }

	// RVA: 0x1AD7EC0 Offset: 0x1AD64C0 VA: 0x181AD7EC0
	public bool get_IsNillable() { }

	// RVA: 0x1C587A0 Offset: 0x1C56DA0 VA: 0x181C587A0
	public void set_IsNillable(bool value) { }

	// RVA: 0x1C58730 Offset: 0x1C56D30 VA: 0x181C58730
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x1C586F0 Offset: 0x1C56CF0 VA: 0x181C586F0
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1C587B0 Offset: 0x1C56DB0 VA: 0x181C587B0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x16237B0 Offset: 0x1621DB0 VA: 0x1816237B0
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x1C58910 Offset: 0x1C56F10 VA: 0x181C58910
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x131C550 Offset: 0x131AB50 VA: 0x18131C550
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x1C58860 Offset: 0x1C56E60 VA: 0x181C58860
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x1C58660 Offset: 0x1C56C60 VA: 0x181C58660
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x1AAA4E0 Offset: 0x1AA8AE0 VA: 0x181AAA4E0
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1C586E0 Offset: 0x1C56CE0 VA: 0x181C586E0
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x1621970 Offset: 0x161FF70 VA: 0x181621970
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x510990 Offset: 0x50EF90 VA: 0x180510990
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x1C58520 Offset: 0x1C56B20 VA: 0x181C58520
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1C58530 Offset: 0x1C56B30 VA: 0x181C58530
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1C58700 Offset: 0x1C56D00 VA: 0x181C58700
	internal bool get_HasConstraints() { }

	// RVA: 0x1C04700 Offset: 0x1C02D00 VA: 0x181C04700
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x1C58790 Offset: 0x1C56D90 VA: 0x181C58790
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x5513E0 Offset: 0x54F9E0 VA: 0x1805513E0
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x15B42A0 Offset: 0x15B28A0 VA: 0x1815B42A0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1C58750 Offset: 0x1C56D50 VA: 0x181C58750 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x1C58510 Offset: 0x1C56B10 VA: 0x181C58510 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1C58250 Offset: 0x1C56850 VA: 0x181C58250
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1C58540 Offset: 0x1C56B40 VA: 0x181C58540
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaException : SystemException // TypeDefIndex: 7083
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string sourceUri; // 0xA0
	private int lineNumber; // 0xA8
	private int linePosition; // 0xAC
	private XmlSchemaObject sourceSchemaObject; // 0xB0
	private string message; // 0xB8

	// Properties
	internal string GetRes { get; }
	internal string[] Args { get; }
	public string SourceUri { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public XmlSchemaObject SourceSchemaObject { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1C58D10 Offset: 0x1C57310 VA: 0x181C58D10
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C58A30 Offset: 0x1C57030 VA: 0x181C58A30 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C59200 Offset: 0x1C57800 VA: 0x181C59200
	public void .ctor() { }

	// RVA: 0x1C593E0 Offset: 0x1C579E0 VA: 0x181C593E0
	public void .ctor(string message) { }

	// RVA: 0x1C59230 Offset: 0x1C57830 VA: 0x181C59230
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1C59450 Offset: 0x1C57A50 VA: 0x181C59450
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1C59550 Offset: 0x1C57B50 VA: 0x181C59550
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1C59250 Offset: 0x1C57850 VA: 0x181C59250
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1C59130 Offset: 0x1C57730 VA: 0x181C59130
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1C58C80 Offset: 0x1C57280 VA: 0x181C58C80
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1C58C40 Offset: 0x1C57240 VA: 0x181C58C40
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1C58CC0 Offset: 0x1C572C0 VA: 0x181C58CC0
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x1C59580 Offset: 0x1C57B80 VA: 0x181C59580
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x1C59400 Offset: 0x1C57A00 VA: 0x181C59400
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x1C59310 Offset: 0x1C57910 VA: 0x181C59310
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x1C589E0 Offset: 0x1C56FE0 VA: 0x181C589E0
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	internal string get_GetRes() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	internal string[] get_Args() { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public string get_SourceUri() { }

	// RVA: 0x1C59660 Offset: 0x1C57C60 VA: 0x181C59660
	public int get_LineNumber() { }

	// RVA: 0x3A3480 Offset: 0x3A1A80 VA: 0x1803A3480
	public int get_LinePosition() { }

	// RVA: 0x16237B0 Offset: 0x1621DB0 VA: 0x1816237B0
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x1C58B80 Offset: 0x1C57180 VA: 0x181C58B80
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x8DA860 Offset: 0x8D8E60 VA: 0x1808DA860
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x1C58BD0 Offset: 0x1C571D0 VA: 0x181C58BD0
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x1C59670 Offset: 0x1C57C70 VA: 0x181C59670 Slot: 5
	public override string get_Message() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaExternal : XmlSchemaObject // TypeDefIndex: 7084
{
	// Fields
	private string location; // 0x38
	private Uri baseUri; // 0x40
	private XmlSchema schema; // 0x48
	private string id; // 0x50
	private XmlAttribute[] moreAttributes; // 0x58
	private Compositor compositor; // 0x60

	// Properties
	[Xml("schemaLocation", DataType = "anyURI")]
	public string SchemaLocation { get; set; }
	[XmlIgnore]
	public XmlSchema Schema { get; set; }
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlIgnore]
	internal Uri BaseUri { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }
	internal Compositor Compositor { get; set; }

	// Methods

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_SchemaLocation() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_SchemaLocation(string value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public XmlSchema get_Schema() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_Id() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Id(string value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal Uri get_BaseUri() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x3848A0 Offset: 0x382EA0 VA: 0x1803848A0
	internal Compositor get_Compositor() { }

	// RVA: 0x1548CC0 Offset: 0x15472C0 VA: 0x181548CC0
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal enum FacetType // TypeDefIndex: 7085
{
	// Fields
	public int value__; // 0x0
	public const FacetType None = 0;
	public const FacetType Length = 1;
	public const FacetType MinLength = 2;
	public const FacetType MaxLength = 3;
	public const FacetType Pattern = 4;
	public const FacetType Whitespace = 5;
	public const FacetType Enumeration = 6;
	public const FacetType MinExclusive = 7;
	public const FacetType MinInclusive = 8;
	public const FacetType MaxExclusive = 9;
	public const FacetType MaxInclusive = 10;
	public const FacetType TotalDigits = 11;
	public const FacetType FractionDigits = 12;
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaFacet : XmlSchemaAnnotated // TypeDefIndex: 7086
{
	// Fields
	private string value; // 0x50
	private bool isFixed; // 0x58
	private FacetType facetType; // 0x5C

	// Properties
	[Xml("value")]
	public string Value { get; set; }
	[Xml("fixed")]
	[DefaultValue(False)]
	public virtual bool IsFixed { get; set; }
	internal FacetType FacetType { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_Value() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Value(string value) { }

	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80 Slot: 14
	public virtual bool get_IsFixed() { }

	// RVA: 0x1C59690 Offset: 0x1C57C90 VA: 0x181C59690 Slot: 15
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x15B2E40 Offset: 0x15B1440 VA: 0x1815B2E40
	internal FacetType get_FacetType() { }

	// RVA: 0x1C3C690 Offset: 0x1C3AC90 VA: 0x181C3C690
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaNumericFacet : XmlSchemaFacet // TypeDefIndex: 7087
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 7088
{
	// Methods

	// RVA: 0x1C5A0F0 Offset: 0x1C586F0 VA: 0x181C5A0F0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 7089
{
	// Methods

	// RVA: 0x1C5A1B0 Offset: 0x1C587B0 VA: 0x181C5A1B0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 7090
{
	// Methods

	// RVA: 0x1C5A150 Offset: 0x1C58750 VA: 0x181C5A150
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaPatternFacet : XmlSchemaFacet // TypeDefIndex: 7091
{
	// Methods

	// RVA: 0x1C5A820 Offset: 0x1C58E20 VA: 0x181C5A820
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaEnumerationFacet : XmlSchemaFacet // TypeDefIndex: 7092
{
	// Methods

	// RVA: 0x1C589C0 Offset: 0x1C56FC0 VA: 0x181C589C0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 7093
{
	// Methods

	// RVA: 0x1C5A170 Offset: 0x1C58770 VA: 0x181C5A170
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 7094
{
	// Methods

	// RVA: 0x1C5A190 Offset: 0x1C58790 VA: 0x181C5A190
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 7095
{
	// Methods

	// RVA: 0x1C5A110 Offset: 0x1C58710 VA: 0x181C5A110
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 7096
{
	// Methods

	// RVA: 0x1C5A130 Offset: 0x1C58730 VA: 0x181C5A130
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 7097
{
	// Methods

	// RVA: 0x1C5A840 Offset: 0x1C58E40 VA: 0x181C5A840
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 7098
{
	// Methods

	// RVA: 0x1C59730 Offset: 0x1C57D30 VA: 0x181C59730
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet // TypeDefIndex: 7099
{
	// Methods

	// RVA: 0x1C5A860 Offset: 0x1C58E60 VA: 0x181C5A860
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaForm // TypeDefIndex: 7100
{
	// Fields
	public int value__; // 0x0
	[XmlIgnore]
	public const XmlSchemaForm None = 0;
	[XmlEnum("qualified")]
	public const XmlSchemaForm Qualified = 1;
	[XmlEnum("unqualified")]
	public const XmlSchemaForm Unqualified = 2;
}

// Namespace: System.Xml.Schema
public class XmlSchemaGroup : XmlSchemaAnnotated // TypeDefIndex: 7101
{
	// Fields
	private string name; // 0x50
	private XmlSchemaGroupBase particle; // 0x58
	private XmlSchemaParticle canonicalParticle; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaGroup redefined; // 0x70
	private int selfReferenceCount; // 0x78

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaGroupBase Particle { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal XmlSchemaParticle CanonicalParticle { get; set; }
	[XmlIgnore]
	internal XmlSchemaGroup Redefined { get; set; }
	[XmlIgnore]
	internal int SelfReferenceCount { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_Name() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Name(string value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1869360 Offset: 0x1867960 VA: 0x181869360
	internal int get_SelfReferenceCount() { }

	// RVA: 0x18693A0 Offset: 0x18679A0 VA: 0x1818693A0
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1C59AF0 Offset: 0x1C580F0 VA: 0x181C59AF0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1C598E0 Offset: 0x1C57EE0 VA: 0x181C598E0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1C59B00 Offset: 0x1C58100 VA: 0x181C59B00
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaGroupBase : XmlSchemaParticle // TypeDefIndex: 7102
{
	// Properties
	[XmlIgnore]
	public abstract XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XmlSchemaObjectCollection get_Items();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void SetItems(XmlSchemaObjectCollection newItems);

	// RVA: 0x1C59750 Offset: 0x1C57D50 VA: 0x181C59750
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaGroupRef : XmlSchemaParticle // TypeDefIndex: 7103
{
	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Properties
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[XmlIgnore]
	public XmlSchemaGroupBase Particle { get; }
	[XmlIgnore]
	internal XmlSchemaGroup Redefined { get; set; }

	// Methods

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1C59830 Offset: 0x1C57E30 VA: 0x181C59830
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1C597A0 Offset: 0x1C57DA0 VA: 0x181C597A0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated // TypeDefIndex: 7104
{
	// Fields
	private string name; // 0x50
	private XmlSchemaXPath selector; // 0x58
	private XmlSchemaObjectCollection fields; // 0x60
	private XmlQualifiedName qualifiedName; // 0x68
	private CompiledIdentityConstraint compiledConstraint; // 0x70

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("selector", typeof(XmlSchemaXPath))]
	public XmlSchemaXPath Selector { get; set; }
	[XmlElement("field", typeof(XmlSchemaXPath))]
	public XmlSchemaObjectCollection Fields { get; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal CompiledIdentityConstraint CompiledConstraint { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_Name() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Name(string value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1C59B70 Offset: 0x1C58170 VA: 0x181C59B70
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaXPath : XmlSchemaAnnotated // TypeDefIndex: 7105
{
	// Fields
	private string xpath; // 0x50

	// Properties
	[Xml("xpath")]
	[DefaultValue("")]
	public string XPath { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_XPath() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_XPath(string value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaUnique : XmlSchemaIdentityConstraint // TypeDefIndex: 7106
{
	// Methods

	// RVA: 0x1C59F30 Offset: 0x1C58530 VA: 0x181C59F30
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaKey : XmlSchemaIdentityConstraint // TypeDefIndex: 7107
{
	// Methods

	// RVA: 0x1C59F30 Offset: 0x1C58530 VA: 0x181C59F30
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaKeyref : XmlSchemaIdentityConstraint // TypeDefIndex: 7108
{
	// Fields
	private XmlQualifiedName refer; // 0x78

	// Properties
	[Xml("refer")]
	public XmlQualifiedName Refer { get; set; }

	// Methods

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x1C5A040 Offset: 0x1C58640 VA: 0x181C5A040
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x1C59F40 Offset: 0x1C58540 VA: 0x181C59F40
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaImport : XmlSchemaExternal // TypeDefIndex: 7109
{
	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Properties
	[Xml("namespace", DataType = "anyURI")]
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x1C59C20 Offset: 0x1C58220 VA: 0x181C59C20
	public void .ctor() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public string get_Namespace() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void set_Namespace(string value) { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaInclude : XmlSchemaExternal // TypeDefIndex: 7110
{
	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x1C59C40 Offset: 0x1C58240 VA: 0x181C59C40
	public void .ctor() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaInfo : IXmlSchemaInfo // TypeDefIndex: 7111
{
	// Fields
	private bool isDefault; // 0x10
	private bool isNil; // 0x11
	private XmlSchemaElement schemaElement; // 0x18
	private XmlSchemaAttribute schemaAttribute; // 0x20
	private XmlSchemaType schemaType; // 0x28
	private XmlSchemaSimpleType memberType; // 0x30
	private XmlSchemaValidity validity; // 0x38
	private XmlSchemaContentType contentType; // 0x3C

	// Properties
	public XmlSchemaValidity Validity { get; set; }
	public bool IsDefault { get; set; }
	public bool IsNil { get; set; }
	public XmlSchemaSimpleType MemberType { get; set; }
	public XmlSchemaType SchemaType { get; set; }
	public XmlSchemaElement SchemaElement { get; set; }
	public XmlSchemaAttribute SchemaAttribute { get; set; }
	public XmlSchemaContentType ContentType { get; }
	internal XmlSchemaType XmlType { get; }
	internal bool HasDefaultValue { get; }
	internal bool IsUnionType { get; }

	// Methods

	// RVA: 0x1C59D50 Offset: 0x1C58350 VA: 0x181C59D50
	public void .ctor() { }

	// RVA: 0x1C59CD0 Offset: 0x1C582D0 VA: 0x181C59CD0
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990 Slot: 4
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00 Slot: 5
	public bool get_IsDefault() { }

	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_IsDefault(bool value) { }

	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90 Slot: 6
	public bool get_IsNil() { }

	// RVA: 0x14B8CA0 Offset: 0x14B72A0 VA: 0x1814B8CA0
	public void set_IsNil(bool value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 7
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 8
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x1C59EE0 Offset: 0x1C584E0 VA: 0x181C59EE0
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 9
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1C59EA0 Offset: 0x1C584A0 VA: 0x181C59EA0
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 10
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1C59E60 Offset: 0x1C58460 VA: 0x181C59E60
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1C59E40 Offset: 0x1C58440 VA: 0x181C59E40
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x1C59DC0 Offset: 0x1C583C0 VA: 0x181C59DC0
	internal bool get_HasDefaultValue() { }

	// RVA: 0x1C59E00 Offset: 0x1C58400 VA: 0x181C59E00
	internal bool get_IsUnionType() { }

	// RVA: 0x1C59C60 Offset: 0x1C58260 VA: 0x181C59C60
	internal void Clear() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaNotation : XmlSchemaAnnotated // TypeDefIndex: 7112
{
	// Fields
	private string name; // 0x50
	private string publicId; // 0x58
	private string systemId; // 0x60
	private XmlQualifiedName qname; // 0x68

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[Xml("public")]
	public string Public { get; set; }
	[Xml("system")]
	public string System { get; set; }
	[XmlIgnore]
	internal XmlQualifiedName QualifiedName { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_Name() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Name(string value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public string get_Public() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_Public(string value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public string get_System() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_System(string value) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1C5A1D0 Offset: 0x1C587D0 VA: 0x181C5A1D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaObject // TypeDefIndex: 7113
{
	// Fields
	private int lineNum; // 0x10
	private int linePos; // 0x14
	private string sourceUri; // 0x18
	private XmlSerializerNamespaces namespaces; // 0x20
	private XmlSchemaObject parent; // 0x28
	private bool isProcessing; // 0x30

	// Properties
	[XmlIgnore]
	public int LineNumber { get; set; }
	[XmlIgnore]
	public int LinePosition { get; set; }
	[XmlIgnore]
	public string SourceUri { get; set; }
	[XmlIgnore]
	public XmlSchemaObject Parent { get; set; }
	[XmlNamespaceDeclarations]
	public XmlSerializerNamespaces Namespaces { get; set; }
	[XmlIgnore]
	internal virtual string IdAttribute { get; set; }
	[XmlIgnore]
	internal virtual string NameAttribute { get; set; }
	[XmlIgnore]
	internal bool IsProcessing { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_LineNumber() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_LineNumber(int value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_LinePosition() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_LinePosition(int value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_SourceUri() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_SourceUri(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x1C5A7B0 Offset: 0x1C58DB0 VA: 0x181C5A7B0
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	internal virtual string get_IdAttribute() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 11
	internal virtual string get_NameAttribute() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	internal bool get_IsProcessing() { }

	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x1C5A730 Offset: 0x1C58D30 VA: 0x181C5A730 Slot: 13
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
public class XmlSchemaObjectCollection : CollectionBase // TypeDefIndex: 7114
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Properties
	public virtual XmlSchemaObject Item { get; set; }

	// Methods

	// RVA: 0x131ABA0 Offset: 0x13191A0 VA: 0x18131ABA0
	public void .ctor() { }

	// RVA: 0x1C5A5F0 Offset: 0x1C58BF0 VA: 0x181C5A5F0 Slot: 29
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x1C5A6B0 Offset: 0x1C58CB0 VA: 0x181C5A6B0 Slot: 30
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x1C5A360 Offset: 0x1C58960 VA: 0x181C5A360
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x1C5A270 Offset: 0x1C58870 VA: 0x181C5A270
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x1C5A3E0 Offset: 0x1C589E0 VA: 0x181C5A3E0
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x1C5A520 Offset: 0x1C58B20 VA: 0x181C5A520
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x1C5A480 Offset: 0x1C58A80 VA: 0x181C5A480 Slot: 21
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x1C5A4C0 Offset: 0x1C58AC0 VA: 0x181C5A4C0 Slot: 20
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x1C5A460 Offset: 0x1C58A60 VA: 0x181C5A460 Slot: 22
	protected override void OnClear() { }

	// RVA: 0x1C5A4A0 Offset: 0x1C58AA0 VA: 0x181C5A4A0 Slot: 23
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x1C5A2E0 Offset: 0x1C588E0 VA: 0x181C5A2E0
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x1C5A240 Offset: 0x1C58840 VA: 0x181C5A240
	private void Add(XmlSchemaObjectCollection collToAdd) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectEnumerator : IEnumerator // TypeDefIndex: 7115
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public XmlSchemaObject Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(IEnumerator enumerator) { }

	// RVA: 0x1C62C90 Offset: 0x1C61290 VA: 0x181C62C90
	public bool MoveNext() { }

	// RVA: 0x1C62DD0 Offset: 0x1C613D0 VA: 0x181C62DD0
	public XmlSchemaObject get_Current() { }

	// RVA: 0x1C62D30 Offset: 0x1C61330 VA: 0x181C62D30 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1C62CE0 Offset: 0x1C612E0 VA: 0x181C62CE0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1C62D80 Offset: 0x1C61380 VA: 0x181C62D80 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
public class XmlSchemaObjectTable // TypeDefIndex: 7121
{
	// Fields
	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; // 0x10
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Properties
	public int Count { get; }
	public XmlSchemaObject Item { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x1C63540 Offset: 0x1C61B40 VA: 0x181C63540
	internal void .ctor() { }

	// RVA: 0x1C62E70 Offset: 0x1C61470 VA: 0x181C62E70
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1C63200 Offset: 0x1C61800 VA: 0x181C63200
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1C63410 Offset: 0x1C61A10 VA: 0x181C63410
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1C62FA0 Offset: 0x1C615A0 VA: 0x181C62FA0
	internal void Clear() { }

	// RVA: 0x1C63350 Offset: 0x1C61950 VA: 0x181C63350
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x1C63090 Offset: 0x1C61690 VA: 0x181C63090
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x1C63600 Offset: 0x1C61C00 VA: 0x181C63600
	public int get_Count() { }

	// RVA: 0x1C63030 Offset: 0x1C61630 VA: 0x181C63030
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x1C63650 Offset: 0x1C61C50 VA: 0x181C63650
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x1C636D0 Offset: 0x1C61CD0 VA: 0x181C636D0
	public ICollection get_Values() { }

	// RVA: 0x1C63150 Offset: 0x1C61750 VA: 0x181C63150
	public IDictionaryEnumerator GetEnumerator() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaParticle : XmlSchemaAnnotated // TypeDefIndex: 7124
{
	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private XmlSchemaParticle.Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Properties
	[Xml("minOccurs")]
	public string MinOccursString { get; set; }
	[Xml("maxOccurs")]
	public string MaxOccursString { get; set; }
	[XmlIgnore]
	public Decimal MinOccurs { get; set; }
	[XmlIgnore]
	public Decimal MaxOccurs { get; set; }
	internal virtual bool IsEmpty { get; }
	internal virtual string NameString { get; }

	// Methods

	// RVA: 0x1C63C20 Offset: 0x1C62220 VA: 0x181C63C20
	public string get_MinOccursString() { }

	// RVA: 0x1C64060 Offset: 0x1C62660 VA: 0x181C64060
	public void set_MinOccursString(string value) { }

	// RVA: 0x1C63B00 Offset: 0x1C62100 VA: 0x181C63B00
	public string get_MaxOccursString() { }

	// RVA: 0x1C63C90 Offset: 0x1C62290 VA: 0x181C63C90
	public void set_MaxOccursString(string value) { }

	// RVA: 0x9E35B0 Offset: 0x9E1BB0 VA: 0x1809E35B0
	public Decimal get_MinOccurs() { }

	// RVA: 0x1C641D0 Offset: 0x1C627D0 VA: 0x181C641D0
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0x15B7430 Offset: 0x15B5A30 VA: 0x1815B7430
	public Decimal get_MaxOccurs() { }

	// RVA: 0x1C63EC0 Offset: 0x1C624C0 VA: 0x181C63EC0
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x1C63A80 Offset: 0x1C62080 VA: 0x181C63A80 Slot: 14
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x37A870 Offset: 0x378E70 VA: 0x18037A870 Slot: 15
	internal virtual string get_NameString() { }

	// RVA: 0x1C63770 Offset: 0x1C61D70 VA: 0x181C63770
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x1C63A00 Offset: 0x1C62000 VA: 0x181C63A00
	protected void .ctor() { }

	// RVA: 0x1C638F0 Offset: 0x1C61EF0 VA: 0x181C638F0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaRedefine : XmlSchemaExternal // TypeDefIndex: 7125
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x68
	private XmlSchemaObjectTable attributeGroups; // 0x70
	private XmlSchemaObjectTable types; // 0x78
	private XmlSchemaObjectTable groups; // 0x80

	// Properties
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Groups { get; }

	// Methods

	// RVA: 0x1C64330 Offset: 0x1C62930 VA: 0x181C64330
	public void .ctor() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x1C64310 Offset: 0x1C62910 VA: 0x181C64310 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSequence : XmlSchemaGroupBase // TypeDefIndex: 7126
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1C644A0 Offset: 0x1C62AA0 VA: 0x181C644A0 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1C64430 Offset: 0x1C62A30 VA: 0x181C64430
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSet // TypeDefIndex: 7127
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private SortedList schemas; // 0x20
	private ValidationEventHandler internalEventHandler; // 0x28
	private ValidationEventHandler eventHandler; // 0x30
	private bool isCompiled; // 0x38
	private Hashtable schemaLocations; // 0x40
	private Hashtable chameleonSchemas; // 0x48
	private Hashtable targetNamespaces; // 0x50
	private bool compileAll; // 0x58
	private SchemaInfo cachedCompiledInfo; // 0x60
	private XmlReaderSettings readerSettings; // 0x68
	private XmlSchema schemaForSchema; // 0x70
	private XmlSchemaCompilationSettings compilationSettings; // 0x78
	internal XmlSchemaObjectTable elements; // 0x80
	internal XmlSchemaObjectTable attributes; // 0x88
	internal XmlSchemaObjectTable schemaTypes; // 0x90
	internal XmlSchemaObjectTable substitutionGroups; // 0x98
	private XmlSchemaObjectTable typeExtensions; // 0xA0
	private object internalSyncObject; // 0xA8

	// Properties
	internal object InternalSyncObject { get; }
	public bool IsCompiled { get; }
	public XmlResolver XmlResolver { set; }
	public XmlSchemaCompilationSettings CompilationSettings { get; set; }
	public int Count { get; }
	public XmlSchemaObjectTable GlobalElements { get; }
	public XmlSchemaObjectTable GlobalAttributes { get; }
	public XmlSchemaObjectTable GlobalTypes { get; }
	internal XmlSchemaObjectTable SubstitutionGroups { get; }
	internal Hashtable SchemaLocations { get; }
	internal XmlSchemaObjectTable TypeExtensions { get; }
	internal SchemaInfo CompiledInfo { get; }
	internal XmlReaderSettings ReaderSettings { get; }
	internal SortedList SortedSchemas { get; }

	// Methods

	// RVA: 0x1C6D630 Offset: 0x1C6BC30 VA: 0x181C6D630
	internal object get_InternalSyncObject() { }

	// RVA: 0x1C6CFE0 Offset: 0x1C6B5E0 VA: 0x181C6CFE0
	public void .ctor() { }

	// RVA: 0x1C6D040 Offset: 0x1C6B640 VA: 0x181C6D040
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1C6D340 Offset: 0x1C6B940 VA: 0x181C6D340
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1C6D7B0 Offset: 0x1C6BDB0 VA: 0x181C6D7B0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	public bool get_IsCompiled() { }

	// RVA: 0x1C6D870 Offset: 0x1C6BE70 VA: 0x181C6D870
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x3E13F0 Offset: 0x3DF9F0 VA: 0x1803E13F0
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x1C6D480 Offset: 0x1C6BA80 VA: 0x181C6D480
	public int get_Count() { }

	// RVA: 0x1C6D530 Offset: 0x1C6BB30 VA: 0x181C6D530
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x1C6D4B0 Offset: 0x1C6BAB0 VA: 0x181C6D4B0
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x1C6D5B0 Offset: 0x1C6BBB0 VA: 0x181C6D5B0
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x1C6D6B0 Offset: 0x1C6BCB0 VA: 0x181C6D6B0
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x1C6D730 Offset: 0x1C6BD30 VA: 0x181C6D730
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x1C64D60 Offset: 0x1C63360 VA: 0x181C64D60
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x1C65DB0 Offset: 0x1C643B0 VA: 0x181C65DB0
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x1C6A520 Offset: 0x1C68B20 VA: 0x181C6A520
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x1C666B0 Offset: 0x1C64CB0 VA: 0x181C666B0
	public bool Contains(string targetNamespace) { }

	// RVA: 0x1C66070 Offset: 0x1C64670 VA: 0x181C66070
	public void Compile() { }

	// RVA: 0x1C6C0B0 Offset: 0x1C6A6B0 VA: 0x181C6C0B0
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x1C687E0 Offset: 0x1C66DE0 VA: 0x181C687E0
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x1C6CDD0 Offset: 0x1C6B3D0 VA: 0x181C6CDD0
	public ICollection Schemas() { }

	// RVA: 0x1C6CC40 Offset: 0x1C6B240 VA: 0x181C6CC40
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x1C64D00 Offset: 0x1C63300 VA: 0x181C64D00
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x1C65920 Offset: 0x1C63F20 VA: 0x181C65920
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x1C68980 Offset: 0x1C66F80 VA: 0x181C68980
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x1C64550 Offset: 0x1C62B50 VA: 0x181C64550
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x1C69D80 Offset: 0x1C68380 VA: 0x181C69D80
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x1C6C850 Offset: 0x1C6AE50 VA: 0x181C6C850
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x1C6BDC0 Offset: 0x1C6A3C0 VA: 0x181C6BDC0
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x1C65F70 Offset: 0x1C64570 VA: 0x181C65F70
	private void ClearTables() { }

	// RVA: 0x1C69C20 Offset: 0x1C68220 VA: 0x181C69C20
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x1C69AF0 Offset: 0x1C680F0 VA: 0x181C69AF0
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x1C66700 Offset: 0x1C64D00 VA: 0x181C66700
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x1C68C50 Offset: 0x1C67250 VA: 0x181C68C50
	internal XmlResolver GetResolver() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1C68DF0 Offset: 0x1C673F0 VA: 0x181C68DF0
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1C68F40 Offset: 0x1C67540 VA: 0x181C68F40
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x1C68C70 Offset: 0x1C67270 VA: 0x181C68C70
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x1C68EB0 Offset: 0x1C674B0 VA: 0x181C68EB0
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x1C6ADF0 Offset: 0x1C693F0 VA: 0x181C6ADF0
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x1C6B2E0 Offset: 0x1C698E0 VA: 0x181C6B2E0
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x1C64940 Offset: 0x1C62F40 VA: 0x181C64940
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1C6CEC0 Offset: 0x1C6B4C0 VA: 0x181C6CEC0
	private void VerifyTables() { }

	// RVA: 0x1C68EF0 Offset: 0x1C674F0 VA: 0x181C68EF0
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x1C6CE00 Offset: 0x1C6B400 VA: 0x181C6CE00
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContent : XmlSchemaContentModel // TypeDefIndex: 7128
{
	// Fields
	private XmlSchemaContent content; // 0x50

	// Properties
	[XmlElement("extension", typeof(XmlSchemaSimpleContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaSimpleContentRestriction))]
	public override XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentExtension : XmlSchemaContent // TypeDefIndex: 7129
{
	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1C6D940 Offset: 0x1C6BF40 VA: 0x181C6D940
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1C6D890 Offset: 0x1C6BE90 VA: 0x181C6D890
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentRestriction : XmlSchemaContent // TypeDefIndex: 7130
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60
	private XmlSchemaObjectCollection attributes; // 0x68
	private XmlSchemaAnyAttribute anyAttribute; // 0x70

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	public XmlSchemaObjectCollection Facets { get; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1C6DAD0 Offset: 0x1C6C0D0 VA: 0x181C6DAD0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1C6D9F0 Offset: 0x1C6BFF0 VA: 0x181C6D9F0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleType : XmlSchemaType // TypeDefIndex: 7131
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Properties
	[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
	[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
	[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
	public XmlSchemaSimpleTypeContent Content { get; set; }

	// Methods

	// RVA: 0x1C6E3D0 Offset: 0x1C6C9D0 VA: 0x181C6E3D0
	public void .ctor() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x534930 Offset: 0x532F30 VA: 0x180534930
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0x1C6E2A0 Offset: 0x1C6C8A0 VA: 0x181C6E2A0 Slot: 13
	internal override XmlSchemaObject Clone() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated // TypeDefIndex: 7132
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent // TypeDefIndex: 7133
{
	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Properties
	[Xml("itemType")]
	public XmlQualifiedName ItemTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType ItemType { get; set; }
	[XmlIgnore]
	public XmlSchemaSimpleType BaseItemType { get; set; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x1C6DD20 Offset: 0x1C6C320 VA: 0x181C6DD20
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x1C6DB80 Offset: 0x1C6C180 VA: 0x181C6DB80 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1C6DCB0 Offset: 0x1C6C2B0 VA: 0x181C6DCB0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent // TypeDefIndex: 7134
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	public XmlSchemaObjectCollection Facets { get; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1C6DFB0 Offset: 0x1C6C5B0 VA: 0x181C6DFB0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x1C6DDD0 Offset: 0x1C6C3D0 VA: 0x181C6DDD0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1C6DF00 Offset: 0x1C6C500 VA: 0x181C6DF00
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent // TypeDefIndex: 7135
{
	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Properties
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection BaseTypes { get; }
	[Xml("memberTypes")]
	public XmlQualifiedName[] MemberTypes { get; set; }
	[XmlIgnore]
	public XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x1C6E060 Offset: 0x1C6C660 VA: 0x181C6E060 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1C6E230 Offset: 0x1C6C830 VA: 0x181C6E230
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroup : XmlSchemaObject // TypeDefIndex: 7136
{
	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Properties
	[XmlIgnore]
	internal ArrayList Members { get; }
	[XmlIgnore]
	internal XmlQualifiedName Examplar { get; set; }

	// Methods

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	internal ArrayList get_Members() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0x1C6E550 Offset: 0x1C6CB50 VA: 0x181C6E550
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup // TypeDefIndex: 7137
{
	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Properties
	[XmlIgnore]
	internal XmlSchemaChoice Choice { get; }

	// Methods

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0x1C6E460 Offset: 0x1C6CA60 VA: 0x181C6E460
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaType : XmlSchemaAnnotated // TypeDefIndex: 7138
{
	// Fields
	private string name; // 0x50
	private XmlSchemaDerivationMethod final; // 0x58
	private XmlSchemaDerivationMethod derivedBy; // 0x5C
	private XmlSchemaType baseSchemaType; // 0x60
	private XmlSchemaDatatype datatype; // 0x68
	private XmlSchemaDerivationMethod finalResolved; // 0x70
	private SchemaElementDecl elementDecl; // 0x78
	private XmlQualifiedName qname; // 0x80
	private XmlSchemaType redefined; // 0x88
	private XmlSchemaContentType contentType; // 0x90

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[Xml("final")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod Final { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved { get; }
	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod DerivedBy { get; }
	[XmlIgnore]
	public XmlSchemaDatatype Datatype { get; }
	[XmlIgnore]
	public virtual bool IsMixed { get; set; }
	[XmlIgnore]
	public XmlTypeCode TypeCode { get; }
	[XmlIgnore]
	internal XmlValueConverter ValueConverter { get; }
	internal XmlSchemaContentType SchemaContentType { get; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnore]
	internal XmlSchemaType Redefined { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x1C6E860 Offset: 0x1C6CE60 VA: 0x181C6E860
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x1C6E930 Offset: 0x1C6CF30 VA: 0x181C6E930
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x1C6E600 Offset: 0x1C6CC00 VA: 0x181C6E600
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_Name() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Name(string value) { }

	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x399820 Offset: 0x397E20 VA: 0x180399820
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1C6EC40 Offset: 0x1C6D240 VA: 0x181C6EC40
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x15B2E40 Offset: 0x15B1440 VA: 0x1815B2E40
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 14
	public virtual bool get_IsMixed() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 15
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0x1C6EC60 Offset: 0x1C6D260 VA: 0x181C6EC60
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0x1C6ED20 Offset: 0x1C6D320 VA: 0x181C6ED20
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x1C6EBE0 Offset: 0x1C6D1E0 VA: 0x181C6EBE0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x4A4300 Offset: 0x4A2900 VA: 0x1804A4300
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0xEB3B80 Offset: 0xEB2180 VA: 0x180EB3B80
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x1C3C690 Offset: 0x1C3AC90 VA: 0x181C3C690
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x1C6EC20 Offset: 0x1C6D220 VA: 0x181C6EC20
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x1C6EDA0 Offset: 0x1C6D3A0 VA: 0x181C6EDA0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0xAC7EF0 Offset: 0xAC64F0 VA: 0x180AC7EF0
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x1C6EA50 Offset: 0x1C6D050 VA: 0x181C6EA50
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x1C6E980 Offset: 0x1C6CF80 VA: 0x181C6E980
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1C6E3D0 Offset: 0x1C6C9D0 VA: 0x181C6E3D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaUse // TypeDefIndex: 7139
{
	// Fields
	public int value__; // 0x0
	[XmlIgnore]
	public const XmlSchemaUse None = 0;
	[XmlEnum("optional")]
	public const XmlSchemaUse Optional = 1;
	[XmlEnum("prohibited")]
	public const XmlSchemaUse Prohibited = 2;
	[XmlEnum("required")]
	public const XmlSchemaUse Required = 3;
}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaValidationException : XmlSchemaException // TypeDefIndex: 7140
{
	// Methods

	// RVA: 0x1BF9D40 Offset: 0x1BF8340 VA: 0x181BF9D40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BF9C30 Offset: 0x1BF8230 VA: 0x181BF9C30 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BF9D60 Offset: 0x1BF8360 VA: 0x181BF9D60
	public void .ctor() { }

	// RVA: 0x1C6EE10 Offset: 0x1C6D410 VA: 0x181C6EE10
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1C58C40 Offset: 0x1C57240 VA: 0x181C58C40
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1C6EDD0 Offset: 0x1C6D3D0 VA: 0x181C6EDD0
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Schema
public sealed class XmlValueGetter : MulticastDelegate // TypeDefIndex: 7141
{
	// Methods

	// RVA: 0x1012020 Offset: 0x1010620 VA: 0x181012020
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1011D00 Offset: 0x1010300 VA: 0x181011D00 Slot: 13
	public virtual object Invoke() { }
}

// Namespace: System.Xml.Schema
[Flags]
public enum XmlSchemaValidationFlags // TypeDefIndex: 7142
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidationFlags None = 0;
	public const XmlSchemaValidationFlags ProcessInlineSchema = 1;
	public const XmlSchemaValidationFlags ProcessSchemaLocation = 2;
	public const XmlSchemaValidationFlags ReportValidationWarnings = 4;
	public const XmlSchemaValidationFlags ProcessIdentityConstraints = 8;
	public const XmlSchemaValidationFlags AllowXmlAttributes = 16;
}

// Namespace: System.Xml.Schema
internal enum ValidatorState // TypeDefIndex: 7143
{
	// Fields
	public int value__; // 0x0
	public const ValidatorState None = 0;
	public const ValidatorState Start = 1;
	public const ValidatorState TopLevelAttribute = 2;
	public const ValidatorState TopLevelTextOrWS = 3;
	public const ValidatorState Element = 4;
	public const ValidatorState Attribute = 5;
	public const ValidatorState EndOfAttributes = 6;
	public const ValidatorState Text = 7;
	public const ValidatorState Whitespace = 8;
	public const ValidatorState EndElement = 9;
	public const ValidatorState SkipToEndElement = 10;
	public const ValidatorState Finish = 11;
}

// Namespace: System.Xml.Schema
internal class IdRefNode // TypeDefIndex: 7144
{
	// Fields
	internal string Id; // 0x10
	internal int LineNo; // 0x18
	internal int LinePos; // 0x1C
	internal IdRefNode Next; // 0x20

	// Methods

	// RVA: 0x1C5BDB0 Offset: 0x1C5A3B0 VA: 0x181C5BDB0
	internal void .ctor(IdRefNode next, string id, int lineNo, int linePos) { }
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaValidator // TypeDefIndex: 7145
{
	// Fields
	private XmlSchemaSet schemaSet; // 0x10
	private XmlSchemaValidationFlags validationFlags; // 0x18
	private int startIDConstraint; // 0x1C
	private bool isRoot; // 0x20
	private bool rootHasSchema; // 0x21
	private bool attrValid; // 0x22
	private bool checkEntity; // 0x23
	private SchemaInfo compiledSchemaInfo; // 0x28
	private IDtdInfo dtdSchemaInfo; // 0x30
	private Hashtable validatedNamespaces; // 0x38
	private HWStack validationStack; // 0x40
	private ValidationState context; // 0x48
	private ValidatorState currentState; // 0x50
	private Hashtable attPresence; // 0x58
	private SchemaAttDef wildID; // 0x60
	private Hashtable IDs; // 0x68
	private IdRefNode idRefListHead; // 0x70
	private XmlQualifiedName contextQName; // 0x78
	private string NsXs; // 0x80
	private string NsXsi; // 0x88
	private string NsXmlNs; // 0x90
	private string NsXml; // 0x98
	private XmlSchemaObject partialValidationType; // 0xA0
	private StringBuilder textValue; // 0xA8
	private ValidationEventHandler eventHandler; // 0xB0
	private object validationEventSender; // 0xB8
	private XmlNameTable nameTable; // 0xC0
	private IXmlLineInfo positionInfo; // 0xC8
	private IXmlLineInfo dummyPositionInfo; // 0xD0
	private XmlResolver xmlResolver; // 0xD8
	private Uri sourceUri; // 0xE0
	private string sourceUriString; // 0xE8
	private IXmlNamespaceResolver nsResolver; // 0xF0
	private XmlSchemaContentProcessing processContents; // 0xF8
	private string xsiTypeString; // 0x100
	private string xsiNilString; // 0x108
	private string xsiSchemaLocationString; // 0x110
	private string xsiNoNamespaceSchemaLocationString; // 0x118
	private static readonly XmlSchemaDatatype dtQName; // 0x0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; // 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; // 0x20
	private XmlCharType xmlCharType; // 0x120
	internal static bool[,] ValidStates; // 0x28
	private static string[] MethodNames; // 0x30

	// Properties
	public XmlResolver XmlResolver { set; }
	public IXmlLineInfo LineInfoProvider { set; }
	public Uri SourceUri { set; }
	public object ValidationEventSender { set; }
	internal XmlSchemaSet SchemaSet { get; }
	internal XmlSchemaValidationFlags ValidationFlags { get; }
	internal XmlSchemaContentType CurrentContentType { get; }
	private bool StrictlyAssessed { get; }
	private bool HasSchema { get; }
	private bool HasIdentityConstraints { get; }
	internal bool ProcessIdentityConstraints { get; }
	internal bool ReportValidationWarnings { get; }
	internal bool ProcessSchemaHints { get; }

	// Methods

	// RVA: 0x1C7B240 Offset: 0x1C79840 VA: 0x181C7B240
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x1C74DC0 Offset: 0x1C733C0 VA: 0x181C74DC0
	private void Init() { }

	// RVA: 0x1C77870 Offset: 0x1C75E70 VA: 0x181C77870
	private void Reset() { }

	// RVA: 0x15B40E0 Offset: 0x15B26E0 VA: 0x1815B40E0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1C7B8B0 Offset: 0x1C79EB0 VA: 0x181C7B8B0
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x1C7B8E0 Offset: 0x1C79EE0 VA: 0x181C7B8E0
	public void set_SourceUri(Uri value) { }

	// RVA: 0x8221D0 Offset: 0x8207D0 VA: 0x1808221D0
	public void set_ValidationEventSender(object value) { }

	// RVA: 0x1C7B620 Offset: 0x1C79C20 VA: 0x181C7B620
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1C7B800 Offset: 0x1C79E00 VA: 0x181C7B800
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1C6F400 Offset: 0x1C6DA00 VA: 0x181C6F400
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0x1C75210 Offset: 0x1C73810 VA: 0x181C75210
	public void Initialize() { }

	// RVA: 0x1C75370 Offset: 0x1C73970 VA: 0x181C75370
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x1C7A010 Offset: 0x1C78610 VA: 0x181C7A010
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x1C79A10 Offset: 0x1C78010 VA: 0x181C79A10
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C78F90 Offset: 0x1C77590 VA: 0x181C78F90
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C7A530 Offset: 0x1C78B30 VA: 0x181C7A530
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C7A660 Offset: 0x1C78C60 VA: 0x181C7A660
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x1C7A6D0 Offset: 0x1C78CD0 VA: 0x181C7A6D0
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x1C7AD80 Offset: 0x1C79380 VA: 0x181C7AD80
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x1C7AB20 Offset: 0x1C79120 VA: 0x181C7AB20
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x1C7A520 Offset: 0x1C78B20 VA: 0x181C7A520
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C783E0 Offset: 0x1C769E0 VA: 0x181C783E0
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C737D0 Offset: 0x1C71DD0 VA: 0x181C737D0
	public void EndValidation() { }

	// RVA: 0x1C74680 Offset: 0x1C72C80 VA: 0x181C74680
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1C7B6D0 Offset: 0x1C79CD0 VA: 0x181C7B6D0
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x1C783C0 Offset: 0x1C769C0 VA: 0x181C783C0
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x1C7B7C0 Offset: 0x1C79DC0 VA: 0x181C7B7C0
	private bool get_StrictlyAssessed() { }

	// RVA: 0x1C7B730 Offset: 0x1C79D30 VA: 0x181C7B730
	private bool get_HasSchema() { }

	// RVA: 0x1C73F90 Offset: 0x1C72590 VA: 0x181C73F90
	internal string GetConcatenatedValue() { }

	// RVA: 0x1C75650 Offset: 0x1C73C50 VA: 0x181C75650
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x1C76F60 Offset: 0x1C75560 VA: 0x181C76F60
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x1C79A90 Offset: 0x1C78090 VA: 0x181C79A90
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0x1C743D0 Offset: 0x1C729D0 VA: 0x181C743D0
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x1C78C80 Offset: 0x1C77280 VA: 0x181C78C80
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x1C78860 Offset: 0x1C76E60 VA: 0x181C78860
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x1C74610 Offset: 0x1C72C10 VA: 0x181C74610
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x1C77930 Offset: 0x1C75F30 VA: 0x181C77930
	private void SaveTextValue(object value) { }

	// RVA: 0x1C77580 Offset: 0x1C75B80 VA: 0x181C77580
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1C76110 Offset: 0x1C74710 VA: 0x181C76110
	private void Pop() { }

	// RVA: 0x1C73C30 Offset: 0x1C72230 VA: 0x181C73C30
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x1C70ED0 Offset: 0x1C6F4D0 VA: 0x181C70ED0
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0x1C78620 Offset: 0x1C76C20 VA: 0x181C78620
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x1C70100 Offset: 0x1C6E700 VA: 0x181C70100
	private void CheckElementProperties() { }

	// RVA: 0x1C7A600 Offset: 0x1C78C00 VA: 0x181C7A600
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1C70640 Offset: 0x1C6EC40 VA: 0x181C70640
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x1C6F840 Offset: 0x1C6DE40 VA: 0x181C6F840
	private void AddXmlNamespaceSchema() { }

	// RVA: 0x1C707D0 Offset: 0x1C6EDD0 VA: 0x181C707D0
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x1C75CB0 Offset: 0x1C742B0 VA: 0x181C75CB0
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1C77800 Offset: 0x1C75E00 VA: 0x181C77800
	internal void RecompileSchemaSet() { }

	// RVA: 0x1C77250 Offset: 0x1C75850 VA: 0x181C77250
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x1C6FE60 Offset: 0x1C6E460 VA: 0x181C6FE60
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x1C701F0 Offset: 0x1C6E7F0 VA: 0x181C701F0
	private object CheckElementValue(string stringValue) { }

	// RVA: 0x1C70D50 Offset: 0x1C6F350 VA: 0x181C70D50
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x1C73F60 Offset: 0x1C72560 VA: 0x181C73F60
	private object FindId(string name) { }

	// RVA: 0x1C70510 Offset: 0x1C6EB10 VA: 0x181C70510
	private void CheckForwardRefs() { }

	// RVA: 0x1C7B710 Offset: 0x1C79D10 VA: 0x181C7B710
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x1C7B780 Offset: 0x1C79D80 VA: 0x181C7B780
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0x1C7B7B0 Offset: 0x1C79DB0 VA: 0x181C7B7B0
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0x1C7B790 Offset: 0x1C79D90 VA: 0x181C7B790
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0x1C70AC0 Offset: 0x1C6F0C0 VA: 0x181C70AC0
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x1C715F0 Offset: 0x1C6FBF0 VA: 0x181C715F0
	private void ClearPSVI() { }

	// RVA: 0x1C708E0 Offset: 0x1C6EEE0 VA: 0x181C708E0
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x1C74260 Offset: 0x1C72860 VA: 0x181C74260
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x1C73FC0 Offset: 0x1C725C0 VA: 0x181C73FC0
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x1C6EEE0 Offset: 0x1C6D4E0 VA: 0x181C6EEE0
	private void AddIdentityConstraints() { }

	// RVA: 0x1C71CA0 Offset: 0x1C702A0 VA: 0x181C71CA0
	private void ElementIdentityConstraints() { }

	// RVA: 0x1C6F920 Offset: 0x1C6DF20 VA: 0x181C6F920
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x1C72A70 Offset: 0x1C71070 VA: 0x181C72A70
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x1C72050 Offset: 0x1C70650 VA: 0x181C72050
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x1C71650 Offset: 0x1C6FC50 VA: 0x181C71650
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x1C76280 Offset: 0x1C74880 VA: 0x181C76280
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x1C76CA0 Offset: 0x1C752A0 VA: 0x181C76CA0
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0x1C766A0 Offset: 0x1C74CA0 VA: 0x181C766A0
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x1C73A00 Offset: 0x1C72000 VA: 0x181C73A00
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x1C77790 Offset: 0x1C75D90 VA: 0x181C77790
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0x1C6FDF0 Offset: 0x1C6E3F0 VA: 0x181C6FDF0
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x1C6FC60 Offset: 0x1C6E260 VA: 0x181C6FC60
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0x1C76E30 Offset: 0x1C75430 VA: 0x181C76E30
	private void ProcessEntity(string name) { }

	// RVA: 0x1C77E20 Offset: 0x1C76420 VA: 0x181C77E20
	private void SendValidationEvent(string code) { }

	// RVA: 0x1C77F40 Offset: 0x1C76540 VA: 0x181C77F40
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x1C77E40 Offset: 0x1C76440 VA: 0x181C77E40
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0x1C77AB0 Offset: 0x1C760B0 VA: 0x181C77AB0
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x1C78150 Offset: 0x1C76750 VA: 0x181C78150
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x1C77990 Offset: 0x1C75F90 VA: 0x181C77990
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x1C77980 Offset: 0x1C75F80 VA: 0x181C77980
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x1C78060 Offset: 0x1C76660 VA: 0x181C78060
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1C782A0 Offset: 0x1C768A0 VA: 0x181C782A0
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x1C77C20 Offset: 0x1C76220 VA: 0x181C77C20
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x1C77D60 Offset: 0x1C76360 VA: 0x181C77D60
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x1C7ADF0 Offset: 0x1C793F0 VA: 0x181C7ADF0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaValidity // TypeDefIndex: 7146
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidity NotKnown = 0;
	public const XmlSchemaValidity Valid = 1;
	public const XmlSchemaValidity Invalid = 2;
}

// Namespace: System.Xml.Schema
public enum XmlSeverityType // TypeDefIndex: 7147
{
	// Fields
	public int value__; // 0x0
	public const XmlSeverityType Error = 0;
	public const XmlSeverityType Warning = 1;
}

// Namespace: System.Xml.Schema
public enum XmlTypeCode // TypeDefIndex: 7148
{
	// Fields
	public int value__; // 0x0
	public const XmlTypeCode None = 0;
	public const XmlTypeCode Item = 1;
	public const XmlTypeCode Node = 2;
	public const XmlTypeCode Document = 3;
	public const XmlTypeCode Element = 4;
	public const XmlTypeCode Attribute = 5;
	public const XmlTypeCode Namespace = 6;
	public const XmlTypeCode ProcessingInstruction = 7;
	public const XmlTypeCode Comment = 8;
	public const XmlTypeCode Text = 9;
	public const XmlTypeCode AnyAtomicType = 10;
	public const XmlTypeCode UntypedAtomic = 11;
	public const XmlTypeCode String = 12;
	public const XmlTypeCode Boolean = 13;
	public const XmlTypeCode Decimal = 14;
	public const XmlTypeCode Float = 15;
	public const XmlTypeCode Double = 16;
	public const XmlTypeCode Duration = 17;
	public const XmlTypeCode DateTime = 18;
	public const XmlTypeCode Time = 19;
	public const XmlTypeCode Date = 20;
	public const XmlTypeCode GYearMonth = 21;
	public const XmlTypeCode GYear = 22;
	public const XmlTypeCode GMonthDay = 23;
	public const XmlTypeCode GDay = 24;
	public const XmlTypeCode GMonth = 25;
	public const XmlTypeCode HexBinary = 26;
	public const XmlTypeCode Base64Binary = 27;
	public const XmlTypeCode AnyUri = 28;
	public const XmlTypeCode QName = 29;
	public const XmlTypeCode Notation = 30;
	public const XmlTypeCode NormalizedString = 31;
	public const XmlTypeCode Token = 32;
	public const XmlTypeCode Language = 33;
	public const XmlTypeCode NmToken = 34;
	public const XmlTypeCode Name = 35;
	public const XmlTypeCode NCName = 36;
	public const XmlTypeCode Id = 37;
	public const XmlTypeCode Idref = 38;
	public const XmlTypeCode Entity = 39;
	public const XmlTypeCode Integer = 40;
	public const XmlTypeCode NonPositiveInteger = 41;
	public const XmlTypeCode NegativeInteger = 42;
	public const XmlTypeCode Long = 43;
	public const XmlTypeCode Int = 44;
	public const XmlTypeCode Short = 45;
	public const XmlTypeCode Byte = 46;
	public const XmlTypeCode NonNegativeInteger = 47;
	public const XmlTypeCode UnsignedLong = 48;
	public const XmlTypeCode UnsignedInt = 49;
	public const XmlTypeCode UnsignedShort = 50;
	public const XmlTypeCode UnsignedByte = 51;
	public const XmlTypeCode PositiveInteger = 52;
	public const XmlTypeCode YearMonthDuration = 53;
	public const XmlTypeCode DayTimeDuration = 54;
}

// Namespace: System.Xml.Schema
internal abstract class XmlValueConverter // TypeDefIndex: 7149
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ToBoolean(long value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool ToBoolean(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool ToBoolean(double value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ToBoolean(DateTime value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool ToBoolean(string value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int ToInt32(bool value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int ToInt32(long value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int ToInt32(double value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int ToInt32(DateTime value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int ToInt32(string value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract long ToInt64(bool value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract long ToInt64(int value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract long ToInt64(double value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract long ToInt64(DateTime value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract long ToInt64(string value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Decimal ToDecimal(string value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract Decimal ToDecimal(object value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract double ToDouble(bool value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract double ToDouble(int value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract double ToDouble(long value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract double ToDouble(DateTime value);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract double ToDouble(string value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract double ToDouble(object value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract float ToSingle(double value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract float ToSingle(string value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract DateTime ToDateTime(bool value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract DateTime ToDateTime(int value);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract DateTime ToDateTime(long value);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract DateTime ToDateTime(double value);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract DateTime ToDateTime(DateTimeOffset value);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract DateTime ToDateTime(string value);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract DateTime ToDateTime(object value);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract DateTimeOffset ToDateTimeOffset(string value);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract DateTimeOffset ToDateTimeOffset(object value);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract string ToString(bool value);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract string ToString(int value);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract string ToString(long value);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract string ToString(Decimal value);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract string ToString(float value);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract string ToString(double value);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract string ToString(DateTime value);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract string ToString(DateTimeOffset value);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract string ToString(object value);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

	// RVA: -1 Offset: -1 Slot: 53
	public abstract object ChangeType(bool value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 54
	public abstract object ChangeType(int value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 55
	public abstract object ChangeType(long value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract object ChangeType(Decimal value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract object ChangeType(double value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 58
	public abstract object ChangeType(DateTime value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract object ChangeType(object value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 61
	public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class XmlBaseConverter : XmlValueConverter // TypeDefIndex: 7150
{
	// Fields
	private XmlSchemaType schemaType; // 0x10
	private XmlTypeCode typeCode; // 0x18
	private Type clrTypeDefault; // 0x20
	protected static readonly Type ICollectionType; // 0x0
	protected static readonly Type IEnumerableType; // 0x8
	protected static readonly Type IListType; // 0x10
	protected static readonly Type ObjectArrayType; // 0x18
	protected static readonly Type StringArrayType; // 0x20
	protected static readonly Type XmlAtomicValueArrayType; // 0x28
	protected static readonly Type DecimalType; // 0x30
	protected static readonly Type Int32Type; // 0x38
	protected static readonly Type Int64Type; // 0x40
	protected static readonly Type StringType; // 0x48
	protected static readonly Type XmlAtomicValueType; // 0x50
	protected static readonly Type ObjectType; // 0x58
	protected static readonly Type ByteType; // 0x60
	protected static readonly Type Int16Type; // 0x68
	protected static readonly Type SByteType; // 0x70
	protected static readonly Type UInt16Type; // 0x78
	protected static readonly Type UInt32Type; // 0x80
	protected static readonly Type UInt64Type; // 0x88
	protected static readonly Type XPathItemType; // 0x90
	protected static readonly Type DoubleType; // 0x98
	protected static readonly Type SingleType; // 0xA0
	protected static readonly Type DateTimeType; // 0xA8
	protected static readonly Type DateTimeOffsetType; // 0xB0
	protected static readonly Type BooleanType; // 0xB8
	protected static readonly Type ByteArrayType; // 0xC0
	protected static readonly Type XmlQualifiedNameType; // 0xC8
	protected static readonly Type UriType; // 0xD0
	protected static readonly Type TimeSpanType; // 0xD8
	protected static readonly Type XPathNavigatorType; // 0xE0

	// Properties
	protected XmlSchemaType SchemaType { get; }
	protected XmlTypeCode TypeCode { get; }
	protected string XmlTypeName { get; }
	protected Type DefaultClrType { get; }

	// Methods

	// RVA: 0x1C62820 Offset: 0x1C60E20 VA: 0x181C62820
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1C62730 Offset: 0x1C60D30 VA: 0x181C62730
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1C62A10 Offset: 0x1C61010 VA: 0x181C62A10
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x1C626D0 Offset: 0x1C60CD0 VA: 0x181C626D0
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x1C5F820 Offset: 0x1C5DE20 VA: 0x181C5F820 Slot: 7
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x1C5F740 Offset: 0x1C5DD40 VA: 0x181C5F740 Slot: 6
	public override bool ToBoolean(double value) { }

	// RVA: 0x1C5F5B0 Offset: 0x1C5DBB0 VA: 0x181C5F5B0 Slot: 5
	public override bool ToBoolean(int value) { }

	// RVA: 0x1C5F9C0 Offset: 0x1C5DFC0 VA: 0x181C5F9C0 Slot: 4
	public override bool ToBoolean(long value) { }

	// RVA: 0x1C5F680 Offset: 0x1C5DC80 VA: 0x181C5F680 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1C5F900 Offset: 0x1C5DF00 VA: 0x181C5F900 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1C600D0 Offset: 0x1C5E6D0 VA: 0x181C600D0 Slot: 33
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x1C60280 Offset: 0x1C5E880 VA: 0x181C60280 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1C5FD50 Offset: 0x1C5E350 VA: 0x181C5FD50 Slot: 36
	public override DateTime ToDateTime(double value) { }

	// RVA: 0x1C5FFF0 Offset: 0x1C5E5F0 VA: 0x181C5FFF0 Slot: 34
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x1C5FE40 Offset: 0x1C5E440 VA: 0x181C5FE40 Slot: 35
	public override DateTime ToDateTime(long value) { }

	// RVA: 0x1C601B0 Offset: 0x1C5E7B0 VA: 0x181C601B0 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1C5FF20 Offset: 0x1C5E520 VA: 0x181C5FF20 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1C5FB70 Offset: 0x1C5E170 VA: 0x181C5FB70 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1C5FA90 Offset: 0x1C5E090 VA: 0x181C5FA90 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1C5FC70 Offset: 0x1C5E270 VA: 0x181C5FC70 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1C60450 Offset: 0x1C5EA50 VA: 0x181C60450 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1C60370 Offset: 0x1C5E970 VA: 0x181C60370 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1C606D0 Offset: 0x1C5ECD0 VA: 0x181C606D0 Slot: 24
	public override double ToDouble(bool value) { }

	// RVA: 0x1C605F0 Offset: 0x1C5EBF0 VA: 0x181C605F0 Slot: 27
	public override double ToDouble(DateTime value) { }

	// RVA: 0x1C60860 Offset: 0x1C5EE60 VA: 0x181C60860 Slot: 25
	public override double ToDouble(int value) { }

	// RVA: 0x1C60930 Offset: 0x1C5EF30 VA: 0x181C60930 Slot: 26
	public override double ToDouble(long value) { }

	// RVA: 0x1C607A0 Offset: 0x1C5EDA0 VA: 0x181C607A0 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1C60530 Offset: 0x1C5EB30 VA: 0x181C60530 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1C60E10 Offset: 0x1C5F410 VA: 0x181C60E10 Slot: 10
	public override int ToInt32(bool value) { }

	// RVA: 0x1C60AC0 Offset: 0x1C5F0C0 VA: 0x181C60AC0 Slot: 13
	public override int ToInt32(DateTime value) { }

	// RVA: 0x1C60D30 Offset: 0x1C5F330 VA: 0x181C60D30 Slot: 12
	public override int ToInt32(double value) { }

	// RVA: 0x1C60C60 Offset: 0x1C5F260 VA: 0x181C60C60 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1C60A00 Offset: 0x1C5F000 VA: 0x181C60A00 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1C60BA0 Offset: 0x1C5F1A0 VA: 0x181C60BA0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1C612F0 Offset: 0x1C5F8F0 VA: 0x181C612F0 Slot: 16
	public override long ToInt64(bool value) { }

	// RVA: 0x1C60FB0 Offset: 0x1C5F5B0 VA: 0x181C60FB0 Slot: 19
	public override long ToInt64(DateTime value) { }

	// RVA: 0x1C61150 Offset: 0x1C5F750 VA: 0x181C61150 Slot: 18
	public override long ToInt64(double value) { }

	// RVA: 0x1C60EE0 Offset: 0x1C5F4E0 VA: 0x181C60EE0 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1C61090 Offset: 0x1C5F690 VA: 0x181C61090 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1C61230 Offset: 0x1C5F830 VA: 0x181C61230 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1C61480 Offset: 0x1C5FA80 VA: 0x181C61480 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1C613C0 Offset: 0x1C5F9C0 VA: 0x181C613C0 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1C61560 Offset: 0x1C5FB60 VA: 0x181C61560 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1C61C90 Offset: 0x1C60290 VA: 0x181C61C90 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1C61940 Offset: 0x1C5FF40 VA: 0x181C61940 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1C616E0 Offset: 0x1C5FCE0 VA: 0x181C616E0 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1C61870 Offset: 0x1C5FE70 VA: 0x181C61870 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1C61A10 Offset: 0x1C60010 VA: 0x181C61A10 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1C61620 Offset: 0x1C5FC20 VA: 0x181C61620 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1C61BB0 Offset: 0x1C601B0 VA: 0x181C61BB0 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1C61AE0 Offset: 0x1C600E0 VA: 0x181C61AE0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1C617B0 Offset: 0x1C5FDB0 VA: 0x181C617B0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C61C70 Offset: 0x1C60270 VA: 0x181C61C70 Slot: 51
	public override string ToString(object value) { }

	// RVA: 0x1C5CAC0 Offset: 0x1C5B0C0 VA: 0x181C5CAC0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1C5CBE0 Offset: 0x1C5B1E0 VA: 0x181C5CBE0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1C5C9D0 Offset: 0x1C5AFD0 VA: 0x181C5C9D0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1C5CB80 Offset: 0x1C5B180 VA: 0x181C5CB80 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1C5CA60 Offset: 0x1C5B060 VA: 0x181C5CA60 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1C5CB20 Offset: 0x1C5B120 VA: 0x181C5CB20 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1C5C9B0 Offset: 0x1C5AFB0 VA: 0x181C5C9B0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C5C980 Offset: 0x1C5AF80 VA: 0x181C5C980 Slot: 60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x1C62A80 Offset: 0x1C61080 VA: 0x181C62A80
	protected string get_XmlTypeName() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	protected Type get_DefaultClrType() { }

	// RVA: 0x1C5E340 Offset: 0x1C5C940 VA: 0x181C5E340
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x1C5CC60 Offset: 0x1C5B260 VA: 0x181C5CC60
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x1C5E3E0 Offset: 0x1C5C9E0 VA: 0x181C5E3E0
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x1C5C920 Offset: 0x1C5AF20 VA: 0x181C5C920 Slot: 62
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C5E6E0 Offset: 0x1C5CCE0 VA: 0x181C5E6E0
	protected static byte[] StringToBase64Binary(string value) { }

	// RVA: 0x1C5E900 Offset: 0x1C5CF00 VA: 0x181C5E900
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x1C5E880 Offset: 0x1C5CE80 VA: 0x181C5E880
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x1C5E980 Offset: 0x1C5CF80 VA: 0x181C5E980
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x1C5E9E0 Offset: 0x1C5CFE0 VA: 0x181C5E9E0
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x1C5EAD0 Offset: 0x1C5D0D0 VA: 0x181C5EAD0
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x1C5ECF0 Offset: 0x1C5D2F0 VA: 0x181C5ECF0
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x1C5EBE0 Offset: 0x1C5D1E0 VA: 0x181C5EBE0
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x1C5EF10 Offset: 0x1C5D510 VA: 0x181C5EF10
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x1C5EE00 Offset: 0x1C5D400 VA: 0x181C5EE00
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x1C5E760 Offset: 0x1C5CD60 VA: 0x181C5E760
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x1C5E7F0 Offset: 0x1C5CDF0 VA: 0x181C5E7F0
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x1C5EA40 Offset: 0x1C5D040 VA: 0x181C5EA40
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x1C5EC60 Offset: 0x1C5D260 VA: 0x181C5EC60
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x1C5EB50 Offset: 0x1C5D150 VA: 0x181C5EB50
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x1C5EE80 Offset: 0x1C5D480 VA: 0x181C5EE80
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x1C5ED70 Offset: 0x1C5D370 VA: 0x181C5ED70
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x1C5EF90 Offset: 0x1C5D590 VA: 0x181C5EF90
	protected static byte[] StringToHexBinary(string value) { }

	// RVA: 0x1C5F060 Offset: 0x1C5D660 VA: 0x181C5F060
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C5F3D0 Offset: 0x1C5D9D0 VA: 0x181C5F3D0
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x1C5F340 Offset: 0x1C5D940 VA: 0x181C5F340
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x1C5F450 Offset: 0x1C5DA50 VA: 0x181C5F450
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x1C5C8B0 Offset: 0x1C5AEB0 VA: 0x181C5C8B0
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x1C5C8D0 Offset: 0x1C5AED0 VA: 0x181C5C8D0
	protected static string Base64BinaryToString(byte[] value) { }

	// RVA: 0x1C5D130 Offset: 0x1C5B730 VA: 0x181C5D130
	protected static string DateToString(DateTime value) { }

	// RVA: 0x1C5D0B0 Offset: 0x1C5B6B0 VA: 0x181C5D0B0
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x1C5D1B0 Offset: 0x1C5B7B0 VA: 0x181C5D1B0
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x1C5D7E0 Offset: 0x1C5BDE0 VA: 0x181C5D7E0
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x1C5D8C0 Offset: 0x1C5BEC0 VA: 0x181C5D8C0
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x1C5DAC0 Offset: 0x1C5C0C0 VA: 0x181C5DAC0
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x1C5D9C0 Offset: 0x1C5BFC0 VA: 0x181C5D9C0
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x1C5DCC0 Offset: 0x1C5C2C0 VA: 0x181C5DCC0
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x1C5DBC0 Offset: 0x1C5C1C0 VA: 0x181C5DBC0
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x1C5CF60 Offset: 0x1C5B560 VA: 0x181C5CF60
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1C5D030 Offset: 0x1C5B630 VA: 0x181C5D030
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1C5D840 Offset: 0x1C5BE40 VA: 0x181C5D840
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1C5DA40 Offset: 0x1C5C040 VA: 0x181C5DA40
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1C5D940 Offset: 0x1C5BF40 VA: 0x181C5D940
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1C5DC40 Offset: 0x1C5C240 VA: 0x181C5DC40
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1C5DB40 Offset: 0x1C5C140 VA: 0x181C5DB40
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1C5E500 Offset: 0x1C5CB00 VA: 0x181C5E500
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C5F530 Offset: 0x1C5DB30 VA: 0x181C5F530
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x1C5F4B0 Offset: 0x1C5DAB0 VA: 0x181C5F4B0
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1C61E60 Offset: 0x1C60460 VA: 0x181C61E60
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x1C5CFE0 Offset: 0x1C5B5E0 VA: 0x181C5CFE0
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x1C5D210 Offset: 0x1C5B810 VA: 0x181C5D210
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x1C5D400 Offset: 0x1C5BA00 VA: 0x181C5D400
	protected static long DecimalToInt64(Decimal value) { }

	// RVA: 0x1C5D600 Offset: 0x1C5BC00 VA: 0x181C5D600
	protected static ulong DecimalToUInt64(Decimal value) { }

	// RVA: 0x1C5DD40 Offset: 0x1C5C340 VA: 0x181C5DD40
	protected static byte Int32ToByte(int value) { }

	// RVA: 0x1C5DE40 Offset: 0x1C5C440 VA: 0x181C5DE40
	protected static short Int32ToInt16(int value) { }

	// RVA: 0x1C5DF40 Offset: 0x1C5C540 VA: 0x181C5DF40
	protected static sbyte Int32ToSByte(int value) { }

	// RVA: 0x1C5E040 Offset: 0x1C5C640 VA: 0x181C5E040
	protected static ushort Int32ToUInt16(int value) { }

	// RVA: 0x1C5E140 Offset: 0x1C5C740 VA: 0x181C5E140
	protected static int Int64ToInt32(long value) { }

	// RVA: 0x1C5E240 Offset: 0x1C5C840 VA: 0x181C5E240
	protected static uint Int64ToUInt32(long value) { }

	// RVA: 0x1C61DE0 Offset: 0x1C603E0 VA: 0x181C61DE0
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x1C61D50 Offset: 0x1C60350 VA: 0x181C61D50
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x1C61EC0 Offset: 0x1C604C0 VA: 0x181C61EC0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 7151
{
	// Methods

	// RVA: 0x1C8B9E0 Offset: 0x1C89FE0 VA: 0x181C8B9E0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1C8A340 Offset: 0x1C88940 VA: 0x181C8A340
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1C8A860 Offset: 0x1C88E60 VA: 0x181C8A860 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1C8A3D0 Offset: 0x1C889D0 VA: 0x181C8A3D0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1C8A950 Offset: 0x1C88F50 VA: 0x181C8A950 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1C8A9A0 Offset: 0x1C88FA0 VA: 0x181C8A9A0 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1C8AAC0 Offset: 0x1C890C0 VA: 0x181C8AAC0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1C8B420 Offset: 0x1C89A20 VA: 0x181C8B420 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1C8AEF0 Offset: 0x1C894F0 VA: 0x181C8AEF0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1C8B010 Offset: 0x1C89610 VA: 0x181C8B010 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1C8B900 Offset: 0x1C89F00 VA: 0x181C8B900 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1C8B8B0 Offset: 0x1C89EB0 VA: 0x181C8B8B0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1C8B430 Offset: 0x1C89A30 VA: 0x181C8B430 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1C8B480 Offset: 0x1C89A80 VA: 0x181C8B480 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C89EA0 Offset: 0x1C884A0 VA: 0x181C89EA0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1C89A80 Offset: 0x1C88080 VA: 0x181C89A80 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1C891E0 Offset: 0x1C877E0 VA: 0x181C891E0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1C89620 Offset: 0x1C87C20 VA: 0x181C89620 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C88040 Offset: 0x1C86640 VA: 0x181C88040 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C877B0 Offset: 0x1C85DB0 VA: 0x181C877B0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C87BD0 Offset: 0x1C861D0 VA: 0x181C87BD0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 7152
{
	// Methods

	// RVA: 0x1C8D7C0 Offset: 0x1C8BDC0 VA: 0x181C8D7C0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1C8C9A0 Offset: 0x1C8AFA0 VA: 0x181C8C9A0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1C8CDA0 Offset: 0x1C8B3A0 VA: 0x181C8CDA0 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1C8CA30 Offset: 0x1C8B030 VA: 0x181C8CA30 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1C8CF40 Offset: 0x1C8B540 VA: 0x181C8CF40 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1C8CE70 Offset: 0x1C8B470 VA: 0x181C8CE70 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1C8CF50 Offset: 0x1C8B550 VA: 0x181C8CF50 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1C8D310 Offset: 0x1C8B910 VA: 0x181C8D310 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1C8D730 Offset: 0x1C8BD30 VA: 0x181C8D730 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1C8D3C0 Offset: 0x1C8B9C0 VA: 0x181C8D3C0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C8C620 Offset: 0x1C8AC20 VA: 0x181C8C620 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1C8BA40 Offset: 0x1C8A040 VA: 0x181C8BA40 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C8BE10 Offset: 0x1C8A410 VA: 0x181C8BE10 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 7153
{
	// Methods

	// RVA: 0x1C83570 Offset: 0x1C81B70 VA: 0x181C83570
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1C82130 Offset: 0x1C80730 VA: 0x181C82130
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1C82800 Offset: 0x1C80E00 VA: 0x181C82800 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1C82860 Offset: 0x1C80E60 VA: 0x181C82860 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1C82A70 Offset: 0x1C81070 VA: 0x181C82A70 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1C825A0 Offset: 0x1C80BA0 VA: 0x181C825A0 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1C825D0 Offset: 0x1C80BD0 VA: 0x181C825D0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1C821C0 Offset: 0x1C807C0 VA: 0x181C821C0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1C83020 Offset: 0x1C81620 VA: 0x181C83020 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1C82E10 Offset: 0x1C81410 VA: 0x181C82E10 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1C831E0 Offset: 0x1C817E0 VA: 0x181C831E0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C81D80 Offset: 0x1C80380 VA: 0x181C81D80 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1C810F0 Offset: 0x1C7F6F0 VA: 0x181C810F0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C814E0 Offset: 0x1C7FAE0 VA: 0x181C814E0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 7154
{
	// Methods

	// RVA: 0x1C81090 Offset: 0x1C7F690 VA: 0x181C81090
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1C80940 Offset: 0x1C7EF40 VA: 0x181C80940
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1C80CC0 Offset: 0x1C7F2C0 VA: 0x181C80CC0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1C809D0 Offset: 0x1C7EFD0 VA: 0x181C809D0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1C81040 Offset: 0x1C7F640 VA: 0x181C81040 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1C80D60 Offset: 0x1C7F360 VA: 0x181C80D60 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C7FC20 Offset: 0x1C7E220 VA: 0x181C7FC20 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1C805F0 Offset: 0x1C7EBF0 VA: 0x181C805F0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C7FF40 Offset: 0x1C7E540 VA: 0x181C7FF40 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 7155
{
	// Methods

	// RVA: 0x1C87750 Offset: 0x1C85D50 VA: 0x181C87750
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1C87020 Offset: 0x1C85620 VA: 0x181C87020
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1C870B0 Offset: 0x1C856B0 VA: 0x181C870B0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C859E0 Offset: 0x1C83FE0 VA: 0x181C859E0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C86030 Offset: 0x1C84630 VA: 0x181C86030 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C85710 Offset: 0x1C83D10 VA: 0x181C85710
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C85860 Offset: 0x1C83E60 VA: 0x181C85860
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlStringConverter : XmlBaseConverter // TypeDefIndex: 7156
{
	// Methods

	// RVA: 0x1C8E2A0 Offset: 0x1C8C8A0 VA: 0x181C8E2A0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1C8DFD0 Offset: 0x1C8C5D0 VA: 0x181C8DFD0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1C8E060 Offset: 0x1C8C660 VA: 0x181C8E060 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C8D820 Offset: 0x1C8BE20 VA: 0x181C8D820 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C8DAF0 Offset: 0x1C8C0F0 VA: 0x181C8DAF0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 7157
{
	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0x1C95100 Offset: 0x1C93700 VA: 0x181C95100
	protected void .ctor() { }

	// RVA: 0x1C95000 Offset: 0x1C93600 VA: 0x181C95000
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x1C92B50 Offset: 0x1C91150 VA: 0x181C92B50 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1C92980 Offset: 0x1C90F80 VA: 0x181C92980 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1C92E90 Offset: 0x1C91490 VA: 0x181C92E90 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1C92F30 Offset: 0x1C91530 VA: 0x181C92F30 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1C92DD0 Offset: 0x1C913D0 VA: 0x181C92DD0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1C92BF0 Offset: 0x1C911F0 VA: 0x181C92BF0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1C93100 Offset: 0x1C91700 VA: 0x181C93100 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1C931C0 Offset: 0x1C917C0 VA: 0x181C931C0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1C93580 Offset: 0x1C91B80 VA: 0x181C93580 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1C933B0 Offset: 0x1C919B0 VA: 0x181C933B0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1C93620 Offset: 0x1C91C20 VA: 0x181C93620 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1C936C0 Offset: 0x1C91CC0 VA: 0x181C936C0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1C93A60 Offset: 0x1C92060 VA: 0x181C93A60 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1C93890 Offset: 0x1C91E90 VA: 0x181C93890 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1C93CD0 Offset: 0x1C922D0 VA: 0x181C93CD0 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1C93B00 Offset: 0x1C92100 VA: 0x181C93B00 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1C94C30 Offset: 0x1C93230 VA: 0x181C94C30 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1C94DC0 Offset: 0x1C933C0 VA: 0x181C94DC0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1C94E10 Offset: 0x1C93410 VA: 0x181C94E10 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1C93D70 Offset: 0x1C92370 VA: 0x181C93D70 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1C94C80 Offset: 0x1C93280 VA: 0x181C94C80 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1C94D70 Offset: 0x1C93370 VA: 0x181C94D70 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1C94D20 Offset: 0x1C93320 VA: 0x181C94D20 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1C94CD0 Offset: 0x1C932D0 VA: 0x181C94CD0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1C93DD0 Offset: 0x1C923D0 VA: 0x181C93DD0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C8F4A0 Offset: 0x1C8DAA0 VA: 0x181C8F4A0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1C90410 Offset: 0x1C8EA10 VA: 0x181C90410 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1C907C0 Offset: 0x1C8EDC0 VA: 0x181C907C0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1C8F2C0 Offset: 0x1C8D8C0 VA: 0x181C8F2C0 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1C905F0 Offset: 0x1C8EBF0 VA: 0x181C905F0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1C8F0E0 Offset: 0x1C8D6E0 VA: 0x181C8F0E0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1C8F680 Offset: 0x1C8DC80 VA: 0x181C8F680 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C909B0 Offset: 0x1C8EFB0 VA: 0x181C909B0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C8EE10 Offset: 0x1C8D410 VA: 0x181C8EE10
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C8EF60 Offset: 0x1C8D560 VA: 0x181C8EF60
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C8EAB0 Offset: 0x1C8D0B0 VA: 0x181C8EAB0 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C92320 Offset: 0x1C90920 VA: 0x181C92320
	private bool SupportsType(Type clrType) { }

	// RVA: 0x1C94E70 Offset: 0x1C93470 VA: 0x181C94E70
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 7158
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x1C7F680 Offset: 0x1C7DC80 VA: 0x181C7F680
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1C7E520 Offset: 0x1C7CB20 VA: 0x181C7E520 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1C7E930 Offset: 0x1C7CF30 VA: 0x181C7E930 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1C7E6F0 Offset: 0x1C7CCF0 VA: 0x181C7E6F0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1C7EB10 Offset: 0x1C7D110 VA: 0x181C7EB10 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1C7ED40 Offset: 0x1C7D340 VA: 0x181C7ED40 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1C7EF10 Offset: 0x1C7D510 VA: 0x181C7EF10 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1C7F0E0 Offset: 0x1C7D6E0 VA: 0x181C7F0E0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1C7F350 Offset: 0x1C7D950 VA: 0x181C7F350 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1C7C230 Offset: 0x1C7A830 VA: 0x181C7C230 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1C7C420 Offset: 0x1C7AA20 VA: 0x181C7C420 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1C7BC10 Offset: 0x1C7A210 VA: 0x181C7BC10 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1C7E330 Offset: 0x1C7C930 VA: 0x181C7E330 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1C7C610 Offset: 0x1C7AC10 VA: 0x181C7C610 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1C7BE20 Offset: 0x1C7A420 VA: 0x181C7BE20 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1C7C010 Offset: 0x1C7A610 VA: 0x181C7C010 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C7C800 Offset: 0x1C7AE00 VA: 0x181C7C800 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C7B940 Offset: 0x1C79F40 VA: 0x181C7B940
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C7BA90 Offset: 0x1C7A090 VA: 0x181C7BA90
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C7F2B0 Offset: 0x1C7D8B0 VA: 0x181C7F2B0
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x1C7F560 Offset: 0x1C7DB60 VA: 0x181C7F560
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlAnyListConverter : XmlListConverter // TypeDefIndex: 7159
{
	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x1C7FBB0 Offset: 0x1C7E1B0 VA: 0x181C7FBB0
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x1C7F6E0 Offset: 0x1C7DCE0 VA: 0x181C7F6E0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C7F980 Offset: 0x1C7DF80 VA: 0x181C7F980
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 7160
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x1C7FBB0 Offset: 0x1C7E1B0 VA: 0x181C7FBB0
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x1C85630 Offset: 0x1C83C30 VA: 0x181C85630
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x1C856B0 Offset: 0x1C83CB0 VA: 0x181C856B0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1C84A40 Offset: 0x1C83040 VA: 0x181C84A40
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x1C84620 Offset: 0x1C82C20 VA: 0x181C84620 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C835D0 Offset: 0x1C81BD0 VA: 0x181C835D0 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C84C10 Offset: 0x1C83210 VA: 0x181C84C10
	private bool IsListType(Type type) { }

	// RVA: -1 Offset: -1
	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x815590 Offset: 0x813B90 VA: 0x180815590
	|-XmlListConverter.ToArray<bool>
	|-XmlListConverter.ToArray<byte>
	|-XmlListConverter.ToArray<sbyte>
	|
	|-RVA: 0x816120 Offset: 0x814720 VA: 0x180816120
	|-XmlListConverter.ToArray<DateTime>
	|-XmlListConverter.ToArray<TimeSpan>
	|
	|-RVA: 0x815B50 Offset: 0x814150 VA: 0x180815B50
	|-XmlListConverter.ToArray<DateTimeOffset>
	|-XmlListConverter.ToArray<Decimal>
	|
	|-RVA: 0x8166E0 Offset: 0x814CE0 VA: 0x1808166E0
	|-XmlListConverter.ToArray<double>
	|
	|-RVA: 0x817280 Offset: 0x815880 VA: 0x180817280
	|-XmlListConverter.ToArray<short>
	|-XmlListConverter.ToArray<ushort>
	|
	|-RVA: 0x817840 Offset: 0x815E40 VA: 0x180817840
	|-XmlListConverter.ToArray<int>
	|-XmlListConverter.ToArray<uint>
	|
	|-RVA: 0x817E00 Offset: 0x816400 VA: 0x180817E00
	|-XmlListConverter.ToArray<long>
	|-XmlListConverter.ToArray<ulong>
	|
	|-RVA: 0x8183C0 Offset: 0x8169C0 VA: 0x1808183C0
	|-XmlListConverter.ToArray<object>
	|
	|-RVA: 0x818990 Offset: 0x816F90 VA: 0x180818990
	|-XmlListConverter.ToArray<float>
	|
	|-RVA: 0x816CA0 Offset: 0x8152A0 VA: 0x180816CA0
	|-XmlListConverter.ToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C85100 Offset: 0x1C83700 VA: 0x181C85100
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C85060 Offset: 0x1C83660 VA: 0x181C85060
	private List<string> StringAsList(string value) { }

	// RVA: 0x1C84DB0 Offset: 0x1C833B0 VA: 0x181C84DB0
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C84740 Offset: 0x1C82D40 VA: 0x181C84740
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }
}

// Namespace: System.Xml.Schema
internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 7161
{
	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0x1C8E810 Offset: 0x1C8CE10 VA: 0x181C8E810
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1C8E7B0 Offset: 0x1C8CDB0 VA: 0x181C8E7B0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1C8E300 Offset: 0x1C8C900 VA: 0x181C8E300 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal sealed class XsdBuilder : SchemaBuilder // TypeDefIndex: 7169
{
	// Fields
	private static readonly XsdBuilder.State[] SchemaElement; // 0x0
	private static readonly XsdBuilder.State[] SchemaSubelements; // 0x8
	private static readonly XsdBuilder.State[] AttributeSubelements; // 0x10
	private static readonly XsdBuilder.State[] ElementSubelements; // 0x18
	private static readonly XsdBuilder.State[] ComplexTypeSubelements; // 0x20
	private static readonly XsdBuilder.State[] SimpleContentSubelements; // 0x28
	private static readonly XsdBuilder.State[] SimpleContentExtensionSubelements; // 0x30
	private static readonly XsdBuilder.State[] SimpleContentRestrictionSubelements; // 0x38
	private static readonly XsdBuilder.State[] ComplexContentSubelements; // 0x40
	private static readonly XsdBuilder.State[] ComplexContentExtensionSubelements; // 0x48
	private static readonly XsdBuilder.State[] ComplexContentRestrictionSubelements; // 0x50
	private static readonly XsdBuilder.State[] SimpleTypeSubelements; // 0x58
	private static readonly XsdBuilder.State[] SimpleTypeRestrictionSubelements; // 0x60
	private static readonly XsdBuilder.State[] SimpleTypeListSubelements; // 0x68
	private static readonly XsdBuilder.State[] SimpleTypeUnionSubelements; // 0x70
	private static readonly XsdBuilder.State[] RedefineSubelements; // 0x78
	private static readonly XsdBuilder.State[] AttributeGroupSubelements; // 0x80
	private static readonly XsdBuilder.State[] GroupSubelements; // 0x88
	private static readonly XsdBuilder.State[] AllSubelements; // 0x90
	private static readonly XsdBuilder.State[] ChoiceSequenceSubelements; // 0x98
	private static readonly XsdBuilder.State[] IdentityConstraintSubelements; // 0xA0
	private static readonly XsdBuilder.State[] AnnotationSubelements; // 0xA8
	private static readonly XsdBuilder.State[] AnnotatedSubelements; // 0xB0
	private static readonly XsdBuilder.XsdAttributeEntry[] SchemaAttributes; // 0xB8
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeAttributes; // 0xC0
	private static readonly XsdBuilder.XsdAttributeEntry[] ElementAttributes; // 0xC8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes; // 0xD0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes; // 0xD8
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes; // 0xE0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes; // 0xE8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes; // 0xF0
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes; // 0xF8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes; // 0x100
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes; // 0x108
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes; // 0x110
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes; // 0x118
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes; // 0x120
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes; // 0x128
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes; // 0x130
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupAttributes; // 0x138
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupRefAttributes; // 0x140
	private static readonly XsdBuilder.XsdAttributeEntry[] ParticleAttributes; // 0x148
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributes; // 0x150
	private static readonly XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes; // 0x158
	private static readonly XsdBuilder.XsdAttributeEntry[] SelectorAttributes; // 0x160
	private static readonly XsdBuilder.XsdAttributeEntry[] FieldAttributes; // 0x168
	private static readonly XsdBuilder.XsdAttributeEntry[] NotationAttributes; // 0x170
	private static readonly XsdBuilder.XsdAttributeEntry[] IncludeAttributes; // 0x178
	private static readonly XsdBuilder.XsdAttributeEntry[] ImportAttributes; // 0x180
	private static readonly XsdBuilder.XsdAttributeEntry[] FacetAttributes; // 0x188
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes; // 0x190
	private static readonly XsdBuilder.XsdAttributeEntry[] DocumentationAttributes; // 0x198
	private static readonly XsdBuilder.XsdAttributeEntry[] AppinfoAttributes; // 0x1A0
	private static readonly XsdBuilder.XsdAttributeEntry[] RedefineAttributes; // 0x1A8
	private static readonly XsdBuilder.XsdAttributeEntry[] AnnotationAttributes; // 0x1B0
	private static readonly XsdBuilder.XsdEntry[] SchemaEntries; // 0x1B8
	private static readonly int[] DerivationMethodValues; // 0x1C0
	private static readonly string[] DerivationMethodStrings; // 0x1C8
	private static readonly string[] FormStringValues; // 0x1D0
	private static readonly string[] UseStringValues; // 0x1D8
	private static readonly string[] ProcessContentsStringValues; // 0x1E0
	private XmlReader reader; // 0x10
	private PositionInfo positionInfo; // 0x18
	private XsdBuilder.XsdEntry currentEntry; // 0x20
	private XsdBuilder.XsdEntry nextEntry; // 0x28
	private bool hasChild; // 0x30
	private HWStack stateHistory; // 0x38
	private Stack containerStack; // 0x40
	private XmlNameTable nameTable; // 0x48
	private SchemaNames schemaNames; // 0x50
	private XmlNamespaceManager namespaceManager; // 0x58
	private bool canIncludeImport; // 0x60
	private XmlSchema schema; // 0x68
	private XmlSchemaObject xso; // 0x70
	private XmlSchemaElement element; // 0x78
	private XmlSchemaAny anyElement; // 0x80
	private XmlSchemaAttribute attribute; // 0x88
	private XmlSchemaAnyAttribute anyAttribute; // 0x90
	private XmlSchemaComplexType complexType; // 0x98
	private XmlSchemaSimpleType simpleType; // 0xA0
	private XmlSchemaComplexContent complexContent; // 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; // 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; // 0xB8
	private XmlSchemaSimpleContent simpleContent; // 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; // 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; // 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; // 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; // 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; // 0xE8
	private XmlSchemaGroup group; // 0xF0
	private XmlSchemaGroupRef groupRef; // 0xF8
	private XmlSchemaAll all; // 0x100
	private XmlSchemaChoice choice; // 0x108
	private XmlSchemaSequence sequence; // 0x110
	private XmlSchemaParticle particle; // 0x118
	private XmlSchemaAttributeGroup attributeGroup; // 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; // 0x128
	private XmlSchemaNotation notation; // 0x130
	private XmlSchemaIdentityConstraint identityConstraint; // 0x138
	private XmlSchemaXPath xpath; // 0x140
	private XmlSchemaInclude include; // 0x148
	private XmlSchemaImport import; // 0x150
	private XmlSchemaAnnotation annotation; // 0x158
	private XmlSchemaAppInfo appInfo; // 0x160
	private XmlSchemaDocumentation documentation; // 0x168
	private XmlSchemaFacet facet; // 0x170
	private XmlNode[] markup; // 0x178
	private XmlSchemaRedefine redefine; // 0x180
	private ValidationEventHandler validationEventHandler; // 0x188
	private ArrayList unhandledAttributes; // 0x190
	private Hashtable namespaces; // 0x198

	// Properties
	private SchemaNames.Token CurrentElement { get; }
	private SchemaNames.Token ParentElement { get; }
	private XmlSchemaObject ParentContainer { get; }

	// Methods

	// RVA: 0x1CA2DD0 Offset: 0x1CA13D0 VA: 0x181CA2DD0
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x1C9AAC0 Offset: 0x1C990C0 VA: 0x181C9AAC0 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x1C9A590 Offset: 0x1C98B90 VA: 0x181C9A590 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x1C99F60 Offset: 0x1C98560 VA: 0x181C99F60 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x1C9ACB0 Offset: 0x1C992B0 VA: 0x181C9ACB0 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x1C9AA70 Offset: 0x1C99070 VA: 0x181C9AA70 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x1C9CD00 Offset: 0x1C9B300 VA: 0x181C9CD00 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x1C97420 Offset: 0x1C95A20 VA: 0x181C97420 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x1C9ACD0 Offset: 0x1C992D0 VA: 0x181C9ACD0
	private void Push() { }

	// RVA: 0x1C9A4A0 Offset: 0x1C98AA0 VA: 0x181C9A4A0
	private void Pop() { }

	// RVA: 0x136B350 Offset: 0x1369950 VA: 0x18136B350
	private SchemaNames.Token get_CurrentElement() { }

	// RVA: 0x1CA30D0 Offset: 0x1CA16D0 VA: 0x181CA30D0
	private SchemaNames.Token get_ParentElement() { }

	// RVA: 0x1CA3030 Offset: 0x1CA1630 VA: 0x181CA3030
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x1C97590 Offset: 0x1C95B90 VA: 0x181C97590
	private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

	// RVA: 0x1C9B560 Offset: 0x1C99B60 VA: 0x181C9B560
	private void SetContainer(XsdBuilder.State state, object container) { }

	// RVA: 0x1C957D0 Offset: 0x1C93DD0 VA: 0x181C957D0
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x1C96CE0 Offset: 0x1C952E0 VA: 0x181C96CE0
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1C96E00 Offset: 0x1C95400 VA: 0x181C96E00
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1C96F20 Offset: 0x1C95520 VA: 0x181C96F20
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x1C96F50 Offset: 0x1C95550 VA: 0x181C96F50
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x1C96EB0 Offset: 0x1C954B0 VA: 0x181C96EB0
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1C96D90 Offset: 0x1C95390 VA: 0x181C96D90
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1C993E0 Offset: 0x1C979E0 VA: 0x181C993E0
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x1C99190 Offset: 0x1C97790 VA: 0x181C99190
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x1C96B90 Offset: 0x1C95190 VA: 0x181C96B90
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1C990C0 Offset: 0x1C976C0 VA: 0x181C990C0
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x1C96B30 Offset: 0x1C95130 VA: 0x181C96B30
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1C96B60 Offset: 0x1C95160 VA: 0x181C96B60
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1C99310 Offset: 0x1C97910 VA: 0x181C99310
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x1C96CB0 Offset: 0x1C952B0 VA: 0x181C96CB0
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1C97570 Offset: 0x1C95B70 VA: 0x181C97570
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x1C98170 Offset: 0x1C96770 VA: 0x181C98170
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x1C95B00 Offset: 0x1C94100 VA: 0x181C95B00
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x1C95B30 Offset: 0x1C94130 VA: 0x181C95B30
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1C95B60 Offset: 0x1C94160 VA: 0x181C95B60
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x1C95D40 Offset: 0x1C94340 VA: 0x181C95D40
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x1C95C40 Offset: 0x1C94240 VA: 0x181C95C40
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1C95C10 Offset: 0x1C94210 VA: 0x181C95C10
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C95CC0 Offset: 0x1C942C0 VA: 0x181C95CC0
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x1C98870 Offset: 0x1C96E70 VA: 0x181C98870
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x1C96320 Offset: 0x1C94920 VA: 0x181C96320
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x1C963A0 Offset: 0x1C949A0 VA: 0x181C963A0
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x1C96410 Offset: 0x1C94A10 VA: 0x181C96410
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x1C964E0 Offset: 0x1C94AE0 VA: 0x181C964E0
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x1C96720 Offset: 0x1C94D20 VA: 0x181C96720
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1C96440 Offset: 0x1C94A40 VA: 0x181C96440
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1C964B0 Offset: 0x1C94AB0 VA: 0x181C964B0
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1C96590 Offset: 0x1C94B90 VA: 0x181C96590
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1C965C0 Offset: 0x1C94BC0 VA: 0x181C965C0
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1C965F0 Offset: 0x1C94BF0 VA: 0x181C965F0
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C96620 Offset: 0x1C94C20 VA: 0x181C96620
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x1C966A0 Offset: 0x1C94CA0 VA: 0x181C966A0
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1C967A0 Offset: 0x1C94DA0 VA: 0x181C967A0
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x1C99BB0 Offset: 0x1C981B0 VA: 0x181C99BB0
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x1C973B0 Offset: 0x1C959B0 VA: 0x181C973B0
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C97340 Offset: 0x1C95940 VA: 0x181C97340
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1C99AC0 Offset: 0x1C980C0 VA: 0x181C99AC0
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x1C97180 Offset: 0x1C95780 VA: 0x181C97180
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x1C998E0 Offset: 0x1C97EE0 VA: 0x181C998E0
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x1C97080 Offset: 0x1C95680 VA: 0x181C97080
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x1C999D0 Offset: 0x1C97FD0 VA: 0x181C999D0
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1C97100 Offset: 0x1C95700 VA: 0x181C97100
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1C985F0 Offset: 0x1C96BF0 VA: 0x181C985F0
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x1C95F70 Offset: 0x1C94570 VA: 0x181C95F70
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x1C95FF0 Offset: 0x1C945F0 VA: 0x181C95FF0
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x1C96070 Offset: 0x1C94670 VA: 0x181C96070
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1C960E0 Offset: 0x1C946E0 VA: 0x181C960E0
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x1C96170 Offset: 0x1C94770 VA: 0x181C96170
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C984B0 Offset: 0x1C96AB0 VA: 0x181C984B0
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x1C95EF0 Offset: 0x1C944F0 VA: 0x181C95EF0
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x1C98300 Offset: 0x1C96900 VA: 0x181C98300
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x1C95DF0 Offset: 0x1C943F0 VA: 0x181C95DF0
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1C98400 Offset: 0x1C96A00 VA: 0x181C98400
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1C95E70 Offset: 0x1C94470 VA: 0x181C95E70
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1C997A0 Offset: 0x1C97DA0 VA: 0x181C997A0
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x1C995A0 Offset: 0x1C97BA0 VA: 0x181C995A0
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x1C96F80 Offset: 0x1C95580 VA: 0x181C96F80
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1C996A0 Offset: 0x1C97CA0 VA: 0x181C996A0
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1C97000 Offset: 0x1C95600 VA: 0x181C97000
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1C98090 Offset: 0x1C96690 VA: 0x181C98090
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1C95AD0 Offset: 0x1C940D0 VA: 0x181C95AD0
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C98000 Offset: 0x1C96600 VA: 0x181C98000
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x1C95A50 Offset: 0x1C94050 VA: 0x181C95A50
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1C97B60 Offset: 0x1C96160 VA: 0x181C97B60
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x1C95800 Offset: 0x1C93E00 VA: 0x181C95800
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1C95830 Offset: 0x1C93E30 VA: 0x181C95830
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x1C98E90 Offset: 0x1C97490 VA: 0x181C98E90
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1C96990 Offset: 0x1C94F90 VA: 0x181C96990
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C98DE0 Offset: 0x1C973E0 VA: 0x181C98DE0
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x1C96C50 Offset: 0x1C95250 VA: 0x181C96C50
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1C96C80 Offset: 0x1C95280 VA: 0x181C96C80
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1C96910 Offset: 0x1C94F10 VA: 0x181C96910
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1C979B0 Offset: 0x1C95FB0 VA: 0x181C979B0
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x1C98250 Offset: 0x1C96850 VA: 0x181C98250
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x1C994F0 Offset: 0x1C97AF0 VA: 0x181C994F0
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x1C97E70 Offset: 0x1C96470 VA: 0x181C97E70
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x1C958E0 Offset: 0x1C93EE0 VA: 0x181C958E0
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1C95910 Offset: 0x1C93F10 VA: 0x181C95910
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x1C99260 Offset: 0x1C97860 VA: 0x181C99260
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x1C96BC0 Offset: 0x1C951C0 VA: 0x181C96BC0
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C96BF0 Offset: 0x1C951F0 VA: 0x181C96BF0
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x1C96C20 Offset: 0x1C95220 VA: 0x181C96C20
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x1C98990 Offset: 0x1C96F90 VA: 0x181C98990
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x1C96820 Offset: 0x1C94E20 VA: 0x181C96820
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1C968B0 Offset: 0x1C94EB0 VA: 0x181C968B0
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x1C98F60 Offset: 0x1C97560 VA: 0x181C98F60
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x1C969C0 Offset: 0x1C94FC0 VA: 0x181C969C0
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C969F0 Offset: 0x1C94FF0 VA: 0x181C969F0
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x1C99410 Offset: 0x1C97A10 VA: 0x181C99410
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x1C968E0 Offset: 0x1C94EE0 VA: 0x181C968E0
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x1C98D00 Offset: 0x1C97300 VA: 0x181C98D00
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x1C968E0 Offset: 0x1C94EE0 VA: 0x181C968E0
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x1C97A60 Offset: 0x1C96060 VA: 0x181C97A60
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x1C97F20 Offset: 0x1C96520 VA: 0x181C97F20
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x1C959D0 Offset: 0x1C93FD0 VA: 0x181C959D0
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x1C973E0 Offset: 0x1C959E0 VA: 0x181C973E0
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x1C98790 Offset: 0x1C96D90 VA: 0x181C98790
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x1C961A0 Offset: 0x1C947A0 VA: 0x181C961A0
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x1C96220 Offset: 0x1C94820 VA: 0x181C96220
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x1C97530 Offset: 0x1C95B30 VA: 0x181C97530
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x1C951D0 Offset: 0x1C937D0 VA: 0x181C951D0
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x1C95440 Offset: 0x1C93A40 VA: 0x181C95440
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1C977E0 Offset: 0x1C95DE0 VA: 0x181C977E0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x1C99F80 Offset: 0x1C98580 VA: 0x181C99F80
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x1C9CCA0 Offset: 0x1C9B2A0 VA: 0x181C9CCA0
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x1C9CC40 Offset: 0x1C9B240 VA: 0x181C9CC40
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x1C9A230 Offset: 0x1C98830 VA: 0x181C9A230
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x1C9A2C0 Offset: 0x1C988C0 VA: 0x181C9A2C0
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x1C9A3A0 Offset: 0x1C989A0 VA: 0x181C9A3A0
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x1C99FB0 Offset: 0x1C985B0 VA: 0x181C99FB0
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	private static string ParseUriReference(string s) { }

	// RVA: 0x1C9B0A0 Offset: 0x1C996A0 VA: 0x181C9B0A0
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x1C9B240 Offset: 0x1C99840 VA: 0x181C9B240
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x1C9B440 Offset: 0x1C99A40 VA: 0x181C9B440
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1C9B350 Offset: 0x1C99950 VA: 0x181C9B350
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1C9B090 Offset: 0x1C99690 VA: 0x181C9B090
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1C9AFB0 Offset: 0x1C995B0 VA: 0x181C9AFB0
	private void RecordPosition() { }

	// RVA: 0x1C9CED0 Offset: 0x1C9B4D0 VA: 0x181C9CED0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
[Flags]
internal enum XsdDateTimeFlags // TypeDefIndex: 7170
{
	// Fields
	public int value__; // 0x0
	public const XsdDateTimeFlags DateTime = 1;
	public const XsdDateTimeFlags Time = 2;
	public const XsdDateTimeFlags Date = 4;
	public const XsdDateTimeFlags GYearMonth = 8;
	public const XsdDateTimeFlags GYear = 16;
	public const XsdDateTimeFlags GMonthDay = 32;
	public const XsdDateTimeFlags GDay = 64;
	public const XsdDateTimeFlags GMonth = 128;
	public const XsdDateTimeFlags XdrDateTimeNoTz = 256;
	public const XsdDateTimeFlags XdrDateTime = 512;
	public const XsdDateTimeFlags XdrTimeNoTz = 1024;
	public const XsdDateTimeFlags AllXsd = 255;
}

// Namespace: System.Xml.Schema
internal struct XsdDateTime // TypeDefIndex: 7174
{
	// Fields
	private DateTime dt; // 0x0
	private uint extra; // 0x8
	private static readonly int Lzyyyy; // 0x0
	private static readonly int Lzyyyy_; // 0x4
	private static readonly int Lzyyyy_MM; // 0x8
	private static readonly int Lzyyyy_MM_; // 0xC
	private static readonly int Lzyyyy_MM_dd; // 0x10
	private static readonly int Lzyyyy_MM_ddT; // 0x14
	private static readonly int LzHH; // 0x18
	private static readonly int LzHH_; // 0x1C
	private static readonly int LzHH_mm; // 0x20
	private static readonly int LzHH_mm_; // 0x24
	private static readonly int LzHH_mm_ss; // 0x28
	private static readonly int Lz_; // 0x2C
	private static readonly int Lz_zz; // 0x30
	private static readonly int Lz_zz_; // 0x34
	private static readonly int Lz_zz_zz; // 0x38
	private static readonly int Lz__; // 0x3C
	private static readonly int Lz__mm; // 0x40
	private static readonly int Lz__mm_; // 0x44
	private static readonly int Lz__mm__; // 0x48
	private static readonly int Lz__mm_dd; // 0x4C
	private static readonly int Lz___; // 0x50
	private static readonly int Lz___dd; // 0x54
	private static readonly XmlTypeCode[] typeCodes; // 0x58

	// Properties
	private XsdDateTime.DateTimeTypeCode InternalTypeCode { get; }
	private XsdDateTime.XsdDateTimeKind InternalKind { get; }
	public int Year { get; }
	public int Month { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minute { get; }
	public int Second { get; }
	public int Fraction { get; }
	public int ZoneHour { get; }
	public int ZoneMinute { get; }

	// Methods

	// RVA: 0x1CAD290 Offset: 0x1CAB890 VA: 0x181CAD290
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1CAD4C0 Offset: 0x1CABAC0 VA: 0x181CAD4C0
	private void .ctor(XsdDateTime.Parser parser) { }

	// RVA: 0x1CAB850 Offset: 0x1CA9E50 VA: 0x181CAB850
	private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

	// RVA: 0x1CACAD0 Offset: 0x1CAB0D0 VA: 0x181CACAD0
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x1CAD550 Offset: 0x1CABB50 VA: 0x181CAD550
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x1CAD700 Offset: 0x1CABD00 VA: 0x181CAD700
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x1CAD100 Offset: 0x1CAB700 VA: 0x181CAD100
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x1CAD920 Offset: 0x1CABF20 VA: 0x181CAD920
	private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x148C410 Offset: 0x148AA10 VA: 0x18148C410
	private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x1CADA20 Offset: 0x1CAC020 VA: 0x181CADA20
	public int get_Year() { }

	// RVA: 0x1CAD980 Offset: 0x1CABF80 VA: 0x181CAD980
	public int get_Month() { }

	// RVA: 0x1CAD770 Offset: 0x1CABD70 VA: 0x181CAD770
	public int get_Day() { }

	// RVA: 0x1CAD8D0 Offset: 0x1CABED0 VA: 0x181CAD8D0
	public int get_Hour() { }

	// RVA: 0x1CAD930 Offset: 0x1CABF30 VA: 0x181CAD930
	public int get_Minute() { }

	// RVA: 0x1CAD9D0 Offset: 0x1CABFD0 VA: 0x181CAD9D0
	public int get_Second() { }

	// RVA: 0x1CAD7C0 Offset: 0x1CABDC0 VA: 0x181CAD7C0
	public int get_Fraction() { }

	// RVA: 0x148C420 Offset: 0x148AA20 VA: 0x18148C420
	public int get_ZoneHour() { }

	// RVA: 0x1105F00 Offset: 0x1104500 VA: 0x181105F00
	public int get_ZoneMinute() { }

	// RVA: 0x1CADA70 Offset: 0x1CAC070 VA: 0x181CADA70
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1CAE0D0 Offset: 0x1CAC6D0 VA: 0x181CAE0D0
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1CAC540 Offset: 0x1CAAB40 VA: 0x181CAC540 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CABA50 Offset: 0x1CAA050 VA: 0x181CABA50
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x1CABD60 Offset: 0x1CAA360 VA: 0x181CABD60
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x1CAC180 Offset: 0x1CAA780 VA: 0x181CAC180
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x1CAB9B0 Offset: 0x1CA9FB0 VA: 0x181CAB9B0
	private void IntToCharArray(char[] text, int start, int value, int digits) { }

	// RVA: 0x1CAC4C0 Offset: 0x1CAAAC0 VA: 0x181CAC4C0
	private void ShortToCharArray(char[] text, int start, int value) { }

	// RVA: 0x1CACC40 Offset: 0x1CAB240 VA: 0x181CACC40
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal struct XsdDuration // TypeDefIndex: 7177
{
	// Fields
	private int years; // 0x0
	private int months; // 0x4
	private int days; // 0x8
	private int hours; // 0xC
	private int minutes; // 0x10
	private int seconds; // 0x14
	private uint nanoseconds; // 0x18

	// Properties
	public bool IsNegative { get; }
	public int Years { get; }
	public int Months { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public int Nanoseconds { get; }

	// Methods

	// RVA: 0x1CAFFE0 Offset: 0x1CAE5E0 VA: 0x181CAFFE0
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x1CAFCB0 Offset: 0x1CAE2B0 VA: 0x181CAFCB0
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x1CAFCC0 Offset: 0x1CAE2C0 VA: 0x181CAFCC0
	public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

	// RVA: 0x1CB0270 Offset: 0x1CAE870 VA: 0x181CB0270
	public void .ctor(string s) { }

	// RVA: 0x1CAFF30 Offset: 0x1CAE530 VA: 0x181CAFF30
	public void .ctor(string s, XsdDuration.DurationType durationType) { }

	// RVA: 0x1CB0280 Offset: 0x1CAE880 VA: 0x181CB0280
	public bool get_IsNegative() { }

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public int get_Years() { }

	// RVA: 0x5CFF00 Offset: 0x5CE500 VA: 0x1805CFF00
	public int get_Months() { }

	// RVA: 0x958B90 Offset: 0x957190 VA: 0x180958B90
	public int get_Days() { }

	// RVA: 0x1052600 Offset: 0x1050C00 VA: 0x181052600
	public int get_Hours() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_Minutes() { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_Seconds() { }

	// RVA: 0x1CB0290 Offset: 0x1CAE890 VA: 0x181CB0290
	public int get_Nanoseconds() { }

	// RVA: 0x1CAE8F0 Offset: 0x1CACEF0 VA: 0x181CAE8F0
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x1CAE940 Offset: 0x1CACF40 VA: 0x181CAE940
	public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

	// RVA: 0x1CAF670 Offset: 0x1CADC70 VA: 0x181CAF670
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x1CAF680 Offset: 0x1CADC80 VA: 0x181CAF680
	internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

	// RVA: 0x1CAE4F0 Offset: 0x1CACAF0 VA: 0x181CAE4F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CAE500 Offset: 0x1CACB00 VA: 0x181CAE500
	internal string ToString(XsdDuration.DurationType durationType) { }

	// RVA: 0x1CAEAE0 Offset: 0x1CAD0E0 VA: 0x181CAEAE0
	internal static Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x1CAEAF0 Offset: 0x1CAD0F0 VA: 0x181CAEAF0
	internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

	// RVA: 0x1CAE990 Offset: 0x1CACF90 VA: 0x181CAE990
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }
}

// Namespace: System.Xml.Schema
internal sealed class XsdValidator : BaseValidator // TypeDefIndex: 7178
{
	// Fields
	private int startIDConstraint; // 0x80
	private HWStack validationStack; // 0x88
	private Hashtable attPresence; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool bManageNamespaces; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8
	private XmlSchemaContentProcessing processContents; // 0xC0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x0
	private static readonly XmlSchemaDatatype dtQName; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsiSchemaLocation; // 0xF0
	private string XsiNoNamespaceSchemaLocation; // 0xF8
	private string XsdSchema; // 0x100

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }
	private bool HasIdentityConstraints { get; }

	// Methods

	// RVA: 0x1CB6340 Offset: 0x1CB4940 VA: 0x181CB6340
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1CB6310 Offset: 0x1CB4910 VA: 0x181CB6310
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1CB25C0 Offset: 0x1CB0BC0 VA: 0x181CB25C0
	private void Init() { }

	// RVA: 0x1CB6140 Offset: 0x1CB4740 VA: 0x181CB6140 Slot: 5
	public override void Validate() { }

	// RVA: 0x1CB0CC0 Offset: 0x1CAF2C0 VA: 0x181CB0CC0 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1C51180 Offset: 0x1C4F780 VA: 0x181C51180
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1CB3A10 Offset: 0x1CB2010 VA: 0x181CB3A10
	private void ProcessInlineSchema() { }

	// RVA: 0x1CB4FE0 Offset: 0x1CB35E0 VA: 0x181CB4FE0
	private void ValidateElement() { }

	// RVA: 0x1CB4D70 Offset: 0x1CB3370 VA: 0x181CB4D70
	private object ValidateChildElement() { }

	// RVA: 0x1CB3270 Offset: 0x1CB1870 VA: 0x181CB3270
	private void ProcessElement(object particle) { }

	// RVA: 0x1CB3F20 Offset: 0x1CB2520 VA: 0x181CB3F20
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x1CB51C0 Offset: 0x1CB37C0 VA: 0x181CB51C0
	private void ValidateEndElement() { }

	// RVA: 0x1CB24E0 Offset: 0x1CB0AE0 VA: 0x181CB24E0
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x1CB48C0 Offset: 0x1CB2EC0 VA: 0x181CB48C0
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x1CB5A10 Offset: 0x1CB4010 VA: 0x181CB5A10
	private void ValidateStartElement() { }

	// RVA: 0x1CB5510 Offset: 0x1CB3B10 VA: 0x181CB5510
	private void ValidateEndStartElement() { }

	// RVA: 0x1CB2A50 Offset: 0x1CB1050 VA: 0x181CB2A50
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x1CB2FA0 Offset: 0x1CB15A0 VA: 0x181CB2FA0
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1C51160 Offset: 0x1C4F760 VA: 0x181C51160
	private bool get_HasSchema() { }

	// RVA: 0x1C51190 Offset: 0x1C4F790 VA: 0x181C51190 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1CB3C70 Offset: 0x1CB2270 VA: 0x181CB3C70
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1CB0E10 Offset: 0x1CAF410 VA: 0x181CB0E10
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1CB0330 Offset: 0x1CAE930 VA: 0x181CB0330
	internal void AddID(string name, object node) { }

	// RVA: 0x1C4E750 Offset: 0x1C4CD50 VA: 0x181C4E750 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1CB2A00 Offset: 0x1CB1000 VA: 0x181CB2A00
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1CB4720 Offset: 0x1CB2D20 VA: 0x181CB4720
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1CB3170 Offset: 0x1CB1770 VA: 0x181CB3170
	private void Pop() { }

	// RVA: 0x1CB0CC0 Offset: 0x1CAF2C0 VA: 0x181CB0CC0
	private void CheckForwardRefs() { }

	// RVA: 0x1CB59B0 Offset: 0x1CB3FB0 VA: 0x181CB59B0
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1CB6370 Offset: 0x1CB4970 VA: 0x181CB6370
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x1CB03E0 Offset: 0x1CAE9E0 VA: 0x181CB03E0
	private void AddIdentityConstraints() { }

	// RVA: 0x1CB1270 Offset: 0x1CAF870 VA: 0x181CB1270
	private void ElementIdentityConstraints() { }

	// RVA: 0x1CB0930 Offset: 0x1CAEF30 VA: 0x181CB0930
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x1CB4D00 Offset: 0x1CB3300 VA: 0x181CB4D00
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x1CB16B0 Offset: 0x1CAFCB0 VA: 0x181CB16B0
	private void EndElementIdentityConstraints() { }

	// RVA: 0x1CB6220 Offset: 0x1CB4820 VA: 0x181CB6220
	private static void .cctor() { }
}

