// Namespace: Actors.Enemies
public enum EEnemy // TypeDefIndex: 5314
{
	// Fields
	public int value__; // 0x0
	public const EEnemy Skeleton = 0;
	public const EEnemy GoldenSkeleton = 1;
	public const EEnemy XpSkeleton = 2;
	public const EEnemy ArmoredSkeleton = 3;
	public const EEnemy SkeletonDusty = 4;
	public const EEnemy ArmoredSkeletonDusty = 5;
	public const EEnemy Ghoul = 6;
	public const EEnemy MinibossPig = 7;
	public const EEnemy Mummy = 8;
	public const EEnemy Slime = 9;
	public const EEnemy Test = 10;
	public const EEnemy Test2 = 11;
	public const EEnemy Goblin = 12;
	public const EEnemy GoblinStrong = 13;
	public const EEnemy GoblinTank = 14;
	public const EEnemy MinibossGolem = 15;
	public const EEnemy Ghost = 16;
	public const EEnemy GreaterGhost = 17;
	public const EEnemy SkeletonMage = 18;
	public const EEnemy Ent1 = 19;
	public const EEnemy Ent2 = 20;
	public const EEnemy Ent3 = 21;
	public const EEnemy BoomerSpider = 22;
	public const EEnemy Golem = 23;
	public const EEnemy Bee = 24;
	public const EEnemy MinibossGolemSand = 25;
	public const EEnemy Scorpion = 26;
	public const EEnemy MinibossScorpion = 27;
	public const EEnemy Wisp = 28;
	public const EEnemy CactusShooter = 29;
	public const EEnemy ScorpionMedium = 30;
	public const EEnemy MummyTank = 31;
	public const EEnemy MummyAncient = 32;
	public const EEnemy Tumblebone = 33;
	public const EEnemy Pharaoh1 = 34;
	public const EEnemy Pharaoh2 = 35;
	public const EEnemy Pharaoh3 = 36;
	public const EEnemy Bandit = 37;
	public const EEnemy Bush = 38;
	public const EEnemy GhostRed = 39;
	public const EEnemy GhostPurple = 40;
}

// Namespace: Actors.Enemies
public static class EnemyBehaviour // TypeDefIndex: 5315
{
	// Methods

	// RVA: 0x3B9A70 Offset: 0x3B8070 VA: 0x1803B9A70
	public static void DeathBehaviour(Enemy enemy) { }

	// RVA: 0x3B9B40 Offset: 0x3B8140 VA: 0x1803B9B40
	public static void FixedUpdate(Enemy enemy) { }
}

// Namespace: Actors.Enemies
public class EnemyMovementRb : MonoBehaviour // TypeDefIndex: 5317
{
	// Fields
	public Enemy enemy; // 0x20
	public Rigidbody rb; // 0x28
	private float nextStepTime; // 0x30
	private Vector3 offsetBias; // 0x34
	private Vector3 desiredVelocity; // 0x40
	private Quaternion desiredRotation; // 0x4C
	private float knockbackResetSpeed; // 0x5C
	private Vector3 knockbackVelocity; // 0x60
	private float randomOffset; // 0x6C
	private float randomGroundedCheckOffset; // 0x70
	public EnemyMovementRb.State state; // 0x74
	private float flyingKnockupVel; // 0x78
	private bool canRotate; // 0x7C
	private bool isClimbing; // 0x7D
	private float nextClimbCheckTime; // 0x80
	private float nextGroundedCheckTime; // 0x84
	private float groundCheckInterval; // 0x88
	[CompilerGenerated]
	private bool <grounded>k__BackingField; // 0x8C
	private bool dashing; // 0x8D
	private float dashStopTime; // 0x90
	private Vector3 dashDirection; // 0x94
	private float dashSpeed; // 0xA0
	private bool isDashingWall; // 0xA4
	private HashSet<EDebuff> debuffs; // 0xA8
	private Vector3 baseVelocity; // 0xB0
	private const float baseRotationSpeed = 10;
	private float rotationSpeed; // 0xBC
	private Vector3 flyingOffset; // 0xC0
	public float distanceToTarget; // 0xCC
	private bool isStationary; // 0xD0
	private float nextGetSpeedTime; // 0xD4
	private float getSpeedCooldown; // 0xD8
	private float storedSpeed; // 0xDC
	private static float knockbackConstant; // 0x0
	private const float maxKnockback = 5;
	private const float maxBossKnockback = 2.25;
	private float maxKnockbackVelSqrBoss; // 0xE0
	private Transform suckTarget; // 0xE8
	private float totalSuckTime; // 0xF0
	private float totalSuckTimeMax; // 0xF4
	private float nextCheckDamageTime; // 0xF8

	// Properties
	public bool grounded { get; set; }

	// Methods

	// RVA: 0x3B9C00 Offset: 0x3B8200 VA: 0x1803B9C00
	private void Awake() { }

	// RVA: 0x3BC350 Offset: 0x3BA950 VA: 0x1803BC350
	private void OnDestroy() { }

	// RVA: 0x3BB490 Offset: 0x3B9A90 VA: 0x1803BB490
	public void Init() { }

	// RVA: 0x3BBBB0 Offset: 0x3BA1B0 VA: 0x1803BBBB0
	public void MyFixedUpdate() { }

	// RVA: 0x3BCA90 Offset: 0x3BB090 VA: 0x1803BCA90
	private float TryClimbWall() { }

	[CompilerGenerated]
	// RVA: 0x3BD190 Offset: 0x3BB790 VA: 0x1803BD190
	public bool get_grounded() { }

	[CompilerGenerated]
	// RVA: 0x3BD1A0 Offset: 0x3BB7A0 VA: 0x1803BD1A0
	private void set_grounded(bool value) { }

	// RVA: 0x3B9DA0 Offset: 0x3B83A0 VA: 0x1803B9DA0
	private void CheckGrounded() { }

	// RVA: 0x3BB280 Offset: 0x3B9880 VA: 0x1803BB280
	private Vector3 GetTargetPosition() { }

	// RVA: 0x3B9FA0 Offset: 0x3B85A0 VA: 0x1803B9FA0
	public void DashStart(Vector3 dir, float dashTime, float dashSpeed) { }

	// RVA: 0x3BC4D0 Offset: 0x3BAAD0 VA: 0x1803BC4D0
	public void SetDashDirection(Vector3 dir) { }

	// RVA: 0x3BA100 Offset: 0x3B8700 VA: 0x1803BA100
	private void Dashing() { }

	// RVA: 0x3BC8C0 Offset: 0x3BAEC0 VA: 0x1803BC8C0
	public void StopDash() { }

	// RVA: 0x3BC8D0 Offset: 0x3BAED0 VA: 0x1803BC8D0
	public void StopMovement() { }

	// RVA: 0x3BC890 Offset: 0x3BAE90 VA: 0x1803BC890
	public void StartMovement() { }

	// RVA: 0x3BC610 Offset: 0x3BAC10 VA: 0x1803BC610
	private void SetVelocity(Vector3 vel) { }

	// RVA: 0x3BC960 Offset: 0x3BAF60 VA: 0x1803BC960
	private void TimescaleVelocity() { }

	// RVA: 0x3BA740 Offset: 0x3B8D40 VA: 0x1803BA740
	public void FindNextPosition() { }

	// RVA: 0x3BC530 Offset: 0x3BAB30 VA: 0x1803BC530
	public void SetDesiredRotation(Vector3 targetPos) { }

	// RVA: 0x3BB1B0 Offset: 0x3B97B0 VA: 0x1803BB1B0
	private float GetSpeed() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void MyUpdate() { }

	// RVA: 0x3BC490 Offset: 0x3BAA90 VA: 0x1803BC490
	public void Pause(bool isPaused) { }

	// RVA: 0x3BB750 Offset: 0x3B9D50 VA: 0x1803BB750
	public void KnockUp(float knockbackForce) { }

	// RVA: 0x3BB930 Offset: 0x3B9F30 VA: 0x1803BB930
	public void Knockback(DamageContainer dc) { }

	// RVA: 0x3BB9A0 Offset: 0x3B9FA0 VA: 0x1803BB9A0
	public void Knockback(Vector3 dir, float knockback) { }

	// RVA: 0x3BC910 Offset: 0x3BAF10 VA: 0x1803BC910
	public void Suck(Transform target) { }

	// RVA: 0x3BC900 Offset: 0x3BAF00 VA: 0x1803BC900
	public void StopSuck() { }

	// RVA: 0x3B9D40 Offset: 0x3B8340 VA: 0x1803B9D40
	private bool CanFindNextPosition() { }

	// RVA: 0x3BAFF0 Offset: 0x3B95F0 VA: 0x1803BAFF0
	private float GetNextStepTime(float distanceToTarget) { }

	// RVA: 0x3BAEE0 Offset: 0x3B94E0 VA: 0x1803BAEE0
	private float GetNextGroundCheckOffset(float distanceToTarget) { }

	// RVA: 0x3BD060 Offset: 0x3BB660 VA: 0x1803BD060
	public void .ctor() { }

	// RVA: 0x3BD020 Offset: 0x3BB620 VA: 0x1803BD020
	private static void .cctor() { }
}

// Namespace: Actors.Enemies
public class EnemySpawnParticles : MonoBehaviour // TypeDefIndex: 5318
{
	// Fields
	public RandomSfx audio; // 0x20
	public ParticleSystem ps; // 0x28

	// Methods

	// RVA: 0x3BD380 Offset: 0x3BB980 VA: 0x1803BD380
	public void Set(Enemy enemy) { }

	// RVA: 0x3BD1B0 Offset: 0x3BB7B0 VA: 0x1803BD1B0
	public void Release() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

