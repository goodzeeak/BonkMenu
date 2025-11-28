// Namespace: Assets.Scripts.Game.Combat.EnemySpecialAttacks
public enum EEnemyAttack // TypeDefIndex: 5673
{
	// Fields
	public int value__; // 0x0
	public const EEnemyAttack RootSpikes = 0;
	public const EEnemyAttack StoneSpikes = 1;
	public const EEnemyAttack PoisonSpikes = 2;
	public const EEnemyAttack PoisonSpikeProjectiles = 3;
	public const EEnemyAttack CactusProjectile = 4;
	public const EEnemyAttack SandPillar = 5;
	public const EEnemyAttack BanditSlice = 6;
	public const EEnemyAttack SniperShot = 7;
	public const EEnemyAttack GroundSlam = 8;
	public const EEnemyAttack MudSplash = 9;
}

// Namespace: Assets.Scripts.Game.Combat.EnemySpecialAttacks
public class EnemyAttackEffectPrefab : MonoBehaviour // TypeDefIndex: 5674
{
	// Fields
	public EEnemyAttack eAttack; // 0x20
	public float aliveTime; // 0x24
	private float returnTime; // 0x28

	// Methods

	// RVA: 0x44F750 Offset: 0x44DD50 VA: 0x18044F750
	private void OnEnable() { }

	// RVA: 0x44F7B0 Offset: 0x44DDB0 VA: 0x18044F7B0
	private void Update() { }

	// RVA: 0x44F860 Offset: 0x44DE60 VA: 0x18044F860
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemySpecialAttacks
public class EnemyAttackPrefabAnimation : MonoBehaviour // TypeDefIndex: 5675
{
	// Fields
	public AnimationCurve animationCurveScale; // 0x20
	public float animationDuration; // 0x28
	private Vector3 defaultSize; // 0x2C
	private float animationTime; // 0x38

	// Methods

	// RVA: 0x44F870 Offset: 0x44DE70 VA: 0x18044F870
	private void Awake() { }

	// RVA: 0x44F8B0 Offset: 0x44DEB0 VA: 0x18044F8B0
	private void Update() { }

	// RVA: 0x44F9D0 Offset: 0x44DFD0 VA: 0x18044F9D0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemySpecialAttacks
public class EnemyProjectileMud : EnemySpecialAttackPrefab // TypeDefIndex: 5676
{
	// Fields
	public GameObject hitEffect; // 0x50
	public ParticleSystem mudParticles; // 0x58
	public Transform slamParticles; // 0x60
	public Transform preParticles; // 0x68
	public bool grounded; // 0x70
	public bool predictive; // 0x71

	// Methods

	// RVA: 0x44FDC0 Offset: 0x44E3C0 VA: 0x18044FDC0 Slot: 4
	protected override void Init() { }

	// RVA: 0x450390 Offset: 0x44E990 VA: 0x180450390
	private void SpawnHitEffect() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemySpecialAttacks
[Serializable]
public class EnemySpecialAttack // TypeDefIndex: 5677
{
	// Fields
	public bool isEnabled; // 0x10
	public string attackName; // 0x18
	public GameObject attackPrefab; // 0x20
	[Header("Attack Settings")]
	public float attackChargeTime; // 0x28
	public float attackRadius; // 0x2C
	public float attackCooldown; // 0x30
	public float duration; // 0x34
	public float nextSpecialAttackCooldown; // 0x38
	public float triggerDistance; // 0x3C
	public float endLag; // 0x40
	public float damageMultiplier; // 0x44

	// Methods

	// RVA: 0x451C60 Offset: 0x450260 VA: 0x180451C60
	public float GetDamage(Enemy enemy) { }

	// RVA: 0x451CC0 Offset: 0x4502C0 VA: 0x180451CC0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemySpecialAttacks
public class SpecialAttackController // TypeDefIndex: 5679
{
	// Fields
	private static bool enabled; // 0x0
	private HashSet<EnemySpecialAttack> attacks; // 0x10
	private Dictionary<EnemySpecialAttack, float> cooldowns; // 0x18
	private float updateRate; // 0x20
	private float nextCheckTime; // 0x24
	private Enemy enemy; // 0x28
	private bool isAttacking; // 0x30
	private float attackOverAtTime; // 0x34
	private EnemySpecialAttack currentAttack; // 0x38

	// Methods

	// RVA: 0x461A50 Offset: 0x460050 VA: 0x180461A50
	public void .ctor(Enemy enemy) { }

	// RVA: 0x461300 Offset: 0x45F900 VA: 0x180461300
	public void Tick() { }

	// RVA: 0x4617F0 Offset: 0x45FDF0 VA: 0x1804617F0
	private void UseSpecialAttack(EnemySpecialAttack attack) { }

	// RVA: 0x461270 Offset: 0x45F870 VA: 0x180461270
	private void FinishAttack() { }

	// RVA: 0x461A10 Offset: 0x460010 VA: 0x180461A10
	private static void .cctor() { }
}

