// Namespace: UnityEngine.UI
[Serializable]
public class AnimationTriggers // TypeDefIndex: 12094
{
	// Fields
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	[FormerlySerializedAs("normalTrigger")]
	[SerializeField]
	private string m_NormalTrigger; // 0x10
	[FormerlySerializedAs("highlightedTrigger")]
	[SerializeField]
	private string m_HighlightedTrigger; // 0x18
	[FormerlySerializedAs("pressedTrigger")]
	[SerializeField]
	private string m_PressedTrigger; // 0x20
	[FormerlySerializedAs("m_HighlightedTrigger")]
	[SerializeField]
	private string m_SelectedTrigger; // 0x28
	[FormerlySerializedAs("disabledTrigger")]
	[SerializeField]
	private string m_DisabledTrigger; // 0x30

	// Properties
	public string normalTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledTrigger { get; set; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_normalTrigger() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_normalTrigger(string value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_highlightedTrigger() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_pressedTrigger() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_pressedTrigger(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_selectedTrigger() { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_selectedTrigger(string value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_disabledTrigger() { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_disabledTrigger(string value) { }

	// RVA: 0x2437BB0 Offset: 0x24361B0 VA: 0x182437BB0
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Button", 30)]
public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 12097
{
	// Fields
	[FormerlySerializedAs("onClick")]
	[SerializeField]
	private Button.ButtonClickedEvent m_OnClick; // 0x100

	// Properties
	public Button.ButtonClickedEvent onClick { get; set; }

	// Methods

	// RVA: 0x2437EA0 Offset: 0x24364A0 VA: 0x182437EA0
	protected void .ctor() { }

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public Button.ButtonClickedEvent get_onClick() { }

	// RVA: 0x15B47E0 Offset: 0x15B2DE0 VA: 0x1815B47E0
	public void set_onClick(Button.ButtonClickedEvent value) { }

	// RVA: 0x2437E10 Offset: 0x2436410 VA: 0x182437E10
	private void Press() { }

	// RVA: 0x2437D10 Offset: 0x2436310 VA: 0x182437D10 Slot: 41
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2437D40 Offset: 0x2436340 VA: 0x182437D40 Slot: 42
	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachine(typeof(Button.<OnFinishSubmit>d__9))]
	// RVA: 0x2437CA0 Offset: 0x24362A0 VA: 0x182437CA0
	private IEnumerator OnFinishSubmit() { }
}

// Namespace: UnityEngine.UI
public enum CanvasUpdate // TypeDefIndex: 12098
{
	// Fields
	public int value__; // 0x0
	public const CanvasUpdate Prelayout = 0;
	public const CanvasUpdate Layout = 1;
	public const CanvasUpdate PostLayout = 2;
	public const CanvasUpdate PreRender = 3;
	public const CanvasUpdate LatePreRender = 4;
	public const CanvasUpdate MaxUpdateValue = 5;
}

// Namespace: UnityEngine.UI
public interface ICanvasElement // TypeDefIndex: 12099
{
	// Properties
	public abstract Transform transform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rebuild(CanvasUpdate executing);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Transform get_transform();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LayoutComplete();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GraphicUpdateComplete();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsDestroyed();
}

// Namespace: UnityEngine.UI
public class CanvasUpdateRegistry // TypeDefIndex: 12100
{
	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private string[] m_CanvasUpdateProfilerStrings; // 0x18
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x8

	// Properties
	public static CanvasUpdateRegistry instance { get; }

	// Methods

	// RVA: 0x2439680 Offset: 0x2437C80 VA: 0x182439680
	protected void .ctor() { }

	// RVA: 0x2439890 Offset: 0x2437E90 VA: 0x182439890
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x2438960 Offset: 0x2436F60 VA: 0x182438960
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x2437F30 Offset: 0x2436530 VA: 0x182437F30
	private void CleanInvalidItems() { }

	// RVA: 0x2438B00 Offset: 0x2437100 VA: 0x182438B00
	private void PerformUpdate() { }

	// RVA: 0x2438A30 Offset: 0x2437030 VA: 0x182438A30
	private static int ParentCount(Transform child) { }

	// RVA: 0x2439240 Offset: 0x2437840 VA: 0x182439240
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x24391E0 Offset: 0x24377E0 VA: 0x1824391E0
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2439350 Offset: 0x2437950 VA: 0x182439350
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2438610 Offset: 0x2436C10 VA: 0x182438610
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2439180 Offset: 0x2437780 VA: 0x182439180
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x24392F0 Offset: 0x24378F0 VA: 0x1824392F0
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2438550 Offset: 0x2436B50 VA: 0x182438550
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x24393B0 Offset: 0x24379B0 VA: 0x1824393B0
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x24380F0 Offset: 0x24366F0 VA: 0x1824380F0
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x24387B0 Offset: 0x2436DB0 VA: 0x1824387B0
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x24386A0 Offset: 0x2436CA0 VA: 0x1824386A0
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2438440 Offset: 0x2436A40 VA: 0x182438440
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x2438330 Offset: 0x2436930 VA: 0x182438330
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x2438910 Offset: 0x2436F10 VA: 0x182438910
	public static bool IsRebuildingLayout() { }

	// RVA: 0x24388C0 Offset: 0x2436EC0 VA: 0x1824388C0
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x24395F0 Offset: 0x2437BF0 VA: 0x1824395F0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 12101
{
	// Fields
	[FormerlySerializedAs("normalColor")]
	[SerializeField]
	private Color m_NormalColor; // 0x0
	[FormerlySerializedAs("highlightedColor")]
	[SerializeField]
	private Color m_HighlightedColor; // 0x10
	[FormerlySerializedAs("pressedColor")]
	[SerializeField]
	private Color m_PressedColor; // 0x20
	[FormerlySerializedAs("m_HighlightedColor")]
	[SerializeField]
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAs("disabledColor")]
	[SerializeField]
	private Color m_DisabledColor; // 0x40
	[Range(1, 5)]
	[SerializeField]
	private float m_ColorMultiplier; // 0x50
	[FormerlySerializedAs("fadeDuration")]
	[SerializeField]
	private float m_FadeDuration; // 0x54
	public static ColorBlock defaultColorBlock; // 0x0

	// Properties
	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }

	// Methods

	// RVA: 0x3A43B0 Offset: 0x3A29B0 VA: 0x1803A43B0
	public Color get_normalColor() { }

	// RVA: 0x3A43C0 Offset: 0x3A29C0 VA: 0x1803A43C0
	public void set_normalColor(Color value) { }

	// RVA: 0xA67320 Offset: 0xA65920 VA: 0x180A67320
	public Color get_highlightedColor() { }

	// RVA: 0x1032A10 Offset: 0x1031010 VA: 0x181032A10
	public void set_highlightedColor(Color value) { }

	// RVA: 0x95D410 Offset: 0x95BA10 VA: 0x18095D410
	public Color get_pressedColor() { }

	// RVA: 0x132E3D0 Offset: 0x132C9D0 VA: 0x18132E3D0
	public void set_pressedColor(Color value) { }

	// RVA: 0x16AF8F0 Offset: 0x16ADEF0 VA: 0x1816AF8F0
	public Color get_selectedColor() { }

	// RVA: 0x16F38C0 Offset: 0x16F1EC0 VA: 0x1816F38C0
	public void set_selectedColor(Color value) { }

	// RVA: 0xAC52A0 Offset: 0xAC38A0 VA: 0x180AC52A0
	public Color get_disabledColor() { }

	// RVA: 0xAC52D0 Offset: 0xAC38D0 VA: 0x180AC52D0
	public void set_disabledColor(Color value) { }

	// RVA: 0x34DA80 Offset: 0x34C080 VA: 0x18034DA80
	public float get_colorMultiplier() { }

	// RVA: 0x243A900 Offset: 0x2438F00 VA: 0x18243A900
	public void set_colorMultiplier(float value) { }

	// RVA: 0x17836B0 Offset: 0x1781CB0 VA: 0x1817836B0
	public float get_fadeDuration() { }

	// RVA: 0x474440 Offset: 0x472A40 VA: 0x180474440
	public void set_fadeDuration(float value) { }

	// RVA: 0x243A490 Offset: 0x2438A90 VA: 0x18243A490
	private static void .cctor() { }

	// RVA: 0x243A010 Offset: 0x2438610 VA: 0x18243A010 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x243A100 Offset: 0x2438700 VA: 0x18243A100 Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x243A7B0 Offset: 0x2438DB0 VA: 0x18243A7B0
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x243A850 Offset: 0x2438E50 VA: 0x18243A850
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x243A400 Offset: 0x2438A00 VA: 0x18243A400 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UI
public class ClipperRegistry // TypeDefIndex: 12102
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x2439BD0 Offset: 0x24381D0 VA: 0x182439BD0
	protected void .ctor() { }

	// RVA: 0x2439C50 Offset: 0x2438250 VA: 0x182439C50
	public static ClipperRegistry get_instance() { }

	// RVA: 0x2439970 Offset: 0x2437F70 VA: 0x182439970
	public void Cull() { }

	// RVA: 0x2439B00 Offset: 0x2438100 VA: 0x182439B00
	public static void Register(IClipper c) { }

	// RVA: 0x2439B70 Offset: 0x2438170 VA: 0x182439B70
	public static void Unregister(IClipper c) { }

	// RVA: 0x2439AA0 Offset: 0x24380A0 VA: 0x182439AA0
	public static void Disable(IClipper c) { }
}

// Namespace: UnityEngine.UI
public static class Clipping // TypeDefIndex: 12103
{
	// Methods

	// RVA: 0x2439D50 Offset: 0x2438350 VA: 0x182439D50
	public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect) { }
}

// Namespace: UnityEngine.UI
public interface IClipper // TypeDefIndex: 12104
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PerformClipping();
}

// Namespace: UnityEngine.UI
public interface IClippable // TypeDefIndex: 12105
{
	// Properties
	public abstract GameObject gameObject { get; }
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject get_gameObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RecalculateClipping();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract RectTransform get_rectTransform();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Cull(Rect clipRect, bool validRect);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetClipRect(Rect value, bool validRect);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetClipSoftness(Vector2 clipSoftness);
}

// Namespace: UnityEngine.UI
internal class RectangularVertexClipper // TypeDefIndex: 12106
{
	// Fields
	private readonly Vector3[] m_WorldCorners; // 0x10
	private readonly Vector3[] m_CanvasCorners; // 0x18

	// Methods

	// RVA: 0x2452270 Offset: 0x2450870 VA: 0x182452270
	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

	// RVA: 0x2452450 Offset: 0x2450A50 VA: 0x182452450
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public static class DefaultControls // TypeDefIndex: 12110
{
	// Fields
	private static DefaultControls.IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Properties
	public static DefaultControls.IFactoryControls factory { get; }

	// Methods

	// RVA: 0x2440000 Offset: 0x243E600 VA: 0x182440000
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x243FA00 Offset: 0x243E000 VA: 0x18243FA00
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x243FB10 Offset: 0x243E110 VA: 0x18243FB10
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x243FC40 Offset: 0x243E240 VA: 0x18243FC40
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x243FBF0 Offset: 0x243E1F0 VA: 0x18243FBF0
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x243FE00 Offset: 0x243E400 VA: 0x18243FE00
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x243FD20 Offset: 0x243E320 VA: 0x18243FD20
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x243D0B0 Offset: 0x243B6B0 VA: 0x18243D0B0
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x243A910 Offset: 0x2438F10 VA: 0x18243A910
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x243F0B0 Offset: 0x243D6B0 VA: 0x18243F0B0
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x243C730 Offset: 0x243AD30 VA: 0x18243C730
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x243D430 Offset: 0x243BA30 VA: 0x18243D430
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x243E730 Offset: 0x243CD30 VA: 0x18243E730
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x243E0F0 Offset: 0x243C6F0 VA: 0x18243E0F0
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x243F250 Offset: 0x243D850 VA: 0x18243F250
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x243C870 Offset: 0x243AE70 VA: 0x18243C870
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x243AE30 Offset: 0x2439430 VA: 0x18243AE30
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x243D570 Offset: 0x243BB70 VA: 0x18243D570
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x243FEE0 Offset: 0x243E4E0 VA: 0x18243FEE0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Legacy/Dropdown", 102)]
[RequireComponent(typeof(RectTransform))]
public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 12117
{
	// Fields
	[SerializeField]
	private RectTransform m_Template; // 0x100
	[SerializeField]
	private Text m_CaptionText; // 0x108
	[SerializeField]
	private Image m_CaptionImage; // 0x110
	[Space]
	[SerializeField]
	private Text m_ItemText; // 0x118
	[SerializeField]
	private Image m_ItemImage; // 0x120
	[Space]
	[SerializeField]
	private int m_Value; // 0x128
	[Space]
	[SerializeField]
	private Dropdown.OptionDataList m_Options; // 0x130
	[Space]
	[SerializeField]
	private Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField]
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private const int kHighSortingLayer = 30000;
	private static Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<Dropdown.OptionData> options { get; set; }
	public Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }

	// Methods

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public RectTransform get_template() { }

	// RVA: 0x24438B0 Offset: 0x2441EB0 VA: 0x1824438B0
	public void set_template(RectTransform value) { }

	// RVA: 0x15B3B70 Offset: 0x15B2170 VA: 0x1815B3B70
	public Text get_captionText() { }

	// RVA: 0x24437C0 Offset: 0x2441DC0 VA: 0x1824437C0
	public void set_captionText(Text value) { }

	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	public Image get_captionImage() { }

	// RVA: 0x2443790 Offset: 0x2441D90 VA: 0x182443790
	public void set_captionImage(Image value) { }

	// RVA: 0x1634AF0 Offset: 0x16330F0 VA: 0x181634AF0
	public Text get_itemText() { }

	// RVA: 0x2443820 Offset: 0x2441E20 VA: 0x182443820
	public void set_itemText(Text value) { }

	// RVA: 0x8DA910 Offset: 0x8D8F10 VA: 0x1808DA910
	public Image get_itemImage() { }

	// RVA: 0x24437F0 Offset: 0x2441DF0 VA: 0x1824437F0
	public void set_itemImage(Image value) { }

	// RVA: 0x2443750 Offset: 0x2441D50 VA: 0x182443750
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x2443870 Offset: 0x2441E70 VA: 0x182443870
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x1791C80 Offset: 0x1790280 VA: 0x181791C80
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x2443850 Offset: 0x2441E50 VA: 0x182443850
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0x17870B0 Offset: 0x17856B0 VA: 0x1817870B0
	public float get_alphaFadeSpeed() { }

	// RVA: 0x2443780 Offset: 0x2441D80 VA: 0x182443780
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x2443770 Offset: 0x2441D70 VA: 0x182443770
	public int get_value() { }

	// RVA: 0x24438E0 Offset: 0x2441EE0 VA: 0x1824438E0
	public void set_value(int value) { }

	// RVA: 0x2441BF0 Offset: 0x24401F0 VA: 0x182441BF0
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x2441C00 Offset: 0x2440200 VA: 0x182441C00
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x24435B0 Offset: 0x2441BB0 VA: 0x1824435B0
	protected void .ctor() { }

	// RVA: 0x2440AF0 Offset: 0x243F0F0 VA: 0x182440AF0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2443470 Offset: 0x2441A70 VA: 0x182443470 Slot: 6
	protected override void Start() { }

	// RVA: 0x2441750 Offset: 0x243FD50 VA: 0x182441750 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2441930 Offset: 0x243FF30 VA: 0x182441930
	public void RefreshShownValue() { }

	// RVA: 0x2440890 Offset: 0x243EE90 VA: 0x182440890
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x2440590 Offset: 0x243EB90 VA: 0x182440590
	public void AddOptions(List<string> options) { }

	// RVA: 0x2440710 Offset: 0x243ED10 VA: 0x182440710
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x2440C00 Offset: 0x243F200 VA: 0x182440C00
	public void ClearOptions() { }

	// RVA: 0x2441D30 Offset: 0x2440330 VA: 0x182441D30
	private void SetupTemplate(Canvas rootCanvas) { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D4AF0 Offset: 0x6D30F0 VA: 0x1806D4AF0
	|-Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x2441800 Offset: 0x243FE00 VA: 0x182441800 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2441800 Offset: 0x243FE00 VA: 0x182441800 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2441740 Offset: 0x243FD40 VA: 0x182441740 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x2442450 Offset: 0x2440A50 VA: 0x182442450
	public void Show() { }

	// RVA: 0x2440C80 Offset: 0x243F280 VA: 0x182440C80 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x2441300 Offset: 0x243F900 VA: 0x182441300 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x24411C0 Offset: 0x243F7C0 VA: 0x1824411C0 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x2441350 Offset: 0x243F950 VA: 0x182441350 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x2441220 Offset: 0x243F820 VA: 0x182441220 Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x2440280 Offset: 0x243E880 VA: 0x182440280
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x2440A60 Offset: 0x243F060 VA: 0x182440A60
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x2440900 Offset: 0x243EF00 VA: 0x182440900
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x2441B40 Offset: 0x2440140 VA: 0x182441B40
	private void SetAlpha(float alpha) { }

	// RVA: 0x24413A0 Offset: 0x243F9A0 VA: 0x1824413A0
	public void Hide() { }

	[IteratorStateMachine(typeof(Dropdown.<DelayedDestroyDropdownList>d__75))]
	// RVA: 0x2441280 Offset: 0x243F880 VA: 0x182441280
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x2441580 Offset: 0x243FB80 VA: 0x182441580
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x2441810 Offset: 0x243FE10 VA: 0x182441810
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x2443530 Offset: 0x2441B30 VA: 0x182443530
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 12118
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("font")]
	private Font m_Font; // 0x10
	[SerializeField]
	[FormerlySerializedAs("fontSize")]
	private int m_FontSize; // 0x18
	[SerializeField]
	[FormerlySerializedAs("fontStyle")]
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField]
	private bool m_BestFit; // 0x20
	[SerializeField]
	private int m_MinSize; // 0x24
	[SerializeField]
	private int m_MaxSize; // 0x28
	[SerializeField]
	[FormerlySerializedAs("alignment")]
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField]
	private bool m_AlignByGeometry; // 0x30
	[SerializeField]
	[FormerlySerializedAs("richText")]
	private bool m_RichText; // 0x31
	[SerializeField]
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField]
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField]
	private float m_LineSpacing; // 0x3C

	// Properties
	public static FontData defaultFontData { get; }
	public Font font { get; set; }
	public int fontSize { get; set; }
	public FontStyle fontStyle { get; set; }
	public bool bestFit { get; set; }
	public int minSize { get; set; }
	public int maxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public bool richText { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }

	// Methods

	// RVA: 0x2443940 Offset: 0x2441F40 VA: 0x182443940
	public static FontData get_defaultFontData() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Font get_font() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_font(Font value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_fontSize() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_fontSize(int value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public FontStyle get_fontStyle() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_bestFit() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_bestFit(bool value) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public int get_minSize() { }

	// RVA: 0x3CB180 Offset: 0x3C9780 VA: 0x1803CB180
	public void set_minSize(int value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_maxSize() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_maxSize(int value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public TextAnchor get_alignment() { }

	// RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_alignByGeometry() { }

	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x16ADFC0 Offset: 0x16AC5C0 VA: 0x1816ADFC0
	public bool get_richText() { }

	// RVA: 0x1D9AD60 Offset: 0x1D99360 VA: 0x181D9AD60
	public void set_richText(bool value) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x10051F0 Offset: 0x10037F0 VA: 0x1810051F0
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x1853720 Offset: 0x1851D20 VA: 0x181853720
	public float get_lineSpacing() { }

	// RVA: 0x1853770 Offset: 0x1851D70 VA: 0x181853770
	public void set_lineSpacing(float value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x24438F0 Offset: 0x2441EF0 VA: 0x1824438F0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public static class FontUpdateTracker // TypeDefIndex: 12119
{
	// Fields
	private static Dictionary<Font, HashSet<Text>> m_Tracked; // 0x0

	// Methods

	// RVA: 0x2443B30 Offset: 0x2442130 VA: 0x182443B30
	public static void TrackText(Text t) { }

	// RVA: 0x24439C0 Offset: 0x2441FC0 VA: 0x1824439C0
	private static void RebuildForFont(Font f) { }

	// RVA: 0x2443D80 Offset: 0x2442380 VA: 0x182443D80
	public static void UntrackText(Text t) { }

	// RVA: 0x2443F90 Offset: 0x2442590 VA: 0x182443F90
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 12120
{
	// Fields
	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	[FormerlySerializedAs("m_Mat")]
	[SerializeField]
	protected Material m_Material; // 0x20
	[SerializeField]
	private Color m_Color; // 0x28
	protected bool m_SkipLayoutUpdate; // 0x38
	protected bool m_SkipMaterialUpdate; // 0x39
	[SerializeField]
	private bool m_RaycastTarget; // 0x3A
	private bool m_RaycastTargetCache; // 0x3B
	[SerializeField]
	private Vector4 m_RaycastPadding; // 0x3C
	private RectTransform m_RectTransform; // 0x50
	private CanvasRenderer m_CanvasRenderer; // 0x58
	private Canvas m_Canvas; // 0x60
	private bool m_VertsDirty; // 0x68
	private bool m_MaterialDirty; // 0x69
	protected UnityAction m_OnDirtyLayoutCallback; // 0x70
	protected UnityAction m_OnDirtyVertsCallback; // 0x78
	protected UnityAction m_OnDirtyMaterialCallback; // 0x80
	protected static Mesh s_Mesh; // 0x10
	private static readonly VertexHelper s_VertexHelper; // 0x18
	protected Mesh m_CachedMesh; // 0x88
	protected Vector2[] m_CachedUvs; // 0x90
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; // 0x98
	[CompilerGenerated]
	private bool <useLegacyMeshGeneration>k__BackingField; // 0xA0

	// Properties
	public static Material defaultGraphicMaterial { get; }
	public virtual Color color { get; set; }
	public virtual bool raycastTarget { get; set; }
	public Vector4 raycastPadding { get; set; }
	protected bool useLegacyMeshGeneration { get; set; }
	public int depth { get; }
	public RectTransform rectTransform { get; }
	public Canvas canvas { get; }
	public CanvasRenderer canvasRenderer { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Material material { get; set; }
	public virtual Material materialForRendering { get; }
	public virtual Texture mainTexture { get; }
	protected static Mesh workerMesh { get; }

	// Methods

	// RVA: 0x2449910 Offset: 0x2447F10 VA: 0x182449910
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x1116670 Offset: 0x1114C70 VA: 0x181116670 Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x2449FE0 Offset: 0x24485E0 VA: 0x182449FE0 Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x13D9FE0 Offset: 0x13D85E0 VA: 0x1813D9FE0 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x244A0D0 Offset: 0x24486D0 VA: 0x18244A0D0 Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	// RVA: 0x2449E20 Offset: 0x2448420 VA: 0x182449E20
	public Vector4 get_raycastPadding() { }

	// RVA: 0x244A0C0 Offset: 0x24486C0 VA: 0x18244A0C0
	public void set_raycastPadding(Vector4 value) { }

	[CompilerGenerated]
	// RVA: 0x156F940 Offset: 0x156DF40 VA: 0x18156F940
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGenerated]
	// RVA: 0x163E120 Offset: 0x163C720 VA: 0x18163E120
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x2449730 Offset: 0x2447D30 VA: 0x182449730
	protected void .ctor() { }

	// RVA: 0x2448FA0 Offset: 0x24475A0 VA: 0x182448FA0 Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x2449010 Offset: 0x2447610 VA: 0x182449010 Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x24492B0 Offset: 0x24478B0 VA: 0x1824492B0 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x24490F0 Offset: 0x24476F0 VA: 0x1824490F0 Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x24491D0 Offset: 0x24477D0 VA: 0x1824491D0
	public void SetRaycastDirty() { }

	// RVA: 0x2448630 Offset: 0x2446C30 VA: 0x182448630 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2447B70 Offset: 0x2446170 VA: 0x182447B70 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x2448720 Offset: 0x2446D20 VA: 0x182448720 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2449B30 Offset: 0x2448130 VA: 0x182449B30
	public int get_depth() { }

	// RVA: 0x2449E30 Offset: 0x2448430 VA: 0x182449E30 Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x24498A0 Offset: 0x2447EA0 VA: 0x1824498A0
	public Canvas get_canvas() { }

	// RVA: 0x2446A00 Offset: 0x2445000 VA: 0x182446A00
	private void CacheCanvas() { }

	// RVA: 0x2449800 Offset: 0x2447E00 VA: 0x182449800
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x2449A10 Offset: 0x2448010 VA: 0x182449A10 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x2449D90 Offset: 0x2448390 VA: 0x182449D90 Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x244A030 Offset: 0x2448630 VA: 0x18244A030 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x2449BB0 Offset: 0x24481B0 VA: 0x182449BB0 Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x2449B60 Offset: 0x2448160 VA: 0x182449B60 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x2448200 Offset: 0x2446800 VA: 0x182448200 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2448040 Offset: 0x2446640 VA: 0x182448040 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2447EC0 Offset: 0x24464C0 VA: 0x182447EC0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2447C90 Offset: 0x2446290 VA: 0x182447C90 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x2447DF0 Offset: 0x24463F0 VA: 0x182447DF0 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x2448CD0 Offset: 0x24472D0 VA: 0x182448CD0 Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2449590 Offset: 0x2447B90 VA: 0x182449590 Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x2449570 Offset: 0x2447B70 VA: 0x182449570 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x2447450 Offset: 0x2445A50 VA: 0x182447450
	private void DoMeshGeneration() { }

	// RVA: 0x2446F70 Offset: 0x2445570 VA: 0x182446F70
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x2449E90 Offset: 0x2448490 VA: 0x182449E90
	protected static Mesh get_workerMesh() { }

	[EditorBrowsable(1)]
	[Obsolete("Use OnPopulateMesh instead.", True)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", False)]
	// RVA: 0x2448390 Offset: 0x2446990 VA: 0x182448390 Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x2448430 Offset: 0x2446A30 VA: 0x182448430 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x2448020 Offset: 0x2446620 VA: 0x182448020 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x2448970 Offset: 0x2446F70 VA: 0x182448970 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x24487E0 Offset: 0x2446DE0 VA: 0x1824487E0
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x2447980 Offset: 0x2445F80 VA: 0x182447980
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x2446F30 Offset: 0x2445530 VA: 0x182446F30 Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x2446C70 Offset: 0x2445270 VA: 0x182446C70 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x2446B80 Offset: 0x2445180 VA: 0x182446B80
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x2446BA0 Offset: 0x24451A0 VA: 0x182446BA0 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x2448DB0 Offset: 0x24473B0 VA: 0x182448DB0
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x2449380 Offset: 0x2447980 VA: 0x182449380
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x2448F00 Offset: 0x2447500 VA: 0x182448F00
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x24494D0 Offset: 0x2447AD0 VA: 0x1824494D0
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x2448E50 Offset: 0x2447450 VA: 0x182448E50
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x2449420 Offset: 0x2447A20 VA: 0x182449420
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x2449660 Offset: 0x2447C60 VA: 0x182449660
	private static void .cctor() { }

	// RVA: 0x21AC2C0 Offset: 0x21AA8C0 VA: 0x1821AC2C0 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Event/Graphic Raycaster")]
[RequireComponent(typeof(Canvas))]
public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 12123
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	[FormerlySerializedAs("ignoreReversedGraphics")]
	[SerializeField]
	private bool m_IgnoreReversedGraphics; // 0x28
	[FormerlySerializedAs("blockingObjects")]
	[SerializeField]
	private GraphicRaycaster.BlockingObjects m_BlockingObjects; // 0x2C
	[SerializeField]
	protected LayerMask m_BlockingMask; // 0x30
	private Canvas m_Canvas; // 0x38
	private List<Graphic> m_RaycastResults; // 0x40
	private static readonly List<Graphic> s_SortedGraphics; // 0x0

	// Properties
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public bool ignoreReversedGraphics { get; set; }
	public GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
	public LayerMask blockingMask { get; set; }
	private Canvas canvas { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x24457A0 Offset: 0x2443DA0 VA: 0x1824457A0 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x2445740 Offset: 0x2443D40 VA: 0x182445740 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public LayerMask get_blockingMask() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x2445560 Offset: 0x2443B60 VA: 0x182445560
	protected void .ctor() { }

	// RVA: 0x24455F0 Offset: 0x2443BF0 VA: 0x1824455F0
	private Canvas get_canvas() { }

	// RVA: 0x2444600 Offset: 0x2442C00 VA: 0x182444600 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x2445680 Offset: 0x2443C80 VA: 0x182445680 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x2444020 Offset: 0x2442620 VA: 0x182444020
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x24454D0 Offset: 0x2443AD0 VA: 0x1824454D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
public class GraphicRegistry // TypeDefIndex: 12124
{
	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics; // 0x18
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x2446610 Offset: 0x2444C10 VA: 0x182446610
	protected void .ctor() { }

	// RVA: 0x24467A0 Offset: 0x2444DA0 VA: 0x1824467A0
	public static GraphicRegistry get_instance() { }

	// RVA: 0x2445E10 Offset: 0x2444410 VA: 0x182445E10
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2446010 Offset: 0x2444610 VA: 0x182446010
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2446230 Offset: 0x2444830 VA: 0x182446230
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x24463F0 Offset: 0x24449F0 VA: 0x1824463F0
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2445800 Offset: 0x2443E00 VA: 0x182445800
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2445B00 Offset: 0x2444100 VA: 0x182445B00
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x2445C90 Offset: 0x2444290 VA: 0x182445C90
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x2445D50 Offset: 0x2444350 VA: 0x182445D50
	public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x2446580 Offset: 0x2444B80 VA: 0x182446580
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Not supported anymore")]
internal interface IGraphicEnabledDisabled // TypeDefIndex: 12125
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSiblingGraphicEnabledDisabled();
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/Image", 11)]
public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 12133
{
	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	[FormerlySerializedAs("m_Frame")]
	[SerializeField]
	private Sprite m_Sprite; // 0xE0
	private Sprite m_OverrideSprite; // 0xE8
	[SerializeField]
	private Image.Type m_Type; // 0xF0
	[SerializeField]
	private bool m_PreserveAspect; // 0xF4
	[SerializeField]
	private bool m_FillCenter; // 0xF5
	[SerializeField]
	private Image.FillMethod m_FillMethod; // 0xF8
	[Range(0, 1)]
	[SerializeField]
	private float m_FillAmount; // 0xFC
	[SerializeField]
	private bool m_FillClockwise; // 0x100
	[SerializeField]
	private int m_FillOrigin; // 0x104
	private float m_AlphaHitTestMinimumThreshold; // 0x108
	private bool m_Tracked; // 0x10C
	[SerializeField]
	private bool m_UseSpriteMesh; // 0x10D
	[SerializeField]
	private float m_PixelsPerUnitMultiplier; // 0x110
	private float m_CachedReferencePixelsPerUnit; // 0x114
	private static readonly Vector2[] s_VertScratch; // 0x8
	private static readonly Vector2[] s_UVScratch; // 0x10
	private static readonly Vector3[] s_Xy; // 0x18
	private static readonly Vector3[] s_Uv; // 0x20
	private static List<Image> m_TrackedTexturelessImages; // 0x28
	private static bool s_Initialized; // 0x30

	// Properties
	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	private Sprite activeSprite { get; }
	public Image.Type type { get; set; }
	public bool preserveAspect { get; set; }
	public bool fillCenter { get; set; }
	public Image.FillMethod fillMethod { get; set; }
	public float fillAmount { get; set; }
	public bool fillClockwise { get; set; }
	public int fillOrigin { get; set; }
	[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
	public float eventAlphaThreshold { get; set; }
	public float alphaHitTestMinimumThreshold { get; set; }
	public bool useSpriteMesh { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnitMultiplier { get; set; }
	public float pixelsPerUnit { get; }
	protected float multipliedPixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	public Sprite get_sprite() { }

	// RVA: 0x2451E20 Offset: 0x2450420 VA: 0x182451E20
	public void set_sprite(Sprite value) { }

	// RVA: 0x244A550 Offset: 0x2448B50 VA: 0x18244A550
	public void DisableSpriteOptimizations() { }

	// RVA: 0x2451460 Offset: 0x244FA60 VA: 0x182451460
	public Sprite get_overrideSprite() { }

	// RVA: 0x2451D10 Offset: 0x2450310 VA: 0x182451D10
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x2450DE0 Offset: 0x244F3E0 VA: 0x182450DE0
	private Sprite get_activeSprite() { }

	// RVA: 0x16EE440 Offset: 0x16ECA40 VA: 0x1816EE440
	public Image.Type get_type() { }

	// RVA: 0x2452110 Offset: 0x2450710 VA: 0x182452110
	public void set_type(Image.Type value) { }

	// RVA: 0x16EE460 Offset: 0x16ECA60 VA: 0x1816EE460
	public bool get_preserveAspect() { }

	// RVA: 0x2451DB0 Offset: 0x24503B0 VA: 0x182451DB0
	public void set_preserveAspect(bool value) { }

	// RVA: 0x2450F80 Offset: 0x244F580 VA: 0x182450F80
	public bool get_fillCenter() { }

	// RVA: 0x2451B50 Offset: 0x2450150 VA: 0x182451B50
	public void set_fillCenter(bool value) { }

	// RVA: 0x16EE480 Offset: 0x16ECA80 VA: 0x1816EE480
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x2451C30 Offset: 0x2450230 VA: 0x182451C30
	public void set_fillMethod(Image.FillMethod value) { }

	// RVA: 0x2147500 Offset: 0x2145B00 VA: 0x182147500
	public float get_fillAmount() { }

	// RVA: 0x2451AC0 Offset: 0x24500C0 VA: 0x182451AC0
	public void set_fillAmount(float value) { }

	// RVA: 0x16212D0 Offset: 0x161F8D0 VA: 0x1816212D0
	public bool get_fillClockwise() { }

	// RVA: 0x2451BC0 Offset: 0x24501C0 VA: 0x182451BC0
	public void set_fillClockwise(bool value) { }

	// RVA: 0x2450F90 Offset: 0x244F590 VA: 0x182450F90
	public int get_fillOrigin() { }

	// RVA: 0x2451CA0 Offset: 0x24502A0 VA: 0x182451CA0
	public void set_fillOrigin(int value) { }

	// RVA: 0x2450F60 Offset: 0x244F560 VA: 0x182450F60
	public float get_eventAlphaThreshold() { }

	// RVA: 0x2451950 Offset: 0x244FF50 VA: 0x182451950
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x352AA0 Offset: 0x3510A0 VA: 0x180352AA0
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x24517F0 Offset: 0x244FDF0 VA: 0x1824517F0
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x24517E0 Offset: 0x244FDE0 VA: 0x1824517E0
	public bool get_useSpriteMesh() { }

	// RVA: 0x2452180 Offset: 0x2450780 VA: 0x182452180
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x2450D80 Offset: 0x244F380 VA: 0x182450D80
	protected void .ctor() { }

	// RVA: 0x2450E60 Offset: 0x244F460 VA: 0x182450E60
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x2451090 Offset: 0x244F690 VA: 0x182451090 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x2450FA0 Offset: 0x244F5A0 VA: 0x182450FA0
	public bool get_hasBorder() { }

	// RVA: 0x2451470 Offset: 0x244FA70 VA: 0x182451470
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x2451D80 Offset: 0x2450380 VA: 0x182451D80
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x2451480 Offset: 0x244FA80 VA: 0x182451480
	public float get_pixelsPerUnit() { }

	// RVA: 0x2451440 Offset: 0x244FA40 VA: 0x182451440
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x2451220 Offset: 0x244F820 VA: 0x182451220 Slot: 32
	public override Material get_material() { }

	// RVA: 0x244A030 Offset: 0x2448630 VA: 0x18244A030 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 77
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x244F290 Offset: 0x244D890 VA: 0x18244F290 Slot: 78
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x244F6E0 Offset: 0x244DCE0 VA: 0x18244F6E0
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x244E400 Offset: 0x244CA00 VA: 0x18244E400
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x24500C0 Offset: 0x244E6C0 VA: 0x1824500C0 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x244F590 Offset: 0x244DB90 VA: 0x18244F590 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x2450460 Offset: 0x244EA60 VA: 0x182450460
	private void TrackSprite() { }

	// RVA: 0x244F570 Offset: 0x244DB70 VA: 0x18244F570 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x244F4A0 Offset: 0x244DAA0 VA: 0x18244F4A0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2450A10 Offset: 0x244F010 VA: 0x182450A10 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x244F300 Offset: 0x244D900 VA: 0x18244F300 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x244BA10 Offset: 0x244A010 VA: 0x18244BA10
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x244C710 Offset: 0x244AD10 VA: 0x18244C710
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x244BDC0 Offset: 0x244A3C0 VA: 0x18244BDC0
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x244CCE0 Offset: 0x244B2E0 VA: 0x18244CCE0
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x244A3F0 Offset: 0x24489F0 VA: 0x18244A3F0
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x244A1B0 Offset: 0x24487B0 VA: 0x18244A1B0
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x244E0A0 Offset: 0x244C6A0 VA: 0x18244E0A0
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x244A560 Offset: 0x2448B60 VA: 0x18244A560
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x244F860 Offset: 0x244DE60 VA: 0x18244F860
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x244F9B0 Offset: 0x244DFB0 VA: 0x18244F9B0
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 79
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 80
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 81
	public virtual float get_minWidth() { }

	// RVA: 0x24516D0 Offset: 0x244FCD0 VA: 0x1824516D0 Slot: 82
	public virtual float get_preferredWidth() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 83
	public virtual float get_flexibleWidth() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 84
	public virtual float get_minHeight() { }

	// RVA: 0x24515C0 Offset: 0x244FBC0 VA: 0x1824515C0 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 86
	public virtual float get_flexibleHeight() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 87
	public virtual int get_layoutPriority() { }

	// RVA: 0x244E770 Offset: 0x244CD70 VA: 0x18244E770 Slot: 88
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x244EBC0 Offset: 0x244D1C0 VA: 0x18244EBC0
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x244FEB0 Offset: 0x244E4B0 VA: 0x18244FEB0
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x24502F0 Offset: 0x244E8F0 VA: 0x1824502F0
	private static void TrackImage(Image g) { }

	// RVA: 0x2450990 Offset: 0x244EF90 VA: 0x182450990
	private static void UnTrackImage(Image g) { }

	// RVA: 0x244F460 Offset: 0x244DA60 VA: 0x18244F460 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2450BC0 Offset: 0x244F1C0 VA: 0x182450BC0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x24506A0 Offset: 0x244ECA0 VA: 0x1824506A0
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	[CompilerGenerated]
	// RVA: 0x2450850 Offset: 0x244EE50 VA: 0x182450850
	private bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1() { }
}

// Namespace: UnityEngine.UI
[EditorBrowsable(1)]
[Obsolete("Not supported anymore.", True)]
public interface IMask // TypeDefIndex: 12134
{
	// Properties
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract RectTransform get_rectTransform();
}

// Namespace: UnityEngine.UI
public interface IMaskable // TypeDefIndex: 12135
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RecalculateMasking();
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Legacy/Input Field", 103)]
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 12147
{
	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0x100
	private static readonly char[] kSeparators; // 0x0
	private static bool s_IsQuestDevice; // 0x8
	[SerializeField]
	[FormerlySerializedAs("text")]
	protected Text m_TextComponent; // 0x108
	[SerializeField]
	protected Graphic m_Placeholder; // 0x110
	[SerializeField]
	private InputField.ContentType m_ContentType; // 0x118
	[FormerlySerializedAs("inputType")]
	[SerializeField]
	private InputField.InputType m_InputType; // 0x11C
	[FormerlySerializedAs("asteriskChar")]
	[SerializeField]
	private char m_AsteriskChar; // 0x120
	[FormerlySerializedAs("keyboardType")]
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; // 0x124
	[SerializeField]
	private InputField.LineType m_LineType; // 0x128
	[FormerlySerializedAs("hideMobileInput")]
	[SerializeField]
	private bool m_HideMobileInput; // 0x12C
	[FormerlySerializedAs("validation")]
	[SerializeField]
	private InputField.CharacterValidation m_CharacterValidation; // 0x130
	[FormerlySerializedAs("characterLimit")]
	[SerializeField]
	private int m_CharacterLimit; // 0x134
	[FormerlySerializedAs("onSubmit")]
	[FormerlySerializedAs("m_OnSubmit")]
	[FormerlySerializedAs("m_EndEdit")]
	[FormerlySerializedAs("m_OnEndEdit")]
	[SerializeField]
	private InputField.SubmitEvent m_OnSubmit; // 0x138
	[SerializeField]
	private InputField.EndEditEvent m_OnDidEndEdit; // 0x140
	[FormerlySerializedAs("onValueChange")]
	[FormerlySerializedAs("m_OnValueChange")]
	[SerializeField]
	private InputField.OnChangeEvent m_OnValueChanged; // 0x148
	[FormerlySerializedAs("onValidateInput")]
	[SerializeField]
	private InputField.OnValidateInput m_OnValidateInput; // 0x150
	[FormerlySerializedAs("selectionColor")]
	[SerializeField]
	private Color m_CaretColor; // 0x158
	[SerializeField]
	private bool m_CustomCaretColor; // 0x168
	[SerializeField]
	private Color m_SelectionColor; // 0x16C
	[SerializeField]
	[Multiline]
	[FormerlySerializedAs("mValue")]
	protected string m_Text; // 0x180
	[SerializeField]
	[Range(0, 4)]
	private float m_CaretBlinkRate; // 0x188
	[SerializeField]
	[Range(1, 5)]
	private int m_CaretWidth; // 0x18C
	[SerializeField]
	private bool m_ReadOnly; // 0x190
	[SerializeField]
	private bool m_ShouldActivateOnSelect; // 0x191
	protected int m_CaretPosition; // 0x194
	protected int m_CaretSelectPosition; // 0x198
	private RectTransform caretRectTrans; // 0x1A0
	protected UIVertex[] m_CursorVerts; // 0x1A8
	private TextGenerator m_InputTextCache; // 0x1B0
	private CanvasRenderer m_CachedInputRenderer; // 0x1B8
	private bool m_PreventFontCallback; // 0x1C0
	protected Mesh m_Mesh; // 0x1C8
	private bool m_AllowInput; // 0x1D0
	private bool m_ShouldActivateNextUpdate; // 0x1D1
	private bool m_UpdateDrag; // 0x1D2
	private bool m_DragPositionOutOfBounds; // 0x1D3
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x1D4
	private Coroutine m_BlinkCoroutine; // 0x1D8
	private float m_BlinkStartTime; // 0x1E0
	protected int m_DrawStart; // 0x1E4
	protected int m_DrawEnd; // 0x1E8
	private Coroutine m_DragCoroutine; // 0x1F0
	private string m_OriginalText; // 0x1F8
	private bool m_WasCanceled; // 0x200
	private bool m_HasDoneFocusTransition; // 0x201
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x208
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x210
	private bool m_IsCompositionActive; // 0x211
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private const string kOculusQuestDeviceModel = "Oculus Quest";
	private Event m_ProcessingEvent; // 0x218
	private const int k_MaxTextLength = 16382;

	// Properties
	private BaseInput input { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	protected TextGenerator cachedInputTextGenerator { get; }
	public bool shouldHideMobileInput { get; set; }
	public virtual bool shouldActivateOnSelect { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public InputField.EndEditEvent onEndEdit { get; set; }
	public InputField.SubmitEvent onSubmit { get; set; }
	[Obsolete("onValueChange has been renamed to onValueChanged")]
	public InputField.OnChangeEvent onValueChange { get; set; }
	public InputField.OnChangeEvent onValueChanged { get; set; }
	public InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public InputField.ContentType contentType { get; set; }
	public InputField.LineType lineType { get; set; }
	public InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public InputField.CharacterValidation characterValidation { get; set; }
	public bool readOnly { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x264CCD0 Offset: 0x264B2D0 VA: 0x18264CCD0
	private BaseInput get_input() { }

	// RVA: 0x264CB90 Offset: 0x264B190 VA: 0x18264CB90
	private string get_compositionString() { }

	// RVA: 0x264C7A0 Offset: 0x264ADA0 VA: 0x18264C7A0
	protected void .ctor() { }

	// RVA: 0x264CDE0 Offset: 0x264B3E0 VA: 0x18264CDE0
	protected Mesh get_mesh() { }

	// RVA: 0x264C9F0 Offset: 0x264AFF0 VA: 0x18264C9F0
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x264DF50 Offset: 0x264C550 VA: 0x18264DF50
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x264D300 Offset: 0x264B900 VA: 0x18264D300
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x264DF40 Offset: 0x264C540 VA: 0x18264DF40 Slot: 59
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x264D2A0 Offset: 0x264B8A0 VA: 0x18264D2A0 Slot: 60
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x17A1C60 Offset: 0x17A0260 VA: 0x1817A1C60
	public string get_text() { }

	// RVA: 0x264E240 Offset: 0x264C840 VA: 0x18264E240
	public void set_text(string value) { }

	// RVA: 0x264AD10 Offset: 0x2649310 VA: 0x18264AD10
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x264AD20 Offset: 0x2649320 VA: 0x18264AD20
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x264CDD0 Offset: 0x264B3D0 VA: 0x18264CDD0
	public bool get_isFocused() { }

	// RVA: 0x264CA70 Offset: 0x264B070 VA: 0x18264CA70
	public float get_caretBlinkRate() { }

	// RVA: 0x264D3D0 Offset: 0x264B9D0 VA: 0x18264D3D0
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x264CB40 Offset: 0x264B140 VA: 0x18264CB40
	public int get_caretWidth() { }

	// RVA: 0x264D610 Offset: 0x264BC10 VA: 0x18264D610
	public void set_caretWidth(int value) { }

	// RVA: 0x15B3B70 Offset: 0x15B2170 VA: 0x1815B3B70
	public Text get_textComponent() { }

	// RVA: 0x264DFA0 Offset: 0x264C5A0 VA: 0x18264DFA0
	public void set_textComponent(Text value) { }

	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	public Graphic get_placeholder() { }

	// RVA: 0x264DDA0 Offset: 0x264C3A0 VA: 0x18264DDA0
	public void set_placeholder(Graphic value) { }

	// RVA: 0x264CA80 Offset: 0x264B080 VA: 0x18264CA80
	public Color get_caretColor() { }

	// RVA: 0x264D440 Offset: 0x264BA40 VA: 0x18264D440
	public void set_caretColor(Color value) { }

	// RVA: 0x264CC40 Offset: 0x264B240 VA: 0x18264CC40
	public bool get_customCaretColor() { }

	// RVA: 0x264DA40 Offset: 0x264C040 VA: 0x18264DA40
	public void set_customCaretColor(bool value) { }

	// RVA: 0x264D290 Offset: 0x264B890 VA: 0x18264D290
	public Color get_selectionColor() { }

	// RVA: 0x264DE60 Offset: 0x264C460 VA: 0x18264DE60
	public void set_selectionColor(Color value) { }

	// RVA: 0x1791C20 Offset: 0x1790220 VA: 0x181791C20
	public InputField.EndEditEvent get_onEndEdit() { }

	// RVA: 0x264DC60 Offset: 0x264C260 VA: 0x18264DC60
	public void set_onEndEdit(InputField.EndEditEvent value) { }

	// RVA: 0x1791C80 Offset: 0x1790280 VA: 0x181791C80
	public InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x264DCB0 Offset: 0x264C2B0 VA: 0x18264DCB0
	public void set_onSubmit(InputField.SubmitEvent value) { }

	// RVA: 0x127C510 Offset: 0x127AB10 VA: 0x18127C510
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x264DD50 Offset: 0x264C350 VA: 0x18264DD50
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x127C510 Offset: 0x127AB10 VA: 0x18127C510
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x264DD50 Offset: 0x264C350 VA: 0x18264DD50
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x17871E0 Offset: 0x17857E0 VA: 0x1817871E0
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x264DD00 Offset: 0x264C300 VA: 0x18264DD00
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x1E99140 Offset: 0x1E97740 VA: 0x181E99140
	public int get_characterLimit() { }

	// RVA: 0x264D6A0 Offset: 0x264BCA0 VA: 0x18264D6A0
	public void set_characterLimit(int value) { }

	// RVA: 0x8DB840 Offset: 0x8D9E40 VA: 0x1808DB840
	public InputField.ContentType get_contentType() { }

	// RVA: 0x264D810 Offset: 0x264BE10 VA: 0x18264D810
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0x2443770 Offset: 0x2441D70 VA: 0x182443770
	public InputField.LineType get_lineType() { }

	// RVA: 0x264DB80 Offset: 0x264C180 VA: 0x18264DB80
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0x264CCC0 Offset: 0x264B2C0 VA: 0x18264CCC0
	public InputField.InputType get_inputType() { }

	// RVA: 0x264DAA0 Offset: 0x264C0A0 VA: 0x18264DAA0
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x19DB700 Offset: 0x19D9D00 VA: 0x1819DB700
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x264DB10 Offset: 0x264C110 VA: 0x18264DB10
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x561240 Offset: 0x55F840 VA: 0x180561240
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x264D750 Offset: 0x264BD50 VA: 0x18264D750
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x1791C40 Offset: 0x1790240 VA: 0x181791C40
	public bool get_readOnly() { }

	// RVA: 0x1E998D0 Offset: 0x1E97ED0 VA: 0x181E998D0
	public void set_readOnly(bool value) { }

	// RVA: 0x264CEA0 Offset: 0x264B4A0 VA: 0x18264CEA0
	public bool get_multiLine() { }

	// RVA: 0x264C9E0 Offset: 0x264AFE0 VA: 0x18264C9E0
	public char get_asteriskChar() { }

	// RVA: 0x264D370 Offset: 0x264B970 VA: 0x18264D370
	public void set_asteriskChar(char value) { }

	// RVA: 0x264D360 Offset: 0x264B960 VA: 0x18264D360
	public bool get_wasCanceled() { }

	// RVA: 0x2643F40 Offset: 0x2642540 VA: 0x182643F40
	protected void ClampPos(ref int pos) { }

	// RVA: 0x264CAE0 Offset: 0x264B0E0 VA: 0x18264CAE0
	protected int get_caretPositionInternal() { }

	// RVA: 0x264D4B0 Offset: 0x264BAB0 VA: 0x18264D4B0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x264CB10 Offset: 0x264B110 VA: 0x18264CB10
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x264D5C0 Offset: 0x264BBC0 VA: 0x18264D5C0
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x264CC50 Offset: 0x264B250 VA: 0x18264CC50
	private bool get_hasSelection() { }

	// RVA: 0x264CB10 Offset: 0x264B110 VA: 0x18264CB10
	public int get_caretPosition() { }

	// RVA: 0x264D500 Offset: 0x264BB00 VA: 0x18264D500
	public void set_caretPosition(int value) { }

	// RVA: 0x264CAE0 Offset: 0x264B0E0 VA: 0x18264CAE0
	public int get_selectionAnchorPosition() { }

	// RVA: 0x264DDF0 Offset: 0x264C3F0 VA: 0x18264DDF0
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x264CB10 Offset: 0x264B110 VA: 0x18264CB10
	public int get_selectionFocusPosition() { }

	// RVA: 0x264DED0 Offset: 0x264C4D0 VA: 0x18264DED0
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x2649280 Offset: 0x2647880 VA: 0x182649280 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2648D20 Offset: 0x2647320 VA: 0x182648D20 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2648CC0 Offset: 0x26472C0 VA: 0x182648CC0 Slot: 8
	protected override void OnDestroy() { }

	[IteratorStateMachine(typeof(InputField.<CaretBlink>d__170))]
	// RVA: 0x2643ED0 Offset: 0x26424D0 VA: 0x182643ED0
	private IEnumerator CaretBlink() { }

	// RVA: 0x264A460 Offset: 0x2648A60 VA: 0x18264A460
	private void SetCaretVisible() { }

	// RVA: 0x264A3A0 Offset: 0x26489A0 VA: 0x18264A3A0
	private void SetCaretActive() { }

	// RVA: 0x264B3D0 Offset: 0x26499D0 VA: 0x18264B3D0
	private void UpdateCaretMaterial() { }

	// RVA: 0x26496F0 Offset: 0x2647CF0 VA: 0x1826496F0
	protected void OnFocus() { }

	// RVA: 0x264A170 Offset: 0x2648770 VA: 0x18264A170
	protected void SelectAll() { }

	// RVA: 0x2648860 Offset: 0x2646E60 VA: 0x182648860
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x2648980 Offset: 0x2646F80 VA: 0x182648980
	public void MoveTextStart(bool shift) { }

	// RVA: 0x264CB50 Offset: 0x264B150 VA: 0x18264CB50
	private static string get_clipboard() { }

	// RVA: 0x264D7C0 Offset: 0x264BDC0 VA: 0x18264D7C0
	private static void set_clipboard(string value) { }

	// RVA: 0x264B200 Offset: 0x2649800 VA: 0x18264B200
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x26469F0 Offset: 0x2644FF0 VA: 0x1826469F0
	private bool InPlaceEditing() { }

	// RVA: 0x2646970 Offset: 0x2644F70 VA: 0x182646970
	private bool InPlaceEditingChanged() { }

	// RVA: 0x2646310 Offset: 0x2644910 VA: 0x182646310
	private RangeInt GetInternalSelection() { }

	// RVA: 0x264B9B0 Offset: 0x2649FB0 VA: 0x18264B9B0
	private void UpdateKeyboardCaret() { }

	// RVA: 0x264B2A0 Offset: 0x26498A0 VA: 0x18264B2A0
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x2647370 Offset: 0x2645970 VA: 0x182647370 Slot: 61
	protected virtual void LateUpdate() { }

	[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
	// RVA: 0x2649C50 Offset: 0x2648250 VA: 0x182649C50
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x2646700 Offset: 0x2644D00 VA: 0x182646700
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x26460D0 Offset: 0x26446D0 VA: 0x1826460D0
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x2647F80 Offset: 0x2646580 VA: 0x182647F80
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x2648C60 Offset: 0x2647260 VA: 0x182648C60 Slot: 62
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2648FA0 Offset: 0x26475A0 VA: 0x182648FA0 Slot: 63
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(InputField.<MouseDragOutsideRect>d__194))]
	// RVA: 0x2648070 Offset: 0x2646670 VA: 0x182648070
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x2649500 Offset: 0x2647B00 VA: 0x182649500 Slot: 64
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2649730 Offset: 0x2647D30 VA: 0x182649730 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2646CF0 Offset: 0x26452F0 VA: 0x182646CF0
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x2646C90 Offset: 0x2645290 VA: 0x182646C90
	private bool IsValidChar(char c) { }

	// RVA: 0x2649C30 Offset: 0x2648230 VA: 0x182649C30
	public void ProcessEvent(Event e) { }

	// RVA: 0x2649A60 Offset: 0x2648060 VA: 0x182649A60 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x2646600 Offset: 0x2644C00 VA: 0x182646600
	private string GetSelectedString() { }

	// RVA: 0x2644AD0 Offset: 0x26430D0 VA: 0x182644AD0
	private int FindtNextWordBegin() { }

	// RVA: 0x26485B0 Offset: 0x2646BB0 VA: 0x1826485B0
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x2644BD0 Offset: 0x26431D0 VA: 0x182644BD0
	private int FindtPrevWordBegin() { }

	// RVA: 0x2648330 Offset: 0x2646930 VA: 0x182648330
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x26446D0 Offset: 0x2642CD0 VA: 0x1826446D0
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x2647D10 Offset: 0x2646310 VA: 0x182647D10
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x2647A60 Offset: 0x2646060 VA: 0x182647A60
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x2648320 Offset: 0x2646920 VA: 0x182648320
	private void MoveDown(bool shift) { }

	// RVA: 0x2648100 Offset: 0x2646700 VA: 0x182648100
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x2648A70 Offset: 0x2647070 VA: 0x182648A70
	private void MoveUp(bool shift) { }

	// RVA: 0x2648A80 Offset: 0x2647080 VA: 0x182648A80
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x2644390 Offset: 0x2642990 VA: 0x182644390
	private void Delete() { }

	// RVA: 0x2644CC0 Offset: 0x26432C0 VA: 0x182644CC0
	private void ForwardSpace() { }

	// RVA: 0x2643D50 Offset: 0x2642350 VA: 0x182643D50
	private void Backspace() { }

	// RVA: 0x2646A20 Offset: 0x2645020 VA: 0x182646A20
	private void Insert(char c) { }

	// RVA: 0x264BF90 Offset: 0x264A590 VA: 0x18264BF90
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x264A300 Offset: 0x2648900 VA: 0x18264A300
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x264A320 Offset: 0x2648920 VA: 0x18264A320
	private void SendOnValueChanged() { }

	// RVA: 0x264A200 Offset: 0x2648800 VA: 0x18264A200
	protected void SendOnEndEdit() { }

	// RVA: 0x264A280 Offset: 0x2648880 VA: 0x18264A280
	protected void SendOnSubmit() { }

	// RVA: 0x2643570 Offset: 0x2641B70 VA: 0x182643570 Slot: 66
	protected virtual void Append(string input) { }

	// RVA: 0x26431F0 Offset: 0x26417F0 VA: 0x1826431F0 Slot: 67
	protected virtual void Append(char input) { }

	// RVA: 0x264BA80 Offset: 0x264A080 VA: 0x18264BA80
	protected void UpdateLabel() { }

	// RVA: 0x2646BC0 Offset: 0x26451C0 VA: 0x182646BC0
	private bool IsSelectionVisible() { }

	// RVA: 0x26464E0 Offset: 0x2644AE0 VA: 0x1826464E0
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x2646420 Offset: 0x2644A20 VA: 0x182646420
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x264A4A0 Offset: 0x2648AA0 VA: 0x18264A4A0
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x2644CB0 Offset: 0x26432B0 VA: 0x182644CB0
	public void ForceLabelUpdate() { }

	// RVA: 0x2647F30 Offset: 0x2646530 VA: 0x182647F30
	private void MarkGeometryAsDirty() { }

	// RVA: 0x2649C40 Offset: 0x2648240 VA: 0x182649C40 Slot: 68
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 69
	public virtual void LayoutComplete() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 70
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x264B4E0 Offset: 0x2649AE0 VA: 0x18264B4E0
	private void UpdateGeometry() { }

	// RVA: 0x2643620 Offset: 0x2641C20 VA: 0x182643620
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x2649530 Offset: 0x2647B30 VA: 0x182649530
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x2644DE0 Offset: 0x26433E0 VA: 0x182644DE0
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x2643F80 Offset: 0x2642580 VA: 0x182643F80
	private void CreateCursorVerts() { }

	// RVA: 0x26458A0 Offset: 0x2643EA0 VA: 0x1826458A0
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x264BFF0 Offset: 0x264A5F0 VA: 0x18264BFF0
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x26430B0 Offset: 0x26416B0 VA: 0x1826430B0
	public void ActivateInputField() { }

	// RVA: 0x2642C60 Offset: 0x2641260 VA: 0x182642C60
	private void ActivateInputFieldInternal() { }

	// RVA: 0x26499D0 Offset: 0x2647FD0 VA: 0x1826499D0 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x2649700 Offset: 0x2647D00 VA: 0x182649700 Slot: 71
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2644140 Offset: 0x2642740 VA: 0x182644140
	public void DeactivateInputField() { }

	// RVA: 0x2648C90 Offset: 0x2647290 VA: 0x182648C90 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2649A10 Offset: 0x2648010 VA: 0x182649A10 Slot: 72
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2644830 Offset: 0x2642E30 VA: 0x182644830
	private void EnforceContentType() { }

	// RVA: 0x2644A20 Offset: 0x2643020 VA: 0x182644A20
	private void EnforceTextHOverflow() { }

	// RVA: 0x264B180 Offset: 0x2649780 VA: 0x18264B180
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x264B1E0 Offset: 0x26497E0 VA: 0x18264B1E0
	private void SetToCustom() { }

	// RVA: 0x2644800 Offset: 0x2642E00 VA: 0x182644800 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 73
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 74
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x264CE90 Offset: 0x264B490 VA: 0x18264CE90 Slot: 75
	public virtual float get_minWidth() { }

	// RVA: 0x264D0A0 Offset: 0x264B6A0 VA: 0x18264D0A0 Slot: 76
	public virtual float get_preferredWidth() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 77
	public virtual float get_flexibleWidth() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 78
	public virtual float get_minHeight() { }

	// RVA: 0x264CEC0 Offset: 0x264B4C0 VA: 0x18264CEC0 Slot: 79
	public virtual float get_preferredHeight() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 80
	public virtual float get_flexibleHeight() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 81
	public virtual int get_layoutPriority() { }

	// RVA: 0x264C700 Offset: 0x264AD00 VA: 0x18264C700
	private static void .cctor() { }

	// RVA: 0x21AC2C0 Offset: 0x21AA8C0 VA: 0x1821AC2C0 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 12149
{
	// Fields
	[SerializeField]
	private AspectRatioFitter.AspectMode m_AspectMode; // 0x20
	[SerializeField]
	private float m_AspectRatio; // 0x24
	private RectTransform m_Rect; // 0x28
	private bool m_DelayedSetDirty; // 0x30
	private bool m_DoesParentExist; // 0x31
	private DrivenRectTransformTracker m_Tracker; // 0x32

	// Properties
	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x263FDA0 Offset: 0x263E3A0 VA: 0x18263FDA0
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x3CB490 Offset: 0x3C9A90 VA: 0x1803CB490
	public float get_aspectRatio() { }

	// RVA: 0x263FE00 Offset: 0x263E400 VA: 0x18263FE00
	public void set_aspectRatio(float value) { }

	// RVA: 0x263FD10 Offset: 0x263E310 VA: 0x18263FD10
	private RectTransform get_rectTransform() { }

	// RVA: 0x263FD00 Offset: 0x263E300 VA: 0x18263FD00
	protected void .ctor() { }

	// RVA: 0x263F710 Offset: 0x263DD10 VA: 0x18263F710 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x263F860 Offset: 0x263DE60 VA: 0x18263F860 Slot: 6
	protected override void Start() { }

	// RVA: 0x263F690 Offset: 0x263DC90 VA: 0x18263F690 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x263F7C0 Offset: 0x263DDC0 VA: 0x18263F7C0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x263FCE0 Offset: 0x263E2E0 VA: 0x18263FCE0 Slot: 19
	protected virtual void Update() { }

	// RVA: 0x263F7B0 Offset: 0x263DDB0 VA: 0x18263F7B0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x263F8B0 Offset: 0x263DEB0 VA: 0x18263F8B0
	private void UpdateRect() { }

	// RVA: 0x263F3F0 Offset: 0x263D9F0 VA: 0x18263F3F0
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x263F2F0 Offset: 0x263D8F0 VA: 0x18263F2F0
	private Vector2 GetParentSize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x263F7B0 Offset: 0x263DDB0 VA: 0x18263F7B0
	protected void SetDirty() { }

	// RVA: 0x263F5E0 Offset: 0x263DBE0 VA: 0x18263F5E0
	public bool IsComponentValidOnObject() { }

	// RVA: 0x263F5C0 Offset: 0x263DBC0 VA: 0x18263F5C0
	public bool IsAspectModeValid() { }

	// RVA: 0x16ADFC0 Offset: 0x16AC5C0 VA: 0x1816ADFC0
	private bool DoesParentExists() { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(Canvas))]
[ExecuteAlways]
[AddComponentMenu("Layout/Canvas Scaler", 101)]
[DisallowMultipleComponent]
public class CanvasScaler : UIBehaviour // TypeDefIndex: 12153
{
	// Fields
	[Tooltip("Determines how UI elements in the Canvas are scaled.")]
	[SerializeField]
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x20
	[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
	[SerializeField]
	protected float m_ReferencePixelsPerUnit; // 0x24
	[Tooltip("Scales all UI elements in the Canvas by this factor.")]
	[SerializeField]
	protected float m_ScaleFactor; // 0x28
	[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
	[SerializeField]
	protected Vector2 m_ReferenceResolution; // 0x2C
	[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
	[SerializeField]
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x34
	[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
	[Range(0, 1)]
	[SerializeField]
	protected float m_MatchWidthOrHeight; // 0x38
	private const float kLogBase = 2;
	[Tooltip("The physical unit to specify positions and sizes in.")]
	[SerializeField]
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x3C
	[Tooltip("The DPI to assume if the screen DPI is not known.")]
	[SerializeField]
	protected float m_FallbackScreenDPI; // 0x40
	[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
	[SerializeField]
	protected float m_DefaultSpriteDPI; // 0x44
	[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
	[SerializeField]
	protected float m_DynamicPixelsPerUnit; // 0x48
	private Canvas m_Canvas; // 0x50
	private float m_PrevScaleFactor; // 0x58
	private float m_PrevReferencePixelsPerUnit; // 0x5C
	[SerializeField]
	protected bool m_PresetInfoIsWorld; // 0x60

	// Properties
	public CanvasScaler.ScaleMode uiScaleMode { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public float scaleFactor { get; set; }
	public Vector2 referenceResolution { get; set; }
	public CanvasScaler.ScreenMatchMode screenMatchMode { get; set; }
	public float matchWidthOrHeight { get; set; }
	public CanvasScaler.Unit physicalUnit { get; set; }
	public float fallbackScreenDPI { get; set; }
	public float defaultSpriteDPI { get; set; }
	public float dynamicPixelsPerUnit { get; set; }

	// Methods

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	// RVA: 0xA63230 Offset: 0xA61830 VA: 0x180A63230
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x3CB490 Offset: 0x3C9A90 VA: 0x1803CB490
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x3CB500 Offset: 0x3C9B00 VA: 0x1803CB500
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x3CB4A0 Offset: 0x3C9AA0 VA: 0x1803CB4A0
	public float get_scaleFactor() { }

	// RVA: 0x26406B0 Offset: 0x263ECB0 VA: 0x1826406B0
	public void set_scaleFactor(float value) { }

	// RVA: 0x26405F0 Offset: 0x263EBF0 VA: 0x1826405F0
	public Vector2 get_referenceResolution() { }

	// RVA: 0x2640630 Offset: 0x263EC30 VA: 0x182640630
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x10051A0 Offset: 0x10037A0 VA: 0x1810051A0
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x10051F0 Offset: 0x10037F0 VA: 0x1810051F0
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x5590D0 Offset: 0x5576D0 VA: 0x1805590D0
	public float get_matchWidthOrHeight() { }

	// RVA: 0x559130 Offset: 0x557730 VA: 0x180559130
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x46A6E0 Offset: 0x468CE0 VA: 0x18046A6E0
	public float get_fallbackScreenDPI() { }

	// RVA: 0x46E240 Offset: 0x46C840 VA: 0x18046E240
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x46E1F0 Offset: 0x46C7F0 VA: 0x18046E1F0
	public float get_defaultSpriteDPI() { }

	// RVA: 0x2640610 Offset: 0x263EC10 VA: 0x182640610
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x187F560 Offset: 0x187DB60 VA: 0x18187F560
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x1F0DA10 Offset: 0x1F0C010 VA: 0x181F0DA10
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x26405A0 Offset: 0x263EBA0 VA: 0x1826405A0
	protected void .ctor() { }

	// RVA: 0x2640460 Offset: 0x263EA60 VA: 0x182640460 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0xD13970 Offset: 0xD11F70 VA: 0x180D13970
	private void Canvas_preWillRenderCanvases() { }

	// RVA: 0x2640390 Offset: 0x263E990 VA: 0x182640390 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2640270 Offset: 0x263E870 VA: 0x182640270 Slot: 17
	protected virtual void Handle() { }

	// RVA: 0x2640200 Offset: 0x263E800 VA: 0x182640200 Slot: 18
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x263FF40 Offset: 0x263E540 VA: 0x18263FF40 Slot: 19
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x263FFB0 Offset: 0x263E5B0 VA: 0x18263FFB0 Slot: 20
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x263FE60 Offset: 0x263E460 VA: 0x18263FE60 Slot: 21
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x2640560 Offset: 0x263EB60 VA: 0x182640560
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x2640520 Offset: 0x263EB20 VA: 0x182640520
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Content Size Fitter", 141)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 12155
{
	// Fields
	[SerializeField]
	protected ContentSizeFitter.FitMode m_HorizontalFit; // 0x20
	[SerializeField]
	protected ContentSizeFitter.FitMode m_VerticalFit; // 0x24
	private RectTransform m_Rect; // 0x28
	private DrivenRectTransformTracker m_Tracker; // 0x30

	// Properties
	public ContentSizeFitter.FitMode horizontalFit { get; set; }
	public ContentSizeFitter.FitMode verticalFit { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public ContentSizeFitter.FitMode get_horizontalFit() { }

	// RVA: 0x2640B20 Offset: 0x263F120 VA: 0x182640B20
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x2640B80 Offset: 0x263F180 VA: 0x182640B80
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x2640A90 Offset: 0x263F090 VA: 0x182640A90
	private RectTransform get_rectTransform() { }

	// RVA: 0x365090 Offset: 0x363690 VA: 0x180365090
	protected void .ctor() { }

	// RVA: 0x2640830 Offset: 0x263EE30 VA: 0x182640830 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x26407B0 Offset: 0x263EDB0 VA: 0x1826407B0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2640850 Offset: 0x263EE50 VA: 0x182640850 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x26406D0 Offset: 0x263ECD0 VA: 0x1826406D0
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x26408E0 Offset: 0x263EEE0 VA: 0x1826408E0 Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x26409C0 Offset: 0x263EFC0 VA: 0x1826409C0 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x2640860 Offset: 0x263EE60 VA: 0x182640860
	protected void SetDirty() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Grid Layout Group", 152)]
public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 12159
{
	// Fields
	[SerializeField]
	protected GridLayoutGroup.Corner m_StartCorner; // 0x60
	[SerializeField]
	protected GridLayoutGroup.Axis m_StartAxis; // 0x64
	[SerializeField]
	protected Vector2 m_CellSize; // 0x68
	[SerializeField]
	protected Vector2 m_Spacing; // 0x70
	[SerializeField]
	protected GridLayoutGroup.Constraint m_Constraint; // 0x78
	[SerializeField]
	protected int m_ConstraintCount; // 0x7C

	// Properties
	public GridLayoutGroup.Corner startCorner { get; set; }
	public GridLayoutGroup.Axis startAxis { get; set; }
	public Vector2 cellSize { get; set; }
	public Vector2 spacing { get; set; }
	public GridLayoutGroup.Constraint constraint { get; set; }
	public int constraintCount { get; set; }

	// Methods

	// RVA: 0x3848A0 Offset: 0x382EA0 VA: 0x1803848A0
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x2641AB0 Offset: 0x26400B0 VA: 0x182641AB0
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x3F3740 Offset: 0x3F1D40 VA: 0x1803F3740
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x2641A60 Offset: 0x2640060 VA: 0x182641A60
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0xC9D760 Offset: 0xC9BD60 VA: 0x180C9D760
	public Vector2 get_cellSize() { }

	// RVA: 0x26418F0 Offset: 0x263FEF0 VA: 0x1826418F0
	public void set_cellSize(Vector2 value) { }

	// RVA: 0xC9D650 Offset: 0xC9BC50 VA: 0x180C9D650
	public Vector2 get_spacing() { }

	// RVA: 0x2641A00 Offset: 0x2640000 VA: 0x182641A00
	public void set_spacing(Vector2 value) { }

	// RVA: 0x1869360 Offset: 0x1867960 VA: 0x181869360
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x26419B0 Offset: 0x263FFB0 VA: 0x1826419B0
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0x15D1060 Offset: 0x15CF660 VA: 0x1815D1060
	public int get_constraintCount() { }

	// RVA: 0x2641950 Offset: 0x263FF50 VA: 0x182641950
	public void set_constraintCount(int value) { }

	// RVA: 0x2641880 Offset: 0x263FE80 VA: 0x182641880
	protected void .ctor() { }

	// RVA: 0x2640C60 Offset: 0x263F260 VA: 0x182640C60 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x2640E60 Offset: 0x263F460 VA: 0x182640E60 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x2641860 Offset: 0x263FE60 VA: 0x182641860 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x2641870 Offset: 0x263FE70 VA: 0x182641870 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x2641060 Offset: 0x263F660 VA: 0x182641060
	private void SetCellsAlongAxis(int axis) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 12160
{
	// Methods

	// RVA: 0x2641B60 Offset: 0x2640160 VA: 0x182641B60
	protected void .ctor() { }

	// RVA: 0x2641B00 Offset: 0x2640100 VA: 0x182641B00 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x2641B30 Offset: 0x2640130 VA: 0x182641B30 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x2641B40 Offset: 0x2640140 VA: 0x182641B40 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x2641B50 Offset: 0x2640150 VA: 0x182641B50 Slot: 38
	public override void SetLayoutVertical() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 12161
{
	// Fields
	[SerializeField]
	protected float m_Spacing; // 0x60
	[SerializeField]
	protected bool m_ChildForceExpandWidth; // 0x64
	[SerializeField]
	protected bool m_ChildForceExpandHeight; // 0x65
	[SerializeField]
	protected bool m_ChildControlWidth; // 0x66
	[SerializeField]
	protected bool m_ChildControlHeight; // 0x67
	[SerializeField]
	protected bool m_ChildScaleWidth; // 0x68
	[SerializeField]
	protected bool m_ChildScaleHeight; // 0x69
	[SerializeField]
	protected bool m_ReverseArrangement; // 0x6A

	// Properties
	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }
	public bool reverseArrangement { get; set; }

	// Methods

	// RVA: 0x187F570 Offset: 0x187DB70 VA: 0x18187F570
	public float get_spacing() { }

	// RVA: 0x2642C10 Offset: 0x2641210 VA: 0x182642C10
	public void set_spacing(float value) { }

	// RVA: 0x25D0200 Offset: 0x25CE800 VA: 0x1825D0200
	public bool get_childForceExpandWidth() { }

	// RVA: 0x2642AD0 Offset: 0x26410D0 VA: 0x182642AD0
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x1AF3940 Offset: 0x1AF1F40 VA: 0x181AF3940
	public bool get_childForceExpandHeight() { }

	// RVA: 0x2642A80 Offset: 0x2641080 VA: 0x182642A80
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x1AF2E30 Offset: 0x1AF1430 VA: 0x181AF2E30
	public bool get_childControlWidth() { }

	// RVA: 0x2642A30 Offset: 0x2641030 VA: 0x182642A30
	public void set_childControlWidth(bool value) { }

	// RVA: 0x1AF2E20 Offset: 0x1AF1420 VA: 0x181AF2E20
	public bool get_childControlHeight() { }

	// RVA: 0x26429E0 Offset: 0x2640FE0 VA: 0x1826429E0
	public void set_childControlHeight(bool value) { }

	// RVA: 0x528950 Offset: 0x526F50 VA: 0x180528950
	public bool get_childScaleWidth() { }

	// RVA: 0x2642B70 Offset: 0x2641170 VA: 0x182642B70
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x534E70 Offset: 0x533470 VA: 0x180534E70
	public bool get_childScaleHeight() { }

	// RVA: 0x2642B20 Offset: 0x2641120 VA: 0x182642B20
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x1CC49C0 Offset: 0x1CC2FC0 VA: 0x181CC49C0
	public bool get_reverseArrangement() { }

	// RVA: 0x2642BC0 Offset: 0x26411C0 VA: 0x182642BC0
	public void set_reverseArrangement(bool value) { }

	// RVA: 0x2641B70 Offset: 0x2640170 VA: 0x182641B70
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x2642080 Offset: 0x2640680 VA: 0x182642080
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x2641F70 Offset: 0x2640570 VA: 0x182641F70
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x2641B60 Offset: 0x2640160 VA: 0x182641B60
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
public interface ILayoutElement // TypeDefIndex: 12162
{
	// Properties
	public abstract float minWidth { get; }
	public abstract float preferredWidth { get; }
	public abstract float flexibleWidth { get; }
	public abstract float minHeight { get; }
	public abstract float preferredHeight { get; }
	public abstract float flexibleHeight { get; }
	public abstract int layoutPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CalculateLayoutInputHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CalculateLayoutInputVertical();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_minWidth();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_preferredWidth();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_flexibleWidth();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_minHeight();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_preferredHeight();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_flexibleHeight();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_layoutPriority();
}

// Namespace: UnityEngine.UI
public interface ILayoutController // TypeDefIndex: 12163
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetLayoutVertical();
}

// Namespace: UnityEngine.UI
public interface ILayoutGroup : ILayoutController // TypeDefIndex: 12164
{}

// Namespace: UnityEngine.UI
public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 12165
{}

// Namespace: UnityEngine.UI
public interface ILayoutIgnorer // TypeDefIndex: 12166
{
	// Properties
	public abstract bool ignoreLayout { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_ignoreLayout();
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Layout Element", 140)]
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 12167
{
	// Fields
	[SerializeField]
	private bool m_IgnoreLayout; // 0x20
	[SerializeField]
	private float m_MinWidth; // 0x24
	[SerializeField]
	private float m_MinHeight; // 0x28
	[SerializeField]
	private float m_PreferredWidth; // 0x2C
	[SerializeField]
	private float m_PreferredHeight; // 0x30
	[SerializeField]
	private float m_FlexibleWidth; // 0x34
	[SerializeField]
	private float m_FlexibleHeight; // 0x38
	[SerializeField]
	private int m_LayoutPriority; // 0x3C

	// Properties
	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x264E440 Offset: 0x264CA40 VA: 0x18264E440 Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x3CB490 Offset: 0x3C9A90 VA: 0x1803CB490 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x264E560 Offset: 0x264CB60 VA: 0x18264E560 Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x3CB4A0 Offset: 0x3C9AA0 VA: 0x1803CB4A0 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x264E500 Offset: 0x264CB00 VA: 0x18264E500 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x4877C0 Offset: 0x485DC0 VA: 0x1804877C0 Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x264E620 Offset: 0x264CC20 VA: 0x18264E620 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x420BC0 Offset: 0x41F1C0 VA: 0x180420BC0 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x264E5C0 Offset: 0x264CBC0 VA: 0x18264E5C0 Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x43AEF0 Offset: 0x4394F0 VA: 0x18043AEF0 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x264E3E0 Offset: 0x264C9E0 VA: 0x18264E3E0 Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x5590D0 Offset: 0x5576D0 VA: 0x1805590D0 Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x264E380 Offset: 0x264C980 VA: 0x18264E380 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0 Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x264E4A0 Offset: 0x264CAA0 VA: 0x18264E4A0 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x264E340 Offset: 0x264C940 VA: 0x18264E340
	protected void .ctor() { }

	// RVA: 0x264E280 Offset: 0x264C880 VA: 0x18264E280 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x264E250 Offset: 0x264C850 VA: 0x18264E250 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x264E260 Offset: 0x264C860 VA: 0x18264E260 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x264E250 Offset: 0x264C850 VA: 0x18264E250 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x264E250 Offset: 0x264C850 VA: 0x18264E250 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x264E2A0 Offset: 0x264C8A0 VA: 0x18264E2A0
	protected void SetDirty() { }
}

// Namespace: UnityEngine.UI
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 12169
{
	// Fields
	[SerializeField]
	protected RectOffset m_Padding; // 0x20
	[SerializeField]
	protected TextAnchor m_ChildAlignment; // 0x28
	private RectTransform m_Rect; // 0x30
	protected DrivenRectTransformTracker m_Tracker; // 0x38
	private Vector2 m_TotalMinSize; // 0x3C
	private Vector2 m_TotalPreferredSize; // 0x44
	private Vector2 m_TotalFlexibleSize; // 0x4C
	private List<RectTransform> m_RectChildren; // 0x58

	// Properties
	public RectOffset padding { get; set; }
	public TextAnchor childAlignment { get; set; }
	protected RectTransform rectTransform { get; }
	protected List<RectTransform> rectChildren { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }
	private bool isRootLayoutGroup { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public RectOffset get_padding() { }

	// RVA: 0x264F9F0 Offset: 0x264DFF0 VA: 0x18264F9F0
	public void set_padding(RectOffset value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public TextAnchor get_childAlignment() { }

	// RVA: 0x264F9A0 Offset: 0x264DFA0 VA: 0x18264F9A0
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x264F910 Offset: 0x264DF10 VA: 0x18264F910
	protected RectTransform get_rectTransform() { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x264E680 Offset: 0x264CC80 VA: 0x18264E680 Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical();

	// RVA: 0x2173E70 Offset: 0x2172470 VA: 0x182173E70 Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x23E4390 Offset: 0x23E2990 VA: 0x1823E4390 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x23E43C0 Offset: 0x23E29C0 VA: 0x1823E43C0 Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x23A8F30 Offset: 0x23A7530 VA: 0x1823A8F30 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x23E43A0 Offset: 0x23E29A0 VA: 0x1823E43A0 Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x23E43D0 Offset: 0x23E29D0 VA: 0x1823E43D0 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical();

	// RVA: 0x264F650 Offset: 0x264DC50 VA: 0x18264F650
	protected void .ctor() { }

	// RVA: 0x264ECC0 Offset: 0x264D2C0 VA: 0x18264ECC0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x264EC40 Offset: 0x264D240 VA: 0x18264EC40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x264EC30 Offset: 0x264D230 VA: 0x18264EC30 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x264EC10 Offset: 0x264D210 VA: 0x18264EC10
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x264EC20 Offset: 0x264D220 VA: 0x18264EC20
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x264EC00 Offset: 0x264D200 VA: 0x18264EC00
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x264EA80 Offset: 0x264D080 VA: 0x18264EA80
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x264EA30 Offset: 0x264D030 VA: 0x18264EA30
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x264F5C0 Offset: 0x264DBC0 VA: 0x18264F5C0
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x264F340 Offset: 0x264D940 VA: 0x18264F340
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x264F0F0 Offset: 0x264D6F0 VA: 0x18264F0F0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x264F3E0 Offset: 0x264D9E0 VA: 0x18264F3E0
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x264EE10 Offset: 0x264D410 VA: 0x18264EE10
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x264F7F0 Offset: 0x264DDF0 VA: 0x18264F7F0
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x264ECE0 Offset: 0x264D2E0 VA: 0x18264ECE0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x264EC30 Offset: 0x264D230 VA: 0x18264EC30 Slot: 39
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: -1 Offset: -1
	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7155E0 Offset: 0x713BE0 VA: 0x1807155E0
	|-LayoutGroup.SetProperty<bool>
	|
	|-RVA: 0x715970 Offset: 0x713F70 VA: 0x180715970
	|-LayoutGroup.SetProperty<int>
	|
	|-RVA: 0x7158C0 Offset: 0x713EC0 VA: 0x1807158C0
	|-LayoutGroup.SetProperty<Int32Enum>
	|
	|-RVA: 0x7159F0 Offset: 0x713FF0 VA: 0x1807159F0
	|-LayoutGroup.SetProperty<object>
	|
	|-RVA: 0x715A60 Offset: 0x714060 VA: 0x180715A60
	|-LayoutGroup.SetProperty<float>
	|
	|-RVA: 0x715AF0 Offset: 0x7140F0 VA: 0x180715AF0
	|-LayoutGroup.SetProperty<Vector2>
	|
	|-RVA: 0x715680 Offset: 0x713C80 VA: 0x180715680
	|-LayoutGroup.SetProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x264F490 Offset: 0x264DA90 VA: 0x18264F490
	protected void SetDirty() { }

	[IteratorStateMachine(typeof(LayoutGroup.<DelayedSetDirty>d__56))]
	// RVA: 0x264E9C0 Offset: 0x264CFC0 VA: 0x18264E9C0
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }
}

// Namespace: UnityEngine.UI
public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 12171
{
	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x264FBD0 Offset: 0x264E1D0 VA: 0x18264FBD0
	private void Initialize(RectTransform controller) { }

	// RVA: 0x264FA40 Offset: 0x264E040 VA: 0x18264FA40
	private void Clear() { }

	// RVA: 0x26510D0 Offset: 0x264F6D0 VA: 0x1826510D0
	private static void .cctor() { }

	// RVA: 0x26509C0 Offset: 0x264EFC0 VA: 0x1826509C0
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x264FC20 Offset: 0x264E220 VA: 0x18264FC20 Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x2650D60 Offset: 0x264F360 VA: 0x182650D60
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x264FAD0 Offset: 0x264E0D0 VA: 0x18264FAD0
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x2650A10 Offset: 0x264F010 VA: 0x182650A10 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x2650610 Offset: 0x264EC10 VA: 0x182650610
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x26503A0 Offset: 0x264E9A0 VA: 0x1826503A0
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x264FCF0 Offset: 0x264E2F0 VA: 0x18264FCF0
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x2650EE0 Offset: 0x264F4E0 VA: 0x182650EE0
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x2650220 Offset: 0x264E820 VA: 0x182650220
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x264FC70 Offset: 0x264E270 VA: 0x18264FC70 Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x264FA70 Offset: 0x264E070 VA: 0x18264FA70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2650E80 Offset: 0x264F480 VA: 0x182650E80 Slot: 3
	public override string ToString() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public static class LayoutUtility // TypeDefIndex: 12173
{
	// Methods

	// RVA: 0x2651AE0 Offset: 0x26500E0 VA: 0x182651AE0
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x2651FD0 Offset: 0x26505D0 VA: 0x182651FD0
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x26513B0 Offset: 0x264F9B0 VA: 0x1826513B0
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x2651CD0 Offset: 0x26502D0 VA: 0x182651CD0
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x2652360 Offset: 0x2650960 VA: 0x182652360
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x26515A0 Offset: 0x264FBA0 VA: 0x1826515A0
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x26519D0 Offset: 0x264FFD0 VA: 0x1826519D0
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x2651DE0 Offset: 0x26503E0 VA: 0x182651DE0
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x26512A0 Offset: 0x264F8A0 VA: 0x1826512A0
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x26516B0 Offset: 0x264FCB0 VA: 0x1826516B0
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x26516D0 Offset: 0x264FCD0 VA: 0x1826516D0
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Vertical Layout Group", 151)]
public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 12174
{
	// Methods

	// RVA: 0x2641B60 Offset: 0x2640160 VA: 0x182641B60
	protected void .ctor() { }

	// RVA: 0x2655BC0 Offset: 0x26541C0 VA: 0x182655BC0 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x2655BF0 Offset: 0x26541F0 VA: 0x182655BF0 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x2655C00 Offset: 0x2654200 VA: 0x182655C00 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x2655C10 Offset: 0x2654210 VA: 0x182655C10 Slot: 38
	public override void SetLayoutVertical() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Mask", 13)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 12175
{
	// Fields
	private RectTransform m_RectTransform; // 0x20
	[SerializeField]
	private bool m_ShowMaskGraphic; // 0x28
	private Graphic m_Graphic; // 0x30
	private Material m_MaskMaterial; // 0x38
	private Material m_UnmaskMaterial; // 0x40

	// Properties
	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }

	// Methods

	// RVA: 0x26540C0 Offset: 0x26526C0 VA: 0x1826540C0
	public RectTransform get_rectTransform() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_showMaskGraphic() { }

	// RVA: 0x2654130 Offset: 0x2652730 VA: 0x182654130
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x2654050 Offset: 0x2652650 VA: 0x182654050
	public Graphic get_graphic() { }

	// RVA: 0x2654040 Offset: 0x2652640 VA: 0x182654040
	protected void .ctor() { }

	// RVA: 0x2653980 Offset: 0x2651F80 VA: 0x182653980 Slot: 19
	public virtual bool MaskEnabled() { }

	[Obsolete("Not used anymore.")]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x2653DB0 Offset: 0x26523B0 VA: 0x182653DB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2653A40 Offset: 0x2652040 VA: 0x182653A40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2653890 Offset: 0x2651E90 VA: 0x182653890 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x2653580 Offset: 0x2651B80 VA: 0x182653580 Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }
}

// Namespace: UnityEngine.UI
public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 12177
{
	// Fields
	protected bool m_ShouldRecalculateStencil; // 0xA8
	protected Material m_MaskMaterial; // 0xB0
	private RectMask2D m_ParentMask; // 0xB8
	[SerializeField]
	private bool m_Maskable; // 0xC0
	private bool m_IsMaskingGraphic; // 0xC1
	[EditorBrowsable(1)]
	[Obsolete("Not used anymore.", True)]
	protected bool m_IncludeForMasking; // 0xC2
	[SerializeField]
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xC8
	[EditorBrowsable(1)]
	[Obsolete("Not used anymore", True)]
	protected bool m_ShouldRecalculate; // 0xD0
	protected int m_StencilValue; // 0xD4
	private readonly Vector3[] m_Corners; // 0xD8

	// Properties
	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	public bool isMaskingGraphic { get; set; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x3A3700 Offset: 0x3A1D00 VA: 0x1803A3700
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x1621970 Offset: 0x161FF70 VA: 0x181621970
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x1AA21F0 Offset: 0x1AA07F0 VA: 0x181AA21F0
	public bool get_maskable() { }

	// RVA: 0x2654E60 Offset: 0x2653460 VA: 0x182654E60
	public void set_maskable(bool value) { }

	// RVA: 0x24F83A0 Offset: 0x24F69A0 VA: 0x1824F83A0
	public bool get_isMaskingGraphic() { }

	// RVA: 0x2654E50 Offset: 0x2653450 VA: 0x182654E50
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x2654390 Offset: 0x2652990 VA: 0x182654390 Slot: 58
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x2654210 Offset: 0x2652810 VA: 0x182654210 Slot: 59
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x2654990 Offset: 0x2652F90 VA: 0x182654990
	private void UpdateCull(bool cull) { }

	// RVA: 0x2654750 Offset: 0x2652D50 VA: 0x182654750 Slot: 60
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x26547B0 Offset: 0x2652DB0 VA: 0x1826547B0 Slot: 61
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x2654600 Offset: 0x2652C00 VA: 0x182654600 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2654540 Offset: 0x2652B40 VA: 0x182654540 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2654660 Offset: 0x2652C60 VA: 0x182654660 Slot: 12
	protected override void OnTransformParentChanged() { }

	[EditorBrowsable(1)]
	[Obsolete("Not used anymore.", True)]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 62
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x26544F0 Offset: 0x2652AF0 VA: 0x1826544F0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x2654B60 Offset: 0x2653160 VA: 0x182654B60
	private Rect get_rootCanvasRect() { }

	// RVA: 0x2654800 Offset: 0x2652E00 VA: 0x182654800
	private void UpdateClipParent() { }

	// RVA: 0x26546B0 Offset: 0x2652CB0 VA: 0x1826546B0 Slot: 63
	public virtual void RecalculateClipping() { }

	// RVA: 0x26546C0 Offset: 0x2652CC0 VA: 0x1826546C0 Slot: 64
	public virtual void RecalculateMasking() { }

	// RVA: 0x2654A60 Offset: 0x2653060 VA: 0x182654A60
	protected void .ctor() { }

	// RVA: 0x26547F0 Offset: 0x2652DF0 VA: 0x1826547F0 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }
}

// Namespace: UnityEngine.UI
public class MaskUtilities // TypeDefIndex: 12178
{
	// Methods

	// RVA: 0x2653160 Offset: 0x2651760 VA: 0x182653160
	public static void Notify2DMaskStateChanged(Component mask) { }

	// RVA: 0x2653370 Offset: 0x2651970 VA: 0x182653370
	public static void NotifyStencilStateChanged(Component mask) { }

	// RVA: 0x2652550 Offset: 0x2650B50 VA: 0x182652550
	public static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x2652D50 Offset: 0x2651350 VA: 0x182652D50
	public static int GetStencilDepth(Transform transform, Transform stopAfter) { }

	// RVA: 0x2652FF0 Offset: 0x26515F0 VA: 0x182652FF0
	public static bool IsDescendantOrSelf(Transform father, Transform child) { }

	// RVA: 0x26526D0 Offset: 0x2650CD0 VA: 0x1826526D0
	public static RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	// RVA: 0x2652A00 Offset: 0x2651000 VA: 0x182652A00
	public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public interface IMaterialModifier // TypeDefIndex: 12179
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material GetModifiedMaterial(Material baseMaterial);
}

// Namespace: UnityEngine.UI
internal static class Misc // TypeDefIndex: 12180
{
	// Methods

	// RVA: 0x26565B0 Offset: 0x2654BB0 VA: 0x1826565B0
	public static void Destroy(Object obj) { }

	// RVA: 0x26564F0 Offset: 0x2654AF0 VA: 0x1826564F0
	public static void DestroyImmediate(Object obj) { }
}

// Namespace: UnityEngine.UI
internal static class MultipleDisplayUtilities // TypeDefIndex: 12181
{
	// Methods

	// RVA: 0x26566D0 Offset: 0x2654CD0 VA: 0x1826566D0
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position) { }

	// RVA: 0x26567B0 Offset: 0x2654DB0 VA: 0x1826567B0
	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	// RVA: 0x26568C0 Offset: 0x2654EC0 VA: 0x1826568C0
	public static Vector3 RelativeMouseAtScaled(Vector2 position) { }
}

// Namespace: UnityEngine.UI
[Serializable]
public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 12183
{
	// Fields
	[SerializeField]
	private Navigation.Mode m_Mode; // 0x0
	[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
	[SerializeField]
	private bool m_WrapAround; // 0x4
	[SerializeField]
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField]
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField]
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField]
	private Selectable m_SelectOnRight; // 0x20

	// Properties
	public Navigation.Mode mode { get; set; }
	public bool wrapAround { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }

	// Methods

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public Navigation.Mode get_mode() { }

	// RVA: 0x58E190 Offset: 0x58C790 VA: 0x18058E190
	public void set_mode(Navigation.Mode value) { }

	// RVA: 0x1105D60 Offset: 0x1104360 VA: 0x181105D60
	public bool get_wrapAround() { }

	// RVA: 0x22D6360 Offset: 0x22D4960 VA: 0x1822D6360
	public void set_wrapAround(bool value) { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public Selectable get_selectOnUp() { }

	// RVA: 0x971490 Offset: 0x96FA90 VA: 0x180971490
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Selectable get_selectOnDown() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Selectable get_selectOnLeft() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Selectable get_selectOnRight() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x2657030 Offset: 0x2655630 VA: 0x182657030
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x2656F20 Offset: 0x2655520 VA: 0x182656F20 Slot: 4
	public bool Equals(Navigation other) { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/Raw Image", 12)]
public class RawImage : MaskableGraphic // TypeDefIndex: 12184
{
	// Fields
	[FormerlySerializedAs("m_Tex")]
	[SerializeField]
	private Texture m_Texture; // 0xE0
	[SerializeField]
	private Rect m_UVRect; // 0xE8

	// Properties
	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }

	// Methods

	// RVA: 0x2657CC0 Offset: 0x26562C0 VA: 0x182657CC0
	protected void .ctor() { }

	// RVA: 0x2657CF0 Offset: 0x26562F0 VA: 0x182657CF0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	public Texture get_texture() { }

	// RVA: 0x2657E80 Offset: 0x2656480 VA: 0x182657E80
	public void set_texture(Texture value) { }

	// RVA: 0x2657E70 Offset: 0x2656470 VA: 0x182657E70
	public Rect get_uvRect() { }

	// RVA: 0x2657F30 Offset: 0x2656530 VA: 0x182657F30
	public void set_uvRect(Rect value) { }

	// RVA: 0x2657B50 Offset: 0x2656150 VA: 0x182657B50 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x2657730 Offset: 0x2655D30 VA: 0x182657730 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x244F460 Offset: 0x244DA60 VA: 0x18244F460 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Rect Mask 2D", 14)]
[ExecuteAlways]
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 12185
{
	// Fields
	private readonly RectangularVertexClipper m_VertexClipper; // 0x20
	private RectTransform m_RectTransform; // 0x28
	private HashSet<MaskableGraphic> m_MaskableTargets; // 0x30
	private HashSet<IClippable> m_ClipTargets; // 0x38
	private bool m_ShouldRecalculateClipRects; // 0x40
	private List<RectMask2D> m_Clippers; // 0x48
	private Rect m_LastClipRectCanvasSpace; // 0x50
	private bool m_ForceClip; // 0x60
	[SerializeField]
	private Vector4 m_Padding; // 0x64
	[SerializeField]
	private Vector2Int m_Softness; // 0x74
	private Canvas m_Canvas; // 0x80
	private Vector3[] m_Corners; // 0x88

	// Properties
	public Vector4 padding { get; set; }
	public Vector2Int softness { get; set; }
	internal Canvas Canvas { get; }
	public Rect canvasRect { get; }
	public RectTransform rectTransform { get; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x2659980 Offset: 0x2657F80 VA: 0x182659980
	public Vector4 get_padding() { }

	// RVA: 0x2659C00 Offset: 0x2658200 VA: 0x182659C00
	public void set_padding(Vector4 value) { }

	// RVA: 0x2659BF0 Offset: 0x26581F0 VA: 0x182659BF0
	public Vector2Int get_softness() { }

	// RVA: 0x2659C10 Offset: 0x2658210 VA: 0x182659C10
	public void set_softness(Vector2Int value) { }

	// RVA: 0x2659750 Offset: 0x2657D50 VA: 0x182659750
	internal Canvas get_Canvas() { }

	// RVA: 0x26598C0 Offset: 0x2657EC0 VA: 0x1826598C0
	public Rect get_canvasRect() { }

	// RVA: 0x2659990 Offset: 0x2657F90 VA: 0x182659990
	public RectTransform get_rectTransform() { }

	// RVA: 0x26595E0 Offset: 0x2657BE0 VA: 0x1826595E0
	protected void .ctor() { }

	// RVA: 0x2658740 Offset: 0x2656D40 VA: 0x182658740 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2658680 Offset: 0x2656C80 VA: 0x182658680 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2658660 Offset: 0x2656C60 VA: 0x182658660 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2658510 Offset: 0x2656B10 VA: 0x182658510 Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x2659A00 Offset: 0x2658000 VA: 0x182659A00
	private Rect get_rootCanvasRect() { }

	// RVA: 0x2658770 Offset: 0x2656D70 VA: 0x182658770 Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x26592C0 Offset: 0x26578C0 VA: 0x1826592C0 Slot: 21
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x2658400 Offset: 0x2656A00 VA: 0x182658400
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x2659110 Offset: 0x2657710 VA: 0x182659110
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x2658620 Offset: 0x2656C20 VA: 0x182658620 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2658620 Offset: 0x2656C20 VA: 0x182658620 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Scrollbar", 36)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 12190
{
	// Fields
	[SerializeField]
	private RectTransform m_HandleRect; // 0x100
	[SerializeField]
	private Scrollbar.Direction m_Direction; // 0x108
	[Range(0, 1)]
	[SerializeField]
	private float m_Value; // 0x10C
	[Range(0, 1)]
	[SerializeField]
	private float m_Size; // 0x110
	[Range(0, 11)]
	[SerializeField]
	private int m_NumberOfSteps; // 0x114
	[Space(6)]
	[SerializeField]
	private Scrollbar.ScrollEvent m_OnValueChanged; // 0x118
	private RectTransform m_ContainerRect; // 0x120
	private Vector2 m_Offset; // 0x128
	private DrivenRectTransformTracker m_Tracker; // 0x130
	private Coroutine m_PointerDownRepeat; // 0x138
	private bool isPointerDownAndNotDragging; // 0x140
	private bool m_DelayedUpdateVisuals; // 0x141

	// Properties
	public RectTransform handleRect { get; set; }
	public Scrollbar.Direction direction { get; set; }
	public float value { get; set; }
	public float size { get; set; }
	public int numberOfSteps { get; set; }
	public Scrollbar.ScrollEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Scrollbar.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public RectTransform get_handleRect() { }

	// RVA: 0x2661580 Offset: 0x265FB80 VA: 0x182661580
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x561250 Offset: 0x55F850 VA: 0x180561250
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x2661520 Offset: 0x265FB20 VA: 0x182661520
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x2661350 Offset: 0x265F950 VA: 0x182661350
	protected void .ctor() { }

	// RVA: 0x26614C0 Offset: 0x265FAC0 VA: 0x1826614C0
	public float get_value() { }

	// RVA: 0x26616E0 Offset: 0x265FCE0 VA: 0x1826616E0
	public void set_value(float value) { }

	// RVA: 0x26609B0 Offset: 0x265EFB0 VA: 0x1826609B0 Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x2451470 Offset: 0x244FA70 VA: 0x182451470
	public float get_size() { }

	// RVA: 0x2661660 Offset: 0x265FC60 VA: 0x182661660
	public void set_size(float value) { }

	// RVA: 0x561190 Offset: 0x55F790 VA: 0x180561190
	public int get_numberOfSteps() { }

	// RVA: 0x26615F0 Offset: 0x265FBF0 VA: 0x1826615F0
	public void set_numberOfSteps(int value) { }

	// RVA: 0x1634AF0 Offset: 0x16330F0 VA: 0x181634AF0
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0x16410B0 Offset: 0x163F6B0 VA: 0x1816410B0
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x2661490 Offset: 0x265FA90 VA: 0x182661490
	private float get_stepSize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2660250 Offset: 0x265E850 VA: 0x182660250 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2660000 Offset: 0x265E600 VA: 0x182660000 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2661330 Offset: 0x265F930 VA: 0x182661330 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x2660B90 Offset: 0x265F190 VA: 0x182660B90
	private void UpdateCachedReferences() { }

	// RVA: 0x2660A60 Offset: 0x265F060 VA: 0x182660A60
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x26607A0 Offset: 0x265EDA0 VA: 0x1826607A0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2661450 Offset: 0x265FA50 VA: 0x182661450
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x2661470 Offset: 0x265FA70 VA: 0x182661470
	private bool get_reverseValue() { }

	// RVA: 0x26610C0 Offset: 0x265F6C0 VA: 0x1826610C0
	private void UpdateVisuals() { }

	// RVA: 0x2660C90 Offset: 0x265F290 VA: 0x182660C90
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x2660E20 Offset: 0x265F420 VA: 0x182660E20
	private void UpdateDrag(RectTransform containerRect, Vector2 position, Camera camera) { }

	// RVA: 0x265FB60 Offset: 0x265E160 VA: 0x18265FB60
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x265FCE0 Offset: 0x265E2E0 VA: 0x18265FCE0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x265FD50 Offset: 0x265E350 VA: 0x18265FD50 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2660030 Offset: 0x265E630 VA: 0x182660030 Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x2660650 Offset: 0x265EC50 VA: 0x182660650 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x265FAE0 Offset: 0x265E0E0 VA: 0x18265FAE0
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(Scrollbar.<ClickRepeat>d__59))]
	// RVA: 0x265FA40 Offset: 0x265E040 VA: 0x18265FA40
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x2660760 Offset: 0x265ED60 VA: 0x182660760 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2660340 Offset: 0x265E940 VA: 0x182660340 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x265FC50 Offset: 0x265E250 VA: 0x18265FC50 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x265FC80 Offset: 0x265E280 VA: 0x18265FC80 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x265FCB0 Offset: 0x265E2B0 VA: 0x18265FCB0 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x265FC20 Offset: 0x265E220 VA: 0x18265FC20 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x2660320 Offset: 0x265E920 VA: 0x182660320 Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x26607E0 Offset: 0x265EDE0 VA: 0x1826607E0
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x21AC2C0 Offset: 0x21AA8C0 VA: 0x1821AC2C0 Slot: 43
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Scroll Rect", 37)]
[SelectionBase]
[ExecuteAlways]
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 12194
{
	// Fields
	[SerializeField]
	private RectTransform m_Content; // 0x20
	[SerializeField]
	private bool m_Horizontal; // 0x28
	[SerializeField]
	private bool m_Vertical; // 0x29
	[SerializeField]
	private ScrollRect.MovementType m_MovementType; // 0x2C
	[SerializeField]
	private float m_Elasticity; // 0x30
	[SerializeField]
	private bool m_Inertia; // 0x34
	[SerializeField]
	private float m_DecelerationRate; // 0x38
	[SerializeField]
	private float m_ScrollSensitivity; // 0x3C
	[SerializeField]
	private RectTransform m_Viewport; // 0x40
	[SerializeField]
	private Scrollbar m_HorizontalScrollbar; // 0x48
	[SerializeField]
	private Scrollbar m_VerticalScrollbar; // 0x50
	[SerializeField]
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x58
	[SerializeField]
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x5C
	[SerializeField]
	private float m_HorizontalScrollbarSpacing; // 0x60
	[SerializeField]
	private float m_VerticalScrollbarSpacing; // 0x64
	[SerializeField]
	private ScrollRect.ScrollRectEvent m_OnValueChanged; // 0x68
	private Vector2 m_PointerStartLocalCursor; // 0x70
	protected Vector2 m_ContentStartPosition; // 0x78
	private RectTransform m_ViewRect; // 0x80
	protected Bounds m_ContentBounds; // 0x88
	private Bounds m_ViewBounds; // 0xA0
	private Vector2 m_Velocity; // 0xB8
	private bool m_Dragging; // 0xC0
	private bool m_Scrolling; // 0xC1
	private Vector2 m_PrevPosition; // 0xC4
	private Bounds m_PrevContentBounds; // 0xCC
	private Bounds m_PrevViewBounds; // 0xE4
	private bool m_HasRebuiltLayout; // 0xFC
	private bool m_HSliderExpand; // 0xFD
	private bool m_VSliderExpand; // 0xFE
	private float m_HSliderHeight; // 0x100
	private float m_VSliderWidth; // 0x104
	private RectTransform m_Rect; // 0x108
	private RectTransform m_HorizontalScrollbarRect; // 0x110
	private RectTransform m_VerticalScrollbarRect; // 0x118
	private DrivenRectTransformTracker m_Tracker; // 0x120
	private readonly Vector3[] m_Corners; // 0x128

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRect.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRect.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public RectTransform get_content() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_content(RectTransform value) { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_horizontal() { }

	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	public void set_horizontal(bool value) { }

	// RVA: 0x179F980 Offset: 0x179DF80 VA: 0x18179F980
	public bool get_vertical() { }

	// RVA: 0x1EC4A60 Offset: 0x1EC3060 VA: 0x181EC4A60
	public void set_vertical(bool value) { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x420BC0 Offset: 0x41F1C0 VA: 0x180420BC0
	public float get_elasticity() { }

	// RVA: 0x36F720 Offset: 0x36DD20 VA: 0x18036F720
	public void set_elasticity(float value) { }

	// RVA: 0x15EF9D0 Offset: 0x15EDFD0 VA: 0x1815EF9D0
	public bool get_inertia() { }

	// RVA: 0x16A5170 Offset: 0x16A3770 VA: 0x1816A5170
	public void set_inertia(bool value) { }

	// RVA: 0x5590D0 Offset: 0x5576D0 VA: 0x1805590D0
	public float get_decelerationRate() { }

	// RVA: 0x559130 Offset: 0x557730 VA: 0x180559130
	public void set_decelerationRate(float value) { }

	// RVA: 0x1853720 Offset: 0x1851D20 VA: 0x181853720
	public float get_scrollSensitivity() { }

	// RVA: 0x1853770 Offset: 0x1851D70 VA: 0x181853770
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public RectTransform get_viewport() { }

	// RVA: 0x265FA10 Offset: 0x265E010 VA: 0x18265FA10
	public void set_viewport(RectTransform value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x265F670 Offset: 0x265DC70 VA: 0x18265F670
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x265F880 Offset: 0x265DE80 VA: 0x18265F880
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x265F660 Offset: 0x265DC60 VA: 0x18265F660
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x15B2E40 Offset: 0x15B1440 VA: 0x1815B2E40
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x265F870 Offset: 0x265DE70 VA: 0x18265F870
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x187F570 Offset: 0x187DB70 VA: 0x18187F570
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x265F650 Offset: 0x265DC50 VA: 0x18265F650
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x187F590 Offset: 0x187DB90 VA: 0x18187F590
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x265F860 Offset: 0x265DE60 VA: 0x18265F860
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x265F520 Offset: 0x265DB20 VA: 0x18265F520
	protected RectTransform get_viewRect() { }

	// RVA: 0x265F3E0 Offset: 0x265D9E0 VA: 0x18265F3E0
	public Vector2 get_velocity() { }

	// RVA: 0x265F850 Offset: 0x265DE50 VA: 0x18265F850
	public void set_velocity(Vector2 value) { }

	// RVA: 0x265F2B0 Offset: 0x265D8B0 VA: 0x18265F2B0
	private RectTransform get_rectTransform() { }

	// RVA: 0x265EF30 Offset: 0x265D530 VA: 0x18265EF30
	protected void .ctor() { }

	// RVA: 0x265CB00 Offset: 0x265B100 VA: 0x18265CB00 Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x265E350 Offset: 0x265C950 VA: 0x18265E350
	private void UpdateCachedData() { }

	// RVA: 0x265C690 Offset: 0x265AC90 VA: 0x18265C690 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x265C1E0 Offset: 0x265A7E0 VA: 0x18265C1E0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x265B530 Offset: 0x2659B30 VA: 0x18265B530 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x265AF80 Offset: 0x2659580 VA: 0x18265AF80
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x265DC50 Offset: 0x265C250 VA: 0x18265DC50 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x265C8F0 Offset: 0x265AEF0 VA: 0x18265C8F0 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x265C870 Offset: 0x265AE70 VA: 0x18265C870 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x265C070 Offset: 0x265A670 VA: 0x18265C070 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x265C840 Offset: 0x265AE40 VA: 0x18265C840 Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x265C420 Offset: 0x265AA20 VA: 0x18265C420 Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x265CBF0 Offset: 0x265B1F0 VA: 0x18265CBF0 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x265B5A0 Offset: 0x2659BA0 VA: 0x18265B5A0 Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x265E7E0 Offset: 0x265CDE0 VA: 0x18265E7E0
	protected void UpdatePrevData() { }

	// RVA: 0x265ED30 Offset: 0x265D330 VA: 0x18265ED30
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x265F270 Offset: 0x265D870 VA: 0x18265F270
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x265F800 Offset: 0x265DE00 VA: 0x18265F800
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x265F160 Offset: 0x265D760 VA: 0x18265F160
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x265CE20 Offset: 0x265B420 VA: 0x18265CE20
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x265F400 Offset: 0x265DA00 VA: 0x18265F400
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x265DC30 Offset: 0x265C230 VA: 0x18265DC30
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x265CE20 Offset: 0x265B420 VA: 0x18265CE20
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x265DC30 Offset: 0x265C230 VA: 0x18265DC30
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x265D710 Offset: 0x265BD10 VA: 0x18265D710 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x265CB90 Offset: 0x265B190 VA: 0x18265CB90
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x265C8E0 Offset: 0x265AEE0 VA: 0x18265C8E0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x265F0D0 Offset: 0x265D6D0 VA: 0x18265F0D0
	private bool get_hScrollingNeeded() { }

	// RVA: 0x265F350 Offset: 0x265D950 VA: 0x18265F350
	private bool get_vScrollingNeeded() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0x37A690 Offset: 0x378C90 VA: 0x18037A690 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x265CE40 Offset: 0x265B440 VA: 0x18265CE40 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x265D5D0 Offset: 0x265BBD0 VA: 0x18265D5D0 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x265ECD0 Offset: 0x265D2D0 VA: 0x18265ECD0
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x265E6F0 Offset: 0x265CCF0 VA: 0x18265E6F0
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x265E8E0 Offset: 0x265CEE0 VA: 0x18265E8E0
	private void UpdateScrollbarLayout() { }

	// RVA: 0x265DCB0 Offset: 0x265C2B0 VA: 0x18265DCB0
	protected void UpdateBounds() { }

	// RVA: 0x265AD20 Offset: 0x2659320 VA: 0x18265AD20
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x265AFE0 Offset: 0x26595E0 VA: 0x18265AFE0
	private Bounds GetBounds() { }

	// RVA: 0x265B2A0 Offset: 0x26598A0 VA: 0x18265B2A0
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x265ADD0 Offset: 0x26593D0 VA: 0x18265ADD0
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x265B120 Offset: 0x2659720 VA: 0x18265B120
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x265CDA0 Offset: 0x265B3A0 VA: 0x18265CDA0
	protected void SetDirty() { }

	// RVA: 0x265CCE0 Offset: 0x265B2E0 VA: 0x18265CCE0
	protected void SetDirtyCaching() { }

	// RVA: 0x21AC2C0 Offset: 0x21AA8C0 VA: 0x1821AC2C0 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Selectable", 35)]
[ExecuteAlways]
[SelectionBase]
[DisallowMultipleComponent]
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 12197
{
	// Fields
	protected static Selectable[] s_Selectables; // 0x0
	protected static int s_SelectableCount; // 0x8
	private bool m_EnableCalled; // 0x20
	[FormerlySerializedAs("navigation")]
	[SerializeField]
	private Navigation m_Navigation; // 0x28
	[FormerlySerializedAs("transition")]
	[SerializeField]
	private Selectable.Transition m_Transition; // 0x50
	[FormerlySerializedAs("colors")]
	[SerializeField]
	private ColorBlock m_Colors; // 0x54
	[FormerlySerializedAs("spriteState")]
	[SerializeField]
	private SpriteState m_SpriteState; // 0xB0
	[FormerlySerializedAs("animationTriggers")]
	[SerializeField]
	private AnimationTriggers m_AnimationTriggers; // 0xD0
	[Tooltip("Can the Selectable be interacted with?")]
	[SerializeField]
	private bool m_Interactable; // 0xD8
	[FormerlySerializedAs("highlightGraphic")]
	[FormerlySerializedAs("m_HighlightGraphic")]
	[SerializeField]
	private Graphic m_TargetGraphic; // 0xE0
	private bool m_GroupsAllowInteraction; // 0xE8
	protected int m_CurrentIndex; // 0xEC
	[CompilerGenerated]
	private bool <isPointerInside>k__BackingField; // 0xF0
	[CompilerGenerated]
	private bool <isPointerDown>k__BackingField; // 0xF1
	[CompilerGenerated]
	private bool <hasSelection>k__BackingField; // 0xF2
	private readonly List<CanvasGroup> m_CanvasGroupCache; // 0xF8

	// Properties
	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
	public static List<Selectable> allSelectables { get; }
	public Navigation navigation { get; set; }
	public Selectable.Transition transition { get; set; }
	public ColorBlock colors { get; set; }
	public SpriteState spriteState { get; set; }
	public AnimationTriggers animationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public bool interactable { get; set; }
	private bool isPointerInside { get; set; }
	private bool isPointerDown { get; set; }
	private bool hasSelection { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	protected Selectable.SelectionState currentSelectionState { get; }

	// Methods

	// RVA: 0x2663D90 Offset: 0x2662390 VA: 0x182663D90
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x2663D40 Offset: 0x2662340 VA: 0x182663D40
	public static int get_allSelectableCount() { }

	// RVA: 0x2663E20 Offset: 0x2662420 VA: 0x182663E20
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x26616F0 Offset: 0x265FCF0 VA: 0x1826616F0
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x26640A0 Offset: 0x26626A0 VA: 0x1826640A0
	public Navigation get_navigation() { }

	// RVA: 0x2664350 Offset: 0x2662950 VA: 0x182664350
	public void set_navigation(Navigation value) { }

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public Selectable.Transition get_transition() { }

	// RVA: 0x26644A0 Offset: 0x2662AA0 VA: 0x1826644A0
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x2663F60 Offset: 0x2662560 VA: 0x182663F60
	public ColorBlock get_colors() { }

	// RVA: 0x2664120 Offset: 0x2662720 VA: 0x182664120
	public void set_colors(ColorBlock value) { }

	// RVA: 0xC98010 Offset: 0xC96610 VA: 0x180C98010
	public SpriteState get_spriteState() { }

	// RVA: 0x26643D0 Offset: 0x26629D0 VA: 0x1826643D0
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x3A36F0 Offset: 0x3A1CF0 VA: 0x1803A36F0
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x26640C0 Offset: 0x26626C0 VA: 0x1826640C0
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	public Graphic get_targetGraphic() { }

	// RVA: 0x2664440 Offset: 0x2662A40 VA: 0x182664440
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x1C5B9C0 Offset: 0x1C59FC0 VA: 0x181C5B9C0
	public bool get_interactable() { }

	// RVA: 0x26641C0 Offset: 0x26627C0 VA: 0x1826641C0
	public void set_interactable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161EE00 Offset: 0x161D400 VA: 0x18161EE00
	private bool get_isPointerInside() { }

	[CompilerGenerated]
	// RVA: 0x2664340 Offset: 0x2662940 VA: 0x182664340
	private void set_isPointerInside(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161EEF0 Offset: 0x161D4F0 VA: 0x18161EEF0
	private bool get_isPointerDown() { }

	[CompilerGenerated]
	// RVA: 0x2664330 Offset: 0x2662930 VA: 0x182664330
	private void set_isPointerDown(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161ED70 Offset: 0x161D370 VA: 0x18161ED70
	private bool get_hasSelection() { }

	[CompilerGenerated]
	// RVA: 0x161EF00 Offset: 0x161D500 VA: 0x18161EF00
	private void set_hasSelection(bool value) { }

	// RVA: 0x2663BB0 Offset: 0x26621B0 VA: 0x182663BB0
	protected void .ctor() { }

	// RVA: 0x2664010 Offset: 0x2662610 VA: 0x182664010
	public Image get_image() { }

	// RVA: 0x12F1A10 Offset: 0x12F0010 VA: 0x1812F1A10
	public void set_image(Image value) { }

	// RVA: 0x2663F20 Offset: 0x2662520 VA: 0x182663F20
	public Animator get_animator() { }

	// RVA: 0x26617C0 Offset: 0x265FDC0 VA: 0x1826617C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2662B70 Offset: 0x2661170 VA: 0x182662B70 Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x2663570 Offset: 0x2661B70 VA: 0x182663570
	private bool ParentGroupAllowsInteraction() { }

	// RVA: 0x2662A00 Offset: 0x2661000 VA: 0x182662A00 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x2662C20 Offset: 0x2661220 VA: 0x182662C20 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2662E40 Offset: 0x2661440 VA: 0x182662E40 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2663540 Offset: 0x2661B40 VA: 0x182663540 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2662C20 Offset: 0x2661220 VA: 0x182662C20
	private void OnSetProperty() { }

	// RVA: 0x2662C90 Offset: 0x2661290 VA: 0x182662C90 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2662B10 Offset: 0x2661110 VA: 0x182662B10
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x2663FA0 Offset: 0x26625A0 VA: 0x182663FA0
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x2662860 Offset: 0x2660E60 VA: 0x182662860 Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x2661900 Offset: 0x265FF00 VA: 0x182661900 Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x2661FA0 Offset: 0x26605A0 VA: 0x182661FA0
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x2662640 Offset: 0x2660C40 VA: 0x182662640
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x2662A70 Offset: 0x2661070 VA: 0x182662A70
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x2661D00 Offset: 0x2660300 VA: 0x182661D00 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x2661DE0 Offset: 0x26603E0 VA: 0x182661DE0 Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x2661EC0 Offset: 0x26604C0 VA: 0x182661EC0 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x2661C20 Offset: 0x2660220 VA: 0x182661C20 Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x2663160 Offset: 0x2661760 VA: 0x182663160 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x26637F0 Offset: 0x2661DF0 VA: 0x1826637F0
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x2661860 Offset: 0x265FE60 VA: 0x182661860
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x26638E0 Offset: 0x2661EE0 VA: 0x1826638E0
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x2662990 Offset: 0x2660F90 VA: 0x182662990
	protected bool IsHighlighted() { }

	// RVA: 0x2662A20 Offset: 0x2661020 VA: 0x182662A20
	protected bool IsPressed() { }

	// RVA: 0x2661BB0 Offset: 0x26601B0 VA: 0x182661BB0
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x2663290 Offset: 0x2661890 VA: 0x182663290 Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x26634A0 Offset: 0x2661AA0 VA: 0x1826634A0 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x26633C0 Offset: 0x26619C0 VA: 0x1826633C0 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x2663430 Offset: 0x2661A30 VA: 0x182663430 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x26634D0 Offset: 0x2661AD0 VA: 0x1826634D0 Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x2662BB0 Offset: 0x26611B0 VA: 0x182662BB0 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2663700 Offset: 0x2661D00 VA: 0x182663700 Slot: 38
	public virtual void Select() { }

	// RVA: 0x2663B30 Offset: 0x2662130 VA: 0x182663B30
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
internal static class SetPropertyUtility // TypeDefIndex: 12198
{
	// Methods

	// RVA: 0x21CD7B0 Offset: 0x21CBDB0 VA: 0x1821CD7B0
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	// RVA: -1 Offset: -1
	public static bool SetStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79CA00 Offset: 0x79B000 VA: 0x18079CA00
	|-SetPropertyUtility.SetStruct<bool>
	|
	|-RVA: 0x79CCA0 Offset: 0x79B2A0 VA: 0x18079CCA0
	|-SetPropertyUtility.SetStruct<char>
	|
	|-RVA: 0x79CE20 Offset: 0x79B420 VA: 0x18079CE20
	|-SetPropertyUtility.SetStruct<ColorBlock>
	|
	|-RVA: 0x79D550 Offset: 0x79BB50 VA: 0x18079D550
	|-SetPropertyUtility.SetStruct<int>
	|
	|-RVA: 0x79D330 Offset: 0x79B930 VA: 0x18079D330
	|-SetPropertyUtility.SetStruct<Int32Enum>
	|
	|-RVA: 0x79D740 Offset: 0x79BD40 VA: 0x18079D740
	|-SetPropertyUtility.SetStruct<Navigation>
	|
	|-RVA: 0x79D9A0 Offset: 0x79BFA0 VA: 0x18079D9A0
	|-SetPropertyUtility.SetStruct<float>
	|
	|-RVA: 0x79DB10 Offset: 0x79C110 VA: 0x18079DB10
	|-SetPropertyUtility.SetStruct<SpriteState>
	|
	|-RVA: 0x79D1D0 Offset: 0x79B7D0 VA: 0x18079D1D0
	|-SetPropertyUtility.SetStruct<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetClass<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79C7F0 Offset: 0x79ADF0 VA: 0x18079C7F0
	|-SetPropertyUtility.SetClass<object>
	*/
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Slider", 34)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 12202
{
	// Fields
	[SerializeField]
	private RectTransform m_FillRect; // 0x100
	[SerializeField]
	private RectTransform m_HandleRect; // 0x108
	[Space]
	[SerializeField]
	private Slider.Direction m_Direction; // 0x110
	[SerializeField]
	private float m_MinValue; // 0x114
	[SerializeField]
	private float m_MaxValue; // 0x118
	[SerializeField]
	private bool m_WholeNumbers; // 0x11C
	[SerializeField]
	protected float m_Value; // 0x120
	[Space]
	[SerializeField]
	private Slider.SliderEvent m_OnValueChanged; // 0x128
	private Image m_FillImage; // 0x130
	private Transform m_FillTransform; // 0x138
	private RectTransform m_FillContainerRect; // 0x140
	private Transform m_HandleTransform; // 0x148
	private RectTransform m_HandleContainerRect; // 0x150
	private Vector2 m_Offset; // 0x158
	private DrivenRectTransformTracker m_Tracker; // 0x160
	private bool m_DelayedUpdateVisuals; // 0x161

	// Properties
	public RectTransform fillRect { get; set; }
	public RectTransform handleRect { get; set; }
	public Slider.Direction direction { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public bool wholeNumbers { get; set; }
	public virtual float value { get; set; }
	public float normalizedValue { get; set; }
	public Slider.SliderEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Slider.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x352A90 Offset: 0x351090 VA: 0x180352A90
	public RectTransform get_fillRect() { }

	// RVA: 0x2665FE0 Offset: 0x26645E0 VA: 0x182665FE0
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x15B3B70 Offset: 0x15B2170 VA: 0x1815B3B70
	public RectTransform get_handleRect() { }

	// RVA: 0x2666050 Offset: 0x2664650 VA: 0x182666050
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x219A520 Offset: 0x2198B20 VA: 0x18219A520
	public Slider.Direction get_direction() { }

	// RVA: 0x2665F80 Offset: 0x2664580 VA: 0x182665F80
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x21DE0A0 Offset: 0x21DC6A0 VA: 0x1821DE0A0
	public float get_minValue() { }

	// RVA: 0x2666140 Offset: 0x2664740 VA: 0x182666140
	public void set_minValue(float value) { }

	// RVA: 0x2665E40 Offset: 0x2664440 VA: 0x182665E40
	public float get_maxValue() { }

	// RVA: 0x26660C0 Offset: 0x26646C0 VA: 0x1826660C0
	public void set_maxValue(float value) { }

	// RVA: 0x2665F70 Offset: 0x2664570 VA: 0x182665F70
	public bool get_wholeNumbers() { }

	// RVA: 0x2666230 Offset: 0x2664830 VA: 0x182666230
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x2665F50 Offset: 0x2664550 VA: 0x182665F50 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x2666210 Offset: 0x2664810 VA: 0x182666210 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x2665160 Offset: 0x2663760 VA: 0x182665160 Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x2665E50 Offset: 0x2664450 VA: 0x182665E50
	public float get_normalizedValue() { }

	// RVA: 0x26661C0 Offset: 0x26647C0 VA: 0x1826661C0
	public void set_normalizedValue(float value) { }

	// RVA: 0x19DB6F0 Offset: 0x19D9CF0 VA: 0x1819DB6F0
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x23F6D20 Offset: 0x23F5320 VA: 0x1823F6D20
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x2665F20 Offset: 0x2664520 VA: 0x182665F20
	private float get_stepSize() { }

	// RVA: 0x2665D20 Offset: 0x2664320 VA: 0x182665D20
	protected void .ctor() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x26649D0 Offset: 0x2662FD0 VA: 0x1826649D0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2664920 Offset: 0x2662F20 VA: 0x182664920 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2665CD0 Offset: 0x26642D0 VA: 0x182665CD0 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x2664630 Offset: 0x2662C30 VA: 0x182664630 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2665260 Offset: 0x2663860 VA: 0x182665260
	private void UpdateCachedReferences() { }

	// RVA: 0x2664540 Offset: 0x2662B40 VA: 0x182664540
	private float ClampValue(float input) { }

	// RVA: 0x2665180 Offset: 0x2663780 VA: 0x182665180 Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x2664F50 Offset: 0x2663550 VA: 0x182664F50 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2665E20 Offset: 0x2664420 VA: 0x182665E20
	private Slider.Axis get_axis() { }

	// RVA: 0x2665F00 Offset: 0x2664500 VA: 0x182665F00
	private bool get_reverseValue() { }

	// RVA: 0x2665910 Offset: 0x2663F10 VA: 0x182665910
	private void UpdateVisuals() { }

	// RVA: 0x26655F0 Offset: 0x2663BF0 VA: 0x1826655F0
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x265FCE0 Offset: 0x265E2E0 VA: 0x18265FCE0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x2664CE0 Offset: 0x26632E0 VA: 0x182664CE0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2664950 Offset: 0x2662F50 VA: 0x182664950 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x2664A20 Offset: 0x2663020 VA: 0x182664A20 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x26645A0 Offset: 0x2662BA0 VA: 0x1826645A0 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x26645D0 Offset: 0x2662BD0 VA: 0x1826645D0 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x2664600 Offset: 0x2662C00 VA: 0x182664600 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x2664570 Offset: 0x2662B70 VA: 0x182664570 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x2660320 Offset: 0x265E920 VA: 0x182660320 Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x2664F90 Offset: 0x2663590 VA: 0x182664F90
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x21AC2C0 Offset: 0x21AA8C0 VA: 0x1821AC2C0 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 12203
{
	// Fields
	[SerializeField]
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField]
	private Sprite m_PressedSprite; // 0x8
	[FormerlySerializedAs("m_HighlightedSprite")]
	[SerializeField]
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField]
	private Sprite m_DisabledSprite; // 0x18

	// Properties
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public Sprite get_highlightedSprite() { }

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public Sprite get_pressedSprite() { }

	// RVA: 0x971490 Offset: 0x96FA90 VA: 0x180971490
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Sprite get_selectedSprite() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Sprite get_disabledSprite() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x26662B0 Offset: 0x26648B0 VA: 0x1826662B0 Slot: 4
	public bool Equals(SpriteState other) { }
}

// Namespace: UnityEngine.UI
public static class StencilMaterial // TypeDefIndex: 12205
{
	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	[EditorBrowsable(1)]
	[Obsolete("Use Material.Add instead.", True)]
	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x26663B0 Offset: 0x26649B0 VA: 0x1826663B0
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x2667030 Offset: 0x2665630 VA: 0x182667030
	private static void LogWarningWhenNotInBatchmode(string warning, Object context) { }

	// RVA: 0x2666450 Offset: 0x2664A50 VA: 0x182666450
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x26670C0 Offset: 0x26656C0 VA: 0x1826670C0
	public static void Remove(Material customMat) { }

	// RVA: 0x2666EC0 Offset: 0x26654C0 VA: 0x182666EC0
	public static void ClearAll() { }

	// RVA: 0x2667290 Offset: 0x2665890 VA: 0x182667290
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/Legacy/Text", 100)]
public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 12206
{
	// Fields
	[SerializeField]
	private FontData m_FontData; // 0xE0
	[TextArea(3, 10)]
	[SerializeField]
	protected string m_Text; // 0xE8
	private TextGenerator m_TextCache; // 0xF0
	private TextGenerator m_TextCacheForLayout; // 0xF8
	protected static Material s_DefaultText; // 0x0
	protected bool m_DisableFontTextureRebuiltCallback; // 0x100
	private readonly UIVertex[] m_TempVerts; // 0x108

	// Properties
	public TextGenerator cachedTextGenerator { get; }
	public TextGenerator cachedTextGeneratorForLayout { get; }
	public override Texture mainTexture { get; }
	public Font font { get; set; }
	public virtual string text { get; set; }
	public bool supportRichText { get; set; }
	public bool resizeTextForBestFit { get; set; }
	public int resizeTextMinSize { get; set; }
	public int resizeTextMaxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public int fontSize { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }
	public FontStyle fontStyle { get; set; }
	public float pixelsPerUnit { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x26681B0 Offset: 0x26667B0 VA: 0x1826681B0
	protected void .ctor() { }

	// RVA: 0x2668320 Offset: 0x2666920 VA: 0x182668320
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x26682A0 Offset: 0x26668A0 VA: 0x1826682A0
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x2668450 Offset: 0x2666A50 VA: 0x182668450 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x2667430 Offset: 0x2665A30 VA: 0x182667430
	public void FontTextureChanged() { }

	// RVA: 0x26683F0 Offset: 0x26669F0 VA: 0x1826683F0
	public Font get_font() { }

	// RVA: 0x2668BF0 Offset: 0x26671F0 VA: 0x182668BF0
	public void set_font(Font value) { }

	// RVA: 0x5513E0 Offset: 0x54F9E0 VA: 0x1805513E0 Slot: 74
	public virtual string get_text() { }

	// RVA: 0x2668F50 Offset: 0x2667550 VA: 0x182668F50 Slot: 75
	public virtual void set_text(string value) { }

	// RVA: 0x2668A50 Offset: 0x2667050 VA: 0x182668A50
	public bool get_supportRichText() { }

	// RVA: 0x2668EF0 Offset: 0x26674F0 VA: 0x182668EF0
	public void set_supportRichText(bool value) { }

	// RVA: 0x26689F0 Offset: 0x2666FF0 VA: 0x1826689F0
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x2668DD0 Offset: 0x26673D0 VA: 0x182668DD0
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x2668A30 Offset: 0x2667030 VA: 0x182668A30
	public int get_resizeTextMinSize() { }

	// RVA: 0x2668E90 Offset: 0x2667490 VA: 0x182668E90
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x2668A10 Offset: 0x2667010 VA: 0x182668A10
	public int get_resizeTextMaxSize() { }

	// RVA: 0x2668E30 Offset: 0x2667430 VA: 0x182668E30
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x2668280 Offset: 0x2666880 VA: 0x182668280
	public TextAnchor get_alignment() { }

	// RVA: 0x2668AD0 Offset: 0x26670D0 VA: 0x182668AD0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x2668260 Offset: 0x2666860 VA: 0x182668260
	public bool get_alignByGeometry() { }

	// RVA: 0x2668A90 Offset: 0x2667090 VA: 0x182668A90
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x20AAE90 Offset: 0x20A9490 VA: 0x1820AAE90
	public int get_fontSize() { }

	// RVA: 0x2668B30 Offset: 0x2667130 VA: 0x182668B30
	public void set_fontSize(int value) { }

	// RVA: 0x2668410 Offset: 0x2666A10 VA: 0x182668410
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x2668D10 Offset: 0x2667310 VA: 0x182668D10
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x2668A70 Offset: 0x2667070 VA: 0x182668A70
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x2669040 Offset: 0x2667640 VA: 0x182669040
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x2668430 Offset: 0x2666A30 VA: 0x182668430
	public float get_lineSpacing() { }

	// RVA: 0x2668D70 Offset: 0x2667370 VA: 0x182668D70
	public void set_lineSpacing(float value) { }

	// RVA: 0x26683D0 Offset: 0x26669D0 VA: 0x1826683D0
	public FontStyle get_fontStyle() { }

	// RVA: 0x2668B90 Offset: 0x2667190 VA: 0x182668B90
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x2668650 Offset: 0x2666C50 VA: 0x182668650
	public float get_pixelsPerUnit() { }

	// RVA: 0x2667970 Offset: 0x2665F70 VA: 0x182667970 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2667910 Offset: 0x2665F10 VA: 0x182667910 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2668130 Offset: 0x2666730 VA: 0x182668130 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x26673D0 Offset: 0x26659D0 VA: 0x1826673D0
	internal void AssignDefaultFont() { }

	// RVA: 0x2667320 Offset: 0x2665920 VA: 0x182667320
	internal void AssignDefaultFontIfNecessary() { }

	// RVA: 0x2667550 Offset: 0x2665B50 VA: 0x182667550
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x26677A0 Offset: 0x2665DA0 VA: 0x1826677A0
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x26679F0 Offset: 0x2665FF0 VA: 0x1826679F0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 76
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 77
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 78
	public virtual float get_minWidth() { }

	// RVA: 0x26688D0 Offset: 0x2666ED0 VA: 0x1826688D0 Slot: 79
	public virtual float get_preferredWidth() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 80
	public virtual float get_flexibleWidth() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 81
	public virtual float get_minHeight() { }

	// RVA: 0x26687C0 Offset: 0x2666DC0 VA: 0x1826687C0 Slot: 82
	public virtual float get_preferredHeight() { }

	// RVA: 0x21ADF40 Offset: 0x21AC540 VA: 0x1821ADF40 Slot: 83
	public virtual float get_flexibleHeight() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 84
	public virtual int get_layoutPriority() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Toggle", 30)]
[RequireComponent(typeof(RectTransform))]
public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 12209
{
	// Fields
	public Toggle.ToggleTransition toggleTransition; // 0x100
	public Graphic graphic; // 0x108
	[SerializeField]
	private ToggleGroup m_Group; // 0x110
	public Toggle.ToggleEvent onValueChanged; // 0x118
	[Tooltip("Is the toggle currently on or off?")]
	[SerializeField]
	private bool m_IsOn; // 0x120

	// Properties
	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }

	// Methods

	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	public ToggleGroup get_group() { }

	// RVA: 0x266A750 Offset: 0x2668D50 VA: 0x18266A750
	public void set_group(ToggleGroup value) { }

	// RVA: 0x266A690 Offset: 0x2668C90 VA: 0x18266A690
	protected void .ctor() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2669EF0 Offset: 0x26684F0 VA: 0x182669EF0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x266A0E0 Offset: 0x26686E0 VA: 0x18266A0E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x266A0B0 Offset: 0x26686B0 VA: 0x18266A0B0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2669F80 Offset: 0x2668580 VA: 0x182669F80 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x266A270 Offset: 0x2668870 VA: 0x18266A270
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x16211E0 Offset: 0x161F7E0 VA: 0x1816211E0
	public bool get_isOn() { }

	// RVA: 0x266A780 Offset: 0x2668D80 VA: 0x18266A780
	public void set_isOn(bool value) { }

	// RVA: 0x266A260 Offset: 0x2668860 VA: 0x18266A260
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x266A4F0 Offset: 0x2668AF0 VA: 0x18266A4F0
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x266A1A0 Offset: 0x26687A0 VA: 0x18266A1A0
	private void PlayEffect(bool instant) { }

	// RVA: 0x266A680 Offset: 0x2668C80 VA: 0x18266A680 Slot: 6
	protected override void Start() { }

	// RVA: 0x2669E90 Offset: 0x2668490 VA: 0x182669E90
	private void InternalToggle() { }

	// RVA: 0x266A120 Offset: 0x2668720 VA: 0x18266A120 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2669E90 Offset: 0x2668490 VA: 0x182669E90 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x21AC2C0 Offset: 0x21AA8C0 VA: 0x1821AC2C0 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Toggle Group", 31)]
[DisallowMultipleComponent]
public class ToggleGroup : UIBehaviour // TypeDefIndex: 12211
{
	// Fields
	[SerializeField]
	private bool m_AllowSwitchOff; // 0x20
	protected List<Toggle> m_Toggles; // 0x28

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_allowSwitchOff() { }

	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x2669E10 Offset: 0x2668410 VA: 0x182669E10
	protected void .ctor() { }

	// RVA: 0x2669A30 Offset: 0x2668030 VA: 0x182669A30 Slot: 6
	protected override void Start() { }

	// RVA: 0x2669A30 Offset: 0x2668030 VA: 0x182669A30 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2669CC0 Offset: 0x26682C0 VA: 0x182669CC0
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x26697C0 Offset: 0x2667DC0 VA: 0x1826697C0
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x2669C40 Offset: 0x2668240 VA: 0x182669C40
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x2669A50 Offset: 0x2668050 VA: 0x182669A50
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x2669350 Offset: 0x2667950 VA: 0x182669350
	public void EnsureValidState() { }

	// RVA: 0x2669200 Offset: 0x2667800 VA: 0x182669200
	public bool AnyTogglesOn() { }

	// RVA: 0x26690E0 Offset: 0x26676E0 VA: 0x1826690E0
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x2669750 Offset: 0x2667D50 VA: 0x182669750
	public Toggle GetFirstActiveToggle() { }

	// RVA: 0x2669B30 Offset: 0x2668130 VA: 0x182669B30
	public void SetAllTogglesOff(bool sendCallback = True) { }
}

// Namespace: UnityEngine.UI
internal class ReflectionMethodsCache // TypeDefIndex: 12218
{
	// Fields
	public ReflectionMethodsCache.Raycast3DCallback raycast3D; // 0x10
	public ReflectionMethodsCache.RaycastAllCallback raycast3DAll; // 0x18
	public ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc; // 0x20
	public ReflectionMethodsCache.Raycast2DCallback raycast2D; // 0x28
	public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll; // 0x30
	public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; // 0x38
	private static ReflectionMethodsCache s_ReflectionMethodsCache; // 0x0

	// Properties
	public static ReflectionMethodsCache Singleton { get; }

	// Methods

	// RVA: 0x2659C40 Offset: 0x2658240 VA: 0x182659C40
	public void .ctor() { }

	// RVA: 0x265AC10 Offset: 0x2659210 VA: 0x18265AC10
	public static ReflectionMethodsCache get_Singleton() { }
}

// Namespace: UnityEngine.UI
public class VertexHelper : IDisposable // TypeDefIndex: 12219
{
	// Fields
	private List<Vector3> m_Positions; // 0x10
	private List<Color32> m_Colors; // 0x18
	private List<Vector4> m_Uv0S; // 0x20
	private List<Vector4> m_Uv1S; // 0x28
	private List<Vector4> m_Uv2S; // 0x30
	private List<Vector4> m_Uv3S; // 0x38
	private List<Vector3> m_Normals; // 0x40
	private List<Vector4> m_Tangents; // 0x48
	private List<int> m_Indices; // 0x50
	private static readonly Vector4 s_DefaultTangent; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x10
	private bool m_ListsInitalized; // 0x58

	// Properties
	public int currentVertCount { get; }
	public int currentIndexCount { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x266C3D0 Offset: 0x266A9D0 VA: 0x18266C3D0
	public void .ctor(Mesh m) { }

	// RVA: 0x266BC50 Offset: 0x266A250 VA: 0x18266BC50
	private void InitializeListIfRequired() { }

	// RVA: 0x266B860 Offset: 0x2669E60 VA: 0x18266B860 Slot: 4
	public void Dispose() { }

	// RVA: 0x266B770 Offset: 0x2669D70 VA: 0x18266B770
	public void Clear() { }

	// RVA: 0x266C660 Offset: 0x266AC60 VA: 0x18266C660
	public int get_currentVertCount() { }

	// RVA: 0x266C610 Offset: 0x266AC10 VA: 0x18266C610
	public int get_currentIndexCount() { }

	// RVA: 0x266BE30 Offset: 0x266A430 VA: 0x18266BE30
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x266BFF0 Offset: 0x266A5F0 VA: 0x18266BFF0
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x266BA70 Offset: 0x266A070 VA: 0x18266BA70
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x266B330 Offset: 0x2669930 VA: 0x18266B330
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x266B110 Offset: 0x2669710 VA: 0x18266B110
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x266AF20 Offset: 0x2669520 VA: 0x18266AF20
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x266B280 Offset: 0x2669880 VA: 0x18266B280
	public void AddVert(UIVertex v) { }

	// RVA: 0x266A9C0 Offset: 0x2668FC0 VA: 0x18266A9C0
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x266AB30 Offset: 0x2669130 VA: 0x18266AB30
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x266ADE0 Offset: 0x26693E0 VA: 0x18266ADE0
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x266AEA0 Offset: 0x26694A0 VA: 0x18266AEA0
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x266BBD0 Offset: 0x266A1D0 VA: 0x18266BBD0
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x266C340 Offset: 0x266A940 VA: 0x18266C340
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Use BaseMeshEffect instead", True)]
public abstract class BaseVertexEffect // TypeDefIndex: 12220
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", True)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ModifyVertices(List<UIVertex> vertices);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 12221
{
	// Fields
	private Graphic m_Graphic; // 0x20

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x2656040 Offset: 0x2654640 VA: 0x182656040
	protected Graphic get_graphic() { }

	// RVA: 0x2655FA0 Offset: 0x26545A0 VA: 0x182655FA0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2655F00 Offset: 0x2654500 VA: 0x182655F00 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2655E60 Offset: 0x2654460 VA: 0x182655E60 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2655C20 Offset: 0x2654220 VA: 0x182655C20 Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh);

	// RVA: 0x365090 Offset: 0x363690 VA: 0x180365090
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
[EditorBrowsable(1)]
[Obsolete("Use IMeshModifier instead", True)]
public interface IVertexModifier // TypeDefIndex: 12222
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", True)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyVertices(List<UIVertex> verts);
}

// Namespace: UnityEngine.UI
public interface IMeshModifier // TypeDefIndex: 12223
{
	// Methods

	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", False)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyMesh(Mesh mesh);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ModifyMesh(VertexHelper verts);
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Outline", 81)]
public class Outline : Shadow // TypeDefIndex: 12224
{
	// Methods

	// RVA: 0x26573C0 Offset: 0x26559C0 VA: 0x1826573C0
	protected void .ctor() { }

	// RVA: 0x2657050 Offset: 0x2655650 VA: 0x182657050 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Position As UV1", 82)]
public class PositionAsUV1 : BaseMeshEffect // TypeDefIndex: 12225
{
	// Methods

	// RVA: 0x365090 Offset: 0x363690 VA: 0x180365090
	protected void .ctor() { }

	// RVA: 0x26573D0 Offset: 0x26559D0 VA: 0x1826573D0 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Shadow", 80)]
public class Shadow : BaseMeshEffect // TypeDefIndex: 12226
{
	// Fields
	[SerializeField]
	private Color m_EffectColor; // 0x28
	[SerializeField]
	private Vector2 m_EffectDistance; // 0x38
	[SerializeField]
	private bool m_UseGraphicAlpha; // 0x40
	private const float kMaxEffectDistance = 600;

	// Properties
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public bool useGraphicAlpha { get; set; }

	// Methods

	// RVA: 0x267AEE0 Offset: 0x26794E0 VA: 0x18267AEE0
	protected void .ctor() { }

	// RVA: 0x1116670 Offset: 0x1114C70 VA: 0x181116670
	public Color get_effectColor() { }

	// RVA: 0x267AF30 Offset: 0x2679530 VA: 0x18267AF30
	public void set_effectColor(Color value) { }

	// RVA: 0x267AF10 Offset: 0x2679510 VA: 0x18267AF10
	public Vector2 get_effectDistance() { }

	// RVA: 0x267AFD0 Offset: 0x26795D0 VA: 0x18267AFD0
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_useGraphicAlpha() { }

	// RVA: 0x267B100 Offset: 0x2679700 VA: 0x18267B100
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x267AA00 Offset: 0x2679000 VA: 0x18267AA00
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x267AD90 Offset: 0x2679390 VA: 0x18267AD90
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x267ADA0 Offset: 0x26793A0 VA: 0x18267ADA0 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

