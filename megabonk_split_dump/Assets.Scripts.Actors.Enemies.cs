// Namespace: Assets.Scripts.Actors.Enemies
[Flags]
public enum EEnemyFlag // TypeDefIndex: 5714
{
	// Fields
	public int value__; // 0x0
	public const EEnemyFlag None = 0;
	public const EEnemyFlag Elite = 1;
	public const EEnemyFlag Boss = 2;
	public const EEnemyFlag StageBoss = 4;
	public const EEnemyFlag Challenge = 8;
	public const EEnemyFlag SummonerMiniboss = 16;
	public const EEnemyFlag FinalBoss = 32;
	public const EEnemyFlag AnyBoss = 54;
}

// Namespace: Assets.Scripts.Actors.Enemies
public enum EEnemyState // TypeDefIndex: 5715
{
	// Fields
	public int value__; // 0x0
	public const EEnemyState Default = 0;
	public const EEnemyState Teleporting = 1;
	public const EEnemyState Idle = 2;
}

// Namespace: Assets.Scripts.Actors.Enemies
public class Enemy : MonoBehaviour // TypeDefIndex: 5718
{
	// Fields
	[CompilerGenerated]
	private EnemyData <enemyData>k__BackingField; // 0x20
	public AnimatedMesh animatedMesh; // 0x28
	public Renderer renderer; // 0x30
	public EnemyRenderer enemyRenderer; // 0x38
	[CompilerGenerated]
	private float <meshHeight>k__BackingField; // 0x40
	[CompilerGenerated]
	private float <meshRadius>k__BackingField; // 0x44
	public Rigidbody rb; // 0x48
	public CapsuleCollider collider; // 0x50
	public EnemyMovementRb enemyMovement; // 0x58
	public Material whiteMaterial; // 0x60
	public EnemyDissolve dissolve; // 0x68
	private float flashTime; // 0x70
	[CompilerGenerated]
	private Vector3 <feetOffset>k__BackingField; // 0x74
	[CompilerGenerated]
	private float <hp>k__BackingField; // 0x80
	public float maxHp; // 0x84
	[CompilerGenerated]
	private uint <id>k__BackingField; // 0x88
	[CompilerGenerated]
	private int <waveNumber>k__BackingField; // 0x8C
	[CompilerGenerated]
	private Rigidbody <target>k__BackingField; // 0x90
	private float despawnAtTime; // 0x98
	[CompilerGenerated]
	private float <spawnedAtTime>k__BackingField; // 0x9C
	public EEnemyState state; // 0xA0
	private float eliteScaleMultiplier; // 0xA4
	private SpecialAttackController specialAttackController; // 0xA8
	public static int deaths; // 0x0
	public static Action<Enemy, DamageContainer> A_EnemyDied; // 0x8
	public static Action<Enemy> A_EnemyDiedPre; // 0x10
	public static Action<Enemy> A_EnemySpawned; // 0x18
	public static Action<Enemy> A_EnemyReleasedFromPool; // 0x20
	public static Action<Enemy> A_TargetOfInterestSpawn; // 0x28
	public static Action<Enemy, DamageContainer> A_Damage; // 0x30
	public Action<Enemy, DamageContainer> A_DamageNonStatic; // 0xB0
	public static Action<Enemy> A_HealthChange; // 0x38
	private float controlHp; // 0xB8
	private EEnemyFlag enemyFlag; // 0xBC
	private float maxDespawnTime; // 0xC0
	private float speedMultiplier; // 0xC4
	private EnemyStatusSymbols statusSymbols; // 0xC8
	private EEnemyFlag eliteChallengeFlags; // 0xD0
	private Vector3 defaultScale; // 0xD4
	private Outline outline; // 0xE0
	public float teleportTime; // 0xE8
	public static float defaultTeleportTime; // 0x40
	public static Action A_HpTamper; // 0x48
	private float echoDamage; // 0xEC
	private static int normalHits; // 0x50
	private static int executeHits; // 0x54
	private float stopFlashTime; // 0xF0
	private float readyToFlashTime; // 0xF4
	public float flashInterval; // 0xF8
	private bool flashing; // 0xFC
	private bool isInvulnerable; // 0xFD
	public static Action<Enemy, bool> A_InvulnerableChanged; // 0x58
	private bool isDyingNextFrame; // 0xFE
	private bool deathFunctionCalled; // 0xFF
	private float startTeleportThresholdDistance; // 0x100
	private float lastTeleportTime; // 0x104
	public Dictionary<EDebuff, EnemyDebuff> debuffs; // 0x108
	public HashSet<EDebuff> debuffsToRemove; // 0x110
	private Dictionary<EDebuff, AddDebuffContainer> debuffsToAdd; // 0x118
	public Action<EDebuff> A_DebuffAdded; // 0x120
	public Action<EDebuff> A_DebuffRemoved; // 0x128
	private Dictionary<EDebuff, int> debuffCounts; // 0x130
	private int maxStunsAndFreezes; // 0x138
	private float nextVerifyTime; // 0x13C
	private float nextTeleportTimeCheck; // 0x140
	private float teleportCheckInterval; // 0x144
	private float minStayAtDistance; // 0x148
	private float maxStayAtDistance; // 0x14C
	private bool allowSpecialAttacks; // 0x150
	private float basePowerupDropChance; // 0x154

	// Properties
	public EnemyData enemyData { get; set; }
	public float meshHeight { get; set; }
	public float meshRadius { get; set; }
	public Vector3 feetOffset { get; set; }
	public float hp { get; set; }
	public uint id { get; set; }
	public int waveNumber { get; set; }
	public Rigidbody target { get; set; }
	public float spawnedAtTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public EnemyData get_enemyData() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_enemyData(EnemyData value) { }

	[CompilerGenerated]
	// RVA: 0x46A6E0 Offset: 0x468CE0 VA: 0x18046A6E0
	public float get_meshHeight() { }

	[CompilerGenerated]
	// RVA: 0x46E240 Offset: 0x46C840 VA: 0x18046E240
	private void set_meshHeight(float value) { }

	[CompilerGenerated]
	// RVA: 0x46E1F0 Offset: 0x46C7F0 VA: 0x18046E1F0
	public float get_meshRadius() { }

	[CompilerGenerated]
	// RVA: 0x46E250 Offset: 0x46C850 VA: 0x18046E250
	private void set_meshRadius(float value) { }

	[CompilerGenerated]
	// RVA: 0x46E1C0 Offset: 0x46C7C0 VA: 0x18046E1C0
	public Vector3 get_feetOffset() { }

	[CompilerGenerated]
	// RVA: 0x46E220 Offset: 0x46C820 VA: 0x18046E220
	private void set_feetOffset(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x46E1E0 Offset: 0x46C7E0 VA: 0x18046E1E0
	public float get_hp() { }

	[CompilerGenerated]
	// RVA: 0x46E230 Offset: 0x46C830 VA: 0x18046E230
	public void set_hp(float value) { }

	[CompilerGenerated]
	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90
	public uint get_id() { }

	[CompilerGenerated]
	// RVA: 0x3AAD20 Offset: 0x3A9320 VA: 0x1803AAD20
	private void set_id(uint value) { }

	[CompilerGenerated]
	// RVA: 0x46E210 Offset: 0x46C810 VA: 0x18046E210
	public int get_waveNumber() { }

	[CompilerGenerated]
	// RVA: 0x46E280 Offset: 0x46C880 VA: 0x18046E280
	public void set_waveNumber(int value) { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public Rigidbody get_target() { }

	[CompilerGenerated]
	// RVA: 0x46E260 Offset: 0x46C860 VA: 0x18046E260
	private void set_target(Rigidbody value) { }

	[CompilerGenerated]
	// RVA: 0x46E200 Offset: 0x46C800 VA: 0x18046E200
	public float get_spawnedAtTime() { }

	[CompilerGenerated]
	// RVA: 0x372F40 Offset: 0x371540 VA: 0x180372F40
	private void set_spawnedAtTime(float value) { }

	// RVA: 0x46AB30 Offset: 0x469130 VA: 0x18046AB30
	public void InitEnemy(uint id, EnemyData enemyData, Vector3 pos, int waveNumber, EEnemyFlag flag = 0, bool canBeElite = True) { }

	// RVA: 0x46D0B0 Offset: 0x46B6B0 VA: 0x18046D0B0
	public void SetSpeedMultiplier(float f) { }

	// RVA: 0x46D240 Offset: 0x46B840 VA: 0x18046D240
	public void SetSwarmMultiplierHp(float f) { }

	// RVA: 0x46A720 Offset: 0x468D20 VA: 0x18046A720
	public float GetSpeed() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	public int GetMoney() { }

	// RVA: 0x46A2D0 Offset: 0x4688D0 VA: 0x18046A2D0
	private void Freeze() { }

	// RVA: 0x46DC90 Offset: 0x46C290 VA: 0x18046DC90
	private void UnFreeze() { }

	// RVA: 0x468D50 Offset: 0x467350 VA: 0x180468D50
	private void CheckScale() { }

	// RVA: 0x46BF10 Offset: 0x46A510 VA: 0x18046BF10
	public void MakeChallenge() { }

	// RVA: 0x468DD0 Offset: 0x4673D0 VA: 0x180468DD0
	private void CheckStatusSymbols() { }

	// RVA: 0x46A900 Offset: 0x468F00 VA: 0x18046A900
	public void Heal(int amount) { }

	// RVA: 0x46D050 Offset: 0x46B650 VA: 0x18046D050
	private void SetBoss() { }

	// RVA: 0x46D0C0 Offset: 0x46B6C0 VA: 0x18046D0C0
	public void SetSummonerMiniboss() { }

	// RVA: 0x46BD30 Offset: 0x46A330 VA: 0x18046BD30
	public bool IsStageBoss() { }

	// RVA: 0x46BA80 Offset: 0x46A080 VA: 0x18046BA80
	public bool IsBoss() { }

	// RVA: 0x46BBA0 Offset: 0x46A1A0 VA: 0x18046BBA0
	public bool IsElite() { }

	// RVA: 0x46BAD0 Offset: 0x46A0D0 VA: 0x18046BAD0
	public bool IsChallenge() { }

	// RVA: 0x46BB50 Offset: 0x46A150 VA: 0x18046BB50
	public bool IsEliteChallenge() { }

	// RVA: 0x46BBF0 Offset: 0x46A1F0 VA: 0x18046BBF0
	public bool IsFinalBoss() { }

	// RVA: 0x46D090 Offset: 0x46B690 VA: 0x18046D090
	public void SetMinibossGoon(float hp) { }

	// RVA: 0x467FF0 Offset: 0x4665F0 VA: 0x180467FF0
	private void AddStatusSymbols() { }

	// RVA: 0x46CEB0 Offset: 0x46B4B0 VA: 0x18046CEB0
	private void RemoveStatusSymbols() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void ResetUi() { }

	// RVA: 0x468340 Offset: 0x466940 VA: 0x180468340
	private void Awake() { }

	// RVA: 0x46C400 Offset: 0x46AA00 VA: 0x18046C400
	private void OnDestroy() { }

	// RVA: 0x46C850 Offset: 0x46AE50 VA: 0x18046C850
	private void OnStatusEffectAdded(EStatusEffect eStatusEffect, bool newEffect) { }

	// RVA: 0x46C890 Offset: 0x46AE90 VA: 0x18046C890
	private void OnStatusEffectRemoved(EStatusEffect eStatusEffect) { }

	[IteratorStateMachine(typeof(Enemy.<StartTeleporting>d__94))]
	// RVA: 0x46D2A0 Offset: 0x46B8A0 VA: 0x18046D2A0
	private IEnumerator StartTeleporting(Vector3 toPosition, bool skipStart = False) { }

	[IteratorStateMachine(typeof(Enemy.<Despawn>d__95))]
	// RVA: 0x469C50 Offset: 0x468250 VA: 0x180469C50
	private IEnumerator Despawn() { }

	// RVA: 0x4693C0 Offset: 0x4679C0 VA: 0x1804693C0
	public void DamageFromPlayerWeapon(DamageContainer dc) { }

	// RVA: 0x469320 Offset: 0x467920 VA: 0x180469320
	public void DamageFromPlayerOther(DamageContainer dc) { }

	// RVA: 0x469310 Offset: 0x467910 VA: 0x180469310
	public void DamageExternal(DamageContainer dc) { }

	// RVA: 0x46A8A0 Offset: 0x468EA0 VA: 0x18046A8A0
	public bool HasDebuff(EDebuff debuff) { }

	// RVA: 0x46CAA0 Offset: 0x46B0A0 VA: 0x18046CAA0
	public void ReleaseEcho() { }

	// RVA: 0x469460 Offset: 0x467A60 VA: 0x180469460
	private void Damage(DamageContainer damageContainer) { }

	// RVA: 0x46BFD0 Offset: 0x46A5D0 VA: 0x18046BFD0
	public void MakeWhite() { }

	// RVA: 0x46BDF0 Offset: 0x46A3F0 VA: 0x18046BDF0
	public void Kill() { }

	// RVA: 0x4688A0 Offset: 0x466EA0 VA: 0x1804688A0
	public bool CanTakeDamage() { }

	// RVA: 0x46BF20 Offset: 0x46A520 VA: 0x18046BF20
	public void MakeInvulnerable(bool invulnerable) { }

	// RVA: 0x469CC0 Offset: 0x4682C0 VA: 0x180469CC0
	public void DiedNextFrame() { }

	// RVA: 0x469E70 Offset: 0x468470 VA: 0x180469E70
	private void EnemyDied() { }

	// RVA: 0x469D50 Offset: 0x468350 VA: 0x180469D50
	public void EnemyDied(DamageContainer dc) { }

	// RVA: 0x46C830 Offset: 0x46AE30 VA: 0x18046C830
	private void OnPaused(bool paused) { }

	// RVA: 0x46C820 Offset: 0x46AE20 VA: 0x18046C820
	private void OnDissolveFinished() { }

	// RVA: 0x46CC60 Offset: 0x46B260 VA: 0x18046CC60
	private void ReleaseToPoolNextFrame() { }

	// RVA: 0x46CCA0 Offset: 0x46B2A0 VA: 0x18046CCA0
	public void ReleaseToPool() { }

	// RVA: 0x46C030 Offset: 0x46A630 VA: 0x18046C030
	public void MyFixedUpdate() { }

	// RVA: 0x467E00 Offset: 0x466400 VA: 0x180467E00
	public void AddDebuff(EDebuff eDebuff, DamageContainer dc, float duration, int stacks = 1) { }

	// RVA: 0x467B80 Offset: 0x466180 VA: 0x180467B80
	private void AddDebuffImplementation(AddDebuffContainer debuffContainer) { }

	// RVA: 0x46CDC0 Offset: 0x46B3C0 VA: 0x18046CDC0
	public void RemoveDebuff(EDebuff debuff, bool fromDeath) { }

	// RVA: 0x469910 Offset: 0x467F10 VA: 0x180469910
	public void DebuffTick() { }

	// RVA: 0x46C8D0 Offset: 0x46AED0 VA: 0x18046C8D0
	public void QueueClearAllDebuffs() { }

	// RVA: 0x469150 Offset: 0x467750 VA: 0x180469150
	public void ClearAllDebuffs() { }

	// RVA: 0x4688D0 Offset: 0x466ED0 VA: 0x1804688D0
	public void Charm(DamageContainer dc, float duration) { }

	// RVA: 0x46CA20 Offset: 0x46B020 VA: 0x18046CA20
	public void ReleaseCharm() { }

	// RVA: 0x469F30 Offset: 0x468530 VA: 0x180469F30
	public void FindTarget() { }

	// RVA: 0x46DCD0 Offset: 0x46C2D0 VA: 0x18046DCD0
	private void VerifyPosition() { }

	// RVA: 0x46D340 Offset: 0x46B940 VA: 0x18046D340
	public void TeleportToPlayer() { }

	// RVA: 0x46D430 Offset: 0x46BA30 VA: 0x18046D430
	private void TryDespawn() { }

	// RVA: 0x46BDE0 Offset: 0x46A3E0 VA: 0x18046BDE0
	public bool IsTeleporting() { }

	// RVA: 0x46D540 Offset: 0x46BB40 VA: 0x18046D540
	private void TryTeleport() { }

	// RVA: 0x46D270 Offset: 0x46B870 VA: 0x18046D270
	public void StartSpecialAttack() { }

	// RVA: 0x469D20 Offset: 0x468320 VA: 0x180469D20
	public void EndSpecialAttack() { }

	// RVA: 0x46C3B0 Offset: 0x46A9B0 VA: 0x18046C3B0
	public void MyUpdate() { }

	// RVA: 0x4687D0 Offset: 0x466DD0 VA: 0x1804687D0
	public bool CanMove() { }

	// RVA: 0x46BCC0 Offset: 0x46A2C0 VA: 0x18046BCC0
	public bool IsRunningFromPlayer() { }

	// RVA: 0x46BD80 Offset: 0x46A380 VA: 0x18046BD80
	private bool IsStationary() { }

	// RVA: 0x46A830 Offset: 0x468E30 VA: 0x18046A830
	public int GetXp() { }

	// RVA: 0x46D010 Offset: 0x46B610 VA: 0x18046D010
	private void ResetMaterial() { }

	// RVA: 0x46BB40 Offset: 0x46A140 VA: 0x18046BB40
	public bool IsDead() { }

	// RVA: 0x46BB20 Offset: 0x46A120 VA: 0x18046BB20
	public bool IsDeadOrDyingNextFrame() { }

	// RVA: 0x46A3F0 Offset: 0x4689F0 VA: 0x18046A3F0
	public Vector3 GetCenterPosition() { }

	// RVA: 0x46A440 Offset: 0x468A40 VA: 0x18046A440
	public Vector3 GetFeetPosition() { }

	// RVA: 0x46A5F0 Offset: 0x468BF0 VA: 0x18046A5F0
	public Vector3 GetHeadPosition() { }

	// RVA: 0x46A490 Offset: 0x468A90 VA: 0x18046A490
	public Vector3 GetGroundCheckPosition() { }

	// RVA: 0x46BC40 Offset: 0x46A240 VA: 0x18046BC40
	public bool IsImportantEnemy() { }

	// RVA: 0x46A6E0 Offset: 0x468CE0 VA: 0x18046A6E0
	public float GetHeight() { }

	// RVA: 0x469D10 Offset: 0x468310 VA: 0x180469D10
	public void DisableSpecialAttacks() { }

	// RVA: 0x46A310 Offset: 0x468910 VA: 0x18046A310
	public Vector3 GetBottomPosition() { }

	// RVA: 0x46A710 Offset: 0x468D10 VA: 0x18046A710
	public float GetPowerupDropChance() { }

	// RVA: 0x46A6F0 Offset: 0x468CF0 VA: 0x18046A6F0
	public float GetHpRatio() { }

	// RVA: 0x46DF60 Offset: 0x46C560 VA: 0x18046DF60
	public void .ctor() { }

	// RVA: 0x46DF20 Offset: 0x46C520 VA: 0x18046DF20
	private static void .cctor() { }
}

