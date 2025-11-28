// Namespace: Assets.Scripts.Actors.Player
public class MyPlayer : MonoBehaviour // TypeDefIndex: 5713
{
	// Fields
	public PlayerRenderer playerRenderer; // 0x20
	public PlayerMovement playerMovement; // 0x28
	public ParticleSystem levelupParticles; // 0x30
	public AudioSource levelupSfx; // 0x38
	public ECharacter character; // 0x40
	public PlayerInput playerInput; // 0x48
	public AuraAttacks playerConstantAttacks; // 0x50
	public PlayerSfxs playerSfxs; // 0x58
	public PlayerEffects playerEffects; // 0x60
	public GameObject fogOfWar; // 0x68
	public GameObject teleportEffect; // 0x70
	public Camera minimapCamera; // 0x78
	private bool inited; // 0x80
	[CompilerGenerated]
	private float <baseMovementSpeed>k__BackingField; // 0x84
	public PlayerInventory inventory; // 0x88
	public static Action<PlayerInventory> A_PlayerInventoryInitialized; // 0x0
	public static MyPlayer Instance; // 0x8
	public static Action A_PrePlayerSpawn; // 0x10
	public float height; // 0x90
	public Transform feet; // 0x98
	public Transform head; // 0xA0
	public Vector3 spawnDir; // 0xA8
	public float width; // 0xB4
	private bool started; // 0xB8
	private float nextChangeTime; // 0xBC
	private bool isInvincible; // 0xC0
	private float damageCooldownOverAtTime; // 0xC4
	private float lastCalledTime; // 0xC8
	private Dictionary<GameObject, float> enemyCooldowns; // 0xD0
	private float enemyAttackCooldown; // 0xD8
	private int enemyLayer; // 0xDC
	public static Action A_Collided; // 0x18
	public static Action A_CollidedEnemy; // 0x20
	private float movingDirectionBias; // 0xE0
	private float shootingDirectionBias; // 0xE4
	private float biasMoveSpeed; // 0xE8
	private Vector3 averageMovingDirection; // 0xEC
	private Vector3 averageMovingDirectionShooting; // 0xF8
	private float maxVectorSize; // 0x104
	private float maxVectorSizeShooting; // 0x108
	public Transform arrow; // 0x110
	public Transform shootingArrow; // 0x118
	public bool isTeleporting; // 0x120
	private static float defaultBaseDamage; // 0x28
	private float baseDamage; // 0x124

	// Properties
	public float baseMovementSpeed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x471F10 Offset: 0x470510 VA: 0x180471F10
	public float get_baseMovementSpeed() { }

	[CompilerGenerated]
	// RVA: 0x471F20 Offset: 0x470520 VA: 0x180471F20
	private void set_baseMovementSpeed(float value) { }

	// RVA: 0x46F2C0 Offset: 0x46D8C0 VA: 0x18046F2C0
	public void Awake() { }

	// RVA: 0x471450 Offset: 0x46FA50 VA: 0x180471450
	public void TryInit() { }

	// RVA: 0x471290 Offset: 0x46F890 VA: 0x180471290
	private void Start() { }

	// RVA: 0x470C90 Offset: 0x46F290 VA: 0x180470C90
	public void Spawn(Vector3 position, Vector3 direction, bool useHeightOffset = False) { }

	// RVA: 0x471100 Offset: 0x46F700 VA: 0x180471100
	public void StartPlayer(ECharacter character, Vector3 direction) { }

	// RVA: 0x470800 Offset: 0x46EE00 VA: 0x180470800
	public void RefreshSize(CharacterData characterData, Vector3 direction, float sizeMultiplier = 1) { }

	// RVA: 0x46F420 Offset: 0x46DA20 VA: 0x18046F420
	private void FixedUpdate() { }

	// RVA: 0x471DD0 Offset: 0x4703D0 VA: 0x180471DD0
	private void Update() { }

	// RVA: 0x46F750 Offset: 0x46DD50 VA: 0x18046F750
	private void LateUpdate() { }

	// RVA: 0x46FE60 Offset: 0x46E460 VA: 0x18046FE60
	private void OnDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage) { }

	// RVA: 0x46F370 Offset: 0x46D970 VA: 0x18046F370
	private void DamageCooldownOver() { }

	// RVA: 0x470460 Offset: 0x46EA60 VA: 0x180470460
	public void OnLevelUp() { }

	// RVA: 0x471320 Offset: 0x46F920 VA: 0x180471320
	private void StopLevelupParticles() { }

	// RVA: 0x46F770 Offset: 0x46DD70 VA: 0x18046F770
	private void OnCollisionStay(Collision other) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void OnGUI() { }

	// RVA: 0x46F360 Offset: 0x46D960 VA: 0x18046F360
	private bool CanTakeDamage() { }

	// RVA: 0x471980 Offset: 0x46FF80 VA: 0x180471980
	public void UpdateSpawnDirectionBias() { }

	// RVA: 0x46F690 Offset: 0x46DC90 VA: 0x18046F690
	public float GetSpawnDirectionBias() { }

	// RVA: 0x46F570 Offset: 0x46DB70 VA: 0x18046F570
	public Vector3 GetAverageMovingDirection() { }

	// RVA: 0x46F550 Offset: 0x46DB50 VA: 0x18046F550
	public Vector3 GetAverageMovingDirectionTarget() { }

	// RVA: 0x46F720 Offset: 0x46DD20 VA: 0x18046F720
	public bool IsDead() { }

	// RVA: 0x470600 Offset: 0x46EC00 VA: 0x180470600
	private void OnPlayerDied() { }

	// RVA: 0x4713E0 Offset: 0x46F9E0 VA: 0x1804713E0
	public void TeleportPlayer() { }

	// RVA: 0x471370 Offset: 0x46F970 VA: 0x180471370
	private void TeleportEnd() { }

	// RVA: 0x4707D0 Offset: 0x46EDD0 VA: 0x1804707D0
	public void PauseInventory(bool b) { }

	// RVA: 0x46F5A0 Offset: 0x46DBA0 VA: 0x18046F5A0
	public Vector3 GetFeetPosition() { }

	// RVA: 0x46F2D0 Offset: 0x46D8D0 VA: 0x18046F2D0
	private void CalculateBaseDamage() { }

	// RVA: 0x46F590 Offset: 0x46DB90 VA: 0x18046F590
	public float GetBaseDamage() { }

	// RVA: 0x46FFE0 Offset: 0x46E5E0 VA: 0x18046FFE0
	private void OnDestroy() { }

	// RVA: 0x471E30 Offset: 0x470430 VA: 0x180471E30
	public void .ctor() { }

	// RVA: 0x471DF0 Offset: 0x4703F0 VA: 0x180471DF0
	private static void .cctor() { }
}

