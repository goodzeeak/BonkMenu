// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal static class P2T // TypeDefIndex: 13650
{
	// Fields
	private static TriangulationAlgorithm _defaultAlgorithm; // 0x0

	// Methods

	// RVA: 0x207B1F0 Offset: 0x20797F0 VA: 0x18207B1F0
	public static void Triangulate(PolygonSet ps) { }

	// RVA: 0x207B020 Offset: 0x2079620 VA: 0x18207B020
	public static void Triangulate(Polygon p) { }

	// RVA: 0x207B0A0 Offset: 0x20796A0 VA: 0x18207B0A0
	public static void Triangulate(ConstrainedPointSet cps) { }

	// RVA: 0x207B120 Offset: 0x2079720 VA: 0x18207B120
	public static void Triangulate(PointSet ps) { }

	// RVA: 0x207ADA0 Offset: 0x20793A0 VA: 0x18207ADA0
	public static TriangulationContext CreateContext(TriangulationAlgorithm algorithm) { }

	// RVA: 0x207B1A0 Offset: 0x20797A0 VA: 0x18207B1A0
	public static void Triangulate(TriangulationAlgorithm algorithm, Triangulatable t) { }

	// RVA: 0x207AF60 Offset: 0x2079560 VA: 0x18207AF60
	public static void Triangulate(TriangulationContext tcx) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void Warmup() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class Polygon : Triangulatable // TypeDefIndex: 13651
{
	// Fields
	protected List<TriangulationPoint> _points; // 0x10
	protected List<TriangulationPoint> _steinerPoints; // 0x18
	protected List<Polygon> _holes; // 0x20
	protected List<DelaunayTriangle> _triangles; // 0x28
	protected PolygonPoint _last; // 0x30

	// Properties
	public TriangulationMode TriangulationMode { get; }
	public IList<TriangulationPoint> Points { get; }
	public IList<DelaunayTriangle> Triangles { get; }
	public IList<Polygon> Holes { get; }

	// Methods

	// RVA: 0x207D790 Offset: 0x207BD90 VA: 0x18207D790
	public void .ctor(IList<PolygonPoint> points) { }

	// RVA: 0x207D710 Offset: 0x207BD10 VA: 0x18207D710
	public void .ctor(IEnumerable<PolygonPoint> points) { }

	// RVA: 0x207D9E0 Offset: 0x207BFE0 VA: 0x18207D9E0
	public void .ctor(PolygonPoint[] points) { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 10
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x207CD90 Offset: 0x207B390 VA: 0x18207CD90
	public void AddSteinerPoint(TriangulationPoint point) { }

	// RVA: 0x207CE90 Offset: 0x207B490 VA: 0x18207CE90
	public void AddSteinerPoints(List<TriangulationPoint> points) { }

	// RVA: 0x207D050 Offset: 0x207B650 VA: 0x18207D050
	public void ClearSteinerPoints() { }

	// RVA: 0x207C890 Offset: 0x207AE90 VA: 0x18207C890
	public void AddHole(Polygon poly) { }

	// RVA: 0x207D110 Offset: 0x207B710 VA: 0x18207D110
	public void InsertPointAfter(PolygonPoint point, PolygonPoint newPoint) { }

	// RVA: 0x207CA90 Offset: 0x207B090 VA: 0x18207CA90
	public void AddPoints(IEnumerable<PolygonPoint> list) { }

	// RVA: 0x207C990 Offset: 0x207AF90 VA: 0x18207C990
	public void AddPoint(PolygonPoint p) { }

	// RVA: 0x207D670 Offset: 0x207BC70 VA: 0x18207D670
	public void RemovePoint(PolygonPoint p) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	public IList<TriangulationPoint> get_Points() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 6
	public IList<DelaunayTriangle> get_Triangles() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public IList<Polygon> get_Holes() { }

	// RVA: 0x207CF40 Offset: 0x207B540 VA: 0x18207CF40 Slot: 7
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x207CFF0 Offset: 0x207B5F0 VA: 0x18207CFF0 Slot: 8
	public void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	// RVA: 0x207D0B0 Offset: 0x207B6B0 VA: 0x18207D0B0 Slot: 9
	public void ClearTriangles() { }

	// RVA: 0x207D260 Offset: 0x207B860 VA: 0x18207D260 Slot: 4
	public void Prepare(TriangulationContext tcx) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PolygonPoint : TriangulationPoint // TypeDefIndex: 13652
{
	// Fields
	[CompilerGenerated]
	private PolygonPoint <Next>k__BackingField; // 0x30
	[CompilerGenerated]
	private PolygonPoint <Previous>k__BackingField; // 0x38

	// Properties
	public PolygonPoint Next { get; set; }
	public PolygonPoint Previous { get; set; }

	// Methods

	// RVA: 0x207C600 Offset: 0x207AC00 VA: 0x18207C600
	public void .ctor(double x, double y, int index = -1) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public PolygonPoint get_Next() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_Next(PolygonPoint value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public PolygonPoint get_Previous() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_Previous(PolygonPoint value) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PolygonSet // TypeDefIndex: 13653
{
	// Fields
	protected List<Polygon> _polygons; // 0x10

	// Properties
	public IEnumerable<Polygon> Polygons { get; }

	// Methods

	// RVA: 0x207C810 Offset: 0x207AE10 VA: 0x18207C810
	public void .ctor() { }

	// RVA: 0x207C700 Offset: 0x207AD00 VA: 0x18207C700
	public void .ctor(Polygon poly) { }

	// RVA: 0x207C650 Offset: 0x207AC50 VA: 0x18207C650
	public void Add(Polygon p) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public IEnumerable<Polygon> get_Polygons() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DelaunayTriangle // TypeDefIndex: 13654
{
	// Fields
	public FixedArray3<TriangulationPoint> Points; // 0x10
	public FixedArray3<DelaunayTriangle> Neighbors; // 0x28
	public FixedBitArray3 EdgeIsConstrained; // 0x40
	public FixedBitArray3 EdgeIsDelaunay; // 0x43
	[CompilerGenerated]
	private bool <IsInterior>k__BackingField; // 0x46

	// Properties
	public bool IsInterior { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x207A9B0 Offset: 0x2078FB0 VA: 0x18207A9B0
	public bool get_IsInterior() { }

	[CompilerGenerated]
	// RVA: 0x207A9C0 Offset: 0x2078FC0 VA: 0x18207A9C0
	public void set_IsInterior(bool value) { }

	// RVA: 0x207A910 Offset: 0x2078F10 VA: 0x18207A910
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) { }

	// RVA: 0x2079570 Offset: 0x2077B70 VA: 0x182079570
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x2079540 Offset: 0x2077B40 VA: 0x182079540
	public int IndexCWFrom(TriangulationPoint p) { }

	// RVA: 0x2079510 Offset: 0x2077B10 VA: 0x182079510
	public int IndexCCWFrom(TriangulationPoint p) { }

	// RVA: 0x2079060 Offset: 0x2077660 VA: 0x182079060
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x2079F30 Offset: 0x2078530 VA: 0x182079F30
	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) { }

	// RVA: 0x2079CE0 Offset: 0x20782E0 VA: 0x182079CE0
	public void MarkNeighbor(DelaunayTriangle t) { }

	// RVA: 0x207A190 Offset: 0x2078790 VA: 0x18207A190
	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x207A100 Offset: 0x2078700 VA: 0x18207A100
	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point) { }

	// RVA: 0x207A070 Offset: 0x2078670 VA: 0x18207A070
	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point) { }

	// RVA: 0x207A000 Offset: 0x2078600 VA: 0x18207A000
	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point) { }

	// RVA: 0x207A1D0 Offset: 0x20787D0 VA: 0x18207A1D0
	public TriangulationPoint PointCCWFrom(TriangulationPoint point) { }

	// RVA: 0x207A240 Offset: 0x2078840 VA: 0x18207A240
	public TriangulationPoint PointCWFrom(TriangulationPoint point) { }

	// RVA: 0x207A2B0 Offset: 0x20788B0 VA: 0x18207A2B0
	private void RotateCW() { }

	// RVA: 0x2079610 Offset: 0x2077C10 VA: 0x182079610
	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint) { }

	// RVA: 0x207A760 Offset: 0x2078D60 VA: 0x18207A760 Slot: 3
	public override string ToString() { }

	// RVA: 0x2079B70 Offset: 0x2078170 VA: 0x182079B70
	public void MarkNeighborEdges() { }

	// RVA: 0x2079A40 Offset: 0x2078040 VA: 0x182079A40
	public void MarkEdge(DelaunayTriangle triangle) { }

	// RVA: 0x2079870 Offset: 0x2077E70 VA: 0x182079870
	public void MarkEdge(List<DelaunayTriangle> tList) { }

	// RVA: 0x2079800 Offset: 0x2077E00 VA: 0x182079800
	public void MarkConstrainedEdge(int index) { }

	// RVA: 0x2079750 Offset: 0x2077D50 VA: 0x182079750
	public void MarkConstrainedEdge(DTSweepConstraint edge) { }

	// RVA: 0x2079780 Offset: 0x2077D80 VA: 0x182079780
	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q) { }

	// RVA: 0x2078DC0 Offset: 0x20773C0 VA: 0x182078DC0
	public double Area() { }

	// RVA: 0x2078ED0 Offset: 0x20774D0 VA: 0x182078ED0
	public TriangulationPoint Centroid() { }

	// RVA: 0x20790B0 Offset: 0x20776B0 VA: 0x1820790B0
	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x2079210 Offset: 0x2077810 VA: 0x182079210
	public bool GetConstrainedEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x20792B0 Offset: 0x20778B0 VA: 0x1820792B0
	public bool GetConstrainedEdgeCW(TriangulationPoint p) { }

	// RVA: 0x2079190 Offset: 0x2077790 VA: 0x182079190
	public bool GetConstrainedEdgeAcross(TriangulationPoint p) { }

	// RVA: 0x207A410 Offset: 0x2078A10 VA: 0x18207A410
	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x207A4C0 Offset: 0x2078AC0 VA: 0x18207A4C0
	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x207A380 Offset: 0x2078980 VA: 0x18207A380
	public void SetConstrainedEdgeAcross(TriangulationPoint p, bool ce) { }

	// RVA: 0x20793D0 Offset: 0x20779D0 VA: 0x1820793D0
	public bool GetDelaunayEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x2079470 Offset: 0x2077A70 VA: 0x182079470
	public bool GetDelaunayEdgeCW(TriangulationPoint p) { }

	// RVA: 0x2079350 Offset: 0x2077950 VA: 0x182079350
	public bool GetDelaunayEdgeAcross(TriangulationPoint p) { }

	// RVA: 0x207A600 Offset: 0x2078C00 VA: 0x18207A600
	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x207A6B0 Offset: 0x2078CB0 VA: 0x18207A6B0
	public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x207A570 Offset: 0x2078B70 VA: 0x18207A570
	public void SetDelaunayEdgeAcross(TriangulationPoint p, bool ce) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class AdvancingFront // TypeDefIndex: 13655
{
	// Fields
	public AdvancingFrontNode Head; // 0x10
	public AdvancingFrontNode Tail; // 0x18
	protected AdvancingFrontNode Search; // 0x20

	// Methods

	// RVA: 0x2072D90 Offset: 0x2071390 VA: 0x182072D90
	public void .ctor(AdvancingFrontNode head, AdvancingFrontNode tail) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x2072C90 Offset: 0x2071290 VA: 0x182072C90 Slot: 3
	public override string ToString() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	private AdvancingFrontNode FindSearchNode(double x) { }

	// RVA: 0x2072AD0 Offset: 0x20710D0 VA: 0x182072AD0
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x2072A20 Offset: 0x2071020 VA: 0x182072A20
	private AdvancingFrontNode LocateNode(double x) { }

	// RVA: 0x2072B90 Offset: 0x2071190 VA: 0x182072B90
	public AdvancingFrontNode LocatePoint(TriangulationPoint point) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class AdvancingFrontNode // TypeDefIndex: 13656
{
	// Fields
	public AdvancingFrontNode Next; // 0x10
	public AdvancingFrontNode Prev; // 0x18
	public double Value; // 0x20
	public TriangulationPoint Point; // 0x28
	public DelaunayTriangle Triangle; // 0x30

	// Properties
	public bool HasNext { get; }
	public bool HasPrev { get; }

	// Methods

	// RVA: 0x20729D0 Offset: 0x2070FD0 VA: 0x1820729D0
	public void .ctor(TriangulationPoint point) { }

	// RVA: 0x13C33E0 Offset: 0x13C19E0 VA: 0x1813C33E0
	public bool get_HasNext() { }

	// RVA: 0x136E330 Offset: 0x136C930 VA: 0x18136E330
	public bool get_HasPrev() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal static class DTSweep // TypeDefIndex: 13658
{
	// Fields
	private const double PI_div2 = 1.5707963267948966;
	private const double PI_3div4 = 2.356194490192345;

	// Methods

	// RVA: 0x2078BD0 Offset: 0x20771D0 VA: 0x182078BD0
	public static void Triangulate(DTSweepContext tcx) { }

	// RVA: 0x20789A0 Offset: 0x2076FA0 VA: 0x1820789A0
	private static void Sweep(DTSweepContext tcx) { }

	// RVA: 0x2076360 Offset: 0x2074960 VA: 0x182076360
	private static void FinalizationConvexHull(DTSweepContext tcx) { }

	// RVA: 0x2078C20 Offset: 0x2077220 VA: 0x182078C20
	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) { }

	// RVA: 0x2076C70 Offset: 0x2075270 VA: 0x182076C70
	private static void FinalizationPolygon(DTSweepContext tcx) { }

	// RVA: 0x2078200 Offset: 0x2076800 VA: 0x182078200
	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point) { }

	// RVA: 0x2077CC0 Offset: 0x20762C0 VA: 0x182077CC0
	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) { }

	// RVA: 0x2074680 Offset: 0x2072C80 VA: 0x182074680
	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2075120 Offset: 0x2073720 VA: 0x182075120
	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2075E50 Offset: 0x2074450 VA: 0x182075E50
	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2075F70 Offset: 0x2074570 VA: 0x182075F70
	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2075C00 Offset: 0x2074200 VA: 0x182075C00
	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2075AA0 Offset: 0x20740A0 VA: 0x182075AA0
	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2075880 Offset: 0x2073E80 VA: 0x182075880
	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2075760 Offset: 0x2073D60 VA: 0x182075760
	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2075520 Offset: 0x2073B20 VA: 0x182075520
	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x20753C0 Offset: 0x20739C0 VA: 0x1820753C0
	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x2077870 Offset: 0x2075E70 VA: 0x182077870
	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) { }

	// RVA: 0x2074820 Offset: 0x2072E20 VA: 0x182074820
	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) { }

	// RVA: 0x2078870 Offset: 0x2076E70 VA: 0x182078870
	private static void SplitEdge(TriangulationPoint ep, TriangulationPoint eq, TriangulationPoint p) { }

	// RVA: 0x2076E60 Offset: 0x2075460 VA: 0x182076E60
	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x2077F30 Offset: 0x2076530 VA: 0x182077F30
	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op) { }

	// RVA: 0x2078090 Offset: 0x2076690 VA: 0x182078090
	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) { }

	// RVA: 0x2077430 Offset: 0x2075A30 VA: 0x182077430
	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x2074AA0 Offset: 0x20730A0 VA: 0x182074AA0
	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n) { }

	// RVA: 0x2074E70 Offset: 0x2073470 VA: 0x182074E70
	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x2074C60 Offset: 0x2073260 VA: 0x182074C60
	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x2077970 Offset: 0x2075F70 VA: 0x182077970
	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x2077750 Offset: 0x2075D50 VA: 0x182077750
	private static double HoleAngle(AdvancingFrontNode node) { }

	// RVA: 0x20745B0 Offset: 0x2072BB0 VA: 0x1820745B0
	private static double BasinAngle(AdvancingFrontNode node) { }

	// RVA: 0x2076190 Offset: 0x2074790 VA: 0x182076190
	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x20779E0 Offset: 0x2075FE0 VA: 0x1820779E0
	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t) { }

	// RVA: 0x2078560 Offset: 0x2076B60 VA: 0x182078560
	private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepBasin // TypeDefIndex: 13659
{
	// Fields
	public AdvancingFrontNode leftNode; // 0x10
	public AdvancingFrontNode bottomNode; // 0x18
	public AdvancingFrontNode rightNode; // 0x20
	public double width; // 0x28
	public bool leftHighest; // 0x30

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepConstraint : TriangulationConstraint // TypeDefIndex: 13660
{
	// Methods

	// RVA: 0x2073190 Offset: 0x2071790 VA: 0x182073190
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepContext : TriangulationContext // TypeDefIndex: 13661
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	[CompilerGenerated]
	private TriangulationPoint <Head>k__BackingField; // 0x50
	[CompilerGenerated]
	private TriangulationPoint <Tail>k__BackingField; // 0x58
	public DTSweepBasin Basin; // 0x60
	public DTSweepEdgeEvent EdgeEvent; // 0x68
	private DTSweepPointComparator _comparator; // 0x70

	// Properties
	public TriangulationPoint Head { get; set; }
	public TriangulationPoint Tail { get; set; }
	public override bool IsDebugEnabled { get; set; }
	public override TriangulationAlgorithm Algorithm { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public TriangulationPoint get_Head() { }

	[CompilerGenerated]
	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_Head(TriangulationPoint value) { }

	[CompilerGenerated]
	// RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	public TriangulationPoint get_Tail() { }

	[CompilerGenerated]
	// RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x2074020 Offset: 0x2072620 VA: 0x182074020
	public void .ctor() { }

	// RVA: 0x9E9940 Offset: 0x9E7F40 VA: 0x1809E9940 Slot: 8
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x20741B0 Offset: 0x20727B0 VA: 0x1820741B0 Slot: 9
	protected override void set_IsDebugEnabled(bool value) { }

	// RVA: 0x2073FC0 Offset: 0x20725C0 VA: 0x182073FC0
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x2073B40 Offset: 0x2072140 VA: 0x182073B40
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x2073A30 Offset: 0x2072030 VA: 0x182073A30
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x2073350 Offset: 0x2071950 VA: 0x182073350 Slot: 7
	public override void Clear() { }

	// RVA: 0x2073330 Offset: 0x2071930 VA: 0x182073330
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x2073330 Offset: 0x2071930 VA: 0x182073330
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x2073880 Offset: 0x2071E80 VA: 0x182073880
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x2073420 Offset: 0x2071A20 VA: 0x182073420
	public void CreateAdvancingFront() { }

	// RVA: 0x2073950 Offset: 0x2071F50 VA: 0x182073950
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x2073BC0 Offset: 0x20721C0 VA: 0x182073BC0 Slot: 5
	public override void PrepareTriangulation(Triangulatable t) { }

	// RVA: 0x2073770 Offset: 0x2071D70 VA: 0x182073770
	public void FinalizeTriangulation() { }

	// RVA: 0x2073B50 Offset: 0x2072150 VA: 0x182073B50 Slot: 6
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 4
	public override TriangulationAlgorithm get_Algorithm() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepDebugContext : TriangulationDebugContext // TypeDefIndex: 13662
{
	// Fields
	private DelaunayTriangle _primaryTriangle; // 0x18
	private DelaunayTriangle _secondaryTriangle; // 0x20
	private TriangulationPoint _activePoint; // 0x28
	private AdvancingFrontNode _activeNode; // 0x30
	private DTSweepConstraint _activeConstraint; // 0x38

	// Properties
	public DelaunayTriangle PrimaryTriangle { get; set; }
	public DelaunayTriangle SecondaryTriangle { get; set; }
	public TriangulationPoint ActivePoint { get; set; }
	public AdvancingFrontNode ActiveNode { get; set; }
	public DTSweepConstraint ActiveConstraint { get; set; }
	public bool IsDebugContext { get; }

	// Methods

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public DelaunayTriangle get_PrimaryTriangle() { }

	// RVA: 0x2074480 Offset: 0x2072A80 VA: 0x182074480
	public void set_PrimaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public DelaunayTriangle get_SecondaryTriangle() { }

	// RVA: 0x20744E0 Offset: 0x2072AE0 VA: 0x1820744E0
	public void set_SecondaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public TriangulationPoint get_ActivePoint() { }

	// RVA: 0x2074420 Offset: 0x2072A20 VA: 0x182074420
	public void set_ActivePoint(TriangulationPoint value) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public AdvancingFrontNode get_ActiveNode() { }

	// RVA: 0x20743C0 Offset: 0x20729C0 VA: 0x1820743C0
	public void set_ActiveNode(AdvancingFrontNode value) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public DTSweepConstraint get_ActiveConstraint() { }

	// RVA: 0x2074360 Offset: 0x2072960 VA: 0x182074360
	public void set_ActiveConstraint(DTSweepConstraint value) { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(DTSweepContext tcx) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	public bool get_IsDebugContext() { }

	// RVA: 0x2074240 Offset: 0x2072840 VA: 0x182074240 Slot: 4
	public override void Clear() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepEdgeEvent // TypeDefIndex: 13663
{
	// Fields
	public DTSweepConstraint ConstrainedEdge; // 0x10
	public bool Right; // 0x18

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepPointComparator : IComparer<TriangulationPoint> // TypeDefIndex: 13664
{
	// Methods

	// RVA: 0x2074540 Offset: 0x2072B40 VA: 0x182074540 Slot: 4
	public int Compare(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointOnEdgeException : NotImplementedException // TypeDefIndex: 13665
{
	// Fields
	public readonly TriangulationPoint A; // 0x90
	public readonly TriangulationPoint B; // 0x98
	public readonly TriangulationPoint C; // 0xA0

	// Methods

	// RVA: 0x207B8D0 Offset: 0x2079ED0 VA: 0x18207B8D0
	public void .ctor(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal interface Triangulatable // TypeDefIndex: 13666
{
	// Properties
	public abstract IList<TriangulationPoint> Points { get; }
	public abstract IList<DelaunayTriangle> Triangles { get; }
	public abstract TriangulationMode TriangulationMode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Prepare(TriangulationContext tcx);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IList<TriangulationPoint> get_Points();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IList<DelaunayTriangle> get_Triangles();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddTriangle(DelaunayTriangle t);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddTriangles(IEnumerable<DelaunayTriangle> list);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ClearTriangles();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TriangulationMode get_TriangulationMode();
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum Orientation // TypeDefIndex: 13667
{
	// Fields
	public int value__; // 0x0
	public const Orientation CW = 0;
	public const Orientation CCW = 1;
	public const Orientation Collinear = 2;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class ConstrainedPointSet : PointSet // TypeDefIndex: 13668
{
	// Fields
	[CompilerGenerated]
	private int[] <EdgeIndex>k__BackingField; // 0x20

	// Properties
	public int[] EdgeIndex { get; set; }
	public override TriangulationMode TriangulationMode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public int[] get_EdgeIndex() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_EdgeIndex(int[] value) { }

	// RVA: 0x20730E0 Offset: 0x20716E0 VA: 0x1820730E0
	public void .ctor(List<TriangulationPoint> points, int[] index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 11
	public override TriangulationMode get_TriangulationMode() { }

	// RVA: 0x2072DF0 Offset: 0x20713F0 VA: 0x182072DF0 Slot: 12
	public override void Prepare(TriangulationContext tcx) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointSet : Triangulatable // TypeDefIndex: 13669
{
	// Fields
	[CompilerGenerated]
	private IList<TriangulationPoint> <Points>k__BackingField; // 0x10
	[CompilerGenerated]
	private IList<DelaunayTriangle> <Triangles>k__BackingField; // 0x18

	// Properties
	public IList<TriangulationPoint> Points { get; set; }
	public IList<DelaunayTriangle> Triangles { get; set; }
	public virtual TriangulationMode TriangulationMode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	public IList<TriangulationPoint> get_Points() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_Points(IList<TriangulationPoint> value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 6
	public IList<DelaunayTriangle> get_Triangles() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_Triangles(IList<DelaunayTriangle> value) { }

	// RVA: 0x207BD70 Offset: 0x207A370 VA: 0x18207BD70
	public void .ctor(List<TriangulationPoint> points) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 11
	public virtual TriangulationMode get_TriangulationMode() { }

	// RVA: 0x207B950 Offset: 0x2079F50 VA: 0x18207B950 Slot: 7
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x207B9B0 Offset: 0x2079FB0 VA: 0x18207B9B0 Slot: 8
	public void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	// RVA: 0x207BC10 Offset: 0x207A210 VA: 0x18207BC10 Slot: 9
	public void ClearTriangles() { }

	// RVA: 0x207BC60 Offset: 0x207A260 VA: 0x18207BC60 Slot: 12
	public virtual void Prepare(TriangulationContext tcx) { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum TriangulationAlgorithm // TypeDefIndex: 13670
{
	// Fields
	public int value__; // 0x0
	public const TriangulationAlgorithm DTSweep = 0;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationConstraint // TypeDefIndex: 13671
{
	// Fields
	public TriangulationPoint P; // 0x10
	public TriangulationPoint Q; // 0x18

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal abstract class TriangulationContext // TypeDefIndex: 13672
{
	// Fields
	[CompilerGenerated]
	private TriangulationDebugContext <DebugContext>k__BackingField; // 0x10
	public readonly List<DelaunayTriangle> Triangles; // 0x18
	public readonly List<TriangulationPoint> Points; // 0x20
	[CompilerGenerated]
	private TriangulationMode <TriangulationMode>k__BackingField; // 0x28
	[CompilerGenerated]
	private Triangulatable <Triangulatable>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <StepCount>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsDebugEnabled>k__BackingField; // 0x3C

	// Properties
	public TriangulationDebugContext DebugContext { get; set; }
	public TriangulationMode TriangulationMode { get; set; }
	public Triangulatable Triangulatable { get; set; }
	public int StepCount { get; set; }
	public abstract TriangulationAlgorithm Algorithm { get; }
	public virtual bool IsDebugEnabled { get; set; }
	public DTSweepDebugContext DTDebugContext { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public TriangulationDebugContext get_DebugContext() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	protected void set_DebugContext(TriangulationDebugContext value) { }

	[CompilerGenerated]
	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public TriangulationMode get_TriangulationMode() { }

	[CompilerGenerated]
	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	protected void set_TriangulationMode(TriangulationMode value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public Triangulatable get_Triangulatable() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_Triangulatable(Triangulatable value) { }

	[CompilerGenerated]
	// RVA: 0x4DD990 Offset: 0x4DBF90 VA: 0x1804DD990
	public int get_StepCount() { }

	[CompilerGenerated]
	// RVA: 0x16EE2C0 Offset: 0x16EC8C0 VA: 0x1816EE2C0
	private void set_StepCount(int value) { }

	// RVA: 0x1DF4CA0 Offset: 0x1DF32A0 VA: 0x181DF4CA0
	public void Done() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TriangulationAlgorithm get_Algorithm();

	// RVA: 0x207DA70 Offset: 0x207C070 VA: 0x18207DA70 Slot: 5
	public virtual void PrepareTriangulation(Triangulatable t) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b);

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Update(string message) { }

	// RVA: 0x207D9F0 Offset: 0x207BFF0 VA: 0x18207D9F0 Slot: 7
	public virtual void Clear() { }

	[CompilerGenerated]
	// RVA: 0x9E9940 Offset: 0x9E7F40 VA: 0x1809E9940 Slot: 8
	public virtual bool get_IsDebugEnabled() { }

	[CompilerGenerated]
	// RVA: 0x9E9950 Offset: 0x9E7F50 VA: 0x1809E9950 Slot: 9
	protected virtual void set_IsDebugEnabled(bool value) { }

	// RVA: 0x207DC10 Offset: 0x207C210 VA: 0x18207DC10
	public DTSweepDebugContext get_DTDebugContext() { }

	// RVA: 0x207DB50 Offset: 0x207C150 VA: 0x18207DB50
	protected void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal abstract class TriangulationDebugContext // TypeDefIndex: 13673
{
	// Fields
	protected TriangulationContext _tcx; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(TriangulationContext tcx) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Clear();
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum TriangulationMode // TypeDefIndex: 13674
{
	// Fields
	public int value__; // 0x0
	public const TriangulationMode Unconstrained = 0;
	public const TriangulationMode Constrained = 1;
	public const TriangulationMode Polygon = 2;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationPoint // TypeDefIndex: 13675
{
	// Fields
	public const int INSERTED_INDEX = -1;
	public const int INVALID_INDEX = -2;
	[CompilerGenerated]
	private List<DTSweepConstraint> <Edges>k__BackingField; // 0x10
	public double X; // 0x18
	public double Y; // 0x20
	public int Index; // 0x28

	// Properties
	public List<DTSweepConstraint> Edges { get; set; }
	public float Xf { get; set; }
	public float Yf { get; set; }
	public bool HasEdges { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public List<DTSweepConstraint> get_Edges() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_Edges(List<DTSweepConstraint> value) { }

	// RVA: 0x207C600 Offset: 0x207AC00 VA: 0x18207C600
	public void .ctor(double x, double y, int index = -1) { }

	// RVA: 0x207DDA0 Offset: 0x207C3A0 VA: 0x18207DDA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x207DEC0 Offset: 0x207C4C0 VA: 0x18207DEC0
	public float get_Xf() { }

	// RVA: 0x207DEE0 Offset: 0x207C4E0 VA: 0x18207DEE0
	public void set_Xf(float value) { }

	// RVA: 0x207DED0 Offset: 0x207C4D0 VA: 0x18207DED0
	public float get_Yf() { }

	// RVA: 0x207DEF0 Offset: 0x207C4F0 VA: 0x18207DEF0
	public void set_Yf(float value) { }

	// RVA: 0x207DCA0 Offset: 0x207C2A0 VA: 0x18207DCA0
	public void AddEdge(DTSweepConstraint e) { }

	// RVA: 0x13C33E0 Offset: 0x13C19E0 VA: 0x1813C33E0
	public bool get_HasEdges() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationUtil // TypeDefIndex: 13676
{
	// Fields
	public static double EPSILON; // 0x0

	// Methods

	// RVA: 0x207E0D0 Offset: 0x207C6D0 VA: 0x18207E0D0
	public static bool SmartIncircle(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x207DF00 Offset: 0x207C500 VA: 0x18207DF00
	public static bool InScanArea(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x207DFC0 Offset: 0x207C5C0 VA: 0x18207DFC0
	public static Orientation Orient2d(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x207E210 Offset: 0x207C810 VA: 0x18207E210
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointGenerator // TypeDefIndex: 13677
{
	// Fields
	private static readonly Random RNG; // 0x0

	// Methods

	// RVA: 0x207B4B0 Offset: 0x2079AB0 VA: 0x18207B4B0
	public static List<TriangulationPoint> UniformDistribution(int n, double scale) { }

	// RVA: 0x207B6C0 Offset: 0x2079CC0 VA: 0x18207B6C0
	public static List<TriangulationPoint> UniformGrid(int n, double scale) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x207B850 Offset: 0x2079E50 VA: 0x18207B850
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PolygonGenerator // TypeDefIndex: 13678
{
	// Fields
	private static readonly Random RNG; // 0x0
	private static double PI_2; // 0x8

	// Methods

	// RVA: 0x207C140 Offset: 0x207A740 VA: 0x18207C140
	public static Polygon RandomCircleSweep(double scale, int vertexCount) { }

	// RVA: 0x207BE00 Offset: 0x207A400 VA: 0x18207BE00
	public static Polygon RandomCircleSweep2(double scale, int vertexCount) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x207C570 Offset: 0x207AB70 VA: 0x18207C570
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
[DefaultMember("Item")]
internal struct FixedArray3<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 13680
{
	// Fields
	public T _0; // 0x0
	public T _1; // 0x0
	public T _2; // 0x0

	// Properties
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D6B0 Offset: 0x100BCB0 VA: 0x18100D6B0
	|-FixedArray3<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D720 Offset: 0x100BD20 VA: 0x18100D720
	|-FixedArray3<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D420 Offset: 0x100BA20 VA: 0x18100D420
	|-FixedArray3<object>.Contains
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D5F0 Offset: 0x100BBF0 VA: 0x18100D5F0
	|-FixedArray3<object>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D3D0 Offset: 0x100B9D0 VA: 0x18100D3D0
	|-FixedArray3<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Clear(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D2E0 Offset: 0x100B8E0 VA: 0x18100D2E0
	|-FixedArray3<object>.Clear
	*/

	[IteratorStateMachine(typeof(FixedArray3.<Enumerate>d__10<T>))]
	// RVA: -1 Offset: -1
	private IEnumerable<T> Enumerate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D4A0 Offset: 0x100BAA0 VA: 0x18100D4A0
	|-FixedArray3<object>.Enumerate
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D560 Offset: 0x100BB60 VA: 0x18100D560
	|-FixedArray3<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D670 Offset: 0x100BC70 VA: 0x18100D670
	|-FixedArray3<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
[DefaultMember("Item")]
internal struct FixedBitArray3 : IEnumerable<bool>, IEnumerable // TypeDefIndex: 13682
{
	// Fields
	public bool _0; // 0x0
	public bool _1; // 0x1
	public bool _2; // 0x2

	// Properties
	public bool Item { get; set; }

	// Methods

	// RVA: 0x207ACC0 Offset: 0x20792C0 VA: 0x18207ACC0
	public bool get_Item(int index) { }

	// RVA: 0x207AD30 Offset: 0x2079330 VA: 0x18207AD30
	public void set_Item(int index, bool value) { }

	// RVA: 0x207AA80 Offset: 0x2079080 VA: 0x18207AA80
	public bool Contains(bool value) { }

	// RVA: 0x207AC20 Offset: 0x2079220 VA: 0x18207AC20
	public int IndexOf(bool value) { }

	// RVA: 0x207AA70 Offset: 0x2079070 VA: 0x18207AA70
	public void Clear() { }

	// RVA: 0x207A9D0 Offset: 0x2078FD0 VA: 0x18207A9D0
	public void Clear(bool value) { }

	[IteratorStateMachine(typeof(FixedBitArray3.<Enumerate>d__10))]
	// RVA: 0x207AB10 Offset: 0x2079110 VA: 0x18207AB10
	private IEnumerable<bool> Enumerate() { }

	// RVA: 0x207AB80 Offset: 0x2079180 VA: 0x18207AB80 Slot: 4
	public IEnumerator<bool> GetEnumerator() { }

	// RVA: 0x207ACB0 Offset: 0x20792B0 VA: 0x18207ACB0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

