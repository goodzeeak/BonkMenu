// Namespace: UnityEngine.UIElements.Experimental
public static class Easing // TypeDefIndex: 4559
{
	// Methods

	// RVA: 0x5EFE00 Offset: 0x5EE400 VA: 0x1805EFE00
	public static float Linear(float t) { }

	// RVA: 0x253C5E0 Offset: 0x253ABE0 VA: 0x18253C5E0
	public static float InSine(float t) { }

	// RVA: 0x253C860 Offset: 0x253AE60 VA: 0x18253C860
	public static float OutSine(float t) { }

	// RVA: 0x253C590 Offset: 0x253AB90 VA: 0x18253C590
	public static float InOutSine(float t) { }

	// RVA: 0x253C5D0 Offset: 0x253ABD0 VA: 0x18253C5D0
	public static float InQuad(float t) { }

	// RVA: 0x253C840 Offset: 0x253AE40 VA: 0x18253C840
	public static float OutQuad(float t) { }

	// RVA: 0x253C540 Offset: 0x253AB40 VA: 0x18253C540
	public static float InOutQuad(float t) { }

	// RVA: 0x253BF90 Offset: 0x253A590 VA: 0x18253BF90
	public static float InCubic(float t) { }

	// RVA: 0x253C720 Offset: 0x253AD20 VA: 0x18253C720
	public static float OutCubic(float t) { }

	// RVA: 0x253C320 Offset: 0x253A920 VA: 0x18253C320
	public static float InOutCubic(float t) { }

	// RVA: 0x253C5C0 Offset: 0x253ABC0 VA: 0x18253C5C0
	public static float InPower(float t, int power) { }

	// RVA: 0x253C7F0 Offset: 0x253ADF0 VA: 0x18253C7F0
	public static float OutPower(float t, int power) { }

	// RVA: 0x253C4C0 Offset: 0x253AAC0 VA: 0x18253C4C0
	public static float InOutPower(float t, int power) { }

	// RVA: 0x253BE60 Offset: 0x253A460 VA: 0x18253BE60
	public static float InBounce(float t) { }

	// RVA: 0x253C650 Offset: 0x253AC50 VA: 0x18253C650
	public static float OutBounce(float t) { }

	// RVA: 0x253C0B0 Offset: 0x253A6B0 VA: 0x18253C0B0
	public static float InOutBounce(float t) { }

	// RVA: 0x253BFA0 Offset: 0x253A5A0 VA: 0x18253BFA0
	public static float InElastic(float t) { }

	// RVA: 0x253C750 Offset: 0x253AD50 VA: 0x18253C750
	public static float OutElastic(float t) { }

	// RVA: 0x253C380 Offset: 0x253A980 VA: 0x18253C380
	public static float InOutElastic(float t) { }

	// RVA: 0x253BE40 Offset: 0x253A440 VA: 0x18253BE40
	public static float InBack(float t) { }

	// RVA: 0x253C610 Offset: 0x253AC10 VA: 0x18253C610
	public static float OutBack(float t) { }

	// RVA: 0x253C030 Offset: 0x253A630 VA: 0x18253C030
	public static float InOutBack(float t) { }

	// RVA: 0x253BF30 Offset: 0x253A530 VA: 0x18253BF30
	public static float InCirc(float t) { }

	// RVA: 0x253C6F0 Offset: 0x253ACF0 VA: 0x18253C6F0
	public static float OutCirc(float t) { }

	// RVA: 0x253C270 Offset: 0x253A870 VA: 0x18253C270
	public static float InOutCirc(float t) { }
}

// Namespace: UnityEngine.UIElements.Experimental
internal struct EventDebuggerLogCall : IDisposable // TypeDefIndex: 4560
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void .ctor(Delegate callback, EventBase evt) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine.UIElements.Experimental
internal struct EventDebuggerLogIMGUICall : IDisposable // TypeDefIndex: 4561
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void .ctor(EventBase evt) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine.UIElements.Experimental
internal struct EventDebuggerLogExecuteDefaultAction : IDisposable // TypeDefIndex: 4562
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void .ctor(EventBase evt) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine.UIElements.Experimental
[EventCategory(4)]
public class PointerOverLinkTagEvent : PointerEventBase<PointerOverLinkTagEvent> // TypeDefIndex: 4564
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <linkID>k__BackingField; // 0x100
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <linkText>k__BackingField; // 0x108

	// Properties
	private string linkID { set; }
	private string linkText { set; }

	// Methods

	// RVA: 0x253DC10 Offset: 0x253C210 VA: 0x18253DC10
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x15B47E0 Offset: 0x15B2DE0 VA: 0x1815B47E0
	private void set_linkID(string value) { }

	[CompilerGenerated]
	// RVA: 0x15B42C0 Offset: 0x15B28C0 VA: 0x1815B42C0
	private void set_linkText(string value) { }

	// RVA: 0x253DBC0 Offset: 0x253C1C0 VA: 0x18253DBC0 Slot: 13
	protected override void Init() { }

	// RVA: 0x253D620 Offset: 0x253BC20 VA: 0x18253D620
	private void LocalInit() { }

	// RVA: 0x253DB30 Offset: 0x253C130 VA: 0x18253DB30
	public static PointerOverLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x253DCF0 Offset: 0x253C2F0 VA: 0x18253DCF0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.Experimental
[EventCategory(2)]
public class PointerMoveLinkTagEvent : PointerEventBase<PointerMoveLinkTagEvent> // TypeDefIndex: 4566
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkID>k__BackingField; // 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkText>k__BackingField; // 0x108

	// Properties
	private string linkID { set; }
	private string linkText { set; }

	// Methods

	// RVA: 0x253D840 Offset: 0x253BE40 VA: 0x18253D840
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x15B47E0 Offset: 0x15B2DE0 VA: 0x1815B47E0
	private void set_linkID(string value) { }

	[CompilerGenerated]
	// RVA: 0x15B42C0 Offset: 0x15B28C0 VA: 0x1815B42C0
	private void set_linkText(string value) { }

	// RVA: 0x253D7F0 Offset: 0x253BDF0 VA: 0x18253D7F0 Slot: 13
	protected override void Init() { }

	// RVA: 0x253D620 Offset: 0x253BC20 VA: 0x18253D620
	private void LocalInit() { }

	// RVA: 0x253D760 Offset: 0x253BD60 VA: 0x18253D760
	public static PointerMoveLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x253D920 Offset: 0x253BF20 VA: 0x18253D920
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.Experimental
[EventCategory(4)]
public class PointerOutLinkTagEvent : PointerEventBase<PointerOutLinkTagEvent> // TypeDefIndex: 4568
{
	// Methods

	// RVA: 0x253DA00 Offset: 0x253C000 VA: 0x18253DA00
	private static void .cctor() { }

	// RVA: 0x253D9B0 Offset: 0x253BFB0 VA: 0x18253D9B0 Slot: 13
	protected override void Init() { }

	// RVA: 0x253D620 Offset: 0x253BC20 VA: 0x18253D620
	private void LocalInit() { }

	// RVA: 0x253D970 Offset: 0x253BF70 VA: 0x18253D970
	public static PointerOutLinkTagEvent GetPooled(IPointerEvent evt, string linkID) { }

	// RVA: 0x253DAE0 Offset: 0x253C0E0 VA: 0x18253DAE0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.Experimental
public sealed class PointerDownLinkTagEvent : PointerEventBase<PointerDownLinkTagEvent> // TypeDefIndex: 4570
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkID>k__BackingField; // 0x100
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <linkText>k__BackingField; // 0x108

	// Properties
	private string linkID { set; }
	private string linkText { set; }

	// Methods

	// RVA: 0x253D630 Offset: 0x253BC30 VA: 0x18253D630
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x15B47E0 Offset: 0x15B2DE0 VA: 0x1815B47E0
	private void set_linkID(string value) { }

	[CompilerGenerated]
	// RVA: 0x15B42C0 Offset: 0x15B28C0 VA: 0x1815B42C0
	private void set_linkText(string value) { }

	// RVA: 0x253D5D0 Offset: 0x253BBD0 VA: 0x18253D5D0 Slot: 13
	protected override void Init() { }

	// RVA: 0x253D620 Offset: 0x253BC20 VA: 0x18253D620
	private void LocalInit() { }

	// RVA: 0x253D540 Offset: 0x253BB40 VA: 0x18253D540
	public static PointerDownLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x253D710 Offset: 0x253BD10 VA: 0x18253D710
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerUpLinkTagEvent : PointerEventBase<PointerUpLinkTagEvent> // TypeDefIndex: 4572
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <linkID>k__BackingField; // 0x100
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <linkText>k__BackingField; // 0x108

	// Properties
	private string linkID { set; }
	private string linkText { set; }

	// Methods

	// RVA: 0x253DE20 Offset: 0x253C420 VA: 0x18253DE20
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x15B47E0 Offset: 0x15B2DE0 VA: 0x1815B47E0
	private void set_linkID(string value) { }

	[CompilerGenerated]
	// RVA: 0x15B42C0 Offset: 0x15B28C0 VA: 0x1815B42C0
	private void set_linkText(string value) { }

	// RVA: 0x253DDD0 Offset: 0x253C3D0 VA: 0x18253DDD0 Slot: 13
	protected override void Init() { }

	// RVA: 0x253D620 Offset: 0x253BC20 VA: 0x18253D620
	private void LocalInit() { }

	// RVA: 0x253DD40 Offset: 0x253C340 VA: 0x18253DD40
	public static PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x253DF00 Offset: 0x253C500 VA: 0x18253DF00
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.Experimental
public struct StyleValues // TypeDefIndex: 4573
{
	// Fields
	internal StyleValueCollection m_StyleValues; // 0x0

	// Properties
	public float top { set; }
	public float left { set; }
	public float width { set; }
	public float height { set; }
	public float right { set; }
	public float bottom { set; }
	public Color color { set; }
	public Color backgroundColor { set; }
	public Color unityBackgroundImageTintColor { set; }
	public Color borderColor { set; }
	public float marginLeft { set; }
	public float marginTop { set; }
	public float marginRight { set; }
	public float marginBottom { set; }
	public float paddingLeft { set; }
	public float paddingTop { get; set; }
	public float paddingRight { set; }
	public float paddingBottom { set; }
	public float borderLeftWidth { set; }
	public float borderRightWidth { set; }
	public float borderTopWidth { set; }
	public float borderBottomWidth { set; }
	public float borderTopLeftRadius { set; }
	public float borderTopRightRadius { set; }
	public float borderBottomLeftRadius { set; }
	public float borderBottomRightRadius { set; }
	public float opacity { set; }
	public float flexGrow { set; }
	public float flexShrink { set; }

	// Methods

	// RVA: 0x254AB80 Offset: 0x2549180 VA: 0x18254AB80
	public void set_top(float value) { }

	// RVA: 0x254AAD0 Offset: 0x25490D0 VA: 0x18254AAD0
	public void set_left(float value) { }

	// RVA: 0x254AC50 Offset: 0x2549250 VA: 0x18254AC50
	public void set_width(float value) { }

	// RVA: 0x254AAC0 Offset: 0x25490C0 VA: 0x18254AAC0
	public void set_height(float value) { }

	// RVA: 0x254AB70 Offset: 0x2549170 VA: 0x18254AB70
	public void set_right(float value) { }

	// RVA: 0x254A9E0 Offset: 0x2548FE0 VA: 0x18254A9E0
	public void set_bottom(float value) { }

	// RVA: 0x254A9F0 Offset: 0x2548FF0 VA: 0x18254A9F0
	public void set_color(Color value) { }

	// RVA: 0x254A7E0 Offset: 0x2548DE0 VA: 0x18254A7E0
	public void set_backgroundColor(Color value) { }

	// RVA: 0x254AB90 Offset: 0x2549190 VA: 0x18254AB90
	public void set_unityBackgroundImageTintColor(Color value) { }

	// RVA: 0x254A8D0 Offset: 0x2548ED0 VA: 0x18254A8D0
	public void set_borderColor(Color value) { }

	// RVA: 0x254AAF0 Offset: 0x25490F0 VA: 0x18254AAF0
	public void set_marginLeft(float value) { }

	// RVA: 0x254AB10 Offset: 0x2549110 VA: 0x18254AB10
	public void set_marginTop(float value) { }

	// RVA: 0x254AB00 Offset: 0x2549100 VA: 0x18254AB00
	public void set_marginRight(float value) { }

	// RVA: 0x254AAE0 Offset: 0x25490E0 VA: 0x18254AAE0
	public void set_marginBottom(float value) { }

	// RVA: 0x254AB40 Offset: 0x2549140 VA: 0x18254AB40
	public void set_paddingLeft(float value) { }

	// RVA: 0x254A740 Offset: 0x2548D40 VA: 0x18254A740
	public float get_paddingTop() { }

	// RVA: 0x254AB60 Offset: 0x2549160 VA: 0x18254AB60
	public void set_paddingTop(float value) { }

	// RVA: 0x254AB50 Offset: 0x2549150 VA: 0x18254AB50
	public void set_paddingRight(float value) { }

	// RVA: 0x254AB30 Offset: 0x2549130 VA: 0x18254AB30
	public void set_paddingBottom(float value) { }

	// RVA: 0x254A990 Offset: 0x2548F90 VA: 0x18254A990
	public void set_borderLeftWidth(float value) { }

	// RVA: 0x254A9A0 Offset: 0x2548FA0 VA: 0x18254A9A0
	public void set_borderRightWidth(float value) { }

	// RVA: 0x254A9D0 Offset: 0x2548FD0 VA: 0x18254A9D0
	public void set_borderTopWidth(float value) { }

	// RVA: 0x254A8C0 Offset: 0x2548EC0 VA: 0x18254A8C0
	public void set_borderBottomWidth(float value) { }

	// RVA: 0x254A9B0 Offset: 0x2548FB0 VA: 0x18254A9B0
	public void set_borderTopLeftRadius(float value) { }

	// RVA: 0x254A9C0 Offset: 0x2548FC0 VA: 0x18254A9C0
	public void set_borderTopRightRadius(float value) { }

	// RVA: 0x254A8A0 Offset: 0x2548EA0 VA: 0x18254A8A0
	public void set_borderBottomLeftRadius(float value) { }

	// RVA: 0x254A8B0 Offset: 0x2548EB0 VA: 0x18254A8B0
	public void set_borderBottomRightRadius(float value) { }

	// RVA: 0x254AB20 Offset: 0x2549120 VA: 0x18254AB20
	public void set_opacity(float value) { }

	// RVA: 0x254AAB0 Offset: 0x25490B0 VA: 0x18254AAB0
	public void set_flexGrow(float value) { }

	// RVA: 0x254AAB0 Offset: 0x25490B0 VA: 0x18254AAB0
	public void set_flexShrink(float value) { }

	// RVA: 0x254A560 Offset: 0x2548B60 VA: 0x18254A560
	internal void SetValue(StylePropertyId id, float value) { }

	// RVA: 0x254A620 Offset: 0x2548C20 VA: 0x18254A620
	internal void SetValue(StylePropertyId id, Color value) { }

	// RVA: 0x254A6D0 Offset: 0x2548CD0 VA: 0x18254A6D0
	internal StyleValueCollection Values() { }
}

// Namespace: UnityEngine.UIElements.Experimental
public interface ITransitionAnimations // TypeDefIndex: 4574
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueAnimation<StyleValues> Start(StyleValues to, int durationMs);
}

// Namespace: UnityEngine.UIElements.Experimental
internal static class Lerp // TypeDefIndex: 4575
{
	// Methods

	// RVA: 0x2338DF0 Offset: 0x23373F0 VA: 0x182338DF0
	public static float Interpolate(float start, float end, float ratio) { }

	// RVA: 0x253CBA0 Offset: 0x253B1A0 VA: 0x18253CBA0
	public static Color Interpolate(Color start, Color end, float ratio) { }

	// RVA: 0x253CC40 Offset: 0x253B240 VA: 0x18253CC40
	internal static StyleValues Interpolate(StyleValues start, StyleValues end, float ratio) { }
}

// Namespace: UnityEngine.UIElements.Experimental
internal interface IValueAnimationUpdate // TypeDefIndex: 4576
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Tick(long currentTimeMs);
}

// Namespace: UnityEngine.UIElements.Experimental
public sealed class ValueAnimation<T> : IValueAnimationUpdate // TypeDefIndex: 4578
{
	// Fields
	private long m_StartTimeMs; // 0x0
	private int m_DurationMs; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Func<float, float> <easingCurve>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isRunning>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action <onAnimationCompleted>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <autoRecycle>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <recycled>k__BackingField; // 0x0
	private static ObjectPool<ValueAnimation<T>> sObjectPool; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <owner>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<VisualElement, T> <valueUpdated>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<VisualElement, T> <initialValue>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Func<T, T, float, T> <interpolator>k__BackingField; // 0x0
	private T _from; // 0x0
	private bool fromValueSet; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private T <to>k__BackingField; // 0x0

	// Properties
	public int durationMs { get; set; }
	public Func<float, float> easingCurve { get; set; }
	public bool isRunning { get; set; }
	public Action onAnimationCompleted { get; set; }
	public bool autoRecycle { get; set; }
	private bool recycled { get; set; }
	private VisualElement owner { get; set; }
	public Action<VisualElement, T> valueUpdated { get; set; }
	public Func<VisualElement, T> initialValue { get; set; }
	public Func<T, T, float, T> interpolator { get; set; }
	public T from { get; set; }
	public T to { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public int get_durationMs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA3D180 Offset: 0xA3B780 VA: 0x180A3D180
	|-ValueAnimation<StyleValues>.get_durationMs
	|
	|-RVA: 0x886C10 Offset: 0x885210 VA: 0x180886C10
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_durationMs
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void set_durationMs(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADADE0 Offset: 0xAD93E0 VA: 0x180ADADE0
	|-ValueAnimation<StyleValues>.set_durationMs
	|
	|-RVA: 0xADAD70 Offset: 0xAD9370 VA: 0x180ADAD70
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_durationMs
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<float, float> get_easingCurve() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-ValueAnimation<StyleValues>.get_easingCurve
	|
	|-RVA: 0x96AFD0 Offset: 0x9695D0 VA: 0x18096AFD0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_easingCurve
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_easingCurve(Func<float, float> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	|-ValueAnimation<StyleValues>.set_easingCurve
	|
	|-RVA: 0x96B000 Offset: 0x969600 VA: 0x18096B000
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_easingCurve
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public bool get_isRunning() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	|-ValueAnimation<StyleValues>.get_isRunning
	|
	|-RVA: 0xADAB30 Offset: 0xAD9130 VA: 0x180ADAB30
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_isRunning
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_isRunning(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	|-ValueAnimation<StyleValues>.set_isRunning
	|
	|-RVA: 0xADB020 Offset: 0xAD9620 VA: 0x180ADB020
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_isRunning
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Action get_onAnimationCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-ValueAnimation<StyleValues>.get_onAnimationCompleted
	|
	|-RVA: 0xADAB60 Offset: 0xAD9160 VA: 0x180ADAB60
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_onAnimationCompleted
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_onAnimationCompleted(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	|-ValueAnimation<StyleValues>.set_onAnimationCompleted
	|
	|-RVA: 0xADB090 Offset: 0xAD9690 VA: 0x180ADB090
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_onAnimationCompleted
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_autoRecycle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	|-ValueAnimation<StyleValues>.get_autoRecycle
	|
	|-RVA: 0xADA830 Offset: 0xAD8E30 VA: 0x180ADA830
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_autoRecycle
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_autoRecycle(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	|-ValueAnimation<StyleValues>.set_autoRecycle
	|
	|-RVA: 0xADACF0 Offset: 0xAD92F0 VA: 0x180ADACF0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_autoRecycle
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private bool get_recycled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADABC0 Offset: 0xAD91C0 VA: 0x180ADABC0
	|-ValueAnimation<StyleValues>.get_recycled
	|
	|-RVA: 0xADABD0 Offset: 0xAD91D0 VA: 0x180ADABD0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_recycled
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_recycled(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADB1E0 Offset: 0xAD97E0 VA: 0x180ADB1E0
	|-ValueAnimation<StyleValues>.set_recycled
	|
	|-RVA: 0xADB170 Offset: 0xAD9770 VA: 0x180ADB170
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_recycled
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private VisualElement get_owner() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	|-ValueAnimation<StyleValues>.get_owner
	|
	|-RVA: 0xADAB90 Offset: 0xAD9190 VA: 0x180ADAB90
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_owner
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_owner(VisualElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	|-ValueAnimation<StyleValues>.set_owner
	|
	|-RVA: 0xADB100 Offset: 0xAD9700 VA: 0x180ADB100
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_owner
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Action<VisualElement, T> get_valueUpdated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	|-ValueAnimation<StyleValues>.get_valueUpdated
	|
	|-RVA: 0xADACC0 Offset: 0xAD92C0 VA: 0x180ADACC0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_valueUpdated
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_valueUpdated(Action<VisualElement, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	|-ValueAnimation<StyleValues>.set_valueUpdated
	|
	|-RVA: 0xADB2D0 Offset: 0xAD98D0 VA: 0x180ADB2D0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_valueUpdated
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<VisualElement, T> get_initialValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	|-ValueAnimation<StyleValues>.get_initialValue
	|
	|-RVA: 0x8DB160 Offset: 0x8D9760 VA: 0x1808DB160
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_initialValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_initialValue(Func<VisualElement, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	|-ValueAnimation<StyleValues>.set_initialValue
	|
	|-RVA: 0xADAF30 Offset: 0xAD9530 VA: 0x180ADAF30
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_initialValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<T, T, float, T> get_interpolator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	|-ValueAnimation<StyleValues>.get_interpolator
	|
	|-RVA: 0xADAB00 Offset: 0xAD9100 VA: 0x180ADAB00
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_interpolator
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_interpolator(Func<T, T, float, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	|-ValueAnimation<StyleValues>.set_interpolator
	|
	|-RVA: 0xADAFA0 Offset: 0xAD95A0 VA: 0x180ADAFA0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_interpolator
	*/

	// RVA: -1 Offset: -1
	public T get_from() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADA860 Offset: 0xAD8E60 VA: 0x180ADA860
	|-ValueAnimation<StyleValues>.get_from
	|
	|-RVA: 0xADA8C0 Offset: 0xAD8EC0 VA: 0x180ADA8C0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_from
	*/

	// RVA: -1 Offset: -1
	public void set_from(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADAF10 Offset: 0xAD9510 VA: 0x180ADAF10
	|-ValueAnimation<StyleValues>.set_from
	|
	|-RVA: 0xADADF0 Offset: 0xAD93F0 VA: 0x180ADADF0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_from
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_to() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	|-ValueAnimation<StyleValues>.get_to
	|
	|-RVA: 0xADAC00 Offset: 0xAD9200 VA: 0x180ADAC00
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_to
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_to(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADB2C0 Offset: 0xAD98C0 VA: 0x180ADB2C0
	|-ValueAnimation<StyleValues>.set_to
	|
	|-RVA: 0xADB1F0 Offset: 0xAD97F0 VA: 0x180ADB1F0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_to
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADA7F0 Offset: 0xAD8DF0 VA: 0x180ADA7F0
	|-ValueAnimation<StyleValues>..ctor
	|
	|-RVA: 0xADA760 Offset: 0xAD8D60 VA: 0x180ADA760
	|-ValueAnimation<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD9770 Offset: 0xAD7D70 VA: 0x180AD9770
	|-ValueAnimation<StyleValues>.Start
	|
	|-RVA: 0xAD9840 Offset: 0xAD7E40 VA: 0x180AD9840
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Stop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD9AB0 Offset: 0xAD80B0 VA: 0x180AD9AB0
	|-ValueAnimation<StyleValues>.Stop
	|
	|-RVA: 0xAD9960 Offset: 0xAD7F60 VA: 0x180AD9960
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Stop
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Recycle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD8E40 Offset: 0xAD7440 VA: 0x180AD8E40
	|-ValueAnimation<StyleValues>.Recycle
	|
	|-RVA: 0xAD8F90 Offset: 0xAD7590 VA: 0x180AD8F90
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Recycle
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(long currentTimeMs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADA060 Offset: 0xAD8660 VA: 0x180ADA060
	|-ValueAnimation<StyleValues>.UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick
	|
	|-RVA: 0xAD9C40 Offset: 0xAD8240 VA: 0x180AD9C40
	|-ValueAnimation<__Il2CppFullySharedGenericType>.UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick
	*/

	// RVA: -1 Offset: -1
	private void SetDefaultValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD9530 Offset: 0xAD7B30 VA: 0x180AD9530
	|-ValueAnimation<StyleValues>.SetDefaultValues
	|
	|-RVA: 0xAD91C0 Offset: 0xAD77C0 VA: 0x180AD91C0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.SetDefaultValues
	*/

	// RVA: -1 Offset: -1
	private void Unregister() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADA1E0 Offset: 0xAD87E0 VA: 0x180ADA1E0
	|-ValueAnimation<StyleValues>.Unregister
	|
	|-RVA: 0xADA200 Offset: 0xAD8800 VA: 0x180ADA200
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Unregister
	*/

	// RVA: -1 Offset: -1
	private void Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD9110 Offset: 0xAD7710 VA: 0x180AD9110
	|-ValueAnimation<StyleValues>.Register
	|
	|-RVA: 0xAD9130 Offset: 0xAD7730 VA: 0x180AD9130
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Register
	*/

	// RVA: -1 Offset: -1
	internal void SetOwner(VisualElement e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD9630 Offset: 0xAD7C30 VA: 0x180AD9630
	|-ValueAnimation<StyleValues>.SetOwner
	|
	|-RVA: 0xAD96A0 Offset: 0xAD7CA0 VA: 0x180AD96A0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.SetOwner
	*/

	// RVA: -1 Offset: -1
	private void CheckNotRecycled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD89E0 Offset: 0xAD6FE0 VA: 0x180AD89E0
	|-ValueAnimation<StyleValues>.CheckNotRecycled
	|
	|-RVA: 0xAD8950 Offset: 0xAD6F50 VA: 0x180AD8950
	|-ValueAnimation<__Il2CppFullySharedGenericType>.CheckNotRecycled
	*/

	// RVA: -1 Offset: -1
	public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD8A40 Offset: 0xAD7040 VA: 0x180AD8A40
	|-ValueAnimation<StyleValues>.Create
	|
	|-RVA: 0xAD8BD0 Offset: 0xAD71D0 VA: 0x180AD8BD0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public ValueAnimation<T> KeepAlive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD8E30 Offset: 0xAD7430 VA: 0x180AD8E30
	|-ValueAnimation<StyleValues>.KeepAlive
	|
	|-RVA: 0xAD8E00 Offset: 0xAD7400 VA: 0x180AD8E00
	|-ValueAnimation<__Il2CppFullySharedGenericType>.KeepAlive
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADA290 Offset: 0xAD8890 VA: 0x180ADA290
	|-ValueAnimation<StyleValues>..cctor
	|
	|-RVA: 0xADA4D0 Offset: 0xAD8AD0 VA: 0x180ADA4D0
	|-ValueAnimation<__Il2CppFullySharedGenericType>..cctor
	*/
}

