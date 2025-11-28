// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons
public enum EAmplificationMode // TypeDefIndex: 5475
{
	// Fields
	public int value__; // 0x0
	public const EAmplificationMode Bounce = 0;
	public const EAmplificationMode Pierce = 1;
	public const EAmplificationMode ShieldStack = 2;
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons
public class Firefield : MonoBehaviour // TypeDefIndex: 5476
{
	// Fields
	private float collisionCooldown; // 0x20
	private float spawnTime; // 0x24
	private float aliveTime; // 0x28
	private float spawnRadius; // 0x2C
	private Vector3 normal; // 0x30
	private WeaponBase weaponBase; // 0x40
	private float damage; // 0x48
	private string damageSource; // 0x50
	private DamageContainer recycledDx; // 0x58
	private float nextCheckDamageTime; // 0x60
	private float visualRadius; // 0x64
	private float desiredVisualRadius; // 0x68

	// Methods

	// RVA: 0x3F79B0 Offset: 0x3F5FB0 VA: 0x1803F79B0
	public void Set(Vector3 pos, Vector3 fallbackPos, float radius, float duration, float damage, WeaponBase weaponBase, string damageSource) { }

	// RVA: 0x3F7480 Offset: 0x3F5A80 VA: 0x1803F7480
	protected void FixedUpdate() { }

	// RVA: 0x3F76A0 Offset: 0x3F5CA0 VA: 0x1803F76A0
	private bool IsWeaponAttack() { }

	// RVA: 0x3F6E10 Offset: 0x3F5410 VA: 0x1803F6E10
	private void CheckDamage() { }

	// RVA: 0x3F75A0 Offset: 0x3F5BA0 VA: 0x1803F75A0
	private float GetEffectiveRadius() { }

	// RVA: 0x3F7620 Offset: 0x3F5C20 VA: 0x1803F7620
	private float GetHitboxRadius() { }

	// RVA: 0x3F80E0 Offset: 0x3F66E0 VA: 0x1803F80E0
	protected void Update() { }

	// RVA: 0x3F76B0 Offset: 0x3F5CB0 VA: 0x1803F76B0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x3F7820 Offset: 0x3F5E20 VA: 0x1803F7820
	private void OnDrawGizmos() { }

	// RVA: 0x3F82C0 Offset: 0x3F68C0 VA: 0x1803F82C0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons
public class EnemyScanContainer // TypeDefIndex: 5477
{
	// Fields
	public float range; // 0x10
	public float time; // 0x14
	public Vector3 position; // 0x18
	private const float distThreshold = 2;
	private const float distThresholdSqr = 4;
	private const float timeThreshold = 0.04;
	private const float rangeThreshold = 1;

	// Methods

	// RVA: 0x3F4990 Offset: 0x3F2F90 VA: 0x1803F4990
	public void .ctor(Vector3 position, float time, float range) { }

	// RVA: 0x3F4870 Offset: 0x3F2E70 VA: 0x1803F4870
	public bool IsEqual(Vector3 pos, float t, float range) { }

	// RVA: 0x3F4820 Offset: 0x3F2E20 VA: 0x1803F4820
	public bool IsEqual(EnemyScanContainer other) { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons
public static class EnemyTargeting // TypeDefIndex: 5478
{
	// Fields
	private static int currentBufferCount; // 0x0
	private static Collider[] enemyBuffer; // 0x8
	private static RaycastHit[] losBuf; // 0x10
	private static EnemyScanContainer currentBufferContainer; // 0x18
	private static readonly Dictionary<Type, Collider[]> buffers; // 0x20

	// Methods

	// RVA: 0x3F69C0 Offset: 0x3F4FC0 VA: 0x1803F69C0
	public static void Init() { }

	// RVA: 0x3F5100 Offset: 0x3F3700 VA: 0x1803F5100
	public static void Cleanup() { }

	// RVA: 0x3F6AE0 Offset: 0x3F50E0 VA: 0x1803F6AE0
	private static void Reset() { }

	// RVA: 0x3F55B0 Offset: 0x3F3BB0 VA: 0x1803F55B0
	public static int GetEnemiesInRadiusSafe(object owner, Vector3 pos, float range, out Collider[] buffer) { }

	// RVA: 0x3F5AD0 Offset: 0x3F40D0 VA: 0x1803F5AD0
	public static Enemy GetEnemy(Vector3 position, float range, int projectileIndex, bool useVision, GameObject exceptObject) { }

	// RVA: 0x3F57E0 Offset: 0x3F3DE0 VA: 0x1803F57E0
	public static int GetEnemiesInRadius(Vector3 position, float range, out Collider[] enemies) { }

	// RVA: 0x3F6840 Offset: 0x3F4E40 VA: 0x1803F6840
	private static Enemy GetTargetedEnemy(Collider[] colliders, int count, Vector3 pos, bool useVision, GameObject exceptObject) { }

	// RVA: 0x3F61E0 Offset: 0x3F47E0 VA: 0x1803F61E0
	private static Enemy GetSmartEnemy(Collider[] colliders, int count, Vector3 pos, bool useVision, GameObject exceptObject) { }

	// RVA: 0x3F5220 Offset: 0x3F3820 VA: 0x1803F5220
	private static Enemy GetClosestEnemy(Collider[] colliders, int count, Vector3 pos, bool useVision, GameObject exceptObject) { }

	// RVA: 0x3F5EA0 Offset: 0x3F44A0 VA: 0x1803F5EA0
	private static Enemy GetRandomEnemy(Collider[] colliders, int count, Vector3 pos, bool useVision, GameObject exceptObject) { }

	// RVA: 0x3F6B60 Offset: 0x3F5160 VA: 0x1803F6B60
	private static bool ShouldPickRandom(int idx, float ratio) { }

	// RVA: 0x3F6C00 Offset: 0x3F5200 VA: 0x1803F6C00
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons
public class VisualizeTargeting : MonoBehaviour // TypeDefIndex: 5479
{
	// Fields
	private Enemy target; // 0x20

	// Methods

	// RVA: 0x40CB40 Offset: 0x40B140 VA: 0x18040CB40
	private void FixedUpdate() { }

	// RVA: 0x40CC10 Offset: 0x40B210 VA: 0x18040CC10
	private void Update() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons
public class WeaponBase // TypeDefIndex: 5480
{
	// Fields
	private float usedWeaponAtTime; // 0x10
	public WeaponData weaponData; // 0x18
	public int level; // 0x20
	private Dictionary<EStat, float> weaponStats; // 0x28
	private List<List<StatModifier>> upgrades; // 0x30
	private WeaponPassive passive; // 0x38
	public static Action<EStat, EWeapon> A_WeaponStatUpdate; // 0x0
	[CompilerGenerated]
	private bool <enabled>k__BackingField; // 0x40

	// Properties
	public bool enabled { get; set; }

	// Methods

	// RVA: 0x40E0B0 Offset: 0x40C6B0 VA: 0x18040E0B0
	public void .ctor(WeaponData data) { }

	// RVA: 0x40CE10 Offset: 0x40B410 VA: 0x18040CE10
	public void Cleanup() { }

	[CompilerGenerated]
	// RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	public bool get_enabled() { }

	[CompilerGenerated]
	// RVA: 0x40E2F0 Offset: 0x40C8F0 VA: 0x18040E2F0
	private void set_enabled(bool value) { }

	// RVA: 0x40CE30 Offset: 0x40B430 VA: 0x18040CE30
	public void Disable() { }

	// RVA: 0x40CE40 Offset: 0x40B440 VA: 0x18040CE40
	public void Enable() { }

	// RVA: 0x40DF70 Offset: 0x40C570 VA: 0x18040DF70
	public void Use() { }

	// RVA: 0x40DDC0 Offset: 0x40C3C0 VA: 0x18040DDC0
	public void Upgrade(List<StatModifier> upgradeOffer) { }

	// RVA: 0x40D6E0 Offset: 0x40BCE0 VA: 0x18040D6E0
	private void UpdateStat(EStat stat) { }

	// RVA: 0x40CEC0 Offset: 0x40B4C0 VA: 0x18040CEC0
	public float GetTestUpdateStat(EStat stat, StatModifier testUpgrade) { }

	// RVA: 0x40D5B0 Offset: 0x40BBB0 VA: 0x18040D5B0
	public float GetValue(EStat stat) { }

	// RVA: 0x40E0A0 Offset: 0x40C6A0 VA: 0x18040E0A0
	public void WeaponPassiveChanged(EStat stat) { }

	// RVA: 0x40CE50 Offset: 0x40B450 VA: 0x18040CE50
	private float GetBaseValue(EStat stat) { }

	// RVA: 0x40CD80 Offset: 0x40B380 VA: 0x18040CD80
	private void ApplyStatModifier(StatModifier modifier, int amount, ref float flatValues, ref float additionValues, ref float multiplicationValues) { }

	// RVA: 0x40D620 Offset: 0x40BC20 VA: 0x18040D620
	private bool IsCooldown() { }

	// RVA: 0x40CE70 Offset: 0x40B470 VA: 0x18040CE70
	private float GetCooldown() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons
public class WeaponInventory // TypeDefIndex: 5481
{
	// Fields
	private bool isMaxed; // 0x10
	private bool hasAimableWeapon; // 0x11
	public Dictionary<EWeapon, WeaponBase> weapons; // 0x18
	public static Action<WeaponBase> A_WeaponAdded; // 0x0
	public static Action<WeaponBase> A_WeaponRemoved; // 0x8
	public static Action<WeaponBase> A_WeaponToggled; // 0x10

	// Methods

	// RVA: 0x426930 Offset: 0x424F30 VA: 0x180426930
	public void AddWeapon(WeaponData weaponData, List<StatModifier> upgradeOffer) { }

	// RVA: 0x4271A0 Offset: 0x4257A0 VA: 0x1804271A0
	public void ToggleWeapon(EWeapon eWeapon, bool enable) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void RemoveWeapon() { }

	// RVA: 0x427080 Offset: 0x425680 VA: 0x180427080
	public void Tick() { }

	// RVA: 0x426EB0 Offset: 0x4254B0 VA: 0x180426EB0
	public int GetNumWeapons() { }

	// RVA: 0x426F00 Offset: 0x425500 VA: 0x180426F00
	public int GetWeaponLevel(EWeapon eWeapon) { }

	// RVA: 0x426B50 Offset: 0x425150 VA: 0x180426B50
	private void CheckMaxed() { }

	// RVA: 0x426FA0 Offset: 0x4255A0 VA: 0x180426FA0
	private bool IsMaxLevel(EWeapon eWeapon) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool IsMaxed() { }

	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool HasAimableWeapon() { }

	// RVA: 0x426D90 Offset: 0x425390 VA: 0x180426D90
	public void Cleanup() { }

	// RVA: 0x4272C0 Offset: 0x4258C0 VA: 0x1804272C0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons
[Serializable]
public class WeaponUpgrade // TypeDefIndex: 5482
{
	// Fields
	public List<StatModifier> statModifiers; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Inventory__Items__Pickups.Weapons
public static class WeaponUtility // TypeDefIndex: 5484
{
	// Fields
	public static Action<DamageContainer> A_CreateDamageContainerPreAttack; // 0x0
	private static StatComponents itemModifier; // 0x8
	private static DamageContainer weaponDc; // 0x10
	private static DamageContainer otherDc; // 0x18
	private static List<int> availableIndexes; // 0x20

	// Methods

	// RVA: 0x429160 Offset: 0x427760 VA: 0x180429160
	public static DamageContainer GetDamageContainer(WeaponBase weaponBase, ProjectileBase projectile, Enemy enemy, Vector3 direction, float forceDamage = -1) { }

	// RVA: 0x4295B0 Offset: 0x427BB0 VA: 0x1804295B0
	public static DamageContainer GetDamageContainer(DamageContainer recycleDc, float baseDamage, float procCoefficient, string damageSourceName, Vector3 direction, Enemy enemy) { }

	// RVA: 0x42A930 Offset: 0x428F30 VA: 0x18042A930
	private static float GetWeaponDamage(WeaponBase weaponBase, float forceDamage) { }

	// RVA: 0x429CB0 Offset: 0x4282B0 VA: 0x180429CB0
	private static float GetNewDamage(float baseDamage, StatComponents itemModifierStatComponents) { }

	// RVA: 0x429930 Offset: 0x427F30 VA: 0x180429930
	public static float GetDamage(WeaponBase weaponBase) { }

	// RVA: 0x429990 Offset: 0x427F90 VA: 0x180429990
	private static float GetDamage(float damage) { }

	// RVA: 0x4299C0 Offset: 0x427FC0 VA: 0x1804299C0
	private static float GetDcCritMultiplier(float critChance, DamageContainer dc) { }

	// RVA: 0x42A170 Offset: 0x428770 VA: 0x18042A170
	public static Enemy GetRandomEnemyInRange(Vector3 position, float range, bool tryAimForward = False, GameObject exceptObject) { }

	// RVA: 0x429DC0 Offset: 0x4283C0 VA: 0x180429DC0
	public static Enemy GetRandomEnemyInRadius(Vector3 position, float radius, GameObject exceptObject) { }

	// RVA: 0x429A80 Offset: 0x428080 VA: 0x180429A80
	public static Collider[] GetEnemiesInRadius(Vector3 position, float radius) { }

	// RVA: 0x4288D0 Offset: 0x426ED0 VA: 0x1804288D0
	public static Enemy ConecastEnemyInVision(Vector3 position, float range, bool useRandom) { }

	// RVA: 0x429B30 Offset: 0x428130 VA: 0x180429B30
	public static Enemy GetIndex0EnemyInRange(Vector3 position, WeaponData weaponData, GameObject exceptObject) { }

	// RVA: 0x428F00 Offset: 0x427500 VA: 0x180428F00
	public static float GetAttackSizeMultiplier(WeaponBase weaponBase) { }

	// RVA: 0x428E90 Offset: 0x427490 VA: 0x180428E90
	public static int GetAttackQuantity(WeaponBase weaponBase) { }

	// RVA: 0x429D30 Offset: 0x428330 VA: 0x180429D30
	public static int GetProjectileBounces(WeaponBase weaponBase) { }

	// RVA: 0x429D80 Offset: 0x428380 VA: 0x180429D80
	public static float GetProjectileSpeed(WeaponBase weaponBase) { }

	// RVA: 0x429A10 Offset: 0x428010 VA: 0x180429A10
	public static float GetDuration(WeaponBase weaponBase) { }

	// RVA: 0x428F70 Offset: 0x427570 VA: 0x180428F70
	public static float GetBurstInterval(WeaponBase weaponBase) { }

	// RVA: 0x42A800 Offset: 0x428E00 VA: 0x18042A800
	public static float GetWeaponCooldown(WeaponBase weaponBase) { }

	// RVA: 0x4290C0 Offset: 0x4276C0 VA: 0x1804290C0
	public static float GetCritChance(WeaponBase weaponBase) { }

	// RVA: 0x429110 Offset: 0x427710 VA: 0x180429110
	public static float GetCritDamageMultiplier(WeaponBase weaponBase) { }

	// RVA: 0x429C40 Offset: 0x428240 VA: 0x180429C40
	public static float GetKnockback(WeaponBase weaponBase) { }

	// RVA: 0x429870 Offset: 0x427E70 VA: 0x180429870
	public static float GetDamageProjectile(ProjectileBase projectile) { }

	// RVA: 0x42A9E0 Offset: 0x428FE0 VA: 0x18042A9E0
	public static float GetWeaponRange(WeaponBase weaponBase) { }

	// RVA: 0x429CA0 Offset: 0x4282A0 VA: 0x180429CA0
	public static int GetMaxProjectilesPoolSize(EWeapon weapon) { }

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90
	public static int GetMaxProjectileHitsPoolSize(EWeapon weapon) { }

	// RVA: 0x429C90 Offset: 0x428290 VA: 0x180429C90
	public static int GetMaxProjectileDonePoolSize(EWeapon weapon) { }

	// RVA: 0x429C80 Offset: 0x428280 VA: 0x180429C80
	public static int GetMaxAttacksPoolSize(EWeapon weapon) { }

	// RVA: 0x42ACC0 Offset: 0x4292C0 VA: 0x18042ACC0
	public static void WeaponAttack(WeaponBase weapon) { }

	// RVA: 0x42AA50 Offset: 0x429050 VA: 0x18042AA50
	public static void LightningStrike(Enemy enemy, int bounces, DamageContainer dc, float bounceRange, float bounceProcCoefficient) { }

	// RVA: 0x4282D0 Offset: 0x4268D0 VA: 0x1804282D0
	private static void ChainLightning(Enemy initialEnemy, int numBounces, float bounceRange, DamageContainer sourceDc, float bounceProcCoefficient) { }

	// RVA: 0x42AF40 Offset: 0x429540 VA: 0x18042AF40
	private static void .cctor() { }
}

