// Namespace: System.Security.Util
internal sealed class Parser // TypeDefIndex: 715
{
	// Fields
	private SecurityDocument _doc; // 0x10
	private Tokenizer _t; // 0x18

	// Methods

	// RVA: 0x1389F90 Offset: 0x1388590 VA: 0x181389F90
	internal SecurityElement GetTopElement() { }

	// RVA: 0x13897C0 Offset: 0x1387DC0 VA: 0x1813897C0
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	// RVA: 0x13895D0 Offset: 0x1387BD0 VA: 0x1813895D0
	private int DetermineFormat(TokenizerStream stream) { }

	// RVA: 0x1389FC0 Offset: 0x13885C0 VA: 0x181389FC0
	private void ParseContents() { }

	// RVA: 0x138A600 Offset: 0x1388C00 VA: 0x18138A600
	private void .ctor(Tokenizer t) { }

	// RVA: 0x138A500 Offset: 0x1388B00 VA: 0x18138A500
	internal void .ctor(string input) { }
}

// Namespace: System.Security.Util
internal sealed class Tokenizer // TypeDefIndex: 720
{
	// Fields
	public int LineNo; // 0x10
	private int _inProcessingTag; // 0x14
	private byte[] _inBytes; // 0x18
	private char[] _inChars; // 0x20
	private string _inString; // 0x28
	private int _inIndex; // 0x30
	private int _inSize; // 0x34
	private int _inSavedCharacter; // 0x38
	private Tokenizer.TokenSource _inTokenSource; // 0x3C
	private Tokenizer.ITokenReader _inTokenReader; // 0x40
	private Tokenizer.StringMaker _maker; // 0x48
	private string[] _searchStrings; // 0x50
	private string[] _replaceStrings; // 0x58
	private int _inNestedIndex; // 0x60
	private int _inNestedSize; // 0x64
	private string _inNestedString; // 0x68

	// Methods

	// RVA: 0x138F5C0 Offset: 0x138DBC0 VA: 0x18138F5C0
	internal void BasicInitialization() { }

	// RVA: 0x13902E0 Offset: 0x138E8E0 VA: 0x1813902E0
	public void Recycle() { }

	// RVA: 0x1390330 Offset: 0x138E930 VA: 0x181390330
	internal void .ctor(string input) { }

	// RVA: 0x138F640 Offset: 0x138DC40 VA: 0x18138F640
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x138F8F0 Offset: 0x138DEF0 VA: 0x18138F8F0
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x138F8D0 Offset: 0x138DED0 VA: 0x18138F8D0
	private string GetStringToken() { }
}

// Namespace: System.Security.Util
internal sealed class TokenizerShortBlock // TypeDefIndex: 721
{
	// Fields
	internal short[] m_block; // 0x10
	internal TokenizerShortBlock m_next; // 0x18

	// Methods

	// RVA: 0x138EDD0 Offset: 0x138D3D0 VA: 0x18138EDD0
	public void .ctor() { }
}

// Namespace: System.Security.Util
internal sealed class TokenizerStringBlock // TypeDefIndex: 722
{
	// Fields
	internal string[] m_block; // 0x10
	internal TokenizerStringBlock m_next; // 0x18

	// Methods

	// RVA: 0x138F560 Offset: 0x138DB60 VA: 0x18138F560
	public void .ctor() { }
}

// Namespace: System.Security.Util
internal sealed class TokenizerStream // TypeDefIndex: 723
{
	// Fields
	private int m_countTokens; // 0x10
	private TokenizerShortBlock m_headTokens; // 0x18
	private TokenizerShortBlock m_lastTokens; // 0x20
	private TokenizerShortBlock m_currentTokens; // 0x28
	private int m_indexTokens; // 0x30
	private TokenizerStringBlock m_headStrings; // 0x38
	private TokenizerStringBlock m_currentStrings; // 0x40
	private int m_indexStrings; // 0x48

	// Methods

	// RVA: 0x138F400 Offset: 0x138DA00 VA: 0x18138F400
	internal void .ctor() { }

	// RVA: 0x138EF70 Offset: 0x138D570 VA: 0x18138EF70
	internal void AddToken(short token) { }

	// RVA: 0x138EE30 Offset: 0x138D430 VA: 0x18138EE30
	internal void AddString(string str) { }

	// RVA: 0x138F300 Offset: 0x138D900 VA: 0x18138F300
	internal void Reset() { }

	// RVA: 0x138F0B0 Offset: 0x138D6B0 VA: 0x18138F0B0
	internal short GetNextFullToken() { }

	// RVA: 0x138F1C0 Offset: 0x138D7C0 VA: 0x18138F1C0
	internal short GetNextToken() { }

	// RVA: 0x138F140 Offset: 0x138D740 VA: 0x18138F140
	internal string GetNextString() { }

	// RVA: 0x138F3F0 Offset: 0x138D9F0 VA: 0x18138F3F0
	internal void ThrowAwayNextString() { }

	// RVA: 0x138F360 Offset: 0x138D960 VA: 0x18138F360
	internal void TagLastToken(short tag) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	internal int GetTokenCount() { }

	// RVA: 0x138F1E0 Offset: 0x138D7E0 VA: 0x18138F1E0
	internal void GoToPosition(int position) { }
}

