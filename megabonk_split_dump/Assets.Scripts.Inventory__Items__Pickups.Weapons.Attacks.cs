// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons.Attacks
public class WeaponAttack : MonoBehaviour // TypeDefIndex: 5497
{
	// Fields
	public GameObject prefabProjectile; // 0x20
	public GameObject prefabMuzzle; // 0x28
	public GameObject prefabHit; // 0x30
	public WeaponBase weaponBase; // 0x38
	protected MyPlayer player; // 0x40
	private bool attackDone; // 0x48
	public float projectileSizeMultiplier; // 0x4C
	public Action A_SpawnedProjectile; // 0x50
	public static Action<ProjectileBase> A_SpawnedProjectileSuccessfully; // 0x0
	private float expirationTime; // 0x58
	private EnemyScanContainer lastCheckSphere; // 0x60
	public bool lastWasSkip; // 0x68
	private float muzzleCooldown; // 0x6C
	private AttackMuzzle muzzle; // 0x70

	// Methods

	// RVA: 0x425A90 Offset: 0x424090 VA: 0x180425A90
	public void SetAttack(WeaponBase weaponBase, MyPlayer player) { }

	[IteratorStateMachine(typeof(WeaponAttack.<StartAttack>d__11))]
	// RVA: 0x4260C0 Offset: 0x4246C0 VA: 0x1804260C0
	private IEnumerator StartAttack() { }

	// RVA: 0x425B30 Offset: 0x424130 VA: 0x180425B30 Slot: 4
	protected virtual void SpawnProjectile(int projectileIndex) { }

	// RVA: 0x4257D0 Offset: 0x423DD0 VA: 0x1804257D0
	public float GetSize() { }

	// RVA: 0x425890 Offset: 0x423E90 VA: 0x180425890
	public void ProjectileDone(ProjectileBase projectile) { }

	// RVA: 0x425950 Offset: 0x423F50 VA: 0x180425950
	public void ProjectileHit(Vector3 hitPos, Vector3 moveDir, bool hitEnemy, bool useSfx) { }

	// RVA: 0x426130 Offset: 0x424730 VA: 0x180426130
	public void SuccessfullySpawnedProjectile(ProjectileBase projectile) { }

	// RVA: 0x426700 Offset: 0x424D00 VA: 0x180426700
	private void Update() { }

	// RVA: 0x4255A0 Offset: 0x423BA0 VA: 0x1804255A0
	private void AttackTimeout() { }

	// RVA: 0x425690 Offset: 0x423C90 VA: 0x180425690
	private Vector3 GetProjectilePosition() { }

	// RVA: 0x425780 Offset: 0x423D80 VA: 0x180425780
	private Quaternion GetProjectileRotation() { }

	// RVA: 0x426850 Offset: 0x424E50 VA: 0x180426850
	public void .ctor() { }
}

