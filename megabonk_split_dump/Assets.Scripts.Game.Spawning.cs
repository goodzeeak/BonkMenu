// Namespace: Assets.Scripts.Game.Spawning
[Serializable]
public class EnemyWave // TypeDefIndex: 5646
{
	// Fields
	public EWaveType eWaveType; // 0x10
	public List<EEnemy> enemies; // 0x18
	public List<EnemyData> enemyDatas; // 0x20
	public int waveTime; // 0x28
	public int minNumEnemies; // 0x2C
	public float spawnInterval; // 0x30

	// Methods

	// RVA: 0x451D10 Offset: 0x450310 VA: 0x180451D10 Slot: 3
	public override string ToString() { }

	// RVA: 0x451D00 Offset: 0x450300 VA: 0x180451D00
	public float EnemiesPerSecond() { }

	// RVA: 0x451DC0 Offset: 0x4503C0 VA: 0x180451DC0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.Game.Spawning
public enum EWaveType // TypeDefIndex: 5647
{
	// Fields
	public int value__; // 0x0
	public const EWaveType Normal = 0;
	public const EWaveType Swarm = 1;
	public const EWaveType Boss = 2;
	public const EWaveType FinalSwarm = 3;
}

// Namespace: Assets.Scripts.Game.Spawning
public static class SpawnPositions // TypeDefIndex: 5648
{
	// Fields
	public static Vector3 INVALID_POS; // 0x0
	private static float lastFoundSpawnBounds; // 0xC
	private static float minX; // 0x10
	private static float minZ; // 0x14
	private static float maxX; // 0x18
	private static float maxZ; // 0x1C

	// Methods

	// RVA: 0x4604E0 Offset: 0x45EAE0 VA: 0x1804604E0
	public static Vector3 GetEnemySpawnPosition(EnemyData enemyData, int attempts = 50, bool useDirectionBias = True) { }

	// RVA: 0x460040 Offset: 0x45E640 VA: 0x180460040
	public static Vector3 GetEnemySpawnPositionTest(EnemyData enemyData, int attempts = 50) { }

	// RVA: 0x460E50 Offset: 0x45F450 VA: 0x180460E50
	private static void GetSpawnDistances(out float min, out float max) { }

	// RVA: 0x45E9C0 Offset: 0x45CFC0 VA: 0x18045E9C0
	private static void FindBounds() { }

	// RVA: 0x45F4E0 Offset: 0x45DAE0 VA: 0x18045F4E0
	private static Vector3 GetEnemySpawnPositionBiased(EnemyData enemyData, float playerDirectionBias, int attempts = 50) { }

	// RVA: 0x45F0A0 Offset: 0x45D6A0 VA: 0x18045F0A0
	public static Vector3 GetEnemySpawnPositionAroundPoint(Vector3 pos, float minRadius, float maxRadius, int attempts = 50, bool onlyGround = False, float fromHeight = 999) { }

	// RVA: 0x461020 Offset: 0x45F620 VA: 0x180461020
	private static Vector3 SampleBiasedDirection(Vector3 biasedTowards, float bias) { }

	// RVA: 0x460C20 Offset: 0x45F220 VA: 0x180460C20
	private static Vector3 GetPlayerMovementDirection() { }

	// RVA: 0x4605D0 Offset: 0x45EBD0 VA: 0x1804605D0
	public static Vector3 GetObjectSpawnPosition(Vector3 center, Vector3 size, float checkRadius, int layerMask, out Vector3 normal, int attempts = 50, bool onlyUseGroundLayer = True, bool debug = False, bool canSpawnInWater = False, float maxSlopeAngle = 44, float extraRayFromHeight = 0) { }

	// RVA: 0x45EC10 Offset: 0x45D210 VA: 0x18045EC10
	public static RaycastHit FindHitClosestToPlayerY(RaycastHit[] hits, out bool foundPosition, bool canChooseObject = True) { }

	// RVA: 0x460F00 Offset: 0x45F500 VA: 0x180460F00
	public static Vector3 PredictPlayerPosition(float time) { }

	// RVA: 0x460CA0 Offset: 0x45F2A0 VA: 0x180460CA0
	public static Vector3 GetRandomSpawnPositionOnMap(float extraHeight = 0) { }

	// RVA: 0x461220 Offset: 0x45F820 VA: 0x180461220
	private static void .cctor() { }
}

