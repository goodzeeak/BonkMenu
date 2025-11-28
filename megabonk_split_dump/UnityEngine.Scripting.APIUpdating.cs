// Namespace: UnityEngine.Scripting.APIUpdating
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct MovedFromAttributeData // TypeDefIndex: 9882
{
	// Fields
	public string className; // 0x0
	public string nameSpace; // 0x8
	public string assembly; // 0x10
	public bool classHasChanged; // 0x18
	public bool nameSpaceHasChanged; // 0x19
	public bool assemblyHasChanged; // 0x1A
	public bool autoUdpateAPI; // 0x1B

	// Methods

	// RVA: 0x2357C40 Offset: 0x2356240 VA: 0x182357C40
	public void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }
}

// Namespace: UnityEngine.Scripting.APIUpdating
[Usage(5148)]
public class MovedFromAttribute : Attribute // TypeDefIndex: 9883
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal MovedFromAttributeData data; // 0x10

	// Methods

	// RVA: 0x2357CD0 Offset: 0x23562D0 VA: 0x182357CD0
	public void .ctor(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }

	// RVA: 0x2357D30 Offset: 0x2356330 VA: 0x182357D30
	public void .ctor(string sourceNamespace) { }
}

