// Namespace: Assets.Scripts.Camera
public class CameraShakerController : MonoBehaviour // TypeDefIndex: 5700
{
	// Fields
	public Shaker shaker; // 0x20
	public ShakePreset damageShake; // 0x28
	public ShakePreset objectImpactShake; // 0x30
	public ShakePreset grindShake; // 0x38
	public ShakePreset pylonSpawnShake; // 0x40
	private float damageShakeCooldown; // 0x48
	private float damageNextShakeReadyTime; // 0x4C
	private ShakeInstance grindShakeInstance; // 0x50

	// Methods

	// RVA: 0x44B680 Offset: 0x449C80 VA: 0x18044B680
	private void Awake() { }

	// RVA: 0x44BD30 Offset: 0x44A330 VA: 0x18044BD30
	private void OnDestroy() { }

	// RVA: 0x44C420 Offset: 0x44AA20 VA: 0x18044C420
	private void Start() { }

	// RVA: 0x44C370 Offset: 0x44A970 VA: 0x18044C370
	private void OnSettingUpdated(string setting, object oldValue, object newValue) { }

	// RVA: 0x44BBE0 Offset: 0x44A1E0 VA: 0x18044BBE0
	private void OnDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage) { }

	// RVA: 0x44C300 Offset: 0x44A900 VA: 0x18044C300
	private void OnObjectImpact(float shakeMultiplier) { }

	// RVA: 0x44C290 Offset: 0x44A890 VA: 0x18044C290
	private void OnGrindToggle(bool isGrinding) { }

	// RVA: 0x44C340 Offset: 0x44A940 VA: 0x18044C340
	private void OnPylonsStarted() { }

	// RVA: 0x44C550 Offset: 0x44AB50 VA: 0x18044C550
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Camera
public class MinimapArrow : MonoBehaviour // TypeDefIndex: 5701
{
	// Fields
	public Transform target; // 0x20
	public MeshRenderer arrowRenderer; // 0x28

	// Methods

	// RVA: 0x452A10 Offset: 0x451010 VA: 0x180452A10
	public void Set(Transform target, Color color) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Camera
public class MinimapCamera : MonoBehaviour // TypeDefIndex: 5702
{
	// Fields
	public Transform playerIcon; // 0x20
	public Transform arrowPrefab; // 0x28
	public bool staticOrientation; // 0x30
	private Vector3 staticRotation; // 0x34
	public Camera minimapCamera; // 0x40
	private bool bossSpotted; // 0x48
	private Transform bossSpawner; // 0x50
	public static Action<float> A_RotationUpdated; // 0x0
	private Quaternion lastRotation; // 0x58
	private Color bossColor; // 0x68
	private Color portalColor; // 0x78
	private Dictionary<Transform, MinimapArrow> arrowDict; // 0x88

	// Methods

	// RVA: 0x453530 Offset: 0x451B30 VA: 0x180453530
	private void Start() { }

	// RVA: 0x452F30 Offset: 0x451530 VA: 0x180452F30
	private void OnDestroy() { }

	// RVA: 0x4533E0 Offset: 0x4519E0 VA: 0x1804533E0
	private void OnEnemySpawn(Enemy enemy) { }

	// RVA: 0x453350 Offset: 0x451950 VA: 0x180453350
	private void OnEnemyDied(Enemy enemy) { }

	// RVA: 0x453B70 Offset: 0x452170 VA: 0x180453B70
	private void TryFindBossSpawner() { }

	// RVA: 0x4546C0 Offset: 0x452CC0 VA: 0x1804546C0
	private void Update() { }

	// RVA: 0x453A90 Offset: 0x452090 VA: 0x180453A90
	private void StaticOrientation() { }

	// RVA: 0x452CB0 Offset: 0x4512B0 VA: 0x180452CB0
	private void DynamicOrientation() { }

	// RVA: 0x453EF0 Offset: 0x4524F0 VA: 0x180453EF0
	private void UpdateArrows() { }

	// RVA: 0x453C80 Offset: 0x452280 VA: 0x180453C80
	private void TrySpotBossSpawner() { }

	// RVA: 0x452AE0 Offset: 0x4510E0 VA: 0x180452AE0
	private void AddArrow(Transform target, Color color) { }

	// RVA: 0x453430 Offset: 0x451A30 VA: 0x180453430
	private void RemoveArrow(Transform transform) { }

	// RVA: 0x452EF0 Offset: 0x4514F0 VA: 0x180452EF0
	private void OnBossSpawnerInteract() { }

	// RVA: 0x452EA0 Offset: 0x4514A0 VA: 0x180452EA0
	private void OnBossSpawnerCompleted(bool openedPortal) { }

	// RVA: 0x454C70 Offset: 0x453270 VA: 0x180454C70
	public void .ctor() { }
}

