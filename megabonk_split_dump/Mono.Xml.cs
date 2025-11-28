// Namespace: Mono.Xml
internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 69
{
	// Fields
	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78

	// Methods

	// RVA: 0x133E5D0 Offset: 0x133CBD0 VA: 0x18133E5D0
	public void .ctor() { }

	// RVA: 0x133E0C0 Offset: 0x133C6C0 VA: 0x18133E0C0
	public void LoadXml(string xml) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public SecurityElement ToXml() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x133E2A0 Offset: 0x133C8A0 VA: 0x18133E2A0 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x133E1E0 Offset: 0x133C7E0 VA: 0x18133E1E0 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x133E160 Offset: 0x133C760 VA: 0x18133E160 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}

// Namespace: Mono.Xml
internal class SmallXmlParser // TypeDefIndex: 73
{
	// Fields
	private SmallXmlParser.IContentHandler handler; // 0x10
	private TextReader reader; // 0x18
	private Stack elementNames; // 0x20
	private Stack xmlSpaces; // 0x28
	private string xmlSpace; // 0x30
	private StringBuilder buffer; // 0x38
	private char[] nameBuffer; // 0x40
	private bool isWhitespace; // 0x48
	private SmallXmlParser.AttrListImpl attributes; // 0x50
	private int line; // 0x58
	private int column; // 0x5C
	private bool resetColumn; // 0x60

	// Methods

	// RVA: 0x1346C40 Offset: 0x1345240 VA: 0x181346C40
	public void .ctor() { }

	// RVA: 0x1344580 Offset: 0x1342B80 VA: 0x181344580
	private Exception Error(string msg) { }

	// RVA: 0x1346B60 Offset: 0x1345160 VA: 0x181346B60
	private Exception UnexpectedEndError() { }

	// RVA: 0x1344960 Offset: 0x1342F60 VA: 0x181344960
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x1344A50 Offset: 0x1343050 VA: 0x181344A50
	private bool IsWhitespace(int c) { }

	// RVA: 0x1346A70 Offset: 0x1345070 VA: 0x181346A70
	public void SkipWhitespaces() { }

	// RVA: 0x1344850 Offset: 0x1342E50 VA: 0x181344850
	private void HandleWhitespaces() { }

	// RVA: 0x1346A80 Offset: 0x1345080 VA: 0x181346A80
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x1344CF0 Offset: 0x13432F0 VA: 0x181344CF0
	private int Peek() { }

	// RVA: 0x1346A10 Offset: 0x1345010 VA: 0x181346A10
	private int Read() { }

	// RVA: 0x1344660 Offset: 0x1342C60 VA: 0x181344660
	public void Expect(int c) { }

	// RVA: 0x13468D0 Offset: 0x1344ED0 VA: 0x1813468D0
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x1346440 Offset: 0x1344A40 VA: 0x181346440
	public string ReadName() { }

	// RVA: 0x1344A70 Offset: 0x1343070 VA: 0x181344A70
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x13444D0 Offset: 0x1342AD0 VA: 0x1813444D0
	private void Cleanup() { }

	// RVA: 0x1345540 Offset: 0x1343B40 VA: 0x181345540
	public void ReadContent() { }

	// RVA: 0x1344780 Offset: 0x1342D80 VA: 0x181344780
	private void HandleBufferedContent() { }

	// RVA: 0x13452D0 Offset: 0x13438D0 VA: 0x1813452D0
	private void ReadCharacters() { }

	// RVA: 0x1346670 Offset: 0x1344C70 VA: 0x181346670
	private void ReadReference() { }

	// RVA: 0x13450E0 Offset: 0x13436E0 VA: 0x1813450E0
	private int ReadCharacterReference() { }

	// RVA: 0x1344D20 Offset: 0x1343320 VA: 0x181344D20
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x1344F90 Offset: 0x1343590 VA: 0x181344F90
	private void ReadCDATASection() { }

	// RVA: 0x13453F0 Offset: 0x13439F0 VA: 0x1813453F0
	private void ReadComment() { }
}

// Namespace: Mono.Xml
internal class SmallXmlParserException : SystemException // TypeDefIndex: 74
{
	// Fields
	private int line; // 0x90
	private int column; // 0x94

	// Methods

	// RVA: 0x1344410 Offset: 0x1342A10 VA: 0x181344410
	public void .ctor(string msg, int line, int column) { }
}

