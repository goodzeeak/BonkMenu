// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface INativePlatformHelper // TypeDefIndex: 2202
{
	// Properties
	public abstract bool isApplicationFocused { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isApplicationFocused();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IInputManagerJoystick : IInputManagerJoystickPublic // TypeDefIndex: 2203
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void FillData(ControllerDataUpdater dataUpdater);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract BridgedController ToBridgedController();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IInputManagerJoystickPublic // TypeDefIndex: 2204
{
	// Properties
	public abstract int rewiredId { get; }
	public abstract int inputManagerId { get; }
	public abstract string name { get; }
	public abstract Nullable<long> systemId { get; }
	public abstract int unityId { get; }
	public abstract Controller.Extension extension { get; }
	public abstract Guid instanceGuid { get; }
	public abstract Guid persistentGuid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_rewiredId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_inputManagerId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Nullable<long> get_systemId();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_unityId();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Controller.Extension get_extension();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Guid get_instanceGuid();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Guid get_persistentGuid();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetVibration(float amount, int motorIndex);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void StopVibration();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IInputSource : IDisposable // TypeDefIndex: 2205
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_DeviceChangedEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_DeviceChangedEvent(Action value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SystemDeviceConnected();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SystemDeviceDisconnected();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void UpdateDevices(UpdateLoopType updateLoop);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UpdateFinished();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IList<TJoy> GetJoysticks<TJoy>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IInputSource.GetJoysticks<object>
	*/
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IElementIdentifierTool // TypeDefIndex: 2206
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize(GUIText guiText);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Start();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnDestroy();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IGetSetEnabled // TypeDefIndex: 2207
{
	// Properties
	public abstract bool enabled { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_enabled(bool value);
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IUnifiedMouseSource // TypeDefIndex: 2208
{
	// Properties
	public abstract InputSource inputSource { get; }
	public abstract HardwareControllerMap_Game hardwareMap { get; }
	public abstract int axisCount { get; }
	public abstract int buttonCount { get; }
	public abstract Vector2 mousePosition { get; }
	public abstract Controller.Extension controllerExtension { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract InputSource get_inputSource();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract HardwareControllerMap_Game get_hardwareMap();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_axisCount();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_buttonCount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Vector2 get_mousePosition();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Controller.Extension get_controllerExtension();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UpdateInputData(ControllerDataUpdater dataUpdater);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Clear();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IUnifiedKeyboardSource // TypeDefIndex: 2209
{
	// Properties
	public abstract InputSource inputSource { get; }
	public abstract HardwareControllerMap_Game hardwareMap { get; }
	public abstract int buttonCount { get; }
	public abstract Controller.Extension controllerExtension { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract InputSource get_inputSource();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract HardwareControllerMap_Game get_hardwareMap();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_buttonCount();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Controller.Extension get_controllerExtension();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void UpdateInputData(ControllerDataUpdater dataUpdater);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Clear();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
public interface IControllerExtensionSource // TypeDefIndex: 2210
{}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerElementIdentifierCommon_Internal // TypeDefIndex: 2211
{
	// Properties
	public abstract int id { get; }
	public abstract string name { get; }
	public abstract string positiveName { get; }
	public abstract string negativeName { get; }
	public abstract string nonLocalizedName { get; }
	public abstract string nonLocalizedPositiveName { get; }
	public abstract string nonLocalizedNegativeName { get; }
	public abstract string key { get; }
	public abstract string positiveKey { get; }
	public abstract string negativeKey { get; }
	public abstract bool isNonLocalizedPositiveNameAutoGenerated { get; }
	public abstract bool isNonLocalizedNegativeNameAutoGenerated { get; }
	public abstract bool isPositiveKeyAutoGenerated { get; }
	public abstract bool isNegativeKeyAutoGenerated { get; }
	public abstract DeviceLocalizationInfo deviceLocalizationInfo { get; }
	public abstract object elementType { get; }
	public abstract bool useEditorElementTypeOverride { get; }
	public abstract ControllerElementType editorElementTypeOverride { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_id();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_positiveName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_negativeName();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_nonLocalizedName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_nonLocalizedPositiveName();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_nonLocalizedNegativeName();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string GetSpecialElementNonLocalizedName(int index);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_key();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_positiveKey();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_negativeKey();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string GetSpecialElementKey(int index);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_isNonLocalizedPositiveNameAutoGenerated();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_isNonLocalizedNegativeNameAutoGenerated();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_isPositiveKeyAutoGenerated();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_isNegativeKeyAutoGenerated();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract DeviceLocalizationInfo get_deviceLocalizationInfo();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract object get_elementType();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_useEditorElementTypeOverride();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract ControllerElementType get_editorElementTypeOverride();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal // TypeDefIndex: 2212
{
	// Properties
	public abstract ControllerTemplateElementType elementType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ControllerTemplateElementType get_elementType();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerTemplateElementIdentifier_Editor : IControllerTemplateElementIdentifier, IControllerElementIdentifierCommon_Internal // TypeDefIndex: 2213
{
	// Properties
	public abstract string scriptingName { get; }
	public abstract string alternateScriptingName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_scriptingName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_alternateScriptingName();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
public interface IControllerVibrator // TypeDefIndex: 2214
{
	// Properties
	public abstract int vibrationMotorCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_vibrationMotorCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetVibration(int motorIndex, float motorLevel);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetVibration(int motorIndex, float motorLevel, float duration);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float GetVibration(int motorIndex);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StopVibration();
}

// Namespace: Rewired.Interfaces
public interface IUserDataStore // TypeDefIndex: 2215
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Save();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SaveControllerData(ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SavePlayerData(int playerId);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SaveInputBehavior(int playerId, int behaviorId);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Load();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LoadControllerData(ControllerType controllerType, int controllerId);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void LoadPlayerData(int playerId);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void LoadInputBehavior(int playerId, int behaviorId);
}

// Namespace: Rewired.Interfaces
public interface IControllerMapStore // TypeDefIndex: 2216
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SaveControllerMap(int playerId, ControllerMap controllerMap);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId);
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal interface ISteamControllerInternal // TypeDefIndex: 2217
{
	// Properties
	public abstract int MaxActionSourceCount { get; }
	public abstract bool IsConnected { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_MaxActionSourceCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsConnected();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetActionSetName(ulong handle);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetDigitalActionName(ulong handle);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string GetAnalogActionName(ulong handle);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ulong GetActionSetHandle(ref string actionSetName);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ulong GetDigitalActionHandle(ref string actionName);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract ulong GetAnalogActionHandle(ref string actionName);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool GetDigitalActionValue(ulong actionHandle);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool GetDigitalActionValue(ref string actionName);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Vector2 GetAnalogActionValue(ulong actionHandle);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Vector2 GetAnalogActionValue(ref string actionName);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool SetActiveActionSet(ulong actionSetHandle);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool SetActiveActionSet(ref string actionSetName);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract ulong GetActiveActionSetHandle();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string GetActiveActionSetName();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ShowBindingPanel();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SetHapticPulse(SteamControllerPadType targetPad, float durationSeconds);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void SetHapticPulse(SteamControllerPadType targetPad, ushort durationMicroSeconds);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ref string actionSetName, ref string actionName);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ref string actionSetName, ref string actionName);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle);
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal interface IControllerAssigner // TypeDefIndex: 2218
{
	// Properties
	public abstract bool enabled { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_enabled(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool CanHandleAssignment(ControllerType controllerType, Controller controller);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AssignController(ControllerType controllerType, Controller controller);
}

// Namespace: Rewired.Interfaces
public interface IPoolableObject : IDisposable // TypeDefIndex: 2219
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Return();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal interface IAndroidFallbackDS4Helper // TypeDefIndex: 2220
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsDS4KeyMapped(int unityJoystickArrayIndex);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsDS4(string name);
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal interface IAndroidFallbackPlatformHelper // TypeDefIndex: 2221
{
	// Properties
	public abstract IAndroidFallbackDS4Helper ds4Helper { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_DeviceChangedEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_DeviceChangedEvent(Action value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IAndroidFallbackDS4Helper get_ds4Helper();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetUniqueDeviceIdentifier(string unityJoystickName, int unityArrayIndex);
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal interface IAxisCalibrationIndexMap // TypeDefIndex: 2222
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetMappedAxisIndex(int axisIndex);
}

// Namespace: Rewired.Interfaces
public interface ILocalizedStringProvider // TypeDefIndex: 2223
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetLocalizedString(string key, out string result);
}

// Namespace: Rewired.Interfaces
public interface IGlyphProvider // TypeDefIndex: 2224
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetGlyph(string key, out object result);
}

