// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public abstract class CustomControllerExtension : Controller.Extension // TypeDefIndex: 2648
{
	// Fields
	private bool JarExWojqwuaagTUOHDylRweoiUp; // 0x28

	// Methods

	// RVA: 0x17623E0 Offset: 0x17609E0 VA: 0x1817623E0
	public void .ctor(IControllerExtensionSource ) { }

	// RVA: 0x17623F0 Offset: 0x17609F0 VA: 0x1817623F0
	protected void .ctor(CustomControllerExtension ) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected virtual void OnUpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	protected virtual void OnSourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	protected IControllerExtensionSource GetSource() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Controller.Extension ShallowCopy();

	// RVA: 0x14438C0 Offset: 0x1441EC0 VA: 0x1814438C0 Slot: 7
	internal override Controller.Extension Clone() { }

	// RVA: 0x17623A0 Offset: 0x17609A0 VA: 0x1817623A0 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1762380 Offset: 0x1760980 VA: 0x181762380 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }
}

// Namespace: Rewired.ControllerExtensions
public interface IDualSenseExtension : IDualShock4Extension, IControllerVibrator // TypeDefIndex: 2649
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool SetTriggerEffect(DualSenseTriggerType trigger, IDualSenseTriggerEffect effect);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DualSenseTriggerEffectStates GetTriggerEffectStates();
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseTriggerType // TypeDefIndex: 2650
{
	// Fields
	public int value__; // 0x0
	public const DualSenseTriggerType Left = 0;
	public const DualSenseTriggerType Right = 1;
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseMicrophoneLightMode // TypeDefIndex: 2651
{
	// Fields
	public byte value__; // 0x0
	public const DualSenseMicrophoneLightMode Off = 0;
	public const DualSenseMicrophoneLightMode On = 1;
	public const DualSenseMicrophoneLightMode Flash = 2;
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseOtherLightBrightness // TypeDefIndex: 2652
{
	// Fields
	public byte value__; // 0x0
	public const DualSenseOtherLightBrightness Low = 0;
	public const DualSenseOtherLightBrightness Medium = 1;
	public const DualSenseOtherLightBrightness High = 2;
}

// Namespace: Rewired.ControllerExtensions
[Flags]
public enum DualSensePlayerLightFlags // TypeDefIndex: 2653
{
	// Fields
	public byte value__; // 0x0
	public const DualSensePlayerLightFlags None = 0;
	public const DualSensePlayerLightFlags One = 1;
	public const DualSensePlayerLightFlags Two = 2;
	public const DualSensePlayerLightFlags Three = 4;
	public const DualSensePlayerLightFlags Four = 8;
	public const DualSensePlayerLightFlags Five = 16;
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseVibrationMode // TypeDefIndex: 2654
{
	// Fields
	public int value__; // 0x0
	public const DualSenseVibrationMode Advanced = 1;
	public const DualSenseVibrationMode Compatible = 2;
	public const DualSenseVibrationMode Compatible2 = 3;
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class DualSenseExtension : Controller.Extension, IControllerVibrator, IDualShock4Extension, IDualSenseExtension, IHIDControllerExtension // TypeDefIndex: 2656
{
	// Fields
	private DualSenseExtension.TdpwBkFYYJqQGiFLUHTjGJSOuwit BTTdmoCXWWXkJPNRXeKVbkiWCsfs; // 0x28
	private bool LuXduPdmwilQHPrIcfVOnxFhNtUy; // 0x30
	private TimerAbs[] MGaEtggUDUBkPwJJAobnGFFyOFuhA; // 0x38

	// Properties
	private Joystick joystick { get; }
	public int vibrationMotorCount { get; }
	public float lightColorRed { get; set; }
	public float lightColorGreen { get; set; }
	public float lightColorBlue { get; set; }
	public DualSenseMicrophoneLightMode microphoneLightMode { get; set; }
	public DualSenseOtherLightBrightness otherLightBrightness { get; set; }
	public DualSensePlayerLightFlags playerLights { get; set; }
	public int maxTouches { get; }
	public int touchCount { get; }
	public float batteryLevel { get; }
	public bool batteryCharging { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x1763F00 Offset: 0x1762500 VA: 0x181763F00
	private Joystick QIhfcwDZhnEhkHrlbKTwUlXqEnsqb() { }

	// RVA: 0x17658E0 Offset: 0x1763EE0 VA: 0x1817658E0
	internal void .ctor(IDriver_DualSense ) { }

	// RVA: 0x1765780 Offset: 0x1763D80 VA: 0x181765780
	private void .ctor(DualSenseExtension ) { }

	// RVA: 0x1766210 Offset: 0x1764810 VA: 0x181766210 Slot: 8
	public int get_vibrationMotorCount() { }

	// RVA: 0x1765470 Offset: 0x1763A70 VA: 0x181765470 Slot: 9
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x17650B0 Offset: 0x17636B0 VA: 0x1817650B0 Slot: 10
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x1764E60 Offset: 0x1763460 VA: 0x181764E60 Slot: 11
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x17652F0 Offset: 0x17638F0 VA: 0x1817652F0 Slot: 12
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x1763BE0 Offset: 0x17621E0 VA: 0x181763BE0 Slot: 13
	public float GetVibration(int motorIndex) { }

	// RVA: 0x1765580 Offset: 0x1763B80 VA: 0x181765580 Slot: 14
	public void StopVibration() { }

	// RVA: 0x17639C0 Offset: 0x1761FC0 VA: 0x1817639C0
	public DualSenseVibrationMode GetVibrationMode() { }

	// RVA: 0x1764D20 Offset: 0x1763320 VA: 0x181764D20
	public void SetVibrationMode(DualSenseVibrationMode mode) { }

	// RVA: 0x1763A80 Offset: 0x1762080 VA: 0x181763A80
	public float GetVibration(DualShock4MotorType motor) { }

	// RVA: 0x17650D0 Offset: 0x17636D0 VA: 0x1817650D0
	public void SetVibration(DualShock4MotorType motor, float motorLevel) { }

	// RVA: 0x1765430 Offset: 0x1763A30 VA: 0x181765430
	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration) { }

	// RVA: 0x1765450 Offset: 0x1763A50 VA: 0x181765450
	public void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x1764E80 Offset: 0x1763480 VA: 0x181764E80
	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x17650F0 Offset: 0x17636F0 VA: 0x1817650F0 Slot: 31
	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	// RVA: 0x1765110 Offset: 0x1763710 VA: 0x181765110 Slot: 32
	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration) { }

	// RVA: 0x1765D50 Offset: 0x1764350 VA: 0x181765D50
	public float get_lightColorRed() { }

	// RVA: 0x1766460 Offset: 0x1764A60 VA: 0x181766460
	public void set_lightColorRed(float value) { }

	// RVA: 0x1765C80 Offset: 0x1764280 VA: 0x181765C80
	public float get_lightColorGreen() { }

	// RVA: 0x17663F0 Offset: 0x17649F0 VA: 0x1817663F0
	public void set_lightColorGreen(float value) { }

	// RVA: 0x1765BB0 Offset: 0x17641B0 VA: 0x181765BB0
	public float get_lightColorBlue() { }

	// RVA: 0x1766380 Offset: 0x1764980 VA: 0x181766380
	public void set_lightColorBlue(float value) { }

	// RVA: 0x1762DC0 Offset: 0x17613C0 VA: 0x181762DC0
	public Color GetLightColor() { }

	// RVA: 0x17648C0 Offset: 0x1762EC0 VA: 0x1817648C0 Slot: 21
	public void SetLightColor(Color color) { }

	// RVA: 0x1764A20 Offset: 0x1763020 VA: 0x181764A20 Slot: 22
	public void SetLightColor(float red, float green, float blue) { }

	// RVA: 0x1764740 Offset: 0x1762D40 VA: 0x181764740 Slot: 23
	public void SetLightColor(float red, float green, float blue, float intensity) { }

	// RVA: 0x1765EE0 Offset: 0x17644E0 VA: 0x181765EE0
	public DualSenseMicrophoneLightMode get_microphoneLightMode() { }

	// RVA: 0x17664D0 Offset: 0x1764AD0 VA: 0x1817664D0
	public void set_microphoneLightMode(DualSenseMicrophoneLightMode value) { }

	// RVA: 0x1765FB0 Offset: 0x17645B0 VA: 0x181765FB0
	public DualSenseOtherLightBrightness get_otherLightBrightness() { }

	// RVA: 0x17665B0 Offset: 0x1764BB0 VA: 0x1817665B0
	public void set_otherLightBrightness(DualSenseOtherLightBrightness value) { }

	// RVA: 0x1766080 Offset: 0x1764680 VA: 0x181766080
	public DualSensePlayerLightFlags get_playerLights() { }

	// RVA: 0x1766690 Offset: 0x1764C90 VA: 0x181766690
	public void set_playerLights(DualSensePlayerLightFlags value) { }

	// RVA: 0x17625E0 Offset: 0x1760BE0 VA: 0x1817625E0 Slot: 16
	public Vector3 GetAccelerometerValueRaw() { }

	// RVA: 0x1762730 Offset: 0x1760D30 VA: 0x181762730 Slot: 15
	public Vector3 GetAccelerometerValue() { }

	// RVA: 0x1762B20 Offset: 0x1761120 VA: 0x181762B20
	public Vector3 GetLastGyroscopeValueRaw() { }

	// RVA: 0x1762C70 Offset: 0x1761270 VA: 0x181762C70
	public Vector3 GetLastGyroscopeValue() { }

	// RVA: 0x1762880 Offset: 0x1760E80 VA: 0x181762880
	public Vector3 GetGyroscopeValueRaw() { }

	// RVA: 0x17629D0 Offset: 0x1760FD0 VA: 0x1817629D0
	public Vector3 GetGyroscopeValue() { }

	// RVA: 0x1762F40 Offset: 0x1761540 VA: 0x181762F40 Slot: 19
	public Quaternion GetOrientation() { }

	// RVA: 0x1763F40 Offset: 0x1762540 VA: 0x181763F40 Slot: 20
	public void ResetOrientation() { }

	// RVA: 0x1765E20 Offset: 0x1764420 VA: 0x181765E20 Slot: 24
	public int get_maxTouches() { }

	// RVA: 0x1766150 Offset: 0x1764750 VA: 0x181766150 Slot: 25
	public int get_touchCount() { }

	// RVA: 0x17630A0 Offset: 0x17616A0 VA: 0x1817630A0 Slot: 26
	public int GetTouchId(int index) { }

	// RVA: 0x1763720 Offset: 0x1761D20 VA: 0x181763720 Slot: 27
	public bool GetTouchPosition(int index, out Vector2 position) { }

	// RVA: 0x17635B0 Offset: 0x1761BB0 VA: 0x1817635B0 Slot: 28
	public bool GetTouchPositionByTouchId(int touchId, out Vector2 position) { }

	// RVA: 0x17633B0 Offset: 0x17619B0 VA: 0x1817633B0
	public bool GetTouchPositionAbsolute(int index, out Vector2 position) { }

	// RVA: 0x17631B0 Offset: 0x17617B0 VA: 0x1817631B0
	public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position) { }

	// RVA: 0x1763E00 Offset: 0x1762400 VA: 0x181763E00 Slot: 29
	public bool IsTouching(int index) { }

	// RVA: 0x1763D00 Offset: 0x1762300 VA: 0x181763D00 Slot: 30
	public bool IsTouchingByTouchId(int touchId) { }

	// RVA: 0x1765AF0 Offset: 0x17640F0 VA: 0x181765AF0
	public float get_batteryLevel() { }

	// RVA: 0x1765A30 Offset: 0x1764030 VA: 0x181765A30
	public bool get_batteryCharging() { }

	// RVA: 0x1764BD0 Offset: 0x17631D0 VA: 0x181764BD0 Slot: 33
	public bool SetTriggerEffect(DualSenseTriggerType trigger, IDualSenseTriggerEffect effect) { }

	// RVA: 0x1763890 Offset: 0x1761E90 VA: 0x181763890 Slot: 34
	public DualSenseTriggerEffectStates GetTriggerEffectStates() { }

	// RVA: 0x1764150 Offset: 0x1762750 VA: 0x181764150 Slot: 18
	private Vector3 Rewired.ControllerExtensions.IDualShock4Extension.GetGyroscopeValue() { }

	// RVA: 0x1764000 Offset: 0x1762600 VA: 0x181764000 Slot: 17
	private Vector3 Rewired.ControllerExtensions.IDualShock4Extension.GetGyroscopeValueRaw() { }

	// RVA: 0x1764680 Offset: 0x1762C80 VA: 0x181764680 Slot: 35
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x1764370 Offset: 0x1762970 VA: 0x181764370 Slot: 36
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x1764430 Offset: 0x1762A30 VA: 0x181764430 Slot: 37
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x17642A0 Offset: 0x17628A0 VA: 0x1817642A0 Slot: 38
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x1764500 Offset: 0x1762B00 VA: 0x181764500 Slot: 39
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x17645C0 Offset: 0x1762BC0 VA: 0x1817645C0 Slot: 40
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x17656C0 Offset: 0x1763CC0 VA: 0x1817656C0 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1765490 Offset: 0x1763A90 VA: 0x181765490 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x1762580 Offset: 0x1760B80 VA: 0x181762580 Slot: 7
	internal override Controller.Extension Clone() { }

	// RVA: 0x1766770 Offset: 0x1764D70 VA: 0x181766770
	private void wVIenXtOstLcYcoAVvYkHyeUtbBJ() { }

	// RVA: 0x17662B0 Offset: 0x17648B0 VA: 0x1817662B0
	private void pFxhxDxypCKkziWOWEjZmLjWKQMs(DualShock4MotorType , float , float ) { }
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseTriggerEffectType // TypeDefIndex: 2657
{
	// Fields
	public int value__; // 0x0
	public const DualSenseTriggerEffectType Off = 0;
	public const DualSenseTriggerEffectType Feedback = 1;
	public const DualSenseTriggerEffectType Weapon = 2;
	public const DualSenseTriggerEffectType Vibration = 3;
	public const DualSenseTriggerEffectType MultiplePositionFeedback = 4;
	public const DualSenseTriggerEffectType SlopeFeedback = 5;
	public const DualSenseTriggerEffectType MultiplePositionVibration = 6;
}

// Namespace: Rewired.ControllerExtensions
public enum DualSenseTriggerEffectState // TypeDefIndex: 2658
{
	// Fields
	public int value__; // 0x0
	public const DualSenseTriggerEffectState Unknown = -1;
	public const DualSenseTriggerEffectState Off = 0;
	public const DualSenseTriggerEffectState FeedbackIdle = 1;
	public const DualSenseTriggerEffectState FeedbackApplyingForce = 2;
	public const DualSenseTriggerEffectState WeaponIdle = 3;
	public const DualSenseTriggerEffectState WeaponFiring = 4;
	public const DualSenseTriggerEffectState WeaponFired = 5;
	public const DualSenseTriggerEffectState VibrationIdle = 6;
	public const DualSenseTriggerEffectState VibrationVibrating = 7;
}

// Namespace: Rewired.ControllerExtensions
public struct DualSenseTriggerEffectStates // TypeDefIndex: 2659
{
	// Fields
	public DualSenseTriggerEffectState leftTrigger; // 0x0
	public DualSenseTriggerEffectState rightTrigger; // 0x4
}

// Namespace: Rewired.ControllerExtensions
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False)]
internal static class DualSenseTriggerEffect // TypeDefIndex: 2660
{
	// Fields
	public const byte strengthMin = 0;
	public const byte strengthMax = 8;
	public const byte amplitudeMin = 0;
	public const byte amplitudeMax = 8;
	public const byte frequencyMin = 0;
	public const byte frequencyMax = 255;
	public const byte positionCount = 10;
	public const byte positionMin = 0;
	public const byte positionMax = 9;

	// Methods

	// RVA: 0x1767260 Offset: 0x1765860 VA: 0x181767260
	internal static bool IsInRange(byte value, byte min, byte max) { }

	// RVA: 0x1767200 Offset: 0x1765800 VA: 0x181767200
	internal static byte Clamp(byte value, byte min, byte max) { }

	// RVA: 0x1767300 Offset: 0x1765900 VA: 0x181767300
	internal static float NormalizeStrength(byte value) { }

	// RVA: 0x1767340 Offset: 0x1765940 VA: 0x181767340
	internal static float NormalizePosition(byte value) { }

	// RVA: 0x1767300 Offset: 0x1765900 VA: 0x181767300
	internal static float NormalizeAmplitude(byte value) { }

	// RVA: 0x1767320 Offset: 0x1765920 VA: 0x181767320
	internal static float NormalizeFrequency(byte value) { }

	// RVA: 0x1767360 Offset: 0x1765960 VA: 0x181767360
	internal static void ThrowArgumentOutOfRange(string name, byte min, byte max) { }

	// RVA: 0x1767270 Offset: 0x1765870 VA: 0x181767270
	internal static void LogValueClamped(byte origValue, byte clampedValue) { }
}

// Namespace: Rewired.ControllerExtensions
[DefaultMember("Item")]
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectPositionValueSet // TypeDefIndex: 2661
{
	// Fields
	public const int Count = 10;
	[SerializeField]
	private byte _position0; // 0x0
	[SerializeField]
	private byte _position1; // 0x1
	[SerializeField]
	private byte _position2; // 0x2
	[SerializeField]
	private byte _position3; // 0x3
	[SerializeField]
	private byte _position4; // 0x4
	[SerializeField]
	private byte _position5; // 0x5
	[SerializeField]
	private byte _position6; // 0x6
	[SerializeField]
	private byte _position7; // 0x7
	[SerializeField]
	private byte _position8; // 0x8
	[SerializeField]
	private byte _position9; // 0x9

	// Properties
	public byte Item { get; set; }

	// Methods

	// RVA: 0x1766B50 Offset: 0x1765150 VA: 0x181766B50
	public void .ctor(IList<byte> ) { }

	// RVA: 0x1766D60 Offset: 0x1765360 VA: 0x181766D60
	public byte get_Item(int index) { }

	// RVA: 0x1766F30 Offset: 0x1765530 VA: 0x181766F30
	public void set_Item(int index, byte value) { }

	// RVA: 0x1766AF0 Offset: 0x17650F0 VA: 0x181766AF0
	public byte[] ToArray() { }

	// RVA: 0x1766950 Offset: 0x1764F50 VA: 0x181766950
	public void CopyTo(byte[] destination) { }

	// RVA: 0x1766E60 Offset: 0x1765460 VA: 0x181766E60
	internal void lHBtWWYytYPUOxSazrIdkBPHZYjk(byte , byte ) { }
}

// Namespace: Rewired.ControllerExtensions
public interface IDualSenseTriggerEffect // TypeDefIndex: 2662
{
	// Properties
	public abstract DualSenseTriggerEffectType triggerEffectType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DualSenseTriggerEffectType get_triggerEffectType();
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectOff : IDualSenseTriggerEffect // TypeDefIndex: 2663
{
	// Properties
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectFeedback : IDualSenseTriggerEffect // TypeDefIndex: 2664
{
	// Fields
	[SerializeField]
	private byte _position; // 0x0
	[SerializeField]
	private byte _strength; // 0x1

	// Properties
	public byte position { get; set; }
	public byte strength { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public byte get_position() { }

	// RVA: 0x1766810 Offset: 0x1764E10 VA: 0x181766810
	public void set_position(byte value) { }

	// RVA: 0x12B1970 Offset: 0x12AFF70 VA: 0x1812B1970
	public byte get_strength() { }

	// RVA: 0x1766840 Offset: 0x1764E40 VA: 0x181766840
	public void set_strength(byte value) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectWeapon : IDualSenseTriggerEffect // TypeDefIndex: 2665
{
	// Fields
	[SerializeField]
	private byte _startPosition; // 0x0
	[SerializeField]
	private byte _endPosition; // 0x1
	[SerializeField]
	private byte _strength; // 0x2

	// Properties
	public byte startPosition { get; set; }
	public byte endPosition { get; set; }
	public byte strength { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public byte get_startPosition() { }

	// RVA: 0x1767170 Offset: 0x1765770 VA: 0x181767170
	public void set_startPosition(byte value) { }

	// RVA: 0x12B1970 Offset: 0x12AFF70 VA: 0x1812B1970
	public byte get_endPosition() { }

	// RVA: 0x1767120 Offset: 0x1765720 VA: 0x181767120
	public void set_endPosition(byte value) { }

	// RVA: 0x157D110 Offset: 0x157B710 VA: 0x18157D110
	public byte get_strength() { }

	// RVA: 0x17671C0 Offset: 0x17657C0 VA: 0x1817671C0
	public void set_strength(byte value) { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectVibration : IDualSenseTriggerEffect // TypeDefIndex: 2666
{
	// Fields
	[SerializeField]
	private byte _position; // 0x0
	[SerializeField]
	private byte _amplitude; // 0x1
	[SerializeField]
	private byte _frequency; // 0x2

	// Properties
	public byte position { get; set; }
	public byte amplitude { get; set; }
	public byte frequency { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public byte get_position() { }

	// RVA: 0x1766810 Offset: 0x1764E10 VA: 0x181766810
	public void set_position(byte value) { }

	// RVA: 0x12B1970 Offset: 0x12AFF70 VA: 0x1812B1970
	public byte get_amplitude() { }

	// RVA: 0x1766840 Offset: 0x1764E40 VA: 0x181766840
	public void set_amplitude(byte value) { }

	// RVA: 0x157D110 Offset: 0x157B710 VA: 0x18157D110
	public byte get_frequency() { }

	// RVA: 0x1767110 Offset: 0x1765710 VA: 0x181767110
	public void set_frequency(byte value) { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectMultiplePositionFeedback : IDualSenseTriggerEffect // TypeDefIndex: 2667
{
	// Fields
	[SerializeField]
	private DualSenseTriggerEffectPositionValueSet _strength; // 0x0

	// Properties
	public DualSenseTriggerEffectPositionValueSet strength { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0x1766880 Offset: 0x1764E80 VA: 0x181766880
	public DualSenseTriggerEffectPositionValueSet get_strength() { }

	// RVA: 0x17668A0 Offset: 0x1764EA0 VA: 0x1817668A0
	public void set_strength(DualSenseTriggerEffectPositionValueSet value) { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectSlopeFeedback : IDualSenseTriggerEffect // TypeDefIndex: 2668
{
	// Fields
	[SerializeField]
	private byte _startPosition; // 0x0
	[SerializeField]
	private byte _endPosition; // 0x1
	[SerializeField]
	private byte _startStrength; // 0x2
	[SerializeField]
	private byte _endStrength; // 0x3

	// Properties
	public byte startPosition { get; set; }
	public byte endPosition { get; set; }
	public byte startStrength { get; set; }
	public byte endStrength { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public byte get_startPosition() { }

	// RVA: 0x1766810 Offset: 0x1764E10 VA: 0x181766810
	public void set_startPosition(byte value) { }

	// RVA: 0x12B1970 Offset: 0x12AFF70 VA: 0x1812B1970
	public byte get_endPosition() { }

	// RVA: 0x1767030 Offset: 0x1765630 VA: 0x181767030
	public void set_endPosition(byte value) { }

	// RVA: 0x157D110 Offset: 0x157B710 VA: 0x18157D110
	public byte get_startStrength() { }

	// RVA: 0x17670C0 Offset: 0x17656C0 VA: 0x1817670C0
	public void set_startStrength(byte value) { }

	// RVA: 0x58E950 Offset: 0x58CF50 VA: 0x18058E950
	public byte get_endStrength() { }

	// RVA: 0x1767070 Offset: 0x1765670 VA: 0x181767070
	public void set_endStrength(byte value) { }

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
[Preserve]
[Serializable]
public struct DualSenseTriggerEffectMultiplePositionVibration : IDualSenseTriggerEffect // TypeDefIndex: 2669
{
	// Fields
	[SerializeField]
	private byte _frequency; // 0x0
	[SerializeField]
	private DualSenseTriggerEffectPositionValueSet _amplitude; // 0x1

	// Properties
	public byte frequency { get; set; }
	public DualSenseTriggerEffectPositionValueSet amplitude { get; set; }
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.triggerEffectType { get; }

	// Methods

	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	public byte get_frequency() { }

	// RVA: 0x1766940 Offset: 0x1764F40 VA: 0x181766940
	public void set_frequency(byte value) { }

	// RVA: 0x17668E0 Offset: 0x1764EE0 VA: 0x1817668E0
	public DualSenseTriggerEffectPositionValueSet get_amplitude() { }

	// RVA: 0x1766900 Offset: 0x1764F00 VA: 0x181766900
	public void set_amplitude(DualSenseTriggerEffectPositionValueSet value) { }

	// RVA: 0x45C3F0 Offset: 0x45A9F0 VA: 0x18045C3F0 Slot: 4
	private DualSenseTriggerEffectType Rewired.ControllerExtensions.IDualSenseTriggerEffect.get_triggerEffectType() { }
}

// Namespace: Rewired.ControllerExtensions
public interface IDualShock4Extension : IControllerVibrator // TypeDefIndex: 2670
{
	// Properties
	public abstract int maxTouches { get; }
	public abstract int touchCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 GetAccelerometerValue();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 GetAccelerometerValueRaw();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector3 GetGyroscopeValueRaw();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Vector3 GetGyroscopeValue();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Quaternion GetOrientation();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ResetOrientation();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetLightColor(Color color);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetLightColor(float red, float green, float blue);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetLightColor(float red, float green, float blue, float intensity);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_maxTouches();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_touchCount();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetTouchId(int index);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool GetTouchPosition(int index, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool GetTouchPositionByTouchId(int touchId, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool IsTouching(int index);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool IsTouchingByTouchId(int touchId);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetVibration(float leftMotorLevel, float rightMotorLevel);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration);
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class DualShock4Extension : Controller.Extension, IControllerVibrator, IDualShock4Extension, IHIDControllerExtension // TypeDefIndex: 2672
{
	// Fields
	private DualShock4Extension.FZpRLExJBKdgsATbfaIHyLtDylLE zFueLdGGnKyMDivOuTOnLzSZAHvS; // 0x28
	private bool XlXdTQkLOkIqGqUIOBZOwDdlcaro; // 0x30
	private TimerAbs[] RlJwhbDpaywQRwLZRpyozttyoFPR; // 0x38

	// Properties
	private Joystick joystick { get; }
	public int vibrationMotorCount { get; }
	public float lightColorRed { get; set; }
	public float lightColorGreen { get; set; }
	public float lightColorBlue { get; set; }
	public int maxTouches { get; }
	public int touchCount { get; }
	public float batteryLevel { get; }
	public bool batteryCharging { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x176ADC0 Offset: 0x17693C0 VA: 0x18176ADC0
	private Joystick tDgFqlaYitvyJSSZaBQXwOEPehVxA() { }

	// RVA: 0x176A3C0 Offset: 0x17689C0 VA: 0x18176A3C0
	internal void .ctor(IDriver_DualShock4 ) { }

	// RVA: 0x176A500 Offset: 0x1768B00 VA: 0x18176A500
	private void .ctor(DualShock4Extension ) { }

	// RVA: 0x176ABD0 Offset: 0x17691D0 VA: 0x18176ABD0 Slot: 8
	public int get_vibrationMotorCount() { }

	// RVA: 0x1769DE0 Offset: 0x17683E0 VA: 0x181769DE0 Slot: 9
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x1769A30 Offset: 0x1768030 VA: 0x181769A30 Slot: 10
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x17699F0 Offset: 0x1767FF0 VA: 0x1817699F0 Slot: 11
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x1769CA0 Offset: 0x17682A0 VA: 0x181769CA0 Slot: 12
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x17687A0 Offset: 0x1766DA0 VA: 0x1817687A0 Slot: 13
	public float GetVibration(int motorIndex) { }

	// RVA: 0x176A1C0 Offset: 0x17687C0 VA: 0x18176A1C0 Slot: 14
	public void StopVibration() { }

	// RVA: 0x17688C0 Offset: 0x1766EC0 VA: 0x1817688C0
	public float GetVibration(DualShock4MotorType motor) { }

	// RVA: 0x1769E00 Offset: 0x1768400 VA: 0x181769E00
	public void SetVibration(DualShock4MotorType motor, float motorLevel) { }

	// RVA: 0x17699D0 Offset: 0x1767FD0 VA: 0x1817699D0
	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration) { }

	// RVA: 0x1769C80 Offset: 0x1768280 VA: 0x181769C80
	public void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x1769A50 Offset: 0x1768050 VA: 0x181769A50
	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x1769A10 Offset: 0x1768010 VA: 0x181769A10 Slot: 31
	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	// RVA: 0x1769E20 Offset: 0x1768420 VA: 0x181769E20 Slot: 32
	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration) { }

	// RVA: 0x176A980 Offset: 0x1768F80 VA: 0x18176A980
	public float get_lightColorRed() { }

	// RVA: 0x176AD50 Offset: 0x1769350 VA: 0x18176AD50
	public void set_lightColorRed(float value) { }

	// RVA: 0x176A8B0 Offset: 0x1768EB0 VA: 0x18176A8B0
	public float get_lightColorGreen() { }

	// RVA: 0x176ACE0 Offset: 0x17692E0 VA: 0x18176ACE0
	public void set_lightColorGreen(float value) { }

	// RVA: 0x176A7E0 Offset: 0x1768DE0 VA: 0x18176A7E0
	public float get_lightColorBlue() { }

	// RVA: 0x176AC70 Offset: 0x1769270 VA: 0x18176AC70
	public void set_lightColorBlue(float value) { }

	// RVA: 0x1767CD0 Offset: 0x17662D0 VA: 0x181767CD0
	public Color GetLightColor() { }

	// RVA: 0x17695D0 Offset: 0x1767BD0 VA: 0x1817695D0 Slot: 21
	public void SetLightColor(Color color) { }

	// RVA: 0x1769420 Offset: 0x1767A20 VA: 0x181769420 Slot: 22
	public void SetLightColor(float red, float green, float blue) { }

	// RVA: 0x1769730 Offset: 0x1767D30 VA: 0x181769730 Slot: 23
	public void SetLightColor(float red, float green, float blue, float intensity) { }

	// RVA: 0x17698B0 Offset: 0x1767EB0 VA: 0x1817698B0
	public void SetLightFlash(float onDuration, float offDuration) { }

	// RVA: 0x176A0F0 Offset: 0x17686F0 VA: 0x18176A0F0
	public void StopLightFlash() { }

	// RVA: 0x17674F0 Offset: 0x1765AF0 VA: 0x1817674F0 Slot: 16
	public Vector3 GetAccelerometerValueRaw() { }

	// RVA: 0x1767640 Offset: 0x1765C40 VA: 0x181767640 Slot: 15
	public Vector3 GetAccelerometerValue() { }

	// RVA: 0x1767A30 Offset: 0x1766030 VA: 0x181767A30
	public Vector3 GetLastGyroscopeValueRaw() { }

	// RVA: 0x1767B80 Offset: 0x1766180 VA: 0x181767B80
	public Vector3 GetLastGyroscopeValue() { }

	// RVA: 0x1767790 Offset: 0x1765D90 VA: 0x181767790
	public Vector3 GetGyroscopeValueRaw() { }

	// RVA: 0x17678E0 Offset: 0x1765EE0 VA: 0x1817678E0
	public Vector3 GetGyroscopeValue() { }

	// RVA: 0x1767E50 Offset: 0x1766450 VA: 0x181767E50 Slot: 19
	public Quaternion GetOrientation() { }

	// RVA: 0x1768C20 Offset: 0x1767220 VA: 0x181768C20 Slot: 20
	public void ResetOrientation() { }

	// RVA: 0x176AA50 Offset: 0x1769050 VA: 0x18176AA50 Slot: 24
	public int get_maxTouches() { }

	// RVA: 0x176AB10 Offset: 0x1769110 VA: 0x18176AB10 Slot: 25
	public int get_touchCount() { }

	// RVA: 0x1767FB0 Offset: 0x17665B0 VA: 0x181767FB0 Slot: 26
	public int GetTouchId(int index) { }

	// RVA: 0x1768630 Offset: 0x1766C30 VA: 0x181768630 Slot: 27
	public bool GetTouchPosition(int index, out Vector2 position) { }

	// RVA: 0x17684C0 Offset: 0x1766AC0 VA: 0x1817684C0 Slot: 28
	public bool GetTouchPositionByTouchId(int touchId, out Vector2 position) { }

	// RVA: 0x17682C0 Offset: 0x17668C0 VA: 0x1817682C0
	public bool GetTouchPositionAbsolute(int index, out Vector2 position) { }

	// RVA: 0x17680C0 Offset: 0x17666C0 VA: 0x1817680C0
	public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position) { }

	// RVA: 0x1768B20 Offset: 0x1767120 VA: 0x181768B20 Slot: 29
	public bool IsTouching(int index) { }

	// RVA: 0x1768A20 Offset: 0x1767020 VA: 0x181768A20 Slot: 30
	public bool IsTouchingByTouchId(int touchId) { }

	// RVA: 0x176A720 Offset: 0x1768D20 VA: 0x18176A720
	public float get_batteryLevel() { }

	// RVA: 0x176A660 Offset: 0x1768C60 VA: 0x18176A660
	public bool get_batteryCharging() { }

	// RVA: 0x1768E30 Offset: 0x1767430 VA: 0x181768E30 Slot: 18
	private Vector3 Rewired.ControllerExtensions.IDualShock4Extension.GetGyroscopeValue() { }

	// RVA: 0x1768CE0 Offset: 0x17672E0 VA: 0x181768CE0 Slot: 17
	private Vector3 Rewired.ControllerExtensions.IDualShock4Extension.GetGyroscopeValueRaw() { }

	// RVA: 0x1769360 Offset: 0x1767960 VA: 0x181769360 Slot: 33
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x1769050 Offset: 0x1767650 VA: 0x181769050 Slot: 34
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x1769110 Offset: 0x1767710 VA: 0x181769110 Slot: 35
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x1768F80 Offset: 0x1767580 VA: 0x181768F80 Slot: 36
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x17691E0 Offset: 0x17677E0 VA: 0x1817691E0 Slot: 37
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x17692A0 Offset: 0x17678A0 VA: 0x1817692A0 Slot: 38
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x176A300 Offset: 0x1768900 VA: 0x18176A300 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x176A000 Offset: 0x1768600 VA: 0x18176A000 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x1767490 Offset: 0x1765A90 VA: 0x181767490 Slot: 7
	internal override Controller.Extension Clone() { }

	// RVA: 0x176AE00 Offset: 0x1769400 VA: 0x18176AE00
	private void vbBGUhPnfjfvzPmUaOHmNgBfmpKM() { }

	// RVA: 0x176AEA0 Offset: 0x17694A0 VA: 0x18176AEA0
	private void zVAdggKMXQFskGQJcoTyOmKLVkorA(DualShock4MotorType , float , float ) { }
}

// Namespace: Rewired.ControllerExtensions
public enum DualShock4MotorType // TypeDefIndex: 2673
{
	// Fields
	public int value__; // 0x0
	public const DualShock4MotorType LeftMotor = 0;
	public const DualShock4MotorType StrongMotor = 0;
	public const DualShock4MotorType RightMotor = 1;
	public const DualShock4MotorType WeakMotor = 1;
}

// Namespace: Rewired.ControllerExtensions
public interface IHIDControllerExtension // TypeDefIndex: 2674
{
	// Properties
	public abstract ushort vendorId { get; }
	public abstract ushort productId { get; }
	public abstract string productName { get; }
	public abstract string manufacturer { get; }
	public abstract ushort usagePage { get; }
	public abstract ushort usage { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ushort get_vendorId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ushort get_productId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_productName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_manufacturer();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ushort get_usagePage();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ushort get_usage();
}

// Namespace: Rewired.ControllerExtensions
[Serializable]
public struct NintendoSwitchGamepadVibration : IEquatable<NintendoSwitchGamepadVibration> // TypeDefIndex: 2675
{
	// Fields
	internal const int frequencyLowDefault = 160;
	internal const int frequencyHighDefault = 320;
	public const float frequencyLowMin = 40.875885;
	public const float frequencyLowMax = 626.28613;
	public const float frequencyHighMin = 81.75177;
	public const float frequencyHighMax = 1252.5723;
	[FieldRange(0, 1)]
	public float amplitudeLow; // 0x0
	[FieldRange(40.875885, 626.28613)]
	public float frequencyLow; // 0x4
	[FieldRange(0, 1)]
	public float amplitudeHigh; // 0x8
	[FieldRange(81.75177, 1252.5723)]
	public float frequencyHigh; // 0xC

	// Properties
	internal static NintendoSwitchGamepadVibration OcABJLJZvfPkXcqjaGNJVDiirSdoA { get; }

	// Methods

	// RVA: 0x177A530 Offset: 0x1778B30 VA: 0x18177A530
	internal void .ctor(float , float , float , float ) { }

	// RVA: 0x177A1C0 Offset: 0x17787C0 VA: 0x18177A1C0 Slot: 4
	public bool Equals(NintendoSwitchGamepadVibration other) { }

	// RVA: 0x177A200 Offset: 0x1778800 VA: 0x18177A200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x177A2C0 Offset: 0x17788C0 VA: 0x18177A2C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x177A1C0 Offset: 0x17787C0 VA: 0x18177A1C0
	public static bool op_Equality(NintendoSwitchGamepadVibration a, NintendoSwitchGamepadVibration b) { }

	// RVA: 0x177A590 Offset: 0x1778B90 VA: 0x18177A590
	public static bool op_Inequality(NintendoSwitchGamepadVibration a, NintendoSwitchGamepadVibration b) { }

	// RVA: 0x177A330 Offset: 0x1778930 VA: 0x18177A330 Slot: 3
	public override string ToString() { }

	// RVA: 0x86A2C0 Offset: 0x8688C0 VA: 0x18086A2C0
	internal static NintendoSwitchGamepadVibration BMrUCQdohvDDlgoXWIjqodEbfWGoA() { }

	// RVA: 0x177A1A0 Offset: 0x17787A0 VA: 0x18177A1A0
	public static NintendoSwitchGamepadVibration Create() { }

	// RVA: 0x177A100 Offset: 0x1778700 VA: 0x18177A100
	public static NintendoSwitchGamepadVibration Create(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) { }

	// RVA: 0x177A160 Offset: 0x1778760 VA: 0x18177A160
	public static NintendoSwitchGamepadVibration Create(float amplitudeLow, float amplitudeHigh) { }
}

// Namespace: Rewired.ControllerExtensions
public enum NintendoSwitchJoyConType // TypeDefIndex: 2676
{
	// Fields
	public int value__; // 0x0
	public const NintendoSwitchJoyConType Left = 0;
	public const NintendoSwitchJoyConType Right = 1;
}

// Namespace: Rewired.ControllerExtensions
public enum NintendoSwitchJoyConGripStyle // TypeDefIndex: 2677
{
	// Fields
	public int value__; // 0x0
	public const NintendoSwitchJoyConGripStyle Vertical = 0;
	public const NintendoSwitchJoyConGripStyle Horizontal = 1;
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public abstract class NintendoSwitchGamepadExtension : Controller.Extension, IControllerVibrator, IHIDControllerExtension // TypeDefIndex: 2679
{
	// Fields
	private NintendoSwitchGamepadExtension.ExtSource_Base HIAOLRKKoTjvhfzIadJoFaDKrjGW; // 0x28
	private bool yjoQkrShssApbZBjuCcVbAIDQtnBb; // 0x30

	// Properties
	protected bool isValid { get; }
	protected Joystick joystick { get; }
	protected object source { get; }
	public int vibrationMotorCount { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	protected bool get_isValid() { }

	// RVA: 0x177A000 Offset: 0x1778600 VA: 0x18177A000
	protected Joystick get_joystick() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	protected object get_source() { }

	// RVA: 0x17623E0 Offset: 0x17609E0 VA: 0x1817623E0
	internal void .ctor(NintendoSwitchGamepadExtension.ExtSource_Base ) { }

	// RVA: 0x17623F0 Offset: 0x17609F0 VA: 0x1817623F0
	protected void .ctor(NintendoSwitchGamepadExtension ) { }

	// RVA: 0x177A040 Offset: 0x1778640 VA: 0x18177A040 Slot: 8
	public int get_vibrationMotorCount() { }

	// RVA: 0x1778C60 Offset: 0x1777260 VA: 0x181778C60
	public NintendoSwitchGamepadVibration GetVibration(int motorIndex) { }

	// RVA: 0x1779C60 Offset: 0x1778260 VA: 0x181779C60
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) { }

	// RVA: 0x17793C0 Offset: 0x17779C0 VA: 0x1817793C0
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, bool stopOtherMotors) { }

	// RVA: 0x17799F0 Offset: 0x1777FF0 VA: 0x1817799F0
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration) { }

	// RVA: 0x1779630 Offset: 0x1777C30 VA: 0x181779630
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration, bool stopOtherMotors) { }

	// RVA: 0x1779500 Offset: 0x1777B00 VA: 0x181779500
	public void SetVibration(int motorIndex, NintendoSwitchGamepadVibration vibration) { }

	// RVA: 0x1779B30 Offset: 0x1778130 VA: 0x181779B30
	public void SetVibration(int motorIndex, NintendoSwitchGamepadVibration vibration, float duration) { }

	// RVA: 0x17798B0 Offset: 0x1777EB0 VA: 0x1817798B0
	public void SetVibration(int motorIndex, NintendoSwitchGamepadVibration vibration, float duration, bool stopOtherMotors) { }

	// RVA: 0x1779780 Offset: 0x1777D80 VA: 0x181779780
	public void SetVibration(int motorIndex, NintendoSwitchGamepadVibration vibration, bool stopOtherMotors) { }

	// RVA: 0x1779F30 Offset: 0x1778530 VA: 0x181779F30
	public void StopVibration(int motorIndex) { }

	// RVA: 0x1779E70 Offset: 0x1778470 VA: 0x181779E70 Slot: 14
	public void StopVibration() { }

	// RVA: 0x1779340 Offset: 0x1777940 VA: 0x181779340 Slot: 9
	private void Rewired.Interfaces.IControllerVibrator.SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x1779380 Offset: 0x1777980 VA: 0x181779380 Slot: 10
	private void Rewired.Interfaces.IControllerVibrator.SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x1779340 Offset: 0x1777940 VA: 0x181779340 Slot: 11
	private void Rewired.Interfaces.IControllerVibrator.SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x1779380 Offset: 0x1777980 VA: 0x181779380 Slot: 12
	private void Rewired.Interfaces.IControllerVibrator.SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x1779310 Offset: 0x1777910 VA: 0x181779310 Slot: 13
	private float Rewired.Interfaces.IControllerVibrator.GetVibration(int motorIndex) { }

	// RVA: 0x1779250 Offset: 0x1777850 VA: 0x181779250 Slot: 15
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x1778F40 Offset: 0x1777540 VA: 0x181778F40 Slot: 16
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x1779000 Offset: 0x1777600 VA: 0x181779000 Slot: 17
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x1778E70 Offset: 0x1777470 VA: 0x181778E70 Slot: 18
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x17790D0 Offset: 0x17776D0 VA: 0x1817790D0 Slot: 19
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x1779190 Offset: 0x1777790 VA: 0x181779190 Slot: 20
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1779D80 Offset: 0x1778380 VA: 0x181779D80 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class NintendoSwitchProControllerExtension : NintendoSwitchGamepadExtension, IControllerVibrator, IHIDControllerExtension // TypeDefIndex: 2681
{
	// Fields
	public int motorIndexLeft; // 0x38
	public int motorIndexRight; // 0x3C

	// Properties
	private NintendoSwitchProControllerExtension.XKxwQWuPaoDZdaSSpDORniWLmzRnA source { get; }

	// Methods

	// RVA: 0x177ACE0 Offset: 0x17792E0 VA: 0x18177ACE0
	private NintendoSwitchProControllerExtension.XKxwQWuPaoDZdaSSpDORniWLmzRnA qpDWKrZSfnrExvRfYTjnjvPYvnrA() { }

	// RVA: 0x177AC60 Offset: 0x1779260 VA: 0x18177AC60
	internal void .ctor(IDriver_NintendoSwitchProController ) { }

	// RVA: 0x177AC50 Offset: 0x1779250 VA: 0x18177AC50
	private void .ctor(NintendoSwitchProControllerExtension ) { }

	// RVA: 0x177ABF0 Offset: 0x17791F0 VA: 0x18177ABF0 Slot: 7
	internal override Controller.Extension Clone() { }
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class NintendoSwitchJoyConExtension : NintendoSwitchGamepadExtension, IControllerVibrator, IHIDControllerExtension, IAxisCalibrationIndexMap // TypeDefIndex: 2683
{
	// Properties
	private NintendoSwitchJoyConExtension.kkauNtuyeXRYdhayjRZhNEdoiQiO source { get; }
	public NintendoSwitchJoyConType joyConType { get; }
	public NintendoSwitchJoyConGripStyle joyConGripStyle { get; set; }

	// Methods

	// RVA: 0x177A7D0 Offset: 0x1778DD0 VA: 0x18177A7D0
	private NintendoSwitchJoyConExtension.kkauNtuyeXRYdhayjRZhNEdoiQiO HkRzuRWHRrACxjFDGPSyZjGzofeBb() { }

	// RVA: 0x177A860 Offset: 0x1778E60 VA: 0x18177A860
	internal void .ctor(IDriver_NintendoSwitchJoyCon ) { }

	// RVA: 0x17623F0 Offset: 0x17609F0 VA: 0x1817623F0
	private void .ctor(NintendoSwitchJoyConExtension ) { }

	// RVA: 0x177A9E0 Offset: 0x1778FE0 VA: 0x18177A9E0
	public NintendoSwitchJoyConType get_joyConType() { }

	// RVA: 0x177A8E0 Offset: 0x1778EE0 VA: 0x18177A8E0
	public NintendoSwitchJoyConGripStyle get_joyConGripStyle() { }

	// RVA: 0x177AAE0 Offset: 0x17790E0 VA: 0x18177AAE0
	public void set_joyConGripStyle(NintendoSwitchJoyConGripStyle value) { }

	// RVA: 0x177A650 Offset: 0x1778C50 VA: 0x18177A650 Slot: 21
	private int DOWYuuCxLopzemsHPrmQQzDXGEZO(int ) { }

	// RVA: 0x177A5F0 Offset: 0x1778BF0 VA: 0x18177A5F0 Slot: 7
	internal override Controller.Extension Clone() { }
}

// Namespace: Rewired.ControllerExtensions
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
public sealed class RailDriverExtension : Controller.Extension, IHIDControllerExtension // TypeDefIndex: 2685
{
	// Fields
	private RailDriverExtension.LCVyxVtTEqVKmsMbLGDenKslHvWd AXrvFTqBBRyTLCTKRVgJDWCNOaDw; // 0x28

	// Properties
	private Joystick joystick { get; }
	public bool speakerEnabled { get; set; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x1781210 Offset: 0x177F810 VA: 0x181781210
	private Joystick rOnsLBfZRFmZVHceWHLruolYCcOaA() { }

	// RVA: 0x17810D0 Offset: 0x177F6D0 VA: 0x1817810D0
	internal void .ctor(IDriver_RailDriver ) { }

	// RVA: 0x17623F0 Offset: 0x17609F0 VA: 0x1817623F0
	private void .ctor(RailDriverExtension ) { }

	// RVA: 0x1781150 Offset: 0x177F750 VA: 0x181781150
	public bool get_speakerEnabled() { }

	// RVA: 0x1781250 Offset: 0x177F850 VA: 0x181781250
	public void set_speakerEnabled(bool value) { }

	// RVA: 0x1780D00 Offset: 0x177F300 VA: 0x181780D00
	public void SetLEDDisplay(int digitIndex, byte digitBitValues) { }

	// RVA: 0x1780E80 Offset: 0x177F480 VA: 0x181780E80
	public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues) { }

	// RVA: 0x1780C40 Offset: 0x177F240 VA: 0x181780C40 Slot: 8
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x1780930 Offset: 0x177EF30 VA: 0x181780930 Slot: 9
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x17809F0 Offset: 0x177EFF0 VA: 0x1817809F0 Slot: 10
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x1780860 Offset: 0x177EE60 VA: 0x181780860 Slot: 11
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x1780AC0 Offset: 0x177F0C0 VA: 0x181780AC0 Slot: 12
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x1780B80 Offset: 0x177F180 VA: 0x181780B80 Slot: 13
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1781000 Offset: 0x177F600 VA: 0x181781000 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x1780800 Offset: 0x177EE00 VA: 0x181780800 Slot: 7
	internal override Controller.Extension Clone() { }
}

// Namespace: Rewired.ControllerExtensions
[CustomObfuscation(rename = False)]
internal enum SteamControllerPadType // TypeDefIndex: 2686
{
	// Fields
	public uint value__; // 0x0
	public const SteamControllerPadType Left = 0;
	public const SteamControllerPadType Right = 1;
}

// Namespace: Rewired.ControllerExtensions
[CustomObfuscation(rename = False)]
internal enum SteamControllerActionOrigin // TypeDefIndex: 2687
{
	// Fields
	public int value__; // 0x0
	public const SteamControllerActionOrigin None = 0;
	public const SteamControllerActionOrigin A = 1;
	public const SteamControllerActionOrigin B = 2;
	public const SteamControllerActionOrigin X = 3;
	public const SteamControllerActionOrigin Y = 4;
	public const SteamControllerActionOrigin LeftBumper = 5;
	public const SteamControllerActionOrigin RightBumper = 6;
	public const SteamControllerActionOrigin LeftGrip = 7;
	public const SteamControllerActionOrigin RightGrip = 8;
	public const SteamControllerActionOrigin Start = 9;
	public const SteamControllerActionOrigin Back = 10;
	public const SteamControllerActionOrigin LeftPad_Touch = 11;
	public const SteamControllerActionOrigin LeftPad_Swipe = 12;
	public const SteamControllerActionOrigin LeftPad_Click = 13;
	public const SteamControllerActionOrigin LeftPad_DPadNorth = 14;
	public const SteamControllerActionOrigin LeftPad_DPadSouth = 15;
	public const SteamControllerActionOrigin LeftPad_DPadWest = 16;
	public const SteamControllerActionOrigin LeftPad_DPadEast = 17;
	public const SteamControllerActionOrigin RightPad_Touch = 18;
	public const SteamControllerActionOrigin RightPad_Swipe = 19;
	public const SteamControllerActionOrigin RightPad_Click = 20;
	public const SteamControllerActionOrigin RightPad_DPadNorth = 21;
	public const SteamControllerActionOrigin RightPad_DPadSouth = 22;
	public const SteamControllerActionOrigin RightPad_DPadWest = 23;
	public const SteamControllerActionOrigin RightPad_DPadEast = 24;
	public const SteamControllerActionOrigin LeftTrigger_Pull = 25;
	public const SteamControllerActionOrigin LeftTrigger_Click = 26;
	public const SteamControllerActionOrigin RightTrigger_Pull = 27;
	public const SteamControllerActionOrigin RightTrigger_Click = 28;
	public const SteamControllerActionOrigin LeftStick_Move = 29;
	public const SteamControllerActionOrigin LeftStick_Click = 30;
	public const SteamControllerActionOrigin LeftStick_DPadNorth = 31;
	public const SteamControllerActionOrigin LeftStick_DPadSouth = 32;
	public const SteamControllerActionOrigin LeftStick_DPadWest = 33;
	public const SteamControllerActionOrigin LeftStick_DPadEast = 34;
	public const SteamControllerActionOrigin Gyro_Move = 35;
	public const SteamControllerActionOrigin Gyro_Pitch = 36;
	public const SteamControllerActionOrigin Gyro_Yaw = 37;
	public const SteamControllerActionOrigin Gyro_Roll = 38;
	public const SteamControllerActionOrigin PS4_X = 39;
	public const SteamControllerActionOrigin PS4_Circle = 40;
	public const SteamControllerActionOrigin PS4_Triangle = 41;
	public const SteamControllerActionOrigin PS4_Square = 42;
	public const SteamControllerActionOrigin PS4_LeftBumper = 43;
	public const SteamControllerActionOrigin PS4_RightBumper = 44;
	public const SteamControllerActionOrigin PS4_Options = 45;
	public const SteamControllerActionOrigin PS4_Share = 46;
	public const SteamControllerActionOrigin PS4_LeftPad_Touch = 47;
	public const SteamControllerActionOrigin PS4_LeftPad_Swipe = 48;
	public const SteamControllerActionOrigin PS4_LeftPad_Click = 49;
	public const SteamControllerActionOrigin PS4_LeftPad_DPadNorth = 50;
	public const SteamControllerActionOrigin PS4_LeftPad_DPadSouth = 51;
	public const SteamControllerActionOrigin PS4_LeftPad_DPadWest = 52;
	public const SteamControllerActionOrigin PS4_LeftPad_DPadEast = 53;
	public const SteamControllerActionOrigin PS4_RightPad_Touch = 54;
	public const SteamControllerActionOrigin PS4_RightPad_Swipe = 55;
	public const SteamControllerActionOrigin PS4_RightPad_Click = 56;
	public const SteamControllerActionOrigin PS4_RightPad_DPadNorth = 57;
	public const SteamControllerActionOrigin PS4_RightPad_DPadSouth = 58;
	public const SteamControllerActionOrigin PS4_RightPad_DPadWest = 59;
	public const SteamControllerActionOrigin PS4_RightPad_DPadEast = 60;
	public const SteamControllerActionOrigin PS4_CenterPad_Touch = 61;
	public const SteamControllerActionOrigin PS4_CenterPad_Swipe = 62;
	public const SteamControllerActionOrigin PS4_CenterPad_Click = 63;
	public const SteamControllerActionOrigin PS4_CenterPad_DPadNorth = 64;
	public const SteamControllerActionOrigin PS4_CenterPad_DPadSouth = 65;
	public const SteamControllerActionOrigin PS4_CenterPad_DPadWest = 66;
	public const SteamControllerActionOrigin PS4_CenterPad_DPadEast = 67;
	public const SteamControllerActionOrigin PS4_LeftTrigger_Pull = 68;
	public const SteamControllerActionOrigin PS4_LeftTrigger_Click = 69;
	public const SteamControllerActionOrigin PS4_RightTrigger_Pull = 70;
	public const SteamControllerActionOrigin PS4_RightTrigger_Click = 71;
	public const SteamControllerActionOrigin PS4_LeftStick_Move = 72;
	public const SteamControllerActionOrigin PS4_LeftStick_Click = 73;
	public const SteamControllerActionOrigin PS4_LeftStick_DPadNorth = 74;
	public const SteamControllerActionOrigin PS4_LeftStick_DPadSouth = 75;
	public const SteamControllerActionOrigin PS4_LeftStick_DPadWest = 76;
	public const SteamControllerActionOrigin PS4_LeftStick_DPadEast = 77;
	public const SteamControllerActionOrigin PS4_RightStick_Move = 78;
	public const SteamControllerActionOrigin PS4_RightStick_Click = 79;
	public const SteamControllerActionOrigin PS4_RightStick_DPadNorth = 80;
	public const SteamControllerActionOrigin PS4_RightStick_DPadSouth = 81;
	public const SteamControllerActionOrigin PS4_RightStick_DPadWest = 82;
	public const SteamControllerActionOrigin PS4_RightStick_DPadEast = 83;
	public const SteamControllerActionOrigin PS4_DPad_North = 84;
	public const SteamControllerActionOrigin PS4_DPad_South = 85;
	public const SteamControllerActionOrigin PS4_DPad_West = 86;
	public const SteamControllerActionOrigin PS4_DPad_East = 87;
	public const SteamControllerActionOrigin PS4_Gyro_Move = 88;
	public const SteamControllerActionOrigin PS4_Gyro_Pitch = 89;
	public const SteamControllerActionOrigin PS4_Gyro_Yaw = 90;
	public const SteamControllerActionOrigin PS4_Gyro_Roll = 91;
	public const SteamControllerActionOrigin XBoxOne_A = 92;
	public const SteamControllerActionOrigin XBoxOne_B = 93;
	public const SteamControllerActionOrigin XBoxOne_X = 94;
	public const SteamControllerActionOrigin XBoxOne_Y = 95;
	public const SteamControllerActionOrigin XBoxOne_LeftBumper = 96;
	public const SteamControllerActionOrigin XBoxOne_RightBumper = 97;
	public const SteamControllerActionOrigin XBoxOne_Menu = 98;
	public const SteamControllerActionOrigin XBoxOne_View = 99;
	public const SteamControllerActionOrigin XBoxOne_LeftTrigger_Pull = 100;
	public const SteamControllerActionOrigin XBoxOne_LeftTrigger_Click = 101;
	public const SteamControllerActionOrigin XBoxOne_RightTrigger_Pull = 102;
	public const SteamControllerActionOrigin XBoxOne_RightTrigger_Click = 103;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_Move = 104;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_Click = 105;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_DPadNorth = 106;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_DPadSouth = 107;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_DPadWest = 108;
	public const SteamControllerActionOrigin XBoxOne_LeftStick_DPadEast = 109;
	public const SteamControllerActionOrigin XBoxOne_RightStick_Move = 110;
	public const SteamControllerActionOrigin XBoxOne_RightStick_Click = 111;
	public const SteamControllerActionOrigin XBoxOne_RightStick_DPadNorth = 112;
	public const SteamControllerActionOrigin XBoxOne_RightStick_DPadSouth = 113;
	public const SteamControllerActionOrigin XBoxOne_RightStick_DPadWest = 114;
	public const SteamControllerActionOrigin XBoxOne_RightStick_DPadEast = 115;
	public const SteamControllerActionOrigin XBoxOne_DPad_North = 116;
	public const SteamControllerActionOrigin XBoxOne_DPad_South = 117;
	public const SteamControllerActionOrigin XBoxOne_DPad_West = 118;
	public const SteamControllerActionOrigin XBoxOne_DPad_East = 119;
	public const SteamControllerActionOrigin XBox360_A = 120;
	public const SteamControllerActionOrigin XBox360_B = 121;
	public const SteamControllerActionOrigin XBox360_X = 122;
	public const SteamControllerActionOrigin XBox360_Y = 123;
	public const SteamControllerActionOrigin XBox360_LeftBumper = 124;
	public const SteamControllerActionOrigin XBox360_RightBumper = 125;
	public const SteamControllerActionOrigin XBox360_Start = 126;
	public const SteamControllerActionOrigin XBox360_Back = 127;
	public const SteamControllerActionOrigin XBox360_LeftTrigger_Pull = 128;
	public const SteamControllerActionOrigin XBox360_LeftTrigger_Click = 129;
	public const SteamControllerActionOrigin XBox360_RightTrigger_Pull = 130;
	public const SteamControllerActionOrigin XBox360_RightTrigger_Click = 131;
	public const SteamControllerActionOrigin XBox360_LeftStick_Move = 132;
	public const SteamControllerActionOrigin XBox360_LeftStick_Click = 133;
	public const SteamControllerActionOrigin XBox360_LeftStick_DPadNorth = 134;
	public const SteamControllerActionOrigin XBox360_LeftStick_DPadSouth = 135;
	public const SteamControllerActionOrigin XBox360_LeftStick_DPadWest = 136;
	public const SteamControllerActionOrigin XBox360_LeftStick_DPadEast = 137;
	public const SteamControllerActionOrigin XBox360_RightStick_Move = 138;
	public const SteamControllerActionOrigin XBox360_RightStick_Click = 139;
	public const SteamControllerActionOrigin XBox360_RightStick_DPadNorth = 140;
	public const SteamControllerActionOrigin XBox360_RightStick_DPadSouth = 141;
	public const SteamControllerActionOrigin XBox360_RightStick_DPadWest = 142;
	public const SteamControllerActionOrigin XBox360_RightStick_DPadEast = 143;
	public const SteamControllerActionOrigin XBox360_DPad_North = 144;
	public const SteamControllerActionOrigin XBox360_DPad_South = 145;
	public const SteamControllerActionOrigin XBox360_DPad_West = 146;
	public const SteamControllerActionOrigin XBox360_DPad_East = 147;
	public const SteamControllerActionOrigin SteamV2_A = 148;
	public const SteamControllerActionOrigin SteamV2_B = 149;
	public const SteamControllerActionOrigin SteamV2_X = 150;
	public const SteamControllerActionOrigin SteamV2_Y = 151;
	public const SteamControllerActionOrigin SteamV2_LeftBumper = 152;
	public const SteamControllerActionOrigin SteamV2_RightBumper = 153;
	public const SteamControllerActionOrigin SteamV2_LeftGrip = 154;
	public const SteamControllerActionOrigin SteamV2_RightGrip = 155;
	public const SteamControllerActionOrigin SteamV2_LeftGrip_Upper = 156;
	public const SteamControllerActionOrigin SteamV2_RightGrip_Upper = 157;
	public const SteamControllerActionOrigin SteamV2_LeftBumper_Pressure = 158;
	public const SteamControllerActionOrigin SteamV2_RightBumper_Pressure = 159;
	public const SteamControllerActionOrigin SteamV2_LeftGrip_Pressure = 160;
	public const SteamControllerActionOrigin SteamV2_RightGrip_Pressure = 161;
	public const SteamControllerActionOrigin SteamV2_LeftGrip_Upper_Pressure = 162;
	public const SteamControllerActionOrigin SteamV2_RightGrip_Upper_Pressure = 163;
	public const SteamControllerActionOrigin SteamV2_Start = 164;
	public const SteamControllerActionOrigin SteamV2_Back = 165;
	public const SteamControllerActionOrigin SteamV2_LeftPad_Touch = 166;
	public const SteamControllerActionOrigin SteamV2_LeftPad_Swipe = 167;
	public const SteamControllerActionOrigin SteamV2_LeftPad_Click = 168;
	public const SteamControllerActionOrigin SteamV2_LeftPad_Pressure = 169;
	public const SteamControllerActionOrigin SteamV2_LeftPad_DPadNorth = 170;
	public const SteamControllerActionOrigin SteamV2_LeftPad_DPadSouth = 171;
	public const SteamControllerActionOrigin SteamV2_LeftPad_DPadWest = 172;
	public const SteamControllerActionOrigin SteamV2_LeftPad_DPadEast = 173;
	public const SteamControllerActionOrigin SteamV2_RightPad_Touch = 174;
	public const SteamControllerActionOrigin SteamV2_RightPad_Swipe = 175;
	public const SteamControllerActionOrigin SteamV2_RightPad_Click = 176;
	public const SteamControllerActionOrigin SteamV2_RightPad_Pressure = 177;
	public const SteamControllerActionOrigin SteamV2_RightPad_DPadNorth = 178;
	public const SteamControllerActionOrigin SteamV2_RightPad_DPadSouth = 179;
	public const SteamControllerActionOrigin SteamV2_RightPad_DPadWest = 180;
	public const SteamControllerActionOrigin SteamV2_RightPad_DPadEast = 181;
	public const SteamControllerActionOrigin SteamV2_LeftTrigger_Pull = 182;
	public const SteamControllerActionOrigin SteamV2_LeftTrigger_Click = 183;
	public const SteamControllerActionOrigin SteamV2_RightTrigger_Pull = 184;
	public const SteamControllerActionOrigin SteamV2_RightTrigger_Click = 185;
	public const SteamControllerActionOrigin SteamV2_LeftStick_Move = 186;
	public const SteamControllerActionOrigin SteamV2_LeftStick_Click = 187;
	public const SteamControllerActionOrigin SteamV2_LeftStick_DPadNorth = 188;
	public const SteamControllerActionOrigin SteamV2_LeftStick_DPadSouth = 189;
	public const SteamControllerActionOrigin SteamV2_LeftStick_DPadWest = 190;
	public const SteamControllerActionOrigin SteamV2_LeftStick_DPadEast = 191;
	public const SteamControllerActionOrigin SteamV2_Gyro_Move = 192;
	public const SteamControllerActionOrigin SteamV2_Gyro_Pitch = 193;
	public const SteamControllerActionOrigin SteamV2_Gyro_Yaw = 194;
	public const SteamControllerActionOrigin SteamV2_Gyro_Roll = 195;
	public const SteamControllerActionOrigin Count = 196;
}

// Namespace: Rewired.ControllerExtensions
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class SteamControllerExtension : Controller.Extension // TypeDefIndex: 2689
{
	// Fields
	private SteamControllerExtension.NcoItSJQEOPxcOrwnCSdEquNiegt xTBWLcMzSiuAlxEdkFLQdMhyeeFab; // 0x28

	// Properties
	private Joystick joystick { get; }
	internal ISteamControllerInternal internalController { get; }

	// Methods

	// RVA: 0x1782CD0 Offset: 0x17812D0 VA: 0x181782CD0
	private Joystick dMAMtBKnUNQuudnpFbNUGDvfjnBK() { }

	// RVA: 0x1782D10 Offset: 0x1781310 VA: 0x181782D10
	internal ISteamControllerInternal get_internalController() { }

	// RVA: 0x1782C50 Offset: 0x1781250 VA: 0x181782C50
	internal void .ctor(ISteamControllerInternal ) { }

	// RVA: 0x17623F0 Offset: 0x17609F0 VA: 0x1817623F0
	private void .ctor(SteamControllerExtension ) { }

	// RVA: 0x1781430 Offset: 0x177FA30 VA: 0x181781430
	public ulong GetActionSetHandle(string actionSetName) { }

	// RVA: 0x1781840 Offset: 0x177FE40 VA: 0x181781840
	public ulong GetAnalogActionHandle(string actionName) { }

	// RVA: 0x1781FB0 Offset: 0x17805B0 VA: 0x181781FB0
	public ulong GetDigitalActionHandle(string actionName) { }

	// RVA: 0x1781560 Offset: 0x177FB60 VA: 0x181781560
	public string GetActionSetName(ulong actionSetHandle) { }

	// RVA: 0x1781970 Offset: 0x177FF70 VA: 0x181781970
	public string GetAnalogActionName(ulong actionHandle) { }

	// RVA: 0x17820E0 Offset: 0x17806E0 VA: 0x1817820E0
	public string GetDigitalActionName(ulong actionHandle) { }

	// RVA: 0x1781CB0 Offset: 0x17802B0 VA: 0x181781CB0
	public Vector2 GetAnalogActionValue(string actionName) { }

	// RVA: 0x1781E30 Offset: 0x1780430 VA: 0x181781E30
	public Vector2 GetAnalogActionValue(ulong actionHandle) { }

	// RVA: 0x17824F0 Offset: 0x1780AF0 VA: 0x1817824F0
	public bool GetDigitalActionValue(string actionName) { }

	// RVA: 0x1782420 Offset: 0x1780A20 VA: 0x181782420
	public bool GetDigitalActionValue(ulong actionHandle) { }

	// RVA: 0x1782750 Offset: 0x1780D50 VA: 0x181782750
	public bool SetActiveActionSet(ulong actionSetHandle) { }

	// RVA: 0x1782620 Offset: 0x1780C20 VA: 0x181782620
	public bool SetActiveActionSet(string actionSetName) { }

	// RVA: 0x1781640 Offset: 0x177FC40 VA: 0x181781640
	public ulong GetActiveActionSetHandle() { }

	// RVA: 0x1781770 Offset: 0x177FD70 VA: 0x181781770
	public string GetActiveActionSetName() { }

	// RVA: 0x1782AC0 Offset: 0x17810C0 VA: 0x181782AC0
	public void ShowBindingPanel() { }

	// RVA: 0x1782820 Offset: 0x1780E20 VA: 0x181782820
	public void SetHapticPulse(SteamControllerPadType targePad, float durationSeconds) { }

	// RVA: 0x1782970 Offset: 0x1780F70 VA: 0x181782970
	public void SetHapticPulse(SteamControllerPadType targePad, ushort durationMicroSeconds) { }

	// RVA: 0x17821C0 Offset: 0x17807C0 VA: 0x1817821C0
	public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(string actionSetName, string actionName) { }

	// RVA: 0x1782320 Offset: 0x1780920 VA: 0x181782320
	public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle) { }

	// RVA: 0x1781A50 Offset: 0x1780050 VA: 0x181781A50
	public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(string actionSetName, string actionName) { }

	// RVA: 0x1781BB0 Offset: 0x17801B0 VA: 0x181781BB0
	public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	internal override void UpdateData(UpdateLoopType updateLoop) { }

	// RVA: 0x1782B80 Offset: 0x1781180 VA: 0x181782B80 Slot: 5
	internal override void SourceUpdated(IControllerExtensionSource source) { }

	// RVA: 0x17813D0 Offset: 0x177F9D0 VA: 0x1817813D0 Slot: 7
	internal override Controller.Extension Clone() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void EIjlUbRKgNsAlJoKTSElPtZFXRjk() { }
}

