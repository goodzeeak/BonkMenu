// Namespace: Rewired.ComponentControls.Effects
[AddComponentMenu("Rewired/Touch Controls/Effects/Rotate Around Axis")]
public class RotateAroundAxis : MonoBehaviour // TypeDefIndex: 2775
{
	// Fields
	[Tooltip("The current speed of rotation.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private RotateAroundAxis.Speed _speed; // 0x20
	[Tooltip("The speed of rotation when Speed is set to Slow. This measured in degrees per second.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _slowRotationSpeed; // 0x24
	[Tooltip("The speed of rotation when Speed is set to Fast. This measured in degrees per second.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _fastRotationSpeed; // 0x28
	[Tooltip("The axis around which rotation will occur.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private RotateAroundAxis.RotationAxis _rotateAroundAxis; // 0x2C
	[Tooltip("The space in which rotation will occur.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private Space _relativeTo; // 0x30
	[Tooltip("Reverses the rotation direction.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _reverse; // 0x34

	// Properties
	public RotateAroundAxis.Speed speed { get; set; }
	public float slowRotationSpeed { get; set; }
	public float fastRotationSpeed { get; set; }
	public RotateAroundAxis.RotationAxis rotateAroundAxis { get; set; }
	public Space relativeTo { get; set; }
	public bool reverse { get; set; }

	// Methods

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public RotateAroundAxis.Speed get_speed() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_speed(RotateAroundAxis.Speed value) { }

	// RVA: 0x3CB490 Offset: 0x3C9A90 VA: 0x1803CB490
	public float get_slowRotationSpeed() { }

	// RVA: 0x3CB500 Offset: 0x3C9B00 VA: 0x1803CB500
	public void set_slowRotationSpeed(float value) { }

	// RVA: 0x3CB4A0 Offset: 0x3C9AA0 VA: 0x1803CB4A0
	public float get_fastRotationSpeed() { }

	// RVA: 0x3CB510 Offset: 0x3C9B10 VA: 0x1803CB510
	public void set_fastRotationSpeed(float value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public RotateAroundAxis.RotationAxis get_rotateAroundAxis() { }

	// RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	public void set_rotateAroundAxis(RotateAroundAxis.RotationAxis value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public Space get_relativeTo() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	public void set_relativeTo(Space value) { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_reverse() { }

	// RVA: 0x16A5170 Offset: 0x16A3770 VA: 0x1816A5170
	public void set_reverse(bool value) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179A9D0 Offset: 0x1798FD0 VA: 0x18179A9D0
	private void Update() { }

	// RVA: 0x179AB40 Offset: 0x1799140 VA: 0x18179AB40
	private static Vector3 pufSmofQKcThwMjXymcWZiJvqAGV(RotateAroundAxis.RotationAxis ) { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void SetSpeed(RotateAroundAxis.Speed speed) { }

	// RVA: 0x179A910 Offset: 0x1798F10 VA: 0x18179A910
	public void SetSpeed(int speed) { }

	// RVA: 0x179AB10 Offset: 0x1799110 VA: 0x18179AB10
	public void .ctor() { }
}

// Namespace: Rewired.ComponentControls.Effects
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Touch Controls/Effects/Touch Interactable Transitioner")]
public sealed class TouchInteractableTransitioner : MonoBehaviour, IVisibilityChangedHandler, TouchInteractable.IInteractionStateTransitionHandler // TypeDefIndex: 2776
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Toggles visibility. An invisible control can still be interacted with. This property only has any effect when used with an Image Component.")]
	private bool _visible; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The transition type(s) to be used when transitioning to various states. Multiple transition types can be used simultaneously.")]
	[Bitmask(typeof(TouchInteractable.TransitionTypeFlags))]
	private TouchInteractable.TransitionTypeFlags _transitionType; // 0x24
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Settings using for Color Tint transitions.")]
	private ColorBlock _transitionColorTint; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Settings using for Sprite State transitions.")]
	private SpriteState _transitionSpriteState; // 0x80
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Settings using for Animation Trigger transitions.")]
	private AnimationTriggers _transitionAnimationTriggers; // 0xA0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The target Graphic component for interaction state transitions. This should normally be set to an Image component on this GameObject.")]
	private Graphic _targetGraphic; // 0xA8
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Toggles whether the fade duration is set by incoming transition events. If enabled, the duration of fades for visibility and Color Tint transitions will be synchronized with the event sender.")]
	private bool _syncFadeDurationWithTransitionEvent; // 0xB0
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Toggles whether the color tint is set by incoming transition events. If enabled, the color tint transition of the event sender will override any color tint setting here. This setting overrides Sync Fade Duration With Transition Event.")]
	private bool _syncColorTintWithTransitionEvent; // 0xB1
	private TouchInteractable.InteractionState ZMqfOZHMIYasPJiblVgoRqEcsNhBb; // 0xB4

	// Properties
	public bool visible { get; set; }
	public TouchInteractable.TransitionTypeFlags transitionType { get; set; }
	public ColorBlock transitionColorTint { get; set; }
	public SpriteState transitionSpriteState { get; set; }
	public AnimationTriggers transitionAnimationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public bool syncFadeDurationWithTransitionEvent { get; set; }
	public bool syncColorTintWithTransitionEvent { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_visible() { }

	// RVA: 0x179DD10 Offset: 0x179C310 VA: 0x18179DD10
	public void set_visible(bool value) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public TouchInteractable.TransitionTypeFlags get_transitionType() { }

	// RVA: 0x179EB50 Offset: 0x179D150 VA: 0x18179EB50
	public void set_transitionType(TouchInteractable.TransitionTypeFlags value) { }

	// RVA: 0x179E630 Offset: 0x179CC30 VA: 0x18179E630
	public ColorBlock get_transitionColorTint() { }

	// RVA: 0x179E9F0 Offset: 0x179CFF0 VA: 0x18179E9F0
	public void set_transitionColorTint(ColorBlock value) { }

	// RVA: 0x179E670 Offset: 0x179CC70 VA: 0x18179E670
	public SpriteState get_transitionSpriteState() { }

	// RVA: 0x179EA80 Offset: 0x179D080 VA: 0x18179EA80
	public void set_transitionSpriteState(SpriteState value) { }

	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public AnimationTriggers get_transitionAnimationTriggers() { }

	// RVA: 0x179E960 Offset: 0x179CF60 VA: 0x18179E960
	public void set_transitionAnimationTriggers(AnimationTriggers value) { }

	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	public Graphic get_targetGraphic() { }

	// RVA: 0x179E880 Offset: 0x179CE80 VA: 0x18179E880
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x1641010 Offset: 0x163F610 VA: 0x181641010
	public bool get_syncFadeDurationWithTransitionEvent() { }

	// RVA: 0x179E800 Offset: 0x179CE00 VA: 0x18179E800
	public void set_syncFadeDurationWithTransitionEvent(bool value) { }

	// RVA: 0x1641090 Offset: 0x163F690 VA: 0x181641090
	public bool get_syncColorTintWithTransitionEvent() { }

	// RVA: 0x179E780 Offset: 0x179CD80 VA: 0x18179E780
	public void set_syncColorTintWithTransitionEvent(bool value) { }

	// RVA: 0x179E5A0 Offset: 0x179CBA0 VA: 0x18179E5A0
	public Image get_image() { }

	// RVA: 0x179E6A0 Offset: 0x179CCA0 VA: 0x18179E6A0
	public void set_image(Image value) { }

	// RVA: 0x179E550 Offset: 0x179CB50 VA: 0x18179E550
	public Animator get_animator() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179E200 Offset: 0x179C800 VA: 0x18179E200
	private void .ctor() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179D6E0 Offset: 0x179BCE0 VA: 0x18179D6E0
	private void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179D950 Offset: 0x179BF50 VA: 0x18179D950
	private void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179D840 Offset: 0x179BE40 VA: 0x18179D840
	private void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179DB30 Offset: 0x179C130 VA: 0x18179DB30
	private void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179DD90 Offset: 0x179C390 VA: 0x18179DD90
	private void Reset() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179D7E0 Offset: 0x179BDE0 VA: 0x18179D7E0
	private void OnCanvasGroupWasChanged() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179D7E0 Offset: 0x179BDE0 VA: 0x18179D7E0
	private void OnAnimationPropertiesWereApplied() { }

	// RVA: 0x179D7E0 Offset: 0x179BDE0 VA: 0x18179D7E0
	private void imUjzMsgdxIgPDXUygsznSIAXEAf() { }

	// RVA: 0x179D7E0 Offset: 0x179BDE0 VA: 0x18179D7E0
	private void OHsdITfZrGKTtltvIWFbUjMiUWjH() { }

	// RVA: 0x179D7C0 Offset: 0x179BDC0 VA: 0x18179D7C0
	private void DzbfmzxPhyYkZaQtCYnYZMFirymm(bool ) { }

	// RVA: 0x179E690 Offset: 0x179CC90 VA: 0x18179E690
	private void kJHYTZCmwTXnVhOrFTsIiCMguxhj(bool , bool ) { }

	// RVA: 0x179EBD0 Offset: 0x179D1D0 VA: 0x18179EBD0
	private bool ulLonZHWZkdlmaCmKrBuzfaTkRGp() { }

	// RVA: 0x179D840 Offset: 0x179BE40 VA: 0x18179D840
	private void vbGPpNrxFbVExVFTdLXytTASFIwA() { }

	// RVA: 0x179DE00 Offset: 0x179C400 VA: 0x18179DE00
	private void SYJcMLlIxTuYyuKhfBBoMfokGXuBA(TouchInteractable.InteractionState , bool ) { }

	// RVA: 0x179EC20 Offset: 0x179D220 VA: 0x18179EC20
	private void wvhJboyQzQucMqptfKxpXythouDT(Color , bool ) { }

	// RVA: 0x179E160 Offset: 0x179C760 VA: 0x18179E160
	private void TmxnLBFFnsrLuujZuOWFZhJjipeR(Sprite ) { }

	// RVA: 0x179E2F0 Offset: 0x179C8F0 VA: 0x18179E2F0
	private void celTFUeKjxEhZbCUUmdODCRjmcxTb(string ) { }

	// RVA: 0x179D9C0 Offset: 0x179BFC0 VA: 0x18179D9C0 Slot: 5
	public void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs args) { }

	// RVA: 0x179DD10 Offset: 0x179C310 VA: 0x18179DD10 Slot: 4
	public void OnVisibilityChanged(bool state) { }
}

// Namespace: Rewired.ComponentControls.Effects
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(Image))]
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Touch Controls/Effects/Touch Joystick Angle Indicator")]
public sealed class TouchJoystickAngleIndicator : MonoBehaviour, IVisibilityChangedHandler, TouchJoystick.IStickPositionChangedHandler // TypeDefIndex: 2777
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Toggles visibility.")]
	private bool _visible; // 0x20
	[Tooltip("If enabled, the target angle will be determined by the transform's Local Rotation Z. Otherwise, the activation angle must be manually set.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _targetAngleFromRotation; // 0x21
	[Tooltip("The joystick angle at which this object should be considered fully active.
0 = up with negative values increase rotating clockwise. Example: -45 degrees = up-right.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0, -360)]
	private float _targetAngle; // 0x24
	[Tooltip("If enabled, the color will fade in and out based on the current joystick value.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _fadeWithValue; // 0x28
	[Tooltip("If enabled, the color will fade in and out based on the current joystick angle. As the angle approaches the Target Angle, the color will become more intense.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _fadeWithAngle; // 0x29
	[Tooltip("The angle of rotation away from the Target Angle where the color fully fades out. If Fade with Angle is enabled, this is used to determine when the color will fully fade out when the joystick angle rotates away from the the Target Angle. This should be set to 1/2 of the complete rotation arc. Example: A value of 45 degrees would make the color fully fade out when the joystick angle is 45 degrees away from the Target Angle on either side, giving a complete arc of 90 degrees.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Range(0, 360)]
	private float _fadeRange; // 0x2C
	[Tooltip("The color when fully active.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private Color _activeColor; // 0x30
	[Tooltip("The color when not active.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private Color _normalColor; // 0x40
	private Image uJvqIMWeNXtWCTUSUfHYulLsCjkDA; // 0x50
	private RectTransform nRBBiJhmiYDgttPiaPZmekohjTjfb; // 0x58
	private Vector2 xuhsvdUAcVryowDvSQZPFqgPjLK; // 0x60
	private bool EYCGYXDCdQGRxlCdKLCKNdvxbDgDA; // 0x68
	private IRegistrar<TouchJoystickAngleIndicator> lGBmCFWLFfwgSeuPTtfioZcuHZBU; // 0x70

	// Properties
	public bool visible { get; set; }
	public bool targetAngleFromRotation { get; set; }
	public float targetAngle { get; set; }
	public bool fadeWithValue { get; set; }
	public bool fadeWithAngle { get; set; }
	public float fadeRange { get; set; }
	public Color activeColor { get; set; }
	public Color normalColor { get; set; }
	internal Image OYeDppMXGhacZqzIUmiWLUxltDpH { get; }
	internal Sprite SaGvOLyOJtVfetMEqCZJhQbefCiAb { get; }
	internal RectTransform atyICacHVimqcWZZAaMhdIvzkqVf { get; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_visible() { }

	// RVA: 0x179FAB0 Offset: 0x179E0B0 VA: 0x18179FAB0
	public void set_visible(bool value) { }

	// RVA: 0x38E1B0 Offset: 0x38C7B0 VA: 0x18038E1B0
	public bool get_targetAngleFromRotation() { }

	// RVA: 0x179FA80 Offset: 0x179E080 VA: 0x18179FA80
	public void set_targetAngleFromRotation(bool value) { }

	// RVA: 0x179F990 Offset: 0x179DF90 VA: 0x18179F990
	public float get_targetAngle() { }

	// RVA: 0x179FA90 Offset: 0x179E090 VA: 0x18179FA90
	public void set_targetAngle(float value) { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_fadeWithValue() { }

	// RVA: 0x1796560 Offset: 0x1794B60 VA: 0x181796560
	public void set_fadeWithValue(bool value) { }

	// RVA: 0x179F980 Offset: 0x179DF80 VA: 0x18179F980
	public bool get_fadeWithAngle() { }

	// RVA: 0x179FA70 Offset: 0x179E070 VA: 0x18179FA70
	public void set_fadeWithAngle(bool value) { }

	// RVA: 0x4877C0 Offset: 0x485DC0 VA: 0x1804877C0
	public float get_fadeRange() { }

	// RVA: 0x179FA50 Offset: 0x179E050 VA: 0x18179FA50
	public void set_fadeRange(float value) { }

	// RVA: 0x16AF8F0 Offset: 0x16ADEF0 VA: 0x1816AF8F0
	public Color get_activeColor() { }

	// RVA: 0x16F38C0 Offset: 0x16F1EC0 VA: 0x1816F38C0
	public void set_activeColor(Color value) { }

	// RVA: 0xAC52A0 Offset: 0xAC38A0 VA: 0x180AC52A0
	public Color get_normalColor() { }

	// RVA: 0xAC52D0 Offset: 0xAC38D0 VA: 0x180AC52D0
	public void set_normalColor(Color value) { }

	// RVA: 0x179ED70 Offset: 0x179D370 VA: 0x18179ED70
	internal Image FrNKYTywpovBomnekWBYkTEzRGHv() { }

	// RVA: 0x179F860 Offset: 0x179DE60 VA: 0x18179F860
	internal Sprite fhvAtNeKqXlBgAsYwbbpjrkwXyLZA() { }

	// RVA: 0x179F7D0 Offset: 0x179DDD0 VA: 0x18179F7D0
	internal RectTransform eHdUjtmElsiUxezyZRNYtbFFhhmI() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179F7A0 Offset: 0x179DDA0 VA: 0x18179F7A0
	private void .ctor() { }

	// RVA: 0x179EDE0 Offset: 0x179D3E0 VA: 0x18179EDE0
	internal bool JmvJtEuDthiptbrZxVxuwWiQFDte(out Vector2 ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179ED10 Offset: 0x179D310 VA: 0x18179ED10
	private void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179EF80 Offset: 0x179D580 VA: 0x18179EF80
	private void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179EF70 Offset: 0x179D570 VA: 0x18179EF70
	private void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179F0C0 Offset: 0x179D6C0 VA: 0x18179F0C0
	private void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179F0B0 Offset: 0x179D6B0 VA: 0x18179F0B0
	private void OnTransformParentChanged() { }

	// RVA: 0x179F610 Offset: 0x179DC10 VA: 0x18179F610
	private void RtVSUPFbhnOaITGGIBDCsuPOFkte(bool , bool ) { }

	// RVA: 0x179F120 Offset: 0x179D720 VA: 0x18179F120
	private void OosDWSDEOqAalGcEPoywMuWtYhAB(Vector2 ) { }

	// RVA: 0x179FAD0 Offset: 0x179E0D0 VA: 0x18179FAD0
	private void ulNayiXhWvETCqeDFCcqJwwHfeTo() { }

	// RVA: 0x179F840 Offset: 0x179DE40 VA: 0x18179F840
	private void fPtEjrtzzettgFDLnHBQKItkatwb() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void PMWFLbkRKeVkjsFsFIFvRyViFjzB() { }

	// RVA: 0x179F6D0 Offset: 0x179DCD0 VA: 0x18179F6D0
	private void SkCiUWeKVCHYSvybqBASeZxVMwvs() { }

	// RVA: 0x179F9D0 Offset: 0x179DFD0 VA: 0x18179F9D0
	private void neqcPYdmoKFkOqszTxzpIcQDwtlH() { }

	// RVA: 0x179F110 Offset: 0x179D710 VA: 0x18179F110 Slot: 4
	public void OnVisibilityChanged(bool state) { }

	// RVA: 0x179F000 Offset: 0x179D600 VA: 0x18179F000
	public void OnTouchJoystickStickPositionChanged(Vector2 value) { }

	// RVA: 0x179F600 Offset: 0x179DC00 VA: 0x18179F600 Slot: 5
	private void Rewired.ComponentControls.TouchJoystick.IStickPositionChangedHandler.OnStickPositionChanged(Vector2 value) { }
}

// Namespace: Rewired.ComponentControls.Effects
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
[AddComponentMenu("Rewired/Touch Controls/Effects/Touch Joystick Radial Indicator")]
public sealed class TouchJoystickRadialIndicator : MonoBehaviour, IRegistrar<TouchJoystickAngleIndicator> // TypeDefIndex: 2778
{
	// Fields
	[Tooltip("If enabled, the indicators will be scaled based on the size of the RectTransform.")]
	public bool _scale; // 0x20
	[Tooltip("If enabled, the aspect ratio will be determined from the Sprite's texture.")]
	public bool _preserveSpriteAspectRatio; // 0x21
	[Tooltip("The scale ratio of the indicators to the current RectTransform's height. A ratio of 0.1 means the indicator will be 0.1 times the size of the RectTransform's height. This is useful if you need to be able to scale the transform and have the indicators also scale with it.")]
	[Range(0.01, 1)]
	public float _scaleRatio; // 0x24
	[Tooltip("The horizontal component of the desired aspect ratio of the indicator.")]
	[Range(0.01, 10)]
	public float _aspectRatioX; // 0x28
	[Tooltip("The vertical component of the desired aspect ratio of the indicator.")]
	[Range(0.01, 10)]
	public float _aspectRatioY; // 0x2C
	[Tooltip("Offsets the indicator position up by this proportion of its height. 1.0 = 1 unit high offset.")]
	public float _offset; // 0x30
	private static readonly Vector2 XKunTWSwuTQkRNssEGpQffKAYUoO; // 0x0
	private RectTransform dYPcNHqOIQUVbqgJsZtfCOsVKqCi; // 0x38
	private List<TouchJoystickAngleIndicator> ehemcpiqYAfErhDglWdvkMfQkzZd; // 0x40

	// Properties
	public bool scale { get; set; }
	public bool preserveSpriteAspectRatio { get; set; }
	public float scaleRatio { get; set; }
	public float aspectRatioX { get; set; }
	public float aspectRatioY { get; set; }
	public float offset { get; set; }
	private RectTransform dXkAPGkafARYYJTIaIFwxKpSyvmjA { get; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_scale() { }

	// RVA: 0x17A0780 Offset: 0x179ED80 VA: 0x1817A0780
	public void set_scale(bool value) { }

	// RVA: 0x38E1B0 Offset: 0x38C7B0 VA: 0x18038E1B0
	public bool get_preserveSpriteAspectRatio() { }

	// RVA: 0x17A0720 Offset: 0x179ED20 VA: 0x1817A0720
	public void set_preserveSpriteAspectRatio(bool value) { }

	// RVA: 0x3CB490 Offset: 0x3C9A90 VA: 0x1803CB490
	public float get_scaleRatio() { }

	// RVA: 0x17A0730 Offset: 0x179ED30 VA: 0x1817A0730
	public void set_scaleRatio(float value) { }

	// RVA: 0x3CB4A0 Offset: 0x3C9AA0 VA: 0x1803CB4A0
	public float get_aspectRatioX() { }

	// RVA: 0x17A0660 Offset: 0x179EC60 VA: 0x1817A0660
	public void set_aspectRatioX(float value) { }

	// RVA: 0x4877C0 Offset: 0x485DC0 VA: 0x1804877C0
	public float get_aspectRatioY() { }

	// RVA: 0x17A06B0 Offset: 0x179ECB0 VA: 0x1817A06B0
	public void set_aspectRatioY(float value) { }

	// RVA: 0x420BC0 Offset: 0x41F1C0 VA: 0x180420BC0
	public float get_offset() { }

	// RVA: 0x17A0700 Offset: 0x179ED00 VA: 0x1817A0700
	public void set_offset(float value) { }

	// RVA: 0x17A0790 Offset: 0x179ED90 VA: 0x1817A0790
	private RectTransform wCXoOLIjTvBzpGFHvYCaaPesiWVt() { }

	// RVA: 0x179FE80 Offset: 0x179E480 VA: 0x18179FE80 Slot: 4
	private void Rewired.Utils.Interfaces.IRegistrar<Rewired.ComponentControls.Effects.TouchJoystickAngleIndicator>.Register(TouchJoystickAngleIndicator registrant) { }

	// RVA: 0x179FDF0 Offset: 0x179E3F0 VA: 0x18179FDF0 Slot: 5
	private void Rewired.Utils.Interfaces.IRegistrar<Rewired.ComponentControls.Effects.TouchJoystickAngleIndicator>.Deregister(TouchJoystickAngleIndicator registrant) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179FAE0 Offset: 0x179E0E0 VA: 0x18179FAE0
	private void Update() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179FB50 Offset: 0x179E150 VA: 0x18179FB50
	private void OnValidate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179FAE0 Offset: 0x179E0E0 VA: 0x18179FAE0
	private void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x179FAF0 Offset: 0x179E0F0 VA: 0x18179FAF0
	private void OnDestroy() { }

	// RVA: 0x179FCB0 Offset: 0x179E2B0 VA: 0x18179FCB0
	private void OqwzIrbKicyJEdEDafAkIHkNncckA() { }

	// RVA: 0x17A0140 Offset: 0x179E740 VA: 0x1817A0140
	private void eAmkjYTIGNjyzgEYdrtosmUOtMBiA(TouchJoystickAngleIndicator ) { }

	// RVA: 0x179FAE0 Offset: 0x179E0E0 VA: 0x18179FAE0
	private void CSaqPGsOycpMpEPAZBFbBUkLFaIN() { }

	// RVA: 0x179FF20 Offset: 0x179E520 VA: 0x18179FF20
	private void SlZijVGhsrZLDuRZBrQoZtKCDVIt() { }

	// RVA: 0x17A00A0 Offset: 0x179E6A0 VA: 0x1817A00A0
	public void .ctor() { }

	// RVA: 0x17A0060 Offset: 0x179E660 VA: 0x1817A0060
	private static void .cctor() { }
}

