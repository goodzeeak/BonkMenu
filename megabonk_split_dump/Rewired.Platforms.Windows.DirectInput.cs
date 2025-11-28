// Namespace: Rewired.Platforms.Windows.DirectInput
public enum DirectInputDeviceType // TypeDefIndex: 5888
{
	// Fields
	public int value__; // 0x0
	public const DirectInputDeviceType Device = 17;
	public const DirectInputDeviceType Mouse = 18;
	public const DirectInputDeviceType Keyboard = 19;
	public const DirectInputDeviceType Joystick = 20;
	public const DirectInputDeviceType Gamepad = 21;
	public const DirectInputDeviceType Driving = 22;
	public const DirectInputDeviceType Flight = 23;
	public const DirectInputDeviceType FirstPerson = 24;
	public const DirectInputDeviceType ControlDevice = 25;
	public const DirectInputDeviceType ScreenPointer = 26;
	public const DirectInputDeviceType Remote = 27;
	public const DirectInputDeviceType Supplemental = 28;
}

// Namespace: Rewired.Platforms.Windows.DirectInput
public enum DirectInputDeviceAxisMode // TypeDefIndex: 5889
{
	// Fields
	public int value__; // 0x0
	public const DirectInputDeviceAxisMode Absolute = 0;
	public const DirectInputDeviceAxisMode Relative = 1;
}

// Namespace: Rewired.Platforms.Windows.DirectInput
public struct DirectInputInputRange // TypeDefIndex: 5890
{
	// Fields
	public int Minimum; // 0x0
	public int Maximum; // 0x4
	public const int NoMinimum = -2147483648;
	public const int NoMaximum = 2147483647;

	// Methods

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	public void .ctor(int , int ) { }
}

// Namespace: Rewired.Platforms.Windows.DirectInput
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class DirectInputControllerExtension : Controller.Extension, IHIDControllerExtension // TypeDefIndex: 5892
{
	// Fields
	private DirectInputControllerExtension.cUzfKQHwKRcpiuGhfQXdlxVnqBYc EWwAeiUpgvtlbQdUWtEOOaRinRPw; // 0x28
	private bool kJpBSqRNXqDtiASRXMMPJrBnlpOR; // 0x30

	// Properties
	private Joystick joystick { get; }
	public Guid instanceGuid { get; }
	public Guid productGuid { get; }
	public string instanceName { get; }
	public string productName { get; }
	public Guid forceFeedbackDriverGuid { get; }
	public ushort usagePage { get; }
	public ushort usage { get; }
	public DirectInputDeviceType deviceType { get; }
	public int deviceSubtype { get; }
	public int rawType { get; }
	public bool isHumanInterfaceDevice { get; }
	public DirectInputDeviceAxisMode axisMode { get; }
	public int bufferSize { get; }
	public Guid classGuid { get; }
	public int forceFeedbackGain { get; set; }
	public string interfacePath { get; }
	public int joystickId { get; }
	public ushort productId { get; }
	public ushort vendorId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }

	// Methods

	// RVA: 0x192F3B0 Offset: 0x192D9B0 VA: 0x18192F3B0
	private Joystick kdmLphKmVrFRPpusvrsNJWTnfHIB() { }

	// RVA: 0x192E360 Offset: 0x192C960 VA: 0x18192E360
	internal void .ctor(JicQzfZFGYlDzHeOEuuFHdMrnbQA , iiCQkmclKKOKpHlRAXXyhYgZVknX ) { }

	// RVA: 0x17623F0 Offset: 0x17609F0 VA: 0x1817623F0
	private void .ctor(DirectInputControllerExtension ) { }

	// RVA: 0x192E9F0 Offset: 0x192CFF0 VA: 0x18192E9F0
	public Guid get_instanceGuid() { }

	// RVA: 0x192EE10 Offset: 0x192D410 VA: 0x18192EE10
	public Guid get_productGuid() { }

	// RVA: 0x192EAE0 Offset: 0x192D0E0 VA: 0x18192EAE0
	public string get_instanceName() { }

	// RVA: 0x192EFD0 Offset: 0x192D5D0 VA: 0x18192EFD0 Slot: 10
	public string get_productName() { }

	// RVA: 0x192E830 Offset: 0x192CE30 VA: 0x18192E830
	public Guid get_forceFeedbackDriverGuid() { }

	// RVA: 0x192F160 Offset: 0x192D760 VA: 0x18192F160 Slot: 12
	public ushort get_usagePage() { }

	// RVA: 0x192F220 Offset: 0x192D820 VA: 0x18192F220 Slot: 13
	public ushort get_usage() { }

	// RVA: 0x192E770 Offset: 0x192CD70 VA: 0x18192E770
	public DirectInputDeviceType get_deviceType() { }

	// RVA: 0x192E6B0 Offset: 0x192CCB0 VA: 0x18192E6B0
	public int get_deviceSubtype() { }

	// RVA: 0x192F0A0 Offset: 0x192D6A0 VA: 0x18192F0A0
	public int get_rawType() { }

	// RVA: 0x192EC80 Offset: 0x192D280 VA: 0x18192EC80
	public bool get_isHumanInterfaceDevice() { }

	// RVA: 0x192E400 Offset: 0x192CA00 VA: 0x18192E400
	public DirectInputDeviceAxisMode get_axisMode() { }

	// RVA: 0x192E4D0 Offset: 0x192CAD0 VA: 0x18192E4D0
	public int get_bufferSize() { }

	// RVA: 0x192E5A0 Offset: 0x192CBA0 VA: 0x18192E5A0
	public Guid get_classGuid() { }

	// RVA: 0x192E920 Offset: 0x192CF20 VA: 0x18192E920
	public int get_forceFeedbackGain() { }

	// RVA: 0x192F3F0 Offset: 0x192D9F0 VA: 0x18192F3F0
	public void set_forceFeedbackGain(int value) { }

	// RVA: 0x192EBB0 Offset: 0x192D1B0 VA: 0x18192EBB0
	public string get_interfacePath() { }

	// RVA: 0x192ED40 Offset: 0x192D340 VA: 0x18192ED40
	public int get_joystickId() { }

	// RVA: 0x192EF00 Offset: 0x192D500 VA: 0x18192EF00 Slot: 9
	public ushort get_productId() { }

	// RVA: 0x192F2E0 Offset: 0x192D8E0 VA: 0x18192F2E0 Slot: 8
	public ushort get_vendorId() { }

	// RVA: 0x37A870 Offset: 0x378E70 VA: 0x18037A870 Slot: 11
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x1908730 Offset: 0x1906D30 VA: 0x181908730 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x192E290 Offset: 0x192C890 VA: 0x18192E290 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x192E230 Offset: 0x192C830 VA: 0x18192E230 Slot: 7
	internal override Controller.Extension Clone() { }
}

