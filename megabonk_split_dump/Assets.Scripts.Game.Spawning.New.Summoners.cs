// Namespace: Assets.Scripts.Game.Spawning.New.Summoners
public class BossSummoner : BaseSummoner // TypeDefIndex: 5657
{
	// Methods

	// RVA: 0x44AAB0 Offset: 0x4490B0 VA: 0x18044AAB0
	public void .ctor(int id, List<EEnemy> defaultEnemies) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected override void Init() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 9
	protected override List<EEnemy> GetEnemies() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 10
	public override float GetSummonInterval() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 11
	public override float GetBaseCreditsPerSecond() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 12
	public override float GetInitialCredits() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 13
	public override int GetNumTargetEnemies() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 14
	protected override bool UseDirectionBias() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 15
	protected override bool ForceSpawn() { }
}

// Namespace: Assets.Scripts.Game.Spawning.New.Summoners
public class ChallengeSummoner : BaseSummoner // TypeDefIndex: 5658
{
	// Fields
	private List<EEnemy> enemyPool; // 0x60
	private Vector3 pos; // 0x68

	// Methods

	// RVA: 0x44CC70 Offset: 0x44B270 VA: 0x18044CC70
	public void .ctor(int id, List<EEnemy> defaultEnemies) { }

	// RVA: 0x44C610 Offset: 0x44AC10 VA: 0x18044C610 Slot: 8
	protected override void Init() { }

	// RVA: 0x44C960 Offset: 0x44AF60 VA: 0x18044C960
	public List<Enemy> SpawnEnemies(bool onlyElites, Vector3 position) { }

	// RVA: 0x44C990 Offset: 0x44AF90 VA: 0x18044C990 Slot: 6
	public override List<Enemy> SpendCredits(bool useWeights = True) { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0 Slot: 9
	protected override List<EEnemy> GetEnemies() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 10
	public override float GetSummonInterval() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 11
	public override float GetBaseCreditsPerSecond() { }

	// RVA: 0x44C560 Offset: 0x44AB60 VA: 0x18044C560 Slot: 12
	public override float GetInitialCredits() { }

	// RVA: 0x44C600 Offset: 0x44AC00 VA: 0x18044C600 Slot: 13
	public override int GetNumTargetEnemies() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 14
	protected override bool UseDirectionBias() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 15
	protected override bool ForceSpawn() { }
}

// Namespace: Assets.Scripts.Game.Spawning.New.Summoners
public class SpecialSkeletonSummoner : BaseSummoner // TypeDefIndex: 5659
{
	// Methods

	// RVA: 0x44AAB0 Offset: 0x4490B0 VA: 0x18044AAB0
	public void .ctor(int id, List<EEnemy> defaultEnemies) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected override void Init() { }

	// RVA: 0x461CE0 Offset: 0x4602E0 VA: 0x180461CE0 Slot: 9
	protected override List<EEnemy> GetEnemies() { }

	// RVA: 0x461E20 Offset: 0x460420 VA: 0x180461E20 Slot: 6
	public override List<Enemy> SpendCredits(bool useWeights = True) { }

	// RVA: 0x461E10 Offset: 0x460410 VA: 0x180461E10 Slot: 10
	public override float GetSummonInterval() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 11
	public override float GetBaseCreditsPerSecond() { }

	// RVA: 0x461E00 Offset: 0x460400 VA: 0x180461E00 Slot: 12
	public override float GetInitialCredits() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 13
	public override int GetNumTargetEnemies() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 14
	protected override bool UseDirectionBias() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 15
	protected override bool ForceSpawn() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	protected override bool UseMultiplier() { }
}

// Namespace: Assets.Scripts.Game.Spawning.New.Summoners
public class StageSummoner : BaseSummoner // TypeDefIndex: 5660
{
	// Fields
	private List<EEnemy> enemyPool; // 0x60
	private float capReduction; // 0x68

	// Methods

	// RVA: 0x461EF0 Offset: 0x4604F0 VA: 0x180461EF0
	public bool AddEnemyToPoolAndPickNewCard(List<EEnemy> eEnemy, out EEnemy selectedEnemy) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected override void Init() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 9
	protected override List<EEnemy> GetEnemies() { }

	// RVA: 0x4624F0 Offset: 0x460AF0 VA: 0x1804624F0 Slot: 10
	public override float GetSummonInterval() { }

	// RVA: 0x4622C0 Offset: 0x4608C0 VA: 0x1804622C0
	public float GetBaseCreditsPerSecondUncapped() { }

	// RVA: 0x462340 Offset: 0x460940 VA: 0x180462340 Slot: 11
	public override float GetBaseCreditsPerSecond() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 12
	public override float GetInitialCredits() { }

	// RVA: 0x4623F0 Offset: 0x4609F0 VA: 0x1804623F0 Slot: 13
	public override int GetNumTargetEnemies() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 14
	protected override bool UseDirectionBias() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 15
	protected override bool ForceSpawn() { }

	// RVA: 0x462550 Offset: 0x460B50 VA: 0x180462550
	private bool IsTargetEnemiesReached() { }

	// RVA: 0x4625F0 Offset: 0x460BF0 VA: 0x1804625F0
	public void .ctor(int id, List<EEnemy> defaultEnemies) { }
}

// Namespace: Assets.Scripts.Game.Spawning.New.Summoners
public class SwarmSummoner : BaseSummoner // TypeDefIndex: 5661
{
	// Fields
	private List<EEnemy> finalSwarmEnemies; // 0x60
	public const float swarmSummonInterval = 0.5;
	private int ghostTier; // 0x68
	private bool hasSwappedEnemy; // 0x6C
	private List<Enemy> spawnedEnemies; // 0x70
	private float swarmHpMultiplier; // 0x78
	private float swarmSpeedMultiplier; // 0x7C

	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected override void Init() { }

	// RVA: 0x4652C0 Offset: 0x4638C0 VA: 0x1804652C0 Slot: 4
	protected override void TickExtra() { }

	// RVA: 0x464E60 Offset: 0x463460 VA: 0x180464E60 Slot: 9
	protected override List<EEnemy> GetEnemies() { }

	// RVA: 0x465040 Offset: 0x463640 VA: 0x180465040 Slot: 10
	public override float GetSummonInterval() { }

	// RVA: 0x464CA0 Offset: 0x4632A0 VA: 0x180464CA0 Slot: 11
	public override float GetBaseCreditsPerSecond() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 12
	public override float GetInitialCredits() { }

	// RVA: 0x464EC0 Offset: 0x4634C0 VA: 0x180464EC0 Slot: 13
	public override int GetNumTargetEnemies() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 14
	protected override bool UseDirectionBias() { }

	// RVA: 0x465050 Offset: 0x463650 VA: 0x180465050 Slot: 6
	public override List<Enemy> SpendCredits(bool useWeights = True) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 15
	protected override bool ForceSpawn() { }

	// RVA: 0x465510 Offset: 0x463B10 VA: 0x180465510
	public void .ctor(int id, List<EEnemy> defaultEnemies) { }
}

