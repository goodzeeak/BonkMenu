// Namespace: RetroArsenal
public class RetroEffectCycler : MonoBehaviour // TypeDefIndex: 5722
{
	// Fields
	public List<GameObject> listOfEffects; // 0x20
	private int effectIndex; // 0x28
	[Header("Spawn Settings")]
	[SerializeField]
	[Space(10)]
	public float loopLength; // 0x2C
	public float startDelay; // 0x30
	public bool disableLights; // 0x34
	public bool disableSound; // 0x35
	public bool autoMode; // 0x36
	[Header("UI Elements")]
	public Text effectNameText; // 0x38
	private GameObject currentEffect; // 0x40

	// Methods

	// RVA: 0x473180 Offset: 0x471780 VA: 0x180473180
	private void Start() { }

	// RVA: 0x472FF0 Offset: 0x4715F0 VA: 0x180472FF0
	public void PlayEffect() { }

	// RVA: 0x472F80 Offset: 0x471580 VA: 0x180472F80
	public void NextEffect() { }

	// RVA: 0x473070 Offset: 0x471670 VA: 0x180473070
	public void PreviousEffect() { }

	// RVA: 0x473210 Offset: 0x471810 VA: 0x180473210
	public void ToggleAutoMode() { }

	// RVA: 0x4730E0 Offset: 0x4716E0 VA: 0x1804730E0
	private void RestartEffect() { }

	[IteratorStateMachine(typeof(RetroEffectCycler.<EffectLoop>d__15))]
	// RVA: 0x472F10 Offset: 0x471510 VA: 0x180472F10
	private IEnumerator EffectLoop() { }

	// RVA: 0x473230 Offset: 0x471830 VA: 0x180473230
	private void UpdateEffectUI() { }

	// RVA: 0x473380 Offset: 0x471980 VA: 0x180473380
	private void Update() { }

	// RVA: 0x473490 Offset: 0x471A90 VA: 0x180473490
	public void .ctor() { }
}

// Namespace: RetroArsenal
public enum BeamType // TypeDefIndex: 5723
{
	// Fields
	public int value__; // 0x0
	public const BeamType Type1 = 0;
	public const BeamType Type2 = 1;
	public const BeamType Type3 = 2;
}

// Namespace: RetroArsenal
public class RetroFireBeam : MonoBehaviour // TypeDefIndex: 5724
{
	// Fields
	[Header("Prefabs")]
	public GameObject[] beamLineRendererPrefab; // 0x20
	public GameObject[] beamStartPrefab; // 0x28
	public GameObject[] beamEndPrefab; // 0x30
	private BeamType currentBeam; // 0x38
	private GameObject beamStart; // 0x40
	private GameObject beamEnd; // 0x48
	private GameObject beam; // 0x50
	private LineRenderer line; // 0x58
	private Transform beamTransform; // 0x60
	private float textureScrollOffset; // 0x68
	[Header("Adjustable Variables")]
	public float beamEndOffset; // 0x6C
	public float textureScrollSpeed; // 0x70
	public float textureLengthScale; // 0x74
	[Header("Put Sliders here (Optional)")]
	public Slider endOffsetSlider; // 0x78
	public Slider scrollSpeedSlider; // 0x80
	[Header("UI Text object to show beam name")]
	public Text textBeamName; // 0x88
	private bool isFiringBeam; // 0x90

	// Methods

	// RVA: 0x473C60 Offset: 0x472260 VA: 0x180473C60
	private void Start() { }

	// RVA: 0x4734B0 Offset: 0x471AB0 VA: 0x1804734B0
	private void CreateBeamObjects() { }

	// RVA: 0x473EF0 Offset: 0x4724F0 VA: 0x180473EF0
	private void Update() { }

	// RVA: 0x473DF0 Offset: 0x4723F0 VA: 0x180473DF0
	private void UpdateBeam() { }

	// RVA: 0x473790 Offset: 0x471D90 VA: 0x180473790
	private void ShootBeamInDir(Vector3 start, Vector3 dir) { }

	// RVA: 0x474230 Offset: 0x472830 VA: 0x180474230
	public void .ctor() { }
}

// Namespace: RetroArsenal
public class RetroFireProjectile : MonoBehaviour // TypeDefIndex: 5726
{
	// Fields
	public GameObject[] projectiles; // 0x20
	[Header("GUI Links")]
	public Text missileNameText; // 0x28
	public Toggle fullAutoButton; // 0x30
	public Slider speedSlider; // 0x38
	public bool cleanUpMissileName; // 0x40
	[Header("Projectile Settings")]
	public Transform spawnPosition; // 0x48
	[HideInInspector]
	public int currentProjectile; // 0x50
	public float speed; // 0x54
	public float spawnOffset; // 0x58
	[Header("Firing Settings")]
	public float fireRate; // 0x5C
	public bool isFullAuto; // 0x60
	[Header("Gun Settings")]
	public GameObject gunPrefab; // 0x68
	public float gunOffset; // 0x70
	private bool canShoot; // 0x74
	private GameObject instantiatedGun; // 0x78

	// Methods

	// RVA: 0x474910 Offset: 0x472F10 VA: 0x180474910
	private void Start() { }

	// RVA: 0x4752C0 Offset: 0x4738C0 VA: 0x1804752C0
	private void Update() { }

	[IteratorStateMachine(typeof(RetroFireProjectile.<Shoot>d__17))]
	// RVA: 0x4748A0 Offset: 0x472EA0 VA: 0x1804748A0
	private IEnumerator Shoot() { }

	// RVA: 0x474450 Offset: 0x472A50 VA: 0x180474450
	private void ShootProjectile() { }

	// RVA: 0x474E10 Offset: 0x473410 VA: 0x180474E10
	private void UpdateGunPositionAndRotation() { }

	// RVA: 0x475600 Offset: 0x473C00 VA: 0x180475600
	public void nextEffect() { }

	// RVA: 0x475640 Offset: 0x473C40 VA: 0x180475640
	public void previousEffect() { }

	// RVA: 0x474C40 Offset: 0x473240 VA: 0x180474C40
	private void UpdateDisplayName() { }

	// RVA: 0x474250 Offset: 0x472850 VA: 0x180474250
	private string CleanUpMissileName(string name) { }

	// RVA: 0x474440 Offset: 0x472A40 VA: 0x180474440
	private void OnSpeedSliderChanged(float value) { }

	// RVA: 0x4755D0 Offset: 0x473BD0 VA: 0x1804755D0
	public void .ctor() { }
}

// Namespace: RetroArsenal
public class RetroLoopScript : MonoBehaviour // TypeDefIndex: 5728
{
	// Fields
	public GameObject chosenEffect; // 0x20
	public float loopTimeLimit; // 0x28
	[Header("Spawn options")]
	public bool disableLights; // 0x2C
	public bool disableSound; // 0x2D
	public float spawnScale; // 0x30

	// Methods

	// RVA: 0x475E90 Offset: 0x474490 VA: 0x180475E90
	private void Start() { }

	// RVA: 0x475E90 Offset: 0x474490 VA: 0x180475E90
	public void PlayEffect() { }

	[IteratorStateMachine(typeof(RetroLoopScript.<EffectLoop>d__7))]
	// RVA: 0x475E20 Offset: 0x474420 VA: 0x180475E20
	private IEnumerator EffectLoop() { }

	// RVA: 0x475ED0 Offset: 0x4744D0 VA: 0x180475ED0
	public void .ctor() { }
}

// Namespace: RetroArsenal
public class RetroOrbit : MonoBehaviour // TypeDefIndex: 5729
{
	// Fields
	public Transform target; // 0x20
	public Vector3 cameraOffset; // 0x28
	public float defaultDistance; // 0x34
	private float _currentDistance; // 0x38
	public float xSpeed; // 0x3C
	public float ySpeed; // 0x40
	public float yMinLimit; // 0x44
	public float yMaxLimit; // 0x48
	public float distanceMin; // 0x4C
	public float distanceMax; // 0x50
	public float zoomLerpSpeed; // 0x54
	public float smoothingFactor; // 0x58
	public float collisionOffset; // 0x5C
	private float rotationYAxis; // 0x60
	private float rotationXAxis; // 0x64
	private float velocityX; // 0x68
	private float velocityY; // 0x6C
	private Vector3 originalTargetPosition; // 0x70

	// Methods

	// RVA: 0x4764F0 Offset: 0x474AF0 VA: 0x1804764F0
	private void Start() { }

	// RVA: 0x475EF0 Offset: 0x4744F0 VA: 0x180475EF0
	private void LateUpdate() { }

	// RVA: 0x476600 Offset: 0x474C00 VA: 0x180476600
	public void .ctor() { }
}

// Namespace: RetroArsenal
public class RetroProjectileScript : MonoBehaviour // TypeDefIndex: 5730
{
	// Fields
	public GameObject impactParticle; // 0x20
	public GameObject projectileParticle; // 0x28
	public GameObject muzzleParticle; // 0x30
	public GameObject[] trailParticles; // 0x38
	[Header("Adjust if not using Sphere Collider")]
	public float colliderRadius; // 0x40
	[Range(0, 1)]
	public float collideOffset; // 0x44
	private Rigidbody rb; // 0x48
	private Transform myTransform; // 0x50
	private SphereCollider sphereCollider; // 0x58
	private float destroyTimer; // 0x60
	private bool destroyed; // 0x64

	// Methods

	// RVA: 0x477460 Offset: 0x475A60 VA: 0x180477460
	private void Start() { }

	// RVA: 0x4769F0 Offset: 0x474FF0 VA: 0x1804769F0
	private void FixedUpdate() { }

	// RVA: 0x476750 Offset: 0x474D50 VA: 0x180476750
	private void DestroyMissile() { }

	// RVA: 0x4771E0 Offset: 0x4757E0 VA: 0x1804771E0
	private void RotateTowardsDirection() { }

	// RVA: 0x4776B0 Offset: 0x475CB0 VA: 0x1804776B0
	public void .ctor() { }
}

// Namespace: RetroArsenal
public class RetroRotateTowardsCamera : MonoBehaviour // TypeDefIndex: 5731
{
	// Fields
	private Camera mainCamera; // 0x20

	// Methods

	// RVA: 0x4776D0 Offset: 0x475CD0 VA: 0x1804776D0
	private void Start() { }

	// RVA: 0x477760 Offset: 0x475D60 VA: 0x180477760
	private void Update() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: RetroArsenal
public class RetroSceneSelect : MonoBehaviour // TypeDefIndex: 5732
{
	// Fields
	private bool GUIHide01; // 0x20
	private bool GUIHide02; // 0x21
	private bool GUIHide03; // 0x22

	// Methods

	// RVA: 0x477960 Offset: 0x475F60 VA: 0x180477960
	public void CBLoadSceneBeams() { }

	// RVA: 0x4779C0 Offset: 0x475FC0 VA: 0x1804779C0
	public void CBLoadSceneEmojis() { }

	// RVA: 0x477A20 Offset: 0x476020 VA: 0x180477A20
	public void CBLoadSceneExplosions() { }

	// RVA: 0x477A80 Offset: 0x476080 VA: 0x180477A80
	public void CBLoadSceneLibrary() { }

	// RVA: 0x477AE0 Offset: 0x4760E0 VA: 0x180477AE0
	public void CBLoadSceneLoot() { }

	// RVA: 0x477B40 Offset: 0x476140 VA: 0x180477B40
	public void CBLoadSceneMissiles() { }

	// RVA: 0x477BA0 Offset: 0x4761A0 VA: 0x180477BA0
	public void CBLoadScenePowerups() { }

	// RVA: 0x477D00 Offset: 0x476300 VA: 0x180477D00
	private void Update() { }

	// RVA: 0x477C00 Offset: 0x476200 VA: 0x180477C00
	private void CheckKeyCode(KeyCode keyCode, ref bool guiHide, string canvasName) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: RetroArsenal
[Serializable]
public class TargetEffects // TypeDefIndex: 5733
{
	// Fields
	public GameObject hitParticle; // 0x10
	public GameObject respawnParticle; // 0x18
	public List<GameObject> deathParticles; // 0x20
	public AudioClip destroySound; // 0x28
	public AudioClip respawnSound; // 0x30

	// Methods

	// RVA: 0x478E20 Offset: 0x477420 VA: 0x180478E20
	public void .ctor() { }
}

// Namespace: RetroArsenal
public class RetroTarget : MonoBehaviour // TypeDefIndex: 5736
{
	// Fields
	public TargetEffects effects; // 0x20
	[Header("General Settings")]
	public int hitsToDestroy; // 0x28
	public float respawnTime; // 0x2C
	[Header("Squash & Stretch")]
	public bool enableSquashAndStretch; // 0x30
	public float duration; // 0x34
	public Vector3 squashScale; // 0x38
	public Vector3 stretchScale; // 0x44
	private Renderer targetRenderer; // 0x50
	private Collider targetCollider; // 0x58
	private AudioSource audioSource; // 0x60
	private int currentHits; // 0x68
	private Vector3 originalScale; // 0x6C

	// Methods

	// RVA: 0x478510 Offset: 0x476B10 VA: 0x180478510
	private void Start() { }

	// RVA: 0x4782A0 Offset: 0x4768A0 VA: 0x1804782A0
	private void SpawnTarget() { }

	[IteratorStateMachine(typeof(RetroTarget.<Respawn>d__14))]
	// RVA: 0x478230 Offset: 0x476830 VA: 0x180478230
	private IEnumerator Respawn() { }

	// RVA: 0x478060 Offset: 0x476660 VA: 0x180478060
	public void OnHit() { }

	[IteratorStateMachine(typeof(RetroTarget.<SquashAndStretch>d__16))]
	// RVA: 0x4784A0 Offset: 0x476AA0 VA: 0x1804784A0
	private IEnumerator SquashAndStretch() { }

	// RVA: 0x477DB0 Offset: 0x4763B0 VA: 0x180477DB0
	private void DestroyTarget() { }

	// RVA: 0x4785F0 Offset: 0x476BF0 VA: 0x1804785F0
	public void .ctor() { }
}

// Namespace: RetroArsenal
public class RetroBeamStatic : MonoBehaviour // TypeDefIndex: 5737
{
	// Fields
	[Header("Prefabs")]
	public GameObject beamLineRendererPrefab; // 0x20
	public GameObject beamStartPrefab; // 0x28
	public GameObject beamEndPrefab; // 0x30
	private GameObject beamStart; // 0x38
	private GameObject beamEnd; // 0x40
	private GameObject beam; // 0x48
	private LineRenderer line; // 0x50
	[Header("Beam Options")]
	public bool beamCollides; // 0x58
	public float beamLength; // 0x5C
	public float beamEndOffset; // 0x60
	public float textureScrollSpeed; // 0x64
	public float textureLengthScale; // 0x68
	[Header("Width Pulse Options")]
	public float widthMultiplier; // 0x6C
	private float customWidth; // 0x70
	private float originalWidth; // 0x74
	private float lerpValue; // 0x78
	public float pulseSpeed; // 0x7C
	private bool pulseExpanding; // 0x80

	// Methods

	// RVA: 0x472EA0 Offset: 0x4714A0 VA: 0x180472EA0
	private void Start() { }

	// RVA: 0x4722C0 Offset: 0x4708C0 VA: 0x1804722C0
	private void FixedUpdate() { }

	// RVA: 0x472B40 Offset: 0x471140 VA: 0x180472B40
	public void SpawnBeam() { }

	// RVA: 0x472EE0 Offset: 0x4714E0 VA: 0x180472EE0
	public void .ctor() { }
}

// Namespace: RetroArsenal
public class RetroPitchRandomizer : MonoBehaviour // TypeDefIndex: 5738
{
	// Fields
	public float randomPercent; // 0x20

	// Methods

	// RVA: 0x476680 Offset: 0x474C80 VA: 0x180476680
	private void Start() { }

	// RVA: 0x476740 Offset: 0x474D40 VA: 0x180476740
	public void .ctor() { }
}

