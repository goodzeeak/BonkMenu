// Namespace: System.Runtime.Versioning
[Usage(108, AllowMultiple = False, Inherited = False)]
internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 964
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Versioning
[Usage(1, AllowMultiple = False, Inherited = False)]
public sealed class TargetFrameworkAttribute : Attribute // TypeDefIndex: 965
{
	// Fields
	private string _frameworkName; // 0x10
	private string _frameworkDisplayName; // 0x18

	// Properties
	public string FrameworkDisplayName { set; }

	// Methods

	// RVA: 0x13F7350 Offset: 0x13F5950 VA: 0x1813F7350
	public void .ctor(string frameworkName) { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_FrameworkDisplayName(string value) { }
}

// Namespace: System.Runtime.Versioning
internal static class BinaryCompatibility // TypeDefIndex: 966
{
	// Fields
	public static readonly bool TargetsAtLeast_Desktop_V4_5; // 0x0
	public static readonly bool TargetsAtLeast_Desktop_V4_5_1; // 0x1

	// Methods

	// RVA: 0x13DA000 Offset: 0x13D8600 VA: 0x1813DA000
	private static void .cctor() { }
}

