// Namespace: UnityEngine.TerrainUtils
internal enum TerrainMapStatusCode // TypeDefIndex: 14072
{
	// Fields
	public int value__; // 0x0
	public const TerrainMapStatusCode OK = 0;
	public const TerrainMapStatusCode Overlapping = 1;
	public const TerrainMapStatusCode SizeMismatch = 4;
	public const TerrainMapStatusCode EdgeAlignmentMismatch = 8;
}

// Namespace: UnityEngine.TerrainUtils
[IsReadOnly]
public struct TerrainTileCoord // TypeDefIndex: 14073
{
	// Fields
	public readonly int tileX; // 0x0
	public readonly int tileZ; // 0x4

	// Methods

	// RVA: 0x8F9B20 Offset: 0x8F8120 VA: 0x1808F9B20
	public void .ctor(int tileX, int tileZ) { }
}

// Namespace: UnityEngine.TerrainUtils
public class TerrainMap // TypeDefIndex: 14075
{
	// Fields
	private Vector3 m_patchSize; // 0x10
	private TerrainMapStatusCode m_errorCode; // 0x1C
	private Dictionary<TerrainTileCoord, Terrain> m_terrainTiles; // 0x20

	// Properties
	public Dictionary<TerrainTileCoord, Terrain> terrainTiles { get; }

	// Methods

	// RVA: 0x23E2330 Offset: 0x23E0930 VA: 0x1823E2330
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x23E1F40 Offset: 0x23E0540 VA: 0x1823E1F40
	public static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter, bool fullValidation = True) { }

	// RVA: 0x23E1BE0 Offset: 0x23E01E0 VA: 0x1823E1BE0
	public static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter, bool fullValidation = True) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Dictionary<TerrainTileCoord, Terrain> get_terrainTiles() { }

	// RVA: 0x23E2DB0 Offset: 0x23E13B0 VA: 0x1823E2DB0
	public void .ctor() { }

	// RVA: 0x23E1980 Offset: 0x23DFF80 VA: 0x1823E1980
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x23E23B0 Offset: 0x23E09B0 VA: 0x1823E23B0
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x23E24C0 Offset: 0x23E0AC0 VA: 0x1823E24C0
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x23E2C70 Offset: 0x23E1270 VA: 0x1823E2C70
	private TerrainMapStatusCode Validate() { }
}

// Namespace: UnityEngine.TerrainUtils
[MovedFrom("UnityEngine.Experimental.TerrainAPI")]
public static class TerrainUtility // TypeDefIndex: 14078
{
	// Methods

	// RVA: 0x23E3860 Offset: 0x23E1E60 VA: 0x1823E3860
	internal static bool ValidTerrainsExist() { }

	// RVA: 0x23E33E0 Offset: 0x23E19E0 VA: 0x1823E33E0
	internal static void ClearConnectivity() { }

	// RVA: 0x23E35A0 Offset: 0x23E1BA0 VA: 0x1823E35A0
	internal static Dictionary<int, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = True) { }

	[RequiredByNativeCode]
	// RVA: 0x23E2E30 Offset: 0x23E1430 VA: 0x1823E2E30
	public static void AutoConnect() { }
}

