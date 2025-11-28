// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles
public enum EProjectileTargetMode // TypeDefIndex: 5489
{
	// Fields
	public int value__; // 0x0
	public const EProjectileTargetMode RandomDirection = 0;
	public const EProjectileTargetMode RandomTarget = 1;
	public const EProjectileTargetMode Index0 = 2;
	public const EProjectileTargetMode ClosestTargetInVision = 3;
	public const EProjectileTargetMode MoveDirection = 4;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles
public abstract class ProjectileBase : MonoBehaviour // TypeDefIndex: 5490
{
	// Fields
	public WeaponBase weaponBase; // 0x20
	protected WeaponAttack weaponAttack; // 0x28
	public float projectileRadius; // 0x30
	private float baseProjectileRadius; // 0x34
	public Vector3 direction; // 0x38
	public int bounces; // 0x44
	public int maxBounces; // 0x48
	protected bool timedOut; // 0x4C
	protected float expirationTime; // 0x50
	protected float projectileSpeed; // 0x54
	protected Collider lastHitEnemy; // 0x58
	protected HashSet<Collider> hitEnemies; // 0x60

	// Methods

	// RVA: 0x41F380 Offset: 0x41D980 VA: 0x18041F380
	public void Set(WeaponBase weaponBase, WeaponAttack weaponAttack, int projectileIndex) { }

	// RVA: 0x41E870 Offset: 0x41CE70 VA: 0x18041E870
	protected float GetDuration() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract bool TryInit(int projectileIndex);

	// RVA: 0x41E760 Offset: 0x41CD60 VA: 0x18041E760
	private void FixedUpdate() { }

	// RVA: 0x41E550 Offset: 0x41CB50 VA: 0x18041E550 Slot: 5
	protected virtual void CheckSpawnCollision() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract Vector3 GetMovementDirection();

	// RVA: 0x41F650 Offset: 0x41DC50 VA: 0x18041F650 Slot: 7
	protected virtual void StepMovement() { }

	// RVA: 0x41FA10 Offset: 0x41E010 VA: 0x18041FA10
	private void Update() { }

	// RVA: 0x41E6C0 Offset: 0x41CCC0 VA: 0x18041E6C0
	private void CheckTimeout() { }

	// RVA: 0x41F280 Offset: 0x41D880 VA: 0x18041F280
	protected void ProjectileDone() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void MyFixedUpdate();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void MyUpdate();

	// RVA: 0x41E3F0 Offset: 0x41C9F0 VA: 0x18041E3F0 Slot: 10
	protected virtual bool CheckCollision(Collider collider, Vector3 normal) { }

	// RVA: 0x41E910 Offset: 0x41CF10 VA: 0x18041E910 Slot: 11
	protected virtual bool HitEnemy(Collider collider, Vector3 normal) { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void FindMovementDirection();

	// RVA: 0x41ED10 Offset: 0x41D310 VA: 0x18041ED10 Slot: 13
	protected virtual void HitOther(Collider collider, Vector3 normal) { }

	// RVA: 0x41FA80 Offset: 0x41E080 VA: 0x18041FA80
	protected void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles
public class ProjectileBasic : ProjectileBase // TypeDefIndex: 5491
{
	// Fields
	protected GameObject currentTarget; // 0x68

	// Methods

	// RVA: 0x41FF00 Offset: 0x41E500 VA: 0x18041FF00 Slot: 4
	protected override bool TryInit(int projectileIndex) { }

	// RVA: 0x41FA90 Offset: 0x41E090 VA: 0x18041FA90 Slot: 12
	protected override void FindMovementDirection() { }

	// RVA: 0x41FD30 Offset: 0x41E330 VA: 0x18041FD30 Slot: 6
	protected override Vector3 GetMovementDirection() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected override void MyFixedUpdate() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	protected override void MyUpdate() { }

	// RVA: 0x41FD70 Offset: 0x41E370 VA: 0x18041FD70
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x41FE80 Offset: 0x41E480 VA: 0x18041FE80
	private void OnTriggerEnter(Collider collider) { }

	// RVA: 0x41FA80 Offset: 0x41E080 VA: 0x18041FA80
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles
public class ProjectileDexecutioner : ProjectileBase // TypeDefIndex: 5493
{
	// Fields
	public Vector3 colliderOffset; // 0x68
	public float testMultiplier; // 0x74
	public float projectileDistance; // 0x78
	private float forwardOffset; // 0x7C
	private float upOffset; // 0x80
	public Vector3 attackDir; // 0x84
	public float executionChance; // 0x90
	private static readonly RaycastHit[] sphereHits; // 0x0
	private List<ProjectileDexecutioner.MeleeHit> effectHits; // 0x98
	private bool useAudio; // 0xA0

	// Methods

	// RVA: 0x420F20 Offset: 0x41F520 VA: 0x180420F20 Slot: 4
	protected override bool TryInit(int projectileIndex) { }

	// RVA: 0x420BA0 Offset: 0x41F1A0 VA: 0x180420BA0 Slot: 6
	protected override Vector3 GetMovementDirection() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected override void MyFixedUpdate() { }

	// RVA: 0x420BD0 Offset: 0x41F1D0 VA: 0x180420BD0 Slot: 9
	protected override void MyUpdate() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 12
	protected override void FindMovementDirection() { }

	// RVA: 0x420320 Offset: 0x41E920 VA: 0x180420320
	public void CheckZone(WeaponBase weaponBase, float radius, GameObject hitEffect) { }

	// RVA: 0x420DA0 Offset: 0x41F3A0 VA: 0x180420DA0
	private void SpawnEffect() { }

	// RVA: 0x420BC0 Offset: 0x41F1C0 VA: 0x180420BC0
	private float GetRadius() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	protected override bool CheckCollision(Collider collider, Vector3 normal) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	protected override void StepMovement() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	protected override void CheckSpawnCollision() { }

	// RVA: 0x421580 Offset: 0x41FB80 VA: 0x180421580
	public void .ctor() { }

	// RVA: 0x4214E0 Offset: 0x41FAE0 VA: 0x1804214E0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles
public class ProjectileHoming : ProjectileBase // TypeDefIndex: 5494
{
	// Fields
	private Enemy enemyTarget; // 0x68

	// Methods

	// RVA: 0x421AC0 Offset: 0x4200C0 VA: 0x180421AC0 Slot: 4
	protected override bool TryInit(int projectileIndex) { }

	// RVA: 0x421690 Offset: 0x41FC90 VA: 0x180421690 Slot: 12
	protected override void FindMovementDirection() { }

	// RVA: 0x421AB0 Offset: 0x4200B0 VA: 0x180421AB0
	private bool HasBounces() { }

	// RVA: 0x4219D0 Offset: 0x41FFD0 VA: 0x1804219D0 Slot: 6
	protected override Vector3 GetMovementDirection() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected override void MyFixedUpdate() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	protected override void MyUpdate() { }

	// RVA: 0x421680 Offset: 0x41FC80 VA: 0x180421680
	private void DestroySelf() { }

	// RVA: 0x41FA80 Offset: 0x41E080 VA: 0x18041FA80
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles
public class ProjectileUtility // TypeDefIndex: 5495
{
	// Methods

	// RVA: 0x421CB0 Offset: 0x4202B0 VA: 0x180421CB0
	public static float GetArrowSpeed(WeaponBase weaponBase) { }

	// RVA: 0x421B40 Offset: 0x420140 VA: 0x180421B40
	public static float GetArrowSpeedReduction(WeaponBase weaponBase) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

