// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerDriver // TypeDefIndex: 2195
{
	// Properties
	public abstract int AxisCount { get; }
	public abstract int ButtonCount { get; }
	public abstract int HatCount { get; }
	public abstract int AccelerometerCount { get; }
	public abstract int GyroscopeCount { get; }
	public abstract int TouchpadCount { get; }
	public abstract int LightCount { get; }
	public abstract int VibrationMotorCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_AxisCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ButtonCount();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_HatCount();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_AccelerometerCount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_GyroscopeCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_TouchpadCount();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_LightCount();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_VibrationMotorCount();
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IDriver_DualShock4 : IControllerDriver, IHIDControllerExtension // TypeDefIndex: 2196
{
	// Properties
	public abstract float BatteryLevel { get; }
	public abstract bool BatteryCharging { get; }
	public abstract float LeftMotor { get; set; }
	public abstract float RightMotor { get; set; }
	public abstract float LightColorR { get; set; }
	public abstract float LightColorG { get; set; }
	public abstract float LightColorB { get; set; }
	public abstract float LightFlashOnDuration { get; set; }
	public abstract float LightFlashOffDuration { get; set; }
	public abstract Vector3 AccelerometerValue { get; }
	public abstract Vector3 AccelerometerValueRaw { get; }
	public abstract Vector3 GyroscopeValue { get; }
	public abstract Vector3 GyroscopeValueRaw { get; }
	public abstract Vector3 LastGyroscopeValue { get; }
	public abstract Vector3 LastGyroscopeValueRaw { get; }
	public abstract Quaternion Orientation { get; }
	public abstract int MaxTouches { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_BatteryLevel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_BatteryCharging();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_LeftMotor();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_LeftMotor(float value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_RightMotor();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_RightMotor(float value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_LightColorR();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_LightColorR(float value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_LightColorG();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_LightColorG(float value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float get_LightColorB();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_LightColorB(float value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float get_LightFlashOnDuration();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_LightFlashOnDuration(float value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float get_LightFlashOffDuration();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_LightFlashOffDuration(float value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Vector3 get_AccelerometerValue();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Vector3 get_AccelerometerValueRaw();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Vector3 get_GyroscopeValue();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Vector3 get_GyroscopeValueRaw();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Vector3 get_LastGyroscopeValue();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract Vector3 get_LastGyroscopeValueRaw();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Quaternion get_Orientation();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void ResetOrientation();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int get_MaxTouches();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int GetTouchCount();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool IsTouchingAtTouchId(int touchId);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool IsTouchingAtIndex(int index);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int GetTouchIdAtIndex(int index);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool GetTouchPositionByIndex(int index, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool GetTouchPositionByTouchId(int touchId, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void StopLightFlash();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void StopVibration();
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IDriver_DualSense : IControllerDriver, IHIDControllerExtension // TypeDefIndex: 2197
{
	// Properties
	public abstract float BatteryLevel { get; }
	public abstract bool BatteryCharging { get; }
	public abstract DualSenseVibrationMode vibrationMode { get; set; }
	public abstract float LeftMotor { get; set; }
	public abstract float RightMotor { get; set; }
	public abstract float LightColorR { get; set; }
	public abstract float LightColorG { get; set; }
	public abstract float LightColorB { get; set; }
	public abstract float LightFlashOnDuration { get; set; }
	public abstract float LightFlashOffDuration { get; set; }
	public abstract DualSenseMicrophoneLightMode microphoneLightMode { get; set; }
	public abstract DualSenseOtherLightBrightness otherLightBrightness { get; set; }
	public abstract DualSensePlayerLightFlags playerLights { get; set; }
	public abstract Vector3 AccelerometerValue { get; }
	public abstract Vector3 AccelerometerValueRaw { get; }
	public abstract Vector3 GyroscopeValue { get; }
	public abstract Vector3 GyroscopeValueRaw { get; }
	public abstract Vector3 LastGyroscopeValue { get; }
	public abstract Vector3 LastGyroscopeValueRaw { get; }
	public abstract Quaternion Orientation { get; }
	public abstract int MaxTouches { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_BatteryLevel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_BatteryCharging();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DualSenseVibrationMode get_vibrationMode();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_vibrationMode(DualSenseVibrationMode value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_LeftMotor();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_LeftMotor(float value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_RightMotor();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_RightMotor(float value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_LightColorR();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_LightColorR(float value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float get_LightColorG();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_LightColorG(float value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float get_LightColorB();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_LightColorB(float value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float get_LightFlashOnDuration();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_LightFlashOnDuration(float value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract float get_LightFlashOffDuration();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void set_LightFlashOffDuration(float value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract DualSenseMicrophoneLightMode get_microphoneLightMode();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void set_microphoneLightMode(DualSenseMicrophoneLightMode value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract DualSenseOtherLightBrightness get_otherLightBrightness();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void set_otherLightBrightness(DualSenseOtherLightBrightness value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract DualSensePlayerLightFlags get_playerLights();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_playerLights(DualSensePlayerLightFlags value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Vector3 get_AccelerometerValue();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Vector3 get_AccelerometerValueRaw();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract Vector3 get_GyroscopeValue();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Vector3 get_GyroscopeValueRaw();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract Vector3 get_LastGyroscopeValue();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Vector3 get_LastGyroscopeValueRaw();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Quaternion get_Orientation();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void ResetOrientation();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int get_MaxTouches();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetTouchCount();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract bool IsTouchingAtTouchId(int touchId);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract bool IsTouchingAtIndex(int index);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract int GetTouchIdAtIndex(int index);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract bool GetTouchPositionByIndex(int index, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract bool GetTouchPositionByTouchId(int touchId, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract void StopLightFlash();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract void StopVibration();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract bool SetTriggerEffect(DualSenseTriggerType trigger, IDualSenseTriggerEffect effect);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract DualSenseTriggerEffectStates GetTriggerEffectStates();
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IDriver_RailDriver : IControllerDriver, IHIDControllerExtension // TypeDefIndex: 2198
{
	// Properties
	public abstract bool SpeakerEnabled { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_SpeakerEnabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_SpeakerEnabled(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetLEDDisplay(int digitIndex, byte digitBitValues);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues);
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IDriver_NintendoSwitchController : IControllerDriver, IHIDControllerExtension // TypeDefIndex: 2199
{
	// Properties
	public abstract int vibrationMotorCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_vibrationMotorCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void GetVibration(int motorIndex, out float amplitudeLow, out float frequencyLow, out float amplitudeHigh, out float frequencyHigh);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, bool stopOtherMotors);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration, bool stopOtherMotors);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StopVibration(int motorIndex);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void StopVibration();
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IDriver_NintendoSwitchJoyCon : IDriver_NintendoSwitchController, IControllerDriver, IHIDControllerExtension, IAxisCalibrationIndexMap // TypeDefIndex: 2200
{
	// Properties
	public abstract NintendoSwitchJoyConType joyConType { get; }
	public abstract NintendoSwitchJoyConGripStyle joyConGripStyle { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NintendoSwitchJoyConType get_joyConType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract NintendoSwitchJoyConGripStyle get_joyConGripStyle();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_joyConGripStyle(NintendoSwitchJoyConGripStyle value);
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IDriver_NintendoSwitchProController : IDriver_NintendoSwitchController, IControllerDriver, IHIDControllerExtension // TypeDefIndex: 2201
{}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal class DualSenseDriver : HIDDeviceDriver, IDriver_DualSense, IControllerDriver, IHIDControllerExtension, IDisposable // TypeDefIndex: 6525
{
	// Fields
	private const float zrFUOqqmZrAefNrQRZBRwqkjHrVd = 4;
	private const int zMZxUDphhPifhFdjuvhTLJOMKEGKA = 15;
	private const int FCJMbVDVguqmvOJXIAfCeFBwluGnA = 2;
	private const int wKBgYAjCeehdrjNTkIUxbYGdeBfQB = 0;
	private const int bHyrjZnChKMHtIfvCEFhAKPwzHEq = 1912;
	private const int dyTXinVDLQjyyFRYEntyCQtYcKVy = 0;
	private const int UPCEeHcmKQOHOdCXlOTYNhjTvSHs = 941;
	private const bool IuICIlvtArimNlqpjfuFoyTLBVYA = False;
	private const bool DEDzXrVHZReXBNvUFMnfnKvieTwK = True;
	private const float svNtkeaQfZOxuRXBWygbDHOjixtv = 2.5;
	private const int uyitKJtckkpRIGCvzbtBHMMvdAvVA = 0;
	private const int hIpCDZhWblvCrgweqXGEZxuBBPEB = 0;
	private const int mfwAXqClMMmlGKdpZYxUcEjBSTqW = 1;
	private const int FfaeLmeAmTEXCfOQZngKdiZtXzis = 0;
	private const int FRdegIINLPhJxmQpCUORsEUNgBrP = 0;
	private const int KYwchsZHsZvPrYKYharIJGAlwLZN = 0;
	private const int dcbhByuwGlaACfUgGZkyDPvYuKjJ = 1;
	private const int UdjjCvHdcrybtGFTennchIfDyPuNb = 49;
	private const int mYAfcEKxOLlBVcvPjhAMTEizrHYMA = 0;
	private const int RgnumyFeRYXIwPtXernpIfqspdSn = 1;
	private const int kUlTXwrnequDcUwbgeuvwVFTjMrE = 64;
	private const int ifSGXgQnqxFOuIMuVREeViPTDYLdb = 48;
	private const int ChZpTqWZcEMOaXkoOpMOEnnryacg = 78;
	private const int giokaFeqvTvMppEFhFRObhIODvyyA = 5;
	private const int SDmqPhBcpWrdOqfzRheUErmrWTCc = 41;
	private const byte ZEBpCSpTyfZgAMoeUOSqMEFmMaSF = 1;
	private const byte fZkYblqHvLDKkHckHnVCCOfAvYlac = 2;
	private const int xNEQWgLUlgepnnERwGavOzLidkAX = 1;
	private const int WevhFHxkxYKAxpvejEaZpwZKpaZf = 2;
	private const int lteCatvtcNwGEZvfsXoXsbrPteTh = 3;
	private const int NUaRErgiZmFydLjJTcIzXTmgWnyy = 4;
	private const int OynRoMBmpzBBOlIMNaqQiJdmLimb = 5;
	private const int BcUjhPcMjrVkNHWNyDTqLZotTUyX = 6;
	private const int uTxohtIIteTGPyGhVIawGPIIhvWCb = 8;
	private const int GxcrIdVDlhyjdBoIRAxHepHvrmNx = 22;
	private const int yEAvHXQpixvHqROFDgXpqlHKQlKy = 16;
	private const int lKFSUhmJXXUMtnHixJQpXvBTiZMp = 33;
	private const int WLQOqjqnAEnNDtJzygeTNltDExZZ = 8;
	private const int gzxvUBXQpPYeupeQpbDFByhjWGNuA = 9;
	private const int OQpOGmmqDVFpDjBZhfjDmIkwdCmqA = 10;
	private const int ryFmEExteoeuLWXOyFybccPWdEmV = 28;
	private const int ihrrOLRPOHnBtHwTlmLOyOCwNQPe = 53;
	private const int lrhczoHGfKQxvavDFsrIHfoPdchN = 54;
	private const int kXLyLdbTZKKTxQAsIRnowtlkaFFo = 43;
	private const int zCKBkGBDPQJQwpeNGKsAAjxHfyvkb = 42;
	private const int FUuyghBwzcSExkzMNBHXAPlJpQlf = 48;
	private const bool CKZIPhJAjWOMsdnsZPBROohzEKIj = True;
	private const int RKkDfArnrlCHnNOIDRoZqjOGcZZ = 60;
	private const int nDrJKHDKwBnmImCMsKmHWKNPqUsj = 60;
	private const int zQvoUQtKniimhCmvlNYyDCjIQKBdb = 3000000;
	private const float CrCHCDZNxRePlMcTZVEufdWdApfCA = 8192;
	private const float eAtZWVALuusilfxscIWNuOiUtFhm = 0.0010652969;
	private const float pqSYZBBcJsmGybPvgrNivIObeKVB = 0.06103702;
	private const bool iIQrYFoGPMFxEctUabsbpxMRarBs = True;
	private const bool VxuYquYkjMAgwgHrnvgowOxykXkd = True;
	private const bool EDNhdHnKGTQwZAeqTkxBUObxhJzr = True;
	private const bool exZsNRRfUAGrFbTCUNeuLFQjBkmAb = True;
	private const float XAZmbMZONSfohctwIWJLjdtmqNSI = 4096;
	private const float PTJQRIxeesGBBVCOiGjgyXLXfufe = 16384;
	private const float QASSVpJXslzLVHiDfCWKgnUbSCZK = 16777216;
	private const float RzchXfnLIqFYkESkWatsSPcxrAZjb = 268435460;
	private const float uOdocgnzhqaafIkdqkHRzkCbXmEK = 0.01999998;
	private const float uJxCLVDbmUvIPRLBQcJESgvtGjpgb = 8192;
	private const float rQlqqQwrYLMMOXUGwgROnnfzlEKK = 0.98;
	private const float CGZBJMbyKxHAeFGMiIeKslvqxYOLA = 45;
	private const float KpIYTDNuXdnPtikCaypiaziQmNee = 20;
	private const DualSenseVibrationMode TOCVMMXPFQlrZVMHfRzmMkZniFNk = 3;
	private readonly HIDDeviceDriver.IHIDDevice KfttQitkMjElZJEjiAabSOlRpEYy; // 0x58
	private readonly HIDDeviceDriver.HIDProperties iMMyZNQYoLvBafCLYdhfkaOIsuhQ; // 0x60
	private readonly bool CaRyZANcmpymaMIaLArnNviPakug; // 0x88
	private readonly int dPoePrPEIjhzcRhDmszikoMSCuCP; // 0x8C
	private readonly int zAWOmJisBtVXdsPIsEHRudNwZeOt; // 0x90
	private readonly bool wDCEfBvRrEYaLRouZbfYjPhOfKpj; // 0x94
	private readonly byte thVPcfIUCXHYVweFRuIXvgDroPyC; // 0x95
	private readonly int GtEsNIInBevTSTbvMCGsHGOFoDPJ; // 0x98
	private readonly int XTeltfZpDITEQPFKEWJtHJKGkktp; // 0x9C
	private readonly int csWfedatVVYAokuDSKVrGuYGMmmW; // 0xA0
	private readonly int VPNGSCBCOhsatonuEwvDbRoeLiWl; // 0xA4
	private readonly NativeBuffer hBpuofSqdISmXbjHyKkPjyfnbkcB; // 0xA8
	private readonly NativeBuffer LwVTdCrRgoiQpauWiPpofGSakDatA; // 0xB0
	private ndPzSZhFNVeBDFDFsrPPRfBbUpJt avzeqBdYiMMTAZhSXobPaJMoeOic; // 0xB8
	private int zPpQUfrnhVBMHmObuWfdtjtnEnGgA; // 0xD0
	private bool ddyqNmluLZAsJzyoasZxWdDRcEfl; // 0xD4
	private bool tTUhJlMUjZFGMdbbVHGVSOKopLsm; // 0xD5
	private double kfxHhbmCaltTHRoCirJVYDfrnTyF; // 0xD8
	private int cIpVgxgnXhHOpOHZPIDzBOCFhgiF; // 0xE0
	private DualSenseDriver.WNEfWiAGWElIfccIOJaCVxrIIwQTA qKtcbtzmMqlcbBMBXFtXNSOPhZYl; // 0xE4
	private bool BoTiMEuJOJRTbVCNUgwJNiAXgRiN; // 0xE8
	private Quaternion qTuLVXdQkJBuRbxPWrMVAXKnREuY; // 0xEC
	private DualSenseMicrophoneLightMode soLuaADTNyrbsYQczpWbLvDNvSNP; // 0xFC
	private DualSenseDriver.tNwXbQmPQlRJWXrOVdAfZgqrPzrU MpHcwdrMRsNFfEpezyQAGaVqPJGp; // 0xFD
	private DualSensePlayerLightFlags PCynKhNivOpjlPlCXxSrrWElqHbI; // 0xFE
	private bool FzjozUiwrYazeOYcwOsTQRFkfhMj; // 0xFF
	private uint NXgCQRdShRkvqpjPgpQTFPGfoBAob; // 0x100
	private float hDsErGKbImRqSmboViobTtAAVgey; // 0x104
	private double vJCoNzGAXPywozkGfFtNNfpOKlbs; // 0x108
	private float WYSlGnhebzOlLxrGWaEdsjLRCuAG; // 0x110
	private readonly IDualSenseTriggerEffect[] ZHgxhorDEufYqxgYtsIzYlzOIrVC; // 0x118
	private readonly byte[] qlrVBtcdFkHnNGUBxiOUATUHFpJf; // 0x120
	private readonly byte[] gTccfJnUpnYTUZiwRDXZAUsomIFQA; // 0x128
	private DualSenseTriggerEffectState[] KzlCOvsEoLugdzxXgAEIlgxmmnnx; // 0x130
	private DualSenseVibrationMode QpUvwRIigheypWhSZmAgdjYWpEvT; // 0x138
	private byte bwuNamIEbxumfCuUEJwkYiOCqJBf; // 0x13C
	private bool PuViwpQGZCDEgMljbWOgNILeIlDw; // 0x13D
	private bool SBNeUJxwcPNJKBsVEMyZMJhCANbj; // 0x13E
	private bool YFjjEZhEPCLVWgbDeRBGlvlvOcJIA; // 0x13F
	private bool JRdFASdGWXfsHAOmGGnOalicPLKwc; // 0x140
	private bool JYGiQBzHokigmewUCiHLcpqkTLwFA; // 0x141
	private bool ayurKXpkOUdOLDCEKAnvYsajfLCQA; // 0x142
	private bool wzIJJTKIsHUFwYAhyqpTZHeKgkwM; // 0x143
	private bool CiZBcFAdBhteMTcbykEqysvKOdmOA; // 0x144
	private bool NGcWXAXhyFmLaYHcjHgvqMHSgHKT; // 0x145
	private byte ARmClpCwWbxufeqbcYnibZxqDSZeb; // 0x146
	private byte eqzRaoHaUDSeYwCKDvbhUMrqRbnk; // 0x147
	private Quaternion OdBPtECHeHntOneJJJzWLgVbhKfW; // 0x148
	private Quaternion kucbUZGCESbxIJFjhehoyfDmRovD; // 0x158
	private bool wHXQXXDQeVlcIUfBPUBwQDWPfQMN; // 0x168
	private int trNoAFhBtkGFYIKkqMfnwwSJPNZs; // 0x16C
	private int[] HIUufFaMTzgHBDwdAZZWdohQqPulA; // 0x170
	private int[] yXpzgPLOXBoYQakXqENxTnftEMaR; // 0x178
	private static uint[] iVNPtjFeEhEDOpjmfEaaeJQGlWdx; // 0x0
	private const uint OlTbdCXCZshwpErgSiHUkNFNbOxCA = 3940166985;

	// Properties
	private bool isVibrating { get; }
	public float BatteryLevel { get; }
	public bool BatteryCharging { get; }
	public DualSenseVibrationMode vibrationMode { get; set; }
	public float LeftMotor { get; set; }
	public float RightMotor { get; set; }
	public float LightColorR { get; set; }
	public float LightColorG { get; set; }
	public float LightColorB { get; set; }
	public float LightFlashOnDuration { get; set; }
	public float LightFlashOffDuration { get; set; }
	public DualSenseMicrophoneLightMode microphoneLightMode { get; set; }
	public DualSenseOtherLightBrightness otherLightBrightness { get; set; }
	public DualSensePlayerLightFlags playerLights { get; set; }
	public Vector3 AccelerometerValue { get; }
	public Vector3 AccelerometerValueRaw { get; }
	public Vector3 GyroscopeValue { get; }
	public Vector3 GyroscopeValueRaw { get; }
	public Vector3 LastGyroscopeValue { get; }
	public Vector3 LastGyroscopeValueRaw { get; }
	public Quaternion Orientation { get; }
	public int MaxTouches { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x19CD7B0 Offset: 0x19CBDB0 VA: 0x1819CD7B0
	private bool jKNiLxoDkSpZClrikPckauAiRqFF() { }

	// RVA: 0x19CD0F0 Offset: 0x19CB6F0 VA: 0x1819CD0F0 Slot: 17
	public float get_BatteryLevel() { }

	// RVA: 0x19CD0E0 Offset: 0x19CB6E0 VA: 0x1819CD0E0 Slot: 18
	public bool get_BatteryCharging() { }

	// RVA: 0x17870A0 Offset: 0x17856A0 VA: 0x1817870A0 Slot: 19
	public DualSenseVibrationMode get_vibrationMode() { }

	// RVA: 0x19CEED0 Offset: 0x19CD4D0 VA: 0x1819CEED0 Slot: 20
	public void set_vibrationMode(DualSenseVibrationMode value) { }

	// RVA: 0x19CD530 Offset: 0x19CBB30 VA: 0x1819CD530 Slot: 21
	public float get_LeftMotor() { }

	// RVA: 0x19CEB30 Offset: 0x19CD130 VA: 0x1819CEB30 Slot: 22
	public void set_LeftMotor(float value) { }

	// RVA: 0x19CD680 Offset: 0x19CBC80 VA: 0x1819CD680 Slot: 23
	public float get_RightMotor() { }

	// RVA: 0x19CED60 Offset: 0x19CD360 VA: 0x1819CED60 Slot: 24
	public void set_RightMotor(float value) { }

	// RVA: 0x19CD610 Offset: 0x19CBC10 VA: 0x1819CD610 Slot: 25
	public float get_LightColorR() { }

	// RVA: 0x19CEC20 Offset: 0x19CD220 VA: 0x1819CEC20 Slot: 26
	public void set_LightColorR(float value) { }

	// RVA: 0x19CD5D0 Offset: 0x19CBBD0 VA: 0x1819CD5D0 Slot: 27
	public float get_LightColorG() { }

	// RVA: 0x19CEBE0 Offset: 0x19CD1E0 VA: 0x1819CEBE0 Slot: 28
	public void set_LightColorG(float value) { }

	// RVA: 0x19CD590 Offset: 0x19CBB90 VA: 0x1819CD590 Slot: 29
	public float get_LightColorB() { }

	// RVA: 0x19CEBA0 Offset: 0x19CD1A0 VA: 0x1819CEBA0 Slot: 30
	public void set_LightColorB(float value) { }

	// RVA: 0x19CD660 Offset: 0x19CBC60 VA: 0x1819CD660 Slot: 31
	public float get_LightFlashOnDuration() { }

	// RVA: 0x19CECE0 Offset: 0x19CD2E0 VA: 0x1819CECE0 Slot: 32
	public void set_LightFlashOnDuration(float value) { }

	// RVA: 0x19CD650 Offset: 0x19CBC50 VA: 0x1819CD650 Slot: 33
	public float get_LightFlashOffDuration() { }

	// RVA: 0x19CEC60 Offset: 0x19CD260 VA: 0x1819CEC60 Slot: 34
	public void set_LightFlashOffDuration(float value) { }

	// RVA: 0x16EE490 Offset: 0x16ECA90 VA: 0x1816EE490 Slot: 35
	public DualSenseMicrophoneLightMode get_microphoneLightMode() { }

	// RVA: 0x19CEDD0 Offset: 0x19CD3D0 VA: 0x1819CEDD0 Slot: 36
	public void set_microphoneLightMode(DualSenseMicrophoneLightMode value) { }

	// RVA: 0x19CD6E0 Offset: 0x19CBCE0 VA: 0x1819CD6E0 Slot: 37
	public DualSenseOtherLightBrightness get_otherLightBrightness() { }

	// RVA: 0x19CEDF0 Offset: 0x19CD3F0 VA: 0x1819CEDF0 Slot: 38
	public void set_otherLightBrightness(DualSenseOtherLightBrightness value) { }

	// RVA: 0x19CD790 Offset: 0x19CBD90 VA: 0x1819CD790 Slot: 39
	public DualSensePlayerLightFlags get_playerLights() { }

	// RVA: 0x19CEEB0 Offset: 0x19CD4B0 VA: 0x1819CEEB0 Slot: 40
	public void set_playerLights(DualSensePlayerLightFlags value) { }

	// RVA: 0x19CD050 Offset: 0x19CB650 VA: 0x1819CD050 Slot: 41
	public Vector3 get_AccelerometerValue() { }

	// RVA: 0x19CCFB0 Offset: 0x19CB5B0 VA: 0x1819CCFB0 Slot: 42
	public Vector3 get_AccelerometerValueRaw() { }

	// RVA: 0x19CD1F0 Offset: 0x19CB7F0 VA: 0x1819CD1F0 Slot: 43
	public Vector3 get_GyroscopeValue() { }

	// RVA: 0x19CD100 Offset: 0x19CB700 VA: 0x1819CD100 Slot: 44
	public Vector3 get_GyroscopeValueRaw() { }

	// RVA: 0x19CD420 Offset: 0x19CBA20 VA: 0x1819CD420 Slot: 45
	public Vector3 get_LastGyroscopeValue() { }

	// RVA: 0x19CD380 Offset: 0x19CB980 VA: 0x1819CD380 Slot: 46
	public Vector3 get_LastGyroscopeValueRaw() { }

	// RVA: 0x19CD670 Offset: 0x19CBC70 VA: 0x1819CD670 Slot: 47
	public Quaternion get_Orientation() { }

	// RVA: 0x19CAC40 Offset: 0x19C9240 VA: 0x1819CAC40 Slot: 48
	public void ResetOrientation() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 49
	public int get_MaxTouches() { }

	// RVA: 0x19C95A0 Offset: 0x19C7BA0 VA: 0x1819C95A0 Slot: 50
	public int GetTouchCount() { }

	// RVA: 0x19C9CB0 Offset: 0x19C82B0 VA: 0x1819C9CB0 Slot: 52
	public bool IsTouchingAtIndex(int index) { }

	// RVA: 0x19C9D10 Offset: 0x19C8310 VA: 0x1819C9D10 Slot: 51
	public bool IsTouchingAtTouchId(int touchId) { }

	// RVA: 0x19C9610 Offset: 0x19C7C10 VA: 0x1819C9610 Slot: 53
	public int GetTouchIdAtIndex(int index) { }

	// RVA: 0x19C97D0 Offset: 0x19C7DD0 VA: 0x1819C97D0 Slot: 54
	public bool GetTouchPositionByIndex(int index, out Vector2 position) { }

	// RVA: 0x19C9850 Offset: 0x19C7E50 VA: 0x1819C9850 Slot: 55
	public bool GetTouchPositionByTouchId(int touchId, out Vector2 position) { }

	// RVA: 0x19C9670 Offset: 0x19C7C70 VA: 0x1819C9670 Slot: 56
	public bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY) { }

	// RVA: 0x19C96F0 Offset: 0x19C7CF0 VA: 0x1819C96F0 Slot: 57
	public bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY) { }

	// RVA: 0x19CAF30 Offset: 0x19C9530 VA: 0x1819CAF30 Slot: 58
	public void StopLightFlash() { }

	// RVA: 0x19CAF50 Offset: 0x19C9550 VA: 0x1819CAF50 Slot: 59
	public void StopVibration() { }

	// RVA: 0x19CAE00 Offset: 0x19C9400 VA: 0x1819CAE00 Slot: 60
	public bool SetTriggerEffect(DualSenseTriggerType trigger, IDualSenseTriggerEffect effect) { }

	// RVA: 0x19C9930 Offset: 0x19C7F30 VA: 0x1819C9930 Slot: 61
	public DualSenseTriggerEffectStates GetTriggerEffectStates() { }

	// RVA: 0x19CACB0 Offset: 0x19C92B0 VA: 0x1819CACB0 Slot: 62
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x19CAC90 Offset: 0x19C9290 VA: 0x1819CAC90 Slot: 63
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950 Slot: 64
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0 Slot: 65
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x15D1050 Offset: 0x15CF650 VA: 0x1815D1050 Slot: 66
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x19CACA0 Offset: 0x19C92A0 VA: 0x1819CACA0 Slot: 67
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x19CB5F0 Offset: 0x19C9BF0 VA: 0x1819CB5F0
	public void .ctor(HIDDeviceDriver.InitArgs ) { }

	// RVA: 0x19CAFF0 Offset: 0x19C95F0 VA: 0x1819CAFF0 Slot: 13
	public override void Update(UpdateLoopType updateLoop) { }

	// RVA: 0x19CA740 Offset: 0x19C8D40 VA: 0x1819CA740 Slot: 14
	public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp) { }

	// RVA: 0x19C9090 Offset: 0x19C7690 VA: 0x1819C9090 Slot: 15
	public override Controller.Extension CreateControllerExtension() { }

	// RVA: 0x19CB500 Offset: 0x19C9B00 VA: 0x1819CB500
	private void ZCjFeNniEMliEGvWDHxAFMsYdnyH(GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19CCE60 Offset: 0x19CB460 VA: 0x1819CCE60
	private bool dWKthrkUImeVBRNcIQznuBDgWENt(GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19CA380 Offset: 0x19C8980 VA: 0x1819CA380
	private void MVLIJnHJuriYyVlklWMPsfDWvTNw() { }

	// RVA: 0x19CCB00 Offset: 0x19CB100 VA: 0x1819CCB00
	private void bLOZHhkbzlLcrGzeTjQivfIRHyeH(NativeBuffer , int ) { }

	// RVA: 0x19C9DC0 Offset: 0x19C83C0 VA: 0x1819C9DC0
	private void JJFbvQcyysGQXsGgcLoWPQdWbcfc(ref IDualSenseTriggerEffect , NativeBuffer , int ) { }

	// RVA: 0x19C9A80 Offset: 0x19C8080 VA: 0x1819C9A80
	private bool IqKwzaVwzpcKviAwExSRsZPFCsex(GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19CD890 Offset: 0x19CBE90 VA: 0x1819CD890
	private void lVOgfFIevRYcjDxGjYPQJURbOMJzA(NativeBuffer , double ) { }

	// RVA: 0x19CA6C0 Offset: 0x19C8CC0 VA: 0x1819CA6C0
	private void OBInMWNIksIRKdKjIaICAboByjawA(GLNYbQuaOXeaSToXMWjUhtXAplaf[] , NativeBuffer , double ) { }

	// RVA: 0x19CEA80 Offset: 0x19CD080 VA: 0x1819CEA80
	private void rsDsorvfPpFwCxRlYPumjMNvQuUc() { }

	// RVA: 0x19CA230 Offset: 0x19C8830 VA: 0x1819CA230
	private void LNmQUmQxdVTFtbCzqKTtFwpuxtMe(NativeBuffer ) { }

	// RVA: 0x19CB0F0 Offset: 0x19C96F0 VA: 0x1819CB0F0
	private void UqvAXxPbDwSftAdDtJPdczDDKGuM() { }

	// RVA: 0x19C99B0 Offset: 0x19C7FB0 VA: 0x1819C99B0
	private static bool HYPZhWLPtyHMwmZiBGUZejgokWLB(ref Vector3 ) { }

	// RVA: 0x19CDC40 Offset: 0x19CC240 VA: 0x1819CDC40
	private void pVMKaLMADrNUwjWfPbZanNZaXVSG(Vector3 , Vector3 ) { }

	// RVA: 0x19CB390 Offset: 0x19C9990 VA: 0x1819CB390
	private static Quaternion YBTrQAGnLBtrqtpuXIauSVrgrxnJ(Quaternion , Vector3 ) { }

	// RVA: 0x19CF750 Offset: 0x19CDD50 VA: 0x1819CF750
	private static Vector3 zemTYqQBZELWvqFMRhJXPjlfUySp(Vector3 , Vector3 ) { }

	// RVA: 0x19C93A0 Offset: 0x19C79A0 VA: 0x1819C93A0
	private Quaternion EwAgoeCxROigZBncLTiHIRdYIjmW(Quaternion , DualSenseDriver.kwWbOigzUXjwsSlLFbphfRWOKNiKA ) { }

	// RVA: 0x19C99F0 Offset: 0x19C7FF0 VA: 0x1819C99F0
	public static Quaternion Inverse(Quaternion quaternion) { }

	// RVA: 0x19CA300 Offset: 0x19C8900 VA: 0x1819CA300
	private float LoqQFKLJZjefqAdshPvGnkQsfndVA(float , float ) { }

	// RVA: 0x19C8FB0 Offset: 0x19C75B0 VA: 0x1819C8FB0
	private Vector3 AhXdMQRlgjaffyiijgTqFOoKZnixA(Vector3 , float  = 0) { }

	// RVA: 0x19CF310 Offset: 0x19CD910 VA: 0x1819CF310
	private Quaternion tlcZTWPAritfRlDlBqsooqhSHjSr(Vector3 , float  = 0) { }

	// RVA: 0x19CEEE0 Offset: 0x19CD4E0 VA: 0x1819CEEE0
	private Quaternion spbeEKezYkciXIDbIOKiNcfDiDGvb(Vector3 , float  = 0) { }

	// RVA: 0x19C9980 Offset: 0x19C7F80 VA: 0x1819C9980
	private float GooBgOdtFAHhIFJhDcQkgsfmBlTJ(Vector3 ) { }

	// RVA: 0x19CB370 Offset: 0x19C9970 VA: 0x1819CB370
	private bool VWesQLpVIJrrNoEOnVgdFhEfxKcd(float ) { }

	// RVA: 0x19CF620 Offset: 0x19CDC20 VA: 0x1819CF620
	private bool vDMdvjomOyPufEityuyydKkrXaWd(Vector3 , out DualSenseDriver.yqlVBrYOMEvZDUDKfkRdVNTtRzZI ) { }

	// RVA: 0x19CF280 Offset: 0x19CD880 VA: 0x1819CF280
	private bool tLgYgzUsHnAvXHQNmgjYPmhbJWQGA(Vector3 ) { }

	// RVA: 0x19CCA90 Offset: 0x19CB090 VA: 0x1819CCA90
	private bool bKXwwnHTHKKoYsDdKeSMaLAjPSnAb(Vector3 ) { }

	// RVA: 0x19CD800 Offset: 0x19CBE00 VA: 0x1819CD800
	private Vector3 jwNtbATLWwJiFArRQCdDZHIWTbfI(float[] ) { }

	// RVA: 0x19CACC0 Offset: 0x19C92C0 VA: 0x1819CACC0
	private Vector3 SYkfvAoMAgyNvLqqOSqMhNoRUxaK(RingBuffer<wlfdzvjuaZfnTkWOTlZxCBwptsuo.uBFqvefKBuWBtkgvFGvssozHNHtT> ) { }

	// RVA: 0x19CCEB0 Offset: 0x19CB4B0 VA: 0x1819CCEB0
	private Vector3 fHtSvOEzxZwYlPHKAyPKVjlDedUf(Vector3 , float ) { }

	// RVA: 0x19CA2B0 Offset: 0x19C88B0 VA: 0x1819CA2B0
	private int LTiYHMMOAFdlAZecJAWObogiXpYE(int ) { }

	// RVA: 0x19CCDD0 Offset: 0x19CB3D0 VA: 0x1819CCDD0
	private void oqKcYsKvkvHYNgAelbvSraTEQAvA(byte[] , float[] ) { }

	// RVA: 0x19CCDD0 Offset: 0x19CB3D0 VA: 0x1819CCDD0
	private void chrhyZLSGaFSkHeMjOeUyzFBopAM(byte[] , float[] ) { }

	// RVA: 0x19CD880 Offset: 0x19CBE80 VA: 0x1819CD880
	private float kJZcakChVFnMfiJdQsKzjzMbjPCjA() { }

	// RVA: 0x19CF420 Offset: 0x19CDA20 VA: 0x1819CF420
	private void uBKuCPgkUuFJKnWoglFASHyhVukL(NativeBuffer , WrSlmJxoZFgCLSWPeQjtyKXyDhws.TouchData[] ) { }

	// RVA: 0x19C9290 Offset: 0x19C7890 VA: 0x1819C9290
	private int EKWDVFBirMGmfFEYoFIcviHyxmLeA(int , bool , int ) { }

	// RVA: 0x19CA5B0 Offset: 0x19C8BB0 VA: 0x1819CA5B0
	private void oxrCkgLRlrEkqqcXBOlaNtzNMTzS() { }

	// RVA: 0x19CA5B0 Offset: 0x19C8BB0 VA: 0x1819CA5B0
	private void MZdnNxAMTktRAMrkQixYhrksykWX() { }

	// RVA: 0x19CD7A0 Offset: 0x19CBDA0 VA: 0x1819CD7A0
	private void hAVKImvpDcBSqjOJnLTCfHFTxzNy() { }

	// RVA: 0x19CAFE0 Offset: 0x19C95E0 VA: 0x1819CAFE0
	private void TVCwDtwJRQAtneOnUWORBxaHKxyNA() { }

	// RVA: 0x19C9530 Offset: 0x19C7B30 VA: 0x1819C9530 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19C9160 Offset: 0x19C7760 VA: 0x1819C9160 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x19CA5C0 Offset: 0x19C8BC0 VA: 0x1819CA5C0
	public static bool Matches(int vid, int pid) { }

	// RVA: 0x19CA5E0 Offset: 0x19C8BE0 VA: 0x1819CA5E0
	private static uint NgsanvsiMWIUgGLwNdgaAiqaxwYKb(NativeBuffer , int ) { }

	// RVA: 0x19CCF40 Offset: 0x19CB540 VA: 0x1819CCF40
	private static DualSenseDriver.tNwXbQmPQlRJWXrOVdAfZgqrPzrU fsYhHcYCjjbeDIopvwnqGYAKESFs(DualSenseOtherLightBrightness ) { }

	// RVA: 0x19C9D50 Offset: 0x19C8350 VA: 0x1819C9D50
	private static DualSenseOtherLightBrightness IvuxeZKgRNkYidoCVYFCItPSsXei(DualSenseDriver.tNwXbQmPQlRJWXrOVdAfZgqrPzrU ) { }

	// RVA: 0x19CA2C0 Offset: 0x19C88C0 VA: 0x1819CA2C0
	private static DualSenseDriver.KWOtPVEcszXdSkbXHOEUvAFRQruq LhapvhbYMURWJiLCCBBzBNmvYJQn(DualSenseTriggerType , byte ) { }

	// RVA: 0x19CE8D0 Offset: 0x19CCED0 VA: 0x1819CE8D0
	private static DualSenseTriggerEffectState qKeFePIOuMbELKEgCXSlloskHHEqA(DualSenseTriggerType , byte , byte ) { }

	[Conditional("DEBUG_THIS")]
	// RVA: 0x19C90F0 Offset: 0x19C76F0 VA: 0x1819C90F0
	protected static void DLog(object msg) { }

	// RVA: 0x19CB560 Offset: 0x19C9B60 VA: 0x1819CB560
	private static void .cctor() { }
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal class DualShock4Driver : HIDDeviceDriver, IDriver_DualShock4, IControllerDriver, IHIDControllerExtension, IDisposable // TypeDefIndex: 6530
{
	// Fields
	private const float mAavRRWbtFDpeBZFSPeoxicCrCBk = 4;
	private const int ywZaQTqXJLNIbskPzwesBnunfnAiA = 14;
	private const int pytAagHEIsXMPSmVTrGNaxISJasW = 2;
	private const int QfpiVBcsiWiAsQoVUynRcWtPXgYEA = 0;
	private const int XgUDFnCNXDTQAGNDlUvlXWOUhkzC = 1912;
	private const int sBkKilDFbAvsUCyvUfNMhPCtjSBeA = 0;
	private const int vIKdgXSRfTsmknxMvwTbIbRGlpqf = 941;
	private const bool MArvGKJCCReBukrdbaVefMNFFJhzA = False;
	private const bool enJAfPKngiurfDQjcQjvvJsCAtqn = True;
	private const float QwhpEfVKzeMwHquZOrglVjqtQyuN = 2.5;
	private const int zPleddFGaBjqZWrePNZSEdDWcyiR = 0;
	private const int eiQcyvpGbQVFcaPrQklibzdsckLC = 0;
	private const int QyXgSQZZPUsUYArMGGAZqoRIkEsA = 1;
	private const int exECDDFROfiuPdCcoqaWikqjyrhYB = 0;
	private const int OcPQnqREbgCqUHrylGCgHCgoWazEb = 0;
	private const int PIsiSQCiyWlorLoNfWgtpOAeFOaf = 0;
	private const int BpxZOEMsPvBvvEMSqwSqPaDeqUey = 1;
	private const int AmecAbHsqjaulJIlrmKKtWllXufgA = 17;
	private const int EWxgMzajkVofXixvHJyPNyyBTibyC = 0;
	private const int hajDPuEGpLdABGmfDniBIKBuCyBpB = 2;
	private const int IaudPHasvsiluLGVlrbWwcsIupvG = 64;
	private const int zsdxbfKPjxDXJfyUeCZpaPGHqpLK = 78;
	private const byte NKwDTkizTKyTVDrpjNaJEYcrATomA = 17;
	private const byte lIoDOobnnVfBGEiIhzubISZoYqCbA = 5;
	private const byte ZdIBQbOWVnABzZBZywufumugcKBBA = 2;
	private const byte IGwRBjgyMEzrXivFmIHmbfOzMzFJ = 37;
	private const byte guSgzVkLtftzydjdBQVTiMOVvNcv = 5;
	private const byte jndJlcIxGfsJDyYpZBqPyFnBQjfk = 41;
	private const byte BUqBcqvOuUSCcnOGbIHMqmtEdLkq = 163;
	private const byte QeOLuoDjMJBQJkzwmTWTcdHlDxumA = 49;
	private const byte pcglzIfOyBnqJPFKPkGhrBznKmqB = 18;
	private const byte MHFvocjGoptMRBFfLRUaHdKoUKdl = 16;
	private const byte nvMuQBTnMaKqSvtYqqAhHFFlpdGJ = 161;
	private const byte ZQVkFmjfJSggQHfNZgzGrIFJVmDU = 162;
	private const byte aRWaWKDBPfdmAIeNCaGLdSGGoRCub = 163;
	private const int vHXYQYmutXhnKcgyXZVZhmzuCbXjA = 1;
	private const int yBKFuWMlNHuvPXqqCdSVEhZybiaO = 2;
	private const int fPvpoCMhkAvrdNDKYrATALzOcFDaA = 3;
	private const int SoTQjxmwqbOvRLnsIQAwZJbQAdif = 4;
	private const int sYIlhBdOmIGVjDOIfdbkvfYJbthlA = 8;
	private const int GyfNbwYrUvtlkUXuJtlUTXGXIdex = 9;
	private const int YbOKGMzOLdJdaGUupTjNvrfQdJsw = 5;
	private const int KacbfoCOQbHhjBjlGGnPcniqWMetB = 19;
	private const int fCEiEdaFoSCREHGqLqFWtPXrgfJD = 13;
	private const int drhkqYKdwmESCGixpOhMlkjQxpAl = 35;
	private const int SksCJDpQHCHFBtztZEnDfGTtIoRi = 5;
	private const int mhmItXypVeFqeiGFUzaSWzyGnPWh = 6;
	private const int lVFqsVbPzTZjAbbbWAmneYmxZRMN = 7;
	private const int hJifrCjYkcPtcqkPDFRDbREeLWeDB = 10;
	private const int bnFrKdedHpuBqUvQOdZCjGtBBwoV = 30;
	private const int uxYZxVkQrXxbBoVOloOheBITEhCv = 27;
	private const byte yYLTCgDuKmlbyhQRWNagKvXbsqTD = 200;
	private const byte pYMGTRkAeqlNlNYpNTEUSPtBBsRT = 53;
	private const byte unwruiBwJTEdEHcGZHMeGFsbPEFE = 255;
	private const byte eELDVHvdTQpkxrpyQNfNInIPcCaBA = 0;
	private const bool uJgOzgfYtSvRjcCmWNoBpWdYuOjJ = True;
	private const int oyEPZnxmYOLzzldSiGbagFsGMAFeb = 60;
	private const int aZRinaJyVeLgPohVHiFTyKPufCnFA = 60;
	private const int CQjIICqIAZwEFJNsaLpeNTZyndxQ = 187500;
	private const float DzhdQgkbJbyfycgiiECxFiYdAwlJA = 8192;
	private const float seOriQOCYdmxSuOkkXEQRfOXFFpK = 0.0010652969;
	private const float ZZRdmtQoXEaiNCpdCxQaDcVHJBGIA = 0.06103702;
	private const bool PknoBNAUKvQmAcFJXrpHXLivbbLQ = True;
	private const bool VwCeeDgfHIbtLzFIVjiuRZAxvMAWA = True;
	private const bool sSueyyDzynreutKsXQpPeYivlvtTA = True;
	private const bool GtsmaqCjPRcgBEiLlBIBFRUkIZfY = True;
	private const float mnUGlNBbTeSqyJHzoqawQvwurmrw = 4096;
	private const float ByHzHyZVHzNOSdpGLcmjaKfvWlsaA = 16384;
	private const float uZpDaUcGhuyASebGgLFjgDQuhHDI = 16777216;
	private const float cwmFceGVNzCNSvXIhGNGyueEKCJC = 268435460;
	private const float HHYaCPoNAdkFgXCBlSDNWPfCITuEA = 0.01999998;
	private const float bHtBuHyOYHDkrBNHXVfKEFyheICn = 8192;
	private const float VNMtImdJkVEtusVjiaznfTjFwJOIA = 0.98;
	private const float HxZVoCocrgbNFcWjcbJLDajwqSPF = 45;
	private const float AyMRQLHVGNoiODFrlaBCQujPzwxL = 20;
	private readonly HIDDeviceDriver.IHIDDevice lRaeaQRuLcsbHSjugvxXAkiWacvg; // 0x58
	private readonly HIDDeviceDriver.HIDProperties ZqnaCutbBoyHKjeuFgiiasxZwSVSA; // 0x60
	private readonly bool cWMwlqccerlKJmmJjfVOacQqPFHN; // 0x88
	private readonly RhzYuVirWegvYsLvvdtRvjIAEUGd GxfoxkgGLAqQusEXiaLOEMjUiFdVA; // 0x8C
	private readonly int dqZTmAaFmbhbxjRjdGvvBnsbtPVV; // 0x90
	private readonly int OrSGzNrgbkehgjflkpdDMwyaIuTq; // 0x94
	private readonly bool JqBuLSkQcNrOADnihhtqEPGcNmdm; // 0x98
	private readonly byte vGtADxJUAaSMaJujcIujKSGqItOMB; // 0x99
	private readonly int hDeHKvCdehdRuIswQAsgotWlOzQpA; // 0x9C
	private readonly int lskOFlmtHvztREaZAKBHRTUJWyxG; // 0xA0
	private readonly int fGugTowgJDqDEdYkTgNKUysdqDxg; // 0xA4
	private readonly int pQqeEuvNbmJjsSaiNEHpLXGCxveg; // 0xA8
	private readonly NativeBuffer ckUBJlSFkwkELcibEsQKADIQiodFA; // 0xB0
	private readonly NativeBuffer AblgESTyBDdKbqLpmZXLgBadVopd; // 0xB8
	private readonly ndPzSZhFNVeBDFDFsrPPRfBbUpJt SKXDOBeNcQMavdBUOMJTkzAYZzRA; // 0xC0
	private readonly byte[] ngRKtltjrMwZtXMLjqgoejBrIFXs; // 0xD8
	private bool ZGfajMeCkJjZuFgQLLZHEMJuFpLqA; // 0xE0
	private bool DHWFolZZicdpcGNBjdrBiNctbmuH; // 0xE1
	private double zxBgrrKtlNnByqhbeaXpCyWHuHUgb; // 0xE8
	private int ixgmbyjnmKEVZHBCopwFvacCWJQDA; // 0xF0
	private DualShock4Driver.MbXScNgSTlIodlRzYbgnewUBkkcvA UUXCBqgZpCGSEqMNNazhfBrdGwTvb; // 0xF4
	private Quaternion CcbARtwowTcufJVVQMXhDZuKFkGr; // 0xF8
	private ushort jCrxeUcpjTWoIcBvjAoZHxxxEYQjA; // 0x108
	private float cBZFOpJmjJKLQbgcdMTvduxRmKNl; // 0x10C
	private double xCgCkXETKaKtMdRezHvfdlriNTduA; // 0x110
	private float eKcwUmfykzcqcwoGezmjhLWHgVFhA; // 0x118
	private bool XuNGCRrEdvIEdSsaTihszNKadxCj; // 0x11C
	private bool omawcswVZzGeCtLLrbqWyDjsmEVp; // 0x11D
	private bool iPWUloUffenMTujqLtGWobzAfukW; // 0x11E
	private bool pnajuPFSrbEkFAIWKuNxSBXSyAFc; // 0x11F
	private byte tSLEPOpWzyiRbIiRBcjHUlCOOumO; // 0x120
	private byte XKjdJJjViVUSdyXuCzauUQwqaEGv; // 0x121
	private Quaternion pYeqTjzztokYyvnAAInLggyDsvAP; // 0x124
	private Quaternion bawjREywlvGuFEQnlYFGnpPOYOXf; // 0x134
	private bool QWZDKtXiMjQXTxuEgHhhZyZsNHUw; // 0x144
	private int yvcucsQUkQzSrMnUdioJqZFvuNxD; // 0x148
	private int[] XuXvKbHRGzICMSNFdhDhdqyltUOfA; // 0x150
	private int[] YUzdmeUMkMHMvKTqBLSFMtswgIYf; // 0x158

	// Properties
	private bool isVibrating { get; }
	public float BatteryLevel { get; }
	public bool BatteryCharging { get; }
	public float LeftMotor { get; set; }
	public float RightMotor { get; set; }
	public float LightColorR { get; set; }
	public float LightColorG { get; set; }
	public float LightColorB { get; set; }
	public float LightFlashOnDuration { get; set; }
	public float LightFlashOffDuration { get; set; }
	public Vector3 AccelerometerValue { get; }
	public Vector3 AccelerometerValueRaw { get; }
	public Vector3 GyroscopeValue { get; }
	public Vector3 GyroscopeValueRaw { get; }
	public Vector3 LastGyroscopeValue { get; }
	public Vector3 LastGyroscopeValueRaw { get; }
	public Quaternion Orientation { get; }
	public int MaxTouches { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x19CD7B0 Offset: 0x19CBDB0 VA: 0x1819CD7B0
	private bool EsSxLmvcMohNeaXToWHSVcWVBZOAA() { }

	// RVA: 0x19D26E0 Offset: 0x19D0CE0 VA: 0x1819D26E0 Slot: 17
	public float get_BatteryLevel() { }

	// RVA: 0x19D26D0 Offset: 0x19D0CD0 VA: 0x1819D26D0 Slot: 18
	public bool get_BatteryCharging() { }

	// RVA: 0x19CD530 Offset: 0x19CBB30 VA: 0x1819CD530 Slot: 19
	public float get_LeftMotor() { }

	// RVA: 0x19CEB30 Offset: 0x19CD130 VA: 0x1819CEB30 Slot: 20
	public void set_LeftMotor(float value) { }

	// RVA: 0x19CD680 Offset: 0x19CBC80 VA: 0x1819CD680 Slot: 21
	public float get_RightMotor() { }

	// RVA: 0x19CED60 Offset: 0x19CD360 VA: 0x1819CED60 Slot: 22
	public void set_RightMotor(float value) { }

	// RVA: 0x19CD610 Offset: 0x19CBC10 VA: 0x1819CD610 Slot: 23
	public float get_LightColorR() { }

	// RVA: 0x19CEC20 Offset: 0x19CD220 VA: 0x1819CEC20 Slot: 24
	public void set_LightColorR(float value) { }

	// RVA: 0x19CD5D0 Offset: 0x19CBBD0 VA: 0x1819CD5D0 Slot: 25
	public float get_LightColorG() { }

	// RVA: 0x19CEBE0 Offset: 0x19CD1E0 VA: 0x1819CEBE0 Slot: 26
	public void set_LightColorG(float value) { }

	// RVA: 0x19CD590 Offset: 0x19CBB90 VA: 0x1819CD590 Slot: 27
	public float get_LightColorB() { }

	// RVA: 0x19CEBA0 Offset: 0x19CD1A0 VA: 0x1819CEBA0 Slot: 28
	public void set_LightColorB(float value) { }

	// RVA: 0x19D29A0 Offset: 0x19D0FA0 VA: 0x1819D29A0 Slot: 29
	public float get_LightFlashOnDuration() { }

	// RVA: 0x19D2C60 Offset: 0x19D1260 VA: 0x1819D2C60 Slot: 30
	public void set_LightFlashOnDuration(float value) { }

	// RVA: 0x19D2990 Offset: 0x19D0F90 VA: 0x1819D2990 Slot: 31
	public float get_LightFlashOffDuration() { }

	// RVA: 0x19D2BE0 Offset: 0x19D11E0 VA: 0x1819D2BE0 Slot: 32
	public void set_LightFlashOffDuration(float value) { }

	// RVA: 0x19CD050 Offset: 0x19CB650 VA: 0x1819CD050 Slot: 33
	public Vector3 get_AccelerometerValue() { }

	// RVA: 0x19CCFB0 Offset: 0x19CB5B0 VA: 0x1819CCFB0 Slot: 34
	public Vector3 get_AccelerometerValueRaw() { }

	// RVA: 0x19D26F0 Offset: 0x19D0CF0 VA: 0x1819D26F0 Slot: 35
	public Vector3 get_GyroscopeValue() { }

	// RVA: 0x19CD100 Offset: 0x19CB700 VA: 0x1819CD100 Slot: 36
	public Vector3 get_GyroscopeValueRaw() { }

	// RVA: 0x19D2880 Offset: 0x19D0E80 VA: 0x1819D2880 Slot: 37
	public Vector3 get_LastGyroscopeValue() { }

	// RVA: 0x19CD380 Offset: 0x19CB980 VA: 0x1819CD380 Slot: 38
	public Vector3 get_LastGyroscopeValueRaw() { }

	// RVA: 0x19D29B0 Offset: 0x19D0FB0 VA: 0x1819D29B0 Slot: 39
	public Quaternion get_Orientation() { }

	// RVA: 0x19D0890 Offset: 0x19CEE90 VA: 0x1819D0890 Slot: 40
	public void ResetOrientation() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 41
	public int get_MaxTouches() { }

	// RVA: 0x19C95A0 Offset: 0x19C7BA0 VA: 0x1819C95A0 Slot: 42
	public int GetTouchCount() { }

	// RVA: 0x19C9CB0 Offset: 0x19C82B0 VA: 0x1819C9CB0 Slot: 44
	public bool IsTouchingAtIndex(int index) { }

	// RVA: 0x19C9D10 Offset: 0x19C8310 VA: 0x1819C9D10 Slot: 43
	public bool IsTouchingAtTouchId(int touchId) { }

	// RVA: 0x19C9610 Offset: 0x19C7C10 VA: 0x1819C9610 Slot: 45
	public int GetTouchIdAtIndex(int index) { }

	// RVA: 0x19C97D0 Offset: 0x19C7DD0 VA: 0x1819C97D0 Slot: 46
	public bool GetTouchPositionByIndex(int index, out Vector2 position) { }

	// RVA: 0x19C9850 Offset: 0x19C7E50 VA: 0x1819C9850 Slot: 47
	public bool GetTouchPositionByTouchId(int touchId, out Vector2 position) { }

	// RVA: 0x19C9670 Offset: 0x19C7C70 VA: 0x1819C9670 Slot: 48
	public bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY) { }

	// RVA: 0x19C96F0 Offset: 0x19C7CF0 VA: 0x1819C96F0 Slot: 49
	public bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY) { }

	// RVA: 0x19D08E0 Offset: 0x19CEEE0 VA: 0x1819D08E0 Slot: 50
	public void StopLightFlash() { }

	// RVA: 0x19CAF50 Offset: 0x19C9550 VA: 0x1819CAF50 Slot: 51
	public void StopVibration() { }

	// RVA: 0x19CACB0 Offset: 0x19C92B0 VA: 0x1819CACB0 Slot: 52
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x19CAC90 Offset: 0x19C9290 VA: 0x1819CAC90 Slot: 53
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950 Slot: 54
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0 Slot: 55
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x15D1050 Offset: 0x15CF650 VA: 0x1815D1050 Slot: 56
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x19CACA0 Offset: 0x19C92A0 VA: 0x1819CACA0 Slot: 57
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x19D0D40 Offset: 0x19CF340 VA: 0x1819D0D40
	public void .ctor(HIDDeviceDriver.InitArgs ) { }

	// RVA: 0x19D0B50 Offset: 0x19CF150 VA: 0x1819D0B50 Slot: 13
	public override void Update(UpdateLoopType updateLoop) { }

	// RVA: 0x19D0340 Offset: 0x19CE940 VA: 0x1819D0340 Slot: 14
	public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp) { }

	// RVA: 0x19CF850 Offset: 0x19CDE50 VA: 0x1819CF850 Slot: 15
	public override Controller.Extension CreateControllerExtension() { }

	// RVA: 0x19D0C50 Offset: 0x19CF250 VA: 0x1819D0C50
	private void WYAzrqiddohhCiCpnHbUFkhuJYpCA(GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19D0900 Offset: 0x19CEF00 VA: 0x1819D0900
	private bool TUsULhxVWMLpagBAmaFYKTVDhSRdA(GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19D2190 Offset: 0x19D0790 VA: 0x1819D2190
	private void cMfsGNkbdCzoIdGBwFheEMZinebS() { }

	// RVA: 0x19CFE80 Offset: 0x19CE480 VA: 0x1819CFE80
	private bool LMjlMnnOYgSeUQKhPAoQKkRyKQiBA(GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19CFB20 Offset: 0x19CE120 VA: 0x1819CFB20
	private void FCedfwbNeOTIRTJaQQxHBCZMKrmYA(NativeBuffer , double ) { }

	// RVA: 0x19CA6C0 Offset: 0x19C8CC0 VA: 0x1819CA6C0
	private void pYUUYnCcCQRvLrHdFfGDJwxHcKKm(GLNYbQuaOXeaSToXMWjUhtXAplaf[] , NativeBuffer , double ) { }

	// RVA: 0x19D2B30 Offset: 0x19D1130 VA: 0x1819D2B30
	private void qpECslPsUFOaxjNoFqSRniYnBNyR() { }

	// RVA: 0x19D0CB0 Offset: 0x19CF2B0 VA: 0x1819D0CB0
	private void XEWZFKeoKfDfFAmyUJNlXsRcSTsm(NativeBuffer ) { }

	// RVA: 0x19D2CE0 Offset: 0x19D12E0 VA: 0x1819D2CE0
	private void vRLYmKlvEXCstjGcQjgnxOkbCDlA() { }

	// RVA: 0x19C99B0 Offset: 0x19C7FB0 VA: 0x1819C99B0
	private static bool uBwfTyUqGpwCFYpDfIGcHHcUkkCgb(ref Vector3 ) { }

	// RVA: 0x19D2F20 Offset: 0x19D1520 VA: 0x1819D2F20
	private void wgMloNttyQRjapfLLVyfhWLCMzpf(Vector3 , Vector3 ) { }

	// RVA: 0x19D29C0 Offset: 0x19D0FC0 VA: 0x1819D29C0
	private static Quaternion kwPSBUYldoOFJqIGJPVhNqgGEhls(Quaternion , Vector3 ) { }

	// RVA: 0x19CF750 Offset: 0x19CDD50 VA: 0x1819CF750
	private static Vector3 LLOMUxFTZCEREEaLwUTwvXMysPyj(Vector3 , Vector3 ) { }

	// RVA: 0x19C93A0 Offset: 0x19C79A0 VA: 0x1819C93A0
	private Quaternion EDsitMlWkPfqPWTwwcGefoILBltN(Quaternion , DualShock4Driver.kitClctKihZiXmKkXMXxdbGInNah ) { }

	// RVA: 0x19C99F0 Offset: 0x19C7FF0 VA: 0x1819C99F0
	public static Quaternion Inverse(Quaternion quaternion) { }

	// RVA: 0x19CA300 Offset: 0x19C8900 VA: 0x1819CA300
	private float hDOghQhFZkylslJBADoECqEDvYXU(float , float ) { }

	// RVA: 0x19C8FB0 Offset: 0x19C75B0 VA: 0x1819C8FB0
	private Vector3 DouExMhLsFASHqHdDBhZlYyiObSJA(Vector3 , float  = 0) { }

	// RVA: 0x19CF310 Offset: 0x19CD910 VA: 0x1819CF310
	private Quaternion pYlguQHhiLRWjmdavOsuQyaNJCfRA(Vector3 , float  = 0) { }

	// RVA: 0x19CEEE0 Offset: 0x19CD4E0 VA: 0x1819CEEE0
	private Quaternion vybJxnlpJIBQqwOGoIzHfRIebhmZA(Vector3 , float  = 0) { }

	// RVA: 0x19C9980 Offset: 0x19C7F80 VA: 0x1819C9980
	private float GhsNzVPzcrCQAAKzFXgdxkqpMsH(Vector3 ) { }

	// RVA: 0x19CB370 Offset: 0x19C9970 VA: 0x1819CB370
	private bool YZHuRnRoCFJirREPQcTaxeRZRRNJ(float ) { }

	// RVA: 0x19CF620 Offset: 0x19CDC20 VA: 0x1819CF620
	private bool BiUzsnDmSgZCbaporDpyopBthTZf(Vector3 , out DualShock4Driver.ckAfeOCHQuMmQPQqpQFPMczqbBhDb ) { }

	// RVA: 0x19CF280 Offset: 0x19CD880 VA: 0x1819CF280
	private bool AHExdmhdjyeXpBeZujZlBkoIJXLxb(Vector3 ) { }

	// RVA: 0x19CCA90 Offset: 0x19CB090 VA: 0x1819CCA90
	private bool FbUCforxbQBhhUPCtdCbkmQJTElc(Vector3 ) { }

	// RVA: 0x19CD800 Offset: 0x19CBE00 VA: 0x1819CD800
	private Vector3 JDeMPmpjEdcDwVpRaQDwFFuznBzI(float[] ) { }

	// RVA: 0x19CF9E0 Offset: 0x19CDFE0 VA: 0x1819CF9E0
	private Vector3 DrQACtGQvCEydOWsMixwuQPJyYpoA(RingBuffer<wlfdzvjuaZfnTkWOTlZxCBwptsuo.uBFqvefKBuWBtkgvFGvssozHNHtT> ) { }

	// RVA: 0x19CCEB0 Offset: 0x19CB4B0 VA: 0x1819CCEB0
	private Vector3 ecMLwcuWDtkwSGmMoBmoLljIFWkR(Vector3 , float ) { }

	// RVA: 0x19CA2B0 Offset: 0x19C88B0 VA: 0x1819CA2B0
	private int OdWolQHHbbgwIQTVoKNPGLuFqKqf(int ) { }

	// RVA: 0x19CCDD0 Offset: 0x19CB3D0 VA: 0x1819CCDD0
	private void TXmeJCWHMbbHFhDqbOtPNTjkDwJm(byte[] , float[] ) { }

	// RVA: 0x19CCDD0 Offset: 0x19CB3D0 VA: 0x1819CCDD0
	private void CqIDookMWLJyCcMzhbvUnQMyzJPr(byte[] , float[] ) { }

	// RVA: 0x352790 Offset: 0x350D90 VA: 0x180352790
	private float btTAZXaBPMRefAytxeUYIlgWssPu() { }

	// RVA: 0x19D0950 Offset: 0x19CEF50 VA: 0x1819D0950
	private void TnqfNMbUGDAkoUXjEHRUncOGbcWI(NativeBuffer , WrSlmJxoZFgCLSWPeQjtyKXyDhws.TouchData[] ) { }

	// RVA: 0x19D0220 Offset: 0x19CE820 VA: 0x1819D0220
	private int MhCEfrjZPeOLcgLiuQqibYLUCjoF(int , bool , int ) { }

	// RVA: 0x19D2B20 Offset: 0x19D1120 VA: 0x1819D2B20
	private void oCPdAqYZJUYBHkGhDJEJJyxuWxbG() { }

	// RVA: 0x19D2B10 Offset: 0x19D1110 VA: 0x1819D2B10
	private void mEzHSPnmMMRkGskUFRKXSdsxlXgV() { }

	// RVA: 0x19D26C0 Offset: 0x19D0CC0 VA: 0x1819D26C0
	private void fBKJbHRGYlHbivAzflwTDdvFftzk() { }

	// RVA: 0x19D0330 Offset: 0x19CE930 VA: 0x1819D0330
	private void PKoVNWkBtSHcLpILQPwOQxrVtpvv() { }

	// RVA: 0x19C9530 Offset: 0x19C7B30 VA: 0x1819C9530 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19CF8B0 Offset: 0x19CDEB0 VA: 0x1819CF8B0 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x19D00B0 Offset: 0x19CE6B0 VA: 0x1819D00B0
	public static bool Matches(int vid, int pid) { }

	[Conditional("DEBUG_THIS")]
	// RVA: 0x19D2B00 Offset: 0x19D1100 VA: 0x1819D2B00
	private static void lXyGHVmhnieJWeCINkbdMpEkOKqdb(object ) { }
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal abstract class HIDDeviceDriver : IControllerDriver, IDisposable // TypeDefIndex: 6535
{
	// Fields
	public pCLyOolGSoGnzckhrUopJSxPPQuQA[] axes; // 0x10
	public ObPWlwvNIZlgLtPWEEVnCpUXVVLm[] buttons; // 0x18
	public FGSJBFVFVYBfMIKsAxCQjZVJGBqqA[] hats; // 0x20
	public wqcsgHbRqKmTaBqusbzdwjpIObAM[] accelerometers; // 0x28
	public wlfdzvjuaZfnTkWOTlZxCBwptsuo[] gyroscopes; // 0x30
	public WrSlmJxoZFgCLSWPeQjtyKXyDhws[] touchpads; // 0x38
	public tudIoPOAEDmqsLLiFPEYXeUodAYW[] vibrationMotors; // 0x40
	public qEpfSxgyzoxzSqMkstzdRksmymJpA[] lights; // 0x48
	private bool EQxARCBFvfppmDBYcgmhgssRIxOWA; // 0x50

	// Properties
	public int AxisCount { get; }
	public int ButtonCount { get; }
	public int HatCount { get; }
	public int AccelerometerCount { get; }
	public int GyroscopeCount { get; }
	public int TouchpadCount { get; }
	public int LightCount { get; }
	public int VibrationMotorCount { get; }
	protected bool disposed { get; }

	// Methods

	// RVA: 0x378930 Offset: 0x376F30 VA: 0x180378930 Slot: 4
	public int get_AxisCount() { }

	// RVA: 0x37E800 Offset: 0x37CE00 VA: 0x18037E800 Slot: 5
	public int get_ButtonCount() { }

	// RVA: 0x176B890 Offset: 0x1769E90 VA: 0x18176B890 Slot: 6
	public int get_HatCount() { }

	// RVA: 0x12AD9E0 Offset: 0x12ABFE0 VA: 0x1812AD9E0 Slot: 7
	public int get_AccelerometerCount() { }

	// RVA: 0x173FD70 Offset: 0x173E370 VA: 0x18173FD70 Slot: 8
	public int get_GyroscopeCount() { }

	// RVA: 0x19D41B0 Offset: 0x19D27B0 VA: 0x1819D41B0 Slot: 9
	public int get_TouchpadCount() { }

	// RVA: 0x1773560 Offset: 0x1771B60 VA: 0x181773560 Slot: 10
	public int get_LightCount() { }

	// RVA: 0x176D690 Offset: 0x176BC90 VA: 0x18176D690 Slot: 11
	public int get_VibrationMotorCount() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Update(UpdateLoopType updateLoop);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Controller.Extension CreateControllerExtension();

	// RVA: 0x19D3FC0 Offset: 0x19D25C0 VA: 0x1819D3FC0
	public static HIDDeviceDriver GetDriver(HIDDeviceDriver.DriverType driverId, HIDDeviceDriver.InitArgs hidDriverInitArgs) { }

	// RVA: 0x19D3CA0 Offset: 0x19D22A0 VA: 0x1819D3CA0
	public static HIDDeviceDriver.DriverType FindDriverId(int vendorId, int productId, IList<EnhancedDeviceSupportDeviceType> exclusions) { }

	// RVA: 0x95D0B0 Offset: 0x95B6B0 VA: 0x18095D0B0
	protected bool get_disposed() { }

	// RVA: 0x19D3C30 Offset: 0x19D2230 VA: 0x1819D3C30 Slot: 12
	public void Dispose() { }

	// RVA: 0x193F0F0 Offset: 0x193D6F0 VA: 0x18193F0F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19D3C90 Offset: 0x19D2290 VA: 0x1819D3C90 Slot: 16
	protected virtual void Dispose(bool disposing) { }
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal abstract class NintendoSwitchGamepadDriver : HIDDeviceDriver, IDriver_NintendoSwitchController, IControllerDriver, IHIDControllerExtension, IDisposable // TypeDefIndex: 6541
{
	// Fields
	protected const byte INPUT_REPORT_ID = 33;
	protected const byte OUTPUT_REPORT_COMMAND_GET_INPUT = 31;
	protected const byte OUTPUT_RUMBLE_AND_SUBCMD = 1;
	protected const byte OUTPUT_FW_UPDATE_PKT = 3;
	protected const byte OUTPUT_RUMBLE_ONLY = 16;
	protected const byte OUTPUT_MCU_DATA = 17;
	protected const byte OUTPUT_USB_CMD = 128;
	protected const byte SUBCMD_STATE = 0;
	protected const byte SUBCMD_MANUAL_BT_PAIRING = 1;
	protected const byte SUBCMD_REQ_DEV_INFO = 2;
	protected const byte SUBCMD_SET_REPORT_MODE = 3;
	protected const byte SUBCMD_TRIGGERS_ELAPSED = 4;
	protected const byte SUBCMD_GET_PAGE_LIST_STATE = 5;
	protected const byte SUBCMD_SET_HCI_STATE = 6;
	protected const byte SUBCMD_RESET_PAIRING_INFO = 7;
	protected const byte SUBCMD_LOW_POWER_MODE = 8;
	protected const byte SUBCMD_SPI_FLASH_READ = 16;
	protected const byte SUBCMD_SPI_FLASH_WRITE = 17;
	protected const byte SUBCMD_RESET_MCU = 32;
	protected const byte SUBCMD_SET_MCU_CONFIG = 33;
	protected const byte SUBCMD_SET_MCU_STATE = 34;
	protected const byte SUBCMD_SET_PLAYER_LIGHTS = 48;
	protected const byte SUBCMD_GET_PLAYER_LIGHTS = 49;
	protected const byte SUBCMD_SET_HOME_LIGHT = 56;
	protected const byte SUBCMD_ENABLE_IMU = 64;
	protected const byte SUBCMD_SET_IMU_SENSITIVITY = 65;
	protected const byte SUBCMD_WRITE_IMU_REG = 66;
	protected const byte SUBCMD_READ_IMU_REG = 67;
	protected const byte SUBCMD_ENABLE_VIBRATION = 72;
	protected const byte SUBCMD_GET_REGULATED_VOLTAGE = 80;
	protected const byte INPUT_BUTTON_EVENT = 63;
	protected const byte INPUT_SUBCMD_REPLY = 33;
	protected const byte INPUT_IMU_DATA = 48;
	protected const byte INPUT_MCU_DATA = 49;
	protected const byte INPUT_USB_RESPONSE = 129;
	protected const byte FEATURE_LAST_SUBCMD = 2;
	protected const byte FEATURE_OTA_FW_UPGRADE = 112;
	protected const byte FEATURE_SETUP_MEM_READ = 113;
	protected const byte FEATURE_MEM_READ = 114;
	protected const byte FEATURE_ERASE_MEM_SECTOR = 115;
	protected const byte FEATURE_MEM_WRITE = 116;
	protected const byte FEATURE_LAUNCH = 117;
	protected const byte USB_CMD_CONN_STATUS = 1;
	protected const byte USB_CMD_HANDSHAKE = 2;
	protected const byte USB_CMD_BAUDRATE_3M = 3;
	protected const byte USB_CMD_NO_TIMEOUT = 4;
	protected const byte USB_CMD_EN_TIMEOUT = 5;
	protected const byte USB_RESET = 6;
	protected const byte USB_PRE_HANDSHAKE = 145;
	protected const byte USB_SEND_UART = 146;
	protected const ushort CAL_DATA_START = 24637;
	protected const ushort CAL_DATA_END = 24654;
	protected const ushort CAL_DATA_SIZE = 18;
	protected const int MIN_INPUT_REPORT_SIZE = 49;
	protected const int SUBCOMMAND_INPUT_REPORT_SIZE = 49;
	protected const float VIBRATION_FREQUENCY_LOW_MIN = 40.875885;
	protected const float VIBRATION_FREQUENCY_LOW_MAX = 626.28613;
	protected const float VIBRATION_FREQUENCY_HIGH_MIN = 81.75177;
	protected const float VIBRATION_FREQUENCY_HIGH_MAX = 1252.5723;
	protected const float NOINPUTREPORT_REINIT_HACK_TIMEOUT_SEC = 1;
	protected const int DEVICE_POLL_RATE_HZ = 66;
	protected const int HID_AXIS_MIN_VALUE = 0;
	protected const int HID_AXIS_MAX_VALUE = 65535;
	protected const int HID_AXIS_ZERO_VALUE = 32767;
	protected const int HID_AXIS_BITS = 16;
	protected const int HID_AXIS_BYTES = 2;
	protected readonly NintendoSwitchGamepadDriver.TcyrPLPfzGgITAruLwqcettRbltv _controllerType; // 0x58
	protected readonly int _buttonCount; // 0x5C
	protected readonly int _axisCount; // 0x60
	protected readonly int _vibrationMotorCount; // 0x64
	private readonly HIDDeviceDriver.IHIDDevice agdAUrOskycecJHYieJdannkwlTjb; // 0x68
	private readonly HIDDeviceDriver.HIDProperties cXetojNJCijVTfpMOfTwGFFBWEAL; // 0x70
	private readonly bool fXDdrjUskIGypVdPQgMhiIVvCeZpA; // 0x98
	private readonly NativeBuffer mlWZARlfUoYCMLkDaVlKXkxrVlYs; // 0xA0
	private readonly NativeBuffer qhzeVzBTSrDGcGTpeQeyciMBAuyz; // 0xA8
	private readonly NativeBuffer iFomqbBcoDLzLFihMCeVjkaxFpjn; // 0xB0
	private readonly byte[] ByRJeUoLumshLYxReMTOAhWeYGOL; // 0xB8
	private readonly NativeBuffer XXfVXtDscQeZYALbvBjzMHeWIyX; // 0xC0
	private readonly NativeBuffer OkPgmsTBqXHbrZMPQFtIdSstqZFt; // 0xC8
	private ndPzSZhFNVeBDFDFsrPPRfBbUpJt AbAdUSRKPDZpgpnDmPVvtToVeyk; // 0xD0
	private double vTXkqhdynadjbHorjAgDhQvmViVJ; // 0xE8
	private byte jjiAvWXoXNGlOxumlvTsCxBnkKGR; // 0xF0
	private double qLwEQxpbMfCKDKsoYWAbudHojCyGA; // 0xF8
	private bool RyvduUgDcJCKtVuNqaDTUFHyFrVr; // 0x100
	private bool IEHeSyDCfDkAOlJEYwWzahfclqIiA; // 0x101
	private NintendoSwitchGamepadDriver.lSlfWqNcBNTEzYnePjZAnPiaDhQG[] WGkBqYjiLemafvXZEDbfbpxuCtvGA; // 0x108
	private NintendoSwitchGamepadDriver.IWHIwelovzjgYbNkzspktfxZGJUF[] NWrVVLBDUcAGcAigaTUlvYWEMyDA; // 0x110
	private static readonly byte[] FKMAGstMGiOAVpxUiErqgasiFEOt; // 0x0

	// Properties
	public int vibrationMotorCount { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x3F3740 Offset: 0x3F1D40 VA: 0x1803F3740 Slot: 17
	public int get_vibrationMotorCount() { }

	// RVA: 0x19D4AD0 Offset: 0x19D30D0 VA: 0x1819D4AD0 Slot: 18
	public void GetVibration(int motorIndex, out float amplitudeLow, out float frequencyLow, out float amplitudeHigh, out float frequencyHigh) { }

	// RVA: 0x19D5990 Offset: 0x19D3F90 VA: 0x1819D5990 Slot: 19
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) { }

	// RVA: 0x19D5B30 Offset: 0x19D4130 VA: 0x1819D5B30 Slot: 20
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, bool stopOtherMotors) { }

	// RVA: 0x19D5910 Offset: 0x19D3F10 VA: 0x1819D5910 Slot: 21
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration) { }

	// RVA: 0x19D5A10 Offset: 0x19D4010 VA: 0x1819D5A10 Slot: 22
	public void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration, bool stopOtherMotors) { }

	// RVA: 0x19D5BE0 Offset: 0x19D41E0 VA: 0x1819D5BE0 Slot: 23
	public void StopVibration(int motorIndex) { }

	// RVA: 0x19D5B80 Offset: 0x19D4180 VA: 0x1819D5B80 Slot: 24
	public void StopVibration() { }

	// RVA: 0x19D42A0 Offset: 0x19D28A0 VA: 0x1819D42A0
	private void BLwvAnLOGykuTMAUMGYabAAqAXNNA(int ) { }

	// RVA: 0x19D5900 Offset: 0x19D3F00 VA: 0x1819D5900 Slot: 25
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x19D58D0 Offset: 0x19D3ED0 VA: 0x1819D58D0 Slot: 26
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400 Slot: 27
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510 Slot: 28
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x19D58E0 Offset: 0x19D3EE0 VA: 0x1819D58E0 Slot: 29
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x19D58F0 Offset: 0x19D3EF0 VA: 0x1819D58F0 Slot: 30
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x19D6260 Offset: 0x19D4860 VA: 0x1819D6260
	protected void .ctor(HIDDeviceDriver.InitArgs , NintendoSwitchGamepadDriver.TcyrPLPfzGgITAruLwqcettRbltv , int , int , int ) { }

	// RVA: 0x19D4B60 Offset: 0x19D3160 VA: 0x1819D4B60
	protected void Initialize() { }

	// RVA: 0x19D5D90 Offset: 0x19D4390 VA: 0x1819D5D90 Slot: 13
	public override void Update(UpdateLoopType updateLoop) { }

	// RVA: 0x19D5720 Offset: 0x19D3D20 VA: 0x1819D5720 Slot: 14
	public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp) { }

	// RVA: -1 Offset: -1 Slot: 31
	protected abstract void UpdateButtons(NativeBuffer inputReport, double timestamp);

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract void UpdateElements(GLNYbQuaOXeaSToXMWjUhtXAplaf[] elements, NativeBuffer inputReport, double timestamp);

	// RVA: 0x19D7170 Offset: 0x19D5770 VA: 0x1819D7170
	private bool yLHMsUuIihuDprnoMjEyDEYeZdTR(NintendoSwitchGamepadDriver.IJCDGwaUnZjoCnuWhUPRMrwFNEXC , byte[] ) { }

	// RVA: 0x19D5C30 Offset: 0x19D4230 VA: 0x1819D5C30
	private bool UKwfbwNbZEwZmjMGvdWglQQAmfSg(NativeBuffer , byte ) { }

	// RVA: 0x19D6B90 Offset: 0x19D5190 VA: 0x1819D6B90
	private void iHrNEMpLXQrlxMdKDDHBpjcPctCGA(byte ) { }

	// RVA: 0x19D6060 Offset: 0x19D4660 VA: 0x1819D6060
	private void WwneIQZBtJQaycWoXrPeejZivjJd(byte , NativeBuffer , int , GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19D6D60 Offset: 0x19D5360 VA: 0x1819D6D60
	private void kmfknKEtuJQiNNkIvWbtOHgtbyCR(NativeBuffer ) { }

	// RVA: 0x19D6C60 Offset: 0x19D5260 VA: 0x1819D6C60
	private void jKBsOlSPSVptlYpIKGCzDFNKbLYA(NativeBuffer , int ) { }

	// RVA: 0x19D5330 Offset: 0x19D3930 VA: 0x1819D5330
	private static void LMuMotnkXZQHvvwEqUPnATYmbpRd(NativeBuffer , int , NintendoSwitchGamepadDriver.jnLEXiChHTfgKGUsPaOnLAMMfUunA ) { }

	// RVA: 0x19D5170 Offset: 0x19D3770 VA: 0x1819D5170
	private static byte LBBXIGLAvnpNTCSLjaltShyZSzWt(float ) { }

	// RVA: 0x19D6FF0 Offset: 0x19D55F0 VA: 0x1819D6FF0
	private void wsvvUyLbsXxNgxZjTFACPsjrEMQeA(GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19D6DE0 Offset: 0x19D53E0 VA: 0x1819D6DE0
	private bool tMDjasoTiSoGFVtCKUyWeqcoyQkg() { }

	// RVA: 0x19D6ED0 Offset: 0x19D54D0 VA: 0x1819D6ED0
	private bool vXeTbwpRCrElMNelOmXdcePtvWAE(bool ) { }

	// RVA: 0x19D5570 Offset: 0x19D3B70 VA: 0x1819D5570
	private bool NUvobLICjOdHXqxVnlcejkGCdYnS(byte , byte , byte , byte[] ) { }

	// RVA: 0x19D4330 Offset: 0x19D2930 VA: 0x1819D4330
	private bool DABoxZkCwcatwJyIrgukLCgwHVsMA(GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19D4850 Offset: 0x19D2E50 VA: 0x1819D4850
	private byte DsRPzbcaUIDfkDasQFpqcAKKPFjjb() { }

	// RVA: 0x19D7730 Offset: 0x19D5D30 VA: 0x1819D7730
	private bool yoeGmlEgXMnkGNQHbzuaFfmhvUzY() { }

	// RVA: 0x19D69A0 Offset: 0x19D4FA0 VA: 0x1819D69A0
	private static void dGqMHpsslQnTZfNTdSrtjVnJkrGk(byte[] , NintendoSwitchGamepadDriver.IWHIwelovzjgYbNkzspktfxZGJUF , NintendoSwitchGamepadDriver.IWHIwelovzjgYbNkzspktfxZGJUF , bool ) { }

	// RVA: 0x19D6180 Offset: 0x19D4780 VA: 0x1819D6180
	private static void ZrhBjwjvoBXbBfGtuDmQheweFXREB(byte[] , NintendoSwitchGamepadDriver.IWHIwelovzjgYbNkzspktfxZGJUF , NintendoSwitchGamepadDriver.IWHIwelovzjgYbNkzspktfxZGJUF ) { }

	// RVA: 0x19D48B0 Offset: 0x19D2EB0 VA: 0x1819D48B0
	protected bool GetCalibratedStickValue(ushort valueX, ushort valueY, NintendoSwitchGamepadDriver.IWHIwelovzjgYbNkzspktfxZGJUF calX, NintendoSwitchGamepadDriver.IWHIwelovzjgYbNkzspktfxZGJUF calY, out ushort calibratedX, out ushort calibratedY) { }

	// RVA: 0x19D4880 Offset: 0x19D2E80 VA: 0x1819D4880
	protected NintendoSwitchGamepadDriver.IWHIwelovzjgYbNkzspktfxZGJUF GetAxisCalibration(int index) { }

	// RVA: 0x19D5F60 Offset: 0x19D4560 VA: 0x1819D5F60
	private void VkIzmSeLHIAkFrTkTNapmiBCaIMcA(bool ) { }

	// RVA: 0x19C9530 Offset: 0x19C7B30 VA: 0x1819C9530 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19D45B0 Offset: 0x19D2BB0 VA: 0x1819D45B0 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x19D5FD0 Offset: 0x19D45D0 VA: 0x1819D5FD0
	private static void WizFCMkpfqkHafZcDdMRrzcPHKJJ(NativeBuffer , int ) { }

	// RVA: 0x19D6B00 Offset: 0x19D5100 VA: 0x1819D6B00
	private static void fnEkaDvpHwasnPaoYvqpqIVYasHk(byte[] , int ) { }

	[Conditional("DEBUG_THIS")]
	// RVA: 0x19D4540 Offset: 0x19D2B40 VA: 0x1819D4540
	protected static void DLog(object msg) { }

	// RVA: 0x19D61D0 Offset: 0x19D47D0 VA: 0x1819D61D0
	private static void .cctor() { }
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal abstract class NintendoSwitchJoyConDriver : NintendoSwitchGamepadDriver, IDriver_NintendoSwitchJoyCon, IDriver_NintendoSwitchController, IControllerDriver, IHIDControllerExtension, IAxisCalibrationIndexMap // TypeDefIndex: 6542
{
	// Fields
	private const int RBePpdABnOsrIeDfVBNhBxcQLZsK = 11;
	private const int PrbEqXqcsAxtfYwXhkwzSiFZVFsc = 2;
	private const int aiiEeXHFDgIVrKsSoJrmRcQjDmiV = 1;
	private const int TeeHuehAzIRDZEWHSVFMHEobqkDDb = 1;
	private const int PRRzFDddtLuhJwAiHQpdkEWvYJud = 3;
	private readonly NativeBuffer GVMzoKfoKBJGuadaEBknrBPgvkDRA; // 0x118
	private readonly NintendoSwitchJoyConType zUIKGqDNMwxJlqvzzbLlnfmdcvMj; // 0x120
	private NintendoSwitchJoyConGripStyle yHLqWVDvMhRwChzcmqOwQwjcNHhw; // 0x124
	private readonly byte[] AizjWksJsdrpHRVodRdEgGFTauBk; // 0x128

	// Properties
	protected byte[] buttonAxisReadBuffer { get; }
	protected abstract int byteIndexStartSticks { get; }
	public NintendoSwitchJoyConType joyConType { get; }
	public NintendoSwitchJoyConGripStyle joyConGripStyle { get; set; }

	// Methods

	// RVA: 0x19DB6F0 Offset: 0x19D9CF0 VA: 0x1819DB6F0
	protected byte[] get_buttonAxisReadBuffer() { }

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract int get_byteIndexStartSticks();

	// RVA: 0x19DB710 Offset: 0x19D9D10 VA: 0x1819DB710 Slot: 33
	public NintendoSwitchJoyConType get_joyConType() { }

	// RVA: 0x19DB700 Offset: 0x19D9D00 VA: 0x1819DB700 Slot: 34
	public NintendoSwitchJoyConGripStyle get_joyConGripStyle() { }

	// RVA: 0x19DB720 Offset: 0x19D9D20 VA: 0x1819DB720 Slot: 35
	public void set_joyConGripStyle(NintendoSwitchJoyConGripStyle value) { }

	// RVA: 0x19DB150 Offset: 0x19D9750 VA: 0x1819DB150 Slot: 36
	private int Rewired.Interfaces.IAxisCalibrationIndexMap.GetMappedAxisIndex(int elementIndex) { }

	// RVA: 0x19DB380 Offset: 0x19D9980 VA: 0x1819DB380
	protected void .ctor(HIDDeviceDriver.InitArgs , NintendoSwitchGamepadDriver.TcyrPLPfzGgITAruLwqcettRbltv ) { }

	// RVA: 0x19DB030 Offset: 0x19D9630 VA: 0x1819DB030 Slot: 15
	public override Controller.Extension CreateControllerExtension() { }

	// RVA: 0x19DB170 Offset: 0x19D9770 VA: 0x1819DB170 Slot: 32
	protected override void UpdateElements(GLNYbQuaOXeaSToXMWjUhtXAplaf[] elements, NativeBuffer inputReport, double timestamp) { }

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract void HandleGripStyleStickAxisSwap(ref ushort stickX, ref ushort stickY);

	// RVA: 0x19DB0E0 Offset: 0x19D96E0 VA: 0x1819DB0E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19DB090 Offset: 0x19D9690 VA: 0x1819DB090 Slot: 16
	protected override void Dispose(bool disposing) { }
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal sealed class NintendoSwitchJoyConLeftDriver : NintendoSwitchJoyConDriver // TypeDefIndex: 6543
{
	// Fields
	private const int hBrwENtBQnuxUvCCZRVEHrFDFKpfA = 4;
	private const int jQTFelKZIllhzAUOfQOsepqYFPem = 6;

	// Properties
	protected override int byteIndexStartSticks { get; }

	// Methods

	// RVA: 0x45C3F0 Offset: 0x45A9F0 VA: 0x18045C3F0 Slot: 37
	protected override int get_byteIndexStartSticks() { }

	// RVA: 0x19DBB80 Offset: 0x19DA180 VA: 0x1819DBB80
	public void .ctor(HIDDeviceDriver.InitArgs ) { }

	// RVA: 0x19DB7E0 Offset: 0x19D9DE0 VA: 0x1819DB7E0 Slot: 31
	protected override void UpdateButtons(NativeBuffer inputReport, double timestamp) { }

	// RVA: 0x19DB7A0 Offset: 0x19D9DA0 VA: 0x1819DB7A0 Slot: 38
	protected override void HandleGripStyleStickAxisSwap(ref ushort stickX, ref ushort stickY) { }

	// RVA: 0x19DB730 Offset: 0x19D9D30 VA: 0x1819DB730 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19DB090 Offset: 0x19D9690 VA: 0x1819DB090 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x19DB7C0 Offset: 0x19D9DC0 VA: 0x1819DB7C0
	public static bool Matches(int vid, int pid) { }
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal sealed class SwitchJoyConRightDriver : NintendoSwitchJoyConDriver // TypeDefIndex: 6544
{
	// Fields
	private const int PgJuxePOSlhBSLNNEOIQlnDMxQgC = 3;
	private const int DzmgoidTkbXhqiXMCZbniBYmOqDgb = 9;

	// Properties
	protected override int byteIndexStartSticks { get; }

	// Methods

	// RVA: 0x458E50 Offset: 0x457450 VA: 0x180458E50 Slot: 37
	protected override int get_byteIndexStartSticks() { }

	// RVA: 0x19DDCD0 Offset: 0x19DC2D0 VA: 0x1819DDCD0
	public void .ctor(HIDDeviceDriver.InitArgs ) { }

	// RVA: 0x19DDA00 Offset: 0x19DC000 VA: 0x1819DDA00 Slot: 31
	protected override void UpdateButtons(NativeBuffer inputReport, double timestamp) { }

	// RVA: 0x19DD9C0 Offset: 0x19DBFC0 VA: 0x1819DD9C0 Slot: 38
	protected override void HandleGripStyleStickAxisSwap(ref ushort stickX, ref ushort stickY) { }

	// RVA: 0x19DB730 Offset: 0x19D9D30 VA: 0x1819DB730 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19DB090 Offset: 0x19D9690 VA: 0x1819DB090 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x19DD9E0 Offset: 0x19DBFE0 VA: 0x1819DD9E0
	public static bool Matches(int vid, int pid) { }
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal sealed class NintendoSwitchProControllerDriver : NintendoSwitchGamepadDriver, IDriver_NintendoSwitchProController, IDriver_NintendoSwitchController, IControllerDriver, IHIDControllerExtension // TypeDefIndex: 6545
{
	// Fields
	private const int iWtEdVRnpUFbWCcfuxhfctioiAAL = 18;
	private const int zYYXkxCVYlnuTWcSpqHlVzFcoAZs = 4;
	private const int zbrTxvZrUrmPVrJNzuCeKBQIhxnd = 2;
	private const int AItFellXQKGZvnLMsHEmcLPdTxcc = 3;
	private const int cACBCzBxedDyzlMjLoPhEznOfKjs = 6;
	private const int mUOMoDBjVAuejcWCrhXBbDMEosui = 1;
	private const int hJOkzSDBpBXyjkyqjpvqFESfXQFC = 3;
	private const int LUwYoskJzanyTpAqRVkzAOUEbLrU = 5;
	private const int dsaXLnUYaFzxhGCPXxPBjFahRxPG = 7;
	private readonly byte[] EbNGzmyNVrIGSZSisSZAFCnYdwKfA; // 0x118
	private readonly NativeBuffer McWNvZieiYYqznmRdUzHKNudHVHc; // 0x120

	// Methods

	// RVA: 0x19DC530 Offset: 0x19DAB30 VA: 0x1819DC530
	public void .ctor(HIDDeviceDriver.InitArgs ) { }

	// RVA: 0x19DC520 Offset: 0x19DAB20 VA: 0x1819DC520 Slot: 13
	public override void Update(UpdateLoopType updateLoop) { }

	// RVA: 0x19DBB90 Offset: 0x19DA190 VA: 0x1819DBB90 Slot: 15
	public override Controller.Extension CreateControllerExtension() { }

	// RVA: 0x19DBC60 Offset: 0x19DA260 VA: 0x1819DBC60 Slot: 31
	protected override void UpdateButtons(NativeBuffer inputReport, double timestamp) { }

	// RVA: 0x19DC240 Offset: 0x19DA840 VA: 0x1819DC240 Slot: 32
	protected override void UpdateElements(GLNYbQuaOXeaSToXMWjUhtXAplaf[] elements, NativeBuffer inputReport, double timestamp) { }

	// RVA: 0x19DB0E0 Offset: 0x19D96E0 VA: 0x1819DB0E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19DBBF0 Offset: 0x19DA1F0 VA: 0x1819DBBF0 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x19DBC40 Offset: 0x19DA240 VA: 0x1819DBC40
	public static bool Matches(int vid, int pid) { }
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
internal class RailDriverDriver : HIDDeviceDriver, IDisposable, IDriver_RailDriver, IControllerDriver, IHIDControllerExtension // TypeDefIndex: 6547
{
	// Fields
	private const int NXudYJbwGBRZHaXAcKFbKZkvccJQA = 1523;
	private const int dBiMpPEZfTIwjlFdREIMILZknXAQ = 210;
	private const int nLoETJcTEudqqcsZpAQfeCqBUIX = 50;
	private const int NQZkwDszvpNPaIwnuLbJmLjqejIIA = 44;
	private const int KjicWaRLflcBNulaQxuiWgDpuWDI = 6;
	private const int pkdFiImJvjWGdxGnFZFKyChxzcuR = 44;
	private const int ROGmzBzBzbfcEfTsQfDgcHqEGLhrb = 45;
	private const int oXRqVnRlMvtMCJFKiUihtzyTGVYf = 46;
	private const int yGLVXewAPEuTfoiRvRPbZGHCkcRs = 47;
	private const int asNmeQSscCryVaaPklAZkJdHHLrk = 48;
	private const int wVsQDIozmpBtTNDolmhDMNiGhAjX = 49;
	private const int xIsnChYuVrSbGtyTAjIWwkLGGDKd = 0;
	private const int mLABwFbDUCKcAXsPZMoXkxeMecJaA = 15;
	private const int HYPJDbyfNtbeDefcidTtCRTjqmgab = 9;
	private const int bYQGakKTIhyEVTucXzyhdwdcuJWQA = 1;
	private const int PdxeJffjtEcjIaaMMyfAfZesZCEdA = 2;
	private const int pmojEbhmxqqjyWgAatoDhJirrdyC = 3;
	private const int XonByXdeWXgFxHVNegZoHOXRHjgqb = 4;
	private const int jfaFYKYWloTAFYYtyJSVPpknjTVy = 5;
	private const int IUPvkIRercGKbbBskjBkIIBigxLV = 6;
	private const int BMQeLPBijGofGwVSbEPbtqVyHLjl = 7;
	private const int BpaswIDZbSWnVjpXUGEXMfWOAgBgA = 8;
	private const int BzopXzNWeiHLEVLSJgkSkzEUWXTC = 14;
	private const int TnhlRyQlFaeAVjfkQqdiILMvEBpI = 3;
	private const int BsIGZKCFnLioYbipAbWhOSgcpJKhc = 7;
	private readonly NativeBuffer lqQjgrehqPiyWqRbbJjrmxUAmNId; // 0x58
	private readonly NativeBuffer BmXLNMASCdqMwdmkLBqJqfAmKrTT; // 0x60
	private bool jxpZyeeWyhLUgPalaLmelDsDuwkK; // 0x68
	private byte[] nfzMHuhfhOAjGEkJlrtSTwfFNWxm; // 0x70
	private readonly HIDDeviceDriver.IHIDDevice yHwrIBEOkmcvEPMNYOvXxNKYHziF; // 0x78
	private readonly HIDDeviceDriver.HIDProperties QmwoQVtBjnHuOgXTHLUcpPoZXdsw; // 0x80
	private readonly ndPzSZhFNVeBDFDFsrPPRfBbUpJt VMvREOiDIYvijvvAGiGORwEaadRM; // 0xA8

	// Properties
	public bool SpeakerEnabled { get; set; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.vendorId { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.productId { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.productName { get; }
	private string Rewired.ControllerExtensions.IHIDControllerExtension.manufacturer { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usagePage { get; }
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.usage { get; }

	// Methods

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950 Slot: 17
	public bool get_SpeakerEnabled() { }

	// RVA: 0x19DD6E0 Offset: 0x19DBCE0 VA: 0x1819DD6E0 Slot: 18
	public void set_SpeakerEnabled(bool value) { }

	// RVA: 0x19DCEF0 Offset: 0x19DB4F0 VA: 0x1819DCEF0 Slot: 19
	public void SetLEDDisplay(int digitIndex, byte digitBitValues) { }

	// RVA: 0x19DCF40 Offset: 0x19DB540 VA: 0x1819DCF40 Slot: 20
	public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues) { }

	// RVA: 0x15D1070 Offset: 0x15CF670 VA: 0x1815D1070 Slot: 21
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_vendorId() { }

	// RVA: 0x1641020 Offset: 0x163F620 VA: 0x181641020 Slot: 22
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_productId() { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0 Slot: 23
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_productName() { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80 Slot: 24
	private string Rewired.ControllerExtensions.IHIDControllerExtension.get_manufacturer() { }

	// RVA: 0x19DCED0 Offset: 0x19DB4D0 VA: 0x1819DCED0 Slot: 25
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usagePage() { }

	// RVA: 0x19DCEE0 Offset: 0x19DB4E0 VA: 0x1819DCEE0 Slot: 26
	private ushort Rewired.ControllerExtensions.IHIDControllerExtension.get_usage() { }

	// RVA: 0x19DCFB0 Offset: 0x19DB5B0 VA: 0x1819DCFB0
	public void .ctor(HIDDeviceDriver.InitArgs ) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	public override void Update(UpdateLoopType updateLoop) { }

	// RVA: 0x19DCBF0 Offset: 0x19DB1F0 VA: 0x1819DCBF0 Slot: 14
	public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp) { }

	// RVA: 0x19DC990 Offset: 0x19DAF90 VA: 0x1819DC990 Slot: 15
	public override Controller.Extension CreateControllerExtension() { }

	// RVA: 0x19DD6B0 Offset: 0x19DBCB0 VA: 0x1819DD6B0
	private bool hkxcNXMwOaYZzorgATgKMoYwaUmU(RailDriverDriver.yXfVtKGdUdsoyeOJeIjnFuoNbLdeb , GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19DCA70 Offset: 0x19DB070 VA: 0x1819DCA70
	private void PMklFycNdyqkGHdJNZfdaBenHqsJA(RailDriverDriver.yXfVtKGdUdsoyeOJeIjnFuoNbLdeb ) { }

	// RVA: 0x19DCCC0 Offset: 0x19DB2C0 VA: 0x1819DCCC0
	private bool QDkTLFzUUcGpGtAKfSWArxqsWXDe(GCmaQhFpjWTiwKeLtoDuCusTJlUIb ) { }

	// RVA: 0x19DD750 Offset: 0x19DBD50 VA: 0x1819DD750
	private void wyDiLFwXwkPMHhvkFtOfZzOKXspG(NativeBuffer , double ) { }

	// RVA: 0x19CA6C0 Offset: 0x19C8CC0 VA: 0x1819CA6C0
	private void lTZgmDMWSOTaoMGDHVPdIbdklcOQ(GLNYbQuaOXeaSToXMWjUhtXAplaf[] , NativeBuffer , double ) { }

	// RVA: 0x19C9530 Offset: 0x19C7B30 VA: 0x1819C9530 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19DC9F0 Offset: 0x19DAFF0 VA: 0x1819DC9F0 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x19DCA50 Offset: 0x19DB050 VA: 0x1819DCA50
	public static bool Matches(int vid, int pid) { }
}

