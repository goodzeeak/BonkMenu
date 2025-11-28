// Namespace: Rewired.Platforms.Windows.XInput
[Flags]
public enum CapabilityFlags // TypeDefIndex: 5833
{
	// Fields
	public short value__; // 0x0
	public const CapabilityFlags VoiceSupported = 4;
	public const CapabilityFlags None = 0;
}

// Namespace: Rewired.Platforms.Windows.XInput
public enum DeviceType // TypeDefIndex: 5834
{
	// Fields
	public byte value__; // 0x0
	public const DeviceType Gamepad = 1;
}

// Namespace: Rewired.Platforms.Windows.XInput
public enum DeviceSubType // TypeDefIndex: 5835
{
	// Fields
	public byte value__; // 0x0
	public const DeviceSubType Gamepad = 1;
	public const DeviceSubType Wheel = 2;
	public const DeviceSubType ArcadeStick = 3;
	public const DeviceSubType FlightStick = 4;
	public const DeviceSubType DancePad = 5;
	public const DeviceSubType Guitar = 6;
	public const DeviceSubType GuitarAlternate = 7;
	public const DeviceSubType DrumKit = 8;
	public const DeviceSubType GuitarBass = 11;
	public const DeviceSubType ArcadePad = 19;
}

// Namespace: Rewired.Platforms.Windows.XInput
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class XInputControllerExtension : Controller.Extension // TypeDefIndex: 5837
{
	// Fields
	private XInputControllerExtension.SJUYlFAMJtVrFhCPdjgneRHpmpxpA HMNUqmnhdQauGsKboaMnlgqDnsHo; // 0x28
	private bool bbGPAidqElinvdVHGfoUBjQxJSphA; // 0x30

	// Properties
	private Joystick joystick { get; }
	public int userIndex { get; }
	public CapabilityFlags capabilityFlags { get; }
	public DeviceType deviceType { get; }
	public DeviceSubType deviceSubType { get; }

	// Methods

	// RVA: 0x1908620 Offset: 0x1906C20 VA: 0x181908620
	private Joystick IfZeIPaBsYCBNgUFLveYIJBbVNXCB() { }

	// RVA: 0x1908740 Offset: 0x1906D40 VA: 0x181908740
	internal void .ctor(QEecNmerDwMEXqivTHmSCnnvXaRfA.JFEcxKsSMFqVTiNiUIOzDNWFPHkFA ) { }

	// RVA: 0x17623F0 Offset: 0x17609F0 VA: 0x1817623F0
	private void .ctor(XInputControllerExtension ) { }

	// RVA: 0x1908A50 Offset: 0x1907050 VA: 0x181908A50
	public int get_userIndex() { }

	// RVA: 0x19087B0 Offset: 0x1906DB0 VA: 0x1819087B0
	public CapabilityFlags get_capabilityFlags() { }

	// RVA: 0x1908970 Offset: 0x1906F70 VA: 0x181908970
	public DeviceType get_deviceType() { }

	// RVA: 0x1908890 Offset: 0x1906E90 VA: 0x181908890
	public DeviceSubType get_deviceSubType() { }

	// RVA: 0x1908730 Offset: 0x1906D30 VA: 0x181908730 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1908660 Offset: 0x1906C60 VA: 0x181908660 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x19085C0 Offset: 0x1906BC0 VA: 0x1819085C0 Slot: 7
	internal override Controller.Extension Clone() { }
}

