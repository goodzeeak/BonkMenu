// Namespace: UnityEngine.Localization.PropertyVariants.TrackedObjects
[Serializable]
public abstract class JsonSerializerTrackedObject : TrackedObject // TypeDefIndex: 12077
{
	// Fields
	[Tooltip("Determines the type of property update that will be performed.- Full update reads the entire object into JSON, patches the properties, then reapplies the new JSON.
- Partial update generates a partial patch and applies the changes for the tracked properties only.
Partial update provides better performance however is not supported when modifying collections or properties that contain a serialized version such as Rect.
This value is automatically set based on the properties tracked.")]
	[SerializeField]
	private JsonSerializerTrackedObject.ApplyChangesMethod m_UpdateType; // 0x28

	// Properties
	public JsonSerializerTrackedObject.ApplyChangesMethod UpdateType { get; set; }

	// Methods

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public JsonSerializerTrackedObject.ApplyChangesMethod get_UpdateType() { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	public void set_UpdateType(JsonSerializerTrackedObject.ApplyChangesMethod value) { }

	// RVA: 0x1F05DD0 Offset: 0x1F043D0 VA: 0x181F05DD0 Slot: 7
	public override void AddTrackedProperty(ITrackedProperty trackedProperty) { }

	// RVA: 0x1F06260 Offset: 0x1F04860 VA: 0x181F06260 Slot: 11
	public override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale) { }

	// RVA: 0x1F05EA0 Offset: 0x1F044A0 VA: 0x181F05EA0
	private void ApplyArraySizes(IEnumerable<ArraySizeTrackedProperty> arraySizes, JObject jsonObject, LocaleIdentifier variantLocale, LocaleIdentifier defaultLocale) { }

	// RVA: 0x1F06200 Offset: 0x1F04800 VA: 0x181F06200
	private void ApplyJson(JObject jsonObject) { }

	// RVA: 0x1F076A0 Offset: 0x1F05CA0 VA: 0x181F076A0
	internal static JsonSerializerTrackedObject.ArrayResult GetNextArrayItem(string path, int startIndex) { }

	// RVA: 0x1F07890 Offset: 0x1F05E90 VA: 0x181F07890
	internal static JToken GetPropertyFromPath(string path, JContainer obj) { }

	// RVA: 0x1F07E00 Offset: 0x1F06400 VA: 0x181F07E00
	protected void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedObjects
[DisplayName("Mesh Filter", null)]
[CustomTrackedObject(typeof(MeshFilter), False)]
[Serializable]
public class TrackedMeshFilter : TrackedObject // TypeDefIndex: 12078
{
	// Fields
	private const string k_MeshProperty = "m_Mesh";
	private AsyncOperationHandle<Mesh> m_CurrentOperation; // 0x28

	// Methods

	// RVA: 0x1F0BE30 Offset: 0x1F0A430 VA: 0x181F0BE30 Slot: 6
	public override bool CanTrackProperty(string propertyPath) { }

	// RVA: 0x1F0B840 Offset: 0x1F09E40 VA: 0x181F0B840 Slot: 11
	public override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale) { }

	// RVA: 0x1F0BE70 Offset: 0x1F0A470 VA: 0x181F0BE70
	private void MeshOperationCompleted(AsyncOperationHandle<Mesh> assetOp) { }

	// RVA: 0x1F0BED0 Offset: 0x1F0A4D0 VA: 0x181F0BED0
	private void SetMesh(Mesh mesh) { }

	// RVA: 0x1F07E00 Offset: 0x1F06400 VA: 0x181F07E00
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedObjects
[CustomTrackedObject(typeof(MonoBehaviour), True)]
[Serializable]
public class TrackedMonoBehaviourObject : JsonSerializerTrackedObject // TypeDefIndex: 12079
{
	// Fields
	[SerializeField]
	private UnityEvent m_Changed; // 0x30

	// Properties
	public UnityEvent Changed { get; }

	// Methods

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public UnityEvent get_Changed() { }

	// RVA: 0x1F0BF50 Offset: 0x1F0A550 VA: 0x181F0BF50 Slot: 12
	protected override void PostApplyTrackedProperties() { }

	// RVA: 0x1F0BF70 Offset: 0x1F0A570 VA: 0x181F0BF70
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedObjects
[Serializable]
public abstract class TrackedObject : ISerializationCallbackReceiver // TypeDefIndex: 12081
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private Object m_Target; // 0x10
	[SerializeField]
	private TrackedObject.TrackedPropertiesCollection m_TrackedProperties; // 0x18
	private readonly Dictionary<string, ITrackedProperty> m_PropertiesLookup; // 0x20

	// Properties
	public Object Target { get; set; }
	public IList<ITrackedProperty> TrackedProperties { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Object get_Target() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_Target(Object value) { }

	// RVA: 0x168F7D0 Offset: 0x168DDD0 VA: 0x18168F7D0
	public IList<ITrackedProperty> get_TrackedProperties() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 6
	public virtual bool CanTrackProperty(string propertyPath) { }

	// RVA: -1 Offset: -1
	public T AddTrackedProperty<T>(string propertyPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C5B60 Offset: 0x7C4160 VA: 0x1807C5B60
	|-TrackedObject.AddTrackedProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1F0BFE0 Offset: 0x1F0A5E0 VA: 0x181F0BFE0 Slot: 7
	public virtual void AddTrackedProperty(ITrackedProperty trackedProperty) { }

	// RVA: 0x1F0C6B0 Offset: 0x1F0ACB0 VA: 0x181F0C6B0 Slot: 8
	public virtual bool RemoveTrackedProperty(ITrackedProperty trackedProperty) { }

	// RVA: -1 Offset: -1
	public T GetTrackedProperty<T>(string propertyPath, bool create = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C5DD0 Offset: 0x7C43D0 VA: 0x1807C5DD0
	|-TrackedObject.GetTrackedProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1F0C220 Offset: 0x1F0A820 VA: 0x181F0C220 Slot: 9
	public virtual ITrackedProperty GetTrackedProperty(string propertyPath) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 10
	public virtual ITrackedProperty CreateCustomTrackedProperty(string propertyPath) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale);

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	protected virtual void PostApplyTrackedProperties() { }

	// RVA: 0x1F0C2A0 Offset: 0x1F0A8A0 VA: 0x181F0C2A0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1F0C4B0 Offset: 0x1F0AAB0 VA: 0x181F0C4B0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1F0C7E0 Offset: 0x1F0ADE0 VA: 0x181F0C7E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedObjects
[DisplayName("Rect Transform", null)]
[CustomTrackedObject(typeof(RectTransform), False)]
[Serializable]
public class TrackedRectTransform : TrackedTransform // TypeDefIndex: 12082
{
	// Fields
	private Vector3 m_AnchorPosToApply; // 0x58
	private Vector2 m_AnchorMinToApply; // 0x64
	private Vector2 m_AnchorMaxToApply; // 0x6C
	private Vector2 m_PivotToApply; // 0x74
	private Vector2 m_SizeDeltaToApply; // 0x7C

	// Methods

	// RVA: 0x1F0C970 Offset: 0x1F0AF70 VA: 0x181F0C970 Slot: 13
	protected override void AddPropertyHandlers(Dictionary<string, Action<float>> handlers) { }

	// RVA: 0x1F0CD90 Offset: 0x1F0B390 VA: 0x181F0CD90 Slot: 11
	public override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale) { }

	// RVA: 0x1F07E00 Offset: 0x1F06400 VA: 0x181F07E00
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F0CFA0 Offset: 0x1F0B5A0 VA: 0x181F0CFA0
	private void <AddPropertyHandlers>b__5_0(float val) { }

	[CompilerGenerated]
	// RVA: 0x1F0CFC0 Offset: 0x1F0B5C0 VA: 0x181F0CFC0
	private void <AddPropertyHandlers>b__5_1(float val) { }

	[CompilerGenerated]
	// RVA: 0x1F0CFD0 Offset: 0x1F0B5D0 VA: 0x181F0CFD0
	private void <AddPropertyHandlers>b__5_2(float val) { }

	[CompilerGenerated]
	// RVA: 0x1F0CFE0 Offset: 0x1F0B5E0 VA: 0x181F0CFE0
	private void <AddPropertyHandlers>b__5_3(float val) { }

	[CompilerGenerated]
	// RVA: 0x4A4310 Offset: 0x4A2910 VA: 0x1804A4310
	private void <AddPropertyHandlers>b__5_4(float val) { }

	[CompilerGenerated]
	// RVA: 0xC9D7C0 Offset: 0xC9BDC0 VA: 0x180C9D7C0
	private void <AddPropertyHandlers>b__5_5(float val) { }

	[CompilerGenerated]
	// RVA: 0x1F0CFF0 Offset: 0x1F0B5F0 VA: 0x181F0CFF0
	private void <AddPropertyHandlers>b__5_6(float val) { }

	[CompilerGenerated]
	// RVA: 0x1F0D000 Offset: 0x1F0B600 VA: 0x181F0D000
	private void <AddPropertyHandlers>b__5_7(float val) { }

	[CompilerGenerated]
	// RVA: 0x46E230 Offset: 0x46C830 VA: 0x18046E230
	private void <AddPropertyHandlers>b__5_8(float val) { }

	[CompilerGenerated]
	// RVA: 0x1F0D010 Offset: 0x1F0B610 VA: 0x181F0D010
	private void <AddPropertyHandlers>b__5_9(float val) { }

	[CompilerGenerated]
	// RVA: 0x1F0CFB0 Offset: 0x1F0B5B0 VA: 0x181F0CFB0
	private void <AddPropertyHandlers>b__5_10(float val) { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedObjects
[DisplayName("TMP Dropdown", null)]
[CustomTrackedObject(typeof(TMP_Dropdown), True)]
[Serializable]
public class TrackedTmpDropdown : JsonSerializerTrackedObject // TypeDefIndex: 12083
{
	// Methods

	// RVA: 0x1F0D020 Offset: 0x1F0B620 VA: 0x181F0D020 Slot: 12
	protected override void PostApplyTrackedProperties() { }

	// RVA: 0x1F07E00 Offset: 0x1F06400 VA: 0x181F07E00
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedObjects
[DisplayName("Transform", null)]
[CustomTrackedObject(typeof(Transform), False)]
[Serializable]
public class TrackedTransform : TrackedObject // TypeDefIndex: 12084
{
	// Fields
	private Vector3 m_PositionToApply; // 0x28
	private Quaternion m_RotationToApply; // 0x34
	private Vector3 m_ScaleToApply; // 0x44
	private Dictionary<string, Action<float>> m_PropertyHandlers; // 0x50

	// Methods

	// RVA: 0x1F0D0A0 Offset: 0x1F0B6A0 VA: 0x181F0D0A0 Slot: 13
	protected virtual void AddPropertyHandlers(Dictionary<string, Action<float>> handlers) { }

	// RVA: 0x1F0D990 Offset: 0x1F0BF90 VA: 0x181F0D990 Slot: 6
	public override bool CanTrackProperty(string propertyPath) { }

	// RVA: 0x1F0D460 Offset: 0x1F0BA60 VA: 0x181F0D460 Slot: 11
	public override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale) { }

	// RVA: 0x1F07E00 Offset: 0x1F06400 VA: 0x181F07E00
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3CB510 Offset: 0x3C9B10 VA: 0x1803CB510
	private void <AddPropertyHandlers>b__4_0(float val) { }

	[CompilerGenerated]
	// RVA: 0x1853730 Offset: 0x1851D30 VA: 0x181853730
	private void <AddPropertyHandlers>b__4_1(float val) { }

	[CompilerGenerated]
	// RVA: 0x36F720 Offset: 0x36DD20 VA: 0x18036F720
	private void <AddPropertyHandlers>b__4_2(float val) { }

	[CompilerGenerated]
	// RVA: 0x5590F0 Offset: 0x5576F0 VA: 0x1805590F0
	private void <AddPropertyHandlers>b__4_3(float val) { }

	[CompilerGenerated]
	// RVA: 0x559130 Offset: 0x557730 VA: 0x180559130
	private void <AddPropertyHandlers>b__4_4(float val) { }

	[CompilerGenerated]
	// RVA: 0x1853770 Offset: 0x1851D70 VA: 0x181853770
	private void <AddPropertyHandlers>b__4_5(float val) { }

	[CompilerGenerated]
	// RVA: 0x46E240 Offset: 0x46C840 VA: 0x18046E240
	private void <AddPropertyHandlers>b__4_6(float val) { }

	[CompilerGenerated]
	// RVA: 0x46E250 Offset: 0x46C850 VA: 0x18046E250
	private void <AddPropertyHandlers>b__4_7(float val) { }

	[CompilerGenerated]
	// RVA: 0x1F0DA10 Offset: 0x1F0C010 VA: 0x181F0DA10
	private void <AddPropertyHandlers>b__4_8(float val) { }

	[CompilerGenerated]
	// RVA: 0x1F0DA20 Offset: 0x1F0C020 VA: 0x181F0DA20
	private void <AddPropertyHandlers>b__4_9(float val) { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedObjects
[DisplayName("UI Graphic", null)]
[CustomTrackedObject(typeof(Graphic), True)]
[Serializable]
public class TrackedUGuiGraphic : JsonSerializerTrackedObject // TypeDefIndex: 12085
{
	// Methods

	// RVA: 0x1F0DAB0 Offset: 0x1F0C0B0 VA: 0x181F0DAB0 Slot: 12
	protected override void PostApplyTrackedProperties() { }

	// RVA: 0x1F07E00 Offset: 0x1F06400 VA: 0x181F07E00
	public void .ctor() { }
}

// Namespace: UnityEngine.Localization.PropertyVariants.TrackedObjects
[DisplayName("UI Dropdown", null)]
[CustomTrackedObject(typeof(Dropdown), True)]
[Serializable]
public class TrackedUGuiDropdown : JsonSerializerTrackedObject // TypeDefIndex: 12086
{
	// Methods

	// RVA: 0x1F0DA30 Offset: 0x1F0C030 VA: 0x181F0DA30 Slot: 12
	protected override void PostApplyTrackedProperties() { }

	// RVA: 0x1F07E00 Offset: 0x1F06400 VA: 0x181F07E00
	public void .ctor() { }
}

