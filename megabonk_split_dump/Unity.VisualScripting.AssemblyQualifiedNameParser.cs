// Namespace: Unity.VisualScripting.AssemblyQualifiedNameParser
public class ParsedAssemblyQualifiedName // TypeDefIndex: 9396
{
	// Fields
	[CompilerGenerated]
	private readonly string <AssemblyDescriptionString>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <TypeName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <ShortAssemblyName>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Culture>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly string <PublicKeyToken>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly List<ParsedAssemblyQualifiedName> <GenericParameters>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly int <GenericParameterCount>k__BackingField; // 0x48

	// Properties
	public string AssemblyDescriptionString { get; }
	public string TypeName { get; set; }
	public string ShortAssemblyName { get; }
	public string Version { get; }
	public string Culture { get; }
	public string PublicKeyToken { get; }
	public List<ParsedAssemblyQualifiedName> GenericParameters { get; }
	public int GenericParameterCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_AssemblyDescriptionString() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_TypeName() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_TypeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_ShortAssemblyName() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_Culture() { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_PublicKeyToken() { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public List<ParsedAssemblyQualifiedName> get_GenericParameters() { }

	[CompilerGenerated]
	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public int get_GenericParameterCount() { }

	// RVA: 0x22CDD60 Offset: 0x22CC360 VA: 0x1822CDD60
	public void .ctor(string AssemblyQualifiedName) { }

	// RVA: 0x22CD8A0 Offset: 0x22CBEA0 VA: 0x1822CD8A0
	private static string LookForPairThenRemove(List<string> strings, string Name) { }

	// RVA: 0x22CD990 Offset: 0x22CBF90 VA: 0x1822CD990
	public void Replace(string oldTypeName, string newTypeName) { }

	// RVA: 0x22CDAD0 Offset: 0x22CC0D0 VA: 0x1822CDAD0
	private string ToString(bool includeAssemblyDescription) { }

	// RVA: 0x22CDD50 Offset: 0x22CC350 VA: 0x1822CDD50 Slot: 3
	public override string ToString() { }
}

