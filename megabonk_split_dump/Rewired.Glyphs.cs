// Namespace: Rewired.Glyphs
public abstract class ControllerElementGlyph : ControllerElementGlyphBase // TypeDefIndex: 5229
{
	// Fields
	private ActionElementMap _actionElementMap; // 0x48
	private ControllerElementIdentifier _controllerElementIdentifier; // 0x50
	private AxisRange _axisRange; // 0x58

	// Properties
	public ActionElementMap actionElementMap { get; set; }
	public ControllerElementIdentifier controllerElementIdentifier { get; set; }
	public AxisRange axisRange { get; set; }

	// Methods

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public ActionElementMap get_actionElementMap() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_actionElementMap(ActionElementMap value) { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public ControllerElementIdentifier get_controllerElementIdentifier() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_controllerElementIdentifier(ControllerElementIdentifier value) { }

	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0
	public AxisRange get_axisRange() { }

	// RVA: 0x399820 Offset: 0x397E20 VA: 0x180399820
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x3996C0 Offset: 0x397CC0 VA: 0x1803996C0 Slot: 13
	protected override void Update() { }

	// RVA: 0x3997E0 Offset: 0x397DE0 VA: 0x1803997E0
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs
public abstract class ControllerElementGlyphBase : MonoBehaviour // TypeDefIndex: 5232
{
	// Fields
	[Tooltip("If set, when glyph/text objects are created, they will be instantiated from this prefab. If left blank, the global default prefab will be used.")]
	[SerializeField]
	private GameObject _glyphOrTextPrefab; // 0x20
	[Tooltip("Determines what types of objects are allowed.")]
	[SerializeField]
	private ControllerElementGlyphBase.AllowedTypes _allowedTypes; // 0x28
	private readonly List<ControllerElementGlyphBase.GlyphOrTextObject> _entries; // 0x30
	private List<object> _tempGlyphs; // 0x38
	private GameObject _lastGlyphOrTextPrefab; // 0x40

	// Properties
	public virtual GameObject glyphOrTextPrefab { get; set; }
	public virtual ControllerElementGlyphBase.AllowedTypes allowedTypes { get; set; }
	protected List<ControllerElementGlyphBase.GlyphOrTextObject> entries { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 4
	public virtual GameObject get_glyphOrTextPrefab() { }

	// RVA: 0x399440 Offset: 0x397A40 VA: 0x180399440 Slot: 5
	public virtual void set_glyphOrTextPrefab(GameObject value) { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60 Slot: 6
	public virtual ControllerElementGlyphBase.AllowedTypes get_allowedTypes() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0 Slot: 7
	public virtual void set_allowedTypes(ControllerElementGlyphBase.AllowedTypes value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	protected List<ControllerElementGlyphBase.GlyphOrTextObject> get_entries() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected virtual void Awake() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	protected virtual void Start() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	protected virtual void OnDestroy() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 11
	protected virtual void OnEnable() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	protected virtual void OnDisable() { }

	// RVA: 0x399250 Offset: 0x397850 VA: 0x180399250 Slot: 13
	protected virtual void Update() { }

	// RVA: 0x398D10 Offset: 0x397310 VA: 0x180398D10 Slot: 14
	public virtual void RequireRebuild() { }

	// RVA: 0x3984A0 Offset: 0x396AA0 VA: 0x1803984A0 Slot: 15
	protected virtual void ClearObjects() { }

	// RVA: 0x398A40 Offset: 0x397040 VA: 0x180398A40 Slot: 16
	protected virtual void EvaluateObjectVisibility() { }

	// RVA: 0x398B00 Offset: 0x397100 VA: 0x180398B00 Slot: 17
	protected virtual void EvaluateObjectVisibility(Transform transform) { }

	// RVA: 0x3988F0 Offset: 0x396EF0 VA: 0x1803988F0 Slot: 18
	protected virtual void EvaluateObjectVisibility(Transform transform, List<ControllerElementGlyphBase.GlyphOrTextObject> entries) { }

	// RVA: 0x398D30 Offset: 0x397330 VA: 0x180398D30 Slot: 19
	protected virtual int ShowGlyphsOrText(ActionElementMap actionElementMap, Transform parent, List<ControllerElementGlyphBase.GlyphOrTextObject> entries) { }

	// RVA: 0x398FE0 Offset: 0x3975E0 VA: 0x180398FE0 Slot: 20
	protected virtual int ShowGlyphsOrText(ActionElementMap actionElementMap) { }

	// RVA: 0x399030 Offset: 0x397630 VA: 0x180399030 Slot: 21
	protected virtual int ShowGlyphsOrText(ControllerElementIdentifier elementIdentifier, AxisRange axisRange, Transform parent, List<ControllerElementGlyphBase.GlyphOrTextObject> entries) { }

	// RVA: 0x3991F0 Offset: 0x3977F0 VA: 0x1803991F0 Slot: 22
	protected virtual int ShowGlyphsOrText(ControllerElementIdentifier elementIdentifier, AxisRange axisRange) { }

	// RVA: 0x398C40 Offset: 0x397240 VA: 0x180398C40 Slot: 23
	protected virtual void Hide() { }

	// RVA: 0x398B20 Offset: 0x397120 VA: 0x180398B20 Slot: 24
	protected virtual GameObject GetGlyphOrTextPrefabOrDefault() { }

	// RVA: -1 Offset: -1 Slot: 25
	protected abstract GameObject GetDefaultGlyphOrTextPrefab();

	// RVA: 0x3985A0 Offset: 0x396BA0 VA: 0x1803985A0 Slot: 26
	protected virtual bool CreateObjectsAsNeeded(Transform parent, List<ControllerElementGlyphBase.GlyphOrTextObject> entries, int count) { }

	// RVA: 0x398D00 Offset: 0x397300 VA: 0x180398D00 Slot: 27
	protected virtual bool IsAllowed(ControllerElementGlyphBase.AllowedTypes allowedType) { }

	// RVA: 0x398BB0 Offset: 0x3971B0 VA: 0x180398BB0
	protected static int GetGlyphs(ActionElementMap actionElementMap, List<object> results) { }

	// RVA: 0x399380 Offset: 0x397980 VA: 0x180399380
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public class ControllerElementGlyphSelectorOptions // TypeDefIndex: 5233
{
	// Fields
	[Tooltip("Determines if the Player's last active controller is used for glyph selection.")]
	[SerializeField]
	private bool _useLastActiveController; // 0x10
	[Tooltip("List of controller type priority. First in list corresponds to highest priority. This determines which controller types take precedence when displaying glyphs. If use last active controller is enabled, the active controller will always take priority, however, if there is no last active controller, selection will fall back based on this priority. In addition, keyboard and mouse are treated as a single controller for the purposes of glyph handling, so to prioritze keyboard over mouse or vice versa, the one that is lower in the list will take precedence.")]
	[SerializeField]
	private ControllerType[] _controllerTypeOrder; // 0x18
	private static ControllerElementGlyphSelectorOptions s_defaultOptions; // 0x0

	// Properties
	public bool useLastActiveController { get; set; }
	public ControllerType[] controllerTypeOrder { get; set; }
	public static ControllerElementGlyphSelectorOptions defaultOptions { get; set; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_useLastActiveController() { }

	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_useLastActiveController(bool value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ControllerType[] get_controllerTypeOrder() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_controllerTypeOrder(ControllerType[] value) { }

	// RVA: 0x399480 Offset: 0x397A80 VA: 0x180399480 Slot: 4
	public virtual bool TryGetControllerTypeOrder(int index, out ControllerType controllerType) { }

	// RVA: 0x399550 Offset: 0x397B50 VA: 0x180399550
	public static ControllerElementGlyphSelectorOptions get_defaultOptions() { }

	// RVA: 0x399650 Offset: 0x397C50 VA: 0x180399650
	public static void set_defaultOptions(ControllerElementGlyphSelectorOptions value) { }

	// RVA: 0x3994C0 Offset: 0x397AC0 VA: 0x1803994C0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public class ControllerElementGlyphSelectorOptionsSO : ControllerElementGlyphSelectorOptionsSOBase // TypeDefIndex: 5234
{
	// Fields
	[SerializeField]
	private ControllerElementGlyphSelectorOptions _options; // 0x18

	// Properties
	public override ControllerElementGlyphSelectorOptions options { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 4
	public override ControllerElementGlyphSelectorOptions get_options() { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public abstract class ControllerElementGlyphSelectorOptionsSOBase : ScriptableObject // TypeDefIndex: 5235
{
	// Properties
	public abstract ControllerElementGlyphSelectorOptions options { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ControllerElementGlyphSelectorOptions get_options();

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs
public abstract class DefaultControllerElementGlyphSettingsBase : MonoBehaviour // TypeDefIndex: 5236
{
	// Fields
	[Tooltip("The Controller element glyph options.")]
	[SerializeField]
	private ControllerElementGlyphSelectorOptions _options; // 0x20
	[Tooltip("The prefab used for each glyph or text object.")]
	[SerializeField]
	private GameObject _glyphOrTextPrefab; // 0x28

	// Properties
	public ControllerElementGlyphSelectorOptions options { get; set; }
	public GameObject glyphOrTextPrefab { get; set; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public ControllerElementGlyphSelectorOptions get_options() { }

	// RVA: 0x39A550 Offset: 0x398B50 VA: 0x18039A550
	public void set_options(ControllerElementGlyphSelectorOptions value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public GameObject get_glyphOrTextPrefab() { }

	// RVA: 0x39A520 Offset: 0x398B20 VA: 0x18039A520
	public void set_glyphOrTextPrefab(GameObject value) { }

	// RVA: 0x39A460 Offset: 0x398A60 VA: 0x18039A460 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x39A4E0 Offset: 0x398AE0 VA: 0x18039A4E0 Slot: 6
	protected virtual void SetDefaults() { }

	// RVA: 0x39A480 Offset: 0x398A80 VA: 0x18039A480 Slot: 7
	protected virtual void SetDefaultOptions() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void SetDefaultGlyphOrTextPrefab();

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs
public abstract class GlyphOrTextBase : MonoBehaviour // TypeDefIndex: 5238
{
	// Properties
	protected abstract string textString { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract string get_textString();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void set_textString(string value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ShowText(string text);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ShowGlyph(object glyph);

	// RVA: 0x39A5E0 Offset: 0x398BE0 VA: 0x18039A5E0 Slot: 8
	public virtual void Hide() { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Hide(GlyphOrTextBase.TypeFlags flags);

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs
public abstract class GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent> : GlyphOrTextBase // TypeDefIndex: 5239
{
	// Fields
	[SerializeField]
	private TTextComponent _textComponent; // 0x0
	[SerializeField]
	private TGlyphComponent _glyphComponent; // 0x0

	// Properties
	public TTextComponent textComponent { get; set; }
	public TGlyphComponent glyphComponent { get; set; }
	protected abstract TGlyphGraphic glyphGraphic { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public TTextComponent get_textComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-GlyphOrTextBase<object, object, object>.get_textComponent
	*/

	// RVA: -1 Offset: -1
	public void set_textComponent(TTextComponent value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	|-GlyphOrTextBase<object, object, object>.set_textComponent
	*/

	// RVA: -1 Offset: -1
	public TGlyphComponent get_glyphComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	|-GlyphOrTextBase<object, object, object>.get_glyphComponent
	*/

	// RVA: -1 Offset: -1
	public void set_glyphComponent(TGlyphComponent value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	|-GlyphOrTextBase<object, object, object>.set_glyphComponent
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract TGlyphGraphic get_glyphGraphic();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-GlyphOrTextBase<object, object, object>.get_glyphGraphic
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void set_glyphGraphic(TGlyphGraphic value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-GlyphOrTextBase<object, object, object>.set_glyphGraphic
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void ShowText(string text) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102E800 Offset: 0x102CE00 VA: 0x18102E800
	|-GlyphOrTextBase<object, object, object>.ShowText
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void ShowGlyph(object glyph) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102E510 Offset: 0x102CB10 VA: 0x18102E510
	|-GlyphOrTextBase<object, object, object>.ShowGlyph
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void ShowGlyph(TGlyphGraphic glyph) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102E6B0 Offset: 0x102CCB0 VA: 0x18102E6B0
	|-GlyphOrTextBase<object, object, object>.ShowGlyph
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Hide(GlyphOrTextBase.TypeFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102E300 Offset: 0x102C900 VA: 0x18102E300
	|-GlyphOrTextBase<object, object, object>.Hide
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x365090 Offset: 0x363690 VA: 0x180365090
	|-GlyphOrTextBase<object, object, object>..ctor
	*/
}

// Namespace: Rewired.Glyphs
public class GlyphProvider : MonoBehaviour, IGlyphProvider // TypeDefIndex: 5240
{
	// Fields
	[SerializeField]
	[Tooltip("Determines if glyphs should be fetched immediately in bulk when available. If false, glyphs will be fetched when queried.")]
	private bool _prefetch; // 0x20
	[SerializeField]
	[Tooltip("A list of glyph set collections. At least one collection must be assigned.")]
	private List<GlyphSetCollection> _glyphSetCollections; // 0x28
	private readonly Dictionary<string, object> _glyphs; // 0x30
	private bool _initialized; // 0x38

	// Properties
	public bool prefetch { get; set; }
	public List<GlyphSetCollection> glyphSetCollections { get; set; }
	protected Dictionary<string, object> glyphs { get; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_prefetch() { }

	// RVA: 0x39B980 Offset: 0x399F80 VA: 0x18039B980
	public void set_prefetch(bool value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public List<GlyphSetCollection> get_glyphSetCollections() { }

	// RVA: 0x39B860 Offset: 0x399E60 VA: 0x18039B860
	public void set_glyphSetCollections(List<GlyphSetCollection> value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	protected Dictionary<string, object> get_glyphs() { }

	// RVA: 0x39B3F0 Offset: 0x3999F0 VA: 0x18039B3F0 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x39B2A0 Offset: 0x3998A0 VA: 0x18039B2A0 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x39B5D0 Offset: 0x399BD0 VA: 0x18039B5D0 Slot: 8
	protected virtual void TrySetGlyphProvider() { }

	// RVA: 0x39AD80 Offset: 0x399380 VA: 0x18039AD80 Slot: 9
	protected virtual bool Initialize() { }

	// RVA: 0x39B430 Offset: 0x399A30 VA: 0x18039B430
	public void Reload() { }

	// RVA: 0x39B540 Offset: 0x399B40 VA: 0x18039B540 Slot: 4
	private bool Rewired.Interfaces.IGlyphProvider.TryGetGlyph(string key, out object result) { }

	// RVA: 0x39B7E0 Offset: 0x399DE0 VA: 0x18039B7E0
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public abstract class GlyphSet : ScriptableObject // TypeDefIndex: 5243
{
	// Fields
	[Tooltip("A list of base keys. Final keys will be composed of base key + glyph key. Setting multiple base keys allows one glyph set to apply to multiple controllers, for example.")]
	[SerializeField]
	private string[] _baseKeys; // 0x18

	// Properties
	public string[] baseKeys { get; set; }
	public abstract int glyphCount { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string[] get_baseKeys() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_baseKeys(string[] value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_glyphCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract GlyphSet.EntryBase GetEntry(int index);

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public class GlyphSetCollection : ScriptableObject // TypeDefIndex: 5245
{
	// Fields
	[Tooltip("The list of glyph sets.")]
	[SerializeField]
	private List<GlyphSet> _sets; // 0x18
	[Tooltip("The list of glyph set collections.")]
	[SerializeField]
	private List<GlyphSetCollection> _collections; // 0x20

	// Properties
	public List<GlyphSet> sets { get; set; }
	public List<GlyphSetCollection> collections { get; set; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public List<GlyphSet> get_sets() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_sets(List<GlyphSet> value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<GlyphSetCollection> get_collections() { }

	// RVA: 0x39BC70 Offset: 0x39A270 VA: 0x18039BC70
	public void set_collections(List<GlyphSetCollection> value) { }

	// RVA: 0x39BB20 Offset: 0x39A120 VA: 0x18039BB20 Slot: 4
	public virtual IEnumerable<GlyphSet> IterateSetsRecursively() { }

	[IteratorStateMachine(typeof(GlyphSetCollection.<IterateSetsRecursively>d__9))]
	// RVA: 0x39BA90 Offset: 0x39A090 VA: 0x18039BA90 Slot: 5
	protected virtual IEnumerable<GlyphSet> IterateSetsRecursively(List<GlyphSetCollection> processedCollections) { }

	// RVA: 0x39BC10 Offset: 0x39A210 VA: 0x18039BC10
	private static void LogCircularDependency() { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: Rewired.Glyphs
public static class GlyphTools // TypeDefIndex: 5246
{
	// Methods

	// RVA: 0x39C480 Offset: 0x39AA80 VA: 0x18039C480
	public static bool TryGetActionElementMaps(int playerId, int actionId, AxisRange actionRange, ControllerElementGlyphSelectorOptions options, List<ActionElementMap> workingActionElementMaps, out ActionElementMap aemResult1, out ActionElementMap aemResult2) { }

	// RVA: 0x39CB00 Offset: 0x39B100 VA: 0x18039CB00
	public static bool TryGetActionElementMaps(InputAction action, AxisRange actionRange, List<ActionElementMap> tempAems, out ActionElementMap aemResult1, out ActionElementMap aemResult2) { }

	// RVA: 0x39BEA0 Offset: 0x39A4A0 VA: 0x18039BEA0
	public static ActionElementMap FindFirstFullAxisBinding(List<ActionElementMap> actionElementMaps) { }

	// RVA: 0x39BD20 Offset: 0x39A320 VA: 0x18039BD20
	public static ActionElementMap FindFirstBinding(List<ActionElementMap> actionElementMaps, AxisRange actionRange) { }

	// RVA: 0x39BF50 Offset: 0x39A550 VA: 0x18039BF50
	public static bool FindFirstSplitAxisBindingPair(List<ActionElementMap> actionElementMaps, out ActionElementMap negativeAem, out ActionElementMap positiveAem) { }

	// RVA: 0x39C2D0 Offset: 0x39A8D0 VA: 0x18039C2D0
	public static bool IsMousePrioritizedOverKeyboard(ControllerElementGlyphSelectorOptions options) { }

	// RVA: 0x39C200 Offset: 0x39A800 VA: 0x18039C200
	private static int GetElementMapsWithAction(Player player, ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x39C140 Offset: 0x39A740 VA: 0x18039C140
	private static int GetElementMapsWithAction(Player player, ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x39C080 Offset: 0x39A680 VA: 0x18039C080
	private static int GetElementMapsWithAction(Player player, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x39C340 Offset: 0x39A940 VA: 0x18039C340
	private static int RemoveInvalidElementMaps(Player player, List<ActionElementMap> results, int startIndex) { }
}

// Namespace: Rewired.Glyphs
[Serializable]
public class SpriteGlyphSet : GlyphSet // TypeDefIndex: 5248
{
	// Fields
	[Tooltip("The list of glyphs.")]
	[SerializeField]
	private List<SpriteGlyphSet.Entry> _glyphs; // 0x20

	// Properties
	public List<SpriteGlyphSet.Entry> glyphs { get; set; }
	public override int glyphCount { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<SpriteGlyphSet.Entry> get_glyphs() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_glyphs(List<SpriteGlyphSet.Entry> value) { }

	// RVA: 0x3A4350 Offset: 0x3A2950 VA: 0x1803A4350 Slot: 4
	public override int get_glyphCount() { }

	// RVA: 0x3A4290 Offset: 0x3A2890 VA: 0x1803A4290 Slot: 5
	public override GlyphSet.EntryBase GetEntry(int index) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

