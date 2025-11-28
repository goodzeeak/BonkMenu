// Namespace: Coffee.UIExtensions
[Serializable]
public class AnimatableProperty : ISerializationCallbackReceiver // TypeDefIndex: 13559
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private AnimatableProperty.ShaderPropertyType m_Type; // 0x18
	[CompilerGenerated]
	private int <id>k__BackingField; // 0x1C

	// Properties
	public int id { get; set; }
	public AnimatableProperty.ShaderPropertyType type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_id() { }

	[CompilerGenerated]
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	private void set_id(int value) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public AnimatableProperty.ShaderPropertyType get_type() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x553A20 Offset: 0x552020 VA: 0x180553A20 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x553A40 Offset: 0x552040 VA: 0x180553A40
	public void UpdateMaterialProperties(Material material, MaterialPropertyBlock mpb) { }

	// RVA: 0x553CD0 Offset: 0x5522D0 VA: 0x180553CD0
	public void .ctor() { }
}

// Namespace: Coffee.UIExtensions
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(CanvasRenderer))]
public class UIParticle : MaskableGraphic, ISerializationCallbackReceiver // TypeDefIndex: 13564
{
	// Fields
	[HideInInspector]
	[SerializeField]
	[Obsolete]
	internal bool m_IsTrail; // 0xE0
	[HideInInspector]
	[FormerlySerializedAs("m_IgnoreParent")]
	[SerializeField]
	[Obsolete]
	private bool m_IgnoreCanvasScaler; // 0xE1
	[HideInInspector]
	[SerializeField]
	[Obsolete]
	internal bool m_AbsoluteMode; // 0xE2
	[Tooltip("Scale the rendering particles. When the `3D` toggle is enabled, 3D scale (x, y, z) is supported.")]
	[SerializeField]
	private Vector3 m_Scale3D; // 0xE4
	[Tooltip("If you want to update material properties (e.g. _MainTex_ST, _Color) in AnimationClip, use this to mark as animatable.")]
	[SerializeField]
	internal AnimatableProperty[] m_AnimatableProperties; // 0xF0
	[Tooltip("Particles")]
	[SerializeField]
	private List<ParticleSystem> m_Particles; // 0xF8
	[Tooltip("Particle simulation results are shared within the same group. A large number of the same effects can be displayed with a small load.
None: Disable mesh sharing.
Auto: Automatically select Primary/Replica.
Primary: Provides particle simulation results to the same group.
Primary Simulator: Primary, but do not render the particle (simulation only).
Replica: Render simulation results provided by the primary.")]
	[SerializeField]
	private UIParticle.MeshSharing m_MeshSharing; // 0x100
	[Tooltip("Mesh sharing group ID.
If non-zero is specified, particle simulation results are shared within the group.")]
	[SerializeField]
	private int m_GroupId; // 0x104
	[SerializeField]
	private int m_GroupMaxId; // 0x108
	[Tooltip("Emission position mode.
Relative: The particles will be emitted from the scaled position.
Absolute: The particles will be emitted from the world position.")]
	[SerializeField]
	private UIParticle.PositionMode m_PositionMode; // 0x10C
	[SerializeField]
	[Obsolete]
	internal bool m_AutoScaling; // 0x110
	[SerializeField]
	[Tooltip("How to automatically adjust when the Canvas scale is changed by the screen size or reference resolution.
None: Do nothing.
Transform: Transform.lossyScale (=world scale) will be set to (1, 1, 1).
UIParticle: UIParticle.scale will be adjusted.")]
	private UIParticle.AutoScalingMode m_AutoScalingMode; // 0x114
	[SerializeField]
	[Tooltip("Use a custom view.
Use this if the particles are not displayed correctly due to min/max particle size.")]
	private bool m_UseCustomView; // 0x118
	[SerializeField]
	[Tooltip("Custom view size.
Change the bake view size.")]
	private float m_CustomViewSize; // 0x11C
	private readonly List<UIParticleRenderer> _renderers; // 0x120
	private Camera _bakeCamera; // 0x128
	private int _groupId; // 0x130
	private bool _isScaleStored; // 0x134
	private Vector3 _storedScale; // 0x138
	private DrivenRectTransformTracker _tracker; // 0x144
	[CompilerGenerated]
	private bool <isPaused>k__BackingField; // 0x145
	[CompilerGenerated]
	private Vector3 <parentScale>k__BackingField; // 0x148
	[CompilerGenerated]
	private Vector3 <canvasScale>k__BackingField; // 0x154

	// Properties
	public override bool raycastTarget { get; set; }
	public UIParticle.MeshSharing meshSharing { get; set; }
	public int groupId { get; set; }
	public int groupMaxId { get; set; }
	public UIParticle.PositionMode positionMode { get; set; }
	[Obsolete("The absoluteMode is now obsolete. Please use the autoScalingMode instead.", False)]
	public bool absoluteMode { get; set; }
	[Obsolete("The autoScaling is now obsolete. Please use the autoScalingMode instead.", False)]
	public bool autoScaling { get; set; }
	public UIParticle.AutoScalingMode autoScalingMode { get; set; }
	public bool useCustomView { get; set; }
	public float customViewSize { get; set; }
	internal bool useMeshSharing { get; }
	internal bool isPrimary { get; }
	internal bool canSimulate { get; }
	internal bool canRender { get; }
	public float scale { get; set; }
	public Vector3 scale3D { get; set; }
	public Vector3 scale3DForCalc { get; }
	public List<ParticleSystem> particles { get; }
	public bool isPaused { get; set; }
	public Vector3 parentScale { get; set; }
	public Vector3 canvasScale { get; set; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 24
	public override bool get_raycastTarget() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 25
	public override void set_raycastTarget(bool value) { }

	// RVA: 0x561290 Offset: 0x55F890 VA: 0x180561290
	public UIParticle.MeshSharing get_meshSharing() { }

	// RVA: 0x5615D0 Offset: 0x55FBD0 VA: 0x1805615D0
	public void set_meshSharing(UIParticle.MeshSharing value) { }

	// RVA: 0x561240 Offset: 0x55F840 VA: 0x180561240
	public int get_groupId() { }

	// RVA: 0x561540 Offset: 0x55FB40 VA: 0x180561540
	public void set_groupId(int value) { }

	// RVA: 0x561250 Offset: 0x55F850 VA: 0x180561250
	public int get_groupMaxId() { }

	// RVA: 0x561580 Offset: 0x55FB80 VA: 0x180561580
	public void set_groupMaxId(int value) { }

	// RVA: 0x5612D0 Offset: 0x55F8D0 VA: 0x1805612D0
	public UIParticle.PositionMode get_positionMode() { }

	// RVA: 0x561600 Offset: 0x55FC00 VA: 0x180561600
	public void set_positionMode(UIParticle.PositionMode value) { }

	// RVA: 0x561180 Offset: 0x55F780 VA: 0x180561180
	public bool get_absoluteMode() { }

	// RVA: 0x5613F0 Offset: 0x55F9F0 VA: 0x1805613F0
	public void set_absoluteMode(bool value) { }

	// RVA: 0x5611A0 Offset: 0x55F7A0 VA: 0x1805611A0
	public bool get_autoScaling() { }

	// RVA: 0x561480 Offset: 0x55FA80 VA: 0x180561480
	public void set_autoScaling(bool value) { }

	// RVA: 0x561190 Offset: 0x55F790 VA: 0x180561190
	public UIParticle.AutoScalingMode get_autoScalingMode() { }

	// RVA: 0x561410 Offset: 0x55FA10 VA: 0x180561410
	public void set_autoScalingMode(UIParticle.AutoScalingMode value) { }

	// RVA: 0x5613D0 Offset: 0x55F9D0 VA: 0x1805613D0
	public bool get_useCustomView() { }

	// RVA: 0x561650 Offset: 0x55FC50 VA: 0x180561650
	public void set_useCustomView(bool value) { }

	// RVA: 0x561230 Offset: 0x55F830 VA: 0x180561230
	public float get_customViewSize() { }

	// RVA: 0x561520 Offset: 0x55FB20 VA: 0x180561520
	public void set_customViewSize(float value) { }

	// RVA: 0x5613E0 Offset: 0x55F9E0 VA: 0x1805613E0
	internal bool get_useMeshSharing() { }

	// RVA: 0x561270 Offset: 0x55F870 VA: 0x180561270
	internal bool get_isPrimary() { }

	// RVA: 0x5611E0 Offset: 0x55F7E0 VA: 0x1805611E0
	internal bool get_canSimulate() { }

	// RVA: 0x5611B0 Offset: 0x55F7B0 VA: 0x1805611B0
	internal bool get_canRender() { }

	// RVA: 0x3A36E0 Offset: 0x3A1CE0 VA: 0x1803A36E0
	public float get_scale() { }

	// RVA: 0x561630 Offset: 0x55FC30 VA: 0x180561630
	public void set_scale(float value) { }

	// RVA: 0x5613B0 Offset: 0x55F9B0 VA: 0x1805613B0
	public Vector3 get_scale3D() { }

	// RVA: 0x561610 Offset: 0x55FC10 VA: 0x180561610
	public void set_scale3D(Vector3 value) { }

	// RVA: 0x5612E0 Offset: 0x55F8E0 VA: 0x1805612E0
	public Vector3 get_scale3DForCalc() { }

	// RVA: 0x5612C0 Offset: 0x55F8C0 VA: 0x1805612C0
	public List<ParticleSystem> get_particles() { }

	[CompilerGenerated]
	// RVA: 0x561260 Offset: 0x55F860 VA: 0x180561260
	public bool get_isPaused() { }

	[CompilerGenerated]
	// RVA: 0x5615C0 Offset: 0x55FBC0 VA: 0x1805615C0
	private void set_isPaused(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5612A0 Offset: 0x55F8A0 VA: 0x1805612A0
	public Vector3 get_parentScale() { }

	[CompilerGenerated]
	// RVA: 0x5615E0 Offset: 0x55FBE0 VA: 0x1805615E0
	private void set_parentScale(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x561210 Offset: 0x55F810 VA: 0x180561210
	public Vector3 get_canvasScale() { }

	[CompilerGenerated]
	// RVA: 0x561500 Offset: 0x55FB00 VA: 0x180561500
	private void set_canvasScale(Vector3 value) { }

	// RVA: 0x55F940 Offset: 0x55DF40 VA: 0x18055F940 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x55F6A0 Offset: 0x55DCA0 VA: 0x18055F6A0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 65
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x5609D0 Offset: 0x55EFD0 VA: 0x1805609D0 Slot: 66
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x55FC40 Offset: 0x55E240 VA: 0x18055FC40
	public void Play() { }

	// RVA: 0x55FB00 Offset: 0x55E100 VA: 0x18055FB00
	public void Pause() { }

	// RVA: 0x560300 Offset: 0x55E900 VA: 0x180560300
	public void Resume() { }

	// RVA: 0x560890 Offset: 0x55EE90 VA: 0x180560890
	public void Stop() { }

	// RVA: 0x560630 Offset: 0x55EC30 VA: 0x180560630
	public void StartEmission() { }

	// RVA: 0x560760 Offset: 0x55ED60 VA: 0x180560760
	public void StopEmission() { }

	// RVA: 0x55ECE0 Offset: 0x55D2E0 VA: 0x18055ECE0
	public void Clear() { }

	// RVA: 0x55F3C0 Offset: 0x55D9C0 VA: 0x18055F3C0
	public void GetMaterials(List<Material> result) { }

	// RVA: 0x560310 Offset: 0x55E910 VA: 0x180560310
	public void SetParticleSystemInstance(GameObject instance) { }

	// RVA: 0x560320 Offset: 0x55E920 VA: 0x180560320
	public void SetParticleSystemInstance(GameObject instance, bool destroyOldParticles) { }

	// RVA: 0x560570 Offset: 0x55EB70 VA: 0x180560570
	public void SetParticleSystemPrefab(GameObject prefab) { }

	// RVA: 0x560290 Offset: 0x55E890 VA: 0x180560290
	public void RefreshParticles() { }

	// RVA: 0x560040 Offset: 0x55E640 VA: 0x180560040
	private void RefreshParticles(GameObject root) { }

	// RVA: 0x55FD80 Offset: 0x55E380 VA: 0x18055FD80
	public void RefreshParticles(List<ParticleSystem> particleSystems) { }

	// RVA: 0x560CC0 Offset: 0x55F2C0 VA: 0x180560CC0
	internal void UpdateTransformScale() { }

	// RVA: 0x560B30 Offset: 0x55F130 VA: 0x180560B30
	internal void UpdateRenderers() { }

	// RVA: 0x5602C0 Offset: 0x55E8C0 VA: 0x1805602C0
	internal void ResetGroupId() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x560A20 Offset: 0x55F020 VA: 0x180560A20
	private void UpdateRendererMaterial() { }

	// RVA: 0x55F530 Offset: 0x55DB30 VA: 0x18055F530
	internal UIParticleRenderer GetRenderer(int index) { }

	// RVA: 0x55EE20 Offset: 0x55D420 VA: 0x18055EE20
	private Camera GetBakeCamera() { }

	// RVA: 0x561050 Offset: 0x55F650 VA: 0x180561050
	public void .ctor() { }
}

// Namespace: Coffee.UIExtensions
[ExecuteAlways]
public class UIParticleAttractor : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 13567
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private ParticleSystem m_ParticleSystem; // 0x20
	[SerializeField]
	private List<ParticleSystem> m_ParticleSystems; // 0x28
	[Range(0.1, 10)]
	[SerializeField]
	private float m_DestinationRadius; // 0x30
	[Range(0, 0.95)]
	[SerializeField]
	private float m_DelayRate; // 0x34
	[Range(0.001, 100)]
	[SerializeField]
	private float m_MaxSpeed; // 0x38
	[SerializeField]
	private UIParticleAttractor.Movement m_Movement; // 0x3C
	[SerializeField]
	private UIParticleAttractor.UpdateMode m_UpdateMode; // 0x40
	[SerializeField]
	private UnityEvent m_OnAttracted; // 0x48
	private List<UIParticle> _uiParticles; // 0x50

	// Properties
	public float destinationRadius { get; set; }
	public float delay { get; set; }
	public float maxSpeed { get; set; }
	public UIParticleAttractor.Movement movement { get; set; }
	public UIParticleAttractor.UpdateMode updateMode { get; set; }
	public UnityEvent onAttracted { get; set; }
	public IReadOnlyList<ParticleSystem> particleSystems { get; }

	// Methods

	// RVA: 0x420BC0 Offset: 0x41F1C0 VA: 0x180420BC0
	public float get_destinationRadius() { }

	// RVA: 0x559100 Offset: 0x557700 VA: 0x180559100
	public void set_destinationRadius(float value) { }

	// RVA: 0x43AEF0 Offset: 0x4394F0 VA: 0x18043AEF0
	public float get_delay() { }

	// RVA: 0x5590F0 Offset: 0x5576F0 VA: 0x1805590F0
	public void set_delay(float value) { }

	// RVA: 0x5590D0 Offset: 0x5576D0 VA: 0x1805590D0
	public float get_maxSpeed() { }

	// RVA: 0x559130 Offset: 0x557730 VA: 0x180559130
	public void set_maxSpeed(float value) { }

	// RVA: 0x5590E0 Offset: 0x5576E0 VA: 0x1805590E0
	public UIParticleAttractor.Movement get_movement() { }

	// RVA: 0x559140 Offset: 0x557740 VA: 0x180559140
	public void set_movement(UIParticleAttractor.Movement value) { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	public UIParticleAttractor.UpdateMode get_updateMode() { }

	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	public void set_updateMode(UIParticleAttractor.UpdateMode value) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public UnityEvent get_onAttracted() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	public void set_onAttracted(UnityEvent value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public IReadOnlyList<ParticleSystem> get_particleSystems() { }

	// RVA: 0x5579F0 Offset: 0x555FF0 VA: 0x1805579F0
	public void AddParticleSystem(ParticleSystem ps) { }

	// RVA: 0x558E40 Offset: 0x557440 VA: 0x180558E40
	public void RemoveParticleSystem(ParticleSystem ps) { }

	// RVA: 0x558220 Offset: 0x556820 VA: 0x180558220
	private void Awake() { }

	// RVA: 0x558D00 Offset: 0x557300 VA: 0x180558D00
	private void OnEnable() { }

	// RVA: 0x558C20 Offset: 0x557220 VA: 0x180558C20
	private void OnDisable() { }

	// RVA: 0x558BE0 Offset: 0x5571E0 VA: 0x180558BE0
	private void OnDestroy() { }

	// RVA: 0x557B00 Offset: 0x556100 VA: 0x180557B00
	internal void Attract() { }

	// RVA: 0x558750 Offset: 0x556D50 VA: 0x180558750
	private Vector3 GetDestinationPosition(UIParticle uiParticle, ParticleSystem particleSystem) { }

	// RVA: 0x558470 Offset: 0x556A70 VA: 0x180558470
	private Vector3 GetAttractedPosition(Vector3 current, Vector3 target, float duration, float time) { }

	// RVA: 0x558230 Offset: 0x556830 VA: 0x180558230
	private void CollectUIParticlesIfNeeded() { }

	// RVA: 0x558220 Offset: 0x556820 VA: 0x180558220 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x558F00 Offset: 0x557500 VA: 0x180558F00
	private void UpgradeIfNeeded() { }

	// RVA: 0x559000 Offset: 0x557600 VA: 0x180559000
	public void .ctor() { }
}

// Namespace: Coffee.UIExtensions
public class UIParticleProjectSettings : PreloadedProjectSettings<UIParticleProjectSettings> // TypeDefIndex: 13568
{
	// Fields
	[Header("Setting")]
	[SerializeField]
	internal bool m_EnableLinearToGamma; // 0x18
	[Header("Editor")]
	[Tooltip("Hide the automatically generated objects.
  - UIParticleRenderer
  - UIParticle BakingCamera")]
	[SerializeField]
	private bool m_HideGeneratedObjects; // 0x19

	// Properties
	public static bool enableLinearToGamma { get; set; }
	public static HideFlags globalHideFlags { get; }

	// Methods

	// RVA: 0x559190 Offset: 0x557790 VA: 0x180559190
	public static bool get_enableLinearToGamma() { }

	// RVA: 0x559220 Offset: 0x557820 VA: 0x180559220
	public static void set_enableLinearToGamma(bool value) { }

	// RVA: 0x5591D0 Offset: 0x5577D0 VA: 0x1805591D0
	public static HideFlags get_globalHideFlags() { }

	// RVA: 0x559150 Offset: 0x557750 VA: 0x180559150
	public void .ctor() { }
}

// Namespace: Coffee.UIExtensions
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("")]
internal class UIParticleRenderer : MaskableGraphic // TypeDefIndex: 13570
{
	// Fields
	private static readonly CombineInstance[] s_CombineInstances; // 0x0
	private static readonly List<Material> s_Materials; // 0x8
	private static MaterialPropertyBlock s_Mpb; // 0x10
	private static readonly Vector3[] s_Corners; // 0x18
	private bool _delay; // 0xE0
	private int _index; // 0xE4
	private bool _isPrevStored; // 0xE8
	private bool _isTrail; // 0xE9
	private Bounds _lastBounds; // 0xEC
	private Material _materialForRendering; // 0x108
	private Material _modifiedMaterial; // 0x110
	private UIParticle _parent; // 0x118
	private ParticleSystem _particleSystem; // 0x120
	private float _prevCanvasScale; // 0x128
	private Vector3 _prevPsPos; // 0x12C
	private Vector3 _prevScale; // 0x138
	private Vector2Int _prevScreenSize; // 0x144
	private bool _preWarm; // 0x14C
	private ParticleSystemRenderer _renderer; // 0x150

	// Properties
	public override Texture mainTexture { get; }
	public override bool raycastTarget { get; }
	private Rect rootCanvasRect { get; }
	public override Material materialForRendering { get; }

	// Methods

	// RVA: 0x55D540 Offset: 0x55BB40 VA: 0x18055D540 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 24
	public override bool get_raycastTarget() { }

	// RVA: 0x55D7B0 Offset: 0x55BDB0 VA: 0x18055D7B0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x55D720 Offset: 0x55BD20 VA: 0x18055D720 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x55A5D0 Offset: 0x558BD0 VA: 0x18055A5D0
	public void Reset(int index = -1) { }

	// RVA: 0x55A420 Offset: 0x558A20 VA: 0x18055A420 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x55A390 Offset: 0x558990 VA: 0x18055A390 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x559270 Offset: 0x557870 VA: 0x180559270
	public static UIParticleRenderer AddRenderer(UIParticle parent, int index) { }

	// RVA: 0x559850 Offset: 0x557E50 VA: 0x180559850 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x55AE80 Offset: 0x559480 VA: 0x18055AE80
	public void Set(UIParticle parent, ParticleSystem ps, bool isTrail) { }

	// RVA: 0x55BAB0 Offset: 0x55A0B0 VA: 0x18055BAB0
	public void UpdateMesh(Camera bakeCamera) { }

	// RVA: 0x55AE40 Offset: 0x559440 VA: 0x18055AE40 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x559570 Offset: 0x557B70 VA: 0x180559570 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x55A1B0 Offset: 0x5587B0 VA: 0x18055A1B0
	private Vector3 GetWorldScale() { }

	// RVA: 0x559CC0 Offset: 0x5582C0 VA: 0x180559CC0
	private Matrix4x4 GetWorldMatrix(Vector3 psPos, Vector3 scale) { }

	// RVA: 0x55A780 Offset: 0x558D80 VA: 0x18055A780
	private void ResolveResolutionChange(Vector3 psPos, Vector3 scale) { }

	// RVA: 0x55B280 Offset: 0x559880 VA: 0x18055B280
	private void Simulate(Vector3 scale, bool paused) { }

	// RVA: 0x55B7D0 Offset: 0x559DD0 VA: 0x18055B7D0
	private void UpdateMaterialProperties() { }

	// RVA: 0x55D530 Offset: 0x55BB30 VA: 0x18055D530
	public void .ctor() { }

	// RVA: 0x55D410 Offset: 0x55BA10 VA: 0x18055D410
	private static void .cctor() { }
}

// Namespace: Coffee.UIExtensions
internal static class UIParticleUpdater // TypeDefIndex: 13571
{
	// Fields
	private static readonly List<UIParticle> s_ActiveParticles; // 0x0
	private static readonly List<UIParticleAttractor> s_ActiveAttractors; // 0x8
	private static readonly HashSet<int> s_UpdatedGroupIds; // 0x10
	private static int s_FrameCount; // 0x18

	// Properties
	public static int uiParticleCount { get; }

	// Methods

	// RVA: 0x55EC70 Offset: 0x55D270 VA: 0x18055EC70
	public static int get_uiParticleCount() { }

	// RVA: 0x55E910 Offset: 0x55CF10 VA: 0x18055E910
	public static void Register(UIParticle particle) { }

	// RVA: 0x55E9C0 Offset: 0x55CFC0 VA: 0x18055E9C0
	public static void Unregister(UIParticle particle) { }

	// RVA: 0x55E800 Offset: 0x55CE00 VA: 0x18055E800
	public static void Register(UIParticleAttractor attractor) { }

	// RVA: 0x55EA70 Offset: 0x55D070 VA: 0x18055EA70
	public static void Unregister(UIParticleAttractor attractor) { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x55E2C0 Offset: 0x55C8C0 VA: 0x18055E2C0
	private static void InitializeOnLoad() { }

	// RVA: 0x55E3A0 Offset: 0x55C9A0 VA: 0x18055E3A0
	private static void Refresh() { }

	// RVA: 0x55DFF0 Offset: 0x55C5F0 VA: 0x18055DFF0
	public static void GetGroupedRenderers(int groupId, int index, List<UIParticleRenderer> results) { }

	// RVA: 0x55E150 Offset: 0x55C750 VA: 0x18055E150
	internal static UIParticle GetPrimary(int groupId) { }

	// RVA: 0x55EB20 Offset: 0x55D120 VA: 0x18055EB20
	private static void .cctor() { }
}

