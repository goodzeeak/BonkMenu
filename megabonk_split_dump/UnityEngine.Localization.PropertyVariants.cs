// Namespace: UnityEngine.Localization.PropertyVariants
[Usage(4)]
public class CustomTrackedObjectAttribute : Attribute // TypeDefIndex: 12044
{
	// Fields
	[CompilerGenerated]
	private readonly Type <ObjectType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <SupportsInheritedTypes>k__BackingField; // 0x18

	// Properties
	internal Type ObjectType { get; }
	internal bool SupportsInheritedTypes { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal Type get_ObjectType() { }

	[CompilerGenerated]
	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	internal bool get_SupportsInheritedTypes() { }

	// RVA: 0x1523850 Offset: 0x1521E50 VA: 0x181523850
	public void .ctor(Type type, bool supportsInheritedTypes) { }
}

// Namespace: UnityEngine.Localization.PropertyVariants
[ExecuteAlways]
[DisallowMultipleComponent]
public class GameObjectLocalizer : MonoBehaviour // TypeDefIndex: 12046
{
	// Fields
	[SerializeReference]
	private List<TrackedObject> m_TrackedObjects; // 0x20
	private Locale m_CurrentLocale; // 0x28
	[CompilerGenerated]
	private AsyncOperationHandle <CurrentOperation>k__BackingField; // 0x30

	// Properties
	internal AsyncOperationHandle CurrentOperation { get; set; }
	public List<TrackedObject> TrackedObjects { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1ECB590 Offset: 0x1EC9B90 VA: 0x181ECB590
	internal AsyncOperationHandle get_CurrentOperation() { }

	[CompilerGenerated]
	// RVA: 0x1F04930 Offset: 0x1F02F30 VA: 0x181F04930
	private void set_CurrentOperation(AsyncOperationHandle value) { }

	// RVA: 0x1F046F0 Offset: 0x1F02CF0 VA: 0x181F046F0
	private void OnEnable() { }

	// RVA: 0x1F04630 Offset: 0x1F02C30 VA: 0x181F04630
	private void OnDisable() { }

	[IteratorStateMachine(typeof(GameObjectLocalizer.<Start>d__8))]
	// RVA: 0x1F04840 Offset: 0x1F02E40 VA: 0x181F04840
	private IEnumerator Start() { }

	// RVA: 0x1F047B0 Offset: 0x1F02DB0 VA: 0x181F047B0
	private void SelectedLocaleChanged(Locale locale) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<TrackedObject> get_TrackedObjects() { }

	// RVA: -1 Offset: -1
	public T GetTrackedObject<T>(Object target, bool create = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x702B60 Offset: 0x701160 VA: 0x180702B60
	|-GameObjectLocalizer.GetTrackedObject<object>
	*/

	// RVA: 0x1F04450 Offset: 0x1F02A50 VA: 0x181F04450
	public TrackedObject GetTrackedObject(Object target) { }

	// RVA: 0x1F03F20 Offset: 0x1F02520 VA: 0x181F03F20
	public AsyncOperationHandle ApplyLocaleVariant(Locale locale) { }

	// RVA: 0x1F03F80 Offset: 0x1F02580 VA: 0x181F03F80
	public AsyncOperationHandle ApplyLocaleVariant(Locale locale, Locale fallback) { }

	// RVA: 0x1F048B0 Offset: 0x1F02EB0 VA: 0x181F048B0
	public void .ctor() { }
}

