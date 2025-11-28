// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal abstract class ControllerTemplateSpecialElementMapping // TypeDefIndex: 2393
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal class ControllerTemplateThumbStickMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 2394
{
	// Fields
	public int eid_axisX; // 0x10
	public int eid_axisY; // 0x14
	public int eid_button; // 0x18

	// Methods

	// RVA: 0x1725260 Offset: 0x1723860 VA: 0x181725260
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal class ControllerTemplateDPadMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 2395
{
	// Fields
	public int eid_up; // 0x10
	public int eid_right; // 0x14
	public int eid_down; // 0x18
	public int eid_left; // 0x1C
	public int eid_press; // 0x20

	// Methods

	// RVA: 0x1725060 Offset: 0x1723660 VA: 0x181725060
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal class ControllerTemplateStickMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 2396
{
	// Fields
	public int eid_axisX; // 0x10
	public int eid_axisY; // 0x14
	public int eid_axisZ; // 0x18

	// Methods

	// RVA: 0x1725260 Offset: 0x1723860 VA: 0x181725260
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal class ControllerTemplateThrottleMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 2397
{
	// Fields
	public int eid_axis; // 0x10
	public int eid_minDetent; // 0x14

	// Methods

	// RVA: 0x1725280 Offset: 0x1723880 VA: 0x181725280
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal class ControllerTemplateHatMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 2398
{
	// Fields
	public int eid_up; // 0x10
	public int eid_upRight; // 0x14
	public int eid_right; // 0x18
	public int eid_downRight; // 0x1C
	public int eid_down; // 0x20
	public int eid_downLeft; // 0x24
	public int eid_left; // 0x28
	public int eid_upLeft; // 0x2C

	// Methods

	// RVA: 0x1725210 Offset: 0x1723810 VA: 0x181725210
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal class ControllerTemplateYokeMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 2399
{
	// Fields
	public int eid_axisX; // 0x10
	public int eid_axisZ; // 0x14

	// Methods

	// RVA: 0x1725280 Offset: 0x1723880 VA: 0x181725280
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Preserve]
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[Serializable]
internal class ControllerTemplateStick6DMapping : ControllerTemplateSpecialElementMapping // TypeDefIndex: 2400
{
	// Fields
	public int eid_positionX; // 0x10
	public int eid_positionY; // 0x14
	public int eid_positionZ; // 0x18
	public int eid_rotationX; // 0x1C
	public int eid_rotationY; // 0x20
	public int eid_rotationZ; // 0x24

	// Methods

	// RVA: 0x1725240 Offset: 0x1723840 VA: 0x181725240
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class ActionCategoryMap // TypeDefIndex: 2404
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<ActionCategoryMap.Entry> list; // 0x10

	// Methods

	[IteratorStateMachine(typeof(ActionCategoryMap.qlOvgOCOuIFMpKtoCMBPnDzNmamY))]
	// RVA: 0x1722A10 Offset: 0x1721010 VA: 0x181722A10
	public IEnumerable<int> ActionIdsInCategory(int categoryId) { }

	// RVA: 0x1723880 Offset: 0x1721E80 VA: 0x181723880
	public void .ctor() { }

	// RVA: 0x17236C0 Offset: 0x1721CC0 VA: 0x1817236C0
	public void .ctor(ActionCategoryMap ) { }

	// RVA: 0x1722B30 Offset: 0x1721130 VA: 0x181722B30
	public void AddCategory(int id) { }

	// RVA: 0x1723320 Offset: 0x1721920 VA: 0x181723320
	public void RemoveCategory(int id) { }

	// RVA: 0x1723560 Offset: 0x1721B60 VA: 0x181723560
	public bool ReorderCategory(int id, bool offsetDown) { }

	// RVA: 0x1722C70 Offset: 0x1721270 VA: 0x181722C70
	public bool ChangeCategory(int actionId, int newCategoryId) { }

	// RVA: 0x1723070 Offset: 0x1721670 VA: 0x181723070
	public int IndexOfCategory(int id) { }

	// RVA: 0x1722A90 Offset: 0x1721090 VA: 0x181722A90
	public bool AddAction(int categoryId, int actionId) { }

	// RVA: 0x1723130 Offset: 0x1721730 VA: 0x181723130
	public bool InsertAction(int categoryId, int actionId, int index) { }

	// RVA: 0x1723390 Offset: 0x1721990 VA: 0x181723390
	public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1723260 Offset: 0x1721860 VA: 0x181723260
	public void RemoveAction(int categoryId, int actionId) { }

	// RVA: 0x1722FD0 Offset: 0x17215D0 VA: 0x181722FD0
	public int IndexOfAction(int categoryId, int actionId) { }

	// RVA: 0x1722DF0 Offset: 0x17213F0 VA: 0x181722DF0
	public ActionCategoryMap Clone() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public abstract class CustomCalculation : SerializedMethod // TypeDefIndex: 2405
{
	// Methods

	// RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	protected void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class CustomCalculation_Accelerometer : CustomCalculation // TypeDefIndex: 2409
{
	// Fields
	public CustomCalculation_Accelerometer.CalculationType _calculationType; // 0x50
	public CustomCalculation_Accelerometer.InputType _inputType; // 0x54
	public CustomCalculation_Accelerometer.OutputType _outputType; // 0x58

	// Properties
	internal override TypeWrapper.DataType ResultType { get; }

	// Methods

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 4
	internal override TypeWrapper.DataType get_ResultType() { }

	// RVA: 0x17254C0 Offset: 0x1723AC0 VA: 0x1817254C0 Slot: 5
	internal override bool kCItxVOzpIcXWAwvIECPsMJQfupZ() { }

	// RVA: 0x17252E0 Offset: 0x17238E0 VA: 0x1817252E0
	private float JQVqxsjqtdooOWuKbFFmQorXNASi() { }

	// RVA: 0x1725560 Offset: 0x1723B60 VA: 0x181725560
	private float nZSJAkSbRQRkuJbcYptJospwdeIp() { }

	// RVA: 0x1725290 Offset: 0x1723890 VA: 0x181725290
	private float EgdEiGCOWcVfmtLdEZLcjkrysORtA(float ) { }

	// RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class CustomCalculation_CompareElementValues : CustomCalculation // TypeDefIndex: 2411
{
	// Fields
	private const TypeWrapper.DataType resultType = 10;
	[SerializeField]
	private CustomCalculation_CompareElementValues.ComparisonType _comparisonType; // 0x50

	// Properties
	internal override TypeWrapper.DataType ResultType { get; }

	// Methods

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 4
	internal override TypeWrapper.DataType get_ResultType() { }

	// RVA: 0x1725750 Offset: 0x1723D50 VA: 0x181725750 Slot: 5
	internal override bool PzFzGLNzBHnBinqYYPYlrNXJAIJX() { }

	// RVA: 0x17257D0 Offset: 0x1723DD0 VA: 0x1817257D0
	private float jivxVXdaolQbPFUGAgVsqIdIpZJQ() { }

	// RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class CustomCalculation_FirstNonZero : CustomCalculation // TypeDefIndex: 2412
{
	// Fields
	private const TypeWrapper.DataType resultType = 10;

	// Properties
	internal override TypeWrapper.DataType ResultType { get; }

	// Methods

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 4
	internal override TypeWrapper.DataType get_ResultType() { }

	// RVA: 0x1725B60 Offset: 0x1724160 VA: 0x181725B60 Slot: 5
	internal override bool shUcyrbhIGPFUTDjrWktPhwRshFb() { }

	// RVA: 0x1725A10 Offset: 0x1724010 VA: 0x181725A10
	private float ZVvVwfzWDFuFPblYXYEWfOVJDEMKA() { }

	// RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class CustomCalculation_LogitechGRacingWheelPedals : CustomCalculation // TypeDefIndex: 2414
{
	// Fields
	private const TypeWrapper.DataType resultType = 10;
	private const float dead = 0.01;
	private CustomCalculation_LogitechGRacingWheelPedals.Mode WIlxHaKHsmEkBkvzuZlMMRglmGWJ; // 0x50

	// Properties
	internal override TypeWrapper.DataType ResultType { get; }

	// Methods

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90 Slot: 4
	internal override TypeWrapper.DataType get_ResultType() { }

	// RVA: 0x1725D00 Offset: 0x1724300 VA: 0x181725D00 Slot: 5
	internal override bool VGVsyxSkSGOVyCelmfXTUsClLLDv() { }

	// RVA: 0x1725D80 Offset: 0x1724380 VA: 0x181725D80
	private float kLOlaIrtCDNyqziNUbWXBBSoxJQf() { }

	// RVA: 0x1726060 Offset: 0x1724660 VA: 0x181726060
	private void yUKUonsehZfkoNSmJfAYFgYnQnWQ(float , float ) { }

	// RVA: 0x3B3D50 Offset: 0x3B2350 VA: 0x1803B3D50
	public void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
public sealed class HardwareJoystickMap : ScriptableObject, IHardwareControllerMap, IHardwareControllerMap_Internal // TypeDefIndex: 2617
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string controllerName; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string editorControllerName; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string description; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string controllerGuid; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string controllerKey; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string[] templateGuids; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool hideInLists; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private JoystickType[] joystickTypes; // 0x50
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ControllerElementIdentifier[] elementIdentifiers; // 0x58
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.CompoundElement[] compoundElements; // 0x60
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_DirectInput directInput; // 0x68
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_RawInput rawInput; // 0x70
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_XInput xInput; // 0x78
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_WindowsWGI windowsWGI; // 0x80
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_OSX osx; // 0x88
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Linux linux; // 0x90
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_WindowsUWP windowsUWP; // 0x98
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_Windows; // 0xA0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_WindowsUWP; // 0xA8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_OSX; // 0xB0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_Linux; // 0xB8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_Linux_PreConfigured; // 0xC0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_Android; // 0xC8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_iOS; // 0xD0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_XBoxOne; // 0xD8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_PS4; // 0xE0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_PS5 ps5; // 0xE8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_PSM; // 0xF0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_PSVita; // 0xF8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_Fallback fallback_AmazonFireTV; // 0x100
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_WebGL webGL; // 0x108
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_XboxOne xboxOne; // 0x110
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_GameCore gameCore; // 0x118
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_PS4 ps4; // 0x120
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_NintendoSwitch nintendoSwitch; // 0x128
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_NintendoSwitch2 nintendoSwitch2; // 0x130
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_InternalDriver internalDriver; // 0x138
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_SDL2 sdl2_Linux; // 0x140
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_SDL2 sdl2_Windows; // 0x148
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_SDL2 sdl2_OSX; // 0x150
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickMap.Platform_AppleGCController appleGCController; // 0x158
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int elementIdentifierIdCounter; // 0x160
	private Nullable<Guid> __runtimeControllerGuidCache; // 0x164
	private Guid[] __runtimeTemplateGuidCache; // 0x178

	// Properties
	private Guid runtimeControllerGuid { get; }
	private Guid[] runtimeTemplateGuids { get; }
	public string ControllerName { get; }
	public string EditorControllerName { get; }
	public Guid Guid { get; }
	public string Key { get; }
	public IEnumerable<Guid> TemplateGuids { get; }
	public IEnumerable<ControllerElementIdentifier> ElementIdentifiers { get; }
	public int elementIdentifierCount { get; }
	public bool HideInLists { get; }
	internal IEnumerable<JoystickType> JoystickTypes { get; }
	private Guid Rewired.Data.Mapping.IHardwareControllerMap_Internal.typeGuid { get; }
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.typeKey { get; }
	private ControllerType Rewired.Data.Mapping.IHardwareControllerMap_Internal.controllerType { get; }
	private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.ElementIdentifiers { get; }

	// Methods

	// RVA: 0x172B300 Offset: 0x1729900 VA: 0x18172B300
	private Guid get_runtimeControllerGuid() { }

	// RVA: 0x172B400 Offset: 0x1729A00 VA: 0x18172B400
	private Guid[] get_runtimeTemplateGuids() { }

	// RVA: 0x172A7B0 Offset: 0x1728DB0 VA: 0x18172A7B0
	public void .ctor() { }

	// RVA: 0x1729AB0 Offset: 0x17280B0 VA: 0x181729AB0
	public void .ctor(HardwareJoystickMap ) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_ControllerName() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_EditorControllerName() { }

	// RVA: 0x172B040 Offset: 0x1729640 VA: 0x18172B040
	public Guid get_Guid() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_Key() { }

	[IteratorStateMachine(typeof(HardwareJoystickMap.WkCPSvYqUvmbACUhVuMDpuBVgrQl))]
	// RVA: 0x172B270 Offset: 0x1729870 VA: 0x18172B270
	public IEnumerable<Guid> get_TemplateGuids() { }

	[IteratorStateMachine(typeof(HardwareJoystickMap.QcBlNQqttFsvVoTsjBEtJAyZbmNh))]
	// RVA: 0x172AFD0 Offset: 0x17295D0 VA: 0x18172AFD0
	public IEnumerable<ControllerElementIdentifier> get_ElementIdentifiers() { }

	// RVA: 0x172B2E0 Offset: 0x17298E0 VA: 0x18172B2E0
	public int get_elementIdentifierCount() { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	public bool get_HideInLists() { }

	[IteratorStateMachine(typeof(HardwareJoystickMap.fWebeGkUSdkyKIpDAYKPQdgyDdJEb))]
	// RVA: 0x172B200 Offset: 0x1729800 VA: 0x18172B200
	internal IEnumerable<JoystickType> get_JoystickTypes() { }

	// RVA: 0x1729A80 Offset: 0x1728080 VA: 0x181729A80 Slot: 9
	private Guid Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_typeGuid() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 10
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_typeKey() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 11
	private ControllerType Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_controllerType() { }

	// RVA: 0x1728FA0 Offset: 0x17275A0 VA: 0x181728FA0
	public int GetTemplateGuids(IList<Guid> results) { }

	// RVA: 0x1726F10 Offset: 0x1725510 VA: 0x181726F10
	public bool ContainsTemplateGuid(Guid guid) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1728540 Offset: 0x1726B40 VA: 0x181728540 Slot: 4
	public string[] GetElementIdentifierNames() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1728230 Offset: 0x1726830 VA: 0x181728230 Slot: 5
	public int[] GetElementIdentifierIds() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1728620 Offset: 0x1726C20 VA: 0x181728620
	public ControllerElementIdentifier GetElementIdentifier(int id) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17281F0 Offset: 0x17267F0 VA: 0x1817281F0
	public ControllerElementIdentifier GetElementIdentifierAtIndex(int index) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1726EB0 Offset: 0x17254B0 VA: 0x181726EB0 Slot: 6
	public bool ContainsElementIdentifier(int id) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17282F0 Offset: 0x17268F0 VA: 0x1817282F0
	public int GetElementIdentifierInfo(ControllerElementType type, out string[] names, out int[] ids) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1728760 Offset: 0x1726D60 VA: 0x181728760 Slot: 7
	public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids) { }

	// RVA: 0x1726E50 Offset: 0x1725450 VA: 0x181726E50
	internal HardwareJoystickMap Clone() { }

	// RVA: 0x1729270 Offset: 0x1727870 VA: 0x181729270
	internal int IndexOfElementIdentifier(int id) { }

	// RVA: 0x1728100 Offset: 0x1726700 VA: 0x181728100
	internal ControllerElementType GetEffectiveElementIdentifierType(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap) { }

	// RVA: 0x1728000 Offset: 0x1726600 VA: 0x181728000
	internal bool GetEffectiveAxisRange(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap, out AxisRange axisRange) { }

	// RVA: 0x1728690 Offset: 0x1726C90 VA: 0x181728690
	internal void GetElementIdentifiersForControllerElements(HardwareControllerMapIdentifier hardwareMapIdentifier, bool isDefaultMap, out int[] buttons, out int[] axes) { }

	// RVA: 0x1729930 Offset: 0x1727F30 VA: 0x181729930
	internal static bool Matches(HardwareJoystickMap.Platform platform, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x17292D0 Offset: 0x17278D0 VA: 0x1817292D0
	internal bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex, out HardwareJoystickMap.Platform platformMap) { }

	// RVA: 0x1727B00 Offset: 0x1726100 VA: 0x181727B00
	internal HardwareJoystickMap_InputManager GetDefaultHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal string[] GetTemplateGuidsOrig() { }

	[IteratorStateMachine(typeof(HardwareJoystickMap.DDsFLFDuJkQwNSNsLSWMscMmOrLwA))]
	// RVA: 0x1729A00 Offset: 0x1728000 VA: 0x181729A00 Slot: 12
	private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_ElementIdentifiers() { }

	// RVA: 0x1729980 Offset: 0x1727F80 VA: 0x181729980 Slot: 13
	private IControllerElementIdentifierCommon_Internal Rewired.Data.Mapping.IHardwareControllerMap_Internal.GetElementIdentifier(int id) { }

	// RVA: 0x1727450 Offset: 0x1725A50 VA: 0x181727450
	private HardwareJoystickMap.Platform_Fallback_Base FindFallbackMatch(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	// RVA: 0x17270E0 Offset: 0x17256E0 VA: 0x1817270E0
	private HardwareJoystickMap.Platform_Fallback_Base FindFallbackMap(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	// RVA: 0x17279B0 Offset: 0x1725FB0 VA: 0x1817279B0
	private HardwareJoystickMap.Platform_SDL2_Base FindSDL2Match(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	// RVA: 0x1727880 Offset: 0x1725E80 VA: 0x181727880
	private HardwareJoystickMap.Platform_SDL2_Base FindSDL2Map(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) { }

	// RVA: -1 Offset: -1
	private T TryGetFirstValidMap<T>(T mainMap, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x705A10 Offset: 0x704010 VA: 0x180705A10
	|-HardwareJoystickMap.TryGetFirstValidMap<object>
	*/

	// RVA: -1 Offset: -1
	private T TryGetFirstMatchingMap<T>(T mainMap, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x705890 Offset: 0x703E90 VA: 0x180705890
	|-HardwareJoystickMap.TryGetFirstMatchingMap<object>
	*/

	// RVA: -1 Offset: -1
	private T GetUniversalDefaultMap<T>(out InputPlatform actualInputPlatform, out int variantIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7055C0 Offset: 0x703BC0 VA: 0x1807055C0
	|-HardwareJoystickMap.GetUniversalDefaultMap<object>
	*/

	// RVA: -1 Offset: -1
	private T GetUniversalDefaultMapRoot<T>(Type type, out InputPlatform actualInputPlatform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x705490 Offset: 0x703A90 VA: 0x180705490
	|-HardwareJoystickMap.GetUniversalDefaultMapRoot<object>
	*/

	// RVA: 0x17289D0 Offset: 0x1726FD0 VA: 0x1817289D0
	private HardwareJoystickMap.Platform GetSpecificPlatformMap(HardwareControllerMapIdentifier hardwareMapIdentifier) { }

	// RVA: 0x1728A20 Offset: 0x1727020 VA: 0x181728A20
	private HardwareJoystickMap.Platform GetSpecificPlatformRoot(InputPlatform exactInputPlatform) { }

	// RVA: 0x1729A70 Offset: 0x1728070 VA: 0x181729A70 Slot: 8
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_name() { }
}

// Namespace: Rewired.Data.Mapping
public abstract class HardwareControllerTemplateMap : ScriptableObject // TypeDefIndex: 2619
{
	// Properties
	public abstract Guid Guid { get; }
	public abstract string Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_Guid();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Key();

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract ControllerTemplateElementIdentifier GetElementIdentifier(int id);

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ContainsElementIdentifier(int id);

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: Rewired.Data.Mapping
public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap, IHardwareControllerTemplateMap, IHardwareControllerTemplateMap_Internal, IHardwareControllerMap, IHardwareControllerMap_Internal // TypeDefIndex: 2625
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string controllerName; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string description; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string templateGuid; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string templateKey; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string className; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ControllerTemplateElementIdentifier_Editor[] elementIdentifiers; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<HardwareJoystickTemplateMap.Entry> joysticks; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private HardwareJoystickTemplateMap.SpecialElementEntry[] specialElements; // 0x50
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int elementIdentifierIdCounter; // 0x58
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int joystickIdCounter; // 0x5C
	private Func<Guid, HardwareJoystickTemplateMap.Entry> LKQjWHhzOOlRIMTrjYTvXIoKMJde; // 0x60

	// Properties
	public override Guid Guid { get; }
	public override string Key { get; }
	public string ControllerName { get; }
	public string ClassName { get; }
	public IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers { get; }
	public int elementIdentifierCount { get; }
	private Guid Rewired.Data.Mapping.IHardwareControllerMap_Internal.typeGuid { get; }
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.typeKey { get; }
	private ControllerType Rewired.Data.Mapping.IHardwareControllerMap_Internal.controllerType { get; }
	private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.ElementIdentifiers { get; }
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.name { get; }
	private Guid Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.typeGuid { get; }
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.typeKey { get; }
	private Func<Guid, HardwareJoystickTemplateMap.Entry> VcwHoykxnUNotVACPZCdvnygCbRf { get; }

	// Methods

	// RVA: 0x176D8A0 Offset: 0x176BEA0 VA: 0x18176D8A0 Slot: 4
	public override Guid get_Guid() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 5
	public override string get_Key() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_ControllerName() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_ClassName() { }

	[IteratorStateMachine(typeof(HardwareJoystickTemplateMap.WrSsvRVkHzxOxJociCztVVbzuuee))]
	// RVA: 0x176D820 Offset: 0x176BE20 VA: 0x18176D820
	public IEnumerable<ControllerTemplateElementIdentifier> get_ElementIdentifiers() { }

	// RVA: 0x176D690 Offset: 0x176BC90 VA: 0x18176D690
	public int get_elementIdentifierCount() { }

	// RVA: 0x176D5C0 Offset: 0x176BBC0 VA: 0x18176D5C0 Slot: 22
	private Guid Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_typeGuid() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 23
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_typeKey() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 24
	private ControllerType Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_controllerType() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x176C6B0 Offset: 0x176ACB0 VA: 0x18176C6B0 Slot: 6
	public override ControllerTemplateElementIdentifier GetElementIdentifier(int id) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x176C3B0 Offset: 0x176A9B0 VA: 0x18176C3B0
	public ControllerTemplateElementIdentifier GetElementIdentifierAtIndex(int index) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x176C350 Offset: 0x176A950 VA: 0x18176C350 Slot: 7
	public override bool ContainsElementIdentifier(int id) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x176C4B0 Offset: 0x176AAB0 VA: 0x18176C4B0 Slot: 17
	public string[] GetElementIdentifierNames() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x176C3F0 Offset: 0x176A9F0 VA: 0x18176C3F0 Slot: 18
	public int[] GetElementIdentifierIds() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x176C590 Offset: 0x176AB90 VA: 0x18176C590
	internal string[] GetElementIdentifierScriptingNames(bool useAlternate) { }

	// RVA: 0x176CC70 Offset: 0x176B270 VA: 0x18176CC70 Slot: 20
	public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids) { }

	// RVA: 0x176CF10 Offset: 0x176B510 VA: 0x18176CF10
	public int GetNonMappableElementIdentifierInfo(out string[] names, out int[] ids) { }

	// RVA: 0x176CB80 Offset: 0x176B180 VA: 0x18176CB80
	public string[] GetJoystickNames() { }

	// RVA: 0x176CAA0 Offset: 0x176B0A0 VA: 0x18176CAA0
	public int[] GetJoystickIds() { }

	// RVA: 0x176C820 Offset: 0x176AE20 VA: 0x18176C820
	public Guid GetJoystickGuid(int joystickId) { }

	// RVA: 0x176C970 Offset: 0x176AF70 VA: 0x18176C970
	public int GetJoystickId(Guid guid) { }

	// RVA: 0x176C720 Offset: 0x176AD20 VA: 0x18176C720
	public string GetJoystickFileGuidString(int joystickId) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal HardwareJoystickTemplateMap.SpecialElementEntry[] GetSpecialElementsOrig() { }

	// RVA: 0x176DA10 Offset: 0x176C010 VA: 0x18176DA10
	internal bool iaKJlWeRhlxzQxOMjnbeoyHSjItm(ControllerMap_Editor , HardwareJoystickMap , Guid , out string ) { }

	// RVA: 0x176D240 Offset: 0x176B840 VA: 0x18176D240
	internal SUKBHhZFjtXCZDAZGqMkzjNQboJY OXBDogYrJsZORTaCvKIHTMarTGnC() { }

	// RVA: 0x176D910 Offset: 0x176BF10 VA: 0x18176D910
	private HardwareJoystickTemplateMap.Entry hlPTMSnymaDPOOjCkNCwxDkRVeu(Guid ) { }

	[IteratorStateMachine(typeof(HardwareJoystickTemplateMap.uwWmBRwUPUvcvNsQdetkTuFUwufx))]
	// RVA: 0x176D540 Offset: 0x176BB40 VA: 0x18176D540 Slot: 25
	private IEnumerable<IControllerElementIdentifierCommon_Internal> Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_ElementIdentifiers() { }

	// RVA: 0x155E990 Offset: 0x155CF90 VA: 0x18155E990 Slot: 26
	private IControllerElementIdentifierCommon_Internal Rewired.Data.Mapping.IHardwareControllerMap_Internal.GetElementIdentifier(int id) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 8
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_name() { }

	// RVA: 0x176D5C0 Offset: 0x176BBC0 VA: 0x18176D5C0 Slot: 9
	private Guid Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_typeGuid() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 10
	private string Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.get_typeKey() { }

	// RVA: 0x176D690 Offset: 0x176BC90 VA: 0x18176D690 Slot: 11
	private int Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetElementIdentifierCount() { }

	// RVA: 0x176D720 Offset: 0x176BD20 VA: 0x18176D720 Slot: 12
	private IControllerTemplateElementIdentifier Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifier(int index) { }

	// RVA: 0x155E990 Offset: 0x155CF90 VA: 0x18155E990 Slot: 13
	private IControllerTemplateElementIdentifier Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifierById(int elementIdentifierId) { }

	// RVA: 0x176D6B0 Offset: 0x176BCB0 VA: 0x18176D6B0 Slot: 14
	private IControllerTemplateMapSpecialElement_Internal Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetSpecialTemplateElementByElementIdentifierId(int id) { }

	// RVA: 0x176D5F0 Offset: 0x176BBF0 VA: 0x18176D5F0 Slot: 15
	private vuooprXJHVvacQvysmZLVazcCbGcA Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetAxisTarget(Controller controller, int elementIdentifierId) { }

	// RVA: 0x176D640 Offset: 0x176BC40 VA: 0x18176D640 Slot: 16
	private vuooprXJHVvacQvysmZLVazcCbGcA Rewired.Data.Mapping.IHardwareControllerTemplateMap_Internal.GetButtonTarget(Controller controller, int elementIdentifierId) { }

	// RVA: 0x176D1B0 Offset: 0x176B7B0 VA: 0x18176D1B0
	private Func<Guid, HardwareJoystickTemplateMap.Entry> NeObThvkqUejjoCCmkfTBNVbBIdD() { }

	// RVA: 0x176C090 Offset: 0x176A690 VA: 0x18176C090
	internal static vuooprXJHVvacQvysmZLVazcCbGcA BeKVQupanfQxzfEFwNETmAujgNXFA(IHardwareControllerTemplateMap_Internal , Controller , int , Func<Guid, HardwareJoystickTemplateMap.Entry> ) { }

	// RVA: 0x176E3B0 Offset: 0x176C9B0 VA: 0x18176E3B0
	internal static vuooprXJHVvacQvysmZLVazcCbGcA sMFEhcuyYhZHTnxMatWNBOzXkROc(IHardwareControllerTemplateMap_Internal , Controller , int , Func<Guid, HardwareJoystickTemplateMap.Entry> ) { }

	// RVA: 0x176D7B0 Offset: 0x176BDB0 VA: 0x18176D7B0
	internal static ControllerTemplateElementIdentifier gMoqCtwoTwEcaqVFQDcojnLjfmKtA(ControllerTemplateElementIdentifier[] , int ) { }

	// RVA: 0x176D4E0 Offset: 0x176BAE0 VA: 0x18176D4E0
	internal static int PEVMPrnlPNGmiYwJrFGUhYOAMjTw(ControllerTemplateElementIdentifier[] , int ) { }

	// RVA: 0x176E350 Offset: 0x176C950 VA: 0x18176E350
	internal static bool mUcpDsVsaDLAJfdCFgLKDkIeOLiX(ControllerTemplateElementIdentifier[] , int ) { }

	// RVA: 0x176D750 Offset: 0x176BD50 VA: 0x18176D750
	public void .ctor() { }

	// RVA: 0x1729A70 Offset: 0x1728070 VA: 0x181729A70 Slot: 21
	private string Rewired.Data.Mapping.IHardwareControllerMap_Internal.get_name() { }
}

// Namespace: Rewired.Data.Mapping
public enum HardwareElementSourceType // TypeDefIndex: 2628
{
	// Fields
	public int value__; // 0x0
	public const HardwareElementSourceType Button = 0;
	public const HardwareElementSourceType Axis = 1;
	public const HardwareElementSourceType Key = 3;
	public const HardwareElementSourceType Custom = 100;
}

// Namespace: Rewired.Data.Mapping
public enum HardwareElementSourceTypeWithHat // TypeDefIndex: 2629
{
	// Fields
	public int value__; // 0x0
	public const HardwareElementSourceTypeWithHat Button = 0;
	public const HardwareElementSourceTypeWithHat Axis = 1;
	public const HardwareElementSourceTypeWithHat Hat = 2;
	public const HardwareElementSourceTypeWithHat Key = 3;
	public const HardwareElementSourceTypeWithHat Custom = 100;
}

// Namespace: Rewired.Data.Mapping
public enum HatDirection // TypeDefIndex: 2630
{
	// Fields
	public int value__; // 0x0
	public const HatDirection Up = 0;
	public const HatDirection Right = 1;
	public const HatDirection Down = 2;
	public const HatDirection Left = 3;
	public const HatDirection UpRight = 4;
	public const HatDirection DownRight = 5;
	public const HatDirection DownLeft = 6;
	public const HatDirection UpLeft = 7;
}

// Namespace: Rewired.Data.Mapping
public enum HatType // TypeDefIndex: 2631
{
	// Fields
	public int value__; // 0x0
	public const HatType FourWay = 0;
	public const HatType EightWay = 1;
}

// Namespace: Rewired.Data.Mapping
public enum AxisDirection // TypeDefIndex: 2632
{
	// Fields
	public int value__; // 0x0
	public const AxisDirection Vertical = 0;
	public const AxisDirection Horizontal = 1;
}

// Namespace: Rewired.Data.Mapping
public enum HardwareAxisType // TypeDefIndex: 2633
{
	// Fields
	public int value__; // 0x0
	public const HardwareAxisType Axis = 0;
	public const HardwareAxisType Axis2D = 1;
}

// Namespace: Rewired.Data.Mapping
public enum AxisCalibrationType // TypeDefIndex: 2634
{
	// Fields
	public int value__; // 0x0
	public const AxisCalibrationType Default = 0;
	public const AxisCalibrationType Uncalibrated = 1;
	public const AxisCalibrationType Custom = 2;
}

// Namespace: Rewired.Data.Mapping
public enum SpecialAxisType // TypeDefIndex: 2635
{
	// Fields
	public int value__; // 0x0
	public const SpecialAxisType None = 0;
	public const SpecialAxisType Throttle = 1;
}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
internal enum AlternateAxisCalibrationType // TypeDefIndex: 2636
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const AlternateAxisCalibrationType Default = 0;
	[CustomObfuscation(rename = False)]
	public const AlternateAxisCalibrationType ThrottleZeroCenter = 1;
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public class HardwareAxisInfo : IDeepCloneable // TypeDefIndex: 2637
{
	// Fields
	[SerializeField]
	internal AxisCoordinateMode _dataFormat; // 0x10
	[SerializeField]
	internal bool _excludeFromPolling; // 0x14
	[SerializeField]
	internal SpecialAxisType _specialAxisType; // 0x18
	[SerializeField]
	internal float _pollingDeadZone; // 0x1C

	// Properties
	public AxisCoordinateMode dataFormat { get; }
	public bool excludeFromPolling { get; }
	public SpecialAxisType specialAxisType { get; }
	public float pollingDeadZone { get; }
	[CustomObfuscation(rename = False)]
	internal static HardwareAxisInfo Default { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public AxisCoordinateMode get_dataFormat() { }

	// RVA: 0xC1EE00 Offset: 0xC1D400 VA: 0x180C1EE00
	public bool get_excludeFromPolling() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public SpecialAxisType get_specialAxisType() { }

	// RVA: 0x3CB3F0 Offset: 0x3C99F0 VA: 0x1803CB3F0
	public float get_pollingDeadZone() { }

	// RVA: 0x176BF10 Offset: 0x176A510 VA: 0x18176BF10
	public void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x176BF40 Offset: 0x176A540 VA: 0x18176BF40
	internal void .ctor(AxisCoordinateMode , bool , float , SpecialAxisType ) { }

	// RVA: 0x176BFA0 Offset: 0x176A5A0 VA: 0x18176BFA0
	internal static HardwareAxisInfo get_Default() { }

	// RVA: 0x176BE70 Offset: 0x176A470 VA: 0x18176BE70 Slot: 4
	public object DeepClone() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public class HardwareButtonInfo : IDeepCloneable // TypeDefIndex: 2638
{
	// Fields
	[SerializeField]
	internal bool _excludeFromPolling; // 0x10
	[SerializeField]
	internal bool _isPressureSensitive; // 0x11

	// Properties
	public bool excludeFromPolling { get; }
	public bool isPressureSensitive { get; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_excludeFromPolling() { }

	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_isPressureSensitive() { }

	// RVA: 0x176C070 Offset: 0x176A670 VA: 0x18176C070
	public void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x133A310 Offset: 0x1338910 VA: 0x18133A310
	internal void .ctor(bool , bool ) { }

	// RVA: 0x176C000 Offset: 0x176A600 VA: 0x18176C000 Slot: 4
	public object DeepClone() { }
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public class AxisCalibrationInfo : IDeepCloneable // TypeDefIndex: 2639
{
	// Fields
	[SerializeField]
	private bool _applyRangeCalibration; // 0x10
	[SerializeField]
	private bool _invert; // 0x11
	[SerializeField]
	private float _deadZone; // 0x14
	[SerializeField]
	private float _zero; // 0x18
	[SerializeField]
	private float _min; // 0x1C
	[SerializeField]
	private float _max; // 0x20
	[SerializeField]
	private AxisSensitivityType _sensitivityType; // 0x24
	[SerializeField]
	private float _sensitivity; // 0x28
	[SerializeField]
	private AnimationCurve _sensitivityCurve; // 0x30

	// Properties
	public bool applyRangeCalibration { get; set; }
	public bool invert { get; set; }
	public float deadZone { get; set; }
	public float zero { get; set; }
	public float min { get; set; }
	public float max { get; set; }
	public AxisSensitivityType sensitivityType { get; set; }
	public float sensitivity { get; set; }
	public AnimationCurve sensitivityCurve { get; set; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_applyRangeCalibration() { }

	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_applyRangeCalibration(bool value) { }

	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_invert() { }

	// RVA: 0x14B8CA0 Offset: 0x14B72A0 VA: 0x1814B8CA0
	public void set_invert(bool value) { }

	// RVA: 0x3A4AB0 Offset: 0x3A30B0 VA: 0x1803A4AB0
	public float get_deadZone() { }

	// RVA: 0x3A4C60 Offset: 0x3A3260 VA: 0x1803A4C60
	public void set_deadZone(float value) { }

	// RVA: 0x3A4A70 Offset: 0x3A3070 VA: 0x1803A4A70
	public float get_zero() { }

	// RVA: 0x3A4C30 Offset: 0x3A3230 VA: 0x1803A4C30
	public void set_zero(float value) { }

	// RVA: 0x3CB3F0 Offset: 0x3C99F0 VA: 0x1803CB3F0
	public float get_min() { }

	// RVA: 0x3CB450 Offset: 0x3C9A50 VA: 0x1803CB450
	public void set_min(float value) { }

	// RVA: 0x3CB400 Offset: 0x3C9A00 VA: 0x1803CB400
	public float get_max() { }

	// RVA: 0x3CB460 Offset: 0x3C9A60 VA: 0x1803CB460
	public void set_max(float value) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public AxisSensitivityType get_sensitivityType() { }

	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	public void set_sensitivityType(AxisSensitivityType value) { }

	// RVA: 0x3CB4A0 Offset: 0x3C9AA0 VA: 0x1803CB4A0
	public float get_sensitivity() { }

	// RVA: 0x3CB510 Offset: 0x3C9B10 VA: 0x1803CB510
	public void set_sensitivity(float value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public AnimationCurve get_sensitivityCurve() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_sensitivityCurve(AnimationCurve value) { }

	// RVA: 0x175F8F0 Offset: 0x175DEF0 VA: 0x18175F8F0
	public void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x175F840 Offset: 0x175DE40 VA: 0x18175F840
	internal void .ctor(float , float , float , float , bool , bool , AxisSensitivityType , float , AnimationCurve ) { }

	// RVA: 0x175F700 Offset: 0x175DD00 VA: 0x18175F700 Slot: 4
	public object DeepClone() { }

	// RVA: 0x175F900 Offset: 0x175DF00 VA: 0x18175F900
	internal static AxisCalibrationData cllDKZmfQpIlwuQZzofNcwmlSTgi(AxisCalibrationInfo ) { }

	// RVA: 0x175FAA0 Offset: 0x175E0A0 VA: 0x18175FAA0
	internal static AxisCalibrationInfo uIEJjViMcREqppxTcrbFOmPwkRgn(AxisCalibrationData ) { }
}

// Namespace: Rewired.Data.Mapping
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
public interface IHardwareControllerMap // TypeDefIndex: 2640
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string[] GetElementIdentifierNames();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int[] GetElementIdentifierIds();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool ContainsElementIdentifier(int id);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int GetMappableElementIdentifierInfo(out string[] names, out int[] ids);
}

// Namespace: Rewired.Data.Mapping
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
public interface IHardwareControllerTemplateMap // TypeDefIndex: 2641
{}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IHardwareControllerMap_Internal // TypeDefIndex: 2642
{
	// Properties
	public abstract string name { get; }
	public abstract Guid typeGuid { get; }
	public abstract string typeKey { get; }
	public abstract ControllerType controllerType { get; }
	public abstract IEnumerable<IControllerElementIdentifierCommon_Internal> ElementIdentifiers { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Guid get_typeGuid();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_typeKey();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ControllerType get_controllerType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerable<IControllerElementIdentifierCommon_Internal> get_ElementIdentifiers();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerElementIdentifierCommon_Internal GetElementIdentifier(int id);
}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IHardwareControllerTemplateMap_Internal // TypeDefIndex: 2643
{
	// Properties
	public abstract string name { get; }
	public abstract Guid typeGuid { get; }
	public abstract string typeKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Guid get_typeGuid();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_typeKey();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int GetElementIdentifierCount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IControllerTemplateElementIdentifier GetTemplateElementIdentifier(int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IControllerTemplateElementIdentifier GetTemplateElementIdentifierById(int elementIdentifierId);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IControllerTemplateMapSpecialElement_Internal GetSpecialTemplateElementByElementIdentifierId(int id);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract vuooprXJHVvacQvysmZLVazcCbGcA GetAxisTarget(Controller controller, int elementIdentifierId);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract vuooprXJHVvacQvysmZLVazcCbGcA GetButtonTarget(Controller controller, int elementIdentifierId);
}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IControllerTemplateMapMapping_Internal // TypeDefIndex: 2644
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IControllerElementTarget[] GetTargets();
}

// Namespace: Rewired.Data.Mapping
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IControllerTemplateMapSpecialElement_Internal // TypeDefIndex: 2645
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T GetMapping<T>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IControllerTemplateMapSpecialElement_Internal.GetMapping<object>
	*/
}

// Namespace: Rewired.Data.Mapping
[Serializable]
public sealed class ControllerMap_Editor // TypeDefIndex: 2647
{
	// Fields
	public int id; // 0x10
	public int categoryId; // 0x14
	public int layoutId; // 0x18
	public string name; // 0x20
	public string hardwareGuidString; // 0x28
	public int customControllerUid; // 0x30
	public List<ActionElementMap> actionElementMaps; // 0x38

	// Properties
	public IEnumerable<ActionElementMap> ActionElementMaps { get; }
	public Guid hardwareGuid { get; }

	// Methods

	[IteratorStateMachine(typeof(ControllerMap_Editor.CkiSfnuxBtEZzeZOcxNWwLXGexRh))]
	// RVA: 0x17621F0 Offset: 0x17607F0 VA: 0x1817621F0
	public IEnumerable<ActionElementMap> get_ActionElementMaps() { }

	// RVA: 0x1762270 Offset: 0x1760870 VA: 0x181762270
	public Guid get_hardwareGuid() { }

	// RVA: 0x1761CE0 Offset: 0x17602E0 VA: 0x181761CE0
	public void .ctor() { }

	// RVA: 0x17605B0 Offset: 0x175EBB0 VA: 0x1817605B0
	public ControllerMap_Editor Clone() { }

	// RVA: 0x1761510 Offset: 0x175FB10 VA: 0x181761510
	public ActionElementMap GetActionElementMap(int index) { }

	// RVA: 0x1761640 Offset: 0x175FC40 VA: 0x181761640
	internal JoystickMap HHjbLQwFCbOjIjxqDmKMrxnjcQxu(Func<int, bool> , HardwareControllerMapIdentifier , HardwareJoystickMap , bool ) { }

	// RVA: 0x1761590 Offset: 0x175FB90 VA: 0x181761590
	internal KeyboardMap GkOMTpuElomGSiWBHoGtQSVvbgvP(Func<int, bool> ) { }

	// RVA: 0x1761460 Offset: 0x175FA60 VA: 0x181761460
	internal MouseMap GJlKCiYFZmwrNGsQeVDnjyKjAnUl(Func<int, bool> ) { }

	// RVA: 0x1761C50 Offset: 0x1760250 VA: 0x181761C50
	internal CustomControllerMap YPcdpeLlKOZIUgyoMEQkYAakxOyD(Func<int, bool> , CustomController_Editor ) { }

	// RVA: 0x17610F0 Offset: 0x175F6F0 VA: 0x1817610F0
	internal ControllerTemplateMap DsEYefPHnASQMUeVIEPlKXaXvSKy() { }

	// RVA: 0x1761D60 Offset: 0x1760360 VA: 0x181761D60
	private void folKIkpWpvEvDkfvXNFHqiugeHiB(Func<int, bool> , ControllerMap , HardwareControllerMapIdentifier , HardwareJoystickMap , bool ) { }

	// RVA: 0x17617D0 Offset: 0x175FDD0 VA: 0x1817617D0
	private void MQieuvVTjMNNEfLtsOAJxZmKMxtr(Func<int, bool> , InputSource , CustomControllerMap , CustomController_Editor ) { }

	// RVA: 0x1760820 Offset: 0x175EE20 VA: 0x181760820
	public void CreateElementsFromHardwareMap(IHardwareControllerMap hardwareJoystickMap) { }

	// RVA: 0x1760B90 Offset: 0x175F190 VA: 0x181760B90
	public void CreateElementsFromHardwareMap(CustomController_Editor customController) { }

	// RVA: 0x17604F0 Offset: 0x175EAF0 VA: 0x1817604F0
	public void AddActionElementMap() { }

	// RVA: 0x1761700 Offset: 0x175FD00 VA: 0x181761700
	public void InsertActionElementMap(int index) { }

	// RVA: 0x1761040 Offset: 0x175F640 VA: 0x181761040
	public void DeleteActionElementMap(int index) { }

	// RVA: 0x1761BE0 Offset: 0x17601E0 VA: 0x181761BE0
	public bool ReorderActionElementMap(int index, bool offsetDown, bool offsetNow) { }

	// RVA: 0x1761300 Offset: 0x175F900 VA: 0x181761300
	public void DuplicateActionElementMap(int index) { }

	// RVA: 0x17622E0 Offset: 0x17608E0 VA: 0x1817622E0
	private ActionElementMap wrlwpkyPTxUCDzAKycRnjunGkewh() { }
}

