// Namespace: Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations
public class EnemySpecialAttackFollowing : EnemySpecialAttackPrefab // TypeDefIndex: 5682
{
	// Fields
	public bool grounded; // 0x50
	public bool predictive; // 0x51
	public float delayBetweenHits; // 0x54
	public int numHits; // 0x58
	private int numSpawned; // 0x5C

	// Methods

	// RVA: 0x450780 Offset: 0x44ED80 VA: 0x180450780 Slot: 4
	protected override void Init() { }

	[IteratorStateMachine(typeof(EnemySpecialAttackFollowing.<DoAttack>d__5))]
	// RVA: 0x450710 Offset: 0x44ED10 VA: 0x180450710
	private IEnumerator DoAttack() { }

	// RVA: 0x4508C0 Offset: 0x44EEC0 VA: 0x1804508C0
	private void SpawnHitEffect(Vector3 pos) { }

	// RVA: 0x450CB0 Offset: 0x44F2B0 VA: 0x180450CB0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations
public abstract class EnemySpecialAttackPrefab : MonoBehaviour // TypeDefIndex: 5684
{
	// Fields
	public GameObject attackEffectPrefab; // 0x20
	public EEnemyAttack eAttack; // 0x28
	[CompilerGenerated]
	private EnemySpecialAttack <specialAttack>k__BackingField; // 0x30
	protected Enemy enemy; // 0x38
	protected CircleWarning circleWarning; // 0x40
	private bool isActive; // 0x48

	// Properties
	public EnemySpecialAttack specialAttack { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public EnemySpecialAttack get_specialAttack() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_specialAttack(EnemySpecialAttack value) { }

	// RVA: 0x451BB0 Offset: 0x4501B0 VA: 0x180451BB0
	public void Set(EnemySpecialAttack attack, Enemy enemy) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Init();

	// RVA: 0x4517D0 Offset: 0x44FDD0 VA: 0x1804517D0
	protected void CreateWarningSphere(Vector3 pos, Action completeAction) { }

	// RVA: 0x4516E0 Offset: 0x44FCE0 VA: 0x1804516E0
	protected bool CreateWarningHitscan(Vector3 pos, Vector3 dir, float distance, Action completeAction) { }

	// RVA: 0x4518D0 Offset: 0x44FED0 VA: 0x1804518D0
	protected GameObject GetEffectPrefab() { }

	// RVA: 0x451590 Offset: 0x44FB90 VA: 0x180451590
	private void Awake() { }

	// RVA: 0x451940 Offset: 0x44FF40 VA: 0x180451940
	private void OnDestroy() { }

	// RVA: 0x451A90 Offset: 0x450090 VA: 0x180451A90
	private void OnEnemyDied(Enemy enemy) { }

	// RVA: 0x451B10 Offset: 0x450110 VA: 0x180451B10
	protected void ReturnToPool() { }

	[IteratorStateMachine(typeof(EnemySpecialAttackPrefab.<WaitForSecondsCustom>d__18))]
	// RVA: 0x451C00 Offset: 0x450200 VA: 0x180451C00
	protected IEnumerator WaitForSecondsCustom(float time) { }

	// RVA: 0x4518A0 Offset: 0x44FEA0 VA: 0x1804518A0
	protected DcFlags GetDamageFlags() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

// Namespace: Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations
public class EnemySpecialAttackPrefabSingle : EnemySpecialAttackPrefab // TypeDefIndex: 5685
{
	// Fields
	public bool grounded; // 0x50
	public bool predictive; // 0x51

	// Methods

	// RVA: 0x450CD0 Offset: 0x44F2D0 VA: 0x180450CD0 Slot: 4
	protected override void Init() { }

	// RVA: 0x4510E0 Offset: 0x44F6E0 VA: 0x1804510E0
	private void SpawnHitEffect() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

