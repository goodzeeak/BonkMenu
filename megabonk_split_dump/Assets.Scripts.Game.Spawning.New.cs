// Namespace: Assets.Scripts.Game.Spawning.New
public class EnemyCard // TypeDefIndex: 5649
{
	// Fields
	private float costInfluenceOnWeight; // 0x10
	public EnemyData enemy; // 0x18
	public bool isElite; // 0x20
	public float cost; // 0x24
	public float weight; // 0x28

	// Methods

	// RVA: 0x44FB70 Offset: 0x44E170 VA: 0x18044FB70
	public void .ctor(EnemyData enemy, bool isElite) { }

	// RVA: 0x44F9E0 Offset: 0x44DFE0 VA: 0x18044F9E0
	public void RefreshWeightAndCost() { }

	// RVA: 0x44FA70 Offset: 0x44E070 VA: 0x18044FA70
	public string ToString() { }
}

// Namespace: Assets.Scripts.Game.Spawning.New
public abstract class BaseSummoner // TypeDefIndex: 5651
{
	// Fields
	protected float credits; // 0x10
	private List<EnemyCard> cards; // 0x18
	private float giveCreditsTimer; // 0x20
	private float spendCreditsTimer; // 0x24
	public const int maxEnemiesPerSecond = 500;
	public const int maxEnemiesPerCycle = 200;
	protected int enemiesThisSecond; // 0x28
	private int nextSecond; // 0x2C
	protected int id; // 0x30
	public bool slowmode; // 0x34
	private float slowmodeMultiplier; // 0x38
	private float slowmodeOverAtTime; // 0x3C
	private bool isWaveMode; // 0x40
	private float waveModeOverAtTime; // 0x44
	private List<EnemyCard> waveModeCards; // 0x48
	protected List<EEnemy> currentEnemies; // 0x50
	private List<Enemy> spawnedEnemies; // 0x58

	// Methods

	// RVA: 0x44A750 Offset: 0x448D50 VA: 0x18044A750
	public void .ctor(int id, List<EEnemy> defaultEnemies) { }

	// RVA: 0x449020 Offset: 0x447620 VA: 0x180449020
	public void Cleanup() { }

	// RVA: 0x44A490 Offset: 0x448A90 VA: 0x18044A490
	public void Tick() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	protected virtual void TickExtra() { }

	// RVA: 0x449260 Offset: 0x447860 VA: 0x180449260
	protected void GenerateCardsForSummoner(List<EEnemy> enemies) { }

	// RVA: 0x4492A0 Offset: 0x4478A0 VA: 0x1804492A0 Slot: 5
	protected virtual List<EnemyCard> GenerateCards(List<EEnemy> enemies) { }

	// RVA: 0x449DD0 Offset: 0x4483D0 VA: 0x180449DD0
	private void RefreshCardWeights() { }

	// RVA: 0x448EF0 Offset: 0x4474F0 VA: 0x180448EF0
	public void AddCredits() { }

	// RVA: 0x4497C0 Offset: 0x447DC0 VA: 0x1804497C0
	public float GetCreditsPerSecond() { }

	// RVA: 0x44A240 Offset: 0x448840 VA: 0x18044A240 Slot: 6
	public virtual List<Enemy> SpendCredits(bool useWeights = True) { }

	// RVA: 0x4498E0 Offset: 0x447EE0 VA: 0x1804498E0
	protected EnemyCard GetRandomCard(bool useWeights) { }

	// RVA: 0x44A120 Offset: 0x448720 VA: 0x18044A120
	public void SetSlowmode(float multiplier, float duration) { }

	// RVA: 0x44A1A0 Offset: 0x4487A0 VA: 0x18044A1A0
	public void SetWaveMode(List<EEnemy> waveEnemies, float duration) { }

	// RVA: 0x449800 Offset: 0x447E00 VA: 0x180449800
	protected float GetMultiplier() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 7
	protected virtual bool UseMultiplier() { }

	// RVA: 0x448FB0 Offset: 0x4475B0 VA: 0x180448FB0
	private bool CanEarnCredits() { }

	// RVA: 0x449DC0 Offset: 0x4483C0 VA: 0x180449DC0
	private void OnStatUpdated(EStat stat) { }

	// RVA: 0x449DB0 Offset: 0x4483B0 VA: 0x180449DB0
	private void OnPlayerInventoryInitialized(PlayerInventory playerInventory) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void Init();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract List<EEnemy> GetEnemies();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float GetSummonInterval();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float GetBaseCreditsPerSecond();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float GetInitialCredits();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetNumTargetEnemies();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract bool UseDirectionBias();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract bool ForceSpawn();
}

// Namespace: Assets.Scripts.Game.Spawning.New
public class SummonerController // TypeDefIndex: 5652
{
	// Fields
	public StageSummoner stageSummoner; // 0x10
	private SpecialSkeletonSummoner specialSkeletonSummoner; // 0x18
	private BaseSummoner swarmSummoner; // 0x20
	private BaseSummoner finalSwarmSummoner; // 0x28
	private List<BaseSummoner> summoners; // 0x30
	private int id; // 0x38
	private int currentTimelineEvent; // 0x3C
	private StageTimeline timeline; // 0x40
	public static Action A_SwarmStarted; // 0x0
	public static Action A_FinalSwarmStarted; // 0x8
	public static Action A_MiniBoss; // 0x10
	private float lastAddedNewEnemyTime; // 0x48
	private bool hadEventThisTick; // 0x4C
	private float swarmOverAtTime; // 0x50
	[CompilerGenerated]
	private int <minibossCount>k__BackingField; // 0x54
	private List<EEnemy> minibossPool; // 0x58
	private bool isFinalSwarmStarted; // 0x60
	private float bossDeadGracePeriod; // 0x64
	private bool isFinalBossDead; // 0x68
	private bool areSummonersDestroyed; // 0x69

	// Properties
	public int minibossCount { get; set; }

	// Methods

	// RVA: 0x464940 Offset: 0x462F40 VA: 0x180464940
	public void .ctor() { }

	// RVA: 0x464400 Offset: 0x462A00 VA: 0x180464400
	public void Tick() { }

	// RVA: 0x463750 Offset: 0x461D50 VA: 0x180463750
	public float GetMaxTimeLength() { }

	// RVA: 0x463FD0 Offset: 0x4625D0 VA: 0x180463FD0
	private void TickTimeline() { }

	// RVA: 0x464540 Offset: 0x462B40 VA: 0x180464540
	private void TryAddNewEnemyCard() { }

	// RVA: 0x463C00 Offset: 0x462200 VA: 0x180463C00
	public void StartEvent(int eventIndex) { }

	// RVA: 0x4635C0 Offset: 0x461BC0 VA: 0x1804635C0
	private void EventSwarm(TimelineEvent timelineEvent) { }

	[CompilerGenerated]
	// RVA: 0x464C80 Offset: 0x463280 VA: 0x180464C80
	public int get_minibossCount() { }

	[CompilerGenerated]
	// RVA: 0x464C90 Offset: 0x463290 VA: 0x180464C90
	private void set_minibossCount(int value) { }

	// RVA: 0x462EB0 Offset: 0x4614B0 VA: 0x180462EB0
	public void EventMiniboss(TimelineEvent timelineEvent) { }

	// RVA: 0x462C40 Offset: 0x461240 VA: 0x180462C40
	private bool CanAddNewEnemyCard() { }

	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810
	public bool IsFinalSwarm() { }

	// RVA: 0x463E40 Offset: 0x462440 VA: 0x180463E40
	private void StartFinalSwarm() { }

	// RVA: 0x462B90 Offset: 0x461190 VA: 0x180462B90
	private void AddSummoner(BaseSummoner summoner) { }

	// RVA: 0x462E40 Offset: 0x461440 VA: 0x180462E40
	private void DestroySummoner(BaseSummoner summoner) { }

	// RVA: 0x463900 Offset: 0x461F00 VA: 0x180463900
	public List<Enemy> SpawnStageBoss(Vector3 pos) { }

	// RVA: 0x4637B0 Offset: 0x461DB0 VA: 0x1804637B0
	private void OnBossDied(bool isLastStage) { }

	// RVA: 0x464760 Offset: 0x462D60 VA: 0x180464760
	private void TryStopSummoners() { }

	// RVA: 0x462C60 Offset: 0x461260 VA: 0x180462C60
	public void Cleanup() { }
}

