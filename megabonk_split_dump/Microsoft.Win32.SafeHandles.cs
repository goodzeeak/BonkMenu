// Namespace: Microsoft.Win32.SafeHandles
internal static class SafeHandleCache<T> // TypeDefIndex: 127
{
	// Fields
	private static T s_invalidHandle; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal static bool IsCachedInvalidHandle(SafeHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x966870 Offset: 0x964E70 VA: 0x180966870
	|-SafeHandleCache<object>.IsCachedInvalidHandle
	*/
}

// Namespace: Microsoft.Win32.SafeHandles
internal sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 128
{
	// Methods

	// RVA: 0x135CF50 Offset: 0x135B550 VA: 0x18135CF50
	internal void .ctor() { }

	// RVA: 0x135D050 Offset: 0x135B650 VA: 0x18135D050 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 129
{
	// Methods

	// RVA: 0x135D2B0 Offset: 0x135B8B0 VA: 0x18135D2B0 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x135CF50 Offset: 0x135B550 VA: 0x18135CF50
	internal void .ctor() { }

	// RVA: 0x135CED0 Offset: 0x135B4D0 VA: 0x18135CED0
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }
}

// Namespace: Microsoft.Win32.SafeHandles
internal sealed class SafePasswordHandle : SafeHandle // TypeDefIndex: 130
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x135D060 Offset: 0x135B660 VA: 0x18135D060
	private IntPtr CreateHandle(string password) { }

	// RVA: 0x135D110 Offset: 0x135B710 VA: 0x18135D110
	private void FreeHandle() { }

	// RVA: 0x135D220 Offset: 0x135B820 VA: 0x18135D220
	public void .ctor(string password) { }

	// RVA: 0x135D1B0 Offset: 0x135B7B0 VA: 0x18135D1B0 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x135D0B0 Offset: 0x135B6B0 VA: 0x18135D0B0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x135D290 Offset: 0x135B890 VA: 0x18135D290 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x135D160 Offset: 0x135B760 VA: 0x18135D160
	internal string Mono_DangerousGetString() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 131
{
	// Methods

	// RVA: 0x135CED0 Offset: 0x135B4D0 VA: 0x18135CED0
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x135CE60 Offset: 0x135B460 VA: 0x18135CE60 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
internal class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 132
{
	// Methods

	// RVA: 0x135CF50 Offset: 0x135B550 VA: 0x18135CF50
	internal void .ctor() { }

	// RVA: 0x135CF00 Offset: 0x135B500 VA: 0x18135CF00 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 133
{
	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x135CED0 Offset: 0x135B4D0 VA: 0x18135CED0
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x135D2D0 Offset: 0x135B8D0 VA: 0x18135D2D0 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle // TypeDefIndex: 134
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x135CFF0 Offset: 0x135B5F0 VA: 0x18135CFF0
	protected void .ctor(bool ownsHandle) { }

	// RVA: 0x135D000 Offset: 0x135B600 VA: 0x18135D000 Slot: 5
	public override bool get_IsInvalid() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public abstract class SafeHandleMinusOneIsInvalid : SafeHandle // TypeDefIndex: 135
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x135CF60 Offset: 0x135B560 VA: 0x18135CF60
	protected void .ctor(bool ownsHandle) { }

	// RVA: 0x135CFB0 Offset: 0x135B5B0 VA: 0x18135CFB0 Slot: 5
	public override bool get_IsInvalid() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 7393
{
	// Fields
	internal static SafeProcessHandle InvalidHandle; // 0x0

	// Methods

	// RVA: 0x1DDA880 Offset: 0x1DD8E80 VA: 0x181DDA880
	internal void .ctor(IntPtr handle) { }

	// RVA: 0x1DDA8B0 Offset: 0x1DD8EB0 VA: 0x181DDA8B0
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x1DDA7F0 Offset: 0x1DD8DF0 VA: 0x181DDA7F0 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x1DDA800 Offset: 0x1DD8E00 VA: 0x181DDA800
	private static void .cctor() { }
}

