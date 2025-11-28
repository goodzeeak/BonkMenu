// Namespace: Rewired.Config
[Flags]
public enum UpdateLoopSetting // TypeDefIndex: 2690
{
	// Fields
	public int value__; // 0x0
	public const UpdateLoopSetting None = 0;
	public const UpdateLoopSetting Update = 1;
	public const UpdateLoopSetting FixedUpdate = 2;
	public const UpdateLoopSetting OnGUI = 4;
}

// Namespace: Rewired.Config
public enum UpdateMode // TypeDefIndex: 2691
{
	// Fields
	public int value__; // 0x0
	public const UpdateMode Automatic = 0;
	public const UpdateMode Manual = 1;
}

// Namespace: Rewired.Config
public enum ThrottleCalibrationMode // TypeDefIndex: 2692
{
	// Fields
	public int value__; // 0x0
	public const ThrottleCalibrationMode ZeroToOne = 0;
	public const ThrottleCalibrationMode NegativeOneToOne = 1;
}

// Namespace: Rewired.Config
public enum KeyCombinationOverrideMode // TypeDefIndex: 2693
{
	// Fields
	public int value__; // 0x0
	public const KeyCombinationOverrideMode None = 0;
	public const KeyCombinationOverrideMode Pause = 1;
	public const KeyCombinationOverrideMode Cancel = 2;
	public const KeyCombinationOverrideMode Overlap = 3;
}

// Namespace: Rewired.Config
public enum EnhancedDeviceSupportDeviceType // TypeDefIndex: 2694
{
	// Fields
	public int value__; // 0x0
	public const EnhancedDeviceSupportDeviceType SonyDualShock4 = 1;
	public const EnhancedDeviceSupportDeviceType SonyDualSense = 2;
	public const EnhancedDeviceSupportDeviceType NintendoSwitchProController = 100;
	public const EnhancedDeviceSupportDeviceType NintendoSwitchJoyConLeft = 101;
	public const EnhancedDeviceSupportDeviceType NintendoSwitchJoyConRight = 102;
	public const EnhancedDeviceSupportDeviceType PIEngineeringRailDriver = 1000;
}

// Namespace: Rewired.Config
[Flags]
public enum LogLevelFlags // TypeDefIndex: 2695
{
	// Fields
	public int value__; // 0x0
	public const LogLevelFlags Off = 0;
	public const LogLevelFlags Info = 1;
	public const LogLevelFlags Warning = 2;
	public const LogLevelFlags Error = 4;
	public const LogLevelFlags Debug = 8;
}

// Namespace: Rewired.Config
[CustomObfuscation(rename = False)]
internal enum LogLevel // TypeDefIndex: 2696
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const LogLevel Info = 0;
	[CustomObfuscation(rename = False)]
	public const LogLevel Warning = 1;
	[CustomObfuscation(rename = False)]
	public const LogLevel Error = 2;
	[CustomObfuscation(rename = False)]
	public const LogLevel Debug = 3;
}

