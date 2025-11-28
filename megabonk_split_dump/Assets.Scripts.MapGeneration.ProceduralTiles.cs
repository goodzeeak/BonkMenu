// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public enum EFillType // TypeDefIndex: 5442
{
	// Fields
	public int value__; // 0x0
	public const EFillType Nothing = 0;
	public const EFillType Top = 1;
	public const EFillType Bottom = 2;
	public const EFillType Both = 3;
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public enum ETileEdgeType // TypeDefIndex: 5443
{
	// Fields
	public int value__; // 0x0
	public const ETileEdgeType Flat = 0;
	public const ETileEdgeType SlopeRight = 1;
	public const ETileEdgeType SlopeLeft = 2;
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public class FillTile : MonoBehaviour // TypeDefIndex: 5444
{
	// Fields
	public MeshRenderer renderer; // 0x20
	public EFillType fillType; // 0x28
	public bool cross; // 0x2C
	public bool useEdge; // 0x2D

	// Methods

	// RVA: 0x3F6DB0 Offset: 0x3F53B0 VA: 0x1803F6DB0
	public void SetFillType(EFillType type, StageData stageData, bool useEdgeTextures = False) { }

	// RVA: 0x3F6D50 Offset: 0x3F5350 VA: 0x1803F6D50
	private void OnValidate() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public enum MapEdgeFillType // TypeDefIndex: 5445
{
	// Fields
	public int value__; // 0x0
	public const MapEdgeFillType Island = 0;
	public const MapEdgeFillType Walls = 1;
	public const MapEdgeFillType Trees = 2;
	public const MapEdgeFillType None = 3;
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
[CreateAssetMenu(menuName = "Me/Mapping/MapParameters")]
public class MapParameters : ScriptableObject // TypeDefIndex: 5446
{
	// Fields
	public float volatility; // 0x18
	public float centerHeightTarget; // 0x1C
	public float slopeStrength; // 0x20
	public float yOffset; // 0x24
	public float flatMapBias; // 0x28
	public int size; // 0x2C
	public int scale; // 0x30
	public int tileWidth; // 0x34
	public int tileHeight; // 0x38
	public EBiasStrategy biasStrategy; // 0x3C
	public EHeightGenerationStrategy heightGenerationStrategy; // 0x40
	[Header("Calculated Values")]
	public int scaledTileWidth; // 0x44
	public int scaledTileHeight; // 0x48
	public StageData testStageData; // 0x50

	// Methods

	// RVA: 0x3FAD60 Offset: 0x3F9360 VA: 0x1803FAD60
	private void OnValidate() { }

	// RVA: 0x3FAD80 Offset: 0x3F9380 VA: 0x1803FAD80
	public void .ctor() { }
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public static class Maze // TypeDefIndex: 5448
{
	// Fields
	public static readonly Dictionary<int, int> Opposite; // 0x0
	[TupleElementNames(new[] { "direction", "dirValue" })]
	public static readonly ValueTuple<Vector2Int, int>[] DirectionsWithVectors; // 0x8

	// Methods

	// RVA: 0x3FBDE0 Offset: 0x3FA3E0 VA: 0x1803FBDE0
	public static NodeTree Generate(int width, int height, int seed) { }

	// RVA: 0x3FC480 Offset: 0x3FAA80 VA: 0x1803FC480
	private static int ToIndex(Vector2Int position, int width) { }

	// RVA: 0x3FC490 Offset: 0x3FAA90 VA: 0x1803FC490
	private static Vector2Int ToPosition(int index, int width) { }

	// RVA: 0x3FC450 Offset: 0x3FAA50 VA: 0x1803FC450
	private static bool IsValidPosition(Vector2Int position, int width, int height) { }

	// RVA: -1 Offset: -1
	private static List<T> Shuffle<T>(List<T> list, Random rand) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72F5B0 Offset: 0x72DBB0 VA: 0x18072F5B0
	|-Maze.Shuffle<ValueTuple<Vector2Int, int>>
	|
	|-RVA: 0x72F300 Offset: 0x72D900 VA: 0x18072F300
	|-Maze.Shuffle<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3FC4B0 Offset: 0x3FAAB0 VA: 0x1803FC4B0
	private static void .cctor() { }
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public class NodeTree // TypeDefIndex: 5450
{
	// Fields
	[CompilerGenerated]
	private Vector2Int <position>k__BackingField; // 0x10
	[CompilerGenerated]
	private NodeTree <parent>k__BackingField; // 0x18
	[CompilerGenerated]
	private List<NodeTree> <children>k__BackingField; // 0x20
	public int height; // 0x28
	public int yDir; // 0x2C

	// Properties
	public Vector2Int position { get; set; }
	public NodeTree parent { get; set; }
	public List<NodeTree> children { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Vector2Int get_position() { }

	[CompilerGenerated]
	// RVA: 0x3FDF00 Offset: 0x3FC500 VA: 0x1803FDF00
	private void set_position(Vector2Int value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public NodeTree get_parent() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_parent(NodeTree value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<NodeTree> get_children() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_children(List<NodeTree> value) { }

	// RVA: 0x3FDE60 Offset: 0x3FC460 VA: 0x1803FDE60
	public void .ctor(Vector2Int position, NodeTree parent) { }

	// RVA: 0x3FDAB0 Offset: 0x3FC0B0 VA: 0x1803FDAB0 Slot: 3
	public override string ToString() { }
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public class MazeHeightGenerator // TypeDefIndex: 5453
{
	// Methods

	// RVA: 0x3FBD90 Offset: 0x3FA390 VA: 0x1803FBD90
	public static void GenerateHeight(ProceduralTileGeneration tileGeneration, NodeTree startNode, int seed, MapParameters mapParameters) { }

	// RVA: 0x3FADC0 Offset: 0x3F93C0 VA: 0x1803FADC0
	public static void GenerateHeightHein(ProceduralTileGeneration tileGeneration, NodeTree startNode, int seed, MapParameters mapParameters) { }

	// RVA: 0x3FB580 Offset: 0x3F9B80 VA: 0x1803FB580
	public static void GenerateHeightMe(ProceduralTileGeneration proceduralTileGeneration, NodeTree startNode, int seed, MapParameters mapParameters) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public enum EBiasStrategy // TypeDefIndex: 5454
{
	// Fields
	public int value__; // 0x0
	public const EBiasStrategy Gaussian = 0;
	public const EBiasStrategy Linear = 1;
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public enum EHeightGenerationStrategy // TypeDefIndex: 5455
{
	// Fields
	public int value__; // 0x0
	public const EHeightGenerationStrategy Hein = 0;
	public const EHeightGenerationStrategy Me = 1;
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public interface IHeightBiasStrategy // TypeDefIndex: 5456
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float CalculateBias(int x, int y, int size, float outerBiasStrength, float strictness);
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public class GaussianHeightBias : IHeightBiasStrategy // TypeDefIndex: 5457
{
	// Methods

	// RVA: 0x3F8350 Offset: 0x3F6950 VA: 0x1803F8350 Slot: 4
	public float CalculateBias(int x, int y, int size, float outerBiasStrength, float strictness) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public class LinearHeightBias : IHeightBiasStrategy // TypeDefIndex: 5458
{
	// Methods

	// RVA: 0x3F9B80 Offset: 0x3F8180 VA: 0x1803F9B80 Slot: 4
	public float CalculateBias(int x, int y, int size, float outerBiasStrength, float strictness) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
public class MeshColliderCombiner // TypeDefIndex: 5459
{
	// Methods

	// RVA: 0x3FCB90 Offset: 0x3FB190 VA: 0x1803FCB90
	public static GameObject CombineMeshes(List<GameObject> pieces) { }

	// RVA: 0x3FC750 Offset: 0x3FAD50 VA: 0x1803FC750
	private static void AutoWeld(Mesh mesh, float threshold) { }

	// RVA: 0x3FD230 Offset: 0x3FB830 VA: 0x1803FD230
	private static void SimplifyMesh(Mesh mesh) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Assets.Scripts.MapGeneration.ProceduralTiles
[Serializable]
public class TileEdge // TypeDefIndex: 5460
{
	// Fields
	public Vector2Int direction; // 0x10
	public int offsetHeight; // 0x18
	public ETileEdgeType type; // 0x1C

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

