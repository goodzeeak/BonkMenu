// Namespace: Rewired.Platforms.XboxOne
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IXboxOneInputSource // TypeDefIndex: 2252
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool SetXboxOneVibration(ulong xboxOneJoystickId, qLJFBgiKLIprSOWlnupLPXiABOCWA vibration);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration);
}

// Namespace: Rewired.Platforms.XboxOne
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class XboxOneGamepadExtension : Controller.Extension, IControllerVibrator // TypeDefIndex: 2254
{
	// Fields
	private XboxOneGamepadExtension.FiwNzBaDIxCuGxOWguVKZIDqTpro wMlezCAFMTVSqNFTRKxnpRucdKCFb; // 0x28
	private TimerAbs[] TMEHNAcAjxTdwcdDgdGThStTAfehb; // 0x30

	// Properties
	private Joystick joystick { get; }
	public int xboxOneUserId { get; }
	public ulong xboxOneJoystickId { get; }
	public int vibrationMotorCount { get; }

	// Methods

	// RVA: 0x16FDED0 Offset: 0x16FC4D0 VA: 0x1816FDED0
	private Joystick KZHZyNuUtwbQNgkMOiplBSbguXsF() { }

	// RVA: 0x16FEFF0 Offset: 0x16FD5F0 VA: 0x1816FEFF0
	public int get_xboxOneUserId() { }

	// RVA: 0x16FEEB0 Offset: 0x16FD4B0 VA: 0x1816FEEB0
	public ulong get_xboxOneJoystickId() { }

	// RVA: 0x16FEB30 Offset: 0x16FD130 VA: 0x1816FEB30
	internal void .ctor(bool , IXboxOneInputSource ) { }

	// RVA: 0x16FEC80 Offset: 0x16FD280 VA: 0x1816FEC80
	private void .ctor(XboxOneGamepadExtension ) { }

	// RVA: 0x16FEE20 Offset: 0x16FD420 VA: 0x1816FEE20 Slot: 8
	public int get_vibrationMotorCount() { }

	// RVA: 0x16FE4B0 Offset: 0x16FCAB0 VA: 0x1816FE4B0 Slot: 9
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x16FE490 Offset: 0x16FCA90 VA: 0x1816FE490 Slot: 10
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x16FE230 Offset: 0x16FC830 VA: 0x1816FE230 Slot: 11
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x16FE840 Offset: 0x16FCE40 VA: 0x1816FE840 Slot: 12
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x16FDC70 Offset: 0x16FC270 VA: 0x1816FDC70 Slot: 13
	public float GetVibration(int motorIndex) { }

	// RVA: 0x16FDD70 Offset: 0x16FC370 VA: 0x1816FDD70
	public float GetVibration(XboxOneGamepadMotorType motor) { }

	// RVA: 0x16FEA40 Offset: 0x16FD040 VA: 0x1816FEA40 Slot: 14
	public void StopVibration() { }

	// RVA: 0x16FE4D0 Offset: 0x16FCAD0 VA: 0x1816FE4D0
	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel) { }

	// RVA: 0x16FE210 Offset: 0x16FC810 VA: 0x1816FE210
	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration) { }

	// RVA: 0x16FE270 Offset: 0x16FC870 VA: 0x1816FE270
	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x16FE290 Offset: 0x16FC890 VA: 0x1816FE290
	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x16FE250 Offset: 0x16FC850 VA: 0x1816FE250
	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	// RVA: 0x16FE4F0 Offset: 0x16FCAF0 VA: 0x1816FE4F0
	public void SetVibration(float leftMotorLevel, float rightMotorLevel, bool stopOtherMotors) { }

	// RVA: 0x16FE6A0 Offset: 0x16FCCA0 VA: 0x1816FE6A0
	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftTriggerLevel, float rightTriggerLevel) { }

	// RVA: 0x16FE040 Offset: 0x16FC640 VA: 0x1816FE040
	public void PulseVibrateMotor(XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration) { }

	// RVA: 0x16FDBE0 Offset: 0x16FC1E0 VA: 0x1816FDBE0 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x16FE970 Offset: 0x16FCF70 VA: 0x1816FE970 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x16FDB10 Offset: 0x16FC110 VA: 0x1816FDB10 Slot: 7
	internal override Controller.Extension Clone() { }

	// RVA: 0x16FDBE0 Offset: 0x16FC1E0 VA: 0x1816FDBE0
	private void GNXBuQXqZBHFlUtasGepeqReuyYq() { }

	// RVA: 0x16FED20 Offset: 0x16FD320 VA: 0x1816FED20
	private void bhzdsTjThvFhcdyrlGeSPiHmaUbTA(XboxOneGamepadMotorType , float , float ) { }

	// RVA: 0x16FDF10 Offset: 0x16FC510 VA: 0x1816FDF10
	private void KukABWcGYWJzFZniUcTfmQlHLUqPA() { }
}

// Namespace: Rewired.Platforms.XboxOne
public enum XboxOneGamepadMotorType // TypeDefIndex: 2255
{
	// Fields
	public int value__; // 0x0
	public const XboxOneGamepadMotorType LeftMotor = 0;
	public const XboxOneGamepadMotorType RightMotor = 1;
	public const XboxOneGamepadMotorType LeftTriggerMotor = 2;
	public const XboxOneGamepadMotorType RightTriggerMotor = 3;
}

// Namespace: Rewired.Platforms.XboxOne
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal sealed class XboxOneInputSource : CustomInputSource, IXboxOneInputSource // TypeDefIndex: 2260
{
	// Fields
	private const int nhujktiewWTfgJNNaQDQnWkMWUxp = 8;
	private readonly bool OSPAKwBGcaasuKRXcTuCJUeVAXLDb; // 0x58
	private bool dZxuzhAONxSMjuFPBkAnrTrOGutq; // 0x59
	private Queue<XboxOneInputSource.miyZWpTlfrgbhFZVVSteyfKElQFk> aqWeUmtECYdudspjGXTtDOEQvmtb; // 0x60
	private bool cQhLNWpAXerbuNDCvjEvQCWGDGfkA; // 0x68

	// Properties
	public override bool isReady { get; }

	// Methods

	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80 Slot: 12
	public override bool get_isReady() { }

	// RVA: 0x16FFA50 Offset: 0x16FE050 VA: 0x1816FFA50
	public void .ctor() { }

	// RVA: 0x16FF740 Offset: 0x16FDD40 VA: 0x1816FF740 Slot: 13
	public override void Update() { }

	// RVA: 0x16FFEB0 Offset: 0x16FE4B0 VA: 0x1816FFEB0
	private void mkNoGLrhcBOSfLMkhquGygDBoZND(uint , bool ) { }

	// RVA: 0x1700190 Offset: 0x16FE790 VA: 0x181700190
	private void yqveSxebtWOqsfzAFWabBazIgaHTC(uint , bool ) { }

	// RVA: 0x1700020 Offset: 0x16FE620 VA: 0x181700020
	private void pCLgbWZqCuOSeruyAByqkOrSjOMc() { }

	// RVA: 0x16FFC70 Offset: 0x16FE270 VA: 0x1816FFC70
	private bool efnHwcbKDCWnNazvCwXjafdsdsIEA(uint , bool , out XboxOneInputSource.BadConnectionReason ) { }

	// RVA: 0x16FFA00 Offset: 0x16FE000 VA: 0x1816FFA00
	private void ZSoHjLYDMGIwhtcEJahsebdSRPUr() { }

	// RVA: 0x16FF350 Offset: 0x16FD950 VA: 0x1816FF350 Slot: 14
	public int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId) { }

	// RVA: 0x16FF460 Offset: 0x16FDA60 VA: 0x1816FF460 Slot: 16
	public void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration) { }

	// RVA: 0x16FF5E0 Offset: 0x16FDBE0 VA: 0x1816FF5E0 Slot: 15
	public bool SetXboxOneVibration(ulong xboxOneJoystickId, qLJFBgiKLIprSOWlnupLPXiABOCWA vibration) { }

	// RVA: 0x16FF150 Offset: 0x16FD750 VA: 0x1816FF150 Slot: 10
	public override void Dispose() { }

	// RVA: 0x16FF2E0 Offset: 0x16FD8E0 VA: 0x1816FF2E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x16FF200 Offset: 0x16FD800 VA: 0x1816FF200 Slot: 11
	protected override void Dispose(bool disposing) { }
}

