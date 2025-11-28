// Namespace: Rewired.Data
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class ConfigVars : IConfigVars_Internal // TypeDefIndex: 2309
{
	// Fields
	public UpdateMode updateMode; // 0x10
	public UpdateLoopSetting updateLoop; // 0x14
	public bool alwaysUseUnityInput; // 0x18
	public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource; // 0x1C
	public OSXStandalonePrimaryInputSource osx_primaryInputSource; // 0x20
	public LinuxStandalonePrimaryInputSource linux_primaryInputSource; // 0x24
	public WindowsUWPPrimaryInputSource windowsUWP_primaryInputSource; // 0x28
	public XboxOnePrimaryInputSource xboxOne_primaryInputSource; // 0x2C
	public GameCoreXboxOnePrimaryInputSource gameCoreXboxOne_primaryInputSource; // 0x30
	public GameCoreScarlettPrimaryInputSource gameCoreScarlett_primaryInputSource; // 0x34
	public PS4PrimaryInputSource ps4_primaryInputSource; // 0x38
	public PS5PrimaryInputSource ps5_primaryInputSource; // 0x3C
	public WebGLPrimaryInputSource webGL_primaryInputSource; // 0x40
	public bool useXInput; // 0x44
	public bool useNativeMouse; // 0x45
	public bool useEnhancedDeviceSupport; // 0x46
	public bool osxStandalone_useEnhancedDeviceSupport; // 0x47
	public bool android_supportUnknownGamepads; // 0x48
	public bool ps4_assignJoysticksByPS4JoyId; // 0x49
	public bool useSteamControllerSupport; // 0x4A
	public bool logToScreen; // 0x4B
	public bool runInEditMode; // 0x4C
	public bool allowInputInEditorSceneView; // 0x4D
	public bool unityUsePhysicalKeys; // 0x4E
	public KeyCombinationOverrideMode keyCombinationOverrideMode; // 0x50
	public bool generateKeyEventsOnKeyCombinationOverride; // 0x54
	public ConfigVars.PlatformVars_WindowsStandalone platformVars_windowsStandalone; // 0x58
	public ConfigVars.PlatformVars_LinuxStandalone platformVars_linuxStandalone; // 0x60
	public ConfigVars.PlatformVars_OSXStandalone platformVars_osxStandalone; // 0x68
	public ConfigVars.PlatformVars_WindowsUWP platformVars_windowsUWP; // 0x70
	public ConfigVars.PlatformVars platformVars_iOS; // 0x78
	public ConfigVars.PlatformVars platformVars_tvOS; // 0x80
	public ConfigVars.PlatformVars platformVars_android; // 0x88
	public ConfigVars.PlatformVars platformVars_ps4; // 0x90
	public ConfigVars.PlatformVars_PS5 platformVars_ps5; // 0x98
	public ConfigVars.PlatformVars platformVars_psVita; // 0xA0
	public ConfigVars.PlatformVars platformVars_xboxOne; // 0xA8
	public ConfigVars.PlatformVars_GameCoreXboxOne platformVars_gameCoreXboxOne; // 0xB0
	public ConfigVars.PlatformVars_GameCoreScarlett platformVars_gameCoreScarlett; // 0xB8
	public ConfigVars.PlatformVars platformVars_switch; // 0xC0
	public ConfigVars.PlatformVars platformVars_switch2; // 0xC8
	public ConfigVars.PlatformVars platformVars_webGL; // 0xD0
	private ConfigVars.PlatformVars platformVars_unknown; // 0xD8
	public int maxJoysticksPerPlayer; // 0xE0
	public bool autoAssignJoysticks; // 0xE4
	public bool assignJoysticksToPlayingPlayersOnly; // 0xE5
	public bool distributeJoysticksEvenly; // 0xE6
	public bool reassignJoystickToPreviousOwnerOnReconnect; // 0xE7
	public DeadZone2DType defaultJoystickAxis2DDeadZoneType; // 0xE8
	public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType; // 0xEC
	public AxisSensitivityType defaultAxisSensitivityType; // 0xF0
	public bool force4WayHats; // 0xF4
	public ThrottleCalibrationMode throttleCalibrationMode; // 0xF8
	public bool activateActionButtonsOnNegativeValue; // 0xFC
	public bool deferControllerConnectedEventsOnStart; // 0xFD
	public LogLevelFlags logLevel; // 0x100
	public ConfigVars.EditorVars editorSettings; // 0x108
	private Dictionary<int, ConfigVars.qlCOOkJbwQXASCPFTdWeqzFejdTU> __platformVarsDict; // 0x110
	private Dictionary<int, ConfigVars.xeLlgGAnAuFgYCkjXUIHuyHvFsaab> __getSetPlatformVariableDict; // 0x118
	private KeyedGetSetValueStore<string> __configVarsValues; // 0x120
	private Dictionary<string, object> __valueDelegates; // 0x128

	// Properties
	private Dictionary<int, ConfigVars.qlCOOkJbwQXASCPFTdWeqzFejdTU> platformVarsDict { get; }
	private Dictionary<int, ConfigVars.xeLlgGAnAuFgYCkjXUIHuyHvFsaab> getSetPlatformVariableDict { get; }
	private KeyedGetSetValueStore<string> Rewired.Data.IConfigVars_Internal.values { get; }
	private Dictionary<string, object> valueDelegates { get; }

	// Methods

	// RVA: 0x16EEF00 Offset: 0x16ED500 VA: 0x1816EEF00
	private Dictionary<int, ConfigVars.qlCOOkJbwQXASCPFTdWeqzFejdTU> get_platformVarsDict() { }

	// RVA: 0x16EEC00 Offset: 0x16ED200 VA: 0x1816EEC00
	private Dictionary<int, ConfigVars.xeLlgGAnAuFgYCkjXUIHuyHvFsaab> get_getSetPlatformVariableDict() { }

	[Preserve]
	// RVA: 0x16EEBA0 Offset: 0x16ED1A0 VA: 0x1816EEBA0
	public void .ctor() { }

	// RVA: 0x16EB380 Offset: 0x16E9980 VA: 0x1816EB380
	internal bool DoesPlatformUseFallback(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor) { }

	// RVA: 0x16EB900 Offset: 0x16E9F00 VA: 0x1816EB900
	internal string GetDebugConfigSettings() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x16ECA40 Offset: 0x16EB040 VA: 0x1816ECA40
	internal string GetPlatformVarsRelPath(Platform platform) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x16ECB10 Offset: 0x16EB110 VA: 0x1816ECB10
	internal ConfigVars.PlatformVars GetPlatformVars(Platform platform) { }

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	internal T Editor_GetAllSerializedPlatformVar<T>(ConfigVars.AllPlatformVar var) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BB7B0 Offset: 0x6B9DB0 VA: 0x1806BB7B0
	|-ConfigVars.Editor_GetAllSerializedPlatformVar<__Il2CppFullySharedGenericType>
	*/

	[CustomObfuscation(rename = False)]
	// RVA: 0x16EB400 Offset: 0x16E9A00 VA: 0x1816EB400
	internal void Editor_SetAllSerializedPlatformVar(ConfigVars.AllPlatformVar var, object value) { }

	// RVA: 0x16EC060 Offset: 0x16EA660 VA: 0x1816EC060
	internal bool GetPlatformVar_disableKeyboard() { }

	// RVA: 0x16ED1F0 Offset: 0x16EB7F0 VA: 0x1816ED1F0
	internal bool SetPlatformVar_disableKeyboard(bool value) { }

	// RVA: 0x16EC080 Offset: 0x16EA680 VA: 0x1816EC080
	internal bool GetPlatformVar_disableMouse() { }

	// RVA: 0x16ED220 Offset: 0x16EB820 VA: 0x1816ED220
	internal bool SetPlatformVar_disableMouse(bool value) { }

	// RVA: 0x16EC300 Offset: 0x16EA900 VA: 0x1816EC300
	internal bool GetPlatformVar_ignoreInputWhenAppNotInFocus() { }

	// RVA: 0x16EC520 Offset: 0x16EAB20 VA: 0x1816EC520
	internal bool GetPlatformVar_useEnhancedDeviceSupport() { }

	// RVA: 0x16EC810 Offset: 0x16EAE10 VA: 0x1816EC810
	internal bool GetPlatformVar_useNativeMouse() { }

	// RVA: 0x16EC650 Offset: 0x16EAC50 VA: 0x1816EC650
	internal bool GetPlatformVar_useNativeKeyboard() { }

	// RVA: 0x16EC320 Offset: 0x16EA920 VA: 0x1816EC320
	internal int GetPlatformVar_joystickRefreshRate() { }

	// RVA: 0x16EBD80 Offset: 0x16EA380 VA: 0x1816EBD80
	internal bool GetPlatformVar_assignJoysticksBySystemId() { }

	// RVA: 0x16EC420 Offset: 0x16EAA20 VA: 0x1816EC420
	internal bool GetPlatformVar_useAppleGameController() { }

	// RVA: 0x16EC940 Offset: 0x16EAF40 VA: 0x1816EC940
	internal bool GetPlatformVar_useWindowsGamingInput() { }

	// RVA: 0x16EC0A0 Offset: 0x16EA6A0 VA: 0x1816EC0A0
	internal IList<EnhancedDeviceSupportDeviceType> GetPlatformVar_enhancedDeviceSupportExcludedDeviceTypes() { }

	// RVA: 0x16ED570 Offset: 0x16EBB70 VA: 0x1816ED570
	internal bool SetPlatformVar_ignoreInputWhenAppNotInFocus(bool value) { }

	// RVA: 0x16ED810 Offset: 0x16EBE10 VA: 0x1816ED810
	internal bool SetPlatformVar_useEnhancedDeviceSupport(bool value) { }

	// RVA: 0x16EDAD0 Offset: 0x16EC0D0 VA: 0x1816EDAD0
	internal bool SetPlatformVar_useNativeMouse(bool value) { }

	// RVA: 0x16ED980 Offset: 0x16EBF80 VA: 0x1816ED980
	internal bool SetPlatformVar_useNativeKeyboard(bool value) { }

	// RVA: 0x16ED5D0 Offset: 0x16EBBD0 VA: 0x1816ED5D0
	internal bool SetPlatformVar_joystickRefreshRate(int value) { }

	// RVA: 0x16ECEE0 Offset: 0x16EB4E0 VA: 0x1816ECEE0
	internal bool SetPlatformVar_assignJoysticksBySystemId(bool value) { }

	// RVA: 0x16ED6F0 Offset: 0x16EBCF0 VA: 0x1816ED6F0
	internal bool SetPlatformVar_useAppleGameController(bool value) { }

	// RVA: 0x16EDB80 Offset: 0x16EC180 VA: 0x1816EDB80
	internal bool SetPlatformVar_useWindowsGamingInput(bool value) { }

	// RVA: 0x16ED250 Offset: 0x16EB850 VA: 0x1816ED250
	internal bool SetPlatformVar_enhancedDeviceSupportExcludedDeviceTypes(IList<EnhancedDeviceSupportDeviceType> value) { }

	// RVA: 0x16ECCA0 Offset: 0x16EB2A0 VA: 0x1816ECCA0
	private ConfigVars.PlatformVars GetPlatformVars() { }

	// RVA: -1 Offset: -1
	private T GetOrCreatePlatformVars<T>(ref T var) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BB920 Offset: 0x6B9F20 VA: 0x1806BB920
	|-ConfigVars.GetOrCreatePlatformVars<object>
	*/

	// RVA: 0x16EB5E0 Offset: 0x16E9BE0 VA: 0x1816EB5E0
	private MultiBoolValue GetAllSerializedPlatformVar_multiBool(ConfigVars.AllPlatformVar var) { }

	// RVA: 0x16ECD30 Offset: 0x16EB330 VA: 0x1816ECD30
	internal bool IsEditModeInputSupported(ControllerType controllerType, EditorPlatform editorPlatform) { }

	// RVA: 0x16ECE10 Offset: 0x16EB410 VA: 0x1816ECE10
	private static bool IsNativeKeyboardAllowed(Platform platform, bool unityUsePhysicalKeys) { }

	// RVA: 0x16ECE30 Offset: 0x16EB430 VA: 0x1816ECE30 Slot: 4
	private KeyedGetSetValueStore<string> Rewired.Data.IConfigVars_Internal.get_values() { }

	// RVA: 0x16EF9A0 Offset: 0x16EDFA0 VA: 0x1816EF9A0
	private Dictionary<string, object> get_valueDelegates() { }

	[CompilerGenerated]
	// RVA: 0x16EDE80 Offset: 0x16EC480 VA: 0x1816EDE80
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_0() { }

	[CompilerGenerated]
	// RVA: 0x16EE080 Offset: 0x16EC680 VA: 0x1816EE080
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_1() { }

	[CompilerGenerated]
	// RVA: 0x16EE0C0 Offset: 0x16EC6C0 VA: 0x1816EE0C0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_2() { }

	[CompilerGenerated]
	// RVA: 0x16EE100 Offset: 0x16EC700 VA: 0x1816EE100
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_3() { }

	[CompilerGenerated]
	// RVA: 0x16EE140 Offset: 0x16EC740 VA: 0x1816EE140
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_4() { }

	[CompilerGenerated]
	// RVA: 0x16EE180 Offset: 0x16EC780 VA: 0x1816EE180
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_5() { }

	[CompilerGenerated]
	// RVA: 0x16EE1C0 Offset: 0x16EC7C0 VA: 0x1816EE1C0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_6() { }

	[CompilerGenerated]
	// RVA: 0x16EE200 Offset: 0x16EC800 VA: 0x1816EE200
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_7() { }

	[CompilerGenerated]
	// RVA: 0x16EE240 Offset: 0x16EC840 VA: 0x1816EE240
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_8() { }

	[CompilerGenerated]
	// RVA: 0x16EE280 Offset: 0x16EC880 VA: 0x1816EE280
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_9() { }

	[CompilerGenerated]
	// RVA: 0x16EDEC0 Offset: 0x16EC4C0 VA: 0x1816EDEC0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_10() { }

	[CompilerGenerated]
	// RVA: 0x16EDF00 Offset: 0x16EC500 VA: 0x1816EDF00
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_11() { }

	[CompilerGenerated]
	// RVA: 0x16EDF40 Offset: 0x16EC540 VA: 0x1816EDF40
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_12() { }

	[CompilerGenerated]
	// RVA: 0x16EDF80 Offset: 0x16EC580 VA: 0x1816EDF80
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_13() { }

	[CompilerGenerated]
	// RVA: 0x16EDFC0 Offset: 0x16EC5C0 VA: 0x1816EDFC0
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_14() { }

	[CompilerGenerated]
	// RVA: 0x16EE000 Offset: 0x16EC600 VA: 0x1816EE000
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_15() { }

	[CompilerGenerated]
	// RVA: 0x16EE040 Offset: 0x16EC640 VA: 0x1816EE040
	private ConfigVars.PlatformVars <get_platformVarsDict>b__59_16() { }

	[CompilerGenerated]
	// RVA: 0x16EDCA0 Offset: 0x16EC2A0 VA: 0x1816EDCA0
	private object <get_getSetPlatformVariableDict>b__62_0(Platform p) { }

	[CompilerGenerated]
	// RVA: 0x16EDCE0 Offset: 0x16EC2E0 VA: 0x1816EDCE0
	private void <get_getSetPlatformVariableDict>b__62_1(Platform platform, object value) { }

	[CompilerGenerated]
	// RVA: 0x16EDD40 Offset: 0x16EC340 VA: 0x1816EDD40
	private object <get_getSetPlatformVariableDict>b__62_2(Platform p) { }

	[CompilerGenerated]
	// RVA: 0x16EDD80 Offset: 0x16EC380 VA: 0x1816EDD80
	private void <get_getSetPlatformVariableDict>b__62_3(Platform platform, object value) { }

	[CompilerGenerated]
	// RVA: 0x16EDDE0 Offset: 0x16EC3E0 VA: 0x1816EDDE0
	private object <get_getSetPlatformVariableDict>b__62_4(Platform platform) { }

	[CompilerGenerated]
	// RVA: 0x16EDE20 Offset: 0x16EC420 VA: 0x1816EDE20
	private void <get_getSetPlatformVariableDict>b__62_5(Platform platform, object value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	private UpdateLoopSetting <get_valueDelegates>b__102_0() { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	private void <get_valueDelegates>b__102_1(UpdateLoopSetting x) { }

	[CompilerGenerated]
	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	private bool <get_valueDelegates>b__102_2() { }

	[CompilerGenerated]
	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	private void <get_valueDelegates>b__102_3(bool x) { }

	[CompilerGenerated]
	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	private WindowsStandalonePrimaryInputSource <get_valueDelegates>b__102_4() { }

	[CompilerGenerated]
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	private void <get_valueDelegates>b__102_5(WindowsStandalonePrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	private OSXStandalonePrimaryInputSource <get_valueDelegates>b__102_6() { }

	[CompilerGenerated]
	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	private void <get_valueDelegates>b__102_7(OSXStandalonePrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	private LinuxStandalonePrimaryInputSource <get_valueDelegates>b__102_8() { }

	[CompilerGenerated]
	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	private void <get_valueDelegates>b__102_9(LinuxStandalonePrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	private WindowsUWPPrimaryInputSource <get_valueDelegates>b__102_10() { }

	[CompilerGenerated]
	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	private void <get_valueDelegates>b__102_11(WindowsUWPPrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	private XboxOnePrimaryInputSource <get_valueDelegates>b__102_12() { }

	[CompilerGenerated]
	// RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	private void <get_valueDelegates>b__102_13(XboxOnePrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	private GameCoreXboxOnePrimaryInputSource <get_valueDelegates>b__102_14() { }

	[CompilerGenerated]
	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	private void <get_valueDelegates>b__102_15(GameCoreXboxOnePrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	private GameCoreScarlettPrimaryInputSource <get_valueDelegates>b__102_16() { }

	[CompilerGenerated]
	// RVA: 0x10051F0 Offset: 0x10037F0 VA: 0x1810051F0
	private void <get_valueDelegates>b__102_17(GameCoreScarlettPrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	private PS4PrimaryInputSource <get_valueDelegates>b__102_18() { }

	[CompilerGenerated]
	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	private void <get_valueDelegates>b__102_19(PS4PrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	private PS5PrimaryInputSource <get_valueDelegates>b__102_20() { }

	[CompilerGenerated]
	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	private void <get_valueDelegates>b__102_21(PS5PrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	private WebGLPrimaryInputSource <get_valueDelegates>b__102_22() { }

	[CompilerGenerated]
	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	private void <get_valueDelegates>b__102_23(WebGLPrimaryInputSource x) { }

	[CompilerGenerated]
	// RVA: 0x43C000 Offset: 0x43A600 VA: 0x18043C000
	private bool <get_valueDelegates>b__102_24() { }

	[CompilerGenerated]
	// RVA: 0x16EE2D0 Offset: 0x16EC8D0 VA: 0x1816EE2D0
	private void <get_valueDelegates>b__102_25(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE2E0 Offset: 0x16EC8E0 VA: 0x1816EE2E0
	private bool <get_valueDelegates>b__102_26() { }

	[CompilerGenerated]
	// RVA: 0x16EE2F0 Offset: 0x16EC8F0 VA: 0x1816EE2F0
	private void <get_valueDelegates>b__102_27(bool x) { }

	[CompilerGenerated]
	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	private bool <get_valueDelegates>b__102_28() { }

	[CompilerGenerated]
	// RVA: 0x132E3F0 Offset: 0x132C9F0 VA: 0x18132E3F0
	private void <get_valueDelegates>b__102_29(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE300 Offset: 0x16EC900 VA: 0x1816EE300
	private bool <get_valueDelegates>b__102_30() { }

	[CompilerGenerated]
	// RVA: 0x16EE310 Offset: 0x16EC910 VA: 0x1816EE310
	private void <get_valueDelegates>b__102_31(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE320 Offset: 0x16EC920 VA: 0x1816EE320
	private bool <get_valueDelegates>b__102_32() { }

	[CompilerGenerated]
	// RVA: 0x16EE330 Offset: 0x16EC930 VA: 0x1816EE330
	private void <get_valueDelegates>b__102_33(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE340 Offset: 0x16EC940 VA: 0x1816EE340
	private bool <get_valueDelegates>b__102_34() { }

	[CompilerGenerated]
	// RVA: 0x16EE350 Offset: 0x16EC950 VA: 0x1816EE350
	private void <get_valueDelegates>b__102_35(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE360 Offset: 0x16EC960 VA: 0x1816EE360
	private bool <get_valueDelegates>b__102_36() { }

	[CompilerGenerated]
	// RVA: 0x16EE370 Offset: 0x16EC970 VA: 0x1816EE370
	private void <get_valueDelegates>b__102_37(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE380 Offset: 0x16EC980 VA: 0x1816EE380
	private bool <get_valueDelegates>b__102_38() { }

	[CompilerGenerated]
	// RVA: 0x16EE390 Offset: 0x16EC990 VA: 0x1816EE390
	private void <get_valueDelegates>b__102_39(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE3A0 Offset: 0x16EC9A0 VA: 0x1816EE3A0
	private int <get_valueDelegates>b__102_40() { }

	[CompilerGenerated]
	// RVA: 0x16EE3B0 Offset: 0x16EC9B0 VA: 0x1816EE3B0
	private void <get_valueDelegates>b__102_41(int x) { }

	[CompilerGenerated]
	// RVA: 0x16EE3C0 Offset: 0x16EC9C0 VA: 0x1816EE3C0
	private bool <get_valueDelegates>b__102_42() { }

	[CompilerGenerated]
	// RVA: 0x16EE3D0 Offset: 0x16EC9D0 VA: 0x1816EE3D0
	private void <get_valueDelegates>b__102_43(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE3E0 Offset: 0x16EC9E0 VA: 0x1816EE3E0
	private bool <get_valueDelegates>b__102_44() { }

	[CompilerGenerated]
	// RVA: 0x16EE3F0 Offset: 0x16EC9F0 VA: 0x1816EE3F0
	private void <get_valueDelegates>b__102_45(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE400 Offset: 0x16ECA00 VA: 0x1816EE400
	private bool <get_valueDelegates>b__102_46() { }

	[CompilerGenerated]
	// RVA: 0x16EE410 Offset: 0x16ECA10 VA: 0x1816EE410
	private void <get_valueDelegates>b__102_47(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE420 Offset: 0x16ECA20 VA: 0x1816EE420
	private bool <get_valueDelegates>b__102_48() { }

	[CompilerGenerated]
	// RVA: 0x16EE430 Offset: 0x16ECA30 VA: 0x1816EE430
	private void <get_valueDelegates>b__102_49(bool x) { }

	[CompilerGenerated]
	// RVA: 0x12ECB10 Offset: 0x12EB110 VA: 0x1812ECB10
	private DeadZone2DType <get_valueDelegates>b__102_50() { }

	[CompilerGenerated]
	// RVA: 0x12ECF10 Offset: 0x12EB510 VA: 0x1812ECF10
	private void <get_valueDelegates>b__102_51(DeadZone2DType x) { }

	[CompilerGenerated]
	// RVA: 0x359760 Offset: 0x357D60 VA: 0x180359760
	private AxisSensitivity2DType <get_valueDelegates>b__102_52() { }

	[CompilerGenerated]
	// RVA: 0x3597C0 Offset: 0x357DC0 VA: 0x1803597C0
	private void <get_valueDelegates>b__102_53(AxisSensitivity2DType x) { }

	[CompilerGenerated]
	// RVA: 0x16EE440 Offset: 0x16ECA40 VA: 0x1816EE440
	private AxisSensitivityType <get_valueDelegates>b__102_54() { }

	[CompilerGenerated]
	// RVA: 0x16EE450 Offset: 0x16ECA50 VA: 0x1816EE450
	private void <get_valueDelegates>b__102_55(AxisSensitivityType x) { }

	[CompilerGenerated]
	// RVA: 0x16EE460 Offset: 0x16ECA60 VA: 0x1816EE460
	private bool <get_valueDelegates>b__102_56() { }

	[CompilerGenerated]
	// RVA: 0x16EE470 Offset: 0x16ECA70 VA: 0x1816EE470
	private void <get_valueDelegates>b__102_57(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE480 Offset: 0x16ECA80 VA: 0x1816EE480
	private ThrottleCalibrationMode <get_valueDelegates>b__102_58() { }

	[CompilerGenerated]
	// RVA: 0x12EC7C0 Offset: 0x12EADC0 VA: 0x1812EC7C0
	private void <get_valueDelegates>b__102_59(ThrottleCalibrationMode x) { }

	[CompilerGenerated]
	// RVA: 0x16EE490 Offset: 0x16ECA90 VA: 0x1816EE490
	private bool <get_valueDelegates>b__102_60() { }

	[CompilerGenerated]
	// RVA: 0x16EE4A0 Offset: 0x16ECAA0 VA: 0x1816EE4A0
	private void <get_valueDelegates>b__102_61(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE4B0 Offset: 0x16ECAB0 VA: 0x1816EE4B0
	private bool <get_valueDelegates>b__102_62() { }

	[CompilerGenerated]
	// RVA: 0x16EE4C0 Offset: 0x16ECAC0 VA: 0x1816EE4C0
	private void <get_valueDelegates>b__102_63(bool x) { }

	[CompilerGenerated]
	// RVA: 0x561290 Offset: 0x55F890 VA: 0x180561290
	private LogLevelFlags <get_valueDelegates>b__102_64() { }

	[CompilerGenerated]
	// RVA: 0x5615D0 Offset: 0x55FBD0 VA: 0x1805615D0
	private void <get_valueDelegates>b__102_65(LogLevelFlags x) { }

	[CompilerGenerated]
	// RVA: 0x16EC060 Offset: 0x16EA660 VA: 0x1816EC060
	private bool <get_valueDelegates>b__102_66() { }

	[CompilerGenerated]
	// RVA: 0x16EE4D0 Offset: 0x16ECAD0 VA: 0x1816EE4D0
	private void <get_valueDelegates>b__102_67(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EC080 Offset: 0x16EA680 VA: 0x1816EC080
	private bool <get_valueDelegates>b__102_68() { }

	[CompilerGenerated]
	// RVA: 0x16EE500 Offset: 0x16ECB00 VA: 0x1816EE500
	private void <get_valueDelegates>b__102_69(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EC300 Offset: 0x16EA900 VA: 0x1816EC300
	private bool <get_valueDelegates>b__102_70() { }

	[CompilerGenerated]
	// RVA: 0x16EE530 Offset: 0x16ECB30 VA: 0x1816EE530
	private void <get_valueDelegates>b__102_71(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE580 Offset: 0x16ECB80 VA: 0x1816EE580
	private bool <get_valueDelegates>b__102_72() { }

	[CompilerGenerated]
	// RVA: 0x16EE590 Offset: 0x16ECB90 VA: 0x1816EE590
	private void <get_valueDelegates>b__102_73(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE6D0 Offset: 0x16ECCD0 VA: 0x1816EE6D0
	private bool <get_valueDelegates>b__102_74() { }

	[CompilerGenerated]
	// RVA: 0x16EE6E0 Offset: 0x16ECCE0 VA: 0x1816EE6E0
	private void <get_valueDelegates>b__102_75(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EE780 Offset: 0x16ECD80 VA: 0x1816EE780
	private bool <get_valueDelegates>b__102_76() { }

	[CompilerGenerated]
	// RVA: 0x16EE940 Offset: 0x16ECF40 VA: 0x1816EE940
	private void <get_valueDelegates>b__102_77(bool x) { }

	[CompilerGenerated]
	// RVA: 0x16EC320 Offset: 0x16EA920 VA: 0x1816EC320
	private int <get_valueDelegates>b__102_78() { }

	[CompilerGenerated]
	// RVA: 0x16EEA80 Offset: 0x16ED080 VA: 0x1816EEA80
	private void <get_valueDelegates>b__102_79(int x) { }

	[CompilerGenerated]
	// RVA: 0x16EEB80 Offset: 0x16ED180 VA: 0x1816EEB80
	private bool <get_valueDelegates>b__102_80() { }

	[CompilerGenerated]
	// RVA: 0x16EEB90 Offset: 0x16ED190 VA: 0x1816EEB90
	private void <get_valueDelegates>b__102_81(bool x) { }
}

// Namespace: Rewired.Data
public sealed class ControllerDataFiles : ScriptableObject // TypeDefIndex: 2310
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap defaultHardwareJoystickMap; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap[] hardwareJoystickMaps; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickTemplateMap[] joystickTemplates; // 0x28
	private bool LYKiWLiYkJetShlXJaClaVepgaWib; // 0x30
	private readonly ADictionary<Guid, SUKBHhZFjtXCZDAZGqMkzjNQboJY> xOPrJCJWFfmQvtLOdugFpEtoCssZ; // 0x38

	// Properties
	public Guid defaultHardwareJoystickMapGuid { get; }
	public HardwareJoystickTemplateMap[] JoystickTemplates { get; set; }
	public HardwareJoystickMap[] HardwareJoystickMaps { get; set; }
	public HardwareJoystickMap DefaultHardwareJoystickMap { get; set; }

	// Methods

	// RVA: 0x16F2C80 Offset: 0x16F1280 VA: 0x1816F2C80
	public Guid get_defaultHardwareJoystickMapGuid() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public HardwareJoystickTemplateMap[] get_JoystickTemplates() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_JoystickTemplates(HardwareJoystickTemplateMap[] value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public HardwareJoystickMap[] get_HardwareJoystickMaps() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_HardwareJoystickMaps(HardwareJoystickMap[] value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public HardwareJoystickMap get_DefaultHardwareJoystickMap() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_DefaultHardwareJoystickMap(HardwareJoystickMap value) { }

	// RVA: 0x16F2670 Offset: 0x16F0C70 VA: 0x1816F2670
	public void .ctor() { }

	// RVA: 0x16F1FA0 Offset: 0x16F05A0 VA: 0x1816F1FA0
	public string[] GetJoystickNames() { }

	// RVA: 0x16F1900 Offset: 0x16EFF00 VA: 0x1816F1900
	public string[] GetEditorJoystickNames() { }

	// RVA: 0x16F1D70 Offset: 0x16F0370 VA: 0x1816F1D70
	public Guid[] GetJoystickGuids() { }

	// RVA: 0x16F2350 Offset: 0x16F0950 VA: 0x1816F2350
	public string[] GetJoystickTemplateNames() { }

	// RVA: 0x16F2160 Offset: 0x16F0760 VA: 0x1816F2160
	public Guid[] GetJoystickTemplateGuids() { }

	// RVA: 0x16F1B30 Offset: 0x16F0130 VA: 0x1816F1B30
	public HardwareJoystickMap GetHardwareJoystickMap(Guid guid) { }

	// RVA: 0x16F24C0 Offset: 0x16F0AC0 VA: 0x1816F24C0
	public HardwareJoystickTemplateMap GetJoystickTemplate(Guid guid) { }

	// RVA: 0x16F18E0 Offset: 0x16EFEE0 VA: 0x1816F18E0
	public IHardwareControllerTemplateMap GetControllerTemplate(Guid guid) { }

	// RVA: 0x16F1CC0 Offset: 0x16F02C0 VA: 0x1816F1CC0
	public IHardwareControllerMap GetHardwareJoystickOrTemplateMap(Guid guid) { }

	// RVA: 0x16F2840 Offset: 0x16F0E40 VA: 0x1816F2840
	internal ControllerTemplateElementIdentifier dJKvSPDuhLBFCmLLZBGjehQOvBzb(Guid , int , out HardwareJoystickMap ) { }

	// RVA: 0x16F31C0 Offset: 0x16F17C0 VA: 0x1816F31C0
	internal int nlYMXWCcKKMUAiSuCfrvceopeOMcA(Guid , Guid , int , List<HardwareControllerTemplateMap.jKiaMLFrsZtqsedKIgXIoKaJmIXiA> ) { }

	// RVA: 0x16F2D30 Offset: 0x16F1330 VA: 0x1816F2D30
	internal HardwareJoystickMap_InputManager hfqiIxaDibtsmuzEOjbxOoBePEMGb(Guid , InputSource ) { }

	// RVA: 0x16F3330 Offset: 0x16F1930 VA: 0x1816F3330
	internal HardwareJoystickMap_InputManager ztIqFJjeQZgtwLOOkXkXKastfVSHA(BridgedControllerHWInfo ) { }

	// RVA: 0x16F2B50 Offset: 0x16F1150 VA: 0x1816F2B50
	private HardwareJoystickMap_InputManager efEMGTIzGHgMiEvdeXJFALsnivt(HardwareJoystickMap , BridgedControllerHWInfo , bool , out InputPlatform , out int , out HardwareJoystickMap.Platform ) { }

	// RVA: 0x16F2F10 Offset: 0x16F1510 VA: 0x1816F2F10
	private HardwareJoystickMap_InputManager lBrdJsBiHOwzWESYSTbTDZyhhFkEA(BridgedControllerHWInfo , string ) { }

	// RVA: 0x16F2610 Offset: 0x16F0C10 VA: 0x1816F2610
	private HardwareJoystickMap_InputManager MBfKSrzxMfnOAkamDtNsSpVSfMZe(BridgedControllerHWInfo ) { }

	// RVA: 0x16F2710 Offset: 0x16F0D10 VA: 0x1816F2710
	internal SUKBHhZFjtXCZDAZGqMkzjNQboJY bkUYosKGHndJEAtXJFIXNsqtffDmA(Guid ) { }

	// RVA: 0x16F3100 Offset: 0x16F1700 VA: 0x1816F3100
	internal IHardwareControllerTemplateMap mWsdWCerHGChHLvQSRYKcESzGaylA(Guid ) { }

	// RVA: 0x16F3120 Offset: 0x16F1720 VA: 0x1816F3120
	private void mvtyzKOwwcftwlCiIOeFNjNOIWMV() { }
}

// Namespace: Rewired.Data
[Browsable(False)]
[EditorBrowsable(1)]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[Serializable]
public sealed class CustomController_Editor // TypeDefIndex: 2315
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _name; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _descriptiveName; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _id; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _typeGuidString; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _key; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerElementIdentifier> _elementIdentifiers; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<CustomController_Editor.Axis> _axes; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<CustomController_Editor.Button> _buttons; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _elementIdentifierIdCounter; // 0x50

	// Properties
	public string name { get; set; }
	public string descriptiveName { get; set; }
	public int id { get; set; }
	public Guid typeGuid { get; set; }
	internal string typeGuidString { get; set; }
	public string key { get; set; }
	public List<ControllerElementIdentifier> elementIdentifiers { get; set; }
	public List<CustomController_Editor.Axis> axes { get; }
	public List<CustomController_Editor.Button> buttons { get; }
	public int buttonCount { get; }
	public int axisCount { get; }
	public IEnumerable<ControllerElementIdentifier> ElementIdentifiers { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_name() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	internal void set_name(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_descriptiveName() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_descriptiveName(string value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_id() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	internal void set_id(int value) { }

	// RVA: 0x1709AB0 Offset: 0x17080B0 VA: 0x181709AB0
	public Guid get_typeGuid() { }

	// RVA: 0x1709E30 Offset: 0x1708430 VA: 0x181709E30
	internal void set_typeGuid(Guid value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal string get_typeGuidString() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void set_typeGuidString(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_key() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_key(string value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public List<ControllerElementIdentifier> get_elementIdentifiers() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	internal void set_elementIdentifiers(List<ControllerElementIdentifier> value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public List<CustomController_Editor.Axis> get_axes() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public List<CustomController_Editor.Button> get_buttons() { }

	// RVA: 0x1709A60 Offset: 0x1708060 VA: 0x181709A60
	public int get_buttonCount() { }

	// RVA: 0x1709A10 Offset: 0x1708010 VA: 0x181709A10
	public int get_axisCount() { }

	[IteratorStateMachine(typeof(CustomController_Editor.toElyePGjyrApiHOKRXXzTPriKCh))]
	// RVA: 0x1709990 Offset: 0x1707F90 VA: 0x181709990
	public IEnumerable<ControllerElementIdentifier> get_ElementIdentifiers() { }

	// RVA: 0x17096E0 Offset: 0x1707CE0 VA: 0x1817096E0
	public void .ctor() { }

	// RVA: 0x17091F0 Offset: 0x17077F0 VA: 0x1817091F0
	public void .ctor(CustomController_Editor ) { }

	// RVA: 0x1706E40 Offset: 0x1705440 VA: 0x181706E40
	public CustomController_Editor Clone() { }

	// RVA: 0x1708810 Offset: 0x1706E10 VA: 0x181708810
	public string[] GetElementIdentifierNames() { }

	// RVA: 0x17084C0 Offset: 0x1706AC0 VA: 0x1817084C0
	public int[] GetElementIdentifierIds() { }

	// RVA: 0x17085A0 Offset: 0x1706BA0 VA: 0x1817085A0
	public string[] GetElementIdentifierNamesTypeSorted() { }

	// RVA: 0x1708230 Offset: 0x1706830 VA: 0x181708230
	public int[] GetElementIdentifierIdsTypeSorted() { }

	// RVA: 0x1708970 Offset: 0x1706F70 VA: 0x181708970
	public ControllerElementIdentifier[] GetElementIdentifiersTypeSorted() { }

	// RVA: 0x1706EA0 Offset: 0x17054A0 VA: 0x181706EA0
	public bool ContainsElementIdentifier(int id) { }

	// RVA: 0x1708C30 Offset: 0x1707230 VA: 0x181708C30
	public int IndexOfElementIdentifier(int id) { }

	// RVA: 0x1708900 Offset: 0x1706F00 VA: 0x181708900
	public ControllerElementIdentifier GetElementIdentifier(int id) { }

	// RVA: 0x1707EE0 Offset: 0x17064E0 VA: 0x181707EE0
	internal ControllerElementType GetEffectiveElementIdentifierType(int elementIdentifierId) { }

	// RVA: 0x1707DA0 Offset: 0x17063A0 VA: 0x181707DA0
	internal bool GetEffectiveAxisRange(int elementIdentifierId, out AxisRange axisRange) { }

	// RVA: 0x1707CB0 Offset: 0x17062B0 VA: 0x181707CB0
	public string[] GetButtonNames() { }

	// RVA: 0x1707BD0 Offset: 0x17061D0 VA: 0x181707BD0
	public int[] GetButtonElementIdentifierIds() { }

	// RVA: 0x1707AE0 Offset: 0x17060E0 VA: 0x181707AE0
	public string[] GetAxisNames() { }

	// RVA: 0x1707A00 Offset: 0x1706000 VA: 0x181707A00
	public int[] GetAxisElementIdentifierIds() { }

	// RVA: -1 Offset: -1
	public string[] GetElementNames<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C22F0 Offset: 0x6C08F0 VA: 0x1806C22F0
	|-CustomController_Editor.GetElementNames<object>
	*/

	// RVA: 0x1708BC0 Offset: 0x17071C0 VA: 0x181708BC0
	public string[] GetElementNames(ControllerElementType type) { }

	// RVA: 0x1708040 Offset: 0x1706640 VA: 0x181708040
	public int[] GetElementElementIdentifierIds(ControllerElementType type) { }

	// RVA: -1 Offset: -1
	public T GetElement<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C1BC0 Offset: 0x6C01C0 VA: 0x1806C1BC0
	|-CustomController_Editor.GetElement<object>
	*/

	// RVA: 0x1706CA0 Offset: 0x17052A0 VA: 0x181706CA0
	public void AddElement(ControllerElementType type) { }

	// RVA: 0x1706AC0 Offset: 0x17050C0 VA: 0x181706AC0
	public void AddAxis() { }

	// RVA: 0x1706BB0 Offset: 0x17051B0 VA: 0x181706BB0
	public void AddButton() { }

	// RVA: 0x1708EF0 Offset: 0x17074F0 VA: 0x181708EF0
	public void InsertElement(ControllerElementType type, int index) { }

	// RVA: 0x1708CD0 Offset: 0x17072D0 VA: 0x181708CD0
	public void InsertAxis(int index) { }

	// RVA: 0x1708DE0 Offset: 0x17073E0 VA: 0x181708DE0
	public void InsertButton(int index) { }

	// RVA: 0x1707890 Offset: 0x1705E90 VA: 0x181707890
	public void DeleteElement(ControllerElementType type, int index) { }

	// RVA: -1 Offset: -1
	public void DeleteElement<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C1910 Offset: 0x6BFF10 VA: 0x1806C1910
	|-CustomController_Editor.DeleteElement<object>
	*/

	// RVA: 0x17090E0 Offset: 0x17076E0 VA: 0x1817090E0
	public bool ReorderElement(ControllerElementType type, int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1707940 Offset: 0x1705F40 VA: 0x181707940
	public void DuplicateElement(ControllerElementType type, int index) { }

	// RVA: -1 Offset: -1
	private void zCZbOSslKxYuFORSNAQeeDKjKrcEb<>(int , List<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C2410 Offset: 0x6C0A10 VA: 0x1806C2410
	|-CustomController_Editor.zCZbOSslKxYuFORSNAQeeDKjKrcEb<object>
	*/

	// RVA: 0x1709E60 Offset: 0x1708460 VA: 0x181709E60
	private ControllerElementIdentifier txTbjsBFXkLALtTKCAnzTQuRHKxx(int , string ) { }

	// RVA: 0x1709B20 Offset: 0x1708120 VA: 0x181709B20
	private CustomController_Editor.Element ifsMRXdDsUjbiirTAEHueLgrpySV(ControllerElementType ) { }

	// RVA: 0x17097F0 Offset: 0x1707DF0 VA: 0x1817097F0
	private ControllerElementIdentifier egNLKAISWQyiTtVvJnNErwGbgtyd(ControllerElementType , string , string , string , string , string , string ) { }

	// RVA: 0x1706F40 Offset: 0x1705540 VA: 0x181706F40
	internal HardwareControllerMap_Game CreateGameHardwareMap() { }
}

// Namespace: Rewired.Data
public class EditorSettings : ScriptableObject // TypeDefIndex: 2316
{
	// Fields
	[CustomObfuscation(rename = False)]
	public int programVersion1; // 0x18
	[CustomObfuscation(rename = False)]
	public int programVersion2; // 0x1C
	[CustomObfuscation(rename = False)]
	public int programVersion3; // 0x20
	[CustomObfuscation(rename = False)]
	public int programVersion4; // 0x24
	[CustomObfuscation(rename = False)]
	public int dataVersion; // 0x28

	// Methods

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: Rewired.Data
public class RuntimeData : ScriptableObject // TypeDefIndex: 2317
{
	// Fields
	[CustomObfuscation(rename = False)]
	public Platform platform; // 0x18
	[CustomObfuscation(rename = False)]
	public WebplayerPlatform webplayerPlatform; // 0x1C
	[CustomObfuscation(rename = False)]
	public EditorPlatform editorPlatform; // 0x20
	[CustomObfuscation(rename = False)]
	public List<TextAsset> libraries; // 0x28

	// Methods

	// RVA: 0x170B870 Offset: 0x1709E70 VA: 0x18170B870
	public void SetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform, List<TextAsset> libraries) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: Rewired.Data
public class EditorPlatformData : ScriptableObject // TypeDefIndex: 2319
{
	// Fields
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform windowsStandalone; // 0x18
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform windowsStore; // 0x20
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform osxStandalone; // 0x28
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform linuxStandalone; // 0x30
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform webplayer; // 0x38
	[CustomObfuscation(rename = False)]
	public EditorPlatformData.Platform fallback; // 0x40

	// Methods

	// RVA: 0x170A220 Offset: 0x1708820 VA: 0x18170A220
	public TextAsset[] GetLibraries(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform) { }

	// RVA: 0x170A2A0 Offset: 0x17088A0 VA: 0x18170A2A0
	public EditorPlatformData.Platform GetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: Rewired.Data
[Browsable(False)]
[EditorBrowsable(1)]
[Serializable]
public sealed class Player_Editor // TypeDefIndex: 2325
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _id; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _name; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _descriptiveName; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _key; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _startPlaying; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<Player_Editor.Mapping> _defaultJoystickMaps; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<Player_Editor.Mapping> _defaultMouseMaps; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<Player_Editor.Mapping> _defaultKeyboardMaps; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<Player_Editor.Mapping> _defaultCustomControllerMaps; // 0x50
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<Player_Editor.CreateControllerInfo> _startingCustomControllers; // 0x58
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _assignMouseOnStart; // 0x60
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _assignKeyboardOnStart; // 0x61
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _excludeFromControllerAutoAssignment; // 0x62
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private Player_Editor.ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings; // 0x68
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private Player_Editor.ControllerMapEnablerSettings _controllerMapEnablerSettings; // 0x70

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public string descriptiveName { get; set; }
	public string key { get; set; }
	public bool startPlaying { get; set; }
	public List<Player_Editor.Mapping> defaultJoystickMaps { get; set; }
	public List<Player_Editor.Mapping> defaultMouseMaps { get; set; }
	public List<Player_Editor.Mapping> defaultKeyboardMaps { get; set; }
	public List<Player_Editor.Mapping> defaultCustomControllerMaps { get; set; }
	public List<Player_Editor.CreateControllerInfo> startingCustomControllers { get; set; }
	public bool assignMouseOnStart { get; set; }
	public bool assignKeyboardOnStart { get; set; }
	public bool excludeFromControllerAutoAssignment { get; set; }
	public Player_Editor.ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings { get; set; }
	public Player_Editor.ControllerMapEnablerSettings controllerMapEnablerSettings { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_id() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	internal void YHNktSgNzjaanHiwBtLbTmlRFSafA(int ) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_name() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void aTeEYkbsZKCKLWIEWaonLtGAkFQyA(string ) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_descriptiveName() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void SlncMYeZmkDTMxLdlDIMZgYqJhXLA(string ) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_key() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	internal void utaQFMWHBOUFTAMaPGnqjEdKqetHb(string ) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_startPlaying() { }

	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	internal void hvUTJIjAwIbySYhfoijOJBLkCnTMA(bool ) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public List<Player_Editor.Mapping> get_defaultJoystickMaps() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	internal void JDKvLPdXtWcXnpyDBjIYbKbLieJ(List<Player_Editor.Mapping> ) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public List<Player_Editor.Mapping> get_defaultMouseMaps() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void CnYfQnkzwZhIjdQdtaULyGHwDFJD(List<Player_Editor.Mapping> ) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public List<Player_Editor.Mapping> get_defaultKeyboardMaps() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	internal void YKdNlrlqSDgRvhnWlsoIvtyQotEx(List<Player_Editor.Mapping> ) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public List<Player_Editor.Mapping> get_defaultCustomControllerMaps() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	internal void avfBuhgCOwtdgKNmMIOCbPXLVTdW(List<Player_Editor.Mapping> ) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public List<Player_Editor.CreateControllerInfo> get_startingCustomControllers() { }

	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	internal void kUsagsXKriYmBgmtbeqSeJHacZCs(List<Player_Editor.CreateControllerInfo> ) { }

	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810
	public bool get_assignMouseOnStart() { }

	// RVA: 0x37F820 Offset: 0x37DE20 VA: 0x18037F820
	internal void JAhAMfIQzGxpIGrVkJvtKhalAgVWA(bool ) { }

	// RVA: 0x1380E10 Offset: 0x137F410 VA: 0x181380E10
	public bool get_assignKeyboardOnStart() { }

	// RVA: 0x14C6DE0 Offset: 0x14C53E0 VA: 0x1814C6DE0
	internal void CJXSVuatIVqsTlFcihrpCzBqsvRMA(bool ) { }

	// RVA: 0x1380E20 Offset: 0x137F420 VA: 0x181380E20
	public bool get_excludeFromControllerAutoAssignment() { }

	// RVA: 0x170A4E0 Offset: 0x1708AE0 VA: 0x18170A4E0
	internal void OSRvPGkiRREVXHgahfDnluFjENwy(bool ) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public Player_Editor.ControllerMapLayoutManagerSettings get_controllerMapLayoutManagerSettings() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void set_controllerMapLayoutManagerSettings(Player_Editor.ControllerMapLayoutManagerSettings value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public Player_Editor.ControllerMapEnablerSettings get_controllerMapEnablerSettings() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void set_controllerMapEnablerSettings(Player_Editor.ControllerMapEnablerSettings value) { }

	// RVA: 0x170AE60 Offset: 0x1709460 VA: 0x18170AE60
	public void .ctor() { }

	// RVA: 0x170A4F0 Offset: 0x1708AF0 VA: 0x18170A4F0
	public void .ctor(Player_Editor ) { }

	// RVA: 0x170A480 Offset: 0x1708A80 VA: 0x18170A480
	public Player_Editor Clone() { }

	// RVA: 0x170B020 Offset: 0x1709620 VA: 0x18170B020
	internal OfCXoqClnlVSJpkEaYBuIVAVFZZB knqXXCimqGaFOxratsxgRgvfUoci() { }
}

// Namespace: Rewired.Data
[Serializable]
public sealed class UserData // TypeDefIndex: 2384
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ConfigVars configVars; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<Player_Editor> players; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputAction> actions; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputActionCategory> actionCategories; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ActionCategoryMap actionCategoryMap; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputBehavior> inputBehaviors; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputMapCategory> mapCategories; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputLayout> joystickLayouts; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputLayout> keyboardLayouts; // 0x50
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputLayout> mouseLayouts; // 0x58
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<InputLayout> customControllerLayouts; // 0x60
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerMap_Editor> joystickMaps; // 0x68
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerMap_Editor> keyboardMaps; // 0x70
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerMap_Editor> mouseMaps; // 0x78
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerMap_Editor> customControllerMaps; // 0x80
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<CustomController_Editor> customControllers; // 0x88
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerMapLayoutManager_RuleSet_Editor> controllerMapLayoutManagerRuleSets; // 0x90
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ControllerMapEnabler_RuleSet_Editor> controllerMapEnablerRuleSets; // 0x98
	private List<InputAction> sqLuZGUybdzajLNLhNDrvXgoRJLA; // 0xA0
	private bool snOUqLpXwmuPFKJSJVjqRfAVmOGV; // 0xA8
	[CompilerGenerated]
	private IList<Player_Editor> <Players_readOnly>k__BackingField; // 0xB0
	[CompilerGenerated]
	private IList<InputAction> <Actions_readOnly>k__BackingField; // 0xB8
	[CompilerGenerated]
	private IList<InputCategory> <ActionCategories_readOnly>k__BackingField; // 0xC0
	[CompilerGenerated]
	private IList<InputBehavior> <InputBehaviors_readOnly>k__BackingField; // 0xC8
	[CompilerGenerated]
	private IList<InputMapCategory> <MapCategories_readOnly>k__BackingField; // 0xD0
	[CompilerGenerated]
	private IList<InputLayout> <JoystickLayouts_readOnly>k__BackingField; // 0xD8
	[CompilerGenerated]
	private IList<InputLayout> <KeyboardLayouts_readOnly>k__BackingField; // 0xE0
	[CompilerGenerated]
	private IList<InputLayout> <MouseLayouts_readOnly>k__BackingField; // 0xE8
	[CompilerGenerated]
	private IList<InputLayout> <CustomControllerLayouts_readOnly>k__BackingField; // 0xF0
	[CompilerGenerated]
	private IList<ControllerMap_Editor> <JoystickMaps_readOnly>k__BackingField; // 0xF8
	[CompilerGenerated]
	private IList<ControllerMap_Editor> <KeyboardMaps_readOnly>k__BackingField; // 0x100
	[CompilerGenerated]
	private IList<ControllerMap_Editor> <MouseMaps_readOnly>k__BackingField; // 0x108
	[CompilerGenerated]
	private IList<ControllerMap_Editor> <CustomControllerMaps_readOnly>k__BackingField; // 0x110
	[CompilerGenerated]
	private IList<ControllerMapLayoutManager_RuleSet_Editor> <ControllerMapLayoutManagerRuleSets_readOnly>k__BackingField; // 0x118
	[CompilerGenerated]
	private IList<ControllerMapEnabler_RuleSet_Editor> <ControllerMapEnablerRuleSets_readOnly>k__BackingField; // 0x120
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int playerIdCounter; // 0x128
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int actionIdCounter; // 0x12C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int actionCategoryIdCounter; // 0x130
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int inputBehaviorIdCounter; // 0x134
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int mapCategoryIdCounter; // 0x138
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int joystickLayoutIdCounter; // 0x13C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int keyboardLayoutIdCounter; // 0x140
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int mouseLayoutIdCounter; // 0x144
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int customControllerLayoutIdCounter; // 0x148
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int joystickMapIdCounter; // 0x14C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int keyboardMapIdCounter; // 0x150
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int mouseMapIdCounter; // 0x154
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int customControllerMapIdCounter; // 0x158
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int customControllerIdCounter; // 0x15C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int controllerMapLayoutManagerSetIdCounter; // 0x160
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int controllerMapEnablerSetIdCounter; // 0x164
	private Func<int, bool> containsActionDelegate; // 0x168

	// Properties
	internal IList<Player_Editor> ZkHbBodPqWmHjdeoHRXuxWNUcCVmA { get; set; }
	internal IList<InputAction> OccfrRhqCXrdlYtlrAVmpCpXlStHA { get; set; }
	internal IList<InputCategory> MhbSdiJiuaHseXIwuvlseimvjsoJA { get; set; }
	internal IList<InputBehavior> XYRHyRLQZfqwYfJgkWaTDEcBtgqE { get; set; }
	internal IList<InputMapCategory> dGzHtzBkTcmAyWVhSutRVieEVGuR { get; set; }
	internal IList<InputLayout> rfBxLDFygoTUSyIKlcmQDLaNlIQs { get; set; }
	internal IList<InputLayout> FBeXPXJAOwETovNlsUTIvKovHApN { get; set; }
	internal IList<InputLayout> CbmrufhtdZEzbcRkrtuHCwQmAdFn { get; set; }
	internal IList<InputLayout> VrpPhGvPscHArYgxucIiClMZQmJNA { get; set; }
	internal IList<ControllerMap_Editor> OeSqpwupmzlJehfCOxintJdKZAHR { get; set; }
	internal IList<ControllerMap_Editor> ynZbEAemqyGjwVHOitMqBjEbgfFoA { get; set; }
	internal IList<ControllerMap_Editor> PKlJMWdlGTjrhyGisbyVItAykvTK { get; set; }
	internal IList<ControllerMap_Editor> XzvchnmUbsrQWPcMwWQSvsHreSYM { get; set; }
	internal IList<ControllerMapLayoutManager_RuleSet_Editor> tcRhSKeMlmedQIDqbMKictQjLOMCb { get; set; }
	internal IList<ControllerMapEnabler_RuleSet_Editor> GaOupjlIbUCatHRvniixpJdXECDl { get; set; }
	public ConfigVars ConfigVars { get; }
	internal IEnumerable<InputMapCategory> nxcfJmNoZKEstYndJaKcfJgVEfjo { get; }
	internal IEnumerable<InputCategory> RZLvXALGJKtLAIAKVAYpDxYtDyQpA { get; }
	internal IEnumerable<InputAction> VhkDfAGDHxoraQeLfrJUQoecUefz { get; }
	public int playerCount { get; }
	private List<InputAction> cztoBzJDhvKxbFfpMOrCRCPYFFRA { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x16237B0 Offset: 0x1621DB0 VA: 0x1816237B0
	internal IList<Player_Editor> lYbCCvFaeXhKsfCvGLydiYxAlYHDE() { }

	[CompilerGenerated]
	// RVA: 0x8DA860 Offset: 0x8D8E60 VA: 0x1808DA860
	private void yCsLddBLMqEnxElqrdVJNmbXYqMm(IList<Player_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x131C550 Offset: 0x131AB50 VA: 0x18131C550
	internal IList<InputAction> ljzjvxhFCcrWQeQMGtCaFPLDqqDC() { }

	[CompilerGenerated]
	// RVA: 0x8221D0 Offset: 0x8207D0 VA: 0x1808221D0
	private void lfiFAOzMqrlzrfUjzOcqfrUhaFOI(IList<InputAction> ) { }

	[CompilerGenerated]
	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	internal IList<InputCategory> JIjlrqFxBbOCixvJLTYqblIMdrbK() { }

	[CompilerGenerated]
	// RVA: 0x8DA8F0 Offset: 0x8D8EF0 VA: 0x1808DA8F0
	private void AmVPSxXDXoYCDzDXraEYGpVGzjKOA(IList<InputCategory> ) { }

	[CompilerGenerated]
	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	internal IList<InputBehavior> JWegLOhzFkhWvJNOxWRvRvgxwIIeA() { }

	[CompilerGenerated]
	// RVA: 0x1621970 Offset: 0x161FF70 VA: 0x181621970
	private void LSFZElDgStfJAfLAxLzUTtHImODG(IList<InputBehavior> ) { }

	[CompilerGenerated]
	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	internal IList<InputMapCategory> yLEJYEDUvKBAgCKPlCkoYrWaXPV() { }

	[CompilerGenerated]
	// RVA: 0x510990 Offset: 0x50EF90 VA: 0x180510990
	private void yeJCdjFLwwAlvpchgJdQSLiFkWMUA(IList<InputMapCategory> ) { }

	[CompilerGenerated]
	// RVA: 0x3A3640 Offset: 0x3A1C40 VA: 0x1803A3640
	internal IList<InputLayout> kfIZFwwqAzgbIEyUdEwIMSvGrggv() { }

	[CompilerGenerated]
	// RVA: 0x15B40E0 Offset: 0x15B26E0 VA: 0x1815B40E0
	private void ygOTXEkAuTOUeUadEVtmsaSeEQifA(IList<InputLayout> ) { }

	[CompilerGenerated]
	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	internal IList<InputLayout> XjOuAOMvgBGIDDmOQxgdJbfwzHBi() { }

	[CompilerGenerated]
	// RVA: 0x12F1A10 Offset: 0x12F0010 VA: 0x1812F1A10
	private void vyfBqeAELRjswXYKtcxuvuOJdQYm(IList<InputLayout> ) { }

	[CompilerGenerated]
	// RVA: 0x5513E0 Offset: 0x54F9E0 VA: 0x1805513E0
	internal IList<InputLayout> WikwDLpiFIamRBlfCfNljodKFsrjc() { }

	[CompilerGenerated]
	// RVA: 0x15B42A0 Offset: 0x15B28A0 VA: 0x1815B42A0
	private void dXnLtbaqjZsEvoOpklxXZkCImXvG(IList<InputLayout> ) { }

	[CompilerGenerated]
	// RVA: 0x551B80 Offset: 0x550180 VA: 0x180551B80
	internal IList<InputLayout> pHhBlabZAaNcagyBqxbTMGGkfiUo() { }

	[CompilerGenerated]
	// RVA: 0x551B90 Offset: 0x550190 VA: 0x180551B90
	private void MEPHXWEKceufsKVFjklYfQSHpQkO(IList<InputLayout> ) { }

	[CompilerGenerated]
	// RVA: 0x5612C0 Offset: 0x55F8C0 VA: 0x1805612C0
	internal IList<ControllerMap_Editor> ZbLQVjKmcHWICjIRNApbaizpTzGRA() { }

	[CompilerGenerated]
	// RVA: 0x15B4860 Offset: 0x15B2E60 VA: 0x1815B4860
	private void dxsiTwVmSrWBlaquSynadqiCCujl(IList<ControllerMap_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	internal IList<ControllerMap_Editor> SzQKbbUbUzCrDdgokICBAEXunnCIb() { }

	[CompilerGenerated]
	// RVA: 0x15B47E0 Offset: 0x15B2DE0 VA: 0x1815B47E0
	private void ovwKIaYHVRhLQPZbItTILngBELdz(IList<ControllerMap_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x15B3B70 Offset: 0x15B2170 VA: 0x1815B3B70
	internal IList<ControllerMap_Editor> fjTPhdFDlfdUJIglJNrLBRmKbFZn() { }

	[CompilerGenerated]
	// RVA: 0x15B42C0 Offset: 0x15B28C0 VA: 0x1815B42C0
	private void KWulxGcvoTGMuYobsSELZpNpADAF(IList<ControllerMap_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	internal IList<ControllerMap_Editor> sIKzNhwGdoZgJvfbOGzOMnBHIeEfA() { }

	[CompilerGenerated]
	// RVA: 0x16212F0 Offset: 0x161F8F0 VA: 0x1816212F0
	private void FCmOtgStTzmKYOJlRxmIJOGzumFg(IList<ControllerMap_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x1634AF0 Offset: 0x16330F0 VA: 0x181634AF0
	internal IList<ControllerMapLayoutManager_RuleSet_Editor> aCcbSNjYAUdludlUtudVtrXLApFaA() { }

	[CompilerGenerated]
	// RVA: 0x16410B0 Offset: 0x163F6B0 VA: 0x1816410B0
	private void BGuXVnyceGodELxUzTXqypgHoOzx(IList<ControllerMapLayoutManager_RuleSet_Editor> ) { }

	[CompilerGenerated]
	// RVA: 0x8DA910 Offset: 0x8D8F10 VA: 0x1808DA910
	internal IList<ControllerMapEnabler_RuleSet_Editor> rVHINsQgdYbUTxqHYnukaWlwglSJ() { }

	[CompilerGenerated]
	// RVA: 0x8DA9C0 Offset: 0x8D8FC0 VA: 0x1808DA9C0
	private void meUITxplhFIhqgFYLJIizQZAkdrjA(IList<ControllerMapEnabler_RuleSet_Editor> ) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ConfigVars get_ConfigVars() { }

	[IteratorStateMachine(typeof(UserData.rGFrnVLyzJlTyhmHSWLHLVTBjpkm))]
	// RVA: 0x1721790 Offset: 0x171FD90 VA: 0x181721790
	internal IEnumerable<InputMapCategory> rzdcaGMsfqbUAaxsOaFZyiKsVjzIA(string ) { }

	[IteratorStateMachine(typeof(UserData.wHKdaaGPHrSFoITmQfXufSnsWBKsA))]
	// RVA: 0x171F650 Offset: 0x171DC50 VA: 0x18171F650
	internal IEnumerable<InputMapCategory> ZkAXlLTCRVrBkuPuupFsXYrCoCfB() { }

	[IteratorStateMachine(typeof(UserData.yPyhEfAoKiDdclWsGCHmJRJegymcA))]
	// RVA: 0x1721820 Offset: 0x171FE20 VA: 0x181721820
	internal IEnumerable<InputMapCategory> skzcQwKFSPFZnofqwAPoeruQMsbvA(string ) { }

	[IteratorStateMachine(typeof(UserData.gjlAYZAWEKllyualrzvQaKsFzDiV))]
	// RVA: 0x171E960 Offset: 0x171CF60 VA: 0x18171E960
	internal IEnumerable<InputCategory> MLJCqPjwVvbWWxQmXZMYLDUFPdPu(string ) { }

	[IteratorStateMachine(typeof(UserData.NXRTQHDhsIpeJGNFitmAdMUThalQ))]
	// RVA: 0x170D510 Offset: 0x170BB10 VA: 0x18170D510
	internal IEnumerable<InputCategory> DdbliloqjJqJUbzoouxvdtwPqhJQ() { }

	[IteratorStateMachine(typeof(UserData.gvmmaavAbPAEfQqEjWjDwUmylJaS))]
	// RVA: 0x1720750 Offset: 0x171ED50 VA: 0x181720750
	internal IEnumerable<InputCategory> gOsDrNHQpCFataOJxeXumehCqgCiA(string ) { }

	[IteratorStateMachine(typeof(UserData.kMJwpGhFHVfPxbUkmFBSiUjXslXH))]
	// RVA: 0x171EC10 Offset: 0x171D210 VA: 0x18171EC10
	internal IEnumerable<InputAction> OroVbQuHTjxOXAQgItKsnRUnjbvr() { }

	[IteratorStateMachine(typeof(UserData.rimaglLGaJMpvfpPFhyIvabJtFgL))]
	// RVA: 0x17203C0 Offset: 0x171E9C0 VA: 0x1817203C0
	internal IEnumerable<InputAction> cbaJdzEDeVhBFktZItxlgLyfYwyLA(int , bool ) { }

	[IteratorStateMachine(typeof(UserData.WwAxueMkaRHeZRaDKMfnxARrXSou))]
	// RVA: 0x1712030 Offset: 0x1710630 VA: 0x181712030
	internal IEnumerable<InputAction> EEgjPzuOwfSFKvshZAZOpzqvtWSD(string , bool ) { }

	[IteratorStateMachine(typeof(UserData.XFBhqqhaTBdBLCxPZoEBRauiSNjWA))]
	// RVA: 0x1722680 Offset: 0x1720C80 VA: 0x181722680
	internal IEnumerable<InputAction> xMEGeVCbKYDaULPaiJiJEdRPmSIFA(string ) { }

	[IteratorStateMachine(typeof(UserData.LxLjzEAdyruWsBHuKAqExSkuiEdBA))]
	// RVA: 0x170C4B0 Offset: 0x170AAB0 VA: 0x18170C4B0
	internal IEnumerable<InputAction> BVQZvAhNiMTGjLgTusqsoaSznGyO(int , bool ) { }

	[IteratorStateMachine(typeof(UserData.QwVwPbREzfYDoWDNVEEUhLMZWXWjA))]
	// RVA: 0x1720540 Offset: 0x171EB40 VA: 0x181720540
	internal IEnumerable<InputAction> eRSkmyDDCsCcuUhoysoudBURTKhf(string , bool ) { }

	// RVA: 0x171FEE0 Offset: 0x171E4E0 VA: 0x18171FEE0
	public void .ctor() { }

	// RVA: 0x171F6C0 Offset: 0x171DCC0 VA: 0x18171F6C0
	private void .ctor(bool ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x171F1E0 Offset: 0x171D7E0 VA: 0x18171F1E0
	internal void SetDefaultValuesOnCreation() { }

	// RVA: 0x1713E70 Offset: 0x1712470 VA: 0x181713E70
	public List<InputAction> GetActions_Copy() { }

	// RVA: 0x1716E70 Offset: 0x1715470 VA: 0x181716E70
	public List<InputBehavior> GetInputBehaviors_Copy() { }

	// RVA: 0x17185C0 Offset: 0x1716BC0 VA: 0x1817185C0
	public List<KeyboardMap> GetKeyboardMaps_Copy() { }

	// RVA: 0x1719F60 Offset: 0x1718560 VA: 0x181719F60
	public List<MouseMap> GetMouseMaps_Copy() { }

	// RVA: 0x17207E0 Offset: 0x171EDE0 VA: 0x1817207E0
	public int get_playerCount() { }

	// RVA: 0x170C2F0 Offset: 0x170A8F0 VA: 0x18170C2F0
	public void AddPlayer() { }

	// RVA: 0x171E170 Offset: 0x171C770 VA: 0x18171E170
	public void InsertPlayer(int index) { }

	// RVA: 0x170F700 Offset: 0x170DD00 VA: 0x18170F700
	public void DeletePlayer(int index) { }

	// RVA: 0x171F170 Offset: 0x171D770 VA: 0x18171F170
	public bool ReorderPlayer(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1711C90 Offset: 0x1710290 VA: 0x181711C90
	public void DuplicatePlayer(int index) { }

	// RVA: 0x171A490 Offset: 0x1718A90 VA: 0x18171A490
	public string[] GetPlayerNames() { }

	// RVA: 0x171A580 Offset: 0x1718B80 VA: 0x18171A580
	public int GetPlayerNames(IList<string> results) { }

	// RVA: 0x171A2B0 Offset: 0x17188B0 VA: 0x18171A2B0
	public int[] GetPlayerIds() { }

	// RVA: 0x171A750 Offset: 0x1718D50 VA: 0x18171A750
	public int[] GetPlayerRuntimeIds() { }

	// RVA: 0x171A810 Offset: 0x1718E10 VA: 0x18171A810
	public int GetPlayerRuntimeIds(IList<int> results) { }

	// RVA: 0x171A390 Offset: 0x1718990 VA: 0x18171A390
	public string GetPlayerNameById(int id) { }

	// RVA: 0x171A930 Offset: 0x1718F30 VA: 0x18171A930
	public Player_Editor GetPlayer(int index) { }

	// RVA: 0x171A1C0 Offset: 0x17187C0 VA: 0x18171A1C0
	public int GetPlayerId(string name) { }

	// RVA: 0x171E2F0 Offset: 0x171C8F0 VA: 0x18171E2F0
	public bool IsMouseAssigned() { }

	// RVA: 0x170CD70 Offset: 0x170B370 VA: 0x18170CD70
	public void ClearMouseAssignments() { }

	// RVA: 0x171E240 Offset: 0x171C840 VA: 0x18171E240
	public bool IsKeyboardAssigned() { }

	// RVA: 0x170CCE0 Offset: 0x170B2E0 VA: 0x18170CCE0
	public void ClearKeyboardAssignments() { }

	// RVA: 0x1720830 Offset: 0x171EE30 VA: 0x181720830
	private List<InputAction> jrmWjHyPceXANJInbFzFekgUDhxz() { }

	// RVA: 0x170B990 Offset: 0x1709F90 VA: 0x18170B990
	public void AddAction(int categoryId) { }

	// RVA: 0x171D780 Offset: 0x171BD80 VA: 0x18171D780
	public void InsertAction(int categoryId, int actionId) { }

	// RVA: 0x170D750 Offset: 0x170BD50 VA: 0x18170D750
	public void DeleteAction(int categoryId, int actionId) { }

	// RVA: 0x171ED20 Offset: 0x171D320 VA: 0x18171ED20
	public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow) { }

	// RVA: 0x170FE90 Offset: 0x170E490 VA: 0x18170FE90
	public int DuplicateAction_FromButton(int categoryId, int actionId) { }

	// RVA: 0x17212E0 Offset: 0x171F8E0 VA: 0x1817212E0
	private int qESjBNrLJvqiIQgaiEMhYBABmqFf(int , InputAction ) { }

	// RVA: 0x1713920 Offset: 0x1711F20 VA: 0x181713920
	public string[] GetActionNames() { }

	// RVA: 0x1713AD0 Offset: 0x17120D0 VA: 0x181713AD0
	public int GetActionNames(IList<string> results) { }

	// RVA: 0x1713650 Offset: 0x1711C50 VA: 0x181713650
	public int[] GetActionIds() { }

	// RVA: 0x17133E0 Offset: 0x17119E0 VA: 0x1817133E0
	public int GetActionIds(IList<int> results) { }

	// RVA: 0x17137F0 Offset: 0x1711DF0 VA: 0x1817137F0
	public string GetActionNameById(int id) { }

	// RVA: 0x1713DD0 Offset: 0x17123D0 VA: 0x181713DD0
	public InputAction GetAction(int index) { }

	// RVA: 0x1713D40 Offset: 0x1712340 VA: 0x181713D40
	public InputAction GetAction(string name) { }

	// RVA: 0x1712AE0 Offset: 0x17110E0 VA: 0x181712AE0
	public InputAction GetActionById(int id) { }

	// RVA: 0x1713340 Offset: 0x1711940 VA: 0x181713340
	public int GetActionId(string name) { }

	// RVA: 0x171AF00 Offset: 0x1719500 VA: 0x18171AF00
	public string[] GetSortedActionNamesInCategory(int id) { }

	[IteratorStateMachine(typeof(UserData.ECFMFanDvkGvuzeAwbziGuHYQalR))]
	// RVA: 0x171F3F0 Offset: 0x171D9F0 VA: 0x18171F3F0
	public IEnumerable<string> SortedActionNamesInCategory(int id) { }

	// RVA: 0x171A9B0 Offset: 0x1718FB0 VA: 0x18171A9B0
	public string[] GetSortedActionDescriptiveNamesInCategory(int id) { }

	[IteratorStateMachine(typeof(UserData.IsOrCUuJwuxxRuwrhCYasxleFHYx))]
	// RVA: 0x171F2F0 Offset: 0x171D8F0 VA: 0x18171F2F0
	public IEnumerable<string> SortedActionDescriptiveNamesInCategory(int id) { }

	// RVA: 0x171AC40 Offset: 0x1719240 VA: 0x18171AC40
	public int[] GetSortedActionIdsInCategory(int id) { }

	[IteratorStateMachine(typeof(UserData.SjKwswxlfNNjPSvgCxpZIEINADGGA))]
	// RVA: 0x171F370 Offset: 0x171D970 VA: 0x18171F370
	public IEnumerable<int> SortedActionIdsInCategory(int id) { }

	// RVA: 0x170CE10 Offset: 0x170B410 VA: 0x18170CE10
	public bool ContainsAction(int id) { }

	// RVA: 0x171C3E0 Offset: 0x171A9E0 VA: 0x18171C3E0
	public int IndexOfAction(int id) { }

	// RVA: 0x171C4B0 Offset: 0x171AAB0 VA: 0x18171C4B0
	public int IndexOfAction(string name) { }

	// RVA: 0x170B8C0 Offset: 0x1709EC0 VA: 0x18170B8C0
	public void AddActionCategory() { }

	// RVA: 0x171D680 Offset: 0x171BC80 VA: 0x18171D680
	public void InsertActionCategory(int index) { }

	// RVA: 0x170D580 Offset: 0x170BB80 VA: 0x18170D580
	public void DeleteActionCategory(int index) { }

	// RVA: 0x171EC80 Offset: 0x171D280 VA: 0x18171EC80
	public bool ReorderActionCategory(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x170F7B0 Offset: 0x170DDB0 VA: 0x18170F7B0
	public void DuplicateActionCategory(int index, bool duplicateActions) { }

	// RVA: 0x170CC10 Offset: 0x170B210 VA: 0x18170CC10
	public void ChangeActionCategory(int actionId, int newCategoryId) { }

	// RVA: 0x1712C40 Offset: 0x1711240 VA: 0x181712C40
	public int GetActionCategoryCount(int id) { }

	// RVA: 0x1712F90 Offset: 0x1711590 VA: 0x181712F90
	public int GetActionCategoryIndex(int id) { }

	// RVA: 0x1713150 Offset: 0x1711750 VA: 0x181713150
	public string[] GetActionCategoryNames() { }

	// RVA: 0x1712EB0 Offset: 0x17114B0 VA: 0x181712EB0
	public int[] GetActionCategoryIds() { }

	// RVA: 0x1713240 Offset: 0x1711840 VA: 0x181713240
	public InputCategory GetActionCategory(int index) { }

	// RVA: 0x17132C0 Offset: 0x17118C0 VA: 0x1817132C0
	public InputCategory GetActionCategory(string name) { }

	// RVA: 0x1712BD0 Offset: 0x17111D0 VA: 0x181712BD0
	public InputCategory GetActionCategoryById(int id) { }

	// RVA: 0x1712E20 Offset: 0x1711420 VA: 0x181712E20
	public int GetActionCategoryId(string name) { }

	// RVA: 0x1713050 Offset: 0x1711650 VA: 0x181713050
	public string GetActionCategoryNameById(int id) { }

	// RVA: 0x171C320 Offset: 0x171A920 VA: 0x18171C320
	public int IndexOfActionCategory(int id) { }

	// RVA: 0x171C230 Offset: 0x171A830 VA: 0x18171C230
	public int IndexOfActionCategory(string name) { }

	// RVA: 0x1712DD0 Offset: 0x17113D0 VA: 0x181712DD0
	public int GetActionCategoryCount() { }

	// RVA: 0x170BF30 Offset: 0x170A530 VA: 0x18170BF30
	public void AddInputBehavior() { }

	// RVA: 0x171DD60 Offset: 0x171C360 VA: 0x18171DD60
	public void InsertInputBehavior(int index) { }

	// RVA: 0x170E4F0 Offset: 0x170CAF0 VA: 0x18170E4F0
	public void DeleteInputBehavior(int index) { }

	// RVA: 0x171EF40 Offset: 0x171D540 VA: 0x18171EF40
	public bool ReorderInputBehavior(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1710BF0 Offset: 0x170F1F0 VA: 0x181710BF0
	public void DuplicateInputBehavior(int index) { }

	// RVA: 0x1716C80 Offset: 0x1715280 VA: 0x181716C80
	public string[] GetInputBehaviorNames() { }

	// RVA: 0x1716BA0 Offset: 0x17151A0 VA: 0x181716BA0
	public int[] GetInputBehaviorIds() { }

	// RVA: 0x1716DF0 Offset: 0x17153F0 VA: 0x181716DF0
	public InputBehavior GetInputBehavior(int index) { }

	// RVA: 0x1716D70 Offset: 0x1715370 VA: 0x181716D70
	public InputBehavior GetInputBehavior(string name) { }

	// RVA: 0x1716A50 Offset: 0x1715050 VA: 0x181716A50
	public InputBehavior GetInputBehaviorById(int id) { }

	// RVA: 0x1716B10 Offset: 0x1715110 VA: 0x181716B10
	public int GetInputBehaviorId(string name) { }

	// RVA: 0x171CF00 Offset: 0x171B500 VA: 0x18171CF00
	public int IndexOfInputBehavior(int id) { }

	// RVA: 0x171CE00 Offset: 0x171B400 VA: 0x18171CE00
	public int IndexOfInputBehavior(string name) { }

	// RVA: 0x170C170 Offset: 0x170A770 VA: 0x18170C170
	public void AddMapCategory() { }

	// RVA: 0x171DFD0 Offset: 0x171C5D0 VA: 0x18171DFD0
	public void InsertMapCategory(int index) { }

	// RVA: 0x170EE10 Offset: 0x170D410 VA: 0x18170EE10
	public void DeleteMapCategory(int index) { }

	// RVA: 0x171F090 Offset: 0x171D690 VA: 0x18171F090
	public bool ReorderMapCategory(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x17114E0 Offset: 0x170FAE0 VA: 0x1817114E0
	public void DuplicateMapCategory(int index, bool duplicateMaps) { }

	// RVA: 0x1719110 Offset: 0x1717710 VA: 0x181719110
	public int GetMapCategoryMapCount(int id) { }

	// RVA: 0x1719050 Offset: 0x1717650 VA: 0x181719050
	public int GetMapCategoryIndex(int id) { }

	// RVA: 0x1719400 Offset: 0x1717A00 VA: 0x181719400
	public string[] GetMapCategoryNames() { }

	// RVA: 0x1718F70 Offset: 0x1717570 VA: 0x181718F70
	public int[] GetMapCategoryIds() { }

	// RVA: 0x17194F0 Offset: 0x1717AF0 VA: 0x1817194F0
	public InputMapCategory GetMapCategory(int index) { }

	// RVA: 0x1719570 Offset: 0x1717B70 VA: 0x181719570
	public InputMapCategory GetMapCategory(string name) { }

	// RVA: 0x1718E20 Offset: 0x1717420 VA: 0x181718E20
	public InputMapCategory GetMapCategoryById(int id) { }

	// RVA: 0x1718EE0 Offset: 0x17174E0 VA: 0x181718EE0
	public int GetMapCategoryId(string name) { }

	// RVA: 0x1719300 Offset: 0x1717900 VA: 0x181719300
	public string GetMapCategoryNameById(int id) { }

	// RVA: 0x171D320 Offset: 0x171B920 VA: 0x18171D320
	public int IndexOfMapCategory(int id) { }

	// RVA: 0x171D3E0 Offset: 0x171B9E0 VA: 0x18171D3E0
	public int IndexOfMapCategory(string name) { }

	// RVA: 0x1718D90 Offset: 0x1717390 VA: 0x181718D90
	public string[] GetLayoutNames(ControllerType controllerType) { }

	// RVA: 0x1718720 Offset: 0x1716D20 VA: 0x181718720
	public int[] GetLayoutIds(ControllerType controllerType) { }

	// RVA: 0x170BFF0 Offset: 0x170A5F0 VA: 0x18170BFF0
	public void AddJoystickLayout() { }

	// RVA: 0x171DE30 Offset: 0x171C430 VA: 0x18171DE30
	public void InsertJoystickLayout(int index) { }

	// RVA: 0x170E6D0 Offset: 0x170CCD0 VA: 0x18170E6D0
	public void DeleteJoystickLayout(int index) { }

	// RVA: 0x171EFB0 Offset: 0x171D5B0 VA: 0x18171EFB0
	public bool ReorderJoystickLayout(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1710DC0 Offset: 0x170F3C0 VA: 0x181710DC0
	public void DuplicateJoystickLayout(int index, bool duplicateMaps) { }

	// RVA: 0x17172F0 Offset: 0x17158F0 VA: 0x1817172F0
	public int GetJoystickLayoutMapCount(int id) { }

	// RVA: 0x1717230 Offset: 0x1715830 VA: 0x181717230
	public int GetJoystickLayoutIndex(int id) { }

	// RVA: 0x17174A0 Offset: 0x1715AA0 VA: 0x1817174A0
	public string[] GetJoystickLayoutNames() { }

	// RVA: 0x1717150 Offset: 0x1715750 VA: 0x181717150
	public int[] GetJoystickLayoutIds() { }

	// RVA: 0x1717610 Offset: 0x1715C10 VA: 0x181717610
	public InputLayout GetJoystickLayout(int index) { }

	// RVA: 0x1717590 Offset: 0x1715B90 VA: 0x181717590
	public InputLayout GetJoystickLayout(string name) { }

	// RVA: 0x1716FD0 Offset: 0x17155D0 VA: 0x181716FD0
	public InputLayout GetJoystickLayoutById(int id) { }

	// RVA: 0x17170C0 Offset: 0x17156C0 VA: 0x1817170C0
	public int GetJoystickLayoutId(string name) { }

	// RVA: 0x171CFC0 Offset: 0x171B5C0 VA: 0x18171CFC0
	public int IndexOfJoystickLayout(int id) { }

	// RVA: 0x171D080 Offset: 0x171B680 VA: 0x18171D080
	public int IndexOfJoystickLayout(string name) { }

	// RVA: 0x17173C0 Offset: 0x17159C0 VA: 0x1817173C0
	public string GetJoystickLayoutNameById(int id) { }

	// RVA: 0x170C0B0 Offset: 0x170A6B0 VA: 0x18170C0B0
	public void AddKeyboardLayout() { }

	// RVA: 0x171DF00 Offset: 0x171C500 VA: 0x18171DF00
	public void InsertKeyboardLayout(int index) { }

	// RVA: 0x170EA70 Offset: 0x170D070 VA: 0x18170EA70
	public void DeleteKeyboardLayout(int index) { }

	// RVA: 0x171F020 Offset: 0x171D620 VA: 0x18171F020
	public bool ReorderKeyboardLayout(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1711150 Offset: 0x170F750 VA: 0x181711150
	public void DuplicateKeyboardLayout(int index, bool duplicateMaps) { }

	// RVA: 0x1717F70 Offset: 0x1716570 VA: 0x181717F70
	public int GetKeyboardLayoutMapCount(int id) { }

	// RVA: 0x1717EB0 Offset: 0x17164B0 VA: 0x181717EB0
	public int GetKeyboardLayoutIndex(int id) { }

	// RVA: 0x1718120 Offset: 0x1716720 VA: 0x181718120
	public string[] GetKeyboardLayoutNames() { }

	// RVA: 0x1717DD0 Offset: 0x17163D0 VA: 0x181717DD0
	public int[] GetKeyboardLayoutIds() { }

	// RVA: 0x1718290 Offset: 0x1716890 VA: 0x181718290
	public InputLayout GetKeyboardLayout(int index) { }

	// RVA: 0x1718210 Offset: 0x1716810 VA: 0x181718210
	public InputLayout GetKeyboardLayout(string name) { }

	// RVA: 0x1717C50 Offset: 0x1716250 VA: 0x181717C50
	public InputLayout GetKeyboardLayoutById(int id) { }

	// RVA: 0x1717D40 Offset: 0x1716340 VA: 0x181717D40
	public int GetKeyboardLayoutId(string name) { }

	// RVA: 0x171D170 Offset: 0x171B770 VA: 0x18171D170
	public int IndexOfKeyboardLayout(int id) { }

	// RVA: 0x171D230 Offset: 0x171B830 VA: 0x18171D230
	public int IndexOfKeyboardLayout(string name) { }

	// RVA: 0x1718040 Offset: 0x1716640 VA: 0x181718040
	public string GetKeyboardLayoutNameById(int id) { }

	// RVA: 0x170C230 Offset: 0x170A830 VA: 0x18170C230
	public void AddMouseLayout() { }

	// RVA: 0x171E0A0 Offset: 0x171C6A0 VA: 0x18171E0A0
	public void InsertMouseLayout(int index) { }

	// RVA: 0x170F360 Offset: 0x170D960 VA: 0x18170F360
	public void DeleteMouseLayout(int index) { }

	// RVA: 0x171F100 Offset: 0x171D700 VA: 0x18171F100
	public bool ReorderMouseLayout(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1711900 Offset: 0x170FF00 VA: 0x181711900
	public void DuplicateMouseLayout(int index, bool duplicateMaps) { }

	// RVA: 0x1719910 Offset: 0x1717F10 VA: 0x181719910
	public int GetMouseLayoutMapCount(int id) { }

	// RVA: 0x1719850 Offset: 0x1717E50 VA: 0x181719850
	public int GetMouseLayoutIndex(int id) { }

	// RVA: 0x1719AC0 Offset: 0x17180C0 VA: 0x181719AC0
	public string[] GetMouseLayoutNames() { }

	// RVA: 0x1719770 Offset: 0x1717D70 VA: 0x181719770
	public int[] GetMouseLayoutIds() { }

	// RVA: 0x1719BB0 Offset: 0x17181B0 VA: 0x181719BB0
	public InputLayout GetMouseLayout(int index) { }

	// RVA: 0x1719C30 Offset: 0x1718230 VA: 0x181719C30
	public InputLayout GetMouseLayout(string name) { }

	// RVA: 0x17195F0 Offset: 0x1717BF0 VA: 0x1817195F0
	public InputLayout GetMouseLayoutById(int id) { }

	// RVA: 0x17196E0 Offset: 0x1717CE0 VA: 0x1817196E0
	public int GetMouseLayoutId(string name) { }

	// RVA: 0x171D5C0 Offset: 0x171BBC0 VA: 0x18171D5C0
	public int IndexOfMouseLayout(int id) { }

	// RVA: 0x171D4D0 Offset: 0x171BAD0 VA: 0x18171D4D0
	public int IndexOfMouseLayout(string name) { }

	// RVA: 0x17199E0 Offset: 0x1717FE0 VA: 0x1817199E0
	public string GetMouseLayoutNameById(int id) { }

	// RVA: 0x170BC00 Offset: 0x170A200 VA: 0x18170BC00
	public void AddCustomControllerLayout() { }

	// RVA: 0x171D9F0 Offset: 0x171BFF0 VA: 0x18171D9F0
	public void InsertCustomControllerLayout(int index) { }

	// RVA: 0x170DF90 Offset: 0x170C590 VA: 0x18170DF90
	public void DeleteCustomControllerLayout(int index) { }

	// RVA: 0x171EE50 Offset: 0x171D450 VA: 0x18171EE50
	public bool ReorderCustomControllerLayout(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x17104F0 Offset: 0x170EAF0 VA: 0x1817104F0
	public void DuplicateCustomControllerLayout(int index, bool duplicateMaps) { }

	// RVA: 0x1715E40 Offset: 0x1714440 VA: 0x181715E40
	public int GetCustomControllerLayoutMapCount(int id) { }

	// RVA: 0x1715D80 Offset: 0x1714380 VA: 0x181715D80
	public int GetCustomControllerLayoutIndex(int id) { }

	// RVA: 0x1715FF0 Offset: 0x17145F0 VA: 0x181715FF0
	public string[] GetCustomControllerLayoutNames() { }

	// RVA: 0x1715CA0 Offset: 0x17142A0 VA: 0x181715CA0
	public int[] GetCustomControllerLayoutIds() { }

	// RVA: 0x1716160 Offset: 0x1714760 VA: 0x181716160
	public InputLayout GetCustomControllerLayout(int index) { }

	// RVA: 0x17160E0 Offset: 0x17146E0 VA: 0x1817160E0
	public InputLayout GetCustomControllerLayout(string name) { }

	// RVA: 0x1715B20 Offset: 0x1714120 VA: 0x181715B20
	public InputLayout GetCustomControllerLayoutById(int id) { }

	// RVA: 0x1715C10 Offset: 0x1714210 VA: 0x181715C10
	public int GetCustomControllerLayoutId(string name) { }

	// RVA: 0x171CA40 Offset: 0x171B040 VA: 0x18171CA40
	public int IndexOfCustomControllerLayout(int id) { }

	// RVA: 0x171C950 Offset: 0x171AF50 VA: 0x18171C950
	public int IndexOfCustomControllerLayout(string name) { }

	// RVA: 0x1715F10 Offset: 0x1714510 VA: 0x181715F10
	public string GetCustomControllerLayoutNameById(int id) { }

	// RVA: 0x1718AA0 Offset: 0x17170A0 VA: 0x181718AA0
	public string GetLayoutNameById(ControllerType controllerType, int id) { }

	// RVA: 0x17208D0 Offset: 0x171EED0 VA: 0x1817208D0
	internal ControllerMap kmXfZZbuMsBGNNPqfWrrMHgfgPCu(Controller , int , int ) { }

	// RVA: 0x1717900 Offset: 0x1715F00 VA: 0x181717900
	public ControllerMap_Editor GetJoystickMap(int categoryId, Guid hardwareGuid, int layoutId) { }

	// RVA: 0x1717690 Offset: 0x1715C90 VA: 0x181717690
	public ControllerMap_Editor GetJoystickMapById(int id, out int joystickMapIndex) { }

	// RVA: 0x1717AA0 Offset: 0x17160A0 VA: 0x181717AA0
	public List<ControllerMap_Editor> GetJoystickMaps(Guid hardwareGuid) { }

	// RVA: 0x1717760 Offset: 0x1715D60 VA: 0x181717760
	public int GetJoystickMapId(int categoryId, Guid hardwareGuid, int layoutId) { }

	// RVA: 0x171B6B0 Offset: 0x1719CB0 VA: 0x18171B6B0
	public bool HasJoystickMap(int categoryId, Guid hardwareGuid, int layoutId) { }

	// RVA: 0x171B5A0 Offset: 0x1719BA0 VA: 0x18171B5A0
	public bool HasJoystickMap(Guid hardwareGuid) { }

	// RVA: 0x171B450 Offset: 0x1719A50 VA: 0x18171B450
	public bool HasJoystickMapInCategory(Guid hardwareGuid, int categoryId) { }

	// RVA: 0x170D0F0 Offset: 0x170B6F0 VA: 0x18170D0F0
	public bool CreateJoystickMap(int categoryId, Guid joystickOrTemplateGuid, int layoutId) { }

	// RVA: 0x170E9B0 Offset: 0x170CFB0 VA: 0x18170E9B0
	public void DeleteJoystickMap(int id) { }

	// RVA: 0x1711040 Offset: 0x170F640 VA: 0x181711040
	public int DuplicateJoystickMap(int index) { }

	// RVA: 0x170C550 Offset: 0x170AB50 VA: 0x18170C550
	internal JoystickMap BhyJCKMJLfNuZkhyOdGAYyUkspeU(HardwareControllerMapIdentifier , int , int ) { }

	// RVA: 0x17210A0 Offset: 0x171F6A0 VA: 0x1817210A0
	internal JoystickMap pBBXIWfGwOXqYTIhIttXCZllMpRn(Joystick , int , int ) { }

	// RVA: 0x17121B0 Offset: 0x17107B0 VA: 0x1817121B0
	private JoystickMap EzJxtkyLoQIPiouuRnpaWYMytUdW(HardwareControllerMapIdentifier , int , int ) { }

	// RVA: 0x1721420 Offset: 0x171FA20 VA: 0x181721420
	private ControllerMap_Editor qRmNXSkdVKakQTQeCaBIhzwfADJWA(int , Guid , int , bool ) { }

	// RVA: 0x171BFA0 Offset: 0x171A5A0 VA: 0x18171BFA0
	private ControllerMap_Editor HtwWqrtjirzNjzGbeQSOYRdthFmN(int , Guid , int ) { }

	// RVA: 0x17214A0 Offset: 0x171FAA0 VA: 0x1817214A0
	private JoystickMap rNWbsIyxKSPWhMApUIGHWNXDOgCJ(HardwareControllerMapIdentifier , ControllerMap_Editor , HardwareJoystickTemplateMap , HardwareJoystickMap , int , int ) { }

	// RVA: 0x170C600 Offset: 0x170AC00 VA: 0x18170C600
	private JoystickMap BqKeBDVwTYwvNeXnxTfUvzcGXXxE(JoystickMap , HardwareControllerMapIdentifier ) { }

	// RVA: 0x17184E0 Offset: 0x1716AE0 VA: 0x1817184E0
	public ControllerMap_Editor GetKeyboardMap(int categoryId, int layoutId) { }

	// RVA: 0x17183E0 Offset: 0x17169E0 VA: 0x1817183E0
	public int GetKeyboardMapId(int categoryId, int layoutId) { }

	// RVA: 0x171B9B0 Offset: 0x1719FB0 VA: 0x18171B9B0
	public bool HasKeyboardMap(int categoryId, Guid hardwareGuid, int layoutId) { }

	// RVA: 0x170D270 Offset: 0x170B870 VA: 0x18170D270
	public bool CreateKeyboardMap(int categoryId, int layoutId) { }

	// RVA: 0x170ED50 Offset: 0x170D350 VA: 0x18170ED50
	public void DeleteKeyboardMap(int id) { }

	// RVA: 0x17113D0 Offset: 0x170F9D0 VA: 0x1817113D0
	public int DuplicateKeyboardMap(int index) { }

	// RVA: 0x1718310 Offset: 0x1716910 VA: 0x181718310
	public ControllerMap_Editor GetKeyboardMapById(int id, out int keyboardMapIndex) { }

	// RVA: 0x1712820 Offset: 0x1710E20 VA: 0x181712820
	public KeyboardMap FindKeyboardMap_Game(Keyboard keyboard, int categoryId, int layoutId) { }

	// RVA: 0x171B830 Offset: 0x1719E30 VA: 0x18171B830
	public bool HasKeyboardMapInCategory(int categoryId) { }

	// RVA: 0x171B8E0 Offset: 0x1719EE0 VA: 0x18171B8E0
	public bool HasKeyboardMapInLayout(int categoryId, int layoutId) { }

	// RVA: 0x1719E80 Offset: 0x1718480 VA: 0x181719E80
	public ControllerMap_Editor GetMouseMap(int categoryId, int layoutId) { }

	// RVA: 0x1719D80 Offset: 0x1718380 VA: 0x181719D80
	public int GetMouseMapId(int categoryId, int layoutId) { }

	// RVA: 0x171BCB0 Offset: 0x171A2B0 VA: 0x18171BCB0
	public bool HasMouseMap(int categoryId, Guid hardwareGuid, int layoutId) { }

	// RVA: 0x170D3C0 Offset: 0x170B9C0 VA: 0x18170D3C0
	public bool CreateMouseMap(int categoryId, int layoutId) { }

	// RVA: 0x170F640 Offset: 0x170DC40 VA: 0x18170F640
	public void DeleteMouseMap(int id) { }

	// RVA: 0x1711B80 Offset: 0x1710180 VA: 0x181711B80
	public int DuplicateMouseMap(int index) { }

	// RVA: 0x1719CB0 Offset: 0x17182B0 VA: 0x181719CB0
	public ControllerMap_Editor GetMouseMapById(int id, out int mouseMapIndex) { }

	// RVA: 0x1712980 Offset: 0x1710F80 VA: 0x181712980
	public MouseMap FindMouseMap_Game(Mouse mouse, int categoryId, int layoutId) { }

	// RVA: 0x171BB30 Offset: 0x171A130 VA: 0x18171BB30
	public bool HasMouseMapInCategory(int categoryId) { }

	// RVA: 0x171BBE0 Offset: 0x171A1E0 VA: 0x18171BBE0
	public bool HasMouseMapInLayout(int categoryId, int layoutId) { }

	// RVA: 0x17164E0 Offset: 0x1714AE0 VA: 0x1817164E0
	public ControllerMap_Editor GetCustomControllerMap(int categoryId, int controllerUid, int layoutId) { }

	// RVA: 0x17161E0 Offset: 0x17147E0 VA: 0x1817161E0
	public ControllerMap_Editor GetCustomControllerMapById(int mapId, out int customControllerMapIndex) { }

	// RVA: 0x1716620 Offset: 0x1714C20 VA: 0x181716620
	public List<ControllerMap_Editor> GetCustomControllerMaps(int controllerUid) { }

	// RVA: 0x1716390 Offset: 0x1714990 VA: 0x181716390
	public int GetCustomControllerMapId(int categoryId, int controllerUid, int layoutId) { }

	// RVA: 0x171B320 Offset: 0x1719920 VA: 0x18171B320
	public bool HasCustomControllerMap(int mapId, int categoryId, int layoutId) { }

	// RVA: 0x171B260 Offset: 0x1719860 VA: 0x18171B260
	public bool HasCustomControllerMap(int mapId) { }

	// RVA: 0x171B180 Offset: 0x1719780 VA: 0x18171B180
	public bool HasCustomControllerMapInCategory(int controllerUid, int categoryId) { }

	// RVA: 0x170CF60 Offset: 0x170B560 VA: 0x18170CF60
	public bool CreateCustomControllerMap(int categoryId, int controllerUid, int layoutId) { }

	// RVA: 0x170E290 Offset: 0x170C890 VA: 0x18170E290
	public void DeleteCustomControllerMap(int mapId) { }

	// RVA: 0x1710770 Offset: 0x170ED70 VA: 0x181710770
	public int DuplicateCustomControllerMap(int index) { }

	// RVA: 0x1711E80 Offset: 0x1710480 VA: 0x181711E80
	internal CustomControllerMap DxGMMsSzZcMiEuneWGYrmiQWFAGg(Guid , int , int ) { }

	// RVA: 0x171EAE0 Offset: 0x171D0E0 VA: 0x18171EAE0
	internal CustomControllerMap OWzjYmYVaFhNpTKUuFDUGgRAMKv(int , int , int ) { }

	// RVA: 0x171E3A0 Offset: 0x171C9A0 VA: 0x18171E3A0
	private CustomControllerMap ItzAHOadgbjhBIPGOPzUJXcwHvgP(CustomController_Editor , int , int ) { }

	// RVA: 0x17205E0 Offset: 0x171EBE0 VA: 0x1817205E0
	private ControllerMap_Editor fJtJOptrwvhxdjuqQFgoCVkwNEcf(int , int , int , bool ) { }

	// RVA: 0x171E660 Offset: 0x171CC60 VA: 0x18171E660
	private ControllerMap_Editor LEYWrrUCgfaIsCgFUzrbeVYzZQoEA(int , int , int ) { }

	// RVA: 0x170DC60 Offset: 0x170C260 VA: 0x18170DC60
	public void DeleteControllerMap(ControllerType controllerType, int id) { }

	// RVA: 0x17143B0 Offset: 0x17129B0 VA: 0x1817143B0
	public ControllerMap_Editor GetControllerMapByIndex(ControllerType controllerType, int index) { }

	// RVA: 0x17140B0 Offset: 0x17126B0 VA: 0x1817140B0
	public ControllerMap_Editor GetControllerMapById(ControllerType controllerType, int id, out int controllerMapIndex) { }

	// RVA: 0x1710450 Offset: 0x170EA50 VA: 0x181710450
	public int DuplicateControllerMap(ControllerType controllerType, int index) { }

	// RVA: 0x171F470 Offset: 0x171DA70 VA: 0x18171F470
	internal ControllerTemplateMap TPjmFSJUsHBjvOPjmAugUVTuKHaN(Guid , int , int ) { }

	[Obsolete("Does not validate type guid on creation to avoid clashes with other controllers. Use overload with typeGuid argument.", True)]
	// RVA: 0x170BCC0 Offset: 0x170A2C0 VA: 0x18170BCC0
	public void AddCustomController() { }

	// RVA: 0x170BE00 Offset: 0x170A400 VA: 0x18170BE00
	public void AddCustomController(Guid typeGuid) { }

	[Obsolete("Does not validate type guid on creation to avoid clashes with other controllers. Use overload with typeGuid argument.", True)]
	// RVA: 0x171DC10 Offset: 0x171C210 VA: 0x18171DC10
	public void InsertCustomController(int index) { }

	// RVA: 0x171DAC0 Offset: 0x171C0C0 VA: 0x18171DAC0
	public void InsertCustomController(int index, Guid typeGuid) { }

	// RVA: 0x170E350 Offset: 0x170C950 VA: 0x18170E350
	public void DeleteCustomController(int index) { }

	// RVA: 0x171EEC0 Offset: 0x171D4C0 VA: 0x18171EEC0
	public bool ReorderCustomController(int index, bool offsetDown, bool offsetNow) { }

	[Obsolete("Does not validate type guid on creation to avoid clashes with other controllers. Use overload with typeGuid argument.", True)]
	// RVA: 0x17108A0 Offset: 0x170EEA0 VA: 0x1817108A0
	public void DuplicateCustomController(int index, bool duplicateMaps) { }

	// RVA: 0x1710900 Offset: 0x170EF00 VA: 0x181710900
	public void DuplicateCustomController(int index, bool duplicateMaps, Guid typeGuid) { }

	// RVA: 0x17162C0 Offset: 0x17148C0 VA: 0x1817162C0
	public int GetCustomControllerMapCount(int controllerUid) { }

	// RVA: 0x1715A50 Offset: 0x1714050 VA: 0x181715A50
	public int GetCustomControllerIndex(int id) { }

	// RVA: 0x1716850 Offset: 0x1714E50 VA: 0x181716850
	public string[] GetCustomControllerNames() { }

	// RVA: 0x1715950 Offset: 0x1713F50 VA: 0x181715950
	public int[] GetCustomControllerIds() { }

	// RVA: 0x1715760 Offset: 0x1713D60 VA: 0x181715760
	public Guid[] GetCustomControllerGuids() { }

	// RVA: 0x1716950 Offset: 0x1714F50 VA: 0x181716950
	public CustomController_Editor GetCustomController(int index) { }

	// RVA: 0x17169D0 Offset: 0x1714FD0 VA: 0x1817169D0
	public CustomController_Editor GetCustomController(string name) { }

	// RVA: 0x1715660 Offset: 0x1713C60 VA: 0x181715660
	public CustomController_Editor GetCustomControllerById(int id) { }

	// RVA: 0x17154E0 Offset: 0x1713AE0 VA: 0x1817154E0
	public CustomController_Editor GetCustomControllerByHardwareTypeGuid(Guid hardwareTypeGuid) { }

	// RVA: 0x17158C0 Offset: 0x1713EC0 VA: 0x1817158C0
	public int GetCustomControllerId(string name) { }

	// RVA: 0x171CC40 Offset: 0x171B240 VA: 0x18171CC40
	public int IndexOfCustomController(int id) { }

	// RVA: 0x171CD00 Offset: 0x171B300 VA: 0x18171CD00
	public int IndexOfCustomController(string name) { }

	// RVA: 0x171CB00 Offset: 0x171B100 VA: 0x18171CB00
	public int IndexOfCustomController(Guid hardwareTypeGuid) { }

	// RVA: 0x1716760 Offset: 0x1714D60 VA: 0x181716760
	public string GetCustomControllerNameById(int id) { }

	// RVA: 0x170BB40 Offset: 0x170A140 VA: 0x18170BB40
	public void AddControllerMapLayoutManagerRuleSet() { }

	// RVA: 0x171D920 Offset: 0x171BF20 VA: 0x18171D920
	public void InsertControllerMapLayoutManagerRuleSet(int index) { }

	// RVA: 0x170DA30 Offset: 0x170C030 VA: 0x18170DA30
	public void DeleteControllerMapLayoutManagerRuleSet(int index) { }

	// RVA: 0x171EDD0 Offset: 0x171D3D0 VA: 0x18171EDD0
	public bool ReorderControllerMapLayoutManagerRuleSet(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1710280 Offset: 0x170E880 VA: 0x181710280
	public void DuplicateControllerMapLayoutManagerRuleSet(int index) { }

	// RVA: 0x1715290 Offset: 0x1713890 VA: 0x181715290
	public int GetControllerMapLayoutManagerRuleSetUsedCount(int id) { }

	// RVA: 0x1714FD0 Offset: 0x17135D0 VA: 0x181714FD0
	public int GetControllerMapLayoutManagerRuleSetIndex(int id) { }

	// RVA: 0x1715190 Offset: 0x1713790 VA: 0x181715190
	public string[] GetControllerMapLayoutManagerRuleSetNames() { }

	// RVA: 0x1714ED0 Offset: 0x17134D0 VA: 0x181714ED0
	public int[] GetControllerMapLayoutManagerRuleSetIds() { }

	// RVA: 0x17153E0 Offset: 0x17139E0 VA: 0x1817153E0
	public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSet(int index) { }

	// RVA: 0x1715460 Offset: 0x1713A60 VA: 0x181715460
	public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSet(string name) { }

	// RVA: 0x1714CF0 Offset: 0x17132F0 VA: 0x181714CF0
	public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSetById(int id) { }

	// RVA: 0x1714E40 Offset: 0x1713440 VA: 0x181714E40
	public int GetControllerMapLayoutManagerRuleSetId(string name) { }

	// RVA: 0x171C890 Offset: 0x171AE90 VA: 0x18171C890
	public int IndexOfControllerMapLayoutManagerRuleSet(int id) { }

	// RVA: 0x171C790 Offset: 0x171AD90 VA: 0x18171C790
	public int IndexOfControllerMapLayoutManagerRuleSet(string name) { }

	// RVA: 0x17150A0 Offset: 0x17136A0 VA: 0x1817150A0
	public string GetControllerMapLayoutManagerRuleSetNameById(int id) { }

	// RVA: 0x1714DF0 Offset: 0x17133F0 VA: 0x181714DF0
	public int GetControllerMapLayoutManagerRuleSetCount() { }

	// RVA: 0x170BA80 Offset: 0x170A080 VA: 0x18170BA80
	public void AddControllerMapEnablerRuleSet() { }

	// RVA: 0x171D850 Offset: 0x171BE50 VA: 0x18171D850
	public void InsertControllerMapEnablerRuleSet(int index) { }

	// RVA: 0x170D800 Offset: 0x170BE00 VA: 0x18170D800
	public void DeleteControllerMapEnablerRuleSet(int index) { }

	// RVA: 0x171ED50 Offset: 0x171D350 VA: 0x18171ED50
	public bool ReorderControllerMapEnablerRuleSet(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x17100B0 Offset: 0x170E6B0 VA: 0x1817100B0
	public void DuplicateControllerMapEnablerRuleSet(int index) { }

	// RVA: 0x1714AA0 Offset: 0x17130A0 VA: 0x181714AA0
	public int GetControllerMapEnablerRuleSetUsedCount(int id) { }

	// RVA: 0x17147E0 Offset: 0x1712DE0 VA: 0x1817147E0
	public int GetControllerMapEnablerRuleSetIndex(int id) { }

	// RVA: 0x17149A0 Offset: 0x1712FA0 VA: 0x1817149A0
	public string[] GetControllerMapEnablerRuleSetNames() { }

	// RVA: 0x17146E0 Offset: 0x1712CE0 VA: 0x1817146E0
	public int[] GetControllerMapEnablerRuleSetIds() { }

	// RVA: 0x1714C70 Offset: 0x1713270 VA: 0x181714C70
	public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSet(int index) { }

	// RVA: 0x1714BF0 Offset: 0x17131F0 VA: 0x181714BF0
	public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSet(string name) { }

	// RVA: 0x1714500 Offset: 0x1712B00 VA: 0x181714500
	public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSetById(int id) { }

	// RVA: 0x1714650 Offset: 0x1712C50 VA: 0x181714650
	public int GetControllerMapEnablerRuleSetId(string name) { }

	// RVA: 0x171C6D0 Offset: 0x171ACD0 VA: 0x18171C6D0
	public int IndexOfControllerMapEnablerRuleSet(int id) { }

	// RVA: 0x171C5D0 Offset: 0x171ABD0 VA: 0x18171C5D0
	public int IndexOfControllerMapEnablerRuleSet(string name) { }

	// RVA: 0x17148B0 Offset: 0x1712EB0 VA: 0x1817148B0
	public string GetControllerMapEnablerRuleSetNameById(int id) { }

	// RVA: 0x1714600 Offset: 0x1712C00 VA: 0x181714600
	public int GetControllerMapEnablerRuleSetCount() { }

	// RVA: 0x171A1B0 Offset: 0x17187B0 VA: 0x18171A1B0
	public int GetNewPlayerId() { }

	// RVA: 0x171A0D0 Offset: 0x17186D0 VA: 0x18171A0D0
	public int GetNewActionId() { }

	// RVA: 0x171A0C0 Offset: 0x17186C0 VA: 0x18171A0C0
	public int GetNewActionCategoryId() { }

	// RVA: 0x171A130 Offset: 0x1718730 VA: 0x18171A130
	public int GetNewInputBehaviorId() { }

	// RVA: 0x171A180 Offset: 0x1718780 VA: 0x18171A180
	public int GetNewMapCategoryId() { }

	// RVA: 0x171A140 Offset: 0x1718740 VA: 0x18171A140
	public int GetNewJoystickLayoutId() { }

	// RVA: 0x171A160 Offset: 0x1718760 VA: 0x18171A160
	public int GetNewKeyboardLayoutId() { }

	// RVA: 0x171A190 Offset: 0x1718790 VA: 0x18171A190
	public int GetNewMouseLayoutId() { }

	// RVA: 0x171A110 Offset: 0x1718710 VA: 0x18171A110
	public int GetNewCustomControllerLayoutId() { }

	// RVA: 0x171A150 Offset: 0x1718750 VA: 0x18171A150
	public int GetNewJoystickMapId() { }

	// RVA: 0x171A170 Offset: 0x1718770 VA: 0x18171A170
	public int GetNewKeyboardMapId() { }

	// RVA: 0x171A1A0 Offset: 0x17187A0 VA: 0x18171A1A0
	public int GetNewMouseMapId() { }

	// RVA: 0x171A120 Offset: 0x1718720 VA: 0x18171A120
	public int GetNewCustomControllerMapId() { }

	// RVA: 0x171A100 Offset: 0x1718700 VA: 0x18171A100
	public int GetNewCustomControllerId() { }

	// RVA: 0x171A0F0 Offset: 0x17186F0 VA: 0x18171A0F0
	public int GetNewControllerMapLayoutManagerRuleSetId() { }

	// RVA: 0x171A0E0 Offset: 0x17186E0 VA: 0x18171A0E0
	public int GetNewControllerMapEnablerRuleSetId() { }

	// RVA: 0x171FEF0 Offset: 0x171E4F0 VA: 0x18171FEF0
	private Player_Editor aTfqrcfjvliLEtqTAzpUcGYQhitF() { }

	// RVA: 0x170C3B0 Offset: 0x170A9B0 VA: 0x18170C3B0
	private InputAction BBUTTKrlOBIqnYWRFMYiEPcMpoVr() { }

	// RVA: 0x171E9F0 Offset: 0x171CFF0 VA: 0x18171E9F0
	private InputActionCategory MYySWZhZbNmoJlpZrhmZpMIaxwuP() { }

	// RVA: 0x1721130 Offset: 0x171F730 VA: 0x181721130
	private InputBehavior pNbdEKYjnGqRqOWDdvEBDYQxRsAW() { }

	// RVA: 0x17218B0 Offset: 0x171FEB0 VA: 0x1817218B0
	private InputMapCategory szjopLpBmqqAfleDYApEgHjlQHJGA() { }

	// RVA: 0x17120D0 Offset: 0x17106D0 VA: 0x1817120D0
	private InputLayout EtWNEHMaFCjbSftfyozqtTOWHjoL() { }

	// RVA: 0x171E880 Offset: 0x171CE80 VA: 0x18171E880
	private InputLayout LsCLYwARMNwNgmCPlJScDiJPgvFt() { }

	// RVA: 0x1720460 Offset: 0x171EA60 VA: 0x181720460
	private InputLayout dbKdYBLSiDrdctDwQtAKPYnGNtOt() { }

	// RVA: 0x17202E0 Offset: 0x171E8E0 VA: 0x1817202E0
	private InputLayout beJMyoirrCAUgBimIrGNVgQyUHtC() { }

	// RVA: 0x1720DF0 Offset: 0x171F3F0 VA: 0x181720DF0
	private CustomController_Editor odAchwdSSgbZvVtsFiDVMupqozYAb(Guid ) { }

	// RVA: 0x171F4B0 Offset: 0x171DAB0 VA: 0x18171F4B0
	private ControllerMapLayoutManager_RuleSet_Editor XjwyEPXtAalcFfFNwDCKBVFNSIlS() { }

	// RVA: 0x171F580 Offset: 0x171DB80 VA: 0x18171F580
	private ControllerMapEnabler_RuleSet_Editor YdKZNVYDKYrYqMnQSdwAVcKBKZxe() { }

	// RVA: 0x1720FE0 Offset: 0x171F5E0 VA: 0x181720FE0
	private ControllerMap_Editor oosshuNDSnoCtFdEufApwHVCfUWiA(List<ControllerMap_Editor> , int , int ) { }

	// RVA: 0x17219A0 Offset: 0x171FFA0 VA: 0x1817219A0
	private ControllerMap_Editor tQrvOWaBulpmcuNXBoqAzmBGAjqc(List<ControllerMap_Editor> , List<InputLayout> , int , int , bool ) { }

	// RVA: 0x170CE30 Offset: 0x170B430 VA: 0x18170CE30
	private ControllerMap_Editor CqgEKJBvjgAkRTfGBGPYIUrZseFW(List<ControllerMap_Editor> , List<InputLayout> , int , int ) { }

	// RVA: 0x1720200 Offset: 0x171E800 VA: 0x181720200
	private void ayaqjpkalZYpXgaOGjEHBWOfTCuEA(List<ControllerMap_Editor> , List<InputLayout> ) { }

	// RVA: 0x1721B60 Offset: 0x1720160 VA: 0x181721B60
	internal void uSgcczrOKlBMyDAfjaEhFMYxshxu() { }

	// RVA: 0x171BE30 Offset: 0x171A430 VA: 0x18171BE30
	internal void HqnDUZfEoOAGrVHnUjWQjwnZvPYY() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x171EAD0 Offset: 0x171D0D0 VA: 0x18171EAD0
	internal static UserData Merge(UserData orig, UserData other, bool preserveOrigIds) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x170CE00 Offset: 0x170B400 VA: 0x18170CE00
	internal static UserData Compact(UserData orig) { }
}

// Namespace: Rewired.Data
[RequireComponent(typeof(InputManager_Base))]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
public abstract class UserDataStore : MonoBehaviour, IUserDataStore, IControllerMapStore // TypeDefIndex: 2385
{
	// Methods

	// RVA: 0x1732490 Offset: 0x1730A90 VA: 0x181732490
	private void OnDestroy() { }

	// RVA: 0x1732360 Offset: 0x1730960 VA: 0x181732360
	internal void Initialize() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Load();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void LoadControllerData(ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void LoadPlayerData(int playerId);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void LoadInputBehavior(int playerId, int behaviorId);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Save();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void SaveControllerData(ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void SavePlayerData(int playerId);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void SaveInputBehavior(int playerId, int behaviorId);

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 26
	public virtual void SaveControllerMap(int playerId, ControllerMap controllerMap) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 27
	public virtual ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract void OnInitialize();

	// RVA: -1 Offset: -1 Slot: 29
	protected abstract void OnControllerConnected(ControllerStatusChangedEventArgs args);

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract void OnControllerDisconnected(ControllerStatusChangedEventArgs args);

	[Obsolete("This method is deprecated and will be removed in a future version. Use OnControllerPreDisconnect instead.", False)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 31
	protected virtual void OnControllerPreDiscconnect(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x1732470 Offset: 0x1730A70 VA: 0x181732470 Slot: 32
	protected virtual void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

// Namespace: Rewired.Data
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IConfigVars_Internal // TypeDefIndex: 2386
{
	// Properties
	public abstract KeyedGetSetValueStore<string> values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract KeyedGetSetValueStore<string> get_values();
}

// Namespace: Rewired.Data
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[Serializable]
internal sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier, IControllerTemplateElementIdentifier_Editor, IControllerTemplateElementIdentifier, IControllerElementIdentifierCommon_Internal // TypeDefIndex: 2387
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _scriptingName; // 0x88
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _alternateScriptingName; // 0x90
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _excludeFromExport; // 0x98
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _useEditorElementTypeOverride; // 0x99
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ControllerElementType _editorElementTypeOverride; // 0x9C

	// Properties
	internal string scriptingName { get; set; }
	internal string alternateScriptingName { get; set; }
	internal bool excludeFromExport { get; }
	internal override bool useEditorElementTypeOverride { get; }
	internal override ControllerElementType editorElementTypeOverride { get; }
	internal ControllerTemplateElementType effectiveElementType { get; }
	private string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.scriptingName { get; }
	private string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.alternateScriptingName { get; }

	// Methods

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0
	internal string get_scriptingName() { }

	// RVA: 0x4EC6E0 Offset: 0x4EACE0 VA: 0x1804EC6E0
	internal void set_scriptingName(string value) { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	internal string get_alternateScriptingName() { }

	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	internal void set_alternateScriptingName(string value) { }

	// RVA: 0x3A35D0 Offset: 0x3A1BD0 VA: 0x1803A35D0
	internal bool get_excludeFromExport() { }

	// RVA: 0x1725200 Offset: 0x1723800 VA: 0x181725200 Slot: 54
	internal override bool get_useEditorElementTypeOverride() { }

	// RVA: 0x17251D0 Offset: 0x17237D0 VA: 0x1817251D0 Slot: 55
	internal override ControllerElementType get_editorElementTypeOverride() { }

	// RVA: 0x17251E0 Offset: 0x17237E0 VA: 0x1817251E0
	internal ControllerTemplateElementType get_effectiveElementType() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x1725140 Offset: 0x1723740 VA: 0x181725140
	public void .ctor(ControllerTemplateElementIdentifier_Editor ) { }

	// RVA: 0x4EC6D0 Offset: 0x4EACD0 VA: 0x1804EC6D0 Slot: 57
	private string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.get_scriptingName() { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80 Slot: 58
	private string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.get_alternateScriptingName() { }

	// RVA: 0x1725080 Offset: 0x1723680 VA: 0x181725080 Slot: 56
	public override ControllerTemplateElementIdentifier Clone() { }
}

// Namespace: Rewired.Data
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class ControllerMapEnabler_RuleSet_Editor // TypeDefIndex: 2388
{
	// Fields
	[Serialize]
	[SerializeField]
	private int _id; // 0x10
	[Serialize]
	[SerializeField]
	private string _name; // 0x18
	[Serialize]
	[SerializeField]
	private string _tag; // 0x20
	[Serialize]
	[SerializeField]
	private List<ControllerMapEnabler_Rule_Editor> _rules; // 0x28

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public string tag { get; set; }
	public List<ControllerMapEnabler_Rule_Editor> rules { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_id() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_id(int value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_name() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_name(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_tag() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_tag(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public List<ControllerMapEnabler_Rule_Editor> get_rules() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_rules(List<ControllerMapEnabler_Rule_Editor> value) { }

	// RVA: 0x1723C90 Offset: 0x1722290 VA: 0x181723C90
	public void .ctor() { }

	// RVA: 0x1723B90 Offset: 0x1722190 VA: 0x181723B90
	public void .ctor(ControllerMapEnabler_RuleSet_Editor ) { }

	// RVA: 0x1723900 Offset: 0x1721F00 VA: 0x181723900
	internal ControllerMapEnabler_RuleSet_Editor Clone() { }

	// RVA: 0x1723A30 Offset: 0x1722030 VA: 0x181723A30
	internal ControllerMapEnabler.RuleSet ToRuntime() { }
}

// Namespace: Rewired.Data
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class ControllerMapEnabler_Rule_Editor : IDeepCloneable // TypeDefIndex: 2389
{
	// Fields
	[Serialize]
	[SerializeField]
	private string _tag; // 0x10
	[Serialize]
	[SerializeField]
	private bool _enable; // 0x18
	[Serialize]
	[SerializeField]
	private List<int> _categoryIds; // 0x20
	[Serialize]
	[SerializeField]
	private List<int> _layoutIds; // 0x28
	[Serialize]
	[SerializeField]
	private ControllerSetSelector_Editor _controllerSetSelector; // 0x30

	// Properties
	public string tag { get; set; }
	public bool enable { get; set; }
	public List<int> categoryIds { get; set; }
	public List<int> layoutIds { get; set; }
	public ControllerSetSelector_Editor controllerSetSelector { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_tag() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_tag(string value) { }

	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_enable() { }

	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	public void set_enable(bool value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<int> get_categoryIds() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_categoryIds(List<int> value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public List<int> get_layoutIds() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_layoutIds(List<int> value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public ControllerSetSelector_Editor get_controllerSetSelector() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_controllerSetSelector(ControllerSetSelector_Editor value) { }

	// RVA: 0x17240E0 Offset: 0x17226E0 VA: 0x1817240E0
	public void .ctor() { }

	// RVA: 0x1723FA0 Offset: 0x17225A0 VA: 0x181723FA0
	public void .ctor(ControllerMapEnabler_Rule_Editor ) { }

	// RVA: 0x1723E80 Offset: 0x1722480 VA: 0x181723E80
	internal ControllerMapEnabler.Rule ToRuntime() { }

	// RVA: 0x1723D10 Offset: 0x1722310 VA: 0x181723D10 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: Rewired.Data
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class ControllerMapLayoutManager_RuleSet_Editor // TypeDefIndex: 2390
{
	// Fields
	[Serialize]
	[SerializeField]
	private int _id; // 0x10
	[Serialize]
	[SerializeField]
	private string _name; // 0x18
	[Serialize]
	[SerializeField]
	private string _tag; // 0x20
	[Serialize]
	[SerializeField]
	private List<ControllerMapLayoutManager_Rule_Editor> _rules; // 0x28

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public string tag { get; set; }
	public List<ControllerMapLayoutManager_Rule_Editor> rules { get; set; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_id() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_id(int value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_name() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_name(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_tag() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_tag(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public List<ControllerMapLayoutManager_Rule_Editor> get_rules() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_rules(List<ControllerMapLayoutManager_Rule_Editor> value) { }

	// RVA: 0x1724460 Offset: 0x1722A60 VA: 0x181724460
	public void .ctor() { }

	// RVA: 0x17244E0 Offset: 0x1722AE0 VA: 0x1817244E0
	public void .ctor(ControllerMapLayoutManager_RuleSet_Editor ) { }

	// RVA: 0x17241D0 Offset: 0x17227D0 VA: 0x1817241D0
	internal ControllerMapLayoutManager_RuleSet_Editor Clone() { }

	// RVA: 0x1724300 Offset: 0x1722900 VA: 0x181724300
	internal ControllerMapLayoutManager.RuleSet ToRuntime() { }
}

// Namespace: Rewired.Data
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class ControllerMapLayoutManager_Rule_Editor : IDeepCloneable // TypeDefIndex: 2391
{
	// Fields
	[Serialize]
	[SerializeField]
	private string _tag; // 0x10
	[Serialize]
	[SerializeField]
	private List<int> _categoryIds; // 0x18
	[Serialize]
	[SerializeField]
	private int _layoutId; // 0x20
	[Serialize]
	[SerializeField]
	private ControllerSetSelector_Editor _controllerSetSelector; // 0x28

	// Properties
	public string tag { get; set; }
	public List<int> categoryIds { get; set; }
	public int layoutId { get; set; }
	public ControllerSetSelector_Editor controllerSetSelector { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_tag() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_tag(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public List<int> get_categoryIds() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_categoryIds(List<int> value) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_layoutId() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_layoutId(int value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public ControllerSetSelector_Editor get_controllerSetSelector() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_controllerSetSelector(ControllerSetSelector_Editor value) { }

	// RVA: 0x1724940 Offset: 0x1722F40 VA: 0x181724940
	public void .ctor() { }

	// RVA: 0x1724820 Offset: 0x1722E20 VA: 0x181724820
	public void .ctor(ControllerMapLayoutManager_Rule_Editor ) { }

	// RVA: 0x1724730 Offset: 0x1722D30 VA: 0x181724730
	internal ControllerMapLayoutManager.Rule ToRuntime() { }

	// RVA: 0x17245E0 Offset: 0x1722BE0 VA: 0x1817245E0 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: Rewired.Data
[Preserve]
[Serializable]
public sealed class ControllerSetSelector_Editor : IDeepCloneable // TypeDefIndex: 2392
{
	// Fields
	[Serialize]
	[SerializeField]
	private ControllerSetSelector.Type _type; // 0x10
	[Serialize]
	[SerializeField]
	private ControllerType _controllerType; // 0x14
	[Serialize]
	[SerializeField]
	private string _hardwareTypeGuidString; // 0x18
	[Serialize]
	[SerializeField]
	private string _hardwareIdentifier; // 0x20
	[Serialize]
	[SerializeField]
	private string _controllerTemplateTypeGuidString; // 0x28
	[Serialize]
	[SerializeField]
	private string _deviceInstanceGuidString; // 0x30
	[Serialize]
	[SerializeField]
	private int _customControllerSourceId; // 0x38
	[Serialize]
	[SerializeField]
	private int _controllerId; // 0x3C

	// Properties
	public ControllerSetSelector.Type type { get; set; }
	public ControllerType controllerType { get; set; }
	public Guid hardwareTypeGuid { get; set; }
	public string hardwareTypeGuidString { get; set; }
	public string hardwareIdentifier { get; set; }
	public Guid controllerTemplateTypeGuid { get; set; }
	public string controllerTemplateTypeGuidString { get; set; }
	public Guid deviceInstanceGuid { get; set; }
	public string deviceInstanceGuidString { get; set; }
	public int controllerId { get; set; }
	public int customControllerSourceId { get; set; }

	// Methods

	// RVA: 0x1724CD0 Offset: 0x17232D0 VA: 0x181724CD0
	internal void .ctor(ControllerSetSelector.Type ) { }

	// RVA: 0x1724E30 Offset: 0x1723430 VA: 0x181724E30
	public void .ctor() { }

	// RVA: 0x1724D60 Offset: 0x1723360 VA: 0x181724D60
	public void .ctor(ControllerSetSelector_Editor ) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public ControllerSetSelector.Type get_type() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_type(ControllerSetSelector.Type value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public ControllerType get_controllerType() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_controllerType(ControllerType value) { }

	// RVA: 0x1724F90 Offset: 0x1723590 VA: 0x181724F90
	public Guid get_hardwareTypeGuid() { }

	// RVA: 0x1725030 Offset: 0x1723630 VA: 0x181725030
	public void set_hardwareTypeGuid(Guid value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_hardwareTypeGuidString() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_hardwareTypeGuidString(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_hardwareIdentifier() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_hardwareIdentifier(string value) { }

	// RVA: 0x1724EB0 Offset: 0x17234B0 VA: 0x181724EB0
	public Guid get_controllerTemplateTypeGuid() { }

	// RVA: 0x1709E30 Offset: 0x1708430 VA: 0x181709E30
	public void set_controllerTemplateTypeGuid(Guid value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_controllerTemplateTypeGuidString() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_controllerTemplateTypeGuidString(string value) { }

	// RVA: 0x1724F20 Offset: 0x1723520 VA: 0x181724F20
	public Guid get_deviceInstanceGuid() { }

	// RVA: 0x1725000 Offset: 0x1723600 VA: 0x181725000
	public void set_deviceInstanceGuid(Guid value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_deviceInstanceGuidString() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_deviceInstanceGuidString(string value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public int get_controllerId() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	public void set_controllerId(int value) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public int get_customControllerSourceId() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_customControllerSourceId(int value) { }

	// RVA: 0x1724A00 Offset: 0x1723000 VA: 0x181724A00
	internal ControllerSetSelector DldAywTeMqDwxQOlsEMochmlDdKeb() { }

	// RVA: 0x1724BD0 Offset: 0x17231D0 VA: 0x181724BD0 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: Rewired.Data
public class UserDataStore_File : UserDataStore_KeyValue // TypeDefIndex: 5190
{
	// Fields
	private static readonly string thisScriptName; // 0x0
	private const string logPrefix = "Rewired: ";
	private const string defaultExtensionText = ".json";
	private const string defaultExtensionBinary = ".bin";
	private const string defaultFileName = "RewiredSaveData.json";
	[Tooltip("The data file name. Changing this will make saved data already stored with the old file name no longer accessible.")]
	[SerializeField]
	private string _fileName; // 0x58
	[Tooltip("Determines if the file should be stored as binary or text. Changing this will make saved data already stored no longer accessible.")]
	[SerializeField]
	private UserDataStore_File.DataFormat _dataFormat; // 0x60
	private string __directory; // 0x68
	private UserDataStore_File.DataStore _dataStore; // 0x70
	private UserDataStore_File.IDataHandler __dataHandler; // 0x78
	private bool _initialized; // 0x80

	// Properties
	public string directory { get; set; }
	public string fileName { get; set; }
	public UserDataStore_File.DataFormat dataFormat { get; set; }
	protected UserDataStore_File.IDataHandler dataHandler { get; set; }
	protected override UserDataStore_KeyValue.IDataStore dataStore { get; }

	// Methods

	// RVA: 0x384C00 Offset: 0x383200 VA: 0x180384C00
	public string get_directory() { }

	// RVA: 0x384CF0 Offset: 0x3832F0 VA: 0x180384CF0
	public void set_directory(string value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public string get_fileName() { }

	// RVA: 0x384D30 Offset: 0x383330 VA: 0x180384D30
	public void set_fileName(string value) { }

	// RVA: 0x3848A0 Offset: 0x382EA0 VA: 0x1803848A0
	public UserDataStore_File.DataFormat get_dataFormat() { }

	// RVA: 0x384C90 Offset: 0x383290 VA: 0x180384C90
	public void set_dataFormat(UserDataStore_File.DataFormat value) { }

	// RVA: 0x384A30 Offset: 0x383030 VA: 0x180384A30
	protected UserDataStore_File.IDataHandler get_dataHandler() { }

	// RVA: 0x384CB0 Offset: 0x3832B0 VA: 0x180384CB0
	protected void set_dataHandler(UserDataStore_File.IDataHandler value) { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0 Slot: 33
	protected override UserDataStore_KeyValue.IDataStore get_dataStore() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 35
	protected virtual void SetInitialValues() { }

	// RVA: 0x3847E0 Offset: 0x382DE0 VA: 0x1803847E0 Slot: 28
	protected override void OnInitialize() { }

	// RVA: 0x3844A0 Offset: 0x382AA0 VA: 0x1803844A0
	private void OnDataSourceChanged() { }

	// RVA: 0x384960 Offset: 0x382F60 VA: 0x180384960
	public void .ctor() { }

	// RVA: 0x3848B0 Offset: 0x382EB0 VA: 0x1803848B0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x3848A0 Offset: 0x382EA0 VA: 0x1803848A0
	private UserDataStore_File.DataFormat <get_dataHandler>b__17_0() { }
}

// Namespace: Rewired.Data
public abstract class UserDataStore_KeyValue : UserDataStore // TypeDefIndex: 5203
{
	// Fields
	private static readonly string thisScriptName; // 0x0
	private const string logPrefix = "Rewired: ";
	private const string key_controllerAssignments = "ControllerAssignments";
	private const int controllerMapKeyVersion = 0;
	private const int controllerElementByRoleMapKeyVersion = 0;
	[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
	[SerializeField]
	private bool _isEnabled; // 0x20
	[Tooltip("Should saved data be loaded on start?")]
	[SerializeField]
	private bool _loadDataOnStart; // 0x21
	[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
	[SerializeField]
	private bool _loadJoystickAssignments; // 0x22
	[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
	[SerializeField]
	private bool _loadKeyboardAssignments; // 0x23
	[Tooltip("Should Player Mouse assignments be saved and loaded?")]
	[SerializeField]
	private bool _loadMouseAssignments; // 0x24
	[Tooltip("How should Action mapping data be saved?

By Controller: Data is stored per-controller. Action mappings apply only to the specific controller for which it was saved.

By Controller Element Role: Data is stored per-element on the controller if the controller element has a known role. Action mappings are mirrored on controller elements with the same role on all other controllers for the Player. Example: When saving Action mappings for a gamepad, element on all gamepads that have the same roles will inherit the mappings. This allows you to remap once for all compatible gamepads simultaneously, for example. This can extend beyond just gamepads, however. For example: On a console platform, a racing wheel with A, B, X, Y, D-Pad etc. elements will also reflect the same Action mappings if the gamepad is remapped. Action mappings for any controller elements that do not have known roles will be saved per-controller. Warning: Do not use this mode if you need to allow a Player to save different mappings for multiple controllers of the same type such as gamepads. (This option currently works best for gamepads and only miminally for other controller types.)")]
	[SerializeField]
	private UserDataStore_KeyValue.ActionMappingSaveMode _actionMappingSaveMode; // 0x28
	private bool _allowImpreciseJoystickAssignmentMatching; // 0x2C
	private bool _deferredJoystickAssignmentLoadPending; // 0x2D
	private bool _wasJoystickEverDetected; // 0x2E
	private List<int> __allActionIds; // 0x30
	private string __allActionIdsString; // 0x38
	private readonly StringBuilder _sb; // 0x40
	private Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> _tempElementByRoleMaps; // 0x48
	private Dictionary<string, bool> _tempElementByRoleMapsEnabled; // 0x50

	// Properties
	public bool isEnabled { get; set; }
	public bool loadDataOnStart { get; set; }
	public bool loadJoystickAssignments { get; set; }
	public bool loadKeyboardAssignments { get; set; }
	public bool loadMouseAssignments { get; set; }
	public UserDataStore_KeyValue.ActionMappingSaveMode actionMappingSaveMode { get; set; }
	protected abstract UserDataStore_KeyValue.IDataStore dataStore { get; }
	private bool loadControllerAssignments { get; }
	private List<int> allActionIds { get; }
	private string allActionIdsString { get; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_isEnabled() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_isEnabled(bool value) { }

	// RVA: 0x38E1B0 Offset: 0x38C7B0 VA: 0x18038E1B0
	public bool get_loadDataOnStart() { }

	// RVA: 0x38E210 Offset: 0x38C810 VA: 0x18038E210
	public void set_loadDataOnStart(bool value) { }

	// RVA: 0x38E1C0 Offset: 0x38C7C0 VA: 0x18038E1C0
	public bool get_loadJoystickAssignments() { }

	// RVA: 0x38E220 Offset: 0x38C820 VA: 0x18038E220
	public void set_loadJoystickAssignments(bool value) { }

	// RVA: 0x38E1D0 Offset: 0x38C7D0 VA: 0x18038E1D0
	public bool get_loadKeyboardAssignments() { }

	// RVA: 0x38E230 Offset: 0x38C830 VA: 0x18038E230
	public void set_loadKeyboardAssignments(bool value) { }

	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	public bool get_loadMouseAssignments() { }

	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	public void set_loadMouseAssignments(bool value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public UserDataStore_KeyValue.ActionMappingSaveMode get_actionMappingSaveMode() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_actionMappingSaveMode(UserDataStore_KeyValue.ActionMappingSaveMode value) { }

	// RVA: -1 Offset: -1 Slot: 33
	protected abstract UserDataStore_KeyValue.IDataStore get_dataStore();

	// RVA: 0x38E190 Offset: 0x38C790 VA: 0x18038E190
	private bool get_loadControllerAssignments() { }

	// RVA: 0x38DED0 Offset: 0x38C4D0 VA: 0x18038DED0
	private List<int> get_allActionIds() { }

	// RVA: 0x38DD70 Offset: 0x38C370 VA: 0x18038DD70
	private string get_allActionIdsString() { }

	// RVA: 0x38D670 Offset: 0x38BC70 VA: 0x18038D670 Slot: 21
	public override void Save() { }

	// RVA: 0x38B630 Offset: 0x389C30 VA: 0x18038B630 Slot: 22
	public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x38B530 Offset: 0x389B30 VA: 0x18038B530 Slot: 23
	public override void SaveControllerData(ControllerType controllerType, int controllerId) { }

	// RVA: 0x38D4E0 Offset: 0x38BAE0 VA: 0x18038D4E0 Slot: 24
	public override void SavePlayerData(int playerId) { }

	// RVA: 0x38CAB0 Offset: 0x38B0B0 VA: 0x18038CAB0 Slot: 25
	public override void SaveInputBehavior(int playerId, int behaviorId) { }

	// RVA: 0x38A430 Offset: 0x388A30 VA: 0x18038A430 Slot: 16
	public override void Load() { }

	// RVA: 0x3870B0 Offset: 0x3856B0 VA: 0x1803870B0 Slot: 17
	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x386FB0 Offset: 0x3855B0 VA: 0x180386FB0 Slot: 18
	public override void LoadControllerData(ControllerType controllerType, int controllerId) { }

	// RVA: 0x38A300 Offset: 0x388900 VA: 0x18038A300 Slot: 19
	public override void LoadPlayerData(int playerId) { }

	// RVA: 0x388530 Offset: 0x386B30 VA: 0x180388530 Slot: 20
	public override void LoadInputBehavior(int playerId, int behaviorId) { }

	// RVA: 0x38A840 Offset: 0x388E40 VA: 0x18038A840 Slot: 28
	protected override void OnInitialize() { }

	// RVA: 0x38A510 Offset: 0x388B10 VA: 0x18038A510 Slot: 29
	protected override void OnControllerConnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x38A810 Offset: 0x388E10 VA: 0x18038A810 Slot: 32
	protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x38A5F0 Offset: 0x388BF0 VA: 0x18038A5F0 Slot: 30
	protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x38C270 Offset: 0x38A870 VA: 0x18038C270 Slot: 26
	public override void SaveControllerMap(int playerId, ControllerMap controllerMap) { }

	// RVA: 0x387620 Offset: 0x385C20 VA: 0x180387620 Slot: 27
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x3858E0 Offset: 0x383EE0 VA: 0x1803858E0 Slot: 34
	public virtual void ClearSaveData() { }

	// RVA: 0x386B90 Offset: 0x385190 VA: 0x180386B90
	private int LoadAll() { }

	// RVA: 0x389FD0 Offset: 0x3885D0 VA: 0x180389FD0
	private int LoadPlayerDataNow(int playerId) { }

	// RVA: 0x38A050 Offset: 0x388650 VA: 0x18038A050
	private int LoadPlayerDataNow(Player player) { }

	// RVA: 0x386900 Offset: 0x384F00 VA: 0x180386900
	private int LoadAllJoystickCalibrationData() { }

	// RVA: 0x3897E0 Offset: 0x387DE0 VA: 0x1803897E0
	private int LoadJoystickCalibrationData(Joystick joystick) { }

	// RVA: 0x3898B0 Offset: 0x387EB0 VA: 0x1803898B0
	private int LoadJoystickCalibrationData(int joystickId) { }

	// RVA: 0x389930 Offset: 0x387F30 VA: 0x180389930
	private int LoadJoystickData(int joystickId) { }

	// RVA: 0x386F30 Offset: 0x385530 VA: 0x180386F30
	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x386F10 Offset: 0x385510 VA: 0x180386F10
	private int LoadControllerDataNow(ControllerType controllerType, int controllerId) { }

	// RVA: 0x3876F0 Offset: 0x385CF0 VA: 0x1803876F0
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x387420 Offset: 0x385A20 VA: 0x180387420
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x3871D0 Offset: 0x3857D0 VA: 0x1803871D0
	private bool LoadControllerElementMapByRole(Player player, Controller controller, string role, int mapCategoryId, int layoutId, Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> elementByRoleMaps) { }

	// RVA: 0x3886C0 Offset: 0x386CC0 VA: 0x1803886C0
	private int LoadInputBehaviors(int playerId) { }

	// RVA: 0x388450 Offset: 0x386A50 VA: 0x180388450
	private int LoadInputBehaviorNow(int playerId, int behaviorId) { }

	// RVA: 0x388330 Offset: 0x386930 VA: 0x180388330
	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) { }

	// RVA: 0x386EA0 Offset: 0x3854A0 VA: 0x180386EA0
	private bool LoadControllerAssignmentsNow() { }

	// RVA: 0x389C50 Offset: 0x388250 VA: 0x180389C50
	private bool LoadKeyboardAndMouseAssignmentsNow(UserDataStore_KeyValue.ControllerAssignmentSaveInfo data) { }

	// RVA: 0x388970 Offset: 0x386F70 VA: 0x180388970
	private bool LoadJoystickAssignmentsNow(UserDataStore_KeyValue.ControllerAssignmentSaveInfo data) { }

	// RVA: 0x386D90 Offset: 0x385390 VA: 0x180386D90
	private UserDataStore_KeyValue.ControllerAssignmentSaveInfo LoadControllerAssignmentData() { }

	[IteratorStateMachine(typeof(UserDataStore_KeyValue.<LoadJoystickAssignmentsDeferred>d__81))]
	// RVA: 0x388900 Offset: 0x386F00 VA: 0x180388900
	private IEnumerator LoadJoystickAssignmentsDeferred() { }

	// RVA: 0x38ABF0 Offset: 0x3891F0 VA: 0x18038ABF0
	private void SaveAll() { }

	// RVA: 0x38D260 Offset: 0x38B860 VA: 0x18038D260
	private void SavePlayerDataNow(int playerId) { }

	// RVA: 0x38D330 Offset: 0x38B930 VA: 0x18038D330
	private void SavePlayerDataNow(Player player) { }

	// RVA: 0x38A970 Offset: 0x388F70 VA: 0x18038A970
	private void SaveAllJoystickCalibrationData() { }

	// RVA: 0x38CE10 Offset: 0x38B410 VA: 0x18038CE10
	private void SaveJoystickCalibrationData(int joystickId) { }

	// RVA: 0x38CE90 Offset: 0x38B490 VA: 0x18038CE90
	private void SaveJoystickCalibrationData(Joystick joystick) { }

	// RVA: 0x38CF60 Offset: 0x38B560 VA: 0x18038CF60
	private void SaveJoystickData(int joystickId) { }

	// RVA: 0x38B4C0 Offset: 0x389AC0 VA: 0x18038B4C0
	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x38B510 Offset: 0x389B10 VA: 0x18038B510
	private void SaveControllerDataNow(ControllerType controllerType, int controllerId) { }

	// RVA: 0x38C680 Offset: 0x38AC80 VA: 0x18038C680
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData) { }

	// RVA: 0x38C400 Offset: 0x38AA00 VA: 0x18038C400
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x38C340 Offset: 0x38A940 VA: 0x18038C340
	private void SaveControllerMap(Player player, ControllerMap controllerMap) { }

	// RVA: 0x38BF30 Offset: 0x38A530 VA: 0x18038BF30
	private void SaveControllerMapByController(Player player, ControllerMap controllerMap) { }

	// RVA: 0x38B750 Offset: 0x389D50 VA: 0x18038B750
	private void SaveControllerMapByControllerElementRole(Player player, Controller controller, ControllerMap controllerMap) { }

	// RVA: 0x384D70 Offset: 0x383370 VA: 0x180384D70
	private bool AddControllerElementByRoleMapEntry(Player player, Controller controller, ActionElementMap elementMap, ref Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> maps) { }

	// RVA: 0x38CD00 Offset: 0x38B300 VA: 0x18038CD00
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData) { }

	// RVA: 0x38C870 Offset: 0x38AE70 VA: 0x18038C870
	private void SaveInputBehaviorNow(int playerId, int behaviorId) { }

	// RVA: 0x38C9F0 Offset: 0x38AFF0 VA: 0x18038C9F0
	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior) { }

	// RVA: 0x38AF40 Offset: 0x389540 VA: 0x18038AF40
	private bool SaveControllerAssignments() { }

	// RVA: 0x385870 Offset: 0x383E70 VA: 0x180385870
	private static void AppendPlayerKey(StringBuilder sb, Player player) { }

	// RVA: 0x385C00 Offset: 0x384200 VA: 0x180385C00
	private string GetControllerMapKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x385D90 Offset: 0x384390 VA: 0x180385D90
	private string GetControllerMapKnownActionIdsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x3855F0 Offset: 0x383BF0 VA: 0x1803855F0
	private static void AppendControllerMapKeyCommonSuffix(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int keyVersion) { }

	// RVA: 0x3854D0 Offset: 0x383AD0 VA: 0x1803854D0
	private static void AppendControllerElementByRoleMapKey(StringBuilder sb, string elementRole, int categoryId, int layoutId, int keyVersion) { }

	// RVA: 0x386760 Offset: 0x384D60 VA: 0x180386760
	private string GetJoystickCalibrationMapKey(Joystick joystick) { }

	// RVA: 0x386560 Offset: 0x384B60 VA: 0x180386560
	private string GetInputBehaviorKey(Player player, int inputBehaviorId) { }

	// RVA: 0x385AD0 Offset: 0x3840D0 VA: 0x180385AD0
	private string GetControllerMapJson(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x385F20 Offset: 0x384520 VA: 0x180385F20
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x3866C0 Offset: 0x384CC0 VA: 0x1803866C0
	private string GetJoystickCalibrationMapJson(Joystick joystick) { }

	// RVA: 0x3864B0 Offset: 0x384AB0 VA: 0x1803864B0
	private string GetInputBehaviorJson(Player player, int id) { }

	// RVA: 0x384FD0 Offset: 0x3835D0 VA: 0x180384FD0
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds) { }

	// RVA: 0x385940 Offset: 0x383F40 VA: 0x180385940
	private Joystick FindJoystickPrecise(UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) { }

	// RVA: 0x38D810 Offset: 0x38BE10 VA: 0x18038D810
	private bool TryFindJoysticksImprecise(UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches) { }

	// RVA: 0x38A8E0 Offset: 0x388EE0 VA: 0x18038A8E0
	private void RefreshLayoutManager(int playerId) { }

	// RVA: 0x38A610 Offset: 0x388C10 VA: 0x18038A610
	private void OnControllerMapsSaved(Player player) { }

	// RVA: 0x386120 Offset: 0x384720 VA: 0x180386120
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) { }

	// RVA: 0x38DAD0 Offset: 0x38C0D0 VA: 0x18038DAD0
	private static bool TryGetString(UserDataStore_KeyValue.IDataStore store, string key, out string result) { }

	// RVA: 0x38D750 Offset: 0x38BD50 VA: 0x18038D750
	private static int SortOldestToNewest(ControllerMapSaveData a, ControllerMapSaveData b) { }

	// RVA: 0x38DCE0 Offset: 0x38C2E0 VA: 0x18038DCE0
	protected void .ctor() { }

	// RVA: 0x38DC30 Offset: 0x38C230 VA: 0x18038DC30
	private static void .cctor() { }
}

// Namespace: Rewired.Data
public class UserDataStore_PlayerPrefs : UserDataStore // TypeDefIndex: 5215
{
	// Fields
	private const string thisScriptName = "UserDataStore_PlayerPrefs";
	private const string logPrefix = "Rewired: ";
	private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";
	private const int controllerMapPPKeyVersion_original = 0;
	private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;
	private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;
	private const int controllerMapPPKeyVersion_includeFormatVersion = 2;
	private const int controllerMapPPKeyVersion = 2;
	private const int controllerElementByRoleMapPPKeyVersion = 0;
	[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
	[SerializeField]
	private bool isEnabled; // 0x20
	[Tooltip("Should saved data be loaded on start?")]
	[SerializeField]
	private bool loadDataOnStart; // 0x21
	[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
	[SerializeField]
	private bool loadJoystickAssignments; // 0x22
	[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
	[SerializeField]
	private bool loadKeyboardAssignments; // 0x23
	[Tooltip("Should Player Mouse assignments be saved and loaded?")]
	[SerializeField]
	private bool loadMouseAssignments; // 0x24
	[Tooltip("How should Action mapping data be saved?

By Controller: Data is stored per-controller. Action mappings apply only to the specific controller for which it was saved.

By Controller Element Role: Data is stored per-element on the controller if the controller element has a known role. Action mappings are mirrored on controller elements with the same role on all other controllers for the Player. Example: When saving Action mappings for a gamepad, element on all gamepads that have the same roles will inherit the mappings. This allows you to remap once for all compatible gamepads simultaneously, for example. This can extend beyond just gamepads, however. For example: On a console platform, a racing wheel with A, B, X, Y, D-Pad etc. elements will also reflect the same Action mappings if the gamepad is remapped. Action mappings for any controller elements that do not have known roles will be saved per-controller. Warning: Do not use this mode if you need to allow a Player to save different mappings for multiple controllers of the same type such as gamepads. (This option currently works best for gamepads and only miminally for other controller types.)")]
	[SerializeField]
	private UserDataStore_PlayerPrefs.ActionMappingSaveMode _actionMappingSaveMode; // 0x28
	[Tooltip("The PlayerPrefs key prefix. Change this to change how keys are stored in PlayerPrefs. Changing this will make saved data already stored with the old key no longer accessible.")]
	[SerializeField]
	private string playerPrefsKeyPrefix; // 0x30
	private bool allowImpreciseJoystickAssignmentMatching; // 0x38
	private bool deferredJoystickAssignmentLoadPending; // 0x39
	private bool wasJoystickEverDetected; // 0x3A
	private List<int> __allActionIds; // 0x40
	private string __allActionIdsString; // 0x48
	private readonly StringBuilder _sb; // 0x50
	private Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> _tempElementByRoleMaps; // 0x58
	private Dictionary<string, bool> _tempElementByRoleMapsEnabled; // 0x60

	// Properties
	public bool IsEnabled { get; set; }
	public bool LoadDataOnStart { get; set; }
	public bool LoadJoystickAssignments { get; set; }
	public bool LoadKeyboardAssignments { get; set; }
	public bool LoadMouseAssignments { get; set; }
	public UserDataStore_PlayerPrefs.ActionMappingSaveMode actionMappingSaveMode { get; set; }
	public string PlayerPrefsKeyPrefix { get; set; }
	private string playerPrefsKey_controllerAssignments { get; }
	private bool loadControllerAssignments { get; }
	private List<int> allActionIds { get; }
	private string allActionIdsString { get; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_IsEnabled() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_IsEnabled(bool value) { }

	// RVA: 0x38E1B0 Offset: 0x38C7B0 VA: 0x18038E1B0
	public bool get_LoadDataOnStart() { }

	// RVA: 0x38E210 Offset: 0x38C810 VA: 0x18038E210
	public void set_LoadDataOnStart(bool value) { }

	// RVA: 0x38E1C0 Offset: 0x38C7C0 VA: 0x18038E1C0
	public bool get_LoadJoystickAssignments() { }

	// RVA: 0x38E220 Offset: 0x38C820 VA: 0x18038E220
	public void set_LoadJoystickAssignments(bool value) { }

	// RVA: 0x38E1D0 Offset: 0x38C7D0 VA: 0x18038E1D0
	public bool get_LoadKeyboardAssignments() { }

	// RVA: 0x38E230 Offset: 0x38C830 VA: 0x18038E230
	public void set_LoadKeyboardAssignments(bool value) { }

	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	public bool get_LoadMouseAssignments() { }

	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	public void set_LoadMouseAssignments(bool value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public UserDataStore_PlayerPrefs.ActionMappingSaveMode get_actionMappingSaveMode() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_actionMappingSaveMode(UserDataStore_PlayerPrefs.ActionMappingSaveMode value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_PlayerPrefsKeyPrefix() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_PlayerPrefsKeyPrefix(string value) { }

	// RVA: 0x3971C0 Offset: 0x3957C0 VA: 0x1803971C0
	private string get_playerPrefsKey_controllerAssignments() { }

	// RVA: 0x38E190 Offset: 0x38C790 VA: 0x18038E190
	private bool get_loadControllerAssignments() { }

	// RVA: 0x396F10 Offset: 0x395510 VA: 0x180396F10
	private List<int> get_allActionIds() { }

	// RVA: 0x396DB0 Offset: 0x3953B0 VA: 0x180396DB0
	private string get_allActionIdsString() { }

	// RVA: 0x3969C0 Offset: 0x394FC0 VA: 0x1803969C0 Slot: 21
	public override void Save() { }

	// RVA: 0x394F30 Offset: 0x393530 VA: 0x180394F30 Slot: 22
	public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x395000 Offset: 0x393600 VA: 0x180395000 Slot: 23
	public override void SaveControllerData(ControllerType controllerType, int controllerId) { }

	// RVA: 0x3968D0 Offset: 0x394ED0 VA: 0x1803968D0 Slot: 24
	public override void SavePlayerData(int playerId) { }

	// RVA: 0x396160 Offset: 0x394760 VA: 0x180396160 Slot: 25
	public override void SaveInputBehavior(int playerId, int behaviorId) { }

	// RVA: 0x393F10 Offset: 0x392510 VA: 0x180393F10 Slot: 16
	public override void Load() { }

	// RVA: 0x390C30 Offset: 0x38F230 VA: 0x180390C30 Slot: 17
	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x390B90 Offset: 0x38F190 VA: 0x180390B90 Slot: 18
	public override void LoadControllerData(ControllerType controllerType, int controllerId) { }

	// RVA: 0x393E30 Offset: 0x392430 VA: 0x180393E30 Slot: 19
	public override void LoadPlayerData(int playerId) { }

	// RVA: 0x392060 Offset: 0x390660 VA: 0x180392060 Slot: 20
	public override void LoadInputBehavior(int playerId, int behaviorId) { }

	// RVA: 0x3942C0 Offset: 0x3928C0 VA: 0x1803942C0 Slot: 28
	protected override void OnInitialize() { }

	// RVA: 0x393F90 Offset: 0x392590 VA: 0x180393F90 Slot: 29
	protected override void OnControllerConnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x394290 Offset: 0x392890 VA: 0x180394290 Slot: 32
	protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x394070 Offset: 0x392670 VA: 0x180394070 Slot: 30
	protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args) { }

	// RVA: 0x395B00 Offset: 0x394100 VA: 0x180395B00 Slot: 26
	public override void SaveControllerMap(int playerId, ControllerMap controllerMap) { }

	// RVA: 0x390E70 Offset: 0x38F470 VA: 0x180390E70 Slot: 27
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x390740 Offset: 0x38ED40 VA: 0x180390740
	private int LoadAll() { }

	// RVA: 0x393DB0 Offset: 0x3923B0 VA: 0x180393DB0
	private int LoadPlayerDataNow(int playerId) { }

	// RVA: 0x393B00 Offset: 0x392100 VA: 0x180393B00
	private int LoadPlayerDataNow(Player player) { }

	// RVA: 0x390500 Offset: 0x38EB00 VA: 0x180390500
	private int LoadAllJoystickCalibrationData() { }

	// RVA: 0x3934B0 Offset: 0x391AB0 VA: 0x1803934B0
	private int LoadJoystickCalibrationData(Joystick joystick) { }

	// RVA: 0x3933D0 Offset: 0x3919D0 VA: 0x1803933D0
	private int LoadJoystickCalibrationData(int joystickId) { }

	// RVA: 0x393530 Offset: 0x391B30 VA: 0x180393530
	private int LoadJoystickData(int joystickId) { }

	// RVA: 0x390AF0 Offset: 0x38F0F0 VA: 0x180390AF0
	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x390B70 Offset: 0x38F170 VA: 0x180390B70
	private int LoadControllerDataNow(ControllerType controllerType, int controllerId) { }

	// RVA: 0x391210 Offset: 0x38F810 VA: 0x180391210
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x390F40 Offset: 0x38F540 VA: 0x180390F40
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x390D00 Offset: 0x38F300 VA: 0x180390D00
	private bool LoadControllerElementMapByRole(Player player, Controller controller, string role, int mapCategoryId, int layoutId, Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> elementByRoleMaps) { }

	// RVA: 0x392210 Offset: 0x390810 VA: 0x180392210
	private int LoadInputBehaviors(int playerId) { }

	// RVA: 0x391E50 Offset: 0x390450 VA: 0x180391E50
	private int LoadInputBehaviorNow(int playerId, int behaviorId) { }

	// RVA: 0x391FB0 Offset: 0x3905B0 VA: 0x180391FB0
	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) { }

	// RVA: 0x390A80 Offset: 0x38F080 VA: 0x180390A80
	private bool LoadControllerAssignmentsNow() { }

	// RVA: 0x393780 Offset: 0x391D80 VA: 0x180393780
	private bool LoadKeyboardAndMouseAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data) { }

	// RVA: 0x392560 Offset: 0x390B60 VA: 0x180392560
	private bool LoadJoystickAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data) { }

	// RVA: 0x390940 Offset: 0x38EF40 VA: 0x180390940
	private UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData() { }

	[IteratorStateMachine(typeof(UserDataStore_PlayerPrefs.<LoadJoystickAssignmentsDeferred>d__88))]
	// RVA: 0x3924F0 Offset: 0x390AF0 VA: 0x1803924F0
	private IEnumerator LoadJoystickAssignmentsDeferred() { }

	// RVA: 0x394620 Offset: 0x392C20 VA: 0x180394620
	private void SaveAll() { }

	// RVA: 0x396840 Offset: 0x394E40 VA: 0x180396840
	private void SavePlayerDataNow(int playerId) { }

	// RVA: 0x3966F0 Offset: 0x394CF0 VA: 0x1803966F0
	private void SavePlayerDataNow(Player player) { }

	// RVA: 0x3943F0 Offset: 0x3929F0 VA: 0x1803943F0
	private void SaveAllJoystickCalibrationData() { }

	// RVA: 0x396380 Offset: 0x394980 VA: 0x180396380
	private void SaveJoystickCalibrationData(int joystickId) { }

	// RVA: 0x396440 Offset: 0x394A40 VA: 0x180396440
	private void SaveJoystickCalibrationData(Joystick joystick) { }

	// RVA: 0x3964C0 Offset: 0x394AC0 VA: 0x1803964C0
	private void SaveJoystickData(int joystickId) { }

	// RVA: 0x394EA0 Offset: 0x3934A0 VA: 0x180394EA0
	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x394F00 Offset: 0x393500 VA: 0x180394F00
	private void SaveControllerDataNow(ControllerType controllerType, int controllerId) { }

	// RVA: 0x395E20 Offset: 0x394420 VA: 0x180395E20
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData) { }

	// RVA: 0x395BA0 Offset: 0x3941A0 VA: 0x180395BA0
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x395A40 Offset: 0x394040 VA: 0x180395A40
	private void SaveControllerMap(Player player, ControllerMap controllerMap) { }

	// RVA: 0x395780 Offset: 0x393D80 VA: 0x180395780
	private void SaveControllerMapByController(Player player, ControllerMap controllerMap) { }

	// RVA: 0x3950B0 Offset: 0x3936B0 VA: 0x1803950B0
	private void SaveControllerMapByControllerElementRole(Player player, Controller controller, ControllerMap controllerMap) { }

	// RVA: 0x38E250 Offset: 0x38C850 VA: 0x18038E250
	private bool AddControllerElementByRoleMapEntry(Player player, Controller controller, ActionElementMap elementMap, ref Dictionary<string, UserDataStore_PlayerPrefs.ControllerElementByRoleMap> maps) { }

	// RVA: 0x3962D0 Offset: 0x3948D0 VA: 0x1803962D0
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData) { }

	// RVA: 0x396060 Offset: 0x394660 VA: 0x180396060
	private void SaveInputBehaviorNow(int playerId, int behaviorId) { }

	// RVA: 0x396010 Offset: 0x394610 VA: 0x180396010
	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior) { }

	// RVA: 0x394950 Offset: 0x392F50 VA: 0x180394950
	private bool SaveControllerAssignments() { }

	// RVA: 0x38F2D0 Offset: 0x38D8D0 VA: 0x18038F2D0
	private bool ControllerAssignmentSaveDataExists() { }

	// RVA: 0x38FA50 Offset: 0x38E050 VA: 0x18038FA50
	private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x38F530 Offset: 0x38DB30 VA: 0x18038F530
	private string GetControllerElementByRoleMapPlayerPrefsKey(Player player, string elementRole, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x3902F0 Offset: 0x38E8F0 VA: 0x1803902F0
	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick) { }

	// RVA: 0x38F710 Offset: 0x38DD10 VA: 0x18038F710
	private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x390150 Offset: 0x38E750 VA: 0x180390150
	private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId) { }

	// RVA: 0x38E9D0 Offset: 0x38CFD0 VA: 0x18038E9D0
	private static void AppendBaseKey(StringBuilder sb, string playerPrefsKeyPrefix) { }

	// RVA: 0x38F260 Offset: 0x38D860 VA: 0x18038F260
	private static void AppendPlayerKey(StringBuilder sb, Player player) { }

	// RVA: 0x38EF00 Offset: 0x38D500 VA: 0x18038EF00
	private static void AppendControllerMapKey(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x38EFC0 Offset: 0x38D5C0 VA: 0x18038EFC0
	private static void AppendControllerMapKnownActionIdsKey(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x38EB10 Offset: 0x38D110 VA: 0x18038EB10
	private static void AppendControllerMapKeyCommonSuffix(StringBuilder sb, Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x38E9F0 Offset: 0x38CFF0 VA: 0x18038E9F0
	private static void AppendControllerElementByRoleMapKey(StringBuilder sb, string elementRole, int categoryId, int layoutId, int ppKeyVersion) { }

	// RVA: 0x38F100 Offset: 0x38D700 VA: 0x18038F100
	private static void AppendJoystickCalibrationMapKey(StringBuilder sb, Joystick joystick) { }

	// RVA: 0x38F080 Offset: 0x38D680 VA: 0x18038F080
	private static void AppendInputBehaviorKey(StringBuilder sb, int inputBehaviorId) { }

	// RVA: 0x38FD00 Offset: 0x38E300 VA: 0x18038FD00
	private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x38F890 Offset: 0x38DE90 VA: 0x18038F890
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	// RVA: 0x3904B0 Offset: 0x38EAB0 VA: 0x1803904B0
	private string GetJoystickCalibrationMapXml(Joystick joystick) { }

	// RVA: 0x3902A0 Offset: 0x38E8A0 VA: 0x1803902A0
	private string GetInputBehaviorXml(Player player, int id) { }

	// RVA: 0x38E4B0 Offset: 0x38CAB0 VA: 0x18038E4B0
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds) { }

	// RVA: 0x38F3A0 Offset: 0x38D9A0 VA: 0x18038F3A0
	private Joystick FindJoystickPrecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo) { }

	// RVA: 0x396A40 Offset: 0x395040 VA: 0x180396A40
	private bool TryFindJoysticksImprecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches) { }

	// RVA: 0x38FDC0 Offset: 0x38E3C0 VA: 0x18038FDC0
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) { }

	// RVA: 0x394360 Offset: 0x392960 VA: 0x180394360
	private void RefreshLayoutManager(int playerId) { }

	// RVA: 0x394090 Offset: 0x392690 VA: 0x180394090
	private void OnControllerMapsSaved(Player player) { }

	// RVA: 0x38FBD0 Offset: 0x38E1D0 VA: 0x18038FBD0
	private static Type GetControllerMapType(ControllerType controllerType) { }

	// RVA: 0x38D750 Offset: 0x38BD50 VA: 0x18038D750
	private static int SortOldestToNewest(ControllerMapSaveData a, ControllerMapSaveData b) { }

	// RVA: 0x396D00 Offset: 0x395300 VA: 0x180396D00
	public void .ctor() { }
}

