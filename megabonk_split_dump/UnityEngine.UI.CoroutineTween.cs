// Namespace: UnityEngine.UI.CoroutineTween
internal interface ITweenValue // TypeDefIndex: 12228
{
	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget();
}

// Namespace: UnityEngine.UI.CoroutineTween
internal struct ColorTween : ITweenValue // TypeDefIndex: 12231
{
	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x1105D70 Offset: 0x1104370 VA: 0x181105D70
	public Color get_startColor() { }

	// RVA: 0x14DAB30 Offset: 0x14D9130 VA: 0x1814DAB30
	public void set_startColor(Color value) { }

	// RVA: 0x8641A0 Offset: 0x8627A0 VA: 0x1808641A0
	public Color get_targetColor() { }

	// RVA: 0x14DAB50 Offset: 0x14D9150 VA: 0x1814DAB50
	public void set_targetColor(Color value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x4877C0 Offset: 0x485DC0 VA: 0x1804877C0 Slot: 6
	public float get_duration() { }

	// RVA: 0x1853730 Offset: 0x1851D30 VA: 0x181853730
	public void set_duration(float value) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x266E3D0 Offset: 0x266C9D0 VA: 0x18266E3D0 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x266E310 Offset: 0x266C910 VA: 0x18266E310
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool GetIgnoreTimescale() { }

	// RVA: 0x4877C0 Offset: 0x485DC0 VA: 0x1804877C0
	public float GetDuration() { }

	// RVA: 0x1575E10 Offset: 0x1574410 VA: 0x181575E10 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: UnityEngine.UI.CoroutineTween
internal struct FloatTween : ITweenValue // TypeDefIndex: 12233
{
	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x1105EF0 Offset: 0x11044F0 VA: 0x181105EF0
	public float get_startValue() { }

	// RVA: 0x1947EA0 Offset: 0x19464A0 VA: 0x181947EA0
	public void set_startValue(float value) { }

	// RVA: 0x19477A0 Offset: 0x1945DA0 VA: 0x1819477A0
	public float get_targetValue() { }

	// RVA: 0x1947A90 Offset: 0x1946090 VA: 0x181947A90
	public void set_targetValue(float value) { }

	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0 Slot: 6
	public float get_duration() { }

	// RVA: 0x4722B0 Offset: 0x4708B0 VA: 0x1804722B0
	public void set_duration(float value) { }

	// RVA: 0xC1EE00 Offset: 0xC1D400 VA: 0x180C1EE00 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1453DF0 Offset: 0x14523F0 VA: 0x181453DF0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x2672900 Offset: 0x2670F00 VA: 0x182672900 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x2672840 Offset: 0x2670E40 VA: 0x182672840
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0xC1EE00 Offset: 0xC1D400 VA: 0x180C1EE00
	public bool GetIgnoreTimescale() { }

	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	public float GetDuration() { }

	// RVA: 0x1575E10 Offset: 0x1574410 VA: 0x181575E10 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: UnityEngine.UI.CoroutineTween
internal class TweenRunner<T> // TypeDefIndex: 12235
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	[IteratorStateMachine(typeof(TweenRunner.<Start>d__2<T>))]
	// RVA: -1 Offset: -1
	private static IEnumerator Start(T tweenInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6D3F0 Offset: 0xA6B9F0 VA: 0x180A6D3F0
	|-TweenRunner<ColorTween>.Start
	|
	|-RVA: 0xA6D1C0 Offset: 0xA6B7C0 VA: 0x180A6D1C0
	|-TweenRunner<FloatTween>.Start
	|
	|-RVA: 0xA6D280 Offset: 0xA6B880 VA: 0x180A6D280
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Start
	*/

	// RVA: -1 Offset: -1
	public void Init(MonoBehaviour coroutineContainer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-TweenRunner<ColorTween>.Init
	|-TweenRunner<FloatTween>.Init
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Init
	*/

	// RVA: -1 Offset: -1
	public void StartTween(T info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6C6A0 Offset: 0xA6ACA0 VA: 0x180A6C6A0
	|-TweenRunner<ColorTween>.StartTween
	|
	|-RVA: 0xA6CB40 Offset: 0xA6B140 VA: 0x180A6CB40
	|-TweenRunner<FloatTween>.StartTween
	|
	|-RVA: 0xA6C8E0 Offset: 0xA6AEE0 VA: 0x180A6C8E0
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StartTween
	*/

	// RVA: -1 Offset: -1
	public void StopTween() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6D4C0 Offset: 0xA6BAC0 VA: 0x180A6D4C0
	|-TweenRunner<ColorTween>.StopTween
	|-TweenRunner<FloatTween>.StopTween
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StopTween
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-TweenRunner<ColorTween>..ctor
	|-TweenRunner<FloatTween>..ctor
	|-TweenRunner<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

