// Namespace: Assets.Scripts.Objects.Pooling
public class PoolManager : MonoBehaviour // TypeDefIndex: 5438
{
	// Fields
	public Transform damageNumbersParent; // 0x20
	private static int maxCritPrefabs; // 0x0
	private int maxBonkPrefabs; // 0x28
	private int maxBulletHitPrefabs; // 0x2C
	private int maxHitNumbers; // 0x30
	private int maxLightningStrikes; // 0x34
	private int maxFirefields; // 0x38
	private int rocketPoolSize; // 0x3C
	private int orbPoolSize; // 0x40
	private int explosionPoolSize; // 0x44
	private static int maxSilver; // 0x4
	private static int cursedHitsPoolSize; // 0x8
	private static int charmPoolSize; // 0xC
	private static int eatPoolSize; // 0x10
	public static PoolManager Instance; // 0x18
	private int maxWarningSpheres; // 0x48
	public GameObject xpPrefab; // 0x50
	public GameObject goldPrefab; // 0x58
	public GameObject silverPrefab; // 0x60
	public GameObject enemyPrefab; // 0x68
	public GameObject enemySpawnFxPrefab; // 0x70
	public GameObject damageNumbersPrefab; // 0x78
	public GameObject pickupEffectPrefab; // 0x80
	public GameObject goldBurstPrefab; // 0x88
	public GameObject critEffectPrefab; // 0x90
	public GameObject lightningStrikePrefab; // 0x98
	public GameObject footstepPrefab; // 0xA0
	public GameObject enemyStatusSymbolsPrefab; // 0xA8
	public ObjectPool<GameObject> xpPool; // 0xB0
	public ObjectPool<GameObject> goldPool; // 0xB8
	public ObjectPool<GameObject> silverPool; // 0xC0
	public ObjectPool<GameObject> enemyPool; // 0xC8
	public ObjectPool<GameObject> enemySpawnFxPool; // 0xD0
	public ObjectPool<GameObject> damageNumbersPool; // 0xD8
	public ObjectPool<GameObject> pickupeffectPool; // 0xE0
	public ObjectPool<GameObject> goldBurstPool; // 0xE8
	public ObjectPool<GameObject> critEffectPool; // 0xF0
	public ObjectPool<GameObject> lightningStrikePool; // 0xF8
	public ObjectPool<GameObject> footstepPool; // 0x100
	public ObjectPool<GameObject> enemyStatusSymbolsPool; // 0x108
	public ObjectPool<GameObject> powerupPool; // 0x110
	public ObjectPool<GameObject> warningTubePool; // 0x118
	public ObjectPool<GameObject> warningSpherePool; // 0x120
	public ObjectPool<GameObject> bullseyePool; // 0x128
	public ObjectPool<GameObject> poisonPool; // 0x130
	public GameObject defaultHitPrefab; // 0x138
	public GameObject powerupPrefab; // 0x140
	public GameObject warningTube; // 0x148
	public GameObject warningSphere; // 0x150
	public GameObject bullseye; // 0x158
	public GameObject poisonCloud; // 0x160
	public Dictionary<EWeapon, ObjectPool<GameObject>> weaponAttackPools; // 0x168
	public Dictionary<EWeapon, ObjectPool<GameObject>> projectilePools; // 0x170
	public Dictionary<string, ObjectPool<GameObject>> projectileDonePools; // 0x178
	public Dictionary<string, ObjectPool<GameObject>> projectileHitPools; // 0x180
	public Dictionary<string, ObjectPool<GameObject>> enemyAttacksPools; // 0x188
	public Dictionary<EEnemyAttack, ObjectPool<GameObject>> enemyAttacksFxPools; // 0x190
	private int itemFxPoolSizes; // 0x198
	public ObjectPool<GameObject> grandmaTonicPool; // 0x1A0
	public ObjectPool<GameObject> megaCritPool; // 0x1A8
	public ObjectPool<GameObject> executePool; // 0x1B0
	public ObjectPool<GameObject> spicyMeatballPool; // 0x1B8
	public ObjectPool<GameObject> chainLightningPool; // 0x1C0
	public ObjectPool<GameObject> freezeFxPool; // 0x1C8
	public ObjectPool<GameObject> firefieldPool; // 0x1D0
	public ObjectPool<GameObject> rocketPool; // 0x1D8
	public ObjectPool<GameObject> explosionPool; // 0x1E0
	public ObjectPool<GameObject> bonkPool; // 0x1E8
	public ObjectPool<GameObject> bulletHitPool; // 0x1F0
	public ObjectPool<GameObject> cursedHitPool; // 0x1F8
	public ObjectPool<GameObject> orbPool; // 0x200
	public ObjectPool<GameObject> ghostPool; // 0x208
	public ObjectPool<GameObject> angrySoulPool; // 0x210
	public ObjectPool<GameObject> charmPool; // 0x218
	public ObjectPool<GameObject> borgorPool; // 0x220
	public ObjectPool<GameObject> eatPool; // 0x228
	public ObjectPool<GameObject> bloodmarkPool; // 0x230
	public ObjectPool<GameObject> cactusPool; // 0x238
	public ObjectPool<GameObject> tumbleweedPool; // 0x240
	public ObjectPool<GameObject> tumbleweedBreakPool; // 0x248
	public ObjectPool<GameObject> quinMaskPool; // 0x250
	public GameObject grandmaTonicFx; // 0x258
	public GameObject megaCritFx; // 0x260
	public GameObject spicyMeatballFx; // 0x268
	public GameObject chainLightningFx; // 0x270
	public GameObject freezeFx; // 0x278
	public GameObject firefield; // 0x280
	public GameObject rocket; // 0x288
	public GameObject explosionFx; // 0x290
	public GameObject bonkFx; // 0x298
	public GameObject executeFx; // 0x2A0
	public GameObject bulletHit; // 0x2A8
	public GameObject cursedHit; // 0x2B0
	public GameObject orb; // 0x2B8
	public GameObject ghost; // 0x2C0
	public GameObject angrySoul; // 0x2C8
	public GameObject charmFx; // 0x2D0
	public GameObject borgor; // 0x2D8
	public GameObject eat; // 0x2E0
	public GameObject bloodmark; // 0x2E8
	public GameObject cactusFx; // 0x2F0
	public GameObject tumbleweed; // 0x2F8
	public GameObject tumbleweedBreak; // 0x300
	public GameObject quinMaskFx; // 0x308
	private Dictionary<GameObject, WeaponAttack> weaponAttacksDict; // 0x310
	private Dictionary<GameObject, ProjectileBase> projectileDict; // 0x318
	private Dictionary<GameObject, DamageNumbers> damageNumbersDict; // 0x320
	private Dictionary<GameObject, AttackHit> attackHitsDict; // 0x328
	private Dictionary<EWeapon, string> weaponStrings; // 0x330

	// Methods

	// RVA: 0x403470 Offset: 0x401A70 VA: 0x180403470
	private void Awake() { }

	// RVA: 0x405460 Offset: 0x403A60 VA: 0x180405460
	private void Start() { }

	// RVA: 0x403B80 Offset: 0x402180 VA: 0x180403B80
	public DamageNumbers GetDamageNumber() { }

	// RVA: 0x403750 Offset: 0x401D50 VA: 0x180403750
	public WeaponAttack GetAttack(WeaponBase weaponBase) { }

	// RVA: 0x405180 Offset: 0x403780 VA: 0x180405180
	public void ReturnAttack(WeaponAttack weaponAttack) { }

	// RVA: 0x404C40 Offset: 0x403240 VA: 0x180404C40
	public ProjectileBase GetProjectile(WeaponAttack weaponAttack) { }

	// RVA: 0x4053B0 Offset: 0x4039B0 VA: 0x1804053B0
	public void ReturnProjectile(WeaponAttack weaponAttack, GameObject projectile) { }

	// RVA: 0x404840 Offset: 0x402E40 VA: 0x180404840
	public AttackHit GetProjectileHit(string source, GameObject hitPrefab) { }

	// RVA: 0x404410 Offset: 0x402A10 VA: 0x180404410
	public GameObject GetProjectileDoneFx(EWeapon eWeapon, GameObject hitPrefab) { }

	// RVA: 0x404520 Offset: 0x402B20 VA: 0x180404520
	public GameObject GetProjectileDoneFx(string source, GameObject hitPrefab) { }

	// RVA: 0x404080 Offset: 0x402680 VA: 0x180404080
	public GameObject GetEnemyAttack(EnemySpecialAttack specialAttack) { }

	// RVA: 0x403D40 Offset: 0x402340 VA: 0x180403D40
	public GameObject GetEnemyAttackFx(EnemySpecialAttackPrefab enemyAttackPrefab) { }

	// RVA: 0x405240 Offset: 0x403840 VA: 0x180405240
	public void ReturnEnemyAttackFx(EnemyAttackEffectPrefab attackPrefab) { }

	// RVA: 0x4052F0 Offset: 0x4038F0 VA: 0x1804052F0
	public void ReturnEnemyAttack(EnemySpecialAttackPrefab specialAttackPrefab) { }

	// RVA: 0x4036A0 Offset: 0x401CA0 VA: 0x1804036A0
	private GameObject CreatePooledItem(GameObject prefab, ObjectPool<GameObject> pool, int maxSize) { }

	// RVA: 0x403580 Offset: 0x401B80 VA: 0x180403580
	private GameObject CreatePooledItemTimeout(GameObject prefab, ObjectPool<GameObject> pool, int maxSize, float time) { }

	// RVA: 0x4050E0 Offset: 0x4036E0 VA: 0x1804050E0
	private void OnReturnedToPool(GameObject obj) { }

	// RVA: 0x405110 Offset: 0x403710 VA: 0x180405110
	private void OnTakeFromPool(GameObject obj) { }

	// RVA: 0x405090 Offset: 0x403690 VA: 0x180405090
	private void OnDestroyPoolObject(GameObject obj) { }

	// RVA: 0x409210 Offset: 0x407810 VA: 0x180409210
	public void .ctor() { }

	// RVA: 0x409180 Offset: 0x407780 VA: 0x180409180
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x407CD0 Offset: 0x4062D0 VA: 0x180407CD0
	private GameObject <Start>b__105_0() { }

	[CompilerGenerated]
	// RVA: 0x4082B0 Offset: 0x4068B0 VA: 0x1804082B0
	private GameObject <Start>b__105_1() { }

	[CompilerGenerated]
	// RVA: 0x408760 Offset: 0x406D60 VA: 0x180408760
	private GameObject <Start>b__105_2() { }

	[CompilerGenerated]
	// RVA: 0x408D20 Offset: 0x407320 VA: 0x180408D20
	private GameObject <Start>b__105_3() { }

	[CompilerGenerated]
	// RVA: 0x408E10 Offset: 0x407410 VA: 0x180408E10
	private GameObject <Start>b__105_4() { }

	[CompilerGenerated]
	// RVA: 0x408EB0 Offset: 0x4074B0 VA: 0x180408EB0
	private GameObject <Start>b__105_5() { }

	[CompilerGenerated]
	// RVA: 0x408F60 Offset: 0x407560 VA: 0x180408F60
	private GameObject <Start>b__105_6() { }

	[CompilerGenerated]
	// RVA: 0x409000 Offset: 0x407600 VA: 0x180409000
	private GameObject <Start>b__105_7() { }

	[CompilerGenerated]
	// RVA: 0x409040 Offset: 0x407640 VA: 0x180409040
	private GameObject <Start>b__105_8() { }

	[CompilerGenerated]
	// RVA: 0x4090E0 Offset: 0x4076E0 VA: 0x1804090E0
	private GameObject <Start>b__105_9() { }

	[CompilerGenerated]
	// RVA: 0x407DC0 Offset: 0x4063C0 VA: 0x180407DC0
	private GameObject <Start>b__105_10() { }

	[CompilerGenerated]
	// RVA: 0x407EC0 Offset: 0x4064C0 VA: 0x180407EC0
	private GameObject <Start>b__105_11() { }

	[CompilerGenerated]
	// RVA: 0x407F70 Offset: 0x406570 VA: 0x180407F70
	private GameObject <Start>b__105_12() { }

	[CompilerGenerated]
	// RVA: 0x408020 Offset: 0x406620 VA: 0x180408020
	private GameObject <Start>b__105_13() { }

	[CompilerGenerated]
	// RVA: 0x408060 Offset: 0x406660 VA: 0x180408060
	private GameObject <Start>b__105_14() { }

	[CompilerGenerated]
	// RVA: 0x4080A0 Offset: 0x4066A0 VA: 0x1804080A0
	private GameObject <Start>b__105_15() { }

	[CompilerGenerated]
	// RVA: 0x408150 Offset: 0x406750 VA: 0x180408150
	private GameObject <Start>b__105_16() { }

	[CompilerGenerated]
	// RVA: 0x408190 Offset: 0x406790 VA: 0x180408190
	private GameObject <Start>b__105_17() { }

	[CompilerGenerated]
	// RVA: 0x408230 Offset: 0x406830 VA: 0x180408230
	private GameObject <Start>b__105_18() { }

	[CompilerGenerated]
	// RVA: 0x408270 Offset: 0x406870 VA: 0x180408270
	private GameObject <Start>b__105_19() { }

	[CompilerGenerated]
	// RVA: 0x4083A0 Offset: 0x4069A0 VA: 0x1804083A0
	private GameObject <Start>b__105_20() { }

	[CompilerGenerated]
	// RVA: 0x4083E0 Offset: 0x4069E0 VA: 0x1804083E0
	private GameObject <Start>b__105_21() { }

	[CompilerGenerated]
	// RVA: 0x408420 Offset: 0x406A20 VA: 0x180408420
	private GameObject <Start>b__105_22() { }

	[CompilerGenerated]
	// RVA: 0x408460 Offset: 0x406A60 VA: 0x180408460
	private GameObject <Start>b__105_23() { }

	[CompilerGenerated]
	// RVA: 0x4084A0 Offset: 0x406AA0 VA: 0x1804084A0
	private GameObject <Start>b__105_24() { }

	[CompilerGenerated]
	// RVA: 0x408550 Offset: 0x406B50 VA: 0x180408550
	private GameObject <Start>b__105_25() { }

	[CompilerGenerated]
	// RVA: 0x408600 Offset: 0x406C00 VA: 0x180408600
	private GameObject <Start>b__105_26() { }

	[CompilerGenerated]
	// RVA: 0x408640 Offset: 0x406C40 VA: 0x180408640
	private GameObject <Start>b__105_27() { }

	[CompilerGenerated]
	// RVA: 0x408680 Offset: 0x406C80 VA: 0x180408680
	private GameObject <Start>b__105_28() { }

	[CompilerGenerated]
	// RVA: 0x4086C0 Offset: 0x406CC0 VA: 0x1804086C0
	private GameObject <Start>b__105_29() { }

	[CompilerGenerated]
	// RVA: 0x408850 Offset: 0x406E50 VA: 0x180408850
	private GameObject <Start>b__105_30() { }

	[CompilerGenerated]
	// RVA: 0x4088F0 Offset: 0x406EF0 VA: 0x1804088F0
	private GameObject <Start>b__105_31() { }

	[CompilerGenerated]
	// RVA: 0x408990 Offset: 0x406F90 VA: 0x180408990
	private GameObject <Start>b__105_32() { }

	[CompilerGenerated]
	// RVA: 0x408A30 Offset: 0x407030 VA: 0x180408A30
	private GameObject <Start>b__105_33() { }

	[CompilerGenerated]
	// RVA: 0x408AE0 Offset: 0x4070E0 VA: 0x180408AE0
	private GameObject <Start>b__105_34() { }

	[CompilerGenerated]
	// RVA: 0x408B80 Offset: 0x407180 VA: 0x180408B80
	private GameObject <Start>b__105_35() { }

	[CompilerGenerated]
	// RVA: 0x408BC0 Offset: 0x4071C0 VA: 0x180408BC0
	private GameObject <Start>b__105_36() { }

	[CompilerGenerated]
	// RVA: 0x408C00 Offset: 0x407200 VA: 0x180408C00
	private GameObject <Start>b__105_37() { }

	[CompilerGenerated]
	// RVA: 0x408C40 Offset: 0x407240 VA: 0x180408C40
	private GameObject <Start>b__105_38() { }

	[CompilerGenerated]
	// RVA: 0x408CE0 Offset: 0x4072E0 VA: 0x180408CE0
	private GameObject <Start>b__105_39() { }
}

