// Namespace: Assets.Scripts.Objects.Particles___Effects.ParticleOpacity
public class ParticleOpacity : MonoBehaviour // TypeDefIndex: 5440
{
	// Fields
	public ParticleSystem[] particleSystems; // 0x20
	public float[] defaultOpacitiesParticles; // 0x28
	public TrailRenderer[] trails; // 0x30
	public float[] defaultOpacitiesTrailsStart; // 0x38
	public float[] defaultOpacitiesTrailsEnd; // 0x40
	public LineRenderer[] lines; // 0x48
	public float[] defaultOpacitiesLinesStart; // 0x50
	public float[] defaultOpacitiesLinesEnd; // 0x58
	public MeshRenderer[] meshRenderer; // 0x60
	public EffectPlayer effectPlayer; // 0x68
	public bool subscribeToOpacityChange; // 0x70
	private bool queueRefreshForce; // 0x71
	private bool queueRefresh; // 0x72
	private float readyAtTime; // 0x74
	private float cooldown; // 0x78
	private float lastSetOpacity; // 0x7C
	private bool isHidden; // 0x80
	public ParticleOpacity.EOpacityCurve opacityCurve; // 0x84
	public AnimationCurve customCurve; // 0x88
	[Header("Projectile Auto Opacity")]
	public bool useProjectileAutoOpacity; // 0x90
	public ProjectileBase projectileBase; // 0x98
	public ConstantAttack constantAttack; // 0xA0
	public float autoMinSize; // 0xA8
	public float autoMaxSize; // 0xAC
	public float minOpacity; // 0xB0
	public bool useScaleWithoutProjectileData; // 0xB4
	private string particleOpacitySettingName; // 0xB8

	// Methods

	// RVA: 0x3FDF10 Offset: 0x3FC510 VA: 0x1803FDF10
	private void Awake() { }

	// RVA: 0x3FE350 Offset: 0x3FC950 VA: 0x1803FE350
	private void OnDestroy() { }

	// RVA: 0x3FE5C0 Offset: 0x3FCBC0 VA: 0x1803FE5C0
	private void OnEnable() { }

	// RVA: 0x3FF520 Offset: 0x3FDB20 VA: 0x1803FF520
	private void Refresh() { }

	// RVA: 0x3FEAF0 Offset: 0x3FD0F0 VA: 0x1803FEAF0
	private void Refresh(bool force = False) { }

	// RVA: 0x3FE180 Offset: 0x3FC780 VA: 0x1803FE180
	private float GetAutoOpacity() { }

	// RVA: 0x3FE600 Offset: 0x3FCC00 VA: 0x1803FE600
	private void OnValidate() { }

	// RVA: 0x3FE5D0 Offset: 0x3FCBD0 VA: 0x1803FE5D0
	private void OnSettingUpdated(string name, object oldValue, object newValue) { }

	// RVA: 0x3FF530 Offset: 0x3FDB30 VA: 0x1803FF530
	private void Update() { }

	// RVA: 0x3FF630 Offset: 0x3FDC30 VA: 0x1803FF630
	public void .ctor() { }
}

