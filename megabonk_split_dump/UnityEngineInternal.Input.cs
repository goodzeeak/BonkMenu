// Namespace: UnityEngineInternal.Input
internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 14274
{
	// Methods

	// RVA: 0x593FB0 Offset: 0x5925B0 VA: 0x180593FB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }
}

// Namespace: UnityEngineInternal.Input
internal struct NativeInputEventBuffer // TypeDefIndex: 14275
{
	// Fields
	public void* eventBuffer; // 0x0
	public int eventCount; // 0x8
	public int sizeInBytes; // 0xC
	public int capacityInBytes; // 0x10
}

// Namespace: UnityEngineInternal.Input
[Flags]
internal enum NativeInputUpdateType // TypeDefIndex: 14276
{
	// Fields
	public int value__; // 0x0
	public const NativeInputUpdateType Dynamic = 1;
	public const NativeInputUpdateType Fixed = 2;
	public const NativeInputUpdateType BeforeRender = 4;
	public const NativeInputUpdateType Editor = 8;
	public const NativeInputUpdateType IgnoreFocus = -2147483648;
}

// Namespace: UnityEngineInternal.Input
[NativeHeader("Modules/Input/Private/InputModuleBindings.h")]
[NativeHeader("Modules/Input/Private/InputInternal.h")]
internal class NativeInputSystem // TypeDefIndex: 14277
{
	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
	private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	internal static bool hasDeviceDiscoveredCallback { set; }

	// Methods

	// RVA: 0x23A91B0 Offset: 0x23A77B0 VA: 0x1823A91B0
	private static void .cctor() { }

	[RequiredByNativeCode]
	// RVA: 0x23A8F90 Offset: 0x23A7590 VA: 0x1823A8F90
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCode]
	// RVA: 0x23A9080 Offset: 0x23A7680 VA: 0x1823A9080
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCode]
	// RVA: 0x23A9000 Offset: 0x23A7600 VA: 0x1823A9000
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCode]
	// RVA: 0x23A9120 Offset: 0x23A7720 VA: 0x1823A9120
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x23A91E0 Offset: 0x23A77E0 VA: 0x1823A91E0
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }
}

