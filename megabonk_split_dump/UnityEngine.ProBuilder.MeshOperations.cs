// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
public static class AppendElements // TypeDefIndex: 11699
{
	// Methods

	[Extension]
	// RVA: 0x20E3F30 Offset: 0x20E2530 VA: 0x1820E3F30
	internal static Face AppendFace(ProBuilderMesh mesh, Vector3[] positions, Color[] colors, Vector2[] uv0s, Vector4[] uv2s, Vector4[] uv3s, Face face, int[] common) { }

	[Extension]
	// RVA: 0x20E47F0 Offset: 0x20E2DF0 VA: 0x1820E47F0
	public static Face[] AppendFaces(ProBuilderMesh mesh, Vector3[][] positions, Color[][] colors, Vector2[][] uvs, Face[] faces, int[][] shared) { }

	[Extension]
	// RVA: 0x20E93D0 Offset: 0x20E79D0 VA: 0x1820E93D0
	public static Face CreatePolygon(ProBuilderMesh mesh, IList<int> indexes, bool unordered) { }

	[Extension]
	// RVA: 0x20E89E0 Offset: 0x20E6FE0 VA: 0x1820E89E0
	public static Face CreatePolygonWithHole(ProBuilderMesh mesh, IList<int> indexes, IList<IList<int>> holes) { }

	[Extension]
	// RVA: 0x20E98F0 Offset: 0x20E7EF0 VA: 0x1820E98F0
	public static ActionResult CreateShapeFromPolygon(PolyShape poly) { }

	[Extension]
	// RVA: 0x20E89A0 Offset: 0x20E6FA0 VA: 0x1820E89A0
	internal static void ClearAndRefreshMesh(ProBuilderMesh mesh) { }

	[Extension]
	// RVA: 0x20EA430 Offset: 0x20E8A30 VA: 0x1820EA430
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, IList<Vector3> points, float extrude, bool flipNormals) { }

	[Extension]
	[Obsolete("Face.CreateShapeFromPolygon is deprecated as it no longer relies on camera look at.")]
	// RVA: 0x20EA450 Offset: 0x20E8A50 VA: 0x1820EA450
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, IList<Vector3> points, float extrude, bool flipNormals, Vector3 cameraLookAt, IList<IList<Vector3>> holePoints) { }

	[Extension]
	// RVA: 0x20E9940 Offset: 0x20E7F40 VA: 0x1820E9940
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, IList<Vector3> points, float extrude, bool flipNormals, IList<IList<Vector3>> holePoints) { }

	// RVA: 0x20EAF20 Offset: 0x20E9520 VA: 0x1820EAF20
	internal static FaceRebuildData FaceWithVertices(List<Vertex> vertices, bool unordered = True) { }

	// RVA: 0x20EAA60 Offset: 0x20E9060 VA: 0x1820EAA60
	internal static FaceRebuildData FaceWithVerticesAndHole(List<Vertex> borderVertices, List<List<Vertex>> holes) { }

	// RVA: 0x20ED060 Offset: 0x20EB660 VA: 0x1820ED060
	internal static List<FaceRebuildData> TentCapWithVertices(List<Vertex> path) { }

	[Extension]
	// RVA: 0x20EA470 Offset: 0x20E8A70 VA: 0x1820EA470
	public static void DuplicateAndFlip(ProBuilderMesh mesh, Face[] faces) { }

	[Extension]
	// RVA: 0x20E7540 Offset: 0x20E5B40 VA: 0x1820E7540
	public static Face Bridge(ProBuilderMesh mesh, Edge a, Edge b, bool allowNonManifoldGeometry = False) { }

	[Extension]
	// RVA: 0x20E7520 Offset: 0x20E5B20 VA: 0x1820E7520
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points) { }

	[Extension]
	// RVA: 0x20E6880 Offset: 0x20E4E80 VA: 0x1820E6880
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points, bool insertOnEdge) { }

	[Extension]
	// RVA: 0x20E6800 Offset: 0x20E4E00 VA: 0x1820E6800
	public static List<Edge> AppendVerticesToEdge(ProBuilderMesh mesh, Edge edge, int count) { }

	[Extension]
	// RVA: 0x20E4E80 Offset: 0x20E3480 VA: 0x1820E4E80
	public static List<Edge> AppendVerticesToEdge(ProBuilderMesh mesh, IList<Edge> edges, int count) { }

	[Extension]
	// RVA: 0x20EB010 Offset: 0x20E9610 VA: 0x1820EB010
	public static Face[] InsertVertexInFace(ProBuilderMesh mesh, Face face, Vector3 point) { }

	[Extension]
	// RVA: 0x20EBE50 Offset: 0x20EA450 VA: 0x1820EBE50
	public static Vertex InsertVertexOnEdge(ProBuilderMesh mesh, Edge originalEdge, Vector3 point) { }

	[Extension]
	// RVA: 0x20EBB90 Offset: 0x20EA190 VA: 0x1820EBB90
	public static Vertex InsertVertexInMesh(ProBuilderMesh mesh, Vector3 point, Vector3 normal) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class Bevel // TypeDefIndex: 11704
{
	// Fields
	private static readonly int[] k_BridgeIndexesTri; // 0x0

	// Methods

	// RVA: 0x20ED430 Offset: 0x20EBA30 VA: 0x1820ED430
	public static List<Face> BevelEdges(ProBuilderMesh mesh, IList<Edge> edges, float amount) { }

	// RVA: 0x20EFA40 Offset: 0x20EE040 VA: 0x1820EFA40
	private static List<FaceRebuildData> GetBridgeFaces(IList<Vertex> vertices, WingedEdge left, WingedEdge right, Dictionary<int, List<SimpleTuple<FaceRebuildData, List<int>>>> holes) { }

	// RVA: 0x20F0420 Offset: 0x20EEA20 VA: 0x1820F0420
	private static void SlideEdge(IList<Vertex> vertices, WingedEdge we, float amount) { }

	// RVA: 0x20F0260 Offset: 0x20EE860 VA: 0x1820F0260
	private static Edge GetLeadingEdge(WingedEdge wing, int common) { }

	// RVA: 0x20F06B0 Offset: 0x20EECB0 VA: 0x1820F06B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class CombineMeshes // TypeDefIndex: 11706
{
	// Methods

	[Obsolete("Combine(IEnumerable<ProBuilderMesh> meshes) is deprecated. Plase use Combine(IEnumerable<ProBuilderMesh> meshes, ProBuilderMesh meshTarget).")]
	// RVA: 0x20F1370 Offset: 0x20EF970 VA: 0x1820F1370
	public static List<ProBuilderMesh> Combine(IEnumerable<ProBuilderMesh> meshes) { }

	// RVA: 0x20F1380 Offset: 0x20EF980 VA: 0x1820F1380
	public static List<ProBuilderMesh> Combine(IEnumerable<ProBuilderMesh> meshes, ProBuilderMesh meshTarget) { }

	// RVA: 0x20F0EB0 Offset: 0x20EF4B0 VA: 0x1820F0EB0
	private static List<ProBuilderMesh> CombineToNewMeshes(IEnumerable<ProBuilderMesh> meshes) { }

	// RVA: 0x20F0750 Offset: 0x20EED50 VA: 0x1820F0750
	private static void AccumulateMeshesInfo(IEnumerable<ProBuilderMesh> meshes, int offset, ref List<Vertex> vertices, ref List<Face> faces, ref List<Face> autoUvFaces, ref List<SharedVertex> sharedVertices, ref List<SharedVertex> sharedTextures, ref List<Material> materialMap, Transform targetTransform) { }

	// RVA: 0x20F1CB0 Offset: 0x20F02B0 VA: 0x1820F1CB0
	private static ProBuilderMesh CreateMeshFromSplit(List<Vertex> vertices, List<Face> faces, Dictionary<int, int> sharedVertexLookup, Dictionary<int, int> sharedTextureLookup, Dictionary<int, int> remap, Material[] materials) { }

	// RVA: 0x20F21B0 Offset: 0x20F07B0 VA: 0x1820F21B0
	internal static List<ProBuilderMesh> SplitByMaxVertexCount(IList<Vertex> vertices, IList<Face> faces, IList<SharedVertex> sharedVertices, IList<SharedVertex> sharedTextures, uint maxVertexCount = 65535) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal sealed class ConnectFaceRebuildData // TypeDefIndex: 11707
{
	// Fields
	public FaceRebuildData faceRebuildData; // 0x10
	public List<int> newVertexIndexes; // 0x18

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(FaceRebuildData faceRebuildData, List<int> newVertexIndexes) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
public static class ConnectElements // TypeDefIndex: 11711
{
	// Methods

	[Extension]
	// RVA: 0x20F62A0 Offset: 0x20F48A0 VA: 0x1820F62A0
	public static Face[] Connect(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	[Extension]
	// RVA: 0x20F4B80 Offset: 0x20F3180 VA: 0x1820F4B80
	public static SimpleTuple<Face[], Edge[]> Connect(ProBuilderMesh mesh, IEnumerable<Edge> edges) { }

	[Extension]
	// RVA: 0x20F6590 Offset: 0x20F4B90 VA: 0x1820F6590
	public static int[] Connect(ProBuilderMesh mesh, IList<int> indexes) { }

	[Extension]
	// RVA: 0x20F4C20 Offset: 0x20F3220 VA: 0x1820F4C20
	internal static ActionResult Connect(ProBuilderMesh mesh, IEnumerable<Edge> edges, out Face[] addedFaces, out Edge[] connections, bool returnFaces = False, bool returnEdges = False, HashSet<Face> faceMask) { }

	// RVA: 0x20F3250 Offset: 0x20F1850 VA: 0x1820F3250
	private static List<ConnectFaceRebuildData> ConnectEdgesInFace(Face face, WingedEdge a, WingedEdge b, List<Vertex> vertices) { }

	// RVA: 0x20F2A50 Offset: 0x20F1050 VA: 0x1820F2A50
	private static List<ConnectFaceRebuildData> ConnectEdgesInFace(Face face, List<WingedEdge> edges, List<Vertex> vertices) { }

	// RVA: 0x20F7580 Offset: 0x20F5B80 VA: 0x1820F7580
	private static bool InsertVertices(Face face, List<WingedEdge> edges, List<Vertex> vertices, out ConnectFaceRebuildData data) { }

	// RVA: 0x20F4300 Offset: 0x20F2900 VA: 0x1820F4300
	private static List<ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, int a, int b, List<Vertex> vertices, Dictionary<int, int> lookup) { }

	// RVA: 0x20F3980 Offset: 0x20F1F80 VA: 0x1820F3980
	private static List<ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, List<int> indexes, List<Vertex> vertices, Dictionary<int, int> lookup, int sharedIndexOffset) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
public static class DeleteElements // TypeDefIndex: 11715
{
	// Methods

	[Extension]
	// RVA: 0x20F8260 Offset: 0x20F6860 VA: 0x1820F8260
	public static void DeleteVertices(ProBuilderMesh mesh, IEnumerable<int> distinctIndexes) { }

	[Extension]
	// RVA: 0x20F7AC0 Offset: 0x20F60C0 VA: 0x1820F7AC0
	public static int[] DeleteFace(ProBuilderMesh mesh, Face face) { }

	[Extension]
	// RVA: 0x20F8150 Offset: 0x20F6750 VA: 0x1820F8150
	public static int[] DeleteFaces(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	[Extension]
	// RVA: 0x20F7B50 Offset: 0x20F6150 VA: 0x1820F7B50
	public static int[] DeleteFaces(ProBuilderMesh mesh, IList<int> faceIndexes) { }

	[Extension]
	[Obsolete("Use MeshValidation.RemoveDegenerateTriangles")]
	[EditorBrowsable(1)]
	// RVA: 0x20F86E0 Offset: 0x20F6CE0 VA: 0x1820F86E0
	public static int[] RemoveDegenerateTriangles(ProBuilderMesh mesh) { }

	[Extension]
	[Obsolete("Use MeshValidation.RemoveUnusedVertices")]
	[EditorBrowsable(1)]
	// RVA: 0x20F8780 Offset: 0x20F6D80 VA: 0x1820F8780
	public static int[] RemoveUnusedVertices(ProBuilderMesh mesh) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
public static class ElementSelection // TypeDefIndex: 11719
{
	// Fields
	private const int k_MaxHoleIterations = 2048;
	private static readonly Vector3 Vector3_Zero; // 0x0

	// Methods

	// RVA: 0x20FC460 Offset: 0x20FAA60 VA: 0x1820FC460
	public static void GetNeighborFaces(ProBuilderMesh mesh, Edge edge, List<Face> neighborFaces) { }

	// RVA: 0x20FC160 Offset: 0x20FA760 VA: 0x1820FC160
	internal static List<SimpleTuple<Face, Edge>> GetNeighborFaces(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x20FBF10 Offset: 0x20FA510 VA: 0x1820FBF10
	internal static List<Face> GetNeighborFaces(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x20F9B60 Offset: 0x20F8160 VA: 0x1820F9B60
	internal static Edge[] GetConnectedEdges(ProBuilderMesh mesh, int[] indexes) { }

	[Extension]
	// RVA: 0x20FC6B0 Offset: 0x20FACB0 VA: 0x1820FC6B0
	public static IEnumerable<Edge> GetPerimeterEdges(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	// RVA: 0x20FCCA0 Offset: 0x20FB2A0 VA: 0x1820FCCA0
	internal static int[] GetPerimeterEdges(ProBuilderMesh mesh, IList<Edge> edges) { }

	// RVA: 0x20FCF10 Offset: 0x20FB510 VA: 0x1820FCF10
	internal static IEnumerable<Face> GetPerimeterFaces(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	// RVA: 0x20FD490 Offset: 0x20FBA90 VA: 0x1820FD490
	internal static int[] GetPerimeterVertices(ProBuilderMesh mesh, int[] indexes, Edge[] universal_edges_all) { }

	// RVA: 0x20F8820 Offset: 0x20F6E20 VA: 0x1820F8820
	private static WingedEdge EdgeRingNext(WingedEdge edge) { }

	// RVA: 0x20FB2E0 Offset: 0x20F98E0 VA: 0x1820FB2E0
	internal static IEnumerable<Edge> GetEdgeRing(ProBuilderMesh pb, IEnumerable<Edge> edges) { }

	// RVA: 0x20FAD40 Offset: 0x20F9340 VA: 0x1820FAD40
	internal static IEnumerable<Edge> GetEdgeRingIterative(ProBuilderMesh pb, IEnumerable<Edge> edges) { }

	// RVA: 0x20FA970 Offset: 0x20F8F70 VA: 0x1820FA970
	internal static bool GetEdgeLoop(ProBuilderMesh mesh, IEnumerable<Edge> edges, out Edge[] loop) { }

	// RVA: 0x20FA660 Offset: 0x20F8C60 VA: 0x1820FA660
	internal static bool GetEdgeLoopIterative(ProBuilderMesh mesh, IEnumerable<Edge> edges, out Edge[] loop) { }

	// RVA: 0x20FA410 Offset: 0x20F8A10 VA: 0x1820FA410
	private static bool GetEdgeLoopInternal(WingedEdge start, int startIndex, HashSet<EdgeLookup> used) { }

	// RVA: 0x20FA040 Offset: 0x20F8640 VA: 0x1820FA040
	private static void GetEdgeLoopInternalIterative(WingedEdge start, Edge edge, HashSet<EdgeLookup> used) { }

	// RVA: 0x20FDF00 Offset: 0x20FC500 VA: 0x1820FDF00
	private static WingedEdge NextSpoke(WingedEdge wing, int pivot, bool opp) { }

	// RVA: 0x20FD700 Offset: 0x20FBD00 VA: 0x1820FD700
	internal static List<WingedEdge> GetSpokes(WingedEdge wing, int sharedIndex, bool allowHoles = False) { }

	// RVA: 0x20FDA60 Offset: 0x20FC060 VA: 0x1820FDA60
	public static HashSet<Face> GrowSelection(ProBuilderMesh mesh, IEnumerable<Face> faces, float maxAngleDiff = -1) { }

	// RVA: 0x20F96F0 Offset: 0x20F7CF0 VA: 0x1820F96F0
	internal static void Flood(WingedEdge wing, HashSet<Face> selection) { }

	// RVA: 0x20F9790 Offset: 0x20F7D90 VA: 0x1820F9790
	internal static void Flood(ProBuilderMesh pb, WingedEdge wing, Vector3 wingNrm, float maxAngle, HashSet<Face> selection) { }

	// RVA: 0x20F9410 Offset: 0x20F7A10 VA: 0x1820F9410
	public static HashSet<Face> FloodSelection(ProBuilderMesh mesh, IList<Face> faces, float maxAngleDiff) { }

	// RVA: 0x20FBAD0 Offset: 0x20FA0D0 VA: 0x1820FBAD0
	public static HashSet<Face> GetFaceLoop(ProBuilderMesh mesh, Face[] faces, bool ring = False) { }

	// RVA: 0x20FBCE0 Offset: 0x20FA2E0 VA: 0x1820FBCE0
	public static HashSet<Face> GetFaceRingAndLoop(ProBuilderMesh mesh, Face[] faces) { }

	// RVA: 0x20FB8E0 Offset: 0x20F9EE0 VA: 0x1820FB8E0
	private static HashSet<Face> GetFaceLoop(List<WingedEdge> wings, Face face, bool ring) { }

	// RVA: 0x20F90A0 Offset: 0x20F76A0 VA: 0x1820F90A0
	internal static List<List<Edge>> FindHoles(ProBuilderMesh mesh, IEnumerable<int> indexes) { }

	// RVA: 0x20F8880 Offset: 0x20F6E80 VA: 0x1820F8880
	internal static List<List<WingedEdge>> FindHoles(List<WingedEdge> wings, HashSet<int> common) { }

	// RVA: 0x20F93A0 Offset: 0x20F79A0 VA: 0x1820F93A0
	private static WingedEdge FindNextEdgeInHole(WingedEdge wing, int common) { }

	// RVA: 0x20FE030 Offset: 0x20FC630 VA: 0x1820FE030
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
public static class ExtrudeElements // TypeDefIndex: 11721
{
	// Methods

	[Extension]
	// RVA: 0x2102720 Offset: 0x2100D20 VA: 0x182102720
	public static Face[] Extrude(ProBuilderMesh mesh, IEnumerable<Face> faces, ExtrudeMethod method, float distance) { }

	[Extension]
	// RVA: 0x2101840 Offset: 0x20FFE40 VA: 0x182101840
	public static Edge[] Extrude(ProBuilderMesh mesh, IEnumerable<Edge> edges, float distance, bool extrudeAsGroup, bool enableManifoldExtrude) { }

	[Extension]
	// RVA: 0x20FEBA0 Offset: 0x20FD1A0 VA: 0x1820FEBA0
	public static List<Face> DetachFaces(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	[Extension]
	// RVA: 0x20FEBB0 Offset: 0x20FD1B0 VA: 0x1820FEBB0
	public static List<Face> DetachFaces(ProBuilderMesh mesh, IEnumerable<Face> faces, bool deleteSourceFaces) { }

	// RVA: 0x2100D20 Offset: 0x20FF320 VA: 0x182100D20
	private static Face[] ExtrudePerFace(ProBuilderMesh pb, IEnumerable<Face> faces, float distance) { }

	// RVA: 0x20FF3F0 Offset: 0x20FD9F0 VA: 0x1820FF3F0
	private static Face[] ExtrudeAsGroups(ProBuilderMesh mesh, IEnumerable<Face> faces, bool compensateAngleVertexDistance, float distance) { }

	// RVA: 0x2102750 Offset: 0x2100D50 VA: 0x182102750
	private static List<HashSet<Face>> GetFaceGroups(List<WingedEdge> wings) { }

	// RVA: 0x2102AE0 Offset: 0x21010E0 VA: 0x182102AE0
	private static Dictionary<EdgeLookup, Face> GetPerimeterEdges(HashSet<Face> faces, Dictionary<int, int> lookup) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class InternalMeshUtility // TypeDefIndex: 11723
{
	// Methods

	// RVA: 0x2102E60 Offset: 0x2101460 VA: 0x182102E60
	internal static Vector3 AverageNormalWithIndexes(SharedVertex shared, int[] all, IList<Vector3> norm) { }

	// RVA: 0x2103000 Offset: 0x2101600 VA: 0x182103000
	public static ProBuilderMesh CreateMeshWithTransform(Transform t, bool preserveFaces) { }

	// RVA: 0x2104480 Offset: 0x2102A80 VA: 0x182104480
	public static bool ResetPbObjectWithMeshFilter(ProBuilderMesh pb, bool preserveFaces) { }

	// RVA: 0x2104040 Offset: 0x2102640 VA: 0x182104040
	internal static void FilterUnusedSubmeshIndexes(ProBuilderMesh mesh) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MergeElements // TypeDefIndex: 11726
{
	// Methods

	// RVA: 0x2105880 Offset: 0x2103E80 VA: 0x182105880
	public static List<Face> MergePairs(ProBuilderMesh target, IEnumerable<SimpleTuple<Face, Face>> pairs, bool collapseCoincidentVertices = True) { }

	// RVA: 0x2105E70 Offset: 0x2104470 VA: 0x182105E70
	public static Face Merge(ProBuilderMesh target, IEnumerable<Face> faces) { }

	// RVA: 0x2105570 Offset: 0x2103B70 VA: 0x182105570
	internal static void CollapseCoincidentVertices(ProBuilderMesh mesh, IEnumerable<Face> faces) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Serializable]
public sealed class MeshImportSettings // TypeDefIndex: 11727
{
	// Fields
	[SerializeField]
	private bool m_Quads; // 0x10
	[SerializeField]
	private bool m_Smoothing; // 0x11
	[SerializeField]
	private float m_SmoothingThreshold; // 0x14

	// Properties
	public bool quads { get; set; }
	public bool smoothing { get; set; }
	public float smoothingAngle { get; set; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_quads() { }

	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_quads(bool value) { }

	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_smoothing() { }

	// RVA: 0x14B8CA0 Offset: 0x14B72A0 VA: 0x1814B8CA0
	public void set_smoothing(bool value) { }

	// RVA: 0x3A4AB0 Offset: 0x3A30B0 VA: 0x1803A4AB0
	public float get_smoothingAngle() { }

	// RVA: 0x3A4C60 Offset: 0x3A3260 VA: 0x1803A4C60
	public void set_smoothingAngle(float value) { }

	// RVA: 0x21062A0 Offset: 0x21048A0 VA: 0x1821062A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2106350 Offset: 0x2104950 VA: 0x182106350
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public sealed class MeshImporter // TypeDefIndex: 11729
{
	// Fields
	private static readonly MeshImportSettings k_DefaultImportSettings; // 0x0
	private Mesh m_SourceMesh; // 0x10
	private Material[] m_SourceMaterials; // 0x18
	private ProBuilderMesh m_Destination; // 0x20
	private Vertex[] m_Vertices; // 0x28

	// Methods

	// RVA: 0x2106E20 Offset: 0x2105420 VA: 0x182106E20
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x2106FB0 Offset: 0x21055B0 VA: 0x182106FB0
	public void .ctor(Mesh sourceMesh, Material[] sourceMaterials, ProBuilderMesh destination) { }

	[Obsolete]
	[EditorBrowsable(1)]
	// RVA: 0x199A250 Offset: 0x1998850 VA: 0x18199A250
	public void .ctor(ProBuilderMesh destination) { }

	[Obsolete]
	[EditorBrowsable(1)]
	// RVA: 0x2106370 Offset: 0x2104970 VA: 0x182106370
	public bool Import(GameObject go, MeshImportSettings importSettings) { }

	// RVA: 0x21064B0 Offset: 0x2104AB0 VA: 0x1821064B0
	public void Import(MeshImportSettings importSettings) { }

	// RVA: 0x2106D90 Offset: 0x2105390 VA: 0x182106D90
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
public static class MeshTransform // TypeDefIndex: 11730
{
	// Methods

	[Extension]
	// RVA: 0x2107690 Offset: 0x2105C90 VA: 0x182107690
	internal static void SetPivot(ProBuilderMesh mesh, PivotLocation pivotLocation) { }

	[Extension]
	// RVA: 0x2107120 Offset: 0x2105720 VA: 0x182107120
	public static void CenterPivot(ProBuilderMesh mesh, int[] indexes) { }

	[Extension]
	// RVA: 0x21078F0 Offset: 0x2105EF0 VA: 0x1821078F0
	public static void SetPivot(ProBuilderMesh mesh, Vector3 worldPosition) { }

	[Extension]
	// RVA: 0x21074B0 Offset: 0x2105AB0 VA: 0x1821074B0
	public static void FreezeScaleTransform(ProBuilderMesh mesh) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
public static class MeshValidation // TypeDefIndex: 11735
{
	// Methods

	[Extension]
	// RVA: 0x2107F70 Offset: 0x2106570 VA: 0x182107F70
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh) { }

	[Extension]
	// RVA: 0x2107F90 Offset: 0x2106590 VA: 0x182107F90
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, IList<Face> faces) { }

	[Extension]
	// RVA: 0x2107DF0 Offset: 0x21063F0 VA: 0x182107DF0
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, Face face) { }

	[Extension]
	// RVA: 0x2108240 Offset: 0x2106840 VA: 0x182108240
	public static bool ContainsNonContiguousTriangles(ProBuilderMesh mesh, Face face) { }

	[Extension]
	// RVA: 0x2108370 Offset: 0x2106970 VA: 0x182108370
	public static List<Face> EnsureFacesAreComposedOfContiguousTriangles(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	[Extension]
	// RVA: 0x2107AC0 Offset: 0x21060C0 VA: 0x182107AC0
	internal static List<List<Triangle>> CollectFaceGroups(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x2109AD0 Offset: 0x21080D0 VA: 0x182109AD0
	public static bool RemoveDegenerateTriangles(ProBuilderMesh mesh, List<int> removed) { }

	// RVA: 0x210A3A0 Offset: 0x21089A0 VA: 0x18210A3A0
	public static bool RemoveUnusedVertices(ProBuilderMesh mesh, List<int> removed) { }

	// RVA: 0x2109620 Offset: 0x2107C20 VA: 0x182109620
	internal static List<int> RebuildIndexes(IEnumerable<int> indices, List<int> removed) { }

	// RVA: 0x2109300 Offset: 0x2107900 VA: 0x182109300
	internal static List<Edge> RebuildEdges(IEnumerable<Edge> edges, List<int> removed) { }

	// RVA: 0x21098C0 Offset: 0x2107EC0 VA: 0x1821098C0
	internal static void RebuildSelectionIndexes(ProBuilderMesh mesh, ref Face[] faces, ref Edge[] edges, ref int[] indices, IEnumerable<int> removed) { }

	// RVA: 0x2108960 Offset: 0x2106F60 VA: 0x182108960
	internal static bool EnsureMeshIsValid(ProBuilderMesh mesh, out int removedVertices) { }

	// RVA: 0x2108AE0 Offset: 0x21070E0 VA: 0x182108AE0
	private static void EnsureRealNumbers(IList<Vector2> attribute) { }

	// RVA: 0x2108CC0 Offset: 0x21072C0 VA: 0x182108CC0
	private static void EnsureRealNumbers(IList<Vector3> attribute) { }

	// RVA: 0x2108F00 Offset: 0x2107500 VA: 0x182108F00
	private static void EnsureRealNumbers(IList<Vector4> attribute) { }

	// RVA: -1 Offset: -1
	private static void EnsureArraySize<T>(ref T[] attribute, int expectedVertexCount, MeshValidation.AttributeValidationStrategy strategy = 1, T fill) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x733990 Offset: 0x731F90 VA: 0x180733990
	|-MeshValidation.EnsureArraySize<Color>
	|-MeshValidation.EnsureArraySize<Vector4>
	|
	|-RVA: 0x733C00 Offset: 0x732200 VA: 0x180733C00
	|-MeshValidation.EnsureArraySize<Vector2>
	|
	|-RVA: 0x733CD0 Offset: 0x7322D0 VA: 0x180733CD0
	|-MeshValidation.EnsureArraySize<Vector3>
	|
	|-RVA: 0x733A60 Offset: 0x732060 VA: 0x180733A60
	|-MeshValidation.EnsureArraySize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void EnsureListSize<T>(ref List<T> attribute, int expectedVertexCount, MeshValidation.AttributeValidationStrategy strategy = 1, T fill) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x734030 Offset: 0x732630 VA: 0x180734030
	|-MeshValidation.EnsureListSize<Vector4>
	|
	|-RVA: 0x733DB0 Offset: 0x7323B0 VA: 0x180733DB0
	|-MeshValidation.EnsureListSize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21090C0 Offset: 0x21076C0 VA: 0x1821090C0
	private static void EnsureValidAttributes(ProBuilderMesh mesh) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
public static class QuadUtility // TypeDefIndex: 11736
{
	// Methods

	[Extension]
	// RVA: 0x210AEF0 Offset: 0x21094F0 VA: 0x18210AEF0
	public static List<Face> ToQuads(ProBuilderMesh mesh, IList<Face> faces, bool smoothing = True) { }

	// RVA: 0x210A680 Offset: 0x2108C80 VA: 0x18210A680
	private static Face GetBestQuadConnection(WingedEdge wing, Dictionary<EdgeLookup, float> connections) { }

	[Extension]
	// RVA: 0x210A870 Offset: 0x2108E70 VA: 0x18210A870
	private static float GetQuadScore(ProBuilderMesh mesh, WingedEdge left, WingedEdge right, float normalThreshold = 0.9) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
internal static class Subdivision // TypeDefIndex: 11737
{
	// Methods

	[Extension]
	// RVA: 0x210B650 Offset: 0x2109C50 VA: 0x18210B650
	public static ActionResult Subdivide(ProBuilderMesh pb) { }

	[Extension]
	// RVA: 0x210B700 Offset: 0x2109D00 VA: 0x18210B700
	public static Face[] Subdivide(ProBuilderMesh pb, IList<Face> faces) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
public static class SurfaceTopology // TypeDefIndex: 11739
{
	// Methods

	[Extension]
	// RVA: 0x210CF10 Offset: 0x210B510 VA: 0x18210CF10
	public static Face[] ToTriangles(ProBuilderMesh mesh, IList<Face> faces) { }

	// RVA: 0x210B710 Offset: 0x2109D10 VA: 0x18210B710
	private static List<FaceRebuildData> BreakFaceIntoTris(Face face, List<Vertex> vertices, Dictionary<int, int> lookup) { }

	[Extension]
	// RVA: 0x210CCF0 Offset: 0x210B2F0 VA: 0x18210CCF0
	public static WindingOrder GetWindingOrder(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x210CAF0 Offset: 0x210B0F0 VA: 0x18210CAF0
	private static WindingOrder GetWindingOrder(IList<Vertex> vertices, IList<int> indexes) { }

	// RVA: 0x210C930 Offset: 0x210AF30 VA: 0x18210C930
	public static WindingOrder GetWindingOrder(IList<Vector2> points) { }

	[Extension]
	// RVA: 0x210C310 Offset: 0x210A910 VA: 0x18210C310
	public static bool FlipEdge(ProBuilderMesh mesh, Face face) { }

	[Extension]
	// RVA: 0x210BD10 Offset: 0x210A310 VA: 0x18210BD10
	public static ActionResult ConformNormals(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	// RVA: 0x210C830 Offset: 0x210AE30 VA: 0x18210C830
	private static void GetWindingFlags(WingedEdge edge, bool flag, Dictionary<Face, bool> flags) { }

	// RVA: 0x210C210 Offset: 0x210A810 VA: 0x18210C210
	internal static ActionResult ConformOppositeNormal(WingedEdge source) { }

	// RVA: 0x210C690 Offset: 0x210AC90 VA: 0x18210C690
	private static Edge GetCommonEdgeInWindingOrder(WingedEdge wing) { }

	// RVA: 0x210CD40 Offset: 0x210B340 VA: 0x18210CD40
	internal static void MatchNormal(Face source, Face target, Dictionary<int, int> lookup) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class Triangulation // TypeDefIndex: 11742
{
	// Fields
	private static TriangulationContext s_TriangulationContext; // 0x0

	// Properties
	private static TriangulationContext triangulationContext { get; }

	// Methods

	// RVA: 0x210EEF0 Offset: 0x210D4F0 VA: 0x18210EEF0
	private static TriangulationContext get_triangulationContext() { }

	// RVA: 0x210D3C0 Offset: 0x210B9C0 VA: 0x18210D3C0
	public static bool SortAndTriangulate(IList<Vector2> points, out List<int> indexes, bool convex = False) { }

	// RVA: 0x210DA80 Offset: 0x210C080 VA: 0x18210DA80
	public static bool TriangulateVertices(IList<Vertex> vertices, out List<int> triangles, bool unordered = True, bool convex = False) { }

	// RVA: 0x210D710 Offset: 0x210BD10 VA: 0x18210D710
	public static bool TriangulateVertices(Vector3[] vertices, out List<int> triangles, Vector3[][] holes) { }

	// RVA: 0x210D880 Offset: 0x210BE80 VA: 0x18210D880
	public static bool TriangulateVertices(Vector3[] vertices, out List<int> triangles, bool unordered = True, bool convex = False) { }

	// RVA: 0x210DCB0 Offset: 0x210C2B0 VA: 0x18210DCB0
	public static bool Triangulate(IList<Vector2> points, out List<int> indexes, bool convex = False) { }

	// RVA: 0x210E4A0 Offset: 0x210CAA0 VA: 0x18210E4A0
	public static bool Triangulate(IList<Vector2> points, IList<IList<Vector2>> holes, out List<int> indexes) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
internal static class UVEditing // TypeDefIndex: 11746
{
	// Methods

	// RVA: 0x21108A0 Offset: 0x210EEA0 VA: 0x1821108A0
	public static bool AutoStitch(ProBuilderMesh mesh, Face f1, Face f2, int channel) { }

	// RVA: 0x210FA70 Offset: 0x210E070 VA: 0x18210FA70
	private static bool AlignEdges(ProBuilderMesh mesh, Face faceToMove, Edge edgeToAlignTo, Edge edgeToBeAligned, int channel) { }

	// RVA: 0x2110E00 Offset: 0x210F400 VA: 0x182110E00
	internal static Vector2[] GetUVs(ProBuilderMesh mesh, int channel) { }

	// RVA: 0x2110550 Offset: 0x210EB50 VA: 0x182110550
	internal static void ApplyUVs(ProBuilderMesh mesh, Vector2[] uvs, int channel, bool applyToMesh = True) { }

	[Extension]
	// RVA: 0x2112180 Offset: 0x2110780 VA: 0x182112180
	public static void SewUVs(ProBuilderMesh mesh, int[] indexes, float delta) { }

	[Extension]
	// RVA: 0x2110B80 Offset: 0x210F180 VA: 0x182110B80
	public static void CollapseUVs(ProBuilderMesh mesh, int[] indexes) { }

	[Extension]
	// RVA: 0x21126C0 Offset: 0x2110CC0 VA: 0x1821126C0
	public static void SplitUVs(ProBuilderMesh mesh, IEnumerable<int> indexes) { }

	// RVA: 0x2112930 Offset: 0x2110F30 VA: 0x182112930
	internal static void SplitUVs(ProBuilderMesh mesh, IEnumerable<Face> faces) { }

	// RVA: 0x2111040 Offset: 0x210F640 VA: 0x182111040
	internal static void ProjectFacesAuto(ProBuilderMesh mesh, Face[] faces, int channel) { }

	// RVA: 0x2111480 Offset: 0x210FA80 VA: 0x182111480
	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, int channel = 0) { }

	// RVA: 0x2110C50 Offset: 0x210F250 VA: 0x182110C50
	internal static Vector2 FindMinimalUV(Vector2[] uvs, int[] indices, float xMin = 0, float yMin = 0) { }

	// RVA: 0x21119F0 Offset: 0x210FFF0 VA: 0x1821119F0
	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, Vector2 lowerLeftAnchor, int channel = 0) { }

	// RVA: 0x2112010 Offset: 0x2110610 VA: 0x182112010
	public static void ProjectFacesSphere(ProBuilderMesh pb, int[] indexes, int channel = 0) { }

	// RVA: 0x2110D20 Offset: 0x210F320 VA: 0x182110D20
	public static Vector2[] FitUVs(Vector2[] uvs) { }
}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Extension]
public static class VertexEditing // TypeDefIndex: 11747
{
	// Methods

	[Extension]
	// RVA: 0x2113440 Offset: 0x2111A40 VA: 0x182113440
	public static int MergeVertices(ProBuilderMesh mesh, int[] indexes, bool collapseToFirst = False) { }

	[Extension]
	// RVA: 0x2113740 Offset: 0x2111D40 VA: 0x182113740
	public static void SplitVertices(ProBuilderMesh mesh, Edge edge) { }

	[Extension]
	// RVA: 0x21137D0 Offset: 0x2111DD0 VA: 0x1821137D0
	public static void SplitVertices(ProBuilderMesh mesh, IEnumerable<int> vertices) { }

	[Extension]
	// RVA: 0x2113AD0 Offset: 0x21120D0 VA: 0x182113AD0
	public static int[] WeldVertices(ProBuilderMesh mesh, IEnumerable<int> indexes, float neighborRadius) { }

	// RVA: 0x2112BE0 Offset: 0x21111E0 VA: 0x182112BE0
	internal static FaceRebuildData ExplodeVertex(IList<Vertex> vertices, IList<SimpleTuple<WingedEdge, int>> edgeAndCommonIndex, float distance, out Dictionary<int, List<int>> appendedVertices) { }

	// RVA: 0x2112B90 Offset: 0x2111190 VA: 0x182112B90
	private static Edge AlignEdgeWithDirection(EdgeLookup edge, int commonIndex) { }
}

