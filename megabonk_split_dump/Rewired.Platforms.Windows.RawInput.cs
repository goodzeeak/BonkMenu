// Namespace: Rewired.Platforms.Windows.RawInput
internal enum DeviceType // TypeDefIndex: 5846
{
	// Fields
	public int value__; // 0x0
	public const DeviceType Joystick = 0;
	public const DeviceType Gamepad = 1;
	public const DeviceType Keyboard = 2;
	public const DeviceType Mouse = 3;
	public const DeviceType MultiAxisController = 4;
	public const DeviceType Unknown = 5;
}

// Namespace: Rewired.Platforms.Windows.RawInput
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class RawInputControllerExtension : Controller.Extension, IHIDControllerExtension // TypeDefIndex: 5864
{
	// Fields
	private RawInputControllerExtension.BdOLWKkCthZoSUWjkTTvdUyhsYiR aCHdLqJciXdygdlMJIXNkKrXTIjLA; // 0x28
	private bool ZPWzXQpqDjBMKEXngzvlBdumhBKN; // 0x30

	// Properties
	private Joystick joystick { get; }
	public IntPtr hidDeviceHandle { get; }
	public IntPtr rawInputDeviceHandle { get; }
	public string devicePath { get; }
	public string productName { get; }
	public string manufacturer { get; }
	public ushort vendorId { get; }
	public ushort productId { get; }
	public Guid productGuid { get; }
	public bool isBluetoothDevice { get; }
	public string bluetoothDeviceName { get; }
	public int hubId { get; }
	public int portId { get; }
	public ushort usagePage { get; }
	public ushort usage { get; }

	// Methods

	// RVA: 0x1921DE0 Offset: 0x19203E0 VA: 0x181921DE0
	private Joystick hEUGDTjnErYlbTlHQswYmYKQShgqA() { }

	// RVA: 0x19210E0 Offset: 0x191F6E0 VA: 0x1819210E0
	internal void .ctor(DOUHYWHWfppEOZUqKorrbywepupI ) { }

	// RVA: 0x17623F0 Offset: 0x17609F0 VA: 0x1817623F0
	private void .ctor(RawInputControllerExtension ) { }

	// RVA: 0x1921340 Offset: 0x191F940 VA: 0x181921340
	public IntPtr get_hidDeviceHandle() { }

	// RVA: 0x1921A40 Offset: 0x1920040 VA: 0x181921A40
	public IntPtr get_rawInputDeviceHandle() { }

	// RVA: 0x1921240 Offset: 0x191F840 VA: 0x181921240
	public string get_devicePath() { }

	// RVA: 0x1921960 Offset: 0x191FF60 VA: 0x181921960 Slot: 10
	public string get_productName() { }

	// RVA: 0x19215D0 Offset: 0x191FBD0 VA: 0x1819215D0 Slot: 11
	public string get_manufacturer() { }

	// RVA: 0x1921D10 Offset: 0x1920310 VA: 0x181921D10 Slot: 8
	public ushort get_vendorId() { }

	// RVA: 0x1921890 Offset: 0x191FE90 VA: 0x181921890 Slot: 9
	public ushort get_productId() { }

	// RVA: 0x1921780 Offset: 0x191FD80 VA: 0x181921780
	public Guid get_productGuid() { }

	// RVA: 0x1921500 Offset: 0x191FB00 VA: 0x181921500
	public bool get_isBluetoothDevice() { }

	// RVA: 0x1921160 Offset: 0x191F760 VA: 0x181921160
	public string get_bluetoothDeviceName() { }

	// RVA: 0x1921430 Offset: 0x191FA30 VA: 0x181921430
	public int get_hubId() { }

	// RVA: 0x19216B0 Offset: 0x191FCB0 VA: 0x1819216B0
	public int get_portId() { }

	// RVA: 0x1921B10 Offset: 0x1920110 VA: 0x181921B10 Slot: 12
	public ushort get_usagePage() { }

	// RVA: 0x1921C10 Offset: 0x1920210 VA: 0x181921C10 Slot: 13
	public ushort get_usage() { }

	// RVA: 0x1908730 Offset: 0x1906D30 VA: 0x181908730 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1921010 Offset: 0x191F610 VA: 0x181921010 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x1920FB0 Offset: 0x191F5B0 VA: 0x181920FB0 Slot: 7
	internal override Controller.Extension Clone() { }
}

