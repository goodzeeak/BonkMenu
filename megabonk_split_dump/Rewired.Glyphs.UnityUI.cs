// Namespace: Rewired.Glyphs.UnityUI
[AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Controller Element Glyph")]
public class UnityUIControllerElementGlyph : ControllerElementGlyph // TypeDefIndex: 5249
{
	// Methods

	// RVA: 0x3A8C50 Offset: 0x3A7250 VA: 0x1803A8C50 Slot: 25
	protected override GameObject GetDefaultGlyphOrTextPrefab() { }

	// RVA: 0x3997E0 Offset: 0x397DE0 VA: 0x1803997E0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
public abstract class UnityUIControllerElementGlyphBase : ControllerElementGlyphBase // TypeDefIndex: 5250
{
	// Fields
	private static GameObject s_defaultGlyphOrTextPrefab; // 0x0
	private static Func<GameObject> s_defaultGlyphOrTextPrefabProvider; // 0x8

	// Properties
	public static GameObject defaultGlyphOrTextPrefab { get; set; }
	public static Func<GameObject> defaultGlyphOrTextPrefabProvider { get; set; }

	// Methods

	// RVA: 0x3A8C50 Offset: 0x3A7250 VA: 0x1803A8C50 Slot: 25
	protected override GameObject GetDefaultGlyphOrTextPrefab() { }

	// RVA: 0x3A8CA0 Offset: 0x3A72A0 VA: 0x1803A8CA0
	public static GameObject get_defaultGlyphOrTextPrefab() { }

	// RVA: 0x3A8DC0 Offset: 0x3A73C0 VA: 0x1803A8DC0
	public static void set_defaultGlyphOrTextPrefab(GameObject value) { }

	// RVA: 0x3A8C60 Offset: 0x3A7260 VA: 0x1803A8C60
	public static Func<GameObject> get_defaultGlyphOrTextPrefabProvider() { }

	// RVA: 0x3A8D60 Offset: 0x3A7360 VA: 0x1803A8D60
	public static void set_defaultGlyphOrTextPrefabProvider(Func<GameObject> value) { }

	// RVA: 0x3A88B0 Offset: 0x3A6EB0 VA: 0x1803A88B0
	private static GameObject CreateDefaultGlyphOrTextPrefab() { }

	// RVA: 0x3997E0 Offset: 0x397DE0 VA: 0x1803997E0
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
[AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Default Controller Element Glyph Settings")]
public class UnityUIDefaultControllerElementGlyphSettings : DefaultControllerElementGlyphSettingsBase // TypeDefIndex: 5251
{
	// Methods

	// RVA: 0x3A8E20 Offset: 0x3A7420 VA: 0x1803A8E20 Slot: 8
	protected override void SetDefaultGlyphOrTextPrefab() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
internal class UnityUIDefaultGlyphOrTextTMProPrefabProvider // TypeDefIndex: 5252
{
	// Methods

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0x3A91B0 Offset: 0x3A77B0 VA: 0x1803A91B0
	private static void Initialize() { }

	// RVA: 0x3A8E80 Offset: 0x3A7480 VA: 0x1803A8E80
	private static GameObject CreateDefaultGlyphOrTextPrefab() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
public class UnityUIGlyphOrText : GlyphOrTextBase<Image, Sprite, Text> // TypeDefIndex: 5253
{
	// Properties
	protected override string textString { get; set; }
	protected override Sprite glyphGraphic { get; set; }

	// Methods

	// RVA: 0x3A95E0 Offset: 0x3A7BE0 VA: 0x1803A95E0 Slot: 4
	protected override string get_textString() { }

	// RVA: 0x3A9730 Offset: 0x3A7D30 VA: 0x1803A9730 Slot: 5
	protected override void set_textString(string value) { }

	// RVA: 0x3A9550 Offset: 0x3A7B50 VA: 0x1803A9550 Slot: 10
	protected override Sprite get_glyphGraphic() { }

	// RVA: 0x3A9690 Offset: 0x3A7C90 VA: 0x1803A9690 Slot: 11
	protected override void set_glyphGraphic(Sprite value) { }

	// RVA: 0x3A9510 Offset: 0x3A7B10 VA: 0x1803A9510
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
public class UnityUIGlyphOrTextTMPro : GlyphOrTextBase<Image, Sprite, TMP_Text> // TypeDefIndex: 5254
{
	// Properties
	protected override string textString { get; set; }
	protected override Sprite glyphGraphic { get; set; }

	// Methods

	// RVA: 0x3A9320 Offset: 0x3A7920 VA: 0x1803A9320 Slot: 4
	protected override string get_textString() { }

	// RVA: 0x3A9470 Offset: 0x3A7A70 VA: 0x1803A9470 Slot: 5
	protected override void set_textString(string value) { }

	// RVA: 0x3A9290 Offset: 0x3A7890 VA: 0x1803A9290 Slot: 10
	protected override Sprite get_glyphGraphic() { }

	// RVA: 0x3A93D0 Offset: 0x3A79D0 VA: 0x1803A93D0 Slot: 11
	protected override void set_glyphGraphic(Sprite value) { }

	// RVA: 0x3A9250 Offset: 0x3A7850 VA: 0x1803A9250
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
[AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Player Controller Element Glyph")]
public class UnityUIPlayerControllerElementGlyph : UnityUIPlayerControllerElementGlyphBase // TypeDefIndex: 5255
{
	// Fields
	[Tooltip("The Player id.")]
	[SerializeField]
	private int _playerId; // 0x88
	[Tooltip("The Action name.")]
	[SerializeField]
	private string _actionName; // 0x90
	private int _actionId; // 0x98
	private bool _actionIdCached; // 0x9C

	// Properties
	public override int playerId { get; set; }
	public override int actionId { get; set; }
	public string actionName { get; set; }

	// Methods

	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90 Slot: 30
	public override int get_playerId() { }

	// RVA: 0x3AAD20 Offset: 0x3A9320 VA: 0x1803AAD20 Slot: 31
	public override void set_playerId(int value) { }

	// RVA: 0x3AAB40 Offset: 0x3A9140 VA: 0x1803AAB40 Slot: 32
	public override int get_actionId() { }

	// RVA: 0x3AABA0 Offset: 0x3A91A0 VA: 0x1803AABA0 Slot: 33
	public override void set_actionId(int value) { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public string get_actionName() { }

	// RVA: 0x3AACF0 Offset: 0x3A92F0 VA: 0x1803AACF0
	public void set_actionName(string value) { }

	// RVA: 0x3AA920 Offset: 0x3A8F20 VA: 0x1803AA920
	private void CacheActionId() { }

	// RVA: 0x3AAA10 Offset: 0x3A9010 VA: 0x1803AAA10
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
public abstract class UnityUIPlayerControllerElementGlyphBase : UnityUIControllerElementGlyphBase // TypeDefIndex: 5256
{
	// Fields
	[Tooltip("Optional reference to an object that defines options. If blank, the global default options will be used.")]
	[SerializeField]
	private ControllerElementGlyphSelectorOptionsSOBase _options; // 0x48
	[Tooltip("The range of the Action for which to show glyphs / text. This determines whether to show the glyph for an axis-type Action (ex: Move Horizontal), or the positive/negative pole of an Action (ex: Move Right). For button-type Actions, Full and Positive are equivalent.")]
	[SerializeField]
	private AxisRange _actionRange; // 0x50
	[Tooltip("Optional parent Transform of the first group of instantiated glyph / text objects. If an axis-type Action is bound to multiple elements, the glyphs bound to the negative pole of the Action will be instantiated under this Transform. This allows you to separate negative and positive groups in order to stack glyph groups horizontally or vertically, for example. If an Action is only bound to one element, the glyph will be instantiated under this transform. If blank, objects will be created as children of this object's Transform.")]
	[SerializeField]
	private Transform _group1; // 0x58
	[Tooltip("Optional parent Transform of the second group of instantiated glyph / text objects. If an axis-type Action is bound to multiple elements, the glyphs bound to the positive pole of the Action will be instantiated under this Transform. This allows you to separate negative and positive groups in order to stack glyph groups horizontally or vertically, for example. If an Action is only bound to one element, the glyph will be instantiated under group1 instead. If blank, objects will be created as children of either group1 if set or the object's Transform.")]
	[SerializeField]
	private Transform _group2; // 0x60
	private List<ActionElementMap> _tempAems; // 0x68
	private List<ActionElementMap> _tempCombinedElementAems; // 0x70
	private readonly List<ControllerElementGlyphBase.GlyphOrTextObject> _group1Objects; // 0x78
	private readonly List<ControllerElementGlyphBase.GlyphOrTextObject> _group2Objects; // 0x80

	// Properties
	public virtual ControllerElementGlyphSelectorOptionsSOBase options { get; set; }
	public abstract int playerId { get; set; }
	public abstract int actionId { get; set; }
	public virtual AxisRange actionRange { get; set; }
	public virtual Transform group1 { get; set; }
	public virtual Transform group2 { get; set; }
	protected virtual bool isMousePrioritizedOverKeyboard { get; }

	// Methods

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 28
	public virtual ControllerElementGlyphSelectorOptionsSOBase get_options() { }

	// RVA: 0x3AA8F0 Offset: 0x3A8EF0 VA: 0x1803AA8F0 Slot: 29
	public virtual void set_options(ControllerElementGlyphSelectorOptionsSOBase value) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int get_playerId();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void set_playerId(int value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int get_actionId();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void set_actionId(int value);

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0 Slot: 34
	public virtual AxisRange get_actionRange() { }

	// RVA: 0x3AA880 Offset: 0x3A8E80 VA: 0x1803AA880 Slot: 35
	public virtual void set_actionRange(AxisRange value) { }

	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80 Slot: 36
	public virtual Transform get_group1() { }

	// RVA: 0x3AA890 Offset: 0x3A8E90 VA: 0x1803AA890 Slot: 37
	public virtual void set_group1(Transform value) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0 Slot: 38
	public virtual Transform get_group2() { }

	// RVA: 0x3AA8C0 Offset: 0x3A8EC0 VA: 0x1803AA8C0 Slot: 39
	public virtual void set_group2(Transform value) { }

	// RVA: 0x3AA800 Offset: 0x3A8E00 VA: 0x1803AA800 Slot: 40
	protected virtual bool get_isMousePrioritizedOverKeyboard() { }

	// RVA: 0x3AA480 Offset: 0x3A8A80 VA: 0x1803AA480 Slot: 41
	protected virtual bool TryGetControllerTypeOrder(int index, out ControllerType controllerType) { }

	// RVA: 0x3AA4E0 Offset: 0x3A8AE0 VA: 0x1803AA4E0 Slot: 13
	protected override void Update() { }

	// RVA: 0x3A97D0 Offset: 0x3A7DD0 VA: 0x1803A97D0 Slot: 15
	protected override void ClearObjects() { }

	// RVA: 0x3AA040 Offset: 0x3A8640 VA: 0x1803AA040 Slot: 42
	protected virtual bool ShowBinding(ActionElementMap actionElementMap) { }

	// RVA: 0x3AA290 Offset: 0x3A8890 VA: 0x1803AA290 Slot: 43
	protected virtual bool ShowSplitAxisBindings(ActionElementMap negativeAem, ActionElementMap positiveAem) { }

	// RVA: 0x3A9950 Offset: 0x3A7F50 VA: 0x1803A9950 Slot: 16
	protected override void EvaluateObjectVisibility() { }

	// RVA: 0x3AA0D0 Offset: 0x3A86D0 VA: 0x1803AA0D0 Slot: 44
	protected virtual int ShowGlyphsOrText(IList<ActionElementMap> bindings, Transform parent, List<ControllerElementGlyphBase.GlyphOrTextObject> objects) { }

	// RVA: 0x3A9E40 Offset: 0x3A8440 VA: 0x1803A9E40 Slot: 23
	protected override void Hide() { }

	// RVA: 0x3A9B00 Offset: 0x3A8100 VA: 0x1803A9B00 Slot: 45
	protected virtual Transform GetObjectGroupTransform(int groupIndex) { }

	// RVA: 0x3A9CA0 Offset: 0x3A82A0 VA: 0x1803A9CA0 Slot: 46
	protected virtual ControllerElementGlyphSelectorOptions GetOptionsOrDefault() { }

	// RVA: 0x3AA6C0 Offset: 0x3A8CC0 VA: 0x1803AA6C0
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs.UnityUI
[AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Text Mesh Pro Glyph Helper")]
[RequireComponent(typeof(TextMeshProUGUI))]
public class UnityUITextMeshProGlyphHelper : MonoBehaviour // TypeDefIndex: 5281
{
	// Fields
	[Tooltip("Enter text into this field and not in the TMPro Text field directly. Text will be parsed for special tags, and the final result will be passed on to the Text Mesh Pro Text component. See the documentation for special tag format.")]
	[SerializeField]
	[TextArea(3, 10)]
	private string _text; // 0x20
	[Tooltip("Optional reference to an object that defines options. If blank, the global default options will be used.")]
	[SerializeField]
	private ControllerElementGlyphSelectorOptionsSOBase _options; // 0x28
	[Tooltip("Options that control how Text Mesh Pro displays Sprites.")]
	[SerializeField]
	private UnityUITextMeshProGlyphHelper.TMProSpriteOptions _spriteOptions; // 0x30
	[Tooltip("Optional material for Sprites. If blank, the default material will be used.
Material is instantiated for each Sprite Asset, so making changes to values in the base material later will not affect Sprites. Changing the base material at runtime will copy only certain properties from the new material to Sprite materials.")]
	[SerializeField]
	private Material _baseSpriteMaterial; // 0x50
	[Tooltip("If enabled, local values such as Sprite color will be used instead of the value on the base material.")]
	[SerializeField]
	private bool _overrideSpriteMaterialProperties; // 0x58
	[Tooltip("These properties will override the properties on the Sprite material if Override Sprite Material Properties is enabled.")]
	[SerializeField]
	private UnityUITextMeshProGlyphHelper.SpriteMaterialProperties _spriteMaterialProperties; // 0x5C
	private TextMeshProUGUI _tmProText; // 0x70
	private string _textPrev; // 0x78
	private readonly StringBuilder _processTagSb; // 0x80
	private readonly StringBuilder _tempSb; // 0x88
	private readonly StringBuilder _tempSb2; // 0x90
	private UnityUITextMeshProGlyphHelper.Asset _primaryAsset; // 0x98
	private readonly List<UnityUITextMeshProGlyphHelper.Asset> _assignedAssets; // 0xA0
	private readonly List<UnityUITextMeshProGlyphHelper.Asset> _assetsPool; // 0xA8
	private readonly List<ActionElementMap> _tempAems; // 0xB0
	private readonly List<Sprite> _tempGlyphs; // 0xB8
	private readonly List<UnityUITextMeshProGlyphHelper.Asset> _dirtyAssets; // 0xC0
	private readonly List<string> _tempKeys; // 0xC8
	private readonly List<UnityUITextMeshProGlyphHelper.GlyphOrText> _glyphsOrTextTemp; // 0xD0
	private readonly List<UnityUITextMeshProGlyphHelper.Asset> _currentlyUsedAssets; // 0xD8
	private readonly List<UnityUITextMeshProGlyphHelper.Tag> _currentTags; // 0xE0
	private Dictionary<string, string> _tempStringDictionary; // 0xE8
	private bool _initialized; // 0xF0
	private bool _rebuildRequired; // 0xF1
	private Texture2D _stubTexture; // 0xF8
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> __controllerElementTagPool; // 0x100
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> __actionTagPool; // 0x108
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> __playerTagPool; // 0x110
	private Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> __tagHandlers; // 0x118
	private static string[] __s_displayTypeNames; // 0x0
	private static UnityUITextMeshProGlyphHelper.DisplayType[] __s_displayTypeValues; // 0x8
	private static string[] __s_axisRangeNames; // 0x10
	private static AxisRange[] __s_axisRangeValues; // 0x18

	// Properties
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> controllerElementTagPool { get; }
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> actionTagPool { get; }
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> playerTagPool { get; }
	private Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> tagHandlers { get; }
	public virtual string text { get; set; }
	public virtual ControllerElementGlyphSelectorOptionsSOBase options { get; set; }
	public virtual UnityUITextMeshProGlyphHelper.TMProSpriteOptions spriteOptions { get; set; }
	public virtual Material baseSpriteMaterial { get; set; }
	public virtual bool overrideSpriteMaterialProperties { get; set; }
	public virtual UnityUITextMeshProGlyphHelper.SpriteMaterialProperties spriteMaterialProperties { get; set; }
	private static int shaderPropertyId_color { get; }
	private static string[] s_displayTypeNames { get; }
	private static UnityUITextMeshProGlyphHelper.DisplayType[] s_displayTypeValues { get; }
	private static string[] s_axisRangeNames { get; }
	private static AxisRange[] s_axisRangeValues { get; }

	// Methods

	// RVA: 0x3AFCF0 Offset: 0x3AE2F0 VA: 0x1803AFCF0
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> get_controllerElementTagPool() { }

	// RVA: 0x3AFC60 Offset: 0x3AE260 VA: 0x1803AFC60
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> get_actionTagPool() { }

	// RVA: 0x3AFD90 Offset: 0x3AE390 VA: 0x1803AFD90
	private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> get_playerTagPool() { }

	// RVA: 0x3B02A0 Offset: 0x3AE8A0 VA: 0x1803B02A0
	private Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> get_tagHandlers() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 4
	public virtual string get_text() { }

	// RVA: 0x3B0AE0 Offset: 0x3AF0E0 VA: 0x1803B0AE0 Slot: 5
	public virtual void set_text(string value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 6
	public virtual ControllerElementGlyphSelectorOptionsSOBase get_options() { }

	// RVA: 0x3B0590 Offset: 0x3AEB90 VA: 0x1803B0590 Slot: 7
	public virtual void set_options(ControllerElementGlyphSelectorOptionsSOBase value) { }

	// RVA: 0x3B0280 Offset: 0x3AE880 VA: 0x1803B0280 Slot: 8
	public virtual UnityUITextMeshProGlyphHelper.TMProSpriteOptions get_spriteOptions() { }

	// RVA: 0x3B07C0 Offset: 0x3AEDC0 VA: 0x1803B07C0 Slot: 9
	public virtual void set_spriteOptions(UnityUITextMeshProGlyphHelper.TMProSpriteOptions value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 10
	public virtual Material get_baseSpriteMaterial() { }

	// RVA: 0x3B0460 Offset: 0x3AEA60 VA: 0x1803B0460 Slot: 11
	public virtual void set_baseSpriteMaterial(Material value) { }

	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80 Slot: 12
	public virtual bool get_overrideSpriteMaterialProperties() { }

	// RVA: 0x3B05C0 Offset: 0x3AEBC0 VA: 0x1803B05C0 Slot: 13
	public virtual void set_overrideSpriteMaterialProperties(bool value) { }

	// RVA: 0x3B0270 Offset: 0x3AE870 VA: 0x1803B0270 Slot: 14
	public virtual UnityUITextMeshProGlyphHelper.SpriteMaterialProperties get_spriteMaterialProperties() { }

	// RVA: 0x3B0730 Offset: 0x3AED30 VA: 0x1803B0730 Slot: 15
	public virtual void set_spriteMaterialProperties(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties value) { }

	// RVA: 0x3AC810 Offset: 0x3AAE10 VA: 0x1803AC810 Slot: 16
	protected virtual void OnEnable() { }

	// RVA: 0x3ADE80 Offset: 0x3AC480 VA: 0x1803ADE80 Slot: 17
	protected virtual void Start() { }

	// RVA: 0x3AF740 Offset: 0x3ADD40 VA: 0x1803AF740 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x3AC460 Offset: 0x3AAA60 VA: 0x1803AC460 Slot: 19
	protected virtual void OnDestroy() { }

	// RVA: 0x3AB350 Offset: 0x3A9950 VA: 0x1803AB350 Slot: 20
	public virtual void ForceUpdate() { }

	// RVA: 0x3AB400 Offset: 0x3A9A00 VA: 0x1803AB400 Slot: 21
	protected virtual ControllerElementGlyphSelectorOptions GetOptionsOrDefault() { }

	// RVA: 0x3ABB50 Offset: 0x3AA150 VA: 0x1803ABB50
	private bool Initialize() { }

	// RVA: 0x3ABED0 Offset: 0x3AA4D0 VA: 0x1803ABED0
	private void MainUpdate() { }

	// RVA: 0x3ACE50 Offset: 0x3AB450 VA: 0x1803ACE50
	private bool ParseText(string text, out string newText) { }

	// RVA: 0x3AD030 Offset: 0x3AB630 VA: 0x1803AD030
	private bool ProcessNextTag(ref string text, StringBuilder sb) { }

	// RVA: 0x3AD690 Offset: 0x3ABC90 VA: 0x1803AD690
	private bool ProcessTag_ControllerElement(string text, int startIndex, int count, out string replacement) { }

	// RVA: 0x3AD420 Offset: 0x3ABA20 VA: 0x1803AD420
	private bool ProcessTag_Action(string text, int startIndex, int count, out string replacement) { }

	// RVA: 0x3AD910 Offset: 0x3ABF10 VA: 0x1803AD910
	private bool ProcessTag_Player(string text, int startIndex, int count, out string replacement) { }

	// RVA: 0x3AE5C0 Offset: 0x3ACBC0 VA: 0x1803AE5C0
	private bool TryCreateTMProString(List<UnityUITextMeshProGlyphHelper.GlyphOrText> glyphs, out string result) { }

	// RVA: 0x3AE8A0 Offset: 0x3ACEA0 VA: 0x1803AE8A0
	private bool TryGetControllerElementGlyphsOrText(UnityUITextMeshProGlyphHelper.ControllerElementTag tag, List<UnityUITextMeshProGlyphHelper.GlyphOrText> results) { }

	// RVA: 0x3AE7D0 Offset: 0x3ACDD0 VA: 0x1803AE7D0
	private bool TryGetActionDisplayName(UnityUITextMeshProGlyphHelper.ActionTag tag, out string result) { }

	// RVA: 0x3AF440 Offset: 0x3ADA40 VA: 0x1803AF440
	private bool TryGetPlayerDisplayName(UnityUITextMeshProGlyphHelper.PlayerTag tag, out string result) { }

	// RVA: 0x3ADE90 Offset: 0x3AC490 VA: 0x1803ADE90
	private bool TryAssignSprite(Sprite sprite, string key) { }

	// RVA: 0x3ADDE0 Offset: 0x3AC3E0 VA: 0x1803ADDE0
	private void RequireRebuild() { }

	// RVA: 0x3AB140 Offset: 0x3A9740 VA: 0x1803AB140
	private void CreatePrimaryAsset() { }

	// RVA: 0x3AB5A0 Offset: 0x3A9BA0 VA: 0x1803AB5A0
	private UnityUITextMeshProGlyphHelper.Asset GetOrCreateAsset(Sprite sprite) { }

	// RVA: 0x3AB010 Offset: 0x3A9610 VA: 0x1803AB010
	private UnityUITextMeshProGlyphHelper.Asset CreateAsset() { }

	// RVA: 0x3ADB70 Offset: 0x3AC170 VA: 0x1803ADB70
	private void RemoveUnusedAssets() { }

	// RVA: 0x3ADDF0 Offset: 0x3AC3F0 VA: 0x1803ADDF0
	private void SetDirty(UnityUITextMeshProGlyphHelper.Asset asset) { }

	// RVA: 0x3AB200 Offset: 0x3A9800 VA: 0x1803AB200
	private void ForEachAsset(Action<UnityUITextMeshProGlyphHelper.Asset> callback) { }

	// RVA: 0x3B0230 Offset: 0x3AE830 VA: 0x1803B0230
	private static int get_shaderPropertyId_color() { }

	// RVA: 0x3B0030 Offset: 0x3AE630 VA: 0x1803B0030
	private static string[] get_s_displayTypeNames() { }

	// RVA: 0x3B0100 Offset: 0x3AE700 VA: 0x1803B0100
	private static UnityUITextMeshProGlyphHelper.DisplayType[] get_s_displayTypeValues() { }

	// RVA: 0x3AFE20 Offset: 0x3AE420 VA: 0x1803AFE20
	private static string[] get_s_axisRangeNames() { }

	// RVA: 0x3AFF00 Offset: 0x3AE500 VA: 0x1803AFF00
	private static AxisRange[] get_s_axisRangeValues() { }

	// RVA: 0x3AC970 Offset: 0x3AAF70 VA: 0x1803AC970
	private static void ParseAttributes(string text, int startIndex, int count, StringBuilder sbKey, StringBuilder sbValue, Dictionary<string, string> results) { }

	// RVA: 0x3ABE50 Offset: 0x3AA450 VA: 0x1803ABE50
	private static bool IsValidKeyChar(char c) { }

	// RVA: 0x3ABE50 Offset: 0x3AA450 VA: 0x1803ABE50
	private static bool IsValidTagNameChar(char c) { }

	// RVA: 0x3ABEA0 Offset: 0x3AA4A0 VA: 0x1803ABEA0
	private static bool IsValidNonQuotedValueChar(char c) { }

	// RVA: 0x3ABCB0 Offset: 0x3AA2B0 VA: 0x1803ABCB0
	private static bool IsEqual(List<UnityUITextMeshProGlyphHelper.GlyphOrText> a, List<UnityUITextMeshProGlyphHelper.GlyphOrText> b) { }

	// RVA: 0x3AF7E0 Offset: 0x3ADDE0 VA: 0x1803AF7E0
	private static void WriteSpriteKey(StringBuilder sb, string key) { }

	// RVA: 0x3AF160 Offset: 0x3AD760 VA: 0x1803AF160
	private static bool TryGetGlyphsOrText(ActionElementMap aem, UnityUITextMeshProGlyphHelper.DisplayType displayType, List<Sprite> glyphs, List<string> keys, List<UnityUITextMeshProGlyphHelper.GlyphOrText> results) { }

	// RVA: 0x3ABE30 Offset: 0x3AA430 VA: 0x1803ABE30
	private static bool IsGlyphAllowed(UnityUITextMeshProGlyphHelper.DisplayType displayType) { }

	// RVA: 0x3ABE40 Offset: 0x3AA440 VA: 0x1803ABE40
	private static bool IsTextAllowed(UnityUITextMeshProGlyphHelper.DisplayType displayType) { }

	// RVA: 0x3AAD30 Offset: 0x3A9330 VA: 0x1803AAD30
	private static void CopyMaterialProperties(Material source, Material destination) { }

	// RVA: 0x3AAF50 Offset: 0x3A9550 VA: 0x1803AAF50
	private static void CopySpriteMaterialPropertiesToMaterial(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties properties, Material material) { }

	// RVA: 0x3AF860 Offset: 0x3ADE60 VA: 0x1803AF860
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3AF500 Offset: 0x3ADB00 VA: 0x1803AF500
	private void <set_overrideSpriteMaterialProperties>b__51_0(UnityUITextMeshProGlyphHelper.Asset asset) { }

	[CompilerGenerated]
	// RVA: 0x3AF620 Offset: 0x3ADC20 VA: 0x1803AF620
	private void <set_spriteMaterialProperties>b__54_0(UnityUITextMeshProGlyphHelper.Asset asset) { }
}

