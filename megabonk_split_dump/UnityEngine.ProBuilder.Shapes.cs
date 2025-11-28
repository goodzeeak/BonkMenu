// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Arch")]
public class Arch : Shape // TypeDefIndex: 11681
{
	// Fields
	[Min(0.01)]
	[SerializeField]
	private float m_Thickness; // 0x10
	[Range(2, 200)]
	[SerializeField]
	private int m_NumberOfSides; // 0x14
	[Range(1, 360)]
	[SerializeField]
	private float m_ArchDegrees; // 0x18
	[SerializeField]
	private bool m_EndCaps; // 0x1C
	[SerializeField]
	private bool m_Smooth; // 0x1D

	// Methods

	// RVA: 0x20CECA0 Offset: 0x20CD2A0 VA: 0x1820CECA0 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20CED60 Offset: 0x20CD360 VA: 0x1820CED60
	private Vector3[] GetFace(Vector2 vertex1, Vector2 vertex2, float depth) { }

	// RVA: 0x20CEEB0 Offset: 0x20CD4B0 VA: 0x1820CEEB0 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20CFE10 Offset: 0x20CE410 VA: 0x1820CFE10
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Cone")]
public class Cone : Shape // TypeDefIndex: 11682
{
	// Fields
	[Range(3, 64)]
	[SerializeField]
	internal int m_NumberOfSides; // 0x10
	private float m_Radius; // 0x14
	[SerializeField]
	private bool m_Smooth; // 0x18

	// Methods

	// RVA: 0x20CFE40 Offset: 0x20CE440 VA: 0x1820CFE40 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20D0B30 Offset: 0x20CF130 VA: 0x1820D0B30 Slot: 4
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x20CFEF0 Offset: 0x20CE4F0 VA: 0x1820CFEF0 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20D0D30 Offset: 0x20CF330 VA: 0x1820D0D30
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Cube")]
public class Cube : Shape // TypeDefIndex: 11683
{
	// Fields
	private static readonly Vector3[] k_CubeVertices; // 0x0
	private static readonly int[] k_CubeTriangles; // 0x8

	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20D0D50 Offset: 0x20CF350 VA: 0x1820D0D50 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x20D1000 Offset: 0x20CF600 VA: 0x1820D1000
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Cylinder")]
public class Cylinder : Shape // TypeDefIndex: 11684
{
	// Fields
	[SerializeField]
	[Range(3, 64)]
	private int m_AxisDivisions; // 0x10
	[Min(0)]
	[SerializeField]
	private int m_HeightCuts; // 0x14
	[SerializeField]
	private bool m_Smooth; // 0x18

	// Methods

	// RVA: 0x20D1270 Offset: 0x20CF870 VA: 0x1820D1270 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20D2170 Offset: 0x20D0770 VA: 0x1820D2170 Slot: 4
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x20D1390 Offset: 0x20CF990 VA: 0x1820D1390 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20D0D30 Offset: 0x20CF330 VA: 0x1820D0D30
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Door")]
public class Door : Shape // TypeDefIndex: 11685
{
	// Fields
	[Min(0.01)]
	[SerializeField]
	private float m_DoorHeight; // 0x10
	[Min(0.01)]
	[SerializeField]
	private float m_LegWidth; // 0x14

	// Methods

	// RVA: 0x20D21D0 Offset: 0x20D07D0 VA: 0x1820D21D0 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20D22B0 Offset: 0x20D08B0 VA: 0x1820D22B0 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20D3ED0 Offset: 0x20D24D0 VA: 0x1820D3ED0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Pipe")]
public class Pipe : Shape // TypeDefIndex: 11686
{
	// Fields
	[Min(0.01)]
	[SerializeField]
	private float m_Thickness; // 0x10
	[Range(3, 64)]
	[SerializeField]
	private int m_NumberOfSides; // 0x14
	[Range(0, 31)]
	[SerializeField]
	private int m_HeightCuts; // 0x18
	[SerializeField]
	private bool m_Smooth; // 0x1C

	// Methods

	// RVA: 0x20D3EF0 Offset: 0x20D24F0 VA: 0x1820D3EF0 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20D2170 Offset: 0x20D0770 VA: 0x1820D2170 Slot: 4
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x20D3FA0 Offset: 0x20D25A0 VA: 0x1820D3FA0 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20D4C80 Offset: 0x20D3280 VA: 0x1820D4C80
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Plane")]
public class Plane : Shape // TypeDefIndex: 11687
{
	// Fields
	[Min(0)]
	[SerializeField]
	private int m_HeightSegments; // 0x10
	[Min(0)]
	[SerializeField]
	private int m_WidthSegments; // 0x14

	// Methods

	// RVA: 0x20D4CA0 Offset: 0x20D32A0 VA: 0x1820D4CA0 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20D4D80 Offset: 0x20D3380 VA: 0x1820D4D80 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20D5040 Offset: 0x20D3640 VA: 0x1820D5040
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Prism")]
public class Prism : Shape // TypeDefIndex: 11688
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20D5060 Offset: 0x20D3660 VA: 0x1820D5060 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[AddComponentMenu("")]
[DisallowMultipleComponent]
internal sealed class ProBuilderShape : MonoBehaviour // TypeDefIndex: 11689
{
	// Fields
	[SerializeReference]
	private Shape m_Shape; // 0x20
	[SerializeField]
	private Vector3 m_Size; // 0x28
	[SerializeField]
	private Quaternion m_Rotation; // 0x34
	private ProBuilderMesh m_Mesh; // 0x48
	[SerializeField]
	private PivotLocation m_PivotLocation; // 0x50
	[SerializeField]
	private Vector3 m_PivotPosition; // 0x54
	[SerializeField]
	internal ushort m_UnmodifiedMeshVersion; // 0x60
	private Bounds m_EditionBounds; // 0x64
	[SerializeField]
	private Bounds m_ShapeBox; // 0x7C

	// Properties
	public Shape shape { get; set; }
	public PivotLocation pivotLocation { get; set; }
	public Vector3 pivotLocalPosition { get; set; }
	public Vector3 pivotGlobalPosition { get; set; }
	public Vector3 size { get; set; }
	public Quaternion rotation { get; set; }
	public Bounds editionBounds { get; }
	public Bounds shapeBox { get; }
	public bool isEditable { get; }
	public ProBuilderMesh mesh { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Shape get_shape() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_shape(Shape value) { }

	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public PivotLocation get_pivotLocation() { }

	// RVA: 0x3AA880 Offset: 0x3A8E80 VA: 0x1803AA880
	public void set_pivotLocation(PivotLocation value) { }

	// RVA: 0x20D6DF0 Offset: 0x20D53F0 VA: 0x1820D6DF0
	public Vector3 get_pivotLocalPosition() { }

	// RVA: 0x20D6EE0 Offset: 0x20D54E0 VA: 0x1820D6EE0
	public void set_pivotLocalPosition(Vector3 value) { }

	// RVA: 0x20D6D70 Offset: 0x20D5370 VA: 0x1820D6D70
	public Vector3 get_pivotGlobalPosition() { }

	// RVA: 0x20D6E60 Offset: 0x20D5460 VA: 0x1820D6E60
	public void set_pivotGlobalPosition(Vector3 value) { }

	// RVA: 0x20D6E40 Offset: 0x20D5440 VA: 0x1820D6E40
	public Vector3 get_size() { }

	// RVA: 0x20D6F00 Offset: 0x20D5500 VA: 0x1820D6F00
	public void set_size(Vector3 value) { }

	// RVA: 0x20D6E10 Offset: 0x20D5410 VA: 0x1820D6E10
	public Quaternion get_rotation() { }

	// RVA: 0x20D6EF0 Offset: 0x20D54F0 VA: 0x1820D6EF0
	public void set_rotation(Quaternion value) { }

	// RVA: 0x20D6B60 Offset: 0x20D5160 VA: 0x1820D6B60
	public Bounds get_editionBounds() { }

	// RVA: 0x20D6E20 Offset: 0x20D5420 VA: 0x1820D6E20
	public Bounds get_shapeBox() { }

	// RVA: 0x20D6C40 Offset: 0x20D5240 VA: 0x1820D6C40
	public bool get_isEditable() { }

	// RVA: 0x20D6C70 Offset: 0x20D5270 VA: 0x1820D6C70
	public ProBuilderMesh get_mesh() { }

	// RVA: 0x20D5A90 Offset: 0x20D4090 VA: 0x1820D5A90
	private void OnValidate() { }

	// RVA: 0x20D6A20 Offset: 0x20D5020 VA: 0x1820D6A20
	internal void UpdateComponent() { }

	// RVA: 0x20D68F0 Offset: 0x20D4EF0 VA: 0x1820D68F0
	internal void UpdateBounds(Bounds bounds) { }

	// RVA: 0x20D6070 Offset: 0x20D4670 VA: 0x1820D6070
	internal void Rebuild(Bounds bounds, Quaternion rotation, Vector3 cornerPivot) { }

	// RVA: 0x20D5E20 Offset: 0x20D4420 VA: 0x1820D5E20
	private void Rebuild() { }

	// RVA: 0x20D65F0 Offset: 0x20D4BF0 VA: 0x1820D65F0
	internal void SetShape(Shape shape, PivotLocation location) { }

	// RVA: 0x20D6420 Offset: 0x20D4A20 VA: 0x1820D6420
	internal void RotateInsideBounds(Quaternion deltaRotation) { }

	// RVA: 0x20D61D0 Offset: 0x20D47D0 VA: 0x1820D61D0
	private void ResetPivot(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20D5B60 Offset: 0x20D4160 VA: 0x1820D5B60
	internal void RebuildPivot(Vector3 size, Quaternion rotation) { }

	// RVA: 0x20D6A80 Offset: 0x20D5080 VA: 0x1820D6A80
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Serializable]
public abstract class Shape // TypeDefIndex: 11690
{
	// Methods

	// RVA: 0x20D7020 Offset: 0x20D5620 VA: 0x1820D7020 Slot: 4
	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void CopyShape(Shape shape);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Usage(4)]
public class ShapeAttribute : Attribute // TypeDefIndex: 11691
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string n) { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Sphere")]
public class Sphere : Shape // TypeDefIndex: 11692
{
	// Fields
	private static readonly Vector3[] k_IcosphereVertices; // 0x0
	private static readonly int[] k_IcosphereTriangles; // 0x8
	[Range(1, 5)]
	[SerializeField]
	private int m_Subdivisions; // 0x10
	private int m_BottomMostVertexIndex; // 0x14
	[SerializeField]
	private bool m_Smooth; // 0x18

	// Methods

	// RVA: 0x20D7070 Offset: 0x20D5670 VA: 0x1820D7070 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20D7020 Offset: 0x20D5620 VA: 0x1820D7020 Slot: 4
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x20D7120 Offset: 0x20D5720 VA: 0x1820D7120 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20D7D90 Offset: 0x20D6390 VA: 0x1820D7D90
	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	// RVA: 0x20D8850 Offset: 0x20D6E50 VA: 0x1820D8850
	public void .ctor() { }

	// RVA: 0x20D8520 Offset: 0x20D6B20 VA: 0x1820D8520
	private static void .cctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Sprite")]
public class Sprite : Shape // TypeDefIndex: 11693
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20D8870 Offset: 0x20D6E70 VA: 0x1820D8870 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
internal enum StepGenerationType // TypeDefIndex: 11694
{
	// Fields
	public int value__; // 0x0
	public const StepGenerationType Height = 0;
	public const StepGenerationType Count = 1;
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Stairs")]
public class Stairs : Shape // TypeDefIndex: 11695
{
	// Fields
	[SerializeField]
	private StepGenerationType m_StepGenerationType; // 0x10
	[Min(0.01)]
	[SerializeField]
	private float m_StepsHeight; // 0x14
	[Range(1, 256)]
	[SerializeField]
	private int m_StepsCount; // 0x18
	[SerializeField]
	private bool m_HomogeneousSteps; // 0x1C
	[Range(-360, 360)]
	[SerializeField]
	private float m_Circumference; // 0x20
	[SerializeField]
	private bool m_Sides; // 0x24
	[SerializeField]
	[Min(0)]
	private float m_InnerRadius; // 0x28

	// Properties
	public bool sides { get; set; }

	// Methods

	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	public bool get_sides() { }

	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	public void set_sides(bool value) { }

	// RVA: 0x20DB620 Offset: 0x20D9C20 VA: 0x1820DB620 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20DB6E0 Offset: 0x20D9CE0 VA: 0x1820DB6E0 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20DB770 Offset: 0x20D9D70 VA: 0x1820DB770 Slot: 4
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x20DA2E0 Offset: 0x20D88E0 VA: 0x1820DA2E0
	private Bounds BuildStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20D8C10 Offset: 0x20D7210 VA: 0x1820D8C10
	private Bounds BuildCurvedStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20DB950 Offset: 0x20D9F50 VA: 0x1820DB950
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.Shapes
[Shape("Torus")]
public class Torus : Shape // TypeDefIndex: 11696
{
	// Fields
	[Range(3, 64)]
	[SerializeField]
	private int m_Rows; // 0x10
	[Range(3, 64)]
	[SerializeField]
	private int m_Columns; // 0x14
	[Min(0.01)]
	[SerializeField]
	private float m_TubeRadius; // 0x18
	[Range(0, 360)]
	[SerializeField]
	private float m_HorizontalCircumference; // 0x1C
	[Range(0, 360)]
	[SerializeField]
	private float m_VerticalCircumference; // 0x20
	[SerializeField]
	private bool m_Smooth; // 0x24

	// Methods

	// RVA: 0x20DB980 Offset: 0x20D9F80 VA: 0x1820DB980 Slot: 6
	public override void CopyShape(Shape shape) { }

	// RVA: 0x20DCEB0 Offset: 0x20DB4B0 VA: 0x1820DCEB0 Slot: 4
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x20DC350 Offset: 0x20DA950 VA: 0x1820DC350 Slot: 5
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x20DBE90 Offset: 0x20DA490 VA: 0x1820DBE90
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	// RVA: 0x20DBA40 Offset: 0x20DA040 VA: 0x1820DBA40
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x20DCF50 Offset: 0x20DB550 VA: 0x1820DCF50
	public void .ctor() { }
}

