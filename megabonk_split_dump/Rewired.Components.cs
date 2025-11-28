// Namespace: Rewired.Components
[AddComponentMenu("")]
[Serializable]
public abstract class ComponentWrapper<T> : MonoBehaviour // TypeDefIndex: 2697
{
	// Fields
	private T RIcIpFZaDiwCsxeGEBJGEBpbjJeO; // 0x0
	private bool HTqfQiJdoyPQveIKcGwoyxdOeLrZB; // 0x0

	// Properties
	protected T source { get; }
	protected bool initialized { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected T get_source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-ComponentWrapper<object>.get_source
	*/

	// RVA: -1 Offset: -1
	protected bool get_initialized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	|-ComponentWrapper<object>.get_initialized
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD134E0 Offset: 0xD11AE0 VA: 0x180D134E0
	|-ComponentWrapper<object>.Awake
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A460 Offset: 0x398A60 VA: 0x18039A460
	|-ComponentWrapper<object>.Start
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49D780 Offset: 0x49BD80 VA: 0x18049D780
	|-ComponentWrapper<object>.OnEnable
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13700 Offset: 0xD11D00 VA: 0x180D13700
	|-ComponentWrapper<object>.OnDisable
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x54A640 Offset: 0x548C40 VA: 0x18054A640
	|-ComponentWrapper<object>.OnDestroy
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49CF60 Offset: 0x49B560 VA: 0x18049CF60
	|-ComponentWrapper<object>.Reset
	*/

	[CustomObfuscation(rename = False)]
	// RVA: -1 Offset: -1
	private void OnValidate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13720 Offset: 0xD11D20 VA: 0x180D13720
	|-ComponentWrapper<object>.OnValidate
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void OnAwake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD135A0 Offset: 0xD11BA0 VA: 0x180D135A0
	|-ComponentWrapper<object>.OnAwake
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void OnAwakeFinished() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-ComponentWrapper<object>.OnAwakeFinished
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void OnStart() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-ComponentWrapper<object>.OnStart
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void OnEnabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-ComponentWrapper<object>.OnEnabled
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void OnDisabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-ComponentWrapper<object>.OnDisabled
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual void OnDestroyed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13650 Offset: 0xD11C50 VA: 0x180D13650
	|-ComponentWrapper<object>.OnDestroyed
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual void OnReset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-ComponentWrapper<object>.OnReset
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected virtual void OnValidated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-ComponentWrapper<object>.OnValidated
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13550 Offset: 0xD11B50 VA: 0x180D13550
	|-ComponentWrapper<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual bool TryInitialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13810 Offset: 0xD11E10 VA: 0x180D13810
	|-ComponentWrapper<object>.TryInitialize
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract T CreateSource(object args);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ComponentWrapper<object>.CreateSource
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract object GetCreateSourceArgs();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ComponentWrapper<object>.GetCreateSourceArgs
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual void PostInitialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13740 Offset: 0xD11D40 VA: 0x180D13740
	|-ComponentWrapper<object>.PostInitialize
	*/

	// RVA: -1 Offset: -1 Slot: 17
	protected virtual void Deinitialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13520 Offset: 0xD11B20 VA: 0x180D13520
	|-ComponentWrapper<object>.Deinitialize
	*/

	// RVA: -1 Offset: -1 Slot: 18
	protected virtual void Subscribe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13760 Offset: 0xD11D60 VA: 0x180D13760
	|-ComponentWrapper<object>.Subscribe
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected virtual void Unsubscribe() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD138B0 Offset: 0xD11EB0 VA: 0x180D138B0
	|-ComponentWrapper<object>.Unsubscribe
	*/

	// RVA: -1 Offset: -1
	private void wlAvpitoDxGDQglsAUNPgwWLoMah() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13970 Offset: 0xD11F70 VA: 0x180D13970
	|-ComponentWrapper<object>.wlAvpitoDxGDQglsAUNPgwWLoMah
	*/

	// RVA: -1 Offset: -1
	private void YLtFNCMGjCtqdvKwavFByoxJAYKo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13950 Offset: 0xD11F50 VA: 0x180D13950
	|-ComponentWrapper<object>.YLtFNCMGjCtqdvKwavFByoxJAYKo
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	|-ComponentWrapper<object>..ctor
	*/
}

// Namespace: Rewired.Components
[AddComponentMenu("Rewired/Player Controllers/Player Controller")]
[Serializable]
public class PlayerController : ComponentWrapper<PlayerController>, IPlayerController // TypeDefIndex: 2704
{
	// Fields
	[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Action ids, Player ids, etc.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private InputManager_Base _rewiredInputManager; // 0x30
	[Tooltip("The Player id of the Player used for the source of input.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _playerId; // 0x38
	[Tooltip("The elements that will be created in the controller.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private List<PlayerController.ElementInfo> _elements; // 0x40
	[Tooltip("Triggered the first frame the button is pressed or released.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private PlayerController.ButtonStateChangedHandler _onButtonStateChanged; // 0x48
	[Tooltip("Triggered when the axis value changes.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private PlayerController.AxisValueChangedHandler _onAxisValueChanged; // 0x50
	[Tooltip("Triggered when the controller is enabled or disabled.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private PlayerController.EnabledStateChangedHandler _onEnabledStateChanged; // 0x58

	// Properties
	public int playerId { get; set; }
	public IList<PlayerController.Button> buttons { get; }
	public IList<PlayerController.Axis> axes { get; }
	public IList<PlayerController.Element> elements { get; }
	public int buttonCount { get; }
	public int axisCount { get; }
	public int elementCount { get; }

	// Methods

	// RVA: 0x177C310 Offset: 0x177A910 VA: 0x18177C310 Slot: 22
	public int get_playerId() { }

	// RVA: 0x177CFF0 Offset: 0x177B5F0 VA: 0x18177CFF0 Slot: 23
	public void set_playerId(int value) { }

	// RVA: 0x177C1D0 Offset: 0x177A7D0 VA: 0x18177C1D0 Slot: 24
	public IList<PlayerController.Button> get_buttons() { }

	// RVA: 0x177C0A0 Offset: 0x177A6A0 VA: 0x18177C0A0 Slot: 25
	public IList<PlayerController.Axis> get_axes() { }

	// RVA: 0x177C2A0 Offset: 0x177A8A0 VA: 0x18177C2A0 Slot: 26
	public IList<PlayerController.Element> get_elements() { }

	// RVA: 0x177C170 Offset: 0x177A770 VA: 0x18177C170 Slot: 27
	public int get_buttonCount() { }

	// RVA: 0x177C110 Offset: 0x177A710 VA: 0x18177C110 Slot: 28
	public int get_axisCount() { }

	// RVA: 0x177C240 Offset: 0x177A840 VA: 0x18177C240 Slot: 29
	public int get_elementCount() { }

	// RVA: 0x177BFC0 Offset: 0x177A5C0 VA: 0x18177BFC0 Slot: 30
	public void add_ButtonStateChangedEvent(Action<int, bool> value) { }

	// RVA: 0x177CF10 Offset: 0x177B510 VA: 0x18177CF10 Slot: 31
	public void remove_ButtonStateChangedEvent(Action<int, bool> value) { }

	// RVA: 0x177BF50 Offset: 0x177A550 VA: 0x18177BF50 Slot: 32
	public void add_AxisValueChangedEvent(Action<int, float> value) { }

	// RVA: 0x177CEA0 Offset: 0x177B4A0 VA: 0x18177CEA0 Slot: 33
	public void remove_AxisValueChangedEvent(Action<int, float> value) { }

	// RVA: 0x177C030 Offset: 0x177A630 VA: 0x18177C030 Slot: 34
	public void add_EnabledStateChangedEvent(Action<bool> value) { }

	// RVA: 0x177CF80 Offset: 0x177B580 VA: 0x18177CF80 Slot: 35
	public void remove_EnabledStateChangedEvent(Action<bool> value) { }

	// RVA: 0x177B370 Offset: 0x1779970 VA: 0x18177B370 Slot: 36
	public bool GetButton(int index) { }

	// RVA: 0x177B290 Offset: 0x1779890 VA: 0x18177B290 Slot: 37
	public bool GetButtonDown(int index) { }

	// RVA: 0x177B300 Offset: 0x1779900 VA: 0x18177B300 Slot: 38
	public bool GetButtonUp(int index) { }

	// RVA: 0x177B220 Offset: 0x1779820 VA: 0x18177B220 Slot: 39
	public float GetAxis(int index) { }

	// RVA: 0x177B1B0 Offset: 0x17797B0 VA: 0x18177B1B0 Slot: 40
	public float GetAxisRaw(int index) { }

	// RVA: 0x177B3E0 Offset: 0x17799E0 VA: 0x18177B3E0 Slot: 41
	public PlayerController.Element GetElement(int index) { }

	// RVA: -1 Offset: -1 Slot: 42
	public T GetElement<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x749750 Offset: 0x747D50 VA: 0x180749750
	|-PlayerController.GetElement<object>
	*/

	// RVA: 0x177B4B0 Offset: 0x1779AB0 VA: 0x18177B4B0 Slot: 4
	protected override void OnAwake() { }

	// RVA: 0x177B450 Offset: 0x1779A50 VA: 0x18177B450 Slot: 5
	protected override void OnAwakeFinished() { }

	// RVA: 0x177B620 Offset: 0x1779C20 VA: 0x18177B620 Slot: 7
	protected override void OnEnabled() { }

	// RVA: 0x177B540 Offset: 0x1779B40 VA: 0x18177B540 Slot: 8
	protected override void OnDisabled() { }

	// RVA: 0x177B900 Offset: 0x1779F00 VA: 0x18177B900 Slot: 11
	protected override void OnValidated() { }

	// RVA: 0x177B700 Offset: 0x1779D00 VA: 0x18177B700 Slot: 10
	protected override void OnReset() { }

	// RVA: 0x177BAF0 Offset: 0x177A0F0 VA: 0x18177BAF0 Slot: 18
	protected override void Subscribe() { }

	// RVA: 0x177BC50 Offset: 0x177A250 VA: 0x18177BC50 Slot: 19
	protected override void Unsubscribe() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 15
	protected override object GetCreateSourceArgs() { }

	// RVA: 0x177AE40 Offset: 0x1779440 VA: 0x18177AE40 Slot: 14
	protected override PlayerController CreateSource(object args) { }

	// RVA: 0x177C4F0 Offset: 0x177AAF0 VA: 0x18177C4F0 Slot: 43
	internal virtual List<PlayerController.ElementInfo> kZPfxafqEeLOrsiTlcYkCgviCAklA() { }

	// RVA: 0x177C420 Offset: 0x177AA20 VA: 0x18177C420
	private void iluugqXajasbWDEpxzywVYQksKTV(int , bool ) { }

	// RVA: 0x177AD70 Offset: 0x1779370 VA: 0x18177AD70
	private void BFVAzpJNSUjfRHEzFapXbMNZriet(int , float ) { }

	// RVA: 0x177C370 Offset: 0x177A970 VA: 0x18177C370
	private void iPZNJZGqhHfQcaZDGKkJcSQBMinIA(bool ) { }

	// RVA: 0x177CE30 Offset: 0x177B430 VA: 0x18177CE30
	private void oMVKlsfAxWCvYEtuxGVZcVvIPOYEA() { }

	// RVA: 0x177BDB0 Offset: 0x177A3B0 VA: 0x18177BDB0
	public void .ctor() { }

	// RVA: 0x177BAD0 Offset: 0x177A0D0 VA: 0x18177BAD0 Slot: 20
	private bool Rewired.IPlayerController.get_enabled() { }

	// RVA: 0x177BAE0 Offset: 0x177A0E0 VA: 0x18177BAE0 Slot: 21
	private void Rewired.IPlayerController.set_enabled(bool value) { }
}

// Namespace: Rewired.Components
[AddComponentMenu("Rewired/Player Controllers/Player Mouse")]
[Serializable]
public sealed class PlayerMouse : PlayerController, IPlayerMouse, IPlayerController, IMouseInputSource // TypeDefIndex: 2706
{
	// Fields
	[Tooltip("If enabled, the screen position will default to the center of the allowed movement area. Otherwise, it will default to the lower-left corner of the allowed movement area.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _defaultToCenter; // 0x60
	[Tooltip("The pointer speed. This does not affect the speed of input from the mouse x/y axes if useHardwarePointerPosition is enabled. It only affects the speed from input sources other than mouse x/y or if mouse x/y are mapped to Actions assigned to Axes. ")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _pointerSpeed; // 0x64
	[Tooltip("If enabled, the hardware pointer position will be used for mouse input. Otherwise, the position of the pointer will be calculated only from the Axis Action values. The Player that owns this Player Mouse must have the physical mouse assigned to it in order for the hardware position to be used, ex: player.controllers.hasMouse == true.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _useHardwarePointerPosition; // 0x68
	[Tooltip("If enabled, movement will be clamped to the Movement Area.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _clampToMovementArea; // 0x69
	[Tooltip("The allowed movement area for the mouse pointer. Set Movement Area Unit to determine the data format of this value. This rect is a screen-space rect with 0, 0 at the lower-left corner.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private Rect _movementArea; // 0x6C
	[Tooltip("The unit format of the movement area. This is used to determine the data format of Movement Area.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private PlayerMouse.MovementAreaUnit _movementAreaUnit; // 0x7C
	[Tooltip("Triggered when the screen position changes. Link this to your pointer to drive its position.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private PlayerMouse.ScreenPositionChangedHandler _onScreenPositionChanged; // 0x80

	// Properties
	private PlayerMouse QMvsaYpPjhxAqyjvHaxZUBidklRb { get; }
	public bool defaultToCenter { get; set; }
	public bool clampToMovementArea { get; set; }
	public ScreenRect movementArea { get; set; }
	public PlayerMouse.MovementAreaUnit movementAreaUnit { get; set; }
	public Vector2 screenPosition { get; set; }
	public Vector2 screenPositionPrev { get; }
	public Vector2 screenPositionDelta { get; }
	public PlayerController.MouseAxis xAxis { get; }
	public PlayerController.MouseAxis yAxis { get; }
	public PlayerController.MouseWheel wheel { get; }
	public PlayerController.Button leftButton { get; }
	public PlayerController.Button rightButton { get; }
	public PlayerController.Button middleButton { get; }
	public float pointerSpeed { get; set; }
	public bool useHardwarePointerPosition { get; set; }
	private bool Rewired.UI.IMouseInputSource.enabled { get; }
	private Vector2 Rewired.UI.IMouseInputSource.screenPosition { get; }
	private Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta { get; }
	private Vector2 Rewired.UI.IMouseInputSource.wheelDelta { get; }
	private bool Rewired.UI.IMouseInputSource.locked { get; }

	// Methods

	// RVA: 0x17807B0 Offset: 0x177EDB0 VA: 0x1817807B0
	private PlayerMouse vSZKEoKbyvAijUCuiNRgpadyuJIf() { }

	// RVA: 0x177F510 Offset: 0x177DB10 VA: 0x18177F510 Slot: 44
	public bool get_defaultToCenter() { }

	// RVA: 0x177FFE0 Offset: 0x177E5E0 VA: 0x18177FFE0
	public void set_defaultToCenter(bool value) { }

	// RVA: 0x177F480 Offset: 0x177DA80 VA: 0x18177F480
	public bool get_clampToMovementArea() { }

	// RVA: 0x177FEA0 Offset: 0x177E4A0 VA: 0x18177FEA0
	public void set_clampToMovementArea(bool value) { }

	// RVA: 0x177F750 Offset: 0x177DD50 VA: 0x18177F750 Slot: 45
	public ScreenRect get_movementArea() { }

	// RVA: 0x1780260 Offset: 0x177E860 VA: 0x181780260 Slot: 46
	public void set_movementArea(ScreenRect value) { }

	// RVA: 0x177F6C0 Offset: 0x177DCC0 VA: 0x18177F6C0 Slot: 47
	public PlayerMouse.MovementAreaUnit get_movementAreaUnit() { }

	// RVA: 0x1780120 Offset: 0x177E720 VA: 0x181780120 Slot: 48
	public void set_movementAreaUnit(PlayerMouse.MovementAreaUnit value) { }

	// RVA: 0x177FAF0 Offset: 0x177E0F0 VA: 0x18177FAF0 Slot: 49
	public Vector2 get_screenPosition() { }

	// RVA: 0x1780640 Offset: 0x177EC40 VA: 0x181780640
	public void set_screenPosition(Vector2 value) { }

	// RVA: 0x177FA20 Offset: 0x177E020 VA: 0x18177FA20 Slot: 50
	public Vector2 get_screenPositionPrev() { }

	// RVA: 0x177F950 Offset: 0x177DF50 VA: 0x18177F950 Slot: 51
	public Vector2 get_screenPositionDelta() { }

	// RVA: 0x177FCE0 Offset: 0x177E2E0 VA: 0x18177FCE0 Slot: 52
	public PlayerController.MouseAxis get_xAxis() { }

	// RVA: 0x177FD70 Offset: 0x177E370 VA: 0x18177FD70 Slot: 53
	public PlayerController.MouseAxis get_yAxis() { }

	// RVA: 0x177FC50 Offset: 0x177E250 VA: 0x18177FC50 Slot: 54
	public PlayerController.MouseWheel get_wheel() { }

	// RVA: 0x177F5A0 Offset: 0x177DBA0 VA: 0x18177F5A0 Slot: 55
	public PlayerController.Button get_leftButton() { }

	// RVA: 0x177F8C0 Offset: 0x177DEC0 VA: 0x18177F8C0 Slot: 56
	public PlayerController.Button get_rightButton() { }

	// RVA: 0x177F630 Offset: 0x177DC30 VA: 0x18177F630 Slot: 57
	public PlayerController.Button get_middleButton() { }

	// RVA: 0x177F830 Offset: 0x177DE30 VA: 0x18177F830 Slot: 58
	public float get_pointerSpeed() { }

	// RVA: 0x1780520 Offset: 0x177EB20 VA: 0x181780520
	public void set_pointerSpeed(float value) { }

	// RVA: 0x177FBC0 Offset: 0x177E1C0 VA: 0x18177FBC0 Slot: 59
	public bool get_useHardwarePointerPosition() { }

	// RVA: 0x1780710 Offset: 0x177ED10 VA: 0x181780710
	public void set_useHardwarePointerPosition(bool value) { }

	// RVA: 0x177F3E0 Offset: 0x177D9E0 VA: 0x18177F3E0 Slot: 60
	public void add_ScreenPositionChangedEvent(Action<Vector2> value) { }

	// RVA: 0x177FE00 Offset: 0x177E400 VA: 0x18177FE00 Slot: 61
	public void remove_ScreenPositionChangedEvent(Action<Vector2> value) { }

	// RVA: 0x177E0A0 Offset: 0x177C6A0 VA: 0x18177E0A0 Slot: 11
	protected override void OnValidated() { }

	// RVA: 0x177DFF0 Offset: 0x177C5F0 VA: 0x18177DFF0 Slot: 10
	protected override void OnReset() { }

	// RVA: 0x177D140 Offset: 0x177B740 VA: 0x18177D140 Slot: 14
	protected override PlayerController CreateSource(object args) { }

	// RVA: 0x177D570 Offset: 0x177BB70 VA: 0x18177D570 Slot: 17
	protected override void Deinitialize() { }

	// RVA: 0x177ECE0 Offset: 0x177D2E0 VA: 0x18177ECE0 Slot: 18
	protected override void Subscribe() { }

	// RVA: 0x177EF50 Offset: 0x177D550 VA: 0x18177EF50 Slot: 19
	protected override void Unsubscribe() { }

	// RVA: 0x177D5B0 Offset: 0x177BBB0 VA: 0x18177D5B0 Slot: 43
	internal override List<PlayerController.ElementInfo> HWUHRVMkFdqcJRiPBYrZtOMOBZYDA() { }

	// RVA: 0x177EBF0 Offset: 0x177D1F0 VA: 0x18177EBF0
	private void STEHoDgxmlszagNPvGchjBKWaLHV(Vector2 ) { }

	// RVA: 0x177E7F0 Offset: 0x177CDF0 VA: 0x18177E7F0 Slot: 63
	private bool Rewired.UI.IMouseInputSource.get_enabled() { }

	// RVA: 0x177E5B0 Offset: 0x177CBB0 VA: 0x18177E5B0 Slot: 66
	private bool Rewired.UI.IMouseInputSource.GetButtonDown(int button) { }

	// RVA: 0x177E670 Offset: 0x177CC70 VA: 0x18177E670 Slot: 67
	private bool Rewired.UI.IMouseInputSource.GetButtonUp(int button) { }

	// RVA: 0x177E730 Offset: 0x177CD30 VA: 0x18177E730 Slot: 68
	private bool Rewired.UI.IMouseInputSource.GetButton(int button) { }

	// RVA: 0x177EA30 Offset: 0x177D030 VA: 0x18177EA30 Slot: 69
	private Vector2 Rewired.UI.IMouseInputSource.get_screenPosition() { }

	// RVA: 0x177E950 Offset: 0x177CF50 VA: 0x18177E950 Slot: 70
	private Vector2 Rewired.UI.IMouseInputSource.get_screenPositionDelta() { }

	// RVA: 0x177EB10 Offset: 0x177D110 VA: 0x18177EB10 Slot: 71
	private Vector2 Rewired.UI.IMouseInputSource.get_wheelDelta() { }

	// RVA: 0x177E8A0 Offset: 0x177CEA0 VA: 0x18177E8A0 Slot: 64
	private bool Rewired.UI.IMouseInputSource.get_locked() { }

	// RVA: 0x177F1C0 Offset: 0x177D7C0 VA: 0x18177F1C0
	public void .ctor() { }

	// RVA: 0x177BAD0 Offset: 0x177A0D0 VA: 0x18177BAD0 Slot: 20
	private bool Rewired.IPlayerController.get_enabled() { }

	// RVA: 0x177BAE0 Offset: 0x177A0E0 VA: 0x18177BAE0 Slot: 21
	private void Rewired.IPlayerController.set_enabled(bool value) { }
}

