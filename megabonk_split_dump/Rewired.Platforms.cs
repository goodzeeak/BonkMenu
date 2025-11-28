// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum Platform // TypeDefIndex: 2225
{
	// Fields
	public int value__; // 0x0
	public const Platform Unknown = 0;
	public const Platform Windows = 1;
	public const Platform WindowsAppStore = 2;
	public const Platform WindowsPhone8 = 3;
	public const Platform OSX = 4;
	public const Platform iOS = 5;
	public const Platform Linux = 6;
	public const Platform Android = 7;
	public const Platform Blackberry = 8;
	public const Platform Webplayer = 9;
	public const Platform Xbox360 = 10;
	public const Platform XboxOne = 11;
	public const Platform PS3 = 12;
	public const Platform PS4 = 13;
	public const Platform PSVita = 14;
	public const Platform PSMobile = 15;
	public const Platform Wii = 16;
	public const Platform Flash = 17;
	public const Platform WiiU = 18;
	public const Platform WebGL = 19;
	public const Platform Tizen = 20;
	public const Platform Xenon = 21;
	public const Platform STV = 22;
	public const Platform NACL = 23;
	public const Platform NACL_Webplayer = 24;
	public const Platform NACL_Chrome = 25;
	public const Platform SamsungTV = 26;
	public const Platform Pepper = 27;
	public const Platform tvOS = 28;
	public const Platform WindowsUWP = 29;
	public const Platform Windows81Store = 30;
	public const Platform N3DS = 31;
	public const Platform Switch = 32;
	public const Platform Switch2 = 33;
	public const Platform Ouya = 100;
	public const Platform AmazonFireTV = 101;
	public const Platform RazerForgeTV = 102;
	public const Platform GameCoreXboxOne = 104;
	public const Platform GameCoreScarlett = 105;
	public const Platform PS5 = 106;
	public const Platform Custom = 10000;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum EditorPlatform // TypeDefIndex: 2226
{
	// Fields
	public int value__; // 0x0
	public const EditorPlatform None = 0;
	public const EditorPlatform OSX = 1;
	public const EditorPlatform Windows = 2;
	public const EditorPlatform Linux = 3;
	public const EditorPlatform Unknown = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum WebplayerPlatform // TypeDefIndex: 2227
{
	// Fields
	public int value__; // 0x0
	public const WebplayerPlatform None = 0;
	public const WebplayerPlatform Windows = 1;
	public const WebplayerPlatform OSX = 2;
	public const WebplayerPlatform Unknown = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum ScriptingBackend // TypeDefIndex: 2228
{
	// Fields
	public int value__; // 0x0
	public const ScriptingBackend Mono = 0;
	public const ScriptingBackend DotNet = 1;
	public const ScriptingBackend IL2CPP = 2;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum ScriptingAPILevel // TypeDefIndex: 2229
{
	// Fields
	public int value__; // 0x0
	public const ScriptingAPILevel Net20 = 0;
	public const ScriptingAPILevel Net20Subset = 1;
	public const ScriptingAPILevel Net46 = 2;
	public const ScriptingAPILevel NetStandard20 = 3;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum WindowsStandalonePrimaryInputSource // TypeDefIndex: 2230
{
	// Fields
	public int value__; // 0x0
	public const WindowsStandalonePrimaryInputSource RawInput = 0;
	public const WindowsStandalonePrimaryInputSource DirectInput = 1;
	public const WindowsStandalonePrimaryInputSource XInput = 2;
	public const WindowsStandalonePrimaryInputSource WindowsGamingInput = 3;
	public const WindowsStandalonePrimaryInputSource SDL2 = 10;
	public const WindowsStandalonePrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum OSXStandalonePrimaryInputSource // TypeDefIndex: 2231
{
	// Fields
	public int value__; // 0x0
	public const OSXStandalonePrimaryInputSource Native = 0;
	public const OSXStandalonePrimaryInputSource GameController = 1;
	public const OSXStandalonePrimaryInputSource SDL2 = 10;
	public const OSXStandalonePrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum LinuxStandalonePrimaryInputSource // TypeDefIndex: 2232
{
	// Fields
	public int value__; // 0x0
	public const LinuxStandalonePrimaryInputSource Native = 0;
	public const LinuxStandalonePrimaryInputSource SDL2 = 10;
	public const LinuxStandalonePrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum WindowsUWPPrimaryInputSource // TypeDefIndex: 2233
{
	// Fields
	public int value__; // 0x0
	public const WindowsUWPPrimaryInputSource Native = 0;
	public const WindowsUWPPrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum XboxOnePrimaryInputSource // TypeDefIndex: 2234
{
	// Fields
	public int value__; // 0x0
	public const XboxOnePrimaryInputSource Native = 0;
	public const XboxOnePrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum GameCoreXboxOnePrimaryInputSource // TypeDefIndex: 2235
{
	// Fields
	public int value__; // 0x0
	public const GameCoreXboxOnePrimaryInputSource Native = 0;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum GameCoreScarlettPrimaryInputSource // TypeDefIndex: 2236
{
	// Fields
	public int value__; // 0x0
	public const GameCoreScarlettPrimaryInputSource Native = 0;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum PS4PrimaryInputSource // TypeDefIndex: 2237
{
	// Fields
	public int value__; // 0x0
	public const PS4PrimaryInputSource PS4Input = 0;
	public const PS4PrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum PS5PrimaryInputSource // TypeDefIndex: 2238
{
	// Fields
	public int value__; // 0x0
	public const PS5PrimaryInputSource PS5Input = 0;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum WebGLPrimaryInputSource // TypeDefIndex: 2239
{
	// Fields
	public int value__; // 0x0
	public const WebGLPrimaryInputSource Native = 0;
	public const WebGLPrimaryInputSource Unity = 100;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum DirectInputAxis // TypeDefIndex: 2240
{
	// Fields
	public int value__; // 0x0
	public const DirectInputAxis None = 0;
	public const DirectInputAxis X = 1;
	public const DirectInputAxis Y = 2;
	public const DirectInputAxis Z = 3;
	public const DirectInputAxis RotationX = 4;
	public const DirectInputAxis RotationY = 5;
	public const DirectInputAxis RotationZ = 6;
	public const DirectInputAxis Slider0 = 7;
	public const DirectInputAxis Slider1 = 8;
	public const DirectInputAxis VelocityX = 9;
	public const DirectInputAxis VelocityY = 10;
	public const DirectInputAxis VelocityZ = 11;
	public const DirectInputAxis AngularVelocityX = 12;
	public const DirectInputAxis AngularVelocityY = 13;
	public const DirectInputAxis AngularVelocityZ = 14;
	public const DirectInputAxis VelocitySlider0 = 15;
	public const DirectInputAxis VelocitySlider1 = 16;
	public const DirectInputAxis AccelerationX = 17;
	public const DirectInputAxis AccelerationY = 18;
	public const DirectInputAxis AccelerationZ = 19;
	public const DirectInputAxis AngularAccelerationX = 20;
	public const DirectInputAxis AngularAccelerationY = 21;
	public const DirectInputAxis AngularAccelerationZ = 22;
	public const DirectInputAxis AccelerationSlider0 = 23;
	public const DirectInputAxis AccelerationSlider1 = 24;
	public const DirectInputAxis ForceX = 25;
	public const DirectInputAxis ForceY = 26;
	public const DirectInputAxis ForceZ = 27;
	public const DirectInputAxis TorqueX = 28;
	public const DirectInputAxis TorqueY = 29;
	public const DirectInputAxis TorqueZ = 30;
	public const DirectInputAxis ForceSlider0 = 31;
	public const DirectInputAxis ForceSlider1 = 32;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum RawInputAxis // TypeDefIndex: 2241
{
	// Fields
	public int value__; // 0x0
	public const RawInputAxis None = 0;
	public const RawInputAxis X = 1;
	public const RawInputAxis Y = 2;
	public const RawInputAxis Z = 3;
	public const RawInputAxis RotationX = 4;
	public const RawInputAxis RotationY = 5;
	public const RawInputAxis RotationZ = 6;
	public const RawInputAxis Slider0 = 7;
	public const RawInputAxis Slider1 = 8;
	public const RawInputAxis VelocityX = 9;
	public const RawInputAxis VelocityY = 10;
	public const RawInputAxis VelocityZ = 11;
	public const RawInputAxis Other = 1000;
}

// Namespace: Rewired.Platforms
public enum XInputDeviceSubType // TypeDefIndex: 2242
{
	// Fields
	public int value__; // 0x0
	public const XInputDeviceSubType Gamepad = 1;
	public const XInputDeviceSubType Wheel = 2;
	public const XInputDeviceSubType ArcadeStick = 3;
	public const XInputDeviceSubType FlightStick = 4;
	public const XInputDeviceSubType DancePad = 5;
	public const XInputDeviceSubType Guitar = 6;
	public const XInputDeviceSubType GuitarAlternate = 7;
	public const XInputDeviceSubType DrumKit = 8;
	public const XInputDeviceSubType GuitarBass = 11;
	public const XInputDeviceSubType ArcadePad = 19;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum XInputAxis // TypeDefIndex: 2243
{
	// Fields
	public int value__; // 0x0
	public const XInputAxis None = 0;
	public const XInputAxis LeftThumbX = 1;
	public const XInputAxis LeftThumbY = 2;
	public const XInputAxis RightThumbX = 3;
	public const XInputAxis RightThumbY = 4;
	public const XInputAxis LeftTrigger = 5;
	public const XInputAxis RightTrigger = 6;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum XInputButton // TypeDefIndex: 2244
{
	// Fields
	public int value__; // 0x0
	public const XInputButton None = 0;
	public const XInputButton A = 1;
	public const XInputButton B = 2;
	public const XInputButton X = 3;
	public const XInputButton Y = 4;
	public const XInputButton LeftShoulder = 5;
	public const XInputButton RightShoulder = 6;
	public const XInputButton LeftThumb = 7;
	public const XInputButton RightThumb = 8;
	public const XInputButton Start = 9;
	public const XInputButton Back = 10;
	public const XInputButton DPadUp = 11;
	public const XInputButton DPadRight = 12;
	public const XInputButton DPadDown = 13;
	public const XInputButton DPadLeft = 14;
	public const XInputButton Guide = 15;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum OSXAxis // TypeDefIndex: 2245
{
	// Fields
	public int value__; // 0x0
	public const OSXAxis None = 0;
	public const OSXAxis X = 1;
	public const OSXAxis Y = 2;
	public const OSXAxis Other = 3;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum UnityAxis // TypeDefIndex: 2246
{
	// Fields
	public int value__; // 0x0
	public const UnityAxis None = 0;
	public const UnityAxis Axis0 = 1;
	public const UnityAxis Axis1 = 2;
	public const UnityAxis Axis2 = 3;
	public const UnityAxis Axis3 = 4;
	public const UnityAxis Axis4 = 5;
	public const UnityAxis Axis5 = 6;
	public const UnityAxis Axis6 = 7;
	public const UnityAxis Axis7 = 8;
	public const UnityAxis Axis8 = 9;
	public const UnityAxis Axis9 = 10;
	public const UnityAxis Axis10 = 11;
	public const UnityAxis Axis11 = 12;
	public const UnityAxis Axis12 = 13;
	public const UnityAxis Axis13 = 14;
	public const UnityAxis Axis14 = 15;
	public const UnityAxis Axis15 = 16;
	public const UnityAxis Axis16 = 17;
	public const UnityAxis Axis17 = 18;
	public const UnityAxis Axis18 = 19;
	public const UnityAxis Axis19 = 20;
	public const UnityAxis Axis20 = 21;
	public const UnityAxis Axis21 = 22;
	public const UnityAxis Axis22 = 23;
	public const UnityAxis Axis23 = 24;
	public const UnityAxis Axis24 = 25;
	public const UnityAxis Axis25 = 26;
	public const UnityAxis Axis26 = 27;
	public const UnityAxis Axis27 = 28;
	public const UnityAxis Axis28 = 29;
	public const UnityAxis Axis29 = 30;
}

// Namespace: Rewired.Platforms
[EditorBrowsable(1)]
public enum UnityButton // TypeDefIndex: 2247
{
	// Fields
	public int value__; // 0x0
	public const UnityButton None = 0;
	public const UnityButton Button0 = 1;
	public const UnityButton Button1 = 2;
	public const UnityButton Button2 = 3;
	public const UnityButton Button3 = 4;
	public const UnityButton Button4 = 5;
	public const UnityButton Button5 = 6;
	public const UnityButton Button6 = 7;
	public const UnityButton Button7 = 8;
	public const UnityButton Button8 = 9;
	public const UnityButton Button9 = 10;
	public const UnityButton Button10 = 11;
	public const UnityButton Button11 = 12;
	public const UnityButton Button12 = 13;
	public const UnityButton Button13 = 14;
	public const UnityButton Button14 = 15;
	public const UnityButton Button15 = 16;
	public const UnityButton Button16 = 17;
	public const UnityButton Button17 = 18;
	public const UnityButton Button18 = 19;
	public const UnityButton Button19 = 20;
}

// Namespace: Rewired.Platforms
[CustomObfuscation(rename = False)]
internal enum WebGLGamepadMappingType // TypeDefIndex: 2248
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const WebGLGamepadMappingType None = 0;
	[CustomObfuscation(rename = False)]
	public const WebGLGamepadMappingType Standard = 1;
}

// Namespace: Rewired.Platforms
[CustomObfuscation(rename = False)]
internal enum WebGLWebBrowserType // TypeDefIndex: 2249
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Unknown = -1;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType None = 0;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Chrome = 1;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Firefox = 2;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Opera = 3;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Safari = 4;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType InternetExplorer = 5;
	[CustomObfuscation(rename = False)]
	public const WebGLWebBrowserType Edge = 6;
}

// Namespace: Rewired.Platforms
[CustomObfuscation(rename = False)]
internal enum WebGLOSType // TypeDefIndex: 2250
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const WebGLOSType Unknown = -1;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType None = 0;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType Windows = 1;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType OSX = 2;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType Linux = 3;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType Android = 4;
	[CustomObfuscation(rename = False)]
	public const WebGLOSType iOS = 5;
}

