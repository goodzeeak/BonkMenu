// Namespace: Rewired.Utils.Interfaces
public interface IDeepCloneable // TypeDefIndex: 3041
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object DeepClone();
}

// Namespace: Rewired.Utils.Interfaces
public interface IExternalTools // TypeDefIndex: 3042
{
	// Properties
	public abstract bool isEditorPaused { get; }
	public abstract bool UnityInput_IsTouchPressureSupported { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isEditorPaused();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void add_EditorPausedStateChangedEvent(Action<bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void remove_EditorPausedStateChangedEvent(Action<bool> value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Destroy();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetPlatformInitializer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string GetFocusedEditorWindowTitle();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool IsEditorSceneViewFocused();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool LinuxInput_IsJoystickPreconfigured(string name);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int XboxOneInput_GetUserIdForGamepad(uint id);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract ulong XboxOneInput_GetControllerId(uint unityJoystickId);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void add_XboxOneInput_OnGamepadStateChange(Action<uint, bool> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void remove_XboxOneInput_OnGamepadStateChange(Action<uint, bool> value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool XboxOneInput_IsGamepadActive(uint unityJoystickId);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string XboxOneInput_GetControllerType(ulong xboxControllerId);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract uint XboxOneInput_GetJoystickId(ulong xboxControllerId);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void XboxOne_Gamepad_UpdatePlugin();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motor, float startLevel, float endLevel, ulong durationMS);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetAndroidAPILevel();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool UnityUI_Graphic_GetRaycastTarget(object graphic);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool get_UnityInput_IsTouchPressureSupported();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract float UnityInput_GetTouchPressure(ref Touch touch);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Type[] GetControllerTemplateTypes();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract Type[] GetControllerTemplateInterfaceTypes();
}

// Namespace: Rewired.Utils.Interfaces
public interface IRegistrar<T> // TypeDefIndex: 3043
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Register(T registrant);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IRegistrar<object>.Register
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Deregister(T registrant);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IRegistrar<object>.Deregister
	*/
}

// Namespace: Rewired.Utils.Interfaces
public interface IExternalInputManager // TypeDefIndex: 3044
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Initialize(Platform platform, object configVars);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Deinitialize();
}

// Namespace: Rewired.Utils.Interfaces
public interface IKeyedData<TKey> // TypeDefIndex: 3045
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetValue<T>(TKey key, out T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKeyedData<__Il2CppFullySharedGenericType>.TryGetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TrySetValue<T>(TKey key, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKeyedData<__Il2CppFullySharedGenericType>.TrySetValue<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Rewired.Utils.Interfaces
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IReadOnlyList // TypeDefIndex: 3046
{
	// Properties
	public abstract int Count { get; }
	public abstract object Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int IndexOf(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Contains(object value);
}

// Namespace: Rewired.Utils.Interfaces
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IReadOnlyList<T> : IReadOnlyList // TypeDefIndex: 3047
{
	// Properties
	public abstract T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int IndexOf(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Contains(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<__Il2CppFullySharedGenericType>.Contains
	*/
}

// Namespace: Rewired.Utils.Interfaces
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IReadOnlyDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 3048
{
	// Properties
	public abstract TValue Item { get; }
	public abstract ICollection<TKey> Keys { get; }
	public abstract ICollection<TValue> Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TValue get_Item(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ICollection<TKey> get_Keys();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection<TValue> get_Values();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ContainsKey(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/
}

// Namespace: Rewired.Utils.Interfaces
[DefaultMember("Item")]
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IReadOnlyDictionaryEnumerator<TKey, TValue> // TypeDefIndex: 3049
{
	// Properties
	public abstract TValue Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TValue get_Item(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ContainsKey(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/
}

// Namespace: Rewired.Utils.Interfaces
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IExportToXml // TypeDefIndex: 3050
{
	// Properties
	public abstract bool writesOwnElementTag { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_writesOwnElementTag();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void WriteXml(XmlWriter writer);
}

// Namespace: Rewired.Utils.Interfaces
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IExportToJson // TypeDefIndex: 3051
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void WriteJson(StringBuilder stringBuilder, Action<StringBuilder, object> appendValueDelegate);
}

// Namespace: Rewired.Utils.Interfaces
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IAddValue<TValue> // TypeDefIndex: 3052
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Add(TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAddValue<__Il2CppFullySharedGenericType>.Add
	*/
}

// Namespace: Rewired.Utils.Interfaces
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IAddKeyValue<TKey, TValue> // TypeDefIndex: 3053
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Add(TKey key, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IAddKeyValue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/
}

// Namespace: Rewired.Utils.Interfaces
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IGetValue<T> // TypeDefIndex: 3054
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T GetValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGetValue<__Il2CppFullySharedGenericType>.GetValue
	*/
}

// Namespace: Rewired.Utils.Interfaces
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface ISetValue<T> // TypeDefIndex: 3055
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetValue(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISetValue<__Il2CppFullySharedGenericType>.SetValue
	*/
}

// Namespace: Rewired.Utils.Interfaces
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IGetSetValue<T> : IGetValue<T>, ISetValue<T> // TypeDefIndex: 3056
{}

