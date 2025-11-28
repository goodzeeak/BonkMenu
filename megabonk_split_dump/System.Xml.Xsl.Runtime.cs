// Namespace: System.Xml.Xsl.Runtime
[EditorBrowsable(1)]
public struct StringConcat // TypeDefIndex: 6881
{
	// Fields
	private string s1; // 0x0
	private string s2; // 0x8
	private string s3; // 0x10
	private string s4; // 0x18
	private string delimiter; // 0x20
	private List<string> strList; // 0x28
	private int idxStr; // 0x30

	// Properties
	internal int Count { get; }

	// Methods

	// RVA: 0x1D58C00 Offset: 0x1D57200 VA: 0x181D58C00
	public void Clear() { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	internal int get_Count() { }

	// RVA: 0x1D58DC0 Offset: 0x1D573C0 VA: 0x181D58DC0
	public string GetResult() { }

	// RVA: 0x1D58C20 Offset: 0x1D57220 VA: 0x181D58C20
	internal void ConcatNoDelimiter(string s) { }
}

