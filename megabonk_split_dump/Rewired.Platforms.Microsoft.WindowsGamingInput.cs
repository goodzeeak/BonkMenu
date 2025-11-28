// Namespace: Rewired.Platforms.Microsoft.WindowsGamingInput
[CustomObfuscation(rename = False)]
internal enum WGIDeviceType // TypeDefIndex: 5909
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const WGIDeviceType None = 0;
	[CustomObfuscation(rename = False)]
	public const WGIDeviceType Gamepad = 1;
}

// Namespace: Rewired.Platforms.Microsoft.WindowsGamingInput
public enum DeviceType // TypeDefIndex: 5922
{
	// Fields
	public int value__; // 0x0
	public const DeviceType Unknown = 0;
	public const DeviceType Gamepad = 1;
}

// Namespace: Rewired.Platforms.Microsoft.WindowsGamingInput
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class WindowsGamingInputControllerExtension : Controller.Extension, IHIDControllerExtension // TypeDefIndex: 5924
{
	// Fields
	private WindowsGamingInputControllerExtension.qwGCowBrMnLRCPESXmBayoDQRQoM wlAdOowjDiYbKcvYrdRalhPTdQBbA; // 0x28
	private bool uQPCwPATDelVaZwKepFlCffsTZYU; // 0x30

	// Properties
	private Joystick joystick { get; }
	public DeviceType deviceType { get; }
	public IntPtr nativePointer { get; }
	public string nonRoamableId { get; }
	public bool isWireless { get; }
	public string productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	public ushort vendorId { get; }
	public ushort productId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x1933980 Offset: 0x1931F80 VA: 0x181933980
	private Joystick ugAfSjUndxhVoTIQgcksNfBXkYQl() { }

	// RVA: 0x1933320 Offset: 0x1931920 VA: 0x181933320
	internal void .ctor(ZPSSkNvBmmvBukTLMPkyFcGrUsvP ) { }

	// RVA: 0x17623F0 Offset: 0x17609F0 VA: 0x1817623F0
	private void .ctor(WindowsGamingInputControllerExtension ) { }

	// RVA: 0x19333A0 Offset: 0x19319A0 VA: 0x1819333A0
	public DeviceType get_deviceType() { }

	// RVA: 0x19334D0 Offset: 0x1931AD0 VA: 0x1819334D0
	public IntPtr get_nativePointer() { }

	// RVA: 0x1933620 Offset: 0x1931C20 VA: 0x181933620
	public string get_nonRoamableId() { }

	// RVA: 0x1933400 Offset: 0x1931A00 VA: 0x181933400
	public bool get_isWireless() { }

	// RVA: 0x19337D0 Offset: 0x1931DD0 VA: 0x1819337D0 Slot: 10
	public string get_productName() { }

	// RVA: 0x37A870 Offset: 0x378E70 VA: 0x18037A870 Slot: 11
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x19338B0 Offset: 0x1931EB0 VA: 0x1819338B0 Slot: 8
	public ushort get_vendorId() { }

	// RVA: 0x1933700 Offset: 0x1931D00 VA: 0x181933700 Slot: 9
	public ushort get_productId() { }

	// RVA: 0x19330B0 Offset: 0x19316B0 VA: 0x1819330B0 Slot: 12
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x1933180 Offset: 0x1931780 VA: 0x181933180 Slot: 13
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x1908730 Offset: 0x1906D30 VA: 0x181908730 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1933250 Offset: 0x1931850 VA: 0x181933250 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x1933050 Offset: 0x1931650 VA: 0x181933050 Slot: 7
	internal override Controller.Extension Clone() { }
}

// Namespace: Rewired.Platforms.Microsoft.WindowsGamingInput
[Flags]
internal enum GamepadButtons // TypeDefIndex: 5937
{
	// Fields
	public uint value__; // 0x0
	public const GamepadButtons None = 0;
	public const GamepadButtons Menu = 1;
	public const GamepadButtons View = 2;
	public const GamepadButtons A = 4;
	public const GamepadButtons B = 8;
	public const GamepadButtons X = 16;
	public const GamepadButtons Y = 32;
	public const GamepadButtons DPadUp = 64;
	public const GamepadButtons DPadDown = 128;
	public const GamepadButtons DPadLeft = 256;
	public const GamepadButtons DPadRight = 512;
	public const GamepadButtons LeftShoulder = 1024;
	public const GamepadButtons RightShoulder = 2048;
	public const GamepadButtons LeftThumbstick = 4096;
	public const GamepadButtons RightThumbstick = 8192;
}

