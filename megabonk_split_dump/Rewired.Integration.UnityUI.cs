// Namespace: Rewired.Integration.UnityUI
public class PlayerPointerEventData : PointerEventData // TypeDefIndex: 5217
{
	// Fields
	[CompilerGenerated]
	private int <playerId>k__BackingField; // 0x180
	[CompilerGenerated]
	private int <inputSourceIndex>k__BackingField; // 0x184
	[CompilerGenerated]
	private IMouseInputSource <mouseSource>k__BackingField; // 0x188
	[CompilerGenerated]
	private ITouchInputSource <touchSource>k__BackingField; // 0x190
	[CompilerGenerated]
	private PointerEventType <sourceType>k__BackingField; // 0x198
	[CompilerGenerated]
	private int <buttonIndex>k__BackingField; // 0x19C

	// Properties
	public int playerId { get; set; }
	public int inputSourceIndex { get; set; }
	public IMouseInputSource mouseSource { get; set; }
	public ITouchInputSource touchSource { get; set; }
	public PointerEventType sourceType { get; set; }
	public int buttonIndex { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37EAF0 Offset: 0x37D0F0 VA: 0x18037EAF0
	public int get_playerId() { }

	[CompilerGenerated]
	// RVA: 0x37EB60 Offset: 0x37D160 VA: 0x18037EB60
	public void set_playerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37EAD0 Offset: 0x37D0D0 VA: 0x18037EAD0
	public int get_inputSourceIndex() { }

	[CompilerGenerated]
	// RVA: 0x37EB30 Offset: 0x37D130 VA: 0x18037EB30
	public void set_inputSourceIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x37EAE0 Offset: 0x37D0E0 VA: 0x18037EAE0
	public IMouseInputSource get_mouseSource() { }

	[CompilerGenerated]
	// RVA: 0x37EB40 Offset: 0x37D140 VA: 0x18037EB40
	public void set_mouseSource(IMouseInputSource value) { }

	[CompilerGenerated]
	// RVA: 0x37EB10 Offset: 0x37D110 VA: 0x18037EB10
	public ITouchInputSource get_touchSource() { }

	[CompilerGenerated]
	// RVA: 0x37EB80 Offset: 0x37D180 VA: 0x18037EB80
	public void set_touchSource(ITouchInputSource value) { }

	[CompilerGenerated]
	// RVA: 0x37EB00 Offset: 0x37D100 VA: 0x18037EB00
	public PointerEventType get_sourceType() { }

	[CompilerGenerated]
	// RVA: 0x37EB70 Offset: 0x37D170 VA: 0x18037EB70
	public void set_sourceType(PointerEventType value) { }

	[CompilerGenerated]
	// RVA: 0x37EAC0 Offset: 0x37D0C0 VA: 0x18037EAC0
	public int get_buttonIndex() { }

	[CompilerGenerated]
	// RVA: 0x37EB20 Offset: 0x37D120 VA: 0x18037EB20
	public void set_buttonIndex(int value) { }

	// RVA: 0x37EA90 Offset: 0x37D090 VA: 0x18037EA90
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x37E820 Offset: 0x37CE20 VA: 0x18037E820 Slot: 3
	public override string ToString() { }
}

// Namespace: Rewired.Integration.UnityUI
[AddComponentMenu("Rewired/Rewired Event System")]
public class RewiredEventSystem : EventSystem // TypeDefIndex: 5218
{
	// Fields
	[Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
	[SerializeField]
	private bool _alwaysUpdate; // 0x60

	// Properties
	public bool alwaysUpdate { get; set; }

	// Methods

	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810
	public bool get_alwaysUpdate() { }

	// RVA: 0x37F820 Offset: 0x37DE20 VA: 0x18037F820
	public void set_alwaysUpdate(bool value) { }

	// RVA: 0x37F690 Offset: 0x37DC90 VA: 0x18037F690 Slot: 18
	protected override void Update() { }

	// RVA: 0x37F7C0 Offset: 0x37DDC0 VA: 0x18037F7C0
	public void .ctor() { }
}

// Namespace: Rewired.Integration.UnityUI
public abstract class RewiredPointerInputModule : BaseInputModule // TypeDefIndex: 5223
{
	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	private const int customButtonsStartingId = -2147483520;
	private const int customButtonsMaxCount = 128;
	private const int customButtonsLastId = -2147483392;
	private readonly List<IMouseInputSource> m_MouseInputSourcesList; // 0x58
	private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData; // 0x60
	private ITouchInputSource m_UserDefaultTouchInputSource; // 0x68
	private RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource; // 0x70
	private readonly RewiredPointerInputModule.MouseState m_MouseState; // 0x78

	// Properties
	private RewiredPointerInputModule.UnityInputSource defaultInputSource { get; }
	private IMouseInputSource defaultMouseInputSource { get; }
	protected ITouchInputSource defaultTouchInputSource { get; }
	protected virtual bool isMouseSupported { get; }

	// Methods

	// RVA: 0x3829E0 Offset: 0x380FE0 VA: 0x1803829E0
	private RewiredPointerInputModule.UnityInputSource get_defaultInputSource() { }

	// RVA: 0x382A60 Offset: 0x381060 VA: 0x180382A60
	private IMouseInputSource get_defaultMouseInputSource() { }

	// RVA: 0x382A60 Offset: 0x381060 VA: 0x180382A60
	protected ITouchInputSource get_defaultTouchInputSource() { }

	// RVA: 0x381A40 Offset: 0x380040 VA: 0x180381A40
	protected bool IsDefaultMouse(IMouseInputSource mouse) { }

	// RVA: 0x380460 Offset: 0x37EA60 VA: 0x180380460
	public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex) { }

	// RVA: 0x3820D0 Offset: 0x3806D0 VA: 0x1803820D0
	public void RemoveMouseInputSource(IMouseInputSource source) { }

	// RVA: 0x37F830 Offset: 0x37DE30 VA: 0x18037F830
	public void AddMouseInputSource(IMouseInputSource source) { }

	// RVA: 0x380310 Offset: 0x37E910 VA: 0x180380310
	public int GetMouseInputSourceCount(int playerId) { }

	// RVA: 0x3816D0 Offset: 0x37FCD0 VA: 0x1803816D0
	public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex) { }

	// RVA: 0x382240 Offset: 0x380840 VA: 0x180382240
	public void RemoveTouchInputSource(ITouchInputSource source) { }

	// RVA: 0x37F970 Offset: 0x37DF70 VA: 0x18037F970
	public void AddTouchInputSource(ITouchInputSource source) { }

	// RVA: 0x3816A0 Offset: 0x37FCA0 VA: 0x1803816A0
	public int GetTouchInputSourceCount(int playerId) { }

	// RVA: 0x37FA40 Offset: 0x37E040 VA: 0x18037FA40
	protected void ClearMouseInputSources() { }

	// RVA: 0x382A70 Offset: 0x381070 VA: 0x180382A70 Slot: 27
	protected virtual bool get_isMouseSupported() { }

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract bool IsDefaultPlayer(int playerId);

	// RVA: 0x381020 Offset: 0x37F620 VA: 0x180381020
	protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType) { }

	// RVA: 0x37FEE0 Offset: 0x37E4E0 VA: 0x18037FEE0
	private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType) { }

	// RVA: 0x382180 Offset: 0x380780 VA: 0x180382180
	protected void RemovePointerData(PlayerPointerEventData data) { }

	// RVA: 0x381760 Offset: 0x37FD60 VA: 0x180381760
	protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released) { }

	// RVA: 0x380620 Offset: 0x37EC20 VA: 0x180380620 Slot: 29
	protected virtual RewiredPointerInputModule.MouseState GetMousePointerEventData(int playerId, int mouseIndex) { }

	// RVA: 0x380110 Offset: 0x37E710 VA: 0x180380110
	protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType) { }

	// RVA: 0x3822C0 Offset: 0x3808C0 VA: 0x1803822C0
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x381FB0 Offset: 0x3805B0 VA: 0x180381FB0 Slot: 30
	protected virtual void ProcessMove(PlayerPointerEventData pointerEvent) { }

	// RVA: 0x381C60 Offset: 0x380260 VA: 0x180381C60 Slot: 31
	protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent) { }

	// RVA: 0x381A60 Offset: 0x380060 VA: 0x180381A60 Slot: 20
	public override bool IsPointerOverGameObject(int pointerTypeId) { }

	// RVA: 0x37FAA0 Offset: 0x37E0A0 VA: 0x18037FAA0
	protected void ClearSelection() { }

	// RVA: 0x3823E0 Offset: 0x3809E0 VA: 0x1803823E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x380030 Offset: 0x37E630 VA: 0x180380030
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x37FDF0 Offset: 0x37E3F0 VA: 0x18037FDF0
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x382310 Offset: 0x380910 VA: 0x180382310
	protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId) { }

	// RVA: 0x382880 Offset: 0x380E80 VA: 0x180382880
	protected void .ctor() { }
}

// Namespace: Rewired.Integration.UnityUI
public enum PointerEventType // TypeDefIndex: 5224
{
	// Fields
	public int value__; // 0x0
	public const PointerEventType Mouse = 0;
	public const PointerEventType Touch = 1;
}

// Namespace: Rewired.Integration.UnityUI
[AddComponentMenu("Rewired/Rewired Standalone Input Module")]
public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule // TypeDefIndex: 5226
{
	// Fields
	private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";
	private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";
	private const string DEFAULT_ACTION_SUBMIT = "UISubmit";
	private const string DEFAULT_ACTION_CANCEL = "UICancel";
	[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Player ids, etc.")]
	[SerializeField]
	private InputManager_Base rewiredInputManager; // 0x80
	[SerializeField]
	[Tooltip("Use all Rewired game Players to control the UI. This does not include the System Player. If enabled, this setting overrides individual Player Ids set in Rewired Player Ids.")]
	private bool useAllRewiredGamePlayers; // 0x88
	[SerializeField]
	[Tooltip("Allow the Rewired System Player to control the UI.")]
	private bool useRewiredSystemPlayer; // 0x89
	[SerializeField]
	[Tooltip("A list of Player Ids that are allowed to control the UI. If Use All Rewired Game Players = True, this list will be ignored.")]
	private int[] rewiredPlayerIds; // 0x90
	[SerializeField]
	[Tooltip("Allow only Players with Player.isPlaying = true to control the UI.")]
	private bool usePlayingPlayersOnly; // 0x98
	[SerializeField]
	[Tooltip("Player Mice allowed to interact with the UI. Each Player that owns a Player Mouse must also be allowed to control the UI or the Player Mouse will not function.")]
	private List<PlayerMouse> playerMice; // 0xA0
	[SerializeField]
	[Tooltip("Makes an axis press always move only one UI selection. Enable if you do not want to allow scrolling through UI elements by holding an axis direction.")]
	private bool moveOneElementPerAxisPress; // 0xA8
	[SerializeField]
	[Tooltip("If enabled, Action Ids will be used to set the Actions. If disabled, string names will be used to set the Actions.")]
	private bool setActionsById; // 0xA9
	[SerializeField]
	[Tooltip("Id of the horizontal Action for movement (if axis events are used).")]
	private int horizontalActionId; // 0xAC
	[SerializeField]
	[Tooltip("Id of the vertical Action for movement (if axis events are used).")]
	private int verticalActionId; // 0xB0
	[SerializeField]
	[Tooltip("Id of the Action used to submit.")]
	private int submitActionId; // 0xB4
	[SerializeField]
	[Tooltip("Id of the Action used to cancel.")]
	private int cancelActionId; // 0xB8
	[SerializeField]
	[Tooltip("Name of the horizontal axis for movement (if axis events are used).")]
	private string m_HorizontalAxis; // 0xC0
	[SerializeField]
	[Tooltip("Name of the vertical axis for movement (if axis events are used).")]
	private string m_VerticalAxis; // 0xC8
	[SerializeField]
	[Tooltip("Name of the action used to submit.")]
	private string m_SubmitButton; // 0xD0
	[SerializeField]
	[Tooltip("Name of the action used to cancel.")]
	private string m_CancelButton; // 0xD8
	[SerializeField]
	[Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction.")]
	private float m_InputActionsPerSecond; // 0xE0
	[SerializeField]
	[Tooltip("Delay in seconds before vertical/horizontal movement starts repeating continouously when a movement direction is held.")]
	private float m_RepeatDelay; // 0xE4
	[SerializeField]
	[Tooltip("Allows the mouse to be used to select elements.")]
	private bool m_allowMouseInput; // 0xE8
	[SerializeField]
	[Tooltip("Allows the mouse to be used to select elements if the device also supports touch control.")]
	private bool m_allowMouseInputIfTouchSupported; // 0xE9
	[SerializeField]
	[Tooltip("Allows touch input to be used to select elements.")]
	private bool m_allowTouchInput; // 0xEA
	[SerializeField]
	[Tooltip("Deselects the current selection on mouse/touch click when the pointer is not over a selectable object.")]
	private bool m_deselectIfBackgroundClicked; // 0xEB
	[SerializeField]
	[Tooltip("Deselects the current selection on mouse/touch click before selecting the next object.")]
	private bool m_deselectBeforeSelecting; // 0xEC
	[SerializeField]
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	[Tooltip("Forces the module to always be active.")]
	private bool m_ForceModuleActive; // 0xED
	private int[] playerIds; // 0xF0
	private bool recompiling; // 0xF8
	private bool isTouchSupported; // 0xF9
	private double m_PrevActionTime; // 0x100
	private Vector2 m_LastMoveVector; // 0x108
	private int m_ConsecutiveMoveCount; // 0x110
	private bool m_HasFocus; // 0x114

	// Properties
	public InputManager_Base RewiredInputManager { get; set; }
	public bool UseAllRewiredGamePlayers { get; set; }
	public bool UseRewiredSystemPlayer { get; set; }
	public int[] RewiredPlayerIds { get; set; }
	public bool UsePlayingPlayersOnly { get; set; }
	public List<PlayerMouse> PlayerMice { get; set; }
	public bool MoveOneElementPerAxisPress { get; set; }
	public bool allowMouseInput { get; set; }
	public bool allowMouseInputIfTouchSupported { get; set; }
	public bool allowTouchInput { get; set; }
	public bool deselectIfBackgroundClicked { get; set; }
	private bool deselectBeforeSelecting { get; set; }
	public bool SetActionsById { get; set; }
	public int HorizontalActionId { get; set; }
	public int VerticalActionId { get; set; }
	public int SubmitActionId { get; set; }
	public int CancelActionId { get; set; }
	protected override bool isMouseSupported { get; }
	private bool isTouchAllowed { get; }
	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead")]
	public bool allowActivationOnMobileDevice { get; set; }
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x3A3510 Offset: 0x3A1B10 VA: 0x1803A3510
	public InputManager_Base get_RewiredInputManager() { }

	// RVA: 0x3A3A50 Offset: 0x3A2050 VA: 0x1803A3A50
	public void set_RewiredInputManager(InputManager_Base value) { }

	// RVA: 0x3A35C0 Offset: 0x3A1BC0 VA: 0x1803A35C0
	public bool get_UseAllRewiredGamePlayers() { }

	// RVA: 0x3A3C80 Offset: 0x3A2280 VA: 0x1803A3C80
	public void set_UseAllRewiredGamePlayers(bool value) { }

	// RVA: 0x3A35E0 Offset: 0x3A1BE0 VA: 0x1803A35E0
	public bool get_UseRewiredSystemPlayer() { }

	// RVA: 0x3A3CB0 Offset: 0x3A22B0 VA: 0x1803A3CB0
	public void set_UseRewiredSystemPlayer(bool value) { }

	// RVA: 0x3A3520 Offset: 0x3A1B20 VA: 0x1803A3520
	public int[] get_RewiredPlayerIds() { }

	// RVA: 0x3A3A60 Offset: 0x3A2060 VA: 0x1803A3A60
	public void set_RewiredPlayerIds(int[] value) { }

	// RVA: 0x3A35D0 Offset: 0x3A1BD0 VA: 0x1803A35D0
	public bool get_UsePlayingPlayersOnly() { }

	// RVA: 0x3A3CA0 Offset: 0x3A22A0 VA: 0x1803A3CA0
	public void set_UsePlayingPlayersOnly(bool value) { }

	// RVA: 0x3A34A0 Offset: 0x3A1AA0 VA: 0x1803A34A0
	public List<PlayerMouse> get_PlayerMice() { }

	// RVA: 0x3A39A0 Offset: 0x3A1FA0 VA: 0x1803A39A0
	public void set_PlayerMice(List<PlayerMouse> value) { }

	// RVA: 0x3A3490 Offset: 0x3A1A90 VA: 0x1803A3490
	public bool get_MoveOneElementPerAxisPress() { }

	// RVA: 0x3A3990 Offset: 0x3A1F90 VA: 0x1803A3990
	public void set_MoveOneElementPerAxisPress(bool value) { }

	// RVA: 0x3A3620 Offset: 0x3A1C20 VA: 0x1803A3620
	public bool get_allowMouseInput() { }

	// RVA: 0x3A3E30 Offset: 0x3A2430 VA: 0x1803A3E30
	public void set_allowMouseInput(bool value) { }

	// RVA: 0x3A3610 Offset: 0x3A1C10 VA: 0x1803A3610
	public bool get_allowMouseInputIfTouchSupported() { }

	// RVA: 0x3A3E20 Offset: 0x3A2420 VA: 0x1803A3E20
	public void set_allowMouseInputIfTouchSupported(bool value) { }

	// RVA: 0x3A3630 Offset: 0x3A1C30 VA: 0x1803A3630
	public bool get_allowTouchInput() { }

	// RVA: 0x3A3E40 Offset: 0x3A2440 VA: 0x1803A3E40
	public void set_allowTouchInput(bool value) { }

	// RVA: 0x3A3660 Offset: 0x3A1C60 VA: 0x1803A3660
	public bool get_deselectIfBackgroundClicked() { }

	// RVA: 0x3A3F60 Offset: 0x3A2560 VA: 0x1803A3F60
	public void set_deselectIfBackgroundClicked(bool value) { }

	// RVA: 0x3A3650 Offset: 0x3A1C50 VA: 0x1803A3650
	private bool get_deselectBeforeSelecting() { }

	// RVA: 0x3A3F50 Offset: 0x3A2550 VA: 0x1803A3F50
	private void set_deselectBeforeSelecting(bool value) { }

	// RVA: 0x3A35A0 Offset: 0x3A1BA0 VA: 0x1803A35A0
	public bool get_SetActionsById() { }

	// RVA: 0x3A3B20 Offset: 0x3A2120 VA: 0x1803A3B20
	public void set_SetActionsById(bool value) { }

	// RVA: 0x3A3480 Offset: 0x3A1A80 VA: 0x1803A3480
	public int get_HorizontalActionId() { }

	// RVA: 0x3A3850 Offset: 0x3A1E50 VA: 0x1803A3850
	public void set_HorizontalActionId(int value) { }

	// RVA: 0x3A35F0 Offset: 0x3A1BF0 VA: 0x1803A35F0
	public int get_VerticalActionId() { }

	// RVA: 0x3A3CD0 Offset: 0x3A22D0 VA: 0x1803A3CD0
	public void set_VerticalActionId(int value) { }

	// RVA: 0x3A35B0 Offset: 0x3A1BB0 VA: 0x1803A35B0
	public int get_SubmitActionId() { }

	// RVA: 0x3A3B40 Offset: 0x3A2140 VA: 0x1803A3B40
	public void set_SubmitActionId(int value) { }

	// RVA: 0x3A3470 Offset: 0x3A1A70 VA: 0x1803A3470
	public int get_CancelActionId() { }

	// RVA: 0x3A3710 Offset: 0x3A1D10 VA: 0x1803A3710
	public void set_CancelActionId(int value) { }

	// RVA: 0x3A3690 Offset: 0x3A1C90 VA: 0x1803A3690 Slot: 27
	protected override bool get_isMouseSupported() { }

	// RVA: 0x3A3630 Offset: 0x3A1C30 VA: 0x1803A3630
	private bool get_isTouchAllowed() { }

	// RVA: 0x3A3600 Offset: 0x3A1C00 VA: 0x1803A3600
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x3A3E10 Offset: 0x3A2410 VA: 0x1803A3E10
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x3A3600 Offset: 0x3A1C00 VA: 0x1803A3600
	public bool get_forceModuleActive() { }

	// RVA: 0x3A3E10 Offset: 0x3A2410 VA: 0x1803A3E10
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x3A3680 Offset: 0x3A1C80 VA: 0x1803A3680
	public float get_inputActionsPerSecond() { }

	// RVA: 0x3A4070 Offset: 0x3A2670 VA: 0x1803A4070
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x3A36E0 Offset: 0x3A1CE0 VA: 0x1803A36E0
	public float get_repeatDelay() { }

	// RVA: 0x3A4080 Offset: 0x3A2680 VA: 0x1803A4080
	public void set_repeatDelay(float value) { }

	// RVA: 0x3A3670 Offset: 0x3A1C70 VA: 0x1803A3670
	public string get_horizontalAxis() { }

	// RVA: 0x3A3F70 Offset: 0x3A2570 VA: 0x1803A3F70
	public void set_horizontalAxis(string value) { }

	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	public string get_verticalAxis() { }

	// RVA: 0x3A4190 Offset: 0x3A2790 VA: 0x1803A4190
	public void set_verticalAxis(string value) { }

	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	public string get_submitButton() { }

	// RVA: 0x3A4090 Offset: 0x3A2690 VA: 0x1803A4090
	public void set_submitButton(string value) { }

	// RVA: 0x3A3640 Offset: 0x3A1C40 VA: 0x1803A3640
	public string get_cancelButton() { }

	// RVA: 0x3A3E50 Offset: 0x3A2450 VA: 0x1803A3E50
	public void set_cancelButton(string value) { }

	// RVA: 0x3A32D0 Offset: 0x3A18D0 VA: 0x1803A32D0
	private void .ctor() { }

	// RVA: 0x39E220 Offset: 0x39C820 VA: 0x18039E220 Slot: 4
	protected override void Awake() { }

	// RVA: 0x3A3190 Offset: 0x3A1790 VA: 0x1803A3190 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x3A28D0 Offset: 0x3A0ED0 VA: 0x1803A28D0 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x39E140 Offset: 0x39C740 VA: 0x18039E140 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x39E590 Offset: 0x39CB90 VA: 0x18039E590 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x3A12D0 Offset: 0x39F8D0 VA: 0x1803A12D0 Slot: 17
	public override void Process() { }

	// RVA: 0x3A0040 Offset: 0x39E640 VA: 0x1803A0040
	private bool ProcessTouchEvents() { }

	// RVA: 0x3A0B10 Offset: 0x39F110 VA: 0x1803A0B10
	private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x3A1A30 Offset: 0x3A0030 VA: 0x1803A1A30
	private bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x39EA00 Offset: 0x39D000 VA: 0x18039EA00
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x3A1690 Offset: 0x39FC90 VA: 0x1803A1690
	private bool SendMoveEventToSelectedObject() { }

	// RVA: 0x39E300 Offset: 0x39C900 VA: 0x18039E300
	private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical) { }

	// RVA: 0x39F830 Offset: 0x39DE30 VA: 0x18039F830
	private void ProcessMouseEvents() { }

	// RVA: 0x39F450 Offset: 0x39DA50 VA: 0x18039F450
	private void ProcessMouseEvent(int playerId, int pointerIndex) { }

	// RVA: 0x3A1C90 Offset: 0x3A0290 VA: 0x1803A1C90
	private bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x39F9A0 Offset: 0x39DFA0 VA: 0x18039F9A0
	private void ProcessMousePress(RewiredPointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x39ED80 Offset: 0x39D380 VA: 0x18039ED80
	private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x39F2D0 Offset: 0x39D8D0 VA: 0x18039F2D0
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x3A30D0 Offset: 0x3A16D0 VA: 0x1803A30D0
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x39F2E0 Offset: 0x39D8E0 VA: 0x18039F2E0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x39F100 Offset: 0x39D700 VA: 0x18039F100 Slot: 28
	protected override bool IsDefaultPlayer(int playerId) { }

	// RVA: 0x39EF30 Offset: 0x39D530 VA: 0x18039EF30
	private void InitializeRewired() { }

	// RVA: 0x3A22A0 Offset: 0x3A08A0 VA: 0x1803A22A0
	private void SetupRewiredVars() { }

	// RVA: 0x3A2140 Offset: 0x3A0740 VA: 0x1803A2140
	private void SetUpRewiredPlayerMice() { }

	// RVA: 0x3A1DE0 Offset: 0x3A03E0 VA: 0x1803A1DE0
	private void SetUpRewiredActions() { }

	// RVA: 0x39E7D0 Offset: 0x39CDD0 VA: 0x18039E7D0
	private bool GetButton(Player player, int actionId) { }

	// RVA: 0x39E790 Offset: 0x39CD90 VA: 0x18039E790
	private bool GetButtonDown(Player player, int actionId) { }

	// RVA: 0x39E9C0 Offset: 0x39CFC0 VA: 0x18039E9C0
	private bool GetNegativeButton(Player player, int actionId) { }

	// RVA: 0x39E980 Offset: 0x39CF80 VA: 0x18039E980
	private bool GetNegativeButtonDown(Player player, int actionId) { }

	// RVA: 0x39E750 Offset: 0x39CD50 VA: 0x18039E750
	private float GetAxis(Player player, int actionId) { }

	// RVA: 0x39E4A0 Offset: 0x39CAA0 VA: 0x18039E4A0
	private void CheckEditorRecompile() { }

	// RVA: 0x39F3F0 Offset: 0x39D9F0 VA: 0x18039F3F0
	private void OnEditorRecompile() { }

	// RVA: 0x39E550 Offset: 0x39CB50 VA: 0x18039E550
	private void ClearRewiredVars() { }

	// RVA: 0x39E5B0 Offset: 0x39CBB0 VA: 0x18039E5B0
	private bool DidAnyMouseMove() { }

	// RVA: 0x39E810 Offset: 0x39CE10 VA: 0x18039E810
	private bool GetMouseButtonDownOnAnyMouse(int buttonIndex) { }

	// RVA: 0x39F440 Offset: 0x39DA40 VA: 0x18039F440
	private void OnRewiredInitialized() { }

	// RVA: 0x39E550 Offset: 0x39CB50 VA: 0x18039E550
	private void OnRewiredShutDown() { }
}

