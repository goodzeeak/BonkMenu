// Namespace: UnityEngine.ResourceManagement.Exceptions
public class ResourceManagerException : Exception // TypeDefIndex: 12641
{
	// Methods

	// RVA: 0x2127110 Offset: 0x2125710 VA: 0x182127110
	public void .ctor() { }

	// RVA: 0x21271E0 Offset: 0x21257E0 VA: 0x1821271E0
	public void .ctor(string message) { }

	// RVA: 0x2127240 Offset: 0x2125840 VA: 0x182127240
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x2127160 Offset: 0x2125760 VA: 0x182127160
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x2127080 Offset: 0x2125680 VA: 0x182127080 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class UnknownResourceProviderException : ResourceManagerException // TypeDefIndex: 12642
{
	// Fields
	[CompilerGenerated]
	private IResourceLocation <Location>k__BackingField; // 0x90

	// Properties
	public IResourceLocation Location { get; set; }
	public override string Message { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public IResourceLocation get_Location() { }

	[CompilerGenerated]
	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	private void set_Location(IResourceLocation value) { }

	// RVA: 0x212E8E0 Offset: 0x212CEE0 VA: 0x18212E8E0
	public void .ctor(IResourceLocation location) { }

	// RVA: 0x2127110 Offset: 0x2125710 VA: 0x182127110
	public void .ctor() { }

	// RVA: 0x21271E0 Offset: 0x21257E0 VA: 0x1821271E0
	public void .ctor(string message) { }

	// RVA: 0x2127240 Offset: 0x2125840 VA: 0x182127240
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x2127160 Offset: 0x2125760 VA: 0x182127160
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x212E950 Offset: 0x212CF50 VA: 0x18212E950 Slot: 5
	public override string get_Message() { }

	// RVA: 0x5482B0 Offset: 0x5468B0 VA: 0x1805482B0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class OperationException : Exception // TypeDefIndex: 12643
{
	// Methods

	// RVA: 0x2124B80 Offset: 0x2123180 VA: 0x182124B80
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x2124AF0 Offset: 0x21230F0 VA: 0x182124AF0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class ProviderException : OperationException // TypeDefIndex: 12644
{
	// Fields
	[CompilerGenerated]
	private readonly IResourceLocation <Location>k__BackingField; // 0x90

	// Properties
	public IResourceLocation Location { get; }

	// Methods

	// RVA: 0x2125190 Offset: 0x2123790 VA: 0x182125190
	public void .ctor(string message, IResourceLocation location, Exception innerException) { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public IResourceLocation get_Location() { }
}

// Namespace: UnityEngine.ResourceManagement.Exceptions
public class RemoteProviderException : ProviderException // TypeDefIndex: 12645
{
	// Fields
	[CompilerGenerated]
	private readonly UnityWebRequestResult <WebRequestResult>k__BackingField; // 0x98

	// Properties
	public override string Message { get; }
	public UnityWebRequestResult WebRequestResult { get; }

	// Methods

	// RVA: 0x21263A0 Offset: 0x21249A0 VA: 0x1821263A0
	public void .ctor(string message, IResourceLocation location, UnityWebRequestResult uwrResult, Exception innerException) { }

	// RVA: 0x14B4000 Offset: 0x14B2600 VA: 0x1814B4000 Slot: 5
	public override string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public UnityWebRequestResult get_WebRequestResult() { }

	// RVA: 0x2126130 Offset: 0x2124730 VA: 0x182126130 Slot: 3
	public override string ToString() { }
}

