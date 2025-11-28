// Namespace: Assets.Scripts.Managers
public class ButtonManager // TypeDefIndex: 5461
{
	// Fields
	private static MyButton selectedButton2; // 0x0
	public static Action<MyButton> A_ButtonHover; // 0x8
	public static bool enabled; // 0x10

	// Methods

	// RVA: 0x3F2C10 Offset: 0x3F1210 VA: 0x1803F2C10
	public static void Refresh() { }

	// RVA: 0x3F2C70 Offset: 0x3F1270 VA: 0x1803F2C70
	public static void SetFirstButton(MyButton button) { }

	// RVA: 0x3F2980 Offset: 0x3F0F80 VA: 0x1803F2980
	public static void ForceHoverButton(MyButton btn) { }

	// RVA: 0x3F2E10 Offset: 0x3F1410 VA: 0x1803F2E10
	public static void StartedHoveringButton(MyButton button) { }

	// RVA: 0x3F2D60 Offset: 0x3F1360 VA: 0x1803F2D60
	public static void SetNull() { }

	// RVA: 0x3F2BC0 Offset: 0x3F11C0 VA: 0x1803F2BC0
	public static MyButton GetCurrentButton() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x3F2F70 Offset: 0x3F1570 VA: 0x1803F2F70
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Managers
public class EnemyManager : MonoBehaviour // TypeDefIndex: 5462
{
	// Fields
	public EnemyData testEnemy; // 0x20
	public Dictionary<uint, Enemy> enemies; // 0x28
	public Dictionary<Collider, Enemy> collidersToEnemies; // 0x30
	public Dictionary<GameObject, Enemy> gameobjectsToEnemies; // 0x38
	private Dictionary<int, int> waveEnemies; // 0x40
	private uint id; // 0x48
	public static EnemyManager Instance; // 0x0
	public bool enabledWaves; // 0x4C
	public SummonerController summonerController; // 0x50
	private List<Enemy> stageBosses; // 0x58
	public static Action A_StageBossDied; // 0x8
	[CompilerGenerated]
	private bool <stageBossIsDead>k__BackingField; // 0x60
	public static int maxNumEnemiesPooled; // 0x10
	public int numEnemies; // 0x64
	private float nextDebuffTickTime; // 0x68
	private float zoomValue; // 0x6C
	private float currentValue; // 0x70
	private bool started; // 0x74

	// Properties
	public bool stageBossIsDead { get; set; }

	// Methods

	// RVA: 0x3F2FB0 Offset: 0x3F15B0 VA: 0x1803F2FB0
	private void Awake() { }

	// RVA: 0x3F44B0 Offset: 0x3F2AB0 VA: 0x1803F44B0
	private void Start() { }

	// RVA: 0x3F3820 Offset: 0x3F1E20 VA: 0x1803F3820
	private void OnDestroy() { }

	// RVA: 0x3F42B0 Offset: 0x3F28B0 VA: 0x1803F42B0
	public Enemy SpawnEnemy(EnemyData enemyData, int summonerId, bool forceSpawn, EEnemyFlag flag = 0, bool useDirectionBias = True) { }

	// RVA: 0x3F3DE0 Offset: 0x3F23E0 VA: 0x1803F3DE0
	public Enemy SpawnEnemy(EnemyData enemyData, Vector3 pos, int waveNumber, bool forceSpawn = False, EEnemyFlag flag = 0, bool canBeElite = True) { }

	// RVA: 0x3F3BF0 Offset: 0x3F21F0 VA: 0x1803F3BF0
	public Enemy SpawnBoss(EEnemy eEnemy, int summonerId, EEnemyFlag enemyFlag, Vector3 pos) { }

	// RVA: 0x3F39F0 Offset: 0x3F1FF0 VA: 0x1803F39F0
	public void RemoveEnemy(Enemy enemy) { }

	// RVA: 0x3F43F0 Offset: 0x3F29F0 VA: 0x1803F43F0
	private void StageBossDied() { }

	[CompilerGenerated]
	// RVA: 0x37F810 Offset: 0x37DE10 VA: 0x18037F810
	public bool get_stageBossIsDead() { }

	[CompilerGenerated]
	// RVA: 0x37F820 Offset: 0x37DE20 VA: 0x18037F820
	private void set_stageBossIsDead(bool value) { }

	// RVA: 0x3F31E0 Offset: 0x3F17E0 VA: 0x1803F31E0
	public bool CanSpawnEnemy() { }

	// RVA: 0x3F37E0 Offset: 0x3F1DE0 VA: 0x1803F37E0
	public bool HasMaxEnemies() { }

	// RVA: 0x3F3750 Offset: 0x3F1D50 VA: 0x1803F3750
	public int GetNumMaxEnemies() { }

	// RVA: 0x3F3740 Offset: 0x3F1D40 VA: 0x1803F3740
	public int GetNumEnemies() { }

	// RVA: 0x3F3540 Offset: 0x3F1B40 VA: 0x1803F3540
	public int GetEnemiesFromSummoner(int wave) { }

	// RVA: 0x3F3800 Offset: 0x3F1E00 VA: 0x1803F3800
	public bool IsFinalSwarm() { }

	// RVA: 0x3F4510 Offset: 0x3F2B10 VA: 0x1803F4510
	private void Update() { }

	// RVA: 0x3F3200 Offset: 0x3F1800 VA: 0x1803F3200
	private void FixedUpdate() { }

	// RVA: 0x3F35D0 Offset: 0x3F1BD0 VA: 0x1803F35D0
	public bool GetEnemy(Collider collider, out Enemy enemy) { }

	// RVA: 0x3F36B0 Offset: 0x3F1CB0 VA: 0x1803F36B0
	public bool GetEnemy(GameObject enemyObject, out Enemy enemy) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	private void TestSpawnEnemy() { }

	// RVA: 0x3F4690 Offset: 0x3F2C90 VA: 0x1803F4690
	public void .ctor() { }

	// RVA: 0x3F4650 Offset: 0x3F2C50 VA: 0x1803F4650
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.Managers
public class IconManager : MonoBehaviour // TypeDefIndex: 5463
{
	// Fields
	public Texture poisonIcon; // 0x20
	public Texture burnIcon; // 0x28
	public Texture thornsIcon; // 0x30
	public Texture echoIcon; // 0x38
	public Texture bloodmarkIcon; // 0x40
	public Texture zapIcon; // 0x48
	public Texture questionMark; // 0x50
	public Texture[] rankIcons; // 0x58
	public Texture rankFrameIcon; // 0x60
	public static IconManager Instance; // 0x0

	// Methods

	// RVA: 0x3F8450 Offset: 0x3F6A50 VA: 0x1803F8450
	private void Awake() { }

	// RVA: 0x3F8530 Offset: 0x3F6B30 VA: 0x1803F8530
	public Texture GetDebuffIcon(EDebuff debuff) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Managers
public class MapController // TypeDefIndex: 5464
{
	// Fields
	private static PlayerInventory inventory; // 0x0
	public static int index; // 0x8
	[CompilerGenerated]
	private static MapData <currentMap>k__BackingField; // 0x10
	[CompilerGenerated]
	private static StageData <currentStage>k__BackingField; // 0x18
	private static bool isFinalBossStage; // 0x20
	private static bool reseting; // 0x21
	public static Action A_NewRunStarted; // 0x28
	public static RunConfig runConfig; // 0x30

	// Properties
	public static MapData currentMap { get; set; }
	public static StageData currentStage { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3FAB30 Offset: 0x3F9130 VA: 0x1803FAB30
	public static MapData get_currentMap() { }

	[CompilerGenerated]
	// RVA: 0x3FABB0 Offset: 0x3F91B0 VA: 0x1803FABB0
	private static void set_currentMap(MapData value) { }

	[CompilerGenerated]
	// RVA: 0x3FAB70 Offset: 0x3F9170 VA: 0x1803FAB70
	public static StageData get_currentStage() { }

	[CompilerGenerated]
	// RVA: 0x3FAC10 Offset: 0x3F9210 VA: 0x1803FAC10
	private static void set_currentStage(StageData value) { }

	// RVA: 0x3FA330 Offset: 0x3F8930 VA: 0x1803FA330
	public static void RestartRun() { }

	// RVA: 0x3FA500 Offset: 0x3F8B00 VA: 0x1803FA500
	public static void StartNewMap(RunConfig newRunConfig) { }

	// RVA: 0x3FAAE0 Offset: 0x3F90E0 VA: 0x1803FAAE0
	private static void TryCleanupInventory() { }

	// RVA: 0x3FA0D0 Offset: 0x3F86D0 VA: 0x1803FA0D0
	public static void LoadNextStage() { }

	// RVA: 0x3F9F20 Offset: 0x3F8520 VA: 0x1803F9F20
	public static void LoadFinalStage() { }

	// RVA: 0x3F9DE0 Offset: 0x3F83E0 VA: 0x1803F9DE0
	public static bool IsFirstStage() { }

	// RVA: 0x3F9D20 Offset: 0x3F8320 VA: 0x1803F9D20
	public static int GetStageIndex() { }

	// RVA: 0x3F9E20 Offset: 0x3F8420 VA: 0x1803F9E20
	public static bool IsLastStage() { }

	// RVA: 0x3F9DA0 Offset: 0x3F83A0 VA: 0x1803F9DA0
	public static bool IsFinalBossStage() { }

	// RVA: 0x3FA680 Offset: 0x3F8C80 VA: 0x1803FA680
	public static void TestFinalBoss() { }

	// RVA: 0x3F9EB0 Offset: 0x3F84B0 VA: 0x1803F9EB0
	public static bool IsTierFinalStage() { }

	// RVA: 0x3F9C70 Offset: 0x3F8270 VA: 0x1803F9C70
	public static PlayerInventory GetPlayerInventory(CharacterData data) { }

	// RVA: 0x3F9D60 Offset: 0x3F8360 VA: 0x1803F9D60
	public static bool HasPlayerInventory() { }

	// RVA: 0x3FA6D0 Offset: 0x3F8CD0 VA: 0x1803FA6D0
	public static void TestMap(MapData mapData, StageData stageData) { }

	// RVA: 0x3FA8C0 Offset: 0x3F8EC0 VA: 0x1803FA8C0
	public static void TestMap(RunConfig testConfig) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Managers
public class ParticleSpawner : MonoBehaviour // TypeDefIndex: 5465
{
	// Methods

	// RVA: 0x3FF6C0 Offset: 0x3FDCC0 VA: 0x1803FF6C0
	public static GameObject SpawnParticles(GameObject particles, Vector3 position, Quaternion rotation) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

